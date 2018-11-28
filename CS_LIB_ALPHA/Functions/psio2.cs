using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// psio2.c (152, 1)
// pixWritePSEmbed(filein, fileout) as int
// pixWritePSEmbed(const char *, const char *) as l_ok
///  <summary>
/// (1) This is a simple wrapper function that generates an
/// uncompressed PS file, with a bounding box.<para/>
/// 
/// (2) The bounding box is required when a program such as TeX
/// (through epsf) places and rescales the image.<para/>
/// 
/// (3) The bounding box is sized for fitting the image to an
/// 8.5 x 11.0 inch page.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWritePSEmbed/*"/>
///  <param name="filein">[in] - input file, all depths, colormap OK</param>
///  <param name="fileout">[in] - output ps file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWritePSEmbed(
				  String filein, 
				  String fileout){

	int _Result = Natives.pixWritePSEmbed(  filein,   fileout);
	



	return _Result;
}

// psio2.c (205, 1)
// pixWriteStreamPS(fp, pix, box, res, scale) as int
// pixWriteStreamPS(FILE *, PIX *, BOX *, l_int32, l_float32) as l_ok
///  <summary>
/// (1) This writes image in PS format, optionally scaled,
/// adjusted for the printer resolution, and with
/// a bounding box.<para/>
/// 
/// (2) For details on use of parameters, see pixWriteStringPS().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPS/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///  <param name="box">[in][optional] - </param>
///  <param name="res">[in] - can use 0 for default of 300 ppi</param>
///  <param name="scale">[in] - to prevent scaling, use either 1.0 or 0.0</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteStreamPS(
				  FILE fp, 
				  Pix pix, 
				  Box box, 
				  int res, 
				  Single scale){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixWriteStreamPS(fp.Pointer, pix.Pointer, boxPtr,   res,   scale);
	



	return _Result;
}

// psio2.c (303, 1)
// pixWriteStringPS(pixs, box, res, scale) as String
// pixWriteStringPS(PIX *, BOX *, l_int32, l_float32) as char *
///  <summary>
/// a) If %box == NULL, image is placed, optionally scaled,
/// in a standard b.b. at the center of the page.
/// This is to be used when another program like
/// TeX through epsf places the image.
/// b) If %box != NULL, image is placed without a
/// b.b. at the specified page location and with
/// optional scaling.  This is to be used when
/// you want to specify exactly where and optionally
/// how big you want the image to be.
/// Note that all coordinates are in PS convention,
/// with 0,0 at LL corner of the page:
/// x,y  location of LL corner of image, in mils.
/// w,h  scaled size, in mils.  Use 0 to
/// scale with "scale" and "res" input.
/// %scale: If no scaling is desired, use either 1.0 or 0.0.
/// Scaling just resets the resolution parameter the actual
/// scaling is done in the interpreter at rendering time.
/// This is important:  it allows you to scale the image up
/// without increasing the file size.
/// Notes:<para/>
/// 
/// (1) OK, this seems a bit complicated, because there are various
/// ways to scale and not to scale.  Here's a summary:<para/>
/// 
/// (2) If you don't want any scaling at all:
/// if you are using a box:
/// set w = 0, h = 0, and use scale = 1.0 it will print
/// each pixel unscaled at printer resolution
/// if you are not using a box:
/// set scale = 1.0 it will print at printer resolution<para/>
/// 
/// (3) If you want the image to be a certain size in inches:
/// you must use a box and set the box (w,h) in mils<para/>
/// 
/// (4) If you want the image to be scaled by a scale factor != 1.0:
/// if you are using a box:
/// set w = 0, h = 0, and use the desired scale factor
/// the higher the printer resolution, the smaller the
/// image will actually appear.
/// if you are not using a box:
/// set the desired scale factor the higher the printer
/// resolution, the smaller the image will actually appear.<para/>
/// 
/// (5) Another complication is the proliferation of distance units:
/// The interface distances are in milli-inches.
/// Three different units are used internally:
/// ~ pixels  (units of 1/res inch)
/// ~ printer pts (units of 1/72 inch)
/// ~ inches
/// Here is a quiz on volume units from a reviewer:
/// How many UK milli-cups in a US kilo-teaspoon?
/// (Hint: 1.0 US cup = 0.75 UK cup + 0.2 US gill
/// 1.0 US gill = 24.0 US teaspoons)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStringPS/*"/>
///  <param name="pixs">[in] - all depths, colormap OK</param>
///  <param name="box">[in] - bounding box can be NULL</param>
///  <param name="res">[in] - resolution, in printer ppi.  Use 0 for default 300 ppi.</param>
///  <param name="scale">[in] - scale factor.  If no scaling is desired, use either 1.0 or 0.0.   Scaling just resets the resolution parameter the actual scaling is done in the interpreter at rendering time.  This is important: it allows you to scale the image up without increasing the file size.</param>
///   <returns>ps string if OK, or NULL on error</returns>
public static String pixWriteStringPS(
				  Pix pixs, 
				  Box box, 
				  int res, 
				  Single scale){

	String _Result = Natives.pixWriteStringPS(pixs.Pointer, box.Pointer,   res,   scale);
	



	return _Result;
}

