Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' bbuffer.c (124, 1)
' bbufferCreate(indata, nalloc) as L_ByteBuffer
' bbufferCreate(const l_uint8 *, l_int32) as L_BBUFFER *
'''  <summary>
''' (1) If a buffer address is given, you should read all the data in.<para/>
'''
'''(2) Allocates a bbuffer with associated byte array of
'''the given size.  If a buffer address is given,
'''it then reads the number of bytes into the byte array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferCreate/*"/>
'''  <param name="indata">[in] - address in memory [optional]</param>
'''  <param name="nalloc">[in] - size of byte array to be alloc'd 0 for default</param>
'''   <returns>bbuffer, or NULL on error</returns>
Public Shared Function bbufferCreate(
				ByVal indata as Byte(), 
				ByVal nalloc as Integer) as L_ByteBuffer


	Dim _Result as IntPtr = Natives.bbufferCreate(  indata,   nalloc)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_ByteBuffer(_Result)
End Function

' bbuffer.c (167, 1)
' bbufferDestroy(pbb) as Object
' bbufferDestroy(L_BBUFFER **) as void
'''  <summary>
''' (1) Destroys the byte array in the bbuffer and then the bbuffer
'''then nulls the contents of the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferDestroy/*"/>
'''  <param name="pbb">[in,out] - buffer to be nulled</param>
Public Shared Sub bbufferDestroy(
				ByRef pbb as L_ByteBuffer)


	Dim pbbPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pbb) Then pbbPtr = pbb.Pointer

	Natives.bbufferDestroy( pbbPtr)
	
	if pbbPtr = IntPtr.Zero then pbb = Nothing else pbb = new L_ByteBuffer(pbbPtr)
End Sub

' bbuffer.c (203, 1)
' bbufferDestroyAndSaveData(pbb, pnbytes) as Byte()
' bbufferDestroyAndSaveData(L_BBUFFER **, size_t *) as l_uint8 *
'''  <summary>
''' (1) Copies data to newly allocated array then destroys the bbuffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferDestroyAndSaveData/*"/>
'''  <param name="pbb">[in,out] - buffer to be nulled</param>
'''  <param name="pnbytes">[out] - number of bytes saved in array</param>
'''   <returns>barray newly allocated array of data</returns>
Public Shared Function bbufferDestroyAndSaveData(
				ByRef pbb as L_ByteBuffer, 
				<Out()>  ByRef pnbytes as UInteger) as Byte()


	Dim pbbPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pbb) Then pbbPtr = pbb.Pointer

	Dim _Result as Byte() = Natives.bbufferDestroyAndSaveData( pbbPtr,   pnbytes)
	
	if pbbPtr = IntPtr.Zero then pbb = Nothing else pbb = new L_ByteBuffer(pbbPtr)
	return _Result
End Function

' bbuffer.c (262, 1)
' bbufferRead(bb, src, nbytes) as Integer
' bbufferRead(L_BBUFFER *, l_uint8 *, l_int32) as l_ok
'''  <summary>
''' (1) For a read after write, first remove the written
'''bytes by shifting the unwritten bytes in the array,
'''then check if there is enough room to add the new bytes.
'''If not, realloc with bbufferExpandArray(), resulting
'''in a second writing of the unwritten bytes.  While less
'''efficient, this is simpler than making a special case
'''of reallocNew().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferRead/*"/>
'''  <param name="bb">[in] - bbuffer</param>
'''  <param name="src">[in] - source memory buffer from which bytes are read</param>
'''  <param name="nbytes">[in] - bytes to be read</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bbufferRead(
				ByVal bb as L_ByteBuffer, 
				ByVal src as Byte(), 
				ByVal nbytes as Integer) as Integer


if IsNothing (bb) then Throw New ArgumentNullException  ("bb cannot be Nothing")
		if IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	Dim _Result as Integer = Natives.bbufferRead(bb.Pointer,   src,   nbytes)
	
	return _Result
End Function

' bbuffer.c (308, 1)
' bbufferReadStream(bb, fp, nbytes) as Integer
' bbufferReadStream(L_BBUFFER *, FILE *, l_int32) as l_ok
'''  <summary>
''' bbufferReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferReadStream/*"/>
'''  <param name="bb">[in] - bbuffer</param>
'''  <param name="fp">[in] - source stream from which bytes are read</param>
'''  <param name="nbytes">[in] - bytes to be read</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bbufferReadStream(
				ByVal bb as L_ByteBuffer, 
				ByVal fp as FILE, 
				ByVal nbytes as Integer) as Integer


if IsNothing (bb) then Throw New ArgumentNullException  ("bb cannot be Nothing")
		if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.bbufferReadStream(bb.Pointer, fp.Pointer,   nbytes)
	
	return _Result
End Function

' bbuffer.c (359, 1)
' bbufferExtendArray(bb, nbytes) as Integer
' bbufferExtendArray(L_BBUFFER *, l_int32) as l_ok
'''  <summary>
''' (1) reallocNew() copies all bbtonalloc bytes, even though
'''only bbton are data.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferExtendArray/*"/>
'''  <param name="bb">[in] - bbuffer</param>
'''  <param name="nbytes">[in] - number of bytes to extend array size</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bbufferExtendArray(
				ByVal bb as L_ByteBuffer, 
				ByVal nbytes as Integer) as Integer


if IsNothing (bb) then Throw New ArgumentNullException  ("bb cannot be Nothing")
	Dim _Result as Integer = Natives.bbufferExtendArray(bb.Pointer,   nbytes)
	
	return _Result
End Function

' bbuffer.c (390, 1)
' bbufferWrite(bb, dest, nbytes, pnout) as Integer
' bbufferWrite(L_BBUFFER *, l_uint8 *, size_t, size_t *) as l_ok
'''  <summary>
''' bbufferWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferWrite/*"/>
'''  <param name="bb">[in] - bbuffer</param>
'''  <param name="dest">[in] - dest memory buffer to which bytes are written</param>
'''  <param name="nbytes">[in] - bytes requested to be written</param>
'''  <param name="pnout">[out] - bytes actually written</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bbufferWrite(
				ByVal bb as L_ByteBuffer, 
				ByVal dest as Byte(), 
				ByVal nbytes as UInteger, 
				<Out()>  ByRef pnout as UInteger) as Integer


if IsNothing (bb) then Throw New ArgumentNullException  ("bb cannot be Nothing")
		if IsNothing (dest) then Throw New ArgumentNullException  ("dest cannot be Nothing")
	Dim _Result as Integer = Natives.bbufferWrite(bb.Pointer,   dest,   nbytes,   pnout)
	
	return _Result
End Function

' bbuffer.c (442, 1)
' bbufferWriteStream(bb, fp, nbytes, pnout) as Integer
' bbufferWriteStream(L_BBUFFER *, FILE *, size_t, size_t *) as l_ok
'''  <summary>
''' bbufferWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferWriteStream/*"/>
'''  <param name="bb">[in] - bbuffer</param>
'''  <param name="fp">[in] - dest stream to which bytes are written</param>
'''  <param name="nbytes">[in] - bytes requested to be written</param>
'''  <param name="pnout">[out] - bytes actually written</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bbufferWriteStream(
				ByVal bb as L_ByteBuffer, 
				ByVal fp as FILE, 
				ByVal nbytes as UInteger, 
				<Out()>  ByRef pnout as UInteger) as Integer


if IsNothing (bb) then Throw New ArgumentNullException  ("bb cannot be Nothing")
		if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.bbufferWriteStream(bb.Pointer, fp.Pointer,   nbytes,   pnout)
	
	return _Result
End Function

End Class


