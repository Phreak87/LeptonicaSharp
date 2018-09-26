Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\boxfunc1.c (99, 1)
' boxContains()
' boxContains(BOX *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="presult">[out] - 1 if box2 is entirely contained within box1, and 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxContains(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByRef presult as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxContains( box1.Pointer, box2.Pointer, presult)

	Return _Result
End Function

' SRC\boxfunc1.c (130, 1)
' boxIntersects()
' boxIntersects(BOX *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="presult">[out] - 1 if any part of box2 is contained in box1, and 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxIntersects(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByRef presult as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxIntersects( box1.Pointer, box2.Pointer, presult)

	Return _Result
End Function

' SRC\boxfunc1.c (172, 1)
' boxaContainedInBox()
' boxaContainedInBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' Notes
''' (1) All boxes in boxa that are entirely outside box are removed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="box">[in] - for containment</param>
'''   <returns>boxad boxa with all boxes in boxas that are entirely contained in box, or NULL on error</returns>
Public Shared Function boxaContainedInBox(
				ByVal boxas as Boxa, 
				ByVal box as Box) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaContainedInBox( boxas.Pointer, box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (210, 1)
' boxaContainedInBoxCount()
' boxaContainedInBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - for selecting contained boxes in %boxa</param>
'''  <param name="pcount">[out] - number of boxes intersecting the box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaContainedInBoxCount(
				ByVal boxa as Boxa, 
				ByVal box as Box, 
				ByRef pcount as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaContainedInBoxCount( boxa.Pointer, box.Pointer, pcount)

	Return _Result
End Function

' SRC\boxfunc1.c (249, 1)
' boxaContainedInBoxa()
' boxaContainedInBoxa(BOXA *, BOXA *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa1">[in] - </param>
'''  <param name="boxa2">[in] - </param>
'''  <param name="pcontained">[out] - 1 if every box in boxa2 is contained in some box in boxa1; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaContainedInBoxa(
				ByVal boxa1 as Boxa, 
				ByVal boxa2 as Boxa, 
				ByRef pcontained as Integer) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaContainedInBoxa( boxa1.Pointer, boxa2.Pointer, pcontained)

	Return _Result
End Function

' SRC\boxfunc1.c (302, 1)
' boxaIntersectsBox()
' boxaIntersectsBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' Notes
''' (1) All boxes in boxa that intersect with box (i.e., are completely
''' or partially contained in box) are retained.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="box">[in] - for intersecting</param>
'''   <returns>boxad boxa with all boxes in boxas that intersect box, or NULL on error</returns>
Public Shared Function boxaIntersectsBox(
				ByVal boxas as Boxa, 
				ByVal box as Box) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaIntersectsBox( boxas.Pointer, box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (340, 1)
' boxaIntersectsBoxCount()
' boxaIntersectsBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - for selecting intersecting boxes in %boxa</param>
'''  <param name="pcount">[out] - number of boxes intersecting the box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaIntersectsBoxCount(
				ByVal boxa as Boxa, 
				ByVal box as Box, 
				ByRef pcount as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaIntersectsBoxCount( boxa.Pointer, box.Pointer, pcount)

	Return _Result
End Function

' SRC\boxfunc1.c (385, 1)
' boxaClipToBox()
' boxaClipToBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' Notes
''' (1) All boxes in boxa not intersecting with box are removed, and
''' the remaining boxes are clipped to box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="box">[in] - for clipping</param>
'''   <returns>boxad boxa with boxes in boxas clipped to box, or NULL on error</returns>
Public Shared Function boxaClipToBox(
				ByVal boxas as Boxa, 
				ByVal box as Box) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaClipToBox( boxas.Pointer, box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (442, 1)
' boxaCombineOverlaps()
' boxaCombineOverlaps(BOXA *, PIXA *) as BOXA *
'''  <summary>
''' Notes
''' (1) If there are no overlapping boxes, it simply returns a copy
''' of %boxas.
''' (2) Input an empty %pixadb, using pixaCreate(0), for debug output.
''' The output gives 2 visualizations of the boxes per iteration;
''' boxes in red before, and added boxes in green after. Note that
''' all pixels in the red boxes are contained in the green ones.
''' (3) The alternative method of painting each rectangle and finding
''' the 4-connected components gives a different result in
''' general, because two non-overlapping (but touching)
''' rectangles, when rendered, are 4-connected and will be joined.
''' (4) A bad case computationally is to have n boxes, none of which
''' overlap.  Then you have one iteration with O(n^2) compares.
''' This is still faster than painting each rectangle and finding
''' the bounding boxes of the connected components, even for
''' thousands of rectangles.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="pixadb">[in,out] - debug output</param>
'''   <returns>boxad where each set of boxes in boxas that overlap are combined into a single bounding box in boxad, or NULL on error.</returns>
Public Shared Function boxaCombineOverlaps(
				ByVal boxas as Boxa, 
				ByRef pixadb as Pixa) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaCombineOverlaps( boxas.Pointer, pixadbPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (536, 1)
' boxaCombineOverlapsInPair()
' boxaCombineOverlapsInPair(BOXA *, BOXA *, BOXA **, BOXA **, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) One of three things happens to each box in %boxa1 and %boxa2
''' it gets absorbed into a larger box that it overlaps with
''' it absorbs a smaller (by area) box that it overlaps with
''' and gets larger, using the bounding region of the 2 boxes
''' it is unchanged (including absorbing smaller boxes that
''' are contained within it).
''' (2) If all the boxes from one of the input boxa are absorbed, this
''' returns an empty boxa.
''' (3) Input an empty %pixadb, using pixaCreate(0), for debug output
''' (4) This is useful if different operations are to be carried out
''' on possibly overlapping rectangular regions, and it is desired
''' to have only one operation on any rectangular region.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas1">[in] - input boxa1</param>
'''  <param name="boxas2">[in] - input boxa2</param>
'''  <param name="pboxad1">[out] - output boxa1</param>
'''  <param name="pboxad2">[out] - output boxa2</param>
'''  <param name="pixadb">[in,out] - debug output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaCombineOverlapsInPair(
				ByVal boxas1 as Boxa, 
				ByVal boxas2 as Boxa, 
				ByRef pboxad1 as Boxa, 
				ByRef pboxad2 as Boxa, 
				ByRef pixadb as Pixa) as Integer

	If IsNothing (boxas1) then Throw New ArgumentNullException  ("boxas1 cannot be Nothing")
	If IsNothing (boxas2) then Throw New ArgumentNullException  ("boxas2 cannot be Nothing")

	Dim pboxad1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad1) Then pboxad1PTR = pboxad1.Pointer
	Dim pboxad2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad2) Then pboxad2PTR = pboxad2.Pointer
Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaCombineOverlapsInPair( boxas1.Pointer, boxas2.Pointer, pboxad1PTR, pboxad2PTR, pixadbPTR)
	if pboxad1PTR <> IntPtr.Zero then pboxad1 = new Boxa(pboxad1PTR)
	if pboxad2PTR <> IntPtr.Zero then pboxad2 = new Boxa(pboxad2PTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (674, 1)
' boxOverlapRegion()
' boxOverlapRegion(BOX *, BOX *) as BOX *
'''  <summary>
''' Notes
''' (1) This is the geometric intersection of the two rectangles.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes</param>
'''  <param name="box2">[in] - two boxes</param>
'''   <returns>box of overlap region between input boxes, or NULL if no overlap or on error</returns>
Public Shared Function boxOverlapRegion(
				ByVal box1 as Box, 
				ByVal box2 as Box) as Box

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxOverlapRegion( box1.Pointer, box2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (716, 1)
' boxBoundingRegion()
' boxBoundingRegion(BOX *, BOX *) as BOX *
'''  <summary>
''' Notes
''' (1) This is the geometric union of the two rectangles.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes</param>
'''  <param name="box2">[in] - two boxes</param>
'''   <returns>box of bounding region containing the input boxes, or NULL on error</returns>
Public Shared Function boxBoundingRegion(
				ByVal box1 as Box, 
				ByVal box2 as Box) as Box

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxBoundingRegion( box1.Pointer, box2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (756, 1)
' boxOverlapFraction()
' boxOverlapFraction(BOX *, BOX *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The result depends on the order of the input boxes,
''' because the overlap is taken as a fraction of box2.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes</param>
'''  <param name="box2">[in] - two boxes</param>
'''  <param name="pfract">[out] - the fraction of box2 overlapped by box1</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function boxOverlapFraction(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByRef pfract as Single()) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxOverlapFraction( box1.Pointer, box2.Pointer, pfract)

	Return _Result
End Function

' SRC\boxfunc1.c (792, 1)
' boxOverlapArea()
' boxOverlapArea(BOX *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes</param>
'''  <param name="box2">[in] - two boxes</param>
'''  <param name="parea">[out] - the number of pixels in the overlap</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function boxOverlapArea(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByRef parea as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxOverlapArea( box1.Pointer, box2.Pointer, parea)

	Return _Result
End Function

' SRC\boxfunc1.c (853, 1)
' boxaHandleOverlaps()
' boxaHandleOverlaps(BOXA *, l_int32, l_int32, l_float32, l_float32, NUMA **) as BOXA *
'''  <summary>
''' Notes
''' (1) For all n(n-1)/2 box pairings, if two boxes overlap, either
''' (a) op == L_COMBINE get the bounding region for the two,
''' replace the larger with the bounding region, and remove
''' the smaller of the two, or
''' (b) op == L_REMOVE_SMALL just remove the smaller.
''' (2) If boxas is 2D sorted, range can be small, but if it is
''' not spatially sorted, range should be large to allow all
''' pairwise comparisons to be made.
''' (3) The %min_overlap parameter allows ignoring small overlaps.
''' If %min_overlap == 1.0, only boxes fully contained in larger
''' boxes can be considered for removal; if %min_overlap == 0.0,
''' this constraint is ignored.
''' (4) The %max_ratio parameter allows ignoring overlaps between
''' boxes that are not too different in size.  If %max_ratio == 0.0,
''' no boxes can be removed; if %max_ratio == 1.0, this constraint
''' is ignored.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="op">[in] - L_COMBINE, L_REMOVE_SMALL</param>
'''  <param name="range">[in] - GT 0, forward distance over which overlaps are checked</param>
'''  <param name="min_overlap">[in] - minimum fraction of smaller box required for overlap to count; 0.0 to ignore</param>
'''  <param name="max_ratio">[in] - maximum fraction of small/large areas for overlap to count; 1.0 to ignore</param>
'''  <param name="pnamap">[out][optional] - combining map</param>
'''   <returns>boxad, or NULL on error.</returns>
Public Shared Function boxaHandleOverlaps(
				ByVal boxas as Boxa, 
				ByVal op as Enumerations.L_hling_overlapping_bounding_boxes_in_boxa, 
				ByVal range as Integer, 
				ByVal min_overlap as Single, 
				ByVal max_ratio as Single, 
				Optional ByRef pnamap as Numa = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (min_overlap) then Throw New ArgumentNullException  ("min_overlap cannot be Nothing")
	If IsNothing (max_ratio) then Throw New ArgumentNullException  ("max_ratio cannot be Nothing")

Dim pnamapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnamap) Then pnamapPTR = pnamap.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaHandleOverlaps( boxas.Pointer, op, range, min_overlap, max_ratio, pnamapPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnamapPTR <> IntPtr.Zero then pnamap = new Numa(pnamapPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (973, 1)
' boxSeparationDistance()
' boxSeparationDistance(BOX *, BOX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This measures horizontal and vertical separation of the
''' two boxes.  If the boxes are touching but have no pixels
''' in common, the separation is 0.  If the boxes overlap by
''' a distance d, the returned separation is -d.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes, in any order</param>
'''  <param name="box2">[in] - two boxes, in any order</param>
'''  <param name="ph_sep">[out][optional] - horizontal separation</param>
'''  <param name="pv_sep">[out][optional] - vertical separation</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSeparationDistance(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				Optional ByRef ph_sep as Integer = Nothing, 
				Optional ByRef pv_sep as Integer = Nothing) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxSeparationDistance( box1.Pointer, box2.Pointer, ph_sep, pv_sep)

	Return _Result
End Function

' SRC\boxfunc1.c (1029, 1)
' boxCompareSize()
' boxCompareSize(BOX *, BOX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) We're re-using the SORT enum for these comparisons.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="type">[in] - L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA,</param>
'''  <param name="prel">[out] - 1 if box1 GT box2, 0 if the same, -1 if box1 LT box2</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxCompareSize(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByVal type as Enumerations.L_SORT_BY, 
				ByRef prel as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxCompareSize( box1.Pointer, box2.Pointer, type, prel)

	Return _Result
End Function

' SRC\boxfunc1.c (1080, 1)
' boxContainsPt()
' boxContainsPt(BOX *, l_float32, l_float32, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="x">[in] - a point</param>
'''  <param name="y">[in] - a point</param>
'''  <param name="pcontains">[out] - 1 if box contains point; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function boxContainsPt(
				ByVal box as Box, 
				ByVal x as Single, 
				ByVal y as Single, 
				ByRef pcontains as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")
	If IsNothing (y) then Throw New ArgumentNullException  ("y cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxContainsPt( box.Pointer, x, y, pcontains)

	Return _Result
End Function

' SRC\boxfunc1.c (1115, 1)
' boxaGetNearestToPt()
' boxaGetNearestToPt(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) Uses euclidean distance between centroid and point.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="x">[in] - point</param>
'''  <param name="y">[in] - point</param>
'''   <returns>box with centroid closest to the given point [x,y], or NULL if no boxes in boxa</returns>
Public Shared Function boxaGetNearestToPt(
				ByVal boxa as Boxa, 
				ByVal x as Integer, 
				ByVal y as Integer) as Box

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaGetNearestToPt( boxa.Pointer, x, y)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1167, 1)
' boxaGetNearestToLine()
' boxaGetNearestToLine(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) For a horizontal line at some value y, get the minimum of the
''' distance |yc - y| from the box centroid yc value to y;
''' likewise minimize |xc - x| for a vertical line at x.
''' (2) Input y LT 0, x GT= 0 to indicate a vertical line at x, and
''' x LT 0, y GT= 0 for a horizontal line at y.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="x">[in] - (y = -1 for vertical line; x = -1 for horiz line)</param>
'''  <param name="y">[in] - (y = -1 for vertical line; x = -1 for horiz line)</param>
'''   <returns>box with centroid closest to the given line, or NULL if no boxes in boxa</returns>
Public Shared Function boxaGetNearestToLine(
				ByVal boxa as Boxa, 
				ByVal x as Integer, 
				ByVal y as Integer) as Box

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaGetNearestToLine( boxa.Pointer, x, y)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1224, 1)
' boxaFindNearestBoxes()
' boxaFindNearestBoxes(BOXA *, l_int32, l_int32, NUMAA **, NUMAA **) as l_ok
'''  <summary>
''' Notes
''' (1) See boxaGetNearestByDirection() for usage of %dist_select
''' and %range.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
'''  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
'''  <param name="range">[in] - search distance from box i; use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
'''  <param name="pnaaindex">[out] - for each box in %boxa, contains a numa of 4 box indices (per direction) of the nearest box</param>
'''  <param name="pnaadist">[out] - for each box in %boxa, this contains a numa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaFindNearestBoxes(
				ByVal boxa as Boxa, 
				ByVal dist_select as Enumerations.L_value_, 
				ByVal range as Integer, 
				ByRef pnaaindex as Numaa, 
				ByRef pnaadist as Numaa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim pnaaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaaindex) Then pnaaindexPTR = pnaaindex.Pointer
	Dim pnaadistPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaadist) Then pnaadistPTR = pnaadist.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaFindNearestBoxes( boxa.Pointer, dist_select, range, pnaaindexPTR, pnaadistPTR)
	if pnaaindexPTR <> IntPtr.Zero then pnaaindex = new Numaa(pnaaindexPTR)
	if pnaadistPTR <> IntPtr.Zero then pnaadist = new Numaa(pnaadistPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (1305, 1)
' boxaGetNearestByDirection()
' boxaGetNearestByDirection(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) For efficiency, use a LR/TD sorted %boxa, which can be
''' made by flattening a 2D sorted boxaa.  In that case,
''' %range can be some positive integer like 50.
''' (2) If boxes overlap, the distance will be LT 0.  Use %dist_select
''' to determine if these should count or not.  If L_ALL, then
''' one box will match as the nearest to another in 2 or more
''' directions.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
'''  <param name="i">[in] - box we test against</param>
'''  <param name="dir">[in] - direction to look L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
'''  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
'''  <param name="range">[in] - search distance from box i; use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
'''  <param name="pindex">[out] - index in boxa of nearest box with overlapping coordinates in the indicated direction; -1 if there is no box</param>
'''  <param name="pdist">[out] - distance of the nearest box in the indicated direction; 100000 if no box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetNearestByDirection(
				ByVal boxa as Boxa, 
				ByVal i as Integer, 
				ByVal dir as Enumerations.L_scan_direction, 
				ByVal dist_select as Enumerations.L_value_, 
				ByVal range as Integer, 
				ByRef pindex as Integer, 
				ByRef pdist as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetNearestByDirection( boxa.Pointer, i, dir, dist_select, range, pindex, pdist)

	Return _Result
End Function

' SRC\boxfunc1.c (1444, 1)
' boxGetCenter()
' boxGetCenter(BOX *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="pcx">[out] - location of center of box</param>
'''  <param name="pcy">[out] - location of center of box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetCenter(
				ByVal box as Box, 
				ByRef pcx as Single(), 
				ByRef pcy as Single()) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxGetCenter( box.Pointer, pcx, pcy)

	Return _Result
End Function

' SRC\boxfunc1.c (1485, 1)
' boxIntersectByLine()
' boxIntersectByLine(BOX *, l_int32, l_int32, l_float32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) If the intersection is at only one point (a corner), the
''' coordinates are returned in (x1, y1).
''' (2) Represent a vertical line by one with a large but finite slope.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="x">[in] - point that line goes through</param>
'''  <param name="y">[in] - point that line goes through</param>
'''  <param name="slope">[in] - of line</param>
'''  <param name="px1">[out] - 1st point of intersection with box</param>
'''  <param name="py1">[out] - 1st point of intersection with box</param>
'''  <param name="px2">[out] - 2nd point of intersection with box</param>
'''  <param name="py2">[out] - 2nd point of intersection with box</param>
'''  <param name="pn">[out] - number of points of intersection</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxIntersectByLine(
				ByVal box as Box, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal slope as Single, 
				ByRef px1 as Integer, 
				ByRef py1 as Integer, 
				ByRef px2 as Integer, 
				ByRef py2 as Integer, 
				ByRef pn as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (slope) then Throw New ArgumentNullException  ("slope cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxIntersectByLine( box.Pointer, x, y, slope, px1, py1, px2, py2, pn)

	Return _Result
End Function

' SRC\boxfunc1.c (1587, 1)
' boxClipToRectangle()
' boxClipToRectangle(BOX *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This can be used to clip a rectangle to an image.
''' The clipping rectangle is assumed to have a UL corner at (0, 0),
''' and a LR corner at (wi - 1, hi - 1).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="wi">[in] - rectangle representing image</param>
'''  <param name="hi">[in] - rectangle representing image</param>
'''   <returns>part of box within given rectangle, or NULL on error or if box is entirely outside the rectangle</returns>
Public Shared Function boxClipToRectangle(
				ByVal box as Box, 
				ByVal wi as Integer, 
				ByVal hi as Integer) as Box

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxClipToRectangle( box.Pointer, wi, hi)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1644, 1)
' boxClipToRectangleParams()
' boxClipToRectangleParams(BOX *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The return value should be checked.  If it is 1, the
''' returned parameter values are bogus.
''' (2) This simplifies the selection of pixel locations within
''' a given rectangle
''' for (i = ystart; i LT yend; i++ {
''' ...
''' for (j = xstart; j LT xend; j++ {
''' ....
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in][optional] - requested box; can be null</param>
'''  <param name="w">[in] - clipping box size; typ. the size of an image</param>
'''  <param name="h">[in] - clipping box size; typ. the size of an image</param>
'''  <param name="pxstart">[out] - start x coordinate</param>
'''  <param name="pystart">[out] - start y coordinate</param>
'''  <param name="pxend">[out] - one pixel beyond clipping box</param>
'''  <param name="pyend">[out] - one pixel beyond clipping box</param>
'''  <param name="pbw">[out][optional] - clipped width</param>
'''  <param name="pbh">[out][optional] - clipped height</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function boxClipToRectangleParams(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByRef pxstart as Integer, 
				ByRef pystart as Integer, 
				ByRef pxend as Integer, 
				ByRef pyend as Integer, 
				Optional ByVal box as Box = Nothing, 
				Optional ByRef pbw as Integer = Nothing, 
				Optional ByRef pbh as Integer = Nothing) as Integer


	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxClipToRectangleParams( boxPTR, w, h, pxstart, pystart, pxend, pyend, pbw, pbh)

	Return _Result
End Function

' SRC\boxfunc1.c (1706, 1)
' boxRelocateOneSide()
' boxRelocateOneSide(BOX *, BOX *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) Set boxd == NULL to get new box; boxd == boxs for in-place;
''' or otherwise to resize existing boxd.
''' (2) For usage, suggest one of these
''' boxd = boxRelocateOneSide(NULL, boxs, ...);   // new
''' boxRelocateOneSide(boxs, boxs, ...); // in-place
''' boxRelocateOneSide(boxd, boxs, ...); // other
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxd">[in][optional] - ; this can be null, equal to boxs, or different from boxs;</param>
'''  <param name="boxs">[in] - starting box; to have one side relocated</param>
'''  <param name="loc">[in] - new location of the side that is changing</param>
'''  <param name="sideflag">[in] - L_FROM_LEFT, etc., indicating the side that moves</param>
'''   <returns>boxd, or NULL on error or if the computed boxd has width or height LT= 0.</returns>
Public Shared Function boxRelocateOneSide(
				ByVal boxs as Box, 
				ByVal loc as Integer, 
				ByVal sideflag as Enumerations.L_scan_direction, 
				Optional ByVal boxd as Box = Nothing) as Box

	If IsNothing (boxs) then Throw New ArgumentNullException  ("boxs cannot be Nothing")

	Dim boxdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxd) Then boxdPTR = boxd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxRelocateOneSide( boxdPTR, boxs.Pointer, loc, sideflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1750, 1)
' boxaAdjustSides()
' boxaAdjustSides(BOXA *, l_int32, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) New box dimensions are cropped at left and top to x GT= 0 and y GT= 0.
''' (2) If the width or height of a box goes to 0, we generate a box with
''' w == 1 and h == 1, as a placeholder.
''' (3) See boxAdjustSides().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="delleft">[in] - changes in location of each side for each box</param>
'''  <param name="delright">[in] - changes in location of each side for each box</param>
'''  <param name="deltop">[in] - changes in location of each side for each box</param>
'''  <param name="delbot">[in] - changes in location of each side for each box</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaAdjustSides(
				ByVal boxas as Boxa, 
				ByVal delleft as Integer, 
				ByVal delright as Integer, 
				ByVal deltop as Integer, 
				ByVal delbot as Integer) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaAdjustSides( boxas.Pointer, delleft, delright, deltop, delbot)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (1807, 1)
' boxAdjustSides()
' boxAdjustSides(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) Set boxd == NULL to get new box; boxd == boxs for in-place;
''' or otherwise to resize existing boxd.
''' (2) For usage, suggest one of these
''' boxd = boxAdjustSides(NULL, boxs, ...);   // new
''' boxAdjustSides(boxs, boxs, ...); // in-place
''' boxAdjustSides(boxd, boxs, ...); // other
''' (3) New box dimensions are cropped at left and top to x GT= 0 and y GT= 0.
''' (4) For example, to expand in-place by 20 pixels on each side, use
''' boxAdjustSides(box, box, -20, 20, -20, 20);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxd">[in][optional] - ; this can be null, equal to boxs, or different from boxs</param>
'''  <param name="boxs">[in] - starting box; to have sides adjusted</param>
'''  <param name="delleft">[in] - changes in location of each side</param>
'''  <param name="delright">[in] - changes in location of each side</param>
'''  <param name="deltop">[in] - changes in location of each side</param>
'''  <param name="delbot">[in] - changes in location of each side</param>
'''   <returns>boxd, or NULL on error or if the computed boxd has width or height LT= 0.</returns>
Public Shared Function boxAdjustSides(
				ByVal boxs as Box, 
				ByVal delleft as Integer, 
				ByVal delright as Integer, 
				ByVal deltop as Integer, 
				ByVal delbot as Integer, 
				Optional ByVal boxd as Box = Nothing) as Box

	If IsNothing (boxs) then Throw New ArgumentNullException  ("boxs cannot be Nothing")

	Dim boxdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxd) Then boxdPTR = boxd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxAdjustSides( boxdPTR, boxs.Pointer, delleft, delright, deltop, delbot)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1859, 1)
' boxaSetSide()
' boxaSetSide(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) Sets the given side of each box.  Use boxad == NULL for a new
''' boxa, and boxad == boxas for in-place.
''' (2) Use one of these
''' boxad = boxaSetSide(NULL, boxas, ...);   // new
''' boxaSetSide(boxas, boxas, ...);  // in-place
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - use NULL to get a new one; same as boxas for in-place</param>
'''  <param name="boxas">[in] - </param>
'''  <param name="side">[in] - L_SET_LEFT, L_SET_RIGHT, L_SET_TOP, L_SET_BOT</param>
'''  <param name="val">[in] - location to set for given side, for each box</param>
'''  <param name="thresh">[in] - min abs difference to cause resetting to %val</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaSetSide(
				ByVal boxad as Boxa, 
				ByVal boxas as Boxa, 
				ByVal side as Enumerations.L_box_size_adjustment_location, 
				ByVal val as Integer, 
				ByVal thresh as Integer) as Boxa

	If IsNothing (boxad) then Throw New ArgumentNullException  ("boxad cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSetSide( boxad.Pointer, boxas.Pointer, side, val, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (1932, 1)
' boxaAdjustWidthToTarget()
' boxaAdjustWidthToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) Conditionally adjusts the width of each box, by moving
''' the indicated edges (left and/or right) if the width differs
''' by %thresh or more from %target.
''' (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.
''' Use one of these
''' boxad = boxaAdjustWidthToTarget(NULL, boxas, ...);   // new
''' boxaAdjustWidthToTarget(boxas, boxas, ...);  // in-place
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - use NULL to get a new one; same as boxas for in-place</param>
'''  <param name="boxas">[in] - </param>
'''  <param name="sides">[in] - L_ADJUST_LEFT, L_ADJUST_RIGHT, L_ADJUST_LEFT_AND_RIGHT</param>
'''  <param name="target">[in] - target width if differs by more than thresh</param>
'''  <param name="thresh">[in] - min abs difference in width to cause adjustment</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaAdjustWidthToTarget(
				ByVal boxad as Boxa, 
				ByVal boxas as Boxa, 
				ByVal sides as Enumerations.L_box_size_adjustment_location, 
				ByVal target as Integer, 
				ByVal thresh as Integer) as Boxa

	If IsNothing (boxad) then Throw New ArgumentNullException  ("boxad cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaAdjustWidthToTarget( boxad.Pointer, boxas.Pointer, sides, target, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (1999, 1)
' boxaAdjustHeightToTarget()
' boxaAdjustHeightToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) Conditionally adjusts the height of each box, by moving
''' the indicated edges (top and/or bot) if the height differs
''' by %thresh or more from %target.
''' (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.
''' Use one of these
''' boxad = boxaAdjustHeightToTarget(NULL, boxas, ...);   // new
''' boxaAdjustHeightToTarget(boxas, boxas, ...);  // in-place
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - use NULL to get a new one</param>
'''  <param name="boxas">[in] - </param>
'''  <param name="sides">[in] - L_ADJUST_TOP, L_ADJUST_BOT, L_ADJUST_TOP_AND_BOT</param>
'''  <param name="target">[in] - target height if differs by more than thresh</param>
'''  <param name="thresh">[in] - min abs difference in height to cause adjustment</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaAdjustHeightToTarget(
				ByVal boxad as Boxa, 
				ByVal boxas as Boxa, 
				ByVal sides as Enumerations.L_box_size_adjustment_location, 
				ByVal target as Integer, 
				ByVal thresh as Integer) as Boxa

	If IsNothing (boxad) then Throw New ArgumentNullException  ("boxad cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaAdjustHeightToTarget( boxad.Pointer, boxas.Pointer, sides, target, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (2057, 1)
' boxEqual()
' boxEqual(BOX *, BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="psame">[out] - 1 if equal; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxEqual(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByRef psame as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxEqual( box1.Pointer, box2.Pointer, psame)

	Return _Result
End Function

' SRC\boxfunc1.c (2104, 1)
' boxaEqual()
' boxaEqual(BOXA *, BOXA *, l_int32, NUMA **, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The two boxa are the "same" if they contain the same
''' boxes and each box is within %maxdist of its counterpart
''' in their positions within the boxa.  This allows for
''' small rearrangements.  Use 0 for maxdist if the boxa
''' must be identical.
''' (2) This applies only to geometry and ordering; refcounts
''' are not considered.
''' (3) %maxdist allows some latitude in the ordering of the boxes.
''' For the boxa to be the "same", corresponding boxes must
''' be within %maxdist of each other.  Note that for large
''' %maxdist, we should use a hash function for efficiency.
''' (4) naindex[i] gives the position of the box in boxa2 that
''' corresponds to box i in boxa1.  It is only returned if the
''' boxa are equal.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa1">[in] - </param>
'''  <param name="boxa2">[in] - </param>
'''  <param name="maxdist">[in] - </param>
'''  <param name="pnaindex">[out][optional] - index array of correspondences</param>
'''  <param name="psame">[out] - (1 if equal; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaEqual(
				ByVal boxa1 as Boxa, 
				ByVal boxa2 as Boxa, 
				ByVal maxdist as Integer, 
				ByRef psame as Integer, 
				Optional ByRef pnaindex as Numa = Nothing) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaEqual( boxa1.Pointer, boxa2.Pointer, maxdist, pnaindexPTR, psame)
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2183, 1)
' boxSimilar()
' boxSimilar(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The values of leftdiff (etc) are the maximum allowed deviations
''' between the locations of the left (etc) sides.  If any side
''' pairs differ by more than this amount, the boxes are not similar.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="leftdiff">[in] - </param>
'''  <param name="rightdiff">[in] - </param>
'''  <param name="topdiff">[in] - </param>
'''  <param name="botdiff">[in] - </param>
'''  <param name="psimilar">[out] - 1 if similar; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSimilar(
				ByVal box1 as Box, 
				ByVal box2 as Box, 
				ByVal leftdiff as Integer, 
				ByVal rightdiff as Integer, 
				ByVal topdiff as Integer, 
				ByVal botdiff as Integer, 
				ByRef psimilar as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxSimilar( box1.Pointer, box2.Pointer, leftdiff, rightdiff, topdiff, botdiff, psimilar)

	Return _Result
End Function

' SRC\boxfunc1.c (2238, 1)
' boxaSimilar()
' boxaSimilar(BOXA *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) See boxSimilar() for parameter usage.
''' (2) Corresponding boxes are taken in order in the two boxa.
''' (3) %nasim is an indicator array with a (0/1) for each box pair.
''' (4) With %nasim or debug == 1, boxes continue to be tested
''' after failure.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa1">[in] - </param>
'''  <param name="boxa2">[in] - </param>
'''  <param name="leftdiff">[in] - </param>
'''  <param name="rightdiff">[in] - </param>
'''  <param name="topdiff">[in] - </param>
'''  <param name="botdiff">[in] - </param>
'''  <param name="debug">[in] - output details of non-similar boxes</param>
'''  <param name="psimilar">[out] - 1 if similar; 0 otherwise</param>
'''  <param name="pnasim">[out][optional] - na containing 1 if similar; else 0</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSimilar(
				ByVal boxa1 as Boxa, 
				ByVal boxa2 as Boxa, 
				ByVal leftdiff as Integer, 
				ByVal rightdiff as Integer, 
				ByVal topdiff as Integer, 
				ByVal botdiff as Integer, 
				ByRef psimilar as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn, 
				Optional ByRef pnasim as Numa = Nothing) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")

Dim pnasimPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasim) Then pnasimPTR = pnasim.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSimilar( boxa1.Pointer, boxa2.Pointer, leftdiff, rightdiff, topdiff, botdiff, debug, psimilar, pnasimPTR)
	if pnasimPTR <> IntPtr.Zero then pnasim = new Numa(pnasimPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2312, 1)
' boxaJoin()
' boxaJoin(BOXA *, BOXA *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This appends a clone of each indicated box in boxas to boxad
''' (2) istart LT 0 is taken to mean 'read from the start' (istart = 0)
''' (3) iend LT 0 means 'read to the end'
''' (4) if boxas == NULL or has no boxes, this is a no-op.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - dest boxa; add to this one</param>
'''  <param name="boxas">[in] - source boxa; add from this one</param>
'''  <param name="istart">[in] - starting index in boxas</param>
'''  <param name="iend">[in] - ending index in boxas; use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaJoin(
				ByVal boxad as Boxa, 
				ByVal boxas as Boxa, 
				ByVal istart as Integer, 
				ByVal iend as Integer) as Integer

	If IsNothing (boxad) then Throw New ArgumentNullException  ("boxad cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaJoin( boxad.Pointer, boxas.Pointer, istart, iend)

	Return _Result
End Function

' SRC\boxfunc1.c (2361, 1)
' boxaaJoin()
' boxaaJoin(BOXAA *, BOXAA *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This appends a clone of each indicated boxa in baas to baad
''' (2) istart LT 0 is taken to mean 'read from the start' (istart = 0)
''' (3) iend LT 0 means 'read to the end'
''' (4) if baas == NULL, this is a no-op.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baad">[in] - dest boxaa; add to this one</param>
'''  <param name="baas">[in] - source boxaa; add from this one</param>
'''  <param name="istart">[in] - starting index in baas</param>
'''  <param name="iend">[in] - ending index in baas; use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaJoin(
				ByVal baad as Boxaa, 
				ByVal baas as Boxaa, 
				ByVal istart as Integer, 
				ByVal iend as Integer) as Integer

	If IsNothing (baad) then Throw New ArgumentNullException  ("baad cannot be Nothing")
	If IsNothing (baas) then Throw New ArgumentNullException  ("baas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaJoin( baad.Pointer, baas.Pointer, istart, iend)

	Return _Result
End Function

' SRC\boxfunc1.c (2411, 1)
' boxaSplitEvenOdd()
' boxaSplitEvenOdd(BOXA *, l_int32, BOXA **, BOXA **) as l_ok
'''  <summary>
''' Notes
''' (1) If %fillflag == 1, boxae has copies of the even boxes
''' in their original location, and nvalid boxes are placed
''' in the odd array locations.  And v.v.
''' (2) If %fillflag == 0, boxae has only copies of the even boxes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="fillflag">[in] - 1 to put invalid boxes in place; 0 to omit</param>
'''  <param name="pboxae">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
'''  <param name="pboxao">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSplitEvenOdd(
				ByVal boxa as Boxa, 
				ByVal fillflag as Integer, 
				ByRef pboxae as Boxa, 
				ByRef pboxao as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim pboxaePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxae) Then pboxaePTR = pboxae.Pointer
	Dim pboxaoPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxao) Then pboxaoPTR = pboxao.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSplitEvenOdd( boxa.Pointer, fillflag, pboxaePTR, pboxaoPTR)
	if pboxaePTR <> IntPtr.Zero then pboxae = new Boxa(pboxaePTR)
	if pboxaoPTR <> IntPtr.Zero then pboxao = new Boxa(pboxaoPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2475, 1)
' boxaMergeEvenOdd()
' boxaMergeEvenOdd(BOXA *, BOXA *, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) This is essentially the inverse of boxaSplitEvenOdd().
''' Typically, boxae and boxao were generated by boxaSplitEvenOdd(),
''' and the value of %fillflag needs to be the same in both calls.
''' (2) If %fillflag == 1, both boxae and boxao are of the same size;
''' otherwise boxae may have one more box than boxao.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxae">[in] - boxes to go in even positions in merged boxa</param>
'''  <param name="boxao">[in] - boxes to go in odd positions in merged boxa</param>
'''  <param name="fillflag">[in] - 1 if there are invalid boxes in placeholders</param>
'''   <returns>boxad merged, or NULL on error</returns>
Public Shared Function boxaMergeEvenOdd(
				ByVal boxae as Boxa, 
				ByVal boxao as Boxa, 
				ByVal fillflag as Integer) as Boxa

	If IsNothing (boxae) then Throw New ArgumentNullException  ("boxae cannot be Nothing")
	If IsNothing (boxao) then Throw New ArgumentNullException  ("boxao cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaMergeEvenOdd( boxae.Pointer, boxao.Pointer, fillflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

End Class
