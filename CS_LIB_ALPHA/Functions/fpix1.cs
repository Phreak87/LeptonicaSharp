using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// fpix1.c (149, 1)
// fpixCreate(width, height) as FPix
// fpixCreate(l_int32, l_int32) as FPIX *
///  <summary>
/// (1) Makes a FPix of specified size, with the data array
/// allocated and initialized to 0.<para/>
/// 
/// (2) The number of pixels must be less than 2^29.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCreate/*"/>
///  <param name="width">[in] - </param>
///  <param name="height">[in] - </param>
///   <returns>fpixd   with data allocated and initialized to 0, or NULL on error</returns>
public static FPix fpixCreate(
				 int width, 
				 int height){

	IntPtr _Result = Natives.fpixCreate(  width,   height);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (199, 1)
// fpixCreateTemplate(fpixs) as FPix
// fpixCreateTemplate(FPIX *) as FPIX *
///  <summary>
/// (1) Makes a FPix of the same size as the input FPix, with the
/// data array allocated and initialized to 0.<para/>
/// 
/// (2) Copies the resolution.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCreateTemplate/*"/>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixCreateTemplate(
				 FPix fpixs){

	IntPtr _Result = Natives.fpixCreateTemplate(fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (229, 1)
// fpixClone(fpix) as FPix
// fpixClone(FPIX *) as FPIX *
///  <summary>
/// (1) See pixClone() for definition and usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixClone/*"/>
///  <param name="fpix">[in] - </param>
///   <returns>same fpix ptr, or NULL on error</returns>
public static FPix fpixClone(
				 FPix fpix){

	IntPtr _Result = Natives.fpixClone(fpix.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (272, 1)
// fpixCopy(fpixd, fpixs) as FPix
// fpixCopy(FPIX *, FPIX *) as FPIX *
///  <summary>
/// (1) There are three cases:
/// (a) fpixd == null  (makes a new fpix refcount = 1)
/// (b) fpixd == fpixs  (no-op)
/// (c) fpixd != fpixs  (data copy no change in refcount)
/// If the refcount of fpixd  is greater  1, case (c) will side-effect
/// these handles.<para/>
/// 
/// (2) The general pattern of use is:
/// fpixd = fpixCopy(fpixd, fpixs)
/// This will work for all three cases.
/// For clarity when the case is known, you can use:
/// (a) fpixd = fpixCopy(NULL, fpixs)
/// (c) fpixCopy(fpixd, fpixs)<para/>
/// 
/// (3) For case (c), we check if fpixs and fpixd are the same size.
/// If so, the data is copied directly.
/// Otherwise, the data is reallocated to the correct size
/// and the copy proceeds.  The refcount of fpixd is unchanged.<para/>
/// 
/// (4) This operation, like all others that may involve a pre-existing
/// fpixd, will side-effect any existing clones of fpixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCopy/*"/>
///  <param name="fpixd">[in][optional] - can be null, or equal to fpixs, or different from fpixs</param>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixCopy(
				 FPix fpixd, 
				 FPix fpixs){

	IntPtr fpixdPtr = IntPtr.Zero; 	if (fpixd != null) {fpixdPtr = fpixd.Pointer;}

	IntPtr _Result = Natives.fpixCopy(fpixdPtr, fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (326, 1)
// fpixResizeImageData(fpixd, fpixs) as int
// fpixResizeImageData(FPIX *, FPIX *) as l_ok
///  <summary>
/// (1) If the data sizes differ, this destroys the existing
/// data in fpixd and allocates a new, uninitialized, data array
/// of the same size as the data in fpixs.  Otherwise, this
/// doesn't do anything.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixResizeImageData/*"/>
///  <param name="fpixd">[in] - </param>
///  <param name="fpixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixResizeImageData(
				 FPix fpixd, 
				 FPix fpixs){

	int _Result = Natives.fpixResizeImageData(fpixd.Pointer, fpixs.Pointer);
	



	return _Result;
}

// fpix1.c (369, 1)
// fpixDestroy(pfpix) as Object
// fpixDestroy(FPIX **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the fpix.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixDestroy/*"/>
///  <param name="pfpix">[in,out] - will be nulled</param>
public static void fpixDestroy(
				ref FPix pfpix){

	IntPtr pfpixPtr = IntPtr.Zero; 	if (pfpix != null) {pfpixPtr = pfpix.Pointer;}

	Natives.fpixDestroy(ref pfpixPtr);
	

	if (pfpixPtr == null) {pfpix = null;} else { pfpix = new FPix(pfpixPtr); };


}

// fpix1.c (408, 1)
// fpixGetDimensions(fpix, pw, ph) as int
// fpixGetDimensions(FPIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetDimensions/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixGetDimensions(
				 FPix fpix, 
				out int pw, 
				out int ph){

	int _Result = Natives.fpixGetDimensions(fpix.Pointer, out  pw, out  ph);
	



	return _Result;
}

// fpix1.c (434, 1)
// fpixSetDimensions(fpix, w, h) as int
// fpixSetDimensions(FPIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetDimensions/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="w">[in] - </param>
///  <param name="h">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixSetDimensions(
				 FPix fpix, 
				 int w, 
				 int h){

	int _Result = Natives.fpixSetDimensions(fpix.Pointer,   w,   h);
	



	return _Result;
}

// fpix1.c (455, 1)
// fpixGetWpl(fpix) as int
// fpixGetWpl(FPIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetWpl/*"/>
///  <param name="fpix">[in] - </param>
///   <returns>wpl, or UNDEF on error</returns>
public static int fpixGetWpl(
				 FPix fpix){

	int _Result = Natives.fpixGetWpl(fpix.Pointer);
	



	return _Result;
}

// fpix1.c (473, 1)
// fpixSetWpl(fpix, wpl) as int
// fpixSetWpl(FPIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetWpl/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="wpl">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixSetWpl(
				 FPix fpix, 
				 int wpl){

	int _Result = Natives.fpixSetWpl(fpix.Pointer,   wpl);
	



	return _Result;
}

// fpix1.c (493, 1)
// fpixGetRefcount(fpix) as int
// fpixGetRefcount(FPIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetRefcount/*"/>
///  <param name="fpix">[in] - </param>
///   <returns>refcount, or UNDEF on error</returns>
public static int fpixGetRefcount(
				 FPix fpix){

	int _Result = Natives.fpixGetRefcount(fpix.Pointer);
	



	return _Result;
}

// fpix1.c (511, 1)
// fpixChangeRefcount(fpix, delta) as int
// fpixChangeRefcount(FPIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixChangeRefcount/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="delta">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixChangeRefcount(
				 FPix fpix, 
				 int delta){

	int _Result = Natives.fpixChangeRefcount(fpix.Pointer,   delta);
	



	return _Result;
}

