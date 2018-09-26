Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\morph.c (209, 1)
' pixDilate()
' pixDilate(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) This dilates src using hits in Sel.
''' (2) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixDilate(NULL, pixs, ...);
''' (b) pixDilate(pixs, pixs, ...);
''' (c) pixDilate(pixd, pixs, ...);
''' (4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixDilate(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilate( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (263, 1)
' pixErode()
' pixErode(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) This erodes src using hits in Sel.
''' (2) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixErode(NULL, pixs, ...);
''' (b) pixErode(pixs, pixs, ...);
''' (c) pixErode(pixd, pixs, ...);
''' (4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixErode(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErode( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (338, 1)
' pixHMT()
' pixHMT(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) The hit-miss transform erodes the src, using both hits
''' and misses in the Sel.  It ANDs the shifted src for hits
''' and ANDs the inverted shifted src for misses.
''' (2) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixHMT(NULL, pixs, ...);
''' (b) pixHMT(pixs, pixs, ...);
''' (c) pixHMT(pixd, pixs, ...);
''' (4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixHMT(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHMT( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (422, 1)
' pixOpen()
' pixOpen(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) Generic morphological opening, using hits in the Sel.
''' (2) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (3) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpen(NULL, pixs, ...);
''' (b) pixOpen(pixs, pixs, ...);
''' (c) pixOpen(pixd, pixs, ...);
''' (4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpen(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpen( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (469, 1)
' pixClose()
' pixClose(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) Generic morphological closing, using hits in the Sel.
''' (2) This implementation is a strict dual of the opening if
''' symmetric boundary conditions are used (see notes at top
''' of this file).
''' (3) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (4) For clarity, if the case is known, use these patterns
''' (a) pixd = pixClose(NULL, pixs, ...);
''' (b) pixClose(pixs, pixs, ...);
''' (c) pixClose(pixd, pixs, ...);
''' (5) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixClose(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixClose( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (520, 1)
' pixCloseSafe()
' pixCloseSafe(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) Generic morphological closing, using hits in the Sel.
''' (2) If non-symmetric boundary conditions are used, this
''' function adds a border of OFF pixels that is of
''' sufficient size to avoid losing pixels from the dilation,
''' and it removes the border after the operation is finished.
''' It thus enforces a correct extensive result for closing.
''' (3) If symmetric b.c. are used, it is not necessary to add
''' and remove this border.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseSafe(NULL, pixs, ...);
''' (b) pixCloseSafe(pixs, pixs, ...);
''' (c) pixCloseSafe(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseSafe(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafe( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (587, 1)
' pixOpenGeneralized()
' pixOpenGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) Generalized morphological opening, using both hits and
''' misses in the Sel.
''' (2) This does a hit-miss transform, followed by a dilation
''' using the hits.
''' (3) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (4) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpenGeneralized(NULL, pixs, ...);
''' (b) pixOpenGeneralized(pixs, pixs, ...);
''' (c) pixOpenGeneralized(pixd, pixs, ...);
''' (5) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenGeneralized(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenGeneralized( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (634, 1)
' pixCloseGeneralized()
' pixCloseGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' Notes
''' (1) Generalized morphological closing, using both hits and
''' misses in the Sel.
''' (2) This does a dilation using the hits, followed by a
''' hit-miss transform.
''' (3) This operation is a dual of the generalized opening.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseGeneralized(NULL, pixs, ...);
''' (b) pixCloseGeneralized(pixs, pixs, ...);
''' (c) pixCloseGeneralized(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseGeneralized(
				ByVal pixs as Pix, 
				ByVal sel as Sel, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseGeneralized( pixdPTR, pixs.Pointer, sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (684, 1)
' pixDilateBrick()
' pixDilateBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do separably if both hsize and vsize are GT 1.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixDilateBrick(NULL, pixs, ...);
''' (b) pixDilateBrick(pixs, pixs, ...);
''' (c) pixDilateBrick(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (748, 1)
' pixErodeBrick()
' pixErodeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do separably if both hsize and vsize are GT 1.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixErodeBrick(NULL, pixs, ...);
''' (b) pixErodeBrick(pixs, pixs, ...);
''' (c) pixErodeBrick(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (812, 1)
' pixOpenBrick()
' pixOpenBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do separably if both hsize and vsize are GT 1.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpenBrick(NULL, pixs, ...);
''' (b) pixOpenBrick(pixs, pixs, ...);
''' (c) pixOpenBrick(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixOpenBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (878, 1)
' pixCloseBrick()
' pixCloseBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do separably if both hsize and vsize are GT 1.
''' (4) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (5) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseBrick(NULL, pixs, ...);
''' (b) pixCloseBrick(pixs, pixs, ...);
''' (c) pixCloseBrick(pixd, pixs, ...);
''' (6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (949, 1)
' pixCloseSafeBrick()
' pixCloseSafeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do separably if both hsize and vsize are GT 1.
''' (4) Safe closing adds a border of 0 pixels, of sufficient size so
''' that all pixels in input image are processed within
''' 32-bit words in the expanded image.  As a result, there is
''' no special processing for pixels near the boundary, and there
''' are no boundary effects.  The border is removed at the end.
''' (5) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (6) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseBrick(NULL, pixs, ...);
''' (b) pixCloseBrick(pixs, pixs, ...);
''' (c) pixCloseBrick(pixd, pixs, ...);
''' (7) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseSafeBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafeBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1037, 1)
' 
' selectComposableSels(l_int32, l_int32, SEL **, SEL **) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function selectComposableSels(
				ByRef size as Integer, 
				ByRef direction as Integer, 
				ByRef psel1 as Sel, 
				ByRef psel2 as Sel) as Integer

	If IsNothing (psel1) then Throw New ArgumentNullException  ("psel1 cannot be Nothing")
	If IsNothing (psel2) then Throw New ArgumentNullException  ("psel2 cannot be Nothing")

	Dim psel1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(psel1) Then psel1PTR = psel1.Pointer
	Dim psel2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(psel2) Then psel2PTR = psel2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.selectComposableSels( size, direction, psel1PTR, psel2PTR)

	Return _Result
End Function

' SRC\morph.c (1092, 1)
' selectComposableSizes()
' selectComposableSizes(l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This works for Sel sizes up to 62500, which seems sufficient.
''' (2) The composable sel size is typically within +- 1 of
''' the requested size.  Up to size = 300, the maximum difference
''' is +- 2.
''' (3) We choose an overall cost function where the penalty for
''' the size difference between input and actual is 4 times
''' the penalty for additional rasterops.
''' (4) Returned values factor1 GT= factor2
''' If size GT 1, then factor1 GT 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="size">[in] - of sel to be decomposed</param>
'''  <param name="pfactor1">[out] - larger factor</param>
'''  <param name="pfactor2">[out] - smaller factor</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selectComposableSizes(
				ByVal size as Integer, 
				ByRef pfactor1 as Integer, 
				ByRef pfactor2 as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.selectComposableSizes( size, pfactor1, pfactor2)

	Return _Result
End Function

' SRC\morph.c (1204, 1)
' pixDilateCompBrick()
' pixDilateCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do compositely for each dimension GT 1.
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (6) For clarity, if the case is known, use these patterns
''' (a) pixd = pixDilateCompBrick(NULL, pixs, ...);
''' (b) pixDilateCompBrick(pixs, pixs, ...);
''' (c) pixDilateCompBrick(pixd, pixs, ...);
''' (7) The dimensions of the resulting image are determined by pixs.
''' (8) CAUTION both hsize and vsize are being decomposed.
''' The decomposer chooses a product of sizes (call them
''' 'terms') for each that is close to the input size,
''' but not necessarily equal to it.  It attempts to optimize
''' (a) for consistency with the input values the product
''' of terms is close to the input size
''' (b) for efficiency of the operation the sum of the
''' terms is small; ideally about twice the square
''' root of the input size.
''' So, for example, if the input hsize = 37, which is
''' a prime number, the decomposer will break this into two
''' terms, 6 and 6, so that the net result is a dilation
''' with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixDilateCompBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1304, 1)
' pixErodeCompBrick()
' pixErodeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do compositely for each dimension GT 1.
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (6) For clarity, if the case is known, use these patterns
''' (a) pixd = pixErodeCompBrick(NULL, pixs, ...);
''' (b) pixErodeCompBrick(pixs, pixs, ...);
''' (c) pixErodeCompBrick(pixd, pixs, ...);
''' (7) The dimensions of the resulting image are determined by pixs.
''' (8) CAUTION both hsize and vsize are being decomposed.
''' The decomposer chooses a product of sizes (call them
''' 'terms') for each that is close to the input size,
''' but not necessarily equal to it.  It attempts to optimize
''' (a) for consistency with the input values the product
''' of terms is close to the input size
''' (b) for efficiency of the operation the sum of the
''' terms is small; ideally about twice the square
''' root of the input size.
''' So, for example, if the input hsize = 37, which is
''' a prime number, the decomposer will break this into two
''' terms, 6 and 6, so that the net result is a dilation
''' with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixErodeCompBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1395, 1)
' pixOpenCompBrick()
' pixOpenCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do compositely for each dimension GT 1.
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (6) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpenCompBrick(NULL, pixs, ...);
''' (b) pixOpenCompBrick(pixs, pixs, ...);
''' (c) pixOpenCompBrick(pixd, pixs, ...);
''' (7) The dimensions of the resulting image are determined by pixs.
''' (8) CAUTION both hsize and vsize are being decomposed.
''' The decomposer chooses a product of sizes (call them
''' 'terms') for each that is close to the input size,
''' but not necessarily equal to it.  It attempts to optimize
''' (a) for consistency with the input values the product
''' of terms is close to the input size
''' (b) for efficiency of the operation the sum of the
''' terms is small; ideally about twice the square
''' root of the input size.
''' So, for example, if the input hsize = 37, which is
''' a prime number, the decomposer will break this into two
''' terms, 6 and 6, so that the net result is a dilation
''' with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixOpenCompBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1494, 1)
' pixCloseCompBrick()
' pixCloseCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do compositely for each dimension GT 1.
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (6) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseCompBrick(NULL, pixs, ...);
''' (b) pixCloseCompBrick(pixs, pixs, ...);
''' (c) pixCloseCompBrick(pixd, pixs, ...);
''' (7) The dimensions of the resulting image are determined by pixs.
''' (8) CAUTION both hsize and vsize are being decomposed.
''' The decomposer chooses a product of sizes (call them
''' 'terms') for each that is close to the input size,
''' but not necessarily equal to it.  It attempts to optimize
''' (a) for consistency with the input values the product
''' of terms is close to the input size
''' (b) for efficiency of the operation the sum of the
''' terms is small; ideally about twice the square
''' root of the input size.
''' So, for example, if the input hsize = 37, which is
''' a prime number, the decomposer will break this into two
''' terms, 6 and 6, so that the net result is a dilation
''' with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseCompBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1598, 1)
' pixCloseSafeCompBrick()
' pixCloseSafeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Sel is a brick with all elements being hits
''' (2) The origin is at (x, y) = (hsize/2, vsize/2)
''' (3) Do compositely for each dimension GT 1.
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) Safe closing adds a border of 0 pixels, of sufficient size so
''' that all pixels in input image are processed within
''' 32-bit words in the expanded image.  As a result, there is
''' no special processing for pixels near the boundary, and there
''' are no boundary effects.  The border is removed at the end.
''' (6) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (7) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseSafeCompBrick(NULL, pixs, ...);
''' (b) pixCloseSafeCompBrick(pixs, pixs, ...);
''' (c) pixCloseSafeCompBrick(pixd, pixs, ...);
''' (8) The dimensions of the resulting image are determined by pixs.
''' (9) CAUTION both hsize and vsize are being decomposed.
''' The decomposer chooses a product of sizes (call them
''' 'terms') for each that is close to the input size,
''' but not necessarily equal to it.  It attempts to optimize
''' (a) for consistency with the input values the product
''' of terms is close to the input size
''' (b) for efficiency of the operation the sum of the
''' terms is small; ideally about twice the square
''' root of the input size.
''' So, for example, if the input hsize = 37, which is
''' a prime number, the decomposer will break this into two
''' terms, 6 and 6, so that the net result is a dilation
''' with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCloseSafeCompBrick(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseSafeCompBrick( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morph.c (1687, 1)
' resetMorphBoundaryCondition()
' resetMorphBoundaryCondition(l_int32) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="bc">[in] - SYMMETRIC_MORPH_BC, ASYMMETRIC_MORPH_BC</param>
Public Shared Sub resetMorphBoundaryCondition(
				ByVal bc as Enumerations.MMETRIC_MORPH_BC)



	LeptonicaSharp.Natives.resetMorphBoundaryCondition( bc)

End Sub

' SRC\morph.c (1708, 1)
' getMorphBorderPixelColor()
' getMorphBorderPixelColor(l_int32, l_int32) as l_uint32
'''  <summary>
''' 
'''  </summary>
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
