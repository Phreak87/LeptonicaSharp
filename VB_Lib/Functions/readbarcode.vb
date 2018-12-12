Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' readbarcode.c (134, 1)
' pixProcessBarcodes(pixs, format, method, psaw, debugflag) as Sarray
' pixProcessBarcodes(PIX *, l_int32, l_int32, SARRAY **, l_int32) as SARRAY *
'''  <summary>
''' pixProcessBarcodes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixProcessBarcodes/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
'''  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
'''  <param name="psaw">[out][optional] - sarray of bar widths</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>sarray text of barcodes, or NULL if none found or on error</returns>
Public Shared Function pixProcessBarcodes(
				ByVal pixs as Pix, 
				ByVal format as Enumerations.IFF, 
				ByVal method as Enumerations.L_USE_WIS, 
				<Out()>  ByRef psaw as Sarray, 
				ByVal debugflag as Integer) as Sarray


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim psawPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixProcessBarcodes(pixs.Pointer,   format,   method, psawPtr,   debugflag)
	
	if psawPtr = IntPtr.Zero then psaw = Nothing else psaw = new Sarray(psawPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Sarray(_Result)
End Function

' readbarcode.c (182, 1)
' pixExtractBarcodes(pixs, debugflag) as Pixa
' pixExtractBarcodes(PIX *, l_int32) as PIXA *
'''  <summary>
''' pixExtractBarcodes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodes/*"/>
'''  <param name="pixs">[in] - 8 bpp, no colormap</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>pixa deskewed and cropped barcodes, or NULL if none found or on error</returns>
Public Shared Function pixExtractBarcodes(
				ByVal pixs as Pix, 
				ByVal debugflag as Integer) as Pixa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixExtractBarcodes(pixs.Pointer,   debugflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' readbarcode.c (254, 1)
' pixReadBarcodes(pixa, format, method, psaw, debugflag) as Sarray
' pixReadBarcodes(PIXA *, l_int32, l_int32, SARRAY **, l_int32) as SARRAY *
'''  <summary>
''' pixReadBarcodes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadBarcodes/*"/>
'''  <param name="pixa">[in] - of 8 bpp deskewed and cropped barcodes</param>
'''  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
'''  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
'''  <param name="psaw">[out][optional] - sarray of bar widths</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>sa sarray of widths, one string for each barcode found, or NULL on error</returns>
Public Shared Function pixReadBarcodes(
				ByVal pixa as Pixa, 
				ByVal format as Enumerations.IFF, 
				ByVal method as Enumerations.L_USE_WIS, 
				<Out()>  ByRef psaw as Sarray, 
				ByVal debugflag as Integer) as Sarray


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim psawPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixReadBarcodes(pixa.Pointer,   format,   method, psawPtr,   debugflag)
	
	if psawPtr = IntPtr.Zero then psaw = Nothing else psaw = new Sarray(psawPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Sarray(_Result)
End Function

' readbarcode.c (335, 1)
' pixReadBarcodeWidths(pixs, method, debugflag) as Numa
' pixReadBarcodeWidths(PIX *, l_int32, l_int32) as NUMA *
'''  <summary>
''' pixReadBarcodeWidths()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadBarcodeWidths/*"/>
'''  <param name="pixs">[in] - of 8 bpp deskewed and cropped barcode</param>
'''  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>na numa of widths (each in set {1,2,3,4}, or NULL on error</returns>
Public Shared Function pixReadBarcodeWidths(
				ByVal pixs as Pix, 
				ByVal method as Enumerations.L_USE_WIS, 
				ByVal debugflag as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadBarcodeWidths(pixs.Pointer,   method,   debugflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' readbarcode.c (384, 1)
' pixLocateBarcodes(pixs, thresh, ppixb, ppixm) as Boxa
' pixLocateBarcodes(PIX *, l_int32, PIX **, PIX **) as BOXA *
'''  <summary>
''' pixLocateBarcodes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLocateBarcodes/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="thresh">[in] - for binarization of edge filter output typ. 20</param>
'''  <param name="ppixb">[out][optional] - binarized edge filtered input image</param>
'''  <param name="ppixm">[out][optional] - mask over barcodes</param>
'''   <returns>boxa location of barcodes, or NULL if none found or on error</returns>
Public Shared Function pixLocateBarcodes(
				ByVal pixs as Pix, 
				ByVal thresh as Integer, 
				<Out()> Optional  ByRef ppixb as Pix = Nothing, 
				<Out()> Optional  ByRef ppixm as Pix = Nothing) as Boxa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixbPtr as IntPtr = IntPtr.Zero
	Dim ppixmPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixLocateBarcodes(pixs.Pointer,   thresh, ppixbPtr, ppixmPtr)
	
	if ppixbPtr = IntPtr.Zero then ppixb = Nothing else ppixb = new Pix(ppixbPtr)
	if ppixmPtr = IntPtr.Zero then ppixm = Nothing else ppixm = new Pix(ppixmPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' readbarcode.c (500, 1)
' pixDeskewBarcode(pixs, pixb, box, margin, threshold, pangle, pconf) as Pix
' pixDeskewBarcode(PIX *, PIX *, BOX *, l_int32, l_int32, l_float32 *, l_float32 *) as PIX *
'''  <summary>
''' (1) The (optional) angle returned is the angle in degrees (cw positive)
'''necessary to rotate the image so that it is deskewed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDeskewBarcode/*"/>
'''  <param name="pixs">[in] - input image 8 bpp</param>
'''  <param name="pixb">[in] - binarized edge-filtered input image</param>
'''  <param name="box">[in] - identified region containing barcode</param>
'''  <param name="margin">[in] - of extra pixels around box to extract</param>
'''  <param name="threshold">[in] - for binarization ~20</param>
'''  <param name="pangle">[out][optional] - in degrees, clockwise is positive</param>
'''  <param name="pconf">[out][optional] - confidence</param>
'''   <returns>pixd deskewed barcode, or NULL on error</returns>
Public Shared Function pixDeskewBarcode(
				ByVal pixs as Pix, 
				ByVal pixb as Pix, 
				ByVal box as Box, 
				ByVal margin as Integer, 
				ByVal threshold as Integer, 
				<Out()> Optional  ByRef pangle as Single = 0f, 
				<Out()> Optional  ByRef pconf as Single = 0f) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixDeskewBarcode(pixs.Pointer, pixb.Pointer, box.Pointer,   margin,   threshold,   pangle,   pconf)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' readbarcode.c (626, 1)
' pixExtractBarcodeWidths1(pixs, thresh, binfract, pnaehist, pnaohist, debugflag) as Numa
' pixExtractBarcodeWidths1(PIX *, l_float32, l_float32, NUMA **, NUMA **, l_int32) as NUMA *
'''  <summary>
''' (1) The widths are alternating black/white, starting with black
'''and ending with black.<para/>
'''
'''(2) This method uses the widths of the bars directly, in terms
'''of the (float) number of pixels between transitions.
'''The histograms of these widths for black and white bars is
'''generated and interpreted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeWidths1/*"/>
'''  <param name="pixs">[in] - input image 8 bpp</param>
'''  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
'''  <param name="binfract">[in] - histo binsize as a fraction of minsize e.g., 0.25</param>
'''  <param name="pnaehist">[out][optional] - histogram of black widths NULL ok</param>
'''  <param name="pnaohist">[out][optional] - histogram of white widths NULL ok</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>nad numa of barcode widths in encoded integer units, or NULL on error</returns>
Public Shared Function pixExtractBarcodeWidths1(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal binfract as Single, 
				<Out()>  ByRef pnaehist as Numa, 
				<Out()>  ByRef pnaohist as Numa, 
				ByVal debugflag as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnaehistPtr as IntPtr = IntPtr.Zero
	Dim pnaohistPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixExtractBarcodeWidths1(pixs.Pointer,   thresh,   binfract, pnaehistPtr, pnaohistPtr,   debugflag)
	
	if pnaehistPtr = IntPtr.Zero then pnaehist = Nothing else pnaehist = new Numa(pnaehistPtr)
	if pnaohistPtr = IntPtr.Zero then pnaohist = Nothing else pnaohist = new Numa(pnaohistPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' readbarcode.c (679, 1)
' pixExtractBarcodeWidths2(pixs, thresh, pwidth, pnac, debugflag) as Numa
' pixExtractBarcodeWidths2(PIX *, l_float32, l_float32 *, NUMA **, l_int32) as NUMA *
'''  <summary>
''' (1) The widths are alternating black/white, starting with black
'''and ending with black.<para/>
'''
'''(2) The optional best decoding window width is the width of the window
'''that is used to make a decision about whether a transition occurs.
'''It is approximately the average width in pixels of the narrowest
'''white and black bars (i.e., those corresponding to unit width).<para/>
'''
'''(3) The optional return signal %nac is a sequence of 0s, 1s,
'''and perhaps a few 2s, giving the number of crossings in each window.
'''On the occasion where there is a '2', it is interpreted as
'''as ending two runs: the previous one and another one that has length 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeWidths2/*"/>
'''  <param name="pixs">[in] - input image 8 bpp</param>
'''  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
'''  <param name="pwidth">[out][optional] - best decoding window width, in pixels</param>
'''  <param name="pnac">[out][optional] - number of transitions in each window</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>nad numa of barcode widths in encoded integer units, or NULL on error</returns>
Public Shared Function pixExtractBarcodeWidths2(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				<Out()>  ByRef pwidth as Single, 
				<Out()>  ByRef pnac as Numa, 
				ByVal debugflag as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnacPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixExtractBarcodeWidths2(pixs.Pointer,   thresh,   pwidth, pnacPtr,   debugflag)
	
	if pnacPtr = IntPtr.Zero then pnac = Nothing else pnac = new Numa(pnacPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' readbarcode.c (713, 1)
' pixExtractBarcodeCrossings(pixs, thresh, debugflag) as Numa
' pixExtractBarcodeCrossings(PIX *, l_float32, l_int32) as NUMA *
'''  <summary>
''' pixExtractBarcodeCrossings()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeCrossings/*"/>
'''  <param name="pixs">[in] - input image 8 bpp</param>
'''  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>numa of crossings, in pixel units, or NULL on error</returns>
Public Shared Function pixExtractBarcodeCrossings(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal debugflag as Integer) as Numa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixExtractBarcodeCrossings(pixs.Pointer,   thresh,   debugflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' readbarcode.c (837, 1)
' numaQuantizeCrossingsByWidth(nas, binfract, pnaehist, pnaohist, debugflag) as Numa
' numaQuantizeCrossingsByWidth(NUMA *, l_float32, NUMA **, NUMA **, l_int32) as NUMA *
'''  <summary>
''' (1) This first computes the histogram of black and white bar widths,
'''binned in appropriate units.  There should be well-defined
'''peaks, each corresponding to a specific width.  The sequence
'''of barcode widths (namely, the integers from the set {1,2,3,4})
'''is returned.<para/>
'''
'''(2) The optional returned histograms are binned in width units
'''that are inversely proportional to %binfract.  For example,
'''if %binfract = 0.25, there are 4.0 bins in the distance of
'''the width of the narrowest bar.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaQuantizeCrossingsByWidth/*"/>
'''  <param name="nas">[in] - numa of crossing locations, in pixel units</param>
'''  <param name="binfract">[in] - histo binsize as a fraction of minsize e.g., 0.25</param>
'''  <param name="pnaehist">[out][optional] - histo of even (black) bar widths</param>
'''  <param name="pnaohist">[out][optional] - histo of odd (white) bar widths</param>
'''  <param name="debugflag">[in] - 1 to generate plots of histograms of bar widths</param>
'''   <returns>nad sequence of widths, in unit sizes, or NULL on error</returns>
Public Shared Function numaQuantizeCrossingsByWidth(
				ByVal nas as Numa, 
				ByVal binfract as Single, 
				<Out()>  ByRef pnaehist as Numa, 
				<Out()>  ByRef pnaohist as Numa, 
				ByVal debugflag as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim pnaehistPtr as IntPtr = IntPtr.Zero
	Dim pnaohistPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.numaQuantizeCrossingsByWidth(nas.Pointer,   binfract, pnaehistPtr, pnaohistPtr,   debugflag)
	
	if pnaehistPtr = IntPtr.Zero then pnaehist = Nothing else pnaehist = new Numa(pnaehistPtr)
	if pnaohistPtr = IntPtr.Zero then pnaohist = Nothing else pnaohist = new Numa(pnaohistPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' readbarcode.c (1267, 1)
' numaQuantizeCrossingsByWindow(nas, ratio, pwidth, pfirstloc, pnac, debugflag) as Numa
' numaQuantizeCrossingsByWindow(NUMA *, l_float32, l_float32 *, l_float32 *, NUMA **, l_int32) as NUMA *
'''  <summary>
''' (1) The minimum size of the window is set by the minimum
'''distance between zero crossings.<para/>
'''
'''(2) The optional return signal %nac is a sequence of 0s, 1s,
'''and perhaps a few 2s, giving the number of crossings in each window.
'''On the occasion where there is a '2', it is interpreted as
'''ending two runs: the previous one and another one that has length 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaQuantizeCrossingsByWindow/*"/>
'''  <param name="nas">[in] - numa of crossing locations</param>
'''  <param name="ratio">[in] - of max window size over min window size in search typ. 2.0</param>
'''  <param name="pwidth">[out][optional] - best window width</param>
'''  <param name="pfirstloc">[out][optional] - center of window for first xing</param>
'''  <param name="pnac">[out][optional] - array of window crossings (0, 1, 2)</param>
'''  <param name="debugflag">[in] - 1 to generate various plots of intermediate results</param>
'''   <returns>nad sequence of widths, in unit sizes, or NULL on error</returns>
Public Shared Function numaQuantizeCrossingsByWindow(
				ByVal nas as Numa, 
				ByVal ratio as Single, 
				<Out()>  ByRef pwidth as Single, 
				<Out()>  ByRef pfirstloc as Single, 
				<Out()>  ByRef pnac as Numa, 
				ByVal debugflag as Integer) as Numa


if IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	Dim pnacPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.numaQuantizeCrossingsByWindow(nas.Pointer,   ratio,   pwidth,   pfirstloc, pnacPtr,   debugflag)
	
	if pnacPtr = IntPtr.Zero then pnac = Nothing else pnac = new Numa(pnacPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

End Class


