using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// classapp.c (96, 1)
// jbCorrelation(dirin, thresh, weight, components, rootname, firstpage, npages, renderflag) as int
// jbCorrelation(const char *, l_float32, l_float32, l_int32, const char *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) The images must be 1 bpp.  If they are not, you can convert
/// them using convertFilesTo1bpp().<para/>
/// 
/// (2) See prog/jbcorrelation for generating more output (e.g.,
/// for debugging)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbCorrelation/*"/>
///  <param name="dirin">[in] - directory of input images</param>
///  <param name="thresh">[in] - typically ~0.8</param>
///  <param name="weight">[in] - typically ~0.6</param>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="rootname">[in] - for output files</param>
///  <param name="firstpage">[in] - 0-based</param>
///  <param name="npages">[in] - use 0 for all pages in dirin</param>
///  <param name="renderflag">[in] - 1 to render from templates 0 to skip</param>
///   <returns>0 if OK, 1 on error</returns>
public static int jbCorrelation(
				 String dirin, 
				 Single thresh, 
				 Single weight, 
				 int components, 
				 String rootname, 
				 int firstpage, 
				 int npages, 
				 int renderflag){

if (dirin == null) {throw new ArgumentNullException  ("dirin cannot be Nothing");}
		if (rootname == null) {throw new ArgumentNullException  ("rootname cannot be Nothing");}
	int _Result = Natives.jbCorrelation(  dirin,   thresh,   weight,   components,   rootname,   firstpage,   npages,   renderflag);
	
	return _Result;
}

// classapp.c (178, 1)
// jbRankHaus(dirin, size, rank, components, rootname, firstpage, npages, renderflag) as int
// jbRankHaus(const char *, l_int32, l_float32, l_int32, const char *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) See prog/jbrankhaus for generating more output (e.g.,
/// for debugging)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbRankHaus/*"/>
///  <param name="dirin">[in] - directory of input images</param>
///  <param name="size">[in] - of Sel used for dilation typ. 2</param>
///  <param name="rank">[in] - rank value of match typ. 0.97</param>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="rootname">[in] - for output files</param>
///  <param name="firstpage">[in] - 0-based</param>
///  <param name="npages">[in] - use 0 for all pages in dirin</param>
///  <param name="renderflag">[in] - 1 to render from templates 0 to skip</param>
///   <returns>0 if OK, 1 on error</returns>
public static int jbRankHaus(
				 String dirin, 
				 int size, 
				 Single rank, 
				 int components, 
				 String rootname, 
				 int firstpage, 
				 int npages, 
				 int renderflag){

if (dirin == null) {throw new ArgumentNullException  ("dirin cannot be Nothing");}
		if (rootname == null) {throw new ArgumentNullException  ("rootname cannot be Nothing");}
	int _Result = Natives.jbRankHaus(  dirin,   size,   rank,   components,   rootname,   firstpage,   npages,   renderflag);
	
	return _Result;
}

