using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixtiling.c (121, 1)
// pixTilingCreate(pixs, nx, ny, w, h, xoverlap, yoverlap) as PixTiling
// pixTilingCreate(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXTILING *
///  <summary>
/// (1) We put a clone of pixs in the PixTiling.<para/>
/// 
/// (2) The input to pixTilingCreate() for horizontal tiling can be
/// either the number of tiles across the image or the approximate
/// width of the tiles.  If the latter, the actual width will be
/// determined by making all tiles but the last of equal width, and
/// making the last as close to the others as possible.  The same
/// consideration is applied independently to the vertical tiling.
/// To specify tile width, set nx = 0 to specify the number of
/// tiles horizontally across the image, set w = 0.<para/>
/// 
/// (3) If pixs is to be tiled in one-dimensional strips, use ny = 1 for
/// vertical strips and nx = 1 for horizontal strips.<para/>
/// 
/// (4) The overlap must not be larger than the width or height of
/// the leftmost or topmost tile(s).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingCreate/*"/>
///  <param name="pixs">[in] - pix to be tiled any depth colormap OK</param>
///  <param name="nx">[in] - number of tiles across image</param>
///  <param name="ny">[in] - number of tiles down image</param>
///  <param name="w">[in] - desired width of each tile</param>
///  <param name="h">[in] - desired height of each tile</param>
///  <param name="xoverlap">[in] - overlap into neighboring tiles on each side</param>
///  <param name="yoverlap">[in] - overlap into neighboring tiles above and below</param>
///   <returns>pixtiling, or NULL on error</returns>
public static PixTiling pixTilingCreate(
				 Pix pixs, 
				 int nx, 
				 int ny, 
				 int w, 
				 int h, 
				 int xoverlap, 
				 int yoverlap){

	IntPtr _Result = Natives.pixTilingCreate(pixs.Pointer,   nx,   ny,   w,   h,   xoverlap,   yoverlap);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixTiling(_Result);
}

// pixtiling.c (178, 1)
// pixTilingDestroy(ppt) as Object
// pixTilingDestroy(PIXTILING **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingDestroy/*"/>
///  <param name="ppt">[in,out] - will be set to null before returning</param>
public static void pixTilingDestroy(
				ref PixTiling ppt){

	IntPtr pptPtr = IntPtr.Zero; 	if (ppt != null) {pptPtr = ppt.Pointer;}

	Natives.pixTilingDestroy(ref pptPtr);
	

	if (pptPtr == null) {ppt = null;} else { ppt = new PixTiling(pptPtr); };


}

// pixtiling.c (208, 1)
// pixTilingGetCount(pt, pnx, pny) as int
// pixTilingGetCount(PIXTILING *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingGetCount/*"/>
///  <param name="pt">[in] - pixtiling</param>
///  <param name="pnx">[out][optional] - nx can be null</param>
///  <param name="pny">[out][optional] - ny can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixTilingGetCount(
				 PixTiling pt, 
				out int pnx, 
				out int pny){

	int _Result = Natives.pixTilingGetCount(pt.Pointer, out  pnx, out  pny);
	



	return _Result;
}

// pixtiling.c (231, 1)
// pixTilingGetSize(pt, pw, ph) as int
// pixTilingGetSize(PIXTILING *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingGetSize/*"/>
///  <param name="pt">[in] - pixtiling</param>
///  <param name="pw">[out][optional] - tile width can be null</param>
///  <param name="ph">[out][optional] - tile height can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixTilingGetSize(
				 PixTiling pt, 
				out int pw, 
				out int ph){

	int _Result = Natives.pixTilingGetSize(pt.Pointer, out  pw, out  ph);
	



	return _Result;
}

// pixtiling.c (255, 1)
// pixTilingGetTile(pt, i, j) as Pix
// pixTilingGetTile(PIXTILING *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingGetTile/*"/>
///  <param name="pt">[in] - pixtiling</param>
///  <param name="i">[in] - tile row index</param>
///  <param name="j">[in] - tile column index</param>
///   <returns>pixd tile with appropriate boundary (overlap) pixels added, or NULL on error</returns>
public static Pix pixTilingGetTile(
				 PixTiling pt, 
				 int i, 
				 int j){

	IntPtr _Result = Natives.pixTilingGetTile(pt.Pointer,   i,   j);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixtiling.c (368, 1)
// pixTilingNoStripOnPaint(pt) as int
// pixTilingNoStripOnPaint(PIXTILING *) as l_ok
///  <summary>
/// (1) The default for paint is to strip out the overlap pixels
/// that are added by pixTilingGetTile().  However, some
/// operations will generate an image with these pixels
/// stripped off.  This tells the paint operation not
/// to strip the added boundary pixels when painting.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingNoStripOnPaint/*"/>
///  <param name="pt">[in] - pixtiling</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixTilingNoStripOnPaint(
				 PixTiling pt){

	int _Result = Natives.pixTilingNoStripOnPaint(pt.Pointer);
	



	return _Result;
}

// pixtiling.c (390, 1)
// pixTilingPaintTile(pixd, i, j, pixs, pt) as int
// pixTilingPaintTile(PIX *, l_int32, l_int32, PIX *, PIXTILING *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTilingPaintTile/*"/>
///  <param name="pixd">[in] - dest: paint tile onto this, without overlap</param>
///  <param name="i">[in] - tile row index</param>
///  <param name="j">[in] - tile column index</param>
///  <param name="pixs">[in] - source: tile to be painted from</param>
///  <param name="pt">[in] - pixtiling struct</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixTilingPaintTile(
				 Pix pixd, 
				 int i, 
				 int j, 
				 Pix pixs, 
				 PixTiling pt){

	int _Result = Natives.pixTilingPaintTile(pixd.Pointer,   i,   j, pixs.Pointer, pt.Pointer);
	



	return _Result;
}

}
}
