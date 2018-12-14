using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// pixcomp.c (185, 1)
		// pixcompCreateFromPix(pix, comptype) as PixComp
		// pixcompCreateFromPix(PIX *, l_int32) as PIXC *
		///  <summary>
		/// (1) Use %comptype == IFF_DEFAULT to have the compression
		/// type automatically determined.<para/>
		///
		/// (2) To compress jpeg with a quality other than the default (75), use
		/// l_jpegSetQuality()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromPix/*"/>
		///  <param name="pix">[in] - </param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>pixc, or NULL on error</returns>
		public static PixComp pixcompCreateFromPix(
						Pix pix,
						int comptype)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr _Result = Natives.pixcompCreateFromPix(pix.Pointer,   comptype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixComp(_Result);
		}

		// pixcomp.c (242, 1)
		// pixcompCreateFromString(data, size, copyflag) as PixComp
		// pixcompCreateFromString(l_uint8 *, size_t, l_int32) as PIXC *
		///  <summary>
		/// (1) This works when the compressed string is png, jpeg or tiffg4.<para/>
		///
		/// (2) The copyflag determines if the data in the new Pixcomp is
		/// a copy of the input data.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromString/*"/>
		///  <param name="data">[in] - compressed string</param>
		///  <param name="size">[in] - number of bytes</param>
		///  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
		///   <returns>pixc, or NULL on error</returns>
		public static PixComp pixcompCreateFromString(
						Byte[] data,
						uint size,
						int copyflag)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.pixcompCreateFromString(  data,   size,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixComp(_Result);
		}

		// pixcomp.c (291, 1)
		// pixcompCreateFromFile(filename, comptype) as PixComp
		// pixcompCreateFromFile(const char *, l_int32) as PIXC *
		///  <summary>
		/// (1) Use %comptype == IFF_DEFAULT to have the compression
		/// type automatically determined.<para/>
		///
		/// (2) If the comptype is invalid for this file, the default will
		/// be substituted.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromFile/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>pixc, or NULL on error</returns>
		public static PixComp pixcompCreateFromFile(
						String filename,
						int comptype)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.pixcompCreateFromFile(  filename,   comptype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixComp(_Result);
		}

		// pixcomp.c (354, 1)
		// pixcompDestroy(ppixc) as Object
		// pixcompDestroy(PIXC **) as void
		///  <summary>
		/// (1) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompDestroy/*"/>
		///  <param name="ppixc">[in,out] - will be nulled</param>
		public static void pixcompDestroy(
						ref PixComp ppixc)
		{
			IntPtr ppixcPtr = IntPtr.Zero; 	if (ppixc != null) {ppixcPtr = ppixc.Pointer;}
			Natives.pixcompDestroy(ref ppixcPtr);
			if (ppixcPtr == IntPtr.Zero) {ppixc = null;} else { ppixc = new PixComp(ppixcPtr); };
		}

		// pixcomp.c (384, 1)
		// pixcompCopy(pixcs) as PixComp
		// pixcompCopy(PIXC *) as PIXC *
		///  <summary>
		/// pixcompCopy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCopy/*"/>
		///  <param name="pixcs">[in] - </param>
		///   <returns>pixcd, or NULL on error</returns>
		public static PixComp pixcompCopy(
						PixComp pixcs)
		{
			if (pixcs == null) {throw new ArgumentNullException  ("pixcs cannot be Nothing");}

			IntPtr _Result = Natives.pixcompCopy(pixcs.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixComp(_Result);
		}

		// pixcomp.c (429, 1)
		// pixcompGetDimensions(pixc, pw, ph, pd) as int
		// pixcompGetDimensions(PIXC *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// pixcompGetDimensions()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompGetDimensions/*"/>
		///  <param name="pixc">[in] - </param>
		///  <param name="pw">[out][optional] - </param>
		///  <param name="ph">[out][optional] - </param>
		///  <param name="pd">[out][optional] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixcompGetDimensions(
						PixComp pixc,
						out int pw,
						out int ph,
						out int pd)
		{
			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixcompGetDimensions(pixc.Pointer, out  pw, out  ph, out  pd);
			return _Result;
		}

		// pixcomp.c (453, 1)
		// pixcompGetParameters(pixc, pxres, pyres, pcomptype, pcmapflag) as int
		// pixcompGetParameters(PIXC *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// pixcompGetParameters()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompGetParameters/*"/>
		///  <param name="pixc">[in] - </param>
		///  <param name="pxres">[out][all optional] - </param>
		///  <param name="pyres">[out][all optional] - </param>
		///  <param name="pcomptype">[out][all optional] - </param>
		///  <param name="pcmapflag">[out][all optional] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixcompGetParameters(
						PixComp pixc,
						out int pxres,
						out int pyres,
						out int pcomptype,
						out int pcmapflag)
		{
			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixcompGetParameters(pixc.Pointer, out  pxres, out  pyres, out  pcomptype, out  pcmapflag);
			return _Result;
		}

		// pixcomp.c (495, 1)
		// pixcompDetermineFormat(comptype, d, cmapflag, pformat) as int
		// pixcompDetermineFormat(l_int32, l_int32, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) This determines the best format for a pix, given both
		/// the request (%comptype) and the image characteristics.<para/>
		///
		/// (2) If %comptype == IFF_DEFAULT, this does not necessarily result
		/// in png encoding.  Instead, it returns one of the three formats
		/// that is both valid and most likely to give best compression.<para/>
		///
		/// (3) If the pix cannot be compressed by the input value of
		/// %comptype, this selects IFF_PNG, which can compress all pix.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompDetermineFormat/*"/>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///  <param name="d">[in] - pix depth</param>
		///  <param name="cmapflag">[in] - 1 if pix to be compressed as a colormap 0 otherwise</param>
		///  <param name="pformat">[out] - return IFF_TIFF, IFF_PNG or IFF_JFIF_JPEG</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixcompDetermineFormat(
						int comptype,
						int d,
						int cmapflag,
						out int pformat)
		{
			int _Result = Natives.pixcompDetermineFormat(  comptype,   d,   cmapflag, out  pformat);
			return _Result;
		}

		// pixcomp.c (537, 1)
		// pixCreateFromPixcomp(pixc) as Pix
		// pixCreateFromPixcomp(PIXC *) as PIX *
		///  <summary>
		/// pixCreateFromPixcomp()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateFromPixcomp/*"/>
		///  <param name="pixc">[in] - </param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixCreateFromPixcomp(
						PixComp pixc)
		{
			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			IntPtr _Result = Natives.pixCreateFromPixcomp(pixc.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pixcomp.c (590, 1)
		// pixacompCreate(n) as PixaComp
		// pixacompCreate(l_int32) as PIXAC *
		///  <summary>
		/// pixacompCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreate/*"/>
		///  <param name="n">[in] - initial number of ptrs</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompCreate(
						int n)
		{
			IntPtr _Result = Natives.pixacompCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (657, 1)
		// pixacompCreateWithInit(n, offset, pix, comptype) as PixaComp
		// pixacompCreateWithInit(l_int32, l_int32, PIX *, l_int32) as PIXAC *
		///  <summary>
		/// (1) Initializes a pixacomp to be fully populated with %pix,
		/// compressed using %comptype.  If %pix == NULL, %comptype
		/// is ignored.<para/>
		///
		/// (2) Typically, the array is initialized with a tiny pix.
		/// This is most easily done by setting %pix == NULL, causing
		/// initialization of each array element with a tiny placeholder
		/// pix (w = h = d = 1), using comptype = IFF_TIFF_G4 .<para/>
		///
		/// (3) Example usage:
		/// // Generate pixacomp for pages 30 - 49.  This has an array
		/// // size of 20 and the page number offset is 30.
		/// PixaComp pixac = pixacompCreateWithInit(20, 30, NULL,
		/// IFF_TIFF_G4)
		/// // Now insert png-compressed images into the initialized array
		/// for (pageno = 30 pageno  is smaller 50 pageno++) {
		/// Pix pixt = ... // derived from image[pageno]
		/// if (pixt)
		/// pixacompReplacePix(pixac, pageno, pixt, IFF_PNG)
		/// pixDestroy([and]pixt)
		/// }
		/// The result is a pixac with 20 compressed strings, and with
		/// selected pixt replacing the placeholders.
		/// To extract the image for page 38, which is decompressed
		/// from element 8 in the array, use:
		/// pixt = pixacompGetPix(pixac, 38)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateWithInit/*"/>
		///  <param name="n">[in] - initial number of ptrs</param>
		///  <param name="offset">[in] - difference: accessor index - pixacomp array index</param>
		///  <param name="pix">[in][optional] - initialize each ptr in pixacomp to this pix can be NULL</param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompCreateWithInit(
						int n,
						int offset,
						Pix pix,
						int comptype)
		{
			IntPtr pixPtr = IntPtr.Zero; 	if (pix != null) {pixPtr = pix.Pointer;}
			IntPtr _Result = Natives.pixacompCreateWithInit(  n,   offset, pixPtr,   comptype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (721, 1)
		// pixacompCreateFromPixa(pixa, comptype, accesstype) as PixaComp
		// pixacompCreateFromPixa(PIXA *, l_int32, l_int32) as PIXAC *
		///  <summary>
		/// (1) If %format == IFF_DEFAULT, the conversion format for each
		/// image is chosen automatically.  Otherwise, we use the
		/// specified format unless it can't be done (e.g., jpeg
		/// for a 1, 2 or 4 bpp pix, or a pix with a colormap),
		/// in which case we use the default (assumed best) compression.<para/>
		///
		/// (2) %accesstype is used to extract a boxa from %pixa.<para/>
		///
		/// (3) To compress jpeg with a quality other than the default (75), use
		/// l_jpegSetQuality()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromPixa/*"/>
		///  <param name="pixa">[in] - </param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static PixaComp pixacompCreateFromPixa(
						Pixa pixa,
						int comptype,
						int accesstype)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixacompCreateFromPixa(pixa.Pointer,   comptype,   accesstype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (780, 1)
		// pixacompCreateFromFiles(dirname, substr, comptype) as PixaComp
		// pixacompCreateFromFiles(const char *, const char *, l_int32) as PIXAC *
		///  <summary>
		/// (1) %dirname is the full path for the directory.<para/>
		///
		/// (2) %substr is the part of the file name (excluding
		/// the directory) that is to be matched.  All matching
		/// filenames are read into the Pixa.  If substr is NULL,
		/// all filenames are read into the Pixa.<para/>
		///
		/// (3) Use %comptype == IFF_DEFAULT to have the compression
		/// type automatically determined for each file.<para/>
		///
		/// (4) If the comptype is invalid for a file, the default will
		/// be substituted.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromFiles/*"/>
		///  <param name="dirname">[in] - </param>
		///  <param name="substr">[in][optional] - substring filter on filenames can be null</param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompCreateFromFiles(
						String dirname,
						String substr,
						int comptype)
		{
			if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}

			IntPtr _Result = Natives.pixacompCreateFromFiles(  dirname,   substr,   comptype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (819, 1)
		// pixacompCreateFromSA(sa, comptype) as PixaComp
		// pixacompCreateFromSA(SARRAY *, l_int32) as PIXAC *
		///  <summary>
		/// (1) Use %comptype == IFF_DEFAULT to have the compression
		/// type automatically determined for each file.<para/>
		///
		/// (2) If the comptype is invalid for a file, the default will
		/// be substituted.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromSA/*"/>
		///  <param name="sa">[in] - full pathnames for all files</param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompCreateFromSA(
						Sarray sa,
						int comptype)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			IntPtr _Result = Natives.pixacompCreateFromSA(sa.Pointer,   comptype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (861, 1)
		// pixacompDestroy(ppixac) as Object
		// pixacompDestroy(PIXAC **) as void
		///  <summary>
		/// (1) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompDestroy/*"/>
		///  <param name="ppixac">[in,out] - to be nulled</param>
		public static void pixacompDestroy(
						ref PixaComp ppixac)
		{
			IntPtr ppixacPtr = IntPtr.Zero; 	if (ppixac != null) {ppixacPtr = ppixac.Pointer;}
			Natives.pixacompDestroy(ref ppixacPtr);
			if (ppixacPtr == IntPtr.Zero) {ppixac = null;} else { ppixac = new PixaComp(ppixacPtr); };
		}

		// pixcomp.c (908, 1)
		// pixacompAddPix(pixac, pix, comptype) as int
		// pixacompAddPix(PIXAC *, PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) The array is filled up to the (n-1)-th element, and this
		/// converts the input pix to a pixc and adds it at
		/// the n-th position.<para/>
		///
		/// (2) The pixc produced from the pix is owned by the pixac.
		/// The input pix is not affected.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddPix/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="pix">[in] - to be added</param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixacompAddPix(
						PixaComp pixac,
						Pix pix,
						int comptype)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixacompAddPix(pixac.Pointer, pix.Pointer,   comptype);
			return _Result;
		}

		// pixcomp.c (950, 1)
		// pixacompAddPixcomp(pixac, pixc, copyflag) as int
		// pixacompAddPixcomp(PIXAC *, PIXC *, l_int32) as l_ok
		///  <summary>
		/// (1) Anything added to a pixac is owned by the pixac.
		/// So do not L_INSERT a pixc that is owned by another pixac,
		/// or destroy a pixc that has been L_INSERTed.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddPixcomp/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="pixc">[in] - to be added by insertion</param>
		///  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixacompAddPixcomp(
						PixaComp pixac,
						PixComp pixc,
						int copyflag)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixacompAddPixcomp(pixac.Pointer, pixc.Pointer,   copyflag);
			return _Result;
		}

		// pixcomp.c (1028, 1)
		// pixacompReplacePix(pixac, index, pix, comptype) as int
		// pixacompReplacePix(PIXAC *, l_int32, PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.<para/>
		///
		/// (2) The input %pix is converted to a pixc, which is then inserted
		/// into the pixac.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReplacePix/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="pix">[in] - owned by the caller</param>
		///  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixacompReplacePix(
						PixaComp pixac,
						int index,
						Pix pix,
						int comptype)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixacompReplacePix(pixac.Pointer,   index, pix.Pointer,   comptype);
			return _Result;
		}

		// pixcomp.c (1073, 1)
		// pixacompReplacePixcomp(pixac, index, pixc) as int
		// pixacompReplacePixcomp(PIXAC *, l_int32, PIXC *) as l_ok
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.<para/>
		///
		/// (2) The inserted %pixc is now owned by the pixac.  The caller
		/// must not destroy it.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReplacePixcomp/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="pixc">[in] - to replace existing one, which is destroyed</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixacompReplacePixcomp(
						PixaComp pixac,
						int index,
						PixComp pixc)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixacompReplacePixcomp(pixac.Pointer,   index, pixc.Pointer);
			return _Result;
		}

		// pixcomp.c (1108, 1)
		// pixacompAddBox(pixac, box, copyflag) as int
		// pixacompAddBox(PIXAC *, BOX *, l_int32) as l_ok
		///  <summary>
		/// pixacompAddBox()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddBox/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="box">[in] - </param>
		///  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompAddBox(
						PixaComp pixac,
						Box box,
						int copyflag)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.pixacompAddBox(pixac.Pointer, box.Pointer,   copyflag);
			return _Result;
		}

		// pixcomp.c (1136, 1)
		// pixacompGetCount(pixac) as int
		// pixacompGetCount(PIXAC *) as l_int32
		///  <summary>
		/// pixacompGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetCount/*"/>
		///  <param name="pixac">[in] - </param>
		///   <returns>count, or 0 if no pixa</returns>
		public static int pixacompGetCount(
						PixaComp pixac)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompGetCount(pixac.Pointer);
			return _Result;
		}

		// pixcomp.c (1164, 1)
		// pixacompGetPixcomp(pixac, index, copyflag) as PixComp
		// pixacompGetPixcomp(PIXAC *, l_int32, l_int32) as PIXC *
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.<para/>
		///
		/// (2) If copyflag == L_NOCOPY, the pixc is owned by %pixac do
		/// not destroy.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPixcomp/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="copyflag">[in] - L_NOCOPY, L_COPY</param>
		///   <returns>pixc, or NULL on error</returns>
		public static PixComp pixacompGetPixcomp(
						PixaComp pixac,
						int index,
						int copyflag)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixacompGetPixcomp(pixac.Pointer,   index,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixComp(_Result);
		}

		// pixcomp.c (1201, 1)
		// pixacompGetPix(pixac, index) as Pix
		// pixacompGetPix(PIXAC *, l_int32) as PIX *
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPix/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixacompGetPix(
						PixaComp pixac,
						int index)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixacompGetPix(pixac.Pointer,   index);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pixcomp.c (1235, 1)
		// pixacompGetPixDimensions(pixac, index, pw, ph, pd) as int
		// pixacompGetPixDimensions(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPixDimensions/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="pw">[out][optional] - each can be null</param>
		///  <param name="ph">[out][optional] - each can be null</param>
		///  <param name="pd">[out][optional] - each can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompGetPixDimensions(
						PixaComp pixac,
						int index,
						out int pw,
						out int ph,
						out int pd)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompGetPixDimensions(pixac.Pointer,   index, out  pw, out  ph, out  pd);
			return _Result;
		}

		// pixcomp.c (1267, 1)
		// pixacompGetBoxa(pixac, accesstype) as Boxa
		// pixacompGetBoxa(PIXAC *, l_int32) as BOXA *
		///  <summary>
		/// pixacompGetBoxa()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxa/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa pixacompGetBoxa(
						PixaComp pixac,
						int accesstype)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixacompGetBoxa(pixac.Pointer,   accesstype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// pixcomp.c (1291, 1)
		// pixacompGetBoxaCount(pixac) as int
		// pixacompGetBoxaCount(PIXAC *) as l_int32
		///  <summary>
		/// pixacompGetBoxaCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxaCount/*"/>
		///  <param name="pixac">[in] - </param>
		///   <returns>count, or 0 on error</returns>
		public static int pixacompGetBoxaCount(
						PixaComp pixac)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompGetBoxaCount(pixac.Pointer);
			return _Result;
		}

		// pixcomp.c (1325, 1)
		// pixacompGetBox(pixac, index, accesstype) as Box
		// pixacompGetBox(PIXAC *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.<para/>
		///
		/// (2) There is always a boxa with a pixac, and it is initialized so
		/// that each box ptr is NULL.<para/>
		///
		/// (3) In general, we expect that there is either a box associated
		/// with each pixc, or no boxes at all in the boxa.<para/>
		///
		/// (4) Having no boxes is thus not an automatic error.  Whether it
		/// is an actual error is determined by the calling program.
		/// If the caller expects to get a box, it is an error see, e.g.,
		/// pixacGetBoxGeometry().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBox/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
		///   <returns>box if null, not automatically an error, or NULL on error</returns>
		public static Box pixacompGetBox(
						PixaComp pixac,
						int index,
						int accesstype)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixacompGetBox(pixac.Pointer,   index,   accesstype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// pixcomp.c (1371, 1)
		// pixacompGetBoxGeometry(pixac, index, px, py, pw, ph) as int
		// pixacompGetBoxGeometry(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The %index includes the offset, which must be subtracted
		/// to get the actual index into the ptr array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxGeometry/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="index">[in] - caller's view of index within pixac includes offset</param>
		///  <param name="px">[out][optional] - each can be null</param>
		///  <param name="py">[out][optional] - each can be null</param>
		///  <param name="pw">[out][optional] - each can be null</param>
		///  <param name="ph">[out][optional] - each can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompGetBoxGeometry(
						PixaComp pixac,
						int index,
						out int px,
						out int py,
						out int pw,
						out int ph)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompGetBoxGeometry(pixac.Pointer,   index, out  px, out  py, out  pw, out  ph);
			return _Result;
		}

		// pixcomp.c (1411, 1)
		// pixacompGetOffset(pixac) as int
		// pixacompGetOffset(PIXAC *) as l_int32
		///  <summary>
		/// (1) The offset is the difference between the caller's view of
		/// the index into the array and the actual array index.
		/// By default it is 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetOffset/*"/>
		///  <param name="pixac">[in] - </param>
		///   <returns>offset, or 0 on error</returns>
		public static int pixacompGetOffset(
						PixaComp pixac)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompGetOffset(pixac.Pointer);
			return _Result;
		}

		// pixcomp.c (1436, 1)
		// pixacompSetOffset(pixac, offset) as int
		// pixacompSetOffset(PIXAC *, l_int32) as l_ok
		///  <summary>
		/// (1) The offset is the difference between the caller's view of
		/// the index into the array and the actual array index.
		/// By default it is 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompSetOffset/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="offset">[in] - non-negative</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompSetOffset(
						PixaComp pixac,
						int offset)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompSetOffset(pixac.Pointer,   offset);
			return _Result;
		}

		// pixcomp.c (1466, 1)
		// pixaCreateFromPixacomp(pixac, accesstype) as Pixa
		// pixaCreateFromPixacomp(PIXAC *, l_int32) as PIXA *
		///  <summary>
		/// (1) Because the pixa has no notion of offset, the offset must
		/// be set to 0 before the conversion, so that pixacompGetPix()
		/// fetches all the pixcomps.  It is reset at the end.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCreateFromPixacomp/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE for boxa</param>
		///   <returns>pixa if OK, or NULL on error</returns>
		public static Pixa pixaCreateFromPixacomp(
						PixaComp pixac,
						int accesstype)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixaCreateFromPixacomp(pixac.Pointer,   accesstype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixa(_Result);
		}

		// pixcomp.c (1524, 1)
		// pixacompJoin(pixacd, pixacs, istart, iend) as int
		// pixacompJoin(PIXAC *, PIXAC *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This appends a clone of each indicated pixc in pixcas to pixcad<para/>
		///
		/// (2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
		///
		/// (3) iend  is smaller 0 means 'read to the end'<para/>
		///
		/// (4) If pixacs is NULL or contains no pixc, this is a no-op.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompJoin/*"/>
		///  <param name="pixacd">[in] - dest pixac add to this one</param>
		///  <param name="pixacs">[in][optional] - source pixac add from this one</param>
		///  <param name="istart">[in] - starting index in pixacs</param>
		///  <param name="iend">[in] - ending index in pixacs use -1 to cat all</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompJoin(
						PixaComp pixacd,
						PixaComp pixacs,
						int istart,
						int iend)
		{
			if (pixacd == null) {throw new ArgumentNullException  ("pixacd cannot be Nothing");}

			IntPtr pixacsPtr = IntPtr.Zero; 	if (pixacs != null) {pixacsPtr = pixacs.Pointer;}
			int _Result = Natives.pixacompJoin(pixacd.Pointer, pixacsPtr,   istart,   iend);
			return _Result;
		}

		// pixcomp.c (1577, 1)
		// pixacompInterleave(pixac1, pixac2) as PixaComp
		// pixacompInterleave(PIXAC *, PIXAC *) as PIXAC *
		///  <summary>
		/// (1) If the two pixac have different sizes, a warning is issued,
		/// and the number of pairs returned is the minimum size.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompInterleave/*"/>
		///  <param name="pixac1">[in] - first src pixac</param>
		///  <param name="pixac2">[in] - second src pixac</param>
		///   <returns>pixacd  interleaved from sources, or NULL on error.</returns>
		public static PixaComp pixacompInterleave(
						PixaComp pixac1,
						PixaComp pixac2)
		{
			if (pixac1 == null) {throw new ArgumentNullException  ("pixac1 cannot be Nothing");}

			if (pixac2 == null) {throw new ArgumentNullException  ("pixac2 cannot be Nothing");}

			IntPtr _Result = Natives.pixacompInterleave(pixac1.Pointer, pixac2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (1639, 1)
		// pixacompRead(filename) as PixaComp
		// pixacompRead(const char *) as PIXAC *
		///  <summary>
		/// (1) Unlike the situation with serialized Pixa, where the image
		/// data is stored in png format, the Pixacomp image data
		/// can be stored in tiffg4, png and jpg formats.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompRead/*"/>
		///  <param name="filename">[in] - </param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.pixacompRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (1666, 1)
		// pixacompReadStream(fp) as PixaComp
		// pixacompReadStream(FILE *) as PIXAC *
		///  <summary>
		/// pixacompReadStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompReadStream(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.pixacompReadStream(fp.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (1764, 1)
		// pixacompReadMem(data, size) as PixaComp
		// pixacompReadMem(const l_uint8 *, size_t) as PIXAC *
		///  <summary>
		/// (1) Deseralizes a buffer of pixacomp data into a pixac in memory.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReadMem/*"/>
		///  <param name="data">[in] - const pixacomp format</param>
		///  <param name="size">[in] - of data</param>
		///   <returns>pixac, or NULL on error</returns>
		public static PixaComp pixacompReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.pixacompReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new PixaComp(_Result);
		}

		// pixcomp.c (1799, 1)
		// pixacompWrite(filename, pixac) as int
		// pixacompWrite(const char *, PIXAC *) as l_ok
		///  <summary>
		/// (1) Unlike the situation with serialized Pixa, where the image
		/// data is stored in png format, the Pixacomp image data
		/// can be stored in tiffg4, png and jpg formats.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWrite/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pixac">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompWrite(
						String filename,
						PixaComp pixac)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompWrite(  filename, pixac.Pointer);
			return _Result;
		}

		// pixcomp.c (1830, 1)
		// pixacompWriteStream(fp, pixac) as int
		// pixacompWriteStream(FILE *, PIXAC *) as l_ok
		///  <summary>
		/// pixacompWriteStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pixac">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompWriteStream(
						FILE fp,
						PixaComp pixac)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompWriteStream(fp.Pointer, pixac.Pointer);
			return _Result;
		}

		// pixcomp.c (1878, 1)
		// pixacompWriteMem(pdata, psize, pixac) as int
		// pixacompWriteMem(l_uint8 **, size_t *, PIXAC *) as l_ok
		///  <summary>
		/// (1) Serializes a pixac in memory and puts the result in a buffer.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteMem/*"/>
		///  <param name="pdata">[out] - serialized data of pixac</param>
		///  <param name="psize">[out] - size of serialized data</param>
		///  <param name="pixac">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompWriteMem(
						out Byte[] pdata,
						out uint psize,
						PixaComp pixac)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.pixacompWriteMem(out  pdataPtr, out  psize, pixac.Pointer);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// pixcomp.c (1952, 1)
		// pixacompConvertToPdf(pixac, res, scalefactor, type, quality, title, fileout) as int
		// pixacompConvertToPdf(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
		///  <summary>
		/// (1) This follows closely the function pixaConvertToPdf() in pdfio.c.<para/>
		///
		/// (2) The images are encoded with G4 if 1 bpp JPEG if 8 bpp without
		/// colormap and many colors, or 32 bpp FLATE for anything else.<para/>
		///
		/// (3) The scalefactor must be  is greater  0.0 otherwise it is set to 1.0.<para/>
		///
		/// (4) Specifying one of the three encoding types for %type forces
		/// all images to be compressed with that type.  Use 0 to have
		/// the type determined for each image based on depth and whether
		/// or not it has a colormap.<para/>
		///
		/// (5) If all images are jpeg compressed, don't require scaling
		/// and have the same resolution, it is much faster to skip
		/// transcoding with pixacompFastConvertToPdfData(), and then
		/// write the data out to file.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompConvertToPdf/*"/>
		///  <param name="pixac">[in] - containing images all at the same resolution</param>
		///  <param name="res">[in] - override the resolution of each input image, in ppi use 0 to respect the resolution embedded in the input</param>
		///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
		///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or L_DEFAULT_ENCODE for default</param>
		///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
		///  <param name="title">[in][optional] - pdf title</param>
		///  <param name="fileout">[in] - pdf file of all images</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompConvertToPdf(
						PixaComp pixac,
						int res,
						Single scalefactor,
						int type,
						int quality,
						String title,
						String fileout)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (fileout == null) {throw new ArgumentNullException  ("fileout cannot be Nothing");}

			int _Result = Natives.pixacompConvertToPdf(pixac.Pointer,   res,   scalefactor,   type,   quality,   title,   fileout);
			return _Result;
		}

		// pixcomp.c (2004, 1)
		// pixacompConvertToPdfData(pixac, res, scalefactor, type, quality, title, pdata, pnbytes) as int
		// pixacompConvertToPdfData(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
		///  <summary>
		/// (1) See pixacompConvertToPdf().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompConvertToPdfData/*"/>
		///  <param name="pixac">[in] - containing images all at the same resolution</param>
		///  <param name="res">[in] - input resolution of all images</param>
		///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
		///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or L_DEFAULT_ENCODE for default</param>
		///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
		///  <param name="title">[in][optional] - pdf title</param>
		///  <param name="pdata">[out] - output pdf data (of all images</param>
		///  <param name="pnbytes">[out] - size of output pdf data</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompConvertToPdfData(
						PixaComp pixac,
						int res,
						Single scalefactor,
						int type,
						int quality,
						String title,
						out Byte[] pdata,
						out uint pnbytes)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.pixacompConvertToPdfData(pixac.Pointer,   res,   scalefactor,   type,   quality,   title, out  pdataPtr, out  pnbytes);
			Byte[] pdataGen = new Byte[pnbytes];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// pixcomp.c (2115, 1)
		// pixacompFastConvertToPdfData(pixac, title, pdata, pnbytes) as int
		// pixacompFastConvertToPdfData(PIXAC *, const char *, l_uint8 **, size_t *) as l_ok
		///  <summary>
		/// (1) This generates the pdf without transcoding if all the
		/// images in %pixac are compressed with jpeg.
		/// Images not jpeg compressed are skipped.<para/>
		///
		/// (2) It assumes all images have the same resolution, and that
		/// the resolution embedded in each jpeg file is correct.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompFastConvertToPdfData/*"/>
		///  <param name="pixac">[in] - containing images all at the same resolution</param>
		///  <param name="title">[in][optional] - pdf title</param>
		///  <param name="pdata">[out] - output pdf data (of all images</param>
		///  <param name="pnbytes">[out] - size of output pdf data</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompFastConvertToPdfData(
						PixaComp pixac,
						String title,
						out Byte[] pdata,
						out uint pnbytes)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.pixacompFastConvertToPdfData(pixac.Pointer,   title, out  pdataPtr, out  pnbytes);
			Byte[] pdataGen = new Byte[pnbytes];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// pixcomp.c (2240, 1)
		// pixacompWriteStreamInfo(fp, pixac, text) as int
		// pixacompWriteStreamInfo(FILE *, PIXAC *, const char *) as l_ok
		///  <summary>
		/// pixacompWriteStreamInfo()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteStreamInfo/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pixac">[in] - </param>
		///  <param name="text">[in][optional] - identifying string can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompWriteStreamInfo(
						FILE fp,
						PixaComp pixac,
						String text = "")
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			int _Result = Natives.pixacompWriteStreamInfo(fp.Pointer, pixac.Pointer,   text);
			return _Result;
		}

		// pixcomp.c (2284, 1)
		// pixcompWriteStreamInfo(fp, pixc, text) as int
		// pixcompWriteStreamInfo(FILE *, PIXC *, const char *) as l_ok
		///  <summary>
		/// pixcompWriteStreamInfo()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompWriteStreamInfo/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pixc">[in] - </param>
		///  <param name="text">[in][optional] - identifying string can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixcompWriteStreamInfo(
						FILE fp,
						PixComp pixc,
						String text = "")
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixcompWriteStreamInfo(fp.Pointer, pixc.Pointer,   text);
			return _Result;
		}

		// pixcomp.c (2340, 1)
		// pixacompDisplayTiledAndScaled(pixac, outdepth, tilewidth, ncols, background, spacing, border) as Pix
		// pixacompDisplayTiledAndScaled(PIXAC *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This is the same function as pixaDisplayTiledAndScaled(),
		/// except it works on a Pixacomp instead of a Pix.  It is particularly
		/// useful for showing the images in a Pixacomp at reduced resolution.<para/>
		///
		/// (2) See pixaDisplayTiledAndScaled() for details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompDisplayTiledAndScaled/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
		///  <param name="tilewidth">[in] - each pix is scaled to this width</param>
		///  <param name="ncols">[in] - number of tiles in each row</param>
		///  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
		///  <param name="spacing">[in] - between images, and on outside</param>
		///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
		///   <returns>pix of tiled images, or NULL on error</returns>
		public static Pix pixacompDisplayTiledAndScaled(
						PixaComp pixac,
						int outdepth,
						int tilewidth,
						int ncols,
						int background,
						int spacing,
						int border)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			IntPtr _Result = Natives.pixacompDisplayTiledAndScaled(pixac.Pointer,   outdepth,   tilewidth,   ncols,   background,   spacing,   border);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pixcomp.c (2374, 1)
		// pixacompWriteFiles(pixac, subdir) as int
		// pixacompWriteFiles(PIXAC *, const char *) as l_ok
		///  <summary>
		/// pixacompWriteFiles()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteFiles/*"/>
		///  <param name="pixac">[in] - </param>
		///  <param name="subdir">[in] - (subdirectory of /tmp)</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixacompWriteFiles(
						PixaComp pixac,
						String subdir)
		{
			if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}

			if (subdir == null) {throw new ArgumentNullException  ("subdir cannot be Nothing");}

			int _Result = Natives.pixacompWriteFiles(pixac.Pointer,   subdir);
			return _Result;
		}

		// pixcomp.c (2414, 1)
		// pixcompWriteFile(rootname, pixc) as int
		// pixcompWriteFile(const char *, PIXC *) as l_ok
		///  <summary>
		/// (1) The compressed data is written to file, and the filename is
		/// generated by appending the format extension to %rootname.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompWriteFile/*"/>
		///  <param name="rootname">[in] - </param>
		///  <param name="pixc">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixcompWriteFile(
						String rootname,
						PixComp pixc)
		{
			if (rootname == null) {throw new ArgumentNullException  ("rootname cannot be Nothing");}

			if (pixc == null) {throw new ArgumentNullException  ("pixc cannot be Nothing");}

			int _Result = Natives.pixcompWriteFile(  rootname, pixc.Pointer);
			return _Result;
		}


	}
}
