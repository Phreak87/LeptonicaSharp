Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' bytearray.c (93, 1)
' l_byteaCreate(nbytes) as L_Bytea
' l_byteaCreate(size_t) as L_BYTEA *
'''  <summary>
''' (1) The allocated array is n + 1 bytes.  This allows room
'''for null termination.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCreate/*"/>
'''  <param name="nbytes">[in] - determines initial size of data array</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaCreate(
				ByVal nbytes as UInteger) as L_Bytea


	Dim _Result as IntPtr = Natives.l_byteaCreate(  nbytes)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bytea(_Result)
End Function

' bytearray.c (122, 1)
' l_byteaInitFromMem(data, size) as L_Bytea
' l_byteaInitFromMem(const l_uint8 *, size_t) as L_BYTEA *
'''  <summary>
''' l_byteaInitFromMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaInitFromMem/*"/>
'''  <param name="data">[in] - to be copied to the array</param>
'''  <param name="size">[in] - amount of data</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as L_Bytea


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_byteaInitFromMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bytea(_Result)
End Function

' bytearray.c (149, 1)
' l_byteaInitFromFile(fname) as L_Bytea
' l_byteaInitFromFile(const char *) as L_BYTEA *
'''  <summary>
''' l_byteaInitFromFile()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaInitFromFile/*"/>
'''  <param name="fname">[in] - </param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromFile(
				ByVal fname as String) as L_Bytea


if IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
If My.Computer.Filesystem.FileExists (fname) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.l_byteaInitFromFile(  fname)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bytea(_Result)
End Function

' bytearray.c (176, 1)
' l_byteaInitFromStream(fp) as L_Bytea
' l_byteaInitFromStream(FILE *) as L_BYTEA *
'''  <summary>
''' l_byteaInitFromStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaInitFromStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>l_bytea, or NULL on error</returns>
Public Shared Function l_byteaInitFromStream(
				ByVal fp as FILE) as L_Bytea


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_byteaInitFromStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bytea(_Result)
End Function

' bytearray.c (213, 1)
' l_byteaCopy(bas, copyflag) as L_Bytea
' l_byteaCopy(L_BYTEA *, l_int32) as L_BYTEA *
'''  <summary>
''' (1) If cloning, up the refcount and return a ptr to %bas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCopy/*"/>
'''  <param name="bas">[in] - source lba</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>clone or copy of bas, or NULL on error</returns>
Public Shared Function l_byteaCopy(
				ByVal bas as L_Bytea, 
				ByVal copyflag as Enumerations.L_access_storage) as L_Bytea


if IsNothing (bas) then Throw New ArgumentNullException  ("bas cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_byteaCopy(bas.Pointer,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bytea(_Result)
End Function

' bytearray.c (245, 1)
' l_byteaDestroy(pba) as Object
' l_byteaDestroy(L_BYTEA **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the lba.<para/>
'''
'''(2) Always nulls the input ptr.<para/>
'''
'''(3) If the data has been previously removed, the lba will
'''have been nulled, so this will do nothing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaDestroy/*"/>
'''  <param name="pba">[in,out] - will be set to null before returning</param>
Public Shared Sub l_byteaDestroy(
				ByRef pba as L_Bytea)


	Dim pbaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pba) Then pbaPtr = pba.Pointer

	Natives.l_byteaDestroy( pbaPtr)
	
	if pbaPtr = IntPtr.Zero then pba = Nothing else pba = new L_Bytea(pbaPtr)
End Sub

' bytearray.c (281, 1)
' l_byteaGetSize(ba) as UInteger
' l_byteaGetSize(L_BYTEA *) as size_t
'''  <summary>
''' l_byteaGetSize()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaGetSize/*"/>
'''  <param name="ba">[in] - </param>
'''   <returns>size of stored byte array, or 0 on error</returns>
Public Shared Function l_byteaGetSize(
				ByVal ba as L_Bytea) as UInteger


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as UInteger = Natives.l_byteaGetSize(ba.Pointer)
	
	return _Result
End Function

' bytearray.c (304, 1)
' l_byteaGetData(ba, psize) as Byte()
' l_byteaGetData(L_BYTEA *, size_t *) as l_uint8 *
'''  <summary>
''' (1) The returned ptr is owned by %ba.  Do not free it!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaGetData/*"/>
'''  <param name="ba">[in] - </param>
'''  <param name="psize">[out] - size of data in lba</param>
'''   <returns>ptr to existing data array, or NULL on error</returns>
Public Shared Function l_byteaGetData(
				ByVal ba as L_Bytea, 
				<Out()>  ByRef psize as UInteger) as Byte()


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as Byte() = Natives.l_byteaGetData(ba.Pointer,   psize)
	
	return _Result
End Function

' bytearray.c (333, 1)
' l_byteaCopyData(ba, psize) as Byte()
' l_byteaCopyData(L_BYTEA *, size_t *) as l_uint8 *
'''  <summary>
''' (1) The returned data is owned by the caller.  The input %ba
'''still owns the original data array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCopyData/*"/>
'''  <param name="ba">[in] - </param>
'''  <param name="psize">[out] - size of data in lba</param>
'''   <returns>copy of data in use in the data array, or NULL on error.</returns>
Public Shared Function l_byteaCopyData(
				ByVal ba as L_Bytea, 
				<Out()>  ByRef psize as UInteger) as Byte()


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as Byte() = Natives.l_byteaCopyData(ba.Pointer,   psize)
	
	return _Result
End Function

' bytearray.c (363, 1)
' l_byteaAppendData(ba, newdata, newbytes) as Integer
' l_byteaAppendData(L_BYTEA *, const l_uint8 *, size_t) as l_ok
'''  <summary>
''' l_byteaAppendData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaAppendData/*"/>
'''  <param name="ba">[in] - </param>
'''  <param name="newdata">[in] - byte array to be appended</param>
'''  <param name="newbytes">[in] - size of data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaAppendData(
				ByVal ba as L_Bytea, 
				ByVal newdata as Byte(), 
				ByVal newbytes as UInteger) as Integer


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
		if IsNothing (newdata) then Throw New ArgumentNullException  ("newdata cannot be Nothing")
	Dim _Result as Integer = Natives.l_byteaAppendData(ba.Pointer,   newdata,   newbytes)
	
	return _Result
End Function

' bytearray.c (396, 1)
' l_byteaAppendString(ba, str) as Integer
' l_byteaAppendString(L_BYTEA *, const char *) as l_ok
'''  <summary>
''' l_byteaAppendString()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaAppendString/*"/>
'''  <param name="ba">[in] - </param>
'''  <param name="str">[in] - null-terminated string to be appended</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaAppendString(
				ByVal ba as L_Bytea, 
				ByVal str as String) as Integer


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
		if IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")
	Dim _Result as Integer = Natives.l_byteaAppendString(ba.Pointer,   str)
	
	return _Result
End Function

' bytearray.c (465, 1)
' l_byteaJoin(ba1, pba2) as Integer
' l_byteaJoin(L_BYTEA *, L_BYTEA **) as l_ok
'''  <summary>
''' (1) It is a no-op, not an error, for %ba2 to be null.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaJoin/*"/>
'''  <param name="ba1">[in] - </param>
'''  <param name="pba2">[in,out] - data array is added to the one in ba1, and then ba2 is destroyed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaJoin(
				ByVal ba1 as L_Bytea, 
				ByRef pba2 as L_Bytea) as Integer


if IsNothing (ba1) then Throw New ArgumentNullException  ("ba1 cannot be Nothing")
	Dim pba2Ptr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pba2) Then pba2Ptr = pba2.Pointer

	Dim _Result as Integer = Natives.l_byteaJoin(ba1.Pointer,  pba2Ptr)
	
	if pba2Ptr = IntPtr.Zero then pba2 = Nothing else pba2 = new L_Bytea(pba2Ptr)
	return _Result
End Function

' bytearray.c (497, 1)
' l_byteaSplit(ba1, splitloc, pba2) as Integer
' l_byteaSplit(L_BYTEA *, size_t, L_BYTEA **) as l_ok
'''  <summary>
''' l_byteaSplit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaSplit/*"/>
'''  <param name="ba1">[in] - lba to split array bytes nulled beyond the split loc</param>
'''  <param name="splitloc">[in] - location in ba1 to split ba2 begins there</param>
'''  <param name="pba2">[out] - with data starting at splitloc</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaSplit(
				ByVal ba1 as L_Bytea, 
				ByVal splitloc as UInteger, 
				<Out()>  ByRef pba2 as L_Bytea) as Integer


if IsNothing (ba1) then Throw New ArgumentNullException  ("ba1 cannot be Nothing")
	Dim pba2Ptr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.l_byteaSplit(ba1.Pointer,   splitloc, pba2Ptr)
	
	if pba2Ptr = IntPtr.Zero then pba2 = Nothing else pba2 = new L_Bytea(pba2Ptr)
	return _Result
End Function

' bytearray.c (540, 1)
' l_byteaFindEachSequence(ba, sequence, seqlen, pda) as Integer
' l_byteaFindEachSequence(L_BYTEA *, const l_uint8 *, size_t, L_DNA **) as l_ok
'''  <summary>
''' l_byteaFindEachSequence()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaFindEachSequence/*"/>
'''  <param name="ba">[in] - </param>
'''  <param name="sequence">[in] - subarray of bytes to find in data</param>
'''  <param name="seqlen">[in] - length of sequence, in bytes</param>
'''  <param name="pda">[out] - byte positions of each occurrence of %sequence</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaFindEachSequence(
				ByVal ba as L_Bytea, 
				ByVal sequence as Byte(), 
				ByVal seqlen as UInteger, 
				<Out()>  ByRef pda as L_Dna) as Integer


if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
		if IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")
	Dim pdaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.l_byteaFindEachSequence(ba.Pointer,   sequence,   seqlen, pdaPtr)
	
	if pdaPtr = IntPtr.Zero then pda = Nothing else pda = new L_Dna(pdaPtr)
	return _Result
End Function

' bytearray.c (578, 1)
' l_byteaWrite(fname, ba, startloc, endloc) as Integer
' l_byteaWrite(const char *, L_BYTEA *, size_t, size_t) as l_ok
'''  <summary>
''' l_byteaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaWrite/*"/>
'''  <param name="fname">[in] - output file</param>
'''  <param name="ba">[in] - </param>
'''  <param name="startloc">[in] - first byte to output</param>
'''  <param name="endloc">[in] - last byte to output use 0 to write to the end of the data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaWrite(
				ByVal fname as String, 
				ByVal ba as L_Bytea, 
				ByVal startloc as UInteger, 
				ByVal endloc as UInteger) as Integer


if IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
		if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as Integer = Natives.l_byteaWrite(  fname, ba.Pointer,   startloc,   endloc)
	
	return _Result
End Function

' bytearray.c (612, 1)
' l_byteaWriteStream(fp, ba, startloc, endloc) as Integer
' l_byteaWriteStream(FILE *, L_BYTEA *, size_t, size_t) as l_ok
'''  <summary>
''' l_byteaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaWriteStream/*"/>
'''  <param name="fp">[in] - file stream opened for binary write</param>
'''  <param name="ba">[in] - </param>
'''  <param name="startloc">[in] - first byte to output</param>
'''  <param name="endloc">[in] - last byte to output use 0 to write to the end of the data array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_byteaWriteStream(
				ByVal fp as FILE, 
				ByVal ba as L_Bytea, 
				ByVal startloc as UInteger, 
				ByVal endloc as UInteger) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as Integer = Natives.l_byteaWriteStream(fp.Pointer, ba.Pointer,   startloc,   endloc)
	
	return _Result
End Function

End Class


