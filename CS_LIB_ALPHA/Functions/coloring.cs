using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// coloring.c (126, 1)
// pixColorGrayRegions(pixs, boxa, type, thresh, rval, gval, bval) as Pix
// pixColorGrayRegions(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This generates a new image, where some of the pixels in each
/// box in the boxa are colorized.  See pixColorGray() for usage
/// with %type and %thresh.  Note that %thresh is only used for
/// rgb it is ignored for colormapped images.<para/>
/// 
/// (2) If the input image is colormapped, the new image will be 8 bpp
/// colormapped if possible otherwise, it will be converted
/// to 32 bpp rgb.  Only pixels that are strictly gray will be
/// colorized.<para/>
/// 
/// (3) If the input image is not colormapped, it is converted to rgb.
/// A "gray" value for a pixel is determined by averaging the
/// components, and the output rgb value is determined from this.<para/>
/// 
/// (4) This can be used in conjunction with pixHasHighlightRed() to
/// add highlight color to a grayscale image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGrayRegions/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp gray, rgb, or colormapped</param>
///  <param name="boxa">[in] - of regions in which to apply color</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
///  <param name="rval">[in] - new color to paint</param>
///  <param name="gval">[in] - new color to paint</param>
///  <param name="bval">[in] - new color to paint</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixColorGrayRegions(
				  Pix pixs, 
				  Boxa boxa, 
				  int type, 
				  int thresh, 
				  int rval, 
				  int gval, 
				  int bval){

	IntPtr _Result = Natives.pixColorGrayRegions(pixs.Pointer, boxa.Pointer,   type,   thresh,   rval,   gval,   bval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (227, 1)
// pixColorGray(pixs, box, type, thresh, rval, gval, bval) as int
// pixColorGray(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation pixs is modified.
/// If pixs is colormapped, the operation will add colors to the
/// colormap.  Otherwise, pixs will be converted to 32 bpp rgb if
/// it is initially 8 bpp gray.<para/>
/// 
/// (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
/// preserving antialiasing.
/// If type == L_PAINT_DARK, it colorizes non-white pixels,
/// preserving antialiasing.<para/>
/// 
/// (3) If box is NULL, applies function to the entire image otherwise,
/// clips the operation to the intersection of the box and pix.<para/>
/// 
/// (4) If colormapped, calls pixColorGrayCmap(), which applies the
/// coloring algorithm only to pixels that are strictly gray.<para/>
/// 
/// (5) For RGB, determines a "gray" value by averaging then uses this
/// value, plus the input rgb target, to generate the output
/// pixel values.<para/>
/// 
/// (6) thresh is only used for rgb it is ignored for colormapped pix.
/// If type == L_PAINT_LIGHT, use thresh = 0 if all pixels are to
/// be colored (black pixels will be unaltered).
/// In situations where there are a lot of black pixels,
/// setting thresh  is greater  0 will make the function considerably
/// more efficient without affecting the final result.
/// If type == L_PAINT_DARK, use thresh = 255 if all pixels
/// are to be colored (white pixels will be unaltered).
/// In situations where there are a lot of white pixels,
/// setting thresh  is smaller 255 will make the function considerably
/// more efficient without affecting the final result.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGray/*"/>
///  <param name="pixs">[in] - 8 bpp gray, rgb or colormapped image</param>
///  <param name="box">[in][optional] - region in which to apply color can be NULL</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
///  <param name="rval">[in] - new color to paint</param>
///  <param name="gval">[in] - new color to paint</param>
///  <param name="bval">[in] - new color to paint</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixColorGray(
				  Pix pixs, 
				  Box box, 
				  int type, 
				  int thresh, 
				  int rval, 
				  int gval, 
				  int bval){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixColorGray(pixs.Pointer, boxPtr,   type,   thresh,   rval,   gval,   bval);
	



	return _Result;
}

// coloring.c (353, 1)
// pixColorGrayMasked(pixs, pixm, type, thresh, rval, gval, bval) as Pix
// pixColorGrayMasked(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This generates a new image, where some of the pixels under
/// FG in the mask are colorized.<para/>
/// 
/// (2) See pixColorGray() for usage with %type and %thresh.  Note
/// that %thresh is only used for rgb it is ignored for
/// colormapped images.  In most cases, the mask will be over
/// the darker parts and %type == L_PAINT_DARK.<para/>
/// 
/// (3) If pixs is colormapped this calls pixColorMaskedCmap(),
/// which adds colors to the colormap for pixd it only adds
/// colors corresponding to strictly gray colors in the colormap.
/// Otherwise, if pixs is 8 bpp gray, pixd will be 32 bpp rgb.<para/>
/// 
/// (4) If pixs is 32 bpp rgb, for each pixel a "gray" value is
/// found by averaging.  This average is then used with the
/// input rgb target to generate the output pixel values.<para/>
/// 
/// (5) This can be used in conjunction with pixHasHighlightRed() to
/// add highlight color to a grayscale image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGrayMasked/*"/>
///  <param name="pixs">[in] - 8 bpp gray, rgb or colormapped image</param>
///  <param name="pixm">[in] - 1 bpp mask, through which to apply color</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="thresh">[in] - average value below/above which pixel is unchanged</param>
///  <param name="rval">[in] - new color to paint</param>
///  <param name="gval">[in] - new color to paint</param>
///  <param name="bval">[in] - new color to paint</param>
///   <returns>pixd colorized, or NULL on error</returns>
public static Pix pixColorGrayMasked(
				  Pix pixs, 
				  Pix pixm, 
				  int type, 
				  int thresh, 
				  int rval, 
				  int gval, 
				  int bval){

	IntPtr _Result = Natives.pixColorGrayMasked(pixs.Pointer, pixm.Pointer,   type,   thresh,   rval,   gval,   bval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (478, 1)
// pixSnapColor(pixd, pixs, srcval, dstval, diff) as Pix
// pixSnapColor(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) For inplace operation, call it this way:
/// pixSnapColor(pixs, pixs, ... )<para/>
/// 
/// (2) For generating a new pixd:
/// pixd = pixSnapColor(NULL, pixs, ...)<para/>
/// 
/// (3) If pixs has a colormap, it is handled by pixSnapColorCmap().<para/>
/// 
/// (4) All pixels within 'diff' of 'srcval', componentwise,
/// will be changed to 'dstval'.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSnapColor/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
///  <param name="pixs">[in] - colormapped or 8 bpp gray or 32 bpp rgb</param>
///  <param name="srcval">[in] - color center to be selected for change: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color for pixels: 0xrrggbb00</param>
///  <param name="diff">[in] - max absolute difference, applied to all components</param>
///   <returns>pixd with all pixels within diff of pixval set to pixval, or pixd on error</returns>
public static Pix pixSnapColor(
				  Pix pixd, 
				  Pix pixs, 
				  uint srcval, 
				  uint dstval, 
				  int diff){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSnapColor(pixdPtr, pixs.Pointer,   srcval,   dstval,   diff);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (565, 1)
// pixSnapColorCmap(pixd, pixs, srcval, dstval, diff) as Pix
// pixSnapColorCmap(PIX *, PIX *, l_uint32, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) For inplace operation, call it this way:
/// pixSnapCcmap(pixs, pixs, ... )<para/>
/// 
/// (2) For generating a new pixd:
/// pixd = pixSnapCmap(NULL, pixs, ...)<para/>
/// 
/// (3) pixs must have a colormap.<para/>
/// 
/// (4) All colors within 'diff' of 'srcval', componentwise,
/// will be changed to 'dstval'.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSnapColorCmap/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
///  <param name="pixs">[in] - colormapped</param>
///  <param name="srcval">[in] - color center to be selected for change: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color for pixels: 0xrrggbb00</param>
///  <param name="diff">[in] - max absolute difference, applied to all components</param>
///   <returns>pixd with all pixels within diff of srcval set to dstval, or pixd on error</returns>
public static Pix pixSnapColorCmap(
				  Pix pixd, 
				  Pix pixs, 
				  uint srcval, 
				  uint dstval, 
				  int diff){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSnapColorCmap(pixdPtr, pixs.Pointer,   srcval,   dstval,   diff);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (681, 1)
// pixLinearMapToTargetColor(pixd, pixs, srcval, dstval) as Pix
// pixLinearMapToTargetColor(PIX *, PIX *, l_uint32, l_uint32) as PIX *
///  <summary>
/// (1) For each component (r, b, g) separately, this does a piecewise
/// linear mapping of the colors in pixs to colors in pixd.
/// If rs and rd are the red src and dest components in %srcval and
/// %dstval, then the range [0 ... rs] in pixs is mapped to
/// [0 ... rd] in pixd.  Likewise, the range [rs ... 255] in pixs
/// is mapped to [rd ... 255] in pixd.  And similarly for green
/// and blue.<para/>
/// 
/// (2) The mapping will in general change the hue of the pixels.
/// However, if the src and dst targets are related by
/// a transformation given by pixelFractionalShift(), the hue
/// is invariant.<para/>
/// 
/// (3) For inplace operation, call it this way:
/// pixLinearMapToTargetColor(pixs, pixs, ... )<para/>
/// 
/// (4) For generating a new pixd:
/// pixd = pixLinearMapToTargetColor(NULL, pixs, ...)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLinearMapToTargetColor/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="srcval">[in] - source color: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color: 0xrrggbb00</param>
///   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
public static Pix pixLinearMapToTargetColor(
				  Pix pixd, 
				  Pix pixs, 
				  uint srcval, 
				  uint dstval){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixLinearMapToTargetColor(pixdPtr, pixs.Pointer,   srcval,   dstval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (778, 1)
// pixelLinearMapToTargetColor(scolor, srcmap, dstmap, pdcolor) as int
// pixelLinearMapToTargetColor(l_uint32, l_uint32, l_uint32, l_uint32 *) as l_ok
///  <summary>
/// (1) This does this does a piecewise linear mapping of each
/// component of %scolor to %dcolor, based on the relation
/// between the components of %srcmap and %dstmap.  It is the
/// same transformation, performed on a single color, as mapped
/// on every pixel in a pix by pixLinearMapToTargetColor().<para/>
/// 
/// (2) For each component, if the sval is larger than the smap,
/// the dval will be pushed up from dmap towards white.
/// Otherwise, dval will be pushed down from dmap towards black.
/// This is because you can visualize the transformation as
/// a linear stretching where smap moves to dmap, and everything
/// else follows linearly with 0 and 255 fixed.<para/>
/// 
/// (3) The mapping will in general change the hue of %scolor.
/// However, if the %srcmap and %dstmap targets are related by
/// a transformation given by pixelFractionalShift(), the hue
/// will be invariant.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixelLinearMapToTargetColor/*"/>
///  <param name="scolor">[in] - rgb source color: 0xrrggbb00</param>
///  <param name="srcmap">[in] - source mapping color: 0xrrggbb00</param>
///  <param name="dstmap">[in] - target mapping color: 0xrrggbb00</param>
///  <param name="pdcolor">[out] - rgb dest color: 0xrrggbb00</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixelLinearMapToTargetColor(
				  uint scolor, 
				  uint srcmap, 
				  uint dstmap, 
				 out uint pdcolor){

	int _Result = Natives.pixelLinearMapToTargetColor(  scolor,   srcmap,   dstmap, out  pdcolor);
	

pdcolor = 0;


	return _Result;
}

// coloring.c (863, 1)
// pixShiftByComponent(pixd, pixs, srcval, dstval) as Pix
// pixShiftByComponent(PIX *, PIX *, l_uint32, l_uint32) as PIX *
///  <summary>
/// (1) For each component (r, b, g) separately, this does a linear
/// mapping of the colors in pixs to colors in pixd.
/// Let rs and rd be the red src and dest components in %srcval and
/// %dstval, and rval is the red component of the src pixel.
/// Then for all pixels in pixs, the mapping for the red
/// component from pixs to pixd is:
/// if (rd smaller or equal rs) (shift toward black)
/// rval to (rd/rs)  rval
/// if (rd  is greater  rs)  (shift toward white)
/// (255 - rval) to ((255 - rs)/(255 - rd))  (255 - rval)
/// Thus if rd smaller or equal rs, the red component of all pixels is
/// mapped by the same fraction toward white, and if rd  is greater  rs,
/// they are mapped by the same fraction toward black.
/// This is essentially a different linear TRC (gamma = 1)
/// for each component.  The source and target color inputs are
/// just used to generate the three fractions.<para/>
/// 
/// (2) Note that this mapping differs from that in
/// pixLinearMapToTargetColor(), which maps rs to rd and does
/// a piecewise stretching in between.<para/>
/// 
/// (3) For inplace operation, call it this way:
/// pixFractionalShiftByComponent(pixs, pixs, ... )<para/>
/// 
/// (4) For generating a new pixd:
/// pixd = pixLinearMapToTargetColor(NULL, pixs, ...)<para/>
/// 
/// (5) A simple application is to color a grayscale image.
/// A light background can be colored using srcval = 0xffffff00
/// and picking a target background color for dstval.
/// A dark foreground can be colored by using srcval = 0x0
/// and choosing a target foreground color for dstval.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixShiftByComponent/*"/>
///  <param name="pixd">[in][optional] - either NULL or equal to pixs for in-place</param>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="srcval">[in] - source color: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color: 0xrrggbb00</param>
///   <returns>pixd with all pixels mapped based on the srcval/destval mapping, or pixd on error</returns>
public static Pix pixShiftByComponent(
				  Pix pixd, 
				  Pix pixs, 
				  uint srcval, 
				  uint dstval){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixShiftByComponent(pixdPtr, pixs.Pointer,   srcval,   dstval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// coloring.c (964, 1)
// pixelShiftByComponent(rval, gval, bval, srcval, dstval, ppixel) as int
// pixelShiftByComponent(l_int32, l_int32, l_int32, l_uint32, l_uint32, l_uint32 *) as l_ok
///  <summary>
/// (1) This is a linear transformation that gives the same result
/// on a single pixel as pixShiftByComponent() gives
/// on a pix.  Each component is handled separately.  If
/// the dest component is larger than the src, then the
/// component is pushed toward 255 by the same fraction as
/// the src to dest shift.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixelShiftByComponent/*"/>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="srcval">[in] - source color: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color: 0xrrggbb00</param>
///  <param name="ppixel">[out] - rgb value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixelShiftByComponent(
				  int rval, 
				  int gval, 
				  int bval, 
				  uint srcval, 
				  uint dstval, 
				 out uint ppixel){

	int _Result = Natives.pixelShiftByComponent(  rval,   gval,   bval,   srcval,   dstval, out  ppixel);
	

ppixel = 0;


	return _Result;
}

// coloring.c (1023, 1)
// pixelFractionalShift(rval, gval, bval, fraction, ppixel) as int
// pixelFractionalShift(l_int32, l_int32, l_int32, l_float32, l_uint32 *) as l_ok
///  <summary>
/// (1) This transformation leaves the hue invariant, while changing
/// the saturation and intensity.  It can be used for that
/// purpose in pixLinearMapToTargetColor().<para/>
/// 
/// (2) %fraction is in the range [-1 .... +1].  If %fraction  is smaller 0,
/// saturation is increased and brightness is reduced.  The
/// opposite results if %fraction  is greater  0.  If %fraction == -1,
/// the resulting pixel is black %fraction == 1 results in white.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixelFractionalShift/*"/>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fraction">[in] - negative toward black positive toward white</param>
///  <param name="ppixel">[out] - rgb value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixelFractionalShift(
				  int rval, 
				  int gval, 
				  int bval, 
				  Single fraction, 
				 out uint ppixel){

	int _Result = Natives.pixelFractionalShift(  rval,   gval,   bval,   fraction, out  ppixel);
	

ppixel = 0;


	return _Result;
}

}
