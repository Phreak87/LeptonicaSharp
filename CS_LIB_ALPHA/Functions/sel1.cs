using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// sel1.c (239, 1)
// selaCreate(n) as Sela
// selaCreate(l_int32) as SELA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaCreate/*"/>
///  <param name="n">[in] - initial number of sel ptrs use 0 for default</param>
///   <returns>sela, or NULL on error</returns>
public static Sela selaCreate(
				 int n){

	IntPtr _Result = Natives.selaCreate(  n);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sela(_Result);
}

// sel1.c (272, 1)
// selaDestroy(psela) as Object
// selaDestroy(SELA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaDestroy/*"/>
///  <param name="psela">[in,out] - to be nulled</param>
public static void selaDestroy(
				ref Sela psela){

	IntPtr pselaPtr = IntPtr.Zero; 	if (psela != null) {pselaPtr = psela.Pointer;}

	Natives.selaDestroy(ref pselaPtr);
	

	if (pselaPtr == IntPtr.Zero) {psela = null;} else { psela = new Sela(pselaPtr); };


}

// sel1.c (306, 1)
// selCreate(height, width, name) as Sel
// selCreate(l_int32, l_int32, const char *) as SEL *
///  <summary>
/// (1) selCreate() initializes all values to 0.<para/>
/// 
/// (2) After this call, (cy,cx) and nonzero data values must be
/// assigned.  If a text name is not assigned here, it will
/// be needed later when the sel is put into a sela.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreate/*"/>
///  <param name="height">[in] - </param>
///  <param name="width">[in] - </param>
///  <param name="name">[in][optional] - sel name can be null</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selCreate(
				 int height, 
				 int width, 
				 String name){

	IntPtr _Result = Natives.selCreate(  height,   width,   name);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (337, 1)
// selDestroy(psel) as Object
// selDestroy(SEL **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selDestroy/*"/>
///  <param name="psel">[in,out] - to be nulled</param>
public static void selDestroy(
				ref Sel psel){

	IntPtr pselPtr = IntPtr.Zero; 	if (psel != null) {pselPtr = psel.Pointer;}

	Natives.selDestroy(ref pselPtr);
	

	if (pselPtr == IntPtr.Zero) {psel = null;} else { psel = new Sel(pselPtr); };


}

// sel1.c (370, 1)
// selCopy(sel) as Sel
// selCopy(SEL *) as SEL *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCopy/*"/>
///  <param name="sel">[in] - </param>
///   <returns>a copy of the sel, or NULL on error</returns>
public static Sel selCopy(
				 Sel sel){

	IntPtr _Result = Natives.selCopy(sel.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (418, 1)
// selCreateBrick(h, w, cy, cx, type) as Sel
// selCreateBrick(l_int32, l_int32, l_int32, l_int32, l_int32) as SEL *
///  <summary>
/// (1) This is a rectangular sel of all hits, misses or don't cares.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateBrick/*"/>
///  <param name="h">[in] - height, width</param>
///  <param name="w">[in] - height, width</param>
///  <param name="cy">[in] - origin, relative to UL corner at 0,0</param>
///  <param name="cx">[in] - origin, relative to UL corner at 0,0</param>
///  <param name="type">[in] - SEL_HIT, SEL_MISS, or SEL_DONT_CARE</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selCreateBrick(
				 int h, 
				 int w, 
				 int cy, 
				 int cx, 
				 int type){

	IntPtr _Result = Natives.selCreateBrick(  h,   w,   cy,   cx,   type);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (462, 1)
// selCreateComb(factor1, factor2, direction) as Sel
// selCreateComb(l_int32, l_int32, l_int32) as SEL *
///  <summary>
/// (1) This generates a comb Sel of hits with the origin as
/// near the center as possible.<para/>
/// 
/// (2) In use, this is complemented by a brick sel of size %factor1,
/// Both brick and comb sels are made by selectComposableSels().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateComb/*"/>
///  <param name="factor1">[in] - contiguous space between comb tines</param>
///  <param name="factor2">[in] - number of comb tines</param>
///  <param name="direction">[in] - L_HORIZ, L_VERT</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selCreateComb(
				 int factor1, 
				 int factor2, 
				 int direction){

	IntPtr _Result = Natives.selCreateComb(  factor1,   factor2,   direction);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (515, 1)
// create2dIntArray(sy, sx) as List<int[]>
// create2dIntArray(l_int32, l_int32) as l_int32 **
///  <summary>
/// (1) The array[sy][sx] is indexed in standard "matrix notation",
/// with the row index first.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/create2dIntArray/*"/>
///  <param name="sy">[in] - rows == height</param>
///  <param name="sx">[in] - columns == width</param>
///   <returns>doubly indexed array i.e., an array of sy row pointers, each of which points to an array of sx ints</returns>
public static List<int[]> create2dIntArray(
				 int sy, 
				 int sx){

	IntPtr _Result = Natives.create2dIntArray(  sy,   sx);
	


	List<int[]> B = null; // Todo

	return B;
}

// sel1.c (566, 1)
// selaAddSel(sela, sel, selname, copyflag) as int
// selaAddSel(SELA *, SEL *, const char *, l_int32) as l_ok
///  <summary>
/// (1) This adds a sel, either inserting or making a copy.<para/>
/// 
/// (2) Because every sel in a sela must have a name, it copies
/// the input name if necessary.  You can input NULL for
/// selname if the sel already has a name.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddSel/*"/>
///  <param name="sela">[in] - </param>
///  <param name="sel">[in] - to be added</param>
///  <param name="selname">[in] - ignored if already defined in sel req'd in sel when added to a sela</param>
///  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
///   <returns>0 if OK 1 on error</returns>
public static int selaAddSel(
				 Sela sela, 
				 Sel sel, 
				 String selname, 
				 int copyflag){

	int _Result = Natives.selaAddSel(sela.Pointer, sel.Pointer,   selname,   copyflag);
	



	return _Result;
}

// sel1.c (639, 1)
// selaGetCount(sela) as int
// selaGetCount(SELA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaGetCount/*"/>
///  <param name="sela">[in] - </param>
///   <returns>count, or 0 on error</returns>
public static int selaGetCount(
				 Sela sela){

	int _Result = Natives.selaGetCount(sela.Pointer);
	



	return _Result;
}

// sel1.c (664, 1)
// selaGetSel(sela, i) as Sel
// selaGetSel(SELA *, l_int32) as SEL *
///  <summary>
/// (1) This returns a ptr to the sel, not a copy, so the caller
/// must not destroy it!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaGetSel/*"/>
///  <param name="sela">[in] - </param>
///  <param name="i">[in] - index of sel to be retrieved not copied</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selaGetSel(
				 Sela sela, 
				 int i){

	IntPtr _Result = Natives.selaGetSel(sela.Pointer,   i);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (685, 1)
// selGetName(sel) as String
// selGetName(SEL *) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selGetName/*"/>
///  <param name="sel">[in] - </param>
///   <returns>sel name not copied, or NULL if no name or on error</returns>
public static String selGetName(
				 Sel sel){

	String _Result = Natives.selGetName(sel.Pointer);
	



	return _Result;
}

// sel1.c (710, 1)
// selSetName(sel, name) as int
// selSetName(SEL *, const char *) as l_ok
///  <summary>
/// (1) Always frees the existing sel name, if defined.<para/>
/// 
/// (2) If name is not defined, just clears any existing sel name.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selSetName/*"/>
///  <param name="sel">[in] - </param>
///  <param name="name">[in][optional] - can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int selSetName(
				 Sel sel, 
				 String name){

	int _Result = Natives.selSetName(sel.Pointer,   name);
	



	return _Result;
}

// sel1.c (732, 1)
// selaFindSelByName(sela, name, pindex, psel) as int
// selaFindSelByName(SELA *, const char *, l_int32 *, SEL **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaFindSelByName/*"/>
///  <param name="sela">[in] - </param>
///  <param name="name">[in] - sel name</param>
///  <param name="pindex">[out][optional] - </param>
///  <param name="psel">[in][optional] - sel (not a copy)</param>
///   <returns>0 if OK 1 on error</returns>
public static int selaFindSelByName(
				 Sela sela, 
				 String name, 
				out int pindex, 
				 List<Sel> psel){

	IntPtr pselPtr = 	Marshal.AllocHGlobal(Marshal.SizeOf(psel));

	int _Result = Natives.selaFindSelByName(sela.Pointer,   name, out  pindex, pselPtr);
	



	return _Result;
}

// sel1.c (781, 1)
// selGetElement(sel, row, col, ptype) as int
// selGetElement(SEL *, l_int32, l_int32, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selGetElement/*"/>
///  <param name="sel">[in] - </param>
///  <param name="row">[in] - </param>
///  <param name="col">[in] - </param>
///  <param name="ptype">[out] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
///   <returns>0 if OK 1 on error</returns>
public static int selGetElement(
				 Sel sel, 
				 int row, 
				 int col, 
				out int ptype){

	int _Result = Natives.selGetElement(sel.Pointer,   row,   col, out  ptype);
	



	return _Result;
}

// sel1.c (821, 1)
// selSetElement(sel, row, col, type) as int
// selSetElement(SEL *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Because we use row and column to index into an array,
/// they are always non-negative.  The location of the origin
/// (and the type of operation) determine the actual
/// direction of the rasterop.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selSetElement/*"/>
///  <param name="sel">[in] - </param>
///  <param name="row">[in] - </param>
///  <param name="col">[in] - </param>
///  <param name="type">[in] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
///   <returns>0 if OK 1 on error</returns>
public static int selSetElement(
				 Sel sel, 
				 int row, 
				 int col, 
				 int type){

	int _Result = Natives.selSetElement(sel.Pointer,   row,   col,   type);
	



	return _Result;
}

// sel1.c (850, 1)
// selGetParameters(sel, psy, psx, pcy, pcx) as int
// selGetParameters(SEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selGetParameters/*"/>
///  <param name="sel">[in] - </param>
///  <param name="psy">[out][optional] - each can be null</param>
///  <param name="psx">[out][optional] - each can be null</param>
///  <param name="pcy">[out][optional] - each can be null</param>
///  <param name="pcx">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int selGetParameters(
				 Sel sel, 
				out int psy, 
				out int psx, 
				out int pcy, 
				out int pcx){

	int _Result = Natives.selGetParameters(sel.Pointer, out  psy, out  psx, out  pcy, out  pcx);
	



	return _Result;
}

// sel1.c (880, 1)
// selSetOrigin(sel, cy, cx) as int
// selSetOrigin(SEL *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selSetOrigin/*"/>
///  <param name="sel">[in] - </param>
///  <param name="cy">[in] - </param>
///  <param name="cx">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int selSetOrigin(
				 Sel sel, 
				 int cy, 
				 int cx){

	int _Result = Natives.selSetOrigin(sel.Pointer,   cy,   cx);
	



	return _Result;
}

