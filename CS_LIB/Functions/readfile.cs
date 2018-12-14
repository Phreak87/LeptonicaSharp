using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// readfile.c (123, 1)
		// pixaReadFiles(dirname, substr) as Pixa
		// pixaReadFiles(const char *, const char *) as PIXA *
		///  <summary>
		/// (1) %dirname is the full path for the directory.<para/>
		///
		/// (2) %substr is the part of the file name (excluding
		/// the directory) that is to be matched.  All matching
		/// filenames are read into the Pixa.  If substr is NULL,
		/// all filenames are read into the Pixa.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadFiles/*"/>
		///  <param name="dirname">[in] - </param>
		///  <param name="substr">[in][optional] - substring filter on filenames can be null</param>
		///   <returns>pixa, or NULL on error</returns>
		public static Pixa pixaReadFiles(
						String dirname,
						String substr = "")
		{
			if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}

			IntPtr _Result = Natives.pixaReadFiles(  dirname,   substr);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixa(_Result);
		}

		// readfile.c (150, 1)
		// pixaReadFilesSA(sa) as Pixa
		// pixaReadFilesSA(SARRAY *) as PIXA *
		///  <summary>
		/// pixaReadFilesSA()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadFilesSA/*"/>
		///  <param name="sa">[in] - full pathnames for all files</param>
		///   <returns>pixa, or NULL on error</returns>
		public static Pixa pixaReadFilesSA(
						Sarray sa)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			IntPtr _Result = Natives.pixaReadFilesSA(sa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixa(_Result);
		}

		// readfile.c (189, 1)
		// pixRead(filename) as Pix
		// pixRead(const char *) as PIX *
		///  <summary>
		/// (1) See at top of file for supported formats.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRead/*"/>
		///  <param name="filename">[in] - with full pathname or in local directory</param>
		///   <returns>pix if OK NULL on error</returns>
		public static Pix pixRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.pixRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// readfile.c (225, 1)
		// pixReadWithHint(filename, hint) as Pix
		// pixReadWithHint(const char *, l_int32) as PIX *
		///  <summary>
		/// (1) The hint is not binding, but may be used to optimize jpeg decoding.
		/// Use 0 for no hinting.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadWithHint/*"/>
		///  <param name="filename">[in] - with full pathname or in local directory</param>
		///  <param name="hint">[in] - bitwise OR of L_HINT_ values for jpeg use 0 for no hint</param>
		///   <returns>pix if OK NULL on error</returns>
		public static Pix pixReadWithHint(
						String filename,
						int hint = 0)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.pixReadWithHint(  filename,   hint);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// readfile.c (276, 1)
		// pixReadIndexed(sa, index) as Pix
		// pixReadIndexed(SARRAY *, l_int32) as PIX *
		///  <summary>
		/// (1) This function is useful for selecting image files from a
		/// directory, where the integer %index is embedded into
		/// the file name.<para/>
		///
		/// (2) This is typically done by generating the sarray using
		/// getNumberedPathnamesInDirectory(), so that the %index
		/// pathname would have the number %index in it.  The size
		/// of the sarray should be the largest number (plus 1) appearing
		/// in the file names, respecting the constraints in the
		/// call to getNumberedPathnamesInDirectory().<para/>
		///
		/// (3) Consequently, for some indices into the sarray, there may
		/// be no pathnames in the directory containing that number.
		/// By convention, we place empty C strings ("") in those
		/// locations in the sarray, and it is not an error if such
		/// a string is encountered and no pix is returned.
		/// Therefore, the caller must verify that a pix is returned.<para/>
		///
		/// (4) See convertSegmentedPagesToPS() in src/psio1.c for an
		/// example of usage.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadIndexed/*"/>
		///  <param name="sa">[in] - string array of full pathnames</param>
		///  <param name="index">[in] - into pathname array</param>
		///   <returns>pix if OK null if not found</returns>
		public static Pix pixReadIndexed(
						Sarray sa,
						int index)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			IntPtr _Result = Natives.pixReadIndexed(sa.Pointer,   index);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// readfile.c (317, 1)
		// pixReadStream(fp, hint) as Pix
		// pixReadStream(FILE *, l_int32) as PIX *
		///  <summary>
		/// (1) The hint only applies to jpeg.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="hint">[in] - bitwise OR of L_HINT_ values for jpeg use 0 for no hint</param>
		///   <returns>pix if OK NULL on error</returns>
		public static Pix pixReadStream(
						FILE fp,
						int hint = 0)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.pixReadStream(fp.Pointer,   hint);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// readfile.c (431, 1)
		// pixReadHeader(filename, pformat, pw, ph, pbps, pspp, piscmap) as int
		// pixReadHeader(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This reads the actual headers for jpeg, png, tiff and pnm.
		/// For bmp and gif, we cheat and read the entire file into a pix,
		/// from which we extract the "header" information.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadHeader/*"/>
		///  <param name="filename">[in] - with full pathname or in local directory</param>
		///  <param name="pformat">[out][optional] - file format</param>
		///  <param name="pw">[out][optional] - width and height</param>
		///  <param name="ph">[out][optional] - width and height</param>
		///  <param name="pbps">[out][optional] - bits/sample</param>
		///  <param name="pspp">[out][optional] - samples/pixel 1, 3 or 4</param>
		///  <param name="piscmap">[out][optional] - 1 if cmap exists 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixReadHeader(
						String filename,
						out int pformat,
						out int pw,
						out int ph,
						out int pbps,
						out int pspp,
						out int piscmap)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			int _Result = Natives.pixReadHeader(  filename, out  pformat, out  pw, out  ph, out  pbps, out  pspp, out  piscmap);

			return _Result;
		}

		// readfile.c (568, 1)
		// findFileFormat(filename, pformat) as int
		// findFileFormat(const char *, l_int32 *) as l_ok
		///  <summary>
		/// findFileFormat()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findFileFormat/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pformat">[out] - found format</param>
		///   <returns>0 if OK, 1 on error or if format is not recognized</returns>
		public static int findFileFormat(
						String filename,
						out int pformat)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			int _Result = Natives.findFileFormat(  filename, out  pformat);

			return _Result;
		}

		// readfile.c (603, 1)
		// findFileFormatStream(fp, pformat) as int
		// findFileFormatStream(FILE *, l_int32 *) as l_ok
		///  <summary>
		/// (1) Important: Side effect -- this resets fp to BOF.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findFileFormatStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pformat">[out] - found format</param>
		///   <returns>0 if OK, 1 on error or if format is not recognized</returns>
		public static int findFileFormatStream(
						FILE fp,
						out int pformat)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			int _Result = Natives.findFileFormatStream(fp.Pointer, out  pformat);
			return _Result;
		}

		// readfile.c (654, 1)
		// findFileFormatBuffer(buf, pformat) as int
		// findFileFormatBuffer(const l_uint8 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This determines the file format from the first 12 bytes in
		/// the compressed data stream, which are stored in memory.<para/>
		///
		/// (2) For tiff files, this returns IFF_TIFF.  The specific tiff
		/// compression is then determined using findTiffCompression().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findFileFormatBuffer/*"/>
		///  <param name="buf">[in] - byte buffer at least 12 bytes in size we can't check</param>
		///  <param name="pformat">[out] - found format</param>
		///   <returns>0 if OK, 1 on error or if format is not recognized</returns>
		public static int findFileFormatBuffer(
						Byte[] buf,
						out int pformat)
		{
			if (buf == null) {throw new ArgumentNullException  ("buf cannot be Nothing");}

			int _Result = Natives.findFileFormatBuffer(  buf, out  pformat);
			return _Result;
		}

		// readfile.c (783, 1)
		// fileFormatIsTiff(fp) as int
		// fileFormatIsTiff(FILE *) as l_int32
		///  <summary>
		/// fileFormatIsTiff()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileFormatIsTiff/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>1 if file is tiff 0 otherwise or on error</returns>
		public static int fileFormatIsTiff(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			int _Result = Natives.fileFormatIsTiff(fp.Pointer);
			return _Result;
		}

		// readfile.c (827, 1)
		// pixReadMem(data, size) as Pix
		// pixReadMem(const l_uint8 *, size_t) as PIX *
		///  <summary>
		/// (1) This is a variation of pixReadStream(), where the data is read
		/// from a memory buffer rather than a file.<para/>
		///
		/// (2) On windows, this only reads tiff formatted files directly from
		/// memory.  For other formats, it writes to a temp file and
		/// decompresses from file.<para/>
		///
		/// (3) findFileFormatBuffer() requires up to 12 bytes to decide on
		/// the format.  That determines the constraint here.  But in
		/// fact the data must contain the entire compressed string for
		/// the image.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMem/*"/>
		///  <param name="data">[in] - const encoded</param>
		///  <param name="size">[in] - size of data</param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.pixReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// readfile.c (948, 1)
		// pixReadHeaderMem(data, size, pformat, pw, ph, pbps, pspp, piscmap) as int
		// pixReadHeaderMem(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This reads the actual headers for jpeg, png, tiff, jp2k and pnm.
		/// For bmp and gif, we cheat and read all the data into a pix,
		/// from which we extract the "header" information.<para/>
		///
		/// (2) The amount of data required depends on the format.  For
		/// png, it requires less than 30 bytes, but for jpeg it can
		/// require most of the compressed file.  In practice, the data
		/// is typically the entire compressed file in memory.<para/>
		///
		/// (3) findFileFormatBuffer() requires up to 8 bytes to decide on
		/// the format, which we require.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadHeaderMem/*"/>
		///  <param name="data">[in] - const encoded</param>
		///  <param name="size">[in] - size of data</param>
		///  <param name="pformat">[out][optional] - image format</param>
		///  <param name="pw">[out][optional] - width and height</param>
		///  <param name="ph">[out][optional] - width and height</param>
		///  <param name="pbps">[out][optional] - bits/sample</param>
		///  <param name="pspp">[out][optional] - samples/pixel 1, 3 or 4</param>
		///  <param name="piscmap">[out][optional] - 1 if cmap exists 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixReadHeaderMem(
						Byte[] data,
						uint size,
						out int pformat,
						out int pw,
						out int ph,
						out int pbps,
						out int pspp,
						out int piscmap)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			int _Result = Natives.pixReadHeaderMem(  data,   size, out  pformat, out  pw, out  ph, out  pbps, out  pspp, out  piscmap);
			return _Result;
		}

		// readfile.c (1094, 1)
		// writeImageFileInfo(filename, fpout, headeronly) as int
		// writeImageFileInfo(const char *, FILE *, l_int32) as l_ok
		///  <summary>
		/// (1) If headeronly == 0 and the image has spp == 4,this will
		/// also call pixDisplayLayersRGBA() to display the image
		/// in three views.<para/>
		///
		/// (2) This is a debug function that changes the value of
		/// var_PNG_STRIP_16_TO_8 to 1 (the default).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeImageFileInfo/*"/>
		///  <param name="filename">[in] - input file</param>
		///  <param name="fpout">[in] - output file stream</param>
		///  <param name="headeronly">[in] - 1 to read only the header 0 to read both the header and the input file</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int writeImageFileInfo(
						String filename,
						FILE fpout,
						int headeronly)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (fpout == null) {throw new ArgumentNullException  ("fpout cannot be Nothing");}

			int _Result = Natives.writeImageFileInfo(  filename, fpout.Pointer,   headeronly);
			return _Result;
		}

		// readfile.c (1262, 1)
		// ioFormatTest(filename) as int
		// ioFormatTest(const char *) as l_ok
		///  <summary>
		/// (1) This writes and reads a set of output files losslessly
		/// in different formats to /tmp/format/, and tests that the
		/// result before and after is unchanged.<para/>
		///
		/// (2) This should work properly on input images of any depth,
		/// with and without colormaps.<para/>
		///
		/// (3) All supported formats are tested for bmp, png, tiff and
		/// non-ascii pnm.  Ascii pnm also works (but who'd ever want
		/// to use it?) We allow 2 bpp bmp, although it's not
		/// supported elsewhere.  And we don't support reading
		/// 16 bpp png, although this can be turned on in pngio.c.<para/>
		///
		/// (4) This silently skips png or tiff testing if HAVE_LIBPNG
		/// or HAVE_LIBTIFF are 0, respectively.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ioFormatTest/*"/>
		///  <param name="filename">[in] - input file</param>
		///   <returns>0 if OK 1 on error or if the test fails</returns>
		public static int ioFormatTest(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			int _Result = Natives.ioFormatTest(  filename);

			return _Result;
		}


	}
}
