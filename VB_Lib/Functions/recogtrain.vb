Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\recogtrain.c (212, 1)
' recogTrainLabeled(recog, pixs, box, text, debug) as Integer
' recogTrainLabeled(L_RECOG *, PIX *, BOX *, char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Training is restricted to the addition of a single<para/>
''' character in an arbitrary (e.g., UTF8) charset<para/>
''' (2) If box != null, it should represent the location in %pixs<para/>
''' of the character image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - in training mode</param>
'''  <param name="pixs">[in] - if depth  is greater  1, will be thresholded to 1 bpp</param>
'''  <param name="box">[in][optional] - cropping box</param>
'''  <param name="text">[in][optional] - if null, use text field in pix</param>
'''  <param name="debug">[in] - 1 to display images of samples not captured</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogTrainLabeled(
				 ByVal recog as L_Recog, 
				 ByVal pixs as Pix, 
				 Optional ByVal box as Box = Nothing, 
				 Optional ByVal text as String = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogTrainLabeled( recog.Pointer, pixs.Pointer, boxPTR, text, debug)

	Return _Result
End Function

' SRC\recogtrain.c (261, 1)
' recogProcessLabeled(recog, pixs, box, text, ppix) as Integer
' recogProcessLabeled(L_RECOG *, PIX *, BOX *, char *, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This crops and binarizes the input image, generating a pix<para/>
''' of one character where the charval is inserted into the pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - in training mode</param>
'''  <param name="pixs">[in] - if depth  is greater  1, will be thresholded to 1 bpp</param>
'''  <param name="box">[in][optional] - cropping box</param>
'''  <param name="text">[in][optional] - if null, use text field in pix</param>
'''  <param name="ppix">[out] - addr of pix, 1 bpp, labeled</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogProcessLabeled(
				 ByVal recog as L_Recog, 
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal text as String, 
				<Out()> ByRef ppix as Pix) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer
	Dim ppixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppix) Then ppixPTR = ppix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogProcessLabeled( recog.Pointer, pixs.Pointer, boxPTR, text, ppixPTR)
	if ppixPTR <> IntPtr.Zero then ppix = new Pix(ppixPTR)

	Return _Result
End Function

