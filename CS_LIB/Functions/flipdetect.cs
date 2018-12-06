using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// flipdetect.c (242, 1)
// pixOrientCorrect(pixs, minupconf, minratio, pupconf, pleftconf, protation, debug) as Pix
// pixOrientCorrect(PIX *, l_float32, l_float32, l_float32 *, l_float32 *, l_int32 *, l_int32) as PIX *
///  <summary>
/// (1) Simple top-level function to detect if Roman text is in
/// reading orientation, and to rotate the image accordingly if not.<para/>
/// 
/// (2) Returns a copy if no rotation is needed.<para/>
/// 
/// (3) See notes for pixOrientDetect() and pixOrientDecision().
/// Use 0.0 for default values for %minupconf and %minratio<para/>
/// 
/// (4) Optional output of intermediate confidence results and
/// the rotation performed on pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOrientCorrect/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
///  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
///  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
///  <param name="pupconf">[out][optional] - use NULL to skip</param>
///  <param name="pleftconf">[out][optional] - use NULL to skip</param>
///  <param name="protation">[out][optional] - use NULL to skip</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>pixd  may be rotated by 90, 180 or 270 null on error</returns>
public static Pix pixOrientCorrect(
				 Pix pixs, 
				 Single minupconf, 
				 Single minratio, 
				out Single pupconf, 
				out Single pleftconf, 
				out int protation, 
				 DebugOnOff debug){

	IntPtr _Result = Natives.pixOrientCorrect(pixs.Pointer,   minupconf,   minratio, out  pupconf, out  pleftconf, out  protation,  (int) debug);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// flipdetect.c (370, 1)
// pixOrientDetect(pixs, pupconf, pleftconf, mincount, debug) as int
// pixOrientDetect(PIX *, l_float32 *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) See "Measuring document image skew and orientation"
/// Dan S. Bloomberg, Gary E. Kopec and Lakshmi Dasari
/// IS[and]T/SPIE EI'95, Conference 2422: Document Recognition II
/// pp 302-316, Feb 6-7, 1995, San Jose, CA<para/>
/// 
/// (2) upconf is the normalized difference between up ascenders
/// and down ascenders.  The image is analyzed without rotation
/// for being rightside-up or upside-down.  Set [and]upconf to null
/// to skip this operation.<para/>
/// 
/// (3) leftconf is the normalized difference between up ascenders
/// and down ascenders in the image after it has been
/// rotated 90 degrees clockwise.  With that rotation, ascenders
/// projecting to the left in the source image will project up
/// in the rotated image.  We compute this by rotating 90 degrees
/// clockwise and testing for up and down ascenders.  Set
/// [and]leftconf to null to skip this operation.<para/>
/// 
/// (4) Note that upconf and leftconf are not linear measures of
/// confidence, e.g., in a range between 0 and 100.  They
/// measure how far you are out on the tail of a (presumably)
/// normal distribution.  For example, a confidence of 10 means
/// that it is nearly certain that the difference did not
/// happen at random.  However, these values must be interpreted
/// cautiously, taking into consideration the estimated prior
/// for a particular orientation or mirror flip. The up-down
/// signal is very strong if applied to text with ascenders
/// up and down, and relatively weak for text at 90 degrees,
/// but even at 90 degrees, the difference can look significant.
/// For example, suppose the ascenders are oriented horizontally,
/// but the test is done vertically.  Then upconf can
/// be  is smaller -MIN_CONF_FOR_UP_DOWN, suggesting the text may be
/// upside-down.  However, if instead the test were done
/// horizontally, leftconf will be very much larger
/// (in absolute value), giving the correct orientation.<para/>
/// 
/// (5) If you compute both upconf and leftconf, and there is
/// sufficient signal, the following table determines the
/// cw angle necessary to rotate pixs so that the text is
/// rightside-up:
/// 0 deg :   upconf  is greater  is greater  1,  abs(upconf)  is greater  is greater  abs(leftconf)
/// 90 deg :  leftconf  is greater  is greater  1,  abs(leftconf)  is greater  is greater  abs(upconf)
/// 180 deg : upconf  is smaller is smaller -1, abs(upconf)  is greater  is greater  abs(leftconf)
/// 270 deg : leftconf  is smaller is smaller -1, abs(leftconf)  is greater  is greater  abs(upconf)<para/>
/// 
/// (6) One should probably not interpret the direction unless
/// there are a sufficient number of counts for both orientations,
/// in which case neither upconf nor leftconf will be 0.0.<para/>
/// 
/// (7) Uses rasterop implementation of HMT.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOrientDetect/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
///  <param name="pupconf">[out][optional] - may be NULL</param>
///  <param name="pleftconf">[out][optional] - may be NULL</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixOrientDetect(
				 Pix pixs, 
				out Single pupconf, 
				out Single pleftconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixOrientDetect(pixs.Pointer, out  pupconf, out  pleftconf,   mincount,  (int) debug);
	
	return _Result;
}

