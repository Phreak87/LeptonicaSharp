Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\boxfunc4.c (111, 1)
' boxaSelectRange(boxas, first, last, copyflag) as Boxa
' boxaSelectRange(BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The copyflag specifies what we do with each box from boxas.
''' Specifically, L_CLONE inserts a clone into boxad of each
''' selected box from boxas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSelectRange/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="first">[in] - use 0 to select from the beginning</param>
'''  <param name="last">[in] - use 0 to select to the end</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaSelectRange(
				 ByVal boxas as Boxa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSelectRange( boxas.Pointer, first, last, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (164, 1)
' boxaaSelectRange(baas, first, last, copyflag) as Boxaa
' boxaaSelectRange(BOXAA *, l_int32, l_int32, l_int32) as BOXAA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The copyflag specifies what we do with each boxa from baas.
''' Specifically, L_CLONE inserts a clone into baad of each
''' selected boxa from baas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaSelectRange/*"/>
'''  <param name="baas">[in] - </param>
'''  <param name="first">[in] - use 0 to select from the beginning</param>
'''  <param name="last">[in] - use 0 to select to the end</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>baad, or NULL on error</returns>
Public Shared Function boxaaSelectRange(
				 ByVal baas as Boxaa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as Boxaa

	If IsNothing (baas) then Throw New ArgumentNullException  ("baas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaSelectRange( baas.Pointer, first, last, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxfunc4.c (227, 1)
' boxaSelectBySize(boxas, width, height, type, relation, pchanged) as Boxa
' boxaSelectBySize(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The args specify constraints on the size of the
''' components that are kept.<para/>
''' 
''' (2) Uses box copies in the new boxa.<para/>
''' 
''' (3) If the selection type is L_SELECT_WIDTH, the input
''' height is ignored, and v.v.<para/>
''' 
''' (4) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSelectBySize/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="width">[in] - threshold dimensions</param>
'''  <param name="height">[in] - threshold dimensions</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
'''   <returns>boxad filtered set, or NULL on error</returns>
Public Shared Function boxaSelectBySize(
				 ByVal boxas as Boxa, 
				 ByVal width as Integer, 
				 ByVal height as Integer, 
				 ByVal type as Enumerations.L_SELECT, 
				 ByVal relation as Enumerations.L_SELECT_IF, 
				<Out()> Optional ByRef pchanged as Integer = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSelectBySize( boxas.Pointer, width, height, type, relation, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (290, 1)
' boxaMakeSizeIndicator(boxa, width, height, type, relation) as Numa
' boxaMakeSizeIndicator(BOXA *, l_int32, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The args specify constraints on the size of the
''' components that are kept.<para/>
''' 
''' (2) If the selection type is L_SELECT_WIDTH, the input
''' height is ignored, and v.v.<para/>
''' 
''' (3) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaMakeSizeIndicator/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="width">[in] - threshold dimensions</param>
'''  <param name="height">[in] - threshold dimensions</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>na indicator array, or NULL on error</returns>
Public Shared Function boxaMakeSizeIndicator(
				 ByVal boxa as Boxa, 
				 ByVal width as Integer, 
				 ByVal height as Integer, 
				 ByVal type as Enumerations.L_SELECT, 
				 ByVal relation as Enumerations.L_SELECT_IF) as Numa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaMakeSizeIndicator( boxa.Pointer, width, height, type, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\boxfunc4.c (377, 1)
' boxaSelectByArea(boxas, area, relation, pchanged) as Boxa
' boxaSelectByArea(BOXA *, l_int32, l_int32, l_int32 *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Uses box copies in the new boxa.<para/>
''' 
''' (2) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSelectByArea/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="area">[in] - threshold value of width  height</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
'''   <returns>boxad filtered set, or NULL on error</returns>
Public Shared Function boxaSelectByArea(
				 ByVal boxas as Boxa, 
				 ByVal area as Integer, 
				 ByVal relation as Enumerations.L_SELECT_IF, 
				<Out()> Optional ByRef pchanged as Integer = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSelectByArea( boxas.Pointer, area, relation, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (427, 1)
' boxaMakeAreaIndicator(boxa, area, relation) as Numa
' boxaMakeAreaIndicator(BOXA *, l_int32, l_int32) as NUMA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaMakeAreaIndicator/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="area">[in] - threshold value of width  height</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>na indicator array, or NULL on error</returns>
Public Shared Function boxaMakeAreaIndicator(
				 ByVal boxa as Boxa, 
				 ByVal area as Integer, 
				 ByVal relation as Enumerations.L_SELECT_IF) as Numa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaMakeAreaIndicator( boxa.Pointer, area, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\boxfunc4.c (481, 1)
' boxaSelectByWHRatio(boxas, ratio, relation, pchanged) as Boxa
' boxaSelectByWHRatio(BOXA *, l_float32, l_int32, l_int32 *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Uses box copies in the new boxa.<para/>
''' 
''' (2) To keep narrow components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep wide components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSelectByWHRatio/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="ratio">[in] - width/height threshold value</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
'''   <returns>boxad filtered set, or NULL on error</returns>
Public Shared Function boxaSelectByWHRatio(
				 ByVal boxas as Boxa, 
				 ByVal ratio as Single, 
				 ByVal relation as Enumerations.L_SELECT_IF, 
				<Out()> Optional ByRef pchanged as Integer = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSelectByWHRatio( boxas.Pointer, ratio, relation, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (531, 1)
' boxaMakeWHRatioIndicator(boxa, ratio, relation) as Numa
' boxaMakeWHRatioIndicator(BOXA *, l_float32, l_int32) as NUMA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) To keep narrow components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep wide components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaMakeWHRatioIndicator/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="ratio">[in] - width/height threshold value</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>na indicator array, or NULL on error</returns>
Public Shared Function boxaMakeWHRatioIndicator(
				 ByVal boxa as Boxa, 
				 ByVal ratio as Single, 
				 ByVal relation as Enumerations.L_SELECT_IF) as Numa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaMakeWHRatioIndicator( boxa.Pointer, ratio, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\boxfunc4.c (583, 1)
' boxaSelectWithIndicator(boxas, na, pchanged) as Boxa
' boxaSelectWithIndicator(BOXA *, NUMA *, l_int32 *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Returns a copy of the boxa if no components are removed.<para/>
''' 
''' (2) Uses box copies in the new boxa.<para/>
''' 
''' (3) The indicator numa has values 0 (ignore) and 1 (accept).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSelectWithIndicator/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="na">[in] - indicator numa</param>
'''  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
'''   <returns>boxad, or NULL on error</returns>
Public Shared Function boxaSelectWithIndicator(
				 ByVal boxas as Boxa, 
				 ByVal na as Numa, 
				<Out()> Optional ByRef pchanged as Integer = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSelectWithIndicator( boxas.Pointer, na.Pointer, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (641, 1)
' boxaPermutePseudorandom(boxas) as Boxa
' boxaPermutePseudorandom(BOXA *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a pseudorandom in-place permutation of the boxes.<para/>
''' 
''' (2) The result is guaranteed not to have any boxes in their
''' original position, but it is not very random.  If you
''' need randomness, use boxaPermuteRandom().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaPermutePseudorandom/*"/>
'''  <param name="boxas">[in] - input boxa</param>
'''   <returns>boxad with boxes permuted, or NULL on error</returns>
Public Shared Function boxaPermutePseudorandom(
				 ByVal boxas as Boxa) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaPermutePseudorandom( boxas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (682, 1)
' boxaPermuteRandom(boxad, boxas) as Boxa
' boxaPermuteRandom(BOXA *, BOXA *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) If boxad is null, make a copy of boxas and permute the copy.
''' Otherwise, boxad must be equal to boxas, and the operation
''' is done in-place.<para/>
''' 
''' (2) If boxas is empty, return an empty boxad.<para/>
''' 
''' (3) This does a random in-place permutation of the boxes,
''' by swapping each box in turn with a random box.  The
''' result is almost guaranteed not to have any boxes in their
''' original position.<para/>
''' 
''' (4) MSVC rand() has MAX_RAND = 2^15 - 1, so it will not do
''' a proper permutation is the number of boxes exceeds this.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaPermuteRandom/*"/>
'''  <param name="boxad">[in][optional] - can be null or equal to boxas</param>
'''  <param name="boxas">[in] - input boxa</param>
'''   <returns>boxad with boxes permuted, or NULL on error</returns>
Public Shared Function boxaPermuteRandom(
				 ByVal boxad as Boxa, 
				 ByVal boxas as Boxa) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim boxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxad) Then boxadPTR = boxad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaPermuteRandom( boxadPTR, boxas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (719, 1)
' boxaSwapBoxes(boxa, i, j) as Integer
' boxaSwapBoxes(BOXA *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSwapBoxes/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="i">[in] - two indices of boxes, that are to be swapped</param>
'''  <param name="j">[in] - two indices of boxes, that are to be swapped</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSwapBoxes(
				 ByVal boxa as Boxa, 
				 ByVal i as Integer, 
				 ByVal j as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSwapBoxes( boxa.Pointer, i, j)

	Return _Result
End Function

' SRC\boxfunc4.c (763, 1)
' boxaConvertToPta(boxa, ncorners) as Pta
' boxaConvertToPta(BOXA *, l_int32) as PTA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) If ncorners == 2, we select the UL and LR corners.
''' Otherwise we save all 4 corners in this order: UL, UR, LL, LR.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaConvertToPta/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="ncorners">[in] - 2 or 4 for the representation of each box</param>
'''   <returns>pta with %ncorners points for each box in the boxa, or NULL on error</returns>
Public Shared Function boxaConvertToPta(
				 ByVal boxa as Boxa, 
				 ByVal ncorners as Integer) as Pta

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaConvertToPta( boxa.Pointer, ncorners)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\boxfunc4.c (808, 1)
' ptaConvertToBoxa(pta, ncorners) as Boxa
' ptaConvertToBoxa(PTA *, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) For 2 corners, the order of the 2 points is UL, LR.
''' For 4 corners, the order of points is UL, UR, LL, LR.<para/>
''' 
''' (2) Each derived box is the minimum size containing all corners.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/ptaConvertToBoxa/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="ncorners">[in] - 2 or 4 for the representation of each box</param>
'''   <returns>boxa with one box for each 2 or 4 points in the pta, or NULL on error</returns>
Public Shared Function ptaConvertToBoxa(
				 ByVal pta as Pta, 
				 ByVal ncorners as Integer) as Boxa

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaConvertToBoxa( pta.Pointer, ncorners)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (863, 1)
' boxConvertToPta(box, ncorners) as Pta
' boxConvertToPta(BOX *, l_int32) as PTA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) If ncorners == 2, we select the UL and LR corners.
''' Otherwise we save all 4 corners in this order: UL, UR, LL, LR.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxConvertToPta/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="ncorners">[in] - 2 or 4 for the representation of the box</param>
'''   <returns>pta with %ncorners points, or NULL on error</returns>
Public Shared Function boxConvertToPta(
				 ByVal box as Box, 
				 ByVal ncorners as Integer) as Pta

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxConvertToPta( box.Pointer, ncorners)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\boxfunc4.c (905, 1)
' ptaConvertToBox(pta) as Box
' ptaConvertToBox(PTA *) as BOX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) For 2 corners, the order of the 2 points is UL, LR.
''' For 4 corners, the order of points is UL, UR, LL, LR.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/ptaConvertToBox/*"/>
'''  <param name="pta">[in] - </param>
'''   <returns>box minimum containing all points in the pta, or NULL on error</returns>
Public Shared Function ptaConvertToBox(
				 ByVal pta as Pta) as Box

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaConvertToBox( pta.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxfunc4.c (967, 1)
' boxaSmoothSequenceLS(boxas, factor, subflag, maxdiff, extrapixels, debug) as Boxa
' boxaSmoothSequenceLS(BOXA *, l_float32, l_int32, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This returns a modified version of %boxas by constructing
''' for each input box a box that has been linear least square fit
''' (LSF) to the entire set.  The linear fitting is done to each of
''' the box sides independently, after outliers are rejected,
''' and it is computed separately for sequences of even and
''' odd boxes.  Once the linear LSF box is found, the output box
''' (in %boxad) is constructed from the input box and the LSF
''' box, depending on %subflag.  See boxaModifyWithBoxa() for
''' details on the use of %subflag and %maxdiff.<para/>
''' 
''' (2) This is useful if, in both the even and odd sets, the box
''' edges vary roughly linearly with its index in the set.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSmoothSequenceLS/*"/>
'''  <param name="boxas">[in] - source boxa</param>
'''  <param name="factor">[in] - reject outliers with widths and heights deviating from the median by more than %factor times the median variation from the median typically ~3</param>
'''  <param name="subflag">[in] - L_USE_MINSIZE, L_USE_MAXSIZE, L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="maxdiff">[in] - parameter used with L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="extrapixels">[in] - pixels added on all sides (or subtracted if %extrapixels  is smaller 0) when using L_SUB_ON_LOC_DIFF and L_SUB_ON_SIZE_DIFF</param>
'''  <param name="debug">[in] - 1 for debug output</param>
'''   <returns>boxad fitted boxa, or NULL on error</returns>
Public Shared Function boxaSmoothSequenceLS(
				 ByVal boxas as Boxa, 
				 ByVal factor as Single, 
				 ByVal subflag as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal maxdiff as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal extrapixels as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSmoothSequenceLS( boxas.Pointer, factor, subflag, maxdiff, extrapixels, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1073, 1)
' boxaSmoothSequenceMedian(boxas, halfwin, subflag, maxdiff, extrapixels, debug) as Boxa
' boxaSmoothSequenceMedian(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The target width of the sliding window is 2  %halfwin + 1.
''' If necessary, this will be reduced by boxaWindowedMedian().<para/>
''' 
''' (2) This returns a modified version of %boxas by constructing
''' for each input box a box that has been smoothed with windowed
''' median filtering.  The filtering is done to each of the
''' box sides independently, and it is computed separately for
''' sequences of even and odd boxes.  The output %boxad is
''' constructed from the input boxa and the filtered boxa,
''' depending on %subflag.  See boxaModifyWithBoxa() for
''' details on the use of %subflag, %maxdiff and %extrapixels.<para/>
''' 
''' (3) This is useful for removing noise separately in the even
''' and odd sets, where the box edge locations can have
''' discontinuities but otherwise vary roughly linearly within
''' intervals of size %halfwin or larger.<para/>
''' 
''' (4) If you don't need to handle even and odd sets separately,
''' just do this:
''' boxam = boxaWindowedMedian(boxas, halfwin, debug)
''' boxad = boxaModifyWithBoxa(boxas, boxam, subflag, maxdiff,
''' extrapixels)
''' boxaDestroy([and]boxam)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSmoothSequenceMedian/*"/>
'''  <param name="boxas">[in] - source boxa</param>
'''  <param name="halfwin">[in] - half-width of sliding window used to find median</param>
'''  <param name="subflag">[in] - L_USE_MINSIZE, L_USE_MAXSIZE, L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="maxdiff">[in] - parameter used with L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="extrapixels">[in] - pixels added on all sides (or subtracted if %extrapixels  is smaller 0) when using L_SUB_ON_LOC_DIFF and L_SUB_ON_SIZE_DIFF</param>
'''  <param name="debug">[in] - 1 for debug output</param>
'''   <returns>boxad fitted boxa, or NULL on error</returns>
Public Shared Function boxaSmoothSequenceMedian(
				 ByVal boxas as Boxa, 
				 ByVal halfwin as Integer, 
				 ByVal subflag as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal maxdiff as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal extrapixels as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSmoothSequenceMedian( boxas.Pointer, halfwin, subflag, maxdiff, extrapixels, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1179, 1)
' boxaLinearFit(boxas, factor, debug) as Boxa
' boxaLinearFit(BOXA *, l_float32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This finds a set of boxes (boxad) where each edge of each box is
''' a linear least square fit (LSF) to the edges of the
''' input set of boxes (boxas).  Before fitting, outliers in
''' the boxes in boxas are removed (see below).<para/>
''' 
''' (2) This is useful when each of the box edges in boxas are expected
''' to vary linearly with box index in the set.  These could
''' be, for example, noisy measurements of similar regions
''' on successive scanned pages.<para/>
''' 
''' (3) Method: there are 2 steps:
''' (a) Find and remove outliers, separately based on the deviation
''' from the median of the width and height of the box.
''' Use %factor to specify tolerance to outliers use a very
''' large value of %factor to avoid rejecting any box sides
''' in the linear LSF.
''' (b) On the remaining boxes, do a linear LSF independently
''' for each of the four sides.<para/>
''' 
''' (4) Invalid input boxes are not used in computation of the LSF.<para/>
''' 
''' (5) The returned boxad can then be used in boxaModifyWithBoxa()
''' to selectively change the boxes in boxas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaLinearFit/*"/>
'''  <param name="boxas">[in] - source boxa</param>
'''  <param name="factor">[in] - reject outliers with widths and heights deviating from the median by more than %factor times the median deviation from the median typically ~3</param>
'''  <param name="debug">[in] - 1 for debug output</param>
'''   <returns>boxad fitted boxa, or NULL on error</returns>
Public Shared Function boxaLinearFit(
				 ByVal boxas as Boxa, 
				 ByVal factor as Single, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaLinearFit( boxas.Pointer, factor, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1331, 1)
' boxaWindowedMedian(boxas, halfwin, debug) as Boxa
' boxaWindowedMedian(BOXA *, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This finds a set of boxes (boxad) where each edge of each box is
''' a windowed median smoothed value to the edges of the
''' input set of boxes (boxas).<para/>
''' 
''' (2) Invalid input boxes are filled from nearby ones.<para/>
''' 
''' (3) The returned boxad can then be used in boxaModifyWithBoxa()
''' to selectively change the boxes in the source boxa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaWindowedMedian/*"/>
'''  <param name="boxas">[in] - source boxa</param>
'''  <param name="halfwin">[in] - half width of window over which the median is found</param>
'''  <param name="debug">[in] - 1 for debug output</param>
'''   <returns>boxad smoothed boxa, or NULL on error</returns>
Public Shared Function boxaWindowedMedian(
				 ByVal boxas as Boxa, 
				 ByVal halfwin as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaWindowedMedian( boxas.Pointer, halfwin, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1469, 1)
' boxaModifyWithBoxa(boxas, boxam, subflag, maxdiff, extrapixels) as Boxa
' boxaModifyWithBoxa(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This takes two input boxa (boxas, boxam) and constructs boxad,
''' where each box in boxad is generated from the corresponding
''' boxes in boxas and boxam.  The rule for constructing each
''' output box depends on %subflag and %maxdiff.  Let boxs be
''' a box from %boxas and boxm be a box from %boxam.
''' If %subflag == L_USE_MINSIZE: the output box is the intersection
''' of the two input boxes.
''' If %subflag == L_USE_MAXSIZE: the output box is the union of the
''' two input boxes i.e., the minimum bounding rectangle for the
''' two input boxes.
''' If %subflag == L_SUB_ON_LOC_DIFF: each side of the output box
''' is found separately from the corresponding side of boxs and boxm.
''' Use the boxm side, expanded by %extrapixels, if greater than
''' %maxdiff pixels from the boxs side.
''' If %subflag == L_SUB_ON_SIZE_DIFF: the sides of the output box
''' are determined in pairs from the width and height of boxs
''' and boxm.  If the boxm width differs by more than %maxdiff
''' pixels from boxs, use the boxm left and right sides,
''' expanded by %extrapixels.  Ditto for the height difference.
''' For the last two flags, each side of the output box is found
''' separately from the corresponding side of boxs and boxm,
''' according to these rules, where "smaller"("bigger") mean in a
''' direction that decreases(increases) the size of the output box:
''' If %subflag == L_USE_CAPPED_MIN: use the Min of boxm
''' with the Max of (boxs, boxm +- %maxdiff), where the sign
''' is adjusted to make the box smaller (e.g., use "+" on left side).
''' If %subflag == L_USE_CAPPED_MAX: use the Max of boxm
''' with the Min of (boxs, boxm +- %maxdiff), where the sign
''' is adjusted to make the box bigger (e.g., use "-" on left side).
''' Use of the last 2 flags is further explained in (3) and (4).<para/>
''' 
''' (2) boxas and boxam must be the same size.  If boxam == NULL,
''' this returns a copy of boxas with a warning.<para/>
''' 
''' (3) If %subflag == L_SUB_ON_LOC_DIFF, use boxm for each side
''' where the corresponding sides differ by more than %maxdiff.
''' Two extreme cases:
''' (a) set %maxdiff == 0 to use only values from boxam in boxad.
''' (b) set %maxdiff == 10000 to ignore all values from boxam
''' then boxad will be the same as boxas.<para/>
''' 
''' (4) If %subflag == L_USE_CAPPED_MAX: use boxm if boxs is smaller
''' use boxs if boxs is bigger than boxm by an amount up to %maxdiff
''' and use boxm +- %maxdiff (the 'capped' value) if boxs is
''' bigger than boxm by an amount larger than %maxdiff.
''' Similarly, with interchange of Min/Max and sign of %maxdiff,
''' for %subflag == L_USE_CAPPED_MIN.<para/>
''' 
''' (5) If either of corresponding boxes in boxas and boxam is invalid,
''' an invalid box is copied to the result.<para/>
''' 
''' (6) Typical input for boxam may be the output of boxaLinearFit().
''' where outliers have been removed and each side is LS fit to a line.<para/>
''' 
''' (7) Unlike boxaAdjustWidthToTarget() and boxaAdjustHeightToTarget(),
''' this uses two boxes and does not specify target dimensions.
''' Additional constraints on the size of each box can be enforced
''' by following this operation with boxaConstrainSize(), taking
''' boxad as input.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaModifyWithBoxa/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="boxam">[in] - boxa with boxes used to modify those in boxas</param>
'''  <param name="subflag">[in] - L_USE_MINSIZE, L_USE_MAXSIZE, L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="maxdiff">[in] - parameter used with L_SUB_ON_LOC_DIFF, L_SUB_ON_SIZE_DIFF, L_USE_CAPPED_MIN, L_USE_CAPPED_MAX</param>
'''  <param name="extrapixels">[in] - pixels added on all sides (or subtracted if %extrapixels  is smaller 0) when using L_SUB_ON_LOC_DIFF and L_SUB_ON_SIZE_DIFF</param>
'''   <returns>boxad result after adjusting boxes in boxas, or NULL on error.</returns>
Public Shared Function boxaModifyWithBoxa(
				 ByVal boxas as Boxa, 
				 ByVal boxam as Boxa, 
				 ByVal subflag as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal maxdiff as Enumerations.L__modifying_box_boundaries_using_a_second_box, 
				 ByVal extrapixels as Enumerations.L__modifying_box_boundaries_using_a_second_box) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (boxam) then Throw New ArgumentNullException  ("boxam cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaModifyWithBoxa( boxas.Pointer, boxam.Pointer, subflag, maxdiff, extrapixels)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1585, 1)
' boxaConstrainSize(boxas, width, widthflag, height, heightflag) as Boxa
' boxaConstrainSize(BOXA *, l_int32, l_int32, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Forces either width or height (or both) of every box in
''' the boxa to a specified size, by moving the indicated sides.<para/>
''' 
''' (2) Not all input boxes need to be valid.  Median values will be
''' used with invalid boxes.<para/>
''' 
''' (3) Typical input might be the output of boxaLinearFit(),
''' where each side has been fit.<para/>
''' 
''' (4) Unlike boxaAdjustWidthToTarget() and boxaAdjustHeightToTarget(),
''' this is not dependent on a difference threshold to change the size.<para/>
''' 
''' (5) On error, a message is issued and a copy of the input boxa
''' is returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaConstrainSize/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="width">[in] - force width of all boxes to this size input 0 to use the median width</param>
'''  <param name="widthflag">[in] - L_ADJUST_SKIP, L_ADJUST_LEFT, L_ADJUST_RIGHT, or L_ADJUST_LEFT_AND_RIGHT</param>
'''  <param name="height">[in] - force height of all boxes to this size input 0 to use the median height</param>
'''  <param name="heightflag">[in] - L_ADJUST_SKIP, L_ADJUST_TOP, L_ADJUST_BOT, or L_ADJUST_TOP_AND_BOT</param>
'''   <returns>boxad adjusted so all boxes are the same size</returns>
Public Shared Function boxaConstrainSize(
				 ByVal boxas as Boxa, 
				 ByVal width as Integer, 
				 ByVal widthflag as Enumerations.L_box_size_adjustment_location, 
				 ByVal height as Integer, 
				 ByVal heightflag as Enumerations.L_box_size_adjustment_location) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaConstrainSize( boxas.Pointer, width, widthflag, height, heightflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1694, 1)
' boxaReconcileEvenOddHeight(boxas, sides, delh, op, factor, start) as Boxa
' boxaReconcileEvenOddHeight(BOXA *, l_int32, l_int32, l_int32, l_float32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The basic idea is to reconcile differences in box height
''' in the even and odd boxes, by moving the top and/or bottom
''' edges in the even and odd boxes.  Choose the edge or edges
''' to be moved, whether to adjust the boxes with the min
''' or the max of the medians, and the threshold on the median
''' difference between even and odd box heights for the operations
''' to take place.  The same threshold is also used to
''' determine if each individual box edge is to be adjusted.<para/>
''' 
''' (2) Boxes are conditionally reset with either the same top (y)
''' value or the same bottom value, or both.  The value is
''' determined by the greater or lesser of the medians of the
''' even and odd boxes, with the choice depending on the value
''' of %op, which selects for either min or max median height.
''' If the median difference between even and odd boxes is
''' greater than %dely, then any individual box edge that differs
''' from the selected median by more than %dely is set to
''' the selected median times a factor typically near 1.0.<para/>
''' 
''' (3) Note that if selecting for minimum height, you will choose
''' the largest y-value for the top and the smallest y-value for
''' the bottom of the box.<para/>
''' 
''' (4) Typical input might be the output of boxaSmoothSequence(),
''' where even and odd boxa have been independently regulated.<para/>
''' 
''' (5) Require at least 3 valid even boxes and 3 valid odd boxes.
''' Median values will be used for invalid boxes.<para/>
''' 
''' (6) If the median height is not representative of the boxes
''' in %boxas, this can make things much worse.  In that case,
''' ignore the value of %op, and force pairwise equality of the
''' heights, with pairwise maximal vertical extension.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaReconcileEvenOddHeight/*"/>
'''  <param name="boxas">[in] - containing at least 3 valid boxes in even and odd</param>
'''  <param name="sides">[in] - L_ADJUST_TOP, L_ADJUST_BOT, L_ADJUST_TOP_AND_BOT</param>
'''  <param name="delh">[in] - threshold on median height difference</param>
'''  <param name="op">[in] - L_ADJUST_CHOOSE_MIN, L_ADJUST_CHOOSE_MAX</param>
'''  <param name="factor">[in] - is greater  0.0, typically near 1.0</param>
'''  <param name="start">[in] - 0 if pairing (0,1), etc 1 if pairing (1,2), etc</param>
'''   <returns>boxad adjusted, or a copy of boxas on error</returns>
Public Shared Function boxaReconcileEvenOddHeight(
				 ByVal boxas as Boxa, 
				 ByVal sides as Enumerations.L_box_size_adjustment_location, 
				 ByVal delh as Integer, 
				 ByVal op as Enumerations.L_box_size_adjustment_location, 
				 ByVal factor as Single, 
				 ByVal start as Integer) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaReconcileEvenOddHeight( boxas.Pointer, sides, delh, op, factor, start)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1875, 1)
' boxaReconcilePairWidth(boxas, delw, op, factor, na) as Boxa
' boxaReconcilePairWidth(BOXA *, l_int32, l_int32, l_float32, NUMA *) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This reconciles differences in the width of adjacent boxes,
''' by moving one side of one of the boxes in each pair.
''' If the widths in the pair differ by more than some
''' threshold, move either the left side for even boxes or
''' the right side for odd boxes, depending on if we're choosing
''' the min or max.  If choosing min, the width of the max is
''' set to factor  (width of min).  If choosing max, the width
''' of the min is set to factor  (width of max).<para/>
''' 
''' (2) If %na exists, it is an indicator array corresponding to the
''' boxes in %boxas.  If %na != NULL, only boxes with an
''' indicator value of 1 are allowed to adjust otherwise,
''' all boxes can adjust.<para/>
''' 
''' (3) Typical input might be the output of boxaSmoothSequence(),
''' where even and odd boxa have been independently regulated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaReconcilePairWidth/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="delw">[in] - threshold on adjacent width difference</param>
'''  <param name="op">[in] - L_ADJUST_CHOOSE_MIN, L_ADJUST_CHOOSE_MAX</param>
'''  <param name="factor">[in] - is greater  0.0, typically near 1.0</param>
'''  <param name="na">[in][optional] - indicator array allowing change</param>
'''   <returns>boxad adjusted, or a copy of boxas on error</returns>
Public Shared Function boxaReconcilePairWidth(
				 ByVal boxas as Boxa, 
				 ByVal delw as Integer, 
				 ByVal op as Enumerations.L_box_size_adjustment_location, 
				 ByVal factor as Single, 
				 Optional ByVal na as Numa = Nothing) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim naPTR As IntPtr = IntPtr.Zero : If Not IsNothing(na) Then naPTR = na.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaReconcilePairWidth( boxas.Pointer, delw, op, factor, naPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (1980, 1)
' boxaPlotSides(boxa, plotname, pnal, pnat, pnar, pnab, ppixd) as Integer
' boxaPlotSides(BOXA *, const char *, NUMA **, NUMA **, NUMA **, NUMA **, PIX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This debugging function shows the progression of the four
''' sides in the boxa.  There must be at least 2 boxes.<para/>
''' 
''' (2) If there are invalid boxes (e.g., if only even or odd
''' indices have valid boxes), this will fill them with the
''' nearest valid box before plotting.<para/>
''' 
''' (3) The plotfiles are put in /tmp/lept/plots/, and are named
''' either with %plotname or, if NULL, a default name.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaPlotSides/*"/>
'''  <param name="boxa">[in] - source boxa</param>
'''  <param name="plotname">[in][optional] - , can be NULL</param>
'''  <param name="pnal">[out][optional] - na of left sides</param>
'''  <param name="pnat">[out][optional] - na of top sides</param>
'''  <param name="pnar">[out][optional] - na of right sides</param>
'''  <param name="pnab">[out][optional] - na of bottom sides</param>
'''  <param name="ppixd">[out][optional] - pix of the output plot</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaPlotSides(
				 ByVal boxa as Boxa, 
				 Optional ByVal plotname as String = Nothing, 
				<Out()> Optional ByRef pnal as Numa = Nothing, 
				<Out()> Optional ByRef pnat as Numa = Nothing, 
				<Out()> Optional ByRef pnar as Numa = Nothing, 
				<Out()> Optional ByRef pnab as Numa = Nothing, 
				<Out()> Optional ByRef ppixd as Pix = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pnalPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnal) Then pnalPTR = pnal.Pointer
Dim pnatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnat) Then pnatPTR = pnat.Pointer
Dim pnarPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnar) Then pnarPTR = pnar.Pointer
Dim pnabPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnab) Then pnabPTR = pnab.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaPlotSides( boxa.Pointer, plotname, pnalPTR, pnatPTR, pnarPTR, pnabPTR, ppixdPTR)
	if pnalPTR <> IntPtr.Zero then pnal = new Numa(pnalPTR)
	if pnatPTR <> IntPtr.Zero then pnat = new Numa(pnatPTR)
	if pnarPTR <> IntPtr.Zero then pnar = new Numa(pnarPTR)
	if pnabPTR <> IntPtr.Zero then pnab = new Numa(pnabPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\boxfunc4.c (2092, 1)
' boxaPlotSizes(boxa, plotname, pnaw, pnah, ppixd) as Integer
' boxaPlotSizes(BOXA *, const char *, NUMA **, NUMA **, PIX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This debugging function shows the progression of box width
''' and height in the boxa.  There must be at least 2 boxes.<para/>
''' 
''' (2) If there are invalid boxes (e.g., if only even or odd
''' indices have valid boxes), this will fill them with the
''' nearest valid box before plotting.<para/>
''' 
''' (3) The plotfiles are put in /tmp/lept/plots/, and are named
''' either with %plotname or, if NULL, a default name.  Make sure
''' that %plotname is a string with no whitespace characters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaPlotSizes/*"/>
'''  <param name="boxa">[in] - source boxa</param>
'''  <param name="plotname">[in][optional] - , can be NULL</param>
'''  <param name="pnaw">[out][optional] - na of widths</param>
'''  <param name="pnah">[out][optional] - na of heights</param>
'''  <param name="ppixd">[out][optional] - pix of the output plot</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaPlotSizes(
				 ByVal boxa as Boxa, 
				 Optional ByVal plotname as String = Nothing, 
				<Out()> Optional ByRef pnaw as Numa = Nothing, 
				<Out()> Optional ByRef pnah as Numa = Nothing, 
				<Out()> Optional ByRef ppixd as Pix = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pnawPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaw) Then pnawPTR = pnaw.Pointer
Dim pnahPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnah) Then pnahPTR = pnah.Pointer
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaPlotSizes( boxa.Pointer, plotname, pnawPTR, pnahPTR, ppixdPTR)
	if pnawPTR <> IntPtr.Zero then pnaw = new Numa(pnawPTR)
	if pnahPTR <> IntPtr.Zero then pnah = new Numa(pnahPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\boxfunc4.c (2180, 1)
' boxaFillSequence(boxas, useflag, debug) as Boxa
' boxaFillSequence(BOXA *, l_int32, l_int32) as BOXA *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This simple function replaces invalid boxes with a copy of
''' the nearest valid box, selected from either the entire
''' sequence (L_USE_ALL_BOXES) or from the boxes with the
''' same parity (L_USE_SAME_PARITY_BOXES).  It returns a new boxa.<para/>
''' 
''' (2) This is useful if you expect boxes in the sequence to
''' vary slowly with index.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaFillSequence/*"/>
'''  <param name="boxas">[in] - with at least 3 boxes</param>
'''  <param name="useflag">[in] - L_USE_ALL_BOXES, L_USE_SAME_PARITY_BOXES</param>
'''  <param name="debug">[in] - 1 for debug output</param>
'''   <returns>boxad filled boxa, or NULL on error</returns>
Public Shared Function boxaFillSequence(
				 ByVal boxas as Boxa, 
				 ByVal useflag as Enumerations.L_USE_BOXES, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaFillSequence( boxas.Pointer, useflag, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxfunc4.c (2322, 1)
' boxaSizeVariation(boxa, type, pdel_evenodd, prms_even, prms_odd, prms_all) as Integer
' boxaSizeVariation(BOXA *, l_int32, l_float32 *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives several measures of the smoothness of either the
''' width or height of a sequence of boxes.<para/>
''' 
''' (2) Statistics can be found separately for even and odd boxes.
''' Additionally, the average pair-wise difference between
''' adjacent even and odd boxes can be returned.<para/>
''' 
''' (3) The use case is bounding boxes for scanned page images,
''' where ideally the sizes should have little variance.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSizeVariation/*"/>
'''  <param name="boxa">[in] - at least 4 boxes</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT</param>
'''  <param name="pdel_evenodd">[out][optional] - average absolute value of (even - odd) size pairs</param>
'''  <param name="prms_even">[out][optional] - rms deviation of even boxes</param>
'''  <param name="prms_odd">[out][optional] - rms deviation of odd boxes</param>
'''  <param name="prms_all">[out][optional] - rms deviation of all boxes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSizeVariation(
				 ByVal boxa as Boxa, 
				 ByVal type as Enumerations.L_SELECT, 
				<Out()> Optional ByRef pdel_evenodd as Single = Nothing, 
				<Out()> Optional ByRef prms_even as Single = Nothing, 
				<Out()> Optional ByRef prms_odd as Single = Nothing, 
				<Out()> Optional ByRef prms_all as Single = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSizeVariation( boxa.Pointer, type, pdel_evenodd, prms_even, prms_odd, prms_all)

	Return _Result
End Function

' SRC\boxfunc4.c (2419, 1)
' boxaGetExtent(boxa, pw, ph, pbox) as Integer
' boxaGetExtent(BOXA *, l_int32 *, l_int32 *, BOX **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The returned w and h are the minimum size image
''' that would contain all boxes untranslated.<para/>
''' 
''' (2) If there are no valid boxes, returned w and h are 0 and
''' all parameters in the returned box are 0.  This
''' is not an error, because an empty boxa is valid and
''' boxaGetExtent() is required for serialization.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetExtent/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pbox">[out][optional] - minimum box containing all boxes in boxa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetExtent(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef pw as Integer = Nothing, 
				<Out()> Optional ByRef ph as Integer = Nothing, 
				<Out()> Optional ByRef pbox as Box = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetExtent( boxa.Pointer, pw, ph, pboxPTR)
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)

	Return _Result
End Function

' SRC\boxfunc4.c (2485, 1)
' boxaGetCoverage(boxa, wc, hc, exactflag, pfract) as Integer
' boxaGetCoverage(BOXA *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The boxes in boxa are clipped to the input rectangle.<para/>
''' 
''' (2)  When %exactflag == 1, we generate a 1 bpp pix of size
''' wc x hc, paint all the boxes black, and count the fg pixels.
''' This can take 1 msec on a large page with many boxes.
''' When %exactflag == 0, we clip each box to the wc x hc region
''' and sum the resulting areas.  This is faster.
''' The results are the same when none of the boxes overlap
''' within the wc x hc region.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetCoverage/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="wc">[in] - dimensions of overall clipping rectangle with UL corner at (0, 0 that is covered by the boxes.</param>
'''  <param name="hc">[in] - dimensions of overall clipping rectangle with UL corner at (0, 0 that is covered by the boxes.</param>
'''  <param name="exactflag">[in] - 1 for guaranteeing an exact result 0 for getting an exact result only if the boxes do not overlap</param>
'''  <param name="pfract">[out] - sum of box area as fraction of w  h</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetCoverage(
				 ByVal boxa as Boxa, 
				 ByVal wc as Integer, 
				 ByVal hc as Integer, 
				 ByVal exactflag as Integer, 
				<Out()> ByRef pfract as Single) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetCoverage( boxa.Pointer, wc, hc, exactflag, pfract)

	Return _Result
End Function

' SRC\boxfunc4.c (2544, 1)
' boxaaSizeRange(baa, pminw, pminh, pmaxw, pmaxh) as Integer
' boxaaSizeRange(BOXAA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaaSizeRange/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="pminw">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pminh">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pmaxw">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pmaxh">[out][optional] - range of dimensions of all boxes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaSizeRange(
				 ByVal baa as Boxaa, 
				<Out()> Optional ByRef pminw as Integer = Nothing, 
				<Out()> Optional ByRef pminh as Integer = Nothing, 
				<Out()> Optional ByRef pmaxw as Integer = Nothing, 
				<Out()> Optional ByRef pmaxh as Integer = Nothing) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaSizeRange( baa.Pointer, pminw, pminh, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\boxfunc4.c (2598, 1)
' boxaSizeRange(boxa, pminw, pminh, pmaxw, pmaxh) as Integer
' boxaSizeRange(BOXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaSizeRange/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pminw">[out][optional] - range of dimensions of box in the array</param>
'''  <param name="pminh">[out][optional] - range of dimensions of box in the array</param>
'''  <param name="pmaxw">[out][optional] - range of dimensions of box in the array</param>
'''  <param name="pmaxh">[out][optional] - range of dimensions of box in the array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaSizeRange(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef pminw as Integer = Nothing, 
				<Out()> Optional ByRef pminh as Integer = Nothing, 
				<Out()> Optional ByRef pmaxw as Integer = Nothing, 
				<Out()> Optional ByRef pmaxh as Integer = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaSizeRange( boxa.Pointer, pminw, pminh, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\boxfunc4.c (2649, 1)
' boxaLocationRange(boxa, pminx, pminy, pmaxx, pmaxy) as Integer
' boxaLocationRange(BOXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaLocationRange/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pminx">[out][optional] - range of UL corner positions</param>
'''  <param name="pminy">[out][optional] - range of UL corner positions</param>
'''  <param name="pmaxx">[out][optional] - range of UL corner positions</param>
'''  <param name="pmaxy">[out][optional] - range of UL corner positions</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaLocationRange(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef pminx as Integer = Nothing, 
				<Out()> Optional ByRef pminy as Integer = Nothing, 
				<Out()> Optional ByRef pmaxx as Integer = Nothing, 
				<Out()> Optional ByRef pmaxy as Integer = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaLocationRange( boxa.Pointer, pminx, pminy, pmaxx, pmaxy)

	Return _Result
End Function

' SRC\boxfunc4.c (2700, 1)
' boxaGetSizes(boxa, pnaw, pnah) as Integer
' boxaGetSizes(BOXA *, NUMA **, NUMA **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetSizes/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pnaw">[out][optional] - widths and heights of valid boxes</param>
'''  <param name="pnah">[out][optional] - widths and heights of valid boxes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetSizes(
				 ByVal boxa as Boxa, 
				<Out()> Optional ByRef pnaw as Numa = Nothing, 
				<Out()> Optional ByRef pnah as Numa = Nothing) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pnawPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaw) Then pnawPTR = pnaw.Pointer
Dim pnahPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnah) Then pnahPTR = pnah.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetSizes( boxa.Pointer, pnawPTR, pnahPTR)
	if pnawPTR <> IntPtr.Zero then pnaw = new Numa(pnawPTR)
	if pnahPTR <> IntPtr.Zero then pnah = new Numa(pnahPTR)

	Return _Result
End Function

' SRC\boxfunc4.c (2746, 1)
' boxaGetArea(boxa, parea) as Integer
' boxaGetArea(BOXA *, l_int32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Measures the total area of the boxes, without regard to overlaps.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaGetArea/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="parea">[out] - total area of all boxes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetArea(
				 ByVal boxa as Boxa, 
				<Out()> ByRef parea as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetArea( boxa.Pointer, parea)

	Return _Result
End Function

' SRC\boxfunc4.c (2794, 1)
' boxaDisplayTiled(boxas, pixa, maxwidth, linewidth, scalefactor, background, spacing, border) as Pix
' boxaDisplayTiled(BOXA *, PIXA *, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Displays each box separately in a tiled 32 bpp image.<para/>
''' 
''' (2) If pixa is defined, it must have the same count as the boxa,
''' and it will be a background over with each box is rendered.
''' If pixa is not defined, the boxes will be rendered over
''' blank images of identical size.<para/>
''' 
''' (3) See pixaDisplayTiledInRows() for other parameters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/boxaDisplayTiled/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="pixa">[in][optional] - background for each box</param>
'''  <param name="maxwidth">[in] - of output image</param>
'''  <param name="linewidth">[in] - width of box outlines, before scaling</param>
'''  <param name="scalefactor">[in] - applied to every box use 1.0 for no scaling</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''   <returns>pixd of tiled images of boxes, or NULL on error</returns>
Public Shared Function boxaDisplayTiled(
				 ByVal boxas as Boxa, 
				 ByVal pixa as Pixa, 
				 ByVal maxwidth as Integer, 
				 ByVal linewidth as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pix

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim pixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixa) Then pixaPTR = pixa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaDisplayTiled( boxas.Pointer, pixaPTR, maxwidth, linewidth, scalefactor, background, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