// fpix1.c (532, 1)
// fpixGetResolution(fpix, pxres, pyres) as int
// fpixGetResolution(FPIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetResolution/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="pxres">[out][optional] - x and y resolution</param>
///  <param name="pyres">[out][optional] - x and y resolution</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixGetResolution(
				 FPix fpix, 
				out int pxres, 
				out int pyres){

	int _Result = Natives.fpixGetResolution(fpix.Pointer, out  pxres, out  pyres);
	



	return _Result;
}

// fpix1.c (554, 1)
// fpixSetResolution(fpix, xres, yres) as int
// fpixSetResolution(FPIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetResolution/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="xres">[in] - x and y resolution</param>
///  <param name="yres">[in] - x and y resolution</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixSetResolution(
				 FPix fpix, 
				 int xres, 
				 int yres){

	int _Result = Natives.fpixSetResolution(fpix.Pointer,   xres,   yres);
	



	return _Result;
}

// fpix1.c (576, 1)
// fpixCopyResolution(fpixd, fpixs) as int
// fpixCopyResolution(FPIX *, FPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCopyResolution/*"/>
///  <param name="fpixd">[in] - </param>
///  <param name="fpixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixCopyResolution(
				 FPix fpixd, 
				 FPix fpixs){

	int _Result = Natives.fpixCopyResolution(fpixd.Pointer, fpixs.Pointer);
	



	return _Result;
}

