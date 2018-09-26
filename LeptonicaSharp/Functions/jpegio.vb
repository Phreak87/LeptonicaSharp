Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\jpegio.c (214, 1)
' pixReadJpeg()
' pixReadJpeg(const char *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a special function for reading jpeg files.
''' (2) Use this if you want the jpeg library to create
''' an 8 bpp colormapped image.
''' (3) Images reduced by factors of 2, 4 or 8 can be returned
''' significantly faster than full resolution images.
''' (4) If the jpeg data is bad, the jpeg library will continue
''' silently, or return warnings, or attempt to exit.  Depending
''' on the severity of the data corruption, there are two possible
''' outcomes
''' (a) a possibly damaged pix can be generated, along with zero
''' or more warnings, or
''' (b) the library will attempt to exit (caught by our error
''' handler) and no pix will be returned.
''' If a pix is generated with at least one warning of data
''' corruption, and if L_JPEG_FAIL_ON_BAD_DATA is included in %hint,
''' no pix will be returned.
''' (5) The possible hint values are given in the enum in imageio.h
''' L_JPEG_READ_LUMINANCE
''' L_JPEG_FAIL_ON_BAD_DATA
''' Default (0) is to do neither.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="cmapflag">[in] - 0 for no colormap in returned pix; 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
'''  <param name="reduction">[in] - scaling factor 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings about corrupted data</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values; 0 for default</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadJpeg(
				ByVal filename as String, 
				ByVal cmapflag as Integer, 
				ByVal reduction as Integer, 
				ByVal hint as Integer, 
				Optional ByRef pnwarn as Integer = Nothing) as Pix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor 1, 2, 4 or 8") ' All Functions - specific Parameter - RangeCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadJpeg( filename, cmapflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (270, 1)
' pixReadStreamJpeg()
' pixReadStreamJpeg(FILE *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The jpeg comment, if it exists, is not stored in the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="cmapflag">[in] - 0 for no colormap in returned pix; 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
'''  <param name="reduction">[in] - scaling factor 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values; 0 for default</param>
'''   <returns>pix, or NULL on error Usage see pixReadJpeg</returns>
Public Shared Function pixReadStreamJpeg(
				ByVal fp as FILE, 
				ByVal cmapflag as Integer, 
				ByVal reduction as Integer, 
				ByVal hint as Integer, 
				Optional ByRef pnwarn as Integer = Nothing) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor 1, 2, 4 or 8") ' All Functions - specific Parameter - RangeCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamJpeg( fp.Pointer, cmapflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (507, 1)
