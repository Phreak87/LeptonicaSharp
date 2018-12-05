using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// ccbord.c (299, 1)
// ccbaCreate(pixs, n) as CCBorda
// ccbaCreate(PIX *, l_int32) as CCBORDA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaCreate/*"/>
///  <param name="pixs">[in] - binary image can be null</param>
///  <param name="n">[in] - initial number of ptrs</param>
///   <returns>ccba, or NULL on error</returns>
public static CCBorda ccbaCreate(
				 Pix pixs, 
				 int n){

	IntPtr _Result = Natives.ccbaCreate(pixs.Pointer,   n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBorda(_Result);
}

// ccbord.c (332, 1)
// ccbaDestroy(pccba) as Object
// ccbaDestroy(CCBORDA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDestroy/*"/>
///  <param name="pccba">[in,out] - to be nulled</param>
public static void ccbaDestroy(
				ref CCBorda pccba){

	IntPtr pccbaPtr = IntPtr.Zero; 	if (pccba != null) {pccbaPtr = pccba.Pointer;}

	Natives.ccbaDestroy(ref pccbaPtr);
	
	if (pccbaPtr == IntPtr.Zero) {pccba = null;} else { pccba = new CCBorda(pccbaPtr); };
}

// ccbord.c (364, 1)
// ccbCreate(pixs) as CCBord
// ccbCreate(PIX *) as CCBORD *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbCreate/*"/>
///  <param name="pixs">[in][optional] - </param>
///   <returns>ccb or NULL on error</returns>
public static CCBord ccbCreate(
				 Pix pixs){

	IntPtr pixsPtr = IntPtr.Zero; 	if (pixs != null) {pixsPtr = pixs.Pointer;}

	IntPtr _Result = Natives.ccbCreate(pixsPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBord(_Result);
}

// ccbord.c (404, 1)
// ccbDestroy(pccb) as Object
// ccbDestroy(CCBORD **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbDestroy/*"/>
///  <param name="pccb">[in,out] - to be nulled</param>
public static void ccbDestroy(
				ref CCBord pccb){

	IntPtr pccbPtr = IntPtr.Zero; 	if (pccb != null) {pccbPtr = pccb.Pointer;}

	Natives.ccbDestroy(ref pccbPtr);
	
	if (pccbPtr == IntPtr.Zero) {pccb = null;} else { pccb = new CCBord(pccbPtr); };
}

// ccbord.c (454, 1)
// ccbaAddCcb(ccba, ccb) as int
// ccbaAddCcb(CCBORDA *, CCBORD *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaAddCcb/*"/>
///  <param name="ccba">[in] - </param>
///  <param name="ccb">[in] - to be added by insertion</param>
///   <returns>0 if OK 1 on error</returns>
public static int ccbaAddCcb(
				 CCBorda ccba, 
				 CCBord ccb){

	int _Result = Natives.ccbaAddCcb(ccba.Pointer, ccb.Pointer);
	
	return _Result;
}

// ccbord.c (510, 1)
// ccbaGetCount(ccba) as int
// ccbaGetCount(CCBORDA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGetCount/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>count, with 0 on error</returns>
public static int ccbaGetCount(
				 CCBorda ccba){

	int _Result = Natives.ccbaGetCount(ccba.Pointer);
	
	return _Result;
}

// ccbord.c (535, 1)
// ccbaGetCcb(ccba, index) as CCBord
// ccbaGetCcb(CCBORDA *, l_int32) as CCBORD *
///  <summary>
/// (1) This returns a clone of the ccb it must be destroyed
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGetCcb/*"/>
///  <param name="ccba">[in] - </param>
///  <param name="index">[in] - </param>
///   <returns>ccb, or NULL on error</returns>
public static CCBord ccbaGetCcb(
				 CCBorda ccba, 
				 int index){

	IntPtr _Result = Natives.ccbaGetCcb(ccba.Pointer,   index);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBord(_Result);
}

// ccbord.c (564, 1)
// pixGetAllCCBorders(pixs) as CCBorda
// pixGetAllCCBorders(PIX *) as CCBORDA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAllCCBorders/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///   <returns>ccborda, or NULL on error</returns>
public static CCBorda pixGetAllCCBorders(
				 Pix pixs){

	IntPtr _Result = Natives.pixGetAllCCBorders(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBorda(_Result);
}

// ccbord.c (650, 1)
// pixGetCCBorders(pixs, box) as CCBord
// pixGetCCBorders(PIX *, BOX *) as CCBORD *
///  <summary>
/// (1) We are finding the exterior and interior borders
/// of an 8-connected component. This should be used
/// on a pix that has exactly one 8-connected component.<para/>
/// 
/// (2) Typically, pixs is a c.c. in some larger pix.  The
/// input box gives its location in global coordinates.
/// This box is saved, as well as the boxes for the
/// borders of any holes within the c.c., but the latter
/// are given in relative coords within the c.c.<para/>
/// 
/// (3) The calculations for the exterior border are done
/// on a pix with a 1-pixel
/// added border, but the saved pixel coordinates
/// are the correct (relative) ones for the input pix
/// (without a 1-pixel border)<para/>
/// 
/// (4) For the definition of the three tables -- xpostab[], ypostab[]
/// and qpostab[] -- see above where they are defined.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetCCBorders/*"/>
///  <param name="pixs">[in] - 1 bpp, one 8-connected component</param>
///  <param name="box">[in] - xul, yul, width, height in global coords</param>
///   <returns>ccbord, or NULL on error</returns>
public static CCBord pixGetCCBorders(
				 Pix pixs, 
				 Box box){

	IntPtr _Result = Natives.pixGetCCBorders(pixs.Pointer, box.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBord(_Result);
}

// ccbord.c (761, 1)
// pixGetOuterBordersPtaa(pixs) as Ptaa
// pixGetOuterBordersPtaa(PIX *) as PTAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBordersPtaa/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///   <returns>ptaa of outer borders, in global coords, or NULL on error</returns>
public static Ptaa pixGetOuterBordersPtaa(
				 Pix pixs){

	IntPtr _Result = Natives.pixGetOuterBordersPtaa(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Ptaa(_Result);
}

// ccbord.c (821, 1)
// pixGetOuterBorderPta(pixs, box) as Pta
// pixGetOuterBorderPta(PIX *, BOX *) as PTA *
///  <summary>
/// (1) We are finding the exterior border of a single 8-connected
/// component.<para/>
/// 
/// (2) If box is NULL, the outline returned is in the local coords
/// of the input pix.  Otherwise, box is assumed to give the
/// location of the pix in global coordinates, and the returned
/// pta will be in those global coordinates.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBorderPta/*"/>
///  <param name="pixs">[in] - 1 bpp, one 8-connected component</param>
///  <param name="box">[in][optional] - of pixs, in global coordinates</param>
///   <returns>pta of outer border, in global coords, or NULL on error</returns>
public static Pta pixGetOuterBorderPta(
				 Pix pixs, 
				 Box box){

	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.pixGetOuterBorderPta(pixs.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ccbord.c (894, 1)
// pixGetOuterBorder(ccb, pixs, box) as int
// pixGetOuterBorder(CCBORD *, PIX *, BOX *) as l_ok
///  <summary>
/// (1) the border is saved in relative coordinates within
/// the c.c. (pixs).  Because the calculation is done
/// in pixb with added 1 pixel border, we must subtract
/// 1 from each pixel value before storing it.<para/>
/// 
/// (2) the stopping condition is that after the first pixel is
/// returned to, the next pixel is the second pixel.  Having
/// these 2 pixels recur in sequence proves the path is closed,
/// and we do not store the second pixel again.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBorder/*"/>
///  <param name="ccb">[in] - unfilled</param>
///  <param name="pixs">[in] - for the component at hand</param>
///  <param name="box">[in] - for the component, in global coords</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetOuterBorder(
				 CCBord ccb, 
				 Pix pixs, 
				 Box box){

	int _Result = Natives.pixGetOuterBorder(ccb.Pointer, pixs.Pointer, box.Pointer);
	
	return _Result;
}

// ccbord.c (982, 1)
// pixGetHoleBorder(ccb, pixs, box, xs, ys) as int
// pixGetHoleBorder(CCBORD *, PIX *, BOX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) we trace out hole border on pixs without addition
/// of single pixel added border to pixs<para/>
/// 
/// (2) therefore all coordinates are relative within the c.c. (pixs)<para/>
/// 
/// (3) same position tables and stopping condition as for
/// exterior borders
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetHoleBorder/*"/>
///  <param name="ccb">[in] - the exterior border is already made</param>
///  <param name="pixs">[in] - for the connected component at hand</param>
///  <param name="box">[in] - for the specific hole border, in relative coordinates to the c.c.</param>
///  <param name="xs">[in] - first pixel on hole border, relative to c.c.</param>
///  <param name="ys">[in] - first pixel on hole border, relative to c.c.</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetHoleBorder(
				 CCBord ccb, 
				 Pix pixs, 
				 Box box, 
				 int xs, 
				 int ys){

	int _Result = Natives.pixGetHoleBorder(ccb.Pointer, pixs.Pointer, box.Pointer,   xs,   ys);
	
	return _Result;
}

// ccbord.c (1064, 1)
// findNextBorderPixel(w, h, data, wpl, px, py, pqpos, pnpx, pnpy) as int
// findNextBorderPixel(l_int32, l_int32, l_uint32 *, l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_int32
///  <summary>
/// (1) qpos increases clockwise from 0 to 7, with 0 at
/// location with Q to left of P: Q P<para/>
/// 
/// (2) this is a low-level function that does not check input
/// parameters.  All calling functions should check them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findNextBorderPixel/*"/>
///  <param name="w">[in] - </param>
///  <param name="h">[in] - </param>
///  <param name="data">[in] - </param>
///  <param name="wpl">[in] - </param>
///  <param name="px">[in] - current P</param>
///  <param name="py">[in] - current P</param>
///  <param name="pqpos">[in,out] - input current Q new Q</param>
///  <param name="pnpx">[out] - new P</param>
///  <param name="pnpy">[out] - new P</param>
///   <returns>0 if next pixel found 1 otherwise</returns>
public static int findNextBorderPixel(
				 int w, 
				 int h, 
				 Byte[] data, 
				 int wpl, 
				 int px, 
				 int py, 
				ref int[] pqpos, 
				out int pnpx, 
				out int pnpy){

		IntPtr dataPtr = 	Marshal.AllocHGlobal(data.Length);
		Marshal.Copy(data, 0, dataPtr, data.Length);

	int _Result = Natives.findNextBorderPixel(  w,   h,   dataPtr,   wpl,   px,   py, ref  pqpos, out  pnpx, out  pnpy);
	
	Marshal.FreeHGlobal(dataPtr);
	return _Result;
}

// ccbord.c (1115, 1)
// locateOutsideSeedPixel(fpx, fpy, spx, spy, pxs, pys) as Object
// locateOutsideSeedPixel(l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as void
///  <summary>
/// (1) the first and second pixels must be 8-adjacent,
/// so |dx| smaller or equal 1 and |dy| smaller or equal 1 and both dx and dy
/// cannot be 0.  There are 8 possible cases.<para/>
/// 
/// (2) the seed pixel is OUTSIDE the foreground of the c.c.<para/>
/// 
/// (3) these rules are for the situation where the INSIDE
/// of the c.c. is on the right as you follow the border:
/// cw for an exterior border and ccw for a hole border.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/locateOutsideSeedPixel/*"/>
///  <param name="fpx">[in] - location of first pixel</param>
///  <param name="fpy">[in] - location of first pixel</param>
///  <param name="spx">[in] - location of second pixel</param>
///  <param name="spy">[in] - location of second pixel</param>
///  <param name="pxs">[out] - seed pixel to be returned</param>
///  <param name="pys">[out] - seed pixel to be returned</param>
public static void locateOutsideSeedPixel(
				 int fpx, 
				 int fpy, 
				 int spx, 
				 int spy, 
				out int pxs, 
				out int pys){

	Natives.locateOutsideSeedPixel(  fpx,   fpy,   spx,   spy, out  pxs, out  pys);
	
}

// ccbord.c (1160, 1)
// ccbaGenerateGlobalLocs(ccba) as int
// ccbaGenerateGlobalLocs(CCBORDA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateGlobalLocs/*"/>
///  <param name="ccba">[in] - with local chain ptaa of borders computed</param>
///   <returns>0 if OK, 1 on error Action: this uses the pixel locs in the local ptaa, which are all relative to each c.c., to find the global pixel locations, and stores them in the global ptaa.</returns>
public static int ccbaGenerateGlobalLocs(
				 CCBorda ccba){

	int _Result = Natives.ccbaGenerateGlobalLocs(ccba.Pointer);
	
	return _Result;
}

// ccbord.c (1231, 1)
// ccbaGenerateStepChains(ccba) as int
// ccbaGenerateStepChains(CCBORDA *) as l_ok
///  <summary>
/// (1) This uses the pixel locs in the local ptaa,
/// which are all relative to each c.c., to find
/// the step directions for successive pixels in
/// the chain, and stores them in the step numaa.<para/>
/// 
/// (2) To get the step direction, use
/// 1 2 3
/// 0 P 4
/// 7 6 5
/// where P is the previous pixel at (px, py).  The step direction
/// is the number (from 0 through 7) for each relative location
/// of the current pixel at (cx, cy).  It is easily found by
/// indexing into a 2-d 3x3 array (dirtab).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateStepChains/*"/>
///  <param name="ccba">[in] - with local chain ptaa of borders computed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaGenerateStepChains(
				 CCBorda ccba){

	int _Result = Natives.ccbaGenerateStepChains(ccba.Pointer);
	
	return _Result;
}

// ccbord.c (1305, 1)
// ccbaStepChainsToPixCoords(ccba, coordtype) as int
// ccbaStepChainsToPixCoords(CCBORDA *, l_int32) as l_ok
///  <summary>
/// (1) This uses the step chain data in each ccb to determine
/// the pixel locations, either global or local,
/// and stores them in the appropriate ptaa,
/// either global or local.  For the latter, the
/// pixel locations are relative to the c.c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaStepChainsToPixCoords/*"/>
///  <param name="ccba">[in] - with step chains numaa of borders</param>
///  <param name="coordtype">[in] - CCB_GLOBAL_COORDS or CCB_LOCAL_COORDS</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaStepChainsToPixCoords(
				 CCBorda ccba, 
				 int coordtype){

	int _Result = Natives.ccbaStepChainsToPixCoords(ccba.Pointer,   coordtype);
	
	return _Result;
}

// ccbord.c (1405, 1)
// ccbaGenerateSPGlobalLocs(ccba, ptsflag) as int
// ccbaGenerateSPGlobalLocs(CCBORDA *, l_int32) as l_ok
///  <summary>
/// (1) This calculates the splocal rep if not yet made.<para/>
/// 
/// (2) It uses the local pixel values in splocal, the single
/// path pta, which are all relative to each c.c., to find
/// the corresponding global pixel locations, and stores
/// them in the spglobal pta.<para/>
/// 
/// (3) This lists only the turning points: it both makes a
/// valid svg file and is typically about half the size
/// when all border points are listed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateSPGlobalLocs/*"/>
///  <param name="ccba">[in] - </param>
///  <param name="ptsflag">[in] - CCB_SAVE_ALL_PTS or CCB_SAVE_TURNING_PTS</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaGenerateSPGlobalLocs(
				 CCBorda ccba, 
				 int ptsflag){

	int _Result = Natives.ccbaGenerateSPGlobalLocs(ccba.Pointer,   ptsflag);
	
	return _Result;
}

// ccbord.c (1522, 1)
// ccbaGenerateSinglePath(ccba) as int
// ccbaGenerateSinglePath(CCBORDA *) as l_ok
///  <summary>
/// (1) Generates a single border in local pixel coordinates.
/// For each c.c., if there is just an outer border, copy it.
/// If there are also hole borders, for each hole border,
/// determine the smallest horizontal or vertical
/// distance from the border to the outside of the c.c.,
/// and find a path through the c.c. for this cut.
/// We do this in a way that guarantees a pixel from the
/// hole border is the starting point of the path, and
/// we must verify that the path intersects the outer
/// border (if it intersects it, then it ends on it).
/// One can imagine pathological cases, but they may not
/// occur in images of text characters and un-textured
/// line graphics.<para/>
/// 
/// (2) Once it is verified that the path through the c.c.
/// intersects both the hole and outer borders, we
/// generate the full single path for all borders in the
/// c.c.  Starting at the start point on the outer
/// border, when we hit a line on a cut, we take
/// the cut, do the hold border, and return on the cut
/// to the outer border.  We compose a pta of the
/// outer border pts that are on cut paths, and for
/// every point on the outer border (as we go around),
/// we check against this pta.  When we find a matching
/// point in the pta, we do its cut path and hole border.
/// The single path is saved in the ccb.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateSinglePath/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaGenerateSinglePath(
				 CCBorda ccba){

	int _Result = Natives.ccbaGenerateSinglePath(ccba.Pointer);
	
	return _Result;
}

// ccbord.c (1680, 1)
// getCutPathForHole(pix, pta, boxinner, pdir, plen) as Pta
// getCutPathForHole(PIX *, PTA *, BOX *, l_int32 *, l_int32 *) as PTA *
///  <summary>
/// (1) If we don't find a path, we return a pta with no pts
/// in it and len = 0.<para/>
/// 
/// (2) The goal is to get a reasonably short path between the
/// inner and outer borders, that goes entirely within the fg of
/// the pix.  This function is cheap-and-dirty, may fail for some
/// holes in complex topologies such as those you might find in a
/// moderately dark scanned halftone.  If it fails to find a
/// path to any particular hole, it gives a warning, and because
/// that hole path is not included, the hole will not be rendered.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getCutPathForHole/*"/>
///  <param name="pix">[in] - of c.c.</param>
///  <param name="pta">[in] - of outer border</param>
///  <param name="boxinner">[in] - b.b. of hole path</param>
///  <param name="pdir">[out] - direction (0-3), returned only needed for debug</param>
///  <param name="plen">[out] - length of path, returned</param>
///   <returns>pta of pts on cut path from the hole border to the outer border, including end points on both borders or NULL on error</returns>
public static Pta getCutPathForHole(
				 Pix pix, 
				 Pta pta, 
				 Box boxinner, 
				out int pdir, 
				out int plen){

	IntPtr _Result = Natives.getCutPathForHole(pix.Pointer, pta.Pointer, boxinner.Pointer, out  pdir, out  plen);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ccbord.c (1828, 1)
// ccbaDisplayBorder(ccba) as Pix
// ccbaDisplayBorder(CCBORDA *) as PIX *
///  <summary>
/// (1) Uses global ptaa, which gives each border pixel in
/// global coordinates, and must be computed in advance
/// by calling ccbaGenerateGlobalLocs().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayBorder/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>pix of border pixels, or NULL on error</returns>
public static Pix ccbaDisplayBorder(
				 CCBorda ccba){

	IntPtr _Result = Natives.ccbaDisplayBorder(ccba.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ccbord.c (1881, 1)
// ccbaDisplaySPBorder(ccba) as Pix
// ccbaDisplaySPBorder(CCBORDA *) as PIX *
///  <summary>
/// (1) Uses spglobal pta, which gives each border pixel in
/// global coordinates, one path per c.c., and must
/// be computed in advance by calling ccbaGenerateSPGlobalLocs().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplaySPBorder/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>pix of border pixels, or NULL on error</returns>
public static Pix ccbaDisplaySPBorder(
				 CCBorda ccba){

	IntPtr _Result = Natives.ccbaDisplaySPBorder(ccba.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ccbord.c (1971, 1)
// ccbaDisplayImage1(ccba) as Pix
// ccbaDisplayImage1(CCBORDA *) as PIX *
///  <summary>
/// (1) Uses local ptaa, which gives each border pixel in
/// local coordinates, so the actual pixel positions must
/// be computed using all offsets.<para/>
/// 
/// (2) For the holes, use coordinates relative to the c.c.<para/>
/// 
/// (3) This is slower than Method 2.<para/>
/// 
/// (4) This uses topological properties (Method 1) to do scan
/// conversion to raster
/// This algorithm deserves some commentary.
/// I first tried the following:
/// ~ outer borders: 4-fill from outside, stopping at the
/// border, using pixFillClosedBorders()
/// ~ inner borders: 4-fill from outside, stopping again
/// at the border, XOR with the border, and invert
/// to get the hole.  This did not work, because if
/// you have a hole border that looks like:
/// x x x x x x
/// x  x
/// x x x x x
/// x x o x x
/// x x
/// x x
/// x x x
/// if you 4-fill from the outside, the pixel 'o' will
/// not be filled!  XORing with the border leaves it OFF.
/// Inverting then gives a single bad ON pixel that is not
/// actually part of the hole.
/// So what you must do instead is 4-fill the holes from inside.
/// You can do this from a seedfill, using a pix with the hole
/// border as the filling mask.  But you need to start with a
/// pixel inside the hole.  How is this determined?  The best
/// way is from the contour.  We have a right-hand shoulder
/// rule for inside (i.e., the filled region). Take the
/// first 2 pixels of the hole border, and compute dx and dy
/// (second coord minus first coord:  dx = sx - fx, dy = sy - fy).
/// There are 8 possibilities, depending on the values of dx and
/// dy (which can each be -1, 0, and +1, but not both 0).
/// These 8 cases can be broken into 4 see the simple algorithm below.
/// Once you have an interior seed pixel, you fill from the seed,
/// clipping with the hole border pix by filling into its invert.
/// You then successively XOR these interior filled components, in any order.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayImage1/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>pix of image, or NULL on error</returns>
public static Pix ccbaDisplayImage1(
				 CCBorda ccba){

	IntPtr _Result = Natives.ccbaDisplayImage1(ccba.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ccbord.c (2097, 1)
// ccbaDisplayImage2(ccba) as Pix
// ccbaDisplayImage2(CCBORDA *) as PIX *
///  <summary>
/// (1) Uses local chain ptaa, which gives each border pixel in
/// local coordinates, so the actual pixel positions must
/// be computed using all offsets.<para/>
/// 
/// (2) Treats exterior and hole borders on equivalent
/// footing, and does all calculations on a pix
/// that spans the c.c. with a 1 pixel added boundary.<para/>
/// 
/// (3) This uses topological properties (Method 2) to do scan
/// conversion to raster<para/>
/// 
/// (4) The algorithm is described at the top of this file (Method 2).
/// It is preferred to Method 1 because it is between 1.2x and 2x
/// faster than Method 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayImage2/*"/>
///  <param name="ccba">[in] - </param>
///   <returns>pix of image, or NULL on error</returns>
public static Pix ccbaDisplayImage2(
				 CCBorda ccba){

	IntPtr _Result = Natives.ccbaDisplayImage2(ccba.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ccbord.c (2195, 1)
// ccbaWrite(filename, ccba) as int
// ccbaWrite(const char *, CCBORDA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="ccba">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaWrite(
				 String filename, 
				 CCBorda ccba){

	int _Result = Natives.ccbaWrite(  filename, ccba.Pointer);
	
	return _Result;
}

// ccbord.c (2247, 1)
// ccbaWriteStream(fp, ccba) as int
// ccbaWriteStream(FILE *, CCBORDA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="ccba">[in] - </param>
///   <returns>0 if OK 1 on error Format: \code ccba: %7d cc\n num. c.c.) (ascii)   (18B pix width 4B pix height 4B [for i = 1, ncc] ulx  4B uly  4B w    4B       -- not req'd for reconstruction h    4B       -- not req'd for reconstruction number of borders 4B [for j = 1, nb] startx  4B starty  4B [for k = 1, nb] 2 steps 1B end in z8 or 88  1B \endcode</returns>
public static int ccbaWriteStream(
				 FILE fp, 
				 CCBorda ccba){

	int _Result = Natives.ccbaWriteStream(fp.Pointer, ccba.Pointer);
	
	return _Result;
}

// ccbord.c (2348, 1)
// ccbaRead(filename) as CCBorda
// ccbaRead(const char *) as CCBORDA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>ccba, or NULL on error</returns>
public static CCBorda ccbaRead(
				 String filename){

	IntPtr _Result = Natives.ccbaRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBorda(_Result);
}

// ccbord.c (2394, 1)
// ccbaReadStream(fp) as CCBorda
// ccbaReadStream(FILE *) as CCBORDA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>ccba, or NULL on error \code Format:  ccba: %7d cc\n num. c.c.) (ascii)   (17B pix width 4B pix height 4B [for i = 1, ncc] ulx  4B uly  4B w    4B       -- not req'd for reconstruction h    4B       -- not req'd for reconstruction number of borders 4B [for j = 1, nb] startx  4B starty  4B [for k = 1, nb] 2 steps 1B end in z8 or 88  1B \endcode</returns>
public static CCBorda ccbaReadStream(
				 FILE fp){

	IntPtr _Result = Natives.ccbaReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new CCBorda(_Result);
}

// ccbord.c (2515, 1)
// ccbaWriteSVG(filename, ccba) as int
// ccbaWriteSVG(const char *, CCBORDA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteSVG/*"/>
///  <param name="filename">[in] - </param>
///  <param name="ccba">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int ccbaWriteSVG(
				 String filename, 
				 CCBorda ccba){

	int _Result = Natives.ccbaWriteSVG(  filename, ccba.Pointer);
	
	return _Result;
}

// ccbord.c (2546, 1)
// ccbaWriteSVGString(filename, ccba) as String
// ccbaWriteSVGString(const char *, CCBORDA *) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteSVGString/*"/>
///  <param name="filename">[in] - </param>
///  <param name="ccba">[in] - </param>
///   <returns>string in svg-formatted, that can be written to file, or NULL on error.</returns>
public static String ccbaWriteSVGString(
				 String filename, 
				 CCBorda ccba){

	String _Result = Natives.ccbaWriteSVGString(  filename, ccba.Pointer);
	
	return _Result;
}


}
}