// psio2.c (413, 1)
// generateUncompressedPS(hexdata, w, h, d, psbpl, bps, xpt, ypt, wpt, hpt, boxflag) as String
// generateUncompressedPS(char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32, l_int32) as char *
///  <summary>
/// (1) Low-level function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generateUncompressedPS/*"/>
///  <param name="hexdata">[in] - </param>
///  <param name="w">[in] - raster image size in pixels</param>
///  <param name="h">[in] - raster image size in pixels</param>
///  <param name="d">[in] - image depth in bpp rgb is 32</param>
///  <param name="psbpl">[in] - raster bytes/line, when packed to the byte boundary</param>
///  <param name="bps">[in] - bits/sample: either 1 or 8</param>
///  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="wpt">[in] - rendered image size in pts</param>
///  <param name="hpt">[in] - rendered image size in pts</param>
///  <param name="boxflag">[in] - 1 to print out bounding box hint 0 to skip</param>
///   <returns>PS string, or NULL on error</returns>
public static String generateUncompressedPS(
				  String hexdata, 
				  int w, 
				  int h, 
				  int d, 
				  int psbpl, 
				  int bps, 
				  Single xpt, 
				  Single ypt, 
				  Single wpt, 
				  Single hpt, 
				  int boxflag){

	String _Result = Natives.generateUncompressedPS(  hexdata,   w,   h,   d,   psbpl,   bps,   xpt,   ypt,   wpt,   hpt,   boxflag);
	



	return _Result;
}

// psio2.c (522, 1)
// getScaledParametersPS(box, wpix, hpix, res, scale, pxpt, pypt, pwpt, phpt) as Object
// getScaledParametersPS(BOX *, l_int32, l_int32, l_int32, l_float32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as void
///  <summary>
/// (1) The image is always scaled, depending on res and scale.<para/>
/// 
/// (2) If no box, the image is centered on the page.<para/>
/// 
/// (3) If there is a box, the image is placed within it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getScaledParametersPS/*"/>
///  <param name="box">[in][optional] - location of image in mils with x,y being the LL corner</param>
///  <param name="wpix">[in] - pix width in pixels</param>
///  <param name="hpix">[in] - pix height in pixels</param>
///  <param name="res">[in] - of printer use 0 for default</param>
///  <param name="scale">[in] - use 1.0 or 0.0 for no scaling</param>
///  <param name="pxpt">[out] - location of llx in pts</param>
///  <param name="pypt">[out] - location of lly in pts</param>
///  <param name="pwpt">[out] - image width in pts</param>
///  <param name="phpt">[out] - image height in pts</param>
public static void getScaledParametersPS(
				  Box box, 
				  int wpix, 
				  int hpix, 
				  int res, 
				  Single scale, 
				 out Single pxpt, 
				 out Single pypt, 
				 out Single pwpt, 
				 out Single phpt){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	Natives.getScaledParametersPS(boxPtr,   wpix,   hpix,   res,   scale, out  pxpt, out  pypt, out  pwpt, out  phpt);
	

pxpt = 0f;
pypt = 0f;
pwpt = 0f;
phpt = 0f;


}

// psio2.c (601, 1)
// convertByteToHexAscii(byteval, pnib1, pnib2) as Object
// convertByteToHexAscii(l_uint8, char *, char *) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertByteToHexAscii/*"/>
///  <param name="byteval">[in] - input byte</param>
///  <param name="pnib1">[out] - two hex ascii characters</param>
///  <param name="pnib2">[out] - two hex ascii characters</param>
public static void convertByteToHexAscii(
				  byte byteval, 
				 out String pnib1, 
				 out String pnib2){

	Natives.convertByteToHexAscii(  byteval, out  pnib1, out  pnib2);
	

pnib1 = null;
pnib2 = null;


}

