using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// fhmtgen.1.c (37, 6)
// pixHMTDwa_1(pixd, pixs, selname) as Pix
// pixHMTDwa_1(PIX *, PIX *, const char *) as PIX *
///  <summary>
/// (1) This simply adds a 32 pixel border, calls the appropriate
/// pixFHMTGen_(), and removes the border.
/// See notes below for that function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHMTDwa_1/*"/>
///  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///   <returns>pixd</returns>
public static Pix pixHMTDwa_1(
				 Pix pixd, 
				 Pix pixs, 
				 String selname){

	IntPtr _Result = Natives.pixHMTDwa_1(pixd.Pointer, pixs.Pointer,   selname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// fhmtgen.1.c (38, 6)
// pixFHMTGen_1(pixd, pixs, selname) as Pix
// pixFHMTGen_1(PIX *, PIX *, const char *) as PIX *
///  <summary>
/// (1) This is a dwa implementation of the hit-miss transform
/// on pixs by the sel.<para/>
/// 
/// (2) The sel must be limited in size to not more than 31 pixels
/// about the origin.  It must have at least one hit, and it
/// can have any number of misses.<para/>
/// 
/// (3) This handles all required setting of the border pixels
/// before erosion and dilation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFHMTGen_1/*"/>
///  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///   <returns>pixd</returns>
public static Pix pixFHMTGen_1(
				 Pix pixd, 
				 Pix pixs, 
				 String selname){

	IntPtr _Result = Natives.pixFHMTGen_1(pixd.Pointer, pixs.Pointer,   selname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// fhmtgen.1.c (39, 9)
// fhmtgen_low_1(datad, w, h, wpld, datas, wpls, index) as int
// fhmtgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtgen_low_1/*"/>
///   <returns></returns>
public static int fhmtgen_low_1(
				 object datad, 
				 int w, 
				 int h, 
				 int wpld, 
				 object datas, 
				 int wpls, 
				 int index){

	int _Result = Natives.fhmtgen_low_1(  datad,   w,   h,   wpld,   datas,   wpls,   index);
	
	return _Result;
}


}
}