// sel1.c (902, 1)
// selGetTypeAtOrigin(sel, ptype) as int
// selGetTypeAtOrigin(SEL *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selGetTypeAtOrigin/*"/>
///  <param name="sel">[in] - </param>
///  <param name="ptype">[out] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
///   <returns>0 if OK 1 on error or if origin is not found</returns>
public static int selGetTypeAtOrigin(
				 Sel sel, 
				out int ptype){

	int _Result = Natives.selGetTypeAtOrigin(sel.Pointer, out  ptype);
	



	return _Result;
}

// sel1.c (937, 1)
// selaGetBrickName(sela, hsize, vsize) as String
// selaGetBrickName(SELA *, l_int32, l_int32) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaGetBrickName/*"/>
///  <param name="sela">[in] - </param>
///  <param name="hsize">[in] - of brick sel</param>
///  <param name="vsize">[in] - of brick sel</param>
///   <returns>sel name new string, or NULL if no name or on error</returns>
public static String selaGetBrickName(
				 Sela sela, 
				 int hsize, 
				 int vsize){

	String _Result = Natives.selaGetBrickName(sela.Pointer,   hsize,   vsize);
	



	return _Result;
}

// sel1.c (976, 1)
// selaGetCombName(sela, size, direction) as String
// selaGetCombName(SELA *, l_int32, l_int32) as char *
///  <summary>
/// (1) Combs are by definition 1-dimensional, either horiz or vert.<para/>
/// 
/// (2) Use this with comb Sels e.g., from selaAddDwaCombs().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaGetCombName/*"/>
///  <param name="sela">[in] - </param>
///  <param name="size">[in] - the product of sizes of the brick and comb parts</param>
///  <param name="direction">[in] - L_HORIZ, L_VERT</param>
///   <returns>sel name new string, or NULL if name not found or on error</returns>
public static String selaGetCombName(
				 Sela sela, 
				 int size, 
				 int direction){

	String _Result = Natives.selaGetCombName(sela.Pointer,   size,   direction);
	



	return _Result;
}

