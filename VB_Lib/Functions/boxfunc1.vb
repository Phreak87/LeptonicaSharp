Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\boxfunc1.c (99, 1)
' boxContains(box1, box2, presult) as Integer
' boxContains(BOX *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="presult">[out] - 1 if box2 is entirely contained within box1, and 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxContains(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				<Out()> ByRef presult as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxContains( box1.Pointer, box2.Pointer, presult)

	Return _Result
End Function

' SRC\boxfunc1.c (130, 1)
' boxIntersects(box1, box2, presult) as Integer
' boxIntersects(BOX *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="presult">[out] - 1 if any part of box2 is contained in box1, and 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxIntersects(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				<Out()> ByRef presult as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxIntersects( box1.Pointer, box2.Pointer, presult)

	Return _Result
End Function

' SRC\boxfunc1.c (172, 1)
' boxaContainedInBox(boxas, box) as Boxa
' boxaContainedInBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) All boxes in boxa that are entirely outside box are removed.<para/>
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
' boxaContainedInBoxCount(boxa, box, pcount) as Integer
' boxaContainedInBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - for selecting contained boxes in %boxa</param>
'''  <param name="pcount">[out] - number of boxes intersecting the box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaContainedInBoxCount(
				 ByVal boxa as Boxa, 
				 ByVal box as Box, 
				<Out()> ByRef pcount as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxaContainedInBoxCount( boxa.Pointer, box.Pointer, pcount)

	Return _Result
End Function

' SRC\boxfunc1.c (249, 1)
' boxaContainedInBoxa(boxa1, boxa2, pcontained) as Integer
' boxaContainedInBoxa(BOXA *, BOXA *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="boxa1">[in] - </param>
'''  <param name="boxa2">[in] - </param>
'''  <param name="pcontained">[out] - 1 if every box in boxa2 is contained in some box in boxa1 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaContainedInBoxa(
				 ByVal boxa1 as Boxa, 
				 ByVal boxa2 as Boxa, 
				<Out()> ByRef pcontained as Integer) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxaContainedInBoxa( boxa1.Pointer, boxa2.Pointer, pcontained)

	Return _Result
End Function

' SRC\boxfunc1.c (302, 1)
' boxaIntersectsBox(boxas, box) as Boxa
' boxaIntersectsBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) All boxes in boxa that intersect with box (i.e., are completely<para/>
''' or partially contained in box) are retained.<para/>
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
' boxaIntersectsBoxCount(boxa, box, pcount) as Integer
' boxaIntersectsBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - for selecting intersecting boxes in %boxa</param>
'''  <param name="pcount">[out] - number of boxes intersecting the box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaIntersectsBoxCount(
				 ByVal boxa as Boxa, 
				 ByVal box as Box, 
				<Out()> ByRef pcount as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxaIntersectsBoxCount( boxa.Pointer, box.Pointer, pcount)

	Return _Result
End Function

' SRC\boxfunc1.c (385, 1)
' boxaClipToBox(boxas, box) as Boxa
' boxaClipToBox(BOXA *, BOX *) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) All boxes in boxa not intersecting with box are removed, and<para/>
''' the remaining boxes are clipped to box.<para/>
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
' boxaCombineOverlaps(boxas, pixadb) as Boxa
' boxaCombineOverlaps(BOXA *, PIXA *) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there are no overlapping boxes, it simply returns a copy<para/>
''' of %boxas.<para/>
''' (2) Input an empty %pixadb, using pixaCreate(0), for debug output.<para/>
''' The output gives 2 visualizations of the boxes per iteration<para/>
''' boxes in red before, and added boxes in green after. Note that<para/>
''' all pixels in the red boxes are contained in the green ones.<para/>
''' (3) The alternative method of painting each rectangle and finding<para/>
''' the 4-connected components gives a different result in<para/>
''' general, because two non-overlapping (but touching)<para/>
''' rectangles, when rendered, are 4-connected and will be joined.<para/>
''' (4) A bad case computationally is to have n boxes, none of which<para/>
''' overlap.  Then you have one iteration with O(n^2) compares.<para/>
''' This is still faster than painting each rectangle and finding<para/>
''' the bounding boxes of the connected components, even for<para/>
''' thousands of rectangles.<para/>
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
' boxaCombineOverlapsInPair(boxas1, boxas2, pboxad1, pboxad2, pixadb) as Integer
' boxaCombineOverlapsInPair(BOXA *, BOXA *, BOXA **, BOXA **, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) One of three things happens to each box in %boxa1 and %boxa2:<para/>
''' it gets absorbed into a larger box that it overlaps with<para/>
''' it absorbs a smaller (by area) box that it overlaps with<para/>
''' and gets larger, using the bounding region of the 2 boxes<para/>
''' it is unchanged (including absorbing smaller boxes that<para/>
''' are contained within it).<para/>
''' (2) If all the boxes from one of the input boxa are absorbed, this<para/>
''' returns an empty boxa.<para/>
''' (3) Input an empty %pixadb, using pixaCreate(0), for debug output<para/>
''' (4) This is useful if different operations are to be carried out<para/>
''' on possibly overlapping rectangular regions, and it is desired<para/>
''' to have only one operation on any rectangular region.<para/>
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
				<Out()> ByRef pboxad1 as Boxa, 
				<Out()> ByRef pboxad2 as Boxa, 
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
' boxOverlapRegion(box1, box2) as Box
' boxOverlapRegion(BOX *, BOX *) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is the geometric intersection of the two rectangles.<para/>
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
' boxBoundingRegion(box1, box2) as Box
' boxBoundingRegion(BOX *, BOX *) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is the geometric union of the two rectangles.<para/>
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
' boxOverlapFraction(box1, box2, pfract) as Integer
' boxOverlapFraction(BOX *, BOX *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The result depends on the order of the input boxes,<para/>
''' because the overlap is taken as a fraction of box2.<para/>
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
				<Out()> ByRef pfract as Single()) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxOverlapFraction( box1.Pointer, box2.Pointer, pfract)

	Return _Result
