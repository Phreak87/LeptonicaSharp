Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\numafunc1.c (153, 1)
' numaArithOp(nad, na1, na2, op) as Numa
' numaArithOp(NUMA *, NUMA *, NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The sizes of na1 and na2 must be equal.<para/>
''' (2) nad can only null or equal to na1.<para/>
''' (3) To add a constant to a numa, or to multipy a numa by<para/>
''' a constant, use numaTransform().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaArithOp/*"/>
'''  <param name="nad">[in][optional] - can be null or equal to na1 (in-place</param>
'''  <param name="na1">[in] - </param>
'''  <param name="na2">[in] - </param>
'''  <param name="op">[in] - L_ARITH_ADD, L_ARITH_SUBTRACT, L_ARITH_MULTIPLY, L_ARITH_DIVIDE</param>
'''   <returns>nad always: operation applied to na1 and na2</returns>
Public Shared Function numaArithOp(
				 ByVal nad as Numa, 
				 ByVal na1 as Numa, 
				 ByVal na2 as Numa, 
				 ByVal op as Enumerations.L_arithmetic_logical_operator) as Numa

	If IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
	If IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")

	Dim nadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nad) Then nadPTR = nad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaArithOp( nadPTR, na1.Pointer, na2.Pointer, op)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (233, 1)
' numaLogicalOp(nad, na1, na2, op) as Numa
' numaLogicalOp(NUMA *, NUMA *, NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The sizes of na1 and na2 must be equal.<para/>
''' (2) nad can only be null or equal to na1.<para/>
''' (3) This is intended for use with indicator arrays (0s and 1s).<para/>
''' Input data is extracted as integers (0 == false, anything<para/>
''' else == true) output results are 0 and 1.<para/>
''' (4) L_SUBTRACTION is subtraction of val2 from val1.  For bit logical<para/>
''' arithmetic this is (val1  and  ~val2), but because these values<para/>
''' are integers, we use (val1  and  and  !val2).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaLogicalOp/*"/>
'''  <param name="nad">[in][optional] - can be null or equal to na1 (in-place</param>
'''  <param name="na1">[in] - </param>
'''  <param name="na2">[in] - </param>
'''  <param name="op">[in] - L_UNION, L_INTERSECTION, L_SUBTRACTION, L_EXCLUSIVE_OR</param>
'''   <returns>nad always: operation applied to na1 and na2</returns>
Public Shared Function numaLogicalOp(
				 ByVal nad as Numa, 
				 ByVal na1 as Numa, 
				 ByVal na2 as Numa, 
				 ByVal op as Enumerations.L_arithmetic_logical_operator) as Numa

	If IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
	If IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")

	Dim nadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nad) Then nadPTR = nad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaLogicalOp( nadPTR, na1.Pointer, na2.Pointer, op)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (306, 1)
