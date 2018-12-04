using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (145, 1)
// pixReadStreamPnm(fp) as Pix
// pixReadStreamPnm(FILE *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamPnm/*"/>
///  <param name="fp">[in] - file stream opened for read</param>
///   <returns>pix, or NULL on error</returns>

public static Pix pixReadStreamPnm(
				 FILE fp){



	IntPtr _Result = Natives.pixReadStreamPnm(
fp.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (447, 1)
// readHeaderPnm(filename, pw, ph, pd, ptype, pbps, pspp) as int
// readHeaderPnm(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderPnm/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pd">[out][optional] - </param>
///  <param name="ptype">[out][optional] - pnm type</param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>

public static int readHeaderPnm(
				 String filename, 
				out int pw, 
				out int ph, 
				out int pd, 
				out int ptype, 
				out int pbps, 
				out int pspp){



	int _Result = Natives.readHeaderPnm(
  filename, out  pw, out  ph, out  pd, out  ptype, out  pbps, out  pspp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (490, 1)
// freadHeaderPnm(fp, pw, ph, pd, ptype, pbps, pspp) as int
// freadHeaderPnm(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderPnm/*"/>
///  <param name="fp">[in] - file stream opened for read</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pd">[out][optional] - </param>
///  <param name="ptype">[out][optional] - pnm type</param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>

public static int freadHeaderPnm(
				 FILE fp, 
				out int pw, 
				out int ph, 
				out int pd, 
				out int ptype, 
				out int pbps, 
				out int pspp){



	int _Result = Natives.freadHeaderPnm(
fp.Pointer, out  pw, out  ph, out  pd, out  ptype, out  pbps, out  pspp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (667, 1)
// pixWriteStreamPnm(fp, pix) as int
// pixWriteStreamPnm(FILE *, PIX *) as l_ok
///  <summary>
/// (1) This writes "raw" packed format only:
/// 1 bpp to pbm (P4)
/// 2, 4, 8, 16 bpp, no colormap or grayscale colormap to pgm (P5)
/// 2, 4, 8 bpp with color-valued colormap, or rgb to rgb ppm (P6)<para/>
/// 
/// (2) 24 bpp rgb are not supported in leptonica, but this will
/// write them out as a packed array of bytes (3 to a pixel).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPnm/*"/>
///  <param name="fp">[in] - file stream opened for write</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK 1 on error</returns>

public static int pixWriteStreamPnm(
				 FILE fp, 
				 Pix pix){



	int _Result = Natives.pixWriteStreamPnm(
fp.Pointer, pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (786, 1)
// pixWriteStreamAsciiPnm(fp, pix) as int
// pixWriteStreamAsciiPnm(FILE *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamAsciiPnm/*"/>
///  <param name="fp">[in] - file stream opened for write</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK 1 on error Writes "ASCII" format only: 1 bpp to pbm P1 2, 4, 8, 16 bpp, no colormap or grayscale colormap to pgm P2 2, 4, 8 bpp with color-valued colormap, or rgb to rgb ppm P3</returns>

public static int pixWriteStreamAsciiPnm(
				 FILE fp, 
				 Pix pix){



	int _Result = Natives.pixWriteStreamAsciiPnm(
fp.Pointer, pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (908, 1)
// pixWriteStreamPam(fp, pix) as int
// pixWriteStreamPam(FILE *, PIX *) as l_ok
///  <summary>
/// (1) This writes arbitrary PAM (P7) packed format.<para/>
/// 
/// (2) 24 bpp rgb are not supported in leptonica, but this will
/// write them out as a packed array of bytes (3 to a pixel).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPam/*"/>
///  <param name="fp">[in] - file stream opened for write</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK 1 on error</returns>

public static int pixWriteStreamPam(
				 FILE fp, 
				 Pix pix){



	int _Result = Natives.pixWriteStreamPam(
fp.Pointer, pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (1084, 1)
// pixReadMemPnm(data, size) as Pix
// pixReadMemPnm(const l_uint8 *, size_t) as PIX *
///  <summary>
/// (1) The %size byte of %data must be a null character.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemPnm/*"/>
///  <param name="data">[in] - const pnm-encoded</param>
///  <param name="size">[in] - of data</param>
///   <returns>pix, or NULL on error</returns>

public static Pix pixReadMemPnm(
				 Byte[] data, 
				 uint size){



	IntPtr _Result = Natives.pixReadMemPnm(
  data,   size);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (1117, 1)
// readHeaderMemPnm(data, size, pw, ph, pd, ptype, pbps, pspp) as int
// readHeaderMemPnm(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemPnm/*"/>
///  <param name="data">[in] - const pnm-encoded</param>
///  <param name="size">[in] - of data</param>
///  <param name="pw">[out][optional] - </param>
///  <param name="ph">[out][optional] - </param>
///  <param name="pd">[out][optional] - </param>
///  <param name="ptype">[out][optional] - pnm type</param>
///  <param name="pbps">[out][optional] - bits/sample</param>
///  <param name="pspp">[out][optional] - samples/pixel</param>
///   <returns>0 if OK, 1 on error</returns>

public static int readHeaderMemPnm(
				 Byte[] data, 
				 uint size, 
				out int pw, 
				out int ph, 
				out int pd, 
				out int ptype, 
				out int pbps, 
				out int pspp){



	int _Result = Natives.readHeaderMemPnm(
  data,   size, out  pw, out  ph, out  pd, out  ptype, out  pbps, out  pspp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (1159, 1)
// pixWriteMemPnm(pdata, psize, pix) as int
// pixWriteMemPnm(l_uint8 **, size_t *, PIX *) as l_ok
///  <summary>
/// (1) See pixWriteStreamPnm() for usage.  This version writes to
/// memory instead of to a file stream.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPnm/*"/>
///  <param name="pdata">[out] - data of PNM image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixWriteMemPnm(
				out Byte[] pdata, 
				out uint psize, 
				 Pix pix){


	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemPnm(
out  pdataPtr, out  psize, pix.Pointer);
	


//  
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pnmio.c (1214, 1)
// pixWriteMemPam(pdata, psize, pix) as int
// pixWriteMemPam(l_uint8 **, size_t *, PIX *) as l_ok
///  <summary>
/// (1) See pixWriteStreamPnm() for usage.  This version writes to
/// memory instead of to a file stream.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPam/*"/>
///  <param name="pdata">[out] - data of PAM image</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixWriteMemPam(
				out Byte[] pdata, 
				out uint psize, 
				 Pix pix){


	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixWriteMemPam(
out  pdataPtr, out  psize, pix.Pointer);
	


//  
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;



	return _Result;
}


}
}
