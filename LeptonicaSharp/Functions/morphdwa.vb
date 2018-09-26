Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\morphdwa.c (175, 1)
' pixDilateBrickDwa()
' pixDilateBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement 2D brick Sels, using linear Sels generated
''' with selaAddBasic().
''' (2) A brick Sel has hits for all elements.
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (6) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (7) For clarity, if the case is known, use these patterns
''' (a) pixd = pixDilateBrickDwa(NULL, pixs, ...);
''' (b) pixDilateBrickDwa(pixs, pixs, ...);
''' (c) pixDilateBrickDwa(pixd, pixs, ...);
''' (8) The size of pixd is determined by pixs.
''' (9) If either linear Sel is not found, this calls
''' the appropriate decomposible function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (277, 1)
' pixErodeBrickDwa()
' pixErodeBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement 2D brick Sels, using linear Sels generated
''' with selaAddBasic().
''' (2) A brick Sel has hits for all elements.
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (6) Note that we must always set or clear the border pixels
''' before each operation, depending on the the b.c.
''' (symmetric or asymmetric).
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixErodeBrickDwa(NULL, pixs, ...);
''' (b) pixErodeBrickDwa(pixs, pixs, ...);
''' (c) pixErodeBrickDwa(pixd, pixs, ...);
''' (9) The size of the result is determined by pixs.
''' (10) If either linear Sel is not found, this calls
''' the appropriate decomposible function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (379, 1)
' pixOpenBrickDwa()
' pixOpenBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement 2D brick Sels, using linear Sels generated
''' with selaAddBasic().
''' (2) A brick Sel has hits for all elements.
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (4) Do separably if both hsize and vsize are GT 1.
''' (5) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (6) Note that we must always set or clear the border pixels
''' before each operation, depending on the the b.c.
''' (symmetric or asymmetric).
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpenBrickDwa(NULL, pixs, ...);
''' (b) pixOpenBrickDwa(pixs, pixs, ...);
''' (c) pixOpenBrickDwa(pixd, pixs, ...);
''' (9) The size of the result is determined by pixs.
''' (10) If either linear Sel is not found, this calls
''' the appropriate decomposible function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (486, 1)
' pixCloseBrickDwa()
' pixCloseBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a 'safe' closing; we add an extra border of 32 OFF
''' pixels for the standard asymmetric b.c.
''' (2) These implement 2D brick Sels, using linear Sels generated
''' with selaAddBasic().
''' (3) A brick Sel has hits for all elements.
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (5) Do separably if both hsize and vsize are GT 1.
''' (6) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (7) Note that we must always set or clear the border pixels
''' before each operation, depending on the the b.c.
''' (symmetric or asymmetric).
''' (8) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (9) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseBrickDwa(NULL, pixs, ...);
''' (b) pixCloseBrickDwa(pixs, pixs, ...);
''' (c) pixCloseBrickDwa(pixd, pixs, ...);
''' (10) The size of the result is determined by pixs.
''' (11) If either linear Sel is not found, this calls
''' the appropriate decomposible function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (613, 1)
' pixDilateCompBrickDwa()
' pixDilateCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement a separable composite dilation with 2D brick Sels.
''' (2) For efficiency, it may decompose each linear morphological
''' operation into two (brick + comb).
''' (3) A brick Sel has hits for all elements.
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (5) Do separably if both hsize and vsize are GT 1.
''' (6) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixDilateCompBrickDwa(NULL, pixs, ...);
''' (b) pixDilateCompBrickDwa(pixs, pixs, ...);
''' (c) pixDilateCompBrickDwa(pixd, pixs, ...);
''' (9) The size of pixd is determined by pixs.
''' (10) CAUTION both hsize and vsize are being decomposed.
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
'''   <returns>pixd</returns>
Public Shared Function pixDilateCompBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (746, 1)
' pixErodeCompBrickDwa()
' pixErodeCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement a separable composite erosion with 2D brick Sels.
''' (2) For efficiency, it may decompose each linear morphological
''' operation into two (brick + comb).
''' (3) A brick Sel has hits for all elements.
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (5) Do separably if both hsize and vsize are GT 1.
''' (6) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixErodeCompBrickDwa(NULL, pixs, ...);
''' (b) pixErodeCompBrickDwa(pixs, pixs, ...);
''' (c) pixErodeCompBrickDwa(pixd, pixs, ...);
''' (9) The size of pixd is determined by pixs.
''' (10) CAUTION both hsize and vsize are being decomposed.
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
'''   <returns>pixd</returns>
Public Shared Function pixErodeCompBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (875, 1)
' pixOpenCompBrickDwa()
' pixOpenCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) These implement a separable composite opening with 2D brick Sels.
''' (2) For efficiency, it may decompose each linear morphological
''' operation into two (brick + comb).
''' (3) A brick Sel has hits for all elements.
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (5) Do separably if both hsize and vsize are GT 1.
''' (6) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixOpenCompBrickDwa(NULL, pixs, ...);
''' (b) pixOpenCompBrickDwa(pixs, pixs, ...);
''' (c) pixOpenCompBrickDwa(pixd, pixs, ...);
''' (9) The size of pixd is determined by pixs.
''' (10) CAUTION both hsize and vsize are being decomposed.
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
'''   <returns>pixd</returns>
Public Shared Function pixOpenCompBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1042, 1)
' pixCloseCompBrickDwa()
' pixCloseCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This implements a separable composite safe closing with 2D
''' brick Sels.
''' (2) For efficiency, it may decompose each linear morphological
''' operation into two (brick + comb).
''' (3) A brick Sel has hits for all elements.
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)
''' (5) Do separably if both hsize and vsize are GT 1.
''' (6) It is necessary that both horizontal and vertical Sels
''' of the input size are defined in the basic sela.
''' (7) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (8) For clarity, if the case is known, use these patterns
''' (a) pixd = pixCloseCompBrickDwa(NULL, pixs, ...);
''' (b) pixCloseCompBrickDwa(pixs, pixs, ...);
''' (c) pixCloseCompBrickDwa(pixd, pixs, ...);
''' (9) The size of pixd is determined by pixs.
''' (10) CAUTION both hsize and vsize are being decomposed.
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
'''   <returns>pixd</returns>
Public Shared Function pixCloseCompBrickDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1192, 1)
' pixDilateCompBrickExtendDwa()
' pixDilateCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Ankur Jain suggested and implemented extending the composite
''' DWA operations beyond the 63 pixel limit.  This is a
''' simplified and approximate implementation of the extension.
''' This allows arbitrary Dwa morph operations using brick Sels,
''' by decomposing the horizontal and vertical dilations into
''' a sequence of 63-element dilations plus a dilation of size
''' between 3 and 62.
''' (2) The 63-element dilations are exact, whereas the extra dilation
''' is approximate, because the underlying decomposition is
''' in pixDilateCompBrickDwa().  See there for further details.
''' (3) There are three cases
''' (a) pixd == null   (result into new pixd)
''' (b) pixd == pixs   (in-place; writes result back to pixs)
''' (c) pixd != pixs   (puts result into existing pixd)
''' (4) There is no need to call this directly  pixDilateCompBrickDwa()
''' calls this function if either brick dimension exceeds 63.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateCompBrickExtendDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1312, 1)
' pixErodeCompBrickExtendDwa()
' pixErodeCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See pixDilateCompBrickExtendDwa() for usage.
''' (2) There is no need to call this directly  pixErodeCompBrickDwa()
''' calls this function if either brick dimension exceeds 63.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeCompBrickExtendDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1432, 1)
' pixOpenCompBrickExtendDwa()
' pixOpenCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd 1 There are three cases a) pixd == null   (result into new pixd b) pixd == pixs   (in-place; writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly  pixOpenCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
Public Shared Function pixOpenCompBrickExtendDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1473, 1)
' pixCloseCompBrickExtendDwa()
' pixCloseCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd 1 There are three cases a) pixd == null   (result into new pixd b) pixd == pixs   (in-place; writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly  pixCloseCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
Public Shared Function pixCloseCompBrickExtendDwa(
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1562, 1)
' getExtendedCompositeParameters()
' getExtendedCompositeParameters(l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The DWA implementation allows Sels to be used with hits
''' up to 31 pixels from the origin, either horizontally or
''' vertically.  Larger Sels can be used if decomposed into
''' a set of operations with Sels not exceeding 63 pixels
''' in either width or height (and with the origin as close
''' to the center of the Sel as possible).
''' (2) This returns the decomposition of a linear Sel of length
''' %size into a set of %n Sels of length 63 plus an extra
''' Sel of length %extra.
''' (3) For notation, let w == %size, n == %n, and e == %extra.
''' We have 1 LT e LT 63.
''' Then if w LT 64, we have n = 0 and e = w.
''' The general formula for w GT 63 is
''' w = 63 + (n - 1)  62 + (e - 1)
''' Where did this come from?  Each successive convolution with
''' a Sel of length L adds a total length (L - 1) to w.
''' This accounts for using 62 for each additional Sel of size 63,
''' and using (e - 1) for the additional Sel of size e.
''' Solving for n and e for w GT 63
''' n = 1 + Int((w - 63) / 62)
''' e = w - 63 - (n - 1)  62 + 1
''' The extra part is decomposed into two factors f1 and f2,
''' and the actual size of the extra part is
''' e' = f1  f2
''' Then the actual width is
''' w' = 63 + (n - 1)  62 + f1  f2 - 1
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="size">[in] - of linear Sel</param>
'''  <param name="pn">[out] - number of 63 wide convolutions</param>
'''  <param name="pextra">[out] - size of extra Sel</param>
'''  <param name="pactualsize">[out][optional] - actual size used in operation</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function getExtendedCompositeParameters(
				ByVal size as Integer, 
				ByRef pn as Integer, 
				ByRef pextra as Integer, 
				Optional ByRef pactualsize as Integer = Nothing) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.getExtendedCompositeParameters( size, pn, pextra, pactualsize)

	Return _Result
End Function

End Class
