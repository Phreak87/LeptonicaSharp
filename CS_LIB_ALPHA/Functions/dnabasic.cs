using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// dnabasic.c (169, 1)
// l_dnaCreate(n) as L_Dna
// l_dnaCreate(l_int32) as L_DNA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaCreate/*"/>
///  <param name="n">[in] - size of number array to be alloc'd 0 for default</param>
///   <returns>da, or NULL on error</returns>
public static L_Dna l_dnaCreate(
				 int n){

	IntPtr _Result = Natives.l_dnaCreate(  n);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (210, 1)
// l_dnaCreateFromIArray(iarray, size) as L_Dna
// l_dnaCreateFromIArray(l_int32 *, l_int32) as L_DNA *
///  <summary>
/// (1) We can't insert this int array into the l_dna, because a l_dna
/// takes a double array.  So this just copies the data from the
/// input array into the l_dna.  The input array continues to be
/// owned by the caller.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaCreateFromIArray/*"/>
///  <param name="iarray">[in] - integer</param>
///  <param name="size">[in] - of the array</param>
///   <returns>da, or NULL on error</returns>
public static L_Dna l_dnaCreateFromIArray(
				 int[] iarray, 
				 int size){

	IntPtr _Result = Natives.l_dnaCreateFromIArray(  iarray,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (247, 1)
// l_dnaCreateFromDArray(darray, size, copyflag) as L_Dna
// l_dnaCreateFromDArray(l_float64 *, l_int32, l_int32) as L_DNA *
///  <summary>
/// (1) With L_INSERT, ownership of the input array is transferred
/// to the returned l_dna, and all %size elements are considered
/// to be valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaCreateFromDArray/*"/>
///  <param name="darray">[in] - float</param>
///  <param name="size">[in] - of the array</param>
///  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
///   <returns>da, or NULL on error</returns>
public static L_Dna l_dnaCreateFromDArray(
				 Double[] darray, 
				 int size, 
				 int copyflag){

	IntPtr _Result = Natives.l_dnaCreateFromDArray(  darray,   size,   copyflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (286, 1)
// l_dnaMakeSequence(startval, increment, size) as L_Dna
// l_dnaMakeSequence(l_float64, l_float64, l_int32) as L_DNA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaMakeSequence/*"/>
///  <param name="startval">[in] - </param>
///  <param name="increment">[in] - </param>
///  <param name="size">[in] - of sequence</param>
///   <returns>l_dna of sequence of evenly spaced values, or NULL on error</returns>
public static L_Dna l_dnaMakeSequence(
				 double startval, 
				 double increment, 
				 int size){

	IntPtr _Result = Natives.l_dnaMakeSequence(  startval,   increment,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (321, 1)
// l_dnaDestroy(pda) as Object
// l_dnaDestroy(L_DNA **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the l_dna.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaDestroy/*"/>
///  <param name="pda">[in,out] - to be nulled if it exists</param>
public static void l_dnaDestroy(
				ref L_Dna pda){

	IntPtr pdaPtr = IntPtr.Zero; 	if (pda != null) {pdaPtr = pda.Pointer;}

	Natives.l_dnaDestroy(ref pdaPtr);
	

	if (pdaPtr == IntPtr.Zero) {pda = null;} else { pda = new L_Dna(pdaPtr); };


}

// dnabasic.c (360, 1)
// l_dnaCopy(da) as L_Dna
// l_dnaCopy(L_DNA *) as L_DNA *
///  <summary>
/// (1) This removes unused ptrs above daton.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaCopy/*"/>
///  <param name="da">[in] - </param>
///   <returns>copy of da, or NULL on error</returns>
public static L_Dna l_dnaCopy(
				 L_Dna da){

	IntPtr _Result = Natives.l_dnaCopy(da.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (389, 1)
// l_dnaClone(da) as L_Dna
// l_dnaClone(L_DNA *) as L_DNA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaClone/*"/>
///  <param name="da">[in] - </param>
///   <returns>ptr to same da, or NULL on error</returns>
public static L_Dna l_dnaClone(
				 L_Dna da){

	IntPtr _Result = Natives.l_dnaClone(da.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (415, 1)
// l_dnaEmpty(da) as int
// l_dnaEmpty(L_DNA *) as l_ok
///  <summary>
/// (1) This does not change the allocation of the array.
/// It just clears the number of stored numbers, so that
/// the array appears to be empty.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaEmpty/*"/>
///  <param name="da">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaEmpty(
				 L_Dna da){

	int _Result = Natives.l_dnaEmpty(da.Pointer);
	



	return _Result;
}

// dnabasic.c (439, 1)
// l_dnaAddNumber(da, val) as int
// l_dnaAddNumber(L_DNA *, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaAddNumber/*"/>
///  <param name="da">[in] - </param>
///  <param name="val">[in] - float or int to be added stored as a float</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaAddNumber(
				 L_Dna da, 
				 double val){

	int _Result = Natives.l_dnaAddNumber(da.Pointer,   val);
	



	return _Result;
}

// dnabasic.c (500, 1)
// l_dnaInsertNumber(da, index, val) as int
// l_dnaInsertNumber(L_DNA *, l_int32, l_float64) as l_ok
///  <summary>
/// (1) This shifts da[i] to da[i + 1] for all i greater or equal index,
/// and then inserts val as da[index].<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaInsertNumber/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - location in da to insert new value</param>
///  <param name="val">[in] - float64 or integer to be added</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaInsertNumber(
				 L_Dna da, 
				 int index, 
				 double val){

	int _Result = Natives.l_dnaInsertNumber(da.Pointer,   index,   val);
	



	return _Result;
}

// dnabasic.c (539, 1)
// l_dnaRemoveNumber(da, index) as int
// l_dnaRemoveNumber(L_DNA *, l_int32) as l_ok
///  <summary>
/// (1) This shifts da[i] to da[i - 1] for all i  is greater  index.<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaRemoveNumber/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - element to be removed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaRemoveNumber(
				 L_Dna da, 
				 int index){

	int _Result = Natives.l_dnaRemoveNumber(da.Pointer,   index);
	



	return _Result;
}

// dnabasic.c (568, 1)
// l_dnaReplaceNumber(da, index, val) as int
// l_dnaReplaceNumber(L_DNA *, l_int32, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaReplaceNumber/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - element to be replaced</param>
///  <param name="val">[in] - new value to replace old one</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaReplaceNumber(
				 L_Dna da, 
				 int index, 
				 double val){

	int _Result = Natives.l_dnaReplaceNumber(da.Pointer,   index,   val);
	



	return _Result;
}

// dnabasic.c (597, 1)
// l_dnaGetCount(da) as int
// l_dnaGetCount(L_DNA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetCount/*"/>
///  <param name="da">[in] - </param>
///   <returns>count, or 0 if no numbers or on error</returns>
public static int l_dnaGetCount(
				 L_Dna da){

	int _Result = Natives.l_dnaGetCount(da.Pointer);
	



	return _Result;
}

// dnabasic.c (624, 1)
// l_dnaSetCount(da, newcount) as int
// l_dnaSetCount(L_DNA *, l_int32) as l_ok
///  <summary>
/// (1) If newcount smaller or equal datonalloc, this resets daton.
/// Using newcount = 0 is equivalent to l_dnaEmpty().<para/>
/// 
/// (2) If newcount  is greater  datonalloc, this causes a realloc
/// to a size datonalloc = newcount.<para/>
/// 
/// (3) All the previously unused values in da are set to 0.0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaSetCount/*"/>
///  <param name="da">[in] - </param>
///  <param name="newcount">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaSetCount(
				 L_Dna da, 
				 int newcount){

	int _Result = Natives.l_dnaSetCount(da.Pointer,   newcount);
	



	return _Result;
}

// dnabasic.c (658, 1)
// l_dnaGetDValue(da, index, pval) as int
// l_dnaGetDValue(L_DNA *, l_int32, l_float64 *) as l_ok
///  <summary>
/// (1) Caller may need to check the function return value to
/// decide if a 0.0 in the returned ival is valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetDValue/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - into l_dna</param>
///  <param name="pval">[out] - double value 0.0 on error</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaGetDValue(
				 L_Dna da, 
				 int index, 
				out Double[] pval){

	int _Result = Natives.l_dnaGetDValue(da.Pointer,   index, out  pval);
	



	return _Result;
}

// dnabasic.c (693, 1)
// l_dnaGetIValue(da, index, pival) as int
// l_dnaGetIValue(L_DNA *, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) Caller may need to check the function return value to
/// decide if a 0 in the returned ival is valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetIValue/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - into l_dna</param>
///  <param name="pival">[out] - integer value 0 on error</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaGetIValue(
				 L_Dna da, 
				 int index, 
				out int pival){

	int _Result = Natives.l_dnaGetIValue(da.Pointer,   index, out  pival);
	



	return _Result;
}

// dnabasic.c (725, 1)
// l_dnaSetValue(da, index, val) as int
// l_dnaSetValue(L_DNA *, l_int32, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaSetValue/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - to element to be set</param>
///  <param name="val">[in] - to set element</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaSetValue(
				 L_Dna da, 
				 int index, 
				 double val){

	int _Result = Natives.l_dnaSetValue(da.Pointer,   index,   val);
	



	return _Result;
}

// dnabasic.c (750, 1)
// l_dnaShiftValue(da, index, diff) as int
// l_dnaShiftValue(L_DNA *, l_int32, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaShiftValue/*"/>
///  <param name="da">[in] - </param>
///  <param name="index">[in] - to element to change relative to the current value</param>
///  <param name="diff">[in] - increment if diff  is greater  0 or decrement if diff  is smaller 0</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaShiftValue(
				 L_Dna da, 
				 int index, 
				 double diff){

	int _Result = Natives.l_dnaShiftValue(da.Pointer,   index,   diff);
	



	return _Result;
}

// dnabasic.c (786, 1)
// l_dnaGetIArray(da) as int[]
// l_dnaGetIArray(L_DNA *) as l_int32 *
///  <summary>
/// (1) A copy of the array is made, because we need to
/// generate an integer array from the bare double array.
/// The caller is responsible for freeing the array.<para/>
/// 
/// (2) The array size is determined by the number of stored numbers,
/// not by the size of the allocated array in the l_dna.<para/>
/// 
/// (3) This function is provided to simplify calculations
/// using the bare internal array, rather than continually
/// calling accessors on the l_dna.  It is typically used
/// on an array of size 256.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetIArray/*"/>
///  <param name="da">[in] - </param>
///   <returns>a copy of the bare internal array, integerized by rounding, or NULL on error</returns>
public static int[] l_dnaGetIArray(
				 L_Dna da){

	int[] _Result = Natives.l_dnaGetIArray(da.Pointer);
	



	return _Result;
}

// dnabasic.c (831, 1)
// l_dnaGetDArray(da, copyflag) as Double[]
// l_dnaGetDArray(L_DNA *, l_int32) as l_float64 *
///  <summary>
/// (1) If copyflag == L_COPY, it makes a copy which the caller
/// is responsible for freeing.  Otherwise, it operates
/// directly on the bare array of the l_dna.<para/>
/// 
/// (2) Very important: for L_NOCOPY, any writes to the array
/// will be in the l_dna.  Do not write beyond the size of
/// the count field, because it will not be accessible
/// from the l_dna!  If necessary, be sure to set the count
/// field to a larger number (such as the alloc size)
/// BEFORE calling this function.  Creating with l_dnaMakeConstant()
/// is another way to insure full initialization.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetDArray/*"/>
///  <param name="da">[in] - </param>
///  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
///   <returns>either the bare internal array or a copy of it, or NULL on error</returns>
public static Double[] l_dnaGetDArray(
				 L_Dna da, 
				 int copyflag){

	Double[] _Result = Natives.l_dnaGetDArray(da.Pointer,   copyflag);
	



	return _Result;
}

// dnabasic.c (863, 1)
// l_dnaGetRefcount(da) as int
// l_dnaGetRefcount(L_DNA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetRefcount/*"/>
///  <param name="da">[in] - </param>
///   <returns>refcount, or UNDEF on error</returns>
public static int l_dnaGetRefcount(
				 L_Dna da){

	int _Result = Natives.l_dnaGetRefcount(da.Pointer);
	



	return _Result;
}

// dnabasic.c (881, 1)
// l_dnaChangeRefcount(da, delta) as int
// l_dnaChangeRefcount(L_DNA *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaChangeRefcount/*"/>
///  <param name="da">[in] - </param>
///  <param name="delta">[in] - change to be applied</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaChangeRefcount(
				 L_Dna da, 
				 int delta){

	int _Result = Natives.l_dnaChangeRefcount(da.Pointer,   delta);
	



	return _Result;
}