// classapp.c (266, 1)
// jbWordsInTextlines(dirin, reduction, maxwidth, maxheight, thresh, weight, pnatl, firstpage, npages) as JbClasser
// jbWordsInTextlines(const char *, l_int32, l_int32, l_int32, l_float32, l_float32, NUMA **, l_int32, l_int32) as JBCLASSER *
///  <summary>
/// (1) This is a high-level function.  See prog/jbwords for example
/// of usage.<para/>
/// 
/// (2) Typically, use input of 75 - 150 ppi for finding words.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbWordsInTextlines/*"/>
///  <param name="dirin">[in] - directory of input pages</param>
///  <param name="reduction">[in] - 1 for full res 2 for half-res</param>
///  <param name="maxwidth">[in] - of word mask components, to be kept</param>
///  <param name="maxheight">[in] - of word mask components, to be kept</param>
///  <param name="thresh">[in] - on correlation 0.80 is reasonable</param>
///  <param name="weight">[in] - for handling thick text 0.6 is reasonable</param>
///  <param name="pnatl">[out] - numa with textline index for each component</param>
///  <param name="firstpage">[in] - 0-based</param>
///  <param name="npages">[in] - use 0 for all pages in dirin</param>
///   <returns>classer for the set of pages</returns>
public static JbClasser jbWordsInTextlines(
				 String dirin, 
				 int reduction, 
				 int maxwidth, 
				 int maxheight, 
				 Single thresh, 
				 Single weight, 
				out Numa pnatl, 
				 int firstpage, 
				 int npages){

if (dirin == null) {throw new ArgumentNullException  ("dirin cannot be Nothing");}
if (reduction < 2 || reduction > 16){   throw new ArgumentException ("1 for full res 2 for half-res");}
	IntPtr pnatlPtr = IntPtr.Zero;

	IntPtr _Result = Natives.jbWordsInTextlines(  dirin,   reduction,   maxwidth,   maxheight,   thresh,   weight, out pnatlPtr,   firstpage,   npages);
	
	if (pnatlPtr == IntPtr.Zero) {pnatl = null;} else { pnatl = new Numa(pnatlPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbClasser(_Result);
}

// classapp.c (378, 1)
// pixGetWordsInTextlines(pixs, minwidth, minheight, maxwidth, maxheight, pboxad, ppixad, pnai) as int
// pixGetWordsInTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, PIXA **, NUMA **) as l_ok
///  <summary>
/// (1) The input should be at a resolution of between 75 and 150 ppi.<para/>
/// 
/// (2) The four size constraints on saved components are all
/// scaled by %reduction.<para/>
/// 
/// (3) The result are word images (and their b.b.), extracted in
/// textline order, at either full res or 2x reduction,
/// and with a numa giving the textline index for each word.<para/>
/// 
/// (4) The pixa and boxa interfaces should make this type of
/// application simple to put together.  The steps are:
/// ~ generate first estimate of word masks
/// ~ get b.b. of these, and remove the small and big ones
/// ~ extract pixa of the word images, using the b.b.
/// ~ sort actual word images in textline order (2d)
/// ~ flatten them to a pixa (1d), saving the textline index
/// for each pix<para/>
/// 
/// (5) In an actual application, it may be desirable to pre-filter
/// the input image to remove large components, to extract
/// single columns of text, and to deskew them.  For example,
/// to remove both large components and small noisy components
/// that can interfere with the statistics used to estimate
/// parameters for segmenting by words, but still retain text lines,
/// the following image preprocessing can be done:
/// Pix pixt = pixMorphSequence(pixs, "c40.1", 0)
/// Pix pixf = pixSelectBySize(pixt, 0, 60, 8,
/// L_SELECT_HEIGHT, L_SELECT_IF_LT, NULL)
/// pixAnd(pixf, pixf, pixs)  // the filtered image
/// The closing turns text lines into long blobs, but does not
/// significantly increase their height.  But if there are many
/// small connected components in a dense texture, this is likely
/// to generate tall components that will be eliminated in pixf.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWordsInTextlines/*"/>
///  <param name="pixs">[in] - 1 bpp, typ. 75 - 150 ppi</param>
///  <param name="minwidth">[in] - of saved components smaller are discarded</param>
///  <param name="minheight">[in] - of saved components smaller are discarded</param>
///  <param name="maxwidth">[in] - of saved components larger are discarded</param>
///  <param name="maxheight">[in] - of saved components larger are discarded</param>
///  <param name="pboxad">[out] - word boxes sorted in textline line order</param>
///  <param name="ppixad">[out] - word images sorted in textline line order</param>
///  <param name="pnai">[out] - index of textline for each word</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetWordsInTextlines(
				 Pix pixs, 
				 int minwidth, 
				 int minheight, 
				 int maxwidth, 
				 int maxheight, 
				out Boxa pboxad, 
				out Pixa ppixad, 
				out Numa pnai){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pboxadPtr = IntPtr.Zero;
	IntPtr ppixadPtr = IntPtr.Zero;
	IntPtr pnaiPtr = IntPtr.Zero;

	int _Result = Natives.pixGetWordsInTextlines(pixs.Pointer,   minwidth,   minheight,   maxwidth,   maxheight, out pboxadPtr, out ppixadPtr, out pnaiPtr);
	
	if (pboxadPtr == IntPtr.Zero) {pboxad = null;} else { pboxad = new Boxa(pboxadPtr); };
	if (ppixadPtr == IntPtr.Zero) {ppixad = null;} else { ppixad = new Pixa(ppixadPtr); };
	if (pnaiPtr == IntPtr.Zero) {pnai = null;} else { pnai = new Numa(pnaiPtr); };
	return _Result;
}

// classapp.c (453, 1)
// pixGetWordBoxesInTextlines(pixs, minwidth, minheight, maxwidth, maxheight, pboxad, pnai) as int
// pixGetWordBoxesInTextlines(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, NUMA **) as l_ok
///  <summary>
/// (1) The input should be at a resolution of between 75 and 150 ppi.<para/>
/// 
/// (2) This is a special version of pixGetWordsInTextlines(), that
/// just finds the word boxes in line order, with a numa
/// giving the textline index for each word.
/// See pixGetWordsInTextlines() for more details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWordBoxesInTextlines/*"/>
///  <param name="pixs">[in] - 1 bpp, typ. 300 ppi</param>
///  <param name="minwidth">[in] - of saved components smaller are discarded</param>
///  <param name="minheight">[in] - of saved components smaller are discarded</param>
///  <param name="maxwidth">[in] - of saved components larger are discarded</param>
///  <param name="maxheight">[in] - of saved components larger are discarded</param>
///  <param name="pboxad">[out] - word boxes sorted in textline line order</param>
///  <param name="pnai">[out][optional] - index of textline for each word</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetWordBoxesInTextlines(
				 Pix pixs, 
				 int minwidth, 
				 int minheight, 
				 int maxwidth, 
				 int maxheight, 
				out Boxa pboxad, 
				out Numa pnai){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pboxadPtr = IntPtr.Zero;
	IntPtr pnaiPtr = IntPtr.Zero;

	int _Result = Natives.pixGetWordBoxesInTextlines(pixs.Pointer,   minwidth,   minheight,   maxwidth,   maxheight, out pboxadPtr, out pnaiPtr);
	
	if (pboxadPtr == IntPtr.Zero) {pboxad = null;} else { pboxad = new Boxa(pboxadPtr); };
	if (pnaiPtr == IntPtr.Zero) {pnai = null;} else { pnai = new Numa(pnaiPtr); };
	return _Result;
}

