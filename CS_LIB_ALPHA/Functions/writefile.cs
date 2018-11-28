using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// writefile.c (182, 1)
// l_jpegSetQuality(new_quality) as int
// l_jpegSetQuality(l_int32) as l_int32
///  <summary>
/// (1) This variable is used in pixWriteStream() and pixWriteMem(),
/// to control the jpeg quality.  The default is 75.<para/>
/// 
/// (2) It returns the previous quality, so for example:
/// l_int32  prev = l_jpegSetQuality(85)  //sets to 85
/// pixWriteStream(...)
/// l_jpegSetQuality(prev) // resets to previous value<para/>
/// 
/// (3) On error, logs a message and does not change the variable.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_jpegSetQuality/*"/>
///  <param name="new_quality">[in] - 1 - 100 75 is default 0 defaults to 75</param>
///   <returns>prev           previous quality</returns>
public static int l_jpegSetQuality(
				  int new_quality){

	int _Result = Natives.l_jpegSetQuality(  new_quality);
	



	return _Result;
}

// writefile.c (217, 1)
// setLeptDebugOK(allow) as Object
// setLeptDebugOK(l_int32) as void
///  <summary>
/// (1) This sets or clears the global variable LeptDebugOK, to
/// control writing files in a temp directory with names that
/// are compiled in.<para/>
/// 
/// (2) The default in the library distribution is 0.  Call with
/// %allow = 1 for development and debugging.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/setLeptDebugOK/*"/>
///  <param name="allow">[in] - TRUE (1) or FALSE (0)</param>
public static void setLeptDebugOK(
				  int allow){

	Natives.setLeptDebugOK(  allow);
	



}

// writefile.c (242, 1)
// pixaWriteFiles(rootname, pixa, format) as int
// pixaWriteFiles(const char *, PIXA *, l_int32) as l_ok
///  <summary>
/// (1) Use %format = IFF_DEFAULT to decide the output format
/// individually for each pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteFiles/*"/>
///  <param name="rootname">[in] - </param>
///  <param name="pixa">[in] - </param>
///  <param name="format">[in] - defined in imageio.h see notes for default</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaWriteFiles(
				  String rootname, 
				  Pixa pixa, 
				  IFF format){

	int _Result = Natives.pixaWriteFiles(  rootname, pixa.Pointer,  (int) format);
	



	return _Result;
}

// writefile.c (295, 1)
// pixWriteDebug(fname, pix, format) as int
// pixWriteDebug(const char *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) Debug version, intended for use in the library when writing
/// to files in a temp directory with names that are compiled in.
/// This is used instead of pixWrite() for all such library calls.<para/>
/// 
/// (2) The global variable LeptDebugOK defaults to 0, and can be set
/// or cleared by the function setLeptDebugOK().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteDebug/*"/>
///  <param name="fname">[in] - </param>
///  <param name="pix">[in] - </param>
///  <param name="format">[in] - defined in imageio.h</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteDebug(
				  String fname, 
				  Pix pix, 
				  IFF format){

	int _Result = Natives.pixWriteDebug(  fname, pix.Pointer,  (int) format);
	



	return _Result;
}

// writefile.c (332, 1)
// pixWrite(fname, pix, format) as int
// pixWrite(const char *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) Open for write using binary mode (with the "b" flag)
/// to avoid having Windows automatically translate the NL
/// into CRLF, which corrupts image files.  On non-windows
/// systems this flag should be ignored, per ISO C90.
/// Thanks to Dave Bryan for pointing this out.<para/>
/// 
/// (2) If the default image format IFF_DEFAULT is requested:
/// use the input format if known otherwise, use a lossless format.<para/>
/// 
/// (3) The default jpeg quality is 75.  For some other value,
/// Use l_jpegSetQuality().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWrite/*"/>
///  <param name="fname">[in] - </param>
///  <param name="pix">[in] - </param>
///  <param name="format">[in] - defined in imageio.h</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWrite(
				  String fname, 
				  Pix pix, 
				  IFF format){

	int _Result = Natives.pixWrite(  fname, pix.Pointer,  (int) format);
	



	return _Result;
}

