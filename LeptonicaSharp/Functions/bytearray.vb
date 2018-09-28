Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\bytearray.c (93, 1)
' l_byteaCreate()
' l_byteaCreate(size_t) as L_BYTEA *
'''  <summary>
''' Notes
''' (1) The allocated array is n + 1 bytes.  This allows room
''' for null termination.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nbytes">[in] - determines initial size of data array</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaCreate(
				ByVal nbytes as UInteger) as L_Bytea

	If IsNothing (nbytes) then Throw New ArgumentNullException  ("nbytes cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_byteaCreate( nbytes)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Bytea(_Result)
End Function

' SRC\bytearray.c (122, 1)
' l_byteaInitFromMem()
' l_byteaInitFromMem(const l_uint8 *, size_t) as L_BYTEA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - to be copied to the array</param>
'''  <param name="size">[in] - amount of data</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as L_Bytea

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_byteaInitFromMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Bytea(_Result)
End Function

' SRC\bytearray.c (149, 1)
' l_byteaInitFromFile()
' l_byteaInitFromFile(const char *) as L_BYTEA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromFile(
				ByVal fname as String) as L_Bytea

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_byteaInitFromFile( fname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Bytea(_Result)
End Function

' SRC\bytearray.c (176, 1)
' l_byteaInitFromStream()
' l_byteaInitFromStream(FILE *) as L_BYTEA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromStream(
				ByVal fp as FILE) as L_Bytea

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_byteaInitFromStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Bytea(_Result)
End Function

' SRC\bytearray.c (213, 1)
' l_byteaCopy()
' l_byteaCopy(L_BYTEA *, l_int32) as L_BYTEA *
'''  <summary>
''' Notes
''' (1) If cloning, up the refcount and return a ptr to %bas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="bas">[in] - source lba</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>clone or copy of bas, or NULL on error</returns>
Public Shared Function l_byteaCopy(
				ByVal bas as L_Bytea, 
				ByVal copyflag as Enumerations.L_access_storage) as L_Bytea

	If IsNothing (bas) then Throw New ArgumentNullException  ("bas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_byteaCopy( bas.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Bytea(_Result)
End Function

' SRC\bytearray.c (245, 1)
' l_byteaDestroy()
' l_byteaDestroy(L_BYTEA **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the lba.
''' (2) Always nulls the input ptr.
''' (3) If the data has been previously removed, the lba will
''' have been nulled, so this will do nothing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pba">[in,out] - will be set to null before returning</param>
Public Shared Sub l_byteaDestroy(
				ByRef pba as L_Bytea)


	Dim pbaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pba) Then pbaPTR = pba.Pointer

	LeptonicaSharp.Natives.l_byteaDestroy( pbaPTR)
	if pbaPTR <> IntPtr.Zero then pba = new L_Bytea(pbaPTR)

End Sub

' SRC\bytearray.c (281, 1)
' l_byteaGetSize()
' l_byteaGetSize(L_BYTEA *) as size_t
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''   <returns>size of stored byte array, or 0 on error</returns>
Public Shared Function l_byteaGetSize(
				ByVal ba as L_Bytea) as UInteger

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.l_byteaGetSize( ba.Pointer)

	Return _Result
End Function

' SRC\bytearray.c (304, 1)
' l_byteaGetData()
' l_byteaGetData(L_BYTEA *, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The returned ptr is owned by %ba.  Do not free it!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''  <param name="psize">[out] - size of data in lba</param>
'''   <returns>ptr to existing data array, or NULL on error</returns>
Public Shared Function l_byteaGetData(
				ByVal ba as L_Bytea, 
				ByRef psize as UInteger) as Byte()

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_byteaGetData( ba.Pointer, psize)

	Return _Result
End Function

' SRC\bytearray.c (333, 1)
' l_byteaCopyData()
' l_byteaCopyData(L_BYTEA *, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The returned data is owned by the caller.  The input %ba
''' still owns the original data array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''  <param name="psize">[out] - size of data in lba</param>
'''   <returns>copy of data in use in the data array, or NULL on error.</returns>
Public Shared Function l_byteaCopyData(
				ByVal ba as L_Bytea, 
				ByRef psize as UInteger) as Byte()

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_byteaCopyData( ba.Pointer, psize)

	Return _Result
End Function

' SRC\bytearray.c (363, 1)
' l_byteaAppendData()
' l_byteaAppendData(L_BYTEA *, const l_uint8 *, size_t) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''  <param name="newdata">[in] - byte array to be appended</param>
'''  <param name="newbytes">[in] - size of data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaAppendData(
				ByVal ba as L_Bytea, 
				ByVal newdata as Byte(), 
				ByVal newbytes as UInteger) as Integer

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	If IsNothing (newdata) then Throw New ArgumentNullException  ("newdata cannot be Nothing")
	If IsNothing (newbytes) then Throw New ArgumentNullException  ("newbytes cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaAppendData( ba.Pointer, newdata, newbytes)

	Return _Result
End Function

' SRC\bytearray.c (396, 1)
' l_byteaAppendString()
' l_byteaAppendString(L_BYTEA *, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''  <param name="str">[in] - null-terminated string to be appended</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaAppendString(
				ByVal ba as L_Bytea, 
				ByVal str as String) as Integer

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaAppendString( ba.Pointer, str)

	Return _Result
End Function

' SRC\bytearray.c (465, 1)
' l_byteaJoin()
' l_byteaJoin(L_BYTEA *, L_BYTEA **) as l_ok
'''  <summary>
''' Notes
''' (1) It is a no-op, not an error, for %ba2 to be null.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba1">[in] - </param>
'''  <param name="pba2">[in,out] - data array is added to the one in ba1, and then ba2 is destroyed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaJoin(
				ByVal ba1 as L_Bytea, 
				ByRef pba2 as L_Bytea) as Integer

	If IsNothing (ba1) then Throw New ArgumentNullException  ("ba1 cannot be Nothing")

	Dim pba2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pba2) Then pba2PTR = pba2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaJoin( ba1.Pointer, pba2PTR)
	if pba2PTR <> IntPtr.Zero then pba2 = new L_Bytea(pba2PTR)

	Return _Result
End Function

' SRC\bytearray.c (497, 1)
' l_byteaSplit()
' l_byteaSplit(L_BYTEA *, size_t, L_BYTEA **) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba1">[in] - lba to split; array bytes nulled beyond the split loc</param>
'''  <param name="splitloc">[in] - location in ba1 to split; ba2 begins there</param>
'''  <param name="pba2">[out] - with data starting at splitloc</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaSplit(
				ByVal ba1 as L_Bytea, 
				ByVal splitloc as UInteger, 
				ByRef pba2 as L_Bytea) as Integer

	If IsNothing (ba1) then Throw New ArgumentNullException  ("ba1 cannot be Nothing")
	If IsNothing (splitloc) then Throw New ArgumentNullException  ("splitloc cannot be Nothing")

	Dim pba2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pba2) Then pba2PTR = pba2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaSplit( ba1.Pointer, splitloc, pba2PTR)
	if pba2PTR <> IntPtr.Zero then pba2 = new L_Bytea(pba2PTR)

	Return _Result
End Function

' SRC\bytearray.c (540, 1)
' l_byteaFindEachSequence()
' l_byteaFindEachSequence(L_BYTEA *, const l_uint8 *, size_t, L_DNA **) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ba">[in] - </param>
'''  <param name="sequence">[in] - subarray of bytes to find in data</param>
'''  <param name="seqlen">[in] - length of sequence, in bytes</param>
'''  <param name="pda">[out] - byte positions of each occurrence of %sequence</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaFindEachSequence(
				ByVal ba as L_Bytea, 
				ByVal sequence as Byte(), 
				ByVal seqlen as UInteger, 
				ByRef pda as L_Dna) as Integer

	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")
	If IsNothing (seqlen) then Throw New ArgumentNullException  ("seqlen cannot be Nothing")

	Dim pdaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pda) Then pdaPTR = pda.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaFindEachSequence( ba.Pointer, sequence, seqlen, pdaPTR)
	if pdaPTR <> IntPtr.Zero then pda = new L_Dna(pdaPTR)

	Return _Result
End Function

' SRC\bytearray.c (578, 1)
' l_byteaWrite()
' l_byteaWrite(const char *, L_BYTEA *, size_t, size_t) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - output file</param>
'''  <param name="ba">[in] - </param>
'''  <param name="startloc">[in] - first byte to output</param>
'''  <param name="endloc">[in] - last byte to output; use 0 to write to the end of the data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaWrite(
				ByVal fname as String, 
				ByVal ba as L_Bytea, 
				ByVal startloc as UInteger, 
				ByVal endloc as UInteger) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	If IsNothing (startloc) then Throw New ArgumentNullException  ("startloc cannot be Nothing")
	If IsNothing (endloc) then Throw New ArgumentNullException  ("endloc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaWrite( fname, ba.Pointer, startloc, endloc)

	Return _Result
End Function

' SRC\bytearray.c (612, 1)
' l_byteaWriteStream()
' l_byteaWriteStream(FILE *, L_BYTEA *, size_t, size_t) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for binary write</param>
'''  <param name="ba">[in] - </param>
'''  <param name="startloc">[in] - first byte to output</param>
'''  <param name="endloc">[in] - last byte to output; use 0 to write to the end of the data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaWriteStream(
				ByVal fp as FILE, 
				ByVal ba as L_Bytea, 
				ByVal startloc as UInteger, 
				ByVal endloc as UInteger) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	If IsNothing (startloc) then Throw New ArgumentNullException  ("startloc cannot be Nothing")
	If IsNothing (endloc) then Throw New ArgumentNullException  ("endloc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_byteaWriteStream( fp.Pointer, ba.Pointer, startloc, endloc)

	Return _Result
End Function

End Class