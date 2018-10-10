Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\jpegio.c (214, 1)
' pixReadJpeg(filename, cmapflag, reduction, pnwarn, hint) as Pix
' pixReadJpeg(const char *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a special function for reading jpeg files.<para/>
''' (2) Use this if you want the jpeg library to create<para/>
''' an 8 bpp colormapped image.<para/>
''' (3) Images reduced by factors of 2, 4 or 8 can be returned<para/>
''' significantly faster than full resolution images.<para/>
''' (4) If the jpeg data is bad, the jpeg library will continue<para/>
''' silently, or return warnings, or attempt to exit.  Depending<para/>
''' on the severity of the data corruption, there are two possible<para/>
''' outcomes:<para/>
''' (a) a possibly damaged pix can be generated, along with zero<para/>
''' or more warnings, or<para/>
''' (b) the library will attempt to exit (caught by our error<para/>
''' handler) and no pix will be returned.<para/>
''' If a pix is generated with at least one warning of data<para/>
''' corruption, and if L_JPEG_FAIL_ON_BAD_DATA is included in %hint,<para/>
''' no pix will be returned.<para/>
''' (5) The possible hint values are given in the enum in imageio.h:<para/>
''' L_JPEG_READ_LUMINANCE<para/>
''' L_JPEG_FAIL_ON_BAD_DATA<para/>
''' Default (0) is to do neither.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="cmapflag">[in] - 0 for no colormap in returned pix 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
'''  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings about corrupted data</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadJpeg(
				 ByVal filename as String, 
				 ByVal cmapflag as Integer, 
				 ByVal reduction as Integer, 
				<Out()> ByRef pnwarn as Integer, 
				 ByVal hint as Integer) as Pix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor: 1, 2, 4 or 8")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadJpeg( filename, cmapflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (270, 1)
' pixReadStreamJpeg(fp, cmapflag, reduction, pnwarn, hint) as Pix
' pixReadStreamJpeg(FILE *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The jpeg comment, if it exists, is not stored in the pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="cmapflag">[in] - 0 for no colormap in returned pix 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
'''  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
'''   <returns>pix, or NULL on error Usage: see pixReadJpeg</returns>
Public Shared Function pixReadStreamJpeg(
				 ByVal fp as FILE, 
				 ByVal cmapflag as Integer, 
				 ByVal reduction as Integer, 
				<Out()> ByRef pnwarn as Integer, 
				 ByVal hint as Integer) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor: 1, 2, 4 or 8")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamJpeg( fp.Pointer, cmapflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (507, 1)