// writefile.c (365, 1)
// pixWriteAutoFormat(filename, pix) as int
// pixWriteAutoFormat(const char *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteAutoFormat/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteAutoFormat(
				  String filename, 
				  Pix pix){

	int _Result = Natives.pixWriteAutoFormat(  filename, pix.Pointer);
	



	return _Result;
}

// writefile.c (392, 1)
// pixWriteStream(fp, pix, format) as int
// pixWriteStream(FILE *, PIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///  <param name="format">[in] - </param>
///   <returns>0 if OK 1 on error.</returns>
public static int pixWriteStream(
				  FILE fp, 
				  Pix pix, 
				  IFF format){

	int _Result = Natives.pixWriteStream(fp.Pointer, pix.Pointer,  (int) format);
	



	return _Result;
}

// writefile.c (484, 1)
// pixWriteImpliedFormat(filename, pix, quality, progressive) as int
// pixWriteImpliedFormat(const char *, PIX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This determines the output format from the filename extension.<para/>
/// 
/// (2) The last two args are ignored except for requests for jpeg files.<para/>
/// 
/// (3) The jpeg default quality is 75.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteImpliedFormat/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pix">[in] - </param>
///  <param name="quality">[in] - iff JPEG 1 - 100, 0 for default</param>
///  <param name="progressive">[in] - iff JPEG 0 for baseline seq., 1 for progressive</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteImpliedFormat(
				  String filename, 
				  Pix pix, 
				  int quality, 
				  int progressive){

	int _Result = Natives.pixWriteImpliedFormat(  filename, pix.Pointer,   quality,   progressive);
	



	return _Result;
}

// writefile.c (549, 1)
// pixChooseOutputFormat(pix) as int
// pixChooseOutputFormat(PIX *) as l_int32
///  <summary>
/// (1) This should only be called if the requested format is IFF_DEFAULT.<para/>
/// 
/// (2) If the pix wasn't read from a file, its input format value
/// will be IFF_UNKNOWN, and in that case it is written out
/// in a compressed but lossless format.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixChooseOutputFormat/*"/>
///  <param name="pix">[in] - </param>
///   <returns>output format, or 0 on error</returns>
public static int pixChooseOutputFormat(
				  Pix pix){

	int _Result = Natives.pixChooseOutputFormat(pix.Pointer);
	



	return _Result;
}

// writefile.c (584, 1)
// getImpliedFileFormat(filename) as int
// getImpliedFileFormat(const char *) as l_int32
///  <summary>
/// (1) This determines the output file format from the extension
/// of the input filename.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getImpliedFileFormat/*"/>
///  <param name="filename">[in] - </param>
///   <returns>output format, or IFF_UNKNOWN on error or invalid extension.</returns>
public static int getImpliedFileFormat(
				  String filename){

	int _Result = Natives.getImpliedFileFormat(  filename);
	



	return _Result;
}

// writefile.c (625, 1)
// pixGetAutoFormat(pix, pformat) as int
// pixGetAutoFormat(PIX *, l_int32 *) as l_ok
///  <summary>
/// (1) The output formats are restricted to tiff, jpeg and png
/// because these are the most commonly used image formats and
/// the ones that are typically installed with leptonica.<para/>
/// 
/// (2) This decides what compression to use based on the pix.
/// It chooses tiff-g4 if 1 bpp without a colormap, jpeg with
/// quality 75 if grayscale, rgb or rgba (where it loses
/// the alpha layer), and lossless png for all other situations.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAutoFormat/*"/>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetAutoFormat(
				  Pix pix, 
				  object pformat){

	int _Result = Natives.pixGetAutoFormat(pix.Pointer,   pformat);
	



	return _Result;
}

// writefile.c (666, 1)
// getFormatExtension(format) as String
// getFormatExtension(l_int32) as const char *
///  <summary>
/// (1) This string is NOT owned by the caller it is just a pointer
/// to a global string.  Do not free it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getFormatExtension/*"/>
///  <param name="format">[in] - integer</param>
///   <returns>extension string, or NULL if format is out of range</returns>
public static String getFormatExtension(
				  IFF format){

	String _Result = Natives.getFormatExtension( (int) format);
	



	return _Result;
}

