using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixabasic.c (162, 1)
// pixaCreate(n) as Pixa
// pixaCreate(l_int32) as PIXA *
///  <summary>
/// (1) This creates an empty boxa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCreate/*"/>
///  <param name="n">[in] - initial number of ptrs</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaCreate(
				 int n){

	IntPtr _Result = Natives.pixaCreate(  n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (201, 1)
// pixaCreateFromPix(pixs, n, cellw, cellh) as Pixa
// pixaCreateFromPix(PIX *, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) For bpp = 1, we truncate each retrieved pix to the ON
/// pixels, which we assume for now start at (0,0)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCreateFromPix/*"/>
///  <param name="pixs">[in] - with individual components on a lattice</param>
///  <param name="n">[in] - number of components</param>
///  <param name="cellw">[in] - width of each cell</param>
///  <param name="cellh">[in] - height of each cell</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaCreateFromPix(
				 Pix pixs, 
				 int n, 
				 int cellw, 
				 int cellh){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixaCreateFromPix(pixs.Pointer,   n,   cellw,   cellh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (264, 1)
// pixaCreateFromBoxa(pixs, boxa, pcropwarn) as Pixa
// pixaCreateFromBoxa(PIX *, BOXA *, l_int32 *) as PIXA *
///  <summary>
/// (1) This simply extracts from pixs the region corresponding to each
/// box in the boxa.<para/>
/// 
/// (2) The 3rd arg is optional.  If the extent of the boxa exceeds the
/// size of the pixa, so that some boxes are either clipped
/// or entirely outside the pix, a warning is returned as TRUE.<para/>
/// 
/// (3) pixad will have only the properly clipped elements, and
/// the internal boxa will be correct.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCreateFromBoxa/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="boxa">[in] - </param>
///  <param name="pcropwarn">[out][optional] - TRUE if the boxa extent is larger than pixs.</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaCreateFromBoxa(
				 Pix pixs, 
				 Boxa boxa, 
				out int pcropwarn){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
	IntPtr _Result = Natives.pixaCreateFromBoxa(pixs.Pointer, boxa.Pointer, out  pcropwarn);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (337, 1)
// pixaSplitPix(pixs, nx, ny, borderwidth, bordercolor) as Pixa
// pixaSplitPix(PIX *, l_int32, l_int32, l_int32, l_uint32) as PIXA *
///  <summary>
/// (1) This is a variant on pixaCreateFromPix(), where we
/// simply divide the image up into (approximately) equal
/// subunits.  If you want the subimages to have essentially
/// the same aspect ratio as the input pix, use nx = ny.<para/>
/// 
/// (2) If borderwidth is 0, we ignore the input bordercolor and
/// redefine it to white.<para/>
/// 
/// (3) The bordercolor is always used to initialize each tiled pix,
/// so that if the src is clipped, the unblitted part will
/// be this color.  This avoids 1 pixel wide black stripes at the
/// left and lower edges.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSplitPix/*"/>
///  <param name="pixs">[in] - with individual components on a lattice</param>
///  <param name="nx">[in] - number of mosaic cells horizontally</param>
///  <param name="ny">[in] - number of mosaic cells vertically</param>
///  <param name="borderwidth">[in] - of added border on all sides</param>
///  <param name="bordercolor">[in] - in our RGBA format: 0xrrggbbaa</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaSplitPix(
				 Pix pixs, 
				 int nx, 
				 int ny, 
				 int borderwidth, 
				 uint bordercolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixaSplitPix(pixs.Pointer,   nx,   ny,   borderwidth,   bordercolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (399, 1)
// pixaDestroy(ppixa) as Object
// pixaDestroy(PIXA **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the pixa.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDestroy/*"/>
///  <param name="ppixa">[in,out]can be null - ed</param>
public static void pixaDestroy(
				ref Pixa ppixa){

	IntPtr ppixaPtr = IntPtr.Zero; 	if (ppixa != null) {ppixaPtr = ppixa.Pointer;}

	Natives.pixaDestroy(ref ppixaPtr);
	
	if (ppixaPtr == IntPtr.Zero) {ppixa = null;} else { ppixa = new Pixa(ppixaPtr); };
}

// pixabasic.c (441, 1)
// pixaCopy(pixa, copyflag) as Pixa
// pixaCopy(PIXA *, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCopy/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="copyflag">[in] - see pix.h for details: L_COPY makes a new pixa and copies each pix and each box L_CLONE gives a new ref-counted handle to the input pixa L_COPY_CLONE makes a new pixa and inserts clones of all pix and boxes</param>
///   <returns>new pixa, or NULL on error</returns>
public static Pixa pixaCopy(
				 Pixa pixa, 
				 int copyflag){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaCopy(pixa.Pointer,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (494, 1)
// pixaAddPix(pixa, pix, copyflag) as int
// pixaAddPix(PIXA *, PIX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddPix/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pix">[in] - to be added</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaAddPix(
				 Pixa pixa, 
				 Pix pix, 
				 int copyflag){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.pixaAddPix(pixa.Pointer, pix.Pointer,   copyflag);
	
	return _Result;
}

// pixabasic.c (538, 1)
// pixaAddBox(pixa, box, copyflag) as int
// pixaAddBox(PIXA *, BOX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddBox/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="box">[in] - </param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaAddBox(
				 Pixa pixa, 
				 Box box, 
				 int copyflag){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}
	int _Result = Natives.pixaAddBox(pixa.Pointer, box.Pointer,   copyflag);
	
	return _Result;
}

// pixabasic.c (593, 1)
// pixaExtendArrayToSize(pixa, size) as int
// pixaExtendArrayToSize(PIXA *, l_int32) as l_ok
///  <summary>
/// (1) If necessary, reallocs new pixa and boxa ptrs arrays to %size.
/// The pixa and boxa ptr arrays must always be equal in size.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaExtendArrayToSize/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="size">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaExtendArrayToSize(
				 Pixa pixa, 
				 int size){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaExtendArrayToSize(pixa.Pointer,   size);
	
	return _Result;
}

// pixabasic.c (622, 1)
// pixaGetCount(pixa) as int
// pixaGetCount(PIXA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetCount/*"/>
///  <param name="pixa">[in] - </param>
///   <returns>count, or 0 if no pixa</returns>
public static int pixaGetCount(
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaGetCount(pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (641, 1)
// pixaChangeRefcount(pixa, delta) as int
// pixaChangeRefcount(PIXA *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaChangeRefcount/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="delta">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaChangeRefcount(
				 Pixa pixa, 
				 int delta){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaChangeRefcount(pixa.Pointer,   delta);
	
	return _Result;
}

// pixabasic.c (663, 1)
// pixaGetPix(pixa, index, accesstype) as Pix
// pixaGetPix(PIXA *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetPix/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - to the index-th pix</param>
///  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixaGetPix(
				 Pixa pixa, 
				 int index, 
				 int accesstype){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaGetPix(pixa.Pointer,   index,   accesstype);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixabasic.c (698, 1)
// pixaGetPixDimensions(pixa, index, pw, ph, pd) as int
// pixaGetPixDimensions(PIXA *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetPixDimensions/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - to the index-th box</param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///  <param name="pd">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaGetPixDimensions(
				 Pixa pixa, 
				 int index, 
				out int pw, 
				out int ph, 
				out int pd){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaGetPixDimensions(pixa.Pointer,   index, out  pw, out  ph, out  pd);
	
	return _Result;
}

// pixabasic.c (732, 1)
// pixaGetBoxa(pixa, accesstype) as Boxa
// pixaGetBoxa(PIXA *, l_int32) as BOXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetBoxa/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
///   <returns>boxa, or NULL on error</returns>
public static Boxa pixaGetBoxa(
				 Pixa pixa, 
				 int accesstype){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaGetBoxa(pixa.Pointer,   accesstype);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Boxa(_Result);
}

// pixabasic.c (756, 1)
// pixaGetBoxaCount(pixa) as int
// pixaGetBoxaCount(PIXA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetBoxaCount/*"/>
///  <param name="pixa">[in] - </param>
///   <returns>count, or 0 on error</returns>
public static int pixaGetBoxaCount(
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaGetBoxaCount(pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (788, 1)
// pixaGetBox(pixa, index, accesstype) as Box
// pixaGetBox(PIXA *, l_int32, l_int32) as BOX *
///  <summary>
/// (1) There is always a boxa with a pixa, and it is initialized so
/// that each box ptr is NULL.<para/>
/// 
/// (2) In general, we expect that there is either a box associated
/// with each pix, or no boxes at all in the boxa.<para/>
/// 
/// (3) Having no boxes is thus not an automatic error.  Whether it
/// is an actual error is determined by the calling program.
/// If the caller expects to get a box, it is an error see, e.g.,
/// pixaGetBoxGeometry().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetBox/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - to the index-th pix</param>
///  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
///   <returns>box if null, not automatically an error, or NULL on error</returns>
public static Box pixaGetBox(
				 Pixa pixa, 
				 int index, 
				 int accesstype){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaGetBox(pixa.Pointer,   index,   accesstype);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Box(_Result);
}

// pixabasic.c (826, 1)
// pixaGetBoxGeometry(pixa, index, px, py, pw, ph) as int
// pixaGetBoxGeometry(PIXA *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetBoxGeometry/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - to the index-th box</param>
///  <param name="px">[out][optional] - each can be null</param>
///  <param name="py">[out][optional] - each can be null</param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaGetBoxGeometry(
				 Pixa pixa, 
				 int index, 
				out int px, 
				out int py, 
				out int pw, 
				out int ph){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaGetBoxGeometry(pixa.Pointer,   index, out  px, out  py, out  pw, out  ph);
	
	return _Result;
}

// pixabasic.c (868, 1)
// pixaSetBoxa(pixa, boxa, accesstype) as int
// pixaSetBoxa(PIXA *, BOXA *, l_int32) as l_ok
///  <summary>
/// (1) This destroys the existing boxa in the pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSetBoxa/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="boxa">[in] - </param>
///  <param name="accesstype">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSetBoxa(
				 Pixa pixa, 
				 Boxa boxa, 
				 int accesstype){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
	int _Result = Natives.pixaSetBoxa(pixa.Pointer, boxa.Pointer,   accesstype);
	
	return _Result;
}

// pixabasic.c (907, 1)
// pixaGetPixArray(pixa) as Pix
// pixaGetPixArray(PIXA *) as PIX **
///  <summary>
/// (1) This returns a ptr to the actual array.  The array is
/// owned by the pixa, so it must not be destroyed.<para/>
/// 
/// (2) The caller should always check if the return value is NULL
/// before accessing any of the pix ptrs in this array!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetPixArray/*"/>
///  <param name="pixa">[in] - </param>
///   <returns>pix array, or NULL on error</returns>
public static Pix pixaGetPixArray(
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaGetPixArray(pixa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	Pix B = new Pix(_Result);
	return B;
}

// pixabasic.c (932, 1)
// pixaVerifyDepth(pixa, psame, pmaxd) as int
// pixaVerifyDepth(PIXA *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) It is considered to be an error if there are no pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaVerifyDepth/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="psame">[out] - 1 if depth is the same for all pix 0 otherwise</param>
///  <param name="pmaxd">[out][optional] - max depth of all pix</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaVerifyDepth(
				 Pixa pixa, 
				out int psame, 
				out int pmaxd){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaVerifyDepth(pixa.Pointer, out  psame, out  pmaxd);
	
	return _Result;
}

// pixabasic.c (978, 1)
// pixaVerifyDimensions(pixa, psame, pmaxw, pmaxh) as int
// pixaVerifyDimensions(PIXA *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) It is considered to be an error if there are no pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaVerifyDimensions/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="psame">[out] - 1 if dimensions are the same for all pix 0 otherwise</param>
///  <param name="pmaxw">[out][optional] - max width of all pix</param>
///  <param name="pmaxh">[out][optional] - max height of all pix</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaVerifyDimensions(
				 Pixa pixa, 
				out int psame, 
				out int pmaxw, 
				out int pmaxh){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaVerifyDimensions(pixa.Pointer, out  psame, out  pmaxw, out  pmaxh);
	
	return _Result;
}

// pixabasic.c (1029, 1)
// pixaIsFull(pixa, pfullpa, pfullba) as int
// pixaIsFull(PIXA *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) A pixa is "full" if the array of pix is fully
/// occupied from index 0 to index (pixaton - 1).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaIsFull/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pfullpa">[out][optional] - 1 if pixa is full</param>
///  <param name="pfullba">[out][optional] - 1 if boxa is full</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaIsFull(
				 Pixa pixa, 
				out int pfullpa, 
				out int pfullba){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaIsFull(pixa.Pointer, out  pfullpa, out  pfullba);
	
	return _Result;
}

