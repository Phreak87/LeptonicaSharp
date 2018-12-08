using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// binarize.c (140, 1)
		// pixOtsuAdaptiveThreshold(pixs, sx, sy, smoothx, smoothy, scorefract, ppixth, ppixd) as int
		// pixOtsuAdaptiveThreshold(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, PIX **, PIX **) as l_ok
		///  <summary>
		/// (1) The Otsu method finds a single global threshold for an image.
		/// This function allows a locally adapted threshold to be
		/// found for each tile into which the image is broken up.<para/>
		///
		/// (2) The array of threshold values, one for each tile, constitutes
		/// a highly downscaled image.  This array is optionally
		/// smoothed using a convolution.  The full width and height of the
		/// convolution kernel are (2  %smoothx + 1) and (2  %smoothy + 1).<para/>
		///
		/// (3) The minimum tile dimension allowed is 16.  If such small
		/// tiles are used, it is recommended to use smoothing, because
		/// without smoothing, each small tile determines the splitting
		/// threshold independently.  A tile that is entirely in the
		/// image bg will then hallucinate fg, resulting in a very noisy
		/// binarization.  The smoothing should be large enough that no
		/// tile is only influenced by one type (fg or bg) of pixels,
		/// because it will force a split of its pixels.<para/>
		///
		/// (4) To get a single global threshold for the entire image, use
		/// input values of %sx and %sy that are larger than the image.
		/// For this situation, the smoothing parameters are ignored.<para/>
		///
		/// (5) The threshold values partition the image pixels into two classes:
		/// one whose values are less than the threshold and another
		/// whose values are greater than or equal to the threshold.
		/// This is the same use of 'threshold' as in pixThresholdToBinary().<para/>
		///
		/// (6) The scorefract is the fraction of the maximum Otsu score, which
		/// is used to determine the range over which the histogram minimum
		/// is searched.  See numaSplitDistribution() for details on the
		/// underlying method of choosing a threshold.<para/>
		///
		/// (7) This uses enables a modified version of the Otsu criterion for
		/// splitting the distribution of pixels in each tile into a
		/// fg and bg part.  The modification consists of searching for
		/// a minimum in the histogram over a range of pixel values where
		/// the Otsu score is within a defined fraction, %scorefract,
		/// of the max score.  To get the original Otsu algorithm, set
		/// %scorefract == 0.<para/>
		///
		/// (8) N.B. This method is NOT recommended for images with weak text
		/// and significant background noise, such as bleedthrough, because
		/// of the problem noted in (3) above for tiling.  Use Sauvola.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOtsuAdaptiveThreshold/*"/>
		///  <param name="pixs">[in] - 8 bpp</param>
		///  <param name="sx">[in] - desired tile dimensions actual size may vary</param>
		///  <param name="sy">[in] - desired tile dimensions actual size may vary</param>
		///  <param name="smoothx">[in] - half-width of convolution kernel applied to threshold array: use 0 for no smoothing</param>
		///  <param name="smoothy">[in] - half-width of convolution kernel applied to threshold array: use 0 for no smoothing</param>
		///  <param name="scorefract">[in] - fraction of the max Otsu score typ. 0.1 use 0.0 for standard Otsu</param>
		///  <param name="ppixth">[out][optional] - array of threshold values found for each tile</param>
		///  <param name="ppixd">[out][optional] - thresholded input pixs, based on the threshold array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixOtsuAdaptiveThreshold(
						Pix pixs,
						int sx,
						int sy,
						int smoothx,
						int smoothy,
						Single scorefract,
						out Pix ppixth,
						out Pix ppixd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
			IntPtr ppixthPtr = IntPtr.Zero;
			IntPtr ppixdPtr = IntPtr.Zero;
			int _Result = Natives.pixOtsuAdaptiveThreshold(pixs.Pointer,   sx,   sy,   smoothx,   smoothy,   scorefract, out ppixthPtr, out ppixdPtr);
			if (ppixthPtr == IntPtr.Zero) {ppixth = null;} else { ppixth = new Pix(ppixthPtr); };
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			return _Result;
		}

		// binarize.c (256, 1)
		// pixOtsuThreshOnBackgroundNorm(pixs, pixim, sx, sy, thresh, mincount, bgval, smoothx, smoothy, scorefract, pthresh) as Pix
		// pixOtsuThreshOnBackgroundNorm(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as PIX *
		///  <summary>
		/// (1) This does background normalization followed by Otsu
		/// thresholding.  Otsu binarization attempts to split the
		/// image into two roughly equal sets of pixels, and it does
		/// a very poor job when there are large amounts of dark
		/// background.  By doing a background normalization first,
		/// to get the background near 255, we remove this problem.
		/// Then we use a modified Otsu to estimate the best global
		/// threshold on the normalized image.<para/>
		///
		/// (2) See pixBackgroundNorm() for meaning and typical values
		/// of input parameters.  For a start, you can try:
		/// sx, sy = 10, 15
		/// thresh = 100
		/// mincount = 50
		/// bgval = 255
		/// smoothx, smoothy = 2
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOtsuThreshOnBackgroundNorm/*"/>
		///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
		///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
		///  <param name="sx">[in] - tile size in pixels</param>
		///  <param name="sy">[in] - tile size in pixels</param>
		///  <param name="thresh">[in] - threshold for determining foreground</param>
		///  <param name="mincount">[in] - min threshold on counts in a tile</param>
		///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
		///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
		///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
		///  <param name="scorefract">[in] - fraction of the max Otsu score typ. 0.1</param>
		///  <param name="pthresh">[out][optional] - threshold value that was used on the normalized image</param>
		///   <returns>pixd 1 bpp thresholded image, or NULL on error</returns>
		public static Pix pixOtsuThreshOnBackgroundNorm(
						Pix pixs,
						Pix pixim,
						int sx,
						int sy,
						int thresh,
						int mincount,
						int bgval,
						int smoothx,
						int smoothy,
						Single scorefract,
						out int pthresh)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
			IntPtr _Result = Natives.pixOtsuThreshOnBackgroundNorm(pixs.Pointer, piximPtr,   sx,   sy,   thresh,   mincount,   bgval,   smoothx,   smoothy,   scorefract, out  pthresh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// binarize.c (354, 1)
		// pixMaskedThreshOnBackgroundNorm(pixs, pixim, sx, sy, thresh, mincount, smoothx, smoothy, scorefract, pthresh) as Pix
		// pixMaskedThreshOnBackgroundNorm(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as PIX *
		///  <summary>
		/// (1) This begins with a standard background normalization.
		/// Additionally, there is a flexible background norm, that
		/// will adapt to a rapidly varying background, and this
		/// puts white pixels in the background near regions with
		/// significant foreground.  The white pixels are turned into
		/// a 1 bpp selection mask by binarization followed by dilation.
		/// Otsu thresholding is performed on the input image to get an
		/// estimate of the threshold in the non-mask regions.
		/// The background normalized image is thresholded with two
		/// different values, and the result is combined using
		/// the selection mask.<para/>
		///
		/// (2) Note that the numbers 255 (for bgval target) and 190 (for
		/// thresholding on pixn) are tied together, and explicitly
		/// defined in this function.<para/>
		///
		/// (3) See pixBackgroundNorm() for meaning and typical values
		/// of input parameters.  For a start, you can try:
		/// sx, sy = 10, 15
		/// thresh = 100
		/// mincount = 50
		/// smoothx, smoothy = 2
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMaskedThreshOnBackgroundNorm/*"/>
		///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
		///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
		///  <param name="sx">[in] - tile size in pixels</param>
		///  <param name="sy">[in] - tile size in pixels</param>
		///  <param name="thresh">[in] - threshold for determining foreground</param>
		///  <param name="mincount">[in] - min threshold on counts in a tile</param>
		///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
		///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
		///  <param name="scorefract">[in] - fraction of the max Otsu score typ. ~ 0.1</param>
		///  <param name="pthresh">[out][optional] - threshold value that was used on the normalized image</param>
		///   <returns>pixd 1 bpp thresholded image, or NULL on error</returns>
		public static Pix pixMaskedThreshOnBackgroundNorm(
						Pix pixs,
						Pix pixim,
						int sx,
						int sy,
						int thresh,
						int mincount,
						int smoothx,
						int smoothy,
						Single scorefract,
						out int pthresh)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
			IntPtr _Result = Natives.pixMaskedThreshOnBackgroundNorm(pixs.Pointer, piximPtr,   sx,   sy,   thresh,   mincount,   smoothx,   smoothy,   scorefract, out  pthresh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// binarize.c (468, 1)
		// pixSauvolaBinarizeTiled(pixs, whsize, factor, nx, ny, ppixth, ppixd) as int
		// pixSauvolaBinarizeTiled(PIX *, l_int32, l_float32, l_int32, l_int32, PIX **, PIX **) as l_ok
		///  <summary>
		/// (1) The window width and height are 2  %whsize + 1.  The minimum
		/// value for %whsize is 2 typically it is greater or equal 7..<para/>
		///
		/// (2) For nx == ny == 1, this defaults to pixSauvolaBinarize().<para/>
		///
		/// (3) Why a tiled version?
		/// (a) Because the mean value accumulator is a uint32, overflow
		/// can occur for an image with more than 16M pixels.
		/// (b) The mean value accumulator array for 16M pixels is 64 MB.
		/// The mean square accumulator array for 16M pixels is 128 MB.
		/// Using tiles reduces the size of these arrays.
		/// (c) Each tile can be processed independently, in parallel,
		/// on a multicore processor.<para/>
		///
		/// (4) The Sauvola threshold is determined from the formula:
		/// t = m  (1 - k  (1 - s / 128))
		/// See pixSauvolaBinarize() for details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSauvolaBinarizeTiled/*"/>
		///  <param name="pixs">[in] - 8 bpp grayscale, not colormapped</param>
		///  <param name="whsize">[in] - window half-width for measuring local statistics</param>
		///  <param name="factor">[in] - factor for reducing threshold due to variance greater or equal 0</param>
		///  <param name="nx">[in] - subdivision into tiles greater or equal 1</param>
		///  <param name="ny">[in] - subdivision into tiles greater or equal 1</param>
		///  <param name="ppixth">[out][optional] - Sauvola threshold values</param>
		///  <param name="ppixd">[out][optional] - thresholded image</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSauvolaBinarizeTiled(
						Pix pixs,
						int whsize,
						Single factor,
						int nx,
						int ny,
						out Pix ppixth,
						out Pix ppixd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr ppixthPtr = IntPtr.Zero;
			IntPtr ppixdPtr = IntPtr.Zero;
			int _Result = Natives.pixSauvolaBinarizeTiled(pixs.Pointer,   whsize,   factor,   nx,   ny, out ppixthPtr, out ppixdPtr);
			if (ppixthPtr == IntPtr.Zero) {ppixth = null;} else { ppixth = new Pix(ppixthPtr); };
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			return _Result;
		}

		// binarize.c (595, 1)
		// pixSauvolaBinarize(pixs, whsize, factor, addborder, ppixm, ppixsd, ppixth, ppixd) as int
		// pixSauvolaBinarize(PIX *, l_int32, l_float32, l_int32, PIX **, PIX **, PIX **, PIX **) as l_ok
		///  <summary>
		/// (1) The window width and height are 2  %whsize + 1.  The minimum
		/// value for %whsize is 2 typically it is greater or equal 7..<para/>
		///
		/// (2) The local statistics, measured over the window, are the
		/// average and standard deviation.<para/>
		///
		/// (3) The measurements of the mean and standard deviation are
		/// performed inside a border of (%whsize + 1) pixels.  If pixs does
		/// not have these added border pixels, use %addborder = 1 to add
		/// it here otherwise use %addborder = 0.<para/>
		///
		/// (4) The Sauvola threshold is determined from the formula:
		/// t = m  (1 - k  (1 - s / 128))
		/// where:
		/// t = local threshold
		/// m = local mean
		/// k = %factor (greater or equal 0) [ typ. 0.35 ]
		/// s = local standard deviation, which is maximized at
		/// 127.5 when half the samples are 0 and half are 255.<para/>
		///
		/// (5) The basic idea of Niblack and Sauvola binarization is that
		/// the local threshold should be less than the median value,
		/// and the larger the variance, the closer to the median
		/// it should be chosen.  Typical values for k are between
		/// 0.2 and 0.5.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSauvolaBinarize/*"/>
		///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
		///  <param name="whsize">[in] - window half-width for measuring local statistics</param>
		///  <param name="factor">[in] - factor for reducing threshold due to variance greater or equal 0</param>
		///  <param name="addborder">[in] - 1 to add border of width (%whsize + 1) on all sides</param>
		///  <param name="ppixm">[out][optional] - local mean values</param>
		///  <param name="ppixsd">[out][optional] - local standard deviation values</param>
		///  <param name="ppixth">[out][optional] - threshold values</param>
		///  <param name="ppixd">[out][optional] - thresholded image</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSauvolaBinarize(
						Pix pixs,
						int whsize,
						Single factor,
						int addborder,
						out Pix ppixm,
						out Pix ppixsd,
						out Pix ppixth,
						out Pix ppixd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr ppixmPtr = IntPtr.Zero;
			IntPtr ppixsdPtr = IntPtr.Zero;
			IntPtr ppixthPtr = IntPtr.Zero;
			IntPtr ppixdPtr = IntPtr.Zero;
			int _Result = Natives.pixSauvolaBinarize(pixs.Pointer,   whsize,   factor,   addborder, out ppixmPtr, out ppixsdPtr, out ppixthPtr, out ppixdPtr);
			if (ppixmPtr == IntPtr.Zero) {ppixm = null;} else { ppixm = new Pix(ppixmPtr); };
			if (ppixsdPtr == IntPtr.Zero) {ppixsd = null;} else { ppixsd = new Pix(ppixsdPtr); };
			if (ppixthPtr == IntPtr.Zero) {ppixth = null;} else { ppixth = new Pix(ppixthPtr); };
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			return _Result;
		}

		// binarize.c (705, 1)
		// pixSauvolaGetThreshold(pixm, pixms, factor, ppixsd) as Pix
		// pixSauvolaGetThreshold(PIX *, PIX *, l_float32, PIX **) as PIX *
		///  <summary>
		/// (1) The Sauvola threshold is determined from the formula:
		/// t = m  (1 - k  (1 - s / 128))
		/// where:
		/// t = local threshold
		/// m = local mean
		/// k = %factor (greater or equal 0) [ typ. 0.35 ]
		/// s = local standard deviation, which is maximized at
		/// 127.5 when half the samples are 0 and half are 255.<para/>
		///
		/// (2) See pixSauvolaBinarize() for other details.<para/>
		///
		/// (3) Important definitions and relations for computing averages:
		/// v == pixel value
		/// E(p) == expected value of p == average of p over some pixel set
		/// S(v) == square of v == v  v
		/// mv == E(v) == expected pixel value == mean value
		/// ms == E(S(v)) == expected square of pixel values
		/// == mean square value
		/// var == variance == expected square of deviation from mean
		/// == E(S(v - mv)) = E(S(v) - 2  S(v  mv) + S(mv))
		/// = E(S(v)) - S(mv)
		/// = ms - mv  mv
		/// s == standard deviation = sqrt(var)
		/// So for evaluating the standard deviation in the Sauvola
		/// threshold, we take
		/// s = sqrt(ms - mv  mv)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSauvolaGetThreshold/*"/>
		///  <param name="pixm">[in] - 8 bpp grayscale not colormapped</param>
		///  <param name="pixms">[in] - 32 bpp</param>
		///  <param name="factor">[in] - factor for reducing threshold due to variance greater or equal 0</param>
		///  <param name="ppixsd">[out][optional] - local standard deviation</param>
		///   <returns>pixd 8 bpp, sauvola threshold values, or NULL on error</returns>
		public static Pix pixSauvolaGetThreshold(
						Pix pixm,
						Pix pixms,
						Single factor,
						out Pix ppixsd)
		{
			if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}

			if (pixms == null) {throw new ArgumentNullException  ("pixms cannot be Nothing");}

			IntPtr ppixsdPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixSauvolaGetThreshold(pixm.Pointer, pixms.Pointer,   factor, out ppixsdPtr);
			if (ppixsdPtr == IntPtr.Zero) {ppixsd = null;} else { ppixsd = new Pix(ppixsdPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// binarize.c (788, 1)
		// pixApplyLocalThreshold(pixs, pixth, redfactor) as Pix
		// pixApplyLocalThreshold(PIX *, PIX *, l_int32) as PIX *
		///  <summary>
		/// pixApplyLocalThreshold()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixApplyLocalThreshold/*"/>
		///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
		///  <param name="pixth">[in] - 8 bpp array of local thresholds</param>
		///  <param name="redfactor">[in] - ...</param>
		///   <returns>pixd 1 bpp, thresholded image, or NULL on error</returns>
		public static Pix pixApplyLocalThreshold(
						Pix pixs,
						Pix pixth,
						int redfactor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (pixth == null) {throw new ArgumentNullException  ("pixth cannot be Nothing");}

			IntPtr _Result = Natives.pixApplyLocalThreshold(pixs.Pointer, pixth.Pointer,   redfactor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// binarize.c (887, 1)
		// pixThresholdByConnComp(pixs, pixm, start, end, incr, thresh48, threshdiff, pglobthresh, ppixd, debugflag) as int
		// pixThresholdByConnComp(PIX *, PIX *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32 *, PIX **, l_int32) as l_ok
		///  <summary>
		/// (1) This finds a global threshold based on connected components.
		/// Although slow, it is reasonable to use it in a situation where
		/// (a) the background in the image is relatively uniform, and
		/// (b) the result will be fed to an OCR program that accepts 1 bpp
		/// images and works best with easily segmented characters.
		/// The reason for (b) is that this selects a threshold with a
		/// minimum number of both broken characters and merged characters.<para/>
		///
		/// (2) If the pix has color, it is converted to gray using the
		/// max component.<para/>
		///
		/// (3) Input 0 to use default values for any of these inputs:
		/// %start, %end, %incr, %thresh48, %threshdiff.<para/>
		///
		/// (4) This approach can be understood as follows.  When the
		/// binarization threshold is varied, the numbers of c.c. identify
		/// four regimes:
		/// (a) For low thresholds, text is broken into small pieces, and
		/// the number of c.c. is large, with the 4 c.c. significantly
		/// exceeding the 8 c.c.
		/// (b) As the threshold rises toward the optimum value, the text
		/// characters coalesce and there is very little difference
		/// between the numbers of 4 and 8 c.c, which both go
		/// through a minimum.
		/// (c) Above this, the image background gets noisy because some
		/// pixels are(thresholded to foreground, and the numbers
		/// of c.c. quickly increase, with the 4 c.c. significantly
		/// larger than the 8 c.c.
		/// (d) At even higher thresholds, the image background noise
		/// coalesces as it becomes mostly foreground, and the
		/// number of c.c. drops quickly.<para/>
		///
		/// (5) If there is no global threshold that distinguishes foreground
		/// text from background (e.g., weak text over a background that
		/// has significant variation and/or bleedthrough), this returns 1,
		/// which the caller should check.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdByConnComp/*"/>
		///  <param name="pixs">[in] - depth  is greater  1, colormap OK</param>
		///  <param name="pixm">[in][optional] - 1 bpp mask giving region to ignore by setting pixels to white use NULL if no mask</param>
		///  <param name="start">[in] - binarization threshold levels to test</param>
		///  <param name="incr">[in] - binarization threshold levels to test</param>
		///  <param name="thresh48">[in] - threshold on normalized difference between the numbers of 4 and 8 connected components</param>
		///  <param name="threshdiff">[in] - threshold on normalized difference between the number of 4 cc at successive iterations</param>
		///  <param name="pglobthresh">[out][optional] - best global threshold 0 if no threshold is found</param>
		///  <param name="ppixd">[out][optional] - image thresholded to binary, or null if no threshold is found</param>
		///  <param name="debugflag">[in] - 1 for plotted results</param>
		///   <returns>0 if OK, 1 on error or if no threshold is found</returns>
		public static int pixThresholdByConnComp(
						Pix pixs,
						Pix pixm,
						int start,
						int _end_,
						int incr,
						Single thresh48,
						Single threshdiff,
						out int pglobthresh,
						out Pix ppixd,
						int debugflag)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}
			IntPtr ppixdPtr = IntPtr.Zero;
			int _Result = Natives.pixThresholdByConnComp(pixs.Pointer, pixmPtr,   start,   _end_,   incr,   thresh48,   threshdiff, out  pglobthresh, out ppixdPtr,   debugflag);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			return _Result;
		}


	}
}
