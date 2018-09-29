Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\fpix1.c (149, 1)
' fpixCreate()
' fpixCreate(l_int32, l_int32) as FPIX *
'''  <summary>
''' Notes
''' (1) Makes a FPix of specified size, with the data array
''' allocated and initialized to 0.
''' (2) The number of pixels must be less than 2^29.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''   <returns>fpixd   with data allocated and initialized to 0, or NULL on error</returns>
Public Shared Function fpixCreate(
				ByVal width as Integer, 
				ByVal height as Integer) as FPix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixCreate( width, height)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (199, 1)
' fpixCreateTemplate()
' fpixCreateTemplate(FPIX *) as FPIX *
'''  <summary>
''' Notes
''' (1) Makes a FPix of the same size as the input FPix, with the
''' data array allocated and initialized to 0.
''' (2) Copies the resolution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd, or NULL on error</returns>
Public Shared Function fpixCreateTemplate(
				ByVal fpixs as FPix) as FPix

	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixCreateTemplate( fpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (229, 1)
' fpixClone()
' fpixClone(FPIX *) as FPIX *
'''  <summary>
''' Notes
''' (1) See pixClone() for definition and usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''   <returns>same fpix ptr, or NULL on error</returns>
Public Shared Function fpixClone(
				ByVal fpix as FPix) as FPix

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixClone( fpix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (272, 1)
' fpixCopy()
' fpixCopy(FPIX *, FPIX *) as FPIX *
'''  <summary>
''' Notes
''' (1) There are three cases
''' (a) fpixd == null  (makes a new fpix; refcount = 1)
''' (b) fpixd == fpixs  (no-op)
''' (c) fpixd != fpixs  (data copy; no change in refcount)
''' If the refcount of fpixd GT 1, case (c) will side-effect
''' these handles.
''' (2) The general pattern of use is
''' fpixd = fpixCopy(fpixd, fpixs);
''' This will work for all three cases.
''' For clarity when the case is known, you can use
''' (a) fpixd = fpixCopy(NULL, fpixs);
''' (c) fpixCopy(fpixd, fpixs);
''' (3) For case (c), we check if fpixs and fpixd are the same size.
''' If so, the data is copied directly.
''' Otherwise, the data is reallocated to the correct size
''' and the copy proceeds.  The refcount of fpixd is unchanged.
''' (4) This operation, like all others that may involve a pre-existing
''' fpixd, will side-effect any existing clones of fpixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixd">[in][optional] - ; can be null, or equal to fpixs, or different from fpixs</param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd, or NULL on error</returns>
Public Shared Function fpixCopy(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as FPix

	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")

	Dim fpixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fpixd) Then fpixdPTR = fpixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixCopy( fpixdPTR, fpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (326, 1)
' fpixResizeImageData()
' fpixResizeImageData(FPIX *, FPIX *) as l_ok
'''  <summary>
''' Notes
''' (1) If the data sizes differ, this destroys the existing
''' data in fpixd and allocates a new, uninitialized, data array
''' of the same size as the data in fpixs.  Otherwise, this
''' doesn't do anything.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixd">[in] - </param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixResizeImageData(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as Integer

	If IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixResizeImageData( fpixd.Pointer, fpixs.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (369, 1)
' fpixDestroy()
' fpixDestroy(FPIX **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the fpix.
''' (2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pfpix">[in,out] - will be nulled</param>
Public Shared Sub fpixDestroy(
				ByRef pfpix as FPix)


	Dim pfpixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pfpix) Then pfpixPTR = pfpix.Pointer

	LeptonicaSharp.Natives.fpixDestroy( pfpixPTR)
	if pfpixPTR <> IntPtr.Zero then pfpix = new FPix(pfpixPTR)

End Sub

' SRC\fpix1.c (408, 1)
' fpixGetDimensions()
' fpixGetDimensions(FPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixGetDimensions(
				ByVal fpix as FPix, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixGetDimensions( fpix.Pointer, pw, ph)

	Return _Result
End Function

' SRC\fpix1.c (434, 1)
' fpixSetDimensions()
' fpixSetDimensions(FPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetDimensions(
				ByVal fpix as FPix, 
				ByVal w as Integer, 
				ByVal h as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixSetDimensions( fpix.Pointer, w, h)

	Return _Result
End Function

' SRC\fpix1.c (455, 1)
' fpixGetWpl()
' fpixGetWpl(FPIX *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''   <returns>wpl, or UNDEF on error</returns>
Public Shared Function fpixGetWpl(
				ByVal fpix as FPix) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixGetWpl( fpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (473, 1)
' fpixSetWpl()
' fpixSetWpl(FPIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="wpl">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetWpl(
				ByVal fpix as FPix, 
				ByVal wpl as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixSetWpl( fpix.Pointer, wpl)

	Return _Result
End Function

' SRC\fpix1.c (493, 1)
' fpixGetRefcount()
' fpixGetRefcount(FPIX *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function fpixGetRefcount(
				ByVal fpix as FPix) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixGetRefcount( fpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (511, 1)
' fpixChangeRefcount()
' fpixChangeRefcount(FPIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixChangeRefcount(
				ByVal fpix as FPix, 
				ByVal delta as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixChangeRefcount( fpix.Pointer, delta)

	Return _Result
End Function

' SRC\fpix1.c (532, 1)
' fpixGetResolution()
' fpixGetResolution(FPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="pxres">[out][optional] - x and y resolution</param>
'''  <param name="pyres">[out][optional] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixGetResolution(
				ByVal fpix as FPix, 
				ByRef pxres as Integer, 
				ByRef pyres as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixGetResolution( fpix.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\fpix1.c (554, 1)
' fpixSetResolution()
' fpixSetResolution(FPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="xres">[in] - x and y resolution</param>
'''  <param name="yres">[in] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetResolution(
				ByVal fpix as FPix, 
				ByVal xres as Integer, 
				ByVal yres as Integer) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixSetResolution( fpix.Pointer, xres, yres)

	Return _Result
End Function

' SRC\fpix1.c (576, 1)
' fpixCopyResolution()
' fpixCopyResolution(FPIX *, FPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixd">[in] - </param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixCopyResolution(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as Integer

	If IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixCopyResolution( fpixd.Pointer, fpixs.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (598, 1)
' fpixGetData()
' fpixGetData(FPIX *) as l_float32 *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''   <returns>ptr FPixdata, or NULL on error</returns>
Public Shared Function fpixGetData(
				ByVal fpix as FPix) as Single()

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Single() = LeptonicaSharp.Natives.fpixGetData( fpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (616, 1)
' fpixSetData()
' fpixSetData(FPIX *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="data">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixSetData(
				ByVal fpix as FPix, 
				ByVal data as Single()) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixSetData( fpix.Pointer, data)

	Return _Result
End Function

' SRC\fpix1.c (638, 1)
' fpixGetPixel()
' fpixGetPixel(FPIX *, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fpixGetPixel(
				ByVal fpix as FPix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByRef pval as Single()) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixGetPixel( fpix.Pointer, x, y, pval)

	Return _Result
End Function

' SRC\fpix1.c (673, 1)
' fpixSetPixel()
' fpixSetPixel(FPIX *, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fpixSetPixel(
				ByVal fpix as FPix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal val as Single) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixSetPixel( fpix.Pointer, x, y, val)

	Return _Result
End Function

' SRC\fpix1.c (706, 1)
' fpixaCreate()
' fpixaCreate(l_int32) as FPIXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>fpixa, or NULL on error</returns>
Public Shared Function fpixaCreate(
				ByVal n as Integer) as FPixa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\fpix1.c (746, 1)
' fpixaCopy()
' fpixaCopy(FPIXA *, l_int32) as FPIXA *
'''  <summary>
''' Notes
''' copyflag may be one of
''' ~ L_COPY makes a new fpixa and copies each fpix
''' ~ L_CLONE gives a new ref-counted handle to the input fpixa
''' ~ L_COPY_CLONE makes a new fpixa with clones of all fpix
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY, L_CLODE or L_COPY_CLONE</param>
'''   <returns>new fpixa, or NULL on error</returns>
Public Shared Function fpixaCopy(
				ByVal fpixa as FPixa, 
				ByVal copyflag as Integer) as FPixa

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaCopy( fpixa.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\fpix1.c (793, 1)
' fpixaDestroy()
' fpixaDestroy(FPIXA **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the fpixa.
''' (2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pfpixa">[in,out] - to be nulled</param>
Public Shared Sub fpixaDestroy(
				ByRef pfpixa as FPixa)


	Dim pfpixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pfpixa) Then pfpixaPTR = pfpixa.Pointer

	LeptonicaSharp.Natives.fpixaDestroy( pfpixaPTR)
	if pfpixaPTR <> IntPtr.Zero then pfpixa = new FPixa(pfpixaPTR)

End Sub

' SRC\fpix1.c (834, 1)
' fpixaAddFPix()
' fpixaAddFPix(FPIXA *, FPIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="fpix">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fpixaAddFPix(
				ByVal fpixa as FPixa, 
				ByVal fpix as FPix, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaAddFPix( fpixa.Pointer, fpix.Pointer, copyflag)

	Return _Result
End Function

' SRC\fpix1.c (934, 1)
' fpixaGetCount()
' fpixaGetCount(FPIXA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''   <returns>count, or 0 if no pixa</returns>
Public Shared Function fpixaGetCount(
				ByVal fpixa as FPixa) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaGetCount( fpixa.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (953, 1)
' fpixaChangeRefcount()
' fpixaChangeRefcount(FPIXA *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixaChangeRefcount(
				ByVal fpixa as FPixa, 
				ByVal delta as Integer) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaChangeRefcount( fpixa.Pointer, delta)

	Return _Result
End Function

' SRC\fpix1.c (975, 1)
' fpixaGetFPix()
' fpixaGetFPix(FPIXA *, l_int32, l_int32) as FPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - to the index-th fpix</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixaGetFPix(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal accesstype as Enumerations.L_access_storage) as FPix

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaGetFPix( fpixa.Pointer, index, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (1004, 1)
' fpixaGetFPixDimensions()
' fpixaGetFPixDimensions(FPIXA *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixaGetFPixDimensions(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaGetFPixDimensions( fpixa.Pointer, index, pw, ph)

	Return _Result
End Function

' SRC\fpix1.c (1038, 1)
' fpixaGetData()
' fpixaGetData(FPIXA *, l_int32) as l_float32 *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''   <returns>data not a copy, or NULL on error</returns>
Public Shared Function fpixaGetData(
				ByVal fpixa as FPixa, 
				ByVal index as Integer) as Single()

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as Single() = LeptonicaSharp.Natives.fpixaGetData( fpixa.Pointer, index)

	Return _Result
End Function

' SRC\fpix1.c (1070, 1)
' fpixaGetPixel()
' fpixaGetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fpixaGetPixel(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByRef pval as Single()) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaGetPixel( fpixa.Pointer, index, x, y, pval)

	Return _Result
End Function

' SRC\fpix1.c (1107, 1)
' fpixaSetPixel()
' fpixaSetPixel(FPIXA *, l_int32, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - </param>
'''  <param name="index">[in] - into fpixa array</param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fpixaSetPixel(
				ByVal fpixa as FPixa, 
				ByVal index as Integer, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal val as Single) as Integer

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixaSetPixel( fpixa.Pointer, index, x, y, val)

	Return _Result
End Function

' SRC\fpix1.c (1148, 1)
' dpixCreate()
' dpixCreate(l_int32, l_int32) as DPIX *
'''  <summary>
''' Notes
''' (1) Makes a DPix of specified size, with the data array
''' allocated and initialized to 0.
''' (2) The number of pixels must be less than 2^28.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="width">[in] - </param>
'''  <param name="height">[in] - </param>
'''   <returns>dpix  with data allocated and initialized to 0, or NULL on error</returns>
Public Shared Function dpixCreate(
				ByVal width as Integer, 
				ByVal height as Integer) as DPix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixCreate( width, height)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (1198, 1)
' dpixCreateTemplate()
' dpixCreateTemplate(DPIX *) as DPIX *
'''  <summary>
''' Notes
''' (1) Makes a DPix of the same size as the input DPix, with the
''' data array allocated and initialized to 0.
''' (2) Copies the resolution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd, or NULL on error</returns>
Public Shared Function dpixCreateTemplate(
				ByVal dpixs as DPix) as DPix

	If IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixCreateTemplate( dpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (1227, 1)
' dpixClone()
' dpixClone(DPIX *) as DPIX *
'''  <summary>
''' Notes
''' (1) See pixClone() for definition and usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''   <returns>same dpix ptr, or NULL on error</returns>
Public Shared Function dpixClone(
				ByVal dpix as DPix) as DPix

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixClone( dpix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (1270, 1)
' dpixCopy()
' dpixCopy(DPIX *, DPIX *) as DPIX *
'''  <summary>
''' Notes
''' (1) There are three cases
''' (a) dpixd == null  (makes a new dpix; refcount = 1)
''' (b) dpixd == dpixs  (no-op)
''' (c) dpixd != dpixs  (data copy; no change in refcount)
''' If the refcount of dpixd GT 1, case (c) will side-effect
''' these handles.
''' (2) The general pattern of use is
''' dpixd = dpixCopy(dpixd, dpixs);
''' This will work for all three cases.
''' For clarity when the case is known, you can use
''' (a) dpixd = dpixCopy(NULL, dpixs);
''' (c) dpixCopy(dpixd, dpixs);
''' (3) For case (c), we check if dpixs and dpixd are the same size.
''' If so, the data is copied directly.
''' Otherwise, the data is reallocated to the correct size
''' and the copy proceeds.  The refcount of dpixd is unchanged.
''' (4) This operation, like all others that may involve a pre-existing
''' dpixd, will side-effect any existing clones of dpixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpixd">[in][optional] - ; can be null, or equal to dpixs, or different from dpixs</param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd, or NULL on error</returns>
Public Shared Function dpixCopy(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as DPix

	If IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")

	Dim dpixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(dpixd) Then dpixdPTR = dpixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixCopy( dpixdPTR, dpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (1316, 1)
' dpixResizeImageData()
' dpixResizeImageData(DPIX *, DPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpixd">[in] - </param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixResizeImageData(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as Integer

	If IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
	If IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixResizeImageData( dpixd.Pointer, dpixs.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1359, 1)
' dpixDestroy()
' dpixDestroy(DPIX **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the dpix.
''' (2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdpix">[in,out] - will be nulled</param>
Public Shared Sub dpixDestroy(
				ByRef pdpix as DPix)


	Dim pdpixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdpix) Then pdpixPTR = pdpix.Pointer

	LeptonicaSharp.Natives.dpixDestroy( pdpixPTR)
	if pdpixPTR <> IntPtr.Zero then pdpix = new DPix(pdpixPTR)

End Sub

' SRC\fpix1.c (1398, 1)
' dpixGetDimensions()
' dpixGetDimensions(DPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixGetDimensions(
				ByVal dpix as DPix, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixGetDimensions( dpix.Pointer, pw, ph)

	Return _Result
End Function

' SRC\fpix1.c (1424, 1)
' dpixSetDimensions()
' dpixSetDimensions(DPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetDimensions(
				ByVal dpix as DPix, 
				ByVal w as Integer, 
				ByVal h as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixSetDimensions( dpix.Pointer, w, h)

	Return _Result
End Function

' SRC\fpix1.c (1445, 1)
' dpixGetWpl()
' dpixGetWpl(DPIX *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''   <returns>wpl, or UNDEF on error</returns>
Public Shared Function dpixGetWpl(
				ByVal dpix as DPix) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixGetWpl( dpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1463, 1)
' dpixSetWpl()
' dpixSetWpl(DPIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="wpl">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetWpl(
				ByVal dpix as DPix, 
				ByVal wpl as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixSetWpl( dpix.Pointer, wpl)

	Return _Result
End Function

' SRC\fpix1.c (1483, 1)
' dpixGetRefcount()
' dpixGetRefcount(DPIX *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function dpixGetRefcount(
				ByVal dpix as DPix) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixGetRefcount( dpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1501, 1)
' dpixChangeRefcount()
' dpixChangeRefcount(DPIX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixChangeRefcount(
				ByVal dpix as DPix, 
				ByVal delta as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixChangeRefcount( dpix.Pointer, delta)

	Return _Result
End Function

' SRC\fpix1.c (1522, 1)
' dpixGetResolution()
' dpixGetResolution(DPIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="pxres">[out][optional] - x and y resolution</param>
'''  <param name="pyres">[out][optional] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixGetResolution(
				ByVal dpix as DPix, 
				ByRef pxres as Integer, 
				ByRef pyres as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixGetResolution( dpix.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\fpix1.c (1544, 1)
' dpixSetResolution()
' dpixSetResolution(DPIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="xres">[in] - x and y resolution</param>
'''  <param name="yres">[in] - x and y resolution</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetResolution(
				ByVal dpix as DPix, 
				ByVal xres as Integer, 
				ByVal yres as Integer) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixSetResolution( dpix.Pointer, xres, yres)

	Return _Result
End Function

' SRC\fpix1.c (1566, 1)
' dpixCopyResolution()
' dpixCopyResolution(DPIX *, DPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpixd">[in] - </param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixCopyResolution(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as Integer

	If IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
	If IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixCopyResolution( dpixd.Pointer, dpixs.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1588, 1)
' dpixGetData()
' dpixGetData(DPIX *) as l_float64 *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''   <returns>ptr DPixdata, or NULL on error</returns>
Public Shared Function dpixGetData(
				ByVal dpix as DPix) as Double()

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Double() = LeptonicaSharp.Natives.dpixGetData( dpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1606, 1)
' dpixSetData()
' dpixSetData(DPIX *, l_float64 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="data">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixSetData(
				ByVal dpix as DPix, 
				ByVal data as Double()) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixSetData( dpix.Pointer, data)

	Return _Result
End Function

' SRC\fpix1.c (1628, 1)
' dpixGetPixel()
' dpixGetPixel(DPIX *, l_int32, l_int32, l_float64 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="pval">[out] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function dpixGetPixel(
				ByVal dpix as DPix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByRef pval as Double()) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixGetPixel( dpix.Pointer, x, y, pval)

	Return _Result
End Function

' SRC\fpix1.c (1663, 1)
' dpixSetPixel()
' dpixSetPixel(DPIX *, l_int32, l_int32, l_float64) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpix">[in] - </param>
'''  <param name="x">[in] - ,y pixel coords</param>
'''  <param name="val">[in] - pixel value</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function dpixSetPixel(
				ByVal dpix as DPix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal val as Double) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixSetPixel( dpix.Pointer, x, y, val)

	Return _Result
End Function

' SRC\fpix1.c (1696, 1)
' fpixRead()
' fpixRead(const char *) as FPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixRead(
				ByVal filename as String) as FPix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (1723, 1)
' fpixReadStream()
' fpixReadStream(FILE *) as FPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixReadStream(
				ByVal fp as FILE) as FPix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (1776, 1)
' fpixReadMem()
' fpixReadMem(const l_uint8 *, size_t) as FPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - of serialized fpix</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>fpix, or NULL on error</returns>
Public Shared Function fpixReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as FPix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (1804, 1)
' fpixWrite()
' fpixWrite(const char *, FPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWrite(
				ByVal filename as String, 
				ByVal fpix as FPix) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixWrite( filename, fpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1835, 1)
' fpixWriteStream()
' fpixWriteStream(FILE *, FPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWriteStream(
				ByVal fp as FILE, 
				ByVal fpix as FPix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixWriteStream( fp.Pointer, fpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (1881, 1)
' fpixWriteMem()
' fpixWriteMem(l_uint8 **, size_t *, FPIX *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a fpix in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized fpix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="fpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal fpix as FPix) as Integer

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.fpixWriteMem( pdataPTR, psize, fpix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\fpix1.c (1941, 1)
' fpixEndianByteSwap()
' fpixEndianByteSwap(FPIX *, FPIX *) as FPIX *
'''  <summary>
''' Notes
''' (1) On big-endian hardware, this does byte-swapping on each of
''' the 4-byte floats in the fpix data.  On little-endians,
''' the data is unchanged.  This is used for serialization
''' of fpix; the data is serialized in little-endian byte
''' order because most hardware is little-endian.
''' (2) The operation can be either in-place or, if fpixd == NULL,
''' a new fpix is made.  If not in-place, caller must catch
''' the returned pointer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixd">[in] - can be equal to fpixs or NULL</param>
'''  <param name="fpixs">[in] - </param>
'''   <returns>fpixd always</returns>
Public Shared Function fpixEndianByteSwap(
				ByVal fpixd as FPix, 
				ByVal fpixs as FPix) as FPix

	If IsNothing (fpixd) then Throw New ArgumentNullException  ("fpixd cannot be Nothing")
	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixEndianByteSwap( fpixd.Pointer, fpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPix(_Result)
End Function

' SRC\fpix1.c (1993, 1)
' dpixRead()
' dpixRead(const char *) as DPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixRead(
				ByVal filename as String) as DPix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (2020, 1)
' dpixReadStream()
' dpixReadStream(FILE *) as DPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixReadStream(
				ByVal fp as FILE) as DPix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (2073, 1)
' dpixReadMem()
' dpixReadMem(const l_uint8 *, size_t) as DPIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - of serialized dpix</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>dpix, or NULL on error</returns>
Public Shared Function dpixReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as DPix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (2101, 1)
' dpixWrite()
' dpixWrite(const char *, DPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWrite(
				ByVal filename as String, 
				ByVal dpix as DPix) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixWrite( filename, dpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (2132, 1)
' dpixWriteStream()
' dpixWriteStream(FILE *, DPIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWriteStream(
				ByVal fp as FILE, 
				ByVal dpix as DPix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dpixWriteStream( fp.Pointer, dpix.Pointer)

	Return _Result
End Function

' SRC\fpix1.c (2178, 1)
' dpixWriteMem()
' dpixWriteMem(l_uint8 **, size_t *, DPIX *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a dpix in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized dpix</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="dpix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dpixWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal dpix as DPix) as Integer

	If IsNothing (dpix) then Throw New ArgumentNullException  ("dpix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.dpixWriteMem( pdataPTR, psize, dpix.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\fpix1.c (2238, 1)
' dpixEndianByteSwap()
' dpixEndianByteSwap(DPIX *, DPIX *) as DPIX *
'''  <summary>
''' Notes
''' (1) On big-endian hardware, this does byte-swapping on each of
''' the 4-byte words in the dpix data.  On little-endians,
''' the data is unchanged.  This is used for serialization
''' of dpix; the data is serialized in little-endian byte
''' order because most hardware is little-endian.
''' (2) The operation can be either in-place or, if dpixd == NULL,
''' a new dpix is made.  If not in-place, caller must catch
''' the returned pointer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dpixd">[in] - can be equal to dpixs or NULL</param>
'''  <param name="dpixs">[in] - </param>
'''   <returns>dpixd always</returns>
Public Shared Function dpixEndianByteSwap(
				ByVal dpixd as DPix, 
				ByVal dpixs as DPix) as DPix

	If IsNothing (dpixd) then Throw New ArgumentNullException  ("dpixd cannot be Nothing")
	If IsNothing (dpixs) then Throw New ArgumentNullException  ("dpixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dpixEndianByteSwap( dpixd.Pointer, dpixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DPix(_Result)
End Function

' SRC\fpix1.c (2297, 1)
' fpixPrintStream()
' fpixPrintStream(FILE *, FPIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Subsampled printout of fpix for debugging.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="fpix">[in] - </param>
'''  <param name="factor">[in] - subsampled</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fpixPrintStream(
				ByVal fp as FILE, 
				ByVal fpix as FPix, 
				ByVal factor as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fpixPrintStream( fp.Pointer, fpix.Pointer, factor)

	Return _Result
End Function

End Class
