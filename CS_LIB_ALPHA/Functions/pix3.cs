using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pix3.c (155, 1)
// pixSetMasked(pixd, pixm, val) as int
// pixSetMasked(PIX *, PIX *, l_uint32) as l_ok
///  <summary>
/// (1) In-place operation.<para/>
/// 
/// (2) NOTE: For cmapped images, this calls pixSetMaskedCmap().
/// %val must be the 32-bit color representation of the RGB pixel.
/// It is not the index into the colormap!<para/>
/// 
/// (2) If pixm == NULL, a warning is given.<para/>
/// 
/// (3) This is an implicitly aligned operation, where the UL
/// corners of pixd and pixm coincide.  A warning is
/// issued if the two image sizes differ significantly,
/// but the operation proceeds.<para/>
/// 
/// (4) Each pixel in pixd that co-locates with an ON pixel
/// in pixm is set to the specified input value.
/// Other pixels in pixd are not changed.<para/>
/// 
/// (5) You can visualize this as painting the color through
/// the mask, as a stencil.<para/>
/// 
/// (6) If you do not want to have the UL corners aligned,
/// use the function pixSetMaskedGeneral(), which requires
/// you to input the UL corner of pixm relative to pixd.<para/>
/// 
/// (7) Implementation details: see comments in pixPaintThroughMask()
/// for when we use rasterop to do the painting.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetMasked/*"/>
///  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp or colormapped</param>
///  <param name="pixm">[in][optional] - 1 bpp mask no operation if NULL</param>
///  <param name="val">[in] - value to set at each masked pixel</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixSetMasked(
				 Pix pixd, 
				 Pix pixm, 
				 uint val){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixSetMasked(pixd.Pointer, pixmPtr,   val);
	
	return _Result;
}

// pix3.c (294, 1)
// pixSetMaskedGeneral(pixd, pixm, val, x, y) as int
// pixSetMaskedGeneral(PIX *, PIX *, l_uint32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) Alignment is explicit.  If you want the UL corners of
/// the two images to be aligned, use pixSetMasked().<para/>
/// 
/// (3) A typical use would be painting through the foreground
/// of a small binary mask pixm, located somewhere on a
/// larger pixd.  Other pixels in pixd are not changed.<para/>
/// 
/// (4) You can visualize this as painting the color through
/// the mask, as a stencil.<para/>
/// 
/// (5) This uses rasterop to handle clipping and different depths of pixd.<para/>
/// 
/// (6) If pixd has a colormap, you should call pixPaintThroughMask().<para/>
/// 
/// (7) Why is this function here, if pixPaintThroughMask() does the
/// same thing, and does it more generally?  I've retained it here
/// to show how one can paint through a mask using only full
/// image rasterops, rather than pixel peeking in pixm and poking
/// in pixd.  It's somewhat baroque, but I found it amusing.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetMaskedGeneral/*"/>
///  <param name="pixd">[in] - 8, 16 or 32 bpp</param>
///  <param name="pixm">[in][optional] - 1 bpp mask no operation if null</param>
///  <param name="val">[in] - value to set at each masked pixel</param>
///  <param name="x">[in] - location of UL corner of pixm relative to pixd can be negative</param>
///  <param name="y">[in] - location of UL corner of pixm relative to pixd can be negative</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixSetMaskedGeneral(
				 Pix pixd, 
				 Pix pixm, 
				 uint val, 
				 int x, 
				 int y){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixSetMaskedGeneral(pixd.Pointer, pixmPtr,   val,   x,   y);
	
	return _Result;
}

// pix3.c (374, 1)
// pixCombineMasked(pixd, pixs, pixm) as int
// pixCombineMasked(PIX *, PIX *, PIX *) as l_ok
///  <summary>
/// (1) In-place operation pixd is changed.<para/>
/// 
/// (2) This sets each pixel in pixd that co-locates with an ON
/// pixel in pixm to the corresponding value of pixs.<para/>
/// 
/// (3) pixs and pixd must be the same depth and not colormapped.<para/>
/// 
/// (4) All three input pix are aligned at the UL corner, and the
/// operation is clipped to the intersection of all three images.<para/>
/// 
/// (5) If pixm == NULL, it's a no-op.<para/>
/// 
/// (6) Implementation: see notes in pixCombineMaskedGeneral().
/// For 8 bpp selective masking, you might guess that it
/// would be faster to generate an 8 bpp version of pixm,
/// using pixConvert1To8(pixm, 0, 255), and then use a
/// general combine operation
/// d = (d [and] ~m) | (s [and] m)
/// on a word-by-word basis.  Not always.  The word-by-word
/// combine takes a time that is independent of the mask data.
/// If the mask is relatively sparse, the byte-check method
/// is actually faster!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCombineMasked/*"/>
///  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb no cmap</param>
///  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb no cmap</param>
///  <param name="pixm">[in][optional] - 1 bpp mask no operation if NULL</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixCombineMasked(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixCombineMasked(pixd.Pointer, pixs.Pointer, pixmPtr);
	
	return _Result;
}

