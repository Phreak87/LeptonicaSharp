Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pix1.c (282, 1)
' setPixMemoryManager(allocator, deallocator) as Object
' setPixMemoryManager(alloc_fn, dealloc_fn) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use this to change the alloc and/or dealloc functions<para/>
''' e.g., setPixMemoryManager(my_malloc, my_free).<para/>
''' (2) The C99 standard (section 6.7.5.3, par. 8) says:<para/>
''' A declaration of a parameter as "function returning type"<para/>
''' shall be adjusted to "pointer to function returning type"<para/>
''' so that it can be in either of these two forms:<para/>
''' (a) type (function-ptr(type, ...))<para/>
''' (b) type ((function-ptr)(type, ...))<para/>
''' because form (a) is implictly converted to form (b), as in the<para/>
''' definition of struct PixMemoryManager above.  So, for example,<para/>
''' we should be able to declare either of these:<para/>
''' (a) void (allocator(size_t))<para/>
''' (b) void ((allocator)(size_t))<para/>
''' However, MSVC++ only accepts the second version.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="allocator">[in][optional] - use NULL to skip</param>
'''  <param name="deallocator">[in][optional] - use NULL to skip</param>
Public Shared Sub setPixMemoryManager(
				 ByVal allocator as IntPtr, 
				 ByVal deallocator as IntPtr)



	LeptonicaSharp.Natives.setPixMemoryManager( allocator, deallocator)

End Sub

' SRC\pix1.c (302, 1)
' pixCreate(width, height, depth) as Pix
' pixCreate(l_int32, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''  <param name="depth">[in] - </param>
'''   <returns>pixd with data allocated and initialized to 0, or NULL on error</returns>
Public Shared Function pixCreate(
				 ByVal width as Integer, 
				 ByVal height as Integer, 
				 ByVal depth as Integer) as Pix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreate( width, height, depth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (331, 1)
' pixCreateNoInit(width, height, depth) as Pix
' pixCreateNoInit(l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Must set pad bits to avoid reading uninitialized data, because<para/>
''' some optimized routines (e.g., pixConnComp()) read from pad bits.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''  <param name="depth">[in] - </param>
'''   <returns>pixd with data allocated but not initialized, or NULL on error</returns>
Public Shared Function pixCreateNoInit(
				 ByVal width as Integer, 
				 ByVal height as Integer, 
				 ByVal depth as Integer) as Pix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreateNoInit( width, height, depth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (367, 1)
' pixCreateTemplate(pixs) as Pix
' pixCreateTemplate(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Makes a Pix of the same size as the input Pix, with the<para/>
''' data array allocated and initialized to 0.<para/>
''' (2) Copies the other fields, including colormap if it exists.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCreateTemplate(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreateTemplate( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (397, 1)
' pixCreateTemplateNoInit(pixs) as Pix
' pixCreateTemplateNoInit(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Makes a Pix of the same size as the input Pix, with<para/>
''' the data array allocated but not initialized to 0.<para/>
''' (2) Copies the other fields, including colormap if it exists.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCreateTemplateNoInit(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreateTemplateNoInit( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (439, 1)
' pixCreateHeader(width, height, depth) as Pix
' pixCreateHeader(l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is assumed that all 32 bit pix have 3 spp.  If there is<para/>
''' a valid alpha channel, this will be set to 4 spp later.<para/>
''' (2) If the number of bytes to be allocated is larger than the<para/>
''' maximum value in an int32, we can get overflow, resulting<para/>
''' in a smaller amount of memory actually being allocated.<para/>
''' Later, an attempt to access memory that wasn't allocated will<para/>
''' cause a crash.  So to avoid crashing a program (or worse)<para/>
''' with bad (or malicious) input, this is where we limit the<para/>
''' requested allocation of image data in a typesafe way.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''  <param name="depth">[in] - </param>
'''   <returns>pixd with no data allocated, or NULL on error</returns>
Public Shared Function pixCreateHeader(
				 ByVal width as Integer, 
				 ByVal height as Integer, 
				 ByVal depth as Integer) as Pix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreateHeader( width, height, depth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (517, 1)
' pixClone(pixs) as Pix
' pixClone(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A "clone" is simply a handle (ptr) to an existing pix.<para/>
''' It is implemented because (a) images can be large and<para/>
''' hence expensive to copy, and (b) extra handles to a data<para/>
''' structure need to be made with a simple policy to avoid<para/>
''' both double frees and memory leaks.  Pix are reference<para/>
''' counted.  The side effect of pixClone() is an increase<para/>
''' by 1 in the ref count.<para/>
''' (2) The protocol to be used is:<para/>
''' (a) Whenever you want a new handle to an existing image,<para/>
''' call pixClone(), which just bumps a ref count.<para/>
''' (b) Always call pixDestroy() on all handles.  This<para/>
''' decrements the ref count, nulls the handle, and<para/>
''' only destroys the pix when pixDestroy() has been<para/>
''' called on all handles.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''   <returns>same pix ptr, or NULL on error</returns>
Public Shared Function pixClone(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixClone( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (545, 1)
' pixDestroy(ppix) as Object
' pixDestroy(PIX **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Decrements the ref count and, if 0, destroys the pix.<para/>
''' (2) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppix">[in,out] - will be nulled</param>
Public Shared Sub pixDestroy(
				 ByRef ppix as Pix)


	Dim ppixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppix) Then ppixPTR = ppix.Pointer

	LeptonicaSharp.Natives.pixDestroy( ppixPTR)
	if ppixPTR <> IntPtr.Zero then ppix = new Pix(ppixPTR)

