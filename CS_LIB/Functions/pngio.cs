using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pngio.c (185, 1)
// pixReadStreamPng(fp) as Pix
// pixReadStreamPng(FILE *) as PIX *
///  <summary>
/// (1) If called from pixReadStream(), the stream is positioned
/// at the beginning of the file.<para/>
/// 
/// (2) To do sequential reads of png format images from a stream,
/// use pixReadStreamPng()<para/>
/// 
/// (3) Any image with alpha is converted to RGBA (spp = 4, with
/// equal red, green and blue channels) on reading.
/// There are three important cases with alpha:
/// (a) grayscale-with-alpha (spp = 2), where bpp = 8, and each
/// pixel has an associated alpha (transparency) value
/// in the second component of the image data.
/// (b) spp = 1, d = 1 with colormap and alpha in the trans array.
/// Transparency is usually associated with the white background.
/// (c) spp = 1, d = 8 with colormap and alpha in the trans array.
/// Each color in the colormap has a separate transparency value.<para/>
/// 
/// (4) We use the high level png interface, where the transforms are set
/// up in advance and the header and image are read with a single
/// call.  The more complicated interface, where the header is
/// read first and the buffers for the raster image are user-
/// allocated before reading the image, works for single images,
/// but I could not get it to work properly for the successive
/// png reads that are required by pixaReadStream().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamPng/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixReadStreamPng(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.pixReadStreamPng(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pngio.c (517, 1)
// readHeaderPng(filename, pw, ph, pbps, pspp, piscmap) as int
// readHeaderPng(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, iscmap is returned as 1 else 0.<para/>
/// 
/// (2) For gray+alpha, although the png records bps = 16, we
/// consider this as two 8 bpp samples (gray and alpha).
/// When a gray+alpha is read, it is converted to 32 bpp RGBA.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderPng/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderPng(
				 String filename, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	int _Result = Natives.readHeaderPng(  filename, out  pw, out  ph, out  pbps, out  pspp, out  piscmap);
	
	return _Result;
}

// pngio.c (561, 1)
// freadHeaderPng(fp, pw, ph, pbps, pspp, piscmap) as int
// freadHeaderPng(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) See readHeaderPng().  We only need the first 40 bytes in the file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderPng/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int freadHeaderPng(
				 FILE fp, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	int _Result = Natives.freadHeaderPng(fp.Pointer, out  pw, out  ph, out  pbps, out  pspp, out  piscmap);
	
	return _Result;
}

// pngio.c (618, 1)
// readHeaderMemPng(data, size, pw, ph, pbps, pspp, piscmap) as int
// readHeaderMemPng(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) See readHeaderPng().<para/>
/// 
/// (2) png colortypes (see png.h: PNG_COLOR_TYPE_):
/// 0:  gray fully transparent (with tRNS) (1 spp)
/// 2:  RGB (3 spp)
/// 3:  colormap colormap+alpha (with tRNS) (1 spp)
/// 4:  gray + alpha (2 spp)
/// 6:  RGBA (4 spp)
/// Note:
/// 0 and 3 have the alpha information in a tRNS chunk
/// 4 and 6 have separate alpha samples with each pixel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemPng/*"/>
///  <param name="data">[in] - </param>
///  <param name="size">[in] - 40 bytes is sufficient</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderMemPng(
				 Byte[] data, 
				 uint size, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	int _Result = Natives.readHeaderMemPng(  data,   size, out  pw, out  ph, out  pbps, out  pspp, out  piscmap);
	
	return _Result;
}

// pngio.c (704, 1)
// fgetPngResolution(fp, pxres, pyres) as int
// fgetPngResolution(FILE *, l_int32 *, l_int32 *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetPngResolution/*"/>
///   <returns></returns>
public static int fgetPngResolution(
				 FILE fp, 
				 object pxres, 
				 object pyres){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pxres == null) {throw new ArgumentNullException  ("pxres cannot be Nothing");}
		if (pyres == null) {throw new ArgumentNullException  ("pyres cannot be Nothing");}
	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}

	int _Result = Natives.fgetPngResolution(fp.Pointer,   pxres,   pyres);
	
	return _Result;
}

// pngio.c (761, 1)
// isPngInterlaced(filename, pinterlaced) as int
// isPngInterlaced(const char *, l_int32 *) as l_ok
///  <summary>
/// isPngInterlaced()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/isPngInterlaced/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pinterlaced">[out] - 1 if interlaced png 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int isPngInterlaced(
				 String filename, 
				out int pinterlaced){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	int _Result = Natives.isPngInterlaced(  filename, out  pinterlaced);
	
	return _Result;
}

