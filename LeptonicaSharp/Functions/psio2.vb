Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\psio2.c (152, 1)
' pixWritePSEmbed()
' pixWritePSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a simple wrapper function that generates an
''' uncompressed PS file, with a bounding box.
''' (2) The bounding box is required when a program such as TeX
''' (through epsf) places and rescales the image.
''' (3) The bounding box is sized for fitting the image to an
''' 8.5 x 11.0 inch page.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input file, all depths, colormap OK</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWritePSEmbed(
				ByVal filein as String, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWritePSEmbed( filein, fileout)

	Return _Result
End Function

' SRC\psio2.c (205, 1)
' pixWriteStreamPS()
' pixWriteStreamPS(FILE *, PIX *, BOX *, l_int32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This writes image in PS format, optionally scaled,
''' adjusted for the printer resolution, and with
''' a bounding box.
''' (2) For details on use of parameters, see pixWriteStringPS().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="box">[in][optional] - </param>
'''  <param name="res">[in] - can use 0 for default of 300 ppi</param>
'''  <param name="scale">[in] - to prevent scaling, use either 1.0 or 0.0</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixWriteStreamPS(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPS( fp.Pointer, pix.Pointer, boxPTR, res, scale)

	Return _Result
End Function

' SRC\psio2.c (303, 1)
' pixWriteStringPS()
' pixWriteStringPS(PIX *, BOX *, l_int32, l_float32) as char *
'''  <summary>
''' a) If %box == NULL, image is placed, optionally scaled,
''' in a standard b.b. at the center of the page.
''' This is to be used when another program like
''' TeX through epsf places the image.
''' b) If %box != NULL, image is placed without a
''' b.b. at the specified page location and with
''' optional scaling.  This is to be used when
''' you want to specify exactly where and optionally
''' how big you want the image to be.
''' Note that all coordinates are in PS convention,
''' with 0,0 at LL corner of the page
''' x,y location of LL corner of image, in mils.
''' w,h scaled size, in mils.  Use 0 to
''' scale with "scale" and "res" input.
''' %scale If no scaling is desired, use either 1.0 or 0.0.
''' Scaling just resets the resolution parameter; the actual
''' scaling is done in the interpreter at rendering time.
''' This is important  it allows you to scale the image up
''' without increasing the file size.
''' Notes
''' (1) OK, this seems a bit complicated, because there are various
''' ways to scale and not to scale.  Here's a summary
''' (2) If you don't want any scaling at all
''' if you are using a box
''' set w = 0, h = 0, and use scale = 1.0; it will print
''' each pixel unscaled at printer resolution
''' if you are not using a box
''' set scale = 1.0; it will print at printer resolution
''' (3) If you want the image to be a certain size in inches
''' you must use a box and set the box (w,h) in mils
''' (4) If you want the image to be scaled by a scale factor != 1.0
''' if you are using a box
''' set w = 0, h = 0, and use the desired scale factor;
''' the higher the printer resolution, the smaller the
''' image will actually appear.
''' if you are not using a box
''' set the desired scale factor; the higher the printer
''' resolution, the smaller the image will actually appear.
''' (5) Another complication is the proliferation of distance units
''' The interface distances are in milli-inches.
''' Three different units are used internally
''' ~ pixels  (units of 1/res inch)
''' ~ printer pts (units of 1/72 inch)
''' ~ inches
''' Here is a quiz on volume units from a reviewer
''' How many UK milli-cups in a US kilo-teaspoon?
''' (Hint 1.0 US cup = 0.75 UK cup + 0.2 US gill;
''' 1.0 US gill = 24.0 US teaspoons)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths, colormap OK</param>
'''  <param name="box">[in] - bounding box; can be NULL</param>
'''  <param name="res">[in] - resolution, in printer ppi.  Use 0 for default 300 ppi.</param>
'''  <param name="scale">[in] - scale factor.  If no scaling is desired, use either 1.0 or 0.0.   Scaling just resets the resolution parameter; the actual scaling is done in the interpreter at rendering time.  This is important it allows you to scale the image up without increasing the file size.</param>
'''   <returns>ps string if OK, or NULL on error</returns>
Public Shared Function pixWriteStringPS(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal res as Integer, 
				ByVal scale as Single) as String

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.pixWriteStringPS( pixs.Pointer, box.Pointer, res, scale)

	Return _Result
End Function

' SRC\psio2.c (413, 1)
' generateUncompressedPS()
' generateUncompressedPS(char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32, l_int32) as char *
'''  <summary>
''' Notes
''' (1) Low-level function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="hexdata">[in] - </param>
'''  <param name="w">[in] - raster image size in pixels</param>
'''  <param name="h">[in] - raster image size in pixels</param>
'''  <param name="d">[in] - image depth in bpp; rgb is 32</param>
'''  <param name="psbpl">[in] - raster bytes/line, when packed to the byte boundary</param>
'''  <param name="bps">[in] - bits/sample either 1 or 8</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="boxflag">[in] - 1 to print out bounding box hint; 0 to skip</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateUncompressedPS(
				ByVal hexdata as String, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal d as Integer, 
				ByVal psbpl as Integer, 
				ByVal bps as Integer, 
				ByVal xpt as Single, 
				ByVal ypt as Single, 
				ByVal wpt as Single, 
				ByVal hpt as Single, 
				ByVal boxflag as Integer) as String

	If IsNothing (hexdata) then Throw New ArgumentNullException  ("hexdata cannot be Nothing")
	If IsNothing (xpt) then Throw New ArgumentNullException  ("xpt cannot be Nothing")
	If IsNothing (ypt) then Throw New ArgumentNullException  ("ypt cannot be Nothing")
	If IsNothing (wpt) then Throw New ArgumentNullException  ("wpt cannot be Nothing")
	If IsNothing (hpt) then Throw New ArgumentNullException  ("hpt cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.generateUncompressedPS( hexdata, w, h, d, psbpl, bps, xpt, ypt, wpt, hpt, boxflag)

	Return _Result
End Function

' SRC\psio2.c (522, 1)
' getScaledParametersPS()
' getScaledParametersPS(BOX *, l_int32, l_int32, l_int32, l_float32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as void
'''  <summary>
''' Notes
''' (1) The image is always scaled, depending on res and scale.
''' (2) If no box, the image is centered on the page.
''' (3) If there is a box, the image is placed within it.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in][optional] - location of image in mils; with x,y being the LL corner</param>
'''  <param name="wpix">[in] - pix width in pixels</param>
'''  <param name="hpix">[in] - pix height in pixels</param>
'''  <param name="res">[in] - of printer; use 0 for default</param>
'''  <param name="scale">[in] - use 1.0 or 0.0 for no scaling</param>
'''  <param name="pxpt">[out] - location of llx in pts</param>
'''  <param name="pypt">[out] - location of lly in pts</param>
'''  <param name="pwpt">[out] - image width in pts</param>
'''  <param name="phpt">[out] - image height in pts</param>
Public Shared Sub getScaledParametersPS(
				ByVal wpix as Integer, 
				ByVal hpix as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByRef pxpt as Single(), 
				ByRef pypt as Single(), 
				ByRef pwpt as Single(), 
				ByRef phpt as Single(), 
				Optional ByVal box as Box = Nothing)

	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	LeptonicaSharp.Natives.getScaledParametersPS( boxPTR, wpix, hpix, res, scale, pxpt, pypt, pwpt, phpt)

