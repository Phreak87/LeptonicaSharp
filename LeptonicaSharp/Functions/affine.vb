Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\affine.c (280, 1)
' pixAffineSampledPta()
' pixAffineSampledPta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Brings in either black or white pixels from the boundary.
''' (2) Retains colormap, which you can do for a sampled transform..
''' (3) The 3 points must not be collinear.
''' (4) The order of the 3 points is arbitrary; however, to compare
''' with the sequential transform they must be in these locations
''' and in this order origin, x-axis, y-axis.
''' (5) For 1 bpp images, this has much better quality results
''' than pixAffineSequential(), particularly for text.
''' It is about 3x slower, but does not require additional
''' border pixels.  The poor quality of pixAffineSequential()
''' is due to repeated quantized transforms.  It is strongly
''' recommended that pixAffineSampled() be used for 1 bpp images.
''' (6) For 8 or 32 bpp, much better quality is obtained by the
''' somewhat slower pixAffinePta().  See that function
''' for relative timings between sampled and interpolated.
''' (7) To repeat, use of the sequential transform,
''' pixAffineSequential(), for any images, is discouraged.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffineSampledPta(
				ByVal pixs as Pix, 
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffineSampledPta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (330, 1)
' pixAffineSampled()
' pixAffineSampled(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Brings in either black or white pixels from the boundary.
''' (2) Retains colormap, which you can do for a sampled transform..
''' (3) For 8 or 32 bpp, much better quality is obtained by the
''' somewhat slower pixAffine().  See that function
''' for relative timings between sampled and interpolated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="vc">[in] - vector of 6 coefficients for affine transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffineSampled(
				ByVal pixs as Pix, 
				ByVal vc as Single(), 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffineSampled( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (423, 1)
' pixAffinePta()
' pixAffinePta(PIX *, PTA *, PTA *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Brings in either black or white pixels from the boundary
''' (2) Removes any existing colormap, if necessary, before transforming
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths; colormap ok</param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffinePta(
				ByVal pixs as Pix, 
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffinePta( pixs.Pointer, ptad.Pointer, ptas.Pointer, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (493, 1)
' pixAffine()
' pixAffine(PIX *, l_float32 *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Brings in either black or white pixels from the boundary
''' (2) Removes any existing colormap, if necessary, before transforming
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths; colormap ok</param>
'''  <param name="vc">[in] - vector of 6 coefficients for affine transformation</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffine(
				ByVal pixs as Pix, 
				ByVal vc as Single(), 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffine( pixs.Pointer, vc, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (549, 1)
' pixAffinePtaColor()
' pixAffinePtaColor(PIX *, PTA *, PTA *, l_uint32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffinePtaColor(
				ByVal pixs as Pix, 
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffinePtaColor( pixs.Pointer, ptad.Pointer, ptas.Pointer, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (590, 1)
' pixAffineColor()
' pixAffineColor(PIX *, l_float32 *, l_uint32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="vc">[in] - vector of 6 coefficients for affine transformation</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffineColor(
				ByVal pixs as Pix, 
				ByVal vc as Single(), 
				ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffineColor( pixs.Pointer, vc, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (652, 1)
' pixAffinePtaGray()
' pixAffinePtaGray(PIX *, PTA *, PTA *, l_uint8) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffinePtaGray(
				ByVal pixs as Pix, 
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffinePtaGray( pixs.Pointer, ptad.Pointer, ptas.Pointer, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (694, 1)
' pixAffineGray()
' pixAffineGray(PIX *, l_float32 *, l_uint8) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="vc">[in] - vector of 6 coefficients for affine transformation</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffineGray(
				ByVal pixs as Pix, 
				ByVal vc as Single(), 
				ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffineGray( pixs.Pointer, vc, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (782, 1)
' pixAffinePtaWithAlpha()
' pixAffinePtaWithAlpha(PIX *, PTA *, PTA *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The alpha channel is transformed separately from pixs,
''' and aligns with it, being fully transparent outside the
''' boundary of the transformed pixs.  For pixels that are fully
''' transparent, a blending function like pixBlendWithGrayMask()
''' will give zero weight to corresponding pixels in pixs.
''' (2) If pixg is NULL, it is generated as an alpha layer that is
''' partially opaque, using %fract.  Otherwise, it is cropped
''' to pixs if required and %fract is ignored.  The alpha channel
''' in pixs is never used.
''' (3) Colormaps are removed.
''' (4) When pixs is transformed, it doesn't matter what color is brought
''' in because the alpha channel will be transparent (0) there.
''' (5) To avoid losing source pixels in the destination, it may be
''' necessary to add a border to the source pix before doing
''' the affine transformation.  This can be any non-negative number.
''' (6) The input %ptad and %ptas are in a coordinate space before
''' the border is added.  Internally, we compensate for this
''' before doing the affine transform on the image after the border
''' is added.
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
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
'''  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
'''  <param name="border">[in] - of pixels added to capture transformed source pixels</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffinePtaWithAlpha(
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
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffinePtaWithAlpha( pixs.Pointer, ptad.Pointer, ptas.Pointer, pixgPTR, fract, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\affine.c (931, 1)
' getAffineXformCoeffs()
' getAffineXformCoeffs(PTA *, PTA *, l_float32 **) as l_ok
'''  <summary>
''' We have a set of six equations, describing the affine
''' transformation that takes 3 points ptas into 3 other
''' points ptad.  These equations are
''' x1' = c[0]x1 + c[1]y1 + c[2]
''' y1' = c[3]x1 + c[4]y1 + c[5]
''' x2' = c[0]x2 + c[1]y2 + c[2]
''' y2' = c[3]x2 + c[4]y2 + c[5]
''' x3' = c[0]x3 + c[1]y3 + c[2]
''' y3' = c[3]x3 + c[4]y3 + c[5]
''' This can be represented as
''' AC = B
''' where B and C are column vectors
''' B = [ x1' y1' x2' y2' x3' y3' ]
''' C = [ c[0] c[1] c[2] c[3] c[4] c[5] c[6] ]
''' and A is the 6x6 matrix
''' x1   y1   1   0 0 0
''' 0 0   0   x1   y1   1
''' x2   y2   1   0 0 0
''' 0 0   0   x2   y2   1
''' x3   y3   1   0 0 0
''' 0 0   0   x3   y3   1
''' These six equations are solved here for the coefficients C.
''' These six coefficients can then be used to find the dest
''' point x',y') corresponding to any src point (x,y, according
''' to the equations
''' x' = c[0]x + c[1]y + c[2]
''' y' = c[3]x + c[4]y + c[5]
''' that are implemented in affineXformPt.
''' !!!!!!!!!!!!!!!!!!   Very important   !!!!!!!!!!!!!!!!!!!!!!
''' When the affine transform is composed from a set of simple
''' operations such as translation, scaling and rotation,
''' it is built in a form to convert from the un-transformed src
''' point to the transformed dest point.  However, when an
''' affine transform is used on images, it is used in an inverted
''' way it converts from the transformed dest point to the
''' un-transformed src point.  So, for example, if you transform
''' a boxa using transform A, to transform an image in the same
''' way you must use the inverse of A.
''' For example, if you transform a boxa with a 3x3 affine matrix
''' 'mat', the analogous image transformation must use 'matinv'
''' \code
''' boxad = boxaAffineTransform(boxas, mat);
''' affineInvertXform(mat, matinv);
''' pixd = pixAffine(pixs, matinv, L_BRING_IN_WHITE);
''' \endcode
''' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - source 3 points; unprimed</param>
'''  <param name="ptad">[in] - transformed 3 points; primed</param>
'''  <param name="pvc">[out] - vector of coefficients of transform</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function getAffineXformCoeffs(
				ByVal ptas as Pta, 
				ByVal ptad as Pta, 
				ByRef pvc as List(Of Single())) as Integer

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")

Dim pvcPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.getAffineXformCoeffs( ptas.Pointer, ptad.Pointer, pvcPTR)

	Return _Result
End Function

' SRC\affine.c (1024, 1)
' affineInvertXform()
' affineInvertXform(l_float32 *, l_float32 **) as l_ok
'''  <summary>
''' Notes
''' (1) The 6 affine transform coefficients are the first
''' two rows of a 3x3 matrix where the last row has
''' only a 1 in the third column.  We invert this
''' using gaussjordan(), and select the first 2 rows
''' as the coefficients of the inverse affine transform.
''' (2) Alternatively, we can find the inverse transform
''' coefficients by inverting the 2x2 submatrix,
''' and treating the top 2 coefficients in the 3rd column as
''' a RHS vector for that 2x2 submatrix.  Then the
''' 6 inverted transform coefficients are composed of
''' the inverted 2x2 submatrix and the negative of the
''' transformed RHS vector.  Why is this so?  We have
''' Y = AX + R  (2 equations in 6 unknowns)
''' Then
''' X = A'Y - A'R
''' Gauss-jordan solves
''' AF = R
''' and puts the solution for F, which is A'R,
''' into the input R vector.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="vc">[in] - vector of 6 coefficients</param>
'''  <param name="pvci">[out] - inverted transform</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function affineInvertXform(
				ByVal vc as Single(), 
				ByRef pvci as List(Of Single())) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")

Dim pvciPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.affineInvertXform( vc, pvciPTR)

	Return _Result
End Function

' SRC\affine.c (1107, 1)
' affineXformSampledPt()
' affineXformSampledPt(l_float32 *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This finds the nearest pixel coordinates of the transformed point.
''' (2) It does not check ptrs for returned data!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="vc">[in] - vector of 6 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function affineXformSampledPt(
				ByVal vc as Single(), 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByRef pxp as Integer, 
				ByRef pyp as Integer) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.affineXformSampledPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

' SRC\affine.c (1139, 1)
' affineXformPt()
' affineXformPt(l_float32 *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This computes the floating point location of the transformed point.
''' (2) It does not check ptrs for returned data!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="vc">[in] - vector of 6 coefficients</param>
'''  <param name="x">[in] - initial point</param>
'''  <param name="y">[in] - initial point</param>
'''  <param name="pxp">[out] - transformed point</param>
'''  <param name="pyp">[out] - transformed point</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function affineXformPt(
				ByVal vc as Single(), 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByRef pxp as Single(), 
				ByRef pyp as Single()) as Integer

	If IsNothing (vc) then Throw New ArgumentNullException  ("vc cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.affineXformPt( vc, x, y, pxp, pyp)

	Return _Result
End Function

' SRC\affine.c (1180, 1)
' linearInterpolatePixelColor()
' linearInterpolatePixelColor(l_uint32 *, l_int32, l_int32, l_int32, l_float32, l_float32, l_uint32, l_uint32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a standard linear interpolation function.  It is
''' equivalent to area weighting on each component, and
''' avoids "jaggies" when rendering sharp edges.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="datas">[in] - ptr to beginning of image data</param>
'''  <param name="wpls">[in] - 32-bit word/line for this data array</param>
'''  <param name="w">[in] - of image</param>
'''  <param name="h">[in] - of image</param>
'''  <param name="x">[in] - floating pt location for evaluation</param>
'''  <param name="y">[in] - floating pt location for evaluation</param>
'''  <param name="colorval">[in] - color brought in from the outside when the input x,y location is outside the image; in 0xrrggbb00 format)</param>
'''  <param name="pval">[out] - interpolated color value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function linearInterpolatePixelColor(
				ByVal datas as Byte(), 
				ByVal wpls as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal x as Single, 
				ByVal y as Single, 
				ByVal colorval as UInteger, 
				ByRef pval as UInteger) as Integer

	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")
	If IsNothing (y) then Throw New ArgumentNullException  ("y cannot be Nothing")

	Dim datasPTR As IntPtr = Marshal.AllocHGlobal(datas.Count) : Marshal.Copy(datas, 0, datasPTR, datas.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.linearInterpolatePixelColor( datasPTR, wpls, w, h, x, y, colorval, pval)

	Return _Result
End Function

' SRC\affine.c (1267, 1)
' linearInterpolatePixelGray()
' linearInterpolatePixelGray(l_uint32 *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a standard linear interpolation function.  It is
''' equivalent to area weighting on each component, and
''' avoids "jaggies" when rendering sharp edges.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="datas">[in] - ptr to beginning of image data</param>
'''  <param name="wpls">[in] - 32-bit word/line for this data array</param>
'''  <param name="w">[in] - of image</param>
'''  <param name="h">[in] - of image</param>
'''  <param name="x">[in] - floating pt location for evaluation</param>
'''  <param name="y">[in] - floating pt location for evaluation</param>
'''  <param name="grayval">[in] - color brought in from the outside when the input x,y location is outside the image</param>
'''  <param name="pval">[out] - interpolated gray value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function linearInterpolatePixelGray(
				ByVal datas as Byte(), 
				ByVal wpls as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal x as Single, 
				ByVal y as Single, 
				ByVal grayval as Integer, 
				ByRef pval as Integer) as Integer

	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")
	If IsNothing (x) then Throw New ArgumentNullException  ("x cannot be Nothing")
	If IsNothing (y) then Throw New ArgumentNullException  ("y cannot be Nothing")

	Dim datasPTR As IntPtr = Marshal.AllocHGlobal(datas.Count) : Marshal.Copy(datas, 0, datasPTR, datas.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.linearInterpolatePixelGray( datasPTR, wpls, w, h, x, y, grayval, pval)

	Return _Result
End Function

' SRC\affine.c (1346, 1)
' gaussjordan()
' gaussjordan(l_float32 **, l_float32 *, l_int32) as l_int32
'''  <summary>
''' Notes
''' (1) There are two side-effects
''' The matrix a is transformed to its inverse A
''' The rhs vector b is transformed to the solution x
''' of the linear equation ax = b
''' (2) The inverse A can then be used to solve the same equation with
''' different rhs vectors c by multiplication x = Ac
''' (3) Adapted from "Numerical Recipes in C, Second Edition", 1992,
''' pp. 36-41 (gauss-jordan elimination)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="a">[in] - n x n matrix</param>
'''  <param name="b">[in] - n x 1 right-hand side column vector</param>
'''  <param name="n">[in] - dimension</param>
'''   <returns>0 if ok, 1 on error</returns>
Public Shared Function gaussjordan(
				ByVal a as List(Of Single()), 
				ByVal b as Single(), 
				ByVal n as Integer) as Integer

	If IsNothing (a) then Throw New ArgumentNullException  ("a cannot be Nothing")
	If IsNothing (b) then Throw New ArgumentNullException  ("b cannot be Nothing")

Dim aPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.gaussjordan( aPTR, b, n)

	Return _Result
End Function

' SRC\affine.c (1470, 1)
' pixAffineSequential()
' pixAffineSequential(PIX *, PTA *, PTA *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The 3 pts must not be collinear.
''' (2) The 3 pts must be given in this order
''' ~ origin
''' ~ a location along the x-axis
''' ~ a location along the y-axis.
''' (3) You must guess how much border must be added so that no
''' pixels are lost in the transformations from src to
''' dest coordinate space.  (This can be calculated but it
''' is a lot of work!)  For coordinate spaces that are nearly
''' at right angles, on a 300 ppi scanned page, the addition
''' of 1000 pixels on each side is usually sufficient.
''' (4) This is here for pedagogical reasons.  It is about 3x faster
''' on 1 bpp images than pixAffineSampled(), but the results
''' on text are much inferior.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="ptad">[in] - 3 pts of final coordinate space</param>
'''  <param name="ptas">[in] - 3 pts of initial coordinate space</param>
'''  <param name="bw">[in] - pixels of additional border width during computation</param>
'''  <param name="bh">[in] - pixels of additional border height during computation</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAffineSequential(
				ByVal pixs as Pix, 
				ByVal ptad as Pta, 
				ByVal ptas as Pta, 
				ByVal bw as Integer, 
				ByVal bh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ptad) then Throw New ArgumentNullException  ("ptad cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAffineSequential( pixs.Pointer, ptad.Pointer, ptas.Pointer, bw, bh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