// fpix1.c (598, 1)
// fpixGetData(fpix) as Single[]
// fpixGetData(FPIX *) as l_float32 *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetData/*"/>
///  <param name="fpix">[in] - </param>
///   <returns>ptr FPix::data, or NULL on error</returns>
public static Single[] fpixGetData(
				 FPix fpix){

	Single[] _Result = Natives.fpixGetData(fpix.Pointer);
	



	return _Result;
}

// fpix1.c (616, 1)
// fpixSetData(fpix, data) as int
// fpixSetData(FPIX *, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetData/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="data">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixSetData(
				 FPix fpix, 
				 Single[] data){

	int _Result = Natives.fpixSetData(fpix.Pointer,   data);
	



	return _Result;
}

// fpix1.c (638, 1)
// fpixGetPixel(fpix, x, y, pval) as int
// fpixGetPixel(FPIX *, l_int32, l_int32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetPixel/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="pval">[out] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixGetPixel(
				 FPix fpix, 
				 int x, 
				 int y, 
				out Single pval){

	int _Result = Natives.fpixGetPixel(fpix.Pointer,   x,   y, out  pval);
	



	return _Result;
}

// fpix1.c (673, 1)
// fpixSetPixel(fpix, x, y, val) as int
// fpixSetPixel(FPIX *, l_int32, l_int32, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetPixel/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="val">[in] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixSetPixel(
				 FPix fpix, 
				 int x, 
				 int y, 
				 Single val){

	int _Result = Natives.fpixSetPixel(fpix.Pointer,   x,   y,   val);
	



	return _Result;
}

// fpix1.c (706, 1)
// fpixaCreate(n) as FPixa
// fpixaCreate(l_int32) as FPIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaCreate/*"/>
///  <param name="n">[in] - initial number of ptrs</param>
///   <returns>fpixa, or NULL on error</returns>
public static FPixa fpixaCreate(
				 int n){

	IntPtr _Result = Natives.fpixaCreate(  n);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPixa(_Result);
}

// fpix1.c (746, 1)
// fpixaCopy(fpixa, copyflag) as FPixa
// fpixaCopy(FPIXA *, l_int32) as FPIXA *
///  <summary>
/// copyflag may be one of
/// ~ L_COPY makes a new fpixa and copies each fpix
/// ~ L_CLONE gives a new ref-counted handle to the input fpixa
/// ~ L_COPY_CLONE makes a new fpixa with clones of all fpix
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaCopy/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="copyflag">[in] - L_COPY, L_CLODE or L_COPY_CLONE</param>
///   <returns>new fpixa, or NULL on error</returns>
public static FPixa fpixaCopy(
				 FPixa fpixa, 
				 int copyflag){

	IntPtr _Result = Natives.fpixaCopy(fpixa.Pointer,   copyflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPixa(_Result);
}

// fpix1.c (793, 1)
// fpixaDestroy(pfpixa) as Object
// fpixaDestroy(FPIXA **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the fpixa.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaDestroy/*"/>
///  <param name="pfpixa">[in,out] - to be nulled</param>
public static void fpixaDestroy(
				ref FPixa pfpixa){

	IntPtr pfpixaPtr = IntPtr.Zero; 	if (pfpixa != null) {pfpixaPtr = pfpixa.Pointer;}

	Natives.fpixaDestroy(ref pfpixaPtr);
	

	if (pfpixaPtr == null) {pfpixa = null;} else { pfpixa = new FPixa(pfpixaPtr); };


}

// fpix1.c (834, 1)
// fpixaAddFPix(fpixa, fpix, copyflag) as int
// fpixaAddFPix(FPIXA *, FPIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaAddFPix/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="fpix">[in] - to be added</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixaAddFPix(
				 FPixa fpixa, 
				 FPix fpix, 
				 int copyflag){

	int _Result = Natives.fpixaAddFPix(fpixa.Pointer, fpix.Pointer,   copyflag);
	



	return _Result;
}

