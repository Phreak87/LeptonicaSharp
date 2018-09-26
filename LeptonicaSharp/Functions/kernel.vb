Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\kernel.c (106, 1)
' kernelCreate()
' kernelCreate(l_int32, l_int32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) kernelCreate() initializes all values to 0.
''' (2) After this call, (cy,cx) and nonzero data values must be
''' assigned.
''' (2) The number of kernel elements must be less than 2^29.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="height">[in] - </param>
'''  <param name="width">[in] - </param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function kernelCreate(
				ByVal height as Integer, 
				ByVal width as Integer) as L_Kernel



	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelCreate( height, width)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (144, 1)
' kernelDestroy()
' kernelDestroy(L_KERNEL **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pkel">[in,out] - to be nulled</param>
Public Shared Sub kernelDestroy(
				ByRef pkel as L_Kernel)


	Dim pkelPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pkel) Then pkelPTR = pkel.Pointer

	LeptonicaSharp.Natives.kernelDestroy( pkelPTR)
	if pkelPTR <> IntPtr.Zero then pkel = new L_Kernel(pkelPTR)

End Sub

' SRC\kernel.c (175, 1)
' kernelCopy()
' kernelCopy(L_KERNEL *) as L_KERNEL *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kels">[in] - source kernel</param>
'''   <returns>keld copy of kels, or NULL on error</returns>
Public Shared Function kernelCopy(
				ByVal kels as L_Kernel) as L_Kernel

	If IsNothing (kels) then Throw New ArgumentNullException  ("kels cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelCopy( kels.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (211, 1)
' kernelGetElement()
' kernelGetElement(L_KERNEL *, l_int32, l_int32, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - </param>
'''  <param name="row">[in] - </param>
'''  <param name="col">[in] - </param>
'''  <param name="pval">[out] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function kernelGetElement(
				ByVal kel as L_Kernel, 
				ByVal row as Integer, 
				ByVal col as Integer, 
				ByRef pval as Single()) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelGetElement( kel.Pointer, row, col, pval)

	Return _Result
End Function

' SRC\kernel.c (243, 1)
' kernelSetElement()
' kernelSetElement(L_KERNEL *, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="row">[in] - </param>
'''  <param name="col">[in] - </param>
'''  <param name="val">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function kernelSetElement(
				ByVal kel as L_Kernel, 
				ByVal row as Integer, 
				ByVal col as Integer, 
				ByVal val as Single) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelSetElement( kel.Pointer, row, col, val)

	Return _Result
End Function

' SRC\kernel.c (270, 1)
' kernelGetParameters()
' kernelGetParameters(L_KERNEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="psy">[out][optional] - each can be null</param>
'''  <param name="psx">[out][optional] - each can be null</param>
'''  <param name="pcy">[out][optional] - each can be null</param>
'''  <param name="pcx">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function kernelGetParameters(
				ByVal kel as L_Kernel, 
				Optional ByRef psy as Integer = Nothing, 
				Optional ByRef psx as Integer = Nothing, 
				Optional ByRef pcy as Integer = Nothing, 
				Optional ByRef pcx as Integer = Nothing) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelGetParameters( kel.Pointer, psy, psx, pcy, pcx)

	Return _Result
End Function

' SRC\kernel.c (300, 1)
' kernelSetOrigin()
' kernelSetOrigin(L_KERNEL *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="cy">[in] - </param>
'''  <param name="cx">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function kernelSetOrigin(
				ByVal kel as L_Kernel, 
				ByVal cy as Integer, 
				ByVal cx as Integer) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelSetOrigin( kel.Pointer, cy, cx)

	Return _Result
End Function

' SRC\kernel.c (322, 1)
' kernelGetSum()
' kernelGetSum(L_KERNEL *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="psum">[out] - sum of all kernel values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function kernelGetSum(
				ByVal kel as L_Kernel, 
				ByRef psum as Single()) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelGetSum( kel.Pointer, psum)

	Return _Result
End Function

