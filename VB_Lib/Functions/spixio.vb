Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\spixio.c (88, 1)
' pixReadStreamSpix(fp) as Pix
' pixReadStreamSpix(FILE *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If called from pixReadStream(), the stream is positioned<para/>
''' at the beginning of the file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixReadStreamSpix/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pix, or NULL on error.</returns>
Public Shared Function pixReadStreamSpix(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamSpix( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\spixio.c (126, 1)
' readHeaderSpix(filename, pwidth, pheight, pbps, pspp, piscmap) as Integer
' readHeaderSpix(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, iscmap is returned as 1 else 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/readHeaderSpix/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderSpix(
				 ByVal filename as String, 
				<Out()> ByRef pwidth as Integer, 
				<Out()> ByRef pheight as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> Optional ByRef piscmap as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderSpix( filename, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (167, 1)
' freadHeaderSpix(fp, pwidth, pheight, pbps, pspp, piscmap) as Integer
' freadHeaderSpix(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, iscmap is returned as 1 else 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/freadHeaderSpix/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderSpix(
				 ByVal fp as FILE, 
				<Out()> ByRef pwidth as Integer, 
				<Out()> ByRef pheight as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> Optional ByRef piscmap as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderSpix( fp.Pointer, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (211, 1)
' sreadHeaderSpix(data, pwidth, pheight, pbps, pspp, piscmap) as Integer
' sreadHeaderSpix(const l_uint32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, iscmap is returned as 1 else 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/sreadHeaderSpix/*"/>
'''  <param name="data">[in] - </param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sreadHeaderSpix(
				 ByVal data as Byte(), 
				<Out()> ByRef pwidth as Integer, 
				<Out()> ByRef pheight as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> Optional ByRef piscmap as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.sreadHeaderSpix( dataPTR, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (265, 1)
' pixWriteStreamSpix(fp, pix) as Integer
' pixWriteStreamSpix(FILE *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixWriteStreamSpix/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamSpix(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamSpix( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\spixio.c (297, 1)
' pixReadMemSpix(data, size) as Pix
' pixReadMemSpix(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixReadMemSpix/*"/>
'''  <param name="data">[in] - const uncompressed</param>
'''  <param name="size">[in] - bytes of data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemSpix(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemSpix( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\spixio.c (313, 1)
' pixWriteMemSpix(pdata, psize, pix) as Integer
' pixWriteMemSpix(l_uint8 **, size_t *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixWriteMemSpix/*"/>
'''  <param name="pdata">[out] - data of serialized, uncompressed pix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - all depths colormap OK</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemSpix(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemSpix( pdataPTR, psize, pix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\spixio.c (346, 1)
' pixSerializeToMemory(pixs, pdata, pnbytes) as Integer
' pixSerializeToMemory(PIX *, l_uint32 **, size_t *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does a fast serialization of the principal elements<para/>
''' of the pix, as follows:<para/>
''' "spix"  (4 bytes) -- ID for file type<para/>
''' w (4 bytes)<para/>
''' h (4 bytes)<para/>
''' d (4 bytes)<para/>
''' wpl (4 bytes)<para/>
''' ncolors (4 bytes) -- in colormap 0 if there is no colormap<para/>
''' cdata (4  ncolors)  -- size of serialized colormap array<para/>
''' rdatasize (4 bytes) -- size of serialized raster data<para/>
''' = 4  wpl  h<para/>
''' rdata (rdatasize)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSerializeToMemory/*"/>
'''  <param name="pixs">[in] - all depths, colormap OK</param>
'''  <param name="pdata">[out] - serialized data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in data string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSerializeToMemory(
				 ByVal pixs as Pix, 
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSerializeToMemory( pixs.Pointer, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\spixio.c (424, 1)
' pixDeserializeFromMemory(data, nbytes) as Pix
' pixDeserializeFromMemory(const l_uint32 *, size_t) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixSerializeToMemory() for the binary format.<para/>
''' (2) Note the image size limits.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDeserializeFromMemory/*"/>
'''  <param name="data">[in] - serialized data in memory</param>
'''  <param name="nbytes">[in] - number of bytes in data string</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixDeserializeFromMemory(
				 ByVal data as Byte(), 
				 ByVal nbytes as UInteger) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeserializeFromMemory( dataPTR, nbytes)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
