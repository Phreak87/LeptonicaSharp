Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\pixarith.c (115, 1)
' pixAddConstantGray()
' pixAddConstantGray(PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation.
''' (2) No clipping for 32 bpp.
''' (3) For 8 and 16 bpp, if val GT 0 the result is clipped
''' to 0xff and 0xffff, rsp.
''' (4) For 8 and 16 bpp, if val LT 0 the result is clipped to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8, 16 or 32 bpp</param>
'''  <param name="val">[in] - amount to add to each pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAddConstantGray(
				ByVal pixs as Pix, 
				ByVal val as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAddConstantGray( pixs.Pointer, val)

	Return _Result
End Function

' SRC\pixarith.c (186, 1)
' pixMultConstantGray()
' pixMultConstantGray(PIX *, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place operation; val must be GT= 0.
''' (2) No clipping for 32 bpp.
''' (3) For 8 and 16 bpp, the result is clipped to 0xff and 0xffff, rsp.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8, 16 or 32 bpp</param>
'''  <param name="val">[in] - GT= 0.0; amount to multiply by each pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixMultConstantGray(
				ByVal pixs as Pix, 
				ByVal val as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixMultConstantGray( pixs.Pointer, val)

	Return _Result
End Function

' SRC\pixarith.c (261, 1)
' pixAddGray()
' pixAddGray(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Arithmetic addition of two 8, 16 or 32 bpp images.
''' (2) For 8 and 16 bpp, we do explicit clipping to 0xff and 0xffff,
''' respectively.
''' (3) Alignment is to UL corner.
''' (4) There are 3 cases.  The result can go to a new dest,
''' in-place to pixs1, or to an existing input dest
''' pixd == null   (src1 + src2) --GT new pixd
''' pixd == pixs1  (src1 + src2) --GT src1  (in-place)
''' pixd != pixs1  (src1 + src2) --GT input pixd
''' (5) pixs2 must be different from both pixd and pixs1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, or different from pixs1</param>
'''  <param name="pixs1">[in] - can be == to pixd</param>
'''  <param name="pixs2">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixAddGray(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAddGray( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (353, 1)
' pixSubtractGray()
' pixSubtractGray(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Arithmetic subtraction of two 8, 16 or 32 bpp images.
''' (2) Source pixs2 is always subtracted from source pixs1.
''' (3) Do explicit clipping to 0.
''' (4) Alignment is to UL corner.
''' (5) There are 3 cases.  The result can go to a new dest,
''' in-place to pixs1, or to an existing input dest
''' (a) pixd == null   (src1 - src2) --GT new pixd
''' (b) pixd == pixs1  (src1 - src2) --GT src1  (in-place)
''' (d) pixd != pixs1  (src1 - src2) --GT input pixd
''' (6) pixs2 must be different from both pixd and pixs1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs1, or different from pixs1</param>
'''  <param name="pixs1">[in] - can be == to pixd</param>
'''  <param name="pixs2">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixSubtractGray(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSubtractGray( pixdPTR, pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (442, 1)
' pixThresholdToValue()
' pixThresholdToValue(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' ~ operation can be in-place (pixs == pixd) or to a new pixd
''' ~ if setval GT threshval, sets pixels with a value GT= threshval to setval
''' ~ if setval LT threshval, sets pixels with a value LT= threshval to setval
''' ~ if setval == threshval, no-op
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; if not null, must be equal to pixs</param>
'''  <param name="pixs">[in] - 8, 16, 32 bpp</param>
'''  <param name="threshval">[in] - </param>
'''  <param name="setval">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixThresholdToValue(
				ByVal pixs as Pix, 
				ByVal threshval as Integer, 
				ByVal setval as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixThresholdToValue( pixdPTR, pixs.Pointer, threshval, setval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (551, 1)
' pixInitAccumulate()
' pixInitAccumulate(l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) The offset must be GT= 0.
''' (2) The offset is used so that we can do arithmetic
''' with negative number results on l_uint32 data; it
''' prevents the l_uint32 data from going negative.
''' (3) Because we use l_int32 intermediate data results,
''' these should never exceed the max of l_int32 (0x7fffffff).
''' We do not permit the offset to be above 0x40000000,
''' which is half way between 0 and the max of l_int32.
''' (4) The same offset should be used for initialization,
''' multiplication by a constant, and final extraction!
''' (5) If you're only adding positive values, offset can be 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - of accumulate array</param>
'''  <param name="h">[in] - of accumulate array</param>
'''  <param name="offset">[in] - initialize the 32 bpp to have this value; not more than 0x40000000</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixInitAccumulate(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal offset as UInteger) as Pix

	If IsNothing (offset) then Throw New ArgumentNullException  ("offset cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixInitAccumulate( w, h, offset)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (585, 1)
' pixFinalAccumulate()
' pixFinalAccumulate(PIX *, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The offset must be GT= 0 and should not exceed 0x40000000.
''' (2) The offset is subtracted from the src 32 bpp image
''' (3) For 8 bpp dest, the result is clipped to [0, 0xff]
''' (4) For 16 bpp dest, the result is clipped to [0, 0xffff]
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="offset">[in] - same as used for initialization</param>
'''  <param name="depth">[in] - 8, 16 or 32 bpp, of destination</param>
'''   <returns>pixd 8, 16 or 32 bpp, or NULL on error</returns>
Public Shared Function pixFinalAccumulate(
				ByVal pixs as Pix, 
				ByVal offset as UInteger, 
				ByVal depth as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (offset) then Throw New ArgumentNullException  ("offset cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFinalAccumulate( pixs.Pointer, offset, depth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (662, 1)
' pixFinalAccumulateThreshold()
' pixFinalAccumulateThreshold(PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) The offset must be GT= 0 and should not exceed 0x40000000.
''' (2) The offset is subtracted from the src 32 bpp image
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="offset">[in] - same as used for initialization</param>
'''  <param name="threshold">[in] - values less than this are set in the destination</param>
'''   <returns>pixd 1 bpp, or NULL on error</returns>
Public Shared Function pixFinalAccumulateThreshold(
				ByVal pixs as Pix, 
				ByVal offset as UInteger, 
				ByVal threshold as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (offset) then Throw New ArgumentNullException  ("offset cannot be Nothing")
	If IsNothing (threshold) then Throw New ArgumentNullException  ("threshold cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFinalAccumulateThreshold( pixs.Pointer, offset, threshold)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (719, 1)
' pixAccumulate()
' pixAccumulate(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This adds or subtracts each pixs value from pixd.
''' (2) This clips to the minimum of pixs and pixd, so they
''' do not need to be the same size.
''' (3) The alignment is to the origin [UL corner] of pixs  pixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 32 bpp</param>
'''  <param name="pixs">[in] - 1, 8, 16 or 32 bpp</param>
'''  <param name="op">[in] - L_ARITH_ADD or L_ARITH_SUBTRACT</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixAccumulate(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal op as Enumerations.L_arithmetic_logical_operator) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAccumulate( pixd.Pointer, pixs.Pointer, op)

	Return _Result
End Function

' SRC\pixarith.c (818, 1)
' pixMultConstAccumulate()
' pixMultConstAccumulate(PIX *, l_float32, l_uint32) as l_ok
'''  <summary>
''' Notes
''' (1) The offset must be GT= 0 and should not exceed 0x40000000.
''' (2) This multiplies each pixel, relative to offset, by the input factor
''' (3) The result is returned with the offset back in place.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="factor">[in] - </param>
'''  <param name="offset">[in] - same as used for initialization</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixMultConstAccumulate(
				ByVal pixs as Pix, 
				ByVal factor as Single, 
				ByVal offset as UInteger) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")
	If IsNothing (offset) then Throw New ArgumentNullException  ("offset cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixMultConstAccumulate( pixs.Pointer, factor, offset)

	Return _Result
End Function

' SRC\pixarith.c (872, 1)
' pixAbsDifference()
' pixAbsDifference(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The depth of pixs1 and pixs2 must be equal.
''' (2) Clips computation to the min size, aligning the UL corners
''' (3) For 8 and 16 bpp, assumes one gray component.
''' (4) For 32 bpp, assumes 3 color components, and ignores the
''' LSB of each word (the alpha channel)
''' (5) Computes the absolute value of the difference between
''' each component value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - both either 8 or 16 bpp gray, or 32 bpp RGB</param>
'''  <param name="pixs2">[in] - both either 8 or 16 bpp gray, or 32 bpp RGB</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAbsDifference(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAbsDifference( pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (969, 1)
' pixAddRGB()
' pixAddRGB(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Clips computation to the minimum size, aligning the UL corners.
''' (2) Removes any colormap to RGB, and ignores the LSB of each
''' pixel word (the alpha channel).
''' (3) Adds each component value, pixelwise, clipping to 255.
''' (4) This is useful to combine two images where most of the
''' pixels are essentially black, such as in pixPerceptualDiff().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - 32 bpp RGB, or colormapped</param>
'''  <param name="pixs2">[in] - 32 bpp RGB, or colormapped</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixAddRGB(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAddRGB( pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (1054, 1)
' pixMinOrMax()
' pixMinOrMax(PIX *, PIX *, PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This gives the min or max of two images, component-wise.
''' (2) The depth can be 8 or 16 bpp for 1 component, and 32 bpp
''' for a 3 component image.  For 32 bpp, ignore the LSB
''' of each word (the alpha channel)
''' (3) There are 3 cases
''' ~  if pixd == null,   Min(src1, src2) --GT new pixd
''' ~  if pixd == pixs1,  Min(src1, src2) --GT src1  (in-place)
''' ~  if pixd != pixs1,  Min(src1, src2) --GT input pixd
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - destination this can be null, equal to pixs1, or different from pixs1</param>
'''  <param name="pixs1">[in] - can be == to pixd</param>
'''  <param name="pixs2">[in] - </param>
'''  <param name="type">[in] - L_CHOOSE_MIN, L_CHOOSE_MAX</param>
'''   <returns>pixd always</returns>
Public Shared Function pixMinOrMax(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal type as Enumerations.L_CHOOSE_M, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMinOrMax( pixdPTR, pixs1.Pointer, pixs2.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (1155, 1)
' pixMaxDynamicRange()
' pixMaxDynamicRange(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Scales pixel values to fit maximally within the dest 8 bpp pixd
''' (2) Assumes the source 'pixels' are a 1-component scalar.  For
''' a 32 bpp source, each pixel is treated as a single number --
''' not as a 3-component rgb pixel value.
''' (3) Uses a LUT for log scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 4, 8, 16 or 32 bpp source</param>
'''  <param name="type">[in] - L_LINEAR_SCALE or L_LOG_SCALE</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixMaxDynamicRange(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_L_SCALE) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMaxDynamicRange( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (1343, 1)
' pixMaxDynamicRangeRGB()
' pixMaxDynamicRangeRGB(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Scales pixel values to fit maximally within a 32 bpp dest pixd
''' (2) All color components are scaled with the same factor, based
''' on the maximum r,g or b component in the image.  This should
''' not be used if the 32-bit value is a single number (e.g., a
''' count in a histogram generated by pixMakeHistoHS()).
''' (3) Uses a LUT for log scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb source</param>
'''  <param name="type">[in] - L_LINEAR_SCALE or L_LOG_SCALE</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixMaxDynamicRangeRGB(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_L_SCALE) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMaxDynamicRangeRGB( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixarith.c (1430, 1)
' linearScaleRGBVal()
' linearScaleRGBVal(l_uint32, l_float32) as l_uint32
'''  <summary>
''' Notes
''' (1) %factor must be chosen to be not greater than (255 / maxcomp),
''' where maxcomp is the maximum value of the pixel components.
''' Otherwise, the product will overflow a uint8.  In use, factor
''' is the same for all pixels in a pix.
''' (2) No scaling is performed on the transparency ("A") component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sval">[in] - 32-bit rgb pixel value</param>
'''  <param name="factor">[in] - multiplication factor on each component</param>
'''   <returns>dval  linearly scaled version of %sval</returns>
Public Shared Function linearScaleRGBVal(
				ByVal sval as UInteger, 
				ByVal factor as Single) as UInteger

	If IsNothing (sval) then Throw New ArgumentNullException  ("sval cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.linearScaleRGBVal( sval, factor)

	Return _Result
End Function

' SRC\pixarith.c (1463, 1)
' logScaleRGBVal()
' logScaleRGBVal(l_uint32, l_float32 *, l_float32) as l_uint32
'''  <summary>
''' Notes
''' (1) %tab is made with makeLogBase2Tab().
''' (2) %factor must be chosen to be not greater than
''' 255.0 / log[base2](maxcomp), where maxcomp is the maximum
''' value of the pixel components.  Otherwise, the product
''' will overflow a uint8.  In use, factor is the same for
''' all pixels in a pix.
''' (3) No scaling is performed on the transparency ("A") component.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sval">[in] - 32-bit rgb pixel value</param>
'''  <param name="tab">[in] - 256 entry log-base-2 table</param>
'''  <param name="factor">[in] - multiplication factor on each component</param>
'''   <returns>dval  log scaled version of %sval</returns>
Public Shared Function logScaleRGBVal(
				ByVal sval as UInteger, 
				ByVal tab as Single(), 
				ByVal factor as Single) as UInteger

	If IsNothing (sval) then Throw New ArgumentNullException  ("sval cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.logScaleRGBVal( sval, tab, factor)

	Return _Result
End Function

' SRC\pixarith.c (1488, 1)
' 
' makeLogBase2Tab() as l_float32 *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function makeLogBase2Tab() as Single()



	Dim _Result as Single() = LeptonicaSharp.Natives.makeLogBase2Tab( )

	Return _Result
End Function

' SRC\pixarith.c (1515, 1)
' 
' getLogBase2(l_int32, l_float32 *) as l_float32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function getLogBase2(
				ByRef val as Integer, 
				ByRef logtab as Single()) as Single

	If IsNothing (logtab) then Throw New ArgumentNullException  ("logtab cannot be Nothing")


	Dim _Result as Single = LeptonicaSharp.Natives.getLogBase2( val, logtab)

	Return _Result
End Function

End Class
