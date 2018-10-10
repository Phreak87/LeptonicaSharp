Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\warper.c (107, 1)
' pixSimpleCaptcha(pixs, border, nterms, seed, color, cmapflag) as Pix
' pixSimpleCaptcha(PIX *, l_int32, l_int32, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses typical default values for generating captchas.<para/>
''' The magnitudes of the harmonic warp are typically to be<para/>
''' smaller when more terms are used, even though the phases<para/>
''' are random.  See, for example, prog/warptest.c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="border">[in] - added white pixels on each side</param>
'''  <param name="nterms">[in] - number of x and y harmonic terms</param>
'''  <param name="seed">[in] - of random number generator</param>
'''  <param name="color">[in] - for colorizing in 0xrrggbb00 format use 0 for black</param>
'''  <param name="cmapflag">[in] - 1 for colormap output 0 for rgb</param>
'''   <returns>pixd 8 bpp cmap or 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixSimpleCaptcha(
				 ByVal pixs as Pix, 
				 ByVal border as Integer, 
				 ByVal nterms as Integer, 
				 ByVal seed as UInteger, 
				 ByVal color as UInteger, 
				 ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSimpleCaptcha( pixs.Pointer, border, nterms, seed, color, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (181, 1)
' pixRandomHarmonicWarp(pixs, xmag, ymag, xfreq, yfreq, nx, ny, seed, grayval) as Pix
' pixRandomHarmonicWarp(PIX *, l_float32, l_float32, l_float32, l_float32, l_int32, l_int32, l_uint32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To generate the warped image p(x',y'), set up the transforms<para/>
''' that are in getWarpTransform().  For each (x',y') in the<para/>
''' dest, the warp function computes the originating location<para/>
''' (x, y) in the src.  The differences (x - x') and (y - y')<para/>
''' are given as a sum of products of sinusoidal terms.  Each<para/>
''' term is multiplied by a maximum amplitude (in pixels), and the<para/>
''' angle is determined by a frequency and phase, and depends<para/>
''' on the (x', y') value of the dest.  Random numbers with<para/>
''' a variable input seed are used to allow the warping to be<para/>
''' unpredictable.  A linear interpolation is used to find<para/>
''' the value for the source at (x, y) this value is written<para/>
''' into the dest.<para/>
''' (2) This can be used to generate 'captcha's, which are somewhat<para/>
''' randomly distorted images of text.  A typical set of parameters<para/>
''' for a captcha are:<para/>
''' xmag = 4.0 ymag = 6.0<para/>
''' xfreq = 0.10 yfreq = 0.13<para/>
''' nx = 3 ny = 3<para/>
''' Other examples can be found in prog/warptest.c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="xmag">[in] - maximum magnitude of x and y distortion</param>
'''  <param name="ymag">[in] - maximum magnitude of x and y distortion</param>
'''  <param name="xfreq">[in] - maximum magnitude of x and y frequency</param>
'''  <param name="yfreq">[in] - maximum magnitude of x and y frequency</param>
'''  <param name="nx">[in] - number of x and y harmonic terms</param>
'''  <param name="ny">[in] - number of x and y harmonic terms</param>
'''  <param name="seed">[in] - of random number generator</param>
'''  <param name="grayval">[in] - color brought in from the outside 0 for black, 255 for white</param>
'''   <returns>pixd 8 bpp no colormap, or NULL on error</returns>
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

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRandomHarmonicWarp( pixs.Pointer, xmag, ymag, xfreq, yfreq, nx, ny, seed, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\warper.c (586, 1)
' pixWarpStereoscopic(pixs, zbend, zshiftt, zshiftb, ybendt, ybendb, redleft) as Pix
' pixWarpStereoscopic(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function splits out the red channel, mucks around with<para/>
''' it, then recombines with the unmolested cyan channel.<para/>
''' (2) By using a quadratically increasing shift of the red<para/>
''' pixels horizontally and away from the vertical centerline,<para/>
''' the image appears to bend quadratically out of the image<para/>
''' plane, symmetrically with respect to the vertical center<para/>
''' line.  A positive value of %zbend causes the plane to be<para/>
''' curved away from the viewer.  We use linearly interpolated<para/>
''' stretching to avoid the appearance of kinks in the curve.<para/>
''' (3) The parameters %zshiftt and %zshiftb tilt the image plane<para/>
''' about a horizontal line through the center, and at the<para/>
''' same time move that line either in toward the viewer or away.<para/>
''' This is implemented by a combination of horizontal shear<para/>
''' about the center line (for the tilt) and horizontal<para/>
''' translation (to move the entire plane in or out).<para/>
''' A positive value of %zshiftt moves the top of the plane<para/>
''' away from the viewer, and a positive value of %zshiftb<para/>
''' moves the bottom of the plane away.  We use linear interpolated<para/>
''' shear to avoid visible vertical steps in the tilted image.<para/>
''' (4) The image can be bent in the plane and about the vertical<para/>
''' centerline.  The centerline does not shift, and the<para/>
''' parameter %ybend gives the relative shift at left and right<para/>
''' edges, with a downward shift for positive values of %ybend.<para/>
''' (6) When writing out a steroscopic (red/cyan) image in jpeg,<para/>
''' first call pixSetChromaSampling(pix, 0) to get sufficient<para/>
''' resolution in the red channel.<para/>
''' (7) Typical values are:<para/>
''' zbend = 20<para/>
''' zshiftt = 15<para/>
''' zshiftb = -15<para/>
''' ybendt = 30<para/>
''' ybendb = 0<para/>
''' If the disparity z-values are too large, it is difficult for<para/>
''' the brain to register the two images.<para/>
''' (8) This function has been cleverly reimplemented by Jeff Breidenbach.<para/>
''' The original implementation used two 32 bpp rgb images,<para/>
''' and merged them at the end.  The result is somewhat faded,<para/>
''' and has a parameter "thresh" that controls the amount of<para/>
''' color in the result.  (The present implementation avoids these<para/>
''' two problems, skipping both the colorization and the alpha<para/>
''' blending at the end, and is about 3x faster)<para/>
''' The basic operations with 32 bpp are as follows:<para/>
''' // Immediate conversion to 32 bpp<para/>
''' Pix pixt1 = pixConvertTo32(pixs)<para/>
''' // Do vertical shear<para/>
''' Pix pixr = pixQuadraticVerticalShear(pixt1, L_WARP_TO_RIGHT,<para/>
''' ybendt, ybendb,<para/>
''' L_BRING_IN_WHITE)<para/>
''' // Colorize two versions, toward red and cyan<para/>
''' Pix pixc = pixCopy(NULL, pixr)<para/>
''' l_int32 thresh = 150  // if higher, get less original color<para/>
''' pixColorGray(pixr, NULL, L_PAINT_DARK, thresh, 255, 0, 0)<para/>
''' pixColorGray(pixc, NULL, L_PAINT_DARK, thresh, 0, 255, 255)<para/>
''' // Shift the red pixels e.g., by stretching<para/>
''' Pix pixrs = pixStretchHorizontal(pixr, L_WARP_TO_RIGHT,<para/>
''' L_QUADRATIC_WARP, zbend,<para/>
''' L_INTERPOLATED,<para/>
''' L_BRING_IN_WHITE)<para/>
''' // Blend the shifted red and unshifted cyan 50:50<para/>
''' Pix pixg = pixCreate(w, h, 8)<para/>
''' pixSetAllArbitrary(pixg, 128)<para/>
''' pixd = pixBlendWithGrayMask(pixrs, pixc, pixg, 0, 0)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, colormap ok</param>
'''  <param name="zbend">[in] - horizontal separation in pixels of red and cyan at the left and right sides, that gives rise to quadratic curvature out of the image plane</param>
'''  <param name="zshiftt">[in] - uniform pixel translation difference between red and cyan, that pushes the top of the image plane away from the viewer (zshiftt  is greater  0) or towards the viewer (zshiftt  is lower  0)</param>
'''  <param name="zshiftb">[in] - uniform pixel translation difference between red and cyan, that pushes the bottom of the image plane away from the viewer (zshiftb  is greater  0) or towards the viewer (zshiftb  is lower  0)</param>
'''  <param name="ybendt">[in] - multiplicative parameter for in-plane vertical displacement at the left or right edge at the top: y = ybendt  (2x/w - 1)^2</param>
'''  <param name="ybendb">[in] - same as ybendt, except at the left or right edge at the bottom</param>
'''  <param name="redleft">[in] - 1 if the red filter is on the left 0 otherwise</param>
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
' pixStretchHorizontal(pixs, dir, type, hmax, operation, incolor) as Pix
' pixStretchHorizontal(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If %hmax  is greater  0, this is an increase in the coordinate value of<para/>
''' pixels in pixd, relative to the same pixel in pixs.<para/>
''' (2) If %dir == L_WARP_TO_LEFT, the pixels on the right edge of<para/>
''' the image are not moved. So, for example, if %hmax  is greater  0<para/>
''' and %dir == L_WARP_TO_LEFT, the pixels in pixd are<para/>
''' contracted toward the right edge of the image, relative<para/>
''' to those in pixs.<para/>
''' (3) If %type == L_LINEAR_WARP, the pixel positions are moved<para/>
''' to the left or right by an amount that varies linearly with<para/>
''' the horizontal location.<para/>
''' (4) If %operation == L_SAMPLED, the dest pixels are taken from<para/>
''' the nearest src pixel.  Otherwise, we use linear interpolation<para/>
''' between pairs of sampled pixels.<para/>
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
' pixStretchHorizontalSampled(pixs, dir, type, hmax, incolor) as Pix
' pixStretchHorizontalSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixStretchHorizontal() for details.<para/>
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
' pixStretchHorizontalLI(pixs, dir, type, hmax, incolor) as Pix
' pixStretchHorizontalLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixStretchHorizontal() for details.<para/>
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
' pixQuadraticVShear(pixs, dir, vmaxt, vmaxb, operation, incolor) as Pix
' pixQuadraticVShear(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives a quadratic bending, upward or downward, as you<para/>
''' move to the left or right.<para/>
''' (2) If %dir == L_WARP_TO_LEFT, the right edge is unchanged, and<para/>
''' the left edge pixels are moved maximally up or down.<para/>
''' (3) Parameters %vmaxt and %vmaxb control the maximum amount of<para/>
''' vertical pixel shear at the top and bottom, respectively.<para/>
''' If %vmaxt  is greater  0, the vertical displacement of pixels at the<para/>
''' top is downward.  Likewise, if %vmaxb  is greater  0, the vertical<para/>
''' displacement of pixels at the bottom is downward.<para/>
''' (4) If %operation == L_SAMPLED, the dest pixels are taken from<para/>
''' the nearest src pixel.  Otherwise, we use linear interpolation<para/>
''' between pairs of sampled pixels.<para/>
''' (5) This is for quadratic shear.  For uniform (linear) shear,<para/>
''' use the standard shear operators.<para/>
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
' pixQuadraticVShearSampled(pixs, dir, vmaxt, vmaxb, incolor) as Pix
' pixQuadraticVShearSampled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixQuadraticVShear() for details.<para/>
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
' pixQuadraticVShearLI(pixs, dir, vmaxt, vmaxb, incolor) as Pix
' pixQuadraticVShearLI(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixQuadraticVShear() for details.<para/>
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
' pixStereoFromPair(pix1, pix2, rwt, gwt, bwt) as Pix
' pixStereoFromPair(PIX *, PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pix1 and pix2 are a pair of stereo images, ideally taken<para/>
''' concurrently in the same plane, with some lateral translation.<para/>
''' (2) The output red channel is determined from %pix1.<para/>
''' The output green and blue channels are taken from the green<para/>
''' and blue channels, respectively, of %pix2.<para/>
''' (3) The weights determine how much of each component in %pix1<para/>
''' goes into the output red channel.  The sum of weights<para/>
''' must be 1.0.  If it's not, we scale the weights to<para/>
''' satisfy this criterion.<para/>
''' (4) The most general pixel mapping allowed here is:<para/>
''' rval = rwt  r1 + gwt  g1 + bwt  b1  (from pix1)<para/>
''' gval = g2 (from pix2)<para/>
''' bval = b2 (from pix2)<para/>
''' (5) The simplest method is to use rwt = 1.0, gwt = 0.0, bwt = 0.0,<para/>
''' but this causes unpleasant visual artifacts with red in the image.<para/>
''' Use of green and blue from %pix1 in the red channel,<para/>
''' instead of red, tends to fix that problem.<para/>
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

	If {32}.contains (pix1.d) = false then Throw New ArgumentException ("32 bpp rgb")
	If {32}.contains (pix2.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixStereoFromPair( pix1.Pointer, pix2.Pointer, rwt, gwt, bwt)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