End Sub

' SRC\psio2.c (601, 1)
' convertByteToHexAscii()
' convertByteToHexAscii(l_uint8, char *, char *) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="byteval">[in] - input byte</param>
'''  <param name="pnib1">[out] - two hex ascii characters</param>
'''  <param name="pnib2">[out] - two hex ascii characters</param>
Public Shared Sub convertByteToHexAscii(
				ByVal byteval as Byte, 
				ByRef pnib1 as String, 
				ByRef pnib2 as String)

	If IsNothing (byteval) then Throw New ArgumentNullException  ("byteval cannot be Nothing")


	LeptonicaSharp.Natives.convertByteToHexAscii( byteval, pnib1, pnib2)

End Sub

' SRC\psio2.c (643, 1)
' convertJpegToPSEmbed()
' convertJpegToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function takes a jpeg file as input and generates a DCT
''' compressed, ascii85 encoded PS file, with a bounding box.
''' (2) The bounding box is required when a program such as TeX
''' (through epsf) places and rescales the image.
''' (3) The bounding box is sized for fitting the image to an
''' 8.5 x 11.0 inch page.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input jpeg file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertJpegToPSEmbed(
				ByVal filein as String, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertJpegToPSEmbed( filein, fileout)

	Return _Result
End Function

' SRC\psio2.c (758, 1)
' convertJpegToPS()
' convertJpegToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is simpler to use than pixWriteStringPS(), and
''' it outputs in level 2 PS as compressed DCT (overlaid
''' with ascii85 encoding).
''' (2) An output file can contain multiple pages, each with
''' multiple images.  The arguments to convertJpegToPS()
''' allow you to control placement of jpeg images on multiple
''' pages within a PostScript file.
''' (3) For the first image written to a file, use "w", which
''' opens for write and clears the file.  For all subsequent
''' images written to that file, use "a".
''' (4) The (x, y) parameters give the LL corner of the image
''' relative to the LL corner of the page.  They are in
''' units of pixels if scale = 1.0.  If you use (e.g.)
''' scale = 2.0, the image is placed at (2x, 2y) on the page,
''' and the image dimensions are also doubled.
''' (5) Display vs printed resolution
''' If your display is 75 ppi and your image was created
''' at a resolution of 300 ppi, you can get the image
''' to print at the same size as it appears on your display
''' by either setting scale = 4.0 or by setting  res = 75.
''' Both tell the printer to make a 4x enlarged image.
''' If your image is generated at 150 ppi and you use scale = 1,
''' it will be rendered such that 150 pixels correspond
''' to 72 pts (1 inch on the printer).  This function does
''' the conversion from pixels (with or without scaling) to
''' pts, which are the units that the printer uses.
''' The printer will choose its own resolution to use
''' in rendering the image, which will not affect the size
''' of the rendered image.  That is because the output
''' PostScript file describes the geometry in terms of pts,
''' which are defined to be 1/72 inch.  The printer will
''' only see the size of the image in pts, through the
''' scale and translate parameters and the affine
''' transform (the ImageMatrix) of the image.
''' (6) To render multiple images on the same page, set
''' endpage = FALSE for each image until you get to the
''' last, for which you set endpage = TRUE.  This causes the
''' "showpage" command to be invoked.  Showpage outputs
''' the entire page and clears the raster buffer for the
''' next page to be added.  Without a "showpage",
''' subsequent images from the next page will overlay those
''' previously put down.
''' (7) For multiple pages, increment the page number, starting
''' with page 1.  This allows PostScript (and PDF) to build
''' a page directory, which viewers use for navigation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input jpeg file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write; "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertJpegToPS(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal operation as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (operation) then Throw New ArgumentNullException  ("operation cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertJpegToPS( filein, fileout, operation, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (817, 1)
' convertJpegToPSString() Generates PS string in jpeg format from jpeg file
' convertJpegToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) For usage, see convertJpegToPS()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input jpeg file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertJpegToPSString(
				ByVal filein as String, 
				ByRef poutstr as String(), 
				ByRef pnbytes as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertJpegToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (911, 1)
' generateJpegPS()
' generateJpegPS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
'''  <summary>
''' Notes
''' (1) Low-level function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input jpeg filename; can be null</param>
'''  <param name="cid">[in] - jpeg compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateJpegPS(
				ByVal cid as L_Compressed_Data, 
				ByVal xpt as Single, 
				ByVal ypt as Single, 
				ByVal wpt as Single, 
				ByVal hpt as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer, 
				Optional ByVal filein as String = Nothing) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")
	If IsNothing (xpt) then Throw New ArgumentNullException  ("xpt cannot be Nothing")
	If IsNothing (ypt) then Throw New ArgumentNullException  ("ypt cannot be Nothing")
	If IsNothing (wpt) then Throw New ArgumentNullException  ("wpt cannot be Nothing")
	If IsNothing (hpt) then Throw New ArgumentNullException  ("hpt cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.generateJpegPS( filein, cid.Pointer, xpt, ypt, wpt, hpt, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1039, 1)
' convertG4ToPSEmbed()
' convertG4ToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function takes a g4 compressed tif file as input and
''' generates a g4 compressed, ascii85 encoded PS file, with
''' a bounding box.
''' (2) The bounding box is required when a program such as TeX
''' (through epsf) places and rescales the image.
''' (3) The bounding box is sized for fitting the image to an
''' 8.5 x 11.0 inch page.
''' (4) We paint this through a mask, over whatever is below.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertG4ToPSEmbed(
				ByVal filein as String, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertG4ToPSEmbed( filein, fileout)

	Return _Result
End Function

' SRC\psio2.c (1145, 1)
' convertG4ToPS()
' convertG4ToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) See the usage comments in convertJpegToPS(), some of
''' which are repeated here.
''' (2) This is a wrapper for tiff g4.  The PostScript that
''' is generated is expanded by about 5/4 (due to the
''' ascii85 encoding.  If you convert to pdf (ps2pdf), the
''' ascii85 decoder is automatically invoked, so that the
''' pdf wrapped g4 file is essentially the same size as
''' the original g4 file.  It's useful to have the PS
''' file ascii85 encoded, because many printers will not
''' print binary PS files.
''' (3) For the first image written to a file, use "w", which
''' opens for write and clears the file.  For all subsequent
''' images written to that file, use "a".
''' (4) To render multiple images on the same page, set
''' endpage = FALSE for each image until you get to the
''' last, for which you set endpage = TRUE.  This causes the
''' "showpage" command to be invoked.  Showpage outputs
''' the entire page and clears the raster buffer for the
''' next page to be added.  Without a "showpage",
''' subsequent images from the next page will overlay those
''' previously put down.
''' (5) For multiple images to the same page, where you are writing
''' both jpeg and tiff-g4, you have two options
''' (a) write the g4 first, as either image (maskflag == FALSE)
''' or imagemask (maskflag == TRUE), and then write the
''' jpeg over it.
''' (b) write the jpeg first and as the last item, write
''' the g4 as an imagemask (maskflag == TRUE), to paint
''' through the foreground only.
''' We have this flexibility with the tiff-g4 because it is 1 bpp.
''' (6) For multiple pages, increment the page number, starting
''' with page 1.  This allows PostScript (and PDF) to build
''' a page directory, which viewers use for navigation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff g4 file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write; "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; typ. values are 300 and 600; use 0 for automatic determination based on image size</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="maskflag">[in] - boolean use TRUE if just painting through fg; FALSE if painting both fg and bg.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertG4ToPS(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal operation as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal maskflag as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (operation) then Throw New ArgumentNullException  ("operation cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertG4ToPS( filein, fileout, operation, x, y, res, scale, pageno, maskflag, endpage)

	Return _Result
End Function

' SRC\psio2.c (1208, 1)
' convertG4ToPSString()
' convertG4ToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Generates PS string in G4 compressed tiff format from G4 tiff file.
''' (2) For usage, see convertG4ToPS().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff g4 file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; typ. values are 300 and 600; use 0 for automatic determination based on image size</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="maskflag">[in] - boolean use TRUE if just painting through fg; FALSE if painting both fg and bg.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertG4ToPSString(
				ByVal filein as String, 
				ByRef poutstr as String(), 
				ByRef pnbytes as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal maskflag as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertG4ToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, maskflag, endpage)

	Return _Result
End Function

' SRC\psio2.c (1304, 1)
' generateG4PS()
' generateG4PS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_int32) as char *
'''  <summary>
''' Notes
''' (1) Low-level function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input tiff g4 file; can be null</param>
'''  <param name="cid">[in] - g4 compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="maskflag">[in] - boolean use TRUE if just painting through fg; FALSE if painting both fg and bg.</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateG4PS(
				ByVal cid as L_Compressed_Data, 
				ByVal xpt as Single, 
				ByVal ypt as Single, 
				ByVal wpt as Single, 
				ByVal hpt as Single, 
				ByVal maskflag as Integer, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer, 
				Optional ByVal filein as String = Nothing) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")
	If IsNothing (xpt) then Throw New ArgumentNullException  ("xpt cannot be Nothing")
	If IsNothing (ypt) then Throw New ArgumentNullException  ("ypt cannot be Nothing")
	If IsNothing (wpt) then Throw New ArgumentNullException  ("wpt cannot be Nothing")
	If IsNothing (hpt) then Throw New ArgumentNullException  ("hpt cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.generateG4PS( filein, cid.Pointer, xpt, ypt, wpt, hpt, maskflag, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1438, 1)
' convertTiffMultipageToPS()
' convertTiffMultipageToPS(const char *, const char *, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This converts a multipage tiff file of binary page images
''' into a ccitt g4 compressed PS file.
''' (2) If the images are generated from a standard resolution fax,
''' the vertical resolution is doubled to give a normal-looking
''' aspect ratio.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff multipage file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="fillfract">[in] - factor for filling 8.5 x 11 inch page; use 0.0 for DEFAULT_FILL_FRACTION</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertTiffMultipageToPS(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal fillfract as Single) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (fillfract) then Throw New ArgumentNullException  ("fillfract cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertTiffMultipageToPS( filein, fileout, fillfract)

	Return _Result
End Function

' SRC\psio2.c (1518, 1)
' convertFlateToPSEmbed()
' convertFlateToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function takes any image file as input and generates a
''' flate-compressed, ascii85 encoded PS file, with a bounding box.
''' (2) The bounding box is required when a program such as TeX
''' (through epsf) places and rescales the image.
''' (3) The bounding box is sized for fitting the image to an
''' 8.5 x 11.0 inch page.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input file -- any format</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFlateToPSEmbed(
				ByVal filein as String, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFlateToPSEmbed( filein, fileout)

	Return _Result
End Function

' SRC\psio2.c (1631, 1)
' convertFlateToPS()
' convertFlateToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This outputs level 3 PS as flate compressed (overlaid
''' with ascii85 encoding).
''' (2) An output file can contain multiple pages, each with
''' multiple images.  The arguments to convertFlateToPS()
''' allow you to control placement of png images on multiple
''' pages within a PostScript file.
''' (3) For the first image written to a file, use "w", which
''' opens for write and clears the file.  For all subsequent
''' images written to that file, use "a".
''' (4) The (x, y) parameters give the LL corner of the image
''' relative to the LL corner of the page.  They are in
''' units of pixels if scale = 1.0.  If you use (e.g.)
''' scale = 2.0, the image is placed at (2x, 2y) on the page,
''' and the image dimensions are also doubled.
''' (5) Display vs printed resolution
''' If your display is 75 ppi and your image was created
''' at a resolution of 300 ppi, you can get the image
''' to print at the same size as it appears on your display
''' by either setting scale = 4.0 or by setting  res = 75.
''' Both tell the printer to make a 4x enlarged image.
''' If your image is generated at 150 ppi and you use scale = 1,
''' it will be rendered such that 150 pixels correspond
''' to 72 pts (1 inch on the printer).  This function does
''' the conversion from pixels (with or without scaling) to
''' pts, which are the units that the printer uses.
''' The printer will choose its own resolution to use
''' in rendering the image, which will not affect the size
''' of the rendered image.  That is because the output
''' PostScript file describes the geometry in terms of pts,
''' which are defined to be 1/72 inch.  The printer will
''' only see the size of the image in pts, through the
''' scale and translate parameters and the affine
''' transform (the ImageMatrix) of the image.
''' (6) To render multiple images on the same page, set
''' endpage = FALSE for each image until you get to the
''' last, for which you set endpage = TRUE.  This causes the
''' "showpage" command to be invoked.  Showpage outputs
''' the entire page and clears the raster buffer for the
''' next page to be added.  Without a "showpage",
''' subsequent images from the next page will overlay those
''' previously put down.
''' (7) For multiple pages, increment the page number, starting
''' with page 1.  This allows PostScript (and PDF) to build
''' a page directory, which viewers use for navigation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input file -- any format</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write; "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFlateToPS(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal operation as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (operation) then Throw New ArgumentNullException  ("operation cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFlateToPS( filein, fileout, operation, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1697, 1)
' convertFlateToPSString() Generates level 3 PS string in flate compressed format.
' convertFlateToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) The returned PS character array is a null-terminated
''' ascii string.  All the raster data is ascii85 encoded, so
''' there are no null bytes embedded in it.
''' (2) The raster encoding is made with gzip, the same as that
''' in a png file that is compressed without prediction.
''' The raster data itself is 25% larger than that in the
''' binary form, due to the ascii85 encoding.
''' Usage  See convertFlateToPS()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi; use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer; use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFlateToPSString(
				ByVal filein as String, 
				ByRef poutstr as String(), 
				ByRef pnbytes as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertFlateToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1781, 1)
' generateFlatePS()
' generateFlatePS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input filename; can be null</param>
'''  <param name="cid">[in] - flate compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="pageno">[in] - page number; must start with 1; you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean use TRUE if this is the last image to be added to the page; FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateFlatePS(
				ByVal cid as L_Compressed_Data, 
				ByVal xpt as Single, 
				ByVal ypt as Single, 
				ByVal wpt as Single, 
				ByVal hpt as Single, 
				ByVal pageno as Integer, 
				ByVal endpage as Integer, 
				Optional ByVal filein as String = Nothing) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")
	If IsNothing (xpt) then Throw New ArgumentNullException  ("xpt cannot be Nothing")
	If IsNothing (ypt) then Throw New ArgumentNullException  ("ypt cannot be Nothing")
	If IsNothing (wpt) then Throw New ArgumentNullException  ("wpt cannot be Nothing")
	If IsNothing (hpt) then Throw New ArgumentNullException  ("hpt cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.generateFlatePS( filein, cid.Pointer, xpt, ypt, wpt, hpt, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1922, 1)
' pixWriteMemPS()
' pixWriteMemPS(l_uint8 **, size_t *, PIX *, BOX *, l_int32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) See pixWriteStringPS() for usage.
''' (2) This is just a wrapper for pixWriteStringPS(), which
''' writes uncompressed image data to memory.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of tiff compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="box">[in][optional] - </param>
'''  <param name="res">[in] - can use 0 for default of 300 ppi</param>
'''  <param name="scale">[in] - to prevent scaling, use either 1.0 or 0.0</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPS(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal res as Integer, 
				ByVal scale as Single, 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero
	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPS( pdataPTR, psize, pix.Pointer, boxPTR, res, scale)
ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\psio2.c (1957, 1)
' getResLetterPage()
' getResLetterPage(l_int32, l_int32, l_float32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - image width, pixels</param>
'''  <param name="h">[in] - image height, pixels</param>
'''  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded; use 0 for default</param>
'''   <returns>resolution</returns>
Public Shared Function getResLetterPage(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal fillfract as Single) as Integer

	If IsNothing (fillfract) then Throw New ArgumentNullException  ("fillfract cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.getResLetterPage( w, h, fillfract)

	Return _Result
End Function

' SRC\psio2.c (1982, 1)
' getResA4Page()
' getResA4Page(l_int32, l_int32, l_float32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - image width, pixels</param>
'''  <param name="h">[in] - image height, pixels</param>
'''  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded; use 0 for default</param>
'''   <returns>resolution</returns>
Public Shared Function getResA4Page(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal fillfract as Single) as Integer

	If IsNothing (fillfract) then Throw New ArgumentNullException  ("fillfract cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.getResA4Page( w, h, fillfract)

	Return _Result
End Function

' SRC\psio2.c (2001, 1)
' 
' l_psWriteBoundingBox(l_int32) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_psWriteBoundingBox(
				ByRef flag as Integer)



	LeptonicaSharp.Natives.l_psWriteBoundingBox( flag)

End Sub

End Class