// sel1.c (1104, 1)
// getCompositeParameters(size, psize1, psize2, pnameh1, pnameh2, pnamev1, pnamev2) as int
// getCompositeParameters(l_int32, l_int32 *, l_int32 *, char **, char **, char **, char **) as l_ok
///  <summary>
/// (1) This uses the big lookup table at the top of this file.<para/>
/// 
/// (2) All returned strings are copies that must be freed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getCompositeParameters/*"/>
///  <param name="size">[in] - </param>
///  <param name="psize1">[out][optional] - brick factor size</param>
///  <param name="psize2">[out][optional] - comb factor size</param>
///  <param name="pnameh1">[out][optional] - name of horiz brick</param>
///  <param name="pnameh2">[out][optional] - name of horiz comb</param>
///  <param name="pnamev1">[out][optional] - name of vert brick</param>
///  <param name="pnamev2">[out][optional] - name of vert comb</param>
///   <returns>0 if OK, 1 on error</returns>
public static int getCompositeParameters(
				 int size, 
				out int psize1, 
				out int psize2, 
				out String[] pnameh1, 
				out String[] pnameh2, 
				out String[] pnamev1, 
				out String[] pnamev2){

	IntPtr pnameh1Ptr = IntPtr.Zero;
	IntPtr pnameh2Ptr = IntPtr.Zero;
	IntPtr pnamev1Ptr = IntPtr.Zero;
	IntPtr pnamev2Ptr = IntPtr.Zero;

	int _Result = Natives.getCompositeParameters(  size, out  psize1, out  psize2, out  pnameh1Ptr, out  pnameh2Ptr, out  pnamev1Ptr, out  pnamev2Ptr);
	

	if (pnameh1Ptr == null) {pnameh1 = null;} else { pnameh1 = null; };
	if (pnameh2Ptr == null) {pnameh2 = null;} else { pnameh2 = null; };
	if (pnamev1Ptr == null) {pnamev1 = null;} else { pnamev1 = null; };
	if (pnamev2Ptr == null) {pnamev2 = null;} else { pnamev2 = null; };


	return _Result;
}