// psio2.c (643, 1)
// convertJpegToPSEmbed(filein, fileout) as int
// convertJpegToPSEmbed(const char *, const char *) as l_ok
///  <summary>
/// (1) This function takes a jpeg file as input and generates a DCT
/// compressed, ascii85 encoded PS file, with a bounding box.<para/>
/// 
/// (2) The bounding box is required when a program such as TeX
/// (through epsf) places and rescales the image.<para/>
/// 
/// (3) The bounding box is sized for fitting the image to an
/// 8.5 x 11.0 inch page.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertJpegToPSEmbed/*"/>
///  <param name="filein">[in] - input jpeg file</param>
///  <param name="fileout">[in] - output ps file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertJpegToPSEmbed(
				  String filein, 
				  String fileout){

	int _Result = Natives.convertJpegToPSEmbed(  filein,   fileout);
	



	return _Result;
}

// psio2.c (758, 1)
// convertJpegToPS(filein, fileout, operation, x, y, res, scale, pageno, endpage) as int
// convertJpegToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is simpler to use than pixWriteStringPS(), and
/// it outputs in level 2 PS as compressed DCT (overlaid
/// with ascii85 encoding).<para/>
/// 
/// (2) An output file can contain multiple pages, each with
/// multiple images.  The arguments to convertJpegToPS()
/// allow you to control placement of jpeg images on multiple
/// pages within a PostScript file.<para/>
/// 
/// (3) For the first image written to a file, use "w", which
/// opens for write and clears the file.  For all subsequent
/// images written to that file, use "a".<para/>
/// 
/// (4) The (x, y) parameters give the LL corner of the image
/// relative to the LL corner of the page.  They are in
/// units of pixels if scale = 1.0.  If you use (e.g.)
/// scale = 2.0, the image is placed at (2x, 2y) on the page,
/// and the image dimensions are also doubled.<para/>
/// 
/// (5) Display vs printed resolution:
/// If your display is 75 ppi and your image was created
/// at a resolution of 300 ppi, you can get the image
/// to print at the same size as it appears on your display
/// by either setting scale = 4.0 or by setting  res = 75.
/// Both tell the printer to make a 4x enlarged image.
/// If your image is generated at 150 ppi and you use scale = 1,
/// it will be rendered such that 150 pixels correspond
/// to 72 pts (1 inch on the printer).  This function does
/// the conversion from pixels (with or without scaling) to
/// pts, which are the units that the printer uses.
/// The printer will choose its own resolution to use
/// in rendering the image, which will not affect the size
/// of the rendered image.  That is because the output
/// PostScript file describes the geometry in terms of pts,
/// which are defined to be 1/72 inch.  The printer will
/// only see the size of the image in pts, through the
/// scale and translate parameters and the affine
/// transform (the ImageMatrix) of the image.<para/>
/// 
/// (6) To render multiple images on the same page, set
/// endpage = FALSE for each image until you get to the
/// last, for which you set endpage = TRUE.  This causes the
/// "showpage" command to be invoked.  Showpage outputs
/// the entire page and clears the raster buffer for the
/// next page to be added.  Without a "showpage",
/// subsequent images from the next page will overlay those
/// previously put down.<para/>
/// 
/// (7) For multiple pages, increment the page number, starting
/// with page 1.  This allows PostScript (and PDF) to build
/// a page directory, which viewers use for navigation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertJpegToPS/*"/>
///  <param name="filein">[in] - input jpeg file</param>
///  <param name="fileout">[in] - output ps file</param>
///  <param name="operation">[in] - "w" for write "a" for append</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertJpegToPS(
				  String filein, 
				  String fileout, 
				  String operation, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int endpage){

	int _Result = Natives.convertJpegToPS(  filein,   fileout,   operation,   x,   y,   res,   scale,   pageno,   endpage);
	



	return _Result;
}

