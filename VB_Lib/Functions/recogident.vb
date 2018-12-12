Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' recogident.c (158, 1)
' recogIdentifyMultiple(recog, pixs, minh, skipsplit, pboxa, ppixa, ppixdb, debugsplit) as Integer
' recogIdentifyMultiple(L_RECOG *, PIX *, l_int32, l_int32, BOXA **, PIXA **, PIX **, l_int32) as l_ok
'''  <summary>
''' (1) This filters the input pixa and calls recogIdentifyPixa()<para/>
'''
'''(2) Splitting is relatively slow, because it tries to match all
'''character templates to all locations.  This step can be skipped.<para/>
'''
'''(3) An attempt is made to order the (optionally) returned images
'''and boxes in 2-dimensional sorted order.  These can then
'''be used to aggregate identified characters into numbers or words.
'''One typically wants the pixa, which contains a boxa of the
'''extracted subimages.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyMultiple/*"/>
'''  <param name="recog">[in] - with training finished</param>
'''  <param name="pixs">[in] - containing typically a small number of characters</param>
'''  <param name="minh">[in] - remove shorter components use 0 for default</param>
'''  <param name="skipsplit">[in] - 1 to skip the splitting step</param>
'''  <param name="pboxa">[out][optional] - locations of identified components</param>
'''  <param name="ppixa">[out][optional] - images of identified components</param>
'''  <param name="ppixdb">[out][optional] - debug pix: inputs and best fits</param>
'''  <param name="debugsplit">[in] - 1 returns pix split debugging images</param>
'''   <returns>0 if OK 1 if nothing is found 2 for other errors.</returns>
Public Shared Function recogIdentifyMultiple(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				ByVal minh as Integer, 
				ByVal skipsplit as Integer, 
				<Out()>  ByRef pboxa as Boxa, 
				<Out()>  ByRef ppixa as Pixa, 
				<Out()>  ByRef ppixdb as Pix, 
				ByVal debugsplit as Integer) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pboxaPtr as IntPtr = IntPtr.Zero
	Dim ppixaPtr as IntPtr = IntPtr.Zero
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogIdentifyMultiple(recog.Pointer, pixs.Pointer,   minh,   skipsplit, pboxaPtr, ppixaPtr, ppixdbPtr,   debugsplit)
	
	if pboxaPtr = IntPtr.Zero then pboxa = Nothing else pboxa = new Boxa(pboxaPtr)
	if ppixaPtr = IntPtr.Zero then ppixa = Nothing else ppixa = new Pixa(ppixaPtr)
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	return _Result
End Function