' numaInvert(nad, nas) as Numa
' numaInvert(NUMA *, NUMA *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is intended for use with indicator arrays (0s and 1s).<para/>
''' It gives a boolean-type output, taking the input as<para/>
''' an integer and inverting it:<para/>
''' 0  -- is greater 1<para/>
''' anything else  -- is greater  0<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInvert/*"/>
'''  <param name="nad">[in][optional] - can be null or equal to nas (in-place</param>
'''  <param name="nas">[in] - </param>
'''   <returns>nad always: 'inverts' nas</returns>
Public Shared Function numaInvert(
				 ByVal nad as Numa, 
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim nadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nad) Then nadPTR = nad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaInvert( nadPTR, nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (351, 1)
' numaSimilar(na1, na2, maxdiff, psimilar) as Integer
' numaSimilar(NUMA *, NUMA *, l_float32, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Float values can differ slightly due to roundoff and<para/>
''' accumulated errors.  Using %maxdiff  is greater  0.0 allows similar<para/>
''' arrays to be identified.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSimilar/*"/>
'''  <param name="na1">[in] - </param>
'''  <param name="na2">[in] - </param>
'''  <param name="maxdiff">[in] - use 0.0 for exact equality</param>
'''  <param name="psimilar">[out] - 1 if similar 0 if different</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSimilar(
				 ByVal na1 as Numa, 
				 ByVal na2 as Numa, 
				 ByVal maxdiff as Single, 
				<Out()> ByRef psimilar as Integer) as Integer

	If IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
	If IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSimilar( na1.Pointer, na2.Pointer, maxdiff, psimilar)

	Return _Result
End Function

' SRC\numafunc1.c (400, 1)
' numaAddToNumber(na, index, val) as Integer
' numaAddToNumber(NUMA *, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is useful for accumulating sums, regardless of the index<para/>
''' order in which the values are made available.<para/>
''' (2) Before use, the numa has to be filled up to %index.  This would<para/>
''' typically be used by creating the numa with the full sized<para/>
''' array, initialized to 0.0, using numaMakeConstant().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaAddToNumber/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="index">[in] - element to be changed</param>
'''  <param name="val">[in] - new value to be added</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaAddToNumber(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				 ByVal val as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaAddToNumber( na.Pointer, index, val)

	Return _Result
End Function

' SRC\numafunc1.c (431, 1)
' numaGetMin(na, pminval, piminloc) as Integer
' numaGetMin(NUMA *, l_float32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetMin/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pminval">[out][optional] - min value</param>
'''  <param name="piminloc">[out][optional] - index of min location</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetMin(
				 ByVal na as Numa, 
				<Out()> Optional ByRef pminval as Single = Nothing, 
				<Out()> Optional ByRef piminloc as Integer = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetMin( na.Pointer, pminval, piminloc)

	Return _Result
End Function

' SRC\numafunc1.c (473, 1)
' numaGetMax(na, pmaxval, pimaxloc) as Integer
' numaGetMax(NUMA *, l_float32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetMax/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pmaxval">[out][optional] - max value</param>
'''  <param name="pimaxloc">[out][optional] - index of max location</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetMax(
				 ByVal na as Numa, 
				<Out()> Optional ByRef pmaxval as Single = Nothing, 
				<Out()> Optional ByRef pimaxloc as Integer = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetMax( na.Pointer, pmaxval, pimaxloc)

	Return _Result
End Function

' SRC\numafunc1.c (514, 1)
' numaGetSum(na, psum) as Integer
' numaGetSum(NUMA *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetSum/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="psum">[out] - sum of values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetSum(
				 ByVal na as Numa, 
				<Out()> ByRef psum as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetSum( na.Pointer, psum)

	Return _Result
End Function

' SRC\numafunc1.c (553, 1)
' numaGetPartialSums(na) as Numa
' numaGetPartialSums(NUMA *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) nasum[i] is the sum for all j  is lower = i of na[j].<para/>
''' So nasum[0] = na[0].<para/>
''' (2) If you want to generate a rank function, where rank[0] - 0.0,<para/>
''' insert a 0.0 at the beginning of the nasum array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetPartialSums/*"/>
'''  <param name="na">[in] - source numa</param>
'''   <returns>nasum, or NULL on error</returns>
Public Shared Function numaGetPartialSums(
				 ByVal na as Numa) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaGetPartialSums( na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (586, 1)
' numaGetSumOnInterval(na, first, last, psum) as Integer
' numaGetSumOnInterval(NUMA *, l_int32, l_int32, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetSumOnInterval/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="first">[in] - beginning index</param>
'''  <param name="last">[in] - final index</param>
'''  <param name="psum">[out] - sum of values in the index interval range</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetSumOnInterval(
				 ByVal na as Numa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				<Out()> ByRef psum as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetSumOnInterval( na.Pointer, first, last, psum)

	Return _Result
End Function

' SRC\numafunc1.c (632, 1)
' numaHasOnlyIntegers(na, maxsamples, pallints) as Integer
' numaHasOnlyIntegers(NUMA *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Set %maxsamples == 0 to check every integer in na.  Otherwise,<para/>
''' this samples no more than %maxsamples.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaHasOnlyIntegers/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="maxsamples">[in] - maximum number of samples to check</param>
'''  <param name="pallints">[out] - 1 if all sampled values are ints else 0</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaHasOnlyIntegers(
				 ByVal na as Numa, 
				 ByVal maxsamples as Integer, 
				<Out()> ByRef pallints as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaHasOnlyIntegers( na.Pointer, maxsamples, pallints)

	Return _Result
End Function

' SRC\numafunc1.c (673, 1)
' numaSubsample(nas, subfactor) as Numa
' numaSubsample(NUMA *, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSubsample/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="subfactor">[in] - subsample factor,  is greater = 1</param>
'''   <returns>nad evenly sampled values from nas, or NULL on error</returns>
Public Shared Function numaSubsample(
				 ByVal nas as Numa, 
				 ByVal subfactor as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaSubsample( nas.Pointer, subfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (707, 1)
' numaMakeDelta(nas) as Numa
' numaMakeDelta(NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaMakeDelta/*"/>
'''  <param name="nas">[in] - input numa</param>
'''   <returns>numa of difference values val[i+1] - val[i], or NULL on error</returns>
Public Shared Function numaMakeDelta(
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeDelta( nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (737, 1)
' numaMakeSequence(startval, increment, size) as Numa
' numaMakeSequence(l_float32, l_float32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaMakeSequence/*"/>
'''  <param name="startval">[in] - </param>
'''  <param name="increment">[in] - </param>
'''  <param name="size">[in] - of sequence</param>
'''   <returns>numa of sequence of evenly spaced values, or NULL on error</returns>
Public Shared Function numaMakeSequence(
				 ByVal startval as Single, 
				 ByVal increment as Single, 
				 ByVal size as Integer) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeSequence( startval, increment, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (768, 1)
' numaMakeConstant(val, size) as Numa
' numaMakeConstant(l_float32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaMakeConstant/*"/>
'''  <param name="val">[in] - </param>
'''  <param name="size">[in] - of numa</param>
'''   <returns>numa of given size with all entries equal to 'val', or NULL on error</returns>
Public Shared Function numaMakeConstant(
				 ByVal val as Single, 
				 ByVal size as Integer) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeConstant( val, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (784, 1)
' numaMakeAbsValue(nad, nas) as Numa
' numaMakeAbsValue(NUMA *, NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaMakeAbsValue/*"/>
'''  <param name="nad">[in]can be null - for new array, or the same as nas for inplace</param>
'''  <param name="nas">[in] - input numa</param>
'''   <returns>nad with all numbers being the absval of the input, or NULL on error</returns>
Public Shared Function numaMakeAbsValue(
				 ByVal nad as Numa, 
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim nadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nad) Then nadPTR = nad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeAbsValue( nadPTR, nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (818, 1)
' numaAddBorder(nas, left, right, val) as Numa
' numaAddBorder(NUMA *, l_int32, l_int32, l_float32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaAddBorder/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="left">[in] - number of elements to add on each side</param>
'''  <param name="right">[in] - number of elements to add on each side</param>
'''  <param name="val">[in] - initialize border elements</param>
'''   <returns>nad with added elements at left and right, or NULL on error</returns>
Public Shared Function numaAddBorder(
				 ByVal nas as Numa, 
				 ByVal left as Integer, 
				 ByVal right as Integer, 
				 ByVal val as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaAddBorder( nas.Pointer, left, right, val)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (860, 1)
' numaAddSpecifiedBorder(nas, left, right, type) as Numa
' numaAddSpecifiedBorder(NUMA *, l_int32, l_int32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaAddSpecifiedBorder/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="left">[in] - number of elements to add on each side</param>
'''  <param name="right">[in] - number of elements to add on each side</param>
'''  <param name="type">[in] - L_CONTINUED_BORDER, L_MIRRORED_BORDER</param>
'''   <returns>nad with added elements at left and right, or NULL on error</returns>
Public Shared Function numaAddSpecifiedBorder(
				 ByVal nas as Numa, 
				 ByVal left as Integer, 
				 ByVal right as Integer, 
				 ByVal type as Enumerations.L_BORDER) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaAddSpecifiedBorder( nas.Pointer, left, right, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (910, 1)
' numaRemoveBorder(nas, left, right) as Numa
' numaRemoveBorder(NUMA *, l_int32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaRemoveBorder/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="left">[in] - number of elements to remove from each side</param>
'''  <param name="right">[in] - number of elements to remove from each side</param>
'''   <returns>nad with removed elements at left and right, or NULL on error</returns>
Public Shared Function numaRemoveBorder(
				 ByVal nas as Numa, 
				 ByVal left as Integer, 
				 ByVal right as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaRemoveBorder( nas.Pointer, left, right)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (951, 1)
' numaCountNonzeroRuns(na, pcount) as Integer
' numaCountNonzeroRuns(NUMA *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaCountNonzeroRuns/*"/>
'''  <param name="na">[in] - e.g., of pixel counts in rows or columns</param>
'''  <param name="pcount">[out] - number of nonzero runs</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaCountNonzeroRuns(
				 ByVal na as Numa, 
				<Out()> ByRef pcount as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaCountNonzeroRuns( na.Pointer, pcount)

	Return _Result
End Function

' SRC\numafunc1.c (990, 1)
' numaGetNonzeroRange(na, eps, pfirst, plast) as Integer
' numaGetNonzeroRange(NUMA *, l_float32, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetNonzeroRange/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="eps">[in] - largest value considered to be zero</param>
'''  <param name="pfirst">[out] - interval of array indices where values are nonzero</param>
'''  <param name="plast">[out] - interval of array indices where values are nonzero</param>
'''   <returns>0 if OK, 1 on error or if no nonzero range is found.</returns>
Public Shared Function numaGetNonzeroRange(
				 ByVal na as Numa, 
				 ByVal eps as Single, 
				<Out()> ByRef pfirst as Integer, 
				<Out()> ByRef plast as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetNonzeroRange( na.Pointer, eps, pfirst, plast)

	Return _Result
End Function

' SRC\numafunc1.c (1041, 1)
' numaGetCountRelativeToZero(na, type, pcount) as Integer
' numaGetCountRelativeToZero(NUMA *, l_int32, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetCountRelativeToZero/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="type">[in] - L_LESS_THAN_ZERO, L_EQUAL_TO_ZERO, L_GREATER_THAN_ZERO</param>
'''  <param name="pcount">[out] - count of values of given type</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetCountRelativeToZero(
				 ByVal na as Numa, 
				 ByVal type as Enumerations.L_ZERO, 
				<Out()> ByRef pcount as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetCountRelativeToZero( na.Pointer, type, pcount)

	Return _Result
End Function

' SRC\numafunc1.c (1089, 1)
' numaClipToInterval(nas, first, last) as Numa
' numaClipToInterval(NUMA *, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' If you want the indices of the array values to be unchanged,<para/>
''' use first = 0.<para/>
''' Usage:<para/>
''' This is useful to clip a histogram that has a few nonzero<para/>
''' values to its nonzero range.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaClipToInterval/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="first">[in] - clipping interval</param>
'''  <param name="last">[in] - clipping interval</param>
'''   <returns>numa with the same values as the input, but clipped to the specified interval</returns>
Public Shared Function numaClipToInterval(
				 ByVal nas as Numa, 
				 ByVal first as Integer, 
				 ByVal last as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaClipToInterval( nas.Pointer, first, last)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1137, 1)
' numaMakeThresholdIndicator(nas, thresh, type) as Numa
' numaMakeThresholdIndicator(NUMA *, l_float32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each element in nas, if the constraint given by 'type'<para/>
''' correctly specifies its relation to thresh, a value of 1<para/>
''' is recorded in nad.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaMakeThresholdIndicator/*"/>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="thresh">[in] - threshold value</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns></returns>
Public Shared Function numaMakeThresholdIndicator(
				 ByVal nas as Numa, 
				 ByVal thresh as Single, 
				 ByVal type as Enumerations.L_SELECT_IF) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaMakeThresholdIndicator( nas.Pointer, thresh, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1193, 1)
' numaUniformSampling(nas, nsamp) as Numa
' numaUniformSampling(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This resamples the values in the array, using %nsamp<para/>
''' equal divisions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaUniformSampling/*"/>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="nsamp">[in] - number of samples</param>
'''   <returns></returns>
Public Shared Function numaUniformSampling(
				 ByVal nas as Numa, 
				 ByVal nsamp as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaUniformSampling( nas.Pointer, nsamp)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1258, 1)
' numaReverse(nad, nas) as Numa
' numaReverse(NUMA *, NUMA *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Usage:<para/>
''' numaReverse(nas, nas) // in-place<para/>
''' nad = numaReverse(NULL, nas)  // makes a new one<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaReverse/*"/>
'''  <param name="nad">[in][optional] - can be null or equal to nas</param>
'''  <param name="nas">[in] - input numa</param>
'''   <returns></returns>
Public Shared Function numaReverse(
				 ByVal nad as Numa, 
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim nadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nad) Then nadPTR = nad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaReverse( nadPTR, nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1313, 1)
' numaLowPassIntervals(nas, thresh, maxn) as Numa
' numaLowPassIntervals(NUMA *, l_float32, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each interval where the value is less than a specified<para/>
''' fraction of the maximum, this records the left and right "x"<para/>
''' value.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaLowPassIntervals/*"/>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="thresh">[in] - threshold fraction of max in [0.0 ... 1.0]</param>
'''  <param name="maxn">[in] - for normalizing set maxn = 0.0 to use the max in nas</param>
'''   <returns></returns>
Public Shared Function numaLowPassIntervals(
				 ByVal nas as Numa, 
				 ByVal thresh as Single, 
				 ByVal maxn as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaLowPassIntervals( nas.Pointer, thresh, maxn)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1389, 1)
' numaThresholdEdges(nas, thresh1, thresh2, maxn) as Numa
' numaThresholdEdges(NUMA *, l_float32, l_float32, l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each edge interval, where where the value is less<para/>
''' than %thresh1 on one side, greater than %thresh2 on<para/>
''' the other, and between these thresholds throughout the<para/>
''' interval, this records a triplet of values: the<para/>
''' 'left' and 'right' edges, and either +1 or -1, depending<para/>
''' on whether the edge is rising or falling.<para/>
''' (2) No assumption is made about the value outside the array,<para/>
''' so if the value at the array edge is between the threshold<para/>
''' values, it is not considered part of an edge.  We start<para/>
''' looking for edge intervals only after leaving the thresholded<para/>
''' band.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaThresholdEdges/*"/>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="thresh1">[in] - low threshold as fraction of max in [0.0 ... 1.0]</param>
'''  <param name="thresh2">[in] - high threshold as fraction of max in [0.0 ... 1.0]</param>
'''  <param name="maxn">[in] - for normalizing set maxn = 0.0 to use the max in nas</param>
'''   <returns></returns>
Public Shared Function numaThresholdEdges(
				 ByVal nas as Numa, 
				 ByVal thresh1 as Single, 
				 ByVal thresh2 as Single, 
				 ByVal maxn as Single) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaThresholdEdges( nas.Pointer, thresh1, thresh2, maxn)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (1509, 1)
' numaGetSpanValues(na, span, pstart, pend) as Integer
' numaGetSpanValues(NUMA *, l_int32, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetSpanValues/*"/>
'''  <param name="na">[in] - numa that is output of numaLowPassIntervals()</param>
'''  <param name="span">[in] - span number, zero-based</param>
'''  <param name="pstart">[out][optional] - location of start of transition</param>
'''  <param name="pend">[out][optional] - location of end of transition</param>
'''   <returns></returns>
Public Shared Function numaGetSpanValues(
				 ByVal na as Numa, 
				 ByVal span as Integer, 
				<Out()> Optional ByRef pstart as Integer = Nothing, 
				<Out()> Optional ByRef pend as Integer = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetSpanValues( na.Pointer, span, pstart, pend)

	Return _Result
End Function

' SRC\numafunc1.c (1545, 1)
' numaGetEdgeValues(na, edge, pstart, pend, psign) as Integer
' numaGetEdgeValues(NUMA *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetEdgeValues/*"/>
'''  <param name="na">[in] - numa that is output of numaThresholdEdges()</param>
'''  <param name="edge">[in] - edge number, zero-based</param>
'''  <param name="pstart">[out][optional] - location of start of transition</param>
'''  <param name="pend">[out][optional] - location of end of transition</param>
'''  <param name="psign">[out][optional] - transition sign: +1 is rising, -1 is falling</param>
'''   <returns></returns>
Public Shared Function numaGetEdgeValues(
				 ByVal na as Numa, 
				 ByVal edge as Integer, 
				<Out()> Optional ByRef pstart as Integer = Nothing, 
				<Out()> Optional ByRef pend as Integer = Nothing, 
				<Out()> Optional ByRef psign as Integer = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetEdgeValues( na.Pointer, edge, pstart, pend, psign)

	Return _Result
End Function

' SRC\numafunc1.c (1602, 1)
' numaInterpolateEqxVal(startx, deltax, nay, type, xval, pyval) as Integer
' numaInterpolateEqxVal(l_float32, l_float32, NUMA *, l_int32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Considering nay as a function of x, the x values<para/>
''' are equally spaced<para/>
''' (2) Caller should check for valid return.<para/>
''' For linear Lagrangian interpolation (through 2 data pts):<para/>
''' y(x) = y1(x-x2)/(x1-x2) + y2(x-x1)/(x2-x1)<para/>
''' For quadratic Lagrangian interpolation (through 3 data pts):<para/>
''' y(x) = y1(x-x2)(x-x3)/((x1-x2)(x1-x3)) +<para/>
''' y2(x-x1)(x-x3)/((x2-x1)(x2-x3)) +<para/>
''' y3(x-x1)(x-x2)/((x3-x1)(x3-x2))<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInterpolateEqxVal/*"/>
'''  <param name="startx">[in] - xval corresponding to first element in array</param>
'''  <param name="deltax">[in] - x increment between array elements</param>
'''  <param name="nay">[in] - numa of ordinate values, assumed equally spaced</param>
'''  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
'''  <param name="xval">[in] - </param>
'''  <param name="pyval">[out] - interpolated value</param>
'''   <returns>0 if OK, 1 on error e.g., if xval is outside range</returns>
Public Shared Function numaInterpolateEqxVal(
				 ByVal startx as Single, 
				 ByVal deltax as Single, 
				 ByVal nay as Numa, 
				 ByVal type as Enumerations.L_INTERP, 
				 ByVal xval as Single, 
				<Out()> ByRef pyval as Single) as Integer

	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaInterpolateEqxVal( startx, deltax, nay.Pointer, type, xval, pyval)

	Return _Result
End Function

' SRC\numafunc1.c (1695, 1)
' numaInterpolateArbxVal(nax, nay, type, xval, pyval) as Integer
' numaInterpolateArbxVal(NUMA *, NUMA *, l_int32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values in nax must be sorted in increasing order.<para/>
''' If, additionally, they are equally spaced, you can use<para/>
''' numaInterpolateEqxVal().<para/>
''' (2) Caller should check for valid return.<para/>
''' (3) Uses lagrangian interpolation.  See numaInterpolateEqxVal()<para/>
''' for formulas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInterpolateArbxVal/*"/>
'''  <param name="nax">[in] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
'''  <param name="xval">[in] - </param>
'''  <param name="pyval">[out] - interpolated value</param>
'''   <returns>0 if OK, 1 on error e.g., if xval is outside range</returns>
Public Shared Function numaInterpolateArbxVal(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal type as Enumerations.L_INTERP, 
				 ByVal xval as Single, 
				<Out()> ByRef pyval as Single) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaInterpolateArbxVal( nax.Pointer, nay.Pointer, type, xval, pyval)

	Return _Result
End Function

' SRC\numafunc1.c (1812, 1)
' numaInterpolateEqxInterval(startx, deltax, nasy, type, x0, x1, npts, pnax, pnay) as Integer
' numaInterpolateEqxInterval(l_float32, l_float32, NUMA *, l_int32, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Considering nasy as a function of x, the x values<para/>
''' are equally spaced.<para/>
''' (2) This creates nay (and optionally nax) of interpolated<para/>
''' values over the specified interval (x0, x1).<para/>
''' (3) If the interval (x0, x1) lies partially outside the array<para/>
''' nasy (as interpreted by startx and deltax), it is an<para/>
''' error and returns 1.<para/>
''' (4) Note that deltax is the intrinsic x-increment for the input<para/>
''' array nasy, whereas delx is the intrinsic x-increment for the<para/>
''' output interpolated array nay.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInterpolateEqxInterval/*"/>
'''  <param name="startx">[in] - xval corresponding to first element in nas</param>
'''  <param name="deltax">[in] - x increment between array elements in nas</param>
'''  <param name="nasy">[in] - numa of ordinate values, assumed equally spaced</param>
'''  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
'''  <param name="x0">[in] - start value of interval</param>
'''  <param name="x1">[in] - end value of interval</param>
'''  <param name="npts">[in] - number of points to evaluate function in interval</param>
'''  <param name="pnax">[out][optional] - array of x values in interval</param>
'''  <param name="pnay">[out] - array of y values in interval</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaInterpolateEqxInterval(
				 ByVal startx as Single, 
				 ByVal deltax as Single, 
				 ByVal nasy as Numa, 
				 ByVal type as Enumerations.L_INTERP, 
				 ByVal x0 as Single, 
				 ByVal x1 as Single, 
				 ByVal npts as Integer, 
				<Out()> ByRef pnax as Numa, 
				<Out()> ByRef pnay as Numa) as Integer

	If IsNothing (nasy) then Throw New ArgumentNullException  ("nasy cannot be Nothing")

Dim pnaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnax) Then pnaxPTR = pnax.Pointer
	Dim pnayPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnay) Then pnayPTR = pnay.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaInterpolateEqxInterval( startx, deltax, nasy.Pointer, type, x0, x1, npts, pnaxPTR, pnayPTR)
	if pnaxPTR <> IntPtr.Zero then pnax = new Numa(pnaxPTR)
	if pnayPTR <> IntPtr.Zero then pnay = new Numa(pnayPTR)

	Return _Result
End Function

' SRC\numafunc1.c (1900, 1)
' numaInterpolateArbxInterval(nax, nay, type, x0, x1, npts, pnadx, pnady) as Integer
' numaInterpolateArbxInterval(NUMA *, NUMA *, l_int32, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values in nax must be sorted in increasing order.<para/>
''' If they are not sorted, we do it here, and complain.<para/>
''' (2) If the values in nax are equally spaced, you can use<para/>
''' numaInterpolateEqxInterval().<para/>
''' (3) Caller should check for valid return.<para/>
''' (4) We don't call numaInterpolateArbxVal() for each output<para/>
''' point, because that requires an O(n) search for<para/>
''' each point.  Instead, we do a single O(n) pass through<para/>
''' nax, saving the indices to be used for each output yval.<para/>
''' (5) Uses lagrangian interpolation.  See numaInterpolateEqxVal()<para/>
''' for formulas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInterpolateArbxInterval/*"/>
'''  <param name="nax">[in] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="type">[in] - L_LINEAR_INTERP, L_QUADRATIC_INTERP</param>
'''  <param name="x0">[in] - start value of interval</param>
'''  <param name="x1">[in] - end value of interval</param>
'''  <param name="npts">[in] - number of points to evaluate function in interval</param>
'''  <param name="pnadx">[out][optional] - array of x values in interval</param>
'''  <param name="pnady">[out] - array of y values in interval</param>
'''   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
Public Shared Function numaInterpolateArbxInterval(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal type as Enumerations.L_INTERP, 
				 ByVal x0 as Single, 
				 ByVal x1 as Single, 
				 ByVal npts as Integer, 
				<Out()> ByRef pnadx as Numa, 
				<Out()> ByRef pnady as Numa) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

Dim pnadxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnadx) Then pnadxPTR = pnadx.Pointer
	Dim pnadyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnady) Then pnadyPTR = pnady.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaInterpolateArbxInterval( nax.Pointer, nay.Pointer, type, x0, x1, npts, pnadxPTR, pnadyPTR)
	if pnadxPTR <> IntPtr.Zero then pnadx = new Numa(pnadxPTR)
	if pnadyPTR <> IntPtr.Zero then pnady = new Numa(pnadyPTR)

	Return _Result
End Function

' SRC\numafunc1.c (2061, 1)
' numaFitMax(na, pmaxval, naloc, pmaxloc) as Integer
' numaFitMax(NUMA *, l_float32 *, NUMA *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' If %naloc is given, there is no requirement that the<para/>
''' data points are evenly spaced.  Lagrangian interpolation<para/>
''' handles that.  The only requirement is that the<para/>
''' data points are ordered so that the values in naloc<para/>
''' are either increasing or decreasing.  We test to make<para/>
''' sure that the sizes of na and naloc are equal, and it<para/>
''' is assumed that the correspondences %na[i] as a function<para/>
''' of %naloc[i] are properly arranged for all i.<para/>
''' The formula for Lagrangian interpolation through 3 data pts is:<para/>
''' y(x) = y1(x-x2)(x-x3)/((x1-x2)(x1-x3)) +<para/>
''' y2(x-x1)(x-x3)/((x2-x1)(x2-x3)) +<para/>
''' y3(x-x1)(x-x2)/((x3-x1)(x3-x2))<para/>
''' Then the derivative, using the constants (c1,c2,c3) defined below,<para/>
''' is set to 0:<para/>
''' y'(x) = 2x(c1+c2+c3) - c1(x2+x3) - c2(x1+x3) - c3(x1+x2) = 0<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaFitMax/*"/>
'''  <param name="na">[in] - numa of ordinate values, to fit a max to</param>
'''  <param name="pmaxval">[out] - max value</param>
'''  <param name="naloc">[in][optional] - associated numa of abscissa values</param>
'''  <param name="pmaxloc">[out] - abscissa value that gives max value in na if naloc == null, this is given as an interpolated index value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaFitMax(
				 ByVal na as Numa, 
				<Out()> ByRef pmaxval as Single, 
				 ByVal naloc as Numa, 
				<Out()> ByRef pmaxloc as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim nalocPTR As IntPtr = IntPtr.Zero : If Not IsNothing(naloc) Then nalocPTR = naloc.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaFitMax( na.Pointer, pmaxval, nalocPTR, pmaxloc)

	Return _Result
End Function

' SRC\numafunc1.c (2166, 1)
' numaDifferentiateInterval(nax, nay, x0, x1, npts, pnadx, pnady) as Integer
' numaDifferentiateInterval(NUMA *, NUMA *, l_float32, l_float32, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values in nax must be sorted in increasing order.<para/>
''' If they are not sorted, it is done in the interpolation<para/>
''' step, and a warning is issued.<para/>
''' (2) Caller should check for valid return.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaDifferentiateInterval/*"/>
'''  <param name="nax">[in] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="x0">[in] - start value of interval</param>
'''  <param name="x1">[in] - end value of interval</param>
'''  <param name="npts">[in] - number of points to evaluate function in interval</param>
'''  <param name="pnadx">[out][optional] - array of x values in interval</param>
'''  <param name="pnady">[out] - array of derivatives in interval</param>
'''   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
Public Shared Function numaDifferentiateInterval(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal x0 as Single, 
				 ByVal x1 as Single, 
				 ByVal npts as Integer, 
				<Out()> ByRef pnadx as Numa, 
				<Out()> ByRef pnady as Numa) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

Dim pnadxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnadx) Then pnadxPTR = pnadx.Pointer
	Dim pnadyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnady) Then pnadyPTR = pnady.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaDifferentiateInterval( nax.Pointer, nay.Pointer, x0, x1, npts, pnadxPTR, pnadyPTR)
	if pnadxPTR <> IntPtr.Zero then pnadx = new Numa(pnadxPTR)
	if pnadyPTR <> IntPtr.Zero then pnady = new Numa(pnadyPTR)

	Return _Result
End Function

' SRC\numafunc1.c (2249, 1)
' numaIntegrateInterval(nax, nay, x0, x1, npts, psum) as Integer
' numaIntegrateInterval(NUMA *, NUMA *, l_float32, l_float32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values in nax must be sorted in increasing order.<para/>
''' If they are not sorted, it is done in the interpolation<para/>
''' step, and a warning is issued.<para/>
''' (2) Caller should check for valid return.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaIntegrateInterval/*"/>
'''  <param name="nax">[in] - numa of abscissa values</param>
'''  <param name="nay">[in] - numa of ordinate values, corresponding to nax</param>
'''  <param name="x0">[in] - start value of interval</param>
'''  <param name="x1">[in] - end value of interval</param>
'''  <param name="npts">[in] - number of points to evaluate function in interval</param>
'''  <param name="psum">[out] - integral of function over interval</param>
'''   <returns>0 if OK, 1 on error e.g., if x0 or x1 is outside range</returns>
Public Shared Function numaIntegrateInterval(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal x0 as Single, 
				 ByVal x1 as Single, 
				 ByVal npts as Integer, 
				<Out()> ByRef psum as Single) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaIntegrateInterval( nax.Pointer, nay.Pointer, x0, x1, npts, psum)

	Return _Result
End Function

' SRC\numafunc1.c (2354, 1)
' numaSortGeneral(na, pnasort, pnaindex, pnainvert, sortorder, sorttype) as Integer
' numaSortGeneral(NUMA *, NUMA **, NUMA **, NUMA **, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sorting can be confusing.  Here's an array of five values with<para/>
''' the results shown for the 3 output arrays.<para/>
''' na  nasort naindex nainvert<para/>
''' -----------------------------------<para/>
''' 3 9 2 3<para/>
''' 4 6 3 2<para/>
''' 9 4 1 0<para/>
''' 6 3 0 1<para/>
''' 1 1 4 4<para/>
''' Note that naindex is a LUT into na for the sorted array values,<para/>
''' and nainvert directly gives the sorted index values for the<para/>
''' input array.  It is useful to view naindex is as a map:<para/>
''' 0  -- is greater 2<para/>
''' 1  -- is greater 3<para/>
''' 2  -- is greater 1<para/>
''' 3  -- is greater 0<para/>
''' 4  -- is greater 4<para/>
''' and nainvert, the inverse of this map:<para/>
''' 0  -- is greater 3<para/>
''' 1  -- is greater 2<para/>
''' 2  -- is greater 0<para/>
''' 3  -- is greater 1<para/>
''' 4  -- is greater 4<para/>
''' We can write these relations symbolically as:<para/>
''' nasort[i] = na[naindex[i]]<para/>
''' na[i] = nasort[nainvert[i]]<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSortGeneral/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pnasort">[out][optional] - sorted numa</param>
'''  <param name="pnaindex">[out][optional] - index of elements in na associated with each element of nasort</param>
'''  <param name="pnainvert">[out][optional] - index of elements in nasort associated with each element of na</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''  <param name="sorttype">[in] - L_SHELL_SORT or L_BIN_SORT</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSortGeneral(
				 ByVal na as Numa, 
				<Out()> ByRef pnasort as Numa, 
				<Out()> ByRef pnaindex as Numa, 
				<Out()> ByRef pnainvert as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				 ByVal sorttype as Enumerations.L_SORT) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

Dim pnasortPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasort) Then pnasortPTR = pnasort.Pointer
Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer
Dim pnainvertPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnainvert) Then pnainvertPTR = pnainvert.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSortGeneral( na.Pointer, pnasortPTR, pnaindexPTR, pnainvertPTR, sortorder, sorttype)
	if pnasortPTR <> IntPtr.Zero then pnasort = new Numa(pnasortPTR)
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)
	if pnainvertPTR <> IntPtr.Zero then pnainvert = new Numa(pnainvertPTR)

	Return _Result
End Function

' SRC\numafunc1.c (2408, 1)
' numaSortAutoSelect(nas, sortorder) as Numa
' numaSortAutoSelect(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does either a shell sort or a bin sort, depending on<para/>
''' the number of elements in nas and the dynamic range.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSortAutoSelect/*"/>
'''  <param name="nas">[in] - input numa</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>naout output sorted numa, or NULL on error</returns>
Public Shared Function numaSortAutoSelect(
				 ByVal nas as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaSortAutoSelect( nas.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2444, 1)
' numaSortIndexAutoSelect(nas, sortorder) as Numa
' numaSortIndexAutoSelect(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does either a shell sort or a bin sort, depending on<para/>
''' the number of elements in nas and the dynamic range.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSortIndexAutoSelect/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>nad indices of nas, sorted by value in nas, or NULL on error</returns>
Public Shared Function numaSortIndexAutoSelect(
				 ByVal nas as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaSortIndexAutoSelect( nas.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2480, 1)
' numaChooseSortType(nas) as Integer
' numaChooseSortType(NUMA *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This selects either a shell sort or a bin sort, depending on<para/>
''' the number of elements in nas and the dynamic range.<para/>
''' (2) If there are negative values in nas, it selects shell sort.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaChooseSortType/*"/>
'''  <param name="nas">[in] - to be sorted</param>
'''   <returns>sorttype L_SHELL_SORT or L_BIN_SORT, or UNDEF on error.</returns>
Public Shared Function numaChooseSortType(
				 ByVal nas as Numa) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaChooseSortType( nas.Pointer)

	Return _Result
End Function

' SRC\numafunc1.c (2531, 1)
' numaSort(naout, nain, sortorder) as Numa
' numaSort(NUMA *, NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Set naout = nain for in-place otherwise, set naout = NULL.<para/>
''' (2) Source: Shell sort, modified from K and R, 2nd edition, p.62.<para/>
''' Slow but simple O(n logn) sort.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSort/*"/>
'''  <param name="naout">[in] - output numa can be NULL or equal to nain</param>
'''  <param name="nain">[in] - input numa</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>naout output sorted numa, or NULL on error</returns>
Public Shared Function numaSort(
				 ByVal naout as Numa, 
				 ByVal nain as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (naout) then Throw New ArgumentNullException  ("naout cannot be Nothing")
	If IsNothing (nain) then Throw New ArgumentNullException  ("nain cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaSort( naout.Pointer, nain.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2593, 1)
' numaBinSort(nas, sortorder) as Numa
' numaBinSort(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Because this uses a bin sort with buckets of size 1, it<para/>
''' is not appropriate for sorting either small arrays or<para/>
''' arrays containing very large integer values.  For such<para/>
''' arrays, use a standard general sort function like<para/>
''' numaSort().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaBinSort/*"/>
'''  <param name="nas">[in] - of non-negative integers with a max that is typically less than 50,000</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>na sorted, or NULL on error</returns>
Public Shared Function numaBinSort(
				 ByVal nas as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaBinSort( nas.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2621, 1)
' numaGetSortIndex(na, sortorder) as Numa
' numaGetSortIndex(NUMA *, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetSortIndex/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>na giving an array of indices that would sort the input array, or NULL on error</returns>
Public Shared Function numaGetSortIndex(
				 ByVal na as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaGetSortIndex( na.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2697, 1)
' numaGetBinSortIndex(nas, sortorder) as Numa
' numaGetBinSortIndex(NUMA *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This creates an array (or lookup table) that contains<para/>
''' the sorted position of the elements in the input Numa.<para/>
''' (2) Because it uses a bin sort with buckets of size 1, it<para/>
''' is not appropriate for sorting either small arrays or<para/>
''' arrays containing very large integer values.  For such<para/>
''' arrays, use a standard general sort function like<para/>
''' numaGetSortIndex().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetBinSortIndex/*"/>
'''  <param name="nas">[in] - of non-negative integers with a max that is typically less than 1,000,000</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''   <returns>na sorted, or NULL on error</returns>
Public Shared Function numaGetBinSortIndex(
				 ByVal nas as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaGetBinSortIndex( nas.Pointer, sortorder)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2770, 1)
' numaSortByIndex(nas, naindex) as Numa
' numaSortByIndex(NUMA *, NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSortByIndex/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="naindex">[in] - na that maps from the new numa to the input numa</param>
'''   <returns>nad sorted, or NULL on error</returns>
Public Shared Function numaSortByIndex(
				 ByVal nas as Numa, 
				 ByVal naindex as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")
	If IsNothing (naindex) then Throw New ArgumentNullException  ("naindex cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaSortByIndex( nas.Pointer, naindex.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2812, 1)
' numaIsSorted(nas, sortorder, psorted) as Integer
' numaIsSorted(NUMA *, l_int32, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a quick O(n) test if nas is sorted.  It is useful<para/>
''' in situations where the array is likely to be already<para/>
''' sorted, and a sort operation can be avoided.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaIsSorted/*"/>
'''  <param name="nas">[in] - </param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''  <param name="psorted">[out] - 1 if sorted 0 if not</param>
'''   <returns>1 if OK 0 on error</returns>
Public Shared Function numaIsSorted(
				 ByVal nas as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> ByRef psorted as Integer) as Integer

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaIsSorted( nas.Pointer, sortorder, psorted)

	Return _Result
End Function

' SRC\numafunc1.c (2859, 1)
' numaSortPair(nax, nay, sortorder, pnasx, pnasy) as Integer
' numaSortPair(NUMA *, NUMA *, l_int32, NUMA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function sorts the two input arrays, nax and nay,<para/>
''' together, using nax as the key for sorting.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaSortPair/*"/>
'''  <param name="nax">[in] - input arrays</param>
'''  <param name="nay">[in] - input arrays</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
'''  <param name="pnasx">[out] - sorted</param>
'''  <param name="pnasy">[out] - sorted exactly in order of nasx</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSortPair(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> ByRef pnasx as Numa, 
				<Out()> ByRef pnasy as Numa) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim pnasxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasx) Then pnasxPTR = pnasx.Pointer
	Dim pnasyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasy) Then pnasyPTR = pnasy.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaSortPair( nax.Pointer, nay.Pointer, sortorder, pnasxPTR, pnasyPTR)
	if pnasxPTR <> IntPtr.Zero then pnasx = new Numa(pnasxPTR)
	if pnasyPTR <> IntPtr.Zero then pnasy = new Numa(pnasyPTR)

	Return _Result
End Function

' SRC\numafunc1.c (2910, 1)
' numaInvertMap(nas) as Numa
' numaInvertMap(NUMA *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This requires that nas contain each integer from 0 to n-1.<para/>
''' The array is typically an index array into a sort or permutation<para/>
''' of another array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaInvertMap/*"/>
'''  <param name="nas">[in] - </param>
'''   <returns>nad the inverted map, or NULL on error or if not invertible</returns>
Public Shared Function numaInvertMap(
				 ByVal nas as Numa) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaInvertMap( nas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (2969, 1)
' numaPseudorandomSequence(size, seed) as Numa
' numaPseudorandomSequence(l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the Durstenfeld shuffle.<para/>
''' See: http://en.wikipedia.org/wiki/Fisherâ€“Yates_shuffle.<para/>
''' Result is a pseudorandom permutation of the sequence of integers<para/>
''' from 0 to size - 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaPseudorandomSequence/*"/>
'''  <param name="size">[in] - of sequence</param>
'''  <param name="seed">[in] - for random number generation</param>
'''   <returns>na pseudorandom on {0,...,size - 1}, or NULL on error</returns>
Public Shared Function numaPseudorandomSequence(
				 ByVal size as Integer, 
				 ByVal seed as Integer) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaPseudorandomSequence( size, seed)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (3008, 1)
' numaRandomPermutation(nas, seed) as Numa
' numaRandomPermutation(NUMA *, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaRandomPermutation/*"/>
'''  <param name="nas">[in] - input array</param>
'''  <param name="seed">[in] - for random number generation</param>
'''   <returns>nas randomly shuffled array, or NULL on error</returns>
Public Shared Function numaRandomPermutation(
				 ByVal nas as Numa, 
				 ByVal seed as Integer) as Numa

	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaRandomPermutation( nas.Pointer, seed)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numafunc1.c (3065, 1)
' numaGetRankValue(na, fract, nasort, usebins, pval) as Integer
' numaGetRankValue(NUMA *, l_float32, NUMA *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Computes the rank value of a number in the %na, which is<para/>
''' the number that is a fraction %fract from the small<para/>
''' end of the sorted version of %na.<para/>
''' (2) If you do this multiple times for different rank values,<para/>
''' sort the array in advance and use that for %nasort<para/>
''' if you're only calling this once, input %nasort == NULL.<para/>
''' (3) If %usebins == 1, this uses a bin sorting method.<para/>
''' Use this only where:<para/>
''' the numbers are non-negative integers<para/>
''' there are over 100 numbers<para/>
''' the maximum value is less than about 50,000<para/>
''' (4) The advantage of using a bin sort is that it is O(n),<para/>
''' instead of O(nlogn) for general sort routines.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetRankValue/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="fract">[in] - use 0.0 for smallest, 1.0 for largest</param>
'''  <param name="nasort">[in][optional] - increasing sorted version of na</param>
'''  <param name="usebins">[in] - 0 for general sort 1 for bin sort</param>
'''  <param name="pval">[out] - rank val</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetRankValue(
				 ByVal na as Numa, 
				 ByVal fract as Single, 
				 ByVal nasort as Numa, 
				 ByVal usebins as Integer, 
				<Out()> ByRef pval as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim nasortPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nasort) Then nasortPTR = nasort.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetRankValue( na.Pointer, fract, nasortPTR, usebins, pval)

	Return _Result
End Function

' SRC\numafunc1.c (3119, 1)
' numaGetMedian(na, pval) as Integer
' numaGetMedian(NUMA *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Computes the median value of the numbers in the numa, by<para/>
''' sorting and finding the middle value in the sorted array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetMedian/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pval">[out] - median value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetMedian(
				 ByVal na as Numa, 
				<Out()> ByRef pval as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetMedian( na.Pointer, pval)

	Return _Result
End Function

' SRC\numafunc1.c (3150, 1)
' numaGetBinnedMedian(na, pval) as Integer
' numaGetBinnedMedian(NUMA *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Computes the median value of the numbers in the numa,<para/>
''' using bin sort and finding the middle value in the sorted array.<para/>
''' (2) See numaGetRankValue() for conditions on na for which<para/>
''' this should be used.  Otherwise, use numaGetMedian().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetBinnedMedian/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pval">[out] - integer median value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetBinnedMedian(
				 ByVal na as Numa, 
				<Out()> ByRef pval as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetBinnedMedian( na.Pointer, pval)

	Return _Result
End Function

' SRC\numafunc1.c (3187, 1)
' numaGetMode(na, pval, pcount) as Integer
' numaGetMode(NUMA *, l_float32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Computes the mode value of the numbers in the numa, by<para/>
''' sorting and finding the value of the number with the<para/>
''' largest count.<para/>
''' (2) Optionally, also returns that count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetMode/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pval">[out] - mode val</param>
'''  <param name="pcount">[out][optional] - mode count</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetMode(
				 ByVal na as Numa, 
				<Out()> ByRef pval as Single, 
				<Out()> Optional ByRef pcount as Integer = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetMode( na.Pointer, pval, pcount)

	Return _Result
End Function

' SRC\numafunc1.c (3266, 1)
' numaGetMedianVariation(na, pmedval, pmedvar) as Integer
' numaGetMedianVariation(NUMA *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Finds the median of the absolute value of the variation from<para/>
''' the median value in the array.  Why take the absolute value?<para/>
''' Consider the case where you have values equally distributed<para/>
''' about both sides of a median value.  Without taking the absolute<para/>
''' value of the differences, you will get 0 for the variation,<para/>
''' and this is not useful.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGetMedianVariation/*"/>
'''  <param name="na">[in] - source numa</param>
'''  <param name="pmedval">[out][optional] - median value</param>
'''  <param name="pmedvar">[out] - median variation from median val</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetMedianVariation(
				 ByVal na as Numa, 
				<Out()> ByRef pmedval as Single, 
				<Out()> ByRef pmedvar as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetMedianVariation( na.Pointer, pmedval, pmedvar)

	Return _Result
End Function

' SRC\numafunc1.c (3319, 1)
' numaJoin(nad, nas, istart, iend) as Integer
' numaJoin(NUMA *, NUMA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (2) iend  is lower  0 means 'read to the end'<para/>
''' (3) if nas == NULL, this is a no-op<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaJoin/*"/>
'''  <param name="nad">[in] - dest numa add to this one</param>
'''  <param name="nas">[in][optional] - source numa add from this one</param>
'''  <param name="istart">[in] - starting index in nas</param>
'''  <param name="iend">[in] - ending index in nas use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaJoin(
				 ByVal nad as Numa, 
				 ByVal nas as Numa, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (nad) then Throw New ArgumentNullException  ("nad cannot be Nothing")

	Dim nasPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nas) Then nasPTR = nas.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaJoin( nad.Pointer, nasPTR, istart, iend)

	Return _Result
End Function

' SRC\numafunc1.c (3368, 1)
' numaaJoin(naad, naas, istart, iend) as Integer
' numaaJoin(NUMAA *, NUMAA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (2) iend  is lower  0 means 'read to the end'<para/>
''' (3) if naas == NULL, this is a no-op<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaaJoin/*"/>
'''  <param name="naad">[in] - dest naa add to this one</param>
'''  <param name="naas">[in][optional] - source naa add from this one</param>
'''  <param name="istart">[in] - starting index in nas</param>
'''  <param name="iend">[in] - ending index in naas use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaJoin(
				 ByVal naad as Numaa, 
				 ByVal naas as Numaa, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (naad) then Throw New ArgumentNullException  ("naad cannot be Nothing")

	Dim naasPTR As IntPtr = IntPtr.Zero : If Not IsNothing(naas) Then naasPTR = naas.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.numaaJoin( naad.Pointer, naasPTR, istart, iend)

	Return _Result
End Function

' SRC\numafunc1.c (3416, 1)
' numaaFlattenToNuma(naa) as Numa
' numaaFlattenToNuma(NUMAA *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This 'flattens' the Numaa to a Numa, by joining successively<para/>
''' each Numa in the Numaa.<para/>
''' (2) It doesn't make any assumptions about the location of the<para/>
''' Numas in the Numaa array, unlike most Numaa functions.<para/>
''' (3) It leaves the input Numaa unchanged.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaaFlattenToNuma/*"/>
'''  <param name="naa">[in] - </param>
'''   <returns>numa, or NULL on error</returns>
Public Shared Function numaaFlattenToNuma(
				 ByVal naa as Numaa) as Numa

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaFlattenToNuma( naa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

End Class
