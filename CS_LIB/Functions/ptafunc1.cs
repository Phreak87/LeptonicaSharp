using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// ptafunc1.c (111, 1)
// ptaSubsample(ptas, subfactor) as Pta
// ptaSubsample(PTA *, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaSubsample/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="subfactor">[in] - subsample factor, greater or equal 1</param>
///   <returns>ptad evenly sampled pt values from ptas, or NULL on error</returns>
public static Pta ptaSubsample(
				 Pta ptas, 
				 int subfactor){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaSubsample(ptas.Pointer,   subfactor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (154, 1)
// ptaJoin(ptad, ptas, istart, iend) as int
// ptaJoin(PTA *, PTA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (2) iend  is smaller 0 means 'read to the end'<para/>
/// 
/// (3) if ptas == NULL, this is a no-op
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaJoin/*"/>
///  <param name="ptad">[in] - dest pta add to this one</param>
///  <param name="ptas">[in] - source pta add from this one</param>
///  <param name="istart">[in] - starting index in ptas</param>
///  <param name="iend">[in] - ending index in ptas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaJoin(
				 Pta ptad, 
				 Pta ptas, 
				 int istart, 
				 int iend){

if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}
		if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	int _Result = Natives.ptaJoin(ptad.Pointer, ptas.Pointer,   istart,   iend);
	
	return _Result;
}

// ptafunc1.c (202, 1)
// ptaaJoin(ptaad, ptaas, istart, iend) as int
// ptaaJoin(PTAA *, PTAA *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
/// 
/// (2) iend  is smaller 0 means 'read to the end'<para/>
/// 
/// (3) if ptas == NULL, this is a no-op
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaJoin/*"/>
///  <param name="ptaad">[in] - dest ptaa add to this one</param>
///  <param name="ptaas">[in] - source ptaa add from this one</param>
///  <param name="istart">[in] - starting index in ptaas</param>
///  <param name="iend">[in] - ending index in ptaas use -1 to cat all</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaaJoin(
				 Ptaa ptaad, 
				 Ptaa ptaas, 
				 int istart, 
				 int iend){

if (ptaad == null) {throw new ArgumentNullException  ("ptaad cannot be Nothing");}
		if (ptaas == null) {throw new ArgumentNullException  ("ptaas cannot be Nothing");}
	int _Result = Natives.ptaaJoin(ptaad.Pointer, ptaas.Pointer,   istart,   iend);
	
	return _Result;
}

// ptafunc1.c (242, 1)
// ptaReverse(ptas, type) as Pta
// ptaReverse(PTA *, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReverse/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="type">[in] - 0 for float values 1 for integer values</param>
///   <returns>ptad reversed pta, or NULL on error</returns>
public static Pta ptaReverse(
				 Pta ptas, 
				 int type){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaReverse(ptas.Pointer,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (278, 1)
// ptaTranspose(ptas) as Pta
// ptaTranspose(PTA *) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaTranspose/*"/>
///  <param name="ptas">[in] - </param>
///   <returns>ptad with x and y values swapped, or NULL on error</returns>
public static Pta ptaTranspose(
				 Pta ptas){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaTranspose(ptas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (318, 1)
// ptaCyclicPerm(ptas, xs, ys) as Pta
// ptaCyclicPerm(PTA *, l_int32, l_int32) as PTA *
///  <summary>
/// (1) Check to insure that (a) ptas is a closed path where
/// the first and last points are identical, and (b) the
/// resulting pta also starts and ends on the same point
/// (which in this case is (xs, ys).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCyclicPerm/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="xs">[in] - start point must be in ptas</param>
///  <param name="ys">[in] - start point must be in ptas</param>
///   <returns>ptad cyclic permutation, starting and ending at (xs, ys, or NULL on error</returns>
public static Pta ptaCyclicPerm(
				 Pta ptas, 
				 int xs, 
				 int ys){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaCyclicPerm(ptas.Pointer,   xs,   ys);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (374, 1)
// ptaSelectRange(ptas, first, last) as Pta
// ptaSelectRange(PTA *, l_int32, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaSelectRange/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="first">[in] - use 0 to select from the beginning</param>
///  <param name="last">[in] - use 0 to select to the end</param>
///   <returns>ptad, or NULL on error</returns>
public static Pta ptaSelectRange(
				 Pta ptas, 
				 int first, 
				 int last){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaSelectRange(ptas.Pointer,   first,   last);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (424, 1)
// ptaGetBoundingRegion(pta) as Box
// ptaGetBoundingRegion(PTA *) as BOX *
///  <summary>
/// (1) This is used when the pta represents a set of points in
/// a two-dimensional image.  It returns the box of minimum
/// size containing the pts in the pta.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetBoundingRegion/*"/>
///  <param name="pta">[in] - </param>
///   <returns>box, or NULL on error</returns>
public static Box ptaGetBoundingRegion(
				 Pta pta){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr _Result = Natives.ptaGetBoundingRegion(pta.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Box(_Result);
}

// ptafunc1.c (468, 1)
// ptaGetRange(pta, pminx, pmaxx, pminy, pmaxy) as int
// ptaGetRange(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
///  <summary>
/// (1) We can use pts to represent pairs of floating values, that
/// are not necessarily tied to a two-dimension region.  For
/// example, the pts can represent a general function y(x).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetRange/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pminx">[out][optional] - min value of x</param>
///  <param name="pmaxx">[out][optional] - max value of x</param>
///  <param name="pminy">[out][optional] - min value of y</param>
///  <param name="pmaxy">[out][optional] - max value of y</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaGetRange(
				 Pta pta, 
				out Single pminx, 
				out Single pmaxx, 
				out Single pminy, 
				out Single pmaxy){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	int _Result = Natives.ptaGetRange(pta.Pointer, out  pminx, out  pmaxx, out  pminy, out  pmaxy);
	
	return _Result;
}

// ptafunc1.c (518, 1)
// ptaGetInsideBox(ptas, box) as Pta
// ptaGetInsideBox(PTA *, BOX *) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetInsideBox/*"/>
///  <param name="ptas">[in] - input pts</param>
///  <param name="box">[in] - </param>
///   <returns>ptad of pts in ptas that are inside the box, or NULL on error</returns>
public static Pta ptaGetInsideBox(
				 Pta ptas, 
				 Box box){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
		if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}
	IntPtr _Result = Natives.ptaGetInsideBox(ptas.Pointer, box.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (558, 1)
// pixFindCornerPixels(pixs) as Pta
// pixFindCornerPixels(PIX *) as PTA *
///  <summary>
/// (1) Finds the 4 corner-most pixels, as defined by a search
/// inward from each corner, using a 45 degree line.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindCornerPixels/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///   <returns>pta, or NULL on error</returns>
public static Pta pixFindCornerPixels(
				 Pix pixs){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixFindCornerPixels(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (650, 1)
// ptaContainsPt(pta, x, y) as int
// ptaContainsPt(PTA *, l_int32, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaContainsPt/*"/>
///  <param name="pta">[in] - </param>
///  <param name="x">[in] - point</param>
///  <param name="y">[in] - point</param>
///   <returns>1 if contained, 0 otherwise or on error</returns>
public static int ptaContainsPt(
				 Pta pta, 
				 int x, 
				 int y){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	int _Result = Natives.ptaContainsPt(pta.Pointer,   x,   y);
	
	return _Result;
}

// ptafunc1.c (679, 1)
// ptaTestIntersection(pta1, pta2) as int
// ptaTestIntersection(PTA *, PTA *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaTestIntersection/*"/>
///  <param name="pta1">[in] - </param>
///  <param name="pta2">[in] - </param>
///   <returns>bval which is 1 if they have any elements in common 0 otherwise or on error.</returns>
public static int ptaTestIntersection(
				 Pta pta1, 
				 Pta pta2){

if (pta1 == null) {throw new ArgumentNullException  ("pta1 cannot be Nothing");}
		if (pta2 == null) {throw new ArgumentNullException  ("pta2 cannot be Nothing");}
	int _Result = Natives.ptaTestIntersection(pta1.Pointer, pta2.Pointer);
	
	return _Result;
}

// ptafunc1.c (720, 1)
// ptaTransform(ptas, shiftx, shifty, scalex, scaley) as Pta
// ptaTransform(PTA *, l_int32, l_int32, l_float32, l_float32) as PTA *
///  <summary>
/// (1) Shift first, then scale.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaTransform/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="shiftx">[in] - </param>
///  <param name="shifty">[in] - </param>
///  <param name="scalex">[in] - </param>
///  <param name="scaley">[in] - </param>
///   <returns>pta, or NULL on error</returns>
public static Pta ptaTransform(
				 Pta ptas, 
				 int shiftx, 
				 int shifty, 
				 Single scalex, 
				 Single scaley){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaTransform(ptas.Pointer,   shiftx,   shifty,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (760, 1)
// ptaPtInsidePolygon(pta, x, y, pinside) as int
// ptaPtInsidePolygon(PTA *, l_float32, l_float32, l_int32 *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaPtInsidePolygon/*"/>
///  <param name="pta">[in] - vertices of a polygon</param>
///  <param name="x">[in] - point to be tested</param>
///  <param name="y">[in] - point to be tested</param>
///  <param name="pinside">[out] - 1 if inside 0 if outside or on boundary</param>
///   <returns>1 if OK, 0 on error The abs value of the sum of the angles subtended from a point by the sides of a polygon, when taken in order traversing the polygon, is 0 if the point is outside the polygon and 2pi if inside. The sign will be positive if traversed cw and negative if ccw.</returns>
public static int ptaPtInsidePolygon(
				 Pta pta, 
				 Single x, 
				 Single y, 
				out int pinside){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	int _Result = Natives.ptaPtInsidePolygon(pta.Pointer,   x,   y, out  pinside);
	
	return _Result;
}

// ptafunc1.c (812, 1)
// l_angleBetweenVectors(x1, y1, x2, y2) as Single
// l_angleBetweenVectors(l_float32, l_float32, l_float32, l_float32) as l_float32
///  <summary>
/// (1) This gives the angle between two vectors, going between
/// vector1 (x1,y1) and vector2 (x2,y2).  The angle is swept
/// out from 1 to 2.  If this is clockwise, the angle is
/// positive, but the result is folded into the interval [-pi, pi].
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_angleBetweenVectors/*"/>
///  <param name="x1">[in] - end point of first vector</param>
///  <param name="y1">[in] - end point of first vector</param>
///  <param name="x2">[in] - end point of second vector</param>
///  <param name="y2">[in] - end point of second vector</param>
///   <returns>angle radians, or 0.0 on error</returns>
public static Single l_angleBetweenVectors(
				 Single x1, 
				 Single y1, 
				 Single x2, 
				 Single y2){

	Single _Result = Natives.l_angleBetweenVectors(  x1,   y1,   x2,   y2);
	
	return _Result;
}

// ptafunc1.c (841, 1)
// ptaGetMinMax(pta, pxmin, pymin, pxmax, pymax) as int
// ptaGetMinMax(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetMinMax/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pxmin">[out][optional] - min of x</param>
///  <param name="pymin">[out][optional] - min of y</param>
///  <param name="pxmax">[out][optional] - max of x</param>
///  <param name="pymax">[out][optional] - max of y</param>
///   <returns>0 if OK, 1 on error.  If pta is empty, requested values are returned as -1.0.</returns>
public static int ptaGetMinMax(
				 Pta pta, 
				out Single pxmin, 
				out Single pymin, 
				out Single pxmax, 
				out Single pymax){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	int _Result = Natives.ptaGetMinMax(pta.Pointer, out  pxmin, out  pymin, out  pxmax, out  pymax);
	
	return _Result;
}

// ptafunc1.c (894, 1)
// ptaSelectByValue(ptas, xth, yth, type, relation) as Pta
// ptaSelectByValue(PTA *, l_float32, l_float32, l_int32, l_int32) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaSelectByValue/*"/>
///  <param name="ptas">[in] - </param>
///  <param name="xth">[in] - threshold values</param>
///  <param name="yth">[in] - threshold values</param>
///  <param name="type">[in] - L_SELECT_XVAL, L_SELECT_YVAL, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
///  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///   <returns>ptad filtered set, or NULL on error</returns>
public static Pta ptaSelectByValue(
				 Pta ptas, 
				 Single xth, 
				 Single yth, 
				 int type, 
				 int relation){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr _Result = Natives.ptaSelectByValue(ptas.Pointer,   xth,   yth,   type,   relation);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (962, 1)
// ptaCropToMask(ptas, pixm) as Pta
// ptaCropToMask(PTA *, PIX *) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCropToMask/*"/>
///  <param name="ptas">[in] - input pta</param>
///  <param name="pixm">[in] - 1 bpp mask</param>
///   <returns>ptad  with only pts under the mask fg, or NULL on error</returns>
public static Pta ptaCropToMask(
				 Pta ptas, 
				 Pix pixm){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	IntPtr _Result = Natives.ptaCropToMask(ptas.Pointer, pixm.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (1029, 1)
// ptaGetLinearLSF(pta, pa, pb, pnafit) as int
// ptaGetLinearLSF(PTA *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) Either or both [and]a and [and]b must be input.  They determine the
/// type of line that is fit.<para/>
/// 
/// (2) If both [and]a and [and]b are defined, this returns a and b that minimize:
/// sum (yi - axi -b)^2
/// i
/// The method is simple: differentiate this expression w/rt a and b,
/// and solve the resulting two equations for a and b in terms of
/// various sums over the input data (xi, yi).<para/>
/// 
/// (3) We also allow two special cases, where either a = 0 or b = 0:
/// (a) If [and]a is given and [and]b = null, find the linear LSF that
/// goes through the origin (b = 0).
/// (b) If [and]b is given and [and]a = null, find the linear LSF with
/// zero slope (a = 0).<para/>
/// 
/// (4) If [and]nafit is defined, this returns an array of fitted values,
/// corresponding to the two implicit Numa arrays (nax and nay) in pta.
/// Thus, just as you can plot the data in pta as nay vs. nax,
/// you can plot the linear least square fit as nafit vs. nax.
/// Get the nax array using ptaGetArrays(pta, [and]nax, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetLinearLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pa">[out][optional] - slope a of least square fit: y = ax + b</param>
///  <param name="pb">[out][optional] - intercept b of least square fit</param>
///  <param name="pnafit">[out][optional] - numa of least square fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaGetLinearLSF(
				 Pta pta, 
				out Single pa, 
				out Single pb, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaGetLinearLSF(pta.Pointer, out  pa, out  pb, out pnafitPtr);
	
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1130, 1)
// ptaGetQuadraticLSF(pta, pa, pb, pc, pnafit) as int
// ptaGetQuadraticLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This does a quadratic least square fit to the set of points
/// in %pta.  That is, it finds coefficients a, b and c that minimize:
/// sum (yi - axixi -bxi -c)^2
/// i
/// The method is simple: differentiate this expression w/rt
/// a, b and c, and solve the resulting three equations for these
/// coefficients in terms of various sums over the input data (xi, yi).
/// The three equations are in the form:
/// f[0][0]a + f[0][1]b + f[0][2]c = g[0]
/// f[1][0]a + f[1][1]b + f[1][2]c = g[1]
/// f[2][0]a + f[2][1]b + f[2][2]c = g[2]<para/>
/// 
/// (2) If [and]nafit is defined, this returns an array of fitted values,
/// corresponding to the two implicit Numa arrays (nax and nay) in pta.
/// Thus, just as you can plot the data in pta as nay vs. nax,
/// you can plot the linear least square fit as nafit vs. nax.
/// Get the nax array using ptaGetArrays(pta, [and]nax, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetQuadraticLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pa">[out][optional] - coeff a of LSF: y = ax^2 + bx + c</param>
///  <param name="pb">[out][optional] - coeff b of LSF: y = ax^2 + bx + c</param>
///  <param name="pc">[out][optional] - coeff c of LSF: y = ax^2 + bx + c</param>
///  <param name="pnafit">[out][optional] - numa of least square fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaGetQuadraticLSF(
				 Pta pta, 
				out Single pa, 
				out Single pb, 
				out Single pc, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaGetQuadraticLSF(pta.Pointer, out  pa, out  pb, out  pc, out pnafitPtr);
	
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1243, 1)
// ptaGetCubicLSF(pta, pa, pb, pc, pd, pnafit) as int
// ptaGetCubicLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This does a cubic least square fit to the set of points
/// in %pta.  That is, it finds coefficients a, b, c and d
/// that minimize:
/// sum (yi - axixixi -bxixi -cxi - d)^2
/// i
/// Differentiate this expression w/rt a, b, c and d, and solve
/// the resulting four equations for these coefficients in
/// terms of various sums over the input data (xi, yi).
/// The four equations are in the form:
/// f[0][0]a + f[0][1]b + f[0][2]c + f[0][3] = g[0]
/// f[1][0]a + f[1][1]b + f[1][2]c + f[1][3] = g[1]
/// f[2][0]a + f[2][1]b + f[2][2]c + f[2][3] = g[2]
/// f[3][0]a + f[3][1]b + f[3][2]c + f[3][3] = g[3]<para/>
/// 
/// (2) If [and]nafit is defined, this returns an array of fitted values,
/// corresponding to the two implicit Numa arrays (nax and nay) in pta.
/// Thus, just as you can plot the data in pta as nay vs. nax,
/// you can plot the linear least square fit as nafit vs. nax.
/// Get the nax array using ptaGetArrays(pta, [and]nax, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetCubicLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pa">[out][optional] - coeff a of LSF: y = ax^3 + bx^2 + cx + d</param>
///  <param name="pb">[out][optional] - coeff b of LSF</param>
///  <param name="pc">[out][optional] - coeff c of LSF</param>
///  <param name="pd">[out][optional] - coeff d of LSF</param>
///  <param name="pnafit">[out][optional] - numa of least square fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaGetCubicLSF(
				 Pta pta, 
				out Single pa, 
				out Single pb, 
				out Single pc, 
				out Single pd, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaGetCubicLSF(pta.Pointer, out  pa, out  pb, out  pc, out  pd, out pnafitPtr);
	
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1373, 1)
// ptaGetQuarticLSF(pta, pa, pb, pc, pd, pe, pnafit) as int
// ptaGetQuarticLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This does a quartic least square fit to the set of points
/// in %pta.  That is, it finds coefficients a, b, c, d and 3
/// that minimize:
/// sum (yi - axixixixi -bxixixi -cxixi - dxi - e)^2
/// i
/// Differentiate this expression w/rt a, b, c, d and e, and solve
/// the resulting five equations for these coefficients in
/// terms of various sums over the input data (xi, yi).
/// The five equations are in the form:
/// f[0][0]a + f[0][1]b + f[0][2]c + f[0][3] + f[0][4] = g[0]
/// f[1][0]a + f[1][1]b + f[1][2]c + f[1][3] + f[1][4] = g[1]
/// f[2][0]a + f[2][1]b + f[2][2]c + f[2][3] + f[2][4] = g[2]
/// f[3][0]a + f[3][1]b + f[3][2]c + f[3][3] + f[3][4] = g[3]
/// f[4][0]a + f[4][1]b + f[4][2]c + f[4][3] + f[4][4] = g[4]<para/>
/// 
/// (2) If [and]nafit is defined, this returns an array of fitted values,
/// corresponding to the two implicit Numa arrays (nax and nay) in pta.
/// Thus, just as you can plot the data in pta as nay vs. nax,
/// you can plot the linear least square fit as nafit vs. nax.
/// Get the nax array using ptaGetArrays(pta, [and]nax, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetQuarticLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pa">[out][optional] - coeff a of LSF: y = ax^4 + bx^3 + cx^2 + dx + e</param>
///  <param name="pb">[out][optional] - coeff b of LSF</param>
///  <param name="pc">[out][optional] - coeff c of LSF</param>
///  <param name="pd">[out][optional] - coeff d of LSF</param>
///  <param name="pe">[out][optional] - coeff e of LSF</param>
///  <param name="pnafit">[out][optional] - numa of least square fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaGetQuarticLSF(
				 Pta pta, 
				out Single pa, 
				out Single pb, 
				out Single pc, 
				out Single pd, 
				out Single pe, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaGetQuarticLSF(pta.Pointer, out  pa, out  pb, out  pc, out  pd, out  pe, out pnafitPtr);
	
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1509, 1)
// ptaNoisyLinearLSF(pta, factor, pptad, pa, pb, pmederr, pnafit) as int
// ptaNoisyLinearLSF(PTA *, l_float32, PTA **, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This does a linear least square fit to the set of points
/// in %pta.  It then evaluates the errors and removes points
/// whose error is greater or equal factor  median_error.  It then re-runs
/// the linear LSF on the resulting points.<para/>
/// 
/// (2) Either or both [and]a and [and]b must be input.  They determine the
/// type of line that is fit.<para/>
/// 
/// (3) The median error can give an indication of how good the fit
/// is likely to be.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaNoisyLinearLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="factor">[in] - reject outliers with error greater than this number of medians typically ~ 3</param>
///  <param name="pptad">[out][optional] - with outliers removed</param>
///  <param name="pa">[out][optional] - slope a of least square fit: y = ax + b</param>
///  <param name="pb">[out][optional] - intercept b of least square fit</param>
///  <param name="pmederr">[out][optional] - median error</param>
///  <param name="pnafit">[out][optional] - numa of least square fit to ptad</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaNoisyLinearLSF(
				 Pta pta, 
				 Single factor, 
				out Pta pptad, 
				out Single pa, 
				out Single pb, 
				out Single pmederr, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pptadPtr = IntPtr.Zero;
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaNoisyLinearLSF(pta.Pointer,   factor, out pptadPtr, out  pa, out  pb, out  pmederr, out pnafitPtr);
	
	if (pptadPtr == IntPtr.Zero) {pptad = null;} else { pptad = new Pta(pptadPtr); };
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1596, 1)
// ptaNoisyQuadraticLSF(pta, factor, pptad, pa, pb, pc, pmederr, pnafit) as int
// ptaNoisyQuadraticLSF(PTA *, l_float32, PTA **, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This does a quadratic least square fit to the set of points
/// in %pta.  It then evaluates the errors and removes points
/// whose error is greater or equal factor  median_error.  It then re-runs
/// a quadratic LSF on the resulting points.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaNoisyQuadraticLSF/*"/>
///  <param name="pta">[in] - </param>
///  <param name="factor">[in] - reject outliers with error greater than this number of medians typically ~ 3</param>
///  <param name="pptad">[out][optional] - with outliers removed</param>
///  <param name="pa">[out][optional] - coeff a of LSF: y = ax^2 + bx + c</param>
///  <param name="pb">[out][optional] - coeff b of LSF: y = ax^2 + bx + c</param>
///  <param name="pc">[out][optional] - coeff c of LSF: y = ax^2 + bx + c</param>
///  <param name="pmederr">[out][optional] - median error</param>
///  <param name="pnafit">[out][optional] - numa of least square fit to ptad</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaNoisyQuadraticLSF(
				 Pta pta, 
				 Single factor, 
				out Pta pptad, 
				out Single pa, 
				out Single pb, 
				out Single pc, 
				out Single pmederr, 
				out Numa pnafit){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pptadPtr = IntPtr.Zero;
	IntPtr pnafitPtr = IntPtr.Zero;

	int _Result = Natives.ptaNoisyQuadraticLSF(pta.Pointer,   factor, out pptadPtr, out  pa, out  pb, out  pc, out  pmederr, out pnafitPtr);
	
	if (pptadPtr == IntPtr.Zero) {pptad = null;} else { pptad = new Pta(pptadPtr); };
	if (pnafitPtr == IntPtr.Zero) {pnafit = null;} else { pnafit = new Numa(pnafitPtr); };
	return _Result;
}

// ptafunc1.c (1676, 1)
// applyLinearFit(a, b, x, py) as int
// applyLinearFit(l_float32, l_float32, l_float32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/applyLinearFit/*"/>
///  <param name="a">[in] - linear fit coefficients</param>
///  <param name="b">[in] - linear fit coefficients</param>
///  <param name="x">[in] - </param>
///  <param name="py">[out] - y = a  x + b</param>
///   <returns>0 if OK, 1 on error</returns>
public static int applyLinearFit(
				 Single a, 
				 Single b, 
				 Single x, 
				out Single py){

	int _Result = Natives.applyLinearFit(  a,   b,   x, out  py);
	
	return _Result;
}

// ptafunc1.c (1700, 1)
// applyQuadraticFit(a, b, c, x, py) as int
// applyQuadraticFit(l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/applyQuadraticFit/*"/>
///  <param name="a">[in] - quadratic fit coefficients</param>
///  <param name="b">[in] - quadratic fit coefficients</param>
///  <param name="c">[in] - quadratic fit coefficients</param>
///  <param name="x">[in] - </param>
///  <param name="py">[out] - y = a  x^2 + b  x + c</param>
///   <returns>0 if OK, 1 on error</returns>
public static int applyQuadraticFit(
				 Single a, 
				 Single b, 
				 Single c, 
				 Single x, 
				out Single py){

	int _Result = Natives.applyQuadraticFit(  a,   b,   c,   x, out  py);
	
	return _Result;
}

// ptafunc1.c (1725, 1)
// applyCubicFit(a, b, c, d, x, py) as int
// applyCubicFit(l_float32, l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/applyCubicFit/*"/>
///  <param name="a">[in] - cubic fit coefficients</param>
///  <param name="b">[in] - cubic fit coefficients</param>
///  <param name="c">[in] - cubic fit coefficients</param>
///  <param name="d">[in] - cubic fit coefficients</param>
///  <param name="x">[in] - </param>
///  <param name="py">[out] - y = a  x^3 + b  x^2  + c  x + d</param>
///   <returns>0 if OK, 1 on error</returns>
public static int applyCubicFit(
				 Single a, 
				 Single b, 
				 Single c, 
				 Single d, 
				 Single x, 
				out Single py){

	int _Result = Natives.applyCubicFit(  a,   b,   c,   d,   x, out  py);
	
	return _Result;
}

// ptafunc1.c (1751, 1)
// applyQuarticFit(a, b, c, d, e, x, py) as int
// applyQuarticFit(l_float32, l_float32, l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/applyQuarticFit/*"/>
///  <param name="a">[in] - quartic fit coefficients</param>
///  <param name="b">[in] - quartic fit coefficients</param>
///  <param name="c">[in] - quartic fit coefficients</param>
///  <param name="d">[in] - quartic fit coefficients</param>
///  <param name="e">[in] - quartic fit coefficients</param>
///  <param name="x">[in] - </param>
///  <param name="py">[out] - y = a  x^4 + b  x^3  + c  x^2 + d  x + e</param>
///   <returns>0 if OK, 1 on error</returns>
public static int applyQuarticFit(
				 Single a, 
				 Single b, 
				 Single c, 
				 Single d, 
				 Single e, 
				 Single x, 
				out Single py){

	int _Result = Natives.applyQuarticFit(  a,   b,   c,   d,   e,   x, out  py);
	
	return _Result;
}

// ptafunc1.c (1792, 1)
// pixPlotAlongPta(pixs, pta, outformat, title) as int
// pixPlotAlongPta(PIX *, PTA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This is a debugging function.<para/>
/// 
/// (2) Removes existing colormaps and clips the pta to the input %pixs.<para/>
/// 
/// (3) If the image is RGB, three separate plots are generated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixPlotAlongPta/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="pta">[in] - set of points on which to plot</param>
///  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
///  <param name="title">[in][optional] - for plot can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixPlotAlongPta(
				 Pix pixs, 
				 Pta pta, 
				 int outformat, 
				 String title){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	int _Result = Natives.pixPlotAlongPta(pixs.Pointer, pta.Pointer,   outformat,   title);
	
	return _Result;
}

// ptafunc1.c (1893, 1)
// ptaGetPixelsFromPix(pixs, box) as Pta
// ptaGetPixelsFromPix(PIX *, BOX *) as PTA *
///  <summary>
/// (1) Generates a pta of fg pixels in the pix, within the box.
/// If box == NULL, it uses the entire pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetPixelsFromPix/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="box">[in][optional] - can be null</param>
///   <returns>pta, or NULL on error</returns>
public static Pta ptaGetPixelsFromPix(
				 Pix pixs, 
				 Box box){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}

	IntPtr _Result = Natives.ptaGetPixelsFromPix(pixs.Pointer, boxPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (1946, 1)
// pixGenerateFromPta(pta, w, h) as Pix
// pixGenerateFromPta(PTA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Points are rounded to nearest ints.<para/>
/// 
/// (2) Any points outside (w,h) are silently discarded.<para/>
/// 
/// (3) Output 1 bpp pix has values 1 for each point in the pta.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGenerateFromPta/*"/>
///  <param name="pta">[in] - </param>
///  <param name="w">[in] - of pix</param>
///  <param name="h">[in] - of pix</param>
///   <returns>pix 1 bpp, or NULL on error</returns>
public static Pix pixGenerateFromPta(
				 Pta pta, 
				 int w, 
				 int h){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr _Result = Natives.pixGenerateFromPta(pta.Pointer,   w,   h);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ptafunc1.c (1987, 1)
// ptaGetBoundaryPixels(pixs, type) as Pta
// ptaGetBoundaryPixels(PIX *, l_int32) as PTA *
///  <summary>
/// (1) This generates a pta of either fg or bg boundary pixels.<para/>
/// 
/// (2) See also pixGeneratePtaBoundary() for rendering of
/// fg boundary pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetBoundaryPixels/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="type">[in] - L_BOUNDARY_FG, L_BOUNDARY_BG</param>
///   <returns>pta, or NULL on error</returns>
public static Pta ptaGetBoundaryPixels(
				 Pix pixs, 
				 int type){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.ptaGetBoundaryPixels(pixs.Pointer,   type);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (2036, 1)
// ptaaGetBoundaryPixels(pixs, type, connectivity, pboxa, ppixa) as Ptaa
// ptaaGetBoundaryPixels(PIX *, l_int32, l_int32, BOXA **, PIXA **) as PTAA *
///  <summary>
/// (1) This generates a ptaa of either fg or bg boundary pixels,
/// where each pta has the boundary pixels for a connected
/// component.<para/>
/// 
/// (2) We can't simply find all the boundary pixels and then select
/// those within the bounding box of each component, because
/// bounding boxes can overlap.  It is necessary to extract and
/// dilate or erode each component separately.  Note also that
/// special handling is required for bg pixels when the
/// component touches the pix boundary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetBoundaryPixels/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="type">[in] - L_BOUNDARY_FG, L_BOUNDARY_BG</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="pboxa">[out][optional] - bounding boxes of the c.c.</param>
///  <param name="ppixa">[out][optional] - pixa of the c.c.</param>
///   <returns>ptaa, or NULL on error</returns>
public static Ptaa ptaaGetBoundaryPixels(
				 Pix pixs, 
				 int type, 
				 int connectivity, 
				out Boxa pboxa, 
				out Pixa ppixa){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr pboxaPtr = IntPtr.Zero;
	IntPtr ppixaPtr = IntPtr.Zero;

	IntPtr _Result = Natives.ptaaGetBoundaryPixels(pixs.Pointer,   type,   connectivity, out pboxaPtr, out ppixaPtr);
	
	if (pboxaPtr == IntPtr.Zero) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };
	if (ppixaPtr == IntPtr.Zero) {ppixa = null;} else { ppixa = new Pixa(ppixaPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Ptaa(_Result);
}

// ptafunc1.c (2119, 1)
// ptaaIndexLabeledPixels(pixs, pncc) as Ptaa
// ptaaIndexLabeledPixels(PIX *, l_int32 *) as PTAA *
///  <summary>
/// (1) The pixel values in %pixs are the index of the connected component
/// to which the pixel belongs %pixs is typically generated from
/// a 1 bpp pix by pixConnCompTransform().  Background pixels in
/// the generating 1 bpp pix are represented in %pixs by 0.
/// We do not check that the pixel values are correctly labelled.<para/>
/// 
/// (2) Each pta in the returned ptaa gives the pixel locations
/// correspnding to a connected component, with the label of each
/// given by the index of the pta into the ptaa.<para/>
/// 
/// (3) Initialize with the first pta in ptaa being empty and
/// representing the background value (index 0) in the pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaIndexLabeledPixels/*"/>
///  <param name="pixs">[in] - 32 bpp, of indices of c.c.</param>
///  <param name="pncc">[out][optional] - number of connected components</param>
///   <returns>ptaa, or NULL on error</returns>
public static Ptaa ptaaIndexLabeledPixels(
				 Pix pixs, 
				out int pncc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.ptaaIndexLabeledPixels(pixs.Pointer, out  pncc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Ptaa(_Result);
}

// ptafunc1.c (2176, 1)
// ptaGetNeighborPixLocs(pixs, x, y, conn) as Pta
// ptaGetNeighborPixLocs(PIX *, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) Generates a pta of all valid neighbor pixel locations,
/// or NULL on error.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetNeighborPixLocs/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="x">[in] - pixel from which we search for nearest neighbors</param>
///  <param name="y">[in] - pixel from which we search for nearest neighbors</param>
///  <param name="conn">[in] - 4 or 8 connectivity</param>
///   <returns>pta, or NULL on error</returns>
public static Pta ptaGetNeighborPixLocs(
				 Pix pixs, 
				 int x, 
				 int y, 
				 int conn){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.ptaGetNeighborPixLocs(pixs.Pointer,   x,   y,   conn);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (2232, 1)
// numaConvertToPta1(na) as Pta
// numaConvertToPta1(NUMA *) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaConvertToPta1/*"/>
///  <param name="na">[in] - numa with implicit y(x)</param>
///   <returns>pta if OK null on error</returns>
public static Pta numaConvertToPta1(
				 Numa na){

if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.numaConvertToPta1(na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (2262, 1)
// numaConvertToPta2(nax, nay) as Pta
// numaConvertToPta2(NUMA *, NUMA *) as PTA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaConvertToPta2/*"/>
///  <param name="nax">[in] - </param>
///  <param name="nay">[in] - </param>
///   <returns>pta if OK null on error</returns>
public static Pta numaConvertToPta2(
				 Numa nax, 
				 Numa nay){

if (nax == null) {throw new ArgumentNullException  ("nax cannot be Nothing");}
		if (nay == null) {throw new ArgumentNullException  ("nay cannot be Nothing");}
	IntPtr _Result = Natives.numaConvertToPta2(nax.Pointer, nay.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (2298, 1)
// ptaConvertToNuma(pta, pnax, pnay) as int
// ptaConvertToNuma(PTA *, NUMA **, NUMA **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaConvertToNuma/*"/>
///  <param name="pta">[in] - </param>
///  <param name="pnax">[out] - addr of nax</param>
///  <param name="pnay">[out] - addr of nay</param>
///   <returns>0 if OK, 1 on error</returns>
public static int ptaConvertToNuma(
				 Pta pta, 
				out Numa pnax, 
				out Numa pnay){

if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
	IntPtr pnaxPtr = IntPtr.Zero;
	IntPtr pnayPtr = IntPtr.Zero;

	int _Result = Natives.ptaConvertToNuma(pta.Pointer, out pnaxPtr, out pnayPtr);
	
	if (pnaxPtr == IntPtr.Zero) {pnax = null;} else { pnax = new Numa(pnaxPtr); };
	if (pnayPtr == IntPtr.Zero) {pnay = null;} else { pnay = new Numa(pnayPtr); };
	return _Result;
}

// ptafunc1.c (2349, 1)
// pixDisplayPta(pixd, pixs, pta) as Pix
// pixDisplayPta(PIX *, PIX *, PTA *) as PIX *
///  <summary>
/// (1) To write on an existing pixs, pixs must be 32 bpp and
/// call with pixd == pixs:
/// pixDisplayPta(pixs, pixs, pta)
/// To write to a new pix, use pixd == NULL and call:
/// pixd = pixDisplayPta(NULL, pixs, pta)<para/>
/// 
/// (2) On error, returns pixd to avoid losing pixs if called as
/// pixs = pixDisplayPta(pixs, pixs, pta)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayPta/*"/>
///  <param name="pixd">[in] - can be same as pixs or NULL 32 bpp if in-place</param>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
///  <param name="pta">[in] - of path to be plotted</param>
///   <returns>pixd 32 bpp RGB version of pixs, with path in green.</returns>
public static Pix pixDisplayPta(
				 Pix pixd, 
				 Pix pixs, 
				 Pta pta){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
if ((new List<int> {1,2,4,8,16,32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1, 2, 4, 8, 16 or 32 bpp"); }
	IntPtr _Result = Natives.pixDisplayPta(pixd.Pointer, pixs.Pointer, pta.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ptafunc1.c (2415, 1)
// pixDisplayPtaaPattern(pixd, pixs, ptaa, pixp, cx, cy) as Pix
// pixDisplayPtaaPattern(PIX *, PIX *, PTAA *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) To write on an existing pixs, pixs must be 32 bpp and
/// call with pixd == pixs:
/// pixDisplayPtaPattern(pixs, pixs, pta, ...)
/// To write to a new pix, use pixd == NULL and call:
/// pixd = pixDisplayPtaPattern(NULL, pixs, pta, ...)<para/>
/// 
/// (2) Puts a random color on each pattern associated with a pta.<para/>
/// 
/// (3) On error, returns pixd to avoid losing pixs if called as
/// pixs = pixDisplayPtaPattern(pixs, pixs, pta, ...)<para/>
/// 
/// (4) A typical pattern to be used is a circle, generated with
/// generatePtaFilledCircle()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayPtaaPattern/*"/>
///  <param name="pixd">[in] - 32 bpp</param>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp 32 bpp if in place</param>
///  <param name="ptaa">[in] - giving locations at which the pattern is displayed</param>
///  <param name="pixp">[in] - 1 bpp pattern to be placed such that its reference point co-locates with each point in pta</param>
///  <param name="cx">[in] - reference point in pattern</param>
///  <param name="cy">[in] - reference point in pattern</param>
///   <returns>pixd 32 bpp RGB version of pixs.</returns>
public static Pix pixDisplayPtaaPattern(
				 Pix pixd, 
				 Pix pixs, 
				 Ptaa ptaa, 
				 Pix pixp, 
				 int cx, 
				 int cy){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}
		if (pixp == null) {throw new ArgumentNullException  ("pixp cannot be Nothing");}
	IntPtr _Result = Natives.pixDisplayPtaaPattern(pixd.Pointer, pixs.Pointer, ptaa.Pointer, pixp.Pointer,   cx,   cy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ptafunc1.c (2482, 1)
// pixDisplayPtaPattern(pixd, pixs, pta, pixp, cx, cy, color) as Pix
// pixDisplayPtaPattern(PIX *, PIX *, PTA *, PIX *, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) To write on an existing pixs, pixs must be 32 bpp and
/// call with pixd == pixs:
/// pixDisplayPtaPattern(pixs, pixs, pta, ...)
/// To write to a new pix, use pixd == NULL and call:
/// pixd = pixDisplayPtaPattern(NULL, pixs, pta, ...)<para/>
/// 
/// (2) On error, returns pixd to avoid losing pixs if called as
/// pixs = pixDisplayPtaPattern(pixs, pixs, pta, ...)<para/>
/// 
/// (3) A typical pattern to be used is a circle, generated with
/// generatePtaFilledCircle()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayPtaPattern/*"/>
///  <param name="pixd">[in] - can be same as pixs or NULL 32 bpp if in-place</param>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
///  <param name="pta">[in] - giving locations at which the pattern is displayed</param>
///  <param name="pixp">[in] - 1 bpp pattern to be placed such that its reference point co-locates with each point in pta</param>
///  <param name="cx">[in] - reference point in pattern</param>
///  <param name="cy">[in] - reference point in pattern</param>
///  <param name="color">[in] - in 0xrrggbb00 format</param>
///   <returns>pixd 32 bpp RGB version of pixs.</returns>
public static Pix pixDisplayPtaPattern(
				 Pix pixd, 
				 Pix pixs, 
				 Pta pta, 
				 Pix pixp, 
				 int cx, 
				 int cy, 
				 uint color){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pta == null) {throw new ArgumentNullException  ("pta cannot be Nothing");}
		if (pixp == null) {throw new ArgumentNullException  ("pixp cannot be Nothing");}
if ((new List<int> {1,2,4,8,16,32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1, 2, 4, 8, 16 or 32 bpp"); }
	IntPtr _Result = Natives.pixDisplayPtaPattern(pixd.Pointer, pixs.Pointer, pta.Pointer, pixp.Pointer,   cx,   cy,   color);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// ptafunc1.c (2542, 1)
// ptaReplicatePattern(ptas, pixp, ptap, cx, cy, w, h) as Pta
// ptaReplicatePattern(PTA *, PIX *, PTA *, l_int32, l_int32, l_int32, l_int32) as PTA *
///  <summary>
/// (1) You can use either the image %pixp or the set of pts %ptap.<para/>
/// 
/// (2) The pattern is placed with its reference point at each point
/// in ptas, and all the fg pixels are colleced into ptad.
/// For %pixp, this is equivalent to blitting pixp at each point
/// in ptas, and then converting the resulting pix to a pta.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReplicatePattern/*"/>
///  <param name="ptas">[in] - "sparse" input pta</param>
///  <param name="pixp">[in][optional] - 1 bpp pattern, to be replicated in output pta</param>
///  <param name="ptap">[in][optional] - set of pts, to be replicated in output pta</param>
///  <param name="cx">[in] - reference point in pattern</param>
///  <param name="cy">[in] - reference point in pattern</param>
///  <param name="w">[in] - clipping sizes for output pta</param>
///  <param name="h">[in] - clipping sizes for output pta</param>
///   <returns>ptad with all points of replicated pattern, or NULL on error</returns>
public static Pta ptaReplicatePattern(
				 Pta ptas, 
				 Pix pixp, 
				 Pta ptap, 
				 int cx, 
				 int cy, 
				 int w, 
				 int h){

if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}
	IntPtr pixpPtr = IntPtr.Zero; 	if (pixp != null) {pixpPtr = pixp.Pointer;}
	IntPtr ptapPtr = IntPtr.Zero; 	if (ptap != null) {ptapPtr = ptap.Pointer;}

	IntPtr _Result = Natives.ptaReplicatePattern(ptas.Pointer, pixpPtr, ptapPtr,   cx,   cy,   w,   h);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pta(_Result);
}

// ptafunc1.c (2594, 1)
// pixDisplayPtaa(pixs, ptaa) as Pix
// pixDisplayPtaa(PIX *, PTAA *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayPtaa/*"/>
///  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
///  <param name="ptaa">[in] - array of paths to be plotted</param>
///   <returns>pixd 32 bpp RGB version of pixs, with paths plotted in different colors, or NULL on error</returns>
public static Pix pixDisplayPtaa(
				 Pix pixs, 
				 Ptaa ptaa){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (ptaa == null) {throw new ArgumentNullException  ("ptaa cannot be Nothing");}
if ((new List<int> {1,2,4,8,16,32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1, 2, 4, 8, 16 or 32 bpp"); }
	IntPtr _Result = Natives.pixDisplayPtaa(pixs.Pointer, ptaa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
