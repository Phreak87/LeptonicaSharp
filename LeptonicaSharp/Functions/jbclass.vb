Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\jbclass.c (283, 1)
' jbRankHausInit()
' jbRankHausInit(l_int32, l_int32, l_int32, l_int32, l_float32) as JBCLASSER *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component; use 0 for default</param>
'''  <param name="maxheight">[in] - of component; use 0 for default</param>
'''  <param name="size">[in] - of square structuring element; 2, representing 2x2 sel, is necessary for reasonable accuracy of small components; combine this with rank ~ 0.97 to avoid undue class expansion</param>
'''  <param name="rank">[in] - rank val of match, each way; in [0.5 - 1.0]; when using size = 2, 0.97 is a reasonable value</param>
'''   <returns>jbclasser if OK; NULL on error</returns>
Public Shared Function jbRankHausInit(
				ByVal components as Enumerations.JB_S, 
				ByVal maxwidth as Integer, 
				ByVal maxheight as Integer, 
				ByVal size as Integer, 
				ByVal rank as Single) as JbClasser

	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbRankHausInit( components, maxwidth, maxheight, size, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (344, 1)
' jbCorrelationInit()
' jbCorrelationInit(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
'''  <summary>
''' Notes
''' (1) For scanned text, suggested input values are
''' thresh ~ [0.8 - 0.85]
''' weightfactor ~ [0.5 - 0.6]
''' (2) For electronically generated fonts (e.g., rasterized pdf),
''' a very high thresh (e.g., 0.95) will not cause a significant
''' increase in the number of classes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component; use 0 for default</param>
'''  <param name="maxheight">[in] - of component; use 0 for default</param>
'''  <param name="thresh">[in] - value for correlation score in [0.4 - 0.98]</param>
'''  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
'''   <returns>jbclasser if OK; NULL on error</returns>
Public Shared Function jbCorrelationInit(
				ByVal components as Enumerations.JB_S, 
				ByVal maxwidth as Integer, 
				ByVal maxheight as Integer, 
				ByVal thresh as Single, 
				ByVal weightfactor as Single) as JbClasser

	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If IsNothing (weightfactor) then Throw New ArgumentNullException  ("weightfactor cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbCorrelationInit( components, maxwidth, maxheight, thresh, weightfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (371, 1)
' jbCorrelationInitWithoutComponents()
' jbCorrelationInitWithoutComponents(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
'''  <summary>
''' Notes
''' Acts the same as jbCorrelationInit(), but the resulting
''' object doesn't keep a list of all the components.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component; use 0 for default</param>
'''  <param name="maxheight">[in] - of component; use 0 for default</param>
'''  <param name="thresh">[in] - value  for correlation score in [0.4 - 0.98]</param>
'''  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
'''   <returns>jbclasser if OK; NULL on error</returns>
Public Shared Function jbCorrelationInitWithoutComponents(
				ByVal components as Enumerations.JB_S, 
				ByVal maxwidth as Integer, 
				ByVal maxheight as Integer, 
				ByVal thresh as Single, 
				ByVal weightfactor as Single) as JbClasser

	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If IsNothing (weightfactor) then Throw New ArgumentNullException  ("weightfactor cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbCorrelationInitWithoutComponents( components, maxwidth, maxheight, thresh, weightfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (444, 1)
' jbAddPages()
' jbAddPages(JBCLASSER *, SARRAY *) as l_ok
'''  <summary>
''' Notes
''' (1) jbclasser makes a copy of the array of file names.
''' (2) The caller is still responsible for destroying the input array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="safiles">[in] - of page image file names</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function jbAddPages(
				ByRef classer as JbClasser, 
				ByVal safiles as Sarray) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (safiles) then Throw New ArgumentNullException  ("safiles cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbAddPages( classer.Pointer, safiles.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (486, 1)
' jbAddPage()
' jbAddPage(JBCLASSER *, PIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input page</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function jbAddPage(
				ByRef classer as JbClasser, 
				ByVal pixs as Pix) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbAddPage( classer.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (531, 1)
' jbAddPageComponents()
' jbAddPageComponents(JBCLASSER *, PIX *, BOXA *, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) If there are no components on the page, we don't require input
''' of empty boxas or pixas, although that's the typical situation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input page</param>
'''  <param name="boxas">[in] - b.b. of components for this page</param>
'''  <param name="pixas">[in] - components for this page</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function jbAddPageComponents(
				ByRef classer as JbClasser, 
				ByVal pixs as Pix, 
				ByVal boxas as Boxa, 
				ByVal pixas as Pixa) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbAddPageComponents( classer.Pointer, pixs.Pointer, boxas.Pointer, pixas.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (591, 1)
' jbClassifyRankHaus()
' jbClassifyRankHaus(JBCLASSER *, BOXA *, PIXA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - new components for classification</param>
'''  <param name="pixas">[in] - new components for classification</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function jbClassifyRankHaus(
				ByRef classer as JbClasser, 
				ByVal boxa as Boxa, 
				ByVal pixas as Pixa) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbClassifyRankHaus( classer.Pointer, boxa.Pointer, pixas.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (845, 1)
' pixHaustest()
' pixHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32) as l_int32
'''  <summary>
''' Notes
''' We check first that the two pix are roughly
''' the same size.  Only if they meet that criterion do
''' we compare the bitmaps.  The Hausdorff is a 2-way
''' check.  The centroid difference is used to align the two
''' images to the nearest integer for each of the checks.
''' These check that the dilated image of one contains
''' ALL the pixels of the undilated image of the other.
''' Checks are done in both direction.  A single pixel not
''' contained in either direction results in failure of the test.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - new pix, not dilated</param>
'''  <param name="pix2">[in] - new pix, dilated</param>
'''  <param name="pix3">[in] - exemplar pix, not dilated</param>
'''  <param name="pix4">[in] - exemplar pix, dilated</param>
'''  <param name="delx">[in] - x comp of centroid difference</param>
'''  <param name="dely">[in] - y comp of centroid difference</param>
'''  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
'''  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
'''   <returns>0 FALSE) if no match, 1 (TRUE if the new pix is in the same class as the exemplar.</returns>
Public Shared Function pixHaustest(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal pix3 as Pix, 
				ByVal pix4 as Pix, 
				ByVal delx as Single, 
				ByVal dely as Single, 
				ByVal maxdiffw as Integer, 
				ByVal maxdiffh as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (pix3) then Throw New ArgumentNullException  ("pix3 cannot be Nothing")
	If IsNothing (pix4) then Throw New ArgumentNullException  ("pix4 cannot be Nothing")
	If IsNothing (delx) then Throw New ArgumentNullException  ("delx cannot be Nothing")
	If IsNothing (dely) then Throw New ArgumentNullException  ("dely cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixHaustest( pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer, delx, dely, maxdiffw, maxdiffh)

	Return _Result
End Function

' SRC\jbclass.c (943, 1)
' pixRankHaustest()
' pixRankHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as l_int32
'''  <summary>
''' Notes
''' We check first that the two pix are roughly
''' the same size.  Only if they meet that criterion do
''' we compare the bitmaps.  We convert the rank value to
''' a number of pixels by multiplying the rank fraction by the number
''' of pixels in the undilated image.  The Hausdorff is a 2-way
''' check.  The centroid difference is used to align the two
''' images to the nearest integer for each of the checks.
''' The rank hausdorff checks that the dilated image of one
''' contains the rank fraction of the pixels of the undilated
''' image of the other.   Checks are done in both direction.
''' Failure of the test in either direction results in failure
''' of the test.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - new pix, not dilated</param>
'''  <param name="pix2">[in] - new pix, dilated</param>
'''  <param name="pix3">[in] - exemplar pix, not dilated</param>
'''  <param name="pix4">[in] - exemplar pix, dilated</param>
'''  <param name="delx">[in] - x comp of centroid difference</param>
'''  <param name="dely">[in] - y comp of centroid difference</param>
'''  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
'''  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
'''  <param name="area1">[in] - fg pixels in pix1</param>
'''  <param name="area3">[in] - fg pixels in pix3</param>
'''  <param name="rank">[in] - rank value of test, each way</param>
'''  <param name="tab8">[in] - table of pixel sums for byte</param>
'''   <returns>0 FALSE) if no match, 1 (TRUE if the new pix is in the same class as the exemplar.</returns>
Public Shared Function pixRankHaustest(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal pix3 as Pix, 
				ByVal pix4 as Pix, 
				ByVal delx as Single, 
				ByVal dely as Single, 
				ByVal maxdiffw as Integer, 
				ByVal maxdiffh as Integer, 
				ByVal area1 as Integer, 
				ByVal area3 as Integer, 
				ByVal rank as Single, 
				ByVal tab8 as Integer()) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (pix3) then Throw New ArgumentNullException  ("pix3 cannot be Nothing")
	If IsNothing (pix4) then Throw New ArgumentNullException  ("pix4 cannot be Nothing")
	If IsNothing (delx) then Throw New ArgumentNullException  ("delx cannot be Nothing")
	If IsNothing (dely) then Throw New ArgumentNullException  ("dely cannot be Nothing")
	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")
	If IsNothing (tab8) then Throw New ArgumentNullException  ("tab8 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRankHaustest( pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer, delx, dely, maxdiffw, maxdiffh, area1, area3, rank, tab8)

	Return _Result
End Function

' SRC\jbclass.c (1030, 1)
' jbClassifyCorrelation()
' jbClassifyCorrelation(JBCLASSER *, BOXA *, PIXA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - new components for classification</param>
'''  <param name="pixas">[in] - new components for classification</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function jbClassifyCorrelation(
				ByRef classer as JbClasser, 
				ByVal boxa as Boxa, 
				ByVal pixas as Pixa) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbClassifyCorrelation( classer.Pointer, boxa.Pointer, pixas.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (1312, 1)
' jbGetComponents()
' jbGetComponents(PIX *, l_int32, l_int32, l_int32, BOXA **, PIXA **) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of saved components; larger are discarded</param>
'''  <param name="maxheight">[in] - of saved components; larger are discarded</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetComponents(
				ByVal pixs as Pix, 
				ByVal components as Enumerations.JB_S, 
				ByVal maxwidth as Integer, 
				ByVal maxheight as Integer, 
				ByRef pboxad as Boxa, 
				ByRef ppixad as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pboxad) then Throw New ArgumentNullException  ("pboxad cannot be Nothing")
	If IsNothing (ppixad) then Throw New ArgumentNullException  ("ppixad cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pboxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad) Then pboxadPTR = pboxad.Pointer
	Dim ppixadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixad) Then ppixadPTR = ppixad.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbGetComponents( pixs.Pointer, components, maxwidth, maxheight, pboxadPTR, ppixadPTR)

	Return _Result
End Function

' SRC\jbclass.c (1454, 1)
' pixWordMaskByDilation()
' pixWordMaskByDilation(PIX *, PIX **, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This gives an estimate of the word masks.  See
''' pixWordBoxesByDilation() for further filtering of the word boxes.
''' (2) The resolution should be between 75 and 150 ppi, and the optimal
''' dilation will be between 3 and 10.
''' (3) A good size for dilating to get word masks is optionally returned.
''' (4) Typically, the number of c.c. reduced with each successive
''' dilation (stored in nadiff) decreases quickly to a minimum
''' (where the characters in a word are joined), and then
''' increases again as the smaller number of words are joined.
''' For the typical case, you can then look for this minimum
''' and dilate to get the word mask.  However, there are many
''' cases where the function is not so simple. For example, if the
''' pix has been upscaled 2x, the nadiff function oscillates, with
''' every other value being zero!  And for some images it tails
''' off without a clear minimum to indicate where to break.
''' So a more simple and robust method is to find the dilation
''' where the initial number of c.c. has been reduced by some
''' fraction (we use a 70% reduction).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp; typ. at 75 to 150 ppi</param>
'''  <param name="psize">[out][optional] - size of good horizontal dilation</param>
'''  <param name="pixadb">[out][optional] - debug pixa of intermediate steps</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWordMaskByDilation(
				ByVal pixs as Pix, 
				ByRef ppixm as Pix, 
				Optional ByRef psize as Integer = Nothing, 
				Optional ByRef pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ppixm) then Throw New ArgumentNullException  ("ppixm cannot be Nothing")

	Dim ppixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixm) Then ppixmPTR = ppixm.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWordMaskByDilation( pixs.Pointer, ppixmPTR, psize, pixadbPTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\jbclass.c (1597, 1)
' pixWordBoxesByDilation()
' pixWordBoxesByDilation(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Returns a pruned set of word boxes.
''' (2) See pixWordMaskByDilation().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp; typ. 75 - 200 ppi</param>
'''  <param name="minwidth">[in] - saved components; smaller are discarded</param>
'''  <param name="minheight">[in] - saved components; smaller are discarded</param>
'''  <param name="maxwidth">[in] - saved components; larger are discarded</param>
'''  <param name="maxheight">[in] - saved components; larger are discarded</param>
'''  <param name="pboxa">[out] - of dilated word mask</param>
'''  <param name="psize">[out][optional] - size of good horizontal dilation</param>
'''  <param name="pixadb">[out][optional] - debug pixa of intermediate steps</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWordBoxesByDilation(
				ByVal pixs as Pix, 
				ByVal minwidth as Integer, 
				ByVal minheight as Integer, 
				ByVal maxwidth as Integer, 
				ByVal maxheight as Integer, 
				ByRef pboxa as Boxa, 
				Optional ByRef psize as Integer = Nothing, 
				Optional ByRef pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWordBoxesByDilation( pixs.Pointer, minwidth, minheight, maxwidth, maxheight, pboxaPTR, psize, pixadbPTR)
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\jbclass.c (1659, 1)
' jbAccumulateComposites()
' jbAccumulateComposites(PIXAA *, NUMA **, PTA **) as PIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixaa">[in] - one pixa for each class</param>
'''  <param name="pptat">[out] - centroids of bordered composites</param>
'''   <returns>pixad accumulated sum of samples in each class, or NULL on error</returns>
Public Shared Function jbAccumulateComposites(
				ByVal pixaa as Pixaa, 
				ByRef pna as Numa, 
				ByRef pptat as Pta) as Pixa

	If IsNothing (pixaa) then Throw New ArgumentNullException  ("pixaa cannot be Nothing")
	If IsNothing (pna) then Throw New ArgumentNullException  ("pna cannot be Nothing")

	Dim pnaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pna) Then pnaPTR = pna.Pointer
	Dim pptatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptat) Then pptatPTR = pptat.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbAccumulateComposites( pixaa.Pointer, pnaPTR, pptatPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pptatPTR <> IntPtr.Zero then pptat = new Pta(pptatPTR)

	Return  new Pixa(_Result)
End Function

' SRC\jbclass.c (1749, 1)
' jbTemplatesFromComposites()
' jbTemplatesFromComposites(PIXA *, NUMA *) as PIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - one pix of composites for each class</param>
'''  <param name="na">[in] - number of samples used for each class composite</param>
'''   <returns>pixad 8 bpp templates for each class, or NULL on error</returns>
Public Shared Function jbTemplatesFromComposites(
				ByVal pixac as Pixa, 
				ByVal na as Numa) as Pixa

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbTemplatesFromComposites( pixac.Pointer, na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\jbclass.c (1794, 1)
' jbClasserCreate()
' jbClasserCreate(l_int32, l_int32) as JBCLASSER *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="method">[in] - JB_RANKHAUS, JB_CORRELATION</param>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''   <returns>jbclasser, or NULL on error</returns>
Public Shared Function jbClasserCreate(
				ByVal method as Enumerations.JB, 
				ByVal components as Enumerations.JB_S) as JbClasser



	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbClasserCreate( method, components)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (1832, 1)
' 
' jbClasserDestroy(JBCLASSER **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub jbClasserDestroy(
				ByRef pclasser as JbClasser)

	If IsNothing (pclasser) then Throw New ArgumentNullException  ("pclasser cannot be Nothing")

	Dim pclasserPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pclasser) Then pclasserPTR = pclasser.Pointer

	LeptonicaSharp.Natives.jbClasserDestroy( pclasserPTR)

End Sub

' SRC\jbclass.c (1882, 1)
' jbDataSave()
' jbDataSave(JBCLASSER *) as JBDATA *
'''  <summary>
''' Notes
''' (1) This routine stores the jbig2-type data required for
''' generating a lossy jbig2 version of the image.
''' It can be losslessly written to (and read from) two files.
''' (2) It generates and stores the mosaic of templates.
''' (3) It clones the Numa and Pta arrays, so these must all
''' be destroyed by the caller.
''' (4) Input 0 to use the default values for latticew and/or latticeh,
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>jbdata, or NULL on error</returns>
Public Shared Function jbDataSave(
				ByRef classer as JbClasser) as JbData

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbDataSave( classer.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbData(_Result)
End Function

' SRC\jbclass.c (1922, 1)
' 
' jbDataDestroy(JBDATA **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub jbDataDestroy(
				ByRef pdata as JbData)

	If IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdata) Then pdataPTR = pdata.Pointer

	LeptonicaSharp.Natives.jbDataDestroy( pdataPTR)

End Sub

' SRC\jbclass.c (1954, 1)
' jbDataWrite()
' jbDataWrite(const char *, JBDATA *) as l_ok
'''  <summary>
''' Notes
''' (1) Serialization function that writes data in jbdata to file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="jbdata">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbDataWrite(
				ByRef rootout as String, 
				ByVal jbdata as JbData) as Integer

	If IsNothing (rootout) then Throw New ArgumentNullException  ("rootout cannot be Nothing")
	If IsNothing (jbdata) then Throw New ArgumentNullException  ("jbdata cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.jbDataWrite( rootout, jbdata.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (2014, 1)
' jbDataRead()
' jbDataRead(const char *) as JBDATA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rootname">[in] - for template and data files</param>
'''   <returns>jbdata, or NULL on error</returns>
Public Shared Function jbDataRead(
				ByVal rootname as String) as JbData

	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbDataRead( rootname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbData(_Result)
End Function

' SRC\jbclass.c (2119, 1)
' jbDataRender()
' jbDataRender(JBDATA *, l_int32) as PIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="debugflag">[in] - if TRUE, writes into 2 bpp pix and adds component outlines in color</param>
'''   <returns>pixa reconstruction of original images, using templates or NULL on error</returns>
Public Shared Function jbDataRender(
				ByRef data as JbData, 
				ByVal debugflag as Integer) as Pixa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

Dim dataPTR As IntPtr = IntPtr.Zero : If Not IsNothing(data) Then dataPTR = data.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbDataRender( data.Pointer, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\jbclass.c (2228, 1)
' jbGetULCorners()
' jbGetULCorners(JBCLASSER *, PIX *, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This computes the ptaul field, which has the global UL corners,
''' adjusted for each specific component, so that each component
''' can be replaced by the template for its class and have the
''' centroid in the template in the same position as the
''' centroid of the original connected component.  It is important
''' that this be done properly to avoid a wavy baseline in the
''' result.
''' (2) The array fields ptac and ptact give the centroids of
''' those components relative to the UL corner of each component.
''' Here, we compute the difference in each component, round to
''' nearest integer, and correct the box-GTx and box-GTy by
''' the appropriate integral difference.
''' (3) The templates and stored instances are all bordered.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - full res image</param>
'''  <param name="boxa">[in] - of c.c. bounding rectangles for this page</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetULCorners(
				ByRef classer as JbClasser, 
				ByVal pixs as Pix, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbGetULCorners( classer.Pointer, pixs.Pointer, boxa.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (2320, 1)
' jbGetLLCorners()
' jbGetLLCorners(JBCLASSER *) as l_ok
'''  <summary>
''' Notes
''' (1) This computes the ptall field, which has the global LL corners,
''' adjusted for each specific component, so that each component
''' can be replaced by the template for its class and have the
''' centroid in the template in the same position as the
''' centroid of the original connected component. It is important
''' that this be done properly to avoid a wavy baseline in the result.
''' (2) It is computed here from the corresponding UL corners, where
''' the input templates and stored instances are all bordered.
''' This should be done after all pages have been processed.
''' (3) For proper substitution, the templates whose LL corners are
''' placed in these locations must be UN-bordered.
''' This is available for a realistic jbig2 encoder, which would
''' (1) encode each template without a border, and (2) encode
''' the position using the LL corner (rather than the UL
''' corner) because the difference between y-values
''' of successive instances is typically close to zero.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetLLCorners(
				ByRef classer as JbClasser) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")

Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbGetLLCorners( classer.Pointer)

	Return _Result
End Function

End Class
