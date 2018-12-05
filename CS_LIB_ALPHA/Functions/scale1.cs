using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// scale1.c (243, 1)
// pixScale(pixs, scalex, scaley) as Pix
// pixScale(PIX *, l_float32, l_float32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScale/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 and 32 bpp</param>
///  <param name="scalex">[in] - </param>
///  <param name="scaley">[in] - </param>
///   <returns>pixd, or NULL on error This function scales 32 bpp RGB 2, 4 or 8 bpp palette color 2, 4, 8 or 16 bpp gray and binary images. When the input has palette color, the colormap is removed and the result is either 8 bpp gray or 32 bpp RGB, depending on whether the colormap has color entries.  Images with 2, 4 or 16 bpp are converted to 8 bpp. Because pixScale is meant to be a very simple interface to a number of scaling functions, including the use of unsharp masking, the type of scaling and the sharpening parameters are chosen by default.  Grayscale and color images are scaled using one of four methods, depending on the scale factors: 1 antialiased subsampling (lowpass filtering followed by subsampling, implemented here by area mapping), for scale factors less than 0.2 2 antialiased subsampling with sharpening, for scale factors between 0.2 and 0.7 3 linear interpolation with sharpening, for scale factors between 0.7 and 1.4 4 linear interpolation without sharpening, for scale factors greater or equal 1.4. One could use subsampling for scale factors very close to 1.0, because it preserves sharp edges.  Linear interpolation blurs edges because the dest pixels will typically straddle two src edge pixels.  Subsmpling removes entire columns and rows, so the edge is not blurred.  However, there are two reasons for not doing this. First, it moves edges, so that a straight line at a large angle to both horizontal and vertical will have noticeable kinks where horizontal and vertical rasters are removed.  Second, although it is very fast, you get good results on sharp edges by applying a sharpening filter. For images with sharp edges, sharpening substantially improves the image quality for scale factors between about 0.2 and about 2.0. pixScale uses a small amount of sharpening by default because it strengthens edge pixels that are weak due to anti-aliasing. The default sharpening factors are: for scaling factors  is smaller 0.7:   sharpfract = 0.2    sharpwidth = 1 for scaling factors greater or equal 0.7:  sharpfract = 0.4    sharpwidth = 2 The cases where the sharpening halfwidth is 1 or 2 have special implementations and are about twice as fast as the general case. However, sharpening is computationally expensive, and one needs to consider the speed-quality tradeoff: For upscaling of RGB images, linear interpolation plus default sharpening is about 5 times slower than upscaling alone. For downscaling, area mapping plus default sharpening is about 10 times slower than downscaling alone. When the scale factor is larger than 1.4, the cost of sharpening, which is proportional to image area, is very large compared to the incremental quality improvement, so we cut off the default use of sharpening at 1.4.  Thus, for scale factors greater than 1.4, pixScale only does linear interpolation. In many situations you will get a satisfactory result by scaling without sharpening: call pixScaleGeneral with %sharpfract = 0.0. Alternatively, if you wish to sharpen but not use the default value, first call pixScaleGeneral with %sharpfract = 0.0, and then sharpen explicitly using pixUnsharpMasking. Binary images are scaled to binary by sampling the closest pixel, without any low-pass filtering averaging of neighboring pixels. This will introduce aliasing for reductions.  Aliasing can be prevented by using pixScaleToGray instead.</returns>
public static Pix pixScale(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScale(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (273, 1)
// pixScaleToSizeRel(pixs, delw, delh) as Pix
// pixScaleToSizeRel(PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleToSizeRel/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="delw">[in] - change in width, in pixels 0 means no change</param>
///  <param name="delh">[in] - change in height, in pixels 0 means no change</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleToSizeRel(
				 Pix pixs, 
				 int delw, 
				 int delh){

	IntPtr _Result = Natives.pixScaleToSizeRel(pixs.Pointer,   delw,   delh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (316, 1)
// pixScaleToSize(pixs, wd, hd) as Pix
// pixScaleToSize(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The output scaled image has the dimension(s) you specify:
/// To specify the width with isotropic scaling, set %hd = 0.
/// To specify the height with isotropic scaling, set %wd = 0.
/// If both %wd and %hd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// It is an error to set both %wd and %hd to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleToSize/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 and 32 bpp</param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleToSize(
				 Pix pixs, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixScaleToSize(pixs.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (374, 1)
// pixScaleGeneral(pixs, scalex, scaley, sharpfract, sharpwidth) as Pix
// pixScaleGeneral(PIX *, l_float32, l_float32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) See pixScale() for usage.<para/>
/// 
/// (2) This interface may change in the future, as other special
/// cases are added.<para/>
/// 
/// (3) The actual sharpening factors used depend on the maximum
/// of the two scale factors (maxscale):
/// maxscale smaller or equal 0.2:  no sharpening
/// 0.2  is smaller maxscale  is smaller 1.4: uses the input parameters
/// maxscale greater or equal 1.4:  no sharpening<para/>
/// 
/// (4) To avoid sharpening for grayscale and color images with
/// scaling factors between 0.2 and 1.4, call this function
/// with %sharpfract == 0.0.<para/>
/// 
/// (5) To use arbitrary sharpening in conjunction with scaling,
/// call this function with %sharpfract = 0.0, and follow this
/// with a call to pixUnsharpMasking() with your chosen parameters.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGeneral/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 and 32 bpp</param>
///  <param name="scalex">[in] - both  is greater  0.0</param>
///  <param name="scaley">[in] - both  is greater  0.0</param>
///  <param name="sharpfract">[in] - use 0.0 to skip sharpening</param>
///  <param name="sharpwidth">[in] - halfwidth of low-pass filter typ. 1 or 2</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleGeneral(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley, 
				 Single sharpfract, 
				 int sharpwidth){

	IntPtr _Result = Natives.pixScaleGeneral(pixs.Pointer,   scalex,   scaley,   sharpfract,   sharpwidth);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (458, 1)
// pixScaleLI(pixs, scalex, scaley) as Pix
// pixScaleLI(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This function should only be used when the scale factors are
/// greater than or equal to 0.7, and typically greater than 1.
/// If either scale factor is larger than 0.7, we issue a warning
/// and call pixScaleGeneral(), which will invoke area mapping
/// without sharpening.<para/>
/// 
/// (2) This works on 2, 4, 8, 16 and 32 bpp images, as well as on
/// 2, 4 and 8 bpp images that have a colormap.  If there is a
/// colormap, it is removed to either gray or RGB, depending
/// on the colormap.<para/>
/// 
/// (3) This does a linear interpolation on the src image.<para/>
/// 
/// (4) It dispatches to much faster implementations for
/// the special cases of 2x and 4x expansion.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleLI/*"/>
///  <param name="pixs">[in] - 2, 4, 8 or 32 bpp with or without colormap</param>
///  <param name="scalex">[in] - must both be greater or equal 0.7</param>
///  <param name="scaley">[in] - must both be greater or equal 0.7</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleLI(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleLI(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (519, 1)
// pixScaleColorLI(pixs, scalex, scaley) as Pix
// pixScaleColorLI(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) If either scale factor is larger than 0.7, we issue a warning
/// and call pixScaleGeneral(), which will invoke area mapping
/// without sharpening.  This is particularly important for
/// document images with sharp edges.<para/>
/// 
/// (2) For the general case, it's about 4x faster to manipulate
/// the color pixels directly, rather than to make images
/// out of each of the 3 components, scale each component
/// using the pixScaleGrayLI(), and combine the results back
/// into an rgb image.<para/>
/// 
/// (3) The speed on intel hardware for the general case (not 2x)
/// is about 10  10^6 dest-pixels/sec/GHz.  (The special 2x
/// case runs at about 80  10^6 dest-pixels/sec/GHz.)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleColorLI/*"/>
///  <param name="pixs">[in] - 32 bpp, representing rgb</param>
///  <param name="scalex">[in] - must both be greater or equal 0.7</param>
///  <param name="scaley">[in] - must both be greater or equal 0.7</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleColorLI(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleColorLI(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (585, 1)
// pixScaleColor2xLI(pixs) as Pix
// pixScaleColor2xLI(PIX *) as PIX *
///  <summary>
/// (1) This is a special case of linear interpolated scaling,
/// for 2x upscaling.  It is about 8x faster than using
/// the generic pixScaleColorLI(), and about 4x faster than
/// using the special 2x scale function pixScaleGray2xLI()
/// on each of the three components separately.<para/>
/// 
/// (2) The speed on intel hardware is about
/// 80  10^6 dest-pixels/sec/GHz.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleColor2xLI/*"/>
///  <param name="pixs">[in] - 32 bpp, representing rgb</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleColor2xLI(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleColor2xLI(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (634, 1)
// pixScaleColor4xLI(pixs) as Pix
// pixScaleColor4xLI(PIX *) as PIX *
///  <summary>
/// (1) This is a special case of color linear interpolated scaling,
/// for 4x upscaling.  It is about 3x faster than using
/// the generic pixScaleColorLI().<para/>
/// 
/// (2) The speed on intel hardware is about
/// 30  10^6 dest-pixels/sec/GHz<para/>
/// 
/// (3) This scales each component separately, using pixScaleGray4xLI().
/// It would be about 4x faster to inline the color code properly,
/// in analogy to scaleColor4xLILow(), and I leave this as
/// an exercise for someone who really needs it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleColor4xLI/*"/>
///  <param name="pixs">[in] - 32 bpp, representing rgb</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleColor4xLI(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleColor4xLI(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (738, 1)
// pixScaleGrayLI(pixs, scalex, scaley) as Pix
// pixScaleGrayLI(PIX *, l_float32, l_float32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGrayLI/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale, no cmap</param>
///  <param name="scalex">[in] - must both be greater or equal 0.7</param>
///  <param name="scaley">[in] - must both be greater or equal 0.7</param>
///   <returns>pixd, or NULL on error This function is appropriate for upscaling magnification, where the scale factor is  is greater  1, as well as for a small amount of downscaling reduction, with scale factor  is greater  0.7.  If the scale factor is  is smaller 0.7, the best result is obtained by area mapping, but this is relatiely expensive.  A less expensive alternative with scale factor  is smaller 0.7 is low-pass filtering followed by subsampling (pixScaleSmooth()), which is effectively a cheap form of area mapping. Some more details follow. For each pixel in the dest, this does a linear interpolation of 4 neighboring pixels in the src. Specifically, consider the UL corner of src and dest pixels.  The UL corner of the dest falls within a src pixel, whose four corners are the UL corners of 4 adjacent src pixels.  The value of the dest is taken by linear interpolation using the values of the four src pixels and the distance of the UL corner of the dest from each corner. If the image is expanded so that the dest pixel is smaller than the src pixel, such interpolation is a reasonable approach.  This interpolation is also good for a small image reduction factor that is not more than a 2x reduction. Note that the linear interpolation algorithm for scaling is identical in form to the area-mapping algorithm for grayscale rotation.  The latter corresponds to a translation of each pixel without scaling. This function is NOT optimal if the scaling involves a large reduction.    If the image is significantly reduced, so that the dest pixel is much larger than the src pixels, this interpolation, which is over src pixels only near the UL corner of the dest pixel, is not going to give a good area-mapping average. Because area mapping for image scaling is considerably more computationally intensive than linear interpolation, we choose not to use it.   For large image reduction, linear interpolation over adjacent src pixels degenerates asymptotically to subsampling.  But subsampling without a low-pass pre-filter causes aliasing by the nyquist theorem.  To avoid aliasing, a low-pass filter e.g., an averaging filter of size roughly equal to the dest pixel i.e., the reduction factor should be applied to the src before subsampling. As an alternative to low-pass filtering and subsampling for large reduction factors, linear interpolation can also be done between the widely separated src pixels in which the corners of the dest pixel lie.  This also is not optimal, as it samples src pixels only near the corners of the dest pixel, and it is not implemented. The speed on circa 2005 Intel hardware for the general case (not 2x) is about 13  10^6 dest-pixels/sec/GHz.  The special 2x case runs at about 100  10^6 dest-pixels/sec/GHz.</returns>
public static Pix pixScaleGrayLI(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleGrayLI(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (801, 1)
// pixScaleGray2xLI(pixs) as Pix
// pixScaleGray2xLI(PIX *) as PIX *
///  <summary>
/// (1) This is a special case of gray linear interpolated scaling,
/// for 2x upscaling.  It is about 6x faster than using
/// the generic pixScaleGrayLI().<para/>
/// 
/// (2) The speed on intel hardware is about
/// 100  10^6 dest-pixels/sec/GHz
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray2xLI/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale, not cmapped</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleGray2xLI(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleGray2xLI(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (844, 1)
// pixScaleGray4xLI(pixs) as Pix
// pixScaleGray4xLI(PIX *) as PIX *
///  <summary>
/// (1) This is a special case of gray linear interpolated scaling,
/// for 4x upscaling.  It is about 12x faster than using
/// the generic pixScaleGrayLI().<para/>
/// 
/// (2) The speed on intel hardware is about
/// 160  10^6 dest-pixels/sec/GHz.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray4xLI/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale, not cmapped</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleGray4xLI(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleGray4xLI(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (889, 1)
// pixScaleGray2xLIThresh(pixs, thresh) as Pix
// pixScaleGray2xLIThresh(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This does 2x upscale on pixs, using linear interpolation,
/// followed by thresholding to binary.<para/>
/// 
/// (2) Buffers are used to avoid making a large grayscale image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray2xLIThresh/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///  <param name="thresh">[in] - between 0 and 256</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleGray2xLIThresh(
				 Pix pixs, 
				 int thresh){

	IntPtr _Result = Natives.pixScaleGray2xLIThresh(pixs.Pointer,   thresh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (968, 1)
// pixScaleGray2xLIDither(pixs) as Pix
// pixScaleGray2xLIDither(PIX *) as PIX *
///  <summary>
/// (1) This does 2x upscale on pixs, using linear interpolation,
/// followed by Floyd-Steinberg dithering to binary.<para/>
/// 
/// (2) Buffers are used to avoid making a large grayscale image.
/// ~ Two line buffers are used for the src, required for the 2x
/// LI upscale.
/// ~ Three line buffers are used for the intermediate image.
/// Two are filled with each 2xLI row operation the third is
/// needed because the upscale and dithering ops are out of sync.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray2xLIDither/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleGray2xLIDither(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleGray2xLIDither(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1087, 1)
// pixScaleGray4xLIThresh(pixs, thresh) as Pix
// pixScaleGray4xLIThresh(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This does 4x upscale on pixs, using linear interpolation,
/// followed by thresholding to binary.<para/>
/// 
/// (2) Buffers are used to avoid making a large grayscale image.<para/>
/// 
/// (3) If a full 4x expanded grayscale image can be kept in memory,
/// this function is only about 10% faster than separately doing
/// a linear interpolation to a large grayscale image, followed
/// by thresholding to binary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray4xLIThresh/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="thresh">[in] - between 0 and 256</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleGray4xLIThresh(
				 Pix pixs, 
				 int thresh){

	IntPtr _Result = Natives.pixScaleGray4xLIThresh(pixs.Pointer,   thresh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1175, 1)
// pixScaleGray4xLIDither(pixs) as Pix
// pixScaleGray4xLIDither(PIX *) as PIX *
///  <summary>
/// (1) This does 4x upscale on pixs, using linear interpolation,
/// followed by Floyd-Steinberg dithering to binary.<para/>
/// 
/// (2) Buffers are used to avoid making a large grayscale image.
/// ~ Two line buffers are used for the src, required for the
/// 4xLI upscale.
/// ~ Five line buffers are used for the intermediate image.
/// Four are filled with each 4xLI row operation the fifth
/// is needed because the upscale and dithering ops are
/// out of sync.<para/>
/// 
/// (3) If a full 4x expanded grayscale image can be kept in memory,
/// this function is only about 5% faster than separately doing
/// a linear interpolation to a large grayscale image, followed
/// by error-diffusion dithering to binary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGray4xLIDither/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleGray4xLIDither(
				 Pix pixs){

	IntPtr _Result = Natives.pixScaleGray4xLIDither(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1298, 1)
// pixScaleBySampling(pixs, scalex, scaley) as Pix
// pixScaleBySampling(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This function samples from the source without
/// filtering.  As a result, aliasing will occur for
/// subsampling (%scalex and/or %scaley  is smaller 1.0).<para/>
/// 
/// (2) If %scalex == 1.0 and %scaley == 1.0, returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleBySampling/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
///  <param name="scalex">[in] - both  is greater  0.0</param>
///  <param name="scaley">[in] - both  is greater  0.0</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleBySampling(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleBySampling(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1360, 1)
// pixScaleBySamplingToSize(pixs, wd, hd) as Pix
// pixScaleBySamplingToSize(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This guarantees that the output scaled image has the
/// dimension(s) you specify.
/// ~ To specify the width with isotropic scaling, set %hd = 0.
/// ~ To specify the height with isotropic scaling, set %wd = 0.
/// ~ If both %wd and %hd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// ~ It is an error to set both %wd and %hd to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleBySamplingToSize/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 and 32 bpp</param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleBySamplingToSize(
				 Pix pixs, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixScaleBySamplingToSize(pixs.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1405, 1)
// pixScaleByIntSampling(pixs, factor) as Pix
// pixScaleByIntSampling(PIX *, l_int32) as PIX *
///  <summary>
/// (1) Simple interface to pixScaleBySampling(), for
/// isotropic integer reduction.<para/>
/// 
/// (2) If %factor == 1, returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleByIntSampling/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
///  <param name="factor">[in] - integer subsampling</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleByIntSampling(
				 Pix pixs, 
				 int factor){

	IntPtr _Result = Natives.pixScaleByIntSampling(pixs.Pointer,   factor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1447, 1)
// pixScaleRGBToGrayFast(pixs, factor, color) as Pix
// pixScaleRGBToGrayFast(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This does simultaneous subsampling by an integer factor and
/// extraction of the color from the RGB pix.<para/>
/// 
/// (2) It is designed for maximum speed, and is used for quickly
/// generating a downsized grayscale image from a higher resolution
/// RGB image.  This would typically be used for image analysis.<para/>
/// 
/// (3) The standard color byte order (RGBA) is assumed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleRGBToGrayFast/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="factor">[in] - integer reduction factor greater or equal 1</param>
///  <param name="color">[in] - one of COLOR_RED, COLOR_GREEN, COLOR_BLUE</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix pixScaleRGBToGrayFast(
				 Pix pixs, 
				 int factor, 
				 int color){

	IntPtr _Result = Natives.pixScaleRGBToGrayFast(pixs.Pointer,   factor,   color);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1522, 1)
// pixScaleRGBToBinaryFast(pixs, factor, thresh) as Pix
// pixScaleRGBToBinaryFast(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This does simultaneous subsampling by an integer factor and
/// conversion from RGB to gray to binary.<para/>
/// 
/// (2) It is designed for maximum speed, and is used for quickly
/// generating a downsized binary image from a higher resolution
/// RGB image.  This would typically be used for image analysis.<para/>
/// 
/// (3) It uses the green channel to represent the RGB pixel intensity.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleRGBToBinaryFast/*"/>
///  <param name="pixs">[in] - 32 bpp RGB</param>
///  <param name="factor">[in] - integer reduction factor greater or equal 1</param>
///  <param name="thresh">[in] - binarization threshold</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleRGBToBinaryFast(
				 Pix pixs, 
				 int factor, 
				 int thresh){

	IntPtr _Result = Natives.pixScaleRGBToBinaryFast(pixs.Pointer,   factor,   thresh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1588, 1)
// pixScaleGrayToBinaryFast(pixs, factor, thresh) as Pix
// pixScaleGrayToBinaryFast(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This does simultaneous subsampling by an integer factor and
/// thresholding from gray to binary.<para/>
/// 
/// (2) It is designed for maximum speed, and is used for quickly
/// generating a downsized binary image from a higher resolution
/// gray image.  This would typically be used for image analysis.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleGrayToBinaryFast/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///  <param name="factor">[in] - integer reduction factor greater or equal 1</param>
///  <param name="thresh">[in] - binarization threshold</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixScaleGrayToBinaryFast(
				 Pix pixs, 
				 int factor, 
				 int thresh){

	IntPtr _Result = Natives.pixScaleGrayToBinaryFast(pixs.Pointer,   factor,   thresh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1671, 1)
// pixScaleSmooth(pix, scalex, scaley) as Pix
// pixScaleSmooth(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This function should only be used when the scale factors are less
/// than or equal to 0.7 (i.e., more than about 1.42x reduction).
/// If either scale factor is larger than 0.7, we issue a warning
/// and call pixScaleGeneral(), which will invoke linear
/// interpolation without sharpening.<para/>
/// 
/// (2) This works only on 2, 4, 8 and 32 bpp images, and if there is
/// a colormap, it is removed by converting to RGB.  In other
/// cases, we issue a warning and call pixScaleGeneral().<para/>
/// 
/// (3) It does simple (flat filter) convolution, with a filter size
/// commensurate with the amount of reduction, to avoid antialiasing.<para/>
/// 
/// (4) It does simple subsampling after smoothing, which is appropriate
/// for this range of scaling.  Linear interpolation gives essentially
/// the same result with more computation for these scale factors,
/// so we don't use it.<para/>
/// 
/// (5) The result is the same as doing a full block convolution followed by
/// subsampling, but this is faster because the results of the block
/// convolution are only computed at the subsampling locations.
/// In fact, the computation time is approximately independent of
/// the scale factor, because the convolution kernel is adjusted
/// so that each source pixel is summed approximately once.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleSmooth/*"/>
///  <param name="pix">[in] - 2, 4, 8 or 32 bpp and 2, 4, 8 bpp with colormap</param>
///  <param name="scalex">[in] - must both be  is smaller 0.7</param>
///  <param name="scaley">[in] - must both be  is smaller 0.7</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleSmooth(
				 Pix pix, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleSmooth(pix.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1767, 1)
// pixScaleSmoothToSize(pixs, wd, hd) as Pix
// pixScaleSmoothToSize(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See notes in pixScaleSmooth().<para/>
/// 
/// (2) The output scaled image has the dimension(s) you specify:
/// To specify the width with isotropic scaling, set %hd = 0.
/// To specify the height with isotropic scaling, set %wd = 0.
/// If both %wd and %hd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// It is an error to set both %wd and %hd to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleSmoothToSize/*"/>
///  <param name="pixs">[in] - 2, 4, 8 or 32 bpp and 2, 4, 8 bpp with colormap</param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleSmoothToSize(
				 Pix pixs, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixScaleSmoothToSize(pixs.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1805, 1)
// pixScaleRGBToGray2(pixs, rwt, gwt, bwt) as Pix
// pixScaleRGBToGray2(PIX *, l_float32, l_float32, l_float32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleRGBToGray2/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="rwt">[in] - must sum to 1.0</param>
///  <param name="gwt">[in] - must sum to 1.0</param>
///  <param name="bwt">[in] - must sum to 1.0</param>
///   <returns>pixd, 8 bpp, 2x reduced, or NULL on error</returns>
public static Pix pixScaleRGBToGray2(
				 Pix pixs, 
				 Single rwt, 
				 Single gwt, 
				 Single bwt){

	IntPtr _Result = Natives.pixScaleRGBToGray2(pixs.Pointer,   rwt,   gwt,   bwt);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1872, 1)
// pixScaleAreaMap(pix, scalex, scaley) as Pix
// pixScaleAreaMap(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This function should only be used when the scale factors are less
/// than or equal to 0.7 (i.e., more than about 1.42x reduction).
/// If either scale factor is larger than 0.7, we issue a warning
/// and call pixScaleGeneral(), which will invoke linear
/// interpolation without sharpening.<para/>
/// 
/// (2) This works only on 2, 4, 8 and 32 bpp images.  If there is
/// a colormap, it is removed by converting to RGB.  In other
/// cases, we issue a warning and call pixScaleGeneral().<para/>
/// 
/// (3) This is faster than pixScale() because it does not do sharpening.<para/>
/// 
/// (4) It does a relatively expensive area mapping computation, to
/// avoid antialiasing.  It is about 2x slower than pixScaleSmooth(),
/// but the results are much better on fine text.<para/>
/// 
/// (5) This is typically about 20% faster for the special cases of
/// 2x, 4x, 8x and 16x reduction.<para/>
/// 
/// (6) Surprisingly, there is no speedup (and a slight quality
/// impairment) if you do as many successive 2x reductions as
/// possible, ending with a reduction with a scale factor larger
/// than 0.5.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleAreaMap/*"/>
///  <param name="pix">[in] - 2, 4, 8 or 32 bpp and 2, 4, 8 bpp with colormap</param>
///  <param name="scalex">[in] - must both be smaller or equal 0.7</param>
///  <param name="scaley">[in] - must both be smaller or equal 0.7</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleAreaMap(
				 Pix pix, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleAreaMap(pix.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (1992, 1)
// pixScaleAreaMap2(pix) as Pix
// pixScaleAreaMap2(PIX *) as PIX *
///  <summary>
/// (1) This function does an area mapping (average) for 2x
/// reduction.<para/>
/// 
/// (2) This works only on 2, 4, 8 and 32 bpp images.  If there is
/// a colormap, it is removed by converting to RGB.<para/>
/// 
/// (3) Speed on 3 GHz processor:
/// Color: 160 Mpix/sec
/// Gray: 700 Mpix/sec
/// This contrasts with the speed of the general pixScaleAreaMap():
/// Color: 35 Mpix/sec
/// Gray: 50 Mpix/sec<para/>
/// 
/// (4) From (3), we see that this special function is about 4.5x
/// faster for color and 14x faster for grayscale<para/>
/// 
/// (5) Consequently, pixScaleAreaMap2() is incorporated into the
/// general area map scaling function, for the special cases
/// of 2x, 4x, 8x and 16x reduction.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleAreaMap2/*"/>
///  <param name="pix">[in] - 2, 4, 8 or 32 bpp and 2, 4, 8 bpp with colormap</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleAreaMap2(
				 Pix pix){

	IntPtr _Result = Natives.pixScaleAreaMap2(pix.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (2057, 1)
// pixScaleAreaMapToSize(pixs, wd, hd) as Pix
// pixScaleAreaMapToSize(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See notes in pixScaleAreaMap().<para/>
/// 
/// (2) The output scaled image has the dimension(s) you specify:
/// To specify the width with isotropic scaling, set %hd = 0.
/// To specify the height with isotropic scaling, set %wd = 0.
/// If both %wd and %hd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// It is an error to set both %wd and %hd to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleAreaMapToSize/*"/>
///  <param name="pixs">[in] - 2, 4, 8 or 32 bpp and 2, 4, 8 bpp with colormap</param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleAreaMapToSize(
				 Pix pixs, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixScaleAreaMapToSize(pixs.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// scale1.c (2105, 1)
// pixScaleBinary(pixs, scalex, scaley) as Pix
// pixScaleBinary(PIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This function samples from the source without
/// filtering.  As a result, aliasing will occur for
/// subsampling (scalex and scaley  is smaller 1.0).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleBinary/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="scalex">[in] - both  is greater  0.0</param>
///  <param name="scaley">[in] - both  is greater  0.0</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixScaleBinary(
				 Pix pixs, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixScaleBinary(pixs.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
