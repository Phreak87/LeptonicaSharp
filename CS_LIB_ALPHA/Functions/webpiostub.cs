using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (45, 7)
// pixReadStreamWebP(fp) as Pix
// pixReadStreamWebP(FILE *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamWebP/*"/>
///   <returns></returns>

public static Pix pixReadStreamWebP(
				 FILE fp){


	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}

	IntPtr _Result = Natives.pixReadStreamWebP(
fp.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (52, 7)
// pixReadMemWebP(filedata, filesize) as Pix
// pixReadMemWebP(const l_uint8 *, size_t) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemWebP/*"/>
///   <returns></returns>

public static Pix pixReadMemWebP(
				 Byte[] filedata, 
				 uint filesize){



	IntPtr _Result = Natives.pixReadMemWebP(
  filedata,   filesize);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (59, 6)
// readHeaderWebP(filename, pw, ph, pspp) as int
// readHeaderWebP(const char *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderWebP/*"/>
///   <returns></returns>

public static int readHeaderWebP(
				 String filename, 
				 object pw, 
				 object ph, 
				 object pspp){



	int _Result = Natives.readHeaderWebP(
  filename,   pw,   ph,   pspp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (67, 6)
// readHeaderMemWebP(data, size, pw, ph, pspp) as int
// readHeaderMemWebP(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemWebP/*"/>
///   <returns></returns>

public static int readHeaderMemWebP(
				 Byte[] data, 
				 uint size, 
				 object pw, 
				 object ph, 
				 object pspp){



	int _Result = Natives.readHeaderMemWebP(
  data,   size,   pw,   ph,   pspp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (75, 6)
// pixWriteWebP(filename, pixs, quality, lossless) as int
// pixWriteWebP(const char *, PIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteWebP/*"/>
///   <returns></returns>

public static int pixWriteWebP(
				 String filename, 
				 Pix pixs, 
				 int quality, 
				 int lossless){


	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixWriteWebP(
  filename, pixs.Pointer,   quality,   lossless);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (83, 6)
// pixWriteStreamWebP(fp, pixs, quality, lossless) as int
// pixWriteStreamWebP(FILE *, PIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamWebP/*"/>
///   <returns></returns>

public static int pixWriteStreamWebP(
				 FILE fp, 
				 Pix pixs, 
				 int quality, 
				 int lossless){


	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixWriteStreamWebP(
fp.Pointer, pixs.Pointer,   quality,   lossless);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// webpiostub.c (91, 6)
// pixWriteMemWebP(pencdata, pencsize, pixs, quality, lossless) as int
// pixWriteMemWebP(l_uint8 **, size_t *, PIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemWebP/*"/>
///   <returns></returns>

public static int pixWriteMemWebP(
				 object pencdata, 
				 object pencsize, 
				 Pix pixs, 
				 int quality, 
				 int lossless){


	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixWriteMemWebP(
  pencdata,   pencsize, pixs.Pointer,   quality,   lossless);
	


//  



	return _Result;
}


}
}
