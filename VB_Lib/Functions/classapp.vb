Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\classapp.c (96, 1)
' jbCorrelation(dirin, thresh, weight, components, rootname, firstpage, npages, renderflag) as Integer
' jbCorrelation(const char *, l_float32, l_float32, l_int32, const char *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The images must be 1 bpp.  If they are not, you can convert<para/>
''' them using convertFilesTo1bpp().<para/>
''' (2) See prog/jbcorrelation for generating more output (e.g.,<para/>
''' for debugging)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/jbCorrelation/*"/>
'''  <param name="dirin">[in] - directory of input images</param>
'''  <param name="thresh">[in] - typically ~0.8</param>
'''  <param name="weight">[in] - typically ~0.6</param>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="rootname">[in] - for output files</param>
'''  <param name="firstpage">[in] - 0-based</param>
'''  <param name="npages">[in] - use 0 for all pages in dirin</param>
'''  <param name="renderflag">[in] - 1 to render from templates 0 to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbCorrelation(
				 ByVal dirin as String, 
				 ByVal thresh as Single, 
				 ByVal weight as Single, 
				 ByVal components as Enumerations.JB_S, 
				 ByVal rootname as String, 
				 ByVal firstpage as Integer, 
				 ByVal npages as Integer, 
				 ByVal renderflag as Integer) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.jbCorrelation( dirin, thresh, weight, components, rootname, firstpage, npages, renderflag)

	Return _Result
End Function

' SRC\classapp.c (178, 1)
' jbRankHaus(dirin, size, rank, components, rootname, firstpage, npages, renderflag) as Integer
' jbRankHaus(const char *, l_int32, l_float32, l_int32, const char *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See prog/jbrankhaus for generating more output (e.g.,<para/>
''' for debugging)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/jbRankHaus/*"/>
'''  <param name="dirin">[in] - directory of input images</param>
'''  <param name="size">[in] - of Sel used for dilation typ. 2</param>
'''  <param name="rank">[in] - rank value of match typ. 0.97</param>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="rootname">[in] - for output files</param>
'''  <param name="firstpage">[in] - 0-based</param>
'''  <param name="npages">[in] - use 0 for all pages in dirin</param>
'''  <param name="renderflag">[in] - 1 to render from templates 0 to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbRankHaus(
				 ByVal dirin as String, 
				 ByVal size as Integer, 
				 ByVal rank as Single, 
				 ByVal components as Enumerations.JB_S, 
				 ByVal rootname as String, 
				 ByVal firstpage as Integer, 
				 ByVal npages as Integer, 
				 ByVal renderflag as Integer) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.jbRankHaus( dirin, size, rank, components, rootname, firstpage, npages, renderflag)

	Return _Result
End Function

' SRC\classapp.c (266, 1)
' jbWordsInTextlines(dirin, reduction, maxwidth, maxheight, thresh, weight, pnatl, firstpage, npages) as JbClasser
' jbWordsInTextlines(const char *, l_int32, l_int32, l_int32, l_float32, l_float32, NUMA **, l_int32, l_int32) as JBCLASSER *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a high-level function.  See prog/jbwords for example<para/>
''' of usage.<para/>
''' (2) Typically, use input of 75 - 150 ppi for finding words.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/jbWordsInTextlines/*"/>
'''  <param name="dirin">[in] - directory of input pages</param>
'''  <param name="reduction">[in] - 1 for full res 2 for half-res</param>
'''  <param name="maxwidth">[in] - of word mask components, to be kept</param>
'''  <param name="maxheight">[in] - of word mask components, to be kept</param>
'''  <param name="thresh">[in] - on correlation 0.80 is reasonable</param>
'''  <param name="weight">[in] - for handling thick text 0.6 is reasonable</param>
'''  <param name="pnatl">[out] - numa with textline index for each component</param>
'''  <param name="firstpage">[in] - 0-based</param>
'''  <param name="npages">[in] - use 0 for all pages in dirin</param>
'''   <returns>classer for the set of pages</returns>
Public Shared Function jbWordsInTextlines(
				 ByVal dirin as String, 
				 ByVal reduction as Integer, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				 ByVal thresh as Single, 
				 ByVal weight as Single, 
				<Out()> ByRef pnatl as Numa, 
				 ByVal firstpage as Integer, 
				 ByVal npages as Integer) as JbClasser

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")

	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("1 for full res 2 for half-res")

	Dim pnatlPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnatl) Then pnatlPTR = pnatl.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbWordsInTextlines( dirin, reduction, maxwidth, maxheight, thresh, weight, pnatlPTR, firstpage, npages)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnatlPTR <> IntPtr.Zero then pnatl = new Numa(pnatlPTR)

	Return  new JbClasser(_Result)
End Function

' SRC\classapp.c (378, 1)
' pixGetWordsInTextlines(pixs, minwidth, minheight, maxwidth, maxheight, pboxad, ppixad, pnai) as Integer
' pixGetWordsInTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, PIXA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input should be at a resolution of between 75 and 150 ppi.<para/>
''' (2) The four size constraints on saved components are all<para/>
''' scaled by %reduction.<para/>
''' (3) The result are word images (and their b.b.), extracted in<para/>
''' textline order, at either full res or 2x reduction,<para/>
''' and with a numa giving the textline index for each word.<para/>
''' (4) The pixa and boxa interfaces should make this type of<para/>
''' application simple to put together.  The steps are:<para/>
''' ~ generate first estimate of word masks<para/>
''' ~ get b.b. of these, and remove the small and big ones<para/>
''' ~ extract pixa of the word images, using the b.b.<para/>
''' ~ sort actual word images in textline order (2d)<para/>
''' ~ flatten them to a pixa (1d), saving the textline index<para/>
''' for each pix<para/>
''' (5) In an actual application, it may be desirable to pre-filter<para/>
''' the input image to remove large components, to extract<para/>
''' single columns of text, and to deskew them.  For example,<para/>
''' to remove both large components and small noisy components<para/>
''' that can interfere with the statistics used to estimate<para/>
''' parameters for segmenting by words, but still retain text lines,<para/>
''' the following image preprocessing can be done:<para/>
''' Pix pixt = pixMorphSequence(pixs, "c40.1", 0)<para/>
''' Pix pixf = pixSelectBySize(pixt, 0, 60, 8,<para/>
''' L_SELECT_HEIGHT, L_SELECT_IF_LT, NULL)<para/>
''' pixAnd(pixf, pixf, pixs)  // the filtered image<para/>
''' The closing turns text lines into long blobs, but does not<para/>
''' significantly increase their height.  But if there are many<para/>
''' small connected components in a dense texture, this is likely<para/>
''' to generate tall components that will be eliminated in pixf.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetWordsInTextlines/*"/>
'''  <param name="pixs">[in] - 1 bpp, typ. 75 - 150 ppi</param>
'''  <param name="minwidth">[in] - of saved components smaller are discarded</param>
'''  <param name="minheight">[in] - of saved components smaller are discarded</param>
'''  <param name="maxwidth">[in] - of saved components larger are discarded</param>
'''  <param name="maxheight">[in] - of saved components larger are discarded</param>
'''  <param name="pboxad">[out] - word boxes sorted in textline line order</param>
'''  <param name="ppixad">[out] - word images sorted in textline line order</param>
'''  <param name="pnai">[out] - index of textline for each word</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetWordsInTextlines(
				 ByVal pixs as Pix, 
				 ByVal minwidth as Integer, 
				 ByVal minheight as Integer, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				<Out()> ByRef pboxad as Boxa, 
				<Out()> ByRef ppixad as Pixa, 
				<Out()> ByRef pnai as Numa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pboxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad) Then pboxadPTR = pboxad.Pointer
	Dim ppixadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixad) Then ppixadPTR = ppixad.Pointer
	Dim pnaiPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnai) Then pnaiPTR = pnai.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetWordsInTextlines( pixs.Pointer, minwidth, minheight, maxwidth, maxheight, pboxadPTR, ppixadPTR, pnaiPTR)
	if pboxadPTR <> IntPtr.Zero then pboxad = new Boxa(pboxadPTR)
	if ppixadPTR <> IntPtr.Zero then ppixad = new Pixa(ppixadPTR)
	if pnaiPTR <> IntPtr.Zero then pnai = new Numa(pnaiPTR)

	Return _Result
End Function

' SRC\classapp.c (453, 1)
' pixGetWordBoxesInTextlines(pixs, minwidth, minheight, maxwidth, maxheight, pboxad, pnai) as Integer
' pixGetWordBoxesInTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input should be at a resolution of between 75 and 150 ppi.<para/>
''' (2) This is a special version of pixGetWordsInTextlines(), that<para/>
''' just finds the word boxes in line order, with a numa<para/>
''' giving the textline index for each word.<para/>
''' See pixGetWordsInTextlines() for more details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetWordBoxesInTextlines/*"/>
'''  <param name="pixs">[in] - 1 bpp, typ. 300 ppi</param>
'''  <param name="minwidth">[in] - of saved components smaller are discarded</param>
'''  <param name="minheight">[in] - of saved components smaller are discarded</param>
'''  <param name="maxwidth">[in] - of saved components larger are discarded</param>
'''  <param name="maxheight">[in] - of saved components larger are discarded</param>
'''  <param name="pboxad">[out] - word boxes sorted in textline line order</param>
'''  <param name="pnai">[out][optional] - index of textline for each word</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetWordBoxesInTextlines(
				 ByVal pixs as Pix, 
				 ByVal minwidth as Integer, 
				 ByVal minheight as Integer, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				<Out()> ByRef pboxad as Boxa, 
				<Out()> Optional ByRef pnai as Numa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pboxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad) Then pboxadPTR = pboxad.Pointer
Dim pnaiPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnai) Then pnaiPTR = pnai.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetWordBoxesInTextlines( pixs.Pointer, minwidth, minheight, maxwidth, maxheight, pboxadPTR, pnaiPTR)
	if pboxadPTR <> IntPtr.Zero then pboxad = new Boxa(pboxadPTR)
	if pnaiPTR <> IntPtr.Zero then pnai = new Numa(pnaiPTR)

	Return _Result
End Function

' SRC\classapp.c (515, 1)
' boxaExtractSortedPattern(boxa, na) as Numaa
' boxaExtractSortedPattern(BOXA *, NUMA *) as NUMAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input is expected to come from pixGetWordBoxesInTextlines().<para/>
''' (2) Each numa in the output consists of an average y coordinate<para/>
''' of the first box in the textline, followed by pairs of<para/>
''' x coordinates representing the left and right edges of each<para/>
''' of the boxes in the textline.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaExtractSortedPattern/*"/>
'''  <param name="boxa">[in] - typ. of word bounding boxes, in textline order</param>
'''  <param name="na">[in] - index of textline for each box in boxa</param>
'''   <returns>naa NUMAA, where each numa represents one textline, or NULL on error</returns>
Public Shared Function boxaExtractSortedPattern(
				 ByVal boxa as Boxa, 
				 ByVal na as Numa) as Numaa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaExtractSortedPattern( boxa.Pointer, na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\classapp.c (603, 1)
' numaaCompareImagesByBoxes(naa1, naa2, nperline, nreq, maxshiftx, maxshifty, delx, dely, psame, debugflag) as Integer
' numaaCompareImagesByBoxes(NUMAA *, NUMAA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Each input numaa describes a set of sorted bounding boxes<para/>
''' (sorted by textline and, within each textline, from<para/>
''' left to right) in the images from which they are derived.<para/>
''' See boxaExtractSortedPattern() for a description of the data<para/>
''' format in each of the input numaa.<para/>
''' (2) This function does an alignment between the input<para/>
''' descriptions of bounding boxes for two images. The<para/>
''' input parameter %nperline specifies the number of boxes<para/>
''' to consider in each line when testing for a match, and<para/>
''' %nreq is the required number of lines that must be well-aligned<para/>
''' to get a match.<para/>
''' (3) Testing by alignment has 3 steps:<para/>
''' (a) Generating the location of word bounding boxes from the<para/>
''' images (prior to calling this function).<para/>
''' (b) Listing all possible pairs of aligned rows, based on<para/>
''' tolerances in horizontal and vertical positions of<para/>
''' the boxes.  Specifically, all pairs of rows are enumerated<para/>
''' whose first %nperline boxes can be brought into close<para/>
''' alignment, based on the delx parameter for boxes in the<para/>
''' line and within the overall the %maxshiftx and %maxshifty<para/>
''' constraints.<para/>
''' (c) Each pair, starting with the first, is used to search<para/>
''' for a set of %nreq - 1 other pairs that can all be aligned<para/>
''' with a difference in global translation of not more<para/>
''' than (%delx, %dely).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaaCompareImagesByBoxes/*"/>
'''  <param name="naa1">[in] - for image 1, formatted by boxaExtractSortedPattern()</param>
'''  <param name="naa2">[in] - ditto for image 2</param>
'''  <param name="nperline">[in] - number of box regions to be used in each textline</param>
'''  <param name="nreq">[in] - number of complete row matches required</param>
'''  <param name="maxshiftx">[in] - max allowed x shift between two patterns, in pixels</param>
'''  <param name="maxshifty">[in] - max allowed y shift between two patterns, in pixels</param>
'''  <param name="delx">[in] - max allowed difference in x data, after alignment</param>
'''  <param name="dely">[in] - max allowed difference in y data, after alignment</param>
'''  <param name="psame">[out] - 1 if %nreq row matches are found 0 otherwise</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaCompareImagesByBoxes(
				 ByVal naa1 as Numaa, 
				 ByVal naa2 as Numaa, 
				 ByVal nperline as Integer, 
				 ByVal nreq as Integer, 
				 ByVal maxshiftx as Integer, 
				 ByVal maxshifty as Integer, 
				 ByVal delx as Integer, 
				 ByVal dely as Integer, 
				<Out()> ByRef psame as Integer, 
				 ByVal debugflag as Integer) as Integer

	If IsNothing (naa1) then Throw New ArgumentNullException  ("naa1 cannot be Nothing")
	If IsNothing (naa2) then Throw New ArgumentNullException  ("naa2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaaCompareImagesByBoxes( naa1.Pointer, naa2.Pointer, nperline, nreq, maxshiftx, maxshifty, delx, dely, psame, debugflag)

	Return _Result
End Function

End Class
