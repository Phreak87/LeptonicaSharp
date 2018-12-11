using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// numabasic.c (187, 1)
// numaCreate(n) as Numa
// numaCreate(l_int32) as NUMA *
///  <summary>
/// numaCreate()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCreate/*"/>
///  <param name="n">[in] - size of number array to be alloc'd 0 for default</param>
///   <returns>na, or NULL on error</returns>
public static Numa numaCreate(
				 int n){

	IntPtr _Result = Natives.numaCreate(  n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (228, 1)
// numaCreateFromIArray(iarray, size) as Numa
// numaCreateFromIArray(l_int32 *, l_int32) as NUMA *
///  <summary>
/// (1) We can't insert this int array into the numa, because a numa
/// takes a float array.  So this just copies the data from the
/// input array into the numa.  The input array continues to be
/// owned by the caller.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCreateFromIArray/*"/>
///  <param name="iarray">[in] - integer</param>
///  <param name="size">[in] - of the array</param>
///   <returns>na, or NULL on error</returns>
public static Numa numaCreateFromIArray(
				 int[] iarray, 
				 int size){

if (iarray == null) {throw new ArgumentNullException  ("iarray cannot be Nothing");}
	IntPtr _Result = Natives.numaCreateFromIArray(  iarray,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (265, 1)
// numaCreateFromFArray(farray, size, copyflag) as Numa
// numaCreateFromFArray(l_float32 *, l_int32, l_int32) as NUMA *
///  <summary>
/// (1) With L_INSERT, ownership of the input array is transferred
/// to the returned numa, and all %size elements are considered
/// to be valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCreateFromFArray/*"/>
///  <param name="farray">[in] - float</param>
///  <param name="size">[in] - of the array</param>
///  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
///   <returns>na, or NULL on error</returns>
public static Numa numaCreateFromFArray(
				 Single[] farray, 
				 int size, 
				 int copyflag){

if (farray == null) {throw new ArgumentNullException  ("farray cannot be Nothing");}
	IntPtr _Result = Natives.numaCreateFromFArray(  farray,   size,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (309, 1)
// numaCreateFromString(str) as Numa
// numaCreateFromString(const char *) as NUMA *
///  <summary>
/// (1) The numbers can be ints or floats they will be interpreted
/// and stored as floats.  To use them as integers (e.g., for
/// indexing into arrays), use numaGetIValue(...).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCreateFromString/*"/>
///  <param name="str">[in] - string of comma-separated numbers</param>
///   <returns>na, or NULL on error</returns>
public static Numa numaCreateFromString(
				 String str){

if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}
	IntPtr _Result = Natives.numaCreateFromString(  str);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (360, 1)
// numaDestroy(pna) as Object
// numaDestroy(NUMA **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the numa.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaDestroy/*"/>
///  <param name="pna">[in,out] - to be nulled if it exists</param>
public static void numaDestroy(
				ref Numa pna){

	IntPtr pnaPtr = IntPtr.Zero; 	if (pna != null) {pnaPtr = pna.Pointer;}

	Natives.numaDestroy(ref pnaPtr);
	
	if (pnaPtr == IntPtr.Zero) {pna = null;} else { pna = new Numa(pnaPtr); };
}

// numabasic.c (394, 1)
// numaCopy(na) as Numa
// numaCopy(NUMA *) as NUMA *
///  <summary>
/// numaCopy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCopy/*"/>
///  <param name="na">[in] - </param>
///   <returns>copy of numa, or NULL on error</returns>
public static Numa numaCopy(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaCopy(na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (423, 1)
// numaClone(na) as Numa
// numaClone(NUMA *) as NUMA *
///  <summary>
/// numaClone()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaClone/*"/>
///  <param name="na">[in] - </param>
///   <returns>ptr to same numa, or NULL on error</returns>
public static Numa numaClone(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaClone(na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (449, 1)
// numaEmpty(na) as int
// numaEmpty(NUMA *) as l_ok
///  <summary>
/// (1) This does not change the allocation of the array.
/// It just clears the number of stored numbers, so that
/// the array appears to be empty.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaEmpty/*"/>
///  <param name="na">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int numaEmpty(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaEmpty(na.Pointer);
	
	return _Result;
}

// numabasic.c (473, 1)
// numaAddNumber(na, val) as int
// numaAddNumber(NUMA *, l_float32) as l_ok
///  <summary>
/// numaAddNumber()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaAddNumber/*"/>
///  <param name="na">[in] - </param>
///  <param name="val">[in] - float or int to be added stored as a float</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaAddNumber(
				 Numa na, 
				 Single val){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaAddNumber(na.Pointer,   val);
	
	return _Result;
}

// numabasic.c (534, 1)
// numaInsertNumber(na, index, val) as int
// numaInsertNumber(NUMA *, l_int32, l_float32) as l_ok
///  <summary>
/// (1) This shifts na[i] to na[i + 1] for all i greater or equal index,
/// and then inserts val as na[index].<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInsertNumber/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - location in na to insert new value</param>
///  <param name="val">[in] - float32 or integer to be added</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaInsertNumber(
				 Numa na, 
				 int index, 
				 Single val){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaInsertNumber(na.Pointer,   index,   val);
	
	return _Result;
}

// numabasic.c (573, 1)
// numaRemoveNumber(na, index) as int
// numaRemoveNumber(NUMA *, l_int32) as l_ok
///  <summary>
/// (1) This shifts na[i] to na[i - 1] for all i  is greater  index.<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaRemoveNumber/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - element to be removed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaRemoveNumber(
				 Numa na, 
				 int index){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaRemoveNumber(na.Pointer,   index);
	
	return _Result;
}

// numabasic.c (602, 1)
// numaReplaceNumber(na, index, val) as int
// numaReplaceNumber(NUMA *, l_int32, l_float32) as l_ok
///  <summary>
/// numaReplaceNumber()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaReplaceNumber/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - element to be replaced</param>
///  <param name="val">[in] - new value to replace old one</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaReplaceNumber(
				 Numa na, 
				 int index, 
				 Single val){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaReplaceNumber(na.Pointer,   index,   val);
	
	return _Result;
}

// numabasic.c (631, 1)
// numaGetCount(na) as int
// numaGetCount(NUMA *) as l_int32
///  <summary>
/// numaGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetCount/*"/>
///  <param name="na">[in] - </param>
///   <returns>count, or 0 if no numbers or on error</returns>
public static int numaGetCount(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetCount(na.Pointer);
	
	return _Result;
}

// numabasic.c (658, 1)
// numaSetCount(na, newcount) as int
// numaSetCount(NUMA *, l_int32) as l_ok
///  <summary>
/// (1) If newcount smaller or equal natonalloc, this resets naton.
/// Using newcount = 0 is equivalent to numaEmpty().<para/>
/// 
/// (2) If newcount  is greater  natonalloc, this causes a realloc
/// to a size natonalloc = newcount.<para/>
/// 
/// (3) All the previously unused values in na are set to 0.0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSetCount/*"/>
///  <param name="na">[in] - </param>
///  <param name="newcount">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaSetCount(
				 Numa na, 
				 int newcount){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaSetCount(na.Pointer,   newcount);
	
	return _Result;
}

// numabasic.c (692, 1)
// numaGetFValue(na, index, pval) as int
// numaGetFValue(NUMA *, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) Caller may need to check the function return value to
/// decide if a 0.0 in the returned ival is valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetFValue/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - into numa</param>
///  <param name="pval">[out] - float value 0.0 on error</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetFValue(
				 Numa na, 
				 int index, 
				out Single pval){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetFValue(na.Pointer,   index, out  pval);
	
	return _Result;
}

// numabasic.c (727, 1)
// numaGetIValue(na, index, pival) as int
// numaGetIValue(NUMA *, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) Caller may need to check the function return value to
/// decide if a 0 in the returned ival is valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetIValue/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - into numa</param>
///  <param name="pival">[out] - integer value 0 on error</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetIValue(
				 Numa na, 
				 int index, 
				out int pival){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetIValue(na.Pointer,   index, out  pival);
	
	return _Result;
}

// numabasic.c (759, 1)
// numaSetValue(na, index, val) as int
// numaSetValue(NUMA *, l_int32, l_float32) as l_ok
///  <summary>
/// numaSetValue()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSetValue/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - to element to be set</param>
///  <param name="val">[in] - to set element</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaSetValue(
				 Numa na, 
				 int index, 
				 Single val){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaSetValue(na.Pointer,   index,   val);
	
	return _Result;
}

// numabasic.c (784, 1)
// numaShiftValue(na, index, diff) as int
// numaShiftValue(NUMA *, l_int32, l_float32) as l_ok
///  <summary>
/// numaShiftValue()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaShiftValue/*"/>
///  <param name="na">[in] - </param>
///  <param name="index">[in] - to element to change relative to the current value</param>
///  <param name="diff">[in] - increment if diff  is greater  0 or decrement if diff  is smaller 0</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaShiftValue(
				 Numa na, 
				 int index, 
				 Single diff){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaShiftValue(na.Pointer,   index,   diff);
	
	return _Result;
}

