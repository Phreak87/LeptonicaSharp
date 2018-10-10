Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\flipdetect.c (242, 1)
' pixOrientCorrect(pixs, minupconf, minratio, pupconf, pleftconf, protation, debug) as Pix
' pixOrientCorrect(PIX *, l_float32, l_float32, l_float32 *, l_float32 *, l_int32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Simple top-level function to detect if Roman text is in<para/>
''' reading orientation, and to rotate the image accordingly if not.<para/>
''' (2) Returns a copy if no rotation is needed.<para/>
''' (3) See notes for pixOrientDetect() and pixOrientDecision().<para/>
''' Use 0.0 for default values for %minupconf and %minratio<para/>
''' (4) Optional output of intermediate confidence results and<para/>
''' the rotation performed on pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
'''  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
'''  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
'''  <param name="pupconf">[out][optional] - use NULL to skip</param>
'''  <param name="pleftconf">[out][optional] - use NULL to skip</param>
'''  <param name="protation">[out][optional] - use NULL to skip</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>pixd  may be rotated by 90, 180 or 270 null on error</returns>
Public Shared Function pixOrientCorrect(
				 ByVal pixs as Pix, 
				 ByVal minupconf as Single, 
				 ByVal minratio as Single, 
				<Out()> Optional ByRef pupconf as Single = Nothing, 
				<Out()> Optional ByRef pleftconf as Single = Nothing, 
				<Out()> Optional ByRef protation as Integer = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOrientCorrect( pixs.Pointer, minupconf, minratio, pupconf, pleftconf, protation, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\flipdetect.c (370, 1)
' pixOrientDetect(pixs, pupconf, pleftconf, mincount, debug) as Integer
' pixOrientDetect(PIX *, l_float32 *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See "Measuring document image skew and orientation"<para/>
''' Dan S. Bloomberg, Gary E. Kopec and Lakshmi Dasari<para/>
''' IS and T/SPIE EI'95, Conference 2422: Document Recognition II<para/>
''' pp 302-316, Feb 6-7, 1995, San Jose, CA<para/>
''' (2) upconf is the normalized difference between up ascenders<para/>
''' and down ascenders.  The image is analyzed without rotation<para/>
''' for being rightside-up or upside-down.  Set  and upconf to null<para/>
''' to skip this operation.<para/>
''' (3) leftconf is the normalized difference between up ascenders<para/>
''' and down ascenders in the image after it has been<para/>
''' rotated 90 degrees clockwise.  With that rotation, ascenders<para/>
''' projecting to the left in the source image will project up<para/>
''' in the rotated image.  We compute this by rotating 90 degrees<para/>
''' clockwise and testing for up and down ascenders.  Set<para/>
'''  and leftconf to null to skip this operation.<para/>
''' (4) Note that upconf and leftconf are not linear measures of<para/>
''' confidence, e.g., in a range between 0 and 100.  They<para/>
''' measure how far you are out on the tail of a (presumably)<para/>
''' normal distribution.  For example, a confidence of 10 means<para/>
''' that it is nearly certain that the difference did not<para/>
''' happen at random.  However, these values must be interpreted<para/>
''' cautiously, taking into consideration the estimated prior<para/>
''' for a particular orientation or mirror flip. The up-down<para/>
''' signal is very strong if applied to text with ascenders<para/>
''' up and down, and relatively weak for text at 90 degrees,<para/>
''' but even at 90 degrees, the difference can look significant.<para/>
''' For example, suppose the ascenders are oriented horizontally,<para/>
''' but the test is done vertically.  Then upconf can<para/>
''' be  is lower  -MIN_CONF_FOR_UP_DOWN, suggesting the text may be<para/>
''' upside-down.  However, if instead the test were done<para/>
''' horizontally, leftconf will be very much larger<para/>
''' (in absolute value), giving the correct orientation.<para/>
''' (5) If you compute both upconf and leftconf, and there is<para/>
''' sufficient signal, the following table determines the<para/>
''' cw angle necessary to rotate pixs so that the text is<para/>
''' rightside-up:<para/>
''' 0 deg :   upconf  is greater  is greater  1,  abs(upconf)  is greater  is greater  abs(leftconf)<para/>
''' 90 deg :  leftconf  is greater  is greater  1,  abs(leftconf)  is greater  is greater  abs(upconf)<para/>
''' 180 deg : upconf  is lower  is lower  -1, abs(upconf)  is greater  is greater  abs(leftconf)<para/>
''' 270 deg : leftconf  is lower  is lower  -1, abs(leftconf)  is greater  is greater  abs(upconf)<para/>
''' (6) One should probably not interpret the direction unless<para/>
''' there are a sufficient number of counts for both orientations,<para/>
''' in which case neither upconf nor leftconf will be 0.0.<para/>
''' (7) Uses rasterop implementation of HMT.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
'''  <param name="pupconf">[out][optional] - may be NULL</param>
'''  <param name="pleftconf">[out][optional] - may be NULL</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixOrientDetect(
				 ByVal pixs as Pix, 
				<Out()> ByRef pupconf as Single, 
				<Out()> ByRef pleftconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixOrientDetect( pixs.Pointer, pupconf, pleftconf, mincount, debug)

	Return _Result
End Function

' SRC\flipdetect.c (431, 1)
' makeOrientDecision(upconf, leftconf, minupconf, minratio, porient, debug) as Integer
' makeOrientDecision(l_float32, l_float32, l_float32, l_float32, l_int32 *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be run after pixOrientDetect()<para/>
''' (2) Both upconf and leftconf must be nonzero otherwise the<para/>
''' orientation cannot be determined.<para/>
''' (3) The abs values of the input confidences are compared to<para/>
''' minupconf.<para/>
''' (4) The abs value of the largest of (upconf/leftconf) and<para/>
''' (leftconf/upconf) is compared with minratio.<para/>
''' (5) Input 0.0 for the default values for minupconf and minratio.<para/>
''' (6) The return value of orient is interpreted thus:<para/>
''' L_TEXT_ORIENT_UNKNOWN:  not enough evidence to determine<para/>
''' L_TEXT_ORIENT_UP: text rightside-up<para/>
''' L_TEXT_ORIENT_LEFT: landscape, text up facing left<para/>
''' L_TEXT_ORIENT_DOWN: text upside-down<para/>
''' L_TEXT_ORIENT_RIGHT:  landscape, text up facing right<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="upconf">[in] - nonzero</param>
'''  <param name="leftconf">[in] - nonzero</param>
'''  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
'''  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
'''  <param name="porient">[out] - text orientation enum {0,1,2,3,4}</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function makeOrientDecision(
				 ByVal upconf as Single, 
				 ByVal leftconf as Single, 
				 ByVal minupconf as Single, 
				 ByVal minratio as Single, 
				<Out()> ByRef porient as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.makeOrientDecision( upconf, leftconf, minupconf, minratio, porient, debug)

	Return _Result
End Function

' SRC\flipdetect.c (510, 1)
' pixUpDownDetect(pixs, pconf, mincount, debug) as Integer
' pixUpDownDetect(PIX *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Special (typical, slightly faster) case, where the pixels<para/>
''' identified through the HMT (hit-miss transform) are not<para/>
''' clipped by a truncated word mask pixm.  See pixOrientDetect()<para/>
''' and pixUpDownDetectGeneral() for details.<para/>
''' (2) The returned confidence is the normalized difference<para/>
''' between the number of detected up and down ascenders,<para/>
''' assuming that the text is either rightside-up or upside-down<para/>
''' and not rotated at a 90 degree angle.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
'''  <param name="pconf">[out] - confidence that text is rightside-up</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixUpDownDetect(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixUpDownDetect( pixs.Pointer, pconf, mincount, debug)

	Return _Result
End Function

' SRC\flipdetect.c (558, 1)
' pixUpDownDetectGeneral(pixs, pconf, mincount, npixels, debug) as Integer
' pixUpDownDetectGeneral(PIX *, l_float32 *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixOrientDetect() for other details.<para/>
''' (2) %conf is the normalized difference between the number of<para/>
''' detected up and down ascenders, assuming that the text<para/>
''' is either rightside-up or upside-down and not rotated<para/>
''' at a 90 degree angle.<para/>
''' (3) The typical mode of operation is %npixels == 0.<para/>
''' If %npixels  is greater  0, this removes HMT matches at the<para/>
''' beginning and ending of "words."  This is useful for<para/>
''' pages that may have mostly digits, because if npixels == 0,<para/>
''' leading "1" and "3" digits can register as having<para/>
''' ascenders or descenders, and "7" digits can match descenders.<para/>
''' Consequently, a page image of only digits may register<para/>
''' as being upside-down.<para/>
''' (4) We want to count the number of instances found using the HMT.<para/>
''' An expensive way to do this would be to count the<para/>
''' number of connected components.  A cheap way is to do a rank<para/>
''' reduction cascade that reduces each component to a single<para/>
''' pixel, and results (after two or three 2x reductions)<para/>
''' in one pixel for each of the original components.<para/>
''' After the reduction, you have a much smaller pix over<para/>
''' which to count pixels.  We do only 2 reductions, because<para/>
''' this function is designed to work for input pix between<para/>
''' 150 and 300 ppi, and an 8x reduction on a 150 ppi image<para/>
''' is going too far -- components will get merged.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
'''  <param name="pconf">[out] - confidence that text is rightside-up</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="npixels">[in] - number of pixels removed from each side of word box</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixUpDownDetectGeneral(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 ByVal npixels as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixUpDownDetectGeneral( pixs.Pointer, pconf, mincount, npixels, debug)

	Return _Result
End Function

' SRC\flipdetect.c (699, 1)
' pixOrientDetectDwa(pixs, pupconf, pleftconf, mincount, debug) as Integer
' pixOrientDetectDwa(PIX *, l_float32 *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Same interface as for pixOrientDetect().  See notes<para/>
''' there for usage.<para/>
''' (2) Uses auto-gen'd code for the Sels defined at the<para/>
''' top of this file, with some renaming of functions.<para/>
''' The auto-gen'd code is in fliphmtgen.c, and can<para/>
''' be generated by a simple executable see prog/flipselgen.c.<para/>
''' (3) This runs about 2.5 times faster than the pixOrientDetect().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
'''  <param name="pupconf">[out][optional] - may be NULL</param>
'''  <param name="pleftconf">[out][optional] - may be NULL</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixOrientDetectDwa(
				 ByVal pixs as Pix, 
				<Out()> ByRef pupconf as Single, 
				<Out()> ByRef pleftconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixOrientDetectDwa( pixs.Pointer, pupconf, pleftconf, mincount, debug)

	Return _Result
End Function

' SRC\flipdetect.c (752, 1)
' pixUpDownDetectDwa(pixs, pconf, mincount, debug) as Integer
' pixUpDownDetectDwa(PIX *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Faster (DWA) version of pixUpDownDetect().<para/>
''' (2) This is a special case (but typical and slightly faster) of<para/>
''' pixUpDownDetectGeneralDwa(), where the pixels identified<para/>
''' through the HMT (hit-miss transform) are not clipped by<para/>
''' a truncated word mask pixm.  See pixUpDownDetectGeneral()<para/>
''' for usage and other details.<para/>
''' (3) The returned confidence is the normalized difference<para/>
''' between the number of detected up and down ascenders,<para/>
''' assuming that the text is either rightside-up or upside-down<para/>
''' and not rotated at a 90 degree angle.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text, 150 - 300 ppi</param>
'''  <param name="pconf">[out] - confidence that text is rightside-up</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixUpDownDetectDwa(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixUpDownDetectDwa( pixs.Pointer, pconf, mincount, debug)

	Return _Result
End Function

' SRC\flipdetect.c (777, 1)
' pixUpDownDetectGeneralDwa(pixs, pconf, mincount, npixels, debug) as Integer
' pixUpDownDetectGeneralDwa(PIX *, l_float32 *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See the notes in pixUpDownDetectGeneral() for usage.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
'''  <param name="pconf">[out] - confidence that text is rightside-up</param>
'''  <param name="mincount">[in] - min number of up + down use 0 for default</param>
'''  <param name="npixels">[in] - number of pixels removed from each side of word box</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixUpDownDetectGeneralDwa(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 ByVal npixels as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixUpDownDetectGeneralDwa( pixs.Pointer, pconf, mincount, npixels, debug)

	Return _Result
End Function

' SRC\flipdetect.c (934, 1)
' pixMirrorDetect(pixs, pconf, mincount, debug) as Integer
' pixMirrorDetect(PIX *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For this test, it is necessary that the text is horizontally<para/>
''' oriented, with ascenders going up.<para/>
''' (2) conf is the normalized difference between the number of<para/>
''' right and left facing characters with ascenders.<para/>
''' Left-facing are {d} right-facing are {b, h, k}.<para/>
''' At least that was the expectation.  In practice, we can<para/>
''' really just say that it is the normalized difference in<para/>
''' hits using two specific hit-miss filters, textsel1 and textsel2,<para/>
''' after the image has been suitably pre-filtered so that<para/>
''' these filters are effective.  See (4) for what's really happening.<para/>
''' (3) A large positive conf value indicates normal text, whereas<para/>
''' a large negative conf value means the page is mirror reversed.<para/>
''' (4) The implementation is a bit tricky.  The general idea is<para/>
''' to fill the x-height part of characters, but not the space<para/>
''' between them, before doing the HMT.  This is done by<para/>
''' finding pixels added using two different operations -- a<para/>
''' horizontal close and a vertical dilation -- and adding<para/>
''' the intersection of these sets to the original.  It turns<para/>
''' out that the original intuition about the signal was largely<para/>
''' in error: much of the signal for right-facing characters<para/>
''' comes from the lower part of common x-height characters, like<para/>
''' the e and c, that remain open after these operations.<para/>
''' So it's important that the operations to close the x-height<para/>
''' parts of the characters are purposely weakened sufficiently<para/>
''' to allow these characters to remain open.  The wonders<para/>
''' of morphology!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
'''  <param name="pconf">[out] - confidence that text is not LR mirror reversed</param>
'''  <param name="mincount">[in] - min number of left + right use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixMirrorDetect(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixMirrorDetect( pixs.Pointer, pconf, mincount, debug)

	Return _Result
End Function

' SRC\flipdetect.c (1025, 1)
' pixMirrorDetectDwa(pixs, pconf, mincount, debug) as Integer
' pixMirrorDetectDwa(PIX *, l_float32 *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We assume the text is horizontally oriented, with<para/>
''' ascenders going up.<para/>
''' (2) See notes in pixMirrorDetect().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, deskewed, English text</param>
'''  <param name="pconf">[out] - confidence that text is not LR mirror reversed</param>
'''  <param name="mincount">[in] - min number of left + right use 0 for default</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixMirrorDetectDwa(
				 ByVal pixs as Pix, 
				<Out()> ByRef pconf as Single, 
				 ByVal mincount as Integer, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixMirrorDetectDwa( pixs.Pointer, pconf, mincount, debug)

	Return _Result
End Function

End Class
