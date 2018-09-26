Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\blend.c (174, 1)
' pixBlend()
' pixBlend(PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a simple top-level interface.  For more flexibility,
''' call directly into pixBlendMask(), etc.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - blendee</param>
'''  <param name="pixs2">[in] - blender; typ. smaller</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1; can be LT 0</param>
'''  <param name="fract">[in] - blending fraction</param>
'''   <returns>pixd blended image, or NULL on error</returns>
Public Shared Function pixBlend(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlend( pixs1.Pointer, pixs2.Pointer, x, y, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (262, 1)
' pixBlendMask()
' pixBlendMask(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Clipping of pixs2 to pixs1 is done in the inner pixel loop.
''' (2) If pixs1 has a colormap, it is removed.
''' (3) For inplace operation (pixs1 not cmapped), call it this way
''' pixBlendMask(pixs1, pixs1, pixs2, ...)
''' (4) For generating a new pixd
''' pixd = pixBlendMask(NULL, pixs1, pixs2, ...)
''' (5) Only call in-place if pixs1 does not have a colormap.
''' (6) Invalid %fract defaults to 0.5 with a warning.
''' Invalid %type defaults to L_BLEND_WITH_INVERSE with a warning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs1 for in-place</param>
'''  <param name="pixs1">[in] - blendee, depth GT 1</param>
'''  <param name="pixs2">[in] - blender, 1 bpp; typ. smaller in size than pixs1</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1; can be LT 0</param>
'''  <param name="fract">[in] - blending fraction</param>
'''  <param name="type">[in] - L_BLEND_WITH_INVERSE, L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
'''   <returns>pixd if OK; NULL on error</returns>
Public Shared Function pixBlendMask(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single, 
				ByVal type as Enumerations.L_BLEND, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendMask( pixdPTR, pixs1.Pointer, pixs2.Pointer, x, y, fract, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (489, 1)
' pixBlendGray()
' pixBlendGray(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation (pixs1 not cmapped), call it this way
''' pixBlendGray(pixs1, pixs1, pixs2, ...)
''' (2) For generating a new pixd
''' pixd = pixBlendGray(NULL, pixs1, pixs2, ...)
''' (3) Clipping of pixs2 to pixs1 is done in the inner pixel loop.
''' (4) If pixs1 has a colormap, it is removed; otherwise, if pixs1
''' has depth LT 8, it is unpacked to generate a 8 bpp pix.
''' (5) If transparent = 0, the blending fraction (fract) is
''' applied equally to all pixels.
''' (6) If transparent = 1, all pixels of value transpix (typically
''' either 0 or 0xff) in pixs2 are transparent in the blend.
''' (7) After processing pixs1, it is either 8 bpp or 32 bpp
''' ~ if 8 bpp, the fraction of pixs2 is mixed with pixs1.
''' ~ if 32 bpp, each component of pixs1 is mixed with
''' the same fraction of pixs2.
''' (8) For L_BLEND_GRAY_WITH_INVERSE, the white values of the blendee
''' (cval == 255 in the code below) result in a delta of 0.
''' Thus, these pixels are intrinsically transparent!
''' The "pivot" value of the src, at which no blending occurs, is
''' 128.  Compare with the adaptive pivot in pixBlendGrayAdapt().
''' (9) Invalid %fract defaults to 0.5 with a warning.
''' Invalid %type defaults to L_BLEND_GRAY with a warning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs1 for in-place</param>
'''  <param name="pixs1">[in] - blendee, depth GT 1</param>
'''  <param name="pixs2">[in] - blender, any depth; typ. smaller in size than pixs1</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1; can be LT 0</param>
'''  <param name="fract">[in] - blending fraction</param>
'''  <param name="type">[in] - L_BLEND_GRAY, L_BLEND_GRAY_WITH_INVERSE</param>
'''  <param name="transparent">[in] - 1 to use transparency; 0 otherwise</param>
'''  <param name="transpix">[in] - pixel grayval in pixs2 that is to be transparent</param>
'''   <returns>pixd if OK; pixs1 on error</returns>
Public Shared Function pixBlendGray(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single, 
				ByVal type as Enumerations.L_BLEND, 
				ByVal transparent as Integer, 
				ByVal transpix as UInteger, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If IsNothing (transpix) then Throw New ArgumentNullException  ("transpix cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendGray( pixdPTR, pixs1.Pointer, pixs2.Pointer, x, y, fract, type, transparent, transpix)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (688, 1)
' pixBlendGrayInverse()
' pixBlendGrayInverse(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation (pixs1 not cmapped), call it this way
''' pixBlendGrayInverse(pixs1, pixs1, pixs2, ...)
''' (2) For generating a new pixd
''' pixd = pixBlendGrayInverse(NULL, pixs1, pixs2, ...)
''' (3) Clipping of pixs2 to pixs1 is done in the inner pixel loop.
''' (4) If pixs1 has a colormap, it is removed; otherwise if pixs1
''' has depth LT 8, it is unpacked to generate a 8 bpp pix.
''' (5) This is a no-nonsense blender.  It changes the src1 pixel except
''' when the src1 pixel is midlevel gray.  Use fract == 1 for the most
''' aggressive blending, where, if the gray pixel in pixs2 is 0,
''' we get a complete inversion of the color of the src pixel in pixs1.
''' (6) The basic logic is that each component transforms by
'''   d  --GT  c * d + (1 - c ) * (f * (1 - d) + d * (1 - f))
''' where c is the blender pixel from pixs2,
''' f is %fract,
''' c and d are normalized to [0...1]
''' This has the property that for f == 0 (no blend) or c == 1 (white)
''' d  --GT  d
''' For c == 0 (black) we get maximum inversion
''' d  --GT  f  (1 - d) + d  (1 - f)   [inversion by fraction f]
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs1 for in-place</param>
'''  <param name="pixs1">[in] - blendee, depth GT 1</param>
'''  <param name="pixs2">[in] - blender, any depth; typ. smaller in size than pixs1</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1; can be LT 0</param>
'''  <param name="fract">[in] - blending fraction</param>
'''   <returns>pixd if OK; pixs1 on error</returns>
Public Shared Function pixBlendGrayInverse(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendGrayInverse( pixdPTR, pixs1.Pointer, pixs2.Pointer, x, y, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (820, 1)
' pixBlendColor()
' pixBlendColor(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation (pixs1 must be 32 bpp), call it this way
''' pixBlendColor(pixs1, pixs1, pixs2, ...)
''' (2) For generating a new pixd
''' pixd = pixBlendColor(NULL, pixs1, pixs2, ...)
''' (3) If pixs2 is not 32 bpp rgb, it is converted.
''' (4) Clipping of pixs2 to pixs1 is done in the inner pixel loop.
''' (5) If pixs1 has a colormap, it is removed to generate a 32 bpp pix.
''' (6) If pixs1 has depth LT 32, it is unpacked to generate a 32 bpp pix.
''' (7) If transparent = 0, the blending fraction (fract) is
''' applied equally to all pixels.
''' (8) If transparent = 1, all pixels of value transpix (typically
''' either 0 or 0xffffff00) in pixs2 are transparent in the blend.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs1 for in-place</param>
'''  <param name="pixs1">[in] - blendee; depth GT 1</param>
'''  <param name="pixs2">[in] - blender, any depth;; typ. smaller in size than pixs1</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1</param>
'''  <param name="fract">[in] - blending fraction</param>
'''  <param name="transparent">[in] - 1 to use transparency; 0 otherwise</param>
'''  <param name="transpix">[in] - pixel color in pixs2 that is to be transparent</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBlendColor(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single, 
				ByVal transparent as Integer, 
				ByVal transpix as UInteger, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If IsNothing (transpix) then Throw New ArgumentNullException  ("transpix cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendColor( pixdPTR, pixs1.Pointer, pixs2.Pointer, x, y, fract, transparent, transpix)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (932, 1)
' 
' pixBlendColorByChannel(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_float32, l_int32, l_uint32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixBlendColorByChannel(
				ByRef pixd as Pix, 
				ByRef pixs1 as Pix, 
				ByRef pixs2 as Pix, 
				ByRef x as Integer, 
				ByRef y as Integer, 
				ByRef rfract as Single, 
				ByRef gfract as Single, 
				ByRef bfract as Single, 
				ByRef transparent as Integer, 
				ByRef transpix as UInteger) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (rfract) then Throw New ArgumentNullException  ("rfract cannot be Nothing")
	If IsNothing (gfract) then Throw New ArgumentNullException  ("gfract cannot be Nothing")
	If IsNothing (bfract) then Throw New ArgumentNullException  ("bfract cannot be Nothing")
	If IsNothing (transpix) then Throw New ArgumentNullException  ("transpix cannot be Nothing")

Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixs1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs1) Then pixs1PTR = pixs1.Pointer
Dim pixs2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs2) Then pixs2PTR = pixs2.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendColorByChannel( pixd.Pointer, pixs1.Pointer, pixs2.Pointer, x, y, rfract, gfract, bfract, transparent, transpix)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1061, 1)
' pixBlendGrayAdapt()
' pixBlendGrayAdapt(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation (pixs1 not cmapped), call it this way
''' pixBlendGrayAdapt(pixs1, pixs1, pixs2, ...)
''' For generating a new pixd
''' pixd = pixBlendGrayAdapt(NULL, pixs1, pixs2, ...)
''' (2) Clipping of pixs2 to pixs1 is done in the inner pixel loop.
''' (3) If pixs1 has a colormap, it is removed.
''' (4) If pixs1 has depth LT 8, it is unpacked to generate a 8 bpp pix.
''' (5) This does a blend with inverse.  Whereas in pixGlendGray(), the
''' zero blend point is where the blendee pixel is 128, here
''' the zero blend point is found adaptively, with respect to the
''' median of the blendee region.  If the median is LT 128,
''' the zero blend point is found from
''' median + shift.
''' Otherwise, if the median GT= 128, the zero blend point is
''' median - shift.
''' The purpose of shifting the zero blend point away from the
''' median is to prevent a situation in pixBlendGray() where
''' the median is 128 and the blender is not visible.
''' The default value of shift is 64.
''' (6) After processing pixs1, it is either 8 bpp or 32 bpp
''' ~ if 8 bpp, the fraction of pixs2 is mixed with pixs1.
''' ~ if 32 bpp, each component of pixs1 is mixed with
''' the same fraction of pixs2.
''' (7) The darker the blender, the more it mixes with the blendee.
''' A blender value of 0 has maximum mixing; a value of 255
''' has no mixing and hence is transparent.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs1 for in-place</param>
'''  <param name="pixs1">[in] - blendee, depth GT 1</param>
'''  <param name="pixs2">[in] - blender, any depth; typ. smaller in size than pixs1</param>
'''  <param name="x">[in] - ,y  origin [UL corner] of pixs2 relative to the origin of pixs1; can be LT 0</param>
'''  <param name="fract">[in] - blending fraction</param>
'''  <param name="shift">[in] - GT= 0 but LT= 128 shift of zero blend value from median source; use -1 for default value;</param>
'''   <returns>pixd if OK; pixs1 on error</returns>
Public Shared Function pixBlendGrayAdapt(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal fract as Single, 
				ByVal shift as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendGrayAdapt( pixdPTR, pixs1.Pointer, pixs2.Pointer, x, y, fract, shift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1235, 1)
' pixFadeWithGray()
' pixFadeWithGray(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This function combines two pix aligned to the UL corner; they
''' need not be the same size.
''' (2) Each pixel in pixb is multiplied by 'factor' divided by 255, and
''' clipped to the range [0 ... 1].  This gives the fade fraction
''' to be applied to pixs.  Fade either to white (L_BLEND_TO_WHITE)
''' or to black (L_BLEND_TO_BLACK).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - colormapped or 8 bpp or 32 bpp</param>
'''  <param name="pixb">[in] - 8 bpp blender</param>
'''  <param name="factor">[in] - multiplicative factor to apply to blender value</param>
'''  <param name="type">[in] - L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixFadeWithGray(
				ByVal pixs as Pix, 
				ByVal pixb as Pix, 
				ByVal factor as Single, 
				ByVal type as Enumerations.L_BLEND) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFadeWithGray( pixs.Pointer, pixb.Pointer, factor, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1349, 1)
' 
' pixBlendHardLight(PIX *, PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixBlendHardLight(
				ByRef pixd as Pix, 
				ByRef pixs1 as Pix, 
				ByRef pixs2 as Pix, 
				ByRef x as Integer, 
				ByRef y as Integer, 
				ByRef fract as Single) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixs1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs1) Then pixs1PTR = pixs1.Pointer
Dim pixs2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs2) Then pixs2PTR = pixs2.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendHardLight( pixd.Pointer, pixs1.Pointer, pixs2.Pointer, x, y, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1555, 1)
' pixBlendCmap()
' pixBlendCmap(PIX *, PIX *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This function combines two colormaps, and replaces the pixels
''' in pixs that have a specified color value with those in pixb.
''' (2) sindex must be in the existing colormap; otherwise an
''' error is returned.  In use, sindex will typically be the index
''' for white (255, 255, 255).
''' (3) Blender colors that already exist in the colormap are used;
''' others are added.  If any blender colors cannot be
''' stored in the colormap, an error is returned.
''' (4) In the implementation, a mapping is generated from each
''' original blender colormap index to the corresponding index
''' in the expanded colormap for pixs.  Then for each pixel in
''' pixs with value sindex, and which is covered by a blender pixel,
''' the new index corresponding to the blender pixel is substituted
''' for sindex.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
'''  <param name="pixb">[in] - colormapped blender</param>
'''  <param name="x">[in] - UL corner of blender relative to pixs</param>
'''  <param name="y">[in] - UL corner of blender relative to pixs</param>
'''  <param name="sindex">[in] - colormap index of pixels in pixs to be changed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixBlendCmap(
				ByVal pixs as Pix, 
				ByVal pixb as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal sindex as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixBlendCmap( pixs.Pointer, pixb.Pointer, x, y, sindex)

	Return _Result
End Function

' SRC\blend.c (1692, 1)
' pixBlendWithGrayMask()
' pixBlendWithGrayMask(PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The result is 8 bpp grayscale if both pixs1 and pixs2 are
''' 8 bpp gray.  Otherwise, the result is 32 bpp rgb.
''' (2) pixg is an 8 bpp transparency image, where 0 is transparent
''' and 255 is opaque.  It determines the transparency of pixs2
''' when applied over pixs1.  It can be null if pixs2 is rgba,
''' in which case we use the alpha component of pixs2.
''' (3) If pixg exists, it need not be the same size as pixs2.
''' However, we assume their UL corners are aligned with each other,
''' and placed at the location (x, y) in pixs1.
''' (4) The pixels in pixd are a combination of those in pixs1
''' and pixs2, where the amount from pixs2 is proportional to
''' the value of the pixel (p) in pixg, and the amount from pixs1
''' is proportional to (255 - p).  Thus pixg is a transparency
''' image (usually called an alpha blender) where each pixel
''' can be associated with a pixel in pixs2, and determines
''' the amount of the pixs2 pixel in the final result.
''' For example, if pixg is all 0, pixs2 is transparent and
''' the result in pixd is simply pixs1.
''' (5) A typical use is for the pixs2/pixg combination to be
''' a small watermark that is applied to pixs1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - 8 bpp gray, rgb, rgba or colormapped</param>
'''  <param name="pixs2">[in] - 8 bpp gray, rgb, rgba or colormapped</param>
'''  <param name="pixg">[in][optional] - 8 bpp gray, for transparency of pixs2; can be null</param>
'''  <param name="x">[in] - UL corner of pixs2 and pixg with respect to pixs1</param>
'''  <param name="y">[in] - UL corner of pixs2 and pixg with respect to pixs1</param>
'''   <returns>pixd blended image, or NULL on error</returns>
Public Shared Function pixBlendWithGrayMask(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				Optional ByVal pixg as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendWithGrayMask( pixs1.Pointer, pixs2.Pointer, pixgPTR, x, y)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1846, 1)
' pixBlendBackgroundToColor()
' pixBlendBackgroundToColor(PIX *, PIX *, BOX *, l_uint32, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This in effect replaces light background pixels in pixs
''' by the input color.  It does it by alpha blending so that
''' there are no visible artifacts from hard cutoffs.
''' (2) If pixd == pixs, this is done in-place.
''' (3) If box == NULL, this is performed on all of pixs.
''' (4) The alpha component for blending is derived from pixs,
''' by converting to grayscale and enhancing with a TRC.
''' (5) The last three arguments specify the TRC operation.
''' Suggested values are %gamma = 0.3, %minval = 50, %maxval = 200.
''' To skip the TRC, use %gamma == 1, %minval = 0, %maxval = 255.
''' See pixGammaTRC() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - or pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="box">[in] - region for blending; can be NULL)</param>
'''  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
'''  <param name="gamma">[in] - args for grayscale TRC mapping</param>
'''  <param name="minval">[in] - args for grayscale TRC mapping</param>
'''  <param name="maxval">[in] - args for grayscale TRC mapping</param>
'''   <returns>pixd always</returns>
Public Shared Function pixBlendBackgroundToColor(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal color as UInteger, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (color) then Throw New ArgumentNullException  ("color cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlendBackgroundToColor( pixdPTR, pixs.Pointer, box.Pointer, color, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (1926, 1)
' pixMultiplyByColor()
' pixMultiplyByColor(PIX *, PIX *, BOX *, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) This filters all pixels in the specified region by
''' multiplying each component by the input color.
''' This leaves black invariant and transforms white to the
''' input color.
''' (2) If pixd == pixs, this is done in-place.
''' (3) If box == NULL, this is performed on all of pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - or pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="box">[in] - region for filtering; can be NULL)</param>
'''  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
'''   <returns>pixd always</returns>
Public Shared Function pixMultiplyByColor(
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal color as UInteger, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (color) then Throw New ArgumentNullException  ("color cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMultiplyByColor( pixdPTR, pixs.Pointer, box.Pointer, color)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (2004, 1)
' pixAlphaBlendUniform()
' pixAlphaBlendUniform(PIX *, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a convenience function that renders 32 bpp RGBA images
''' (with an alpha channel) over a uniform background of
''' value %color.  To render over a white background,
''' use %color = 0xffffff00.  The result is an RGB image.
''' (2) If pixs does not have an alpha channel, it returns a clone
''' of pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgba, with alpha</param>
'''  <param name="color">[in] - 32 bit color in 0xrrggbb00 format</param>
'''   <returns>pixd 32 bpp rgb pixs blended over uniform color %color, a clone of pixs if no alpha, and NULL on error</returns>
Public Shared Function pixAlphaBlendUniform(
				ByVal pixs as Pix, 
				ByVal color as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (color) then Throw New ArgumentNullException  ("color cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAlphaBlendUniform( pixs.Pointer, color)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (2057, 1)
' pixAddAlphaToBlend()
' pixAddAlphaToBlend(PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a simple alpha layer generator, where typically white has
''' maximum transparency and black has minimum.
''' (2) If %invert == 1, generate the same alpha layer but invert
''' the input image photometrically.  This is useful for blending
''' over dark images, where you want dark regions in pixs, such
''' as text, to be lighter in the blended image.
''' (3) The fade %fract gives the minimum transparency (i.e.,
''' maximum opacity).  A small fraction is useful for adding
''' a watermark to an image.
''' (4) If pixs has a colormap, it is removed to rgb.
''' (5) If pixs already has an alpha layer, it is overwritten.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="fract">[in] - fade fraction in the alpha component</param>
'''  <param name="invert">[in] - 1 to photometrically invert pixs</param>
'''   <returns>pixd 32 bpp with alpha, or NULL on error</returns>
Public Shared Function pixAddAlphaToBlend(
				ByVal pixs as Pix, 
				ByVal fract as Single, 
				ByVal invert as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAddAlphaToBlend( pixs.Pointer, fract, invert)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (2116, 1)
' pixSetAlphaOverWhite()
' pixSetAlphaOverWhite(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The generated alpha component is transparent over white
''' (background) pixels in pixs, and quickly grades to opaque
''' away from the transparent parts.  This is a cheap and
''' dirty alpha generator.  The 2 pixel gradation is useful
''' to blur the boundary between the transparent region
''' (that will render entirely from a backing image) and
''' the remainder which renders from pixs.
''' (2) All alpha component bits in pixs are overwritten.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - colormapped or 32 bpp rgb; no alpha</param>
'''   <returns>pixd new pix with meaningful alpha component, or NULL on error</returns>
Public Shared Function pixSetAlphaOverWhite(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSetAlphaOverWhite( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\blend.c (2178, 1)
' pixLinearEdgeFade()
' pixLinearEdgeFade(PIX *, l_int32, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation.
''' (2) Maximum fading fraction %maxfade occurs at the edge of the image,
''' and the fraction goes to 0 at the fractional distance %distfract
''' from the edge.  %maxfade must be in [0, 1].
''' (3) %distrfact must be in [0, 1], and typically it would be LT= 0.5.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="dir">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
'''  <param name="fadeto">[in] - L_BLEND_TO_WHITE, L_BLEND_TO_BLACK</param>
'''  <param name="distfract">[in] - fraction of width or height over which fading occurs</param>
'''  <param name="maxfade">[in] - fraction of fading at the edge, LT= 1.0</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixLinearEdgeFade(
				ByVal pixs as Pix, 
				ByVal dir as Enumerations.L_scan_direction, 
				ByVal fadeto as Enumerations.L_BLEND, 
				ByVal distfract as Single, 
				ByVal maxfade as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (distfract) then Throw New ArgumentNullException  ("distfract cannot be Nothing")
	If IsNothing (maxfade) then Throw New ArgumentNullException  ("maxfade cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixLinearEdgeFade( pixs.Pointer, dir, fadeto, distfract, maxfade)

	Return _Result
End Function

End Class