// fpix1.c (934, 1)
// fpixaGetCount(fpixa) as int
// fpixaGetCount(FPIXA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetCount/*"/>
///  <param name="fpixa">[in] - </param>
///   <returns>count, or 0 if no pixa</returns>
public static int fpixaGetCount(
				 FPixa fpixa){

	int _Result = Natives.fpixaGetCount(fpixa.Pointer);
	



	return _Result;
}

// fpix1.c (953, 1)
// fpixaChangeRefcount(fpixa, delta) as int
// fpixaChangeRefcount(FPIXA *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaChangeRefcount/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="delta">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixaChangeRefcount(
				 FPixa fpixa, 
				 int delta){

	int _Result = Natives.fpixaChangeRefcount(fpixa.Pointer,   delta);
	



	return _Result;
}

// fpix1.c (975, 1)
// fpixaGetFPix(fpixa, index, accesstype) as FPix
// fpixaGetFPix(FPIXA *, l_int32, l_int32) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetFPix/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="index">[in] - to the index-th fpix</param>
///  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
///   <returns>fpix, or NULL on error</returns>
public static FPix fpixaGetFPix(
				 FPixa fpixa, 
				 int index, 
				 int accesstype){

	IntPtr _Result = Natives.fpixaGetFPix(fpixa.Pointer,   index,   accesstype);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (1004, 1)
// fpixaGetFPixDimensions(fpixa, index, pw, ph) as int
// fpixaGetFPixDimensions(FPIXA *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetFPixDimensions/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="index">[in] - to the index-th box</param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixaGetFPixDimensions(
				 FPixa fpixa, 
				 int index, 
				out int pw, 
				out int ph){

	int _Result = Natives.fpixaGetFPixDimensions(fpixa.Pointer,   index, out  pw, out  ph);
	



	return _Result;
}

// fpix1.c (1038, 1)
// fpixaGetData(fpixa, index) as Single[]
// fpixaGetData(FPIXA *, l_int32) as l_float32 *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetData/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="index">[in] - into fpixa array</param>
///   <returns>data not a copy, or NULL on error</returns>
public static Single[] fpixaGetData(
				 FPixa fpixa, 
				 int index){

	Single[] _Result = Natives.fpixaGetData(fpixa.Pointer,   index);
	



	return _Result;
}

// fpix1.c (1070, 1)
// fpixaGetPixel(fpixa, index, x, y, pval) as int
// fpixaGetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetPixel/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="index">[in] - into fpixa array</param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="pval">[out] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixaGetPixel(
				 FPixa fpixa, 
				 int index, 
				 int x, 
				 int y, 
				out Single pval){

	int _Result = Natives.fpixaGetPixel(fpixa.Pointer,   index,   x,   y, out  pval);
	



	return _Result;
}

// fpix1.c (1107, 1)
// fpixaSetPixel(fpixa, index, x, y, val) as int
// fpixaSetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaSetPixel/*"/>
///  <param name="fpixa">[in] - </param>
///  <param name="index">[in] - into fpixa array</param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="val">[in] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixaSetPixel(
				 FPixa fpixa, 
				 int index, 
				 int x, 
				 int y, 
				 Single val){

	int _Result = Natives.fpixaSetPixel(fpixa.Pointer,   index,   x,   y,   val);
	



	return _Result;
}

