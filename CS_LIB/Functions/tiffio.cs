using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// tiffio.c (371, 1)
// pixReadTiff(filename, n) as Pix
// pixReadTiff(const char *, l_int32) as PIX *
///  <summary>
/// (1) This is a version of pixRead(), specialized for tiff
/// files, that allows specification of the page to be returned<para/>
/// 
/// (2) No warning messages on failure, because of how multi-page
/// TIFF reading works. You are supposed to keep trying until
/// it stops working.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadTiff/*"/>
///  <param name="filename">[in] - </param>
///  <param name="n">[in] - page number 0 based</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixReadTiff(
				 String filename, 
				 int n){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.pixReadTiff(  filename,   n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// tiffio.c (408, 1)
// pixReadStreamTiff(fp, n) as Pix
// pixReadStreamTiff(FILE *, l_int32) as PIX *
///  <summary>
/// (1) No warning messages on failure, because of how multi-page
/// TIFF reading works. You are supposed to keep trying until
/// it stops working.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamTiff/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="n">[in] - page number: 0 based</param>
///   <returns>pix, or NULL on error or if there are no more images in the file</returns>
public static Pix pixReadStreamTiff(
				 FILE fp, 
				 int n){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.pixReadStreamTiff(fp.Pointer,   n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// tiffio.c (654, 1)
// pixWriteTiff(filename, pix, comptype, modestr) as int
// pixWriteTiff(const char *, PIX *, l_int32, const char *) as l_ok
///  <summary>
/// (1) For multipage tiff, write the first pix with mode "w" and
/// all subsequent pix with mode "a".<para/>
/// 
/// (2) For multipage tiff, there is considerable overhead in the
/// machinery to append an image and add the directory entry,
/// and the time required for each image increases linearly
/// with the number of images in the file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteTiff/*"/>
///  <param name="filename">[in] - to write to</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///  <param name="modestr">[in] - "a" or "w"</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteTiff(
				 String filename, 
				 Pix pix, 
				 int comptype, 
				 String modestr){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
		if (modestr == null) {throw new ArgumentNullException  ("modestr cannot be Nothing");}
	int _Result = Natives.pixWriteTiff(  filename, pix.Pointer,   comptype,   modestr);
	
	return _Result;
}

// tiffio.c (711, 1)
// pixWriteTiffCustom(filename, pix, comptype, modestr, natags, savals, satypes, nasizes) as int
// pixWriteTiffCustom(const char *, PIX *, l_int32, const char *, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
///  <summary>
/// pixWriteTiffCustom()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteTiffCustom/*"/>
///  <param name="filename">[in] - to write to</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///  <param name="modestr">[in] - "a" or "w"</param>
///  <param name="natags">[in][optional] - NUMA of custom tiff tags</param>
///  <param name="savals">[in][optional] - SARRAY of values</param>
///  <param name="satypes">[in][optional] - SARRAY of types</param>
///  <param name="nasizes">[in][optional] - NUMA of sizes</param>
///   <returns>0 if OK, 1 on error Usage: 1 This writes a page image to a tiff file, with optional extra tags defined in tiff.h 2 For multipage tiff, write the first pix with mode "w" and all subsequent pix with mode "a". 3 For the custom tiff tags: a The three arrays {natags, savals, satypes} must all be either NULL or defined and of equal size. b If they are defined, the tags are an array of integers, the vals are an array of values in string format, and the types are an array of types in string format. c All valid tags are definined in tiff.h. d The types allowed are the set of strings: "char" "l_uint8" "l_uint16" "l_uint32" "l_int32" "l_float64" "l_uint16-l_uint16" note the dash use it between the two l_uint16 vals in the val string Of these, "char" and "l_uint16" are the most commonly used. e The last array, nasizes, is also optional.  It is for tags that take an array of bytes for a value, a number of elements in the array, and a type that is either "char" or "l_uint8" probably either will work. Use NULL if there are no such tags. f VERY IMPORTANT: if there are any tags that require the extra size value, stored in nasizes, they must be written first!</returns>
public static int pixWriteTiffCustom(
				 String filename, 
				 Pix pix, 
				 int comptype, 
				 String modestr, 
				 Numa natags, 
				 Sarray savals, 
				 Sarray satypes, 
				 Numa nasizes){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
		if (modestr == null) {throw new ArgumentNullException  ("modestr cannot be Nothing");}
	IntPtr natagsPtr = IntPtr.Zero; 	if (natags != null) {natagsPtr = natags.Pointer;}
	IntPtr savalsPtr = IntPtr.Zero; 	if (savals != null) {savalsPtr = savals.Pointer;}
	IntPtr satypesPtr = IntPtr.Zero; 	if (satypes != null) {satypesPtr = satypes.Pointer;}
	IntPtr nasizesPtr = IntPtr.Zero; 	if (nasizes != null) {nasizesPtr = nasizes.Pointer;}

	int _Result = Natives.pixWriteTiffCustom(  filename, pix.Pointer,   comptype,   modestr, natagsPtr, savalsPtr, satypesPtr, nasizesPtr);
	
	return _Result;
}

// tiffio.c (770, 1)
// pixWriteStreamTiff(fp, pix, comptype) as int
// pixWriteStreamTiff(FILE *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This writes a single image to a file stream opened for writing.<para/>
/// 
/// (2) For images with bpp  is greater  1, this resets the comptype, if
/// necessary, to write uncompressed data.<para/>
/// 
/// (3) G3 and G4 are only defined for 1 bpp.<para/>
/// 
/// (4) We only allow PACKBITS for bpp = 1, because for bpp  is greater  1
/// it typically expands images that are not synthetically generated.<para/>
/// 
/// (5) G4 compression is typically about twice as good as G3.
/// G4 is excellent for binary compression of text/line-art,
/// but terrible for halftones and dithered patterns.  (In
/// fact, G4 on halftones can give a file that is larger
/// than uncompressed!)  If a binary image has dithered
/// regions, it is usually better to compress with png.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamTiff/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteStreamTiff(
				 FILE fp, 
				 Pix pix, 
				 int comptype){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.pixWriteStreamTiff(fp.Pointer, pix.Pointer,   comptype);
	
	return _Result;
}

// tiffio.c (790, 1)
// pixWriteStreamTiffWA(fp, pix, comptype, modestr) as int
// pixWriteStreamTiffWA(FILE *, PIX *, l_int32, const char *) as l_ok
///  <summary>
/// pixWriteStreamTiffWA()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamTiffWA/*"/>
///  <param name="fp">[in] - file stream opened for append or write</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///  <param name="modestr">[in] - "w" or "a"</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteStreamTiffWA(
				 FILE fp, 
				 Pix pix, 
				 int comptype, 
				 String modestr){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
		if (modestr == null) {throw new ArgumentNullException  ("modestr cannot be Nothing");}
	int _Result = Natives.pixWriteStreamTiffWA(fp.Pointer, pix.Pointer,   comptype,   modestr);
	
	return _Result;
}

// tiffio.c (1177, 1)
// pixReadFromMultipageTiff(fname, poffset) as Pix
// pixReadFromMultipageTiff(const char *, size_t *) as PIX *
///  <summary>
/// (1) This allows overhead for traversal of a multipage tiff file
/// to be linear in the number of images.  This will also work
/// with a singlepage tiff file.<para/>
/// 
/// (2) No TIFF internal data structures are exposed to the caller
/// (thanks to Jeff Breidenbach).<para/>
/// 
/// (3) offset is the byte offset of a particular image in a multipage
/// tiff file. To get the first image in the file, input the
/// special offset value of 0.<para/>
/// 
/// (4) The offset is updated to point to the next image, for a
/// subsequent call.<para/>
/// 
/// (5) On the last image, the offset returned is 0.  Exit the loop
/// when the returned offset is 0.<para/>
/// 
/// (6) For reading a multipage tiff from a memory buffer, see
/// pixReadMemFromMultipageTiff()<para/>
/// 
/// (7) Example usage for reading all the images in the tif file:
/// size_t offset = 0
/// do {
/// Pix pix = pixReadFromMultipageTiff(filename, [and]offset)
/// // do something with pix
/// } while (offset != 0)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadFromMultipageTiff/*"/>
///  <param name="fname">[in] - filename</param>
///  <param name="poffset">[in,out] - set offset to 0 for first image</param>
///   <returns>pix, or NULL on error or if previous call returned the last image</returns>
public static Pix pixReadFromMultipageTiff(
				 String fname, 
				ref Byte[] poffset){

if (fname == null) {throw new ArgumentNullException  ("fname cannot be Nothing");}
if (File.Exists (fname) == false) {   throw new ArgumentException ("File is missing");};
		IntPtr poffsetPtr = 	Marshal.AllocHGlobal(poffset.Length);
		Marshal.Copy(poffset, 0, poffsetPtr, poffset.Length);

	IntPtr _Result = Natives.pixReadFromMultipageTiff(  fname, ref  poffsetPtr);
	
	Byte[] poffsetGen = new Byte[1];
	if (poffsetPtr != IntPtr.Zero) {
	  Marshal.Copy(poffsetPtr, poffsetGen, 0, poffsetGen.Length);
	}
	poffset = poffsetGen;
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// tiffio.c (1226, 1)
// pixaReadMultipageTiff(filename) as Pixa
// pixaReadMultipageTiff(const char *) as PIXA *
///  <summary>
/// pixaReadMultipageTiff()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadMultipageTiff/*"/>
///  <param name="filename">[in] - input tiff file</param>
///   <returns>pixa of page images, or NULL on error</returns>
public static Pixa pixaReadMultipageTiff(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.pixaReadMultipageTiff(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// tiffio.c (1286, 1)
// pixaWriteMultipageTiff(fname, pixa) as int
// pixaWriteMultipageTiff(const char *, PIXA *) as l_ok
///  <summary>
/// (1) The tiff directory overhead is O(n^2).  I have not been
/// able to reduce it to O(n).  The overhead for n = 2000 is
/// about 1 second.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteMultipageTiff/*"/>
///  <param name="fname">[in] - input tiff file</param>
///  <param name="pixa">[in] - any depth colormap will be removed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaWriteMultipageTiff(
				 String fname, 
				 Pixa pixa){

if (fname == null) {throw new ArgumentNullException  ("fname cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaWriteMultipageTiff(  fname, pixa.Pointer);
	
	return _Result;
}

// tiffio.c (1347, 1)
// writeMultipageTiff(dirin, substr, fileout) as int
// writeMultipageTiff(const char *, const char *, const char *) as l_ok
///  <summary>
/// (1) This writes a set of image files in a directory out
/// as a multipage tiff file.  The images can be in any
/// initial file format.<para/>
/// 
/// (2) Images with a colormap have the colormap removed before
/// re-encoding as tiff.<para/>
/// 
/// (3) All images are encoded losslessly.  Those with 1 bpp are
/// encoded 'g4'.  The rest are encoded as 'zip' (flate encoding).
/// Because it is lossless, this is an expensive method for
/// saving most rgb images.<para/>
/// 
/// (4) The tiff directory overhead is quadratic in the number of
/// images.  To avoid this for very large numbers of images to be
/// written, apply the method used in pixaWriteMultipageTiff().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeMultipageTiff/*"/>
///  <param name="dirin">[in] - input directory</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="fileout">[in] - output multipage tiff file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int writeMultipageTiff(
				 String dirin, 
				 String substr, 
				 String fileout){

if (dirin == null) {throw new ArgumentNullException  ("dirin cannot be Nothing");}
		if (fileout == null) {throw new ArgumentNullException  ("fileout cannot be Nothing");}
	int _Result = Natives.writeMultipageTiff(  dirin,   substr,   fileout);
	
	return _Result;
}

// tiffio.c (1383, 1)
// writeMultipageTiffSA(sa, fileout) as int
// writeMultipageTiffSA(SARRAY *, const char *) as l_ok
///  <summary>
/// (1) See writeMultipageTiff()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeMultipageTiffSA/*"/>
///  <param name="sa">[in] - string array of full path names</param>
///  <param name="fileout">[in] - output ps file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int writeMultipageTiffSA(
				 Sarray sa, 
				 String fileout){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (fileout == null) {throw new ArgumentNullException  ("fileout cannot be Nothing");}
	int _Result = Natives.writeMultipageTiffSA(sa.Pointer,   fileout);
	
	return _Result;
}

// tiffio.c (1443, 1)
// fprintTiffInfo(fpout, tiffile) as int
// fprintTiffInfo(FILE *, const char *) as l_ok
///  <summary>
/// fprintTiffInfo()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fprintTiffInfo/*"/>
///  <param name="fpout">[in] - stream for output of tag data</param>
///  <param name="tiffile">[in] - input</param>
///   <returns>0 if OK 1 on error</returns>
public static int fprintTiffInfo(
				 FILE fpout, 
				 String tiffile){

if (fpout == null) {throw new ArgumentNullException  ("fpout cannot be Nothing");}
		if (tiffile == null) {throw new ArgumentNullException  ("tiffile cannot be Nothing");}
	int _Result = Natives.fprintTiffInfo(fpout.Pointer,   tiffile);
	
	return _Result;
}

// tiffio.c (1476, 1)
// tiffGetCount(fp, pn) as int
// tiffGetCount(FILE *, l_int32 *) as l_ok
///  <summary>
/// tiffGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/tiffGetCount/*"/>
///  <param name="fp">[in] - file stream opened for read</param>
///  <param name="pn">[out] - number of images</param>
///   <returns>0 if OK 1 on error</returns>
public static int tiffGetCount(
				 FILE fp, 
				out int pn){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	int _Result = Natives.tiffGetCount(fp.Pointer, out  pn);
	
	return _Result;
}

// tiffio.c (1524, 1)
// getTiffResolution(fp, pxres, pyres) as int
// getTiffResolution(FILE *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If neither resolution field is set, this is not an error
/// the returned resolution values are 0 (designating 'unknown').
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getTiffResolution/*"/>
///  <param name="fp">[in] - file stream opened for read</param>
///  <param name="pxres">[out] - resolution in ppi</param>
///  <param name="pyres">[out] - resolution in ppi</param>
///   <returns>0 if OK 1 on error</returns>
public static int getTiffResolution(
				 FILE fp, 
				out int pxres, 
				out int pyres){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	int _Result = Natives.getTiffResolution(fp.Pointer, out  pxres, out  pyres);
	
	return _Result;
}

// tiffio.c (1621, 1)
// readHeaderTiff(filename, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as int
// readHeaderTiff(const char *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
/// 
/// (2) If %n is equal to or greater than the number of images, returns 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderTiff/*"/>
///  <param name="filename">[in] - </param>
///  <param name="n">[in] - page image number: 0-based</param>
///  <param name="pw">[out][optional] - width</param>
///  <param name="ph">[out][optional] - height</param>
///  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
///  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
///  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
///  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
///  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderTiff(
				 String filename, 
				 int n, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int pres, 
				out int pcmap, 
				out int pformat){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	int _Result = Natives.readHeaderTiff(  filename,   n, out  pw, out  ph, out  pbps, out  pspp, out  pres, out  pcmap, out  pformat);
	
	return _Result;
}

// tiffio.c (1677, 1)
// freadHeaderTiff(fp, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as int
// freadHeaderTiff(FILE *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
/// 
/// (2) If %n is equal to or greater than the number of images, returns 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderTiff/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="n">[in] - page image number: 0-based</param>
///  <param name="pw">[out][optional] - width</param>
///  <param name="ph">[out][optional] - height</param>
///  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
///  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
///  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
///  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
///  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int freadHeaderTiff(
				 FILE fp, 
				 int n, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int pres, 
				out int pcmap, 
				out int pformat){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	int _Result = Natives.freadHeaderTiff(fp.Pointer,   n, out  pw, out  ph, out  pbps, out  pspp, out  pres, out  pcmap, out  pformat);
	
	return _Result;
}

// tiffio.c (1748, 1)
// readHeaderMemTiff(cdata, size, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as int
// readHeaderMemTiff(const l_uint8 *, size_t, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemTiff/*"/>
///  <param name="cdata">[in] - const tiff-encoded</param>
///  <param name="size">[in] - size of data</param>
///  <param name="n">[in] - page image number: 0-based</param>
///  <param name="pw">[out][optional] - width</param>
///  <param name="ph">[out][optional] - height</param>
///  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
///  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
///  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
///  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
///  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderMemTiff(
				 Byte[] cdata, 
				 uint size, 
				 int n, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int pres, 
				out int pcmap, 
				out int pformat){

if (cdata == null) {throw new ArgumentNullException  ("cdata cannot be Nothing");}
	int _Result = Natives.readHeaderMemTiff(  cdata,   size,   n, out  pw, out  ph, out  pbps, out  pspp, out  pres, out  pcmap, out  pformat);
	
	return _Result;
}

// tiffio.c (1883, 1)
// findTiffCompression(fp, pcomptype) as int
// findTiffCompression(FILE *, l_int32 *) as l_ok
///  <summary>
/// (1) The returned compression type is that defined in
/// the enum in imageio.h.  It is not the tiff flag value.<para/>
/// 
/// (2) The compression type is initialized to IFF_UNKNOWN.
/// If it is not one of the specified types, the returned
/// type is IFF_TIFF, which indicates no compression.<para/>
/// 
/// (3) When this function is called, the stream must be at BOF.
/// If the opened stream is to be used again to read the
/// file, it must be rewound to BOF after calling this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findTiffCompression/*"/>
///  <param name="fp">[in] - file stream must be rewound to BOF</param>
///  <param name="pcomptype">[out] - compression type</param>
///   <returns>0 if OK, 1 on error</returns>
public static int findTiffCompression(
				 FILE fp, 
				out int pcomptype){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	int _Result = Natives.findTiffCompression(fp.Pointer, out  pcomptype);
	
	return _Result;
}

// tiffio.c (1968, 1)
// extractG4DataFromFile(filein, pdata, pnbytes, pw, ph, pminisblack) as int
// extractG4DataFromFile(const char *, l_uint8 **, size_t *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// extractG4DataFromFile()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractG4DataFromFile/*"/>
///  <param name="filein">[in] - </param>
///  <param name="pdata">[out] - binary data of ccitt g4 encoded stream</param>
///  <param name="pnbytes">[out] - size of binary data</param>
///  <param name="pw">[out][optional] - image width</param>
///  <param name="ph">[out][optional] - image height</param>
///  <param name="pminisblack">[out][optional] - boolean</param>
///   <returns>0 if OK, 1 on error</returns>
public static int extractG4DataFromFile(
				 String filein, 
				out Byte[] pdata, 
				out uint pnbytes, 
				out int pw, 
				out int ph, 
				out int pminisblack){

if (filein == null) {throw new ArgumentNullException  ("filein cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.extractG4DataFromFile(  filein, out  pdataPtr, out  pnbytes, out  pw, out  ph, out  pminisblack);
	
	Byte[] pdataGen = new Byte[pnbytes];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// tiffio.c (2445, 1)
// pixReadMemTiff(cdata, size, n) as Pix
// pixReadMemTiff(const l_uint8 *, size_t, l_int32) as PIX *
///  <summary>
/// (1) This is a version of pixReadTiff(), where the data is read
/// from a memory buffer and uncompressed.<para/>
/// 
/// (2) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.<para/>
/// 
/// (3) No warning messages on failure, because of how multi-page
/// TIFF reading works. You are supposed to keep trying until
/// it stops working.<para/>
/// 
/// (4) Tiff directory overhead is linear in the input page number.
/// If reading many images, use pixReadMemFromMultipageTiff().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemTiff/*"/>
///  <param name="cdata">[in] - const tiff-encoded</param>
///  <param name="size">[in] - size of cdata</param>
///  <param name="n">[in] - page image number: 0-based</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixReadMemTiff(
				 Byte[] cdata, 
				 uint size, 
				 int n){

if (cdata == null) {throw new ArgumentNullException  ("cdata cannot be Nothing");}
	IntPtr _Result = Natives.pixReadMemTiff(  cdata,   size,   n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// tiffio.c (2510, 1)
// pixReadMemFromMultipageTiff(cdata, size, poffset) as Pix
// pixReadMemFromMultipageTiff(const l_uint8 *, size_t, size_t *) as PIX *
///  <summary>
/// (1) This is a read-from-memory version of pixReadFromMultipageTiff().
/// See that function for usage.<para/>
/// 
/// (2) If reading sequentially from the tiff data, this is more
/// efficient than pixReadMemTiff(), which has an overhead
/// proportional to the image index n.<para/>
/// 
/// (3) Example usage for reading all the images:
/// size_t offset = 0
/// do {
/// Pix pix = pixReadMemFromMultipageTiff(data, size, [and]offset)
/// // do something with pix
/// } while (offset != 0)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemFromMultipageTiff/*"/>
///  <param name="cdata">[in] - const tiff-encoded</param>
///  <param name="size">[in] - size of cdata</param>
///  <param name="poffset">[in,out] - set offset to 0 for first image</param>
///   <returns>pix, or NULL on error or if previous call returned the last image</returns>
public static Pix pixReadMemFromMultipageTiff(
				 Byte[] cdata, 
				 uint size, 
				ref Byte[] poffset){

if (cdata == null) {throw new ArgumentNullException  ("cdata cannot be Nothing");}
		IntPtr poffsetPtr = 	Marshal.AllocHGlobal(poffset.Length);
		Marshal.Copy(poffset, 0, poffsetPtr, poffset.Length);

	IntPtr _Result = Natives.pixReadMemFromMultipageTiff(  cdata,   size, ref  poffsetPtr);
	
	Byte[] poffsetGen = new Byte[size];
	if (poffsetPtr != IntPtr.Zero) {
	  Marshal.Copy(poffsetPtr, poffsetGen, 0, poffsetGen.Length);
	}
	poffset = poffsetGen;
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// tiffio.c (2566, 1)
// pixaReadMemMultipageTiff(data, size) as Pixa
// pixaReadMemMultipageTiff(const l_uint8 *, size_t) as PIXA *
///  <summary>
/// (1) This is an O(n) read-from-memory version of pixaReadMultipageTiff().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadMemMultipageTiff/*"/>
///  <param name="data">[in] - const multiple pages tiff-encoded</param>
///  <param name="size">[in] - size of cdata</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaReadMemMultipageTiff(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.pixaReadMemMultipageTiff(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// tiffio.c (2606, 1)
// pixaWriteMemMultipageTiff(pdata, psize, pixa) as int
// pixaWriteMemMultipageTiff(l_uint8 **, size_t *, PIXA *) as l_ok
///  <summary>
/// (1) fopenTiffMemstream() does not work in append mode, so we
/// must work-around with a temporary file.<para/>
/// 
/// (2) Getting a file stream from
/// open_memstream((char )pdata, psize)
/// does not work with the tiff directory.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteMemMultipageTiff/*"/>
///  <param name="pdata">[out] - const tiff-encoded</param>
///  <param name="psize">[out] - size of data</param>
///  <param name="pixa">[in] - any depth colormap will be removed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaWriteMemMultipageTiff(
				out Byte[] pdata, 
				out uint psize, 
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixaWriteMemMultipageTiff(out  pdataPtr, out  psize, pixa.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// tiffio.c (2672, 1)
// pixWriteMemTiff(pdata, psize, pix, comptype) as int
// pixWriteMemTiff(l_uint8 **, size_t *, PIX *, l_int32) as l_ok
///  <summary>
/// pixWriteMemTiff()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemTiff/*"/>
///  <param name="pdata">[out] - data of tiff compressed image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///   <returns>0 if OK, 1 on error Usage: 1) See pixWriteTiff(.  This version writes to memory instead of to a file.</returns>
public static int pixWriteMemTiff(
				out Byte[] pdata, 
				out uint psize, 
				 Pix pix, 
				 int comptype){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemTiff(out  pdataPtr, out  psize, pix.Pointer,   comptype);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// tiffio.c (2703, 1)
// pixWriteMemTiffCustom(pdata, psize, pix, comptype, natags, savals, satypes, nasizes) as int
// pixWriteMemTiffCustom(l_uint8 **, size_t *, PIX *, l_int32, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
///  <summary>
/// pixWriteMemTiffCustom()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemTiffCustom/*"/>
///  <param name="pdata">[out] - data of tiff compressed image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
///  <param name="natags">[in][optional] - NUMA of custom tiff tags</param>
///  <param name="savals">[in][optional] - SARRAY of values</param>
///  <param name="satypes">[in][optional] - SARRAY of types</param>
///  <param name="nasizes">[in][optional] - NUMA of sizes</param>
///   <returns>0 if OK, 1 on error Usage: 1) See pixWriteTiffCustom(.  This version writes to memory instead of to a file. 2) Use TIFFClose() TIFFCleanup( doesn't free internal memstream.</returns>
public static int pixWriteMemTiffCustom(
				out Byte[] pdata, 
				out uint psize, 
				 Pix pix, 
				 int comptype, 
				 Numa natags, 
				 Sarray savals, 
				 Sarray satypes, 
				 Numa nasizes){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;
	IntPtr natagsPtr = IntPtr.Zero; 	if (natags != null) {natagsPtr = natags.Pointer;}
	IntPtr savalsPtr = IntPtr.Zero; 	if (savals != null) {savalsPtr = savals.Pointer;}
	IntPtr satypesPtr = IntPtr.Zero; 	if (satypes != null) {satypesPtr = satypes.Pointer;}
	IntPtr nasizesPtr = IntPtr.Zero; 	if (nasizes != null) {nasizesPtr = nasizes.Pointer;}

	int _Result = Natives.pixWriteMemTiffCustom(out  pdataPtr, out  psize, pix.Pointer,   comptype, natagsPtr, savalsPtr, satypesPtr, nasizesPtr);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}


}
}
