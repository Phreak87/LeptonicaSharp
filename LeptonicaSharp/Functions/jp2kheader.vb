Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\jp2kheader.c (75, 1)
' readHeaderJp2k()
' readHeaderJp2k(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderJp2k(
				ByVal filename as String, 
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pbps as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderJp2k( filename, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (112, 1)
' freadHeaderJp2k()
' freadHeaderJp2k(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderJp2k(
				ByVal fp as FILE, 
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pbps as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderJp2k( fp.Pointer, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (167, 1)
' readHeaderMemJp2k()
' readHeaderMemJp2k(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The ISO/IEC reference for jpeg2000 is
''' http//www.jpeg.org/public/15444-1annexi.pdf
''' and the file format syntax begins at page 127.
''' (2) The Image Header Box begins with 'ihdr' = 0x69686472 in
''' big-endian order.  This typically, but not always, starts
''' byte 44, with the big-endian data fields beginning at byte 48
''' h 4 bytes
''' w 4 bytes
''' spp  2 bytes
''' bps  1 byte   (contains bps - 1)
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pbps as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemJp2k( data, size, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (240, 1)
' 
' fgetJp2kResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJp2kResolution(
				ByRef fp as FILE, 
				ByRef pxres as Object, 
				ByRef pyres as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
	If IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJp2kResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

End Class
