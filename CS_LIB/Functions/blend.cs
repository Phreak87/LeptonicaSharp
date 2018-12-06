using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// blend.c (174, 1)
// pixBlend(pixs1, pixs2, x, y, fract) as Pix
// pixBlend(PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
///  <summary>
/// (1) This is a simple top-level interface.  For more flexibility,
/// call directly into pixBlendMask(), etc.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlend/*"/>
///  <param name="pixs1">[in] - blendee</param>
///  <param name="pixs2">[in] - blender typ. smaller</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1 can be  is smaller 0</param>
///  <param name="fract">[in] - blending fraction</param>
///   <returns>pixd blended image, or NULL on error</returns>
public static Pix pixBlend(
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract){

	IntPtr _Result = Natives.pixBlend(pixs1.Pointer, pixs2.Pointer,   x,   y,   fract);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (262, 1)
// pixBlendMask(pixd, pixs1, pixs2, x, y, fract, type) as Pix
// pixBlendMask(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) Clipping of pixs2 to pixs1 is done in the inner pixel loop.<para/>
/// 
/// (2) If pixs1 has a colormap, it is removed.<para/>
/// 
/// (3) For inplace operation (pixs1 not cmapped), call it this way:
/// pixBlendMask(pixs1, pixs1, pixs2, ...)<para/>
/// 
/// (4) For generating a new pixd:
/// pixd = pixBlendMask(NULL, pixs1, pixs2, ...)<para/>
/// 
/// (5) Only call in-place if pixs1 does not have a colormap.<para/>
/// 
/// (6) Invalid %fract defaults to 0.5 with a warning.
/// Invalid %type defaults to L_BLEND_WITH_INVERSE with a warning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendMask/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs1 for in-place</param>
///  <param name="pixs1">[in] - blendee, depth  is greater  1</param>
///  <param name="pixs2">[in] - blender, 1 bpp typ. smaller in size than pixs1</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1 can be  is smaller 0</param>
///  <param name="fract">[in] - blending fraction</param>
///  <param name="type">[in] - L_BLEND_WITH_INVERSE, L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
///   <returns>pixd if OK NULL on error</returns>
public static Pix pixBlendMask(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract, 
				 int type){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendMask(pixdPtr, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (489, 1)
// pixBlendGray(pixd, pixs1, pixs2, x, y, fract, type, transparent, transpix) as Pix
// pixBlendGray(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) For inplace operation (pixs1 not cmapped), call it this way:
/// pixBlendGray(pixs1, pixs1, pixs2, ...)<para/>
/// 
/// (2) For generating a new pixd:
/// pixd = pixBlendGray(NULL, pixs1, pixs2, ...)<para/>
/// 
/// (3) Clipping of pixs2 to pixs1 is done in the inner pixel loop.<para/>
/// 
/// (4) If pixs1 has a colormap, it is removed otherwise, if pixs1
/// has depth  is smaller 8, it is unpacked to generate a 8 bpp pix.<para/>
/// 
/// (5) If transparent = 0, the blending fraction (fract) is
/// applied equally to all pixels.<para/>
/// 
/// (6) If transparent = 1, all pixels of value transpix (typically
/// either 0 or 0xff) in pixs2 are transparent in the blend.<para/>
/// 
/// (7) After processing pixs1, it is either 8 bpp or 32 bpp:
/// ~ if 8 bpp, the fraction of pixs2 is mixed with pixs1.
/// ~ if 32 bpp, each component of pixs1 is mixed with
/// the same fraction of pixs2.<para/>
/// 
/// (8) For L_BLEND_GRAY_WITH_INVERSE, the white values of the blendee
/// (cval == 255 in the code below) result in a delta of 0.
/// Thus, these pixels are intrinsically transparent!
/// The "pivot" value of the src, at which no blending occurs, is
/// 128.  Compare with the adaptive pivot in pixBlendGrayAdapt().<para/>
/// 
/// (9) Invalid %fract defaults to 0.5 with a warning.
/// Invalid %type defaults to L_BLEND_GRAY with a warning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendGray/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs1 for in-place</param>
///  <param name="pixs1">[in] - blendee, depth  is greater  1</param>
///  <param name="pixs2">[in] - blender, any depth typ. smaller in size than pixs1</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1 can be  is smaller 0</param>
///  <param name="fract">[in] - blending fraction</param>
///  <param name="type">[in] - L_BLEND_GRAY, L_BLEND_GRAY_WITH_INVERSE</param>
///  <param name="transparent">[in] - 1 to use transparency 0 otherwise</param>
///  <param name="transpix">[in] - pixel grayval in pixs2 that is to be transparent</param>
///   <returns>pixd if OK pixs1 on error</returns>
public static Pix pixBlendGray(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract, 
				 int type, 
				 int transparent, 
				 uint transpix){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendGray(pixdPtr, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract,   type,   transparent,   transpix);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (688, 1)
// pixBlendGrayInverse(pixd, pixs1, pixs2, x, y, fract) as Pix
// pixBlendGrayInverse(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
///  <summary>
/// (1) For inplace operation (pixs1 not cmapped), call it this way:
/// pixBlendGrayInverse(pixs1, pixs1, pixs2, ...)<para/>
/// 
/// (2) For generating a new pixd:
/// pixd = pixBlendGrayInverse(NULL, pixs1, pixs2, ...)<para/>
/// 
/// (3) Clipping of pixs2 to pixs1 is done in the inner pixel loop.<para/>
/// 
/// (4) If pixs1 has a colormap, it is removed otherwise if pixs1
/// has depth  is smaller 8, it is unpacked to generate a 8 bpp pix.<para/>
/// 
/// (5) This is a no-nonsense blender.  It changes the src1 pixel except
/// when the src1 pixel is midlevel gray.  Use fract == 1 for the most
/// aggressive blending, where, if the gray pixel in pixs2 is 0,
/// we get a complete inversion of the color of the src pixel in pixs1.<para/>
/// 
/// (6) The basic logic is that each component transforms by:
///    d  to  c * d + (1 - c ) * (f * (1 - d) + d * (1 - f))
/// where c is the blender pixel from pixs2,
/// f is %fract,
/// c and d are normalized to [0...1]
/// This has the property that for f == 0 (no blend) or c == 1 (white):
/// d  to  d
/// For c == 0 (black) we get maximum inversion:
/// d  to  f  (1 - d) + d  (1 - f) [inversion by fraction f]
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendGrayInverse/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs1 for in-place</param>
///  <param name="pixs1">[in] - blendee, depth  is greater  1</param>
///  <param name="pixs2">[in] - blender, any depth typ. smaller in size than pixs1</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1 can be  is smaller 0</param>
///  <param name="fract">[in] - blending fraction</param>
///   <returns>pixd if OK pixs1 on error</returns>
public static Pix pixBlendGrayInverse(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendGrayInverse(pixdPtr, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (820, 1)
// pixBlendColor(pixd, pixs1, pixs2, x, y, fract, transparent, transpix) as Pix
// pixBlendColor(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) For inplace operation (pixs1 must be 32 bpp), call it this way:
/// pixBlendColor(pixs1, pixs1, pixs2, ...)<para/>
/// 
/// (2) For generating a new pixd:
/// pixd = pixBlendColor(NULL, pixs1, pixs2, ...)<para/>
/// 
/// (3) If pixs2 is not 32 bpp rgb, it is converted.<para/>
/// 
/// (4) Clipping of pixs2 to pixs1 is done in the inner pixel loop.<para/>
/// 
/// (5) If pixs1 has a colormap, it is removed to generate a 32 bpp pix.<para/>
/// 
/// (6) If pixs1 has depth  is smaller 32, it is unpacked to generate a 32 bpp pix.<para/>
/// 
/// (7) If transparent = 0, the blending fraction (fract) is
/// applied equally to all pixels.<para/>
/// 
/// (8) If transparent = 1, all pixels of value transpix (typically
/// either 0 or 0xffffff00) in pixs2 are transparent in the blend.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendColor/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs1 for in-place</param>
///  <param name="pixs1">[in] - blendee depth  is greater  1</param>
///  <param name="pixs2">[in] - blender, any depth typ. smaller in size than pixs1</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1</param>
///  <param name="fract">[in] - blending fraction</param>
///  <param name="transparent">[in] - 1 to use transparency 0 otherwise</param>
///  <param name="transpix">[in] - pixel color in pixs2 that is to be transparent</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixBlendColor(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract, 
				 int transparent, 
				 uint transpix){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendColor(pixdPtr, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract,   transparent,   transpix);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (932, 1)
// pixBlendColorByChannel(pixd, pixs1, pixs2, x, y, rfract, gfract, bfract, transparent, transpix) as Pix
// pixBlendColorByChannel(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_float32, l_int32, l_uint32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendColorByChannel/*"/>
///   <returns></returns>
public static Pix pixBlendColorByChannel(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single rfract, 
				 Single gfract, 
				 Single bfract, 
				 int transparent, 
				 uint transpix){

	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixs1Ptr = IntPtr.Zero; if (pixs1 != null) {pixs1Ptr = pixs1.Pointer;}
	IntPtr pixs2Ptr = IntPtr.Zero; if (pixs2 != null) {pixs2Ptr = pixs2.Pointer;}

	IntPtr _Result = Natives.pixBlendColorByChannel(pixd.Pointer, pixs1.Pointer, pixs2.Pointer,   x,   y,   rfract,   gfract,   bfract,   transparent,   transpix);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1061, 1)
// pixBlendGrayAdapt(pixd, pixs1, pixs2, x, y, fract, shift) as Pix
// pixBlendGrayAdapt(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) For inplace operation (pixs1 not cmapped), call it this way:
/// pixBlendGrayAdapt(pixs1, pixs1, pixs2, ...)
/// For generating a new pixd:
/// pixd = pixBlendGrayAdapt(NULL, pixs1, pixs2, ...)<para/>
/// 
/// (2) Clipping of pixs2 to pixs1 is done in the inner pixel loop.<para/>
/// 
/// (3) If pixs1 has a colormap, it is removed.<para/>
/// 
/// (4) If pixs1 has depth  is smaller 8, it is unpacked to generate a 8 bpp pix.<para/>
/// 
/// (5) This does a blend with inverse.  Whereas in pixGlendGray(), the
/// zero blend point is where the blendee pixel is 128, here
/// the zero blend point is found adaptively, with respect to the
/// median of the blendee region.  If the median is  is smaller 128,
/// the zero blend point is found from
/// median + shift.
/// Otherwise, if the median greater or equal 128, the zero blend point is
/// median - shift.
/// The purpose of shifting the zero blend point away from the
/// median is to prevent a situation in pixBlendGray() where
/// the median is 128 and the blender is not visible.
/// The default value of shift is 64.<para/>
/// 
/// (6) After processing pixs1, it is either 8 bpp or 32 bpp:
/// ~ if 8 bpp, the fraction of pixs2 is mixed with pixs1.
/// ~ if 32 bpp, each component of pixs1 is mixed with
/// the same fraction of pixs2.<para/>
/// 
/// (7) The darker the blender, the more it mixes with the blendee.
/// A blender value of 0 has maximum mixing a value of 255
/// has no mixing and hence is transparent.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendGrayAdapt/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs1 for in-place</param>
///  <param name="pixs1">[in] - blendee, depth  is greater  1</param>
///  <param name="pixs2">[in] - blender, any depth typ. smaller in size than pixs1</param>
///  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1 can be  is smaller 0</param>
///  <param name="fract">[in] - blending fraction</param>
///  <param name="shift">[in] - greater or equal 0 but smaller or equal 128: shift of zero blend value from median source use -1 for default value</param>
///   <returns>pixd if OK pixs1 on error</returns>
public static Pix pixBlendGrayAdapt(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract, 
				 int shift){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendGrayAdapt(pixdPtr, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract,   shift);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1235, 1)
// pixFadeWithGray(pixs, pixb, factor, type) as Pix
// pixFadeWithGray(PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This function combines two pix aligned to the UL corner they
/// need not be the same size.<para/>
/// 
/// (2) Each pixel in pixb is multiplied by 'factor' divided by 255, and
/// clipped to the range [0 ... 1].  This gives the fade fraction
/// to be applied to pixs.  Fade either to white (L_BLEND_TO_WHITE)
/// or to black (L_BLEND_TO_BLACK).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFadeWithGray/*"/>
///  <param name="pixs">[in] - colormapped or 8 bpp or 32 bpp</param>
///  <param name="pixb">[in] - 8 bpp blender</param>
///  <param name="factor">[in] - multiplicative factor to apply to blender value</param>
///  <param name="type">[in] - L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixFadeWithGray(
				 Pix pixs, 
				 Pix pixb, 
				 Single factor, 
				 int type){

	IntPtr _Result = Natives.pixFadeWithGray(pixs.Pointer, pixb.Pointer,   factor,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1349, 1)
// pixBlendHardLight(pixd, pixs1, pixs2, x, y, fract) as Pix
// pixBlendHardLight(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendHardLight/*"/>
///   <returns></returns>
public static Pix pixBlendHardLight(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int x, 
				 int y, 
				 Single fract){

	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixs1Ptr = IntPtr.Zero; if (pixs1 != null) {pixs1Ptr = pixs1.Pointer;}
	IntPtr pixs2Ptr = IntPtr.Zero; if (pixs2 != null) {pixs2Ptr = pixs2.Pointer;}

	IntPtr _Result = Natives.pixBlendHardLight(pixd.Pointer, pixs1.Pointer, pixs2.Pointer,   x,   y,   fract);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1555, 1)
// pixBlendCmap(pixs, pixb, x, y, sindex) as int
// pixBlendCmap(PIX *, PIX *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This function combines two colormaps, and replaces the pixels
/// in pixs that have a specified color value with those in pixb.<para/>
/// 
/// (2) sindex must be in the existing colormap otherwise an
/// error is returned.  In use, sindex will typically be the index
/// for white (255, 255, 255).<para/>
/// 
/// (3) Blender colors that already exist in the colormap are used
/// others are added.  If any blender colors cannot be
/// stored in the colormap, an error is returned.<para/>
/// 
/// (4) In the implementation, a mapping is generated from each
/// original blender colormap index to the corresponding index
/// in the expanded colormap for pixs.  Then for each pixel in
/// pixs with value sindex, and which is covered by a blender pixel,
/// the new index corresponding to the blender pixel is substituted
/// for sindex.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendCmap/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
///  <param name="pixb">[in] - colormapped blender</param>
///  <param name="x">[in] - UL corner of blender relative to pixs</param>
///  <param name="y">[in] - UL corner of blender relative to pixs</param>
///  <param name="sindex">[in] - colormap index of pixels in pixs to be changed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixBlendCmap(
				 Pix pixs, 
				 Pix pixb, 
				 int x, 
				 int y, 
				 int sindex){

	int _Result = Natives.pixBlendCmap(pixs.Pointer, pixb.Pointer,   x,   y,   sindex);
	
	return _Result;
}

// blend.c (1692, 1)
// pixBlendWithGrayMask(pixs1, pixs2, pixg, x, y) as Pix
// pixBlendWithGrayMask(PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The result is 8 bpp grayscale if both pixs1 and pixs2 are
/// 8 bpp gray.  Otherwise, the result is 32 bpp rgb.<para/>
/// 
/// (2) pixg is an 8 bpp transparency image, where 0 is transparent
/// and 255 is opaque.  It determines the transparency of pixs2
/// when applied over pixs1.  It can be null if pixs2 is rgba,
/// in which case we use the alpha component of pixs2.<para/>
/// 
/// (3) If pixg exists, it need not be the same size as pixs2.
/// However, we assume their UL corners are aligned with each other,
/// and placed at the location (x, y) in pixs1.<para/>
/// 
/// (4) The pixels in pixd are a combination of those in pixs1
/// and pixs2, where the amount from pixs2 is proportional to
/// the value of the pixel (p) in pixg, and the amount from pixs1
/// is proportional to (255 - p).  Thus pixg is a transparency
/// image (usually called an alpha blender) where each pixel
/// can be associated with a pixel in pixs2, and determines
/// the amount of the pixs2 pixel in the final result.
/// For example, if pixg is all 0, pixs2 is transparent and
/// the result in pixd is simply pixs1.<para/>
/// 
/// (5) A typical use is for the pixs2/pixg combination to be
/// a small watermark that is applied to pixs1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendWithGrayMask/*"/>
///  <param name="pixs1">[in] - 8 bpp gray, rgb, rgba or colormapped</param>
///  <param name="pixs2">[in] - 8 bpp gray, rgb, rgba or colormapped</param>
///  <param name="pixg">[in][optional] - 8 bpp gray, for transparency of pixs2 can be null</param>
///  <param name="x">[in] - UL corner of pixs2 and pixg with respect to pixs1</param>
///  <param name="y">[in] - UL corner of pixs2 and pixg with respect to pixs1</param>
///   <returns>pixd blended image, or NULL on error</returns>
public static Pix pixBlendWithGrayMask(
				 Pix pixs1, 
				 Pix pixs2, 
				 Pix pixg, 
				 int x, 
				 int y){

	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}

	IntPtr _Result = Natives.pixBlendWithGrayMask(pixs1.Pointer, pixs2.Pointer, pixgPtr,   x,   y);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1846, 1)
// pixBlendBackgroundToColor(pixd, pixs, box, color, gamma, minval, maxval) as Pix
// pixBlendBackgroundToColor(PIX *, PIX *, BOX *, l_uint32, l_float32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This in effect replaces light background pixels in pixs
/// by the input color.  It does it by alpha blending so that
/// there are no visible artifacts from hard cutoffs.<para/>
/// 
/// (2) If pixd == pixs, this is done in-place.<para/>
/// 
/// (3) If box == NULL, this is performed on all of pixs.<para/>
/// 
/// (4) The alpha component for blending is derived from pixs,
/// by converting to grayscale and enhancing with a TRC.<para/>
/// 
/// (5) The last three arguments specify the TRC operation.
/// Suggested values are: %gamma = 0.3, %minval = 50, %maxval = 200.
/// To skip the TRC, use %gamma == 1, %minval = 0, %maxval = 255.
/// See pixGammaTRC() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendBackgroundToColor/*"/>
///  <param name="pixd">[in]can be NULL - or pixs</param>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="box">[in] - region for blending can be NULL)</param>
///  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
///  <param name="gamma">[in] - args for grayscale TRC mapping</param>
///  <param name="minval">[in] - args for grayscale TRC mapping</param>
///  <param name="maxval">[in] - args for grayscale TRC mapping</param>
///   <returns>pixd always</returns>
public static Pix pixBlendBackgroundToColor(
				 Pix pixd, 
				 Pix pixs, 
				 Box box, 
				 uint color, 
				 Single gamma, 
				 int minval, 
				 int maxval){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixBlendBackgroundToColor(pixdPtr, pixs.Pointer, box.Pointer,   color,   gamma,   minval,   maxval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (1926, 1)
// pixMultiplyByColor(pixd, pixs, box, color) as Pix
// pixMultiplyByColor(PIX *, PIX *, BOX *, l_uint32) as PIX *
///  <summary>
/// (1) This filters all pixels in the specified region by
/// multiplying each component by the input color.
/// This leaves black invariant and transforms white to the
/// input color.<para/>
/// 
/// (2) If pixd == pixs, this is done in-place.<para/>
/// 
/// (3) If box == NULL, this is performed on all of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMultiplyByColor/*"/>
///  <param name="pixd">[in]can be NULL - or pixs</param>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="box">[in] - region for filtering can be NULL)</param>
///  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
///   <returns>pixd always</returns>
public static Pix pixMultiplyByColor(
				 Pix pixd, 
				 Pix pixs, 
				 Box box, 
				 uint color){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixMultiplyByColor(pixdPtr, pixs.Pointer, box.Pointer,   color);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (2004, 1)
// pixAlphaBlendUniform(pixs, color) as Pix
// pixAlphaBlendUniform(PIX *, l_uint32) as PIX *
///  <summary>
/// (1) This is a convenience function that renders 32 bpp RGBA images
/// (with an alpha channel) over a uniform background of
/// value %color.  To render over a white background,
/// use %color = 0xffffff00.  The result is an RGB image.<para/>
/// 
/// (2) If pixs does not have an alpha channel, it returns a clone
/// of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAlphaBlendUniform/*"/>
///  <param name="pixs">[in] - 32 bpp rgba, with alpha</param>
///  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
///   <returns>pixd 32 bpp rgb: pixs blended over uniform color %color, a clone of pixs if no alpha, and NULL on error</returns>
public static Pix pixAlphaBlendUniform(
				 Pix pixs, 
				 uint color){

	IntPtr _Result = Natives.pixAlphaBlendUniform(pixs.Pointer,   color);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (2057, 1)
// pixAddAlphaToBlend(pixs, fract, invert) as Pix
// pixAddAlphaToBlend(PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This is a simple alpha layer generator, where typically white has
/// maximum transparency and black has minimum.<para/>
/// 
/// (2) If %invert == 1, generate the same alpha layer but invert
/// the input image photometrically.  This is useful for blending
/// over dark images, where you want dark regions in pixs, such
/// as text, to be lighter in the blended image.<para/>
/// 
/// (3) The fade %fract gives the minimum transparency (i.e.,
/// maximum opacity).  A small fraction is useful for adding
/// a watermark to an image.<para/>
/// 
/// (4) If pixs has a colormap, it is removed to rgb.<para/>
/// 
/// (5) If pixs already has an alpha layer, it is overwritten.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddAlphaToBlend/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="fract">[in] - fade fraction in the alpha component</param>
///  <param name="invert">[in] - 1 to photometrically invert pixs</param>
///   <returns>pixd 32 bpp with alpha, or NULL on error</returns>
public static Pix pixAddAlphaToBlend(
				 Pix pixs, 
				 Single fract, 
				 int invert){

	IntPtr _Result = Natives.pixAddAlphaToBlend(pixs.Pointer,   fract,   invert);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (2116, 1)
// pixSetAlphaOverWhite(pixs) as Pix
// pixSetAlphaOverWhite(PIX *) as PIX *
///  <summary>
/// (1) The generated alpha component is transparent over white
/// (background) pixels in pixs, and quickly grades to opaque
/// away from the transparent parts.  This is a cheap and
/// dirty alpha generator.  The 2 pixel gradation is useful
/// to blur the boundary between the transparent region
/// (that will render entirely from a backing image) and
/// the remainder which renders from pixs.<para/>
/// 
/// (2) All alpha component bits in pixs are overwritten.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetAlphaOverWhite/*"/>
///  <param name="pixs">[in] - colormapped or 32 bpp rgb no alpha</param>
///   <returns>pixd new pix with meaningful alpha component, or NULL on error</returns>
public static Pix pixSetAlphaOverWhite(
				 Pix pixs){

	IntPtr _Result = Natives.pixSetAlphaOverWhite(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// blend.c (2178, 1)
// pixLinearEdgeFade(pixs, dir, fadeto, distfract, maxfade) as int
// pixLinearEdgeFade(PIX *, l_int32, l_int32, l_float32, l_float32) as l_ok
///  <summary>
/// (1) In-place operation.<para/>
/// 
/// (2) Maximum fading fraction %maxfade occurs at the edge of the image,
/// and the fraction goes to 0 at the fractional distance %distfract
/// from the edge.  %maxfade must be in [0, 1].<para/>
/// 
/// (3) %distrfact must be in [0, 1], and typically it would be smaller or equal 0.5.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLinearEdgeFade/*"/>
///  <param name="pixs">[in] - 8 or 32 bpp no colormap</param>
///  <param name="dir">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
///  <param name="fadeto">[in] - L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
///  <param name="distfract">[in] - fraction of width or height over which fading occurs</param>
///  <param name="maxfade">[in] - fraction of fading at the edge, smaller or equal 1.0</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixLinearEdgeFade(
				 Pix pixs, 
				 int dir, 
				 int fadeto, 
				 Single distfract, 
				 Single maxfade){

	int _Result = Natives.pixLinearEdgeFade(pixs.Pointer,   dir,   fadeto,   distfract,   maxfade);
	
	return _Result;
}


}
}