// classapp.c (515, 1)
// boxaExtractSortedPattern(boxa, na) as Numaa
// boxaExtractSortedPattern(BOXA *, NUMA *) as NUMAA *
///  <summary>
/// (1) The input is expected to come from pixGetWordBoxesInTextlines().<para/>
/// 
/// (2) Each numa in the output consists of an average y coordinate
/// of the first box in the textline, followed by pairs of
/// x coordinates representing the left and right edges of each
/// of the boxes in the textline.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtractSortedPattern/*"/>
///  <param name="boxa">[in] - typ. of word bounding boxes, in textline order</param>
///  <param name="na">[in] - index of textline for each box in boxa</param>
///   <returns>naa NUMAA, where each numa represents one textline, or NULL on error</returns>
public static Numaa boxaExtractSortedPattern(
				 Boxa boxa, 
				 Numa na){

if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.boxaExtractSortedPattern(boxa.Pointer, na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numaa(_Result);
}

// classapp.c (603, 1)
// numaaCompareImagesByBoxes(naa1, naa2, nperline, nreq, maxshiftx, maxshifty, delx, dely, psame, debugflag) as int
// numaaCompareImagesByBoxes(NUMAA *, NUMAA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32) as l_ok
///  <summary>
/// (1) Each input numaa describes a set of sorted bounding boxes
/// (sorted by textline and, within each textline, from
/// left to right) in the images from which they are derived.
/// See boxaExtractSortedPattern() for a description of the data
/// format in each of the input numaa.<para/>
/// 
/// (2) This function does an alignment between the input
/// descriptions of bounding boxes for two images. The
/// input parameter %nperline specifies the number of boxes
/// to consider in each line when testing for a match, and
/// %nreq is the required number of lines that must be well-aligned
/// to get a match.<para/>
/// 
/// (3) Testing by alignment has 3 steps:
/// (a) Generating the location of word bounding boxes from the
/// images (prior to calling this function).
/// (b) Listing all possible pairs of aligned rows, based on
/// tolerances in horizontal and vertical positions of
/// the boxes.  Specifically, all pairs of rows are enumerated
/// whose first %nperline boxes can be brought into close
/// alignment, based on the delx parameter for boxes in the
/// line and within the overall the %maxshiftx and %maxshifty
/// constraints.
/// (c) Each pair, starting with the first, is used to search
/// for a set of %nreq - 1 other pairs that can all be aligned
/// with a difference in global translation of not more
/// than (%delx, %dely).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaaCompareImagesByBoxes/*"/>
///  <param name="naa1">[in] - for image 1, formatted by boxaExtractSortedPattern()</param>
///  <param name="naa2">[in] - ditto for image 2</param>
///  <param name="nperline">[in] - number of box regions to be used in each textline</param>
///  <param name="nreq">[in] - number of complete row matches required</param>
///  <param name="maxshiftx">[in] - max allowed x shift between two patterns, in pixels</param>
///  <param name="maxshifty">[in] - max allowed y shift between two patterns, in pixels</param>
///  <param name="delx">[in] - max allowed difference in x data, after alignment</param>
///  <param name="dely">[in] - max allowed difference in y data, after alignment</param>
///  <param name="psame">[out] - 1 if %nreq row matches are found 0 otherwise</param>
///  <param name="debugflag">[in] - 1 for debug output</param>
///   <returns>0 if OK, 1 on error</returns>
public static int numaaCompareImagesByBoxes(
				 Numaa naa1, 
				 Numaa naa2, 
				 int nperline, 
				 int nreq, 
				 int maxshiftx, 
				 int maxshifty, 
				 int delx, 
				 int dely, 
				out int psame, 
				 int debugflag){

if (naa1 == null) {throw new ArgumentNullException  ("naa1 cannot be Nothing");}
		if (naa2 == null) {throw new ArgumentNullException  ("naa2 cannot be Nothing");}
	int _Result = Natives.numaaCompareImagesByBoxes(naa1.Pointer, naa2.Pointer,   nperline,   nreq,   maxshiftx,   maxshifty,   delx,   dely, out  psame,   debugflag);
	
	return _Result;
}


}
}
