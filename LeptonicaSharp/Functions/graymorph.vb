Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\graymorph.c (158, 1)
' pixErodeGray()
' pixErodeGray(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel; must be odd; origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeGray(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeGray( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (274, 1)
' pixDilateGray()
' pixDilateGray(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel; must be odd; origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateGray(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateGray( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (390, 1)
' pixOpenGray()
' pixOpenGray(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel; must be odd; origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenGray(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenGray( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (522, 1)
' pixCloseGray()
' pixCloseGray(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel; must be odd; origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseGray(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseGray( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (661, 1)
' pixErodeGray3()
' pixErodeGray3(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)
''' (2) If hsize = vsize = 1, just returns a copy.
''' (3) It would be nice not to add a border, but it is required
''' if we want the same results as from the general case.
''' We add 4 bytes on the left to speed up the copying, and
''' 8 bytes at the right and bottom to allow unrolling of
''' the computation of 8 pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="hsize">[in] - 1 or 3</param>
'''  <param name="vsize">[in] - 1 or 3</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixErodeGray3(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeGray3( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (847, 1)
' pixDilateGray3()
' pixDilateGray3(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="hsize">[in] - 1 or 3</param>
'''  <param name="vsize">[in] - 1 or 3</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixDilateGray3(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateGray3( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (1032, 1)
' pixOpenGray3()
' pixOpenGray3(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)
''' (2) If hsize = vsize = 1, just returns a copy.
''' (3) It would be nice not to add a border, but it is required
''' to get the same results as for the general case.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="hsize">[in] - 1 or 3</param>
'''  <param name="vsize">[in] - 1 or 3</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixOpenGray3(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenGray3( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graymorph.c (1098, 1)
' pixCloseGray3()
' pixCloseGray3(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Special case for 1x3, 3x1 or 3x3 brick sel (all hits)
''' (2) If hsize = vsize = 1, just returns a copy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="hsize">[in] - 1 or 3</param>
'''  <param name="vsize">[in] - 1 or 3</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseGray3(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseGray3( pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
