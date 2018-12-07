using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// jbclass.c (283, 1)
// jbRankHausInit(components, maxwidth, maxheight, size, rank) as JbClasser
// jbRankHausInit(l_int32, l_int32, l_int32, l_int32, l_float32) as JBCLASSER *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbRankHausInit/*"/>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="maxwidth">[in] - of component use 0 for default</param>
///  <param name="maxheight">[in] - of component use 0 for default</param>
///  <param name="size">[in] - of square structuring element 2, representing 2x2 sel, is necessary for reasonable accuracy of small components combine this with rank ~ 0.97 to avoid undue class expansion</param>
///  <param name="rank">[in] - rank val of match, each way in [0.5 - 1.0] when using size = 2, 0.97 is a reasonable value</param>
///   <returns>jbclasser if OK NULL on error</returns>
public static JbClasser jbRankHausInit(
				 int components, 
				 int maxwidth, 
				 int maxheight, 
				 int size, 
				 Single rank){

	IntPtr _Result = Natives.jbRankHausInit(  components,   maxwidth,   maxheight,   size,   rank);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbClasser(_Result);
}

// jbclass.c (344, 1)
// jbCorrelationInit(components, maxwidth, maxheight, thresh, weightfactor) as JbClasser
// jbCorrelationInit(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
///  <summary>
/// (1) For scanned text, suggested input values are:
/// thresh ~ [0.8 - 0.85]
/// weightfactor ~ [0.5 - 0.6]<para/>
/// 
/// (2) For electronically generated fonts (e.g., rasterized pdf),
/// a very high thresh (e.g., 0.95) will not cause a significant
/// increase in the number of classes.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbCorrelationInit/*"/>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="maxwidth">[in] - of component use 0 for default</param>
///  <param name="maxheight">[in] - of component use 0 for default</param>
///  <param name="thresh">[in] - value for correlation score: in [0.4 - 0.98]</param>
///  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
///   <returns>jbclasser if OK NULL on error</returns>
public static JbClasser jbCorrelationInit(
				 int components, 
				 int maxwidth, 
				 int maxheight, 
				 Single thresh, 
				 Single weightfactor){

	IntPtr _Result = Natives.jbCorrelationInit(  components,   maxwidth,   maxheight,   thresh,   weightfactor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbClasser(_Result);
}

// jbclass.c (371, 1)
// jbCorrelationInitWithoutComponents(components, maxwidth, maxheight, thresh, weightfactor) as JbClasser
// jbCorrelationInitWithoutComponents(l_int32, l_int32, l_int32, l_float32, l_float32) as JBCLASSER *
///  <summary>
/// Acts the same as jbCorrelationInit(), but the resulting
/// object doesn't keep a list of all the components.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbCorrelationInitWithoutComponents/*"/>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="maxwidth">[in] - of component use 0 for default</param>
///  <param name="maxheight">[in] - of component use 0 for default</param>
///  <param name="thresh">[in] - value  for correlation score: in [0.4 - 0.98]</param>
///  <param name="weightfactor">[in] - corrects thresh for thick characters [0.0 - 1.0]</param>
///   <returns>jbclasser if OK NULL on error</returns>
public static JbClasser jbCorrelationInitWithoutComponents(
				 int components, 
				 int maxwidth, 
				 int maxheight, 
				 Single thresh, 
				 Single weightfactor){

	IntPtr _Result = Natives.jbCorrelationInitWithoutComponents(  components,   maxwidth,   maxheight,   thresh,   weightfactor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbClasser(_Result);
}

// jbclass.c (444, 1)
// jbAddPages(classer, safiles) as int
// jbAddPages(JBCLASSER *, SARRAY *) as l_ok
///  <summary>
/// (1) jbclasser makes a copy of the array of file names.<para/>
/// 
/// (2) The caller is still responsible for destroying the input array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbAddPages/*"/>
///  <param name="safiles">[in] - of page image file names</param>
///   <returns>0 if OK 1 on error</returns>
public static int jbAddPages(
				 JbClasser classer, 
				 Sarray safiles){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (safiles == null) {throw new ArgumentNullException  ("safiles cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbAddPages(classer.Pointer, safiles.Pointer);
	
	return _Result;
}

// jbclass.c (486, 1)
// jbAddPage(classer, pixs) as int
// jbAddPage(JBCLASSER *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbAddPage/*"/>
///  <param name="pixs">[in] - input page</param>
///   <returns>0 if OK 1 on error</returns>
public static int jbAddPage(
				 JbClasser classer, 
				 Pix pixs){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbAddPage(classer.Pointer, pixs.Pointer);
	
	return _Result;
}

// jbclass.c (531, 1)
// jbAddPageComponents(classer, pixs, boxas, pixas) as int
// jbAddPageComponents(JBCLASSER *, PIX *, BOXA *, PIXA *) as l_ok
///  <summary>
/// (1) If there are no components on the page, we don't require input
/// of empty boxas or pixas, although that's the typical situation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbAddPageComponents/*"/>
///  <param name="pixs">[in] - input page</param>
///  <param name="boxas">[in] - b.b. of components for this page</param>
///  <param name="pixas">[in] - components for this page</param>
///   <returns>0 if OK 1 on error</returns>
public static int jbAddPageComponents(
				 JbClasser classer, 
				 Pix pixs, 
				 Boxa boxas, 
				 Pixa pixas){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}
		if (pixas == null) {throw new ArgumentNullException  ("pixas cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbAddPageComponents(classer.Pointer, pixs.Pointer, boxas.Pointer, pixas.Pointer);
	
	return _Result;
}

// jbclass.c (591, 1)
// jbClassifyRankHaus(classer, boxa, pixas) as int
// jbClassifyRankHaus(JBCLASSER *, BOXA *, PIXA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbClassifyRankHaus/*"/>
///  <param name="boxa">[in] - new components for classification</param>
///  <param name="pixas">[in] - new components for classification</param>
///   <returns>0 if OK 1 on error</returns>
public static int jbClassifyRankHaus(
				 JbClasser classer, 
				 Boxa boxa, 
				 Pixa pixas){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
		if (pixas == null) {throw new ArgumentNullException  ("pixas cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbClassifyRankHaus(classer.Pointer, boxa.Pointer, pixas.Pointer);
	
	return _Result;
}

// jbclass.c (845, 1)
// pixHaustest(pix1, pix2, pix3, pix4, delx, dely, maxdiffw, maxdiffh) as int
// pixHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32) as l_int32
///  <summary>
/// We check first that the two pix are roughly
/// the same size.  Only if they meet that criterion do
/// we compare the bitmaps.  The Hausdorff is a 2-way
/// check.  The centroid difference is used to align the two
/// images to the nearest integer for each of the checks.
/// These check that the dilated image of one contains
/// ALL the pixels of the undilated image of the other.
/// Checks are done in both direction.  A single pixel not
/// contained in either direction results in failure of the test.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHaustest/*"/>
///  <param name="pix1">[in] - new pix, not dilated</param>
///  <param name="pix2">[in] - new pix, dilated</param>
///  <param name="pix3">[in] - exemplar pix, not dilated</param>
///  <param name="pix4">[in] - exemplar pix, dilated</param>
///  <param name="delx">[in] - x comp of centroid difference</param>
///  <param name="dely">[in] - y comp of centroid difference</param>
///  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
///  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
///   <returns>0 FALSE) if no match, 1 (TRUE if the new pix is in the same class as the exemplar.</returns>
public static int pixHaustest(
				 Pix pix1, 
				 Pix pix2, 
				 Pix pix3, 
				 Pix pix4, 
				 Single delx, 
				 Single dely, 
				 int maxdiffw, 
				 int maxdiffh){

if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}
		if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}
		if (pix3 == null) {throw new ArgumentNullException  ("pix3 cannot be Nothing");}
		if (pix4 == null) {throw new ArgumentNullException  ("pix4 cannot be Nothing");}
	int _Result = Natives.pixHaustest(pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer,   delx,   dely,   maxdiffw,   maxdiffh);
	
	return _Result;
}

// jbclass.c (943, 1)
// pixRankHaustest(pix1, pix2, pix3, pix4, delx, dely, maxdiffw, maxdiffh, area1, area3, rank, tab8) as int
// pixRankHaustest(PIX *, PIX *, PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32 *) as l_int32
///  <summary>
/// We check first that the two pix are roughly
/// the same size.  Only if they meet that criterion do
/// we compare the bitmaps.  We convert the rank value to
/// a number of pixels by multiplying the rank fraction by the number
/// of pixels in the undilated image.  The Hausdorff is a 2-way
/// check.  The centroid difference is used to align the two
/// images to the nearest integer for each of the checks.
/// The rank hausdorff checks that the dilated image of one
/// contains the rank fraction of the pixels of the undilated
/// image of the other. Checks are done in both direction.
/// Failure of the test in either direction results in failure
/// of the test.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRankHaustest/*"/>
///  <param name="pix1">[in] - new pix, not dilated</param>
///  <param name="pix2">[in] - new pix, dilated</param>
///  <param name="pix3">[in] - exemplar pix, not dilated</param>
///  <param name="pix4">[in] - exemplar pix, dilated</param>
///  <param name="delx">[in] - x comp of centroid difference</param>
///  <param name="dely">[in] - y comp of centroid difference</param>
///  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
///  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
///  <param name="area1">[in] - fg pixels in pix1</param>
///  <param name="area3">[in] - fg pixels in pix3</param>
///  <param name="rank">[in] - rank value of test, each way</param>
///  <param name="tab8">[in] - table of pixel sums for byte</param>
///   <returns>0 FALSE) if no match, 1 (TRUE if the new pix is in the same class as the exemplar.</returns>
public static int pixRankHaustest(
				 Pix pix1, 
				 Pix pix2, 
				 Pix pix3, 
				 Pix pix4, 
				 Single delx, 
				 Single dely, 
				 int maxdiffw, 
				 int maxdiffh, 
				 int area1, 
				 int area3, 
				 Single rank, 
				 int[] tab8){

if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}
		if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}
		if (pix3 == null) {throw new ArgumentNullException  ("pix3 cannot be Nothing");}
		if (pix4 == null) {throw new ArgumentNullException  ("pix4 cannot be Nothing");}
		if (tab8 == null) {throw new ArgumentNullException  ("tab8 cannot be Nothing");}
	int _Result = Natives.pixRankHaustest(pix1.Pointer, pix2.Pointer, pix3.Pointer, pix4.Pointer,   delx,   dely,   maxdiffw,   maxdiffh,   area1,   area3,   rank,   tab8);
	
	return _Result;
}

// jbclass.c (1030, 1)
// jbClassifyCorrelation(classer, boxa, pixas) as int
// jbClassifyCorrelation(JBCLASSER *, BOXA *, PIXA *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbClassifyCorrelation/*"/>
///  <param name="boxa">[in] - new components for classification</param>
///  <param name="pixas">[in] - new components for classification</param>
///   <returns>0 if OK 1 on error</returns>
public static int jbClassifyCorrelation(
				 JbClasser classer, 
				 Boxa boxa, 
				 Pixa pixas){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
		if (pixas == null) {throw new ArgumentNullException  ("pixas cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbClassifyCorrelation(classer.Pointer, boxa.Pointer, pixas.Pointer);
	
	return _Result;
}

// jbclass.c (1312, 1)
// jbGetComponents(pixs, components, maxwidth, maxheight, pboxad, ppixad) as int
// jbGetComponents(PIX *, l_int32, l_int32, l_int32, BOXA **, PIXA **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbGetComponents/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///  <param name="maxwidth">[in] - of saved components larger are discarded</param>
///  <param name="maxheight">[in] - of saved components larger are discarded</param>
///   <returns>0 if OK, 1 on error</returns>
public static int jbGetComponents(
				 Pix pixs, 
				 int components, 
				 int maxwidth, 
				 int maxheight, 
				 Boxa pboxad, 
				 Pixa ppixad){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pboxad == null) {throw new ArgumentNullException  ("pboxad cannot be Nothing");}
		if (ppixad == null) {throw new ArgumentNullException  ("ppixad cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr pboxadPtr = IntPtr.Zero; 	if (pboxad != null) {pboxadPtr = pboxad.Pointer;}
	IntPtr ppixadPtr = IntPtr.Zero; 	if (ppixad != null) {ppixadPtr = ppixad.Pointer;}

	int _Result = Natives.jbGetComponents(pixs.Pointer,   components,   maxwidth,   maxheight, pboxadPtr, ppixadPtr);
	
	return _Result;
}

// jbclass.c (1454, 1)
// pixWordMaskByDilation(pixs, ppixm, psize, pixadb) as int
// pixWordMaskByDilation(PIX *, PIX **, l_int32 *, PIXA *) as l_ok
///  <summary>
/// (1) This gives an estimate of the word masks.  See
/// pixWordBoxesByDilation() for further filtering of the word boxes.<para/>
/// 
/// (2) The resolution should be between 75 and 150 ppi, and the optimal
/// dilation will be between 3 and 10.<para/>
/// 
/// (3) A good size for dilating to get word masks is optionally returned.<para/>
/// 
/// (4) Typically, the number of c.c. reduced with each successive
/// dilation (stored in nadiff) decreases quickly to a minimum
/// (where the characters in a word are joined), and then
/// increases again as the smaller number of words are joined.
/// For the typical case, you can then look for this minimum
/// and dilate to get the word mask.  However, there are many
/// cases where the function is not so simple. For example, if the
/// pix has been upscaled 2x, the nadiff function oscillates, with
/// every other value being zero!  And for some images it tails
/// off without a clear minimum to indicate where to break.
/// So a more simple and robust method is to find the dilation
/// where the initial number of c.c. has been reduced by some
/// fraction (we use a 70% reduction).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWordMaskByDilation/*"/>
///  <param name="pixs">[in] - 1 bpp typ. at 75 to 150 ppi</param>
///  <param name="psize">[out][optional] - size of good horizontal dilation</param>
///  <param name="pixadb">[out][optional] - debug: pixa of intermediate steps</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWordMaskByDilation(
				 Pix pixs, 
				 Pix ppixm, 
				out int psize, 
				out Pixa pixadb){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (ppixm == null) {throw new ArgumentNullException  ("ppixm cannot be Nothing");}
	IntPtr ppixmPtr = IntPtr.Zero; 	if (ppixm != null) {ppixmPtr = ppixm.Pointer;}
	IntPtr pixadbPtr = IntPtr.Zero;

	int _Result = Natives.pixWordMaskByDilation(pixs.Pointer, ppixmPtr, out  psize, out pixadbPtr);
	
	if (pixadbPtr == IntPtr.Zero) {pixadb = null;} else { pixadb = new Pixa(pixadbPtr); };
	return _Result;
}

// jbclass.c (1597, 1)
// pixWordBoxesByDilation(pixs, minwidth, minheight, maxwidth, maxheight, pboxa, psize, pixadb) as int
// pixWordBoxesByDilation(PIX *, l_int32, l_int32, l_int32, l_int32, BOXA **, l_int32 *, PIXA *) as l_ok
///  <summary>
/// (1) Returns a pruned set of word boxes.<para/>
/// 
/// (2) See pixWordMaskByDilation().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWordBoxesByDilation/*"/>
///  <param name="pixs">[in] - 1 bpp typ. 75 - 200 ppi</param>
///  <param name="minwidth">[in] - saved components smaller are discarded</param>
///  <param name="minheight">[in] - saved components smaller are discarded</param>
///  <param name="maxwidth">[in] - saved components larger are discarded</param>
///  <param name="maxheight">[in] - saved components larger are discarded</param>
///  <param name="pboxa">[out] - of dilated word mask</param>
///  <param name="psize">[out][optional] - size of good horizontal dilation</param>
///  <param name="pixadb">[out][optional] - debug: pixa of intermediate steps</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWordBoxesByDilation(
				 Pix pixs, 
				 int minwidth, 
				 int minheight, 
				 int maxwidth, 
				 int maxheight, 
				out Boxa pboxa, 
				out int psize, 
				out Pixa pixadb){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pboxaPtr = IntPtr.Zero;
	IntPtr pixadbPtr = IntPtr.Zero;

	int _Result = Natives.pixWordBoxesByDilation(pixs.Pointer,   minwidth,   minheight,   maxwidth,   maxheight, out pboxaPtr, out  psize, out pixadbPtr);
	
	if (pboxaPtr == IntPtr.Zero) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };
	if (pixadbPtr == IntPtr.Zero) {pixadb = null;} else { pixadb = new Pixa(pixadbPtr); };
	return _Result;
}

// jbclass.c (1659, 1)
// jbAccumulateComposites(pixaa, pna, pptat) as Pixa
// jbAccumulateComposites(PIXAA *, NUMA **, PTA **) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbAccumulateComposites/*"/>
///  <param name="pixaa">[in] - one pixa for each class</param>
///  <param name="pptat">[out] - centroids of bordered composites</param>
///   <returns>pixad accumulated sum of samples in each class, or NULL on error</returns>
public static Pixa jbAccumulateComposites(
				 Pixaa pixaa, 
				 Numa pna, 
				out Pta pptat){

if (pixaa == null) {throw new ArgumentNullException  ("pixaa cannot be Nothing");}
		if (pna == null) {throw new ArgumentNullException  ("pna cannot be Nothing");}
	IntPtr pnaPtr = IntPtr.Zero; 	if (pna != null) {pnaPtr = pna.Pointer;}
	IntPtr pptatPtr = IntPtr.Zero;

	IntPtr _Result = Natives.jbAccumulateComposites(pixaa.Pointer, pnaPtr, out pptatPtr);
	
	if (pptatPtr == IntPtr.Zero) {pptat = null;} else { pptat = new Pta(pptatPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// jbclass.c (1749, 1)
// jbTemplatesFromComposites(pixac, na) as Pixa
// jbTemplatesFromComposites(PIXA *, NUMA *) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbTemplatesFromComposites/*"/>
///  <param name="pixac">[in] - one pix of composites for each class</param>
///  <param name="na">[in] - number of samples used for each class composite</param>
///   <returns>pixad 8 bpp templates for each class, or NULL on error</returns>
public static Pixa jbTemplatesFromComposites(
				 Pixa pixac, 
				 Numa na){

if (pixac == null) {throw new ArgumentNullException  ("pixac cannot be Nothing");}
		if (na == null) {throw new ArgumentNullException  ("na cannot be Nothing");}
	IntPtr _Result = Natives.jbTemplatesFromComposites(pixac.Pointer, na.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// jbclass.c (1794, 1)
// jbClasserCreate(method, components) as JbClasser
// jbClasserCreate(l_int32, l_int32) as JBCLASSER *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbClasserCreate/*"/>
///  <param name="method">[in] - JB_RANKHAUS, JB_CORRELATION</param>
///  <param name="components">[in] - JB_CONN_COMPS, JB_CHARACTERS, JB_WORDS</param>
///   <returns>jbclasser, or NULL on error</returns>
public static JbClasser jbClasserCreate(
				 int method, 
				 int components){

	IntPtr _Result = Natives.jbClasserCreate(  method,   components);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbClasser(_Result);
}

// jbclass.c (1832, 1)
// jbClasserDestroy(pclasser) as Object
// jbClasserDestroy(JBCLASSER **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbClasserDestroy/*"/>
public static void jbClasserDestroy(
				 JbClasser pclasser){

if (pclasser == null) {throw new ArgumentNullException  ("pclasser cannot be Nothing");}
	IntPtr pclasserPtr = IntPtr.Zero; 	if (pclasser != null) {pclasserPtr = pclasser.Pointer;}

	Natives.jbClasserDestroy(pclasserPtr);
	
}

// jbclass.c (1882, 1)
// jbDataSave(classer) as JbData
// jbDataSave(JBCLASSER *) as JBDATA *
///  <summary>
/// (1) This routine stores the jbig2-type data required for
/// generating a lossy jbig2 version of the image.
/// It can be losslessly written to (and read from) two files.<para/>
/// 
/// (2) It generates and stores the mosaic of templates.<para/>
/// 
/// (3) It clones the Numa and Pta arrays, so these must all
/// be destroyed by the caller.<para/>
/// 
/// (4) Input 0 to use the default values for latticew and/or latticeh,
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbDataSave/*"/>
///   <returns>jbdata, or NULL on error</returns>
public static JbData jbDataSave(
				 JbClasser classer){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	IntPtr _Result = Natives.jbDataSave(classer.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbData(_Result);
}

// jbclass.c (1922, 1)
// jbDataDestroy(pdata) as Object
// jbDataDestroy(JBDATA **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbDataDestroy/*"/>
public static void jbDataDestroy(
				 JbData pdata){

if (pdata == null) {throw new ArgumentNullException  ("pdata cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero; 	if (pdata != null) {pdataPtr = pdata.Pointer;}

	Natives.jbDataDestroy(pdataPtr);
	
}

// jbclass.c (1954, 1)
// jbDataWrite(rootout, jbdata) as int
// jbDataWrite(const char *, JBDATA *) as l_ok
///  <summary>
/// (1) Serialization function that writes data in jbdata to file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbDataWrite/*"/>
///  <param name="jbdata">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int jbDataWrite(
				 String rootout, 
				 JbData jbdata){

if (rootout == null) {throw new ArgumentNullException  ("rootout cannot be Nothing");}
		if (jbdata == null) {throw new ArgumentNullException  ("jbdata cannot be Nothing");}
	int _Result = Natives.jbDataWrite(  rootout, jbdata.Pointer);
	
	return _Result;
}

// jbclass.c (2014, 1)
// jbDataRead(rootname) as JbData
// jbDataRead(const char *) as JBDATA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbDataRead/*"/>
///  <param name="rootname">[in] - for template and data files</param>
///   <returns>jbdata, or NULL on error</returns>
public static JbData jbDataRead(
				 String rootname){

if (rootname == null) {throw new ArgumentNullException  ("rootname cannot be Nothing");}
	IntPtr _Result = Natives.jbDataRead(  rootname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new JbData(_Result);
}

// jbclass.c (2119, 1)
// jbDataRender(data, debugflag) as Pixa
// jbDataRender(JBDATA *, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbDataRender/*"/>
///  <param name="debugflag">[in] - if TRUE, writes into 2 bpp pix and adds component outlines in color</param>
///   <returns>pixa reconstruction of original images, using templates or NULL on error</returns>
public static Pixa jbDataRender(
				 JbData data, 
				 int debugflag){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr dataPtr = IntPtr.Zero; if (data != null) {dataPtr = data.Pointer;}

	IntPtr _Result = Natives.jbDataRender(data.Pointer,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// jbclass.c (2228, 1)
// jbGetULCorners(classer, pixs, boxa) as int
// jbGetULCorners(JBCLASSER *, PIX *, BOXA *) as l_ok
///  <summary>
/// (1) This computes the ptaul field, which has the global UL corners,
/// adjusted for each specific component, so that each component
/// can be replaced by the template for its class and have the
/// centroid in the template in the same position as the
/// centroid of the original connected component.  It is important
/// that this be done properly to avoid a wavy baseline in the
/// result.<para/>
/// 
/// (2) The array fields ptac and ptact give the centroids of
/// those components relative to the UL corner of each component.
/// Here, we compute the difference in each component, round to
/// nearest integer, and correct the boxtox and boxtoy by
/// the appropriate integral difference.<para/>
/// 
/// (3) The templates and stored instances are all bordered.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbGetULCorners/*"/>
///  <param name="pixs">[in] - full res image</param>
///  <param name="boxa">[in] - of c.c. bounding rectangles for this page</param>
///   <returns>0 if OK, 1 on error</returns>
public static int jbGetULCorners(
				 JbClasser classer, 
				 Pix pixs, 
				 Boxa boxa){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbGetULCorners(classer.Pointer, pixs.Pointer, boxa.Pointer);
	
	return _Result;
}

// jbclass.c (2320, 1)
// jbGetLLCorners(classer) as int
// jbGetLLCorners(JBCLASSER *) as l_ok
///  <summary>
/// (1) This computes the ptall field, which has the global LL corners,
/// adjusted for each specific component, so that each component
/// can be replaced by the template for its class and have the
/// centroid in the template in the same position as the
/// centroid of the original connected component. It is important
/// that this be done properly to avoid a wavy baseline in the result.<para/>
/// 
/// (2) It is computed here from the corresponding UL corners, where
/// the input templates and stored instances are all bordered.
/// This should be done after all pages have been processed.<para/>
/// 
/// (3) For proper substitution, the templates whose LL corners are
/// placed in these locations must be UN-bordered.
/// This is available for a realistic jbig2 encoder, which would<para/>
/// 
/// (1) encode each template without a border, and (2) encode
/// the position using the LL corner (rather than the UL
/// corner) because the difference between y-values
/// of successive instances is typically close to zero.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/jbGetLLCorners/*"/>
///   <returns>0 if OK, 1 on error</returns>
public static int jbGetLLCorners(
				 JbClasser classer){

if (classer == null) {throw new ArgumentNullException  ("classer cannot be Nothing");}
	IntPtr classerPtr = IntPtr.Zero; if (classer != null) {classerPtr = classer.Pointer;}

	int _Result = Natives.jbGetLLCorners(classer.Pointer);
	
	return _Result;
}


}
}
