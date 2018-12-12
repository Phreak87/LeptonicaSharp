using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// dewarp4.c (97, 1)
// dewarpSinglePage(pixs, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug) as int
// dewarpSinglePage(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **, l_int32) as l_ok
///  <summary>
/// (1) Dewarps pixs and returns the result in [and]pixd.<para/>
/// 
/// (2) This uses default values for all model parameters.<para/>
/// 
/// (3) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
/// 
/// (4) If it can't build a model, returns a copy of pixs in [and]pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePage/*"/>
///  <param name="pixs">[in] - with text, any depth</param>
///  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
///  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
///  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
///  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
///  <param name="ppixd">[out] - dewarped result</param>
///  <param name="pdewa">[out][optional] - dewa with single page NULL to skip</param>
///  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
///   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
public static int dewarpSinglePage(
				 Pix pixs, 
				 int thresh, 
				 int adaptive, 
				 int useboth, 
				 int check_columns, 
				out Pix ppixd, 
				out L_Dewarpa pdewa, 
				 DebugOnOff debug){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr ppixdPtr = IntPtr.Zero;
	IntPtr pdewaPtr = IntPtr.Zero;

	int _Result = Natives.dewarpSinglePage(pixs.Pointer,   thresh,   adaptive,   useboth,   check_columns, out ppixdPtr, out pdewaPtr,  (int) debug);
	
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	if (pdewaPtr == IntPtr.Zero) {pdewa = null;} else { pdewa = new L_Dewarpa(pdewaPtr); };
	return _Result;
}

// dewarp4.c (165, 1)
// dewarpSinglePageInit(pixs, thresh, adaptive, useboth, check_columns, ppixb, pdewa) as int
// dewarpSinglePageInit(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **) as l_ok
///  <summary>
/// (1) This binarizes the input pixs if necessary, returning the
/// binarized image.  It also initializes the dewa to default values
/// for the model parameters.<para/>
/// 
/// (2) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
/// 
/// (3) To change the model parameters, call dewarpaSetCurvatures()
/// before running dewarpSinglePageRun().  For example:
/// dewarpSinglePageInit(pixs, 0, 1, 1, 1, [and]pixb, [and]dewa)
/// dewarpaSetCurvatures(dewa, 250, -1, -1, 80, 70, 150)
/// dewarpSinglePageRun(pixs, pixb, dewa, [and]pixd, 0)
/// dewarpaDestroy([and]dewa)
/// pixDestroy([and]pixb)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePageInit/*"/>
///  <param name="pixs">[in] - with text, any depth</param>
///  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
///  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
///  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
///  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
///  <param name="ppixb">[out] - 1 bpp image</param>
///  <param name="pdewa">[out] - initialized dewa</param>
///   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
public static int dewarpSinglePageInit(
				 Pix pixs, 
				 int thresh, 
				 int adaptive, 
				 int useboth, 
				 int check_columns, 
				out Pix ppixb, 
				out L_Dewarpa pdewa){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr ppixbPtr = IntPtr.Zero;
	IntPtr pdewaPtr = IntPtr.Zero;

	int _Result = Natives.dewarpSinglePageInit(pixs.Pointer,   thresh,   adaptive,   useboth,   check_columns, out ppixbPtr, out pdewaPtr);
	
	if (ppixbPtr == IntPtr.Zero) {ppixb = null;} else { ppixb = new Pix(ppixbPtr); };
	if (pdewaPtr == IntPtr.Zero) {pdewa = null;} else { pdewa = new L_Dewarpa(pdewaPtr); };
	return _Result;
}

