using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// kernel.c (106, 1)
// kernelCreate(height, width) as L_Kernel
// kernelCreate(l_int32, l_int32) as L_KERNEL *
///  <summary>
/// (1) kernelCreate() initializes all values to 0.<para/>
/// 
/// (2) After this call, (cy,cx) and nonzero data values must be
/// assigned.<para/>
/// 
/// (2) The number of kernel elements must be less than 2^29.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelCreate/*"/>
///  <param name="height">[in] - </param>
///  <param name="width">[in] - </param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel kernelCreate(
				 int height, 
				 int width){

	IntPtr _Result = Natives.kernelCreate(  height,   width);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (144, 1)
// kernelDestroy(pkel) as Object
// kernelDestroy(L_KERNEL **) as void
///  <summary>
/// kernelDestroy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelDestroy/*"/>
///  <param name="pkel">[in,out] - to be nulled</param>
public static void kernelDestroy(
				ref L_Kernel pkel){

	IntPtr pkelPtr = IntPtr.Zero; 	if (pkel != null) {pkelPtr = pkel.Pointer;}

	Natives.kernelDestroy(ref pkelPtr);
	
	if (pkelPtr == IntPtr.Zero) {pkel = null;} else { pkel = new L_Kernel(pkelPtr); };
}

// kernel.c (175, 1)
// kernelCopy(kels) as L_Kernel
// kernelCopy(L_KERNEL *) as L_KERNEL *
///  <summary>
/// kernelCopy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelCopy/*"/>
///  <param name="kels">[in] - source kernel</param>
///   <returns>keld copy of kels, or NULL on error</returns>
public static L_Kernel kernelCopy(
				 L_Kernel kels){

if (kels == null) {throw new ArgumentNullException  ("kels cannot be Nothing");}
	IntPtr _Result = Natives.kernelCopy(kels.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (211, 1)
// kernelGetElement(kel, row, col, pval) as int
// kernelGetElement(L_KERNEL *, l_int32, l_int32, l_float32 *) as l_ok
///  <summary>
/// kernelGetElement()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelGetElement/*"/>
///  <param name="kel">[in] - </param>
///  <param name="row">[in] - </param>
///  <param name="col">[in] - </param>
///  <param name="pval">[out] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int kernelGetElement(
				 L_Kernel kel, 
				 int row, 
				 int col, 
				out Single pval){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelGetElement(kel.Pointer,   row,   col, out  pval);
	
	return _Result;
}

// kernel.c (243, 1)
// kernelSetElement(kel, row, col, val) as int
// kernelSetElement(L_KERNEL *, l_int32, l_int32, l_float32) as l_ok
///  <summary>
/// kernelSetElement()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelSetElement/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="row">[in] - </param>
///  <param name="col">[in] - </param>
///  <param name="val">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int kernelSetElement(
				 L_Kernel kel, 
				 int row, 
				 int col, 
				 Single val){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelSetElement(kel.Pointer,   row,   col,   val);
	
	return _Result;
}

// kernel.c (270, 1)
// kernelGetParameters(kel, psy, psx, pcy, pcx) as int
// kernelGetParameters(L_KERNEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// kernelGetParameters()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelGetParameters/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="psy">[out][optional] - each can be null</param>
///  <param name="psx">[out][optional] - each can be null</param>
///  <param name="pcy">[out][optional] - each can be null</param>
///  <param name="pcx">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int kernelGetParameters(
				 L_Kernel kel, 
				out int psy, 
				out int psx, 
				out int pcy, 
				out int pcx){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelGetParameters(kel.Pointer, out  psy, out  psx, out  pcy, out  pcx);
	
	return _Result;
}

// kernel.c (300, 1)
// kernelSetOrigin(kel, cy, cx) as int
// kernelSetOrigin(L_KERNEL *, l_int32, l_int32) as l_ok
///  <summary>
/// kernelSetOrigin()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelSetOrigin/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="cy">[in] - </param>
///  <param name="cx">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int kernelSetOrigin(
				 L_Kernel kel, 
				 int cy, 
				 int cx){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelSetOrigin(kel.Pointer,   cy,   cx);
	
	return _Result;
}

