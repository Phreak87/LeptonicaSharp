using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// watershed.c (203, 1)
// wshedCreate(pixs, pixm, mindepth, debugflag) as L_WShed
// wshedCreate(PIX *, PIX *, l_int32, l_int32) as L_WSHED *
///  <summary>
/// (1) It is not necessary for the fg pixels in the seed image
/// be at minima, or that they be isolated.  We extract a
/// single pixel from each connected component, and a seed
/// anywhere in a watershed will eventually label the watershed
/// when the filling level reaches it.<para/>
/// 
/// (2) Set mindepth to some value to ignore noise in pixs that
/// can create small local minima.  Any watershed shallower
/// than mindepth, even if it has a seed, will not be saved
/// It will either be incorporated in another watershed or
/// eliminated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedCreate/*"/>
///  <param name="pixs">[in] - 8 bpp source</param>
///  <param name="pixm">[in] - 1 bpp 'marker' seed</param>
///  <param name="mindepth">[in] - minimum depth anything less is not saved</param>
///  <param name="debugflag">[in] - 1 for debug output</param>
///   <returns>WShed, or NULL on error</returns>
public static L_WShed wshedCreate(
				 Pix pixs, 
				 Pix pixm, 
				 int mindepth, 
				 int debugflag){

	IntPtr _Result = Natives.wshedCreate(pixs.Pointer, pixm.Pointer,   mindepth,   debugflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_WShed(_Result);
}

// watershed.c (250, 1)
// wshedDestroy(pwshed) as Object
// wshedDestroy(L_WSHED **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedDestroy/*"/>
///  <param name="pwshed">[in,out] - will be set to null before returning</param>
public static void wshedDestroy(
				ref L_WShed pwshed){

	IntPtr pwshedPtr = IntPtr.Zero; 	if (pwshed != null) {pwshedPtr = pwshed.Pointer;}

	Natives.wshedDestroy(ref pwshedPtr);
	

	if (pwshedPtr == null) {pwshed = null;} else { pwshed = new L_WShed(pwshedPtr); };


}

// watershed.c (305, 1)
// wshedApply(wshed) as int
// wshedApply(L_WSHED *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedApply/*"/>
///  <param name="wshed">[in] - generated from wshedCreate()</param>
///   <returns>0 if OK, 1 on error Iportant note: 1 This is buggy.  It seems to locate watersheds that are duplicates.  The watershed extraction after complete fill grabs some regions belonging to existing watersheds. See prog/watershedtest.c for testing.</returns>
public static int wshedApply(
				 L_WShed wshed){

	int _Result = Natives.wshedApply(wshed.Pointer);
	



	return _Result;
}

// watershed.c (1034, 1)
// wshedBasins(wshed, ppixa, pnalevels) as int
// wshedBasins(L_WSHED *, PIXA **, NUMA **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedBasins/*"/>
///  <param name="wshed">[in] - </param>
///  <param name="ppixa">[out][optional] - mask of watershed basins</param>
///  <param name="pnalevels">[out][optional] - watershed levels</param>
///   <returns>0 if OK, 1 on error</returns>
public static int wshedBasins(
				 L_WShed wshed, 
				out Pixa ppixa, 
				out Numa pnalevels){

	IntPtr ppixaPtr = IntPtr.Zero;
	IntPtr pnalevelsPtr = IntPtr.Zero;

	int _Result = Natives.wshedBasins(wshed.Pointer, out ppixaPtr, out pnalevelsPtr);
	

	if (ppixaPtr == null) {ppixa = null;} else { ppixa = new Pixa(ppixaPtr); };
	if (pnalevelsPtr == null) {pnalevels = null;} else { pnalevels = new Numa(pnalevelsPtr); };


	return _Result;
}

// watershed.c (1058, 1)
// wshedRenderFill(wshed) as Pix
// wshedRenderFill(L_WSHED *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedRenderFill/*"/>
///  <param name="wshed">[in] - </param>
///   <returns>pixd initial image with all basins filled, or NULL on error</returns>
public static Pix wshedRenderFill(
				 L_WShed wshed){

	IntPtr _Result = Natives.wshedRenderFill(wshed.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// watershed.c (1094, 1)
// wshedRenderColors(wshed) as Pix
// wshedRenderColors(L_WSHED *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedRenderColors/*"/>
///  <param name="wshed">[in] - </param>
///   <returns>pixd initial image with all basins filled, or NULL on error</returns>
public static Pix wshedRenderColors(
				 L_WShed wshed){

	IntPtr _Result = Natives.wshedRenderColors(wshed.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

}
}