// pngio.c (805, 1)
// fgetPngColormapInfo(fp, pcmap, ptransparency) as int
// fgetPngColormapInfo(FILE *, PIXCMAP **, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetPngColormapInfo/*"/>
///   <returns></returns>
public static int fgetPngColormapInfo(
				 FILE fp, 
				 PixColormap pcmap, 
				 object ptransparency){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pcmap == null) {throw new ArgumentNullException  ("pcmap cannot be Nothing");}
		if (ptransparency == null) {throw new ArgumentNullException  ("ptransparency cannot be Nothing");}
	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
	IntPtr pcmapPtr = IntPtr.Zero; 	if (pcmap != null) {pcmapPtr = pcmap.Pointer;}

	int _Result = Natives.fgetPngColormapInfo(fp.Pointer, pcmapPtr,   ptransparency);
	
	return _Result;
}

// pngio.c (906, 1)
// pixWritePng(filename, pix, gamma) as int
// pixWritePng(const char *, PIX *, l_float32) as l_ok
///  <summary>
/// (1) Special version for writing png with a specified gamma.
/// When using pixWrite(), no field is given for gamma.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWritePng/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pix">[in] - </param>
///  <param name="gamma">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWritePng(
				 String filename, 
				 Pix pix, 
				 Single gamma){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.pixWritePng(  filename, pix.Pointer,   gamma);
	
	return _Result;
}

// pngio.c (1006, 1)
// pixWriteStreamPng(fp, pix, gamma) as int
// pixWriteStreamPng(FILE *, PIX *, l_float32) as l_ok
///  <summary>
/// (1) If called from pixWriteStream(), the stream is positioned
/// at the beginning of the file.<para/>
/// 
/// (2) To do sequential writes of png format images to a stream,
/// use pixWriteStreamPng() directly.<para/>
/// 
/// (3) gamma is an optional png chunk.  If no gamma value is to be
/// placed into the file, use gamma = 0.0.  Otherwise, if
/// gamma  is greater  0.0, its value is written into the header.<para/>
/// 
/// (4) The use of gamma in png is highly problematic.  For an illuminating
/// discussion, see:  http://hsivonen.iki.fi/png-gamma/<para/>
/// 
/// (5) What is the effect/meaning of gamma in the png file?  This
/// gamma, which we can call the 'source' gamma, is the
/// inverse of the gamma that was used in enhance.c to brighten
/// or darken images.  The 'source' gamma is supposed to indicate
/// the intensity mapping that was done at the time the
/// image was captured.  Display programs typically apply a
/// 'display' gamma of 2.2 to the output, which is intended
/// to linearize the intensity based on the response of
/// thermionic tubes (CRTs).  Flat panel LCDs have typically
/// been designed to give a similar response as CRTs (call it
/// "backward compatibility").  The 'display' gamma is
/// in some sense the inverse of the 'source' gamma.
/// jpeg encoders attached to scanners and cameras will lighten
/// the pixels, applying a gamma corresponding to approximately
/// a square-root relation of output vs input:
/// output = input^(gamma)
/// where gamma is often set near 0.4545  (1/gamma is 2.2).
/// This is stored in the image file.  Then if the display
/// program reads the gamma, it will apply a display gamma,
/// typically about 2.2 the product is 1.0, and the
/// display program produces a linear output.  This works because
/// the dark colors were appropriately boosted by the scanner,
/// as described by the 'source' gamma, so they should not
/// be further boosted by the display program.<para/>
/// 
/// (6) As an example, with xv and display, if no gamma is stored,
/// the program acts as if gamma were 0.4545, multiplies this by 2.2,
/// and does a linear rendering.  Taking this as a baseline
/// brightness, if the stored gamma is:
///  is greater  0.4545, the image is rendered lighter than baseline
///  is smaller 0.4545, the image is rendered darker than baseline
/// In contrast, gqview seems to ignore the gamma chunk in png.<para/>
/// 
/// (7) The only valid pixel depths in leptonica are 1, 2, 4, 8, 16
/// and 32.  However, it is possible, and in some cases desirable,
/// to write out a png file using an rgb pix that has 24 bpp.
/// For example, the open source xpdf SplashBitmap class generates
/// 24 bpp rgb images.  Consequently, we enable writing 24 bpp pix.
/// To generate such a pix, you can make a 24 bpp pix without data
/// and assign the data array to the pix e.g.,
/// pix = pixCreateHeader(w, h, 24)
/// pixSetData(pix, rgbdata)
/// See pixConvert32To24() for an example, where we get rgbdata
/// from the 32 bpp pix.  Caution: do not call pixSetPadBits(),
/// because the alignment is wrong and you may erase part of the
/// last pixel on each line.<para/>
/// 
/// (8) If the pix has a colormap, it is written to file.  In most
/// situations, the alpha component is 255 for each colormap entry,
/// which is opaque and indicates that it should be ignored.
/// However, if any alpha component is not 255, it is assumed that
/// the alpha values are valid, and they are written to the png
/// file in a tRNS segment.  On readback, the tRNS segment is
/// identified, and the colormapped image with alpha is converted
/// to a 4 spp rgba image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPng/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///  <param name="gamma">[in] - use 0.0 if gamma is not defined</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteStreamPng(
				 FILE fp, 
				 Pix pix, 
				 Single gamma){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.pixWriteStreamPng(fp.Pointer, pix.Pointer,   gamma);
	
	return _Result;
}