End Sub

' SRC\pix1.c (630, 1)
' pixCopy(pixd, pixs) as Pix
' pixCopy(PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) There are three cases:<para/>
''' (a) pixd == null  (makes a new pix refcount = 1)<para/>
''' (b) pixd == pixs  (no-op)<para/>
''' (c) pixd != pixs  (data copy no change in refcount)<para/>
''' If the refcount of pixd  is greater  1, case (c) will side-effect<para/>
''' these handles.<para/>
''' (2) The general pattern of use is:<para/>
''' pixd = pixCopy(pixd, pixs)<para/>
''' This will work for all three cases.<para/>
''' For clarity when the case is known, you can use:<para/>
''' (a) pixd = pixCopy(NULL, pixs)<para/>
''' (c) pixCopy(pixd, pixs)<para/>
''' (3) For case (c), we check if pixs and pixd are the same<para/>
''' size (w,h,d).  If so, the data is copied directly.<para/>
''' Otherwise, the data is reallocated to the correct size<para/>
''' and the copy proceeds.  The refcount of pixd is unchanged.<para/>
''' (4) This operation, like all others that may involve a pre-existing<para/>
''' pixd, will side-effect any existing clones of pixd.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - can be null, equal to pixs, different from pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixCopy(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCopy( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pix1.c (698, 1)
' pixResizeImageData(pixd, pixs) as Integer
' pixResizeImageData(PIX *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the sizes of data in pixs and pixd are unequal, this<para/>
''' frees the existing image data in pixd and allocates<para/>
''' an uninitialized buffer that will hold the required amount<para/>
''' of image data in pixs.  The image data from pixs is not<para/>
''' copied into the new buffer.<para/>
''' (2) On failure to allocate, pixd is unchanged.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - gets new uninitialized buffer for image data</param>
'''  <param name="pixs">[in] - determines the size of the buffer not changed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixResizeImageData(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixResizeImageData( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (747, 1)
' pixCopyColormap(pixd, pixs) as Integer
' pixCopyColormap(PIX *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This always destroys any colormap in pixd (except if<para/>
''' the operation is a no-op.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - </param>
'''  <param name="pixs">[in] - copies the colormap to %pixd</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCopyColormap(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopyColormap( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (780, 1)
' pixSizesEqual(pix1, pix2) as Integer
' pixSizesEqual(PIX *, PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - </param>
'''  <param name="pix2">[in] - </param>
'''   <returns>1 if the two pix have same {h, w, d} 0 otherwise.</returns>
Public Shared Function pixSizesEqual(
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSizesEqual( pix1.Pointer, pix2.Pointer)

	Return _Result
End Function

' SRC\pix1.c (854, 1)
' pixTransferAllData(pixd, ppixs, copytext, copyformat) as Integer
' pixTransferAllData(PIX *, PIX **, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does a complete data transfer from pixs to pixd,<para/>
''' followed by the destruction of pixs (refcount permitting).<para/>
''' (2) If the refcount of pixs is 1, pixs is destroyed.  Otherwise,<para/>
''' the data in pixs is copied (rather than transferred) to pixd.<para/>
''' (3) This operation, like all others with a pre-existing pixd,<para/>
''' will side-effect any existing clones of pixd.  The pixd<para/>
''' refcount does not change.<para/>
''' (4) When might you use this?  Suppose you have an in-place Pix<para/>
''' function (returning void) with the typical signature:<para/>
''' void function-inplace(PIX pix, ...)<para/>
''' where "..." are non-pointer input parameters, and suppose<para/>
''' further that you sometimes want to return an arbitrary Pix<para/>
''' in place of the input Pix.  There are two ways you can do this:<para/>
''' (a) The straightforward way is to change the function<para/>
''' signature to take the address of the Pix ptr:<para/>
''' \code<para/>
''' void function-inplace(PIX ppix, ...) {<para/>
''' PIX pixt = function-makenew(ppix)<para/>
''' pixDestroy(ppix)<para/>
''' ppix = pixt<para/>
''' return<para/>
''' }<para/>
''' \endcode<para/>
''' Here, the input and returned pix are different, as viewed<para/>
''' by the calling function, and the inplace function is<para/>
''' expected to destroy the input pix to avoid a memory leak.<para/>
''' (b) Keep the signature the same and use pixTransferAllData()<para/>
''' to return the new Pix in the input Pix struct:<para/>
''' \code<para/>
''' void function-inplace(PIX pix, ...) {<para/>
''' PIX pixt = function-makenew(pix)<para/>
''' pixTransferAllData(pix,  and pixt, 0, 0)<para/>
''' // pixDestroy() is called on pixt<para/>
''' return<para/>
''' }<para/>
''' \endcode<para/>
''' Here, the input and returned pix are the same, as viewed<para/>
''' by the calling function, and the inplace function must<para/>
''' never destroy the input pix, because the calling function<para/>
''' maintains an unchanged handle to it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - must be different from pixs</param>
'''  <param name="ppixs">[in,out] - will be nulled if refcount goes to 0</param>
'''  <param name="copytext">[in] - 1 to copy the text field 0 to skip</param>
'''  <param name="copyformat">[in] - 1 to copy the informat field 0 to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTransferAllData(
				 ByVal pixd as Pix, 
				 ByRef ppixs as Pix, 
				 ByVal copytext as Integer, 
				 ByVal copyformat as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim ppixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixs) Then ppixsPTR = ppixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixTransferAllData( pixd.Pointer, ppixsPTR, copytext, copyformat)
	if ppixsPTR <> IntPtr.Zero then ppixs = new Pix(ppixsPTR)

	Return _Result
End Function

' SRC\pix1.c (944, 1)
' pixSwapAndDestroy(ppixd, ppixs) as Integer
' pixSwapAndDestroy(PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Simple operation to change the handle name safely.<para/>
''' After this operation, the original image in pixd has<para/>
''' been destroyed, pixd points to what was pixs, and<para/>
''' the input pixs ptr has been nulled.<para/>
''' (2) This works safely whether or not pixs and pixd are cloned.<para/>
''' If pixs is cloned, the other handles still point to<para/>
''' the original image, with the ref count reduced by 1.<para/>
''' (3) Usage example:<para/>
''' \code<para/>
''' Pix pix1 = pixRead("...")<para/>
''' Pix pix2 = function(pix1, ...)<para/>
''' pixSwapAndDestroy( and pix1,  and pix2)<para/>
''' pixDestroy( and pix1)  // holds what was in pix2<para/>
''' \endcode<para/>
''' Example with clones ([] shows ref count of image generated<para/>
''' by the function):<para/>
''' \code<para/>
''' Pix pixs = pixRead("...")<para/>
''' Pix pix1 = pixClone(pixs)<para/>
''' Pix pix2 = function(pix1, ...) [1]<para/>
''' Pix pix3 = pixClone(pix2) [1] -- is greater  [2]<para/>
''' pixSwapAndDestroy( and pix1,  and pix2)<para/>
''' pixDestroy( and pixs)  // still holds read image<para/>
''' pixDestroy( and pix1)  // holds what was in pix2  [2] -- is greater  [1]<para/>
''' pixDestroy( and pix3)  // holds what was in pix2  [1] -- is greater  [0]<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppixd">[out][optional] - input pixd can be null, and it must be different from pixs</param>
'''  <param name="ppixs">[in,out] - will be nulled after the swap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSwapAndDestroy(
				<Out()> ByRef ppixd as Pix, 
				 ByRef ppixs as Pix) as Integer


Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer
	Dim ppixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixs) Then ppixsPTR = ppixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSwapAndDestroy( ppixdPTR, ppixsPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)
	if ppixsPTR <> IntPtr.Zero then ppixs = new Pix(ppixsPTR)

	Return _Result