' SRC\recogtrain.c (352, 1)
' recogAddSample(recog, pix, debug) as Integer
' recogAddSample(L_RECOG *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix is 1 bpp, with the character string label embedded.<para/>
''' (2) The pixaa_u array of the recog is initialized to accept<para/>
''' up to 256 different classes.  When training is finished,<para/>
''' the arrays are truncated to the actual number of classes.<para/>
''' To pad an existing recog from the boot recognizers, training<para/>
''' is started again if samples from a new class are added,<para/>
''' the pixaa_u array is extended by adding a pixa to hold them.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="pix">[in] - a single character, 1 bpp</param>
'''  <param name="debug">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogAddSample(
				 ByVal recog as L_Recog, 
				 ByVal pix as Pix, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.recogAddSample( recog.Pointer, pix.Pointer, debug)

	Return _Result
End Function

' SRC\recogtrain.c (417, 1)
' recogModifyTemplate(recog, pixs) as Pix
' recogModifyTemplate(L_RECOG *, PIX *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="pixs">[in] - 1 bpp, to be optionally scaled and turned into strokes of fixed width</param>
'''   <returns>pixd   modified pix if OK, NULL on error</returns>
Public Shared Function recogModifyTemplate(
				 ByVal recog as L_Recog, 
				 ByVal pixs as Pix) as Pix

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogModifyTemplate( recog.Pointer, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\recogtrain.c (486, 1)
' recogAverageSamples(precog, debug) as Integer
' recogAverageSamples(L_RECOG **, l_int32) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is only called in two situations:<para/>
''' (a) When splitting characters using either the DID method<para/>
''' recogDecode() or the the greedy splitter<para/>
''' recogCorrelationBestRow()<para/>
''' (b) By a special recognizer that is used to remove outliers.<para/>
''' Both unscaled and scaled inputs are averaged.<para/>
''' (2) If the data in any class is nonexistent (no samples), or<para/>
''' very bad (no fg pixels in the average), or if the ratio<para/>
''' of max/min average unscaled class template heights is<para/>
''' greater than max_ht_ratio, this destroys the recog.<para/>
''' The caller must check the return value of the recog.<para/>
''' (3) Set debug = 1 to view the resulting templates and their centroids.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in] - addr of existing recog may be destroyed</param>
'''  <param name="debug">[in] - </param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function recogAverageSamples(
				 ByVal precog as List (of L_Recog), 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")

	Dim precogPTR As IntPtr = IntPtr.Zero ' : If Not IsNothing(precog) Then precogPTR = precog.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogAverageSamples( precogPTR, debug)

	Return _Result
End Function

' SRC\recogtrain.c (664, 1)
' pixaAccumulateSamples(pixa, pta, ppixd, px, py) as Integer
' pixaAccumulateSamples(PIXA *, PTA *, PIX **, l_float32 *, l_float32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates an aligned (by centroid) sum of the input pix.<para/>
''' (2) We use only the first 256 samples that's plenty.<para/>
''' (3) If pta is not input, we generate two tables, and discard<para/>
''' after use.  If this is called many times, it is better<para/>
''' to precompute the pta.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - of samples from the same class, 1 bpp</param>
'''  <param name="pta">[in][optional] - of centroids of the samples</param>
'''  <param name="ppixd">[out] - accumulated samples, 8 bpp</param>
'''  <param name="px">[out][optional] - average x coordinate of centroids</param>
'''  <param name="py">[out][optional] - average y coordinate of centroids</param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function pixaAccumulateSamples(
				 ByVal pixa as Pixa, 
				 ByVal pta as Pta, 
				<Out()> ByRef ppixd as Pix, 
				<Out()> Optional ByRef px as Single = Nothing, 
				<Out()> Optional ByRef py as Single = Nothing) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim ptaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pta) Then ptaPTR = pta.Pointer
	Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaAccumulateSamples( pixa.Pointer, ptaPTR, ppixdPTR, px, py)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\recogtrain.c (783, 1)
' recogTrainingFinished(precog, modifyflag, minsize, minfract) as Integer
' recogTrainingFinished(L_RECOG **, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This must be called after all training samples have been added.<para/>
''' (2) If the templates are not good enough, the recog input is destroyed.<para/>
''' (3) Usually, %modifyflag == 1, because we want to apply<para/>
''' recogModifyTemplate() to generate the actual templates<para/>
''' that will be used.  The one exception is when reading a<para/>
''' serialized recog: there we want to put the same set of<para/>
''' templates in both the unscaled and modified pixaa.<para/>
''' See recogReadStream() to see why we do this.<para/>
''' (4) See recogTemplatesAreOK() for %minsize and %minfract usage.<para/>
''' (5) The following things are done here:<para/>
''' (a) Allocate (or reallocate) storage for (possibly) modified<para/>
''' bitmaps, centroids, and fg areas.<para/>
''' (b) Generate the (possibly) modified bitmaps.<para/>
''' (c) Compute centroid and fg area data for both unscaled and<para/>
''' modified bitmaps.<para/>
''' (d) Truncate the pixaa, ptaa and numaa arrays down from<para/>
''' 256 to the actual size.<para/>
''' (6) Putting these operations here makes it simple to recompute<para/>
''' the recog with different modifications on the bitmaps.<para/>
''' (7) Call recogShowContent() to display the templates, both<para/>
''' unscaled and modified.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in] - addr of recog</param>
'''  <param name="modifyflag">[in] - 1 to use recogModifyTemplate() 0 otherwise</param>
'''  <param name="minsize">[in] - set to -1 for default</param>
'''  <param name="minfract">[in] - set to -1.0 for default</param>
'''   <returns>0 if OK, 1 on error (input recog will be destroyed)</returns>
Public Shared Function recogTrainingFinished(
				 ByVal precog as List (of L_Recog), 
				 ByVal modifyflag as Integer, 
				 ByVal minsize as Integer, 
				 ByVal minfract as Single) as Integer

	If IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")

	Dim precogPTR As IntPtr = IntPtr.Zero ' : If Not IsNothing(precog) Then precogPTR = precog.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogTrainingFinished( precogPTR, modifyflag, minsize, minfract)

	Return _Result
