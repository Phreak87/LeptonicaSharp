Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\rotateam.c (149, 1)
' pixRotateAM(pixs, angle, incolor) as Pix
' pixRotateAM(PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates about image center.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Brings in either black or white pixels from the boundary.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAM/*"/>
'''  <param name="pixs">[in] - 2, 4, 8 bpp gray or colormapped, or 32 bpp RGB</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAM(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAM( pixs.Pointer, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (212, 1)
' pixRotateAMColor(pixs, angle, colorval) as Pix
' pixRotateAMColor(PIX *, l_float32, l_uint32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates about image center.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Specify the color to be brought in from outside the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMColor/*"/>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMColor(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMColor( pixs.Pointer, angle, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (266, 1)
' pixRotateAMGray(pixs, angle, grayval) as Pix
' pixRotateAMGray(PIX *, l_float32, l_uint8) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates about image center.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Specify the grayvalue to be brought in from outside the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMGray/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMGray(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMGray( pixs.Pointer, angle, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (447, 1)
' pixRotateAMCorner(pixs, angle, incolor) as Pix
' pixRotateAMCorner(PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates about the UL corner of the image.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Brings in either black or white pixels from the boundary.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMCorner/*"/>
'''  <param name="pixs">[in] - 1, 2, 4, 8 bpp gray or colormapped, or 32 bpp RGB</param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMCorner(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMCorner( pixs.Pointer, angle, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (508, 1)
' pixRotateAMColorCorner(pixs, angle, fillval) as Pix
' pixRotateAMColorCorner(PIX *, l_float32, l_uint32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates the image about the UL corner.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Specify the color to be brought in from outside the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMColorCorner/*"/>
'''  <param name="pixs">[in] - </param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="fillval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMColorCorner(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal fillval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMColorCorner( pixs.Pointer, angle, fillval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (562, 1)
' pixRotateAMGrayCorner(pixs, angle, grayval) as Pix
' pixRotateAMGrayCorner(PIX *, l_float32, l_uint8) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Rotates the image about the UL corner.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) Specify the grayvalue to be brought in from outside the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMGrayCorner/*"/>
'''  <param name="pixs">[in] - </param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMGrayCorner(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal grayval as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (grayval) then Throw New ArgumentNullException  ("grayval cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMGrayCorner( pixs.Pointer, angle, grayval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateam.c (741, 1)
' pixRotateAMColorFast(pixs, angle, colorval) as Pix
' pixRotateAMColorFast(PIX *, l_float32, l_uint32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This rotates a color image about the image center.<para/>
''' 
''' (2) A positive angle gives a clockwise rotation.<para/>
''' 
''' (3) It uses area mapping, dividing each pixel into
''' 16 subpixels.<para/>
''' 
''' (4) It is about 10% to 20% faster than the more accurate linear
''' interpolation function pixRotateAMColor(),
''' which uses 256 subpixels.<para/>
''' 
''' (5) For some reason it shifts the image center.
''' No attempt is made to rotate the alpha component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRotateAMColorFast/*"/>
'''  <param name="pixs">[in] - </param>
'''  <param name="angle">[in] - radians clockwise is positive</param>
'''  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateAMColorFast(
				 ByVal pixs as Pix, 
				 ByVal angle as Single, 
				 ByVal colorval as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateAMColorFast( pixs.Pointer, angle, colorval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