// pixabasic.c (1079, 1)
// pixaCountText(pixa, pntext) as int
// pixaCountText(PIXA *, l_int32 *) as l_ok
///  <summary>
/// (1) All pix have non-empty text strings if the returned value %ntext
/// equals the pixa count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCountText/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pntext">[out] - number of pix with non-empty text strings</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixaCountText(
				 Pixa pixa, 
				out int pntext){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaCountText(pixa.Pointer, out  pntext);
	
	return _Result;
}

// pixabasic.c (1122, 1)
// pixaSetText(pixa, sa) as int
// pixaSetText(PIXA *, SARRAY *) as l_ok
///  <summary>
/// (1) To clear all the text fields, use sa == NULL<para/>
/// 
/// (2) If sa is defined, it must be the same size as %pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSetText/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="sa">[in][optional] - array of text strings, to insert in each pix</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixaSetText(
				 Pixa pixa, 
				 Sarray sa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr saPtr = IntPtr.Zero; 	if (sa != null) {saPtr = sa.Pointer;}

	int _Result = Natives.pixaSetText(pixa.Pointer, saPtr);
	
	return _Result;
}

// pixabasic.c (1180, 1)
// pixaGetLinePtrs(pixa, psize) as IntPtr
// pixaGetLinePtrs(PIXA *, l_int32 *) as void ***
///  <summary>
/// (1) See pixGetLinePtrs() for details.<para/>
/// 
/// (2) It is best if all pix in the pixa are the same size.
/// The size of each line ptr array is equal to the height
/// of the pix that it refers to.<para/>
/// 
/// (3) This is an array of arrays.  To destroy it:
/// for (i = 0 i  is smaller size i++)
/// LEPT_FREE(lineset[i])
/// LEPT_FREE(lineset)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetLinePtrs/*"/>
///  <param name="pixa">[in] - of pix that all have the same depth</param>
///  <param name="psize">[out][optional] - number of pix in the pixa</param>
///   <returns>array of array of line ptrs, or NULL on error</returns>
public static IntPtr pixaGetLinePtrs(
				 Pixa pixa, 
				out int psize){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaGetLinePtrs(pixa.Pointer, out  psize);
	
	return _Result;
}

