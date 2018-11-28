using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// recogident.c (158, 1)
// recogIdentifyMultiple(recog, pixs, minh, skipsplit, pboxa, ppixa, ppixdb, debugsplit) as int
// recogIdentifyMultiple(L_RECOG *, PIX *, l_int32, l_int32, BOXA **, PIXA **, PIX **, l_int32) as l_ok
///  <summary>
/// (1) This filters the input pixa and calls recogIdentifyPixa()<para/>
/// 
/// (2) Splitting is relatively slow, because it tries to match all
/// character templates to all locations.  This step can be skipped.<para/>
/// 
/// (3) An attempt is made to order the (optionally) returned images
/// and boxes in 2-dimensional sorted order.  These can then
/// be used to aggregate identified characters into numbers or words.
/// One typically wants the pixa, which contains a boxa of the
/// extracted subimages.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyMultiple/*"/>
///  <param name="recog">[in] - with training finished</param>
///  <param name="pixs">[in] - containing typically a small number of characters</param>
///  <param name="minh">[in] - remove shorter components use 0 for default</param>
///  <param name="skipsplit">[in] - 1 to skip the splitting step</param>
///  <param name="pboxa">[out][optional] - locations of identified components</param>
///  <param name="ppixa">[out][optional] - images of identified components</param>
///  <param name="ppixdb">[out][optional] - debug pix: inputs and best fits</param>
///  <param name="debugsplit">[in] - 1 returns pix split debugging images</param>
///   <returns>0 if OK 1 if nothing is found 2 for other errors.</returns>
public static int recogIdentifyMultiple(
				  L_Recog recog, 
				  Pix pixs, 
				  int minh, 
				  int skipsplit, 
				 out Boxa pboxa, 
				 out Pixa ppixa, 
				 out Pix ppixdb, 
				  int debugsplit){

	IntPtr pboxaPtr = IntPtr.Zero;
	IntPtr ppixaPtr = IntPtr.Zero;
	IntPtr ppixdbPtr = IntPtr.Zero;

	int _Result = Natives.recogIdentifyMultiple(recog.Pointer, pixs.Pointer,   minh,   skipsplit, out pboxaPtr, out ppixaPtr, out ppixdbPtr,   debugsplit);
	

pboxa = null;
	; if (pboxaPtr != IntPtr.Zero){pboxa = new Boxa(pboxaPtr);}
ppixa = null;
	; if (ppixaPtr != IntPtr.Zero){ppixa = new Pixa(ppixaPtr);}
ppixdb = null;
	; if (ppixdbPtr != IntPtr.Zero){ppixdb = new Pix(ppixdbPtr);}


	return _Result;
}

// recogident.c (246, 1)
// recogSplitIntoCharacters(recog, pixs, minh, skipsplit, pboxa, ppixa, debug) as int
// recogSplitIntoCharacters(L_RECOG *, PIX *, l_int32, l_int32, BOXA **, PIXA **, l_int32) as l_ok
///  <summary>
/// (1) This can be given an image that has an arbitrary number
/// of text characters.  It optionally splits connected
/// components based on document image decoding in recogDecode().
/// The returned pixa includes the boxes from which the
/// (possibly split) components are extracted.<para/>
/// 
/// (2) After noise filtering, the resulting components are put in
/// row-major (2D) order, and the smaller of overlapping
/// components are removed if they satisfy conditions of
/// relative size and fractional overlap.<para/>
/// 
/// (3) Note that the splitting function uses unscaled templates
/// and does not bother returning the class results and scores.
/// These are more accurately found later using the scaled templates.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSplitIntoCharacters/*"/>
///  <param name="recog">[in] - </param>
///  <param name="pixs">[in] - 1 bpp, contains only mostly deskewed text</param>
///  <param name="minh">[in] - remove shorter components use 0 for default</param>
///  <param name="skipsplit">[in] - 1 to skip the splitting step</param>
///  <param name="pboxa">[out] - character bounding boxes</param>
///  <param name="ppixa">[out] - character images</param>
///  <param name="debug">[in] - 1 for results written to pixadb_split</param>
///   <returns>0 if OK, 1 on error or if no components are returned</returns>
public static int recogSplitIntoCharacters(
				  L_Recog recog, 
				  Pix pixs, 
				  int minh, 
				  int skipsplit, 
				 out Boxa pboxa, 
				 out Pixa ppixa, 
				 DebugOnOff debug){

	IntPtr pboxaPtr = IntPtr.Zero;
	IntPtr ppixaPtr = IntPtr.Zero;

	int _Result = Natives.recogSplitIntoCharacters(recog.Pointer, pixs.Pointer,   minh,   skipsplit, out pboxaPtr, out ppixaPtr,  (int) debug);
	

pboxa = null;
	; if (pboxaPtr != IntPtr.Zero){pboxa = new Boxa(pboxaPtr);}
ppixa = null;
	; if (ppixaPtr != IntPtr.Zero){ppixa = new Pixa(ppixaPtr);}


	return _Result;
}

