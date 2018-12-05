using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixafunc1.c (212, 1)
// pixSelectBySize(pixs, width, height, connectivity, type, relation, pchanged) as Pix
// pixSelectBySize(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) The args specify constraints on the size of the
/// components that are kept.<para/>
/// 
/// (2) If unchanged, returns a copy of pixs.  Otherwise,
/// returns a new pix with the filtered components.<para/>
/// 
/// (3) If the selection type is L_SELECT_WIDTH, the input
/// height is ignored, and v.v.<para/>
/// 
/// (4) To keep small components, use relation = L_SELECT_IF_LT or
/// L_SELECT_IF_LTE.
/// To keep large components, use relation = L_SELECT_IF_GT or
/// L_SELECT_IF_GTE.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectBySize/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="width">[in] - threshold dimensions</param>
///  <param name="height">[in] - threshold dimensions</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
///  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 otherwise</param>
///   <returns>filtered pixd, or NULL on error</returns>
public static Pix pixSelectBySize(
				 Pix pixs, 
				 int width, 
				 int height, 
				 int connectivity, 
				 int type, 
				 int relation, 
				out int pchanged){

	IntPtr _Result = Natives.pixSelectBySize(pixs.Pointer,   width,   height,   connectivity,   type,   relation, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (299, 1)
// pixaSelectBySize(pixas, width, height, type, relation, pchanged) as Pixa
// pixaSelectBySize(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) The args specify constraints on the size of the
/// components that are kept.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) If the selection type is L_SELECT_WIDTH, the input
/// height is ignored, and v.v.<para/>
/// 
/// (4) To keep small components, use relation = L_SELECT_IF_LT or
/// L_SELECT_IF_LTE.
/// To keep large components, use relation = L_SELECT_IF_GT or
/// L_SELECT_IF_GTE.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectBySize/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="width">[in] - threshold dimensions</param>
///  <param name="height">[in] - threshold dimensions</param>
///  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
///  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 otherwise</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectBySize(
				 Pixa pixas, 
				 int width, 
				 int height, 
				 int type, 
				 int relation, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectBySize(pixas.Pointer,   width,   height,   type,   relation, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (355, 1)
// pixaMakeSizeIndicator(pixa, width, height, type, relation) as Numa
// pixaMakeSizeIndicator(PIXA *, l_int32, l_int32, l_int32, l_int32) as NUMA *
///  <summary>
/// (1) The args specify constraints on the size of the
/// components that are kept.<para/>
/// 
/// (2) If the selection type is L_SELECT_WIDTH, the input
/// height is ignored, and v.v.<para/>
/// 
/// (3) To keep small components, use relation = L_SELECT_IF_LT or
/// L_SELECT_IF_LTE.
/// To keep large components, use relation = L_SELECT_IF_GT or
/// L_SELECT_IF_GTE.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaMakeSizeIndicator/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="width">[in] - threshold dimensions</param>
///  <param name="height">[in] - threshold dimensions</param>
///  <param name="type">[in] - L_SELECT_WIDTH, L_SELECT_HEIGHT, L_SELECT_IF_EITHER, L_SELECT_IF_BOTH</param>
///  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///   <returns>na indicator array, or NULL on error</returns>
public static Numa pixaMakeSizeIndicator(
				 Pixa pixa, 
				 int width, 
				 int height, 
				 int type, 
				 int relation){

	IntPtr _Result = Natives.pixaMakeSizeIndicator(pixa.Pointer,   width,   height,   type,   relation);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// pixafunc1.c (446, 1)
// pixSelectByPerimToAreaRatio(pixs, thresh, connectivity, type, pchanged) as Pix
// pixSelectByPerimToAreaRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) The args specify constraints on the size of the
/// components that are kept.<para/>
/// 
/// (2) If unchanged, returns a copy of pixs.  Otherwise,
/// returns a new pix with the filtered components.<para/>
/// 
/// (3) This filters "thick" components, where a thick component
/// is defined to have a ratio of boundary to interior pixels
/// that is smaller than a given threshold value.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save the thicker
/// components, and L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectByPerimToAreaRatio/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixSelectByPerimToAreaRatio(
				 Pix pixs, 
				 Single thresh, 
				 int connectivity, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixSelectByPerimToAreaRatio(pixs.Pointer,   thresh,   connectivity,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (520, 1)
// pixaSelectByPerimToAreaRatio(pixas, thresh, type, pchanged) as Pixa
// pixaSelectByPerimToAreaRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) See pixSelectByPerimToAreaRatio().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectByPerimToAreaRatio/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectByPerimToAreaRatio(
				 Pixa pixas, 
				 Single thresh, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectByPerimToAreaRatio(pixas.Pointer,   thresh,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (577, 1)
// pixSelectByPerimSizeRatio(pixs, thresh, connectivity, type, pchanged) as Pix
// pixSelectByPerimSizeRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) The args specify constraints on the size of the
/// components that are kept.<para/>
/// 
/// (2) If unchanged, returns a copy of pixs.  Otherwise,
/// returns a new pix with the filtered components.<para/>
/// 
/// (3) This filters components with smooth vs. dendritic shape, using
/// the ratio of the fg boundary pixels to the circumference of
/// the bounding box, and comparing it to a threshold value.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save the smooth
/// boundary components, and L_SELECT_IF_GT or L_SELECT_IF_GTE
/// to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectByPerimSizeRatio/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="thresh">[in] - threshold ratio of fg boundary to fg pixels</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixSelectByPerimSizeRatio(
				 Pix pixs, 
				 Single thresh, 
				 int connectivity, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixSelectByPerimSizeRatio(pixs.Pointer,   thresh,   connectivity,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (651, 1)
// pixaSelectByPerimSizeRatio(pixas, thresh, type, pchanged) as Pixa
// pixaSelectByPerimSizeRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) See pixSelectByPerimSizeRatio().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectByPerimSizeRatio/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="thresh">[in] - threshold ratio of fg boundary to b.b. circumference</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectByPerimSizeRatio(
				 Pixa pixas, 
				 Single thresh, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectByPerimSizeRatio(pixas.Pointer,   thresh,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (707, 1)
// pixSelectByAreaFraction(pixs, thresh, connectivity, type, pchanged) as Pix
// pixSelectByAreaFraction(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) The args specify constraints on the amount of foreground
/// coverage of the components that are kept.<para/>
/// 
/// (2) If unchanged, returns a copy of pixs.  Otherwise,
/// returns a new pix with the filtered components.<para/>
/// 
/// (3) This filters components based on the fraction of fg pixels
/// of the component in its bounding box.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
/// with less than the threshold fraction of foreground, and
/// L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectByAreaFraction/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="thresh">[in] - threshold ratio of fg pixels to (w  h)</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixSelectByAreaFraction(
				 Pix pixs, 
				 Single thresh, 
				 int connectivity, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixSelectByAreaFraction(pixs.Pointer,   thresh,   connectivity,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (785, 1)
// pixaSelectByAreaFraction(pixas, thresh, type, pchanged) as Pixa
// pixaSelectByAreaFraction(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) This filters components based on the fraction of fg pixels
/// of the component in its bounding box.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
/// with less than the threshold fraction of foreground, and
/// L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectByAreaFraction/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="thresh">[in] - threshold ratio of fg pixels to (w  h)</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectByAreaFraction(
				 Pixa pixas, 
				 Single thresh, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectByAreaFraction(pixas.Pointer,   thresh,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (840, 1)
// pixSelectByWidthHeightRatio(pixs, thresh, connectivity, type, pchanged) as Pix
// pixSelectByWidthHeightRatio(PIX *, l_float32, l_int32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) The args specify constraints on the width-to-height ratio
/// for components that are kept.<para/>
/// 
/// (2) If unchanged, returns a copy of pixs.  Otherwise,
/// returns a new pix with the filtered components.<para/>
/// 
/// (3) This filters components based on the width-to-height ratios.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
/// with less than the threshold ratio, and
/// L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectByWidthHeightRatio/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="thresh">[in] - threshold ratio of width/height</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixSelectByWidthHeightRatio(
				 Pix pixs, 
				 Single thresh, 
				 int connectivity, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixSelectByWidthHeightRatio(pixs.Pointer,   thresh,   connectivity,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (918, 1)
// pixaSelectByWidthHeightRatio(pixas, thresh, type, pchanged) as Pixa
// pixaSelectByWidthHeightRatio(PIXA *, l_float32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) This filters components based on the width-to-height ratio
/// of each pix.<para/>
/// 
/// (4) Use L_SELECT_IF_LT or L_SELECT_IF_LTE to save components
/// with less than the threshold ratio, and
/// L_SELECT_IF_GT or L_SELECT_IF_GTE to remove them.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectByWidthHeightRatio/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="thresh">[in] - threshold ratio of width/height</param>
///  <param name="type">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT, L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectByWidthHeightRatio(
				 Pixa pixas, 
				 Single thresh, 
				 int type, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectByWidthHeightRatio(pixas.Pointer,   thresh,   type, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (968, 1)
// pixaSelectByNumConnComp(pixas, nmin, nmax, connectivity, pchanged) as Pixa
// pixaSelectByNumConnComp(PIXA *, l_int32, l_int32, l_int32, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) This filters by the number of connected components in
/// a given range.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectByNumConnComp/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="nmin">[in] - minimum number of components</param>
///  <param name="nmax">[in] - maximum number of components</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectByNumConnComp(
				 Pixa pixas, 
				 int nmin, 
				 int nmax, 
				 int connectivity, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectByNumConnComp(pixas.Pointer,   nmin,   nmax,   connectivity, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1027, 1)
// pixaSelectWithIndicator(pixas, na, pchanged) as Pixa
// pixaSelectWithIndicator(PIXA *, NUMA *, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa clone if no components are removed.<para/>
/// 
/// (2) Uses pix and box clones in the new pixa.<para/>
/// 
/// (3) The indicator numa has values 0 (ignore) and 1 (accept).<para/>
/// 
/// (4) If the source boxa is not fully populated, it is left
/// empty in the dest pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectWithIndicator/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="na">[in] - indicator numa</param>
///  <param name="pchanged">[out][optional] - 1 if changed 0 if clone returned</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectWithIndicator(
				 Pixa pixas, 
				 Numa na, 
				out int pchanged){

	IntPtr _Result = Natives.pixaSelectWithIndicator(pixas.Pointer, na.Pointer, out  pchanged);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1087, 1)
// pixRemoveWithIndicator(pixs, pixa, na) as int
// pixRemoveWithIndicator(PIX *, PIXA *, NUMA *) as l_ok
///  <summary>
/// (1) This complements pixAddWithIndicator(). Here, the selected
/// components are set subtracted from pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveWithIndicator/*"/>
///  <param name="pixs">[in] - 1 bpp pix from which components are removed in-place</param>
///  <param name="pixa">[in] - of connected components in pixs</param>
///  <param name="na">[in] - numa indicator: remove components corresponding to 1s</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixRemoveWithIndicator(
				 Pix pixs, 
				 Pixa pixa, 
				 Numa na){

	int _Result = Natives.pixRemoveWithIndicator(pixs.Pointer, pixa.Pointer, na.Pointer);
	
	return _Result;
}

// pixafunc1.c (1140, 1)
// pixAddWithIndicator(pixs, pixa, na) as int
// pixAddWithIndicator(PIX *, PIXA *, NUMA *) as l_ok
///  <summary>
/// (1) This complements pixRemoveWithIndicator(). Here, the selected
/// components are added to pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddWithIndicator/*"/>
///  <param name="pixs">[in] - 1 bpp pix from which components are added in-place</param>
///  <param name="pixa">[in] - of connected components, some of which will be put into pixs</param>
///  <param name="na">[in] - numa indicator: add components corresponding to 1s</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixAddWithIndicator(
				 Pix pixs, 
				 Pixa pixa, 
				 Numa na){

	int _Result = Natives.pixAddWithIndicator(pixs.Pointer, pixa.Pointer, na.Pointer);
	
	return _Result;
}

// pixafunc1.c (1193, 1)
// pixaSelectWithString(pixas, str, perror) as Pixa
// pixaSelectWithString(PIXA *, const char *, l_int32 *) as PIXA *
///  <summary>
/// (1) Returns a pixa with copies of selected pix.<para/>
/// 
/// (2) Associated boxes are also copied, if fully populated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectWithString/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="str">[in] - string of indices into pixa, giving the pix to be selected</param>
///  <param name="perror">[out][optional] - 1 if any indices are invalid 0 if all indices are valid</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectWithString(
				 Pixa pixas, 
				 String str, 
				out int perror){

	IntPtr _Result = Natives.pixaSelectWithString(pixas.Pointer,   str, out  perror);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1264, 1)
// pixaRenderComponent(pixs, pixa, index) as Pix
// pixaRenderComponent(PIX *, PIXA *, l_int32) as PIX *
///  <summary>
/// (1) If pixs is null, this generates an empty pix of a size determined
/// by union of the component bounding boxes, and including the origin.<para/>
/// 
/// (2) The selected component is blitted into pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRenderComponent/*"/>
///  <param name="pixs">[in][optional] - 1 bpp pix</param>
///  <param name="pixa">[in] - of 1 bpp connected components, one of which will be rendered in pixs, with its origin determined by the associated box.</param>
///  <param name="index">[in] - of component to be rendered</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixaRenderComponent(
				 Pix pixs, 
				 Pixa pixa, 
				 int index){

	IntPtr pixsPtr = IntPtr.Zero; 	if (pixs != null) {pixsPtr = pixs.Pointer;}

	IntPtr _Result = Natives.pixaRenderComponent(pixsPtr, pixa.Pointer,   index);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// pixafunc1.c (1334, 1)
// pixaSort(pixas, sorttype, sortorder, pnaindex, copyflag) as Pixa
// pixaSort(PIXA *, l_int32, l_int32, NUMA **, l_int32) as PIXA *
///  <summary>
/// (1) This sorts based on the data in the boxa.  If the boxa
/// count is not the same as the pixa count, this returns an error.<para/>
/// 
/// (2) If the boxa is empty, it makes one corresponding to the
/// dimensions of each pix, which allows meaningful sorting on
/// all types except x and y.<para/>
/// 
/// (3) The copyflag refers to the pix and box copies that are
/// inserted into the sorted pixa.  These are either L_COPY
/// or L_CLONE.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSort/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MIN_DIMENSION, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA, L_SORT_BY_ASPECT_RATIO</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
///  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>pixad sorted version of pixas, or NULL on error</returns>
public static Pixa pixaSort(
				 Pixa pixas, 
				 int sorttype, 
				 int sortorder, 
				out Numa pnaindex, 
				 int copyflag){

	IntPtr pnaindexPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixaSort(pixas.Pointer,   sorttype,   sortorder, out pnaindexPtr,   copyflag);
	
	if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1474, 1)
// pixaBinSort(pixas, sorttype, sortorder, pnaindex, copyflag) as Pixa
// pixaBinSort(PIXA *, l_int32, l_int32, NUMA **, l_int32) as PIXA *
///  <summary>
/// (1) This sorts based on the data in the boxa.  If the boxa
/// count is not the same as the pixa count, this returns an error.<para/>
/// 
/// (2) The copyflag refers to the pix and box copies that are
/// inserted into the sorted pixa.  These are either L_COPY
/// or L_CLONE.<para/>
/// 
/// (3) For a large number of boxes (say, greater than 1000), this
/// O(n) binsort is much faster than the O(nlogn) shellsort.
/// For 5000 components, this is over 20x faster than boxaSort().<para/>
/// 
/// (4) Consequently, pixaSort() calls this function if it will
/// likely go much faster.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaBinSort/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_PERIMETER</param>
///  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
///  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>pixad sorted version of pixas, or NULL on error</returns>
public static Pixa pixaBinSort(
				 Pixa pixas, 
				 int sorttype, 
				 int sortorder, 
				out Numa pnaindex, 
				 int copyflag){

	IntPtr pnaindexPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixaBinSort(pixas.Pointer,   sorttype,   sortorder, out pnaindexPtr,   copyflag);
	
	if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1562, 1)
// pixaSortByIndex(pixas, naindex, copyflag) as Pixa
// pixaSortByIndex(PIXA *, NUMA *, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSortByIndex/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="naindex">[in] - na that maps from the new pixa to the input pixa</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>pixad sorted, or NULL on error</returns>
public static Pixa pixaSortByIndex(
				 Pixa pixas, 
				 Numa naindex, 
				 int copyflag){

	IntPtr _Result = Natives.pixaSortByIndex(pixas.Pointer, naindex.Pointer,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1603, 1)
// pixaSort2dByIndex(pixas, naa, copyflag) as Pixaa
// pixaSort2dByIndex(PIXA *, NUMAA *, l_int32) as PIXAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSort2dByIndex/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="naa">[in] - numaa that maps from the new pixaa to the input pixas</param>
///  <param name="copyflag">[in] - L_CLONE or L_COPY</param>
///   <returns>paa sorted, or NULL on error</returns>
public static Pixaa pixaSort2dByIndex(
				 Pixa pixas, 
				 Numaa naa, 
				 int copyflag){

	IntPtr _Result = Natives.pixaSort2dByIndex(pixas.Pointer, naa.Pointer,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixafunc1.c (1668, 1)
// pixaSelectRange(pixas, first, last, copyflag) as Pixa
// pixaSelectRange(PIXA *, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) The copyflag specifies what we do with each pix from pixas.
/// Specifically, L_CLONE inserts a clone into pixad of each
/// selected pix from pixas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectRange/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="first">[in] - use 0 to select from the beginning</param>
///  <param name="last">[in] - use 0 to select to the end</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaSelectRange(
				 Pixa pixas, 
				 int first, 
				 int last, 
				 int copyflag){

	IntPtr _Result = Natives.pixaSelectRange(pixas.Pointer,   first,   last,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1718, 1)
// pixaaSelectRange(paas, first, last, copyflag) as Pixaa
// pixaaSelectRange(PIXAA *, l_int32, l_int32, l_int32) as PIXAA *
///  <summary>
/// (1) The copyflag specifies what we do with each pixa from paas.
/// Specifically, L_CLONE inserts a clone into paad of each
/// selected pixa from paas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaSelectRange/*"/>
///  <param name="paas">[in] - </param>
///  <param name="first">[in] - use 0 to select from the beginning</param>
///  <param name="last">[in] - use 0 to select to the end</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>paad, or NULL on error</returns>
public static Pixaa pixaaSelectRange(
				 Pixaa paas, 
				 int first, 
				 int last, 
				 int copyflag){

	IntPtr _Result = Natives.pixaaSelectRange(paas.Pointer,   first,   last,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixafunc1.c (1774, 1)
// pixaaScaleToSize(paas, wd, hd) as Pixaa
// pixaaScaleToSize(PIXAA *, l_int32, l_int32) as PIXAA *
///  <summary>
/// (1) This guarantees that each output scaled image has the
/// dimension(s) you specify.
/// ~ To specify the width with isotropic scaling, set %hd = 0.
/// ~ To specify the height with isotropic scaling, set %wd = 0.
/// ~ If both %wd and %hd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// ~ It is an error to set both %wd and %hd to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaScaleToSize/*"/>
///  <param name="paas">[in] - </param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>paad, or NULL on error</returns>
public static Pixaa pixaaScaleToSize(
				 Pixaa paas, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixaaScaleToSize(paas.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixafunc1.c (1823, 1)
// pixaaScaleToSizeVar(paas, nawd, nahd) as Pixaa
// pixaaScaleToSizeVar(PIXAA *, NUMA *, NUMA *) as PIXAA *
///  <summary>
/// (1) This guarantees that the scaled images in each pixa have the
/// dimension(s) you specify in the numas.
/// ~ To specify the width with isotropic scaling, set %nahd = NULL.
/// ~ To specify the height with isotropic scaling, set %nawd = NULL.
/// ~ If both %nawd and %nahd are specified, the image is scaled
/// (in general, anisotropically) to that size.
/// ~ It is an error to set both %nawd and %nahd to NULL.<para/>
/// 
/// (2) If either nawd and/or nahd is defined, it must have the same
/// count as the number of pixa in paas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaScaleToSizeVar/*"/>
///  <param name="paas">[in] - </param>
///  <param name="nawd">[in][optional] - target widths use NULL if using height</param>
///  <param name="nahd">[in][optional] - target height use NULL if using width</param>
///   <returns>paad, or NULL on error</returns>
public static Pixaa pixaaScaleToSizeVar(
				 Pixaa paas, 
				 Numa nawd, 
				 Numa nahd){

	IntPtr nawdPtr = IntPtr.Zero; 	if (nawd != null) {nawdPtr = nawd.Pointer;}
	IntPtr nahdPtr = IntPtr.Zero; 	if (nahd != null) {nahdPtr = nahd.Pointer;}

	IntPtr _Result = Natives.pixaaScaleToSizeVar(paas.Pointer, nawdPtr, nahdPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixaa(_Result);
}

// pixafunc1.c (1871, 1)
// pixaScaleToSize(pixas, wd, hd) as Pixa
// pixaScaleToSize(PIXA *, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) See pixaaScaleToSize()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaScaleToSize/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="wd">[in] - target width use 0 if using height as target</param>
///  <param name="hd">[in] - target height use 0 if using width as target</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaScaleToSize(
				 Pixa pixas, 
				 int wd, 
				 int hd){

	IntPtr _Result = Natives.pixaScaleToSize(pixas.Pointer,   wd,   hd);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1916, 1)
// pixaScaleToSizeRel(pixas, delw, delh) as Pixa
// pixaScaleToSizeRel(PIXA *, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) If a requested change in a pix is not possible because
/// either the requested width or height is smaller or equal 0, issue a
/// warning and return a copy.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaScaleToSizeRel/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="delw">[in] - change in width, in pixels 0 means no change</param>
///  <param name="delh">[in] - change in height, in pixels 0 means no change return  pixad, or NULL on error</param>
///   <returns></returns>
public static Pixa pixaScaleToSizeRel(
				 Pixa pixas, 
				 int delw, 
				 int delh){

	IntPtr _Result = Natives.pixaScaleToSizeRel(pixas.Pointer,   delw,   delh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (1960, 1)
// pixaScale(pixas, scalex, scaley) as Pixa
// pixaScale(PIXA *, l_float32, l_float32) as PIXA *
///  <summary>
/// (1) If pixas has a full boxes, it is scaled as well.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaScale/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="scalex">[in] - </param>
///  <param name="scaley">[in] - </param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaScale(
				 Pixa pixas, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixaScale(pixas.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2011, 1)
// pixaScaleBySampling(pixas, scalex, scaley) as Pixa
// pixaScaleBySampling(PIXA *, l_float32, l_float32) as PIXA *
///  <summary>
/// (1) If pixas has a full boxes, it is scaled as well.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaScaleBySampling/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="scalex">[in] - </param>
///  <param name="scaley">[in] - </param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaScaleBySampling(
				 Pixa pixas, 
				 Single scalex, 
				 Single scaley){

	IntPtr _Result = Natives.pixaScaleBySampling(pixas.Pointer,   scalex,   scaley);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2076, 1)
// pixaRotate(pixas, angle, type, incolor, width, height) as Pixa
// pixaRotate(PIXA *, l_float32, l_int32, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) Each pix is rotated about its center.  See pixRotate() for details.<para/>
/// 
/// (2) The boxa array is copied.  Why is it not rotated?
/// If a boxa exists, the array of boxes is in 1-to-1
/// correspondence with the array of pix, and each box typically
/// represents the location of the pix relative to an image from
/// which it has been extracted.  Like the pix, we could rotate
/// each box around its center, and then generate a box that
/// contains all four corners, as is done in boxaRotate(), but
/// this seems unnecessary.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRotate/*"/>
///  <param name="pixas">[in] - 1, 2, 4, 8, 32 bpp rgb</param>
///  <param name="angle">[in] - rotation angle in radians clockwise is positive</param>
///  <param name="type">[in] - L_ROTATE_AREA_MAP, L_ROTATE_SHEAR, L_ROTATE_SAMPLING</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///  <param name="width">[in] - original width use 0 to avoid embedding</param>
///  <param name="height">[in] - original height use 0 to avoid embedding</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaRotate(
				 Pixa pixas, 
				 Single angle, 
				 int type, 
				 int incolor, 
				 int width, 
				 int height){

	IntPtr _Result = Natives.pixaRotate(pixas.Pointer,   angle,   type,   incolor,   width,   height);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2134, 1)
// pixaRotateOrth(pixas, rotation) as Pixa
// pixaRotateOrth(PIXA *, l_int32) as PIXA *
///  <summary>
/// (1) Rotates each pix in the pixa.  Rotates and saves the boxes in
/// the boxa if the boxa is full.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaRotateOrth/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg all rotations are clockwise</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaRotateOrth(
				 Pixa pixas, 
				 int rotation){

	IntPtr _Result = Natives.pixaRotateOrth(pixas.Pointer,   rotation);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2186, 1)
// pixaTranslate(pixas, hshift, vshift, incolor) as Pixa
// pixaTranslate(PIXA *, l_int32, l_int32, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaTranslate/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="hshift">[in] - horizontal shift hshift  is greater  0 is to right</param>
///  <param name="vshift">[in] - vertical shift vshift  is greater  0 is down</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixad, or NULL on error.</returns>
public static Pixa pixaTranslate(
				 Pixa pixas, 
				 int hshift, 
				 int vshift, 
				 int incolor){

	IntPtr _Result = Natives.pixaTranslate(pixas.Pointer,   hshift,   vshift,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2260, 1)
// pixaAddBorderGeneral(pixad, pixas, left, right, top, bot, val) as Pixa
// pixaAddBorderGeneral(PIXA *, PIXA *, l_int32, l_int32, l_int32, l_int32, l_uint32) as PIXA *
///  <summary>
/// (1) For binary images:
/// white:  val = 0
/// black:  val = 1
/// For grayscale images:
/// white:  val = 2  d - 1
/// black:  val = 0
/// For rgb color images:
/// white:  val = 0xffffff00
/// black:  val = 0
/// For colormapped images, use 'index' found this way:
/// white: pixcmapGetRankIntensity(cmap, 1.0, [and]index)
/// black: pixcmapGetRankIntensity(cmap, 0.0, [and]index)<para/>
/// 
/// (2) For in-place replacement of each pix with a bordered version,
/// use %pixad = %pixas.  To make a new pixa, use %pixad = NULL.<para/>
/// 
/// (3) In both cases, the boxa has sides adjusted as if it were
/// expanded by the border.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddBorderGeneral/*"/>
///  <param name="pixad">[in]can be null - or equal to pixas</param>
///  <param name="pixas">[in] - containing pix of all depths colormap ok</param>
///  <param name="left">[in] - number of pixels added</param>
///  <param name="right">[in] - number of pixels added</param>
///  <param name="top">[in] - number of pixels added</param>
///  <param name="bot">[in] - number of pixels added</param>
///  <param name="val">[in] - value of added border pixels</param>
///   <returns>pixad with border added to each pix, including on error</returns>
public static Pixa pixaAddBorderGeneral(
				 Pixa pixad, 
				 Pixa pixas, 
				 int left, 
				 int right, 
				 int top, 
				 int bot, 
				 uint val){

	IntPtr pixadPtr = IntPtr.Zero; 	if (pixad != null) {pixadPtr = pixad.Pointer;}

	IntPtr _Result = Natives.pixaAddBorderGeneral(pixadPtr, pixas.Pointer,   left,   right,   top,   bot,   val);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2331, 1)
// pixaaFlattenToPixa(paa, pnaindex, copyflag) as Pixa
// pixaaFlattenToPixa(PIXAA *, NUMA **, l_int32) as PIXA *
///  <summary>
/// (1) This 'flattens' the pixaa to a pixa, taking the pix in
/// order in the first pixa, then the second, etc.<para/>
/// 
/// (2) If [and]naindex is defined, we generate a Numa that gives, for
/// each pix in the pixaa, the index of the pixa to which it belongs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaFlattenToPixa/*"/>
///  <param name="paa">[in] - </param>
///  <param name="pnaindex">[out][optional] - the pixa index in the pixaa</param>
///  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
///   <returns>pixa, or NULL on error</returns>
public static Pixa pixaaFlattenToPixa(
				 Pixaa paa, 
				out Numa pnaindex, 
				 int copyflag){

	IntPtr pnaindexPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixaaFlattenToPixa(paa.Pointer, out pnaindexPtr,   copyflag);
	
	if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2386, 1)
// pixaaSizeRange(paa, pminw, pminh, pmaxw, pmaxh) as int
// pixaaSizeRange(PIXAA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaSizeRange/*"/>
///  <param name="paa">[in] - </param>
///  <param name="pminw">[out][optional] - range of dimensions of all boxes</param>
///  <param name="pminh">[out][optional] - range of dimensions of all boxes</param>
///  <param name="pmaxw">[out][optional] - range of dimensions of all boxes</param>
///  <param name="pmaxh">[out][optional] - range of dimensions of all boxes</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaaSizeRange(
				 Pixaa paa, 
				out int pminw, 
				out int pminh, 
				out int pmaxw, 
				out int pmaxh){

	int _Result = Natives.pixaaSizeRange(paa.Pointer, out  pminw, out  pminh, out  pmaxw, out  pmaxh);
	
	return _Result;
}

// pixafunc1.c (2440, 1)
// pixaSizeRange(pixa, pminw, pminh, pmaxw, pmaxh) as int
// pixaSizeRange(PIXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSizeRange/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pminw">[out][optional] - range of dimensions of pix in the array</param>
///  <param name="pminh">[out][optional] - range of dimensions of pix in the array</param>
///  <param name="pmaxw">[out][optional] - range of dimensions of pix in the array</param>
///  <param name="pmaxh">[out][optional] - range of dimensions of pix in the array</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSizeRange(
				 Pixa pixa, 
				out int pminw, 
				out int pminh, 
				out int pmaxw, 
				out int pmaxh){

	int _Result = Natives.pixaSizeRange(pixa.Pointer, out  pminw, out  pminh, out  pmaxw, out  pmaxh);
	
	return _Result;
}

// pixafunc1.c (2510, 1)
// pixaClipToPix(pixas, pixs) as Pixa
// pixaClipToPix(PIXA *, PIX *) as PIXA *
///  <summary>
/// (1) This is intended for use in situations where pixas
/// was originally generated from the input pixs.<para/>
/// 
/// (2) Returns a pixad where each pix in pixas is ANDed
/// with its associated region of the input pixs.  This
/// region is specified by the the box that is associated
/// with the pix.<para/>
/// 
/// (3) In a typical application of this function, pixas has
/// a set of region masks, so this generates a pixa of
/// the parts of pixs that correspond to each region
/// mask component, along with the bounding box for
/// the region.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaClipToPix/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="pixs">[in] - </param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaClipToPix(
				 Pixa pixas, 
				 Pix pixs){

	IntPtr _Result = Natives.pixaClipToPix(pixas.Pointer, pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2559, 1)
// pixaClipToForeground(pixas, ppixad, pboxa) as int
// pixaClipToForeground(PIXA *, PIXA **, BOXA **) as l_ok
///  <summary>
/// (1) At least one of [[and]pixd, [and]boxa] must be specified.<para/>
/// 
/// (2) Any pix with no fg pixels is skipped.<para/>
/// 
/// (3) See pixClipToForeground().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaClipToForeground/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="ppixad">[out][optional] - pixa of clipped pix returned</param>
///  <param name="pboxa">[out][optional] - clipping boxes returned</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaClipToForeground(
				 Pixa pixas, 
				out Pixa ppixad, 
				out Boxa pboxa){

	IntPtr ppixadPtr = IntPtr.Zero;
	IntPtr pboxaPtr = IntPtr.Zero;

	int _Result = Natives.pixaClipToForeground(pixas.Pointer, out ppixadPtr, out pboxaPtr);
	
	if (ppixadPtr == IntPtr.Zero) {ppixad = null;} else { ppixad = new Pixa(ppixadPtr); };
	if (pboxaPtr == IntPtr.Zero) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };
	return _Result;
}

// pixafunc1.c (2605, 1)
// pixaGetRenderingDepth(pixa, pdepth) as int
// pixaGetRenderingDepth(PIXA *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetRenderingDepth/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pdepth">[out] - depth required to render if all colormaps are removed</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaGetRenderingDepth(
				 Pixa pixa, 
				out int pdepth){

	int _Result = Natives.pixaGetRenderingDepth(pixa.Pointer, out  pdepth);
	
	return _Result;
}

// pixafunc1.c (2642, 1)
// pixaHasColor(pixa, phascolor) as int
// pixaHasColor(PIXA *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaHasColor/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="phascolor">[out] - 1 if any pix is rgb or has a colormap with color 0 otherwise</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaHasColor(
				 Pixa pixa, 
				out int phascolor){

	int _Result = Natives.pixaHasColor(pixa.Pointer, out  phascolor);
	
	return _Result;
}

// pixafunc1.c (2683, 1)
// pixaAnyColormaps(pixa, phascmap) as int
// pixaAnyColormaps(PIXA *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAnyColormaps/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="phascmap">[out] - 1 if any pix has a colormap 0 otherwise</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaAnyColormaps(
				 Pixa pixa, 
				out int phascmap){

	int _Result = Natives.pixaAnyColormaps(pixa.Pointer, out  phascmap);
	
	return _Result;
}

// pixafunc1.c (2722, 1)
// pixaGetDepthInfo(pixa, pmaxdepth, psame) as int
// pixaGetDepthInfo(PIXA *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetDepthInfo/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pmaxdepth">[out][optional] - max pixel depth of pix in pixa</param>
///  <param name="psame">[out][optional] - true if all depths are equal</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixaGetDepthInfo(
				 Pixa pixa, 
				out int pmaxdepth, 
				out int psame){

	int _Result = Natives.pixaGetDepthInfo(pixa.Pointer, out  pmaxdepth, out  psame);
	
	return _Result;
}

// pixafunc1.c (2771, 1)
// pixaConvertToSameDepth(pixas) as Pixa
// pixaConvertToSameDepth(PIXA *) as PIXA *
///  <summary>
/// (1) If any pix has a colormap, they are all converted to rgb.
/// Otherwise, they are all converted to the maximum depth of
/// all the pix.<para/>
/// 
/// (2) This can be used to allow lossless rendering onto a single pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertToSameDepth/*"/>
///  <param name="pixas">[in] - </param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaConvertToSameDepth(
				 Pixa pixas){

	IntPtr _Result = Natives.pixaConvertToSameDepth(pixas.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// pixafunc1.c (2851, 1)
// pixaEqual(pixa1, pixa2, maxdist, pnaindex, psame) as int
// pixaEqual(PIXA *, PIXA *, l_int32, NUMA **, l_int32 *) as l_ok
///  <summary>
/// (1) The two pixa are the "same" if they contain the same
/// boxa and the same ordered set of pix.  However, if they
/// have boxa, the pix in each pixa can differ in ordering
/// by an amount given by the parameter %maxdist.  If they
/// don't have a boxa, the %maxdist parameter is ignored,
/// and the ordering must be identical.<para/>
/// 
/// (2) This applies only to boxa geometry, pixels and ordering
/// other fields in the pix are ignored.<para/>
/// 
/// (3) naindex[i] gives the position of the box in pixa2 that
/// corresponds to box i in pixa1.  It is only returned if the
/// pixa have boxa and the boxa are equal.<para/>
/// 
/// (4) In situations where the ordering is very different, so that
/// a large %maxdist is required for "equality", this should be
/// implemented with a hash function for efficiency.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaEqual/*"/>
///  <param name="pixa1">[in] - </param>
///  <param name="pixa2">[in] - </param>
///  <param name="maxdist">[in] - </param>
///  <param name="pnaindex">[out][optional] - index array of correspondences</param>
///  <param name="psame">[out] - 1 if equal 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaEqual(
				 Pixa pixa1, 
				 Pixa pixa2, 
				 int maxdist, 
				out Numa pnaindex, 
				out int psame){

	IntPtr pnaindexPtr = IntPtr.Zero;

	int _Result = Natives.pixaEqual(pixa1.Pointer, pixa2.Pointer,   maxdist, out pnaindexPtr, out  psame);
	
	if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };
	return _Result;
}

// pixafunc1.c (2936, 1)
// pixaSetFullSizeBoxa(pixa) as int
// pixaSetFullSizeBoxa(PIXA *) as l_ok
///  <summary>
/// (1) Replaces the existing boxa.  Each box gives the dimensions
/// of the corresponding pix.  This is needed for functions
/// like pixaSort() that sort based on the boxes.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSetFullSizeBoxa/*"/>
///  <param name="pixa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSetFullSizeBoxa(
				 Pixa pixa){

	int _Result = Natives.pixaSetFullSizeBoxa(pixa.Pointer);
	
	return _Result;
}


}
}
