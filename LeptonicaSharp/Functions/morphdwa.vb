Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\morphdwa.c (175, 1)
' pixDilateBrickDwa()
' pixDilateBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement 2D brick Sels, using linear Sels generated<para/>
''' with selaAddBasic().<para/>
''' (2) A brick Sel has hits for all elements.<para/>
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (6) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (7) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixDilateBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixDilateBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixDilateBrickDwa(pixd, pixs, ...)<para/>
''' (8) The size of pixd is determined by pixs.<para/>
''' (9) If either linear Sel is not found, this calls<para/>
''' the appropriate decomposible function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (277, 1)
' pixErodeBrickDwa()
' pixErodeBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement 2D brick Sels, using linear Sels generated<para/>
''' with selaAddBasic().<para/>
''' (2) A brick Sel has hits for all elements.<para/>
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (6) Note that we must always set or clear the border pixels<para/>
''' before each operation, depending on the the b.c.<para/>
''' (symmetric or asymmetric).<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixErodeBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixErodeBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixErodeBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of the result is determined by pixs.<para/>
''' (10) If either linear Sel is not found, this calls<para/>
''' the appropriate decomposible function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (379, 1)
' pixOpenBrickDwa()
' pixOpenBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement 2D brick Sels, using linear Sels generated<para/>
''' with selaAddBasic().<para/>
''' (2) A brick Sel has hits for all elements.<para/>
''' (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (4) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (5) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (6) Note that we must always set or clear the border pixels<para/>
''' before each operation, depending on the the b.c.<para/>
''' (symmetric or asymmetric).<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpenBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixOpenBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixOpenBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of the result is determined by pixs.<para/>
''' (10) If either linear Sel is not found, this calls<para/>
''' the appropriate decomposible function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixOpenBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (486, 1)
' pixCloseBrickDwa()
' pixCloseBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a 'safe' closing we add an extra border of 32 OFF<para/>
''' pixels for the standard asymmetric b.c.<para/>
''' (2) These implement 2D brick Sels, using linear Sels generated<para/>
''' with selaAddBasic().<para/>
''' (3) A brick Sel has hits for all elements.<para/>
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (5) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (6) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (7) Note that we must always set or clear the border pixels<para/>
''' before each operation, depending on the the b.c.<para/>
''' (symmetric or asymmetric).<para/>
''' (8) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (9) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixCloseBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixCloseBrickDwa(pixd, pixs, ...)<para/>
''' (10) The size of the result is determined by pixs.<para/>
''' (11) If either linear Sel is not found, this calls<para/>
''' the appropriate decomposible function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixCloseBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (613, 1)
' pixDilateCompBrickDwa()
' pixDilateCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement a separable composite dilation with 2D brick Sels.<para/>
''' (2) For efficiency, it may decompose each linear morphological<para/>
''' operation into two (brick + comb).<para/>
''' (3) A brick Sel has hits for all elements.<para/>
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (5) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (6) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixDilateCompBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixDilateCompBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixDilateCompBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of pixd is determined by pixs.<para/>
''' (10) CAUTION: both hsize and vsize are being decomposed.<para/>
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
'''   <returns>pixd</returns>
Public Shared Function pixDilateCompBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (746, 1)
' pixErodeCompBrickDwa()
' pixErodeCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement a separable composite erosion with 2D brick Sels.<para/>
''' (2) For efficiency, it may decompose each linear morphological<para/>
''' operation into two (brick + comb).<para/>
''' (3) A brick Sel has hits for all elements.<para/>
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (5) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (6) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixErodeCompBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixErodeCompBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixErodeCompBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of pixd is determined by pixs.<para/>
''' (10) CAUTION: both hsize and vsize are being decomposed.<para/>
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
'''   <returns>pixd</returns>
Public Shared Function pixErodeCompBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (875, 1)
' pixOpenCompBrickDwa()
' pixOpenCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These implement a separable composite opening with 2D brick Sels.<para/>
''' (2) For efficiency, it may decompose each linear morphological<para/>
''' operation into two (brick + comb).<para/>
''' (3) A brick Sel has hits for all elements.<para/>
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (5) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (6) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixOpenCompBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixOpenCompBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixOpenCompBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of pixd is determined by pixs.<para/>
''' (10) CAUTION: both hsize and vsize are being decomposed.<para/>
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
'''   <returns>pixd</returns>
Public Shared Function pixOpenCompBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1042, 1)
' pixCloseCompBrickDwa()
' pixCloseCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This implements a separable composite safe closing with 2D<para/>
''' brick Sels.<para/>
''' (2) For efficiency, it may decompose each linear morphological<para/>
''' operation into two (brick + comb).<para/>
''' (3) A brick Sel has hits for all elements.<para/>
''' (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
''' (5) Do separably if both hsize and vsize are  is greater  1.<para/>
''' (6) It is necessary that both horizontal and vertical Sels<para/>
''' of the input size are defined in the basic sela.<para/>
''' (7) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (8) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixCloseCompBrickDwa(NULL, pixs, ...)<para/>
''' (b) pixCloseCompBrickDwa(pixs, pixs, ...)<para/>
''' (c) pixCloseCompBrickDwa(pixd, pixs, ...)<para/>
''' (9) The size of pixd is determined by pixs.<para/>
''' (10) CAUTION: both hsize and vsize are being decomposed.<para/>
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
'''   <returns>pixd</returns>
Public Shared Function pixCloseCompBrickDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrickDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1192, 1)
' pixDilateCompBrickExtendDwa()
' pixDilateCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Ankur Jain suggested and implemented extending the composite<para/>
''' DWA operations beyond the 63 pixel limit.  This is a<para/>
''' simplified and approximate implementation of the extension.<para/>
''' This allows arbitrary Dwa morph operations using brick Sels,<para/>
''' by decomposing the horizontal and vertical dilations into<para/>
''' a sequence of 63-element dilations plus a dilation of size<para/>
''' between 3 and 62.<para/>
''' (2) The 63-element dilations are exact, whereas the extra dilation<para/>
''' is approximate, because the underlying decomposition is<para/>
''' in pixDilateCompBrickDwa().  See there for further details.<para/>
''' (3) There are three cases:<para/>
''' (a) pixd == null (result into new pixd)<para/>
''' (b) pixd == pixs (in-place writes result back to pixs)<para/>
''' (c) pixd != pixs (puts result into existing pixd)<para/>
''' (4) There is no need to call this directly:  pixDilateCompBrickDwa()<para/>
''' calls this function if either brick dimension exceeds 63.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixDilateCompBrickExtendDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDilateCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1312, 1)
' pixErodeCompBrickExtendDwa()
' pixErodeCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixDilateCompBrickExtendDwa() for usage.<para/>
''' (2) There is no need to call this directly:  pixErodeCompBrickDwa()<para/>
''' calls this function if either brick dimension exceeds 63.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd</returns>
Public Shared Function pixErodeCompBrickExtendDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixErodeCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1432, 1)
' pixOpenCompBrickExtendDwa()
' pixOpenCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd 1 There are three cases: a) pixd == null   (result into new pixd b) pixd == pixs   (in-place writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly:  pixOpenCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
Public Shared Function pixOpenCompBrickExtendDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOpenCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1473, 1)
' pixCloseCompBrickExtendDwa()
' pixCloseCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="hsize">[in] - width of brick Sel</param>
'''  <param name="vsize">[in] - height of brick Sel</param>
'''   <returns>pixd 1 There are three cases: a) pixd == null   (result into new pixd b) pixd == pixs   (in-place writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly:  pixCloseCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
Public Shared Function pixCloseCompBrickExtendDwa(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal hsize as Integer, 
				ByVal vsize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCloseCompBrickExtendDwa( pixdPTR, pixs.Pointer, hsize, vsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphdwa.c (1562, 1)
' getExtendedCompositeParameters()
' getExtendedCompositeParameters(l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The DWA implementation allows Sels to be used with hits<para/>
''' up to 31 pixels from the origin, either horizontally or<para/>
''' vertically.  Larger Sels can be used if decomposed into<para/>
''' a set of operations with Sels not exceeding 63 pixels<para/>
''' in either width or height (and with the origin as close<para/>
''' to the center of the Sel as possible).<para/>
''' (2) This returns the decomposition of a linear Sel of length<para/>
''' %size into a set of %n Sels of length 63 plus an extra<para/>
''' Sel of length %extra.<para/>
''' (3) For notation, let w == %size, n == %n, and e == %extra.<para/>
''' We have 1  is lower  e  is lower  63.<para/>
''' Then if w  is lower  64, we have n = 0 and e = w.<para/>
''' The general formula for w  is greater  63 is:<para/>
''' w = 63 + (n - 1)  62 + (e - 1)<para/>
''' Where did this come from?  Each successive convolution with<para/>
''' a Sel of length L adds a total length (L - 1) to w.<para/>
''' This accounts for using 62 for each additional Sel of size 63,<para/>
''' and using (e - 1) for the additional Sel of size e.<para/>
''' Solving for n and e for w  is greater  63:<para/>
''' n = 1 + Int((w - 63) / 62)<para/>
''' e = w - 63 - (n - 1)  62 + 1<para/>
''' The extra part is decomposed into two factors f1 and f2,<para/>
''' and the actual size of the extra part is<para/>
''' e' = f1  f2<para/>
''' Then the actual width is:<para/>
''' w' = 63 + (n - 1)  62 + f1  f2 - 1<para/>
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
				ByRef pactualsize as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.getExtendedCompositeParameters( size, pn, pextra, pactualsize)

	Return _Result
End Function

End Class
