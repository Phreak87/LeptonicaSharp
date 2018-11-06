Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\coloring.c (126, 1)
' pixColorGrayRegions(pixs, boxa, type, thresh, rval, gval, bval) as Pix
' pixColorGrayRegions(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a new image, where some of the pixels in each<para/>
''' box in the boxa are colorized.  See pixColorGray() for usage<para/>
''' with %type and %thresh.  Note that %thresh is only used for<para/>
''' rgb it is ignored for colormapped images.<para/>
''' (2) If the input image is colormapped, the new image will be 8 bpp<para/>
''' colormapped if possible otherwise, it will be converted<para/>
''' to 32 bpp rgb.  Only pixels that are strictly gray will be<para/>
''' colorized.<para/>
''' (3) If the input image is not colormapped, it is converted to rgb.<para/>
''' A "gray" value for a pixel is determined by averaging the<para/>
''' components, and the output rgb value is determined from this.<para/>
''' (4) This can be used in conjunction with pixHasHighlightRed() to<para/>
''' add highlight color to a grayscale image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGrayRegions/*"/>
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
' pixColorGray(pixs, box, type, thresh, rval, gval, bval) as Integer
' pixColorGray(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place operation pixs is modified.<para/>
''' If pixs is colormapped, the operation will add colors to the<para/>
''' colormap.  Otherwise, pixs will be converted to 32 bpp rgb if<para/>
''' it is initially 8 bpp gray.<para/>
''' (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,<para/>
''' preserving antialiasing.<para/>
''' If type == L_PAINT_DARK, it colorizes non-white pixels,<para/>
''' preserving antialiasing.<para/>
''' (3) If box is NULL, applies function to the entire image otherwise,<para/>
''' clips the operation to the intersection of the box and pix.<para/>
''' (4) If colormapped, calls pixColorGrayCmap(), which applies the<para/>
''' coloring algorithm only to pixels that are strictly gray.<para/>
''' (5) For RGB, determines a "gray" value by averaging then uses this<para/>
''' value, plus the input rgb target, to generate the output<para/>
''' pixel values.<para/>
''' (6) thresh is only used for rgb it is ignored for colormapped pix.<para/>
''' If type == L_PAINT_LIGHT, use thresh = 0 if all pixels are to<para/>
''' be colored (black pixels will be unaltered).<para/>
''' In situations where there are a lot of black pixels,<para/>
''' setting thresh  is greater  0 will make the function considerably<para/>
''' more efficient without affecting the final result.<para/>
''' If type == L_PAINT_DARK, use thresh = 255 if all pixels<para/>
''' are to be colored (white pixels will be unaltered).<para/>
''' In situations where there are a lot of white pixels,<para/>
''' setting thresh  is lower  255 will make the function considerably<para/>
''' more efficient without affecting the final result.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGray/*"/>
'''  <param name="pixs">[in] - 8 bpp gray, rgb or colormapped image</param>
'''  <param name="box">[in][optional] - region in which to apply color can be NULL</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
'''  <param name="rval">[in] - new color to paint</param>
'''  <param name="gval">[in] - new color to paint</param>
'''  <param name="bval">[in] - new color to paint</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixColorGray(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal type as Enumerations.L_PAINT, 
				 ByVal thresh as Integer, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorGray( pixs.Pointer, boxPTR, type, thresh, rval, gval, bval)

	Return _Result
End Function

' SRC\coloring.c (353, 1)
' pixColorGrayMasked(pixs, pixm, type, thresh, rval, gval, bval) as Pix
' pixColorGrayMasked(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a new image, where some of the pixels under<para/>
''' FG in the mask are colorized.<para/>
''' (2) See pixColorGray() for usage with %type and %thresh.  Note<para/>
''' that %thresh is only used for rgb it is ignored for<para/>
''' colormapped images.  In most cases, the mask will be over<para/>
''' the darker parts and %type == L_PAINT_DARK.<para/>
''' (3) If pixs is colormapped this calls pixColorMaskedCmap(),<para/>
''' which adds colors to the colormap for pixd it only adds<para/>
''' colors corresponding to strictly gray colors in the colormap.<para/>
''' Otherwise, if pixs is 8 bpp gray, pixd will be 32 bpp rgb.<para/>
''' (4) If pixs is 32 bpp rgb, for each pixel a "gray" value is<para/>
''' found by averaging.  This average is then used with the<para/>
''' input rgb target to generate the output pixel values.<para/>
''' (5) This can be used in conjunction with pixHasHighlightRed() to<para/>
''' add highlight color to a grayscale image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGrayMasked/*"/>
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
' pixSnapColor(pixd, pixs, srcval, dstval, diff) as Pix
' pixSnapColor(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For inplace operation, call it this way:<para/>
''' pixSnapColor(pixs, pixs, ... )<para/>
''' (2) For generating a new pixd:<para/>
''' pixd = pixSnapColor(NULL, pixs, ...)<para/>
''' (3) If pixs has a colormap, it is handled by pixSnapColorCmap().<para/>
''' (4) All pixels within 'diff' of 'srcval', componentwise,<para/>
''' will be changed to 'dstval'.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSnapColor/*"/>
'''  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - colormapped or 8 bpp gray or 32 bpp rgb</param>
'''  <param name="srcval">[in] - color center to be selected for change: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color for pixels: 0xrrggbb00</param>
'''  <param name="diff">[in] - max absolute difference, applied to all components</param>
'''   <returns>pixd with all pixels within diff of pixval set to pixval, or pixd on error</returns>
Public Shared Function pixSnapColor(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal srcval as UInteger, 
				 ByVal dstval as UInteger, 
				 ByVal diff as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSnapColor( pixdPTR, pixs.Pointer, srcval, dstval, diff)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (565, 1)
' pixSnapColorCmap(pixd, pixs, srcval, dstval, diff) as Pix
' pixSnapColorCmap(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For inplace operation, call it this way:<para/>
''' pixSnapCcmap(pixs, pixs, ... )<para/>
''' (2) For generating a new pixd:<para/>
''' pixd = pixSnapCmap(NULL, pixs, ...)<para/>
''' (3) pixs must have a colormap.<para/>
''' (4) All colors within 'diff' of 'srcval', componentwise,<para/>
''' will be changed to 'dstval'.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSnapColorCmap/*"/>
'''  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - colormapped</param>
'''  <param name="srcval">[in] - color center to be selected for change: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color for pixels: 0xrrggbb00</param>
'''  <param name="diff">[in] - max absolute difference, applied to all components</param>
'''   <returns>pixd with all pixels within diff of srcval set to dstval, or pixd on error</returns>
Public Shared Function pixSnapColorCmap(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal srcval as UInteger, 
				 ByVal dstval as UInteger, 
				 ByVal diff as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSnapColorCmap( pixdPTR, pixs.Pointer, srcval, dstval, diff)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (681, 1)
' pixLinearMapToTargetColor(pixd, pixs, srcval, dstval) as Pix
' pixLinearMapToTargetColor(PIX *, PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each component (r, b, g) separately, this does a piecewise<para/>
''' linear mapping of the colors in pixs to colors in pixd.<para/>
''' If rs and rd are the red src and dest components in %srcval and<para/>
''' %dstval, then the range [0 ... rs] in pixs is mapped to<para/>
''' [0 ... rd] in pixd.  Likewise, the range [rs ... 255] in pixs<para/>
''' is mapped to [rd ... 255] in pixd.  And similarly for green<para/>
''' and blue.<para/>
''' (2) The mapping will in general change the hue of the pixels.<para/>
''' However, if the src and dst targets are related by<para/>
''' a transformation given by pixelFractionalShift(), the hue<para/>
''' is invariant.<para/>
''' (3) For inplace operation, call it this way:<para/>
''' pixLinearMapToTargetColor(pixs, pixs, ... )<para/>
''' (4) For generating a new pixd:<para/>
''' pixd = pixLinearMapToTargetColor(NULL, pixs, ...)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixLinearMapToTargetColor/*"/>
'''  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="srcval">[in] - source color: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color: 0xrrggbb00</param>
'''   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
Public Shared Function pixLinearMapToTargetColor(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal srcval as UInteger, 
				 ByVal dstval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixLinearMapToTargetColor( pixdPTR, pixs.Pointer, srcval, dstval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (778, 1)
' pixelLinearMapToTargetColor(scolor, srcmap, dstmap, pdcolor) as Integer
' pixelLinearMapToTargetColor(l_uint32, l_uint32, l_uint32, l_uint32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does this does a piecewise linear mapping of each<para/>
''' component of %scolor to %dcolor, based on the relation<para/>
''' between the components of %srcmap and %dstmap.  It is the<para/>
''' same transformation, performed on a single color, as mapped<para/>
''' on every pixel in a pix by pixLinearMapToTargetColor().<para/>
''' (2) For each component, if the sval is larger than the smap,<para/>
''' the dval will be pushed up from dmap towards white.<para/>
''' Otherwise, dval will be pushed down from dmap towards black.<para/>
''' This is because you can visualize the transformation as<para/>
''' a linear stretching where smap moves to dmap, and everything<para/>
''' else follows linearly with 0 and 255 fixed.<para/>
''' (3) The mapping will in general change the hue of %scolor.<para/>
''' However, if the %srcmap and %dstmap targets are related by<para/>
''' a transformation given by pixelFractionalShift(), the hue<para/>
''' will be invariant.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixelLinearMapToTargetColor/*"/>
'''  <param name="scolor">[in] - rgb source color: 0xrrggbb00</param>
'''  <param name="srcmap">[in] - source mapping color: 0xrrggbb00</param>
'''  <param name="dstmap">[in] - target mapping color: 0xrrggbb00</param>
'''  <param name="pdcolor">[out] - rgb dest color: 0xrrggbb00</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelLinearMapToTargetColor(
				 ByVal scolor as UInteger, 
				 ByVal srcmap as UInteger, 
				 ByVal dstmap as UInteger, 
				<Out()> ByRef pdcolor as UInteger) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixelLinearMapToTargetColor( scolor, srcmap, dstmap, pdcolor)

	Return _Result
End Function

' SRC\coloring.c (863, 1)
' pixShiftByComponent(pixd, pixs, srcval, dstval) as Pix
' pixShiftByComponent(PIX *, PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each component (r, b, g) separately, this does a linear<para/>
''' mapping of the colors in pixs to colors in pixd.<para/>
''' Let rs and rd be the red src and dest components in %srcval and<para/>
''' %dstval, and rval is the red component of the src pixel.<para/>
''' Then for all pixels in pixs, the mapping for the red<para/>
''' component from pixs to pixd is:<para/>
''' if (rd  is lower = rs) (shift toward black)<para/>
''' rval -- is greater  (rd/rs)  rval<para/>
''' if (rd  is greater  rs)  (shift toward white)<para/>
''' (255 - rval) -- is greater  ((255 - rs)/(255 - rd))  (255 - rval)<para/>
''' Thus if rd  is lower = rs, the red component of all pixels is<para/>
''' mapped by the same fraction toward white, and if rd  is greater  rs,<para/>
''' they are mapped by the same fraction toward black.<para/>
''' This is essentially a different linear TRC (gamma = 1)<para/>
''' for each component.  The source and target color inputs are<para/>
''' just used to generate the three fractions.<para/>
''' (2) Note that this mapping differs from that in<para/>
''' pixLinearMapToTargetColor(), which maps rs -- is greater  rd and does<para/>
''' a piecewise stretching in between.<para/>
''' (3) For inplace operation, call it this way:<para/>
''' pixFractionalShiftByComponent(pixs, pixs, ... )<para/>
''' (4) For generating a new pixd:<para/>
''' pixd = pixLinearMapToTargetColor(NULL, pixs, ...)<para/>
''' (5) A simple application is to color a grayscale image.<para/>
''' A light background can be colored using srcval = 0xffffff00<para/>
''' and picking a target background color for dstval.<para/>
''' A dark foreground can be colored by using srcval = 0x0<para/>
''' and choosing a target foreground color for dstval.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixShiftByComponent/*"/>
'''  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="srcval">[in] - source color: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color: 0xrrggbb00</param>
'''   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
Public Shared Function pixShiftByComponent(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal srcval as UInteger, 
				 ByVal dstval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixShiftByComponent( pixdPTR, pixs.Pointer, srcval, dstval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\coloring.c (964, 1)
' pixelShiftByComponent(rval, gval, bval, srcval, dstval, ppixel) as Integer
' pixelShiftByComponent(l_int32, l_int32, l_int32, l_uint32, l_uint32, l_uint32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a linear transformation that gives the same result<para/>
''' on a single pixel as pixShiftByComponent() gives<para/>
''' on a pix.  Each component is handled separately.  If<para/>
''' the dest component is larger than the src, then the<para/>
''' component is pushed toward 255 by the same fraction as<para/>
''' the src -- is greater  dest shift.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixelShiftByComponent/*"/>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="srcval">[in] - source color: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color: 0xrrggbb00</param>
'''  <param name="ppixel">[out] - rgb value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelShiftByComponent(
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer, 
				 ByVal srcval as UInteger, 
				 ByVal dstval as UInteger, 
				<Out()> ByRef ppixel as UInteger) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixelShiftByComponent( rval, gval, bval, srcval, dstval, ppixel)

	Return _Result
End Function

' SRC\coloring.c (1023, 1)
' pixelFractionalShift(rval, gval, bval, fraction, ppixel) as Integer
' pixelFractionalShift(l_int32, l_int32, l_int32, l_float32, l_uint32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This transformation leaves the hue invariant, while changing<para/>
''' the saturation and intensity.  It can be used for that<para/>
''' purpose in pixLinearMapToTargetColor().<para/>
''' (2) %fraction is in the range [-1 .... +1].  If %fraction  is lower  0,<para/>
''' saturation is increased and brightness is reduced.  The<para/>
''' opposite results if %fraction  is greater  0.  If %fraction == -1,<para/>
''' the resulting pixel is black %fraction == 1 results in white.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixelFractionalShift/*"/>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fraction">[in] - negative toward black positive toward white</param>
'''  <param name="ppixel">[out] - rgb value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixelFractionalShift(
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer, 
				 ByVal fraction as Single, 
				<Out()> ByRef ppixel as UInteger) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixelFractionalShift( rval, gval, bval, fraction, ppixel)

	Return _Result
End Function

End Class
