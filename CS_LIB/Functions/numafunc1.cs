using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// numafunc1.c (153, 1)
// numaArithOp(nad, na1, na2, op) as Numa
// numaArithOp(NUMA *, NUMA *, NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) The sizes of na1 and na2 must be equal.<para/>
/// 
/// (2) nad can only null or equal to na1.<para/>
/// 
/// (3) To add a constant to a numa, or to multipy a numa by
/// a constant, use numaTransform().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaArithOp/*"/>
///  <param name="nad">[in][optional] - can be null or equal to na1 (in-place</param>
///  <param name="na1">[in] - </param>
///  <param name="na2">[in] - </param>
///  <param name="op">[in] - L_ARITH_ADD, L_ARITH_SUBTRACT, L_ARITH_MULTIPLY, L_ARITH_DIVIDE</param>
///   <returns>nad always: operation applied to na1 and na2</returns>
public static Numa numaArithOp(
				 Numa nad, 
				 Numa na1, 
				 Numa na2, 
				 int op){

if (na1 == null) {throw new ArgumentNullException  ("na1 cannot be Nothing");}
		if (na2 == null) {throw new ArgumentNullException  ("na2 cannot be Nothing");}
	IntPtr nadPtr = IntPtr.Zero; 	if (nad != null) {nadPtr = nad.Pointer;}

	IntPtr _Result = Natives.numaArithOp(nadPtr, na1.Pointer, na2.Pointer,   op);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (233, 1)
// numaLogicalOp(nad, na1, na2, op) as Numa
// numaLogicalOp(NUMA *, NUMA *, NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) The sizes of na1 and na2 must be equal.<para/>
/// 
/// (2) nad can only be null or equal to na1.<para/>
/// 
/// (3) This is intended for use with indicator arrays (0s and 1s).
/// Input data is extracted as integers (0 == false, anything
/// else == true) output results are 0 and 1.<para/>
/// 
/// (4) L_SUBTRACTION is subtraction of val2 from val1.  For bit logical
/// arithmetic this is (val1 [and] ~val2), but because these values
/// are integers, we use (val1 [and][and] !val2).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaLogicalOp/*"/>
///  <param name="nad">[in][optional] - can be null or equal to na1 (in-place</param>
///  <param name="na1">[in] - </param>
///  <param name="na2">[in] - </param>
///  <param name="op">[in] - L_UNION, L_INTERSECTION, L_SUBTRACTION, L_EXCLUSIVE_OR</param>
///   <returns>nad always: operation applied to na1 and na2</returns>
public static Numa numaLogicalOp(
				 Numa nad, 
				 Numa na1, 
				 Numa na2, 
				 int op){

if (na1 == null) {throw new ArgumentNullException  ("na1 cannot be Nothing");}
		if (na2 == null) {throw new ArgumentNullException  ("na2 cannot be Nothing");}
	IntPtr nadPtr = IntPtr.Zero; 	if (nad != null) {nadPtr = nad.Pointer;}

	IntPtr _Result = Natives.numaLogicalOp(nadPtr, na1.Pointer, na2.Pointer,   op);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (306, 1)
// numaInvert(nad, nas) as Numa
// numaInvert(NUMA *, NUMA *) as NUMA *
///  <summary>
/// (1) This is intended for use with indicator arrays (0s and 1s).
/// It gives a boolean-type output, taking the input as
/// an integer and inverting it:
/// 0  to  1
/// anything else  to 0
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInvert/*"/>
///  <param name="nad">[in][optional] - can be null or equal to nas (in-place</param>
///  <param name="nas">[in] - </param>
///   <returns>nad always: 'inverts' nas</returns>
public static Numa numaInvert(
				 Numa nad, 
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr nadPtr = IntPtr.Zero; 	if (nad != null) {nadPtr = nad.Pointer;}

	IntPtr _Result = Natives.numaInvert(nadPtr, nas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (351, 1)
// numaSimilar(na1, na2, maxdiff, psimilar) as int
// numaSimilar(NUMA *, NUMA *, l_float32, l_int32 *) as l_int32
///  <summary>
/// (1) Float values can differ slightly due to roundoff and
/// accumulated errors.  Using %maxdiff  is greater  0.0 allows similar
/// arrays to be identified.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSimilar/*"/>
///  <param name="na1">[in] - </param>
///  <param name="na2">[in] - </param>
///  <param name="maxdiff">[in] - use 0.0 for exact equality</param>
///  <param name="psimilar">[out] - 1 if similar 0 if different</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaSimilar(
				 Numa na1, 
				 Numa na2, 
				 Single maxdiff, 
				out int psimilar){

if (na1 == null) {throw new ArgumentNullException  ("na1 cannot be Nothing");}
		if (na2 == null) {throw new ArgumentNullException  ("na2 cannot be Nothing");}
	int _Result = Natives.numaSimilar(na1.Pointer, na2.Pointer,   maxdiff, out  psimilar);
	
	return _Result;
}

// numafunc1.c (400, 1)
// numaAddToNumber(na, index, val) as int
// numaAddToNumber(NUMA *, l_int32, l_float32) as l_ok
///  <summary>
/// (1) This is useful for accumulating sums, regardless of the index
/// order in which the values are made available.<para/>
/// 
/// (2) Before use, the numa has to be filled up to %index.  This would
/// typically be used by creating the numa with the full sized
/// array, initialized to 0.0, using numaMakeConstant().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaAddToNumber/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="index">[in] - element to be changed</param>
///  <param name="val">[in] - new value to be added</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaAddToNumber(
				 Numa na, 
				 int index, 
				 Single val){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaAddToNumber(na.Pointer,   index,   val);
	
	return _Result;
}

// numafunc1.c (431, 1)
// numaGetMin(na, pminval, piminloc) as int
// numaGetMin(NUMA *, l_float32 *, l_int32 *) as l_ok
///  <summary>
/// numaGetMin()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetMin/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pminval">[out][optional] - min value</param>
///  <param name="piminloc">[out][optional] - index of min location</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetMin(
				 Numa na, 
				out Single pminval, 
				out int piminloc){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetMin(na.Pointer, out  pminval, out  piminloc);
	
	return _Result;
}

// numafunc1.c (473, 1)
// numaGetMax(na, pmaxval, pimaxloc) as int
// numaGetMax(NUMA *, l_float32 *, l_int32 *) as l_ok
///  <summary>
/// numaGetMax()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetMax/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pmaxval">[out][optional] - max value</param>
///  <param name="pimaxloc">[out][optional] - index of max location</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetMax(
				 Numa na, 
				out Single pmaxval, 
				out int pimaxloc){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetMax(na.Pointer, out  pmaxval, out  pimaxloc);
	
	return _Result;
}

// numafunc1.c (514, 1)
// numaGetSum(na, psum) as int
// numaGetSum(NUMA *, l_float32 *) as l_ok
///  <summary>
/// numaGetSum()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetSum/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="psum">[out] - sum of values</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaGetSum(
				 Numa na, 
				out Single psum){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetSum(na.Pointer, out  psum);
	
	return _Result;
}

// numafunc1.c (553, 1)
// numaGetPartialSums(na) as Numa
// numaGetPartialSums(NUMA *) as NUMA *
///  <summary>
/// (1) nasum[i] is the sum for all j smaller or equal i of na[j].
/// So nasum[0] = na[0].<para/>
/// 
/// (2) If you want to generate a rank function, where rank[0] - 0.0,
/// insert a 0.0 at the beginning of the nasum array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetPartialSums/*"/>
///  <param name="na">[in] - source numa</param>
///   <returns>nasum, or NULL on error</returns>
public static Numa numaGetPartialSums(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaGetPartialSums(na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (586, 1)
// numaGetSumOnInterval(na, first, last, psum) as int
// numaGetSumOnInterval(NUMA *, l_int32, l_int32, l_float32 *) as l_ok
///  <summary>
/// numaGetSumOnInterval()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetSumOnInterval/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="first">[in] - beginning index</param>
///  <param name="last">[in] - final index</param>
///  <param name="psum">[out] - sum of values in the index interval range</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaGetSumOnInterval(
				 Numa na, 
				 int first, 
				 int last, 
				out Single psum){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetSumOnInterval(na.Pointer,   first,   last, out  psum);
	
	return _Result;
}

// numafunc1.c (632, 1)
// numaHasOnlyIntegers(na, maxsamples, pallints) as int
// numaHasOnlyIntegers(NUMA *, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) Set %maxsamples == 0 to check every integer in na.  Otherwise,
/// this samples no more than %maxsamples.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaHasOnlyIntegers/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="maxsamples">[in] - maximum number of samples to check</param>
///  <param name="pallints">[out] - 1 if all sampled values are ints else 0</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaHasOnlyIntegers(
				 Numa na, 
				 int maxsamples, 
				out int pallints){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaHasOnlyIntegers(na.Pointer,   maxsamples, out  pallints);
	
	return _Result;
}

// numafunc1.c (673, 1)
// numaSubsample(nas, subfactor) as Numa
// numaSubsample(NUMA *, l_int32) as NUMA *
///  <summary>
/// numaSubsample()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSubsample/*"/>
///  <param name="nas">[in] - </param>
///  <param name="subfactor">[in] - subsample factor, greater or equal 1</param>
///   <returns>nad evenly sampled values from nas, or NULL on error</returns>
public static Numa numaSubsample(
				 Numa nas, 
				 int subfactor){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaSubsample(nas.Pointer,   subfactor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (707, 1)
// numaMakeDelta(nas) as Numa
// numaMakeDelta(NUMA *) as NUMA *
///  <summary>
/// numaMakeDelta()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeDelta/*"/>
///  <param name="nas">[in] - input numa</param>
///   <returns>numa of difference values val[i+1] - val[i], or NULL on error</returns>
public static Numa numaMakeDelta(
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaMakeDelta(nas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (737, 1)
// numaMakeSequence(startval, increment, size) as Numa
// numaMakeSequence(l_float32, l_float32, l_int32) as NUMA *
///  <summary>
/// numaMakeSequence()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeSequence/*"/>
///  <param name="startval">[in] - </param>
///  <param name="increment">[in] - </param>
///  <param name="size">[in] - of sequence</param>
///   <returns>numa of sequence of evenly spaced values, or NULL on error</returns>
public static Numa numaMakeSequence(
				 Single startval, 
				 Single increment, 
				 int size){

	IntPtr _Result = Natives.numaMakeSequence(  startval,   increment,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (768, 1)
// numaMakeConstant(val, size) as Numa
// numaMakeConstant(l_float32, l_int32) as NUMA *
///  <summary>
/// numaMakeConstant()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeConstant/*"/>
///  <param name="val">[in] - </param>
///  <param name="size">[in] - of numa</param>
///   <returns>numa of given size with all entries equal to 'val', or NULL on error</returns>
public static Numa numaMakeConstant(
				 Single val, 
				 int size){

	IntPtr _Result = Natives.numaMakeConstant(  val,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (784, 1)
// numaMakeAbsValue(nad, nas) as Numa
// numaMakeAbsValue(NUMA *, NUMA *) as NUMA *
///  <summary>
/// numaMakeAbsValue()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeAbsValue/*"/>
///  <param name="nad">[in]can be null - for new array, or the same as nas for inplace</param>
///  <param name="nas">[in] - input numa</param>
///   <returns>nad with all numbers being the absval of the input, or NULL on error</returns>
public static Numa numaMakeAbsValue(
				 Numa nad, 
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr nadPtr = IntPtr.Zero; 	if (nad != null) {nadPtr = nad.Pointer;}

	IntPtr _Result = Natives.numaMakeAbsValue(nadPtr, nas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (818, 1)
// numaAddBorder(nas, left, right, val) as Numa
// numaAddBorder(NUMA *, l_int32, l_int32, l_float32) as NUMA *
///  <summary>
/// numaAddBorder()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaAddBorder/*"/>
///  <param name="nas">[in] - </param>
///  <param name="left">[in] - number of elements to add on each side</param>
///  <param name="right">[in] - number of elements to add on each side</param>
///  <param name="val">[in] - initialize border elements</param>
///   <returns>nad with added elements at left and right, or NULL on error</returns>
public static Numa numaAddBorder(
				 Numa nas, 
				 int left, 
				 int right, 
				 Single val){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaAddBorder(nas.Pointer,   left,   right,   val);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (860, 1)
// numaAddSpecifiedBorder(nas, left, right, type) as Numa
// numaAddSpecifiedBorder(NUMA *, l_int32, l_int32, l_int32) as NUMA *
///  <summary>
/// numaAddSpecifiedBorder()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaAddSpecifiedBorder/*"/>
///  <param name="nas">[in] - </param>
///  <param name="left">[in] - number of elements to add on each side</param>
///  <param name="right">[in] - number of elements to add on each side</param>
///  <param name="type">[in] - L_CONTINUED_BORDER, L_MIRRORED_BORDER</param>
///   <returns>nad with added elements at left and right, or NULL on error</returns>
public static Numa numaAddSpecifiedBorder(
				 Numa nas, 
				 int left, 
				 int right, 
				 int type){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaAddSpecifiedBorder(nas.Pointer,   left,   right,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (910, 1)
// numaRemoveBorder(nas, left, right) as Numa
// numaRemoveBorder(NUMA *, l_int32, l_int32) as NUMA *
///  <summary>
/// numaRemoveBorder()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaRemoveBorder/*"/>
///  <param name="nas">[in] - </param>
///  <param name="left">[in] - number of elements to remove from each side</param>
///  <param name="right">[in] - number of elements to remove from each side</param>
///   <returns>nad with removed elements at left and right, or NULL on error</returns>
public static Numa numaRemoveBorder(
				 Numa nas, 
				 int left, 
				 int right){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaRemoveBorder(nas.Pointer,   left,   right);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (951, 1)
// numaCountNonzeroRuns(na, pcount) as int
// numaCountNonzeroRuns(NUMA *, l_int32 *) as l_ok
///  <summary>
/// numaCountNonzeroRuns()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaCountNonzeroRuns/*"/>
///  <param name="na">[in] - e.g., of pixel counts in rows or columns</param>
///  <param name="pcount">[out] - number of nonzero runs</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaCountNonzeroRuns(
				 Numa na, 
				out int pcount){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaCountNonzeroRuns(na.Pointer, out  pcount);
	
	return _Result;
}

// numafunc1.c (990, 1)
// numaGetNonzeroRange(na, eps, pfirst, plast) as int
// numaGetNonzeroRange(NUMA *, l_float32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// numaGetNonzeroRange()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetNonzeroRange/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="eps">[in] - largest value considered to be zero</param>
///  <param name="pfirst">[out] - interval of array indices where values are nonzero</param>
///  <param name="plast">[out] - interval of array indices where values are nonzero</param>
///   <returns>0 if OK, 1 on error or if no nonzero range is found.</returns>
public static int numaGetNonzeroRange(
				 Numa na, 
				 Single eps, 
				out int pfirst, 
				out int plast){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetNonzeroRange(na.Pointer,   eps, out  pfirst, out  plast);
	
	return _Result;
}

// numafunc1.c (1041, 1)
// numaGetCountRelativeToZero(na, type, pcount) as int
// numaGetCountRelativeToZero(NUMA *, l_int32, l_int32 *) as l_ok
///  <summary>
/// numaGetCountRelativeToZero()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetCountRelativeToZero/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="type">[in] - L_LESS_THAN_ZERO, L_EQUAL_TO_ZERO, L_GREATER_THAN_ZERO</param>
///  <param name="pcount">[out] - count of values of given type</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaGetCountRelativeToZero(
				 Numa na, 
				 int type, 
				out int pcount){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetCountRelativeToZero(na.Pointer,   type, out  pcount);
	
	return _Result;
}

// numafunc1.c (1089, 1)
// numaClipToInterval(nas, first, last) as Numa
// numaClipToInterval(NUMA *, l_int32, l_int32) as NUMA *
///  <summary>
/// If you want the indices of the array values to be unchanged,
/// use first = 0.
/// Usage:
/// This is useful to clip a histogram that has a few nonzero
/// values to its nonzero range.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaClipToInterval/*"/>
///  <param name="nas">[in] - </param>
///  <param name="first">[in] - clipping interval</param>
///  <param name="last">[in] - clipping interval</param>
///   <returns>numa with the same values as the input, but clipped to the specified interval</returns>
public static Numa numaClipToInterval(
				 Numa nas, 
				 int first, 
				 int last){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaClipToInterval(nas.Pointer,   first,   last);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1137, 1)
// numaMakeThresholdIndicator(nas, thresh, type) as Numa
// numaMakeThresholdIndicator(NUMA *, l_float32, l_int32) as NUMA *
///  <summary>
/// (1) For each element in nas, if the constraint given by 'type'
/// correctly specifies its relation to thresh, a value of 1
/// is recorded in nad.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaMakeThresholdIndicator/*"/>
///  <param name="nas">[in] - input numa</param>
///  <param name="thresh">[in] - threshold value</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///   <returns></returns>
public static Numa numaMakeThresholdIndicator(
				 Numa nas, 
				 Single thresh, 
				 int type){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaMakeThresholdIndicator(nas.Pointer,   thresh,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1193, 1)
// numaUniformSampling(nas, nsamp) as Numa
// numaUniformSampling(NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) This resamples the values in the array, using %nsamp
/// equal divisions.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaUniformSampling/*"/>
///  <param name="nas">[in] - input numa</param>
///  <param name="nsamp">[in] - number of samples</param>
///   <returns></returns>
public static Numa numaUniformSampling(
				 Numa nas, 
				 int nsamp){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaUniformSampling(nas.Pointer,   nsamp);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1258, 1)
// numaReverse(nad, nas) as Numa
// numaReverse(NUMA *, NUMA *) as NUMA *
///  <summary>
/// (1) Usage:
/// numaReverse(nas, nas) // in-place
/// nad = numaReverse(NULL, nas)  // makes a new one
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaReverse/*"/>
///  <param name="nad">[in][optional] - can be null or equal to nas</param>
///  <param name="nas">[in] - input numa</param>
///   <returns></returns>
public static Numa numaReverse(
				 Numa nad, 
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr nadPtr = IntPtr.Zero; 	if (nad != null) {nadPtr = nad.Pointer;}

	IntPtr _Result = Natives.numaReverse(nadPtr, nas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1313, 1)
// numaLowPassIntervals(nas, thresh, maxn) as Numa
// numaLowPassIntervals(NUMA *, l_float32, l_float32) as NUMA *
///  <summary>
/// (1) For each interval where the value is less than a specified
/// fraction of the maximum, this records the left and right "x"
/// value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaLowPassIntervals/*"/>
///  <param name="nas">[in] - input numa</param>
///  <param name="thresh">[in] - threshold fraction of max in [0.0 ... 1.0]</param>
///  <param name="maxn">[in] - for normalizing set maxn = 0.0 to use the max in nas</param>
///   <returns></returns>
public static Numa numaLowPassIntervals(
				 Numa nas, 
				 Single thresh, 
				 Single maxn){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaLowPassIntervals(nas.Pointer,   thresh,   maxn);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1389, 1)
// numaThresholdEdges(nas, thresh1, thresh2, maxn) as Numa
// numaThresholdEdges(NUMA *, l_float32, l_float32, l_float32) as NUMA *
///  <summary>
/// (1) For each edge interval, where where the value is less
/// than %thresh1 on one side, greater than %thresh2 on
/// the other, and between these thresholds throughout the
/// interval, this records a triplet of values: the
/// 'left' and 'right' edges, and either +1 or -1, depending
/// on whether the edge is rising or falling.<para/>
/// 
/// (2) No assumption is made about the value outside the array,
/// so if the value at the array edge is between the threshold
/// values, it is not considered part of an edge.  We start
/// looking for edge intervals only after leaving the thresholded
/// band.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaThresholdEdges/*"/>
///  <param name="nas">[in] - input numa</param>
///  <param name="thresh1">[in] - low threshold as fraction of max in [0.0 ... 1.0]</param>
///  <param name="thresh2">[in] - high threshold as fraction of max in [0.0 ... 1.0]</param>
///  <param name="maxn">[in] - for normalizing set maxn = 0.0 to use the max in nas</param>
///   <returns></returns>
public static Numa numaThresholdEdges(
				 Numa nas, 
				 Single thresh1, 
				 Single thresh2, 
				 Single maxn){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaThresholdEdges(nas.Pointer,   thresh1,   thresh2,   maxn);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (1509, 1)
// numaGetSpanValues(na, span, pstart, pend) as int
// numaGetSpanValues(NUMA *, l_int32, l_int32 *, l_int32 *) as l_int32
///  <summary>
/// numaGetSpanValues()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetSpanValues/*"/>
///  <param name="na">[in] - numa that is output of numaLowPassIntervals()</param>
///  <param name="span">[in] - span number, zero-based</param>
///  <param name="pstart">[out][optional] - location of start of transition</param>
///  <param name="pend">[out][optional] - location of end of transition</param>
///   <returns></returns>
public static int numaGetSpanValues(
				 Numa na, 
				 int span, 
				out int pstart, 
				out int pend){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetSpanValues(na.Pointer,   span, out  pstart, out  pend);
	
	return _Result;
}

// numafunc1.c (1545, 1)
// numaGetEdgeValues(na, edge, pstart, pend, psign) as int
// numaGetEdgeValues(NUMA *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_int32
///  <summary>
/// numaGetEdgeValues()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetEdgeValues/*"/>
///  <param name="na">[in] - numa that is output of numaThresholdEdges()</param>
///  <param name="edge">[in] - edge number, zero-based</param>
///  <param name="pstart">[out][optional] - location of start of transition</param>
///  <param name="pend">[out][optional] - location of end of transition</param>
///  <param name="psign">[out][optional] - transition sign: +1 is rising, -1 is falling</param>
///   <returns></returns>
public static int numaGetEdgeValues(
				 Numa na, 
				 int edge, 
				out int pstart, 
				out int pend, 
				out int psign){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetEdgeValues(na.Pointer,   edge, out  pstart, out  pend, out  psign);
	
	return _Result;
}

// numafunc1.c (1602, 1)
// numaInterpolateEqxVal(startx, deltax, nay, type, xval, pyval) as int
// numaInterpolateEqxVal(l_float32, l_float32, NUMA *, l_int32, l_float32, l_float32 *) as l_ok
///  <summary>
/// (1) Considering nay as a function of x, the x values
/// are equally spaced<para/>
/// 
/// (2) Caller should check for valid return.
/// For linear Lagrangian interpolation (through 2 data pts):
/// y(x) = y1(x-x2)/(x1-x2) + y2(x-x1)/(x2-x1)
/// For quadratic Lagrangian interpolation (through 3 data pts):
/// y(x) = y1(x-x2)(x-x3)/((x1-x2)(x1-x3)) +
/// y2(x-x1)(x-x3)/((x2-x1)(x2-x3)) +
/// y3(x-x1)(x-x2)/((x3-x1)(x3-x2))
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInterpolateEqxVal/*"/>
///  <param name="startx">[in] - xval corresponding to first element in array</param>
///  <param name="deltax">[in] - x increment between array elements</param>
///  <param name="nay">[in] - numa of ordinate values, assumed equally spaced</param>
///  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
///  <param name="xval">[in] - </param>
///  <param name="pyval">[out] - interpolated value</param>
///   <returns>0 if OK, 1 on error e.g., if xval is outside range</returns>
public static int numaInterpolateEqxVal(
				 Single startx, 
				 Single deltax, 
				 Numa nay, 
				 int type, 
				 Single xval, 
				out Single pyval){

if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	int _Result = Natives.numaInterpolateEqxVal(  startx,   deltax, nay.Pointer,   type,   xval, out  pyval);
	
	return _Result;
}

// numafunc1.c (1695, 1)
// numaInterpolateArbxVal(nax, nay, type, xval, pyval) as int
// numaInterpolateArbxVal(NUMA *, NUMA *, l_int32, l_float32, l_float32 *) as l_ok
///  <summary>
/// (1) The values in nax must be sorted in increasing order.
/// If, additionally, they are equally spaced, you can use
/// numaInterpolateEqxVal().<para/>
/// 
/// (2) Caller should check for valid return.<para/>
/// 
/// (3) Uses lagrangian interpolation.  See numaInterpolateEqxVal()
/// for formulas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInterpolateArbxVal/*"/>
///  <param name="nax">[in] - numa of abscissa values</param>
///  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
///  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
///  <param name="xval">[in] - </param>
///  <param name="pyval">[out] - interpolated value</param>
///   <returns>0 if OK, 1 on error e.g., if xval is outside range</returns>
public static int numaInterpolateArbxVal(
				 Numa nax, 
				 Numa nay, 
				 int type, 
				 Single xval, 
				out Single pyval){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	int _Result = Natives.numaInterpolateArbxVal(nax.Pointer, nay.Pointer,   type,   xval, out  pyval);
	
	return _Result;
}

// numafunc1.c (1812, 1)
// numaInterpolateEqxInterval(startx, deltax, nasy, type, x0, x1, npts, pnax, pnay) as int
// numaInterpolateEqxInterval(l_float32, l_float32, NUMA *, l_int32, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
///  <summary>
/// (1) Considering nasy as a function of x, the x values
/// are equally spaced.<para/>
/// 
/// (2) This creates nay (and optionally nax) of interpolated
/// values over the specified interval (x0, x1).<para/>
/// 
/// (3) If the interval (x0, x1) lies partially outside the array
/// nasy (as interpreted by startx and deltax), it is an
/// error and returns 1.<para/>
/// 
/// (4) Note that deltax is the intrinsic x-increment for the input
/// array nasy, whereas delx is the intrinsic x-increment for the
/// output interpolated array nay.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInterpolateEqxInterval/*"/>
///  <param name="startx">[in] - xval corresponding to first element in nas</param>
///  <param name="deltax">[in] - x increment between array elements in nas</param>
///  <param name="nasy">[in] - numa of ordinate values, assumed equally spaced</param>
///  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
///  <param name="x0">[in] - start value of interval</param>
///  <param name="x1">[in] - end value of interval</param>
///  <param name="npts">[in] - number of points to evaluate function in interval</param>
///  <param name="pnax">[out][optional] - array of x values in interval</param>
///  <param name="pnay">[out] - array of y values in interval</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaInterpolateEqxInterval(
				 Single startx, 
				 Single deltax, 
				 Numa nasy, 
				 int type, 
				 Single x0, 
				 Single x1, 
				 int npts, 
				out Numa pnax, 
				out Numa pnay){

if (nasy == null) {throw new ArgumentNullException  ("nasy cannot be Nothing");}
	IntPtr pnaxPtr = IntPtr.Zero;
	IntPtr pnayPtr = IntPtr.Zero;

	int _Result = Natives.numaInterpolateEqxInterval(  startx,   deltax, nasy.Pointer,   type,   x0,   x1,   npts, out pnaxPtr, out pnayPtr);
	
	if (pnaxPtr == IntPtr.Zero) {pnax = null;} else { pnax = new Numa(pnaxPtr); };
	if (pnayPtr == IntPtr.Zero) {pnay = null;} else { pnay = new Numa(pnayPtr); };
	return _Result;
}

// numafunc1.c (1900, 1)
// numaInterpolateArbxInterval(nax, nay, type, x0, x1, npts, pnadx, pnady) as int
// numaInterpolateArbxInterval(NUMA *, NUMA *, l_int32, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
///  <summary>
/// (1) The values in nax must be sorted in increasing order.
/// If they are not sorted, we do it here, and complain.<para/>
/// 
/// (2) If the values in nax are equally spaced, you can use
/// numaInterpolateEqxInterval().<para/>
/// 
/// (3) Caller should check for valid return.<para/>
/// 
/// (4) We don't call numaInterpolateArbxVal() for each output
/// point, because that requires an O(n) search for
/// each point.  Instead, we do a single O(n) pass through
/// nax, saving the indices to be used for each output yval.<para/>
/// 
/// (5) Uses lagrangian interpolation.  See numaInterpolateEqxVal()
/// for formulas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInterpolateArbxInterval/*"/>
///  <param name="nax">[in] - numa of abscissa values</param>
///  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
///  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
///  <param name="x0">[in] - start value of interval</param>
///  <param name="x1">[in] - end value of interval</param>
///  <param name="npts">[in] - number of points to evaluate function in interval</param>
///  <param name="pnadx">[out][optional] - array of x values in interval</param>
///  <param name="pnady">[out] - array of y values in interval</param>
///   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
public static int numaInterpolateArbxInterval(
				 Numa nax, 
				 Numa nay, 
				 int type, 
				 Single x0, 
				 Single x1, 
				 int npts, 
				out Numa pnadx, 
				out Numa pnady){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	IntPtr pnadxPtr = IntPtr.Zero;
	IntPtr pnadyPtr = IntPtr.Zero;

	int _Result = Natives.numaInterpolateArbxInterval(nax.Pointer, nay.Pointer,   type,   x0,   x1,   npts, out pnadxPtr, out pnadyPtr);
	
	if (pnadxPtr == IntPtr.Zero) {pnadx = null;} else { pnadx = new Numa(pnadxPtr); };
	if (pnadyPtr == IntPtr.Zero) {pnady = null;} else { pnady = new Numa(pnadyPtr); };
	return _Result;
}

// numafunc1.c (2061, 1)
// numaFitMax(na, pmaxval, naloc, pmaxloc) as int
// numaFitMax(NUMA *, l_float32 *, NUMA *, l_float32 *) as l_ok
///  <summary>
/// If %naloc is given, there is no requirement that the
/// data points are evenly spaced.  Lagrangian interpolation
/// handles that.  The only requirement is that the
/// data points are ordered so that the values in naloc
/// are either increasing or decreasing.  We test to make
/// sure that the sizes of na and naloc are equal, and it
/// is assumed that the correspondences %na[i] as a function
/// of %naloc[i] are properly arranged for all i.
/// The formula for Lagrangian interpolation through 3 data pts is:
/// y(x) = y1(x-x2)(x-x3)/((x1-x2)(x1-x3)) +
/// y2(x-x1)(x-x3)/((x2-x1)(x2-x3)) +
/// y3(x-x1)(x-x2)/((x3-x1)(x3-x2))
/// Then the derivative, using the constants (c1,c2,c3) defined below,
/// is set to 0:
/// y'(x) = 2x(c1+c2+c3) - c1(x2+x3) - c2(x1+x3) - c3(x1+x2) = 0
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaFitMax/*"/>
///  <param name="na">[in] - numa of ordinate values, to fit a max to</param>
///  <param name="pmaxval">[out] - max value</param>
///  <param name="naloc">[in][optional] - associated numa of abscissa values</param>
///  <param name="pmaxloc">[out] - abscissa value that gives max value in na if naloc == null, this is given as an interpolated index value</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaFitMax(
				 Numa na, 
				out Single pmaxval, 
				 Numa naloc, 
				out Single pmaxloc){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr nalocPtr = IntPtr.Zero; 	if (naloc != null) {nalocPtr = naloc.Pointer;}

	int _Result = Natives.numaFitMax(na.Pointer, out  pmaxval, nalocPtr, out  pmaxloc);
	
	return _Result;
}

// numafunc1.c (2166, 1)
// numaDifferentiateInterval(nax, nay, x0, x1, npts, pnadx, pnady) as int
// numaDifferentiateInterval(NUMA *, NUMA *, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
///  <summary>
/// (1) The values in nax must be sorted in increasing order.
/// If they are not sorted, it is done in the interpolation
/// step, and a warning is issued.<para/>
/// 
/// (2) Caller should check for valid return.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaDifferentiateInterval/*"/>
///  <param name="nax">[in] - numa of abscissa values</param>
///  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
///  <param name="x0">[in] - start value of interval</param>
///  <param name="x1">[in] - end value of interval</param>
///  <param name="npts">[in] - number of points to evaluate function in interval</param>
///  <param name="pnadx">[out][optional] - array of x values in interval</param>
///  <param name="pnady">[out] - array of derivatives in interval</param>
///   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
public static int numaDifferentiateInterval(
				 Numa nax, 
				 Numa nay, 
				 Single x0, 
				 Single x1, 
				 int npts, 
				out Numa pnadx, 
				out Numa pnady){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	IntPtr pnadxPtr = IntPtr.Zero;
	IntPtr pnadyPtr = IntPtr.Zero;

	int _Result = Natives.numaDifferentiateInterval(nax.Pointer, nay.Pointer,   x0,   x1,   npts, out pnadxPtr, out pnadyPtr);
	
	if (pnadxPtr == IntPtr.Zero) {pnadx = null;} else { pnadx = new Numa(pnadxPtr); };
	if (pnadyPtr == IntPtr.Zero) {pnady = null;} else { pnady = new Numa(pnadyPtr); };
	return _Result;
}

// numafunc1.c (2249, 1)
// numaIntegrateInterval(nax, nay, x0, x1, npts, psum) as int
// numaIntegrateInterval(NUMA *, NUMA *, l_float32, l_float32, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) The values in nax must be sorted in increasing order.
/// If they are not sorted, it is done in the interpolation
/// step, and a warning is issued.<para/>
/// 
/// (2) Caller should check for valid return.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaIntegrateInterval/*"/>
///  <param name="nax">[in] - numa of abscissa values</param>
///  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
///  <param name="x0">[in] - start value of interval</param>
///  <param name="x1">[in] - end value of interval</param>
///  <param name="npts">[in] - number of points to evaluate function in interval</param>
///  <param name="psum">[out] - integral of function over interval</param>
///   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
public static int numaIntegrateInterval(
				 Numa nax, 
				 Numa nay, 
				 Single x0, 
				 Single x1, 
				 int npts, 
				out Single psum){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	int _Result = Natives.numaIntegrateInterval(nax.Pointer, nay.Pointer,   x0,   x1,   npts, out  psum);
	
	return _Result;
}

// numafunc1.c (2354, 1)
// numaSortGeneral(na, pnasort, pnaindex, pnainvert, sortorder, sorttype) as int
// numaSortGeneral(NUMA *, NUMA **, NUMA **, NUMA **, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Sorting can be confusing.  Here's an array of five values with
/// the results shown for the 3 output arrays.
/// na  nasort naindex nainvert
/// -----------------------------------
/// 3 9 2 3
/// 4 6 3 2
/// 9 4 1 0
/// 6 3 0 1
/// 1 1 4 4
/// Note that naindex is a LUT into na for the sorted array values,
/// and nainvert directly gives the sorted index values for the
/// input array.  It is useful to view naindex is as a map:
/// 0  to  2
/// 1  to  3
/// 2  to  1
/// 3  to  0
/// 4  to  4
/// and nainvert, the inverse of this map:
/// 0  to  3
/// 1  to  2
/// 2  to  0
/// 3  to  1
/// 4  to  4
/// We can write these relations symbolically as:
/// nasort[i] = na[naindex[i]]
/// na[i] = nasort[nainvert[i]]
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSortGeneral/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pnasort">[out][optional] - sorted numa</param>
///  <param name="pnaindex">[out][optional] - index of elements in na associated with each element of nasort</param>
///  <param name="pnainvert">[out][optional] - index of elements in nasort associated with each element of na</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///  <param name="sorttype">[in] - L_SHELL_SORT or L_BIN_SORT</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaSortGeneral(
				 Numa na, 
				out Numa pnasort, 
				out Numa pnaindex, 
				out Numa pnainvert, 
				 int sortorder, 
				 int sorttype){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr pnasortPtr = IntPtr.Zero;
	IntPtr pnaindexPtr = IntPtr.Zero;
	IntPtr pnainvertPtr = IntPtr.Zero;

	int _Result = Natives.numaSortGeneral(na.Pointer, out pnasortPtr, out pnaindexPtr, out pnainvertPtr,   sortorder,   sorttype);
	
	if (pnasortPtr == IntPtr.Zero) {pnasort = null;} else { pnasort = new Numa(pnasortPtr); };
	if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };
	if (pnainvertPtr == IntPtr.Zero) {pnainvert = null;} else { pnainvert = new Numa(pnainvertPtr); };
	return _Result;
}

// numafunc1.c (2408, 1)
// numaSortAutoSelect(nas, sortorder) as Numa
// numaSortAutoSelect(NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) This does either a shell sort or a bin sort, depending on
/// the number of elements in nas and the dynamic range.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSortAutoSelect/*"/>
///  <param name="nas">[in] - input numa</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>naout output sorted numa, or NULL on error</returns>
public static Numa numaSortAutoSelect(
				 Numa nas, 
				 int sortorder){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaSortAutoSelect(nas.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2444, 1)
// numaSortIndexAutoSelect(nas, sortorder) as Numa
// numaSortIndexAutoSelect(NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) This does either a shell sort or a bin sort, depending on
/// the number of elements in nas and the dynamic range.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSortIndexAutoSelect/*"/>
///  <param name="nas">[in] - </param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>nad indices of nas, sorted by value in nas, or NULL on error</returns>
public static Numa numaSortIndexAutoSelect(
				 Numa nas, 
				 int sortorder){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaSortIndexAutoSelect(nas.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2480, 1)
// numaChooseSortType(nas) as int
// numaChooseSortType(NUMA *) as l_int32
///  <summary>
/// (1) This selects either a shell sort or a bin sort, depending on
/// the number of elements in nas and the dynamic range.<para/>
/// 
/// (2) If there are negative values in nas, it selects shell sort.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaChooseSortType/*"/>
///  <param name="nas">[in] - to be sorted</param>
///   <returns>sorttype L_SHELL_SORT or L_BIN_SORT, or UNDEF on error.</returns>
public static int numaChooseSortType(
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	int _Result = Natives.numaChooseSortType(nas.Pointer);
	
	return _Result;
}

// numafunc1.c (2531, 1)
// numaSort(naout, nain, sortorder) as Numa
// numaSort(NUMA *, NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) Set naout = nain for in-place otherwise, set naout = NULL.<para/>
/// 
/// (2) Source: Shell sort, modified from K[and]R, 2nd edition, p.62.
/// Slow but simple O(n logn) sort.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSort/*"/>
///  <param name="naout">[in] - output numa can be NULL or equal to nain</param>
///  <param name="nain">[in] - input numa</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>naout output sorted numa, or NULL on error</returns>
public static Numa numaSort(
				 Numa naout, 
				 Numa nain, 
				 int sortorder){

if (naout == null) {throw new ArgumentNullException  ("naout cannot be Nothing");}
		if (nain == null) {throw new ArgumentNullException  ("nain cannot be Nothing");}
	IntPtr _Result = Natives.numaSort(naout.Pointer, nain.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2593, 1)
// numaBinSort(nas, sortorder) as Numa
// numaBinSort(NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) Because this uses a bin sort with buckets of size 1, it
/// is not appropriate for sorting either small arrays or
/// arrays containing very large integer values.  For such
/// arrays, use a standard general sort function like
/// numaSort().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaBinSort/*"/>
///  <param name="nas">[in] - of non-negative integers with a max that is typically less than 50,000</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>na sorted, or NULL on error</returns>
public static Numa numaBinSort(
				 Numa nas, 
				 int sortorder){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaBinSort(nas.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2621, 1)
// numaGetSortIndex(na, sortorder) as Numa
// numaGetSortIndex(NUMA *, l_int32) as NUMA *
///  <summary>
/// numaGetSortIndex()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetSortIndex/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>na giving an array of indices that would sort the input array, or NULL on error</returns>
public static Numa numaGetSortIndex(
				 Numa na, 
				 int sortorder){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaGetSortIndex(na.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2697, 1)
// numaGetBinSortIndex(nas, sortorder) as Numa
// numaGetBinSortIndex(NUMA *, l_int32) as NUMA *
///  <summary>
/// (1) This creates an array (or lookup table) that contains
/// the sorted position of the elements in the input Numa.<para/>
/// 
/// (2) Because it uses a bin sort with buckets of size 1, it
/// is not appropriate for sorting either small arrays or
/// arrays containing very large integer values.  For such
/// arrays, use a standard general sort function like
/// numaGetSortIndex().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetBinSortIndex/*"/>
///  <param name="nas">[in] - of non-negative integers with a max that is typically less than 1,000,000</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///   <returns>na sorted, or NULL on error</returns>
public static Numa numaGetBinSortIndex(
				 Numa nas, 
				 int sortorder){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaGetBinSortIndex(nas.Pointer,   sortorder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2770, 1)
// numaSortByIndex(nas, naindex) as Numa
// numaSortByIndex(NUMA *, NUMA *) as NUMA *
///  <summary>
/// numaSortByIndex()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSortByIndex/*"/>
///  <param name="nas">[in] - </param>
///  <param name="naindex">[in] - na that maps from the new numa to the input numa</param>
///   <returns>nad sorted, or NULL on error</returns>
public static Numa numaSortByIndex(
				 Numa nas, 
				 Numa naindex){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
		if (naindex == null) {throw new ArgumentNullException  ("naindex cannot be Nothing");}
	IntPtr _Result = Natives.numaSortByIndex(nas.Pointer, naindex.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2812, 1)
// numaIsSorted(nas, sortorder, psorted) as int
// numaIsSorted(NUMA *, l_int32, l_int32 *) as l_int32
///  <summary>
/// (1) This is a quick O(n) test if nas is sorted.  It is useful
/// in situations where the array is likely to be already
/// sorted, and a sort operation can be avoided.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaIsSorted/*"/>
///  <param name="nas">[in] - </param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///  <param name="psorted">[out] - 1 if sorted 0 if not</param>
///   <returns>1 if OK 0 on error</returns>
public static int numaIsSorted(
				 Numa nas, 
				 int sortorder, 
				out int psorted){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	int _Result = Natives.numaIsSorted(nas.Pointer,   sortorder, out  psorted);
	
	return _Result;
}

// numafunc1.c (2859, 1)
// numaSortPair(nax, nay, sortorder, pnasx, pnasy) as int
// numaSortPair(NUMA *, NUMA *, l_int32, NUMA **, NUMA **) as l_ok
///  <summary>
/// (1) This function sorts the two input arrays, nax and nay,
/// together, using nax as the key for sorting.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaSortPair/*"/>
///  <param name="nax">[in] - input arrays</param>
///  <param name="nay">[in] - input arrays</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
///  <param name="pnasx">[out] - sorted</param>
///  <param name="pnasy">[out] - sorted exactly in order of nasx</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaSortPair(
				 Numa nax, 
				 Numa nay, 
				 int sortorder, 
				out Numa pnasx, 
				out Numa pnasy){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	IntPtr pnasxPtr = IntPtr.Zero;
	IntPtr pnasyPtr = IntPtr.Zero;

	int _Result = Natives.numaSortPair(nax.Pointer, nay.Pointer,   sortorder, out pnasxPtr, out pnasyPtr);
	
	if (pnasxPtr == IntPtr.Zero) {pnasx = null;} else { pnasx = new Numa(pnasxPtr); };
	if (pnasyPtr == IntPtr.Zero) {pnasy = null;} else { pnasy = new Numa(pnasyPtr); };
	return _Result;
}

// numafunc1.c (2910, 1)
// numaInvertMap(nas) as Numa
// numaInvertMap(NUMA *) as NUMA *
///  <summary>
/// (1) This requires that nas contain each integer from 0 to n-1.
/// The array is typically an index array into a sort or permutation
/// of another array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaInvertMap/*"/>
///  <param name="nas">[in] - </param>
///   <returns>nad the inverted map, or NULL on error or if not invertible</returns>
public static Numa numaInvertMap(
				 Numa nas){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaInvertMap(nas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (2969, 1)
// numaPseudorandomSequence(size, seed) as Numa
// numaPseudorandomSequence(l_int32, l_int32) as NUMA *
///  <summary>
/// (1) This uses the Durstenfeld shuffle.
/// See: http://en.wikipedia.org/wiki/Fisherâ€“Yates_shuffle.
/// Result is a pseudorandom permutation of the sequence of integers
/// from 0 to size - 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaPseudorandomSequence/*"/>
///  <param name="size">[in] - of sequence</param>
///  <param name="seed">[in] - for random number generation</param>
///   <returns>na pseudorandom on {0,...,size - 1}, or NULL on error</returns>
public static Numa numaPseudorandomSequence(
				 int size, 
				 int seed){

	IntPtr _Result = Natives.numaPseudorandomSequence(  size,   seed);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (3008, 1)
// numaRandomPermutation(nas, seed) as Numa
// numaRandomPermutation(NUMA *, l_int32) as NUMA *
///  <summary>
/// numaRandomPermutation()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaRandomPermutation/*"/>
///  <param name="nas">[in] - input array</param>
///  <param name="seed">[in] - for random number generation</param>
///   <returns>nas randomly shuffled array, or NULL on error</returns>
public static Numa numaRandomPermutation(
				 Numa nas, 
				 int seed){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr _Result = Natives.numaRandomPermutation(nas.Pointer,   seed);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// numafunc1.c (3065, 1)
// numaGetRankValue(na, fract, nasort, usebins, pval) as int
// numaGetRankValue(NUMA *, l_float32, NUMA *, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) Computes the rank value of a number in the %na, which is
/// the number that is a fraction %fract from the small
/// end of the sorted version of %na.<para/>
/// 
/// (2) If you do this multiple times for different rank values,
/// sort the array in advance and use that for %nasort
/// if you're only calling this once, input %nasort == NULL.<para/>
/// 
/// (3) If %usebins == 1, this uses a bin sorting method.
/// Use this only where:
/// the numbers are non-negative integers
/// there are over 100 numbers
/// the maximum value is less than about 50,000<para/>
/// 
/// (4) The advantage of using a bin sort is that it is O(n),
/// instead of O(nlogn) for general sort routines.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetRankValue/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="fract">[in] - use 0.0 for smallest, 1.0 for largest</param>
///  <param name="nasort">[in][optional] - increasing sorted version of na</param>
///  <param name="usebins">[in] - 0 for general sort 1 for bin sort</param>
///  <param name="pval">[out] - rank val</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetRankValue(
				 Numa na, 
				 Single fract, 
				 Numa nasort, 
				 int usebins, 
				out Single pval){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr nasortPtr = IntPtr.Zero; 	if (nasort != null) {nasortPtr = nasort.Pointer;}

	int _Result = Natives.numaGetRankValue(na.Pointer,   fract, nasortPtr,   usebins, out  pval);
	
	return _Result;
}

// numafunc1.c (3119, 1)
// numaGetMedian(na, pval) as int
// numaGetMedian(NUMA *, l_float32 *) as l_ok
///  <summary>
/// (1) Computes the median value of the numbers in the numa, by
/// sorting and finding the middle value in the sorted array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetMedian/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pval">[out] - median value</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetMedian(
				 Numa na, 
				out Single pval){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetMedian(na.Pointer, out  pval);
	
	return _Result;
}

// numafunc1.c (3150, 1)
// numaGetBinnedMedian(na, pval) as int
// numaGetBinnedMedian(NUMA *, l_int32 *) as l_ok
///  <summary>
/// (1) Computes the median value of the numbers in the numa,
/// using bin sort and finding the middle value in the sorted array.<para/>
/// 
/// (2) See numaGetRankValue() for conditions on na for which
/// this should be used.  Otherwise, use numaGetMedian().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetBinnedMedian/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pval">[out] - integer median value</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetBinnedMedian(
				 Numa na, 
				out int pval){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetBinnedMedian(na.Pointer, out  pval);
	
	return _Result;
}

// numafunc1.c (3187, 1)
// numaGetMode(na, pval, pcount) as int
// numaGetMode(NUMA *, l_float32 *, l_int32 *) as l_ok
///  <summary>
/// (1) Computes the mode value of the numbers in the numa, by
/// sorting and finding the value of the number with the
/// largest count.<para/>
/// 
/// (2) Optionally, also returns that count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetMode/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pval">[out] - mode val</param>
///  <param name="pcount">[out][optional] - mode count</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetMode(
				 Numa na, 
				out Single pval, 
				out int pcount){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetMode(na.Pointer, out  pval, out  pcount);
	
	return _Result;
}

// numafunc1.c (3266, 1)
// numaGetMedianVariation(na, pmedval, pmedvar) as int
// numaGetMedianVariation(NUMA *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// (1) Finds the median of the absolute value of the variation from
/// the median value in the array.  Why take the absolute value?
/// Consider the case where you have values equally distributed
/// about both sides of a median value.  Without taking the absolute
/// value of the differences, you will get 0 for the variation,
/// and this is not useful.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaGetMedianVariation/*"/>
///  <param name="na">[in] - source numa</param>
///  <param name="pmedval">[out][optional] - median value</param>
///  <param name="pmedvar">[out] - median variation from median val</param>
///   <returns>0 if OK 1 on error</returns>
public static int numaGetMedianVariation(
				 Numa na, 
				out Single pmedval, 
				out Single pmedvar){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	int _Result = Natives.numaGetMedianVariation(na.Pointer, out  pmedval, out  pmedvar);
	
	return _Result;
}

// numafunc1.c (3319, 1)
// numaJoin(nad, nas, istart, iend) as int
// numaJoin(NUMA *, NUMA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (2) iend  is smaller 0 means 'read to the end'<para/>
/// 
/// (3) if nas == NULL, this is a no-op
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaJoin/*"/>
///  <param name="nad">[in] - dest numa add to this one</param>
///  <param name="nas">[in][optional] - source numa add from this one</param>
///  <param name="istart">[in] - starting index in nas</param>
///  <param name="iend">[in] - ending index in nas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaJoin(
				 Numa nad, 
				 Numa nas, 
				 int istart, 
				 int iend){

if (nad == null) {throw new ArgumentNullException  ("nad cannot be Nothing");}
	IntPtr nasPtr = IntPtr.Zero; 	if (nas != null) {nasPtr = nas.Pointer;}

	int _Result = Natives.numaJoin(nad.Pointer, nasPtr,   istart,   iend);
	
	return _Result;
}

// numafunc1.c (3368, 1)
// numaaJoin(naad, naas, istart, iend) as int
// numaaJoin(NUMAA *, NUMAA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (2) iend  is smaller 0 means 'read to the end'<para/>
/// 
/// (3) if naas == NULL, this is a no-op
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaJoin/*"/>
///  <param name="naad">[in] - dest naa add to this one</param>
///  <param name="naas">[in][optional] - source naa add from this one</param>
///  <param name="istart">[in] - starting index in nas</param>
///  <param name="iend">[in] - ending index in naas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaJoin(
				 Numaa naad, 
				 Numaa naas, 
				 int istart, 
				 int iend){

if (naad == null) {throw new ArgumentNullException  ("naad cannot be Nothing");}
	IntPtr naasPtr = IntPtr.Zero; 	if (naas != null) {naasPtr = naas.Pointer;}

	int _Result = Natives.numaaJoin(naad.Pointer, naasPtr,   istart,   iend);
	
	return _Result;
}

// numafunc1.c (3416, 1)
// numaaFlattenToNuma(naa) as Numa
// numaaFlattenToNuma(NUMAA *) as NUMA *
///  <summary>
/// (1) This 'flattens' the Numaa to a Numa, by joining successively
/// each Numa in the Numaa.<para/>
/// 
/// (2) It doesn't make any assumptions about the location of the
/// Numas in the Numaa array, unlike most Numaa functions.<para/>
/// 
/// (3) It leaves the input Numaa unchanged.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaFlattenToNuma/*"/>
///  <param name="naa">[in] - </param>
///   <returns>numa, or NULL on error</returns>
public static Numa numaaFlattenToNuma(
				 Numaa naa){

if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}
	IntPtr _Result = Natives.numaaFlattenToNuma(naa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}


}
}
