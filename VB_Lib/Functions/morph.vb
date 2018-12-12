Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' morph.c (209, 1)
' pixDilate(pixd, pixs, sel) as Pix
' pixDilate(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) This dilates src using hits in Sel.<para/>
'''
'''(2) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(3) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixDilate(NULL, pixs, ...)
'''(b) pixDilate(pixs, pixs, ...)
'''(c) pixDilate(pixd, pixs, ...)<para/>
'''
'''(4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilate/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixDilate(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixDilate(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (263, 1)
' pixErode(pixd, pixs, sel) as Pix
' pixErode(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) This erodes src using hits in Sel.<para/>
'''
'''(2) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(3) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixErode(NULL, pixs, ...)
'''(b) pixErode(pixs, pixs, ...)
'''(c) pixErode(pixd, pixs, ...)<para/>
'''
'''(4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErode/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixErode(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixErode(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (338, 1)
' pixHMT(pixd, pixs, sel) as Pix
' pixHMT(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) The hit-miss transform erodes the src, using both hits
'''and misses in the Sel.  It ANDs the shifted src for hits
'''and ANDs the inverted shifted src for misses.<para/>
'''
'''(2) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(3) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixHMT(NULL, pixs, ...)
'''(b) pixHMT(pixs, pixs, ...)
'''(c) pixHMT(pixd, pixs, ...)<para/>
'''
'''(4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHMT/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixHMT(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixHMT(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (422, 1)
' pixOpen(pixd, pixs, sel) as Pix
' pixOpen(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) Generic morphological opening, using hits in the Sel.<para/>
'''
'''(2) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(3) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixOpen(NULL, pixs, ...)
'''(b) pixOpen(pixs, pixs, ...)
'''(c) pixOpen(pixd, pixs, ...)<para/>
'''
'''(4) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpen/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpen(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixOpen(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (469, 1)
' pixClose(pixd, pixs, sel) as Pix
' pixClose(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) Generic morphological closing, using hits in the Sel.<para/>
'''
'''(2) This implementation is a strict dual of the opening if
'''symmetric boundary conditions are used (see notes at top
'''of this file).<para/>
'''
'''(3) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(4) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixClose(NULL, pixs, ...)
'''(b) pixClose(pixs, pixs, ...)
'''(c) pixClose(pixd, pixs, ...)<para/>
'''
'''(5) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClose/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixClose(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixClose(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (520, 1)
' pixCloseSafe(pixd, pixs, sel) as Pix
' pixCloseSafe(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) Generic morphological closing, using hits in the Sel.<para/>
'''
'''(2) If non-symmetric boundary conditions are used, this
'''function adds a border of OFF pixels that is of
'''sufficient size to avoid losing pixels from the dilation,
'''and it removes the border after the operation is finished.
'''It thus enforces a correct extensive result for closing.<para/>
'''
'''(3) If symmetric b.c. are used, it is not necessary to add
'''and remove this border.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseSafe(NULL, pixs, ...)
'''(b) pixCloseSafe(pixs, pixs, ...)
'''(c) pixCloseSafe(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseSafe/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseSafe(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseSafe(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (587, 1)
' pixOpenGeneralized(pixd, pixs, sel) as Pix
' pixOpenGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) Generalized morphological opening, using both hits and
'''misses in the Sel.<para/>
'''
'''(2) This does a hit-miss transform, followed by a dilation
'''using the hits.<para/>
'''
'''(3) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(4) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixOpenGeneralized(NULL, pixs, ...)
'''(b) pixOpenGeneralized(pixs, pixs, ...)
'''(c) pixOpenGeneralized(pixd, pixs, ...)<para/>
'''
'''(5) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenGeneralized/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenGeneralized(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixOpenGeneralized(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (634, 1)
' pixCloseGeneralized(pixd, pixs, sel) as Pix
' pixCloseGeneralized(PIX *, PIX *, SEL *) as PIX *
'''  <summary>
''' (1) Generalized morphological closing, using both hits and
'''misses in the Sel.<para/>
'''
'''(2) This does a dilation using the hits, followed by a
'''hit-miss transform.<para/>
'''
'''(3) This operation is a dual of the generalized opening.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseGeneralized(NULL, pixs, ...)
'''(b) pixCloseGeneralized(pixs, pixs, ...)
'''(c) pixCloseGeneralized(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseGeneralized/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - </param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseGeneralized(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal sel as Sel) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseGeneralized(pixdPtr, pixs.Pointer, sel.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (684, 1)
' pixDilateBrick(pixd, pixs, hsize, vsize) as Pix
' pixDilateBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixDilateBrick(NULL, pixs, ...)
'''(b) pixDilateBrick(pixs, pixs, ...)
'''(c) pixDilateBrick(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixDilateBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (748, 1)
' pixErodeBrick(pixd, pixs, hsize, vsize) as Pix
' pixErodeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixErodeBrick(NULL, pixs, ...)
'''(b) pixErodeBrick(pixs, pixs, ...)
'''(c) pixErodeBrick(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixErodeBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (812, 1)
' pixOpenBrick(pixd, pixs, hsize, vsize) as Pix
' pixOpenBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixOpenBrick(NULL, pixs, ...)
'''(b) pixOpenBrick(pixs, pixs, ...)
'''(c) pixOpenBrick(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixOpenBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (878, 1)
' pixCloseBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(4) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(5) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseBrick(NULL, pixs, ...)
'''(b) pixCloseBrick(pixs, pixs, ...)
'''(c) pixCloseBrick(pixd, pixs, ...)<para/>
'''
'''(6) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (949, 1)
' pixCloseSafeBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseSafeBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(4) Safe closing adds a border of 0 pixels, of sufficient size so
'''that all pixels in input image are processed within
'''32-bit words in the expanded image.  As a result, there is
'''no special processing for pixels near the boundary, and there
'''are no boundary effects.  The border is removed at the end.<para/>
'''
'''(5) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(6) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseBrick(NULL, pixs, ...)
'''(b) pixCloseBrick(pixs, pixs, ...)
'''(c) pixCloseBrick(pixd, pixs, ...)<para/>
'''
'''(7) The size of the result is determined by pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseSafeBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseSafeBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1037, 1)
' selectComposableSels(size, direction, psel1, psel2) as Integer
' selectComposableSels(l_int32, l_int32, SEL **, SEL **) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selectComposableSels/*"/>
'''   <returns></returns>
Public Shared Function selectComposableSels(
				ByVal size as Integer, 
				ByVal direction as Integer, 
				ByVal psel1 as Sel, 
				ByVal psel2 as Sel) as Integer


if IsNothing (psel1) then Throw New ArgumentNullException  ("psel1 cannot be Nothing")
		if IsNothing (psel2) then Throw New ArgumentNullException  ("psel2 cannot be Nothing")
	Dim psel1Ptr as IntPtr = IntPtr.Zero : 	If Not IsNothing(psel1) Then psel1Ptr = psel1.Pointer
	Dim psel2Ptr as IntPtr = IntPtr.Zero : 	If Not IsNothing(psel2) Then psel2Ptr = psel2.Pointer

	Dim _Result as Integer = Natives.selectComposableSels(  size,   direction, psel1Ptr, psel2Ptr)
	
	return _Result
End Function

' morph.c (1092, 1)
' selectComposableSizes(size, pfactor1, pfactor2) as Integer
' selectComposableSizes(l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This works for Sel sizes up to 62500, which seems sufficient.<para/>
'''
'''(2) The composable sel size is typically within +- 1 of
'''the requested size.  Up to size = 300, the maximum difference
'''is +- 2.<para/>
'''
'''(3) We choose an overall cost function where the penalty for
'''the size difference between input and actual is 4 times
'''the penalty for additional rasterops.<para/>
'''
'''(4) Returned values: factor1 greater or equal factor2
'''If size  is greater  1, then factor1  is greater  1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selectComposableSizes/*"/>
'''  <param name="size">[in] - of sel to be decomposed</param>
'''  <param name="pfactor1">[out] - larger factor</param>
'''  <param name="pfactor2">[out] - smaller factor</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selectComposableSizes(
				ByVal size as Integer, 
				<Out()>  ByRef pfactor1 as Integer, 
				<Out()>  ByRef pfactor2 as Integer) as Integer


	Dim _Result as Integer = Natives.selectComposableSizes(  size,   pfactor1,   pfactor2)
	
	return _Result
End Function

' morph.c (1204, 1)
' pixDilateCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixDilateCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do compositely for each dimension  is greater  1.<para/>
'''
'''(4) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(5) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(6) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixDilateCompBrick(NULL, pixs, ...)
'''(b) pixDilateCompBrick(pixs, pixs, ...)
'''(c) pixDilateCompBrick(pixd, pixs, ...)<para/>
'''
'''(7) The dimensions of the resulting image are determined by pixs.<para/>
'''
'''(8) CAUTION: both hsize and vsize are being decomposed.
'''The decomposer chooses a product of sizes (call them
''''terms') for each that is close to the input size,
'''but not necessarily equal to it.  It attempts to optimize:
'''(a) for consistency with the input values: the product
'''of terms is close to the input size
'''(b) for efficiency of the operation: the sum of the
'''terms is small ideally about twice the square
'''root of the input size.
'''So, for example, if the input hsize = 37, which is
'''a prime number, the decomposer will break this into two
'''terms, 6 and 6, so that the net result is a dilation
'''with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateCompBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixDilateCompBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1304, 1)
' pixErodeCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixErodeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do compositely for each dimension  is greater  1.<para/>
'''
'''(4) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(5) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(6) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixErodeCompBrick(NULL, pixs, ...)
'''(b) pixErodeCompBrick(pixs, pixs, ...)
'''(c) pixErodeCompBrick(pixd, pixs, ...)<para/>
'''
'''(7) The dimensions of the resulting image are determined by pixs.<para/>
'''
'''(8) CAUTION: both hsize and vsize are being decomposed.
'''The decomposer chooses a product of sizes (call them
''''terms') for each that is close to the input size,
'''but not necessarily equal to it.  It attempts to optimize:
'''(a) for consistency with the input values: the product
'''of terms is close to the input size
'''(b) for efficiency of the operation: the sum of the
'''terms is small ideally about twice the square
'''root of the input size.
'''So, for example, if the input hsize = 37, which is
'''a prime number, the decomposer will break this into two
'''terms, 6 and 6, so that the net result is a dilation
'''with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeCompBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixErodeCompBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1395, 1)
' pixOpenCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixOpenCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do compositely for each dimension  is greater  1.<para/>
'''
'''(4) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(5) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(6) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixOpenCompBrick(NULL, pixs, ...)
'''(b) pixOpenCompBrick(pixs, pixs, ...)
'''(c) pixOpenCompBrick(pixd, pixs, ...)<para/>
'''
'''(7) The dimensions of the resulting image are determined by pixs.<para/>
'''
'''(8) CAUTION: both hsize and vsize are being decomposed.
'''The decomposer chooses a product of sizes (call them
''''terms') for each that is close to the input size,
'''but not necessarily equal to it.  It attempts to optimize:
'''(a) for consistency with the input values: the product
'''of terms is close to the input size
'''(b) for efficiency of the operation: the sum of the
'''terms is small ideally about twice the square
'''root of the input size.
'''So, for example, if the input hsize = 37, which is
'''a prime number, the decomposer will break this into two
'''terms, 6 and 6, so that the net result is a dilation
'''with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenCompBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixOpenCompBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1494, 1)
' pixCloseCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do compositely for each dimension  is greater  1.<para/>
'''
'''(4) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(5) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(6) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseCompBrick(NULL, pixs, ...)
'''(b) pixCloseCompBrick(pixs, pixs, ...)
'''(c) pixCloseCompBrick(pixd, pixs, ...)<para/>
'''
'''(7) The dimensions of the resulting image are determined by pixs.<para/>
'''
'''(8) CAUTION: both hsize and vsize are being decomposed.
'''The decomposer chooses a product of sizes (call them
''''terms') for each that is close to the input size,
'''but not necessarily equal to it.  It attempts to optimize:
'''(a) for consistency with the input values: the product
'''of terms is close to the input size
'''(b) for efficiency of the operation: the sum of the
'''terms is small ideally about twice the square
'''root of the input size.
'''So, for example, if the input hsize = 37, which is
'''a prime number, the decomposer will break this into two
'''terms, 6 and 6, so that the net result is a dilation
'''with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseCompBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseCompBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1598, 1)
' pixCloseSafeCompBrick(pixd, pixs, hsize, vsize) as Pix
' pixCloseSafeCompBrick(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) Sel is a brick with all elements being hits<para/>
'''
'''(2) The origin is at (x, y) = (hsize/2, vsize/2)<para/>
'''
'''(3) Do compositely for each dimension  is greater  1.<para/>
'''
'''(4) Do separably if both hsize and vsize are  is greater  1.<para/>
'''
'''(5) Safe closing adds a border of 0 pixels, of sufficient size so
'''that all pixels in input image are processed within
'''32-bit words in the expanded image.  As a result, there is
'''no special processing for pixels near the boundary, and there
'''are no boundary effects.  The border is removed at the end.<para/>
'''
'''(6) There are three cases:
'''(a) pixd == null (result into new pixd)
'''(b) pixd == pixs (in-place writes result back to pixs)
'''(c) pixd != pixs (puts result into existing pixd)<para/>
'''
'''(7) For clarity, if the case is known, use these patterns:
'''(a) pixd = pixCloseSafeCompBrick(NULL, pixs, ...)
'''(b) pixCloseSafeCompBrick(pixs, pixs, ...)
'''(c) pixCloseSafeCompBrick(pixd, pixs, ...)<para/>
'''
'''(8) The dimensions of the resulting image are determined by pixs.<para/>
'''
'''(9) CAUTION: both hsize and vsize are being decomposed.
'''The decomposer chooses a product of sizes (call them
''''terms') for each that is close to the input size,
'''but not necessarily equal to it.  It attempts to optimize:
'''(a) for consistency with the input values: the product
'''of terms is close to the input size
'''(b) for efficiency of the operation: the sum of the
'''terms is small ideally about twice the square
'''root of the input size.
'''So, for example, if the input hsize = 37, which is
'''a prime number, the decomposer will break this into two
'''terms, 6 and 6, so that the net result is a dilation
'''with hsize = 36.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseSafeCompBrick/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixCloseSafeCompBrick(pixdPtr, pixs.Pointer,   hsize,   vsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' morph.c (1687, 1)
' resetMorphBoundaryCondition(bc) as Object
' resetMorphBoundaryCondition(l_int32) as void
'''  <summary>
''' resetMorphBoundaryCondition()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/resetMorphBoundaryCondition/*"/>
'''  <param name="bc">[in] - SYMMETRIC_MORPH_BC, ASYMMETRIC_MORPH_BC</param>
Public Shared Sub resetMorphBoundaryCondition(
				ByVal bc as Enumerations.MMETRIC_MORPH_BC)


	Natives.resetMorphBoundaryCondition(  bc)
	
End Sub

' morph.c (1708, 1)
' getMorphBorderPixelColor(type, depth) as UInteger
' getMorphBorderPixelColor(l_int32, l_int32) as l_uint32
'''  <summary>
''' getMorphBorderPixelColor()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getMorphBorderPixelColor/*"/>
'''  <param name="type">[in] - L_MORPH_DILATE, L_MORPH_ERODE</param>
'''  <param name="depth">[in] - of pix</param>
'''   <returns>color of border pixels for this operation</returns>
Public Shared Function getMorphBorderPixelColor(
				ByVal type as Enumerations.L_MORPH, 
				ByVal depth as Integer) as UInteger


	Dim _Result as UInteger = Natives.getMorphBorderPixelColor(  type,   depth)
	
	return _Result
End Function

End Class


