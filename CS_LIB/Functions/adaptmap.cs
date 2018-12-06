using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// adaptmap.c (185, 1)
// pixCleanBackgroundToWhite(pixs, pixim, pixg, gamma, blackval, whiteval) as Pix
// pixCleanBackgroundToWhite(PIX *, PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a simplified interface for cleaning an image.
/// For comparison, see pixAdaptThresholdToBinaryGen().<para/>
/// 
/// (2) The suggested default values for the input parameters are:
/// gamma:  1.0  (reduce this to increase the contrast e.g.,
/// for light text)
/// blackval 70  (a bit more than 60)
/// whiteval  190  (a bit less than 200)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCleanBackgroundToWhite/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale or 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///  <param name="gamma">[in] - gamma correction must be  is greater  0.0 typically ~1.0</param>
///  <param name="blackval">[in] - dark value to set to black (0)</param>
///  <param name="whiteval">[in] - light value to set to white (255)</param>
///   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
public static Pix pixCleanBackgroundToWhite(
				 Pix pixs, 
				 Pix pixim, 
				 Pix pixg, 
				 Single gamma, 
				 int blackval, 
				 int whiteval){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}

	IntPtr _Result = Natives.pixCleanBackgroundToWhite(pixs.Pointer, piximPtr, pixgPtr,   gamma,   blackval,   whiteval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (231, 1)
// pixBackgroundNormSimple(pixs, pixim, pixg) as Pix
// pixBackgroundNormSimple(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This is a simplified interface to pixBackgroundNorm(),
/// where seven parameters are defaulted.<para/>
/// 
/// (2) The input image is either grayscale or rgb.<para/>
/// 
/// (3) See pixBackgroundNorm() for usage and function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormSimple/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale or 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
public static Pix pixBackgroundNormSimple(
				 Pix pixs, 
				 Pix pixim, 
				 Pix pixg){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}

	IntPtr _Result = Natives.pixBackgroundNormSimple(pixs.Pointer, piximPtr, pixgPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (302, 1)
// pixBackgroundNorm(pixs, pixim, pixg, sx, sy, thresh, mincount, bgval, smoothx, smoothy) as Pix
// pixBackgroundNorm(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a top-level interface for normalizing the image intensity
/// by mapping the image so that the background is near the input
/// value 'bgval'.<para/>
/// 
/// (2) The input image is either grayscale or rgb.<para/>
/// 
/// (3) For each component in the input image, the background value
/// in each tile is estimated using the values in the tile that
/// are not part of the foreground, where the foreground is
/// determined by the input 'thresh' argument.<para/>
/// 
/// (4) An optional binary mask can be specified, with the foreground
/// pixels typically over image regions.  The resulting background
/// map values will be determined by surrounding pixels that are
/// not under the mask foreground.  The origin (0,0) of this mask
/// is assumed to be aligned with the origin of the input image.
/// This binary mask must not fully cover pixs, because then there
/// will be no pixels in the input image available to compute
/// the background.<para/>
/// 
/// (5) An optional grayscale version of the input pixs can be supplied.
/// The only reason to do this is if the input is RGB and this
/// grayscale version can be used elsewhere.  If the input is RGB
/// and this is not supplied, it is made internally using only
/// the green component, and destroyed after use.<para/>
/// 
/// (6) The dimensions of the pixel tile (sx, sy) give the amount by
/// by which the map is reduced in size from the input image.<para/>
/// 
/// (7) The threshold is used to binarize the input image, in order to
/// locate the foreground components.  If this is set too low,
/// some actual foreground may be used to determine the maps
/// if set too high, there may not be enough background
/// to determine the map values accurately.  Typically, it's
/// better to err by setting the threshold too high.<para/>
/// 
/// (8) A 'mincount' threshold is a minimum count of pixels in a
/// tile for which a background reading is made, in order for that
/// pixel in the map to be valid.  This number should perhaps be
/// at least 1/3 the size of the tile.<para/>
/// 
/// (9) A 'bgval' target background value for the normalized image.  This
/// should be at least 128.  If set too close to 255, some
/// clipping will occur in the result.<para/>
/// 
/// (10) Two factors, 'smoothx' and 'smoothy', are input for smoothing
/// the map.  Each low-pass filter kernel dimension is
/// is 2  (smoothing factor) + 1, so a
/// value of 0 means no smoothing. A value of 1 or 2 is recommended.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNorm/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale or 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///  <param name="sx">[in] - tile size in pixels</param>
///  <param name="sy">[in] - tile size in pixels</param>
///  <param name="thresh">[in] - threshold for determining foreground</param>
///  <param name="mincount">[in] - min threshold on counts in a tile</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
///   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
public static Pix pixBackgroundNorm(
				 Pix pixs, 
				 Pix pixim, 
				 Pix pixg, 
				 int sx, 
				 int sy, 
				 int thresh, 
				 int mincount, 
				 int bgval, 
				 int smoothx, 
				 int smoothy){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}

	IntPtr _Result = Natives.pixBackgroundNorm(pixs.Pointer, piximPtr, pixgPtr,   sx,   sy,   thresh,   mincount,   bgval,   smoothx,   smoothy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (443, 1)
// pixBackgroundNormMorph(pixs, pixim, reduction, size, bgval) as Pix
// pixBackgroundNormMorph(PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a top-level interface for normalizing the image intensity
/// by mapping the image so that the background is near the input
/// value 'bgval'.<para/>
/// 
/// (2) The input image is either grayscale or rgb.<para/>
/// 
/// (3) For each component in the input image, the background value
/// is estimated using a grayscale closing hence the 'Morph'
/// in the function name.<para/>
/// 
/// (4) An optional binary mask can be specified, with the foreground
/// pixels typically over image regions.  The resulting background
/// map values will be determined by surrounding pixels that are
/// not under the mask foreground.  The origin (0,0) of this mask
/// is assumed to be aligned with the origin of the input image.
/// This binary mask must not fully cover pixs, because then there
/// will be no pixels in the input image available to compute
/// the background.<para/>
/// 
/// (5) The map is computed at reduced size (given by 'reduction')
/// from the input pixs and optional pixim.  At this scale,
/// pixs is closed to remove the background, using a square Sel
/// of odd dimension.  The product of reduction  size should be
/// large enough to remove most of the text foreground.<para/>
/// 
/// (6) No convolutional smoothing needs to be done on the map before
/// inverting it.<para/>
/// 
/// (7) A 'bgval' target background value for the normalized image.  This
/// should be at least 128.  If set too close to 255, some
/// clipping will occur in the result.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormMorph/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale or 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="reduction">[in] - at which morph closings are done between 2 and 16</param>
///  <param name="size">[in] - of square Sel for the closing use an odd number</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix pixBackgroundNormMorph(
				 Pix pixs, 
				 Pix pixim, 
				 int reduction, 
				 int size, 
				 int bgval){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}

	IntPtr _Result = Natives.pixBackgroundNormMorph(pixs.Pointer, piximPtr,   reduction,   size,   bgval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (554, 1)
// pixBackgroundNormGrayArray(pixs, pixim, sx, sy, thresh, mincount, bgval, smoothx, smoothy, ppixd) as int
// pixBackgroundNormGrayArray(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as l_ok
///  <summary>
/// (1) See notes in pixBackgroundNorm().<para/>
/// 
/// (2) This returns a 16 bpp pix that can be used by
/// pixApplyInvBackgroundGrayMap() to generate a normalized version
/// of the input pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormGrayArray/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="sx">[in] - tile size in pixels</param>
///  <param name="sy">[in] - tile size in pixels</param>
///  <param name="thresh">[in] - threshold for determining foreground</param>
///  <param name="mincount">[in] - min threshold on counts in a tile</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
///  <param name="ppixd">[out] - 16 bpp array of inverted background value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixBackgroundNormGrayArray(
				 Pix pixs, 
				 Pix pixim, 
				 int sx, 
				 int sy, 
				 int thresh, 
				 int mincount, 
				 int bgval, 
				 int smoothx, 
				 int smoothy, 
				out Pix ppixd){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixdPtr = IntPtr.Zero;

	int _Result = Natives.pixBackgroundNormGrayArray(pixs.Pointer, piximPtr,   sx,   sy,   thresh,   mincount,   bgval,   smoothx,   smoothy, out ppixdPtr);
	
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	return _Result;
}

// adaptmap.c (631, 1)
// pixBackgroundNormRGBArrays(pixs, pixim, pixg, sx, sy, thresh, mincount, bgval, smoothx, smoothy, ppixr, ppixg, ppixb) as int
// pixBackgroundNormRGBArrays(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
///  <summary>
/// (1) See notes in pixBackgroundNorm().<para/>
/// 
/// (2) This returns a set of three 16 bpp pix that can be used by
/// pixApplyInvBackgroundGrayMap() to generate a normalized version
/// of each component of the input pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormRGBArrays/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///  <param name="sx">[in] - tile size in pixels</param>
///  <param name="sy">[in] - tile size in pixels</param>
///  <param name="thresh">[in] - threshold for determining foreground</param>
///  <param name="mincount">[in] - min threshold on counts in a tile</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
///  <param name="ppixr">[out] - 16 bpp array of inverted R background value</param>
///  <param name="ppixg">[out] - 16 bpp array of inverted G background value</param>
///  <param name="ppixb">[out] - 16 bpp array of inverted B background value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixBackgroundNormRGBArrays(
				 Pix pixs, 
				 Pix pixim, 
				 Pix pixg, 
				 int sx, 
				 int sy, 
				 int thresh, 
				 int mincount, 
				 int bgval, 
				 int smoothx, 
				 int smoothy, 
				out Pix ppixr, 
				out Pix ppixg, 
				out Pix ppixb){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}
	IntPtr ppixrPtr = IntPtr.Zero;
	IntPtr ppixgPtr = IntPtr.Zero;
	IntPtr ppixbPtr = IntPtr.Zero;

	int _Result = Natives.pixBackgroundNormRGBArrays(pixs.Pointer, piximPtr, pixgPtr,   sx,   sy,   thresh,   mincount,   bgval,   smoothx,   smoothy, out ppixrPtr, out ppixgPtr, out ppixbPtr);
	
	if (ppixrPtr == IntPtr.Zero) {ppixr = null;} else { ppixr = new Pix(ppixrPtr); };
	if (ppixgPtr == IntPtr.Zero) {ppixg = null;} else { ppixg = new Pix(ppixgPtr); };
	if (ppixbPtr == IntPtr.Zero) {ppixb = null;} else { ppixb = new Pix(ppixbPtr); };
	return _Result;
}