// dnabasic.c (902, 1)
// l_dnaGetParameters(da, pstartx, pdelx) as int
// l_dnaGetParameters(L_DNA *, l_float64 *, l_float64 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaGetParameters/*"/>
///  <param name="da">[in] - </param>
///  <param name="pstartx">[out][optional] - startx</param>
///  <param name="pdelx">[out][optional] - delx</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaGetParameters(
				 L_Dna da, 
				out Double[] pstartx, 
				out Double[] pdelx){

	int _Result = Natives.l_dnaGetParameters(da.Pointer, out  pstartx, out  pdelx);
	



	return _Result;
}

// dnabasic.c (932, 1)
// l_dnaSetParameters(da, startx, delx) as int
// l_dnaSetParameters(L_DNA *, l_float64, l_float64) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaSetParameters/*"/>
///  <param name="da">[in] - </param>
///  <param name="startx">[in] - x value corresponding to da[0]</param>
///  <param name="delx">[in] - difference in x values for the situation where the elements of da correspond to the evaulation of a function at equal intervals of size %delx</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaSetParameters(
				 L_Dna da, 
				 double startx, 
				 double delx){

	int _Result = Natives.l_dnaSetParameters(da.Pointer,   startx,   delx);
	



	return _Result;
}

// dnabasic.c (955, 1)
// l_dnaCopyParameters(dad, das) as int
// l_dnaCopyParameters(L_DNA *, L_DNA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaCopyParameters/*"/>
///  <param name="dad">[in] - destination DNuma</param>
///  <param name="das">[in] - source DNuma</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaCopyParameters(
				 L_Dna dad, 
				 L_Dna das){

	int _Result = Natives.l_dnaCopyParameters(dad.Pointer, das.Pointer);
	



	return _Result;
}