End Function

' SRC\pix1.c (969, 1)
' pixGetWidth(pix) as Integer
' pixGetWidth(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetWidth(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetWidth( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (981, 1)
' pixSetWidth(pix, width) as Integer
' pixSetWidth(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetWidth(
				 ByVal pix as Pix, 
				 ByVal width as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetWidth( pix.Pointer, width)

	Return _Result
End Function

' SRC\pix1.c (999, 1)
' pixGetHeight(pix) as Integer
' pixGetHeight(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetHeight(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetHeight( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1011, 1)
' pixSetHeight(pix, height) as Integer
' pixSetHeight(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetHeight(
				 ByVal pix as Pix, 
				 ByVal height as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetHeight( pix.Pointer, height)

	Return _Result
End Function

' SRC\pix1.c (1029, 1)
' pixGetDepth(pix) as Integer
' pixGetDepth(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetDepth(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetDepth( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1041, 1)
' pixSetDepth(pix, depth) as Integer
' pixSetDepth(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetDepth(
				 ByVal pix as Pix, 
				 ByVal depth as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetDepth( pix.Pointer, depth)

	Return _Result
End Function

' SRC\pix1.c (1064, 1)
' pixGetDimensions(pix, pw, ph, pd) as Integer
' pixGetDimensions(PIX *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''  <param name="pd">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetDimensions(
				 ByVal pix as Pix, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pd as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetDimensions( pix.Pointer, pw, ph, pd)

	Return _Result
