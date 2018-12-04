using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (92, 1)
// pixQuadtreeMean(pixs, nlevels, pix_ma, pfpixa) as int
// pixQuadtreeMean(PIX *, l_int32, PIX *, FPIXA **) as l_ok
///  <summary>
/// (1) The returned fpixa has %nlevels of fpix, each containing
/// the mean values at its level.  Level 0 has a
/// single value level 1 has 4 values level 2 has 16 etc.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixQuadtreeMean/*"/>
///  <param name="pixs">[in] - 8 bpp, no colormap</param>
///  <param name="nlevels">[in] - in quadtree max allowed depends on image size</param>
///  <param name="pix_ma">[in] - input mean accumulator can be null</param>
///  <param name="pfpixa">[out] - mean values in quadtree</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixQuadtreeMean(
				 Pix pixs, 
				 int nlevels, 
				 Pix pix_ma, 
				out FPixa pfpixa){


	IntPtr pfpixaPtr = IntPtr.Zero;

	int _Result = Natives.pixQuadtreeMean(
pixs.Pointer,   nlevels, pix_ma.Pointer, out pfpixaPtr);
	


//  
	if (pfpixaPtr == IntPtr.Zero) {pfpixa = null;} else { pfpixa = new FPixa(pfpixaPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (169, 1)
// pixQuadtreeVariance(pixs, nlevels, pix_ma, dpix_msa, pfpixa_v, pfpixa_rv) as int
// pixQuadtreeVariance(PIX *, l_int32, PIX *, DPIX *, FPIXA **, FPIXA **) as l_ok
///  <summary>
/// (1) The returned fpixav and fpixarv have %nlevels of fpix,
/// each containing at the respective levels the variance
/// and root variance values.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixQuadtreeVariance/*"/>
///  <param name="pixs">[in] - 8 bpp, no colormap</param>
///  <param name="nlevels">[in] - in quadtree</param>
///  <param name="pix_ma">[in] - input mean accumulator can be null</param>
///  <param name="dpix_msa">[in] - input mean square accumulator can be null</param>
///  <param name="pfpixa_v">[out][optional] - variance values in quadtree</param>
///  <param name="pfpixa_rv">[out][optional] - root variance values in quadtree</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixQuadtreeVariance(
				 Pix pixs, 
				 int nlevels, 
				 Pix pix_ma, 
				 DPix dpix_msa, 
				out FPixa pfpixa_v, 
				out FPixa pfpixa_rv){


	IntPtr pfpixa_vPtr = IntPtr.Zero;
	IntPtr pfpixa_rvPtr = IntPtr.Zero;

	int _Result = Natives.pixQuadtreeVariance(
pixs.Pointer,   nlevels, pix_ma.Pointer, dpix_msa.Pointer, out pfpixa_vPtr, out pfpixa_rvPtr);
	


//  
	if (pfpixa_vPtr == IntPtr.Zero) {pfpixa_v = null;} else { pfpixa_v = new FPixa(pfpixa_vPtr); };
	if (pfpixa_rvPtr == IntPtr.Zero) {pfpixa_rv = null;} else { pfpixa_rv = new FPixa(pfpixa_rvPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (265, 1)
// pixMeanInRectangle(pixs, box, pixma, pval) as int
// pixMeanInRectangle(PIX *, BOX *, PIX *, l_float32 *) as l_ok
///  <summary>
/// (1) This function is intended to be used for many rectangles
/// on the same image.  It can find the mean within a
/// rectangle in O(1), independent of the size of the rectangle.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMeanInRectangle/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="box">[in] - region to compute mean value</param>
///  <param name="pixma">[in] - mean accumulator</param>
///  <param name="pval">[out] - mean value</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixMeanInRectangle(
				 Pix pixs, 
				 Box box, 
				 Pix pixma, 
				out Single pval){



	int _Result = Natives.pixMeanInRectangle(
pixs.Pointer, box.Pointer, pixma.Pointer, out  pval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (341, 1)
// pixVarianceInRectangle(pixs, box, pix_ma, dpix_msa, pvar, prvar) as int
// pixVarianceInRectangle(PIX *, BOX *, PIX *, DPIX *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// (1) This function is intended to be used for many rectangles
/// on the same image.  It can find the variance and/or the
/// square root of the variance within a rectangle in O(1),
/// independent of the size of the rectangle.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixVarianceInRectangle/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="box">[in] - region to compute variance and/or root variance</param>
///  <param name="pix_ma">[in] - mean accumulator</param>
///  <param name="dpix_msa">[in] - mean square accumulator</param>
///  <param name="pvar">[out][optional] - variance</param>
///  <param name="prvar">[out][optional] - root variance</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixVarianceInRectangle(
				 Pix pixs, 
				 Box box, 
				 Pix pix_ma, 
				 DPix dpix_msa, 
				out Single pvar, 
				out Single prvar){



	int _Result = Natives.pixVarianceInRectangle(
pixs.Pointer, box.Pointer, pix_ma.Pointer, dpix_msa.Pointer, out  pvar, out  prvar);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (449, 1)
// boxaaQuadtreeRegions(w, h, nlevels) as Boxaa
// boxaaQuadtreeRegions(l_int32, l_int32, l_int32) as BOXAA *
///  <summary>
/// (1) The returned boxaa has %nlevels of boxa, each containing
/// the set of rectangles at that level.  The rectangle at
/// level 0 is the entire region at level 1 the region is
/// divided into 4 rectangles, and at level n there are n^4
/// rectangles.<para/>
/// 
/// (2) At each level, the rectangles in the boxa are in "raster"
/// order, with LR (fast scan) and TB (slow scan).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaQuadtreeRegions/*"/>
///  <param name="w">[in] - size of pix that is being quadtree-ized</param>
///  <param name="h">[in] - size of pix that is being quadtree-ized</param>
///  <param name="nlevels">[in] - number of levels in quadtree</param>
///   <returns>baa for quadtree regions at each level, or NULL on error</returns>

public static Boxaa boxaaQuadtreeRegions(
				 int w, 
				 int h, 
				 int nlevels){



	IntPtr _Result = Natives.boxaaQuadtreeRegions(
  w,   h,   nlevels);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Boxaa(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (530, 1)
// quadtreeGetParent(fpixa, level, x, y, pval) as int
// quadtreeGetParent(FPIXA *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
///  <summary>
/// (1) Check return value for error.  On error, val is returned as 0.0.<para/>
/// 
/// (2) The parent is located at:
/// level - 1
/// (x/2, y/2)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/quadtreeGetParent/*"/>
///  <param name="fpixa">[in] - mean, variance or root variance</param>
///  <param name="level">[in] - x, y of current pixel</param>
///  <param name="pval">[out] - parent pixel value, or 0.0 on error</param>
///   <returns>0 if OK, 1 on error</returns>

public static int quadtreeGetParent(
				 FPixa fpixa, 
				 int level, 
				 int x, 
				 int y, 
				out Single pval){



	int _Result = Natives.quadtreeGetParent(
fpixa.Pointer,   level,   x,   y, out  pval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (573, 1)
// quadtreeGetChildren(fpixa, level, x, y, pval00, pval10, pval01, pval11) as int
// quadtreeGetChildren(FPIXA *, l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// (1) Check return value for error.  On error, all return vals are 0.0.<para/>
/// 
/// (2) The returned child pixels are located at:
/// level + 1
/// (2x, 2y), (2x+1, 2y), (2x, 2y+1), (2x+1, 2y+1)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/quadtreeGetChildren/*"/>
///  <param name="fpixa">[in] - mean, variance or root variance</param>
///  <param name="level">[in] - x, y of current pixel</param>
///  <param name="pval00">[out] - four child pixel values</param>
///  <param name="pval10">[out] - four child pixel values</param>
///  <param name="pval01">[out] - four child pixel values</param>
///  <param name="pval11">[out] - four child pixel values</param>
///   <returns>0 if OK, 1 on error</returns>

public static int quadtreeGetChildren(
				 FPixa fpixa, 
				 int level, 
				 int x, 
				 int y, 
				out Single pval00, 
				out Single pval10, 
				out Single pval01, 
				out Single pval11){



	int _Result = Natives.quadtreeGetChildren(
fpixa.Pointer,   level,   x,   y, out  pval00, out  pval10, out  pval01, out  pval11);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (619, 1)
// quadtreeMaxLevels(w, h) as int
// quadtreeMaxLevels(l_int32, l_int32) as l_int32
///  <summary>
/// (1) The criterion for maxlevels is that the subdivision not
/// go down below the single pixel level.  The 1.5 factor
/// is intended to keep any rectangle from accidentally
/// having zero dimension due to integer truncation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/quadtreeMaxLevels/*"/>
///  <param name="w">[in] - dimensions of image</param>
///  <param name="h">[in] - dimensions of image</param>
///   <returns>maxlevels maximum number of levels allowed, or -1 on error</returns>

public static int quadtreeMaxLevels(
				 int w, 
				 int h){



	int _Result = Natives.quadtreeMaxLevels(
  w,   h);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// quadtree.c (654, 1)
// fpixaDisplayQuadtree(fpixa, factor, fontsize) as Pix
// fpixaDisplayQuadtree(FPIXA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The mean and root variance fall naturally in the 8 bpp range,
/// but the variance is typically outside the range.  This
/// function displays 8 bpp pix clipped to 255, so the image
/// pixels will mostly be 255 (white).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaDisplayQuadtree/*"/>
///  <param name="fpixa">[in] - mean, variance or root variance</param>
///  <param name="factor">[in] - replication factor at lowest level</param>
///  <param name="fontsize">[in] - 4, ... 20</param>
///   <returns>pixd 8 bpp, mosaic of quadtree images, or NULL on error</returns>

public static Pix fpixaDisplayQuadtree(
				 FPixa fpixa, 
				 int factor, 
				 int fontsize){



	IntPtr _Result = Natives.fpixaDisplayQuadtree(
fpixa.Pointer,   factor,   fontsize);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}


}
}
