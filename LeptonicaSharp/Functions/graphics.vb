Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\graphics.c (138, 1)
' generatePtaLine()
' generatePtaLine(l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) Uses Bresenham line drawing, which results in an 8-connected line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x1">[in] - end point 1</param>
'''  <param name="y1">[in] - end point 1</param>
'''  <param name="x2">[in] - end point 2</param>
'''  <param name="y2">[in] - end point 2</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function generatePtaLine(
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer) as Pta



	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaLine( x1, y1, x2, y2)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (203, 1)
' generatePtaWideLine()
' generatePtaWideLine(l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x1">[in] - end point 1</param>
'''  <param name="y1">[in] - end point 1</param>
'''  <param name="x2">[in] - end point 2</param>
'''  <param name="y2">[in] - end point 2</param>
'''  <param name="width">[in] - </param>
'''   <returns>ptaj, or NULL on error</returns>
Public Shared Function generatePtaWideLine(
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer, 
				ByVal width as Integer) as Pta



	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaWideLine( x1, y1, x2, y2, width)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (273, 1)
' generatePtaBox()
' generatePtaBox(BOX *, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) Because the box is constructed so that we don't have any
''' overlapping lines, there is no need to remove duplicates.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="width">[in] - of line</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaBox(
				ByVal box as Box, 
				ByVal width as Integer) as Pta

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaBox( box.Pointer, width)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (350, 1)
' generatePtaBoxa()
' generatePtaBoxa(BOXA *, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) If the boxa has overlapping boxes, and if blending will
''' be used to give a transparent effect, transparency
''' artifacts at line intersections can be removed using
''' removedups = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="width">[in] - </param>
'''  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaBoxa(
				ByVal boxa as Boxa, 
				ByVal width as Integer, 
				ByVal removedups as Integer) as Pta

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaBoxa( boxa.Pointer, width, removedups)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (405, 1)
' generatePtaHashBox()
' generatePtaHashBox(BOX *, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) The orientation takes on one of 4 orientations (horiz, vertical,
''' slope +1, slope -1).
''' (2) The full outline is also drawn if %outline = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - of line</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaHashBox(
				ByVal box as Box, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer) as Pta

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaHashBox( box.Pointer, spacing, width, orient, outline)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (505, 1)
' generatePtaHashBoxa()
' generatePtaHashBoxa(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) The orientation takes on one of 4 orientations (horiz, vertical,
''' slope +1, slope -1).
''' (2) The full outline is also drawn if %outline = 1.
''' (3) If the boxa has overlapping boxes, and if blending will
''' be used to give a transparent effect, transparency
''' artifacts at line intersections can be removed using
''' removedups = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - of line</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaHashBoxa(
				ByVal boxa as Boxa, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal removedups as Integer) as Pta

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaHashBoxa( boxa.Pointer, spacing, width, orient, outline, removedups)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (565, 1)
' generatePtaaBoxa()
' generatePtaaBoxa(BOXA *) as PTAA *
'''  <summary>
''' Notes
''' (1) This generates a pta of the four corners for each box in
''' the boxa.
''' (2) Each of these pta can be rendered onto a pix with random colors,
''' by using pixRenderRandomCmapPtaa() with closeflag = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function generatePtaaBoxa(
				ByVal boxa as Boxa) as Ptaa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaaBoxa( boxa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\graphics.c (616, 1)
' generatePtaaHashBoxa()
' generatePtaaHashBoxa(BOXA *, l_int32, l_int32, l_int32, l_int32) as PTAA *
'''  <summary>
''' Notes
''' (1) The orientation takes on one of 4 orientations (horiz, vertical,
''' slope +1, slope -1).
''' (2) The full outline is also drawn if %outline = 1.
''' (3) Each of these pta can be rendered onto a pix with random colors,
''' by using pixRenderRandomCmapPtaa() with closeflag = 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="spacing">[in] - spacing between hash lines; must be GT 1</param>
'''  <param name="width">[in] - hash line width</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function generatePtaaHashBoxa(
				ByVal boxa as Boxa, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer) as Ptaa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaaHashBoxa( boxa.Pointer, spacing, width, orient, outline)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\graphics.c (664, 1)
' generatePtaPolyline()
' generatePtaPolyline(PTA *, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - vertices of polyline</param>
'''  <param name="width">[in] - </param>
'''  <param name="closeflag">[in] - 1 to close the contour; 0 otherwise</param>
'''  <param name="removedups">[in] - 1 to remove, 0 to leave</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaPolyline(
				ByVal ptas as Pta, 
				ByVal width as Integer, 
				ByVal closeflag as Integer, 
				ByVal removedups as Integer) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaPolyline( ptas.Pointer, width, closeflag, removedups)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (722, 1)
' generatePtaGrid()
' generatePtaGrid(l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="w">[in] - of region where grid will be displayed</param>
'''  <param name="h">[in] - of region where grid will be displayed</param>
'''  <param name="nx">[in] - number of rectangles in each direction in grid</param>
'''  <param name="ny">[in] - number of rectangles in each direction in grid</param>
'''  <param name="width">[in] - of rendered lines</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function generatePtaGrid(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal width as Integer) as Pta



	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaGrid( w, h, nx, ny, width)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (780, 1)
' convertPtaLineTo4cc()
' convertPtaLineTo4cc(PTA *) as PTA *
'''  <summary>
''' Notes
''' (1) When a polyline is generated with width = 1, the resulting
''' line is not 4-connected in general.  This function adds
''' points as necessary to convert the line to 4-cconnected.
''' It is useful when rendering 1 bpp on a pix.
''' (2) Do not use this for lines generated with width GT 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - 8-connected line of points</param>
'''   <returns>ptad 4-connected line, or NULL on error</returns>
Public Shared Function convertPtaLineTo4cc(
				ByVal ptas as Pta) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.convertPtaLineTo4cc( ptas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (823, 1)
' generatePtaFilledCircle()
' generatePtaFilledCircle(l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) The circle is has diameter = 2  radius + 1.
''' (2) It is located with the center of the circle at the
''' point (radius, radius).
''' (3) Consequently, it typically must be translated if
''' it is to represent a set of pixels in an image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="radius">[in] - </param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function generatePtaFilledCircle(
				ByVal radius as Integer) as Pta



	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaFilledCircle( radius)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (863, 1)
' generatePtaFilledSquare()
' generatePtaFilledSquare(l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) The center of the square can be chosen to be at
''' (side / 2, side / 2).  It must be translated by this amount
''' when used for replication.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="side">[in] - </param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function generatePtaFilledSquare(
				ByVal side as Integer) as Pta



	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaFilledSquare( side)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (897, 1)
' generatePtaLineFromPt()
' generatePtaLineFromPt(l_int32, l_int32, l_float64, l_float64) as PTA *
'''  <summary>
''' Notes
''' (1) The %length of the line is 1 greater than the distance
''' used in locatePtRadially().  Example a distance of 1
''' gives rise to a length of 2.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x">[in] - point of origination</param>
'''  <param name="y">[in] - point of origination</param>
'''  <param name="length">[in] - of line, including starting point</param>
'''  <param name="radang">[in] - angle in radians, CW from horizontal</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function generatePtaLineFromPt(
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal length as Double, 
				ByVal radang as Double) as Pta

	If IsNothing (length) then Throw New ArgumentNullException  ("length cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.generatePtaLineFromPt( x, y, length, radang)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (921, 1)
' locatePtRadially()
' locatePtRadially(l_int32, l_int32, l_float64, l_float64, l_float64 *, l_float64 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="xr">[in] - reference point</param>
'''  <param name="yr">[in] - reference point</param>
'''  <param name="dist">[in] - distance of point from reference point along line given by the specified angle</param>
'''  <param name="radang">[in] - angle in radians, CW from horizontal</param>
'''  <param name="px">[out] - location of point</param>
'''  <param name="py">[out] - location of point</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function locatePtRadially(
				ByVal xr as Integer, 
				ByVal yr as Integer, 
				ByVal dist as Double, 
				ByVal radang as Double, 
				ByRef px as Double(), 
				ByRef py as Double()) as Integer

	If IsNothing (dist) then Throw New ArgumentNullException  ("dist cannot be Nothing")
	If IsNothing (radang) then Throw New ArgumentNullException  ("radang cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.locatePtRadially( xr, yr, dist, radang, px, py)

	Return _Result
End Function

' SRC\graphics.c (963, 1)
' pixRenderPlotFromNuma()
' pixRenderPlotFromNuma(PIX **, NUMA *, l_int32, l_int32, l_int32, l_uint32) as l_ok
'''  <summary>
''' Notes
''' (1) Simplified interface for plotting row or column aligned data
''' on a pix.
''' (2) This replaces %pix with a 32 bpp rgb version if it is not
''' already 32 bpp.  It then draws the plot on the pix.
''' (3) See makePlotPtaFromNumaGen() for more details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppix">[in,out] - any type; replaced if not 32 bpp rgb</param>
'''  <param name="na">[in] - to be plotted</param>
'''  <param name="plotloc">[in] - location of plot L_PLOT_AT_TOP, etc</param>
'''  <param name="linewidth">[in] - width of "line" that is drawn; between 1 and 7</param>
'''  <param name="max">[in] - maximum excursion in pixels from baseline</param>
'''  <param name="color">[in] - plot color 0xrrggbb00</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPlotFromNuma(
				ByRef ppix as Pix, 
				ByVal na as Numa, 
				ByVal plotloc as Enumerations.L_PLOT_AT, 
				ByVal linewidth as Integer, 
				ByVal max as Integer, 
				ByVal color as UInteger) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim ppixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppix) Then ppixPTR = ppix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPlotFromNuma( ppixPTR, na.Pointer, plotloc, linewidth, max, color)
	if ppixPTR <> IntPtr.Zero then ppix = new Pix(ppixPTR)

	Return _Result
End Function

' SRC\graphics.c (1021, 1)
' makePlotPtaFromNuma()
' makePlotPtaFromNuma(NUMA *, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) This generates points from %numa representing y(x) or x(y)
''' with respect to a pix.  A horizontal plot y(x) is drawn for
''' a function of column position, and a vertical plot is drawn
''' for a function x(y) of row position.  The baseline is located
''' so that all plot points will fit in the pix.
''' (2) See makePlotPtaFromNumaGen() for more details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="size">[in] - pix height for horizontal plot; width for vertical plot</param>
'''  <param name="plotloc">[in] - location of plot L_PLOT_AT_TOP, etc</param>
'''  <param name="linewidth">[in] - width of "line" that is drawn; between 1 and 7</param>
'''  <param name="max">[in] - maximum excursion in pixels from baseline</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function makePlotPtaFromNuma(
				ByVal na as Numa, 
				ByVal size as Integer, 
				ByVal plotloc as Enumerations.L_PLOT_AT, 
				ByVal linewidth as Integer, 
				ByVal max as Integer) as Pta

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.makePlotPtaFromNuma( na.Pointer, size, plotloc, linewidth, max)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (1077, 1)
' pixRenderPlotFromNumaGen()
' pixRenderPlotFromNumaGen(PIX **, NUMA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint32) as l_ok
'''  <summary>
''' Notes
''' (1) General interface for plotting row or column aligned data
''' on a pix.
''' (2) This replaces %pix with a 32 bpp rgb version if it is not
''' already 32 bpp.  It then draws the plot on the pix.
''' (3) See makePlotPtaFromNumaGen() for other input parameters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppix">[in,out] - any type; replaced if not 32 bpp rgb</param>
'''  <param name="na">[in] - to be plotted</param>
'''  <param name="orient">[in] - L_HORIZONTAL_LINE, L_VERTICAL_LINE</param>
'''  <param name="linewidth">[in] - width of "line" that is drawn; between 1 and 7</param>
'''  <param name="refpos">[in] - reference position y for horizontal and x for vertical</param>
'''  <param name="max">[in] - maximum excursion in pixels from baseline</param>
'''  <param name="drawref">[in] - 1 to draw the reference line and the normal to it</param>
'''  <param name="color">[in] - plot color 0xrrggbb00</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPlotFromNumaGen(
				ByRef ppix as Pix, 
				ByVal na as Numa, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal linewidth as Integer, 
				ByVal refpos as Integer, 
				ByVal max as Integer, 
				ByVal drawref as Integer, 
				ByVal color as UInteger) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim ppixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppix) Then ppixPTR = ppix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPlotFromNumaGen( ppixPTR, na.Pointer, orient, linewidth, refpos, max, drawref, color)
	if ppixPTR <> IntPtr.Zero then ppix = new Pix(ppixPTR)

	Return _Result
End Function

' SRC\graphics.c (1142, 1)
' makePlotPtaFromNumaGen()
' makePlotPtaFromNumaGen(NUMA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) This generates points from %numa representing y(x) or x(y)
''' with respect to a pix.  For y(x), we draw a horizontal line
''' at the reference position and a vertical line at the edge; then
''' we draw the values of %numa, scaled so that the maximum
''' excursion from the reference position is %max pixels.
''' (2) The start and delx parameters of %numa are used to refer
''' its values to the raster lines (L_VERTICAL_LINE) or columns
''' (L_HORIZONTAL_LINE).
''' (3) The linewidth is chosen in the interval [1 ... 7].
''' (4) %refpos should be chosen so the plot is entirely within the pix
''' that it will be painted onto.
''' (5) This would typically be used to plot, in place, a function
''' computed along pixel rows or columns.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''  <param name="orient">[in] - L_HORIZONTAL_LINE, L_VERTICAL_LINE</param>
'''  <param name="linewidth">[in] - width of "line" that is drawn; between 1 and 7</param>
'''  <param name="refpos">[in] - reference position y for horizontal and x for vertical</param>
'''  <param name="max">[in] - maximum excursion in pixels from baseline</param>
'''  <param name="drawref">[in] - 1 to draw the reference line and the normal to it</param>
'''   <returns>ptad, or NULL on error</returns>
Public Shared Function makePlotPtaFromNumaGen(
				ByVal na as Numa, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal linewidth as Integer, 
				ByVal refpos as Integer, 
				ByVal max as Integer, 
				ByVal drawref as Integer) as Pta

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.makePlotPtaFromNumaGen( na.Pointer, orient, linewidth, refpos, max, drawref)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\graphics.c (1254, 1)
' pixRenderPta()
' pixRenderPta(PIX *, PTA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) L_SET_PIXELS puts all image bits in each pixel to 1
''' (black for 1 bpp; white for depth GT 1)
''' (2) L_CLEAR_PIXELS puts all image bits in each pixel to 0
''' (white for 1 bpp; black for depth GT 1)
''' (3) L_FLIP_PIXELS reverses all image bits in each pixel
''' (4) This function clips the rendering to the pix.  It performs
''' clipping for functions such as pixRenderLine(),
''' pixRenderBox() and pixRenderBoxa(), that call pixRenderPta().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="pta">[in] - arbitrary set of points</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPta(
				ByVal pix as Pix, 
				ByVal pta as Pta, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPta( pix.Pointer, pta.Pointer, op)

	Return _Result
End Function

' SRC\graphics.c (1343, 1)
' pixRenderPtaArb()
' pixRenderPtaArb(PIX *, PTA *, l_uint8, l_uint8, l_uint8) as l_ok
'''  <summary>
''' Notes
''' (1) If pix is colormapped, render this color (or the nearest
''' color if the cmap is full) on each pixel.
''' (2) The rgb components have the standard dynamic range [0 ... 255]
''' (3) If pix is not colormapped, do the best job you can using
''' the input colors
''' ~ d = 1 set the pixels
''' ~ d = 2, 4, 8 average the input rgb value
''' ~ d = 32 use the input rgb value
''' (4) This function clips the rendering to the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, cmapped ok</param>
'''  <param name="pta">[in] - arbitrary set of points</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPtaArb(
				ByVal pix as Pix, 
				ByVal pta as Pta, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPtaArb( pix.Pointer, pta.Pointer, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (1418, 1)
' pixRenderPtaBlend()
' pixRenderPtaBlend(PIX *, PTA *, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This function clips the rendering to the pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="pta">[in] - arbitrary set of points</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPtaBlend(
				ByVal pix as Pix, 
				ByVal pta as Pta, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal fract as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPtaBlend( pix.Pointer, pta.Pointer, rval, gval, bval, fract)

	Return _Result
End Function

' SRC\graphics.c (1483, 1)
' pixRenderLine()
' pixRenderLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="x1">[in] - </param>
'''  <param name="y1">[in] - </param>
'''  <param name="x2">[in] - </param>
'''  <param name="y2">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderLine(
				ByVal pix as Pix, 
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer, 
				ByVal width as Integer, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderLine( pix.Pointer, x1, y1, x2, y2, width, op)

	Return _Result
End Function

' SRC\graphics.c (1523, 1)
' pixRenderLineArb()
' pixRenderLineArb(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, cmapped ok</param>
'''  <param name="x1">[in] - </param>
'''  <param name="y1">[in] - </param>
'''  <param name="x2">[in] - </param>
'''  <param name="y2">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderLineArb(
				ByVal pix as Pix, 
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderLineArb( pix.Pointer, x1, y1, x2, y2, width, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (1564, 1)
' pixRenderLineBlend()
' pixRenderLineBlend(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="x1">[in] - </param>
'''  <param name="y1">[in] - </param>
'''  <param name="x2">[in] - </param>
'''  <param name="y2">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderLineBlend(
				ByVal pix as Pix, 
				ByVal x1 as Integer, 
				ByVal y1 as Integer, 
				ByVal x2 as Integer, 
				ByVal y2 as Integer, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal fract as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderLineBlend( pix.Pointer, x1, y1, x2, y2, width, rval, gval, bval, fract)

	Return _Result
End Function

' SRC\graphics.c (1604, 1)
' pixRenderBox()
' pixRenderBox(PIX *, BOX *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="box">[in] - </param>
'''  <param name="width">[in] - thickness of box lines</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBox(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal width as Integer, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBox( pix.Pointer, box.Pointer, width, op)

	Return _Result
End Function

' SRC\graphics.c (1642, 1)
' pixRenderBoxArb()
' pixRenderBoxArb(PIX *, BOX *, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, cmapped ok</param>
'''  <param name="box">[in] - </param>
'''  <param name="width">[in] - thickness of box lines</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBoxArb(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBoxArb( pix.Pointer, box.Pointer, width, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (1682, 1)
' pixRenderBoxBlend()
' pixRenderBoxBlend(PIX *, BOX *, l_int32, l_uint8, l_uint8, l_uint8, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="box">[in] - </param>
'''  <param name="width">[in] - thickness of box lines</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - in [0.0 - 1.0]; complete transparency (no effect if 0.0; no transparency if 1.0)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBoxBlend(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal fract as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBoxBlend( pix.Pointer, box.Pointer, width, rval, gval, bval, fract)

	Return _Result
End Function

' SRC\graphics.c (1721, 1)
' pixRenderBoxa()
' pixRenderBoxa(PIX *, BOXA *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBoxa(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal width as Integer, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBoxa( pix.Pointer, boxa.Pointer, width, op)

	Return _Result
End Function

' SRC\graphics.c (1759, 1)
' pixRenderBoxaArb()
' pixRenderBoxaArb(PIX *, BOXA *, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth; colormapped is ok</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBoxaArb(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBoxaArb( pix.Pointer, boxa.Pointer, width, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (1800, 1)
' pixRenderBoxaBlend()
' pixRenderBoxaBlend(PIX *, BOXA *, l_int32, l_uint8, l_uint8, l_uint8, l_float32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - in [0.0 - 1.0]; complete transparency (no effect if 0.0; no transparency if 1.0)</param>
'''  <param name="removedups">[in] - 1 to remove; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderBoxaBlend(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal fract as Single, 
				ByVal removedups as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderBoxaBlend( pix.Pointer, boxa.Pointer, width, rval, gval, bval, fract, removedups)

	Return _Result
End Function

' SRC\graphics.c (1843, 1)
' pixRenderHashBox()
' pixRenderHashBox(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="box">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBox(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBox( pix.Pointer, box.Pointer, spacing, width, orient, outline, op)

	Return _Result
End Function

' SRC\graphics.c (1893, 1)
' pixRenderHashBoxArb()
' pixRenderHashBoxArb(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth; cmapped ok</param>
'''  <param name="box">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBoxArb(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBoxArb( pix.Pointer, box.Pointer, spacing, width, orient, outline, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (1945, 1)
' pixRenderHashBoxBlend()
' pixRenderHashBoxBlend(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp</param>
'''  <param name="box">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - in [0.0 - 1.0]; complete transparency (no effect if 0.0; no transparency if 1.0)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBoxBlend(
				ByVal pix as Pix, 
				ByVal box as Box, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal fract as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBoxBlend( pix.Pointer, box.Pointer, spacing, width, orient, outline, rval, gval, bval, fract)

	Return _Result
End Function

' SRC\graphics.c (2003, 1)
' pixRenderHashMaskArb()
' pixRenderHashMaskArb(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place operation that renders hash lines
''' through a mask %pixm onto %pix.  The mask origin is
''' translated by (%x,%y) relative to the origin of %pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth; cmapped ok</param>
'''  <param name="pixm">[in] - 1 bpp clipping mask for hash marks</param>
'''  <param name="x">[in] - ,y   UL corner of %pixm with respect to %pix</param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashMaskArb(
				ByVal pix as Pix, 
				ByVal pixm as Pix, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashMaskArb( pix.Pointer, pixm.Pointer, x, y, spacing, width, orient, outline, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (2071, 1)
' pixRenderHashBoxa()
' pixRenderHashBoxa(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBoxa(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal op as Enumerations.L_PIXELS) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBoxa( pix.Pointer, boxa.Pointer, spacing, width, orient, outline, op)

	Return _Result
End Function

' SRC\graphics.c (2121, 1)
' pixRenderHashBoxaArb()
' pixRenderHashBoxaArb(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth; cmapped ok</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBoxaArb(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBoxaArb( pix.Pointer, boxa.Pointer, spacing, width, orient, outline, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (2173, 1)
' pixRenderHashBoxaBlend()
' pixRenderHashBoxaBlend(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="boxa">[in] - </param>
'''  <param name="spacing">[in] - spacing between lines; must be GT 1</param>
'''  <param name="width">[in] - thickness of box and hash lines</param>
'''  <param name="orient">[in] - orientation of lines L_HORIZONTAL_LINE, ...</param>
'''  <param name="outline">[in] - 0 to skip drawing box outline</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - in [0.0 - 1.0]; complete transparency (no effect if 0.0; no transparency if 1.0)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderHashBoxaBlend(
				ByVal pix as Pix, 
				ByVal boxa as Boxa, 
				ByVal spacing as Integer, 
				ByVal width as Integer, 
				ByVal orient as Enumerations.L_LINE, 
				ByVal outline as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal fract as Single) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderHashBoxaBlend( pix.Pointer, boxa.Pointer, spacing, width, orient, outline, rval, gval, bval, fract)

	Return _Result
End Function

' SRC\graphics.c (2227, 1)
' pixRenderPolyline()
' pixRenderPolyline(PIX *, PTA *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' This renders a closed contour.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, not cmapped</param>
'''  <param name="ptas">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="op">[in] - one of L_SET_PIXELS, L_CLEAR_PIXELS, L_FLIP_PIXELS</param>
'''  <param name="closeflag">[in] - 1 to close the contour; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPolyline(
				ByVal pix as Pix, 
				ByVal ptas as Pta, 
				ByVal width as Integer, 
				ByVal op as Enumerations.L_PIXELS, 
				ByVal closeflag as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPolyline( pix.Pointer, ptas.Pointer, width, op, closeflag)

	Return _Result
End Function

' SRC\graphics.c (2272, 1)
' pixRenderPolylineArb()
' pixRenderPolylineArb(PIX *, PTA *, l_int32, l_uint8, l_uint8, l_uint8, l_int32) as l_ok
'''  <summary>
''' Notes
''' This renders a closed contour.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth; cmapped ok</param>
'''  <param name="ptas">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="closeflag">[in] - 1 to close the contour; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPolylineArb(
				ByVal pix as Pix, 
				ByVal ptas as Pta, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal closeflag as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPolylineArb( pix.Pointer, ptas.Pointer, width, rval, gval, bval, closeflag)

	Return _Result
End Function

' SRC\graphics.c (2315, 1)
' pixRenderPolylineBlend()
' pixRenderPolylineBlend(PIX *, PTA *, l_int32, l_uint8, l_uint8, l_uint8, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 32 bpp rgb</param>
'''  <param name="ptas">[in] - </param>
'''  <param name="width">[in] - thickness of line</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="fract">[in] - in [0.0 - 1.0]; complete transparency (no effect if 0.0; no transparency if 1.0)</param>
'''  <param name="closeflag">[in] - 1 to close the contour; 0 otherwise</param>
'''  <param name="removedups">[in] - 1 to remove; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderPolylineBlend(
				ByVal pix as Pix, 
				ByVal ptas as Pta, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte, 
				ByVal fract as Single, 
				ByVal closeflag as Integer, 
				ByVal removedups as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")
	If {32}.contains (pix.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderPolylineBlend( pix.Pointer, ptas.Pointer, width, rval, gval, bval, fract, closeflag, removedups)

	Return _Result
End Function

' SRC\graphics.c (2356, 1)
' pixRenderGridArb()
' pixRenderGridArb(PIX *, l_int32, l_int32, l_int32, l_uint8, l_uint8, l_uint8) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - any depth, cmapped ok</param>
'''  <param name="nx">[in] - number of rectangles in each direction</param>
'''  <param name="ny">[in] - number of rectangles in each direction</param>
'''  <param name="width">[in] - thickness of grid lines</param>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRenderGridArb(
				ByVal pix as Pix, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal width as Integer, 
				ByVal rval as Byte, 
				ByVal gval as Byte, 
				ByVal bval as Byte) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (rval) then Throw New ArgumentNullException  ("rval cannot be Nothing")
	If IsNothing (gval) then Throw New ArgumentNullException  ("gval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRenderGridArb( pix.Pointer, nx, ny, width, rval, gval, bval)

	Return _Result
End Function

' SRC\graphics.c (2416, 1)
' pixRenderRandomCmapPtaa()
' pixRenderRandomCmapPtaa(PIX *, PTAA *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a debugging routine, that displays a set of
''' pixels, selected by the set of Ptas in a Ptaa,
''' in a random color in a pix.
''' (2) If %polyflag == 1, each Pta is considered to be a polyline,
''' and is rendered using %width and %closeflag.  Each polyline
''' is rendered in a random color.
''' (3) If %polyflag == 0, all points in each Pta are rendered in a
''' random color.  The %width and %closeflag parameters are ignored.
''' (4) The output pix is 8 bpp and colormapped.  Up to 254
''' different, randomly selected colors, can be used.
''' (5) The rendered pixels replace the input pixels.  They will
''' be clipped silently to the input pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
'''  <param name="ptaa">[in] - </param>
'''  <param name="polyflag">[in] - 1 to interpret each Pta as a polyline; 0 to simply render the Pta as a set of pixels</param>
'''  <param name="width">[in] - thickness of line; use only for polyline</param>
'''  <param name="closeflag">[in] - 1 to close the contour; 0 otherwise; use only for polyline mode</param>
'''   <returns>pixd cmapped, 8 bpp or NULL on error</returns>
Public Shared Function pixRenderRandomCmapPtaa(
				ByVal pix as Pix, 
				ByVal ptaa as Ptaa, 
				ByVal polyflag as Integer, 
				ByVal width as Integer, 
				ByVal closeflag as Integer) as Pix

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	If {1,2,4,8,16,32}.contains (pix.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16, 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRenderRandomCmapPtaa( pix.Pointer, ptaa.Pointer, polyflag, width, closeflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2485, 1)
' pixRenderPolygon()
' pixRenderPolygon(PTA *, l_int32, l_int32 *, l_int32 *) as PIX *
'''  <summary>
''' Notes
''' (1) The pix is the minimum size required to contain the origin
''' and the polygon.  For example, the max x value of the input
''' points is w - 1, where w is the pix width.
''' (2) The rendered line is 4-connected, so that an interior or
''' exterior 8-c.c. flood fill operation works properly.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - of vertices, none repeated</param>
'''  <param name="width">[in] - of polygon outline</param>
'''  <param name="pxmin">[out][optional] - min x value of input pts</param>
'''  <param name="pymin">[out][optional] - min y value of input pts</param>
'''   <returns>pix 1 bpp, with outline generated, or NULL on error</returns>
Public Shared Function pixRenderPolygon(
				ByVal ptas as Pta, 
				ByVal width as Integer, 
				ByRef pxmin as Integer, 
				ByRef pymin as Integer) as Pix

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRenderPolygon( ptas.Pointer, width, pxmin, pymin)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2540, 1)
' pixFillPolygon()
' pixFillPolygon(PIX *, PTA *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This fills the interior of the polygon, returning a
''' new pix.  It works for both convex and non-convex polygons.
''' (2) To generate a filled polygon from a pta
''' PIX pixt = pixRenderPolygon(pta, 1, xmin, ymin);
''' PIX pixd = pixFillPolygon(pixt, pta, xmin, ymin);
''' pixDestroy(pixt);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp, with 4-connected polygon outline</param>
'''  <param name="pta">[in] - vertices of the polygon</param>
'''  <param name="xmin">[in] - min values of vertices of polygon</param>
'''  <param name="ymin">[in] - min values of vertices of polygon</param>
'''   <returns>pixd with outline filled, or NULL on error</returns>
Public Shared Function pixFillPolygon(
				ByVal pixs as Pix, 
				ByVal pta as Pta, 
				ByVal xmin as Integer, 
				ByVal ymin as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillPolygon( pixs.Pointer, pta.Pointer, xmin, ymin)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2619, 1)
' pixRenderContours()
' pixRenderContours(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The output can be either 1 bpp, showing just the contour
''' lines, or a copy of the input pixs with the contour lines
''' superposed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 16 bpp; no colormap</param>
'''  <param name="startval">[in] - value of lowest contour; must be in [0 ... maxval]</param>
'''  <param name="incr">[in] - increment to next contour; must be GT 0</param>
'''  <param name="outdepth">[in] - either 1 or depth of pixs</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRenderContours(
				ByVal pixs as Pix, 
				ByVal startval as Integer, 
				ByVal incr as Integer, 
				ByVal outdepth as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRenderContours( pixs.Pointer, startval, incr, outdepth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2745, 1)
' fpixAutoRenderContours()
' fpixAutoRenderContours(FPIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The increment is set to get approximately %ncontours.
''' (2) The proximity to the target value for contour display
''' is set to 0.15.
''' (3) Negative values are rendered in red; positive values as black.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpix">[in] - </param>
'''  <param name="ncontours">[in] - GT 1, LT 500, typ. about 50</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function fpixAutoRenderContours(
				ByVal fpix as FPix, 
				ByVal ncontours as Integer) as Pix

	If IsNothing (fpix) then Throw New ArgumentNullException  ("fpix cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixAutoRenderContours( fpix.Pointer, ncontours)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2783, 1)
' fpixRenderContours()
' fpixRenderContours(FPIX *, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) Values are displayed when val/incr is within +-proxim
''' to an integer.  The default value is 0.15; smaller values
''' result in thinner contour lines.
''' (2) Negative values are rendered in red; positive values as black.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixs">[in] - </param>
'''  <param name="incr">[in] - increment between contours; must be GT 0.0</param>
'''  <param name="proxim">[in] - required proximity to target value; default 0.15</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function fpixRenderContours(
				ByVal fpixs as FPix, 
				ByVal incr as Single, 
				ByVal proxim as Single) as Pix

	If IsNothing (fpixs) then Throw New ArgumentNullException  ("fpixs cannot be Nothing")
	If IsNothing (incr) then Throw New ArgumentNullException  ("incr cannot be Nothing")
	If IsNothing (proxim) then Throw New ArgumentNullException  ("proxim cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixRenderContours( fpixs.Pointer, incr, proxim)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\graphics.c (2862, 1)
' pixGeneratePtaBoundary()
' pixGeneratePtaBoundary(PIX *, l_int32) as PTA *
'''  <summary>
''' Notes
''' (1) Similar to ptaGetBoundaryPixels(), except here
''' we only get pixels in the foreground
''' we can have a "line" width greater than 1 pixel.
''' (2) Once generated, this can be applied to a random 1 bpp image
''' to add a color boundary as follows
''' Pta pta = pixGeneratePtaBoundary(pixs, width);
''' Pix pix1 = pixConvert1To8Cmap(pixs);
''' pixRenderPtaArb(pix1, pta, rval, gval, bval);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="width">[in] - of boundary line</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function pixGeneratePtaBoundary(
				ByVal pixs as Pix, 
				ByVal width as Integer) as Pta

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGeneratePtaBoundary( pixs.Pointer, width)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

End Class