// adaptmap.c (714, 1)
// pixBackgroundNormGrayArrayMorph(pixs, pixim, reduction, size, bgval, ppixd) as int
// pixBackgroundNormGrayArrayMorph(PIX *, PIX *, l_int32, l_int32, l_int32, PIX **) as l_ok
///  <summary>
/// (1) See notes in pixBackgroundNormMorph().<para/>
/// 
/// (2) This returns a 16 bpp pix that can be used by
/// pixApplyInvBackgroundGrayMap() to generate a normalized version
/// of the input pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormGrayArrayMorph/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="reduction">[in] - at which morph closings are done between 2 and 16</param>
///  <param name="size">[in] - of square Sel for the closing use an odd number</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="ppixd">[out] - 16 bpp array of inverted background value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixBackgroundNormGrayArrayMorph(
				 Pix pixs, 
				 Pix pixim, 
				 int reduction, 
				 int size, 
				 int bgval, 
				out Pix ppixd){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixdPtr = IntPtr.Zero;

	int _Result = Natives.pixBackgroundNormGrayArrayMorph(pixs.Pointer, piximPtr,   reduction,   size,   bgval, out ppixdPtr);
	
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	return _Result;
}

// adaptmap.c (779, 1)
// pixBackgroundNormRGBArraysMorph(pixs, pixim, reduction, size, bgval, ppixr, ppixg, ppixb) as int
// pixBackgroundNormRGBArraysMorph(PIX *, PIX *, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
///  <summary>
/// (1) See notes in pixBackgroundNormMorph().<para/>
/// 
/// (2) This returns a set of three 16 bpp pix that can be used by
/// pixApplyInvBackgroundGrayMap() to generate a normalized version
/// of each component of the input pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormRGBArraysMorph/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="reduction">[in] - at which morph closings are done between 2 and 16</param>
///  <param name="size">[in] - of square Sel for the closing use an odd number</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="ppixr">[out] - 16 bpp array of inverted R background value</param>
///  <param name="ppixg">[out] - 16 bpp array of inverted G background value</param>
///  <param name="ppixb">[out] - 16 bpp array of inverted B background value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixBackgroundNormRGBArraysMorph(
				 Pix pixs, 
				 Pix pixim, 
				 int reduction, 
				 int size, 
				 int bgval, 
				out Pix ppixr, 
				out Pix ppixg, 
				out Pix ppixb){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixrPtr = IntPtr.Zero;
	IntPtr ppixgPtr = IntPtr.Zero;
	IntPtr ppixbPtr = IntPtr.Zero;

	int _Result = Natives.pixBackgroundNormRGBArraysMorph(pixs.Pointer, piximPtr,   reduction,   size,   bgval, out ppixrPtr, out ppixgPtr, out ppixbPtr);
	
	if (ppixrPtr == IntPtr.Zero) {ppixr = null;} else { ppixr = new Pix(ppixrPtr); };
	if (ppixgPtr == IntPtr.Zero) {ppixg = null;} else { ppixg = new Pix(ppixgPtr); };
	if (ppixbPtr == IntPtr.Zero) {ppixb = null;} else { ppixb = new Pix(ppixbPtr); };
	return _Result;
}