// fpix1.c (1148, 1)
// dpixCreate(width, height) as DPix
// dpixCreate(l_int32, l_int32) as DPIX *
///  <summary>
/// (1) Makes a DPix of specified size, with the data array
/// allocated and initialized to 0.<para/>
/// 
/// (2) The number of pixels must be less than 2^28.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCreate/*"/>
///  <param name="width">[in] - </param>
///  <param name="height">[in] - </param>
///   <returns>dpix  with data allocated and initialized to 0, or NULL on error</returns>
public static DPix dpixCreate(
				 int width, 
				 int height){

	IntPtr _Result = Natives.dpixCreate(  width,   height);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (1198, 1)
// dpixCreateTemplate(dpixs) as DPix
// dpixCreateTemplate(DPIX *) as DPIX *
///  <summary>
/// (1) Makes a DPix of the same size as the input DPix, with the
/// data array allocated and initialized to 0.<para/>
/// 
/// (2) Copies the resolution.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCreateTemplate/*"/>
///  <param name="dpixs">[in] - </param>
///   <returns>dpixd, or NULL on error</returns>
public static DPix dpixCreateTemplate(
				 DPix dpixs){

	IntPtr _Result = Natives.dpixCreateTemplate(dpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (1227, 1)
// dpixClone(dpix) as DPix
// dpixClone(DPIX *) as DPIX *
///  <summary>
/// (1) See pixClone() for definition and usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixClone/*"/>
///  <param name="dpix">[in] - </param>
///   <returns>same dpix ptr, or NULL on error</returns>
public static DPix dpixClone(
				 DPix dpix){

	IntPtr _Result = Natives.dpixClone(dpix.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (1270, 1)
// dpixCopy(dpixd, dpixs) as DPix
// dpixCopy(DPIX *, DPIX *) as DPIX *
///  <summary>
/// (1) There are three cases:
/// (a) dpixd == null  (makes a new dpix refcount = 1)
/// (b) dpixd == dpixs  (no-op)
/// (c) dpixd != dpixs  (data copy no change in refcount)
/// If the refcount of dpixd  is greater  1, case (c) will side-effect
/// these handles.<para/>
/// 
/// (2) The general pattern of use is:
/// dpixd = dpixCopy(dpixd, dpixs)
/// This will work for all three cases.
/// For clarity when the case is known, you can use:
/// (a) dpixd = dpixCopy(NULL, dpixs)
/// (c) dpixCopy(dpixd, dpixs)<para/>
/// 
/// (3) For case (c), we check if dpixs and dpixd are the same size.
/// If so, the data is copied directly.
/// Otherwise, the data is reallocated to the correct size
/// and the copy proceeds.  The refcount of dpixd is unchanged.<para/>
/// 
/// (4) This operation, like all others that may involve a pre-existing
/// dpixd, will side-effect any existing clones of dpixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCopy/*"/>
///  <param name="dpixd">[in][optional] - can be null, or equal to dpixs, or different from dpixs</param>
///  <param name="dpixs">[in] - </param>
///   <returns>dpixd, or NULL on error</returns>
public static DPix dpixCopy(
				 DPix dpixd, 
				 DPix dpixs){

	IntPtr dpixdPtr = IntPtr.Zero; 	if (dpixd != null) {dpixdPtr = dpixd.Pointer;}

	IntPtr _Result = Natives.dpixCopy(dpixdPtr, dpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (1316, 1)
// dpixResizeImageData(dpixd, dpixs) as int
// dpixResizeImageData(DPIX *, DPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixResizeImageData/*"/>
///  <param name="dpixd">[in] - </param>
///  <param name="dpixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixResizeImageData(
				 DPix dpixd, 
				 DPix dpixs){

	int _Result = Natives.dpixResizeImageData(dpixd.Pointer, dpixs.Pointer);
	



	return _Result;
}

// fpix1.c (1359, 1)
// dpixDestroy(pdpix) as Object
// dpixDestroy(DPIX **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the dpix.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixDestroy/*"/>
///  <param name="pdpix">[in,out] - will be nulled</param>
public static void dpixDestroy(
				ref DPix pdpix){

	IntPtr pdpixPtr = IntPtr.Zero; 	if (pdpix != null) {pdpixPtr = pdpix.Pointer;}

	Natives.dpixDestroy(ref pdpixPtr);
	

	if (pdpixPtr == null) {pdpix = null;} else { pdpix = new DPix(pdpixPtr); };


}

// fpix1.c (1398, 1)
// dpixGetDimensions(dpix, pw, ph) as int
// dpixGetDimensions(DPIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetDimensions/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixGetDimensions(
				 DPix dpix, 
				out int pw, 
				out int ph){

	int _Result = Natives.dpixGetDimensions(dpix.Pointer, out  pw, out  ph);
	



	return _Result;
}

// fpix1.c (1424, 1)
// dpixSetDimensions(dpix, w, h) as int
// dpixSetDimensions(DPIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetDimensions/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="w">[in] - </param>
///  <param name="h">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixSetDimensions(
				 DPix dpix, 
				 int w, 
				 int h){

	int _Result = Natives.dpixSetDimensions(dpix.Pointer,   w,   h);
	



	return _Result;
}

// fpix1.c (1445, 1)
// dpixGetWpl(dpix) as int
// dpixGetWpl(DPIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetWpl/*"/>
///  <param name="dpix">[in] - </param>
///   <returns>wpl, or UNDEF on error</returns>
public static int dpixGetWpl(
				 DPix dpix){

	int _Result = Natives.dpixGetWpl(dpix.Pointer);
	



	return _Result;
}

// fpix1.c (1463, 1)
// dpixSetWpl(dpix, wpl) as int
// dpixSetWpl(DPIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetWpl/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="wpl">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixSetWpl(
				 DPix dpix, 
				 int wpl){

	int _Result = Natives.dpixSetWpl(dpix.Pointer,   wpl);
	



	return _Result;
}

// fpix1.c (1483, 1)
// dpixGetRefcount(dpix) as int
// dpixGetRefcount(DPIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetRefcount/*"/>
///  <param name="dpix">[in] - </param>
///   <returns>refcount, or UNDEF on error</returns>
public static int dpixGetRefcount(
				 DPix dpix){

	int _Result = Natives.dpixGetRefcount(dpix.Pointer);
	



	return _Result;
}

// fpix1.c (1501, 1)
// dpixChangeRefcount(dpix, delta) as int
// dpixChangeRefcount(DPIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixChangeRefcount/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="delta">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixChangeRefcount(
				 DPix dpix, 
				 int delta){

	int _Result = Natives.dpixChangeRefcount(dpix.Pointer,   delta);
	



	return _Result;
}

// fpix1.c (1522, 1)
// dpixGetResolution(dpix, pxres, pyres) as int
// dpixGetResolution(DPIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetResolution/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="pxres">[out][optional] - x and y resolution</param>
///  <param name="pyres">[out][optional] - x and y resolution</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixGetResolution(
				 DPix dpix, 
				out int pxres, 
				out int pyres){

	int _Result = Natives.dpixGetResolution(dpix.Pointer, out  pxres, out  pyres);
	



	return _Result;
}

// fpix1.c (1544, 1)
// dpixSetResolution(dpix, xres, yres) as int
// dpixSetResolution(DPIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetResolution/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="xres">[in] - x and y resolution</param>
///  <param name="yres">[in] - x and y resolution</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixSetResolution(
				 DPix dpix, 
				 int xres, 
				 int yres){

	int _Result = Natives.dpixSetResolution(dpix.Pointer,   xres,   yres);
	



	return _Result;
}

