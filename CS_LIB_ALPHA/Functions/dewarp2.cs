using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// dewarp2.c (148, 1)
// dewarpBuildPageModel(dew, debugfile) as int
// dewarpBuildPageModel(L_DEWARP *, const char *) as l_ok
///  <summary>
/// (1) This is the basic function that builds the horizontal and
/// vertical disparity arrays, which allow determination of the
/// src pixel in the input image corresponding to each
/// dest pixel in the dewarped image.<para/>
/// 
/// (2) Sets vsuccess = 1 if the vertical disparity array builds.
/// Always attempts to build the horizontal disparity array,
/// even if it will not be requested (useboth == 0).
/// Sets hsuccess = 1 if horizontal disparity builds.<para/>
/// 
/// (3) The method is as follows:
/// (a) Estimate the points along the centers of all the
/// long textlines.  If there are too few lines, no
/// disparity models are built.
/// (b) From the vertical deviation of the lines, estimate
/// the vertical disparity.
/// (c) From the ends of the lines, estimate the horizontal
/// disparity, assuming that the text is made of lines
/// that are close to left and right justified.
/// (d) One can also compute an additional contribution to the
/// horizontal disparity, inferred from slopes of the top
/// and bottom lines.  We do not do this.<para/>
/// 
/// (4) In more detail for the vertical disparity:
/// (a) Fit a LS quadratic to center locations along each line.
/// This smooths the curves.
/// (b) Sample each curve at a regular interval, find the y-value
/// of the mid-point on each curve, and subtract the sampled
/// curve value from this value.  This is the vertical
/// disparity at sampled points along each curve.
/// (c) Fit a LS quadratic to each set of vertically aligned
/// disparity samples.  This smooths the disparity values
/// in the vertical direction.  Then resample at the same
/// regular interval.  We now have a regular grid of smoothed
/// vertical disparity valuels.<para/>
/// 
/// (5) Once the sampled vertical disparity array is found, it can be
/// interpolated to get a full resolution vertical disparity map.
/// This can be applied directly to the src image pixels
/// to dewarp the image in the vertical direction, making
/// all textlines horizontal.  Likewise, the horizontal
/// disparity array is used to left- and right-align the
/// longest textlines.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpBuildPageModel/*"/>
///  <param name="dew">[in] - </param>
///  <param name="debugfile">[in]use NULL to skip - writing this</param>
///   <returns>0 if OK, 1 if unable to build the model or on error</returns>
public static int dewarpBuildPageModel(
				  L_Dewarp dew, 
				 String debugfile){

	int _Result = Natives.dewarpBuildPageModel(dew.Pointer,   debugfile);
	



	return _Result;
}

// dewarp2.c (294, 1)
// dewarpFindVertDisparity(dew, ptaa, rotflag) as int
// dewarpFindVertDisparity(L_DEWARP *, PTAA *, l_int32) as l_ok
///  <summary>
/// (1) This starts with points along the centers of textlines.
/// It does quadratic fitting (and smoothing), first along the
/// lines and then in the vertical direction, to generate
/// the sampled vertical disparity map.  This can then be
/// interpolated to full resolution and used to remove
/// the vertical line warping.<para/>
/// 
/// (2) Use %rotflag == 1 if you are dewarping vertical lines, as
/// is done in dewarpBuildLineModel().  The usual case is for
/// %rotflag == 0.<para/>
/// 
/// (3) Note that this builds a vertical disparity model (VDM), but
/// does not check it against constraints for validity.
/// Constraint checking is done after building the models,
/// and before inserting reference models.<para/>
/// 
/// (4) This sets the vsuccess flag to 1 on success.<para/>
/// 
/// (5) Pix debug output goes to /tmp/dewvert/ for collection into
/// a pdf.  Non-pix debug output goes to /tmp.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpFindVertDisparity/*"/>
///  <param name="dew">[in] - </param>
///  <param name="ptaa">[in] - unsmoothed lines, not vertically ordered</param>
///  <param name="rotflag">[in] - 0 if using dewtopixs 1 if rotated by 90 degrees cw</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpFindVertDisparity(
				  L_Dewarp dew, 
				  Ptaa ptaa, 
				  int rotflag){

	int _Result = Natives.dewarpFindVertDisparity(dew.Pointer, ptaa.Pointer,   rotflag);
	



	return _Result;
}

