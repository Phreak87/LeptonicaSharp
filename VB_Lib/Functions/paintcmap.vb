Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\paintcmap.c (98, 1)
' pixSetSelectCmap(pixs, box, sindex, rval, gval, bval) as Integer
' pixSetSelectCmap(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) It sets all pixels in region that have the color specified
''' by the colormap index 'sindex' to the new color.<para/>
''' 
''' (3) sindex must be in the existing colormap otherwise an
''' error is returned.<para/>
''' 
''' (4) If the new color exists in the colormap, it is used
''' otherwise, it is added to the colormap.  If it cannot be
''' added because the colormap is full, an error is returned.<para/>
''' 
''' (5) If box is NULL, applies function to the entire image otherwise,
''' clips the operation to the intersection of the box and pix.<para/>
''' 
''' (6) An example of use would be to set to a specific color all
''' the light (background) pixels within a certain region of
''' a 3-level 2 bpp image, while leaving light pixels outside
''' this region unchanged.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSetSelectCmap/*"/>
'''  <param name="pixs">[in] - 1, 2, 4 or 8 bpp, with colormap</param>
'''  <param name="box">[in][optional] - region to set color can be NULL</param>
'''  <param name="sindex">[in] - colormap index of pixels to be changed</param>
'''  <param name="rval">[in] - new color to paint</param>
'''  <param name="gval">[in] - new color to paint</param>
'''  <param name="bval">[in] - new color to paint</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetSelectCmap(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal sindex as Integer, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetSelectCmap( pixs.Pointer, boxPTR, sindex, rval, gval, bval)

	Return _Result
End Function

' SRC\paintcmap.c (219, 1)
' pixColorGrayRegionsCmap(pixs, boxa, type, rval, gval, bval) as Integer
' pixColorGrayRegionsCmap(PIX *, BOXA *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
''' preserving antialiasing.
''' If type == L_PAINT_DARK, it colorizes non-white pixels,
''' preserving antialiasing.  See pixColorGrayCmap() for details.<para/>
''' 
''' (3) This can also be called through pixColorGrayRegions().<para/>
''' 
''' (4) This increases the colormap size by the number of
''' different gray (non-black or non-white) colors in the
''' selected regions of pixs.  If there is not enough room in
''' the colormap for this expansion, it returns 1 (error),
''' and the caller should check the return value.<para/>
''' 
''' (5) Because two boxes in the boxa can overlap, pixels that
''' are colorized in the first box must be excluded in the
''' second because their value exceeds the size of the map.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGrayRegionsCmap/*"/>
'''  <param name="pixs">[in] - 8 bpp, with colormap</param>
'''  <param name="boxa">[in] - of regions in which to apply color</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="rval">[in] - target color</param>
'''  <param name="gval">[in] - target color</param>
'''  <param name="bval">[in] - target color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorGrayRegionsCmap(
				 ByVal pixs as Pix, 
				 ByVal boxa as Boxa, 
				 ByVal type as Enumerations.L_PAINT, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorGrayRegionsCmap( pixs.Pointer, boxa.Pointer, type, rval, gval, bval)

	Return _Result
End Function

' SRC\paintcmap.c (327, 1)
' pixColorGrayCmap(pixs, box, type, rval, gval, bval) as Integer
' pixColorGrayCmap(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
''' preserving antialiasing.
''' If type == L_PAINT_DARK, it colorizes non-white pixels,
''' preserving antialiasing.<para/>
''' 
''' (3) box gives the region to apply color if NULL, this
''' colorizes the entire image.<para/>
''' 
''' (4) If the cmap is only 2 or 4 bpp, pixs is converted in-place
''' to an 8 bpp cmap.  A 1 bpp cmap is not a valid input pix.<para/>
''' 
''' (5) This can also be called through pixColorGray().<para/>
''' 
''' (6) This operation increases the colormap size by the number of
''' different gray (non-black or non-white) colors in the
''' input colormap.  If there is not enough room in the colormap
''' for this expansion, it returns 1 (error), and the caller
''' should check the return value.<para/>
''' 
''' (7) Using the darkness of each original pixel in the rect,
''' it generates a new color (based on the input rgb values).
''' If type == L_PAINT_LIGHT, the new color is a (generally)
''' darken-to-black version of the  input rgb color, where the
''' amount of darkening increases with the darkness of the
''' original pixel color.
''' If type == L_PAINT_DARK, the new color is a (generally)
''' faded-to-white version of the  input rgb color, where the
''' amount of fading increases with the brightness of the
''' original pixel color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGrayCmap/*"/>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
'''  <param name="box">[in][optional] - region to set color can be NULL</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="rval">[in] - target color</param>
'''  <param name="gval">[in] - target color</param>
'''  <param name="bval">[in] - target color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorGrayCmap(
				 ByVal pixs as Pix, 
				 ByVal box as Box, 
				 ByVal type as Enumerations.L_PAINT, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorGrayCmap( pixs.Pointer, boxPTR, type, rval, gval, bval)

	Return _Result
End Function

' SRC\paintcmap.c (395, 1)
' pixColorGrayMaskedCmap(pixs, pixm, type, rval, gval, bval) as Integer
' pixColorGrayMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
''' preserving antialiasing.
''' If type == L_PAINT_DARK, it colorizes non-white pixels,
''' preserving antialiasing.  See pixColorGrayCmap() for details.<para/>
''' 
''' (3) This increases the colormap size by the number of
''' different gray (non-black or non-white) colors in the
''' input colormap.  If there is not enough room in the colormap
''' for this expansion, it returns 1 (error).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorGrayMaskedCmap/*"/>
'''  <param name="pixs">[in] - 8 bpp, with colormap</param>
'''  <param name="pixm">[in] - 1 bpp mask, through which to apply color</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="rval">[in] - target color</param>
'''  <param name="gval">[in] - target color</param>
'''  <param name="bval">[in] - target color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorGrayMaskedCmap(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal type as Enumerations.L_PAINT, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorGrayMaskedCmap( pixs.Pointer, pixm.Pointer, type, rval, gval, bval)

	Return _Result
End Function

' SRC\paintcmap.c (492, 1)
' addColorizedGrayToCmap(cmap, type, rval, gval, bval, pna) as Integer
' addColorizedGrayToCmap(PIXCMAP *, l_int32, l_int32, l_int32, l_int32, NUMA **) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) If type == L_PAINT_LIGHT, it colorizes non-black pixels,
''' preserving antialiasing.
''' If type == L_PAINT_DARK, it colorizes non-white pixels,
''' preserving antialiasing.<para/>
''' 
''' (2) This increases the colormap size by the number of
''' different gray (non-black or non-white) colors in the
''' input colormap.  If there is not enough room in the colormap
''' for this expansion, it returns 1 (treated as a warning)
''' the caller should check the return value.<para/>
''' 
''' (3) This can be used to determine if the new colors will fit in
''' the cmap, using null for [and]na.  Returns 0 if they fit 2 if
''' they don't fit.<para/>
''' 
''' (4) The mapping table contains, for each gray color found, the
''' index of the corresponding colorized pixel.  Non-gray
''' pixels are assigned the invalid index 256.<para/>
''' 
''' (5) See pixColorGrayCmap() for usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/addColorizedGrayToCmap/*"/>
'''  <param name="cmap">[in] - from 2 or 4 bpp pix</param>
'''  <param name="type">[in] - L_PAINT_LIGHT, L_PAINT_DARK</param>
'''  <param name="rval">[in] - target color</param>
'''  <param name="gval">[in] - target color</param>
'''  <param name="bval">[in] - target color</param>
'''  <param name="pna">[out][optional] - table for mapping new cmap entries</param>
'''   <returns>0 if OK 1 on error 2 if new colors will not fit in cmap.</returns>
Public Shared Function addColorizedGrayToCmap(
				 ByVal cmap as PixColormap, 
				 ByVal type as Enumerations.L_PAINT, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer, 
				<Out()> Optional ByRef pna as Numa = Nothing) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

Dim pnaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pna) Then pnaPTR = pna.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.addColorizedGrayToCmap( cmap.Pointer, type, rval, gval, bval, pnaPTR)
	if pnaPTR <> IntPtr.Zero then pna = new Numa(pnaPTR)

	Return _Result
End Function

' SRC\paintcmap.c (583, 1)
' pixSetSelectMaskedCmap(pixs, pixm, x, y, sindex, rval, gval, bval) as Integer
' pixSetSelectMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) This paints through the fg of pixm and replaces all pixels
''' in pixs that have a particular value (sindex) with the new color.<para/>
''' 
''' (3) If pixm == NULL, a warning is given.<para/>
''' 
''' (4) sindex must be in the existing colormap otherwise an
''' error is returned.<para/>
''' 
''' (5) If the new color exists in the colormap, it is used
''' otherwise, it is added to the colormap.  If the colormap
''' is full, an error is returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSetSelectMaskedCmap/*"/>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp, with colormap</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask no-op if NULL</param>
'''  <param name="x">[in] - UL corner of mask relative to pixs</param>
'''  <param name="y">[in] - UL corner of mask relative to pixs</param>
'''  <param name="sindex">[in] - colormap index of pixels in pixs to be changed</param>
'''  <param name="rval">[in] - new color to substitute</param>
'''  <param name="gval">[in] - new color to substitute</param>
'''  <param name="bval">[in] - new color to substitute</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSetSelectMaskedCmap(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal sindex as Integer, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetSelectMaskedCmap( pixs.Pointer, pixmPTR, x, y, sindex, rval, gval, bval)

	Return _Result
End Function

' SRC\paintcmap.c (693, 1)
' pixSetMaskedCmap(pixs, pixm, x, y, rval, gval, bval) as Integer
' pixSetMaskedCmap(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an in-place operation.<para/>
''' 
''' (2) It paints a single color through the mask (as a stencil).<para/>
''' 
''' (3) The mask origin is placed at (x,y) on pixs, and the
''' operation is clipped to the intersection of the mask and pixs.<para/>
''' 
''' (4) If pixm == NULL, a warning is given.<para/>
''' 
''' (5) Typically, pixm is a small binary mask located somewhere
''' on the larger pixs.<para/>
''' 
''' (6) If the color is in the colormap, it is used.  Otherwise,
''' it is added if possible an error is returned if the
''' colormap is already full.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSetMaskedCmap/*"/>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp, colormapped</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask no-op if NULL</param>
'''  <param name="x">[in] - origin of pixm relative to pixs can be negative</param>
'''  <param name="y">[in] - origin of pixm relative to pixs can be negative</param>
'''  <param name="rval">[in] - new color to set at each masked pixel</param>
'''  <param name="gval">[in] - new color to set at each masked pixel</param>
'''  <param name="bval">[in] - new color to set at each masked pixel</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixSetMaskedCmap(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSetMaskedCmap( pixs.Pointer, pixmPTR, x, y, rval, gval, bval)

	Return _Result
End Function

End Class
