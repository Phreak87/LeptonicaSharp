Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\dewarp2.c (148, 1)
' dewarpBuildPageModel()
' dewarpBuildPageModel(L_DEWARP *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is the basic function that builds the horizontal and
''' vertical disparity arrays, which allow determination of the
''' src pixel in the input image corresponding to each
''' dest pixel in the dewarped image.
''' (2) Sets vsuccess = 1 if the vertical disparity array builds.
''' Always attempts to build the horizontal disparity array,
''' even if it will not be requested (useboth == 0).
''' Sets hsuccess = 1 if horizontal disparity builds.
''' (3) The method is as follows
''' (a) Estimate the points along the centers of all the
''' long textlines.  If there are too few lines, no
''' disparity models are built.
''' (b) From the vertical deviation of the lines, estimate
''' the vertical disparity.
''' (c) From the ends of the lines, estimate the horizontal
''' disparity, assuming that the text is made of lines
''' that are close to left and right justified.
''' (d) One can also compute an additional contribution to the
''' horizontal disparity, inferred from slopes of the top
''' and bottom lines.  We do not do this.
''' (4) In more detail for the vertical disparity
''' (a) Fit a LS quadratic to center locations along each line.
''' This smooths the curves.
''' (b) Sample each curve at a regular interval, find the y-value
''' of the mid-point on each curve, and subtract the sampled
''' curve value from this value.  This is the vertical
''' disparity at sampled points along each curve.
''' (c) Fit a LS quadratic to each set of vertically aligned
''' disparity samples.  This smooths the disparity values
''' in the vertical direction.  Then resample at the same
''' regular interval.  We now have a regular grid of smoothed
''' vertical disparity valuels.
''' (5) Once the sampled vertical disparity array is found, it can be
''' interpolated to get a full resolution vertical disparity map.
''' This can be applied directly to the src image pixels
''' to dewarp the image in the vertical direction, making
''' all textlines horizontal.  Likewise, the horizontal
''' disparity array is used to left- and right-align the
''' longest textlines.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="debugfile">[in]use NULL to skip - writing this</param>
'''   <returns>0 if OK, 1 if unable to build the model or on error</returns>
Public Shared Function dewarpBuildPageModel(
				ByVal dew as L_Dewarp, 
				Optional ByVal debugfile as String = Nothing) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpBuildPageModel( dew.Pointer, debugfile)

	Return _Result
End Function

' SRC\dewarp2.c (294, 1)
' dewarpFindVertDisparity()
' dewarpFindVertDisparity(L_DEWARP *, PTAA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This starts with points along the centers of textlines.
''' It does quadratic fitting (and smoothing), first along the
''' lines and then in the vertical direction, to generate
''' the sampled vertical disparity map.  This can then be
''' interpolated to full resolution and used to remove
''' the vertical line warping.
''' (2) Use %rotflag == 1 if you are dewarping vertical lines, as
''' is done in dewarpBuildLineModel().  The usual case is for
''' %rotflag == 0.
''' (3) Note that this builds a vertical disparity model (VDM), but
''' does not check it against constraints for validity.
''' Constraint checking is done after building the models,
''' and before inserting reference models.
''' (4) This sets the vsuccess flag to 1 on success.
''' (5) Pix debug output goes to /tmp/dewvert/ for collection into
''' a pdf.  Non-pix debug output goes to /tmp.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="ptaa">[in] - unsmoothed lines, not vertically ordered</param>
'''  <param name="rotflag">[in] - 0 if using dew-GTpixs; 1 if rotated by 90 degrees cw</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpFindVertDisparity(
				ByVal dew as L_Dewarp, 
				ByVal ptaa as Ptaa, 
				ByVal rotflag as Integer) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
	If IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpFindVertDisparity( dew.Pointer, ptaa.Pointer, rotflag)

	Return _Result
End Function

' SRC\dewarp2.c (558, 1)
' dewarpFindHorizDisparity()
' dewarpFindHorizDisparity(L_DEWARP *, PTAA *) as l_ok
'''  <summary>
''' Notes
''' (1) This builds a horizontal disparity model (HDM), but
''' does not check it against constraints for validity.
''' Constraint checking is done at rendering time.
''' (2) Horizontal disparity is not required for a successful model;
''' only the vertical disparity is required.  This will not be
''' called if the function to build the vertical disparity fails.
''' (3) This sets the hsuccess flag to 1 on success.
''' (4) Internally in ptal1, ptar1, ptal2, ptar2 x and y are reversed,
''' so the 'y' value is horizontal distance across the image width.
''' (5) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="ptaa">[in] - unsmoothed lines, not vertically ordered</param>
'''   <returns>0 if OK, 1 if horizontal disparity array is not built, or on error</returns>
Public Shared Function dewarpFindHorizDisparity(
				ByVal dew as L_Dewarp, 
				ByVal ptaa as Ptaa) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
	If IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpFindHorizDisparity( dew.Pointer, ptaa.Pointer)

	Return _Result
End Function

