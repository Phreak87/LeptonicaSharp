Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\psio2.c (152, 1)
' pixWritePSEmbed(filein, fileout) as Integer
' pixWritePSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a simple wrapper function that generates an<para/>
''' uncompressed PS file, with a bounding box.<para/>
''' (2) The bounding box is required when a program such as TeX<para/>
''' (through epsf) places and rescales the image.<para/>
''' (3) The bounding box is sized for fitting the image to an<para/>
''' 8.5 x 11.0 inch page.<para/>
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
' pixWriteStreamPS(fp, pix, box, res, scale) as Integer
' pixWriteStreamPS(FILE *, PIX *, BOX *, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes image in PS format, optionally scaled,<para/>
''' adjusted for the printer resolution, and with<para/>
''' a bounding box.<para/>
''' (2) For details on use of parameters, see pixWriteStringPS().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="box">[in][optional] - </param>
'''  <param name="res">[in] - can use 0 for default of 300 ppi</param>
'''  <param name="scale">[in] - to prevent scaling, use either 1.0 or 0.0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPS(
				 ByVal fp as FILE, 
				 ByVal pix as Pix, 
				 ByVal box as Box, 
				 ByVal res as Integer, 
				 ByVal scale as Single) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPS( fp.Pointer, pix.Pointer, boxPTR, res, scale)

	Return _Result
End Function

' SRC\psio2.c (303, 1)
' pixWriteStringPS(pixs, box, res, scale) as String
' pixWriteStringPS(PIX *, BOX *, l_int32, l_float32) as char *
'''  <summary>
''' <para/>
''' a) If %box == NULL, image is placed, optionally scaled,<para/>
''' in a standard b.b. at the center of the page.<para/>
''' This is to be used when another program like<para/>
''' TeX through epsf places the image.<para/>
''' b) If %box != NULL, image is placed without a<para/>
''' b.b. at the specified page location and with<para/>
''' optional scaling.  This is to be used when<para/>
''' you want to specify exactly where and optionally<para/>
''' how big you want the image to be.<para/>
''' Note that all coordinates are in PS convention,<para/>
''' with 0,0 at LL corner of the page:<para/>
''' x,y  location of LL corner of image, in mils.<para/>
''' w,h  scaled size, in mils.  Use 0 to<para/>
''' scale with "scale" and "res" input.<para/>
''' %scale: If no scaling is desired, use either 1.0 or 0.0.<para/>
''' Scaling just resets the resolution parameter the actual<para/>
''' scaling is done in the interpreter at rendering time.<para/>
''' This is important:  it allows you to scale the image up<para/>
''' without increasing the file size.<para/>
''' Notes:<para/>
''' (1) OK, this seems a bit complicated, because there are various<para/>
''' ways to scale and not to scale.  Here's a summary:<para/>
''' (2) If you don't want any scaling at all:<para/>
''' if you are using a box:<para/>
''' set w = 0, h = 0, and use scale = 1.0 it will print<para/>
''' each pixel unscaled at printer resolution<para/>
''' if you are not using a box:<para/>
''' set scale = 1.0 it will print at printer resolution<para/>
''' (3) If you want the image to be a certain size in inches:<para/>
''' you must use a box and set the box (w,h) in mils<para/>
''' (4) If you want the image to be scaled by a scale factor != 1.0:<para/>
''' if you are using a box:<para/>
''' set w = 0, h = 0, and use the desired scale factor<para/>
''' the higher the printer resolution, the smaller the<para/>
''' image will actually appear.<para/>
''' if you are not using a box:<para/>
''' set the desired scale factor the higher the printer<para/>
''' resolution, the smaller the image will actually appear.<para/>
''' (5) Another complication is the proliferation of distance units:<para/>
''' The interface distances are in milli-inches.<para/>
''' Three different units are used internally:<para/>
''' ~ pixels  (units of 1/res inch)<para/>
''' ~ printer pts (units of 1/72 inch)<para/>
''' ~ inches<para/>
''' Here is a quiz on volume units from a reviewer:<para/>
''' How many UK milli-cups in a US kilo-teaspoon?<para/>
''' (Hint: 1.0 US cup = 0.75 UK cup + 0.2 US gill<para/>
''' 1.0 US gill = 24.0 US teaspoons)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths, colormap OK</param>
'''  <param name="box">[in] - bounding box can be NULL</param>
'''  <param name="res">[in] - resolution, in printer ppi.  Use 0 for default 300 ppi.</param>
'''  <param name="scale">[in] - scale factor.  If no scaling is desired, use either 1.0 or 0.0.   Scaling just resets the resolution parameter the actual scaling is done in the interpreter at rendering time.  This is important: it allows you to scale the image up without increasing the file size.</param>
'''   <returns>ps string if OK, or NULL on error</returns>
Public Shared Function pixWriteStringPS(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal res as Integer, 
				 ByVal scale as Single) as String

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.pixWriteStringPS( pixs.Pointer, box.Pointer, res, scale)

	Return _Result