' SRC\kernel.c (354, 1)
' kernelGetMinMax()
' kernelGetMinMax(L_KERNEL *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="pmin">[out][optional] - minimum value</param>
'''  <param name="pmax">[out][optional] - maximum value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function kernelGetMinMax(
				ByVal kel as L_Kernel, 
				Optional ByRef pmin as Single() = Nothing, 
				Optional ByRef pmax as Single() = Nothing) as Integer

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelGetMinMax( kel.Pointer, pmin, pmax)

	Return _Result
End Function

' SRC\kernel.c (410, 1)
' kernelNormalize()
' kernelNormalize(L_KERNEL *, l_float32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) If the sum of kernel elements is close to 0, do not
''' try to calculate the normalized kernel.  Instead,
''' return a copy of the input kernel, with a warning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kels">[in] - source kel, to be normalized</param>
'''  <param name="normsum">[in] - desired sum of elements in keld</param>
'''   <returns>keld normalized version of kels, or NULL on error or if sum of elements is very close to 0)</returns>
Public Shared Function kernelNormalize(
				ByVal kels as L_Kernel, 
				ByVal normsum as Single) as L_Kernel

	If IsNothing (kels) then Throw New ArgumentNullException  ("kels cannot be Nothing")
	If IsNothing (normsum) then Throw New ArgumentNullException  ("normsum cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelNormalize( kels.Pointer, normsum)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (456, 1)
' kernelInvert()
' kernelInvert(L_KERNEL *) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) For convolution, the kernel is spatially inverted before
''' a "correlation" operation is done between the kernel and the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kels">[in] - source kel, to be inverted</param>
'''   <returns>keld spatially inverted, about the origin, or NULL on error</returns>
Public Shared Function kernelInvert(
				ByVal kels as L_Kernel) as L_Kernel

	If IsNothing (kels) then Throw New ArgumentNullException  ("kels cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelInvert( kels.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (499, 1)
' create2dFloatArray()
' create2dFloatArray(l_int32, l_int32) as l_float32 **
'''  <summary>
''' Notes
''' (1) The array[sy][sx] is indexed in standard "matrix notation",
''' with the row index first.
''' (2) The caller kernelCreate() limits the size to LT 2^29 pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sy">[in] - rows == height</param>
'''  <param name="sx">[in] - columns == width</param>
'''   <returns>doubly indexed array i.e., an array of sy row pointers, each of which points to an array of sx floats</returns>
Public Shared Function create2dFloatArray(
				ByVal sy as Integer, 
				ByVal sx as Integer) as List(Of Single())



	Dim _Result as IntPtr = LeptonicaSharp.Natives.create2dFloatArray( sy, sx)
Dim PTRArr(1) As IntPtr : Marshal.Copy(_Result, PTRArr, 0, PTRArr.Length)
Dim B As New List(Of Single())
For Each eintrag In PTRArr
Dim SingleLST(1) As Single
Marshal.Copy(eintrag, SingleLST, 0, SingleLST.Count)
B.Add(SingleLST)
Next

	Return B
End Function

