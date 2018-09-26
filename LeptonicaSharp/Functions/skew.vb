Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\skew.c (162, 1)
' pixDeskewBoth()
' pixDeskewBoth(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This binarizes if necessary and does both horizontal
''' and vertical deskewing, using the default parameters in
''' the underlying pixDeskew().  See usage there.
''' (2) This may return a clone.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search reduction factor = 1, 2 or 4; use 0 for default</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskewBoth(
				ByVal pixs as Pix, 
				Optional ByVal redsearch as Integer = 0) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search reduction factor = 1, 2 or 4; use 0 for default") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskewBoth( pixs.Pointer, redsearch)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (205, 1)
' pixDeskew()
' pixDeskew(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This binarizes if necessary and finds the skew angle.  If the
''' angle is large enough and there is sufficient confidence,
''' it returns a deskewed image; otherwise, it returns a clone.
''' (2) Typical values at 300 ppi for %redsearch are 2 and 4.
''' At 75 ppi, one should use %redsearch = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search reduction factor = 1, 2 or 4; use 0 for default</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskew(
				ByVal pixs as Pix, 
				Optional ByVal redsearch as Integer = 0) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search reduction factor = 1, 2 or 4; use 0 for default") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskew( pixs.Pointer, redsearch)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (241, 1)
' pixFindSkewAndDeskew()
' pixFindSkewAndDeskew(PIX *, l_int32, l_float32 *, l_float32 *) as PIX *
'''  <summary>
''' Notes
''' (1) This binarizes if necessary and finds the skew angle.  If the
''' angle is large enough and there is sufficient confidence,
''' it returns a deskewed image; otherwise, it returns a clone.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search reduction factor = 1, 2 or 4; use 0 for default</param>
'''  <param name="pangle">[out][optional] - angle required to deskew, in degrees; use NULL to skip</param>
'''  <param name="pconf">[out][optional] - conf value is ratio of max/min scores; use NULL to skip</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixFindSkewAndDeskew(
				ByVal pixs as Pix, 
				Optional ByVal redsearch as Integer = 0, 
				Optional ByRef pangle as Single() = Nothing, 
				Optional ByRef pconf as Single() = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search reduction factor = 1, 2 or 4; use 0 for default") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindSkewAndDeskew( pixs.Pointer, redsearch, pangle, pconf)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (285, 1)
' pixDeskewGeneral()
' pixDeskewGeneral(PIX *, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32 *, l_float32 *) as PIX *
'''  <summary>
''' Notes
''' (1) This binarizes if necessary and finds the skew angle.  If the
''' angle is large enough and there is sufficient confidence,
''' it returns a deskewed image; otherwise, it returns a clone.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsweep">[in] - for linear search reduction factor = 1, 2 or 4; use 0 for default</param>
'''  <param name="sweeprange">[in] - in degrees in each direction from 0; use 0.0 for default</param>
'''  <param name="sweepdelta">[in] - in degrees; use 0.0 for default</param>
'''  <param name="redsearch">[in] - for binary search reduction factor = 1, 2 or 4; use 0 for default;</param>
'''  <param name="thresh">[in] - for binarizing the image; use 0 for default</param>
'''  <param name="pangle">[out][optional] - angle required to deskew, in degrees; use NULL to skip</param>
'''  <param name="pconf">[out][optional] - conf value is ratio of max/min scores; use NULL to skip</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskewGeneral(
				ByVal pixs as Pix, 
				ByVal sweeprange as Single, 
				ByVal sweepdelta as Single, 
				Optional ByVal redsweep as Integer = 0, 
				Optional ByVal redsearch as Integer = 0, 
				Optional ByVal thresh as Integer = 0, 
				Optional ByRef pangle as Single() = Nothing, 
				Optional ByRef pconf as Single() = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("for linear search reduction factor = 1, 2 or 4; use 0 for default") ' All Functions - specific Parameter - ArrayCheck
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search reduction factor = 1, 2 or 4; use 0 for default;") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskewGeneral( pixs.Pointer, redsweep, sweeprange, sweepdelta, redsearch, thresh, pangle, pconf)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (370, 1)
' pixFindSkew()
' pixFindSkew(PIX *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a simple high-level interface, that uses default
''' values of the parameters for reasonable speed and accuracy.
''' (2) The angle returned is the negative of the skew angle of
''' the image.  It is the angle required for deskew.
''' Clockwise rotations are positive angles.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew, in degrees</param>
'''  <param name="pconf">[out] - confidence value is ratio max/min scores</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkew(
				ByVal pixs as Pix, 
				ByRef pangle as Single(), 
				ByRef pconf as Single()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkew( pixs.Pointer, pangle, pconf)

	Return _Result
End Function

' SRC\skew.c (414, 1)
' pixFindSkewSweep()
' pixFindSkewSweep(PIX *, l_float32 *, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This examines the 'score' for skew angles with equal intervals.
''' (2) Caller must check the return value for validity of the result.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew, in degrees</param>
'''  <param name="reduction">[in] - factor = 1, 2, 4 or 8</param>
'''  <param name="sweeprange">[in] - half the full range; assumed about 0; in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep; in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweep(
				ByVal pixs as Pix, 
				ByRef pangle as Single(), 
				ByVal reduction as Integer, 
				ByVal sweeprange as Single, 
				ByVal sweepdelta as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("factor = 1, 2, 4 or 8") ' All Functions - specific Parameter - RangeCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweep( pixs.Pointer, pangle, reduction, sweeprange, sweepdelta)

	Return _Result
End Function

' SRC\skew.c (558, 1)
' pixFindSkewSweepAndSearch()
' pixFindSkewSweepAndSearch(PIX *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This finds the skew angle, doing first a sweep through a set
''' of equal angles, and then doing a binary search until
''' convergence.
''' (2) Caller must check the return value for validity of the result.
''' (3) In computing the differential line sum variance score, we sum
''' the result over scanlines, but we always skip
''' ~ at least one scanline
''' ~ not more than 10% of the image height
''' ~ not more than 5% of the image width
''' (4) See also notes in pixFindSkewSweepAndSearchScore()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew; in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep</param>
'''  <param name="sweeprange">[in] - half the full range, assumed about 0; in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep; in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle; in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearch(
				ByVal pixs as Pix, 
				ByRef pangle as Single(), 
				ByRef pconf as Single(), 
				ByVal sweeprange as Single, 
				ByVal sweepdelta as Single, 
				ByVal minbsdelta as Single, 
				Optional ByVal redsweep as Integer = 0, 
				Optional ByVal redsearch as Integer = 0) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If IsNothing (minbsdelta) then Throw New ArgumentNullException  ("minbsdelta cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8") ' All Functions - specific Parameter - ArrayCheck
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearch( pixs.Pointer, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta)

	Return _Result
End Function

' SRC\skew.c (612, 1)
' pixFindSkewSweepAndSearchScore()
' pixFindSkewSweepAndSearchScore(PIX *, l_float32 *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This finds the skew angle, doing first a sweep through a set
''' of equal angles, and then doing a binary search until convergence.
''' (2) There are two built-in constants that determine if the
''' returned confidence is nonzero
''' ~ MIN_VALID_MAXSCORE (minimum allowed maxscore)
''' ~ MINSCORE_THRESHOLD_CONSTANT (determines minimum allowed
''' minscore, by multiplying by (height  width^2)
''' If either of these conditions is not satisfied, the returned
''' confidence value will be zero.  The maxscore is optionally
''' returned in this function to allow evaluation of the
''' resulting angle by a method that is independent of the
''' returned confidence value.
''' (3) The larger the confidence value, the greater the probability
''' that the proper alignment is given by the angle that maximizes
''' variance.  It should be compared to a threshold, which depends
''' on the application.  Values between 3.0 and 6.0 are common.
''' (4) By default, the shear is about the UL corner.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew; in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="pendscore">[out][optional] - max score; use NULL to ignore</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep</param>
'''  <param name="sweepcenter">[in] - angle about which sweep is performed; in degrees</param>
'''  <param name="sweeprange">[in] - half the full range, taken about sweepcenter; in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep; in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle; in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearchScore(
				ByVal pixs as Pix, 
				ByRef pangle as Single(), 
				ByRef pconf as Single(), 
				ByVal sweepcenter as Single, 
				ByVal sweeprange as Single, 
				ByVal sweepdelta as Single, 
				ByVal minbsdelta as Single, 
				Optional ByRef pendscore as Single() = Nothing, 
				Optional ByVal redsweep as Integer = 0, 
				Optional ByVal redsearch as Integer = 0) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sweepcenter) then Throw New ArgumentNullException  ("sweepcenter cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If IsNothing (minbsdelta) then Throw New ArgumentNullException  ("minbsdelta cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8") ' All Functions - specific Parameter - ArrayCheck
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearchScore( pixs.Pointer, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta)

	Return _Result
End Function

' SRC\skew.c (661, 1)
' pixFindSkewSweepAndSearchScorePivot()
' pixFindSkewSweepAndSearchScorePivot(PIX *, l_float32 *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) See notes in pixFindSkewSweepAndSearchScore().
''' (2) This allows choice of shear pivoting from either the UL corner
''' or the center.  For small angles, the ability to discriminate
''' angles is better with shearing from the UL corner.  However,
''' for large angles (say, greater than 20 degrees), it is better
''' to shear about the center because a shear from the UL corner
''' loses too much of the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew; in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="pendscore">[out][optional] - max score; use NULL to ignore</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep</param>
'''  <param name="sweepcenter">[in] - angle about which sweep is performed; in degrees</param>
'''  <param name="sweeprange">[in] - half the full range, taken about sweepcenter; in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep; in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle; in degrees</param>
'''  <param name="pivot">[in] - L_SHEAR_ABOUT_CORNER, L_SHEAR_ABOUT_CENTER</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearchScorePivot(
				ByVal pixs as Pix, 
				ByRef pangle as Single(), 
				ByRef pconf as Single(), 
				ByVal sweepcenter as Single, 
				ByVal sweeprange as Single, 
				ByVal sweepdelta as Single, 
				ByVal minbsdelta as Single, 
				ByVal pivot as Enumerations.L_SHEAR_ABOUT_CER, 
				Optional ByRef pendscore as Single() = Nothing, 
				Optional ByVal redsweep as Integer = 0, 
				Optional ByVal redsearch as Integer = 0) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sweepcenter) then Throw New ArgumentNullException  ("sweepcenter cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If IsNothing (minbsdelta) then Throw New ArgumentNullException  ("minbsdelta cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8") ' All Functions - specific Parameter - ArrayCheck
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8; and must not exceed redsweep") ' All Functions - specific Parameter - ArrayCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearchScorePivot( pixs.Pointer, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta, pivot)

	Return _Result
End Function

' SRC\skew.c (1032, 1)
' 
' pixFindSkewOrthogonalRange(PIX *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixFindSkewOrthogonalRange(
				ByRef pixs as Pix, 
				ByRef pangle as Single(), 
				ByRef pconf as Single(), 
				ByRef sweeprange as Single, 
				ByRef sweepdelta as Single, 
				ByRef minbsdelta as Single, 
				ByRef confprior as Single, 
				Optional ByVal redsweep as Integer = 0, 
				Optional ByVal redsearch as Integer = 0) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pangle) then Throw New ArgumentNullException  ("pangle cannot be Nothing")
	If IsNothing (pconf) then Throw New ArgumentNullException  ("pconf cannot be Nothing")
	If IsNothing (sweeprange) then Throw New ArgumentNullException  ("sweeprange cannot be Nothing")
	If IsNothing (sweepdelta) then Throw New ArgumentNullException  ("sweepdelta cannot be Nothing")
	If IsNothing (minbsdelta) then Throw New ArgumentNullException  ("minbsdelta cannot be Nothing")
	If IsNothing (confprior) then Throw New ArgumentNullException  ("confprior cannot be Nothing")
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("") ' All Functions - specific Parameter - ArrayCheck
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("") ' All Functions - specific Parameter - ArrayCheck

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewOrthogonalRange( pixs.Pointer, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta, confprior)

	Return _Result
End Function

' SRC\skew.c (1105, 1)
' pixFindDifferentialSquareSum()
' pixFindDifferentialSquareSum(PIX *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) At the top and bottom, we skip
''' ~ at least one scanline
''' ~ not more than 10% of the image height
''' ~ not more than 5% of the image width
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="psum">[out] - result</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindDifferentialSquareSum(
				ByVal pixs as Pix, 
				ByRef psum as Single()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindDifferentialSquareSum( pixs.Pointer, psum)

	Return _Result
End Function

' SRC\skew.c (1178, 1)
' pixFindNormalizedSquareSum()
' pixFindNormalizedSquareSum(PIX *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) Let the image have h scanlines and N fg pixels.
''' If the pixels were uniformly distributed on scanlines,
''' the sum of squares of fg pixels on each scanline would be
''' h  (N / h)^2.  However, if the pixels are not uniformly
''' distributed (e.g., for text), the sum of squares of fg
''' pixels will be larger.  We return in hratio and vratio the
''' ratio of these two values.
''' (2) If there are no fg pixels, hratio and vratio are returned as 0.0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="phratio">[out][optional] - ratio of normalized horiz square sum to result if the pixel distribution were uniform</param>
'''  <param name="pvratio">[out][optional] - ratio of normalized vert square sum to result if the pixel distribution were uniform</param>
'''  <param name="pfract">[out][optional] - ratio of fg pixels to total pixels</param>
'''   <returns>0 if OK, 1 on error or if there are no fg pixels</returns>
Public Shared Function pixFindNormalizedSquareSum(
				ByVal pixs as Pix, 
				Optional ByRef phratio as Single() = Nothing, 
				Optional ByRef pvratio as Single() = Nothing, 
				Optional ByRef pfract as Single() = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindNormalizedSquareSum( pixs.Pointer, phratio, pvratio, pfract)

	Return _Result
End Function

End Class