' readHeaderJpeg()
' readHeaderJpeg(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space; 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderJpeg(
				ByVal filename as String, 
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing, 
				Optional ByRef pycck as Integer = Nothing, 
				Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderJpeg( filename, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (549, 1)
' freadHeaderJpeg()
' freadHeaderJpeg(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space; 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderJpeg(
				ByVal fp as FILE, 
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing, 
				Optional ByRef pycck as Integer = Nothing, 
				Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderJpeg( fp.Pointer, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (618, 1)
' 
' fgetJpegResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJpegResolution(
				ByRef fp as FILE, 
				ByRef pxres as Object, 
				ByRef pyres as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
	If IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJpegResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\jpegio.c (678, 1)
' 
' fgetJpegComment(FILE *, l_uint8 **) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetJpegComment(
				ByRef fp as FILE, 
				ByRef pcomment as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pcomment) then Throw New ArgumentNullException  ("pcomment cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetJpegComment( fp.Pointer, pcomment)

	Return _Result
End Function

' SRC\jpegio.c (732, 1)
' pixWriteJpeg()
' pixWriteJpeg(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pix">[in] - any depth; cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100; 75 is default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential; 1 for progressive</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteJpeg(
				ByVal filename as String, 
				ByVal pix as Pix, 
				ByVal quality as Integer, 
				ByVal progressive as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteJpeg( filename, pix.Pointer, quality, progressive)

	Return _Result
End Function

' SRC\jpegio.c (793, 1)
' pixWriteStreamJpeg()
' pixWriteStreamJpeg(FILE *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Progressive encoding gives better compression, at the
''' expense of slower encoding and decoding.
''' (2) Standard chroma subsampling is 2x2 on both the U and V
''' channels.  For highest quality, use no subsampling; this
''' option is set by pixSetChromaSampling(pix, 0).
''' (3) The only valid pixel depths in leptonica are 1, 2, 4, 8, 16
''' and 32 bpp.  However, it is possible, and in some cases desirable,
''' to write out a jpeg file using an rgb pix that has 24 bpp.
''' This can be created by appending the raster data for a 24 bpp
''' image (with proper scanline padding) directly to a 24 bpp
''' pix that was created without a data array.
''' (4) There are two compression paths in this function
''' Grayscale image, no colormap compress as 8 bpp image.
''' rgb full color image copy each line into the color
''' line buffer, and compress as three 8 bpp images.
''' (5) Under the covers, the jpeg library transforms rgb to a
''' luminance-chromaticity triple, each component of which is
''' also 8 bits, and compresses that.  It uses 2 Huffman tables,
''' a higher resolution one (with more quantization levels)
''' for luminosity and a lower resolution one for the chromas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixs">[in] - any depth; cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100; 75 is default value; 0 is also default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential; 1 for progressive</param>
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
' pixReadMemJpeg()
' pixReadMemJpeg(const l_uint8 *, size_t, l_int32, l_int32, l_int32 *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The %size byte of %data must be a null character.
''' (2) The only hint flag so far is L_JPEG_READ_LUMINANCE,
''' given in the enum in imageio.h.
''' (3) See pixReadJpeg() for usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const; jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="cmflag">[in] - colormap flag 0 means return RGB image if color; 1 means create a colormap and return an 8 bpp colormapped image if color</param>
'''  <param name="reduction">[in] - scaling factor 1, 2, 4 or 8</param>
'''  <param name="pnwarn">[out][optional] - number of warnings</param>
'''  <param name="hint">[in] - a bitwise OR of L_JPEG_ values; 0 for default</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemJpeg(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				ByVal cmflag as Integer, 
				ByVal reduction as Integer, 
				ByVal hint as Integer, 
				Optional ByRef pnwarn as Integer = Nothing) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("scaling factor 1, 2, 4 or 8") ' All Functions - specific Parameter - RangeCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemJpeg( data, size, cmflag, reduction, pnwarn, hint)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jpegio.c (1038, 1)
' readHeaderMemJpeg()
' readHeaderMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const; jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="pycck">[out][optional] - 1 if ycck color space; 0 otherwise</param>
'''  <param name="pcmyk">[out][optional] - 1 if cmyk color space; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemJpeg(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				Optional ByRef pw as Integer = Nothing, 
				Optional ByRef ph as Integer = Nothing, 
				Optional ByRef pspp as Integer = Nothing, 
				Optional ByRef pycck as Integer = Nothing, 
				Optional ByRef pcmyk as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemJpeg( data, size, pw, ph, pspp, pycck, pcmyk)

	Return _Result
End Function

' SRC\jpegio.c (1079, 1)
' readResolutionMemJpeg()
' readResolutionMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const; jpeg-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pxres">[out][optional] - </param>
'''  <param name="pyres">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readResolutionMemJpeg(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				Optional ByRef pxres as Integer = Nothing, 
				Optional ByRef pyres as Integer = Nothing) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readResolutionMemJpeg( data, size, pxres, pyres)

	Return _Result
End Function

' SRC\jpegio.c (1121, 1)
' pixWriteMemJpeg()
' pixWriteMemJpeg(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) See pixWriteStreamJpeg() for usage.  This version writes to
''' memory instead of to a file stream.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of jpeg compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - any depth; cmap is OK</param>
'''  <param name="quality">[in] - 1 - 100; 75 is default value; 0 is also default</param>
'''  <param name="progressive">[in] - 0 for baseline sequential; 1 for progressive</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemJpeg(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
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
' pixSetChromaSampling()
' pixSetChromaSampling(PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) The default is for 2x2 chroma subsampling because the files are
''' considerably smaller and the appearance is typically satisfactory.
''' To get full resolution output in the chroma channels for
''' jpeg writing, call this with %sampling == 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="sampling">[in] - 1 for subsampling; 0 for no subsampling</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetChromaSampling(
				ByVal pix as Pix, 
				ByVal sampling as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetChromaSampling( pix.Pointer, sampling)

	Return _Result
End Function

End Class
