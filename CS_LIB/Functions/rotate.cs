using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// rotate.c (99, 1)
		// pixRotate(pixs, angle, type, incolor, width, height) as Pix
		// pixRotate(PIX *, l_float32, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This is a high-level, simple interface for rotating images
		/// about their center.<para/>
		///
		/// (2) For very small rotations, just return a clone.<para/>
		///
		/// (3) Rotation brings either white or black pixels in
		/// from outside the image.<para/>
		///
		/// (4) The rotation type is adjusted if necessary for the image
		/// depth and size of rotation angle.  For 1 bpp images, we
		/// rotate either by shear or sampling.<para/>
		///
		/// (5) Colormaps are removed for rotation by area mapping.<para/>
		///
		/// (6) The dest can be expanded so that no image pixels
		/// are lost.  To invoke expansion, input the original
		/// width and height.  For repeated rotation, use of the
		/// original width and height allows the expansion to
		/// stop at the maximum required size, which is a square
		/// with side = sqrt(ww + hh).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotate/*"/>
		///  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
		///  <param name="angle">[in] - radians clockwise is positive</param>
		///  <param name="type">[in] - L_ROTATE_AREA_MAP, L_ROTATE_SHEAR, L_ROTATE_SAMPLING</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///  <param name="width">[in] - original width use 0 to avoid embedding</param>
		///  <param name="height">[in] - original height use 0 to avoid embedding</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixRotate(
						Pix pixs,
						Single angle,
						int type,
						int incolor,
						int width,
						int height)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRotate(pixs.Pointer,   angle,   type,   incolor,   width,   height);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// rotate.c (241, 1)
		// pixEmbedForRotation(pixs, angle, incolor, width, height) as Pix
		// pixEmbedForRotation(PIX *, l_float32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) For very small rotations, just return a clone.<para/>
		///
		/// (2) Generate larger image to embed pixs if necessary, and
		/// place the center of the input image in the center.<para/>
		///
		/// (3) Rotation brings either white or black pixels in
		/// from outside the image.  For colormapped images where
		/// there is no white or black, a new color is added if
		/// possible for these pixels otherwise, either the
		/// lightest or darkest color is used.  In most cases,
		/// the colormap will be removed prior to rotation.<para/>
		///
		/// (4) The dest is to be expanded so that no image pixels
		/// are lost after rotation.  Input of the original width
		/// and height allows the expansion to stop at the maximum
		/// required size, which is a square with side equal to
		/// sqrt(ww + hh).<para/>
		///
		/// (5) For an arbitrary angle, the expansion can be found by
		/// considering the UL and UR corners.  As the image is
		/// rotated, these move in an arc centered at the center of
		/// the image.  Normalize to a unit circle by dividing by half
		/// the image diagonal.  After a rotation of T radians, the UL
		/// and UR corners are at points T radians along the unit
		/// circle.  Compute the x and y coordinates of both these
		/// points and take the max of absolute values these represent
		/// the half width and half height of the containing rectangle.
		/// The arithmetic is done using formulas for sin(a+b) and cos(a+b),
		/// where b = T.  For the UR corner, sin(a) = h/d and cos(a) = w/d.
		/// For the UL corner, replace a by (pi - a), and you have
		/// sin(pi - a) = h/d, cos(pi - a) = -w/d.  The equations
		/// given below follow directly.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEmbedForRotation/*"/>
		///  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
		///  <param name="angle">[in] - radians clockwise is positive</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///  <param name="width">[in] - original width use 0 to avoid embedding</param>
		///  <param name="height">[in] - original height use 0 to avoid embedding</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixEmbedForRotation(
						Pix pixs,
						Single angle,
						int incolor,
						int width,
						int height)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixEmbedForRotation(pixs.Pointer,   angle,   incolor,   width,   height);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// rotate.c (322, 1)
		// pixRotateBySampling(pixs, xcen, ycen, angle, incolor) as Pix
		// pixRotateBySampling(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
		///  <summary>
		/// (1) For very small rotations, just return a clone.<para/>
		///
		/// (2) Rotation brings either white or black pixels in
		/// from outside the image.<para/>
		///
		/// (3) Colormaps are retained.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateBySampling/*"/>
		///  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp rgb can be cmapped</param>
		///  <param name="xcen">[in] - x value of center of rotation</param>
		///  <param name="ycen">[in] - y value of center of rotation</param>
		///  <param name="angle">[in] - radians clockwise is positive</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixRotateBySampling(
						Pix pixs,
						int xcen,
						int ycen,
						Single angle,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRotateBySampling(pixs.Pointer,   xcen,   ycen,   angle,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// rotate.c (455, 1)
		// pixRotateBinaryNice(pixs, angle, incolor) as Pix
		// pixRotateBinaryNice(PIX *, l_float32, l_int32) as PIX *
		///  <summary>
		/// (1) For very small rotations, just return a clone.<para/>
		///
		/// (2) This does a computationally expensive rotation of 1 bpp images.
		/// The fastest rotators (using shears or subsampling) leave
		/// visible horizontal and vertical shear lines across which
		/// the image shear changes by one pixel.  To ameliorate the
		/// visual effect one can introduce random dithering.  One
		/// way to do this in a not-too-random fashion is given here.
		/// We convert to 8 bpp, do a very small blur, rotate using
		/// linear interpolation (same as area mapping), do a
		/// small amount of sharpening to compensate for the initial
		/// blur, and threshold back to binary.  The shear lines
		/// are magically removed.<para/>
		///
		/// (3) This operation is about 5x slower than rotation by sampling.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateBinaryNice/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="angle">[in] - radians clockwise is positive about the center</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixRotateBinaryNice(
						Pix pixs,
						Single angle,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixRotateBinaryNice(pixs.Pointer,   angle,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// rotate.c (533, 1)
		// pixRotateWithAlpha(pixs, angle, pixg, fract) as Pix
		// pixRotateWithAlpha(PIX *, l_float32, PIX *, l_float32) as PIX *
		///  <summary>
		/// (1) The alpha channel is transformed separately from pixs,
		/// and aligns with it, being fully transparent outside the
		/// boundary of the transformed pixs.  For pixels that are fully
		/// transparent, a blending function like pixBlendWithGrayMask()
		/// will give zero weight to corresponding pixels in pixs.<para/>
		///
		/// (2) Rotation is about the center of the image for very small
		/// rotations, just return a clone.  The dest is automatically
		/// expanded so that no image pixels are lost.<para/>
		///
		/// (3) Rotation is by area mapping.  It doesn't matter what
		/// color is brought in because the alpha channel will
		/// be transparent (black) there.<para/>
		///
		/// (4) If pixg is NULL, it is generated as an alpha layer that is
		/// partially opaque, using %fract.  Otherwise, it is cropped
		/// to pixs if required and %fract is ignored.  The alpha
		/// channel in pixs is never used.<para/>
		///
		/// (4) Colormaps are removed to 32 bpp.<para/>
		///
		/// (5) The default setting for the border values in the alpha channel
		/// is 0 (transparent) for the outermost ring of pixels and
		/// (0.5  fract  255) for the second ring.  When blended over
		/// a second image, this
		/// (a) shrinks the visible image to make a clean overlap edge
		/// with an image below, and
		/// (b) softens the edges by weakening the aliasing there.
		/// Use l_setAlphaMaskBorder() to change these values.<para/>
		///
		/// (6) A subtle use of gamma correction is to remove gamma correction
		/// before rotation and restore it afterwards.  This is done
		/// by sandwiching this function between a gamma/inverse-gamma
		/// photometric transform:
		/// pixt = pixGammaTRCWithAlpha(NULL, pixs, 1.0 / gamma, 0, 255)
		/// pixd = pixRotateWithAlpha(pixt, angle, NULL, fract)
		/// pixGammaTRCWithAlpha(pixd, pixd, gamma, 0, 255)
		/// pixDestroy([and]pixt)
		/// This has the side-effect of producing artifacts in the very
		/// dark regions.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateWithAlpha/*"/>
		///  <param name="pixs">[in] - 32 bpp rgb or cmapped</param>
		///  <param name="angle">[in] - radians clockwise is positive</param>
		///  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
		///  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
		///   <returns>pixd 32 bpp rgba, or NULL on error</returns>
		public static Pix pixRotateWithAlpha(
						Pix pixs,
						Single angle,
						Pix pixg,
						Single fract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}
			IntPtr _Result = Natives.pixRotateWithAlpha(pixs.Pointer,   angle, pixgPtr,   fract);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}


	}
}
