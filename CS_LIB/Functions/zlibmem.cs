using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// zlibmem.c (92, 1)
		// zlibCompress(datain, nin, pnout) as Byte[]
		// zlibCompress(l_uint8 *, size_t, size_t *) as l_uint8 *
		///  <summary>
		/// (1) We repeatedly read in and fill up an input buffer,
		/// compress the data, and read it back out.  zlib
		/// uses two byte buffers internally in the z_stream
		/// data structure.  We use the bbuffers to feed data
		/// into the fixed bufferin, and feed it out of bufferout,
		/// in the same way that a pair of streams would normally
		/// be used if the data were being read from one file
		/// and written to another.  This is done iteratively,
		/// compressing L_BUF_SIZE bytes of input data at a time.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/zlibCompress/*"/>
		///  <param name="datain">[in] - byte buffer with input data</param>
		///  <param name="nin">[in] - number of bytes of input data</param>
		///  <param name="pnout">[out] - number of bytes of output data</param>
		///   <returns>dataout compressed data, or NULL on error</returns>
		public static Byte[] zlibCompress(
						Byte[] datain,
						uint nin,
						out uint pnout)
		{
			if (datain == null) {throw new ArgumentNullException  ("datain cannot be Nothing");}

			Byte[] _Result = Natives.zlibCompress(  datain,   nin, out  pnout);
			return _Result;
		}

		// zlibmem.c (198, 1)
		// zlibUncompress(datain, nin, pnout) as Byte[]
		// zlibUncompress(l_uint8 *, size_t, size_t *) as l_uint8 *
		///  <summary>
		/// (1) See zlibCompress().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/zlibUncompress/*"/>
		///  <param name="datain">[in] - byte buffer with compressed input data</param>
		///  <param name="nin">[in] - number of bytes of input data</param>
		///  <param name="pnout">[out] - number of bytes of output data</param>
		///   <returns>dataout uncompressed data, or NULL on error</returns>
		public static Byte[] zlibUncompress(
						Byte[] datain,
						uint nin,
						out uint pnout)
		{
			if (datain == null) {throw new ArgumentNullException  ("datain cannot be Nothing");}

			Byte[] _Result = Natives.zlibUncompress(  datain,   nin, out  pnout);
			return _Result;
		}

	}
}