// dewarp4.c (223, 1)
// dewarpSinglePageRun(pixs, pixb, dewa, ppixd, debug) as int
// dewarpSinglePageRun(PIX *, PIX *, L_DEWARPA *, PIX **, l_int32) as l_ok
///  <summary>
/// (1) Dewarps pixs and returns the result in [and]pixd.<para/>
/// 
/// (2) The 1 bpp version %pixb and %dewa are conveniently generated by
/// dewarpSinglePageInit().<para/>
/// 
/// (3) Non-default model parameters must be set before calling this.<para/>
/// 
/// (4) If a model cannot be built, this returns a copy of pixs in [and]pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePageRun/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="pixb">[in] - 1 bpp</param>
///  <param name="dewa">[in] - initialized</param>
///  <param name="ppixd">[out] - dewarped result</param>
///  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
///   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
public static int dewarpSinglePageRun(
				 Pix pixs, 
				 Pix pixb, 
				 L_Dewarpa dewa, 
				out Pix ppixd, 
				 DebugOnOff debug){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixb == null) {throw new ArgumentNullException  ("pixb cannot be Nothing");}
		if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixb.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr ppixdPtr = IntPtr.Zero;

	int _Result = Natives.dewarpSinglePageRun(pixs.Pointer, pixb.Pointer, dewa.Pointer, out ppixdPtr,  (int) debug);
	
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	return _Result;
}

// dewarp4.c (289, 1)
// dewarpaListPages(dewa) as int
// dewarpaListPages(L_DEWARPA *) as l_ok
///  <summary>
/// (1) This generates two numas, stored in the dewarpa, that give:
/// (a) the page number for each dew that has a page model.
/// (b) the page number for each dew that has either a page
/// model or a reference model.
/// It can be called at any time.<para/>
/// 
/// (2) It is called by the dewarpa serializer before writing.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaListPages/*"/>
///  <param name="dewa">[in] - populated with dewarp structs for pages</param>
///   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
public static int dewarpaListPages(
				 L_Dewarpa dewa){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaListPages(dewa.Pointer);
	
	return _Result;
}

// dewarp4.c (341, 1)
// dewarpaSetValidModels(dewa, notests, debug) as int
// dewarpaSetValidModels(L_DEWARPA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) A valid model must meet the rendering requirements, which
/// include whether or not a vertical disparity model exists
/// and conditions on curvatures for vertical and horizontal
/// disparity models.<para/>
/// 
/// (2) If %notests == 1, this ignores the curvature constraints
/// and assumes that all successfully built models are valid.<para/>
/// 
/// (3) This function does not need to be called by the application.
/// It is called by dewarpaInsertRefModels(), which
/// will destroy all invalid dewarps.  Consequently, to inspect
/// an invalid dewarp model, it must be done before calling
/// dewarpaInsertRefModels().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaSetValidModels/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="notests">[in] - </param>
///  <param name="debug">[in] - 1 to output information on invalid page models</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaSetValidModels(
				 L_Dewarpa dewa, 
				 int notests, 
				 DebugOnOff debug){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaSetValidModels(dewa.Pointer,   notests,  (int) debug);
	
	return _Result;
}

// dewarp4.c (447, 1)
// dewarpaInsertRefModels(dewa, notests, debug) as int
// dewarpaInsertRefModels(L_DEWARPA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This destroys all dewarp models that are invalid, and then
/// inserts reference models where possible.<para/>
/// 
/// (2) If %notests == 1, this ignores the curvature constraints
/// and assumes that all successfully built models are valid.<para/>
/// 
/// (3) If useboth == 0, it uses the closest valid model within the
/// distance and parity constraints.  If useboth == 1, it tries
/// to use the closest allowed hvalid model if it doesn't find
/// an hvalid model, it uses the closest valid model.<para/>
/// 
/// (4) For all pages without a model, this clears out any existing
/// invalid and reference dewarps, finds the nearest valid model
/// with the same parity, and inserts an empty dewarp with the
/// reference page.<para/>
/// 
/// (5) Then if it is requested to use both vertical and horizontal
/// disparity arrays (useboth == 1), it tries to replace any
/// hvalid == 0 model or reference with an hvalid == 1 reference.<para/>
/// 
/// (6) The distance constraint is that any reference model must
/// be within maxdist.  Note that with the parity constraint,
/// no reference models will be used if maxdist  is smaller 2.<para/>
/// 
/// (7) This function must be called, even if reference models will
/// not be used.  It should be called after building models on all
/// available pages, and after setting the rendering parameters.<para/>
/// 
/// (8) If the dewa has been serialized, this function is called by
/// dewarpaRead() when it is read back.  It is also called
/// any time the rendering parameters are changed.<para/>
/// 
/// (9) Note: if this has been called with useboth == 1, and useboth
/// is reset to 0, you should first call dewarpaRestoreModels()
/// to bring real models from the cache back to the primary array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaInsertRefModels/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="notests">[in] - if 1, ignore curvature constraints on model</param>
///  <param name="debug">[in] - 1 to output information on invalid page models</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaInsertRefModels(
				 L_Dewarpa dewa, 
				 int notests, 
				 DebugOnOff debug){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaInsertRefModels(dewa.Pointer,   notests,  (int) debug);
	
	return _Result;
}

