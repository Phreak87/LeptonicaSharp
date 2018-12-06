using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// dwacomb.2.c (37, 6)
// pixMorphDwa_2(pixd, pixs, operation, selname) as Pix
// pixMorphDwa_2(PIX *, PIX *, l_int32, char *) as PIX *
///  <summary>
/// (1) This simply adds a border, calls the appropriate
/// pixFMorphopGen_(), and removes the border.
/// See the notes for that function.<para/>
/// 
/// (2) The size of the border depends on the operation
/// and the boundary conditions.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMorphDwa_2/*"/>
///  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
///   <returns>pixd</returns>
public static Pix pixMorphDwa_2(
				 Pix pixd, 
				 Pix pixs, 
				 int operation, 
				 String selname){

	IntPtr _Result = Natives.pixMorphDwa_2(pixd.Pointer, pixs.Pointer,   operation,   selname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// dwacomb.2.c (38, 6)
// pixFMorphopGen_2(pixd, pixs, operation, selname) as Pix
// pixFMorphopGen_2(PIX *, PIX *, l_int32, char *) as PIX *
///  <summary>
/// (1) This is a dwa operation, and the Sels must be limited in
/// size to not more than 31 pixels about the origin.<para/>
/// 
/// (2) A border of appropriate size (32 pixels, or 64 pixels
/// for safe closing with asymmetric b.c.) must be added before
/// this function is called.<para/>
/// 
/// (3) This handles all required setting of the border pixels
/// before erosion and dilation.<para/>
/// 
/// (4) The closing operation is safe no pixels can be removed
/// near the boundary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFMorphopGen_2/*"/>
///  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
///   <returns>pixd</returns>
public static Pix pixFMorphopGen_2(
				 Pix pixd, 
				 Pix pixs, 
				 int operation, 
				 String selname){

	IntPtr _Result = Natives.pixFMorphopGen_2(pixd.Pointer, pixs.Pointer,   operation,   selname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// dwacomb.2.c (39, 9)
// fmorphopgen_low_2(datad, w, h, wpld, datas, wpls, index) as int
// fmorphopgen_low_2(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fmorphopgen_low_2/*"/>
///   <returns></returns>
public static int fmorphopgen_low_2(
				 object datad, 
				 int w, 
				 int h, 
				 int wpld, 
				 object datas, 
				 int wpls, 
				 int index){

	int _Result = Natives.fmorphopgen_low_2(  datad,   w,   h,   wpld,   datas,   wpls,   index);
	
	return _Result;
}


}
}
