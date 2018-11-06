Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\gifiostub.c (45, 7)
' pixReadStreamGif(fp) as Pix
' pixReadStreamGif(FILE *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixReadStreamGif/*"/>
'''   <returns></returns>
Public Shared Function pixReadStreamGif(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamGif( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\gifiostub.c (52, 7)
' pixReadMemGif(cdata, size) as Pix
' pixReadMemGif(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixReadMemGif/*"/>
'''   <returns></returns>
Public Shared Function pixReadMemGif(
				 ByVal cdata as Byte(), 
				 ByVal size as UInteger) as Pix

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemGif( cdata, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\gifiostub.c (59, 6)
' pixWriteStreamGif(fp, pix) as Integer
' pixWriteStreamGif(FILE *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixWriteStreamGif/*"/>
'''   <returns></returns>
Public Shared Function pixWriteStreamGif(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamGif( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\gifiostub.c (66, 6)
' pixWriteMemGif(pdata, psize, pix) as Integer
' pixWriteMemGif(l_uint8 **, size_t *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixWriteMemGif/*"/>
'''   <returns></returns>
Public Shared Function pixWriteMemGif(
				 ByVal pdata as Object, 
				 ByVal psize as Object, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")
	If IsNothing (psize) then Throw New ArgumentNullException  ("psize cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemGif( pdata, psize, pix.Pointer)

	Return _Result
End Function

End Class