// pix3.c (493, 1)
// pixCombineMaskedGeneral(pixd, pixs, pixm, x, y) as int
// pixCombineMaskedGeneral(PIX *, PIX *, PIX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) In-place operation pixd is changed.<para/>
/// 
/// (2) This is a generalized version of pixCombinedMasked(), where
/// the source and mask can be placed at the same (arbitrary)
/// location relative to pixd.<para/>
/// 
/// (3) pixs and pixd must be the same depth and not colormapped.<para/>
/// 
/// (4) The UL corners of both pixs and pixm are aligned with
/// the point (x, y) of pixd, and the operation is clipped to
/// the intersection of all three images.<para/>
/// 
/// (5) If pixm == NULL, it's a no-op.<para/>
/// 
/// (6) Implementation.  There are two ways to do these.  In the first,
/// we use rasterop, ORing the part of pixs under the mask
/// with pixd (which has been appropriately cleared there first).
/// In the second, the mask is used one pixel at a time to
/// selectively replace pixels of pixd with those of pixs.
/// Here, we use rasterop for 1 bpp and pixel-wise replacement
/// for 8 and 32 bpp.  To use rasterop for 8 bpp, for example,
/// we must first generate an 8 bpp version of the mask.
/// The code is simple:
/// Pix pixm8 = pixConvert1To8(NULL, pixm, 0, 255)
/// Pix pixt = pixAnd(NULL, pixs, pixm8)
/// pixRasterop(pixd, x, y, wmin, hmin, PIX_DST [and] PIX_NOT(PIX_SRC),
/// pixm8, 0, 0)
/// pixRasterop(pixd, x, y, wmin, hmin, PIX_SRC | PIX_DST,
/// pixt, 0, 0)
/// pixDestroy([and]pixt)
/// pixDestroy([and]pixm8)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCombineMaskedGeneral/*"/>
///  <param name="pixd">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
///  <param name="pixs">[in] - 1 bpp, 8 bpp gray or 32 bpp rgb</param>
///  <param name="pixm">[in][optional] - 1 bpp mask</param>
///  <param name="x">[in] - origin of pixs and pixm relative to pixd can be negative</param>
///  <param name="y">[in] - origin of pixs and pixm relative to pixd can be negative</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixCombineMaskedGeneral(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm, 
				 int x, 
				 int y){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixCombineMaskedGeneral(pixd.Pointer, pixs.Pointer, pixmPtr,   x,   y);
	
	return _Result;
}

// pix3.c (618, 1)
// pixPaintThroughMask(pixd, pixm, x, y, val) as int
// pixPaintThroughMask(PIX *, PIX *, l_int32, l_int32, l_uint32) as l_ok
///  <summary>
/// (1) In-place operation.  Calls pixSetMaskedCmap() for colormapped
/// images.<para/>
/// 
/// (2) For 1, 2, 4, 8 and 16 bpp gray, we take the appropriate
/// number of least significant bits of val.<para/>
/// 
/// (3) If pixm == NULL, it's a no-op.<para/>
/// 
/// (4) The mask origin is placed at (x,y) on pixd, and the
/// operation is clipped to the intersection of rectangles.<para/>
/// 
/// (5) For rgb, the components in val are in the canonical locations,
/// with red in location COLOR_RED, etc.<para/>
/// 
/// (6) Implementation detail 1:
/// For painting with val == 0 or val == maxval, you can use rasterop.
/// If val == 0, invert the mask so that it's 0 over the region
/// into which you want to write, and use PIX_SRC [and] PIX_DST to
/// clear those pixels.  To write with val = maxval (all 1's),
/// use PIX_SRC | PIX_DST to set all bits under the mask.<para/>
/// 
/// (7) Implementation detail 2:
/// The rasterop trick can be used for depth  is greater  1 as well.
/// For val == 0, generate the mask for depth d from the binary
/// mask using
/// pixmd = pixUnpackBinary(pixm, d, 1)
/// and use pixRasterop() with PIX_MASK.  For val == maxval,
/// pixmd = pixUnpackBinary(pixm, d, 0)
/// and use pixRasterop() with PIX_PAINT.
/// But note that if d == 32 bpp, it is about 3x faster to use
/// the general implementation (not pixRasterop()).<para/>
/// 
/// (8) Implementation detail 3:
/// It might be expected that the switch in the inner loop will
/// cause large branching delays and should be avoided.
/// This is not the case, because the entrance is always the
/// same and the compiler can correctly predict the jump.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixPaintThroughMask/*"/>
///  <param name="pixd">[in] - 1, 2, 4, 8, 16 or 32 bpp or colormapped</param>
///  <param name="pixm">[in][optional] - 1 bpp mask</param>
///  <param name="x">[in] - origin of pixm relative to pixd can be negative</param>
///  <param name="y">[in] - origin of pixm relative to pixd can be negative</param>
///  <param name="val">[in] - pixel value to set at each masked pixel</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixPaintThroughMask(
				 Pix pixd, 
				 Pix pixm, 
				 int x, 
				 int y, 
				 uint val){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixPaintThroughMask(pixd.Pointer, pixmPtr,   x,   y,   val);
	
	return _Result;
}

