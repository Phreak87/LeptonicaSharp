using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// morphdwa.c (175, 1)
// pixDilateBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixDilateBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement 2D brick Sels, using linear Sels generated
/// with selaAddBasic().<para/>
/// 
/// (2) A brick Sel has hits for all elements.<para/>
/// 
/// (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (4) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (5) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (6) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (7) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixDilateBrickDwa(NULL, pixs, ...)
/// (b) pixDilateBrickDwa(pixs, pixs, ...)
/// (c) pixDilateBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (8) The size of pixd is determined by pixs.<para/>
/// 
/// (9) If either linear Sel is not found, this calls
/// the appropriate decomposible function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixDilateBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixDilateBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (277, 1)
// pixErodeBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixErodeBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement 2D brick Sels, using linear Sels generated
/// with selaAddBasic().<para/>
/// 
/// (2) A brick Sel has hits for all elements.<para/>
/// 
/// (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (4) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (5) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (6) Note that we must always set or clear the border pixels
/// before each operation, depending on the the b.c.
/// (symmetric or asymmetric).<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixErodeBrickDwa(NULL, pixs, ...)
/// (b) pixErodeBrickDwa(pixs, pixs, ...)
/// (c) pixErodeBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of the result is determined by pixs.<para/>
/// 
/// (10) If either linear Sel is not found, this calls
/// the appropriate decomposible function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixErodeBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixErodeBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (379, 1)
// pixOpenBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixOpenBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement 2D brick Sels, using linear Sels generated
/// with selaAddBasic().<para/>
/// 
/// (2) A brick Sel has hits for all elements.<para/>
/// 
/// (3) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (4) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (5) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (6) Note that we must always set or clear the border pixels
/// before each operation, depending on the the b.c.
/// (symmetric or asymmetric).<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixOpenBrickDwa(NULL, pixs, ...)
/// (b) pixOpenBrickDwa(pixs, pixs, ...)
/// (c) pixOpenBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of the result is determined by pixs.<para/>
/// 
/// (10) If either linear Sel is not found, this calls
/// the appropriate decomposible function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixOpenBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixOpenBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (486, 1)
// pixCloseBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixCloseBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a 'safe' closing we add an extra border of 32 OFF
/// pixels for the standard asymmetric b.c.<para/>
/// 
/// (2) These implement 2D brick Sels, using linear Sels generated
/// with selaAddBasic().<para/>
/// 
/// (3) A brick Sel has hits for all elements.<para/>
/// 
/// (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (5) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (6) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (7) Note that we must always set or clear the border pixels
/// before each operation, depending on the the b.c.
/// (symmetric or asymmetric).<para/>
/// 
/// (8) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (9) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixCloseBrickDwa(NULL, pixs, ...)
/// (b) pixCloseBrickDwa(pixs, pixs, ...)
/// (c) pixCloseBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (10) The size of the result is determined by pixs.<para/>
/// 
/// (11) If either linear Sel is not found, this calls
/// the appropriate decomposible function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixCloseBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixCloseBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (613, 1)
// pixDilateCompBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixDilateCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement a separable composite dilation with 2D brick Sels.<para/>
/// 
/// (2) For efficiency, it may decompose each linear morphological
/// operation into two (brick + comb).<para/>
/// 
/// (3) A brick Sel has hits for all elements.<para/>
/// 
/// (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (5) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (6) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixDilateCompBrickDwa(NULL, pixs, ...)
/// (b) pixDilateCompBrickDwa(pixs, pixs, ...)
/// (c) pixDilateCompBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of pixd is determined by pixs.<para/>
/// 
/// (10) CAUTION: both hsize and vsize are being decomposed.
/// The decomposer chooses a product of sizes (call them
/// 'terms') for each that is close to the input size,
/// but not necessarily equal to it.  It attempts to optimize:
/// (a) for consistency with the input values: the product
/// of terms is close to the input size
/// (b) for efficiency of the operation: the sum of the
/// terms is small ideally about twice the square
/// root of the input size.
/// So, for example, if the input hsize = 37, which is
/// a prime number, the decomposer will break this into two
/// terms, 6 and 6, so that the net result is a dilation
/// with hsize = 36.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateCompBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixDilateCompBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixDilateCompBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (746, 1)
// pixErodeCompBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixErodeCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement a separable composite erosion with 2D brick Sels.<para/>
/// 
/// (2) For efficiency, it may decompose each linear morphological
/// operation into two (brick + comb).<para/>
/// 
/// (3) A brick Sel has hits for all elements.<para/>
/// 
/// (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (5) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (6) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixErodeCompBrickDwa(NULL, pixs, ...)
/// (b) pixErodeCompBrickDwa(pixs, pixs, ...)
/// (c) pixErodeCompBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of pixd is determined by pixs.<para/>
/// 
/// (10) CAUTION: both hsize and vsize are being decomposed.
/// The decomposer chooses a product of sizes (call them
/// 'terms') for each that is close to the input size,
/// but not necessarily equal to it.  It attempts to optimize:
/// (a) for consistency with the input values: the product
/// of terms is close to the input size
/// (b) for efficiency of the operation: the sum of the
/// terms is small ideally about twice the square
/// root of the input size.
/// So, for example, if the input hsize = 37, which is
/// a prime number, the decomposer will break this into two
/// terms, 6 and 6, so that the net result is a dilation
/// with hsize = 36.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeCompBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixErodeCompBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixErodeCompBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (875, 1)
// pixOpenCompBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixOpenCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) These implement a separable composite opening with 2D brick Sels.<para/>
/// 
/// (2) For efficiency, it may decompose each linear morphological
/// operation into two (brick + comb).<para/>
/// 
/// (3) A brick Sel has hits for all elements.<para/>
/// 
/// (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (5) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (6) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixOpenCompBrickDwa(NULL, pixs, ...)
/// (b) pixOpenCompBrickDwa(pixs, pixs, ...)
/// (c) pixOpenCompBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of pixd is determined by pixs.<para/>
/// 
/// (10) CAUTION: both hsize and vsize are being decomposed.
/// The decomposer chooses a product of sizes (call them
/// 'terms') for each that is close to the input size,
/// but not necessarily equal to it.  It attempts to optimize:
/// (a) for consistency with the input values: the product
/// of terms is close to the input size
/// (b) for efficiency of the operation: the sum of the
/// terms is small ideally about twice the square
/// root of the input size.
/// So, for example, if the input hsize = 37, which is
/// a prime number, the decomposer will break this into two
/// terms, 6 and 6, so that the net result is a dilation
/// with hsize = 36.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenCompBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixOpenCompBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixOpenCompBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1042, 1)
// pixCloseCompBrickDwa(pixd, pixs, hsize, vsize) as Pix
// pixCloseCompBrickDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This implements a separable composite safe closing with 2D
/// brick Sels.<para/>
/// 
/// (2) For efficiency, it may decompose each linear morphological
/// operation into two (brick + comb).<para/>
/// 
/// (3) A brick Sel has hits for all elements.<para/>
/// 
/// (4) The origin of the Sel is at (x, y) = (hsize/2, vsize/2)<para/>
/// 
/// (5) Do separably if both hsize and vsize are  is greater  1.<para/>
/// 
/// (6) It is necessary that both horizontal and vertical Sels
/// of the input size are defined in the basic sela.<para/>
/// 
/// (7) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (8) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixCloseCompBrickDwa(NULL, pixs, ...)
/// (b) pixCloseCompBrickDwa(pixs, pixs, ...)
/// (c) pixCloseCompBrickDwa(pixd, pixs, ...)<para/>
/// 
/// (9) The size of pixd is determined by pixs.<para/>
/// 
/// (10) CAUTION: both hsize and vsize are being decomposed.
/// The decomposer chooses a product of sizes (call them
/// 'terms') for each that is close to the input size,
/// but not necessarily equal to it.  It attempts to optimize:
/// (a) for consistency with the input values: the product
/// of terms is close to the input size
/// (b) for efficiency of the operation: the sum of the
/// terms is small ideally about twice the square
/// root of the input size.
/// So, for example, if the input hsize = 37, which is
/// a prime number, the decomposer will break this into two
/// terms, 6 and 6, so that the net result is a dilation
/// with hsize = 36.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseCompBrickDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixCloseCompBrickDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixCloseCompBrickDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1192, 1)
// pixDilateCompBrickExtendDwa(pixd, pixs, hsize, vsize) as Pix
// pixDilateCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Ankur Jain suggested and implemented extending the composite
/// DWA operations beyond the 63 pixel limit.  This is a
/// simplified and approximate implementation of the extension.
/// This allows arbitrary Dwa morph operations using brick Sels,
/// by decomposing the horizontal and vertical dilations into
/// a sequence of 63-element dilations plus a dilation of size
/// between 3 and 62.<para/>
/// 
/// (2) The 63-element dilations are exact, whereas the extra dilation
/// is approximate, because the underlying decomposition is
/// in pixDilateCompBrickDwa().  See there for further details.<para/>
/// 
/// (3) There are three cases:
/// (a) pixd == null (result into new pixd)
/// (b) pixd == pixs (in-place writes result back to pixs)
/// (c) pixd != pixs (puts result into existing pixd)<para/>
/// 
/// (4) There is no need to call this directly:  pixDilateCompBrickDwa()
/// calls this function if either brick dimension exceeds 63.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDilateCompBrickExtendDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixDilateCompBrickExtendDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixDilateCompBrickExtendDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1312, 1)
// pixErodeCompBrickExtendDwa(pixd, pixs, hsize, vsize) as Pix
// pixErodeCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See pixDilateCompBrickExtendDwa() for usage.<para/>
/// 
/// (2) There is no need to call this directly:  pixErodeCompBrickDwa()
/// calls this function if either brick dimension exceeds 63.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixErodeCompBrickExtendDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd</returns>
public static Pix pixErodeCompBrickExtendDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixErodeCompBrickExtendDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1432, 1)
// pixOpenCompBrickExtendDwa(pixd, pixs, hsize, vsize) as Pix
// pixOpenCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOpenCompBrickExtendDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd 1 There are three cases: a) pixd == null   (result into new pixd b) pixd == pixs   (in-place writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly:  pixOpenCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
public static Pix pixOpenCompBrickExtendDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixOpenCompBrickExtendDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1473, 1)
// pixCloseCompBrickExtendDwa(pixd, pixs, hsize, vsize) as Pix
// pixCloseCompBrickExtendDwa(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCloseCompBrickExtendDwa/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="hsize">[in] - width of brick Sel</param>
///  <param name="vsize">[in] - height of brick Sel</param>
///   <returns>pixd 1 There are three cases: a) pixd == null   (result into new pixd b) pixd == pixs   (in-place writes result back to pixs c) pixd != pixs   (puts result into existing pixd 2) There is no need to call this directly:  pixCloseCompBrickDwa( calls this function if either brick dimension exceeds 63.</returns>
public static Pix pixCloseCompBrickExtendDwa(
				  Pix pixd, 
				  Pix pixs, 
				  int hsize, 
				  int vsize){

	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixCloseCompBrickExtendDwa(pixdPtr, pixs.Pointer,   hsize,   vsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphdwa.c (1562, 1)
// getExtendedCompositeParameters(size, pn, pextra, pactualsize) as int
// getExtendedCompositeParameters(l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) The DWA implementation allows Sels to be used with hits
/// up to 31 pixels from the origin, either horizontally or
/// vertically.  Larger Sels can be used if decomposed into
/// a set of operations with Sels not exceeding 63 pixels
/// in either width or height (and with the origin as close
/// to the center of the Sel as possible).<para/>
/// 
/// (2) This returns the decomposition of a linear Sel of length
/// %size into a set of %n Sels of length 63 plus an extra
/// Sel of length %extra.<para/>
/// 
/// (3) For notation, let w == %size, n == %n, and e == %extra.
/// We have 1  is smaller e  is smaller 63.
/// Then if w  is smaller 64, we have n = 0 and e = w.
/// The general formula for w  is greater  63 is:
/// w = 63 + (n - 1)  62 + (e - 1)
/// Where did this come from?  Each successive convolution with
/// a Sel of length L adds a total length (L - 1) to w.
/// This accounts for using 62 for each additional Sel of size 63,
/// and using (e - 1) for the additional Sel of size e.
/// Solving for n and e for w  is greater  63:
/// n = 1 + Int((w - 63) / 62)
/// e = w - 63 - (n - 1)  62 + 1
/// The extra part is decomposed into two factors f1 and f2,
/// and the actual size of the extra part is
/// e' = f1  f2
/// Then the actual width is:
/// w' = 63 + (n - 1)  62 + f1  f2 - 1
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getExtendedCompositeParameters/*"/>
///  <param name="size">[in] - of linear Sel</param>
///  <param name="pn">[out] - number of 63 wide convolutions</param>
///  <param name="pextra">[out] - size of extra Sel</param>
///  <param name="pactualsize">[out][optional] - actual size used in operation</param>
///   <returns>0 if OK, 1 on error</returns>
public static int getExtendedCompositeParameters(
				  int size, 
				 out int pn, 
				 out int pextra, 
				out int pactualsize){

	int _Result = Natives.getExtendedCompositeParameters(  size, out  pn, out  pextra, out  pactualsize);
	

pn = 0;
pextra = 0;
pactualsize = 0;


	return _Result;
}

}