// kernel.c (322, 1)
// kernelGetSum(kel, psum) as int
// kernelGetSum(L_KERNEL *, l_float32 *) as l_ok
///  <summary>
/// kernelGetSum()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelGetSum/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="psum">[out] - sum of all kernel values</param>
///   <returns>0 if OK, 1 on error</returns>
public static int kernelGetSum(
				 L_Kernel kel, 
				out Single psum){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelGetSum(kel.Pointer, out  psum);
	
	return _Result;
}

// kernel.c (354, 1)
// kernelGetMinMax(kel, pmin, pmax) as int
// kernelGetMinMax(L_KERNEL *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// kernelGetMinMax()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelGetMinMax/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="pmin">[out][optional] - minimum value</param>
///  <param name="pmax">[out][optional] - maximum value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int kernelGetMinMax(
				 L_Kernel kel, 
				out Single pmin, 
				out Single pmax){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelGetMinMax(kel.Pointer, out  pmin, out  pmax);
	
	return _Result;
}

// kernel.c (410, 1)
// kernelNormalize(kels, normsum) as L_Kernel
// kernelNormalize(L_KERNEL *, l_float32) as L_KERNEL *
///  <summary>
/// (1) If the sum of kernel elements is close to 0, do not
/// try to calculate the normalized kernel.  Instead,
/// return a copy of the input kernel, with a warning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelNormalize/*"/>
///  <param name="kels">[in] - source kel, to be normalized</param>
///  <param name="normsum">[in] - desired sum of elements in keld</param>
///   <returns>keld normalized version of kels, or NULL on error or if sum of elements is very close to 0)</returns>
public static L_Kernel kernelNormalize(
				 L_Kernel kels, 
				 Single normsum){

if (kels == null) {throw new ArgumentNullException  ("kels cannot be Nothing");}
	IntPtr _Result = Natives.kernelNormalize(kels.Pointer,   normsum);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (456, 1)
// kernelInvert(kels) as L_Kernel
// kernelInvert(L_KERNEL *) as L_KERNEL *
///  <summary>
/// (1) For convolution, the kernel is spatially inverted before
/// a "correlation" operation is done between the kernel and the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelInvert/*"/>
///  <param name="kels">[in] - source kel, to be inverted</param>
///   <returns>keld spatially inverted, about the origin, or NULL on error</returns>
public static L_Kernel kernelInvert(
				 L_Kernel kels){

if (kels == null) {throw new ArgumentNullException  ("kels cannot be Nothing");}
	IntPtr _Result = Natives.kernelInvert(kels.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (499, 1)
// create2dFloatArray(sy, sx) as List<Single[]>
// create2dFloatArray(l_int32, l_int32) as l_float32 **
///  <summary>
/// (1) The array[sy][sx] is indexed in standard "matrix notation",
/// with the row index first.<para/>
/// 
/// (2) The caller kernelCreate() limits the size to  is smaller 2^29 pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/create2dFloatArray/*"/>
///  <param name="sy">[in] - rows == height</param>
///  <param name="sx">[in] - columns == width</param>
///   <returns>doubly indexed array i.e., an array of sy row pointers, each of which points to an array of sx floats</returns>
public static List<Single[]> create2dFloatArray(
				 int sy, 
				 int sx){

	IntPtr _Result = Natives.create2dFloatArray(  sy,   sx);
	
	IntPtr[] PTRArr = new IntPtr[1];
	Marshal.Copy(_Result, PTRArr, 0, PTRArr.Length);
	List<Single[]> B = new List<Single[]>();
	foreach (IntPtr eintrag in PTRArr){{
	  Single[] SingleLST = new Single[1];
	  Marshal.Copy(eintrag, SingleLST, 0, SingleLST.Length);
	  B.Add(SingleLST);
	}}
	return B;
}

// kernel.c (526, 1)
// kernelRead(fname) as L_Kernel
// kernelRead(const char *) as L_KERNEL *
///  <summary>
/// kernelRead()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelRead/*"/>
///  <param name="fname">[in] - filename</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel kernelRead(
				 String fname){

if (fname == null) {throw new ArgumentNullException  ("fname cannot be Nothing");}
if (File.Exists (fname) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.kernelRead(  fname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (555, 1)
// kernelReadStream(fp) as L_Kernel
// kernelReadStream(FILE *) as L_KERNEL *
///  <summary>
/// kernelReadStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel kernelReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.kernelReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (598, 1)
// kernelWrite(fname, kel) as int
// kernelWrite(const char *, L_KERNEL *) as l_ok
///  <summary>
/// kernelWrite()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelWrite/*"/>
///  <param name="fname">[in] - output file</param>
///  <param name="kel">[in] - kernel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int kernelWrite(
				 String fname, 
				 L_Kernel kel){

if (fname == null) {throw new ArgumentNullException  ("fname cannot be Nothing");}
		if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelWrite(  fname, kel.Pointer);
	
	return _Result;
}

// kernel.c (627, 1)
// kernelWriteStream(fp, kel) as int
// kernelWriteStream(FILE *, L_KERNEL *) as l_ok
///  <summary>
/// kernelWriteStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="kel">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int kernelWriteStream(
				 FILE fp, 
				 L_Kernel kel){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	int _Result = Natives.kernelWriteStream(fp.Pointer, kel.Pointer);
	
	return _Result;
}

// kernel.c (679, 1)
// kernelCreateFromString(h, w, cy, cx, kdata) as L_Kernel
// kernelCreateFromString(l_int32, l_int32, l_int32, l_int32, const char *) as L_KERNEL *
///  <summary>
/// (1) The data is an array of chars, in row-major order, giving
/// space separated integers in the range [-255 ... 255].<para/>
/// 
/// (2) The only other formatting limitation is that you must
/// leave space between the last number in each row and
/// the double-quote.  If possible, it's also nice to have each
/// line in the string represent a line in the kernel e.g.,
/// static const char kdata =
/// " 20 50 20 "
/// " 70  140 70 "
/// " 20 50 20 "
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelCreateFromString/*"/>
///  <param name="h">[in] - height, width</param>
///  <param name="w">[in] - height, width</param>
///  <param name="cy">[in] - origin</param>
///  <param name="cx">[in] - origin</param>
///  <param name="kdata">[in] - </param>
///   <returns>kernel of the given size, or NULL on error</returns>
public static L_Kernel kernelCreateFromString(
				 int h, 
				 int w, 
				 int cy, 
				 int cx, 
				 String kdata){

if (kdata == null) {throw new ArgumentNullException  ("kdata cannot be Nothing");}
	IntPtr _Result = Natives.kernelCreateFromString(  h,   w,   cy,   cx,   kdata);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (765, 1)
// kernelCreateFromFile(filename) as L_Kernel
// kernelCreateFromFile(const char *) as L_KERNEL *
///  <summary>
/// (1) The file contains, in the following order:
/// ~ Any number of comment lines starting with '#' are ignored
/// ~ The height and width of the kernel
/// ~ The y and x values of the kernel origin
/// ~ The kernel data, formatted as lines of numbers (integers
/// or floats) for the kernel values in row-major order,
/// and with no other punctuation.
/// (Note: this differs from kernelCreateFromString(),
/// where each line must begin and end with a double-quote
/// to tell the compiler it's part of a string.)
/// ~ The kernel specification ends when a blank line,
/// a comment line, or the end of file is reached.<para/>
/// 
/// (2) All lines must be left-justified.<para/>
/// 
/// (3) See kernelCreateFromString() for a description of the string
/// format for the kernel data.  As an example, here are the lines
/// of a valid kernel description file  In the file, all lines
/// are left-justified:
/// \code
/// # small 3x3 kernel
/// 3 3
/// 1 1
/// 25.5 51  24.3
/// 70.2  146.3  73.4
/// 20 50.9  18.4
/// \endcode
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelCreateFromFile/*"/>
///  <param name="filename">[in] - </param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel kernelCreateFromFile(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.kernelCreateFromFile(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (865, 1)
// kernelCreateFromPix(pix, cy, cx) as L_Kernel
// kernelCreateFromPix(PIX *, l_int32, l_int32) as L_KERNEL *
///  <summary>
/// (1) The origin must be positive and within the dimensions of the pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelCreateFromPix/*"/>
///  <param name="pix">[in] - </param>
///  <param name="cy">[in] - origin of kernel</param>
///  <param name="cx">[in] - origin of kernel</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel kernelCreateFromPix(
				 Pix pix, 
				 int cy, 
				 int cx){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr _Result = Natives.kernelCreateFromPix(pix.Pointer,   cy,   cx);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (926, 1)
// kernelDisplayInPix(kel, size, gthick) as Pix
// kernelDisplayInPix(L_KERNEL *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This gives a visual representation of a kernel.<para/>
/// 
/// (2) There are two modes of display:
/// (a) Grid lines of minimum width 2, surrounding regions
/// representing kernel elements of minimum size 17,
/// with a "plus" mark at the kernel origin, or
/// (b) A pix without grid lines and using 1 pixel per kernel element.<para/>
/// 
/// (3) For both cases, the kernel absolute value is displayed,
/// normalized such that the maximum absolute value is 255.<para/>
/// 
/// (4) Large 2D separable kernels should be used for convolution
/// with two 1D kernels.  However, for the bilateral filter,
/// the computation time is independent of the size of the
/// 2D content kernel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/kernelDisplayInPix/*"/>
///  <param name="kel">[in] - kernel</param>
///  <param name="size">[in] - of grid interiors odd either 1 or a minimum size of 17 is enforced</param>
///  <param name="gthick">[in] - grid thickness either 0 or a minimum size of 2 is enforced</param>
///   <returns>pix display of kernel, or NULL on error</returns>
public static Pix kernelDisplayInPix(
				 L_Kernel kel, 
				 int size, 
				 int gthick){

if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	IntPtr _Result = Natives.kernelDisplayInPix(kel.Pointer,   size,   gthick);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// kernel.c (1040, 1)
// parseStringForNumbers(str, seps) as Numa
// parseStringForNumbers(const char *, const char *) as NUMA *
///  <summary>
/// (1) The numbers can be ints or floats.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/parseStringForNumbers/*"/>
///  <param name="str">[in] - string containing numbers not changed</param>
///  <param name="seps">[in] - string of characters that can be used between ints</param>
///   <returns>numa of numbers found, or NULL on error</returns>
public static Numa parseStringForNumbers(
				 String str, 
				 String seps){

if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}
		if (seps == null) {throw new ArgumentNullException  ("seps cannot be Nothing");}
	IntPtr _Result = Natives.parseStringForNumbers(  str,   seps);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// kernel.c (1092, 1)
// makeFlatKernel(height, width, cy, cx) as L_Kernel
// makeFlatKernel(l_int32, l_int32, l_int32, l_int32) as L_KERNEL *
///  <summary>
/// (1) This is the same low-pass filtering kernel that is used
/// in the block convolution functions.<para/>
/// 
/// (2) The kernel origin (%cy, %cx) is typically placed as near
/// the center of the kernel as possible.  If height and
/// width are odd, then using cy = height / 2 and
/// cx = width / 2 places the origin at the exact center.<para/>
/// 
/// (3) This returns a normalized kernel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeFlatKernel/*"/>
///  <param name="height">[in] - </param>
///  <param name="width">[in] - </param>
///  <param name="cy">[in] - origin of kernel</param>
///  <param name="cx">[in] - origin of kernel</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel makeFlatKernel(
				 int height, 
				 int width, 
				 int cy, 
				 int cx){

	IntPtr _Result = Natives.makeFlatKernel(  height,   width,   cy,   cx);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (1137, 1)
// makeGaussianKernel(halfheight, halfwidth, stdev, max) as L_Kernel
// makeGaussianKernel(l_int32, l_int32, l_float32, l_float32) as L_KERNEL *
///  <summary>
/// (1) The kernel size (sx, sy) = (2  halfwidth + 1, 2  halfheight + 1).<para/>
/// 
/// (2) The kernel center (cx, cy) = (halfwidth, halfheight).<para/>
/// 
/// (3) The halfwidth and halfheight are typically equal, and
/// are typically several times larger than the standard deviation.<para/>
/// 
/// (4) If pixConvolve() is invoked with normalization (the sum of
/// kernel elements = 1.0), use 1.0 for max (or any number that's
/// not too small or too large).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeGaussianKernel/*"/>
///  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="stdev">[in] - standard deviation</param>
///  <param name="max">[in] - value at (cx,cy)</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel makeGaussianKernel(
				 int halfheight, 
				 int halfwidth, 
				 Single stdev, 
				 Single max){

	IntPtr _Result = Natives.makeGaussianKernel(  halfheight,   halfwidth,   stdev,   max);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}

// kernel.c (1191, 1)
// makeGaussianKernelSep(halfheight, halfwidth, stdev, max, pkelx, pkely) as int
// makeGaussianKernelSep(l_int32, l_int32, l_float32, l_float32, L_KERNEL **, L_KERNEL **) as l_ok
///  <summary>
/// (1) See makeGaussianKernel() for description of input parameters.<para/>
/// 
/// (2) These kernels are constructed so that the result of both
/// normalized and un-normalized convolution will be the same
/// as when convolving with pixConvolve() using the full kernel.<para/>
/// 
/// (3) The trick for the un-normalized convolution is to have the
/// product of the two kernel elemets at (cx,cy) be equal to max,
/// not max2.  That's why the max for kely is 1.0.  If instead
/// we use sqrt(max) for both, the results are slightly less
/// accurate, when compared to using the full kernel in
/// makeGaussianKernel().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeGaussianKernelSep/*"/>
///  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="stdev">[in] - standard deviation</param>
///  <param name="max">[in] - value at (cx,cy)</param>
///  <param name="pkelx">[out] - x part of kernel</param>
///  <param name="pkely">[out] - y part of kernel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int makeGaussianKernelSep(
				 int halfheight, 
				 int halfwidth, 
				 Single stdev, 
				 Single max, 
				out L_Kernel pkelx, 
				out L_Kernel pkely){

	IntPtr pkelxPtr = IntPtr.Zero;
	IntPtr pkelyPtr = IntPtr.Zero;

	int _Result = Natives.makeGaussianKernelSep(  halfheight,   halfwidth,   stdev,   max, out pkelxPtr, out pkelyPtr);
	
	if (pkelxPtr == IntPtr.Zero) {pkelx = null;} else { pkelx = new L_Kernel(pkelxPtr); };
	if (pkelyPtr == IntPtr.Zero) {pkely = null;} else { pkely = new L_Kernel(pkelyPtr); };
	return _Result;
}

// kernel.c (1236, 1)
// makeDoGKernel(halfheight, halfwidth, stdev, ratio) as L_Kernel
// makeDoGKernel(l_int32, l_int32, l_float32, l_float32) as L_KERNEL *
///  <summary>
/// (1) The DoG (difference of gaussians) is a wavelet mother
/// function with null total sum.  By subtracting two blurred
/// versions of the image, it acts as a bandpass filter for
/// frequencies passed by the narrow gaussian but stopped
/// by the wide one.See:
/// http://en.wikipedia.org/wiki/Difference_of_Gaussians<para/>
/// 
/// (2) The kernel size (sx, sy) = (2  halfwidth + 1, 2  halfheight + 1).<para/>
/// 
/// (3) The kernel center (cx, cy) = (halfwidth, halfheight).<para/>
/// 
/// (4) The halfwidth and halfheight are typically equal, and
/// are typically several times larger than the standard deviation.<para/>
/// 
/// (5) The ratio is the ratio of standard deviations of the wide
/// to narrow gaussian.  It must be greater or equal 1.0 1.0 is a no-op.<para/>
/// 
/// (6) Because the kernel is a null sum, it must be invoked without
/// normalization in pixConvolve().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeDoGKernel/*"/>
///  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
///  <param name="stdev">[in] - standard deviation of narrower gaussian</param>
///  <param name="ratio">[in] - of stdev for wide filter to stdev for narrow one</param>
///   <returns>kernel, or NULL on error</returns>
public static L_Kernel makeDoGKernel(
				 int halfheight, 
				 int halfwidth, 
				 Single stdev, 
				 Single ratio){

	IntPtr _Result = Natives.makeDoGKernel(  halfheight,   halfwidth,   stdev,   ratio);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Kernel(_Result);
}


}
}
