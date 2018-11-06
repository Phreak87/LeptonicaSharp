Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\selgen.c (146, 1)
' pixGenerateSelWithRuns(pixs, nhlines, nvlines, distance, minlength, toppix, botpix, leftpix, rightpix, ppixe) as Sel
' pixGenerateSelWithRuns(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The horizontal and vertical lines along which elements are<para/>
''' selected are roughly equally spaced.  The actual locations of<para/>
''' the hits and misses are the centers of respective run-lengths.<para/>
''' (2) No elements are selected that are less than 'distance' pixels away<para/>
''' from a boundary pixel of the same color.  This makes the<para/>
''' match much more robust to edge noise.  Valid inputs of<para/>
''' 'distance' are 0, 1, 2, 3 and 4.  If distance is either 0 or<para/>
''' greater than 4, we reset it to the default value.<para/>
''' (3) The 4 numbers for adding rectangles of pixels outside the fg<para/>
''' can be use if the pattern is expected to be surrounded by bg<para/>
''' (white) pixels.  On the other hand, if the pattern may be near<para/>
''' other fg (black) components on some sides, use 0 for those sides.<para/>
''' (4) The pixels added to a side allow you to have miss elements there.<para/>
''' There is a constraint between distance, minlength, and<para/>
''' the added pixels for this to work.  We illustrate using the<para/>
''' default values.  If you add 5 pixels to the top, and use a<para/>
''' distance of 1, then you end up with a vertical run of at least<para/>
''' 4 bg pixels along the top edge of the image.  If you use a<para/>
''' minimum runlength of 3, each vertical line will always find<para/>
''' a miss near the center of its run.  However, if you use a<para/>
''' minimum runlength of 5, you will not get a miss on every vertical<para/>
''' line.  As another example, if you have 7 added pixels and a<para/>
''' distance of 2, you can use a runlength up to 5 to guarantee<para/>
''' that the miss element is recorded.  We give a warning if the<para/>
''' constraint does not guarantee a miss element outside the<para/>
''' image proper.<para/>
''' (5) The input pix, as extended by the extra pixels on selected sides,<para/>
''' can optionally be returned.  For debugging, call<para/>
''' pixDisplayHitMissSel() to visualize the hit-miss sel superimposed<para/>
''' on the generating bitmap.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGenerateSelWithRuns/*"/>
'''  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
'''  <param name="nhlines">[in] - number of hor lines along which elements are found</param>
'''  <param name="nvlines">[in] - number of vert lines along which elements are found</param>
'''  <param name="distance">[in] - min distance from boundary pixel use 0 for default</param>
'''  <param name="minlength">[in] - min runlength to set hit or miss use 0 for default</param>
'''  <param name="toppix">[in] - number of extra pixels of bg added above</param>
'''  <param name="botpix">[in] - number of extra pixels of bg added below</param>
'''  <param name="leftpix">[in] - number of extra pixels of bg added to left</param>
'''  <param name="rightpix">[in] - number of extra pixels of bg added to right</param>
'''  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
'''   <returns>sel hit-miss for input pattern, or NULL on error</returns>
Public Shared Function pixGenerateSelWithRuns(
				 ByVal pixs as Pix, 
				 ByVal nhlines as Integer, 
				 ByVal nvlines as Integer, 
				 ByVal distance as Integer, 
				 ByVal minlength as Integer, 
				 ByVal toppix as Integer, 
				 ByVal botpix as Integer, 
				 ByVal leftpix as Integer, 
				 ByVal rightpix as Integer, 
				<Out()> Optional ByRef ppixe as Pix = Nothing) as Sel

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim ppixePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixe) Then ppixePTR = ppixe.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenerateSelWithRuns( pixs.Pointer, nhlines, nvlines, distance, minlength, toppix, botpix, leftpix, rightpix, ppixePTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixePTR <> IntPtr.Zero then ppixe = new Pix(ppixePTR)

	Return  new Sel(_Result)
End Function

' SRC\selgen.c (336, 1)
' pixGenerateSelRandom(pixs, hitfract, missfract, distance, toppix, botpix, leftpix, rightpix, ppixe) as Sel
' pixGenerateSelRandom(PIX *, l_float32, l_float32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Either of hitfract and missfract can be zero.  If both are zero,<para/>
''' the sel would be empty, and NULL is returned.<para/>
''' (2) No elements are selected that are less than 'distance' pixels away<para/>
''' from a boundary pixel of the same color.  This makes the<para/>
''' match much more robust to edge noise.  Valid inputs of<para/>
''' 'distance' are 0, 1, 2, 3 and 4.  If distance is either 0 or<para/>
''' greater than 4, we reset it to the default value.<para/>
''' (3) The 4 numbers for adding rectangles of pixels outside the fg<para/>
''' can be use if the pattern is expected to be surrounded by bg<para/>
''' (white) pixels.  On the other hand, if the pattern may be near<para/>
''' other fg (black) components on some sides, use 0 for those sides.<para/>
''' (4) The input pix, as extended by the extra pixels on selected sides,<para/>
''' can optionally be returned.  For debugging, call<para/>
''' pixDisplayHitMissSel() to visualize the hit-miss sel superimposed<para/>
''' on the generating bitmap.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGenerateSelRandom/*"/>
'''  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
'''  <param name="hitfract">[in] - fraction of allowable fg pixels that are hits</param>
'''  <param name="missfract">[in] - fraction of allowable bg pixels that are misses</param>
'''  <param name="distance">[in] - min distance from boundary pixel use 0 for default</param>
'''  <param name="toppix">[in] - number of extra pixels of bg added above</param>
'''  <param name="botpix">[in] - number of extra pixels of bg added below</param>
'''  <param name="leftpix">[in] - number of extra pixels of bg added to left</param>
'''  <param name="rightpix">[in] - number of extra pixels of bg added to right</param>
'''  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
'''   <returns>sel hit-miss for input pattern, or NULL on error</returns>
Public Shared Function pixGenerateSelRandom(
				 ByVal pixs as Pix, 
				 ByVal hitfract as Single, 
				 ByVal missfract as Single, 
				 ByVal distance as Integer, 
				 ByVal toppix as Integer, 
				 ByVal botpix as Integer, 
				 ByVal leftpix as Integer, 
				 ByVal rightpix as Integer, 
				<Out()> Optional ByRef ppixe as Pix = Nothing) as Sel

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim ppixePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixe) Then ppixePTR = ppixe.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenerateSelRandom( pixs.Pointer, hitfract, missfract, distance, toppix, botpix, leftpix, rightpix, ppixePTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixePTR <> IntPtr.Zero then ppixe = new Pix(ppixePTR)

	Return  new Sel(_Result)
End Function

' SRC\selgen.c (489, 1)
' pixGenerateSelBoundary(pixs, hitdist, missdist, hitskip, missskip, topflag, botflag, leftflag, rightflag, ppixe) as Sel
' pixGenerateSelBoundary(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, PIX **) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) All fg elements selected are exactly hitdist pixels away from<para/>
''' the nearest fg boundary pixel, and ditto for bg elements.<para/>
''' Valid inputs of hitdist and missdist are 0, 1, 2, 3 and 4.<para/>
''' For example, a hitdist of 0 puts the hits at the fg boundary.<para/>
''' Usually, the distances should be  is greater  0 avoid the effect of<para/>
''' noise at the boundary.<para/>
''' (2) Set hitskip  is lower  0 if no hits are to be used.  Ditto for missskip.<para/>
''' If both hitskip and missskip are  is lower  0, the sel would be empty,<para/>
''' and NULL is returned.<para/>
''' (3) The 4 flags determine whether the sel is increased on that side<para/>
''' to allow bg misses to be placed all along that boundary.<para/>
''' The increase in sel size on that side is the minimum necessary<para/>
''' to allow the misses to be placed at mindist.  For text characters,<para/>
''' the topflag and botflag are typically set to 1, and the leftflag<para/>
''' and rightflag to 0.<para/>
''' (4) The input pix, as extended by the extra pixels on selected sides,<para/>
''' can optionally be returned.  For debugging, call<para/>
''' pixDisplayHitMissSel() to visualize the hit-miss sel superimposed<para/>
''' on the generating bitmap.<para/>
''' (5) This is probably the best of the three sel generators, in the<para/>
''' sense that you have the most flexibility with the smallest number<para/>
''' of hits and misses.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGenerateSelBoundary/*"/>
'''  <param name="pixs">[in] - 1 bpp, typically small, to be used as a pattern</param>
'''  <param name="hitdist">[in] - min distance from fg boundary pixel</param>
'''  <param name="missdist">[in] - min distance from bg boundary pixel</param>
'''  <param name="hitskip">[in] - number of boundary pixels skipped between hits</param>
'''  <param name="missskip">[in] - number of boundary pixels skipped between misses</param>
'''  <param name="topflag">[in] - flag for extra pixels of bg added above</param>
'''  <param name="botflag">[in] - flag for extra pixels of bg added below</param>
'''  <param name="leftflag">[in] - flag for extra pixels of bg added to left</param>
'''  <param name="rightflag">[in] - flag for extra pixels of bg added to right</param>
'''  <param name="ppixe">[out][optional] - input pix expanded by extra pixels</param>
'''   <returns>sel hit-miss for input pattern, or NULL on error</returns>
Public Shared Function pixGenerateSelBoundary(
				 ByVal pixs as Pix, 
				 ByVal hitdist as Integer, 
				 ByVal missdist as Integer, 
				 ByVal hitskip as Integer, 
				 ByVal missskip as Integer, 
				 ByVal topflag as Integer, 
				 ByVal botflag as Integer, 
				 ByVal leftflag as Integer, 
				 ByVal rightflag as Integer, 
				<Out()> Optional ByRef ppixe as Pix = Nothing) as Sel

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim ppixePTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixe) Then ppixePTR = ppixe.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGenerateSelBoundary( pixs.Pointer, hitdist, missdist, hitskip, missskip, topflag, botflag, leftflag, rightflag, ppixePTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixePTR <> IntPtr.Zero then ppixe = new Pix(ppixePTR)

	Return  new Sel(_Result)
End Function

' SRC\selgen.c (636, 1)
' pixGetRunCentersOnLine(pixs, x, y, minlength) as Numa
' pixGetRunCentersOnLine(PIX *, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Action: this function computes the fg (black) and bg (white)<para/>
''' pixel runlengths along the specified horizontal or vertical line,<para/>
''' and returns a Numa of the "center" pixels of each fg run<para/>
''' whose length equals or exceeds the minimum length.<para/>
''' (2) This only works on horizontal and vertical lines.<para/>
''' (3) For horizontal runs, set x = -1 and y to the value<para/>
''' for all points along the raster line.  For vertical runs,<para/>
''' set y = -1 and x to the value for all points along the<para/>
''' pixel column.<para/>
''' (4) For horizontal runs, the points in the Numa are the x<para/>
''' values in the center of fg runs that are of length at<para/>
''' least 'minlength'.  For vertical runs, the points in the<para/>
''' Numa are the y values in the center of fg runs, again<para/>
''' of length 'minlength' or greater.<para/>
''' (5) If there are no fg runs along the line that satisfy the<para/>
''' minlength constraint, the returned Numa is empty.  This<para/>
''' is not an error.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetRunCentersOnLine/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="x">[in] - set one of these to -1 see notes</param>
'''  <param name="y">[in] - set one of these to -1 see notes</param>
'''  <param name="minlength">[in] - minimum length of acceptable run</param>
'''   <returns>numa of fg runs, or NULL on error</returns>
Public Shared Function pixGetRunCentersOnLine(
				 ByVal pixs as Pix, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal minlength as Integer) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetRunCentersOnLine( pixs.Pointer, x, y, minlength)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\selgen.c (708, 1)
' pixGetRunsOnLine(pixs, x1, y1, x2, y2) as Numa
' pixGetRunsOnLine(PIX *, l_int32, l_int32, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Action: this function uses the bresenham algorithm to compute<para/>
''' the pixels along the specified line.  It returns a Numa of the<para/>
''' runlengths of the fg (black) and bg (white) runs, always<para/>
''' starting with a white run.<para/>
''' (2) If the first pixel on the line is black, the length of the<para/>
''' first returned run (which is white) is 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetRunsOnLine/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="x1">[in] - </param>
'''  <param name="y1">[in] - </param>
'''  <param name="x2">[in] - </param>
'''  <param name="y2">[in] - </param>
'''   <returns>numa, or NULL on error</returns>
Public Shared Function pixGetRunsOnLine(
				 ByVal pixs as Pix, 
				 ByVal x1 as Integer, 
				 ByVal y1 as Integer, 
				 ByVal x2 as Integer, 
				 ByVal y2 as Integer) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetRunsOnLine( pixs.Pointer, x1, y1, x2, y2)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\selgen.c (803, 1)
' pixSubsampleBoundaryPixels(pixs, skip) as Pta
' pixSubsampleBoundaryPixels(PIX *, l_int32) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If skip = 0, we take all the fg pixels.<para/>
''' (2) We try to traverse the boundaries in a regular way.<para/>
''' Some pixels may be missed, and these are then subsampled<para/>
''' randomly with a fraction determined by 'skip'.<para/>
''' (3) The most natural approach is to use a depth first (stack-based)<para/>
''' method to find the fg pixels.  However, the pixel runs are<para/>
''' 4-connected and there are relatively few branches.  So<para/>
''' instead of doing a proper depth-first search, we get nearly<para/>
''' the same result using two nested while loops: the outer<para/>
''' one continues a raster-based search for the next fg pixel,<para/>
''' and the inner one does a reasonable job running along<para/>
''' each 4-connected coutour.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSubsampleBoundaryPixels/*"/>
'''  <param name="pixs">[in] - 1 bpp, with only boundary pixels in fg</param>
'''  <param name="skip">[in] - number to skip between samples as you traverse boundary</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function pixSubsampleBoundaryPixels(
				 ByVal pixs as Pix, 
				 ByVal skip as Integer) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSubsampleBoundaryPixels( pixs.Pointer, skip)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\selgen.c (870, 1)
' adjacentOnPixelInRaster(pixs, x, y, pxa, pya) as Integer
' adjacentOnPixelInRaster(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Search is in 4-connected directions first then on diagonals.<para/>
''' This allows traversal along a 4-connected boundary.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/adjacentOnPixelInRaster/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="x">[in] - current pixel</param>
'''  <param name="y">[in] - current pixel</param>
'''  <param name="pxa">[out] - adjacent ON pixel, found by simple CCW search</param>
'''  <param name="pya">[out] - adjacent ON pixel, found by simple CCW search</param>
'''   <returns>1 if a pixel is found 0 otherwise or on error</returns>
Public Shared Function adjacentOnPixelInRaster(
				 ByVal pixs as Pix, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pxa as Integer, 
				<Out()> ByRef pya as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as Integer = LeptonicaSharp.Natives.adjacentOnPixelInRaster( pixs.Pointer, x, y, pxa, pya)

	Return _Result
End Function

' SRC\selgen.c (928, 1)
' pixDisplayHitMissSel(pixs, sel, scalefactor, hitcolor, misscolor) as Pix
' pixDisplayHitMissSel(PIX *, SEL *, l_int32, l_uint32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We don't allow scalefactor to be larger than MAX_SEL_SCALEFACTOR<para/>
''' (2) The colors are conveniently given as 4 bytes in hex format,<para/>
''' such as 0xff008800.  The least significant byte is ignored.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDisplayHitMissSel/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sel">[in] - hit-miss in general</param>
'''  <param name="scalefactor">[in] - an integer  is greater = 1 use 0 for default</param>
'''  <param name="hitcolor">[in] - RGB0 color for center of hit pixels</param>
'''  <param name="misscolor">[in] - RGB0 color for center of miss pixels</param>
'''   <returns>pixd RGB showing both pixs and sel, or NULL on error</returns>
Public Shared Function pixDisplayHitMissSel(
				 ByVal pixs as Pix, 
				 ByVal sel as Sel, 
				 ByVal scalefactor as Integer, 
				 ByVal hitcolor as UInteger, 
				 ByVal misscolor as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayHitMissSel( pixs.Pointer, sel.Pointer, scalefactor, hitcolor, misscolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