// psio2.c (817, 1)
// convertJpegToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, endpage) as int
// convertJpegToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) For usage, see convertJpegToPS()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertJpegToPSString/*"/>
///  <param name="filein">[in] - input jpeg file</param>
///  <param name="poutstr">[out] - PS string</param>
///  <param name="pnbytes">[out] - number of bytes in PS string</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertJpegToPSString(
				  String filein, 
				 out String[] poutstr, 
				 out int pnbytes, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int endpage){

	IntPtr poutstrPtr = IntPtr.Zero;

	int _Result = Natives.convertJpegToPSString(  filein, out  poutstrPtr, out  pnbytes,   x,   y,   res,   scale,   pageno,   endpage);
	

poutstr = null;
pnbytes = 0;


	return _Result;
}

// psio2.c (911, 1)
// generateJpegPS(filein, cid, xpt, ypt, wpt, hpt, pageno, endpage) as String
// generateJpegPS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
///  <summary>
/// (1) Low-level function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generateJpegPS/*"/>
///  <param name="filein">[in][optional] - input jpeg filename can be null</param>
///  <param name="cid">[in] - jpeg compressed image data</param>
///  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="wpt">[in] - rendered image size in pts</param>
///  <param name="hpt">[in] - rendered image size in pts</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>PS string, or NULL on error</returns>
public static String generateJpegPS(
				  String filein, 
				  L_Compressed_Data cid, 
				  Single xpt, 
				  Single ypt, 
				  Single wpt, 
				  Single hpt, 
				  int pageno, 
				  int endpage){

	String _Result = Natives.generateJpegPS(  filein, cid.Pointer,   xpt,   ypt,   wpt,   hpt,   pageno,   endpage);
	



	return _Result;
}

// psio2.c (1039, 1)
// convertG4ToPSEmbed(filein, fileout) as int
// convertG4ToPSEmbed(const char *, const char *) as l_ok
///  <summary>
/// (1) This function takes a g4 compressed tif file as input and
/// generates a g4 compressed, ascii85 encoded PS file, with
/// a bounding box.<para/>
/// 
/// (2) The bounding box is required when a program such as TeX
/// (through epsf) places and rescales the image.<para/>
/// 
/// (3) The bounding box is sized for fitting the image to an
/// 8.5 x 11.0 inch page.<para/>
/// 
/// (4) We paint this through a mask, over whatever is below.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertG4ToPSEmbed/*"/>
///  <param name="filein">[in] - input tiff file</param>
///  <param name="fileout">[in] - output ps file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertG4ToPSEmbed(
				  String filein, 
				  String fileout){

	int _Result = Natives.convertG4ToPSEmbed(  filein,   fileout);
	



	return _Result;
}

// psio2.c (1145, 1)
// convertG4ToPS(filein, fileout, operation, x, y, res, scale, pageno, maskflag, endpage) as int
// convertG4ToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) See the usage comments in convertJpegToPS(), some of
/// which are repeated here.<para/>
/// 
/// (2) This is a wrapper for tiff g4.  The PostScript that
/// is generated is expanded by about 5/4 (due to the
/// ascii85 encoding.  If you convert to pdf (ps2pdf), the
/// ascii85 decoder is automatically invoked, so that the
/// pdf wrapped g4 file is essentially the same size as
/// the original g4 file.  It's useful to have the PS
/// file ascii85 encoded, because many printers will not
/// print binary PS files.<para/>
/// 
/// (3) For the first image written to a file, use "w", which
/// opens for write and clears the file.  For all subsequent
/// images written to that file, use "a".<para/>
/// 
/// (4) To render multiple images on the same page, set
/// endpage = FALSE for each image until you get to the
/// last, for which you set endpage = TRUE.  This causes the
/// "showpage" command to be invoked.  Showpage outputs
/// the entire page and clears the raster buffer for the
/// next page to be added.  Without a "showpage",
/// subsequent images from the next page will overlay those
/// previously put down.<para/>
/// 
/// (5) For multiple images to the same page, where you are writing
/// both jpeg and tiff-g4, you have two options:
/// (a) write the g4 first, as either image (maskflag == FALSE)
/// or imagemask (maskflag == TRUE), and then write the
/// jpeg over it.
/// (b) write the jpeg first and as the last item, write
/// the g4 as an imagemask (maskflag == TRUE), to paint
/// through the foreground only.
/// We have this flexibility with the tiff-g4 because it is 1 bpp.<para/>
/// 
/// (6) For multiple pages, increment the page number, starting
/// with page 1.  This allows PostScript (and PDF) to build
/// a page directory, which viewers use for navigation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertG4ToPS/*"/>
///  <param name="filein">[in] - input tiff g4 file</param>
///  <param name="fileout">[in] - output ps file</param>
///  <param name="operation">[in] - "w" for write "a" for append</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi typ. values are 300 and 600 use 0 for automatic determination based on image size</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertG4ToPS(
				  String filein, 
				  String fileout, 
				  String operation, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int maskflag, 
				  int endpage){

	int _Result = Natives.convertG4ToPS(  filein,   fileout,   operation,   x,   y,   res,   scale,   pageno,   maskflag,   endpage);
	



	return _Result;
}

