Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\rotateshear.c (196, 1)
' pixRotateShear()
' pixRotateShear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This rotates an image about the given point, using
''' either 2 or 3 shears.
''' (2) A positive angle gives a clockwise rotation.
''' (3) This brings in 'incolor' pixels from outside the image.
''' (4) For rotation angles larger than about 0.35 radians, we issue
''' a warning because you should probably be using another method
''' (either sampling or area mapping)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - x value for which there is no horizontal shear</param>
'''  <param name="ycen">[in] - y value for which there is no vertical shear</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotateShear(
				ByVal pixs as Pix, 
				ByVal xcen as Integer, 
				ByVal ycen as Integer, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateShear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (248, 1)
' pixRotate2Shear()
' pixRotate2Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This rotates the image about the given point, using the 2-shear
''' method.  It should only be used for angles smaller than
''' MAX_2_SHEAR_ANGLE.  For larger angles, a warning is issued.
''' (2) A positive angle gives a clockwise rotation.
''' (3) 2-shear rotation by a specified angle is equivalent
''' to the sequential transformations
''' x' = x + tan(angle)  (y - ycen)  for x-shear
''' y' = y + tan(angle)  (x - xcen)  for y-shear
''' (4) Computation of tan(angle) is performed within the shear operation.
''' (5) This brings in 'incolor' pixels from outside the image.
''' (6) If the image has an alpha layer, it is rotated separately by
''' two shears.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotate2Shear(
				ByVal pixs as Pix, 
				ByVal xcen as Integer, 
				ByVal ycen as Integer, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate2Shear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (319, 1)
' pixRotate3Shear()
' pixRotate3Shear(PIX *, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This rotates the image about the given point, using the 3-shear
''' method.  It should only be used for angles smaller than
''' LIMIT_SHEAR_ANGLE.  For larger angles, a warning is issued.
''' (2) A positive angle gives a clockwise rotation.
''' (3) 3-shear rotation by a specified angle is equivalent
''' to the sequential transformations
''' y' = y + tan(angle/2)  (x - xcen)  for first y-shear
''' x' = x + sin(angle)  (y - ycen) for x-shear
''' y' = y + tan(angle/2)  (x - xcen)  for second y-shear
''' (4) Computation of tan(angle) is performed in the shear operations.
''' (5) This brings in 'incolor' pixels from outside the image.
''' (6) If the image has an alpha layer, it is rotated separately by
''' two shears.
''' (7) The algorithm was published by Alan Paeth "A Fast Algorithm
''' for General Raster Rotation," Graphics Interface '86,
''' pp. 77-81, May 1986.  A description of the method, along with
''' an implementation, can be found in Graphics Gems, p. 179,
''' edited by Andrew Glassner, published by Academic Press, 1990.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK;</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixRotate3Shear(
				ByVal pixs as Pix, 
				ByVal xcen as Integer, 
				ByVal ycen as Integer, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate3Shear( pixs.Pointer, xcen, ycen, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (395, 1)
' pixRotateShearIP()
' pixRotateShearIP(PIX *, l_int32, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This does an in-place rotation of the image about the
''' specified point, using the 3-shear method.  It should only
''' be used for angles smaller than LIMIT_SHEAR_ANGLE.
''' For larger angles, a warning is issued.
''' (2) A positive angle gives a clockwise rotation.
''' (3) 3-shear rotation by a specified angle is equivalent
''' to the sequential transformations
''' y' = y + tan(angle/2)  (x - xcen)   for first y-shear
''' x' = x + sin(angle)  (y - ycen)  for x-shear
''' y' = y + tan(angle/2)  (x - xcen)   for second y-shear
''' (4) Computation of tan(angle) is performed in the shear operations.
''' (5) This brings in 'incolor' pixels from outside the image.
''' (6) The pix cannot be colormapped, because the in-place operation
''' only blits in 0 or 1 bits, not an arbitrary colormap index.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth; not colormapped</param>
'''  <param name="xcen">[in] - center of rotation</param>
'''  <param name="ycen">[in] - center of rotation</param>
'''  <param name="angle">[in] - radians</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixRotateShearIP(
				ByVal pixs as Pix, 
				ByVal xcen as Integer, 
				ByVal ycen as Integer, 
				ByVal angle as Single, 
				ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRotateShearIP( pixs.Pointer, xcen, ycen, angle, incolor)

	Return _Result
End Function

' SRC\rotateshear.c (439, 1)
' pixRotateShearCenter()
' pixRotateShearCenter(PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
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
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateShearCenter( pixs.Pointer, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateshear.c (462, 1)
' pixRotateShearCenterIP()
' pixRotateShearCenterIP(PIX *, l_float32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
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
	If IsNothing (angle) then Throw New ArgumentNullException  ("angle cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRotateShearCenterIP( pixs.Pointer, angle, incolor)

	Return _Result
End Function

End Class