End Function

' SRC\recogtrain.c (970, 1)
' recogFilterPixaBySize(pixas, setsize, maxkeep, max_ht_ratio, pna) as Pixa
' recogFilterPixaBySize(PIXA *, l_int32, l_int32, l_float32, NUMA **) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The basic assumption is that the most common and larger<para/>
''' templates in each class are more likely to represent the<para/>
''' characters we are interested in.  For example, larger digits<para/>
''' are more likely to represent page numbers, and smaller digits<para/>
''' could be data in tables.  Therefore, we bias the first<para/>
''' stage of filtering toward the larger characters by removing<para/>
''' very small ones, and select based on proximity of the<para/>
''' remaining characters to median height.<para/>
''' (2) For each of the %setsize classes, order the templates<para/>
''' increasingly by height.  Take the rank 0.9 height.  Eliminate<para/>
''' all templates that are shorter by more than %max_ht_ratio.<para/>
''' Of the remaining ones, select up to %maxkeep that are closest<para/>
''' in rank order height to the median template.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - labeled templates</param>
'''  <param name="setsize">[in] - size of character set (number of classes)</param>
'''  <param name="maxkeep">[in] - max number of templates to keep in a class</param>
'''  <param name="max_ht_ratio">[in] - max allowed height ratio (see below)</param>
'''  <param name="pna">[out][optional] - debug output, giving the number in each class after filtering use NULL to skip</param>
'''   <returns>pixa   filtered templates, or NULL on error</returns>
Public Shared Function recogFilterPixaBySize(
				 ByVal pixas as Pixa, 
				 ByVal setsize as Integer, 
				 ByVal maxkeep as Integer, 
				 ByVal max_ht_ratio as Single, 
				<Out()> Optional ByRef pna as Numa = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim pnaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pna) Then pnaPTR = pna.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogFilterPixaBySize( pixas.Pointer, setsize, maxkeep, max_ht_ratio, pnaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaPTR <> IntPtr.Zero then pna = new Numa(pnaPTR)

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1041, 1)
' recogSortPixaByClass(pixa, setsize) as Pixaa
' recogSortPixaByClass(PIXA *, l_int32) as PIXAA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - labeled templates</param>
'''  <param name="setsize">[in] - size of character set (number of classes)</param>
'''   <returns>paa   pixaa where each pixa has templates for one class, or null on error</returns>
Public Shared Function recogSortPixaByClass(
				 ByVal pixa as Pixa, 
				 ByVal setsize as Integer) as Pixaa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogSortPixaByClass( pixa.Pointer, setsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\recogtrain.c (1081, 1)
' recogRemoveOutliers1(precog, minscore, mintarget, minsize, ppixsave, ppixrem) as Integer
' recogRemoveOutliers1(L_RECOG **, l_float32, l_int32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a convenience wrapper when using default parameters<para/>
''' for the recog.  See pixaRemoveOutliers1() for details.<para/>
''' (2) If this succeeds, the new recog replaces the input recog<para/>
''' if it fails, the input recog is destroyed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in] - addr of recog with unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score</param>
'''  <param name="mintarget">[in] - minimum desired number to retain if possible</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function recogRemoveOutliers1(
				 ByVal precog as List (of L_Recog), 
				 ByVal minscore as Single, 
				 ByVal mintarget as Integer, 
				 ByVal minsize as Integer, 
				<Out()> Optional ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional ByRef ppixrem as Pix = Nothing) as Integer

	If IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")

	Dim precogPTR As IntPtr = IntPtr.Zero ' : If Not IsNothing(precog) Then precogPTR = precog.Pointer
Dim ppixsavePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsave) Then ppixsavePTR = ppixsave.Pointer
Dim ppixremPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixrem) Then ppixremPTR = ppixrem.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogRemoveOutliers1( precogPTR, minscore, mintarget, minsize, ppixsavePTR, ppixremPTR)
	if ppixsavePTR <> IntPtr.Zero then ppixsave = new Pix(ppixsavePTR)
	if ppixremPTR <> IntPtr.Zero then ppixrem = new Pix(ppixremPTR)

	Return _Result
End Function

' SRC\recogtrain.c (1159, 1)
' pixaRemoveOutliers1(pixas, minscore, mintarget, minsize, ppixsave, ppixrem) as Pixa
' pixaRemoveOutliers1(PIXA *, l_float32, l_int32, l_int32, PIX **, PIX **) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Removing outliers is particularly important when recognition<para/>
''' goes against all the samples in the training set, as opposed<para/>
''' to the averages for each class.  The reason is that we get<para/>
''' an identification error if a mislabeled template is a best<para/>
''' match for an input sample.<para/>
''' (2) Because the score values depend strongly on the quality<para/>
''' of the character images, to avoid losing too many samples<para/>
''' we supplement a minimum score for retention with a score<para/>
''' necessary to acquire the minimum target number of templates.<para/>
''' To do this we are willing to use a lower threshold,<para/>
''' LOWER_SCORE_THRESHOLD, on the score.  Consequently, with<para/>
''' poor quality templates, we may keep samples with a score<para/>
''' less than %minscore, but never less than LOWER_SCORE_THRESHOLD.<para/>
''' And if the number of samples is less than %minsize, we do<para/>
''' not use any.<para/>
''' (3) This is meant to be used on a BAR, where the templates all<para/>
''' come from the same book use minscore ~0.75.<para/>
''' (4) Method: make a scaled recog from the input %pixas.  Then,<para/>
''' for each class: generate the averages, match each<para/>
''' scaled template against the average, and save unscaled<para/>
''' templates that had a sufficiently good match.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score use -1.0 for default.</param>
'''  <param name="mintarget">[in] - minimum desired number to retain if possible use -1 for default.</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class use -1 for default.</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>pixa   of unscaled templates to be kept, or NULL on error</returns>
Public Shared Function pixaRemoveOutliers1(
				 ByVal pixas as Pixa, 
				 ByVal minscore as Single, 
				 ByVal mintarget as Integer, 
				 ByVal minsize as Integer, 
				<Out()> Optional ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional ByRef ppixrem as Pix = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim ppixsavePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsave) Then ppixsavePTR = ppixsave.Pointer