// writefile.c (701, 1)
// pixWriteMem(pdata, psize, pix, format) as int
// pixWriteMem(l_uint8 **, size_t *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) On windows, this will only write tiff and PostScript to memory.
/// For other formats, it requires open_memstream(3).<para/>
/// 
/// (2) PostScript output is uncompressed, in hex ascii.
/// Most printers support level 2 compression (tiff_g4 for 1 bpp,
/// jpeg for 8 and 32 bpp).<para/>
/// 
/// (3) The default jpeg quality is 75.  For some other value,
/// Use l_jpegSetQuality().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMem/*"/>
///  <param name="pdata">[out] - data of tiff compressed image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///  <param name="format">[in] - defined in imageio.h</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteMem(
				 out Byte[] pdata, 
				 out uint psize, 
				  Pix pix, 
				  IFF format){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMem(out  pdataPtr, out  psize, pix.Pointer,  (int) format);
	

pdata = null;
psize = 0;


	return _Result;
}

// writefile.c (801, 1)
// l_fileDisplay(fname, x, y, scale) as int
// l_fileDisplay(const char *, l_int32, l_int32, l_float32) as l_ok
///  <summary>
/// (1) This is a convenient wrapper for displaying image files.<para/>
/// 
/// (2) It does nothing unless LeptDebugOK == TRUE.<para/>
/// 
/// (2) Set %scale = 0 to disable display.<para/>
/// 
/// (3) This downscales 1 bpp to gray.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_fileDisplay/*"/>
///  <param name="fname">[in] - </param>
///  <param name="x">[in] - location of display frame on the screen</param>
///  <param name="y">[in] - location of display frame on the screen</param>
///  <param name="scale">[in] - scale factor (use 0 to skip display)</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_fileDisplay(
				  String fname, 
				  int x, 
				  int y, 
				  Single scale){

	int _Result = Natives.l_fileDisplay(  fname,   x,   y,   scale);
	



	return _Result;
}

// writefile.c (877, 1)
// pixDisplay(pixs, x, y) as int
// pixDisplay(PIX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is debugging code that displays an image on the screen.
/// It uses a static internal variable to number the output files
/// written by a single process.  Behavior with a shared library
/// may be unpredictable.<para/>
/// 
/// (2) It does nothing unless LeptDebugOK == TRUE.<para/>
/// 
/// (3) It uses these programs to display the image:
/// On Unix: xzgv, xli or xv
/// On Windows: i_view
/// The display program must be on your $PATH variable.  It is
/// chosen by setting the global var_DISPLAY_PROG, using
/// l_chooseDisplayProg().  Default on Unix is xzgv.<para/>
/// 
/// (4) Images with dimensions larger than MAX_DISPLAY_WIDTH or
/// MAX_DISPLAY_HEIGHT are downscaled to fit those constraints.
/// This is particularly important for displaying 1 bpp images
/// with xv, because xv automatically downscales large images
/// by subsampling, which looks poor.  For 1 bpp, we use
/// scale-to-gray to get decent-looking anti-aliased images.
/// In all cases, we write a temporary file to /tmp/lept/disp,
/// that is read by the display program.<para/>
/// 
/// (5) The temporary file is written as png if, after initial
/// processing for special cases, any of these obtain:
/// pix dimensions are smaller than some thresholds
/// pix depth is less than 8 bpp
/// pix is colormapped<para/>
/// 
/// (6) For spp == 4, we call pixDisplayLayersRGBA() to show 3
/// versions of the image: the image with a fully opaque
/// alpha, the alpha, and the image as it would appear with
/// a white background.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplay/*"/>
///  <param name="x">[in] - location of display frame on the screen</param>
///  <param name="y">[in] - location of display frame on the screen</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixDisplay(
				  Pix pixs, 
				  int x, 
				  int y){

	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixDisplay(pixs.Pointer,   x,   y);
	



	return _Result;
}

