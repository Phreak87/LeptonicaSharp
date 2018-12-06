using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// jp2kheader.c (75, 1)
// readHeaderJp2k(filename, pw, ph, pbps, pspp) as int
// readHeaderJp2k(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderJp2k/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderJp2k(
				 String filename, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp){

	int _Result = Natives.readHeaderJp2k(  filename, out  pw, out  ph, out  pbps, out  pspp);
	
	return _Result;
}

// jp2kheader.c (112, 1)
// freadHeaderJp2k(fp, pw, ph, pbps, pspp) as int
// freadHeaderJp2k(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderJp2k/*"/>
///  <param name="fp">[in] - file stream opened for read</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int freadHeaderJp2k(
				 FILE fp, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp){

	int _Result = Natives.freadHeaderJp2k(fp.Pointer, out  pw, out  ph, out  pbps, out  pspp);
	
	return _Result;
}

// jp2kheader.c (167, 1)
// readHeaderMemJp2k(data, size, pw, ph, pbps, pspp) as int
// readHeaderMemJp2k(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) The ISO/IEC reference for jpeg2000 is
/// http://www.jpeg.org/public/15444-1annexi.pdf
/// and the file format syntax begins at page 127.<para/>
/// 
/// (2) The Image Header Box begins with 'ihdr' = 0x69686472 in
/// big-endian order.  This typically, but not always, starts
/// byte 44, with the big-endian data fields beginning at byte 48:
/// h:  4 bytes
/// w:  4 bytes
/// spp:  2 bytes
/// bps:  1 byte (contains bps - 1)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemJp2k/*"/>
///  <param name="data">[in] - </param>
///  <param name="size">[in] - at least 80</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int readHeaderMemJp2k(
				 Byte[] data, 
				 uint size, 
				out int pw, 
				out int ph, 
				out int pbps, 
				out int pspp){

	int _Result = Natives.readHeaderMemJp2k(  data,   size, out  pw, out  ph, out  pbps, out  pspp);
	
	return _Result;
}

// jp2kheader.c (240, 1)
// fgetJp2kResolution(fp, pxres, pyres) as int
// fgetJp2kResolution(FILE *, l_int32 *, l_int32 *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fgetJp2kResolution/*"/>
///   <returns></returns>
public static int fgetJp2kResolution(
				 FILE fp, 
				 object pxres, 
				 object pyres){

	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}

	int _Result = Natives.fgetJp2kResolution(fp.Pointer,   pxres,   pyres);
	
	return _Result;
}


}
}
