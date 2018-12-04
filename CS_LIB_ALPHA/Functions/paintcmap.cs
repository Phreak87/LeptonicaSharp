using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (98, 1)
// pixSetSelectCmap(pixs, box, sindex, rval, gval, bval) as int
// pixSetSelectCmap(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) It sets all pixels in region that have the color specified
/// by the colormap index 'sindex' to the new color.<para/>
/// 
/// (3) sindex must be in the existing colormap otherwise an
/// error is returned.<para/>
/// 
/// (4) If the new color exists in the colormap, it is used
/// otherwise, it is added to the colormap.  If it cannot be
/// added because the colormap is full, an error is returned.<para/>
/// 
/// (5) If box is NULL, applies function to the entire image otherwise,
/// clips the operation to the intersection of the box and pix.<para/>
/// 
/// (6) An example of use would be to set to a specific color all
/// the light (background) pixels within a certain region of
/// a 3-level 2 bpp image, while leaving light pixels outside
/// this region unchanged.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetSelectCmap/*"/>
///  <param name="pixs">[in] - 1, 2, 4 or 8 bpp, with colormap</param>
///  <param name="box">[in][optional] - region to set color can be NULL</param>
///  <param name="sindex">[in] - colormap index of pixels to be changed</param>
///  <param name="rval">[in] - new color to paint</param>
///  <param name="gval">[in] - new color to paint</param>
///  <param name="bval">[in] - new color to paint</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetSelectCmap(
				 Pix pixs, 
				 Box box, 
				 int sindex, 
				 int rval, 
				 int gval, 
				 int bval){


	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixSetSelectCmap(
pixs.Pointer, boxPtr,   sindex,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (219, 1)
// pixColorGrayRegionsCmap(pixs, boxa, type, rval, gval, bval) as int
// pixColorGrayRegionsCmap(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
/// preserving antialiasing.
/// If type == L_PAINT_DARK, it colorizes non-white pixels,
/// preserving antialiasing.  See pixColorGrayCmap() for details.<para/>
/// 
/// (3) This can also be called through pixColorGrayRegions().<para/>
/// 
/// (4) This increases the colormap size by the number of
/// different gray (non-black or non-white) colors in the
/// selected regions of pixs.  If there is not enough room in
/// the colormap for this expansion, it returns 1 (error),
/// and the caller should check the return value.<para/>
/// 
/// (5) Because two boxes in the boxa can overlap, pixels that
/// are colorized in the first box must be excluded in the
/// second because their value exceeds the size of the map.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGrayRegionsCmap/*"/>
///  <param name="pixs">[in] - 8 bpp, with colormap</param>
///  <param name="boxa">[in] - of regions in which to apply color</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="rval">[in] - target color</param>
///  <param name="gval">[in] - target color</param>
///  <param name="bval">[in] - target color</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixColorGrayRegionsCmap(
				 Pix pixs, 
				 Boxa boxa, 
				 int type, 
				 int rval, 
				 int gval, 
				 int bval){



	int _Result = Natives.pixColorGrayRegionsCmap(
pixs.Pointer, boxa.Pointer,   type,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (327, 1)
// pixColorGrayCmap(pixs, box, type, rval, gval, bval) as int
// pixColorGrayCmap(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
/// preserving antialiasing.
/// If type == L_PAINT_DARK, it colorizes non-white pixels,
/// preserving antialiasing.<para/>
/// 
/// (3) box gives the region to apply color if NULL, this
/// colorizes the entire image.<para/>
/// 
/// (4) If the cmap is only 2 or 4 bpp, pixs is converted in-place
/// to an 8 bpp cmap.  A 1 bpp cmap is not a valid input pix.<para/>
/// 
/// (5) This can also be called through pixColorGray().<para/>
/// 
/// (6) This operation increases the colormap size by the number of
/// different gray (non-black or non-white) colors in the
/// input colormap.  If there is not enough room in the colormap
/// for this expansion, it returns 1 (error), and the caller
/// should check the return value.<para/>
/// 
/// (7) Using the darkness of each original pixel in the rect,
/// it generates a new color (based on the input rgb values).
/// If type == L_PAINT_LIGHT, the new color is a (generally)
/// darken-to-black version of the  input rgb color, where the
/// amount of darkening increases with the darkness of the
/// original pixel color.
/// If type == L_PAINT_DARK, the new color is a (generally)
/// faded-to-white version of the  input rgb color, where the
/// amount of fading increases with the brightness of the
/// original pixel color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGrayCmap/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
///  <param name="box">[in][optional] - region to set color can be NULL</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="rval">[in] - target color</param>
///  <param name="gval">[in] - target color</param>
///  <param name="bval">[in] - target color</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixColorGrayCmap(
				 Pix pixs, 
				 Box box, 
				 int type, 
				 int rval, 
				 int gval, 
				 int bval){


	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixColorGrayCmap(
pixs.Pointer, boxPtr,   type,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (395, 1)
// pixColorGrayMaskedCmap(pixs, pixm, type, rval, gval, bval) as int
// pixColorGrayMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
/// preserving antialiasing.
/// If type == L_PAINT_DARK, it colorizes non-white pixels,
/// preserving antialiasing.  See pixColorGrayCmap() for details.<para/>
/// 
/// (3) This increases the colormap size by the number of
/// different gray (non-black or non-white) colors in the
/// input colormap.  If there is not enough room in the colormap
/// for this expansion, it returns 1 (error).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorGrayMaskedCmap/*"/>
///  <param name="pixs">[in] - 8 bpp, with colormap</param>
///  <param name="pixm">[in] - 1 bpp mask, through which to apply color</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="rval">[in] - target color</param>
///  <param name="gval">[in] - target color</param>
///  <param name="bval">[in] - target color</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixColorGrayMaskedCmap(
				 Pix pixs, 
				 Pix pixm, 
				 int type, 
				 int rval, 
				 int gval, 
				 int bval){



	int _Result = Natives.pixColorGrayMaskedCmap(
pixs.Pointer, pixm.Pointer,   type,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (492, 1)
// addColorizedGrayToCmap(cmap, type, rval, gval, bval, pna) as int
// addColorizedGrayToCmap(PIXCMAP *, l_int32, l_int32, l_int32, l_int32, NUMA **) as l_ok
///  <summary>
/// (1) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
/// preserving antialiasing.
/// If type == L_PAINT_DARK, it colorizes non-white pixels,
/// preserving antialiasing.<para/>
/// 
/// (2) This increases the colormap size by the number of
/// different gray (non-black or non-white) colors in the
/// input colormap.  If there is not enough room in the colormap
/// for this expansion, it returns 1 (treated as a warning)
/// the caller should check the return value.<para/>
/// 
/// (3) This can be used to determine if the new colors will fit in
/// the cmap, using null for [and]na.  Returns 0 if they fit 2 if
/// they don't fit.<para/>
/// 
/// (4) The mapping table contains, for each gray color found, the
/// index of the corresponding colorized pixel.  Non-gray
/// pixels are assigned the invalid index 256.<para/>
/// 
/// (5) See pixColorGrayCmap() for usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/addColorizedGrayToCmap/*"/>
///  <param name="cmap">[in] - from 2 or 4 bpp pix</param>
///  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
///  <param name="rval">[in] - target color</param>
///  <param name="gval">[in] - target color</param>
///  <param name="bval">[in] - target color</param>
///  <param name="pna">[out][optional] - table for mapping new cmap entries</param>
///   <returns>0 if OK 1 on error 2 if new colors will not fit in cmap.</returns>

public static int addColorizedGrayToCmap(
				 PixColormap cmap, 
				 int type, 
				 int rval, 
				 int gval, 
				 int bval, 
				out Numa pna){


	IntPtr pnaPtr = IntPtr.Zero;

	int _Result = Natives.addColorizedGrayToCmap(
cmap.Pointer,   type,   rval,   gval,   bval, out pnaPtr);
	


//  
	if (pnaPtr == IntPtr.Zero) {pna = null;} else { pna = new Numa(pnaPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (583, 1)
// pixSetSelectMaskedCmap(pixs, pixm, x, y, sindex, rval, gval, bval) as int
// pixSetSelectMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) This paints through the fg of pixm and replaces all pixels
/// in pixs that have a particular value (sindex) with the new color.<para/>
/// 
/// (3) If pixm == NULL, a warning is given.<para/>
/// 
/// (4) sindex must be in the existing colormap otherwise an
/// error is returned.<para/>
/// 
/// (5) If the new color exists in the colormap, it is used
/// otherwise, it is added to the colormap.  If the colormap
/// is full, an error is returned.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetSelectMaskedCmap/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
///  <param name="pixm">[in][optional] - 1 bpp mask no-op if NULL</param>
///  <param name="x">[in] - UL corner of mask relative to pixs</param>
///  <param name="y">[in] - UL corner of mask relative to pixs</param>
///  <param name="sindex">[in] - colormap index of pixels in pixs to be changed</param>
///  <param name="rval">[in] - new color to substitute</param>
///  <param name="gval">[in] - new color to substitute</param>
///  <param name="bval">[in] - new color to substitute</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetSelectMaskedCmap(
				 Pix pixs, 
				 Pix pixm, 
				 int x, 
				 int y, 
				 int sindex, 
				 int rval, 
				 int gval, 
				 int bval){


	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixSetSelectMaskedCmap(
pixs.Pointer, pixmPtr,   x,   y,   sindex,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// paintcmap.c (693, 1)
// pixSetMaskedCmap(pixs, pixm, x, y, rval, gval, bval) as int
// pixSetMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation.<para/>
/// 
/// (2) It paints a single color through the mask (as a stencil).<para/>
/// 
/// (3) The mask origin is placed at (x,y) on pixs, and the
/// operation is clipped to the intersection of the mask and pixs.<para/>
/// 
/// (4) If pixm == NULL, a warning is given.<para/>
/// 
/// (5) Typically, pixm is a small binary mask located somewhere
/// on the larger pixs.<para/>
/// 
/// (6) If the color is in the colormap, it is used.  Otherwise,
/// it is added if possible an error is returned if the
/// colormap is already full.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetMaskedCmap/*"/>
///  <param name="pixs">[in] - 2, 4 or 8 bpp, colormapped</param>
///  <param name="pixm">[in][optional] - 1 bpp mask no-op if NULL</param>
///  <param name="x">[in] - origin of pixm relative to pixs can be negative</param>
///  <param name="y">[in] - origin of pixm relative to pixs can be negative</param>
///  <param name="rval">[in] - new color to set at each masked pixel</param>
///  <param name="gval">[in] - new color to set at each masked pixel</param>
///  <param name="bval">[in] - new color to set at each masked pixel</param>
///   <returns>0 if OK 1 on error</returns>

public static int pixSetMaskedCmap(
				 Pix pixs, 
				 Pix pixm, 
				 int x, 
				 int y, 
				 int rval, 
				 int gval, 
				 int bval){


	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixSetMaskedCmap(
pixs.Pointer, pixmPtr,   x,   y,   rval,   gval,   bval);
	


//  



	return _Result;
}


}
}