// pix3.c (786, 1)
// pixPaintSelfThroughMask(pixd, pixm, x, y, searchdir, mindist, tilesize, ntiles, distblend) as int
// pixPaintSelfThroughMask(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) In-place operation pixd is changed.<para/>
/// 
/// (2) If pixm == NULL, it's a no-op.<para/>
/// 
/// (3) The mask origin is placed at (x,y) on pixd, and the
/// operation is clipped to the intersection of pixd and the
/// fg of the mask.<para/>
/// 
/// (4) %tsize is the the requested size for tiling.  The actual
/// actual size for each c.c. will be bounded by the minimum
/// dimension of the c.c.<para/>
/// 
/// (5) For %mindist, %searchdir and %ntiles, see pixFindRepCloseTile().
/// They determine the set of possible tiles that can be used
/// to build a larger mirrored tile to paint onto pixd through
/// the c.c. of pixm.<para/>
/// 
/// (6) %distblend is used for alpha blending.  It is only applied
/// if there is exactly one c.c. in the mask.  Use distblend == 0
/// to skip blending and just paint through the 1 bpp mask.<para/>
/// 
/// (7) To apply blending to more than 1 component, call this function
/// repeatedly with %pixm, %x and %y representing one component of
/// the mask each time.  This would be done as follows, for an
/// underlying image pixs and mask pixm of components to fill:
/// Boxa boxa = pixConnComp(pixm, [and]pixa, 8)
/// n = boxaGetCount(boxa)
/// for (i = 0 i  is smaller n i++) {
/// Pix pix = pixaGetPix(pixa, i, L_CLONE)
/// Box box = pixaGetBox(pixa, i, L_CLONE)
/// boxGetGeometry(box, [and]bx, [and]by, [and]bw, [and]bh)
/// pixPaintSelfThroughMask(pixs, pix, bx, by, searchdir,
/// mindist, tilesize, ntiles, distblend)
/// pixDestroy([and]pix)
/// boxDestroy([and]box)
/// }
/// pixaDestroy([and]pixa)
/// boxaDestroy([and]boxa)<para/>
/// 
/// (8) If no tiles can be found, this falls back to estimating the
/// color near the boundary of the region to be textured.<para/>
/// 
/// (9) This can be used to replace the pixels in some regions of
/// an image by selected neighboring pixels.  The mask represents
/// the pixels to be replaced.  For each connected component in
/// the mask, this function selects up to two tiles of neighboring
/// pixels to be used for replacement of pixels represented by
/// the component (i.e., under the FG of that component in the mask).
/// After selection, mirror replication is used to generate an
/// image that is large enough to cover the component.  Alpha
/// blending can also be used outside of the component, but near the
/// edge, to blur the transition between painted and original pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixPaintSelfThroughMask/*"/>
///  <param name="pixd">[in] - 8 bpp gray or 32 bpp rgb not colormapped</param>
///  <param name="pixm">[in] - 1 bpp mask</param>
///  <param name="x">[in] - origin of pixm relative to pixd must not be negative</param>
///  <param name="y">[in] - origin of pixm relative to pixd must not be negative</param>
///  <param name="searchdir">[in] - L_HORIZ, L_VERT or L_BOTH_DIRECTIONS</param>
///  <param name="mindist">[in] - min distance of nearest tile edge to box greater or equal 0</param>
///  <param name="tilesize">[in] - requested size for tiling may be reduced</param>
///  <param name="ntiles">[in] - number of tiles tested in each row/column</param>
///  <param name="distblend">[in] - distance outside the fg used for blending with pixs</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixPaintSelfThroughMask(
				 Pix pixd, 
				 Pix pixm, 
				 int x, 
				 int y, 
				 int searchdir, 
				 int mindist, 
				 int tilesize, 
				 int ntiles, 
				 int distblend){

	int _Result = Natives.pixPaintSelfThroughMask(pixd.Pointer, pixm.Pointer,   x,   y,   searchdir,   mindist,   tilesize,   ntiles,   distblend);
	
	return _Result;
}

// pix3.c (943, 1)
// pixMakeMaskFromVal(pixs, val) as Pix
// pixMakeMaskFromVal(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This generates a 1 bpp mask image, where a 1 is written in
/// the mask for each pixel in pixs that has a value %val.<para/>
/// 
/// (2) If no pixels have the value, an empty mask is generated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeMaskFromVal/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp can be colormapped</param>
///  <param name="val">[in] - pixel value</param>
///   <returns>pixd 1 bpp mask, or NULL on error</returns>
public static Pix pixMakeMaskFromVal(
				 Pix pixs, 
				 int val){

	IntPtr _Result = Natives.pixMakeMaskFromVal(pixs.Pointer,   val);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1000, 1)
// pixMakeMaskFromLUT(pixs, tab) as Pix
// pixMakeMaskFromLUT(PIX *, l_int32 *) as PIX *
///  <summary>
/// (1) This generates a 1 bpp mask image, where a 1 is written in
/// the mask for each pixel in pixs that has a value corresponding
/// to a 1 in the LUT.<para/>
/// 
/// (2) The LUT should be of size 256.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeMaskFromLUT/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp can be colormapped</param>
///  <param name="tab">[in] - 256-entry LUT 1 means to write to mask</param>
///   <returns>pixd 1 bpp mask, or NULL on error</returns>
public static Pix pixMakeMaskFromLUT(
				 Pix pixs, 
				 int[] tab){

	IntPtr _Result = Natives.pixMakeMaskFromLUT(pixs.Pointer,   tab);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1069, 1)
