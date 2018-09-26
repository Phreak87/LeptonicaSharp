Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\pixafunc1.c (212, 1)
' pixSelectBySize()
' pixSelectBySize(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the size of the
''' components that are kept.
''' (2) If unchanged, returns a copy of pixs.  Otherwise,
''' returns a new pix with the filtered components.
''' (3) If the selection type is L_SELECT_WIDTH, the input
''' height is ignored, and v.v.
''' (4) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="width">[in] - threshold dimensions</param>
'''  <param name="height">[in] - threshold dimensions</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 otherwise</param>
'''   <returns>filtered pixd, or NULL on error</returns>
Public Shared Function pixSelectBySize(
				ByVal pixs as Pix, 
				ByVal width as Integer, 
				ByVal height as Integer, 
				ByVal connectivity as Integer, 
				ByVal type as Enumerations.L_SELECT, 
				ByVal relation as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectBySize( pixs.Pointer, width, height, connectivity, type, relation, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (299, 1)
' pixaSelectBySize()
' pixaSelectBySize(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the size of the
''' components that are kept.
''' (2) Uses pix and box clones in the new pixa.
''' (3) If the selection type is L_SELECT_WIDTH, the input
''' height is ignored, and v.v.
''' (4) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="width">[in] - threshold dimensions</param>
'''  <param name="height">[in] - threshold dimensions</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 otherwise</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectBySize(
				ByVal pixas as Pixa, 
				ByVal width as Integer, 
				ByVal height as Integer, 
				ByVal type as Enumerations.L_SELECT, 
				ByVal relation as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectBySize( pixas.Pointer, width, height, type, relation, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (355, 1)
' pixaMakeSizeIndicator()
' pixaMakeSizeIndicator(PIXA *, l_int32, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the size of the
''' components that are kept.
''' (2) If the selection type is L_SELECT_WIDTH, the input
''' height is ignored, and v.v.
''' (3) To keep small components, use relation = L_SELECT_IF_LT or
''' L_SELECT_IF_LTE.
''' To keep large components, use relation = L_SELECT_IF_GT or
''' L_SELECT_IF_GTE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="width">[in] - threshold dimensions</param>
'''  <param name="height">[in] - threshold dimensions</param>
'''  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>na indicator array, or NULL on error</returns>
Public Shared Function pixaMakeSizeIndicator(
				ByVal pixa as Pixa, 
				ByVal width as Integer, 
				ByVal height as Integer, 
				ByVal type as Enumerations.L_SELECT, 
				ByVal relation as Enumerations.L_SELECT_IF) as Numa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaMakeSizeIndicator( pixa.Pointer, width, height, type, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\pixafunc1.c (446, 1)
' pixSelectByPerimToAreaRatio()
' pixSelectByPerimToAreaRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the size of the
''' components that are kept.
''' (2) If unchanged, returns a copy of pixs.  Otherwise,
''' returns a new pix with the filtered components.
''' (3) This filters "thick" components, where a thick component
''' is defined to have a ratio of boundary to interior pixels
''' that is smaller than a given threshold value.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save the thicker
''' components, and L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixSelectByPerimToAreaRatio(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal connectivity as Integer, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectByPerimToAreaRatio( pixs.Pointer, thresh, connectivity, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (520, 1)
' pixaSelectByPerimToAreaRatio()
' pixaSelectByPerimToAreaRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) See pixSelectByPerimToAreaRatio().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectByPerimToAreaRatio(
				ByVal pixas as Pixa, 
				ByVal thresh as Single, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectByPerimToAreaRatio( pixas.Pointer, thresh, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (577, 1)
' pixSelectByPerimSizeRatio()
' pixSelectByPerimSizeRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the size of the
''' components that are kept.
''' (2) If unchanged, returns a copy of pixs.  Otherwise,
''' returns a new pix with the filtered components.
''' (3) This filters components with smooth vs. dendritic shape, using
''' the ratio of the fg boundary pixels to the circumference of
''' the bounding box, and comparing it to a threshold value.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save the smooth
''' boundary components, and L_SELECT_IF_GT or L_SELECT_IF_GTE
''' to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixSelectByPerimSizeRatio(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal connectivity as Integer, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectByPerimSizeRatio( pixs.Pointer, thresh, connectivity, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (651, 1)
' pixaSelectByPerimSizeRatio()
' pixaSelectByPerimSizeRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) See pixSelectByPerimSizeRatio().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="thresh">[in] - threshold ratio of fg boundary to b.b. circumference</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectByPerimSizeRatio(
				ByVal pixas as Pixa, 
				ByVal thresh as Single, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectByPerimSizeRatio( pixas.Pointer, thresh, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (707, 1)
' pixSelectByAreaFraction()
' pixSelectByAreaFraction(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the amount of foreground
''' coverage of the components that are kept.
''' (2) If unchanged, returns a copy of pixs.  Otherwise,
''' returns a new pix with the filtered components.
''' (3) This filters components based on the fraction of fg pixels
''' of the component in its bounding box.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
''' with less than the threshold fraction of foreground, and
''' L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold ratio of fg pixels to (w  h)</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixSelectByAreaFraction(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal connectivity as Integer, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectByAreaFraction( pixs.Pointer, thresh, connectivity, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (785, 1)
' pixaSelectByAreaFraction()
' pixaSelectByAreaFraction(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) This filters components based on the fraction of fg pixels
''' of the component in its bounding box.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
''' with less than the threshold fraction of foreground, and
''' L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="thresh">[in] - threshold ratio of fg pixels to (w  h)</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectByAreaFraction(
				ByVal pixas as Pixa, 
				ByVal thresh as Single, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectByAreaFraction( pixas.Pointer, thresh, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (840, 1)
' pixSelectByWidthHeightRatio()
' pixSelectByWidthHeightRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The args specify constraints on the width-to-height ratio
''' for components that are kept.
''' (2) If unchanged, returns a copy of pixs.  Otherwise,
''' returns a new pix with the filtered components.
''' (3) This filters components based on the width-to-height ratios.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
''' with less than the threshold ratio, and
''' L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - threshold ratio of width/height</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixSelectByWidthHeightRatio(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal connectivity as Integer, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectByWidthHeightRatio( pixs.Pointer, thresh, connectivity, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (918, 1)
' pixaSelectByWidthHeightRatio()
' pixaSelectByWidthHeightRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) This filters components based on the width-to-height ratio
''' of each pix.
''' (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
''' with less than the threshold ratio, and
''' L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="thresh">[in] - threshold ratio of width/height</param>
'''  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectByWidthHeightRatio(
				ByVal pixas as Pixa, 
				ByVal thresh as Single, 
				ByVal type as Enumerations.L_SELECT_IF, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectByWidthHeightRatio( pixas.Pointer, thresh, type, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (968, 1)
' pixaSelectByNumConnComp()
' pixaSelectByNumConnComp(PIXA *, l_int32, l_int32, l_int32, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) This filters by the number of connected components in
''' a given range.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="nmin">[in] - minimum number of components</param>
'''  <param name="nmax">[in] - maximum number of components</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectByNumConnComp(
				ByVal pixas as Pixa, 
				ByVal nmin as Integer, 
				ByVal nmax as Integer, 
				ByVal connectivity as Integer, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectByNumConnComp( pixas.Pointer, nmin, nmax, connectivity, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1027, 1)
' pixaSelectWithIndicator()
' pixaSelectWithIndicator(PIXA *, NUMA *, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa clone if no components are removed.
''' (2) Uses pix and box clones in the new pixa.
''' (3) The indicator numa has values 0 (ignore) and 1 (accept).
''' (4) If the source boxa is not fully populated, it is left
''' empty in the dest pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="na">[in] - indicator numa</param>
'''  <param name="pchanged">[out][optional] - 1 if changed; 0 if clone returned</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectWithIndicator(
				ByVal pixas as Pixa, 
				ByVal na as Numa, 
				Optional ByRef pchanged as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectWithIndicator( pixas.Pointer, na.Pointer, pchanged)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1087, 1)
' pixRemoveWithIndicator()
' pixRemoveWithIndicator(PIX *, PIXA *, NUMA *) as l_ok
'''  <summary>
''' Notes
''' (1) This complements pixAddWithIndicator().   Here, the selected
''' components are set subtracted from pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp pix from which components are removed; in-place</param>
'''  <param name="pixa">[in] - of connected components in pixs</param>
'''  <param name="na">[in] - numa indicator remove components corresponding to 1s</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRemoveWithIndicator(
				ByVal pixs as Pix, 
				ByVal pixa as Pixa, 
				ByVal na as Numa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRemoveWithIndicator( pixs.Pointer, pixa.Pointer, na.Pointer)

	Return _Result
End Function

' SRC\pixafunc1.c (1140, 1)
' pixAddWithIndicator()
' pixAddWithIndicator(PIX *, PIXA *, NUMA *) as l_ok
'''  <summary>
''' Notes
''' (1) This complements pixRemoveWithIndicator().   Here, the selected
''' components are added to pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp pix from which components are added; in-place</param>
'''  <param name="pixa">[in] - of connected components, some of which will be put into pixs</param>
'''  <param name="na">[in] - numa indicator add components corresponding to 1s</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAddWithIndicator(
				ByVal pixs as Pix, 
				ByVal pixa as Pixa, 
				ByVal na as Numa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAddWithIndicator( pixs.Pointer, pixa.Pointer, na.Pointer)

	Return _Result
End Function

' SRC\pixafunc1.c (1193, 1)
' pixaSelectWithString()
' pixaSelectWithString(PIXA *, const char *, l_int32 *) as PIXA *
'''  <summary>
''' Notes
''' (1) Returns a pixa with copies of selected pix.
''' (2) Associated boxes are also copied, if fully populated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="str">[in] - string of indices into pixa, giving the pix to be selected</param>
'''  <param name="perror">[out][optional] - 1 if any indices are invalid; 0 if all indices are valid</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectWithString(
				ByVal pixas as Pixa, 
				ByVal str as String, 
				Optional ByRef perror as Integer = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectWithString( pixas.Pointer, str, perror)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1264, 1)
' pixaRenderComponent()
' pixaRenderComponent(PIX *, PIXA *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixs is null, this generates an empty pix of a size determined
''' by union of the component bounding boxes, and including the origin.
''' (2) The selected component is blitted into pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in][optional] - 1 bpp pix</param>
'''  <param name="pixa">[in] - of 1 bpp connected components, one of which will be rendered in pixs, with its origin determined by the associated box.</param>
'''  <param name="index">[in] - of component to be rendered</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixaRenderComponent(
				ByVal pixa as Pixa, 
				ByVal index as Integer, 
				Optional ByVal pixs as Pix = Nothing) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRenderComponent( pixsPTR, pixa.Pointer, index)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc1.c (1334, 1)
' pixaSort()
' pixaSort(PIXA *, l_int32, l_int32, NUMA **, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) This sorts based on the data in the boxa.  If the boxa
''' count is not the same as the pixa count, this returns an error.
''' (2) If the boxa is empty, it makes one corresponding to the
''' dimensions of each pix, which allows meaningful sorting on
''' all types except x and y.
''' (3) The copyflag refers to the pix and box copies that are
''' inserted into the sorted pixa.  These are either L_COPY
''' or L_CLONE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MIN_DIMENSION, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA, L_SORT_BY_ASPECT_RATIO</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>pixad sorted version of pixas, or NULL on error</returns>
Public Shared Function pixaSort(
				ByVal pixas as Pixa, 
				ByVal sorttype as Enumerations.L_SORT_BY, 
				ByVal sortorder as Enumerations.L_SORT_CREASING, 
				ByVal copyflag as Enumerations.L_access_storage, 
				Optional ByRef pnaindex as Numa = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSort( pixas.Pointer, sorttype, sortorder, pnaindexPTR, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1474, 1)
' pixaBinSort()
' pixaBinSort(PIXA *, l_int32, l_int32, NUMA **, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) This sorts based on the data in the boxa.  If the boxa
''' count is not the same as the pixa count, this returns an error.
''' (2) The copyflag refers to the pix and box copies that are
''' inserted into the sorted pixa.  These are either L_COPY
''' or L_CLONE.
''' (3) For a large number of boxes (say, greater than 1000), this
''' O(n) binsort is much faster than the O(nlogn) shellsort.
''' For 5000 components, this is over 20x faster than boxaSort().
''' (4) Consequently, pixaSort() calls this function if it will
''' likely go much faster.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_PERIMETER</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>pixad sorted version of pixas, or NULL on error</returns>
Public Shared Function pixaBinSort(
				ByVal pixas as Pixa, 
				ByVal sorttype as Enumerations.L_SORT_BY, 
				ByVal sortorder as Enumerations.L_SORT_CREASING, 
				ByVal copyflag as Enumerations.L_access_storage, 
				Optional ByRef pnaindex as Numa = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaBinSort( pixas.Pointer, sorttype, sortorder, pnaindexPTR, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1562, 1)
' pixaSortByIndex()
' pixaSortByIndex(PIXA *, NUMA *, l_int32) as PIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="naindex">[in] - na that maps from the new pixa to the input pixa</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>pixad sorted, or NULL on error</returns>
Public Shared Function pixaSortByIndex(
				ByVal pixas as Pixa, 
				ByVal naindex as Numa, 
				ByVal copyflag as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (naindex) then Throw New ArgumentNullException  ("naindex cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSortByIndex( pixas.Pointer, naindex.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1603, 1)
' pixaSort2dByIndex()
' pixaSort2dByIndex(PIXA *, NUMAA *, l_int32) as PIXAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="naa">[in] - numaa that maps from the new pixaa to the input pixas</param>
'''  <param name="copyflag">[in] - L_CLONE or L_COPY</param>
'''   <returns>paa sorted, or NULL on error</returns>
Public Shared Function pixaSort2dByIndex(
				ByVal pixas as Pixa, 
				ByVal naa as Numaa, 
				ByVal copyflag as Enumerations.L_access_storage) as Pixaa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSort2dByIndex( pixas.Pointer, naa.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixafunc1.c (1668, 1)
' pixaSelectRange()
' pixaSelectRange(PIXA *, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) The copyflag specifies what we do with each pix from pixas.
''' Specifically, L_CLONE inserts a clone into pixad of each
''' selected pix from pixas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="first">[in] - use 0 to select from the beginning</param>
'''  <param name="last">[in] - use 0 to select to the end</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaSelectRange(
				ByVal pixas as Pixa, 
				ByVal first as Integer, 
				ByVal last as Integer, 
				ByVal copyflag as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSelectRange( pixas.Pointer, first, last, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1718, 1)
' pixaaSelectRange()
' pixaaSelectRange(PIXAA *, l_int32, l_int32, l_int32) as PIXAA *
'''  <summary>
''' Notes
''' (1) The copyflag specifies what we do with each pixa from paas.
''' Specifically, L_CLONE inserts a clone into paad of each
''' selected pixa from paas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paas">[in] - </param>
'''  <param name="first">[in] - use 0 to select from the beginning</param>
'''  <param name="last">[in] - use 0 to select to the end</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>paad, or NULL on error</returns>
Public Shared Function pixaaSelectRange(
				ByVal paas as Pixaa, 
				ByVal first as Integer, 
				ByVal last as Integer, 
				ByVal copyflag as Enumerations.L_access_storage) as Pixaa

	If IsNothing (paas) then Throw New ArgumentNullException  ("paas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaSelectRange( paas.Pointer, first, last, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixafunc1.c (1774, 1)
' pixaaScaleToSize()
' pixaaScaleToSize(PIXAA *, l_int32, l_int32) as PIXAA *
'''  <summary>
''' Notes
''' (1) This guarantees that each output scaled image has the
''' dimension(s) you specify.
''' ~ To specify the width with isotropic scaling, set %hd = 0.
''' ~ To specify the height with isotropic scaling, set %wd = 0.
''' ~ If both %wd and %hd are specified, the image is scaled
''' (in general, anisotropically) to that size.
''' ~ It is an error to set both %wd and %hd to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paas">[in] - </param>
'''  <param name="wd">[in] - target width; use 0 if using height as target</param>
'''  <param name="hd">[in] - target height; use 0 if using width as target</param>
'''   <returns>paad, or NULL on error</returns>
Public Shared Function pixaaScaleToSize(
				ByVal paas as Pixaa, 
				ByVal wd as Integer, 
				ByVal hd as Integer) as Pixaa

	If IsNothing (paas) then Throw New ArgumentNullException  ("paas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaScaleToSize( paas.Pointer, wd, hd)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixafunc1.c (1823, 1)
' pixaaScaleToSizeVar()
' pixaaScaleToSizeVar(PIXAA *, NUMA *, NUMA *) as PIXAA *
'''  <summary>
''' Notes
''' (1) This guarantees that the scaled images in each pixa have the
''' dimension(s) you specify in the numas.
''' ~ To specify the width with isotropic scaling, set %nahd = NULL.
''' ~ To specify the height with isotropic scaling, set %nawd = NULL.
''' ~ If both %nawd and %nahd are specified, the image is scaled
''' (in general, anisotropically) to that size.
''' ~ It is an error to set both %nawd and %nahd to NULL.
''' (2) If either nawd and/or nahd is defined, it must have the same
''' count as the number of pixa in paas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paas">[in] - </param>
'''  <param name="nawd">[in][optional] - target widths; use NULL if using height</param>
'''  <param name="nahd">[in][optional] - target height; use NULL if using width</param>
'''   <returns>paad, or NULL on error</returns>
Public Shared Function pixaaScaleToSizeVar(
				ByVal paas as Pixaa, 
				Optional ByVal nawd as Numa = Nothing, 
				Optional ByVal nahd as Numa = Nothing) as Pixaa

	If IsNothing (paas) then Throw New ArgumentNullException  ("paas cannot be Nothing")

	Dim nawdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nawd) Then nawdPTR = nawd.Pointer
	Dim nahdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nahd) Then nahdPTR = nahd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaScaleToSizeVar( paas.Pointer, nawdPTR, nahdPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixafunc1.c (1871, 1)
' pixaScaleToSize()
' pixaScaleToSize(PIXA *, l_int32, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) See pixaaScaleToSize()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="wd">[in] - target width; use 0 if using height as target</param>
'''  <param name="hd">[in] - target height; use 0 if using width as target</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaScaleToSize(
				ByVal pixas as Pixa, 
				ByVal wd as Integer, 
				ByVal hd as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaScaleToSize( pixas.Pointer, wd, hd)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1916, 1)
' pixaScaleToSizeRel()
' pixaScaleToSizeRel(PIXA *, l_int32, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) If a requested change in a pix is not possible because
''' either the requested width or height is LT= 0, issue a
''' warning and return a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="delw">[in] - change in width, in pixels; 0 means no change</param>
'''  <param name="delh">[in] - change in height, in pixels; 0 means no change return  pixad, or NULL on error</param>
'''   <returns></returns>
Public Shared Function pixaScaleToSizeRel(
				ByVal pixas as Pixa, 
				ByVal delw as Integer, 
				ByVal delh as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaScaleToSizeRel( pixas.Pointer, delw, delh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (1960, 1)
' pixaScale()
' pixaScale(PIXA *, l_float32, l_float32) as PIXA *
'''  <summary>
''' Notes
''' (1) If pixas has a full boxes, it is scaled as well.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaScale(
				ByVal pixas as Pixa, 
				Optional ByVal scalex as Single = 1, 
				Optional ByVal scaley as Single = 1) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaScale( pixas.Pointer, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2011, 1)
' pixaScaleBySampling()
' pixaScaleBySampling(PIXA *, l_float32, l_float32) as PIXA *
'''  <summary>
''' Notes
''' (1) If pixas has a full boxes, it is scaled as well.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaScaleBySampling(
				ByVal pixas as Pixa, 
				Optional ByVal scalex as Single = 1, 
				Optional ByVal scaley as Single = 1) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaScaleBySampling( pixas.Pointer, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2076, 1)
' pixaRotate()
' pixaRotate(PIXA *, l_float32, l_int32, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) Each pix is rotated about its center.  See pixRotate() for details.
''' (2) The boxa array is copied.  Why is it not rotated?
''' If a boxa exists, the array of boxes is in 1-to-1
''' correspondence with the array of pix, and each box typically
''' represents the location of the pix relative to an image from
''' which it has been extracted.  Like the pix, we could rotate
''' each box around its center, and then generate a box that
''' contains all four corners, as is done in boxaRotate(), but
''' this seems unnecessary.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
'''  <param name="angle">[in] - rotation angle in radians; clockwise is positive</param>
'''  <param name="type">[in] - L_ROTATE_AREA_MAP, L_ROTATE_SHEAR, L_ROTATE_SAMPLING</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''  <param name="width">[in] - original width; use 0 to avoid embedding</param>
'''  <param name="height">[in] - original height; use 0 to avoid embedding</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaRotate(
				ByVal pixas as Pixa, 
				ByVal angle as Single, 
				ByVal type as Enumerations.L_ROTATE, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				ByVal width as Integer, 
				ByVal height as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRotate( pixas.Pointer, angle, type, incolor, width, height)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2134, 1)
' pixaRotateOrth()
' pixaRotateOrth(PIXA *, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) Rotates each pix in the pixa.  Rotates and saves the boxes in
''' the boxa if the boxa is full.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg; all rotations are clockwise</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaRotateOrth(
				ByVal pixas as Pixa, 
				ByVal rotation as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRotateOrth( pixas.Pointer, rotation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2186, 1)
' pixaTranslate()
' pixaTranslate(PIXA *, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="hshift">[in] - horizontal shift; hshift GT 0 is to right</param>
'''  <param name="vshift">[in] - vertical shift; vshift GT 0 is down</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixad, or NULL on error.</returns>
Public Shared Function pixaTranslate(
				ByVal pixas as Pixa, 
				ByVal hshift as Integer, 
				ByVal vshift as Integer, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaTranslate( pixas.Pointer, hshift, vshift, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2260, 1)
' pixaAddBorderGeneral()
' pixaAddBorderGeneral(PIXA *, PIXA *, l_int32, l_int32, l_int32, l_int32, l_uint32) as PIXA *
'''  <summary>
''' Notes
''' (1) For binary images
''' white  val = 0
''' black  val = 1
''' For grayscale images
''' white  val = 2  d - 1
''' black  val = 0
''' For rgb color images
''' white  val = 0xffffff00
''' black  val = 0
''' For colormapped images, use 'index' found this way
''' white pixcmapGetRankIntensity(cmap, 1.0, index);
''' black pixcmapGetRankIntensity(cmap, 0.0, index);
''' (2) For in-place replacement of each pix with a bordered version,
''' use %pixad = %pixas.  To make a new pixa, use %pixad = NULL.
''' (3) In both cases, the boxa has sides adjusted as if it were
''' expanded by the border.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixad">[in]can be null - or equal to pixas</param>
'''  <param name="pixas">[in] - containing pix of all depths; colormap ok</param>
'''  <param name="left">[in] - number of pixels added</param>
'''  <param name="right">[in] - number of pixels added</param>
'''  <param name="top">[in] - number of pixels added</param>
'''  <param name="bot">[in] - number of pixels added</param>
'''  <param name="val">[in] - value of added border pixels</param>
'''   <returns>pixad with border added to each pix, including on error</returns>
Public Shared Function pixaAddBorderGeneral(
				ByVal pixas as Pixa, 
				ByVal left as Integer, 
				ByVal right as Integer, 
				ByVal top as Integer, 
				ByVal bot as Integer, 
				ByVal val as UInteger, 
				Optional ByVal pixad as Pixa = Nothing) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim pixadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixad) Then pixadPTR = pixad.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaAddBorderGeneral( pixadPTR, pixas.Pointer, left, right, top, bot, val)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2331, 1)
' pixaaFlattenToPixa()
' pixaaFlattenToPixa(PIXAA *, NUMA **, l_int32) as PIXA *
'''  <summary>
''' Notes
''' (1) This 'flattens' the pixaa to a pixa, taking the pix in
''' order in the first pixa, then the second, etc.
''' (2) If naindex is defined, we generate a Numa that gives, for
''' each pix in the pixaa, the index of the pixa to which it belongs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="pnaindex">[out][optional] - the pixa index in the pixaa</param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaaFlattenToPixa(
				ByVal paa as Pixaa, 
				ByVal copyflag as Enumerations.L_access_storage, 
				Optional ByRef pnaindex as Numa = Nothing) as Pixa

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaFlattenToPixa( paa.Pointer, pnaindexPTR, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2386, 1)
' pixaaSizeRange()
' pixaaSizeRange(PIXAA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="pminw">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pminh">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pmaxw">[out][optional] - range of dimensions of all boxes</param>
'''  <param name="pmaxh">[out][optional] - range of dimensions of all boxes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaSizeRange(
				ByVal paa as Pixaa, 
				Optional ByRef pminw as Integer = Nothing, 
				Optional ByRef pminh as Integer = Nothing, 
				Optional ByRef pmaxw as Integer = Nothing, 
				Optional ByRef pmaxh as Integer = Nothing) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaSizeRange( paa.Pointer, pminw, pminh, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\pixafunc1.c (2440, 1)
' pixaSizeRange()
' pixaSizeRange(PIXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pminw">[out][optional] - range of dimensions of pix in the array</param>
'''  <param name="pminh">[out][optional] - range of dimensions of pix in the array</param>
'''  <param name="pmaxw">[out][optional] - range of dimensions of pix in the array</param>
'''  <param name="pmaxh">[out][optional] - range of dimensions of pix in the array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSizeRange(
				ByVal pixa as Pixa, 
				Optional ByRef pminw as Integer = Nothing, 
				Optional ByRef pminh as Integer = Nothing, 
				Optional ByRef pmaxw as Integer = Nothing, 
				Optional ByRef pmaxh as Integer = Nothing) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSizeRange( pixa.Pointer, pminw, pminh, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\pixafunc1.c (2510, 1)
' pixaClipToPix()
' pixaClipToPix(PIXA *, PIX *) as PIXA *
'''  <summary>
''' Notes
''' (1) This is intended for use in situations where pixas
''' was originally generated from the input pixs.
''' (2) Returns a pixad where each pix in pixas is ANDed
''' with its associated region of the input pixs.  This
''' region is specified by the the box that is associated
''' with the pix.
''' (3) In a typical application of this function, pixas has
''' a set of region masks, so this generates a pixa of
''' the parts of pixs that correspond to each region
''' mask component, along with the bounding box for
''' the region.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaClipToPix(
				ByVal pixas as Pixa, 
				ByVal pixs as Pix) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaClipToPix( pixas.Pointer, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2559, 1)
' pixaClipToForeground()
' pixaClipToForeground(PIXA *, PIXA **, BOXA **) as l_ok
'''  <summary>
''' Notes
''' (1) At least one of [pixd, boxa] must be specified.
''' (2) Any pix with no fg pixels is skipped.
''' (3) See pixClipToForeground().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="ppixad">[out][optional] - pixa of clipped pix returned</param>
'''  <param name="pboxa">[out][optional] - clipping boxes returned</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaClipToForeground(
				ByVal pixas as Pixa, 
				Optional ByRef ppixad as Pixa = Nothing, 
				Optional ByRef pboxa as Boxa = Nothing) as Integer

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim ppixadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixad) Then ppixadPTR = ppixad.Pointer
Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaClipToForeground( pixas.Pointer, ppixadPTR, pboxaPTR)
	if ppixadPTR <> IntPtr.Zero then ppixad = new Pixa(ppixadPTR)
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return _Result
End Function

' SRC\pixafunc1.c (2605, 1)
' pixaGetRenderingDepth()
' pixaGetRenderingDepth(PIXA *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pdepth">[out] - depth required to render if all colormaps are removed</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixaGetRenderingDepth(
				ByVal pixa as Pixa, 
				ByRef pdepth as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetRenderingDepth( pixa.Pointer, pdepth)

	Return _Result
End Function

' SRC\pixafunc1.c (2642, 1)
' pixaHasColor()
' pixaHasColor(PIXA *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="phascolor">[out] - 1 if any pix is rgb or has a colormap with color; 0 otherwise</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixaHasColor(
				ByVal pixa as Pixa, 
				ByRef phascolor as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaHasColor( pixa.Pointer, phascolor)

	Return _Result
End Function

' SRC\pixafunc1.c (2683, 1)
' pixaAnyColormaps()
' pixaAnyColormaps(PIXA *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="phascmap">[out] - 1 if any pix has a colormap; 0 otherwise</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixaAnyColormaps(
				ByVal pixa as Pixa, 
				ByRef phascmap as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaAnyColormaps( pixa.Pointer, phascmap)

	Return _Result
End Function

' SRC\pixafunc1.c (2722, 1)
' pixaGetDepthInfo()
' pixaGetDepthInfo(PIXA *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pmaxdepth">[out][optional] - max pixel depth of pix in pixa</param>
'''  <param name="psame">[out][optional] - true if all depths are equal</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixaGetDepthInfo(
				ByVal pixa as Pixa, 
				Optional ByRef pmaxdepth as Integer = Nothing, 
				Optional ByRef psame as Integer = Nothing) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetDepthInfo( pixa.Pointer, pmaxdepth, psame)

	Return _Result
End Function

' SRC\pixafunc1.c (2771, 1)
' pixaConvertToSameDepth()
' pixaConvertToSameDepth(PIXA *) as PIXA *
'''  <summary>
''' Notes
''' (1) If any pix has a colormap, they are all converted to rgb.
''' Otherwise, they are all converted to the maximum depth of
''' all the pix.
''' (2) This can be used to allow lossless rendering onto a single pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaConvertToSameDepth(
				ByVal pixas as Pixa) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertToSameDepth( pixas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc1.c (2851, 1)
' pixaEqual()
' pixaEqual(PIXA *, PIXA *, l_int32, NUMA **, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The two pixa are the "same" if they contain the same
''' boxa and the same ordered set of pix.  However, if they
''' have boxa, the pix in each pixa can differ in ordering
''' by an amount given by the parameter %maxdist.  If they
''' don't have a boxa, the %maxdist parameter is ignored,
''' and the ordering must be identical.
''' (2) This applies only to boxa geometry, pixels and ordering;
''' other fields in the pix are ignored.
''' (3) naindex[i] gives the position of the box in pixa2 that
''' corresponds to box i in pixa1.  It is only returned if the
''' pixa have boxa and the boxa are equal.
''' (4) In situations where the ordering is very different, so that
''' a large %maxdist is required for "equality", this should be
''' implemented with a hash function for efficiency.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa1">[in] - </param>
'''  <param name="pixa2">[in] - </param>
'''  <param name="maxdist">[in] - </param>
'''  <param name="pnaindex">[out][optional] - index array of correspondences</param>
'''  <param name="psame">[out] - 1 if equal; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaEqual(
				ByVal pixa1 as Pixa, 
				ByVal pixa2 as Pixa, 
				ByVal maxdist as Integer, 
				ByRef psame as Integer, 
				Optional ByRef pnaindex as Numa = Nothing) as Integer

	If IsNothing (pixa1) then Throw New ArgumentNullException  ("pixa1 cannot be Nothing")
	If IsNothing (pixa2) then Throw New ArgumentNullException  ("pixa2 cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaEqual( pixa1.Pointer, pixa2.Pointer, maxdist, pnaindexPTR, psame)
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return _Result
End Function

' SRC\pixafunc1.c (2936, 1)
' pixaSetFullSizeBoxa()
' pixaSetFullSizeBoxa(PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Replaces the existing boxa.  Each box gives the dimensions
''' of the corresponding pix.  This is needed for functions
''' like pixaSort() that sort based on the boxes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSetFullSizeBoxa(
				ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSetFullSizeBoxa( pixa.Pointer)

	Return _Result
End Function

End Class
