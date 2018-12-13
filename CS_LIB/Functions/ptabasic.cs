using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// ptabasic.c (116, 1)
		// ptaCreate(n) as Pta
		// ptaCreate(l_int32) as PTA *
		///  <summary>
		/// ptaCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCreate/*"/>
		///  <param name="n">[in] - initial array sizes</param>
		///   <returns>pta, or NULL on error.</returns>
		public static Pta ptaCreate(
						int n)
		{
			IntPtr _Result = Natives.ptaCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (149, 1)
		// ptaCreateFromNuma(nax, nay) as Pta
		// ptaCreateFromNuma(NUMA *, NUMA *) as PTA *
		///  <summary>
		/// ptaCreateFromNuma()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCreateFromNuma/*"/>
		///  <param name="nax">[in][optional] - can be null</param>
		///  <param name="nay">[in] - </param>
		///   <returns>pta, or NULL on error.</returns>
		public static Pta ptaCreateFromNuma(
						Numa nax,
						Numa nay)
		{
			if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}

			IntPtr naxPtr = IntPtr.Zero; 	if (nax != null) {naxPtr = nax.Pointer;}
			IntPtr _Result = Natives.ptaCreateFromNuma(naxPtr, nay.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (192, 1)
		// ptaDestroy(ppta) as Object
		// ptaDestroy(PTA **) as void
		///  <summary>
		/// (1) Decrements the ref count and, if 0, destroys the pta.<para/>
		///
		/// (2) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaDestroy/*"/>
		///  <param name="ppta">[in,out] - to be nulled</param>
		public static void ptaDestroy(
						ref Pta ppta)
		{
			IntPtr pptaPtr = IntPtr.Zero; 	if (ppta != null) {pptaPtr = ppta.Pointer;}
			Natives.ptaDestroy(ref pptaPtr);
			if (pptaPtr == IntPtr.Zero) {ppta = null;} else { ppta = new Pta(pptaPtr); };
		}

		// ptabasic.c (225, 1)
		// ptaCopy(pta) as Pta
		// ptaCopy(PTA *) as PTA *
		///  <summary>
		/// ptaCopy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCopy/*"/>
		///  <param name="pta">[in] - </param>
		///   <returns>copy of pta, or NULL on error</returns>
		public static Pta ptaCopy(
						Pta pta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr _Result = Natives.ptaCopy(pta.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (257, 1)
		// ptaCopyRange(ptas, istart, iend) as Pta
		// ptaCopyRange(PTA *, l_int32, l_int32) as PTA *
		///  <summary>
		/// ptaCopyRange()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCopyRange/*"/>
		///  <param name="ptas">[in] - </param>
		///  <param name="istart">[in] - starting index in ptas</param>
		///  <param name="iend">[in] - ending index in ptas use 0 to copy to end</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static Pta ptaCopyRange(
						Pta ptas,
						int istart,
						int iend)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.ptaCopyRange(ptas.Pointer,   istart,   iend);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (296, 1)
		// ptaClone(pta) as Pta
		// ptaClone(PTA *) as PTA *
		///  <summary>
		/// ptaClone()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaClone/*"/>
		///  <param name="pta">[in] - </param>
		///   <returns>ptr to same pta, or NULL on error</returns>
		public static Pta ptaClone(
						Pta pta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr _Result = Natives.ptaClone(pta.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (320, 1)
		// ptaEmpty(pta) as int
		// ptaEmpty(PTA *) as l_ok
		///  <summary>
		/// This only resets the Pta::n field, for reuse
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaEmpty/*"/>
		///  <param name="pta">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaEmpty(
						Pta pta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaEmpty(pta.Pointer);
			return _Result;
		}

		// ptabasic.c (342, 1)
		// ptaAddPt(pta, x, y) as int
		// ptaAddPt(PTA *, l_float32, l_float32) as l_ok
		///  <summary>
		/// ptaAddPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaAddPt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="x">[in] - </param>
		///  <param name="y">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaAddPt(
						Pta pta,
						Single x,
						Single y)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaAddPt(pta.Pointer,   x,   y);
			return _Result;
		}

		// ptabasic.c (404, 1)
		// ptaInsertPt(pta, index, x, y) as int
		// ptaInsertPt(PTA *, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// ptaInsertPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaInsertPt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="index">[in] - at which pt is to be inserted</param>
		///  <param name="x">[in] - point values</param>
		///  <param name="y">[in] - point values</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaInsertPt(
						Pta pta,
						int index,
						int x,
						int y)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaInsertPt(pta.Pointer,   index,   x,   y);
			return _Result;
		}

		// ptabasic.c (447, 1)
		// ptaRemovePt(pta, index) as int
		// ptaRemovePt(PTA *, l_int32) as l_ok
		///  <summary>
		/// (1) This shifts pta[i] to pta[i - 1] for all i  is greater  index.<para/>
		///
		/// (2) It should not be used repeatedly on large arrays,
		/// because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaRemovePt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="index">[in] - of point to be removed</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaRemovePt(
						Pta pta,
						int index)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaRemovePt(pta.Pointer,   index);
			return _Result;
		}

		// ptabasic.c (474, 1)
		// ptaGetRefcount(pta) as int
		// ptaGetRefcount(PTA *) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetRefcount/*"/>
		///   <returns></returns>
		public static int ptaGetRefcount(
						Pta pta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr ptaPtr = IntPtr.Zero; if (pta != null) {ptaPtr = pta.Pointer;}
			int _Result = Natives.ptaGetRefcount(pta.Pointer);
			return _Result;
		}

		// ptabasic.c (485, 1)
		// ptaChangeRefcount(pta, delta) as int
		// ptaChangeRefcount(PTA *, l_int32) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaChangeRefcount/*"/>
		///   <returns></returns>
		public static int ptaChangeRefcount(
						Pta pta,
						int delta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr ptaPtr = IntPtr.Zero; if (pta != null) {ptaPtr = pta.Pointer;}
			int _Result = Natives.ptaChangeRefcount(pta.Pointer,   delta);
			return _Result;
		}

		// ptabasic.c (504, 1)
		// ptaGetCount(pta) as int
		// ptaGetCount(PTA *) as l_int32
		///  <summary>
		/// ptaGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetCount/*"/>
		///  <param name="pta">[in] - </param>
		///   <returns>count, or 0 if no pta</returns>
		public static int ptaGetCount(
						Pta pta)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaGetCount(pta.Pointer);
			return _Result;
		}

		// ptabasic.c (525, 1)
		// ptaGetPt(pta, index, px, py) as int
		// ptaGetPt(PTA *, l_int32, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// ptaGetPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetPt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="index">[in] - into arrays</param>
		///  <param name="px">[out][optional] - float x value</param>
		///  <param name="py">[out][optional] - float y value</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaGetPt(
						Pta pta,
						int index,
						out Single px,
						out Single py)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaGetPt(pta.Pointer,   index, out  px, out  py);
			return _Result;
		}

		// ptabasic.c (555, 1)
		// ptaGetIPt(pta, index, px, py) as int
		// ptaGetIPt(PTA *, l_int32, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// ptaGetIPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetIPt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="index">[in] - into arrays</param>
		///  <param name="px">[out][optional] - integer x value</param>
		///  <param name="py">[out][optional] - integer y value</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaGetIPt(
						Pta pta,
						int index,
						out int px,
						out int py)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaGetIPt(pta.Pointer,   index, out  px, out  py);
			return _Result;
		}

		// ptabasic.c (584, 1)
		// ptaSetPt(pta, index, x, y) as int
		// ptaSetPt(PTA *, l_int32, l_float32, l_float32) as l_ok
		///  <summary>
		/// ptaSetPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaSetPt/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="index">[in] - into arrays</param>
		///  <param name="x">[in] - </param>
		///  <param name="y">[in] - </param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaSetPt(
						Pta pta,
						int index,
						Single x,
						Single y)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaSetPt(pta.Pointer,   index,   x,   y);
			return _Result;
		}

		// ptabasic.c (616, 1)
		// ptaGetArrays(pta, pnax, pnay) as int
		// ptaGetArrays(PTA *, NUMA **, NUMA **) as l_ok
		///  <summary>
		/// (1) This copies the internal arrays into new Numas.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetArrays/*"/>
		///  <param name="pta">[in] - </param>
		///  <param name="pnax">[out][optional] - numa of x array</param>
		///  <param name="pnay">[out][optional] - numa of y array</param>
		///   <returns>0 if OK 1 on error or if pta is empty</returns>
		public static int ptaGetArrays(
						Pta pta,
						out Numa pnax,
						out Numa pnay)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr pnaxPtr = IntPtr.Zero;
			IntPtr pnayPtr = IntPtr.Zero;
			int _Result = Natives.ptaGetArrays(pta.Pointer, out pnaxPtr, out pnayPtr);
			if (pnaxPtr == IntPtr.Zero) {pnax = null;} else { pnax = new Numa(pnaxPtr); };
			if (pnayPtr == IntPtr.Zero) {pnay = null;} else { pnay = new Numa(pnayPtr); };

			return _Result;
		}

		// ptabasic.c (664, 1)
		// ptaRead(filename) as Pta
		// ptaRead(const char *) as PTA *
		///  <summary>
		/// ptaRead()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaRead/*"/>
		///  <param name="filename">[in] - </param>
		///   <returns>pta, or NULL on error</returns>
		public static Pta ptaRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.ptaRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (691, 1)
		// ptaReadStream(fp) as Pta
		// ptaReadStream(FILE *) as PTA *
		///  <summary>
		/// ptaReadStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>pta, or NULL on error</returns>
		public static Pta ptaReadStream(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.ptaReadStream(fp.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (744, 1)
		// ptaReadMem(data, size) as Pta
		// ptaReadMem(const l_uint8 *, size_t) as PTA *
		///  <summary>
		/// ptaReadMem()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReadMem/*"/>
		///  <param name="data">[in] - serialization in ascii</param>
		///  <param name="size">[in] - of data in bytes can use strlen to get it</param>
		///   <returns>pta, or NULL on error</returns>
		public static Pta ptaReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.ptaReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (782, 1)
		// ptaWriteDebug(filename, pta, type) as int
		// ptaWriteDebug(const char *, PTA *, l_int32) as l_ok
		///  <summary>
		/// (1) Debug version, intended for use in the library when writing
		/// to files in a temp directory with names that are compiled in.
		/// This is used instead of ptaWrite() for all such library calls.<para/>
		///
		/// (2) The global variable LeptDebugOK defaults to 0, and can be set
		/// or cleared by the function setLeptDebugOK().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteDebug/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pta">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaWriteDebug(
						String filename,
						Pta pta,
						int type)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaWriteDebug(  filename, pta.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (806, 1)
		// ptaWrite(filename, pta, type) as int
		// ptaWrite(const char *, PTA *, l_int32) as l_ok
		///  <summary>
		/// ptaWrite()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWrite/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="pta">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaWrite(
						String filename,
						Pta pta,
						int type)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaWrite(  filename, pta.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (839, 1)
		// ptaWriteStream(fp, pta, type) as int
		// ptaWriteStream(FILE *, PTA *, l_int32) as l_ok
		///  <summary>
		/// ptaWriteStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="pta">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaWriteStream(
						FILE fp,
						Pta pta,
						int type)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaWriteStream(fp.Pointer, pta.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (888, 1)
		// ptaWriteMem(pdata, psize, pta, type) as int
		// ptaWriteMem(l_uint8 **, size_t *, PTA *, l_int32) as l_ok
		///  <summary>
		/// (1) Serializes a pta in memory and puts the result in a buffer.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteMem/*"/>
		///  <param name="pdata">[out] - data of serialized pta ascii</param>
		///  <param name="psize">[out] - size of returned data</param>
		///  <param name="pta">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaWriteMem(
						out Byte[] pdata,
						out uint psize,
						Pta pta,
						int type)
		{
			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.ptaWriteMem(out  pdataPtr, out  psize, pta.Pointer,   type);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// ptabasic.c (939, 1)
		// ptaaCreate(n) as Ptaa
		// ptaaCreate(l_int32) as PTAA *
		///  <summary>
		/// ptaaCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaCreate/*"/>
		///  <param name="n">[in] - initial number of ptrs</param>
		///   <returns>ptaa, or NULL on error</returns>
		public static Ptaa ptaaCreate(
						int n)
		{
			IntPtr _Result = Natives.ptaaCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Ptaa(_Result);
		}

		// ptabasic.c (967, 1)
		// ptaaDestroy(pptaa) as Object
		// ptaaDestroy(PTAA **) as void
		///  <summary>
		/// ptaaDestroy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaDestroy/*"/>
		///  <param name="pptaa">[in,out] - to be nulled</param>
		public static void ptaaDestroy(
						ref Ptaa pptaa)
		{
			IntPtr pptaaPtr = IntPtr.Zero; 	if (pptaa != null) {pptaaPtr = pptaa.Pointer;}
			Natives.ptaaDestroy(ref pptaaPtr);
			if (pptaaPtr == IntPtr.Zero) {pptaa = null;} else { pptaa = new Ptaa(pptaaPtr); };
		}

		// ptabasic.c (1004, 1)
		// ptaaAddPta(ptaa, pta, copyflag) as int
		// ptaaAddPta(PTAA *, PTA *, l_int32) as l_ok
		///  <summary>
		/// ptaaAddPta()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaAddPta/*"/>
		///  <param name="ptaa">[in] - </param>
		///  <param name="pta">[in] - to be added</param>
		///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaAddPta(
						Ptaa ptaa,
						Pta pta,
						int copyflag)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaaAddPta(ptaa.Pointer, pta.Pointer,   copyflag);
			return _Result;
		}

		// ptabasic.c (1074, 1)
		// ptaaGetCount(ptaa) as int
		// ptaaGetCount(PTAA *) as l_int32
		///  <summary>
		/// ptaaGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetCount/*"/>
		///  <param name="ptaa">[in] - </param>
		///   <returns>count, or 0 if no ptaa</returns>
		public static int ptaaGetCount(
						Ptaa ptaa)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaGetCount(ptaa.Pointer);
			return _Result;
		}

		// ptabasic.c (1094, 1)
		// ptaaGetPta(ptaa, index, accessflag) as Pta
		// ptaaGetPta(PTAA *, l_int32, l_int32) as PTA *
		///  <summary>
		/// ptaaGetPta()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetPta/*"/>
		///  <param name="ptaa">[in] - </param>
		///  <param name="index">[in] - to the i-th pta</param>
		///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>pta, or NULL on error</returns>
		public static Pta ptaaGetPta(
						Ptaa ptaa,
						int index,
						int accessflag)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			IntPtr _Result = Natives.ptaaGetPta(ptaa.Pointer,   index,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// ptabasic.c (1125, 1)
		// ptaaGetPt(ptaa, ipta, jpt, px, py) as int
		// ptaaGetPt(PTAA *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// ptaaGetPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetPt/*"/>
		///  <param name="ptaa">[in] - </param>
		///  <param name="ipta">[in] - to the i-th pta</param>
		///  <param name="jpt">[in] - index to the j-th pt in the pta</param>
		///  <param name="px">[out][optional] - float x value</param>
		///  <param name="py">[out][optional] - float y value</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaaGetPt(
						Ptaa ptaa,
						int ipta,
						int jpt,
						out Single px,
						out Single py)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaGetPt(ptaa.Pointer,   ipta,   jpt, out  px, out  py);
			return _Result;
		}

		// ptabasic.c (1165, 1)
		// ptaaInitFull(ptaa, pta) as int
		// ptaaInitFull(PTAA *, PTA *) as l_ok
		///  <summary>
		/// ptaaInitFull()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaInitFull/*"/>
		///  <param name="ptaa">[in] - can have non-null ptrs in the ptr array</param>
		///  <param name="pta">[in] - to be replicated into the entire ptr array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaaInitFull(
						Ptaa ptaa,
						Pta pta)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaaInitFull(ptaa.Pointer, pta.Pointer);
			return _Result;
		}

		// ptabasic.c (1204, 1)
		// ptaaReplacePta(ptaa, index, pta) as int
		// ptaaReplacePta(PTAA *, l_int32, PTA *) as l_ok
		///  <summary>
		/// (1) Any existing pta is destroyed, and the input one
		/// is inserted in its place.<para/>
		///
		/// (2) If the index is invalid, return 1 (error)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReplacePta/*"/>
		///  <param name="ptaa">[in] - </param>
		///  <param name="index">[in] - to the index-th pta</param>
		///  <param name="pta">[in] - insert and replace any existing one</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaReplacePta(
						Ptaa ptaa,
						int index,
						Pta pta)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}

			int _Result = Natives.ptaaReplacePta(ptaa.Pointer,   index, pta.Pointer);
			return _Result;
		}

		// ptabasic.c (1235, 1)
		// ptaaAddPt(ptaa, ipta, x, y) as int
		// ptaaAddPt(PTAA *, l_int32, l_float32, l_float32) as l_ok
		///  <summary>
		/// ptaaAddPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaAddPt/*"/>
		///  <param name="ptaa">[in] - </param>
		///  <param name="ipta">[in] - to the i-th pta</param>
		///  <param name="x">[in] - ,y point coordinates</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaaAddPt(
						Ptaa ptaa,
						int ipta,
						Single x,
						Single y)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaAddPt(ptaa.Pointer,   ipta,   x,   y);
			return _Result;
		}

		// ptabasic.c (1270, 1)
		// ptaaTruncate(ptaa) as int
		// ptaaTruncate(PTAA *) as l_ok
		///  <summary>
		/// (1) This identifies the largest index containing a pta that
		/// has any points within it, destroys all pta above that index,
		/// and resets the count.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaTruncate/*"/>
		///  <param name="ptaa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaTruncate(
						Ptaa ptaa)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaTruncate(ptaa.Pointer);
			return _Result;
		}

		// ptabasic.c (1310, 1)
		// ptaaRead(filename) as Ptaa
		// ptaaRead(const char *) as PTAA *
		///  <summary>
		/// ptaaRead()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaRead/*"/>
		///  <param name="filename">[in] - </param>
		///   <returns>ptaa, or NULL on error</returns>
		public static Ptaa ptaaRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.ptaaRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Ptaa(_Result);
		}

		// ptabasic.c (1337, 1)
		// ptaaReadStream(fp) as Ptaa
		// ptaaReadStream(FILE *) as PTAA *
		///  <summary>
		/// ptaaReadStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>ptaa, or NULL on error</returns>
		public static Ptaa ptaaReadStream(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.ptaaReadStream(fp.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Ptaa(_Result);
		}

		// ptabasic.c (1377, 1)
		// ptaaReadMem(data, size) as Ptaa
		// ptaaReadMem(const l_uint8 *, size_t) as PTAA *
		///  <summary>
		/// ptaaReadMem()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReadMem/*"/>
		///  <param name="data">[in] - serialization in ascii</param>
		///  <param name="size">[in] - of data in bytes can use strlen to get it</param>
		///   <returns>ptaa, or NULL on error</returns>
		public static Ptaa ptaaReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.ptaaReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Ptaa(_Result);
		}

		// ptabasic.c (1415, 1)
		// ptaaWriteDebug(filename, ptaa, type) as int
		// ptaaWriteDebug(const char *, PTAA *, l_int32) as l_ok
		///  <summary>
		/// (1) Debug version, intended for use in the library when writing
		/// to files in a temp directory with names that are compiled in.
		/// This is used instead of ptaaWrite() for all such library calls.<para/>
		///
		/// (2) The global variable LeptDebugOK defaults to 0, and can be set
		/// or cleared by the function setLeptDebugOK().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteDebug/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="ptaa">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaWriteDebug(
						String filename,
						Ptaa ptaa,
						int type)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaWriteDebug(  filename, ptaa.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (1439, 1)
		// ptaaWrite(filename, ptaa, type) as int
		// ptaaWrite(const char *, PTAA *, l_int32) as l_ok
		///  <summary>
		/// ptaaWrite()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWrite/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="ptaa">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaWrite(
						String filename,
						Ptaa ptaa,
						int type)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaWrite(  filename, ptaa.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (1472, 1)
		// ptaaWriteStream(fp, ptaa, type) as int
		// ptaaWriteStream(FILE *, PTAA *, l_int32) as l_ok
		///  <summary>
		/// ptaaWriteStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="ptaa">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptaaWriteStream(
						FILE fp,
						Ptaa ptaa,
						int type)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			int _Result = Natives.ptaaWriteStream(fp.Pointer, ptaa.Pointer,   type);
			return _Result;
		}

		// ptabasic.c (1514, 1)
		// ptaaWriteMem(pdata, psize, ptaa, type) as int
		// ptaaWriteMem(l_uint8 **, size_t *, PTAA *, l_int32) as l_ok
		///  <summary>
		/// (1) Serializes a ptaa in memory and puts the result in a buffer.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteMem/*"/>
		///  <param name="pdata">[out] - data of serialized ptaa ascii</param>
		///  <param name="psize">[out] - size of returned data</param>
		///  <param name="ptaa">[in] - </param>
		///  <param name="type">[in] - 0 for float values 1 for integer values</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptaaWriteMem(
						out Byte[] pdata,
						out uint psize,
						Ptaa ptaa,
						int type)
		{
			if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.ptaaWriteMem(out  pdataPtr, out  psize, ptaa.Pointer,   type);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}


	}
}
