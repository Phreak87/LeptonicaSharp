Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\morph.c (209, 1)
' pixDilate(pixd, pixs, sel) as Pix
' pixDilate(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This dilates src using hits in Sel.<para/>
''' (2) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixDilate(NULL, pixs, ...)<para/>
''' (b) pixDilate(pixs, pixs, ...)<para/>
''' (c) pixDilate(pixd, pixs, ...)<para/>
''' (4) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixDilate(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilate( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (263, 1)
' pixErode(pixd, pixs, sel) as Pix
' pixErode(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This erodes src using hits in Sel.<para/>
''' (2) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixErode(NULL, pixs, ...)<para/>
''' (b) pixErode(pixs, pixs, ...)<para/>
''' (c) pixErode(pixd, pixs, ...)<para/>
''' (4) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixErode(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErode( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (338, 1)
' pixHMT(pixd, pixs, sel) as Pix
' pixHMT(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The hit-miss transform erodes the src, using both hits<para/>
''' and misses in the Sel.  It ANDs the shifted src for hits<para/>
''' and ANDs the inverted shifted src for misses.<para/>
''' (2) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixHMT(NULL, pixs, ...)<para/>
''' (b) pixHMT(pixs, pixs, ...)<para/>
''' (c) pixHMT(pixd, pixs, ...)<para/>
''' (4) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixHMT(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHMT( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (422, 1)
' pixOpen(pixd, pixs, sel) as Pix
' pixOpen(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generic morphological opening, using hits in the Sel.<para/>
''' (2) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpen(NULL, pixs, ...)<para/>
''' (b) pixOpen(pixs, pixs, ...)<para/>
''' (c) pixOpen(pixd, pixs, ...)<para/>
''' (4) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpen(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpen( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (469, 1)
' pixClose(pixd, pixs, sel) as Pix
' pixClose(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generic morphological closing, using hits in the Sel.<para/>
''' (2) This implementation is a strict dual of the opening if<para/>
''' symmetric boundary conditions are used (see notes at top<para/>
''' of this file).<para/>
''' (3) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (4) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixClose(NULL, pixs, ...)<para/>
''' (b) pixClose(pixs, pixs, ...)<para/>
''' (c) pixClose(pixd, pixs, ...)<para/>
''' (5) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixClose(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixClose( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (520, 1)
' pixCloseSafe(pixd, pixs, sel) as Pix
' pixCloseSafe(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generic morphological closing, using hits in the Sel.<para/>
''' (2) If non-symmetric boundary conditions are used, this<para/>
''' function adds a border of OFF pixels that is of<para/>
''' sufficient size to avoid losing pixels from the dilation,<para/>
''' and it removes the border after the operation is finished.<para/>
''' It thus enforces a correct extensive result for closing.<para/>
''' (3) If symmetric b.c. are used, it is not necessary to add<para/>
''' and remove this border.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseSafe(NULL, pixs, ...)<para/>
''' (b) pixCloseSafe(pixs, pixs, ...)<para/>
''' (c) pixCloseSafe(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseSafe(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafe( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (587, 1)
' pixOpenGeneralized(pixd, pixs, sel) as Pix
' pixOpenGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generalized morphological opening, using both hits and<para/>
''' misses in the Sel.<para/>
''' (2) This does a hit-miss transform, followed by a dilation<para/>
''' using the hits.<para/>
''' (3) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (4) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpenGeneralized(NULL, pixs, ...)<para/>
''' (b) pixOpenGeneralized(pixs, pixs, ...)<para/>
''' (c) pixOpenGeneralized(pixd, pixs, ...)<para/>
''' (5) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenGeneralized(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenGeneralized( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (634, 1)
' pixCloseGeneralized(pixd, pixs, sel) as Pix
' pixCloseGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generalized morphological closing, using both hits and<para/>
''' misses in the Sel.<para/>
''' (2) This does a dilation using the hits, followed by a<para/>
''' hit-miss transform.<para/>
''' (3) This operation is a dual of the generalized opening.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseGeneralized(NULL, pixs, ...)<para/>
''' (b) pixCloseGeneralized(pixs, pixs, ...)<para/>
''' (c) pixCloseGeneralized(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseGeneralized(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal sel as Sel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseGeneralized( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (684, 1)
' pixDilateBrick(pixd, pixs, hsize, vsize) as Pix
' pixDilateBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixDilateBrick(NULL, pixs, ...)<para/>
''' (b) pixDilateBrick(pixs, pixs, ...)<para/>
''' (c) pixDilateBrick(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (748, 1)
' pixErodeBrick(pixd, pixs, hsize, vsize) as Pix
' pixErodeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixErodeBrick(NULL, pixs, ...)<para/>
''' (b) pixErodeBrick(pixs, pixs, ...)<para/>
''' (c) pixErodeBrick(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (812, 1)
' pixOpenBrick(pixd, pixs, hsize, vsize) as Pix
' pixOpenBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpenBrick(NULL, pixs, ...)<para/>
''' (b) pixOpenBrick(pixs, pixs, ...)<para/>
''' (c) pixOpenBrick(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixOpenBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (878, 1)
' pixCloseBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (4) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (5) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseBrick(NULL, pixs, ...)<para/>
''' (b) pixCloseBrick(pixs, pixs, ...)<para/>
''' (c) pixCloseBrick(pixd, pixs, ...)<para/>
''' (6) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (949, 1)
' pixCloseSafeBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseSafeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (4) Safe closing adds a border of 0 pixels, of sufficient size so<para/>
''' that all pixels in input image are processed within<para/>
''' 32-bit words in the expanded image.  As a result, there is<para/>
''' no special processing for pixels near the boundary, and there<para/>
''' are no boundary effects.  The border is removed at the end.<para/>
''' (5) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (6) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseBrick(NULL, pixs, ...)<para/>
''' (b) pixCloseBrick(pixs, pixs, ...)<para/>
''' (c) pixCloseBrick(pixd, pixs, ...)<para/>
''' (7) The size of the result is determined by pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseSafeBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafeBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1037, 1)
' selectComposableSels(size, direction, psel1, psel2) as Integer
' selectComposableSels(l_int32, l_int32, SEL **, SEL **) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function selectComposableSels(
				 ByVal size as Integer, 
				 ByVal direction as Integer, 
				 ByVal psel1 as Sel, 
				 ByVal psel2 as Sel) as Integer

	If IsNothing (psel1) then Throw New ArgumentNullException  ("psel1 cannot be Nothing")
	If IsNothing (psel2) then Throw New ArgumentNullException  ("psel2 cannot be Nothing")

	Dim psel1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(psel1) Then psel1PTR = psel1.Pointer
	Dim psel2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(psel2) Then psel2PTR = psel2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.selectComposableSels( size, direction, psel1PTR, psel2PTR)

	Return _Result
End Function

' SRC\morph.c (1092, 1)
' selectComposableSizes(size, pfactor1, pfactor2) as Integer
' selectComposableSizes(l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This works for Sel sizes up to 62500, which seems sufficient.<para/>
''' (2) The composable sel size is typically within +- 1 of<para/>
''' the requested size.  Up to size = 300, the maximum difference<para/>
''' is +- 2.<para/>
''' (3) We choose an overall cost function where the penalty for<para/>
''' the size difference between input and actual is 4 times<para/>
''' the penalty for additional rasterops.<para/>
''' (4) Returned values: factor1  is greater = factor2<para/>
''' If size  is greater  1, then factor1  is greater  1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="size">[in] - of sel to be decomposed</param>
'''  <param name="pfactor1">[out] - larger factor</param>
'''  <param name="pfactor2">[out] - smaller factor</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selectComposableSizes(
				 ByVal size as Integer, 
				<Out()> ByRef pfactor1 as Integer, 
				<Out()> ByRef pfactor2 as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.selectComposableSizes( size, pfactor1, pfactor2)

	Return _Result
End Function

' SRC\morph.c (1204, 1)
' pixDilateCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixDilateCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do compositely for each dimension  is greater  1.<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (6) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixDilateCompBrick(NULL, pixs, ...)<para/>
''' (b) pixDilateCompBrick(pixs, pixs, ...)<para/>
''' (c) pixDilateCompBrick(pixd, pixs, ...)<para/>
''' (7) The dimensions of the resulting image are determined by pixs.<para/>
''' (8) CAUTION: both hsize and vsize are being decomposed.<para/>
''' The decomposer chooses a product of sizes (call them<para/>
''' 'terms') for each that is close to the input size,<para/>
''' but not necessarily equal to it.  It attempts to optimize:<para/>
''' (a) for consistency with the input values: the product<para/>
''' of terms is close to the input size<para/>
''' (b) for efficiency of the operation: the sum of the<para/>
''' terms is small ideally about twice the square<para/>
''' root of the input size.<para/>
''' So, for example, if the input hsize = 37, which is<para/>
''' a prime number, the decomposer will break this into two<para/>
''' terms, 6 and 6, so that the net result is a dilation<para/>
''' with hsize = 36.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixDilateCompBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1304, 1)
' pixErodeCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixErodeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do compositely for each dimension  is greater  1.<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (6) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixErodeCompBrick(NULL, pixs, ...)<para/>
''' (b) pixErodeCompBrick(pixs, pixs, ...)<para/>
''' (c) pixErodeCompBrick(pixd, pixs, ...)<para/>
''' (7) The dimensions of the resulting image are determined by pixs.<para/>
''' (8) CAUTION: both hsize and vsize are being decomposed.<para/>
''' The decomposer chooses a product of sizes (call them<para/>
''' 'terms') for each that is close to the input size,<para/>
''' but not necessarily equal to it.  It attempts to optimize:<para/>
''' (a) for consistency with the input values: the product<para/>
''' of terms is close to the input size<para/>
''' (b) for efficiency of the operation: the sum of the<para/>
''' terms is small ideally about twice the square<para/>
''' root of the input size.<para/>
''' So, for example, if the input hsize = 37, which is<para/>
''' a prime number, the decomposer will break this into two<para/>
''' terms, 6 and 6, so that the net result is a dilation<para/>
''' with hsize = 36.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixErodeCompBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1395, 1)
' pixOpenCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixOpenCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do compositely for each dimension  is greater  1.<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (6) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpenCompBrick(NULL, pixs, ...)<para/>
''' (b) pixOpenCompBrick(pixs, pixs, ...)<para/>
''' (c) pixOpenCompBrick(pixd, pixs, ...)<para/>
''' (7) The dimensions of the resulting image are determined by pixs.<para/>
''' (8) CAUTION: both hsize and vsize are being decomposed.<para/>
''' The decomposer chooses a product of sizes (call them<para/>
''' 'terms') for each that is close to the input size,<para/>
''' but not necessarily equal to it.  It attempts to optimize:<para/>
''' (a) for consistency with the input values: the product<para/>
''' of terms is close to the input size<para/>
''' (b) for efficiency of the operation: the sum of the<para/>
''' terms is small ideally about twice the square<para/>
''' root of the input size.<para/>
''' So, for example, if the input hsize = 37, which is<para/>
''' a prime number, the decomposer will break this into two<para/>
''' terms, 6 and 6, so that the net result is a dilation<para/>
''' with hsize = 36.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixOpenCompBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1494, 1)
' pixCloseCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do compositely for each dimension  is greater  1.<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (6) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseCompBrick(NULL, pixs, ...)<para/>
''' (b) pixCloseCompBrick(pixs, pixs, ...)<para/>
''' (c) pixCloseCompBrick(pixd, pixs, ...)<para/>
''' (7) The dimensions of the resulting image are determined by pixs.<para/>
''' (8) CAUTION: both hsize and vsize are being decomposed.<para/>
''' The decomposer chooses a product of sizes (call them<para/>
''' 'terms') for each that is close to the input size,<para/>
''' but not necessarily equal to it.  It attempts to optimize:<para/>
''' (a) for consistency with the input values: the product<para/>
''' of terms is close to the input size<para/>
''' (b) for efficiency of the operation: the sum of the<para/>
''' terms is small ideally about twice the square<para/>
''' root of the input size.<para/>
''' So, for example, if the input hsize = 37, which is<para/>
''' a prime number, the decomposer will break this into two<para/>
''' terms, 6 and 6, so that the net result is a dilation<para/>
''' with hsize = 36.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseCompBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1598, 1)
' pixCloseSafeCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseSafeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
''' (3) Do compositely for each dimension  is greater  1.<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) Safe closing adds a border of 0 pixels, of sufficient size so<para/>
''' that all pixels in input image are processed within<para/>
''' 32-bit words in the expanded image.  As a result, there is<para/>
''' no special processing for pixels near the boundary, and there<para/>
''' are no boundary effects.  The border is removed at the end.<para/>
''' (6) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (7) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseSafeCompBrick(NULL, pixs, ...)<para/>
''' (b) pixCloseSafeCompBrick(pixs, pixs, ...)<para/>
''' (c) pixCloseSafeCompBrick(pixd, pixs, ...)<para/>
''' (8) The dimensions of the resulting image are determined by pixs.<para/>
''' (9) CAUTION: both hsize and vsize are being decomposed.<para/>
''' The decomposer chooses a product of sizes (call them<para/>
''' 'terms') for each that is close to the input size,<para/>
''' but not necessarily equal to it.  It attempts to optimize:<para/>
''' (a) for consistency with the input values: the product<para/>
''' of terms is close to the input size<para/>
''' (b) for efficiency of the operation: the sum of the<para/>
''' terms is small ideally about twice the square<para/>
''' root of the input size.<para/>
''' So, for example, if the input hsize = 37, which is<para/>
''' a prime number, the decomposer will break this into two<para/>
''' terms, 6 and 6, so that the net result is a dilation<para/>
''' with hsize = 36.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseSafeCompBrick(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafeCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1687, 1)
' resetMorphBoundaryCondition(bc) as Object
' resetMorphBoundaryCondition(l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <param name="bc">[in] - SYMMETRIC_MORPH_BC, ASYMMETRIC_MORPH_BC</param>
Public Shared Sub resetMorphBoundaryCondition(
				 ByVal bc as Enumerations.MMETRIC_MORPH_BC)



	LeptonicaSharp.Natives.resetMorphBoundaryCondition( bc)

End Sub

' SRC\morph.c (1708, 1)
' getMorphBorderPixelColor(type, depth) as UInteger
' getMorphBorderPixelColor(l_int32, l_int32) as l_uint32
'''  <remarks>
'''  </remarks>
'''  <param name="type">[in] - L_MORPH_DILATE, L_MORPH_ERODE</param>
'''  <param name="depth">[in] - of pix</param>
'''   <returns>color of border pixels for this operation</returns>
Public Shared Function getMorphBorderPixelColor(
				 ByVal type as Enumerations.L_MORPH, 
				 ByVal depth as Integer) as UInteger



	Dim _Result as UInteger = LeptonicaSharp.Natives.getMorphBorderPixelColor( type, depth)

	Return _Result
End Function

End Class