// pixMakeArbMaskFromRGB(pixs, rc, gc, bc, thresh) as Pix
// pixMakeArbMaskFromRGB(PIX *, l_float32, l_float32, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This generates a 1 bpp mask image, where a 1 is written in
/// the mask for each pixel in pixs that satisfies
/// rc  rval + gc  gval + bc  bval  is greater  thresh
/// where rval is the red component, etc.<para/>
/// 
/// (2) Unlike with pixConvertToGray(), there are no constraints
/// on the color coefficients, which can be negative.  For
/// example, a mask that discriminates against red and in favor
/// of blue will have rc  is smaller 0.0 and bc  is greater  0.0.<para/>
/// 
/// (3) To make the result independent of intensity (the 'V' in HSV),
/// select coefficients so that %thresh = 0.  Then the result
/// is not changed when all components are multiplied by the
/// same constant (as long as nothing saturates).  This can be
/// useful if, for example, the illumination is not uniform.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeArbMaskFromRGB/*"/>
///  <param name="pixs">[in] - 32 bpp RGB</param>
///  <param name="rc">[in] - arithmetic factors can be negative</param>
///  <param name="gc">[in] - arithmetic factors can be negative</param>
///  <param name="bc">[in] - arithmetic factors can be negative</param>
///  <param name="thresh">[in] - lower threshold on weighted sum of components</param>
///   <returns>pixd 1 bpp mask, or NULL on error</returns>
public static Pix pixMakeArbMaskFromRGB(
				 Pix pixs, 
				 Single rc, 
				 Single gc, 
				 Single bc, 
				 Single thresh){

	IntPtr _Result = Natives.pixMakeArbMaskFromRGB(pixs.Pointer,   rc,   gc,   bc,   thresh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1146, 1)
// pixSetUnderTransparency(pixs, val, debug) as Pix
// pixSetUnderTransparency(PIX *, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) This sets the r, g and b components under every fully
/// transparent alpha component to %val.  The alpha components
/// are unchanged.<para/>
/// 
/// (2) Full transparency is denoted by alpha == 0.  Setting
/// all pixels to a constant %val where alpha is transparent
/// can improve compressibility by reducing the entropy.<para/>
/// 
/// (3) The visual result depends on how the image is displayed.
/// (a) For display devices that respect the use of the alpha
/// layer, this will not affect the appearance.
/// (b) For typical leptonica operations, alpha is ignored,
/// so there will be a change in appearance because this
/// resets the rgb values in the fully transparent region.<para/>
/// 
/// (4) pixRead() and pixWrite() will, by default, read and write
/// 4-component (rgba) pix in png format.  To ignore the alpha
/// component after reading, or omit it on writing, pixSetSpp(..., 3).<para/>
/// 
/// (5) Here are some examples:
/// To convert all fully transparent pixels in a 4 component
/// (rgba) png file to white:
/// pixs = pixRead( is smallerinfile is greater )
/// pixd = pixSetUnderTransparency(pixs, 0xffffff00, 0)
/// To write pixd with the alpha component:
/// pixWrite( is smalleroutfile is greater , pixd, IFF_PNG)
/// To write and rgba image without the alpha component, first do:
/// pixSetSpp(pixd, 3)
/// If you later want to use the alpha, spp must be reset to 4.
/// (fancier) To remove the alpha by blending the image over
/// a white background:
/// pixRemoveAlpha()
/// This changes all pixel values where the alpha component is
/// not opaque (255).<para/>
/// 
/// (6) Caution.  rgb images in leptonica typically have value 0 in
/// the alpha channel, which is fully transparent.  If spp for
/// such an image were changed from 3 to 4, the image becomes
/// fully transparent, and this function will set each pixel to %val.
/// If you really want to set every pixel to the same value,
/// use pixSetAllArbitrary().<para/>
/// 
/// (7) This is useful for compressing an RGBA image where the part
/// of the image that is fully transparent is random junk compression
/// is typically improved by setting that region to a constant.
/// For rendering as a 3 component RGB image over a uniform
/// background of arbitrary color, use pixAlphaBlendUniform().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetUnderTransparency/*"/>
///  <param name="pixs">[in] - 32 bpp rgba</param>
///  <param name="val">[in] - 32 bit unsigned color to use where alpha == 0</param>
///  <param name="debug">[in] - displays layers of pixs</param>
///   <returns>pixd 32 bpp rgba, or NULL on error</returns>
public static Pix pixSetUnderTransparency(
				 Pix pixs, 
				 uint val, 
				 DebugOnOff debug){

	IntPtr _Result = Natives.pixSetUnderTransparency(pixs.Pointer,   val,  (int) debug);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1222, 1)
// pixMakeAlphaFromMask(pixs, dist, pbox) as Pix
// pixMakeAlphaFromMask(PIX *, l_int32, BOX **) as PIX *
///  <summary>
/// (1) This generates a 8 bpp alpha layer that is opaque (256)
/// over the FG of pixs, and goes transparent linearly away
/// from the FG pixels, decaying to 0 (transparent) is an
/// 8-connected distance given by %dist.  If %dist == 0,
/// this does a simple conversion from 1 to 8 bpp.<para/>
/// 
/// (2) If [and]box == NULL, this returns an alpha mask that is the
/// full size of pixs.  Otherwise, the returned mask pixd covers
/// just the FG pixels of pixs, expanded by %dist in each
/// direction (if possible), and the returned box gives the
/// location of the returned mask relative to pixs.<para/>
/// 
/// (3) This is useful for painting through a mask and allowing
/// blending of the painted image with an underlying image
/// in the mask background for pixels near foreground mask pixels.
/// For example, with an underlying rgb image pix1, an overlaying
/// image rgb pix2, binary mask pixm, and dist  is greater  0, this
/// blending is achieved with:
/// pix3 = pixMakeAlphaFromMask(pixm, dist, [and]box)
/// boxGetGeometry(box, [and]x, [and]y, NULL, NULL)
/// pix4 = pixBlendWithGrayMask(pix1, pix2, pix3, x, y)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeAlphaFromMask/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="dist">[in] - blending distance typically 10 - 30</param>
///  <param name="pbox">[out][optional] - use NULL to get the full size</param>
///   <returns>pixd (8 bpp gray, or NULL on error</returns>
public static Pix pixMakeAlphaFromMask(
				 Pix pixs, 
				 int dist, 
				out Box pbox){

	IntPtr pboxPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixMakeAlphaFromMask(pixs.Pointer,   dist, out pboxPtr);
	
	if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1291, 1)
// pixGetColorNearMaskBoundary(pixs, pixm, box, dist, pval, debug) as int
// pixGetColorNearMaskBoundary(PIX *, PIX *, BOX *, l_int32, l_uint32 *, l_int32) as l_ok
///  <summary>
/// (1) This finds the average color in a set of pixels that are
/// roughly a distance %dist from the c.c. boundary and in the
/// background of the mask image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColorNearMaskBoundary/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="pixm">[in] - 1 bpp mask, full image</param>
///  <param name="box">[in] - region of mask typically b.b. of a component</param>
///  <param name="dist">[in] - distance into BG from mask boundary to use</param>
///  <param name="pval">[out] - average pixel value</param>
///  <param name="debug">[in] - 1 to output mask images</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixGetColorNearMaskBoundary(
				 Pix pixs, 
				 Pix pixm, 
				 Box box, 
				 int dist, 
				out uint pval, 
				 DebugOnOff debug){

	int _Result = Natives.pixGetColorNearMaskBoundary(pixs.Pointer, pixm.Pointer, box.Pointer,   dist, out  pval,  (int) debug);
	
	return _Result;
}

