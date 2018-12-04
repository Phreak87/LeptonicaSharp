using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// gifiostub.c (45, 7)
// pixReadStreamGif(fp) as Pix
// pixReadStreamGif(FILE *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamGif/*"/>
///   <returns></returns>

public static Pix pixReadStreamGif(
				 FILE fp){


	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}

	IntPtr _Result = Natives.pixReadStreamGif(
fp.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// gifiostub.c (52, 7)
// pixReadMemGif(cdata, size) as Pix
// pixReadMemGif(const l_uint8 *, size_t) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemGif/*"/>
///   <returns></returns>

public static Pix pixReadMemGif(
				 Byte[] cdata, 
				 uint size){



	IntPtr _Result = Natives.pixReadMemGif(
  cdata,   size);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// gifiostub.c (59, 6)
// pixWriteStreamGif(fp, pix) as int
// pixWriteStreamGif(FILE *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamGif/*"/>
///   <returns></returns>

public static int pixWriteStreamGif(
				 FILE fp, 
				 Pix pix){


	IntPtr fpPtr = IntPtr.Zero; if (fp != null) {fpPtr = fp.Pointer;}
	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixWriteStreamGif(
fp.Pointer, pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// gifiostub.c (66, 6)
// pixWriteMemGif(pdata, psize, pix) as int
// pixWriteMemGif(l_uint8 **, size_t *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemGif/*"/>
///   <returns></returns>

public static int pixWriteMemGif(
				 object pdata, 
				 object psize, 
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixWriteMemGif(
  pdata,   psize, pix.Pointer);
	


//  



	return _Result;
}


}
}
