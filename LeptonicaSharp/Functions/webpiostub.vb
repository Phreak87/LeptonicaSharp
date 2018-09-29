Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\webpiostub.c (45, 7)
' 
' pixReadStreamWebP(FILE *) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadStreamWebP(
				ByRef fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamWebP( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\webpiostub.c (52, 7)
' 
' pixReadMemWebP(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadMemWebP(
				ByRef filedata as Byte(), 
				ByRef filesize as UInteger) as Pix

	If IsNothing (filedata) then Throw New ArgumentNullException  ("filedata cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemWebP( filedata, filesize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\webpiostub.c (59, 6)
' 
' readHeaderWebP(const char *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function readHeaderWebP(
				ByRef filename as String, 
				ByRef pw as Object, 
				ByRef ph as Object, 
				ByRef pspp as Object) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
	If IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
	If IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderWebP( filename, pw, ph, pspp)

	Return _Result
End Function

' SRC\webpiostub.c (67, 6)
' 
' readHeaderMemWebP(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function readHeaderMemWebP(
				ByRef data as Byte(), 
				ByRef size as UInteger, 
				ByRef pw as Object, 
				ByRef ph as Object, 
				ByRef pspp as Object) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
	If IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
	If IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemWebP( data, size, pw, ph, pspp)

	Return _Result
End Function

' SRC\webpiostub.c (75, 6)
' 
' pixWriteWebP(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteWebP(
				ByRef filename as String, 
				ByRef pixs as Pix, 
				ByRef quality as Integer, 
				ByRef lossless as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteWebP( filename, pixs.Pointer, quality, lossless)

	Return _Result
End Function

' SRC\webpiostub.c (83, 6)
' 
' pixWriteStreamWebP(FILE *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteStreamWebP(
				ByRef fp as FILE, 
				ByRef pixs as Pix, 
				ByRef quality as Integer, 
				ByRef lossless as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamWebP( fp.Pointer, pixs.Pointer, quality, lossless)

	Return _Result
End Function

' SRC\webpiostub.c (91, 6)
' 
' pixWriteMemWebP(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteMemWebP(
				ByRef pencdata as Object, 
				ByRef pencsize as Object, 
				ByRef pixs as Pix, 
				ByRef quality as Integer, 
				ByRef lossless as Integer) as Integer

	If IsNothing (pencdata) then Throw New ArgumentNullException  ("pencdata cannot be Nothing")
	If IsNothing (pencsize) then Throw New ArgumentNullException  ("pencsize cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemWebP( pencdata, pencsize, pixs.Pointer, quality, lossless)

	Return _Result
End Function

End Class
