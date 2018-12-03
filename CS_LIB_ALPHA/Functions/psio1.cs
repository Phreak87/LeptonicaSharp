using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// psio1.c (154, 1)
// convertFilesToPS(dirin, substr, res, fileout) as int
// convertFilesToPS(const char *, const char *, l_int32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesToPS/*"/>
///   <returns></returns>
public static int convertFilesToPS(
				 String dirin, 
				 String substr, 
				 int res, 
				 String fileout){

	int _Result = Natives.convertFilesToPS(  dirin,   substr,   res,   fileout);
	



	return _Result;
}

// psio1.c (201, 1)
// sarrayConvertFilesToPS(sa, res, fileout) as int
// sarrayConvertFilesToPS(SARRAY *, l_int32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayConvertFilesToPS/*"/>
///   <returns></returns>
public static int sarrayConvertFilesToPS(
				 Sarray sa, 
				 int res, 
				 String fileout){

	IntPtr saPtr = IntPtr.Zero; if (sa != null) {saPtr = sa.Pointer;}

	int _Result = Natives.sarrayConvertFilesToPS(sa.Pointer,   res,   fileout);
	



	return _Result;
}

// psio1.c (269, 1)
// convertFilesFittedToPS(dirin, substr, xpts, ypts, fileout) as int
// convertFilesFittedToPS(const char *, const char *, l_float32, l_float32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesFittedToPS/*"/>
///   <returns></returns>
public static int convertFilesFittedToPS(
				 String dirin, 
				 String substr, 
				 Single xpts, 
				 Single ypts, 
				 String fileout){

	int _Result = Natives.convertFilesFittedToPS(  dirin,   substr,   xpts,   ypts,   fileout);
	



	return _Result;
}

// psio1.c (321, 1)
// sarrayConvertFilesFittedToPS(sa, xpts, ypts, fileout) as int
// sarrayConvertFilesFittedToPS(SARRAY *, l_float32, l_float32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayConvertFilesFittedToPS/*"/>
///   <returns></returns>
public static int sarrayConvertFilesFittedToPS(
				 Sarray sa, 
				 Single xpts, 
				 Single ypts, 
				 String fileout){

	IntPtr saPtr = IntPtr.Zero; if (sa != null) {saPtr = sa.Pointer;}

	int _Result = Natives.sarrayConvertFilesFittedToPS(sa.Pointer,   xpts,   ypts,   fileout);
	



	return _Result;
}

// psio1.c (391, 1)
// writeImageCompressedToPSFile(filein, fileout, res, pfirstfile, pindex) as int
// writeImageCompressedToPSFile(const char *, const char *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeImageCompressedToPSFile/*"/>
///   <returns></returns>
public static int writeImageCompressedToPSFile(
				 String filein, 
				 String fileout, 
				 int res, 
				 object pfirstfile, 
				 object pindex){

	int _Result = Natives.writeImageCompressedToPSFile(  filein,   fileout,   res,   pfirstfile,   pindex);
	



	return _Result;
}

// psio1.c (498, 1)
// convertSegmentedPagesToPS(pagedir, pagestr, page_numpre, maskdir, maskstr, mask_numpre, numpost, maxnum, textscale, imagescale, threshold, fileout) as int
// convertSegmentedPagesToPS(const char *, const char *, l_int32, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertSegmentedPagesToPS/*"/>
///   <returns></returns>
public static int convertSegmentedPagesToPS(
				 String pagedir, 
				 String pagestr, 
				 int page_numpre, 
				 String maskdir, 
				 String maskstr, 
				 int mask_numpre, 
				 int numpost, 
				 int maxnum, 
				 Single textscale, 
				 Single imagescale, 
				 int threshold, 
				 String fileout){

	int _Result = Natives.convertSegmentedPagesToPS(  pagedir,   pagestr,   page_numpre,   maskdir,   maskstr,   mask_numpre,   numpost,   maxnum,   textscale,   imagescale,   threshold,   fileout);
	



	return _Result;
}

// psio1.c (596, 1)
// pixWriteSegmentedPageToPS(pixs, pixm, textscale, imagescale, threshold, pageno, fileout) as int
// pixWriteSegmentedPageToPS(PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteSegmentedPageToPS/*"/>
///   <returns></returns>
public static int pixWriteSegmentedPageToPS(
				 Pix pixs, 
				 Pix pixm, 
				 Single textscale, 
				 Single imagescale, 
				 int threshold, 
				 int pageno, 
				 String fileout){

	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}
	IntPtr pixmPtr = IntPtr.Zero; if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixWriteSegmentedPageToPS(pixs.Pointer, pixm.Pointer,   textscale,   imagescale,   threshold,   pageno,   fileout);
	



	return _Result;
}

// psio1.c (747, 1)
// pixWriteMixedToPS(pixb, pixc, scale, pageno, fileout) as int
// pixWriteMixedToPS(PIX *, PIX *, l_float32, l_int32, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMixedToPS/*"/>
///   <returns></returns>
public static int pixWriteMixedToPS(
				 Pix pixb, 
				 Pix pixc, 
				 Single scale, 
				 int pageno, 
				 String fileout){

	IntPtr pixbPtr = IntPtr.Zero; if (pixb != null) {pixbPtr = pixb.Pointer;}
	IntPtr pixcPtr = IntPtr.Zero; if (pixc != null) {pixcPtr = pixc.Pointer;}

	int _Result = Natives.pixWriteMixedToPS(pixb.Pointer, pixc.Pointer,   scale,   pageno,   fileout);
	



	return _Result;
}

// psio1.c (834, 1)
// convertToPSEmbed(filein, fileout, level) as int
// convertToPSEmbed(const char *, const char *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPSEmbed/*"/>
///   <returns></returns>
public static int convertToPSEmbed(
				 String filein, 
				 String fileout, 
				 int level){

	int _Result = Natives.convertToPSEmbed(  filein,   fileout,   level);
	



	return _Result;
}

// psio1.c (935, 1)
// pixaWriteCompressedToPS(pixa, fileout, res, level) as int
// pixaWriteCompressedToPS(PIXA *, const char *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteCompressedToPS/*"/>
///   <returns></returns>
public static int pixaWriteCompressedToPS(
				 Pixa pixa, 
				 String fileout, 
				 int res, 
				 int level){

	IntPtr pixaPtr = IntPtr.Zero; if (pixa != null) {pixaPtr = pixa.Pointer;}

	int _Result = Natives.pixaWriteCompressedToPS(pixa.Pointer,   fileout,   res,   level);
	



	return _Result;
}


}
}
