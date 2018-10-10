Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\numafunc2.c (165, 1)
' numaErode(nas, size) as Numa
' numaErode(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
''' (2) If size == 1, this returns a copy<para/>
''' (3) General comment.  The morphological operations are equivalent<para/>
''' to those that would be performed on a 1-dimensional fpix.<para/>
''' However, because we have not implemented morphological<para/>
''' operations on fpix, we do this here.  Because it is only<para/>
''' 1 dimensional, there is no reason to use the more<para/>
''' complicated van Herk/Gil-Werman algorithm, and we do it<para/>
''' by brute force.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad eroded, or NULL on error</returns>
Public Shared Function numaErode(
				 ByVal nas as Numa, 
				 ByVal size as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaErode( nas.Pointer, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (233, 1)
' numaDilate(nas, size) as Numa
' numaDilate(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
''' (2) If size == 1, this returns a copy<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad dilated, or NULL on error</returns>
Public Shared Function numaDilate(
				 ByVal nas as Numa, 
				 ByVal size as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaDilate( nas.Pointer, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (301, 1)
' numaOpen(nas, size) as Numa
' numaOpen(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
''' (2) If size == 1, this returns a copy<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad opened, or NULL on error</returns>
Public Shared Function numaOpen(
				 ByVal nas as Numa, 
				 ByVal size as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaOpen( nas.Pointer, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (347, 1)
' numaClose(nas, size) as Numa
' numaClose(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
''' (2) If size == 1, this returns a copy<para/>
''' (3) We add a border before doing this operation, for the same<para/>
''' reason that we add a border to a pix before doing a safe closing.<para/>
''' Without the border, a small component near the border gets<para/>
''' clipped at the border on dilation, and can be entirely removed<para/>
''' by the following erosion, violating the basic extensivity<para/>
''' property of closing.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad opened, or NULL on error</returns>
Public Shared Function numaClose(
				 ByVal nas as Numa, 
				 ByVal size as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaClose( nas.Pointer, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (394, 1)
' numaTransform(nas, shift, scale) as Numa
' numaTransform(NUMA *, l_float32, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Each number is shifted before scaling.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="shift">[in] - add this to each number</param>
'''  <param name="scale">[in] - multiply each number by this</param>
'''   <returns>nad with all values shifted and scaled, or NULL on error</returns>
Public Shared Function numaTransform(
				 ByVal nas as Numa, 
				 ByVal shift as Single, 
				 ByVal scale as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaTransform( nas.Pointer, shift, scale)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (431, 1)
' numaSimpleStats(na, first, last, pmean, pvar, prvar) as Integer
' numaSimpleStats(NUMA *, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - input numa</param>
'''  <param name="first">[in] - first element to use</param>
'''  <param name="last">[in] - last element to use 0 to go to the end</param>
'''  <param name="pmean">[out][optional] - mean value</param>
'''  <param name="pvar">[out][optional] - variance</param>
'''  <param name="prvar">[out][optional] - rms deviation from the mean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSimpleStats(
				 ByVal na as Numa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				<Out()> Optional ByRef pmean as Single = Nothing, 
				<Out()> Optional ByRef pvar as Single = Nothing, 
				<Out()> Optional ByRef prvar as Single = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSimpleStats( na.Pointer, first, last, pmean, pvar, prvar)

	Return _Result
End Function

' SRC\numafunc2.c (511, 1)
' numaWindowedStats(nas, wc, pnam, pnams, pnav, pnarv) as Integer
' numaWindowedStats(NUMA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a high-level convenience function for calculating<para/>
''' any or all of these derived arrays.<para/>
''' (2) These statistical measures over the values in the<para/>
''' rectangular window are:<para/>
''' ~ average value: [x]  (nam)<para/>
''' ~ average squared value: [xx] (nams)<para/>
''' ~ variance: [(x - [x])(x - [x])] = [xx] - [x][x]  (nav)<para/>
''' ~ square-root of variance: (narv)<para/>
''' where the brackets [ .. ] indicate that the average value is<para/>
''' to be taken over the window.<para/>
''' (3) Note that the variance is just the mean square difference from<para/>
''' the mean value and the square root of the variance is the<para/>
''' root mean square difference from the mean, sometimes also<para/>
''' called the 'standard deviation'.<para/>
''' (4) Internally, use mirrored borders to handle values near the<para/>
''' end of each array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="wc">[in] - half width of the window</param>
'''  <param name="pnam">[out][optional] - mean value in window</param>
'''  <param name="pnams">[out][optional] - mean square value in window</param>
'''  <param name="pnav">[out][optional] - variance in window</param>
'''  <param name="pnarv">[out][optional] - rms deviation from the mean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWindowedStats(
				 ByVal nas as Numa, 
				 ByVal wc as Integer, 
				<Out()> Optional ByRef pnam as Numa = Nothing, 
				<Out()> Optional ByRef pnams as Numa = Nothing, 
				<Out()> Optional ByRef pnav as Numa = Nothing, 
				<Out()> Optional ByRef pnarv as Numa = Nothing) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

Dim pnamPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnam) Then pnamPTR = pnam.Pointer
Dim pnamsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnams) Then pnamsPTR = pnams.Pointer
Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer
Dim pnarvPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnarv) Then pnarvPTR = pnarv.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaWindowedStats( nas.Pointer, wc, pnamPTR, pnamsPTR, pnavPTR, pnarvPTR)
	if pnamPTR <> IntPtr.Zero then pnam = new Numa(pnamPTR)
	if pnamsPTR <> IntPtr.Zero then pnams = new Numa(pnamsPTR)
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)
	if pnarvPTR <> IntPtr.Zero then pnarv = new Numa(pnarvPTR)

	Return _Result
End Function

' SRC\numafunc2.c (562, 1)
' numaWindowedMean(nas, wc) as Numa
' numaWindowedMean(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a convolution.  The window has width = 2  %wc + 1.<para/>
''' (2) We add a mirrored border of size %wc to each end of the array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="wc">[in] - half width of the convolution window</param>
'''   <returns>nad after low-pass filtering, or NULL on error</returns>
Public Shared Function numaWindowedMean(
				 ByVal nas as Numa, 
				 ByVal wc as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaWindowedMean( nas.Pointer, wc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (622, 1)
' numaWindowedMeanSquare(nas, wc) as Numa
' numaWindowedMeanSquare(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The window has width = 2  %wc + 1.<para/>
''' (2) We add a mirrored border of size %wc to each end of the array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="wc">[in] - half width of the window</param>
'''   <returns>nad containing windowed mean square values, or NULL on error</returns>
Public Shared Function numaWindowedMeanSquare(
				 ByVal nas as Numa, 
				 ByVal wc as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaWindowedMeanSquare( nas.Pointer, wc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (690, 1)
' numaWindowedVariance(nam, nams, pnav, pnarv) as Integer
' numaWindowedVariance(NUMA *, NUMA *, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The numas of windowed mean and mean square are precomputed,<para/>
''' using numaWindowedMean() and numaWindowedMeanSquare().<para/>
''' (2) Either or both of the variance and square-root of variance<para/>
''' are returned, where the variance is the average over the<para/>
''' window of the mean square difference of the pixel value<para/>
''' from the mean:<para/>
''' [(x - [x])(x - [x])] = [xx] - [x][x]<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nam">[in] - windowed mean values</param>
'''  <param name="nams">[in] - windowed mean square values</param>
'''  <param name="pnav">[out][optional] - numa of variance -- the ms deviation from the mean</param>
'''  <param name="pnarv">[out][optional] - numa of rms deviation from the mean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWindowedVariance(
				 ByVal nam as Numa, 
				 ByVal nams as Numa, 
				<Out()> Optional ByRef pnav as Numa = Nothing, 
				<Out()> Optional ByRef pnarv as Numa = Nothing) as Integer

	If IsNothing (nam) then Throw New ArgumentNullException  ("nam cannot be Nothing")
	If IsNothing (nams) then Throw New ArgumentNullException  ("nams cannot be Nothing")

Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer
Dim pnarvPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnarv) Then pnarvPTR = pnarv.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaWindowedVariance( nam.Pointer, nams.Pointer, pnavPTR, pnarvPTR)
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)
	if pnarvPTR <> IntPtr.Zero then pnarv = new Numa(pnarvPTR)

	Return _Result
End Function

' SRC\numafunc2.c (758, 1)
' numaWindowedMedian(nas, halfwin) as Numa
' numaWindowedMedian(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The requested window has width = 2  %halfwin + 1.<para/>
''' (2) If the input nas has less then 3 elements, return a copy.<para/>
''' (3) If the filter is too small (%halfwin  is lower = 0), return a copy.<para/>
''' (4) If the filter is too large, it is reduced in size.<para/>
''' (5) We add a mirrored border of size %halfwin to each end of<para/>
''' the array to simplify the calculation by avoiding end-effects.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - </param>
'''  <param name="halfwin">[in] - half width of window over which the median is found</param>
'''   <returns>nad after windowed median filtering, or NULL on error</returns>
Public Shared Function numaWindowedMedian(
				 ByVal nas as Numa, 
				 ByVal halfwin as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaWindowedMedian( nas.Pointer, halfwin)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (807, 1)
' numaConvertToInt(nas) as Numa
' numaConvertToInt(NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - source numa</param>
'''   <returns>na with all values rounded to nearest integer, or NULL on error</returns>
Public Shared Function numaConvertToInt(
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaConvertToInt( nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (859, 1)
' numaMakeHistogram(na, maxbins, pbinsize, pbinstart) as Numa
' numaMakeHistogram(NUMA *, l_int32, l_int32 *, l_int32 *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simple interface is designed for integer data.<para/>
''' The bins are of integer width and start on integer boundaries,<para/>
''' so the results on float data will not have high precision.<para/>
''' (2) Specify the max number of input bins. Then %binsize,<para/>
''' the size of bins necessary to accommodate the input data,<para/>
''' is returned.  It is one of the sequence:<para/>
''' {1, 2, 5, 10, 20, 50, ...}.<para/>
''' (3) If  and binstart is given, all values are accommodated,<para/>
''' and the min value of the starting bin is returned.<para/>
''' Otherwise, all negative values are discarded and<para/>
''' the histogram bins start at 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="maxbins">[in] - max number of histogram bins</param>
'''  <param name="pbinsize">[out] - size of histogram bins</param>
'''  <param name="pbinstart">[out][optional] - start val of minimum bin input NULL to force start at 0</param>
'''   <returns>na consisiting of histogram of integerized values, or NULL on error.</returns>
Public Shared Function numaMakeHistogram(
				 ByVal na as Numa, 
				 ByVal maxbins as Integer, 
				<Out()> ByRef pbinsize as Integer, 
				<Out()> Optional ByRef pbinstart as Integer = Nothing) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeHistogram( na.Pointer, maxbins, pbinsize, pbinstart)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (971, 1)
' numaMakeHistogramAuto(na, maxbins) as Numa
' numaMakeHistogramAuto(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simple interface is designed for accurate binning<para/>
''' of both integer and float data.<para/>
''' (2) If the array data is integers, and the range of integers<para/>
''' is smaller than %maxbins, they are binned as they fall,<para/>
''' with binsize = 1.<para/>
''' (3) If the range of data, (maxval - minval), is larger than<para/>
''' %maxbins, or if the data is floats, they are binned into<para/>
''' exactly %maxbins bins.<para/>
''' (4) Unlike numaMakeHistogram(), these bins in general have<para/>
''' non-integer location and width, even for integer data.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - numa of floats these may be integers</param>
'''  <param name="maxbins">[in] - max number of histogram bins  is greater = 1</param>
'''   <returns>na consisiting of histogram of quantized float values, or NULL on error.</returns>
Public Shared Function numaMakeHistogramAuto(
				 ByVal na as Numa, 
				 ByVal maxbins as Integer) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeHistogramAuto( na.Pointer, maxbins)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (1055, 1)
' numaMakeHistogramClipped(na, binsize, maxsize) as Numa
' numaMakeHistogramClipped(NUMA *, l_float32, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simple function generates a histogram of values<para/>
''' from na, discarding all values  is lower  0.0 or greater than<para/>
''' min(%maxsize, maxval), where maxval is the maximum value in na.<para/>
''' The histogram data is put in bins of size delx = %binsize,<para/>
''' starting at x = 0.0.  We use as many bins as are<para/>
''' needed to hold the data.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="binsize">[in] - typically 1.0</param>
'''  <param name="maxsize">[in] - of histogram ordinate</param>
'''   <returns>na histogram of bins of size %binsize, starting with the na[0] (x = 0.0 and going up to a maximum of x = %maxsize, by increments of %binsize), or NULL on error</returns>
Public Shared Function numaMakeHistogramClipped(
				 ByVal na as Numa, 
				 ByVal binsize as Single, 
				 ByVal maxsize as Single) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeHistogramClipped( na.Pointer, binsize, maxsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (1104, 1)
' numaRebinHistogram(nas, newsize) as Numa
' numaRebinHistogram(NUMA *, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - input histogram</param>
'''  <param name="newsize">[in] - number of old bins contained in each new bin</param>
'''   <returns>nad more coarsely re-binned histogram, or NULL on error</returns>
Public Shared Function numaRebinHistogram(
				 ByVal nas as Numa, 
				 ByVal newsize as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaRebinHistogram( nas.Pointer, newsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (1153, 1)
' numaNormalizeHistogram(nas, tsum) as Numa
' numaNormalizeHistogram(NUMA *, l_float32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - input histogram</param>
'''  <param name="tsum">[in] - target sum of all numbers in dest histogram e.g., use %tsum= 1.0 if this represents a probability distribution</param>
'''   <returns>nad normalized histogram, or NULL on error</returns>
Public Shared Function numaNormalizeHistogram(
				 ByVal nas as Numa, 
				 ByVal tsum as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaNormalizeHistogram( nas.Pointer, tsum)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (1235, 1)
' numaGetStatsUsingHistogram(na, maxbins, pmin, pmax, pmean, pvariance, pmedian, rank, prval, phisto) as Integer
' numaGetStatsUsingHistogram(NUMA *, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a simple interface for gathering statistics<para/>
''' from a numa, where a histogram is used 'under the covers'<para/>
''' to avoid sorting if a rank value is requested.  In that case,<para/>
''' by using a histogram we are trading speed for accuracy, because<para/>
''' the values in %na are quantized to the center of a set of bins.<para/>
''' (2) If the median, other rank value, or histogram are not requested,<para/>
''' the calculation is all performed on the input Numa.<para/>
''' (3) The variance is the average of the square of the<para/>
''' difference from the mean.  The median is the value in na<para/>
''' with rank 0.5.<para/>
''' (4) There are two situations where this gives rank results with<para/>
''' accuracy comparable to computing stastics directly on the input<para/>
''' data, without binning into a histogram:<para/>
''' (a) the data is integers and the range of data is less than<para/>
''' %maxbins, and<para/>
''' (b) the data is floats and the range is small compared to<para/>
''' %maxbins, so that the binsize is much less than 1.<para/>
''' (5) If a histogram is used and the numbers in the Numa extend<para/>
''' over a large range, you can limit the required storage by<para/>
''' specifying the maximum number of bins in the histogram.<para/>
''' Use %maxbins == 0 to force the bin size to be 1.<para/>
''' (6) This optionally returns the median and one arbitrary rank value.<para/>
''' If you need several rank values, return the histogram and use<para/>
''' numaHistogramGetValFromRank(nah, rank,  and rval)<para/>
''' multiple times.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - an arbitrary set of numbers not ordered and not a histogram</param>
'''  <param name="maxbins">[in] - the maximum number of bins to be allowed in the histogram use an integer larger than the largest number in %na for consecutive integer bins</param>
'''  <param name="pmin">[out][optional] - min value of set</param>
'''  <param name="pmax">[out][optional] - max value of set</param>
'''  <param name="pmean">[out][optional] - mean value of set</param>
'''  <param name="pvariance">[out][optional] - variance</param>
'''  <param name="pmedian">[out][optional] - median value of set</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0] median has a rank 0.5 ignored if  and rval == NULL</param>
'''  <param name="prval">[out][optional] - value in na corresponding to %rank</param>
'''  <param name="phisto">[out][optional] - Numa histogram use NULL to prevent</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetStatsUsingHistogram(
				 ByVal na as Numa, 
				 ByVal maxbins as Integer, 
				<Out()> ByRef pmin as Single, 
				<Out()> ByRef pmax as Single, 
				<Out()> ByRef pmean as Single, 
				<Out()> ByRef pvariance as Single, 
				<Out()> ByRef pmedian as Single, 
				 ByVal rank as Single, 
				<Out()> Optional ByRef prval as Single = Nothing, 
				<Out()> Optional ByRef phisto as Numa = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

Dim phistoPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phisto) Then phistoPTR = phisto.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetStatsUsingHistogram( na.Pointer, maxbins, pmin, pmax, pmean, pvariance, pmedian, rank, prval, phistoPTR)
	if phistoPTR <> IntPtr.Zero then phisto = new Numa(phistoPTR)

	Return _Result
End Function

' SRC\numafunc2.c (1326, 1)
' numaGetHistogramStats(nahisto, startx, deltax, pxmean, pxmedian, pxmode, pxvariance) as Integer
' numaGetHistogramStats(NUMA *, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the histogram represents the relation y(x), the<para/>
''' computed values that are returned are the x values.<para/>
''' These are NOT the bucket indices i they are related to the<para/>
''' bucket indices by<para/>
''' x(i) = startx + i  deltax<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nahisto">[in] - histogram: y(x(i)), i = 0 ... nbins - 1</param>
'''  <param name="startx">[in] - x value of first bin: x(0)</param>
'''  <param name="deltax">[in] - x increment between bins the bin size x(1) - x(0)</param>
'''  <param name="pxmean">[out][optional] - mean value of histogram</param>
'''  <param name="pxmedian">[out][optional] - median value of histogram</param>
'''  <param name="pxmode">[out][optional] - mode value of histogram: xmode = x(imode), where y(xmode)  is greater = y(x(i)) for all i != imode</param>
'''  <param name="pxvariance">[out][optional] - variance of x</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetHistogramStats(
				 ByVal nahisto as Numa, 
				 ByVal startx as Single, 
				 ByVal deltax as Single, 
				<Out()> Optional ByRef pxmean as Single = Nothing, 
				<Out()> Optional ByRef pxmedian as Single = Nothing, 
				<Out()> Optional ByRef pxmode as Single = Nothing, 
				<Out()> Optional ByRef pxvariance as Single = Nothing) as Integer

	If IsNothing (nahisto) then Throw New ArgumentNullException  ("nahisto cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetHistogramStats( nahisto.Pointer, startx, deltax, pxmean, pxmedian, pxmode, pxvariance)

	Return _Result
End Function

' SRC\numafunc2.c (1375, 1)
' numaGetHistogramStatsOnInterval(nahisto, startx, deltax, ifirst, ilast, pxmean, pxmedian, pxmode, pxvariance) as Integer
' numaGetHistogramStatsOnInterval(NUMA *, l_float32, l_float32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the histogram represents the relation y(x), the<para/>
''' computed values that are returned are the x values.<para/>
''' These are NOT the bucket indices i they are related to the<para/>
''' bucket indices by<para/>
''' x(i) = startx + i  deltax<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nahisto">[in] - histogram: y(x(i)), i = 0 ... nbins - 1</param>
'''  <param name="startx">[in] - x value of first bin: x(0)</param>
'''  <param name="deltax">[in] - x increment between bins the bin size x(1) - x(0)</param>
'''  <param name="ifirst">[in] - first bin to use for collecting stats</param>
'''  <param name="ilast">[in] - last bin for collecting stats use 0 to go to the end</param>
'''  <param name="pxmean">[out][optional] - mean value of histogram</param>
'''  <param name="pxmedian">[out][optional] - median value of histogram</param>
'''  <param name="pxmode">[out][optional] - mode value of histogram: xmode = x(imode), where y(xmode)  is greater = y(x(i)) for all i != imode</param>
'''  <param name="pxvariance">[out][optional] - variance of x</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetHistogramStatsOnInterval(
				 ByVal nahisto as Numa, 
				 ByVal startx as Single, 
				 ByVal deltax as Single, 
				 ByVal ifirst as Integer, 
				 ByVal ilast as Integer, 
				<Out()> Optional ByRef pxmean as Single = Nothing, 
				<Out()> Optional ByRef pxmedian as Single = Nothing, 
				<Out()> Optional ByRef pxmode as Single = Nothing, 
				<Out()> Optional ByRef pxvariance as Single = Nothing) as Integer

	If IsNothing (nahisto) then Throw New ArgumentNullException  ("nahisto cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetHistogramStatsOnInterval( nahisto.Pointer, startx, deltax, ifirst, ilast, pxmean, pxmedian, pxmode, pxvariance)

	Return _Result
End Function

' SRC\numafunc2.c (1462, 1)
' numaMakeRankFromHistogram(startx, deltax, nasy, npts, pnax, pnay) as Integer
' numaMakeRankFromHistogram(l_float32, l_float32, NUMA *, l_int32, NUMA **, NUMA **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="startx">[in] - xval corresponding to first element in nay</param>
'''  <param name="deltax">[in] - x increment between array elements in nay</param>
'''  <param name="nasy">[in] - input histogram, assumed equally spaced</param>
'''  <param name="npts">[in] - number of points to evaluate rank function</param>
'''  <param name="pnax">[out][optional] - array of x values in range</param>
'''  <param name="pnay">[out] - rank array of specified npts</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaMakeRankFromHistogram(
				 ByVal startx as Single, 
				 ByVal deltax as Single, 
				 ByVal nasy as Numa, 
				 ByVal npts as Integer, 
				<Out()> ByRef pnax as Numa, 
				<Out()> ByRef pnay as Numa) as Integer

	If IsNothing (nasy) then Throw New ArgumentNullException  ("nasy cannot be Nothing")

Dim pnaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnax) Then pnaxPTR = pnax.Pointer
	Dim pnayPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnay) Then pnayPTR = pnay.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaMakeRankFromHistogram( startx, deltax, nasy.Pointer, npts, pnaxPTR, pnayPTR)
	if pnaxPTR <> IntPtr.Zero then pnax = new Numa(pnaxPTR)
	if pnayPTR <> IntPtr.Zero then pnay = new Numa(pnayPTR)

	Return _Result
End Function

' SRC\numafunc2.c (1530, 1)
' numaHistogramGetRankFromVal(na, rval, prank) as Integer
' numaHistogramGetRankFromVal(NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If we think of the histogram as a function y(x), normalized<para/>
''' to 1, for a given input value of x, this computes the<para/>
''' rank of x, which is the integral of y(x) from the start<para/>
''' value of x to the input value.<para/>
''' (2) This function only makes sense when applied to a Numa that<para/>
''' is a histogram.  The values in the histogram can be ints and<para/>
''' floats, and are computed as floats.  The rank is returned<para/>
''' as a float between 0.0 and 1.0.<para/>
''' (3) The numa parameters startx and binsize are used to<para/>
''' compute x from the Numa index i.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - histogram</param>
'''  <param name="rval">[in] - value of input sample for which we want the rank</param>
'''  <param name="prank">[out] - fraction of total samples below rval</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaHistogramGetRankFromVal(
				 ByVal na as Numa, 
				 ByVal rval as Single, 
				<Out()> ByRef prank as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaHistogramGetRankFromVal( na.Pointer, rval, prank)

	Return _Result
End Function

' SRC\numafunc2.c (1601, 1)
' numaHistogramGetValFromRank(na, rank, prval) as Integer
' numaHistogramGetValFromRank(NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If we think of the histogram as a function y(x), this returns<para/>
''' the value x such that the integral of y(x) from the start<para/>
''' value to x gives the fraction 'rank' of the integral<para/>
''' of y(x) over all bins.<para/>
''' (2) This function only makes sense when applied to a Numa that<para/>
''' is a histogram.  The values in the histogram can be ints and<para/>
''' floats, and are computed as floats.  The val is returned<para/>
''' as a float, even though the buckets are of integer width.<para/>
''' (3) The numa parameters startx and binsize are used to<para/>
''' compute x from the Numa index i.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - histogram</param>
'''  <param name="rank">[in] - fraction of total samples</param>
'''  <param name="prval">[out] - approx. to the bin value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaHistogramGetValFromRank(
				 ByVal na as Numa, 
				 ByVal rank as Single, 
				<Out()> ByRef prval as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaHistogramGetValFromRank( na.Pointer, rank, prval)

	Return _Result
End Function

' SRC\numafunc2.c (1681, 1)
' numaDiscretizeRankAndIntensity(na, nbins, pnarbin, pnam, pnar, pnabb) as Integer
' numaDiscretizeRankAndIntensity(NUMA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We are inverting the rank(intensity) function to get<para/>
''' the intensity(rank) function at %nbins equally spaced<para/>
''' values of rank between 0.0 and 1.0.  We save integer values<para/>
''' for the intensity.<para/>
''' (2) We are using the word "intensity" to describe the type of<para/>
''' array values, but any array of non-negative numbers will work.<para/>
''' (3) The output arrays give the following mappings, where the<para/>
''' input is a normalized histogram of array values:<para/>
''' array values -- is greater rank bin number  (narbin)<para/>
''' rank bin number  -- is greater median array value in bin (nam)<para/>
''' array values -- is greater cumulative norm = rank  (nar)<para/>
''' rank bin number  -- is greater array value at right bin edge (nabb)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - normalized histogram of probability density vs intensity</param>
'''  <param name="nbins">[in] - number of bins at which the rank is divided</param>
'''  <param name="pnarbin">[out][optional] - rank bin value vs intensity</param>
'''  <param name="pnam">[out][optional] - median intensity in a bin vs rank bin value, with %nbins of discretized rank values</param>
'''  <param name="pnar">[out][optional] - rank vs intensity this is a cumulative norm histogram</param>
'''  <param name="pnabb">[out][optional] - intensity at the right bin boundary vs rank bin</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaDiscretizeRankAndIntensity(
				 ByVal na as Numa, 
				 ByVal nbins as Integer, 
				<Out()> Optional ByRef pnarbin as Numa = Nothing, 
				<Out()> Optional ByRef pnam as Numa = Nothing, 
				<Out()> Optional ByRef pnar as Numa = Nothing, 
				<Out()> Optional ByRef pnabb as Numa = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

Dim pnarbinPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnarbin) Then pnarbinPTR = pnarbin.Pointer
Dim pnamPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnam) Then pnamPTR = pnam.Pointer
Dim pnarPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnar) Then pnarPTR = pnar.Pointer
Dim pnabbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnabb) Then pnabbPTR = pnabb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaDiscretizeRankAndIntensity( na.Pointer, nbins, pnarbinPTR, pnamPTR, pnarPTR, pnabbPTR)
	if pnarbinPTR <> IntPtr.Zero then pnarbin = new Numa(pnarbinPTR)
	if pnamPTR <> IntPtr.Zero then pnam = new Numa(pnamPTR)
	if pnarPTR <> IntPtr.Zero then pnar = new Numa(pnarPTR)
	if pnabbPTR <> IntPtr.Zero then pnabb = new Numa(pnabbPTR)

	Return _Result
End Function

' SRC\numafunc2.c (1829, 1)
' numaGetRankBinValues(na, nbins, pnarbin, pnam) as Integer
' numaGetRankBinValues(NUMA *, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Simple interface for getting a binned rank representation<para/>
''' of an input array of values.  This returns two mappings:<para/>
''' array value -- is greater rank bin number  (narbin)<para/>
''' rank bin number -- is greater median array value in each rank bin (nam)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - just an array of values</param>
'''  <param name="nbins">[in] - number of bins at which the rank is divided</param>
'''  <param name="pnarbin">[out][optional] - rank bin value vs array value</param>
'''  <param name="pnam">[out][optional] - median intensity in a bin vs rank bin value, with %nbins of discretized rank values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetRankBinValues(
				 ByVal na as Numa, 
				 ByVal nbins as Integer, 
				<Out()> Optional ByRef pnarbin as Numa = Nothing, 
				<Out()> Optional ByRef pnam as Numa = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

Dim pnarbinPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnarbin) Then pnarbinPTR = pnarbin.Pointer
Dim pnamPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnam) Then pnamPTR = pnam.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetRankBinValues( na.Pointer, nbins, pnarbinPTR, pnamPTR)
	if pnarbinPTR <> IntPtr.Zero then pnarbin = new Numa(pnarbinPTR)
	if pnamPTR <> IntPtr.Zero then pnam = new Numa(pnamPTR)

	Return _Result