// numabasic.c (820, 1)
// numaGetIArray(na) as int[]
// numaGetIArray(NUMA *) as l_int32 *
///  <summary>
/// (1) A copy of the array is always made, because we need to
/// generate an integer array from the bare float array.
/// The caller is responsible for freeing the array.<para/>
/// 
/// (2) The array size is determined by the number of stored numbers,
/// not by the size of the allocated array in the Numa.<para/>
/// 
/// (3) This function is provided to simplify calculations
/// using the bare internal array, rather than continually
/// calling accessors on the numa.  It is typically used
/// on an array of size 256.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetIArray/*"/>
///  <param name="na">[in] - </param>
///   <returns>a copy of the bare internal array, integerized by rounding, or NULL on error</returns>
public static int[] numaGetIArray(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int[] _Result = Natives.numaGetIArray(na.Pointer);
	
	return _Result;
}

// numabasic.c (865, 1)
// numaGetFArray(na, copyflag) as Single[]
// numaGetFArray(NUMA *, l_int32) as l_float32 *
///  <summary>
/// (1) If copyflag == L_COPY, it makes a copy which the caller
/// is responsible for freeing.  Otherwise, it operates
/// directly on the bare array of the numa.<para/>
/// 
/// (2) Very important: for L_NOCOPY, any writes to the array
/// will be in the numa.  Do not write beyond the size of
/// the count field, because it will not be accessible
/// from the numa!  If necessary, be sure to set the count
/// field to a larger number (such as the alloc size)
/// BEFORE calling this function.  Creating with numaMakeConstant()
/// is another way to insure full initialization.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetFArray/*"/>
///  <param name="na">[in] - </param>
///  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
///   <returns>either the bare internal array or a copy of it, or NULL on error</returns>
public static Single[] numaGetFArray(
				 Numa na, 
				 int copyflag){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	Single[] _Result = Natives.numaGetFArray(na.Pointer,   copyflag);
	
	return _Result;
}

