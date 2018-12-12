Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' numafunc2.c (165, 1)
' numaErode(nas, size) as Numa
' numaErode(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
'''
'''(2) If size == 1, this returns a copy<para/>
'''
'''(3) General comment.  The morphological operations are equivalent
'''to those that would be performed on a 1-dimensional fpix.
'''However, because we have not implemented morphological
'''operations on fpix, we do this here.  Because it is only
'''1 dimensional, there is no reason to use the more
'''complicated van Herk/Gil-Werman algorithm, and we do it
'''by brute force.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaErode/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad eroded, or NULL on error</returns>
Public Shared Function numaErode(
				ByVal nas as Numa, 
				ByVal size as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaErode(nas.Pointer,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (233, 1)
' numaDilate(nas, size) as Numa
' numaDilate(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
'''
'''(2) If size == 1, this returns a copy
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaDilate/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad dilated, or NULL on error</returns>
Public Shared Function numaDilate(
				ByVal nas as Numa, 
				ByVal size as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaDilate(nas.Pointer,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (301, 1)
' numaOpen(nas, size) as Numa
' numaOpen(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
'''
'''(2) If size == 1, this returns a copy
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaOpen/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad opened, or NULL on error</returns>
Public Shared Function numaOpen(
				ByVal nas as Numa, 
				ByVal size as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaOpen(nas.Pointer,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (347, 1)
' numaClose(nas, size) as Numa
' numaClose(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The structuring element (sel) is linear, all "hits"<para/>
'''
'''(2) If size == 1, this returns a copy<para/>
'''
'''(3) We add a border before doing this operation, for the same
'''reason that we add a border to a pix before doing a safe closing.
'''Without the border, a small component near the border gets
'''clipped at the border on dilation, and can be entirely removed
'''by the following erosion, violating the basic extensivity
'''property of closing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaClose/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="size">[in] - of sel greater than 0, odd origin implicitly in center</param>
'''   <returns>nad opened, or NULL on error</returns>
Public Shared Function numaClose(
				ByVal nas as Numa, 
				ByVal size as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaClose(nas.Pointer,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (394, 1)
' numaTransform(nas, shift, scale) as Numa
' numaTransform(NUMA *, l_float32, l_float32) as NUMA *
'''  <summary>
''' (1) Each number is shifted before scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaTransform/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="shift">[in] - add this to each number</param>
'''  <param name="scale">[in] - multiply each number by this</param>
'''   <returns>nad with all values shifted and scaled, or NULL on error</returns>
Public Shared Function numaTransform(
				ByVal nas as Numa, 
				ByVal shift as Single, 
				ByVal scale as Single) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaTransform(nas.Pointer,   shift,   scale)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (431, 1)
' numaSimpleStats(na, first, last, pmean, pvar, prvar) as Integer
' numaSimpleStats(NUMA *, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' numaSimpleStats()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSimpleStats/*"/>
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
				<Out()> Optional  ByRef pmean as Single = 0f, 
				<Out()> Optional  ByRef pvar as Single = 0f, 
				<Out()> Optional  ByRef prvar as Single = 0f) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as Integer = Natives.numaSimpleStats(na.Pointer,   first,   last,   pmean,   pvar,   prvar)
	
	return _Result
End Function

' numafunc2.c (511, 1)
' numaWindowedStats(nas, wc, pnam, pnams, pnav, pnarv) as Integer
' numaWindowedStats(NUMA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) This is a high-level convenience function for calculating
'''any or all of these derived arrays.<para/>
'''
'''(2) These statistical measures over the values in the
'''rectangular window are:
'''~ average value: [x]  (nam)
'''~ average squared value: [xx] (nams)
'''~ variance: [(x - [x])(x - [x])] = [xx] - [x][x]  (nav)
'''~ square-root of variance: (narv)
'''where the brackets [ .. ] indicate that the average value is
'''to be taken over the window.<para/>
'''
'''(3) Note that the variance is just the mean square difference from
'''the mean value and the square root of the variance is the
'''root mean square difference from the mean, sometimes also
'''called the 'standard deviation'.<para/>
'''
'''(4) Internally, use mirrored borders to handle values near the
'''end of each array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWindowedStats/*"/>
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
				<Out()> Optional  ByRef pnam as Numa = Nothing, 
				<Out()> Optional  ByRef pnams as Numa = Nothing, 
				<Out()> Optional  ByRef pnav as Numa = Nothing, 
				<Out()> Optional  ByRef pnarv as Numa = Nothing) as Integer


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim pnamPtr as IntPtr = IntPtr.Zero
	Dim pnamsPtr as IntPtr = IntPtr.Zero
	Dim pnavPtr as IntPtr = IntPtr.Zero
	Dim pnarvPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaWindowedStats(nas.Pointer,   wc, pnamPtr, pnamsPtr, pnavPtr, pnarvPtr)
	
	if pnamPtr = IntPtr.Zero then pnam = Nothing else pnam = new Numa(pnamPtr)
	if pnamsPtr = IntPtr.Zero then pnams = Nothing else pnams = new Numa(pnamsPtr)
	if pnavPtr = IntPtr.Zero then pnav = Nothing else pnav = new Numa(pnavPtr)
	if pnarvPtr = IntPtr.Zero then pnarv = Nothing else pnarv = new Numa(pnarvPtr)
	return _Result
End Function

' numafunc2.c (562, 1)
' numaWindowedMean(nas, wc) as Numa
' numaWindowedMean(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) This is a convolution.  The window has width = 2  %wc + 1.<para/>
'''
'''(2) We add a mirrored border of size %wc to each end of the array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWindowedMean/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="wc">[in] - half width of the convolution window</param>
'''   <returns>nad after low-pass filtering, or NULL on error</returns>
Public Shared Function numaWindowedMean(
				ByVal nas as Numa, 
				ByVal wc as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaWindowedMean(nas.Pointer,   wc)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (622, 1)
' numaWindowedMeanSquare(nas, wc) as Numa
' numaWindowedMeanSquare(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The window has width = 2  %wc + 1.<para/>
'''
'''(2) We add a mirrored border of size %wc to each end of the array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWindowedMeanSquare/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="wc">[in] - half width of the window</param>
'''   <returns>nad containing windowed mean square values, or NULL on error</returns>
Public Shared Function numaWindowedMeanSquare(
				ByVal nas as Numa, 
				ByVal wc as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaWindowedMeanSquare(nas.Pointer,   wc)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (690, 1)
' numaWindowedVariance(nam, nams, pnav, pnarv) as Integer
' numaWindowedVariance(NUMA *, NUMA *, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) The numas of windowed mean and mean square are precomputed,
'''using numaWindowedMean() and numaWindowedMeanSquare().<para/>
'''
'''(2) Either or both of the variance and square-root of variance
'''are returned, where the variance is the average over the
'''window of the mean square difference of the pixel value
'''from the mean:
'''[(x - [x])(x - [x])] = [xx] - [x][x]
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWindowedVariance/*"/>
'''  <param name="nam">[in] - windowed mean values</param>
'''  <param name="nams">[in] - windowed mean square values</param>
'''  <param name="pnav">[out][optional] - numa of variance -- the ms deviation from the mean</param>
'''  <param name="pnarv">[out][optional] - numa of rms deviation from the mean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWindowedVariance(
				ByVal nam as Numa, 
				ByVal nams as Numa, 
				<Out()> Optional  ByRef pnav as Numa = Nothing, 
				<Out()> Optional  ByRef pnarv as Numa = Nothing) as Integer


if IsNothing (nam) then Throw New ArgumentNullException  ("nam cannot be Nothing")
		if IsNothing (nams) then Throw New ArgumentNullException  ("nams cannot be Nothing")
	Dim pnavPtr as IntPtr = IntPtr.Zero
	Dim pnarvPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaWindowedVariance(nam.Pointer, nams.Pointer, pnavPtr, pnarvPtr)
	
	if pnavPtr = IntPtr.Zero then pnav = Nothing else pnav = new Numa(pnavPtr)
	if pnarvPtr = IntPtr.Zero then pnarv = Nothing else pnarv = new Numa(pnarvPtr)
	return _Result
End Function

' numafunc2.c (758, 1)
' numaWindowedMedian(nas, halfwin) as Numa
' numaWindowedMedian(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) The requested window has width = 2  %halfwin + 1.<para/>
'''
'''(2) If the input nas has less then 3 elements, return a copy.<para/>
'''
'''(3) If the filter is too small (%halfwin smaller or equal 0), return a copy.<para/>
'''
'''(4) If the filter is too large, it is reduced in size.<para/>
'''
'''(5) We add a mirrored border of size %halfwin to each end of
'''the array to simplify the calculation by avoiding end-effects.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWindowedMedian/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="halfwin">[in] - half width of window over which the median is found</param>
'''   <returns>nad after windowed median filtering, or NULL on error</returns>
Public Shared Function numaWindowedMedian(
				ByVal nas as Numa, 
				ByVal halfwin as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaWindowedMedian(nas.Pointer,   halfwin)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (807, 1)
' numaConvertToInt(nas) as Numa
' numaConvertToInt(NUMA *) as NUMA *
'''  <summary>
''' numaConvertToInt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaConvertToInt/*"/>
'''  <param name="nas">[in] - source numa</param>
'''   <returns>na with all values rounded to nearest integer, or NULL on error</returns>
Public Shared Function numaConvertToInt(
				ByVal nas as Numa) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaConvertToInt(nas.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (859, 1)
' numaMakeHistogram(na, maxbins, pbinsize, pbinstart) as Numa
' numaMakeHistogram(NUMA *, l_int32, l_int32 *, l_int32 *) as NUMA *
'''  <summary>
''' (1) This simple interface is designed for integer data.
'''The bins are of integer width and start on integer boundaries,
'''so the results on float data will not have high precision.<para/>
'''
'''(2) Specify the max number of input bins. Then %binsize,
'''the size of bins necessary to accommodate the input data,
'''is returned.  It is one of the sequence:
'''{1, 2, 5, 10, 20, 50, ...}.<para/>
'''
'''(3) If [and]binstart is given, all values are accommodated,
'''and the min value of the starting bin is returned.
'''Otherwise, all negative values are discarded and
'''the histogram bins start at 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeHistogram/*"/>
'''  <param name="na">[in] - </param>
'''  <param name="maxbins">[in] - max number of histogram bins</param>
'''  <param name="pbinsize">[out] - size of histogram bins</param>
'''  <param name="pbinstart">[out][optional] - start val of minimum bin input NULL to force start at 0</param>
'''   <returns>na consisiting of histogram of integerized values, or NULL on error.</returns>
Public Shared Function numaMakeHistogram(
				ByVal na as Numa, 
				ByVal maxbins as Integer, 
				<Out()>  ByRef pbinsize as Integer, 
				<Out()> Optional  ByRef pbinstart as Integer = 0) as Numa


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaMakeHistogram(na.Pointer,   maxbins,   pbinsize,   pbinstart)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (971, 1)
' numaMakeHistogramAuto(na, maxbins) as Numa
' numaMakeHistogramAuto(NUMA *, l_int32) as NUMA *
'''  <summary>
''' (1) This simple interface is designed for accurate binning
'''of both integer and float data.<para/>
'''
'''(2) If the array data is integers, and the range of integers
'''is smaller than %maxbins, they are binned as they fall,
'''with binsize = 1.<para/>
'''
'''(3) If the range of data, (maxval - minval), is larger than
'''%maxbins, or if the data is floats, they are binned into
'''exactly %maxbins bins.<para/>
'''
'''(4) Unlike numaMakeHistogram(), these bins in general have
'''non-integer location and width, even for integer data.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeHistogramAuto/*"/>
'''  <param name="na">[in] - numa of floats these may be integers</param>
'''  <param name="maxbins">[in] - max number of histogram bins greater or equal 1</param>
'''   <returns>na consisiting of histogram of quantized float values, or NULL on error.</returns>
Public Shared Function numaMakeHistogramAuto(
				ByVal na as Numa, 
				ByVal maxbins as Integer) as Numa


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaMakeHistogramAuto(na.Pointer,   maxbins)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (1055, 1)
' numaMakeHistogramClipped(na, binsize, maxsize) as Numa
' numaMakeHistogramClipped(NUMA *, l_float32, l_float32) as NUMA *
'''  <summary>
''' (1) This simple function generates a histogram of values
'''from na, discarding all values  is smaller 0.0 or greater than
'''min(%maxsize, maxval), where maxval is the maximum value in na.
'''The histogram data is put in bins of size delx = %binsize,
'''starting at x = 0.0.  We use as many bins as are
'''needed to hold the data.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeHistogramClipped/*"/>
'''  <param name="na">[in] - </param>
'''  <param name="binsize">[in] - typically 1.0</param>
'''  <param name="maxsize">[in] - of histogram ordinate</param>
'''   <returns>na histogram of bins of size %binsize, starting with the na[0] (x = 0.0 and going up to a maximum of x = %maxsize, by increments of %binsize), or NULL on error</returns>
Public Shared Function numaMakeHistogramClipped(
				ByVal na as Numa, 
				ByVal binsize as Single, 
				ByVal maxsize as Single) as Numa


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaMakeHistogramClipped(na.Pointer,   binsize,   maxsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (1104, 1)
' numaRebinHistogram(nas, newsize) as Numa
' numaRebinHistogram(NUMA *, l_int32) as NUMA *
'''  <summary>
''' numaRebinHistogram()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaRebinHistogram/*"/>
'''  <param name="nas">[in] - input histogram</param>
'''  <param name="newsize">[in] - number of old bins contained in each new bin</param>
'''   <returns>nad more coarsely re-binned histogram, or NULL on error</returns>
Public Shared Function numaRebinHistogram(
				ByVal nas as Numa, 
				ByVal newsize as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaRebinHistogram(nas.Pointer,   newsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (1153, 1)
' numaNormalizeHistogram(nas, tsum) as Numa
' numaNormalizeHistogram(NUMA *, l_float32) as NUMA *
'''  <summary>
''' numaNormalizeHistogram()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaNormalizeHistogram/*"/>
'''  <param name="nas">[in] - input histogram</param>
'''  <param name="tsum">[in] - target sum of all numbers in dest histogram e.g., use %tsum= 1.0 if this represents a probability distribution</param>
'''   <returns>nad normalized histogram, or NULL on error</returns>
Public Shared Function numaNormalizeHistogram(
				ByVal nas as Numa, 
				ByVal tsum as Single) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaNormalizeHistogram(nas.Pointer,   tsum)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (1235, 1)
' numaGetStatsUsingHistogram(na, maxbins, pmin, pmax, pmean, pvariance, pmedian, rank, prval, phisto) as Integer
' numaGetStatsUsingHistogram(NUMA *, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' (1) This is a simple interface for gathering statistics
'''from a numa, where a histogram is used 'under the covers'
'''to avoid sorting if a rank value is requested.  In that case,
'''by using a histogram we are trading speed for accuracy, because
'''the values in %na are quantized to the center of a set of bins.<para/>
'''
'''(2) If the median, other rank value, or histogram are not requested,
'''the calculation is all performed on the input Numa.<para/>
'''
'''(3) The variance is the average of the square of the
'''difference from the mean.  The median is the value in na
'''with rank 0.5.<para/>
'''
'''(4) There are two situations where this gives rank results with
'''accuracy comparable to computing stastics directly on the input
'''data, without binning into a histogram:
'''(a) the data is integers and the range of data is less than
'''%maxbins, and
'''(b) the data is floats and the range is small compared to
'''%maxbins, so that the binsize is much less than 1.<para/>
'''
'''(5) If a histogram is used and the numbers in the Numa extend
'''over a large range, you can limit the required storage by
'''specifying the maximum number of bins in the histogram.
'''Use %maxbins == 0 to force the bin size to be 1.<para/>
'''
'''(6) This optionally returns the median and one arbitrary rank value.
'''If you need several rank values, return the histogram and use
'''numaHistogramGetValFromRank(nah, rank, [and]rval)
'''multiple times.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetStatsUsingHistogram/*"/>
'''  <param name="na">[in] - an arbitrary set of numbers not ordered and not a histogram</param>
'''  <param name="maxbins">[in] - the maximum number of bins to be allowed in the histogram use an integer larger than the largest number in %na for consecutive integer bins</param>
'''  <param name="pmin">[out][optional] - min value of set</param>
'''  <param name="pmax">[out][optional] - max value of set</param>
'''  <param name="pmean">[out][optional] - mean value of set</param>
'''  <param name="pvariance">[out][optional] - variance</param>
'''  <param name="pmedian">[out][optional] - median value of set</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0] median has a rank 0.5 ignored if [and]rval == NULL</param>
'''  <param name="prval">[out][optional] - value in na corresponding to %rank</param>
'''  <param name="phisto">[out][optional] - Numa histogram use NULL to prevent</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetStatsUsingHistogram(
				ByVal na as Numa, 
				ByVal maxbins as Integer, 
				<Out()>  ByRef pmin as Single, 
				<Out()>  ByRef pmax as Single, 
				<Out()>  ByRef pmean as Single, 
				<Out()>  ByRef pvariance as Single, 
				<Out()>  ByRef pmedian as Single, 
				ByVal rank as Single, 
				<Out()> Optional  ByRef prval as Single = 0f, 
				<Out()> Optional  ByRef phisto as Numa = Nothing) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim phistoPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaGetStatsUsingHistogram(na.Pointer,   maxbins,   pmin,   pmax,   pmean,   pvariance,   pmedian,   rank,   prval, phistoPtr)
	
	if phistoPtr = IntPtr.Zero then phisto = Nothing else phisto = new Numa(phistoPtr)
	return _Result
End Function

' numafunc2.c (1326, 1)
' numaGetHistogramStats(nahisto, startx, deltax, pxmean, pxmedian, pxmode, pxvariance) as Integer
' numaGetHistogramStats(NUMA *, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) If the histogram represents the relation y(x), the
'''computed values that are returned are the x values.
'''These are NOT the bucket indices i they are related to the
'''bucket indices by
'''x(i) = startx + i  deltax
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetHistogramStats/*"/>
'''  <param name="nahisto">[in] - histogram: y(x(i)), i = 0 ... nbins - 1</param>
'''  <param name="startx">[in] - x value of first bin: x(0)</param>
'''  <param name="deltax">[in] - x increment between bins the bin size x(1) - x(0)</param>
'''  <param name="pxmean">[out][optional] - mean value of histogram</param>
'''  <param name="pxmedian">[out][optional] - median value of histogram</param>
'''  <param name="pxmode">[out][optional] - mode value of histogram: xmode = x(imode), where y(xmode) greater or equal y(x(i)) for all i != imode</param>
'''  <param name="pxvariance">[out][optional] - variance of x</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetHistogramStats(
				ByVal nahisto as Numa, 
				ByVal startx as Single, 
				ByVal deltax as Single, 
				<Out()> Optional  ByRef pxmean as Single = 0f, 
				<Out()> Optional  ByRef pxmedian as Single = 0f, 
				<Out()> Optional  ByRef pxmode as Single = 0f, 
				<Out()> Optional  ByRef pxvariance as Single = 0f) as Integer


if IsNothing (nahisto) then Throw New ArgumentNullException  ("nahisto cannot be Nothing")
	Dim _Result as Integer = Natives.numaGetHistogramStats(nahisto.Pointer,   startx,   deltax,   pxmean,   pxmedian,   pxmode,   pxvariance)
	
	return _Result
End Function

' numafunc2.c (1375, 1)
' numaGetHistogramStatsOnInterval(nahisto, startx, deltax, ifirst, ilast, pxmean, pxmedian, pxmode, pxvariance) as Integer
' numaGetHistogramStatsOnInterval(NUMA *, l_float32, l_float32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) If the histogram represents the relation y(x), the
'''computed values that are returned are the x values.
'''These are NOT the bucket indices i they are related to the
'''bucket indices by
'''x(i) = startx + i  deltax
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetHistogramStatsOnInterval/*"/>
'''  <param name="nahisto">[in] - histogram: y(x(i)), i = 0 ... nbins - 1</param>
'''  <param name="startx">[in] - x value of first bin: x(0)</param>
'''  <param name="deltax">[in] - x increment between bins the bin size x(1) - x(0)</param>
'''  <param name="ifirst">[in] - first bin to use for collecting stats</param>
'''  <param name="ilast">[in] - last bin for collecting stats use 0 to go to the end</param>
'''  <param name="pxmean">[out][optional] - mean value of histogram</param>
'''  <param name="pxmedian">[out][optional] - median value of histogram</param>
'''  <param name="pxmode">[out][optional] - mode value of histogram: xmode = x(imode), where y(xmode) greater or equal y(x(i)) for all i != imode</param>
'''  <param name="pxvariance">[out][optional] - variance of x</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetHistogramStatsOnInterval(
				ByVal nahisto as Numa, 
				ByVal startx as Single, 
				ByVal deltax as Single, 
				ByVal ifirst as Integer, 
				ByVal ilast as Integer, 
				<Out()> Optional  ByRef pxmean as Single = 0f, 
				<Out()> Optional  ByRef pxmedian as Single = 0f, 
				<Out()> Optional  ByRef pxmode as Single = 0f, 
				<Out()> Optional  ByRef pxvariance as Single = 0f) as Integer


if IsNothing (nahisto) then Throw New ArgumentNullException  ("nahisto cannot be Nothing")
	Dim _Result as Integer = Natives.numaGetHistogramStatsOnInterval(nahisto.Pointer,   startx,   deltax,   ifirst,   ilast,   pxmean,   pxmedian,   pxmode,   pxvariance)
	
	return _Result
End Function

' numafunc2.c (1462, 1)
' numaMakeRankFromHistogram(startx, deltax, nasy, npts, pnax, pnay) as Integer
' numaMakeRankFromHistogram(l_float32, l_float32, NUMA *, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' numaMakeRankFromHistogram()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeRankFromHistogram/*"/>
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
				<Out()>  ByRef pnax as Numa, 
				<Out()>  ByRef pnay as Numa) as Integer


if IsNothing (nasy) then Throw New ArgumentNullException  ("nasy cannot be Nothing")
	Dim pnaxPtr as IntPtr = IntPtr.Zero
	Dim pnayPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaMakeRankFromHistogram(  startx,   deltax, nasy.Pointer,   npts, pnaxPtr, pnayPtr)
	
	if pnaxPtr = IntPtr.Zero then pnax = Nothing else pnax = new Numa(pnaxPtr)
	if pnayPtr = IntPtr.Zero then pnay = Nothing else pnay = new Numa(pnayPtr)
	return _Result
End Function

' numafunc2.c (1530, 1)
' numaHistogramGetRankFromVal(na, rval, prank) as Integer
' numaHistogramGetRankFromVal(NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' (1) If we think of the histogram as a function y(x), normalized
'''to 1, for a given input value of x, this computes the
'''rank of x, which is the integral of y(x) from the start
'''value of x to the input value.<para/>
'''
'''(2) This function only makes sense when applied to a Numa that
'''is a histogram.  The values in the histogram can be ints and
'''floats, and are computed as floats.  The rank is returned
'''as a float between 0.0 and 1.0.<para/>
'''
'''(3) The numa parameters startx and binsize are used to
'''compute x from the Numa index i.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaHistogramGetRankFromVal/*"/>
'''  <param name="na">[in] - histogram</param>
'''  <param name="rval">[in] - value of input sample for which we want the rank</param>
'''  <param name="prank">[out] - fraction of total samples below rval</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaHistogramGetRankFromVal(
				ByVal na as Numa, 
				ByVal rval as Single, 
				<Out()>  ByRef prank as Single) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as Integer = Natives.numaHistogramGetRankFromVal(na.Pointer,   rval,   prank)
	
	return _Result
End Function

' numafunc2.c (1601, 1)
' numaHistogramGetValFromRank(na, rank, prval) as Integer
' numaHistogramGetValFromRank(NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' (1) If we think of the histogram as a function y(x), this returns
'''the value x such that the integral of y(x) from the start
'''value to x gives the fraction 'rank' of the integral
'''of y(x) over all bins.<para/>
'''
'''(2) This function only makes sense when applied to a Numa that
'''is a histogram.  The values in the histogram can be ints and
'''floats, and are computed as floats.  The val is returned
'''as a float, even though the buckets are of integer width.<para/>
'''
'''(3) The numa parameters startx and binsize are used to
'''compute x from the Numa index i.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaHistogramGetValFromRank/*"/>
'''  <param name="na">[in] - histogram</param>
'''  <param name="rank">[in] - fraction of total samples</param>
'''  <param name="prval">[out] - approx. to the bin value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaHistogramGetValFromRank(
				ByVal na as Numa, 
				ByVal rank as Single, 
				<Out()>  ByRef prval as Single) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as Integer = Natives.numaHistogramGetValFromRank(na.Pointer,   rank,   prval)
	
	return _Result
End Function

' numafunc2.c (1681, 1)
' numaDiscretizeRankAndIntensity(na, nbins, pnarbin, pnam, pnar, pnabb) as Integer
' numaDiscretizeRankAndIntensity(NUMA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) We are inverting the rank(intensity) function to get
'''the intensity(rank) function at %nbins equally spaced
'''values of rank between 0.0 and 1.0.  We save integer values
'''for the intensity.<para/>
'''
'''(2) We are using the word "intensity" to describe the type of
'''array values, but any array of non-negative numbers will work.<para/>
'''
'''(3) The output arrays give the following mappings, where the
'''input is a normalized histogram of array values:
'''array values to  rank bin number  (narbin)
'''rank bin number  to  median array value in bin (nam)
'''array values to  cumulative norm = rank  (nar)
'''rank bin number  to  array value at right bin edge (nabb)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaDiscretizeRankAndIntensity/*"/>
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
				<Out()> Optional  ByRef pnarbin as Numa = Nothing, 
				<Out()> Optional  ByRef pnam as Numa = Nothing, 
				<Out()> Optional  ByRef pnar as Numa = Nothing, 
				<Out()> Optional  ByRef pnabb as Numa = Nothing) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim pnarbinPtr as IntPtr = IntPtr.Zero
	Dim pnamPtr as IntPtr = IntPtr.Zero
	Dim pnarPtr as IntPtr = IntPtr.Zero
	Dim pnabbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaDiscretizeRankAndIntensity(na.Pointer,   nbins, pnarbinPtr, pnamPtr, pnarPtr, pnabbPtr)
	
	if pnarbinPtr = IntPtr.Zero then pnarbin = Nothing else pnarbin = new Numa(pnarbinPtr)
	if pnamPtr = IntPtr.Zero then pnam = Nothing else pnam = new Numa(pnamPtr)
	if pnarPtr = IntPtr.Zero then pnar = Nothing else pnar = new Numa(pnarPtr)
	if pnabbPtr = IntPtr.Zero then pnabb = Nothing else pnabb = new Numa(pnabbPtr)
	return _Result
End Function

' numafunc2.c (1829, 1)
' numaGetRankBinValues(na, nbins, pnarbin, pnam) as Integer
' numaGetRankBinValues(NUMA *, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) Simple interface for getting a binned rank representation
'''of an input array of values.  This returns two mappings:
'''array value to  rank bin number  (narbin)
'''rank bin number to  median array value in each rank bin (nam)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetRankBinValues/*"/>
'''  <param name="na">[in] - just an array of values</param>
'''  <param name="nbins">[in] - number of bins at which the rank is divided</param>
'''  <param name="pnarbin">[out][optional] - rank bin value vs array value</param>
'''  <param name="pnam">[out][optional] - median intensity in a bin vs rank bin value, with %nbins of discretized rank values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetRankBinValues(
				ByVal na as Numa, 
				ByVal nbins as Integer, 
				<Out()> Optional  ByRef pnarbin as Numa = Nothing, 
				<Out()> Optional  ByRef pnam as Numa = Nothing) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim pnarbinPtr as IntPtr = IntPtr.Zero
	Dim pnamPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaGetRankBinValues(na.Pointer,   nbins, pnarbinPtr, pnamPtr)
	
	if pnarbinPtr = IntPtr.Zero then pnarbin = Nothing else pnarbin = new Numa(pnarbinPtr)
	if pnamPtr = IntPtr.Zero then pnam = Nothing else pnam = new Numa(pnamPtr)
	return _Result
End Function

' numafunc2.c (1924, 1)
' numaSplitDistribution(na, scorefract, psplitindex, pave1, pave2, pnum1, pnum2, pnascore) as Integer
' numaSplitDistribution(NUMA *, l_float32, l_int32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' (1) This function is intended to be used on a distribution of
'''values that represent two sets, such as a histogram of
'''pixel values for an image with a fg and bg, and the goal
'''is to determine the averages of the two sets and the
'''best splitting point.<para/>
'''
'''(2) The Otsu method finds a split point that divides the distribution
'''into two parts by maximizing a score function that is the
'''product of two terms:
'''(a) the square of the difference of centroids, (ave1 - ave2)^2
'''(b) fract1  (1 - fract1)
'''where fract1 is the fraction in the lower distribution.<para/>
'''
'''(3) This works well for images where the fg and bg are
'''each relatively homogeneous and well-separated in color.
'''However, if the actual fg and bg sets are very different
'''in size, and the bg is highly varied, as can occur in some
'''scanned document images, this will bias the split point
'''into the larger "bump" (i.e., toward the point where the
'''(b) term reaches its maximum of 0.25 at fract1 = 0.5.
'''To avoid this, we define a range of values near the
'''maximum of the score function, and choose the value within
'''this range such that the histogram itself has a minimum value.
'''The range is determined by scorefract: we include all abscissa
'''values to the left and right of the value that maximizes the
'''score, such that the score stays above (1 - scorefract)  maxscore.
'''The intuition behind this modification is to try to find
'''a split point that both has a high variance score and is
'''at or near a minimum in the histogram, so that the histogram
'''slope is small at the split point.<para/>
'''
'''(4) We normalize the score so that if the two distributions
'''were of equal size and at opposite ends of the numa, the
'''score would be 1.0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSplitDistribution/*"/>
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
				<Out()> Optional  ByRef psplitindex as Integer = 0, 
				<Out()> Optional  ByRef pave1 as Single = 0f, 
				<Out()> Optional  ByRef pave2 as Single = 0f, 
				<Out()> Optional  ByRef pnum1 as Single = 0f, 
				<Out()> Optional  ByRef pnum2 as Single = 0f, 
				<Out()> Optional  ByRef pnascore as Numa = Nothing) as Integer


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim pnascorePtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.numaSplitDistribution(na.Pointer,   scorefract,   psplitindex,   pave1,   pave2,   pnum1,   pnum2, pnascorePtr)
	
	if pnascorePtr = IntPtr.Zero then pnascore = Nothing else pnascore = new Numa(pnascorePtr)
	return _Result
End Function

' numafunc2.c (2086, 1)
' grayHistogramsToEMD(naa1, naa2, pnad) as Integer
' grayHistogramsToEMD(NUMAA *, NUMAA *, NUMA **) as l_ok
'''  <summary>
''' (1) The two numaas must be the same size and have corresponding
'''256-element histograms.  Pairs do not need to be normalized
'''to the same sum.<para/>
'''
'''(2) This is typically used on two sets of histograms from
'''corresponding tiles of two images.  The similarity of two
'''images can be found with the scoring function used in
'''pixCompareGrayByHisto():
'''score S = 1.0 - k  D, where
'''k is a constant, say in the range 5-10
'''D = EMD
'''for each tile for multiple tiles, take the Min(S) over
'''the set of tiles to be the final score.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/grayHistogramsToEMD/*"/>
'''  <param name="naa1">[in] - two numaa, each with one or more 256-element histograms</param>
'''  <param name="naa2">[in] - two numaa, each with one or more 256-element histograms</param>
'''  <param name="pnad">[out] - nad of EM distances for each histogram</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function grayHistogramsToEMD(
				ByVal naa1 as Numaa, 
				ByVal naa2 as Numaa, 
				<Out()>  ByRef pnad as Numa) as Integer


if IsNothing (naa1) then Throw New ArgumentNullException  ("naa1 cannot be Nothing")
		if IsNothing (naa2) then Throw New ArgumentNullException  ("naa2 cannot be Nothing")
	Dim pnadPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.grayHistogramsToEMD(naa1.Pointer, naa2.Pointer, pnadPtr)
	
	if pnadPtr = IntPtr.Zero then pnad = Nothing else pnad = new Numa(pnadPtr)
	return _Result
End Function

' numafunc2.c (2152, 1)
' numaEarthMoverDistance(na1, na2, pdist) as Integer
' numaEarthMoverDistance(NUMA *, NUMA *, l_float32 *) as l_ok
'''  <summary>
''' (1) The two numas must have the same size.  They do not need to be
'''normalized to the same sum before applying the function.<para/>
'''
'''(2) For a 1D discrete function, the implementation of the EMD
'''is trivial.  Just keep filling or emptying buckets in one numa
'''to match the amount in the other, moving sequentially along
'''both arrays.<para/>
'''
'''(3) We divide the sum of the absolute value of everything moved
'''(by 1 unit at a time) by the sum of the numa (amount of "earth")
'''to get the average distance that the "earth" was moved.
'''This is the value returned here.<para/>
'''
'''(4) The caller can do a further normalization, by the number of
'''buckets (minus 1), to get the EM distance as a fraction of
'''the maximum possible distance, which is n-1.  This fraction
'''is 1.0 for the situation where all the 'earth' in the first
'''array is at one end, and all in the second array is at the
'''other end.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaEarthMoverDistance/*"/>
'''  <param name="na1">[in] - two numas of the same size, typically histograms</param>
'''  <param name="na2">[in] - two numas of the same size, typically histograms</param>
'''  <param name="pdist">[out] - EM distance</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaEarthMoverDistance(
				ByVal na1 as Numa, 
				ByVal na2 as Numa, 
				<Out()>  ByRef pdist as Single) as Integer


if IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
		if IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")
	Dim _Result as Integer = Natives.numaEarthMoverDistance(na1.Pointer, na2.Pointer,   pdist)
	
	return _Result
End Function

' numafunc2.c (2243, 1)
' grayInterHistogramStats(naa, wc, pnam, pnams, pnav, pnarv) as Integer
' grayInterHistogramStats(NUMAA *, l_int32, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) The %naa has two or more 256-element numa histograms, which
'''are to be compared value-wise at each of the 256 gray levels.
'''The result are stats (mean, mean square, variance, root variance)
'''aggregated across the set of histograms, and each is output
'''as a 256 entry numa.  Think of these histograms as a matrix,
'''where each histogram is one row of the array.  The stats are
'''then aggregated column-wise, between the histograms.<para/>
'''
'''(2) These stats are:
'''~ average value:  is smallerv is greater (nam)
'''~ average squared value:  is smallervv is greater  (nams)
'''~ variance:  is smaller(v -  is smallerv is greater )(v -  is smallerv is greater ) is greater  =  is smallervv is greater  -  is smallerv is greater  is smallerv is greater (nav)
'''~ square-root of variance: (narv)
'''where the brackets  is smaller ..  is greater  indicate that the average value is
'''to be taken over each column of the array.<para/>
'''
'''(3) The input histograms are optionally smoothed before these
'''statistical operations.<para/>
'''
'''(4) The input histograms are normalized to a sum of 10000.  By
'''doing this, the resulting numbers are independent of the
'''number of samples used in building the individual histograms.<para/>
'''
'''(5) A typical application is on a set of histograms from tiles
'''of an image, to distinguish between text/tables and photo
'''regions.  If the tiles are much larger than the text line
'''spacing, text/table regions typically have smaller variance
'''across tiles than photo regions.  For this application, it
'''may be useful to ignore values near white, which are large for
'''text and would magnify the variance due to variations in
'''illumination.  However, because the variance of a drawing or
'''a light photo can be similar to that of grayscale text, this
'''function is only a discriminator between darker photos/drawings
'''and light photos/text/line-graphics.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/grayInterHistogramStats/*"/>
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
				<Out()> Optional  ByRef pnam as Numa = Nothing, 
				<Out()> Optional  ByRef pnams as Numa = Nothing, 
				<Out()> Optional  ByRef pnav as Numa = Nothing, 
				<Out()> Optional  ByRef pnarv as Numa = Nothing) as Integer


if IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")
	Dim pnamPtr as IntPtr = IntPtr.Zero
	Dim pnamsPtr as IntPtr = IntPtr.Zero
	Dim pnavPtr as IntPtr = IntPtr.Zero
	Dim pnarvPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.grayInterHistogramStats(naa.Pointer,   wc, pnamPtr, pnamsPtr, pnavPtr, pnarvPtr)
	
	if pnamPtr = IntPtr.Zero then pnam = Nothing else pnam = new Numa(pnamPtr)
	if pnamsPtr = IntPtr.Zero then pnams = Nothing else pnams = new Numa(pnamsPtr)
	if pnavPtr = IntPtr.Zero then pnav = Nothing else pnav = new Numa(pnavPtr)
	if pnarvPtr = IntPtr.Zero then pnarv = Nothing else pnarv = new Numa(pnarvPtr)
	return _Result
End Function

' numafunc2.c (2333, 1)
' numaFindPeaks(nas, nmax, fract1, fract2) as Numa
' numaFindPeaks(NUMA *, l_int32, l_float32, l_float32) as NUMA *
'''  <summary>
''' (1) The returned na consists of sets of four numbers representing
'''the peak, in the following order:
'''left edge peak center right edge normalized peak area
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaFindPeaks/*"/>
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


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaFindPeaks(nas.Pointer,   nmax,   fract1,   fract2)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (2448, 1)
' numaFindExtrema(nas, delta, pnav) as Numa
' numaFindExtrema(NUMA *, l_float32, NUMA **) as NUMA *
'''  <summary>
''' (1) This returns a sequence of extrema (peaks and valleys).<para/>
'''
'''(2) The algorithm is analogous to that for determining
'''mountain peaks.  Suppose we have a local peak, with
'''bumps on the side.  Under what conditions can we consider
'''those 'bumps' to be actual peaks?  The answer: if the
'''bump is separated from the peak by a saddle that is at
'''least 500 feet below the bump.<para/>
'''
'''(3) Operationally, suppose we are looking for a peak.
'''We are keeping the largest value we've seen since the
'''last valley, and are looking for a value that is delta
'''BELOW our current peak.  When we find such a value,
'''we label the peak, use the current value to label the
'''valley, and then do the same operation in reverse (looking
'''for a valley).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaFindExtrema/*"/>
'''  <param name="nas">[in] - input values</param>
'''  <param name="delta">[in] - relative amount to resolve peaks and valleys</param>
'''  <param name="pnav">[out][optional] - values of extrema</param>
'''   <returns>nad (locations of extrema, or NULL on error</returns>
Public Shared Function numaFindExtrema(
				ByVal nas as Numa, 
				ByVal delta as Single, 
				<Out()> Optional  ByRef pnav as Numa = Nothing) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim pnavPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.numaFindExtrema(nas.Pointer,   delta, pnavPtr)
	
	if pnavPtr = IntPtr.Zero then pnav = Nothing else pnav = new Numa(pnavPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (2544, 1)
' numaCountReversals(nas, minreversal, pnr, pnrpl) as Integer
' numaCountReversals(NUMA *, l_float32, l_int32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) The input numa is can be generated from pixExtractAlongLine().
'''If so, the x parameters can be used to find the reversal
'''frequency along a line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCountReversals/*"/>
'''  <param name="nas">[in] - input values</param>
'''  <param name="minreversal">[in] - relative amount to resolve peaks and valleys</param>
'''  <param name="pnr">[out][optional] - number of reversals</param>
'''  <param name="pnrpl">[out] - ([optional] reversal density: reversals/length</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaCountReversals(
				ByVal nas as Numa, 
				ByVal minreversal as Single, 
				<Out()> Optional  ByRef pnr as Integer = 0, 
				<Out()> Optional  ByRef pnrpl as Single = 0f) as Integer


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as Integer = Natives.numaCountReversals(nas.Pointer,   minreversal,   pnr,   pnrpl)
	
	return _Result
End Function

' numafunc2.c (2606, 1)
' numaSelectCrossingThreshold(nax, nay, estthresh, pbestthresh) as Integer
' numaSelectCrossingThreshold(NUMA *, NUMA *, l_float32, l_float32 *) as l_ok
'''  <summary>
''' (1) When a valid threshold is used, the number of crossings is
'''a maximum, because none are missed.  If no threshold intersects
'''all the crossings, the crossings must be determined with
'''numaCrossingsByPeaks().<para/>
'''
'''(2) %estthresh is an input estimate of the threshold that should
'''be used.  We compute the crossings with 41 thresholds
'''(20 below and 20 above).  There is a range in which the
'''number of crossings is a maximum.  Return a threshold
'''in the center of this stable plateau of crossings.
'''This can then be used with numaCrossingsByThreshold()
'''to get a good estimate of crossing locations.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSelectCrossingThreshold/*"/>
'''  <param name="nax">[in][optional] - numa of abscissa values can be NULL</param>
'''  <param name="nay">[in] - signal</param>
'''  <param name="estthresh">[in] - estimated pixel threshold for crossing: e.g., for images, white  is smallerto black typ. ~120</param>
'''  <param name="pbestthresh">[out] - robust estimate of threshold to use</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSelectCrossingThreshold(
				ByVal nax as Numa, 
				ByVal nay as Numa, 
				ByVal estthresh as Single, 
				<Out()>  ByRef pbestthresh as Single) as Integer


if IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")
	Dim naxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nax) Then naxPtr = nax.Pointer

	Dim _Result as Integer = Natives.numaSelectCrossingThreshold(naxPtr, nay.Pointer,   estthresh,   pbestthresh)
	
	return _Result
End Function

' numafunc2.c (2713, 1)
' numaCrossingsByThreshold(nax, nay, thresh) as Numa
' numaCrossingsByThreshold(NUMA *, NUMA *, l_float32) as NUMA *
'''  <summary>
''' (1) If nax == NULL, we use startx and delx from nay to compute
'''the crossing values in nad.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCrossingsByThreshold/*"/>
'''  <param name="nax">[in][optional] - numa of abscissa values can be NULL</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="thresh">[in] - threshold value for nay</param>
'''   <returns>nad abscissa pts at threshold, or NULL on error</returns>
Public Shared Function numaCrossingsByThreshold(
				ByVal nax as Numa, 
				ByVal nay as Numa, 
				ByVal thresh as Single) as Numa


if IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")
	Dim naxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nax) Then naxPtr = nax.Pointer

	Dim _Result as IntPtr = Natives.numaCrossingsByThreshold(naxPtr, nay.Pointer,   thresh)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (2778, 1)
' numaCrossingsByPeaks(nax, nay, delta) as Numa
' numaCrossingsByPeaks(NUMA *, NUMA *, l_float32) as NUMA *
'''  <summary>
''' (1) If nax == NULL, we use startx and delx from nay to compute
'''the crossing values in nad.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCrossingsByPeaks/*"/>
'''  <param name="nax">[in][optional] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="delta">[in] - parameter used to identify when a new peak can be found</param>
'''   <returns>nad abscissa pts at threshold, or NULL on error</returns>
Public Shared Function numaCrossingsByPeaks(
				ByVal nax as Numa, 
				ByVal nay as Numa, 
				ByVal delta as Single) as Numa


if IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")
	Dim naxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nax) Then naxPtr = nax.Pointer

	Dim _Result as IntPtr = Natives.numaCrossingsByPeaks(naxPtr, nay.Pointer,   delta)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' numafunc2.c (2890, 1)
' numaEvalBestHaarParameters(nas, relweight, nwidth, nshift, minwidth, maxwidth, pbestwidth, pbestshift, pbestscore) as Integer
' numaEvalBestHaarParameters(NUMA *, l_float32, l_int32, l_int32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) This does a linear sweep of widths, evaluating at %nshift
'''shifts for each width, computing the score from a convolution
'''with a long comb, and finding the (width, shift) pair that
'''gives the maximum score.  The best width is the "half-wavelength"
'''of the signal.<para/>
'''
'''(2) The convolving function is a comb of alternating values
'''+1 and -1  relweight, separated by the width and phased by
'''the shift.  This is similar to a Haar transform, except
'''there the convolution is performed with a square wave.<para/>
'''
'''(3) The function is useful for finding the line spacing
'''and strength of line signal from pixel sum projections.<para/>
'''
'''(4) The score is normalized to the size of nas divided by
'''the number of half-widths.  For image applications, the input is
'''typically an array of pixel projections, so one should
'''normalize by dividing the score by the image width in the
'''pixel projection direction.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaEvalBestHaarParameters/*"/>
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
				<Out()>  ByRef pbestwidth as Single, 
				<Out()>  ByRef pbestshift as Single, 
				<Out()> Optional  ByRef pbestscore as Single = 0f) as Integer


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as Integer = Natives.numaEvalBestHaarParameters(nas.Pointer,   relweight,   nwidth,   nshift,   minwidth,   maxwidth,   pbestwidth,   pbestshift,   pbestscore)
	
	return _Result
End Function

' numafunc2.c (2975, 1)
' numaEvalHaarSum(nas, width, shift, relweight, pscore) as Integer
' numaEvalHaarSum(NUMA *, l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' (1) This does a convolution with a comb of alternating values
'''+1 and -relweight, separated by the width and phased by the shift.
'''This is similar to a Haar transform, except that for Haar,<para/>
'''
'''(1) the convolution kernel is symmetric about 0, so the
'''relweight is 1.0, and<para/>
'''
'''(2) the convolution is performed with a square wave.<para/>
'''
'''(2) The score is normalized to the size of nas divided by
'''twice the "width".  For image applications, the input is
'''typically an array of pixel projections, so one should
'''normalize by dividing the score by the image width in the
'''pixel projection direction.<para/>
'''
'''(3) To get a Haar-like result, use relweight = 1.0.  For detecting
'''signals where you expect every other sample to be close to
'''zero, as with barcodes or filtered text lines, you can
'''use relweight  is greater  1.0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaEvalHaarSum/*"/>
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
				<Out()>  ByRef pscore as Single) as Integer


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim _Result as Integer = Natives.numaEvalHaarSum(nas.Pointer,   width,   shift,   relweight,   pscore)
	
	return _Result
End Function

' numafunc2.c (3032, 1)
' genConstrainedNumaInRange(first, last, nmax, use_pairs) as Numa
' genConstrainedNumaInRange(l_int32, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' (1) Selection is made uniformly in the range.  This can be used
'''to select pages distributed as uniformly as possible
'''through a book, where you are constrained to:
'''~ choose between [first, ... biggest],
'''~ choose no more than nmax numbers, and
'''and you have the option of requiring pairs of adjacent numbers.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/genConstrainedNumaInRange/*"/>
'''  <param name="first">[in] - first number to choose greater or equal 0</param>
'''  <param name="last">[in] - biggest possible number to reach greater or equal first</param>
'''  <param name="nmax">[in] - maximum number of numbers to select  is greater  0</param>
'''  <param name="use_pairs">[in] - 1 = select pairs of adjacent numbers 0 = select individual numbers</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function genConstrainedNumaInRange(
				ByVal first as Integer, 
				ByVal last as Integer, 
				ByVal nmax as Integer, 
				ByVal use_pairs as Integer) as Numa


	Dim _Result as IntPtr = Natives.genConstrainedNumaInRange(  first,   last,   nmax,   use_pairs)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

End Class