End Function

' SRC\psio2.c (413, 1)
' generateUncompressedPS(hexdata, w, h, d, psbpl, bps, xpt, ypt, wpt, hpt, boxflag) as String
' generateUncompressedPS(char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Low-level function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="hexdata">[in] - </param>
'''  <param name="w">[in] - raster image size in pixels</param>
'''  <param name="h">[in] - raster image size in pixels</param>
'''  <param name="d">[in] - image depth in bpp rgb is 32</param>
'''  <param name="psbpl">[in] - raster bytes/line, when packed to the byte boundary</param>
'''  <param name="bps">[in] - bits/sample: either 1 or 8</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="boxflag">[in] - 1 to print out bounding box hint 0 to skip</param>
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

	Dim _Result as String = LeptonicaSharp.Natives.generateUncompressedPS( hexdata, w, h, d, psbpl, bps, xpt, ypt, wpt, hpt, boxflag)

	Return _Result
End Function

' SRC\psio2.c (522, 1)
' getScaledParametersPS(box, wpix, hpix, res, scale, pxpt, pypt, pwpt, phpt) as Object
' getScaledParametersPS(BOX *, l_int32, l_int32, l_int32, l_float32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The image is always scaled, depending on res and scale.<para/>
''' (2) If no box, the image is centered on the page.<para/>
''' (3) If there is a box, the image is placed within it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in][optional] - location of image in mils with x,y being the LL corner</param>
'''  <param name="wpix">[in] - pix width in pixels</param>
'''  <param name="hpix">[in] - pix height in pixels</param>
'''  <param name="res">[in] - of printer use 0 for default</param>
'''  <param name="scale">[in] - use 1.0 or 0.0 for no scaling</param>
'''  <param name="pxpt">[out] - location of llx in pts</param>
'''  <param name="pypt">[out] - location of lly in pts</param>
'''  <param name="pwpt">[out] - image width in pts</param>
'''  <param name="phpt">[out] - image height in pts</param>
Public Shared Sub getScaledParametersPS(
				 ByVal box as Box, 
				 ByVal wpix as Integer, 
				 ByVal hpix as Integer, 
				 ByVal res as Integer, 
				 ByVal scale as Single, 
				<Out()> ByRef pxpt as Single, 
				<Out()> ByRef pypt as Single, 
				<Out()> ByRef pwpt as Single, 
				<Out()> ByRef phpt as Single)

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	LeptonicaSharp.Natives.getScaledParametersPS( boxPTR, wpix, hpix, res, scale, pxpt, pypt, pwpt, phpt)

End Sub

' SRC\psio2.c (601, 1)
' convertByteToHexAscii(byteval, pnib1, pnib2) as Object
' convertByteToHexAscii(l_uint8, char *, char *) as void
'''  <remarks>
'''  </remarks>
'''  <param name="byteval">[in] - input byte</param>
'''  <param name="pnib1">[out] - two hex ascii characters</param>
'''  <param name="pnib2">[out] - two hex ascii characters</param>
Public Shared Sub convertByteToHexAscii(
				 ByVal byteval as Byte, 
				<Out()> ByRef pnib1 as String, 
				<Out()> ByRef pnib2 as String)

	If IsNothing (byteval) then Throw New ArgumentNullException  ("byteval cannot be Nothing")

	LeptonicaSharp.Natives.convertByteToHexAscii( byteval, pnib1, pnib2)

End Sub