// pix3.c (1395, 1)
// pixInvert(pixd, pixs) as Pix
// pixInvert(PIX *, PIX *) as PIX *
///  <summary>
/// (1) This inverts pixs, for all pixel depths.<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null, ~src to new pixd
/// (b) pixd == pixs, ~src to src  (in-place)
/// (c) pixd != pixs, ~src to input pixd<para/>
/// 
/// (3) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixInvert(NULL, pixs)
/// (b) pixInvert(pixs, pixs)
/// (c) pixInvert(pixd, pixs)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixInvert/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - </param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixInvert(
				 Pix pixd, 
				 Pix pixs){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixInvert(pixdPtr, pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1446, 1)
// pixOr(pixd, pixs1, pixs2) as Pix
// pixOr(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This gives the union of two images with equal depth,
/// aligning them to the the UL corner.  pixs1 and pixs2
/// need not have the same width and height.<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null, (src1 | src2) to new pixd
/// (b) pixd == pixs1,  (src1 | src2) to src1  (in-place)
/// (c) pixd != pixs1,  (src1 | src2) to input pixd<para/>
/// 
/// (3) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixOr(NULL, pixs1, pixs2)
/// (b) pixOr(pixs1, pixs1, pixs2)
/// (c) pixOr(pixd, pixs1, pixs2)<para/>
/// 
/// (4) The size of the result is determined by pixs1.<para/>
/// 
/// (5) The depths of pixs1 and pixs2 must be equal.<para/>
/// 
/// (6) Note carefully that the order of pixs1 and pixs2 only matters
/// for the in-place case.  For in-place, you must have
/// pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
/// result: the copy puts pixs1 image data in pixs2, and
/// the rasterop is then between pixs2 and pixs2 (a no-op).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOr/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
///  <param name="pixs1">[in] - can be == pixd</param>
///  <param name="pixs2">[in] - must be != pixd</param>
///   <returns>pixd always</returns>
public static Pix pixOr(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixOr(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1510, 1)
// pixAnd(pixd, pixs1, pixs2) as Pix
// pixAnd(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This gives the intersection of two images with equal depth,
/// aligning them to the the UL corner.  pixs1 and pixs2
/// need not have the same width and height.<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null, (src1 [and] src2) to new pixd
/// (b) pixd == pixs1,  (src1 [and] src2) to src1  (in-place)
/// (c) pixd != pixs1,  (src1 [and] src2) to input pixd<para/>
/// 
/// (3) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixAnd(NULL, pixs1, pixs2)
/// (b) pixAnd(pixs1, pixs1, pixs2)
/// (c) pixAnd(pixd, pixs1, pixs2)<para/>
/// 
/// (4) The size of the result is determined by pixs1.<para/>
/// 
/// (5) The depths of pixs1 and pixs2 must be equal.<para/>
/// 
/// (6) Note carefully that the order of pixs1 and pixs2 only matters
/// for the in-place case.  For in-place, you must have
/// pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
/// result: the copy puts pixs1 image data in pixs2, and
/// the rasterop is then between pixs2 and pixs2 (a no-op).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAnd/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
///  <param name="pixs1">[in] - can be == pixd</param>
///  <param name="pixs2">[in] - must be != pixd</param>
///   <returns>pixd always</returns>
public static Pix pixAnd(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixAnd(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1574, 1)
// pixXor(pixd, pixs1, pixs2) as Pix
// pixXor(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This gives the XOR of two images with equal depth,
/// aligning them to the the UL corner.  pixs1 and pixs2
/// need not have the same width and height.<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null, (src1 ^ src2) to new pixd
/// (b) pixd == pixs1,  (src1 ^ src2) to src1  (in-place)
/// (c) pixd != pixs1,  (src1 ^ src2) to input pixd<para/>
/// 
/// (3) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixXor(NULL, pixs1, pixs2)
/// (b) pixXor(pixs1, pixs1, pixs2)
/// (c) pixXor(pixd, pixs1, pixs2)<para/>
/// 
/// (4) The size of the result is determined by pixs1.<para/>
/// 
/// (5) The depths of pixs1 and pixs2 must be equal.<para/>
/// 
/// (6) Note carefully that the order of pixs1 and pixs2 only matters
/// for the in-place case.  For in-place, you must have
/// pixd == pixs1.  Setting pixd == pixs2 gives an incorrect
/// result: the copy puts pixs1 image data in pixs2, and
/// the rasterop is then between pixs2 and pixs2 (a no-op).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixXor/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, different from pixs1</param>
///  <param name="pixs1">[in] - can be == pixd</param>
///  <param name="pixs2">[in] - must be != pixd</param>
///   <returns>pixd always</returns>
public static Pix pixXor(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixXor(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1639, 1)
// pixSubtract(pixd, pixs1, pixs2) as Pix
// pixSubtract(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This gives the set subtraction of two images with equal depth,
/// aligning them to the the UL corner.  pixs1 and pixs2
/// need not have the same width and height.<para/>
/// 
/// (2) Source pixs2 is always subtracted from source pixs1.
/// The result is
/// pixs1 \ pixs2 = pixs1 [and] (~pixs2)<para/>
/// 
/// (3) There are 4 cases:
/// (a) pixd == null, (src1 - src2) to new pixd
/// (b) pixd == pixs1,  (src1 - src2) to src1  (in-place)
/// (c) pixd == pixs2,  (src1 - src2) to src2  (in-place)
/// (d) pixd != pixs1 [and][and] pixd != pixs2),
/// (src1 - src2) to input pixd<para/>
/// 
/// (4) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixSubtract(NULL, pixs1, pixs2)
/// (b) pixSubtract(pixs1, pixs1, pixs2)
/// (c) pixSubtract(pixs2, pixs1, pixs2)
/// (d) pixSubtract(pixd, pixs1, pixs2)<para/>
/// 
/// (5) The size of the result is determined by pixs1.<para/>
/// 
/// (6) The depths of pixs1 and pixs2 must be equal.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSubtract/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, equal to pixs2, or different from both pixs1 and pixs2</param>
///  <param name="pixs1">[in] - can be == pixd</param>
///  <param name="pixs2">[in] - can be == pixd</param>
///   <returns>pixd always</returns>
public static Pix pixSubtract(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSubtract(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (1701, 1)
// pixZero(pix, pempty) as int
// pixZero(PIX *, l_int32 *) as l_ok
///  <summary>
/// (1) For a binary image, if there are no fg (black) pixels, empty = 1.<para/>
/// 
/// (2) For a grayscale image, if all pixels are black (0), empty = 1.<para/>
/// 
/// (3) For an RGB image, if all 4 components in every pixel is 0,
/// empty = 1.<para/>
/// 
/// (4) For a colormapped image, pixel values are 0.  The colormap
/// is ignored.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixZero/*"/>
///  <param name="pix">[in] - all depths colormap OK</param>
///  <param name="pempty">[out] - 1 if all bits in image data field are 0 0 otherwise</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixZero(
				 Pix pix, 
				out int pempty){

	int _Result = Natives.pixZero(pix.Pointer, out  pempty);
	
	return _Result;
}

// pix3.c (1751, 1)
// pixForegroundFraction(pix, pfract) as int
// pixForegroundFraction(PIX *, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixForegroundFraction/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="pfract">[out] - fraction of ON pixels</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixForegroundFraction(
				 Pix pix, 
				out Single pfract){

	int _Result = Natives.pixForegroundFraction(pix.Pointer, out  pfract);
	
	return _Result;
}

// pix3.c (1778, 1)
// pixaCountPixels(pixa) as Numa
// pixaCountPixels(PIXA *) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCountPixels/*"/>
///  <param name="pixa">[in] - array of 1 bpp pix</param>
///   <returns>na of ON pixels in each pix, or NULL on error</returns>
public static Numa pixaCountPixels(
				 Pixa pixa){

	IntPtr _Result = Natives.pixaCountPixels(pixa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (1823, 1)
// pixCountPixels(pixs, pcount, tab8) as int
// pixCountPixels(PIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountPixels/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="pcount">[out] - count of ON pixels</param>
///  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixCountPixels(
				 Pix pixs, 
				out int pcount, 
				 int[] tab8){

	int _Result = Natives.pixCountPixels(pixs.Pointer, out  pcount,   tab8);
	
	return _Result;
}

// pix3.c (1887, 1)
// pixCountPixelsInRect(pixs, box, pcount, tab8) as int
// pixCountPixelsInRect(PIX *, BOX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountPixelsInRect/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="box">[in] - (can be null)</param>
///  <param name="pcount">[out] - count of ON pixels</param>
///  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixCountPixelsInRect(
				 Pix pixs, 
				 Box box, 
				out int pcount, 
				 int[] tab8){

	int _Result = Natives.pixCountPixelsInRect(pixs.Pointer, box.Pointer, out  pcount,   tab8);
	
	return _Result;
}

// pix3.c (1931, 1)
// pixCountByRow(pix, box) as Numa
// pixCountByRow(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountByRow/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="box">[in][optional] - clipping box for count can be null</param>
///   <returns>na of number of ON pixels by row, or NULL on error</returns>
public static Numa pixCountByRow(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixCountByRow(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (1983, 1)
// pixCountByColumn(pix, box) as Numa
// pixCountByColumn(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountByColumn/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="box">[in][optional] - clipping box for count can be null</param>
///   <returns>na of number of ON pixels by column, or NULL on error</returns>
public static Numa pixCountByColumn(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixCountByColumn(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2029, 1)
// pixCountPixelsByRow(pix, tab8) as Numa
// pixCountPixelsByRow(PIX *, l_int32 *) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountPixelsByRow/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
///   <returns>na of counts, or NULL on error</returns>
public static Numa pixCountPixelsByRow(
				 Pix pix, 
				 int[] tab8){

	IntPtr _Result = Natives.pixCountPixelsByRow(pix.Pointer,   tab8);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2063, 1)
// pixCountPixelsByColumn(pix) as Numa
// pixCountPixelsByColumn(PIX *) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountPixelsByColumn/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///   <returns>na of counts in each column, or NULL on error</returns>
public static Numa pixCountPixelsByColumn(
				 Pix pix){

	IntPtr _Result = Natives.pixCountPixelsByColumn(pix.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2104, 1)
// pixCountPixelsInRow(pix, row, pcount, tab8) as int
// pixCountPixelsInRow(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountPixelsInRow/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="row">[in] - number</param>
///  <param name="pcount">[out] - sum of ON pixels in raster line</param>
///  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixCountPixelsInRow(
				 Pix pix, 
				 int row, 
				out int pcount, 
				 int[] tab8){

	int _Result = Natives.pixCountPixelsInRow(pix.Pointer,   row, out  pcount,   tab8);
	
	return _Result;
}

// pix3.c (2167, 1)
// pixGetMomentByColumn(pix, order) as Numa
// pixGetMomentByColumn(PIX *, l_int32) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetMomentByColumn/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="order">[in] - of moment, either 1 or 2</param>
///   <returns>na of first moment of fg pixels, by column, or NULL on error</returns>
public static Numa pixGetMomentByColumn(
				 Pix pix, 
				 int order){

	IntPtr _Result = Natives.pixGetMomentByColumn(pix.Pointer,   order);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2225, 1)
// pixThresholdPixelSum(pix, thresh, pabove, tab8) as int
// pixThresholdPixelSum(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This sums the ON pixels and returns immediately if the count
/// goes above threshold.  It is therefore more efficient
/// for matching images (by running this function on the xor of
/// the 2 images) than using pixCountPixels(), which counts all
/// pixels before returning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdPixelSum/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="thresh">[in] - threshold</param>
///  <param name="pabove">[out] - 1 if above threshold 0 if equal to or less than threshold</param>
///  <param name="tab8">[in][optional] - 8-bit pixel lookup table</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixThresholdPixelSum(
				 Pix pix, 
				 int thresh, 
				out int pabove, 
				 int[] tab8){

	int _Result = Natives.pixThresholdPixelSum(pix.Pointer,   thresh, out  pabove,   tab8);
	
	return _Result;
}

// pix3.c (2297, 1)
// makePixelSumTab8() as int[]
// makePixelSumTab8() as l_int32 *
///  <summary>
/// (1) This table of integers gives the number of 1 bits
/// in the 8 bit index.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makePixelSumTab8/*"/>
///   <returns>table of 256 l_int32, or NULL on error</returns>
public static int[] makePixelSumTab8(){

	int[] _Result = Natives.makePixelSumTab8();
	
	return _Result;
}

// pix3.c (2342, 1)
// makePixelCentroidTab8() as int[]
// makePixelCentroidTab8() as l_int32 *
///  <summary>
/// (1) This table of integers gives the centroid weight of the 1 bits
/// in the 8 bit index.  In other words, if sumtab is obtained by
/// makePixelSumTab8, and centroidtab is obtained by
/// makePixelCentroidTab8, then, for 1 smaller or equal i smaller or equal 255,
/// centroidtab[i] / (float)sumtab[i]
/// is the centroid of the 1 bits in the 8-bit index i, where the
/// MSB is considered to have position 0 and the LSB is considered
/// to have position 7.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makePixelCentroidTab8/*"/>
///   <returns>table of 256 l_int32, or NULL on error</returns>
public static int[] makePixelCentroidTab8(){

	int[] _Result = Natives.makePixelCentroidTab8();
	
	return _Result;
}

// pix3.c (2400, 1)
// pixAverageByRow(pix, box, type) as Numa
// pixAverageByRow(PIX *, BOX *, l_int32) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.<para/>
/// 
/// (2) If type == L_BLACK_IS_MAX, black pixels get the maximum
/// value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAverageByRow/*"/>
///  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for sum can be null</param>
///  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
///   <returns>na of pixel averages by row, or NULL on error</returns>
public static Numa pixAverageByRow(
				 Pix pix, 
				 Box box, 
				 int type){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixAverageByRow(pix.Pointer, boxPtr,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2469, 1)
// pixAverageByColumn(pix, box, type) as Numa
// pixAverageByColumn(PIX *, BOX *, l_int32) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.<para/>
/// 
/// (2) If type == L_BLACK_IS_MAX, black pixels get the maximum
/// value (0xff for 8 bpp, 0xffff for 16 bpp) and white get 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAverageByColumn/*"/>
///  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for sum can be null</param>
///  <param name="type">[in] - L_WHITE_IS_MAX, L_BLACK_IS_MAX</param>
///   <returns>na of pixel averages by column, or NULL on error</returns>
public static Numa pixAverageByColumn(
				 Pix pix, 
				 Box box, 
				 int type){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixAverageByColumn(pix.Pointer, boxPtr,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2534, 1)
// pixAverageInRect(pix, box, pave) as int
// pixAverageInRect(PIX *, BOX *, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAverageInRect/*"/>
///  <param name="pix">[in] - 1, 2, 4, 8 bpp not cmapped</param>
///  <param name="box">[in][optional] - if null, use entire image</param>
///  <param name="pave">[out] - average of pixel values in region</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixAverageInRect(
				 Pix pix, 
				 Box box, 
				out Single pave){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixAverageInRect(pix.Pointer, boxPtr, out  pave);
	
	return _Result;
}

// pix3.c (2600, 1)
// pixVarianceByRow(pix, box) as Numa
// pixVarianceByRow(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.<para/>
/// 
/// (2) We are actually computing the RMS deviation in each row.
/// This is the square root of the variance.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVarianceByRow/*"/>
///  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for variance can be null</param>
///   <returns>na of rmsdev by row, or NULL on error</returns>
public static Numa pixVarianceByRow(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixVarianceByRow(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2665, 1)
// pixVarianceByColumn(pix, box) as Numa
// pixVarianceByColumn(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.<para/>
/// 
/// (2) We are actually computing the RMS deviation in each row.
/// This is the square root of the variance.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVarianceByColumn/*"/>
///  <param name="pix">[in] - 8 or 16 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for variance can be null</param>
///   <returns>na of rmsdev by column, or NULL on error</returns>
public static Numa pixVarianceByColumn(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixVarianceByColumn(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2723, 1)
// pixVarianceInRect(pix, box, prootvar) as int
// pixVarianceInRect(PIX *, BOX *, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVarianceInRect/*"/>
///  <param name="pix">[in] - 1, 2, 4, 8 bpp not cmapped</param>
///  <param name="box">[in][optional] - if null, use entire image</param>
///  <param name="prootvar">[out] - sqrt variance of pixel values in region</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixVarianceInRect(
				 Pix pix, 
				 Box box, 
				out Single prootvar){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixVarianceInRect(pix.Pointer, boxPtr, out  prootvar);
	
	return _Result;
}

// pix3.c (2800, 1)
// pixAbsDiffByRow(pix, box) as Numa
// pixAbsDiffByRow(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) This is an average over differences of adjacent pixels along
/// each row.<para/>
/// 
/// (2) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAbsDiffByRow/*"/>
///  <param name="pix">[in] - 8 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for region can be null</param>
///   <returns>na of abs val pixel difference averages by row, or NULL on error</returns>
public static Numa pixAbsDiffByRow(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixAbsDiffByRow(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2861, 1)
// pixAbsDiffByColumn(pix, box) as Numa
// pixAbsDiffByColumn(PIX *, BOX *) as NUMA *
///  <summary>
/// (1) This is an average over differences of adjacent pixels along
/// each column.<para/>
/// 
/// (2) To resample for a bin size different from 1, use
/// numaUniformSampling() on the result of this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAbsDiffByColumn/*"/>
///  <param name="pix">[in] - 8 bpp no colormap</param>
///  <param name="box">[in][optional] - clipping box for region can be null</param>
///   <returns>na of abs val pixel difference averages by column, or NULL on error</returns>
public static Numa pixAbsDiffByColumn(
				 Pix pix, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixAbsDiffByColumn(pix.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pix3.c (2924, 1)
// pixAbsDiffInRect(pix, box, dir, pabsdiff) as int
// pixAbsDiffInRect(PIX *, BOX *, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) This gives the average over the abs val of differences of
/// adjacent pixels values, along either each
/// row: dir == L_HORIZONTAL_LINE
/// column:  dir == L_VERTICAL_LINE
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAbsDiffInRect/*"/>
///  <param name="pix">[in] - 8 bpp not cmapped</param>
///  <param name="box">[in][optional] - if null, use entire image</param>
///  <param name="dir">[in] - differences along L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
///  <param name="pabsdiff">[out] - average of abs diff pixel values in region</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixAbsDiffInRect(
				 Pix pix, 
				 Box box, 
				 int dir, 
				out Single pabsdiff){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixAbsDiffInRect(pix.Pointer, boxPtr,   dir, out  pabsdiff);
	
	return _Result;
}

// pix3.c (3001, 1)
// pixAbsDiffOnLine(pix, x1, y1, x2, y2, pabsdiff) as int
// pixAbsDiffOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) This gives the average over the abs val of differences of
/// adjacent pixels values, along a line that is either horizontal
/// or vertical.<para/>
/// 
/// (2) If horizontal, require x1  is smaller x2 if vertical, require y1  is smaller y2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAbsDiffOnLine/*"/>
///  <param name="pix">[in] - 8 bpp not cmapped</param>
///  <param name="x1">[in] - first point x1 smaller or equal x2, y1 smaller or equal y2</param>
///  <param name="y1">[in] - first point x1 smaller or equal x2, y1 smaller or equal y2</param>
///  <param name="x2">[in] - first point</param>
///  <param name="y2">[in] - first point</param>
///  <param name="pabsdiff">[out] - average of abs diff pixel values on line</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixAbsDiffOnLine(
				 Pix pix, 
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2, 
				out Single pabsdiff){

	int _Result = Natives.pixAbsDiffOnLine(pix.Pointer,   x1,   y1,   x2,   y2, out  pabsdiff);
	
	return _Result;
}

// pix3.c (3083, 1)
// pixCountArbInRect(pixs, box, val, factor, pcount) as int
// pixCountArbInRect(PIX *, BOX *, l_int32, l_int32, l_int32 *) as l_int32
///  <summary>
/// (1) If pixs is cmapped, %val is compared to the colormap index
/// otherwise, %val is compared to the grayscale value.<para/>
/// 
/// (2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.
/// If %factor  is greater  1, multiply the count by %factor  %factor.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountArbInRect/*"/>
///  <param name="pixs">[in] - 8 bpp, or colormapped</param>
///  <param name="box">[in][optional] - over which count is made use entire image if NULL</param>
///  <param name="val">[in] - pixel value to count</param>
///  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
///  <param name="pcount">[out] - count estimate it if factor  is greater  1</param>
///   <returns>na histogram, or NULL on error</returns>
public static int pixCountArbInRect(
				 Pix pixs, 
				 Box box, 
				 int val, 
				 int factor, 
				out int pcount){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixCountArbInRect(pixs.Pointer, boxPtr,   val,   factor, out  pcount);
	
	return _Result;
}

// pix3.c (3161, 1)
// pixMirroredTiling(pixs, w, h) as Pix
// pixMirroredTiling(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This uses mirrored tiling, where each row alternates
/// with LR flips and every column alternates with TB
/// flips, such that the result is a tiling with identical
/// 2 x 2 tiles, each of which is composed of these transforms:
/// -----------------
/// | 1  |  LR  |
/// -----------------
/// | TB |  LR/TB |
/// -----------------
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMirroredTiling/*"/>
///  <param name="pixs">[in] - 8 or 32 bpp, small tile to be replicated</param>
///  <param name="w">[in] - dimensions of output pix</param>
///  <param name="h">[in] - dimensions of output pix</param>
///   <returns>pixd usually larger pix, mirror-tiled with pixs, or NULL on error</returns>
public static Pix pixMirroredTiling(
				 Pix pixs, 
				 int w, 
				 int h){

	IntPtr _Result = Natives.pixMirroredTiling(pixs.Pointer,   w,   h);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pix3.c (3236, 1)
// pixFindRepCloseTile(pixs, box, searchdir, mindist, tsize, ntiles, pboxtile, debug) as int
// pixFindRepCloseTile(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, BOX **, l_int32) as l_ok
///  <summary>
/// (1) This looks for one or two square tiles with conforming median
/// intensity and low variance, that is outside but near the input box.<para/>
/// 
/// (2) %mindist specifies the gap between the box and the
/// potential tiles.  The tiles are given an overlap of 50%.
/// %ntiles specifies the number of tiles that are tested
/// beyond %mindist for each row or column.<para/>
/// 
/// (3) For example, if %mindist = 20, %tilesize = 50 and %ntiles = 3,
/// a horizontal search to the right will have 3 tiles in each row,
/// with left edges at 20, 45 and 70 from the right edge of the
/// input %box.  The number of rows of tiles is determined by
/// the height of %box and %tsize, with the 50% overlap..
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindRepCloseTile/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="box">[in] - region of pixs to search around</param>
///  <param name="searchdir">[in] - L_HORIZ or L_VERT direction to search</param>
///  <param name="mindist">[in] - min distance of selected tile edge from box greater or equal 0</param>
///  <param name="tsize">[in] - tile size  is greater  1 even typically ~50</param>
///  <param name="ntiles">[in] - number of tiles tested in each row/column</param>
///  <param name="pboxtile">[out] - region of best tile</param>
///  <param name="debug">[in] - 1    for debug output</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixFindRepCloseTile(
				 Pix pixs, 
				 Box box, 
				 int searchdir, 
				 int mindist, 
				 int tsize, 
				 int ntiles, 
				out Box pboxtile, 
				 DebugOnOff debug){

	IntPtr pboxtilePtr = IntPtr.Zero;

	int _Result = Natives.pixFindRepCloseTile(pixs.Pointer, box.Pointer,   searchdir,   mindist,   tsize,   ntiles, out pboxtilePtr,  (int) debug);
	
	if (pboxtilePtr == IntPtr.Zero) {pboxtile = null;} else { pboxtile = new Box(pboxtilePtr); };
	return _Result;
}


}
}
