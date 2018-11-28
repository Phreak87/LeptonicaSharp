using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// shear.c (113, 1)
// pixHShear(pixd, pixs, yloc, radang, incolor) as Pix
// pixHShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) There are 3 cases:
/// (a) pixd == null (make a new pixd)
/// (b) pixd == pixs (in-place)
/// (c) pixd != pixs<para/>
/// 
/// (2) For these three cases, use these patterns, respectively:
/// pixd = pixHShear(NULL, pixs, ...)
/// pixHShear(pixs, pixs, ...)
/// pixHShear(pixd, pixs, ...)<para/>
/// 
/// (3) This shear leaves the horizontal line of pixels at y = yloc
/// invariant.  For a positive shear angle, pixels above this
/// line are shoved to the right, and pixels below this line
/// move to the left.<para/>
/// 
/// (4) With positive shear angle, this can be used, along with
/// pixVShear(), to perform a cw rotation, either with 2 shears
/// (for small angles) or in the general case with 3 shears.<para/>
/// 
/// (5) Changing the value of yloc is equivalent to translating
/// the result horizontally.<para/>
/// 
/// (6) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (7) For in-place operation, pixs cannot be colormapped,
/// because the in-place operation only blits in 0 or 1 bits,
/// not an arbitrary colormap index.<para/>
/// 
/// (8) The angle is brought into the range [-pi, -pi].  It is
/// not permitted to be within MIN_DIFF_FROM_HALF_PI radians
/// from either -pi/2 or pi/2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHShear/*"/>
///  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - no restrictions on depth</param>
///  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, always</returns>
public static Pix pixHShear(
				  Pix pixd, 
				  Pix pixs, 
				  int yloc, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixHShear(pixdPtr, pixs.Pointer,   yloc,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (230, 1)
// pixVShear(pixd, pixs, xloc, radang, incolor) as Pix
// pixVShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) There are 3 cases:
/// (a) pixd == null (make a new pixd)
/// (b) pixd == pixs (in-place)
/// (c) pixd != pixs<para/>
/// 
/// (2) For these three cases, use these patterns, respectively:
/// pixd = pixVShear(NULL, pixs, ...)
/// pixVShear(pixs, pixs, ...)
/// pixVShear(pixd, pixs, ...)<para/>
/// 
/// (3) This shear leaves the vertical line of pixels at x = xloc
/// invariant.  For a positive shear angle, pixels to the right
/// of this line are shoved downward, and pixels to the left
/// of the line move upward.<para/>
/// 
/// (4) With positive shear angle, this can be used, along with
/// pixHShear(), to perform a cw rotation, either with 2 shears
/// (for small angles) or in the general case with 3 shears.<para/>
/// 
/// (5) Changing the value of xloc is equivalent to translating
/// the result vertically.<para/>
/// 
/// (6) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (7) For in-place operation, pixs cannot be colormapped,
/// because the in-place operation only blits in 0 or 1 bits,
/// not an arbitrary colormap index.<para/>
/// 
/// (8) The angle is brought into the range [-pi, -pi].  It is
/// not permitted to be within MIN_DIFF_FROM_HALF_PI radians
/// from either -pi/2 or pi/2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVShear/*"/>
///  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - no restrictions on depth</param>
///  <param name="xloc">[in] - location of vertical line, measured from origin</param>
///  <param name="radang">[in] - angle in radians not too close to +-(pi / 2)</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixVShear(
				  Pix pixd, 
				  Pix pixs, 
				  int xloc, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixVShear(pixdPtr, pixs.Pointer,   xloc,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (328, 1)
// pixHShearCorner(pixd, pixs, radang, incolor) as Pix
// pixHShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) See pixHShear() for usage.<para/>
/// 
/// (2) This does a horizontal shear about the UL corner, with (+) shear
/// pushing increasingly leftward (-x) with increasing y.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHShearCorner/*"/>
///  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
///  <param name="pixs">[in] - </param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>
public static Pix pixHShearCorner(
				  Pix pixd, 
				  Pix pixs, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixHShearCorner(pixdPtr, pixs.Pointer,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (359, 1)
// pixVShearCorner(pixd, pixs, radang, incolor) as Pix
// pixVShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) See pixVShear() for usage.<para/>
/// 
/// (2) This does a vertical shear about the UL corner, with (+) shear
/// pushing increasingly downward (+y) with increasing x.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVShearCorner/*"/>
///  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
///  <param name="pixs">[in] - </param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>
public static Pix pixVShearCorner(
				  Pix pixd, 
				  Pix pixs, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixVShearCorner(pixdPtr, pixs.Pointer,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (390, 1)
// pixHShearCenter(pixd, pixs, radang, incolor) as Pix
// pixHShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) See pixHShear() for usage.<para/>
/// 
/// (2) This does a horizontal shear about the center, with (+) shear
/// pushing increasingly leftward (-x) with increasing y.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHShearCenter/*"/>
///  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
///  <param name="pixs">[in] - </param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>
public static Pix pixHShearCenter(
				  Pix pixd, 
				  Pix pixs, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixHShearCenter(pixdPtr, pixs.Pointer,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (421, 1)
// pixVShearCenter(pixd, pixs, radang, incolor) as Pix
// pixVShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
///  <summary>
/// (1) See pixVShear() for usage.<para/>
/// 
/// (2) This does a vertical shear about the center, with (+) shear
/// pushing increasingly downward (+y) with increasing x.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVShearCenter/*"/>
///  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
///  <param name="pixs">[in] - </param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>
public static Pix pixVShearCenter(
				  Pix pixd, 
				  Pix pixs, 
				  Single radang, 
				  int incolor){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixVShearCenter(pixdPtr, pixs.Pointer,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (459, 1)
// pixHShearIP(pixs, yloc, radang, incolor) as int
// pixHShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place version of pixHShear() see comments there.<para/>
/// 
/// (2) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (3) pixs cannot be colormapped, because the in-place operation
/// only blits in 0 or 1 bits, not an arbitrary colormap index.<para/>
/// 
/// (4) Does a horizontal full-band shear about the line with (+) shear
/// pushing increasingly leftward (-x) with increasing y.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHShearIP/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixHShearIP(
				  Pix pixs, 
				  int yloc, 
				  Single radang, 
				  int incolor){

	int _Result = Natives.pixHShearIP(pixs.Pointer,   yloc,   radang,   incolor);
	



	return _Result;
}

// shear.c (534, 1)
// pixVShearIP(pixs, xloc, radang, incolor) as int
// pixVShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place version of pixVShear() see comments there.<para/>
/// 
/// (2) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (3) pixs cannot be colormapped, because the in-place operation
/// only blits in 0 or 1 bits, not an arbitrary colormap index.<para/>
/// 
/// (4) Does a vertical full-band shear about the line with (+) shear
/// pushing increasingly downward (+y) with increasing x.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVShearIP/*"/>
///  <param name="pixs">[in] - all depths not colormapped</param>
///  <param name="xloc">[in] - location of vertical line, measured from origin</param>
///  <param name="radang">[in] - angle in radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixVShearIP(
				  Pix pixs, 
				  int xloc, 
				  Single radang, 
				  int incolor){

	int _Result = Natives.pixVShearIP(pixs.Pointer,   xloc,   radang,   incolor);
	



	return _Result;
}

// shear.c (617, 1)
// pixHShearLI(pixs, yloc, radang, incolor) as Pix
// pixHShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This does horizontal shear with linear interpolation for
/// accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.
/// It is relatively slow compared to the sampled version
/// implemented by rasterop, but the result is much smoother.<para/>
/// 
/// (2) This shear leaves the horizontal line of pixels at y = yloc
/// invariant.  For a positive shear angle, pixels above this
/// line are shoved to the right, and pixels below this line
/// move to the left.<para/>
/// 
/// (3) Any colormap is removed.<para/>
/// 
/// (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],
/// where del == MIN_DIFF_FROM_HALF_PI.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHShearLI/*"/>
///  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
///  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
///  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd sheared, or NULL on error</returns>
public static Pix pixHShearLI(
				  Pix pixs, 
				  int yloc, 
				  Single radang, 
				  int incolor){

	IntPtr _Result = Natives.pixHShearLI(pixs.Pointer,   yloc,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// shear.c (729, 1)
// pixVShearLI(pixs, xloc, radang, incolor) as Pix
// pixVShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This does vertical shear with linear interpolation for
/// accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.
/// It is relatively slow compared to the sampled version
/// implemented by rasterop, but the result is much smoother.<para/>
/// 
/// (2) This shear leaves the vertical line of pixels at x = xloc
/// invariant.  For a positive shear angle, pixels to the right
/// of this line are shoved downward, and pixels to the left
/// of the line move upward.<para/>
/// 
/// (3) Any colormap is removed.<para/>
/// 
/// (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],
/// where del == MIN_DIFF_FROM_HALF_PI.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVShearLI/*"/>
///  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
///  <param name="xloc">[in] - location of vertical line, measured from origin</param>
///  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd sheared, or NULL on error</returns>
public static Pix pixVShearLI(
				  Pix pixs, 
				  int xloc, 
				  Single radang, 
				  int incolor){

	IntPtr _Result = Natives.pixVShearLI(pixs.Pointer,   xloc,   radang,   incolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

}
