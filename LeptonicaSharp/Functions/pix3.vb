Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\pix3.c (155, 1)
' pixSetMasked()
' pixSetMasked(PIX *, PIX *, l_uint32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation.
''' (2) NOTE For cmapped images, this calls pixSetMaskedCmap().
''' %val must be the 32-bit color representation of the RGB pixel.
''' It is not the index into the colormap!
''' (2) If pixm == NULL, a warning is given.
''' (3) This is an implicitly aligned operation, where the UL
''' corners of pixd and pixm coincide.  A warning is
''' issued if the two image sizes differ significantly,
''' but the operation proceeds.
''' (4) Each pixel in pixd that co-locates with an ON pixel
''' in pixm is set to the specified input value.
''' Other pixels in pixd are not changed.
''' (5) You can visualize this as painting the color through
''' the mask, as a stencil.
''' (6) If you do not want to have the UL corners aligned,
''' use the function pixSetMaskedGeneral(), which requires
''' you to input the UL corner of pixm relative to pixd.
''' (7) Implementation details see comments in pixPaintThroughMask()
''' for when we use rasterop to do the painting.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp; or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask; no operation if NULL</param>
'''  <param name="val">[in] - value to set at each masked pixel</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixSetMasked(
				ByVal pixd as Pix, 
				ByVal val as UInteger, 
				Optional ByVal pixm as Pix = Nothing) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetMasked( pixd.Pointer, pixmPTR, val)

	Return _Result
End Function

' SRC\pix3.c (294, 1)
' pixSetMaskedGeneral()
' pixSetMaskedGeneral(PIX *, PIX *, l_uint32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place operation.
''' (2) Alignment is explicit.  If you want the UL corners of
''' the two images to be aligned, use pixSetMasked().
''' (3) A typical use would be painting through the foreground
''' of a small binary mask pixm, located somewhere on a
''' larger pixd.  Other pixels in pixd are not changed.
''' (4) You can visualize this as painting the color through
''' the mask, as a stencil.
''' (5) This uses rasterop to handle clipping and different depths of pixd.
''' (6) If pixd has a colormap, you should call pixPaintThroughMask().
''' (7) Why is this function here, if pixPaintThroughMask() does the
''' same thing, and does it more generally?  I've retained it here
''' to show how one can paint through a mask using only full
''' image rasterops, rather than pixel peeking in pixm and poking
''' in pixd.  It's somewhat baroque, but I found it amusing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8, 16 or 32 bpp</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask; no operation if null</param>
'''  <param name="val">[in] - value to set at each masked pixel</param>
'''  <param name="x">[in] - location of UL corner of pixm relative to pixd; can be negative</param>
'''  <param name="y">[in] - location of UL corner of pixm relative to pixd; can be negative</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixSetMaskedGeneral(
				ByVal pixd as Pix, 
				ByVal val as UInteger, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				Optional ByVal pixm as Pix = Nothing) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetMaskedGeneral( pixd.Pointer, pixmPTR, val, x, y)

	Return _Result
End Function