// psio2.c (1208, 1)
// convertG4ToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, maskflag, endpage) as int
// convertG4ToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Generates PS string in G4 compressed tiff format from G4 tiff file.<para/>
/// 
/// (2) For usage, see convertG4ToPS().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertG4ToPSString/*"/>
///  <param name="filein">[in] - input tiff g4 file</param>
///  <param name="poutstr">[out] - PS string</param>
///  <param name="pnbytes">[out] - number of bytes in PS string</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi typ. values are 300 and 600 use 0 for automatic determination based on image size</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertG4ToPSString(
				  String filein, 
				 out String[] poutstr, 
				 out int pnbytes, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int maskflag, 
				  int endpage){

	IntPtr poutstrPtr = IntPtr.Zero;

	int _Result = Natives.convertG4ToPSString(  filein, out  poutstrPtr, out  pnbytes,   x,   y,   res,   scale,   pageno,   maskflag,   endpage);
	

poutstr = null;
pnbytes = 0;


	return _Result;
}

// psio2.c (1304, 1)
// generateG4PS(filein, cid, xpt, ypt, wpt, hpt, maskflag, pageno, endpage) as String
// generateG4PS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_int32) as char *
///  <summary>
/// (1) Low-level function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generateG4PS/*"/>
///  <param name="filein">[in][optional] - input tiff g4 file can be null</param>
///  <param name="cid">[in] - g4 compressed image data</param>
///  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="wpt">[in] - rendered image size in pts</param>
///  <param name="hpt">[in] - rendered image size in pts</param>
///  <param name="maskflag">[in] - boolean: use TRUE if just painting through fg FALSE if painting both fg and bg.</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>PS string, or NULL on error</returns>
public static String generateG4PS(
				  String filein, 
				  L_Compressed_Data cid, 
				  Single xpt, 
				  Single ypt, 
				  Single wpt, 
				  Single hpt, 
				  int maskflag, 
				  int pageno, 
				  int endpage){

	String _Result = Natives.generateG4PS(  filein, cid.Pointer,   xpt,   ypt,   wpt,   hpt,   maskflag,   pageno,   endpage);
	



	return _Result;
}

// psio2.c (1438, 1)
// convertTiffMultipageToPS(filein, fileout, fillfract) as int
// convertTiffMultipageToPS(const char *, const char *, l_float32) as l_ok
///  <summary>
/// (1) This converts a multipage tiff file of binary page images
/// into a ccitt g4 compressed PS file.<para/>
/// 
/// (2) If the images are generated from a standard resolution fax,
/// the vertical resolution is doubled to give a normal-looking
/// aspect ratio.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertTiffMultipageToPS/*"/>
///  <param name="filein">[in] - input tiff multipage file</param>
///  <param name="fileout">[in] - output ps file</param>
///  <param name="fillfract">[in] - factor for filling 8.5 x 11 inch page use 0.0 for DEFAULT_FILL_FRACTION</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertTiffMultipageToPS(
				  String filein, 
				  String fileout, 
				 Single fillfract){

	int _Result = Natives.convertTiffMultipageToPS(  filein,   fileout,   fillfract);
	



	return _Result;
}

// psio2.c (1518, 1)
// convertFlateToPSEmbed(filein, fileout) as int
// convertFlateToPSEmbed(const char *, const char *) as l_ok
///  <summary>
/// (1) This function takes any image file as input and generates a
/// flate-compressed, ascii85 encoded PS file, with a bounding box.<para/>
/// 
/// (2) The bounding box is required when a program such as TeX
/// (through epsf) places and rescales the image.<para/>
/// 
/// (3) The bounding box is sized for fitting the image to an
/// 8.5 x 11.0 inch page.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFlateToPSEmbed/*"/>
///  <param name="filein">[in] - input file -- any format</param>
///  <param name="fileout">[in] - output ps file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertFlateToPSEmbed(
				  String filein, 
				  String fileout){

	int _Result = Natives.convertFlateToPSEmbed(  filein,   fileout);
	



	return _Result;
}

