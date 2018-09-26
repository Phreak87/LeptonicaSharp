Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\writefile.c (182, 1)
' l_jpegSetQuality()
' l_jpegSetQuality(l_int32) as l_int32
'''  <summary>
''' Notes
''' (1) This variable is used in pixWriteStream() and pixWriteMem(),
''' to control the jpeg quality.  The default is 75.
''' (2) It returns the previous quality, so for example
''' l_int32  prev = l_jpegSetQuality(85);  //sets to 85
''' pixWriteStream(...);
''' l_jpegSetQuality(prev);   // resets to previous value
''' (3) On error, logs a message and does not change the variable.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="new_quality">[in] - 1 - 100; 75 is default; 0 defaults to 75</param>
'''   <returns>prev           previous quality</returns>
Public Shared Function l_jpegSetQuality(
				ByVal new_quality as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.l_jpegSetQuality( new_quality)

	Return _Result
End Function

' SRC\writefile.c (217, 1)
' setLeptDebugOK()
' setLeptDebugOK(l_int32) as void
'''  <summary>
''' Notes
''' (1) This sets or clears the global variable LeptDebugOK, to
''' control writing files in a temp directory with names that
''' are compiled in.
''' (2) The default in the library distribution is 0.  Call with
''' %allow = 1 for development and debugging.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="allow">[in] - TRUE (1) or FALSE (0)</param>
Public Shared Sub setLeptDebugOK(
				ByVal allow as Integer)



	LeptonicaSharp.Natives.setLeptDebugOK( allow)

End Sub

' SRC\writefile.c (242, 1)
' pixaWriteFiles()
' pixaWriteFiles(const char *, PIXA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Use %format = IFF_DEFAULT to decide the output format
''' individually for each pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rootname">[in] - </param>
'''  <param name="pixa">[in] - </param>
'''  <param name="format">[in] - defined in imageio.h; see notes for default</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixaWriteFiles(
				ByVal rootname as String, 
				ByVal pixa as Pixa, 
				ByVal format as Integer) as Integer

	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteFiles( rootname, pixa.Pointer, format)

	Return _Result
End Function

' SRC\writefile.c (295, 1)
' pixWriteDebug()
' pixWriteDebug(const char *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Debug version, intended for use in the library when writing
''' to files in a temp directory with names that are compiled in.
''' This is used instead of pixWrite() for all such library calls.
''' (2) The global variable LeptDebugOK defaults to 0, and can be set
''' or cleared by the function setLeptDebugOK().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''  <param name="pix">[in] - </param>
'''  <param name="format">[in] - defined in imageio.h</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteDebug(
				ByVal fname as String, 
				ByVal pix as Pix, 
				ByVal format as Integer) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteDebug( fname, pix.Pointer, format)

	Return _Result
End Function

' SRC\writefile.c (332, 1)
' pixWrite()
' pixWrite(const char *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Open for write using binary mode (with the "b" flag)
''' to avoid having Windows automatically translate the NL
''' into CRLF, which corrupts image files.  On non-windows
''' systems this flag should be ignored, per ISO C90.
''' Thanks to Dave Bryan for pointing this out.
''' (2) If the default image format IFF_DEFAULT is requested
''' use the input format if known; otherwise, use a lossless format.
''' (3) The default jpeg quality is 75.  For some other value,
''' Use l_jpegSetQuality().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''  <param name="pix">[in] - </param>
'''  <param name="format">[in] - defined in imageio.h</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWrite(
				ByVal fname as String, 
				ByVal pix as Pix, 
				ByVal format as Integer) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWrite( fname, pix.Pointer, format)

	Return _Result
End Function

' SRC\writefile.c (365, 1)
' pixWriteAutoFormat()
' pixWriteAutoFormat(const char *, PIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteAutoFormat(
				ByVal filename as String, 
				ByVal pix as Pix) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteAutoFormat( filename, pix.Pointer)

	Return _Result
End Function