' SRC\psio2.c (643, 1)
' convertJpegToPSEmbed(filein, fileout) as Integer
' convertJpegToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function takes a jpeg file as input and generates a DCT<para/>
''' compressed, ascii85 encoded PS file, with a bounding box.<para/>
''' (2) The bounding box is required when a program such as TeX<para/>
''' (through epsf) places and rescales the image.<para/>
''' (3) The bounding box is sized for fitting the image to an<para/>
''' 8.5 x 11.0 inch page.<para/>
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
' convertJpegToPS(filein, fileout, operation, x, y, res, scale, pageno, endpage) as Integer
' convertJpegToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is simpler to use than pixWriteStringPS(), and<para/>
''' it outputs in level 2 PS as compressed DCT (overlaid<para/>
''' with ascii85 encoding).<para/>
''' (2) An output file can contain multiple pages, each with<para/>
''' multiple images.  The arguments to convertJpegToPS()<para/>
''' allow you to control placement of jpeg images on multiple<para/>
''' pages within a PostScript file.<para/>
''' (3) For the first image written to a file, use "w", which<para/>
''' opens for write and clears the file.  For all subsequent<para/>
''' images written to that file, use "a".<para/>
''' (4) The (x, y) parameters give the LL corner of the image<para/>
''' relative to the LL corner of the page.  They are in<para/>
''' units of pixels if scale = 1.0.  If you use (e.g.)<para/>
''' scale = 2.0, the image is placed at (2x, 2y) on the page,<para/>
''' and the image dimensions are also doubled.<para/>
''' (5) Display vs printed resolution:<para/>
''' If your display is 75 ppi and your image was created<para/>
''' at a resolution of 300 ppi, you can get the image<para/>
''' to print at the same size as it appears on your display<para/>
''' by either setting scale = 4.0 or by setting  res = 75.<para/>
''' Both tell the printer to make a 4x enlarged image.<para/>
''' If your image is generated at 150 ppi and you use scale = 1,<para/>
''' it will be rendered such that 150 pixels correspond<para/>
''' to 72 pts (1 inch on the printer).  This function does<para/>
''' the conversion from pixels (with or without scaling) to<para/>
''' pts, which are the units that the printer uses.<para/>
''' The printer will choose its own resolution to use<para/>
''' in rendering the image, which will not affect the size<para/>
''' of the rendered image.  That is because the output<para/>
''' PostScript file describes the geometry in terms of pts,<para/>
''' which are defined to be 1/72 inch.  The printer will<para/>
''' only see the size of the image in pts, through the<para/>
''' scale and translate parameters and the affine<para/>
''' transform (the ImageMatrix) of the image.<para/>
''' (6) To render multiple images on the same page, set<para/>
''' endpage = FALSE for each image until you get to the<para/>
''' last, for which you set endpage = TRUE.  This causes the<para/>
''' "showpage" command to be invoked.  Showpage outputs<para/>
''' the entire page and clears the raster buffer for the<para/>
''' next page to be added.  Without a "showpage",<para/>
''' subsequent images from the next page will overlay those<para/>
''' previously put down.<para/>
''' (7) For multiple pages, increment the page number, starting<para/>
''' with page 1.  This allows PostScript (and PDF) to build<para/>
''' a page directory, which viewers use for navigation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input jpeg file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
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

	Dim _Result as Integer = LeptonicaSharp.Natives.convertJpegToPS( filein, fileout, operation, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (817, 1)
' convertJpegToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, endpage) as Integer
' convertJpegToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For usage, see convertJpegToPS()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input jpeg file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertJpegToPSString(
				 ByVal filein as String, 
				<Out()> ByRef poutstr as String(), 
				<Out()> ByRef pnbytes as Integer, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal res as Integer, 
				 ByVal scale as Single, 
				 ByVal pageno as Integer, 
				 ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertJpegToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (911, 1)
' generateJpegPS(filein, cid, xpt, ypt, wpt, hpt, pageno, endpage) as String
' generateJpegPS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Low-level function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input jpeg filename can be null</param>
'''  <param name="cid">[in] - jpeg compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateJpegPS(
				 ByVal filein as String, 
				 ByVal cid as L_Compressed_Data, 
				 ByVal xpt as Single, 
				 ByVal ypt as Single, 
				 ByVal wpt as Single, 
				 ByVal hpt as Single, 
				 ByVal pageno as Integer, 
				 ByVal endpage as Integer) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.generateJpegPS( filein, cid.Pointer, xpt, ypt, wpt, hpt, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1039, 1)
' convertG4ToPSEmbed(filein, fileout) as Integer
' convertG4ToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function takes a g4 compressed tif file as input and<para/>
''' generates a g4 compressed, ascii85 encoded PS file, with<para/>
''' a bounding box.<para/>
''' (2) The bounding box is required when a program such as TeX<para/>
''' (through epsf) places and rescales the image.<para/>
''' (3) The bounding box is sized for fitting the image to an<para/>
''' 8.5 x 11.0 inch page.<para/>
''' (4) We paint this through a mask, over whatever is below.<para/>
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
' convertG4ToPS(filein, fileout, operation, x, y, res, scale, pageno, maskflag, endpage) as Integer
' convertG4ToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See the usage comments in convertJpegToPS(), some of<para/>
''' which are repeated here.<para/>
''' (2) This is a wrapper for tiff g4.  The PostScript that<para/>
''' is generated is expanded by about 5/4 (due to the<para/>
''' ascii85 encoding.  If you convert to pdf (ps2pdf), the<para/>
''' ascii85 decoder is automatically invoked, so that the<para/>
''' pdf wrapped g4 file is essentially the same size as<para/>
''' the original g4 file.  It's useful to have the PS<para/>
''' file ascii85 encoded, because many printers will not<para/>
''' print binary PS files.<para/>
''' (3) For the first image written to a file, use "w", which<para/>
''' opens for write and clears the file.  For all subsequent<para/>
''' images written to that file, use "a".<para/>
''' (4) To render multiple images on the same page, set<para/>
''' endpage = FALSE for each image until you get to the<para/>
''' last, for which you set endpage = TRUE.  This causes the<para/>
''' "showpage" command to be invoked.  Showpage outputs<para/>
''' the entire page and clears the raster buffer for the<para/>
''' next page to be added.  Without a "showpage",<para/>
''' subsequent images from the next page will overlay those<para/>
''' previously put down.<para/>
''' (5) For multiple images to the same page, where you are writing<para/>
''' both jpeg and tiff-g4, you have two options:<para/>
''' (a) write the g4 first, as either image (maskflag == FALSE)<para/>
''' or imagemask (maskflag == TRUE), and then write the<para/>
''' jpeg over it.<para/>
''' (b) write the jpeg first and as the last item, write<para/>
''' the g4 as an imagemask (maskflag == TRUE), to paint<para/>
''' through the foreground only.<para/>
''' We have this flexibility with the tiff-g4 because it is 1 bpp.<para/>
''' (6) For multiple pages, increment the page number, starting<para/>
''' with page 1.  This allows PostScript (and PDF) to build<para/>
''' a page directory, which viewers use for navigation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff g4 file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi typ. values are 300 and 600 use 0 for automatic determination based on image size</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
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

	Dim _Result as Integer = LeptonicaSharp.Natives.convertG4ToPS( filein, fileout, operation, x, y, res, scale, pageno, maskflag, endpage)

	Return _Result
End Function

' SRC\psio2.c (1208, 1)
' convertG4ToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, maskflag, endpage) as Integer
' convertG4ToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates PS string in G4 compressed tiff format from G4 tiff file.<para/>
''' (2) For usage, see convertG4ToPS().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff g4 file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi typ. values are 300 and 600 use 0 for automatic determination based on image size</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertG4ToPSString(
				 ByVal filein as String, 
				<Out()> ByRef poutstr as String(), 
				<Out()> ByRef pnbytes as Integer, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal res as Integer, 
				 ByVal scale as Single, 
				 ByVal pageno as Integer, 
				 ByVal maskflag as Integer, 
				 ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertG4ToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, maskflag, endpage)

	Return _Result
End Function

' SRC\psio2.c (1304, 1)
' generateG4PS(filein, cid, xpt, ypt, wpt, hpt, maskflag, pageno, endpage) as String
' generateG4PS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Low-level function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input tiff g4 file can be null</param>
'''  <param name="cid">[in] - g4 compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateG4PS(
				 ByVal filein as String, 
				 ByVal cid as L_Compressed_Data, 
				 ByVal xpt as Single, 
				 ByVal ypt as Single, 
				 ByVal wpt as Single, 
				 ByVal hpt as Single, 
				 ByVal maskflag as Integer, 
				 ByVal pageno as Integer, 
				 ByVal endpage as Integer) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.generateG4PS( filein, cid.Pointer, xpt, ypt, wpt, hpt, maskflag, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1438, 1)
' convertTiffMultipageToPS(filein, fileout, fillfract) as Integer
' convertTiffMultipageToPS(const char *, const char *, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This converts a multipage tiff file of binary page images<para/>
''' into a ccitt g4 compressed PS file.<para/>
''' (2) If the images are generated from a standard resolution fax,<para/>
''' the vertical resolution is doubled to give a normal-looking<para/>
''' aspect ratio.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input tiff multipage file</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="fillfract">[in] - factor for filling 8.5 x 11 inch page use 0.0 for DEFAULT_FILL_FRACTION</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertTiffMultipageToPS(
				 ByVal filein as String, 
				 ByVal fileout as String, 
				 Optional ByVal fillfract as Single = 0) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.convertTiffMultipageToPS( filein, fileout, fillfract)

	Return _Result
End Function

' SRC\psio2.c (1518, 1)
' convertFlateToPSEmbed(filein, fileout) as Integer
' convertFlateToPSEmbed(const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function takes any image file as input and generates a<para/>
''' flate-compressed, ascii85 encoded PS file, with a bounding box.<para/>
''' (2) The bounding box is required when a program such as TeX<para/>
''' (through epsf) places and rescales the image.<para/>
''' (3) The bounding box is sized for fitting the image to an<para/>
''' 8.5 x 11.0 inch page.<para/>
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
' convertFlateToPS(filein, fileout, operation, x, y, res, scale, pageno, endpage) as Integer
' convertFlateToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This outputs level 3 PS as flate compressed (overlaid<para/>
''' with ascii85 encoding).<para/>
''' (2) An output file can contain multiple pages, each with<para/>
''' multiple images.  The arguments to convertFlateToPS()<para/>
''' allow you to control placement of png images on multiple<para/>
''' pages within a PostScript file.<para/>
''' (3) For the first image written to a file, use "w", which<para/>
''' opens for write and clears the file.  For all subsequent<para/>
''' images written to that file, use "a".<para/>
''' (4) The (x, y) parameters give the LL corner of the image<para/>
''' relative to the LL corner of the page.  They are in<para/>
''' units of pixels if scale = 1.0.  If you use (e.g.)<para/>
''' scale = 2.0, the image is placed at (2x, 2y) on the page,<para/>
''' and the image dimensions are also doubled.<para/>
''' (5) Display vs printed resolution:<para/>
''' If your display is 75 ppi and your image was created<para/>
''' at a resolution of 300 ppi, you can get the image<para/>
''' to print at the same size as it appears on your display<para/>
''' by either setting scale = 4.0 or by setting  res = 75.<para/>
''' Both tell the printer to make a 4x enlarged image.<para/>
''' If your image is generated at 150 ppi and you use scale = 1,<para/>
''' it will be rendered such that 150 pixels correspond<para/>
''' to 72 pts (1 inch on the printer).  This function does<para/>
''' the conversion from pixels (with or without scaling) to<para/>
''' pts, which are the units that the printer uses.<para/>
''' The printer will choose its own resolution to use<para/>
''' in rendering the image, which will not affect the size<para/>
''' of the rendered image.  That is because the output<para/>
''' PostScript file describes the geometry in terms of pts,<para/>
''' which are defined to be 1/72 inch.  The printer will<para/>
''' only see the size of the image in pts, through the<para/>
''' scale and translate parameters and the affine<para/>
''' transform (the ImageMatrix) of the image.<para/>
''' (6) To render multiple images on the same page, set<para/>
''' endpage = FALSE for each image until you get to the<para/>
''' last, for which you set endpage = TRUE.  This causes the<para/>
''' "showpage" command to be invoked.  Showpage outputs<para/>
''' the entire page and clears the raster buffer for the<para/>
''' next page to be added.  Without a "showpage",<para/>
''' subsequent images from the next page will overlay those<para/>
''' previously put down.<para/>
''' (7) For multiple pages, increment the page number, starting<para/>
''' with page 1.  This allows PostScript (and PDF) to build<para/>
''' a page directory, which viewers use for navigation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input file -- any format</param>
'''  <param name="fileout">[in] - output ps file</param>
'''  <param name="operation">[in] - "w" for write "a" for append</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
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

	Dim _Result as Integer = LeptonicaSharp.Natives.convertFlateToPS( filein, fileout, operation, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1697, 1)
' convertFlateToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, endpage) as Integer
' convertFlateToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned PS character array is a null-terminated<para/>
''' ascii string.  All the raster data is ascii85 encoded, so<para/>
''' there are no null bytes embedded in it.<para/>
''' (2) The raster encoding is made with gzip, the same as that<para/>
''' in a png file that is compressed without prediction.<para/>
''' The raster data itself is 25% larger than that in the<para/>
''' binary form, due to the ascii85 encoding.<para/>
''' Usage:  See convertFlateToPS()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file</param>
'''  <param name="poutstr">[out] - PS string</param>
'''  <param name="pnbytes">[out] - number of bytes in PS string</param>
'''  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
'''  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFlateToPSString(
				 ByVal filein as String, 
				<Out()> ByRef poutstr as String(), 
				<Out()> ByRef pnbytes as Integer, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal res as Integer, 
				 ByVal scale as Single, 
				 ByVal pageno as Integer, 
				 ByVal endpage as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")

Dim poutstrPTR As IntPtr = poutstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(poutstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.convertFlateToPSString( filein, poutstrPTR, pnbytes, x, y, res, scale, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1781, 1)
' generateFlatePS(filein, cid, xpt, ypt, wpt, hpt, pageno, endpage) as String
' generateFlatePS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in][optional] - input filename can be null</param>
'''  <param name="cid">[in] - flate compressed image data</param>
'''  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
'''  <param name="wpt">[in] - rendered image size in pts</param>
'''  <param name="hpt">[in] - rendered image size in pts</param>
'''  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
'''  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
'''   <returns>PS string, or NULL on error</returns>
Public Shared Function generateFlatePS(
				 ByVal filein as String, 
				 ByVal cid as L_Compressed_Data, 
				 ByVal xpt as Single, 
				 ByVal ypt as Single, 
				 ByVal wpt as Single, 
				 ByVal hpt as Single, 
				 ByVal pageno as Integer, 
				 ByVal endpage as Integer) as String

	If IsNothing (cid) then Throw New ArgumentNullException  ("cid cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.generateFlatePS( filein, cid.Pointer, xpt, ypt, wpt, hpt, pageno, endpage)

	Return _Result
End Function

' SRC\psio2.c (1922, 1)
' pixWriteMemPS(pdata, psize, pix, box, res, scale) as Integer
' pixWriteMemPS(l_uint8 **, size_t *, PIX *, BOX *, l_int32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixWriteStringPS() for usage.<para/>
''' (2) This is just a wrapper for pixWriteStringPS(), which<para/>
''' writes uncompressed image data to memory.<para/>
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
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pix as Pix, 
				 ByVal box as Box, 
				 ByVal res as Integer, 
				 ByVal scale as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero
	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPS( pdataPTR, psize, pix.Pointer, boxPTR, res, scale)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\psio2.c (1957, 1)
' getResLetterPage(w, h, fillfract) as Integer
' getResLetterPage(l_int32, l_int32, l_float32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - image width, pixels</param>
'''  <param name="h">[in] - image height, pixels</param>
'''  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded use 0 for default</param>
'''   <returns>resolution</returns>
Public Shared Function getResLetterPage(
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal fillfract as Single) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.getResLetterPage( w, h, fillfract)

	Return _Result
End Function

' SRC\psio2.c (1982, 1)
' getResA4Page(w, h, fillfract) as Integer
' getResA4Page(l_int32, l_int32, l_float32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - image width, pixels</param>
'''  <param name="h">[in] - image height, pixels</param>
'''  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded use 0 for default</param>
'''   <returns>resolution</returns>
Public Shared Function getResA4Page(
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal fillfract as Single) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.getResA4Page( w, h, fillfract)

	Return _Result
End Function

' SRC\psio2.c (2001, 1)
' l_psWriteBoundingBox(flag) as Object
' l_psWriteBoundingBox(l_int32) as void
'''  <remarks>
'''  </remarks>
Public Shared Sub l_psWriteBoundingBox(
				 ByVal flag as Integer)

	LeptonicaSharp.Natives.l_psWriteBoundingBox( flag)

End Sub

End Class