// dnabasic.c (981, 1)
// l_dnaRead(filename) as L_Dna
// l_dnaRead(const char *) as L_DNA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>da, or NULL on error</returns>
public static L_Dna l_dnaRead(
				 String filename){

	IntPtr _Result = Natives.l_dnaRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (1013, 1)
// l_dnaReadStream(fp) as L_Dna
// l_dnaReadStream(FILE *) as L_DNA *
///  <summary>
/// (1) fscanf takes %lf to read a double fprintf takes %f to write it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>da, or NULL on error</returns>
public static L_Dna l_dnaReadStream(
				 FILE fp){

	IntPtr _Result = Natives.l_dnaReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (1056, 1)
// l_dnaWrite(filename, da) as int
// l_dnaWrite(const char *, L_DNA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="da">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaWrite(
				 String filename, 
				 L_Dna da){

	int _Result = Natives.l_dnaWrite(  filename, da.Pointer);
	



	return _Result;
}

// dnabasic.c (1087, 1)
// l_dnaWriteStream(fp, da) as int
// l_dnaWriteStream(FILE *, L_DNA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="da">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaWriteStream(
				 FILE fp, 
				 L_Dna da){

	int _Result = Natives.l_dnaWriteStream(fp.Pointer, da.Pointer);
	



	return _Result;
}

