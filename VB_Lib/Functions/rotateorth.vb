Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\rotateorth.c (72, 1)
' pixRotateOrth(pixs, quads) as Pix
' pixRotateOrth(PIX *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotateOrth/*"/>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="quads">[in] - 0-3 number of 90 degree cw rotations</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotateOrth(
				 ByVal pixs as Pix, 
				 ByVal quads as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotateOrth( pixs.Pointer, quads)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateorth.c (121, 1)
' pixRotate180(pixd, pixs) as Pix
' pixRotate180(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a 180 rotation of the image about the center,
''' which is equivalent to a left-right flip about a vertical
''' line through the image center, followed by a top-bottom
''' flip about a horizontal line through the image center.<para/>
''' 
''' (2) There are 3 cases for input:
''' (a) pixd == null (creates a new pixd)
''' (b) pixd == pixs (in-place operation)
''' (c) pixd != pixs (existing pixd)<para/>
''' 
''' (3) For clarity, use these three patterns, respectively:
''' (a) pixd = pixRotate180(NULL, pixs)
''' (b) pixRotate180(pixs, pixs)
''' (c) pixRotate180(pixd, pixs)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotate180/*"/>
'''  <param name="pixd">[in][optional] - can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - all depths</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotate180(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate180( pixdPTR, pixs.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateorth.c (163, 1)
' pixRotate90(pixs, direction) as Pix
' pixRotate90(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a 90 degree rotation of the image about the center,
''' either cw or ccw, returning a new pix.<para/>
''' 
''' (2) The direction must be either 1 (cw) or -1 (ccw).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRotate90/*"/>
'''  <param name="pixs">[in] - all depths</param>
'''  <param name="direction">[in] - 1 = clockwise,  -1 = counter-clockwise</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRotate90(
				 ByVal pixs as Pix, 
				 ByVal direction as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRotate90( pixs.Pointer, direction)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateorth.c (423, 1)
' pixFlipLR(pixd, pixs) as Pix
' pixFlipLR(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a left-right flip of the image, which is
''' equivalent to a rotation out of the plane about a
''' vertical line through the image center.<para/>
''' 
''' (2) There are 3 cases for input:
''' (a) pixd == null (creates a new pixd)
''' (b) pixd == pixs (in-place operation)
''' (c) pixd != pixs (existing pixd)<para/>
''' 
''' (3) For clarity, use these three patterns, respectively:
''' (a) pixd = pixFlipLR(NULL, pixs)
''' (b) pixFlipLR(pixs, pixs)
''' (c) pixFlipLR(pixd, pixs)<para/>
''' 
''' (4) If an existing pixd is not the same size as pixs, the
''' image data will be reallocated.<para/>
''' 
''' (5) The pixel access routines allow a trivial implementation.
''' However, for d  is smaller 8, it is more efficient to right-justify
''' each line to a 32-bit boundary and then extract bytes and
''' do pixel reversing. In those cases, as in the 180 degree
''' rotation, we right-shift the data (if necessary) to
''' right-justify on the 32 bit boundary, and then read the
''' bytes off each raster line in reverse order, reversing
''' the pixels in each byte using a table.  These functions
''' for 1, 2 and 4 bpp were tested against the "trivial"
''' version (shown here for 4 bpp):
''' for (i = 0 i  is smaller h i++) {
''' line = data + i  wpl
''' memcpy(buffer, line, bpl)
''' for (j = 0 j  is smaller w j++) {
''' val = GET_DATA_QBIT(buffer, w - 1 - j)
''' SET_DATA_QBIT(line, j, val)
''' }
''' }
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFlipLR/*"/>
'''  <param name="pixd">[in][optional] - can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - all depths</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixFlipLR(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFlipLR( pixdPTR, pixs.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rotateorth.c (601, 1)
' pixFlipTB(pixd, pixs) as Pix
' pixFlipTB(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This does a top-bottom flip of the image, which is
''' equivalent to a rotation out of the plane about a
''' horizontal line through the image center.<para/>
''' 
''' (2) There are 3 cases for input:
''' (a) pixd == null (creates a new pixd)
''' (b) pixd == pixs (in-place operation)
''' (c) pixd != pixs (existing pixd)<para/>
''' 
''' (3) For clarity, use these three patterns, respectively:
''' (a) pixd = pixFlipTB(NULL, pixs)
''' (b) pixFlipTB(pixs, pixs)
''' (c) pixFlipTB(pixd, pixs)<para/>
''' 
''' (4) If an existing pixd is not the same size as pixs, the
''' image data will be reallocated.<para/>
''' 
''' (5) This is simple and fast.  We use the memcpy function
''' to do all the work on aligned data, regardless of pixel
''' depth.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFlipTB/*"/>
'''  <param name="pixd">[in][optional] - can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - all depths</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixFlipTB(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFlipTB( pixdPTR, pixs.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
