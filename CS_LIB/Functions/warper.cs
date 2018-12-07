using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// warper.c (107, 1)
// pixSimpleCaptcha(pixs, border, nterms, seed, color, cmapflag) as Pix
// pixSimpleCaptcha(PIX *, l_int32, l_int32, l_uint32, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) This uses typical default values for generating captchas.
/// The magnitudes of the harmonic warp are typically to be
/// smaller when more terms are used, even though the phases
/// are random.  See, for example, prog/warptest.c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSimpleCaptcha/*"/>
///  <param name="pixs">[in] - 8 bpp no colormap</param>
///  <param name="border">[in] - added white pixels on each side</param>
///  <param name="nterms">[in] - number of x and y harmonic terms</param>
///  <param name="seed">[in] - of random number generator</param>
///  <param name="color">[in] - for colorizing in 0xrrggbb00 format use 0 for black</param>
///  <param name="cmapflag">[in] - 1 for colormap output 0 for rgb</param>
///   <returns>pixd 8 bpp cmap or 32 bpp rgb, or NULL on error</returns>
public static Pix pixSimpleCaptcha(
				 Pix pixs, 
				 int border, 
				 int nterms, 
				 uint seed, 
				 uint color, 
				 int cmapflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixSimpleCaptcha(pixs.Pointer,   border,   nterms,   seed,   color,   cmapflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (181, 1)
// pixRandomHarmonicWarp(pixs, xmag, ymag, xfreq, yfreq, nx, ny, seed, grayval) as Pix
// pixRandomHarmonicWarp(PIX *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) To generate the warped image p(x',y'), set up the transforms
/// that are in getWarpTransform().  For each (x',y') in the
/// dest, the warp function computes the originating location
/// (x, y) in the src.  The differences (x - x') and (y - y')
/// are given as a sum of products of sinusoidal terms.  Each
/// term is multiplied by a maximum amplitude (in pixels), and the
/// angle is determined by a frequency and phase, and depends
/// on the (x', y') value of the dest.  Random numbers with
/// a variable input seed are used to allow the warping to be
/// unpredictable.  A linear interpolation is used to find
/// the value for the source at (x, y) this value is written
/// into the dest.<para/>
/// 
/// (2) This can be used to generate 'captcha's, which are somewhat
/// randomly distorted images of text.  A typical set of parameters
/// for a captcha are:
/// xmag = 4.0 ymag = 6.0
/// xfreq = 0.10 yfreq = 0.13
/// nx = 3 ny = 3
/// Other examples can be found in prog/warptest.c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRandomHarmonicWarp/*"/>
///  <param name="pixs">[in] - 8 bpp no colormap</param>
///  <param name="xmag">[in] - maximum magnitude of x and y distortion</param>
///  <param name="ymag">[in] - maximum magnitude of x and y distortion</param>
///  <param name="xfreq">[in] - maximum magnitude of x and y frequency</param>
///  <param name="yfreq">[in] - maximum magnitude of x and y frequency</param>
///  <param name="nx">[in] - number of x and y harmonic terms</param>
///  <param name="ny">[in] - number of x and y harmonic terms</param>
///  <param name="seed">[in] - of random number generator</param>
///  <param name="grayval">[in] - color brought in from the outside 0 for black, 255 for white</param>
///   <returns>pixd 8 bpp no colormap, or NULL on error</returns>
public static Pix pixRandomHarmonicWarp(
				 Pix pixs, 
				 Single xmag, 
				 Single ymag, 
				 Single xfreq, 
				 Single yfreq, 
				 int nx, 
				 int ny, 
				 uint seed, 
				 int grayval){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixRandomHarmonicWarp(pixs.Pointer,   xmag,   ymag,   xfreq,   yfreq,   nx,   ny,   seed,   grayval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (586, 1)
// pixWarpStereoscopic(pixs, zbend, zshiftt, zshiftb, ybendt, ybendb, redleft) as Pix
// pixWarpStereoscopic(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This function splits out the red channel, mucks around with
/// it, then recombines with the unmolested cyan channel.<para/>
/// 
/// (2) By using a quadratically increasing shift of the red
/// pixels horizontally and away from the vertical centerline,
/// the image appears to bend quadratically out of the image
/// plane, symmetrically with respect to the vertical center
/// line.  A positive value of %zbend causes the plane to be
/// curved away from the viewer.  We use linearly interpolated
/// stretching to avoid the appearance of kinks in the curve.<para/>
/// 
/// (3) The parameters %zshiftt and %zshiftb tilt the image plane
/// about a horizontal line through the center, and at the
/// same time move that line either in toward the viewer or away.
/// This is implemented by a combination of horizontal shear
/// about the center line (for the tilt) and horizontal
/// translation (to move the entire plane in or out).
/// A positive value of %zshiftt moves the top of the plane
/// away from the viewer, and a positive value of %zshiftb
/// moves the bottom of the plane away.  We use linear interpolated
/// shear to avoid visible vertical steps in the tilted image.<para/>
/// 
/// (4) The image can be bent in the plane and about the vertical
/// centerline.  The centerline does not shift, and the
/// parameter %ybend gives the relative shift at left and right
/// edges, with a downward shift for positive values of %ybend.<para/>
/// 
/// (6) When writing out a steroscopic (red/cyan) image in jpeg,
/// first call pixSetChromaSampling(pix, 0) to get sufficient
/// resolution in the red channel.<para/>
/// 
/// (7) Typical values are:
/// zbend = 20
/// zshiftt = 15
/// zshiftb = -15
/// ybendt = 30
/// ybendb = 0
/// If the disparity z-values are too large, it is difficult for
/// the brain to register the two images.<para/>
/// 
/// (8) This function has been cleverly reimplemented by Jeff Breidenbach.
/// The original implementation used two 32 bpp rgb images,
/// and merged them at the end.  The result is somewhat faded,
/// and has a parameter "thresh" that controls the amount of
/// color in the result.  (The present implementation avoids these
/// two problems, skipping both the colorization and the alpha
/// blending at the end, and is about 3x faster)
/// The basic operations with 32 bpp are as follows:
/// // Immediate conversion to 32 bpp
/// Pix pixt1 = pixConvertTo32(pixs)
/// // Do vertical shear
/// Pix pixr = pixQuadraticVerticalShear(pixt1, L_WARP_TO_RIGHT,
/// ybendt, ybendb,
/// L_BRING_IN_WHITE)
/// // Colorize two versions, toward red and cyan
/// Pix pixc = pixCopy(NULL, pixr)
/// l_int32 thresh = 150  // if higher, get less original color
/// pixColorGray(pixr, NULL, L_PAINT_DARK, thresh, 255, 0, 0)
/// pixColorGray(pixc, NULL, L_PAINT_DARK, thresh, 0, 255, 255)
/// // Shift the red pixels e.g., by stretching
/// Pix pixrs = pixStretchHorizontal(pixr, L_WARP_TO_RIGHT,
/// L_QUADRATIC_WARP, zbend,
/// L_INTERPOLATED,
/// L_BRING_IN_WHITE)
/// // Blend the shifted red and unshifted cyan 50:50
/// Pix pixg = pixCreate(w, h, 8)
/// pixSetAllArbitrary(pixg, 128)
/// pixd = pixBlendWithGrayMask(pixrs, pixc, pixg, 0, 0)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWarpStereoscopic/*"/>
///  <param name="pixs">[in] - any depth, colormap ok</param>
///  <param name="zbend">[in] - horizontal separation in pixels of red and cyan at the left and right sides, that gives rise to quadratic curvature out of the image plane</param>
///  <param name="zshiftt">[in] - uniform pixel translation difference between red and cyan, that pushes the top of the image plane away from the viewer (zshiftt  is greater  0) or towards the viewer (zshiftt  is smaller 0)</param>
///  <param name="zshiftb">[in] - uniform pixel translation difference between red and cyan, that pushes the bottom of the image plane away from the viewer (zshiftb  is greater  0) or towards the viewer (zshiftb  is smaller 0)</param>
///  <param name="ybendt">[in] - multiplicative parameter for in-plane vertical displacement at the left or right edge at the top: y = ybendt  (2x/w - 1)^2</param>
///  <param name="ybendb">[in] - same as ybendt, except at the left or right edge at the bottom</param>
///  <param name="redleft">[in] - 1 if the red filter is on the left 0 otherwise</param>
///   <returns>pixd 32 bpp, or NULL on error</returns>
public static Pix pixWarpStereoscopic(
				 Pix pixs, 
				 int zbend, 
				 int zshiftt, 
				 int zshiftb, 
				 int ybendt, 
				 int ybendb, 
				 int redleft){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixWarpStereoscopic(pixs.Pointer,   zbend,   zshiftt,   zshiftb,   ybendt,   ybendb,   redleft);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (733, 1)
// pixStretchHorizontal(pixs, dir, type, hmax, operation, incolor) as Pix
// pixStretchHorizontal(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) If %hmax  is greater  0, this is an increase in the coordinate value of
/// pixels in pixd, relative to the same pixel in pixs.<para/>
/// 
/// (2) If %dir == L_WARP_TO_LEFT, the pixels on the right edge of
/// the image are not moved. So, for example, if %hmax  is greater  0
/// and %dir == L_WARP_TO_LEFT, the pixels in pixd are
/// contracted toward the right edge of the image, relative
/// to those in pixs.<para/>
/// 
/// (3) If %type == L_LINEAR_WARP, the pixel positions are moved
/// to the left or right by an amount that varies linearly with
/// the horizontal location.<para/>
/// 
/// (4) If %operation == L_SAMPLED, the dest pixels are taken from
/// the nearest src pixel.  Otherwise, we use linear interpolation
/// between pairs of sampled pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStretchHorizontal/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
///  <param name="hmax">[in] - horizontal displacement at edge</param>
///  <param name="operation">[in] - L_SAMPLED or L_INTERPOLATED</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched/compressed, or NULL on error</returns>
public static Pix pixStretchHorizontal(
				 Pix pixs, 
				 int dir, 
				 int type, 
				 int hmax, 
				 int operation, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixStretchHorizontal(pixs.Pointer,   dir,   type,   hmax,   operation,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (785, 1)
// pixStretchHorizontalSampled(pixs, dir, type, hmax, incolor) as Pix
// pixStretchHorizontalSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See pixStretchHorizontal() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStretchHorizontalSampled/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
///  <param name="hmax">[in] - horizontal displacement at edge</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched/compressed, or NULL on error</returns>
public static Pix pixStretchHorizontalSampled(
				 Pix pixs, 
				 int dir, 
				 int type, 
				 int hmax, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixStretchHorizontalSampled(pixs.Pointer,   dir,   type,   hmax,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (883, 1)
// pixStretchHorizontalLI(pixs, dir, type, hmax, incolor) as Pix
// pixStretchHorizontalLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See pixStretchHorizontal() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStretchHorizontalLI/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
///  <param name="hmax">[in] - horizontal displacement at edge</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched/compressed, or NULL on error</returns>
public static Pix pixStretchHorizontalLI(
				 Pix pixs, 
				 int dir, 
				 int type, 
				 int hmax, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixStretchHorizontalLI(pixs.Pointer,   dir,   type,   hmax,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (1019, 1)
// pixQuadraticVShear(pixs, dir, vmaxt, vmaxb, operation, incolor) as Pix
// pixQuadraticVShear(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This gives a quadratic bending, upward or downward, as you
/// move to the left or right.<para/>
/// 
/// (2) If %dir == L_WARP_TO_LEFT, the right edge is unchanged, and
/// the left edge pixels are moved maximally up or down.<para/>
/// 
/// (3) Parameters %vmaxt and %vmaxb control the maximum amount of
/// vertical pixel shear at the top and bottom, respectively.
/// If %vmaxt  is greater  0, the vertical displacement of pixels at the
/// top is downward.  Likewise, if %vmaxb  is greater  0, the vertical
/// displacement of pixels at the bottom is downward.<para/>
/// 
/// (4) If %operation == L_SAMPLED, the dest pixels are taken from
/// the nearest src pixel.  Otherwise, we use linear interpolation
/// between pairs of sampled pixels.<para/>
/// 
/// (5) This is for quadratic shear.  For uniform (linear) shear,
/// use the standard shear operators.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixQuadraticVShear/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
///  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
///  <param name="operation">[in] - L_SAMPLED or L_INTERPOLATED</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched, or NULL on error</returns>
public static Pix pixQuadraticVShear(
				 Pix pixs, 
				 int dir, 
				 int vmaxt, 
				 int vmaxb, 
				 int operation, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixQuadraticVShear(pixs.Pointer,   dir,   vmaxt,   vmaxb,   operation,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (1073, 1)
// pixQuadraticVShearSampled(pixs, dir, vmaxt, vmaxb, incolor) as Pix
// pixQuadraticVShearSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See pixQuadraticVShear() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixQuadraticVShearSampled/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
///  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched, or NULL on error</returns>
public static Pix pixQuadraticVShearSampled(
				 Pix pixs, 
				 int dir, 
				 int vmaxt, 
				 int vmaxb, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixQuadraticVShearSampled(pixs.Pointer,   dir,   vmaxt,   vmaxb,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (1179, 1)
// pixQuadraticVShearLI(pixs, dir, vmaxt, vmaxb, incolor) as Pix
// pixQuadraticVShearLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See pixQuadraticVShear() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixQuadraticVShearLI/*"/>
///  <param name="pixs">[in] - 8 or 32 bpp, or colormapped</param>
///  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
///  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
///  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
///   <returns>pixd stretched, or NULL on error</returns>
public static Pix pixQuadraticVShearLI(
				 Pix pixs, 
				 int dir, 
				 int vmaxt, 
				 int vmaxb, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixQuadraticVShearLI(pixs.Pointer,   dir,   vmaxt,   vmaxb,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// warper.c (1332, 1)
// pixStereoFromPair(pix1, pix2, rwt, gwt, bwt) as Pix
// pixStereoFromPair(PIX *, PIX *, l_float32, l_float32, l_float32) as PIX *
///  <summary>
/// (1) pix1 and pix2 are a pair of stereo images, ideally taken
/// concurrently in the same plane, with some lateral translation.<para/>
/// 
/// (2) The output red channel is determined from %pix1.
/// The output green and blue channels are taken from the green
/// and blue channels, respectively, of %pix2.<para/>
/// 
/// (3) The weights determine how much of each component in %pix1
/// goes into the output red channel.  The sum of weights
/// must be 1.0.  If it's not, we scale the weights to
/// satisfy this criterion.<para/>
/// 
/// (4) The most general pixel mapping allowed here is:
/// rval = rwt  r1 + gwt  g1 + bwt  b1  (from pix1)
/// gval = g2 (from pix2)
/// bval = b2 (from pix2)<para/>
/// 
/// (5) The simplest method is to use rwt = 1.0, gwt = 0.0, bwt = 0.0,
/// but this causes unpleasant visual artifacts with red in the image.
/// Use of green and blue from %pix1 in the red channel,
/// instead of red, tends to fix that problem.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStereoFromPair/*"/>
///  <param name="pix1">[in] - 32 bpp rgb</param>
///  <param name="pix2">[in] - 32 bpp rgb</param>
///  <param name="rwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
///  <param name="gwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
///  <param name="bwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
///   <returns>pixd stereo enhanced, or NULL on error</returns>
public static Pix pixStereoFromPair(
				 Pix pix1, 
				 Pix pix2, 
				 Single rwt, 
				 Single gwt, 
				 Single bwt){

if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}
		if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}
if ((new List<int> {32}).Contains ((int)pix1.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
	if ((new List<int> {32}).Contains ((int)pix2.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
	IntPtr _Result = Natives.pixStereoFromPair(pix1.Pointer, pix2.Pointer,   rwt,   gwt,   bwt);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