// recogident.c (401, 1)
// recogCorrelationBestRow(recog, pixs, pboxa, pnascore, pnaindex, psachar, debug) as int
// recogCorrelationBestRow(L_RECOG *, PIX *, BOXA **, NUMA **, NUMA **, SARRAY **, l_int32) as l_ok
///  <summary>
/// (1) Supervises character matching for (in general) a c.c with
/// multiple touching characters.  Finds the best match greedily.
/// Rejects small parts that are left over after splitting.<para/>
/// 
/// (2) Matching is to the average, and without character scaling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCorrelationBestRow/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="pixs">[in] - typically of multiple touching characters, 1 bpp</param>
///  <param name="pboxa">[out] - bounding boxs of best fit character</param>
///  <param name="pnascore">[out][optional] - correlation scores</param>
///  <param name="pnaindex">[out][optional] - indices of classes</param>
///  <param name="psachar">[out][optional] - array of character strings</param>
///  <param name="debug">[in] - 1 for results written to pixadb_split</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogCorrelationBestRow(
				  L_Recog recog, 
				  Pix pixs, 
				 out Boxa pboxa, 
				out Numa pnascore, 
				out Numa pnaindex, 
				out Sarray psachar, 
				 DebugOnOff debug){

	IntPtr pboxaPtr = IntPtr.Zero;
	IntPtr pnascorePtr = IntPtr.Zero;
	IntPtr pnaindexPtr = IntPtr.Zero;
	IntPtr psacharPtr = IntPtr.Zero;

	int _Result = Natives.recogCorrelationBestRow(recog.Pointer, pixs.Pointer, out pboxaPtr, out pnascorePtr, out pnaindexPtr, out psacharPtr,  (int) debug);
	

pboxa = null;
	; if (pboxaPtr != IntPtr.Zero){pboxa = new Boxa(pboxaPtr);}
pnascore = null;
	; if (pnascorePtr != IntPtr.Zero){pnascore = new Numa(pnascorePtr);}
pnaindex = null;
	; if (pnaindexPtr != IntPtr.Zero){pnaindex = new Numa(pnaindexPtr);}
psachar = null;
	; if (psacharPtr != IntPtr.Zero){psachar = new Sarray(psacharPtr);}


	return _Result;
}