// writefile.c (901, 1)
// pixDisplayWithTitle(pixs, x, y, title, dispflag) as int
// pixDisplayWithTitle(PIX *, l_int32, l_int32, const char *, l_int32) as l_ok
///  <summary>
/// (1) See notes for pixDisplay().<para/>
/// 
/// (2) This displays the image if dispflag == 1 otherwise it punts.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayWithTitle/*"/>
///  <param name="x">[in] - location of display frame</param>
///  <param name="y">[in] - location of display frame</param>
///  <param name="title">[in][optional] - on frame can be NULL</param>
///  <param name="dispflag">[in] - 1 to write, else disabled</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixDisplayWithTitle(
				  Pix pixs, 
				  int x, 
				  int y, 
				  String title, 
				  int dispflag){

	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixDisplayWithTitle(pixs.Pointer,   x,   y,   title,   dispflag);
	



	return _Result;
}

// writefile.c (1077, 1)
// pixSaveTiled(pixs, pixa, scalefactor, newrow, space, dp) as int
// pixSaveTiled(PIX *, PIXA *, l_float32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSaveTiled/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
///  <param name="pixa">[in] - the pix are accumulated here</param>
///  <param name="scalefactor">[in] - 0.0 to disable otherwise this is a scale factor</param>
///  <param name="newrow">[in] - 0 if placed on the same row as previous 1 otherwise</param>
///  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
///  <param name="dp">[in] - depth of pixa 8 or 32 bpp only used on first call</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixSaveTiled(
				  Pix pixs, 
				  Pixa pixa, 
				  Single scalefactor, 
				  int newrow, 
				  int space, 
				  int dp){

	int _Result = Natives.pixSaveTiled(pixs.Pointer, pixa.Pointer,   scalefactor,   newrow,   space,   dp);
	



	return _Result;
}

// writefile.c (1128, 1)
// pixSaveTiledOutline(pixs, pixa, scalefactor, newrow, space, linewidth, dp) as int
// pixSaveTiledOutline(PIX *, PIXA *, l_float32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Before calling this function for the first time, use
/// pixaCreate() to make the %pixa that will accumulate the pix.
/// This is passed in each time pixSaveTiled() is called.<para/>
/// 
/// (2) %scalefactor scales the input image.  After scaling and
/// possible depth conversion, the image is saved in the input
/// pixa, along with a box that specifies the location to
/// place it when tiled later.  Disable saving the pix by
/// setting %scalefactor == 0.0.<para/>
/// 
/// (3) %newrow and %space specify the location of the new pix
/// with respect to the last one(s) that were entered.<para/>
/// 
/// (4) %dp specifies the depth at which all pix are saved.  It can
/// be only 8 or 32 bpp.  Any colormap is removed.  This is only
/// used at the first invocation.<para/>
/// 
/// (5) This function uses two variables from call to call.
/// If they were static, the function would not be .so or thread
/// safe, and furthermore, there would be interference with two or
/// more pixa accumulating images at a time.  Consequently,
/// we use the first pix in the pixa to store and obtain both
/// the depth and the current position of the bottom (one pixel
/// below the lowest image raster line when laid out using
/// the boxa).  The bottom variable is stored in the input format
/// field, which is the only field available for storing an int.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSaveTiledOutline/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
///  <param name="pixa">[in] - the pix are accumulated here</param>
///  <param name="scalefactor">[in] - 0.0 to disable otherwise this is a scale factor</param>
///  <param name="newrow">[in] - 0 if placed on the same row as previous 1 otherwise</param>
///  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
///  <param name="linewidth">[in] - width of added outline for image 0 for no outline</param>
///  <param name="dp">[in] - depth of pixa 8 or 32 bpp only used on first call</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixSaveTiledOutline(
				  Pix pixs, 
				  Pixa pixa, 
				  Single scalefactor, 
				  int newrow, 
				  int space, 
				  int linewidth, 
				  int dp){

	int _Result = Natives.pixSaveTiledOutline(pixs.Pointer, pixa.Pointer,   scalefactor,   newrow,   space,   linewidth,   dp);
	



	return _Result;
}