// adaptmap.c (856, 1)
// pixGetBackgroundGrayMap(pixs, pixim, sx, sy, thresh, mincount, ppixd) as int
// pixGetBackgroundGrayMap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, PIX **) as l_ok
///  <summary>
/// (1) The background is measured in regions that don't have
/// images.  It is then propagated into the image regions,
/// and finally smoothed in each image region.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBackgroundGrayMap/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale not cmapped</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null it should not have all foreground pixels</param>
///  <param name="sx">[in] - tile size in pixels</param>
///  <param name="sy">[in] - tile size in pixels</param>
///  <param name="thresh">[in] - threshold for determining foreground</param>
///  <param name="mincount">[in] - min threshold on counts in a tile</param>
///  <param name="ppixd">[out] - 8 bpp grayscale map</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetBackgroundGrayMap(
				 Pix pixs, 
				 Pix pixim, 
				 int sx, 
				 int sy, 
				 int thresh, 
				 int mincount, 
				out Pix ppixd){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixdPtr = IntPtr.Zero;

	int _Result = Natives.pixGetBackgroundGrayMap(pixs.Pointer, piximPtr,   sx,   sy,   thresh,   mincount, out ppixdPtr);
	
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	return _Result;
}

// adaptmap.c (1034, 1)
// pixGetBackgroundRGBMap(pixs, pixim, pixg, sx, sy, thresh, mincount, ppixmr, ppixmg, ppixmb) as int
// pixGetBackgroundRGBMap(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
///  <summary>
/// (1) If pixg, which is a grayscale version of pixs, is provided,
/// use this internally to generate the foreground mask.
/// Otherwise, a grayscale version of pixs will be generated
/// from the green component only, used, and destroyed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBackgroundRGBMap/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null it should not have all foreground pixels</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///  <param name="sx">[in] - tile size in pixels</param>
///  <param name="sy">[in] - tile size in pixels</param>
///  <param name="thresh">[in] - threshold for determining foreground</param>
///  <param name="mincount">[in] - min threshold on counts in a tile</param>
///  <param name="ppixmr">[out] - rgb maps</param>
///  <param name="ppixmg">[out] - rgb maps</param>
///  <param name="ppixmb">[out] - rgb maps</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetBackgroundRGBMap(
				 Pix pixs, 
				 Pix pixim, 
				 Pix pixg, 
				 int sx, 
				 int sy, 
				 int thresh, 
				 int mincount, 
				out Pix ppixmr, 
				out Pix ppixmg, 
				out Pix ppixmb){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}
	IntPtr ppixmrPtr = IntPtr.Zero;
	IntPtr ppixmgPtr = IntPtr.Zero;
	IntPtr ppixmbPtr = IntPtr.Zero;

	int _Result = Natives.pixGetBackgroundRGBMap(pixs.Pointer, piximPtr, pixgPtr,   sx,   sy,   thresh,   mincount, out ppixmrPtr, out ppixmgPtr, out ppixmbPtr);
	
	if (ppixmrPtr == IntPtr.Zero) {ppixmr = null;} else { ppixmr = new Pix(ppixmrPtr); };
	if (ppixmgPtr == IntPtr.Zero) {ppixmg = null;} else { ppixmg = new Pix(ppixmgPtr); };
	if (ppixmbPtr == IntPtr.Zero) {ppixmb = null;} else { ppixmb = new Pix(ppixmbPtr); };
	return _Result;
}

