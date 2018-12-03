using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixarith.c (115, 1)
// pixAddConstantGray(pixs, val) as int
// pixAddConstantGray(PIX *, l_int32) as l_ok
///  <summary>
/// (1) In-place operation.<para/>
/// 
/// (2) No clipping for 32 bpp.<para/>
/// 
/// (3) For 8 and 16 bpp, if val  is greater  0 the result is clipped
/// to 0xff and 0xffff, rsp.<para/>
/// 
/// (4) For 8 and 16 bpp, if val  is smaller 0 the result is clipped to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddConstantGray/*"/>
///  <param name="pixs">[in] - 8, 16 or 32 bpp</param>
///  <param name="val">[in] - amount to add to each pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixAddConstantGray(
				 Pix pixs, 
				 int val){

	int _Result = Natives.pixAddConstantGray(pixs.Pointer,   val);
	



	return _Result;
}

// pixarith.c (186, 1)
// pixMultConstantGray(pixs, val) as int
// pixMultConstantGray(PIX *, l_float32) as l_ok
///  <summary>
/// (1) In-place operation val must be greater or equal 0.<para/>
/// 
/// (2) No clipping for 32 bpp.<para/>
/// 
/// (3) For 8 and 16 bpp, the result is clipped to 0xff and 0xffff, rsp.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMultConstantGray/*"/>
///  <param name="pixs">[in] - 8, 16 or 32 bpp</param>
///  <param name="val">[in] - greater or equal 0.0 amount to multiply by each pixel</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixMultConstantGray(
				 Pix pixs, 
				 Single val){

	int _Result = Natives.pixMultConstantGray(pixs.Pointer,   val);
	



	return _Result;
}