// pixabasic.c (1228, 1)
// pixaWriteStreamInfo(fp, pixa) as int
// pixaWriteStreamInfo(FILE *, PIXA *) as l_ok
///  <summary>
/// (1) For each pix in the pixa, write out the pix dimensions, spp,
/// text string (if it exists), and cmap info.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteStreamInfo/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixaWriteStreamInfo(
				 FILE fp, 
				 Pixa pixa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaWriteStreamInfo(fp.Pointer, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (1286, 1)
// pixaReplacePix(pixa, index, pix, box) as int
// pixaReplacePix(PIXA *, l_int32, PIX *, BOX *) as l_ok
///  <summary>
/// (1) In-place replacement of one pix.<para/>
/// 
/// (2) The previous pix at that location is destroyed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReplacePix/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - to the index-th pix</param>
///  <param name="pix">[in] - insert to replace existing one</param>
///  <param name="box">[in][optional] - insert to replace existing</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaReplacePix(
				 Pixa pixa, 
				 int index, 
				 Pix pix, 
				 Box box){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixaReplacePix(pixa.Pointer,   index, pix.Pointer, boxPtr);
	
	return _Result;
}

// pixabasic.c (1336, 1)
// pixaInsertPix(pixa, index, pixs, box) as int
// pixaInsertPix(PIXA *, l_int32, PIX *, BOX *) as l_ok
///  <summary>
/// (1) This shifts pixa[i] to pixa[i + 1] for all i greater or equal index,
/// and then inserts at pixa[index].<para/>
/// 
/// (2) To insert at the beginning of the array, set index = 0.<para/>
/// 
/// (3) It should not be used repeatedly on large arrays,
/// because the function is O(n).<para/>
/// 
/// (4) To append a pix to a pixa, it's easier to use pixaAddPix().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaInsertPix/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - at which pix is to be inserted</param>
///  <param name="pixs">[in] - new pix to be inserted</param>
///  <param name="box">[in][optional] - new box to be inserted</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaInsertPix(
				 Pixa pixa, 
				 int index, 
				 Pix pixs, 
				 Box box){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixaInsertPix(pixa.Pointer,   index, pixs.Pointer, boxPtr);
	
	return _Result;
}