// adaptmap.c (1219, 1)
// pixGetBackgroundGrayMapMorph(pixs, pixim, reduction, size, ppixm) as int
// pixGetBackgroundGrayMapMorph(PIX *, PIX *, l_int32, l_int32, PIX **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBackgroundGrayMapMorph/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale not cmapped</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null it should not have all foreground pixels</param>
///  <param name="reduction">[in] - factor at which closing is performed</param>
///  <param name="size">[in] - of square Sel for the closing use an odd number</param>
///  <param name="ppixm">[out] - grayscale map</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetBackgroundGrayMapMorph(
				 Pix pixs, 
				 Pix pixim, 
				 int reduction, 
				 int size, 
				out Pix ppixm){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixmPtr = IntPtr.Zero;

	int _Result = Natives.pixGetBackgroundGrayMapMorph(pixs.Pointer, piximPtr,   reduction,   size, out ppixmPtr);
	
	if (ppixmPtr == IntPtr.Zero) {ppixm = null;} else { ppixm = new Pix(ppixmPtr); };
	return _Result;
}

// adaptmap.c (1310, 1)
// pixGetBackgroundRGBMapMorph(pixs, pixim, reduction, size, ppixmr, ppixmg, ppixmb) as int
// pixGetBackgroundRGBMapMorph(PIX *, PIX *, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBackgroundRGBMapMorph/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null it should not have all foreground pixels</param>
///  <param name="reduction">[in] - factor at which closing is performed</param>
///  <param name="size">[in] - of square Sel for the closing use an odd number</param>
///  <param name="ppixmr">[out] - red component map</param>
///  <param name="ppixmg">[out] - green component map</param>
///  <param name="ppixmb">[out] - blue component map</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixGetBackgroundRGBMapMorph(
				 Pix pixs, 
				 Pix pixim, 
				 int reduction, 
				 int size, 
				out Pix ppixmr, 
				out Pix ppixmg, 
				out Pix ppixmb){

	IntPtr piximPtr = IntPtr.Zero; 	if (pixim != null) {piximPtr = pixim.Pointer;}
	IntPtr ppixmrPtr = IntPtr.Zero;
	IntPtr ppixmgPtr = IntPtr.Zero;
	IntPtr ppixmbPtr = IntPtr.Zero;

	int _Result = Natives.pixGetBackgroundRGBMapMorph(pixs.Pointer, piximPtr,   reduction,   size, out ppixmrPtr, out ppixmgPtr, out ppixmbPtr);
	
	if (ppixmrPtr == IntPtr.Zero) {ppixmr = null;} else { ppixmr = new Pix(ppixmrPtr); };
	if (ppixmgPtr == IntPtr.Zero) {ppixmg = null;} else { ppixmg = new Pix(ppixmgPtr); };
	if (ppixmbPtr == IntPtr.Zero) {ppixmb = null;} else { ppixmb = new Pix(ppixmbPtr); };
	return _Result;
}

// adaptmap.c (1464, 1)
// pixFillMapHoles(pix, nx, ny, filltype) as int
// pixFillMapHoles(PIX *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place operation on pix (the map).  pix is
/// typically a low-resolution version of some other image
/// from which it was derived, where each pixel in pix
/// corresponds to a rectangular tile (say, m x n) of pixels
/// in the larger image.  All we need to know about the larger
/// image is whether or not the rightmost column and bottommost
/// row of pixels in pix correspond to tiles that are
/// only partially covered by pixels in the larger image.<para/>
/// 
/// (2) Typically, some number of pixels in the input map are
/// not known, and their values must be determined by near
/// pixels that are known.  These unknown pixels are the 'holes'.
/// They can take on only two values, 0 and 255, and the
/// instruction about which to fill is given by the filltype flag.<para/>
/// 
/// (3) The "holes" can come from two sources.  The first is when there
/// are not enough foreground or background pixels in a tile
/// the second is when a tile is at least partially covered
/// by an image mask.  If we're filling holes in a fg mask,
/// the holes are initialized to black (0) and use L_FILL_BLACK.
/// For filling holes in a bg mask, initialize the holes to
/// white (255) and use L_FILL_WHITE.<para/>
/// 
/// (4) If w is the map width, nx = w or nx = w - 1 ditto for h and ny.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFillMapHoles/*"/>
///  <param name="pix">[in] - 8 bpp a map, with one pixel for each tile in a larger image</param>
///  <param name="nx">[in] - number of horizontal pixel tiles that are entirely covered with pixels in the original source image</param>
///  <param name="ny">[in] - ditto for the number of vertical pixel tiles</param>
///  <param name="filltype">[in] - L_FILL_WHITE or L_FILL_BLACK</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixFillMapHoles(
				 Pix pix, 
				 int nx, 
				 int ny, 
				 int filltype){

	int _Result = Natives.pixFillMapHoles(pix.Pointer,   nx,   ny,   filltype);
	
	return _Result;
}