Dim ppixremPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixrem) Then ppixremPTR = ppixrem.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRemoveOutliers1( pixas.Pointer, minscore, mintarget, minsize, ppixsavePTR, ppixremPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixsavePTR <> IntPtr.Zero then ppixsave = new Pix(ppixsavePTR)
	if ppixremPTR <> IntPtr.Zero then ppixrem = new Pix(ppixremPTR)

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1299, 1)
' recogRemoveOutliers2(precog, minscore, minsize, ppixsave, ppixrem) as Integer
' recogRemoveOutliers2(L_RECOG **, l_float32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a convenience wrapper when using default parameters<para/>
''' for the recog.  See pixaRemoveOutliers2() for details.<para/>
''' (2) If this succeeds, the new recog replaces the input recog<para/>
''' if it fails, the input recog is destroyed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in] - addr of recog with unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function recogRemoveOutliers2(
				 ByVal precog as List (of L_Recog), 
				 ByVal minscore as Single, 
				 ByVal minsize as Integer, 
				<Out()> Optional ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional ByRef ppixrem as Pix = Nothing) as Integer

	If IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")

	Dim precogPTR As IntPtr = IntPtr.Zero ' : If Not IsNothing(precog) Then precogPTR = precog.Pointer
Dim ppixsavePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsave) Then ppixsavePTR = ppixsave.Pointer
Dim ppixremPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixrem) Then ppixremPTR = ppixrem.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogRemoveOutliers2( precogPTR, minscore, minsize, ppixsavePTR, ppixremPTR)
	if ppixsavePTR <> IntPtr.Zero then ppixsave = new Pix(ppixsavePTR)
	if ppixremPTR <> IntPtr.Zero then ppixrem = new Pix(ppixremPTR)

	Return _Result
End Function

' SRC\recogtrain.c (1363, 1)
' pixaRemoveOutliers2(pixas, minscore, minsize, ppixsave, ppixrem) as Pixa
' pixaRemoveOutliers2(PIXA *, l_float32, l_int32, PIX **, PIX **) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Removing outliers is particularly important when recognition<para/>
''' goes against all the samples in the training set, as opposed<para/>
''' to the averages for each class.  The reason is that we get<para/>
''' an identification error if a mislabeled template is a best<para/>
''' match for an input sample.<para/>
''' (2) This method compares each template against the average templates<para/>
''' of each class, and discards any template that has a higher<para/>
''' correlation to a class different from its own.  It also<para/>
''' sets a lower bound on correlation scores with its class average.<para/>
''' (3) This is meant to be used on a BAR, where the templates all<para/>
''' come from the same book use minscore ~0.75.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score use -1.0 for default.</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class use -1 for default.</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>pixa   of unscaled templates to be kept, or NULL on error</returns>
Public Shared Function pixaRemoveOutliers2(
				 ByVal pixas as Pixa, 
				 ByVal minscore as Single, 
				 ByVal minsize as Integer, 
				<Out()> Optional ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional ByRef ppixrem as Pix = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim ppixsavePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixsave) Then ppixsavePTR = ppixsave.Pointer
Dim ppixremPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixrem) Then ppixremPTR = ppixrem.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRemoveOutliers2( pixas.Pointer, minscore, minsize, ppixsavePTR, ppixremPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixsavePTR <> IntPtr.Zero then ppixsave = new Pix(ppixsavePTR)
	if ppixremPTR <> IntPtr.Zero then ppixrem = new Pix(ppixremPTR)

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1488, 1)
' recogTrainFromBoot(recogboot, pixas, minscore, threshold, debug) as Pixa
' recogTrainFromBoot(L_RECOG *, PIXA *, l_float32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This takes %pixas of unscaled single characters and %recboot,<para/>
''' a bootstrep recognizer (BSR) that has been set up with parameters<para/>
''' scaleh: scale all templates to this height<para/>
''' linew: width of normalized strokes, or 0 if using<para/>
''' the input image<para/>
''' It modifies the pix in %pixas accordingly and correlates<para/>
''' with the templates in the BSR.  It returns those input<para/>
''' images in %pixas whose best correlation with the BSR is at<para/>
''' or above %minscore.  The returned pix have added text labels<para/>
''' for the text string of the class to which the best<para/>
''' correlated template belongs.<para/>
''' (2) Identification occurs in scaled mode (typically with h = 40),<para/>
''' optionally using a width-normalized line images derived<para/>
''' from those in %pixas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recogboot">[in] - labeled boot recognizer</param>
'''  <param name="pixas">[in] - set of unlabeled input characters</param>
'''  <param name="minscore">[in] - min score for accepting the example e.g., 0.75</param>
'''  <param name="threshold">[in] - for binarization, if needed</param>
'''  <param name="debug">[in] - 1 for debug output saved to recogboot 0 otherwise</param>
'''   <returns>pixad   labeled version of input pixas, trained on a BSR, or NULL on error</returns>
Public Shared Function recogTrainFromBoot(
				 ByVal recogboot as L_Recog, 
				 ByVal pixas as Pixa, 
				 ByVal minscore as Single, 
				 ByVal threshold as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pixa

	If IsNothing (recogboot) then Throw New ArgumentNullException  ("recogboot cannot be Nothing")
	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogTrainFromBoot( recogboot.Pointer, pixas.Pointer, minscore, threshold, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1592, 1)
' recogPadDigitTrainingSet(precog, scaleh, linew) as Integer
' recogPadDigitTrainingSet(L_RECOG **, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a no-op if padding is not needed.  However,<para/>
''' if it is, this replaces the input recog with a new recog,<para/>
''' padded appropriately with templates from a boot recognizer,<para/>
''' and set up with correlation templates derived from<para/>
''' %scaleh and %linew.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in,out] - trained if padding is needed, it is replaced by a a new padded recog</param>
'''  <param name="scaleh">[in] - must be  is greater  0 suggest ~40.</param>
'''  <param name="linew">[in] - use 0 for original scanned images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogPadDigitTrainingSet(
				 ByRef precog as L_Recog, 
				 ByVal scaleh as Integer, 
				 ByVal linew as Integer) as Integer

	Dim precogPTR As IntPtr = IntPtr.Zero : If Not IsNothing(precog) Then precogPTR = precog.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogPadDigitTrainingSet( precogPTR, scaleh, linew)
	if precogPTR <> IntPtr.Zero then precog = new L_Recog(precogPTR)

	Return _Result
End Function

' SRC\recogtrain.c (1650, 1)
' recogIsPaddingNeeded(recog, psa) as Integer
' recogIsPaddingNeeded(L_RECOG *, SARRAY **) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a string array in  and sa containing character values<para/>
''' for which extra templates are needed this sarray is<para/>
''' used by recogGetPadTemplates().  It returns NULL<para/>
''' if no padding templates are needed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - trained</param>
'''  <param name="psa">[out] - addr of returned string containing text value</param>
'''   <returns>1 on error 0 if OK, whether or not additional padding templates are required.</returns>
Public Shared Function recogIsPaddingNeeded(
				 ByVal recog as L_Recog, 
				<Out()> ByRef psa as Sarray) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")

	Dim psaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(psa) Then psaPTR = psa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogIsPaddingNeeded( recog.Pointer, psaPTR)
	if psaPTR <> IntPtr.Zero then psa = new Sarray(psaPTR)

	Return _Result
