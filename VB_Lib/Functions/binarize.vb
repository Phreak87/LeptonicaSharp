Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\binarize.c (140, 1)
' pixOtsuAdaptiveThreshold(pixs, sx, sy, smoothx, smoothy, scorefract, ppixth, ppixd) as Integer
' pixOtsuAdaptiveThreshold(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The Otsu method finds a single global threshold for an image.<para/>
''' This function allows a locally adapted threshold to be<para/>
''' found for each tile into which the image is broken up.<para/>
''' (2) The array of threshold values, one for each tile, constitutes<para/>
''' a highly downscaled image.  This array is optionally<para/>
''' smoothed using a convolution.  The full width and height of the<para/>
''' convolution kernel are (2  %smoothx + 1) and (2  %smoothy + 1).<para/>
''' (3) The minimum tile dimension allowed is 16.  If such small<para/>
''' tiles are used, it is recommended to use smoothing, because<para/>
''' without smoothing, each small tile determines the splitting<para/>
''' threshold independently.  A tile that is entirely in the<para/>
''' image bg will then hallucinate fg, resulting in a very noisy<para/>
''' binarization.  The smoothing should be large enough that no<para/>
''' tile is only influenced by one type (fg or bg) of pixels,<para/>
''' because it will force a split of its pixels.<para/>
''' (4) To get a single global threshold for the entire image, use<para/>
''' input values of %sx and %sy that are larger than the image.<para/>
''' For this situation, the smoothing parameters are ignored.<para/>
''' (5) The threshold values partition the image pixels into two classes:<para/>
''' one whose values are less than the threshold and another<para/>
''' whose values are greater than or equal to the threshold.<para/>
''' This is the same use of 'threshold' as in pixThresholdToBinary().<para/>
''' (6) The scorefract is the fraction of the maximum Otsu score, which<para/>
''' is used to determine the range over which the histogram minimum<para/>
''' is searched.  See numaSplitDistribution() for details on the<para/>
''' underlying method of choosing a threshold.<para/>
''' (7) This uses enables a modified version of the Otsu criterion for<para/>
''' splitting the distribution of pixels in each tile into a<para/>
''' fg and bg part.  The modification consists of searching for<para/>
''' a minimum in the histogram over a range of pixel values where<para/>
''' the Otsu score is within a defined fraction, %scorefract,<para/>
''' of the max score.  To get the original Otsu algorithm, set<para/>
''' %scorefract == 0.<para/>
''' (8) N.B. This method is NOT recommended for images with weak text<para/>
''' and significant background noise, such as bleedthrough, because<para/>
''' of the problem noted in (3) above for tiling.  Use Sauvola.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="sx">[in] - desired tile dimensions actual size may vary</param>
'''  <param name="sy">[in] - desired tile dimensions actual size may vary</param>
'''  <param name="smoothx">[in] - half-width of convolution kernel applied to threshold array: use 0 for no smoothing</param>
'''  <param name="smoothy">[in] - half-width of convolution kernel applied to threshold array: use 0 for no smoothing</param>
'''  <param name="scorefract">[in] - fraction of the max Otsu score typ. 0.1 use 0.0 for standard Otsu</param>
'''  <param name="ppixth">[out][optional] - array of threshold values found for each tile</param>
'''  <param name="ppixd">[out][optional] - thresholded input pixs, based on the threshold array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixOtsuAdaptiveThreshold(
				 ByVal pixs as Pix, 
				 ByVal sx as Integer, 
				 ByVal sy as Integer, 
				 ByVal smoothx as Integer, 
				 ByVal smoothy as Integer, 
				 ByVal scorefract as Single, 
				<Out()> ByRef ppixth as Pix, 
				<Out()> ByRef ppixd as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

Dim ppixthPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixth) Then ppixthPTR = ppixth.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixOtsuAdaptiveThreshold( pixs.Pointer, sx, sy, smoothx, smoothy, scorefract, ppixthPTR, ppixdPTR)
	if ppixthPTR <> IntPtr.Zero then ppixth = new Pix(ppixthPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\binarize.c (256, 1)
' pixOtsuThreshOnBackgroundNorm(pixs, pixim, sx, sy, thresh, mincount, bgval, smoothx, smoothy, scorefract, pthresh) as Pix
' pixOtsuThreshOnBackgroundNorm(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does background normalization followed by Otsu<para/>
''' thresholding.  Otsu binarization attempts to split the<para/>
''' image into two roughly equal sets of pixels, and it does<para/>
''' a very poor job when there are large amounts of dark<para/>
''' background.  By doing a background normalization first,<para/>
''' to get the background near 255, we remove this problem.<para/>
''' Then we use a modified Otsu to estimate the best global<para/>
''' threshold on the normalized image.<para/>
''' (2) See pixBackgroundNorm() for meaning and typical values<para/>
''' of input parameters.  For a start, you can try:<para/>
''' sx, sy = 10, 15<para/>
''' thresh = 100<para/>
''' mincount = 50<para/>
''' bgval = 255<para/>
''' smoothx, smoothy = 2<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
'''  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
'''  <param name="sx">[in] - tile size in pixels</param>
'''  <param name="sy">[in] - tile size in pixels</param>
'''  <param name="thresh">[in] - threshold for determining foreground</param>
'''  <param name="mincount">[in] - min threshold on counts in a tile</param>
'''  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
'''  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
'''  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
'''  <param name="scorefract">[in] - fraction of the max Otsu score typ. 0.1</param>
'''  <param name="pthresh">[out][optional] - threshold value that was used on the normalized image</param>
'''   <returns>pixd 1 bpp thresholded image, or NULL on error</returns>
Public Shared Function pixOtsuThreshOnBackgroundNorm(
				 ByVal pixs as Pix, 
				 ByVal pixim as Pix, 
				 ByVal sx as Integer, 
				 ByVal sy as Integer, 
				 ByVal thresh as Integer, 
				 ByVal mincount as Integer, 
				 ByVal bgval as Integer, 
				 ByVal smoothx as Integer, 
				 ByVal smoothy as Integer, 
				 ByVal scorefract as Single, 
				<Out()> ByRef pthresh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



	Dim piximPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixim) Then piximPTR = pixim.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOtsuThreshOnBackgroundNorm( pixs.Pointer, piximPTR, sx, sy, thresh, mincount, bgval, smoothx, smoothy, scorefract, pthresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\binarize.c (354, 1)
' pixMaskedThreshOnBackgroundNorm(pixs, pixim, sx, sy, thresh, mincount, smoothx, smoothy, scorefract, pthresh) as Pix
' pixMaskedThreshOnBackgroundNorm(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This begins with a standard background normalization.<para/>
''' Additionally, there is a flexible background norm, that<para/>
''' will adapt to a rapidly varying background, and this<para/>
''' puts white pixels in the background near regions with<para/>
''' significant foreground.  The white pixels are turned into<para/>
''' a 1 bpp selection mask by binarization followed by dilation.<para/>
''' Otsu thresholding is performed on the input image to get an<para/>
''' estimate of the threshold in the non-mask regions.<para/>
''' The background normalized image is thresholded with two<para/>
''' different values, and the result is combined using<para/>
''' the selection mask.<para/>
''' (2) Note that the numbers 255 (for bgval target) and 190 (for<para/>
''' thresholding on pixn) are tied together, and explicitly<para/>
''' defined in this function.<para/>
''' (3) See pixBackgroundNorm() for meaning and typical values<para/>
''' of input parameters.  For a start, you can try:<para/>
''' sx, sy = 10, 15<para/>
''' thresh = 100<para/>
''' mincount = 50<para/>
''' smoothx, smoothy = 2<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
'''  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
'''  <param name="sx">[in] - tile size in pixels</param>
'''  <param name="sy">[in] - tile size in pixels</param>
'''  <param name="thresh">[in] - threshold for determining foreground</param>
'''  <param name="mincount">[in] - min threshold on counts in a tile</param>
'''  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
'''  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
'''  <param name="scorefract">[in] - fraction of the max Otsu score typ. ~ 0.1</param>
'''  <param name="pthresh">[out][optional] - threshold value that was used on the normalized image</param>
'''   <returns>pixd 1 bpp thresholded image, or NULL on error</returns>
Public Shared Function pixMaskedThreshOnBackgroundNorm(
				 ByVal pixs as Pix, 
				 ByVal pixim as Pix, 
				 ByVal sx as Integer, 
				 ByVal sy as Integer, 
				 ByVal thresh as Integer, 
				 ByVal mincount as Integer, 
				 ByVal smoothx as Integer, 
				 ByVal smoothy as Integer, 
				 ByVal scorefract as Single, 
				<Out()> ByRef pthresh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



	Dim piximPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixim) Then piximPTR = pixim.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMaskedThreshOnBackgroundNorm( pixs.Pointer, piximPTR, sx, sy, thresh, mincount, smoothx, smoothy, scorefract, pthresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\binarize.c (468, 1)
' pixSauvolaBinarizeTiled(pixs, whsize, factor, nx, ny, ppixth, ppixd) as Integer
' pixSauvolaBinarizeTiled(PIX *, l_int32, l_float32, l_int32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The window width and height are 2  %whsize + 1.  The minimum<para/>
''' value for %whsize is 2 typically it is  is greater = 7..<para/>
''' (2) For nx == ny == 1, this defaults to pixSauvolaBinarize().<para/>
''' (3) Why a tiled version?<para/>
''' (a) Because the mean value accumulator is a uint32, overflow<para/>
''' can occur for an image with more than 16M pixels.<para/>
''' (b) The mean value accumulator array for 16M pixels is 64 MB.<para/>
''' The mean square accumulator array for 16M pixels is 128 MB.<para/>
''' Using tiles reduces the size of these arrays.<para/>
''' (c) Each tile can be processed independently, in parallel,<para/>
''' on a multicore processor.<para/>
''' (4) The Sauvola threshold is determined from the formula:<para/>
''' t = m  (1 - k  (1 - s / 128))<para/>
''' See pixSauvolaBinarize() for details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale, not colormapped</param>
'''  <param name="whsize">[in] - window half-width for measuring local statistics</param>
'''  <param name="factor">[in] - factor for reducing threshold due to variance  is greater = 0</param>
'''  <param name="nx">[in] - subdivision into tiles  is greater = 1</param>
'''  <param name="ny">[in] - subdivision into tiles  is greater = 1</param>
'''  <param name="ppixth">[out][optional] - Sauvola threshold values</param>
'''  <param name="ppixd">[out][optional] - thresholded image</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSauvolaBinarizeTiled(
				 ByVal pixs as Pix, 
				 ByVal whsize as Integer, 
				 ByVal factor as Single, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				<Out()> ByRef ppixth as Pix, 
				<Out()> ByRef ppixd as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



Dim ppixthPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixth) Then ppixthPTR = ppixth.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSauvolaBinarizeTiled( pixs.Pointer, whsize, factor, nx, ny, ppixthPTR, ppixdPTR)
	if ppixthPTR <> IntPtr.Zero then ppixth = new Pix(ppixthPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\binarize.c (595, 1)
' pixSauvolaBinarize(pixs, whsize, factor, addborder, ppixm, ppixsd, ppixth, ppixd) as Integer
' pixSauvolaBinarize(PIX *, l_int32, l_float32, l_int32, PIX **, PIX **, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The window width and height are 2  %whsize + 1.  The minimum<para/>
''' value for %whsize is 2 typically it is  is greater = 7..<para/>
''' (2) The local statistics, measured over the window, are the<para/>
''' average and standard deviation.<para/>
''' (3) The measurements of the mean and standard deviation are<para/>
''' performed inside a border of (%whsize + 1) pixels.  If pixs does<para/>
''' not have these added border pixels, use %addborder = 1 to add<para/>
''' it here otherwise use %addborder = 0.<para/>
''' (4) The Sauvola threshold is determined from the formula:<para/>
''' t = m  (1 - k  (1 - s / 128))<para/>
''' where:<para/>
''' t = local threshold<para/>
''' m = local mean<para/>
''' k = %factor ( is greater = 0) [ typ. 0.35 ]<para/>
''' s = local standard deviation, which is maximized at<para/>
''' 127.5 when half the samples are 0 and half are 255.<para/>
''' (5) The basic idea of Niblack and Sauvola binarization is that<para/>
''' the local threshold should be less than the median value,<para/>
''' and the larger the variance, the closer to the median<para/>
''' it should be chosen.  Typical values for k are between<para/>
''' 0.2 and 0.5.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
'''  <param name="whsize">[in] - window half-width for measuring local statistics</param>
'''  <param name="factor">[in] - factor for reducing threshold due to variance  is greater = 0</param>
'''  <param name="addborder">[in] - 1 to add border of width (%whsize + 1) on all sides</param>
'''  <param name="ppixm">[out][optional] - local mean values</param>
'''  <param name="ppixsd">[out][optional] - local standard deviation values</param>
'''  <param name="ppixth">[out][optional] - threshold values</param>
'''  <param name="ppixd">[out][optional] - thresholded image</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSauvolaBinarize(
				 ByVal pixs as Pix, 
				 ByVal whsize as Integer, 
				 ByVal factor as Single, 
				 ByVal addborder as Integer, 
				<Out()> ByRef ppixm as Pix, 
				<Out()> ByRef ppixsd as Pix, 
				<Out()> ByRef ppixth as Pix, 
				<Out()> ByRef ppixd as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



Dim ppixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixm) Then ppixmPTR = ppixm.Pointer
Dim ppixsdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsd) Then ppixsdPTR = ppixsd.Pointer
Dim ppixthPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixth) Then ppixthPTR = ppixth.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSauvolaBinarize( pixs.Pointer, whsize, factor, addborder, ppixmPTR, ppixsdPTR, ppixthPTR, ppixdPTR)
	if ppixmPTR <> IntPtr.Zero then ppixm = new Pix(ppixmPTR)
	if ppixsdPTR <> IntPtr.Zero then ppixsd = new Pix(ppixsdPTR)
	if ppixthPTR <> IntPtr.Zero then ppixth = new Pix(ppixthPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\binarize.c (705, 1)
' pixSauvolaGetThreshold(pixm, pixms, factor, ppixsd) as Pix
' pixSauvolaGetThreshold(PIX *, PIX *, l_float32, PIX **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The Sauvola threshold is determined from the formula:<para/>
''' t = m  (1 - k  (1 - s / 128))<para/>
''' where:<para/>
''' t = local threshold<para/>
''' m = local mean<para/>
''' k = %factor ( is greater = 0) [ typ. 0.35 ]<para/>
''' s = local standard deviation, which is maximized at<para/>
''' 127.5 when half the samples are 0 and half are 255.<para/>
''' (2) See pixSauvolaBinarize() for other details.<para/>
''' (3) Important definitions and relations for computing averages:<para/>
''' v == pixel value<para/>
''' E(p) == expected value of p == average of p over some pixel set<para/>
''' S(v) == square of v == v  v<para/>
''' mv == E(v) == expected pixel value == mean value<para/>
''' ms == E(S(v)) == expected square of pixel values<para/>
''' == mean square value<para/>
''' var == variance == expected square of deviation from mean<para/>
''' == E(S(v - mv)) = E(S(v) - 2  S(v  mv) + S(mv))<para/>
''' = E(S(v)) - S(mv)<para/>
''' = ms - mv  mv<para/>
''' s == standard deviation = sqrt(var)<para/>
''' So for evaluating the standard deviation in the Sauvola<para/>
''' threshold, we take<para/>
''' s = sqrt(ms - mv  mv)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixm">[in] - 8 bpp grayscale not colormapped</param>
'''  <param name="pixms">[in] - 32 bpp</param>
'''  <param name="factor">[in] - factor for reducing threshold due to variance  is greater = 0</param>
'''  <param name="ppixsd">[out][optional] - local standard deviation</param>
'''   <returns>pixd 8 bpp, sauvola threshold values, or NULL on error</returns>
Public Shared Function pixSauvolaGetThreshold(
				 ByVal pixm as Pix, 
				 ByVal pixms as Pix, 
				 ByVal factor as Single, 
				<Out()> ByRef ppixsd as Pix) as Pix

	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (pixms) then Throw New ArgumentNullException  ("pixms cannot be Nothing")



Dim ppixsdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsd) Then ppixsdPTR = ppixsd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSauvolaGetThreshold( pixm.Pointer, pixms.Pointer, factor, ppixsdPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixsdPTR <> IntPtr.Zero then ppixsd = new Pix(ppixsdPTR)

	Return  new Pix(_Result)
End Function

' SRC\binarize.c (788, 1)
' pixApplyLocalThreshold(pixs, pixth, redfactor) as Pix
' pixApplyLocalThreshold(PIX *, PIX *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
'''  <param name="pixth">[in] - 8 bpp array of local thresholds</param>
'''  <param name="redfactor">[in] - ...</param>
'''   <returns>pixd 1 bpp, thresholded image, or NULL on error</returns>
Public Shared Function pixApplyLocalThreshold(
				 ByVal pixs as Pix, 
				 ByVal pixth as Pix, 
				 ByVal redfactor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixth) then Throw New ArgumentNullException  ("pixth cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixApplyLocalThreshold( pixs.Pointer, pixth.Pointer, redfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\binarize.c (887, 1)
' pixThresholdByConnComp(pixs, pixm, start, end, incr, thresh48, threshdiff, pglobthresh, ppixd, debugflag) as Integer
' pixThresholdByConnComp(PIX *, PIX *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32 *, PIX **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds a global threshold based on connected components.<para/>
''' Although slow, it is reasonable to use it in a situation where<para/>
''' (a) the background in the image is relatively uniform, and<para/>
''' (b) the result will be fed to an OCR program that accepts 1 bpp<para/>
''' images and works best with easily segmented characters.<para/>
''' The reason for (b) is that this selects a threshold with a<para/>
''' minimum number of both broken characters and merged characters.<para/>
''' (2) If the pix has color, it is converted to gray using the<para/>
''' max component.<para/>
''' (3) Input 0 to use default values for any of these inputs:<para/>
''' %start, %end, %incr, %thresh48, %threshdiff.<para/>
''' (4) This approach can be understood as follows.  When the<para/>
''' binarization threshold is varied, the numbers of c.c. identify<para/>
''' four regimes:<para/>
''' (a) For low thresholds, text is broken into small pieces, and<para/>
''' the number of c.c. is large, with the 4 c.c. significantly<para/>
''' exceeding the 8 c.c.<para/>
''' (b) As the threshold rises toward the optimum value, the text<para/>
''' characters coalesce and there is very little difference<para/>
''' between the numbers of 4 and 8 c.c, which both go<para/>
''' through a minimum.<para/>
''' (c) Above this, the image background gets noisy because some<para/>
''' pixels are(thresholded to foreground, and the numbers<para/>
''' of c.c. quickly increase, with the 4 c.c. significantly<para/>
''' larger than the 8 c.c.<para/>
''' (d) At even higher thresholds, the image background noise<para/>
''' coalesces as it becomes mostly foreground, and the<para/>
''' number of c.c. drops quickly.<para/>
''' (5) If there is no global threshold that distinguishes foreground<para/>
''' text from background (e.g., weak text over a background that<para/>
''' has significant variation and/or bleedthrough), this returns 1,<para/>
''' which the caller should check.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - depth  is greater  1, colormap OK</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask giving region to ignore by setting pixels to white use NULL if no mask</param>
'''  <param name="start">[in] - binarization threshold levels to test</param>
'''  <param name="incr">[in] - binarization threshold levels to test</param>
'''  <param name="thresh48">[in] - threshold on normalized difference between the numbers of 4 and 8 connected components</param>
'''  <param name="threshdiff">[in] - threshold on normalized difference between the number of 4 cc at successive iterations</param>
'''  <param name="pglobthresh">[out][optional] - best global threshold 0 if no threshold is found</param>
'''  <param name="ppixd">[out][optional] - image thresholded to binary, or null if no threshold is found</param>
'''  <param name="debugflag">[in] - 1 for plotted results</param>
'''   <returns>0 if OK, 1 on error or if no threshold is found</returns>
Public Shared Function pixThresholdByConnComp(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal start as Integer, 
				 ByVal _end_ as Integer, 
				 ByVal incr as Integer, 
				 ByVal thresh48 as Single, 
				 ByVal threshdiff as Single, 
				<Out()> ByRef pglobthresh as Integer, 
				<Out()> ByRef ppixd as Pix, 
				 ByVal debugflag as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixThresholdByConnComp( pixs.Pointer, pixmPTR, start, _end_, incr, thresh48, threshdiff, pglobthresh, ppixdPTR, debugflag)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

End Class
