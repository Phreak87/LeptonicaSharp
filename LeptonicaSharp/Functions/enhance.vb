Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\enhance.c (174, 1)
' pixGammaTRC()
' pixGammaTRC(PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) pixd must either be null or equal to pixs.
''' For in-place operation, set pixd == pixs
''' pixGammaTRC(pixs, pixs, ...);
''' To get a new image, set pixd == null
''' pixd = pixGammaTRC(NULL, pixs, ...);
''' (2) If pixs is colormapped, the colormap is transformed,
''' either in-place or in a copy of pixs.
''' (3) We use a gamma mapping between minval and maxval.
''' (4) If gamma LT 1.0, the image will appear darker;
''' if gamma GT 1.0, the image will appear lighter;
''' (5) If gamma = 1.0 and minval = 0 and maxval = 255, no
''' enhancement is performed; return a copy unless in-place,
''' in which case this is a no-op.
''' (6) For color images that are not colormapped, the mapping
''' is applied to each component.
''' (7) minval and maxval are not restricted to the interval [0, 255].
''' If minval LT 0, an input value of 0 is mapped to a
''' nonzero output.  This will turn black to gray.
''' If maxval GT 255, an input value of 255 is mapped to
''' an output value less than 255.  This will turn
''' white (e.g., in the background) to gray.
''' (8) Increasing minval darkens the image.
''' (9) Decreasing maxval bleaches the image.
''' (10) Simultaneously increasing minval and decreasing maxval
''' will darken the image and make the colors more intense;
''' e.g., minval = 50, maxval = 200.
''' (11) See numaGammaTRC() for further examples of use.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp; or 2, 4 or 8 bpp with colormap</param>
'''  <param name="gamma">[in] - gamma correction; must be GT 0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output; can be LT 0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output; can be GT 255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRC(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRC( pixdPTR, pixs.Pointer, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (242, 1)
' pixGammaTRCMasked()
' pixGammaTRCMasked(PIX *, PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Same as pixGammaTRC() except mapping is optionally over
''' a subset of pixels described by pixm.
''' (2) Masking does not work for colormapped images.
''' (3) See pixGammaTRC() for details on how to use the parameters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp; not colormapped</param>
'''  <param name="pixm">[in][optional] - null or 1 bpp</param>
'''  <param name="gamma">[in] - gamma correction; must be GT 0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output; can be LT 0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output; can be GT 255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRCMasked(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRCMasked( pixdPTR, pixs.Pointer, pixmPTR, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (306, 1)
' pixGammaTRCWithAlpha()
' pixGammaTRCWithAlpha(PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See usage notes in pixGammaTRC().
''' (2) This version saves the alpha channel.  It is only valid
''' for 32 bpp (no colormap), and is a bit slower.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="gamma">[in] - gamma correction; must be GT 0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output; can be LT 0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output; can be GT 255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRCWithAlpha(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRCWithAlpha( pixdPTR, pixs.Pointer, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (366, 1)
' numaGammaTRC()
' numaGammaTRC(l_float32, l_int32, l_int32) as NUMA *
'''  <summary>
''' Notes
''' (1) The map is returned as a numa; values are clipped to [0, 255].
''' (2) To force all intensities into a range within fraction delta
''' of white, use minval = -256  (1 - delta) / delta
''' maxval = 255
''' (3) To force all intensities into a range within fraction delta
''' of black, use minval = 0
''' maxval = 256  (1 - delta) / delta
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="gamma">[in] - gamma factor; must be GT 0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output</param>
'''  <param name="maxval">[in] - input value that gives 255 for output</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaGammaTRC(
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Numa

	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaGammaTRC( gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (436, 1)
' pixContrastTRC()
' pixContrastTRC(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) pixd must either be null or equal to pixs.
''' For in-place operation, set pixd == pixs
''' pixContrastTRC(pixs, pixs, ...);
''' To get a new image, set pixd == null
''' pixd = pixContrastTRC(NULL, pixs, ...);
''' (2) If pixs is colormapped, the colormap is transformed,
''' either in-place or in a copy of pixs.
''' (3) Contrast is enhanced by mapping each color component
''' using an atan function with maximum slope at 127.
''' Pixels below 127 are lowered in intensity and pixels
''' above 127 are increased.
''' (4) The useful range for the contrast factor is scaled to
''' be in (0.0 to 1.0), but larger values can also be used.
''' (5) If factor == 0.0, no enhancement is performed; return a copy
''' unless in-place, in which case this is a no-op.
''' (6) For color images that are not colormapped, the mapping
''' is applied to each component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp; or 2, 4 or 8 bpp with colormap</param>
'''  <param name="factor">[in] - 0.0 is no enhancement</param>
'''   <returns>pixd always</returns>
Public Shared Function pixContrastTRC(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal factor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixContrastTRC( pixdPTR, pixs.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (498, 1)
' pixContrastTRCMasked()
' pixContrastTRCMasked(PIX *, PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) Same as pixContrastTRC() except mapping is optionally over
''' a subset of pixels described by pixm.
''' (2) Masking does not work for colormapped images.
''' (3) See pixContrastTRC() for details on how to use the parameters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp; or 2, 4 or 8 bpp with colormap</param>
'''  <param name="pixm">[in][optional] - null or 1 bpp</param>
'''  <param name="factor">[in] - 0.0 is no enhancement</param>
'''   <returns>pixd always</returns>
Public Shared Function pixContrastTRCMasked(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal factor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixContrastTRCMasked( pixdPTR, pixs.Pointer, pixmPTR, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (557, 1)
' numaContrastTRC()
' numaContrastTRC(l_float32) as NUMA *
'''  <summary>
''' Notes
''' (1) The mapping is monotonic increasing, where 0 is mapped
''' to 0 and 255 is mapped to 255.
''' (2) As 'factor' is increased from 0.0 (where the mapping is linear),
''' the map gets closer to its limit as a step function that
''' jumps from 0 to 255 at the center (input value = 127).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="factor">[in] - generally between 0.0 [no enhancement] and 1.0, but can be larger than 1.0</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaContrastTRC(
				ByVal factor as Single) as Numa

	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaContrastTRC( factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (627, 1)
' pixEqualizeTRC()
' pixEqualizeTRC(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) pixd must either be null or equal to pixs.
''' For in-place operation, set pixd == pixs
''' pixEqualizeTRC(pixs, pixs, ...);
''' To get a new image, set pixd == null
''' pixd = pixEqualizeTRC(NULL, pixs, ...);
''' (2) In histogram equalization, a tone reproduction curve
''' mapping is used to make the number of pixels at each
''' intensity equal.
''' (3) If fract == 0.0, no equalization is performed; return a copy
''' unless in-place, in which case this is a no-op.
''' If fract == 1.0, equalization is complete.
''' (4) Set the subsampling factor GT 1 to reduce the amount of computation.
''' (5) If pixs is colormapped, the colormap is removed and
''' converted to rgb or grayscale.
''' (6) If pixs has color, equalization is done in each channel
''' separately.
''' (7) Note that even if there is a colormap, we can get an
''' in-place operation because the intermediate image pixt
''' is copied back to pixs (which for in-place is the same
''' as pixd).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 bpp gray, 32 bpp rgb, or colormapped</param>
'''  <param name="fract">[in] - fraction of equalization movement of pixel values</param>
'''  <param name="factor">[in] - subsampling factor; integer GT= 1</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixEqualizeTRC(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal fract as Single, 
				ByVal factor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixEqualizeTRC( pixdPTR, pixs.Pointer, fract, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (714, 1)
' numaEqualizeTRC()
' numaEqualizeTRC(PIX *, l_float32, l_int32) as NUMA *
'''  <summary>
''' Notes
''' (1) If fract == 0.0, no equalization will be performed.
''' If fract == 1.0, equalization is complete.
''' (2) Set the subsampling factor GT 1 to reduce the amount of computation.
''' (3) The map is returned as a numa with 256 values, specifying
''' the equalized value (array value) for every input value
''' (the array index).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp, no colormap</param>
'''  <param name="fract">[in] - fraction of equalization movement of pixel values</param>
'''  <param name="factor">[in] - subsampling factor; integer GT= 1</param>
'''   <returns>nad, or NULL on error</returns>
Public Shared Function numaEqualizeTRC(
				ByVal pix as Pix, 
				ByVal fract as Single, 
				ByVal factor as Integer) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaEqualizeTRC( pix.Pointer, fract, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (781, 1)
' pixTRCMap()
' pixTRCMap(PIX *, PIX *, NUMA *) as l_int32
'''  <summary>
''' Notes
''' (1) This operation is in-place on pixs.
''' (2) For 32 bpp, this applies the same map to each of the r,g,b
''' components.
''' (3) The mapping array is of size 256, and it maps the input
''' index into values in the range [0, 255].
''' (4) If defined, the optional 1 bpp mask pixm has its origin
''' aligned with pixs, and the map function is applied only
''' to pixels in pixs under the fg of pixm.
''' (5) For 32 bpp, this does not save the alpha channel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 grayscale or 32 bpp rgb; not colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="na">[in] - mapping array</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixTRCMap(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal na as Numa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixTRCMap( pixs.Pointer, pixmPTR, na.Pointer)

	Return _Result
End Function

' SRC\enhance.c (904, 1)
' pixUnsharpMasking()
' pixUnsharpMasking(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) We use symmetric smoothing filters of odd dimension,
''' typically use sizes of 3, 5, 7, etc.  The %halfwidth parameter
''' for these is (size - 1)/2; i.e., 1, 2, 3, etc.
''' (2) The fract parameter is typically taken in the
''' range  0.2 LT fract LT 0.7
''' (3) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths except 1 bpp; with or without colormaps</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter</param>
'''  <param name="fract">[in] - fraction of edge added back into image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMasking(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMasking( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (973, 1)
' pixUnsharpMaskingGray()
' pixUnsharpMaskingGray(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) We use symmetric smoothing filters of odd dimension,
''' typically use sizes of 3, 5, 7, etc.  The %halfwidth parameter
''' for these is (size - 1)/2; i.e., 1, 2, 3, etc.
''' (2) The fract parameter is typically taken in the range
''' 0.2 LT fract LT 0.7
''' (3) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter</param>
'''  <param name="fract">[in] - fraction of edge added back into image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1070, 1)
' pixUnsharpMaskingFast()
' pixUnsharpMaskingFast(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The fast version uses separable 1-D filters directly on
''' the input image.  The halfwidth is either 1 (full width = 3)
''' or 2 (full width = 5).
''' (2) The fract parameter is typically taken in the
''' range  0.2 LT fract LT 0.7
''' (3) To skip horizontal sharpening, use %fracth = 0.0; ditto for %fractv
''' (4) For one dimensional filtering (as an example)
''' For %halfwidth = 1, the low-pass filter is
''' L 1/3 1/3   1/3
''' and the high-pass filter is
''' H = I - L   -1/3   2/3   -1/3
''' For %halfwidth = 2, the low-pass filter is
''' L 1/5 1/5   1/5 1/5 1/5
''' and the high-pass filter is
''' H = I - L   -1/5  -1/5   4/5  -1/5   -1/5
''' The new sharpened pixel value is found by adding some fraction
''' of the high-pass filter value (which sums to 0) to the
''' initial pixel value
''' N = I + fract  H
''' (5) For 2D, the sharpening filter is not separable, because the
''' vertical filter depends on the horizontal location relative
''' to the filter origin, and v.v.   So we either do the full
''' 2D filter (for %halfwidth == 1) or do the low-pass
''' convolution separably and then compose with the original pix.
''' (6) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - all depths except 1 bpp; with or without colormaps</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter; 1 and 2 only</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT, L_BOTH_DIRECTIONS</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingFast(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single, 
				ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingFast( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1141, 1)
' pixUnsharpMaskingGrayFast()
' pixUnsharpMaskingGrayFast(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For usage and explanation of the algorithm, see notes
''' in pixUnsharpMaskingFast().
''' (2) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT, L_BOTH_DIRECTIONS</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGrayFast(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single, 
				ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGrayFast( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1190, 1)
' pixUnsharpMaskingGray1D()
' pixUnsharpMaskingGray1D(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For usage and explanation of the algorithm, see notes
''' in pixUnsharpMaskingFast().
''' (2) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - filtering direction; use L_HORIZ or L_VERT</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray1D(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single, 
				ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray1D( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1324, 1)
' pixUnsharpMaskingGray2D()
' pixUnsharpMaskingGray2D(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This is for %halfwidth == 1, 2.
''' (2) The lowpass filter is implemented separably.
''' (3) Returns a clone if no sharpening is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray2D(
				ByVal pixs as Pix, 
				ByVal halfwidth as Integer, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray2D( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1469, 1)
' pixModifyHue()
' pixModifyHue(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) pixd must either be null or equal to pixs.
''' For in-place operation, set pixd == pixs
''' pixEqualizeTRC(pixs, pixs, ...);
''' To get a new image, set pixd == null
''' pixd = pixEqualizeTRC(NULL, pixs, ...);
''' (1) Use fract GT 0.0 to increase hue value; LT 0.0 to decrease it.
''' 1.0 (or -1.0) represents a 360 degree rotation; i.e., no change.
''' (2) If no modification is requested (fract = -1.0 or 0 or 1.0),
''' return a copy unless in-place, in which case this is a no-op.
''' (3) See discussion of color-modification methods, in coloring.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - can be null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifyHue(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifyHue( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1542, 1)
' pixModifySaturation()
' pixModifySaturation(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) If fract GT 0.0, it gives the fraction that the pixel
''' saturation is moved from its initial value toward 255.
''' If fract LT 0.0, it gives the fraction that the pixel
''' saturation is moved from its initial value toward 0.
''' The limiting values for fract = -1.0 (1.0) thus set the
''' saturation to 0 (255).
''' (2) If fract = 0, no modification is requested; return a copy
''' unless in-place, in which case this is a no-op.
''' (3) See discussion of color-modification methods, in coloring.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - can be null, existing or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifySaturation(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifySaturation( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1597, 1)
' pixMeasureSaturation()
' pixMeasureSaturation(PIX *, l_int32, l_float32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="factor">[in] - subsampling factor; integer GT= 1</param>
'''  <param name="psat">[out] - average saturation</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMeasureSaturation(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByRef psat as Single()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixMeasureSaturation( pixs.Pointer, factor, psat)

	Return _Result
End Function

' SRC\enhance.c (1658, 1)
' pixModifyBrightness()
' pixModifyBrightness(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) If fract GT 0.0, it gives the fraction that the v-parameter,
''' which is max(r,g,b), is moved from its initial value toward 255.
''' If fract LT 0.0, it gives the fraction that the v-parameter
''' is moved from its initial value toward 0.
''' The limiting values for fract = -1.0 (1.0) thus set the
''' v-parameter to 0 (255).
''' (2) If fract = 0, no modification is requested; return a copy
''' unless in-place, in which case this is a no-op.
''' (3) See discussion of color-modification methods, in coloring.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - can be null, existing or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifyBrightness(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifyBrightness( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1737, 1)
' pixMosaicColorShiftRGB()
' pixMosaicColorShiftRGB(PIX *, l_float32, l_float32, l_float32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This generates a mosaic view of the effect of shifting the RGB
''' components.  See pixColorShiftRGB() for details on the shifting.
''' (2) The offsets (%roff, %goff, %boff) set the color center point,
''' and the deviations from this are shown separately for deltas
''' in r, g and b.  For each component, we show 2  %nincr + 1
''' images.
''' (3) Usage color prints differ from the original due to three factors
''' illumination, calibration of the camera in acquisition,
''' and calibration of the printer.  This function can be used
''' to iteratively match a color print to the original.  On each
''' iteration, the center offsets are set to the best match so
''' far, and the %delta increments are typically reduced.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="roff">[in] - center offset of red component</param>
'''  <param name="goff">[in] - center offset of green component</param>
'''  <param name="boff">[in] - center offset of blue component</param>
'''  <param name="delta">[in] - increments from center offsets [0.0 - 0.1]; use 0.0 to get the default (0.04)</param>
'''  <param name="nincr">[in] - number of increments in each (positive and negative) direction; use 0 to get the default (2).</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixMosaicColorShiftRGB(
				ByVal pixs as Pix, 
				ByVal roff as Single, 
				ByVal goff as Single, 
				ByVal boff as Single, 
				ByVal delta as Single, 
				ByVal nincr as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (roff) then Throw New ArgumentNullException  ("roff cannot be Nothing")
	If IsNothing (goff) then Throw New ArgumentNullException  ("goff cannot be Nothing")
	If IsNothing (boff) then Throw New ArgumentNullException  ("boff cannot be Nothing")
	If IsNothing (delta) then Throw New ArgumentNullException  ("delta cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMosaicColorShiftRGB( pixs.Pointer, roff, goff, boff, delta, nincr)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1833, 1)
' pixColorShiftRGB()
' pixColorShiftRGB(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This allows independent fractional shifts of the r,g and b
''' components.  A positive shift pushes to saturation (255);
''' a negative shift pushes toward 0 (black).
''' (2) The effect can be imagined using a color wheel that consists
''' (for our purposes) of these 6 colors, separated by 60 degrees
''' red, magenta, blue, cyan, green, yellow
''' (3) So, for example, a negative shift of the blue component
''' (bfract LT 0) could be accompanied by positive shifts
''' of red and green to make an image more yellow.
''' (4) Examples of limiting cases
''' rfract = 1 ==GT r = 255
''' rfract = -1 ==GT r = 0
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="rfract">[in] - fractional shift in red component</param>
'''  <param name="gfract">[in] - fractional shift in green component</param>
'''  <param name="bfract">[in] - fractional shift in blue component</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixColorShiftRGB(
				ByVal pixs as Pix, 
				ByVal rfract as Single, 
				ByVal gfract as Single, 
				ByVal bfract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rfract) then Throw New ArgumentNullException  ("rfract cannot be Nothing")
	If IsNothing (gfract) then Throw New ArgumentNullException  ("gfract cannot be Nothing")
	If IsNothing (bfract) then Throw New ArgumentNullException  ("bfract cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorShiftRGB( pixs.Pointer, rfract, gfract, bfract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1930, 1)
' pixDarkenGray()
' pixDarkenGray(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This darkens gray pixels, by a fraction (sat/%satlimit), where
''' the sat, the saturation, is the component difference (max - min).
''' The pixel value is unchanged if sat GT= %satlimit.  A typical
''' value of %satlimit might be 50; the larger the value, the
''' more that pixels with a smaller saturation will be darkened.
''' (2) Pixels with max component GT= %thresh are unchanged. This can be
''' used to prevent bright pixels with low saturation from being
''' darkened.  Setting thresh == 0 is a no-op; setting %thresh == 255
''' causes the darkening to be applied to all pixels.
''' (3) This function is useful to enhance pixels relative to a
''' gray background.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - can be null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="thresh">[in] - pixels with max component GT= %thresh are unchanged</param>
'''  <param name="satlimit">[in] - pixels with saturation GT= %satlimit are unchanged</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixDarkenGray(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal thresh as Integer, 
				ByVal satlimit as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDarkenGray( pixdPTR, pixs.Pointer, thresh, satlimit)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (2002, 1)
' pixMultConstantColor()
' pixMultConstantColor(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) rfact, gfact and bfact can only have non-negative values.
''' They can be greater than 1.0.  All transformed component
''' values are clipped to the interval [0, 255].
''' (2) For multiplication with a general 3x3 matrix of constants,
''' use pixMultMatrixColor().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - colormapped or rgb</param>
'''  <param name="rfact">[in] - red multiplicative factor</param>
'''  <param name="gfact">[in] - green multiplicative factor</param>
'''  <param name="bfact">[in] - blue multiplicative factor</param>
'''   <returns>pixd colormapped or rgb, with colors scaled, or NULL on error</returns>
Public Shared Function pixMultConstantColor(
				ByVal pixs as Pix, 
				ByVal rfact as Single, 
				ByVal gfact as Single, 
				ByVal bfact as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rfact) then Throw New ArgumentNullException  ("rfact cannot be Nothing")
	If IsNothing (gfact) then Throw New ArgumentNullException  ("gfact cannot be Nothing")
	If IsNothing (bfact) then Throw New ArgumentNullException  ("bfact cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMultConstantColor( pixs.Pointer, rfact, gfact, bfact)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (2104, 1)
' pixMultMatrixColor()
' pixMultMatrixColor(PIX *, L_KERNEL *) as PIX *
'''  <summary>
''' Notes
''' (1) The kernel is a data structure used mostly for floating point
''' convolution.  Here it is a 3x3 matrix of floats that are used
''' to transform the pixel values by matrix multiplication
''' nrval = a[0,0]  rval + a[0,1]  gval + a[0,2]  bval
''' ngval = a[1,0]  rval + a[1,1]  gval + a[1,2]  bval
''' nbval = a[2,0]  rval + a[2,1]  gval + a[2,2]  bval
''' (2) The matrix can be generated in several ways.
''' See kernel.c for details.  Here are two of them
''' (a) kel = kernelCreate(3, 3);
''' kernelSetElement(kel, 0, 0, val00);
''' kernelSetElement(kel, 0, 1, val01);
''' ...
''' (b) from a static string; e.g.,
''' const char kdata = " 0.6  0.3 -0.2 "
''' " 0.1  1.2  0.4 "
''' " -0.4 0.2  0.9 ";
''' kel = kernelCreateFromString(3, 3, 0, 0, kdata);
''' (3) For the special case where the matrix is diagonal, it is easier
''' to use pixMultConstantColor().
''' (4) Matrix entries can have positive and negative values, and can
''' be larger than 1.0.  All transformed component values
''' are clipped to [0, 255].
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - colormapped or rgb</param>
'''  <param name="kel">[in] - kernel 3x3 matrix of floats</param>
'''   <returns>pixd colormapped or rgb, or NULL on error</returns>
Public Shared Function pixMultMatrixColor(
				ByVal pixs as Pix, 
				ByVal kel as L_Kernel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (kel) then Throw New ArgumentNullException  ("kel cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMultMatrixColor( pixs.Pointer, kel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (2213, 1)
' pixHalfEdgeByBandpass()
' pixHalfEdgeByBandpass(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) We use symmetric smoothing filters of odd dimension,
''' typically use 3, 5, 7, etc.  The smoothing parameters
''' for these are 1, 2, 3, etc.  The filter size is related
''' to the smoothing parameter by
''' size = 2  smoothing + 1
''' (2) Because we take the difference of two lowpass filters,
''' this is actually a bandpass filter.
''' (3) We allow both filters to be anisotropic.
''' (4) Consider either the h or v component of the 2 filters.
''' Depending on whether sm1 GT sm2 or sm2 GT sm1, we get
''' different halves of the smoothed gradients (or "edges").
''' This difference of smoothed signals looks more like
''' a second derivative of a transition, which we rectify
''' by not allowing the signal to go below zero.  If sm1 LT sm2,
''' the sm2 transition is broader, so the difference between
''' sm1 and sm2 signals is positive on the upper half of
''' the transition.  Likewise, if sm1 GT sm2, the sm1 - sm2
''' signal difference is positive on the lower half of
''' the transition.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb</param>
'''  <param name="sm1h">[in] - "half-widths" of smoothing filter sm1</param>
'''  <param name="sm1v">[in] - "half-widths" of smoothing filter sm1</param>
'''  <param name="sm2h">[in] - "half-widths" of smoothing filter sm2; require sm2 != sm1</param>
'''  <param name="sm2v">[in] - "half-widths" of smoothing filter sm2; require sm2 != sm1</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixHalfEdgeByBandpass(
				ByVal pixs as Pix, 
				ByVal sm1h as Integer, 
				ByVal sm1v as Integer, 
				ByVal sm2h as Integer, 
				ByVal sm2v as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHalfEdgeByBandpass( pixs.Pointer, sm1h, sm1v, sm2h, sm2v)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