// psio2.c (1631, 1)
// convertFlateToPS(filein, fileout, operation, x, y, res, scale, pageno, endpage) as int
// convertFlateToPS(const char *, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This outputs level 3 PS as flate compressed (overlaid
/// with ascii85 encoding).<para/>
/// 
/// (2) An output file can contain multiple pages, each with
/// multiple images.  The arguments to convertFlateToPS()
/// allow you to control placement of png images on multiple
/// pages within a PostScript file.<para/>
/// 
/// (3) For the first image written to a file, use "w", which
/// opens for write and clears the file.  For all subsequent
/// images written to that file, use "a".<para/>
/// 
/// (4) The (x, y) parameters give the LL corner of the image
/// relative to the LL corner of the page.  They are in
/// units of pixels if scale = 1.0.  If you use (e.g.)
/// scale = 2.0, the image is placed at (2x, 2y) on the page,
/// and the image dimensions are also doubled.<para/>
/// 
/// (5) Display vs printed resolution:
/// If your display is 75 ppi and your image was created
/// at a resolution of 300 ppi, you can get the image
/// to print at the same size as it appears on your display
/// by either setting scale = 4.0 or by setting  res = 75.
/// Both tell the printer to make a 4x enlarged image.
/// If your image is generated at 150 ppi and you use scale = 1,
/// it will be rendered such that 150 pixels correspond
/// to 72 pts (1 inch on the printer).  This function does
/// the conversion from pixels (with or without scaling) to
/// pts, which are the units that the printer uses.
/// The printer will choose its own resolution to use
/// in rendering the image, which will not affect the size
/// of the rendered image.  That is because the output
/// PostScript file describes the geometry in terms of pts,
/// which are defined to be 1/72 inch.  The printer will
/// only see the size of the image in pts, through the
/// scale and translate parameters and the affine
/// transform (the ImageMatrix) of the image.<para/>
/// 
/// (6) To render multiple images on the same page, set
/// endpage = FALSE for each image until you get to the
/// last, for which you set endpage = TRUE.  This causes the
/// "showpage" command to be invoked.  Showpage outputs
/// the entire page and clears the raster buffer for the
/// next page to be added.  Without a "showpage",
/// subsequent images from the next page will overlay those
/// previously put down.<para/>
/// 
/// (7) For multiple pages, increment the page number, starting
/// with page 1.  This allows PostScript (and PDF) to build
/// a page directory, which viewers use for navigation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFlateToPS/*"/>
///  <param name="filein">[in] - input file -- any format</param>
///  <param name="fileout">[in] - output ps file</param>
///  <param name="operation">[in] - "w" for write "a" for append</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertFlateToPS(
				  String filein, 
				  String fileout, 
				  String operation, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int endpage){

	int _Result = Natives.convertFlateToPS(  filein,   fileout,   operation,   x,   y,   res,   scale,   pageno,   endpage);
	



	return _Result;
}

// psio2.c (1697, 1)
// convertFlateToPSString(filein, poutstr, pnbytes, x, y, res, scale, pageno, endpage) as int
// convertFlateToPSString(const char *, char **, l_int32 *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) The returned PS character array is a null-terminated
/// ascii string.  All the raster data is ascii85 encoded, so
/// there are no null bytes embedded in it.<para/>
/// 
/// (2) The raster encoding is made with gzip, the same as that
/// in a png file that is compressed without prediction.
/// The raster data itself is 25% larger than that in the
/// binary form, due to the ascii85 encoding.
/// Usage:  See convertFlateToPS()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFlateToPSString/*"/>
///  <param name="filein">[in] - input image file</param>
///  <param name="poutstr">[out] - PS string</param>
///  <param name="pnbytes">[out] - number of bytes in PS string</param>
///  <param name="x">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="y">[in] - location of LL corner of image, in pixels, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="res">[in] - resolution of the input image, in ppi use 0 for default</param>
///  <param name="scale">[in] - scaling by printer use 0.0 or 1.0 for no scaling</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page.</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertFlateToPSString(
				  String filein, 
				 out String[] poutstr, 
				 out int pnbytes, 
				  int x, 
				  int y, 
				  int res, 
				  Single scale, 
				  int pageno, 
				  int endpage){

	IntPtr poutstrPtr = IntPtr.Zero;

	int _Result = Natives.convertFlateToPSString(  filein, out  poutstrPtr, out  pnbytes,   x,   y,   res,   scale,   pageno,   endpage);
	

poutstr = null;
pnbytes = 0;


	return _Result;
}

