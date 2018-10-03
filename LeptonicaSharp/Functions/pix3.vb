Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pix3.c (155, 1)
' pixSetMasked()
' pixSetMasked(PIX *, PIX *, l_uint32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place operation.<para/>
''' (2) NOTE: For cmapped images, this calls pixSetMaskedCmap().<para/>
''' %val must be the 32-bit color representation of the RGB pixel.<para/>
''' It is not the index into the colormap!<para/>
''' (2) If pixm == NULL, a warning is given.<para/>
''' (3) This is an implicitly aligned operation, where the UL<para/>
''' corners of pixd and pixm coincide.  A warning is<para/>
''' issued if the two image sizes differ significantly,<para/>
''' but the operation proceeds.<para/>
''' (4) Each pixel in pixd that co-locates with an ON pixel<para/>
''' in pixm is set to the specified input value.<para/>
''' Other pixels in pixd are not changed.<para/>
''' (5) You can visualize this as painting the color through<para/>
''' the mask, as a stencil.<para/>
''' (6) If you do not want to have the UL corners aligned,<para/>
''' use the function pixSetMaskedGeneral(), which requires<para/>
''' you to input the UL corner of pixm relative to pixd.<para/>
''' (7) Implementation details: see comments in pixPaintThroughMask()<para/>
''' for when we use rasterop to do the painting.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask no operation if NULL</param>
'''  <param name="val">[in] - value to set at each masked pixel</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixSetMasked(
				ByVal pixd as Pix, 
				ByVal pixm as Pix, 
				ByVal val as UInteger) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetMasked( pixd.Pointer, pixmPTR, val)

	Return _Result
End Function

' SRC\pix3.c (294, 1)
' pixSetMaskedGeneral()
' pixSetMaskedGeneral(PIX *, PIX *, l_uint32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place operation.<para/>
''' (2) Alignment is explicit.  If you want the UL corners of<para/>
''' the two images to be aligned, use pixSetMasked().<para/>
''' (3) A typical use would be painting through the foreground<para/>
''' of a small binary mask pixm, located somewhere on a<para/>
''' larger pixd.  Other pixels in pixd are not changed.<para/>
''' (4) You can visualize this as painting the color through<para/>
''' the mask, as a stencil.<para/>
''' (5) This uses rasterop to handle clipping and different depths of pixd.<para/>
''' (6) If pixd has a colormap, you should call pixPaintThroughMask().<para/>
''' (7) Why is this function here, if pixPaintThroughMask() does the<para/>
''' same thing, and does it more generally?  I've retained it here<para/>
''' to show how one can paint through a mask using only full<para/>
''' image rasterops, rather than pixel peeking in pixm and poking<para/>
''' in pixd.  It's somewhat baroque, but I found it amusing.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8, 16 or 32 bpp</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask no operation if null</param>
'''  <param name="val">[in] - value to set at each masked pixel</param>
'''  <param name="x">[in] - location of UL corner of pixm relative to pixd can be negative</param>
'''  <param name="y">[in] - location of UL corner of pixm relative to pixd can be negative</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixSetMaskedGeneral(
				ByVal pixd as Pix, 
				ByVal pixm as Pix, 
				ByVal val as UInteger, 
				ByVal x as Integer, 
				ByVal y as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetMaskedGeneral( pixd.Pointer, pixmPTR, val, x, y)

	Return _Result
End Function

' SRC\pix3.c (374, 1)
' pixCombineMasked()
' pixCombineMasked(PIX *, PIX *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place operation pixd is changed.<para/>
''' (2) This sets each pixel in pixd that co-locates with an ON<para/>
''' pixel in pixm to the corresponding value of pixs.<para/>
''' (3) pixs and pixd must be the same depth and not colormapped.<para/>
''' (4) All three input pix are aligned at the UL corner, and the<para/>
''' operation is clipped to the intersection of all three images.<para/>
''' (5) If pixm == NULL, it's a no-op.<para/>
''' (6) Implementation: see notes in pixCombineMaskedGeneral().<para/>
''' For 8 bpp selective masking, you might guess that it<para/>
''' would be faster to generate an 8 bpp version of pixm,<para/>
''' using pixConvert1To8(pixm, 0, 255), and then use a<para/>
''' general combine operation<para/>
''' d = (d  and  ~m) | (s  and  m)<para/>
''' on a word-by-word basis.  Not always.  The word-by-word<para/>
''' combine takes a time that is independent of the mask data.<para/>
''' If the mask is relatively sparse, the byte-check method<para/>
''' is actually faster!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb no cmap</param>
'''  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb no cmap</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask no operation if NULL</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixCombineMasked(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pixm as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCombineMasked( pixd.Pointer, pixs.Pointer, pixmPTR)

	Return _Result
End Function

' SRC\pix3.c (493, 1)
' pixCombineMaskedGeneral()
' pixCombineMaskedGeneral(PIX *, PIX *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place operation pixd is changed.<para/>
''' (2) This is a generalized version of pixCombinedMasked(), where<para/>
''' the source and mask can be placed at the same (arbitrary)<para/>
''' location relative to pixd.<para/>
''' (3) pixs and pixd must be the same depth and not colormapped.<para/>
''' (4) The UL corners of both pixs and pixm are aligned with<para/>
''' the point (x, y) of pixd, and the operation is clipped to<para/>
''' the intersection of all three images.<para/>
''' (5) If pixm == NULL, it's a no-op.<para/>
''' (6) Implementation.  There are two ways to do these.  In the first,<para/>
''' we use rasterop, ORing the part of pixs under the mask<para/>
''' with pixd (which has been appropriately cleared there first).<para/>
''' In the second, the mask is used one pixel at a time to<para/>
''' selectively replace pixels of pixd with those of pixs.<para/>
''' Here, we use rasterop for 1 bpp and pixel-wise replacement<para/>
''' for 8 and 32 bpp.  To use rasterop for 8 bpp, for example,<para/>
''' we must first generate an 8 bpp version of the mask.<para/>
''' The code is simple:<para/>
''' Pix pixm8 = pixConvert1To8(NULL, pixm, 0, 255)<para/>
''' Pix pixt = pixAnd(NULL, pixs, pixm8)<para/>
''' pixRasterop(pixd, x, y, wmin, hmin, PIX_DST  and  PIX_NOT(PIX_SRC),<para/>
''' pixm8, 0, 0)<para/>
''' pixRasterop(pixd, x, y, wmin, hmin, PIX_SRC | PIX_DST,<para/>
''' pixt, 0, 0)<para/>
''' pixDestroy( and pixt)<para/>
''' pixDestroy( and pixm8)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
'''  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixs and pixm relative to pixd can be negative</param>
'''  <param name="y">[in] - origin of pixs and pixm relative to pixd can be negative</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixCombineMaskedGeneral(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCombineMaskedGeneral( pixd.Pointer, pixs.Pointer, pixmPTR, x, y)

	Return _Result
End Function

' SRC\pix3.c (618, 1)
' pixPaintThroughMask()
' pixPaintThroughMask(PIX *, PIX *, l_int32, l_int32, l_uint32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place operation.  Calls pixSetMaskedCmap() for colormapped<para/>
''' images.<para/>
''' (2) For 1, 2, 4, 8 and 16 bpp gray, we take the appropriate<para/>
''' number of least significant bits of val.<para/>
''' (3) If pixm == NULL, it's a no-op.<para/>
''' (4) The mask origin is placed at (x,y) on pixd, and the<para/>
''' operation is clipped to the intersection of rectangles.<para/>
''' (5) For rgb, the components in val are in the canonical locations,<para/>
''' with red in location COLOR_RED, etc.<para/>
''' (6) Implementation detail 1:<para/>
''' For painting with val == 0 or val == maxval, you can use rasterop.<para/>
''' If val == 0, invert the mask so that it's 0 over the region<para/>
''' into which you want to write, and use PIX_SRC  and  PIX_DST to<para/>
''' clear those pixels.  To write with val = maxval (all 1's),<para/>
''' use PIX_SRC | PIX_DST to set all bits under the mask.<para/>
''' (7) Implementation detail 2:<para/>
''' The rasterop trick can be used for depth  is greater  1 as well.<para/>
''' For val == 0, generate the mask for depth d from the binary<para/>
''' mask using<para/>
''' pixmd = pixUnpackBinary(pixm, d, 1)<para/>
''' and use pixRasterop() with PIX_MASK.  For val == maxval,<para/>
''' pixmd = pixUnpackBinary(pixm, d, 0)<para/>
''' and use pixRasterop() with PIX_PAINT.<para/>
''' But note that if d == 32 bpp, it is about 3x faster to use<para/>
''' the general implementation (not pixRasterop()).<para/>
''' (8) Implementation detail 3:<para/>
''' It might be expected that the switch in the inner loop will<para/>
''' cause large branching delays and should be avoided.<para/>
''' This is not the case, because the entrance is always the<para/>
''' same and the compiler can correctly predict the jump.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixm relative to pixd can be negative</param>
'''  <param name="y">[in] - origin of pixm relative to pixd can be negative</param>
'''  <param name="val">[in] - pixel value to set at each masked pixel</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixPaintThroughMask(
				ByVal pixd as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal val as UInteger) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixPaintThroughMask( pixd.Pointer, pixmPTR, x, y, val)

	Return _Result
End Function

' SRC\pix3.c (786, 1)
' pixPaintSelfThroughMask()
' pixPaintSelfThroughMask(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place operation pixd is changed.<para/>
''' (2) If pixm == NULL, it's a no-op.<para/>
''' (3) The mask origin is placed at (x,y) on pixd, and the<para/>
''' operation is clipped to the intersection of pixd and the<para/>
''' fg of the mask.<para/>
''' (4) %tsize is the the requested size for tiling.  The actual<para/>
''' actual size for each c.c. will be bounded by the minimum<para/>
''' dimension of the c.c.<para/>
''' (5) For %mindist, %searchdir and %ntiles, see pixFindRepCloseTile().<para/>
''' They determine the set of possible tiles that can be used<para/>
''' to build a larger mirrored tile to paint onto pixd through<para/>
''' the c.c. of pixm.<para/>
''' (6) %distblend is used for alpha blending.  It is only applied<para/>
''' if there is exactly one c.c. in the mask.  Use distblend == 0<para/>
''' to skip blending and just paint through the 1 bpp mask.<para/>
''' (7) To apply blending to more than 1 component, call this function<para/>
''' repeatedly with %pixm, %x and %y representing one component of<para/>
''' the mask each time.  This would be done as follows, for an<para/>
''' underlying image pixs and mask pixm of components to fill:<para/>
''' Boxa boxa = pixConnComp(pixm,  and pixa, 8)<para/>
''' n = boxaGetCount(boxa)<para/>
''' for (i = 0 i  is lower  n i++) {<para/>
''' Pix pix = pixaGetPix(pixa, i, L_CLONE)<para/>
''' Box box = pixaGetBox(pixa, i, L_CLONE)<para/>
''' boxGetGeometry(box,  and bx,  and by,  and bw,  and bh)<para/>
''' pixPaintSelfThroughMask(pixs, pix, bx, by, searchdir,<para/>
''' mindist, tilesize, ntiles, distblend)<para/>
''' pixDestroy( and pix)<para/>
''' boxDestroy( and box)<para/>
''' }<para/>
''' pixaDestroy( and pixa)<para/>
''' boxaDestroy( and boxa)<para/>
''' (8) If no tiles can be found, this falls back to estimating the<para/>
''' color near the boundary of the region to be textured.<para/>
''' (9) This can be used to replace the pixels in some regions of<para/>
''' an image by selected neighboring pixels.  The mask represents<para/>
''' the pixels to be replaced.  For each connected component in<para/>
''' the mask, this function selects up to two tiles of neighboring<para/>
''' pixels to be used for replacement of pixels represented by<para/>
''' the component (i.e., under the FG of that component in the mask).<para/>
''' After selection, mirror replication is used to generate an<para/>
''' image that is large enough to cover the component.  Alpha<para/>
''' blending can also be used outside of the component, but near the<para/>
''' edge, to blur the transition between painted and original pixels.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8 bpp gray or 32 bpp rgb not colormapped</param>
'''  <param name="pixm">[in] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixm relative to pixd must not be negative</param>
'''  <param name="y">[in] - origin of pixm relative to pixd must not be negative</param>
'''  <param name="searchdir">[in] - L_HORIZ, L_VERT or L_BOTH_DIRECTIONS</param>
'''  <param name="mindist">[in] - min distance of nearest tile edge to box  is greater = 0</param>
'''  <param name="tilesize">[in] - requested size for tiling may be reduced</param>
'''  <param name="ntiles">[in] - number of tiles tested in each row/column</param>
'''  <param name="distblend">[in] - distance outside the fg used for blending with pixs</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixPaintSelfThroughMask(
				ByVal pixd as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal searchdir as Enumerations.L_direction, 
				ByVal mindist as Integer, 
				ByVal tilesize as Integer, 
				ByVal ntiles as Integer, 
				ByVal distblend as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixPaintSelfThroughMask( pixd.Pointer, pixm.Pointer, x, y, searchdir, mindist, tilesize, ntiles, distblend)

	Return _Result
End Function

' SRC\pix3.c (943, 1)
' pixMakeMaskFromVal()
' pixMakeMaskFromVal(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a 1 bpp mask image, where a 1 is written in<para/>
''' the mask for each pixel in pixs that has a value %val.<para/>
''' (2) If no pixels have the value, an empty mask is generated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp can be colormapped</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>pixd 1 bpp mask, or NULL on error</returns>
Public Shared Function pixMakeMaskFromVal(
				ByVal pixs as Pix, 
				ByVal val as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeMaskFromVal( pixs.Pointer, val)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1000, 1)
' pixMakeMaskFromLUT()
' pixMakeMaskFromLUT(PIX *, l_int32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a 1 bpp mask image, where a 1 is written in<para/>
''' the mask for each pixel in pixs that has a value corresponding<para/>
''' to a 1 in the LUT.<para/>
''' (2) The LUT should be of size 256.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp can be colormapped</param>
'''  <param name="tab">[in] - 256-entry LUT 1 means to write to mask</param>
'''   <returns>pixd 1 bpp mask, or NULL on error</returns>
Public Shared Function pixMakeMaskFromLUT(
				ByVal pixs as Pix, 
				ByVal tab as Integer()) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeMaskFromLUT( pixs.Pointer, tab)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1069, 1)
' pixMakeArbMaskFromRGB()
' pixMakeArbMaskFromRGB(PIX *, l_float32, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a 1 bpp mask image, where a 1 is written in<para/>
''' the mask for each pixel in pixs that satisfies<para/>
''' rc  rval + gc  gval + bc  bval  is greater  thresh<para/>
''' where rval is the red component, etc.<para/>
''' (2) Unlike with pixConvertToGray(), there are no constraints<para/>
''' on the color coefficients, which can be negative.  For<para/>
''' example, a mask that discriminates against red and in favor<para/>
''' of blue will have rc  is lower  0.0 and bc  is greater  0.0.<para/>
''' (3) To make the result independent of intensity (the 'V' in HSV),<para/>
''' select coefficients so that %thresh = 0.  Then the result<para/>
''' is not changed when all components are multiplied by the<para/>
''' same constant (as long as nothing saturates).  This can be<para/>
''' useful if, for example, the illumination is not uniform.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="rc">[in] - arithmetic factors can be negative</param>
'''  <param name="gc">[in] - arithmetic factors can be negative</param>
'''  <param name="bc">[in] - arithmetic factors can be negative</param>
'''  <param name="thresh">[in] - lower threshold on weighted sum of components</param>
'''   <returns>pixd 1 bpp mask, or NULL on error</returns>
Public Shared Function pixMakeArbMaskFromRGB(
				ByVal pixs as Pix, 
				ByVal rc as Single, 
				ByVal gc as Single, 
				ByVal bc as Single, 
				ByVal thresh as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rc) then Throw New ArgumentNullException  ("rc cannot be Nothing")
	If IsNothing (gc) then Throw New ArgumentNullException  ("gc cannot be Nothing")
	If IsNothing (bc) then Throw New ArgumentNullException  ("bc cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeArbMaskFromRGB( pixs.Pointer, rc, gc, bc, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1146, 1)
' pixSetUnderTransparency()
' pixSetUnderTransparency(PIX *, l_uint32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This sets the r, g and b components under every fully<para/>
''' transparent alpha component to %val.  The alpha components<para/>
''' are unchanged.<para/>
''' (2) Full transparency is denoted by alpha == 0.  Setting<para/>
''' all pixels to a constant %val where alpha is transparent<para/>
''' can improve compressibility by reducing the entropy.<para/>
''' (3) The visual result depends on how the image is displayed.<para/>
''' (a) For display devices that respect the use of the alpha<para/>
''' layer, this will not affect the appearance.<para/>
''' (b) For typical leptonica operations, alpha is ignored,<para/>
''' so there will be a change in appearance because this<para/>
''' resets the rgb values in the fully transparent region.<para/>
''' (4) pixRead() and pixWrite() will, by default, read and write<para/>
''' 4-component (rgba) pix in png format.  To ignore the alpha<para/>
''' component after reading, or omit it on writing, pixSetSpp(..., 3).<para/>
''' (5) Here are some examples:<para/>
''' To convert all fully transparent pixels in a 4 component<para/>
''' (rgba) png file to white:<para/>
''' pixs = pixRead( is lower infile is greater )<para/>
''' pixd = pixSetUnderTransparency(pixs, 0xffffff00, 0)<para/>
''' To write pixd with the alpha component:<para/>
''' pixWrite( is lower outfile is greater , pixd, IFF_PNG)<para/>
''' To write and rgba image without the alpha component, first do:<para/>
''' pixSetSpp(pixd, 3)<para/>
''' If you later want to use the alpha, spp must be reset to 4.<para/>
''' (fancier) To remove the alpha by blending the image over<para/>
''' a white background:<para/>
''' pixRemoveAlpha()<para/>
''' This changes all pixel values where the alpha component is<para/>
''' not opaque (255).<para/>
''' (6) Caution.  rgb images in leptonica typically have value 0 in<para/>
''' the alpha channel, which is fully transparent.  If spp for<para/>
''' such an image were changed from 3 to 4, the image becomes<para/>
''' fully transparent, and this function will set each pixel to %val.<para/>
''' If you really want to set every pixel to the same value,<para/>
''' use pixSetAllArbitrary().<para/>
''' (7) This is useful for compressing an RGBA image where the part<para/>
''' of the image that is fully transparent is random junk compression<para/>
''' is typically improved by setting that region to a constant.<para/>
''' For rendering as a 3 component RGB image over a uniform<para/>
''' background of arbitrary color, use pixAlphaBlendUniform().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgba</param>
'''  <param name="val">[in] - 32 bit unsigned color to use where alpha == 0</param>
'''  <param name="debug">[in] - displays layers of pixs</param>
'''   <returns>pixd 32 bpp rgba, or NULL on error</returns>
Public Shared Function pixSetUnderTransparency(
				ByVal pixs as Pix, 
				ByVal val as UInteger, 
				ByVal debug as Enumerations.DebugOnOff) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSetUnderTransparency( pixs.Pointer, val, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1222, 1)
' pixMakeAlphaFromMask()
' pixMakeAlphaFromMask(PIX *, l_int32, BOX **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a 8 bpp alpha layer that is opaque (256)<para/>
''' over the FG of pixs, and goes transparent linearly away<para/>
''' from the FG pixels, decaying to 0 (transparent) is an<para/>
''' 8-connected distance given by %dist.  If %dist == 0,<para/>
''' this does a simple conversion from 1 to 8 bpp.<para/>
''' (2) If  and box == NULL, this returns an alpha mask that is the<para/>
''' full size of pixs.  Otherwise, the returned mask pixd covers<para/>
''' just the FG pixels of pixs, expanded by %dist in each<para/>
''' direction (if possible), and the returned box gives the<para/>
''' location of the returned mask relative to pixs.<para/>
''' (3) This is useful for painting through a mask and allowing<para/>
''' blending of the painted image with an underlying image<para/>
''' in the mask background for pixels near foreground mask pixels.<para/>
''' For example, with an underlying rgb image pix1, an overlaying<para/>
''' image rgb pix2, binary mask pixm, and dist  is greater  0, this<para/>
''' blending is achieved with:<para/>
''' pix3 = pixMakeAlphaFromMask(pixm, dist,  and box)<para/>
''' boxGetGeometry(box,  and x,  and y, NULL, NULL)<para/>
''' pix4 = pixBlendWithGrayMask(pix1, pix2, pix3, x, y)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="dist">[in] - blending distance typically 10 - 30</param>
'''  <param name="pbox">[out][optional] - use NULL to get the full size</param>
'''   <returns>pixd (8 bpp gray, or NULL on error</returns>
Public Shared Function pixMakeAlphaFromMask(
				ByVal pixs as Pix, 
				ByVal dist as Integer, 
				ByRef pbox as Box) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeAlphaFromMask( pixs.Pointer, dist, pboxPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1291, 1)
' pixGetColorNearMaskBoundary()
' pixGetColorNearMaskBoundary(PIX *, PIX *, BOX *, l_int32, l_uint32 *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the average color in a set of pixels that are<para/>
''' roughly a distance %dist from the c.c. boundary and in the<para/>
''' background of the mask image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="pixm">[in] - 1 bpp mask, full image</param>
'''  <param name="box">[in] - region of mask typically b.b. of a component</param>
'''  <param name="dist">[in] - distance into BG from mask boundary to use</param>
'''  <param name="pval">[out] - average pixel value</param>
'''  <param name="debug">[in] - 1 to output mask images</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixGetColorNearMaskBoundary(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal box as Box, 
				ByVal dist as Integer, 
				ByRef pval as UInteger, 
				ByVal debug as Enumerations.DebugOnOff) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetColorNearMaskBoundary( pixs.Pointer, pixm.Pointer, box.Pointer, dist, pval, debug)

	Return _Result
End Function

' SRC\pix3.c (1395, 1)
' pixInvert()
' pixInvert(PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This inverts pixs, for all pixel depths.<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null, ~src -- is greater  new pixd<para/>
''' (b) pixd == pixs, ~src -- is greater  src  (in-place)<para/>
''' (c) pixd != pixs, ~src -- is greater  input pixd<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixInvert(NULL, pixs)<para/>
''' (b) pixInvert(pixs, pixs)<para/>
''' (c) pixInvert(pixd, pixs)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixInvert(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixInvert( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1446, 1)
' pixOr()
' pixOr(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the union of two images with equal depth,<para/>
''' aligning them to the the UL corner.  pixs1 and pixs2<para/>
''' need not have the same width and height.<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null, (src1 | src2) -- is greater  new pixd<para/>
''' (b) pixd == pixs1,  (src1 | src2) -- is greater  src1  (in-place)<para/>
''' (c) pixd != pixs1,  (src1 | src2) -- is greater  input pixd<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOr(NULL, pixs1, pixs2)<para/>
''' (b) pixOr(pixs1, pixs1, pixs2)<para/>
''' (c) pixOr(pixd, pixs1, pixs2)<para/>
''' (4) The size of the result is determined by pixs1.<para/>
''' (5) The depths of pixs1 and pixs2 must be equal.<para/>
''' (6) Note carefully that the order of pixs1 and pixs2 only matters<para/>
''' for the in-place case.  For in-place, you must have<para/>
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect<para/>
''' result: the copy puts pixs1 image data in pixs2, and<para/>
''' the rasterop is then between pixs2 and pixs2 (a no-op).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixOr(
				ByVal pixd as Pix, 
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOr( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1510, 1)
' pixAnd()
' pixAnd(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the intersection of two images with equal depth,<para/>
''' aligning them to the the UL corner.  pixs1 and pixs2<para/>
''' need not have the same width and height.<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null, (src1  and  src2) -- is greater  new pixd<para/>
''' (b) pixd == pixs1,  (src1  and  src2) -- is greater  src1  (in-place)<para/>
''' (c) pixd != pixs1,  (src1  and  src2) -- is greater  input pixd<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixAnd(NULL, pixs1, pixs2)<para/>
''' (b) pixAnd(pixs1, pixs1, pixs2)<para/>
''' (c) pixAnd(pixd, pixs1, pixs2)<para/>
''' (4) The size of the result is determined by pixs1.<para/>
''' (5) The depths of pixs1 and pixs2 must be equal.<para/>
''' (6) Note carefully that the order of pixs1 and pixs2 only matters<para/>
''' for the in-place case.  For in-place, you must have<para/>
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect<para/>
''' result: the copy puts pixs1 image data in pixs2, and<para/>
''' the rasterop is then between pixs2 and pixs2 (a no-op).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixAnd(
				ByVal pixd as Pix, 
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAnd( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1574, 1)
' pixXor()
' pixXor(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the XOR of two images with equal depth,<para/>
''' aligning them to the the UL corner.  pixs1 and pixs2<para/>
''' need not have the same width and height.<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null, (src1 ^ src2) -- is greater  new pixd<para/>
''' (b) pixd == pixs1,  (src1 ^ src2) -- is greater  src1  (in-place)<para/>
''' (c) pixd != pixs1,  (src1 ^ src2) -- is greater  input pixd<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixXor(NULL, pixs1, pixs2)<para/>
''' (b) pixXor(pixs1, pixs1, pixs2)<para/>
''' (c) pixXor(pixd, pixs1, pixs2)<para/>
''' (4) The size of the result is determined by pixs1.<para/>
''' (5) The depths of pixs1 and pixs2 must be equal.<para/>
''' (6) Note carefully that the order of pixs1 and pixs2 only matters<para/>
''' for the in-place case.  For in-place, you must have<para/>
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect<para/>
''' result: the copy puts pixs1 image data in pixs2, and<para/>
''' the rasterop is then between pixs2 and pixs2 (a no-op).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixXor(
				ByVal pixd as Pix, 
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixXor( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1639, 1)
' pixSubtract()
' pixSubtract(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the set subtraction of two images with equal depth,<para/>
''' aligning them to the the UL corner.  pixs1 and pixs2<para/>
''' need not have the same width and height.<para/>
''' (2) Source pixs2 is always subtracted from source pixs1.<para/>
''' The result is<para/>
''' pixs1 \ pixs2 = pixs1  and  (~pixs2)<para/>
''' (3) There are 4 cases:<para/>
''' (a) pixd == null, (src1 - src2) -- is greater  new pixd<para/>
''' (b) pixd == pixs1,  (src1 - src2) -- is greater  src1  (in-place)<para/>
''' (c) pixd == pixs2,  (src1 - src2) -- is greater  src2  (in-place)<para/>
''' (d) pixd != pixs1  and  and  pixd != pixs2),<para/>
''' (src1 - src2) -- is greater  input pixd<para/>
''' (4) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixSubtract(NULL, pixs1, pixs2)<para/>
''' (b) pixSubtract(pixs1, pixs1, pixs2)<para/>
''' (c) pixSubtract(pixs2, pixs1, pixs2)<para/>
''' (d) pixSubtract(pixd, pixs1, pixs2)<para/>
''' (5) The size of the result is determined by pixs1.<para/>
''' (6) The depths of pixs1 and pixs2 must be equal.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs1, equal to pixs2, or different from both pixs1 and pixs2</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - can be == pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSubtract(
				ByVal pixd as Pix, 
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSubtract( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1701, 1)
' pixZero()
' pixZero(PIX *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For a binary image, if there are no fg (black) pixels, empty = 1.<para/>
''' (2) For a grayscale image, if all pixels are black (0), empty = 1.<para/>
''' (3) For an RGB image, if all 4 components in every pixel is 0,<para/>
''' empty = 1.<para/>
''' (4) For a colormapped image, pixel values are 0.  The colormap<para/>
''' is ignored.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - all depths colormap OK</param>
'''  <param name="pempty">[out] - 1 if all bits in image data field are 0 0 otherwise</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixZero(
				ByVal pix as Pix, 
				ByRef pempty as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixZero( pix.Pointer, pempty)

	Return _Result
End Function

' SRC\pix3.c (1751, 1)
' pixForegroundFraction()
' pixForegroundFraction(PIX *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="pfract">[out] - fraction of ON pixels</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixForegroundFraction(
				ByVal pix as Pix, 
				ByRef pfract as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixForegroundFraction( pix.Pointer, pfract)

	Return _Result
End Function

' SRC\pix3.c (1778, 1)
' pixaCountPixels()
' pixaCountPixels(PIXA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - array of 1 bpp pix</param>
'''   <returns>na of ON pixels in each pix, or NULL on error</returns>
Public Shared Function pixaCountPixels(
				ByVal pixa as Pixa) as Numa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCountPixels( pixa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (1823, 1)
' pixCountPixels()
' pixCountPixels(PIX *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pcount">[out] - count of ON pixels</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixCountPixels(
				ByVal pixs as Pix, 
				ByRef pcount as Integer, 
				ByVal tab8 as Integer()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixels( pixs.Pointer, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (1887, 1)
' pixCountPixelsInRect()
' pixCountPixelsInRect(PIX *, BOX *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="box">[in] - (can be null)</param>
'''  <param name="pcount">[out] - count of ON pixels</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixCountPixelsInRect(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByRef pcount as Integer, 
				ByVal tab8 as Integer()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixelsInRect( pixs.Pointer, box.Pointer, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (1931, 1)
' pixCountByRow()
' pixCountByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="box">[in][optional] - clipping box for count can be null</param>
'''   <returns>na of number of ON pixels by row, or NULL on error</returns>
Public Shared Function pixCountByRow(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountByRow( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (1983, 1)
' pixCountByColumn()
' pixCountByColumn(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="box">[in][optional] - clipping box for count can be null</param>
'''   <returns>na of number of ON pixels by column, or NULL on error</returns>
Public Shared Function pixCountByColumn(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2029, 1)
' pixCountPixelsByRow()
' pixCountPixelsByRow(PIX *, l_int32 *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>na of counts, or NULL on error</returns>
Public Shared Function pixCountPixelsByRow(
				ByVal pix as Pix, 
				ByVal tab8 as Integer()) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountPixelsByRow( pix.Pointer, tab8)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2063, 1)
' pixCountPixelsByColumn()
' pixCountPixelsByColumn(PIX *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''   <returns>na of counts in each column, or NULL on error</returns>
Public Shared Function pixCountPixelsByColumn(
				ByVal pix as Pix) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountPixelsByColumn( pix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2104, 1)
' pixCountPixelsInRow()
' pixCountPixelsInRow(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="row">[in] - number</param>
'''  <param name="pcount">[out] - sum of ON pixels in raster line</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixCountPixelsInRow(
				ByVal pix as Pix, 
				ByVal row as Integer, 
				ByRef pcount as Integer, 
				ByVal tab8 as Integer()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixelsInRow( pix.Pointer, row, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (2167, 1)
' pixGetMomentByColumn()
' pixGetMomentByColumn(PIX *, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="order">[in] - of moment, either 1 or 2</param>
'''   <returns>na of first moment of fg pixels, by column, or NULL on error</returns>
Public Shared Function pixGetMomentByColumn(
				ByVal pix as Pix, 
				ByVal order as Integer) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetMomentByColumn( pix.Pointer, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2225, 1)
' pixThresholdPixelSum()
' pixThresholdPixelSum(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This sums the ON pixels and returns immediately if the count<para/>
''' goes above threshold.  It is therefore more efficient<para/>
''' for matching images (by running this function on the xor of<para/>
''' the 2 images) than using pixCountPixels(), which counts all<para/>
''' pixels before returning.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold</param>
'''  <param name="pabove">[out] - 1 if above threshold 0 if equal to or less than threshold</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixThresholdPixelSum(
				ByVal pix as Pix, 
				ByVal thresh as Integer, 
				ByRef pabove as Integer, 
				ByVal tab8 as Integer()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixThresholdPixelSum( pix.Pointer, thresh, pabove, tab8)

	Return _Result
End Function

' SRC\pix3.c (2297, 1)
' makePixelSumTab8()
' makePixelSumTab8() as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This table of integers gives the number of 1 bits<para/>
''' in the 8 bit index.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>table of 256 l_int32, or NULL on error</returns>
Public Shared Function makePixelSumTab8() as Integer()



	Dim _Result as Integer() = LeptonicaSharp.Natives.makePixelSumTab8( )

	Return _Result
End Function

' SRC\pix3.c (2342, 1)
' makePixelCentroidTab8()
' makePixelCentroidTab8() as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This table of integers gives the centroid weight of the 1 bits<para/>
''' in the 8 bit index.  In other words, if sumtab is obtained by<para/>
''' makePixelSumTab8, and centroidtab is obtained by<para/>
''' makePixelCentroidTab8, then, for 1  is lower = i  is lower = 255,<para/>
''' centroidtab[i] / (float)sumtab[i]<para/>
''' is the centroid of the 1 bits in the 8-bit index i, where the<para/>
''' MSB is considered to have position 0 and the LSB is considered<para/>
''' to have position 7.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>table of 256 l_int32, or NULL on error</returns>
Public Shared Function makePixelCentroidTab8() as Integer()



	Dim _Result as Integer() = LeptonicaSharp.Natives.makePixelCentroidTab8( )

	Return _Result
End Function

' SRC\pix3.c (2400, 1)
' pixAverageByRow()
' pixAverageByRow(PIX *, BOX *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
''' (2) If type == L_BLACK_IS_MAX, black pixels get the maximum<para/>
''' value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for sum can be null</param>
'''  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
'''   <returns>na of pixel averages by row, or NULL on error</returns>
Public Shared Function pixAverageByRow(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal type as Enumerations.L_IS_MAX) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAverageByRow( pix.Pointer, boxPTR, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2469, 1)
' pixAverageByColumn()
' pixAverageByColumn(PIX *, BOX *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
''' (2) If type == L_BLACK_IS_MAX, black pixels get the maximum<para/>
''' value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for sum can be null</param>
'''  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
'''   <returns>na of pixel averages by column, or NULL on error</returns>
Public Shared Function pixAverageByColumn(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal type as Enumerations.L_IS_MAX) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAverageByColumn( pix.Pointer, boxPTR, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2534, 1)
' pixAverageInRect()
' pixAverageInRect(PIX *, BOX *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1, 2, 4, 8 bpp not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="pave">[out] - average of pixel values in region</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixAverageInRect(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByRef pave as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixAverageInRect( pix.Pointer, boxPTR, pave)

	Return _Result
End Function

' SRC\pix3.c (2600, 1)
' pixVarianceByRow()
' pixVarianceByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
''' (2) We are actually computing the RMS deviation in each row.<para/>
''' This is the square root of the variance.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for variance can be null</param>
'''   <returns>na of rmsdev by row, or NULL on error</returns>
Public Shared Function pixVarianceByRow(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVarianceByRow( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2665, 1)
' pixVarianceByColumn()
' pixVarianceByColumn(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
''' (2) We are actually computing the RMS deviation in each row.<para/>
''' This is the square root of the variance.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for variance can be null</param>
'''   <returns>na of rmsdev by column, or NULL on error</returns>
Public Shared Function pixVarianceByColumn(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVarianceByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2723, 1)
' pixVarianceInRect()
' pixVarianceInRect(PIX *, BOX *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1, 2, 4, 8 bpp not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="prootvar">[out] - sqrt variance of pixel values in region</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixVarianceInRect(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByRef prootvar as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixVarianceInRect( pix.Pointer, boxPTR, prootvar)

	Return _Result
End Function

' SRC\pix3.c (2800, 1)
' pixAbsDiffByRow()
' pixAbsDiffByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an average over differences of adjacent pixels along<para/>
''' each row.<para/>
''' (2) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for region can be null</param>
'''   <returns>na of abs val pixel difference averages by row, or NULL on error</returns>
Public Shared Function pixAbsDiffByRow(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAbsDiffByRow( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2861, 1)
' pixAbsDiffByColumn()
' pixAbsDiffByColumn(PIX *, BOX *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an average over differences of adjacent pixels along<para/>
''' each column.<para/>
''' (2) To resample for a bin size different from 1, use<para/>
''' numaUniformSampling() on the result of this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp no colormap</param>
'''  <param name="box">[in][optional] - clipping box for region can be null</param>
'''   <returns>na of abs val pixel difference averages by column, or NULL on error</returns>
Public Shared Function pixAbsDiffByColumn(
				ByVal pix as Pix, 
				ByVal box as Box) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAbsDiffByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2924, 1)
' pixAbsDiffInRect()
' pixAbsDiffInRect(PIX *, BOX *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the average over the abs val of differences of<para/>
''' adjacent pixels values, along either each<para/>
''' row: dir == L_HORIZONTAL_LINE<para/>
''' column:  dir == L_VERTICAL_LINE<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="dir">[in] - differences along L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
'''  <param name="pabsdiff">[out] - average of abs diff pixel values in region</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixAbsDiffInRect(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal dir as Enumerations.L_LINE, 
				ByRef pabsdiff as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixAbsDiffInRect( pix.Pointer, boxPTR, dir, pabsdiff)

	Return _Result
End Function

' SRC\pix3.c (3001, 1)
' pixAbsDiffOnLine()
' pixAbsDiffOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the average over the abs val of differences of<para/>
''' adjacent pixels values, along a line that is either horizontal<para/>
''' or vertical.<para/>
''' (2) If horizontal, require x1  is lower  x2 if vertical, require y1  is lower  y2.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp not cmapped</param>
'''  <param name="x1">[in] - first point x1  is lower = x2, y1  is lower = y2</param>
'''  <param name="y1">[in] - first point x1  is lower = x2, y1  is lower = y2</param>
'''  <param name="x2">[in] - first point</param>
'''  <param name="y2">[in] - first point</param>
'''  <param name="pabsdiff">[out] - average of abs diff pixel values on line</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixAbsDiffOnLine(
				ByVal pix as Pix, 
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer, 
				ByRef pabsdiff as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAbsDiffOnLine( pix.Pointer, x1, y1, x2, y2, pabsdiff)

	Return _Result
End Function

' SRC\pix3.c (3083, 1)
' pixCountArbInRect()
' pixCountArbInRect(PIX *, BOX *, l_int32, l_int32, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If pixs is cmapped, %val is compared to the colormap index<para/>
''' otherwise, %val is compared to the grayscale value.<para/>
''' (2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.<para/>
''' If %factor  is greater  1, multiply the count by %factor  %factor.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="box">[in][optional] - over which count is made use entire image if NULL</param>
'''  <param name="val">[in] - pixel value to count</param>
'''  <param name="factor">[in] - subsampling factor integer  is greater = 1</param>
'''  <param name="pcount">[out] - count estimate it if factor  is greater  1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixCountArbInRect(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal val as Integer, 
				ByVal factor as Integer, 
				ByRef pcount as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountArbInRect( pixs.Pointer, boxPTR, val, factor, pcount)

	Return _Result
End Function

' SRC\pix3.c (3161, 1)
' pixMirroredTiling()
' pixMirroredTiling(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses mirrored tiling, where each row alternates<para/>
''' with LR flips and every column alternates with TB<para/>
''' flips, such that the result is a tiling with identical<para/>
''' 2 x 2 tiles, each of which is composed of these transforms:<para/>
''' -----------------<para/>
''' | 1  |  LR  |<para/>
''' -----------------<para/>
''' | TB |  LR/TB |<para/>
''' -----------------<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp, small tile to be replicated</param>
'''  <param name="w">[in] - dimensions of output pix</param>
'''  <param name="h">[in] - dimensions of output pix</param>
'''   <returns>pixd usually larger pix, mirror-tiled with pixs, or NULL on error</returns>
Public Shared Function pixMirroredTiling(
				ByVal pixs as Pix, 
				ByVal w as Integer, 
				ByVal h as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMirroredTiling( pixs.Pointer, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (3236, 1)
' pixFindRepCloseTile()
' pixFindRepCloseTile(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, BOX **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This looks for one or two square tiles with conforming median<para/>
''' intensity and low variance, that is outside but near the input box.<para/>
''' (2) %mindist specifies the gap between the box and the<para/>
''' potential tiles.  The tiles are given an overlap of 50%.<para/>
''' %ntiles specifies the number of tiles that are tested<para/>
''' beyond %mindist for each row or column.<para/>
''' (3) For example, if %mindist = 20, %tilesize = 50 and %ntiles = 3,<para/>
''' a horizontal search to the right will have 3 tiles in each row,<para/>
''' with left edges at 20, 45 and 70 from the right edge of the<para/>
''' input %box.  The number of rows of tiles is determined by<para/>
''' the height of %box and %tsize, with the 50% overlap..<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="box">[in] - region of pixs to search around</param>
'''  <param name="searchdir">[in] - L_HORIZ or L_VERT direction to search</param>
'''  <param name="mindist">[in] - min distance of selected tile edge from box  is greater = 0</param>
'''  <param name="tsize">[in] - tile size  is greater  1 even typically ~50</param>
'''  <param name="ntiles">[in] - number of tiles tested in each row/column</param>
'''  <param name="pboxtile">[out] - region of best tile</param>
'''  <param name="debug">[in] - 1    for debug output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindRepCloseTile(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal searchdir as Enumerations.L_direction, 
				ByVal mindist as Integer, 
				ByVal tsize as Integer, 
				ByVal ntiles as Integer, 
				ByRef pboxtile as Box, 
				ByVal debug as Enumerations.DebugOnOff) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pboxtilePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxtile) Then pboxtilePTR = pboxtile.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindRepCloseTile( pixs.Pointer, box.Pointer, searchdir, mindist, tsize, ntiles, pboxtilePTR, debug)
	if pboxtilePTR <> IntPtr.Zero then pboxtile = new Box(pboxtilePTR)

	Return _Result
End Function

End Class
