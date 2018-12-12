Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' jp2kheader.c (75, 1)
' readHeaderJp2k(filename, pw, ph, pbps, pspp) as Integer
' readHeaderJp2k(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' readHeaderJp2k()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderJp2k/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderJp2k(
				ByVal filename as String, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as Integer = Natives.readHeaderJp2k(  filename,   pw,   ph,   pbps,   pspp)
	
	return _Result
End Function

' jp2kheader.c (112, 1)
' freadHeaderJp2k(fp, pw, ph, pbps, pspp) as Integer
' freadHeaderJp2k(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' freadHeaderJp2k()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderJp2k/*"/>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderJp2k(
				ByVal fp as FILE, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.freadHeaderJp2k(fp.Pointer,   pw,   ph,   pbps,   pspp)
	
	return _Result
End Function

' jp2kheader.c (167, 1)
' readHeaderMemJp2k(data, size, pw, ph, pbps, pspp) as Integer
' readHeaderMemJp2k(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The ISO/IEC reference for jpeg2000 is
'''http://www.jpeg.org/public/15444-1annexi.pdf
'''and the file format syntax begins at page 127.<para/>
'''
'''(2) The Image Header Box begins with 'ihdr' = 0x69686472 in
'''big-endian order.  This typically, but not always, starts
'''byte 44, with the big-endian data fields beginning at byte 48:
'''h:  4 bytes
'''w:  4 bytes
'''spp:  2 bytes
'''bps:  1 byte (contains bps - 1)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemJp2k/*"/>
'''  <param name="data">[in] - </param>
'''  <param name="size">[in] - at least 80</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemJp2k(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as Integer = Natives.readHeaderMemJp2k(  data,   size,   pw,   ph,   pbps,   pspp)
	
	return _Result
End Function

' jp2kheader.c (240, 1)
' fgetJp2kResolution(fp, pxres, pyres) as Integer
' fgetJp2kResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetJp2kResolution/*"/>
'''   <returns></returns>
Public Shared Function fgetJp2kResolution(
				ByVal fp as FILE, 
				ByVal pxres as object, 
				ByVal pyres as object) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
		if IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer

	Dim _Result as Integer = Natives.fgetJp2kResolution(fp.Pointer,   pxres,   pyres)
	
	return _Result
End Function

End Class


