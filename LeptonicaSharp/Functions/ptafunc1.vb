Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\ptafunc1.c (111, 1)
' ptaSubsample()
' ptaSubsample(PTA *, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="subfactor">[in] - subsample factor, GT= 1</param>
'''   <returns>ptad evenly sampled pt values from ptas, or NULL on error</returns>
Public Shared Function ptaSubsample(
				ByVal ptas as Pta, 
				ByVal subfactor as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaSubsample( ptas.Pointer, subfactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (154, 1)
' ptaJoin()
' ptaJoin(PTA *, PTA *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) istart LT 0 is taken to mean 'read from the start' (istart = 0)
''' (2) iend LT 0 means 'read to the end'
''' (3) if ptas == NULL, this is a no-op
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptad">[in] - dest pta; add to this one</param>
'''  <param name="ptas">[in] - source pta; add from this one</param>
'''  <param name="istart">[in] - starting index in ptas</param>
'''  <param name="iend">[in] - ending index in ptas; use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaJoin(
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal istart as Integer, 
				ByVal iend as Integer) as Integer

	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaJoin( ptad.Pointer, ptas.Pointer, istart, iend)

	Return _Result
End Function

' SRC\ptafunc1.c (202, 1)
' ptaaJoin()
' ptaaJoin(PTAA *, PTAA *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) istart LT 0 is taken to mean 'read from the start' (istart = 0)
''' (2) iend LT 0 means 'read to the end'
''' (3) if ptas == NULL, this is a no-op
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptaad">[in] - dest ptaa; add to this one</param>
'''  <param name="ptaas">[in] - source ptaa; add from this one</param>
'''  <param name="istart">[in] - starting index in ptaas</param>
'''  <param name="iend">[in] - ending index in ptaas; use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaJoin(
				ByVal ptaad as Ptaa, 
				ByVal ptaas as Ptaa, 
				ByVal istart as Integer, 
				ByVal iend as Integer) as Integer

	If IsNothing (ptaad) then Throw New ArgumentNullException  ("ptaad cannot be Nothing")
	If IsNothing (ptaas) then Throw New ArgumentNullException  ("ptaas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaaJoin( ptaad.Pointer, ptaas.Pointer, istart, iend)

	Return _Result
End Function

' SRC\ptafunc1.c (242, 1)
' ptaReverse()
' ptaReverse(PTA *, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="type">[in] - 0 for float values; 1 for integer values</param>
'''   <returns>ptad reversed pta, or NULL on error</returns>
Public Shared Function ptaReverse(
				ByVal ptas as Pta, 
				ByVal type as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaReverse( ptas.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (278, 1)
' ptaTranspose()
' ptaTranspose(PTA *) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''   <returns>ptad with x and y values swapped, or NULL on error</returns>
Public Shared Function ptaTranspose(
				ByVal ptas as Pta) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaTranspose( ptas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (318, 1)
' ptaCyclicPerm()
' ptaCyclicPerm(PTA *, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) Check to insure that (a) ptas is a closed path where
''' the first and last points are identical, and (b) the
''' resulting pta also starts and ends on the same point
''' (which in this case is (xs, ys).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="xs">[in] - start point; must be in ptas</param>
'''  <param name="ys">[in] - start point; must be in ptas</param>
'''   <returns>ptad cyclic permutation, starting and ending at (xs, ys, or NULL on error</returns>
Public Shared Function ptaCyclicPerm(
				ByVal ptas as Pta, 
				ByVal xs as Integer, 
				ByVal ys as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaCyclicPerm( ptas.Pointer, xs, ys)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (374, 1)
' ptaSelectRange()
' ptaSelectRange(PTA *, l_int32, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="first">[in] - use 0 to select from the beginning</param>
'''  <param name="last">[in] - use 0 to select to the end</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function ptaSelectRange(
				ByVal ptas as Pta, 
				ByVal first as Integer, 
				ByVal last as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaSelectRange( ptas.Pointer, first, last)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (424, 1)
' ptaGetBoundingRegion()
' ptaGetBoundingRegion(PTA *) as BOX *
'''  <summary>
''' Notes
''' (1) This is used when the pta represents a set of points in
''' a two-dimensional image.  It returns the box of minimum
''' size containing the pts in the pta.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function ptaGetBoundingRegion(
				ByVal pta as Pta) as Box

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaGetBoundingRegion( pta.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\ptafunc1.c (468, 1)
' ptaGetRange()
' ptaGetRange(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) We can use pts to represent pairs of floating values, that
''' are not necessarily tied to a two-dimension region.  For
''' example, the pts can represent a general function y(x).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pminx">[out][optional] - min value of x</param>
'''  <param name="pmaxx">[out][optional] - max value of x</param>
'''  <param name="pminy">[out][optional] - min value of y</param>
'''  <param name="pmaxy">[out][optional] - max value of y</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetRange(
				ByVal pta as Pta, 
				ByRef pminx as Single(), 
				ByRef pmaxx as Single(), 
				ByRef pminy as Single(), 
				ByRef pmaxy as Single()) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetRange( pta.Pointer, pminx, pmaxx, pminy, pmaxy)

	Return _Result
End Function

' SRC\ptafunc1.c (518, 1)
' ptaGetInsideBox()
' ptaGetInsideBox(PTA *, BOX *) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - input pts</param>
'''  <param name="box">[in] - </param>
'''   <returns>ptad of pts in ptas that are inside the box, or NULL on error</returns>
Public Shared Function ptaGetInsideBox(
				ByVal ptas as Pta, 
				ByVal box as Box) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaGetInsideBox( ptas.Pointer, box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (558, 1)
' pixFindCornerPixels()
' pixFindCornerPixels(PIX *) as PTA *
'''  <summary>
''' Notes
''' (1) Finds the 4 corner-most pixels, as defined by a search
''' inward from each corner, using a 45 degree line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function pixFindCornerPixels(
				ByVal pixs as Pix) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindCornerPixels( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (650, 1)
' ptaContainsPt()
' ptaContainsPt(PTA *, l_int32, l_int32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="x">[in] - point</param>
'''  <param name="y">[in] - point</param>
'''   <returns>1 if contained, 0 otherwise or on error</returns>
Public Shared Function ptaContainsPt(
				ByVal pta as Pta, 
				ByVal x as Integer, 
				ByVal y as Integer) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaContainsPt( pta.Pointer, x, y)

	Return _Result
End Function

' SRC\ptafunc1.c (679, 1)
' ptaTestIntersection()
' ptaTestIntersection(PTA *, PTA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta1">[in] - </param>
'''  <param name="pta2">[in] - </param>
'''   <returns>bval which is 1 if they have any elements in common; 0 otherwise or on error.</returns>
Public Shared Function ptaTestIntersection(
				ByVal pta1 as Pta, 
				ByVal pta2 as Pta) as Integer

	If IsNothing (pta1) then Throw New ArgumentNullException  ("pta1 cannot be Nothing")
	If IsNothing (pta2) then Throw New ArgumentNullException  ("pta2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaTestIntersection( pta1.Pointer, pta2.Pointer)

	Return _Result
End Function

' SRC\ptafunc1.c (720, 1)
' ptaTransform()
' ptaTransform(PTA *, l_int32, l_int32, l_float32, l_float32) as PTA *
'''  <summary>
''' Notes
''' (1) Shift first, then scale.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="shiftx">[in] - </param>
'''  <param name="shifty">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaTransform(
				ByVal ptas as Pta, 
				ByVal shiftx as Integer, 
				ByVal shifty as Integer, 
				ByVal scalex as Single, 
				ByVal scaley as Single) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaTransform( ptas.Pointer, shiftx, shifty, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (760, 1)
' ptaPtInsidePolygon()
' ptaPtInsidePolygon(PTA *, l_float32, l_float32, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - vertices of a polygon</param>
'''  <param name="x">[in] - point to be tested</param>
'''  <param name="y">[in] - point to be tested</param>
'''  <param name="pinside">[out] - 1 if inside; 0 if outside or on boundary</param>
'''   <returns>1 if OK, 0 on error The abs value of the sum of the angles subtended from a point by the sides of a polygon, when taken in order traversing the polygon, is 0 if the point is outside the polygon and 2pi if inside. The sign will be positive if traversed cw and negative if ccw.</returns>
Public Shared Function ptaPtInsidePolygon(
				ByVal pta as Pta, 
				ByVal x as Single, 
				ByVal y as Single, 
				ByRef pinside as Integer) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")
	If IsNothing (y) then Throw New ArgumentNullException  ("y cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaPtInsidePolygon( pta.Pointer, x, y, pinside)

	Return _Result
End Function

' SRC\ptafunc1.c (812, 1)
' l_angleBetweenVectors()
' l_angleBetweenVectors(l_float32, l_float32, l_float32, l_float32) as l_float32
'''  <summary>
''' Notes
''' (1) This gives the angle between two vectors, going between
''' vector1 (x1,y1) and vector2 (x2,y2).  The angle is swept
''' out from 1 --GT 2.  If this is clockwise, the angle is
''' positive, but the result is folded into the interval [-pi, pi].
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x1">[in] - end point of first vector</param>
'''  <param name="y1">[in] - end point of first vector</param>
'''  <param name="x2">[in] - end point of second vector</param>
'''  <param name="y2">[in] - end point of second vector</param>
'''   <returns>angle radians, or 0.0 on error</returns>
Public Shared Function l_angleBetweenVectors(
				ByVal x1 as Single, 
				ByVal y1 as Single, 
				ByVal x2 as Single, 
				ByVal y2 as Single) as Single

	If IsNothing (x1) then Throw New ArgumentNullException  ("x1 cannot be Nothing")
	If IsNothing (y1) then Throw New ArgumentNullException  ("y1 cannot be Nothing")
	If IsNothing (x2) then Throw New ArgumentNullException  ("x2 cannot be Nothing")
	If IsNothing (y2) then Throw New ArgumentNullException  ("y2 cannot be Nothing")


	Dim _Result as Single = LeptonicaSharp.Natives.l_angleBetweenVectors( x1, y1, x2, y2)

	Return _Result
End Function

' SRC\ptafunc1.c (841, 1)
' ptaGetMinMax()
' ptaGetMinMax(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pxmin">[out][optional] - min of x</param>
'''  <param name="pymin">[out][optional] - min of y</param>
'''  <param name="pxmax">[out][optional] - max of x</param>
'''  <param name="pymax">[out][optional] - max of y</param>
'''   <returns>0 if OK, 1 on error.  If pta is empty, requested values are returned as -1.0.</returns>
Public Shared Function ptaGetMinMax(
				ByVal pta as Pta, 
				ByRef pxmin as Single(), 
				ByRef pymin as Single(), 
				ByRef pxmax as Single(), 
				ByRef pymax as Single()) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetMinMax( pta.Pointer, pxmin, pymin, pxmax, pymax)

	Return _Result
End Function

' SRC\ptafunc1.c (894, 1)
' ptaSelectByValue()
' ptaSelectByValue(PTA *, l_float32, l_float32, l_int32, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="xth">[in] - threshold values</param>
'''  <param name="yth">[in] - threshold values</param>
'''  <param name="type">[in] - L_SELECT_XVAL, L_SELECT_YVAL, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>ptad filtered set, or NULL on error</returns>
Public Shared Function ptaSelectByValue(
				ByVal ptas as Pta, 
				ByVal xth as Single, 
				ByVal yth as Single, 
				ByVal type as Enumerations.L_SELECT, 
				ByVal relation as Enumerations.L_SELECT_IF) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (xth) then Throw New ArgumentNullException  ("xth cannot be Nothing")
	If IsNothing (yth) then Throw New ArgumentNullException  ("yth cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaSelectByValue( ptas.Pointer, xth, yth, type, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (962, 1)
' ptaCropToMask()
' ptaCropToMask(PTA *, PIX *) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - input pta</param>
'''  <param name="pixm">[in] - 1 bpp mask</param>
'''   <returns>ptad  with only pts under the mask fg, or NULL on error</returns>
Public Shared Function ptaCropToMask(
				ByVal ptas as Pta, 
				ByVal pixm as Pix) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaCropToMask( ptas.Pointer, pixm.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (1029, 1)
' ptaGetLinearLSF()
' ptaGetLinearLSF(PTA *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) Either or both a and b must be input.  They determine the
''' type of line that is fit.
''' (2) If both a and b are defined, this returns a and b that minimize
''' sum (yi - axi -b)^2
''' i
''' The method is simple differentiate this expression w/rt a and b,
''' and solve the resulting two equations for a and b in terms of
''' various sums over the input data (xi, yi).
''' (3) We also allow two special cases, where either a = 0 or b = 0
''' (a) If a is given and b = null, find the linear LSF that
''' goes through the origin (b = 0).
''' (b) If b is given and a = null, find the linear LSF with
''' zero slope (a = 0).
''' (4) If nafit is defined, this returns an array of fitted values,
''' corresponding to the two implicit Numa arrays (nax and nay) in pta.
''' Thus, just as you can plot the data in pta as nay vs. nax,
''' you can plot the linear least square fit as nafit vs. nax.
''' Get the nax array using ptaGetArrays(pta, nax, NULL);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pa">[out][optional] - slope a of least square fit y = ax + b</param>
'''  <param name="pb">[out][optional] - intercept b of least square fit</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetLinearLSF(
				ByVal pta as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetLinearLSF( pta.Pointer, pa, pb, pnafitPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1130, 1)
' ptaGetQuadraticLSF()
' ptaGetQuadraticLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) This does a quadratic least square fit to the set of points
''' in %pta.  That is, it finds coefficients a, b and c that minimize
''' sum (yi - axixi -bxi -c)^2
''' i
''' The method is simple differentiate this expression w/rt
''' a, b and c, and solve the resulting three equations for these
''' coefficients in terms of various sums over the input data (xi, yi).
''' The three equations are in the form
''' f[0][0]a + f[0][1]b + f[0][2]c = g[0]
''' f[1][0]a + f[1][1]b + f[1][2]c = g[1]
''' f[2][0]a + f[2][1]b + f[2][2]c = g[2]
''' (2) If nafit is defined, this returns an array of fitted values,
''' corresponding to the two implicit Numa arrays (nax and nay) in pta.
''' Thus, just as you can plot the data in pta as nay vs. nax,
''' you can plot the linear least square fit as nafit vs. nax.
''' Get the nax array using ptaGetArrays(pta, nax, NULL);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pa">[out][optional] - coeff a of LSF y = ax^2 + bx + c</param>
'''  <param name="pb">[out][optional] - coeff b of LSF y = ax^2 + bx + c</param>
'''  <param name="pc">[out][optional] - coeff c of LSF y = ax^2 + bx + c</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetQuadraticLSF(
				ByVal pta as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pc as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetQuadraticLSF( pta.Pointer, pa, pb, pc, pnafitPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1243, 1)
' ptaGetCubicLSF()
' ptaGetCubicLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) This does a cubic least square fit to the set of points
''' in %pta.  That is, it finds coefficients a, b, c and d
''' that minimize
''' sum (yi - axixixi -bxixi -cxi - d)^2
''' i
''' Differentiate this expression w/rt a, b, c and d, and solve
''' the resulting four equations for these coefficients in
''' terms of various sums over the input data (xi, yi).
''' The four equations are in the form
''' f[0][0]a + f[0][1]b + f[0][2]c + f[0][3] = g[0]
''' f[1][0]a + f[1][1]b + f[1][2]c + f[1][3] = g[1]
''' f[2][0]a + f[2][1]b + f[2][2]c + f[2][3] = g[2]
''' f[3][0]a + f[3][1]b + f[3][2]c + f[3][3] = g[3]
''' (2) If nafit is defined, this returns an array of fitted values,
''' corresponding to the two implicit Numa arrays (nax and nay) in pta.
''' Thus, just as you can plot the data in pta as nay vs. nax,
''' you can plot the linear least square fit as nafit vs. nax.
''' Get the nax array using ptaGetArrays(pta, nax, NULL);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pa">[out][optional] - coeff a of LSF y = ax^3 + bx^2 + cx + d</param>
'''  <param name="pb">[out][optional] - coeff b of LSF</param>
'''  <param name="pc">[out][optional] - coeff c of LSF</param>
'''  <param name="pd">[out][optional] - coeff d of LSF</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetCubicLSF(
				ByVal pta as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pc as Single(), 
				ByRef pd as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetCubicLSF( pta.Pointer, pa, pb, pc, pd, pnafitPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1373, 1)
' ptaGetQuarticLSF()
' ptaGetQuarticLSF(PTA *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) This does a quartic least square fit to the set of points
''' in %pta.  That is, it finds coefficients a, b, c, d and 3
''' that minimize
''' sum (yi - axixixixi -bxixixi -cxixi - dxi - e)^2
''' i
''' Differentiate this expression w/rt a, b, c, d and e, and solve
''' the resulting five equations for these coefficients in
''' terms of various sums over the input data (xi, yi).
''' The five equations are in the form
''' f[0][0]a + f[0][1]b + f[0][2]c + f[0][3] + f[0][4] = g[0]
''' f[1][0]a + f[1][1]b + f[1][2]c + f[1][3] + f[1][4] = g[1]
''' f[2][0]a + f[2][1]b + f[2][2]c + f[2][3] + f[2][4] = g[2]
''' f[3][0]a + f[3][1]b + f[3][2]c + f[3][3] + f[3][4] = g[3]
''' f[4][0]a + f[4][1]b + f[4][2]c + f[4][3] + f[4][4] = g[4]
''' (2) If nafit is defined, this returns an array of fitted values,
''' corresponding to the two implicit Numa arrays (nax and nay) in pta.
''' Thus, just as you can plot the data in pta as nay vs. nax,
''' you can plot the linear least square fit as nafit vs. nax.
''' Get the nax array using ptaGetArrays(pta, nax, NULL);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pa">[out][optional] - coeff a of LSF y = ax^4 + bx^3 + cx^2 + dx + e</param>
'''  <param name="pb">[out][optional] - coeff b of LSF</param>
'''  <param name="pc">[out][optional] - coeff c of LSF</param>
'''  <param name="pd">[out][optional] - coeff d of LSF</param>
'''  <param name="pe">[out][optional] - coeff e of LSF</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetQuarticLSF(
				ByVal pta as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pc as Single(), 
				ByRef pd as Single(), 
				ByRef pe as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetQuarticLSF( pta.Pointer, pa, pb, pc, pd, pe, pnafitPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1509, 1)
' ptaNoisyLinearLSF()
' ptaNoisyLinearLSF(PTA *, l_float32, PTA **, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) This does a linear least square fit to the set of points
''' in %pta.  It then evaluates the errors and removes points
''' whose error is GT= factor  median_error.  It then re-runs
''' the linear LSF on the resulting points.
''' (2) Either or both a and b must be input.  They determine the
''' type of line that is fit.
''' (3) The median error can give an indication of how good the fit
''' is likely to be.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="factor">[in] - reject outliers with error greater than this number of medians; typically ~ 3</param>
'''  <param name="pptad">[out][optional] - with outliers removed</param>
'''  <param name="pa">[out][optional] - slope a of least square fit y = ax + b</param>
'''  <param name="pb">[out][optional] - intercept b of least square fit</param>
'''  <param name="pmederr">[out][optional] - median error</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit to ptad</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaNoisyLinearLSF(
				ByVal pta as Pta, 
				ByVal factor as Single, 
				ByRef pptad as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pmederr as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")

Dim pptadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptad) Then pptadPTR = pptad.Pointer
Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaNoisyLinearLSF( pta.Pointer, factor, pptadPTR, pa, pb, pmederr, pnafitPTR)
	if pptadPTR <> IntPtr.Zero then pptad = new Pta(pptadPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1596, 1)
' ptaNoisyQuadraticLSF()
' ptaNoisyQuadraticLSF(PTA *, l_float32, PTA **, l_float32 *, l_float32 *, l_float32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) This does a quadratic least square fit to the set of points
''' in %pta.  It then evaluates the errors and removes points
''' whose error is GT= factor  median_error.  It then re-runs
''' a quadratic LSF on the resulting points.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="factor">[in] - reject outliers with error greater than this number of medians; typically ~ 3</param>
'''  <param name="pptad">[out][optional] - with outliers removed</param>
'''  <param name="pa">[out][optional] - coeff a of LSF y = ax^2 + bx + c</param>
'''  <param name="pb">[out][optional] - coeff b of LSF y = ax^2 + bx + c</param>
'''  <param name="pc">[out][optional] - coeff c of LSF y = ax^2 + bx + c</param>
'''  <param name="pmederr">[out][optional] - median error</param>
'''  <param name="pnafit">[out][optional] - numa of least square fit to ptad</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaNoisyQuadraticLSF(
				ByVal pta as Pta, 
				ByVal factor as Single, 
				ByRef pptad as Pta, 
				ByRef pa as Single(), 
				ByRef pb as Single(), 
				ByRef pc as Single(), 
				ByRef pmederr as Single(), 
				ByRef pnafit as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")

Dim pptadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptad) Then pptadPTR = pptad.Pointer
Dim pnafitPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnafit) Then pnafitPTR = pnafit.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaNoisyQuadraticLSF( pta.Pointer, factor, pptadPTR, pa, pb, pc, pmederr, pnafitPTR)
	if pptadPTR <> IntPtr.Zero then pptad = new Pta(pptadPTR)
	if pnafitPTR <> IntPtr.Zero then pnafit = new Numa(pnafitPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (1676, 1)
' applyLinearFit()
' applyLinearFit(l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="a">[in] - linear fit coefficients</param>
'''  <param name="b">[in] - linear fit coefficients</param>
'''  <param name="x">[in] - </param>
'''  <param name="py">[out] - y = a  x + b</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function applyLinearFit(
				ByVal a as Single, 
				ByVal b as Single, 
				ByVal x as Single, 
				ByRef py as Single()) as Integer

	If IsNothing (a) then Throw New ArgumentNullException  ("a cannot be Nothing")
	If IsNothing (b) then Throw New ArgumentNullException  ("b cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.applyLinearFit( a, b, x, py)

	Return _Result
End Function

' SRC\ptafunc1.c (1700, 1)
' applyQuadraticFit()
' applyQuadraticFit(l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="a">[in] - quadratic fit coefficients</param>
'''  <param name="b">[in] - quadratic fit coefficients</param>
'''  <param name="c">[in] - quadratic fit coefficients</param>
'''  <param name="x">[in] - </param>
'''  <param name="py">[out] - y = a  x^2 + b  x + c</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function applyQuadraticFit(
				ByVal a as Single, 
				ByVal b as Single, 
				ByVal c as Single, 
				ByVal x as Single, 
				ByRef py as Single()) as Integer

	If IsNothing (a) then Throw New ArgumentNullException  ("a cannot be Nothing")
	If IsNothing (b) then Throw New ArgumentNullException  ("b cannot be Nothing")
	If IsNothing (c) then Throw New ArgumentNullException  ("c cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.applyQuadraticFit( a, b, c, x, py)

	Return _Result
End Function

' SRC\ptafunc1.c (1725, 1)
' applyCubicFit()
' applyCubicFit(l_float32, l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="a">[in] - cubic fit coefficients</param>
'''  <param name="b">[in] - cubic fit coefficients</param>
'''  <param name="c">[in] - cubic fit coefficients</param>
'''  <param name="d">[in] - cubic fit coefficients</param>
'''  <param name="x">[in] - </param>
'''  <param name="py">[out] - y = a  x^3 + b  x^2  + c  x + d</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function applyCubicFit(
				ByVal a as Single, 
				ByVal b as Single, 
				ByVal c as Single, 
				ByVal d as Single, 
				ByVal x as Single, 
				ByRef py as Single()) as Integer

	If IsNothing (a) then Throw New ArgumentNullException  ("a cannot be Nothing")
	If IsNothing (b) then Throw New ArgumentNullException  ("b cannot be Nothing")
	If IsNothing (c) then Throw New ArgumentNullException  ("c cannot be Nothing")
	If IsNothing (d) then Throw New ArgumentNullException  ("d cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.applyCubicFit( a, b, c, d, x, py)

	Return _Result
End Function

' SRC\ptafunc1.c (1751, 1)
' applyQuarticFit()
' applyQuarticFit(l_float32, l_float32, l_float32, l_float32, l_float32, l_float32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="a">[in] - quartic fit coefficients</param>
'''  <param name="b">[in] - quartic fit coefficients</param>
'''  <param name="c">[in] - quartic fit coefficients</param>
'''  <param name="d">[in] - quartic fit coefficients</param>
'''  <param name="e">[in] - quartic fit coefficients</param>
'''  <param name="x">[in] - </param>
'''  <param name="py">[out] - y = a  x^4 + b  x^3  + c  x^2 + d  x + e</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function applyQuarticFit(
				ByVal a as Single, 
				ByVal b as Single, 
				ByVal c as Single, 
				ByVal d as Single, 
				ByVal e as Single, 
				ByVal x as Single, 
				ByRef py as Single()) as Integer

	If IsNothing (a) then Throw New ArgumentNullException  ("a cannot be Nothing")
	If IsNothing (b) then Throw New ArgumentNullException  ("b cannot be Nothing")
	If IsNothing (c) then Throw New ArgumentNullException  ("c cannot be Nothing")
	If IsNothing (d) then Throw New ArgumentNullException  ("d cannot be Nothing")
	If IsNothing (e) then Throw New ArgumentNullException  ("e cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.applyQuarticFit( a, b, c, d, e, x, py)

	Return _Result
End Function

' SRC\ptafunc1.c (1792, 1)
' pixPlotAlongPta()
' pixPlotAlongPta(PIX *, PTA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a debugging function.
''' (2) Removes existing colormaps and clips the pta to the input %pixs.
''' (3) If the image is RGB, three separate plots are generated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="pta">[in] - set of points on which to plot</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="title">[in][optional] - for plot; can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixPlotAlongPta(
				ByVal pixs as Pix, 
				ByVal pta as Pta, 
				ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				ByVal title as String) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixPlotAlongPta( pixs.Pointer, pta.Pointer, outformat, title)

	Return _Result
End Function

' SRC\ptafunc1.c (1893, 1)
' ptaGetPixelsFromPix()
' ptaGetPixelsFromPix(PIX *, BOX *) as PTA *
'''  <summary>
''' Notes
''' (1) Generates a pta of fg pixels in the pix, within the box.
''' If box == NULL, it uses the entire pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="box">[in][optional] - can be null</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaGetPixelsFromPix(
				ByVal pixs as Pix, 
				ByVal box as Box) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaGetPixelsFromPix( pixs.Pointer, boxPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (1946, 1)
' pixGenerateFromPta()
' pixGenerateFromPta(PTA *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Points are rounded to nearest ints.
''' (2) Any points outside (w,h) are silently discarded.
''' (3) Output 1 bpp pix has values 1 for each point in the pta.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="w">[in] - of pix</param>
'''  <param name="h">[in] - of pix</param>
'''   <returns>pix 1 bpp, or NULL on error</returns>
Public Shared Function pixGenerateFromPta(
				ByVal pta as Pta, 
				ByVal w as Integer, 
				ByVal h as Integer) as Pix

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenerateFromPta( pta.Pointer, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ptafunc1.c (1987, 1)
' ptaGetBoundaryPixels()
' ptaGetBoundaryPixels(PIX *, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) This generates a pta of either fg or bg boundary pixels.
''' (2) See also pixGeneratePtaBoundary() for rendering of
''' fg boundary pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="type">[in] - L_BOUNDARY_FG, L_BOUNDARY_BG</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaGetBoundaryPixels(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_BOUNDARY_G) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaGetBoundaryPixels( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (2036, 1)
' ptaaGetBoundaryPixels()
' ptaaGetBoundaryPixels(PIX *, l_int32, l_int32, BOXA **, PIXA **) as PTAA *
'''  <summary>
''' Notes
''' (1) This generates a ptaa of either fg or bg boundary pixels,
''' where each pta has the boundary pixels for a connected
''' component.
''' (2) We can't simply find all the boundary pixels and then select
''' those within the bounding box of each component, because
''' bounding boxes can overlap.  It is necessary to extract and
''' dilate or erode each component separately.  Note also that
''' special handling is required for bg pixels when the
''' component touches the pix boundary.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="type">[in] - L_BOUNDARY_FG, L_BOUNDARY_BG</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="pboxa">[out][optional] - bounding boxes of the c.c.</param>
'''  <param name="ppixa">[out][optional] - pixa of the c.c.</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaGetBoundaryPixels(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_BOUNDARY_G, 
				ByVal connectivity as Integer, 
				ByRef pboxa as Boxa, 
				ByRef ppixa as Pixa) as Ptaa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer
Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaaGetBoundaryPixels( pixs.Pointer, type, connectivity, pboxaPTR, ppixaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)

	Return  new Ptaa(_Result)
End Function

' SRC\ptafunc1.c (2119, 1)
' ptaaIndexLabeledPixels()
' ptaaIndexLabeledPixels(PIX *, l_int32 *) as PTAA *
'''  <summary>
''' Notes
''' (1) The pixel values in %pixs are the index of the connected component
''' to which the pixel belongs; %pixs is typically generated from
''' a 1 bpp pix by pixConnCompTransform().  Background pixels in
''' the generating 1 bpp pix are represented in %pixs by 0.
''' We do not check that the pixel values are correctly labelled.
''' (2) Each pta in the returned ptaa gives the pixel locations
''' correspnding to a connected component, with the label of each
''' given by the index of the pta into the ptaa.
''' (3) Initialize with the first pta in ptaa being empty and
''' representing the background value (index 0) in the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp, of indices of c.c.</param>
'''  <param name="pncc">[out][optional] - number of connected components</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaIndexLabeledPixels(
				ByVal pixs as Pix, 
				ByRef pncc as Integer) as Ptaa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaaIndexLabeledPixels( pixs.Pointer, pncc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\ptafunc1.c (2176, 1)
' ptaGetNeighborPixLocs()
' ptaGetNeighborPixLocs(PIX *, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) Generates a pta of all valid neighbor pixel locations,
''' or NULL on error.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="x">[in] - pixel from which we search for nearest neighbors</param>
'''  <param name="y">[in] - pixel from which we search for nearest neighbors</param>
'''  <param name="conn">[in] - 4 or 8 connectivity</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaGetNeighborPixLocs(
				ByVal pixs as Pix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal conn as Integer) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaGetNeighborPixLocs( pixs.Pointer, x, y, conn)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (2232, 1)
' numaConvertToPta1()
' numaConvertToPta1(NUMA *) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - numa with implicit y(x)</param>
'''   <returns>pta if OK; null on error</returns>
Public Shared Function numaConvertToPta1(
				ByVal na as Numa) as Pta

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaConvertToPta1( na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (2262, 1)
' numaConvertToPta2()
' numaConvertToPta2(NUMA *, NUMA *) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nax">[in] - </param>
'''  <param name="nay">[in] - </param>
'''   <returns>pta if OK; null on error</returns>
Public Shared Function numaConvertToPta2(
				ByVal nax as Numa, 
				ByVal nay as Numa) as Pta

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaConvertToPta2( nax.Pointer, nay.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (2298, 1)
' ptaConvertToNuma()
' ptaConvertToNuma(PTA *, NUMA **, NUMA **) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="pnax">[out] - addr of nax</param>
'''  <param name="pnay">[out] - addr of nay</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaConvertToNuma(
				ByVal pta as Pta, 
				ByRef pnax as Numa, 
				ByRef pnay as Numa) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

	Dim pnaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnax) Then pnaxPTR = pnax.Pointer
	Dim pnayPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnay) Then pnayPTR = pnay.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaConvertToNuma( pta.Pointer, pnaxPTR, pnayPTR)
	if pnaxPTR <> IntPtr.Zero then pnax = new Numa(pnaxPTR)
	if pnayPTR <> IntPtr.Zero then pnay = new Numa(pnayPTR)

	Return _Result
End Function

' SRC\ptafunc1.c (2349, 1)
' pixDisplayPta()
' pixDisplayPta(PIX *, PIX *, PTA *) as PIX *
'''  <summary>
''' Notes
''' (1) To write on an existing pixs, pixs must be 32 bpp and
''' call with pixd == pixs
''' pixDisplayPta(pixs, pixs, pta);
''' To write to a new pix, use pixd == NULL and call
''' pixd = pixDisplayPta(NULL, pixs, pta);
''' (2) On error, returns pixd to avoid losing pixs if called as
''' pixs = pixDisplayPta(pixs, pixs, pta);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - can be same as pixs or NULL; 32 bpp if in-place</param>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="pta">[in] - of path to be plotted</param>
'''   <returns>pixd 32 bpp RGB version of pixs, with path in green.</returns>
Public Shared Function pixDisplayPta(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pta as Pta) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayPta( pixd.Pointer, pixs.Pointer, pta.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ptafunc1.c (2415, 1)
' pixDisplayPtaaPattern()
' pixDisplayPtaaPattern(PIX *, PIX *, PTAA *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) To write on an existing pixs, pixs must be 32 bpp and
''' call with pixd == pixs
''' pixDisplayPtaPattern(pixs, pixs, pta, ...);
''' To write to a new pix, use pixd == NULL and call
''' pixd = pixDisplayPtaPattern(NULL, pixs, pta, ...);
''' (2) Puts a random color on each pattern associated with a pta.
''' (3) On error, returns pixd to avoid losing pixs if called as
''' pixs = pixDisplayPtaPattern(pixs, pixs, pta, ...);
''' (4) A typical pattern to be used is a circle, generated with
''' generatePtaFilledCircle()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 32 bpp</param>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp; 32 bpp if in place</param>
'''  <param name="ptaa">[in] - giving locations at which the pattern is displayed</param>
'''  <param name="pixp">[in] - 1 bpp pattern to be placed such that its reference point co-locates with each point in pta</param>
'''  <param name="cx">[in] - reference point in pattern</param>
'''  <param name="cy">[in] - reference point in pattern</param>
'''   <returns>pixd 32 bpp RGB version of pixs.</returns>
Public Shared Function pixDisplayPtaaPattern(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal ptaa as Ptaa, 
				ByVal pixp as Pix, 
				ByVal cx as Integer, 
				ByVal cy as Integer) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	If IsNothing (pixp) then Throw New ArgumentNullException  ("pixp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayPtaaPattern( pixd.Pointer, pixs.Pointer, ptaa.Pointer, pixp.Pointer, cx, cy)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ptafunc1.c (2482, 1)
' pixDisplayPtaPattern()
' pixDisplayPtaPattern(PIX *, PIX *, PTA *, PIX *, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) To write on an existing pixs, pixs must be 32 bpp and
''' call with pixd == pixs
''' pixDisplayPtaPattern(pixs, pixs, pta, ...);
''' To write to a new pix, use pixd == NULL and call
''' pixd = pixDisplayPtaPattern(NULL, pixs, pta, ...);
''' (2) On error, returns pixd to avoid losing pixs if called as
''' pixs = pixDisplayPtaPattern(pixs, pixs, pta, ...);
''' (3) A typical pattern to be used is a circle, generated with
''' generatePtaFilledCircle()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - can be same as pixs or NULL; 32 bpp if in-place</param>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="pta">[in] - giving locations at which the pattern is displayed</param>
'''  <param name="pixp">[in] - 1 bpp pattern to be placed such that its reference point co-locates with each point in pta</param>
'''  <param name="cx">[in] - reference point in pattern</param>
'''  <param name="cy">[in] - reference point in pattern</param>
'''  <param name="color">[in] - in 0xrrggbb00 format</param>
'''   <returns>pixd 32 bpp RGB version of pixs.</returns>
Public Shared Function pixDisplayPtaPattern(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pta as Pta, 
				ByVal pixp as Pix, 
				ByVal cx as Integer, 
				ByVal cy as Integer, 
				ByVal color as UInteger) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (pixp) then Throw New ArgumentNullException  ("pixp cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayPtaPattern( pixd.Pointer, pixs.Pointer, pta.Pointer, pixp.Pointer, cx, cy, color)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ptafunc1.c (2542, 1)
' ptaReplicatePattern()
' ptaReplicatePattern(PTA *, PIX *, PTA *, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) You can use either the image %pixp or the set of pts %ptap.
''' (2) The pattern is placed with its reference point at each point
''' in ptas, and all the fg pixels are colleced into ptad.
''' For %pixp, this is equivalent to blitting pixp at each point
''' in ptas, and then converting the resulting pix to a pta.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - "sparse" input pta</param>
'''  <param name="pixp">[in][optional] - 1 bpp pattern, to be replicated in output pta</param>
'''  <param name="ptap">[in][optional] - set of pts, to be replicated in output pta</param>
'''  <param name="cx">[in] - reference point in pattern</param>
'''  <param name="cy">[in] - reference point in pattern</param>
'''  <param name="w">[in] - clipping sizes for output pta</param>
'''  <param name="h">[in] - clipping sizes for output pta</param>
'''   <returns>ptad with all points of replicated pattern, or NULL on error</returns>
Public Shared Function ptaReplicatePattern(
				ByVal ptas as Pta, 
				ByVal pixp as Pix, 
				ByVal ptap as Pta, 
				ByVal cx as Integer, 
				ByVal cy as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim pixpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixp) Then pixpPTR = pixp.Pointer
	Dim ptapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ptap) Then ptapPTR = ptap.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaReplicatePattern( ptas.Pointer, pixpPTR, ptapPTR, cx, cy, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc1.c (2594, 1)
' pixDisplayPtaa()
' pixDisplayPtaa(PIX *, PTAA *) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="ptaa">[in] - array of paths to be plotted</param>
'''   <returns>pixd 32 bpp RGB version of pixs, with paths plotted in different colors, or NULL on error</returns>
Public Shared Function pixDisplayPtaa(
				ByVal pixs as Pix, 
				ByVal ptaa as Ptaa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayPtaa( pixs.Pointer, ptaa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
