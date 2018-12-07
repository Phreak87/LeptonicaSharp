using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// convolve.c (127, 1)
// pixBlockconv(pix, wc, hc) as Pix
// pixBlockconv(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1)<para/>
/// 
/// (2) Returns a copy if both wc and hc are 0<para/>
/// 
/// (3) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconv/*"/>
///  <param name="pix">[in] - 8 or 32 bpp or 2, 4 or 8 bpp with colormap</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixBlockconv(
				 Pix pix, 
				 int wc, 
				 int hc){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr _Result = Natives.pixBlockconv(pix.Pointer,   wc,   hc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (210, 1)
// pixBlockconvGray(pixs, pixacc, wc, hc) as Pix
// pixBlockconvGray(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) If accum pix is null, make one and destroy it before
/// returning otherwise, just use the input accum pix.<para/>
/// 
/// (2) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1).<para/>
/// 
/// (3) Returns a copy if both wc and hc are 0.<para/>
/// 
/// (4) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconvGray/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixacc">[in] - pix 32 bpp can be null</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///   <returns>pix 8 bpp, or NULL on error</returns>
public static Pix pixBlockconvGray(
				 Pix pixs, 
				 Pix pixacc, 
				 int wc, 
				 int hc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr _Result = Natives.pixBlockconvGray(pixs.Pointer, pixacc.Pointer,   wc,   hc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (455, 1)
// pixBlockconvAccum(pixs) as Pix
// pixBlockconvAccum(PIX *) as PIX *
///  <summary>
/// (1) The general recursion relation is
/// a(i,j) = v(i,j) + a(i-1, j) + a(i, j-1) - a(i-1, j-1)
/// For the first line, this reduces to the special case
/// a(i,j) = v(i,j) + a(i, j-1)
/// For the first column, the special case is
/// a(i,j) = v(i,j) + a(i-1, j)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconvAccum/*"/>
///  <param name="pixs">[in] - 1, 8 or 32 bpp</param>
///   <returns>accum pix 32 bpp, or NULL on error.</returns>
public static Pix pixBlockconvAccum(
				 Pix pixs){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixBlockconvAccum(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (636, 1)
// pixBlockconvGrayUnnormalized(pixs, wc, hc) as Pix
// pixBlockconvGrayUnnormalized(PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1).<para/>
/// 
/// (2) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.<para/>
/// 
/// (3) Returns a copy if both wc and hc are 0.<para/>
/// 
/// (3) Adds mirrored border to avoid treating the boundary pixels
/// specially.  Note that we add wc + 1 pixels to the left
/// and wc to the right.  The added width is 2  wc + 1 pixels,
/// and the particular choice simplifies the indexing in the loop.
/// Likewise, add hc + 1 pixels to the top and hc to the bottom.<para/>
/// 
/// (4) To get the normalized result, divide by the area of the
/// convolution kernel: (2  wc + 1)  (2  hc + 1)
/// Specifically, do this:
/// pixc = pixBlockconvGrayUnnormalized(pixs, wc, hc)
/// fract = 1. / ((2  wc + 1)  (2  hc + 1))
/// pixMultConstantGray(pixc, fract)
/// pixd = pixGetRGBComponent(pixc, L_ALPHA_CHANNEL)<para/>
/// 
/// (5) Unlike pixBlockconvGray(), this always computes the accumulation
/// pix because its size is tied to wc and hc.<para/>
/// 
/// (6) Compare this implementation with pixBlockconvGray(), where
/// most of the code in blockconvLow() is special casing for
/// efficiently handling the boundary.  Here, the use of
/// mirrored borders and destination indexing makes the
/// implementation very simple.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconvGrayUnnormalized/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///   <returns>pix 32 bpp containing the convolution without normalizing for the window size, or NULL on error</returns>
public static Pix pixBlockconvGrayUnnormalized(
				 Pix pixs, 
				 int wc, 
				 int hc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr _Result = Natives.pixBlockconvGrayUnnormalized(pixs.Pointer,   wc,   hc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (727, 1)
// pixBlockconvTiled(pix, wc, hc, nx, ny) as Pix
// pixBlockconvTiled(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1)<para/>
/// 
/// (2) Returns a copy if both wc and hc are 0<para/>
/// 
/// (3) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.<para/>
/// 
/// (4) For nx == ny == 1, this defaults to pixBlockconv(), which
/// is typically about twice as fast, and gives nearly
/// identical results as pixBlockconvGrayTile().<para/>
/// 
/// (5) If the tiles are too small, nx and/or ny are reduced
/// a minimum amount so that the tiles are expanded to the
/// smallest workable size in the problematic direction(s).<para/>
/// 
/// (6) Why a tiled version?  Three reasons:
/// (a) Because the accumulator is a uint32, overflow can occur
/// for an image with more than 16M pixels.
/// (b) The accumulator array for 16M pixels is 64 MB using
/// tiles reduces the size of this array.
/// (c) Each tile can be processed independently, in parallel,
/// on a multicore processor.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconvTiled/*"/>
///  <param name="pix">[in] - 8 or 32 bpp or 2, 4 or 8 bpp with colormap</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///  <param name="nx">[in] - subdivision into tiles</param>
///  <param name="ny">[in] - subdivision into tiles</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixBlockconvTiled(
				 Pix pix, 
				 int wc, 
				 int hc, 
				 int nx, 
				 int ny){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr _Result = Natives.pixBlockconvTiled(pix.Pointer,   wc,   hc,   nx,   ny);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (853, 1)
// pixBlockconvGrayTile(pixs, pixacc, wc, hc) as Pix
// pixBlockconvGrayTile(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1)<para/>
/// 
/// (2) Assumes that the input pixs is padded with (wc + 1) pixels on
/// left and right, and with (hc + 1) pixels on top and bottom.
/// The returned pix has these stripped off they are only used
/// for computation.<para/>
/// 
/// (3) Returns a copy if both wc and hc are 0<para/>
/// 
/// (4) Require that w  is greater  2  wc + 1 and h  is greater  2  hc + 1,
/// where (w,h) are the dimensions of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockconvGrayTile/*"/>
///  <param name="pixs">[in] - 8 bpp gray</param>
///  <param name="pixacc">[in] - 32 bpp accum pix</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixBlockconvGrayTile(
				 Pix pixs, 
				 Pix pixacc, 
				 int wc, 
				 int hc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}
	IntPtr _Result = Natives.pixBlockconvGrayTile(pixs.Pointer, pixacc.Pointer,   wc,   hc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (980, 1)
// pixWindowedStats(pixs, wc, hc, hasborder, ppixm, ppixms, pfpixv, pfpixrv) as int
// pixWindowedStats(PIX *, l_int32, l_int32, l_int32, PIX **, PIX **, FPIX **, FPIX **) as l_ok
///  <summary>
/// (1) This is a high-level convenience function for calculating
/// any or all of these derived images.<para/>
/// 
/// (2) If %hasborder = 0, a border is added and the result is
/// computed over all pixels in pixs.  Otherwise, no border is
/// added and the border pixels are removed from the output images.<para/>
/// 
/// (3) These statistical measures over the pixels in the
/// rectangular window are:
/// ~ average value:  is smallerp is greater (pixm)
/// ~ average squared value:  is smallerpp is greater  (pixms)
/// ~ variance:  is smaller(p -  is smallerp is greater )(p -  is smallerp is greater ) is greater  =  is smallerpp is greater  -  is smallerp is greater  is smallerp is greater (pixv)
/// ~ square-root of variance: (pixrv)
/// where the brackets  is smaller ..  is greater  indicate that the average value is
/// to be taken over the window.<para/>
/// 
/// (4) Note that the variance is just the mean square difference from
/// the mean value and the square root of the variance is the
/// root mean square difference from the mean, sometimes also
/// called the 'standard deviation'.<para/>
/// 
/// (5) The added border, along with the use of an accumulator array,
/// allows computation without special treatment of pixels near
/// the image boundary, and runs in a time that is independent
/// of the size of the convolution kernel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWindowedStats/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///  <param name="hasborder">[in] - use 1 if it already has (wc + 1 border pixels on left and right, and hc + 1 on top and bottom use 0 to add kernel-dependent border)</param>
///  <param name="ppixm">[out][optional] - 8 bpp mean value in window</param>
///  <param name="ppixms">[out][optional] - 32 bpp mean square value in window</param>
///  <param name="pfpixv">[out][optional] - float variance in window</param>
///  <param name="pfpixrv">[out][optional] - float rms deviation from the mean</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWindowedStats(
				 Pix pixs, 
				 int wc, 
				 int hc, 
				 int hasborder, 
				out Pix ppixm, 
				out Pix ppixms, 
				out FPix pfpixv, 
				out FPix pfpixrv){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp grayscale"); }
	IntPtr ppixmPtr = IntPtr.Zero;
	IntPtr ppixmsPtr = IntPtr.Zero;
	IntPtr pfpixvPtr = IntPtr.Zero;
	IntPtr pfpixrvPtr = IntPtr.Zero;

	int _Result = Natives.pixWindowedStats(pixs.Pointer,   wc,   hc,   hasborder, out ppixmPtr, out ppixmsPtr, out pfpixvPtr, out pfpixrvPtr);
	
	if (ppixmPtr == IntPtr.Zero) {ppixm = null;} else { ppixm = new Pix(ppixmPtr); };
	if (ppixmsPtr == IntPtr.Zero) {ppixms = null;} else { ppixms = new Pix(ppixmsPtr); };
	if (pfpixvPtr == IntPtr.Zero) {pfpixv = null;} else { pfpixv = new FPix(pfpixvPtr); };
	if (pfpixrvPtr == IntPtr.Zero) {pfpixrv = null;} else { pfpixrv = new FPix(pfpixrvPtr); };
	return _Result;
}

// convolve.c (1065, 1)
// pixWindowedMean(pixs, wc, hc, hasborder, normflag) as Pix
// pixWindowedMean(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The input and output depths are the same.<para/>
/// 
/// (2) A set of border pixels of width (wc + 1) on left and right,
/// and of height (hc + 1) on top and bottom, must be on the
/// pix before the accumulator is found.  The output pixd
/// (after convolution) has this border removed.
/// If %hasborder = 0, the required border is added.<para/>
/// 
/// (3) Typically, %normflag == 1.  However, if you want the sum
/// within the window, rather than a normalized convolution,
/// use %normflag == 0.<para/>
/// 
/// (4) This builds a block accumulator pix, uses it here, and
/// destroys it.<para/>
/// 
/// (5) The added border, along with the use of an accumulator array,
/// allows computation without special treatment of pixels near
/// the image boundary, and runs in a time that is independent
/// of the size of the convolution kernel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWindowedMean/*"/>
///  <param name="pixs">[in] - 8 or 32 bpp grayscale</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///  <param name="hasborder">[in] - use 1 if it already has (wc + 1 border pixels on left and right, and hc + 1 on top and bottom use 0 to add kernel-dependent border)</param>
///  <param name="normflag">[in] - 1 for normalization to get average in window 0 for the sum in the window (un-normalized)</param>
///   <returns>pixd 8 or 32 bpp, average over kernel window</returns>
public static Pix pixWindowedMean(
				 Pix pixs, 
				 int wc, 
				 int hc, 
				 int hasborder, 
				 int normflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixWindowedMean(pixs.Pointer,   wc,   hc,   hasborder,   normflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (1182, 1)
// pixWindowedMeanSquare(pixs, wc, hc, hasborder) as Pix
// pixWindowedMeanSquare(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) A set of border pixels of width (wc + 1) on left and right,
/// and of height (hc + 1) on top and bottom, must be on the
/// pix before the accumulator is found.  The output pixd
/// (after convolution) has this border removed.
/// If %hasborder = 0, the required border is added.<para/>
/// 
/// (2) The advantage is that we are unaffected by the boundary, and
/// it is not necessary to treat pixels within %wc and %hc of the
/// border differently.  This is because processing for pixd
/// only takes place for pixels in pixs for which the
/// kernel is entirely contained in pixs.<para/>
/// 
/// (3) Why do we have an added border of width (%wc + 1) and
/// height (%hc + 1), when we only need %wc and %hc pixels
/// to satisfy this condition?  Answer: the accumulators
/// are asymmetric, requiring an extra row and column of
/// pixels at top and left to work accurately.<para/>
/// 
/// (4) The added border, along with the use of an accumulator array,
/// allows computation without special treatment of pixels near
/// the image boundary, and runs in a time that is independent
/// of the size of the convolution kernel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWindowedMeanSquare/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///  <param name="wc">[in] - half width/height of convolution kernel</param>
///  <param name="hc">[in] - half width/height of convolution kernel</param>
///  <param name="hasborder">[in] - use 1 if it already has (wc + 1 border pixels on left and right, and hc + 1 on top and bottom use 0 to add kernel-dependent border)</param>
///   <returns>pixd 32 bpp, average over rectangular window of width = 2  wc + 1 and height = 2  hc + 1</returns>
public static Pix pixWindowedMeanSquare(
				 Pix pixs, 
				 int wc, 
				 int hc, 
				 int hasborder){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp grayscale"); }
	IntPtr _Result = Natives.pixWindowedMeanSquare(pixs.Pointer,   wc,   hc,   hasborder);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (1280, 1)
// pixWindowedVariance(pixm, pixms, pfpixv, pfpixrv) as int
// pixWindowedVariance(PIX *, PIX *, FPIX **, FPIX **) as l_ok
///  <summary>
/// (1) The mean and mean square values are precomputed, using
/// pixWindowedMean() and pixWindowedMeanSquare().<para/>
/// 
/// (2) Either or both of the variance and square-root of variance
/// are returned as an fpix, where the variance is the
/// average over the window of the mean square difference of
/// the pixel value from the mean:
///  is smaller(p -  is smallerp is greater )(p -  is smallerp is greater ) is greater  =  is smallerpp is greater  -  is smallerp is greater  is smallerp is greater <para/>
/// 
/// (3) To visualize the results:
/// ~ for both, use fpixDisplayMaxDynamicRange().
/// ~ for rms deviation, simply convert the output fpix to pix,
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWindowedVariance/*"/>
///  <param name="pixm">[in] - mean over window 8 or 32 bpp grayscale</param>
///  <param name="pixms">[in] - mean square over window 32 bpp</param>
///  <param name="pfpixv">[out][optional] - float variance -- the ms deviation from the mean</param>
///  <param name="pfpixrv">[out][optional] - float rms deviation from the mean</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixWindowedVariance(
				 Pix pixm, 
				 Pix pixms, 
				out FPix pfpixv, 
				out FPix pfpixrv){

if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
		if (pixms == null) {throw new ArgumentNullException  ("pixms cannot be Nothing");}
	IntPtr pfpixvPtr = IntPtr.Zero;
	IntPtr pfpixrvPtr = IntPtr.Zero;

	int _Result = Natives.pixWindowedVariance(pixm.Pointer, pixms.Pointer, out pfpixvPtr, out pfpixrvPtr);
	
	if (pfpixvPtr == IntPtr.Zero) {pfpixv = null;} else { pfpixv = new FPix(pfpixvPtr); };
	if (pfpixrvPtr == IntPtr.Zero) {pfpixrv = null;} else { pfpixrv = new FPix(pfpixrvPtr); };
	return _Result;
}

// convolve.c (1369, 1)
// pixMeanSquareAccum(pixs) as DPix
// pixMeanSquareAccum(PIX *) as DPIX *
///  <summary>
/// (1) Similar to pixBlockconvAccum(), this computes the
/// sum of the squares of the pixel values in such a way
/// that the value at (i,j) is the sum of all squares in
/// the rectangle from the origin to (i,j).<para/>
/// 
/// (2) The general recursion relation (v are squared pixel values) is
/// a(i,j) = v(i,j) + a(i-1, j) + a(i, j-1) - a(i-1, j-1)
/// For the first line, this reduces to the special case
/// a(i,j) = v(i,j) + a(i, j-1)
/// For the first column, the special case is
/// a(i,j) = v(i,j) + a(i-1, j)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMeanSquareAccum/*"/>
///  <param name="pixs">[in] - 8 bpp grayscale</param>
///   <returns>dpix 64 bit array, or NULL on error</returns>
public static DPix pixMeanSquareAccum(
				 Pix pixs){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp grayscale"); }
	IntPtr _Result = Natives.pixMeanSquareAccum(pixs.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new DPix(_Result);
}

// convolve.c (1450, 1)
// pixBlockrank(pixs, pixacc, wc, hc, rank) as Pix
// pixBlockrank(PIX *, PIX *, l_int32, l_int32, l_float32) as PIX *
///  <summary>
/// (1) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1)<para/>
/// 
/// (2) This returns a pixd where each pixel is a 1 if the
/// neighborhood (2  wc + 1) x (2  hc + 1)) pixels
/// contains the rank fraction of 1 pixels.  Otherwise,
/// the returned pixel is 0.  Note that the special case
/// of rank = 0.0 is always satisfied, so the returned
/// pixd has all pixels with value 1.<para/>
/// 
/// (3) If accum pix is null, make one, use it, and destroy it
/// before returning otherwise, just use the input accum pix<para/>
/// 
/// (4) If both wc and hc are 0, returns a copy unless rank == 0.0,
/// in which case this returns an all-ones image.<para/>
/// 
/// (5) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlockrank/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="pixacc">[in] - pix [optional] 32 bpp</param>
///  <param name="wc">[in] - half width/height of block sum/rank kernel</param>
///  <param name="hc">[in] - half width/height of block sum/rank kernel</param>
///  <param name="rank">[in] - between 0.0 and 1.0 0.5 is median filter</param>
///   <returns>pixd 1 bpp</returns>
public static Pix pixBlockrank(
				 Pix pixs, 
				 Pix pixacc, 
				 int wc, 
				 int hc, 
				 Single rank){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr pixaccPtr = IntPtr.Zero; 	if (pixacc != null) {pixaccPtr = pixacc.Pointer;}

	IntPtr _Result = Natives.pixBlockrank(pixs.Pointer, pixaccPtr,   wc,   hc,   rank);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (1532, 1)
// pixBlocksum(pixs, pixacc, wc, hc) as Pix
// pixBlocksum(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) If accum pix is null, make one and destroy it before
/// returning otherwise, just use the input accum pix<para/>
/// 
/// (2) The full width and height of the convolution kernel
/// are (2  wc + 1) and (2  hc + 1)<para/>
/// 
/// (3) Use of wc = hc = 1, followed by pixInvert() on the
/// 8 bpp result, gives a nice anti-aliased, and somewhat
/// darkened, result on text.<para/>
/// 
/// (4) Require that w greater or equal 2  wc + 1 and h greater or equal 2  hc + 1,
/// where (w,h) are the dimensions of pixs.<para/>
/// 
/// (5) Returns in each dest pixel the sum of all src pixels
/// that are within a block of size of the kernel, centered
/// on the dest pixel.  This sum is the number of src ON
/// pixels in the block at each location, normalized to 255
/// for a block containing all ON pixels.  For pixels near
/// the boundary, where the block is not entirely contained
/// within the image, we then multiply by a second normalization
/// factor that is greater than one, so that all results
/// are normalized by the number of participating pixels
/// within the block.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlocksum/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="pixacc">[in] - pix [optional] 32 bpp</param>
///  <param name="wc">[in] - half width/height of block sum/rank kernel</param>
///  <param name="hc">[in] - half width/height of block sum/rank kernel</param>
///   <returns>pixd 8 bpp</returns>
public static Pix pixBlocksum(
				 Pix pixs, 
				 Pix pixacc, 
				 int wc, 
				 int hc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr pixaccPtr = IntPtr.Zero; 	if (pixacc != null) {pixaccPtr = pixacc.Pointer;}

	IntPtr _Result = Natives.pixBlocksum(pixs.Pointer, pixaccPtr,   wc,   hc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (1772, 1)
// pixCensusTransform(pixs, halfsize, pixacc) as Pix
// pixCensusTransform(PIX *, l_int32, PIX *) as PIX *
///  <summary>
/// (1) The Census transform was invented by Ramin Zabih and John Woodfill
/// ("Non-parametric local transforms for computing visual
/// correspondence", Third European Conference on Computer Vision,
/// Stockholm, Sweden, May 1994) see publications at
/// http://www.cs.cornell.edu/~rdz/index.htm
/// This compares each pixel against the average of its neighbors,
/// in a square of odd dimension centered on the pixel.
/// If the pixel is greater than the average of its neighbors,
/// the output pixel value is 1 otherwise it is 0.<para/>
/// 
/// (2) This can be used as an encoding for an image that is
/// fairly robust against slow illumination changes, with
/// applications in image comparison and mosaicing.<para/>
/// 
/// (3) The size of the convolution kernel is (2  halfsize + 1)
/// on a side.  The halfsize parameter must be greater or equal 1.<para/>
/// 
/// (4) If accum pix is null, make one, use it, and destroy it
/// before returning otherwise, just use the input accum pix
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCensusTransform/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="halfsize">[in] - of square over which neighbors are averaged</param>
///  <param name="pixacc">[in] - pix [optional] 32 bpp</param>
///   <returns>pixd 1 bpp</returns>
public static Pix pixCensusTransform(
				 Pix pixs, 
				 int halfsize, 
				 Pix pixacc){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr pixaccPtr = IntPtr.Zero; 	if (pixacc != null) {pixaccPtr = pixacc.Pointer;}

	IntPtr _Result = Natives.pixCensusTransform(pixs.Pointer,   halfsize, pixaccPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (1872, 1)
// pixConvolve(pixs, kel, outdepth, normflag) as Pix
// pixConvolve(PIX *, L_KERNEL *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This gives a convolution with an arbitrary kernel.<para/>
/// 
/// (2) The input pixs must have only one sample/pixel.
/// To do a convolution on an RGB image, use pixConvolveRGB().<para/>
/// 
/// (3) The parameter %outdepth determines the depth of the result.
/// If the kernel is normalized to unit sum, the output values
/// can never exceed 255, so an output depth of 8 bpp is sufficient.
/// If the kernel is not normalized, it may be necessary to use
/// 16 or 32 bpp output to avoid overflow.<para/>
/// 
/// (4) If normflag == 1, the result is normalized by scaling all
/// kernel values for a unit sum.  If the sum of kernel values
/// is very close to zero, the kernel can not be normalized and
/// the convolution will not be performed.  A warning is issued.<para/>
/// 
/// (5) The kernel values can be positive or negative, but the
/// result for the convolution can only be stored as a positive
/// number.  Consequently, if it goes negative, the choices are
/// to clip to 0 or take the absolute value.  We're choosing
/// to take the absolute value.  (Another possibility would be
/// to output a second unsigned image for the negative values.)
/// If you want to get a clipped result, or to keep the negative
/// values in the result, use fpixConvolve(), with the
/// converters in fpix2.c between pix and fpix.<para/>
/// 
/// (6) This uses a mirrored border to avoid special casing on
/// the boundaries.<para/>
/// 
/// (7) To get a subsampled output, call l_setConvolveSampling().
/// The time to make a subsampled output is reduced by the
/// product of the sampling factors.<para/>
/// 
/// (8) The function is slow, running at about 12 machine cycles for
/// each pixel-op in the convolution.  For example, with a 3 GHz
/// cpu, a 1 Mpixel grayscale image, and a kernel with
/// (sx  sy) = 25 elements, the convolution takes about 100 msec.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvolve/*"/>
///  <param name="pixs">[in] - 8, 16, 32 bpp no colormap</param>
///  <param name="kel">[in] - kernel</param>
///  <param name="outdepth">[in] - of pixd: 8, 16 or 32</param>
///  <param name="normflag">[in] - 1 to normalize kernel to unit sum 0 otherwise</param>
///   <returns>pixd 8, 16 or 32 bpp</returns>
public static Pix pixConvolve(
				 Pix pixs, 
				 L_Kernel kel, 
				 int outdepth, 
				 int normflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	IntPtr _Result = Natives.pixConvolve(pixs.Pointer, kel.Pointer,   outdepth,   normflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2002, 1)
// pixConvolveSep(pixs, kelx, kely, outdepth, normflag) as Pix
// pixConvolveSep(PIX *, L_KERNEL *, L_KERNEL *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This does a convolution with a separable kernel that is
/// is a sequence of convolutions in x and y.  The two
/// one-dimensional kernel components must be input separately
/// the full kernel is the product of these components.
/// The support for the full kernel is thus a rectangular region.<para/>
/// 
/// (2) The input pixs must have only one sample/pixel.
/// To do a convolution on an RGB image, use pixConvolveSepRGB().<para/>
/// 
/// (3) The parameter %outdepth determines the depth of the result.
/// If the kernel is normalized to unit sum, the output values
/// can never exceed 255, so an output depth of 8 bpp is sufficient.
/// If the kernel is not normalized, it may be necessary to use
/// 16 or 32 bpp output to avoid overflow.<para/>
/// 
/// (2) The %normflag parameter is used as in pixConvolve().<para/>
/// 
/// (4) The kernel values can be positive or negative, but the
/// result for the convolution can only be stored as a positive
/// number.  Consequently, if it goes negative, the choices are
/// to clip to 0 or take the absolute value.  We're choosing
/// the former for now.  Another possibility would be to output
/// a second unsigned image for the negative values.<para/>
/// 
/// (5) Warning: if you use l_setConvolveSampling() to get a
/// subsampled output, and the sampling factor is larger than
/// the kernel half-width, it is faster to use the non-separable
/// version pixConvolve().  This is because the first convolution
/// here must be done on every raster line, regardless of the
/// vertical sampling factor.  If the sampling factor is smaller
/// than kernel half-width, it's faster to use the separable
/// convolution.<para/>
/// 
/// (6) This uses mirrored borders to avoid special casing on
/// the boundaries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvolveSep/*"/>
///  <param name="pixs">[in] - 8, 16, 32 bpp no colormap</param>
///  <param name="kelx">[in] - x-dependent kernel</param>
///  <param name="kely">[in] - y-dependent kernel</param>
///  <param name="outdepth">[in] - of pixd: 8, 16 or 32</param>
///  <param name="normflag">[in] - 1 to normalize kernel to unit sum 0 otherwise</param>
///   <returns>pixd 8, 16 or 32 bpp</returns>
public static Pix pixConvolveSep(
				 Pix pixs, 
				 L_Kernel kelx, 
				 L_Kernel kely, 
				 int outdepth, 
				 int normflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (kelx == null) {throw new ArgumentNullException  ("kelx cannot be Nothing");}
		if (kely == null) {throw new ArgumentNullException  ("kely cannot be Nothing");}
	IntPtr _Result = Natives.pixConvolveSep(pixs.Pointer, kelx.Pointer, kely.Pointer,   outdepth,   normflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2074, 1)
// pixConvolveRGB(pixs, kel) as Pix
// pixConvolveRGB(PIX *, L_KERNEL *) as PIX *
///  <summary>
/// (1) This gives a convolution on an RGB image using an
/// arbitrary kernel (which we normalize to keep each
/// component within the range [0 ... 255].<para/>
/// 
/// (2) The input pixs must be RGB.<para/>
/// 
/// (3) The kernel values can be positive or negative, but the
/// result for the convolution can only be stored as a positive
/// number.  Consequently, if it goes negative, we clip the
/// result to 0.<para/>
/// 
/// (4) To get a subsampled output, call l_setConvolveSampling().
/// The time to make a subsampled output is reduced by the
/// product of the sampling factors.<para/>
/// 
/// (5) This uses a mirrored border to avoid special casing on
/// the boundaries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvolveRGB/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="kel">[in] - kernel</param>
///   <returns>pixd 32 bpp rgb</returns>
public static Pix pixConvolveRGB(
				 Pix pixs, 
				 L_Kernel kel){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
if ((new List<int> {32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
	IntPtr _Result = Natives.pixConvolveRGB(pixs.Pointer, kel.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2133, 1)
// pixConvolveRGBSep(pixs, kelx, kely) as Pix
// pixConvolveRGBSep(PIX *, L_KERNEL *, L_KERNEL *) as PIX *
///  <summary>
/// (1) This does a convolution on an RGB image using a separable
/// kernel that is a sequence of convolutions in x and y.  The two
/// one-dimensional kernel components must be input separately
/// the full kernel is the product of these components.
/// The support for the full kernel is thus a rectangular region.<para/>
/// 
/// (2) The kernel values can be positive or negative, but the
/// result for the convolution can only be stored as a positive
/// number.  Consequently, if it goes negative, we clip the
/// result to 0.<para/>
/// 
/// (3) To get a subsampled output, call l_setConvolveSampling().
/// The time to make a subsampled output is reduced by the
/// product of the sampling factors.<para/>
/// 
/// (4) This uses a mirrored border to avoid special casing on
/// the boundaries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvolveRGBSep/*"/>
///  <param name="pixs">[in] - 32 bpp rgb</param>
///  <param name="kelx">[in] - x-dependent kernel</param>
///  <param name="kely">[in] - y-dependent kernel</param>
///   <returns>pixd 32 bpp rgb</returns>
public static Pix pixConvolveRGBSep(
				 Pix pixs, 
				 L_Kernel kelx, 
				 L_Kernel kely){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (kelx == null) {throw new ArgumentNullException  ("kelx cannot be Nothing");}
		if (kely == null) {throw new ArgumentNullException  ("kely cannot be Nothing");}
if ((new List<int> {32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
	IntPtr _Result = Natives.pixConvolveRGBSep(pixs.Pointer, kelx.Pointer, kely.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2195, 1)
// fpixConvolve(fpixs, kel, normflag) as FPix
// fpixConvolve(FPIX *, L_KERNEL *, l_int32) as FPIX *
///  <summary>
/// (1) This gives a float convolution with an arbitrary kernel.<para/>
/// 
/// (2) If normflag == 1, the result is normalized by scaling all
/// kernel values for a unit sum.  If the sum of kernel values
/// is very close to zero, the kernel can not be normalized and
/// the convolution will not be performed.  A warning is issued.<para/>
/// 
/// (3) With the FPix, there are no issues about negative
/// array or kernel values.  The convolution is performed
/// with single precision arithmetic.<para/>
/// 
/// (4) To get a subsampled output, call l_setConvolveSampling().
/// The time to make a subsampled output is reduced by the
/// product of the sampling factors.<para/>
/// 
/// (5) This uses a mirrored border to avoid special casing on
/// the boundaries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixConvolve/*"/>
///  <param name="fpixs">[in] - 32 bit float array</param>
///  <param name="kel">[in] - kernel</param>
///  <param name="normflag">[in] - 1 to normalize kernel to unit sum 0 otherwise</param>
///   <returns>fpixd 32 bit float array</returns>
public static FPix fpixConvolve(
				 FPix fpixs, 
				 L_Kernel kel, 
				 int normflag){

if (fpixs == null) {throw new ArgumentNullException  ("fpixs cannot be Nothing");}
		if (kel == null) {throw new ArgumentNullException  ("kel cannot be Nothing");}
	IntPtr _Result = Natives.fpixConvolve(fpixs.Pointer, kel.Pointer,   normflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new FPix(_Result);
}

// convolve.c (2289, 1)
// fpixConvolveSep(fpixs, kelx, kely, normflag) as FPix
// fpixConvolveSep(FPIX *, L_KERNEL *, L_KERNEL *, l_int32) as FPIX *
///  <summary>
/// (1) This does a convolution with a separable kernel that is
/// is a sequence of convolutions in x and y.  The two
/// one-dimensional kernel components must be input separately
/// the full kernel is the product of these components.
/// The support for the full kernel is thus a rectangular region.<para/>
/// 
/// (2) The normflag parameter is used as in fpixConvolve().<para/>
/// 
/// (3) Warning: if you use l_setConvolveSampling() to get a
/// subsampled output, and the sampling factor is larger than
/// the kernel half-width, it is faster to use the non-separable
/// version pixConvolve().  This is because the first convolution
/// here must be done on every raster line, regardless of the
/// vertical sampling factor.  If the sampling factor is smaller
/// than kernel half-width, it's faster to use the separable
/// convolution.<para/>
/// 
/// (4) This uses mirrored borders to avoid special casing on
/// the boundaries.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixConvolveSep/*"/>
///  <param name="fpixs">[in] - 32 bit float array</param>
///  <param name="kelx">[in] - x-dependent kernel</param>
///  <param name="kely">[in] - y-dependent kernel</param>
///  <param name="normflag">[in] - 1 to normalize kernel to unit sum 0 otherwise</param>
///   <returns>fpixd 32 bit float array</returns>
public static FPix fpixConvolveSep(
				 FPix fpixs, 
				 L_Kernel kelx, 
				 L_Kernel kely, 
				 int normflag){

if (fpixs == null) {throw new ArgumentNullException  ("fpixs cannot be Nothing");}
		if (kelx == null) {throw new ArgumentNullException  ("kelx cannot be Nothing");}
		if (kely == null) {throw new ArgumentNullException  ("kely cannot be Nothing");}
	IntPtr _Result = Natives.fpixConvolveSep(fpixs.Pointer, kelx.Pointer, kely.Pointer,   normflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new FPix(_Result);
}

// convolve.c (2367, 1)
// pixConvolveWithBias(pixs, kel1, kel2, force8, pbias) as Pix
// pixConvolveWithBias(PIX *, L_KERNEL *, L_KERNEL *, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) This does a convolution with either a single kernel or
/// a pair of separable kernels, and automatically applies whatever
/// bias (shift) is required so that the resulting pixel values
/// are non-negative.<para/>
/// 
/// (2) The kernel is always normalized.  If there are no negative
/// values in the kernel, a standard normalized convolution is
/// performed, with 8 bpp output.  If the sum of kernel values is
/// very close to zero, the kernel can not be normalized and
/// the convolution will not be performed.  An error message results.<para/>
/// 
/// (3) If there are negative values in the kernel, the pix is
/// converted to an fpix, the convolution is done on the fpix, and
/// a bias (shift) may need to be applied.<para/>
/// 
/// (4) If force8 == TRUE and the range of values after the convolution
/// is  is greater  255, the output values will be scaled to fit in [0 ... 255].
/// If force8 == FALSE, the output will be either 8 or 16 bpp,
/// to accommodate the dynamic range of output values without scaling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvolveWithBias/*"/>
///  <param name="pixs">[in] - 8 bpp no colormap</param>
///  <param name="kel1">[in] - </param>
///  <param name="kel2">[in]can be null - use if separable</param>
///  <param name="force8">[in] - if 1, force output to 8 bpp otherwise, determine output depth by the dynamic range of pixel values</param>
///  <param name="pbias">[out] - applied bias</param>
///   <returns>pixd 8 or 16 bpp</returns>
public static Pix pixConvolveWithBias(
				 Pix pixs, 
				 L_Kernel kel1, 
				 L_Kernel kel2, 
				 int force8, 
				out int pbias){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (kel1 == null) {throw new ArgumentNullException  ("kel1 cannot be Nothing");}
	IntPtr kel2Ptr = IntPtr.Zero; 	if (kel2 != null) {kel2Ptr = kel2.Pointer;}

	IntPtr _Result = Natives.pixConvolveWithBias(pixs.Pointer, kel1.Pointer, kel2Ptr,   force8, out  pbias);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2457, 1)
// l_setConvolveSampling(xfact, yfact) as Object
// l_setConvolveSampling(l_int32, l_int32) as void
///  <summary>
/// (1) This sets the x and y output subsampling factors for generic pix
/// and fpix convolution.  The default values are 1 (no subsampling).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setConvolveSampling/*"/>
///  <param name="xfact">[in] - integer greater or equal 1</param>
///  <param name="yfact">[in] - integer greater or equal 1</param>
public static void l_setConvolveSampling(
				 int xfact, 
				 int yfact){

	Natives.l_setConvolveSampling(  xfact,   yfact);
	
}

// convolve.c (2484, 1)
// pixAddGaussianNoise(pixs, stdev) as Pix
// pixAddGaussianNoise(PIX *, l_float32) as PIX *
///  <summary>
/// (1) This adds noise to each pixel, taken from a normal
/// distribution with zero mean and specified standard deviation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddGaussianNoise/*"/>
///  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb no colormap</param>
///  <param name="stdev">[in] - of noise</param>
///   <returns>pixd 8 or 32 bpp, or NULL on error</returns>
public static Pix pixAddGaussianNoise(
				 Pix pixs, 
				 Single stdev){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixAddGaussianNoise(pixs.Pointer,   stdev);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// convolve.c (2547, 1)
// gaussDistribSampling() as Single
// gaussDistribSampling() as l_float32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gaussDistribSampling/*"/>
///   <returns></returns>
public static Single gaussDistribSampling(){

	Single _Result = Natives.gaussDistribSampling();
	
	return _Result;
}


}
}