// pngio.c (1250, 1)
// pixSetZlibCompression(pix, compval) as int
// pixSetZlibCompression(PIX *, l_int32) as l_ok
///  <summary>
/// (1) Valid zlib compression values are in the interval [0 ... 9],
/// where, as defined in zlib.h:
/// 0 Z_NO_COMPRESSION
/// 1 Z_BEST_SPEED  (poorest compression)
/// 9 Z_BEST_COMPRESSION
/// For the default value, use either of these:
/// 6 Z_DEFAULT_COMPRESSION
/// -1 (resolves to Z_DEFAULT_COMPRESSION)<para/>
/// 
/// (2) If you use the defined constants in zlib.h instead of the
/// compression integers given above, you must include zlib.h.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetZlibCompression/*"/>
///  <param name="pix">[in] - </param>
///  <param name="compval">[in] - zlib compression value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSetZlibCompression(
				 Pix pix, 
				 int compval){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.pixSetZlibCompression(pix.Pointer,   compval);
	
	return _Result;
}

// pngio.c (1277, 1)
// l_pngSetReadStrip16To8(flag) as Object
// l_pngSetReadStrip16To8(l_int32) as void
///  <summary>
/// l_pngSetReadStrip16To8()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_pngSetReadStrip16To8/*"/>
///  <param name="flag">[in] - 1 for stripping 16 bpp to 8 bpp on reading 0 for leaving 16 bpp</param>
public static void l_pngSetReadStrip16To8(
				 int flag){

	Natives.l_pngSetReadStrip16To8(  flag);
	
}

// pngio.c (1520, 1)
// pixReadMemPng(filedata, filesize) as Pix
// pixReadMemPng(const l_uint8 *, size_t) as PIX *
///  <summary>
/// (1) See pixReastreamPng().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemPng/*"/>
///  <param name="filedata">[in] - png compressed data in memory</param>
///  <param name="filesize">[in] - number of bytes in data</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixReadMemPng(
				 Byte[] filedata, 
				 uint filesize){

if (filedata == null) {throw new ArgumentNullException  ("filedata cannot be Nothing");}
	IntPtr _Result = Natives.pixReadMemPng(  filedata,   filesize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pngio.c (1858, 1)
// pixWriteMemPng(pfiledata, pfilesize, pix, gamma) as int
// pixWriteMemPng(l_uint8 **, size_t *, PIX *, l_float32) as l_ok
///  <summary>
/// (1) See pixWriteStreamPng()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPng/*"/>
///  <param name="pfiledata">[out] - png encoded data of pix</param>
///  <param name="pfilesize">[out] - size of png encoded data</param>
///  <param name="pix">[in] - </param>
///  <param name="gamma">[in] - use 0.0 if gamma is not defined</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteMemPng(
				out Byte[] pfiledata, 
				out uint pfilesize, 
				 Pix pix, 
				 Single gamma){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr pfiledataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemPng(out  pfiledataPtr, out  pfilesize, pix.Pointer,   gamma);
	
	Byte[] pfiledataGen = new Byte[pfilesize];
	if (pfiledataPtr != IntPtr.Zero) {
	  Marshal.Copy(pfiledataPtr, pfiledataGen, 0, pfiledataGen.Length);
	}
	pfiledata = pfiledataGen;
	return _Result;
}


}
}
