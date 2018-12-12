Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' strokes.c (75, 1)
' pixFindStrokeLength(pixs, tab8, plength) as Integer
' pixFindStrokeLength(PIX *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) Returns half the number of fg boundary pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindStrokeLength/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
'''  <param name="plength">[out] - estimated length of the strokes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindStrokeLength(
				ByVal pixs as Pix, 
				ByVal tab8 as Integer(), 
				<Out()>  ByRef plength as Integer) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as Integer = Natives.pixFindStrokeLength(pixs.Pointer,   tab8,   plength)
	
	return _Result
End Function

' strokes.c (123, 1)
' pixFindStrokeWidth(pixs, thresh, tab8, pwidth, pnahisto) as Integer
' pixFindStrokeWidth(PIX *, l_float32, l_int32 *, l_float32 *, NUMA **) as l_ok
'''  <summary>
''' (1) This uses two methods to estimate the stroke width:
'''(a) half the fg boundary length
'''(b) a value derived from the histogram of the fg distance transform<para/>
'''
'''(2) Distance is measured in 8-connected<para/>
'''
'''(3) %thresh is the minimum fraction N(dist=d)/N(dist=1) of pixels
'''required to determine if the pixels at distance d are above
'''the noise. It is typically about 0.15.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindStrokeWidth/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="thresh">[in] - fractional count threshold relative to distance 1</param>
'''  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
'''  <param name="pwidth">[out] - estimated width of the strokes</param>
'''  <param name="pnahisto">[out][optional] - histo of pixel distances from bg</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindStrokeWidth(
				ByVal pixs as Pix, 
				ByVal thresh as Single, 
				ByVal tab8 as Integer(), 
				<Out()>  ByRef pwidth as Single, 
				<Out()> Optional  ByRef pnahisto as Numa = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim pnahistoPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixFindStrokeWidth(pixs.Pointer,   thresh,   tab8,   pwidth, pnahistoPtr)
	
	if pnahistoPtr = IntPtr.Zero then pnahisto = Nothing else pnahisto = new Numa(pnahistoPtr)
	return _Result
End Function

' strokes.c (208, 1)
' pixaFindStrokeWidth(pixa, thresh, tab8, debug) as Numa
' pixaFindStrokeWidth(PIXA *, l_float32, l_int32 *, l_int32) as NUMA *
'''  <summary>
''' (1) See pixFindStrokeWidth() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindStrokeWidth/*"/>
'''  <param name="pixa">[in] - of 1 bpp images</param>
'''  <param name="thresh">[in] - fractional count threshold relative to distance 1</param>
'''  <param name="tab8">[in][optional] - table for counting fg pixels can be NULL</param>
'''  <param name="debug">[in] - 1 for debug output 0 to skip</param>
'''   <returns>na  array of stroke widths for each pix in %pixa NULL on error</returns>
Public Shared Function pixaFindStrokeWidth(
				ByVal pixa as Pixa, 
				ByVal thresh as Single, 
				Optional ByVal tab8 as Integer() = nothing, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Numa


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaFindStrokeWidth(pixa.Pointer,   thresh,   tab8,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' strokes.c (254, 1)
' pixaModifyStrokeWidth(pixas, targetw) as Pixa
' pixaModifyStrokeWidth(PIXA *, l_float32) as PIXA *
'''  <summary>
''' pixaModifyStrokeWidth()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaModifyStrokeWidth/*"/>
'''  <param name="pixas">[in] - of 1 bpp pix</param>
'''  <param name="targetw">[out] - desired width for strokes in each pix</param>
'''   <returns>pixa  with modified stroke widths, or NULL on error</returns>
Public Shared Function pixaModifyStrokeWidth(
				ByVal pixas as Pixa, 
				<Out()>  ByRef targetw as Single) as Pixa


if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaModifyStrokeWidth(pixas.Pointer,   targetw)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' strokes.c (298, 1)
' pixModifyStrokeWidth(pixs, width, targetw) as Pix
' pixModifyStrokeWidth(PIX *, l_float32, l_float32) as PIX *
'''  <summary>
''' pixModifyStrokeWidth()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixModifyStrokeWidth/*"/>
'''  <param name="pixs">[in] - of 1 bpp pix</param>
'''  <param name="width">[in] - measured average stroke width</param>
'''  <param name="targetw">[in] - desired stroke width</param>
'''   <returns>pix  with modified stroke width, or NULL on error</returns>
Public Shared Function pixModifyStrokeWidth(
				ByVal pixs as Pix, 
				ByVal width as Single, 
				ByVal targetw as Single) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixModifyStrokeWidth(pixs.Pointer,   width,   targetw)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' strokes.c (345, 1)
' pixaSetStrokeWidth(pixas, width, thinfirst, connectivity) as Pixa
' pixaSetStrokeWidth(PIXA *, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' (1) If %thinfirst == 1, thin to a skeleton using the specified
'''%connectivity.  Use %thinfirst == 0 if all pix in pixas
'''have already been thinned as far as possible.<para/>
'''
'''(2) The image is dilated to the required %width.  This dilation
'''is not connectivity preserving, so this is typically
'''used in a situation where merging of c.c. in the individual
'''pix is not a problem e.g., where each pix is a single c.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSetStrokeWidth/*"/>
'''  <param name="pixas">[in] - of 1 bpp pix</param>
'''  <param name="width">[in] - set stroke width to this value, in [1 ... 100].</param>
'''  <param name="thinfirst">[in] - 1 to thin all pix to a skeleton first 0 to skip</param>
'''  <param name="connectivity">[in] - 4 or 8, to be used if %thinfirst == 1</param>
'''   <returns>pixa  with all stroke widths being %width, or NULL on error</returns>
Public Shared Function pixaSetStrokeWidth(
				ByVal pixas as Pixa, 
				ByVal width as Integer, 
				ByVal thinfirst as Integer, 
				ByVal connectivity as Integer) as Pixa


if IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaSetStrokeWidth(pixas.Pointer,   width,   thinfirst,   connectivity)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' strokes.c (397, 1)
' pixSetStrokeWidth(pixs, width, thinfirst, connectivity) as Pix
' pixSetStrokeWidth(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) See notes in pixaSetStrokeWidth().<para/>
'''
'''(2) A white border of sufficient width to avoid boundary
'''artifacts in the thickening step is added before thinning.<para/>
'''
'''(3) %connectivity == 8 usually gives a slightly smoother result.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetStrokeWidth/*"/>
'''  <param name="pixs">[in] - 1 bpp pix</param>
'''  <param name="width">[in] - set stroke width to this value, in [1 ... 100].</param>
'''  <param name="thinfirst">[in] - 1 to thin all pix to a skeleton first 0 to skip</param>
'''  <param name="connectivity">[in] - 4 or 8, to be used if %thinfirst == 1</param>
'''   <returns>pixd  with stroke width set to %width, or NULL on error</returns>
Public Shared Function pixSetStrokeWidth(
				ByVal pixs as Pix, 
				ByVal width as Integer, 
				ByVal thinfirst as Integer, 
				ByVal connectivity as Integer) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixSetStrokeWidth(pixs.Pointer,   width,   thinfirst,   connectivity)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

End Class


