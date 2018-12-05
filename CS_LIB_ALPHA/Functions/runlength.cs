using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// runlength.c (99, 1)
// pixStrokeWidthTransform(pixs, color, depth, nangles) as Pix
// pixStrokeWidthTransform(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The dest Pix is 8 or 16 bpp, with the pixel values
/// equal to the stroke width in which it is a member.
/// The values are clipped to the max pixel value if necessary.<para/>
/// 
/// (2) The color determines if we're labelling white or black strokes.<para/>
/// 
/// (3) A pixel that is not a member of the chosen color gets
/// value 0 it belongs to a width of length 0 of the
/// chosen color.<para/>
/// 
/// (4) This chooses, for each dest pixel, the minimum of sets
/// of runlengths through each pixel.  Here are the sets:
/// nangles  increment  set
/// -------  ---------  --------------------------------
/// 2  90 {0, 90}
/// 4  45 {0, 45, 90, 135}
/// 6  30 {0, 30, 60, 90, 120, 150}
/// 8  22.5 {0, 22.5, 45, 67.5, 90, 112.5, 135, 157.5}<para/>
/// 
/// (5) Runtime scales linearly with (nangles - 2).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStrokeWidthTransform/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="color">[in] - 0 for white runs, 1 for black runs</param>
///  <param name="depth">[in] - of pixd: 8 or 16 bpp</param>
///  <param name="nangles">[in] - 2, 4, 6 or 8</param>
///   <returns>pixd 8 or 16 bpp, or NULL on error</returns>
public static Pix pixStrokeWidthTransform(
				 Pix pixs, 
				 int color, 
				 int depth, 
				 int nangles){

	IntPtr _Result = Natives.pixStrokeWidthTransform(pixs.Pointer,   color,   depth,   nangles);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// runlength.c (262, 1)
// pixRunlengthTransform(pixs, color, direction, depth) as Pix
// pixRunlengthTransform(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The dest Pix is 8 or 16 bpp, with the pixel values
/// equal to the runlength in which it is a member.
/// The length is clipped to the max pixel value if necessary.<para/>
/// 
/// (2) The color determines if we're labelling white or black runs.<para/>
/// 
/// (3) A pixel that is not a member of the chosen color gets
/// value 0 it belongs to a run of length 0 of the
/// chosen color.<para/>
/// 
/// (4) To convert for maximum dynamic range, either linear or
/// log, use pixMaxDynamicRange().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRunlengthTransform/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="color">[in] - 0 for white runs, 1 for black runs</param>
///  <param name="direction">[in] - L_HORIZONTAL_RUNS, L_VERTICAL_RUNS</param>
///  <param name="depth">[in] - 8 or 16 bpp</param>
///   <returns>pixd 8 or 16 bpp, or NULL on error</returns>
public static Pix pixRunlengthTransform(
				 Pix pixs, 
				 int color, 
				 int direction, 
				 int depth){

	IntPtr _Result = Natives.pixRunlengthTransform(pixs.Pointer,   color,   direction,   depth);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// runlength.c (372, 1)
// pixFindHorizontalRuns(pix, y, xstart, xend, pn) as int
// pixFindHorizontalRuns(PIX *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This finds foreground horizontal runs on a single scanline.<para/>
/// 
/// (2) To find background runs, use pixInvert() before applying
/// this function.<para/>
/// 
/// (3) The xstart and xend arrays are input.  They should be
/// of size w/2 + 1 to insure that they can hold
/// the maximum number of runs in the raster line.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindHorizontalRuns/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="y">[in] - line to traverse</param>
///  <param name="xstart">[in] - returns array of start positions for fg runs</param>
///  <param name="xend">[in] - returns array of end positions for fg runs</param>
///  <param name="pn">[out] - the number of runs found</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixFindHorizontalRuns(
				 Pix pix, 
				 int y, 
				 int[] xstart, 
				 int[] xend, 
				out int pn){

	int _Result = Natives.pixFindHorizontalRuns(pix.Pointer,   y,   xstart,   xend, out  pn);
	
	return _Result;
}

// runlength.c (449, 1)
// pixFindVerticalRuns(pix, x, ystart, yend, pn) as int
// pixFindVerticalRuns(PIX *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This finds foreground vertical runs on a single scanline.<para/>
/// 
/// (2) To find background runs, use pixInvert() before applying
/// this function.<para/>
/// 
/// (3) The ystart and yend arrays are input.  They should be
/// of size h/2 + 1 to insure that they can hold
/// the maximum number of runs in the raster line.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindVerticalRuns/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="x">[in] - line to traverse</param>
///  <param name="ystart">[in] - returns array of start positions for fg runs</param>
///  <param name="yend">[in] - returns array of end positions for fg runs</param>
///  <param name="pn">[out] - the number of runs found</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixFindVerticalRuns(
				 Pix pix, 
				 int x, 
				 int[] ystart, 
				 int[] yend, 
				out int pn){

	int _Result = Natives.pixFindVerticalRuns(pix.Pointer,   x,   ystart,   yend, out  pn);
	
	return _Result;
}