' SRC\pix3.c (374, 1)
' pixCombineMasked()
' pixCombineMasked(PIX *, PIX *, PIX *) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation; pixd is changed.
''' (2) This sets each pixel in pixd that co-locates with an ON
''' pixel in pixm to the corresponding value of pixs.
''' (3) pixs and pixd must be the same depth and not colormapped.
''' (4) All three input pix are aligned at the UL corner, and the
''' operation is clipped to the intersection of all three images.
''' (5) If pixm == NULL, it's a no-op.
''' (6) Implementation see notes in pixCombineMaskedGeneral().
''' For 8 bpp selective masking, you might guess that it
''' would be faster to generate an 8 bpp version of pixm,
''' using pixConvert1To8(pixm, 0, 255), and then use a
''' general combine operation
''' d = (d  ~m) | (s  m)
''' on a word-by-word basis.  Not always.  The word-by-word
''' combine takes a time that is independent of the mask data.
''' If the mask is relatively sparse, the byte-check method
''' is actually faster!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb; no cmap</param>
'''  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb; no cmap</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask; no operation if NULL</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCombineMasked(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				Optional ByVal pixm as Pix = Nothing) as Integer

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
''' Notes
''' (1) In-place operation; pixd is changed.
''' (2) This is a generalized version of pixCombinedMasked(), where
''' the source and mask can be placed at the same (arbitrary)
''' location relative to pixd.
''' (3) pixs and pixd must be the same depth and not colormapped.
''' (4) The UL corners of both pixs and pixm are aligned with
''' the point (x, y) of pixd, and the operation is clipped to
''' the intersection of all three images.
''' (5) If pixm == NULL, it's a no-op.
''' (6) Implementation.  There are two ways to do these.  In the first,
''' we use rasterop, ORing the part of pixs under the mask
''' with pixd (which has been appropriately cleared there first).
''' In the second, the mask is used one pixel at a time to
''' selectively replace pixels of pixd with those of pixs.
''' Here, we use rasterop for 1 bpp and pixel-wise replacement
''' for 8 and 32 bpp.  To use rasterop for 8 bpp, for example,
''' we must first generate an 8 bpp version of the mask.
''' The code is simple
''' Pix pixm8 = pixConvert1To8(NULL, pixm, 0, 255);
''' Pix pixt = pixAnd(NULL, pixs, pixm8);
''' pixRasterop(pixd, x, y, wmin, hmin, PIX_DST  PIX_NOT(PIX_SRC),
''' pixm8, 0, 0);
''' pixRasterop(pixd, x, y, wmin, hmin, PIX_SRC | PIX_DST,
''' pixt, 0, 0);
''' pixDestroy(pixt);
''' pixDestroy(pixm8);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
'''  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixs and pixm relative to pixd; can be negative</param>
'''  <param name="y">[in] - origin of pixs and pixm relative to pixd; can be negative</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCombineMaskedGeneral(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				Optional ByVal pixm as Pix = Nothing) as Integer

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
''' Notes
''' (1) In-place operation.  Calls pixSetMaskedCmap() for colormapped
''' images.
''' (2) For 1, 2, 4, 8 and 16 bpp gray, we take the appropriate
''' number of least significant bits of val.
''' (3) If pixm == NULL, it's a no-op.
''' (4) The mask origin is placed at (x,y) on pixd, and the
''' operation is clipped to the intersection of rectangles.
''' (5) For rgb, the components in val are in the canonical locations,
''' with red in location COLOR_RED, etc.
''' (6) Implementation detail 1
''' For painting with val == 0 or val == maxval, you can use rasterop.
''' If val == 0, invert the mask so that it's 0 over the region
''' into which you want to write, and use PIX_SRC  PIX_DST to
''' clear those pixels.  To write with val = maxval (all 1's),
''' use PIX_SRC | PIX_DST to set all bits under the mask.
''' (7) Implementation detail 2
''' The rasterop trick can be used for depth GT 1 as well.
''' For val == 0, generate the mask for depth d from the binary
''' mask using
''' pixmd = pixUnpackBinary(pixm, d, 1);
''' and use pixRasterop() with PIX_MASK.  For val == maxval,
''' pixmd = pixUnpackBinary(pixm, d, 0);
''' and use pixRasterop() with PIX_PAINT.
''' But note that if d == 32 bpp, it is about 3x faster to use
''' the general implementation (not pixRasterop()).
''' (8) Implementation detail 3
''' It might be expected that the switch in the inner loop will
''' cause large branching delays and should be avoided.
''' This is not the case, because the entrance is always the
''' same and the compiler can correctly predict the jump.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp; or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixm relative to pixd; can be negative</param>
'''  <param name="y">[in] - origin of pixm relative to pixd; can be negative</param>
'''  <param name="val">[in] - pixel value to set at each masked pixel</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixPaintThroughMask(
				ByVal pixd as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal val as UInteger, 
				Optional ByVal pixm as Pix = Nothing) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixPaintThroughMask( pixd.Pointer, pixmPTR, x, y, val)

	Return _Result
End Function

' SRC\pix3.c (786, 1)
' pixPaintSelfThroughMask()
' pixPaintSelfThroughMask(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation; pixd is changed.
''' (2) If pixm == NULL, it's a no-op.
''' (3) The mask origin is placed at (x,y) on pixd, and the
''' operation is clipped to the intersection of pixd and the
''' fg of the mask.
''' (4) %tsize is the the requested size for tiling.  The actual
''' actual size for each c.c. will be bounded by the minimum
''' dimension of the c.c.
''' (5) For %mindist, %searchdir and %ntiles, see pixFindRepCloseTile().
''' They determine the set of possible tiles that can be used
''' to build a larger mirrored tile to paint onto pixd through
''' the c.c. of pixm.
''' (6) %distblend is used for alpha blending.  It is only applied
''' if there is exactly one c.c. in the mask.  Use distblend == 0
''' to skip blending and just paint through the 1 bpp mask.
''' (7) To apply blending to more than 1 component, call this function
''' repeatedly with %pixm, %x and %y representing one component of
''' the mask each time.  This would be done as follows, for an
''' underlying image pixs and mask pixm of components to fill
''' Boxa boxa = pixConnComp(pixm, pixa, 8);
''' n = boxaGetCount(boxa);
''' for (i = 0; i LT n; i++) {
''' Pix pix = pixaGetPix(pixa, i, L_CLONE);
''' Box box = pixaGetBox(pixa, i, L_CLONE);
''' boxGetGeometry(box, bx, by, bw, bh);
''' pixPaintSelfThroughMask(pixs, pix, bx, by, searchdir,
''' mindist, tilesize, ntiles, distblend);
''' pixDestroy(pix);
''' boxDestroy(box);
''' }
''' pixaDestroy(pixa);
''' boxaDestroy(boxa);
''' (8) If no tiles can be found, this falls back to estimating the
''' color near the boundary of the region to be textured.
''' (9) This can be used to replace the pixels in some regions of
''' an image by selected neighboring pixels.  The mask represents
''' the pixels to be replaced.  For each connected component in
''' the mask, this function selects up to two tiles of neighboring
''' pixels to be used for replacement of pixels represented by
''' the component (i.e., under the FG of that component in the mask).
''' After selection, mirror replication is used to generate an
''' image that is large enough to cover the component.  Alpha
''' blending can also be used outside of the component, but near the
''' edge, to blur the transition between painted and original pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8 bpp gray or 32 bpp rgb; not colormapped</param>
'''  <param name="pixm">[in] - 1 bpp mask</param>
'''  <param name="x">[in] - origin of pixm relative to pixd; must not be negative</param>
'''  <param name="y">[in] - origin of pixm relative to pixd; must not be negative</param>
'''  <param name="searchdir">[in] - L_HORIZ, L_VERT or L_BOTH_DIRECTIONS</param>
'''  <param name="mindist">[in] - min distance of nearest tile edge to box; GT= 0</param>
'''  <param name="tilesize">[in] - requested size for tiling; may be reduced</param>
'''  <param name="ntiles">[in] - number of tiles tested in each row/column</param>
'''  <param name="distblend">[in] - distance outside the fg used for blending with pixs</param>
'''   <returns>0 if OK; 1 on error</returns>
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
''' Notes
''' (1) This generates a 1 bpp mask image, where a 1 is written in
''' the mask for each pixel in pixs that has a value %val.
''' (2) If no pixels have the value, an empty mask is generated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp; can be colormapped</param>
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
''' Notes
''' (1) This generates a 1 bpp mask image, where a 1 is written in
''' the mask for each pixel in pixs that has a value corresponding
''' to a 1 in the LUT.
''' (2) The LUT should be of size 256.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp; can be colormapped</param>
'''  <param name="tab">[in] - 256-entry LUT; 1 means to write to mask</param>
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
''' Notes
''' (1) This generates a 1 bpp mask image, where a 1 is written in
''' the mask for each pixel in pixs that satisfies
''' rc  rval + gc  gval + bc  bval GT thresh
''' where rval is the red component, etc.
''' (2) Unlike with pixConvertToGray(), there are no constraints
''' on the color coefficients, which can be negative.  For
''' example, a mask that discriminates against red and in favor
''' of blue will have rc LT 0.0 and bc GT 0.0.
''' (3) To make the result independent of intensity (the 'V' in HSV),
''' select coefficients so that %thresh = 0.  Then the result
''' is not changed when all components are multiplied by the
''' same constant (as long as nothing saturates).  This can be
''' useful if, for example, the illumination is not uniform.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="rc">[in] - arithmetic factors; can be negative</param>
'''  <param name="gc">[in] - arithmetic factors; can be negative</param>
'''  <param name="bc">[in] - arithmetic factors; can be negative</param>
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
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeArbMaskFromRGB( pixs.Pointer, rc, gc, bc, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1146, 1)
' pixSetUnderTransparency()
' pixSetUnderTransparency(PIX *, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This sets the r, g and b components under every fully
''' transparent alpha component to %val.  The alpha components
''' are unchanged.
''' (2) Full transparency is denoted by alpha == 0.  Setting
''' all pixels to a constant %val where alpha is transparent
''' can improve compressibility by reducing the entropy.
''' (3) The visual result depends on how the image is displayed.
''' (a) For display devices that respect the use of the alpha
''' layer, this will not affect the appearance.
''' (b) For typical leptonica operations, alpha is ignored,
''' so there will be a change in appearance because this
''' resets the rgb values in the fully transparent region.
''' (4) pixRead() and pixWrite() will, by default, read and write
''' 4-component (rgba) pix in png format.  To ignore the alpha
''' component after reading, or omit it on writing, pixSetSpp(..., 3).
''' (5) Here are some examples
''' To convert all fully transparent pixels in a 4 component
''' (rgba) png file to white
''' pixs = pixRead(LTinfileGT);
''' pixd = pixSetUnderTransparency(pixs, 0xffffff00, 0);
''' To write pixd with the alpha component
''' pixWrite(LToutfileGT, pixd, IFF_PNG);
''' To write and rgba image without the alpha component, first do
''' pixSetSpp(pixd, 3);
''' If you later want to use the alpha, spp must be reset to 4.
''' (fancier) To remove the alpha by blending the image over
''' a white background
''' pixRemoveAlpha()
''' This changes all pixel values where the alpha component is
''' not opaque (255).
''' (6) Caution.  rgb images in leptonica typically have value 0 in
''' the alpha channel, which is fully transparent.  If spp for
''' such an image were changed from 3 to 4, the image becomes
''' fully transparent, and this function will set each pixel to %val.
''' If you really want to set every pixel to the same value,
''' use pixSetAllArbitrary().
''' (7) This is useful for compressing an RGBA image where the part
''' of the image that is fully transparent is random junk; compression
''' is typically improved by setting that region to a constant.
''' For rendering as a 3 component RGB image over a uniform
''' background of arbitrary color, use pixAlphaBlendUniform().
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
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSetUnderTransparency( pixs.Pointer, val, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix3.c (1222, 1)
' pixMakeAlphaFromMask()
' pixMakeAlphaFromMask(PIX *, l_int32, BOX **) as PIX *
'''  <summary>
''' Notes
''' (1) This generates a 8 bpp alpha layer that is opaque (256)
''' over the FG of pixs, and goes transparent linearly away
''' from the FG pixels, decaying to 0 (transparent) is an
''' 8-connected distance given by %dist.  If %dist == 0,
''' this does a simple conversion from 1 to 8 bpp.
''' (2) If box == NULL, this returns an alpha mask that is the
''' full size of pixs.  Otherwise, the returned mask pixd covers
''' just the FG pixels of pixs, expanded by %dist in each
''' direction (if possible), and the returned box gives the
''' location of the returned mask relative to pixs.
''' (3) This is useful for painting through a mask and allowing
''' blending of the painted image with an underlying image
''' in the mask background for pixels near foreground mask pixels.
''' For example, with an underlying rgb image pix1, an overlaying
''' image rgb pix2, binary mask pixm, and dist GT 0, this
''' blending is achieved with
''' pix3 = pixMakeAlphaFromMask(pixm, dist, box);
''' boxGetGeometry(box, x, y, NULL, NULL);
''' pix4 = pixBlendWithGrayMask(pix1, pix2, pix3, x, y);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="dist">[in] - blending distance; typically 10 - 30</param>
'''  <param name="pbox">[out][optional] - use NULL to get the full size</param>
'''   <returns>pixd (8 bpp gray, or NULL on error</returns>
Public Shared Function pixMakeAlphaFromMask(
				ByVal pixs as Pix, 
				ByVal dist as Integer, 
				Optional ByRef pbox as Box = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

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
''' Notes
''' (1) This finds the average color in a set of pixels that are
''' roughly a distance %dist from the c.c. boundary and in the
''' background of the mask image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="pixm">[in] - 1 bpp mask, full image</param>
'''  <param name="box">[in] - region of mask; typically b.b. of a component</param>
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
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetColorNearMaskBoundary( pixs.Pointer, pixm.Pointer, box.Pointer, dist, pval, debug)

	Return _Result
End Function

' SRC\pix3.c (1395, 1)
' pixInvert()
' pixInvert(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This inverts pixs, for all pixel depths.
''' (2) There are 3 cases
''' (a) pixd == null,   ~src --GT new pixd
''' (b) pixd == pixs,   ~src --GT src  (in-place)
''' (c) pixd != pixs,   ~src --GT input pixd
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixInvert(NULL, pixs);
''' (b) pixInvert(pixs, pixs);
''' (c) pixInvert(pixd, pixs);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixInvert(
				ByVal pixs as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

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
''' Notes
''' (1) This gives the union of two images with equal depth,
''' aligning them to the the UL corner.  pixs1 and pixs2
''' need not have the same width and height.
''' (2) There are 3 cases
''' (a) pixd == null,   (src1 | src2) --GT new pixd
''' (b) pixd == pixs1,  (src1 | src2) --GT src1  (in-place)
''' (c) pixd != pixs1,  (src1 | src2) --GT input pixd
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOr(NULL, pixs1, pixs2);
''' (b) pixOr(pixs1, pixs1, pixs2);
''' (c) pixOr(pixd, pixs1, pixs2);
''' (4) The size of the result is determined by pixs1.
''' (5) The depths of pixs1 and pixs2 must be equal.
''' (6) Note carefully that the order of pixs1 and pixs2 only matters
''' for the in-place case.  For in-place, you must have
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
''' result the copy puts pixs1 image data in pixs2, and
''' the rasterop is then between pixs2 and pixs2 (a no-op).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixOr(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

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
''' Notes
''' (1) This gives the intersection of two images with equal depth,
''' aligning them to the the UL corner.  pixs1 and pixs2
''' need not have the same width and height.
''' (2) There are 3 cases
''' (a) pixd == null,   (src1  src2) --GT new pixd
''' (b) pixd == pixs1,  (src1  src2) --GT src1  (in-place)
''' (c) pixd != pixs1,  (src1  src2) --GT input pixd
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixAnd(NULL, pixs1, pixs2);
''' (b) pixAnd(pixs1, pixs1, pixs2);
''' (c) pixAnd(pixd, pixs1, pixs2);
''' (4) The size of the result is determined by pixs1.
''' (5) The depths of pixs1 and pixs2 must be equal.
''' (6) Note carefully that the order of pixs1 and pixs2 only matters
''' for the in-place case.  For in-place, you must have
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
''' result the copy puts pixs1 image data in pixs2, and
''' the rasterop is then between pixs2 and pixs2 (a no-op).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixAnd(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

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
''' Notes
''' (1) This gives the XOR of two images with equal depth,
''' aligning them to the the UL corner.  pixs1 and pixs2
''' need not have the same width and height.
''' (2) There are 3 cases
''' (a) pixd == null,   (src1 ^ src2) --GT new pixd
''' (b) pixd == pixs1,  (src1 ^ src2) --GT src1  (in-place)
''' (c) pixd != pixs1,  (src1 ^ src2) --GT input pixd
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixXor(NULL, pixs1, pixs2);
''' (b) pixXor(pixs1, pixs1, pixs2);
''' (c) pixXor(pixd, pixs1, pixs2);
''' (4) The size of the result is determined by pixs1.
''' (5) The depths of pixs1 and pixs2 must be equal.
''' (6) Note carefully that the order of pixs1 and pixs2 only matters
''' for the in-place case.  For in-place, you must have
''' pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
''' result the copy puts pixs1 image data in pixs2, and
''' the rasterop is then between pixs2 and pixs2 (a no-op).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, different from pixs1</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - must be != pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixXor(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

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
''' Notes
''' (1) This gives the set subtraction of two images with equal depth,
''' aligning them to the the UL corner.  pixs1 and pixs2
''' need not have the same width and height.
''' (2) Source pixs2 is always subtracted from source pixs1.
''' The result is
''' pixs1 \ pixs2 = pixs1  (~pixs2)
''' (3) There are 4 cases
''' (a) pixd == null,   (src1 - src2) --GT new pixd
''' (b) pixd == pixs1,  (src1 - src2) --GT src1  (in-place)
''' (c) pixd == pixs2,  (src1 - src2) --GT src2  (in-place)
''' (d) pixd != pixs1  pixd != pixs2),
''' (src1 - src2) --GT input pixd
''' (4) For clarity, if the case is known, use these patterns
''' (a) pixd = pixSubtract(NULL, pixs1, pixs2);
''' (b) pixSubtract(pixs1, pixs1, pixs2);
''' (c) pixSubtract(pixs2, pixs1, pixs2);
''' (d) pixSubtract(pixd, pixs1, pixs2);
''' (5) The size of the result is determined by pixs1.
''' (6) The depths of pixs1 and pixs2 must be equal.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, equal to pixs2, or different from both pixs1 and pixs2</param>
'''  <param name="pixs1">[in] - can be == pixd</param>
'''  <param name="pixs2">[in] - can be == pixd</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSubtract(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

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
''' Notes
''' (1) For a binary image, if there are no fg (black) pixels, empty = 1.
''' (2) For a grayscale image, if all pixels are black (0), empty = 1.
''' (3) For an RGB image, if all 4 components in every pixel is 0,
''' empty = 1.
''' (4) For a colormapped image, pixel values are 0.  The colormap
''' is ignored.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - all depths; colormap OK</param>
'''  <param name="pempty">[out] - 1 if all bits in image data field are 0; 0 otherwise</param>
'''   <returns>0 if OK; 1 on error</returns>
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
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="pfract">[out] - fraction of ON pixels</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixForegroundFraction(
				ByVal pix as Pix, 
				ByRef pfract as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixForegroundFraction( pix.Pointer, pfract)

	Return _Result
End Function

' SRC\pix3.c (1778, 1)
' pixaCountPixels()
' pixaCountPixels(PIXA *) as NUMA *
'''  <summary>
''' 
'''  </summary>
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
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pcount">[out] - count of ON pixels</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCountPixels(
				ByVal pixs as Pix, 
				ByRef pcount as Integer, 
				Optional ByVal tab8 as Integer() = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixels( pixs.Pointer, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (1887, 1)
' pixCountPixelsInRect()
' pixCountPixelsInRect(PIX *, BOX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="box">[in] - (can be null)</param>
'''  <param name="pcount">[out] - count of ON pixels</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCountPixelsInRect(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByRef pcount as Integer, 
				Optional ByVal tab8 as Integer() = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixelsInRect( pixs.Pointer, box.Pointer, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (1931, 1)
' pixCountByRow()
' pixCountByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="box">[in][optional] - clipping box for count; can be null</param>
'''   <returns>na of number of ON pixels by row, or NULL on error</returns>
Public Shared Function pixCountByRow(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountByRow( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (1983, 1)
' pixCountByColumn()
' pixCountByColumn(PIX *, BOX *) as NUMA *
'''  <summary>
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="box">[in][optional] - clipping box for count; can be null</param>
'''   <returns>na of number of ON pixels by column, or NULL on error</returns>
Public Shared Function pixCountByColumn(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2029, 1)
' pixCountPixelsByRow()
' pixCountPixelsByRow(PIX *, l_int32 *) as NUMA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>na of counts, or NULL on error</returns>
Public Shared Function pixCountPixelsByRow(
				ByVal pix as Pix, 
				Optional ByVal tab8 as Integer() = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountPixelsByRow( pix.Pointer, tab8)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2063, 1)
' pixCountPixelsByColumn()
' pixCountPixelsByColumn(PIX *) as NUMA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''   <returns>na of counts in each column, or NULL on error</returns>
Public Shared Function pixCountPixelsByColumn(
				ByVal pix as Pix) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCountPixelsByColumn( pix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2104, 1)
' pixCountPixelsInRow()
' pixCountPixelsInRow(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="row">[in] - number</param>
'''  <param name="pcount">[out] - sum of ON pixels in raster line</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCountPixelsInRow(
				ByVal pix as Pix, 
				ByVal row as Integer, 
				ByRef pcount as Integer, 
				Optional ByVal tab8 as Integer() = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountPixelsInRow( pix.Pointer, row, pcount, tab8)

	Return _Result
End Function

' SRC\pix3.c (2167, 1)
' pixGetMomentByColumn()
' pixGetMomentByColumn(PIX *, l_int32) as NUMA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="order">[in] - of moment, either 1 or 2</param>
'''   <returns>na of first moment of fg pixels, by column, or NULL on error</returns>
Public Shared Function pixGetMomentByColumn(
				ByVal pix as Pix, 
				ByVal order as Integer) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetMomentByColumn( pix.Pointer, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2225, 1)
' pixThresholdPixelSum()
' pixThresholdPixelSum(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This sums the ON pixels and returns immediately if the count
''' goes above threshold.  It is therefore more efficient
''' for matching images (by running this function on the xor of
''' the 2 images) than using pixCountPixels(), which counts all
''' pixels before returning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold</param>
'''  <param name="pabove">[out] - 1 if above threshold; 0 if equal to or less than threshold</param>
'''  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixThresholdPixelSum(
				ByVal pix as Pix, 
				ByVal thresh as Integer, 
				ByRef pabove as Integer, 
				Optional ByVal tab8 as Integer() = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixThresholdPixelSum( pix.Pointer, thresh, pabove, tab8)

	Return _Result
End Function

' SRC\pix3.c (2297, 1)
' makePixelSumTab8()
' makePixelSumTab8() as l_int32 *
'''  <summary>
''' Notes
''' (1) This table of integers gives the number of 1 bits
''' in the 8 bit index.
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
''' Notes
''' (1) This table of integers gives the centroid weight of the 1 bits
''' in the 8 bit index.  In other words, if sumtab is obtained by
''' makePixelSumTab8, and centroidtab is obtained by
''' makePixelCentroidTab8, then, for 1 LT= i LT= 255,
''' centroidtab[i] / (float)sumtab[i]
''' is the centroid of the 1 bits in the 8-bit index i, where the
''' MSB is considered to have position 0 and the LSB is considered
''' to have position 7.
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
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
''' (2) If type == L_BLACK_IS_MAX, black pixels get the maximum
''' value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for sum; can be null</param>
'''  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
'''   <returns>na of pixel averages by row, or NULL on error</returns>
Public Shared Function pixAverageByRow(
				ByVal pix as Pix, 
				ByVal type as Enumerations.L_IS_MAX, 
				Optional ByVal box as Box = Nothing) as Numa

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
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
''' (2) If type == L_BLACK_IS_MAX, black pixels get the maximum
''' value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for sum; can be null</param>
'''  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
'''   <returns>na of pixel averages by column, or NULL on error</returns>
Public Shared Function pixAverageByColumn(
				ByVal pix as Pix, 
				ByVal type as Enumerations.L_IS_MAX, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAverageByColumn( pix.Pointer, boxPTR, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2534, 1)
' pixAverageInRect()
' pixAverageInRect(PIX *, BOX *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1, 2, 4, 8 bpp; not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="pave">[out] - average of pixel values in region</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixAverageInRect(
				ByVal pix as Pix, 
				ByRef pave as Single(), 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixAverageInRect( pix.Pointer, boxPTR, pave)

	Return _Result
End Function

' SRC\pix3.c (2600, 1)
' pixVarianceByRow()
' pixVarianceByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
''' (2) We are actually computing the RMS deviation in each row.
''' This is the square root of the variance.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for variance; can be null</param>
'''   <returns>na of rmsdev by row, or NULL on error</returns>
Public Shared Function pixVarianceByRow(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

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
''' Notes
''' (1) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
''' (2) We are actually computing the RMS deviation in each row.
''' This is the square root of the variance.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 or 16 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for variance; can be null</param>
'''   <returns>na of rmsdev by column, or NULL on error</returns>
Public Shared Function pixVarianceByColumn(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVarianceByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2723, 1)
' pixVarianceInRect()
' pixVarianceInRect(PIX *, BOX *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1, 2, 4, 8 bpp; not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="prootvar">[out] - sqrt variance of pixel values in region</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixVarianceInRect(
				ByVal pix as Pix, 
				ByRef prootvar as Single(), 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixVarianceInRect( pix.Pointer, boxPTR, prootvar)

	Return _Result
End Function

' SRC\pix3.c (2800, 1)
' pixAbsDiffByRow()
' pixAbsDiffByRow(PIX *, BOX *) as NUMA *
'''  <summary>
''' Notes
''' (1) This is an average over differences of adjacent pixels along
''' each row.
''' (2) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for region; can be null</param>
'''   <returns>na of abs val pixel difference averages by row, or NULL on error</returns>
Public Shared Function pixAbsDiffByRow(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {8}.contains (pix.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAbsDiffByRow( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2861, 1)
' pixAbsDiffByColumn()
' pixAbsDiffByColumn(PIX *, BOX *) as NUMA *
'''  <summary>
''' Notes
''' (1) This is an average over differences of adjacent pixels along
''' each column.
''' (2) To resample for a bin size different from 1, use
''' numaUniformSampling() on the result of this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; no colormap</param>
'''  <param name="box">[in][optional] - clipping box for region; can be null</param>
'''   <returns>na of abs val pixel difference averages by column, or NULL on error</returns>
Public Shared Function pixAbsDiffByColumn(
				ByVal pix as Pix, 
				Optional ByVal box as Box = Nothing) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {8}.contains (pix.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAbsDiffByColumn( pix.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pix3.c (2924, 1)
' pixAbsDiffInRect()
' pixAbsDiffInRect(PIX *, BOX *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This gives the average over the abs val of differences of
''' adjacent pixels values, along either each
''' row  dir == L_HORIZONTAL_LINE
''' column  dir == L_VERTICAL_LINE
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; not cmapped</param>
'''  <param name="box">[in][optional] - if null, use entire image</param>
'''  <param name="dir">[in] - differences along L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
'''  <param name="pabsdiff">[out] - average of abs diff pixel values in region</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixAbsDiffInRect(
				ByVal pix as Pix, 
				ByVal dir as Enumerations.L_LINE, 
				ByRef pabsdiff as Single(), 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixAbsDiffInRect( pix.Pointer, boxPTR, dir, pabsdiff)

	Return _Result
End Function

' SRC\pix3.c (3001, 1)
' pixAbsDiffOnLine()
' pixAbsDiffOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This gives the average over the abs val of differences of
''' adjacent pixels values, along a line that is either horizontal
''' or vertical.
''' (2) If horizontal, require x1 LT x2; if vertical, require y1 LT y2.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; not cmapped</param>
'''  <param name="x1">[in] - first point; x1 LT= x2, y1 LT= y2</param>
'''  <param name="y1">[in] - first point; x1 LT= x2, y1 LT= y2</param>
'''  <param name="x2">[in] - first point</param>
'''  <param name="y2">[in] - first point</param>
'''  <param name="pabsdiff">[out] - average of abs diff pixel values on line</param>
'''   <returns>0 if OK; 1 on error</returns>
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
''' Notes
''' (1) If pixs is cmapped, %val is compared to the colormap index;
''' otherwise, %val is compared to the grayscale value.
''' (2) Set the subsampling %factor GT 1 to reduce the amount of computation.
''' If %factor GT 1, multiply the count by %factor  %factor.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="box">[in][optional] - over which count is made; use entire image if NULL</param>
'''  <param name="val">[in] - pixel value to count</param>
'''  <param name="factor">[in] - subsampling factor; integer GT= 1</param>
'''  <param name="pcount">[out] - count; estimate it if factor GT 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixCountArbInRect(
				ByVal pixs as Pix, 
				ByVal val as Integer, 
				ByVal factor as Integer, 
				ByRef pcount as Integer, 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountArbInRect( pixs.Pointer, boxPTR, val, factor, pcount)

	Return _Result
End Function

' SRC\pix3.c (3161, 1)
' pixMirroredTiling()
' pixMirroredTiling(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This uses mirrored tiling, where each row alternates
''' with LR flips and every column alternates with TB
''' flips, such that the result is a tiling with identical
''' 2 x 2 tiles, each of which is composed of these transforms
''' -----------------
''' | 1 |  LR |
''' -----------------
''' | TB   |  LR/TB |
''' -----------------
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp, small tile; to be replicated</param>
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
''' Notes
''' (1) This looks for one or two square tiles with conforming median
''' intensity and low variance, that is outside but near the input box.
''' (2) %mindist specifies the gap between the box and the
''' potential tiles.  The tiles are given an overlap of 50%.
''' %ntiles specifies the number of tiles that are tested
''' beyond %mindist for each row or column.
''' (3) For example, if %mindist = 20, %tilesize = 50 and %ntiles = 3,
''' a horizontal search to the right will have 3 tiles in each row,
''' with left edges at 20, 45 and 70 from the right edge of the
''' input %box.  The number of rows of tiles is determined by
''' the height of %box and %tsize, with the 50% overlap..
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="box">[in] - region of pixs to search around</param>
'''  <param name="searchdir">[in] - L_HORIZ or L_VERT; direction to search</param>
'''  <param name="mindist">[in] - min distance of selected tile edge from box; GT= 0</param>
'''  <param name="tsize">[in] - tile size; GT 1; even; typically ~50</param>
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
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

	Dim pboxtilePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxtile) Then pboxtilePTR = pboxtile.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindRepCloseTile( pixs.Pointer, box.Pointer, searchdir, mindist, tsize, ntiles, pboxtilePTR, debug)
	if pboxtilePTR <> IntPtr.Zero then pboxtile = new Box(pboxtilePTR)

	Return _Result
End Function

End Class