// dnabasic.c (1127, 1)
// l_dnaaCreate(n) as L_Dnaa
// l_dnaaCreate(l_int32) as L_DNAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaCreate/*"/>
///  <param name="n">[in] - size of l_dna ptr array to be alloc'd 0 for default</param>
///   <returns>daa, or NULL on error</returns>
public static L_Dnaa l_dnaaCreate(
				 int n){

	IntPtr _Result = Natives.l_dnaaCreate(  n);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dnaa(_Result);
}

// dnabasic.c (1163, 1)
// l_dnaaCreateFull(nptr, n) as L_Dnaa
// l_dnaaCreateFull(l_int32, l_int32) as L_DNAA *
///  <summary>
/// (1) This allocates a dnaa and fills the array with allocated dnas.
/// In use, after calling this function, use
/// l_dnaaAddNumber(dnaa, index, val)
/// to add val to the index-th dna in dnaa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaCreateFull/*"/>
///  <param name="nptr">[in] - : size of dna ptr array to be alloc'd</param>
///  <param name="n">[in] - : size of individual dna arrays to be alloc'd 0 for default</param>
///   <returns>daa, or NULL on error</returns>
public static L_Dnaa l_dnaaCreateFull(
				 int nptr, 
				 int n){

	IntPtr _Result = Natives.l_dnaaCreateFull(  nptr,   n);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dnaa(_Result);
}

