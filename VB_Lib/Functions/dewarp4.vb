Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' dewarp4.c (97, 1)
' dewarpSinglePage(pixs, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug) as Integer
' dewarpSinglePage(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **, l_int32) as l_ok
'''  <summary>
''' (1) Dewarps pixs and returns the result in [and]pixd.<para/>
'''
'''(2) This uses default values for all model parameters.<para/>
'''
'''(3) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
'''
'''(4) If it can't build a model, returns a copy of pixs in [and]pixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePage/*"/>
'''  <param name="pixs">[in] - with text, any depth</param>
'''  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
'''  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
'''  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
'''  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
'''  <param name="ppixd">[out] - dewarped result</param>
'''  <param name="pdewa">[out][optional] - dewa with single page NULL to skip</param>
'''  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Shared Function dewarpSinglePage(
				ByVal pixs as Pix, 
				ByVal thresh as Integer, 
				ByVal adaptive as Integer, 
				ByVal useboth as Integer, 
				ByVal check_columns as Integer, 
				<Out()>  ByRef ppixd as Pix, 
				<Out()> Optional  ByRef pdewa as L_Dewarpa = Nothing, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixdPtr as IntPtr = IntPtr.Zero
	Dim pdewaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.dewarpSinglePage(pixs.Pointer,   thresh,   adaptive,   useboth,   check_columns, ppixdPtr, pdewaPtr,   debug)
	
	if ppixdPtr = IntPtr.Zero then ppixd = Nothing else ppixd = new Pix(ppixdPtr)
	if pdewaPtr = IntPtr.Zero then pdewa = Nothing else pdewa = new L_Dewarpa(pdewaPtr)
	return _Result
End Function

' dewarp4.c (165, 1)
' dewarpSinglePageInit(pixs, thresh, adaptive, useboth, check_columns, ppixb, pdewa) as Integer
' dewarpSinglePageInit(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **) as l_ok
'''  <summary>
''' (1) This binarizes the input pixs if necessary, returning the
'''binarized image.  It also initializes the dewa to default values
'''for the model parameters.<para/>
'''
'''(2) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
'''
'''(3) To change the model parameters, call dewarpaSetCurvatures()
'''before running dewarpSinglePageRun().  For example:
'''dewarpSinglePageInit(pixs, 0, 1, 1, 1, [and]pixb, [and]dewa)
'''dewarpaSetCurvatures(dewa, 250, -1, -1, 80, 70, 150)
'''dewarpSinglePageRun(pixs, pixb, dewa, [and]pixd, 0)
'''dewarpaDestroy([and]dewa)
'''pixDestroy([and]pixb)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePageInit/*"/>
'''  <param name="pixs">[in] - with text, any depth</param>
'''  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
'''  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
'''  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
'''  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
'''  <param name="ppixb">[out] - 1 bpp image</param>
'''  <param name="pdewa">[out] - initialized dewa</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Shared Function dewarpSinglePageInit(
				ByVal pixs as Pix, 
				ByVal thresh as Integer, 
				ByVal adaptive as Integer, 
				ByVal useboth as Integer, 
				ByVal check_columns as Integer, 
				<Out()>  ByRef ppixb as Pix, 
				<Out()>  ByRef pdewa as L_Dewarpa) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim ppixbPtr as IntPtr = IntPtr.Zero
	Dim pdewaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.dewarpSinglePageInit(pixs.Pointer,   thresh,   adaptive,   useboth,   check_columns, ppixbPtr, pdewaPtr)
	
	if ppixbPtr = IntPtr.Zero then ppixb = Nothing else ppixb = new Pix(ppixbPtr)
	if pdewaPtr = IntPtr.Zero then pdewa = Nothing else pdewa = new L_Dewarpa(pdewaPtr)
	return _Result
End Function

' dewarp4.c (223, 1)
' dewarpSinglePageRun(pixs, pixb, dewa, ppixd, debug) as Integer
' dewarpSinglePageRun(PIX *, PIX *, L_DEWARPA *, PIX **, l_int32) as l_ok
'''  <summary>
''' (1) Dewarps pixs and returns the result in [and]pixd.<para/>
'''
'''(2) The 1 bpp version %pixb and %dewa are conveniently generated by
'''dewarpSinglePageInit().<para/>
'''
'''(3) Non-default model parameters must be set before calling this.<para/>
'''
'''(4) If a model cannot be built, this returns a copy of pixs in [and]pixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePageRun/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="pixb">[in] - 1 bpp</param>
'''  <param name="dewa">[in] - initialized</param>
'''  <param name="ppixd">[out] - dewarped result</param>
'''  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Shared Function dewarpSinglePageRun(
				ByVal pixs as Pix, 
				ByVal pixb as Pix, 
				ByVal dewa as L_Dewarpa, 
				<Out()>  ByRef ppixd as Pix, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
		if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
If {1}.contains (pixb.d) = false then Throw New ArgumentException ("1 bpp")
	Dim ppixdPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.dewarpSinglePageRun(pixs.Pointer, pixb.Pointer, dewa.Pointer, ppixdPtr,   debug)
	
	if ppixdPtr = IntPtr.Zero then ppixd = Nothing else ppixd = new Pix(ppixdPtr)
	return _Result
End Function

' dewarp4.c (289, 1)
' dewarpaListPages(dewa) as Integer
' dewarpaListPages(L_DEWARPA *) as l_ok
'''  <summary>
''' (1) This generates two numas, stored in the dewarpa, that give:
'''(a) the page number for each dew that has a page model.
'''(b) the page number for each dew that has either a page
'''model or a reference model.
'''It can be called at any time.<para/>
'''
'''(2) It is called by the dewarpa serializer before writing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaListPages/*"/>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Shared Function dewarpaListPages(
				ByVal dewa as L_Dewarpa) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaListPages(dewa.Pointer)
	
	return _Result
End Function

' dewarp4.c (341, 1)
' dewarpaSetValidModels(dewa, notests, debug) as Integer
' dewarpaSetValidModels(L_DEWARPA *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) A valid model must meet the rendering requirements, which
'''include whether or not a vertical disparity model exists
'''and conditions on curvatures for vertical and horizontal
'''disparity models.<para/>
'''
'''(2) If %notests == 1, this ignores the curvature constraints
'''and assumes that all successfully built models are valid.<para/>
'''
'''(3) This function does not need to be called by the application.
'''It is called by dewarpaInsertRefModels(), which
'''will destroy all invalid dewarps.  Consequently, to inspect
'''an invalid dewarp model, it must be done before calling
'''dewarpaInsertRefModels().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaSetValidModels/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="notests">[in] - </param>
'''  <param name="debug">[in] - 1 to output information on invalid page models</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaSetValidModels(
				ByVal dewa as L_Dewarpa, 
				ByVal notests as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaSetValidModels(dewa.Pointer,   notests,   debug)
	
	return _Result
End Function

' dewarp4.c (447, 1)
' dewarpaInsertRefModels(dewa, notests, debug) as Integer
' dewarpaInsertRefModels(L_DEWARPA *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This destroys all dewarp models that are invalid, and then
'''inserts reference models where possible.<para/>
'''
'''(2) If %notests == 1, this ignores the curvature constraints
'''and assumes that all successfully built models are valid.<para/>
'''
'''(3) If useboth == 0, it uses the closest valid model within the
'''distance and parity constraints.  If useboth == 1, it tries
'''to use the closest allowed hvalid model if it doesn't find
'''an hvalid model, it uses the closest valid model.<para/>
'''
'''(4) For all pages without a model, this clears out any existing
'''invalid and reference dewarps, finds the nearest valid model
'''with the same parity, and inserts an empty dewarp with the
'''reference page.<para/>
'''
'''(5) Then if it is requested to use both vertical and horizontal
'''disparity arrays (useboth == 1), it tries to replace any
'''hvalid == 0 model or reference with an hvalid == 1 reference.<para/>
'''
'''(6) The distance constraint is that any reference model must
'''be within maxdist.  Note that with the parity constraint,
'''no reference models will be used if maxdist  is smaller 2.<para/>
'''
'''(7) This function must be called, even if reference models will
'''not be used.  It should be called after building models on all
'''available pages, and after setting the rendering parameters.<para/>
'''
'''(8) If the dewa has been serialized, this function is called by
'''dewarpaRead() when it is read back.  It is also called
'''any time the rendering parameters are changed.<para/>
'''
'''(9) Note: if this has been called with useboth == 1, and useboth
'''is reset to 0, you should first call dewarpaRestoreModels()
'''to bring real models from the cache back to the primary array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaInsertRefModels/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="notests">[in] - if 1, ignore curvature constraints on model</param>
'''  <param name="debug">[in] - 1 to output information on invalid page models</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaInsertRefModels(
				ByVal dewa as L_Dewarpa, 
				ByVal notests as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaInsertRefModels(dewa.Pointer,   notests,   debug)
	
	return _Result
End Function

' dewarp4.c (578, 1)
' dewarpaStripRefModels(dewa) as Integer
' dewarpaStripRefModels(L_DEWARPA *) as l_ok
'''  <summary>
''' (1) This examines each dew in a dewarpa, and removes
'''all that don't have their own page model (i.e., all
'''that have "references" to nearby pages with valid models).
'''These references were generated by dewarpaInsertRefModels(dewa).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaStripRefModels/*"/>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaStripRefModels(
				ByVal dewa as L_Dewarpa) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaStripRefModels(dewa.Pointer)
	
	return _Result
End Function

' dewarp4.c (619, 1)
' dewarpaRestoreModels(dewa) as Integer
' dewarpaRestoreModels(L_DEWARPA *) as l_ok
'''  <summary>
''' (1) This puts all real models (and only real models) in the
'''primary dewarpa array.  First remove all dewarps that are
'''only references to other page models.  Then move all models
'''that had been cached back into the primary dewarp array.<para/>
'''
'''(2) After this is done, we still need to recompute and insert
'''the reference models before dewatomodelsready is true.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaRestoreModels/*"/>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaRestoreModels(
				ByVal dewa as L_Dewarpa) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaRestoreModels(dewa.Pointer)
	
	return _Result
End Function

' dewarp4.c (664, 1)
' dewarpaInfo(fp, dewa) as Integer
' dewarpaInfo(FILE *, L_DEWARPA *) as l_ok
'''  <summary>
''' dewarpaInfo()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaInfo/*"/>
'''  <param name="fp">[in] - </param>
'''  <param name="dewa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaInfo(
				ByVal fp as FILE, 
				ByVal dewa as L_Dewarpa) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaInfo(fp.Pointer, dewa.Pointer)
	
	return _Result
End Function

' dewarp4.c (756, 1)
' dewarpaModelStats(dewa, pnnone, pnvsuccess, pnvvalid, pnhsuccess, pnhvalid, pnref) as Integer
' dewarpaModelStats(L_DEWARPA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) A page without a model has no dew.  It most likely failed to
'''generate a vertical model, and has not been assigned a ref
'''model from a neighboring page with a valid vertical model.<para/>
'''
'''(2) A page has vsuccess == 1 if there is at least a model of the
'''vertical disparity.  The model may be invalid, in which case
'''dewarpaInsertRefModels() will stash it in the cache and
'''attempt to replace it by a valid ref model.<para/>
'''
'''(3) A vvvalid model is a vertical disparity model whose parameters
'''satisfy the constraints given in dewarpaSetValidModels().<para/>
'''
'''(4) A page has hsuccess == 1 if both the vertical and horizontal
'''disparity arrays have been constructed.<para/>
'''
'''(5) An  hvalid model has vertical and horizontal disparity
'''models whose parameters satisfy the constraints given
'''in dewarpaSetValidModels().<para/>
'''
'''(6) A page has a ref model if it failed to generate a valid
'''model but was assigned a vvalid or hvalid model on another
'''page (within maxdist) by dewarpaInsertRefModel().<para/>
'''
'''(7) This calls dewarpaTestForValidModel() it ignores the vvalid
'''and hvalid fields.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaModelStats/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="pnnone">[out][optional] - number without any model</param>
'''  <param name="pnvsuccess">[out][optional] - number with a vert model</param>
'''  <param name="pnvvalid">[out][optional] - number with a valid vert model</param>
'''  <param name="pnhsuccess">[out][optional] - number with both models</param>
'''  <param name="pnhvalid">[out][optional] - number with both models valid</param>
'''  <param name="pnref">[out][optional] - number with a reference model</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaModelStats(
				ByVal dewa as L_Dewarpa, 
				<Out()> Optional  ByRef pnnone as Integer = 0, 
				<Out()> Optional  ByRef pnvsuccess as Integer = 0, 
				<Out()> Optional  ByRef pnvvalid as Integer = 0, 
				<Out()> Optional  ByRef pnhsuccess as Integer = 0, 
				<Out()> Optional  ByRef pnhvalid as Integer = 0, 
				<Out()> Optional  ByRef pnref as Integer = 0) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaModelStats(dewa.Pointer,   pnnone,   pnvsuccess,   pnvvalid,   pnhsuccess,   pnhvalid,   pnref)
	
	return _Result
End Function

' dewarp4.c (912, 1)
' dewarpaShowArrays(dewa, scalefact, first, last) as Integer
' dewarpaShowArrays(L_DEWARPA *, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) Generates a pdf of contour plots of the disparity arrays.<para/>
'''
'''(2) This only shows actual models not ref models
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaShowArrays/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="scalefact">[in] - on contour images typ. 0.5</param>
'''  <param name="first">[in] - first page model to render</param>
'''  <param name="last">[in] - last page model to render use 0 to go to end</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaShowArrays(
				ByVal dewa as L_Dewarpa, 
				ByVal scalefact as Single, 
				ByVal first as Integer, 
				ByVal last as Integer) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpaShowArrays(dewa.Pointer,   scalefact,   first,   last)
	
	return _Result
End Function

' dewarp4.c (1008, 1)
' dewarpDebug(dew, subdirs, index) as Integer
' dewarpDebug(L_DEWARP *, const char *, l_int32) as l_ok
'''  <summary>
''' (1) Prints dewarp fields and generates disparity array contour images.
'''The contour images are written to file:
'''/tmp/[subdirs]/pixv_[index].png
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpDebug/*"/>
'''  <param name="dew">[in] - </param>
'''  <param name="subdirs">[in] - one or more subdirectories of /tmp e.g., "dew1"</param>
'''  <param name="index">[in] - to help label output images e.g., the page number</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpDebug(
				ByVal dew as L_Dewarp, 
				ByVal subdirs as String, 
				ByVal index as Integer) as Integer


if IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
		if IsNothing (subdirs) then Throw New ArgumentNullException  ("subdirs cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpDebug(dew.Pointer,   subdirs,   index)
	
	return _Result
End Function

' dewarp4.c (1094, 1)
' dewarpShowResults(dewa, sa, boxa, firstpage, lastpage, pdfout) as Integer
' dewarpShowResults(L_DEWARPA *, SARRAY *, BOXA *, l_int32, l_int32, const char *) as l_ok
'''  <summary>
''' (1) This generates a pdf of image pairs (before, after) for
'''the designated set of input pages.<para/>
'''
'''(2) If the boxa exists, its elements are aligned with numbers
'''in the filenames in %sa.  It is used to crop the input images.
'''It is assumed that the dewa was generated from the cropped
'''images.  No undercropping is applied before rendering.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpShowResults/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="sa">[in] - of indexed input images</param>
'''  <param name="boxa">[in] - crop boxes for input images can be null</param>
'''  <param name="firstpage">[in] - </param>
'''  <param name="lastpage">[in] - </param>
'''  <param name="pdfout">[in] - filename</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpShowResults(
				ByVal dewa as L_Dewarpa, 
				ByVal sa as Sarray, 
				ByVal boxa as Boxa, 
				ByVal firstpage as Integer, 
				ByVal lastpage as Integer, 
				ByVal pdfout as String) as Integer


if IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
		if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
		if IsNothing (pdfout) then Throw New ArgumentNullException  ("pdfout cannot be Nothing")
	Dim _Result as Integer = Natives.dewarpShowResults(dewa.Pointer, sa.Pointer, boxa.Pointer,   firstpage,   lastpage,   pdfout)
	
	return _Result
End Function

End Class


