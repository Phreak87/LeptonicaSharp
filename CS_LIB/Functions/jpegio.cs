using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// jpegio.c (214, 1)
		// pixReadJpeg(filename, cmapflag, reduction, pnwarn, hint) as Pix
		// pixReadJpeg(const char *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
		///  <summary>
		/// (1) This is a special function for reading jpeg files.<para/>
		///
		/// (2) Use this if you want the jpeg library to create
		/// an 8 bpp colormapped image.<para/>
		///
		/// (3) Images reduced by factors of 2, 4 or 8 can be returned
		/// significantly faster than full resolution images.<para/>
		///
		/// (4) If the jpeg data is bad, the jpeg library will continue
		/// silently, or return warnings, or attempt to exit.  Depending
		/// on the severity of the data corruption, there are two possible
		/// outcomes:
		/// (a) a possibly damaged pix can be generated, along with zero
		/// or more warnings, or
		/// (b) the library will attempt to exit (caught by our error
		/// handler) and no pix will be returned.
		/// If a pix is generated with at least one warning of data
		/// corruption, and if L_JPEG_FAIL_ON_BAD_DATA is included in %hint,
		/// no pix will be returned.<para/>
		///
		/// (5) The possible hint values are given in the enum in imageio.h:
		/// L_JPEG_READ_LUMINANCE
		/// L_JPEG_FAIL_ON_BAD_DATA
		/// Default (0) is to do neither.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadJpeg/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="cmapflag">[in] - 0 for no colormap in returned pix 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
		///  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
		///  <param name="pnwarn">[out][optional] - number of warnings about corrupted data</param>
		///  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixReadJpeg(
						String filename,
						int cmapflag,
						int reduction,
						out int pnwarn,
						int hint = 0)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("scaling factor: 1, 2, 4 or 8");}

			IntPtr _Result = Natives.pixReadJpeg(  filename,   cmapflag,   reduction, out  pnwarn,   hint);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jpegio.c (270, 1)
		// pixReadStreamJpeg(fp, cmapflag, reduction, pnwarn, hint) as Pix
		// pixReadStreamJpeg(FILE *, l_int32, l_int32, l_int32 *, l_int32) as PIX *
		///  <summary>
		/// (1) The jpeg comment, if it exists, is not stored in the pix.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamJpeg/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="cmapflag">[in] - 0 for no colormap in returned pix 1 to return an 8 bpp cmapped pix if spp = 3 or 4</param>
		///  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
		///  <param name="pnwarn">[out][optional] - number of warnings</param>
		///  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
		///   <returns>pix, or NULL on error Usage: see pixReadJpeg</returns>
		public static Pix pixReadStreamJpeg(
						FILE fp,
						int cmapflag,
						int reduction,
						out int pnwarn,
						int hint = 0)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("scaling factor: 1, 2, 4 or 8");}

			IntPtr _Result = Natives.pixReadStreamJpeg(fp.Pointer,   cmapflag,   reduction, out  pnwarn,   hint);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jpegio.c (507, 1)
		// readHeaderJpeg(filename, pw, ph, pspp, pycck, pcmyk) as int
		// readHeaderJpeg(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// readHeaderJpeg()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderJpeg/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pw">[out][optional] - </param>
		///  <param name="ph">[out][optional] - </param>
		///  <param name="pspp">[out][optional] - samples/pixel</param>
		///  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
		///  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int readHeaderJpeg(
						String filename,
						out int pw,
						out int ph,
						out int pspp,
						out int pycck,
						out int pcmyk)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			int _Result = Natives.readHeaderJpeg(  filename, out  pw, out  ph, out  pspp, out  pycck, out  pcmyk);

			return _Result;
		}

		// jpegio.c (549, 1)
		// freadHeaderJpeg(fp, pw, ph, pspp, pycck, pcmyk) as int
		// freadHeaderJpeg(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// freadHeaderJpeg()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderJpeg/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pw">[out][optional] - </param>
		///  <param name="ph">[out][optional] - </param>
		///  <param name="pspp">[out][optional] - samples/pixel</param>
		///  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
		///  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int freadHeaderJpeg(
						FILE fp,
						out int pw,
						out int ph,
						out int pspp,
						out int pycck,
						out int pcmyk)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			int _Result = Natives.freadHeaderJpeg(fp.Pointer, out  pw, out  ph, out  pspp, out  pycck, out  pcmyk);
			return _Result;
		}

		// jpegio.c (618, 1)
		// fgetJpegResolution(fp, pxres, pyres) as int
		// fgetJpegResolution(FILE *, l_int32 *, l_int32 *) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetJpegResolution/*"/>
		///   <returns></returns>
		public static int fgetJpegResolution(
						FILE fp,
						object pxres,
						object pyres)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pxres == null) {throw new ArgumentNullException  ("pxres cannot be Nothing");}

			if (pyres == null) {throw new ArgumentNullException  ("pyres cannot be Nothing");}

			IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
			int _Result = Natives.fgetJpegResolution(fp.Pointer,   pxres,   pyres);
			return _Result;
		}

		// jpegio.c (678, 1)
		// fgetJpegComment(fp, pcomment) as int
		// fgetJpegComment(FILE *, l_uint8 **) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetJpegComment/*"/>
		///   <returns></returns>
		public static int fgetJpegComment(
						FILE fp,
						object pcomment)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pcomment == null) {throw new ArgumentNullException  ("pcomment cannot be Nothing");}

			IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
			int _Result = Natives.fgetJpegComment(fp.Pointer,   pcomment);
			return _Result;
		}

		// jpegio.c (732, 1)
		// pixWriteJpeg(filename, pix, quality, progressive) as int
		// pixWriteJpeg(const char *, PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// pixWriteJpeg()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteJpeg/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pix">[in] - any depth cmap is OK</param>
		///  <param name="quality">[in] - 1 - 100 75 is default</param>
		///  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixWriteJpeg(
						String filename,
						Pix pix,
						int quality = 0,
						int progressive = 0)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixWriteJpeg(  filename, pix.Pointer,   quality,   progressive);
			return _Result;
		}

		// jpegio.c (793, 1)
		// pixWriteStreamJpeg(fp, pixs, quality, progressive) as int
		// pixWriteStreamJpeg(FILE *, PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) Progressive encoding gives better compression, at the
		/// expense of slower encoding and decoding.<para/>
		///
		/// (2) Standard chroma subsampling is 2x2 on both the U and V
		/// channels.  For highest quality, use no subsampling this
		/// option is set by pixSetChromaSampling(pix, 0).<para/>
		///
		/// (3) The only valid pixel depths in leptonica are 1, 2, 4, 8, 16
		/// and 32 bpp.  However, it is possible, and in some cases desirable,
		/// to write out a jpeg file using an rgb pix that has 24 bpp.
		/// This can be created by appending the raster data for a 24 bpp
		/// image (with proper scanline padding) directly to a 24 bpp
		/// pix that was created without a data array.<para/>
		///
		/// (4) There are two compression paths in this function:
		/// Grayscale image, no colormap: compress as 8 bpp image.
		/// rgb full color image: copy each line into the color
		/// line buffer, and compress as three 8 bpp images.<para/>
		///
		/// (5) Under the covers, the jpeg library transforms rgb to a
		/// luminance-chromaticity triple, each component of which is
		/// also 8 bits, and compresses that.  It uses 2 Huffman tables,
		/// a higher resolution one (with more quantization levels)
		/// for luminosity and a lower resolution one for the chromas.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamJpeg/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pixs">[in] - any depth cmap is OK</param>
		///  <param name="quality">[in] - 1 - 100 75 is default value 0 is also default</param>
		///  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixWriteStreamJpeg(
						FILE fp,
						Pix pixs,
						int quality = 0,
						int progressive = 0)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixWriteStreamJpeg(fp.Pointer, pixs.Pointer,   quality,   progressive);
			return _Result;
		}

		// jpegio.c (991, 1)
		// pixReadMemJpeg(data, size, cmflag, reduction, pnwarn, hint) as Pix
		// pixReadMemJpeg(const l_uint8 *, size_t, l_int32, l_int32, l_int32 *, l_int32) as PIX *
		///  <summary>
		/// (1) The %size byte of %data must be a null character.<para/>
		///
		/// (2) The only hint flag so far is L_JPEG_READ_LUMINANCE,
		/// given in the enum in imageio.h.<para/>
		///
		/// (3) See pixReadJpeg() for usage.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemJpeg/*"/>
		///  <param name="data">[in] - const jpeg-encoded</param>
		///  <param name="size">[in] - of data</param>
		///  <param name="cmflag">[in] - colormap flag 0 means return RGB image if color 1 means create a colormap and return an 8 bpp colormapped image if color</param>
		///  <param name="reduction">[in] - scaling factor: 1, 2, 4 or 8</param>
		///  <param name="pnwarn">[out][optional] - number of warnings</param>
		///  <param name="hint">[in] - a bitwise OR of L_JPEG_ values 0 for default</param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixReadMemJpeg(
						Byte[] data,
						uint size,
						int cmflag,
						int reduction,
						out int pnwarn,
						int hint = 0)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("scaling factor: 1, 2, 4 or 8");}

			IntPtr _Result = Natives.pixReadMemJpeg(  data,   size,   cmflag,   reduction, out  pnwarn,   hint);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jpegio.c (1038, 1)
		// readHeaderMemJpeg(data, size, pw, ph, pspp, pycck, pcmyk) as int
		// readHeaderMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// readHeaderMemJpeg()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemJpeg/*"/>
		///  <param name="data">[in] - const jpeg-encoded</param>
		///  <param name="size">[in] - of data</param>
		///  <param name="pw">[out][optional] - width</param>
		///  <param name="ph">[out][optional] - height</param>
		///  <param name="pspp">[out][optional] - samples/pixel</param>
		///  <param name="pycck">[out][optional] - 1 if ycck color space 0 otherwise</param>
		///  <param name="pcmyk">[out][optional] - 1 if cmyk color space 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int readHeaderMemJpeg(
						Byte[] data,
						uint size,
						out int pw,
						out int ph,
						out int pspp,
						out int pycck,
						out int pcmyk)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			int _Result = Natives.readHeaderMemJpeg(  data,   size, out  pw, out  ph, out  pspp, out  pycck, out  pcmyk);
			return _Result;
		}

		// jpegio.c (1079, 1)
		// readResolutionMemJpeg(data, size, pxres, pyres) as int
		// readResolutionMemJpeg(const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// readResolutionMemJpeg()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readResolutionMemJpeg/*"/>
		///  <param name="data">[in] - const jpeg-encoded</param>
		///  <param name="size">[in] - of data</param>
		///  <param name="pxres">[out][optional] - </param>
		///  <param name="pyres">[out][optional] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int readResolutionMemJpeg(
						Byte[] data,
						uint size,
						out int pxres,
						out int pyres)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			int _Result = Natives.readResolutionMemJpeg(  data,   size, out  pxres, out  pyres);
			return _Result;
		}

		// jpegio.c (1121, 1)
		// pixWriteMemJpeg(pdata, psize, pix, quality, progressive) as int
		// pixWriteMemJpeg(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) See pixWriteStreamJpeg() for usage.  This version writes to
		/// memory instead of to a file stream.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemJpeg/*"/>
		///  <param name="pdata">[out] - data of jpeg compressed image</param>
		///  <param name="psize">[out] - size of returned data</param>
		///  <param name="pix">[in] - any depth cmap is OK</param>
		///  <param name="quality">[in] - 1 - 100 75 is default value 0 is also default</param>
		///  <param name="progressive">[in] - 0 for baseline sequential 1 for progressive</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixWriteMemJpeg(
						out Byte[] pdata,
						out uint psize,
						Pix pix,
						int quality = 0,
						int progressive = 0)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.pixWriteMemJpeg(out  pdataPtr, out  psize, pix.Pointer,   quality,   progressive);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// jpegio.c (1182, 1)
		// pixSetChromaSampling(pix, sampling) as int
		// pixSetChromaSampling(PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) The default is for 2x2 chroma subsampling because the files are
		/// considerably smaller and the appearance is typically satisfactory.
		/// To get full resolution output in the chroma channels for
		/// jpeg writing, call this with %sampling == 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetChromaSampling/*"/>
		///  <param name="pix">[in] - </param>
		///  <param name="sampling">[in] - 1 for subsampling 0 for no subsampling</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSetChromaSampling(
						Pix pix,
						int sampling)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetChromaSampling(pix.Pointer,   sampling);
			return _Result;
		}


	}
}
