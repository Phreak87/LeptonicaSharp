Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\boxfunc2.c (91, 1)
' boxaTransform(boxas, shiftx, shifty, scalex, scaley) as Boxa
' boxaTransform(BOXA *, l_int32, l_int32, l_float32, l_float32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a very simple function that first shifts, then scales.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaTransform/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="shiftx">[in] - </param>
'''  <param name="shifty">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaTransform(
				 ByVal boxas as Boxa, 
				 ByVal shiftx as Integer, 
				 ByVal shifty as Integer, 
				 Optional ByVal scalex as Single = 1, 
				 Optional ByVal scaley as Single = 1) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaTransform( boxas.Pointer, shiftx, shifty, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (137, 1)
' boxTransform(box, shiftx, shifty, scalex, scaley) as Box
' boxTransform(BOX *, l_int32, l_int32, l_float32, l_float32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a very simple function that first shifts, then scales.<para/>
''' (2) If the box is invalid, a new invalid box is returned.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxTransform/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="shiftx">[in] - </param>
'''  <param name="shifty">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''   <returns>boxd, or NULL on error</returns>
Public Shared Function boxTransform(
				 ByVal box as Box, 
				 ByVal shiftx as Integer, 
				 ByVal shifty as Integer, 
				 Optional ByVal scalex as Single = 1, 
				 Optional ByVal scaley as Single = 1) as Box

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxTransform( box.Pointer, shiftx, shifty, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc2.c (192, 1)
' boxaTransformOrdered(boxas, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order) as Boxa
' boxaTransformOrdered(BOXA *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allows a sequence of linear transforms on each box.<para/>
''' the transforms are from the affine set, composed of<para/>
''' shift, scaling and rotation, and the order of the<para/>
''' transforms is specified.<para/>
''' (2) Although these operations appear to be on an infinite<para/>
''' 2D plane, in practice the region of interest is clipped<para/>
''' to a finite image.  The center of rotation is usually taken<para/>
''' with respect to the image (either the UL corner or the<para/>
''' center).  A translation can have two very different effects:<para/>
''' (a) Moves the boxes across the fixed image region.<para/>
''' (b) Moves the image origin, causing a change in the image<para/>
''' region and an opposite effective translation of the boxes.<para/>
''' This function should only be used for (a), where the image<para/>
''' region is fixed on translation.  If the image region is<para/>
''' changed by the translation, use instead the functions<para/>
''' in affinecompose.c, where the image region and rotation<para/>
''' center can be computed from the actual clipping due to<para/>
''' translation of the image origin.<para/>
''' (3) See boxTransformOrdered() for usage and implementation details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaTransformOrdered/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="shiftx">[in] - </param>
'''  <param name="shifty">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - in radians clockwise is positive</param>
'''  <param name="order">[in] - one of 6 combinations: L_TR_SC_RO, ...</param>
'''   <returns>boxd, or NULL on error</returns>
Public Shared Function boxaTransformOrdered(
				 ByVal boxas as Boxa, 
				 ByVal shiftx as Integer, 
				 ByVal shifty as Integer, 
				 ByVal scalex as Single, 
				 ByVal scaley as Single, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal order as Enumerations.L_affine_transm_order) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaTransformOrdered( boxas.Pointer, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (280, 1)
' boxTransformOrdered(boxs, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order) as Box
' boxTransformOrdered(BOX *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allows a sequence of linear transforms, composed of<para/>
''' shift, scaling and rotation, where the order of the<para/>
''' transforms is specified.<para/>
''' (2) The rotation is taken about a point specified by (xcen, ycen).<para/>
''' Let the components of the vector from the center of rotation<para/>
''' to the box center be (xdif, ydif):<para/>
''' xdif = (bx + 0.5  bw) - xcen<para/>
''' ydif = (by + 0.5  bh) - ycen<para/>
''' Then the box center after rotation has new components:<para/>
''' bxcen = xcen + xdif  cosa + ydif  sina<para/>
''' bycen = ycen + ydif  cosa - xdif  sina<para/>
''' where cosa and sina are the cos and sin of the angle,<para/>
''' and the enclosing box for the rotated box has size:<para/>
''' rw = |bw  cosa| + |bh  sina|<para/>
''' rh = |bh  cosa| + |bw  sina|<para/>
''' where bw and bh are the unrotated width and height.<para/>
''' Then the box UL corner (rx, ry) is<para/>
''' rx = bxcen - 0.5  rw<para/>
''' ry = bycen - 0.5  rh<para/>
''' (3) The center of rotation specified by args %xcen and %ycen<para/>
''' is the point BEFORE any translation or scaling.  If the<para/>
''' rotation is not the first operation, this function finds<para/>
''' the actual center at the time of rotation.  It does this<para/>
''' by making the following assumptions:<para/>
''' (1) Any scaling is with respect to the UL corner, so<para/>
''' that the center location scales accordingly.<para/>
''' (2) A translation does not affect the center of<para/>
''' the image it just moves the boxes.<para/>
''' We always use assumption (1).  However, assumption (2)<para/>
''' will be incorrect if the apparent translation is due<para/>
''' to a clipping operation that, in effect, moves the<para/>
''' origin of the image.  In that case, you should NOT use<para/>
''' these simple functions.  Instead, use the functions<para/>
''' in affinecompose.c, where the rotation center can be<para/>
''' computed from the actual clipping due to translation<para/>
''' of the image origin.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxTransformOrdered/*"/>
'''  <param name="boxs">[in] - </param>
'''  <param name="shiftx">[in] - </param>
'''  <param name="shifty">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - in radians clockwise is positive</param>
'''  <param name="order">[in] - one of 6 combinations: L_TR_SC_RO, ...</param>
'''   <returns>boxd, or NULL on error</returns>
Public Shared Function boxTransformOrdered(
				 ByVal boxs as Box, 
				 ByVal shiftx as Integer, 
				 ByVal shifty as Integer, 
				 ByVal scalex as Single, 
				 ByVal scaley as Single, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal order as Enumerations.L_affine_transm_order) as Box

	If IsNothing (boxs) then Throw New ArgumentNullException  ("boxs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxTransformOrdered( boxs.Pointer, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc2.c (454, 1)
' boxaRotateOrth(boxas, w, h, rotation) as Boxa
' boxaRotateOrth(BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See boxRotateOrth() for details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaRotateOrth/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="w">[in] - of image in which the boxa is embedded</param>
'''  <param name="h">[in] - of image in which the boxa is embedded</param>
'''  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg all rotations are clockwise</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaRotateOrth(
				 ByVal boxas as Boxa, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal rotation as Integer) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaRotateOrth( boxas.Pointer, w, h, rotation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (506, 1)
' boxRotateOrth(box, w, h, rotation) as Box
' boxRotateOrth(BOX *, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Rotate the image with the embedded box by the specified amount.<para/>
''' (2) After rotation, the rotated box is always measured with<para/>
''' respect to the UL corner of the image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxRotateOrth/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="w">[in] - of image in which the box is embedded</param>
'''  <param name="h">[in] - of image in which the box is embedded</param>
'''  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg all rotations are clockwise</param>
'''   <returns>boxd, or NULL on error</returns>
Public Shared Function boxRotateOrth(
				 ByVal box as Box, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal rotation as Integer) as Box

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxRotateOrth( box.Pointer, w, h, rotation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc2.c (560, 1)
' boxaSort(boxas, sorttype, sortorder, pnaindex) as Boxa
' boxaSort(BOXA *, l_int32, l_int32, NUMA **) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) An empty boxa returns a copy, with a warning.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSort/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_RIGHT, L_SORT_BY_BOT, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MIN_DIMENSION, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA, L_SORT_BY_ASPECT_RATIO</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
'''   <returns>boxad sorted version of boxas, or NULL on error</returns>
Public Shared Function boxaSort(
				 ByVal boxas as Boxa, 
				 ByVal sorttype as Enumerations.L_SORT_BY, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> Optional ByRef pnaindex as Numa = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSort( boxas.Pointer, sorttype, sortorder, pnaindexPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (684, 1)
' boxaBinSort(boxas, sorttype, sortorder, pnaindex) as Boxa
' boxaBinSort(BOXA *, l_int32, l_int32, NUMA **) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For a large number of boxes (say, greater than 1000), this<para/>
''' O(n) binsort is much faster than the O(nlogn) shellsort.<para/>
''' For 5000 components, this is over 20x faster than boxaSort().<para/>
''' (2) Consequently, boxaSort() calls this function if it will<para/>
''' likely go much faster.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaBinSort/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_PERIMETER</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
'''   <returns>boxad sorted version of boxas, or NULL on error</returns>
Public Shared Function boxaBinSort(
				 ByVal boxas as Boxa, 
				 ByVal sorttype as Enumerations.L_SORT_BY, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> Optional ByRef pnaindex as Numa = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaBinSort( boxas.Pointer, sorttype, sortorder, pnaindexPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (761, 1)
' boxaSortByIndex(boxas, naindex) as Boxa
' boxaSortByIndex(BOXA *, NUMA *) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSortByIndex/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="naindex">[in] - na that maps from the new boxa to the input boxa</param>
'''   <returns>boxad sorted, or NULL on error</returns>
Public Shared Function boxaSortByIndex(
				 ByVal boxas as Boxa, 
				 ByVal naindex as Numa) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (naindex) then Throw New ArgumentNullException  ("naindex cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSortByIndex( boxas.Pointer, naindex.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (837, 1)
' boxaSort2d(boxas, pnaad, delta1, delta2, minh1) as Boxaa
' boxaSort2d(BOXA *, NUMAA **, l_int32, l_int32, l_int32) as BOXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The final result is a sort where the 'fast scan' direction is<para/>
''' left to right, and the 'slow scan' direction is from top<para/>
''' to bottom.  Each boxa in the baa represents a sorted set<para/>
''' of boxes from left to right.<para/>
''' (2) Three passes are used to aggregate the boxas, which can correspond<para/>
''' to characters or words in a line of text.  In pass 1, only<para/>
''' taller components, which correspond to xheight or larger,<para/>
''' are permitted to start a new boxa.  In pass 2, the remaining<para/>
''' vertically-challenged components are allowed to join an<para/>
''' existing boxa or start a new one.  In pass 3, boxa whose extent<para/>
''' is overlapping are joined.  After that, the boxes in each<para/>
''' boxa are sorted horizontally, and finally the boxa are<para/>
''' sorted vertically.<para/>
''' (3) If delta1  is lower  0, the first pass allows aggregation when<para/>
''' boxes in the same boxa do not overlap vertically.<para/>
''' The distance by which they can miss and still be aggregated<para/>
''' is the absolute value |delta1|. Similar for delta2 on<para/>
''' the second pass.<para/>
''' (4) On the first pass, any component of height less than minh1<para/>
''' cannot start a new boxa it's put aside for later insertion.<para/>
''' (5) On the second pass, any small component that doesn't align<para/>
''' with an existing boxa can start a new one.<para/>
''' (6) This can be used to identify lines of text from<para/>
''' character or word bounding boxes.<para/>
''' (7) Typical values for the input parameters on 300 ppi text are:<para/>
''' delta1 ~ 0<para/>
''' delta2 ~ 0<para/>
''' minh1 ~ 5<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSort2d/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="pnaad">[out][optional] - numaa with sorted indices whose values are the indices of the input array</param>
'''  <param name="delta1">[in] - min overlap that permits aggregation of a box onto a boxa of horizontally-aligned boxes pass 1</param>
'''  <param name="delta2">[in] - min overlap that permits aggregation of a box onto a boxa of horizontally-aligned boxes pass 2</param>
'''  <param name="minh1">[in] - components less than this height either join an existing boxa or are set aside for pass 2</param>
'''   <returns>baa 2d sorted version of boxa, or NULL on error</returns>
Public Shared Function boxaSort2d(
				 ByVal boxas as Boxa, 
				<Out()> ByRef pnaad as Numaa, 
				 ByVal delta1 as Integer, 
				 ByVal delta2 as Integer, 
				 ByVal minh1 as Integer) as Boxaa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

Dim pnaadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaad) Then pnaadPTR = pnaad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSort2d( boxas.Pointer, pnaadPTR, delta1, delta2, minh1)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaadPTR <> IntPtr.Zero then pnaad = new Numaa(pnaadPTR)

	Return  new Boxaa(_Result)
End Function

' SRC\boxfunc2.c (1024, 1)
' boxaSort2dByIndex(boxas, naa) as Boxaa
' boxaSort2dByIndex(BOXA *, NUMAA *) as BOXAA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSort2dByIndex/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="naa">[in] - numaa that maps from the new baa to the input boxa</param>
'''   <returns>baa sorted boxaa, or NULL on error</returns>
Public Shared Function boxaSort2dByIndex(
				 ByVal boxas as Boxa, 
				 ByVal naa as Numaa) as Boxaa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSort2dByIndex( boxas.Pointer, naa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxfunc2.c (1093, 1)
' boxaExtractAsNuma(boxa, pnal, pnat, pnar, pnab, pnaw, pnah, keepinvalid) as Integer
' boxaExtractAsNuma(BOXA *, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If you are counting or sorting values, such as determining<para/>
''' rank order, you must remove invalid boxes.<para/>
''' (2) If you are parametrizing the values, or doing an evaluation<para/>
''' where the position in the boxa sequence is important, you<para/>
''' must replace the invalid boxes with valid ones before<para/>
''' doing the extraction. This is easily done with boxaFillSequence().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaExtractAsNuma/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pnal">[out][optional] - array of left locations</param>
'''  <param name="pnat">[out][optional] - array of top locations</param>
'''  <param name="pnar">[out][optional] - array of right locations</param>
'''  <param name="pnab">[out][optional] - array of bottom locations</param>
'''  <param name="pnaw">[out][optional] - array of widths</param>
'''  <param name="pnah">[out][optional] - array of heights</param>
'''  <param name="keepinvalid">[in] - 1 to keep invalid boxes 0 to remove them</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaExtractAsNuma(
				 ByVal boxa as Boxa, 
				<Out()> ByRef pnal as Numa, 
				<Out()> ByRef pnat as Numa, 
				<Out()> ByRef pnar as Numa, 
				<Out()> ByRef pnab as Numa, 
				<Out()> ByRef pnaw as Numa, 
				<Out()> ByRef pnah as Numa, 
				 ByVal keepinvalid as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pnalPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnal) Then pnalPTR = pnal.Pointer
Dim pnatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnat) Then pnatPTR = pnat.Pointer
Dim pnarPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnar) Then pnarPTR = pnar.Pointer
Dim pnabPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnab) Then pnabPTR = pnab.Pointer
Dim pnawPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaw) Then pnawPTR = pnaw.Pointer
Dim pnahPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnah) Then pnahPTR = pnah.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaExtractAsNuma( boxa.Pointer, pnalPTR, pnatPTR, pnarPTR, pnabPTR, pnawPTR, pnahPTR, keepinvalid)
	if pnalPTR <> IntPtr.Zero then pnal = new Numa(pnalPTR)
	if pnatPTR <> IntPtr.Zero then pnat = new Numa(pnatPTR)
	if pnarPTR <> IntPtr.Zero then pnar = new Numa(pnarPTR)
	if pnabPTR <> IntPtr.Zero then pnab = new Numa(pnabPTR)
	if pnawPTR <> IntPtr.Zero then pnaw = new Numa(pnawPTR)
	if pnahPTR <> IntPtr.Zero then pnah = new Numa(pnahPTR)

	Return _Result
End Function

' SRC\boxfunc2.c (1170, 1)
' boxaExtractAsPta(boxa, pptal, pptat, pptar, pptab, pptaw, pptah, keepinvalid) as Integer
' boxaExtractAsPta(BOXA *, PTA **, PTA **, PTA **, PTA **, PTA **, PTA **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For most applications, such as counting, sorting, fitting<para/>
''' to some parametrized form, plotting or filtering in general,<para/>
''' you should remove the invalid boxes.  Each pta saves the<para/>
''' box index in the x array, so replacing invalid boxes by<para/>
''' filling with boxaFillSequence(), which is required for<para/>
''' boxaExtractAsNuma(), is not necessary.<para/>
''' (2) If invalid boxes are retained, each one will result in<para/>
''' entries (typically 0) in all selected output pta.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaExtractAsPta/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pptal">[out][optional] - array of left locations vs. index</param>
'''  <param name="pptat">[out][optional] - array of top locations vs. index</param>
'''  <param name="pptar">[out][optional] - array of right locations vs. index</param>
'''  <param name="pptab">[out][optional] - array of bottom locations vs. index</param>
'''  <param name="pptaw">[out][optional] - array of widths vs. index</param>
'''  <param name="pptah">[out][optional] - array of heights vs. index</param>
'''  <param name="keepinvalid">[in] - 1 to keep invalid boxes 0 to remove them</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaExtractAsPta(
				 ByVal boxa as Boxa, 
				<Out()> ByRef pptal as Pta, 
				<Out()> ByRef pptat as Pta, 
				<Out()> ByRef pptar as Pta, 
				<Out()> ByRef pptab as Pta, 
				<Out()> ByRef pptaw as Pta, 
				<Out()> ByRef pptah as Pta, 
				 ByVal keepinvalid as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pptalPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptal) Then pptalPTR = pptal.Pointer
Dim pptatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptat) Then pptatPTR = pptat.Pointer
Dim pptarPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptar) Then pptarPTR = pptar.Pointer
Dim pptabPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptab) Then pptabPTR = pptab.Pointer
Dim pptawPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptaw) Then pptawPTR = pptaw.Pointer
Dim pptahPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptah) Then pptahPTR = pptah.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaExtractAsPta( boxa.Pointer, pptalPTR, pptatPTR, pptarPTR, pptabPTR, pptawPTR, pptahPTR, keepinvalid)
	if pptalPTR <> IntPtr.Zero then pptal = new Pta(pptalPTR)
	if pptatPTR <> IntPtr.Zero then pptat = new Pta(pptatPTR)
	if pptarPTR <> IntPtr.Zero then pptar = new Pta(pptarPTR)
	if pptabPTR <> IntPtr.Zero then pptab = new Pta(pptabPTR)
	if pptawPTR <> IntPtr.Zero then pptaw = new Pta(pptawPTR)
	if pptahPTR <> IntPtr.Zero then pptah = new Pta(pptahPTR)

	Return _Result
End Function

' SRC\boxfunc2.c (1251, 1)
' boxaGetRankVals(boxa, fract, px, py, pw, ph) as Integer
' boxaGetRankVals(BOXA *, l_float32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function does not assume that all boxes in the boxa are valid<para/>
''' (2) The four box parameters are sorted independently.<para/>
''' For rank order, the width and height are sorted in increasing<para/>
''' order.  But what does it mean to sort x and y in "rank order"?<para/>
''' If the boxes are of comparable size and somewhat<para/>
''' aligned (e.g., from multiple images), it makes some sense<para/>
''' to give a "rank order" for x and y by sorting them in<para/>
''' decreasing order.  But in general, the interpretation of a rank<para/>
''' order on x and y is highly application dependent.  In summary:<para/>
''' ~ x and y are sorted in decreasing order<para/>
''' ~ w and h are sorted in increasing order<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetRankVals/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="fract">[in] - use 0.0 for smallest, 1.0 for largest width and height</param>
'''  <param name="px">[out][optional] - rank value of x</param>
'''  <param name="py">[out][optional] - rank value of y</param>
'''  <param name="pw">[out][optional] - rank value of width</param>
'''  <param name="ph">[out][optional] - rank value of height</param>
'''   <returns>0 if OK, 1 on error or if the boxa is empty or has no valid boxes</returns>
Public Shared Function boxaGetRankVals(
				 ByVal boxa as Boxa, 
				 ByVal fract as Single, 
				<Out()> Optional ByRef px as Integer = Nothing, 
				<Out()> Optional ByRef py as Integer = Nothing, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetRankVals( boxa.Pointer, fract, px, py, pw, ph)

	Return _Result
End Function

' SRC\boxfunc2.c (1317, 1)
' boxaGetMedianVals(boxa, px, py, pw, ph) as Integer
' boxaGetMedianVals(BOXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See boxaGetRankVals()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetMedianVals/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="px">[out][optional] - median value of x</param>
'''  <param name="py">[out][optional] - median value of y</param>
'''  <param name="pw">[out][optional] - median value of width</param>
'''  <param name="ph">[out][optional] - median value of height</param>
'''   <returns>0 if OK, 1 on error or if the boxa is empty or has no valid boxes</returns>
Public Shared Function boxaGetMedianVals(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef px as Integer = Nothing, 
				<Out()> Optional ByRef py as Integer = Nothing, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetMedianVals( boxa.Pointer, px, py, pw, ph)

	Return _Result
End Function

' SRC\boxfunc2.c (1343, 1)
' boxaGetAverageSize(boxa, pw, ph) as Integer
' boxaGetAverageSize(BOXA *, l_float32 *, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetAverageSize/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pw">[out][optional] - average width</param>
'''  <param name="ph">[out][optional] - average height</param>
'''   <returns>0 if OK, 1 on error or if the boxa is empty</returns>
Public Shared Function boxaGetAverageSize(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef pw as Single = Nothing, 
				<Out()> Optional ByRef ph as Single = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetAverageSize( boxa.Pointer, pw, ph)

	Return _Result
End Function

' SRC\boxfunc2.c (1398, 1)
' boxaaGetExtent(baa, pw, ph, pbox, pboxa) as Integer
' boxaaGetExtent(BOXAA *, l_int32 *, l_int32 *, BOX **, BOXA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned w and h are the minimum size image<para/>
''' that would contain all boxes untranslated.<para/>
''' (2) Each box in the returned boxa is the minimum box required to<para/>
''' hold all the boxes in the respective boxa of baa.<para/>
''' (3) If there are no valid boxes in a boxa, the box corresponding<para/>
''' to its extent has all fields set to 0 (an invalid box).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaGetExtent/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pbox">[out][optional] - minimum box containing all boxa in boxaa</param>
'''  <param name="pboxa">[out][optional] - boxa containing all boxes in each boxa in the boxaa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaGetExtent(
				 ByVal baa as Boxaa, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pbox as Box = Nothing, 
				<Out()> Optional ByRef pboxa as Boxa = Nothing) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")

Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer
Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaGetExtent( baa.Pointer, pw, ph, pboxPTR, pboxaPTR)
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return _Result
End Function

' SRC\boxfunc2.c (1478, 1)
' boxaaFlattenToBoxa(baa, pnaindex, copyflag) as Boxa
' boxaaFlattenToBoxa(BOXAA *, NUMA **, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This 'flattens' the baa to a boxa, taking the boxes in<para/>
''' order in the first boxa, then the second, etc.<para/>
''' (2) If a boxa is empty, we generate an invalid, placeholder box<para/>
''' of zero size.  This is useful when converting from a baa<para/>
''' where each boxa has either 0 or 1 boxes, and it is necessary<para/>
''' to maintain a 1:1 correspondence between the initial<para/>
''' boxa array and the resulting box array.<para/>
''' (3) If  and naindex is defined, we generate a Numa that gives, for<para/>
''' each box in the baa, the index of the boxa to which it belongs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaFlattenToBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="pnaindex">[out][optional] - the boxa index in the baa</param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaaFlattenToBoxa(
				 ByVal baa as Boxaa, 
				<Out()> ByRef pnaindex as Numa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaFlattenToBoxa( baa.Pointer, pnaindexPTR, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (1544, 1)
' boxaaFlattenAligned(baa, num, fillerbox, copyflag) as Boxa
' boxaaFlattenAligned(BOXAA *, l_int32, BOX *, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This 'flattens' the baa to a boxa, taking the first %num<para/>
''' boxes from each boxa.<para/>
''' (2) In each boxa, if there are less than %num boxes, we preserve<para/>
''' the alignment between the input baa and the output boxa<para/>
''' by inserting one or more fillerbox(es) or, if %fillerbox == NULL,<para/>
''' one or more invalid placeholder boxes.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaFlattenAligned/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="num">[in] - number extracted from each</param>
'''  <param name="fillerbox">[in][optional] - that fills if necessary</param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaaFlattenAligned(
				 ByVal baa as Boxaa, 
				 ByVal num as Integer, 
				 ByVal fillerbox as Box, 
				 ByVal copyflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")

	Dim fillerboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fillerbox) Then fillerboxPTR = fillerbox.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaFlattenAligned( baa.Pointer, num, fillerboxPTR, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc2.c (1602, 1)
' boxaEncapsulateAligned(boxa, num, copyflag) as Boxaa
' boxaEncapsulateAligned(BOXA *, l_int32, l_int32) as BOXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This puts %num boxes from the input %boxa into each of a<para/>
''' set of boxa within an output baa.<para/>
''' (2) This assumes that the boxes in %boxa are in sets of %num each.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaEncapsulateAligned/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="num">[in] - number put into each boxa in the baa</param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>baa, or NULL on error</returns>
Public Shared Function boxaEncapsulateAligned(
				 ByVal boxa as Boxa, 
				 ByVal num as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as Boxaa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaEncapsulateAligned( boxa.Pointer, num, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxfunc2.c (1656, 1)
' boxaaTranspose(baas) as Boxaa
' boxaaTranspose(BOXAA *) as BOXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If you think of a boxaa as a 2D array of boxes that is accessed<para/>
''' row major, then each row is represented by one of the boxa.<para/>
''' This function creates a new boxaa related to the input boxaa<para/>
''' as a column major traversal of the input boxaa.<para/>
''' (2) For example, if %baas has 2 boxa, each with 10 boxes, then<para/>
''' %baad will have 10 boxa, each with 2 boxes.<para/>
''' (3) Require for this transpose operation that each boxa in<para/>
''' %baas has the same number of boxes.  This operation is useful<para/>
''' when the i-th boxes in each boxa are meaningfully related.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaTranspose/*"/>
'''  <param name="baas">[in] - </param>
'''   <returns>baad, or NULL on error</returns>
Public Shared Function boxaaTranspose(
				 ByVal baas as Boxaa) as Boxaa

	If IsNothing (baas) then Throw New ArgumentNullException  ("baas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaTranspose( baas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxfunc2.c (1715, 1)
' boxaaAlignBox(baa, box, delta, pindex) as Integer
' boxaaAlignBox(BOXAA *, BOX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is not greedy.  It finds the boxa whose vertical<para/>
''' extent has the closest overlap with the input box.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaAlignBox/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="box">[in] - to be aligned with the bext boxa in the baa, if possible</param>
'''  <param name="delta">[in] - amount by which consecutive components can miss in overlap and still be included in the array</param>
'''  <param name="pindex">[out] - index of boxa with best overlap, or if none match, this is the index of the next boxa to be generated</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaAlignBox(
				 ByVal baa as Boxaa, 
				 ByVal box as Box, 
				 ByVal delta as Integer, 
				<Out()> ByRef pindex as Integer) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaAlignBox( baa.Pointer, box.Pointer, delta, pindex)

	Return _Result
End Function

End Class
