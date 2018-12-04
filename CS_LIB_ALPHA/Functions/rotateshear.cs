using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (196, 1)
// pixRotateShear(pixs, xcen, ycen, angle, incolor) as Pix
// pixRotateShear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This rotates an image about the given point, using
/// either 2 or 3 shears.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (4) For rotation angles larger than about 0.35 radians, we issue
/// a warning because you should probably be using another method
/// (either sampling or area mapping)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateShear/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="xcen">[in] - x value for which there is no horizontal shear</param>
///  <param name="ycen">[in] - y value for which there is no vertical shear</param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>

public static Pix pixRotateShear(
				 Pix pixs, 
				 int xcen, 
				 int ycen, 
				 Single angle, 
				 int incolor){



	IntPtr _Result = Natives.pixRotateShear(
pixs.Pointer,   xcen,   ycen,   angle,   incolor);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (248, 1)
// pixRotate2Shear(pixs, xcen, ycen, angle, incolor) as Pix
// pixRotate2Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This rotates the image about the given point, using the 2-shear
/// method.  It should only be used for angles smaller than
/// MAX_2_SHEAR_ANGLE.  For larger angles, a warning is issued.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) 2-shear rotation by a specified angle is equivalent
/// to the sequential transformations
/// x' = x + tan(angle)  (y - ycen) for x-shear
/// y' = y + tan(angle)  (x - xcen) for y-shear<para/>
/// 
/// (4) Computation of tan(angle) is performed within the shear operation.<para/>
/// 
/// (5) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (6) If the image has an alpha layer, it is rotated separately by
/// two shears.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotate2Shear/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="xcen">[in] - center of rotation</param>
///  <param name="ycen">[in] - center of rotation</param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>

public static Pix pixRotate2Shear(
				 Pix pixs, 
				 int xcen, 
				 int ycen, 
				 Single angle, 
				 int incolor){



	IntPtr _Result = Natives.pixRotate2Shear(
pixs.Pointer,   xcen,   ycen,   angle,   incolor);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (319, 1)
// pixRotate3Shear(pixs, xcen, ycen, angle, incolor) as Pix
// pixRotate3Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
///  <summary>
/// (1) This rotates the image about the given point, using the 3-shear
/// method.  It should only be used for angles smaller than
/// LIMIT_SHEAR_ANGLE.  For larger angles, a warning is issued.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) 3-shear rotation by a specified angle is equivalent
/// to the sequential transformations
/// y' = y + tan(angle/2)  (x - xcen) for first y-shear
/// x' = x + sin(angle)  (y - ycen) for x-shear
/// y' = y + tan(angle/2)  (x - xcen) for second y-shear<para/>
/// 
/// (4) Computation of tan(angle) is performed in the shear operations.<para/>
/// 
/// (5) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (6) If the image has an alpha layer, it is rotated separately by
/// two shears.<para/>
/// 
/// (7) The algorithm was published by Alan Paeth: "A Fast Algorithm
/// for General Raster Rotation," Graphics Interface '86,
/// pp. 77-81, May 1986.  A description of the method, along with
/// an implementation, can be found in Graphics Gems, p. 179,
/// edited by Andrew Glassner, published by Academic Press, 1990.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotate3Shear/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="xcen">[in] - center of rotation</param>
///  <param name="ycen">[in] - center of rotation</param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>

public static Pix pixRotate3Shear(
				 Pix pixs, 
				 int xcen, 
				 int ycen, 
				 Single angle, 
				 int incolor){



	IntPtr _Result = Natives.pixRotate3Shear(
pixs.Pointer,   xcen,   ycen,   angle,   incolor);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (395, 1)
// pixRotateShearIP(pixs, xcen, ycen, angle, incolor) as int
// pixRotateShearIP(PIX *, l_int32, l_int32, l_float32, l_int32) as l_ok
///  <summary>
/// (1) This does an in-place rotation of the image about the
/// specified point, using the 3-shear method.  It should only
/// be used for angles smaller than LIMIT_SHEAR_ANGLE.
/// For larger angles, a warning is issued.<para/>
/// 
/// (2) A positive angle gives a clockwise rotation.<para/>
/// 
/// (3) 3-shear rotation by a specified angle is equivalent
/// to the sequential transformations
/// y' = y + tan(angle/2)  (x - xcen)  for first y-shear
/// x' = x + sin(angle)  (y - ycen)  for x-shear
/// y' = y + tan(angle/2)  (x - xcen)  for second y-shear<para/>
/// 
/// (4) Computation of tan(angle) is performed in the shear operations.<para/>
/// 
/// (5) This brings in 'incolor' pixels from outside the image.<para/>
/// 
/// (6) The pix cannot be colormapped, because the in-place operation
/// only blits in 0 or 1 bits, not an arbitrary colormap index.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateShearIP/*"/>
///  <param name="pixs">[in] - any depth not colormapped</param>
///  <param name="xcen">[in] - center of rotation</param>
///  <param name="ycen">[in] - center of rotation</param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>

public static int pixRotateShearIP(
				 Pix pixs, 
				 int xcen, 
				 int ycen, 
				 Single angle, 
				 int incolor){



	int _Result = Natives.pixRotateShearIP(
pixs.Pointer,   xcen,   ycen,   angle,   incolor);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (439, 1)
// pixRotateShearCenter(pixs, angle, incolor) as Pix
// pixRotateShearCenter(PIX *, l_float32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateShearCenter/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error</returns>

public static Pix pixRotateShearCenter(
				 Pix pixs, 
				 Single angle, 
				 int incolor){



	IntPtr _Result = Natives.pixRotateShearCenter(
pixs.Pointer,   angle,   incolor);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// rotateshear.c (462, 1)
// pixRotateShearCenterIP(pixs, angle, incolor) as int
// pixRotateShearCenterIP(PIX *, l_float32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateShearCenterIP/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="angle">[in] - radians</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRotateShearCenterIP(
				 Pix pixs, 
				 Single angle, 
				 int incolor){



	int _Result = Natives.pixRotateShearCenterIP(
pixs.Pointer,   angle,   incolor);
	


//  



	return _Result;
}


}
}