// dnabasic.c (1194, 1)
// l_dnaaTruncate(daa) as int
// l_dnaaTruncate(L_DNAA *) as l_ok
///  <summary>
/// (1) This identifies the largest index containing a dna that
/// has any numbers within it, destroys all dna beyond that
/// index, and resets the count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaTruncate/*"/>
///  <param name="daa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaTruncate(
				 L_Dnaa daa){

	int _Result = Natives.l_dnaaTruncate(daa.Pointer);
	



	return _Result;
}

// dnabasic.c (1228, 1)
// l_dnaaDestroy(pdaa) as Object
// l_dnaaDestroy(L_DNAA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaDestroy/*"/>
///  <param name="pdaa">[in,out] - to be nulled if it exists</param>
public static void l_dnaaDestroy(
				ref L_Dnaa pdaa){

	IntPtr pdaaPtr = IntPtr.Zero; 	if (pdaa != null) {pdaaPtr = pdaa.Pointer;}

	Natives.l_dnaaDestroy(ref pdaaPtr);
	

	if (pdaaPtr == IntPtr.Zero) {pdaa = null;} else { pdaa = new L_Dnaa(pdaaPtr); };


}

// dnabasic.c (1265, 1)
// l_dnaaAddDna(daa, da, copyflag) as int
// l_dnaaAddDna(L_DNAA *, L_DNA *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaAddDna/*"/>
///  <param name="daa">[in] - </param>
///  <param name="da">[in] - to be added</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaAddDna(
				 L_Dnaa daa, 
				 L_Dna da, 
				 int copyflag){

	int _Result = Natives.l_dnaaAddDna(daa.Pointer, da.Pointer,   copyflag);
	



	return _Result;
}

// dnabasic.c (1333, 1)
// l_dnaaGetCount(daa) as int
// l_dnaaGetCount(L_DNAA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaGetCount/*"/>
///  <param name="daa">[in] - </param>
///   <returns>count number of l_dna, or 0 if no l_dna or on error</returns>
public static int l_dnaaGetCount(
				 L_Dnaa daa){

	int _Result = Natives.l_dnaaGetCount(daa.Pointer);
	



	return _Result;
}

// dnabasic.c (1351, 1)
// l_dnaaGetDnaCount(daa, index) as int
// l_dnaaGetDnaCount(L_DNAA *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaGetDnaCount/*"/>
///  <param name="daa">[in] - </param>
///  <param name="index">[in] - of l_dna in daa</param>
///   <returns>count of numbers in the referenced l_dna, or 0 on error.</returns>
public static int l_dnaaGetDnaCount(
				 L_Dnaa daa, 
				 int index){

	int _Result = Natives.l_dnaaGetDnaCount(daa.Pointer,   index);
	



	return _Result;
}

// dnabasic.c (1372, 1)
// l_dnaaGetNumberCount(daa) as int
// l_dnaaGetNumberCount(L_DNAA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaGetNumberCount/*"/>
///  <param name="daa">[in] - </param>
///   <returns>count total number of numbers in the l_dnaa, or 0 if no numbers or on error</returns>
public static int l_dnaaGetNumberCount(
				 L_Dnaa daa){

	int _Result = Natives.l_dnaaGetNumberCount(daa.Pointer);
	



	return _Result;
}