' readHeaderJpeg(filename, pw, ph, pspp, pycck, pcmyk) as Integer
' readHeaderJpeg(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderJpeg(
				 ByVal filename as String, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing, 
				<Out()> Optional ByRef pycck as Integer = Nothing, 
				<Out()> Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderJpeg( filename, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (549, 1)
' freadHeaderJpeg(fp, pw, ph, pspp, pycck, pcmyk) as Integer
' freadHeaderJpeg(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderJpeg(
				 ByVal fp as FILE, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing, 
				<Out()> Optional ByRef pycck as Integer = Nothing, 
				<Out()> Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderJpeg( fp.Pointer, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (618, 1)
' fgetJpegResolution(fp, pxres, pyres) as Integer
' fgetJpegResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJpegResolution(
				 ByVal fp as FILE, 
				 ByVal pxres as Object, 
				 ByVal pyres as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
	If IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJpegResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\jpegio.c (678, 1)
' fgetJpegComment(fp, pcomment) as Integer
' fgetJpegComment(FILE *, l_uint8 **) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJpegComment(
				 ByVal fp as FILE, 
				 ByVal pcomment as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pcomment) then Throw New ArgumentNullException  ("pcomment cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJpegComment( fp.Pointer, pcomment)

	Return _Result
End Function

' SRC\jpegio.c (732, 1)
' pixWriteJpeg(filename, pix, quality, progressive) as Integer
' pixWriteJpeg(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pix">[in] - any depth cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100 75 is default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteJpeg(
				 ByVal filename as String, 
				 ByVal pix as Pix, 
				 ByVal quality as Integer, 
				 ByVal progressive as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteJpeg( filename, pix.Pointer, quality, progressive)

	Return _Result
End Function

' SRC\jpegio.c (793, 1)
' pixWriteStreamJpeg(fp, pixs, quality, progressive) as Integer
' pixWriteStreamJpeg(FILE *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Progressive encoding gives better compression, at the<para/>
''' expense of slower encoding and decoding.<para/>
''' (2) Standard chroma subsampling is 2x2 on both the U and V<para/>
''' channels.  For highest quality, use no subsampling this<para/>
''' option is set by pixSetChromaSampling(pix, 0).<para/>
''' (3) The only valid pixel depths in leptonica are 1, 2, 4, 8, 16<para/>
''' and 32 bpp.  However, it is possible, and in some cases desirable,<para/>
''' to write out a jpeg file using an rgb pix that has 24 bpp.<para/>
''' This can be created by appending the raster data for a 24 bpp<para/>
''' image (with proper scanline padding) directly to a 24 bpp<para/>
''' pix that was created without a data array.<para/>
''' (4) There are two compression paths in this function:<para/>
''' Grayscale image, no colormap: compress as 8 bpp image.<para/>
''' rgb full color image: copy each line into the color<para/>
''' line buffer, and compress as three 8 bpp images.<para/>
''' (5) Under the covers, the jpeg library transforms rgb to a<para/>
''' luminance-chromaticity triple, each component of which is<para/>
''' also 8 bits, and compresses that.  It uses 2 Huffman tables,<para/>
''' a higher resolution one (with more quantization levels)<para/>
''' for luminosity and a lower resolution one for the chromas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixs">[in] - any depth cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100 75 is default value 0 is also default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamJpeg(
				 ByVal fp as FILE, 
				 ByVal pixs as Pix, 
				 ByVal quality as Integer, 
				 ByVal progressive as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamJpeg( fp.Pointer, pixs.Pointer, quality, progressive)

	Return _Result
End Function

' SRC\jpegio.c (991, 1)
' pixReadMemJpeg(data, size, cmflag, reduction, pnwarn, hint) as Pix
' pixReadMemJpeg(const l_uint8 *, size_t, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %size byte of %data must be a null character.<para/>
''' (2) The only hint flag so far is L_JPEG_READ_LUMINANCE,<para/>
''' given in the enum in imageio.h.<para/>
''' (3) See pixReadJpeg() for usage.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="cmflag">[in] - colormap flag 0 means return RGB image if color 1 means create a colormap and return an 8 bpp colormapped image if color</param>
'''  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemJpeg(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				 ByVal cmflag as Integer, 
				 ByVal reduction as Integer, 
				<Out()> ByRef pnwarn as Integer, 
				 ByVal hint as Integer) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor: 1, 2, 4 or 8")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemJpeg( data, size, cmflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (1038, 1)
' readHeaderMemJpeg(data, size, pw, ph, pspp, pycck, pcmyk) as Integer
' readHeaderMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemJpeg(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pspp as Integer = Nothing, 
				<Out()> Optional ByRef pycck as Integer = Nothing, 
				<Out()> Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemJpeg( data, size, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (1079, 1)
' readResolutionMemJpeg(data, size, pxres, pyres) as Integer
' readResolutionMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pxres">[out][optional] - </param>
'''  <param name="pyres">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readResolutionMemJpeg(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				<Out()> Optional ByRef pxres as Integer = Nothing, 
				<Out()> Optional ByRef pyres as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.readResolutionMemJpeg( data, size, pxres, pyres)

	Return _Result
End Function

' SRC\jpegio.c (1121, 1)
' pixWriteMemJpeg(pdata, psize, pix, quality, progressive) as Integer
' pixWriteMemJpeg(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixWriteStreamJpeg() for usage.  This version writes to<para/>
''' memory instead of to a file stream.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of jpeg compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - any depth cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100 75 is default value 0 is also default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemJpeg(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pix as Pix, 
				 ByVal quality as Integer, 
				 ByVal progressive as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemJpeg( pdataPTR, psize, pix.Pointer, quality, progressive)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\jpegio.c (1182, 1)
' pixSetChromaSampling(pix, sampling) as Integer
' pixSetChromaSampling(PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The default is for 2x2 chroma subsampling because the files are<para/>
''' considerably smaller and the appearance is typically satisfactory.<para/>
''' To get full resolution output in the chroma channels for<para/>
''' jpeg writing, call this with %sampling == 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="sampling">[in] - 1 for subsampling 0 for no subsampling</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetChromaSampling(
				 ByVal pix as Pix, 
				 ByVal sampling as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetChromaSampling( pix.Pointer, sampling)

	Return _Result
End Function

End Class
