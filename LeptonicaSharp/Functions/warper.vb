Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\warper.c (107, 1)
' pixSimpleCaptcha()
' pixSimpleCaptcha(PIX *, l_int32, l_int32, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This uses typical default values for generating captchas.
''' The magnitudes of the harmonic warp are typically to be
''' smaller when more terms are used, even though the phases
''' are random.  See, for example, prog/warptest.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="border">[in] - added white pixels on each side</param>
'''  <param name="nterms">[in] - number of x and y harmonic terms</param>
'''  <param name="seed">[in] - of random number generator</param>
'''  <param name="color">[in] - for colorizing; in 0xrrggbb00 format; use 0 for black</param>
'''  <param name="cmapflag">[in] - 1 for colormap output; 0 for rgb</param>
'''   <returns>pixd 8 bpp cmap or 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixSimpleCaptcha(
				ByVal pixs as Pix, 
				ByVal border as Integer, 
				ByVal nterms as Integer, 
				ByVal seed as UInteger, 
				ByVal color as UInteger, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (seed) then Throw New ArgumentNullException  ("seed cannot be Nothing")
	If IsNothing (color) then Throw New ArgumentNullException  ("color cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSimpleCaptcha( pixs.Pointer, border, nterms, seed, color, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (181, 1)
' pixRandomHarmonicWarp()
' pixRandomHarmonicWarp(PIX *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) To generate the warped image p(x',y'), set up the transforms
''' that are in getWarpTransform().  For each (x',y') in the
''' dest, the warp function computes the originating location
''' (x, y) in the src.  The differences (x - x') and (y - y')
''' are given as a sum of products of sinusoidal terms.  Each
''' term is multiplied by a maximum amplitude (in pixels), and the
''' angle is determined by a frequency and phase, and depends
''' on the (x', y') value of the dest.  Random numbers with
''' a variable input seed are used to allow the warping to be
''' unpredictable.  A linear interpolation is used to find
''' the value for the source at (x, y); this value is written
''' into the dest.
''' (2) This can be used to generate 'captcha's, which are somewhat
''' randomly distorted images of text.  A typical set of parameters
''' for a captcha are
''' xmag = 4.0  ymag = 6.0
''' xfreq = 0.10   yfreq = 0.13
''' nx = 3   ny = 3
''' Other examples can be found in prog/warptest.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="xmag">[in] - maximum magnitude of x and y distortion</param>
'''  <param name="ymag">[in] - maximum magnitude of x and y distortion</param>
'''  <param name="xfreq">[in] - maximum magnitude of x and y frequency</param>
'''  <param name="yfreq">[in] - maximum magnitude of x and y frequency</param>
'''  <param name="nx">[in] - number of x and y harmonic terms</param>
'''  <param name="ny">[in] - number of x and y harmonic terms</param>
'''  <param name="seed">[in] - of random number generator</param>
'''  <param name="grayval">[in] - color brought in from the outside; 0 for black, 255 for white</param>
'''   <returns>pixd 8 bpp; no colormap, or NULL on error</returns>
Public Shared Function pixRandomHarmonicWarp(
				ByVal pixs as Pix, 
				ByVal xmag as Single, 
				ByVal ymag as Single, 
				ByVal xfreq as Single, 
				ByVal yfreq as Single, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal seed as UInteger, 
				ByVal grayval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (xmag) then Throw New ArgumentNullException  ("xmag cannot be Nothing")
	If IsNothing (ymag) then Throw New ArgumentNullException  ("ymag cannot be Nothing")
	If IsNothing (xfreq) then Throw New ArgumentNullException  ("xfreq cannot be Nothing")
	If IsNothing (yfreq) then Throw New ArgumentNullException  ("yfreq cannot be Nothing")
	If IsNothing (seed) then Throw New ArgumentNullException  ("seed cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRandomHarmonicWarp( pixs.Pointer, xmag, ymag, xfreq, yfreq, nx, ny, seed, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (586, 1)
' pixWarpStereoscopic()
' pixWarpStereoscopic(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This function splits out the red channel, mucks around with
''' it, then recombines with the unmolested cyan channel.
''' (2) By using a quadratically increasing shift of the red
''' pixels horizontally and away from the vertical centerline,
''' the image appears to bend quadratically out of the image
''' plane, symmetrically with respect to the vertical center
''' line.  A positive value of %zbend causes the plane to be
''' curved away from the viewer.  We use linearly interpolated
''' stretching to avoid the appearance of kinks in the curve.
''' (3) The parameters %zshiftt and %zshiftb tilt the image plane
''' about a horizontal line through the center, and at the
''' same time move that line either in toward the viewer or away.
''' This is implemented by a combination of horizontal shear
''' about the center line (for the tilt) and horizontal
''' translation (to move the entire plane in or out).
''' A positive value of %zshiftt moves the top of the plane
''' away from the viewer, and a positive value of %zshiftb
''' moves the bottom of the plane away.  We use linear interpolated
''' shear to avoid visible vertical steps in the tilted image.
''' (4) The image can be bent in the plane and about the vertical
''' centerline.  The centerline does not shift, and the
''' parameter %ybend gives the relative shift at left and right
''' edges, with a downward shift for positive values of %ybend.
''' (6) When writing out a steroscopic (red/cyan) image in jpeg,
''' first call pixSetChromaSampling(pix, 0) to get sufficient
''' resolution in the red channel.
''' (7) Typical values are
''' zbend = 20
''' zshiftt = 15
''' zshiftb = -15
''' ybendt = 30
''' ybendb = 0
''' If the disparity z-values are too large, it is difficult for
''' the brain to register the two images.
''' (8) This function has been cleverly reimplemented by Jeff Breidenbach.
''' The original implementation used two 32 bpp rgb images,
''' and merged them at the end.  The result is somewhat faded,
''' and has a parameter "thresh" that controls the amount of
''' color in the result.  (The present implementation avoids these
''' two problems, skipping both the colorization and the alpha
''' blending at the end, and is about 3x faster)
''' The basic operations with 32 bpp are as follows
''' // Immediate conversion to 32 bpp
''' Pix pixt1 = pixConvertTo32(pixs);
''' // Do vertical shear
''' Pix pixr = pixQuadraticVerticalShear(pixt1, L_WARP_TO_RIGHT,
''' ybendt, ybendb,
''' L_BRING_IN_WHITE);
''' // Colorize two versions, toward red and cyan
''' Pix pixc = pixCopy(NULL, pixr);
''' l_int32 thresh = 150;  // if higher, get less original color
''' pixColorGray(pixr, NULL, L_PAINT_DARK, thresh, 255, 0, 0);
''' pixColorGray(pixc, NULL, L_PAINT_DARK, thresh, 0, 255, 255);
''' // Shift the red pixels; e.g., by stretching
''' Pix pixrs = pixStretchHorizontal(pixr, L_WARP_TO_RIGHT,
''' L_QUADRATIC_WARP, zbend,
''' L_INTERPOLATED,
''' L_BRING_IN_WHITE);
''' // Blend the shifted red and unshifted cyan 5050
''' Pix pixg = pixCreate(w, h, 8);
''' pixSetAllArbitrary(pixg, 128);
''' pixd = pixBlendWithGrayMask(pixrs, pixc, pixg, 0, 0);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, colormap ok</param>
'''  <param name="zbend">[in] - horizontal separation in pixels of red and cyan at the left and right sides, that gives rise to quadratic curvature out of the image plane</param>
'''  <param name="zshiftt">[in] - uniform pixel translation difference between red and cyan, that pushes the top of the image plane away from the viewer (zshiftt GT 0) or towards the viewer (zshiftt LT 0)</param>
'''  <param name="zshiftb">[in] - uniform pixel translation difference between red and cyan, that pushes the bottom of the image plane away from the viewer (zshiftb GT 0) or towards the viewer (zshiftb LT 0)</param>
'''  <param name="ybendt">[in] - multiplicative parameter for in-plane vertical displacement at the left or right edge at the top y = ybendt  (2x/w - 1)^2</param>
'''  <param name="ybendb">[in] - same as ybendt, except at the left or right edge at the bottom</param>
'''  <param name="redleft">[in] - 1 if the red filter is on the left; 0 otherwise</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixWarpStereoscopic(
				ByVal pixs as Pix, 
				ByVal zbend as Integer, 
				ByVal zshiftt as Integer, 
				ByVal zshiftb as Integer, 
				ByVal ybendt as Integer, 
				ByVal ybendb as Integer, 
				ByVal redleft as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixWarpStereoscopic( pixs.Pointer, zbend, zshiftt, zshiftb, ybendt, ybendb, redleft)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (733, 1)
' pixStretchHorizontal()
' pixStretchHorizontal(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If %hmax GT 0, this is an increase in the coordinate value of
''' pixels in pixd, relative to the same pixel in pixs.
''' (2) If %dir == L_WARP_TO_LEFT, the pixels on the right edge of
''' the image are not moved. So, for example, if %hmax GT 0
''' and %dir == L_WARP_TO_LEFT, the pixels in pixd are
''' contracted toward the right edge of the image, relative
''' to those in pixs.
''' (3) If %type == L_LINEAR_WARP, the pixel positions are moved
''' to the left or right by an amount that varies linearly with
''' the horizontal location.
''' (4) If %operation == L_SAMPLED, the dest pixels are taken from
''' the nearest src pixel.  Otherwise, we use linear interpolation
''' between pairs of sampled pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
'''  <param name="hmax">[in] - horizontal displacement at edge</param>
'''  <param name="operation">[in] - L_SAMPLED or L_INTERPOLATED</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched/compressed, or NULL on error</returns>
Public Shared Function pixStretchHorizontal(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal type as Enumerations.L_WARP, 
				ByVal hmax as Integer, 
				ByVal operation as Enumerations.L_ED, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixStretchHorizontal( pixs.Pointer, dir, type, hmax, operation, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (785, 1)
' pixStretchHorizontalSampled()
' pixStretchHorizontalSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixStretchHorizontal() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
'''  <param name="hmax">[in] - horizontal displacement at edge</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched/compressed, or NULL on error</returns>
Public Shared Function pixStretchHorizontalSampled(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal type as Enumerations.L_WARP, 
				ByVal hmax as Integer, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixStretchHorizontalSampled( pixs.Pointer, dir, type, hmax, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (883, 1)
' pixStretchHorizontalLI()
' pixStretchHorizontalLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixStretchHorizontal() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="type">[in] - L_LINEAR_WARP or L_QUADRATIC_WARP</param>
'''  <param name="hmax">[in] - horizontal displacement at edge</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched/compressed, or NULL on error</returns>
Public Shared Function pixStretchHorizontalLI(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal type as Enumerations.L_WARP, 
				ByVal hmax as Integer, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixStretchHorizontalLI( pixs.Pointer, dir, type, hmax, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (1019, 1)
' pixQuadraticVShear()
' pixQuadraticVShear(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This gives a quadratic bending, upward or downward, as you
''' move to the left or right.
''' (2) If %dir == L_WARP_TO_LEFT, the right edge is unchanged, and
''' the left edge pixels are moved maximally up or down.
''' (3) Parameters %vmaxt and %vmaxb control the maximum amount of
''' vertical pixel shear at the top and bottom, respectively.
''' If %vmaxt GT 0, the vertical displacement of pixels at the
''' top is downward.  Likewise, if %vmaxb GT 0, the vertical
''' displacement of pixels at the bottom is downward.
''' (4) If %operation == L_SAMPLED, the dest pixels are taken from
''' the nearest src pixel.  Otherwise, we use linear interpolation
''' between pairs of sampled pixels.
''' (5) This is for quadratic shear.  For uniform (linear) shear,
''' use the standard shear operators.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
'''  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
'''  <param name="operation">[in] - L_SAMPLED or L_INTERPOLATED</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched, or NULL on error</returns>
Public Shared Function pixQuadraticVShear(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal vmaxt as Integer, 
				ByVal vmaxb as Integer, 
				ByVal operation as Enumerations.L_ED, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixQuadraticVShear( pixs.Pointer, dir, vmaxt, vmaxb, operation, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (1073, 1)
' pixQuadraticVShearSampled()
' pixQuadraticVShearSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixQuadraticVShear() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
'''  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched, or NULL on error</returns>
Public Shared Function pixQuadraticVShearSampled(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal vmaxt as Integer, 
				ByVal vmaxb as Integer, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixQuadraticVShearSampled( pixs.Pointer, dir, vmaxt, vmaxb, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (1179, 1)
' pixQuadraticVShearLI()
' pixQuadraticVShearLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixQuadraticVShear() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp, or colormapped</param>
'''  <param name="dir">[in] - L_WARP_TO_LEFT or L_WARP_TO_RIGHT</param>
'''  <param name="vmaxt">[in] - max vertical displacement at edge and at top</param>
'''  <param name="vmaxb">[in] - max vertical displacement at edge and at bottom</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE or L_BRING_IN_BLACK</param>
'''   <returns>pixd stretched, or NULL on error</returns>
Public Shared Function pixQuadraticVShearLI(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_WARP_TO_T, 
				ByVal vmaxt as Integer, 
				ByVal vmaxb as Integer, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixQuadraticVShearLI( pixs.Pointer, dir, vmaxt, vmaxb, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (1332, 1)
' pixStereoFromPair()
' pixStereoFromPair(PIX *, PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) pix1 and pix2 are a pair of stereo images, ideally taken
''' concurrently in the same plane, with some lateral translation.
''' (2) The output red channel is determined from %pix1.
''' The output green and blue channels are taken from the green
''' and blue channels, respectively, of %pix2.
''' (3) The weights determine how much of each component in %pix1
''' goes into the output red channel.  The sum of weights
''' must be 1.0.  If it's not, we scale the weights to
''' satisfy this criterion.
''' (4) The most general pixel mapping allowed here is
''' rval = rwt  r1 + gwt  g1 + bwt  b1  (from pix1)
''' gval = g2   (from pix2)
''' bval = b2   (from pix2)
''' (5) The simplest method is to use rwt = 1.0, gwt = 0.0, bwt = 0.0,
''' but this causes unpleasant visual artifacts with red in the image.
''' Use of green and blue from %pix1 in the red channel,
''' instead of red, tends to fix that problem.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 32 bpp rgb</param>
'''  <param name="pix2">[in] - 32 bpp rgb</param>
'''  <param name="rwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
'''  <param name="gwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
'''  <param name="bwt">[in] - weighting factors used for each component in                                pix1 to determine the output red channel</param>
'''   <returns>pixd stereo enhanced, or NULL on error</returns>
Public Shared Function pixStereoFromPair(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal rwt as Single, 
				ByVal gwt as Single, 
				ByVal bwt as Single) as Pix

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (rwt) then Throw New ArgumentNullException  ("rwt cannot be Nothing")
	If IsNothing (gwt) then Throw New ArgumentNullException  ("gwt cannot be Nothing")
	If IsNothing (bwt) then Throw New ArgumentNullException  ("bwt cannot be Nothing")
	If {32}.contains (pix1.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck
	If {32}.contains (pix2.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixStereoFromPair( pix1.Pointer, pix2.Pointer, rwt, gwt, bwt)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class