// recogident.c (583, 1)
// recogCorrelationBestChar(recog, pixs, pbox, pscore, pindex, pcharstr, ppixdb) as int
// recogCorrelationBestChar(L_RECOG *, PIX *, BOX **, l_float32 *, l_int32 *, char **, PIX **) as l_ok
///  <summary>
/// (1) Basic matching character splitter.  Finds the best match among
/// all templates to some region of the image.  This can result
/// in splitting the image into two parts.  This is "image decoding"
/// without dynamic programming, because we don't use a setwidth
/// and compute the best matching score for the entire image.<para/>
/// 
/// (2) Matching is to the average templates, without character scaling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCorrelationBestChar/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="pixs">[in] - can be of multiple touching characters, 1 bpp</param>
///  <param name="pbox">[out] - bounding box of best fit character</param>
///  <param name="pscore">[out] - correlation score</param>
///  <param name="pindex">[out][optional] - index of class</param>
///  <param name="pcharstr">[out][optional] - character string of class</param>
///  <param name="ppixdb">[out][optional] - debug pix showing input and best fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogCorrelationBestChar(
				  L_Recog recog, 
				  Pix pixs, 
				 out Box pbox, 
				 out Single pscore, 
				out int pindex, 
				out String[] pcharstr, 
				out Pix ppixdb){

	IntPtr pboxPtr = IntPtr.Zero;
	IntPtr pcharstrPtr = IntPtr.Zero;
	IntPtr ppixdbPtr = IntPtr.Zero;

	int _Result = Natives.recogCorrelationBestChar(recog.Pointer, pixs.Pointer, out pboxPtr, out  pscore, out  pindex, out  pcharstrPtr, out ppixdbPtr);
	

pbox = null;
	; if (pboxPtr != IntPtr.Zero){pbox = new Box(pboxPtr);}
pscore = 0f;
pindex = 0;
pcharstr = null;
ppixdb = null;
	; if (ppixdbPtr != IntPtr.Zero){ppixdb = new Pix(ppixdbPtr);}


	return _Result;
}

// recogident.c (878, 1)
// recogIdentifyPixa(recog, pixa, ppixdb) as int
// recogIdentifyPixa(L_RECOG *, PIXA *, PIX **) as l_ok
///  <summary>
/// (1) This should be called by recogIdentifyMuliple(), which
/// binarizes and splits characters before sending %pixa here.<para/>
/// 
/// (2) This calls recogIdentifyPix(), which does the same operation
/// on each pix in %pixa, and optionally returns the arrays
/// of results (scores, class index and character string)
/// for the best correlation match.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyPixa/*"/>
///  <param name="recog">[in] - </param>
///  <param name="pixa">[in] - of 1 bpp images to match</param>
///  <param name="ppixdb">[out][optional] - pix showing inputs and best fits</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogIdentifyPixa(
				  L_Recog recog, 
				  Pixa pixa, 
				out Pix ppixdb){

	IntPtr ppixdbPtr = IntPtr.Zero;

	int _Result = Natives.recogIdentifyPixa(recog.Pointer, pixa.Pointer, out ppixdbPtr);
	

ppixdb = null;
	; if (ppixdbPtr != IntPtr.Zero){ppixdb = new Pix(ppixdbPtr);}


	return _Result;
}

// recogident.c (971, 1)
// recogIdentifyPix(recog, pixs, ppixdb) as int
// recogIdentifyPix(L_RECOG *, PIX *, PIX **) as l_ok
///  <summary>
/// (1) Basic recognition function for a single character.<para/>
/// 
/// (2) If templ_use == L_USE_ALL_TEMPLATES, which is the default
/// situation, matching is attempted to every bitmap in the recog,
/// and the identify of the best match is returned.<para/>
/// 
/// (3) For finding outliers, templ_use == L_USE_AVERAGE_TEMPLATES, and
/// matching is only attemplted to the averaged bitmaps.  For this
/// case, the index of the bestsample is meaningless (0 is returned
/// if requested).<para/>
/// 
/// (4) The score is related to the confidence (probability of correct
/// identification), in that a higher score is correlated with
/// a higher probability.  However, the actual relation between
/// the correlation (score) and the probability is not known
/// we call this a "score" because "confidence" can be misinterpreted
/// as an actual probability.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogIdentifyPix/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="pixs">[in] - of a single character, 1 bpp</param>
///  <param name="ppixdb">[out][optional] - debug pix showing input and best fit</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogIdentifyPix(
				  L_Recog recog, 
				  Pix pixs, 
				out Pix ppixdb){

	IntPtr ppixdbPtr = IntPtr.Zero;

	int _Result = Natives.recogIdentifyPix(recog.Pointer, pixs.Pointer, out ppixdbPtr);
	

ppixdb = null;
	; if (ppixdbPtr != IntPtr.Zero){ppixdb = new Pix(ppixdbPtr);}


	return _Result;
}

