using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// spixio.c (88, 1)
// pixReadStreamSpix(fp) as Pix
// pixReadStreamSpix(FILE *) as PIX *
///  <summary>
/// (1) If called from pixReadStream(), the stream is positioned
/// at the beginning of the file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamSpix/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>pix, or NULL on error.</returns>
public static Pix pixReadStreamSpix(
				 FILE fp){

	IntPtr _Result = Natives.pixReadStreamSpix(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// spixio.c (126, 1)
// readHeaderSpix(filename, pwidth, pheight, pbps, pspp, piscmap) as int
// readHeaderSpix(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, iscmap is returned as 1 else 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderSpix/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pwidth">[out] - width</param>
///  <param name="pheight">[out] - height</param>
///  <param name="pbps">[out] - bits/sample</param>
///  <param name="pspp">[out] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderSpix(
				 String filename, 
				out int pwidth, 
				out int pheight, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

	int _Result = Natives.readHeaderSpix(  filename, out  pwidth, out  pheight, out  pbps, out  pspp, out  piscmap);
	
	return _Result;
}

// spixio.c (167, 1)
// freadHeaderSpix(fp, pwidth, pheight, pbps, pspp, piscmap) as int
// freadHeaderSpix(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, iscmap is returned as 1 else 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderSpix/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pwidth">[out] - width</param>
///  <param name="pheight">[out] - height</param>
///  <param name="pbps">[out] - bits/sample</param>
///  <param name="pspp">[out] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int freadHeaderSpix(
				 FILE fp, 
				out int pwidth, 
				out int pheight, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

	int _Result = Natives.freadHeaderSpix(fp.Pointer, out  pwidth, out  pheight, out  pbps, out  pspp, out  piscmap);
	
	return _Result;
}

// spixio.c (211, 1)
// sreadHeaderSpix(data, pwidth, pheight, pbps, pspp, piscmap) as int
// sreadHeaderSpix(const l_uint32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) If there is a colormap, iscmap is returned as 1 else 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sreadHeaderSpix/*"/>
///  <param name="data">[in] - </param>
///  <param name="pwidth">[out] - width</param>
///  <param name="pheight">[out] - height</param>
///  <param name="pbps">[out] - bits/sample</param>
///  <param name="pspp">[out] - samples/pixel</param>
///  <param name="piscmap">[out][optional] - input NULL to ignore</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sreadHeaderSpix(
				 Byte[] data, 
				out int pwidth, 
				out int pheight, 
				out int pbps, 
				out int pspp, 
				out int piscmap){

		IntPtr dataPtr = 	Marshal.AllocHGlobal(data.Length);
		Marshal.Copy(data, 0, dataPtr, data.Length);

	int _Result = Natives.sreadHeaderSpix(  dataPtr, out  pwidth, out  pheight, out  pbps, out  pspp, out  piscmap);
	
	Marshal.FreeHGlobal(dataPtr);
	return _Result;
}

// spixio.c (265, 1)
// pixWriteStreamSpix(fp, pix) as int
// pixWriteStreamSpix(FILE *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamSpix/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixWriteStreamSpix(
				 FILE fp, 
				 Pix pix){

	int _Result = Natives.pixWriteStreamSpix(fp.Pointer, pix.Pointer);
	
	return _Result;
}

// spixio.c (297, 1)
// pixReadMemSpix(data, size) as Pix
// pixReadMemSpix(const l_uint8 *, size_t) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemSpix/*"/>
///  <param name="data">[in] - const uncompressed</param>
///  <param name="size">[in] - bytes of data</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixReadMemSpix(
				 Byte[] data, 
				 uint size){

	IntPtr _Result = Natives.pixReadMemSpix(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// spixio.c (313, 1)
// pixWriteMemSpix(pdata, psize, pix) as int
// pixWriteMemSpix(l_uint8 **, size_t *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemSpix/*"/>
///  <param name="pdata">[out] - data of serialized, uncompressed pix</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - all depths colormap OK</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWriteMemSpix(
				out Byte[] pdata, 
				out uint psize, 
				 Pix pix){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemSpix(out  pdataPtr, out  psize, pix.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// spixio.c (346, 1)
// pixSerializeToMemory(pixs, pdata, pnbytes) as int
// pixSerializeToMemory(PIX *, l_uint32 **, size_t *) as l_ok
///  <summary>
/// (1) This does a fast serialization of the principal elements
/// of the pix, as follows:
/// "spix"  (4 bytes) -- ID for file type
/// w (4 bytes)
/// h (4 bytes)
/// d (4 bytes)
/// wpl (4 bytes)
/// ncolors (4 bytes) -- in colormap 0 if there is no colormap
/// cdata (4  ncolors)  -- size of serialized colormap array
/// rdatasize (4 bytes) -- size of serialized raster data
/// = 4  wpl  h
/// rdata (rdatasize)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSerializeToMemory/*"/>
///  <param name="pixs">[in] - all depths, colormap OK</param>
///  <param name="pdata">[out] - serialized data in memory</param>
///  <param name="pnbytes">[out] - number of bytes in data string</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSerializeToMemory(
				 Pix pixs, 
				out Byte[] pdata, 
				out uint pnbytes){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixSerializeToMemory(pixs.Pointer, out  pdataPtr, out  pnbytes);
	
	Byte[] pdataGen = new Byte[pnbytes];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// spixio.c (424, 1)
// pixDeserializeFromMemory(data, nbytes) as Pix
// pixDeserializeFromMemory(const l_uint32 *, size_t) as PIX *
///  <summary>
/// (1) See pixSerializeToMemory() for the binary format.<para/>
/// 
/// (2) Note the image size limits.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDeserializeFromMemory/*"/>
///  <param name="data">[in] - serialized data in memory</param>
///  <param name="nbytes">[in] - number of bytes in data string</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixDeserializeFromMemory(
				 Byte[] data, 
				 uint nbytes){

		IntPtr dataPtr = 	Marshal.AllocHGlobal(data.Length);
		Marshal.Copy(data, 0, dataPtr, data.Length);

	IntPtr _Result = Natives.pixDeserializeFromMemory(  dataPtr,   nbytes);
	
	Marshal.FreeHGlobal(dataPtr);
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