' SRC\dewarp2.c (762, 1)
' dewarpGetTextlineCenters()
' dewarpGetTextlineCenters(PIX *, l_int32) as PTAA *
'''  <summary>
''' Notes
''' (1) This in general does not have a point for each value
''' of x, because there will be gaps between words.
''' It doesn't matter because we will fit a quadratic to the
''' points that we do have.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>ptaa of center values of textlines</returns>
Public Shared Function dewarpGetTextlineCenters(
				ByVal pixs as Pix, 
				ByVal debugflag as Integer) as Ptaa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpGetTextlineCenters( pixs.Pointer, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\dewarp2.c (916, 1)
' dewarpRemoveShortLines()
' dewarpRemoveShortLines(PIX *, PTAA *, l_float32, l_int32) as PTAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="ptaas">[in] - input lines</param>
'''  <param name="fract">[in] - minimum fraction of longest line to keep</param>
'''  <param name="debugflag">[in] - </param>
'''   <returns>ptaad containing only lines of sufficient length, or NULL on error</returns>
Public Shared Function dewarpRemoveShortLines(
				ByVal pixs as Pix, 
				ByVal ptaas as Ptaa, 
				ByVal fract as Single, 
				ByVal debugflag as Integer) as Ptaa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptaas) then Throw New ArgumentNullException  ("ptaas cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpRemoveShortLines( pixs.Pointer, ptaas.Pointer, fract, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\dewarp2.c (1378, 1)
' dewarpFindHorizSlopeDisparity()
' dewarpFindHorizSlopeDisparity(L_DEWARP *, PIX *, l_float32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) %fractthresh is a threshold on the fractional difference in stroke
''' density between between left and right sides.  Process this
''' disparity only if the absolute value of the fractional
''' difference equals or exceeds this threshold.
''' (2) %parity indicates where the binding is on the left for
''' %parity == 0 and on the right for %parity == 1.
''' (3) This takes a 1 bpp %pixb where both vertical and horizontal
''' disparity have been applied, so the text lines are straight and,
''' more importantly, the line end points are vertically aligned.
''' It estimates the foreshortening of the characters on the
''' binding side, and if significant, computes a one-dimensional
''' horizontal disparity function to compensate.
''' (4) The first attempt was to use the average width of the
''' connected components (c.c.) in vertical slices.  This does not work
''' reliably, because the horizontal compression of the text is
''' often accompanied by horizontal joining of c.c.
''' (5) We use the density of vertical strokes, measured by first using
''' a vertical opening, which improves the signal.  The result
''' is relatively insensitive to the size of the opening; we use
''' a 10-pixel opening.  The relative density is measured by
''' finding the number of c.c. in a full height sliding window
''' of width 50 pixels, and compute every 25 pixels.  Similar results
''' are obtained counting c.c. that either intersect the window
''' or are fully contained within it.
''' (6) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="pixb">[in] - (1 bpp, with vertical and horizontal disparity removed)</param>
'''  <param name="fractthresh">[in] - (threshold fractional difference in density)</param>
'''  <param name="parity">[in] - (0 if even page, 1 if odd page)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpFindHorizSlopeDisparity(
				ByVal dew as L_Dewarp, 
				ByVal pixb as Pix, 
				ByVal fractthresh as Single, 
				ByVal parity as Integer) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (fractthresh) then Throw New ArgumentNullException  ("fractthresh cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpFindHorizSlopeDisparity( dew.Pointer, pixb.Pointer, fractthresh, parity)

	Return _Result
End Function

' SRC\dewarp2.c (1606, 1)
' dewarpBuildLineModel()
' dewarpBuildLineModel(L_DEWARP *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This builds the horizontal and vertical disparity arrays
''' for an input of ruled lines, typically for calibration.
''' In book scanning, you could lay the ruled paper over a page.
''' Then for that page and several below it, you can use the
''' disparity correction of the line model to dewarp the pages.
''' (2) The dew has been initialized with the image of ruled lines.
''' These lines must be continuous, but we do a small amount
''' of pre-processing here to insure that.
''' (3) %opensize is typically about 8.  It must be larger than
''' the thickness of the lines to be extracted.  This is the
''' default value, which is applied if %opensize LT 3.
''' (4) Sets vsuccess = 1 and hsuccess = 1 if the vertical and/or
''' horizontal disparity arrays build.
''' (5) Similar to dewarpBuildPageModel(), except here the vertical
''' and horizontal disparity arrays are both built from ruled lines.
''' See notes there.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dew">[in] - </param>
'''  <param name="opensize">[in] - size of opening to remove perpendicular lines</param>
'''  <param name="debugfile">[in]use NULL to skip - writing this</param>
'''   <returns>0 if OK, 1 if unable to build the model or on error</returns>
Public Shared Function dewarpBuildLineModel(
				ByVal dew as L_Dewarp, 
				ByVal opensize as Integer, 
				Optional ByVal debugfile as String = Nothing) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpBuildLineModel( dew.Pointer, opensize, debugfile)

	Return _Result
End Function

' SRC\dewarp2.c (1790, 1)
' dewarpaModelStatus()
' dewarpaModelStatus(L_DEWARPA *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This tests if a model has been built, not if it is valid.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="pageno">[in] - </param>
'''  <param name="pvsuccess">[out][optional] - 1 on success</param>
'''  <param name="phsuccess">[out][optional] - 1 on success</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaModelStatus(
				ByVal dewa as L_Dewarpa, 
				ByVal pageno as Integer, 
				Optional ByRef pvsuccess as Integer = Nothing, 
				Optional ByRef phsuccess as Integer = Nothing) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaModelStatus( dewa.Pointer, pageno, pvsuccess, phsuccess)

	Return _Result
End Function

End Class
