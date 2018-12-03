using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// fpix2.c (124, 1)
// pixConvertToFPix(pixs, ncomps) as FPix
// pixConvertToFPix(PIX *, l_int32) as FPIX *
///  <summary>
/// (1) If colormapped, remove to grayscale.<para/>
/// 
/// (2) If 32 bpp and %ncomps == 3, this is RGB convert to luminance.
/// In all other cases the src image is treated as having a single
/// component of pixel values.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToFPix/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
///  <param name="ncomps">[in] - number of components: 3 for RGB, 1 otherwise</param>
///   <returns>fpix, or NULL on error</returns>
public static FPix pixConvertToFPix(
				 Pix pixs, 
				 int ncomps){

	IntPtr _Result = Natives.pixConvertToFPix(pixs.Pointer,   ncomps);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (217, 1)
// pixConvertToDPix(pixs, ncomps) as DPix
// pixConvertToDPix(PIX *, l_int32) as DPIX *
///  <summary>
/// (1) If colormapped, remove to grayscale.<para/>
/// 
/// (2) If 32 bpp and %ncomps == 3, this is RGB convert to luminance.
/// In all other cases the src image is treated as having a single
/// component of pixel values.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToDPix/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
///  <param name="ncomps">[in] - number of components: 3 for RGB, 1 otherwise</param>
///   <returns>dpix, or NULL on error</returns>
public static DPix pixConvertToDPix(
				 Pix pixs, 
				 int ncomps){

	IntPtr _Result = Natives.pixConvertToDPix(pixs.Pointer,   ncomps);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix2.c (318, 1)
// fpixConvertToPix(fpixs, outdepth, negvals, errorflag) as Pix
// fpixConvertToPix(FPIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Use %outdepth = 0 to programmatically determine the
/// output depth.  If no values are greater than 255,
/// it will set outdepth = 8 otherwise to 16 or 32.<para/>
/// 
/// (2) Because we are converting a float to an unsigned int
/// with a specified dynamic range (8, 16 or 32 bits), errors
/// can occur.  If errorflag == TRUE, output the number
/// of values out of range, both negative and positive.<para/>
/// 
/// (3) If a pixel value is positive and out of range, clip to
/// the maximum value represented at the outdepth of 8, 16
/// or 32 bits.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixConvertToPix/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="outdepth">[in] - 0, 8, 16 or 32 bpp</param>
///  <param name="negvals">[in] - L_CLIP_TO_ZERO, L_TAKE_ABSVAL</param>
///  <param name="errorflag">[in] - 1 to output error stats 0 otherwise</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix fpixConvertToPix(
				 FPix fpixs, 
				 int outdepth, 
				 int negvals, 
				 int errorflag){

	IntPtr _Result = Natives.fpixConvertToPix(fpixs.Pointer,   outdepth,   negvals,   errorflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// fpix2.c (422, 1)
// fpixDisplayMaxDynamicRange(fpixs) as Pix
// fpixDisplayMaxDynamicRange(FPIX *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixDisplayMaxDynamicRange/*"/>
///  <param name="fpixs">[in] - </param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix fpixDisplayMaxDynamicRange(
				 FPix fpixs){

	IntPtr _Result = Natives.fpixDisplayMaxDynamicRange(fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// fpix2.c (479, 1)
// fpixConvertToDPix(fpix) as DPix
// fpixConvertToDPix(FPIX *) as DPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixConvertToDPix/*"/>
///  <param name="fpix">[in] - </param>
///   <returns>dpix, or NULL on error</returns>
public static DPix fpixConvertToDPix(
				 FPix fpix){

	IntPtr _Result = Natives.fpixConvertToDPix(fpix.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix2.c (537, 1)
// dpixConvertToPix(dpixs, outdepth, negvals, errorflag) as Pix
// dpixConvertToPix(DPIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Use %outdepth = 0 to programmatically determine the
/// output depth.  If no values are greater than 255,
/// it will set outdepth = 8 otherwise to 16 or 32.<para/>
/// 
/// (2) Because we are converting a float to an unsigned int
/// with a specified dynamic range (8, 16 or 32 bits), errors
/// can occur.  If errorflag == TRUE, output the number
/// of values out of range, both negative and positive.<para/>
/// 
/// (3) If a pixel value is positive and out of range, clip to
/// the maximum value represented at the outdepth of 8, 16
/// or 32 bits.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixConvertToPix/*"/>
///  <param name="dpixs">[in] - </param>
///  <param name="outdepth">[in] - 0, 8, 16 or 32 bpp</param>
///  <param name="negvals">[in] - L_CLIP_TO_ZERO, L_TAKE_ABSVAL</param>
///  <param name="errorflag">[in] - 1 to output error stats 0 otherwise</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix dpixConvertToPix(
				 DPix dpixs, 
				 int outdepth, 
				 int negvals, 
				 int errorflag){

	IntPtr _Result = Natives.dpixConvertToPix(dpixs.Pointer,   outdepth,   negvals,   errorflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// fpix2.c (641, 1)
// dpixConvertToFPix(dpix) as FPix
// dpixConvertToFPix(DPIX *) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixConvertToFPix/*"/>
///  <param name="dpix">[in] - </param>
///   <returns>fpix, or NULL on error</returns>
public static FPix dpixConvertToFPix(
				 DPix dpix){

	IntPtr _Result = Natives.dpixConvertToFPix(dpix.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (689, 1)
// fpixGetMin(fpix, pminval, pxminloc, pyminloc) as int
// fpixGetMin(FPIX *, l_float32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetMin/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="pminval">[out][optional] - min value</param>
///  <param name="pxminloc">[out][optional] - x location of min</param>
///  <param name="pyminloc">[out][optional] - y location of min</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixGetMin(
				 FPix fpix, 
				out Single pminval, 
				out int pxminloc, 
				out int pyminloc){

	int _Result = Natives.fpixGetMin(fpix.Pointer, out  pminval, out  pxminloc, out  pyminloc);
	



	return _Result;
}

// fpix2.c (742, 1)
// fpixGetMax(fpix, pmaxval, pxmaxloc, pymaxloc) as int
// fpixGetMax(FPIX *, l_float32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetMax/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="pmaxval">[out][optional] - max value</param>
///  <param name="pxmaxloc">[out][optional] - x location of max</param>
///  <param name="pymaxloc">[out][optional] - y location of max</param>
///   <returns>0 if OK 1 on error</returns>
public static int fpixGetMax(
				 FPix fpix, 
				out Single pmaxval, 
				out int pxmaxloc, 
				out int pymaxloc){

	int _Result = Natives.fpixGetMax(fpix.Pointer, out  pmaxval, out  pxmaxloc, out  pymaxloc);
	



	return _Result;
}

// fpix2.c (795, 1)
// dpixGetMin(dpix, pminval, pxminloc, pyminloc) as int
// dpixGetMin(DPIX *, l_float64 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetMin/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="pminval">[out][optional] - min value</param>
///  <param name="pxminloc">[out][optional] - x location of min</param>
///  <param name="pyminloc">[out][optional] - y location of min</param>
///   <returns>0 if OK 1 on error</returns>
public static int dpixGetMin(
				 DPix dpix, 
				out Double[] pminval, 
				out int pxminloc, 
				out int pyminloc){

	int _Result = Natives.dpixGetMin(dpix.Pointer, out  pminval, out  pxminloc, out  pyminloc);
	



	return _Result;
}

// fpix2.c (848, 1)
// dpixGetMax(dpix, pmaxval, pxmaxloc, pymaxloc) as int
// dpixGetMax(DPIX *, l_float64 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetMax/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="pmaxval">[out][optional] - max value</param>
///  <param name="pxmaxloc">[out][optional] - x location of max</param>
///  <param name="pymaxloc">[out][optional] - y location of max</param>
///   <returns>0 if OK 1 on error</returns>
public static int dpixGetMax(
				 DPix dpix, 
				out Double[] pmaxval, 
				out int pxmaxloc, 
				out int pymaxloc){

	int _Result = Natives.dpixGetMax(dpix.Pointer, out  pmaxval, out  pxmaxloc, out  pymaxloc);
	



	return _Result;
}

// fpix2.c (915, 1)
// fpixScaleByInteger(fpixs, factor) as FPix
// fpixScaleByInteger(FPIX *, l_int32) as FPIX *
///  <summary>
/// (1) The width wd of fpixd is related to ws of fpixs by:
/// wd = factor  (ws - 1) + 1 (and ditto for the height)
/// We avoid special-casing boundary pixels in the interpolation
/// by constructing fpixd by inserting (factor - 1) interpolated
/// pixels between each pixel in fpixs.  Then
/// wd = ws + (ws - 1)  (factor - 1)  (same as above)
/// This also has the advantage that if we subsample by %factor,
/// throwing out all the interpolated pixels, we regain the
/// original low resolution fpix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixScaleByInteger/*"/>
///  <param name="fpixs">[in] - low resolution, subsampled</param>
///  <param name="factor">[in] - scaling factor</param>
///   <returns>fpixd interpolated result, or NULL on error</returns>
public static FPix fpixScaleByInteger(
				 FPix fpixs, 
				 int factor){

	IntPtr _Result = Natives.fpixScaleByInteger(fpixs.Pointer,   factor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1007, 1)
// dpixScaleByInteger(dpixs, factor) as DPix
// dpixScaleByInteger(DPIX *, l_int32) as DPIX *
///  <summary>
/// (1) The width wd of dpixd is related to ws of dpixs by:
/// wd = factor  (ws - 1) + 1 (and ditto for the height)
/// We avoid special-casing boundary pixels in the interpolation
/// by constructing fpixd by inserting (factor - 1) interpolated
/// pixels between each pixel in fpixs.  Then
/// wd = ws + (ws - 1)  (factor - 1)  (same as above)
/// This also has the advantage that if we subsample by %factor,
/// throwing out all the interpolated pixels, we regain the
/// original low resolution dpix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixScaleByInteger/*"/>
///  <param name="dpixs">[in] - low resolution, subsampled</param>
///  <param name="factor">[in] - scaling factor</param>
///   <returns>dpixd interpolated result, or NULL on error</returns>
public static DPix dpixScaleByInteger(
				 DPix dpixs, 
				 int factor){

	IntPtr _Result = Natives.dpixScaleByInteger(dpixs.Pointer,   factor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix2.c (1104, 1)
// fpixLinearCombination(fpixd, fpixs1, fpixs2, a, b) as FPix
// fpixLinearCombination(FPIX *, FPIX *, FPIX *, l_float32, l_float32) as FPIX *
///  <summary>
/// (1) Computes pixelwise linear combination: a  src1 + b  src2<para/>
/// 
/// (2) Alignment is to UL corner.<para/>
/// 
/// (3) There are 3 cases.  The result can go to a new dest,
/// in-place to fpixs1, or to an existing input dest:
/// fpixd == null: (src1 + src2) to new fpixd
/// fpixd == fpixs1:  (src1 + src2) to src1  (in-place)
/// fpixd != fpixs1: (src1 + src2) to input fpixd<para/>
/// 
/// (4) fpixs2 must be different from both fpixd and fpixs1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixLinearCombination/*"/>
///  <param name="fpixd">[in][optional] - this can be null, equal to fpixs1, or different from fpixs1</param>
///  <param name="fpixs1">[in] - can be == to fpixd</param>
///  <param name="fpixs2">[in] - </param>
///  <param name="a">[in] - multiplication factors on fpixs1 and fpixs2, rsp.</param>
///  <param name="b">[in] - multiplication factors on fpixs1 and fpixs2, rsp.</param>
///   <returns>fpixd always</returns>
public static FPix fpixLinearCombination(
				 FPix fpixd, 
				 FPix fpixs1, 
				 FPix fpixs2, 
				 Single a, 
				 Single b){

	IntPtr fpixdPtr = IntPtr.Zero; 	if (fpixd != null) {fpixdPtr = fpixd.Pointer;}

	IntPtr _Result = Natives.fpixLinearCombination(fpixdPtr, fpixs1.Pointer, fpixs2.Pointer,   a,   b);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1163, 1)
// fpixAddMultConstant(fpix, addc, multc) as int
// fpixAddMultConstant(FPIX *, l_float32, l_float32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) It can be used to multiply each pixel by a constant,
/// and also to add a constant to each pixel.  Multiplication
/// is done first.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAddMultConstant/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="addc">[in] - use 0.0 to skip the operation</param>
///  <param name="multc">[in] - use 1.0 to skip the operation</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixAddMultConstant(
				 FPix fpix, 
				 Single addc, 
				 Single multc){

	int _Result = Natives.fpixAddMultConstant(fpix.Pointer,   addc,   multc);
	



	return _Result;
}

// fpix2.c (1223, 1)
// dpixLinearCombination(dpixd, dpixs1, dpixs2, a, b) as DPix
// dpixLinearCombination(DPIX *, DPIX *, DPIX *, l_float32, l_float32) as DPIX *
///  <summary>
/// (1) Computes pixelwise linear combination: a  src1 + b  src2<para/>
/// 
/// (2) Alignment is to UL corner.<para/>
/// 
/// (3) There are 3 cases.  The result can go to a new dest,
/// in-place to dpixs1, or to an existing input dest:
/// dpixd == null: (src1 + src2) to new dpixd
/// dpixd == dpixs1:  (src1 + src2) to src1  (in-place)
/// dpixd != dpixs1: (src1 + src2) to input dpixd<para/>
/// 
/// (4) dpixs2 must be different from both dpixd and dpixs1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixLinearCombination/*"/>
///  <param name="dpixd">[in][optional] - this can be null, equal to dpixs1, or different from dpixs1</param>
///  <param name="dpixs1">[in] - can be == to dpixd</param>
///  <param name="dpixs2">[in] - </param>
///  <param name="a">[in] - multiplication factors on dpixs1 and dpixs2, rsp.</param>
///  <param name="b">[in] - multiplication factors on dpixs1 and dpixs2, rsp.</param>
///   <returns>dpixd always</returns>
public static DPix dpixLinearCombination(
				 DPix dpixd, 
				 DPix dpixs1, 
				 DPix dpixs2, 
				 Single a, 
				 Single b){

	IntPtr dpixdPtr = IntPtr.Zero; 	if (dpixd != null) {dpixdPtr = dpixd.Pointer;}

	IntPtr _Result = Natives.dpixLinearCombination(dpixdPtr, dpixs1.Pointer, dpixs2.Pointer,   a,   b);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new DPix(_Result);
}

// fpix2.c (1282, 1)
// dpixAddMultConstant(dpix, addc, multc) as int
// dpixAddMultConstant(DPIX *, l_float64, l_float64) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) It can be used to multiply each pixel by a constant,
/// and also to add a constant to each pixel.  Multiplication
/// is done first.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixAddMultConstant/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="addc">[in] - use 0.0 to skip the operation</param>
///  <param name="multc">[in] - use 1.0 to skip the operation</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixAddMultConstant(
				 DPix dpix, 
				 double addc, 
				 double multc){

	int _Result = Natives.dpixAddMultConstant(dpix.Pointer,   addc,   multc);
	



	return _Result;
}

// fpix2.c (1329, 1)
// fpixSetAllArbitrary(fpix, inval) as int
// fpixSetAllArbitrary(FPIX *, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetAllArbitrary/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="inval">[in] - to set at each pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int fpixSetAllArbitrary(
				 FPix fpix, 
				 Single inval){

	int _Result = Natives.fpixSetAllArbitrary(fpix.Pointer,   inval);
	



	return _Result;
}

// fpix2.c (1360, 1)
// dpixSetAllArbitrary(dpix, inval) as int
// dpixSetAllArbitrary(DPIX *, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetAllArbitrary/*"/>
///  <param name="dpix">[in] - </param>
///  <param name="inval">[in] - to set at each pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dpixSetAllArbitrary(
				 DPix dpix, 
				 double inval){

	int _Result = Natives.dpixSetAllArbitrary(dpix.Pointer,   inval);
	



	return _Result;
}

// fpix2.c (1399, 1)
// fpixAddBorder(fpixs, left, right, top, bot) as FPix
// fpixAddBorder(FPIX *, l_int32, l_int32, l_int32, l_int32) as FPIX *
///  <summary>
/// (1) Adds border of '0' 32-bit pixels
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAddBorder/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="left">[in] - pixels on each side to be added</param>
///  <param name="right">[in] - pixels on each side to be added</param>
///  <param name="top">[in] - pixels on each side to be added</param>
///  <param name="bot">[in] - pixels on each side to be added</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAddBorder(
				 FPix fpixs, 
				 int left, 
				 int right, 
				 int top, 
				 int bot){

	IntPtr _Result = Natives.fpixAddBorder(fpixs.Pointer,   left,   right,   top,   bot);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1435, 1)
// fpixRemoveBorder(fpixs, left, right, top, bot) as FPix
// fpixRemoveBorder(FPIX *, l_int32, l_int32, l_int32, l_int32) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRemoveBorder/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="left">[in] - pixels on each side to be removed</param>
///  <param name="right">[in] - pixels on each side to be removed</param>
///  <param name="top">[in] - pixels on each side to be removed</param>
///  <param name="bot">[in] - pixels on each side to be removed</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixRemoveBorder(
				 FPix fpixs, 
				 int left, 
				 int right, 
				 int top, 
				 int bot){

	IntPtr _Result = Natives.fpixRemoveBorder(fpixs.Pointer,   left,   right,   top,   bot);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1479, 1)
// fpixAddMirroredBorder(fpixs, left, right, top, bot) as FPix
// fpixAddMirroredBorder(FPIX *, l_int32, l_int32, l_int32, l_int32) as FPIX *
///  <summary>
/// (1) See pixAddMirroredBorder() for situations of usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAddMirroredBorder/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="left">[in] - pixels on each side to be added</param>
///  <param name="right">[in] - pixels on each side to be added</param>
///  <param name="top">[in] - pixels on each side to be added</param>
///  <param name="bot">[in] - pixels on each side to be added</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAddMirroredBorder(
				 FPix fpixs, 
				 int left, 
				 int right, 
				 int top, 
				 int bot){

	IntPtr _Result = Natives.fpixAddMirroredBorder(fpixs.Pointer,   left,   right,   top,   bot);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1526, 1)
// fpixAddContinuedBorder(fpixs, left, right, top, bot) as FPix
// fpixAddContinuedBorder(FPIX *, l_int32, l_int32, l_int32, l_int32) as FPIX *
///  <summary>
/// (1) This adds pixels on each side whose values are equal to
/// the value on the closest boundary pixel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAddContinuedBorder/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="left">[in] - pixels on each side to be added</param>
///  <param name="right">[in] - pixels on each side to be added</param>
///  <param name="top">[in] - pixels on each side to be added</param>
///  <param name="bot">[in] - pixels on each side to be added</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAddContinuedBorder(
				 FPix fpixs, 
				 int left, 
				 int right, 
				 int top, 
				 int bot){

	IntPtr _Result = Natives.fpixAddContinuedBorder(fpixs.Pointer,   left,   right,   top,   bot);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1571, 1)
// fpixAddSlopeBorder(fpixs, left, right, top, bot) as FPix
// fpixAddSlopeBorder(FPIX *, l_int32, l_int32, l_int32, l_int32) as FPIX *
///  <summary>
/// (1) This adds pixels on each side whose values have a normal
/// derivative equal to the normal derivative at the boundary
/// of fpixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAddSlopeBorder/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="left">[in] - pixels on each side to be added</param>
///  <param name="right">[in] - pixels on each side to be added</param>
///  <param name="top">[in] - pixels on each side to be added</param>
///  <param name="bot">[in] - pixels on each side to be added</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAddSlopeBorder(
				 FPix fpixs, 
				 int left, 
				 int right, 
				 int top, 
				 int bot){

	IntPtr _Result = Natives.fpixAddSlopeBorder(fpixs.Pointer,   left,   right,   top,   bot);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1660, 1)
// fpixRasterop(fpixd, dx, dy, dw, dh, fpixs, sx, sy) as int
// fpixRasterop(FPIX *, l_int32, l_int32, l_int32, l_int32, FPIX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is similar in structure to pixRasterop(), except
/// it only allows copying from the source into the destination.
/// For that reason, no op code is necessary.  Additionally,
/// all pixels are 32 bit words (float values), which makes
/// the copy very simple.<para/>
/// 
/// (2) Clipping of both src and dest fpix are done automatically.<para/>
/// 
/// (3) This allows in-place copying, without checking to see if
/// the result is valid:  use for in-place with caution!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRasterop/*"/>
///  <param name="fpixd">[in] - dest fpix</param>
///  <param name="dx">[in] - x val of UL corner of dest rectangle</param>
///  <param name="dy">[in] - y val of UL corner of dest rectangle</param>
///  <param name="dw">[in] - width of dest rectangle</param>
///  <param name="dh">[in] - height of dest rectangle</param>
///  <param name="fpixs">[in] - src fpix</param>
///  <param name="sx">[in] - x val of UL corner of src rectangle</param>
///  <param name="sy">[in] - y val of UL corner of src rectangle</param>
///   <returns>0 if OK 1 on error.</returns>
public static int fpixRasterop(
				 FPix fpixd, 
				 int dx, 
				 int dy, 
				 int dw, 
				 int dh, 
				 FPix fpixs, 
				 int sx, 
				 int sy){

	int _Result = Natives.fpixRasterop(fpixd.Pointer,   dx,   dy,   dw,   dh, fpixs.Pointer,   sx,   sy);
	



	return _Result;
}

// fpix2.c (1760, 1)
// fpixRotateOrth(fpixs, quads) as FPix
// fpixRotateOrth(FPIX *, l_int32) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRotateOrth/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="quads">[in] - 0-3 number of 90 degree cw rotations</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixRotateOrth(
				 FPix fpixs, 
				 int quads){

	IntPtr _Result = Natives.fpixRotateOrth(fpixs.Pointer,   quads);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1806, 1)
// fpixRotate180(fpixd, fpixs) as FPix
// fpixRotate180(FPIX *, FPIX *) as FPIX *
///  <summary>
/// (1) This does a 180 rotation of the image about the center,
/// which is equivalent to a left-right flip about a vertical
/// line through the image center, followed by a top-bottom
/// flip about a horizontal line through the image center.<para/>
/// 
/// (2) There are 3 cases for input:
/// (a) fpixd == null (creates a new fpixd)
/// (b) fpixd == fpixs (in-place operation)
/// (c) fpixd != fpixs (existing fpixd)<para/>
/// 
/// (3) For clarity, use these three patterns, respectively:
/// (a) fpixd = fpixRotate180(NULL, fpixs)
/// (b) fpixRotate180(fpixs, fpixs)
/// (c) fpixRotate180(fpixd, fpixs)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRotate180/*"/>
///  <param name="fpixd">[in][optional] - can be null, equal to fpixs, or different from fpixs</param>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixRotate180(
				 FPix fpixd, 
				 FPix fpixs){

	IntPtr fpixdPtr = IntPtr.Zero; 	if (fpixd != null) {fpixdPtr = fpixd.Pointer;}

	IntPtr _Result = Natives.fpixRotate180(fpixdPtr, fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1839, 1)
// fpixRotate90(fpixs, direction) as FPix
// fpixRotate90(FPIX *, l_int32) as FPIX *
///  <summary>
/// (1) This does a 90 degree rotation of the image about the center,
/// either cw or ccw, returning a new pix.<para/>
/// 
/// (2) The direction must be either 1 (cw) or -1 (ccw).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRotate90/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="direction">[in] - 1 = clockwise,  -1 = counter-clockwise</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixRotate90(
				 FPix fpixs, 
				 int direction){

	IntPtr _Result = Natives.fpixRotate90(fpixs.Pointer,   direction);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1912, 1)