// dewarp2.c (558, 1)
// dewarpFindHorizDisparity(dew, ptaa) as int
// dewarpFindHorizDisparity(L_DEWARP *, PTAA *) as l_ok
///  <summary>
/// (1) This builds a horizontal disparity model (HDM), but
/// does not check it against constraints for validity.
/// Constraint checking is done at rendering time.<para/>
/// 
/// (2) Horizontal disparity is not required for a successful model
/// only the vertical disparity is required.  This will not be
/// called if the function to build the vertical disparity fails.<para/>
/// 
/// (3) This sets the hsuccess flag to 1 on success.<para/>
/// 
/// (4) Internally in ptal1, ptar1, ptal2, ptar2: x and y are reversed,
/// so the 'y' value is horizontal distance across the image width.<para/>
/// 
/// (5) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpFindHorizDisparity/*"/>
///  <param name="dew">[in] - </param>
///  <param name="ptaa">[in] - unsmoothed lines, not vertically ordered</param>
///   <returns>0 if OK, 1 if horizontal disparity array is not built, or on error</returns>
public static int dewarpFindHorizDisparity(
				  L_Dewarp dew, 
				  Ptaa ptaa){

	int _Result = Natives.dewarpFindHorizDisparity(dew.Pointer, ptaa.Pointer);
	



	return _Result;
}