// dewarp4.c (578, 1)
// dewarpaStripRefModels(dewa) as int
// dewarpaStripRefModels(L_DEWARPA *) as l_ok
///  <summary>
/// (1) This examines each dew in a dewarpa, and removes
/// all that don't have their own page model (i.e., all
/// that have "references" to nearby pages with valid models).
/// These references were generated by dewarpaInsertRefModels(dewa).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaStripRefModels/*"/>
///  <param name="dewa">[in] - populated with dewarp structs for pages</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaStripRefModels(
				 L_Dewarpa dewa){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaStripRefModels(dewa.Pointer);
	
	return _Result;
}

// dewarp4.c (619, 1)
// dewarpaRestoreModels(dewa) as int
// dewarpaRestoreModels(L_DEWARPA *) as l_ok
///  <summary>
/// (1) This puts all real models (and only real models) in the
/// primary dewarpa array.  First remove all dewarps that are
/// only references to other page models.  Then move all models
/// that had been cached back into the primary dewarp array.<para/>
/// 
/// (2) After this is done, we still need to recompute and insert
/// the reference models before dewatomodelsready is true.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaRestoreModels/*"/>
///  <param name="dewa">[in] - populated with dewarp structs for pages</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaRestoreModels(
				 L_Dewarpa dewa){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaRestoreModels(dewa.Pointer);
	
	return _Result;
}

// dewarp4.c (664, 1)
// dewarpaInfo(fp, dewa) as int
// dewarpaInfo(FILE *, L_DEWARPA *) as l_ok
///  <summary>
/// dewarpaInfo()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaInfo/*"/>
///  <param name="fp">[in] - </param>
///  <param name="dewa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaInfo(
				 FILE fp, 
				 L_Dewarpa dewa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaInfo(fp.Pointer, dewa.Pointer);
	
	return _Result;
}

// dewarp4.c (756, 1)
// dewarpaModelStats(dewa, pnnone, pnvsuccess, pnvvalid, pnhsuccess, pnhvalid, pnref) as int
// dewarpaModelStats(L_DEWARPA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) A page without a model has no dew.  It most likely failed to
/// generate a vertical model, and has not been assigned a ref
/// model from a neighboring page with a valid vertical model.<para/>
/// 
/// (2) A page has vsuccess == 1 if there is at least a model of the
/// vertical disparity.  The model may be invalid, in which case
/// dewarpaInsertRefModels() will stash it in the cache and
/// attempt to replace it by a valid ref model.<para/>
/// 
/// (3) A vvvalid model is a vertical disparity model whose parameters
/// satisfy the constraints given in dewarpaSetValidModels().<para/>
/// 
/// (4) A page has hsuccess == 1 if both the vertical and horizontal
/// disparity arrays have been constructed.<para/>
/// 
/// (5) An  hvalid model has vertical and horizontal disparity
/// models whose parameters satisfy the constraints given
/// in dewarpaSetValidModels().<para/>
/// 
/// (6) A page has a ref model if it failed to generate a valid
/// model but was assigned a vvalid or hvalid model on another
/// page (within maxdist) by dewarpaInsertRefModel().<para/>
/// 
/// (7) This calls dewarpaTestForValidModel() it ignores the vvalid
/// and hvalid fields.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaModelStats/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="pnnone">[out][optional] - number without any model</param>
///  <param name="pnvsuccess">[out][optional] - number with a vert model</param>
///  <param name="pnvvalid">[out][optional] - number with a valid vert model</param>
///  <param name="pnhsuccess">[out][optional] - number with both models</param>
///  <param name="pnhvalid">[out][optional] - number with both models valid</param>
///  <param name="pnref">[out][optional] - number with a reference model</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaModelStats(
				 L_Dewarpa dewa, 
				out int pnnone, 
				out int pnvsuccess, 
				out int pnvvalid, 
				out int pnhsuccess, 
				out int pnhvalid, 
				out int pnref){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaModelStats(dewa.Pointer, out  pnnone, out  pnvsuccess, out  pnvvalid, out  pnhsuccess, out  pnhvalid, out  pnref);
	
	return _Result;
}

