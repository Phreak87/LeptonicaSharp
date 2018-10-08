Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\jbclass.c (283, 1)
' jbRankHausInit(components, maxwidth, maxheight, size, rank) as JbClasser
' jbRankHausInit(l_int32, l_int32, l_int32, l_int32, l_float32) as JBCLASSER *
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component use 0 for default</param>
'''  <param name="maxheight">[in] - of component use 0 for default</param>
'''  <param name="size">[in] - of square structuring element 2, representing 2x2 sel, is necessary for reasonable accuracy of small components combine this with rank ~ 0.97 to avoid undue class expansion</param>
'''  <param name="rank">[in] - rank val of match, each way in [0.5 - 1.0] when using size = 2, 0.97 is a reasonable value</param>
'''   <returns>jbclasser if OK NULL on error</returns>
Public Shared Function jbRankHausInit(
				 ByVal components as Enumerations.JB_S, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				 ByVal size as Integer, 
				 ByVal rank as Single) as JbClasser





	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbRankHausInit( components, maxwidth, maxheight, size, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (344, 1)
' jbCorrelationInit(components, maxwidth, maxheight, thresh, weightfactor) as JbClasser
' jbCorrelationInit(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For scanned text, suggested input values are:<para/>
''' thresh ~ [0.8 - 0.85]<para/>
''' weightfactor ~ [0.5 - 0.6]<para/>
''' (2) For electronically generated fonts (e.g., rasterized pdf),<para/>
''' a very high thresh (e.g., 0.95) will not cause a significant<para/>
''' increase in the number of classes.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component use 0 for default</param>
'''  <param name="maxheight">[in] - of component use 0 for default</param>
'''  <param name="thresh">[in] - value for correlation score: in [0.4 - 0.98]</param>
'''  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
'''   <returns>jbclasser if OK NULL on error</returns>
Public Shared Function jbCorrelationInit(
				 ByVal components as Enumerations.JB_S, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				 ByVal thresh as Single, 
				 ByVal weightfactor as Single) as JbClasser





	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbCorrelationInit( components, maxwidth, maxheight, thresh, weightfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (371, 1)
' jbCorrelationInitWithoutComponents(components, maxwidth, maxheight, thresh, weightfactor) as JbClasser
' jbCorrelationInitWithoutComponents(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' Acts the same as jbCorrelationInit(), but the resulting<para/>
''' object doesn't keep a list of all the components.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of component use 0 for default</param>
'''  <param name="maxheight">[in] - of component use 0 for default</param>
'''  <param name="thresh">[in] - value  for correlation score: in [0.4 - 0.98]</param>
'''  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
'''   <returns>jbclasser if OK NULL on error</returns>
Public Shared Function jbCorrelationInitWithoutComponents(
				 ByVal components as Enumerations.JB_S, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				 ByVal thresh as Single, 
				 ByVal weightfactor as Single) as JbClasser





	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbCorrelationInitWithoutComponents( components, maxwidth, maxheight, thresh, weightfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbClasser(_Result)
End Function

' SRC\jbclass.c (444, 1)
' jbAddPages(classer, safiles) as Integer
' jbAddPages(JBCLASSER *, SARRAY *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) jbclasser makes a copy of the array of file names.<para/>
''' (2) The caller is still responsible for destroying the input array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="safiles">[in] - of page image file names</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function jbAddPages(
				 ByVal classer as JbClasser, 
				 ByVal safiles as Sarray) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (safiles) then Throw New ArgumentNullException  ("safiles cannot be Nothing")



Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbAddPages( classer.Pointer, safiles.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (486, 1)
' jbAddPage(classer, pixs) as Integer
' jbAddPage(JBCLASSER *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input page</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function jbAddPage(
				 ByVal classer as JbClasser, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbAddPage( classer.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (531, 1)
' jbAddPageComponents(classer, pixs, boxas, pixas) as Integer
' jbAddPageComponents(JBCLASSER *, PIX *, BOXA *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there are no components on the page, we don't require input<para/>
''' of empty boxas or pixas, although that's the typical situation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input page</param>
'''  <param name="boxas">[in] - b.b. of components for this page</param>
'''  <param name="pixas">[in] - components for this page</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function jbAddPageComponents(
				 ByVal classer as JbClasser, 
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
' jbClassifyRankHaus(classer, boxa, pixas) as Integer
' jbClassifyRankHaus(JBCLASSER *, BOXA *, PIXA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - new components for classification</param>
'''  <param name="pixas">[in] - new components for classification</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function jbClassifyRankHaus(
				 ByVal classer as JbClasser, 
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
' pixHaustest(pix1, pix2, pix3, pix4, delx, dely, maxdiffw, maxdiffh) as Integer
' pixHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' We check first that the two pix are roughly<para/>
''' the same size.  Only if they meet that criterion do<para/>
''' we compare the bitmaps.  The Hausdorff is a 2-way<para/>
''' check.  The centroid difference is used to align the two<para/>
''' images to the nearest integer for each of the checks.<para/>
''' These check that the dilated image of one contains<para/>
''' ALL the pixels of the undilated image of the other.<para/>
''' Checks are done in both direction.  A single pixel not<para/>
''' contained in either direction results in failure of the test.<para/>
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




	Dim _Result as Integer = LeptonicaSharp.Natives.pixHaustest( pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer, delx, dely, maxdiffw, maxdiffh)

	Return _Result
End Function

' SRC\jbclass.c (943, 1)
' pixRankHaustest(pix1, pix2, pix3, pix4, delx, dely, maxdiffw, maxdiffh, area1, area3, rank, tab8) as Integer
' pixRankHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' We check first that the two pix are roughly<para/>
''' the same size.  Only if they meet that criterion do<para/>
''' we compare the bitmaps.  We convert the rank value to<para/>
''' a number of pixels by multiplying the rank fraction by the number<para/>
''' of pixels in the undilated image.  The Hausdorff is a 2-way<para/>
''' check.  The centroid difference is used to align the two<para/>
''' images to the nearest integer for each of the checks.<para/>
''' The rank hausdorff checks that the dilated image of one<para/>
''' contains the rank fraction of the pixels of the undilated<para/>
''' image of the other. Checks are done in both direction.<para/>
''' Failure of the test in either direction results in failure<para/>
''' of the test.<para/>
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
	If IsNothing (tab8) then Throw New ArgumentNullException  ("tab8 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixRankHaustest( pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer, delx, dely, maxdiffw, maxdiffh, area1, area3, rank, tab8)

	Return _Result
End Function

' SRC\jbclass.c (1030, 1)
' jbClassifyCorrelation(classer, boxa, pixas) as Integer
' jbClassifyCorrelation(JBCLASSER *, BOXA *, PIXA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - new components for classification</param>
'''  <param name="pixas">[in] - new components for classification</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function jbClassifyCorrelation(
				 ByVal classer as JbClasser, 
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
' jbGetComponents(pixs, components, maxwidth, maxheight, pboxad, ppixad) as Integer
' jbGetComponents(PIX *, l_int32, l_int32, l_int32, BOXA **, PIXA **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
'''  <param name="maxwidth">[in] - of saved components larger are discarded</param>
'''  <param name="maxheight">[in] - of saved components larger are discarded</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetComponents(
				 ByVal pixs as Pix, 
				 ByVal components as Enumerations.JB_S, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				 ByVal pboxad as Boxa, 
				 ByVal ppixad as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pboxad) then Throw New ArgumentNullException  ("pboxad cannot be Nothing")
	If IsNothing (ppixad) then Throw New ArgumentNullException  ("ppixad cannot be Nothing")


	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pboxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad) Then pboxadPTR = pboxad.Pointer
	Dim ppixadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixad) Then ppixadPTR = ppixad.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbGetComponents( pixs.Pointer, components, maxwidth, maxheight, pboxadPTR, ppixadPTR)

	Return _Result
End Function

' SRC\jbclass.c (1454, 1)
' pixWordMaskByDilation(pixs, ppixm, psize, pixadb) as Integer
' pixWordMaskByDilation(PIX *, PIX **, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives an estimate of the word masks.  See<para/>
''' pixWordBoxesByDilation() for further filtering of the word boxes.<para/>
''' (2) The resolution should be between 75 and 150 ppi, and the optimal<para/>
''' dilation will be between 3 and 10.<para/>
''' (3) A good size for dilating to get word masks is optionally returned.<para/>
''' (4) Typically, the number of c.c. reduced with each successive<para/>
''' dilation (stored in nadiff) decreases quickly to a minimum<para/>
''' (where the characters in a word are joined), and then<para/>
''' increases again as the smaller number of words are joined.<para/>
''' For the typical case, you can then look for this minimum<para/>
''' and dilate to get the word mask.  However, there are many<para/>
''' cases where the function is not so simple. For example, if the<para/>
''' pix has been upscaled 2x, the nadiff function oscillates, with<para/>
''' every other value being zero!  And for some images it tails<para/>
''' off without a clear minimum to indicate where to break.<para/>
''' So a more simple and robust method is to find the dilation<para/>
''' where the initial number of c.c. has been reduced by some<para/>
''' fraction (we use a 70% reduction).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp typ. at 75 to 150 ppi</param>
'''  <param name="psize">[out][optional] - size of good horizontal dilation</param>
'''  <param name="pixadb">[out][optional] - debug: pixa of intermediate steps</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWordMaskByDilation(
				 ByVal pixs as Pix, 
				 ByVal ppixm as Pix, 
				<Out()> ByRef psize as Integer, 
				<Out()> ByRef pixadb as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ppixm) then Throw New ArgumentNullException  ("ppixm cannot be Nothing")



	Dim ppixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixm) Then ppixmPTR = ppixm.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWordMaskByDilation( pixs.Pointer, ppixmPTR, psize, pixadbPTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\jbclass.c (1597, 1)
' pixWordBoxesByDilation(pixs, minwidth, minheight, maxwidth, maxheight, pboxa, psize, pixadb) as Integer
' pixWordBoxesByDilation(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, l_int32 *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Returns a pruned set of word boxes.<para/>
''' (2) See pixWordMaskByDilation().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp typ. 75 - 200 ppi</param>
'''  <param name="minwidth">[in] - saved components smaller are discarded</param>
'''  <param name="minheight">[in] - saved components smaller are discarded</param>
'''  <param name="maxwidth">[in] - saved components larger are discarded</param>
'''  <param name="maxheight">[in] - saved components larger are discarded</param>
'''  <param name="pboxa">[out] - of dilated word mask</param>
'''  <param name="psize">[out][optional] - size of good horizontal dilation</param>
'''  <param name="pixadb">[out][optional] - debug: pixa of intermediate steps</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWordBoxesByDilation(
				 ByVal pixs as Pix, 
				 ByVal minwidth as Integer, 
				 ByVal minheight as Integer, 
				 ByVal maxwidth as Integer, 
				 ByVal maxheight as Integer, 
				<Out()> ByRef pboxa as Boxa, 
				<Out()> ByRef psize as Integer, 
				<Out()> ByRef pixadb as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



	Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWordBoxesByDilation( pixs.Pointer, minwidth, minheight, maxwidth, maxheight, pboxaPTR, psize, pixadbPTR)
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\jbclass.c (1659, 1)
' jbAccumulateComposites(pixaa, pna, pptat) as Pixa
' jbAccumulateComposites(PIXAA *, NUMA **, PTA **) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixaa">[in] - one pixa for each class</param>
'''  <param name="pptat">[out] - centroids of bordered composites</param>
'''   <returns>pixad accumulated sum of samples in each class, or NULL on error</returns>
Public Shared Function jbAccumulateComposites(
				 ByVal pixaa as Pixaa, 
				 ByVal pna as Numa, 
				<Out()> ByRef pptat as Pta) as Pixa

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
' jbTemplatesFromComposites(pixac, na) as Pixa
' jbTemplatesFromComposites(PIXA *, NUMA *) as PIXA *
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
' jbClasserCreate(method, components) as JbClasser
' jbClasserCreate(l_int32, l_int32) as JBCLASSER *
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
' jbClasserDestroy(pclasser) as Object
' jbClasserDestroy(JBCLASSER **) as void
'''  <remarks>
'''  </remarks>
Public Shared Sub jbClasserDestroy(
				 ByVal pclasser as JbClasser)

	If IsNothing (pclasser) then Throw New ArgumentNullException  ("pclasser cannot be Nothing")



	Dim pclasserPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pclasser) Then pclasserPTR = pclasser.Pointer

	LeptonicaSharp.Natives.jbClasserDestroy( pclasserPTR)

End Sub

' SRC\jbclass.c (1882, 1)
' jbDataSave(classer) as JbData
' jbDataSave(JBCLASSER *) as JBDATA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This routine stores the jbig2-type data required for<para/>
''' generating a lossy jbig2 version of the image.<para/>
''' It can be losslessly written to (and read from) two files.<para/>
''' (2) It generates and stores the mosaic of templates.<para/>
''' (3) It clones the Numa and Pta arrays, so these must all<para/>
''' be destroyed by the caller.<para/>
''' (4) Input 0 to use the default values for latticew and/or latticeh,<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>jbdata, or NULL on error</returns>
Public Shared Function jbDataSave(
				 ByVal classer as JbClasser) as JbData

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")



Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbDataSave( classer.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new JbData(_Result)
End Function

' SRC\jbclass.c (1922, 1)
' jbDataDestroy(pdata) as Object
' jbDataDestroy(JBDATA **) as void
'''  <remarks>
'''  </remarks>
Public Shared Sub jbDataDestroy(
				 ByVal pdata as JbData)

	If IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdata) Then pdataPTR = pdata.Pointer

	LeptonicaSharp.Natives.jbDataDestroy( pdataPTR)

End Sub

' SRC\jbclass.c (1954, 1)
' jbDataWrite(rootout, jbdata) as Integer
' jbDataWrite(const char *, JBDATA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serialization function that writes data in jbdata to file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="jbdata">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbDataWrite(
				 ByVal rootout as String, 
				 ByVal jbdata as JbData) as Integer

	If IsNothing (rootout) then Throw New ArgumentNullException  ("rootout cannot be Nothing")
	If IsNothing (jbdata) then Throw New ArgumentNullException  ("jbdata cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.jbDataWrite( rootout, jbdata.Pointer)

	Return _Result
End Function

' SRC\jbclass.c (2014, 1)
' jbDataRead(rootname) as JbData
' jbDataRead(const char *) as JBDATA *
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
' jbDataRender(data, debugflag) as Pixa
' jbDataRender(JBDATA *, l_int32) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <param name="debugflag">[in] - if TRUE, writes into 2 bpp pix and adds component outlines in color</param>
'''   <returns>pixa reconstruction of original images, using templates or NULL on error</returns>
Public Shared Function jbDataRender(
				 ByVal data as JbData, 
				 ByVal debugflag as Integer) as Pixa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



Dim dataPTR As IntPtr = IntPtr.Zero : If Not IsNothing(data) Then dataPTR = data.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.jbDataRender( data.Pointer, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\jbclass.c (2228, 1)
' jbGetULCorners(classer, pixs, boxa) as Integer
' jbGetULCorners(JBCLASSER *, PIX *, BOXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This computes the ptaul field, which has the global UL corners,<para/>
''' adjusted for each specific component, so that each component<para/>
''' can be replaced by the template for its class and have the<para/>
''' centroid in the template in the same position as the<para/>
''' centroid of the original connected component.  It is important<para/>
''' that this be done properly to avoid a wavy baseline in the<para/>
''' result.<para/>
''' (2) The array fields ptac and ptact give the centroids of<para/>
''' those components relative to the UL corner of each component.<para/>
''' Here, we compute the difference in each component, round to<para/>
''' nearest integer, and correct the box- is greater x and box- is greater y by<para/>
''' the appropriate integral difference.<para/>
''' (3) The templates and stored instances are all bordered.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - full res image</param>
'''  <param name="boxa">[in] - of c.c. bounding rectangles for this page</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetULCorners(
				 ByVal classer as JbClasser, 
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
' jbGetLLCorners(classer) as Integer
' jbGetLLCorners(JBCLASSER *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This computes the ptall field, which has the global LL corners,<para/>
''' adjusted for each specific component, so that each component<para/>
''' can be replaced by the template for its class and have the<para/>
''' centroid in the template in the same position as the<para/>
''' centroid of the original connected component. It is important<para/>
''' that this be done properly to avoid a wavy baseline in the result.<para/>
''' (2) It is computed here from the corresponding UL corners, where<para/>
''' the input templates and stored instances are all bordered.<para/>
''' This should be done after all pages have been processed.<para/>
''' (3) For proper substitution, the templates whose LL corners are<para/>
''' placed in these locations must be UN-bordered.<para/>
''' This is available for a realistic jbig2 encoder, which would<para/>
''' (1) encode each template without a border, and (2) encode<para/>
''' the position using the LL corner (rather than the UL<para/>
''' corner) because the difference between y-values<para/>
''' of successive instances is typically close to zero.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function jbGetLLCorners(
				 ByVal classer as JbClasser) as Integer

	If IsNothing (classer) then Throw New ArgumentNullException  ("classer cannot be Nothing")



Dim classerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(classer) Then classerPTR = classer.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.jbGetLLCorners( classer.Pointer)

	Return _Result
End Function

End Class