// dnabasic.c (1402, 1)
// l_dnaaGetDna(daa, index, accessflag) as L_Dna
// l_dnaaGetDna(L_DNAA *, l_int32, l_int32) as L_DNA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaGetDna/*"/>
///  <param name="daa">[in] - </param>
///  <param name="index">[in] - to the index-th l_dna</param>
///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
///   <returns>l_dna, or NULL on error</returns>
public static L_Dna l_dnaaGetDna(
				 L_Dnaa daa, 
				 int index, 
				 int accessflag){

	IntPtr _Result = Natives.l_dnaaGetDna(daa.Pointer,   index,   accessflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dna(_Result);
}

// dnabasic.c (1438, 1)
// l_dnaaReplaceDna(daa, index, da) as int
// l_dnaaReplaceDna(L_DNAA *, l_int32, L_DNA *) as l_ok
///  <summary>
/// (1) Any existing l_dna is destroyed, and the input one
/// is inserted in its place.<para/>
/// 
/// (2) If the index is invalid, return 1 (error)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaReplaceDna/*"/>
///  <param name="daa">[in] - </param>
///  <param name="index">[in] - to the index-th l_dna</param>
///  <param name="da">[in] - insert and replace any existing one</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaReplaceDna(
				 L_Dnaa daa, 
				 int index, 
				 L_Dna da){

	int _Result = Natives.l_dnaaReplaceDna(daa.Pointer,   index, da.Pointer);
	



	return _Result;
}

// dnabasic.c (1470, 1)
// l_dnaaGetValue(daa, i, j, pval) as int
// l_dnaaGetValue(L_DNAA *, l_int32, l_int32, l_float64 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaGetValue/*"/>
///  <param name="daa">[in] - </param>
///  <param name="i">[in] - index of l_dna within l_dnaa</param>
///  <param name="j">[in] - index into l_dna</param>
///  <param name="pval">[out] - double value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaGetValue(
				 L_Dnaa daa, 
				 int i, 
				 int j, 
				out Double[] pval){

	int _Result = Natives.l_dnaaGetValue(daa.Pointer,   i,   j, out  pval);
	



	return _Result;
}

// dnabasic.c (1510, 1)
// l_dnaaAddNumber(daa, index, val) as int
// l_dnaaAddNumber(L_DNAA *, l_int32, l_float64) as l_ok
///  <summary>
/// (1) Adds to an existing l_dna only.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaAddNumber/*"/>
///  <param name="daa">[in] - </param>
///  <param name="index">[in] - of l_dna within l_dnaa</param>
///  <param name="val">[in] - number to be added stored as a double</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaAddNumber(
				 L_Dnaa daa, 
				 int index, 
				 double val){

	int _Result = Natives.l_dnaaAddNumber(daa.Pointer,   index,   val);
	



	return _Result;
}

// dnabasic.c (1542, 1)
// l_dnaaRead(filename) as L_Dnaa
// l_dnaaRead(const char *) as L_DNAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>daa, or NULL on error</returns>
public static L_Dnaa l_dnaaRead(
				 String filename){

	IntPtr _Result = Natives.l_dnaaRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dnaa(_Result);
}

// dnabasic.c (1569, 1)
// l_dnaaReadStream(fp) as L_Dnaa
// l_dnaaReadStream(FILE *) as L_DNAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>daa, or NULL on error</returns>
public static L_Dnaa l_dnaaReadStream(
				 FILE fp){

	IntPtr _Result = Natives.l_dnaaReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Dnaa(_Result);
}

// dnabasic.c (1613, 1)
// l_dnaaWrite(filename, daa) as int
// l_dnaaWrite(const char *, L_DNAA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="daa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaWrite(
				 String filename, 
				 L_Dnaa daa){

	int _Result = Natives.l_dnaaWrite(  filename, daa.Pointer);
	



	return _Result;
}

// dnabasic.c (1644, 1)
// l_dnaaWriteStream(fp, daa) as int
// l_dnaaWriteStream(FILE *, L_DNAA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="daa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_dnaaWriteStream(
				 FILE fp, 
				 L_Dnaa daa){

	int _Result = Natives.l_dnaaWriteStream(fp.Pointer, daa.Pointer);
	



	return _Result;
}


}
}
