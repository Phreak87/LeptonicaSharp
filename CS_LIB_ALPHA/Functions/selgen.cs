using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// selgen.c (146, 1)
// pixGenerateSelWithRuns(pixs, nhlines, nvlines, distance, minlength, toppix, botpix, leftpix, rightpix, ppixe) as Sel
// pixGenerateSelWithRuns(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
///  <summary>
/// (1) The horizontal and vertical lines along which elements are
/// selected are roughly equally spaced.  The actual locations of
/// the hits and misses are the centers of respective run-lengths.<para/>
/// 
/// (2) No elements are selected that are less than 'distance' pixels away
/// from a boundary pixel of the same color.  This makes the
/// match much more robust to edge noise.  Valid inputs of
/// 'distance' are 0, 1, 2, 3 and 4.  If distance is either 0 or
/// greater than 4, we reset it to the default value.<para/>
/// 
/// (3) The 4 numbers for adding rectangles of pixels outside the fg
/// can be use if the pattern is expected to be surrounded by bg
/// (white) pixels.  On the other hand, if the pattern may be near
/// other fg (black) components on some sides, use 0 for those sides.<para/>
/// 
/// (4) The pixels added to a side allow you to have miss elements there.
/// There is a constraint between distance, minlength, and
/// the added pixels for this to work.  We illustrate using the
/// default values.  If you add 5 pixels to the top, and use a
/// distance of 1, then you end up with a vertical run of at least
/// 4 bg pixels along the top edge of the image.  If you use a
/// minimum runlength of 3, each vertical line will always find
/// a miss near the center of its run.  However, if you use a
/// minimum runlength of 5, you will not get a miss on every vertical
/// line.  As another example, if you have 7 added pixels and a
/// distance of 2, you can use a runlength up to 5 to guarantee
/// that the miss element is recorded.  We give a warning if the
/// constraint does not guarantee a miss element outside the
/// image proper.<para/>
/// 
/// (5) The input pix, as extended by the extra pixels on selected sides,
/// can optionally be returned.  For debugging, call
/// pixDisplayHitMissSel() to visualize the hit-miss sel superimposed
/// on the generating bitmap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateSelWithRuns/*"/>
///  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
///  <param name="nhlines">[in] - number of hor lines along which elements are found</param>
///  <param name="nvlines">[in] - number of vert lines along which elements are found</param>
///  <param name="distance">[in] - min distance from boundary pixel use 0 for default</param>
///  <param name="minlength">[in] - min runlength to set hit or miss use 0 for default</param>
///  <param name="toppix">[in] - number of extra pixels of bg added above</param>
///  <param name="botpix">[in] - number of extra pixels of bg added below</param>
///  <param name="leftpix">[in] - number of extra pixels of bg added to left</param>
///  <param name="rightpix">[in] - number of extra pixels of bg added to right</param>
///  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
///   <returns>sel hit-miss for input pattern, or NULL on error</returns>
public static Sel pixGenerateSelWithRuns(
				 Pix pixs, 
				 int nhlines, 
				 int nvlines, 
				 int distance, 
				 int minlength, 
				 int toppix, 
				 int botpix, 
				 int leftpix, 
				 int rightpix, 
				out Pix ppixe){

	IntPtr ppixePtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixGenerateSelWithRuns(pixs.Pointer,   nhlines,   nvlines,   distance,   minlength,   toppix,   botpix,   leftpix,   rightpix, out ppixePtr);
	

	if (ppixePtr == IntPtr.Zero) {ppixe = null;} else { ppixe = new Pix(ppixePtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// selgen.c (336, 1)
// pixGenerateSelRandom(pixs, hitfract, missfract, distance, toppix, botpix, leftpix, rightpix, ppixe) as Sel
// pixGenerateSelRandom(PIX *, l_float32, l_float32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
///  <summary>
/// (1) Either of hitfract and missfract can be zero.  If both are zero,
/// the sel would be empty, and NULL is returned.<para/>
/// 
/// (2) No elements are selected that are less than 'distance' pixels away
/// from a boundary pixel of the same color.  This makes the
/// match much more robust to edge noise.  Valid inputs of
/// 'distance' are 0, 1, 2, 3 and 4.  If distance is either 0 or
/// greater than 4, we reset it to the default value.<para/>
/// 
/// (3) The 4 numbers for adding rectangles of pixels outside the fg
/// can be use if the pattern is expected to be surrounded by bg
/// (white) pixels.  On the other hand, if the pattern may be near
/// other fg (black) components on some sides, use 0 for those sides.<para/>
/// 
/// (4) The input pix, as extended by the extra pixels on selected sides,
/// can optionally be returned.  For debugging, call
/// pixDisplayHitMissSel() to visualize the hit-miss sel superimposed
/// on the generating bitmap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateSelRandom/*"/>
///  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
///  <param name="hitfract">[in] - fraction of allowable fg pixels that are hits</param>
///  <param name="missfract">[in] - fraction of allowable bg pixels that are misses</param>
///  <param name="distance">[in] - min distance from boundary pixel use 0 for default</param>
///  <param name="toppix">[in] - number of extra pixels of bg added above</param>
///  <param name="botpix">[in] - number of extra pixels of bg added below</param>
///  <param name="leftpix">[in] - number of extra pixels of bg added to left</param>
///  <param name="rightpix">[in] - number of extra pixels of bg added to right</param>
///  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
///   <returns>sel hit-miss for input pattern, or NULL on error</returns>
public static Sel pixGenerateSelRandom(
				 Pix pixs, 
				 Single hitfract, 
				 Single missfract, 
				 int distance, 
				 int toppix, 
				 int botpix, 
				 int leftpix, 
				 int rightpix, 
				out Pix ppixe){

	IntPtr ppixePtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixGenerateSelRandom(pixs.Pointer,   hitfract,   missfract,   distance,   toppix,   botpix,   leftpix,   rightpix, out ppixePtr);
	

	if (ppixePtr == IntPtr.Zero) {ppixe = null;} else { ppixe = new Pix(ppixePtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// selgen.c (489, 1)
// pixGenerateSelBoundary(pixs, hitdist, missdist, hitskip, missskip, topflag, botflag, leftflag, rightflag, ppixe) as Sel
// pixGenerateSelBoundary(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
///  <summary>
/// (1) All fg elements selected are exactly hitdist pixels away from
/// the nearest fg boundary pixel, and ditto for bg elements.
/// Valid inputs of hitdist and missdist are 0, 1, 2, 3 and 4.
/// For example, a hitdist of 0 puts the hits at the fg boundary.
/// Usually, the distances should be  is greater  0 avoid the effect of
/// noise at the boundary.<para/>
/// 
/// (2) Set hitskip  is smaller 0 if no hits are to be used.  Ditto for missskip.
/// If both hitskip and missskip are  is smaller 0, the sel would be empty,
/// and NULL is returned.<para/>
/// 
/// (3) The 4 flags determine whether the sel is increased on that side
/// to allow bg misses to be placed all along that boundary.
/// The increase in sel size on that side is the minimum necessary
/// to allow the misses to be placed at mindist.  For text characters,
/// the topflag and botflag are typically set to 1, and the leftflag
/// and rightflag to 0.<para/>
/// 
/// (4) The input pix, as extended by the extra pixels on selected sides,
/// can optionally be returned.  For debugging, call
/// pixDisplayHitMissSel() to visualize the hit-miss sel superimposed
/// on the generating bitmap.<para/>
/// 
/// (5) This is probably the best of the three sel generators, in the
/// sense that you have the most flexibility with the smallest number
/// of hits and misses.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateSelBoundary/*"/>
///  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
///  <param name="hitdist">[in] - min distance from fg boundary pixel</param>
///  <param name="missdist">[in] - min distance from bg boundary pixel</param>
///  <param name="hitskip">[in] - number of boundary pixels skipped between hits</param>
///  <param name="missskip">[in] - number of boundary pixels skipped between misses</param>
///  <param name="topflag">[in] - flag for extra pixels of bg added above</param>
///  <param name="botflag">[in] - flag for extra pixels of bg added below</param>
///  <param name="leftflag">[in] - flag for extra pixels of bg added to left</param>
///  <param name="rightflag">[in] - flag for extra pixels of bg added to right</param>
///  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
///   <returns>sel hit-miss for input pattern, or NULL on error</returns>
public static Sel pixGenerateSelBoundary(
				 Pix pixs, 
				 int hitdist, 
				 int missdist, 
				 int hitskip, 
				 int missskip, 
				 int topflag, 
				 int botflag, 
				 int leftflag, 
				 int rightflag, 
				out Pix ppixe){

	IntPtr ppixePtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixGenerateSelBoundary(pixs.Pointer,   hitdist,   missdist,   hitskip,   missskip,   topflag,   botflag,   leftflag,   rightflag, out ppixePtr);
	

	if (ppixePtr == IntPtr.Zero) {ppixe = null;} else { ppixe = new Pix(ppixePtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// selgen.c (636, 1)
// pixGetRunCentersOnLine(pixs, x, y, minlength) as Numa
// pixGetRunCentersOnLine(PIX *, l_int32, l_int32, l_int32) as NUMA *
///  <summary>
/// (1) Action: this function computes the fg (black) and bg (white)
/// pixel runlengths along the specified horizontal or vertical line,
/// and returns a Numa of the "center" pixels of each fg run
/// whose length equals or exceeds the minimum length.<para/>
/// 
/// (2) This only works on horizontal and vertical lines.<para/>
/// 
/// (3) For horizontal runs, set x = -1 and y to the value
/// for all points along the raster line.  For vertical runs,
/// set y = -1 and x to the value for all points along the
/// pixel column.<para/>
/// 
/// (4) For horizontal runs, the points in the Numa are the x
/// values in the center of fg runs that are of length at
/// least 'minlength'.  For vertical runs, the points in the
/// Numa are the y values in the center of fg runs, again
/// of length 'minlength' or greater.<para/>
/// 
/// (5) If there are no fg runs along the line that satisfy the
/// minlength constraint, the returned Numa is empty.  This
/// is not an error.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRunCentersOnLine/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="x">[in] - set one of these to -1 see notes</param>
///  <param name="y">[in] - set one of these to -1 see notes</param>
///  <param name="minlength">[in] - minimum length of acceptable run</param>
///   <returns>numa of fg runs, or NULL on error</returns>
public static Numa pixGetRunCentersOnLine(
				 Pix pixs, 
				 int x, 
				 int y, 
				 int minlength){

	IntPtr _Result = Natives.pixGetRunCentersOnLine(pixs.Pointer,   x,   y,   minlength);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Numa(_Result);
}

// selgen.c (708, 1)
// pixGetRunsOnLine(pixs, x1, y1, x2, y2) as Numa
// pixGetRunsOnLine(PIX *, l_int32, l_int32, l_int32, l_int32) as NUMA *
///  <summary>
/// (1) Action: this function uses the bresenham algorithm to compute
/// the pixels along the specified line.  It returns a Numa of the
/// runlengths of the fg (black) and bg (white) runs, always
/// starting with a white run.<para/>
/// 
/// (2) If the first pixel on the line is black, the length of the
/// first returned run (which is white) is 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRunsOnLine/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="x1">[in] - </param>
///  <param name="y1">[in] - </param>
///  <param name="x2">[in] - </param>
///  <param name="y2">[in] - </param>
///   <returns>numa, or NULL on error</returns>
public static Numa pixGetRunsOnLine(
				 Pix pixs, 
				 int x1, 
				 int y1, 
				 int x2, 
				 int y2){

	IntPtr _Result = Natives.pixGetRunsOnLine(pixs.Pointer,   x1,   y1,   x2,   y2);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Numa(_Result);
}

// selgen.c (803, 1)
// pixSubsampleBoundaryPixels(pixs, skip) as Pta
// pixSubsampleBoundaryPixels(PIX *, l_int32) as PTA *
///  <summary>
/// (1) If skip = 0, we take all the fg pixels.<para/>
/// 
/// (2) We try to traverse the boundaries in a regular way.
/// Some pixels may be missed, and these are then subsampled
/// randomly with a fraction determined by 'skip'.<para/>
/// 
/// (3) The most natural approach is to use a depth first (stack-based)
/// method to find the fg pixels.  However, the pixel runs are
/// 4-connected and there are relatively few branches.  So
/// instead of doing a proper depth-first search, we get nearly
/// the same result using two nested while loops: the outer
/// one continues a raster-based search for the next fg pixel,
/// and the inner one does a reasonable job running along
/// each 4-connected coutour.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSubsampleBoundaryPixels/*"/>
///  <param name="pixs">[in] - 1 bpp, with only boundary pixels in fg</param>
///  <param name="skip">[in] - number to skip between samples as you traverse boundary</param>
///   <returns>pta, or NULL on error</returns>
public static Pta pixSubsampleBoundaryPixels(
				 Pix pixs, 
				 int skip){

	IntPtr _Result = Natives.pixSubsampleBoundaryPixels(pixs.Pointer,   skip);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pta(_Result);
}

// selgen.c (870, 1)
// adjacentOnPixelInRaster(pixs, x, y, pxa, pya) as int
// adjacentOnPixelInRaster(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
///  <summary>
/// (1) Search is in 4-connected directions first then on diagonals.
/// This allows traversal along a 4-connected boundary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/adjacentOnPixelInRaster/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="x">[in] - current pixel</param>
///  <param name="y">[in] - current pixel</param>
///  <param name="pxa">[out] - adjacent ON pixel, found by simple CCW search</param>
///  <param name="pya">[out] - adjacent ON pixel, found by simple CCW search</param>
///   <returns>1 if a pixel is found 0 otherwise or on error</returns>
public static int adjacentOnPixelInRaster(
				 Pix pixs, 
				 int x, 
				 int y, 
				out int pxa, 
				out int pya){

	int _Result = Natives.adjacentOnPixelInRaster(pixs.Pointer,   x,   y, out  pxa, out  pya);
	



	return _Result;
}

// selgen.c (928, 1)
// pixDisplayHitMissSel(pixs, sel, scalefactor, hitcolor, misscolor) as Pix
// pixDisplayHitMissSel(PIX *, SEL *, l_int32, l_uint32, l_uint32) as PIX *
///  <summary>
/// (1) We don't allow scalefactor to be larger than MAX_SEL_SCALEFACTOR<para/>
/// 
/// (2) The colors are conveniently given as 4 bytes in hex format,
/// such as 0xff008800.  The least significant byte is ignored.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayHitMissSel/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="sel">[in] - hit-miss in general</param>
///  <param name="scalefactor">[in] - an integer greater or equal 1 use 0 for default</param>
///  <param name="hitcolor">[in] - RGB0 color for center of hit pixels</param>
///  <param name="misscolor">[in] - RGB0 color for center of miss pixels</param>
///   <returns>pixd RGB showing both pixs and sel, or NULL on error</returns>
public static Pix pixDisplayHitMissSel(
				 Pix pixs, 
				 Sel sel, 
				 int scalefactor, 
				 uint hitcolor, 
				 uint misscolor){

	IntPtr _Result = Natives.pixDisplayHitMissSel(pixs.Pointer, sel.Pointer,   scalefactor,   hitcolor,   misscolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}


}
}
