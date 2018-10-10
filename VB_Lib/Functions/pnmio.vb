Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pnmio.c (145, 1)
' pixReadStreamPnm(fp) as Pix
' pixReadStreamPnm(FILE *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadStreamPnm(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamPnm( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pnmio.c (447, 1)
' readHeaderPnm(filename, pw, ph, pd, ptype, pbps, pspp) as Integer
' readHeaderPnm(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderPnm(
				 ByVal filename as String, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pd as Integer = Nothing, 
				<Out()> Optional ByRef ptype as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderPnm( filename, pw, ph, pd, ptype, pbps, pspp)

	Return _Result
End Function

' SRC\pnmio.c (490, 1)
' freadHeaderPnm(fp, pw, ph, pd, ptype, pbps, pspp) as Integer
' freadHeaderPnm(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderPnm(
				 ByVal fp as FILE, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pd as Integer = Nothing, 
				<Out()> Optional ByRef ptype as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderPnm( fp.Pointer, pw, ph, pd, ptype, pbps, pspp)

	Return _Result
End Function

' SRC\pnmio.c (667, 1)
' pixWriteStreamPnm(fp, pix) as Integer
' pixWriteStreamPnm(FILE *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes "raw" packed format only:<para/>
''' 1 bpp -- is greater  pbm (P4)<para/>
''' 2, 4, 8, 16 bpp, no colormap or grayscale colormap -- is greater  pgm (P5)<para/>
''' 2, 4, 8 bpp with color-valued colormap, or rgb -- is greater  rgb ppm (P6)<para/>
''' (2) 24 bpp rgb are not supported in leptonica, but this will<para/>
''' write them out as a packed array of bytes (3 to a pixel).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPnm(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPnm( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\pnmio.c (786, 1)
' pixWriteStreamAsciiPnm(fp, pix) as Integer
' pixWriteStreamAsciiPnm(FILE *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error Writes "ASCII" format only: 1 bpp -- is greater  pbm P1 2, 4, 8, 16 bpp, no colormap or grayscale colormap -- is greater  pgm P2 2, 4, 8 bpp with color-valued colormap, or rgb -- is greater  rgb ppm P3</returns>
Public Shared Function pixWriteStreamAsciiPnm(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamAsciiPnm( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\pnmio.c (908, 1)
' pixWriteStreamPam(fp, pix) as Integer
' pixWriteStreamPam(FILE *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes arbitrary PAM (P7) packed format.<para/>
''' (2) 24 bpp rgb are not supported in leptonica, but this will<para/>
''' write them out as a packed array of bytes (3 to a pixel).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPam(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPam( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\pnmio.c (1084, 1)
' pixReadMemPnm(data, size) as Pix
' pixReadMemPnm(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %size byte of %data must be a null character.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const pnm-encoded</param>
'''  <param name="size">[in] - of data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemPnm(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemPnm( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pnmio.c (1117, 1)
' readHeaderMemPnm(data, size, pw, ph, pd, ptype, pbps, pspp) as Integer
' readHeaderMemPnm(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const pnm-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemPnm(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pd as Integer = Nothing, 
				<Out()> Optional ByRef ptype as Integer = Nothing, 
				<Out()> Optional ByRef pbps as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemPnm( data, size, pw, ph, pd, ptype, pbps, pspp)

	Return _Result
End Function

' SRC\pnmio.c (1159, 1)
' pixWriteMemPnm(pdata, psize, pix) as Integer
' pixWriteMemPnm(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixWriteStreamPnm() for usage.  This version writes to<para/>
''' memory instead of to a file stream.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of PNM image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPnm(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPnm( pdataPTR, psize, pix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pnmio.c (1214, 1)
' pixWriteMemPam(pdata, psize, pix) as Integer
' pixWriteMemPam(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixWriteStreamPnm() for usage.  This version writes to<para/>
''' memory instead of to a file stream.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of PAM image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPam(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPam( pdataPTR, psize, pix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class
