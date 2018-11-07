Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\projective.c (141, 1)
' pixProjectiveSampledPta(pixs, ptad, ptas, incolor) as Pix
' pixProjectiveSampledPta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Brings in either black or white pixels from the boundary.<para/>
''' 
''' (2) Retains colormap, which you can do for a sampled transform..<para/>
''' 
''' (3) No 3 of the 4 points may be collinear.<para/>
''' 
''' (4) For 8 and 32 bpp pix, better quality is obtained by the
''' somewhat slower pixProjectivePta().  See that
''' function for relative timings between sampled and interpolated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectiveSampledPta/*"/>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectiveSampledPta(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectiveSampledPta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (191, 1)
' pixProjectiveSampled(pixs, vc, incolor) as Pix
' pixProjectiveSampled(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Brings in either black or white pixels from the boundary.<para/>
''' 
''' (2) Retains colormap, which you can do for a sampled transform..<para/>
''' 
''' (3) For 8 or 32 bpp, much better quality is obtained by the
''' somewhat slower pixProjective().  See that function
''' for relative timings between sampled and interpolated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectiveSampled/*"/>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectiveSampled(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectiveSampled( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (284, 1)
' pixProjectivePta(pixs, ptad, ptas, incolor) as Pix
' pixProjectivePta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Brings in either black or white pixels from the boundary<para/>
''' 
''' (2) Removes any existing colormap, if necessary, before transforming
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectivePta/*"/>
'''  <param name="pixs">[in] - all depths colormap ok</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectivePta(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectivePta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (354, 1)
' pixProjective(pixs, vc, incolor) as Pix
' pixProjective(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Brings in either black or white pixels from the boundary<para/>
''' 
''' (2) Removes any existing colormap, if necessary, before transforming
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjective/*"/>
'''  <param name="pixs">[in] - all depths colormap ok</param>
'''  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjective(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjective( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (410, 1)
' pixProjectivePtaColor(pixs, ptad, ptas, colorval) as Pix
' pixProjectivePtaColor(PIX *, PTA *, PTA *, l_uint32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectivePtaColor/*"/>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectivePtaColor(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectivePtaColor( pixs.Pointer, ptad.Pointer, ptas.Pointer, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (451, 1)
' pixProjectiveColor(pixs, vc, colorval) as Pix
' pixProjectiveColor(PIX *, l_float32 *, l_uint32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectiveColor/*"/>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectiveColor(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectiveColor( pixs.Pointer, vc, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (513, 1)
' pixProjectivePtaGray(pixs, ptad, ptas, grayval) as Pix
' pixProjectivePtaGray(PIX *, PTA *, PTA *, l_uint8) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectivePtaGray/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectivePtaGray(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectivePtaGray( pixs.Pointer, ptad.Pointer, ptas.Pointer, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (555, 1)
' pixProjectiveGray(pixs, vc, grayval) as Pix
' pixProjectiveGray(PIX *, l_float32 *, l_uint8) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectiveGray/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="vc">[in] - vector of 8 coefficients for projective transformation</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectiveGray(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectiveGray( pixs.Pointer, vc, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (644, 1)
' pixProjectivePtaWithAlpha(pixs, ptad, ptas, pixg, fract, border) as Pix
' pixProjectivePtaWithAlpha(PIX *, PTA *, PTA *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The alpha channel is transformed separately from pixs,
''' and aligns with it, being fully transparent outside the
''' boundary of the transformed pixs.  For pixels that are fully
''' transparent, a blending function like pixBlendWithGrayMask()
''' will give zero weight to corresponding pixels in pixs.<para/>
''' 
''' (2) If pixg is NULL, it is generated as an alpha layer that is
''' partially opaque, using %fract.  Otherwise, it is cropped
''' to pixs if required and %fract is ignored.  The alpha channel
''' in pixs is never used.<para/>
''' 
''' (3) Colormaps are removed.<para/>
''' 
''' (4) When pixs is transformed, it doesn't matter what color is brought
''' in because the alpha channel will be transparent (0) there.<para/>
''' 
''' (5) To avoid losing source pixels in the destination, it may be
''' necessary to add a border to the source pix before doing
''' the projective transformation.  This can be any non-negative
''' number.<para/>
''' 
''' (6) The input %ptad and %ptas are in a coordinate space before
''' the border is added.  Internally, we compensate for this
''' before doing the projective transform on the image after
''' the border is added.<para/>
''' 
''' (7) The default setting for the border values in the alpha channel
''' is 0 (transparent) for the outermost ring of pixels and
''' (0.5  fract  255) for the second ring.  When blended over
''' a second image, this
''' (a) shrinks the visible image to make a clean overlap edge
''' with an image below, and
''' (b) softens the edges by weakening the aliasing there.
''' Use l_setAlphaMaskBorder() to change these values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixProjectivePtaWithAlpha/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="pixg">[in][optional] - 8 bpp, for alpha channel, can be null</param>
'''  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
'''  <param name="border">[in] - of pixels added to capture transformed source pixels</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixProjectivePtaWithAlpha(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal pixg as Pix, 
				 ByVal fract as Single, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixProjectivePtaWithAlpha( pixs.Pointer, ptad.Pointer, ptas.Pointer, pixgPTR, fract, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\projective.c (775, 1)
' getProjectiveXformCoeffs(ptas, ptad, pvc) as Integer
' getProjectiveXformCoeffs(PTA *, PTA *, l_float32 **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/getProjectiveXformCoeffs/*"/>
'''  <param name="ptas">[in] - source 4 points unprimed</param>
'''  <param name="ptad">[in] - transformed 4 points primed</param>
'''  <param name="pvc">[out] - vector of coefficients of transform</param>
'''   <returns>0 if OK 1 on error We have a set of 8 equations, describing the projective transformation that takes 4 points ptas into 4 other points ptad.  These equations are: x1' = c[0]x1 + c[1]y1 + c[2]) / (c[6]x1 + c[7]y1 + 1 y1' = c[3]x1 + c[4]y1 + c[5]) / (c[6]x1 + c[7]y1 + 1 x2' = c[0]x2 + c[1]y2 + c[2]) / (c[6]x2 + c[7]y2 + 1 y2' = c[3]x2 + c[4]y2 + c[5]) / (c[6]x2 + c[7]y2 + 1 x3' = c[0]x3 + c[1]y3 + c[2]) / (c[6]x3 + c[7]y3 + 1 y3' = c[3]x3 + c[4]y3 + c[5]) / (c[6]x3 + c[7]y3 + 1 x4' = c[0]x4 + c[1]y4 + c[2]) / (c[6]x4 + c[7]y4 + 1 y4' = c[3]x4 + c[4]y4 + c[5]) / (c[6]x4 + c[7]y4 + 1 Multiplying both sides of each eqn by the denominator, we get AC = B where B and C are column vectors B = [ x1' y1' x2' y2' x3' y3' x4' y4' ] C = [ c[0] c[1] c[2] c[3] c[4] c[5] c[6] c[7] ] and A is the 8x8 matrix x1   y1     1     0   0    0   -x1x1'  -y1x1' 0    0     0    x1   y1   1   -x1y1'  -y1y1' x2   y2     1     0   0    0   -x2x2'  -y2x2' 0    0     0    x2   y2   1   -x2y2'  -y2y2' x3   y3     1     0   0    0   -x3x3'  -y3x3' 0    0     0    x3   y3   1   -x3y3'  -y3y3' x4   y4     1     0   0    0   -x4x4'  -y4x4' 0    0     0    x4   y4   1   -x4y4'  -y4y4' These eight equations are solved here for the coefficients C. These eight coefficients can then be used to find the mapping x,y) to (x',y': x' = c[0]x + c[1]y + c[2]) / (c[6]x + c[7]y + 1 y' = c[3]x + c[4]y + c[5]) / (c[6]x + c[7]y + 1 that is implemented in projectiveXformSampled and projectiveXFormInterpolated.</returns>
Public Shared Function getProjectiveXformCoeffs(
				 ByVal ptas as Pta, 
				 ByVal ptad as Pta, 
				<Out()> ByRef pvc as List(Of Single())) as Integer

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")

Dim pvcPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.getProjectiveXformCoeffs( ptas.Pointer, ptad.Pointer, pvcPTR)

	Return _Result
End Function

' SRC\projective.c (876, 1)
' projectiveXformSampledPt(vc, x, y, pxp, pyp) as Integer
' projectiveXformSampledPt(l_float32 *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This finds the nearest pixel coordinates of the transformed point.<para/>
''' 
''' (2) It does not check ptrs for returned data!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/projectiveXformSampledPt/*"/>
'''  <param name="vc">[in] - vector of 8 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function projectiveXformSampledPt(
				 ByVal vc as Single(), 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pxp as Integer, 
				<Out()> ByRef pyp as Integer) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.projectiveXformSampledPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

' SRC\projective.c (911, 1)
' projectiveXformPt(vc, x, y, pxp, pyp) as Integer
' projectiveXformPt(l_float32 *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This computes the floating point location of the transformed point.<para/>
''' 
''' (2) It does not check ptrs for returned data!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/projectiveXformPt/*"/>
'''  <param name="vc">[in] - vector of 8 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function projectiveXformPt(
				 ByVal vc as Single(), 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pxp as Single, 
				<Out()> ByRef pyp as Single) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.projectiveXformPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

End Class
