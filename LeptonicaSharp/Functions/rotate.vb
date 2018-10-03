Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\rotate.c (99, 1)
' pixRotate()
' pixRotate(PIX *, l_float32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a high-level, simple interface for rotating images<para/>
''' about their center.<para/>
''' (2) For very small rotations, just return a clone.<para/>
''' (3) Rotation brings either white or black pixels in<para/>
''' from outside the image.<para/>
''' (4) The rotation type is adjusted if necessary for the image<para/>
''' depth and size of rotation angle.  For 1 bpp images, we<para/>
''' rotate either by shear or sampling.<para/>
''' (5) Colormaps are removed for rotation by area mapping.<para/>
''' (6) The dest can be expanded so that no image pixels<para/>
''' are lost.  To invoke expansion, input the original<para/>
''' width and height.  For repeated rotation, use of the<para/>
''' original width and height allows the expansion to<para/>
''' stop at the maximum required size, which is a square<para/>
''' with side = sqrt(ww + hh).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="type">[in] - L_ROTATE_AREA_MAP, L_ROTATE_SHEAR, L_ROTATE_SAMPLING</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''  <param name="width">[in] - original width use 0 to avoid embedding</param>
'''  <param name="height">[in] - original height use 0 to avoid embedding</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotate(
				ByVal pixs as Pix, 
				ByVal angle as Single, 
				ByVal type as Enumerations.L_ROTATE, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				ByVal width as Integer, 
				ByVal height as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate( pixs.Pointer, angle, type, incolor, width, height)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotate.c (241, 1)
' pixEmbedForRotation()
' pixEmbedForRotation(PIX *, l_float32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For very small rotations, just return a clone.<para/>
''' (2) Generate larger image to embed pixs if necessary, and<para/>
''' place the center of the input image in the center.<para/>
''' (3) Rotation brings either white or black pixels in<para/>
''' from outside the image.  For colormapped images where<para/>
''' there is no white or black, a new color is added if<para/>
''' possible for these pixels otherwise, either the<para/>
''' lightest or darkest color is used.  In most cases,<para/>
''' the colormap will be removed prior to rotation.<para/>
''' (4) The dest is to be expanded so that no image pixels<para/>
''' are lost after rotation.  Input of the original width<para/>
''' and height allows the expansion to stop at the maximum<para/>
''' required size, which is a square with side equal to<para/>
''' sqrt(ww + hh).<para/>
''' (5) For an arbitrary angle, the expansion can be found by<para/>
''' considering the UL and UR corners.  As the image is<para/>
''' rotated, these move in an arc centered at the center of<para/>
''' the image.  Normalize to a unit circle by dividing by half<para/>
''' the image diagonal.  After a rotation of T radians, the UL<para/>
''' and UR corners are at points T radians along the unit<para/>
''' circle.  Compute the x and y coordinates of both these<para/>
''' points and take the max of absolute values these represent<para/>
''' the half width and half height of the containing rectangle.<para/>
''' The arithmetic is done using formulas for sin(a+b) and cos(a+b),<para/>
''' where b = T.  For the UR corner, sin(a) = h/d and cos(a) = w/d.<para/>
''' For the UL corner, replace a by (pi - a), and you have<para/>
''' sin(pi - a) = h/d, cos(pi - a) = -w/d.  The equations<para/>
''' given below follow directly.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''  <param name="width">[in] - original width use 0 to avoid embedding</param>
'''  <param name="height">[in] - original height use 0 to avoid embedding</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixEmbedForRotation(
				ByVal pixs as Pix, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				ByVal width as Integer, 
				ByVal height as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixEmbedForRotation( pixs.Pointer, angle, incolor, width, height)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotate.c (322, 1)
' pixRotateBySampling()
' pixRotateBySampling(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For very small rotations, just return a clone.<para/>
''' (2) Rotation brings either white or black pixels in<para/>
''' from outside the image.<para/>
''' (3) Colormaps are retained.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp rgb can be cmapped</param>
'''  <param name="xcen">[in] - x value of center of rotation</param>
'''  <param name="ycen">[in] - y value of center of rotation</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateBySampling(
				ByVal pixs as Pix, 
				ByVal xcen as Integer, 
				ByVal ycen as Integer, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateBySampling( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotate.c (455, 1)
' pixRotateBinaryNice()
' pixRotateBinaryNice(PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For very small rotations, just return a clone.<para/>
''' (2) This does a computationally expensive rotation of 1 bpp images.<para/>
''' The fastest rotators (using shears or subsampling) leave<para/>
''' visible horizontal and vertical shear lines across which<para/>
''' the image shear changes by one pixel.  To ameliorate the<para/>
''' visual effect one can introduce random dithering.  One<para/>
''' way to do this in a not-too-random fashion is given here.<para/>
''' We convert to 8 bpp, do a very small blur, rotate using<para/>
''' linear interpolation (same as area mapping), do a<para/>
''' small amount of sharpening to compensate for the initial<para/>
''' blur, and threshold back to binary.  The shear lines<para/>
''' are magically removed.<para/>
''' (3) This operation is about 5x slower than rotation by sampling.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="angle">[in] - radians clockwise is positive about the center</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateBinaryNice(
				ByVal pixs as Pix, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateBinaryNice( pixs.Pointer, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotate.c (533, 1)
' pixRotateWithAlpha()
' pixRotateWithAlpha(PIX *, l_float32, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The alpha channel is transformed separately from pixs,<para/>
''' and aligns with it, being fully transparent outside the<para/>
''' boundary of the transformed pixs.  For pixels that are fully<para/>
''' transparent, a blending function like pixBlendWithGrayMask()<para/>
''' will give zero weight to corresponding pixels in pixs.<para/>
''' (2) Rotation is about the center of the image for very small<para/>
''' rotations, just return a clone.  The dest is automatically<para/>
''' expanded so that no image pixels are lost.<para/>
''' (3) Rotation is by area mapping.  It doesn't matter what<para/>
''' color is brought in because the alpha channel will<para/>
''' be transparent (black) there.<para/>
''' (4) If pixg is NULL, it is generated as an alpha layer that is<para/>
''' partially opaque, using %fract.  Otherwise, it is cropped<para/>
''' to pixs if required and %fract is ignored.  The alpha<para/>
''' channel in pixs is never used.<para/>
''' (4) Colormaps are removed to 32 bpp.<para/>
''' (5) The default setting for the border values in the alpha channel<para/>
''' is 0 (transparent) for the outermost ring of pixels and<para/>
''' (0.5  fract  255) for the second ring.  When blended over<para/>
''' a second image, this<para/>
''' (a) shrinks the visible image to make a clean overlap edge<para/>
''' with an image below, and<para/>
''' (b) softens the edges by weakening the aliasing there.<para/>
''' Use l_setAlphaMaskBorder() to change these values.<para/>
''' (6) A subtle use of gamma correction is to remove gamma correction<para/>
''' before rotation and restore it afterwards.  This is done<para/>
''' by sandwiching this function between a gamma/inverse-gamma<para/>
''' photometric transform:<para/>
''' pixt = pixGammaTRCWithAlpha(NULL, pixs, 1.0 / gamma, 0, 255)<para/>
''' pixd = pixRotateWithAlpha(pixt, angle, NULL, fract)<para/>
''' pixGammaTRCWithAlpha(pixd, pixd, gamma, 0, 255)<para/>
''' pixDestroy( and pixt)<para/>
''' This has the side-effect of producing artifacts in the very<para/>
''' dark regions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb or cmapped</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
'''  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
'''   <returns>pixd 32 bpp rgba, or NULL on error</returns>
Public Shared Function pixRotateWithAlpha(
				ByVal pixs as Pix, 
				ByVal angle as Single, 
				ByVal pixg as Pix, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateWithAlpha( pixs.Pointer, angle, pixgPTR, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
