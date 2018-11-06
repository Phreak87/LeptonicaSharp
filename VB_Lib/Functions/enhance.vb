Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\enhance.c (174, 1)
' pixGammaTRC(pixd, pixs, gamma, minval, maxval) as Pix
' pixGammaTRC(PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pixd must either be null or equal to pixs.<para/>
''' For in-place operation, set pixd == pixs:<para/>
''' pixGammaTRC(pixs, pixs, ...)<para/>
''' To get a new image, set pixd == null:<para/>
''' pixd = pixGammaTRC(NULL, pixs, ...)<para/>
''' (2) If pixs is colormapped, the colormap is transformed,<para/>
''' either in-place or in a copy of pixs.<para/>
''' (3) We use a gamma mapping between minval and maxval.<para/>
''' (4) If gamma  is lower  1.0, the image will appear darker<para/>
''' if gamma  is greater  1.0, the image will appear lighter<para/>
''' (5) If gamma = 1.0 and minval = 0 and maxval = 255, no<para/>
''' enhancement is performed return a copy unless in-place,<para/>
''' in which case this is a no-op.<para/>
''' (6) For color images that are not colormapped, the mapping<para/>
''' is applied to each component.<para/>
''' (7) minval and maxval are not restricted to the interval [0, 255].<para/>
''' If minval  is lower  0, an input value of 0 is mapped to a<para/>
''' nonzero output.  This will turn black to gray.<para/>
''' If maxval  is greater  255, an input value of 255 is mapped to<para/>
''' an output value less than 255.  This will turn<para/>
''' white (e.g., in the background) to gray.<para/>
''' (8) Increasing minval darkens the image.<para/>
''' (9) Decreasing maxval bleaches the image.<para/>
''' (10) Simultaneously increasing minval and decreasing maxval<para/>
''' will darken the image and make the colors more intense<para/>
''' e.g., minval = 50, maxval = 200.<para/>
''' (11) See numaGammaTRC() for further examples of use.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGammaTRC/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp or 2, 4 or 8 bpp with colormap</param>
'''  <param name="gamma">[in] - gamma correction must be  is greater  0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output can be  is lower  0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output can be  is greater  255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRC(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal gamma as Single, 
				 ByVal minval as Integer, 
				 ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRC( pixdPTR, pixs.Pointer, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (242, 1)
' pixGammaTRCMasked(pixd, pixs, pixm, gamma, minval, maxval) as Pix
' pixGammaTRCMasked(PIX *, PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Same as pixGammaTRC() except mapping is optionally over<para/>
''' a subset of pixels described by pixm.<para/>
''' (2) Masking does not work for colormapped images.<para/>
''' (3) See pixGammaTRC() for details on how to use the parameters.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGammaTRCMasked/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp not colormapped</param>
'''  <param name="pixm">[in][optional] - null or 1 bpp</param>
'''  <param name="gamma">[in] - gamma correction must be  is greater  0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output can be  is lower  0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output can be  is greater  255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRCMasked(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal gamma as Single, 
				 ByVal minval as Integer, 
				 ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRCMasked( pixdPTR, pixs.Pointer, pixmPTR, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (306, 1)
' pixGammaTRCWithAlpha(pixd, pixs, gamma, minval, maxval) as Pix
' pixGammaTRCWithAlpha(PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See usage notes in pixGammaTRC().<para/>
''' (2) This version saves the alpha channel.  It is only valid<para/>
''' for 32 bpp (no colormap), and is a bit slower.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGammaTRCWithAlpha/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="gamma">[in] - gamma correction must be  is greater  0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output can be  is lower  0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output can be  is greater  255</param>
'''   <returns>pixd always</returns>
Public Shared Function pixGammaTRCWithAlpha(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal gamma as Single, 
				 ByVal minval as Integer, 
				 ByVal maxval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGammaTRCWithAlpha( pixdPTR, pixs.Pointer, gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (366, 1)
' numaGammaTRC(gamma, minval, maxval) as Numa
' numaGammaTRC(l_float32, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The map is returned as a numa values are clipped to [0, 255].<para/>
''' (2) To force all intensities into a range within fraction delta<para/>
''' of white, use: minval = -256  (1 - delta) / delta<para/>
''' maxval = 255<para/>
''' (3) To force all intensities into a range within fraction delta<para/>
''' of black, use: minval = 0<para/>
''' maxval = 256  (1 - delta) / delta<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaGammaTRC/*"/>
'''  <param name="gamma">[in] - gamma factor must be  is greater  0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output</param>
'''  <param name="maxval">[in] - input value that gives 255 for output</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaGammaTRC(
				 ByVal gamma as Single, 
				 ByVal minval as Integer, 
				 ByVal maxval as Integer) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaGammaTRC( gamma, minval, maxval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (436, 1)
' pixContrastTRC(pixd, pixs, factor) as Pix
' pixContrastTRC(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pixd must either be null or equal to pixs.<para/>
''' For in-place operation, set pixd == pixs:<para/>
''' pixContrastTRC(pixs, pixs, ...)<para/>
''' To get a new image, set pixd == null:<para/>
''' pixd = pixContrastTRC(NULL, pixs, ...)<para/>
''' (2) If pixs is colormapped, the colormap is transformed,<para/>
''' either in-place or in a copy of pixs.<para/>
''' (3) Contrast is enhanced by mapping each color component<para/>
''' using an atan function with maximum slope at 127.<para/>
''' Pixels below 127 are lowered in intensity and pixels<para/>
''' above 127 are increased.<para/>
''' (4) The useful range for the contrast factor is scaled to<para/>
''' be in (0.0 to 1.0), but larger values can also be used.<para/>
''' (5) If factor == 0.0, no enhancement is performed return a copy<para/>
''' unless in-place, in which case this is a no-op.<para/>
''' (6) For color images that are not colormapped, the mapping<para/>
''' is applied to each component.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixContrastTRC/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp or 2, 4 or 8 bpp with colormap</param>
'''  <param name="factor">[in] - 0.0 is no enhancement</param>
'''   <returns>pixd always</returns>
Public Shared Function pixContrastTRC(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal factor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixContrastTRC( pixdPTR, pixs.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (498, 1)
' pixContrastTRCMasked(pixd, pixs, pixm, factor) as Pix
' pixContrastTRCMasked(PIX *, PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Same as pixContrastTRC() except mapping is optionally over<para/>
''' a subset of pixels described by pixm.<para/>
''' (2) Masking does not work for colormapped images.<para/>
''' (3) See pixContrastTRC() for details on how to use the parameters.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixContrastTRCMasked/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 or 32 bpp or 2, 4 or 8 bpp with colormap</param>
'''  <param name="pixm">[in][optional] - null or 1 bpp</param>
'''  <param name="factor">[in] - 0.0 is no enhancement</param>
'''   <returns>pixd always</returns>
Public Shared Function pixContrastTRCMasked(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal factor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixContrastTRCMasked( pixdPTR, pixs.Pointer, pixmPTR, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (557, 1)
' numaContrastTRC(factor) as Numa
' numaContrastTRC(l_float32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The mapping is monotonic increasing, where 0 is mapped<para/>
''' to 0 and 255 is mapped to 255.<para/>
''' (2) As 'factor' is increased from 0.0 (where the mapping is linear),<para/>
''' the map gets closer to its limit as a step function that<para/>
''' jumps from 0 to 255 at the center (input value = 127).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaContrastTRC/*"/>
'''  <param name="factor">[in] - generally between 0.0 [no enhancement] and 1.0, but can be larger than 1.0</param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function numaContrastTRC(
				 ByVal factor as Single) as Numa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaContrastTRC( factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (627, 1)
' pixEqualizeTRC(pixd, pixs, fract, factor) as Pix
' pixEqualizeTRC(PIX *, PIX *, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pixd must either be null or equal to pixs.<para/>
''' For in-place operation, set pixd == pixs:<para/>
''' pixEqualizeTRC(pixs, pixs, ...)<para/>
''' To get a new image, set pixd == null:<para/>
''' pixd = pixEqualizeTRC(NULL, pixs, ...)<para/>
''' (2) In histogram equalization, a tone reproduction curve<para/>
''' mapping is used to make the number of pixels at each<para/>
''' intensity equal.<para/>
''' (3) If fract == 0.0, no equalization is performed return a copy<para/>
''' unless in-place, in which case this is a no-op.<para/>
''' If fract == 1.0, equalization is complete.<para/>
''' (4) Set the subsampling factor  is greater  1 to reduce the amount of computation.<para/>
''' (5) If pixs is colormapped, the colormap is removed and<para/>
''' converted to rgb or grayscale.<para/>
''' (6) If pixs has color, equalization is done in each channel<para/>
''' separately.<para/>
''' (7) Note that even if there is a colormap, we can get an<para/>
''' in-place operation because the intermediate image pixt<para/>
''' is copied back to pixs (which for in-place is the same<para/>
''' as pixd).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixEqualizeTRC/*"/>
'''  <param name="pixd">[in][optional] - null or equal to pixs</param>
'''  <param name="pixs">[in] - 8 bpp gray, 32 bpp rgb, or colormapped</param>
'''  <param name="fract">[in] - fraction of equalization movement of pixel values</param>
'''  <param name="factor">[in] - subsampling factor integer  is greater = 1</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixEqualizeTRC(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal fract as Single, 
				 ByVal factor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixEqualizeTRC( pixdPTR, pixs.Pointer, fract, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (714, 1)
' numaEqualizeTRC(pix, fract, factor) as Numa
' numaEqualizeTRC(PIX *, l_float32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If fract == 0.0, no equalization will be performed.<para/>
''' If fract == 1.0, equalization is complete.<para/>
''' (2) Set the subsampling factor  is greater  1 to reduce the amount of computation.<para/>
''' (3) The map is returned as a numa with 256 values, specifying<para/>
''' the equalized value (array value) for every input value<para/>
''' (the array index).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/numaEqualizeTRC/*"/>
'''  <param name="pix">[in] - 8 bpp, no colormap</param>
'''  <param name="fract">[in] - fraction of equalization movement of pixel values</param>
'''  <param name="factor">[in] - subsampling factor integer  is greater = 1</param>
'''   <returns>nad, or NULL on error</returns>
Public Shared Function numaEqualizeTRC(
				 ByVal pix as Pix, 
				 ByVal fract as Single, 
				 ByVal factor as Integer) as Numa

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaEqualizeTRC( pix.Pointer, fract, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\enhance.c (781, 1)
' pixTRCMap(pixs, pixm, na) as Integer
' pixTRCMap(PIX *, PIX *, NUMA *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This operation is in-place on pixs.<para/>
''' (2) For 32 bpp, this applies the same map to each of the r,g,b<para/>
''' components.<para/>
''' (3) The mapping array is of size 256, and it maps the input<para/>
''' index into values in the range [0, 255].<para/>
''' (4) If defined, the optional 1 bpp mask pixm has its origin<para/>
''' aligned with pixs, and the map function is applied only<para/>
''' to pixels in pixs under the fg of pixm.<para/>
''' (5) For 32 bpp, this does not save the alpha channel.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixTRCMap/*"/>
'''  <param name="pixs">[in] - 8 grayscale or 32 bpp rgb not colormapped</param>
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
' pixUnsharpMasking(pixs, halfwidth, fract) as Pix
' pixUnsharpMasking(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We use symmetric smoothing filters of odd dimension,<para/>
''' typically use sizes of 3, 5, 7, etc.  The %halfwidth parameter<para/>
''' for these is (size - 1)/2 i.e., 1, 2, 3, etc.<para/>
''' (2) The fract parameter is typically taken in the<para/>
''' range:  0.2  is lower  fract  is lower  0.7<para/>
''' (3) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMasking/*"/>
'''  <param name="pixs">[in] - all depths except 1 bpp with or without colormaps</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter</param>
'''  <param name="fract">[in] - fraction of edge added back into image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMasking(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMasking( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (973, 1)
' pixUnsharpMaskingGray(pixs, halfwidth, fract) as Pix
' pixUnsharpMaskingGray(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We use symmetric smoothing filters of odd dimension,<para/>
''' typically use sizes of 3, 5, 7, etc.  The %halfwidth parameter<para/>
''' for these is (size - 1)/2 i.e., 1, 2, 3, etc.<para/>
''' (2) The fract parameter is typically taken in the range:<para/>
''' 0.2  is lower  fract  is lower  0.7<para/>
''' (3) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMaskingGray/*"/>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter</param>
'''  <param name="fract">[in] - fraction of edge added back into image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1070, 1)
' pixUnsharpMaskingFast(pixs, halfwidth, fract, direction) as Pix
' pixUnsharpMaskingFast(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The fast version uses separable 1-D filters directly on<para/>
''' the input image.  The halfwidth is either 1 (full width = 3)<para/>
''' or 2 (full width = 5).<para/>
''' (2) The fract parameter is typically taken in the<para/>
''' range:  0.2  is lower  fract  is lower  0.7<para/>
''' (3) To skip horizontal sharpening, use %fracth = 0.0 ditto for %fractv<para/>
''' (4) For one dimensional filtering (as an example):<para/>
''' For %halfwidth = 1, the low-pass filter is<para/>
''' L:  1/3  1/3 1/3<para/>
''' and the high-pass filter is<para/>
''' H = I - L: -1/3 2/3 -1/3<para/>
''' For %halfwidth = 2, the low-pass filter is<para/>
''' L:  1/5  1/5 1/5  1/5  1/5<para/>
''' and the high-pass filter is<para/>
''' H = I - L: -1/5  -1/5 4/5  -1/5 -1/5<para/>
''' The new sharpened pixel value is found by adding some fraction<para/>
''' of the high-pass filter value (which sums to 0) to the<para/>
''' initial pixel value:<para/>
''' N = I + fract  H<para/>
''' (5) For 2D, the sharpening filter is not separable, because the<para/>
''' vertical filter depends on the horizontal location relative<para/>
''' to the filter origin, and v.v. So we either do the full<para/>
''' 2D filter (for %halfwidth == 1) or do the low-pass<para/>
''' convolution separably and then compose with the original pix.<para/>
''' (6) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMaskingFast/*"/>
'''  <param name="pixs">[in] - all depths except 1 bpp with or without colormaps</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter 1 and 2 only</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT, L_BOTH_DIRECTIONS</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingFast(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single, 
				 ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingFast( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1141, 1)
' pixUnsharpMaskingGrayFast(pixs, halfwidth, fract, direction) as Pix
' pixUnsharpMaskingGrayFast(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For usage and explanation of the algorithm, see notes<para/>
''' in pixUnsharpMaskingFast().<para/>
''' (2) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMaskingGrayFast/*"/>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter: 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT, L_BOTH_DIRECTIONS</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGrayFast(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single, 
				 ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGrayFast( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1190, 1)
' pixUnsharpMaskingGray1D(pixs, halfwidth, fract, direction) as Pix
' pixUnsharpMaskingGray1D(PIX *, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For usage and explanation of the algorithm, see notes<para/>
''' in pixUnsharpMaskingFast().<para/>
''' (2) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMaskingGray1D/*"/>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter: 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''  <param name="direction">[in] - filtering direction use L_HORIZ or L_VERT</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray1D(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single, 
				 ByVal direction as Enumerations.L_direction) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray1D( pixs.Pointer, halfwidth, fract, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1324, 1)
' pixUnsharpMaskingGray2D(pixs, halfwidth, fract) as Pix
' pixUnsharpMaskingGray2D(PIX *, l_int32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is for %halfwidth == 1, 2.<para/>
''' (2) The lowpass filter is implemented separably.<para/>
''' (3) Returns a clone if no sharpening is requested.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixUnsharpMaskingGray2D/*"/>
'''  <param name="pixs">[in] - 8 bpp no colormap</param>
'''  <param name="halfwidth">[in] - "half-width" of smoothing filter: 1 or 2</param>
'''  <param name="fract">[in] - fraction of high frequency added to image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixUnsharpMaskingGray2D(
				 ByVal pixs as Pix, 
				 ByVal halfwidth as Integer, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnsharpMaskingGray2D( pixs.Pointer, halfwidth, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1469, 1)
' pixModifyHue(pixd, pixs, fract) as Pix
' pixModifyHue(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) pixd must either be null or equal to pixs.<para/>
''' For in-place operation, set pixd == pixs:<para/>
''' pixEqualizeTRC(pixs, pixs, ...)<para/>
''' To get a new image, set pixd == null:<para/>
''' pixd = pixEqualizeTRC(NULL, pixs, ...)<para/>
''' (1) Use fract  is greater  0.0 to increase hue value  is lower  0.0 to decrease it.<para/>
''' 1.0 (or -1.0) represents a 360 degree rotation i.e., no change.<para/>
''' (2) If no modification is requested (fract = -1.0 or 0 or 1.0),<para/>
''' return a copy unless in-place, in which case this is a no-op.<para/>
''' (3) See discussion of color-modification methods, in coloring.c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixModifyHue/*"/>
'''  <param name="pixd">[in][optional] - can be null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifyHue(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifyHue( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1542, 1)
' pixModifySaturation(pixd, pixs, fract) as Pix
' pixModifySaturation(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If fract  is greater  0.0, it gives the fraction that the pixel<para/>
''' saturation is moved from its initial value toward 255.<para/>
''' If fract  is lower  0.0, it gives the fraction that the pixel<para/>
''' saturation is moved from its initial value toward 0.<para/>
''' The limiting values for fract = -1.0 (1.0) thus set the<para/>
''' saturation to 0 (255).<para/>
''' (2) If fract = 0, no modification is requested return a copy<para/>
''' unless in-place, in which case this is a no-op.<para/>
''' (3) See discussion of color-modification methods, in coloring.c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixModifySaturation/*"/>
'''  <param name="pixd">[in][optional] - can be null, existing or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifySaturation(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifySaturation( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1597, 1)
' pixMeasureSaturation(pixs, factor, psat) as Integer
' pixMeasureSaturation(PIX *, l_int32, l_float32 *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMeasureSaturation/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="factor">[in] - subsampling factor integer  is greater = 1</param>
'''  <param name="psat">[out] - average saturation</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMeasureSaturation(
				 ByVal pixs as Pix, 
				 ByVal factor as Integer, 
				<Out()> ByRef psat as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixMeasureSaturation( pixs.Pointer, factor, psat)

	Return _Result
End Function

' SRC\enhance.c (1658, 1)
' pixModifyBrightness(pixd, pixs, fract) as Pix
' pixModifyBrightness(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If fract  is greater  0.0, it gives the fraction that the v-parameter,<para/>
''' which is max(r,g,b), is moved from its initial value toward 255.<para/>
''' If fract  is lower  0.0, it gives the fraction that the v-parameter<para/>
''' is moved from its initial value toward 0.<para/>
''' The limiting values for fract = -1.0 (1.0) thus set the<para/>
''' v-parameter to 0 (255).<para/>
''' (2) If fract = 0, no modification is requested return a copy<para/>
''' unless in-place, in which case this is a no-op.<para/>
''' (3) See discussion of color-modification methods, in coloring.c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixModifyBrightness/*"/>
'''  <param name="pixd">[in][optional] - can be null, existing or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="fract">[in] - between -1.0 and 1.0</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixModifyBrightness(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixModifyBrightness( pixdPTR, pixs.Pointer, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1737, 1)
' pixMosaicColorShiftRGB(pixs, roff, goff, boff, delta, nincr) as Pix
' pixMosaicColorShiftRGB(PIX *, l_float32, l_float32, l_float32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a mosaic view of the effect of shifting the RGB<para/>
''' components.  See pixColorShiftRGB() for details on the shifting.<para/>
''' (2) The offsets (%roff, %goff, %boff) set the color center point,<para/>
''' and the deviations from this are shown separately for deltas<para/>
''' in r, g and b.  For each component, we show 2  %nincr + 1<para/>
''' images.<para/>
''' (3) Usage: color prints differ from the original due to three factors:<para/>
''' illumination, calibration of the camera in acquisition,<para/>
''' and calibration of the printer.  This function can be used<para/>
''' to iteratively match a color print to the original.  On each<para/>
''' iteration, the center offsets are set to the best match so<para/>
''' far, and the %delta increments are typically reduced.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMosaicColorShiftRGB/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="roff">[in] - center offset of red component</param>
'''  <param name="goff">[in] - center offset of green component</param>
'''  <param name="boff">[in] - center offset of blue component</param>
'''  <param name="delta">[in] - increments from center offsets [0.0 - 0.1] use 0.0 to get the default (0.04)</param>
'''  <param name="nincr">[in] - number of increments in each (positive and negative) direction use 0 to get the default (2).</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixMosaicColorShiftRGB(
				 ByVal pixs as Pix, 
				 ByVal roff as Single, 
				 ByVal goff as Single, 
				 ByVal boff as Single, 
				 ByVal delta as Single, 
				 ByVal nincr as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMosaicColorShiftRGB( pixs.Pointer, roff, goff, boff, delta, nincr)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1833, 1)
' pixColorShiftRGB(pixs, rfract, gfract, bfract) as Pix
' pixColorShiftRGB(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allows independent fractional shifts of the r,g and b<para/>
''' components.  A positive shift pushes to saturation (255)<para/>
''' a negative shift pushes toward 0 (black).<para/>
''' (2) The effect can be imagined using a color wheel that consists<para/>
''' (for our purposes) of these 6 colors, separated by 60 degrees:<para/>
''' red, magenta, blue, cyan, green, yellow<para/>
''' (3) So, for example, a negative shift of the blue component<para/>
''' (bfract  is lower  0) could be accompanied by positive shifts<para/>
''' of red and green to make an image more yellow.<para/>
''' (4) Examples of limiting cases:<para/>
''' rfract = 1 == is greater  r = 255<para/>
''' rfract = -1 == is greater  r = 0<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorShiftRGB/*"/>
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

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorShiftRGB( pixs.Pointer, rfract, gfract, bfract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (1930, 1)
' pixDarkenGray(pixd, pixs, thresh, satlimit) as Pix
' pixDarkenGray(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This darkens gray pixels, by a fraction (sat/%satlimit), where<para/>
''' the sat, the saturation, is the component difference (max - min).<para/>
''' The pixel value is unchanged if sat  is greater = %satlimit.  A typical<para/>
''' value of %satlimit might be 50 the larger the value, the<para/>
''' more that pixels with a smaller saturation will be darkened.<para/>
''' (2) Pixels with max component  is greater = %thresh are unchanged. This can be<para/>
''' used to prevent bright pixels with low saturation from being<para/>
''' darkened.  Setting thresh == 0 is a no-op setting %thresh == 255<para/>
''' causes the darkening to be applied to all pixels.<para/>
''' (3) This function is useful to enhance pixels relative to a<para/>
''' gray background.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDarkenGray/*"/>
'''  <param name="pixd">[in][optional] - can be null or equal to pixs</param>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="thresh">[in] - pixels with max component  is greater = %thresh are unchanged</param>
'''  <param name="satlimit">[in] - pixels with saturation  is greater = %satlimit are unchanged</param>
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
' pixMultConstantColor(pixs, rfact, gfact, bfact) as Pix
' pixMultConstantColor(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) rfact, gfact and bfact can only have non-negative values.<para/>
''' They can be greater than 1.0.  All transformed component<para/>
''' values are clipped to the interval [0, 255].<para/>
''' (2) For multiplication with a general 3x3 matrix of constants,<para/>
''' use pixMultMatrixColor().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMultConstantColor/*"/>
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

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMultConstantColor( pixs.Pointer, rfact, gfact, bfact)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\enhance.c (2104, 1)
' pixMultMatrixColor(pixs, kel) as Pix
' pixMultMatrixColor(PIX *, L_KERNEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The kernel is a data structure used mostly for floating point<para/>
''' convolution.  Here it is a 3x3 matrix of floats that are used<para/>
''' to transform the pixel values by matrix multiplication:<para/>
''' nrval = a[0,0]  rval + a[0,1]  gval + a[0,2]  bval<para/>
''' ngval = a[1,0]  rval + a[1,1]  gval + a[1,2]  bval<para/>
''' nbval = a[2,0]  rval + a[2,1]  gval + a[2,2]  bval<para/>
''' (2) The matrix can be generated in several ways.<para/>
''' See kernel.c for details.  Here are two of them:<para/>
''' (a) kel = kernelCreate(3, 3)<para/>
''' kernelSetElement(kel, 0, 0, val00)<para/>
''' kernelSetElement(kel, 0, 1, val01)<para/>
''' ...<para/>
''' (b) from a static string e.g.,:<para/>
''' const char kdata = " 0.6  0.3 -0.2 "<para/>
''' " 0.1  1.2  0.4 "<para/>
''' " -0.4 0.2  0.9 "<para/>
''' kel = kernelCreateFromString(3, 3, 0, 0, kdata)<para/>
''' (3) For the special case where the matrix is diagonal, it is easier<para/>
''' to use pixMultConstantColor().<para/>
''' (4) Matrix entries can have positive and negative values, and can<para/>
''' be larger than 1.0.  All transformed component values<para/>
''' are clipped to [0, 255].<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMultMatrixColor/*"/>
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
' pixHalfEdgeByBandpass(pixs, sm1h, sm1v, sm2h, sm2v) as Pix
' pixHalfEdgeByBandpass(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We use symmetric smoothing filters of odd dimension,<para/>
''' typically use 3, 5, 7, etc.  The smoothing parameters<para/>
''' for these are 1, 2, 3, etc.  The filter size is related<para/>
''' to the smoothing parameter by<para/>
''' size = 2  smoothing + 1<para/>
''' (2) Because we take the difference of two lowpass filters,<para/>
''' this is actually a bandpass filter.<para/>
''' (3) We allow both filters to be anisotropic.<para/>
''' (4) Consider either the h or v component of the 2 filters.<para/>
''' Depending on whether sm1  is greater  sm2 or sm2  is greater  sm1, we get<para/>
''' different halves of the smoothed gradients (or "edges").<para/>
''' This difference of smoothed signals looks more like<para/>
''' a second derivative of a transition, which we rectify<para/>
''' by not allowing the signal to go below zero.  If sm1  is lower  sm2,<para/>
''' the sm2 transition is broader, so the difference between<para/>
''' sm1 and sm2 signals is positive on the upper half of<para/>
''' the transition.  Likewise, if sm1  is greater  sm2, the sm1 - sm2<para/>
''' signal difference is positive on the lower half of<para/>
''' the transition.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixHalfEdgeByBandpass/*"/>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb</param>
'''  <param name="sm1h">[in] - "half-widths" of smoothing filter sm1</param>
'''  <param name="sm1v">[in] - "half-widths" of smoothing filter sm1</param>
'''  <param name="sm2h">[in] - "half-widths" of smoothing filter sm2 require sm2 != sm1</param>
'''  <param name="sm2v">[in] - "half-widths" of smoothing filter sm2 require sm2 != sm1</param>
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