// flipdetect.c (431, 1)
// makeOrientDecision(upconf, leftconf, minupconf, minratio, porient, debug) as int
// makeOrientDecision(l_float32, l_float32, l_float32, l_float32, l_int32 *, l_int32) as l_ok
///  <summary>
/// (1) This can be run after pixOrientDetect()<para/>
/// 
/// (2) Both upconf and leftconf must be nonzero otherwise the
/// orientation cannot be determined.<para/>
/// 
/// (3) The abs values of the input confidences are compared to
/// minupconf.<para/>
/// 
/// (4) The abs value of the largest of (upconf/leftconf) and
/// (leftconf/upconf) is compared with minratio.<para/>
/// 
/// (5) Input 0.0 for the default values for minupconf and minratio.<para/>
/// 
/// (6) The return value of orient is interpreted thus:
/// L_TEXT_ORIENT_UNKNOWN:  not enough evidence to determine
/// L_TEXT_ORIENT_UP: text rightside-up
/// L_TEXT_ORIENT_LEFT: landscape, text up facing left
/// L_TEXT_ORIENT_DOWN: text upside-down
/// L_TEXT_ORIENT_RIGHT:  landscape, text up facing right
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeOrientDecision/*"/>
///  <param name="upconf">[in] - nonzero</param>
///  <param name="leftconf">[in] - nonzero</param>
///  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
///  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
///  <param name="porient">[out] - text orientation enum {0,1,2,3,4}</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int makeOrientDecision(
				 Single upconf, 
				 Single leftconf, 
				 Single minupconf, 
				 Single minratio, 
				out int porient, 
				 DebugOnOff debug){

	int _Result = Natives.makeOrientDecision(  upconf,   leftconf,   minupconf,   minratio, out  porient,  (int) debug);
	
	return _Result;
}

// flipdetect.c (510, 1)
// pixUpDownDetect(pixs, pconf, mincount, debug) as int
// pixUpDownDetect(PIX *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Special (typical, slightly faster) case, where the pixels
/// identified through the HMT (hit-miss transform) are not
/// clipped by a truncated word mask pixm.  See pixOrientDetect()
/// and pixUpDownDetectGeneral() for details.<para/>
/// 
/// (2) The returned confidence is the normalized difference
/// between the number of detected up and down ascenders,
/// assuming that the text is either rightside-up or upside-down
/// and not rotated at a 90 degree angle.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixUpDownDetect/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
///  <param name="pconf">[out] - confidence that text is rightside-up</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixUpDownDetect(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixUpDownDetect(pixs.Pointer, out  pconf,   mincount,  (int) debug);
	
	return _Result;
}

// flipdetect.c (558, 1)
// pixUpDownDetectGeneral(pixs, pconf, mincount, npixels, debug) as int
// pixUpDownDetectGeneral(PIX *, l_float32 *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) See pixOrientDetect() for other details.<para/>
/// 
/// (2) %conf is the normalized difference between the number of
/// detected up and down ascenders, assuming that the text
/// is either rightside-up or upside-down and not rotated
/// at a 90 degree angle.<para/>
/// 
/// (3) The typical mode of operation is %npixels == 0.
/// If %npixels  is greater  0, this removes HMT matches at the
/// beginning and ending of "words."  This is useful for
/// pages that may have mostly digits, because if npixels == 0,
/// leading "1" and "3" digits can register as having
/// ascenders or descenders, and "7" digits can match descenders.
/// Consequently, a page image of only digits may register
/// as being upside-down.<para/>
/// 
/// (4) We want to count the number of instances found using the HMT.
/// An expensive way to do this would be to count the
/// number of connected components.  A cheap way is to do a rank
/// reduction cascade that reduces each component to a single
/// pixel, and results (after two or three 2x reductions)
/// in one pixel for each of the original components.
/// After the reduction, you have a much smaller pix over
/// which to count pixels.  We do only 2 reductions, because
/// this function is designed to work for input pix between
/// 150 and 300 ppi, and an 8x reduction on a 150 ppi image
/// is going too far -- components will get merged.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixUpDownDetectGeneral/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
///  <param name="pconf">[out] - confidence that text is rightside-up</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="npixels">[in] - number of pixels removed from each side of word box</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixUpDownDetectGeneral(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 int npixels, 
				 DebugOnOff debug){

	int _Result = Natives.pixUpDownDetectGeneral(pixs.Pointer, out  pconf,   mincount,   npixels,  (int) debug);
	
	return _Result;
}

// flipdetect.c (699, 1)
// pixOrientDetectDwa(pixs, pupconf, pleftconf, mincount, debug) as int
// pixOrientDetectDwa(PIX *, l_float32 *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Same interface as for pixOrientDetect().  See notes
/// there for usage.<para/>
/// 
/// (2) Uses auto-gen'd code for the Sels defined at the
/// top of this file, with some renaming of functions.
/// The auto-gen'd code is in fliphmtgen.c, and can
/// be generated by a simple executable see prog/flipselgen.c.<para/>
/// 
/// (3) This runs about 2.5 times faster than the pixOrientDetect().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOrientDetectDwa/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
///  <param name="pupconf">[out][optional] - may be NULL</param>
///  <param name="pleftconf">[out][optional] - may be NULL</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixOrientDetectDwa(
				 Pix pixs, 
				out Single pupconf, 
				out Single pleftconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixOrientDetectDwa(pixs.Pointer, out  pupconf, out  pleftconf,   mincount,  (int) debug);
	
	return _Result;
}

// flipdetect.c (752, 1)
// pixUpDownDetectDwa(pixs, pconf, mincount, debug) as int
// pixUpDownDetectDwa(PIX *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Faster (DWA) version of pixUpDownDetect().<para/>
/// 
/// (2) This is a special case (but typical and slightly faster) of
/// pixUpDownDetectGeneralDwa(), where the pixels identified
/// through the HMT (hit-miss transform) are not clipped by
/// a truncated word mask pixm.  See pixUpDownDetectGeneral()
/// for usage and other details.<para/>
/// 
/// (3) The returned confidence is the normalized difference
/// between the number of detected up and down ascenders,
/// assuming that the text is either rightside-up or upside-down
/// and not rotated at a 90 degree angle.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixUpDownDetectDwa/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
///  <param name="pconf">[out] - confidence that text is rightside-up</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixUpDownDetectDwa(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixUpDownDetectDwa(pixs.Pointer, out  pconf,   mincount,  (int) debug);
	
	return _Result;
}

// flipdetect.c (777, 1)
// pixUpDownDetectGeneralDwa(pixs, pconf, mincount, npixels, debug) as int
// pixUpDownDetectGeneralDwa(PIX *, l_float32 *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) See the notes in pixUpDownDetectGeneral() for usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixUpDownDetectGeneralDwa/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
///  <param name="pconf">[out] - confidence that text is rightside-up</param>
///  <param name="mincount">[in] - min number of up + down use 0 for default</param>
///  <param name="npixels">[in] - number of pixels removed from each side of word box</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixUpDownDetectGeneralDwa(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 int npixels, 
				 DebugOnOff debug){

	int _Result = Natives.pixUpDownDetectGeneralDwa(pixs.Pointer, out  pconf,   mincount,   npixels,  (int) debug);
	
	return _Result;
}

// flipdetect.c (934, 1)
// pixMirrorDetect(pixs, pconf, mincount, debug) as int
// pixMirrorDetect(PIX *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) For this test, it is necessary that the text is horizontally
/// oriented, with ascenders going up.<para/>
/// 
/// (2) conf is the normalized difference between the number of
/// right and left facing characters with ascenders.
/// Left-facing are {d} right-facing are {b, h, k}.
/// At least that was the expectation.  In practice, we can
/// really just say that it is the normalized difference in
/// hits using two specific hit-miss filters, textsel1 and textsel2,
/// after the image has been suitably pre-filtered so that
/// these filters are effective.  See (4) for what's really happening.<para/>
/// 
/// (3) A large positive conf value indicates normal text, whereas
/// a large negative conf value means the page is mirror reversed.<para/>
/// 
/// (4) The implementation is a bit tricky.  The general idea is
/// to fill the x-height part of characters, but not the space
/// between them, before doing the HMT.  This is done by
/// finding pixels added using two different operations -- a
/// horizontal close and a vertical dilation -- and adding
/// the intersection of these sets to the original.  It turns
/// out that the original intuition about the signal was largely
/// in error: much of the signal for right-facing characters
/// comes from the lower part of common x-height characters, like
/// the e and c, that remain open after these operations.
/// So it's important that the operations to close the x-height
/// parts of the characters are purposely weakened sufficiently
/// to allow these characters to remain open.  The wonders
/// of morphology!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMirrorDetect/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
///  <param name="pconf">[out] - confidence that text is not LR mirror reversed</param>
///  <param name="mincount">[in] - min number of left + right use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixMirrorDetect(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixMirrorDetect(pixs.Pointer, out  pconf,   mincount,  (int) debug);
	
	return _Result;
}

// flipdetect.c (1025, 1)
// pixMirrorDetectDwa(pixs, pconf, mincount, debug) as int
// pixMirrorDetectDwa(PIX *, l_float32 *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) We assume the text is horizontally oriented, with
/// ascenders going up.<para/>
/// 
/// (2) See notes in pixMirrorDetect().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMirrorDetectDwa/*"/>
///  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
///  <param name="pconf">[out] - confidence that text is not LR mirror reversed</param>
///  <param name="mincount">[in] - min number of left + right use 0 for default</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixMirrorDetectDwa(
				 Pix pixs, 
				out Single pconf, 
				 int mincount, 
				 DebugOnOff debug){

	int _Result = Natives.pixMirrorDetectDwa(pixs.Pointer, out  pconf,   mincount,  (int) debug);
	
	return _Result;
}


}
}