// dewarp2.c (762, 1)
// dewarpGetTextlineCenters(pixs, debugflag) as Ptaa
// dewarpGetTextlineCenters(PIX *, l_int32) as PTAA *
///  <summary>
/// (1) This in general does not have a point for each value
/// of x, because there will be gaps between words.
/// It doesn't matter because we will fit a quadratic to the
/// points that we do have.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpGetTextlineCenters/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="debugflag">[in] - 1 for debug output</param>
///   <returns>ptaa of center values of textlines</returns>
public static Ptaa dewarpGetTextlineCenters(
				  Pix pixs, 
				  int debugflag){

	IntPtr _Result = Natives.dewarpGetTextlineCenters(pixs.Pointer,   debugflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Ptaa(_Result);
}

// dewarp2.c (916, 1)
// dewarpRemoveShortLines(pixs, ptaas, fract, debugflag) as Ptaa
// dewarpRemoveShortLines(PIX *, PTAA *, l_float32, l_int32) as PTAA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpRemoveShortLines/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="ptaas">[in] - input lines</param>
///  <param name="fract">[in] - minimum fraction of longest line to keep</param>
///  <param name="debugflag">[in] - </param>
///   <returns>ptaad containing only lines of sufficient length, or NULL on error</returns>
public static Ptaa dewarpRemoveShortLines(
				  Pix pixs, 
				  Ptaa ptaas, 
				  Single fract, 
				  int debugflag){

	IntPtr _Result = Natives.dewarpRemoveShortLines(pixs.Pointer, ptaas.Pointer,   fract,   debugflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Ptaa(_Result);
}

// dewarp2.c (1378, 1)
// dewarpFindHorizSlopeDisparity(dew, pixb, fractthresh, parity) as int
// dewarpFindHorizSlopeDisparity(L_DEWARP *, PIX *, l_float32, l_int32) as l_ok
///  <summary>
/// (1) %fractthresh is a threshold on the fractional difference in stroke
/// density between between left and right sides.  Process this
/// disparity only if the absolute value of the fractional
/// difference equals or exceeds this threshold.<para/>
/// 
/// (2) %parity indicates where the binding is: on the left for
/// %parity == 0 and on the right for %parity == 1.<para/>
/// 
/// (3) This takes a 1 bpp %pixb where both vertical and horizontal
/// disparity have been applied, so the text lines are straight and,
/// more importantly, the line end points are vertically aligned.
/// It estimates the foreshortening of the characters on the
/// binding side, and if significant, computes a one-dimensional
/// horizontal disparity function to compensate.<para/>
/// 
/// (4) The first attempt was to use the average width of the
/// connected components (c.c.) in vertical slices.  This does not work
/// reliably, because the horizontal compression of the text is
/// often accompanied by horizontal joining of c.c.<para/>
/// 
/// (5) We use the density of vertical strokes, measured by first using
/// a vertical opening, which improves the signal.  The result
/// is relatively insensitive to the size of the opening we use
/// a 10-pixel opening.  The relative density is measured by
/// finding the number of c.c. in a full height sliding window
/// of width 50 pixels, and compute every 25 pixels.  Similar results
/// are obtained counting c.c. that either intersect the window
/// or are fully contained within it.<para/>
/// 
/// (6) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpFindHorizSlopeDisparity/*"/>
///  <param name="dew">[in] - </param>
///  <param name="pixb">[in] - (1 bpp, with vertical and horizontal disparity removed)</param>
///  <param name="fractthresh">[in] - (threshold fractional difference in density)</param>
///  <param name="parity">[in] - (0 if even page, 1 if odd page)</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpFindHorizSlopeDisparity(
				  L_Dewarp dew, 
				  Pix pixb, 
				  Single fractthresh, 
				  int parity){

	int _Result = Natives.dewarpFindHorizSlopeDisparity(dew.Pointer, pixb.Pointer,   fractthresh,   parity);
	



	return _Result;
}

// dewarp2.c (1606, 1)
// dewarpBuildLineModel(dew, opensize, debugfile) as int
// dewarpBuildLineModel(L_DEWARP *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This builds the horizontal and vertical disparity arrays
/// for an input of ruled lines, typically for calibration.
/// In book scanning, you could lay the ruled paper over a page.
/// Then for that page and several below it, you can use the
/// disparity correction of the line model to dewarp the pages.<para/>
/// 
/// (2) The dew has been initialized with the image of ruled lines.
/// These lines must be continuous, but we do a small amount
/// of pre-processing here to insure that.<para/>
/// 
/// (3) %opensize is typically about 8.  It must be larger than
/// the thickness of the lines to be extracted.  This is the
/// default value, which is applied if %opensize  is smaller 3.<para/>
/// 
/// (4) Sets vsuccess = 1 and hsuccess = 1 if the vertical and/or
/// horizontal disparity arrays build.<para/>
/// 
/// (5) Similar to dewarpBuildPageModel(), except here the vertical
/// and horizontal disparity arrays are both built from ruled lines.
/// See notes there.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpBuildLineModel/*"/>
///  <param name="dew">[in] - </param>
///  <param name="opensize">[in] - size of opening to remove perpendicular lines</param>
///  <param name="debugfile">[in]use NULL to skip - writing this</param>
///   <returns>0 if OK, 1 if unable to build the model or on error</returns>
public static int dewarpBuildLineModel(
				  L_Dewarp dew, 
				  int opensize, 
				 String debugfile){

	int _Result = Natives.dewarpBuildLineModel(dew.Pointer,   opensize,   debugfile);
	



	return _Result;
}

// dewarp2.c (1790, 1)
// dewarpaModelStatus(dewa, pageno, pvsuccess, phsuccess) as int
// dewarpaModelStatus(L_DEWARPA *, l_int32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This tests if a model has been built, not if it is valid.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaModelStatus/*"/>
///  <param name="dewa">[in] - </param>
///  <param name="pageno">[in] - </param>
///  <param name="pvsuccess">[out][optional] - 1 on success</param>
///  <param name="phsuccess">[out][optional] - 1 on success</param>
///   <returns>0 if OK, 1 on error</returns>
public static int dewarpaModelStatus(
				  L_Dewarpa dewa, 
				  int pageno, 
				out int pvsuccess, 
				out int phsuccess){

	int _Result = Natives.dewarpaModelStatus(dewa.Pointer,   pageno, out  pvsuccess, out  phsuccess);
	

pvsuccess = 0;
phsuccess = 0;


	return _Result;
}

}