// writefile.c (1258, 1)
// pixSaveTiledWithText(pixs, pixa, outwidth, newrow, space, linewidth, bmf, textstr, val, location) as int
// pixSaveTiledWithText(PIX *, PIXA *, l_int32, l_int32, l_int32, l_int32, L_BMF *, const char *, l_uint32, l_int32) as l_ok
///  <summary>
/// (1) Before calling this function for the first time, use
/// pixaCreate() to make the %pixa that will accumulate the pix.
/// This is passed in each time pixSaveTiled() is called.<para/>
/// 
/// (2) %outwidth is the scaled width.  After scaling, the image is
/// saved in the input pixa, along with a box that specifies
/// the location to place it when tiled later.  Disable saving
/// the pix by setting %outwidth == 0.<para/>
/// 
/// (3) %newrow and %space specify the location of the new pix
/// with respect to the last one(s) that were entered.<para/>
/// 
/// (4) All pix are saved as 32 bpp RGB.<para/>
/// 
/// (5) If both %bmf and %textstr are defined, this generates a pix
/// with the additional text otherwise, no text is written.<para/>
/// 
/// (6) The text is written before scaling, so it is properly
/// antialiased in the scaled pix.  However, if the pix on
/// different calls have different widths, the size of the
/// text will vary.<para/>
/// 
/// (7) See pixSaveTiledOutline() for other implementation details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSaveTiledWithText/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp</param>
///  <param name="pixa">[in] - the pix are accumulated here as 32 bpp</param>
///  <param name="outwidth">[in] - in pixels use 0 to disable entirely</param>
///  <param name="newrow">[in] - 1 to start a new row 0 to go on same row as previous</param>
///  <param name="space">[in] - horizontal and vertical spacing, in pixels</param>
///  <param name="linewidth">[in] - width of added outline for image 0 for no outline</param>
///  <param name="bmf">[in][optional] - font struct</param>
///  <param name="textstr">[in][optional] - text string to be added</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_AT_TOP, L_ADD_AT_BOT, L_ADD_BELOW</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixSaveTiledWithText(
				  Pix pixs, 
				  Pixa pixa, 
				  int outwidth, 
				  int newrow, 
				  int space, 
				  int linewidth, 
				  L_Bmf bmf, 
				  String textstr, 
				  uint val, 
				  int location){

	IntPtr bmfPtr = IntPtr.Zero; 	if (bmf != null) {bmfPtr = bmf.Pointer;}

	int _Result = Natives.pixSaveTiledWithText(pixs.Pointer, pixa.Pointer,   outwidth,   newrow,   space,   linewidth, bmfPtr,   textstr,   val,   location);
	



	return _Result;
}

// writefile.c (1300, 1)
// l_chooseDisplayProg(selection) as Object
// l_chooseDisplayProg(l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_chooseDisplayProg/*"/>
public static void l_chooseDisplayProg(
				  int selection){

	Natives.l_chooseDisplayProg(  selection);
	



}

// writefile.c (1347, 1)
// pixDisplayWrite(pixs, reduction) as int
// pixDisplayWrite(PIX *, l_int32) as l_ok
///  <summary>
/// (0) Deprecated.<para/>
/// 
/// (1) This is a simple interface for writing a set of files.<para/>
/// 
/// (2) This uses jpeg output for pix that are 32 bpp or 8 bpp
/// without a colormap otherwise, it uses png.<para/>
/// 
/// (3) To erase any previously written files in the output directory:
/// pixDisplayWrite(NULL, -1)<para/>
/// 
/// (4) If reduction  is greater  1 and depth == 1, this does a scale-to-gray
/// reduction.<para/>
/// 
/// (5) This function uses a static internal variable to number
/// output files written by a single process.  Behavior
/// with a shared library may be unpredictable.<para/>
/// 
/// (6) For 16 bpp, this displays the full dynamic range with log scale.
/// Alternative image transforms to generate 8 bpp pix are:
/// pix8 = pixMaxDynamicRange(pixt, L_LINEAR_SCALE)
/// pix8 = pixConvert16To8(pixt, 0)  // low order byte
/// pix8 = pixConvert16To8(pixt, 1)  // high order byte
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayWrite/*"/>
///  <param name="reduction">[in] - -1 to reset/erase 0 to disable otherwise this is a reduction factor</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixDisplayWrite(
				  Pix pixs, 
				  int reduction){

	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixDisplayWrite(pixs.Pointer,   reduction);
	



	return _Result;
}

}
