Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\rotateshear.c (196, 1)
' pixRotateShear(pixs, xcen, ycen, angle, incolor) as Pix
' pixRotateShear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This rotates an image about the given point, using<para/>
''' either 2 or 3 shears.<para/>
''' (2) A positive angle gives a clockwise rotation.<para/>
''' (3) This brings in 'incolor' pixels from outside the image.<para/>
''' (4) For rotation angles larger than about 0.35 radians, we issue<para/>
''' a warning because you should probably be using another method<para/>
''' (either sampling or area mapping)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - x value for which there is no horizontal shear</param>
'''  <param name="ycen">[in] - y value for which there is no vertical shear</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotateShear(
				 ByVal pixs as Pix, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateShear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (248, 1)
' pixRotate2Shear(pixs, xcen, ycen, angle, incolor) as Pix
' pixRotate2Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This rotates the image about the given point, using the 2-shear<para/>
''' method.  It should only be used for angles smaller than<para/>
''' MAX_2_SHEAR_ANGLE.  For larger angles, a warning is issued.<para/>
''' (2) A positive angle gives a clockwise rotation.<para/>
''' (3) 2-shear rotation by a specified angle is equivalent<para/>
''' to the sequential transformations<para/>
''' x' = x + tan(angle)  (y - ycen) for x-shear<para/>
''' y' = y + tan(angle)  (x - xcen) for y-shear<para/>
''' (4) Computation of tan(angle) is performed within the shear operation.<para/>
''' (5) This brings in 'incolor' pixels from outside the image.<para/>
''' (6) If the image has an alpha layer, it is rotated separately by<para/>
''' two shears.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotate2Shear(
				 ByVal pixs as Pix, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate2Shear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (319, 1)
' pixRotate3Shear(pixs, xcen, ycen, angle, incolor) as Pix
' pixRotate3Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This rotates the image about the given point, using the 3-shear<para/>
''' method.  It should only be used for angles smaller than<para/>
''' LIMIT_SHEAR_ANGLE.  For larger angles, a warning is issued.<para/>
''' (2) A positive angle gives a clockwise rotation.<para/>
''' (3) 3-shear rotation by a specified angle is equivalent<para/>
''' to the sequential transformations<para/>
''' y' = y + tan(angle/2)  (x - xcen) for first y-shear<para/>
''' x' = x + sin(angle)  (y - ycen) for x-shear<para/>
''' y' = y + tan(angle/2)  (x - xcen) for second y-shear<para/>
''' (4) Computation of tan(angle) is performed in the shear operations.<para/>
''' (5) This brings in 'incolor' pixels from outside the image.<para/>
''' (6) If the image has an alpha layer, it is rotated separately by<para/>
''' two shears.<para/>
''' (7) The algorithm was published by Alan Paeth: "A Fast Algorithm<para/>
''' for General Raster Rotation," Graphics Interface '86,<para/>
''' pp. 77-81, May 1986.  A description of the method, along with<para/>
''' an implementation, can be found in Graphics Gems, p. 179,<para/>
''' edited by Andrew Glassner, published by Academic Press, 1990.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotate3Shear(
				 ByVal pixs as Pix, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate3Shear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (395, 1)
' pixRotateShearIP(pixs, xcen, ycen, angle, incolor) as Integer
' pixRotateShearIP(PIX *, l_int32, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does an in-place rotation of the image about the<para/>
''' specified point, using the 3-shear method.  It should only<para/>
''' be used for angles smaller than LIMIT_SHEAR_ANGLE.<para/>
''' For larger angles, a warning is issued.<para/>
''' (2) A positive angle gives a clockwise rotation.<para/>
''' (3) 3-shear rotation by a specified angle is equivalent<para/>
''' to the sequential transformations<para/>
''' y' = y + tan(angle/2)  (x - xcen)  for first y-shear<para/>
''' x' = x + sin(angle)  (y - ycen)  for x-shear<para/>
''' y' = y + tan(angle/2)  (x - xcen)  for second y-shear<para/>
''' (4) Computation of tan(angle) is performed in the shear operations.<para/>
''' (5) This brings in 'incolor' pixels from outside the image.<para/>
''' (6) The pix cannot be colormapped, because the in-place operation<para/>
''' only blits in 0 or 1 bits, not an arbitrary colormap index.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth not colormapped</param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixRotateShearIP(
				 ByVal pixs as Pix, 
				 ByVal xcen as Integer, 
				 ByVal ycen as Integer, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixRotateShearIP( pixs.Pointer, xcen, ycen, angle, incolor)

	Return _Result
End Function

' SRC\rotateshear.c (439, 1)
' pixRotateShearCenter(pixs, angle, incolor) as Pix
' pixRotateShearCenter(PIX *, l_float32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateShearCenter(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateShearCenter( pixs.Pointer, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (462, 1)
' pixRotateShearCenterIP(pixs, angle, incolor) as Integer
' pixRotateShearCenterIP(PIX *, l_float32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRotateShearCenterIP(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixRotateShearCenterIP( pixs.Pointer, angle, incolor)

	Return _Result
End Function

End Class