// psio2.c (1781, 1)
// generateFlatePS(filein, cid, xpt, ypt, wpt, hpt, pageno, endpage) as String
// generateFlatePS(const char *, L_COMP_DATA *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generateFlatePS/*"/>
///  <param name="filein">[in][optional] - input filename can be null</param>
///  <param name="cid">[in] - flate compressed image data</param>
///  <param name="xpt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="ypt">[in] - location of LL corner of image, in pts, relative to the PostScript origin (0,0) at the LL corner of the page</param>
///  <param name="wpt">[in] - rendered image size in pts</param>
///  <param name="hpt">[in] - rendered image size in pts</param>
///  <param name="pageno">[in] - page number must start with 1 you can use 0 if there is only one page</param>
///  <param name="endpage">[in] - boolean: use TRUE if this is the last image to be added to the page FALSE otherwise</param>
///   <returns>PS string, or NULL on error</returns>
public static String generateFlatePS(
				  String filein, 
				  L_Compressed_Data cid, 
				  Single xpt, 
				  Single ypt, 
				  Single wpt, 
				  Single hpt, 
				  int pageno, 
				  int endpage){

	String _Result = Natives.generateFlatePS(  filein, cid.Pointer,   xpt,   ypt,   wpt,   hpt,   pageno,   endpage);
	



	return _Result;
}

// psio2.c (1922, 1)
// pixWriteMemPS(pdata, psize, pix, box, res, scale) as int
// pixWriteMemPS(l_uint8 **, size_t *, PIX *, BOX *, l_int32, l_float32) as l_ok
///  <summary>
/// (1) See pixWriteStringPS() for usage.<para/>
/// 
/// (2) This is just a wrapper for pixWriteStringPS(), which
/// writes uncompressed image data to memory.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPS/*"/>
///  <param name="pdata">[out] - data of tiff compressed image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///  <param name="box">[in][optional] - </param>
///  <param name="res">[in] - can use 0 for default of 300 ppi</param>
///  <param name="scale">[in] - to prevent scaling, use either 1.0 or 0.0</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteMemPS(
				 out Byte[] pdata, 
				 out uint psize, 
				  Pix pix, 
				  Box box, 
				  int res, 
				  Single scale){

	IntPtr pdataPtr = IntPtr.Zero;
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixWriteMemPS(out  pdataPtr, out  psize, pix.Pointer, boxPtr,   res,   scale);
	

pdata = null;
psize = 0;


	return _Result;
}

// psio2.c (1957, 1)
// getResLetterPage(w, h, fillfract) as int
// getResLetterPage(l_int32, l_int32, l_float32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getResLetterPage/*"/>
///  <param name="w">[in] - image width, pixels</param>
///  <param name="h">[in] - image height, pixels</param>
///  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded use 0 for default</param>
///   <returns>resolution</returns>
public static int getResLetterPage(
				  int w, 
				  int h, 
				  Single fillfract){

	int _Result = Natives.getResLetterPage(  w,   h,   fillfract);
	



	return _Result;
}

// psio2.c (1982, 1)
// getResA4Page(w, h, fillfract) as int
// getResA4Page(l_int32, l_int32, l_float32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getResA4Page/*"/>
///  <param name="w">[in] - image width, pixels</param>
///  <param name="h">[in] - image height, pixels</param>
///  <param name="fillfract">[in] - fraction in linear dimension of full page, not to be exceeded use 0 for default</param>
///   <returns>resolution</returns>
public static int getResA4Page(
				  int w, 
				  int h, 
				  Single fillfract){

	int _Result = Natives.getResA4Page(  w,   h,   fillfract);
	



	return _Result;
}

// psio2.c (2001, 1)
// l_psWriteBoundingBox(flag) as Object
// l_psWriteBoundingBox(l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_psWriteBoundingBox/*"/>
public static void l_psWriteBoundingBox(
				  int flag){

	Natives.l_psWriteBoundingBox(  flag);
	



}

}
