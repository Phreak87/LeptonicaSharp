Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dewarp2.c (148, 1)
' dewarpBuildPageModel(dew, debugfile) as Integer
' dewarpBuildPageModel(L_DEWARP *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is the basic function that builds the horizontal and<para/>
''' vertical disparity arrays, which allow determination of the<para/>
''' src pixel in the input image corresponding to each<para/>
''' dest pixel in the dewarped image.<para/>
''' (2) Sets vsuccess = 1 if the vertical disparity array builds.<para/>
''' Always attempts to build the horizontal disparity array,<para/>
''' even if it will not be requested (useboth == 0).<para/>
''' Sets hsuccess = 1 if horizontal disparity builds.<para/>
''' (3) The method is as follows:<para/>
''' (a) Estimate the points along the centers of all the<para/>
''' long textlines.  If there are too few lines, no<para/>
''' disparity models are built.<para/>
''' (b) From the vertical deviation of the lines, estimate<para/>
''' the vertical disparity.<para/>
''' (c) From the ends of the lines, estimate the horizontal<para/>
''' disparity, assuming that the text is made of lines<para/>
''' that are close to left and right justified.<para/>
''' (d) One can also compute an additional contribution to the<para/>
''' horizontal disparity, inferred from slopes of the top<para/>
''' and bottom lines.  We do not do this.<para/>
''' (4) In more detail for the vertical disparity:<para/>
''' (a) Fit a LS quadratic to center locations along each line.<para/>
''' This smooths the curves.<para/>
''' (b) Sample each curve at a regular interval, find the y-value<para/>
''' of the mid-point on each curve, and subtract the sampled<para/>
''' curve value from this value.  This is the vertical<para/>
''' disparity at sampled points along each curve.<para/>
''' (c) Fit a LS quadratic to each set of vertically aligned<para/>
''' disparity samples.  This smooths the disparity values<para/>
''' in the vertical direction.  Then resample at the same<para/>
''' regular interval.  We now have a regular grid of smoothed<para/>
''' vertical disparity valuels.<para/>
''' (5) Once the sampled vertical disparity array is found, it can be<para/>
''' interpolated to get a full resolution vertical disparity map.<para/>
''' This can be applied directly to the src image pixels<para/>
''' to dewarp the image in the vertical direction, making<para/>
''' all textlines horizontal.  Likewise, the horizontal<para/>
''' disparity array is used to left- and right-align the<para/>
''' longest textlines.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpBuildPageModel/*"/>
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
' dewarpFindVertDisparity(dew, ptaa, rotflag) as Integer
' dewarpFindVertDisparity(L_DEWARP *, PTAA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This starts with points along the centers of textlines.<para/>
''' It does quadratic fitting (and smoothing), first along the<para/>
''' lines and then in the vertical direction, to generate<para/>
''' the sampled vertical disparity map.  This can then be<para/>
''' interpolated to full resolution and used to remove<para/>
''' the vertical line warping.<para/>
''' (2) Use %rotflag == 1 if you are dewarping vertical lines, as<para/>
''' is done in dewarpBuildLineModel().  The usual case is for<para/>
''' %rotflag == 0.<para/>
''' (3) Note that this builds a vertical disparity model (VDM), but<para/>
''' does not check it against constraints for validity.<para/>
''' Constraint checking is done after building the models,<para/>
''' and before inserting reference models.<para/>
''' (4) This sets the vsuccess flag to 1 on success.<para/>
''' (5) Pix debug output goes to /tmp/dewvert/ for collection into<para/>
''' a pdf.  Non-pix debug output goes to /tmp.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpFindVertDisparity/*"/>
'''  <param name="dew">[in] - </param>
'''  <param name="ptaa">[in] - unsmoothed lines, not vertically ordered</param>
'''  <param name="rotflag">[in] - 0 if using dew- is greater pixs 1 if rotated by 90 degrees cw</param>
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
' dewarpFindHorizDisparity(dew, ptaa) as Integer
' dewarpFindHorizDisparity(L_DEWARP *, PTAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This builds a horizontal disparity model (HDM), but<para/>
''' does not check it against constraints for validity.<para/>
''' Constraint checking is done at rendering time.<para/>
''' (2) Horizontal disparity is not required for a successful model<para/>
''' only the vertical disparity is required.  This will not be<para/>
''' called if the function to build the vertical disparity fails.<para/>
''' (3) This sets the hsuccess flag to 1 on success.<para/>
''' (4) Internally in ptal1, ptar1, ptal2, ptar2: x and y are reversed,<para/>
''' so the 'y' value is horizontal distance across the image width.<para/>
''' (5) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpFindHorizDisparity/*"/>
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
' dewarpGetTextlineCenters(pixs, debugflag) as Ptaa
' dewarpGetTextlineCenters(PIX *, l_int32) as PTAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This in general does not have a point for each value<para/>
''' of x, because there will be gaps between words.<para/>
''' It doesn't matter because we will fit a quadratic to the<para/>
''' points that we do have.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpGetTextlineCenters/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>ptaa of center values of textlines</returns>
Public Shared Function dewarpGetTextlineCenters(
				 ByVal pixs as Pix, 
				 ByVal debugflag as Integer) as Ptaa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpGetTextlineCenters( pixs.Pointer, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\dewarp2.c (916, 1)
' dewarpRemoveShortLines(pixs, ptaas, fract, debugflag) as Ptaa
' dewarpRemoveShortLines(PIX *, PTAA *, l_float32, l_int32) as PTAA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpRemoveShortLines/*"/>
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

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpRemoveShortLines( pixs.Pointer, ptaas.Pointer, fract, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\dewarp2.c (1378, 1)
' dewarpFindHorizSlopeDisparity(dew, pixb, fractthresh, parity) as Integer
' dewarpFindHorizSlopeDisparity(L_DEWARP *, PIX *, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %fractthresh is a threshold on the fractional difference in stroke<para/>
''' density between between left and right sides.  Process this<para/>
''' disparity only if the absolute value of the fractional<para/>
''' difference equals or exceeds this threshold.<para/>
''' (2) %parity indicates where the binding is: on the left for<para/>
''' %parity == 0 and on the right for %parity == 1.<para/>
''' (3) This takes a 1 bpp %pixb where both vertical and horizontal<para/>
''' disparity have been applied, so the text lines are straight and,<para/>
''' more importantly, the line end points are vertically aligned.<para/>
''' It estimates the foreshortening of the characters on the<para/>
''' binding side, and if significant, computes a one-dimensional<para/>
''' horizontal disparity function to compensate.<para/>
''' (4) The first attempt was to use the average width of the<para/>
''' connected components (c.c.) in vertical slices.  This does not work<para/>
''' reliably, because the horizontal compression of the text is<para/>
''' often accompanied by horizontal joining of c.c.<para/>
''' (5) We use the density of vertical strokes, measured by first using<para/>
''' a vertical opening, which improves the signal.  The result<para/>
''' is relatively insensitive to the size of the opening we use<para/>
''' a 10-pixel opening.  The relative density is measured by<para/>
''' finding the number of c.c. in a full height sliding window<para/>
''' of width 50 pixels, and compute every 25 pixels.  Similar results<para/>
''' are obtained counting c.c. that either intersect the window<para/>
''' or are fully contained within it.<para/>
''' (6) Debug output goes to /tmp/lept/dewmod/ for collection into a pdf.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpFindHorizSlopeDisparity/*"/>
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

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpFindHorizSlopeDisparity( dew.Pointer, pixb.Pointer, fractthresh, parity)

	Return _Result
End Function

' SRC\dewarp2.c (1606, 1)
' dewarpBuildLineModel(dew, opensize, debugfile) as Integer
' dewarpBuildLineModel(L_DEWARP *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This builds the horizontal and vertical disparity arrays<para/>
''' for an input of ruled lines, typically for calibration.<para/>
''' In book scanning, you could lay the ruled paper over a page.<para/>
''' Then for that page and several below it, you can use the<para/>
''' disparity correction of the line model to dewarp the pages.<para/>
''' (2) The dew has been initialized with the image of ruled lines.<para/>
''' These lines must be continuous, but we do a small amount<para/>
''' of pre-processing here to insure that.<para/>
''' (3) %opensize is typically about 8.  It must be larger than<para/>
''' the thickness of the lines to be extracted.  This is the<para/>
''' default value, which is applied if %opensize  is lower  3.<para/>
''' (4) Sets vsuccess = 1 and hsuccess = 1 if the vertical and/or<para/>
''' horizontal disparity arrays build.<para/>
''' (5) Similar to dewarpBuildPageModel(), except here the vertical<para/>
''' and horizontal disparity arrays are both built from ruled lines.<para/>
''' See notes there.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpBuildLineModel/*"/>
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
' dewarpaModelStatus(dewa, pageno, pvsuccess, phsuccess) as Integer
' dewarpaModelStatus(L_DEWARPA *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This tests if a model has been built, not if it is valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpaModelStatus/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="pageno">[in] - </param>
'''  <param name="pvsuccess">[out][optional] - 1 on success</param>
'''  <param name="phsuccess">[out][optional] - 1 on success</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaModelStatus(
				 ByVal dewa as L_Dewarpa, 
				 ByVal pageno as Integer, 
				<Out()> Optional ByRef pvsuccess as Integer = Nothing, 
				<Out()> Optional ByRef phsuccess as Integer = Nothing) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaModelStatus( dewa.Pointer, pageno, pvsuccess, phsuccess)

	Return _Result
End Function

End Class
