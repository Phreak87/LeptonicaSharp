Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' runlength.c (99, 1)
' pixStrokeWidthTransform(pixs, color, depth, nangles) as Pix
' pixStrokeWidthTransform(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The dest Pix is 8 or 16 bpp, with the pixel values
'''equal to the stroke width in which it is a member.
'''The values are clipped to the max pixel value if necessary.<para/>
'''
'''(2) The color determines if we're labelling white or black strokes.<para/>
'''
'''(3) A pixel that is not a member of the chosen color gets
'''value 0 it belongs to a width of length 0 of the
'''chosen color.<para/>
'''
'''(4) This chooses, for each dest pixel, the minimum of sets
'''of runlengths through each pixel.  Here are the sets:
'''nangles  increment  set
'''-------  ---------  --------------------------------
'''2  90 {0, 90}
'''4  45 {0, 45, 90, 135}
'''6  30 {0, 30, 60, 90, 120, 150}
'''8  22.5 {0, 22.5, 45, 67.5, 90, 112.5, 135, 157.5}<para/>
'''
'''(5) Runtime scales linearly with (nangles - 2).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixStrokeWidthTransform/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="color">[in] - 0 for white runs, 1 for black runs</param>
'''  <param name="depth">[in] - of pixd: 8 or 16 bpp</param>
'''  <param name="nangles">[in] - 2, 4, 6 or 8</param>
'''   <returns>pixd 8 or 16 bpp, or NULL on error</returns>
Public Shared Function pixStrokeWidthTransform(
				ByVal pixs as Pix, 
				ByVal color as Integer, 
				ByVal depth as Integer, 
				ByVal nangles as Integer) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixStrokeWidthTransform(pixs.Pointer,   color,   depth,   nangles)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' runlength.c (262, 1)
' pixRunlengthTransform(pixs, color, direction, depth) as Pix
' pixRunlengthTransform(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The dest Pix is 8 or 16 bpp, with the pixel values
'''equal to the runlength in which it is a member.
'''The length is clipped to the max pixel value if necessary.<para/>
'''
'''(2) The color determines if we're labelling white or black runs.<para/>
'''
'''(3) A pixel that is not a member of the chosen color gets
'''value 0 it belongs to a run of length 0 of the
'''chosen color.<para/>
'''
'''(4) To convert for maximum dynamic range, either linear or
'''log, use pixMaxDynamicRange().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRunlengthTransform/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="color">[in] - 0 for white runs, 1 for black runs</param>
'''  <param name="direction">[in] - L_HORIZONTAL_RUNS, L_VERTICAL_RUNS</param>
'''  <param name="depth">[in] - 8 or 16 bpp</param>
'''   <returns>pixd 8 or 16 bpp, or NULL on error</returns>
Public Shared Function pixRunlengthTransform(
				ByVal pixs as Pix, 
				ByVal color as Integer, 
				ByVal direction as Enumerations.L_AL_RUNS, 
				ByVal depth as Integer) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixRunlengthTransform(pixs.Pointer,   color,   direction,   depth)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' runlength.c (372, 1)
' pixFindHorizontalRuns(pix, y, xstart, xend, pn) as Integer
' pixFindHorizontalRuns(PIX *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This finds foreground horizontal runs on a single scanline.<para/>
'''
'''(2) To find background runs, use pixInvert() before applying
'''this function.<para/>
'''
'''(3) The xstart and xend arrays are input.  They should be
'''of size w/2 + 1 to insure that they can hold
'''the maximum number of runs in the raster line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindHorizontalRuns/*"/>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="y">[in] - line to traverse</param>
'''  <param name="xstart">[in] - returns array of start positions for fg runs</param>
'''  <param name="xend">[in] - returns array of end positions for fg runs</param>
'''  <param name="pn">[out] - the number of runs found</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixFindHorizontalRuns(
				ByVal pix as Pix, 
				ByVal y as Integer, 
				ByVal xstart as Integer(), 
				ByVal xend as Integer(), 
				<Out()>  ByRef pn as Integer) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (xstart) then Throw New ArgumentNullException  ("xstart cannot be Nothing")
		if IsNothing (xend) then Throw New ArgumentNullException  ("xend cannot be Nothing")
If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as Integer = Natives.pixFindHorizontalRuns(pix.Pointer,   y,   xstart,   xend,   pn)
	
	return _Result
End Function

' runlength.c (449, 1)
' pixFindVerticalRuns(pix, x, ystart, yend, pn) as Integer
' pixFindVerticalRuns(PIX *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This finds foreground vertical runs on a single scanline.<para/>
'''
'''(2) To find background runs, use pixInvert() before applying
'''this function.<para/>
'''
'''(3) The ystart and yend arrays are input.  They should be
'''of size h/2 + 1 to insure that they can hold
'''the maximum number of runs in the raster line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindVerticalRuns/*"/>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="x">[in] - line to traverse</param>
'''  <param name="ystart">[in] - returns array of start positions for fg runs</param>
'''  <param name="yend">[in] - returns array of end positions for fg runs</param>
'''  <param name="pn">[out] - the number of runs found</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixFindVerticalRuns(
				ByVal pix as Pix, 
				ByVal x as Integer, 
				ByVal ystart as Integer(), 
				ByVal yend as Integer(), 
				<Out()>  ByRef pn as Integer) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (ystart) then Throw New ArgumentNullException  ("ystart cannot be Nothing")
		if IsNothing (yend) then Throw New ArgumentNullException  ("yend cannot be Nothing")
