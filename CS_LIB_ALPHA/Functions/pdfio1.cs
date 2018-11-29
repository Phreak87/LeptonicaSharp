using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pdfio1.c (239, 1)
// convertFilesToPdf(dirname, substr, res, scalefactor, type, quality, title, fileout) as int
// convertFilesToPdf(const char *, const char *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
///  <summary>
/// (1) If %substr is not NULL, only image filenames that contain
/// the substring can be used.  If %substr == NULL, all files
/// in the directory are used.<para/>
/// 
/// (2) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order
/// before concatenation.<para/>
/// 
/// (3) The scalefactor is applied to each image before encoding.
/// If you enter a value smaller or equal 0.0, it will be set to 1.0.<para/>
/// 
/// (4) Specifying one of the three encoding types for %type forces
/// all images to be compressed with that type.  Use 0 to have
/// the type determined for each image based on depth and whether
/// or not it has a colormap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesToPdf/*"/>
///  <param name="dirname">[in] - directory name containing images</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="res">[in] - input resolution of all images</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertFilesToPdf(
				 String dirname, 
				 String substr, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 String title, 
				 String fileout){

	int _Result = Natives.convertFilesToPdf(  dirname,   substr,   res,   scalefactor,   type,   quality,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (287, 1)
// saConvertFilesToPdf(sa, res, scalefactor, type, quality, title, fileout) as int
// saConvertFilesToPdf(SARRAY *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
///  <summary>
/// (1) See convertFilesToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConvertFilesToPdf/*"/>
///  <param name="sa">[in] - string array of pathnames for images</param>
///  <param name="res">[in] - input resolution of all images</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConvertFilesToPdf(
				 Sarray sa, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 String title, 
				 String fileout){

	int _Result = Natives.saConvertFilesToPdf(sa.Pointer,   res,   scalefactor,   type,   quality,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (340, 1)
// saConvertFilesToPdfData(sa, res, scalefactor, type, quality, title, pdata, pnbytes) as int
// saConvertFilesToPdfData(SARRAY *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) See convertFilesToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConvertFilesToPdfData/*"/>
///  <param name="sa">[in] - string array of pathnames for images</param>
///  <param name="res">[in] - input resolution of all images</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="pdata">[out] - output pdf data (of all images</param>
///  <param name="pnbytes">[out] - size of output pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConvertFilesToPdfData(
				 Sarray sa, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.saConvertFilesToPdfData(sa.Pointer,   res,   scalefactor,   type,   quality,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (457, 1)
// selectDefaultPdfEncoding(pix, ptype) as int
// selectDefaultPdfEncoding(PIX *, l_int32 *) as l_ok
///  <summary>
/// (1) This attempts to choose an encoding for the pix that results
/// in the smallest file, assuming that if jpeg encoded, it will
/// use quality = 75.  The decision is approximate, in that
/// (a) all colormapped images will be losslessly encoded with
/// gzip (flate), and (b) an image with less than about 20 colors
/// is likely to be smaller if flate encoded than if encoded
/// as a jpeg (dct).  For example, an image made by pixScaleToGray3()
/// will have 10 colors, and flate encoding will give about
/// twice the compression as jpeg with quality = 75.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selectDefaultPdfEncoding/*"/>
///  <param name="pix">[in] - </param>
///  <param name="ptype">[out] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int selectDefaultPdfEncoding(
				 Pix pix, 
				out int ptype){

	int _Result = Natives.selectDefaultPdfEncoding(pix.Pointer, out  ptype);
	



	return _Result;
}

// pdfio1.c (520, 1)
// convertUnscaledFilesToPdf(dirname, substr, title, fileout) as int
// convertUnscaledFilesToPdf(const char *, const char *, const char *, const char *) as l_ok
///  <summary>
/// (1) If %substr is not NULL, only image filenames that contain
/// the substring can be used.  If %substr == NULL, all files
/// in the directory are used.<para/>
/// 
/// (2) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order
/// before concatenation.<para/>
/// 
/// (3) For jpeg and jp2k, this is very fast because the compressed
/// data is wrapped up and concatenated.  For png and tiffg4,
/// the images must be read and recompressed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertUnscaledFilesToPdf/*"/>
///  <param name="dirname">[in] - directory name containing images</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertUnscaledFilesToPdf(
				 String dirname, 
				 String substr, 
				 String title, 
				 String fileout){

	int _Result = Natives.convertUnscaledFilesToPdf(  dirname,   substr,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (558, 1)
// saConvertUnscaledFilesToPdf(sa, title, fileout) as int
// saConvertUnscaledFilesToPdf(SARRAY *, const char *, const char *) as l_ok
///  <summary>
/// (1) See convertUnscaledFilesToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConvertUnscaledFilesToPdf/*"/>
///  <param name="sa">[in] - string array of pathnames for images</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConvertUnscaledFilesToPdf(
				 Sarray sa, 
				 String title, 
				 String fileout){

	int _Result = Natives.saConvertUnscaledFilesToPdf(sa.Pointer,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (596, 1)
// saConvertUnscaledFilesToPdfData(sa, title, pdata, pnbytes) as int
// saConvertUnscaledFilesToPdfData(SARRAY *, const char *, l_uint8 **, size_t *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConvertUnscaledFilesToPdfData/*"/>
///  <param name="sa">[in] - string array of pathnames for images</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="pdata">[out] - output pdf data (of all images)</param>
///  <param name="pnbytes">[out] - size of output pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConvertUnscaledFilesToPdfData(
				 Sarray sa, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.saConvertUnscaledFilesToPdfData(sa.Pointer,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (668, 1)
// convertUnscaledToPdfData(fname, title, pdata, pnbytes) as int
// convertUnscaledToPdfData(const char *, const char *, l_uint8 **, size_t *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertUnscaledToPdfData/*"/>
///  <param name="fname">[in] - of image file</param>
///  <param name="title">[in][optional] - pdf title can be NULL</param>
///  <param name="pdata">[out] - output pdf data for image</param>
///  <param name="pnbytes">[out] - size of output pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertUnscaledToPdfData(
				 String fname, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.convertUnscaledToPdfData(  fname,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (752, 1)
// pixaConvertToPdf(pixa, res, scalefactor, type, quality, title, fileout) as int
// pixaConvertToPdf(PIXA *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
///  <summary>
/// (1) The images are encoded with G4 if 1 bpp JPEG if 8 bpp without
/// colormap and many colors, or 32 bpp FLATE for anything else.<para/>
/// 
/// (2) The scalefactor must be  is greater  0.0 otherwise it is set to 1.0.<para/>
/// 
/// (3) Specifying one of the three encoding types for %type forces
/// all images to be compressed with that type.  Use 0 to have
/// the type determined for each image based on depth and whether
/// or not it has a colormap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertToPdf/*"/>
///  <param name="pixa">[in] - containing images all at the same resolution</param>
///  <param name="res">[in] - override the resolution of each input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaConvertToPdf(
				 Pixa pixa, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 String title, 
				 String fileout){

	int _Result = Natives.pixaConvertToPdf(pixa.Pointer,   res,   scalefactor,   type,   quality,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (804, 1)
// pixaConvertToPdfData(pixa, res, scalefactor, type, quality, title, pdata, pnbytes) as int
// pixaConvertToPdfData(PIXA *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) See pixaConvertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertToPdfData/*"/>
///  <param name="pixa">[in] - containing images all at the same resolution</param>
///  <param name="res">[in] - input resolution of all images</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="pdata">[out] - output pdf data (of all images</param>
///  <param name="pnbytes">[out] - size of output pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaConvertToPdfData(
				 Pixa pixa, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixaConvertToPdfData(pixa.Pointer,   res,   scalefactor,   type,   quality,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (950, 1)
// convertToPdf(filein, type, quality, fileout, x, y, res, title, plpd, position) as int
// convertToPdf(const char *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) To wrap only one image in pdf, input %plpd = NULL, and
/// the value of %position will be ignored:
/// convertToPdf(...  type, quality, x, y, res, NULL, 0)<para/>
/// 
/// (2) To wrap multiple images on a single pdf page, this is called
/// once for each successive image.  Do it this way:
/// L_PDF_DATA lpd
/// convertToPdf(...  type, quality, x, y, res, [and]lpd, L_FIRST_IMAGE)
/// convertToPdf(...  type, quality, x, y, res, [and]lpd, L_NEXT_IMAGE)
/// ...
/// convertToPdf(...  type, quality, x, y, res, [and]lpd, L_LAST_IMAGE)
/// This will write the result to the value of %fileout specified
/// in the first call succeeding values of %fileout are ignored.
/// On the last call: the pdf data bytes are computed and written
/// to %fileout, lpd is destroyed internally, and the returned
/// value of lpd is null.  So the client has nothing to clean up.<para/>
/// 
/// (3) (a) Set %res == 0 to respect the resolution embedded in the
/// image file.  If no resolution is embedded, it will be set
/// to the default value.
/// (b) Set %res to some other value to override the file resolution.<para/>
/// 
/// (4) (a) If the input %res and the resolution of the output device
/// are equal, the image will be "displayed" at the same size
/// as the original.
/// (b) If the input %res is 72, the output device will render
/// the image at 1 pt/pixel.
/// (c) Some possible choices for the default input pix resolution are:
/// 72 ppi Render pix on any output device at one pt/pixel
/// 96 ppi Windows default for generated display images
/// 300 ppi Typical default for scanned images.
/// We choose 300, which is sensible for rendering page images.
/// However,  images come from a variety of sources, and
/// some are explicitly created for viewing on a display.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPdf/*"/>
///  <param name="filein">[in] - input image file -- any format</param>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="fileout">[in] - output pdf file only required on last image on page</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title if null, taken from filein</param>
///  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertToPdf(
				 String filein, 
				 int type, 
				 int quality, 
				 String fileout, 
				 int x, 
				 int y, 
				 int res, 
				 String title, 
				ref L_Pdf_Data plpd, 
				 int position){

	IntPtr plpdPtr = IntPtr.Zero; 	if (plpd != null) {plpdPtr = plpd.Pointer;}

	int _Result = Natives.convertToPdf(  filein,   type,   quality,   fileout,   x,   y,   res,   title, ref plpdPtr,   position);
	

	if (plpdPtr == null) {plpd = null;} else { plpd = new L_Pdf_Data(plpdPtr); };


	return _Result;
}

// pdfio1.c (1021, 1)
// convertImageDataToPdf(imdata, size, type, quality, fileout, x, y, res, title, plpd, position) as int
// convertImageDataToPdf(l_uint8 *, size_t, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) If %res == 0 and the input resolution field is 0,
/// this will use DEFAULT_INPUT_RES.<para/>
/// 
/// (2) See comments in convertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertImageDataToPdf/*"/>
///  <param name="imdata">[in] - array of formatted image data e.g., png, jpeg</param>
///  <param name="size">[in] - size of image data</param>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="fileout">[in] - output pdf file only required on last image on page</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertImageDataToPdf(
				 Byte[] imdata, 
				 uint size, 
				 int type, 
				 int quality, 
				 String fileout, 
				 int x, 
				 int y, 
				 int res, 
				 String title, 
				ref L_Pdf_Data plpd, 
				 int position){

	IntPtr plpdPtr = IntPtr.Zero; 	if (plpd != null) {plpdPtr = plpd.Pointer;}

	int _Result = Natives.convertImageDataToPdf(  imdata,   size,   type,   quality,   fileout,   x,   y,   res,   title, ref plpdPtr,   position);
	

	if (plpdPtr == null) {plpd = null;} else { plpd = new L_Pdf_Data(plpdPtr); };


	return _Result;
}

// pdfio1.c (1086, 1)
// convertToPdfData(filein, type, quality, pdata, pnbytes, x, y, res, title, plpd, position) as int
// convertToPdfData(const char *, l_int32, l_int32, l_uint8 **, size_t *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) If %res == 0 and the input resolution field is 0,
/// this will use DEFAULT_INPUT_RES.<para/>
/// 
/// (2) See comments in convertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPdfData/*"/>
///  <param name="filein">[in] - input image file -- any format</param>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="pdata">[out] - pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title if null, use filein</param>
///  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertToPdfData(
				 String filein, 
				 int type, 
				 int quality, 
				out Byte[] pdata, 
				out uint pnbytes, 
				 int x, 
				 int y, 
				 int res, 
				 String title, 
				ref L_Pdf_Data plpd, 
				 int position){

	IntPtr pdataPtr = IntPtr.Zero;
	IntPtr plpdPtr = IntPtr.Zero; 	if (plpd != null) {plpdPtr = plpd.Pointer;}

	int _Result = Natives.convertToPdfData(  filein,   type,   quality, out  pdataPtr, out  pnbytes,   x,   y,   res,   title, ref plpdPtr,   position);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };
	if (plpdPtr == null) {plpd = null;} else { plpd = new L_Pdf_Data(plpdPtr); };


	return _Result;
}

// pdfio1.c (1154, 1)
// convertImageDataToPdfData(imdata, size, type, quality, pdata, pnbytes, x, y, res, title, plpd, position) as int
// convertImageDataToPdfData(l_uint8 *, size_t, l_int32, l_int32, l_uint8 **, size_t *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) If %res == 0 and the input resolution field is 0,
/// this will use DEFAULT_INPUT_RES.<para/>
/// 
/// (2) See comments in convertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertImageDataToPdfData/*"/>
///  <param name="imdata">[in] - array of formatted image data e.g., png, jpeg</param>
///  <param name="size">[in] - size of image data</param>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="pdata">[out] - pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="plpd">[out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertImageDataToPdfData(
				 Byte[] imdata, 
				 uint size, 
				 int type, 
				 int quality, 
				out Byte[] pdata, 
				out uint pnbytes, 
				 int x, 
				 int y, 
				 int res, 
				 String title, 
				out L_Pdf_Data plpd, 
				 int position){

	IntPtr pdataPtr = IntPtr.Zero;
	IntPtr plpdPtr = IntPtr.Zero;

	int _Result = Natives.convertImageDataToPdfData(  imdata,   size,   type,   quality, out  pdataPtr, out  pnbytes,   x,   y,   res,   title, out plpdPtr,   position);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };
	if (plpdPtr == null) {plpd = null;} else { plpd = new L_Pdf_Data(plpdPtr); };


	return _Result;
}

// pdfio1.c (1223, 1)
// pixConvertToPdf(pix, type, quality, fileout, x, y, res, title, plpd, position) as int
// pixConvertToPdf(PIX *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) If %res == 0 and the input resolution field is 0,
/// this will use DEFAULT_INPUT_RES.<para/>
/// 
/// (2) This only writes data to fileout if it is the last
/// image to be written on the page.<para/>
/// 
/// (3) See comments in convertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToPdf/*"/>
///  <param name="pix">[in] - </param>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="fileout">[in] - output pdf file only required on last image on page</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixConvertToPdf(
				 Pix pix, 
				 int type, 
				 int quality, 
				 String fileout, 
				 int x, 
				 int y, 
				 int res, 
				 String title, 
				ref L_Pdf_Data plpd, 
				 int position){

	IntPtr plpdPtr = IntPtr.Zero; 	if (plpd != null) {plpdPtr = plpd.Pointer;}

	int _Result = Natives.pixConvertToPdf(pix.Pointer,   type,   quality,   fileout,   x,   y,   res,   title, ref plpdPtr,   position);
	

	if (plpdPtr == null) {plpd = null;} else { plpd = new L_Pdf_Data(plpdPtr); };


	return _Result;
}

// pdfio1.c (1286, 1)
// pixWriteStreamPdf(fp, pix, res, title) as int
// pixWriteStreamPdf(FILE *, PIX *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This is the simplest interface for writing a single image
/// with pdf encoding to a stream.  It uses G4 encoding for 1 bpp,
/// JPEG encoding for 8 bpp (no cmap) and 32 bpp, and FLATE
/// encoding for everything else.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPdf/*"/>
///  <param name="fp">[in] - file stream opened for writing</param>
///  <param name="pix">[in] - all depths, cmap OK</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title taken from the first image placed on a page e.g., an input image filename</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteStreamPdf(
				 FILE fp, 
				 Pix pix, 
				 int res, 
				 String title){

	int _Result = Natives.pixWriteStreamPdf(fp.Pointer, pix.Pointer,   res,   title);
	



	return _Result;
}

// pdfio1.c (1335, 1)
// pixWriteMemPdf(pdata, pnbytes, pix, res, title) as int
// pixWriteMemPdf(l_uint8 **, size_t *, PIX *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This is the simplest interface for writing a single image
/// with pdf encoding to memory.  It uses G4 encoding for 1 bpp,
/// JPEG encoding for 8 bpp (no cmap) and 32 bpp, and FLATE
/// encoding for everything else.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPdf/*"/>
///  <param name="pdata">[out] - pdf as byte array</param>
///  <param name="pnbytes">[out] - number of bytes in pdf array</param>
///  <param name="pix">[in] - all depths, cmap OK</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title taken from the first image placed on a page e.g., an input image filename</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteMemPdf(
				out Byte[] pdata, 
				out uint pnbytes, 
				 Pix pix, 
				 int res, 
				 String title){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemPdf(out  pdataPtr, out  pnbytes, pix.Pointer,   res,   title);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (1415, 1)
// convertSegmentedFilesToPdf(dirname, substr, res, type, thresh, baa, quality, scalefactor, title, fileout) as int
// convertSegmentedFilesToPdf(const char *, const char *, l_int32, l_int32, l_int32, BOXAA *, l_int32, l_float32, const char *, const char *) as l_ok
///  <summary>
/// (1) If %substr is not NULL, only image filenames that contain
/// the substring can be used.  If %substr == NULL, all files
/// in the directory are used.<para/>
/// 
/// (2) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order
/// before concatenation.<para/>
/// 
/// (3) The images are encoded with G4 if 1 bpp JPEG if 8 bpp without
/// colormap and many colors, or 32 bpp FLATE for anything else.<para/>
/// 
/// (4) The boxaa, if it exists, contains one boxa of "image regions"
/// for each image file.  The boxa must be aligned with the
/// sorted set of images.<para/>
/// 
/// (5) The scalefactor is applied to each image region.  It is
/// typically  is smaller 1.0, to save bytes in the final pdf, because
/// the resolution is often not critical in non-text regions.<para/>
/// 
/// (6) If the non-image regions have pixel depth  is greater  1 and the encoding
/// type is G4, they are automatically scaled up by 2x and
/// thresholded.  Otherwise, no scaling is performed on them.<para/>
/// 
/// (7) Note that this function can be used to generate multipage
/// G4 compressed pdf from any input, by using %boxaa == NULL
/// and %type == L_G4_ENCODE.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertSegmentedFilesToPdf/*"/>
///  <param name="dirname">[in] - directory name containing images</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="res">[in] - input resolution of all images</param>
///  <param name="type">[in] - compression type for non-image regions the image regions are always compressed with L_JPEG_ENCODE</param>
///  <param name="thresh">[in] - used for converting gray to 1 bpp with L_G4_ENCODE</param>
///  <param name="baa">[in][optional] - boxaa of image regions</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image region</param>
///  <param name="title">[in][optional] - pdf title if null, taken from the first image filename</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertSegmentedFilesToPdf(
				 String dirname, 
				 String substr, 
				 int res, 
				 int type, 
				 int thresh, 
				 Boxaa baa, 
				 int quality, 
				 Single scalefactor, 
				 String title, 
				 String fileout){

	IntPtr baaPtr = IntPtr.Zero; 	if (baa != null) {baaPtr = baa.Pointer;}

	int _Result = Natives.convertSegmentedFilesToPdf(  dirname,   substr,   res,   type,   thresh, baaPtr,   quality,   scalefactor,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (1535, 1)
// convertNumberedMasksToBoxaa(dirname, substr, numpre, numpost) as Boxaa
// convertNumberedMasksToBoxaa(const char *, const char *, l_int32, l_int32) as BOXAA *
///  <summary>
/// (1) This is conveniently used to generate the input boxaa
/// for convertSegmentedFilesToPdf().  It guarantees that the
/// boxa will be aligned with the page images, even if some
/// of the boxa are empty.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertNumberedMasksToBoxaa/*"/>
///  <param name="dirname">[in] - directory name containing mask images</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="numpre">[in] - number of characters in name before number</param>
///  <param name="numpost">[in] - number of characters in name after number, up to a dot before an extension including an extension and the dot separator</param>
///   <returns>boxaa of mask regions, or NULL on error</returns>
public static Boxaa convertNumberedMasksToBoxaa(
				 String dirname, 
				 String substr, 
				 int numpre, 
				 int numpost){

	IntPtr _Result = Natives.convertNumberedMasksToBoxaa(  dirname,   substr,   numpre,   numpost);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Boxaa(_Result);
}

// pdfio1.c (1644, 1)
// convertToPdfSegmented(filein, res, type, thresh, boxa, quality, scalefactor, title, fileout) as int
// convertToPdfSegmented(const char *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, const char *) as l_ok
///  <summary>
/// (1) If there are no image regions, set %boxa == NULL
/// %quality and %scalefactor are ignored.<para/>
/// 
/// (2) Typically, %scalefactor is  is smaller 1.0, because the image regions
/// can be rendered at a lower resolution (for better compression)
/// than the text regions.  If %scalefactor == 0, we use 1.0.
/// If the input image is 1 bpp and scalefactor  is smaller 1.0, we
/// use scaleToGray() to downsample the image regions to gray
/// before compressing them.<para/>
/// 
/// (3) If the compression type for non-image regions is L_G4_ENCODE
/// and bpp  is greater  1, the image is upscaled 2x and thresholded
/// to 1 bpp.  That is the only situation where %thresh is used.<para/>
/// 
/// (4) The parameter %quality is only used for image regions.
/// If %type == L_JPEG_ENCODE, default jpeg quality (75) is
/// used for the non-image regions.<para/>
/// 
/// (5) Processing matrix for non-image regions.
/// Input   G4  JPEG  FLATE
/// ----------|---------------------------------------------------
/// 1 bpp |  1x, 1 bpp 1x flate, 1 bpp 1x, 1 bpp
/// |
/// cmap  |  2x, 1 bpp 1x flate, cmap  1x, cmap
/// |
/// 2,4 bpp |  2x, 1 bpp 1x flate  1x, 2,4 bpp
/// no cmap |  2,4 bpp
/// |
/// 8,32 bpp  |  2x, 1 bpp 1x (jpeg)   1x, 8,32 bpp
/// no cmap |  8,32 bpp
/// Summary:
/// (a) if G4 is requested, G4 is used, with 2x upscaling
/// for all cases except 1 bpp.
/// (b) if JPEG is requested, use flate encoding for all cases
/// except 8 bpp without cmap and 32 bpp (rgb).
/// (c) if FLATE is requested, use flate with no transformation
/// of the raster data.<para/>
/// 
/// (6) Calling options/sequence for these functions:
/// file  to  file  (convertToPdfSegmented)
/// pix  to  file  (pixConvertToPdfSegmented)
/// pix  to  data  (pixConvertToPdfDataSegmented)
/// file  to  data  (convertToPdfDataSegmented)
/// pix  to  data  (pixConvertToPdfDataSegmented)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPdfSegmented/*"/>
///  <param name="filein">[in] - input image file -- any format</param>
///  <param name="res">[in] - input image resolution typ. 300 ppi use 0 for default</param>
///  <param name="type">[in] - compression type for non-image regions the image regions are always compressed with L_JPEG_ENCODE</param>
///  <param name="thresh">[in] - used for converting gray to 1 bpp with L_G4_ENCODE</param>
///  <param name="boxa">[in][optional] - of image regions can be null</param>
///  <param name="quality">[in] - used for jpeg image regions 0 for default</param>
///  <param name="scalefactor">[in] - used for jpeg regions must be smaller or equal 1.0</param>
///  <param name="title">[in][optional] - pdf title typically taken from the input file for the pix</param>
///  <param name="fileout">[in] - output pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertToPdfSegmented(
				 String filein, 
				 int res, 
				 int type, 
				 int thresh, 
				 Boxa boxa, 
				 int quality, 
				 Single scalefactor, 
				 String title, 
				 String fileout){

	IntPtr boxaPtr = IntPtr.Zero; 	if (boxa != null) {boxaPtr = boxa.Pointer;}

	int _Result = Natives.convertToPdfSegmented(  filein,   res,   type,   thresh, boxaPtr,   quality,   scalefactor,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (1704, 1)
// pixConvertToPdfSegmented(pixs, res, type, thresh, boxa, quality, scalefactor, title, fileout) as int
// pixConvertToPdfSegmented(PIX *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, const char *) as l_ok
///  <summary>
/// (1) See convertToPdfSegmented() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToPdfSegmented/*"/>
///  <param name="pixs">[in] - any depth, cmap OK</param>
///  <param name="res">[in] - input image resolution typ. 300 ppi use 0 for default</param>
///  <param name="type">[in] - compression type for non-image regions the image regions are always compressed with L_JPEG_ENCODE</param>
///  <param name="thresh">[in] - used for converting gray to 1 bpp with L_G4_ENCODE</param>
///  <param name="boxa">[in][optional] - of image regions can be null</param>
///  <param name="quality">[in] - used for jpeg image regions 0 for default</param>
///  <param name="scalefactor">[in] - used for jpeg regions must be smaller or equal 1.0</param>
///  <param name="title">[in][optional] - pdf title typically taken from the input file for the pix</param>
///  <param name="fileout">[in] - output pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixConvertToPdfSegmented(
				 Pix pixs, 
				 int res, 
				 int type, 
				 int thresh, 
				 Boxa boxa, 
				 int quality, 
				 Single scalefactor, 
				 String title, 
				 String fileout){

	IntPtr boxaPtr = IntPtr.Zero; 	if (boxa != null) {boxaPtr = boxa.Pointer;}

	int _Result = Natives.pixConvertToPdfSegmented(pixs.Pointer,   res,   type,   thresh, boxaPtr,   quality,   scalefactor,   title,   fileout);
	



	return _Result;
}

// pdfio1.c (1767, 1)
// convertToPdfDataSegmented(filein, res, type, thresh, boxa, quality, scalefactor, title, pdata, pnbytes) as int
// convertToPdfDataSegmented(const char *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) If there are no image regions, set %boxa == NULL
/// %quality and %scalefactor are ignored.<para/>
/// 
/// (2) Typically, %scalefactor is  is smaller 1.0.  The image regions are
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPdfDataSegmented/*"/>
///  <param name="filein">[in] - input image file -- any format</param>
///  <param name="res">[in] - input image resolution typ. 300 ppi use 0 for default</param>
///  <param name="type">[in] - compression type for non-image regions the image regions are always compressed with L_JPEG_ENCODE</param>
///  <param name="thresh">[in] - used for converting gray to 1 bpp with L_G4_ENCODE</param>
///  <param name="boxa">[in][optional] - image regions can be null</param>
///  <param name="quality">[in] - used for jpeg image regions 0 for default</param>
///  <param name="scalefactor">[in] - used for jpeg regions must be smaller or equal 1.0</param>
///  <param name="title">[in][optional] - pdf title if null, uses filein</param>
///  <param name="pdata">[out] - pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertToPdfDataSegmented(
				 String filein, 
				 int res, 
				 int type, 
				 int thresh, 
				 Boxa boxa, 
				 int quality, 
				 Single scalefactor, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr boxaPtr = IntPtr.Zero; 	if (boxa != null) {boxaPtr = boxa.Pointer;}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.convertToPdfDataSegmented(  filein,   res,   type,   thresh, boxaPtr,   quality,   scalefactor,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (1834, 1)
// pixConvertToPdfDataSegmented(pixs, res, type, thresh, boxa, quality, scalefactor, title, pdata, pnbytes) as int
// pixConvertToPdfDataSegmented(PIX *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) See convertToPdfSegmented() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToPdfDataSegmented/*"/>
///  <param name="pixs">[in] - any depth, cmap OK</param>
///  <param name="res">[in] - input image resolution typ. 300 ppi use 0 for default</param>
///  <param name="type">[in] - compression type for non-image regions the image regions are always compressed with L_JPEG_ENCODE</param>
///  <param name="thresh">[in] - used for converting gray to 1 bpp with L_G4_ENCODE</param>
///  <param name="boxa">[in][optional] - of image regions can be null</param>
///  <param name="quality">[in] - used for jpeg image regions 0 for default</param>
///  <param name="scalefactor">[in] - used for jpeg regions must be smaller or equal 1.0</param>
///  <param name="title">[in][optional] - pdf title typically taken from the input file for the pix</param>
///  <param name="pdata">[out] - pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixConvertToPdfDataSegmented(
				 Pix pixs, 
				 int res, 
				 int type, 
				 int thresh, 
				 Boxa boxa, 
				 int quality, 
				 Single scalefactor, 
				 String title, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr boxaPtr = IntPtr.Zero; 	if (boxa != null) {boxaPtr = boxa.Pointer;}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixConvertToPdfDataSegmented(pixs.Pointer,   res,   type,   thresh, boxaPtr,   quality,   scalefactor,   title, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (1998, 1)
// concatenatePdf(dirname, substr, fileout) as int
// concatenatePdf(const char *, const char *, const char *) as l_ok
///  <summary>
/// (1) This only works with leptonica-formatted single-page pdf files.<para/>
/// 
/// (2) If %substr is not NULL, only filenames that contain
/// the substring can be returned.  If %substr == NULL,
/// none of the filenames are filtered out.<para/>
/// 
/// (3) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order
/// before concatenation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/concatenatePdf/*"/>
///  <param name="dirname">[in] - directory name containing single-page pdf files</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="fileout">[in] - concatenated pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int concatenatePdf(
				 String dirname, 
				 String substr, 
				 String fileout){

	int _Result = Natives.concatenatePdf(  dirname,   substr,   fileout);
	



	return _Result;
}

// pdfio1.c (2033, 1)
// saConcatenatePdf(sa, fileout) as int
// saConcatenatePdf(SARRAY *, const char *) as l_ok
///  <summary>
/// (1) This only works with leptonica-formatted single-page pdf files.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConcatenatePdf/*"/>
///  <param name="sa">[in] - string array of pathnames for single-page pdf files</param>
///  <param name="fileout">[in] - concatenated pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConcatenatePdf(
				 Sarray sa, 
				 String fileout){

	int _Result = Natives.saConcatenatePdf(sa.Pointer,   fileout);
	



	return _Result;
}

// pdfio1.c (2069, 1)
// ptraConcatenatePdf(pa, fileout) as int
// ptraConcatenatePdf(L_PTRA *, const char *) as l_ok
///  <summary>
/// (1) This only works with leptonica-formatted single-page pdf files.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraConcatenatePdf/*"/>
///  <param name="pa">[in] - array of pdf strings, each for a single-page pdf file</param>
///  <param name="fileout">[in] - concatenated pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptraConcatenatePdf(
				 L_Ptra pa, 
				 String fileout){

	int _Result = Natives.ptraConcatenatePdf(pa.Pointer,   fileout);
	



	return _Result;
}

// pdfio1.c (2113, 1)
// concatenatePdfToData(dirname, substr, pdata, pnbytes) as int
// concatenatePdfToData(const char *, const char *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) This only works with leptonica-formatted single-page pdf files.<para/>
/// 
/// (2) If %substr is not NULL, only filenames that contain
/// the substring can be returned.  If %substr == NULL,
/// none of the filenames are filtered out.<para/>
/// 
/// (3) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order
/// before concatenation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/concatenatePdfToData/*"/>
///  <param name="dirname">[in] - directory name containing single-page pdf files</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="pdata">[out] - concatenated pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int concatenatePdfToData(
				 String dirname, 
				 String substr, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.concatenatePdfToData(  dirname,   substr, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

// pdfio1.c (2154, 1)
// saConcatenatePdfToData(sa, pdata, pnbytes) as int
// saConcatenatePdfToData(SARRAY *, l_uint8 **, size_t *) as l_ok
///  <summary>
/// (1) This only works with leptonica-formatted single-page pdf files.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/saConcatenatePdfToData/*"/>
///  <param name="sa">[in] - string array of pathnames for single-page pdf files</param>
///  <param name="pdata">[out] - concatenated pdf data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in pdf data</param>
///   <returns>0 if OK, 1 on error</returns>
public static int saConcatenatePdfToData(
				 Sarray sa, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.saConcatenatePdfToData(sa.Pointer, out  pdataPtr, out  pnbytes);
	

	if (pdataPtr == null) {pdata = null;} else { pdata = null; };


	return _Result;
}

}
}