// pixabasic.c (1386, 1)
// pixaRemovePix(pixa, index) as int
// pixaRemovePix(PIXA *, l_int32) as l_ok
///  <summary>
/// (1) This shifts pixa[i] to pixa[i - 1] for all i  is greater  index.<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).<para/>
/// 
/// (3) The corresponding box is removed as well, if it exists.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRemovePix/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - of pix to be removed</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaRemovePix(
				 Pixa pixa, 
				 int index){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaRemovePix(pixa.Pointer,   index);
	
	return _Result;
}

// pixabasic.c (1438, 1)
// pixaRemovePixAndSave(pixa, index, ppix, pbox) as int
// pixaRemovePixAndSave(PIXA *, l_int32, PIX **, BOX **) as l_ok
///  <summary>
/// (1) This shifts pixa[i] to pixa[i - 1] for all i  is greater  index.<para/>
/// 
/// (2) It should not be used repeatedly on large arrays,
/// because the function is O(n).<para/>
/// 
/// (3) The corresponding box is removed as well, if it exists.<para/>
/// 
/// (4) The removed pix and box can either be retained or destroyed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRemovePixAndSave/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="index">[in] - of pix to be removed</param>
///  <param name="ppix">[out][optional] - removed pix</param>
///  <param name="pbox">[out][optional] - removed box</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaRemovePixAndSave(
				 Pixa pixa, 
				 int index, 
				out Pix ppix, 
				out Box pbox){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr ppixPtr = IntPtr.Zero;
	IntPtr pboxPtr = IntPtr.Zero;

	int _Result = Natives.pixaRemovePixAndSave(pixa.Pointer,   index, out ppixPtr, out pboxPtr);
	
	if (ppixPtr == IntPtr.Zero) {ppix = null;} else { ppix = new Pix(ppixPtr); };
	if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };
	return _Result;
}

// pixabasic.c (1513, 1)
// pixaInitFull(pixa, pix, box) as int
// pixaInitFull(PIXA *, PIX *, BOX *) as l_ok
///  <summary>
/// (1) This initializes a pixa by filling up the entire pix ptr array
/// with copies of %pix.  If %pix == NULL, we use a tiny placeholder
/// pix (w = h = d = 1).  Any existing pix are destroyed.
/// It also optionally fills the boxa with copies of %box.
/// After this operation, the numbers of pix and (optionally)
/// boxes are equal to the number of allocated ptrs.<para/>
/// 
/// (2) Note that we use pixaReplacePix() instead of pixaInsertPix().
/// They both have the same effect when inserting into a NULL ptr
/// in the pixa ptr array:<para/>
/// 
/// (3) If the boxa is not initialized (i.e., filled with boxes),
/// later insertion of boxes will cause an error, because the
/// 'n' field is 0.<para/>
/// 
/// (4) Example usage.  This function is useful to prepare for a
/// random insertion (or replacement) of pix into a pixa.
/// To randomly insert pix into a pixa, without boxes, up to
/// some index "max":
/// Pixa pixa = pixaCreate(max)
/// pixaInitFull(pixa, NULL, NULL)
/// An existing pixa with a smaller ptr array can also be reused:
/// pixaExtendArrayToSize(pixa, max)
/// pixaInitFull(pixa, NULL, NULL)
/// The initialization allows the pixa to always be properly
/// filled, even if all pix (and boxes) are not later replaced.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaInitFull/*"/>
///  <param name="pixa">[in] - typically empty</param>
///  <param name="pix">[in][optional] - to be replicated into the entire pixa ptr array</param>
///  <param name="box">[in][optional] - to be replicated into the entire boxa ptr array</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaInitFull(
				 Pixa pixa, 
				 Pix pix, 
				 Box box){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr pixPtr = IntPtr.Zero; 	if (pix != null) {pixPtr = pix.Pointer;}
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixaInitFull(pixa.Pointer, pixPtr, boxPtr);
	
	return _Result;
}

// pixabasic.c (1555, 1)
// pixaClear(pixa) as int
// pixaClear(PIXA *) as l_ok
///  <summary>
/// (1) This destroys all pix in the pixa, as well as
/// all boxes in the boxa.  The ptrs in the pix ptr array
/// are all null'd.  The number of allocated pix, n, is set to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaClear/*"/>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaClear(
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaClear(pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (1593, 1)
// pixaJoin(pixad, pixas, istart, iend) as int
// pixaJoin(PIXA *, PIXA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This appends a clone of each indicated pix in pixas to pixad<para/>
/// 
/// (2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (3) iend  is smaller 0 means 'read to the end'<para/>
/// 
/// (4) If pixas is NULL or contains no pix, this is a no-op.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaJoin/*"/>
///  <param name="pixad">[in] - dest pixa add to this one</param>
///  <param name="pixas">[in][optional] - source pixa add from this one</param>
///  <param name="istart">[in] - starting index in pixas</param>
///  <param name="iend">[in] - ending index in pixas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaJoin(
				 Pixa pixad, 
				 Pixa pixas, 
				 int istart, 
				 int iend){

if (pixad == null) {throw new ArgumentNullException  ("pixad cannot be Nothing");}
	IntPtr pixasPtr = IntPtr.Zero; 	if (pixas != null) {pixasPtr = pixas.Pointer;}

	int _Result = Natives.pixaJoin(pixad.Pointer, pixasPtr,   istart,   iend);
	
	return _Result;
}

