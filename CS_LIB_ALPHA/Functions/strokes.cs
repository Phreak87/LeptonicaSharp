using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// strokes.c (75, 1)
// pixFindStrokeLength(pixs, tab8, plength) as int
// pixFindStrokeLength(PIX *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) Returns half the number of fg boundary pixels.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindStrokeLength/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
///  <param name="plength">[out] - estimated length of the strokes</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixFindStrokeLength(
				  Pix pixs, 
				  int[] tab8, 
				 out int plength){

	int _Result = Natives.pixFindStrokeLength(pixs.Pointer,   tab8, out  plength);
	

plength = 0;


	return _Result;
}

// strokes.c (123, 1)
// pixFindStrokeWidth(pixs, thresh, tab8, pwidth, pnahisto) as int
// pixFindStrokeWidth(PIX *, l_float32, l_int32 *, l_float32 *, NUMA **) as l_ok
///  <summary>
/// (1) This uses two methods to estimate the stroke width:
/// (a) half the fg boundary length
/// (b) a value derived from the histogram of the fg distance transform<para/>
/// 
/// (2) Distance is measured in 8-connected<para/>
/// 
/// (3) %thresh is the minimum fraction N(dist=d)/N(dist=1) of pixels
/// required to determine if the pixels at distance d are above
/// the noise. It is typically about 0.15.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindStrokeWidth/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="thresh">[in] - fractional count threshold relative to distance 1</param>
///  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
///  <param name="pwidth">[out] - estimated width of the strokes</param>
///  <param name="pnahisto">[out][optional] - histo of pixel distances from bg</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixFindStrokeWidth(
				  Pix pixs, 
				  Single thresh, 
				  int[] tab8, 
				 out Single pwidth, 
				out Numa pnahisto){

	IntPtr pnahistoPtr = IntPtr.Zero;

	int _Result = Natives.pixFindStrokeWidth(pixs.Pointer,   thresh,   tab8, out  pwidth, out pnahistoPtr);
	

pwidth = 0f;
pnahisto = null;
	; if (pnahistoPtr != IntPtr.Zero){pnahisto = new Numa(pnahistoPtr);}


	return _Result;
}

// strokes.c (208, 1)
// pixaFindStrokeWidth(pixa, thresh, tab8, debug) as Numa
// pixaFindStrokeWidth(PIXA *, l_float32, l_int32 *, l_int32) as NUMA *
///  <summary>
/// (1) See pixFindStrokeWidth() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindStrokeWidth/*"/>
///  <param name="pixa">[in] - of 1 bpp images</param>
///  <param name="thresh">[in] - fractional count threshold relative to distance 1</param>
///  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
///  <param name="debug">[in] - 1 for debug output 0 to skip</param>
///   <returns>na  array of stroke widths for each pix in %pixa NULL on error</returns>
public static Numa pixaFindStrokeWidth(
				  Pixa pixa, 
				  Single thresh, 
				 int[] tab8, 
				 DebugOnOff debug){

	IntPtr _Result = Natives.pixaFindStrokeWidth(pixa.Pointer,   thresh,   tab8,  (int) debug);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Numa(_Result);
}

// strokes.c (254, 1)
// pixaModifyStrokeWidth(pixas, targetw) as Pixa
// pixaModifyStrokeWidth(PIXA *, l_float32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaModifyStrokeWidth/*"/>
///  <param name="pixas">[in] - of 1 bpp pix</param>
///  <param name="targetw">[out] - desired width for strokes in each pix</param>
///   <returns>pixa  with modified stroke widths, or NULL on error</returns>
public static Pixa pixaModifyStrokeWidth(
				  Pixa pixas, 
				 out Single targetw){

	IntPtr _Result = Natives.pixaModifyStrokeWidth(pixas.Pointer, out  targetw);
	

targetw = 0f;

	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// strokes.c (298, 1)
// pixModifyStrokeWidth(pixs, width, targetw) as Pix
// pixModifyStrokeWidth(PIX *, l_float32, l_float32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixModifyStrokeWidth/*"/>
///  <param name="pixs">[in] - of 1 bpp pix</param>
///  <param name="width">[in] - measured average stroke width</param>
///  <param name="targetw">[in] - desired stroke width</param>
///   <returns>pix  with modified stroke width, or NULL on error</returns>
public static Pix pixModifyStrokeWidth(
				  Pix pixs, 
				  Single width, 
				  Single targetw){

	IntPtr _Result = Natives.pixModifyStrokeWidth(pixs.Pointer,   width,   targetw);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// strokes.c (345, 1)
// pixaSetStrokeWidth(pixas, width, thinfirst, connectivity) as Pixa
// pixaSetStrokeWidth(PIXA *, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) If %thinfirst == 1, thin to a skeleton using the specified
/// %connectivity.  Use %thinfirst == 0 if all pix in pixas
/// have already been thinned as far as possible.<para/>
/// 
/// (2) The image is dilated to the required %width.  This dilation
/// is not connectivity preserving, so this is typically
/// used in a situation where merging of c.c. in the individual
/// pix is not a problem e.g., where each pix is a single c.c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSetStrokeWidth/*"/>
///  <param name="pixas">[in] - of 1 bpp pix</param>
///  <param name="width">[in] - set stroke width to this value, in [1 ... 100].</param>
///  <param name="thinfirst">[in] - 1 to thin all pix to a skeleton first 0 to skip</param>
///  <param name="connectivity">[in] - 4 or 8, to be used if %thinfirst == 1</param>
///   <returns>pixa  with all stroke widths being %width, or NULL on error</returns>
public static Pixa pixaSetStrokeWidth(
				  Pixa pixas, 
				  int width, 
				  int thinfirst, 
				  int connectivity){

	IntPtr _Result = Natives.pixaSetStrokeWidth(pixas.Pointer,   width,   thinfirst,   connectivity);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// strokes.c (397, 1)
// pixSetStrokeWidth(pixs, width, thinfirst, connectivity) as Pix
// pixSetStrokeWidth(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See notes in pixaSetStrokeWidth().<para/>
/// 
/// (2) A white border of sufficient width to avoid boundary
/// artifacts in the thickening step is added before thinning.<para/>
/// 
/// (3) %connectivity == 8 usually gives a slightly smoother result.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetStrokeWidth/*"/>
///  <param name="pixs">[in] - 1 bpp pix</param>
///  <param name="width">[in] - set stroke width to this value, in [1 ... 100].</param>
///  <param name="thinfirst">[in] - 1 to thin all pix to a skeleton first 0 to skip</param>
///  <param name="connectivity">[in] - 4 or 8, to be used if %thinfirst == 1</param>
///   <returns>pixd  with stroke width set to %width, or NULL on error</returns>
public static Pix pixSetStrokeWidth(
				  Pix pixs, 
				  int width, 
				  int thinfirst, 
				  int connectivity){

	IntPtr _Result = Natives.pixSetStrokeWidth(pixs.Pointer,   width,   thinfirst,   connectivity);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

}