End Function

' SRC\recogtrain.c (1768, 1)
' recogAddDigitPadTemplates(recog, sa) as Pixa
' recogAddDigitPadTemplates(L_RECOG *, SARRAY *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Call recogIsPaddingNeeded() first, which returns %sa of<para/>
''' template text strings for classes where more templates<para/>
''' are needed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - trained</param>
'''  <param name="sa">[in] - set of text strings that need to be padded</param>
'''   <returns>pixa   of all templates from %recog and the additional pad templates from a boot recognizer or NULL on error</returns>
Public Shared Function recogAddDigitPadTemplates(
				 ByVal recog as L_Recog, 
				 ByVal sa as Sarray) as Pixa

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogAddDigitPadTemplates( recog.Pointer, sa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1876, 1)
' recogMakeBootDigitRecog(scaleh, linew, maxyshift, debug) as L_Recog
' recogMakeBootDigitRecog(l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This takes a set of pre-computed, labeled pixa of single<para/>
''' digits, and generates a recognizer where the character templates<para/>
''' that will be used are derived from the boot-generated pixa:<para/>
''' - extending by replicating the set with different widths,<para/>
''' keeping the height the same<para/>
''' - scaling (isotropically to fixed height)<para/>
''' - optionally generating a skeleton and thickening so that<para/>
''' all strokes have the same width.<para/>
''' (2) The resulting templates are scaled versions of either the<para/>
''' input bitmaps or images with fixed line widths.  To use the<para/>
''' input bitmaps, set %linew = 0 otherwise, set %linew to the<para/>
''' desired line width.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="scaleh">[in] - scale all heights to this typ. use 40</param>
'''  <param name="linew">[in] - normalized line width typ. use 5 0 to skip</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment typically 0 or 1</param>
'''  <param name="debug">[in] - 1 for showing templates 0 otherwise</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogMakeBootDigitRecog(
				 ByVal scaleh as Integer, 
				 ByVal linew as Integer, 
				 ByVal maxyshift as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as L_Recog

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogMakeBootDigitRecog( scaleh, linew, maxyshift, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogtrain.c (1911, 1)
' recogMakeBootDigitTemplates(debug) as Pixa
' recogMakeBootDigitTemplates(l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See recogMakeBootDigitRecog().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="debug">[in] - 1 for display of templates</param>
'''   <returns>pixa   of templates or NULL on error</returns>
Public Shared Function recogMakeBootDigitTemplates(
				 ByVal debug as Enumerations.DebugOnOff) as Pixa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogMakeBootDigitTemplates( debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\recogtrain.c (1962, 1)
' recogShowContent(fp, recog, index, display) as Integer
' recogShowContent(FILE *, L_RECOG *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file  stream</param>
'''  <param name="recog">[in] - </param>
'''  <param name="index">[in] - for naming of output files of template images</param>
'''  <param name="display">[in] - 1 for showing template images, 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogShowContent(
				 ByVal fp as FILE, 
				 ByVal recog as L_Recog, 
				 ByVal index as Integer, 
				 ByVal display as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.recogShowContent( fp.Pointer, recog.Pointer, index, display)

	Return _Result
End Function

' SRC\recogtrain.c (2045, 1)
' recogDebugAverages(precog, debug) as Integer
' recogDebugAverages(L_RECOG **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates an image that pairs each of the input images used<para/>
''' in training with the average template that it is best<para/>
''' correlated to.  This is written into the recog.<para/>
''' (2) It also generates pixa_tr of all the input training images,<para/>
''' which can be used, e.g., in recogShowMatchesInRange().<para/>
''' (3) Destroys the recog if the averaging function finds any bad classes.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in] - addr of recog</param>
'''  <param name="debug">[in] - 0 no output 1 for images 2 for text 3 for both</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogDebugAverages(
				 ByVal precog as List (of L_Recog), 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")

	Dim precogPTR As IntPtr = IntPtr.Zero ' : If Not IsNothing(precog) Then precogPTR = precog.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.recogDebugAverages( precogPTR, debug)

	Return _Result
End Function

' SRC\recogtrain.c (2123, 1)
' recogShowAverageTemplates(recog) as Integer
' recogShowAverageTemplates(L_RECOG *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This debug routine generates a display of the averaged templates,<para/>
''' both scaled and unscaled, with the centroid visible in red.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function recogShowAverageTemplates(
				 ByVal recog as L_Recog) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.recogShowAverageTemplates( recog.Pointer)

	Return _Result