// dewarp4.c (912, 1)
// dewarpaShowArrays(dewa, scalefact, first, last) as int
// dewarpaShowArrays(L_DEWARPA *, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Generates a pdf of contour plots of the disparity arrays.<para/>
/// 
/// (2) This only shows actual models not ref models
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaShowArrays/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="scalefact">[in] - on contour images typ. 0.5</param>
///  <param name="first">[in] - first page model to render</param>
///  <param name="last">[in] - last page model to render use 0 to go to end</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaShowArrays(
				 L_Dewarpa dewa, 
				 Single scalefact, 
				 int first, 
				 int last){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
	int _Result = Natives.dewarpaShowArrays(dewa.Pointer,   scalefact,   first,   last);
	
	return _Result;
}

// dewarp4.c (1008, 1)
// dewarpDebug(dew, subdirs, index) as int
// dewarpDebug(L_DEWARP *, const char *, l_int32) as l_ok
///  <summary>
/// (1) Prints dewarp fields and generates disparity array contour images.
/// The contour images are written to file:
/// /tmp/[subdirs]/pixv_[index].png
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpDebug/*"/>
///  <param name="dew">[in] - </param>
///  <param name="subdirs">[in] - one or more subdirectories of /tmp e.g., "dew1"</param>
///  <param name="index">[in] - to help label output images e.g., the page number</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpDebug(
				 L_Dewarp dew, 
				 String subdirs, 
				 int index){

if (dew == null) {throw new ArgumentNullException  ("dew cannot be Nothing");}
		if (subdirs == null) {throw new ArgumentNullException  ("subdirs cannot be Nothing");}
	int _Result = Natives.dewarpDebug(dew.Pointer,   subdirs,   index);
	
	return _Result;
}

// dewarp4.c (1094, 1)
// dewarpShowResults(dewa, sa, boxa, firstpage, lastpage, pdfout) as int
// dewarpShowResults(L_DEWARPA *, SARRAY *, BOXA *, l_int32, l_int32, const char *) as l_ok
///  <summary>
/// (1) This generates a pdf of image pairs (before, after) for
/// the designated set of input pages.<para/>
/// 
/// (2) If the boxa exists, its elements are aligned with numbers
/// in the filenames in %sa.  It is used to crop the input images.
/// It is assumed that the dewa was generated from the cropped
/// images.  No undercropping is applied before rendering.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpShowResults/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="sa">[in] - of indexed input images</param>
///  <param name="boxa">[in] - crop boxes for input images can be null</param>
///  <param name="firstpage">[in] - </param>
///  <param name="lastpage">[in] - </param>
///  <param name="pdfout">[in] - filename</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpShowResults(
				 L_Dewarpa dewa, 
				 Sarray sa, 
				 Boxa boxa, 
				 int firstpage, 
				 int lastpage, 
				 String pdfout){

if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}
		if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
		if (pdfout == null) {throw new ArgumentNullException  ("pdfout cannot be Nothing");}
	int _Result = Natives.dewarpShowResults(dewa.Pointer, sa.Pointer, boxa.Pointer,   firstpage,   lastpage,   pdfout);
	
	return _Result;
}


}
}
