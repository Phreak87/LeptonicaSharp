Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\spixio.c (88, 1)
' pixReadStreamSpix()
' pixReadStreamSpix(FILE *) as PIX *
'''  <summary>
''' Notes
''' (1) If called from pixReadStream(), the stream is positioned
''' at the beginning of the file.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' readHeaderSpix()
' readHeaderSpix(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) If there is a colormap, iscmap is returned as 1; else 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderSpix(
				ByVal filename as String, 
				ByRef pwidth as Integer, 
				ByRef pheight as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef piscmap as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderSpix( filename, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (167, 1)
' freadHeaderSpix()
' freadHeaderSpix(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) If there is a colormap, iscmap is returned as 1; else 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderSpix(
				ByVal fp as FILE, 
				ByRef pwidth as Integer, 
				ByRef pheight as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef piscmap as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderSpix( fp.Pointer, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (211, 1)
' sreadHeaderSpix()
' sreadHeaderSpix(const l_uint32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) If there is a colormap, iscmap is returned as 1; else 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - </param>
'''  <param name="pwidth">[out] - width</param>
'''  <param name="pheight">[out] - height</param>
'''  <param name="pbps">[out] - bits/sample</param>
'''  <param name="pspp">[out] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sreadHeaderSpix(
				ByVal data as Byte(), 
				ByRef pwidth as Integer, 
				ByRef pheight as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef piscmap as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.sreadHeaderSpix( dataPTR, pwidth, pheight, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\spixio.c (265, 1)
' pixWriteStreamSpix()
' pixWriteStreamSpix(FILE *, PIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteStreamSpix(
				ByVal fp as FILE, 
				ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamSpix( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\spixio.c (297, 1)
' pixReadMemSpix()
' pixReadMemSpix(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const; uncompressed</param>
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
' pixWriteMemSpix()
' pixWriteMemSpix(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized, uncompressed pix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - all depths; colormap OK</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemSpix(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemSpix( pdataPTR, psize, pix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\spixio.c (346, 1)
' pixSerializeToMemory()
' pixSerializeToMemory(PIX *, l_uint32 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) This does a fast serialization of the principal elements
''' of the pix, as follows
''' "spix" (4 bytes) -- ID for file type
''' w   (4 bytes)
''' h   (4 bytes)
''' d   (4 bytes)
''' wpl (4 bytes)
''' ncolors   (4 bytes) -- in colormap; 0 if there is no colormap
''' cdata  (4  ncolors)  -- size of serialized colormap array
''' rdatasize (4 bytes) -- size of serialized raster data
''' = 4  wpl  h
''' rdata  (rdatasize)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths, colormap OK</param>
'''  <param name="pdata">[out] - serialized data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in data string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSerializeToMemory(
				ByVal pixs as Pix, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSerializeToMemory( pixs.Pointer, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\spixio.c (424, 1)
' pixDeserializeFromMemory()
' pixDeserializeFromMemory(const l_uint32 *, size_t) as PIX *
'''  <summary>
''' Notes
''' (1) See pixSerializeToMemory() for the binary format.
''' (2) Note the image size limits.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