End Function

' SRC\numafunc2.c (1924, 1)
' numaSplitDistribution(na, scorefract, psplitindex, pave1, pave2, pnum1, pnum2, pnascore) as Integer
' numaSplitDistribution(NUMA *, l_float32, l_int32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function is intended to be used on a distribution of<para/>
''' values that represent two sets, such as a histogram of<para/>
''' pixel values for an image with a fg and bg, and the goal<para/>
''' is to determine the averages of the two sets and the<para/>
''' best splitting point.<para/>
''' (2) The Otsu method finds a split point that divides the distribution<para/>
''' into two parts by maximizing a score function that is the<para/>
''' product of two terms:<para/>
''' (a) the square of the difference of centroids, (ave1 - ave2)^2<para/>
''' (b) fract1  (1 - fract1)<para/>
''' where fract1 is the fraction in the lower distribution.<para/>
''' (3) This works well for images where the fg and bg are<para/>
''' each relatively homogeneous and well-separated in color.<para/>
''' However, if the actual fg and bg sets are very different<para/>
''' in size, and the bg is highly varied, as can occur in some<para/>
''' scanned document images, this will bias the split point<para/>
''' into the larger "bump" (i.e., toward the point where the<para/>
''' (b) term reaches its maximum of 0.25 at fract1 = 0.5.<para/>
''' To avoid this, we define a range of values near the<para/>
''' maximum of the score function, and choose the value within<para/>
''' this range such that the histogram itself has a minimum value.<para/>
''' The range is determined by scorefract: we include all abscissa<para/>
''' values to the left and right of the value that maximizes the<para/>
''' score, such that the score stays above (1 - scorefract)  maxscore.<para/>
''' The intuition behind this modification is to try to find<para/>
''' a split point that both has a high variance score and is<para/>
''' at or near a minimum in the histogram, so that the histogram<para/>
''' slope is small at the split point.<para/>
''' (4) We normalize the score so that if the two distributions<para/>
''' were of equal size and at opposite ends of the numa, the<para/>
''' score would be 1.0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - histogram</param>
'''  <param name="scorefract">[in] - fraction of the max score, used to determine the range over which the histogram min is searched</param>
'''  <param name="psplitindex">[out][optional] - index for splitting</param>
'''  <param name="pave1">[out][optional] - average of lower distribution</param>
'''  <param name="pave2">[out][optional] - average of upper distribution</param>
'''  <param name="pnum1">[out][optional] - population of lower distribution</param>
'''  <param name="pnum2">[out][optional] - population of upper distribution</param>
'''  <param name="pnascore">[out][optional] - for debugging otherwise use NULL</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSplitDistribution(
				 ByVal na as Numa, 
				 ByVal scorefract as Single, 
				<Out()> Optional ByRef psplitindex as Integer = Nothing, 
				<Out()> Optional ByRef pave1 as Single = Nothing, 
				<Out()> Optional ByRef pave2 as Single = Nothing, 
				<Out()> Optional ByRef pnum1 as Single = Nothing, 
				<Out()> Optional ByRef pnum2 as Single = Nothing, 
				<Out()> Optional ByRef pnascore as Numa = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

Dim pnascorePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnascore) Then pnascorePTR = pnascore.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSplitDistribution( na.Pointer, scorefract, psplitindex, pave1, pave2, pnum1, pnum2, pnascorePTR)
	if pnascorePTR <> IntPtr.Zero then pnascore = new Numa(pnascorePTR)

	Return _Result
End Function

' SRC\numafunc2.c (2086, 1)
' grayHistogramsToEMD(naa1, naa2, pnad) as Integer
' grayHistogramsToEMD(NUMAA *, NUMAA *, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The two numaas must be the same size and have corresponding<para/>
''' 256-element histograms.  Pairs do not need to be normalized<para/>
''' to the same sum.<para/>
''' (2) This is typically used on two sets of histograms from<para/>
''' corresponding tiles of two images.  The similarity of two<para/>
''' images can be found with the scoring function used in<para/>
''' pixCompareGrayByHisto():<para/>
''' score S = 1.0 - k  D, where<para/>
''' k is a constant, say in the range 5-10<para/>
''' D = EMD<para/>
''' for each tile for multiple tiles, take the Min(S) over<para/>
''' the set of tiles to be the final score.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa1">[in] - two numaa, each with one or more 256-element histograms</param>
'''  <param name="naa2">[in] - two numaa, each with one or more 256-element histograms</param>
'''  <param name="pnad">[out] - nad of EM distances for each histogram</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function grayHistogramsToEMD(
				 ByVal naa1 as Numaa, 
				 ByVal naa2 as Numaa, 
				<Out()> ByRef pnad as Numa) as Integer

	If IsNothing (naa1) then Throw New ArgumentNullException  ("naa1 cannot be Nothing")
	If IsNothing (naa2) then Throw New ArgumentNullException  ("naa2 cannot be Nothing")

	Dim pnadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnad) Then pnadPTR = pnad.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.grayHistogramsToEMD( naa1.Pointer, naa2.Pointer, pnadPTR)
	if pnadPTR <> IntPtr.Zero then pnad = new Numa(pnadPTR)

	Return _Result
