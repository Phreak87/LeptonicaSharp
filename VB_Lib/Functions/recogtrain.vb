Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' recogtrain.c (212, 1)
' recogTrainLabeled(recog, pixs, box, text, debug) as Integer
' recogTrainLabeled(L_RECOG *, PIX *, BOX *, char *, l_int32) as l_ok
'''  <summary>
''' (1) Training is restricted to the addition of a single
'''character in an arbitrary (e.g., UTF8) charset<para/>
'''
'''(2) If box != null, it should represent the location in %pixs
'''of the character image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogTrainLabeled/*"/>
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
				Optional ByVal text as String = "", 
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as Integer = Natives.recogTrainLabeled(recog.Pointer, pixs.Pointer, boxPtr,   text,   debug)
	
	return _Result
End Function

' recogtrain.c (261, 1)
' recogProcessLabeled(recog, pixs, box, text, ppix) as Integer
' recogProcessLabeled(L_RECOG *, PIX *, BOX *, char *, PIX **) as l_ok
'''  <summary>
''' (1) This crops and binarizes the input image, generating a pix
'''of one character where the charval is inserted into the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogProcessLabeled/*"/>
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
				<Out()>  ByRef ppix as Pix) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer
	Dim ppixPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogProcessLabeled(recog.Pointer, pixs.Pointer, boxPtr,   text, ppixPtr)
	
	if ppixPtr = IntPtr.Zero then ppix = Nothing else ppix = new Pix(ppixPtr)
	return _Result
End Function

' recogtrain.c (352, 1)
' recogAddSample(recog, pix, debug) as Integer
' recogAddSample(L_RECOG *, PIX *, l_int32) as l_ok
'''  <summary>
''' (1) The pix is 1 bpp, with the character string label embedded.<para/>
'''
'''(2) The pixaa_u array of the recog is initialized to accept
'''up to 256 different classes.  When training is finished,
'''the arrays are truncated to the actual number of classes.
'''To pad an existing recog from the boot recognizers, training
'''is started again if samples from a new class are added,
'''the pixaa_u array is extended by adding a pixa to hold them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogAddSample/*"/>
'''  <param name="recog">[in] - </param>
'''  <param name="pix">[in] - a single character, 1 bpp</param>
'''  <param name="debug">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogAddSample(
				ByVal recog as L_Recog, 
				ByVal pix as Pix, 
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.recogAddSample(recog.Pointer, pix.Pointer,   debug)
	
	return _Result
End Function

' recogtrain.c (417, 1)
' recogModifyTemplate(recog, pixs) as Pix
' recogModifyTemplate(L_RECOG *, PIX *) as PIX *
'''  <summary>
''' recogModifyTemplate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogModifyTemplate/*"/>
'''  <param name="recog">[in] - </param>
'''  <param name="pixs">[in] - 1 bpp, to be optionally scaled and turned into strokes of fixed width</param>
'''   <returns>pixd   modified pix if OK, NULL on error</returns>
Public Shared Function recogModifyTemplate(
				ByVal recog as L_Recog, 
				ByVal pixs as Pix) as Pix


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.recogModifyTemplate(recog.Pointer, pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' recogtrain.c (486, 1)
' recogAverageSamples(precog, debug) as Integer
' recogAverageSamples(L_RECOG **, l_int32) as l_int32
'''  <summary>
''' (1) This is only called in two situations:
'''(a) When splitting characters using either the DID method
'''recogDecode() or the the greedy splitter
'''recogCorrelationBestRow()
'''(b) By a special recognizer that is used to remove outliers.
'''Both unscaled and scaled inputs are averaged.<para/>
'''
'''(2) If the data in any class is nonexistent (no samples), or
'''very bad (no fg pixels in the average), or if the ratio
'''of max/min average unscaled class template heights is
'''greater than max_ht_ratio, this destroys the recog.
'''The caller must check the return value of the recog.<para/>
'''
'''(3) Set debug = 1 to view the resulting templates and their centroids.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogAverageSamples/*"/>
'''  <param name="precog">[in] - addr of existing recog may be destroyed</param>
'''  <param name="debug">[in] - </param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function recogAverageSamples(
				ByVal precog as List(of L_Recog), 
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")
	Dim precogPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogAverageSamples(precogPtr,   debug)
	
	return _Result
End Function

' recogtrain.c (664, 1)
' pixaAccumulateSamples(pixa, pta, ppixd, px, py) as Integer
' pixaAccumulateSamples(PIXA *, PTA *, PIX **, l_float32 *, l_float32 *) as l_int32
'''  <summary>
''' (1) This generates an aligned (by centroid) sum of the input pix.<para/>
'''
'''(2) We use only the first 256 samples that's plenty.<para/>
'''
'''(3) If pta is not input, we generate two tables, and discard
'''after use.  If this is called many times, it is better
'''to precompute the pta.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAccumulateSamples/*"/>
'''  <param name="pixa">[in] - of samples from the same class, 1 bpp</param>
'''  <param name="pta">[in][optional] - of centroids of the samples</param>
'''  <param name="ppixd">[out] - accumulated samples, 8 bpp</param>
'''  <param name="px">[out][optional] - average x coordinate of centroids</param>
'''  <param name="py">[out][optional] - average y coordinate of centroids</param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function pixaAccumulateSamples(
				ByVal pixa as Pixa, 
				ByVal pta as Pta, 
				<Out()>  ByRef ppixd as Pix, 
				<Out()> Optional  ByRef px as Single = 0f, 
				<Out()> Optional  ByRef py as Single = 0f) as Integer


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim ptaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pta) Then ptaPtr = pta.Pointer
	Dim ppixdPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixaAccumulateSamples(pixa.Pointer, ptaPtr, ppixdPtr,   px,   py)
	
	if ppixdPtr = IntPtr.Zero then ppixd = Nothing else ppixd = new Pix(ppixdPtr)
	return _Result
End Function

' recogtrain.c (783, 1)
' recogTrainingFinished(precog, modifyflag, minsize, minfract) as Integer
' recogTrainingFinished(L_RECOG **, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' (1) This must be called after all training samples have been added.<para/>
'''
'''(2) If the templates are not good enough, the recog input is destroyed.<para/>
'''
'''(3) Usually, %modifyflag == 1, because we want to apply
'''recogModifyTemplate() to generate the actual templates
'''that will be used.  The one exception is when reading a
'''serialized recog: there we want to put the same set of
'''templates in both the unscaled and modified pixaa.
'''See recogReadStream() to see why we do this.<para/>
'''
'''(4) See recogTemplatesAreOK() for %minsize and %minfract usage.<para/>
'''
'''(5) The following things are done here:
'''(a) Allocate (or reallocate) storage for (possibly) modified
'''bitmaps, centroids, and fg areas.
'''(b) Generate the (possibly) modified bitmaps.
'''(c) Compute centroid and fg area data for both unscaled and
'''modified bitmaps.
'''(d) Truncate the pixaa, ptaa and numaa arrays down from
'''256 to the actual size.<para/>
'''
'''(6) Putting these operations here makes it simple to recompute
'''the recog with different modifications on the bitmaps.<para/>
'''
'''(7) Call recogShowContent() to display the templates, both
'''unscaled and modified.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogTrainingFinished/*"/>
'''  <param name="precog">[in] - addr of recog</param>
'''  <param name="modifyflag">[in] - 1 to use recogModifyTemplate() 0 otherwise</param>
'''  <param name="minsize">[in] - set to -1 for default</param>
'''  <param name="minfract">[in] - set to -1.0 for default</param>
'''   <returns>0 if OK, 1 on error (input recog will be destroyed)</returns>
Public Shared Function recogTrainingFinished(
				ByVal precog as List(of L_Recog), 
				ByVal modifyflag as Integer, 
				ByVal minsize as Integer, 
				ByVal minfract as Single) as Integer


if IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")
	Dim precogPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogTrainingFinished(precogPtr,   modifyflag,   minsize,   minfract)
	
	return _Result
End Function

' recogtrain.c (970, 1)
' recogFilterPixaBySize(pixas, setsize, maxkeep, max_ht_ratio, pna) as Pixa
' recogFilterPixaBySize(PIXA *, l_int32, l_int32, l_float32, NUMA **) as PIXA *
'''  <summary>
''' (1) The basic assumption is that the most common and larger
'''templates in each class are more likely to represent the
'''characters we are interested in.  For example, larger digits
'''are more likely to represent page numbers, and smaller digits
'''could be data in tables.  Therefore, we bias the first
'''stage of filtering toward the larger characters by removing
'''very small ones, and select based on proximity of the
'''remaining characters to median height.<para/>
'''
'''(2) For each of the %setsize classes, order the templates
'''increasingly by height.  Take the rank 0.9 height.  Eliminate
'''all templates that are shorter by more than %max_ht_ratio.
'''Of the remaining ones, select up to %maxkeep that are closest
'''in rank order height to the median template.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogFilterPixaBySize/*"/>
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
				<Out()> Optional  ByRef pna as Numa = Nothing) as Pixa


if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim pnaPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.recogFilterPixaBySize(pixas.Pointer,   setsize,   maxkeep,   max_ht_ratio, pnaPtr)
	
	if pnaPtr = IntPtr.Zero then pna = Nothing else pna = new Numa(pnaPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1041, 1)
' recogSortPixaByClass(pixa, setsize) as Pixaa
' recogSortPixaByClass(PIXA *, l_int32) as PIXAA *
'''  <summary>
''' recogSortPixaByClass()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSortPixaByClass/*"/>
'''  <param name="pixa">[in] - labeled templates</param>
'''  <param name="setsize">[in] - size of character set (number of classes)</param>
'''   <returns>paa   pixaa where each pixa has templates for one class, or null on error</returns>
Public Shared Function recogSortPixaByClass(
				ByVal pixa as Pixa, 
				ByVal setsize as Integer) as Pixaa


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.recogSortPixaByClass(pixa.Pointer,   setsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixaa(_Result)
End Function

' recogtrain.c (1081, 1)
' recogRemoveOutliers1(precog, minscore, mintarget, minsize, ppixsave, ppixrem) as Integer
' recogRemoveOutliers1(L_RECOG **, l_float32, l_int32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' (1) This is a convenience wrapper when using default parameters
'''for the recog.  See pixaRemoveOutliers1() for details.<para/>
'''
'''(2) If this succeeds, the new recog replaces the input recog
'''if it fails, the input recog is destroyed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogRemoveOutliers1/*"/>
'''  <param name="precog">[in] - addr of recog with unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score</param>
'''  <param name="mintarget">[in] - minimum desired number to retain if possible</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function recogRemoveOutliers1(
				ByVal precog as List(of L_Recog), 
				ByVal minscore as Single, 
				ByVal mintarget as Integer, 
				ByVal minsize as Integer, 
				<Out()> Optional  ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional  ByRef ppixrem as Pix = Nothing) as Integer


if IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")
	Dim precogPtr as IntPtr = IntPtr.Zero
	Dim ppixsavePtr as IntPtr = IntPtr.Zero
	Dim ppixremPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogRemoveOutliers1(precogPtr,   minscore,   mintarget,   minsize, ppixsavePtr, ppixremPtr)
	
	if ppixsavePtr = IntPtr.Zero then ppixsave = Nothing else ppixsave = new Pix(ppixsavePtr)
	if ppixremPtr = IntPtr.Zero then ppixrem = Nothing else ppixrem = new Pix(ppixremPtr)
	return _Result
End Function

' recogtrain.c (1159, 1)
' pixaRemoveOutliers1(pixas, minscore, mintarget, minsize, ppixsave, ppixrem) as Pixa
' pixaRemoveOutliers1(PIXA *, l_float32, l_int32, l_int32, PIX **, PIX **) as PIXA *
'''  <summary>
''' (1) Removing outliers is particularly important when recognition
'''goes against all the samples in the training set, as opposed
'''to the averages for each class.  The reason is that we get
'''an identification error if a mislabeled template is a best
'''match for an input sample.<para/>
'''
'''(2) Because the score values depend strongly on the quality
'''of the character images, to avoid losing too many samples
'''we supplement a minimum score for retention with a score
'''necessary to acquire the minimum target number of templates.
'''To do this we are willing to use a lower threshold,
'''LOWER_SCORE_THRESHOLD, on the score.  Consequently, with
'''poor quality templates, we may keep samples with a score
'''less than %minscore, but never less than LOWER_SCORE_THRESHOLD.
'''And if the number of samples is less than %minsize, we do
'''not use any.<para/>
'''
'''(3) This is meant to be used on a BAR, where the templates all
'''come from the same book use minscore ~0.75.<para/>
'''
'''(4) Method: make a scaled recog from the input %pixas.  Then,
'''for each class: generate the averages, match each
'''scaled template against the average, and save unscaled
'''templates that had a sufficiently good match.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRemoveOutliers1/*"/>
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
				<Out()> Optional  ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional  ByRef ppixrem as Pix = Nothing) as Pixa


if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim ppixsavePtr as IntPtr = IntPtr.Zero
	Dim ppixremPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixaRemoveOutliers1(pixas.Pointer,   minscore,   mintarget,   minsize, ppixsavePtr, ppixremPtr)
	
	if ppixsavePtr = IntPtr.Zero then ppixsave = Nothing else ppixsave = new Pix(ppixsavePtr)
	if ppixremPtr = IntPtr.Zero then ppixrem = Nothing else ppixrem = new Pix(ppixremPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1299, 1)
' recogRemoveOutliers2(precog, minscore, minsize, ppixsave, ppixrem) as Integer
' recogRemoveOutliers2(L_RECOG **, l_float32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' (1) This is a convenience wrapper when using default parameters
'''for the recog.  See pixaRemoveOutliers2() for details.<para/>
'''
'''(2) If this succeeds, the new recog replaces the input recog
'''if it fails, the input recog is destroyed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogRemoveOutliers2/*"/>
'''  <param name="precog">[in] - addr of recog with unscaled labeled templates</param>
'''  <param name="minscore">[in] - keep everything with at least this score</param>
'''  <param name="minsize">[in] - minimum number of samples required for a class</param>
'''  <param name="ppixsave">[out][optional debug] - saved templates, with scores</param>
'''  <param name="ppixrem">[out][optional debug] - removed templates, with scores</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function recogRemoveOutliers2(
				ByVal precog as List(of L_Recog), 
				ByVal minscore as Single, 
				ByVal minsize as Integer, 
				<Out()> Optional  ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional  ByRef ppixrem as Pix = Nothing) as Integer


if IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")
	Dim precogPtr as IntPtr = IntPtr.Zero
	Dim ppixsavePtr as IntPtr = IntPtr.Zero
	Dim ppixremPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogRemoveOutliers2(precogPtr,   minscore,   minsize, ppixsavePtr, ppixremPtr)
	
	if ppixsavePtr = IntPtr.Zero then ppixsave = Nothing else ppixsave = new Pix(ppixsavePtr)
	if ppixremPtr = IntPtr.Zero then ppixrem = Nothing else ppixrem = new Pix(ppixremPtr)
	return _Result
End Function

' recogtrain.c (1363, 1)
' pixaRemoveOutliers2(pixas, minscore, minsize, ppixsave, ppixrem) as Pixa
' pixaRemoveOutliers2(PIXA *, l_float32, l_int32, PIX **, PIX **) as PIXA *
'''  <summary>
''' (1) Removing outliers is particularly important when recognition
'''goes against all the samples in the training set, as opposed
'''to the averages for each class.  The reason is that we get
'''an identification error if a mislabeled template is a best
'''match for an input sample.<para/>
'''
'''(2) This method compares each template against the average templates
'''of each class, and discards any template that has a higher
'''correlation to a class different from its own.  It also
'''sets a lower bound on correlation scores with its class average.<para/>
'''
'''(3) This is meant to be used on a BAR, where the templates all
'''come from the same book use minscore ~0.75.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRemoveOutliers2/*"/>
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
				<Out()> Optional  ByRef ppixsave as Pix = Nothing, 
				<Out()> Optional  ByRef ppixrem as Pix = Nothing) as Pixa


if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim ppixsavePtr as IntPtr = IntPtr.Zero
	Dim ppixremPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixaRemoveOutliers2(pixas.Pointer,   minscore,   minsize, ppixsavePtr, ppixremPtr)
	
	if ppixsavePtr = IntPtr.Zero then ppixsave = Nothing else ppixsave = new Pix(ppixsavePtr)
	if ppixremPtr = IntPtr.Zero then ppixrem = Nothing else ppixrem = new Pix(ppixremPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1488, 1)
' recogTrainFromBoot(recogboot, pixas, minscore, threshold, debug) as Pixa
' recogTrainFromBoot(L_RECOG *, PIXA *, l_float32, l_int32, l_int32) as PIXA *
'''  <summary>
''' (1) This takes %pixas of unscaled single characters and %recboot,
'''a bootstrep recognizer (BSR) that has been set up with parameters
'''scaleh: scale all templates to this height
'''linew: width of normalized strokes, or 0 if using
'''the input image
'''It modifies the pix in %pixas accordingly and correlates
'''with the templates in the BSR.  It returns those input
'''images in %pixas whose best correlation with the BSR is at
'''or above %minscore.  The returned pix have added text labels
'''for the text string of the class to which the best
'''correlated template belongs.<para/>
'''
'''(2) Identification occurs in scaled mode (typically with h = 40),
'''optionally using a width-normalized line images derived
'''from those in %pixas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogTrainFromBoot/*"/>
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
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as Pixa


if IsNothing (recogboot) then Throw New ArgumentNullException  ("recogboot cannot be Nothing")
		if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim _Result as IntPtr = Natives.recogTrainFromBoot(recogboot.Pointer, pixas.Pointer,   minscore,   threshold,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1592, 1)
' recogPadDigitTrainingSet(precog, scaleh, linew) as Integer
' recogPadDigitTrainingSet(L_RECOG **, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This is a no-op if padding is not needed.  However,
'''if it is, this replaces the input recog with a new recog,
'''padded appropriately with templates from a boot recognizer,
'''and set up with correlation templates derived from
'''%scaleh and %linew.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogPadDigitTrainingSet/*"/>
'''  <param name="precog">[in,out] - trained if padding is needed, it is replaced by a a new padded recog</param>
'''  <param name="scaleh">[in] - must be  is greater  0 suggest ~40.</param>
'''  <param name="linew">[in] - use 0 for original scanned images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogPadDigitTrainingSet(
				ByRef precog as L_Recog, 
				ByVal scaleh as Integer, 
				ByVal linew as Integer) as Integer


	Dim precogPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(precog) Then precogPtr = precog.Pointer

	Dim _Result as Integer = Natives.recogPadDigitTrainingSet( precogPtr,   scaleh,   linew)
	
	if precogPtr = IntPtr.Zero then precog = Nothing else precog = new L_Recog(precogPtr)
	return _Result
End Function

' recogtrain.c (1650, 1)
' recogIsPaddingNeeded(recog, psa) as Integer
' recogIsPaddingNeeded(L_RECOG *, SARRAY **) as l_int32
'''  <summary>
''' (1) This returns a string array in [and]sa containing character values
'''for which extra templates are needed this sarray is
'''used by recogGetPadTemplates().  It returns NULL
'''if no padding templates are needed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIsPaddingNeeded/*"/>
'''  <param name="recog">[in] - trained</param>
'''  <param name="psa">[out] - addr of returned string containing text value</param>
'''   <returns>1 on error 0 if OK, whether or not additional padding templates are required.</returns>
Public Shared Function recogIsPaddingNeeded(
				ByVal recog as L_Recog, 
				<Out()>  ByRef psa as Sarray) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	Dim psaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogIsPaddingNeeded(recog.Pointer, psaPtr)
	
	if psaPtr = IntPtr.Zero then psa = Nothing else psa = new Sarray(psaPtr)
	return _Result
End Function

' recogtrain.c (1768, 1)
' recogAddDigitPadTemplates(recog, sa) as Pixa
' recogAddDigitPadTemplates(L_RECOG *, SARRAY *) as PIXA *
'''  <summary>
''' (1) Call recogIsPaddingNeeded() first, which returns %sa of
'''template text strings for classes where more templates
'''are needed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogAddDigitPadTemplates/*"/>
'''  <param name="recog">[in] - trained</param>
'''  <param name="sa">[in] - set of text strings that need to be padded</param>
'''   <returns>pixa   of all templates from %recog and the additional pad templates from a boot recognizer or NULL on error</returns>
Public Shared Function recogAddDigitPadTemplates(
				ByVal recog as L_Recog, 
				ByVal sa as Sarray) as Pixa


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	Dim _Result as IntPtr = Natives.recogAddDigitPadTemplates(recog.Pointer, sa.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1876, 1)
' recogMakeBootDigitRecog(scaleh, linew, maxyshift, debug) as L_Recog
' recogMakeBootDigitRecog(l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' (1) This takes a set of pre-computed, labeled pixa of single
'''digits, and generates a recognizer where the character templates
'''that will be used are derived from the boot-generated pixa:
'''- extending by replicating the set with different widths,
'''keeping the height the same
'''- scaling (isotropically to fixed height)
'''- optionally generating a skeleton and thickening so that
'''all strokes have the same width.<para/>
'''
'''(2) The resulting templates are scaled versions of either the
'''input bitmaps or images with fixed line widths.  To use the
'''input bitmaps, set %linew = 0 otherwise, set %linew to the
'''desired line width.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogMakeBootDigitRecog/*"/>
'''  <param name="scaleh">[in] - scale all heights to this typ. use 40</param>
'''  <param name="linew">[in] - normalized line width typ. use 5 0 to skip</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment typically 0 or 1</param>
'''  <param name="debug">[in] - 1 for showing templates 0 otherwise</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogMakeBootDigitRecog(
				ByVal scaleh as Integer, 
				ByVal linew as Integer, 
				ByVal maxyshift as Integer, 
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as L_Recog


	Dim _Result as IntPtr = Natives.recogMakeBootDigitRecog(  scaleh,   linew,   maxyshift,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Recog(_Result)
End Function

' recogtrain.c (1911, 1)
' recogMakeBootDigitTemplates(debug) as Pixa
' recogMakeBootDigitTemplates(l_int32) as PIXA *
'''  <summary>
''' (1) See recogMakeBootDigitRecog().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogMakeBootDigitTemplates/*"/>
'''  <param name="debug">[in] - 1 for display of templates</param>
'''   <returns>pixa   of templates or NULL on error</returns>
Public Shared Function recogMakeBootDigitTemplates(
				ByVal debug as Enumerations.DebugOnOff) as Pixa


	Dim _Result as IntPtr = Natives.recogMakeBootDigitTemplates(  debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' recogtrain.c (1962, 1)
' recogShowContent(fp, recog, index, display) as Integer
' recogShowContent(FILE *, L_RECOG *, l_int32, l_int32) as l_ok
'''  <summary>
''' recogShowContent()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogShowContent/*"/>
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


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	Dim _Result as Integer = Natives.recogShowContent(fp.Pointer, recog.Pointer,   index,   display)
	
	return _Result
End Function

' recogtrain.c (2045, 1)
' recogDebugAverages(precog, debug) as Integer
' recogDebugAverages(L_RECOG **, l_int32) as l_ok
'''  <summary>
''' (1) Generates an image that pairs each of the input images used
'''in training with the average template that it is best
'''correlated to.  This is written into the recog.<para/>
'''
'''(2) It also generates pixa_tr of all the input training images,
'''which can be used, e.g., in recogShowMatchesInRange().<para/>
'''
'''(3) Destroys the recog if the averaging function finds any bad classes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogDebugAverages/*"/>
'''  <param name="precog">[in] - addr of recog</param>
'''  <param name="debug">[in] - 0 no output 1 for images 2 for text 3 for both</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogDebugAverages(
				ByVal precog as List(of L_Recog), 
				Optional ByVal debug as Enumerations.DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (precog) then Throw New ArgumentNullException  ("precog cannot be Nothing")
	Dim precogPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.recogDebugAverages(precogPtr,   debug)
	
	return _Result
End Function

' recogtrain.c (2123, 1)
' recogShowAverageTemplates(recog) as Integer
' recogShowAverageTemplates(L_RECOG *) as l_int32
'''  <summary>
''' (1) This debug routine generates a display of the averaged templates,
'''both scaled and unscaled, with the centroid visible in red.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogShowAverageTemplates/*"/>
'''  <param name="recog">[in] - </param>
'''   <returns>0 on success, 1 on failure</returns>
Public Shared Function recogShowAverageTemplates(
				ByVal recog as L_Recog) as Integer


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	Dim _Result as Integer = Natives.recogShowAverageTemplates(recog.Pointer)
	
	return _Result
End Function

' recogtrain.c (2311, 1)
' recogShowMatchesInRange(recog, pixa, minscore, maxscore, display) as Integer
' recogShowMatchesInRange(L_RECOG *, PIXA *, l_float32, l_float32, l_int32) as l_ok
'''  <summary>
''' (1) This gives a visual output of the best matches for a given
'''range of scores.  Each pair of images can optionally be
'''labeled with the index of the best match and the correlation.<para/>
'''
'''(2) To use this, save a set of 1 bpp images (labeled or
'''unlabeled) that can be given to a recognizer in a pixa.
'''Then call this function with the pixa and parameters
'''to filter a range of scores.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogShowMatchesInRange/*"/>
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


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as Integer = Natives.recogShowMatchesInRange(recog.Pointer, pixa.Pointer,   minscore,   maxscore,   display)
	
	return _Result
End Function

' recogtrain.c (2405, 1)
' recogShowMatch(recog, pix1, pix2, box, index, score) as Pix
' recogShowMatch(L_RECOG *, PIX *, PIX *, BOX *, l_int32, l_float32) as PIX *
'''  <summary>
''' (1) pix1 can be one of these:
'''(a) The input pix alone, which can be either a single character
'''(box == NULL) or several characters that need to be
'''segmented.  If more than character is present, the box
'''region is displayed with an outline.
'''(b) Both the input pix and the matching template.  In this case,
'''pix2 and box will both be null.<para/>
'''
'''(2) If the bmf has been made (by a call to recogMakeBmf())
'''and the index greater or equal 0, the text field, match score and index
'''will be rendered otherwise their values will be ignored.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogShowMatch/*"/>
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


if IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
		if IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	Dim pix2Ptr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pix2) Then pix2Ptr = pix2.Pointer
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.recogShowMatch(recog.Pointer, pix1.Pointer, pix2Ptr, boxPtr,   index,   score)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

End Class