' SRC\kernel.c (526, 1)
' kernelRead()
' kernelRead(const char *) as L_KERNEL *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function kernelRead(
				ByVal fname as String) as L_Kernel

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelRead( fname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (555, 1)
' kernelReadStream()
' kernelReadStream(FILE *) as L_KERNEL *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function kernelReadStream(
				ByVal fp as FILE) as L_Kernel

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (598, 1)
' kernelWrite()
' kernelWrite(const char *, L_KERNEL *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - output file</param>
'''  <param name="kel">[in] - kernel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function kernelWrite(
				ByVal fname as String, 
				ByVal kel as L_Kernel) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelWrite( fname, kel.Pointer)

	Return _Result
End Function

' SRC\kernel.c (627, 1)
' kernelWriteStream()
' kernelWriteStream(FILE *, L_KERNEL *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="kel">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function kernelWriteStream(
				ByVal fp as FILE, 
				ByVal kel as L_Kernel) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.kernelWriteStream( fp.Pointer, kel.Pointer)

	Return _Result
End Function

' SRC\kernel.c (679, 1)
' kernelCreateFromString()
' kernelCreateFromString(l_int32, l_int32, l_int32, l_int32, const char *) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) The data is an array of chars, in row-major order, giving
''' space separated integers in the range [-255 ... 255].
''' (2) The only other formatting limitation is that you must
''' leave space between the last number in each row and
''' the double-quote.  If possible, it's also nice to have each
''' line in the string represent a line in the kernel; e.g.,
''' static const char kdata =
''' " 20   50   20 "
''' " 70  140   70 "
''' " 20   50   20 ";
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="h">[in] - height, width</param>
'''  <param name="w">[in] - height, width</param>
'''  <param name="cy">[in] - origin</param>
'''  <param name="cx">[in] - origin</param>
'''  <param name="kdata">[in] - </param>
'''   <returns>kernel of the given size, or NULL on error</returns>
Public Shared Function kernelCreateFromString(
				ByVal h as Integer, 
				ByVal w as Integer, 
				ByVal cy as Integer, 
				ByVal cx as Integer, 
				ByVal kdata as String) as L_Kernel

	If IsNothing (kdata) then Throw New ArgumentNullException  ("kdata cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelCreateFromString( h, w, cy, cx, kdata)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (765, 1)
' kernelCreateFromFile()
' kernelCreateFromFile(const char *) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) The file contains, in the following order
''' ~ Any number of comment lines starting with '#' are ignored
''' ~ The height and width of the kernel
''' ~ The y and x values of the kernel origin
''' ~ The kernel data, formatted as lines of numbers (integers
''' or floats) for the kernel values in row-major order,
''' and with no other punctuation.
''' (Note this differs from kernelCreateFromString(),
''' where each line must begin and end with a double-quote
''' to tell the compiler it's part of a string.)
''' ~ The kernel specification ends when a blank line,
''' a comment line, or the end of file is reached.
''' (2) All lines must be left-justified.
''' (3) See kernelCreateFromString() for a description of the string
''' format for the kernel data.  As an example, here are the lines
''' of a valid kernel description file  In the file, all lines
''' are left-justified
''' \code
''' # small 3x3 kernel
''' 3 3
''' 1 1
''' 25.5   51 24.3
''' 70.2  146.3  73.4
''' 20  50.9  18.4
''' \endcode
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function kernelCreateFromFile(
				ByVal filename as String) as L_Kernel

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelCreateFromFile( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (865, 1)
' kernelCreateFromPix()
' kernelCreateFromPix(PIX *, l_int32, l_int32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) The origin must be positive and within the dimensions of the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="cy">[in] - origin of kernel</param>
'''  <param name="cx">[in] - origin of kernel</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function kernelCreateFromPix(
				ByVal pix as Pix, 
				ByVal cy as Integer, 
				ByVal cx as Integer) as L_Kernel

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelCreateFromPix( pix.Pointer, cy, cx)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (926, 1)
' kernelDisplayInPix()
' kernelDisplayInPix(L_KERNEL *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This gives a visual representation of a kernel.
''' (2) There are two modes of display
''' (a) Grid lines of minimum width 2, surrounding regions
''' representing kernel elements of minimum size 17,
''' with a "plus" mark at the kernel origin, or
''' (b) A pix without grid lines and using 1 pixel per kernel element.
''' (3) For both cases, the kernel absolute value is displayed,
''' normalized such that the maximum absolute value is 255.
''' (4) Large 2D separable kernels should be used for convolution
''' with two 1D kernels.  However, for the bilateral filter,
''' the computation time is independent of the size of the
''' 2D content kernel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="kel">[in] - kernel</param>
'''  <param name="size">[in] - of grid interiors; odd; either 1 or a minimum size of 17 is enforced</param>
'''  <param name="gthick">[in] - grid thickness; either 0 or a minimum size of 2 is enforced</param>
'''   <returns>pix display of kernel, or NULL on error</returns>
Public Shared Function kernelDisplayInPix(
				ByVal kel as L_Kernel, 
				ByVal size as Integer, 
				ByVal gthick as Integer) as Pix

	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.kernelDisplayInPix( kel.Pointer, size, gthick)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\kernel.c (1040, 1)
' parseStringForNumbers()
' parseStringForNumbers(const char *, const char *) as NUMA *
'''  <summary>
''' Notes
''' (1) The numbers can be ints or floats.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="str">[in] - string containing numbers; not changed</param>
'''  <param name="seps">[in] - string of characters that can be used between ints</param>
'''   <returns>numa of numbers found, or NULL on error</returns>
Public Shared Function parseStringForNumbers(
				ByVal str as String, 
				ByVal seps as String) as Numa

	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")
	If IsNothing (seps) then Throw New ArgumentNullException  ("seps cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.parseStringForNumbers( str, seps)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\kernel.c (1092, 1)
' makeFlatKernel()
' makeFlatKernel(l_int32, l_int32, l_int32, l_int32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) This is the same low-pass filtering kernel that is used
''' in the block convolution functions.
''' (2) The kernel origin (%cy, %cx) is typically placed as near
''' the center of the kernel as possible.  If height and
''' width are odd, then using cy = height / 2 and
''' cx = width / 2 places the origin at the exact center.
''' (3) This returns a normalized kernel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="height">[in] - </param>
'''  <param name="width">[in] - </param>
'''  <param name="cy">[in] - origin of kernel</param>
'''  <param name="cx">[in] - origin of kernel</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function makeFlatKernel(
				ByVal height as Integer, 
				ByVal width as Integer, 
				ByVal cy as Integer, 
				ByVal cx as Integer) as L_Kernel



	Dim _Result as IntPtr = LeptonicaSharp.Natives.makeFlatKernel( height, width, cy, cx)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (1137, 1)
' makeGaussianKernel()
' makeGaussianKernel(l_int32, l_int32, l_float32, l_float32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) The kernel size (sx, sy) = (2  halfwidth + 1, 2  halfheight + 1).
''' (2) The kernel center (cx, cy) = (halfwidth, halfheight).
''' (3) The halfwidth and halfheight are typically equal, and
''' are typically several times larger than the standard deviation.
''' (4) If pixConvolve() is invoked with normalization (the sum of
''' kernel elements = 1.0), use 1.0 for max (or any number that's
''' not too small or too large).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="stdev">[in] - standard deviation</param>
'''  <param name="max">[in] - value at (cx,cy)</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function makeGaussianKernel(
				ByVal halfheight as Integer, 
				ByVal halfwidth as Integer, 
				ByVal stdev as Single, 
				ByVal max as Single) as L_Kernel

	If IsNothing (stdev) then Throw New ArgumentNullException  ("stdev cannot be Nothing")
	If IsNothing (max) then Throw New ArgumentNullException  ("max cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.makeGaussianKernel( halfheight, halfwidth, stdev, max)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

' SRC\kernel.c (1191, 1)
' makeGaussianKernelSep()
' makeGaussianKernelSep(l_int32, l_int32, l_float32, l_float32, L_KERNEL **, L_KERNEL **) as l_ok
'''  <summary>
''' Notes
''' (1) See makeGaussianKernel() for description of input parameters.
''' (2) These kernels are constructed so that the result of both
''' normalized and un-normalized convolution will be the same
''' as when convolving with pixConvolve() using the full kernel.
''' (3) The trick for the un-normalized convolution is to have the
''' product of the two kernel elemets at (cx,cy) be equal to max,
''' not max2.  That's why the max for kely is 1.0.  If instead
''' we use sqrt(max) for both, the results are slightly less
''' accurate, when compared to using the full kernel in
''' makeGaussianKernel().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="stdev">[in] - standard deviation</param>
'''  <param name="max">[in] - value at (cx,cy)</param>
'''  <param name="pkelx">[out] - x part of kernel</param>
'''  <param name="pkely">[out] - y part of kernel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function makeGaussianKernelSep(
				ByVal halfheight as Integer, 
				ByVal halfwidth as Integer, 
				ByVal stdev as Single, 
				ByVal max as Single, 
				ByRef pkelx as L_Kernel, 
				ByRef pkely as L_Kernel) as Integer

	If IsNothing (stdev) then Throw New ArgumentNullException  ("stdev cannot be Nothing")
	If IsNothing (max) then Throw New ArgumentNullException  ("max cannot be Nothing")

	Dim pkelxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pkelx) Then pkelxPTR = pkelx.Pointer
	Dim pkelyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pkely) Then pkelyPTR = pkely.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.makeGaussianKernelSep( halfheight, halfwidth, stdev, max, pkelxPTR, pkelyPTR)
	if pkelxPTR <> IntPtr.Zero then pkelx = new L_Kernel(pkelxPTR)
	if pkelyPTR <> IntPtr.Zero then pkely = new L_Kernel(pkelyPTR)

	Return _Result
