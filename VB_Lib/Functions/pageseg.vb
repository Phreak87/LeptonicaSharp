Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\pageseg.c (102, 1)
' pixGetRegionsBinary(pixs, ppixhm, ppixtm, ppixtb, pixadb) as Integer
' pixGetRegionsBinary(PIX *, PIX **, PIX **, PIX **, PIXA *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) It is best to deskew the image before segmenting.<para/>
''' 
''' (2) Passing in %pixadb enables debug output.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRegionsBinary/*"/>
'''  <param name="pixs">[in] - 1 bpp, assumed to be 300 to 400 ppi</param>
'''  <param name="ppixhm">[out][optional] - halftone mask</param>
'''  <param name="ppixtm">[out][optional] - textline mask</param>
'''  <param name="ppixtb">[out][optional] - textblock mask</param>
'''  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetRegionsBinary(
				 ByVal pixs as Pix, 
				<Out()> ByRef ppixhm as Pix, 
				<Out()> ByRef ppixtm as Pix, 
				<Out()> ByRef ppixtb as Pix, 
				 ByVal pixadb as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

Dim ppixhmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixhm) Then ppixhmPTR = ppixhm.Pointer
Dim ppixtmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixtm) Then ppixtmPTR = ppixtm.Pointer
Dim ppixtbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixtb) Then ppixtbPTR = ppixtb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetRegionsBinary( pixs.Pointer, ppixhmPTR, ppixtmPTR, ppixtbPTR, pixadb.Pointer)

If ppixhmPTR = IntPtr.Zero Then ppixhm = Nothing
If ppixhmPTR <> IntPtr.Zero Then ppixhm = New Pix(ppixhmPTR)
If ppixtmPTR = IntPtr.Zero Then ppixtm = Nothing
If ppixtmPTR <> IntPtr.Zero Then ppixtm = New Pix(ppixtmPTR)
If ppixtbPTR = IntPtr.Zero Then ppixtb = Nothing
If ppixtbPTR <> IntPtr.Zero Then ppixtb = New Pix(ppixtbPTR)

	Return _Result
End Function

' SRC\pageseg.c (264, 1)
' pixGenHalftoneMask(pixs, ppixtext, phtfound, debug) as Pix
' pixGenHalftoneMask(PIX *, PIX **, l_int32 *, l_int32) as PIX *
'''  <summary>
''' Deprecated:
''' This wrapper avoids an ABI change with tesseract 3.0.4.
''' It should be removed when we no longer need to support 3.0.4.
''' The debug parameter is ignored (assumed 0).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenHalftoneMask/*"/>
'''   <returns></returns>
Public Shared Function pixGenHalftoneMask(
				 ByVal pixs as Pix, 
				 ByVal ppixtext as Pix, 
				 ByVal phtfound as Object, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ppixtext) then Throw New ArgumentNullException  ("ppixtext cannot be Nothing")
	If IsNothing (phtfound) then Throw New ArgumentNullException  ("phtfound cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer
	Dim ppixtextPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixtext) Then ppixtextPTR = ppixtext.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenHalftoneMask( pixs.Pointer, ppixtextPTR, phtfound, debug)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pageseg.c (289, 1)
' pixGenerateHalftoneMask(pixs, ppixtext, phtfound, pixadb) as Pix
' pixGenerateHalftoneMask(PIX *, PIX **, l_int32 *, PIXA *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is not intended to work on small thumbnails.  The
''' dimensions of pixs must be at least MinWidth x MinHeight.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateHalftoneMask/*"/>
'''  <param name="pixs">[in] - 1 bpp, assumed to be 150 to 200 ppi</param>
'''  <param name="ppixtext">[out][optional] - text part of pixs</param>
'''  <param name="phtfound">[out][optional] - 1 if the mask is not empty</param>
'''  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
'''   <returns>pixd halftone mask, or NULL on error</returns>
Public Shared Function pixGenerateHalftoneMask(
				 ByVal pixs as Pix, 
				<Out()> ByRef ppixtext as Pix, 
				<Out()> ByRef phtfound as Integer, 
				 ByVal pixadb as Pixa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

Dim ppixtextPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixtext) Then ppixtextPTR = ppixtext.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenerateHalftoneMask( pixs.Pointer, ppixtextPTR, phtfound, pixadb.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing
If ppixtextPTR = IntPtr.Zero Then ppixtext = Nothing
If ppixtextPTR <> IntPtr.Zero Then ppixtext = New Pix(ppixtextPTR)

	Return  new Pix(_Result)
End Function

' SRC\pageseg.c (372, 1)
' pixGenTextlineMask(pixs, ppixvws, ptlfound, pixadb) as Pix
' pixGenTextlineMask(PIX *, PIX **, l_int32 *, PIXA *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The input pixs should be deskewed.<para/>
''' 
''' (2) pixs should have no halftone pixels.<para/>
''' 
''' (3) This is not intended to work on small thumbnails.  The
''' dimensions of pixs must be at least MinWidth x MinHeight.<para/>
''' 
''' (4) Both the input image and the returned textline mask
''' are at the same resolution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenTextlineMask/*"/>
'''  <param name="pixs">[in] - 1 bpp, assumed to be 150 to 200 ppi</param>
'''  <param name="ppixvws">[out] - vertical whitespace mask</param>
'''  <param name="ptlfound">[out][optional] - 1 if the mask is not empty</param>
'''  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
'''   <returns>pixd textline mask, or NULL on error</returns>
Public Shared Function pixGenTextlineMask(
				 ByVal pixs as Pix, 
				<Out()> ByRef ppixvws as Pix, 
				<Out()> ByRef ptlfound as Integer, 
				 ByVal pixadb as Pixa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

	Dim ppixvwsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixvws) Then ppixvwsPTR = ppixvws.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenTextlineMask( pixs.Pointer, ppixvwsPTR, ptlfound, pixadb.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing
If ppixvwsPTR = IntPtr.Zero Then ppixvws = Nothing
If ppixvwsPTR <> IntPtr.Zero Then ppixvws = New Pix(ppixvwsPTR)

	Return  new Pix(_Result)
End Function

' SRC\pageseg.c (464, 1)
' pixGenTextblockMask(pixs, pixvws, pixadb) as Pix
' pixGenTextblockMask(PIX *, PIX *, PIXA *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Both the input masks (textline and vertical white space) and
''' the returned textblock mask are at the same resolution.<para/>
''' 
''' (2) This is not intended to work on small thumbnails.  The
''' dimensions of pixs must be at least MinWidth x MinHeight.<para/>
''' 
''' (3) The result is somewhat noisy, in that small "blocks" of
''' text may be included.  These can be removed by post-processing,
''' using, e.g.,
''' pixSelectBySize(pix, 60, 60, 4, L_SELECT_IF_EITHER,
''' L_SELECT_IF_GTE, NULL)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenTextblockMask/*"/>
'''  <param name="pixs">[in] - 1 bpp, textline mask, assumed to be 150 to 200 ppi</param>
'''  <param name="pixvws">[in] - vertical white space mask</param>
'''  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
'''   <returns>pixd textblock mask, or NULL on error</returns>
Public Shared Function pixGenTextblockMask(
				 ByVal pixs as Pix, 
				 ByVal pixvws as Pix, 
				 ByVal pixadb as Pixa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixvws) then Throw New ArgumentNullException  ("pixvws cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenTextblockMask( pixs.Pointer, pixvws.Pointer, pixadb.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pageseg.c (548, 1)
' pixFindPageForeground(pixs, threshold, mindist, erasedist, showmorph, pixac) as Box
' pixFindPageForeground(PIX *, l_int32, l_int32, l_int32, l_int32, PIXAC *) as BOX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This doesn't simply crop to the fg.  It attempts to remove
''' pixel noise and junk at the edge of the image before cropping.
''' The input %threshold is used if pixs is not 1 bpp.<para/>
''' 
''' (2) This is not intended to work on small thumbnails.  The
''' dimensions of pixs must be at least MinWidth x MinHeight.<para/>
''' 
''' (3) Debug: set showmorph to display the intermediate image in
''' the morphological operations on this page.<para/>
''' 
''' (4) Debug: to get pdf output of results when called repeatedly,
''' call with an existing pixac, which will add an image of this page,
''' with the fg outlined.  If no foreground is found, there is
''' no output for this page image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindPageForeground/*"/>
'''  <param name="pixs">[in] - full resolution (any type or depth</param>
'''  <param name="threshold">[in] - for binarization typically about 128</param>
'''  <param name="mindist">[in] - min distance of text from border to allow cleaning near border at 2x reduction, this should be larger than 50 typically about 70</param>
'''  <param name="erasedist">[in] - when conditions are satisfied, erase anything within this distance of the edge typically 20-30 at 2x reduction</param>
'''  <param name="showmorph">[in] - debug: set to a negative integer to show steps in generating masks this is typically used for debugging region extraction</param>
'''  <param name="pixac">[in] - debug: allocate outside and pass this in to accumulate results of each call to this function, which can be displayed in a mosaic or a pdf.</param>
'''   <returns>box region including foreground, with some pixel noise removed, or NULL if not found</returns>
Public Shared Function pixFindPageForeground(
				 ByVal pixs as Pix, 
				 ByVal threshold as Integer, 
				 ByVal mindist as Integer, 
				 ByVal erasedist as Integer, 
				 ByVal showmorph as Integer, 
				 ByVal pixac as PixaComp) as Box

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindPageForeground( pixs.Pointer, threshold, mindist, erasedist, showmorph, pixac.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\pageseg.c (679, 1)
' pixSplitIntoCharacters(pixs, minw, minh, pboxa, ppixa, ppixdebug) as Integer
' pixSplitIntoCharacters(PIX *, l_int32, l_int32, BOXA **, PIXA **, PIX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is a simple function that attempts to find split points
''' based on vertical pixel profiles.<para/>
''' 
''' (2) It should be given an image that has an arbitrary number
''' of text characters.<para/>
''' 
''' (3) The returned pixa includes the boxes from which the
''' (possibly split) components are extracted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSplitIntoCharacters/*"/>
'''  <param name="pixs">[in] - 1 bpp, contains only deskewed text</param>
'''  <param name="minw">[in] - min component width for initial filtering typ. 4</param>
'''  <param name="minh">[in] - min component height for initial filtering typ. 4</param>
'''  <param name="pboxa">[out][optional] - character bounding boxes</param>
'''  <param name="ppixa">[out][optional] - character images</param>
'''  <param name="ppixdebug">[out][optional] - showing splittings</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSplitIntoCharacters(
				 ByVal pixs as Pix, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer, 
				<Out()> Optional ByRef pboxa as Boxa = Nothing, 
				<Out()> Optional ByRef ppixa as Pixa = Nothing, 
				<Out()> Optional ByRef ppixdebug as Pix = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer
Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer
Dim ppixdebugPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdebug) Then ppixdebugPTR = ppixdebug.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSplitIntoCharacters( pixs.Pointer, minw, minh, pboxaPTR, ppixaPTR, ppixdebugPTR)

If pboxaPTR = IntPtr.Zero Then pboxa = Nothing
If pboxaPTR <> IntPtr.Zero Then pboxa = New Boxa(pboxaPTR)
If ppixaPTR = IntPtr.Zero Then ppixa = Nothing
If ppixaPTR <> IntPtr.Zero Then ppixa = New Pixa(ppixaPTR)
If ppixdebugPTR = IntPtr.Zero Then ppixdebug = Nothing
If ppixdebugPTR <> IntPtr.Zero Then ppixdebug = New Pix(ppixdebugPTR)

	Return _Result
End Function

' SRC\pageseg.c (780, 1)
' pixSplitComponentWithProfile(pixs, delta, mindel, ppixdebug) as Boxa
' pixSplitComponentWithProfile(PIX *, l_int32, l_int32, PIX **) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This will split the most obvious cases of touching characters.
''' The split points it is searching for are narrow and deep
''' minimima in the vertical pixel projection profile, after a
''' large vertical closing has been applied to the component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSplitComponentWithProfile/*"/>
'''  <param name="pixs">[in] - 1 bpp, exactly one connected component</param>
'''  <param name="delta">[in] - distance used in extrema finding in a numa typ. 10</param>
'''  <param name="mindel">[in] - minimum required difference between profile minimum and profile values +2 and -2 away typ. 7</param>
'''  <param name="ppixdebug">[out][optional] - debug image of splitting</param>
'''   <returns>boxa of c.c. after splitting, or NULL on error</returns>
Public Shared Function pixSplitComponentWithProfile(
				 ByVal pixs as Pix, 
				 ByVal delta as Integer, 
				 ByVal mindel as Integer, 
				<Out()> Optional ByRef ppixdebug as Pix = Nothing) as Boxa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim ppixdebugPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdebug) Then ppixdebugPTR = ppixdebug.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSplitComponentWithProfile( pixs.Pointer, delta, mindel, ppixdebugPTR)

	If  _Result = IntPtr.Zero then Return Nothing
If ppixdebugPTR = IntPtr.Zero Then ppixdebug = Nothing
If ppixdebugPTR <> IntPtr.Zero Then ppixdebug = New Pix(ppixdebugPTR)

	Return  new Boxa(_Result)
End Function

' SRC\pageseg.c (936, 1)
' pixExtractTextlines(pixs, maxw, maxh, minw, minh, adjw, adjh, pixadb) as Pixa
' pixExtractTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIXA *) as PIXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This function assumes that textline fragments have sufficient
''' vertical separation and small enough skew so that a
''' horizontal dilation sufficient to join words will not join
''' textlines.  It does not guarantee that horizontally adjacent
''' textline fragments on the same line will be joined.<para/>
''' 
''' (2) For images with multiple columns, it attempts to avoid joining
''' textlines across the space between columns.  If that is not
''' a concern, you can also use pixExtractRawTextlines(),
''' which will join them with alacrity.<para/>
''' 
''' (3) This first removes components from pixs that are either
''' wide ( is greater  %maxw) or tall ( is greater  %maxh).<para/>
''' 
''' (4) A final filtering operation removes small components, such
''' that width  is smaller %minw or height  is smaller %minh.<para/>
''' 
''' (5) For reasonable accuracy, the resolution of pixs should be
''' at least 100 ppi.  For reasonable efficiency, the resolution
''' should not exceed 600 ppi.<para/>
''' 
''' (6) This can be used to determine if some region of a scanned
''' image is horizontal text.<para/>
''' 
''' (7) As an example, for a pix with resolution 300 ppi, a reasonable
''' set of parameters is:
''' pixExtractTextlines(pix, 150, 150, 36, 20, 5, 5, NULL)
''' The defaults minw and minh for 300 ppi are about 36 and 20,
''' so the same result is obtained with:
''' pixExtractTextlines(pix, 150, 150, 0, 0, 5, 5, NULL)<para/>
''' 
''' (8) The output pixa is composed of subimages, one for each textline,
''' and the boxa in the pixa tells where in %pixs each textline goes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractTextlines/*"/>
'''  <param name="pixs">[in] - any depth, assumed to have nearly horizontal text</param>
'''  <param name="maxw">[in] - initial filtering: remove any components in pixs with components larger than maxw or maxh</param>
'''  <param name="maxh">[in] - initial filtering: remove any components in pixs with components larger than maxw or maxh</param>
'''  <param name="minw">[in] - final filtering: remove extracted 'lines' with sizes smaller than minw or minh use 0 for default.</param>
'''  <param name="minh">[in] - final filtering: remove extracted 'lines' with sizes smaller than minw or minh use 0 for default.</param>
'''  <param name="adjw">[in] - final adjustment of boxes representing each text line.  If  is greater  0, these increase the box size at each edge by this amount.</param>
'''  <param name="adjh">[in] - final adjustment of boxes representing each text line.  If  is greater  0, these increase the box size at each edge by this amount.</param>
'''  <param name="pixadb">[in] - pixa for saving intermediate steps NULL to omit</param>
'''   <returns>pixa of textline images, including bounding boxes, or NULL on error</returns>
Public Shared Function pixExtractTextlines(
				 ByVal pixs as Pix, 
				 ByVal maxw as Integer, 
				 ByVal maxh as Integer, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer, 
				 ByVal adjw as Integer, 
				 ByVal adjh as Integer, 
				 ByVal pixadb as Pixa) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractTextlines( pixs.Pointer, maxw, maxh, minw, minh, adjw, adjh, pixadb.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pageseg.c (1076, 1)
' pixExtractRawTextlines(pixs, maxw, maxh, adjw, adjh, pixadb) as Pixa
' pixExtractRawTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, PIXA *) as PIXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This function assumes that textlines have sufficient
''' vertical separation and small enough skew so that a
''' horizontal dilation sufficient to join words will not join
''' textlines.  It aggressively joins textlines across multiple
''' columns, so if that is not desired, you must either (a) make
''' sure that %pixs is a single column of text or (b) use instead
''' pixExtractTextlines(), which is more conservative
''' about joining text fragments that have vertical overlap.<para/>
''' 
''' (2) This first removes components from pixs that are either
''' very wide ( is greater  %maxw) or very tall ( is greater  %maxh).<para/>
''' 
''' (3) For reasonable accuracy, the resolution of pixs should be
''' at least 100 ppi.  For reasonable efficiency, the resolution
''' should not exceed 600 ppi.<para/>
''' 
''' (4) This can be used to determine if some region of a scanned
''' image is horizontal text.<para/>
''' 
''' (5) As an example, for a pix with resolution 300 ppi, a reasonable
''' set of parameters is:
''' pixExtractRawTextlines(pix, 150, 150, 0, 0, NULL)<para/>
''' 
''' (6) The output pixa is composed of subimages, one for each textline,
''' and the boxa in the pixa tells where in %pixs each textline goes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractRawTextlines/*"/>
'''  <param name="pixs">[in] - any depth, assumed to have nearly horizontal text</param>
'''  <param name="maxw">[in] - initial filtering: remove any components in pixs with components larger than maxw or maxh use 0 for default values.</param>
'''  <param name="maxh">[in] - initial filtering: remove any components in pixs with components larger than maxw or maxh use 0 for default values.</param>
'''  <param name="adjw">[in] - final adjustment of boxes representing each text line.  If  is greater  0, these increase the box size at each edge by this amount.</param>
'''  <param name="adjh">[in] - final adjustment of boxes representing each text line.  If  is greater  0, these increase the box size at each edge by this amount.</param>
'''  <param name="pixadb">[in] - pixa for saving intermediate steps NULL to omit</param>
'''   <returns>pixa of textline images, including bounding boxes, or NULL on error</returns>
Public Shared Function pixExtractRawTextlines(
				 ByVal pixs as Pix, 
				 ByVal maxw as Integer, 
				 ByVal maxh as Integer, 
				 ByVal adjw as Integer, 
				 ByVal adjh as Integer, 
				 ByVal pixadb as Pixa) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixadb) then Throw New ArgumentNullException  ("pixadb cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractRawTextlines( pixs.Pointer, maxw, maxh, adjw, adjh, pixadb.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pageseg.c (1204, 1)
' pixCountTextColumns(pixs, deltafract, peakfract, clipfract, pncols, pixadb) as Integer
' pixCountTextColumns(PIX *, l_float32, l_float32, l_float32, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) It is assumed that pixs has the correct resolution set.
''' If the resolution is 0, we set to 300 and issue a warning.<para/>
''' 
''' (2) If necessary, the image is scaled to between 37 and 75 ppi
''' most of the processing is done at this resolution.<para/>
''' 
''' (3) If no text is found (essentially a blank page),
''' this returns ncols = 0.<para/>
''' 
''' (4) For debug output, input a pre-allocated pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountTextColumns/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="deltafract">[in] - fraction of (max - min) to be used in the delta for extrema finding typ 0.3</param>
'''  <param name="peakfract">[in] - fraction of (max - min) to be used to threshold the peak value typ. 0.5</param>
'''  <param name="clipfract">[in] - fraction of image dimension removed on each side typ. 0.1, which leaves w and h reduced by 0.8</param>
'''  <param name="pncols">[out] - number of columns -1 if not determined</param>
'''  <param name="pixadb">[in][optional] - pre-allocated, for showing intermediate computation use null to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCountTextColumns(
				 ByVal pixs as Pix, 
				 ByVal deltafract as Single, 
				 ByVal peakfract as Single, 
				 ByVal clipfract as Single, 
				<Out()> ByRef pncols as Integer, 
				 Optional ByVal pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountTextColumns( pixs.Pointer, deltafract, peakfract, clipfract, pncols, pixadbPTR)


	Return _Result
End Function

' SRC\pageseg.c (1352, 1)
' pixDecideIfText(pixs, box, pistext, pixadb) as Integer
' pixDecideIfText(PIX *, BOX *, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) It is assumed that pixs has the correct resolution set.
''' If the resolution is 0, we set to 300 and issue a warning.<para/>
''' 
''' (2) If necessary, the image is scaled to 300 ppi most of the
''' processing is done at this resolution.<para/>
''' 
''' (3) Text is assumed to be in horizontal lines.<para/>
''' 
''' (4) Because thin vertical lines are removed before filtering for
''' text lines, this should identify tables as text.<para/>
''' 
''' (5) If %box is null and pixs contains both text lines and line art,
''' this function might return %istext == true.<para/>
''' 
''' (6) If the input pixs is empty, or for some other reason the
''' result can not be determined, return -1.<para/>
''' 
''' (7) For debug output, input a pre-allocated pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDecideIfText/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="box">[in][optional] - if null, use entire pixs</param>
'''  <param name="pistext">[out] - 1 if text 0 if photo -1 if not determined or empty</param>
'''  <param name="pixadb">[in][optional] - pre-allocated, for showing intermediate computation use NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixDecideIfText(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				<Out()> ByRef pistext as Integer, 
				 Optional ByVal pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDecideIfText( pixs.Pointer, boxPTR, pistext, pixadbPTR)


	Return _Result
End Function

' SRC\pageseg.c (1518, 1)
' pixFindThreshFgExtent(pixs, thresh, ptop, pbot) as Integer
' pixFindThreshFgExtent(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindThreshFgExtent/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold number of pixels in row</param>
'''  <param name="ptop">[out][optional] - location of top of region</param>
'''  <param name="pbot">[out][optional] - location of bottom of region</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindThreshFgExtent(
				 ByVal pixs as Pix, 
				 ByVal thresh as Integer, 
				<Out()> Optional ByRef ptop as Integer = Nothing, 
				<Out()> Optional ByRef pbot as Integer = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindThreshFgExtent( pixs.Pointer, thresh, ptop, pbot)


	Return _Result
End Function

' SRC\pageseg.c (1608, 1)
' pixDecideIfTable(pixs, box, orient, pscore, pixadb) as Integer
' pixDecideIfTable(PIX *, BOX *, l_int32, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) It is assumed that pixs has the correct resolution set.
''' If the resolution is 0, we assume it is 300 ppi and issue a warning.<para/>
''' 
''' (2) If %orient == L_LANDSCAPE_MODE, the image is rotated 90 degrees
''' clockwise before being analyzed.<para/>
''' 
''' (3) The interpretation of the returned score:
''' -1 undetermined
''' 0 no table
''' 1 unlikely to have a table
''' 2 likely to have a table
''' 3 even more likely to have a table
''' 4 extremely likely to have a table
''' Setting the condition for finding a table at score greater or equal 2 works
''' well, except for false positives on kanji and landscape text.
''' These false positives can be removed by setting the condition
''' at score greater or equal 3, but recall is lowered because it will not find
''' tables without either horizontal or vertical lines.<para/>
''' 
''' (4) Most of the processing takes place at 75 ppi.<para/>
''' 
''' (5) Internally, three numbers are determined, for horizontal and
''' vertical fg lines, and for vertical bg lines.  From these,
''' four tests are made to decide if there is a table occupying
''' a significant part of the image.<para/>
''' 
''' (6) Images have arbitrary content and would be likely to trigger
''' this detector, so they are checked for first, and if found,
''' return with a 0 (no table) score.<para/>
''' 
''' (7) Musical scores (tablature) are likely to trigger the detector.<para/>
''' 
''' (8) Tables of content with more than 2 columns are likely to
''' trigger the detector.<para/>
''' 
''' (9) For debug output, input a pre-allocated pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDecideIfTable/*"/>
'''  <param name="pixs">[in] - any depth, any resolution greater or equal 75 ppi</param>
'''  <param name="box">[in][optional] - if null, use entire pixs</param>
'''  <param name="orient">[in] - L_PORTRAIT_MODE, L_LANDSCAPE_MODE</param>
'''  <param name="pscore">[out] - 0 - 4 -1 if not determined</param>
'''  <param name="pixadb">[in][optional] - pre-allocated, for showing intermediate computation use NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixDecideIfTable(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal orient as Enumerations.L_MODE, 
				<Out()> ByRef pscore as Integer, 
				 Optional ByVal pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDecideIfTable( pixs.Pointer, boxPTR, orient, pscore, pixadbPTR)


	Return _Result
End Function

' SRC\pageseg.c (1758, 1)
' pixPrepare1bpp(pixs, box, cropfract, outres) as Pix
' pixPrepare1bpp(PIX *, BOX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This handles some common pre-processing operations,
''' where the page segmentation algorithm takes a 1 bpp image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixPrepare1bpp/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="box">[in][optional] - if null, use entire pixs</param>
'''  <param name="cropfract">[in] - fraction to be removed from the boundary use 0.0 to retain the entire image</param>
'''  <param name="outres">[in] - desired resolution of output image if the input image resolution is not set, assume 300 ppi use 0 to skip scaling.</param>
'''   <returns>pixd if OK, NULL on error</returns>
Public Shared Function pixPrepare1bpp(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal cropfract as Single, 
				 ByVal outres as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixPrepare1bpp( pixs.Pointer, boxPTR, cropfract, outres)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pageseg.c (1843, 1)
' pixEstimateBackground(pixs, darkthresh, edgecrop, pbg) as Integer
' pixEstimateBackground(PIX *, l_int32, l_float32, l_int32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Caller should check that return bg value is  is greater  0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEstimateBackground/*"/>
'''  <param name="pixs">[in] - 8 bpp, with or without colormap</param>
'''  <param name="darkthresh">[in] - pixels below this value are never considered part of the background typ. 70 use 0 to skip</param>
'''  <param name="edgecrop">[in] - fraction of half-width on each side, and of half-height at top and bottom, that are cropped</param>
'''  <param name="pbg">[out] - estimated background, or 0 on error</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixEstimateBackground(
				 ByVal pixs as Pix, 
				 ByVal darkthresh as Integer, 
				 ByVal edgecrop as Single, 
				<Out()> ByRef pbg as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixEstimateBackground( pixs.Pointer, darkthresh, edgecrop, pbg)


	Return _Result
End Function

' SRC\pageseg.c (1927, 1)
' pixFindLargeRectangles(pixs, polarity, nrect, pboxa, ppixdb) as Integer
' pixFindLargeRectangles(PIX *, l_int32, l_int32, BOXA **, PIX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a greedy search to find the largest rectangles,
''' either black or white and without overlaps, in %pix.<para/>
''' 
''' (2) See pixFindLargestRectangle(), which is called multiple
''' times, for details.  On each call, the largest rectangle
''' found is painted, so that none of its pixels can be
''' used later, before calling it again.<para/>
''' 
''' (3) This function is surprisingly fast.  Although
''' pixFindLargestRectangle() runs at about 50 MPix/sec, when it
''' is run multiple times by pixFindLargeRectangles(), it processes
''' at 150 - 250 MPix/sec, and the time is approximately linear
''' in %nrect.  For example, for a 1 MPix image, searching for
''' the largest 50 boxes takes about 0.2 seconds.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindLargeRectangles/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="polarity">[in] - 0 within background, 1 within foreground</param>
'''  <param name="nrect">[in] - number of rectangles to be found</param>
'''  <param name="pboxa">[out] - largest rectangles, sorted by decreasing area</param>
'''  <param name="ppixdb">[in,out] - optional return output with rectangles drawn on it</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindLargeRectangles(
				 ByVal pixs as Pix, 
				 ByVal polarity as Integer, 
				 ByVal nrect as Integer, 
				<Out()> ByRef pboxa as Boxa, 
				 ByRef ppixdb as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer
	Dim ppixdbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdb) Then ppixdbPTR = ppixdb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindLargeRectangles( pixs.Pointer, polarity, nrect, pboxaPTR, ppixdbPTR)

If pboxaPTR = IntPtr.Zero Then pboxa = Nothing
If pboxaPTR <> IntPtr.Zero Then pboxa = New Boxa(pboxaPTR)
If ppixdbPTR = IntPtr.Zero Then ppixdb = Nothing
If ppixdbPTR <> IntPtr.Zero Then ppixdb = New Pix(ppixdbPTR)

	Return _Result
End Function

' SRC\pageseg.c (2030, 1)
' pixFindLargestRectangle(pixs, polarity, pbox, ppixdb) as Integer
' pixFindLargestRectangle(PIX *, l_int32, BOX **, PIX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is a simple and elegant solution to a problem in
''' computational geometry that at first appears to be quite
''' difficult: what is the largest rectangle that can be
''' placed in the image, covering only pixels of one polarity
''' (bg or fg)?  The solution is O(n), where n is the number
''' of pixels in the image, and it requires nothing more than
''' using a simple recursion relation in a single sweep of the image.<para/>
''' 
''' (2) In a sweep from UL to LR with left-to-right being the fast
''' direction, calculate the largest white rectangle at (x, y),
''' using previously calculated values at pixels #1 and #2:
''' #1:  (x, y - 1)
''' #2:  (x - 1, y)
''' We also need the most recent "black" pixels that were seen
''' in the current row and column.
''' Consider the largest area.  There are only two possibilities:
''' (a)  Min(w(1), horizdist)  (h(1) + 1)
''' (b)  Min(h(2), vertdist)  (w(2) + 1)
''' where
''' horizdist: the distance from the rightmost "black" pixel seen
''' in the current row across to the current pixel
''' vertdist: the distance from the lowest "black" pixel seen
''' in the current column down to the current pixel
''' and we choose the Max of (a) and (b).<para/>
''' 
''' (3) To convince yourself that these recursion relations are correct,
''' it helps to draw the maximum rectangles at #1 and #2.
''' Then for #1, you try to extend the rectangle down one line,
''' so that the height is h(1) + 1.  Do you get the full
''' width of #1, w(1)?  It depends on where the black pixels are
''' in the current row.  You know the final width is bounded by w(1)
''' and w(2) + 1, but the actual value depends on the distribution
''' of black pixels in the current row that are at a distance
''' from the current pixel that is between these limits.
''' We call that value "horizdist", and the area is then given
''' by the expression (a) above.  Using similar reasoning for #2,
''' where you attempt to extend the rectangle to the right
''' by 1 pixel, you arrive at (b).  The largest rectangle is
''' then found by taking the Max.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindLargestRectangle/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="polarity">[in] - 0 within background, 1 within foreground</param>
'''  <param name="pbox">[out] - largest area rectangle</param>
'''  <param name="ppixdb">[in,out] - optional return output with rectangle drawn on it</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindLargestRectangle(
				 ByVal pixs as Pix, 
				 ByVal polarity as Integer, 
				<Out()> ByRef pbox as Box, 
				 ByRef ppixdb as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer
	Dim ppixdbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdb) Then ppixdbPTR = ppixdb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindLargestRectangle( pixs.Pointer, polarity, pboxPTR, ppixdbPTR)

If pboxPTR = IntPtr.Zero Then pbox = Nothing
If pboxPTR <> IntPtr.Zero Then pbox = New Box(pboxPTR)
If ppixdbPTR = IntPtr.Zero Then ppixdb = Nothing
If ppixdbPTR <> IntPtr.Zero Then ppixdb = New Pix(ppixdbPTR)

	Return _Result
End Function

End Class
