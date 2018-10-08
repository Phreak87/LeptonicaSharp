Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\numabasic.c (187, 1)
' numaCreate(n) as Numa
' numaCreate(l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of number array to be alloc'd 0 for default</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaCreate(
				 ByVal n as Integer) as Numa





	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (228, 1)
' numaCreateFromIArray(iarray, size) as Numa
' numaCreateFromIArray(l_int32 *, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We can't insert this int array into the numa, because a numa<para/>
''' takes a float array.  So this just copies the data from the<para/>
''' input array into the numa.  The input array continues to be<para/>
''' owned by the caller.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="iarray">[in] - integer</param>
'''  <param name="size">[in] - of the array</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaCreateFromIArray(
				 ByVal iarray as Integer(), 
				 ByVal size as Integer) as Numa

	If IsNothing (iarray) then Throw New ArgumentNullException  ("iarray cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCreateFromIArray( iarray, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (265, 1)
' numaCreateFromFArray(farray, size, copyflag) as Numa
' numaCreateFromFArray(l_float32 *, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) With L_INSERT, ownership of the input array is transferred<para/>
''' to the returned numa, and all %size elements are considered<para/>
''' to be valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="farray">[in] - float</param>
'''  <param name="size">[in] - of the array</param>
'''  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaCreateFromFArray(
				 ByVal farray as Single(), 
				 ByVal size as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as Numa

	If IsNothing (farray) then Throw New ArgumentNullException  ("farray cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCreateFromFArray( farray, size, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (309, 1)
' numaCreateFromString(str) as Numa
' numaCreateFromString(const char *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The numbers can be ints or floats they will be interpreted<para/>
''' and stored as floats.  To use them as integers (e.g., for<para/>
''' indexing into arrays), use numaGetIValue(...).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="str">[in] - string of comma-separated numbers</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaCreateFromString(
				 ByVal str as String) as Numa

	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCreateFromString( str)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (360, 1)
' numaDestroy(pna) as Object
' numaDestroy(NUMA **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Decrements the ref count and, if 0, destroys the numa.<para/>
''' (2) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pna">[in,out] - to be nulled if it exists</param>
Public Shared Sub numaDestroy(
				 ByRef pna as Numa)




	Dim pnaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pna) Then pnaPTR = pna.Pointer

	LeptonicaSharp.Natives.numaDestroy( pnaPTR)
	if pnaPTR <> IntPtr.Zero then pna = new Numa(pnaPTR)

End Sub

' SRC\numabasic.c (394, 1)
' numaCopy(na) as Numa
' numaCopy(NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>copy of numa, or NULL on error</returns>
Public Shared Function numaCopy(
				 ByVal na as Numa) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaCopy( na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (423, 1)
' numaClone(na) as Numa
' numaClone(NUMA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>ptr to same numa, or NULL on error</returns>
Public Shared Function numaClone(
				 ByVal na as Numa) as Numa

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaClone( na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (449, 1)
' numaEmpty(na) as Integer
' numaEmpty(NUMA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does not change the allocation of the array.<para/>
''' It just clears the number of stored numbers, so that<para/>
''' the array appears to be empty.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaEmpty(
				 ByVal na as Numa) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaEmpty( na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (473, 1)
' numaAddNumber(na, val) as Integer
' numaAddNumber(NUMA *, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="val">[in] - float or int to be added stored as a float</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaAddNumber(
				 ByVal na as Numa, 
				 ByVal val as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaAddNumber( na.Pointer, val)

	Return _Result
End Function

' SRC\numabasic.c (534, 1)
' numaInsertNumber(na, index, val) as Integer
' numaInsertNumber(NUMA *, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts na[i] -- is greater  na[i + 1] for all i  is greater = index,<para/>
''' and then inserts val as na[index].<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - location in na to insert new value</param>
'''  <param name="val">[in] - float32 or integer to be added</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaInsertNumber(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				 ByVal val as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaInsertNumber( na.Pointer, index, val)

	Return _Result
End Function

' SRC\numabasic.c (573, 1)
' numaRemoveNumber(na, index) as Integer
' numaRemoveNumber(NUMA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts na[i] -- is greater  na[i - 1] for all i  is greater  index.<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - element to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaRemoveNumber(
				 ByVal na as Numa, 
				 ByVal index as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaRemoveNumber( na.Pointer, index)

	Return _Result
End Function

' SRC\numabasic.c (602, 1)
' numaReplaceNumber(na, index, val) as Integer
' numaReplaceNumber(NUMA *, l_int32, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - element to be replaced</param>
'''  <param name="val">[in] - new value to replace old one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaReplaceNumber(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				 ByVal val as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaReplaceNumber( na.Pointer, index, val)

	Return _Result
End Function

' SRC\numabasic.c (631, 1)
' numaGetCount(na) as Integer
' numaGetCount(NUMA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>count, or 0 if no numbers or on error</returns>
Public Shared Function numaGetCount(
				 ByVal na as Numa) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetCount( na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (658, 1)
' numaSetCount(na, newcount) as Integer
' numaSetCount(NUMA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If newcount  is lower = na- is greater nalloc, this resets na- is greater n.<para/>
''' Using newcount = 0 is equivalent to numaEmpty().<para/>
''' (2) If newcount  is greater  na- is greater nalloc, this causes a realloc<para/>
''' to a size na- is greater nalloc = newcount.<para/>
''' (3) All the previously unused values in na are set to 0.0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="newcount">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSetCount(
				 ByVal na as Numa, 
				 ByVal newcount as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaSetCount( na.Pointer, newcount)

	Return _Result
End Function

' SRC\numabasic.c (692, 1)
' numaGetFValue(na, index, pval) as Integer
' numaGetFValue(NUMA *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caller may need to check the function return value to<para/>
''' decide if a 0.0 in the returned ival is valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - into numa</param>
'''  <param name="pval">[out] - float value 0.0 on error</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetFValue(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				<Out()> ByRef pval as Single()) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetFValue( na.Pointer, index, pval)

	Return _Result
End Function

' SRC\numabasic.c (727, 1)
' numaGetIValue(na, index, pival) as Integer
' numaGetIValue(NUMA *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caller may need to check the function return value to<para/>
''' decide if a 0 in the returned ival is valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - into numa</param>
'''  <param name="pival">[out] - integer value 0 on error</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaGetIValue(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				<Out()> ByRef pival as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetIValue( na.Pointer, index, pival)

	Return _Result
End Function

' SRC\numabasic.c (759, 1)
' numaSetValue(na, index, val) as Integer
' numaSetValue(NUMA *, l_int32, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - to element to be set</param>
'''  <param name="val">[in] - to set element</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaSetValue(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				 ByVal val as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaSetValue( na.Pointer, index, val)

	Return _Result
End Function

' SRC\numabasic.c (784, 1)
' numaShiftValue(na, index, diff) as Integer
' numaShiftValue(NUMA *, l_int32, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="index">[in] - to element to change relative to the current value</param>
'''  <param name="diff">[in] - increment if diff  is greater  0 or decrement if diff  is lower  0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaShiftValue(
				 ByVal na as Numa, 
				 ByVal index as Integer, 
				 ByVal diff as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaShiftValue( na.Pointer, index, diff)

	Return _Result
End Function

' SRC\numabasic.c (820, 1)
' numaGetIArray(na) as Integer()
' numaGetIArray(NUMA *) as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A copy of the array is always made, because we need to<para/>
''' generate an integer array from the bare float array.<para/>
''' The caller is responsible for freeing the array.<para/>
''' (2) The array size is determined by the number of stored numbers,<para/>
''' not by the size of the allocated array in the Numa.<para/>
''' (3) This function is provided to simplify calculations<para/>
''' using the bare internal array, rather than continually<para/>
''' calling accessors on the numa.  It is typically used<para/>
''' on an array of size 256.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>a copy of the bare internal array, integerized by rounding, or NULL on error</returns>
Public Shared Function numaGetIArray(
				 ByVal na as Numa) as Integer()

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer() = LeptonicaSharp.Natives.numaGetIArray( na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (865, 1)
' numaGetFArray(na, copyflag) as Single()
' numaGetFArray(NUMA *, l_int32) as l_float32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If copyflag == L_COPY, it makes a copy which the caller<para/>
''' is responsible for freeing.  Otherwise, it operates<para/>
''' directly on the bare array of the numa.<para/>
''' (2) Very important: for L_NOCOPY, any writes to the array<para/>
''' will be in the numa.  Do not write beyond the size of<para/>
''' the count field, because it will not be accessible<para/>
''' from the numa!  If necessary, be sure to set the count<para/>
''' field to a larger number (such as the alloc size)<para/>
''' BEFORE calling this function.  Creating with numaMakeConstant()<para/>
''' is another way to insure full initialization.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
'''   <returns>either the bare internal array or a copy of it, or NULL on error</returns>
Public Shared Function numaGetFArray(
				 ByVal na as Numa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Single()

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Single() = LeptonicaSharp.Natives.numaGetFArray( na.Pointer, copyflag)

	Return _Result
End Function

' SRC\numabasic.c (897, 1)
' numaGetRefcount(na) as Integer
' numaGetRefcount(NUMA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function numaGetRefcount(
				 ByVal na as Numa) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetRefcount( na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (915, 1)
' numaChangeRefcount(na, delta) as Integer
' numaChangeRefcount(NUMA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="delta">[in] - change to be applied</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaChangeRefcount(
				 ByVal na as Numa, 
				 ByVal delta as Integer) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaChangeRefcount( na.Pointer, delta)

	Return _Result
End Function

' SRC\numabasic.c (936, 1)
' numaGetParameters(na, pstartx, pdelx) as Integer
' numaGetParameters(NUMA *, l_float32 *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="pstartx">[out][optional] - startx</param>
'''  <param name="pdelx">[out][optional] - delx</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaGetParameters(
				 ByVal na as Numa, 
				<Out()> ByRef pstartx as Single(), 
				<Out()> ByRef pdelx as Single()) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaGetParameters( na.Pointer, pstartx, pdelx)

	Return _Result
End Function

' SRC\numabasic.c (966, 1)
' numaSetParameters(na, startx, delx) as Integer
' numaSetParameters(NUMA *, l_float32, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="startx">[in] - x value corresponding to na[0]</param>
'''  <param name="delx">[in] - difference in x values for the situation where the elements of na correspond to the evaulation of a function at equal intervals of size %delx</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaSetParameters(
				 ByVal na as Numa, 
				 ByVal startx as Single, 
				 ByVal delx as Single) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaSetParameters( na.Pointer, startx, delx)

	Return _Result
End Function

' SRC\numabasic.c (989, 1)
' numaCopyParameters(nad, nas) as Integer
' numaCopyParameters(NUMA *, NUMA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="nad">[in] - destination Numa</param>
'''  <param name="nas">[in] - source Numa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaCopyParameters(
				 ByVal nad as Numa, 
				 ByVal nas as Numa) as Integer

	If IsNothing (nad) then Throw New ArgumentNullException  ("nad cannot be Nothing")
	If IsNothing (nas) then Throw New ArgumentNullException  ("nas cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaCopyParameters( nad.Pointer, nas.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1027, 1)
' numaConvertToSarray(na, size1, size2, addzeros, type) as Sarray
' numaConvertToSarray(NUMA *, l_int32, l_int32, l_int32, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For integer conversion, size2 is ignored.<para/>
''' For float conversion, addzeroes is ignored.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="size1">[in] - size of conversion field</param>
'''  <param name="size2">[in] - for float conversion: size of field to the right of the decimal point</param>
'''  <param name="addzeros">[in] - for integer conversion: to add lead zeros</param>
'''  <param name="type">[in] - L_INTEGER_VALUE, L_FLOAT_VALUE</param>
'''   <returns>a sarray of the float values converted to strings representing either integer or float values or NULL on error.</returns>
Public Shared Function numaConvertToSarray(
				 ByVal na as Numa, 
				 ByVal size1 as Integer, 
				 ByVal size2 as Integer, 
				 ByVal addzeros as Integer, 
				 ByVal type as Enumerations.L_VALUE) as Sarray

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaConvertToSarray( na.Pointer, size1, size2, addzeros, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\numabasic.c (1083, 1)
' numaRead(filename) as Numa
' numaRead(const char *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaRead(
				 ByVal filename as String) as Numa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (1110, 1)
' numaReadStream(fp) as Numa
' numaReadStream(FILE *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>numa, or NULL on error</returns>
Public Shared Function numaReadStream(
				 ByVal fp as FILE) as Numa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (1156, 1)
' numaReadMem(data, size) as Numa
' numaReadMem(const l_uint8 *, size_t) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - numa serialization in ascii</param>
'''  <param name="size">[in] - of data can use strlen to get it</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaReadMem(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Numa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (1193, 1)
' numaWriteDebug(filename, na) as Integer
' numaWriteDebug(const char *, NUMA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Debug version, intended for use in the library when writing<para/>
''' to files in a temp directory with names that are compiled in.<para/>
''' This is used instead of numaWrite() for all such library calls.<para/>
''' (2) The global variable LeptDebugOK defaults to 0, and can be set<para/>
''' or cleared by the function setLeptDebugOK().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="na">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function numaWriteDebug(
				 ByVal filename as String, 
				 ByVal na as Numa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.numaWriteDebug( filename, na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1214, 1)
' numaWrite(filename, na) as Integer
' numaWrite(const char *, NUMA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="na">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWrite(
				 ByVal filename as String, 
				 ByVal na as Numa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.numaWrite( filename, na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1245, 1)
' numaWriteStream(fp, na) as Integer
' numaWriteStream(FILE *, NUMA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="na">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWriteStream(
				 ByVal fp as FILE, 
				 ByVal na as Numa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaWriteStream( fp.Pointer, na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1288, 1)
' numaWriteMem(pdata, psize, na) as Integer
' numaWriteMem(l_uint8 **, size_t *, NUMA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a numa in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized numa ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="na">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaWriteMem(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal na as Numa) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.numaWriteMem( pdataPTR, psize, na.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\numabasic.c (1339, 1)
' numaaCreate(n) as Numaa
' numaaCreate(l_int32) as NUMAA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of numa ptr array to be alloc'd 0 for default</param>
'''   <returns>naa, or NULL on error</returns>
Public Shared Function numaaCreate(
				 ByVal n as Integer) as Numaa





	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\numabasic.c (1377, 1)
' numaaCreateFull(nptr, n) as Numaa
' numaaCreateFull(l_int32, l_int32) as NUMAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allocates numaa and fills the array with allocated numas.<para/>
''' In use, after calling this function, use<para/>
''' numaaAddNumber(naa, index, val)<para/>
''' to add val to the index-th numa in naa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nptr">[in] - : size of numa ptr array to be alloc'd</param>
'''  <param name="n">[in] - : size of individual numa arrays to be alloc'd 0 for default</param>
'''   <returns>naa, or NULL on error</returns>
Public Shared Function numaaCreateFull(
				 ByVal nptr as Integer, 
				 ByVal n as Integer) as Numaa





	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaCreateFull( nptr, n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\numabasic.c (1408, 1)
' numaaTruncate(naa) as Integer
' numaaTruncate(NUMAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This identifies the largest index containing a numa that<para/>
''' has any numbers within it, destroys all numa beyond that<para/>
''' index, and resets the count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaTruncate(
				 ByVal naa as Numaa) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaTruncate( naa.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1442, 1)
' numaaDestroy(pnaa) as Object
' numaaDestroy(NUMAA **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="pnaa">[in,out] - to be nulled if it exists</param>
Public Shared Sub numaaDestroy(
				 ByRef pnaa as Numaa)




	Dim pnaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaa) Then pnaaPTR = pnaa.Pointer

	LeptonicaSharp.Natives.numaaDestroy( pnaaPTR)
	if pnaaPTR <> IntPtr.Zero then pnaa = new Numaa(pnaaPTR)

End Sub

' SRC\numabasic.c (1480, 1)
' numaaAddNuma(naa, na, copyflag) as Integer
' numaaAddNuma(NUMAA *, NUMA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="na">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaAddNuma(
				 ByVal naa as Numaa, 
				 ByVal na as Numa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaAddNuma( naa.Pointer, na.Pointer, copyflag)

	Return _Result
End Function

' SRC\numabasic.c (1548, 1)
' numaaGetCount(naa) as Integer
' numaaGetCount(NUMAA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''   <returns>count number of numa, or 0 if no numa or on error</returns>
Public Shared Function numaaGetCount(
				 ByVal naa as Numaa) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaGetCount( naa.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1566, 1)
' numaaGetNumaCount(naa, index) as Integer
' numaaGetNumaCount(NUMAA *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="index">[in] - of numa in naa</param>
'''   <returns>count of numbers in the referenced numa, or 0 on error.</returns>
Public Shared Function numaaGetNumaCount(
				 ByVal naa as Numaa, 
				 ByVal index as Integer) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaGetNumaCount( naa.Pointer, index)

	Return _Result
End Function

' SRC\numabasic.c (1587, 1)
' numaaGetNumberCount(naa) as Integer
' numaaGetNumberCount(NUMAA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''   <returns>count total number of numbers in the numaa, or 0 if no numbers or on error</returns>
Public Shared Function numaaGetNumberCount(
				 ByVal naa as Numaa) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaGetNumberCount( naa.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1636, 1)
' numaaGetPtrArray(naa) as Numa
' numaaGetPtrArray(NUMAA *) as NUMA **
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function is convenient for doing direct manipulation on<para/>
''' a fixed size array of Numas.  To do this, it sets the count<para/>
''' to the full size of the allocated array of Numa ptrs.<para/>
''' The originating Numaa owns this array: DO NOT free it!<para/>
''' (2) Intended usage:<para/>
''' Numaa naa = numaaCreate(n)<para/>
''' Numa array = numaaGetPtrArray(naa)<para/>
''' ...  [manipulate Numas directly on the array]<para/>
''' numaaDestroy( and naa)<para/>
''' (3) Cautions:<para/>
''' ~ Do not free this array it is owned by tne Numaa.<para/>
''' ~ Do not call any functions on the Numaa, other than<para/>
''' numaaDestroy() when you're finished with the array.<para/>
''' Adding a Numa will force a resize, destroying the ptr array.<para/>
''' ~ Do not address the array outside its allocated size.<para/>
''' With the bare array, there are no protections.  If the<para/>
''' allocated size is n, array[n] is an error.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''   <returns>the internal array of ptrs to Numa, or NULL on error</returns>
Public Shared Function numaaGetPtrArray(
				 ByVal naa as Numaa) as Numa

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaGetPtrArray( naa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing
Dim B as new Numa(_Result)

	Return B
End Function

' SRC\numabasic.c (1657, 1)
' numaaGetNuma(naa, index, accessflag) as Numa
' numaaGetNuma(NUMAA *, l_int32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="index">[in] - to the index-th numa</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>numa, or NULL on error</returns>
Public Shared Function numaaGetNuma(
				 ByVal naa as Numaa, 
				 ByVal index as Integer, 
				 ByVal accessflag as Enumerations.L_access_storage) as Numa

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaGetNuma( naa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\numabasic.c (1693, 1)
' numaaReplaceNuma(naa, index, na) as Integer
' numaaReplaceNuma(NUMAA *, l_int32, NUMA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Any existing numa is destroyed, and the input one<para/>
''' is inserted in its place.<para/>
''' (2) If the index is invalid, return 1 (error)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="index">[in] - to the index-th numa</param>
'''  <param name="na">[in] - insert and replace any existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaReplaceNuma(
				 ByVal naa as Numaa, 
				 ByVal index as Integer, 
				 ByVal na as Numa) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaReplaceNuma( naa.Pointer, index, na.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1726, 1)
' numaaGetValue(naa, i, j, pfval, pival) as Integer
' numaaGetValue(NUMAA *, l_int32, l_int32, l_float32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="i">[in] - index of numa within numaa</param>
'''  <param name="j">[in] - index into numa</param>
'''  <param name="pfval">[out][optional] - float value</param>
'''  <param name="pival">[out][optional] - int value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaGetValue(
				 ByVal naa as Numaa, 
				 ByVal i as Integer, 
				 ByVal j as Integer, 
				<Out()> ByRef pfval as Single(), 
				<Out()> ByRef pival as Integer) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaGetValue( naa.Pointer, i, j, pfval, pival)

	Return _Result
End Function

' SRC\numabasic.c (1769, 1)
' numaaAddNumber(naa, index, val) as Integer
' numaaAddNumber(NUMAA *, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Adds to an existing numa only.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - </param>
'''  <param name="index">[in] - of numa within numaa</param>
'''  <param name="val">[in] - float or int to be added stored as a float</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaAddNumber(
				 ByVal naa as Numaa, 
				 ByVal index as Integer, 
				 ByVal val as Single) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaAddNumber( naa.Pointer, index, val)

	Return _Result
End Function

' SRC\numabasic.c (1801, 1)
' numaaRead(filename) as Numaa
' numaaRead(const char *) as NUMAA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>naa, or NULL on error</returns>
Public Shared Function numaaRead(
				 ByVal filename as String) as Numaa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\numabasic.c (1828, 1)
' numaaReadStream(fp) as Numaa
' numaaReadStream(FILE *) as NUMAA *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>naa, or NULL on error</returns>
Public Shared Function numaaReadStream(
				 ByVal fp as FILE) as Numaa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\numabasic.c (1873, 1)
' numaaReadMem(data, size) as Numaa
' numaaReadMem(const l_uint8 *, size_t) as NUMAA *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - numaa serialization in ascii</param>
'''  <param name="size">[in] - of data can use strlen to get it</param>
'''   <returns>naa, or NULL on error</returns>
Public Shared Function numaaReadMem(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Numaa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\numabasic.c (1900, 1)
' numaaWrite(filename, naa) as Integer
' numaaWrite(const char *, NUMAA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="naa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaWrite(
				 ByVal filename as String, 
				 ByVal naa as Numaa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.numaaWrite( filename, naa.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1931, 1)
' numaaWriteStream(fp, naa) as Integer
' numaaWriteStream(FILE *, NUMAA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="naa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaWriteStream(
				 ByVal fp as FILE, 
				 ByVal naa as Numaa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.numaaWriteStream( fp.Pointer, naa.Pointer)

	Return _Result
End Function

' SRC\numabasic.c (1973, 1)
' numaaWriteMem(pdata, psize, naa) as Integer
' numaaWriteMem(l_uint8 **, size_t *, NUMAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a numaa in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized numaa ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="naa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function numaaWriteMem(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal naa as Numaa) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.numaaWriteMem( pdataPTR, psize, naa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class
