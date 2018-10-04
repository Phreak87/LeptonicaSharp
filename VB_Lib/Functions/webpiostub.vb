Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\webpiostub.c (45, 7)
' pixReadStreamWebP(fp) as Pix
' pixReadStreamWebP(FILE *) as PIX *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadStreamWebP(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamWebP( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\webpiostub.c (52, 7)
' pixReadMemWebP(filedata, filesize) as Pix
' pixReadMemWebP(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadMemWebP(
				 ByVal filedata as Byte(), 
				 ByVal filesize as UInteger) as Pix

	If IsNothing (filedata) then Throw New ArgumentNullException  ("filedata cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemWebP( filedata, filesize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\webpiostub.c (59, 6)
' readHeaderWebP(filename, pw, ph, pspp) as Integer
' readHeaderWebP(const char *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function readHeaderWebP(
				 ByVal filename as String, 
				 ByVal pw as Object, 
				 ByVal ph as Object, 
				 ByVal pspp as Object) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
	If IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
	If IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderWebP( filename, pw, ph, pspp)

	Return _Result
End Function

' SRC\webpiostub.c (67, 6)
' readHeaderMemWebP(data, size, pw, ph, pspp) as Integer
' readHeaderMemWebP(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function readHeaderMemWebP(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				 ByVal pw as Object, 
				 ByVal ph as Object, 
				 ByVal pspp as Object) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
	If IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
	If IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemWebP( data, size, pw, ph, pspp)

	Return _Result
End Function

' SRC\webpiostub.c (75, 6)
' pixWriteWebP(filename, pixs, quality, lossless) as Integer
' pixWriteWebP(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteWebP(
				 ByVal filename as String, 
				 ByVal pixs as Pix, 
				 ByVal quality as Integer, 
				 ByVal lossless as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteWebP( filename, pixs.Pointer, quality, lossless)

	Return _Result
End Function

' SRC\webpiostub.c (83, 6)
' pixWriteStreamWebP(fp, pixs, quality, lossless) as Integer
' pixWriteStreamWebP(FILE *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteStreamWebP(
				 ByVal fp as FILE, 
				 ByVal pixs as Pix, 
				 ByVal quality as Integer, 
				 ByVal lossless as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamWebP( fp.Pointer, pixs.Pointer, quality, lossless)

	Return _Result
End Function

' SRC\webpiostub.c (91, 6)
' pixWriteMemWebP(pencdata, pencsize, pixs, quality, lossless) as Integer
' pixWriteMemWebP(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteMemWebP(
				 ByVal pencdata as Object, 
				 ByVal pencsize as Object, 
				 ByVal pixs as Pix, 
				 ByVal quality as Integer, 
				 ByVal lossless as Integer) as Integer

	If IsNothing (pencdata) then Throw New ArgumentNullException  ("pencdata cannot be Nothing")
	If IsNothing (pencsize) then Throw New ArgumentNullException  ("pencsize cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemWebP( pencdata, pencsize, pixs.Pointer, quality, lossless)

	Return _Result
End Function

End Class
