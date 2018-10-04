Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dnabasic.c (169, 1)
' l_dnaCreate(n) as L_Dna
' l_dnaCreate(l_int32) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of number array to be alloc'd 0 for default</param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function l_dnaCreate(
				 ByVal n as Integer) as L_Dna



	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (210, 1)
' l_dnaCreateFromIArray(iarray, size) as L_Dna
' l_dnaCreateFromIArray(l_int32 *, l_int32) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We can't insert this int array into the l_dna, because a l_dna<para/>
''' takes a double array.  So this just copies the data from the<para/>
''' input array into the l_dna.  The input array continues to be<para/>
''' owned by the caller.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="iarray">[in] - integer</param>
'''  <param name="size">[in] - of the array</param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function l_dnaCreateFromIArray(
				 ByVal iarray as Integer(), 
				 ByVal size as Integer) as L_Dna

	If IsNothing (iarray) then Throw New ArgumentNullException  ("iarray cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaCreateFromIArray( iarray, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (247, 1)
' l_dnaCreateFromDArray(darray, size, copyflag) as L_Dna
' l_dnaCreateFromDArray(l_float64 *, l_int32, l_int32) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) With L_INSERT, ownership of the input array is transferred<para/>
''' to the returned l_dna, and all %size elements are considered<para/>
''' to be valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="darray">[in] - float</param>
'''  <param name="size">[in] - of the array</param>
'''  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function l_dnaCreateFromDArray(
				 ByVal darray as Double(), 
				 ByVal size as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as L_Dna

	If IsNothing (darray) then Throw New ArgumentNullException  ("darray cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaCreateFromDArray( darray, size, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (286, 1)
' l_dnaMakeSequence(startval, increment, size) as L_Dna
' l_dnaMakeSequence(l_float64, l_float64, l_int32) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="startval">[in] - </param>
'''  <param name="increment">[in] - </param>
'''  <param name="size">[in] - of sequence</param>
'''   <returns>l_dna of sequence of evenly spaced values, or NULL on error</returns>
Public Shared Function l_dnaMakeSequence(
				 ByVal startval as Double, 
				 ByVal increment as Double, 
				 ByVal size as Integer) as L_Dna

	If IsNothing (startval) then Throw New ArgumentNullException  ("startval cannot be Nothing")
	If IsNothing (increment) then Throw New ArgumentNullException  ("increment cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaMakeSequence( startval, increment, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (321, 1)
' l_dnaDestroy(pda) as Object
' l_dnaDestroy(L_DNA **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Decrements the ref count and, if 0, destroys the l_dna.<para/>
''' (2) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pda">[in,out] - to be nulled if it exists</param>
Public Shared Sub l_dnaDestroy(
				 ByRef pda as L_Dna)


	Dim pdaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pda) Then pdaPTR = pda.Pointer

	LeptonicaSharp.Natives.l_dnaDestroy( pdaPTR)
	if pdaPTR <> IntPtr.Zero then pda = new L_Dna(pdaPTR)

End Sub

' SRC\dnabasic.c (360, 1)
' l_dnaCopy(da) as L_Dna
' l_dnaCopy(L_DNA *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes unused ptrs above da- is greater n.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>copy of da, or NULL on error</returns>
Public Shared Function l_dnaCopy(
				 ByVal da as L_Dna) as L_Dna

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaCopy( da.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (389, 1)
' l_dnaClone(da) as L_Dna
' l_dnaClone(L_DNA *) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>ptr to same da, or NULL on error</returns>
Public Shared Function l_dnaClone(
				 ByVal da as L_Dna) as L_Dna

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaClone( da.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (415, 1)
' l_dnaEmpty(da) as Integer
' l_dnaEmpty(L_DNA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does not change the allocation of the array.<para/>
''' It just clears the number of stored numbers, so that<para/>
''' the array appears to be empty.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaEmpty(
				 ByVal da as L_Dna) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaEmpty( da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (439, 1)
' l_dnaAddNumber(da, val) as Integer
' l_dnaAddNumber(L_DNA *, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="val">[in] - float or int to be added stored as a float</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaAddNumber(
				 ByVal da as L_Dna, 
				 ByVal val as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaAddNumber( da.Pointer, val)

	Return _Result
End Function

' SRC\dnabasic.c (500, 1)
' l_dnaInsertNumber(da, index, val) as Integer
' l_dnaInsertNumber(L_DNA *, l_int32, l_float64) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts da[i] -- is greater  da[i + 1] for all i  is greater = index,<para/>
''' and then inserts val as da[index].<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - location in da to insert new value</param>
'''  <param name="val">[in] - float64 or integer to be added</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaInsertNumber(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				 ByVal val as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaInsertNumber( da.Pointer, index, val)

	Return _Result
End Function

' SRC\dnabasic.c (539, 1)
' l_dnaRemoveNumber(da, index) as Integer
' l_dnaRemoveNumber(L_DNA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts da[i] -- is greater  da[i - 1] for all i  is greater  index.<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - element to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaRemoveNumber(
				 ByVal da as L_Dna, 
				 ByVal index as Integer) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaRemoveNumber( da.Pointer, index)

	Return _Result
End Function

' SRC\dnabasic.c (568, 1)
' l_dnaReplaceNumber(da, index, val) as Integer
' l_dnaReplaceNumber(L_DNA *, l_int32, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - element to be replaced</param>
'''  <param name="val">[in] - new value to replace old one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaReplaceNumber(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				 ByVal val as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaReplaceNumber( da.Pointer, index, val)

	Return _Result
End Function

' SRC\dnabasic.c (597, 1)
' l_dnaGetCount(da) as Integer
' l_dnaGetCount(L_DNA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>count, or 0 if no numbers or on error</returns>
Public Shared Function l_dnaGetCount(
				 ByVal da as L_Dna) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaGetCount( da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (624, 1)
' l_dnaSetCount(da, newcount) as Integer
' l_dnaSetCount(L_DNA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If newcount  is lower = da- is greater nalloc, this resets da- is greater n.<para/>
''' Using newcount = 0 is equivalent to l_dnaEmpty().<para/>
''' (2) If newcount  is greater  da- is greater nalloc, this causes a realloc<para/>
''' to a size da- is greater nalloc = newcount.<para/>
''' (3) All the previously unused values in da are set to 0.0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="newcount">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaSetCount(
				 ByVal da as L_Dna, 
				 ByVal newcount as Integer) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaSetCount( da.Pointer, newcount)

	Return _Result
End Function

' SRC\dnabasic.c (658, 1)
' l_dnaGetDValue(da, index, pval) as Integer
' l_dnaGetDValue(L_DNA *, l_int32, l_float64 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caller may need to check the function return value to<para/>
''' decide if a 0.0 in the returned ival is valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - into l_dna</param>
'''  <param name="pval">[out] - double value 0.0 on error</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaGetDValue(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				<Out()> ByRef pval as Double()) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaGetDValue( da.Pointer, index, pval)

	Return _Result
End Function

' SRC\dnabasic.c (693, 1)
' l_dnaGetIValue(da, index, pival) as Integer
' l_dnaGetIValue(L_DNA *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caller may need to check the function return value to<para/>
''' decide if a 0 in the returned ival is valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - into l_dna</param>
'''  <param name="pival">[out] - integer value 0 on error</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaGetIValue(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				<Out()> ByRef pival as Integer) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaGetIValue( da.Pointer, index, pival)

	Return _Result
End Function

' SRC\dnabasic.c (725, 1)
' l_dnaSetValue(da, index, val) as Integer
' l_dnaSetValue(L_DNA *, l_int32, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - to element to be set</param>
'''  <param name="val">[in] - to set element</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaSetValue(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				 ByVal val as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaSetValue( da.Pointer, index, val)

	Return _Result
End Function

' SRC\dnabasic.c (750, 1)
' l_dnaShiftValue(da, index, diff) as Integer
' l_dnaShiftValue(L_DNA *, l_int32, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="index">[in] - to element to change relative to the current value</param>
'''  <param name="diff">[in] - increment if diff  is greater  0 or decrement if diff  is lower  0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaShiftValue(
				 ByVal da as L_Dna, 
				 ByVal index as Integer, 
				 ByVal diff as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (diff) then Throw New ArgumentNullException  ("diff cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaShiftValue( da.Pointer, index, diff)

	Return _Result
End Function

' SRC\dnabasic.c (786, 1)
' l_dnaGetIArray(da) as Integer()
' l_dnaGetIArray(L_DNA *) as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A copy of the array is made, because we need to<para/>
''' generate an integer array from the bare double array.<para/>
''' The caller is responsible for freeing the array.<para/>
''' (2) The array size is determined by the number of stored numbers,<para/>
''' not by the size of the allocated array in the l_dna.<para/>
''' (3) This function is provided to simplify calculations<para/>
''' using the bare internal array, rather than continually<para/>
''' calling accessors on the l_dna.  It is typically used<para/>
''' on an array of size 256.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>a copy of the bare internal array, integerized by rounding, or NULL on error</returns>
Public Shared Function l_dnaGetIArray(
				 ByVal da as L_Dna) as Integer()

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer() = LeptonicaSharp.Natives.l_dnaGetIArray( da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (831, 1)
' l_dnaGetDArray(da, copyflag) as Double()
' l_dnaGetDArray(L_DNA *, l_int32) as l_float64 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If copyflag == L_COPY, it makes a copy which the caller<para/>
''' is responsible for freeing.  Otherwise, it operates<para/>
''' directly on the bare array of the l_dna.<para/>
''' (2) Very important: for L_NOCOPY, any writes to the array<para/>
''' will be in the l_dna.  Do not write beyond the size of<para/>
''' the count field, because it will not be accessible<para/>
''' from the l_dna!  If necessary, be sure to set the count<para/>
''' field to a larger number (such as the alloc size)<para/>
''' BEFORE calling this function.  Creating with l_dnaMakeConstant()<para/>
''' is another way to insure full initialization.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
'''   <returns>either the bare internal array or a copy of it, or NULL on error</returns>
Public Shared Function l_dnaGetDArray(
				 ByVal da as L_Dna, 
				 ByVal copyflag as Enumerations.L_access_storage) as Double()

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Double() = LeptonicaSharp.Natives.l_dnaGetDArray( da.Pointer, copyflag)

	Return _Result
End Function

' SRC\dnabasic.c (863, 1)
' l_dnaGetRefcount(da) as Integer
' l_dnaGetRefcount(L_DNA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function l_dnaGetRefcount(
				 ByVal da as L_Dna) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaGetRefcount( da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (881, 1)
' l_dnaChangeRefcount(da, delta) as Integer
' l_dnaChangeRefcount(L_DNA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="delta">[in] - change to be applied</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaChangeRefcount(
				 ByVal da as L_Dna, 
				 ByVal delta as Integer) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaChangeRefcount( da.Pointer, delta)

	Return _Result
End Function

' SRC\dnabasic.c (902, 1)
' l_dnaGetParameters(da, pstartx, pdelx) as Integer
' l_dnaGetParameters(L_DNA *, l_float64 *, l_float64 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="pstartx">[out][optional] - startx</param>
'''  <param name="pdelx">[out][optional] - delx</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaGetParameters(
				 ByVal da as L_Dna, 
				<Out()> ByRef pstartx as Double(), 
				<Out()> ByRef pdelx as Double()) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaGetParameters( da.Pointer, pstartx, pdelx)

	Return _Result
End Function

' SRC\dnabasic.c (932, 1)
' l_dnaSetParameters(da, startx, delx) as Integer
' l_dnaSetParameters(L_DNA *, l_float64, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="startx">[in] - x value corresponding to da[0]</param>
'''  <param name="delx">[in] - difference in x values for the situation where the elements of da correspond to the evaulation of a function at equal intervals of size %delx</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaSetParameters(
				 ByVal da as L_Dna, 
				 ByVal startx as Double, 
				 ByVal delx as Double) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (startx) then Throw New ArgumentNullException  ("startx cannot be Nothing")
	If IsNothing (delx) then Throw New ArgumentNullException  ("delx cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaSetParameters( da.Pointer, startx, delx)

	Return _Result
End Function

' SRC\dnabasic.c (955, 1)
' l_dnaCopyParameters(dad, das) as Integer
' l_dnaCopyParameters(L_DNA *, L_DNA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="dad">[in] - destination DNuma</param>
'''  <param name="das">[in] - source DNuma</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaCopyParameters(
				 ByVal dad as L_Dna, 
				 ByVal das as L_Dna) as Integer

	If IsNothing (dad) then Throw New ArgumentNullException  ("dad cannot be Nothing")
	If IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaCopyParameters( dad.Pointer, das.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (981, 1)
' l_dnaRead(filename) as L_Dna
' l_dnaRead(const char *) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function l_dnaRead(
				 ByVal filename as String) as L_Dna

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (1013, 1)
' l_dnaReadStream(fp) as L_Dna
' l_dnaReadStream(FILE *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) fscanf takes %lf to read a double fprintf takes %f to write it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function l_dnaReadStream(
				 ByVal fp as FILE) as L_Dna

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (1056, 1)
' l_dnaWrite(filename, da) as Integer
' l_dnaWrite(const char *, L_DNA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="da">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaWrite(
				 ByVal filename as String, 
				 ByVal da as L_Dna) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaWrite( filename, da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1087, 1)
' l_dnaWriteStream(fp, da) as Integer
' l_dnaWriteStream(FILE *, L_DNA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="da">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaWriteStream(
				 ByVal fp as FILE, 
				 ByVal da as L_Dna) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaWriteStream( fp.Pointer, da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1127, 1)
' l_dnaaCreate(n) as L_Dnaa
' l_dnaaCreate(l_int32) as L_DNAA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of l_dna ptr array to be alloc'd 0 for default</param>
'''   <returns>daa, or NULL on error</returns>
Public Shared Function l_dnaaCreate(
				 ByVal n as Integer) as L_Dnaa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dnaa(_Result)
End Function

' SRC\dnabasic.c (1163, 1)
' l_dnaaCreateFull(nptr, n) as L_Dnaa
' l_dnaaCreateFull(l_int32, l_int32) as L_DNAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allocates a dnaa and fills the array with allocated dnas.<para/>
''' In use, after calling this function, use<para/>
''' l_dnaaAddNumber(dnaa, index, val)<para/>
''' to add val to the index-th dna in dnaa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nptr">[in] - : size of dna ptr array to be alloc'd</param>
'''  <param name="n">[in] - : size of individual dna arrays to be alloc'd 0 for default</param>
'''   <returns>daa, or NULL on error</returns>
Public Shared Function l_dnaaCreateFull(
				 ByVal nptr as Integer, 
				 ByVal n as Integer) as L_Dnaa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaCreateFull( nptr, n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dnaa(_Result)
End Function

' SRC\dnabasic.c (1194, 1)
' l_dnaaTruncate(daa) as Integer
' l_dnaaTruncate(L_DNAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This identifies the largest index containing a dna that<para/>
''' has any numbers within it, destroys all dna beyond that<para/>
''' index, and resets the count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaTruncate(
				 ByVal daa as L_Dnaa) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaTruncate( daa.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1228, 1)
' l_dnaaDestroy(pdaa) as Object
' l_dnaaDestroy(L_DNAA **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="pdaa">[in,out] - to be nulled if it exists</param>
Public Shared Sub l_dnaaDestroy(
				 ByRef pdaa as L_Dnaa)


	Dim pdaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdaa) Then pdaaPTR = pdaa.Pointer

	LeptonicaSharp.Natives.l_dnaaDestroy( pdaaPTR)
	if pdaaPTR <> IntPtr.Zero then pdaa = new L_Dnaa(pdaaPTR)

End Sub

' SRC\dnabasic.c (1265, 1)
' l_dnaaAddDna(daa, da, copyflag) as Integer
' l_dnaaAddDna(L_DNAA *, L_DNA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="da">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaAddDna(
				 ByVal daa as L_Dnaa, 
				 ByVal da as L_Dna, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")
	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaAddDna( daa.Pointer, da.Pointer, copyflag)

	Return _Result
End Function

' SRC\dnabasic.c (1333, 1)
' l_dnaaGetCount(daa) as Integer
' l_dnaaGetCount(L_DNAA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''   <returns>count number of l_dna, or 0 if no l_dna or on error</returns>
Public Shared Function l_dnaaGetCount(
				 ByVal daa as L_Dnaa) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaGetCount( daa.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1351, 1)
' l_dnaaGetDnaCount(daa, index) as Integer
' l_dnaaGetDnaCount(L_DNAA *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="index">[in] - of l_dna in daa</param>
'''   <returns>count of numbers in the referenced l_dna, or 0 on error.</returns>
Public Shared Function l_dnaaGetDnaCount(
				 ByVal daa as L_Dnaa, 
				 ByVal index as Integer) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaGetDnaCount( daa.Pointer, index)

	Return _Result
End Function

' SRC\dnabasic.c (1372, 1)
' l_dnaaGetNumberCount(daa) as Integer
' l_dnaaGetNumberCount(L_DNAA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''   <returns>count total number of numbers in the l_dnaa, or 0 if no numbers or on error</returns>
Public Shared Function l_dnaaGetNumberCount(
				 ByVal daa as L_Dnaa) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaGetNumberCount( daa.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1402, 1)
' l_dnaaGetDna(daa, index, accessflag) as L_Dna
' l_dnaaGetDna(L_DNAA *, l_int32, l_int32) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="index">[in] - to the index-th l_dna</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>l_dna, or NULL on error</returns>
Public Shared Function l_dnaaGetDna(
				 ByVal daa as L_Dnaa, 
				 ByVal index as Integer, 
				 ByVal accessflag as Enumerations.L_access_storage) as L_Dna

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaGetDna( daa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnabasic.c (1438, 1)
' l_dnaaReplaceDna(daa, index, da) as Integer
' l_dnaaReplaceDna(L_DNAA *, l_int32, L_DNA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Any existing l_dna is destroyed, and the input one<para/>
''' is inserted in its place.<para/>
''' (2) If the index is invalid, return 1 (error)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="index">[in] - to the index-th l_dna</param>
'''  <param name="da">[in] - insert and replace any existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaReplaceDna(
				 ByVal daa as L_Dnaa, 
				 ByVal index as Integer, 
				 ByVal da as L_Dna) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")
	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaReplaceDna( daa.Pointer, index, da.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1470, 1)
' l_dnaaGetValue(daa, i, j, pval) as Integer
' l_dnaaGetValue(L_DNAA *, l_int32, l_int32, l_float64 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="i">[in] - index of l_dna within l_dnaa</param>
'''  <param name="j">[in] - index into l_dna</param>
'''  <param name="pval">[out] - double value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaGetValue(
				 ByVal daa as L_Dnaa, 
				 ByVal i as Integer, 
				 ByVal j as Integer, 
				<Out()> ByRef pval as Double()) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaGetValue( daa.Pointer, i, j, pval)

	Return _Result
End Function

' SRC\dnabasic.c (1510, 1)
' l_dnaaAddNumber(daa, index, val) as Integer
' l_dnaaAddNumber(L_DNAA *, l_int32, l_float64) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Adds to an existing l_dna only.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''  <param name="index">[in] - of l_dna within l_dnaa</param>
'''  <param name="val">[in] - number to be added stored as a double</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaAddNumber(
				 ByVal daa as L_Dnaa, 
				 ByVal index as Integer, 
				 ByVal val as Double) as Integer

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaAddNumber( daa.Pointer, index, val)

	Return _Result
End Function

' SRC\dnabasic.c (1542, 1)
' l_dnaaRead(filename) as L_Dnaa
' l_dnaaRead(const char *) as L_DNAA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>daa, or NULL on error</returns>
Public Shared Function l_dnaaRead(
				 ByVal filename as String) as L_Dnaa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dnaa(_Result)
End Function

' SRC\dnabasic.c (1569, 1)
' l_dnaaReadStream(fp) as L_Dnaa
' l_dnaaReadStream(FILE *) as L_DNAA *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>daa, or NULL on error</returns>
Public Shared Function l_dnaaReadStream(
				 ByVal fp as FILE) as L_Dnaa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dnaa(_Result)
End Function

' SRC\dnabasic.c (1613, 1)
' l_dnaaWrite(filename, daa) as Integer
' l_dnaaWrite(const char *, L_DNAA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="daa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaWrite(
				 ByVal filename as String, 
				 ByVal daa as L_Dnaa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaWrite( filename, daa.Pointer)

	Return _Result
End Function

' SRC\dnabasic.c (1644, 1)
' l_dnaaWriteStream(fp, daa) as Integer
' l_dnaaWriteStream(FILE *, L_DNAA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="daa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaaWriteStream(
				 ByVal fp as FILE, 
				 ByVal daa as L_Dnaa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaaWriteStream( fp.Pointer, daa.Pointer)

	Return _Result
End Function

End Class
