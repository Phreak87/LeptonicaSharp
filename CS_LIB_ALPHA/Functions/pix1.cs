using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (282, 1)
// setPixMemoryManager(allocator, deallocator) as Object
// setPixMemoryManager(alloc_fn, dealloc_fn) as void
///  <summary>
/// (1) Use this to change the alloc and/or dealloc functions
/// e.g., setPixMemoryManager(my_malloc, my_free).<para/>
/// 
/// (2) The C99 standard (section 6.7.5.3, par. 8) says:
/// A declaration of a parameter as "function returning type"
/// shall be adjusted to "pointer to function returning type"
/// so that it can be in either of these two forms:
/// (a) type (function-ptr(type, ...))
/// (b) type ((function-ptr)(type, ...))
/// because form (a) is implictly converted to form (b), as in the
/// definition of struct PixMemoryManager above.  So, for example,
/// we should be able to declare either of these:
/// (a) void (allocator(size_t))
/// (b) void ((allocator)(size_t))
/// However, MSVC++ only accepts the second version.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/setPixMemoryManager/*"/>
///  <param name="allocator">[in][optional] - use NULL to skip</param>
///  <param name="deallocator">[in][optional] - use NULL to skip</param>

public static void setPixMemoryManager(
				 IntPtr allocator, 
				 IntPtr deallocator){



	Natives.setPixMemoryManager(
  allocator,   deallocator);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (302, 1)
// pixCreate(width, height, depth) as Pix
// pixCreate(l_int32, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreate/*"/>
///  <param name="width">[in] - </param>
///  <param name="height">[in] - </param>
///  <param name="depth">[in] - </param>
///   <returns>pixd with data allocated and initialized to 0, or NULL on error</returns>

public static Pix pixCreate(
				 int width, 
				 int height, 
				 int depth){



	IntPtr _Result = Natives.pixCreate(
  width,   height,   depth);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (331, 1)
// pixCreateNoInit(width, height, depth) as Pix
// pixCreateNoInit(l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Must set pad bits to avoid reading uninitialized data, because
/// some optimized routines (e.g., pixConnComp()) read from pad bits.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateNoInit/*"/>
///  <param name="width">[in] - </param>
///  <param name="height">[in] - </param>
///  <param name="depth">[in] - </param>
///   <returns>pixd with data allocated but not initialized, or NULL on error</returns>

public static Pix pixCreateNoInit(
				 int width, 
				 int height, 
				 int depth){



	IntPtr _Result = Natives.pixCreateNoInit(
  width,   height,   depth);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (367, 1)
// pixCreateTemplate(pixs) as Pix
// pixCreateTemplate(PIX *) as PIX *
///  <summary>
/// (1) Makes a Pix of the same size as the input Pix, with the
/// data array allocated and initialized to 0.<para/>
/// 
/// (2) Copies the other fields, including colormap if it exists.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateTemplate/*"/>
///  <param name="pixs">[in] - </param>
///   <returns>pixd, or NULL on error</returns>

public static Pix pixCreateTemplate(
				 Pix pixs){



	IntPtr _Result = Natives.pixCreateTemplate(
pixs.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (397, 1)
// pixCreateTemplateNoInit(pixs) as Pix
// pixCreateTemplateNoInit(PIX *) as PIX *
///  <summary>
/// (1) Makes a Pix of the same size as the input Pix, with
/// the data array allocated but not initialized to 0.<para/>
/// 
/// (2) Copies the other fields, including colormap if it exists.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateTemplateNoInit/*"/>
///  <param name="pixs">[in] - </param>
///   <returns>pixd, or NULL on error</returns>

public static Pix pixCreateTemplateNoInit(
				 Pix pixs){



	IntPtr _Result = Natives.pixCreateTemplateNoInit(
pixs.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (439, 1)
// pixCreateHeader(width, height, depth) as Pix
// pixCreateHeader(l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) It is assumed that all 32 bit pix have 3 spp.  If there is
/// a valid alpha channel, this will be set to 4 spp later.<para/>
/// 
/// (2) If the number of bytes to be allocated is larger than the
/// maximum value in an int32, we can get overflow, resulting
/// in a smaller amount of memory actually being allocated.
/// Later, an attempt to access memory that wasn't allocated will
/// cause a crash.  So to avoid crashing a program (or worse)
/// with bad (or malicious) input, this is where we limit the
/// requested allocation of image data in a typesafe way.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateHeader/*"/>
///  <param name="width">[in] - </param>
///  <param name="height">[in] - </param>
///  <param name="depth">[in] - </param>
///   <returns>pixd with no data allocated, or NULL on error</returns>

public static Pix pixCreateHeader(
				 int width, 
				 int height, 
				 int depth){



	IntPtr _Result = Natives.pixCreateHeader(
  width,   height,   depth);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (517, 1)
// pixClone(pixs) as Pix
// pixClone(PIX *) as PIX *
///  <summary>
/// (1) A "clone" is simply a handle (ptr) to an existing pix.
/// It is implemented because (a) images can be large and
/// hence expensive to copy, and (b) extra handles to a data
/// structure need to be made with a simple policy to avoid
/// both double frees and memory leaks.  Pix are reference
/// counted.  The side effect of pixClone() is an increase
/// by 1 in the ref count.<para/>
/// 
/// (2) The protocol to be used is:
/// (a) Whenever you want a new handle to an existing image,
/// call pixClone(), which just bumps a ref count.
/// (b) Always call pixDestroy() on all handles.  This
/// decrements the ref count, nulls the handle, and
/// only destroys the pix when pixDestroy() has been
/// called on all handles.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClone/*"/>
///  <param name="pixs">[in] - </param>
///   <returns>same pix ptr, or NULL on error</returns>

public static Pix pixClone(
				 Pix pixs){



	IntPtr _Result = Natives.pixClone(
pixs.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (545, 1)
// pixDestroy(ppix) as Object
// pixDestroy(PIX **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the pix.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDestroy/*"/>
///  <param name="ppix">[in,out] - will be nulled</param>

public static void pixDestroy(
				ref Pix ppix){


	IntPtr ppixPtr = IntPtr.Zero; 	if (ppix != null) {ppixPtr = ppix.Pointer;}

	Natives.pixDestroy(
ref ppixPtr);
	


//  
	if (ppixPtr == IntPtr.Zero) {ppix = null;} else { ppix = new Pix(ppixPtr); };



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (630, 1)
// pixCopy(pixd, pixs) as Pix
// pixCopy(PIX *, PIX *) as PIX *
///  <summary>
/// (1) There are three cases:
/// (a) pixd == null  (makes a new pix refcount = 1)
/// (b) pixd == pixs  (no-op)
/// (c) pixd != pixs  (data copy no change in refcount)
/// If the refcount of pixd  is greater  1, case (c) will side-effect
/// these handles.<para/>
/// 
/// (2) The general pattern of use is:
/// pixd = pixCopy(pixd, pixs)
/// This will work for all three cases.
/// For clarity when the case is known, you can use:
/// (a) pixd = pixCopy(NULL, pixs)
/// (c) pixCopy(pixd, pixs)<para/>
/// 
/// (3) For case (c), we check if pixs and pixd are the same
/// size (w,h,d).  If so, the data is copied directly.
/// Otherwise, the data is reallocated to the correct size
/// and the copy proceeds.  The refcount of pixd is unchanged.<para/>
/// 
/// (4) This operation, like all others that may involve a pre-existing
/// pixd, will side-effect any existing clones of pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopy/*"/>
///  <param name="pixd">[in][optional] - can be null, equal to pixs, different from pixs</param>
///  <param name="pixs">[in] - </param>
///   <returns>pixd, or NULL on error</returns>

public static Pix pixCopy(
				 Pix pixd, 
				 Pix pixs){


	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixCopy(
pixdPtr, pixs.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (698, 1)
// pixResizeImageData(pixd, pixs) as int
// pixResizeImageData(PIX *, PIX *) as l_ok
///  <summary>
/// (1) If the sizes of data in pixs and pixd are unequal, this
/// frees the existing image data in pixd and allocates
/// an uninitialized buffer that will hold the required amount
/// of image data in pixs.  The image data from pixs is not
/// copied into the new buffer.<para/>
/// 
/// (2) On failure to allocate, pixd is unchanged.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixResizeImageData/*"/>
///  <param name="pixd">[in] - gets new uninitialized buffer for image data</param>
///  <param name="pixs">[in] - determines the size of the buffer not changed</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixResizeImageData(
				 Pix pixd, 
				 Pix pixs){



	int _Result = Natives.pixResizeImageData(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (747, 1)
// pixCopyColormap(pixd, pixs) as int
// pixCopyColormap(PIX *, PIX *) as l_ok
///  <summary>
/// (1) This always destroys any colormap in pixd (except if
/// the operation is a no-op.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyColormap/*"/>
///  <param name="pixd">[in] - </param>
///  <param name="pixs">[in] - copies the colormap to %pixd</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixCopyColormap(
				 Pix pixd, 
				 Pix pixs){



	int _Result = Natives.pixCopyColormap(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (780, 1)
// pixSizesEqual(pix1, pix2) as int
// pixSizesEqual(PIX *, PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSizesEqual/*"/>
///  <param name="pix1">[in] - </param>
///  <param name="pix2">[in] - </param>
///   <returns>1 if the two pix have same {h, w, d} 0 otherwise.</returns>

public static int pixSizesEqual(
				 Pix pix1, 
				 Pix pix2){



	int _Result = Natives.pixSizesEqual(
pix1.Pointer, pix2.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (854, 1)
// pixTransferAllData(pixd, ppixs, copytext, copyformat) as int
// pixTransferAllData(PIX *, PIX **, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This does a complete data transfer from pixs to pixd,
/// followed by the destruction of pixs (refcount permitting).<para/>
/// 
/// (2) If the refcount of pixs is 1, pixs is destroyed.  Otherwise,
/// the data in pixs is copied (rather than transferred) to pixd.<para/>
/// 
/// (3) This operation, like all others with a pre-existing pixd,
/// will side-effect any existing clones of pixd.  The pixd
/// refcount does not change.<para/>
/// 
/// (4) When might you use this?  Suppose you have an in-place Pix
/// function (returning void) with the typical signature:
/// void function-inplace(PIX pix, ...)
/// where "..." are non-pointer input parameters, and suppose
/// further that you sometimes want to return an arbitrary Pix
/// in place of the input Pix.  There are two ways you can do this:
/// (a) The straightforward way is to change the function
/// signature to take the address of the Pix ptr:
/// \code
/// void function-inplace(PIX ppix, ...) {
/// PIX pixt = function-makenew(ppix)
/// pixDestroy(ppix)
/// ppix = pixt
/// return
/// }
/// \endcode
/// Here, the input and returned pix are different, as viewed
/// by the calling function, and the inplace function is
/// expected to destroy the input pix to avoid a memory leak.
/// (b) Keep the signature the same and use pixTransferAllData()
/// to return the new Pix in the input Pix struct:
/// \code
/// void function-inplace(PIX pix, ...) {
/// PIX pixt = function-makenew(pix)
/// pixTransferAllData(pix, [and]pixt, 0, 0)
/// // pixDestroy() is called on pixt
/// return
/// }
/// \endcode
/// Here, the input and returned pix are the same, as viewed
/// by the calling function, and the inplace function must
/// never destroy the input pix, because the calling function
/// maintains an unchanged handle to it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTransferAllData/*"/>
///  <param name="pixd">[in] - must be different from pixs</param>
///  <param name="ppixs">[in,out] - will be nulled if refcount goes to 0</param>
///  <param name="copytext">[in] - 1 to copy the text field 0 to skip</param>
///  <param name="copyformat">[in] - 1 to copy the informat field 0 to skip</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixTransferAllData(
				 Pix pixd, 
				ref Pix ppixs, 
				 int copytext, 
				 int copyformat){


	IntPtr ppixsPtr = IntPtr.Zero; 	if (ppixs != null) {ppixsPtr = ppixs.Pointer;}

	int _Result = Natives.pixTransferAllData(
pixd.Pointer, ref ppixsPtr,   copytext,   copyformat);
	


//  
	if (ppixsPtr == IntPtr.Zero) {ppixs = null;} else { ppixs = new Pix(ppixsPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (944, 1)
// pixSwapAndDestroy(ppixd, ppixs) as int
// pixSwapAndDestroy(PIX **, PIX **) as l_ok
///  <summary>
/// (1) Simple operation to change the handle name safely.
/// After this operation, the original image in pixd has
/// been destroyed, pixd points to what was pixs, and
/// the input pixs ptr has been nulled.<para/>
/// 
/// (2) This works safely whether or not pixs and pixd are cloned.
/// If pixs is cloned, the other handles still point to
/// the original image, with the ref count reduced by 1.<para/>
/// 
/// (3) Usage example:
/// \code
/// Pix pix1 = pixRead("...")
/// Pix pix2 = function(pix1, ...)
/// pixSwapAndDestroy([and]pix1, [and]pix2)
/// pixDestroy([and]pix1)  // holds what was in pix2
/// \endcode
/// Example with clones ([] shows ref count of image generated
/// by the function):
/// \code
/// Pix pixs = pixRead("...")
/// Pix pix1 = pixClone(pixs)
/// Pix pix2 = function(pix1, ...) [1]
/// Pix pix3 = pixClone(pix2) [1] to [2]
/// pixSwapAndDestroy([and]pix1, [and]pix2)
/// pixDestroy([and]pixs)  // still holds read image
/// pixDestroy([and]pix1)  // holds what was in pix2  [2] to [1]
/// pixDestroy([and]pix3)  // holds what was in pix2  [1] to [0]
/// \endcode
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSwapAndDestroy/*"/>
///  <param name="ppixd">[out][optional] - input pixd can be null, and it must be different from pixs</param>
///  <param name="ppixs">[in,out] - will be nulled after the swap</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSwapAndDestroy(
				out Pix ppixd, 
				ref Pix ppixs){


	IntPtr ppixdPtr = IntPtr.Zero;
	IntPtr ppixsPtr = IntPtr.Zero; 	if (ppixs != null) {ppixsPtr = ppixs.Pointer;}

	int _Result = Natives.pixSwapAndDestroy(
out ppixdPtr, ref ppixsPtr);
	


//  
	if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
	if (ppixsPtr == IntPtr.Zero) {ppixs = null;} else { ppixs = new Pix(ppixsPtr); };



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (969, 1)
// pixGetWidth(pix) as int
// pixGetWidth(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWidth/*"/>
///   <returns></returns>

public static int pixGetWidth(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetWidth(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (981, 1)
// pixSetWidth(pix, width) as int
// pixSetWidth(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetWidth/*"/>
///   <returns></returns>

public static int pixSetWidth(
				 Pix pix, 
				 int width){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetWidth(
pix.Pointer,   width);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (999, 1)
// pixGetHeight(pix) as int
// pixGetHeight(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetHeight/*"/>
///   <returns></returns>

public static int pixGetHeight(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetHeight(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1011, 1)
// pixSetHeight(pix, height) as int
// pixSetHeight(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetHeight/*"/>
///   <returns></returns>

public static int pixSetHeight(
				 Pix pix, 
				 int height){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetHeight(
pix.Pointer,   height);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1029, 1)
// pixGetDepth(pix) as int
// pixGetDepth(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetDepth/*"/>
///   <returns></returns>

public static int pixGetDepth(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetDepth(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1041, 1)
// pixSetDepth(pix, depth) as int
// pixSetDepth(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetDepth/*"/>
///   <returns></returns>

public static int pixSetDepth(
				 Pix pix, 
				 int depth){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetDepth(
pix.Pointer,   depth);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1064, 1)
// pixGetDimensions(pix, pw, ph, pd) as int
// pixGetDimensions(PIX *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetDimensions/*"/>
///  <param name="pix">[in] - </param>
///  <param name="pw">[out][optional] - each can be null</param>
///  <param name="ph">[out][optional] - each can be null</param>
///  <param name="pd">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixGetDimensions(
				 Pix pix, 
				out int pw, 
				out int ph, 
				out int pd){



	int _Result = Natives.pixGetDimensions(
pix.Pointer, out  pw, out  ph, out  pd);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1091, 1)
// pixSetDimensions(pix, w, h, d) as int
// pixSetDimensions(PIX *, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetDimensions/*"/>
///  <param name="pix">[in] - </param>
///  <param name="w">[in] - use 0 to skip the setting for any of these</param>
///  <param name="h">[in] - use 0 to skip the setting for any of these</param>
///  <param name="d">[in] - use 0 to skip the setting for any of these</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetDimensions(
				 Pix pix, 
				 int w, 
				 int h, 
				 int d){



	int _Result = Natives.pixSetDimensions(
pix.Pointer,   w,   h,   d);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1115, 1)
// pixCopyDimensions(pixd, pixs) as int
// pixCopyDimensions(PIX *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyDimensions/*"/>
///  <param name="pixd">[in] - </param>
///  <param name="pixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixCopyDimensions(
				 Pix pixd, 
				 Pix pixs){



	int _Result = Natives.pixCopyDimensions(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1136, 1)
// pixGetSpp(pix) as int
// pixGetSpp(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetSpp/*"/>
///   <returns></returns>

public static int pixGetSpp(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetSpp(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1164, 1)
// pixSetSpp(pix, spp) as int
// pixSetSpp(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetSpp/*"/>
///   <returns></returns>

public static int pixSetSpp(
				 Pix pix, 
				 int spp){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetSpp(
pix.Pointer,   spp);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1187, 1)
// pixCopySpp(pixd, pixs) as int
// pixCopySpp(PIX *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopySpp/*"/>
///  <param name="pixd">[in] - </param>
///  <param name="pixs">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixCopySpp(
				 Pix pixd, 
				 Pix pixs){



	int _Result = Natives.pixCopySpp(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1205, 1)
// pixGetWpl(pix) as int
// pixGetWpl(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWpl/*"/>
///   <returns></returns>

public static int pixGetWpl(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetWpl(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1216, 1)
// pixSetWpl(pix, wpl) as int
// pixSetWpl(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetWpl/*"/>
///   <returns></returns>

public static int pixSetWpl(
				 Pix pix, 
				 int wpl){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetWpl(
pix.Pointer,   wpl);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1230, 1)
// pixGetRefcount(pix) as int
// pixGetRefcount(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRefcount/*"/>
///   <returns></returns>

public static int pixGetRefcount(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetRefcount(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1241, 1)
// pixChangeRefcount(pix, delta) as int
// pixChangeRefcount(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixChangeRefcount/*"/>
///   <returns></returns>

public static int pixChangeRefcount(
				 Pix pix, 
				 int delta){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixChangeRefcount(
pix.Pointer,   delta);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1255, 1)
// pixGetXRes(pix) as int
// pixGetXRes(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetXRes/*"/>
///   <returns></returns>

public static int pixGetXRes(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetXRes(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1266, 1)
// pixSetXRes(pix, res) as int
// pixSetXRes(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetXRes/*"/>
///   <returns></returns>

public static int pixSetXRes(
				 Pix pix, 
				 int res){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetXRes(
pix.Pointer,   res);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1280, 1)
// pixGetYRes(pix) as int
// pixGetYRes(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetYRes/*"/>
///   <returns></returns>

public static int pixGetYRes(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetYRes(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1291, 1)
// pixSetYRes(pix, res) as int
// pixSetYRes(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetYRes/*"/>
///   <returns></returns>

public static int pixSetYRes(
				 Pix pix, 
				 int res){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetYRes(
pix.Pointer,   res);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1312, 1)
// pixGetResolution(pix, pxres, pyres) as int
// pixGetResolution(PIX *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetResolution/*"/>
///  <param name="pix">[in] - </param>
///  <param name="pxres">[out][optional] - each can be null</param>
///  <param name="pyres">[out][optional] - each can be null</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixGetResolution(
				 Pix pix, 
				out int pxres, 
				out int pyres){



	int _Result = Natives.pixGetResolution(
pix.Pointer, out  pxres, out  pyres);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1338, 1)
// pixSetResolution(pix, xres, yres) as int
// pixSetResolution(PIX *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetResolution/*"/>
///  <param name="pix">[in] - </param>
///  <param name="xres">[in] - use 0 to skip setting a value for either of these</param>
///  <param name="yres">[in] - use 0 to skip setting a value for either of these</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetResolution(
				 Pix pix, 
				 int xres, 
				 int yres){



	int _Result = Natives.pixSetResolution(
pix.Pointer,   xres,   yres);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1353, 1)
// pixCopyResolution(pixd, pixs) as int
// pixCopyResolution(PIX *, PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyResolution/*"/>
///   <returns></returns>

public static int pixCopyResolution(
				 Pix pixd, 
				 Pix pixs){


	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixCopyResolution(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1372, 1)
// pixScaleResolution(pix, xscale, yscale) as int
// pixScaleResolution(PIX *, l_float32, l_float32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScaleResolution/*"/>
///   <returns></returns>

public static int pixScaleResolution(
				 Pix pix, 
				 Single xscale, 
				 Single yscale){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixScaleResolution(
pix.Pointer,   xscale,   yscale);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1390, 1)
// pixGetInputFormat(pix) as int
// pixGetInputFormat(PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetInputFormat/*"/>
///   <returns></returns>

public static int pixGetInputFormat(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixGetInputFormat(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1401, 1)
// pixSetInputFormat(pix, informat) as int
// pixSetInputFormat(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetInputFormat/*"/>
///   <returns></returns>

public static int pixSetInputFormat(
				 Pix pix, 
				 IFF informat){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetInputFormat(
pix.Pointer,  (int) informat);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1414, 1)
// pixCopyInputFormat(pixd, pixs) as int
// pixCopyInputFormat(PIX *, PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyInputFormat/*"/>
///   <returns></returns>

public static int pixCopyInputFormat(
				 Pix pixd, 
				 Pix pixs){


	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixCopyInputFormat(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1432, 1)
// pixSetSpecial(pix, special) as int
// pixSetSpecial(PIX *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetSpecial/*"/>
///   <returns></returns>

public static int pixSetSpecial(
				 Pix pix, 
				 int special){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	int _Result = Natives.pixSetSpecial(
pix.Pointer,   special);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1457, 1)
// pixGetText(pix) as String
// pixGetText(PIX *) as char *
///  <summary>
/// (1) The text string belongs to the pix.  The caller must
/// NOT free it!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetText/*"/>
///  <param name="pix">[in] - </param>
///   <returns>ptr to existing text string</returns>

public static String pixGetText(
				 Pix pix){



	String _Result = Natives.pixGetText(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1481, 1)
// pixSetText(pix, textstring) as int
// pixSetText(PIX *, const char *) as l_ok
///  <summary>
/// (1) This removes any existing textstring and puts a copy of
/// the input textstring there.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetText/*"/>
///  <param name="pix">[in] - </param>
///  <param name="textstring">[in]can be null - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetText(
				 Pix pix, 
				 String textstring){



	int _Result = Natives.pixSetText(
pix.Pointer,   textstring);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1509, 1)
// pixAddText(pix, textstring) as int
// pixAddText(PIX *, const char *) as l_ok
///  <summary>
/// (1) This adds the new textstring to any existing text.<para/>
/// 
/// (2) Either or both the existing text and the new text
/// string can be null.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddText/*"/>
///  <param name="pix">[in] - </param>
///  <param name="textstring">[in]can be null - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixAddText(
				 Pix pix, 
				 String textstring){



	int _Result = Natives.pixAddText(
pix.Pointer,   textstring);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1527, 1)
// pixCopyText(pixd, pixs) as int
// pixCopyText(PIX *, PIX *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyText/*"/>
///   <returns></returns>

public static int pixCopyText(
				 Pix pixd, 
				 Pix pixs){


	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	int _Result = Natives.pixCopyText(
pixd.Pointer, pixs.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1545, 1)
// pixGetColormap(pix) as PixColormap
// pixGetColormap(PIX *) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColormap/*"/>
///   <returns></returns>

public static PixColormap pixGetColormap(
				 Pix pix){


	IntPtr pixPtr = IntPtr.Zero; if (pix != null) {pixPtr = pix.Pointer;}

	IntPtr _Result = Natives.pixGetColormap(
pix.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new PixColormap(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1571, 1)
// pixSetColormap(pix, colormap) as int
// pixSetColormap(PIX *, PIXCMAP *) as l_ok
///  <summary>
/// (1) Unlike with the pix data field, pixSetColormap() destroys
/// any existing colormap before assigning the new one.
/// Because colormaps are not ref counted, it is important that
/// the new colormap does not belong to any other pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetColormap/*"/>
///  <param name="pix">[in] - </param>
///  <param name="colormap">[in] - to be assigned</param>
///   <returns>0 if OK, 1 on error.</returns>

public static int pixSetColormap(
				 Pix pix, 
				 PixColormap colormap){



	int _Result = Natives.pixSetColormap(
pix.Pointer, colormap.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1592, 1)
// pixDestroyColormap(pix) as int
// pixDestroyColormap(PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDestroyColormap/*"/>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixDestroyColormap(
				 Pix pix){



	int _Result = Natives.pixDestroyColormap(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1622, 1)
// pixGetData(pix) as Byte[]
// pixGetData(PIX *) as l_uint32 *
///  <summary>
/// (1) This gives a new handle for the data.  The data is still
/// owned by the pix, so do not call LEPT_FREE() on it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetData/*"/>
///  <param name="pix">[in] - </param>
///   <returns>ptr to image data</returns>

public static Byte[] pixGetData(
				 Pix pix){



	IntPtr _Result = Natives.pixGetData(
pix.Pointer);
	


//  


	Byte[] B = new Byte[pix.w * pix.h * (pix.d/8)] ; Marshal.Copy(_Result, B, 0, B.Length);

	return B;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1646, 1)
// pixSetData(pix, data) as int
// pixSetData(PIX *, l_uint32 *) as l_int32
///  <summary>
/// (1) This does not free any existing data.  To free existing
/// data, use pixFreeData() before pixSetData().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetData/*"/>
///  <param name="pix">[in] - </param>
///  <param name="data">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixSetData(
				 Pix pix, 
				 Byte[] data){


		IntPtr dataPtr = 	Marshal.AllocHGlobal(data.Length);
		Marshal.Copy(data, 0, dataPtr, data.Length);

	int _Result = Natives.pixSetData(
pix.Pointer,   dataPtr);
	

	Marshal.FreeHGlobal(dataPtr);

//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1676, 1)
// pixExtractData(pixs) as Byte[]
// pixExtractData(PIX *) as l_uint32 *
///  <summary>
/// (1) This extracts the pix image data for use in another context.
/// The caller still needs to use pixDestroy() on the input pix.<para/>
/// 
/// (2) If refcount == 1, the data is extracted and the
/// pixtodata ptr is set to NULL.<para/>
/// 
/// (3) If refcount  is greater  1, this simply returns a copy of the data,
/// using the pix allocator, and leaving the input pix unchanged.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractData/*"/>
///   <returns>ptr to data, or null on error</returns>

public static Byte[] pixExtractData(
				 Pix pixs){


	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	IntPtr _Result = Natives.pixExtractData(
pixs.Pointer);
	


//  


	Byte[] B = new Byte[1] ; Marshal.Copy(_Result, B, 0, B.Length);

	return B;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1717, 1)
// pixFreeData(pix) as int
// pixFreeData(PIX *) as l_int32
///  <summary>
/// (1) This frees the data and sets the pix data ptr to null.
/// It should be used before pixSetData() in the situation where
/// you want to free any existing data before doing
/// a subsequent assignment with pixSetData().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFreeData/*"/>
///  <param name="pix">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixFreeData(
				 Pix pix){



	int _Result = Natives.pixFreeData(
pix.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1808, 1)
// pixGetLinePtrs(pix, psize) as IntPtr[]
// pixGetLinePtrs(PIX *, l_int32 *) as void **
///  <summary>
/// (1) This is intended to be used for fast random pixel access.
/// For example, for an 8 bpp image,
/// val = GET_DATA_BYTE(lines8[i], j)
/// is equivalent to, but much faster than,
/// pixGetPixel(pix, j, i, [and]val)<para/>
/// 
/// (2) How much faster?  For 1 bpp, it's from 6 to 10x faster.
/// For 8 bpp, it's an amazing 30x faster.  So if you are
/// doing random access over a substantial part of the image,
/// use this line ptr array.<para/>
/// 
/// (3) When random access is used in conjunction with a stack,
/// queue or heap, the overall computation time depends on
/// the operations performed on each struct that is popped
/// or pushed, and whether we are using a priority queue (O(logn))
/// or a queue or stack (O(1)).  For example, for maze search,
/// the overall ratio of time for line ptrs vs. pixGet/Set is
/// Maze type Type   Time ratio
/// binary  queue   0.4
/// gray  heap (priority queue) 0.6<para/>
/// 
/// (4) Because this returns a void and the accessors take void,
/// the compiler cannot check the pointer types.  It is
/// strongly recommended that you adopt a naming scheme for
/// the returned ptr arrays that indicates the pixel depth.
/// (This follows the original intent of Simonyi's "Hungarian"
/// application notation, where naming is used proactively
/// to make errors visibly obvious.)  By doing this, you can
/// tell by inspection if the correct accessor is used.
/// For example, for an 8 bpp pixg:
/// void lineg8 = pixGetLinePtrs(pixg, NULL)
/// val = GET_DATA_BYTE(lineg8[i], j)  // fast access BYTE, 8
/// ...
/// LEPT_FREE(lineg8)  // don't forget this<para/>
/// 
/// (5) These are convenient for accessing bytes sequentially in an
/// 8 bpp grayscale image.  People who write image processing code
/// on 8 bpp images are accustomed to grabbing pixels directly out
/// of the raster array.  Note that for little endians, you first
/// need to reverse the byte order in each 32-bit word.
/// Here's a typical usage pattern:
/// pixEndianByteSwap(pix) // always safe no-op on big-endians
/// l_uint8 lineptrs = (l_uint8 )pixGetLinePtrs(pix, NULL)
/// pixGetDimensions(pix, [and]w, [and]h, NULL)
/// for (i = 0 i  is smaller h i++) {
/// l_uint8 line = lineptrs[i]
/// for (j = 0 j  is smaller w j++) {
/// val = line[j]
/// ...
/// }
/// }
/// pixEndianByteSwap(pix)  // restore big-endian order
/// LEPT_FREE(lineptrs)
/// This can be done even more simply as follows:
/// l_uint8 lineptrs = pixSetupByteProcessing(pix, [and]w, [and]h)
/// for (i = 0 i  is smaller h i++) {
/// l_uint8 line = lineptrs[i]
/// for (j = 0 j  is smaller w j++) {
/// val = line[j]
/// ...
/// }
/// }
/// pixCleanupByteProcessing(pix, lineptrs)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetLinePtrs/*"/>
///  <param name="pix">[in] - </param>
///  <param name="psize">[out][optional] - array size, which is the pix height</param>
///   <returns>array of line ptrs, or NULL on error</returns>

public static IntPtr[] pixGetLinePtrs(
				 Pix pix, 
				out int psize){



	IntPtr _Result = Natives.pixGetLinePtrs(
pix.Pointer, out  psize);
	


//  


	IntPtr[] B = new IntPtr[psize] ; Marshal.Copy(_Result, B, 0, B.Length);

	return B;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// pix1.c (1848, 1)
// pixPrintStreamInfo(fp, pix, text) as int
// pixPrintStreamInfo(FILE *, PIX *, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixPrintStreamInfo/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="pix">[in] - </param>
///  <param name="text">[in][optional] - identifying string can be null</param>
///   <returns>0 if OK, 1 on error</returns>

public static int pixPrintStreamInfo(
				 FILE fp, 
				 Pix pix, 
				 String text){



	int _Result = Natives.pixPrintStreamInfo(
fp.Pointer, pix.Pointer,   text);
	


//  



	return _Result;
}


}
}
