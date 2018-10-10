Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\shear.c (113, 1)
' pixHShear(pixd, pixs, yloc, radang, incolor) as Pix
' pixHShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) There are 3 cases:<para/>
''' (a) pixd == null (make a new pixd)<para/>
''' (b) pixd == pixs (in-place)<para/>
''' (c) pixd != pixs<para/>
''' (2) For these three cases, use these patterns, respectively:<para/>
''' pixd = pixHShear(NULL, pixs, ...)<para/>
''' pixHShear(pixs, pixs, ...)<para/>
''' pixHShear(pixd, pixs, ...)<para/>
''' (3) This shear leaves the horizontal line of pixels at y = yloc<para/>
''' invariant.  For a positive shear angle, pixels above this<para/>
''' line are shoved to the right, and pixels below this line<para/>
''' move to the left.<para/>
''' (4) With positive shear angle, this can be used, along with<para/>
''' pixVShear(), to perform a cw rotation, either with 2 shears<para/>
''' (for small angles) or in the general case with 3 shears.<para/>
''' (5) Changing the value of yloc is equivalent to translating<para/>
''' the result horizontally.<para/>
''' (6) This brings in 'incolor' pixels from outside the image.<para/>
''' (7) For in-place operation, pixs cannot be colormapped,<para/>
''' because the in-place operation only blits in 0 or 1 bits,<para/>
''' not an arbitrary colormap index.<para/>
''' (8) The angle is brought into the range [-pi, -pi].  It is<para/>
''' not permitted to be within MIN_DIFF_FROM_HALF_PI radians<para/>
''' from either -pi/2 or pi/2.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - no restrictions on depth</param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, always</returns>
Public Shared Function pixHShear(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal yloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShear( pixdPTR, pixs.Pointer, yloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (230, 1)
' pixVShear(pixd, pixs, xloc, radang, incolor) as Pix
' pixVShear(PIX *, PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) There are 3 cases:<para/>
''' (a) pixd == null (make a new pixd)<para/>
''' (b) pixd == pixs (in-place)<para/>
''' (c) pixd != pixs<para/>
''' (2) For these three cases, use these patterns, respectively:<para/>
''' pixd = pixVShear(NULL, pixs, ...)<para/>
''' pixVShear(pixs, pixs, ...)<para/>
''' pixVShear(pixd, pixs, ...)<para/>
''' (3) This shear leaves the vertical line of pixels at x = xloc<para/>
''' invariant.  For a positive shear angle, pixels to the right<para/>
''' of this line are shoved downward, and pixels to the left<para/>
''' of the line move upward.<para/>
''' (4) With positive shear angle, this can be used, along with<para/>
''' pixHShear(), to perform a cw rotation, either with 2 shears<para/>
''' (for small angles) or in the general case with 3 shears.<para/>
''' (5) Changing the value of xloc is equivalent to translating<para/>
''' the result vertically.<para/>
''' (6) This brings in 'incolor' pixels from outside the image.<para/>
''' (7) For in-place operation, pixs cannot be colormapped,<para/>
''' because the in-place operation only blits in 0 or 1 bits,<para/>
''' not an arbitrary colormap index.<para/>
''' (8) The angle is brought into the range [-pi, -pi].  It is<para/>
''' not permitted to be within MIN_DIFF_FROM_HALF_PI radians<para/>
''' from either -pi/2 or pi/2.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - no restrictions on depth</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians not too close to +-(pi / 2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixVShear(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal xloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShear( pixdPTR, pixs.Pointer, xloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (328, 1)
' pixHShearCorner(pixd, pixs, radang, incolor) as Pix
' pixHShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixHShear() for usage.<para/>
''' (2) This does a horizontal shear about the UL corner, with (+) shear<para/>
''' pushing increasingly leftward (-x) with increasing y.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixHShearCorner(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearCorner( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (359, 1)
' pixVShearCorner(pixd, pixs, radang, incolor) as Pix
' pixVShearCorner(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixVShear() for usage.<para/>
''' (2) This does a vertical shear about the UL corner, with (+) shear<para/>
''' pushing increasingly downward (+y) with increasing x.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixVShearCorner(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearCorner( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (390, 1)
' pixHShearCenter(pixd, pixs, radang, incolor) as Pix
' pixHShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixHShear() for usage.<para/>
''' (2) This does a horizontal shear about the center, with (+) shear<para/>
''' pushing increasingly leftward (-x) with increasing y.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixHShearCenter(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearCenter( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (421, 1)
' pixVShearCenter(pixd, pixs, radang, incolor) as Pix
' pixVShearCenter(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixVShear() for usage.<para/>
''' (2) This does a vertical shear about the center, with (+) shear<para/>
''' pushing increasingly downward (+y) with increasing x.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - , if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixVShearCenter(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearCenter( pixdPTR, pixs.Pointer, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (459, 1)
' pixHShearIP(pixs, yloc, radang, incolor) as Integer
' pixHShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place version of pixHShear() see comments there.<para/>
''' (2) This brings in 'incolor' pixels from outside the image.<para/>
''' (3) pixs cannot be colormapped, because the in-place operation<para/>
''' only blits in 0 or 1 bits, not an arbitrary colormap index.<para/>
''' (4) Does a horizontal full-band shear about the line with (+) shear<para/>
''' pushing increasingly leftward (-x) with increasing y.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixHShearIP(
				 ByVal pixs as Pix, 
				 ByVal yloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixHShearIP( pixs.Pointer, yloc, radang, incolor)

	Return _Result
End Function

' SRC\shear.c (534, 1)
' pixVShearIP(pixs, xloc, radang, incolor) as Integer
' pixVShearIP(PIX *, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place version of pixVShear() see comments there.<para/>
''' (2) This brings in 'incolor' pixels from outside the image.<para/>
''' (3) pixs cannot be colormapped, because the in-place operation<para/>
''' only blits in 0 or 1 bits, not an arbitrary colormap index.<para/>
''' (4) Does a vertical full-band shear about the line with (+) shear<para/>
''' pushing increasingly downward (+y) with increasing x.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths not colormapped</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixVShearIP(
				 ByVal pixs as Pix, 
				 ByVal xloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixVShearIP( pixs.Pointer, xloc, radang, incolor)

	Return _Result
End Function

' SRC\shear.c (617, 1)
' pixHShearLI(pixs, yloc, radang, incolor) as Pix
' pixHShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does horizontal shear with linear interpolation for<para/>
''' accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.<para/>
''' It is relatively slow compared to the sampled version<para/>
''' implemented by rasterop, but the result is much smoother.<para/>
''' (2) This shear leaves the horizontal line of pixels at y = yloc<para/>
''' invariant.  For a positive shear angle, pixels above this<para/>
''' line are shoved to the right, and pixels below this line<para/>
''' move to the left.<para/>
''' (3) Any colormap is removed.<para/>
''' (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],<para/>
''' where del == MIN_DIFF_FROM_HALF_PI.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
'''  <param name="yloc">[in] - location of horizontal line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd sheared, or NULL on error</returns>
Public Shared Function pixHShearLI(
				 ByVal pixs as Pix, 
				 ByVal yloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHShearLI( pixs.Pointer, yloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\shear.c (729, 1)
' pixVShearLI(pixs, xloc, radang, incolor) as Pix
' pixVShearLI(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does vertical shear with linear interpolation for<para/>
''' accurate results on 8 bpp gray, 32 bpp rgb, or cmapped images.<para/>
''' It is relatively slow compared to the sampled version<para/>
''' implemented by rasterop, but the result is much smoother.<para/>
''' (2) This shear leaves the vertical line of pixels at x = xloc<para/>
''' invariant.  For a positive shear angle, pixels to the right<para/>
''' of this line are shoved downward, and pixels to the left<para/>
''' of the line move upward.<para/>
''' (3) Any colormap is removed.<para/>
''' (4) The angle is brought into the range [-pi/2 + del, pi/2 - del],<para/>
''' where del == MIN_DIFF_FROM_HALF_PI.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp or 32 bpp, or colormapped</param>
'''  <param name="xloc">[in] - location of vertical line, measured from origin</param>
'''  <param name="radang">[in] - angle in radians, in range (-pi/2 ... pi/2)</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd sheared, or NULL on error</returns>
Public Shared Function pixVShearLI(
				 ByVal pixs as Pix, 
				 ByVal xloc as Integer, 
				 ByVal radang as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixVShearLI( pixs.Pointer, xloc, radang, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