End Function

' SRC\numafunc2.c (2152, 1)
' numaEarthMoverDistance(na1, na2, pdist) as Integer
' numaEarthMoverDistance(NUMA *, NUMA *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The two numas must have the same size.  They do not need to be<para/>
''' normalized to the same sum before applying the function.<para/>
''' (2) For a 1D discrete function, the implementation of the EMD<para/>
''' is trivial.  Just keep filling or emptying buckets in one numa<para/>
''' to match the amount in the other, moving sequentially along<para/>
''' both arrays.<para/>
''' (3) We divide the sum of the absolute value of everything moved<para/>
''' (by 1 unit at a time) by the sum of the numa (amount of "earth")<para/>
''' to get the average distance that the "earth" was moved.<para/>
''' This is the value returned here.<para/>
''' (4) The caller can do a further normalization, by the number of<para/>
''' buckets (minus 1), to get the EM distance as a fraction of<para/>
''' the maximum possible distance, which is n-1.  This fraction<para/>
''' is 1.0 for the situation where all the 'earth' in the first<para/>
''' array is at one end, and all in the second array is at the<para/>
''' other end.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na1">[in] - two numas of the same size, typically histograms</param>
'''  <param name="na2">[in] - two numas of the same size, typically histograms</param>
'''  <param name="pdist">[out] - EM distance</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaEarthMoverDistance(
				 ByVal na1 as Numa, 
				 ByVal na2 as Numa, 
				<Out()> ByRef pdist as Single) as Integer

	If IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
	If IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaEarthMoverDistance( na1.Pointer, na2.Pointer, pdist)

	Return _Result
End Function

' SRC\numafunc2.c (2243, 1)
' grayInterHistogramStats(naa, wc, pnam, pnams, pnav, pnarv) as Integer
' grayInterHistogramStats(NUMAA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %naa has two or more 256-element numa histograms, which<para/>
''' are to be compared value-wise at each of the 256 gray levels.<para/>
''' The result are stats (mean, mean square, variance, root variance)<para/>
''' aggregated across the set of histograms, and each is output<para/>
''' as a 256 entry numa.  Think of these histograms as a matrix,<para/>
''' where each histogram is one row of the array.  The stats are<para/>
''' then aggregated column-wise, between the histograms.<para/>
''' (2) These stats are:<para/>
''' ~ average value:  is lower v is greater (nam)<para/>
''' ~ average squared value:  is lower vv is greater  (nams)<para/>
''' ~ variance:  is lower (v -  is lower v is greater )(v -  is lower v is greater ) is greater  =  is lower vv is greater  -  is lower v is greater  is lower v is greater (nav)<para/>
''' ~ square-root of variance: (narv)<para/>
''' where the brackets  is lower  ..  is greater  indicate that the average value is<para/>
''' to be taken over each column of the array.<para/>
''' (3) The input histograms are optionally smoothed before these<para/>
''' statistical operations.<para/>
''' (4) The input histograms are normalized to a sum of 10000.  By<para/>
''' doing this, the resulting numbers are independent of the<para/>
''' number of samples used in building the individual histograms.<para/>
''' (5) A typical application is on a set of histograms from tiles<para/>
''' of an image, to distinguish between text/tables and photo<para/>
''' regions.  If the tiles are much larger than the text line<para/>
''' spacing, text/table regions typically have smaller variance<para/>
''' across tiles than photo regions.  For this application, it<para/>
''' may be useful to ignore values near white, which are large for<para/>
''' text and would magnify the variance due to variations in<para/>
''' illumination.  However, because the variance of a drawing or<para/>
''' a light photo can be similar to that of grayscale text, this<para/>
''' function is only a discriminator between darker photos/drawings<para/>
''' and light photos/text/line-graphics.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - numaa with two or more 256-element histograms</param>
'''  <param name="wc">[in] - half-width of the smoothing window</param>
'''  <param name="pnam">[out][optional] - mean values</param>
'''  <param name="pnams">[out][optional] - mean square values</param>
'''  <param name="pnav">[out][optional] - variances</param>
'''  <param name="pnarv">[out][optional] - rms deviations from the mean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function grayInterHistogramStats(
				 ByVal naa as Numaa, 
				 ByVal wc as Integer, 
				<Out()> Optional ByRef pnam as Numa = Nothing, 
				<Out()> Optional ByRef pnams as Numa = Nothing, 
				<Out()> Optional ByRef pnav as Numa = Nothing, 
				<Out()> Optional ByRef pnarv as Numa = Nothing) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")

Dim pnamPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnam) Then pnamPTR = pnam.Pointer
Dim pnamsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnams) Then pnamsPTR = pnams.Pointer
Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer
Dim pnarvPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnarv) Then pnarvPTR = pnarv.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.grayInterHistogramStats( naa.Pointer, wc, pnamPTR, pnamsPTR, pnavPTR, pnarvPTR)
	if pnamPTR <> IntPtr.Zero then pnam = new Numa(pnamPTR)
	if pnamsPTR <> IntPtr.Zero then pnams = new Numa(pnamsPTR)
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)
	if pnarvPTR <> IntPtr.Zero then pnarv = new Numa(pnarvPTR)

	Return _Result
End Function

' SRC\numafunc2.c (2333, 1)
' numaFindPeaks(nas, nmax, fract1, fract2) as Numa
' numaFindPeaks(NUMA *, l_int32, l_float32, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned na consists of sets of four numbers representing<para/>
''' the peak, in the following order:<para/>
''' left edge peak center right edge normalized peak area<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - source numa</param>
'''  <param name="nmax">[in] - max number of peaks to be found</param>
'''  <param name="fract1">[in] - min fraction of peak value</param>
'''  <param name="fract2">[in] - min slope</param>
'''   <returns>peak na, or NULL on error.</returns>
Public Shared Function numaFindPeaks(
				 ByVal nas as Numa, 
				 ByVal nmax as Integer, 
				 ByVal fract1 as Single, 
				 ByVal fract2 as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaFindPeaks( nas.Pointer, nmax, fract1, fract2)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (2448, 1)
' numaFindExtrema(nas, delta, pnav) as Numa
' numaFindExtrema(NUMA *, l_float32, NUMA **) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a sequence of extrema (peaks and valleys).<para/>
''' (2) The algorithm is analogous to that for determining<para/>
''' mountain peaks.  Suppose we have a local peak, with<para/>
''' bumps on the side.  Under what conditions can we consider<para/>
''' those 'bumps' to be actual peaks?  The answer: if the<para/>
''' bump is separated from the peak by a saddle that is at<para/>
''' least 500 feet below the bump.<para/>
''' (3) Operationally, suppose we are looking for a peak.<para/>
''' We are keeping the largest value we've seen since the<para/>
''' last valley, and are looking for a value that is delta<para/>
''' BELOW our current peak.  When we find such a value,<para/>
''' we label the peak, use the current value to label the<para/>
''' valley, and then do the same operation in reverse (looking<para/>
''' for a valley).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - input values</param>
'''  <param name="delta">[in] - relative amount to resolve peaks and valleys</param>
'''  <param name="pnav">[out][optional] - values of extrema</param>
'''   <returns>nad (locations of extrema, or NULL on error</returns>
Public Shared Function numaFindExtrema(
				 ByVal nas as Numa, 
				 ByVal delta as Single, 
				<Out()> Optional ByRef pnav as Numa = Nothing) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaFindExtrema( nas.Pointer, delta, pnavPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (2544, 1)
' numaCountReversals(nas, minreversal, pnr, pnrpl) as Integer
' numaCountReversals(NUMA *, l_float32, l_int32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input numa is can be generated from pixExtractAlongLine().<para/>
''' If so, the x parameters can be used to find the reversal<para/>
''' frequency along a line.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - input values</param>
'''  <param name="minreversal">[in] - relative amount to resolve peaks and valleys</param>
'''  <param name="pnr">[out][optional] - number of reversals</param>
'''  <param name="pnrpl">[out] - ([optional] reversal density: reversals/length</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaCountReversals(
				 ByVal nas as Numa, 
				 ByVal minreversal as Single, 
				<Out()> Optional ByRef pnr as Integer = Nothing, 
				<Out()> Optional ByRef pnrpl as Single = Nothing) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaCountReversals( nas.Pointer, minreversal, pnr, pnrpl)

	Return _Result
End Function

' SRC\numafunc2.c (2606, 1)
' numaSelectCrossingThreshold(nax, nay, estthresh, pbestthresh) as Integer
' numaSelectCrossingThreshold(NUMA *, NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) When a valid threshold is used, the number of crossings is<para/>
''' a maximum, because none are missed.  If no threshold intersects<para/>
''' all the crossings, the crossings must be determined with<para/>
''' numaCrossingsByPeaks().<para/>
''' (2) %estthresh is an input estimate of the threshold that should<para/>
''' be used.  We compute the crossings with 41 thresholds<para/>
''' (20 below and 20 above).  There is a range in which the<para/>
''' number of crossings is a maximum.  Return a threshold<para/>
''' in the center of this stable plateau of crossings.<para/>
''' This can then be used with numaCrossingsByThreshold()<para/>
''' to get a good estimate of crossing locations.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nax">[in][optional] - numa of abscissa values can be NULL</param>
'''  <param name="nay">[in] - signal</param>
'''  <param name="estthresh">[in] - estimated pixel threshold for crossing: e.g., for images, white  is lower -- is greater  black typ. ~120</param>
'''  <param name="pbestthresh">[out] - robust estimate of threshold to use</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSelectCrossingThreshold(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal estthresh as Single, 
				<Out()> ByRef pbestthresh as Single) as Integer

	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSelectCrossingThreshold( naxPTR, nay.Pointer, estthresh, pbestthresh)

	Return _Result
End Function

' SRC\numafunc2.c (2713, 1)
' numaCrossingsByThreshold(nax, nay, thresh) as Numa
' numaCrossingsByThreshold(NUMA *, NUMA *, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If nax == NULL, we use startx and delx from nay to compute<para/>
''' the crossing values in nad.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nax">[in][optional] - numa of abscissa values can be NULL</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="thresh">[in] - threshold value for nay</param>
'''   <returns>nad abscissa pts at threshold, or NULL on error</returns>
Public Shared Function numaCrossingsByThreshold(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal thresh as Single) as Numa

	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCrossingsByThreshold( naxPTR, nay.Pointer, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (2778, 1)
' numaCrossingsByPeaks(nax, nay, delta) as Numa
' numaCrossingsByPeaks(NUMA *, NUMA *, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If nax == NULL, we use startx and delx from nay to compute<para/>
''' the crossing values in nad.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nax">[in][optional] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="delta">[in] - parameter used to identify when a new peak can be found</param>
'''   <returns>nad abscissa pts at threshold, or NULL on error</returns>
Public Shared Function numaCrossingsByPeaks(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal delta as Single) as Numa

	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCrossingsByPeaks( naxPTR, nay.Pointer, delta)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc2.c (2890, 1)
' numaEvalBestHaarParameters(nas, relweight, nwidth, nshift, minwidth, maxwidth, pbestwidth, pbestshift, pbestscore) as Integer
' numaEvalBestHaarParameters(NUMA *, l_float32, l_int32, l_int32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does a linear sweep of widths, evaluating at %nshift<para/>
''' shifts for each width, computing the score from a convolution<para/>
''' with a long comb, and finding the (width, shift) pair that<para/>
''' gives the maximum score.  The best width is the "half-wavelength"<para/>
''' of the signal.<para/>
''' (2) The convolving function is a comb of alternating values<para/>
''' +1 and -1  relweight, separated by the width and phased by<para/>
''' the shift.  This is similar to a Haar transform, except<para/>
''' there the convolution is performed with a square wave.<para/>
''' (3) The function is useful for finding the line spacing<para/>
''' and strength of line signal from pixel sum projections.<para/>
''' (4) The score is normalized to the size of nas divided by<para/>
''' the number of half-widths.  For image applications, the input is<para/>
''' typically an array of pixel projections, so one should<para/>
''' normalize by dividing the score by the image width in the<para/>
''' pixel projection direction.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - numa of non-negative signal values</param>
'''  <param name="relweight">[in] - relative weight of (-1 comb) / (+1 comb) contributions to the 'convolution'.  In effect, the convolution kernel is a comb consisting of alternating +1 and -weight.</param>
'''  <param name="nwidth">[in] - number of widths to consider</param>
'''  <param name="nshift">[in] - number of shifts to consider for each width</param>
'''  <param name="minwidth">[in] - smallest width to consider</param>
'''  <param name="maxwidth">[in] - largest width to consider</param>
'''  <param name="pbestwidth">[out] - width giving largest score</param>
'''  <param name="pbestshift">[out] - shift giving largest score</param>
'''  <param name="pbestscore">[out][optional] - convolution with "Haar"-like comb</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaEvalBestHaarParameters(
				 ByVal nas as Numa, 
				 ByVal relweight as Single, 
				 ByVal nwidth as Integer, 
				 ByVal nshift as Integer, 
				 ByVal minwidth as Single, 
				 ByVal maxwidth as Single, 
				<Out()> ByRef pbestwidth as Single, 
				<Out()> ByRef pbestshift as Single, 
				<Out()> Optional ByRef pbestscore as Single = Nothing) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaEvalBestHaarParameters( nas.Pointer, relweight, nwidth, nshift, minwidth, maxwidth, pbestwidth, pbestshift, pbestscore)

	Return _Result
End Function

' SRC\numafunc2.c (2975, 1)
' numaEvalHaarSum(nas, width, shift, relweight, pscore) as Integer
' numaEvalHaarSum(NUMA *, l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does a convolution with a comb of alternating values<para/>
''' +1 and -relweight, separated by the width and phased by the shift.<para/>
''' This is similar to a Haar transform, except that for Haar,<para/>
''' (1) the convolution kernel is symmetric about 0, so the<para/>
''' relweight is 1.0, and<para/>
''' (2) the convolution is performed with a square wave.<para/>
''' (2) The score is normalized to the size of nas divided by<para/>
''' twice the "width".  For image applications, the input is<para/>
''' typically an array of pixel projections, so one should<para/>
''' normalize by dividing the score by the image width in the<para/>
''' pixel projection direction.<para/>
''' (3) To get a Haar-like result, use relweight = 1.0.  For detecting<para/>
''' signals where you expect every other sample to be close to<para/>
''' zero, as with barcodes or filtered text lines, you can<para/>
''' use relweight  is greater  1.0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nas">[in] - numa of non-negative signal values</param>
'''  <param name="width">[in] - distance between +1 and -1 in convolution comb</param>
'''  <param name="shift">[in] - phase of the comb: location of first +1</param>
'''  <param name="relweight">[in] - relative weight of (-1 comb) / (+1 comb) contributions to the 'convolution'.  In effect, the convolution kernel is a comb consisting of alternating +1 and -weight.</param>
'''  <param name="pscore">[out] - convolution with "Haar"-like comb</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaEvalHaarSum(
				 ByVal nas as Numa, 
				 ByVal width as Single, 
				 ByVal shift as Single, 
				 ByVal relweight as Single, 
				<Out()> ByRef pscore as Single) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaEvalHaarSum( nas.Pointer, width, shift, relweight, pscore)

	Return _Result
End Function

' SRC\numafunc2.c (3032, 1)
' genConstrainedNumaInRange(first, last, nmax, use_pairs) as Numa
' genConstrainedNumaInRange(l_int32, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Selection is made uniformly in the range.  This can be used<para/>
''' to select pages distributed as uniformly as possible<para/>
''' through a book, where you are constrained to:<para/>
''' ~ choose between [first, ... biggest],<para/>
''' ~ choose no more than nmax numbers, and<para/>
''' and you have the option of requiring pairs of adjacent numbers.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="first">[in] - first number to choose  is greater = 0</param>
'''  <param name="last">[in] - biggest possible number to reach  is greater = first</param>
'''  <param name="nmax">[in] - maximum number of numbers to select  is greater  0</param>
'''  <param name="use_pairs">[in] - 1 = select pairs of adjacent numbers 0 = select individual numbers</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function genConstrainedNumaInRange(
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				 ByVal nmax as Integer, 
				 ByVal use_pairs as Integer) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.genConstrainedNumaInRange( first, last, nmax, use_pairs)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

End Class
