Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' gifiostub.c (45, 7)
' pixReadStreamGif(fp) as Pix
' pixReadStreamGif(FILE *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamGif/*"/>
'''   <returns></returns>
Public Shared Function pixReadStreamGif(
				ByVal fp as FILE) as Pix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer

	Dim _Result as IntPtr = Natives.pixReadStreamGif(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' gifiostub.c (52, 7)
' pixReadMemGif(cdata, size) as Pix
' pixReadMemGif(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemGif/*"/>
'''   <returns></returns>
Public Shared Function pixReadMemGif(
				ByVal cdata as Byte(), 
				ByVal size as UInteger) as Pix


if IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadMemGif(  cdata,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' gifiostub.c (59, 6)
' pixWriteStreamGif(fp, pix) as Integer
' pixWriteStreamGif(FILE *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamGif/*"/>
'''   <returns></returns>
Public Shared Function pixWriteStreamGif(
				ByVal fp as FILE, 
				ByVal pix as Pix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer
	Dim pixPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as Integer = Natives.pixWriteStreamGif(fp.Pointer, pix.Pointer)
	
	return _Result
End Function

' gifiostub.c (66, 6)
' pixWriteMemGif(pdata, psize, pix) as Integer
' pixWriteMemGif(l_uint8 **, size_t *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemGif/*"/>
'''   <returns></returns>
Public Shared Function pixWriteMemGif(
				ByVal pdata as object, 
				ByVal psize as object, 
				ByVal pix as Pix) as Integer


if IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")
		if IsNothing (psize) then Throw New ArgumentNullException  ("psize cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pixPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as Integer = Natives.pixWriteMemGif(  pdata,   psize, pix.Pointer)
	
	return _Result
End Function

End Class