// numabasic.c (897, 1)
// numaGetRefcount(na) as int
// numaGetRefcount(NUMA *) as l_int32
///  <summary>
/// numaGetRefCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetRefcount/*"/>
///  <param name="na">[in] - </param>
///   <returns>refcount, or UNDEF on error</returns>
public static int numaGetRefcount(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetRefcount(na.Pointer);
	
	return _Result;
}

// numabasic.c (915, 1)
// numaChangeRefcount(na, delta) as int
// numaChangeRefcount(NUMA *, l_int32) as l_ok
///  <summary>
/// numaChangeRefCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaChangeRefcount/*"/>
///  <param name="na">[in] - </param>
///  <param name="delta">[in] - change to be applied</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaChangeRefcount(
				 Numa na, 
				 int delta){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaChangeRefcount(na.Pointer,   delta);
	
	return _Result;
}

// numabasic.c (936, 1)
// numaGetParameters(na, pstartx, pdelx) as int
// numaGetParameters(NUMA *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// numaGetParameters()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetParameters/*"/>
///  <param name="na">[in] - </param>
///  <param name="pstartx">[out][optional] - startx</param>
///  <param name="pdelx">[out][optional] - delx</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaGetParameters(
				 Numa na, 
				out Single pstartx, 
				out Single pdelx){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetParameters(na.Pointer, out  pstartx, out  pdelx);
	
	return _Result;
}

