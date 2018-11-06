Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\skew.c (162, 1)
' pixDeskewBoth(pixs, redsearch) as Pix
' pixDeskewBoth(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes if necessary and does both horizontal<para/>
''' and vertical deskewing, using the default parameters in<para/>
''' the underlying pixDeskew().  See usage there.<para/>
''' (2) This may return a clone.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDeskewBoth/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskewBoth(
				 ByVal pixs as Pix, 
				 Optional ByVal redsearch as Integer = 0) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search: reduction factor = 1, 2 or 4 use 0 for default")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskewBoth( pixs.Pointer, redsearch)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (205, 1)
' pixDeskew(pixs, redsearch) as Pix
' pixDeskew(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes if necessary and finds the skew angle.  If the<para/>
''' angle is large enough and there is sufficient confidence,<para/>
''' it returns a deskewed image otherwise, it returns a clone.<para/>
''' (2) Typical values at 300 ppi for %redsearch are 2 and 4.<para/>
''' At 75 ppi, one should use %redsearch = 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDeskew/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskew(
				 ByVal pixs as Pix, 
				 Optional ByVal redsearch as Integer = 0) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search: reduction factor = 1, 2 or 4 use 0 for default")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskew( pixs.Pointer, redsearch)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (241, 1)
' pixFindSkewAndDeskew(pixs, redsearch, pangle, pconf) as Pix
' pixFindSkewAndDeskew(PIX *, l_int32, l_float32 *, l_float32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes if necessary and finds the skew angle.  If the<para/>
''' angle is large enough and there is sufficient confidence,<para/>
''' it returns a deskewed image otherwise, it returns a clone.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewAndDeskew/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''  <param name="pangle">[out][optional] - angle required to deskew, in degrees use NULL to skip</param>
'''  <param name="pconf">[out][optional] - conf value is ratio of max/min scores use NULL to skip</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixFindSkewAndDeskew(
				 ByVal pixs as Pix, 
				 Optional ByVal redsearch as Integer = 0, 
				<Out()> Optional ByRef pangle as Single = Nothing, 
				<Out()> Optional ByRef pconf as Single = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search: reduction factor = 1, 2 or 4 use 0 for default")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindSkewAndDeskew( pixs.Pointer, redsearch, pangle, pconf)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (285, 1)
' pixDeskewGeneral(pixs, redsweep, sweeprange, sweepdelta, redsearch, thresh, pangle, pconf) as Pix
' pixDeskewGeneral(PIX *, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32 *, l_float32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes if necessary and finds the skew angle.  If the<para/>
''' angle is large enough and there is sufficient confidence,<para/>
''' it returns a deskewed image otherwise, it returns a clone.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDeskewGeneral/*"/>
'''  <param name="pixs">[in] - any depth</param>
'''  <param name="redsweep">[in] - for linear search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''  <param name="sweeprange">[in] - in degrees in each direction from 0 use 0.0 for default</param>
'''  <param name="sweepdelta">[in] - in degrees use 0.0 for default</param>
'''  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''  <param name="thresh">[in] - for binarizing the image use 0 for default</param>
'''  <param name="pangle">[out][optional] - angle required to deskew, in degrees use NULL to skip</param>
'''  <param name="pconf">[out][optional] - conf value is ratio of max/min scores use NULL to skip</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Shared Function pixDeskewGeneral(
				 ByVal pixs as Pix, 
				 Optional ByVal redsweep as Integer = 0, 
				 Optional ByVal sweeprange as Single = 0, 
				 Optional ByVal sweepdelta as Single = 0, 
				 Optional ByVal redsearch as Integer = 0, 
				 Optional ByVal thresh as Integer = 0, 
				<Out()> Optional ByRef pangle as Single = Nothing, 
				<Out()> Optional ByRef pconf as Single = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("for linear search: reduction factor = 1, 2 or 4 use 0 for default")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("for binary search: reduction factor = 1, 2 or 4 use 0 for default")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDeskewGeneral( pixs.Pointer, redsweep, sweeprange, sweepdelta, redsearch, thresh, pangle, pconf)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\skew.c (370, 1)
' pixFindSkew(pixs, pangle, pconf) as Integer
' pixFindSkew(PIX *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a simple high-level interface, that uses default<para/>
''' values of the parameters for reasonable speed and accuracy.<para/>
''' (2) The angle returned is the negative of the skew angle of<para/>
''' the image.  It is the angle required for deskew.<para/>
''' Clockwise rotations are positive angles.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkew/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew, in degrees</param>
'''  <param name="pconf">[out] - confidence value is ratio max/min scores</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkew(
				 ByVal pixs as Pix, 
				<Out()> ByRef pangle as Single, 
				<Out()> ByRef pconf as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkew( pixs.Pointer, pangle, pconf)

	Return _Result
End Function

' SRC\skew.c (414, 1)
' pixFindSkewSweep(pixs, pangle, reduction, sweeprange, sweepdelta) as Integer
' pixFindSkewSweep(PIX *, l_float32 *, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This examines the 'score' for skew angles with equal intervals.<para/>
''' (2) Caller must check the return value for validity of the result.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewSweep/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew, in degrees</param>
'''  <param name="reduction">[in] - factor = 1, 2, 4 or 8</param>
'''  <param name="sweeprange">[in] - half the full range assumed about 0 in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweep(
				 ByVal pixs as Pix, 
				<Out()> ByRef pangle as Single, 
				 ByVal reduction as Integer, 
				 ByVal sweeprange as Single, 
				 ByVal sweepdelta as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("factor = 1, 2, 4 or 8")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweep( pixs.Pointer, pangle, reduction, sweeprange, sweepdelta)

	Return _Result
End Function

' SRC\skew.c (558, 1)
' pixFindSkewSweepAndSearch(pixs, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta) as Integer
' pixFindSkewSweepAndSearch(PIX *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the skew angle, doing first a sweep through a set<para/>
''' of equal angles, and then doing a binary search until<para/>
''' convergence.<para/>
''' (2) Caller must check the return value for validity of the result.<para/>
''' (3) In computing the differential line sum variance score, we sum<para/>
''' the result over scanlines, but we always skip:<para/>
''' ~ at least one scanline<para/>
''' ~ not more than 10% of the image height<para/>
''' ~ not more than 5% of the image width<para/>
''' (4) See also notes in pixFindSkewSweepAndSearchScore()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewSweepAndSearch/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep</param>
'''  <param name="sweeprange">[in] - half the full range, assumed about 0 in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearch(
				 ByVal pixs as Pix, 
				<Out()> ByRef pangle as Single, 
				<Out()> ByRef pconf as Single, 
				 ByVal redsweep as Integer, 
				 ByVal redsearch as Integer, 
				 ByVal sweeprange as Single, 
				 ByVal sweepdelta as Single, 
				 ByVal minbsdelta as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearch( pixs.Pointer, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta)

	Return _Result
End Function

' SRC\skew.c (612, 1)
' pixFindSkewSweepAndSearchScore(pixs, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta) as Integer
' pixFindSkewSweepAndSearchScore(PIX *, l_float32 *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the skew angle, doing first a sweep through a set<para/>
''' of equal angles, and then doing a binary search until convergence.<para/>
''' (2) There are two built-in constants that determine if the<para/>
''' returned confidence is nonzero:<para/>
''' ~ MIN_VALID_MAXSCORE (minimum allowed maxscore)<para/>
''' ~ MINSCORE_THRESHOLD_CONSTANT (determines minimum allowed<para/>
''' minscore, by multiplying by (height  width^2)<para/>
''' If either of these conditions is not satisfied, the returned<para/>
''' confidence value will be zero.  The maxscore is optionally<para/>
''' returned in this function to allow evaluation of the<para/>
''' resulting angle by a method that is independent of the<para/>
''' returned confidence value.<para/>
''' (3) The larger the confidence value, the greater the probability<para/>
''' that the proper alignment is given by the angle that maximizes<para/>
''' variance.  It should be compared to a threshold, which depends<para/>
''' on the application.  Values between 3.0 and 6.0 are common.<para/>
''' (4) By default, the shear is about the UL corner.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewSweepAndSearchScore/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="pendscore">[out][optional] - max score use NULL to ignore</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep</param>
'''  <param name="sweepcenter">[in] - angle about which sweep is performed in degrees</param>
'''  <param name="sweeprange">[in] - half the full range, taken about sweepcenter in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle in degrees</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearchScore(
				 ByVal pixs as Pix, 
				<Out()> ByRef pangle as Single, 
				<Out()> ByRef pconf as Single, 
				<Out()> ByRef pendscore as Single, 
				 ByVal redsweep as Integer, 
				 ByVal redsearch as Integer, 
				 ByVal sweepcenter as Single, 
				 ByVal sweeprange as Single, 
				 ByVal sweepdelta as Single, 
				 ByVal minbsdelta as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearchScore( pixs.Pointer, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta)

	Return _Result
End Function

' SRC\skew.c (661, 1)
' pixFindSkewSweepAndSearchScorePivot(pixs, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta, pivot) as Integer
' pixFindSkewSweepAndSearchScorePivot(PIX *, l_float32 *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in pixFindSkewSweepAndSearchScore().<para/>
''' (2) This allows choice of shear pivoting from either the UL corner<para/>
''' or the center.  For small angles, the ability to discriminate<para/>
''' angles is better with shearing from the UL corner.  However,<para/>
''' for large angles (say, greater than 20 degrees), it is better<para/>
''' to shear about the center because a shear from the UL corner<para/>
''' loses too much of the image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewSweepAndSearchScorePivot/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pangle">[out] - angle required to deskew in degrees</param>
'''  <param name="pconf">[out] - confidence given by ratio of max/min score</param>
'''  <param name="pendscore">[out][optional] - max score use NULL to ignore</param>
'''  <param name="redsweep">[in] - sweep reduction factor = 1, 2, 4 or 8</param>
'''  <param name="redsearch">[in] - binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep</param>
'''  <param name="sweepcenter">[in] - angle about which sweep is performed in degrees</param>
'''  <param name="sweeprange">[in] - half the full range, taken about sweepcenter in degrees</param>
'''  <param name="sweepdelta">[in] - angle increment of sweep in degrees</param>
'''  <param name="minbsdelta">[in] - min binary search increment angle in degrees</param>
'''  <param name="pivot">[in] - L_SHEAR_ABOUT_CORNER, L_SHEAR_ABOUT_CENTER</param>
'''   <returns>0 if OK, 1 on error or if angle measurement not valid</returns>
Public Shared Function pixFindSkewSweepAndSearchScorePivot(
				 ByVal pixs as Pix, 
				<Out()> ByRef pangle as Single, 
				<Out()> ByRef pconf as Single, 
				<Out()> ByRef pendscore as Single, 
				 ByVal redsweep as Integer, 
				 ByVal redsearch as Integer, 
				 ByVal sweepcenter as Single, 
				 ByVal sweeprange as Single, 
				 ByVal sweepdelta as Single, 
				 ByVal minbsdelta as Single, 
				 ByVal pivot as Enumerations.L_SHEAR_ABOUT_CER) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("sweep reduction factor = 1, 2, 4 or 8")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("binary search reduction factor = 1, 2, 4 or 8 and must not exceed redsweep")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewSweepAndSearchScorePivot( pixs.Pointer, pangle, pconf, pendscore, redsweep, redsearch, sweepcenter, sweeprange, sweepdelta, minbsdelta, pivot)

	Return _Result
End Function

' SRC\skew.c (1032, 1)
' pixFindSkewOrthogonalRange(pixs, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta, confprior) as Integer
' pixFindSkewOrthogonalRange(PIX *, l_float32 *, l_float32 *, l_int32, l_int32, l_float32, l_float32, l_float32, l_float32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindSkewOrthogonalRange/*"/>
'''   <returns></returns>
Public Shared Function pixFindSkewOrthogonalRange(
				 ByVal pixs as Pix, 
				 ByVal pangle as Single(), 
				 ByVal pconf as Single(), 
				 ByVal redsweep as Integer, 
				 ByVal redsearch as Integer, 
				 ByVal sweeprange as Single, 
				 ByVal sweepdelta as Single, 
				 ByVal minbsdelta as Single, 
				 ByVal confprior as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pangle) then Throw New ArgumentNullException  ("pangle cannot be Nothing")
	If IsNothing (pconf) then Throw New ArgumentNullException  ("pconf cannot be Nothing")

	If {0,1,2,4,8}.contains (redsweep) = false then Throw New ArgumentException ("")
	If {0,1,2,4,8}.contains (redsearch) = false then Throw New ArgumentException ("")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindSkewOrthogonalRange( pixs.Pointer, pangle, pconf, redsweep, redsearch, sweeprange, sweepdelta, minbsdelta, confprior)

	Return _Result
End Function

' SRC\skew.c (1105, 1)
' pixFindDifferentialSquareSum(pixs, psum) as Integer
' pixFindDifferentialSquareSum(PIX *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) At the top and bottom, we skip:<para/>
''' ~ at least one scanline<para/>
''' ~ not more than 10% of the image height<para/>
''' ~ not more than 5% of the image width<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindDifferentialSquareSum/*"/>
'''  <param name="pixs">[in] - </param>
'''  <param name="psum">[out] - result</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindDifferentialSquareSum(
				 ByVal pixs as Pix, 
				<Out()> ByRef psum as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindDifferentialSquareSum( pixs.Pointer, psum)

	Return _Result
End Function

' SRC\skew.c (1178, 1)
' pixFindNormalizedSquareSum(pixs, phratio, pvratio, pfract) as Integer
' pixFindNormalizedSquareSum(PIX *, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Let the image have h scanlines and N fg pixels.<para/>
''' If the pixels were uniformly distributed on scanlines,<para/>
''' the sum of squares of fg pixels on each scanline would be<para/>
''' h  (N / h)^2.  However, if the pixels are not uniformly<para/>
''' distributed (e.g., for text), the sum of squares of fg<para/>
''' pixels will be larger.  We return in hratio and vratio the<para/>
''' ratio of these two values.<para/>
''' (2) If there are no fg pixels, hratio and vratio are returned as 0.0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindNormalizedSquareSum/*"/>
'''  <param name="pixs">[in] - </param>
'''  <param name="phratio">[out][optional] - ratio of normalized horiz square sum to result if the pixel distribution were uniform</param>
'''  <param name="pvratio">[out][optional] - ratio of normalized vert square sum to result if the pixel distribution were uniform</param>
'''  <param name="pfract">[out][optional] - ratio of fg pixels to total pixels</param>
'''   <returns>0 if OK, 1 on error or if there are no fg pixels</returns>
Public Shared Function pixFindNormalizedSquareSum(
				 ByVal pixs as Pix, 
				<Out()> Optional ByRef phratio as Single = Nothing, 
				<Out()> Optional ByRef pvratio as Single = Nothing, 
				<Out()> Optional ByRef pfract as Single = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindNormalizedSquareSum( pixs.Pointer, phratio, pvratio, pfract)

	Return _Result
End Function

End Class