// runlength.c (525, 1)
// pixFindMaxRuns(pix, direction, pnastart) as Numa
// pixFindMaxRuns(PIX *, l_int32, NUMA **) as NUMA *
///  <summary>
/// (1) This finds the longest foreground runs by row or column<para/>
/// 
/// (2) To find background runs, use pixInvert() before applying
/// this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxRuns/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="direction">[in] - L_HORIZONTAL_RUNS or L_VERTICAL_RUNS</param>
///  <param name="pnastart">[out][optional] - start locations of longest runs</param>
///   <returns>na of lengths of runs, or NULL on error</returns>
public static Numa pixFindMaxRuns(
				 Pix pix, 
				 int direction, 
				out Numa pnastart){

	IntPtr pnastartPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixFindMaxRuns(pix.Pointer,   direction, out pnastartPtr);
	
	if (pnastartPtr == IntPtr.Zero) {pnastart = null;} else { pnastart = new Numa(pnastartPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// runlength.c (578, 1)
// pixFindMaxHorizontalRunOnLine(pix, y, pxstart, psize) as int
// pixFindMaxHorizontalRunOnLine(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This finds the longest foreground horizontal run on a scanline.<para/>
/// 
/// (2) To find background runs, use pixInvert() before applying
/// this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxHorizontalRunOnLine/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="y">[in] - line to traverse</param>
///  <param name="pxstart">[out][optional] - start position</param>
///  <param name="psize">[out] - the size of the run</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixFindMaxHorizontalRunOnLine(
				 Pix pix, 
				 int y, 
				out int pxstart, 
				out int psize){

	int _Result = Natives.pixFindMaxHorizontalRunOnLine(pix.Pointer,   y, out  pxstart, out  psize);
	
	return _Result;
}

// runlength.c (652, 1)
// pixFindMaxVerticalRunOnLine(pix, x, pystart, psize) as int
// pixFindMaxVerticalRunOnLine(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This finds the longest foreground vertical run on a scanline.<para/>
/// 
/// (2) To find background runs, use pixInvert() before applying
/// this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxVerticalRunOnLine/*"/>
///  <param name="pix">[in] - 1 bpp</param>
///  <param name="x">[in] - column to traverse</param>
///  <param name="pystart">[out][optional] - start position</param>
///  <param name="psize">[out] - the size of the run</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixFindMaxVerticalRunOnLine(
				 Pix pix, 
				 int x, 
				out int pystart, 
				out int psize){

	int _Result = Natives.pixFindMaxVerticalRunOnLine(pix.Pointer,   x, out  pystart, out  psize);
	
	return _Result;
}

// runlength.c (733, 1)
// runlengthMembershipOnLine(buffer, size, depth, start, end, n) as int
// runlengthMembershipOnLine(l_int32 *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32) as l_ok
///  <summary>
/// (1) Converts a set of runlengths into a buffer of
/// runlength membership values.<para/>
/// 
/// (2) Initialization of the array gives pixels that are
/// not within a run the value 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/runlengthMembershipOnLine/*"/>
///  <param name="buffer">[in] - into which full line of data is placed</param>
///  <param name="size">[in] - full size of line w or h</param>
///  <param name="depth">[in] - 8 or 16 bpp</param>
///  <param name="start">[in] - array of start positions for fg runs</param>
///  <param name="n">[in] - the number of runs</param>
///   <returns>0 if OK 1 on error</returns>
public static int runlengthMembershipOnLine(
				 int[] buffer, 
				 int size, 
				 int depth, 
				 int[] start, 
				 object _end_, 
				 int n){

	int _Result = Natives.runlengthMembershipOnLine(  buffer,   size,   depth,   start,   _end_,   n);
	
	return _Result;
}

// runlength.c (791, 1)
// makeMSBitLocTab(bitval) as int[]
// makeMSBitLocTab(l_int32) as l_int32 *
///  <summary>
/// (1) If bitval == 1, it finds the leftmost ON pixel in a byte
/// otherwise if bitval == 0, it finds the leftmost OFF pixel.<para/>
/// 
/// (2) If there are no pixels of the indicated color in the byte,
/// this returns 8.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeMSBitLocTab/*"/>
///  <param name="bitval">[in] - either 0 or 1</param>
///   <returns>table giving, for an input byte, the MS bit location, starting at 0 with the MSBit in the byte, or NULL on error.</returns>
public static int[] makeMSBitLocTab(
				 int bitval){

	int[] _Result = Natives.makeMSBitLocTab(  bitval);
	
	return _Result;
}


}
}