// numabasic.c (966, 1)
// numaSetParameters(na, startx, delx) as int
// numaSetParameters(NUMA *, l_float32, l_float32) as l_ok
///  <summary>
/// numaSetParameters()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSetParameters/*"/>
///  <param name="na">[in] - </param>
///  <param name="startx">[in] - x value corresponding to na[0]</param>
///  <param name="delx">[in] - difference in x values for the situation where the elements of na correspond to the evaulation of a function at equal intervals of size %delx</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaSetParameters(
				 Numa na, 
				 Single startx, 
				 Single delx){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaSetParameters(na.Pointer,   startx,   delx);
	
	return _Result;
}

// numabasic.c (989, 1)
// numaCopyParameters(nad, nas) as int
// numaCopyParameters(NUMA *, NUMA *) as l_ok
///  <summary>
/// numaCopyParameters()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCopyParameters/*"/>
///  <param name="nad">[in] - destination Numa</param>
///  <param name="nas">[in] - source Numa</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaCopyParameters(
				 Numa nad, 
				 Numa nas){

if (nad == null) {throw new ArgumentNullException  ("nad cannot be Nothing");}
		if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	int _Result = Natives.numaCopyParameters(nad.Pointer, nas.Pointer);
	
	return _Result;
}

// numabasic.c (1027, 1)
// numaConvertToSarray(na, size1, size2, addzeros, type) as Sarray
// numaConvertToSarray(NUMA *, l_int32, l_int32, l_int32, l_int32) as SARRAY *
///  <summary>
/// (1) For integer conversion, size2 is ignored.
/// For float conversion, addzeroes is ignored.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaConvertToSarray/*"/>
///  <param name="na">[in] - </param>
///  <param name="size1">[in] - size of conversion field</param>
///  <param name="size2">[in] - for float conversion: size of field to the right of the decimal point</param>
///  <param name="addzeros">[in] - for integer conversion: to add lead zeros</param>
///  <param name="type">[in] - L_INTEGER_VALUE, L_FLOAT_VALUE</param>
///   <returns>a sarray of the float values converted to strings representing either integer or float values or NULL on error.</returns>
public static Sarray numaConvertToSarray(
				 Numa na, 
				 int size1, 
				 int size2, 
				 int addzeros, 
				 int type){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaConvertToSarray(na.Pointer,   size1,   size2,   addzeros,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// numabasic.c (1083, 1)
// numaRead(filename) as Numa
// numaRead(const char *) as NUMA *
///  <summary>
/// numaRead()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>na, or NULL on error</returns>
public static Numa numaRead(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.numaRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (1110, 1)
// numaReadStream(fp) as Numa
// numaReadStream(FILE *) as NUMA *
///  <summary>
/// numaReadStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>numa, or NULL on error</returns>
public static Numa numaReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.numaReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (1156, 1)
// numaReadMem(data, size) as Numa
// numaReadMem(const l_uint8 *, size_t) as NUMA *
///  <summary>
/// numaReadMem()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaReadMem/*"/>
///  <param name="data">[in] - numa serialization in ascii</param>
///  <param name="size">[in] - of data can use strlen to get it</param>
///   <returns>na, or NULL on error</returns>
public static Numa numaReadMem(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.numaReadMem(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (1193, 1)
// numaWriteDebug(filename, na) as int
// numaWriteDebug(const char *, NUMA *) as l_ok
///  <summary>
/// (1) Debug version, intended for use in the library when writing
/// to files in a temp directory with names that are compiled in.
/// This is used instead of numaWrite() for all such library calls.<para/>
/// 
/// (2) The global variable LeptDebugOK defaults to 0, and can be set
/// or cleared by the function setLeptDebugOK().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWriteDebug/*"/>
///  <param name="filename">[in] - </param>
///  <param name="na">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int numaWriteDebug(
				 String filename, 
				 Numa na){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaWriteDebug(  filename, na.Pointer);
	
	return _Result;
}

// numabasic.c (1214, 1)
// numaWrite(filename, na) as int
// numaWrite(const char *, NUMA *) as l_ok
///  <summary>
/// numaWrite()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="na">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaWrite(
				 String filename, 
				 Numa na){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaWrite(  filename, na.Pointer);
	
	return _Result;
}

// numabasic.c (1245, 1)
// numaWriteStream(fp, na) as int
// numaWriteStream(FILE *, NUMA *) as l_ok
///  <summary>
/// numaWriteStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="na">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaWriteStream(
				 FILE fp, 
				 Numa na){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaWriteStream(fp.Pointer, na.Pointer);
	
	return _Result;
}

// numabasic.c (1288, 1)
// numaWriteMem(pdata, psize, na) as int
// numaWriteMem(l_uint8 **, size_t *, NUMA *) as l_ok
///  <summary>
/// (1) Serializes a numa in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized numa ascii</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="na">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.numaWriteMem(out  pdataPtr, out  psize, na.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// numabasic.c (1339, 1)
// numaaCreate(n) as Numaa
// numaaCreate(l_int32) as NUMAA *
///  <summary>
/// numaaCreate()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaCreate/*"/>
///  <param name="n">[in] - size of numa ptr array to be alloc'd 0 for default</param>
///   <returns>naa, or NULL on error</returns>
public static Numaa numaaCreate(
				 int n){

	IntPtr _Result = Natives.numaaCreate(  n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// numabasic.c (1377, 1)
// numaaCreateFull(nptr, n) as Numaa
// numaaCreateFull(l_int32, l_int32) as NUMAA *
///  <summary>
/// (1) This allocates numaa and fills the array with allocated numas.
/// In use, after calling this function, use
/// numaaAddNumber(naa, index, val)
/// to add val to the index-th numa in naa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaCreateFull/*"/>
///  <param name="nptr">[in] - : size of numa ptr array to be alloc'd</param>
///  <param name="n">[in] - : size of individual numa arrays to be alloc'd 0 for default</param>
///   <returns>naa, or NULL on error</returns>
public static Numaa numaaCreateFull(
				 int nptr, 
				 int n){

	IntPtr _Result = Natives.numaaCreateFull(  nptr,   n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// numabasic.c (1408, 1)
// numaaTruncate(naa) as int
// numaaTruncate(NUMAA *) as l_ok
///  <summary>
/// (1) This identifies the largest index containing a numa that
/// has any numbers within it, destroys all numa beyond that
/// index, and resets the count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaTruncate/*"/>
///  <param name="naa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaTruncate(
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaTruncate(naa.Pointer);
	
	return _Result;
}

// numabasic.c (1442, 1)
// numaaDestroy(pnaa) as Object
// numaaDestroy(NUMAA **) as void
///  <summary>
/// numaaDestroy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaDestroy/*"/>
///  <param name="pnaa">[in,out] - to be nulled if it exists</param>
public static void numaaDestroy(
				ref Numaa pnaa){

	IntPtr pnaaPtr = IntPtr.Zero; 	if (pnaa != null) {pnaaPtr = pnaa.Pointer;}

	Natives.numaaDestroy(ref pnaaPtr);
	
	if (pnaaPtr == IntPtr.Zero) {pnaa = null;} else { pnaa = new Numaa(pnaaPtr); };
}

// numabasic.c (1480, 1)
// numaaAddNuma(naa, na, copyflag) as int
// numaaAddNuma(NUMAA *, NUMA *, l_int32) as l_ok
///  <summary>
/// numaaAddNuma()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaAddNuma/*"/>
///  <param name="naa">[in] - </param>
///  <param name="na">[in] - to be added</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaAddNuma(
				 Numaa naa, 
				 Numa na, 
				 int copyflag){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaaAddNuma(naa.Pointer, na.Pointer,   copyflag);
	
	return _Result;
}

// numabasic.c (1548, 1)
// numaaGetCount(naa) as int
// numaaGetCount(NUMAA *) as l_int32
///  <summary>
/// numaaGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetCount/*"/>
///  <param name="naa">[in] - </param>
///   <returns>count number of numa, or 0 if no numa or on error</returns>
public static int numaaGetCount(
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaGetCount(naa.Pointer);
	
	return _Result;
}

// numabasic.c (1566, 1)
// numaaGetNumaCount(naa, index) as int
// numaaGetNumaCount(NUMAA *, l_int32) as l_int32
///  <summary>
/// numaaGetNumaCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetNumaCount/*"/>
///  <param name="naa">[in] - </param>
///  <param name="index">[in] - of numa in naa</param>
///   <returns>count of numbers in the referenced numa, or 0 on error.</returns>
public static int numaaGetNumaCount(
				 Numaa naa, 
				 int index){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaGetNumaCount(naa.Pointer,   index);
	
	return _Result;
}

// numabasic.c (1587, 1)
// numaaGetNumberCount(naa) as int
// numaaGetNumberCount(NUMAA *) as l_int32
///  <summary>
/// numaaGetNumberCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetNumberCount/*"/>
///  <param name="naa">[in] - </param>
///   <returns>count total number of numbers in the numaa, or 0 if no numbers or on error</returns>
public static int numaaGetNumberCount(
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaGetNumberCount(naa.Pointer);
	
	return _Result;
}

// numabasic.c (1636, 1)
// numaaGetPtrArray(naa) as Numa
// numaaGetPtrArray(NUMAA *) as NUMA **
///  <summary>
/// (1) This function is convenient for doing direct manipulation on
/// a fixed size array of Numas.  To do this, it sets the count
/// to the full size of the allocated array of Numa ptrs.
/// The originating Numaa owns this array: DO NOT free it!<para/>
/// 
/// (2) Intended usage:
/// Numaa naa = numaaCreate(n)
/// Numa array = numaaGetPtrArray(naa)
/// ...  [manipulate Numas directly on the array]
/// numaaDestroy([and]naa)<para/>
/// 
/// (3) Cautions:
/// ~ Do not free this array it is owned by tne Numaa.
/// ~ Do not call any functions on the Numaa, other than
/// numaaDestroy() when you're finished with the array.
/// Adding a Numa will force a resize, destroying the ptr array.
/// ~ Do not address the array outside its allocated size.
/// With the bare array, there are no protections.  If the
/// allocated size is n, array[n] is an error.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetPtrArray/*"/>
///  <param name="naa">[in] - </param>
///   <returns>the internal array of ptrs to Numa, or NULL on error</returns>
public static Numa numaaGetPtrArray(
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	IntPtr _Result = Natives.numaaGetPtrArray(naa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	Numa B = new Numa(_Result);
	return B;
}

// numabasic.c (1657, 1)
// numaaGetNuma(naa, index, accessflag) as Numa
// numaaGetNuma(NUMAA *, l_int32, l_int32) as NUMA *
///  <summary>
/// numaaGetNuma()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetNuma/*"/>
///  <param name="naa">[in] - </param>
///  <param name="index">[in] - to the index-th numa</param>
///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
///   <returns>numa, or NULL on error</returns>
public static Numa numaaGetNuma(
				 Numaa naa, 
				 int index, 
				 int accessflag){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	IntPtr _Result = Natives.numaaGetNuma(naa.Pointer,   index,   accessflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numabasic.c (1693, 1)
// numaaReplaceNuma(naa, index, na) as int
// numaaReplaceNuma(NUMAA *, l_int32, NUMA *) as l_ok
///  <summary>
/// (1) Any existing numa is destroyed, and the input one
/// is inserted in its place.<para/>
/// 
/// (2) If the index is invalid, return 1 (error)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaReplaceNuma/*"/>
///  <param name="naa">[in] - </param>
///  <param name="index">[in] - to the index-th numa</param>
///  <param name="na">[in] - insert and replace any existing one</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaReplaceNuma(
				 Numaa naa, 
				 int index, 
				 Numa na){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaaReplaceNuma(naa.Pointer,   index, na.Pointer);
	
	return _Result;
}

// numabasic.c (1726, 1)
// numaaGetValue(naa, i, j, pfval, pival) as int
// numaaGetValue(NUMAA *, l_int32, l_int32, l_float32 *, l_int32 *) as l_ok
///  <summary>
/// numaaGetValue()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaGetValue/*"/>
///  <param name="naa">[in] - </param>
///  <param name="i">[in] - index of numa within numaa</param>
///  <param name="j">[in] - index into numa</param>
///  <param name="pfval">[out][optional] - float value</param>
///  <param name="pival">[out][optional] - int value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaGetValue(
				 Numaa naa, 
				 int i, 
				 int j, 
				out Single pfval, 
				out int pival){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaGetValue(naa.Pointer,   i,   j, out  pfval, out  pival);
	
	return _Result;
}

// numabasic.c (1769, 1)
// numaaAddNumber(naa, index, val) as int
// numaaAddNumber(NUMAA *, l_int32, l_float32) as l_ok
///  <summary>
/// (1) Adds to an existing numa only.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaAddNumber/*"/>
///  <param name="naa">[in] - </param>
///  <param name="index">[in] - of numa within numaa</param>
///  <param name="val">[in] - float or int to be added stored as a float</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaAddNumber(
				 Numaa naa, 
				 int index, 
				 Single val){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaAddNumber(naa.Pointer,   index,   val);
	
	return _Result;
}

// numabasic.c (1801, 1)
// numaaRead(filename) as Numaa
// numaaRead(const char *) as NUMAA *
///  <summary>
/// numaaRead()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>naa, or NULL on error</returns>
public static Numaa numaaRead(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.numaaRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// numabasic.c (1828, 1)
// numaaReadStream(fp) as Numaa
// numaaReadStream(FILE *) as NUMAA *
///  <summary>
/// numaaReadStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>naa, or NULL on error</returns>
public static Numaa numaaReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.numaaReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// numabasic.c (1873, 1)
// numaaReadMem(data, size) as Numaa
// numaaReadMem(const l_uint8 *, size_t) as NUMAA *
///  <summary>
/// numaaReadMem()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaReadMem/*"/>
///  <param name="data">[in] - numaa serialization in ascii</param>
///  <param name="size">[in] - of data can use strlen to get it</param>
///   <returns>naa, or NULL on error</returns>
public static Numaa numaaReadMem(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.numaaReadMem(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// numabasic.c (1900, 1)
// numaaWrite(filename, naa) as int
// numaaWrite(const char *, NUMAA *) as l_ok
///  <summary>
/// numaaWrite()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="naa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaWrite(
				 String filename, 
				 Numaa naa){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaWrite(  filename, naa.Pointer);
	
	return _Result;
}

// numabasic.c (1931, 1)
// numaaWriteStream(fp, naa) as int
// numaaWriteStream(FILE *, NUMAA *) as l_ok
///  <summary>
/// numaaWriteStream()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="naa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaWriteStream(
				 FILE fp, 
				 Numaa naa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	int _Result = Natives.numaaWriteStream(fp.Pointer, naa.Pointer);
	
	return _Result;
}

// numabasic.c (1973, 1)
// numaaWriteMem(pdata, psize, naa) as int
// numaaWriteMem(l_uint8 **, size_t *, NUMAA *) as l_ok
///  <summary>
/// (1) Serializes a numaa in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized numaa ascii</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="naa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.numaaWriteMem(out  pdataPtr, out  psize, naa.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}


}
}
