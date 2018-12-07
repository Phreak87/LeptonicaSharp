using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// readbarcode.c (134, 1)
// pixProcessBarcodes(pixs, format, method, psaw, debugflag) as Sarray
// pixProcessBarcodes(PIX *, l_int32, l_int32, SARRAY **, l_int32) as SARRAY *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixProcessBarcodes/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
///  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
///  <param name="psaw">[out][optional] - sarray of bar widths</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>sarray text of barcodes, or NULL if none found or on error</returns>
public static Sarray pixProcessBarcodes(
				 Pix pixs, 
				 IFF format, 
				 int method, 
				out Sarray psaw, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr psawPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixProcessBarcodes(pixs.Pointer,  (int) format,   method, out psawPtr,   debugflag);
	
	if (psawPtr == IntPtr.Zero) {psaw = null;} else { psaw = new Sarray(psawPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// readbarcode.c (182, 1)
// pixExtractBarcodes(pixs, debugflag) as Pixa
// pixExtractBarcodes(PIX *, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodes/*"/>
///  <param name="pixs">[in] - 8 bpp, no colormap</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>pixa deskewed and cropped barcodes, or NULL if none found or on error</returns>
public static Pixa pixExtractBarcodes(
				 Pix pixs, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixExtractBarcodes(pixs.Pointer,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// readbarcode.c (254, 1)
// pixReadBarcodes(pixa, format, method, psaw, debugflag) as Sarray
// pixReadBarcodes(PIXA *, l_int32, l_int32, SARRAY **, l_int32) as SARRAY *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadBarcodes/*"/>
///  <param name="pixa">[in] - of 8 bpp deskewed and cropped barcodes</param>
///  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
///  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
///  <param name="psaw">[out][optional] - sarray of bar widths</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>sa sarray of widths, one string for each barcode found, or NULL on error</returns>
public static Sarray pixReadBarcodes(
				 Pixa pixa, 
				 IFF format, 
				 int method, 
				out Sarray psaw, 
				 int debugflag){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
	IntPtr psawPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixReadBarcodes(pixa.Pointer,  (int) format,   method, out psawPtr,   debugflag);
	
	if (psawPtr == IntPtr.Zero) {psaw = null;} else { psaw = new Sarray(psawPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// readbarcode.c (335, 1)
// pixReadBarcodeWidths(pixs, method, debugflag) as Numa
// pixReadBarcodeWidths(PIX *, l_int32, l_int32) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadBarcodeWidths/*"/>
///  <param name="pixs">[in] - of 8 bpp deskewed and cropped barcode</param>
///  <param name="method">[in] - L_USE_WIDTHS, L_USE_WINDOWS</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>na numa of widths (each in set {1,2,3,4}, or NULL on error</returns>
public static Numa pixReadBarcodeWidths(
				 Pix pixs, 
				 int method, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixReadBarcodeWidths(pixs.Pointer,   method,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// readbarcode.c (384, 1)
// pixLocateBarcodes(pixs, thresh, ppixb, ppixm) as Boxa
// pixLocateBarcodes(PIX *, l_int32, PIX **, PIX **) as BOXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLocateBarcodes/*"/>
///  <param name="pixs">[in] - any depth</param>
///  <param name="thresh">[in] - for binarization of edge filter output typ. 20</param>
///  <param name="ppixb">[out][optional] - binarized edge filtered input image</param>
///  <param name="ppixm">[out][optional] - mask over barcodes</param>
///   <returns>boxa location of barcodes, or NULL if none found or on error</returns>
public static Boxa pixLocateBarcodes(
				 Pix pixs, 
				 int thresh, 
				out Pix ppixb, 
				out Pix ppixm){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr ppixbPtr = IntPtr.Zero;
	IntPtr ppixmPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixLocateBarcodes(pixs.Pointer,   thresh, out ppixbPtr, out ppixmPtr);
	
	if (ppixbPtr == IntPtr.Zero) {ppixb = null;} else { ppixb = new Pix(ppixbPtr); };
	if (ppixmPtr == IntPtr.Zero) {ppixm = null;} else { ppixm = new Pix(ppixmPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Boxa(_Result);
}

// readbarcode.c (500, 1)
// pixDeskewBarcode(pixs, pixb, box, margin, threshold, pangle, pconf) as Pix
// pixDeskewBarcode(PIX *, PIX *, BOX *, l_int32, l_int32, l_float32 *, l_float32 *) as PIX *
///  <summary>
/// (1) The (optional) angle returned is the angle in degrees (cw positive)
/// necessary to rotate the image so that it is deskewed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDeskewBarcode/*"/>
///  <param name="pixs">[in] - input image 8 bpp</param>
///  <param name="pixb">[in] - binarized edge-filtered input image</param>
///  <param name="box">[in] - identified region containing barcode</param>
///  <param name="margin">[in] - of extra pixels around box to extract</param>
///  <param name="threshold">[in] - for binarization ~20</param>
///  <param name="pangle">[out][optional] - in degrees, clockwise is positive</param>
///  <param name="pconf">[out][optional] - confidence</param>
///   <returns>pixd deskewed barcode, or NULL on error</returns>
public static Pix pixDeskewBarcode(
				 Pix pixs, 
				 Pix pixb, 
				 Box box, 
				 int margin, 
				 int threshold, 
				out Single pangle, 
				out Single pconf){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixb == null) {throw new ArgumentNullException  ("pixb cannot be Nothing");}
		if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}
	IntPtr _Result = Natives.pixDeskewBarcode(pixs.Pointer, pixb.Pointer, box.Pointer,   margin,   threshold, out  pangle, out  pconf);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// readbarcode.c (626, 1)
// pixExtractBarcodeWidths1(pixs, thresh, binfract, pnaehist, pnaohist, debugflag) as Numa
// pixExtractBarcodeWidths1(PIX *, l_float32, l_float32, NUMA **, NUMA **, l_int32) as NUMA *
///  <summary>
/// (1) The widths are alternating black/white, starting with black
/// and ending with black.<para/>
/// 
/// (2) This method uses the widths of the bars directly, in terms
/// of the (float) number of pixels between transitions.
/// The histograms of these widths for black and white bars is
/// generated and interpreted.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeWidths1/*"/>
///  <param name="pixs">[in] - input image 8 bpp</param>
///  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
///  <param name="binfract">[in] - histo binsize as a fraction of minsize e.g., 0.25</param>
///  <param name="pnaehist">[out][optional] - histogram of black widths NULL ok</param>
///  <param name="pnaohist">[out][optional] - histogram of white widths NULL ok</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>nad numa of barcode widths in encoded integer units, or NULL on error</returns>
public static Numa pixExtractBarcodeWidths1(
				 Pix pixs, 
				 Single thresh, 
				 Single binfract, 
				out Numa pnaehist, 
				out Numa pnaohist, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pnaehistPtr = IntPtr.Zero;
	IntPtr pnaohistPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixExtractBarcodeWidths1(pixs.Pointer,   thresh,   binfract, out pnaehistPtr, out pnaohistPtr,   debugflag);
	
	if (pnaehistPtr == IntPtr.Zero) {pnaehist = null;} else { pnaehist = new Numa(pnaehistPtr); };
	if (pnaohistPtr == IntPtr.Zero) {pnaohist = null;} else { pnaohist = new Numa(pnaohistPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// readbarcode.c (679, 1)
// pixExtractBarcodeWidths2(pixs, thresh, pwidth, pnac, debugflag) as Numa
// pixExtractBarcodeWidths2(PIX *, l_float32, l_float32 *, NUMA **, l_int32) as NUMA *
///  <summary>
/// (1) The widths are alternating black/white, starting with black
/// and ending with black.<para/>
/// 
/// (2) The optional best decoding window width is the width of the window
/// that is used to make a decision about whether a transition occurs.
/// It is approximately the average width in pixels of the narrowest
/// white and black bars (i.e., those corresponding to unit width).<para/>
/// 
/// (3) The optional return signal %nac is a sequence of 0s, 1s,
/// and perhaps a few 2s, giving the number of crossings in each window.
/// On the occasion where there is a '2', it is interpreted as
/// as ending two runs: the previous one and another one that has length 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeWidths2/*"/>
///  <param name="pixs">[in] - input image 8 bpp</param>
///  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
///  <param name="pwidth">[out][optional] - best decoding window width, in pixels</param>
///  <param name="pnac">[out][optional] - number of transitions in each window</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>nad numa of barcode widths in encoded integer units, or NULL on error</returns>
public static Numa pixExtractBarcodeWidths2(
				 Pix pixs, 
				 Single thresh, 
				out Single pwidth, 
				out Numa pnac, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pnacPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixExtractBarcodeWidths2(pixs.Pointer,   thresh, out  pwidth, out pnacPtr,   debugflag);
	
	if (pnacPtr == IntPtr.Zero) {pnac = null;} else { pnac = new Numa(pnacPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// readbarcode.c (713, 1)
// pixExtractBarcodeCrossings(pixs, thresh, debugflag) as Numa
// pixExtractBarcodeCrossings(PIX *, l_float32, l_int32) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBarcodeCrossings/*"/>
///  <param name="pixs">[in] - input image 8 bpp</param>
///  <param name="thresh">[in] - estimated pixel threshold for crossing white  is smallerto black typ. ~120</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>numa of crossings, in pixel units, or NULL on error</returns>
public static Numa pixExtractBarcodeCrossings(
				 Pix pixs, 
				 Single thresh, 
				 int debugflag){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixExtractBarcodeCrossings(pixs.Pointer,   thresh,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// readbarcode.c (837, 1)
// numaQuantizeCrossingsByWidth(nas, binfract, pnaehist, pnaohist, debugflag) as Numa
// numaQuantizeCrossingsByWidth(NUMA *, l_float32, NUMA **, NUMA **, l_int32) as NUMA *
///  <summary>
/// (1) This first computes the histogram of black and white bar widths,
/// binned in appropriate units.  There should be well-defined
/// peaks, each corresponding to a specific width.  The sequence
/// of barcode widths (namely, the integers from the set {1,2,3,4})
/// is returned.<para/>
/// 
/// (2) The optional returned histograms are binned in width units
/// that are inversely proportional to %binfract.  For example,
/// if %binfract = 0.25, there are 4.0 bins in the distance of
/// the width of the narrowest bar.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaQuantizeCrossingsByWidth/*"/>
///  <param name="nas">[in] - numa of crossing locations, in pixel units</param>
///  <param name="binfract">[in] - histo binsize as a fraction of minsize e.g., 0.25</param>
///  <param name="pnaehist">[out][optional] - histo of even (black) bar widths</param>
///  <param name="pnaohist">[out][optional] - histo of odd (white) bar widths</param>
///  <param name="debugflag">[in] - 1 to generate plots of histograms of bar widths</param>
///   <returns>nad sequence of widths, in unit sizes, or NULL on error</returns>
public static Numa numaQuantizeCrossingsByWidth(
				 Numa nas, 
				 Single binfract, 
				out Numa pnaehist, 
				out Numa pnaohist, 
				 int debugflag){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr pnaehistPtr = IntPtr.Zero;
	IntPtr pnaohistPtr = IntPtr.Zero;

	IntPtr _Result = Natives.numaQuantizeCrossingsByWidth(nas.Pointer,   binfract, out pnaehistPtr, out pnaohistPtr,   debugflag);
	
	if (pnaehistPtr == IntPtr.Zero) {pnaehist = null;} else { pnaehist = new Numa(pnaehistPtr); };
	if (pnaohistPtr == IntPtr.Zero) {pnaohist = null;} else { pnaohist = new Numa(pnaohistPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// readbarcode.c (1267, 1)
// numaQuantizeCrossingsByWindow(nas, ratio, pwidth, pfirstloc, pnac, debugflag) as Numa
// numaQuantizeCrossingsByWindow(NUMA *, l_float32, l_float32 *, l_float32 *, NUMA **, l_int32) as NUMA *
///  <summary>
/// (1) The minimum size of the window is set by the minimum
/// distance between zero crossings.<para/>
/// 
/// (2) The optional return signal %nac is a sequence of 0s, 1s,
/// and perhaps a few 2s, giving the number of crossings in each window.
/// On the occasion where there is a '2', it is interpreted as
/// ending two runs: the previous one and another one that has length 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaQuantizeCrossingsByWindow/*"/>
///  <param name="nas">[in] - numa of crossing locations</param>
///  <param name="ratio">[in] - of max window size over min window size in search typ. 2.0</param>
///  <param name="pwidth">[out][optional] - best window width</param>
///  <param name="pfirstloc">[out][optional] - center of window for first xing</param>
///  <param name="pnac">[out][optional] - array of window crossings (0, 1, 2)</param>
///  <param name="debugflag">[in] - 1 to generate various plots of intermediate results</param>
///   <returns>nad sequence of widths, in unit sizes, or NULL on error</returns>
public static Numa numaQuantizeCrossingsByWindow(
				 Numa nas, 
				 Single ratio, 
				out Single pwidth, 
				out Single pfirstloc, 
				out Numa pnac, 
				 int debugflag){

if (nas == null) {throw new ArgumentNullException  ("nas cannot be Nothing");}
	IntPtr pnacPtr = IntPtr.Zero;

	IntPtr _Result = Natives.numaQuantizeCrossingsByWindow(nas.Pointer,   ratio, out  pwidth, out  pfirstloc, out pnacPtr,   debugflag);
	
	if (pnacPtr == IntPtr.Zero) {pnac = null;} else { pnac = new Numa(pnacPtr); };
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}


}
}
