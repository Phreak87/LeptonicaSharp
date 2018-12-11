Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' webpiostub.c (45, 7)
' pixReadStreamWebP(fp) as Pix
' pixReadStreamWebP(FILE *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamWebP/*"/>
'''   <returns></returns>
Public Shared Function pixReadStreamWebP(
				ByVal fp as FILE) as Pix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer

	Dim _Result as IntPtr = Natives.pixReadStreamWebP(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' webpiostub.c (52, 7)
' pixReadMemWebP(filedata, filesize) as Pix
' pixReadMemWebP(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemWebP/*"/>
'''   <returns></returns>
Public Shared Function pixReadMemWebP(
				ByVal filedata as Byte(), 
				ByVal filesize as UInteger) as Pix


if IsNothing (filedata) then Throw New ArgumentNullException  ("filedata cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadMemWebP(  filedata,   filesize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' webpiostub.c (59, 6)
' readHeaderWebP(filename, pw, ph, pspp) as Integer
' readHeaderWebP(const char *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderWebP/*"/>
'''   <returns></returns>
Public Shared Function readHeaderWebP(
				ByVal filename as String, 
				ByVal pw as object, 
				ByVal ph as object, 
				ByVal pspp as object) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
		if IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
		if IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as Integer = Natives.readHeaderWebP(  filename,   pw,   ph,   pspp)
	
	return _Result
End Function

' webpiostub.c (67, 6)
' readHeaderMemWebP(data, size, pw, ph, pspp) as Integer
' readHeaderMemWebP(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemWebP/*"/>
'''   <returns></returns>
Public Shared Function readHeaderMemWebP(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				ByVal pw as object, 
				ByVal ph as object, 
				ByVal pspp as object) as Integer


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
		if IsNothing (pw) then Throw New ArgumentNullException  ("pw cannot be Nothing")
		if IsNothing (ph) then Throw New ArgumentNullException  ("ph cannot be Nothing")
		if IsNothing (pspp) then Throw New ArgumentNullException  ("pspp cannot be Nothing")
	Dim _Result as Integer = Natives.readHeaderMemWebP(  data,   size,   pw,   ph,   pspp)
	
	return _Result
End Function

' webpiostub.c (75, 6)
' pixWriteWebP(filename, pixs, quality, lossless) as Integer
' pixWriteWebP(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteWebP/*"/>
'''   <returns></returns>
Public Shared Function pixWriteWebP(
				ByVal filename as String, 
				ByVal pixs as Pix, 
				ByVal quality as Integer, 
				ByVal lossless as Integer) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixsPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer

	Dim _Result as Integer = Natives.pixWriteWebP(  filename, pixs.Pointer,   quality,   lossless)
	
	return _Result
End Function

' webpiostub.c (83, 6)
' pixWriteStreamWebP(fp, pixs, quality, lossless) as Integer
' pixWriteStreamWebP(FILE *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamWebP/*"/>
'''   <returns></returns>
Public Shared Function pixWriteStreamWebP(
				ByVal fp as FILE, 
				ByVal pixs as Pix, 
				ByVal quality as Integer, 
				ByVal lossless as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer
	Dim pixsPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer

	Dim _Result as Integer = Natives.pixWriteStreamWebP(fp.Pointer, pixs.Pointer,   quality,   lossless)
	
	return _Result
End Function

' webpiostub.c (91, 6)
' pixWriteMemWebP(pencdata, pencsize, pixs, quality, lossless) as Integer
' pixWriteMemWebP(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemWebP/*"/>
'''   <returns></returns>
Public Shared Function pixWriteMemWebP(
				ByVal pencdata as object, 
				ByVal pencsize as object, 
				ByVal pixs as Pix, 
				ByVal quality as Integer, 
				ByVal lossless as Integer) as Integer


if IsNothing (pencdata) then Throw New ArgumentNullException  ("pencdata cannot be Nothing")
		if IsNothing (pencsize) then Throw New ArgumentNullException  ("pencsize cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixsPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer

	Dim _Result as Integer = Natives.pixWriteMemWebP(  pencdata,   pencsize, pixs.Pointer,   quality,   lossless)
	
	return _Result
End Function

End Class