End Function

' SRC\pix1.c (1091, 1)
' pixSetDimensions(pix, w, h, d) as Integer
' pixSetDimensions(PIX *, l_int32, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="w">[in] - use 0 to skip the setting for any of these</param>
'''  <param name="h">[in] - use 0 to skip the setting for any of these</param>
'''  <param name="d">[in] - use 0 to skip the setting for any of these</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetDimensions(
				 ByVal pix as Pix, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal d as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetDimensions( pix.Pointer, w, h, d)

	Return _Result
End Function

' SRC\pix1.c (1115, 1)
' pixCopyDimensions(pixd, pixs) as Integer
' pixCopyDimensions(PIX *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - </param>
'''  <param name="pixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCopyDimensions(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopyDimensions( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1136, 1)
' pixGetSpp(pix) as Integer
' pixGetSpp(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetSpp(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetSpp( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1164, 1)
' pixSetSpp(pix, spp) as Integer
' pixSetSpp(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetSpp(
				 ByVal pix as Pix, 
				 ByVal spp as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetSpp( pix.Pointer, spp)

	Return _Result
End Function

' SRC\pix1.c (1187, 1)
' pixCopySpp(pixd, pixs) as Integer
' pixCopySpp(PIX *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - </param>
'''  <param name="pixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCopySpp(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopySpp( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1205, 1)
' pixGetWpl(pix) as Integer
' pixGetWpl(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetWpl(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetWpl( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1216, 1)
' pixSetWpl(pix, wpl) as Integer
' pixSetWpl(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetWpl(
				 ByVal pix as Pix, 
				 ByVal wpl as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetWpl( pix.Pointer, wpl)

	Return _Result
End Function

' SRC\pix1.c (1230, 1)
' pixGetRefcount(pix) as Integer
' pixGetRefcount(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetRefcount(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetRefcount( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1241, 1)
' pixChangeRefcount(pix, delta) as Integer
' pixChangeRefcount(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixChangeRefcount(
				 ByVal pix as Pix, 
				 ByVal delta as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixChangeRefcount( pix.Pointer, delta)

	Return _Result
End Function

' SRC\pix1.c (1255, 1)
' pixGetXRes(pix) as Integer
' pixGetXRes(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetXRes(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetXRes( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1266, 1)
' pixSetXRes(pix, res) as Integer
' pixSetXRes(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetXRes(
				 ByVal pix as Pix, 
				 ByVal res as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetXRes( pix.Pointer, res)

	Return _Result
End Function

' SRC\pix1.c (1280, 1)
' pixGetYRes(pix) as Integer
' pixGetYRes(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetYRes(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetYRes( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1291, 1)
' pixSetYRes(pix, res) as Integer
' pixSetYRes(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetYRes(
				 ByVal pix as Pix, 
				 ByVal res as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetYRes( pix.Pointer, res)

	Return _Result
End Function

' SRC\pix1.c (1312, 1)
' pixGetResolution(pix, pxres, pyres) as Integer
' pixGetResolution(PIX *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="pxres">[out][optional] - each can be null</param>
'''  <param name="pyres">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetResolution(
				 ByVal pix as Pix, 
				<Out()> ByRef pxres as Integer, 
				<Out()> ByRef pyres as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetResolution( pix.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\pix1.c (1338, 1)
' pixSetResolution(pix, xres, yres) as Integer
' pixSetResolution(PIX *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="xres">[in] - use 0 to skip setting a value for either of these</param>
'''  <param name="yres">[in] - use 0 to skip setting a value for either of these</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetResolution(
				 ByVal pix as Pix, 
				 ByVal xres as Integer, 
				 ByVal yres as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetResolution( pix.Pointer, xres, yres)

	Return _Result
End Function

' SRC\pix1.c (1353, 1)
' pixCopyResolution(pixd, pixs) as Integer
' pixCopyResolution(PIX *, PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixCopyResolution(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopyResolution( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1372, 1)
' pixScaleResolution(pix, xscale, yscale) as Integer
' pixScaleResolution(PIX *, l_float32, l_float32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixScaleResolution(
				 ByVal pix as Pix, 
				 ByVal xscale as Single, 
				 ByVal yscale as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (xscale) then Throw New ArgumentNullException  ("xscale cannot be Nothing")
	If IsNothing (yscale) then Throw New ArgumentNullException  ("yscale cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixScaleResolution( pix.Pointer, xscale, yscale)

	Return _Result
End Function

' SRC\pix1.c (1390, 1)
' pixGetInputFormat(pix) as Integer
' pixGetInputFormat(PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetInputFormat(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetInputFormat( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1401, 1)
' pixSetInputFormat(pix, informat) as Integer
' pixSetInputFormat(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetInputFormat(
				 ByVal pix as Pix, 
				 ByVal informat as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetInputFormat( pix.Pointer, informat)

	Return _Result
End Function

' SRC\pix1.c (1414, 1)
' pixCopyInputFormat(pixd, pixs) as Integer
' pixCopyInputFormat(PIX *, PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixCopyInputFormat(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopyInputFormat( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1432, 1)
' pixSetSpecial(pix, special) as Integer
' pixSetSpecial(PIX *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixSetSpecial(
				 ByVal pix as Pix, 
				 ByVal special as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetSpecial( pix.Pointer, special)

	Return _Result
End Function

' SRC\pix1.c (1457, 1)
' pixGetText(pix) as String
' pixGetText(PIX *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The text string belongs to the pix.  The caller must<para/>
''' NOT free it!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>ptr to existing text string</returns>
Public Shared Function pixGetText(
				 ByVal pix as Pix) as String

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.pixGetText( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1481, 1)
' pixSetText(pix, textstring) as Integer
' pixSetText(PIX *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes any existing textstring and puts a copy of<para/>
''' the input textstring there.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="textstring">[in]can be null - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetText(
				 ByVal pix as Pix, 
				 ByVal textstring as String) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetText( pix.Pointer, textstring)

	Return _Result
End Function

' SRC\pix1.c (1509, 1)
' pixAddText(pix, textstring) as Integer
' pixAddText(PIX *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This adds the new textstring to any existing text.<para/>
''' (2) Either or both the existing text and the new text<para/>
''' string can be null.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="textstring">[in]can be null - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAddText(
				 ByVal pix as Pix, 
				 ByVal textstring as String) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAddText( pix.Pointer, textstring)

	Return _Result
End Function

' SRC\pix1.c (1527, 1)
' pixCopyText(pixd, pixs) as Integer
' pixCopyText(PIX *, PIX *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixCopyText(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCopyText( pixd.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1545, 1)
' pixGetColormap(pix) as PixColormap
' pixGetColormap(PIX *) as PIXCMAP *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetColormap(
				 ByVal pix as Pix) as PixColormap

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetColormap( pix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\pix1.c (1571, 1)
' pixSetColormap(pix, colormap) as Integer
' pixSetColormap(PIX *, PIXCMAP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Unlike with the pix data field, pixSetColormap() destroys<para/>
''' any existing colormap before assigning the new one.<para/>
''' Because colormaps are not ref counted, it is important that<para/>
''' the new colormap does not belong to any other pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="colormap">[in] - to be assigned</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSetColormap(
				 ByVal pix as Pix, 
				 ByVal colormap as PixColormap) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (colormap) then Throw New ArgumentNullException  ("colormap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetColormap( pix.Pointer, colormap.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1592, 1)
' pixDestroyColormap(pix) as Integer
' pixDestroyColormap(PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixDestroyColormap(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixDestroyColormap( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1622, 1)
' pixGetData(pix) as Byte()
' pixGetData(PIX *) as l_uint32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives a new handle for the data.  The data is still<para/>
''' owned by the pix, so do not call LEPT_FREE() on it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>ptr to image data</returns>
Public Shared Function pixGetData(
				 ByVal pix as Pix) as Byte()

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetData( pix.Pointer)
Dim B(1) As Byte : Marshal.Copy(_Result, B, 0, B.Length)

	Return B
End Function

' SRC\pix1.c (1646, 1)
' pixSetData(pix, data) as Integer
' pixSetData(PIX *, l_uint32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does not free any existing data.  To free existing<para/>
''' data, use pixFreeData() before pixSetData().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="data">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetData(
				 ByVal pix as Pix, 
				 ByVal data as Byte()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetData( pix.Pointer, dataPTR)

	Return _Result
End Function

' SRC\pix1.c (1676, 1)
' pixExtractData(pixs) as Byte()
' pixExtractData(PIX *) as l_uint32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This extracts the pix image data for use in another context.<para/>
''' The caller still needs to use pixDestroy() on the input pix.<para/>
''' (2) If refcount == 1, the data is extracted and the<para/>
''' pix- is greater data ptr is set to NULL.<para/>
''' (3) If refcount  is greater  1, this simply returns a copy of the data,<para/>
''' using the pix allocator, and leaving the input pix unchanged.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>ptr to data, or null on error</returns>
Public Shared Function pixExtractData(
				 ByVal pixs as Pix) as Byte()

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractData( pixs.Pointer)
Dim B(1) As Byte : Marshal.Copy(_Result, B, 0, B.Length)

	Return B
End Function

' SRC\pix1.c (1717, 1)
' pixFreeData(pix) as Integer
' pixFreeData(PIX *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This frees the data and sets the pix data ptr to null.<para/>
''' It should be used before pixSetData() in the situation where<para/>
''' you want to free any existing data before doing<para/>
''' a subsequent assignment with pixSetData().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFreeData(
				 ByVal pix as Pix) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixFreeData( pix.Pointer)

	Return _Result
End Function

' SRC\pix1.c (1808, 1)
' pixGetLinePtrs(pix, psize) as IntPtr()
' pixGetLinePtrs(PIX *, l_int32 *) as void **
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is intended to be used for fast random pixel access.<para/>
''' For example, for an 8 bpp image,<para/>
''' val = GET_DATA_BYTE(lines8[i], j)<para/>
''' is equivalent to, but much faster than,<para/>
''' pixGetPixel(pix, j, i,  and val)<para/>
''' (2) How much faster?  For 1 bpp, it's from 6 to 10x faster.<para/>
''' For 8 bpp, it's an amazing 30x faster.  So if you are<para/>
''' doing random access over a substantial part of the image,<para/>
''' use this line ptr array.<para/>
''' (3) When random access is used in conjunction with a stack,<para/>
''' queue or heap, the overall computation time depends on<para/>
''' the operations performed on each struct that is popped<para/>
''' or pushed, and whether we are using a priority queue (O(logn))<para/>
''' or a queue or stack (O(1)).  For example, for maze search,<para/>
''' the overall ratio of time for line ptrs vs. pixGet/Set is<para/>
''' Maze type Type   Time ratio<para/>
''' binary  queue   0.4<para/>
''' gray  heap (priority queue) 0.6<para/>
''' (4) Because this returns a void and the accessors take void,<para/>
''' the compiler cannot check the pointer types.  It is<para/>
''' strongly recommended that you adopt a naming scheme for<para/>
''' the returned ptr arrays that indicates the pixel depth.<para/>
''' (This follows the original intent of Simonyi's "Hungarian"<para/>
''' application notation, where naming is used proactively<para/>
''' to make errors visibly obvious.)  By doing this, you can<para/>
''' tell by inspection if the correct accessor is used.<para/>
''' For example, for an 8 bpp pixg:<para/>
''' void lineg8 = pixGetLinePtrs(pixg, NULL)<para/>
''' val = GET_DATA_BYTE(lineg8[i], j)  // fast access BYTE, 8<para/>
''' ...<para/>
''' LEPT_FREE(lineg8)  // don't forget this<para/>
''' (5) These are convenient for accessing bytes sequentially in an<para/>
''' 8 bpp grayscale image.  People who write image processing code<para/>
''' on 8 bpp images are accustomed to grabbing pixels directly out<para/>
''' of the raster array.  Note that for little endians, you first<para/>
''' need to reverse the byte order in each 32-bit word.<para/>
''' Here's a typical usage pattern:<para/>
''' pixEndianByteSwap(pix) // always safe no-op on big-endians<para/>
''' l_uint8 lineptrs = (l_uint8 )pixGetLinePtrs(pix, NULL)<para/>
''' pixGetDimensions(pix,  and w,  and h, NULL)<para/>
''' for (i = 0 i  is lower  h i++) {<para/>
''' l_uint8 line = lineptrs[i]<para/>
''' for (j = 0 j  is lower  w j++) {<para/>
''' val = line[j]<para/>
''' ...<para/>
''' }<para/>
''' }<para/>
''' pixEndianByteSwap(pix)  // restore big-endian order<para/>
''' LEPT_FREE(lineptrs)<para/>
''' This can be done even more simply as follows:<para/>
''' l_uint8 lineptrs = pixSetupByteProcessing(pix,  and w,  and h)<para/>
''' for (i = 0 i  is lower  h i++) {<para/>
''' l_uint8 line = lineptrs[i]<para/>
''' for (j = 0 j  is lower  w j++) {<para/>
''' val = line[j]<para/>
''' ...<para/>
''' }<para/>
''' }<para/>
''' pixCleanupByteProcessing(pix, lineptrs)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="psize">[out][optional] - array size, which is the pix height</param>
'''   <returns>array of line ptrs, or NULL on error</returns>
Public Shared Function pixGetLinePtrs(
				 ByVal pix as Pix, 
				<Out()> ByRef psize as Integer) as IntPtr()

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetLinePtrs( pix.Pointer, psize)
Dim B(1) As IntPtr : Marshal.Copy(_Result, B, 0, B.Length)

	Return B
End Function

' SRC\pix1.c (1848, 1)
' pixPrintStreamInfo(fp, pix, text) as Integer
' pixPrintStreamInfo(FILE *, PIX *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="text">[in][optional] - identifying string can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixPrintStreamInfo(
				 ByVal fp as FILE, 
				 ByVal pix as Pix, 
				 ByVal text as String) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixPrintStreamInfo( fp.Pointer, pix.Pointer, text)

	Return _Result
End Function

End Class
