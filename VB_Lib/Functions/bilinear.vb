Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\bilinear.c (143, 1)
' pixBilinearSampledPta(pixs, ptad, ptas, incolor) as Pix
' pixBilinearSampledPta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Brings in either black or white pixels from the boundary.<para/>
''' (2) Retains colormap, which you can do for a sampled transform..<para/>
''' (3) No 3 of the 4 points may be collinear.<para/>
''' (4) For 8 and 32 bpp pix, better quality is obtained by the<para/>
''' somewhat slower pixBilinearPta().  See that<para/>
''' function for relative timings between sampled and interpolated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearSampledPta(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearSampledPta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (193, 1)
' pixBilinearSampled(pixs, vc, incolor) as Pix
' pixBilinearSampled(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Brings in either black or white pixels from the boundary.<para/>
''' (2) Retains colormap, which you can do for a sampled transform..<para/>
''' (3) For 8 or 32 bpp, much better quality is obtained by the<para/>
''' somewhat slower pixBilinear().  See that function<para/>
''' for relative timings between sampled and interpolated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearSampled(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearSampled( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (286, 1)
' pixBilinearPta(pixs, ptad, ptas, incolor) as Pix
' pixBilinearPta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Brings in either black or white pixels from the boundary<para/>
''' (2) Removes any existing colormap, if necessary, before transforming<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths colormap ok</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearPta(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearPta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (356, 1)
' pixBilinear(pixs, vc, incolor) as Pix
' pixBilinear(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Brings in either black or white pixels from the boundary<para/>
''' (2) Removes any existing colormap, if necessary, before transforming<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths colormap ok</param>
'''  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinear(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinear( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (412, 1)
' pixBilinearPtaColor(pixs, ptad, ptas, colorval) as Pix
' pixBilinearPtaColor(PIX *, PTA *, PTA *, l_uint32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearPtaColor(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearPtaColor( pixs.Pointer, ptad.Pointer, ptas.Pointer, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (453, 1)
' pixBilinearColor(pixs, vc, colorval) as Pix
' pixBilinearColor(PIX *, l_float32 *, l_uint32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearColor(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearColor( pixs.Pointer, vc, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (515, 1)
' pixBilinearPtaGray(pixs, ptad, ptas, grayval) as Pix
' pixBilinearPtaGray(PIX *, PTA *, PTA *, l_uint8) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearPtaGray(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearPtaGray( pixs.Pointer, ptad.Pointer, ptas.Pointer, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (556, 1)
' pixBilinearGray(pixs, vc, grayval) as Pix
' pixBilinearGray(PIX *, l_float32 *, l_uint8) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearGray(
				 ByVal pixs as Pix, 
				 ByVal vc as Single(), 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearGray( pixs.Pointer, vc, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (644, 1)
' pixBilinearPtaWithAlpha(pixs, ptad, ptas, pixg, fract, border) as Pix
' pixBilinearPtaWithAlpha(PIX *, PTA *, PTA *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The alpha channel is transformed separately from pixs,<para/>
''' and aligns with it, being fully transparent outside the<para/>
''' boundary of the transformed pixs.  For pixels that are fully<para/>
''' transparent, a blending function like pixBlendWithGrayMask()<para/>
''' will give zero weight to corresponding pixels in pixs.<para/>
''' (2) If pixg is NULL, it is generated as an alpha layer that is<para/>
''' partially opaque, using %fract.  Otherwise, it is cropped<para/>
''' to pixs if required and %fract is ignored.  The alpha channel<para/>
''' in pixs is never used.<para/>
''' (3) Colormaps are removed.<para/>
''' (4) When pixs is transformed, it doesn't matter what color is brought<para/>
''' in because the alpha channel will be transparent (0) there.<para/>
''' (5) To avoid losing source pixels in the destination, it may be<para/>
''' necessary to add a border to the source pix before doing<para/>
''' the bilinear transformation.  This can be any non-negative number.<para/>
''' (6) The input %ptad and %ptas are in a coordinate space before<para/>
''' the border is added.  Internally, we compensate for this<para/>
''' before doing the bilinear transform on the image after<para/>
''' the border is added.<para/>
''' (7) The default setting for the border values in the alpha channel<para/>
''' is 0 (transparent) for the outermost ring of pixels and<para/>
''' (0.5  fract  255) for the second ring.  When blended over<para/>
''' a second image, this<para/>
''' (a) shrinks the visible image to make a clean overlap edge<para/>
''' with an image below, and<para/>
''' (b) softens the edges by weakening the aliasing there.<para/>
''' Use l_setAlphaMaskBorder() to change these values.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ptad">[in] - 4 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
'''  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
'''  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
'''  <param name="border">[in] - of pixels added to capture transformed source pixels</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixBilinearPtaWithAlpha(
				 ByVal pixs as Pix, 
				 ByVal ptad as Pta, 
				 ByVal ptas as Pta, 
				 ByVal pixg as Pix, 
				 ByVal fract as Single, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilinearPtaWithAlpha( pixs.Pointer, ptad.Pointer, ptas.Pointer, pixgPTR, fract, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilinear.c (776, 1)
' getBilinearXformCoeffs(ptas, ptad, pvc) as Integer
' getBilinearXformCoeffs(PTA *, PTA *, l_float32 **) as l_ok
'''  <summary>
''' <para/>
''' We have a set of 8 equations, describing the bilinear<para/>
''' transformation that takes 4 points ptas into 4 other<para/>
''' points ptad.  These equations are:<para/>
''' x1' = c[0]x1 + c[1]y1 + c[2]x1y1 + c[3]<para/>
''' y1' = c[4]x1 + c[5]y1 + c[6]x1y1 + c[7]<para/>
''' x2' = c[0]x2 + c[1]y2 + c[2]x2y2 + c[3]<para/>
''' y2' = c[4]x2 + c[5]y2 + c[6]x2y2 + c[7]<para/>
''' x3' = c[0]x3 + c[1]y3 + c[2]x3y3 + c[3]<para/>
''' y3' = c[4]x3 + c[5]y3 + c[6]x3y3 + c[7]<para/>
''' x4' = c[0]x4 + c[1]y4 + c[2]x4y4 + c[3]<para/>
''' y4' = c[4]x4 + c[5]y4 + c[6]x4y4 + c[7]<para/>
''' This can be represented as<para/>
''' AC = B<para/>
''' where B and C are column vectors<para/>
''' B = [ x1' y1' x2' y2' x3' y3' x4' y4' ]<para/>
''' C = [ c[0] c[1] c[2] c[3] c[4] c[5] c[6] c[7] ]<para/>
''' and A is the 8x8 matrix<para/>
''' x1 y1 x1y1 1 0  0  0 0<para/>
''' 0  0 0 0 x1 y1 x1y1 1<para/>
''' x2 y2 x2y2 1 0  0  0 0<para/>
''' 0  0 0 0 x2 y2 x2y2 1<para/>
''' x3 y3 x3y3 1 0  0  0 0<para/>
''' 0  0 0 0 x3 y3 x3y3 1<para/>
''' x4 y4 x4y4 1 0  0  0 0<para/>
''' 0  0 0 0 x4 y4 x4y4 1<para/>
''' These eight equations are solved here for the coefficients C.<para/>
''' These eight coefficients can then be used to find the mapping<para/>
''' x,y) -- is greater  (x',y':<para/>
''' x' = c[0]x + c[1]y + c[2]xy + c[3]<para/>
''' y' = c[4]x + c[5]y + c[6]xy + c[7]<para/>
''' that are implemented in bilinearXformSampledPt and<para/>
''' bilinearXFormPt.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - source 4 points unprimed</param>
'''  <param name="ptad">[in] - transformed 4 points primed</param>
'''  <param name="pvc">[out] - vector of coefficients of transform</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function getBilinearXformCoeffs(
				 ByVal ptas as Pta, 
				 ByVal ptad as Pta, 
				<Out()> ByRef pvc as List(Of Single())) as Integer

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")

Dim pvcPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.getBilinearXformCoeffs( ptas.Pointer, ptad.Pointer, pvcPTR)

	Return _Result
End Function

' SRC\bilinear.c (869, 1)
' bilinearXformSampledPt(vc, x, y, pxp, pyp) as Integer
' bilinearXformSampledPt(l_float32 *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the nearest pixel coordinates of the transformed point.<para/>
''' (2) It does not check ptrs for returned data!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="vc">[in] - vector of 8 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function bilinearXformSampledPt(
				 ByVal vc as Single(), 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pxp as Integer, 
				<Out()> ByRef pyp as Integer) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.bilinearXformSampledPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

' SRC\bilinear.c (902, 1)
' bilinearXformPt(vc, x, y, pxp, pyp) as Integer
' bilinearXformPt(l_float32 *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This computes the floating point location of the transformed point.<para/>
''' (2) It does not check ptrs for returned data!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="vc">[in] - vector of 8 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function bilinearXformPt(
				 ByVal vc as Single(), 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pxp as Single(), 
				<Out()> ByRef pyp as Single()) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.bilinearXformPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

End Class