// fpixFlipLR(fpixd, fpixs) as FPix
// fpixFlipLR(FPIX *, FPIX *) as FPIX *
///  <summary>
/// (1) This does a left-right flip of the image, which is
/// equivalent to a rotation out of the plane about a
/// vertical line through the image center.<para/>
/// 
/// (2) There are 3 cases for input:
/// (a) fpixd == null (creates a new fpixd)
/// (b) fpixd == fpixs (in-place operation)
/// (c) fpixd != fpixs (existing fpixd)<para/>
/// 
/// (3) For clarity, use these three patterns, respectively:
/// (a) fpixd = fpixFlipLR(NULL, fpixs)
/// (b) fpixFlipLR(fpixs, fpixs)
/// (c) fpixFlipLR(fpixd, fpixs)<para/>
/// 
/// (4) If an existing fpixd is not the same size as fpixs, the
/// image data will be reallocated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixFlipLR/*"/>
///  <param name="fpixd">[in][optional] - can be null, equal to fpixs, or different from fpixs</param>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixFlipLR(
				 FPix fpixd, 
				 FPix fpixs){

	IntPtr fpixdPtr = IntPtr.Zero; 	if (fpixd != null) {fpixdPtr = fpixd.Pointer;}

	IntPtr _Result = Natives.fpixFlipLR(fpixdPtr, fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (1973, 1)
// fpixFlipTB(fpixd, fpixs) as FPix
// fpixFlipTB(FPIX *, FPIX *) as FPIX *
///  <summary>
/// (1) This does a top-bottom flip of the image, which is
/// equivalent to a rotation out of the plane about a
/// horizontal line through the image center.<para/>
/// 
/// (2) There are 3 cases for input:
/// (a) fpixd == null (creates a new fpixd)
/// (b) fpixd == fpixs (in-place operation)
/// (c) fpixd != fpixs (existing fpixd)<para/>
/// 
/// (3) For clarity, use these three patterns, respectively:
/// (a) fpixd = fpixFlipTB(NULL, fpixs)
/// (b) fpixFlipTB(fpixs, fpixs)
/// (c) fpixFlipTB(fpixd, fpixs)<para/>
/// 
/// (4) If an existing fpixd is not the same size as fpixs, the
/// image data will be reallocated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixFlipTB/*"/>
///  <param name="fpixd">[in][optional] - can be null, equal to fpixs, or different from fpixs</param>
///  <param name="fpixs">[in] - </param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixFlipTB(
				 FPix fpixd, 
				 FPix fpixs){

	IntPtr fpixdPtr = IntPtr.Zero; 	if (fpixd != null) {fpixdPtr = fpixd.Pointer;}

	IntPtr _Result = Natives.fpixFlipTB(fpixdPtr, fpixs.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (2035, 1)
// fpixAffinePta(fpixs, ptad, ptas, border, inval) as FPix
// fpixAffinePta(FPIX *, PTA *, PTA *, l_int32, l_float32) as FPIX *
///  <summary>
/// (1) If %border  is greater  0, all four sides are extended by that distance,
/// and removed after the transformation is finished.  Pixels
/// that would be brought in to the trimmed result from outside
/// the extended region are assigned %inval.  The purpose of
/// extending the image is to avoid such assignments.<para/>
/// 
/// (2) On the other hand, you may want to give all pixels that
/// are brought in from outside fpixs a specific value.  In that
/// case, set %border == 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAffinePta/*"/>
///  <param name="fpixs">[in] - 8 bpp</param>
///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
///  <param name="border">[in] - size of extension with constant normal derivative</param>
///  <param name="inval">[in] - value brought in typ. 0</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAffinePta(
				 FPix fpixs, 
				 Pta ptad, 
				 Pta ptas, 
				 int border, 
				 Single inval){

	IntPtr _Result = Natives.fpixAffinePta(fpixs.Pointer, ptad.Pointer, ptas.Pointer,   border,   inval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (2092, 1)
// fpixAffine(fpixs, vc, inval) as FPix
// fpixAffine(FPIX *, l_float32 *, l_float32) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAffine/*"/>
///  <param name="fpixs">[in] - 8 bpp</param>
///  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
///  <param name="inval">[in] - value brought in typ. 0</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixAffine(
				 FPix fpixs, 
				 Single[] vc, 
				 Single inval){

	IntPtr _Result = Natives.fpixAffine(fpixs.Pointer,   vc,   inval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (2154, 1)
// fpixProjectivePta(fpixs, ptad, ptas, border, inval) as FPix
// fpixProjectivePta(FPIX *, PTA *, PTA *, l_int32, l_float32) as FPIX *
///  <summary>
/// (1) If %border  is greater  0, all four sides are extended by that distance,
/// and removed after the transformation is finished.  Pixels
/// that would be brought in to the trimmed result from outside
/// the extended region are assigned %inval.  The purpose of
/// extending the image is to avoid such assignments.<para/>
/// 
/// (2) On the other hand, you may want to give all pixels that
/// are brought in from outside fpixs a specific value.  In that
/// case, set %border == 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixProjectivePta/*"/>
///  <param name="fpixs">[in] - 8 bpp</param>
///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
///  <param name="border">[in] - size of extension with constant normal derivative</param>
///  <param name="inval">[in] - value brought in typ. 0</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixProjectivePta(
				 FPix fpixs, 
				 Pta ptad, 
				 Pta ptas, 
				 int border, 
				 Single inval){

	IntPtr _Result = Natives.fpixProjectivePta(fpixs.Pointer, ptad.Pointer, ptas.Pointer,   border,   inval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (2211, 1)
// fpixProjective(fpixs, vc, inval) as FPix
// fpixProjective(FPIX *, l_float32 *, l_float32) as FPIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixProjective/*"/>
///  <param name="fpixs">[in] - 8 bpp</param>
///  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
///  <param name="inval">[in] - value brought in typ. 0</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix fpixProjective(
				 FPix fpixs, 
				 Single[] vc, 
				 Single inval){

	IntPtr _Result = Natives.fpixProjective(fpixs.Pointer,   vc,   inval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}

// fpix2.c (2269, 1)
// linearInterpolatePixelFloat(datas, w, h, x, y, inval, pval) as int
// linearInterpolatePixelFloat(l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
///  <summary>
/// (1) This is a standard linear interpolation function.  It is
/// equivalent to area weighting on each component, and
/// avoids "jaggies" when rendering sharp edges.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/linearInterpolatePixelFloat/*"/>
///  <param name="datas">[in] - ptr to beginning of float image data</param>
///  <param name="w">[in] - of image</param>
///  <param name="h">[in] - of image</param>
///  <param name="x">[in] - floating pt location for evaluation</param>
///  <param name="y">[in] - floating pt location for evaluation</param>
///  <param name="inval">[in] - float value brought in from the outside when the input x,y location is outside the image</param>
///  <param name="pval">[out] - interpolated float value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int linearInterpolatePixelFloat(
				 Single[] datas, 
				 int w, 
				 int h, 
				 Single x, 
				 Single y, 
				 Single inval, 
				out Single pval){

	int _Result = Natives.linearInterpolatePixelFloat(  datas,   w,   h,   x,   y,   inval, out  pval);
	



	return _Result;
}

// fpix2.c (2333, 1)
// fpixThresholdToPix(fpix, thresh) as Pix
// fpixThresholdToPix(FPIX *, l_float32) as PIX *
///  <summary>
/// (1) For all values of fpix that are smaller or equal thresh, sets the pixel
/// in pixd to 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixThresholdToPix/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="thresh">[in] - </param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix fpixThresholdToPix(
				 FPix fpix, 
				 Single thresh){

	IntPtr _Result = Natives.fpixThresholdToPix(fpix.Pointer,   thresh);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// fpix2.c (2391, 1)
// pixComponentFunction(pix, rnum, gnum, bnum, rdenom, gdenom, bdenom) as FPix
// pixComponentFunction(PIX *, l_float32, l_float32, l_float32, l_float32, l_float32, l_float32) as FPIX *
///  <summary>
/// (1) This stores a function of the component values of each
/// input pixel in %fpixd.<para/>
/// 
/// (2) The function is a ratio of linear combinations of component values.
/// There are two special cases for denominator coefficients:
/// (a) The denominator is 1.0: input 0 for all denominator coefficients
/// (b) Only one component is used in the denominator: input 1.0
/// for that denominator component and 0.0 for the other two.<para/>
/// 
/// (3) If the denominator is 0, multiply by an arbitrary number that
/// is much larger than 1.  Choose 256 "arbitrarily".
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixComponentFunction/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="rnum">[in] - coefficients for numerator</param>
///  <param name="gnum">[in] - coefficients for numerator</param>
///  <param name="bnum">[in] - coefficients for numerator</param>
///  <param name="rdenom">[in] - coefficients for denominator</param>
///  <param name="gdenom">[in] - coefficients for denominator</param>
///  <param name="bdenom">[in] - coefficients for denominator</param>
///   <returns>fpixd, or NULL on error</returns>
public static FPix pixComponentFunction(
				 Pix pix, 
				 Single rnum, 
				 Single gnum, 
				 Single bnum, 
				 Single rdenom, 
				 Single gdenom, 
				 Single bdenom){

	IntPtr _Result = Natives.pixComponentFunction(pix.Pointer,   rnum,   gnum,   bnum,   rdenom,   gdenom,   bdenom);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new FPix(_Result);
}


}
}