// sel1.c (1148, 1)
// selaGetSelnames(sela) as Sarray
// selaGetSelnames(SELA *) as SARRAY *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaGetSelnames/*"/>
///  <param name="sela">[in] - </param>
///   <returns>sa of all sel names, or NULL on error</returns>
public static Sarray selaGetSelnames(
				 Sela sela){

	IntPtr _Result = Natives.selaGetSelnames(sela.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sarray(_Result);
}

// sel1.c (1193, 1)
// selFindMaxTranslations(sel, pxp, pyp, pxn, pyn) as int
// selFindMaxTranslations(SEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// These are the maximum shifts for the erosion operation.
/// For example, when j  is smaller cx, the shift of the image
/// is +x to the cx.  This is a positive xp shift.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selFindMaxTranslations/*"/>
///  <param name="sel">[in] - </param>
///  <param name="pxp">[out] - max shifts</param>
///  <param name="pyp">[out] - max shifts</param>
///  <param name="pxn">[out] - max shifts</param>
///  <param name="pyn">[out] - max shifts</param>
///   <returns>0 if OK 1 on error</returns>
public static int selFindMaxTranslations(
				 Sel sel, 
				out int pxp, 
				out int pyp, 
				out int pxn, 
				out int pyn){

	int _Result = Natives.selFindMaxTranslations(sel.Pointer, out  pxp, out  pyp, out  pxn, out  pyn);
	



	return _Result;
}

// sel1.c (1243, 1)
// selRotateOrth(sel, quads) as Sel
// selRotateOrth(SEL *, l_int32) as SEL *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selRotateOrth/*"/>
///  <param name="sel">[in] - </param>
///  <param name="quads">[in] - 0 - 4 number of 90 degree cw rotations</param>
///   <returns>seld, or NULL on error</returns>
public static Sel selRotateOrth(
				 Sel sel, 
				 int quads){

	IntPtr _Result = Natives.selRotateOrth(sel.Pointer,   quads);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (1310, 1)
// selaRead(fname) as Sela
// selaRead(const char *) as SELA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaRead/*"/>
///  <param name="fname">[in] - filename</param>
///   <returns>sela, or NULL on error</returns>
public static Sela selaRead(
				 String fname){

	IntPtr _Result = Natives.selaRead(  fname);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sela(_Result);
}

// sel1.c (1339, 1)
// selaReadStream(fp) as Sela
// selaReadStream(FILE *) as SELA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>sela, or NULL on error</returns>
public static Sela selaReadStream(
				 FILE fp){

	IntPtr _Result = Natives.selaReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sela(_Result);
}

// sel1.c (1380, 1)
// selRead(fname) as Sel
// selRead(const char *) as SEL *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selRead/*"/>
///  <param name="fname">[in] - filename</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selRead(
				 String fname){

	IntPtr _Result = Natives.selRead(  fname);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (1409, 1)
// selReadStream(fp) as Sel
// selReadStream(FILE *) as SEL *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selReadStream(
				 FILE fp){

	IntPtr _Result = Natives.selReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (1464, 1)
// selaWrite(fname, sela) as int
// selaWrite(const char *, SELA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaWrite/*"/>
///  <param name="fname">[in] - filename</param>
///  <param name="sela">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int selaWrite(
				 String fname, 
				 Sela sela){

	int _Result = Natives.selaWrite(  fname, sela.Pointer);
	



	return _Result;
}

// sel1.c (1493, 1)
// selaWriteStream(fp, sela) as int
// selaWriteStream(FILE *, SELA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="sela">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int selaWriteStream(
				 FILE fp, 
				 Sela sela){

	int _Result = Natives.selaWriteStream(fp.Pointer, sela.Pointer);
	



	return _Result;
}