' SRC\writefile.c (392, 1)
' pixWriteStream()
' pixWriteStream(FILE *, PIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="format">[in] - </param>
'''   <returns>0 if OK; 1 on error.</returns>
Public Shared Function pixWriteStream(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal format as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStream( fp.Pointer, pix.Pointer, format)

	Return _Result
End Function

' SRC\writefile.c (484, 1)
' pixWriteImpliedFormat()
' pixWriteImpliedFormat(const char *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This determines the output format from the filename extension.
''' (2) The last two args are ignored except for requests for jpeg files.
''' (3) The jpeg default quality is 75.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pix">[in] - </param>
'''  <param name="quality">[in] - iff JPEG; 1 - 100, 0 for default</param>
'''  <param name="progressive">[in] - iff JPEG; 0 for baseline seq., 1 for progressive</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteImpliedFormat(
				ByVal filename as String, 
				ByVal pix as Pix, 
				ByVal quality as Integer, 
				ByVal progressive as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteImpliedFormat( filename, pix.Pointer, quality, progressive)

	Return _Result
End Function

' SRC\writefile.c (549, 1)
' pixChooseOutputFormat()
' pixChooseOutputFormat(PIX *) as l_int32
'''  <summary>
''' Notes
''' (1) This should only be called if the requested format is IFF_DEFAULT.
''' (2) If the pix wasn't read from a file, its input format value
''' will be IFF_UNKNOWN, and in that case it is written out
''' in a compressed but lossless format.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>output format, or 0 on error</returns>
Public Shared Function pixChooseOutputFormat(
				ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixChooseOutputFormat( pix.Pointer)

	Return _Result
End Function

' SRC\writefile.c (584, 1)
' getImpliedFileFormat()
' getImpliedFileFormat(const char *) as l_int32
'''  <summary>
''' Notes
''' (1) This determines the output file format from the extension
''' of the input filename.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>output format, or IFF_UNKNOWN on error or invalid extension.</returns>
Public Shared Function getImpliedFileFormat(
				ByVal filename as String) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.getImpliedFileFormat( filename)

	Return _Result
End Function

' SRC\writefile.c (625, 1)
' pixGetAutoFormat()
' pixGetAutoFormat(PIX *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The output formats are restricted to tiff, jpeg and png
''' because these are the most commonly used image formats and
''' the ones that are typically installed with leptonica.
''' (2) This decides what compression to use based on the pix.
''' It chooses tiff-g4 if 1 bpp without a colormap, jpeg with
''' quality 75 if grayscale, rgb or rgba (where it loses
''' the alpha layer), and lossless png for all other situations.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetAutoFormat(
				ByVal pix as Pix, 
				ByRef pformat as Object) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (pformat) then Throw New ArgumentNullException  ("pformat cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetAutoFormat( pix.Pointer, pformat)

	Return _Result
End Function

' SRC\writefile.c (666, 1)
' getFormatExtension()
' getFormatExtension(l_int32) as const char *
'''  <summary>
''' Notes
''' (1) This string is NOT owned by the caller; it is just a pointer
''' to a global string.  Do not free it.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="format">[in] - integer</param>
'''   <returns>extension string, or NULL if format is out of range</returns>
Public Shared Function getFormatExtension(
				ByVal format as Integer) as String



	Dim _Result as String = LeptonicaSharp.Natives.getFormatExtension( format)

	Return _Result
End Function

' SRC\writefile.c (701, 1)
' pixWriteMem()
' pixWriteMem(l_uint8 **, size_t *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) On windows, this will only write tiff and PostScript to memory.
''' For other formats, it requires open_memstream(3).
''' (2) PostScript output is uncompressed, in hex ascii.
''' Most printers support level 2 compression (tiff_g4 for 1 bpp,
''' jpeg for 8 and 32 bpp).
''' (3) The default jpeg quality is 75.  For some other value,
''' Use l_jpegSetQuality().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of tiff compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="format">[in] - defined in imageio.h</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal format as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMem( pdataPTR, psize, pix.Pointer, format)
ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\writefile.c (801, 1)
' l_fileDisplay()
' l_fileDisplay(const char *, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This is a convenient wrapper for displaying image files.
''' (2) It does nothing unless LeptDebugOK == TRUE.
''' (2) Set %scale = 0 to disable display.
''' (3) This downscales 1 bpp to gray.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''  <param name="x">[in] - location of display frame on the screen</param>
'''  <param name="y">[in] - location of display frame on the screen</param>
'''  <param name="scale">[in] - scale factor (use 0 to skip display)</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function l_fileDisplay(
				ByVal fname as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal scale as Single) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_fileDisplay( fname, x, y, scale)

	Return _Result
End Function

' SRC\writefile.c (877, 1)
' pixDisplay()
' pixDisplay(PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is debugging code that displays an image on the screen.
''' It uses a static internal variable to number the output files
''' written by a single process.  Behavior with a shared library
''' may be unpredictable.
''' (2) It does nothing unless LeptDebugOK == TRUE.
''' (3) It uses these programs to display the image
''' On Unix xzgv, xli or xv
''' On Windows i_view
''' The display program must be on your $PATH variable.  It is
''' chosen by setting the global var_DISPLAY_PROG, using
''' l_chooseDisplayProg().  Default on Unix is xzgv.
''' (4) Images with dimensions larger than MAX_DISPLAY_WIDTH or
''' MAX_DISPLAY_HEIGHT are downscaled to fit those constraints.
''' This is particularly important for displaying 1 bpp images
''' with xv, because xv automatically downscales large images
''' by subsampling, which looks poor.  For 1 bpp, we use
''' scale-to-gray to get decent-looking anti-aliased images.
''' In all cases, we write a temporary file to /tmp/lept/disp,
''' that is read by the display program.
''' (5) The temporary file is written as png if, after initial
''' processing for special cases, any of these obtain
''' pix dimensions are smaller than some thresholds
''' pix depth is less than 8 bpp
''' pix is colormapped
''' (6) For spp == 4, we call pixDisplayLayersRGBA() to show 3
''' versions of the image the image with a fully opaque
''' alpha, the alpha, and the image as it would appear with
''' a white background.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x">[in] - location of display frame on the screen</param>
'''  <param name="y">[in] - location of display frame on the screen</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixDisplay(
				ByRef pixs as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDisplay( pixs.Pointer, x, y)

	Return _Result
End Function

' SRC\writefile.c (901, 1)
' pixDisplayWithTitle()
' pixDisplayWithTitle(PIX *, l_int32, l_int32, const char *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) See notes for pixDisplay().
''' (2) This displays the image if dispflag == 1; otherwise it punts.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x">[in] - location of display frame</param>
'''  <param name="y">[in] - location of display frame</param>
'''  <param name="title">[in][optional] - on frame; can be NULL;</param>
'''  <param name="dispflag">[in] - 1 to write, else disabled</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixDisplayWithTitle(
				ByRef pixs as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal dispflag as Integer, 
				Optional ByVal title as String = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDisplayWithTitle( pixs.Pointer, x, y, title, dispflag)

	Return _Result
End Function

' SRC\writefile.c (1077, 1)
' pixSaveTiled()
' pixSaveTiled(PIX *, PIXA *, l_float32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
'''  <param name="pixa">[in] - the pix are accumulated here</param>
'''  <param name="scalefactor">[in] - 0.0 to disable; otherwise this is a scale factor</param>
'''  <param name="newrow">[in] - 0 if placed on the same row as previous; 1 otherwise</param>
'''  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
'''  <param name="dp">[in] - depth of pixa; 8 or 32 bpp; only used on first call</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSaveTiled(
				ByVal pixs as Pix, 
				ByVal pixa as Pixa, 
				ByVal scalefactor as Single, 
				ByVal newrow as Integer, 
				ByVal space as Integer, 
				ByVal dp as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSaveTiled( pixs.Pointer, pixa.Pointer, scalefactor, newrow, space, dp)

	Return _Result
End Function

' SRC\writefile.c (1128, 1)
' pixSaveTiledOutline()
' pixSaveTiledOutline(PIX *, PIXA *, l_float32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Before calling this function for the first time, use
''' pixaCreate() to make the %pixa that will accumulate the pix.
''' This is passed in each time pixSaveTiled() is called.
''' (2) %scalefactor scales the input image.  After scaling and
''' possible depth conversion, the image is saved in the input
''' pixa, along with a box that specifies the location to
''' place it when tiled later.  Disable saving the pix by
''' setting %scalefactor == 0.0.
''' (3) %newrow and %space specify the location of the new pix
''' with respect to the last one(s) that were entered.
''' (4) %dp specifies the depth at which all pix are saved.  It can
''' be only 8 or 32 bpp.  Any colormap is removed.  This is only
''' used at the first invocation.
''' (5) This function uses two variables from call to call.
''' If they were static, the function would not be .so or thread
''' safe, and furthermore, there would be interference with two or
''' more pixa accumulating images at a time.  Consequently,
''' we use the first pix in the pixa to store and obtain both
''' the depth and the current position of the bottom (one pixel
''' below the lowest image raster line when laid out using
''' the boxa).  The bottom variable is stored in the input format
''' field, which is the only field available for storing an int.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
'''  <param name="pixa">[in] - the pix are accumulated here</param>
'''  <param name="scalefactor">[in] - 0.0 to disable; otherwise this is a scale factor</param>
'''  <param name="newrow">[in] - 0 if placed on the same row as previous; 1 otherwise</param>
'''  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
'''  <param name="linewidth">[in] - width of added outline for image; 0 for no outline</param>
'''  <param name="dp">[in] - depth of pixa; 8 or 32 bpp; only used on first call</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSaveTiledOutline(
				ByVal pixs as Pix, 
				ByVal pixa as Pixa, 
				ByVal scalefactor as Single, 
				ByVal newrow as Integer, 
				ByVal space as Integer, 
				ByVal linewidth as Integer, 
				ByVal dp as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSaveTiledOutline( pixs.Pointer, pixa.Pointer, scalefactor, newrow, space, linewidth, dp)

	Return _Result
End Function

' SRC\writefile.c (1258, 1)
' pixSaveTiledWithText()
' pixSaveTiledWithText(PIX *, PIXA *, l_int32, l_int32, l_int32, l_int32, L_BMF *, const char *, l_uint32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Before calling this function for the first time, use
''' pixaCreate() to make the %pixa that will accumulate the pix.
''' This is passed in each time pixSaveTiled() is called.
''' (2) %outwidth is the scaled width.  After scaling, the image is
''' saved in the input pixa, along with a box that specifies
''' the location to place it when tiled later.  Disable saving
''' the pix by setting %outwidth == 0.
''' (3) %newrow and %space specify the location of the new pix
''' with respect to the last one(s) that were entered.
''' (4) All pix are saved as 32 bpp RGB.
''' (5) If both %bmf and %textstr are defined, this generates a pix
''' with the additional text; otherwise, no text is written.
''' (6) The text is written before scaling, so it is properly
''' antialiased in the scaled pix.  However, if the pix on
''' different calls have different widths, the size of the
''' text will vary.
''' (7) See pixSaveTiledOutline() for other implementation details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
'''  <param name="pixa">[in] - the pix are accumulated here; as 32 bpp</param>
'''  <param name="outwidth">[in] - in pixels; use 0 to disable entirely</param>
'''  <param name="newrow">[in] - 1 to start a new row; 0 to go on same row as previous</param>
'''  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
'''  <param name="linewidth">[in] - width of added outline for image; 0 for no outline</param>
'''  <param name="bmf">[in][optional] - font struct</param>
'''  <param name="textstr">[in][optional] - text string to be added</param>
'''  <param name="val">[in] - color to set the text</param>
'''  <param name="location">[in] - L_ADD_ABOVE, L_ADD_AT_TOP, L_ADD_AT_BOT, L_ADD_BELOW</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSaveTiledWithText(
				ByVal pixs as Pix, 
				ByVal pixa as Pixa, 
				ByVal outwidth as Integer, 
				ByVal newrow as Integer, 
				ByVal space as Integer, 
				ByVal linewidth as Integer, 
				ByVal val as UInteger, 
				ByVal location as Enumerations.L_ADD, 
				Optional ByVal bmf as L_Bmf = Nothing, 
				Optional ByVal textstr as String = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim bmfPTR As IntPtr = IntPtr.Zero : If Not IsNothing(bmf) Then bmfPTR = bmf.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSaveTiledWithText( pixs.Pointer, pixa.Pointer, outwidth, newrow, space, linewidth, bmfPTR, textstr, val, location)

	Return _Result
End Function

' SRC\writefile.c (1300, 1)
' 
' l_chooseDisplayProg(l_int32) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_chooseDisplayProg(
				ByRef selection as Integer)



	LeptonicaSharp.Natives.l_chooseDisplayProg( selection)

End Sub

' SRC\writefile.c (1347, 1)
' pixDisplayWrite()
' pixDisplayWrite(PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (0) Deprecated.
''' (1) This is a simple interface for writing a set of files.
''' (2) This uses jpeg output for pix that are 32 bpp or 8 bpp
''' without a colormap; otherwise, it uses png.
''' (3) To erase any previously written files in the output directory
''' pixDisplayWrite(NULL, -1);
''' (4) If reduction GT 1 and depth == 1, this does a scale-to-gray
''' reduction.
''' (5) This function uses a static internal variable to number
''' output files written by a single process.  Behavior
''' with a shared library may be unpredictable.
''' (6) For 16 bpp, this displays the full dynamic range with log scale.
''' Alternative image transforms to generate 8 bpp pix are
''' pix8 = pixMaxDynamicRange(pixt, L_LINEAR_SCALE);
''' pix8 = pixConvert16To8(pixt, 0);  // low order byte
''' pix8 = pixConvert16To8(pixt, 1);  // high order byte
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="reduction">[in] - -1 to reset/erase; 0 to disable; otherwise this is a reduction factor</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixDisplayWrite(
				ByRef pixs as Pix, 
				ByVal reduction as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("-1 to reset/erase; 0 to disable; otherwise this is a  factor") ' All Functions - specific Parameter - RangeCheck

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDisplayWrite( pixs.Pointer, reduction)

	Return _Result
End Function

End Class
