Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\shear.c (113, 1)
' pixHShear()
' pixHShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) There are 3 cases
''' (a) pixd == null (make a new pixd)
''' (b) pixd == pixs (in-place)
''' (c) pixd != pixs
''' (2) For these three cases, use these patterns, respectively
''' pixd = pixHShear(NULL, pixs, ...);
''' pixHShear(pixs, pixs, ...);
''' pixHShear(pixd, pixs, ...);
''' (3) This shear leaves the horizontal line of pixels at y = yloc
''' invariant.  For a positive shear angle, pixels above this
''' line are shoved to the right, and pixels below this line
''' move to the left.
''' (4) With positive shear angle, this can be used, along with
''' pixVShear(), to perform a cw rotation, either with 2 shears
''' (for small angles) or in the general case with 3 shears.
''' (5) Changing the value of yloc is equivalent to translating
''' the result horizontally.
''' (6) This brings in 'incolor' pixels from outside the image.
''' (7) For in-place operation, pixs cannot be colormapped,
''' because the in-place operation only blits in 0 or 1 bits,
''' not an arbitrary colormap index.
''' (8) The angle is brought into the range [-pi, -pi].  It is
''' not permitted to be within MIN_DIFF_FROM_HALF_PI radians
''' from either -pi/2 or pi/2.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - no restrictions on depth</param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, always</returns>
Public Shared Function pixHShear(
				ByVal pixs as Pix, 
				ByVal yloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShear( pixdPTR, pixs.Pointer, yloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (230, 1)
' pixVShear()
' pixVShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) There are 3 cases
''' (a) pixd == null (make a new pixd)
''' (b) pixd == pixs (in-place)
''' (c) pixd != pixs
''' (2) For these three cases, use these patterns, respectively
''' pixd = pixVShear(NULL, pixs, ...);
''' pixVShear(pixs, pixs, ...);
''' pixVShear(pixd, pixs, ...);
''' (3) This shear leaves the vertical line of pixels at x = xloc
''' invariant.  For a positive shear angle, pixels to the right
''' of this line are shoved downward, and pixels to the left
''' of the line move upward.
''' (4) With positive shear angle, this can be used, along with
''' pixHShear(), to perform a cw rotation, either with 2 shears
''' (for small angles) or in the general case with 3 shears.
''' (5) Changing the value of xloc is equivalent to translating
''' the result vertically.
''' (6) This brings in 'incolor' pixels from outside the image.
''' (7) For in-place operation, pixs cannot be colormapped,
''' because the in-place operation only blits in 0 or 1 bits,
''' not an arbitrary colormap index.
''' (8) The angle is brought into the range [-pi, -pi].  It is
''' not permitted to be within MIN_DIFF_FROM_HALF_PI radians
''' from either -pi/2 or pi/2.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - no restrictions on depth</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians; not too close to +-(pi / 2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixVShear(
				ByVal pixs as Pix, 
				ByVal xloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShear( pixdPTR, pixs.Pointer, xloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (328, 1)
' pixHShearCorner()
' pixHShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixHShear() for usage.
''' (2) This does a horizontal shear about the UL corner, with (+) shear
''' pushing increasingly leftward (-x) with increasing y.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixHShearCorner(
				ByVal pixs as Pix, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearCorner( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (359, 1)
' pixVShearCorner()
' pixVShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixVShear() for usage.
''' (2) This does a vertical shear about the UL corner, with (+) shear
''' pushing increasingly downward (+y) with increasing x.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixVShearCorner(
				ByVal pixs as Pix, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearCorner( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (390, 1)
' pixHShearCenter()
' pixHShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixHShear() for usage.
''' (2) This does a horizontal shear about the center, with (+) shear
''' pushing increasingly leftward (-x) with increasing y.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixHShearCenter(
				ByVal pixs as Pix, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearCenter( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (421, 1)
' pixVShearCenter()
' pixVShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixVShear() for usage.
''' (2) This does a vertical shear about the center, with (+) shear
''' pushing increasingly downward (+y) with increasing x.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixVShearCenter(
				ByVal pixs as Pix, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearCenter( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (459, 1)
' pixHShearIP()
' pixHShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place version of pixHShear(); see comments there.
''' (2) This brings in 'incolor' pixels from outside the image.
''' (3) pixs cannot be colormapped, because the in-place operation
''' only blits in 0 or 1 bits, not an arbitrary colormap index.
''' (4) Does a horizontal full-band shear about the line with (+) shear
''' pushing increasingly leftward (-x) with increasing y.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixHShearIP(
				ByVal pixs as Pix, 
				ByVal yloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixHShearIP( pixs.Pointer, yloc, radang, incolor)

	Return _Result
End Function

' SRC\shear.c (534, 1)
' pixVShearIP()
' pixVShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place version of pixVShear(); see comments there.
''' (2) This brings in 'incolor' pixels from outside the image.
''' (3) pixs cannot be colormapped, because the in-place operation
''' only blits in 0 or 1 bits, not an arbitrary colormap index.
''' (4) Does a vertical full-band shear about the line with (+) shear
''' pushing increasingly downward (+y) with increasing x.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths; not colormapped</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixVShearIP(
				ByVal pixs as Pix, 
				ByVal xloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixVShearIP( pixs.Pointer, xloc, radang, incolor)

	Return _Result
End Function

' SRC\shear.c (617, 1)
' pixHShearLI()
' pixHShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does horizontal shear with linear interpolation for
''' accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.
''' It is relatively slow compared to the sampled version
''' implemented by rasterop, but the result is much smoother.
''' (2) This shear leaves the horizontal line of pixels at y = yloc
''' invariant.  For a positive shear angle, pixels above this
''' line are shoved to the right, and pixels below this line
''' move to the left.
''' (3) Any colormap is removed.
''' (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],
''' where del == MIN_DIFF_FROM_HALF_PI.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd sheared, or NULL on error</returns>
Public Shared Function pixHShearLI(
				ByVal pixs as Pix, 
				ByVal yloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearLI( pixs.Pointer, yloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (729, 1)
' pixVShearLI()
' pixVShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does vertical shear with linear interpolation for
''' accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.
''' It is relatively slow compared to the sampled version
''' implemented by rasterop, but the result is much smoother.
''' (2) This shear leaves the vertical line of pixels at x = xloc
''' invariant.  For a positive shear angle, pixels to the right
''' of this line are shoved downward, and pixels to the left
''' of the line move upward.
''' (3) Any colormap is removed.
''' (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],
''' where del == MIN_DIFF_FROM_HALF_PI.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd sheared, or NULL on error</returns>
Public Shared Function pixVShearLI(
				ByVal pixs as Pix, 
				ByVal xloc as Integer, 
				ByVal radang as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearLI( pixs.Pointer, xloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
