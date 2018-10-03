Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixtiling.c (121, 1)
' pixTilingCreate()
' pixTilingCreate(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXTILING *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We put a clone of pixs in the PixTiling.<para/>
''' (2) The input to pixTilingCreate() for horizontal tiling can be<para/>
''' either the number of tiles across the image or the approximate<para/>
''' width of the tiles.  If the latter, the actual width will be<para/>
''' determined by making all tiles but the last of equal width, and<para/>
''' making the last as close to the others as possible.  The same<para/>
''' consideration is applied independently to the vertical tiling.<para/>
''' To specify tile width, set nx = 0 to specify the number of<para/>
''' tiles horizontally across the image, set w = 0.<para/>
''' (3) If pixs is to be tiled in one-dimensional strips, use ny = 1 for<para/>
''' vertical strips and nx = 1 for horizontal strips.<para/>
''' (4) The overlap must not be larger than the width or height of<para/>
''' the leftmost or topmost tile(s).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - pix to be tiled any depth colormap OK</param>
'''  <param name="nx">[in] - number of tiles across image</param>
'''  <param name="ny">[in] - number of tiles down image</param>
'''  <param name="w">[in] - desired width of each tile</param>
'''  <param name="h">[in] - desired height of each tile</param>
'''  <param name="xoverlap">[in] - overlap into neighboring tiles on each side</param>
'''  <param name="yoverlap">[in] - overlap into neighboring tiles above and below</param>
'''   <returns>pixtiling, or NULL on error</returns>
Public Shared Function pixTilingCreate(
				ByVal pixs as Pix, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal xoverlap as Integer, 
				ByVal yoverlap as Integer) as PixTiling

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixTilingCreate( pixs.Pointer, nx, ny, w, h, xoverlap, yoverlap)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixTiling(_Result)
End Function

' SRC\pixtiling.c (178, 1)
' pixTilingDestroy()
' pixTilingDestroy(PIXTILING **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="ppt">[in,out] - will be set to null before returning</param>
Public Shared Sub pixTilingDestroy(
				ByRef ppt as PixTiling)


	Dim pptPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppt) Then pptPTR = ppt.Pointer

	LeptonicaSharp.Natives.pixTilingDestroy( pptPTR)
	if pptPTR <> IntPtr.Zero then ppt = new PixTiling(pptPTR)

End Sub

' SRC\pixtiling.c (208, 1)
' pixTilingGetCount()
' pixTilingGetCount(PIXTILING *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pt">[in] - pixtiling</param>
'''  <param name="pnx">[out][optional] - nx can be null</param>
'''  <param name="pny">[out][optional] - ny can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTilingGetCount(
				ByVal pt as PixTiling, 
				ByRef pnx as Integer, 
				ByRef pny as Integer) as Integer

	If IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixTilingGetCount( pt.Pointer, pnx, pny)

	Return _Result
End Function

' SRC\pixtiling.c (231, 1)
' pixTilingGetSize()
' pixTilingGetSize(PIXTILING *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pt">[in] - pixtiling</param>
'''  <param name="pw">[out][optional] - tile width can be null</param>
'''  <param name="ph">[out][optional] - tile height can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTilingGetSize(
				ByVal pt as PixTiling, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixTilingGetSize( pt.Pointer, pw, ph)

	Return _Result
End Function

' SRC\pixtiling.c (255, 1)
' pixTilingGetTile()
' pixTilingGetTile(PIXTILING *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pt">[in] - pixtiling</param>
'''  <param name="i">[in] - tile row index</param>
'''  <param name="j">[in] - tile column index</param>
'''   <returns>pixd tile with appropriate boundary (overlap) pixels added, or NULL on error</returns>
Public Shared Function pixTilingGetTile(
				ByVal pt as PixTiling, 
				ByVal i as Integer, 
				ByVal j as Integer) as Pix

	If IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixTilingGetTile( pt.Pointer, i, j)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixtiling.c (368, 1)
' pixTilingNoStripOnPaint()
' pixTilingNoStripOnPaint(PIXTILING *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The default for paint is to strip out the overlap pixels<para/>
''' that are added by pixTilingGetTile().  However, some<para/>
''' operations will generate an image with these pixels<para/>
''' stripped off.  This tells the paint operation not<para/>
''' to strip the added boundary pixels when painting.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pt">[in] - pixtiling</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTilingNoStripOnPaint(
				ByVal pt as PixTiling) as Integer

	If IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixTilingNoStripOnPaint( pt.Pointer)

	Return _Result
End Function

' SRC\pixtiling.c (390, 1)
' pixTilingPaintTile()
' pixTilingPaintTile(PIX *, l_int32, l_int32, PIX *, PIXTILING *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - dest: paint tile onto this, without overlap</param>
'''  <param name="i">[in] - tile row index</param>
'''  <param name="j">[in] - tile column index</param>
'''  <param name="pixs">[in] - source: tile to be painted from</param>
'''  <param name="pt">[in] - pixtiling struct</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTilingPaintTile(
				ByVal pixd as Pix, 
				ByVal i as Integer, 
				ByVal j as Integer, 
				ByVal pixs as Pix, 
				ByVal pt as PixTiling) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixTilingPaintTile( pixd.Pointer, i, j, pixs.Pointer, pt.Pointer)

	Return _Result
End Function

End Class