End Function

' SRC\boxfunc1.c (792, 1)
' boxOverlapArea(box1, box2, parea) as Integer
' boxOverlapArea(BOX *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - two boxes</param>
'''  <param name="box2">[in] - two boxes</param>
'''  <param name="parea">[out] - the number of pixels in the overlap</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function boxOverlapArea(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				<Out()> ByRef parea as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxOverlapArea( box1.Pointer, box2.Pointer, parea)

	Return _Result
End Function

' SRC\boxfunc1.c (853, 1)
' boxaHandleOverlaps(boxas, op, range, min_overlap, max_ratio, pnamap) as Boxa
' boxaHandleOverlaps(BOXA *, l_int32, l_int32, l_float32, l_float32, NUMA **) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For all n(n-1)/2 box pairings, if two boxes overlap, either:<para/>
''' (a) op == L_COMBINE: get the bounding region for the two,<para/>
''' replace the larger with the bounding region, and remove<para/>
''' the smaller of the two, or<para/>
''' (b) op == L_REMOVE_SMALL: just remove the smaller.<para/>
''' (2) If boxas is 2D sorted, range can be small, but if it is<para/>
''' not spatially sorted, range should be large to allow all<para/>
''' pairwise comparisons to be made.<para/>
''' (3) The %min_overlap parameter allows ignoring small overlaps.<para/>
''' If %min_overlap == 1.0, only boxes fully contained in larger<para/>
''' boxes can be considered for removal if %min_overlap == 0.0,<para/>
''' this constraint is ignored.<para/>
''' (4) The %max_ratio parameter allows ignoring overlaps between<para/>
''' boxes that are not too different in size.  If %max_ratio == 0.0,<para/>
''' no boxes can be removed if %max_ratio == 1.0, this constraint<para/>
''' is ignored.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="op">[in] - L_COMBINE, L_REMOVE_SMALL</param>
'''  <param name="range">[in] - is greater  0, forward distance over which overlaps are checked</param>
'''  <param name="min_overlap">[in] - minimum fraction of smaller box required for overlap to count 0.0 to ignore</param>
'''  <param name="max_ratio">[in] - maximum fraction of small/large areas for overlap to count 1.0 to ignore</param>
'''  <param name="pnamap">[out][optional] - combining map</param>
'''   <returns>boxad, or NULL on error.</returns>
Public Shared Function boxaHandleOverlaps(
				 ByVal boxas as Boxa, 
				 ByVal op as Enumerations.L_hling_overlapping_bounding_boxes_in_boxa, 
				 ByVal range as Integer, 
				 ByVal min_overlap as Single, 
				 ByVal max_ratio as Single, 
				<Out()> ByRef pnamap as Numa) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")



Dim pnamapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnamap) Then pnamapPTR = pnamap.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaHandleOverlaps( boxas.Pointer, op, range, min_overlap, max_ratio, pnamapPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnamapPTR <> IntPtr.Zero then pnamap = new Numa(pnamapPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc1.c (973, 1)
' boxSeparationDistance(box1, box2, ph_sep, pv_sep) as Integer
' boxSeparationDistance(BOX *, BOX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This measures horizontal and vertical separation of the<para/>
''' two boxes.  If the boxes are touching but have no pixels<para/>
''' in common, the separation is 0.  If the boxes overlap by<para/>
''' a distance d, the returned separation is -d.<para/>
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
				<Out()> ByRef ph_sep as Integer, 
				<Out()> ByRef pv_sep as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxSeparationDistance( box1.Pointer, box2.Pointer, ph_sep, pv_sep)

	Return _Result
End Function

' SRC\boxfunc1.c (1029, 1)
' boxCompareSize(box1, box2, type, prel) as Integer
' boxCompareSize(BOX *, BOX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We're re-using the SORT enum for these comparisons.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="type">[in] - L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA,</param>
'''  <param name="prel">[out] - 1 if box1  is greater  box2, 0 if the same, -1 if box1  is lower  box2</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxCompareSize(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				 ByVal type as Enumerations.L_SORT_BY, 
				<Out()> ByRef prel as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxCompareSize( box1.Pointer, box2.Pointer, type, prel)

	Return _Result
End Function

' SRC\boxfunc1.c (1080, 1)
' boxContainsPt(box, x, y, pcontains) as Integer
' boxContainsPt(BOX *, l_float32, l_float32, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="x">[in] - a point</param>
'''  <param name="y">[in] - a point</param>
'''  <param name="pcontains">[out] - 1 if box contains point 0 otherwise</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function boxContainsPt(
				 ByVal box as Box, 
				 ByVal x as Single, 
				 ByVal y as Single, 
				<Out()> ByRef pcontains as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxContainsPt( box.Pointer, x, y, pcontains)

	Return _Result
End Function

' SRC\boxfunc1.c (1115, 1)
' boxaGetNearestToPt(boxa, x, y) as Box
' boxaGetNearestToPt(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Uses euclidean distance between centroid and point.<para/>
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
' boxaGetNearestToLine(boxa, x, y) as Box
' boxaGetNearestToLine(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For a horizontal line at some value y, get the minimum of the<para/>
''' distance |yc - y| from the box centroid yc value to y<para/>
''' likewise minimize |xc - x| for a vertical line at x.<para/>
''' (2) Input y  is lower  0, x  is greater = 0 to indicate a vertical line at x, and<para/>
''' x  is lower  0, y  is greater = 0 for a horizontal line at y.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="x">[in] - (y = -1 for vertical line x = -1 for horiz line)</param>
'''  <param name="y">[in] - (y = -1 for vertical line x = -1 for horiz line)</param>
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
' boxaFindNearestBoxes(boxa, dist_select, range, pnaaindex, pnaadist) as Integer
' boxaFindNearestBoxes(BOXA *, l_int32, l_int32, NUMAA **, NUMAA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See boxaGetNearestByDirection() for usage of %dist_select<para/>
''' and %range.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
'''  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
'''  <param name="range">[in] - search distance from box i use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
'''  <param name="pnaaindex">[out] - for each box in %boxa, contains a numa of 4 box indices (per direction) of the nearest box</param>
'''  <param name="pnaadist">[out] - for each box in %boxa, this contains a numa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaFindNearestBoxes(
				 ByVal boxa as Boxa, 
				 ByVal dist_select as Enumerations.L_value_, 
				 ByVal range as Integer, 
				<Out()> ByRef pnaaindex as Numaa, 
				<Out()> ByRef pnaadist as Numaa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")



	Dim pnaaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaaindex) Then pnaaindexPTR = pnaaindex.Pointer
	Dim pnaadistPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaadist) Then pnaadistPTR = pnaadist.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaFindNearestBoxes( boxa.Pointer, dist_select, range, pnaaindexPTR, pnaadistPTR)
	if pnaaindexPTR <> IntPtr.Zero then pnaaindex = new Numaa(pnaaindexPTR)
	if pnaadistPTR <> IntPtr.Zero then pnaadist = new Numaa(pnaadistPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (1305, 1)
' boxaGetNearestByDirection(boxa, i, dir, dist_select, range, pindex, pdist) as Integer
' boxaGetNearestByDirection(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For efficiency, use a LR/TD sorted %boxa, which can be<para/>
''' made by flattening a 2D sorted boxaa.  In that case,<para/>
''' %range can be some positive integer like 50.<para/>
''' (2) If boxes overlap, the distance will be  is lower  0.  Use %dist_select<para/>
''' to determine if these should count or not.  If L_ALL, then<para/>
''' one box will match as the nearest to another in 2 or more<para/>
''' directions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
'''  <param name="i">[in] - box we test against</param>
'''  <param name="dir">[in] - direction to look: L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
'''  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
'''  <param name="range">[in] - search distance from box i use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
'''  <param name="pindex">[out] - index in boxa of nearest box with overlapping coordinates in the indicated direction -1 if there is no box</param>
'''  <param name="pdist">[out] - distance of the nearest box in the indicated direction 100000 if no box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetNearestByDirection(
				 ByVal boxa as Boxa, 
				 ByVal i as Integer, 
				 ByVal dir as Enumerations.L_scan_direction, 
				 ByVal dist_select as Enumerations.L_value_, 
				 ByVal range as Integer, 
				<Out()> ByRef pindex as Integer, 
				<Out()> ByRef pdist as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetNearestByDirection( boxa.Pointer, i, dir, dist_select, range, pindex, pdist)

	Return _Result
End Function

' SRC\boxfunc1.c (1444, 1)
' boxGetCenter(box, pcx, pcy) as Integer
' boxGetCenter(BOX *, l_float32 *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="pcx">[out] - location of center of box</param>
'''  <param name="pcy">[out] - location of center of box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetCenter(
				 ByVal box as Box, 
				<Out()> ByRef pcx as Single(), 
				<Out()> ByRef pcy as Single()) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxGetCenter( box.Pointer, pcx, pcy)

	Return _Result
End Function

' SRC\boxfunc1.c (1485, 1)
' boxIntersectByLine(box, x, y, slope, px1, py1, px2, py2, pn) as Integer
' boxIntersectByLine(BOX *, l_int32, l_int32, l_float32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the intersection is at only one point (a corner), the<para/>
''' coordinates are returned in (x1, y1).<para/>
''' (2) Represent a vertical line by one with a large but finite slope.<para/>
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
				<Out()> ByRef px1 as Integer, 
				<Out()> ByRef py1 as Integer, 
				<Out()> ByRef px2 as Integer, 
				<Out()> ByRef py2 as Integer, 
				<Out()> ByRef pn as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxIntersectByLine( box.Pointer, x, y, slope, px1, py1, px2, py2, pn)

	Return _Result
End Function

' SRC\boxfunc1.c (1587, 1)
' boxClipToRectangle(box, wi, hi) as Box
' boxClipToRectangle(BOX *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be used to clip a rectangle to an image.<para/>
''' The clipping rectangle is assumed to have a UL corner at (0, 0),<para/>
''' and a LR corner at (wi - 1, hi - 1).<para/>
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
' boxClipToRectangleParams(box, w, h, pxstart, pystart, pxend, pyend, pbw, pbh) as Integer
' boxClipToRectangleParams(BOX *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The return value should be checked.  If it is 1, the<para/>
''' returned parameter values are bogus.<para/>
''' (2) This simplifies the selection of pixel locations within<para/>
''' a given rectangle:<para/>
''' for (i = ystart i  is lower  yend i++ {<para/>
''' ...<para/>
''' for (j = xstart j  is lower  xend j++ {<para/>
''' ....<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in][optional] - requested box can be null</param>
'''  <param name="w">[in] - clipping box size typ. the size of an image</param>
'''  <param name="h">[in] - clipping box size typ. the size of an image</param>
'''  <param name="pxstart">[out] - start x coordinate</param>
'''  <param name="pystart">[out] - start y coordinate</param>
'''  <param name="pxend">[out] - one pixel beyond clipping box</param>
'''  <param name="pyend">[out] - one pixel beyond clipping box</param>
'''  <param name="pbw">[out][optional] - clipped width</param>
'''  <param name="pbh">[out][optional] - clipped height</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function boxClipToRectangleParams(
				 ByVal box as Box, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				<Out()> ByRef pxstart as Integer, 
				<Out()> ByRef pystart as Integer, 
				<Out()> ByRef pxend as Integer, 
				<Out()> ByRef pyend as Integer, 
				<Out()> ByRef pbw as Integer, 
				<Out()> ByRef pbh as Integer) as Integer




	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxClipToRectangleParams( boxPTR, w, h, pxstart, pystart, pxend, pyend, pbw, pbh)

	Return _Result
End Function

' SRC\boxfunc1.c (1706, 1)
' boxRelocateOneSide(boxd, boxs, loc, sideflag) as Box
' boxRelocateOneSide(BOX *, BOX *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Set boxd == NULL to get new box boxd == boxs for in-place<para/>
''' or otherwise to resize existing boxd.<para/>
''' (2) For usage, suggest one of these:<para/>
''' boxd = boxRelocateOneSide(NULL, boxs, ...) // new<para/>
''' boxRelocateOneSide(boxs, boxs, ...)  // in-place<para/>
''' boxRelocateOneSide(boxd, boxs, ...)  // other<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxd">[in][optional] - this can be null, equal to boxs, or different from boxs</param>
'''  <param name="boxs">[in] - starting box to have one side relocated</param>
'''  <param name="loc">[in] - new location of the side that is changing</param>
'''  <param name="sideflag">[in] - L_FROM_LEFT, etc., indicating the side that moves</param>
'''   <returns>boxd, or NULL on error or if the computed boxd has width or height  is lower = 0.</returns>
Public Shared Function boxRelocateOneSide(
				 ByVal boxd as Box, 
				 ByVal boxs as Box, 
				 ByVal loc as Integer, 
				 ByVal sideflag as Enumerations.L_scan_direction) as Box

	If IsNothing (boxs) then Throw New ArgumentNullException  ("boxs cannot be Nothing")



	Dim boxdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxd) Then boxdPTR = boxd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxRelocateOneSide( boxdPTR, boxs.Pointer, loc, sideflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1750, 1)
' boxaAdjustSides(boxas, delleft, delright, deltop, delbot) as Boxa
' boxaAdjustSides(BOXA *, l_int32, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) New box dimensions are cropped at left and top to x  is greater = 0 and y  is greater = 0.<para/>
''' (2) If the width or height of a box goes to 0, we generate a box with<para/>
''' w == 1 and h == 1, as a placeholder.<para/>
''' (3) See boxAdjustSides().<para/>
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
' boxAdjustSides(boxd, boxs, delleft, delright, deltop, delbot) as Box
' boxAdjustSides(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Set boxd == NULL to get new box boxd == boxs for in-place<para/>
''' or otherwise to resize existing boxd.<para/>
''' (2) For usage, suggest one of these:<para/>
''' boxd = boxAdjustSides(NULL, boxs, ...) // new<para/>
''' boxAdjustSides(boxs, boxs, ...)  // in-place<para/>
''' boxAdjustSides(boxd, boxs, ...)  // other<para/>
''' (3) New box dimensions are cropped at left and top to x  is greater = 0 and y  is greater = 0.<para/>
''' (4) For example, to expand in-place by 20 pixels on each side, use<para/>
''' boxAdjustSides(box, box, -20, 20, -20, 20)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxd">[in][optional] - this can be null, equal to boxs, or different from boxs</param>
'''  <param name="boxs">[in] - starting box to have sides adjusted</param>
'''  <param name="delleft">[in] - changes in location of each side</param>
'''  <param name="delright">[in] - changes in location of each side</param>
'''  <param name="deltop">[in] - changes in location of each side</param>
'''  <param name="delbot">[in] - changes in location of each side</param>
'''   <returns>boxd, or NULL on error or if the computed boxd has width or height  is lower = 0.</returns>
Public Shared Function boxAdjustSides(
				 ByVal boxd as Box, 
				 ByVal boxs as Box, 
				 ByVal delleft as Integer, 
				 ByVal delright as Integer, 
				 ByVal deltop as Integer, 
				 ByVal delbot as Integer) as Box

	If IsNothing (boxs) then Throw New ArgumentNullException  ("boxs cannot be Nothing")



	Dim boxdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxd) Then boxdPTR = boxd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxAdjustSides( boxdPTR, boxs.Pointer, delleft, delright, deltop, delbot)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc1.c (1859, 1)
' boxaSetSide(boxad, boxas, side, val, thresh) as Boxa
' boxaSetSide(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sets the given side of each box.  Use boxad == NULL for a new<para/>
''' boxa, and boxad == boxas for in-place.<para/>
''' (2) Use one of these:<para/>
''' boxad = boxaSetSide(NULL, boxas, ...) // new<para/>
''' boxaSetSide(boxas, boxas, ...)  // in-place<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - use NULL to get a new one same as boxas for in-place</param>
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
' boxaAdjustWidthToTarget(boxad, boxas, sides, target, thresh) as Boxa
' boxaAdjustWidthToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Conditionally adjusts the width of each box, by moving<para/>
''' the indicated edges (left and/or right) if the width differs<para/>
''' by %thresh or more from %target.<para/>
''' (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.<para/>
''' Use one of these:<para/>
''' boxad = boxaAdjustWidthToTarget(NULL, boxas, ...) // new<para/>
''' boxaAdjustWidthToTarget(boxas, boxas, ...)  // in-place<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - use NULL to get a new one same as boxas for in-place</param>
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
' boxaAdjustHeightToTarget(boxad, boxas, sides, target, thresh) as Boxa
' boxaAdjustHeightToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Conditionally adjusts the height of each box, by moving<para/>
''' the indicated edges (top and/or bot) if the height differs<para/>
''' by %thresh or more from %target.<para/>
''' (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.<para/>
''' Use one of these:<para/>
''' boxad = boxaAdjustHeightToTarget(NULL, boxas, ...) // new<para/>
''' boxaAdjustHeightToTarget(boxas, boxas, ...)  // in-place<para/>
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
' boxEqual(box1, box2, psame) as Integer
' boxEqual(BOX *, BOX *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="psame">[out] - 1 if equal 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxEqual(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				<Out()> ByRef psame as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxEqual( box1.Pointer, box2.Pointer, psame)

	Return _Result
End Function

' SRC\boxfunc1.c (2104, 1)
' boxaEqual(boxa1, boxa2, maxdist, pnaindex, psame) as Integer
' boxaEqual(BOXA *, BOXA *, l_int32, NUMA **, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The two boxa are the "same" if they contain the same<para/>
''' boxes and each box is within %maxdist of its counterpart<para/>
''' in their positions within the boxa.  This allows for<para/>
''' small rearrangements.  Use 0 for maxdist if the boxa<para/>
''' must be identical.<para/>
''' (2) This applies only to geometry and ordering refcounts<para/>
''' are not considered.<para/>
''' (3) %maxdist allows some latitude in the ordering of the boxes.<para/>
''' For the boxa to be the "same", corresponding boxes must<para/>
''' be within %maxdist of each other.  Note that for large<para/>
''' %maxdist, we should use a hash function for efficiency.<para/>
''' (4) naindex[i] gives the position of the box in boxa2 that<para/>
''' corresponds to box i in boxa1.  It is only returned if the<para/>
''' boxa are equal.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa1">[in] - </param>
'''  <param name="boxa2">[in] - </param>
'''  <param name="maxdist">[in] - </param>
'''  <param name="pnaindex">[out][optional] - index array of correspondences</param>
'''  <param name="psame">[out] - (1 if equal 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaEqual(
				 ByVal boxa1 as Boxa, 
				 ByVal boxa2 as Boxa, 
				 ByVal maxdist as Integer, 
				<Out()> ByRef pnaindex as Numa, 
				<Out()> ByRef psame as Integer) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")



Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaEqual( boxa1.Pointer, boxa2.Pointer, maxdist, pnaindexPTR, psame)
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2183, 1)
' boxSimilar(box1, box2, leftdiff, rightdiff, topdiff, botdiff, psimilar) as Integer
' boxSimilar(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values of leftdiff (etc) are the maximum allowed deviations<para/>
''' between the locations of the left (etc) sides.  If any side<para/>
''' pairs differ by more than this amount, the boxes are not similar.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box1">[in] - </param>
'''  <param name="box2">[in] - </param>
'''  <param name="leftdiff">[in] - </param>
'''  <param name="rightdiff">[in] - </param>
'''  <param name="topdiff">[in] - </param>
'''  <param name="botdiff">[in] - </param>
'''  <param name="psimilar">[out] - 1 if similar 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSimilar(
				 ByVal box1 as Box, 
				 ByVal box2 as Box, 
				 ByVal leftdiff as Integer, 
				 ByVal rightdiff as Integer, 
				 ByVal topdiff as Integer, 
				 ByVal botdiff as Integer, 
				<Out()> ByRef psimilar as Integer) as Integer

	If IsNothing (box1) then Throw New ArgumentNullException  ("box1 cannot be Nothing")
	If IsNothing (box2) then Throw New ArgumentNullException  ("box2 cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.boxSimilar( box1.Pointer, box2.Pointer, leftdiff, rightdiff, topdiff, botdiff, psimilar)

	Return _Result
End Function

' SRC\boxfunc1.c (2238, 1)
' boxaSimilar(boxa1, boxa2, leftdiff, rightdiff, topdiff, botdiff, debug, psimilar, pnasim) as Integer
' boxaSimilar(BOXA *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See boxSimilar() for parameter usage.<para/>
''' (2) Corresponding boxes are taken in order in the two boxa.<para/>
''' (3) %nasim is an indicator array with a (0/1) for each box pair.<para/>
''' (4) With %nasim or debug == 1, boxes continue to be tested<para/>
''' after failure.<para/>
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
'''  <param name="psimilar">[out] - 1 if similar 0 otherwise</param>
'''  <param name="pnasim">[out][optional] - na containing 1 if similar else 0</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSimilar(
				 ByVal boxa1 as Boxa, 
				 ByVal boxa2 as Boxa, 
				 ByVal leftdiff as Integer, 
				 ByVal rightdiff as Integer, 
				 ByVal topdiff as Integer, 
				 ByVal botdiff as Integer, 
				 ByVal debug as Enumerations.DebugOnOff, 
				<Out()> ByRef psimilar as Integer, 
				<Out()> ByRef pnasim as Numa) as Integer

	If IsNothing (boxa1) then Throw New ArgumentNullException  ("boxa1 cannot be Nothing")
	If IsNothing (boxa2) then Throw New ArgumentNullException  ("boxa2 cannot be Nothing")



Dim pnasimPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasim) Then pnasimPTR = pnasim.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSimilar( boxa1.Pointer, boxa2.Pointer, leftdiff, rightdiff, topdiff, botdiff, debug, psimilar, pnasimPTR)
	if pnasimPTR <> IntPtr.Zero then pnasim = new Numa(pnasimPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2312, 1)
' boxaJoin(boxad, boxas, istart, iend) as Integer
' boxaJoin(BOXA *, BOXA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a clone of each indicated box in boxas to boxad<para/>
''' (2) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (3) iend  is lower  0 means 'read to the end'<para/>
''' (4) if boxas == NULL or has no boxes, this is a no-op.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxad">[in] - dest boxa add to this one</param>
'''  <param name="boxas">[in] - source boxa add from this one</param>
'''  <param name="istart">[in] - starting index in boxas</param>
'''  <param name="iend">[in] - ending index in boxas use -1 to cat all</param>
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
' boxaaJoin(baad, baas, istart, iend) as Integer
' boxaaJoin(BOXAA *, BOXAA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a clone of each indicated boxa in baas to baad<para/>
''' (2) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (3) iend  is lower  0 means 'read to the end'<para/>
''' (4) if baas == NULL, this is a no-op.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baad">[in] - dest boxaa add to this one</param>
'''  <param name="baas">[in] - source boxaa add from this one</param>
'''  <param name="istart">[in] - starting index in baas</param>
'''  <param name="iend">[in] - ending index in baas use -1 to cat all</param>
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
' boxaSplitEvenOdd(boxa, fillflag, pboxae, pboxao) as Integer
' boxaSplitEvenOdd(BOXA *, l_int32, BOXA **, BOXA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If %fillflag == 1, boxae has copies of the even boxes<para/>
''' in their original location, and nvalid boxes are placed<para/>
''' in the odd array locations.  And v.v.<para/>
''' (2) If %fillflag == 0, boxae has only copies of the even boxes.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="fillflag">[in] - 1 to put invalid boxes in place 0 to omit</param>
'''  <param name="pboxae">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
'''  <param name="pboxao">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSplitEvenOdd(
				 ByVal boxa as Boxa, 
				 ByVal fillflag as Integer, 
				<Out()> ByRef pboxae as Boxa, 
				<Out()> ByRef pboxao as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")



	Dim pboxaePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxae) Then pboxaePTR = pboxae.Pointer
	Dim pboxaoPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxao) Then pboxaoPTR = pboxao.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSplitEvenOdd( boxa.Pointer, fillflag, pboxaePTR, pboxaoPTR)
	if pboxaePTR <> IntPtr.Zero then pboxae = new Boxa(pboxaePTR)
	if pboxaoPTR <> IntPtr.Zero then pboxao = new Boxa(pboxaoPTR)

	Return _Result
End Function

' SRC\boxfunc1.c (2475, 1)
' boxaMergeEvenOdd(boxae, boxao, fillflag) as Boxa
' boxaMergeEvenOdd(BOXA *, BOXA *, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is essentially the inverse of boxaSplitEvenOdd().<para/>
''' Typically, boxae and boxao were generated by boxaSplitEvenOdd(),<para/>
''' and the value of %fillflag needs to be the same in both calls.<para/>
''' (2) If %fillflag == 1, both boxae and boxao are of the same size<para/>
''' otherwise boxae may have one more box than boxao.<para/>
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
