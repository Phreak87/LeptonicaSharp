using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// grayquant.c (171, 1)
// pixDitherToBinary(pixs) as Pix
// pixDitherToBinary(PIX *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDitherToBinary/*"/>
///  <param name="pixs">[in] - </param>
///   <returns>pixd dithered binary, or NULL on error The Floyd-Steinberg error diffusion dithering algorithm binarizes an 8 bpp grayscale image to a threshold of 128. If a pixel has a value above 127, it is binarized to white and the excess below 255 is subtracted from three neighboring pixels in the fractions 3/8 to i, j+1, 3/8 to i+1, j) and 1/4 to (i+1,j+1, truncating to 0 if necessary.  Likewise, if it the pixel has a value below 128, it is binarized to black and the excess above 0 is added to the neighboring pixels, truncating to 255 if necessary. This function differs from straight dithering in that it allows clipping of grayscale to 0 or 255 if the values are sufficiently close, without distribution of the excess. This uses default values to specify the range of lower and upper values near 0 and 255, rsp that are clipped to black and white without propagating the excess. Not propagating the excess has the effect of reducing the snake patterns in parts of the image that are nearly black or white however, it also prevents the attempt to reproduce gray for those values. The implementation is straightforward.  It uses a pair of line buffers to avoid changing pixs.  It is about the same speed as pixDitherToBinaryLUT(), which uses three LUTs.</returns>
public static Pix pixDitherToBinary(
				 Pix pixs){

	IntPtr _Result = Natives.pixDitherToBinary(pixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (203, 1)
// pixDitherToBinarySpec(pixs, lowerclip, upperclip) as Pix
// pixDitherToBinarySpec(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See comments above in pixDitherToBinary() for details.<para/>
/// 
/// (2) The input parameters lowerclip and upperclip specify the range
/// of lower and upper values (near 0 and 255, rsp) that are
/// clipped to black and white without propagating the excess.
/// For that reason, lowerclip and upperclip should be small numbers.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDitherToBinarySpec/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="lowerclip">[in] - lower clip distance to black use 0 for default</param>
///  <param name="upperclip">[in] - upper clip distance to white use 0 for default</param>
///   <returns>pixd dithered binary, or NULL on error</returns>
public static Pix pixDitherToBinarySpec(
				 Pix pixs, 
				 int lowerclip, 
				 int upperclip){

	IntPtr _Result = Natives.pixDitherToBinarySpec(pixs.Pointer,   lowerclip,   upperclip);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (322, 1)
// ditherToBinaryLineLow(lined, w, bufs1, bufs2, lowerclip, upperclip, lastlineflag) as Object
// ditherToBinaryLineLow(l_uint32 *, l_int32, l_uint32 *, l_uint32 *, l_int32, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ditherToBinaryLineLow/*"/>
///  <param name="lined">[in] - ptr to beginning of dest line</param>
///  <param name="w">[in] - width of image in pixels</param>
///  <param name="bufs1">[in] - buffer of current source line</param>
///  <param name="bufs2">[in] - buffer of next source line</param>
///  <param name="lowerclip">[in] - lower clip distance to black</param>
///  <param name="upperclip">[in] - upper clip distance to white</param>
///  <param name="lastlineflag">[in] - 0 if not last dest line, 1 if last dest line</param>
public static void ditherToBinaryLineLow(
				 Byte[] lined, 
				 int w, 
				 Byte[] bufs1, 
				 Byte[] bufs2, 
				 int lowerclip, 
				 int upperclip, 
				 int lastlineflag){

		IntPtr linedPtr = 	Marshal.AllocHGlobal(lined.Length);
		Marshal.Copy(lined, 0, linedPtr, lined.Length);
		IntPtr bufs1Ptr = 	Marshal.AllocHGlobal(bufs1.Length);
		Marshal.Copy(bufs1, 0, bufs1Ptr, bufs1.Length);
		IntPtr bufs2Ptr = 	Marshal.AllocHGlobal(bufs2.Length);
		Marshal.Copy(bufs2, 0, bufs2Ptr, bufs2.Length);

	Natives.ditherToBinaryLineLow(  linedPtr,   w,   bufs1Ptr,   bufs2Ptr,   lowerclip,   upperclip,   lastlineflag);
	
	Marshal.FreeHGlobal(linedPtr);
	Marshal.FreeHGlobal(bufs1Ptr);
	Marshal.FreeHGlobal(bufs2Ptr);



}

// grayquant.c (443, 1)
// pixThresholdToBinary(pixs, thresh) as Pix
// pixThresholdToBinary(PIX *, l_int32) as PIX *
///  <summary>
/// (1) If the source pixel is less than the threshold value,
/// the dest will be 1 otherwise, it will be 0.<para/>
/// 
/// (2) For example, for 8 bpp src pix, if %thresh == 256, the dest
/// 1 bpp pix is all ones (fg), and if %thresh == 0, the dest
/// pix is all zeros (bg).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdToBinary/*"/>
///  <param name="pixs">[in] - 4 or 8 bpp</param>
///  <param name="thresh">[in] - threshold value</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixThresholdToBinary(
				 Pix pixs, 
				 int thresh){

	IntPtr _Result = Natives.pixThresholdToBinary(pixs.Pointer,   thresh);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (519, 1)
// thresholdToBinaryLineLow(lined, w, lines, d, thresh) as Object
// thresholdToBinaryLineLow(l_uint32 *, l_int32, l_uint32 *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/thresholdToBinaryLineLow/*"/>
public static void thresholdToBinaryLineLow(
				 object lined, 
				 int w, 
				 object lines, 
				 int d, 
				 int thresh){

	Natives.thresholdToBinaryLineLow(  lined,   w,   lines,   d,   thresh);
	



}

// grayquant.c (650, 1)
// pixVarThresholdToBinary(pixs, pixg) as Pix
// pixVarThresholdToBinary(PIX *, PIX *) as PIX *
///  <summary>
/// (1) If the pixel in pixs is less than the corresponding pixel
/// in pixg, the dest will be 1 otherwise it will be 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVarThresholdToBinary/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixg">[in] - 8 bpp contains threshold values for each pixel</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixVarThresholdToBinary(
				 Pix pixs, 
				 Pix pixg){

	IntPtr _Result = Natives.pixVarThresholdToBinary(pixs.Pointer, pixg.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (725, 1)
// pixAdaptThresholdToBinary(pixs, pixm, gamma) as Pix
// pixAdaptThresholdToBinary(PIX *, PIX *, l_float32) as PIX *
///  <summary>
/// (1) This is a simple convenience function for doing adaptive
/// thresholding on a grayscale image with variable background.
/// It uses default parameters appropriate for typical text images.<para/>
/// 
/// (2) %pixm is a 1 bpp mask over "image" regions, which are not
/// expected to have a white background.  The mask inhibits
/// background finding under the fg pixels of the mask.  For
/// images with both text and image, the image regions would
/// be binarized (or quantized) by a different set of operations.<para/>
/// 
/// (3) As %gamma is increased, the foreground pixels are reduced.<para/>
/// 
/// (4) Under the covers:  The default background value for normalization
/// is 200, so we choose 170 for 'maxval' in pixGammaTRC.  Likewise,
/// the default foreground threshold for normalization is 60,
/// so we choose 50 for 'minval' in pixGammaTRC.  Because
/// 170 was mapped to 255, choosing 200 for the threshold is
/// quite safe for avoiding speckle noise from the background.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAdaptThresholdToBinary/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixm">[in][optional] - 1 bpp image mask can be null</param>
///  <param name="gamma">[in] - gamma correction must be  is greater  0.0 typically ~1.0</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixAdaptThresholdToBinary(
				 Pix pixs, 
				 Pix pixm, 
				 Single gamma){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	IntPtr _Result = Natives.pixAdaptThresholdToBinary(pixs.Pointer, pixmPtr,   gamma);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (765, 1)
// pixAdaptThresholdToBinaryGen(pixs, pixm, gamma, blackval, whiteval, thresh) as Pix
// pixAdaptThresholdToBinaryGen(PIX *, PIX *, l_float32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a convenience function for doing adaptive thresholding
/// on a grayscale image with variable background.  Also see notes
/// in pixAdaptThresholdToBinary().<para/>
/// 
/// (2) Reducing %gamma increases the foreground (text) pixels.
/// Use a low value (e.g., 0.5) for images with light text.<para/>
/// 
/// (3) For normal images, see default args in pixAdaptThresholdToBinary().
/// For images with very light text, these values are appropriate:
/// gamma ~0.5
/// blackval  ~70
/// whiteval  ~190
/// thresh  ~200
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAdaptThresholdToBinaryGen/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixm">[in][optional] - 1 bpp image mask can be null</param>
///  <param name="gamma">[in] - gamma correction must be  is greater  0.0 typically ~1.0</param>
///  <param name="blackval">[in] - dark value to set to black (0)</param>
///  <param name="whiteval">[in] - light value to set to white (255)</param>
///  <param name="thresh">[in] - final threshold for binarization</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixAdaptThresholdToBinaryGen(
				 Pix pixs, 
				 Pix pixm, 
				 Single gamma, 
				 int blackval, 
				 int whiteval, 
				 int thresh){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	IntPtr _Result = Natives.pixAdaptThresholdToBinaryGen(pixs.Pointer, pixmPtr,   gamma,   blackval,   whiteval,   thresh);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (810, 1)
// pixGenerateMaskByValue(pixs, val, usecmap) as Pix
// pixGenerateMaskByValue(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) %val is the pixel value that we are selecting.  It can be
/// either a gray value or a colormap index.<para/>
/// 
/// (2) If pixs is colormapped, %usecmap determines if the colormap
/// index values are used, or if the colormap is removed to gray and
/// the gray values are used.  For the latter, it generates
/// an approximate grayscale value for each pixel, and then looks
/// for gray pixels with the value %val.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateMaskByValue/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, or colormapped</param>
///  <param name="val">[in] - of pixels for which we set 1 in dest</param>
///  <param name="usecmap">[in] - 1 to retain cmap values 0 to convert to gray</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixGenerateMaskByValue(
				 Pix pixs, 
				 int val, 
				 int usecmap){

	IntPtr _Result = Natives.pixGenerateMaskByValue(pixs.Pointer,   val,   usecmap);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (900, 1)
// pixGenerateMaskByBand(pixs, lower, upper, inband, usecmap) as Pix
// pixGenerateMaskByBand(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Generates a 1 bpp mask pixd, the same size as pixs, where
/// the fg pixels in the mask are those either within the specified
/// band (for inband == 1) or outside the specified band
/// (for inband == 0).<para/>
/// 
/// (2) If pixs is colormapped, %usecmap determines if the colormap
/// values are used, or if the colormap is removed to gray and
/// the gray values are used.  For the latter, it generates
/// an approximate grayscale value for each pixel, and then looks
/// for gray pixels with the value %val.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateMaskByBand/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, or colormapped</param>
///  <param name="lower">[in] - two pixel values from which a range, either between (inband) or outside of (!inband), determines which pixels in pixs cause us to set a 1 in the dest mask</param>
///  <param name="upper">[in] - two pixel values from which a range, either between (inband) or outside of (!inband), determines which pixels in pixs cause us to set a 1 in the dest mask</param>
///  <param name="inband">[in] - 1 for finding pixels in [lower, upper] 0 for finding pixels in [0, lower) union (upper, 255]</param>
///  <param name="usecmap">[in] - 1 to retain cmap values 0 to convert to gray</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixGenerateMaskByBand(
				 Pix pixs, 
				 int lower, 
				 int upper, 
				 int inband, 
				 int usecmap){

	IntPtr _Result = Natives.pixGenerateMaskByBand(pixs.Pointer,   lower,   upper,   inband,   usecmap);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1013, 1)
// pixDitherTo2bpp(pixs, cmapflag) as Pix
// pixDitherTo2bpp(PIX *, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDitherTo2bpp/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="cmapflag">[in] - 1 to generate a colormap</param>
///   <returns>pixd dithered 2 bpp, or NULL on error An analog of the Floyd-Steinberg error diffusion dithering algorithm is used to "dibitize" an 8 bpp grayscale image to 2 bpp, using equally spaced gray values of 0, 85, 170, and 255, which are served by thresholds of 43, 128 and 213. If cmapflag == 1, the colormap values are set to 0, 85, 170 and 255. If a pixel has a value between 0 and 42, it is dibitized to 0, and the excess above 0 is added to the three neighboring pixels, in the fractions 3/8 to i, j+1, 3/8 to i+1, j) and 1/4 to (i+1, j+1, truncating to 255 if necessary.  If a pixel has a value between 43 and 127, it is dibitized to 1, and the excess above 85 is added to the three neighboring pixels as before.  If the value is below 85, the excess is subtracted.  With a value between 128 and 212, it is dibitized to 2, with the excess on either side of 170 distributed as before.  Finally, with a value between 213 and 255, it is dibitized to 3, with the excess below 255 subtracted from the neighbors.  We always truncate to 0 or 255. The details can be seen in the lookup table generation. This function differs from straight dithering in that it allows clipping of grayscale to 0 or 255 if the values are sufficiently close, without distribution of the excess. This uses default values from pix.h to specify the range of lower and upper values near 0 and 255, rsp that are clipped to black and white without propagating the excess. Not propagating the excess has the effect of reducing the snake patterns in parts of the image that are nearly black or white however, it also prevents any attempt to reproduce gray for those values. The implementation uses 3 lookup tables for simplicity, and a pair of line buffers to avoid modifying pixs.</returns>
public static Pix pixDitherTo2bpp(
				 Pix pixs, 
				 int cmapflag){

	IntPtr _Result = Natives.pixDitherTo2bpp(pixs.Pointer,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1047, 1)
// pixDitherTo2bppSpec(pixs, lowerclip, upperclip, cmapflag) as Pix
// pixDitherTo2bppSpec(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See comments above in pixDitherTo2bpp() for details.<para/>
/// 
/// (2) The input parameters lowerclip and upperclip specify the range
/// of lower and upper values (near 0 and 255, rsp) that are
/// clipped to black and white without propagating the excess.
/// For that reason, lowerclip and upperclip should be small numbers.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDitherTo2bppSpec/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="lowerclip">[in] - lower clip distance to black use 0 for default</param>
///  <param name="upperclip">[in] - upper clip distance to white use 0 for default</param>
///  <param name="cmapflag">[in] - 1 to generate a colormap</param>
///   <returns>pixd dithered 2 bpp, or NULL on error</returns>
public static Pix pixDitherTo2bppSpec(
				 Pix pixs, 
				 int lowerclip, 
				 int upperclip, 
				 int cmapflag){

	IntPtr _Result = Natives.pixDitherTo2bppSpec(pixs.Pointer,   lowerclip,   upperclip,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1373, 1)
// pixThresholdTo2bpp(pixs, nlevels, cmapflag) as Pix
// pixThresholdTo2bpp(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Valid values for nlevels is the set {2, 3, 4}.<para/>
/// 
/// (2) Any colormap on the input pixs is removed to 8 bpp grayscale.<para/>
/// 
/// (3) This function is typically invoked with cmapflag == 1.
/// In the situation where no colormap is desired, nlevels is
/// ignored and pixs is thresholded to 4 levels.<para/>
/// 
/// (4) The target output colors are equally spaced, with the
/// darkest at 0 and the lightest at 255.  The thresholds are
/// chosen halfway between adjacent output values.  A table
/// is built that specifies the mapping from src to dest.<para/>
/// 
/// (5) If cmapflag == 1, a colormap of size 'nlevels' is made,
/// and the pixel values in pixs are replaced by their
/// appropriate color indices.  The number of holdouts,
/// 4 - nlevels, will be between 0 and 2.<para/>
/// 
/// (6) If you don't want the thresholding to be equally spaced,
/// either first transform the 8 bpp src using pixGammaTRC().
/// or, if cmapflag == 1, after calling this function you can use
/// pixcmapResetColor() to change any individual colors.<para/>
/// 
/// (7) If a colormap is generated, it will specify (to display
/// programs) exactly how each level is to be represented in RGB
/// space.  When representing text, 3 levels is far better than
/// 2 because of the antialiasing of the single gray level,
/// and 4 levels (black, white and 2 gray levels) is getting
/// close to the perceptual quality of a (nearly continuous)
/// grayscale image.  With 2 bpp, you can set up a colormap
/// and allocate from 2 to 4 levels to represent antialiased text.
/// Any left over colormap entries can be used for coloring regions.
/// For the same number of levels, the file size of a 2 bpp image
/// is about 10% smaller than that of a 4 bpp result for the same
/// number of levels.  For both 2 bpp and 4 bpp, using 4 levels you
/// get compression far better than that of jpeg, because the
/// quantization to 4 levels will remove the jpeg ringing in the
/// background near character edges.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdTo2bpp/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="nlevels">[in] - equally spaced must be between 2 and 4</param>
///  <param name="cmapflag">[in] - 1 to build colormap 0 otherwise</param>
///   <returns>pixd 2 bpp, optionally with colormap, or NULL on error</returns>
public static Pix pixThresholdTo2bpp(
				 Pix pixs, 
				 int nlevels, 
				 int cmapflag){

	IntPtr _Result = Natives.pixThresholdTo2bpp(pixs.Pointer,   nlevels,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1515, 1)
// pixThresholdTo4bpp(pixs, nlevels, cmapflag) as Pix
// pixThresholdTo4bpp(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Valid values for nlevels is the set {2, ... 16}.<para/>
/// 
/// (2) Any colormap on the input pixs is removed to 8 bpp grayscale.<para/>
/// 
/// (3) This function is typically invoked with cmapflag == 1.
/// In the situation where no colormap is desired, nlevels is
/// ignored and pixs is thresholded to 16 levels.<para/>
/// 
/// (4) The target output colors are equally spaced, with the
/// darkest at 0 and the lightest at 255.  The thresholds are
/// chosen halfway between adjacent output values.  A table
/// is built that specifies the mapping from src to dest.<para/>
/// 
/// (5) If cmapflag == 1, a colormap of size 'nlevels' is made,
/// and the pixel values in pixs are replaced by their
/// appropriate color indices.  The number of holdouts,
/// 16 - nlevels, will be between 0 and 14.<para/>
/// 
/// (6) If you don't want the thresholding to be equally spaced,
/// either first transform the 8 bpp src using pixGammaTRC().
/// or, if cmapflag == 1, after calling this function you can use
/// pixcmapResetColor() to change any individual colors.<para/>
/// 
/// (7) If a colormap is generated, it will specify, to display
/// programs, exactly how each level is to be represented in RGB
/// space.  When representing text, 3 levels is far better than
/// 2 because of the antialiasing of the single gray level,
/// and 4 levels (black, white and 2 gray levels) is getting
/// close to the perceptual quality of a (nearly continuous)
/// grayscale image.  Therefore, with 4 bpp, you can set up a
/// colormap, allocate a relatively small fraction of the 16
/// possible values to represent antialiased text, and use the
/// other colormap entries for other things, such as coloring
/// text or background.  Two other reasons for using a small number
/// of gray values for antialiased text are (1) PNG compression
/// gets worse as the number of levels that are used is increased,
/// and (2) using a small number of levels will filter out most of
/// the jpeg ringing that is typically introduced near sharp edges
/// of text.  This filtering is partly responsible for the improved
/// compression.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdTo4bpp/*"/>
///  <param name="pixs">[in] - 8 bpp, can have colormap</param>
///  <param name="nlevels">[in] - equally spaced must be between 2 and 16</param>
///  <param name="cmapflag">[in] - 1 to build colormap 0 otherwise</param>
///   <returns>pixd 4 bpp, optionally with colormap, or NULL on error</returns>
public static Pix pixThresholdTo4bpp(
				 Pix pixs, 
				 int nlevels, 
				 int cmapflag){

	IntPtr _Result = Natives.pixThresholdTo4bpp(pixs.Pointer,   nlevels,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1632, 1)
// pixThresholdOn8bpp(pixs, nlevels, cmapflag) as Pix
// pixThresholdOn8bpp(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Valid values for nlevels is the set {2,...,256}.<para/>
/// 
/// (2) Any colormap on the input pixs is removed to 8 bpp grayscale.<para/>
/// 
/// (3) If cmapflag == 1, a colormap of size 'nlevels' is made,
/// and the pixel values in pixs are replaced by their
/// appropriate color indices.  Otherwise, the pixel values
/// are the actual thresholded (i.e., quantized) grayscale values.<para/>
/// 
/// (4) If you don't want the thresholding to be equally spaced,
/// first transform the input 8 bpp src using pixGammaTRC().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdOn8bpp/*"/>
///  <param name="pixs">[in] - 8 bpp, can have colormap</param>
///  <param name="nlevels">[in] - equally spaced must be between 2 and 256</param>
///  <param name="cmapflag">[in] - 1 to build colormap 0 otherwise</param>
///   <returns>pixd 8 bpp, optionally with colormap, or NULL on error</returns>
public static Pix pixThresholdOn8bpp(
				 Pix pixs, 
				 int nlevels, 
				 int cmapflag){

	IntPtr _Result = Natives.pixThresholdOn8bpp(pixs.Pointer,   nlevels,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1733, 1)
// pixThresholdGrayArb(pixs, edgevals, outdepth, use_average, setblack, setwhite) as Pix
// pixThresholdGrayArb(PIX *, const char *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This function allows exact specification of the quantization bins.
/// The string %edgevals is a space-separated set of values
/// specifying the dividing points between output quantization bins.
/// These threshold values are assigned to the bin with higher
/// values, so that each of them is the smallest value in their bin.<para/>
/// 
/// (2) The output image (pixd) depth is specified by %outdepth.  The
/// number of bins is the number of edgevals + 1.  The
/// relation between outdepth and the number of bins is:
/// outdepth = 2 nbins smaller or equal 4
/// outdepth = 4 nbins smaller or equal 16
/// outdepth = 8 nbins smaller or equal 256
/// With %outdepth == 0, the minimum required depth for the
/// given number of bins is used.
/// The output pixd has a colormap.<para/>
/// 
/// (3) The last 3 args determine the specific values that go into
/// the colormap.<para/>
/// 
/// (4) For %use_average:
/// ~ if TRUE, the average value of pixels falling in the bin is
/// chosen as the representative gray value.  Otherwise,
/// ~ if FALSE, the central value of each bin is chosen as
/// the representative value.
/// The colormap holds the representative value.<para/>
/// 
/// (5) For %setblack, if TRUE the darkest color is set to (0,0,0).<para/>
/// 
/// (6) For %setwhite, if TRUE the lightest color is set to (255,255,255).<para/>
/// 
/// (7) An alternative to using this function to quantize to
/// unequally-spaced bins is to first transform the 8 bpp pixs
/// using pixGammaTRC(), and follow this with pixThresholdTo4bpp().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdGrayArb/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale can have colormap</param>
///  <param name="edgevals">[in] - string giving edge value of each bin</param>
///  <param name="outdepth">[in] - 0, 2, 4 or 8 bpp 0 is default for min depth</param>
///  <param name="use_average">[in] - 1 if use the average pixel value in colormap</param>
///  <param name="setblack">[in] - 1 if darkest color is set to black</param>
///  <param name="setwhite">[in] - 1 if lightest color is set to white</param>
///   <returns>pixd 2, 4 or 8 bpp quantized image with colormap, or NULL on error</returns>
public static Pix pixThresholdGrayArb(
				 Pix pixs, 
				 String edgevals, 
				 int outdepth, 
				 int use_average, 
				 int setblack, 
				 int setwhite){

	IntPtr _Result = Natives.pixThresholdGrayArb(pixs.Pointer,   edgevals,   outdepth,   use_average,   setblack,   setwhite);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (1843, 1)
// makeGrayQuantIndexTable(nlevels) as int[]
// makeGrayQuantIndexTable(l_int32) as l_int32 *
///  <summary>
/// (1) 'nlevels' is some number between 2 and 256 (typically 8 or less).<para/>
/// 
/// (2) The table is typically used for quantizing 2, 4 and 8 bpp
/// grayscale src pix, and generating a colormapped dest pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeGrayQuantIndexTable/*"/>
///  <param name="nlevels">[in] - number of output levels</param>
///   <returns>table maps input gray level to colormap index, or NULL on error</returns>
public static int[] makeGrayQuantIndexTable(
				 int nlevels){

	int[] _Result = Natives.makeGrayQuantIndexTable(  nlevels);
	



	return _Result;
}

// grayquant.c (1952, 1)
// makeGrayQuantTableArb(na, outdepth, ptab, pcmap) as int
// makeGrayQuantTableArb(NUMA *, l_int32, l_int32 **, PIXCMAP **) as l_ok
///  <summary>
/// (1) The number of bins is the count of %na + 1.<para/>
/// 
/// (2) The bin boundaries in na must be sorted in increasing order.<para/>
/// 
/// (3) The table is an inverse colormap: it maps input gray level
/// to colormap index (the bin number).<para/>
/// 
/// (4) The colormap generated here has quantized values at the
/// center of each bin.  If you want to use the average gray
/// value of pixels within the bin, discard the colormap and
/// compute it using makeGrayQuantColormapArb().<para/>
/// 
/// (5) Returns an error if there are not enough levels in the
/// output colormap for the number of bins.  The number
/// of bins must not exceed 2^outdepth.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeGrayQuantTableArb/*"/>
///  <param name="na">[in] - numa of bin boundaries</param>
///  <param name="outdepth">[in] - of colormap: 1, 2, 4 or 8</param>
///  <param name="ptab">[out] - table mapping input gray level to cmap index</param>
///  <param name="pcmap">[out] - colormap</param>
///   <returns>0 if OK, 1 on error</returns>
public static int makeGrayQuantTableArb(
				 Numa na, 
				 int outdepth, 
				out List<int[]> ptab, 
				out PixColormap pcmap){

	IntPtr ptabPtr = IntPtr.Zero;
	IntPtr pcmapPtr = IntPtr.Zero;

	int _Result = Natives.makeGrayQuantTableArb(na.Pointer,   outdepth, out  ptabPtr, out pcmapPtr);
	

	if (ptabPtr == null) {ptab = null;} else { ptab = null; };
	if (pcmapPtr == IntPtr.Zero) {pcmap = null;} else { pcmap = new PixColormap(pcmapPtr); };


	return _Result;
}

// grayquant.c (2129, 1)
// pixGenerateMaskByBand32(pixs, refval, delm, delp, fractm, fractp) as Pix
// pixGenerateMaskByBand32(PIX *, l_uint32, l_int32, l_int32, l_float32, l_float32) as PIX *
///  <summary>
/// (1) Generates a 1 bpp mask pixd, the same size as pixs, where
/// the fg pixels in the mask within a band of rgb values
/// surrounding %refval.  The band can be chosen in two ways
/// for each component:
/// (a) Use (%delm, %delp) to specify how many levels down and up
/// (b) Use (%fractm, %fractp) to specify the fractional
/// distance toward 0 and 255, respectively.
/// Note that %delm and %delp must be in [0 ... 255], whereas
/// %fractm and %fractp must be in [0.0 - 1.0].<para/>
/// 
/// (2) Either (%delm, %delp) or (%fractm, %fractp) can be used.
/// Set each value in the other pair to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateMaskByBand32/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="refval">[in] - reference rgb value</param>
///  <param name="delm">[in] - max amount below the ref value for any component</param>
///  <param name="delp">[in] - max amount above the ref value for any component</param>
///  <param name="fractm">[in] - fractional amount below ref value for all components</param>
///  <param name="fractp">[in] - fractional amount above ref value for all components</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixGenerateMaskByBand32(
				 Pix pixs, 
				 uint refval, 
				 int delm, 
				 int delp, 
				 Single fractm, 
				 Single fractp){

	IntPtr _Result = Natives.pixGenerateMaskByBand32(pixs.Pointer,   refval,   delm,   delp,   fractm,   fractp);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (2227, 1)
// pixGenerateMaskByDiscr32(pixs, refval1, refval2, distflag) as Pix
// pixGenerateMaskByDiscr32(PIX *, l_uint32, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) Generates a 1 bpp mask pixd, the same size as pixs, where
/// the fg pixels in the mask are those where the pixel in pixs
/// is "closer" to refval1 than to refval2.<para/>
/// 
/// (2) "Closer" can be defined in several ways, such as:
/// ~ manhattan distance (L1)
/// ~ euclidean distance (L2)
/// ~ majority vote of the individual components
/// Here, we have a choice of L1 or L2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateMaskByDiscr32/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="refval1">[in] - reference rgb value</param>
///  <param name="refval2">[in] - reference rgb value</param>
///  <param name="distflag">[in] - L_MANHATTAN_DISTANCE, L_EUCLIDEAN_DISTANCE</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixGenerateMaskByDiscr32(
				 Pix pixs, 
				 uint refval1, 
				 uint refval2, 
				 int distflag){

	IntPtr _Result = Natives.pixGenerateMaskByDiscr32(pixs.Pointer,   refval1,   refval2,   distflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (2341, 1)
// pixGrayQuantFromHisto(pixd, pixs, pixm, minfract, maxsize) as Pix
// pixGrayQuantFromHisto(PIX *, PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This is useful for quantizing images with relatively few
/// colors, but which may have both color and gray pixels.
/// If there are color pixels, it is assumed that an input
/// rgb image has been color quantized first so that:
/// ~ pixd has a colormap describing the color pixels
/// ~ pixm is a mask over the non-color pixels in pixd
/// ~ the colormap in pixd, and the color pixels in pixd,
/// have been repacked to go from 0 to n-1 (n colors)
/// If there are no color pixels, pixd and pixm are both null,
/// and all pixels in pixs are quantized to gray.<para/>
/// 
/// (2) A 256-entry histogram is built of the gray values in pixs.
/// If pixm exists, the pixels contributing to the histogram are
/// restricted to the fg of pixm.  A colormap and LUT are generated
/// from this histogram.  We break up the array into a set
/// of intervals, each one constituting a color in the colormap:
/// An interval is identified by summing histogram bins until
/// either the sum equals or exceeds the %minfract of the total
/// number of pixels, or the span itself equals or exceeds %maxsize.
/// The color of each bin is always an average of the pixels
/// that constitute it.<para/>
/// 
/// (3) Note that we do not specify the number of gray colors in
/// the colormap.  Instead, we specify two parameters that
/// describe the accuracy of the color assignments this and
/// the actual image determine the number of resulting colors.<para/>
/// 
/// (4) If a mask exists and it is not the same size as pixs, make
/// a new mask the same size as pixs, with the original mask
/// aligned at the UL corners.  Set all additional pixels
/// in the (larger) new mask set to 1, causing those pixels
/// in pixd to be set as gray.<para/>
/// 
/// (5) We estimate the total number of colors (color plus gray)
/// if it exceeds 255, return null.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGrayQuantFromHisto/*"/>
///  <param name="pixd">[in][optional] - quantized pix with cmap can be null</param>
///  <param name="pixs">[in] - 8 bpp gray input pix not cmapped</param>
///  <param name="pixm">[in][optional] - mask over pixels in pixs to quantize</param>
///  <param name="minfract">[in] - minimum fraction of pixels in a set of adjacent histo bins that causes the set to be automatically set aside as a color in the colormap must be at least 0.01</param>
///  <param name="maxsize">[in] - maximum number of adjacent bins allowed to represent a color, regardless of the population of pixels in the bins must be at least 2</param>
///   <returns>pixd 8 bpp, cmapped, or NULL on error</returns>
public static Pix pixGrayQuantFromHisto(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm, 
				 Single minfract, 
				 int maxsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	IntPtr _Result = Natives.pixGrayQuantFromHisto(pixdPtr, pixs.Pointer, pixmPtr,   minfract,   maxsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// grayquant.c (2564, 1)
// pixGrayQuantFromCmap(pixs, cmap, mindepth) as Pix
// pixGrayQuantFromCmap(PIX *, PIXCMAP *, l_int32) as PIX *
///  <summary>
/// (1) In use, pixs is an 8 bpp grayscale image without a colormap.
/// If there is an existing colormap, a warning is issued and
/// a copy of the input pixs is returned.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGrayQuantFromCmap/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale without cmap</param>
///  <param name="cmap">[in] - to quantize to of dest pix</param>
///  <param name="mindepth">[in] - minimum depth of pixd: can be 2, 4 or 8 bpp</param>
///   <returns>pixd 2, 4 or 8 bpp, colormapped, or NULL on error</returns>
public static Pix pixGrayQuantFromCmap(
				 Pix pixs, 
				 PixColormap cmap, 
				 int mindepth){

	IntPtr _Result = Natives.pixGrayQuantFromCmap(pixs.Pointer, cmap.Pointer,   mindepth);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}


}
}