End Function

' SRC\recogtrain.c (2311, 1)
' recogShowMatchesInRange(recog, pixa, minscore, maxscore, display) as Integer
' recogShowMatchesInRange(L_RECOG *, PIXA *, l_float32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives a visual output of the best matches for a given<para/>
''' range of scores.  Each pair of images can optionally be<para/>
''' labeled with the index of the best match and the correlation.<para/>
''' (2) To use this, save a set of 1 bpp images (labeled or<para/>
''' unlabeled) that can be given to a recognizer in a pixa.<para/>
''' Then call this function with the pixa and parameters<para/>
''' to filter a range of scores.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="pixa">[in] - of 1 bpp images to match</param>
'''  <param name="minscore">[in] - range to include output</param>
'''  <param name="maxscore">[in] - range to include output</param>
'''  <param name="display">[in] - to display the result</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogShowMatchesInRange(
				 ByVal recog as L_Recog, 
				 ByVal pixa as Pixa, 
				 ByVal minscore as Single, 
				 ByVal maxscore as Single, 
				 ByVal display as Integer) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.recogShowMatchesInRange( recog.Pointer, pixa.Pointer, minscore, maxscore, display)

	Return _Result
End Function

' SRC\recogtrain.c (2405, 1)
' recogShowMatch(recog, pix1, pix2, box, index, score) as Pix
' recogShowMatch(L_RECOG *, PIX *, PIX *, BOX *, l_int32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pix1 can be one of these:<para/>
''' (a) The input pix alone, which can be either a single character<para/>
''' (box == NULL) or several characters that need to be<para/>
''' segmented.  If more than character is present, the box<para/>
''' region is displayed with an outline.<para/>
''' (b) Both the input pix and the matching template.  In this case,<para/>
''' pix2 and box will both be null.<para/>
''' (2) If the bmf has been made (by a call to recogMakeBmf())<para/>
''' and the index  is greater = 0, the text field, match score and index<para/>
''' will be rendered otherwise their values will be ignored.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="pix1">[in] - input pix several possibilities</param>
'''  <param name="pix2">[in][optional] - matching template</param>
'''  <param name="box">[in][optional] - region in pix1 for which pix2 matches</param>
'''  <param name="index">[in] - index of matching template use -1 to disable printing</param>
'''  <param name="score">[in] - score of match</param>
'''   <returns>pixd pair of images, showing input pix and best template, optionally with matching information, or NULL on error.</returns>
Public Shared Function recogShowMatch(
				 ByVal recog as L_Recog, 
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal box as Box, 
				 ByVal index as Integer, 
				 ByVal score as Single) as Pix

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")

	Dim pix2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix2) Then pix2PTR = pix2.Pointer
	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogShowMatch( recog.Pointer, pix1.Pointer, pix2PTR, boxPTR, index, score)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
