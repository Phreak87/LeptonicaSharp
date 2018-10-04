Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pngio.c (185, 1)
' pixReadStreamPng(fp) as Pix
' pixReadStreamPng(FILE *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If called from pixReadStream(), the stream is positioned<para/>
''' at the beginning of the file.<para/>
''' (2) To do sequential reads of png format images from a stream,<para/>
''' use pixReadStreamPng()<para/>
''' (3) Any image with alpha is converted to RGBA (spp = 4, with<para/>
''' equal red, green and blue channels) on reading.<para/>
''' There are three important cases with alpha:<para/>
''' (a) grayscale-with-alpha (spp = 2), where bpp = 8, and each<para/>
''' pixel has an associated alpha (transparency) value<para/>
''' in the second component of the image data.<para/>
''' (b) spp = 1, d = 1 with colormap and alpha in the trans array.<para/>
''' Transparency is usually associated with the white background.<para/>
''' (c) spp = 1, d = 8 with colormap and alpha in the trans array.<para/>
''' Each color in the colormap has a separate transparency value.<para/>
''' (4) We use the high level png interface, where the transforms are set<para/>
''' up in advance and the header and image are read with a single<para/>
''' call.  The more complicated interface, where the header is<para/>
''' read first and the buffers for the raster image are user-<para/>
''' allocated before reading the image, works for single images,<para/>
''' but I could not get it to work properly for the successive<para/>
''' png reads that are required by pixaReadStream().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadStreamPng(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamPng( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pngio.c (517, 1)
' readHeaderPng(filename, pw, ph, pbps, pspp, piscmap) as Integer
' readHeaderPng(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, iscmap is returned as 1 else 0.<para/>
''' (2) For gray+alpha, although the png records bps = 16, we<para/>
''' consider this as two 8 bpp samples (gray and alpha).<para/>
''' When a gray+alpha is read, it is converted to 32 bpp RGBA.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderPng(
				 ByVal filename as String, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> ByRef piscmap as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderPng( filename, pw, ph, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\pngio.c (561, 1)
' freadHeaderPng(fp, pw, ph, pbps, pspp, piscmap) as Integer
' freadHeaderPng(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See readHeaderPng().  We only need the first 40 bytes in the file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderPng(
				 ByVal fp as FILE, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> ByRef piscmap as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderPng( fp.Pointer, pw, ph, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\pngio.c (618, 1)
' readHeaderMemPng(data, size, pw, ph, pbps, pspp, piscmap) as Integer
' readHeaderMemPng(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See readHeaderPng().<para/>
''' (2) png colortypes (see png.h: PNG_COLOR_TYPE_):<para/>
''' 0:  gray fully transparent (with tRNS) (1 spp)<para/>
''' 2:  RGB (3 spp)<para/>
''' 3:  colormap colormap+alpha (with tRNS) (1 spp)<para/>
''' 4:  gray + alpha (2 spp)<para/>
''' 6:  RGBA (4 spp)<para/>
''' Note:<para/>
''' 0 and 3 have the alpha information in a tRNS chunk<para/>
''' 4 and 6 have separate alpha samples with each pixel.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - </param>
'''  <param name="size">[in] - 40 bytes is sufficient</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''  <param name="piscmap">[out][optional] - input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemPng(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pbps as Integer, 
				<Out()> ByRef pspp as Integer, 
				<Out()> ByRef piscmap as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemPng( data, size, pw, ph, pbps, pspp, piscmap)

	Return _Result
End Function

' SRC\pngio.c (704, 1)
' fgetPngResolution(fp, pxres, pyres) as Integer
' fgetPngResolution(FILE *, l_int32 *, l_int32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetPngResolution(
				 ByVal fp as FILE, 
				 ByVal pxres as Object, 
				 ByVal pyres as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pxres) then Throw New ArgumentNullException  ("pxres cannot be Nothing")
	If IsNothing (pyres) then Throw New ArgumentNullException  ("pyres cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetPngResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\pngio.c (761, 1)
' isPngInterlaced(filename, pinterlaced) as Integer
' isPngInterlaced(const char *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pinterlaced">[out] - 1 if interlaced png 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function isPngInterlaced(
				 ByVal filename as String, 
				<Out()> ByRef pinterlaced as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.isPngInterlaced( filename, pinterlaced)

	Return _Result
End Function

' SRC\pngio.c (805, 1)
' fgetPngColormapInfo(fp, pcmap, ptransparency) as Integer
' fgetPngColormapInfo(FILE *, PIXCMAP **, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fgetPngColormapInfo(
				 ByVal fp as FILE, 
				 ByVal pcmap as PixColormap, 
				 ByVal ptransparency as Object) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pcmap) then Throw New ArgumentNullException  ("pcmap cannot be Nothing")
	If IsNothing (ptransparency) then Throw New ArgumentNullException  ("ptransparency cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
	Dim pcmapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pcmap) Then pcmapPTR = pcmap.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fgetPngColormapInfo( fp.Pointer, pcmapPTR, ptransparency)

	Return _Result
End Function

' SRC\pngio.c (906, 1)
' pixWritePng(filename, pix, gamma) as Integer
' pixWritePng(const char *, PIX *, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Special version for writing png with a specified gamma.<para/>
''' When using pixWrite(), no field is given for gamma.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pix">[in] - </param>
'''  <param name="gamma">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWritePng(
				 ByVal filename as String, 
				 ByVal pix as Pix, 
				 ByVal gamma as Single) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWritePng( filename, pix.Pointer, gamma)

	Return _Result
End Function

' SRC\pngio.c (1006, 1)
' pixWriteStreamPng(fp, pix, gamma) as Integer
' pixWriteStreamPng(FILE *, PIX *, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If called from pixWriteStream(), the stream is positioned<para/>
''' at the beginning of the file.<para/>
''' (2) To do sequential writes of png format images to a stream,<para/>
''' use pixWriteStreamPng() directly.<para/>
''' (3) gamma is an optional png chunk.  If no gamma value is to be<para/>
''' placed into the file, use gamma = 0.0.  Otherwise, if<para/>
''' gamma  is greater  0.0, its value is written into the header.<para/>
''' (4) The use of gamma in png is highly problematic.  For an illuminating<para/>
''' discussion, see:  http://hsivonen.iki.fi/png-gamma/<para/>
''' (5) What is the effect/meaning of gamma in the png file?  This<para/>
''' gamma, which we can call the 'source' gamma, is the<para/>
''' inverse of the gamma that was used in enhance.c to brighten<para/>
''' or darken images.  The 'source' gamma is supposed to indicate<para/>
''' the intensity mapping that was done at the time the<para/>
''' image was captured.  Display programs typically apply a<para/>
''' 'display' gamma of 2.2 to the output, which is intended<para/>
''' to linearize the intensity based on the response of<para/>
''' thermionic tubes (CRTs).  Flat panel LCDs have typically<para/>
''' been designed to give a similar response as CRTs (call it<para/>
''' "backward compatibility").  The 'display' gamma is<para/>
''' in some sense the inverse of the 'source' gamma.<para/>
''' jpeg encoders attached to scanners and cameras will lighten<para/>
''' the pixels, applying a gamma corresponding to approximately<para/>
''' a square-root relation of output vs input:<para/>
''' output = input^(gamma)<para/>
''' where gamma is often set near 0.4545  (1/gamma is 2.2).<para/>
''' This is stored in the image file.  Then if the display<para/>
''' program reads the gamma, it will apply a display gamma,<para/>
''' typically about 2.2 the product is 1.0, and the<para/>
''' display program produces a linear output.  This works because<para/>
''' the dark colors were appropriately boosted by the scanner,<para/>
''' as described by the 'source' gamma, so they should not<para/>
''' be further boosted by the display program.<para/>
''' (6) As an example, with xv and display, if no gamma is stored,<para/>
''' the program acts as if gamma were 0.4545, multiplies this by 2.2,<para/>
''' and does a linear rendering.  Taking this as a baseline<para/>
''' brightness, if the stored gamma is:<para/>
'''  is greater  0.4545, the image is rendered lighter than baseline<para/>
'''  is lower  0.4545, the image is rendered darker than baseline<para/>
''' In contrast, gqview seems to ignore the gamma chunk in png.<para/>
''' (7) The only valid pixel depths in leptonica are 1, 2, 4, 8, 16<para/>
''' and 32.  However, it is possible, and in some cases desirable,<para/>
''' to write out a png file using an rgb pix that has 24 bpp.<para/>
''' For example, the open source xpdf SplashBitmap class generates<para/>
''' 24 bpp rgb images.  Consequently, we enable writing 24 bpp pix.<para/>
''' To generate such a pix, you can make a 24 bpp pix without data<para/>
''' and assign the data array to the pix e.g.,<para/>
''' pix = pixCreateHeader(w, h, 24)<para/>
''' pixSetData(pix, rgbdata)<para/>
''' See pixConvert32To24() for an example, where we get rgbdata<para/>
''' from the 32 bpp pix.  Caution: do not call pixSetPadBits(),<para/>
''' because the alignment is wrong and you may erase part of the<para/>
''' last pixel on each line.<para/>
''' (8) If the pix has a colormap, it is written to file.  In most<para/>
''' situations, the alpha component is 255 for each colormap entry,<para/>
''' which is opaque and indicates that it should be ignored.<para/>
''' However, if any alpha component is not 255, it is assumed that<para/>
''' the alpha values are valid, and they are written to the png<para/>
''' file in a tRNS segment.  On readback, the tRNS segment is<para/>
''' identified, and the colormapped image with alpha is converted<para/>
''' to a 4 spp rgba image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="gamma">[in] - use 0.0 if gamma is not defined</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPng(
				 ByVal fp as FILE, 
				 ByVal pix as Pix, 
				 ByVal gamma as Single) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPng( fp.Pointer, pix.Pointer, gamma)

	Return _Result
End Function

' SRC\pngio.c (1250, 1)
' pixSetZlibCompression(pix, compval) as Integer
' pixSetZlibCompression(PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Valid zlib compression values are in the interval [0 ... 9],<para/>
''' where, as defined in zlib.h:<para/>
''' 0 Z_NO_COMPRESSION<para/>
''' 1 Z_BEST_SPEED  (poorest compression)<para/>
''' 9 Z_BEST_COMPRESSION<para/>
''' For the default value, use either of these:<para/>
''' 6 Z_DEFAULT_COMPRESSION<para/>
''' -1 (resolves to Z_DEFAULT_COMPRESSION)<para/>
''' (2) If you use the defined constants in zlib.h instead of the<para/>
''' compression integers given above, you must include zlib.h.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="compval">[in] - zlib compression value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetZlibCompression(
				 ByVal pix as Pix, 
				 ByVal compval as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetZlibCompression( pix.Pointer, compval)

	Return _Result
End Function

' SRC\pngio.c (1277, 1)
' l_pngSetReadStrip16To8(flag) as Object
' l_pngSetReadStrip16To8(l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <param name="flag">[in] - 1 for stripping 16 bpp to 8 bpp on reading 0 for leaving 16 bpp</param>
Public Shared Sub l_pngSetReadStrip16To8(
				 ByVal flag as Integer)



	LeptonicaSharp.Natives.l_pngSetReadStrip16To8( flag)

End Sub

' SRC\pngio.c (1520, 1)
' pixReadMemPng(filedata, filesize) as Pix
' pixReadMemPng(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixReastreamPng().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filedata">[in] - png compressed data in memory</param>
'''  <param name="filesize">[in] - number of bytes in data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemPng(
				 ByVal filedata as Byte(), 
				 ByVal filesize as UInteger) as Pix

	If IsNothing (filedata) then Throw New ArgumentNullException  ("filedata cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemPng( filedata, filesize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pngio.c (1858, 1)
' pixWriteMemPng(pfiledata, pfilesize, pix, gamma) as Integer
' pixWriteMemPng(l_uint8 **, size_t *, PIX *, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixWriteStreamPng()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pfiledata">[out] - png encoded data of pix</param>
'''  <param name="pfilesize">[out] - size of png encoded data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="gamma">[in] - use 0.0 if gamma is not defined</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteMemPng(
				<Out()> ByRef pfiledata as Byte(), 
				<Out()> ByRef pfilesize as UInteger, 
				 ByVal pix as Pix, 
				 ByVal gamma as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")

	Dim pfiledataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPng( pfiledataPTR, pfilesize, pix.Pointer, gamma)
	ReDim pfiledata(IIf(pfilesize > 0, pfilesize, 1) - 1) : If pfiledataPTR <> IntPtr.Zero Then Marshal.Copy(pfiledataPTR, pfiledata, 0, pfiledata.count)

	Return _Result
End Function

End Class