// fpix1.c (1566, 1)
// dpixCopyResolution(dpixd, dpixs) as int
// dpixCopyResolution(DPIX *, DPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCopyResolution/*"/>
///  <param name="dpixd">[in] - </param>
///  <param name="dpixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixCopyResolution(
				 DPix dpixd, 
				 DPix dpixs){

	int _Result = Natives.dpixCopyResolution(dpixd.Pointer, dpixs.Pointer);
	



	return _Result;
}

// fpix1.c (1588, 1)
// dpixGetData(dpix) as Double[]
// dpixGetData(DPIX *) as l_float64 *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetData/*"/>
///  <param name="dpix">[in] - </param>
///   <returns>ptr DPix::data, or NULL on error</returns>
public static Double[] dpixGetData(
				 DPix dpix){

	Double[] _Result = Natives.dpixGetData(dpix.Pointer);
	



	return _Result;
}

// fpix1.c (1606, 1)
// dpixSetData(dpix, data) as int
// dpixSetData(DPIX *, l_float64 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetData/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="data">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixSetData(
				 DPix dpix, 
				 Double[] data){

	int _Result = Natives.dpixSetData(dpix.Pointer,   data);
	



	return _Result;
}

// fpix1.c (1628, 1)
// dpixGetPixel(dpix, x, y, pval) as int
// dpixGetPixel(DPIX *, l_int32, l_int32, l_float64 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetPixel/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="pval">[out] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int dpixGetPixel(
				 DPix dpix, 
				 int x, 
				 int y, 
				out Double[] pval){

	int _Result = Natives.dpixGetPixel(dpix.Pointer,   x,   y, out  pval);
	



	return _Result;
}

