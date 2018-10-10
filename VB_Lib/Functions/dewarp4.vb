Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dewarp4.c (97, 1)
' dewarpSinglePage(pixs, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug) as Integer
' dewarpSinglePage(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Dewarps pixs and returns the result in  and pixd.<para/>
''' (2) This uses default values for all model parameters.<para/>
''' (3) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
''' (4) If it can't build a model, returns a copy of pixs in  and pixd.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				<Out()> ByRef ppixd as Pix, 
				<Out()> Optional ByRef pdewa as L_Dewarpa = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer
Dim pdewaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdewa) Then pdewaPTR = pdewa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpSinglePage( pixs.Pointer, thresh, adaptive, useboth, check_columns, ppixdPTR, pdewaPTR, debug)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)
	if pdewaPTR <> IntPtr.Zero then pdewa = new L_Dewarpa(pdewaPTR)

	Return _Result
End Function

' SRC\dewarp4.c (165, 1)
' dewarpSinglePageInit(pixs, thresh, adaptive, useboth, check_columns, ppixb, pdewa) as Integer
' dewarpSinglePageInit(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes the input pixs if necessary, returning the<para/>
''' binarized image.  It also initializes the dewa to default values<para/>
''' for the model parameters.<para/>
''' (2) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
''' (3) To change the model parameters, call dewarpaSetCurvatures()<para/>
''' before running dewarpSinglePageRun().  For example:<para/>
''' dewarpSinglePageInit(pixs, 0, 1, 1, 1,  and pixb,  and dewa)<para/>
''' dewarpaSetCurvatures(dewa, 250, -1, -1, 80, 70, 150)<para/>
''' dewarpSinglePageRun(pixs, pixb, dewa,  and pixd, 0)<para/>
''' dewarpaDestroy( and dewa)<para/>
''' pixDestroy( and pixb)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				<Out()> ByRef ppixb as Pix, 
				<Out()> ByRef pdewa as L_Dewarpa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim ppixbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixb) Then ppixbPTR = ppixb.Pointer
	Dim pdewaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdewa) Then pdewaPTR = pdewa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpSinglePageInit( pixs.Pointer, thresh, adaptive, useboth, check_columns, ppixbPTR, pdewaPTR)
	if ppixbPTR <> IntPtr.Zero then ppixb = new Pix(ppixbPTR)
	if pdewaPTR <> IntPtr.Zero then pdewa = new L_Dewarpa(pdewaPTR)

	Return _Result
End Function

' SRC\dewarp4.c (223, 1)
' dewarpSinglePageRun(pixs, pixb, dewa, ppixd, debug) as Integer
' dewarpSinglePageRun(PIX *, PIX *, L_DEWARPA *, PIX **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Dewarps pixs and returns the result in  and pixd.<para/>
''' (2) The 1 bpp version %pixb and %dewa are conveniently generated by<para/>
''' dewarpSinglePageInit().<para/>
''' (3) Non-default model parameters must be set before calling this.<para/>
''' (4) If a model cannot be built, this returns a copy of pixs in  and pixd.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				<Out()> ByRef ppixd as Pix, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	If {1}.contains (pixb.d) = false then Throw New ArgumentException ("1 bpp")

	Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpSinglePageRun( pixs.Pointer, pixb.Pointer, dewa.Pointer, ppixdPTR, debug)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\dewarp4.c (289, 1)
' dewarpaListPages(dewa) as Integer
' dewarpaListPages(L_DEWARPA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates two numas, stored in the dewarpa, that give:<para/>
''' (a) the page number for each dew that has a page model.<para/>
''' (b) the page number for each dew that has either a page<para/>
''' model or a reference model.<para/>
''' It can be called at any time.<para/>
''' (2) It is called by the dewarpa serializer before writing.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Shared Function dewarpaListPages(
				 ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaListPages( dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp4.c (341, 1)
' dewarpaSetValidModels(dewa, notests, debug) as Integer
' dewarpaSetValidModels(L_DEWARPA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A valid model must meet the rendering requirements, which<para/>
''' include whether or not a vertical disparity model exists<para/>
''' and conditions on curvatures for vertical and horizontal<para/>
''' disparity models.<para/>
''' (2) If %notests == 1, this ignores the curvature constraints<para/>
''' and assumes that all successfully built models are valid.<para/>
''' (3) This function does not need to be called by the application.<para/>
''' It is called by dewarpaInsertRefModels(), which<para/>
''' will destroy all invalid dewarps.  Consequently, to inspect<para/>
''' an invalid dewarp model, it must be done before calling<para/>
''' dewarpaInsertRefModels().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="notests">[in] - </param>
'''  <param name="debug">[in] - 1 to output information on invalid page models</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaSetValidModels(
				 ByVal dewa as L_Dewarpa, 
				 ByVal notests as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaSetValidModels( dewa.Pointer, notests, debug)

	Return _Result
End Function

' SRC\dewarp4.c (447, 1)
' dewarpaInsertRefModels(dewa, notests, debug) as Integer
' dewarpaInsertRefModels(L_DEWARPA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This destroys all dewarp models that are invalid, and then<para/>
''' inserts reference models where possible.<para/>
''' (2) If %notests == 1, this ignores the curvature constraints<para/>
''' and assumes that all successfully built models are valid.<para/>
''' (3) If useboth == 0, it uses the closest valid model within the<para/>
''' distance and parity constraints.  If useboth == 1, it tries<para/>
''' to use the closest allowed hvalid model if it doesn't find<para/>
''' an hvalid model, it uses the closest valid model.<para/>
''' (4) For all pages without a model, this clears out any existing<para/>
''' invalid and reference dewarps, finds the nearest valid model<para/>
''' with the same parity, and inserts an empty dewarp with the<para/>
''' reference page.<para/>
''' (5) Then if it is requested to use both vertical and horizontal<para/>
''' disparity arrays (useboth == 1), it tries to replace any<para/>
''' hvalid == 0 model or reference with an hvalid == 1 reference.<para/>
''' (6) The distance constraint is that any reference model must<para/>
''' be within maxdist.  Note that with the parity constraint,<para/>
''' no reference models will be used if maxdist  is lower  2.<para/>
''' (7) This function must be called, even if reference models will<para/>
''' not be used.  It should be called after building models on all<para/>
''' available pages, and after setting the rendering parameters.<para/>
''' (8) If the dewa has been serialized, this function is called by<para/>
''' dewarpaRead() when it is read back.  It is also called<para/>
''' any time the rendering parameters are changed.<para/>
''' (9) Note: if this has been called with useboth == 1, and useboth<para/>
''' is reset to 0, you should first call dewarpaRestoreModels()<para/>
''' to bring real models from the cache back to the primary array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="notests">[in] - if 1, ignore curvature constraints on model</param>
'''  <param name="debug">[in] - 1 to output information on invalid page models</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaInsertRefModels(
				 ByVal dewa as L_Dewarpa, 
				 ByVal notests as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaInsertRefModels( dewa.Pointer, notests, debug)

	Return _Result
End Function

' SRC\dewarp4.c (578, 1)
' dewarpaStripRefModels(dewa) as Integer
' dewarpaStripRefModels(L_DEWARPA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This examines each dew in a dewarpa, and removes<para/>
''' all that don't have their own page model (i.e., all<para/>
''' that have "references" to nearby pages with valid models).<para/>
''' These references were generated by dewarpaInsertRefModels(dewa).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaStripRefModels(
				 ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaStripRefModels( dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp4.c (619, 1)
' dewarpaRestoreModels(dewa) as Integer
' dewarpaRestoreModels(L_DEWARPA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This puts all real models (and only real models) in the<para/>
''' primary dewarpa array.  First remove all dewarps that are<para/>
''' only references to other page models.  Then move all models<para/>
''' that had been cached back into the primary dewarp array.<para/>
''' (2) After this is done, we still need to recompute and insert<para/>
''' the reference models before dewa- is greater modelsready is true.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaRestoreModels(
				 ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaRestoreModels( dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp4.c (664, 1)
' dewarpaInfo(fp, dewa) as Integer
' dewarpaInfo(FILE *, L_DEWARPA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - </param>
'''  <param name="dewa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaInfo(
				 ByVal fp as FILE, 
				 ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaInfo( fp.Pointer, dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp4.c (756, 1)
' dewarpaModelStats(dewa, pnnone, pnvsuccess, pnvvalid, pnhsuccess, pnhvalid, pnref) as Integer
' dewarpaModelStats(L_DEWARPA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A page without a model has no dew.  It most likely failed to<para/>
''' generate a vertical model, and has not been assigned a ref<para/>
''' model from a neighboring page with a valid vertical model.<para/>
''' (2) A page has vsuccess == 1 if there is at least a model of the<para/>
''' vertical disparity.  The model may be invalid, in which case<para/>
''' dewarpaInsertRefModels() will stash it in the cache and<para/>
''' attempt to replace it by a valid ref model.<para/>
''' (3) A vvvalid model is a vertical disparity model whose parameters<para/>
''' satisfy the constraints given in dewarpaSetValidModels().<para/>
''' (4) A page has hsuccess == 1 if both the vertical and horizontal<para/>
''' disparity arrays have been constructed.<para/>
''' (5) An  hvalid model has vertical and horizontal disparity<para/>
''' models whose parameters satisfy the constraints given<para/>
''' in dewarpaSetValidModels().<para/>
''' (6) A page has a ref model if it failed to generate a valid<para/>
''' model but was assigned a vvalid or hvalid model on another<para/>
''' page (within maxdist) by dewarpaInsertRefModel().<para/>
''' (7) This calls dewarpaTestForValidModel() it ignores the vvalid<para/>
''' and hvalid fields.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				<Out()> Optional ByRef pnnone as Integer = Nothing, 
				<Out()> Optional ByRef pnvsuccess as Integer = Nothing, 
				<Out()> Optional ByRef pnvvalid as Integer = Nothing, 
				<Out()> Optional ByRef pnhsuccess as Integer = Nothing, 
				<Out()> Optional ByRef pnhvalid as Integer = Nothing, 
				<Out()> Optional ByRef pnref as Integer = Nothing) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaModelStats( dewa.Pointer, pnnone, pnvsuccess, pnvvalid, pnhsuccess, pnhvalid, pnref)

	Return _Result
End Function

' SRC\dewarp4.c (912, 1)
' dewarpaShowArrays(dewa, scalefact, first, last) as Integer
' dewarpaShowArrays(L_DEWARPA *, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a pdf of contour plots of the disparity arrays.<para/>
''' (2) This only shows actual models not ref models<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaShowArrays( dewa.Pointer, scalefact, first, last)

	Return _Result
End Function

' SRC\dewarp4.c (1008, 1)
' dewarpDebug(dew, subdirs, index) as Integer
' dewarpDebug(L_DEWARP *, const char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Prints dewarp fields and generates disparity array contour images.<para/>
''' The contour images are written to file:<para/>
''' /tmp/[subdirs]/pixv_[index].png<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="subdirs">[in] - one or more subdirectories of /tmp e.g., "dew1"</param>
'''  <param name="index">[in] - to help label output images e.g., the page number</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpDebug(
				 ByVal dew as L_Dewarp, 
				 ByVal subdirs as String, 
				 ByVal index as Integer) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
	If IsNothing (subdirs) then Throw New ArgumentNullException  ("subdirs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpDebug( dew.Pointer, subdirs, index)

	Return _Result
End Function

' SRC\dewarp4.c (1094, 1)
' dewarpShowResults(dewa, sa, boxa, firstpage, lastpage, pdfout) as Integer
' dewarpShowResults(L_DEWARPA *, SARRAY *, BOXA *, l_int32, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a pdf of image pairs (before, after) for<para/>
''' the designated set of input pages.<para/>
''' (2) If the boxa exists, its elements are aligned with numbers<para/>
''' in the filenames in %sa.  It is used to crop the input images.<para/>
''' It is assumed that the dewa was generated from the cropped<para/>
''' images.  No undercropping is applied before rendering.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (pdfout) then Throw New ArgumentNullException  ("pdfout cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpShowResults( dewa.Pointer, sa.Pointer, boxa.Pointer, firstpage, lastpage, pdfout)

	Return _Result
End Function

End Class