' recogident.c (246, 1)
' recogSplitIntoCharacters(recog, pixs, minh, skipsplit, pboxa, ppixa, debug) as Integer
' recogSplitIntoCharacters(L_RECOG *, PIX *, l_int32, l_int32, BOXA **, PIXA **, l_int32) as l_ok
'''  <summary>
''' (1) This can be given an image that has an arbitrary number
'''of text characters.  It optionally splits connected
'''components based on document image decoding in recogDecode().
'''The returned pixa includes the boxes from which the
'''(possibly split) components are extracted.<para/>
'''
'''(2) After noise filtering, the resulting components are put in
'''row-major (2D) order, and the smaller of overlapping
'''components are removed if they satisfy conditions of
'''relative size and fractional overlap.<para/>
'''
'''(3) Note that the splitting function uses unscaled templates
'''and does not bother returning the class results and scores.
'''These are more accurately found later using the scaled templates.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSplitIntoCharacters/*"/>
'''  <param name="recog">[in] - </param>
'''  <param name="pixs">[in] - 1 bpp, contains only mostly deskewed text</param>
'''  <param name="minh">[in] - remove shorter components use 0 for default</param>
'''  <param name="skipsplit">[in] - 1 to skip the splitting step</param>
'''  <param name="pboxa">[out] - character bounding boxes</param>
'''  <param name="ppixa">[out] - character images</param>
'''  <param name="debug">[in] - 1 for results written to pixadb_split</param>
'''   <returns>0 if OK, 1 on error or if no components are returned</returns>
Public Shared Function recogSplitIntoCharacters(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				ByVal minh as Integer, 
				ByVal skipsplit as Integer, 
				<Out()>  ByRef pboxa as Boxa, 
				<Out()>  ByRef ppixa as Pixa, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pboxaPtr as IntPtr = IntPtr.Zero
	Dim ppixaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogSplitIntoCharacters(recog.Pointer, pixs.Pointer,   minh,   skipsplit, pboxaPtr, ppixaPtr,   debug)
	
	if pboxaPtr = IntPtr.Zero then pboxa = Nothing else pboxa = new Boxa(pboxaPtr)
	if ppixaPtr = IntPtr.Zero then ppixa = Nothing else ppixa = new Pixa(ppixaPtr)
	return _Result
End Function

' recogident.c (401, 1)
' recogCorrelationBestRow(recog, pixs, pboxa, pnascore, pnaindex, psachar, debug) as Integer
' recogCorrelationBestRow(L_RECOG *, PIX *, BOXA **, NUMA **, NUMA **, SARRAY **, l_int32) as l_ok
'''  <summary>
''' (1) Supervises character matching for (in general) a c.c with
'''multiple touching characters.  Finds the best match greedily.
'''Rejects small parts that are left over after splitting.<para/>
'''
'''(2) Matching is to the average, and without character scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCorrelationBestRow/*"/>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="pixs">[in] - typically of multiple touching characters, 1 bpp</param>
'''  <param name="pboxa">[out] - bounding boxs of best fit character</param>
'''  <param name="pnascore">[out][optional] - correlation scores</param>
'''  <param name="pnaindex">[out][optional] - indices of classes</param>
'''  <param name="psachar">[out][optional] - array of character strings</param>
'''  <param name="debug">[in] - 1 for results written to pixadb_split</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogCorrelationBestRow(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				<Out()>  ByRef pboxa as Boxa, 
				<Out()> Optional  ByRef pnascore as Numa = Nothing, 
				<Out()> Optional  ByRef pnaindex as Numa = Nothing, 
				<Out()> Optional  ByRef psachar as Sarray = Nothing, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pboxaPtr as IntPtr = IntPtr.Zero
	Dim pnascorePtr as IntPtr = IntPtr.Zero
	Dim pnaindexPtr as IntPtr = IntPtr.Zero
	Dim psacharPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogCorrelationBestRow(recog.Pointer, pixs.Pointer, pboxaPtr, pnascorePtr, pnaindexPtr, psacharPtr,   debug)
	
	if pboxaPtr = IntPtr.Zero then pboxa = Nothing else pboxa = new Boxa(pboxaPtr)
	if pnascorePtr = IntPtr.Zero then pnascore = Nothing else pnascore = new Numa(pnascorePtr)
	if pnaindexPtr = IntPtr.Zero then pnaindex = Nothing else pnaindex = new Numa(pnaindexPtr)
	if psacharPtr = IntPtr.Zero then psachar = Nothing else psachar = new Sarray(psacharPtr)
	return _Result
End Function

' recogident.c (583, 1)
' recogCorrelationBestChar(recog, pixs, pbox, pscore, pindex, pcharstr, ppixdb) as Integer
' recogCorrelationBestChar(L_RECOG *, PIX *, BOX **, l_float32 *, l_int32 *, char **, PIX **) as l_ok
'''  <summary>
''' (1) Basic matching character splitter.  Finds the best match among
'''all templates to some region of the image.  This can result
'''in splitting the image into two parts.  This is "image decoding"
'''without dynamic programming, because we don't use a setwidth
'''and compute the best matching score for the entire image.<para/>
'''
'''(2) Matching is to the average templates, without character scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCorrelationBestChar/*"/>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="pixs">[in] - can be of multiple touching characters, 1 bpp</param>
'''  <param name="pbox">[out] - bounding box of best fit character</param>
'''  <param name="pscore">[out] - correlation score</param>
'''  <param name="pindex">[out][optional] - index of class</param>
'''  <param name="pcharstr">[out][optional] - character string of class</param>
'''  <param name="ppixdb">[out][optional] - debug pix showing input and best fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogCorrelationBestChar(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				<Out()>  ByRef pbox as Box, 
				<Out()>  ByRef pscore as Single, 
				<Out()> Optional  ByRef pindex as Integer = 0, 
				<Out()> Optional  ByRef pcharstr as String() = nothing, 
				<Out()> Optional  ByRef ppixdb as Pix = Nothing) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pboxPtr as IntPtr = IntPtr.Zero
	Dim pcharstrPtr as IntPtr = IntPtr.Zero
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogCorrelationBestChar(recog.Pointer, pixs.Pointer, pboxPtr,   pscore,   pindex,   pcharstrPtr, ppixdbPtr)
	
	if pboxPtr = IntPtr.Zero then pbox = Nothing else pbox = new Box(pboxPtr)
	if IsNothing(pcharstr) then pcharstr = nothing else pcharstr = pcharstr
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	return _Result
End Function

' recogident.c (878, 1)
' recogIdentifyPixa(recog, pixa, ppixdb) as Integer
' recogIdentifyPixa(L_RECOG *, PIXA *, PIX **) as l_ok
'''  <summary>
''' (1) This should be called by recogIdentifyMuliple(), which
'''binarizes and splits characters before sending %pixa here.<para/>
'''
'''(2) This calls recogIdentifyPix(), which does the same operation
'''on each pix in %pixa, and optionally returns the arrays
'''of results (scores, class index and character string)
'''for the best correlation match.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyPixa/*"/>
'''  <param name="recog">[in] - </param>
'''  <param name="pixa">[in] - of 1 bpp images to match</param>
'''  <param name="ppixdb">[out][optional] - pix showing inputs and best fits</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogIdentifyPixa(
				ByVal recog as L_Recog, 
				ByVal pixa as Pixa, 
				<Out()> Optional  ByRef ppixdb as Pix = Nothing) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogIdentifyPixa(recog.Pointer, pixa.Pointer, ppixdbPtr)
	
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	return _Result
End Function

' recogident.c (971, 1)
' recogIdentifyPix(recog, pixs, ppixdb) as Integer
' recogIdentifyPix(L_RECOG *, PIX *, PIX **) as l_ok
'''  <summary>
''' (1) Basic recognition function for a single character.<para/>
'''
'''(2) If templ_use == L_USE_ALL_TEMPLATES, which is the default
'''situation, matching is attempted to every bitmap in the recog,
'''and the identify of the best match is returned.<para/>
'''
'''(3) For finding outliers, templ_use == L_USE_AVERAGE_TEMPLATES, and
'''matching is only attemplted to the averaged bitmaps.  For this
'''case, the index of the bestsample is meaningless (0 is returned
'''if requested).<para/>
'''
'''(4) The score is related to the confidence (probability of correct
'''identification), in that a higher score is correlated with
'''a higher probability.  However, the actual relation between
'''the correlation (score) and the probability is not known
'''we call this a "score" because "confidence" can be misinterpreted
'''as an actual probability.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyPix/*"/>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="pixs">[in] - of a single character, 1 bpp</param>
'''  <param name="ppixdb">[out][optional] - debug pix showing input and best fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogIdentifyPix(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				<Out()> Optional  ByRef ppixdb as Pix = Nothing) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogIdentifyPix(recog.Pointer, pixs.Pointer, ppixdbPtr)
	
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	return _Result
End Function

' recogident.c (1120, 1)
' recogSkipIdentify(recog) as Integer
' recogSkipIdentify(L_RECOG *) as l_ok
'''  <summary>
''' (1) This just writes a "dummy" result with 0 score and empty
'''string id into the rch.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSkipIdentify/*"/>
'''  <param name="recog">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogSkipIdentify(
				ByVal recog as L_Recog) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	Dim _Result as Integer = Natives.recogSkipIdentify(recog.Pointer)
	
	return _Result
End Function

' recogident.c (1168, 1)
' rchaDestroy(prcha) as Object
' rchaDestroy(L_RCHA **) as void
'''  <summary>
''' rchaDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchaDestroy/*"/>
'''  <param name="prcha">[in,out] - to be nulled</param>
Public Shared Sub rchaDestroy(
				ByRef prcha as L_Rcha)


	Dim prchaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(prcha) Then prchaPtr = prcha.Pointer

	Natives.rchaDestroy( prchaPtr)
	
	if prchaPtr = IntPtr.Zero then prcha = Nothing else prcha = new L_Rcha(prchaPtr)
End Sub

' recogident.c (1242, 1)
' rchDestroy(prch) as Object
' rchDestroy(L_RCH **) as void
'''  <summary>
''' rchDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchDestroy/*"/>
'''  <param name="prch">[in,out] - to be nulled</param>
Public Shared Sub rchDestroy(
				ByRef prch as L_Rch)


	Dim prchPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(prch) Then prchPtr = prch.Pointer

	Natives.rchDestroy( prchPtr)
	
	if prchPtr = IntPtr.Zero then prch = Nothing else prch = new L_Rch(prchPtr)
End Sub

' recogident.c (1281, 1)
' rchaExtract(rcha, pnaindex, pnascore, psatext, pnasample, pnaxloc, pnayloc, pnawidth) as Integer
' rchaExtract(L_RCHA *, NUMA **, NUMA **, SARRAY **, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) This returns clones of the number and string arrays.  They must
'''be destroyed by the caller.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchaExtract/*"/>
'''  <param name="rcha">[in] - </param>
'''  <param name="pnaindex">[out][optional] - indices of best templates</param>
'''  <param name="pnascore">[out][optional] - correl scores of best templates</param>
'''  <param name="psatext">[out][optional] - character strings of best templates</param>
'''  <param name="pnasample">[out][optional] - indices of best samples</param>
'''  <param name="pnaxloc">[out][optional] - x-locations of templates</param>
'''  <param name="pnayloc">[out][optional] - y-locations of templates</param>
'''  <param name="pnawidth">[out][optional] - widths of best templates</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function rchaExtract(
				ByVal rcha as L_Rcha, 
				<Out()> Optional  ByRef pnaindex as Numa = Nothing, 
				<Out()> Optional  ByRef pnascore as Numa = Nothing, 
				<Out()> Optional  ByRef psatext as Sarray = Nothing, 
				<Out()> Optional  ByRef pnasample as Numa = Nothing, 
				<Out()> Optional  ByRef pnaxloc as Numa = Nothing, 
				<Out()> Optional  ByRef pnayloc as Numa = Nothing, 
				<Out()> Optional  ByRef pnawidth as Numa = Nothing) as Integer


if IsNothing (rcha) then Throw New ArgumentNullException  ("rcha cannot be Nothing")
	Dim pnaindexPtr as IntPtr = IntPtr.Zero
	Dim pnascorePtr as IntPtr = IntPtr.Zero
	Dim psatextPtr as IntPtr = IntPtr.Zero
	Dim pnasamplePtr as IntPtr = IntPtr.Zero
	Dim pnaxlocPtr as IntPtr = IntPtr.Zero
	Dim pnaylocPtr as IntPtr = IntPtr.Zero
	Dim pnawidthPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.rchaExtract(rcha.Pointer, pnaindexPtr, pnascorePtr, psatextPtr, pnasamplePtr, pnaxlocPtr, pnaylocPtr, pnawidthPtr)
	
	if pnaindexPtr = IntPtr.Zero then pnaindex = Nothing else pnaindex = new Numa(pnaindexPtr)
	if pnascorePtr = IntPtr.Zero then pnascore = Nothing else pnascore = new Numa(pnascorePtr)
	if psatextPtr = IntPtr.Zero then psatext = Nothing else psatext = new Sarray(psatextPtr)
	if pnasamplePtr = IntPtr.Zero then pnasample = Nothing else pnasample = new Numa(pnasamplePtr)
	if pnaxlocPtr = IntPtr.Zero then pnaxloc = Nothing else pnaxloc = new Numa(pnaxlocPtr)
	if pnaylocPtr = IntPtr.Zero then pnayloc = Nothing else pnayloc = new Numa(pnaylocPtr)
	if pnawidthPtr = IntPtr.Zero then pnawidth = Nothing else pnawidth = new Numa(pnawidthPtr)
	return _Result
End Function

' recogident.c (1327, 1)
' rchExtract(rch, pindex, pscore, ptext, psample, pxloc, pyloc, pwidth) as Integer
' rchExtract(L_RCH *, l_int32 *, l_float32 *, char **, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' rchExtract()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchExtract/*"/>
'''  <param name="rch">[in] - </param>
'''  <param name="pindex">[out][optional] - index of best template</param>
'''  <param name="pscore">[out][optional] - correlation score of best template</param>
'''  <param name="ptext">[out][optional] - character string of best template</param>
'''  <param name="psample">[out][optional] - index of best sample</param>
'''  <param name="pxloc">[out][optional] - x-location of template</param>
'''  <param name="pyloc">[out][optional] - y-location of template</param>
'''  <param name="pwidth">[out][optional] - width of best template</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function rchExtract(
				ByVal rch as L_Rch, 
				<Out()> Optional  ByRef pindex as Integer = 0, 
				<Out()> Optional  ByRef pscore as Single = 0f, 
				<Out()> Optional  ByRef ptext as String() = nothing, 
				<Out()> Optional  ByRef psample as Integer = 0, 
				<Out()> Optional  ByRef pxloc as Integer = 0, 
				<Out()> Optional  ByRef pyloc as Integer = 0, 
				<Out()> Optional  ByRef pwidth as Integer = 0) as Integer


if IsNothing (rch) then Throw New ArgumentNullException  ("rch cannot be Nothing")
	Dim ptextPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.rchExtract(rch.Pointer,   pindex,   pscore,   ptextPtr,   psample,   pxloc,   pyloc,   pwidth)
	
	if IsNothing(ptext) then ptext = nothing else ptext = ptext
	return _Result
End Function

' recogident.c (1415, 1)
' recogProcessToIdentify(recog, pixs, pad) as Pix
' recogProcessToIdentify(L_RECOG *, PIX *, l_int32) as PIX *
'''  <summary>
''' (1) This is a lightweight operation to insure that the input
'''image is 1 bpp, properly cropped, and padded on each side.
'''If bpp  is greater  1, the image is thresholded.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogProcessToIdentify/*"/>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="pixs">[in] - typ. single character, possibly d  is greater  1 and uncropped</param>
'''  <param name="pad">[in] - extra pixels added to left and right sides</param>
'''   <returns>pixd 1 bpp, clipped to foreground, or NULL if there are no fg pixels or on error.</returns>
Public Shared Function recogProcessToIdentify(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix, 
				ByVal pad as Integer) as Pix


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.recogProcessToIdentify(recog.Pointer, pixs.Pointer,   pad)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' recogident.c (1628, 1)
' recogExtractNumbers(recog, boxas, scorethresh, spacethresh, pbaa, pnaa) as Sarray
' recogExtractNumbers(L_RECOG *, BOXA *, l_float32, l_int32, BOXAA **, NUMAA **) as SARRAY *
'''  <summary>
''' (1) This extracts digit data after recogaIdentifyMultiple() or
'''lower-level identification has taken place.<para/>
'''
'''(2) Each string in the returned sa contains a sequence of ascii
'''digits in a number.<para/>
'''
'''(3) The horizontal distance between boxes (limited by %spacethresh)
'''is the negative of the horizontal overlap.<para/>
'''
'''(4) Components with a score less than %scorethresh, which may
'''be hyphens or other small characters, will signal the
'''end of the current sequence of digits in the number.  A typical
'''value for %scorethresh is 0.60.<para/>
'''
'''(5) We allow two digits to be combined if these conditions apply:
'''(a) the first is to the left of the second
'''(b) the second has a horizontal separation less than %spacethresh
'''(c) the vertical overlap greater or equal 0 (vertical separation  is smaller 0)
'''(d) both have a score that exceeds %scorethresh<para/>
'''
'''(6) Each numa in the optionally returned naa contains the digit
'''scores of a number.  Each boxa in the optionally returned baa
'''contains the bounding boxes of the digits in the number.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogExtractNumbers/*"/>
'''  <param name="recog">[in] - </param>
'''  <param name="boxas">[in] - location of components</param>
'''  <param name="scorethresh">[in] - min score for which we accept a component</param>
'''  <param name="spacethresh">[in] - max horizontal distance allowed between digits, use -1 for default</param>
'''  <param name="pbaa">[out][optional] - bounding boxes of identified numbers</param>
'''  <param name="pnaa">[out][optional] - scores of identified digits</param>
'''   <returns>sa of identified numbers, or NULL on error</returns>
Public Shared Function recogExtractNumbers(
				ByVal recog as L_Recog, 
				ByVal boxas as Boxa, 
				ByVal scorethresh as Single, 
				ByVal spacethresh as Integer, 
				<Out()> Optional  ByRef pbaa as Boxaa = Nothing, 
				<Out()> Optional  ByRef pnaa as Numaa = Nothing) as Sarray


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	Dim pbaaPtr as IntPtr = IntPtr.Zero
	Dim pnaaPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.recogExtractNumbers(recog.Pointer, boxas.Pointer,   scorethresh,   spacethresh, pbaaPtr, pnaaPtr)
	
	if pbaaPtr = IntPtr.Zero then pbaa = Nothing else pbaa = new Boxaa(pbaaPtr)
	if pnaaPtr = IntPtr.Zero then pnaa = Nothing else pnaa = new Numaa(pnaaPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Sarray(_Result)
End Function

' recogident.c (1761, 1)
' showExtractNumbers(pixs, sa, baa, naa, ppixdb) as Pixa
' showExtractNumbers(PIX *, SARRAY *, BOXAA *, NUMAA *, PIX **) as PIXA *
'''  <summary>
''' (1) This is a debugging routine on digit identification e.g.:
'''recogIdentifyMultiple(recog, pixs, 0, 1, [and]boxa, NULL, NULL, 0)
'''sa = recogExtractNumbers(recog, boxa, 0.8, -1, [and]baa, [and]naa)
'''pixa = showExtractNumbers(pixs, sa, baa, naa, NULL)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/showExtractNumbers/*"/>
'''  <param name="pixs">[in] - input 1 bpp image</param>
'''  <param name="sa">[in] - recognized text strings</param>
'''  <param name="baa">[in] - boxa array for location of characters in each string</param>
'''  <param name="naa">[in] - numa array for scores of characters in each string</param>
'''  <param name="ppixdb">[out][optional] - input pixs with identified chars outlined</param>
'''   <returns>pixa   of identified strings with text and scores, or NULL on error</returns>
Public Shared Function showExtractNumbers(
				ByVal pixs as Pix, 
				ByVal sa as Sarray, 
				ByVal baa as Boxaa, 
				ByVal naa as Numaa, 
				<Out()> Optional  ByRef ppixdb as Pix = Nothing) as Pixa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
		if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")
	Dim ppixdbPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.showExtractNumbers(pixs.Pointer, sa.Pointer, baa.Pointer, naa.Pointer, ppixdbPtr)
	
	if ppixdbPtr = IntPtr.Zero then ppixdb = Nothing else ppixdb = new Pix(ppixdbPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

End Class