If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as Integer = Natives.pixFindVerticalRuns(pix.Pointer,   x,   ystart,   yend,   pn)
	
	return _Result
End Function

' runlength.c (525, 1)
' pixFindMaxRuns(pix, direction, pnastart) as Numa
' pixFindMaxRuns(PIX *, l_int32, NUMA **) as NUMA *
'''  <summary>
''' (1) This finds the longest foreground runs by row or column<para/>
'''
'''(2) To find background runs, use pixInvert() before applying
'''this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxRuns/*"/>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="direction">[in] - L_HORIZONTAL_RUNS or L_VERTICAL_RUNS</param>
'''  <param name="pnastart">[out][optional] - start locations of longest runs</param>
'''   <returns>na of lengths of runs, or NULL on error</returns>
Public Shared Function pixFindMaxRuns(
				ByVal pix as Pix, 
				ByVal direction as Enumerations.L_AL_RUNS, 
				<Out()> Optional  ByRef pnastart as Numa = Nothing) as Numa


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pnastartPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixFindMaxRuns(pix.Pointer,   direction, pnastartPtr)
	
	if pnastartPtr = IntPtr.Zero then pnastart = Nothing else pnastart = new Numa(pnastartPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' runlength.c (578, 1)
' pixFindMaxHorizontalRunOnLine(pix, y, pxstart, psize) as Integer
' pixFindMaxHorizontalRunOnLine(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This finds the longest foreground horizontal run on a scanline.<para/>
'''
'''(2) To find background runs, use pixInvert() before applying
'''this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxHorizontalRunOnLine/*"/>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="y">[in] - line to traverse</param>
'''  <param name="pxstart">[out][optional] - start position</param>
'''  <param name="psize">[out] - the size of the run</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixFindMaxHorizontalRunOnLine(
				ByVal pix as Pix, 
				ByVal y as Integer, 
				<Out()>  ByRef pxstart as Integer, 
				<Out()>  ByRef psize as Integer) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as Integer = Natives.pixFindMaxHorizontalRunOnLine(pix.Pointer,   y,   pxstart,   psize)
	
	return _Result
End Function

' runlength.c (652, 1)
' pixFindMaxVerticalRunOnLine(pix, x, pystart, psize) as Integer
' pixFindMaxVerticalRunOnLine(PIX *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This finds the longest foreground vertical run on a scanline.<para/>
'''
'''(2) To find background runs, use pixInvert() before applying
'''this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindMaxVerticalRunOnLine/*"/>
'''  <param name="pix">[in] - 1 bpp</param>
'''  <param name="x">[in] - column to traverse</param>
'''  <param name="pystart">[out][optional] - start position</param>
'''  <param name="psize">[out] - the size of the run</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixFindMaxVerticalRunOnLine(
				ByVal pix as Pix, 
				ByVal x as Integer, 
				<Out()>  ByRef pystart as Integer, 
				<Out()>  ByRef psize as Integer) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
If {1}.contains (pix.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as Integer = Natives.pixFindMaxVerticalRunOnLine(pix.Pointer,   x,   pystart,   psize)
	
	return _Result
End Function

' runlength.c (733, 1)
' runlengthMembershipOnLine(buffer, size, depth, start, end, n) as Integer
' runlengthMembershipOnLine(l_int32 *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32) as l_ok
'''  <summary>
''' (1) Converts a set of runlengths into a buffer of
'''runlength membership values.<para/>
'''
'''(2) Initialization of the array gives pixels that are
'''not within a run the value 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/runlengthMembershipOnLine/*"/>
'''  <param name="buffer">[in] - into which full line of data is placed</param>
'''  <param name="size">[in] - full size of line w or h</param>
'''  <param name="depth">[in] - 8 or 16 bpp</param>
'''  <param name="start">[in] - array of start positions for fg runs</param>
'''  <param name="n">[in] - the number of runs</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function runlengthMembershipOnLine(
				ByVal buffer as Integer(), 
				ByVal size as Integer, 
				ByVal depth as Integer, 
				ByVal start as Integer(), 
				ByVal _end_ as object, 
				ByVal n as Integer) as Integer


if IsNothing (buffer) then Throw New ArgumentNullException  ("buffer cannot be Nothing")
		if IsNothing (start) then Throw New ArgumentNullException  ("start cannot be Nothing")
		if IsNothing (_end_) then Throw New ArgumentNullException  ("_end_ cannot be Nothing")
	Dim _Result as Integer = Natives.runlengthMembershipOnLine(  buffer,   size,   depth,   start,   _end_,   n)
	
	return _Result
End Function

' runlength.c (791, 1)
' makeMSBitLocTab(bitval) as Integer()
' makeMSBitLocTab(l_int32) as l_int32 *
'''  <summary>
''' (1) If bitval == 1, it finds the leftmost ON pixel in a byte
'''otherwise if bitval == 0, it finds the leftmost OFF pixel.<para/>
'''
'''(2) If there are no pixels of the indicated color in the byte,
'''this returns 8.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeMSBitLocTab/*"/>
'''  <param name="bitval">[in] - either 0 or 1</param>
'''   <returns>table giving, for an input byte, the MS bit location, starting at 0 with the MSBit in the byte, or NULL on error.</returns>
Public Shared Function makeMSBitLocTab(
				ByVal bitval as Integer) as Integer()


	Dim _Result as Integer() = Natives.makeMSBitLocTab(  bitval)
	
	return _Result
End Function

End Class