End Function

' SRC\kernel.c (1236, 1)
' makeDoGKernel()
' makeDoGKernel(l_int32, l_int32, l_float32, l_float32) as L_KERNEL *
'''  <summary>
''' Notes
''' (1) The DoG (difference of gaussians) is a wavelet mother
''' function with null total sum.  By subtracting two blurred
''' versions of the image, it acts as a bandpass filter for
''' frequencies passed by the narrow gaussian but stopped
''' by the wide one.See
''' http//en.wikipedia.org/wiki/Difference_of_Gaussians
''' (2) The kernel size (sx, sy) = (2  halfwidth + 1, 2  halfheight + 1).
''' (3) The kernel center (cx, cy) = (halfwidth, halfheight).
''' (4) The halfwidth and halfheight are typically equal, and
''' are typically several times larger than the standard deviation.
''' (5) The ratio is the ratio of standard deviations of the wide
''' to narrow gaussian.  It must be GT= 1.0; 1.0 is a no-op.
''' (6) Because the kernel is a null sum, it must be invoked without
''' normalization in pixConvolve().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="halfheight">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="halfwidth">[in] - sx = 2  halfwidth + 1, etc</param>
'''  <param name="stdev">[in] - standard deviation of narrower gaussian</param>
'''  <param name="ratio">[in] - of stdev for wide filter to stdev for narrow one</param>
'''   <returns>kernel, or NULL on error</returns>
Public Shared Function makeDoGKernel(
				ByVal halfheight as Integer, 
				ByVal halfwidth as Integer, 
				ByVal stdev as Single, 
				ByVal ratio as Single) as L_Kernel

	If IsNothing (stdev) then Throw New ArgumentNullException  ("stdev cannot be Nothing")
	If IsNothing (ratio) then Throw New ArgumentNullException  ("ratio cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.makeDoGKernel( halfheight, halfwidth, stdev, ratio)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

End Class