// fpix1.c (1663, 1)
// dpixSetPixel(dpix, x, y, val) as int
// dpixSetPixel(DPIX *, l_int32, l_int32, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetPixel/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="x">[in] - ,y pixel coords</param>
///  <param name="val">[in] - pixel value</param>
///   <returns>0 if OK 1 on error</returns>
public static int dpixSetPixel(
				 DPix dpix, 
				 int x, 
				 int y, 
				 double val){

	int _Result = Natives.dpixSetPixel(dpix.Pointer,   x,   y,   val);
	



	return _Result;
}

// fpix1.c (1696, 1)
// fpixRead(filename) as FPix
// fpixRead(const char *) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>fpix, or NULL on error</returns>
public static FPix fpixRead(
				 String filename){

	IntPtr _Result = Natives.fpixRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (1723, 1)
// fpixReadStream(fp) as FPix
// fpixReadStream(FILE *) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>fpix, or NULL on error</returns>
public static FPix fpixReadStream(
				 FILE fp){

	IntPtr _Result = Natives.fpixReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (1776, 1)
// fpixReadMem(data, size) as FPix
// fpixReadMem(const l_uint8 *, size_t) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixReadMem/*"/>
///  <param name="data">[in] - of serialized fpix</param>
///  <param name="size">[in] - of data in bytes</param>
///   <returns>fpix, or NULL on error</returns>
public static FPix fpixReadMem(
				 Byte[] data, 
				 uint size){

	IntPtr _Result = Natives.fpixReadMem(  data,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (1804, 1)
// fpixWrite(filename, fpix) as int
// fpixWrite(const char *, FPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="fpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixWrite(
				 String filename, 
				 FPix fpix){

	int _Result = Natives.fpixWrite(  filename, fpix.Pointer);
	



	return _Result;
}

// fpix1.c (1835, 1)
// fpixWriteStream(fp, fpix) as int
// fpixWriteStream(FILE *, FPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for "wb"</param>
///  <param name="fpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixWriteStream(
				 FILE fp, 
				 FPix fpix){

	int _Result = Natives.fpixWriteStream(fp.Pointer, fpix.Pointer);
	



	return _Result;
}

// fpix1.c (1881, 1)
// fpixWriteMem(pdata, psize, fpix) as int
// fpixWriteMem(l_uint8 **, size_t *, FPIX *) as l_ok
///  <summary>
/// (1) Serializes a fpix in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized fpix</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="fpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 FPix fpix){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.fpixWriteMem(out  pdataPtr, out  psize, fpix.Pointer);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// fpix1.c (1941, 1)
// fpixEndianByteSwap(fpixd, fpixs) as FPix
// fpixEndianByteSwap(FPIX *, FPIX *) as FPIX *
///  <summary>
/// (1) On big-endian hardware, this does byte-swapping on each of
/// the 4-byte floats in the fpix data.  On little-endians,
/// the data is unchanged.  This is used for serialization
/// of fpix the data is serialized in little-endian byte
/// order because most hardware is little-endian.<para/>
/// 
/// (2) The operation can be either in-place or, if fpixd == NULL,
/// a new fpix is made.  If not in-place, caller must catch
/// the returned pointer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixEndianByteSwap/*"/>
///  <param name="fpixd">[in] - can be equal to fpixs or NULL</param>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd always</returns>
public static FPix fpixEndianByteSwap(
				 FPix fpixd, 
				 FPix fpixs){

	IntPtr _Result = Natives.fpixEndianByteSwap(fpixd.Pointer, fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix1.c (1993, 1)
// dpixRead(filename) as DPix
// dpixRead(const char *) as DPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>dpix, or NULL on error</returns>
public static DPix dpixRead(
				 String filename){

	IntPtr _Result = Natives.dpixRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (2020, 1)
// dpixReadStream(fp) as DPix
// dpixReadStream(FILE *) as DPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>dpix, or NULL on error</returns>
public static DPix dpixReadStream(
				 FILE fp){

	IntPtr _Result = Natives.dpixReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (2073, 1)
// dpixReadMem(data, size) as DPix
// dpixReadMem(const l_uint8 *, size_t) as DPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixReadMem/*"/>
///  <param name="data">[in] - of serialized dpix</param>
///  <param name="size">[in] - of data in bytes</param>
///   <returns>dpix, or NULL on error</returns>
public static DPix dpixReadMem(
				 Byte[] data, 
				 uint size){

	IntPtr _Result = Natives.dpixReadMem(  data,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (2101, 1)
// dpixWrite(filename, dpix) as int
// dpixWrite(const char *, DPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="dpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixWrite(
				 String filename, 
				 DPix dpix){

	int _Result = Natives.dpixWrite(  filename, dpix.Pointer);
	



	return _Result;
}

// fpix1.c (2132, 1)
// dpixWriteStream(fp, dpix) as int
// dpixWriteStream(FILE *, DPIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for "wb"</param>
///  <param name="dpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixWriteStream(
				 FILE fp, 
				 DPix dpix){

	int _Result = Natives.dpixWriteStream(fp.Pointer, dpix.Pointer);
	



	return _Result;
}

// fpix1.c (2178, 1)
// dpixWriteMem(pdata, psize, dpix) as int
// dpixWriteMem(l_uint8 **, size_t *, DPIX *) as l_ok
///  <summary>
/// (1) Serializes a dpix in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized dpix</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="dpix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 DPix dpix){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.dpixWriteMem(out  pdataPtr, out  psize, dpix.Pointer);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// fpix1.c (2238, 1)
// dpixEndianByteSwap(dpixd, dpixs) as DPix
// dpixEndianByteSwap(DPIX *, DPIX *) as DPIX *
///  <summary>
/// (1) On big-endian hardware, this does byte-swapping on each of
/// the 4-byte words in the dpix data.  On little-endians,
/// the data is unchanged.  This is used for serialization
/// of dpix the data is serialized in little-endian byte
/// order because most hardware is little-endian.<para/>
/// 
/// (2) The operation can be either in-place or, if dpixd == NULL,
/// a new dpix is made.  If not in-place, caller must catch
/// the returned pointer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixEndianByteSwap/*"/>
///  <param name="dpixd">[in] - can be equal to dpixs or NULL</param>
///  <param name="dpixs">[in] - </param>
///   <returns>dpixd always</returns>
public static DPix dpixEndianByteSwap(
				 DPix dpixd, 
				 DPix dpixs){

	IntPtr _Result = Natives.dpixEndianByteSwap(dpixd.Pointer, dpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix1.c (2297, 1)
// fpixPrintStream(fp, fpix, factor) as int
// fpixPrintStream(FILE *, FPIX *, l_int32) as l_ok
///  <summary>
/// (1) Subsampled printout of fpix for debugging.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixPrintStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="fpix">[in] - </param>
///  <param name="factor">[in] - subsampled</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixPrintStream(
				 FILE fp, 
				 FPix fpix, 
				 int factor){

	int _Result = Natives.fpixPrintStream(fp.Pointer, fpix.Pointer,   factor);
	



	return _Result;
}

}
}
