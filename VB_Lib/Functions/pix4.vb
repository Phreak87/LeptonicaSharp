Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' pix4.c (109, 1)
' pixGetGrayHistogram(pixs, factor) as Numa
' pixGetGrayHistogram(PIX *, l_int32) as NUMA *
'''  <summary>
''' (1) If pixs has a colormap, it is converted to 8 bpp gray.
'''If you want a histogram of the colormap indices, use
'''pixGetCmapHistogram().<para/>
'''
'''(2) If pixs does not have a colormap, the output histogram is
'''of size 2^d, where d is the depth of pixs.<para/>
'''
'''(3) Set the subsampling factor  is greater  1 to reduce the amount of computation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetGrayHistogram/*"/>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 bpp can be colormapped</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixGetGrayHistogram(
				ByVal pixs as Pix, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetGrayHistogram(pixs.Pointer,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (205, 1)
' pixGetGrayHistogramMasked(pixs, pixm, x, y, factor) as Numa
' pixGetGrayHistogramMasked(PIX *, PIX *, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' (1) If pixs is cmapped, it is converted to 8 bpp gray.
'''If you want a histogram of the colormap indices, use
'''pixGetCmapHistogramMasked().<para/>
'''
'''(2) This always returns a 256-value histogram of pixel values.<para/>
'''
'''(3) Set the subsampling factor  is greater  1 to reduce the amount of computation.<para/>
'''
'''(4) Clipping of pixm (if it exists) to pixs is done in the inner loop.<para/>
'''
'''(5) Input x,y are ignored unless pixm exists.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetGrayHistogramMasked/*"/>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which histogram is to be computed use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixGetGrayHistogramMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as IntPtr = Natives.pixGetGrayHistogramMasked(pixs.Pointer, pixmPtr,   x,   y,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (285, 1)
' pixGetGrayHistogramInRect(pixs, box, factor) as Numa
' pixGetGrayHistogramInRect(PIX *, BOX *, l_int32) as NUMA *
'''  <summary>
''' (1) If pixs is cmapped, it is converted to 8 bpp gray.
'''If you want a histogram of the colormap indices, use
'''pixGetCmapHistogramInRect().<para/>
'''
'''(2) This always returns a 256-value histogram of pixel values.<para/>
'''
'''(3) Set the subsampling %factor  is greater  1 to reduce the amount of computation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetGrayHistogramInRect/*"/>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="box">[in][optional] - over which histogram is to be computed use full image if NULL</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixGetGrayHistogramInRect(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixGetGrayHistogramInRect(pixs.Pointer, boxPtr,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (353, 1)
' pixGetGrayHistogramTiled(pixs, factor, nx, ny) as Numaa
' pixGetGrayHistogramTiled(PIX *, l_int32, l_int32, l_int32) as NUMAA *
'''  <summary>
''' (1) If pixs is cmapped, it is converted to 8 bpp gray.<para/>
'''
'''(2) This returns a set of 256-value histograms of pixel values.<para/>
'''
'''(3) Set the subsampling factor  is greater  1 to reduce the amount of computation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetGrayHistogramTiled/*"/>
'''  <param name="pixs">[in] - any depth, colormap OK</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="nx">[in] - tiling greater or equal 1 typically small</param>
'''  <param name="ny">[in] - tiling greater or equal 1 typically small</param>
'''   <returns>naa set of histograms, or NULL on error</returns>
Public Shared Function pixGetGrayHistogramTiled(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer) as Numaa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetGrayHistogramTiled(pixs.Pointer,   factor,   nx,   ny)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numaa(_Result)
End Function

' pix4.c (410, 1)
' pixGetColorHistogram(pixs, factor, pnar, pnag, pnab) as Integer
' pixGetColorHistogram(PIX *, l_int32, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) This generates a set of three 256 entry histograms,
'''one for each color component (r,g,b).<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColorHistogram/*"/>
'''  <param name="pixs">[in] - rgb or colormapped</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="pnar">[out] - red histogram</param>
'''  <param name="pnag">[out] - green histogram</param>
'''  <param name="pnab">[out] - blue histogram</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetColorHistogram(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				<Out()>  ByRef pnar as Numa, 
				<Out()>  ByRef pnag as Numa, 
				<Out()>  ByRef pnab as Numa) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnarPtr as IntPtr = IntPtr.Zero
	Dim pnagPtr as IntPtr = IntPtr.Zero
	Dim pnabPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetColorHistogram(pixs.Pointer,   factor, pnarPtr, pnagPtr, pnabPtr)
	
	if pnarPtr = IntPtr.Zero then pnar = Nothing else pnar = new Numa(pnarPtr)
	if pnagPtr = IntPtr.Zero then pnag = Nothing else pnag = new Numa(pnagPtr)
	if pnabPtr = IntPtr.Zero then pnab = Nothing else pnab = new Numa(pnabPtr)
	return _Result
End Function

' pix4.c (512, 1)
' pixGetColorHistogramMasked(pixs, pixm, x, y, factor, pnar, pnag, pnab) as Integer
' pixGetColorHistogramMasked(PIX *, PIX *, l_int32, l_int32, l_int32, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) This generates a set of three 256 entry histograms,<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.<para/>
'''
'''(3) Clipping of pixm (if it exists) to pixs is done in the inner loop.<para/>
'''
'''(4) Input x,y are ignored unless pixm exists.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColorHistogramMasked/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which histogram is to be computed use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="pnar">[out] - red histogram</param>
'''  <param name="pnag">[out] - green histogram</param>
'''  <param name="pnab">[out] - blue histogram</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetColorHistogramMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				<Out()>  ByRef pnar as Numa, 
				<Out()>  ByRef pnag as Numa, 
				<Out()>  ByRef pnab as Numa) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer
	Dim pnarPtr as IntPtr = IntPtr.Zero
	Dim pnagPtr as IntPtr = IntPtr.Zero
	Dim pnabPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetColorHistogramMasked(pixs.Pointer, pixmPtr,   x,   y,   factor, pnarPtr, pnagPtr, pnabPtr)
	
	if pnarPtr = IntPtr.Zero then pnar = Nothing else pnar = new Numa(pnarPtr)
	if pnagPtr = IntPtr.Zero then pnag = Nothing else pnag = new Numa(pnagPtr)
	if pnabPtr = IntPtr.Zero then pnab = Nothing else pnab = new Numa(pnabPtr)
	return _Result
End Function