// recogident.c (1120, 1)
// recogSkipIdentify(recog) as int
// recogSkipIdentify(L_RECOG *) as l_ok
///  <summary>
/// (1) This just writes a "dummy" result with 0 score and empty
/// string id into the rch.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSkipIdentify/*"/>
///  <param name="recog">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogSkipIdentify(
				  L_Recog recog){

	int _Result = Natives.recogSkipIdentify(recog.Pointer);
	



	return _Result;
}

// recogident.c (1168, 1)
// rchaDestroy(prcha) as Object
// rchaDestroy(L_RCHA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchaDestroy/*"/>
///  <param name="prcha">[in,out] - to be nulled</param>
public static void rchaDestroy(
				 ref L_Rcha prcha){

	IntPtr prchaPtr = IntPtr.Zero; 	if (prcha != null) {prchaPtr = prcha.Pointer;}

	Natives.rchaDestroy(ref prchaPtr);
	

prcha = null;
	; if (prchaPtr != IntPtr.Zero){prcha = new L_Rcha(prchaPtr);}


}

// recogident.c (1242, 1)
// rchDestroy(prch) as Object
// rchDestroy(L_RCH **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchDestroy/*"/>
///  <param name="prch">[in,out] - to be nulled</param>
public static void rchDestroy(
				 ref L_Rch prch){

	IntPtr prchPtr = IntPtr.Zero; 	if (prch != null) {prchPtr = prch.Pointer;}

	Natives.rchDestroy(ref prchPtr);
	

prch = null;
	; if (prchPtr != IntPtr.Zero){prch = new L_Rch(prchPtr);}


}

// recogident.c (1281, 1)
// rchaExtract(rcha, pnaindex, pnascore, psatext, pnasample, pnaxloc, pnayloc, pnawidth) as int
// rchaExtract(L_RCHA *, NUMA **, NUMA **, SARRAY **, NUMA **, NUMA **, NUMA **, NUMA **) as l_ok
///  <summary>
/// (1) This returns clones of the number and string arrays.  They must
/// be destroyed by the caller.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchaExtract/*"/>
///  <param name="rcha">[in] - </param>
///  <param name="pnaindex">[out][optional] - indices of best templates</param>
///  <param name="pnascore">[out][optional] - correl scores of best templates</param>
///  <param name="psatext">[out][optional] - character strings of best templates</param>
///  <param name="pnasample">[out][optional] - indices of best samples</param>
///  <param name="pnaxloc">[out][optional] - x-locations of templates</param>
///  <param name="pnayloc">[out][optional] - y-locations of templates</param>
///  <param name="pnawidth">[out][optional] - widths of best templates</param>
///   <returns>0 if OK, 1 on error</returns>
public static int rchaExtract(
				  L_Rcha rcha, 
				out Numa pnaindex, 
				out Numa pnascore, 
				out Sarray psatext, 
				out Numa pnasample, 
				out Numa pnaxloc, 
				out Numa pnayloc, 
				out Numa pnawidth){

	IntPtr pnaindexPtr = IntPtr.Zero;
	IntPtr pnascorePtr = IntPtr.Zero;
	IntPtr psatextPtr = IntPtr.Zero;
	IntPtr pnasamplePtr = IntPtr.Zero;
	IntPtr pnaxlocPtr = IntPtr.Zero;
	IntPtr pnaylocPtr = IntPtr.Zero;
	IntPtr pnawidthPtr = IntPtr.Zero;

	int _Result = Natives.rchaExtract(rcha.Pointer, out pnaindexPtr, out pnascorePtr, out psatextPtr, out pnasamplePtr, out pnaxlocPtr, out pnaylocPtr, out pnawidthPtr);
	

pnaindex = null;
	; if (pnaindexPtr != IntPtr.Zero){pnaindex = new Numa(pnaindexPtr);}
pnascore = null;
	; if (pnascorePtr != IntPtr.Zero){pnascore = new Numa(pnascorePtr);}
psatext = null;
	; if (psatextPtr != IntPtr.Zero){psatext = new Sarray(psatextPtr);}
pnasample = null;
	; if (pnasamplePtr != IntPtr.Zero){pnasample = new Numa(pnasamplePtr);}
pnaxloc = null;
	; if (pnaxlocPtr != IntPtr.Zero){pnaxloc = new Numa(pnaxlocPtr);}
pnayloc = null;
	; if (pnaylocPtr != IntPtr.Zero){pnayloc = new Numa(pnaylocPtr);}
pnawidth = null;
	; if (pnawidthPtr != IntPtr.Zero){pnawidth = new Numa(pnawidthPtr);}


	return _Result;
}

