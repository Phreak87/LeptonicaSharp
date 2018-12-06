using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// graymorph.c (158, 1)
// pixErodeGray(pixs, hsize, vsize) as Pix
// pixErodeGray(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Sel is a brick with all elements being hits<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeGray/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
///  <param name="vsize">[in] - ditto</param>
///   <returns>pixd</returns>
public static Pix pixErodeGray(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixErodeGray(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (274, 1)
// pixDilateGray(pixs, hsize, vsize) as Pix
// pixDilateGray(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Sel is a brick with all elements being hits<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateGray/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
///  <param name="vsize">[in] - ditto</param>
///   <returns>pixd</returns>
public static Pix pixDilateGray(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixDilateGray(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (390, 1)
// pixOpenGray(pixs, hsize, vsize) as Pix
// pixOpenGray(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Sel is a brick with all elements being hits<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenGray/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
///  <param name="vsize">[in] - ditto</param>
///   <returns>pixd</returns>
public static Pix pixOpenGray(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixOpenGray(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (522, 1)
// pixCloseGray(pixs, hsize, vsize) as Pix
// pixCloseGray(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Sel is a brick with all elements being hits<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseGray/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
///  <param name="vsize">[in] - ditto</param>
///   <returns>pixd</returns>
public static Pix pixCloseGray(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixCloseGray(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (661, 1)
// pixErodeGray3(pixs, hsize, vsize) as Pix
// pixErodeGray3(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.<para/>
/// 
/// (3) It would be nice not to add a border, but it is required
/// if we want the same results as from the general case.
/// We add 4 bytes on the left to speed up the copying, and
/// 8 bytes at the right and bottom to allow unrolling of
/// the computation of 8 pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeGray3/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///  <param name="hsize">[in] - 1 or 3</param>
///  <param name="vsize">[in] - 1 or 3</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixErodeGray3(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixErodeGray3(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (847, 1)
// pixDilateGray3(pixs, hsize, vsize) as Pix
// pixDilateGray3(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateGray3/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///  <param name="hsize">[in] - 1 or 3</param>
///  <param name="vsize">[in] - 1 or 3</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixDilateGray3(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixDilateGray3(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (1032, 1)
// pixOpenGray3(pixs, hsize, vsize) as Pix
// pixOpenGray3(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.<para/>
/// 
/// (3) It would be nice not to add a border, but it is required
/// to get the same results as for the general case.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenGray3/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///  <param name="hsize">[in] - 1 or 3</param>
///  <param name="vsize">[in] - 1 or 3</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixOpenGray3(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixOpenGray3(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// graymorph.c (1098, 1)
// pixCloseGray3(pixs, hsize, vsize) as Pix
// pixCloseGray3(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)<para/>
/// 
/// (2) If hsize = vsize = 1, just returns a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseGray3/*"/>
///  <param name="pixs">[in] - 8 bpp, not cmapped</param>
///  <param name="hsize">[in] - 1 or 3</param>
///  <param name="vsize">[in] - 1 or 3</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixCloseGray3(
				 Pix pixs, 
				 int hsize, 
				 int vsize){

	IntPtr _Result = Natives.pixCloseGray3(pixs.Pointer,   hsize,   vsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
