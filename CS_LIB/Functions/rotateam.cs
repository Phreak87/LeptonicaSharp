using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// rotateam.c (149, 1)
// pixRotateAM(pixs, angle, incolor) as Pix
// pixRotateAM(PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) Rotates about image center.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Brings in either black or white pixels from the boundary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAM/*"/>
///  <param name="pixs">[in] - 2, 4, 8 bpp gray or colormapped, or 32 bpp RGB</param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAM(
				 Pix pixs, 
				 Single angle, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAM(pixs.Pointer,   angle,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (212, 1)
// pixRotateAMColor(pixs, angle, colorval) as Pix
// pixRotateAMColor(PIX *, l_float32, l_uint32) as PIX *
///  <summary>
/// (1) Rotates about image center.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Specify the color to be brought in from outside the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMColor/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMColor(
				 Pix pixs, 
				 Single angle, 
				 uint colorval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAMColor(pixs.Pointer,   angle,   colorval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (266, 1)
// pixRotateAMGray(pixs, angle, grayval) as Pix
// pixRotateAMGray(PIX *, l_float32, l_uint8) as PIX *
///  <summary>
/// (1) Rotates about image center.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Specify the grayvalue to be brought in from outside the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMGray/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMGray(
				 Pix pixs, 
				 Single angle, 
				 byte grayval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr _Result = Natives.pixRotateAMGray(pixs.Pointer,   angle,   grayval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (447, 1)
// pixRotateAMCorner(pixs, angle, incolor) as Pix
// pixRotateAMCorner(PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) Rotates about the UL corner of the image.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Brings in either black or white pixels from the boundary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMCorner/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8 bpp gray or colormapped, or 32 bpp RGB</param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMCorner(
				 Pix pixs, 
				 Single angle, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAMCorner(pixs.Pointer,   angle,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (508, 1)
// pixRotateAMColorCorner(pixs, angle, fillval) as Pix
// pixRotateAMColorCorner(PIX *, l_float32, l_uint32) as PIX *
///  <summary>
/// (1) Rotates the image about the UL corner.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Specify the color to be brought in from outside the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMColorCorner/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="fillval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMColorCorner(
				 Pix pixs, 
				 Single angle, 
				 uint fillval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAMColorCorner(pixs.Pointer,   angle,   fillval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (562, 1)
// pixRotateAMGrayCorner(pixs, angle, grayval) as Pix
// pixRotateAMGrayCorner(PIX *, l_float32, l_uint8) as PIX *
///  <summary>
/// (1) Rotates the image about the UL corner.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) Specify the grayvalue to be brought in from outside the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMGrayCorner/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMGrayCorner(
				 Pix pixs, 
				 Single angle, 
				 byte grayval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAMGrayCorner(pixs.Pointer,   angle,   grayval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rotateam.c (741, 1)
// pixRotateAMColorFast(pixs, angle, colorval) as Pix
// pixRotateAMColorFast(PIX *, l_float32, l_uint32) as PIX *
///  <summary>
/// (1) This rotates a color image about the image center.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) It uses area mapping, dividing each pixel into
/// 16 subpixels.<para/>
/// 
/// (4) It is about 10% to 20% faster than the more accurate linear
/// interpolation function pixRotateAMColor(),
/// which uses 256 subpixels.<para/>
/// 
/// (5) For some reason it shifts the image center.
/// No attempt is made to rotate the alpha component.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateAMColorFast/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="angle">[in] - radians clockwise is positive</param>
///  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRotateAMColorFast(
				 Pix pixs, 
				 Single angle, 
				 uint colorval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRotateAMColorFast(pixs.Pointer,   angle,   colorval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
