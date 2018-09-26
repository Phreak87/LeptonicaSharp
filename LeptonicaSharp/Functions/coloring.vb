Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\coloring.c (126, 1)
' pixColorGrayRegions()
' pixColorGrayRegions(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This generates a new image, where some of the pixels in each
''' box in the boxa are colorized.  See pixColorGray() for usage
''' with %type and %thresh.  Note that %thresh is only used for
''' rgb; it is ignored for colormapped images.
''' (2) If the input image is colormapped, the new image will be 8 bpp
''' colormapped if possible; otherwise, it will be converted
''' to 32 bpp rgb.  Only pixels that are strictly gray will be
''' colorized.
''' (3) If the input image is not colormapped, it is converted to rgb.
''' A "gray" value for a pixel is determined by averaging the
''' components, and the output rgb value is determined from this.
''' (4) This can be used in conjunction with pixHasHighlightRed() to
''' add highlight color to a grayscale image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp gray, rgb, or colormapped</param>
'''  <param name="boxa">[in] - of regions in which to apply color</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
'''  <param name="rval">[in] - new color to paint</param>
'''  <param name="gval">[in] - new color to paint</param>
'''  <param name="bval">[in] - new color to paint</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixColorGrayRegions(
				ByVal pixs as Pix, 
				ByVal boxa as Boxa, 
				ByVal type as Enumerations.L_PAINT, 
				ByVal thresh as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorGrayRegions( pixs.Pointer, boxa.Pointer, type, thresh, rval, gval, bval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (227, 1)
' pixColorGray()
' pixColorGray(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place operation; pixs is modified.
''' If pixs is colormapped, the operation will add colors to the
''' colormap.  Otherwise, pixs will be converted to 32 bpp rgb if
''' it is initially 8 bpp gray.
''' (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
''' preserving antialiasing.
''' If type == L_PAINT_DARK, it colorizes non-white pixels,
''' preserving antialiasing.
''' (3) If box is NULL, applies function to the entire image; otherwise,
''' clips the operation to the intersection of the box and pix.
''' (4) If colormapped, calls pixColorGrayCmap(), which applies the
''' coloring algorithm only to pixels that are strictly gray.
''' (5) For RGB, determines a "gray" value by averaging; then uses this
''' value, plus the input rgb target, to generate the output
''' pixel values.
''' (6) thresh is only used for rgb; it is ignored for colormapped pix.
''' If type == L_PAINT_LIGHT, use thresh = 0 if all pixels are to
''' be colored (black pixels will be unaltered).
''' In situations where there are a lot of black pixels,
''' setting thresh GT 0 will make the function considerably
''' more efficient without affecting the final result.
''' If type == L_PAINT_DARK, use thresh = 255 if all pixels
''' are to be colored (white pixels will be unaltered).
''' In situations where there are a lot of white pixels,
''' setting thresh LT 255 will make the function considerably
''' more efficient without affecting the final result.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray, rgb or colormapped image</param>
'''  <param name="box">[in][optional] - region in which to apply color; can be NULL</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
'''  <param name="rval">[in] - new color to paint</param>
'''  <param name="gval">[in] - new color to paint</param>
'''  <param name="bval">[in] - new color to paint</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixColorGray(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_PAINT, 
				ByVal thresh as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorGray( pixs.Pointer, boxPTR, type, thresh, rval, gval, bval)

	Return _Result
End Function

' SRC\coloring.c (353, 1)
' pixColorGrayMasked()
' pixColorGrayMasked(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This generates a new image, where some of the pixels under
''' FG in the mask are colorized.
''' (2) See pixColorGray() for usage with %type and %thresh.  Note
''' that %thresh is only used for rgb; it is ignored for
''' colormapped images.  In most cases, the mask will be over
''' the darker parts and %type == L_PAINT_DARK.
''' (3) If pixs is colormapped this calls pixColorMaskedCmap(),
''' which adds colors to the colormap for pixd; it only adds
''' colors corresponding to strictly gray colors in the colormap.
''' Otherwise, if pixs is 8 bpp gray, pixd will be 32 bpp rgb.
''' (4) If pixs is 32 bpp rgb, for each pixel a "gray" value is
''' found by averaging.  This average is then used with the
''' input rgb target to generate the output pixel values.
''' (5) This can be used in conjunction with pixHasHighlightRed() to
''' add highlight color to a grayscale image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray, rgb or colormapped image</param>
'''  <param name="pixm">[in] - 1 bpp mask, through which to apply color</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
'''  <param name="rval">[in] - new color to paint</param>
'''  <param name="gval">[in] - new color to paint</param>
'''  <param name="bval">[in] - new color to paint</param>
'''   <returns>pixd colorized, or NULL on error</returns>
Public Shared Function pixColorGrayMasked(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal type as Enumerations.L_PAINT, 
				ByVal thresh as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorGrayMasked( pixs.Pointer, pixm.Pointer, type, thresh, rval, gval, bval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (478, 1)
' pixSnapColor()
' pixSnapColor(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation, call it this way
''' pixSnapColor(pixs, pixs, ... )
''' (2) For generating a new pixd
''' pixd = pixSnapColor(NULL, pixs, ...)
''' (3) If pixs has a colormap, it is handled by pixSnapColorCmap().
''' (4) All pixels within 'diff' of 'srcval', componentwise,
''' will be changed to 'dstval'.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - colormapped or 8 bpp gray or 32 bpp rgb</param>
'''  <param name="srcval">[in] - color center to be selected for change 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color for pixels 0xrrggbb00</param>
'''  <param name="diff">[in] - max absolute difference, applied to all components</param>
'''   <returns>pixd with all pixels within diff of pixval set to pixval, or pixd on error</returns>
Public Shared Function pixSnapColor(
				ByVal pixs as Pix, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger, 
				ByVal diff as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (srcval) then Throw New ArgumentNullException  ("srcval cannot be Nothing")
	If IsNothing (dstval) then Throw New ArgumentNullException  ("dstval cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSnapColor( pixdPTR, pixs.Pointer, srcval, dstval, diff)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (565, 1)
' pixSnapColorCmap()
' pixSnapColorCmap(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For inplace operation, call it this way
''' pixSnapCcmap(pixs, pixs, ... )
''' (2) For generating a new pixd
''' pixd = pixSnapCmap(NULL, pixs, ...)
''' (3) pixs must have a colormap.
''' (4) All colors within 'diff' of 'srcval', componentwise,
''' will be changed to 'dstval'.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - colormapped</param>
'''  <param name="srcval">[in] - color center to be selected for change 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color for pixels 0xrrggbb00</param>
'''  <param name="diff">[in] - max absolute difference, applied to all components</param>
'''   <returns>pixd with all pixels within diff of srcval set to dstval, or pixd on error</returns>
Public Shared Function pixSnapColorCmap(
				ByVal pixs as Pix, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger, 
				ByVal diff as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (srcval) then Throw New ArgumentNullException  ("srcval cannot be Nothing")
	If IsNothing (dstval) then Throw New ArgumentNullException  ("dstval cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSnapColorCmap( pixdPTR, pixs.Pointer, srcval, dstval, diff)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (681, 1)
' pixLinearMapToTargetColor()
' pixLinearMapToTargetColor(PIX *, PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) For each component (r, b, g) separately, this does a piecewise
''' linear mapping of the colors in pixs to colors in pixd.
''' If rs and rd are the red src and dest components in %srcval and
''' %dstval, then the range [0 ... rs] in pixs is mapped to
''' [0 ... rd] in pixd.  Likewise, the range [rs ... 255] in pixs
''' is mapped to [rd ... 255] in pixd.  And similarly for green
''' and blue.
''' (2) The mapping will in general change the hue of the pixels.
''' However, if the src and dst targets are related by
''' a transformation given by pixelFractionalShift(), the hue
''' is invariant.
''' (3) For inplace operation, call it this way
''' pixLinearMapToTargetColor(pixs, pixs, ... )
''' (4) For generating a new pixd
''' pixd = pixLinearMapToTargetColor(NULL, pixs, ...)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="srcval">[in] - source color 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color 0xrrggbb00</param>
'''   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
Public Shared Function pixLinearMapToTargetColor(
				ByVal pixs as Pix, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (srcval) then Throw New ArgumentNullException  ("srcval cannot be Nothing")
	If IsNothing (dstval) then Throw New ArgumentNullException  ("dstval cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixLinearMapToTargetColor( pixdPTR, pixs.Pointer, srcval, dstval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (778, 1)
' pixelLinearMapToTargetColor()
' pixelLinearMapToTargetColor(l_uint32, l_uint32, l_uint32, l_uint32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This does this does a piecewise linear mapping of each
''' component of %scolor to %dcolor, based on the relation
''' between the components of %srcmap and %dstmap.  It is the
''' same transformation, performed on a single color, as mapped
''' on every pixel in a pix by pixLinearMapToTargetColor().
''' (2) For each component, if the sval is larger than the smap,
''' the dval will be pushed up from dmap towards white.
''' Otherwise, dval will be pushed down from dmap towards black.
''' This is because you can visualize the transformation as
''' a linear stretching where smap moves to dmap, and everything
''' else follows linearly with 0 and 255 fixed.
''' (3) The mapping will in general change the hue of %scolor.
''' However, if the %srcmap and %dstmap targets are related by
''' a transformation given by pixelFractionalShift(), the hue
''' will be invariant.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="scolor">[in] - rgb source color 0xrrggbb00</param>
'''  <param name="srcmap">[in] - source mapping color 0xrrggbb00</param>
'''  <param name="dstmap">[in] - target mapping color 0xrrggbb00</param>
'''  <param name="pdcolor">[out] - rgb dest color 0xrrggbb00</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelLinearMapToTargetColor(
				ByVal scolor as UInteger, 
				ByVal srcmap as UInteger, 
				ByVal dstmap as UInteger, 
				ByRef pdcolor as UInteger) as Integer

	If IsNothing (scolor) then Throw New ArgumentNullException  ("scolor cannot be Nothing")
	If IsNothing (srcmap) then Throw New ArgumentNullException  ("srcmap cannot be Nothing")
	If IsNothing (dstmap) then Throw New ArgumentNullException  ("dstmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixelLinearMapToTargetColor( scolor, srcmap, dstmap, pdcolor)

	Return _Result
End Function

' SRC\coloring.c (863, 1)
' pixShiftByComponent()
' pixShiftByComponent(PIX *, PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) For each component (r, b, g) separately, this does a linear
''' mapping of the colors in pixs to colors in pixd.
''' Let rs and rd be the red src and dest components in %srcval and
''' %dstval, and rval is the red component of the src pixel.
''' Then for all pixels in pixs, the mapping for the red
''' component from pixs to pixd is
''' if (rd LT= rs)   (shift toward black)
''' rval --GT (rd/rs)  rval
''' if (rd GT rs) (shift toward white)
''' (255 - rval) --GT ((255 - rs)/(255 - rd))  (255 - rval)
''' Thus if rd LT= rs, the red component of all pixels is
''' mapped by the same fraction toward white, and if rd GT rs,
''' they are mapped by the same fraction toward black.
''' This is essentially a different linear TRC (gamma = 1)
''' for each component.  The source and target color inputs are
''' just used to generate the three fractions.
''' (2) Note that this mapping differs from that in
''' pixLinearMapToTargetColor(), which maps rs --GT rd and does
''' a piecewise stretching in between.
''' (3) For inplace operation, call it this way
''' pixFractionalShiftByComponent(pixs, pixs, ... )
''' (4) For generating a new pixd
''' pixd = pixLinearMapToTargetColor(NULL, pixs, ...)
''' (5) A simple application is to color a grayscale image.
''' A light background can be colored using srcval = 0xffffff00
''' and picking a target background color for dstval.
''' A dark foreground can be colored by using srcval = 0x0
''' and choosing a target foreground color for dstval.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="srcval">[in] - source color 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color 0xrrggbb00</param>
'''   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
Public Shared Function pixShiftByComponent(
				ByVal pixs as Pix, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (srcval) then Throw New ArgumentNullException  ("srcval cannot be Nothing")
	If IsNothing (dstval) then Throw New ArgumentNullException  ("dstval cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixShiftByComponent( pixdPTR, pixs.Pointer, srcval, dstval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (964, 1)
' pixelShiftByComponent()
' pixelShiftByComponent(l_int32, l_int32, l_int32, l_uint32, l_uint32, l_uint32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a linear transformation that gives the same result
''' on a single pixel as pixShiftByComponent() gives
''' on a pix.  Each component is handled separately.  If
''' the dest component is larger than the src, then the
''' component is pushed toward 255 by the same fraction as
''' the src --GT dest shift.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="srcval">[in] - source color 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color 0xrrggbb00</param>
'''  <param name="ppixel">[out] - rgb value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelShiftByComponent(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger, 
				ByRef ppixel as UInteger) as Integer

	If IsNothing (srcval) then Throw New ArgumentNullException  ("srcval cannot be Nothing")
	If IsNothing (dstval) then Throw New ArgumentNullException  ("dstval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixelShiftByComponent( rval, gval, bval, srcval, dstval, ppixel)

	Return _Result
End Function

' SRC\coloring.c (1023, 1)
' pixelFractionalShift()
' pixelFractionalShift(l_int32, l_int32, l_int32, l_float32, l_uint32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This transformation leaves the hue invariant, while changing
''' the saturation and intensity.  It can be used for that
''' purpose in pixLinearMapToTargetColor().
''' (2) %fraction is in the range [-1 .... +1].  If %fraction LT 0,
''' saturation is increased and brightness is reduced.  The
''' opposite results if %fraction GT 0.  If %fraction == -1,
''' the resulting pixel is black; %fraction == 1 results in white.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fraction">[in] - negative toward black; positive toward white</param>
'''  <param name="ppixel">[out] - rgb value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelFractionalShift(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal fraction as Single, 
				ByRef ppixel as UInteger) as Integer

	If IsNothing (fraction) then Throw New ArgumentNullException  ("fraction cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixelFractionalShift( rval, gval, bval, fraction, ppixel)

	Return _Result
End Function

End Class
