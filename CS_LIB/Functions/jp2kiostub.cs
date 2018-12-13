using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// jp2kiostub.c (47, 7)
		// pixReadJp2k(filename, reduction, box, hint, debug) as Pix
		// pixReadJp2k(const char *, l_uint32, BOX *, l_int32, l_int32) as PIX *
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadJp2k/*"/>
		///   <returns></returns>
		public static Pix pixReadJp2k(
						String filename,
						uint reduction,
						Box box,
						int hint,
						DebugOnOff debug)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("");}

			IntPtr boxPtr = IntPtr.Zero; if (box != null) {boxPtr = box.Pointer;}
			IntPtr _Result = Natives.pixReadJp2k(  filename,   reduction, box.Pointer,   hint,  (int) debug);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jp2kiostub.c (55, 7)
		// pixReadStreamJp2k(fp, reduction, box, hint, debug) as Pix
		// pixReadStreamJp2k(FILE *, l_uint32, BOX *, l_int32, l_int32) as PIX *
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamJp2k/*"/>
		///   <returns></returns>
		public static Pix pixReadStreamJp2k(
						FILE fp,
						uint reduction,
						Box box,
						int hint,
						DebugOnOff debug)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("");}

			IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
			IntPtr boxPtr = IntPtr.Zero; if (box != null) {boxPtr = box.Pointer;}
			IntPtr _Result = Natives.pixReadStreamJp2k(fp.Pointer,   reduction, box.Pointer,   hint,  (int) debug);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jp2kiostub.c (63, 6)
		// pixWriteJp2k(filename, pix, quality, nlevels, hint, debug) as int
		// pixWriteJp2k(const char *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteJp2k/*"/>
		///   <returns></returns>
		public static int pixWriteJp2k(
						String filename,
						Pix pix,
						int quality,
						int nlevels,
						int hint,
						DebugOnOff debug)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}
			int _Result = Natives.pixWriteJp2k(  filename, pix.Pointer,   quality,   nlevels,   hint,  (int) debug);
			return _Result;
		}

		// jp2kiostub.c (71, 6)
		// pixWriteStreamJp2k(fp, pix, quality, nlevels, hint, debug) as int
		// pixWriteStreamJp2k(FILE *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamJp2k/*"/>
		///   <returns></returns>
		public static int pixWriteStreamJp2k(
						FILE fp,
						Pix pix,
						int quality,
						int nlevels,
						int hint,
						DebugOnOff debug)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
			IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}
			int _Result = Natives.pixWriteStreamJp2k(fp.Pointer, pix.Pointer,   quality,   nlevels,   hint,  (int) debug);
			return _Result;
		}

		// jp2kiostub.c (79, 7)
		// pixReadMemJp2k(data, size, reduction, box, hint, debug) as Pix
		// pixReadMemJp2k(const l_uint8 *, size_t, l_uint32, BOX *, l_int32, l_int32) as PIX *
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemJp2k/*"/>
		///   <returns></returns>
		public static Pix pixReadMemJp2k(
						Byte[] data,
						uint size,
						uint reduction,
						Box box,
						int hint,
						DebugOnOff debug)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			if (reduction < 2 || reduction > 16) {   throw new ArgumentException ("");}

			IntPtr boxPtr = IntPtr.Zero; if (box != null) {boxPtr = box.Pointer;}
			IntPtr _Result = Natives.pixReadMemJp2k(  data,   size,   reduction, box.Pointer,   hint,  (int) debug);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// jp2kiostub.c (87, 6)
		// pixWriteMemJp2k(pdata, psize, pix, quality, nlevels, hint, debug) as int
		// pixWriteMemJp2k(l_uint8 **, size_t *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemJp2k/*"/>
		///   <returns></returns>
		public static int pixWriteMemJp2k(
						object pdata,
						object psize,
						Pix pix,
						int quality,
						int nlevels,
						int hint,
						DebugOnOff debug)
		{
			if (pdata == null) {throw new ArgumentNullException  ("pdata cannot be Nothing");}

			if (psize == null) {throw new ArgumentNullException  ("psize cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}
			int _Result = Natives.pixWriteMemJp2k(  pdata,   psize, pix.Pointer,   quality,   nlevels,   hint,  (int) debug);
			return _Result;
		}


	}
}