' pix4.c (627, 1)
' pixGetCmapHistogram(pixs, factor) as Numa
' pixGetCmapHistogram(PIX *, l_int32) as NUMA *
'''  <summary>
''' (1) This generates a histogram of colormap pixel indices,
'''and is of size 2^d.<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetCmapHistogram/*"/>
'''  <param name="pixs">[in] - colormapped: d = 2, 4 or 8</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram of cmap indices, or NULL on error</returns>
Public Shared Function pixGetCmapHistogram(
				ByVal pixs as Pix, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetCmapHistogram(pixs.Pointer,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (692, 1)
' pixGetCmapHistogramMasked(pixs, pixm, x, y, factor) as Numa
' pixGetCmapHistogramMasked(PIX *, PIX *, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' (1) This generates a histogram of colormap pixel indices,
'''and is of size 2^d.<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.<para/>
'''
'''(3) Clipping of pixm to pixs is done in the inner loop.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetCmapHistogramMasked/*"/>
'''  <param name="pixs">[in] - colormapped: d = 2, 4 or 8</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which histogram is to be computed use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixGetCmapHistogramMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as IntPtr = Natives.pixGetCmapHistogramMasked(pixs.Pointer, pixmPtr,   x,   y,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (772, 1)
' pixGetCmapHistogramInRect(pixs, box, factor) as Numa
' pixGetCmapHistogramInRect(PIX *, BOX *, l_int32) as NUMA *
'''  <summary>
''' (1) This generates a histogram of colormap pixel indices,
'''and is of size 2^d.<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of computation.<para/>
'''
'''(3) Clipping to the box is done in the inner loop.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetCmapHistogramInRect/*"/>
'''  <param name="pixs">[in] - colormapped: d = 2, 4 or 8</param>
'''  <param name="box">[in][optional] - over which histogram is to be computed use full image if NULL</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>na histogram, or NULL on error</returns>
Public Shared Function pixGetCmapHistogramInRect(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal factor as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixGetCmapHistogramInRect(pixs.Pointer, boxPtr,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' pix4.c (831, 1)
' pixCountRGBColors(pixs) as Integer
' pixCountRGBColors(PIX *) as l_int32
'''  <summary>
''' pixCountRGBColors()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountRGBColors/*"/>
'''  <param name="pixs">[in] - rgb or rgba</param>
'''   <returns>ncolors, or -1 on error</returns>
Public Shared Function pixCountRGBColors(
				ByVal pixs as Pix) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as Integer = Natives.pixCountRGBColors(pixs.Pointer)
	
	return _Result
End Function

' pix4.c (861, 1)
' pixGetColorAmapHistogram(pixs, factor) as L_Rbtree
' pixGetColorAmapHistogram(PIX *, l_int32) as L_AMAP *
'''  <summary>
''' (1) This generates an ordered map from pixel value to histogram count.<para/>
'''
'''(2) Use amapGetCountForColor() to use the map to look up a count.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColorAmapHistogram/*"/>
'''  <param name="pixs">[in] - rgb or rgba</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''   <returns>amap, or NULL on error</returns>
Public Shared Function pixGetColorAmapHistogram(
				ByVal pixs as Pix, 
				ByVal factor as Integer) as L_Rbtree


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetColorAmapHistogram(pixs.Pointer,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree(_Result)
End Function

' pix4.c (910, 1)
' amapGetCountForColor(amap, val) as Integer
' amapGetCountForColor(L_AMAP *, l_uint32) as l_int32
'''  <summary>
''' (1) The ordered map is made by pixGetColorAmapHistogram().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/amapGetCountForColor/*"/>
'''  <param name="amap">[in] - map from pixel value to count</param>
'''  <param name="val">[in] - rgb or rgba pixel value</param>
'''   <returns>count, or -1 on error</returns>
Public Shared Function amapGetCountForColor(
				ByVal amap as L_Rbtree, 
				ByVal val as UInteger) as Integer


if IsNothing (amap) then Throw New ArgumentNullException  ("amap cannot be Nothing")
	Dim _Result as Integer = Natives.amapGetCountForColor(amap.Pointer,   val)
	
	return _Result
End Function

' pix4.c (945, 1)
' pixGetRankValue(pixs, factor, rank, pvalue) as Integer
' pixGetRankValue(PIX *, l_int32, l_float32, l_uint32 *) as l_ok
'''  <summary>
''' (1) Simple function to get rank values of an image.
'''For a color image, the median value (rank = 0.5) can be
'''used to linearly remap the colors based on the median
'''of a target image, using pixLinearMapToTargetColor().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRankValue/*"/>
'''  <param name="pixs">[in] - 8 bpp, 32 bpp or colormapped</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="rank">[in] - between 0.0 and 1.0 1.0 is brightest, 0.0 is darkest</param>
'''  <param name="pvalue">[out] - pixel value corresponding to input rank</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRankValue(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal rank as Single, 
				<Out()>  ByRef pvalue as UInteger) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetRankValue(pixs.Pointer,   factor,   rank,   pvalue)
	
	return _Result
End Function

' pix4.c (1015, 1)
' pixGetRankValueMaskedRGB(pixs, pixm, x, y, factor, rank, prval, pgval, pbval) as Integer
' pixGetRankValueMaskedRGB(PIX *, PIX *, l_int32, l_int32, l_int32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) Computes the rank component values of pixels in pixs that
'''are under the fg of the optional mask.  If the mask is null, it
'''computes the average of the pixels in pixs.<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of
'''computation.<para/>
'''
'''(4) Input x,y are ignored unless pixm exists.<para/>
'''
'''(5) The rank must be in [0.0 ... 1.0], where the brightest pixel
'''has rank 1.0.  For the median pixel value, use 0.5.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRankValueMaskedRGB/*"/>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which rank val is to be taken use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="rank">[in] - between 0.0 and 1.0 1.0 is brightest, 0.0 is darkest</param>
'''  <param name="prval">[out][optional] - red component val for input rank</param>
'''  <param name="pgval">[out][optional] - green component val for input rank</param>
'''  <param name="pbval">[out][optional] - blue component val for input rank</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRankValueMaskedRGB(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				ByVal rank as Single, 
				<Out()> Optional  ByRef prval as Single = 0f, 
				<Out()> Optional  ByRef pgval as Single = 0f, 
				<Out()> Optional  ByRef pbval as Single = 0f) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as Integer = Natives.pixGetRankValueMaskedRGB(pixs.Pointer, pixmPtr,   x,   y,   factor,   rank,   prval,   pgval,   pbval)
	
	return _Result
End Function

' pix4.c (1107, 1)
' pixGetRankValueMasked(pixs, pixm, x, y, factor, rank, pval, pna) as Integer
' pixGetRankValueMasked(PIX *, PIX *, l_int32, l_int32, l_int32, l_float32, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' (1) Computes the rank value of pixels in pixs that are under
'''the fg of the optional mask.  If the mask is null, it
'''computes the average of the pixels in pixs.<para/>
'''
'''(2) Set the subsampling %factor  is greater  1 to reduce the amount of
'''computation.<para/>
'''
'''(3) Clipping of pixm (if it exists) to pixs is done in the inner loop.<para/>
'''
'''(4) Input x,y are ignored unless pixm exists.<para/>
'''
'''(5) The rank must be in [0.0 ... 1.0], where the brightest pixel
'''has rank 1.0.  For the median pixel value, use 0.5.<para/>
'''
'''(6) The histogram can optionally be returned, so that other rank
'''values can be extracted without recomputing the histogram.
'''In that case, just use
'''numaHistogramGetValFromRank(na, rank, [and]val)
'''on the returned Numa for additional rank values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRankValueMasked/*"/>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask, over which the rank val is to be taken use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0 these values are ignored if pixm is null</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="rank">[in] - between 0.0 and 1.0 1.0 is brightest, 0.0 is darkest</param>
'''  <param name="pval">[out] - pixel value corresponding to input rank</param>
'''  <param name="pna">[out][optional] - of histogram</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRankValueMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				ByVal rank as Single, 
				<Out()>  ByRef pval as Single, 
				<Out()> Optional  ByRef pna as Numa = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer
	Dim pnaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetRankValueMasked(pixs.Pointer, pixmPtr,   x,   y,   factor,   rank,   pval, pnaPtr)
	
	if pnaPtr = IntPtr.Zero then pna = Nothing else pna = new Numa(pnaPtr)
	return _Result
End Function

' pix4.c (1176, 1)
' pixGetPixelAverage(pixs, pixm, x, y, factor, pval) as Integer
' pixGetPixelAverage(PIX *, PIX *, l_int32, l_int32, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' (1) For rgb pix, this is a more direct computation of the
'''average value of the pixels in %pixs that are under the
'''mask %pixm. It is faster than pixGetPixelStats(), which
'''calls pixGetAverageMaskedRGB() and has the overhead of
'''generating a temporary pix of each of the three components
'''this can take most of the time if %factor  is greater  1.<para/>
'''
'''(2) If %pixm is null, this gives the average value of all
'''pixels in %pixs.  The returned value is an integer.<para/>
'''
'''(3) For color %pixs, the returned pixel value is in the standard
'''uint32 RGBA packing.<para/>
'''
'''(4) Clipping of pixm (if it exists) to pixs is done in the inner loop.<para/>
'''
'''(5) Input x,y are ignored if %pixm does not exist.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetPixelAverage/*"/>
'''  <param name="pixs">[in] - 8 or 32 bpp, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which average is to be taken use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1</param>
'''  <param name="pval">[out] - average pixel value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetPixelAverage(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				<Out()>  ByRef pval as UInteger) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as Integer = Natives.pixGetPixelAverage(pixs.Pointer, pixmPtr,   x,   y,   factor,   pval)
	
	return _Result
End Function

' pix4.c (1294, 1)
' pixGetPixelStats(pixs, factor, type, pvalue) as Integer
' pixGetPixelStats(PIX *, l_int32, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' (1) Simple function to get one of four statistical values of an image.<para/>
'''
'''(2) It does not take a mask: it uses the entire image.<para/>
'''
'''(3) To get the average pixel value of an RGB image, suggest using
'''pixGetPixelAverage(), which is considerably faster.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetPixelStats/*"/>
'''  <param name="pixs">[in] - 8 bpp, 32 bpp or colormapped</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_ROOT_MEAN_SQUARE, L_STANDARD_DEVIATION, L_VARIANCE</param>
'''  <param name="pvalue">[out] - pixel value corresponding to input type</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetPixelStats(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal type as Enumerations.L_statistical_measures, 
				<Out()>  ByRef pvalue as UInteger) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetPixelStats(pixs.Pointer,   factor,   type,   pvalue)
	
	return _Result
End Function

' pix4.c (1361, 1)
' pixGetAverageMaskedRGB(pixs, pixm, x, y, factor, type, prval, pgval, pbval) as Integer
' pixGetAverageMaskedRGB(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) For usage, see pixGetAverageMasked().<para/>
'''
'''(2) If there is a colormap, it is removed before the 8 bpp
'''component images are extracted.<para/>
'''
'''(3) A better name for this would be: pixGetPixelStatsRGB()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAverageMaskedRGB/*"/>
'''  <param name="pixs">[in] - 32 bpp, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which average is to be taken use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_ROOT_MEAN_SQUARE, L_STANDARD_DEVIATION, L_VARIANCE</param>
'''  <param name="prval">[out][optional] - measured red value of given 'type'</param>
'''  <param name="pgval">[out][optional] - measured green value of given 'type'</param>
'''  <param name="pbval">[out][optional] - measured blue value of given 'type'</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetAverageMaskedRGB(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				ByVal type as Enumerations.L_statistical_measures, 
				<Out()> Optional  ByRef prval as Single = 0f, 
				<Out()> Optional  ByRef pgval as Single = 0f, 
				<Out()> Optional  ByRef pbval as Single = 0f) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as Integer = Natives.pixGetAverageMaskedRGB(pixs.Pointer, pixmPtr,   x,   y,   factor,   type,   prval,   pgval,   pbval)
	
	return _Result
End Function

' pix4.c (1457, 1)
' pixGetAverageMasked(pixs, pixm, x, y, factor, type, pval) as Integer
' pixGetAverageMasked(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' (1) Use L_MEAN_ABSVAL to get the average value of pixels in pixs
'''that are under the fg of the optional mask.  If the mask
'''is null, it finds the average of the pixels in pixs.<para/>
'''
'''(2) Likewise, use L_ROOT_MEAN_SQUARE to get the rms value of
'''pixels in pixs, either masked or not L_STANDARD_DEVIATION
'''to get the standard deviation from the mean of the pixels
'''L_VARIANCE to get the average squared difference from the
'''expected value.  The variance is the square of the stdev.
'''For the standard deviation, we use
'''sqrt([([x] - x)]^2) = sqrt([x^2] - [x]^2)<para/>
'''
'''(3) Set the subsampling %factor  is greater  1 to reduce the amount of
'''computation.<para/>
'''
'''(4) Clipping of pixm (if it exists) to pixs is done in the inner loop.<para/>
'''
'''(5) Input x,y are ignored unless pixm exists.<para/>
'''
'''(6) A better name for this would be: pixGetPixelStatsGray()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAverageMasked/*"/>
'''  <param name="pixs">[in] - 8 or 16 bpp, or colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask over which average is to be taken use all pixels if null</param>
'''  <param name="x">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="y">[in] - UL corner of pixm relative to the UL corner of pixs can be  is smaller 0</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_ROOT_MEAN_SQUARE, L_STANDARD_DEVIATION, L_VARIANCE</param>
'''  <param name="pval">[out] - measured value of given 'type'</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetAverageMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal factor as Integer, 
				ByVal type as Enumerations.L_statistical_measures, 
				<Out()>  ByRef pval as Single) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixmPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as Integer = Natives.pixGetAverageMasked(pixs.Pointer, pixmPtr,   x,   y,   factor,   type,   pval)
	
	return _Result
End Function

' pix4.c (1576, 1)
' pixGetAverageTiledRGB(pixs, sx, sy, type, ppixr, ppixg, ppixb) as Integer
' pixGetAverageTiledRGB(PIX *, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
'''  <summary>
''' (1) For usage, see pixGetAverageTiled().<para/>
'''
'''(2) If there is a colormap, it is removed before the 8 bpp
'''component images are extracted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAverageTiledRGB/*"/>
'''  <param name="pixs">[in] - 32 bpp, or colormapped</param>
'''  <param name="sx">[in] - tile size must be at least 2 x 2</param>
'''  <param name="sy">[in] - tile size must be at least 2 x 2</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_ROOT_MEAN_SQUARE, L_STANDARD_DEVIATION</param>
'''  <param name="ppixr">[out][optional] - tiled 'average' of red component</param>
'''  <param name="ppixg">[out][optional] - tiled 'average' of green component</param>
'''  <param name="ppixb">[out][optional] - tiled 'average' of blue component</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetAverageTiledRGB(
				ByVal pixs as Pix, 
				ByVal sx as Integer, 
				ByVal sy as Integer, 
				ByVal type as Enumerations.L_statistical_measures, 
				<Out()> Optional  ByRef ppixr as Pix = Nothing, 
				<Out()> Optional  ByRef ppixg as Pix = Nothing, 
				<Out()> Optional  ByRef ppixb as Pix = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixrPtr as IntPtr = IntPtr.Zero
	Dim ppixgPtr as IntPtr = IntPtr.Zero
	Dim ppixbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetAverageTiledRGB(pixs.Pointer,   sx,   sy,   type, ppixrPtr, ppixgPtr, ppixbPtr)
	
	if ppixrPtr = IntPtr.Zero then ppixr = Nothing else ppixr = new Pix(ppixrPtr)
	if ppixgPtr = IntPtr.Zero then ppixg = Nothing else ppixg = new Pix(ppixgPtr)
	if ppixbPtr = IntPtr.Zero then ppixb = Nothing else ppixb = new Pix(ppixbPtr)
	return _Result
End Function

' pix4.c (1653, 1)
' pixGetAverageTiled(pixs, sx, sy, type) as Pix
' pixGetAverageTiled(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Only computes for tiles that are entirely contained in pixs.<para/>
'''
'''(2) Use L_MEAN_ABSVAL to get the average abs value within the tile
'''L_ROOT_MEAN_SQUARE to get the rms value within each tile
'''L_STANDARD_DEVIATION to get the standard dev. from the average
'''within each tile.<para/>
'''
'''(3) If colormapped, converts to 8 bpp gray.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAverageTiled/*"/>
'''  <param name="pixs">[in] - 8 bpp, or colormapped</param>
'''  <param name="sx">[in] - tile size must be at least 2 x 2</param>
'''  <param name="sy">[in] - tile size must be at least 2 x 2</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_ROOT_MEAN_SQUARE, L_STANDARD_DEVIATION</param>
'''   <returns>pixd average values in each tile, or NULL on error</returns>
Public Shared Function pixGetAverageTiled(
				ByVal pixs as Pix, 
				ByVal sx as Integer, 
				ByVal sy as Integer, 
				ByVal type as Enumerations.L_statistical_measures) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetAverageTiled(pixs.Pointer,   sx,   sy,   type)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pix4.c (1756, 1)
' pixRowStats(pixs, box, pnamean, pnamedian, pnamode, pnamodecount, pnavar, pnarootvar) as Integer
' pixRowStats(PIX *, BOX *, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **) as l_int32
'''  <summary>
''' (1) This computes numas that represent column vectors of statistics,
'''with each of its values derived from the corresponding row of a Pix.<para/>
'''
'''(2) Use NULL on input to prevent computation of any of the 5 numas.<para/>
'''
'''(3) Other functions that compute pixel row statistics are:
'''pixCountPixelsByRow()
'''pixAverageByRow()
'''pixVarianceByRow()
'''pixGetRowStats()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRowStats/*"/>
'''  <param name="pixs">[in] - 8 bpp not cmapped</param>
'''  <param name="box">[in][optional] - clipping box can be null</param>
'''  <param name="pnamean">[out][optional] - numa of mean values</param>
'''  <param name="pnamedian">[out][optional] - numa of median values</param>
'''  <param name="pnamode">[out][optional] - numa of mode intensity values</param>
'''  <param name="pnamodecount">[out][optional] - numa of mode counts</param>
'''  <param name="pnavar">[out][optional] - numa of variance</param>
'''  <param name="pnarootvar">[out][optional] - numa of square root of variance</param>
'''   <returns>na numa of requested statistic for each row, or NULL on error</returns>
Public Shared Function pixRowStats(
				ByVal pixs as Pix, 
				Optional ByVal box as Box = Nothing, 
				<Out()> Optional  ByRef pnamean as Numa = Nothing, 
				<Out()> Optional  ByRef pnamedian as Numa = Nothing, 
				<Out()> Optional  ByRef pnamode as Numa = Nothing, 
				<Out()> Optional  ByRef pnamodecount as Numa = Nothing, 
				<Out()> Optional  ByRef pnavar as Numa = Nothing, 
				<Out()> Optional  ByRef pnarootvar as Numa = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer
	Dim pnameanPtr as IntPtr = IntPtr.Zero
	Dim pnamedianPtr as IntPtr = IntPtr.Zero
	Dim pnamodePtr as IntPtr = IntPtr.Zero
	Dim pnamodecountPtr as IntPtr = IntPtr.Zero
	Dim pnavarPtr as IntPtr = IntPtr.Zero
	Dim pnarootvarPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixRowStats(pixs.Pointer, boxPtr, pnameanPtr, pnamedianPtr, pnamodePtr, pnamodecountPtr, pnavarPtr, pnarootvarPtr)
	
	if pnameanPtr = IntPtr.Zero then pnamean = Nothing else pnamean = new Numa(pnameanPtr)
	if pnamedianPtr = IntPtr.Zero then pnamedian = Nothing else pnamedian = new Numa(pnamedianPtr)
	if pnamodePtr = IntPtr.Zero then pnamode = Nothing else pnamode = new Numa(pnamodePtr)
	if pnamodecountPtr = IntPtr.Zero then pnamodecount = Nothing else pnamodecount = new Numa(pnamodecountPtr)
	if pnavarPtr = IntPtr.Zero then pnavar = Nothing else pnavar = new Numa(pnavarPtr)
	if pnarootvarPtr = IntPtr.Zero then pnarootvar = Nothing else pnarootvar = new Numa(pnarootvarPtr)
	return _Result
End Function

' pix4.c (1916, 1)
' pixColumnStats(pixs, box, pnamean, pnamedian, pnamode, pnamodecount, pnavar, pnarootvar) as Integer
' pixColumnStats(PIX *, BOX *, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **) as l_int32
'''  <summary>
''' (1) This computes numas that represent row vectors of statistics,
'''with each of its values derived from the corresponding col of a Pix.<para/>
'''
'''(2) Use NULL on input to prevent computation of any of the 5 numas.<para/>
'''
'''(3) Other functions that compute pixel column statistics are:
'''pixCountPixelsByColumn()
'''pixAverageByColumn()
'''pixVarianceByColumn()
'''pixGetColumnStats()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColumnStats/*"/>
'''  <param name="pixs">[in] - 8 bpp not cmapped</param>
'''  <param name="box">[in][optional] - clipping box can be null</param>
'''  <param name="pnamean">[out][optional] - numa of mean values</param>
'''  <param name="pnamedian">[out][optional] - numa of median values</param>
'''  <param name="pnamode">[out][optional] - numa of mode intensity values</param>
'''  <param name="pnamodecount">[out][optional] - numa of mode counts</param>
'''  <param name="pnavar">[out][optional] - numa of variance</param>
'''  <param name="pnarootvar">[out][optional] - numa of square root of variance</param>
'''   <returns>na numa of requested statistic for each column, or NULL on error</returns>
Public Shared Function pixColumnStats(
				ByVal pixs as Pix, 
				Optional ByVal box as Box = Nothing, 
				<Out()> Optional  ByRef pnamean as Numa = Nothing, 
				<Out()> Optional  ByRef pnamedian as Numa = Nothing, 
				<Out()> Optional  ByRef pnamode as Numa = Nothing, 
				<Out()> Optional  ByRef pnamodecount as Numa = Nothing, 
				<Out()> Optional  ByRef pnavar as Numa = Nothing, 
				<Out()> Optional  ByRef pnarootvar as Numa = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer
	Dim pnameanPtr as IntPtr = IntPtr.Zero
	Dim pnamedianPtr as IntPtr = IntPtr.Zero
	Dim pnamodePtr as IntPtr = IntPtr.Zero
	Dim pnamodecountPtr as IntPtr = IntPtr.Zero
	Dim pnavarPtr as IntPtr = IntPtr.Zero
	Dim pnarootvarPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixColumnStats(pixs.Pointer, boxPtr, pnameanPtr, pnamedianPtr, pnamodePtr, pnamodecountPtr, pnavarPtr, pnarootvarPtr)
	
	if pnameanPtr = IntPtr.Zero then pnamean = Nothing else pnamean = new Numa(pnameanPtr)
	if pnamedianPtr = IntPtr.Zero then pnamedian = Nothing else pnamedian = new Numa(pnamedianPtr)
	if pnamodePtr = IntPtr.Zero then pnamode = Nothing else pnamode = new Numa(pnamodePtr)
	if pnamodecountPtr = IntPtr.Zero then pnamodecount = Nothing else pnamodecount = new Numa(pnamodecountPtr)
	if pnavarPtr = IntPtr.Zero then pnavar = Nothing else pnavar = new Numa(pnavarPtr)
	if pnarootvarPtr = IntPtr.Zero then pnarootvar = Nothing else pnarootvar = new Numa(pnarootvarPtr)
	return _Result
End Function

' pix4.c (2063, 1)
' pixGetRangeValues(pixs, factor, color, pminval, pmaxval) as Integer
' pixGetRangeValues(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) If pixs is 8 bpp grayscale, the color selection type is ignored.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRangeValues/*"/>
'''  <param name="pixs">[in] - 8 bpp grayscale, 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1 ignored if colormapped</param>
'''  <param name="color">[in] - L_SELECT_RED, L_SELECT_GREEN or L_SELECT_BLUE</param>
'''  <param name="pminval">[out][optional] - minimum value of component</param>
'''  <param name="pmaxval">[out][optional] - maximum value of component</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRangeValues(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal color as Enumerations.L_SELECT_, 
				<Out()> Optional  ByRef pminval as Integer = 0, 
				<Out()> Optional  ByRef pmaxval as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {8,16}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp grayscale, 32 bpp rgb, or colormapped")
	Dim _Result as Integer = Natives.pixGetRangeValues(pixs.Pointer,   factor,   color,   pminval,   pmaxval)
	
	return _Result
End Function

' pix4.c (2141, 1)
' pixGetExtremeValue(pixs, factor, type, prval, pgval, pbval, pgrayval) as Integer
' pixGetExtremeValue(PIX *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) If pixs is grayscale, the result is returned in [and]grayval.
'''Otherwise, if there is a colormap or d == 32,
'''each requested color component is returned.  At least
'''one color component (address) must be input.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetExtremeValue/*"/>
'''  <param name="pixs">[in] - 8 bpp grayscale, 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1 ignored if colormapped</param>
'''  <param name="type">[in] - L_SELECT_MIN or L_SELECT_MAX</param>
'''  <param name="prval">[out][optional] - red component</param>
'''  <param name="pgval">[out][optional] - green component</param>
'''  <param name="pbval">[out][optional] - blue component</param>
'''  <param name="pgrayval">[out][optional] - min or max gray value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetExtremeValue(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal type as Enumerations.L_SELECT_, 
				<Out()> Optional  ByRef prval as Integer = 0, 
				<Out()> Optional  ByRef pgval as Integer = 0, 
				<Out()> Optional  ByRef pbval as Integer = 0, 
				<Out()> Optional  ByRef pgrayval as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {8,16}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp grayscale, 32 bpp rgb, or colormapped")
	Dim _Result as Integer = Natives.pixGetExtremeValue(pixs.Pointer,   factor,   type,   prval,   pgval,   pbval,   pgrayval)
	
	return _Result
End Function

' pix4.c (2278, 1)
' pixGetMaxValueInRect(pixs, box, pmaxval, pxmax, pymax) as Integer
' pixGetMaxValueInRect(PIX *, BOX *, l_uint32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This can be used to find the maximum and its location
'''in a 2-dimensional histogram, where the x and y directions
'''represent two color components (e.g., saturation and hue).<para/>
'''
'''(2) Note that here a 32 bpp pixs has pixel values that are simply
'''numbers.  They are not 8 bpp components in a colorspace.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetMaxValueInRect/*"/>
'''  <param name="pixs">[in] - 8, 16 or 32 bpp grayscale no color space components</param>
'''  <param name="box">[in][optional] - region set box = NULL to use entire pixs</param>
'''  <param name="pmaxval">[out][optional] - max value in region</param>
'''  <param name="pxmax">[out][optional] - x location of max value</param>
'''  <param name="pymax">[out][optional] - y location of max value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetMaxValueInRect(
				ByVal pixs as Pix, 
				Optional ByVal box as Box = Nothing, 
				<Out()> Optional  ByRef pmaxval as UInteger = Nothing, 
				<Out()> Optional  ByRef pxmax as Integer = 0, 
				<Out()> Optional  ByRef pymax as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as Integer = Natives.pixGetMaxValueInRect(pixs.Pointer, boxPtr,   pmaxval,   pxmax,   pymax)
	
	return _Result
End Function

' pix4.c (2367, 1)
' pixGetBinnedComponentRange(pixs, nbins, factor, color, pminval, pmaxval, pcarray, fontsize) as Integer
' pixGetBinnedComponentRange(PIX *, l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_uint32 **, l_int32) as l_ok
'''  <summary>
''' (1) This returns the min and max average values of the
'''selected color component in the set of rank bins,
'''where the ranking is done using the specified component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBinnedComponentRange/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="nbins">[in] - number of equal population bins must be  is greater  1</param>
'''  <param name="factor">[in] - subsampling factor greater or equal 1</param>
'''  <param name="color">[in] - L_SELECT_RED, L_SELECT_GREEN or L_SELECT_BLUE</param>
'''  <param name="pminval">[out][optional] - minimum value of component</param>
'''  <param name="pmaxval">[out][optional] - maximum value of component</param>
'''  <param name="pcarray">[out][optional] - color array of bins</param>
'''  <param name="fontsize">[in][optional] - 0 for no debug for debug, valid set is {4,6,8,10,12,14,16,18,20}.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetBinnedComponentRange(
				ByVal pixs as Pix, 
				ByVal nbins as Integer, 
				ByVal factor as Integer, 
				ByVal color as Enumerations.L_SELECT_, 
				<Out()> Optional  ByRef pminval as Integer = 0, 
				<Out()> Optional  ByRef pmaxval as Integer = 0, 
				<Out()> Optional  ByRef pcarray as Byte() = nothing, 
				Optional ByVal fontsize as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")
	Dim pcarrayPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetBinnedComponentRange(pixs.Pointer,   nbins,   factor,   color,   pminval,   pmaxval,   pcarrayPtr,   fontsize)
	
	ReDim pcarray(IIf(1 > 0, 1, 1) - 1)
	If pcarrayPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pcarrayPtr, pcarray, 0, pcarray.count)
	End If
	return _Result
End Function

' pix4.c (2467, 1)
' pixGetRankColorArray(pixs, nbins, type, factor, pcarray, debugflag, fontsize) as Integer
' pixGetRankColorArray(PIX *, l_int32, l_int32, l_int32, l_uint32 **, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) The color selection flag is one of: L_SELECT_RED, L_SELECT_GREEN,
'''L_SELECT_BLUE, L_SELECT_MIN, L_SELECT_MAX, L_SELECT_AVERAGE,
'''L_SELECT_HUE, L_SELECT_SATURATION.<para/>
'''
'''(2) Then it finds the histogram of the selected color type in each
'''RGB pixel.  For each of the %nbins sets of pixels,
'''ordered by this color type value, find the average RGB color,
'''and return this as a "rank color" array.  The output array
'''has %nbins colors.<para/>
'''
'''(3) Set the subsampling factor  is greater  1 to reduce the amount of
'''computation.  Typically you want at least 10,000 pixels
'''for reasonable statistics.<para/>
'''
'''(4) The rank color as a function of rank can then be found from
'''rankint = (l_int32)(rank  (nbins - 1) + 0.5)
'''extractRGBValues(array[rankint], [and]rval, [and]gval, [and]bval)
'''where the rank is in [0.0 ... 1.0].
'''This function is meant to be simple and approximate.<para/>
'''
'''(5) Compare this with pixGetBinnedColor(), which generates equal
'''width intensity bins and finds the average color in each bin.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRankColorArray/*"/>
'''  <param name="pixs">[in] - 32 bpp or cmapped</param>
'''  <param name="nbins">[in] - number of equal population bins must be  is greater  1</param>
'''  <param name="type">[in] - color selection flag</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="pcarray">[out] - array of colors, ranked by intensity</param>
'''  <param name="debugflag">[in] - 1 to display color squares and plots of color components 2 to write them as png to file</param>
'''  <param name="fontsize">[in][optional] - 0 for no debug for debug, valid set is {4,6,8,10,12,14,16,18,20}.  Ignored if debugflag == 0.  fontsize == 6 is typical.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRankColorArray(
				ByVal pixs as Pix, 
				ByVal nbins as Integer, 
				ByVal type as Integer, 
				ByVal factor as Integer, 
				<Out()>  ByRef pcarray as Byte(), 
				ByVal debugflag as Integer, 
				Optional ByVal fontsize as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pcarrayPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetRankColorArray(pixs.Pointer,   nbins,   type,   factor,   pcarrayPtr,   debugflag,   fontsize)
	
	ReDim pcarray(IIf(1 > 0, 1, 1) - 1)
	If pcarrayPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pcarrayPtr, pcarray, 0, pcarray.count)
	End If
	return _Result
End Function

' pix4.c (2629, 1)
' pixGetBinnedColor(pixs, pixg, factor, nbins, nalut, pcarray, debugflag) as Integer
' pixGetBinnedColor(PIX *, PIX *, l_int32, l_int32, NUMA *, l_uint32 **, l_int32) as l_ok
'''  <summary>
''' (1) This takes a color image, a grayscale (intensity) version,
'''a LUT from intensity to bin number, and the number of bins.
'''It computes the average color for pixels whose intensity
'''is in each bin.  This is returned as an array of l_uint32
'''colors in our standard RGBA ordering.<para/>
'''
'''(2) This function generates equal width intensity bins and
'''finds the average color in each bin.  Compare this with
'''pixGetRankColorArray(), which rank orders the pixels
'''by the value of the selected component in each pixel,
'''sets up bins with equal population (not intensity width!),
'''and gets the average color in each bin.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBinnedColor/*"/>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="pixg">[in] - 8 bpp grayscale version of pixs</param>
'''  <param name="factor">[in] - sampling factor along pixel counting direction</param>
'''  <param name="nbins">[in] - number of intensity bins</param>
'''  <param name="nalut">[in] - LUT for mapping from intensity to bin number</param>
'''  <param name="pcarray">[out] - array of average color values in each bin</param>
'''  <param name="debugflag">[in] - 1 to display output debug plots of color components 2 to write them as png to file</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixGetBinnedColor(
				ByVal pixs as Pix, 
				ByVal pixg as Pix, 
				ByVal factor as Integer, 
				ByVal nbins as Integer, 
				ByVal nalut as Numa, 
				<Out()>  ByRef pcarray as Byte(), 
				ByVal debugflag as Integer) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (pixg) then Throw New ArgumentNullException  ("pixg cannot be Nothing")
		if IsNothing (nalut) then Throw New ArgumentNullException  ("nalut cannot be Nothing")
	Dim pcarrayPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixGetBinnedColor(pixs.Pointer, pixg.Pointer,   factor,   nbins, nalut.Pointer,   pcarrayPtr,   debugflag)
	
	ReDim pcarray(IIf(1 > 0, 1, 1) - 1)
	If pcarrayPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pcarrayPtr, pcarray, 0, pcarray.count)
	End If
	return _Result
End Function

' pix4.c (2759, 1)
' pixDisplayColorArray(carray, ncolors, side, ncols, fontsize) as Pix
' pixDisplayColorArray(l_uint32 *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' pixDisplayColorArray()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayColorArray/*"/>
'''  <param name="carray">[in] - array of colors: 0xrrggbb00</param>
'''  <param name="ncolors">[in] - size of array</param>
'''  <param name="side">[in] - size of each color square suggest 200</param>
'''  <param name="ncols">[in] - number of columns in output color matrix</param>
'''  <param name="fontsize">[in] - to label each square with text.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''   <returns>pixd color array, or NULL on error</returns>
Public Shared Function pixDisplayColorArray(
				ByVal carray as Byte(), 
				ByVal ncolors as Integer, 
				ByVal side as Integer, 
				ByVal ncols as Integer, 
				ByVal fontsize as Integer) as Pix


if IsNothing (carray) then Throw New ArgumentNullException  ("carray cannot be Nothing")
		Dim carrayPtr as IntPtr = 	Marshal.AllocHGlobal(carray.Length)
		Marshal.Copy(carray, 0, carrayPtr, carray.Length)

	Dim _Result as IntPtr = Natives.pixDisplayColorArray(  carrayPtr,   ncolors,   side,   ncols,   fontsize)
	
	Marshal.FreeHGlobal(carrayPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pix4.c (2831, 1)
' pixRankBinByStrip(pixs, direction, size, nbins, type) as Pix
' pixRankBinByStrip(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) This generates a pix where each column represents a strip of
'''the input image.  If %direction == L_SCAN_HORIZONTAL, the
'''input impage is tiled into vertical strips of width %size,
'''where %size is a compromise between getting better spatial
'''columnwise resolution (small %size) and getting better
'''columnwise statistical information (larger %size).  Likewise
'''with rows of the image if %direction == L_SCAN_VERTICAL.<para/>
'''
'''(2) For L_HORIZONTAL_SCAN, the output pix contains rank binned
'''median colors in each column that correspond to a vertical
'''strip of width %size in the input image.<para/>
'''
'''(3) The color selection flag is one of: L_SELECT_RED, L_SELECT_GREEN,
'''L_SELECT_BLUE, L_SELECT_MIN, L_SELECT_MAX, L_SELECT_AVERAGE.
'''It determines how the rank ordering is done.<para/>
'''
'''(4) Typical input values might be %size = 5, %nbins = 10.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRankBinByStrip/*"/>
'''  <param name="pixs">[in] - 32 bpp or cmapped</param>
'''  <param name="direction">[in] - L_SCAN_HORIZONTAL or L_SCAN_VERTICAL</param>
'''  <param name="size">[in] - of strips in scan direction</param>
'''  <param name="nbins">[in] - number of equal population bins must be  is greater  1</param>
'''  <param name="type">[in] - color selection flag</param>
'''   <returns>pixd result, or NULL on error</returns>
Public Shared Function pixRankBinByStrip(
				ByVal pixs as Pix, 
				ByVal direction as Enumerations.L_scan_direction, 
				ByVal size as Integer, 
				ByVal nbins as Integer, 
				ByVal type as Integer) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixRankBinByStrip(pixs.Pointer,   direction,   size,   nbins,   type)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pix4.c (2928, 1)
' pixaGetAlignedStats(pixa, type, nbins, thresh) as Pix
' pixaGetAlignedStats(PIXA *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Each pixel in the returned pix represents an average
'''(or median, or mode) over the corresponding pixels in each
'''pix in the pixa.<para/>
'''
'''(2) The %thresh parameter works with L_MODE_VAL only, and
'''sets a minimum occupancy of the mode bin.
'''If the occupancy of the mode bin is less than %thresh, the
'''mode value is returned as 0.  To always return the actual
'''mode value, set %thresh = 0.  See pixGetRowStats().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetAlignedStats/*"/>
'''  <param name="pixa">[in] - of identically sized, 8 bpp pix not cmapped</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_MEDIAN_VAL, L_MODE_VAL, L_MODE_COUNT</param>
'''  <param name="nbins">[in] - of histogram for median and mode ignored for mean</param>
'''  <param name="thresh">[in] - on histogram for mode val ignored for all other types</param>
'''   <returns>pix with pixelwise aligned stats, or NULL on error.</returns>
Public Shared Function pixaGetAlignedStats(
				ByVal pixa as Pixa, 
				ByVal type as Enumerations.L_statistical_measures, 
				ByVal nbins as Integer, 
				ByVal thresh as Integer) as Pix


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaGetAlignedStats(pixa.Pointer,   type,   nbins,   thresh)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pix4.c (2975, 1)
' pixaExtractColumnFromEachPix(pixa, col, pixd) as Integer
' pixaExtractColumnFromEachPix(PIXA *, l_int32, PIX *) as l_ok
'''  <summary>
''' pixaExtractColumnFromEachPix()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaExtractColumnFromEachPix/*"/>
'''  <param name="pixa">[in] - of identically sized, 8 bpp not cmapped</param>
'''  <param name="col">[in] - column index</param>
'''  <param name="pixd">[in] - pix into which each column is inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaExtractColumnFromEachPix(
				ByVal pixa as Pixa, 
				ByVal col as Integer, 
				ByVal pixd as Pix) as Integer


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
		if IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	Dim _Result as Integer = Natives.pixaExtractColumnFromEachPix(pixa.Pointer,   col, pixd.Pointer)
	
	return _Result
End Function

' pix4.c (3050, 1)
' pixGetRowStats(pixs, type, nbins, thresh, colvect) as Integer
' pixGetRowStats(PIX *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' (1) This computes a column vector of statistics using each
'''row of a Pix.  The result is put in %colvect.<para/>
'''
'''(2) The %thresh parameter works with L_MODE_VAL only, and
'''sets a minimum occupancy of the mode bin.
'''If the occupancy of the mode bin is less than %thresh, the
'''mode value is returned as 0.  To always return the actual
'''mode value, set %thresh = 0.<para/>
'''
'''(3) What is the meaning of this %thresh parameter?
'''For each row, the total count in the histogram is w, the
'''image width.  So %thresh, relative to w, gives a measure
'''of the ratio of the bin width to the width of the distribution.
'''The larger %thresh, the narrower the distribution must be
'''for the mode value to be returned (instead of returning 0).<para/>
'''
'''(4) If the Pix consists of a set of corresponding columns,
'''one for each Pix in a Pixa, the width of the Pix is the
'''number of Pix in the Pixa and the column vector can
'''be stored as a column in a Pix of the same size as
'''each Pix in the Pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRowStats/*"/>
'''  <param name="pixs">[in] - 8 bpp not cmapped</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_MEDIAN_VAL, L_MODE_VAL, L_MODE_COUNT</param>
'''  <param name="nbins">[in] - of histogram for median and mode ignored for mean</param>
'''  <param name="thresh">[in] - on histogram for mode ignored for mean and median</param>
'''  <param name="colvect">[in] - vector of results gathered across the rows of pixs</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRowStats(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_statistical_measures, 
				ByVal nbins as Integer, 
				ByVal thresh as Integer, 
				ByVal colvect as Single()) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (colvect) then Throw New ArgumentNullException  ("colvect cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetRowStats(pixs.Pointer,   type,   nbins,   thresh,   colvect)
	
	return _Result
End Function

' pix4.c (3172, 1)
' pixGetColumnStats(pixs, type, nbins, thresh, rowvect) as Integer
' pixGetColumnStats(PIX *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' (1) This computes a row vector of statistics using each
'''column of a Pix.  The result is put in %rowvect.<para/>
'''
'''(2) The %thresh parameter works with L_MODE_VAL only, and
'''sets a minimum occupancy of the mode bin.
'''If the occupancy of the mode bin is less than %thresh, the
'''mode value is returned as 0.  To always return the actual
'''mode value, set %thresh = 0.<para/>
'''
'''(3) What is the meaning of this %thresh parameter?
'''For each column, the total count in the histogram is h, the
'''image height.  So %thresh, relative to h, gives a measure
'''of the ratio of the bin width to the width of the distribution.
'''The larger %thresh, the narrower the distribution must be
'''for the mode value to be returned (instead of returning 0).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColumnStats/*"/>
'''  <param name="pixs">[in] - 8 bpp not cmapped</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL, L_MEDIAN_VAL, L_MODE_VAL, L_MODE_COUNT</param>
'''  <param name="nbins">[in] - of histogram for median and mode ignored for mean</param>
'''  <param name="thresh">[in] - on histogram for mode val ignored for all other types</param>
'''  <param name="rowvect">[in] - vector of results gathered down the columns of pixs</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetColumnStats(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_statistical_measures, 
				ByVal nbins as Integer, 
				ByVal thresh as Integer, 
				ByVal rowvect as Single()) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (rowvect) then Throw New ArgumentNullException  ("rowvect cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetColumnStats(pixs.Pointer,   type,   nbins,   thresh,   rowvect)
	
	return _Result
End Function

' pix4.c (3273, 1)
' pixSetPixelColumn(pix, col, colvect) as Integer
' pixSetPixelColumn(PIX *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' pixSetPixelColumn()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetPixelColumn/*"/>
'''  <param name="pix">[in] - 8 bpp not cmapped</param>
'''  <param name="col">[in] - column index</param>
'''  <param name="colvect">[in] - vector of floats</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetPixelColumn(
				ByVal pix as Pix, 
				ByVal col as Integer, 
				ByVal colvect as Single()) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (colvect) then Throw New ArgumentNullException  ("colvect cannot be Nothing")
	Dim _Result as Integer = Natives.pixSetPixelColumn(pix.Pointer,   col,   colvect)
	
	return _Result
End Function

' pix4.c (3313, 1)
' pixThresholdForFgBg(pixs, factor, thresh, pfgval, pbgval) as Integer
' pixThresholdForFgBg(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' pixThresholdForFgBg()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdForFgBg/*"/>
'''  <param name="pixs">[in] - any depth cmapped ok</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="thresh">[in] - threshold for generating foreground mask</param>
'''  <param name="pfgval">[out][optional] - average foreground value</param>
'''  <param name="pbgval">[out][optional] - average background value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixThresholdForFgBg(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal thresh as Integer, 
				<Out()> Optional  ByRef pfgval as Integer = 0, 
				<Out()> Optional  ByRef pbgval as Integer = 0) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as Integer = Natives.pixThresholdForFgBg(pixs.Pointer,   factor,   thresh,   pfgval,   pbgval)
	
	return _Result
End Function

' pix4.c (3372, 1)
' pixSplitDistributionFgBg(pixs, scorefract, factor, pthresh, pfgval, pbgval, ppixdb) as Integer
' pixSplitDistributionFgBg(PIX *, l_float32, l_int32, l_int32 *, l_int32 *, l_int32 *, PIX **) as l_ok
'''  <summary>
''' (1) See numaSplitDistribution() for details on the underlying
'''method of choosing a threshold.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSplitDistributionFgBg/*"/>
'''  <param name="pixs">[in] - any depth cmapped ok</param>
'''  <param name="scorefract">[in] - fraction of the max score, used to determine the range over which the histogram min is searched</param>
'''  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
'''  <param name="pthresh">[out][optional] - best threshold for separating</param>
'''  <param name="pfgval">[out][optional] - average foreground value</param>
'''  <param name="pbgval">[out][optional] - average background value</param>
'''  <param name="ppixdb">[out][optional] - plot of distribution and split point</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSplitDistributionFgBg(
				ByVal pixs as Pix, 
				ByVal scorefract as Single, 
				ByVal factor as Integer, 
				<Out()> Optional  ByRef pthresh as Integer = 0, 
				<Out()> Optional  ByRef pfgval as Integer = 0, 
				<Out()> Optional  ByRef pbgval as Integer = 0, 
				<Out()> Optional  ByRef ppixdb as Pix = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixSplitDistributionFgBg(pixs.Pointer,   scorefract,   factor,   pthresh,   pfgval,   pbgval, ppixdbPtr)
	
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	return _Result
End Function

End Class