// adaptmap.c (1576, 1)
// pixExtendByReplication(pixs, addw, addh) as Pix
// pixExtendByReplication(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The pixel values are extended to the left and down, as required.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtendByReplication/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="addw">[in] - number of extra pixels horizontally to add</param>
///  <param name="addh">[in] - number of extra pixels vertically to add</param>
///   <returns>pixd extended with replicated pixel values, or NULL on error</returns>
public static Pix pixExtendByReplication(
				 Pix pixs, 
				 int addw, 
				 int addh){

	IntPtr _Result = Natives.pixExtendByReplication(pixs.Pointer,   addw,   addh);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (1639, 1)
// pixSmoothConnectedRegions(pixs, pixm, factor) as int
// pixSmoothConnectedRegions(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) The pixels in pixs corresponding to those in each
/// 8-connected region in the mask are set to the average value.<para/>
/// 
/// (2) This is required for adaptive mapping to avoid the
/// generation of stripes in the background map, due to
/// variations in the pixel values near the edges of mask regions.<para/>
/// 
/// (3) This function is optimized for background smoothing, where
/// there are a relatively small number of components.  It will
/// be inefficient if used where there are many small components.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSmoothConnectedRegions/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale no colormap</param>
///  <param name="pixm">[in][optional] - 1 bpp if null, this is a no-op</param>
///  <param name="factor">[in] - subsampling factor for getting average greater or equal 1</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSmoothConnectedRegions(
				 Pix pixs, 
				 Pix pixm, 
				 int factor){

	IntPtr pixmPtr = IntPtr.Zero; 	if (pixm != null) {pixmPtr = pixm.Pointer;}

	int _Result = Natives.pixSmoothConnectedRegions(pixs.Pointer, pixmPtr,   factor);
	
	return _Result;
}

