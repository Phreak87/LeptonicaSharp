Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' fpix1.c (149, 1)
' fpixCreate(width, height) as FPix
' fpixCreate(l_int32, l_int32) as FPIX *
'''  <summary>
''' (1) Makes a FPix of specified size, with the data array
'''allocated and initialized to 0.<para/>
'''
'''(2) The number of pixels must be less than 2^29.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCreate/*"/>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''   <returns>fpixd   with data allocated and initialized to 0, or NULL on error</returns>
Public Shared Function fpixCreate(
				ByVal width as Integer, 
				ByVal height as Integer) as FPix


	Dim _Result as IntPtr = Natives.fpixCreate(  width,   height)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (199, 1)
' fpixCreateTemplate(fpixs) as FPix
' fpixCreateTemplate(FPIX *) as FPIX *
'''  <summary>
''' (1) Makes a FPix of the same size as the input FPix, with the
'''data array allocated and initialized to 0.<para/>
'''
'''(2) Copies the resolution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCreateTemplate/*"/>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd, or NULL on error</returns>
Public Shared Function fpixCreateTemplate(
				ByVal fpixs as FPix) as FPix


if IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixCreateTemplate(fpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (229, 1)
' fpixClone(fpix) as FPix
' fpixClone(FPIX *) as FPIX *
'''  <summary>
''' (1) See pixClone() for definition and usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixClone/*"/>
'''  <param name="fpix">[in] - </param>
'''   <returns>same fpix ptr, or NULL on error</returns>
Public Shared Function fpixClone(
				ByVal fpix as FPix) as FPix


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixClone(fpix.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (272, 1)
' fpixCopy(fpixd, fpixs) as FPix
' fpixCopy(FPIX *, FPIX *) as FPIX *
'''  <summary>
''' (1) There are three cases:
'''(a) fpixd == null  (makes a new fpix refcount = 1)
'''(b) fpixd == fpixs  (no-op)
'''(c) fpixd != fpixs  (data copy no change in refcount)
'''If the refcount of fpixd  is greater  1, case (c) will side-effect
'''these handles.<para/>
'''
'''(2) The general pattern of use is:
'''fpixd = fpixCopy(fpixd, fpixs)
'''This will work for all three cases.
'''For clarity when the case is known, you can use:
'''(a) fpixd = fpixCopy(NULL, fpixs)
'''(c) fpixCopy(fpixd, fpixs)<para/>
'''
'''(3) For case (c), we check if fpixs and fpixd are the same size.
'''If so, the data is copied directly.
'''Otherwise, the data is reallocated to the correct size
'''and the copy proceeds.  The refcount of fpixd is unchanged.<para/>
'''
'''(4) This operation, like all others that may involve a pre-existing
'''fpixd, will side-effect any existing clones of fpixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCopy/*"/>
'''  <param name="fpixd">[in][optional] - can be null, or equal to fpixs, or different from fpixs</param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd, or NULL on error</returns>
Public Shared Function fpixCopy(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as FPix


if IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	Dim fpixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(fpixd) Then fpixdPtr = fpixd.Pointer

	Dim _Result as IntPtr = Natives.fpixCopy(fpixdPtr, fpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (326, 1)
' fpixResizeImageData(fpixd, fpixs) as Integer
' fpixResizeImageData(FPIX *, FPIX *) as l_ok
'''  <summary>
''' (1) If the data sizes differ, this destroys the existing
'''data in fpixd and allocates a new, uninitialized, data array
'''of the same size as the data in fpixs.  Otherwise, this
'''doesn't do anything.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixResizeImageData/*"/>
'''  <param name="fpixd">[in] - </param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixResizeImageData(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as Integer


if IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
		if IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	Dim _Result as Integer = Natives.fpixResizeImageData(fpixd.Pointer, fpixs.Pointer)
	
	return _Result
End Function

' fpix1.c (369, 1)
' fpixDestroy(pfpix) as Object
' fpixDestroy(FPIX **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the fpix.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixDestroy/*"/>
'''  <param name="pfpix">[in,out] - will be nulled</param>
Public Shared Sub fpixDestroy(
				ByRef pfpix as FPix)


	Dim pfpixPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pfpix) Then pfpixPtr = pfpix.Pointer

	Natives.fpixDestroy( pfpixPtr)
	
	if pfpixPtr = IntPtr.Zero then pfpix = Nothing else pfpix = new FPix(pfpixPtr)
End Sub

' fpix1.c (408, 1)
' fpixGetDimensions(fpix, pw, ph) as Integer
' fpixGetDimensions(FPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' fpixGetDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetDimensions/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixGetDimensions(
				ByVal fpix as FPix, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixGetDimensions(fpix.Pointer,   pw,   ph)
	
	return _Result
End Function

' fpix1.c (434, 1)
' fpixSetDimensions(fpix, w, h) as Integer
' fpixSetDimensions(FPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' fpixSetDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetDimensions/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetDimensions(
				ByVal fpix as FPix, 
				ByVal w as Integer, 
				ByVal h as Integer) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixSetDimensions(fpix.Pointer,   w,   h)
	
	return _Result
End Function

' fpix1.c (455, 1)
' fpixGetWpl(fpix) as Integer
' fpixGetWpl(FPIX *) as l_int32
'''  <summary>
''' fpixGetWpl()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetWpl/*"/>
'''  <param name="fpix">[in] - </param>
'''   <returns>wpl, or UNDEF on error</returns>
Public Shared Function fpixGetWpl(
				ByVal fpix as FPix) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixGetWpl(fpix.Pointer)
	
	return _Result
End Function

' fpix1.c (473, 1)
' fpixSetWpl(fpix, wpl) as Integer
' fpixSetWpl(FPIX *, l_int32) as l_ok
'''  <summary>
''' fpixSetWpl()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetWpl/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="wpl">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetWpl(
				ByVal fpix as FPix, 
				ByVal wpl as Integer) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixSetWpl(fpix.Pointer,   wpl)
	
	return _Result
End Function

' fpix1.c (493, 1)
' fpixGetRefcount(fpix) as Integer
' fpixGetRefcount(FPIX *) as l_int32
'''  <summary>
''' fpixGetRefcount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetRefcount/*"/>
'''  <param name="fpix">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function fpixGetRefcount(
				ByVal fpix as FPix) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixGetRefcount(fpix.Pointer)
	
	return _Result
End Function

' fpix1.c (511, 1)
' fpixChangeRefcount(fpix, delta) as Integer
' fpixChangeRefcount(FPIX *, l_int32) as l_ok
'''  <summary>
''' fpixChangeRefcount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixChangeRefcount/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixChangeRefcount(
				ByVal fpix as FPix, 
				ByVal delta as Integer) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixChangeRefcount(fpix.Pointer,   delta)
	
	return _Result
End Function

' fpix1.c (532, 1)
' fpixGetResolution(fpix, pxres, pyres) as Integer
' fpixGetResolution(FPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' fpixGetResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetResolution/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="pxres">[out][optional] - x and y resolution</param>
'''  <param name="pyres">[out][optional] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixGetResolution(
				ByVal fpix as FPix, 
				<Out()> Optional  ByRef pxres as Integer = 0, 
				<Out()> Optional  ByRef pyres as Integer = 0) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixGetResolution(fpix.Pointer,   pxres,   pyres)
	
	return _Result
End Function

' fpix1.c (554, 1)
' fpixSetResolution(fpix, xres, yres) as Integer
' fpixSetResolution(FPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' fpixSetResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetResolution/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="xres">[in] - x and y resolution</param>
'''  <param name="yres">[in] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetResolution(
				ByVal fpix as FPix, 
				ByVal xres as Integer, 
				ByVal yres as Integer) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixSetResolution(fpix.Pointer,   xres,   yres)
	
	return _Result
End Function

' fpix1.c (576, 1)
' fpixCopyResolution(fpixd, fpixs) as Integer
' fpixCopyResolution(FPIX *, FPIX *) as l_ok
'''  <summary>
''' fpixCopyResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixCopyResolution/*"/>
'''  <param name="fpixd">[in] - </param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixCopyResolution(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as Integer


if IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
		if IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	Dim _Result as Integer = Natives.fpixCopyResolution(fpixd.Pointer, fpixs.Pointer)
	
	return _Result
End Function

' fpix1.c (598, 1)
' fpixGetData(fpix) as Single()
' fpixGetData(FPIX *) as l_float32 *
'''  <summary>
''' fpixGetData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetData/*"/>
'''  <param name="fpix">[in] - </param>
'''   <returns>ptr FPix::data, or NULL on error</returns>
Public Shared Function fpixGetData(
				ByVal fpix as FPix) as Single()


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Single() = Natives.fpixGetData(fpix.Pointer)
	
	return _Result
End Function

' fpix1.c (616, 1)
' fpixSetData(fpix, data) as Integer
' fpixSetData(FPIX *, l_float32 *) as l_ok
'''  <summary>
''' fpixSetData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetData/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="data">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetData(
				ByVal fpix as FPix, 
				ByVal data as Single()) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
		if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as Integer = Natives.fpixSetData(fpix.Pointer,   data)
	
	return _Result
End Function

' fpix1.c (638, 1)
' fpixGetPixel(fpix, x, y, pval) as Integer
' fpixGetPixel(FPIX *, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' fpixGetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixGetPixel/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fpixGetPixel(
				ByVal fpix as FPix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				<Out()>  ByRef pval as Single) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixGetPixel(fpix.Pointer,   x,   y,   pval)
	
	return _Result
End Function

' fpix1.c (673, 1)
' fpixSetPixel(fpix, x, y, val) as Integer
' fpixSetPixel(FPIX *, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' fpixSetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixSetPixel/*"/>
'''  <param name="fpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fpixSetPixel(
				ByVal fpix as FPix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal val as Single) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixSetPixel(fpix.Pointer,   x,   y,   val)
	
	return _Result
End Function

' fpix1.c (706, 1)
' fpixaCreate(n) as FPixa
' fpixaCreate(l_int32) as FPIXA *
'''  <summary>
''' fpixaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaCreate/*"/>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>fpixa, or NULL on error</returns>
Public Shared Function fpixaCreate(
				ByVal n as Integer) as FPixa


	Dim _Result as IntPtr = Natives.fpixaCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' fpix1.c (746, 1)
' fpixaCopy(fpixa, copyflag) as FPixa
' fpixaCopy(FPIXA *, l_int32) as FPIXA *
'''  <summary>
''' copyflag may be one of
'''~ L_COPY makes a new fpixa and copies each fpix
'''~ L_CLONE gives a new ref-counted handle to the input fpixa
'''~ L_COPY_CLONE makes a new fpixa with clones of all fpix
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaCopy/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY, L_CLODE or L_COPY_CLONE</param>
'''   <returns>new fpixa, or NULL on error</returns>
Public Shared Function fpixaCopy(
				ByVal fpixa as FPixa, 
				ByVal copyflag as Integer) as FPixa


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaCopy(fpixa.Pointer,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' fpix1.c (793, 1)
' fpixaDestroy(pfpixa) as Object
' fpixaDestroy(FPIXA **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the fpixa.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaDestroy/*"/>
'''  <param name="pfpixa">[in,out] - to be nulled</param>
Public Shared Sub fpixaDestroy(
				ByRef pfpixa as FPixa)


	Dim pfpixaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pfpixa) Then pfpixaPtr = pfpixa.Pointer

	Natives.fpixaDestroy( pfpixaPtr)
	
	if pfpixaPtr = IntPtr.Zero then pfpixa = Nothing else pfpixa = new FPixa(pfpixaPtr)
End Sub

' fpix1.c (834, 1)
' fpixaAddFPix(fpixa, fpix, copyflag) as Integer
' fpixaAddFPix(FPIXA *, FPIX *, l_int32) as l_ok
'''  <summary>
''' fpixaAddFPix()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaAddFPix/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="fpix">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fpixaAddFPix(
				ByVal fpixa as FPixa, 
				ByVal fpix as FPix, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
		if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaAddFPix(fpixa.Pointer, fpix.Pointer,   copyflag)
	
	return _Result
End Function

' fpix1.c (934, 1)
' fpixaGetCount(fpixa) as Integer
' fpixaGetCount(FPIXA *) as l_int32
'''  <summary>
''' fpixaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetCount/*"/>
'''  <param name="fpixa">[in] - </param>
'''   <returns>count, or 0 if no pixa</returns>
Public Shared Function fpixaGetCount(
				ByVal fpixa as FPixa) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaGetCount(fpixa.Pointer)
	
	return _Result
End Function

' fpix1.c (953, 1)
' fpixaChangeRefcount(fpixa, delta) as Integer
' fpixaChangeRefcount(FPIXA *, l_int32) as l_ok
'''  <summary>
''' fpixaChangeRefcount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaChangeRefcount/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixaChangeRefcount(
				ByVal fpixa as FPixa, 
				ByVal delta as Integer) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaChangeRefcount(fpixa.Pointer,   delta)
	
	return _Result
End Function

' fpix1.c (975, 1)
' fpixaGetFPix(fpixa, index, accesstype) as FPix
' fpixaGetFPix(FPIXA *, l_int32, l_int32) as FPIX *
'''  <summary>
''' fpixaGetFPix()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetFPix/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - to the index-th fpix</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixaGetFPix(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal accesstype as Enumerations.L_access_storage) as FPix


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaGetFPix(fpixa.Pointer,   index,   accesstype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (1004, 1)
' fpixaGetFPixDimensions(fpixa, index, pw, ph) as Integer
' fpixaGetFPixDimensions(FPIXA *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' fpixaGetFPixDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetFPixDimensions/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixaGetFPixDimensions(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaGetFPixDimensions(fpixa.Pointer,   index,   pw,   ph)
	
	return _Result
End Function

' fpix1.c (1038, 1)
' fpixaGetData(fpixa, index) as Single()
' fpixaGetData(FPIXA *, l_int32) as l_float32 *
'''  <summary>
''' fpixaGetData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetData/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''   <returns>data not a copy, or NULL on error</returns>
Public Shared Function fpixaGetData(
				ByVal fpixa as FPixa, 
				ByVal index as Integer) as Single()


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Single() = Natives.fpixaGetData(fpixa.Pointer,   index)
	
	return _Result
End Function

' fpix1.c (1070, 1)
' fpixaGetPixel(fpixa, index, x, y, pval) as Integer
' fpixaGetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' fpixaGetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaGetPixel/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fpixaGetPixel(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				<Out()>  ByRef pval as Single) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaGetPixel(fpixa.Pointer,   index,   x,   y,   pval)
	
	return _Result
End Function

' fpix1.c (1107, 1)
' fpixaSetPixel(fpixa, index, x, y, val) as Integer
' fpixaSetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' fpixaSetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaSetPixel/*"/>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fpixaSetPixel(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal val as Single) as Integer


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as Integer = Natives.fpixaSetPixel(fpixa.Pointer,   index,   x,   y,   val)
	
	return _Result
End Function

' fpix1.c (1148, 1)
' dpixCreate(width, height) as DPix
' dpixCreate(l_int32, l_int32) as DPIX *
'''  <summary>
''' (1) Makes a DPix of specified size, with the data array
'''allocated and initialized to 0.<para/>
'''
'''(2) The number of pixels must be less than 2^28.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCreate/*"/>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''   <returns>dpix  with data allocated and initialized to 0, or NULL on error</returns>
Public Shared Function dpixCreate(
				ByVal width as Integer, 
				ByVal height as Integer) as DPix


	Dim _Result as IntPtr = Natives.dpixCreate(  width,   height)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (1198, 1)
' dpixCreateTemplate(dpixs) as DPix
' dpixCreateTemplate(DPIX *) as DPIX *
'''  <summary>
''' (1) Makes a DPix of the same size as the input DPix, with the
'''data array allocated and initialized to 0.<para/>
'''
'''(2) Copies the resolution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCreateTemplate/*"/>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd, or NULL on error</returns>
Public Shared Function dpixCreateTemplate(
				ByVal dpixs as DPix) as DPix


if IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.dpixCreateTemplate(dpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (1227, 1)
' dpixClone(dpix) as DPix
' dpixClone(DPIX *) as DPIX *
'''  <summary>
''' (1) See pixClone() for definition and usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixClone/*"/>
'''  <param name="dpix">[in] - </param>
'''   <returns>same dpix ptr, or NULL on error</returns>
Public Shared Function dpixClone(
				ByVal dpix as DPix) as DPix


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as IntPtr = Natives.dpixClone(dpix.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (1270, 1)
' dpixCopy(dpixd, dpixs) as DPix
' dpixCopy(DPIX *, DPIX *) as DPIX *
'''  <summary>
''' (1) There are three cases:
'''(a) dpixd == null  (makes a new dpix refcount = 1)
'''(b) dpixd == dpixs  (no-op)
'''(c) dpixd != dpixs  (data copy no change in refcount)
'''If the refcount of dpixd  is greater  1, case (c) will side-effect
'''these handles.<para/>
'''
'''(2) The general pattern of use is:
'''dpixd = dpixCopy(dpixd, dpixs)
'''This will work for all three cases.
'''For clarity when the case is known, you can use:
'''(a) dpixd = dpixCopy(NULL, dpixs)
'''(c) dpixCopy(dpixd, dpixs)<para/>
'''
'''(3) For case (c), we check if dpixs and dpixd are the same size.
'''If so, the data is copied directly.
'''Otherwise, the data is reallocated to the correct size
'''and the copy proceeds.  The refcount of dpixd is unchanged.<para/>
'''
'''(4) This operation, like all others that may involve a pre-existing
'''dpixd, will side-effect any existing clones of dpixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCopy/*"/>
'''  <param name="dpixd">[in][optional] - can be null, or equal to dpixs, or different from dpixs</param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd, or NULL on error</returns>
Public Shared Function dpixCopy(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as DPix


if IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")
	Dim dpixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(dpixd) Then dpixdPtr = dpixd.Pointer

	Dim _Result as IntPtr = Natives.dpixCopy(dpixdPtr, dpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (1316, 1)
' dpixResizeImageData(dpixd, dpixs) as Integer
' dpixResizeImageData(DPIX *, DPIX *) as l_ok
'''  <summary>
''' dpixResizeImageData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixResizeImageData/*"/>
'''  <param name="dpixd">[in] - </param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixResizeImageData(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as Integer


if IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
		if IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")
	Dim _Result as Integer = Natives.dpixResizeImageData(dpixd.Pointer, dpixs.Pointer)
	
	return _Result
End Function

' fpix1.c (1359, 1)
' dpixDestroy(pdpix) as Object
' dpixDestroy(DPIX **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the dpix.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixDestroy/*"/>
'''  <param name="pdpix">[in,out] - will be nulled</param>
Public Shared Sub dpixDestroy(
				ByRef pdpix as DPix)


	Dim pdpixPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pdpix) Then pdpixPtr = pdpix.Pointer

	Natives.dpixDestroy( pdpixPtr)
	
	if pdpixPtr = IntPtr.Zero then pdpix = Nothing else pdpix = new DPix(pdpixPtr)
End Sub

' fpix1.c (1398, 1)
' dpixGetDimensions(dpix, pw, ph) as Integer
' dpixGetDimensions(DPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' dpixGetDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetDimensions/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixGetDimensions(
				ByVal dpix as DPix, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixGetDimensions(dpix.Pointer,   pw,   ph)
	
	return _Result
End Function

' fpix1.c (1424, 1)
' dpixSetDimensions(dpix, w, h) as Integer
' dpixSetDimensions(DPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' dpixSetDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetDimensions/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetDimensions(
				ByVal dpix as DPix, 
				ByVal w as Integer, 
				ByVal h as Integer) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixSetDimensions(dpix.Pointer,   w,   h)
	
	return _Result
End Function

' fpix1.c (1445, 1)
' dpixGetWpl(dpix) as Integer
' dpixGetWpl(DPIX *) as l_int32
'''  <summary>
''' dpixGetWpl()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetWpl/*"/>
'''  <param name="dpix">[in] - </param>
'''   <returns>wpl, or UNDEF on error</returns>
Public Shared Function dpixGetWpl(
				ByVal dpix as DPix) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixGetWpl(dpix.Pointer)
	
	return _Result
End Function

' fpix1.c (1463, 1)
' dpixSetWpl(dpix, wpl) as Integer
' dpixSetWpl(DPIX *, l_int32) as l_ok
'''  <summary>
''' dpixSetWpl()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetWpl/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="wpl">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetWpl(
				ByVal dpix as DPix, 
				ByVal wpl as Integer) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixSetWpl(dpix.Pointer,   wpl)
	
	return _Result
End Function

' fpix1.c (1483, 1)
' dpixGetRefcount(dpix) as Integer
' dpixGetRefcount(DPIX *) as l_int32
'''  <summary>
''' dpixGetRefcount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetRefcount/*"/>
'''  <param name="dpix">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function dpixGetRefcount(
				ByVal dpix as DPix) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixGetRefcount(dpix.Pointer)
	
	return _Result
End Function

' fpix1.c (1501, 1)
' dpixChangeRefcount(dpix, delta) as Integer
' dpixChangeRefcount(DPIX *, l_int32) as l_ok
'''  <summary>
''' dpixChangeRefcount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixChangeRefcount/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixChangeRefcount(
				ByVal dpix as DPix, 
				ByVal delta as Integer) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixChangeRefcount(dpix.Pointer,   delta)
	
	return _Result
End Function

' fpix1.c (1522, 1)
' dpixGetResolution(dpix, pxres, pyres) as Integer
' dpixGetResolution(DPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' dpixGetResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetResolution/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="pxres">[out][optional] - x and y resolution</param>
'''  <param name="pyres">[out][optional] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixGetResolution(
				ByVal dpix as DPix, 
				<Out()> Optional  ByRef pxres as Integer = 0, 
				<Out()> Optional  ByRef pyres as Integer = 0) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixGetResolution(dpix.Pointer,   pxres,   pyres)
	
	return _Result
End Function

' fpix1.c (1544, 1)
' dpixSetResolution(dpix, xres, yres) as Integer
' dpixSetResolution(DPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' dpixSetResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetResolution/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="xres">[in] - x and y resolution</param>
'''  <param name="yres">[in] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetResolution(
				ByVal dpix as DPix, 
				ByVal xres as Integer, 
				ByVal yres as Integer) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixSetResolution(dpix.Pointer,   xres,   yres)
	
	return _Result
End Function

' fpix1.c (1566, 1)
' dpixCopyResolution(dpixd, dpixs) as Integer
' dpixCopyResolution(DPIX *, DPIX *) as l_ok
'''  <summary>
''' dpixCopyResolution()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixCopyResolution/*"/>
'''  <param name="dpixd">[in] - </param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixCopyResolution(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as Integer


if IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
		if IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")
	Dim _Result as Integer = Natives.dpixCopyResolution(dpixd.Pointer, dpixs.Pointer)
	
	return _Result
End Function

' fpix1.c (1588, 1)
' dpixGetData(dpix) as Double()
' dpixGetData(DPIX *) as l_float64 *
'''  <summary>
''' dpixGetData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetData/*"/>
'''  <param name="dpix">[in] - </param>
'''   <returns>ptr DPix::data, or NULL on error</returns>
Public Shared Function dpixGetData(
				ByVal dpix as DPix) as Double()


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Double() = Natives.dpixGetData(dpix.Pointer)
	
	return _Result
End Function

' fpix1.c (1606, 1)
' dpixSetData(dpix, data) as Integer
' dpixSetData(DPIX *, l_float64 *) as l_ok
'''  <summary>
''' dpixSetData()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetData/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="data">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetData(
				ByVal dpix as DPix, 
				ByVal data as Double()) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
		if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as Integer = Natives.dpixSetData(dpix.Pointer,   data)
	
	return _Result
End Function

' fpix1.c (1628, 1)
' dpixGetPixel(dpix, x, y, pval) as Integer
' dpixGetPixel(DPIX *, l_int32, l_int32, l_float64 *) as l_ok
'''  <summary>
''' dpixGetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixGetPixel/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function dpixGetPixel(
				ByVal dpix as DPix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				<Out()>  ByRef pval as Double()) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixGetPixel(dpix.Pointer,   x,   y,   pval)
	
	return _Result
End Function

' fpix1.c (1663, 1)
' dpixSetPixel(dpix, x, y, val) as Integer
' dpixSetPixel(DPIX *, l_int32, l_int32, l_float64) as l_ok
'''  <summary>
''' dpixSetPixel()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixSetPixel/*"/>
'''  <param name="dpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function dpixSetPixel(
				ByVal dpix as DPix, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal val as Double) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixSetPixel(dpix.Pointer,   x,   y,   val)
	
	return _Result
End Function

' fpix1.c (1696, 1)
' fpixRead(filename) as FPix
' fpixRead(const char *) as FPIX *
'''  <summary>
''' fpixRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixRead(
				ByVal filename as String) as FPix


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.fpixRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (1723, 1)
' fpixReadStream(fp) as FPix
' fpixReadStream(FILE *) as FPIX *
'''  <summary>
''' fpixReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixReadStream(
				ByVal fp as FILE) as FPix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (1776, 1)
' fpixReadMem(data, size) as FPix
' fpixReadMem(const l_uint8 *, size_t) as FPIX *
'''  <summary>
''' fpixReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixReadMem/*"/>
'''  <param name="data">[in] - of serialized fpix</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as FPix


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (1804, 1)
' fpixWrite(filename, fpix) as Integer
' fpixWrite(const char *, FPIX *) as l_ok
'''  <summary>
''' fpixWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWrite(
				ByVal filename as String, 
				ByVal fpix as FPix) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixWrite(  filename, fpix.Pointer)
	
	return _Result
End Function

' fpix1.c (1835, 1)
' fpixWriteStream(fp, fpix) as Integer
' fpixWriteStream(FILE *, FPIX *) as l_ok
'''  <summary>
''' fpixWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWriteStream/*"/>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWriteStream(
				ByVal fp as FILE, 
				ByVal fpix as FPix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixWriteStream(fp.Pointer, fpix.Pointer)
	
	return _Result
End Function

' fpix1.c (1881, 1)
' fpixWriteMem(pdata, psize, fpix) as Integer
' fpixWriteMem(l_uint8 **, size_t *, FPIX *) as l_ok
'''  <summary>
''' (1) Serializes a fpix in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized fpix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal fpix as FPix) as Integer


if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.fpixWriteMem(  pdataPtr,   psize, fpix.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' fpix1.c (1941, 1)
' fpixEndianByteSwap(fpixd, fpixs) as FPix
' fpixEndianByteSwap(FPIX *, FPIX *) as FPIX *
'''  <summary>
''' (1) On big-endian hardware, this does byte-swapping on each of
'''the 4-byte floats in the fpix data.  On little-endians,
'''the data is unchanged.  This is used for serialization
'''of fpix the data is serialized in little-endian byte
'''order because most hardware is little-endian.<para/>
'''
'''(2) The operation can be either in-place or, if fpixd == NULL,
'''a new fpix is made.  If not in-place, caller must catch
'''the returned pointer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixEndianByteSwap/*"/>
'''  <param name="fpixd">[in] - can be equal to fpixs or NULL</param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd always</returns>
Public Shared Function fpixEndianByteSwap(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as FPix


if IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
		if IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixEndianByteSwap(fpixd.Pointer, fpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPix(_Result)
End Function

' fpix1.c (1993, 1)
' dpixRead(filename) as DPix
' dpixRead(const char *) as DPIX *
'''  <summary>
''' dpixRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixRead(
				ByVal filename as String) as DPix


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.dpixRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (2020, 1)
' dpixReadStream(fp) as DPix
' dpixReadStream(FILE *) as DPIX *
'''  <summary>
''' dpixReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixReadStream(
				ByVal fp as FILE) as DPix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.dpixReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (2073, 1)
' dpixReadMem(data, size) as DPix
' dpixReadMem(const l_uint8 *, size_t) as DPIX *
'''  <summary>
''' dpixReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixReadMem/*"/>
'''  <param name="data">[in] - of serialized dpix</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as DPix


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.dpixReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (2101, 1)
' dpixWrite(filename, dpix) as Integer
' dpixWrite(const char *, DPIX *) as l_ok
'''  <summary>
''' dpixWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWrite(
				ByVal filename as String, 
				ByVal dpix as DPix) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixWrite(  filename, dpix.Pointer)
	
	return _Result
End Function

' fpix1.c (2132, 1)
' dpixWriteStream(fp, dpix) as Integer
' dpixWriteStream(FILE *, DPIX *) as l_ok
'''  <summary>
''' dpixWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWriteStream/*"/>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWriteStream(
				ByVal fp as FILE, 
				ByVal dpix as DPix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim _Result as Integer = Natives.dpixWriteStream(fp.Pointer, dpix.Pointer)
	
	return _Result
End Function

' fpix1.c (2178, 1)
' dpixWriteMem(pdata, psize, dpix) as Integer
' dpixWriteMem(l_uint8 **, size_t *, DPIX *) as l_ok
'''  <summary>
''' (1) Serializes a dpix in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized dpix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal dpix as DPix) as Integer


if IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.dpixWriteMem(  pdataPtr,   psize, dpix.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' fpix1.c (2238, 1)
' dpixEndianByteSwap(dpixd, dpixs) as DPix
' dpixEndianByteSwap(DPIX *, DPIX *) as DPIX *
'''  <summary>
''' (1) On big-endian hardware, this does byte-swapping on each of
'''the 4-byte words in the dpix data.  On little-endians,
'''the data is unchanged.  This is used for serialization
'''of dpix the data is serialized in little-endian byte
'''order because most hardware is little-endian.<para/>
'''
'''(2) The operation can be either in-place or, if dpixd == NULL,
'''a new dpix is made.  If not in-place, caller must catch
'''the returned pointer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dpixEndianByteSwap/*"/>
'''  <param name="dpixd">[in] - can be equal to dpixs or NULL</param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd always</returns>
Public Shared Function dpixEndianByteSwap(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as DPix


if IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
		if IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.dpixEndianByteSwap(dpixd.Pointer, dpixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new DPix(_Result)
End Function

' fpix1.c (2297, 1)
' fpixPrintStream(fp, fpix, factor) as Integer
' fpixPrintStream(FILE *, FPIX *, l_int32) as l_ok
'''  <summary>
''' (1) Subsampled printout of fpix for debugging.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixPrintStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="fpix">[in] - </param>
'''  <param name="factor">[in] - subsampled</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixPrintStream(
				ByVal fp as FILE, 
				ByVal fpix as FPix, 
				ByVal factor as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	Dim _Result as Integer = Natives.fpixPrintStream(fp.Pointer, fpix.Pointer,   factor)
	
	return _Result
End Function

End Class