// sel1.c (1526, 1)
// selWrite(fname, sel) as int
// selWrite(const char *, SEL *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selWrite/*"/>
///  <param name="fname">[in] - filename</param>
///  <param name="sel">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int selWrite(
				 String fname, 
				 Sel sel){

	int _Result = Natives.selWrite(  fname, sel.Pointer);
	



	return _Result;
}

// sel1.c (1555, 1)
// selWriteStream(fp, sel) as int
// selWriteStream(FILE *, SEL *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="sel">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int selWriteStream(
				 FILE fp, 
				 Sel sel){

	int _Result = Natives.selWriteStream(fp.Pointer, sel.Pointer);
	



	return _Result;
}

// sel1.c (1616, 1)
// selCreateFromString(text, h, w, name) as Sel
// selCreateFromString(const char *, l_int32, l_int32, const char *) as SEL *
///  <summary>
/// (1) The text is an array of chars (in row-major order) where
/// each char can be one of the following:
/// 'x': hit
/// 'o': miss
/// ' ': don't-care<para/>
/// 
/// (2) When the origin falls on a hit or miss, use an upper case
/// char (e.g., 'X' or 'O') to indicate it.  When the origin
/// falls on a don't-care, indicate this with a 'C'.
/// The string must have exactly one origin specified.<para/>
/// 
/// (3) The advantage of this method is that the text can be input
/// in a format that shows the 2D layout of the Sel e.g.,
/// \code
/// static const char seltext = "x  "
/// "x Oo "
/// "x  "
/// "xxxxx"
/// \endcode
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateFromString/*"/>
///  <param name="text">[in] - </param>
///  <param name="h">[in] - height, width</param>
///  <param name="w">[in] - height, width</param>
///  <param name="name">[in][optional] - sel name can be null</param>
///   <returns>sel of the given size, or NULL on error</returns>
public static Sel selCreateFromString(
				 String text, 
				 int h, 
				 int w, 
				 String name){

	IntPtr _Result = Natives.selCreateFromString(  text,   h,   w,   name);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (1704, 1)
// selPrintToString(sel) as String
// selPrintToString(SEL *) as char *
///  <summary>
/// (1) This is an inverse function of selCreateFromString.
/// It prints a textual representation of the SEL to a malloc'd
/// string.  The format is the same as selCreateFromString
/// except that newlines are inserted into the output
/// between rows.<para/>
/// 
/// (2) This is useful for debugging.  However, if you want to
/// save some Sels in a file, put them in a Sela and write
/// them out with selaWrite().  They can then be read in
/// with selaRead().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selPrintToString/*"/>
///  <param name="sel">[in] - </param>
///   <returns>str string caller must free</returns>
public static String selPrintToString(
				 Sel sel){

	String _Result = Natives.selPrintToString(sel.Pointer);
	



	return _Result;
}

// sel1.c (1779, 1)
// selaCreateFromFile(filename) as Sela
// selaCreateFromFile(const char *) as SELA *
///  <summary>
/// (1) The file contains a sequence of Sel descriptions.<para/>
/// 
/// (2) Each Sel is formatted as follows:
/// ~ Any number of comment lines starting with '#' are ignored
/// ~ The next line contains the selname
/// ~ The next lines contain the Sel data.  They must be
/// formatted similarly to the string format in
/// selCreateFromString(), with each line beginning and
/// ending with a double-quote, and showing the 2D layout.
/// ~ Each Sel ends when a blank line, a comment line, or
/// the end of file is reached.<para/>
/// 
/// (3) See selCreateFromString() for a description of the string
/// format for the Sel data.  As an example, here are the lines
/// of is a valid file for a single Sel.  In the file, all lines
/// are left-justified:
/// # diagonal sel
/// sel_5diag
/// "x  "
/// " x "
/// "  X  "
/// " x "
/// "  x"
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaCreateFromFile/*"/>
///  <param name="filename">[in] - </param>
///   <returns>sela, or NULL on error</returns>
public static Sela selaCreateFromFile(
				 String filename){

	IntPtr _Result = Natives.selaCreateFromFile(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sela(_Result);
}

// sel1.c (1959, 1)
// selCreateFromPta(pta, cy, cx, name) as Sel
// selCreateFromPta(PTA *, l_int32, l_int32, const char *) as SEL *
///  <summary>
/// (1) The origin and all points in the pta must be positive.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateFromPta/*"/>
///  <param name="pta">[in] - </param>
///  <param name="cy">[in] - origin of sel</param>
///  <param name="cx">[in] - origin of sel</param>
///  <param name="name">[in][optional] - sel name can be null</param>
///   <returns>sel of minimum required size, or NULL on error</returns>
public static Sel selCreateFromPta(
				 Pta pta, 
				 int cy, 
				 int cx, 
				 String name){

	IntPtr _Result = Natives.selCreateFromPta(pta.Pointer,   cy,   cx,   name);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (2009, 1)
// selCreateFromPix(pix, cy, cx, name) as Sel
// selCreateFromPix(PIX *, l_int32, l_int32, const char *) as SEL *
///  <summary>
/// (1) The origin must be positive.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateFromPix/*"/>
///  <param name="pix">[in] - </param>
///  <param name="cy">[in] - origin of sel</param>
///  <param name="cx">[in] - origin of sel</param>
///  <param name="name">[in][optional] - sel name can be null</param>
///   <returns>sel, or NULL on error</returns>
public static Sel selCreateFromPix(
				 Pix pix, 
				 int cy, 
				 int cx, 
				 String name){

	IntPtr _Result = Natives.selCreateFromPix(pix.Pointer,   cy,   cx,   name);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (2060, 1)
// selReadFromColorImage(pathname) as Sel
// selReadFromColorImage(const char *) as SEL *
///  <summary>
/// (1) Loads an image from a file and creates a (hit-miss) sel.<para/>
/// 
/// (2) The sel name is taken from the pathname without the directory
/// and extension.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selReadFromColorImage/*"/>
///  <param name="pathname">[in] - </param>
///   <returns>sel if OK NULL on error</returns>
public static Sel selReadFromColorImage(
				 String pathname){

	IntPtr _Result = Natives.selReadFromColorImage(  pathname);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (2109, 1)
// selCreateFromColorPix(pixs, selname) as Sel
// selCreateFromColorPix(PIX *, const char *) as SEL *
///  <summary>
/// (1) The sel size is given by the size of pixs.<para/>
/// 
/// (2) In pixs, hits are represented by green pixels, misses by red
/// pixels, and don't-cares by white pixels.<para/>
/// 
/// (3) In pixs, there may be no misses, but there must be at least 1 hit.<para/>
/// 
/// (4) At most there can be only one origin pixel, which is optionally
/// specified by using a lower-intensity pixel:
/// if a hit:  dark green
/// if a miss: dark red
/// if a don't care: gray
/// If there is no such pixel, the origin defaults to the approximate
/// center of the sel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selCreateFromColorPix/*"/>
///  <param name="pixs">[in] - cmapped or rgb</param>
///  <param name="selname">[in][optional] - sel name can be null</param>
///   <returns>sel if OK, NULL on error</returns>
public static Sel selCreateFromColorPix(
				 Pix pixs, 
				 String selname){

	IntPtr _Result = Natives.selCreateFromColorPix(pixs.Pointer,   selname);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Sel(_Result);
}

// sel1.c (2200, 1)
// selDisplayInPix(sel, size, gthick) as Pix
// selDisplayInPix(SEL *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This gives a visual representation of a general (hit-miss) sel.<para/>
/// 
/// (2) The empty sel is represented by a grid of intersecting lines.<para/>
/// 
/// (3) Three different patterns are generated for the sel elements:
/// ~ hit (solid black circle)
/// ~ miss (black ring inner radius is radius2)
/// ~ origin (cross, XORed with whatever is there)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selDisplayInPix/*"/>
///  <param name="sel">[in] - </param>
///  <param name="size">[in] - of grid interiors odd minimum size of 13 is enforced</param>
///  <param name="gthick">[in] - grid thickness minimum size of 2 is enforced</param>
///   <returns>pix display of sel, or NULL on error</returns>
public static Pix selDisplayInPix(
				 Sel sel, 
				 int size, 
				 int gthick){

	IntPtr _Result = Natives.selDisplayInPix(sel.Pointer,   size,   gthick);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// sel1.c (2318, 1)
// selaDisplayInPix(sela, size, gthick, spacing, ncols) as Pix
// selaDisplayInPix(SELA *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This gives a visual representation of all the sels in a sela.<para/>
/// 
/// (2) See notes in selDisplayInPix() for display params of each sel.<para/>
/// 
/// (3) This gives the nicest results when all sels in the sela
/// are the same size.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaDisplayInPix/*"/>
///  <param name="sela">[in] - </param>
///  <param name="size">[in] - of grid interiors odd minimum size of 13 is enforced</param>
///  <param name="gthick">[in] - grid thickness minimum size of 2 is enforced</param>
///  <param name="spacing">[in] - between sels, both horizontally and vertically</param>
///  <param name="ncols">[in] - number of sels per "line"</param>
///   <returns>pix display of all sels in sela, or NULL on error</returns>
public static Pix selaDisplayInPix(
				 Sela sela, 
				 int size, 
				 int gthick, 
				 int spacing, 
				 int ncols){

	IntPtr _Result = Natives.selaDisplayInPix(sela.Pointer,   size,   gthick,   spacing,   ncols);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}


}
}
