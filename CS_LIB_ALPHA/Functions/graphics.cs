using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (138, 1)
// generatePtaLine(x1, y1, x2, y2) as Pta
// generatePtaLine(l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) Uses Bresenham line drawing, which results in an 8-connected line.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaLine/*"/>
///  <param name="x1">[in] - end point 1</param>
///  <param name="y1">[in] - end point 1</param>
///  <param name="x2">[in] - end point 2</param>
///  <param name="y2">[in] - end point 2</param>
///   <returns>pta, or NULL on error</returns>

public static Pta generatePtaLine(
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2){



	IntPtr _Result = Natives.generatePtaLine(
  x1,   y1,   x2,   y2);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (203, 1)
// generatePtaWideLine(x1, y1, x2, y2, width) as Pta
// generatePtaWideLine(l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaWideLine/*"/>
///  <param name="x1">[in] - end point 1</param>
///  <param name="y1">[in] - end point 1</param>
///  <param name="x2">[in] - end point 2</param>
///  <param name="y2">[in] - end point 2</param>
///  <param name="width">[in] - </param>
///   <returns>ptaj, or NULL on error</returns>

public static Pta generatePtaWideLine(
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2, 
				 int width){



	IntPtr _Result = Natives.generatePtaWideLine(
  x1,   y1,   x2,   y2,   width);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (273, 1)
// generatePtaBox(box, width) as Pta
// generatePtaBox(BOX *, l_int32) as PTA *
///  <summary>
/// (1) Because the box is constructed so that we don't have any
/// overlapping lines, there is no need to remove duplicates.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaBox/*"/>
///  <param name="box">[in] - </param>
///  <param name="width">[in] - of line</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaBox(
				 Box box, 
				 int width){



	IntPtr _Result = Natives.generatePtaBox(
box.Pointer,   width);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (350, 1)
// generatePtaBoxa(boxa, width, removedups) as Pta
// generatePtaBoxa(BOXA *, l_int32, l_int32) as PTA *
///  <summary>
/// (1) If the boxa has overlapping boxes, and if blending will
/// be used to give a transparent effect, transparency
/// artifacts at line intersections can be removed using
/// removedups = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaBoxa/*"/>
///  <param name="boxa">[in] - </param>
///  <param name="width">[in] - </param>
///  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaBoxa(
				 Boxa boxa, 
				 int width, 
				 int removedups){



	IntPtr _Result = Natives.generatePtaBoxa(
boxa.Pointer,   width,   removedups);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (405, 1)
// generatePtaHashBox(box, spacing, width, orient, outline) as Pta
// generatePtaHashBox(BOX *, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) The orientation takes on one of 4 orientations (horiz, vertical,
/// slope +1, slope -1).<para/>
/// 
/// (2) The full outline is also drawn if %outline = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaHashBox/*"/>
///  <param name="box">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - of line</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaHashBox(
				 Box box, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline){



	IntPtr _Result = Natives.generatePtaHashBox(
box.Pointer,   spacing,   width,   orient,   outline);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (505, 1)
// generatePtaHashBoxa(boxa, spacing, width, orient, outline, removedups) as Pta
// generatePtaHashBoxa(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) The orientation takes on one of 4 orientations (horiz, vertical,
/// slope +1, slope -1).<para/>
/// 
/// (2) The full outline is also drawn if %outline = 1.<para/>
/// 
/// (3) If the boxa has overlapping boxes, and if blending will
/// be used to give a transparent effect, transparency
/// artifacts at line intersections can be removed using
/// removedups = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaHashBoxa/*"/>
///  <param name="boxa">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - of line</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaHashBoxa(
				 Boxa boxa, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int removedups){



	IntPtr _Result = Natives.generatePtaHashBoxa(
boxa.Pointer,   spacing,   width,   orient,   outline,   removedups);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (565, 1)
// generatePtaaBoxa(boxa) as Ptaa
// generatePtaaBoxa(BOXA *) as PTAA *
///  <summary>
/// (1) This generates a pta of the four corners for each box in
/// the boxa.<para/>
/// 
/// (2) Each of these pta can be rendered onto a pix with random colors,
/// by using pixRenderRandomCmapPtaa() with closeflag = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaaBoxa/*"/>
///  <param name="boxa">[in] - </param>
///   <returns>ptaa, or NULL on error</returns>

public static Ptaa generatePtaaBoxa(
				 Boxa boxa){



	IntPtr _Result = Natives.generatePtaaBoxa(
boxa.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Ptaa(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (616, 1)
// generatePtaaHashBoxa(boxa, spacing, width, orient, outline) as Ptaa
// generatePtaaHashBoxa(BOXA *, l_int32, l_int32, l_int32, l_int32) as PTAA *
///  <summary>
/// (1) The orientation takes on one of 4 orientations (horiz, vertical,
/// slope +1, slope -1).<para/>
/// 
/// (2) The full outline is also drawn if %outline = 1.<para/>
/// 
/// (3) Each of these pta can be rendered onto a pix with random colors,
/// by using pixRenderRandomCmapPtaa() with closeflag = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaaHashBoxa/*"/>
///  <param name="boxa">[in] - </param>
///  <param name="spacing">[in] - spacing between hash lines must be  is greater  1</param>
///  <param name="width">[in] - hash line width</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///   <returns>ptaa, or NULL on error</returns>

public static Ptaa generatePtaaHashBoxa(
				 Boxa boxa, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline){



	IntPtr _Result = Natives.generatePtaaHashBoxa(
boxa.Pointer,   spacing,   width,   orient,   outline);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Ptaa(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (664, 1)
// generatePtaPolyline(ptas, width, closeflag, removedups) as Pta
// generatePtaPolyline(PTA *, l_int32, l_int32, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaPolyline/*"/>
///  <param name="ptas">[in] - vertices of polyline</param>
///  <param name="width">[in] - </param>
///  <param name="closeflag">[in] - 1 to close the contour 0 otherwise</param>
///  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaPolyline(
				 Pta ptas, 
				 int width, 
				 int closeflag, 
				 int removedups){



	IntPtr _Result = Natives.generatePtaPolyline(
ptas.Pointer,   width,   closeflag,   removedups);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (722, 1)
// generatePtaGrid(w, h, nx, ny, width) as Pta
// generatePtaGrid(l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaGrid/*"/>
///  <param name="w">[in] - of region where grid will be displayed</param>
///  <param name="h">[in] - of region where grid will be displayed</param>
///  <param name="nx">[in] - number of rectangles in each direction in grid</param>
///  <param name="ny">[in] - number of rectangles in each direction in grid</param>
///  <param name="width">[in] - of rendered lines</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta generatePtaGrid(
				 int w, 
				 int h, 
				 int nx, 
				 int ny, 
				 int width){



	IntPtr _Result = Natives.generatePtaGrid(
  w,   h,   nx,   ny,   width);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (780, 1)
// convertPtaLineTo4cc(ptas) as Pta
// convertPtaLineTo4cc(PTA *) as PTA *
///  <summary>
/// (1) When a polyline is generated with width = 1, the resulting
/// line is not 4-connected in general.  This function adds
/// points as necessary to convert the line to 4-cconnected.
/// It is useful when rendering 1 bpp on a pix.<para/>
/// 
/// (2) Do not use this for lines generated with width  is greater  1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertPtaLineTo4cc/*"/>
///  <param name="ptas">[in] - 8-connected line of points</param>
///   <returns>ptad 4-connected line, or NULL on error</returns>

public static Pta convertPtaLineTo4cc(
				 Pta ptas){



	IntPtr _Result = Natives.convertPtaLineTo4cc(
ptas.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (823, 1)
// generatePtaFilledCircle(radius) as Pta
// generatePtaFilledCircle(l_int32) as PTA *
///  <summary>
/// (1) The circle is has diameter = 2  radius + 1.<para/>
/// 
/// (2) It is located with the center of the circle at the
/// point (radius, radius).<para/>
/// 
/// (3) Consequently, it typically must be translated if
/// it is to represent a set of pixels in an image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaFilledCircle/*"/>
///  <param name="radius">[in] - </param>
///   <returns>pta, or NULL on error</returns>

public static Pta generatePtaFilledCircle(
				 int radius){



	IntPtr _Result = Natives.generatePtaFilledCircle(
  radius);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (863, 1)
// generatePtaFilledSquare(side) as Pta
// generatePtaFilledSquare(l_int32) as PTA *
///  <summary>
/// (1) The center of the square can be chosen to be at
/// (side / 2, side / 2).  It must be translated by this amount
/// when used for replication.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaFilledSquare/*"/>
///  <param name="side">[in] - </param>
///   <returns>pta, or NULL on error</returns>

public static Pta generatePtaFilledSquare(
				 int side){



	IntPtr _Result = Natives.generatePtaFilledSquare(
  side);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (897, 1)
// generatePtaLineFromPt(x, y, length, radang) as Pta
// generatePtaLineFromPt(l_int32, l_int32, l_float64, l_float64) as PTA *
///  <summary>
/// (1) The %length of the line is 1 greater than the distance
/// used in locatePtRadially().  Example: a distance of 1
/// gives rise to a length of 2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generatePtaLineFromPt/*"/>
///  <param name="x">[in] - point of origination</param>
///  <param name="y">[in] - point of origination</param>
///  <param name="length">[in] - of line, including starting point</param>
///  <param name="radang">[in] - angle in radians, CW from horizontal</param>
///   <returns>pta, or NULL on error</returns>

public static Pta generatePtaLineFromPt(
				 int x, 
				 int y, 
				 double length, 
				 double radang){



	IntPtr _Result = Natives.generatePtaLineFromPt(
  x,   y,   length,   radang);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (921, 1)
// locatePtRadially(xr, yr, dist, radang, px, py) as int
// locatePtRadially(l_int32, l_int32, l_float64, l_float64, l_float64 *, l_float64 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/locatePtRadially/*"/>
///  <param name="xr">[in] - reference point</param>
///  <param name="yr">[in] - reference point</param>
///  <param name="dist">[in] - distance of point from reference point along line given by the specified angle</param>
///  <param name="radang">[in] - angle in radians, CW from horizontal</param>
///  <param name="px">[out] - location of point</param>
///  <param name="py">[out] - location of point</param>
///   <returns>0 if OK, 1 on error</returns>

public static int locatePtRadially(
				 int xr, 
				 int yr, 
				 double dist, 
				 double radang, 
				out Double[] px, 
				out Double[] py){



	int _Result = Natives.locatePtRadially(
  xr,   yr,   dist,   radang, out  px, out  py);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (963, 1)
// pixRenderPlotFromNuma(ppix, na, plotloc, linewidth, max, color) as int
// pixRenderPlotFromNuma(PIX **, NUMA *, l_int32, l_int32, l_int32, l_uint32) as l_ok
///  <summary>
/// (1) Simplified interface for plotting row or column aligned data
/// on a pix.<para/>
/// 
/// (2) This replaces %pix with a 32 bpp rgb version if it is not
/// already 32 bpp.  It then draws the plot on the pix.<para/>
/// 
/// (3) See makePlotPtaFromNumaGen() for more details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPlotFromNuma/*"/>
///  <param name="ppix">[in,out] - any type replaced if not 32 bpp rgb</param>
///  <param name="na">[in] - to be plotted</param>
///  <param name="plotloc">[in] - location of plot: L_PLOT_AT_TOP, etc</param>
///  <param name="linewidth">[in] - width of "line" that is drawn between 1 and 7</param>
///  <param name="max">[in] - maximum excursion in pixels from baseline</param>
///  <param name="color">[in] - plot color: 0xrrggbb00</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPlotFromNuma(
				ref Pix ppix, 
				 Numa na, 
				 int plotloc, 
				 int linewidth, 
				 int max, 
				 uint color){


	IntPtr ppixPtr = IntPtr.Zero; 	if (ppix != null) {ppixPtr = ppix.Pointer;}

	int _Result = Natives.pixRenderPlotFromNuma(
ref ppixPtr, na.Pointer,   plotloc,   linewidth,   max,   color);
	


//  
	if (ppixPtr == IntPtr.Zero) {ppix = null;} else { ppix = new Pix(ppixPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1021, 1)
// makePlotPtaFromNuma(na, size, plotloc, linewidth, max) as Pta
// makePlotPtaFromNuma(NUMA *, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) This generates points from %numa representing y(x) or x(y)
/// with respect to a pix.  A horizontal plot y(x) is drawn for
/// a function of column position, and a vertical plot is drawn
/// for a function x(y) of row position.  The baseline is located
/// so that all plot points will fit in the pix.<para/>
/// 
/// (2) See makePlotPtaFromNumaGen() for more details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makePlotPtaFromNuma/*"/>
///  <param name="na">[in] - </param>
///  <param name="size">[in] - pix height for horizontal plot width for vertical plot</param>
///  <param name="plotloc">[in] - location of plot: L_PLOT_AT_TOP, etc</param>
///  <param name="linewidth">[in] - width of "line" that is drawn between 1 and 7</param>
///  <param name="max">[in] - maximum excursion in pixels from baseline</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta makePlotPtaFromNuma(
				 Numa na, 
				 int size, 
				 int plotloc, 
				 int linewidth, 
				 int max){



	IntPtr _Result = Natives.makePlotPtaFromNuma(
na.Pointer,   size,   plotloc,   linewidth,   max);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1077, 1)
// pixRenderPlotFromNumaGen(ppix, na, orient, linewidth, refpos, max, drawref, color) as int
// pixRenderPlotFromNumaGen(PIX **, NUMA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint32) as l_ok
///  <summary>
/// (1) General interface for plotting row or column aligned data
/// on a pix.<para/>
/// 
/// (2) This replaces %pix with a 32 bpp rgb version if it is not
/// already 32 bpp.  It then draws the plot on the pix.<para/>
/// 
/// (3) See makePlotPtaFromNumaGen() for other input parameters.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPlotFromNumaGen/*"/>
///  <param name="ppix">[in,out] - any type replaced if not 32 bpp rgb</param>
///  <param name="na">[in] - to be plotted</param>
///  <param name="orient">[in] - L_HORIZONTAL_LINE, L_VERTICAL_LINE</param>
///  <param name="linewidth">[in] - width of "line" that is drawn between 1 and 7</param>
///  <param name="refpos">[in] - reference position: y for horizontal and x for vertical</param>
///  <param name="max">[in] - maximum excursion in pixels from baseline</param>
///  <param name="drawref">[in] - 1 to draw the reference line and the normal to it</param>
///  <param name="color">[in] - plot color: 0xrrggbb00</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPlotFromNumaGen(
				ref Pix ppix, 
				 Numa na, 
				 int orient, 
				 int linewidth, 
				 int refpos, 
				 int max, 
				 int drawref, 
				 uint color){


	IntPtr ppixPtr = IntPtr.Zero; 	if (ppix != null) {ppixPtr = ppix.Pointer;}

	int _Result = Natives.pixRenderPlotFromNumaGen(
ref ppixPtr, na.Pointer,   orient,   linewidth,   refpos,   max,   drawref,   color);
	


//  
	if (ppixPtr == IntPtr.Zero) {ppix = null;} else { ppix = new Pix(ppixPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1142, 1)
// makePlotPtaFromNumaGen(na, orient, linewidth, refpos, max, drawref) as Pta
// makePlotPtaFromNumaGen(NUMA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) This generates points from %numa representing y(x) or x(y)
/// with respect to a pix.  For y(x), we draw a horizontal line
/// at the reference position and a vertical line at the edge then
/// we draw the values of %numa, scaled so that the maximum
/// excursion from the reference position is %max pixels.<para/>
/// 
/// (2) The start and delx parameters of %numa are used to refer
/// its values to the raster lines (L_VERTICAL_LINE) or columns
/// (L_HORIZONTAL_LINE).<para/>
/// 
/// (3) The linewidth is chosen in the interval [1 ... 7].<para/>
/// 
/// (4) %refpos should be chosen so the plot is entirely within the pix
/// that it will be painted onto.<para/>
/// 
/// (5) This would typically be used to plot, in place, a function
/// computed along pixel rows or columns.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makePlotPtaFromNumaGen/*"/>
///  <param name="na">[in] - </param>
///  <param name="orient">[in] - L_HORIZONTAL_LINE, L_VERTICAL_LINE</param>
///  <param name="linewidth">[in] - width of "line" that is drawn between 1 and 7</param>
///  <param name="refpos">[in] - reference position: y for horizontal and x for vertical</param>
///  <param name="max">[in] - maximum excursion in pixels from baseline</param>
///  <param name="drawref">[in] - 1 to draw the reference line and the normal to it</param>
///   <returns>ptad, or NULL on error</returns>

public static Pta makePlotPtaFromNumaGen(
				 Numa na, 
				 int orient, 
				 int linewidth, 
				 int refpos, 
				 int max, 
				 int drawref){



	IntPtr _Result = Natives.makePlotPtaFromNumaGen(
na.Pointer,   orient,   linewidth,   refpos,   max,   drawref);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1254, 1)
// pixRenderPta(pix, pta, op) as int
// pixRenderPta(PIX *, PTA *, l_int32) as l_ok
///  <summary>
/// (1) L_SET_PIXELS puts all image bits in each pixel to 1
/// (black for 1 bpp white for depth  is greater  1)<para/>
/// 
/// (2) L_CLEAR_PIXELS puts all image bits in each pixel to 0
/// (white for 1 bpp black for depth  is greater  1)<para/>
/// 
/// (3) L_FLIP_PIXELS reverses all image bits in each pixel<para/>
/// 
/// (4) This function clips the rendering to the pix.  It performs
/// clipping for functions such as pixRenderLine(),
/// pixRenderBox() and pixRenderBoxa(), that call pixRenderPta().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPta/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="pta">[in] - arbitrary set of points</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPta(
				 Pix pix, 
				 Pta pta, 
				 int op){



	int _Result = Natives.pixRenderPta(
pix.Pointer, pta.Pointer,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1343, 1)
// pixRenderPtaArb(pix, pta, rval, gval, bval) as int
// pixRenderPtaArb(PIX *, PTA *, l_uint8, l_uint8, l_uint8) as l_ok
///  <summary>
/// (1) If pix is colormapped, render this color (or the nearest
/// color if the cmap is full) on each pixel.<para/>
/// 
/// (2) The rgb components have the standard dynamic range [0 ... 255]<para/>
/// 
/// (3) If pix is not colormapped, do the best job you can using
/// the input colors:
/// ~ d = 1: set the pixels
/// ~ d = 2, 4, 8: average the input rgb value
/// ~ d = 32: use the input rgb value<para/>
/// 
/// (4) This function clips the rendering to the pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPtaArb/*"/>
///  <param name="pix">[in] - any depth, cmapped ok</param>
///  <param name="pta">[in] - arbitrary set of points</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPtaArb(
				 Pix pix, 
				 Pta pta, 
				 byte rval, 
				 byte gval, 
				 byte bval){



	int _Result = Natives.pixRenderPtaArb(
pix.Pointer, pta.Pointer,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1418, 1)
// pixRenderPtaBlend(pix, pta, rval, gval, bval, fract) as int
// pixRenderPtaBlend(PIX *, PTA *, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
///  <summary>
/// (1) This function clips the rendering to the pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPtaBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="pta">[in] - arbitrary set of points</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPtaBlend(
				 Pix pix, 
				 Pta pta, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 Single fract){



	int _Result = Natives.pixRenderPtaBlend(
pix.Pointer, pta.Pointer,   rval,   gval,   bval,   fract);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1483, 1)
// pixRenderLine(pix, x1, y1, x2, y2, width, op) as int
// pixRenderLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderLine/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="x1">[in] - </param>
///  <param name="y1">[in] - </param>
///  <param name="x2">[in] - </param>
///  <param name="y2">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderLine(
				 Pix pix, 
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2, 
				 int width, 
				 int op){



	int _Result = Natives.pixRenderLine(
pix.Pointer,   x1,   y1,   x2,   y2,   width,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1523, 1)
// pixRenderLineArb(pix, x1, y1, x2, y2, width, rval, gval, bval) as int
// pixRenderLineArb(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderLineArb/*"/>
///  <param name="pix">[in] - any depth, cmapped ok</param>
///  <param name="x1">[in] - </param>
///  <param name="y1">[in] - </param>
///  <param name="x2">[in] - </param>
///  <param name="y2">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderLineArb(
				 Pix pix, 
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval){



	int _Result = Natives.pixRenderLineArb(
pix.Pointer,   x1,   y1,   x2,   y2,   width,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1564, 1)
// pixRenderLineBlend(pix, x1, y1, x2, y2, width, rval, gval, bval, fract) as int
// pixRenderLineBlend(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderLineBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="x1">[in] - </param>
///  <param name="y1">[in] - </param>
///  <param name="x2">[in] - </param>
///  <param name="y2">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderLineBlend(
				 Pix pix, 
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 Single fract){



	int _Result = Natives.pixRenderLineBlend(
pix.Pointer,   x1,   y1,   x2,   y2,   width,   rval,   gval,   bval,   fract);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1604, 1)
// pixRenderBox(pix, box, width, op) as int
// pixRenderBox(PIX *, BOX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBox/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="box">[in] - </param>
///  <param name="width">[in] - thickness of box lines</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBox(
				 Pix pix, 
				 Box box, 
				 int width, 
				 int op){



	int _Result = Natives.pixRenderBox(
pix.Pointer, box.Pointer,   width,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1642, 1)
// pixRenderBoxArb(pix, box, width, rval, gval, bval) as int
// pixRenderBoxArb(PIX *, BOX *, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBoxArb/*"/>
///  <param name="pix">[in] - any depth, cmapped ok</param>
///  <param name="box">[in] - </param>
///  <param name="width">[in] - thickness of box lines</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBoxArb(
				 Pix pix, 
				 Box box, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval){



	int _Result = Natives.pixRenderBoxArb(
pix.Pointer, box.Pointer,   width,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1682, 1)
// pixRenderBoxBlend(pix, box, width, rval, gval, bval, fract) as int
// pixRenderBoxBlend(PIX *, BOX *, l_int32, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBoxBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="box">[in] - </param>
///  <param name="width">[in] - thickness of box lines</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - in [0.0 - 1.0] complete transparency (no effect if 0.0 no transparency if 1.0)</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBoxBlend(
				 Pix pix, 
				 Box box, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 Single fract){



	int _Result = Natives.pixRenderBoxBlend(
pix.Pointer, box.Pointer,   width,   rval,   gval,   bval,   fract);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1721, 1)
// pixRenderBoxa(pix, boxa, width, op) as int
// pixRenderBoxa(PIX *, BOXA *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBoxa/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="boxa">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBoxa(
				 Pix pix, 
				 Boxa boxa, 
				 int width, 
				 int op){



	int _Result = Natives.pixRenderBoxa(
pix.Pointer, boxa.Pointer,   width,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1759, 1)
// pixRenderBoxaArb(pix, boxa, width, rval, gval, bval) as int
// pixRenderBoxaArb(PIX *, BOXA *, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBoxaArb/*"/>
///  <param name="pix">[in] - any depth colormapped is ok</param>
///  <param name="boxa">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBoxaArb(
				 Pix pix, 
				 Boxa boxa, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval){



	int _Result = Natives.pixRenderBoxaArb(
pix.Pointer, boxa.Pointer,   width,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1800, 1)
// pixRenderBoxaBlend(pix, boxa, width, rval, gval, bval, fract, removedups) as int
// pixRenderBoxaBlend(PIX *, BOXA *, l_int32, l_uint8, l_uint8, l_uint8, l_float32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderBoxaBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="boxa">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - in [0.0 - 1.0] complete transparency (no effect if 0.0 no transparency if 1.0)</param>
///  <param name="removedups">[in] - 1 to remove 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderBoxaBlend(
				 Pix pix, 
				 Boxa boxa, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 Single fract, 
				 int removedups){



	int _Result = Natives.pixRenderBoxaBlend(
pix.Pointer, boxa.Pointer,   width,   rval,   gval,   bval,   fract,   removedups);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1843, 1)
// pixRenderHashBox(pix, box, spacing, width, orient, outline, op) as int
// pixRenderHashBox(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBox/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="box">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBox(
				 Pix pix, 
				 Box box, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int op){



	int _Result = Natives.pixRenderHashBox(
pix.Pointer, box.Pointer,   spacing,   width,   orient,   outline,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1893, 1)
// pixRenderHashBoxArb(pix, box, spacing, width, orient, outline, rval, gval, bval) as int
// pixRenderHashBoxArb(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBoxArb/*"/>
///  <param name="pix">[in] - any depth cmapped ok</param>
///  <param name="box">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBoxArb(
				 Pix pix, 
				 Box box, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int rval, 
				 int gval, 
				 int bval){



	int _Result = Natives.pixRenderHashBoxArb(
pix.Pointer, box.Pointer,   spacing,   width,   orient,   outline,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (1945, 1)
// pixRenderHashBoxBlend(pix, box, spacing, width, orient, outline, rval, gval, bval, fract) as int
// pixRenderHashBoxBlend(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBoxBlend/*"/>
///  <param name="pix">[in] - 32 bpp</param>
///  <param name="box">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - in [0.0 - 1.0] complete transparency (no effect if 0.0 no transparency if 1.0)</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBoxBlend(
				 Pix pix, 
				 Box box, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int rval, 
				 int gval, 
				 int bval, 
				 Single fract){



	int _Result = Natives.pixRenderHashBoxBlend(
pix.Pointer, box.Pointer,   spacing,   width,   orient,   outline,   rval,   gval,   bval,   fract);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2003, 1)
// pixRenderHashMaskArb(pix, pixm, x, y, spacing, width, orient, outline, rval, gval, bval) as int
// pixRenderHashMaskArb(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation that renders hash lines
/// through a mask %pixm onto %pix.  The mask origin is
/// translated by (%x,%y) relative to the origin of %pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashMaskArb/*"/>
///  <param name="pix">[in] - any depth cmapped ok</param>
///  <param name="pixm">[in] - 1 bpp clipping mask for hash marks</param>
///  <param name="x">[in] - ,y   UL corner of %pixm with respect to %pix</param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashMaskArb(
				 Pix pix, 
				 Pix pixm, 
				 int x, 
				 int y, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int rval, 
				 int gval, 
				 int bval){



	int _Result = Natives.pixRenderHashMaskArb(
pix.Pointer, pixm.Pointer,   x,   y,   spacing,   width,   orient,   outline,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2071, 1)
// pixRenderHashBoxa(pix, boxa, spacing, width, orient, outline, op) as int
// pixRenderHashBoxa(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBoxa/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="boxa">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBoxa(
				 Pix pix, 
				 Boxa boxa, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int op){



	int _Result = Natives.pixRenderHashBoxa(
pix.Pointer, boxa.Pointer,   spacing,   width,   orient,   outline,   op);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2121, 1)
// pixRenderHashBoxaArb(pix, boxa, spacing, width, orient, outline, rval, gval, bval) as int
// pixRenderHashBoxaArb(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBoxaArb/*"/>
///  <param name="pix">[in] - any depth cmapped ok</param>
///  <param name="boxa">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBoxaArb(
				 Pix pix, 
				 Boxa boxa, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int rval, 
				 int gval, 
				 int bval){



	int _Result = Natives.pixRenderHashBoxaArb(
pix.Pointer, boxa.Pointer,   spacing,   width,   orient,   outline,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2173, 1)
// pixRenderHashBoxaBlend(pix, boxa, spacing, width, orient, outline, rval, gval, bval, fract) as int
// pixRenderHashBoxaBlend(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderHashBoxaBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="boxa">[in] - </param>
///  <param name="spacing">[in] - spacing between lines must be  is greater  1</param>
///  <param name="width">[in] - thickness of box and hash lines</param>
///  <param name="orient">[in] - orientation of lines: L_HORIZONTAL_LINE, ...</param>
///  <param name="outline">[in] - 0 to skip drawing box outline</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - in [0.0 - 1.0] complete transparency (no effect if 0.0 no transparency if 1.0)</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderHashBoxaBlend(
				 Pix pix, 
				 Boxa boxa, 
				 int spacing, 
				 int width, 
				 int orient, 
				 int outline, 
				 int rval, 
				 int gval, 
				 int bval, 
				 Single fract){



	int _Result = Natives.pixRenderHashBoxaBlend(
pix.Pointer, boxa.Pointer,   spacing,   width,   orient,   outline,   rval,   gval,   bval,   fract);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2227, 1)
// pixRenderPolyline(pix, ptas, width, op, closeflag) as int
// pixRenderPolyline(PIX *, PTA *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// This renders a closed contour.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPolyline/*"/>
///  <param name="pix">[in] - any depth, not cmapped</param>
///  <param name="ptas">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
///  <param name="closeflag">[in] - 1 to close the contour 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPolyline(
				 Pix pix, 
				 Pta ptas, 
				 int width, 
				 int op, 
				 int closeflag){



	int _Result = Natives.pixRenderPolyline(
pix.Pointer, ptas.Pointer,   width,   op,   closeflag);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2272, 1)
// pixRenderPolylineArb(pix, ptas, width, rval, gval, bval, closeflag) as int
// pixRenderPolylineArb(PIX *, PTA *, l_int32, l_uint8, l_uint8, l_uint8, l_int32) as l_ok
///  <summary>
/// This renders a closed contour.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPolylineArb/*"/>
///  <param name="pix">[in] - any depth cmapped ok</param>
///  <param name="ptas">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="closeflag">[in] - 1 to close the contour 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPolylineArb(
				 Pix pix, 
				 Pta ptas, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 int closeflag){



	int _Result = Natives.pixRenderPolylineArb(
pix.Pointer, ptas.Pointer,   width,   rval,   gval,   bval,   closeflag);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2315, 1)
// pixRenderPolylineBlend(pix, ptas, width, rval, gval, bval, fract, closeflag, removedups) as int
// pixRenderPolylineBlend(PIX *, PTA *, l_int32, l_uint8, l_uint8, l_uint8, l_float32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPolylineBlend/*"/>
///  <param name="pix">[in] - 32 bpp rgb</param>
///  <param name="ptas">[in] - </param>
///  <param name="width">[in] - thickness of line</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///  <param name="fract">[in] - in [0.0 - 1.0] complete transparency (no effect if 0.0 no transparency if 1.0)</param>
///  <param name="closeflag">[in] - 1 to close the contour 0 otherwise</param>
///  <param name="removedups">[in] - 1 to remove 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderPolylineBlend(
				 Pix pix, 
				 Pta ptas, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval, 
				 Single fract, 
				 int closeflag, 
				 int removedups){



	int _Result = Natives.pixRenderPolylineBlend(
pix.Pointer, ptas.Pointer,   width,   rval,   gval,   bval,   fract,   closeflag,   removedups);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2356, 1)
// pixRenderGridArb(pix, nx, ny, width, rval, gval, bval) as int
// pixRenderGridArb(PIX *, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderGridArb/*"/>
///  <param name="pix">[in] - any depth, cmapped ok</param>
///  <param name="nx">[in] - number of rectangles in each direction</param>
///  <param name="ny">[in] - number of rectangles in each direction</param>
///  <param name="width">[in] - thickness of grid lines</param>
///  <param name="rval">[in] - </param>
///  <param name="gval">[in] - </param>
///  <param name="bval">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixRenderGridArb(
				 Pix pix, 
				 int nx, 
				 int ny, 
				 int width, 
				 byte rval, 
				 byte gval, 
				 byte bval){



	int _Result = Natives.pixRenderGridArb(
pix.Pointer,   nx,   ny,   width,   rval,   gval,   bval);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2416, 1)
// pixRenderRandomCmapPtaa(pix, ptaa, polyflag, width, closeflag) as Pix
// pixRenderRandomCmapPtaa(PIX *, PTAA *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a debugging routine, that displays a set of
/// pixels, selected by the set of Ptas in a Ptaa,
/// in a random color in a pix.<para/>
/// 
/// (2) If %polyflag == 1, each Pta is considered to be a polyline,
/// and is rendered using %width and %closeflag.  Each polyline
/// is rendered in a random color.<para/>
/// 
/// (3) If %polyflag == 0, all points in each Pta are rendered in a
/// random color.  The %width and %closeflag parameters are ignored.<para/>
/// 
/// (4) The output pix is 8 bpp and colormapped.  Up to 254
/// different, randomly selected colors, can be used.<para/>
/// 
/// (5) The rendered pixels replace the input pixels.  They will
/// be clipped silently to the input pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderRandomCmapPtaa/*"/>
///  <param name="pix">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
///  <param name="ptaa">[in] - </param>
///  <param name="polyflag">[in] - 1 to interpret each Pta as a polyline 0 to simply render the Pta as a set of pixels</param>
///  <param name="width">[in] - thickness of line use only for polyline</param>
///  <param name="closeflag">[in] - 1 to close the contour 0 otherwise use only for polyline mode</param>
///   <returns>pixd cmapped, 8 bpp or NULL on error</returns>

public static Pix pixRenderRandomCmapPtaa(
				 Pix pix, 
				 Ptaa ptaa, 
				 int polyflag, 
				 int width, 
				 int closeflag){



	IntPtr _Result = Natives.pixRenderRandomCmapPtaa(
pix.Pointer, ptaa.Pointer,   polyflag,   width,   closeflag);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2485, 1)
// pixRenderPolygon(ptas, width, pxmin, pymin) as Pix
// pixRenderPolygon(PTA *, l_int32, l_int32 *, l_int32 *) as PIX *
///  <summary>
/// (1) The pix is the minimum size required to contain the origin
/// and the polygon.  For example, the max x value of the input
/// points is w - 1, where w is the pix width.<para/>
/// 
/// (2) The rendered line is 4-connected, so that an interior or
/// exterior 8-c.c. flood fill operation works properly.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderPolygon/*"/>
///  <param name="ptas">[in] - of vertices, none repeated</param>
///  <param name="width">[in] - of polygon outline</param>
///  <param name="pxmin">[out][optional] - min x value of input pts</param>
///  <param name="pymin">[out][optional] - min y value of input pts</param>
///   <returns>pix 1 bpp, with outline generated, or NULL on error</returns>

public static Pix pixRenderPolygon(
				 Pta ptas, 
				 int width, 
				out int pxmin, 
				out int pymin){



	IntPtr _Result = Natives.pixRenderPolygon(
ptas.Pointer,   width, out  pxmin, out  pymin);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2540, 1)
// pixFillPolygon(pixs, pta, xmin, ymin) as Pix
// pixFillPolygon(PIX *, PTA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This fills the interior of the polygon, returning a
/// new pix.  It works for both convex and non-convex polygons.<para/>
/// 
/// (2) To generate a filled polygon from a pta:
/// PIX pixt = pixRenderPolygon(pta, 1, [and]xmin, [and]ymin)
/// PIX pixd = pixFillPolygon(pixt, pta, xmin, ymin)
/// pixDestroy([and]pixt)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFillPolygon/*"/>
///  <param name="pixs">[in] - 1 bpp, with 4-connected polygon outline</param>
///  <param name="pta">[in] - vertices of the polygon</param>
///  <param name="xmin">[in] - min values of vertices of polygon</param>
///  <param name="ymin">[in] - min values of vertices of polygon</param>
///   <returns>pixd with outline filled, or NULL on error</returns>

public static Pix pixFillPolygon(
				 Pix pixs, 
				 Pta pta, 
				 int xmin, 
				 int ymin){



	IntPtr _Result = Natives.pixFillPolygon(
pixs.Pointer, pta.Pointer,   xmin,   ymin);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2619, 1)
// pixRenderContours(pixs, startval, incr, outdepth) as Pix
// pixRenderContours(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The output can be either 1 bpp, showing just the contour
/// lines, or a copy of the input pixs with the contour lines
/// superposed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRenderContours/*"/>
///  <param name="pixs">[in] - 8 or 16 bpp no colormap</param>
///  <param name="startval">[in] - value of lowest contour must be in [0 ... maxval]</param>
///  <param name="incr">[in] - increment to next contour must be  is greater  0</param>
///  <param name="outdepth">[in] - either 1 or depth of pixs</param>
///   <returns>pixd, or NULL on error</returns>

public static Pix pixRenderContours(
				 Pix pixs, 
				 int startval, 
				 int incr, 
				 int outdepth){



	IntPtr _Result = Natives.pixRenderContours(
pixs.Pointer,   startval,   incr,   outdepth);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2745, 1)
// fpixAutoRenderContours(fpix, ncontours) as Pix
// fpixAutoRenderContours(FPIX *, l_int32) as PIX *
///  <summary>
/// (1) The increment is set to get approximately %ncontours.<para/>
/// 
/// (2) The proximity to the target value for contour display
/// is set to 0.15.<para/>
/// 
/// (3) Negative values are rendered in red positive values as black.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixAutoRenderContours/*"/>
///  <param name="fpix">[in] - </param>
///  <param name="ncontours">[in] - is greater  1,  is smaller 500, typ. about 50</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>

public static Pix fpixAutoRenderContours(
				 FPix fpix, 
				 int ncontours){



	IntPtr _Result = Natives.fpixAutoRenderContours(
fpix.Pointer,   ncontours);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2783, 1)
// fpixRenderContours(fpixs, incr, proxim) as Pix
// fpixRenderContours(FPIX *, l_float32, l_float32) as PIX *
///  <summary>
/// (1) Values are displayed when val/incr is within +-proxim
/// to an integer.  The default value is 0.15 smaller values
/// result in thinner contour lines.<para/>
/// 
/// (2) Negative values are rendered in red positive values as black.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRenderContours/*"/>
///  <param name="fpixs">[in] - </param>
///  <param name="incr">[in] - increment between contours must be  is greater  0.0</param>
///  <param name="proxim">[in] - required proximity to target value default 0.15</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>

public static Pix fpixRenderContours(
				 FPix fpixs, 
				 Single incr, 
				 Single proxim){



	IntPtr _Result = Natives.fpixRenderContours(
fpixs.Pointer,   incr,   proxim);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// graphics.c (2862, 1)
// pixGeneratePtaBoundary(pixs, width) as Pta
// pixGeneratePtaBoundary(PIX *, l_int32) as PTA *
///  <summary>
/// (1) Similar to ptaGetBoundaryPixels(), except here:
/// we only get pixels in the foreground
/// we can have a "line" width greater than 1 pixel.<para/>
/// 
/// (2) Once generated, this can be applied to a random 1 bpp image
/// to add a color boundary as follows:
/// Pta pta = pixGeneratePtaBoundary(pixs, width)
/// Pix pix1 = pixConvert1To8Cmap(pixs)
/// pixRenderPtaArb(pix1, pta, rval, gval, bval)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGeneratePtaBoundary/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="width">[in] - of boundary line</param>
///   <returns>pta, or NULL on error</returns>

public static Pta pixGeneratePtaBoundary(
				 Pix pixs, 
				 int width){



	IntPtr _Result = Natives.pixGeneratePtaBoundary(
pixs.Pointer,   width);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pta(_Result);
}


}
}