// pixarith.c (261, 1)
// pixAddGray(pixd, pixs1, pixs2) as Pix
// pixAddGray(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) Arithmetic addition of two 8, 16 or 32 bpp images.<para/>
/// 
/// (2) For 8 and 16 bpp, we do explicit clipping to 0xff and 0xffff,
/// respectively.<para/>
/// 
/// (3) Alignment is to UL corner.<para/>
/// 
/// (4) There are 3 cases.  The result can go to a new dest,
/// in-place to pixs1, or to an existing input dest:
/// pixd == null: (src1 + src2) to new pixd
/// pixd == pixs1:  (src1 + src2) to src1  (in-place)
/// pixd != pixs1:  (src1 + src2) to input pixd<para/>
/// 
/// (5) pixs2 must be different from both pixd and pixs1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddGray/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, or different from pixs1</param>
///  <param name="pixs1">[in] - can be == to pixd</param>
///  <param name="pixs2">[in] - </param>
///   <returns>pixd always</returns>
public static Pix pixAddGray(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixAddGray(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (353, 1)
// pixSubtractGray(pixd, pixs1, pixs2) as Pix
// pixSubtractGray(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) Arithmetic subtraction of two 8, 16 or 32 bpp images.<para/>
/// 
/// (2) Source pixs2 is always subtracted from source pixs1.<para/>
/// 
/// (3) Do explicit clipping to 0.<para/>
/// 
/// (4) Alignment is to UL corner.<para/>
/// 
/// (5) There are 3 cases.  The result can go to a new dest,
/// in-place to pixs1, or to an existing input dest:
/// (a) pixd == null (src1 - src2) to new pixd
/// (b) pixd == pixs1  (src1 - src2) to src1  (in-place)
/// (d) pixd != pixs1  (src1 - src2) to input pixd<para/>
/// 
/// (6) pixs2 must be different from both pixd and pixs1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSubtractGray/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs1, or different from pixs1</param>
///  <param name="pixs1">[in] - can be == to pixd</param>
///  <param name="pixs2">[in] - </param>
///   <returns>pixd always</returns>
public static Pix pixSubtractGray(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSubtractGray(pixdPtr, pixs1.Pointer, pixs2.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (442, 1)
// pixThresholdToValue(pixd, pixs, threshval, setval) as Pix
// pixThresholdToValue(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// ~ operation can be in-place (pixs == pixd) or to a new pixd
/// ~ if setval  is greater  threshval, sets pixels with a value greater or equal threshval to setval
/// ~ if setval  is smaller threshval, sets pixels with a value smaller or equal threshval to setval
/// ~ if setval == threshval, no-op
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdToValue/*"/>
///  <param name="pixd">[in][optional] - if not null, must be equal to pixs</param>
///  <param name="pixs">[in] - 8, 16, 32 bpp</param>
///  <param name="threshval">[in] - </param>
///  <param name="setval">[in] - </param>
///   <returns>pixd always</returns>
public static Pix pixThresholdToValue(
				 Pix pixd, 
				 Pix pixs, 
				 int threshval, 
				 int setval){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixThresholdToValue(pixdPtr, pixs.Pointer,   threshval,   setval);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (551, 1)
// pixInitAccumulate(w, h, offset) as Pix
// pixInitAccumulate(l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) The offset must be greater or equal 0.<para/>
/// 
/// (2) The offset is used so that we can do arithmetic
/// with negative number results on l_uint32 data it
/// prevents the l_uint32 data from going negative.<para/>
/// 
/// (3) Because we use l_int32 intermediate data results,
/// these should never exceed the max of l_int32 (0x7fffffff).
/// We do not permit the offset to be above 0x40000000,
/// which is half way between 0 and the max of l_int32.<para/>
/// 
/// (4) The same offset should be used for initialization,
/// multiplication by a constant, and final extraction!<para/>
/// 
/// (5) If you're only adding positive values, offset can be 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixInitAccumulate/*"/>
///  <param name="w">[in] - of accumulate array</param>
///  <param name="h">[in] - of accumulate array</param>
///  <param name="offset">[in] - initialize the 32 bpp to have this value not more than 0x40000000</param>
///   <returns>pixd 32 bpp, or NULL on error</returns>
public static Pix pixInitAccumulate(
				 int w, 
				 int h, 
				 uint offset){

	IntPtr _Result = Natives.pixInitAccumulate(  w,   h,   offset);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (585, 1)
// pixFinalAccumulate(pixs, offset, depth) as Pix
// pixFinalAccumulate(PIX *, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) The offset must be greater or equal 0 and should not exceed 0x40000000.<para/>
/// 
/// (2) The offset is subtracted from the src 32 bpp image<para/>
/// 
/// (3) For 8 bpp dest, the result is clipped to [0, 0xff]<para/>
/// 
/// (4) For 16 bpp dest, the result is clipped to [0, 0xffff]
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFinalAccumulate/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="offset">[in] - same as used for initialization</param>
///  <param name="depth">[in] - 8, 16 or 32 bpp, of destination</param>
///   <returns>pixd 8, 16 or 32 bpp, or NULL on error</returns>
public static Pix pixFinalAccumulate(
				 Pix pixs, 
				 uint offset, 
				 int depth){

	IntPtr _Result = Natives.pixFinalAccumulate(pixs.Pointer,   offset,   depth);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (662, 1)
// pixFinalAccumulateThreshold(pixs, offset, threshold) as Pix
// pixFinalAccumulateThreshold(PIX *, l_uint32, l_uint32) as PIX *
///  <summary>
/// (1) The offset must be greater or equal 0 and should not exceed 0x40000000.<para/>
/// 
/// (2) The offset is subtracted from the src 32 bpp image
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFinalAccumulateThreshold/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="offset">[in] - same as used for initialization</param>
///  <param name="threshold">[in] - values less than this are set in the destination</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
public static Pix pixFinalAccumulateThreshold(
				 Pix pixs, 
				 uint offset, 
				 uint threshold){

	IntPtr _Result = Natives.pixFinalAccumulateThreshold(pixs.Pointer,   offset,   threshold);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (719, 1)
// pixAccumulate(pixd, pixs, op) as int
// pixAccumulate(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This adds or subtracts each pixs value from pixd.<para/>
/// 
/// (2) This clips to the minimum of pixs and pixd, so they
/// do not need to be the same size.<para/>
/// 
/// (3) The alignment is to the origin [UL corner] of pixs [and] pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAccumulate/*"/>
///  <param name="pixd">[in] - 32 bpp</param>
///  <param name="pixs">[in] - 1, 8, 16 or 32 bpp</param>
///  <param name="op">[in] - L_ARITH_ADD or L_ARITH_SUBTRACT</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixAccumulate(
				 Pix pixd, 
				 Pix pixs, 
				 int op){

	int _Result = Natives.pixAccumulate(pixd.Pointer, pixs.Pointer,   op);
	



	return _Result;
}

// pixarith.c (818, 1)
// pixMultConstAccumulate(pixs, factor, offset) as int
// pixMultConstAccumulate(PIX *, l_float32, l_uint32) as l_ok
///  <summary>
/// (1) The offset must be greater or equal 0 and should not exceed 0x40000000.<para/>
/// 
/// (2) This multiplies each pixel, relative to offset, by the input factor<para/>
/// 
/// (3) The result is returned with the offset back in place.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMultConstAccumulate/*"/>
///  <param name="pixs">[in] - 32 bpp</param>
///  <param name="factor">[in] - </param>
///  <param name="offset">[in] - same as used for initialization</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixMultConstAccumulate(
				 Pix pixs, 
				 Single factor, 
				 uint offset){

	int _Result = Natives.pixMultConstAccumulate(pixs.Pointer,   factor,   offset);
	



	return _Result;
}

// pixarith.c (872, 1)
// pixAbsDifference(pixs1, pixs2) as Pix
// pixAbsDifference(PIX *, PIX *) as PIX *
///  <summary>
/// (1) The depth of pixs1 and pixs2 must be equal.<para/>
/// 
/// (2) Clips computation to the min size, aligning the UL corners<para/>
/// 
/// (3) For 8 and 16 bpp, assumes one gray component.<para/>
/// 
/// (4) For 32 bpp, assumes 3 color components, and ignores the
/// LSB of each word (the alpha channel)<para/>
/// 
/// (5) Computes the absolute value of the difference between
/// each component value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAbsDifference/*"/>
///  <param name="pixs1">[in] - both either 8 or 16 bpp gray, or 32 bpp RGB</param>
///  <param name="pixs2">[in] - both either 8 or 16 bpp gray, or 32 bpp RGB</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixAbsDifference(
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr _Result = Natives.pixAbsDifference(pixs1.Pointer, pixs2.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (969, 1)
// pixAddRGB(pixs1, pixs2) as Pix
// pixAddRGB(PIX *, PIX *) as PIX *
///  <summary>
/// (1) Clips computation to the minimum size, aligning the UL corners.<para/>
/// 
/// (2) Removes any colormap to RGB, and ignores the LSB of each
/// pixel word (the alpha channel).<para/>
/// 
/// (3) Adds each component value, pixelwise, clipping to 255.<para/>
/// 
/// (4) This is useful to combine two images where most of the
/// pixels are essentially black, such as in pixPerceptualDiff().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddRGB/*"/>
///  <param name="pixs1">[in] - 32 bpp RGB, or colormapped</param>
///  <param name="pixs2">[in] - 32 bpp RGB, or colormapped</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixAddRGB(
				 Pix pixs1, 
				 Pix pixs2){

	IntPtr _Result = Natives.pixAddRGB(pixs1.Pointer, pixs2.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (1054, 1)
// pixMinOrMax(pixd, pixs1, pixs2, type) as Pix
// pixMinOrMax(PIX *, PIX *, PIX *, l_int32) as PIX *
///  <summary>
/// (1) This gives the min or max of two images, component-wise.<para/>
/// 
/// (2) The depth can be 8 or 16 bpp for 1 component, and 32 bpp
/// for a 3 component image.  For 32 bpp, ignore the LSB
/// of each word (the alpha channel)<para/>
/// 
/// (3) There are 3 cases:
/// ~  if pixd == null, Min(src1, src2) to new pixd
/// ~  if pixd == pixs1,  Min(src1, src2) to src1  (in-place)
/// ~  if pixd != pixs1,  Min(src1, src2) to input pixd
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMinOrMax/*"/>
///  <param name="pixd">[in][optional] - destination: this can be null, equal to pixs1, or different from pixs1</param>
///  <param name="pixs1">[in] - can be == to pixd</param>
///  <param name="pixs2">[in] - </param>
///  <param name="type">[in] - L_CHOOSE_MIN, L_CHOOSE_MAX</param>
///   <returns>pixd always</returns>
public static Pix pixMinOrMax(
				 Pix pixd, 
				 Pix pixs1, 
				 Pix pixs2, 
				 int type){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixMinOrMax(pixdPtr, pixs1.Pointer, pixs2.Pointer,   type);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (1155, 1)
// pixMaxDynamicRange(pixs, type) as Pix
// pixMaxDynamicRange(PIX *, l_int32) as PIX *
///  <summary>
/// (1) Scales pixel values to fit maximally within the dest 8 bpp pixd<para/>
/// 
/// (2) Assumes the source 'pixels' are a 1-component scalar.  For
/// a 32 bpp source, each pixel is treated as a single number --
/// not as a 3-component rgb pixel value.<para/>
/// 
/// (3) Uses a LUT for log scaling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMaxDynamicRange/*"/>
///  <param name="pixs">[in] - 4, 8, 16 or 32 bpp source</param>
///  <param name="type">[in] - L_LINEAR_SCALE or L_LOG_SCALE</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix pixMaxDynamicRange(
				 Pix pixs, 
				 int type){

	IntPtr _Result = Natives.pixMaxDynamicRange(pixs.Pointer,   type);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (1343, 1)
// pixMaxDynamicRangeRGB(pixs, type) as Pix
// pixMaxDynamicRangeRGB(PIX *, l_int32) as PIX *
///  <summary>
/// (1) Scales pixel values to fit maximally within a 32 bpp dest pixd<para/>
/// 
/// (2) All color components are scaled with the same factor, based
/// on the maximum r,g or b component in the image.  This should
/// not be used if the 32-bit value is a single number (e.g., a
/// count in a histogram generated by pixMakeHistoHS()).<para/>
/// 
/// (3) Uses a LUT for log scaling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMaxDynamicRangeRGB/*"/>
///  <param name="pixs">[in] - 32 bpp rgb source</param>
///  <param name="type">[in] - L_LINEAR_SCALE or L_LOG_SCALE</param>
///   <returns>pixd 32 bpp, or NULL on error</returns>
public static Pix pixMaxDynamicRangeRGB(
				 Pix pixs, 
				 int type){

	IntPtr _Result = Natives.pixMaxDynamicRangeRGB(pixs.Pointer,   type);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixarith.c (1430, 1)
// linearScaleRGBVal(sval, factor) as uint
// linearScaleRGBVal(l_uint32, l_float32) as l_uint32
///  <summary>
/// (1) %factor must be chosen to be not greater than (255 / maxcomp),
/// where maxcomp is the maximum value of the pixel components.
/// Otherwise, the product will overflow a uint8.  In use, factor
/// is the same for all pixels in a pix.<para/>
/// 
/// (2) No scaling is performed on the transparency ("A") component.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/linearScaleRGBVal/*"/>
///  <param name="sval">[in] - 32-bit rgb pixel value</param>
///  <param name="factor">[in] - multiplication factor on each component</param>
///   <returns>dval  linearly scaled version of %sval</returns>
public static uint linearScaleRGBVal(
				 uint sval, 
				 Single factor){

	uint _Result = Natives.linearScaleRGBVal(  sval,   factor);
	



	return _Result;
}

// pixarith.c (1463, 1)
// logScaleRGBVal(sval, tab, factor) as uint
// logScaleRGBVal(l_uint32, l_float32 *, l_float32) as l_uint32
///  <summary>
/// (1) %tab is made with makeLogBase2Tab().<para/>
/// 
/// (2) %factor must be chosen to be not greater than
/// 255.0 / log[base2](maxcomp), where maxcomp is the maximum
/// value of the pixel components.  Otherwise, the product
/// will overflow a uint8.  In use, factor is the same for
/// all pixels in a pix.<para/>
/// 
/// (3) No scaling is performed on the transparency ("A") component.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/logScaleRGBVal/*"/>
///  <param name="sval">[in] - 32-bit rgb pixel value</param>
///  <param name="tab">[in] - 256 entry log-base-2 table</param>
///  <param name="factor">[in] - multiplication factor on each component</param>
///   <returns>dval  log scaled version of %sval</returns>
public static uint logScaleRGBVal(
				 uint sval, 
				 Single[] tab, 
				 Single factor){

	uint _Result = Natives.logScaleRGBVal(  sval,   tab,   factor);
	



	return _Result;
}

// pixarith.c (1488, 1)
// makeLogBase2Tab() as Single[]
// makeLogBase2Tab() as l_float32 *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeLogBase2Tab/*"/>
///   <returns></returns>
public static Single[] makeLogBase2Tab(){

	Single[] _Result = Natives.makeLogBase2Tab();
	



	return _Result;
}

// pixarith.c (1515, 1)
// getLogBase2(val, logtab) as Single
// getLogBase2(l_int32, l_float32 *) as l_float32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getLogBase2/*"/>
///   <returns></returns>
public static Single getLogBase2(
				 int val, 
				 Single[] logtab){

	Single _Result = Natives.getLogBase2(  val,   logtab);
	



	return _Result;
}


}
}