// recogident.c (1327, 1)
// rchExtract(rch, pindex, pscore, ptext, psample, pxloc, pyloc, pwidth) as int
// rchExtract(L_RCH *, l_int32 *, l_float32 *, char **, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/rchExtract/*"/>
///  <param name="rch">[in] - </param>
///  <param name="pindex">[out][optional] - index of best template</param>
///  <param name="pscore">[out][optional] - correlation score of best template</param>
///  <param name="ptext">[out][optional] - character string of best template</param>
///  <param name="psample">[out][optional] - index of best sample</param>
///  <param name="pxloc">[out][optional] - x-location of template</param>
///  <param name="pyloc">[out][optional] - y-location of template</param>
///  <param name="pwidth">[out][optional] - width of best template</param>
///   <returns>0 if OK, 1 on error</returns>
public static int rchExtract(
				  L_Rch rch, 
				out int pindex, 
				out Single pscore, 
				out String[] ptext, 
				out int psample, 
				out int pxloc, 
				out int pyloc, 
				out int pwidth){

	IntPtr ptextPtr = IntPtr.Zero;

	int _Result = Natives.rchExtract(rch.Pointer, out  pindex, out  pscore, out  ptextPtr, out  psample, out  pxloc, out  pyloc, out  pwidth);
	

pindex = 0;
pscore = 0f;
ptext = null;
psample = 0;
pxloc = 0;
pyloc = 0;
pwidth = 0;


	return _Result;
}

