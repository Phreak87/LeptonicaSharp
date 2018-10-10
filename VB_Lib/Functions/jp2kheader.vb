Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\jp2kheader.c (75, 1)
' readHeaderJp2k(filename, pw, ph, pbps, pspp) as Integer
' readHeaderJp2k(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
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
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderJp2k( filename, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (112, 1)
' freadHeaderJp2k(fp, pw, ph, pbps, pspp) as Integer
' freadHeaderJp2k(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
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
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderJp2k( fp.Pointer, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (167, 1)
' readHeaderMemJp2k(data, size, pw, ph, pbps, pspp) as Integer
' readHeaderMemJp2k(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The ISO/IEC reference for jpeg2000 is<para/>
''' http://www.jpeg.org/public/15444-1annexi.pdf<para/>
''' and the file format syntax begins at page 127.<para/>
''' (2) The Image Header Box begins with 'ihdr' = 0x69686472 in<para/>
''' big-endian order.  This typically, but not always, starts<para/>
''' byte 44, with the big-endian data fields beginning at byte 48:<para/>
''' h:  4 bytes<para/>
''' w:  4 bytes<para/>
''' spp:  2 bytes<para/>
''' bps:  1 byte (contains bps - 1)<para/>
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
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemJp2k( data, size, pw, ph, pbps, pspp)

	Return _Result
End Function

' SRC\jp2kheader.c (240, 1)
' fgetJp2kResolution(fp, pxres, pyres) as Integer
' fgetJp2kResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJp2kResolution(
				 ByVal fp as FILE, 
				 ByVal pxres as Object, 
				 ByVal pyres as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
	If IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJp2kResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

End Class