// adaptmap.c (1840, 1)
// pixGetInvBackgroundMap(pixs, bgval, smoothx, smoothy) as Pix
// pixGetInvBackgroundMap(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) bgval should typically be  is greater  120 and  is smaller 240<para/>
/// 
/// (2) pixd is a normalization image the original image is
/// multiplied by pixd and the result is divided by 256.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetInvBackgroundMap/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale no colormap</param>
///  <param name="bgval">[in] - target bg val typ.  is greater  128</param>
///  <param name="smoothx">[in] - half-width of block convolution kernel width</param>
///  <param name="smoothy">[in] - half-width of block convolution kernel height</param>
///   <returns>pixd 16 bpp, or NULL on error</returns>
public static Pix pixGetInvBackgroundMap(
				 Pix pixs, 
				 int bgval, 
				 int smoothx, 
				 int smoothy){

	IntPtr _Result = Natives.pixGetInvBackgroundMap(pixs.Pointer,   bgval,   smoothx,   smoothy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (1903, 1)
// pixApplyInvBackgroundGrayMap(pixs, pixm, sx, sy) as Pix
// pixApplyInvBackgroundGrayMap(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixApplyInvBackgroundGrayMap/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale no colormap</param>
///  <param name="pixm">[in] - 16 bpp, inverse background map</param>
///  <param name="sx">[in] - tile width in pixels</param>
///  <param name="sy">[in] - tile height in pixels</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix pixApplyInvBackgroundGrayMap(
				 Pix pixs, 
				 Pix pixm, 
				 int sx, 
				 int sy){

	IntPtr _Result = Natives.pixApplyInvBackgroundGrayMap(pixs.Pointer, pixm.Pointer,   sx,   sy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (1969, 1)
// pixApplyInvBackgroundRGBMap(pixs, pixmr, pixmg, pixmb, sx, sy) as Pix
// pixApplyInvBackgroundRGBMap(PIX *, PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixApplyInvBackgroundRGBMap/*"/>
///  <param name="pixs">[in] - 32 bpp rbg</param>
///  <param name="pixmr">[in] - 16 bpp, red inverse background map</param>
///  <param name="pixmg">[in] - 16 bpp, green inverse background map</param>
///  <param name="pixmb">[in] - 16 bpp, blue inverse background map</param>
///  <param name="sx">[in] - tile width in pixels</param>
///  <param name="sy">[in] - tile height in pixels</param>
///   <returns>pixd 32 bpp rbg, or NULL on error</returns>
public static Pix pixApplyInvBackgroundRGBMap(
				 Pix pixs, 
				 Pix pixmr, 
				 Pix pixmg, 
				 Pix pixmb, 
				 int sx, 
				 int sy){

	IntPtr _Result = Natives.pixApplyInvBackgroundRGBMap(pixs.Pointer, pixmr.Pointer, pixmg.Pointer, pixmb.Pointer,   sx,   sy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2067, 1)
// pixApplyVariableGrayMap(pixs, pixg, target) as Pix
// pixApplyVariableGrayMap(PIX *, PIX *, l_int32) as PIX *
///  <summary>
/// (1) Suppose you have an image that you want to transform based
/// on some photometric measurement at each point, such as the
/// threshold value for binarization.  Representing the photometric
/// measurement as an image pixg, you can threshold in input image
/// using pixVarThresholdToBinary().  Alternatively, you can map
/// the input image pointwise so that the threshold over the
/// entire image becomes a constant, such as 128.  For example,
/// if a pixel in pixg is 150 and the target is 128, the
/// corresponding pixel in pixs is mapped linearly to a value
/// (128/150) of the input value.  If the resulting mapped image
/// pixd were then thresholded at 128, you would obtain the
/// same result as a direct binarization using pixg with
/// pixVarThresholdToBinary().<para/>
/// 
/// (2) The sizes of pixs and pixg must be equal.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixApplyVariableGrayMap/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixg">[in] - 8 bpp, variable map</param>
///  <param name="target">[in] - typ. 128 for threshold</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
public static Pix pixApplyVariableGrayMap(
				 Pix pixs, 
				 Pix pixg, 
				 int target){

	IntPtr _Result = Natives.pixApplyVariableGrayMap(pixs.Pointer, pixg.Pointer,   target);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2185, 1)
// pixGlobalNormRGB(pixd, pixs, rval, gval, bval, mapval) as Pix
// pixGlobalNormRGB(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The value of pixd determines if the results are written to a
/// new pix (use NULL), in-place to pixs (use pixs), or to some
/// other existing pix.<para/>
/// 
/// (2) This does a global normalization of an image where the
/// r,g,b color components are not balanced.  Thus, white in pixs is
/// represented by a set of r,g,b values that are not all 255.<para/>
/// 
/// (3) The input values (rval, gval, bval) should be chosen to
/// represent the gray color (mapval, mapval, mapval) in src.
/// Thus, this function will map (rval, gval, bval) to that gray color.<para/>
/// 
/// (4) Typically, mapval = 255, so that (rval, gval, bval)
/// corresponds to the white point of src.  In that case, these
/// parameters should be chosen so that few pixels have higher values.<para/>
/// 
/// (5) In all cases, we do a linear TRC separately on each of the
/// components, saturating at 255.<para/>
/// 
/// (6) If the input pix is 8 bpp without a colormap, you can get
/// this functionality with mapval = 255 by calling:
/// pixGammaTRC(pixd, pixs, 1.0, 0, bgval)
/// where bgval is the value you want to be mapped to 255.
/// Or more generally, if you want bgval to be mapped to mapval:
/// pixGammaTRC(pixd, pixs, 1.0, 0, 255  bgval / mapval)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGlobalNormRGB/*"/>
///  <param name="pixd">[in][optional] - null, existing or equal to pixs</param>
///  <param name="pixs">[in] - 32 bpp rgb, or colormapped</param>
///  <param name="rval">[in] - pixel values in pixs that are linearly mapped to mapval</param>
///  <param name="gval">[in] - pixel values in pixs that are linearly mapped to mapval</param>
///  <param name="bval">[in] - pixel values in pixs that are linearly mapped to mapval</param>
///  <param name="mapval">[in] - use 255 for mapping to white</param>
///   <returns>pixd 32 bpp rgb or colormapped, or NULL on error</returns>
public static Pix pixGlobalNormRGB(
				 Pix pixd, 
				 Pix pixs, 
				 int rval, 
				 int gval, 
				 int bval, 
				 int mapval){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixGlobalNormRGB(pixdPtr, pixs.Pointer,   rval,   gval,   bval,   mapval);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2294, 1)
// pixGlobalNormNoSatRGB(pixd, pixs, rval, gval, bval, factor, rank) as Pix
// pixGlobalNormNoSatRGB(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_float32) as PIX *
///  <summary>
/// (1) This is a version of pixGlobalNormRGB(), where the output
/// intensity is scaled back so that a controlled fraction of
/// pixel components is allowed to saturate.  See comments in
/// pixGlobalNormRGB().<para/>
/// 
/// (2) The value of pixd determines if the results are written to a
/// new pix (use NULL), in-place to pixs (use pixs), or to some
/// other existing pix.<para/>
/// 
/// (3) This does a global normalization of an image where the
/// r,g,b color components are not balanced.  Thus, white in pixs is
/// represented by a set of r,g,b values that are not all 255.<para/>
/// 
/// (4) The input values (rval, gval, bval) can be chosen to be the
/// color that, after normalization, becomes white background.
/// For images that are mostly background, the closer these values
/// are to the median component values, the closer the resulting
/// background will be to gray, becoming white at the brightest places.<para/>
/// 
/// (5) The mapval used in pixGlobalNormRGB() is computed here to
/// avoid saturation of any component in the image (save for a
/// fraction of the pixels given by the input rank value).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGlobalNormNoSatRGB/*"/>
///  <param name="pixd">[in][optional] - null, existing or equal to pixs</param>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="rval">[in] - pixel values in pixs that are linearly mapped to mapval but see below</param>
///  <param name="gval">[in] - pixel values in pixs that are linearly mapped to mapval but see below</param>
///  <param name="bval">[in] - pixel values in pixs that are linearly mapped to mapval but see below</param>
///  <param name="factor">[in] - subsampling factor integer greater or equal 1</param>
///  <param name="rank">[in] - between 0.0 and 1.0 typ. use a value near 1.0</param>
///   <returns>pixd 32 bpp rgb, or NULL on error</returns>
public static Pix pixGlobalNormNoSatRGB(
				 Pix pixd, 
				 Pix pixs, 
				 int rval, 
				 int gval, 
				 int bval, 
				 int factor, 
				 Single rank){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixGlobalNormNoSatRGB(pixdPtr, pixs.Pointer,   rval,   gval,   bval,   factor,   rank);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2394, 1)
// pixThresholdSpreadNorm(pixs, filtertype, edgethresh, smoothx, smoothy, gamma, minval, maxval, targetthresh, ppixth, ppixb, ppixd) as int
// pixThresholdSpreadNorm(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
///  <summary>
/// (1) The basis of this approach is the use of seed spreading
/// on a (possibly) sparse set of estimates for the local threshold.
/// The resulting dense estimates are smoothed by convolution
/// and used to either threshold the input image or normalize it
/// with a local transformation that linearly maps the pixels so
/// that the local threshold estimate becomes constant over the
/// resulting image.  This approach is one of several that
/// have been suggested (and implemented) by Ray Smith.<para/>
/// 
/// (2) You can use either the Sobel or TwoSided edge filters.
/// The results appear to be similar, using typical values
/// of edgethresh in the rang 10-20.<para/>
/// 
/// (3) To skip the trc enhancement, use gamma = 1.0, minval = 0
/// and maxval = 255.<para/>
/// 
/// (4) For the normalized image pixd, each pixel is linearly mapped
/// in such a way that the local threshold is equal to targetthresh.<para/>
/// 
/// (5) The full width and height of the convolution kernel
/// are (2  smoothx + 1) and (2  smoothy + 1).<para/>
/// 
/// (6) This function can be used with the pixtiling utility if the
/// images are too large.  See pixOtsuAdaptiveThreshold() for
/// an example of this.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixThresholdSpreadNorm/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
///  <param name="filtertype">[in] - L_SOBEL_EDGE or L_TWO_SIDED_EDGE</param>
///  <param name="edgethresh">[in] - threshold on magnitude of edge filter typ 10-20</param>
///  <param name="smoothx">[in] - half-width of convolution kernel applied to spread threshold: use 0 for no smoothing</param>
///  <param name="smoothy">[in] - half-width of convolution kernel applied to spread threshold: use 0 for no smoothing</param>
///  <param name="gamma">[in] - gamma correction typ. about 0.7</param>
///  <param name="minval">[in] - input value that gives 0 for output typ. -25</param>
///  <param name="maxval">[in] - input value that gives 255 for output typ. 255</param>
///  <param name="targetthresh">[in] - target threshold for normalization</param>
///  <param name="ppixth">[out][optional] - computed local threshold value</param>
///  <param name="ppixb">[out][optional] - thresholded normalized image</param>
///  <param name="ppixd">[out][optional] - normalized image</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixThresholdSpreadNorm(
				 Pix pixs, 
				 int filtertype, 
				 int edgethresh, 
				 int smoothx, 
				 int smoothy, 
				 Single gamma, 
				 int minval, 
				 int maxval, 
				 int targetthresh, 
				out Pix ppixth, 
				out Pix ppixb, 
				out Pix ppixd){

	IntPtr ppixthPtr = IntPtr.Zero;
	IntPtr ppixbPtr = IntPtr.Zero;
	IntPtr ppixdPtr = IntPtr.Zero;

	int _Result = Natives.pixThresholdSpreadNorm(pixs.Pointer,   filtertype,   edgethresh,   smoothx,   smoothy,   gamma,   minval,   maxval,   targetthresh, out ppixthPtr, out ppixbPtr, out ppixdPtr);
	
	if (ppixthPtr == IntPtr.Zero) {ppixth = null;} else { ppixth = new Pix(ppixthPtr); };
	if (ppixbPtr == IntPtr.Zero) {ppixb = null;} else { ppixb = new Pix(ppixbPtr); };
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	return _Result;
}

// adaptmap.c (2500, 1)
// pixBackgroundNormFlex(pixs, sx, sy, smoothx, smoothy, delta) as Pix
// pixBackgroundNormFlex(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This does adaptation flexibly to a quickly varying background.
/// For that reason, all input parameters should be small.<para/>
/// 
/// (2) sx and sy give the tile size they should be in [5 - 7].<para/>
/// 
/// (3) The full width and height of the convolution kernel
/// are (2  smoothx + 1) and (2  smoothy + 1).  They
/// should be in [1 - 2].<para/>
/// 
/// (4) Basin filling is used to fill the large fg regions.  The
/// parameter %delta measures the height that the black
/// background is raised from the local minima.  By raising
/// the background, it is possible to threshold the large
/// fg regions to foreground.  If %delta is too large,
/// bg regions will be lifted, causing thickening of
/// the fg regions.  Use 0 to skip.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormFlex/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
///  <param name="sx">[in] - desired tile dimensions actual size may vary use values between 3 and 10</param>
///  <param name="sy">[in] - desired tile dimensions actual size may vary use values between 3 and 10</param>
///  <param name="smoothx">[in] - half-width of convolution kernel applied to threshold array: use values between 1 and 3</param>
///  <param name="smoothy">[in] - half-width of convolution kernel applied to threshold array: use values between 1 and 3</param>
///  <param name="delta">[in] - difference parameter in basin filling use 0 to skip</param>
///   <returns>pixd 8 bpp, background-normalized), or NULL on error</returns>
public static Pix pixBackgroundNormFlex(
				 Pix pixs, 
				 int sx, 
				 int sy, 
				 int smoothx, 
				 int smoothy, 
				 int delta){

	IntPtr _Result = Natives.pixBackgroundNormFlex(pixs.Pointer,   sx,   sy,   smoothx,   smoothy,   delta);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2595, 1)
// pixContrastNorm(pixd, pixs, sx, sy, mindiff, smoothx, smoothy) as Pix
// pixContrastNorm(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This function adaptively attempts to expand the contrast
/// to the full dynamic range in each tile.  If the contrast in
/// a tile is smaller than %mindiff, it uses the min and max
/// pixel values from neighboring tiles.  It also can use
/// convolution to smooth the min and max values from
/// neighboring tiles.  After all that processing, it is
/// possible that the actual pixel values in the tile are outside
/// the computed [min ... max] range for local contrast
/// normalization.  Such pixels are taken to be at either 0
/// (if below the min) or 255 (if above the max).<para/>
/// 
/// (2) pixd can be equal to pixs (in-place operation) or
/// null (makes a new pixd).<para/>
/// 
/// (3) sx and sy give the tile size they are typically at least 20.<para/>
/// 
/// (4) mindiff is used to eliminate results for tiles where it is
/// likely that either fg or bg is missing.  A value around 50
/// or more is reasonable.<para/>
/// 
/// (5) The full width and height of the convolution kernel
/// are (2  smoothx + 1) and (2  smoothy + 1).  Some smoothing
/// is typically useful, and we limit the smoothing half-widths
/// to the range from 0 to 8.<para/>
/// 
/// (6) A linear TRC (gamma = 1.0) is applied to increase the contrast
/// in each tile.  The result can subsequently be globally corrected,
/// by applying pixGammaTRC() with arbitrary values of gamma
/// and the 0 and 255 points of the mapping.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixContrastNorm/*"/>
///  <param name="pixd">[in][optional] - 8 bpp null or equal to pixs</param>
///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
///  <param name="sx">[in] - tile dimensions</param>
///  <param name="sy">[in] - tile dimensions</param>
///  <param name="mindiff">[in] - minimum difference to accept as valid</param>
///  <param name="smoothx">[in] - half-width of convolution kernel applied to min and max arrays: use 0 for no smoothing</param>
///  <param name="smoothy">[in] - half-width of convolution kernel applied to min and max arrays: use 0 for no smoothing</param>
///   <returns>pixd always</returns>
public static Pix pixContrastNorm(
				 Pix pixd, 
				 Pix pixs, 
				 int sx, 
				 int sy, 
				 int mindiff, 
				 int smoothx, 
				 int smoothy){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixContrastNorm(pixdPtr, pixs.Pointer,   sx,   sy,   mindiff,   smoothx,   smoothy);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// adaptmap.c (2655, 1)
// pixMinMaxTiles(pixs, sx, sy, mindiff, smoothx, smoothy, ppixmin, ppixmax) as int
// pixMinMaxTiles(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **, PIX **) as l_ok
///  <summary>
/// (1) This computes filtered and smoothed values for the min and
/// max pixel values in each tile of the image.<para/>
/// 
/// (2) See pixContrastNorm() for usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMinMaxTiles/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale not colormapped</param>
///  <param name="sx">[in] - tile dimensions</param>
///  <param name="sy">[in] - tile dimensions</param>
///  <param name="mindiff">[in] - minimum difference to accept as valid</param>
///  <param name="smoothx">[in] - half-width of convolution kernel applied to min and max arrays: use 0 for no smoothing</param>
///  <param name="smoothy">[in] - half-width of convolution kernel applied to min and max arrays: use 0 for no smoothing</param>
///  <param name="ppixmin">[out] - tiled minima</param>
///  <param name="ppixmax">[out] - tiled maxima</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixMinMaxTiles(
				 Pix pixs, 
				 int sx, 
				 int sy, 
				 int mindiff, 
				 int smoothx, 
				 int smoothy, 
				out Pix ppixmin, 
				out Pix ppixmax){

	IntPtr ppixminPtr = IntPtr.Zero;
	IntPtr ppixmaxPtr = IntPtr.Zero;

	int _Result = Natives.pixMinMaxTiles(pixs.Pointer,   sx,   sy,   mindiff,   smoothx,   smoothy, out ppixminPtr, out ppixmaxPtr);
	
	if (ppixminPtr == IntPtr.Zero) {ppixmin = null;} else { ppixmin = new Pix(ppixminPtr); };
	if (ppixmaxPtr == IntPtr.Zero) {ppixmax = null;} else { ppixmax = new Pix(ppixmaxPtr); };
	return _Result;
}

// adaptmap.c (2746, 1)
// pixSetLowContrast(pixs1, pixs2, mindiff) as int
// pixSetLowContrast(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This compares corresponding pixels in pixs1 and pixs2.
/// When they differ by less than %mindiff, set the pixel
/// values to 0 in each.  Each pixel typically represents a tile
/// in a larger image, and a very small difference between
/// the min and max in the tile indicates that the min and max
/// values are not to be trusted.<para/>
/// 
/// (2) If contrast (pixel difference) detection is expected to fail,
/// caller should check return value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetLowContrast/*"/>
///  <param name="pixs1">[in] - 8 bpp</param>
///  <param name="pixs2">[in] - 8 bpp</param>
///  <param name="mindiff">[in] - minimum difference to accept as valid</param>
///   <returns>0 if OK 1 if no pixel diffs are large enough, or on error</returns>
public static int pixSetLowContrast(
				 Pix pixs1, 
				 Pix pixs2, 
				 int mindiff){

	int _Result = Natives.pixSetLowContrast(pixs1.Pointer, pixs2.Pointer,   mindiff);
	
	return _Result;
}

// adaptmap.c (2829, 1)
// pixLinearTRCTiled(pixd, pixs, sx, sy, pixmin, pixmax) as Pix
// pixLinearTRCTiled(PIX *, PIX *, l_int32, l_int32, PIX *, PIX *) as PIX *
///  <summary>
/// (1) pixd can be equal to pixs (in-place operation) or
/// null (makes a new pixd).<para/>
/// 
/// (2) sx and sy give the tile size they are typically at least 20.<para/>
/// 
/// (3) pixmin and pixmax are generated by pixMinMaxTiles()<para/>
/// 
/// (4) For each tile, this does a linear expansion of the dynamic
/// range so that the min value in the tile becomes 0 and the
/// max value in the tile becomes 255.<para/>
/// 
/// (5) The LUTs that do the mapping are generated as needed
/// and stored for reuse in an integer array within the ptr array iaa[].
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLinearTRCTiled/*"/>
///  <param name="pixd">[in][optional] - 8 bpp</param>
///  <param name="pixs">[in] - 8 bpp, not colormapped</param>
///  <param name="sx">[in] - tile dimensions</param>
///  <param name="sy">[in] - tile dimensions</param>
///  <param name="pixmin">[in] - pix of min values in tiles</param>
///  <param name="pixmax">[in] - pix of max values in tiles</param>
///   <returns>pixd always</returns>
public static Pix pixLinearTRCTiled(
				 Pix pixd, 
				 Pix pixs, 
				 int sx, 
				 int sy, 
				 Pix pixmin, 
				 Pix pixmax){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixLinearTRCTiled(pixdPtr, pixs.Pointer,   sx,   sy, pixmin.Pointer, pixmax.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