// recogident.c (1415, 1)
// recogProcessToIdentify(recog, pixs, pad) as Pix
// recogProcessToIdentify(L_RECOG *, PIX *, l_int32) as PIX *
///  <summary>
/// (1) This is a lightweight operation to insure that the input
/// image is 1 bpp, properly cropped, and padded on each side.
/// If bpp  is greater  1, the image is thresholded.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogProcessToIdentify/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="pixs">[in] - typ. single character, possibly d  is greater  1 and uncropped</param>
///  <param name="pad">[in] - extra pixels added to left and right sides</param>
///   <returns>pixd 1 bpp, clipped to foreground, or NULL if there are no fg pixels or on error.</returns>
public static Pix recogProcessToIdentify(
				  L_Recog recog, 
				  Pix pixs, 
				  int pad){

	IntPtr _Result = Natives.recogProcessToIdentify(recog.Pointer, pixs.Pointer,   pad);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// recogident.c (1628, 1)
// recogExtractNumbers(recog, boxas, scorethresh, spacethresh, pbaa, pnaa) as Sarray
// recogExtractNumbers(L_RECOG *, BOXA *, l_float32, l_int32, BOXAA **, NUMAA **) as SARRAY *
///  <summary>
/// (1) This extracts digit data after recogaIdentifyMultiple() or
/// lower-level identification has taken place.<para/>
/// 
/// (2) Each string in the returned sa contains a sequence of ascii
/// digits in a number.<para/>
/// 
/// (3) The horizontal distance between boxes (limited by %spacethresh)
/// is the negative of the horizontal overlap.<para/>
/// 
/// (4) Components with a score less than %scorethresh, which may
/// be hyphens or other small characters, will signal the
/// end of the current sequence of digits in the number.  A typical
/// value for %scorethresh is 0.60.<para/>
/// 
/// (5) We allow two digits to be combined if these conditions apply:
/// (a) the first is to the left of the second
/// (b) the second has a horizontal separation less than %spacethresh
/// (c) the vertical overlap greater or equal 0 (vertical separation  is smaller 0)
/// (d) both have a score that exceeds %scorethresh<para/>
/// 
/// (6) Each numa in the optionally returned naa contains the digit
/// scores of a number.  Each boxa in the optionally returned baa
/// contains the bounding boxes of the digits in the number.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogExtractNumbers/*"/>
///  <param name="recog">[in] - </param>
///  <param name="boxas">[in] - location of components</param>
///  <param name="scorethresh">[in] - min score for which we accept a component</param>
///  <param name="spacethresh">[in] - max horizontal distance allowed between digits, use -1 for default</param>
///  <param name="pbaa">[out][optional] - bounding boxes of identified numbers</param>
///  <param name="pnaa">[out][optional] - scores of identified digits</param>
///   <returns>sa of identified numbers, or NULL on error</returns>
public static Sarray recogExtractNumbers(
				  L_Recog recog, 
				  Boxa boxas, 
				  Single scorethresh, 
				  int spacethresh, 
				out Boxaa pbaa, 
				out Numaa pnaa){

	IntPtr pbaaPtr = IntPtr.Zero;
	IntPtr pnaaPtr = IntPtr.Zero;

	IntPtr _Result = Natives.recogExtractNumbers(recog.Pointer, boxas.Pointer,   scorethresh,   spacethresh, out pbaaPtr, out pnaaPtr);
	

pbaa = null;
	; if (pbaaPtr != IntPtr.Zero){pbaa = new Boxaa(pbaaPtr);}
pnaa = null;
	; if (pnaaPtr != IntPtr.Zero){pnaa = new Numaa(pnaaPtr);}

	if (_Result == IntPtr.Zero) {return null;}

	return  new Sarray(_Result);
}

// recogident.c (1761, 1)
// showExtractNumbers(pixs, sa, baa, naa, ppixdb) as Pixa
// showExtractNumbers(PIX *, SARRAY *, BOXAA *, NUMAA *, PIX **) as PIXA *
///  <summary>
/// (1) This is a debugging routine on digit identification e.g.:
/// recogIdentifyMultiple(recog, pixs, 0, 1, [and]boxa, NULL, NULL, 0)
/// sa = recogExtractNumbers(recog, boxa, 0.8, -1, [and]baa, [and]naa)
/// pixa = showExtractNumbers(pixs, sa, baa, naa, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/showExtractNumbers/*"/>
///  <param name="pixs">[in] - input 1 bpp image</param>
///  <param name="sa">[in] - recognized text strings</param>
///  <param name="baa">[in] - boxa array for location of characters in each string</param>
///  <param name="naa">[in] - numa array for scores of characters in each string</param>
///  <param name="ppixdb">[out][optional] - input pixs with identified chars outlined</param>
///   <returns>pixa   of identified strings with text and scores, or NULL on error</returns>
public static Pixa showExtractNumbers(
				  Pix pixs, 
				  Sarray sa, 
				  Boxaa baa, 
				  Numaa naa, 
				out Pix ppixdb){

	IntPtr ppixdbPtr = IntPtr.Zero;

	IntPtr _Result = Natives.showExtractNumbers(pixs.Pointer, sa.Pointer, baa.Pointer, naa.Pointer, out ppixdbPtr);
	

ppixdb = null;
	; if (ppixdbPtr != IntPtr.Zero){ppixdb = new Pix(ppixdbPtr);}

	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

}