// pixabasic.c (1649, 1)
// pixaInterleave(pixa1, pixa2, copyflag) as Pixa
// pixaInterleave(PIXA *, PIXA *, l_int32) as PIXA *
///  <summary>
/// (1) %copyflag determines if the pix are copied or cloned.
/// The boxes, if they exist, are copied.<para/>
/// 
/// (2) If the two pixa have different sizes, a warning is issued,
/// and the number of pairs returned is the minimum size.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaInterleave/*"/>
///  <param name="pixa1">[in] - first src pixa</param>
///  <param name="pixa2">[in] - second src pixa</param>
///  <param name="copyflag">[in] - L_CLONE, L_COPY</param>
///   <returns>pixa  interleaved from sources, or NULL on error.</returns>
public static Pixa pixaInterleave(
				 Pixa pixa1, 
				 Pixa pixa2, 
				 int copyflag){

if (pixa1 == null) {throw new ArgumentNullException  ("pixa1 cannot be Nothing");}
		if (pixa2 == null) {throw new ArgumentNullException  ("pixa2 cannot be Nothing");}
	IntPtr _Result = Natives.pixaInterleave(pixa1.Pointer, pixa2.Pointer,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (1714, 1)
// pixaaJoin(paad, paas, istart, iend) as int
// pixaaJoin(PIXAA *, PIXAA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This appends a clone of each indicated pixa in paas to pixaad<para/>
/// 
/// (2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (3) iend  is smaller 0 means 'read to the end'
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaJoin/*"/>
///  <param name="paad">[in] - dest pixaa add to this one</param>
///  <param name="paas">[in][optional] - source pixaa add from this one</param>
///  <param name="istart">[in] - starting index in pixaas</param>
///  <param name="iend">[in] - ending index in pixaas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaJoin(
				 Pixaa paad, 
				 Pixaa paas, 
				 int istart, 
				 int iend){

if (paad == null) {throw new ArgumentNullException  ("paad cannot be Nothing");}
	IntPtr paasPtr = IntPtr.Zero; 	if (paas != null) {paasPtr = paas.Pointer;}

	int _Result = Natives.pixaaJoin(paad.Pointer, paasPtr,   istart,   iend);
	
	return _Result;
}

// pixabasic.c (1772, 1)
// pixaaCreate(n) as Pixaa
// pixaaCreate(l_int32) as PIXAA *
///  <summary>
/// (1) A pixaa provides a 2-level hierarchy of images.
/// A common use is for segmentation masks, which are
/// inexpensive to store in png format.<para/>
/// 
/// (2) For example, suppose you want a mask for each textline
/// in a two-column page.  The textline masks for each column
/// can be represented by a pixa, of which there are 2 in the pixaa.
/// The boxes for the textline mask components within a column
/// can have their origin referred to the column rather than the page.
/// Then the boxa field can be used to represent the two box (regions)
/// for the columns, and the (x,y) components of each box can
/// be used to get the absolute position of the textlines on
/// the page.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaCreate/*"/>
///  <param name="n">[in] - initial number of pixa ptrs</param>
///   <returns>paa, or NULL on error</returns>
public static Pixaa pixaaCreate(
				 int n){

	IntPtr _Result = Natives.pixaaCreate(  n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (1817, 1)
// pixaaCreateFromPixa(pixa, n, type, copyflag) as Pixaa
// pixaaCreateFromPixa(PIXA *, l_int32, l_int32, l_int32) as PIXAA *
///  <summary>
/// (1) This subdivides a pixa into a set of smaller pixa that
/// are accumulated into a pixaa.<para/>
/// 
/// (2) If type == L_CHOOSE_CONSECUTIVE, the first 'n' pix are
/// put in a pixa and added to pixaa, then the next 'n', etc.
/// If type == L_CHOOSE_SKIP_BY, the first pixa is made by
/// aggregating pix[0], pix[n], pix[2n], etc.<para/>
/// 
/// (3) The copyflag specifies if each new pix is a copy or a clone.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaCreateFromPixa/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="n">[in] - number specifying subdivision of pixa</param>
///  <param name="type">[in] - L_CHOOSE_CONSECUTIVE, L_CHOOSE_SKIP_BY</param>
///  <param name="copyflag">[in] - L_CLONE, L_COPY</param>
///   <returns>paa, or NULL on error</returns>
public static Pixaa pixaaCreateFromPixa(
				 Pixa pixa, 
				 int n, 
				 int type, 
				 int copyflag){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr _Result = Natives.pixaaCreateFromPixa(pixa.Pointer,   n,   type,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (1879, 1)
// pixaaDestroy(ppaa) as Object
// pixaaDestroy(PIXAA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaDestroy/*"/>
///  <param name="ppaa">[in,out] - to be nulled</param>
public static void pixaaDestroy(
				ref Pixaa ppaa){

	IntPtr ppaaPtr = IntPtr.Zero; 	if (ppaa != null) {ppaaPtr = ppaa.Pointer;}

	Natives.pixaaDestroy(ref ppaaPtr);
	
	if (ppaaPtr == IntPtr.Zero) {ppaa = null;} else { ppaa = new Pixaa(ppaaPtr); };
}

// pixabasic.c (1923, 1)
// pixaaAddPixa(paa, pixa, copyflag) as int
// pixaaAddPixa(PIXAA *, PIXA *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaAddPixa/*"/>
///  <param name="paa">[in] - </param>
///  <param name="pixa">[in] - to be added</param>
///  <param name="copyflag">[in] - : L_INSERT inserts the pixa directly L_COPY makes a new pixa and copies each pix and each box L_CLONE gives a new handle to the input pixa L_COPY_CLONE makes a new pixa and inserts clones of all pix and boxes</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaaAddPixa(
				 Pixaa paa, 
				 Pixa pixa, 
				 int copyflag){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaaAddPixa(paa.Pointer, pixa.Pointer,   copyflag);
	
	return _Result;
}

// pixabasic.c (1964, 1)
// pixaaExtendArray(paa) as int
// pixaaExtendArray(PIXAA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaExtendArray/*"/>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaaExtendArray(
				 Pixaa paa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaExtendArray(paa.Pointer);
	
	return _Result;
}

// pixabasic.c (1992, 1)
// pixaaAddPix(paa, index, pix, box, copyflag) as int
// pixaaAddPix(PIXAA *, l_int32, PIX *, BOX *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaAddPix/*"/>
///  <param name="paa">[in] - input paa</param>
///  <param name="index">[in] - index of pixa in paa</param>
///  <param name="pix">[in] - to be added</param>
///  <param name="box">[in][optional] - to be added</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaaAddPix(
				 Pixaa paa, 
				 int index, 
				 Pix pix, 
				 Box box, 
				 int copyflag){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	int _Result = Natives.pixaaAddPix(paa.Pointer,   index, pix.Pointer, boxPtr,   copyflag);
	
	return _Result;
}

// pixabasic.c (2031, 1)
// pixaaAddBox(paa, box, copyflag) as int
// pixaaAddBox(PIXAA *, BOX *, l_int32) as l_ok
///  <summary>
/// (1) The box can be used, for example, to hold the support region
/// of a pixa that is being added to the pixaa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaAddBox/*"/>
///  <param name="paa">[in] - </param>
///  <param name="box">[in] - </param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaAddBox(
				 Pixaa paa, 
				 Box box, 
				 int copyflag){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
		if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}
	int _Result = Natives.pixaaAddBox(paa.Pointer, box.Pointer,   copyflag);
	
	return _Result;
}

// pixabasic.c (2066, 1)
// pixaaGetCount(paa, pna) as int
// pixaaGetCount(PIXAA *, NUMA **) as l_int32
///  <summary>
/// (1) If paa is empty, a returned na will also be empty.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaGetCount/*"/>
///  <param name="paa">[in] - </param>
///  <param name="pna">[out][optional] - number of pix in each pixa</param>
///   <returns>count, or 0 if no pixaa</returns>
public static int pixaaGetCount(
				 Pixaa paa, 
				out Numa pna){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	IntPtr pnaPtr = IntPtr.Zero;

	int _Result = Natives.pixaaGetCount(paa.Pointer, out pnaPtr);
	
	if (pnaPtr == IntPtr.Zero) {pna = null;} else { pna = new Numa(pnaPtr); };
	return _Result;
}

// pixabasic.c (2115, 1)
// pixaaGetPixa(paa, index, accesstype) as Pixa
// pixaaGetPixa(PIXAA *, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) L_COPY makes a new pixa with a copy of every pix<para/>
/// 
/// (2) L_CLONE just makes a new reference to the pixa,
/// and bumps the counter.  You would use this, for example,
/// when you need to extract some data from a pix within a
/// pixa within a pixaa.<para/>
/// 
/// (3) L_COPY_CLONE makes a new pixa with a clone of every pix
/// and box<para/>
/// 
/// (4) In all cases, you must invoke pixaDestroy() on the returned pixa
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaGetPixa/*"/>
///  <param name="paa">[in] - </param>
///  <param name="index">[in] - to the index-th pixa</param>
///  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaaGetPixa(
				 Pixaa paa, 
				 int index, 
				 int accesstype){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	IntPtr _Result = Natives.pixaaGetPixa(paa.Pointer,   index,   accesstype);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (2153, 1)
// pixaaGetBoxa(paa, accesstype) as Boxa
// pixaaGetBoxa(PIXAA *, l_int32) as BOXA *
///  <summary>
/// (1) L_COPY returns a copy L_CLONE returns a new reference to the boxa.<para/>
/// 
/// (2) In both cases, invoke boxaDestroy() on the returned boxa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaGetBoxa/*"/>
///  <param name="paa">[in] - </param>
///  <param name="accesstype">[in] - L_COPY, L_CLONE</param>
///   <returns>boxa, or NULL on error</returns>
public static Boxa pixaaGetBoxa(
				 Pixaa paa, 
				 int accesstype){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	IntPtr _Result = Natives.pixaaGetBoxa(paa.Pointer,   accesstype);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Boxa(_Result);
}

// pixabasic.c (2177, 1)
// pixaaGetPix(paa, index, ipix, accessflag) as Pix
// pixaaGetPix(PIXAA *, l_int32, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaGetPix/*"/>
///  <param name="paa">[in] - </param>
///  <param name="index">[in] - index into the pixa array in the pixaa</param>
///  <param name="ipix">[in] - index into the pix array in the pixa</param>
///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixaaGetPix(
				 Pixaa paa, 
				 int index, 
				 int ipix, 
				 int accessflag){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	IntPtr _Result = Natives.pixaaGetPix(paa.Pointer,   index,   ipix,   accessflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixabasic.c (2210, 1)
// pixaaVerifyDepth(paa, psame, pmaxd) as int
// pixaaVerifyDepth(PIXAA *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) It is considered to be an error if any pixa have no pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaVerifyDepth/*"/>
///  <param name="paa">[in] - </param>
///  <param name="psame">[out] - 1 if all pix have the same depth 0 otherwise</param>
///  <param name="pmaxd">[out][optional] - max depth of all pix in pixaa</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaaVerifyDepth(
				 Pixaa paa, 
				out int psame, 
				out int pmaxd){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaVerifyDepth(paa.Pointer, out  psame, out  pmaxd);
	
	return _Result;
}

// pixabasic.c (2260, 1)
// pixaaVerifyDimensions(paa, psame, pmaxw, pmaxh) as int
// pixaaVerifyDimensions(PIXAA *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) It is considered to be an error if any pixa have no pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaVerifyDimensions/*"/>
///  <param name="paa">[in] - </param>
///  <param name="psame">[out] - 1 if all pix have the same depth 0 otherwise</param>
///  <param name="pmaxw">[out][optional] - max width of all pix in pixaa</param>
///  <param name="pmaxh">[out][optional] - max height of all pix in pixaa</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaaVerifyDimensions(
				 Pixaa paa, 
				out int psame, 
				out int pmaxw, 
				out int pmaxh){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaVerifyDimensions(paa.Pointer, out  psame, out  pmaxw, out  pmaxh);
	
	return _Result;
}

// pixabasic.c (2314, 1)
// pixaaIsFull(paa, pfull) as int
// pixaaIsFull(PIXAA *, l_int32 *) as l_int32
///  <summary>
/// (1) Does not require boxa associated with each pixa to be full.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaIsFull/*"/>
///  <param name="paa">[in] - </param>
///  <param name="pfull">[out] - 1 if all pixa in the paa have full pix arrays</param>
///   <returns>return 0 if OK, 1 on error</returns>
public static int pixaaIsFull(
				 Pixaa paa, 
				out int pfull){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaIsFull(paa.Pointer, out  pfull);
	
	return _Result;
}

// pixabasic.c (2366, 1)
// pixaaInitFull(paa, pixa) as int
// pixaaInitFull(PIXAA *, PIXA *) as l_ok
///  <summary>
/// (1) This initializes a pixaa by filling up the entire pixa ptr array
/// with copies of %pixa.  Any existing pixa are destroyed.<para/>
/// 
/// (2) Example usage.  This function is useful to prepare for a
/// random insertion (or replacement) of pixa into a pixaa.
/// To randomly insert pixa into a pixaa, up to some index "max":
/// Pixaa paa = pixaaCreate(max)
/// Pixa pixa = pixaCreate(1)  // if you want little memory
/// pixaaInitFull(paa, pixa)  // copy it to entire array
/// pixaDestroy([and]pixa)  // no longer needed
/// The initialization allows the pixaa to always be properly filled.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaInitFull/*"/>
///  <param name="paa">[in] - typically empty</param>
///  <param name="pixa">[in] - to be replicated into the entire pixa ptr array</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaInitFull(
				 Pixaa paa, 
				 Pixa pixa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaaInitFull(paa.Pointer, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (2408, 1)
// pixaaReplacePixa(paa, index, pixa) as int
// pixaaReplacePixa(PIXAA *, l_int32, PIXA *) as l_ok
///  <summary>
/// (1) This allows random insertion of a pixa into a pixaa, with
/// destruction of any existing pixa at that location.
/// The input pixa is now owned by the pixaa.<para/>
/// 
/// (2) No other pixa in the array are affected.<para/>
/// 
/// (3) The index must be within the allowed set.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaReplacePixa/*"/>
///  <param name="paa">[in] - </param>
///  <param name="index">[in] - to the index-th pixa</param>
///  <param name="pixa">[in] - insert to replace existing one</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaReplacePixa(
				 Pixaa paa, 
				 int index, 
				 Pixa pixa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaaReplacePixa(paa.Pointer,   index, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (2441, 1)
// pixaaClear(paa) as int
// pixaaClear(PIXAA *) as l_ok
///  <summary>
/// (1) This destroys all pixa in the pixaa, and nulls the ptrs
/// in the pixa ptr array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaClear/*"/>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaClear(
				 Pixaa paa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaClear(paa.Pointer);
	
	return _Result;
}

// pixabasic.c (2472, 1)
// pixaaTruncate(paa) as int
// pixaaTruncate(PIXAA *) as l_ok
///  <summary>
/// (1) This identifies the largest index containing a pixa that
/// has any pix within it, destroys all pixa above that index,
/// and resets the count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaTruncate/*"/>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaTruncate(
				 Pixaa paa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaTruncate(paa.Pointer);
	
	return _Result;
}

// pixabasic.c (2519, 1)
// pixaRead(filename) as Pixa
// pixaRead(const char *) as PIXA *
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaRead(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {
	   throw new ArgumentException ("File is missing");
	};
	IntPtr _Result = Natives.pixaRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (2556, 1)
// pixaReadStream(fp) as Pixa
// pixaReadStream(FILE *) as PIXA *
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.pixaReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (2615, 1)
// pixaReadMem(data, size) as Pixa
// pixaReadMem(const l_uint8 *, size_t) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadMem/*"/>
///  <param name="data">[in] - of serialized pixa</param>
///  <param name="size">[in] - of data in bytes</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaReadMem(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.pixaReadMem(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (2652, 1)
// pixaWriteDebug(fname, pixa) as int
// pixaWriteDebug(const char *, PIXA *) as l_ok
///  <summary>
/// (1) Debug version, intended for use in the library when writing
/// to files in a temp directory with names that are compiled in.
/// This is used instead of pixaWrite() for all such library calls.<para/>
/// 
/// (2) The global variable LeptDebugOK defaults to 0, and can be set
/// or cleared by the function setLeptDebugOK().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteDebug/*"/>
///  <param name="fname">[in] - </param>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaWriteDebug(
				 String fname, 
				 Pixa pixa){

if (fname == null) {throw new ArgumentNullException  ("fname cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaWriteDebug(  fname, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (2680, 1)
// pixaWrite(filename, pixa) as int
// pixaWrite(const char *, PIXA *) as l_ok
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaWrite(
				 String filename, 
				 Pixa pixa){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaWrite(  filename, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (2721, 1)
// pixaWriteStream(fp, pixa) as int
// pixaWriteStream(FILE *, PIXA *) as l_ok
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for "wb"</param>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaWriteStream(
				 FILE fp, 
				 Pixa pixa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	int _Result = Natives.pixaWriteStream(fp.Pointer, pixa.Pointer);
	
	return _Result;
}

// pixabasic.c (2768, 1)
// pixaWriteMem(pdata, psize, pixa) as int
// pixaWriteMem(l_uint8 **, size_t *, PIXA *) as l_ok
///  <summary>
/// (1) Serializes a pixa in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized pixa</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 Pixa pixa){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixaWriteMem(out  pdataPtr, out  psize, pixa.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// pixabasic.c (2821, 1)
// pixaReadBoth(filename) as Pixa
// pixaReadBoth(const char *) as PIXA *
///  <summary>
/// (1) This reads serialized files of either a pixa or a pixacomp,
/// and returns a pixa in memory.  It requires png and jpeg libraries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadBoth/*"/>
///  <param name="filename">[in] - </param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaReadBoth(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {
	   throw new ArgumentException ("File is missing");
	};
	IntPtr _Result = Natives.pixaReadBoth(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixabasic.c (2878, 1)
// pixaaReadFromFiles(dirname, substr, first, nfiles) as Pixaa
// pixaaReadFromFiles(const char *, const char *, l_int32, l_int32) as PIXAA *
///  <summary>
/// (1) The files must be serialized pixa files (e.g., .pa)
/// If some files cannot be read, warnings are issued.<para/>
/// 
/// (2) Use %substr to filter filenames in the directory.  If
/// %substr == NULL, this takes all files.<para/>
/// 
/// (3) After filtering, use %first and %nfiles to select
/// a contiguous set of files, that have been lexically
/// sorted in increasing order.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaReadFromFiles/*"/>
///  <param name="dirname">[in] - directory</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="first">[in] - 0-based</param>
///  <param name="nfiles">[in] - use 0 for everything from %first to the end</param>
///   <returns>paa, or NULL on error or if no pixa files are found.</returns>
public static Pixaa pixaaReadFromFiles(
				 String dirname, 
				 String substr, 
				 int first, 
				 int nfiles){

if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}
	IntPtr _Result = Natives.pixaaReadFromFiles(  dirname,   substr,   first,   nfiles);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (2928, 1)
// pixaaRead(filename) as Pixaa
// pixaaRead(const char *) as PIXAA *
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>paa, or NULL on error</returns>
public static Pixaa pixaaRead(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {
	   throw new ArgumentException ("File is missing");
	};
	IntPtr _Result = Natives.pixaaRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (2965, 1)
// pixaaReadStream(fp) as Pixaa
// pixaaReadStream(FILE *) as PIXAA *
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>paa, or NULL on error</returns>
public static Pixaa pixaaReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.pixaaReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (3023, 1)
// pixaaReadMem(data, size) as Pixaa
// pixaaReadMem(const l_uint8 *, size_t) as PIXAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaReadMem/*"/>
///  <param name="data">[in] - of serialized pixaa</param>
///  <param name="size">[in] - of data in bytes</param>
///   <returns>paa, or NULL on error</returns>
public static Pixaa pixaaReadMem(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.pixaaReadMem(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixabasic.c (3057, 1)
// pixaaWrite(filename, paa) as int
// pixaaWrite(const char *, PIXAA *) as l_ok
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaWrite(
				 String filename, 
				 Pixaa paa){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaWrite(  filename, paa.Pointer);
	
	return _Result;
}

// pixabasic.c (3098, 1)
// pixaaWriteStream(fp, paa) as int
// pixaaWriteStream(FILE *, PIXAA *) as l_ok
///  <summary>
/// (1) The pix are stored in the file as png.
/// If the png library is not linked, this will fail.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for "wb"</param>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaWriteStream(
				 FILE fp, 
				 Pixaa paa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	int _Result = Natives.pixaaWriteStream(fp.Pointer, paa.Pointer);
	
	return _Result;
}

// pixabasic.c (3144, 1)
// pixaaWriteMem(pdata, psize, paa) as int
// pixaaWriteMem(l_uint8 **, size_t *, PIXAA *) as l_ok
///  <summary>
/// (1) Serializes a pixaa in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized pixaa</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="paa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 Pixaa paa){

if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixaaWriteMem(out  pdataPtr, out  psize, paa.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}


}
}
