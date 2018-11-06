Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixafunc2.c (179, 1)
' pixaDisplay(pixa, w, h) as Pix
' pixaDisplay(PIXA *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the boxes to place each pix in the rendered composite.<para/>
''' (2) Set w = h = 0 to use the b.b. of the components to determine<para/>
''' the size of the returned pix.<para/>
''' (3) Uses the first pix in pixa to determine the depth.<para/>
''' (4) The background is written "white".  On 1 bpp, each successive<para/>
''' pix is "painted" (adding foreground), whereas for grayscale<para/>
''' or color each successive pix is blitted with just the src.<para/>
''' (5) If the pixa is empty, returns an empty 1 bpp pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplay/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaDisplay(
				 ByVal pixa as Pixa, 
				 ByVal w as Integer, 
				 ByVal h as Integer) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplay( pixa.Pointer, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (259, 1)
' pixaDisplayOnColor(pixa, w, h, bgcolor) as Pix
' pixaDisplayOnColor(PIXA *, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the boxes to place each pix in the rendered composite.<para/>
''' (2) Set w = h = 0 to use the b.b. of the components to determine<para/>
''' the size of the returned pix.<para/>
''' (3) If any pix in %pixa are colormapped, or if the pix have<para/>
''' different depths, it returns a 32 bpp pix.  Otherwise,<para/>
''' the depth of the returned pixa equals that of the pix in %pixa.<para/>
''' (4) If the pixa is empty, return null.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayOnColor/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''  <param name="bgcolor">[in] - background color to use</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaDisplayOnColor(
				 ByVal pixa as Pixa, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal bgcolor as UInteger) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayOnColor( pixa.Pointer, w, h, bgcolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (354, 1)
' pixaDisplayRandomCmap(pixa, w, h) as Pix
' pixaDisplayRandomCmap(PIXA *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the boxes to place each pix in the rendered composite.<para/>
''' The fg of each pix in %pixa, such as a single connected<para/>
''' component or a line of text, is given a random color.<para/>
''' (2) By default, the background color is black (cmap index 0).<para/>
''' This can be changed by pixcmapResetColor()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayRandomCmap/*"/>
'''  <param name="pixa">[in] - 1 bpp regions, with boxa delineating those regions</param>
'''  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''   <returns>pix   8 bpp, cmapped, with random colors assigned to each region, or NULL on error.</returns>
Public Shared Function pixaDisplayRandomCmap(
				 ByVal pixa as Pixa, 
				 ByVal w as Integer, 
				 ByVal h as Integer) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayRandomCmap( pixa.Pointer, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (428, 1)
' pixaDisplayLinearly(pixas, direction, scalefactor, background, spacing, border, pboxa) as Pix
' pixaDisplayLinearly(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, BOXA **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This puts each pix, sequentially, in a line, either horizontally<para/>
''' or vertically.<para/>
''' (2) If any pix has a colormap, all pix are rendered in rgb.<para/>
''' (3) The boxa gives the location of each image.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayLinearly/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="direction">[in] - L_HORIZ or L_VERT</param>
'''  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''  <param name="pboxa">[out][optional] - location of images in output pix</param>
'''   <returns>pix of composite images, or NULL on error</returns>
Public Shared Function pixaDisplayLinearly(
				 ByVal pixas as Pixa, 
				 ByVal direction as Enumerations.L_direction, 
				 ByVal scalefactor as Single, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				<Out()> Optional ByRef pboxa as Boxa = Nothing) as Pix

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayLinearly( pixas.Pointer, direction, scalefactor, background, spacing, border, pboxaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (522, 1)
' pixaDisplayOnLattice(pixa, cellw, cellh, pncols, pboxa) as Pix
' pixaDisplayOnLattice(PIXA *, l_int32, l_int32, l_int32 *, BOXA **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This places each pix on sequentially on a regular lattice<para/>
''' in the rendered composite.  If a pix is too large to fit in the<para/>
''' allocated lattice space, it is not rendered.<para/>
''' (2) If any pix has a colormap, all pix are rendered in rgb.<para/>
''' (3) This is useful when putting bitmaps of components,<para/>
''' such as characters, into a single image.<para/>
''' (4) The boxa gives the location of each image.  The UL corner<para/>
''' of each image is on a lattice cell corner.  Omitted images<para/>
''' (due to size) are assigned an invalid width and height of 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayOnLattice/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="cellw">[in] - lattice cell width</param>
'''  <param name="cellh">[in] - lattice cell height</param>
'''  <param name="pncols">[out][optional] - number of columns in output lattice</param>
'''  <param name="pboxa">[out][optional] - location of images in lattice</param>
'''   <returns>pix of composite images, or NULL on error</returns>
Public Shared Function pixaDisplayOnLattice(
				 ByVal pixa as Pixa, 
				 ByVal cellw as Integer, 
				 ByVal cellh as Integer, 
				<Out()> Optional ByRef pncols as Integer = Nothing, 
				<Out()> Optional ByRef pboxa as Boxa = Nothing) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayOnLattice( pixa.Pointer, cellw, cellh, pncols, pboxaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (633, 1)
' pixaDisplayUnsplit(pixa, nx, ny, borderwidth, bordercolor) as Pix
' pixaDisplayUnsplit(PIXA *, l_int32, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a logical inverse of pixaSplitPix().  It<para/>
''' constructs a pix from a mosaic of tiles, all of equal size.<para/>
''' (2) For added generality, a border of arbitrary color can<para/>
''' be added to each of the tiles.<para/>
''' (3) In use, pixa will typically have either been generated<para/>
''' from pixaSplitPix() or will derived from a pixa that<para/>
''' was so generated.<para/>
''' (4) All pix in the pixa must be of equal depth, and, if<para/>
''' colormapped, have the same colormap.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayUnsplit/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="nx">[in] - number of mosaic cells horizontally</param>
'''  <param name="ny">[in] - number of mosaic cells vertically</param>
'''  <param name="borderwidth">[in] - of added border on all sides</param>
'''  <param name="bordercolor">[in] - in our RGBA format: 0xrrggbbaa</param>
'''   <returns>pix of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayUnsplit(
				 ByVal pixa as Pixa, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal borderwidth as Integer, 
				 ByVal bordercolor as UInteger) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayUnsplit( pixa.Pointer, nx, ny, borderwidth, bordercolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (708, 1)
' pixaDisplayTiled(pixa, maxwidth, background, spacing) as Pix
' pixaDisplayTiled(PIXA *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This renders a pixa to a single image of width not to<para/>
''' exceed maxwidth, with background color either white or black,<para/>
''' and with each subimage spaced on a regular lattice.<para/>
''' (2) The lattice size is determined from the largest width and height,<para/>
''' separately, of all pix in the pixa.<para/>
''' (3) All pix in the pixa must be of equal depth.<para/>
''' (4) If any pix has a colormap, all pix are rendered in rgb.<para/>
''' (5) Careful: because no components are omitted, this is<para/>
''' dangerous if there are thousands of small components and<para/>
''' one or more very large one, because the size of the<para/>
''' resulting pix can be huge!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiled/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="maxwidth">[in] - of output image</param>
'''  <param name="background">[in] - 0 for white, 1 for black</param>
'''  <param name="spacing">[in] - </param>
'''   <returns>pix of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiled(
				 ByVal pixa as Pixa, 
				 ByVal maxwidth as Integer, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiled( pixa.Pointer, maxwidth, background, spacing)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (822, 1)
' pixaDisplayTiledInRows(pixa, outdepth, maxwidth, scalefactor, background, spacing, border) as Pix
' pixaDisplayTiledInRows(PIXA *, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This renders a pixa to a single image of width not to<para/>
''' exceed maxwidth, with background color either white or black,<para/>
''' and with each row tiled such that the top of each pix is<para/>
''' aligned and separated by 'spacing' from the next one.<para/>
''' A black border can be added to each pix.<para/>
''' (2) All pix are converted to outdepth existing colormaps are removed.<para/>
''' (3) This does a reasonably spacewise-efficient job of laying<para/>
''' out the individual pix images into a tiled composite.<para/>
''' (4) A serialized boxa giving the location in pixd of each input<para/>
''' pix (without added border) is stored in the text string of pixd.<para/>
''' This allows, e.g., regeneration of a pixa from pixd, using<para/>
''' pixaCreateFromBoxa().  If there is no scaling and the depth of<para/>
''' each input pix in the pixa is the same, this tiling operation<para/>
''' can be inverted using the boxa (except for loss of text in<para/>
''' each of the input pix):<para/>
''' pix1 = pixaDisplayTiledInRows(pixa1, 1, 1500, 1.0, 0, 30, 0)<para/>
''' char boxatxt = pixGetText(pix1)<para/>
''' boxa1 = boxaReadMem((l_uint8 )boxatxt, strlen(boxatxt))<para/>
''' pixa2 = pixaCreateFromBoxa(pix1, boxa1, NULL)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiledInRows/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
'''  <param name="maxwidth">[in] - of output image</param>
'''  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''   <returns>pixd of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiledInRows(
				 ByVal pixa as Pixa, 
				 ByVal outdepth as Integer, 
				 ByVal maxwidth as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiledInRows( pixa.Pointer, outdepth, maxwidth, scalefactor, background, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1006, 1)
' pixaDisplayTiledInColumns(pixas, nx, scalefactor, spacing, border) as Pix
' pixaDisplayTiledInColumns(PIXA *, l_int32, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This renders a pixa to a single image with  and nx columns of<para/>
''' subimages.  The background color is white, and each row<para/>
''' is tiled such that the top of each pix is aligned and<para/>
''' each pix is separated by 'spacing' from the next one.<para/>
''' A black border can be added to each pix.<para/>
''' (2) The output depth is determined by the largest depth<para/>
''' required by the pix in the pixa.  Colormaps are removed.<para/>
''' (3) A serialized boxa giving the location in pixd of each input<para/>
''' pix (without added border) is stored in the text string of pixd.<para/>
''' This allows, e.g., regeneration of a pixa from pixd, using<para/>
''' pixaCreateFromBoxa().  If there is no scaling and the depth of<para/>
''' each input pix in the pixa is the same, this tiling operation<para/>
''' can be inverted using the boxa (except for loss of text in<para/>
''' each of the input pix):<para/>
''' pix1 = pixaDisplayTiledInColumns(pixa1, 3, 1.0, 0, 30, 2)<para/>
''' char boxatxt = pixGetText(pix1)<para/>
''' boxa1 = boxaReadMem((l_uint8 )boxatxt, strlen(boxatxt))<para/>
''' pixa2 = pixaCreateFromBoxa(pix1, boxa1, NULL)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiledInColumns/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="nx">[in] - number of columns in output image</param>
'''  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''   <returns>pixd of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiledInColumns(
				 ByVal pixas as Pixa, 
				 ByVal nx as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiledInColumns( pixas.Pointer, nx, scalefactor, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1123, 1)
' pixaDisplayTiledAndScaled(pixa, outdepth, tilewidth, ncols, background, spacing, border) as Pix
' pixaDisplayTiledAndScaled(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be used to tile a number of renderings of<para/>
''' an image that are at different scales and depths.<para/>
''' (2) Each image, after scaling and optionally adding the<para/>
''' black border, has width 'tilewidth'.  Thus, the border does<para/>
''' not affect the spacing between the image tiles.  The<para/>
''' maximum allowed border width is tilewidth / 5.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiledAndScaled/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
'''  <param name="tilewidth">[in] - each pix is scaled to this width</param>
'''  <param name="ncols">[in] - number of tiles in each row</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''   <returns>pix of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiledAndScaled(
				 ByVal pixa as Pixa, 
				 ByVal outdepth as Integer, 
				 ByVal tilewidth as Integer, 
				 ByVal ncols as Integer, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiledAndScaled( pixa.Pointer, outdepth, tilewidth, ncols, background, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1278, 1)
' pixaDisplayTiledWithText(pixa, maxwidth, scalefactor, spacing, border, fontsize, textcolor) as Pix
' pixaDisplayTiledWithText(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a version of pixaDisplayTiledInRows() that prints, below<para/>
''' each pix, the text in the pix text field.  Up to 127 chars<para/>
''' of text in the pix text field are rendered below each pix.<para/>
''' (2) It renders a pixa to a single image of width not to<para/>
''' exceed %maxwidth, with white background color, with each row<para/>
''' tiled such that the top of each pix is aligned and separated<para/>
''' by %spacing from the next one.<para/>
''' (3) All pix are converted to 32 bpp.<para/>
''' (4) This does a reasonably spacewise-efficient job of laying<para/>
''' out the individual pix images into a tiled composite.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiledWithText/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="maxwidth">[in] - of output image</param>
'''  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''  <param name="fontsize">[in] - 4, 6, ... 20</param>
'''  <param name="textcolor">[in] - 0xrrggbb00</param>
'''   <returns>pixd of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiledWithText(
				 ByVal pixa as Pixa, 
				 ByVal maxwidth as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer, 
				 ByVal textcolor as UInteger) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiledWithText( pixa.Pointer, maxwidth, scalefactor, spacing, border, fontsize, textcolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1377, 1)
' pixaDisplayTiledByIndex(pixa, na, width, spacing, border, fontsize, textcolor) as Pix
' pixaDisplayTiledByIndex(PIXA *, NUMA *, l_int32, l_int32, l_int32, l_int32, l_uint32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This renders a pixa to a single image with white<para/>
''' background color, where the pix are placed in columns<para/>
''' given by the index value in the numa.  Each pix<para/>
''' is separated by %spacing from the adjacent ones, and<para/>
''' an optional border is placed around them.<para/>
''' (2) Up to 127 chars of text in the pix text field are rendered<para/>
''' below each pix.  Use newlines in the text field to write<para/>
''' the text in multiple lines that fit within the pix width.<para/>
''' (3) To avoid having empty columns, if there are N different<para/>
''' index values, they should be in [0 ... N-1].<para/>
''' (4) All pix are converted to 32 bpp.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayTiledByIndex/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="na">[in] - numa with indices corresponding to the pix in pixa</param>
'''  <param name="width">[in] - each pix is scaled to this width</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
'''  <param name="fontsize">[in] - 4, 6, ... 20</param>
'''  <param name="textcolor">[in] - 0xrrggbb00</param>
'''   <returns>pixd of tiled images, or NULL on error</returns>
Public Shared Function pixaDisplayTiledByIndex(
				 ByVal pixa as Pixa, 
				 ByVal na as Numa, 
				 ByVal width as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer, 
				 ByVal textcolor as UInteger) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayTiledByIndex( pixa.Pointer, na.Pointer, width, spacing, border, fontsize, textcolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1480, 1)
' pixaaDisplay(paa, w, h) as Pix
' pixaaDisplay(PIXAA *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Each pix of the paa is displayed at the location given by<para/>
''' its box, translated by the box of the containing pixa<para/>
''' if it exists.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaaDisplay/*"/>
'''  <param name="paa">[in] - </param>
'''  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaaDisplay(
				 ByVal paa as Pixaa, 
				 ByVal w as Integer, 
				 ByVal h as Integer) as Pix

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaDisplay( paa.Pointer, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1574, 1)
' pixaaDisplayByPixa(paa, xspace, yspace, maxw) as Pix
' pixaaDisplayByPixa(PIXAA *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Displays each pixa on a line (or set of lines),<para/>
''' in order from top to bottom.  Within each pixa,<para/>
''' the pix are displayed in order from left to right.<para/>
''' (2) The sizes and depths of each pix can differ.  The output pix<para/>
''' has a depth equal to the max depth of all the pix.<para/>
''' (3) This ignores the boxa of the paa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaaDisplayByPixa/*"/>
'''  <param name="paa">[in] - with pix that may have different depths</param>
'''  <param name="xspace">[in] - between pix in pixa</param>
'''  <param name="yspace">[in] - between pixa</param>
'''  <param name="maxw">[in] - max width of output pix</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixaaDisplayByPixa(
				 ByVal paa as Pixaa, 
				 ByVal xspace as Integer, 
				 ByVal yspace as Integer, 
				 ByVal maxw as Integer) as Pix

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaDisplayByPixa( paa.Pointer, xspace, yspace, maxw)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixafunc2.c (1711, 1)
' pixaaDisplayTiledAndScaled(paa, outdepth, tilewidth, ncols, background, spacing, border) as Pixa
' pixaaDisplayTiledAndScaled(PIXAA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each pixa, this generates from all the pix a<para/>
''' tiled/scaled output pix, and puts it in the output pixa.<para/>
''' (2) See comments in pixaDisplayTiledAndScaled().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaaDisplayTiledAndScaled/*"/>
'''  <param name="paa">[in] - </param>
'''  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
'''  <param name="tilewidth">[in] - each pix is scaled to this width</param>
'''  <param name="ncols">[in] - number of tiles in each row</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''   <returns>pixa of tiled images, one image for each pixa in the paa, or NULL on error</returns>
Public Shared Function pixaaDisplayTiledAndScaled(
				 ByVal paa as Pixaa, 
				 ByVal outdepth as Integer, 
				 ByVal tilewidth as Integer, 
				 ByVal ncols as Integer, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pixa

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaDisplayTiledAndScaled( paa.Pointer, outdepth, tilewidth, ncols, background, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (1761, 1)
' pixaConvertTo1(pixas, thresh) as Pixa
' pixaConvertTo1(PIXA *, l_int32) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConvertTo1/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="thresh">[in] - threshold for final binarization from 8 bpp gray</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaConvertTo1(
				 ByVal pixas as Pixa, 
				 ByVal thresh as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertTo1( pixas.Pointer, thresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (1802, 1)
' pixaConvertTo8(pixas, cmapflag) as Pixa
' pixaConvertTo8(PIXA *, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes for pixConvertTo8(), applied to each pix in pixas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConvertTo8/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="cmapflag">[in] - 1 to give pixd a colormap 0 otherwise</param>
'''   <returns>pixad each pix is 8 bpp, or NULL on error</returns>
Public Shared Function pixaConvertTo8(
				 ByVal pixas as Pixa, 
				 ByVal cmapflag as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertTo8( pixas.Pointer, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (1843, 1)
' pixaConvertTo8Colormap(pixas, dither) as Pixa
' pixaConvertTo8Colormap(PIXA *, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes for pixConvertTo8Colormap(), applied to each pix in pixas.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConvertTo8Colormap/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="dither">[in] - 1 to dither if necessary 0 otherwise</param>
'''   <returns>pixad each pix is 8 bpp, or NULL on error</returns>
Public Shared Function pixaConvertTo8Colormap(
				 ByVal pixas as Pixa, 
				 ByVal dither as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertTo8Colormap( pixas.Pointer, dither)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (1885, 1)
' pixaConvertTo32(pixas) as Pixa
' pixaConvertTo32(PIXA *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes for pixConvertTo32(), applied to each pix in pixas.<para/>
''' (2) This can be used to allow 1 bpp pix in a pixa to be displayed<para/>
''' with color.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConvertTo32/*"/>
'''  <param name="pixas">[in] - </param>
'''   <returns>pixad 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixaConvertTo32(
				 ByVal pixas as Pixa) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertTo32( pixas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (1938, 1)
' pixaConstrainedSelect(pixas, first, last, nmax, use_pairs, copyflag) as Pixa
' pixaConstrainedSelect(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in genConstrainedNumaInRange() for how selection<para/>
''' is made.<para/>
''' (2) This returns a selection of the pix in the input pixa.<para/>
''' (3) Use copyflag == L_COPY if you don't want changes in the pix<para/>
''' in the returned pixa to affect those in the input pixa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConstrainedSelect/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="first">[in] - first index to choose  is greater = 0</param>
'''  <param name="last">[in] - biggest possible index to reach use -1 to go to the end otherwise, last  is greater = first</param>
'''  <param name="nmax">[in] - maximum number of pix to select  is greater  0</param>
'''  <param name="use_pairs">[in] - 1 = select pairs of adjacent pix 0 = select individual pix</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>pixad if OK, NULL on error</returns>
Public Shared Function pixaConstrainedSelect(
				 ByVal pixas as Pixa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				 ByVal nmax as Integer, 
				 ByVal use_pairs as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConstrainedSelect( pixas.Pointer, first, last, nmax, use_pairs, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (2006, 1)
' pixaSelectToPdf(pixas, first, last, res, scalefactor, type, quality, color, fontsize, fileout) as Integer
' pixaSelectToPdf(PIXA *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_uint32, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes a pdf of the selected images from %pixas, one to<para/>
''' a page.  They are optionally scaled and annotated with the<para/>
''' index printed to the left of the image.<para/>
''' (2) If the input images are 1 bpp and you want the numbers to be<para/>
''' in color, first promote each pix to 8 bpp with a colormap:<para/>
''' pixa1 = pixaConvertTo8(pixas, 1)<para/>
''' and then call this function with the specified color<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaSelectToPdf/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="first">[in] - first index to choose  is greater = 0</param>
'''  <param name="last">[in] - biggest possible index to reach use -1 to go to the end otherwise, last  is greater = first</param>
'''  <param name="res">[in] - override the resolution of each input image, in ppi use 0 to respect the resolution embedded in the input</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
'''  <param name="color">[in] - of numbers added to each image (e.g., 0xff000000)</param>
'''  <param name="fontsize">[in] - to print number below each image.  The valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSelectToPdf(
				 ByVal pixas as Pixa, 
				 ByVal first as Integer, 
				 ByVal last as Integer, 
				 ByVal res as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal type as Enumerations.L_ENCODE, 
				 ByVal quality as Integer, 
				 ByVal color as UInteger, 
				 ByVal fontsize as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSelectToPdf( pixas.Pointer, first, last, res, scalefactor, type, quality, color, fontsize, fileout)

	Return _Result
End Function

' SRC\pixafunc2.c (2086, 1)
' pixaDisplayMultiTiled(pixas, nx, ny, maxw, maxh, scalefactor, spacing, border) as Pixa
' pixaDisplayMultiTiled(PIXA *, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Each set of %nx  %ny images is optionally scaled and saved<para/>
''' into a new pix, and then aggregated.<para/>
''' (2) Set %maxw = %maxh = 0 if you want to include all pix from %pixs.<para/>
''' (3) This is useful for generating a pdf from the output pixa, where<para/>
''' each page is a tile of (%nx  %ny) images from the input pixa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaDisplayMultiTiled/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="maxw">[in] - max sizes to keep</param>
'''  <param name="maxh">[in] - max sizes to keep</param>
'''  <param name="scalefactor">[in] - scale each image by this</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''   <returns>pixad if OK, NULL on error</returns>
Public Shared Function pixaDisplayMultiTiled(
				 ByVal pixas as Pixa, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal maxw as Integer, 
				 ByVal maxh as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaDisplayMultiTiled( pixas.Pointer, nx, ny, maxw, maxh, scalefactor, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (2165, 1)
' pixaSplitIntoFiles(pixas, nsplit, scale, outwidth, write_pixa, write_pix, write_pdf) as Integer
' pixaSplitIntoFiles(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each requested output, %nsplit files are written into<para/>
''' directory /tmp/lept/split/.<para/>
''' (2) This is useful when a pixa is so large that the images<para/>
''' are not conveniently displayed as a single tiled image at<para/>
''' full resolution.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaSplitIntoFiles/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="nsplit">[in] - split pixas into this number of pixa  is greater = 2</param>
'''  <param name="scale">[in] - scalefactor applied to each pix</param>
'''  <param name="outwidth">[in] - the maxwidth parameter of tiled images for write_pix</param>
'''  <param name="write_pixa">[in] - 1 to write the split pixa as separate files</param>
'''  <param name="write_pix">[in] - 1 to write tiled images of the split pixa</param>
'''  <param name="write_pdf">[in] - 1 to write pdfs of the split pixa</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSplitIntoFiles(
				 ByVal pixas as Pixa, 
				 ByVal nsplit as Integer, 
				 ByVal scale as Single, 
				 ByVal outwidth as Integer, 
				 ByVal write_pixa as Integer, 
				 ByVal write_pix as Integer, 
				 ByVal write_pdf as Integer) as Integer

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSplitIntoFiles( pixas.Pointer, nsplit, scale, outwidth, write_pixa, write_pix, write_pdf)

	Return _Result
End Function

' SRC\pixafunc2.c (2254, 1)
' convertToNUpFiles(dir, substr, nx, ny, tw, spacing, border, fontsize, outdir) as Integer
' convertToNUpFiles(const char *, const char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Each set of %nx  %ny images is scaled and tiled into a single<para/>
''' image, that is written out to %outdir.<para/>
''' (2) All images in each %nx  %ny set are scaled to the same<para/>
''' width, %tw.  This is typically used when all images are<para/>
''' roughly the same size.<para/>
''' (3) This is useful for generating a pdf from the set of input<para/>
''' files, where each page is a tile of (%nx  %ny) input images.<para/>
''' Typical values for %nx and %ny are in the range [2 ... 5].<para/>
''' (4) If %fontsize != 0, each image has the tail of its filename<para/>
''' rendered below it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/convertToNUpFiles/*"/>
'''  <param name="dir">[in] - full path to directory of images</param>
'''  <param name="substr">[in][optional] - can be null</param>
'''  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="tw">[in] - target width, in pixels must be  is greater = 20</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''  <param name="fontsize">[in] - to print tail of filename with image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''  <param name="outdir">[in] - subdirectory of /tmp to put N-up tiled images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertToNUpFiles(
				 ByVal dir as String, 
				 ByVal substr as String, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal tw as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer, 
				 ByVal outdir as String) as Integer

	If IsNothing (dir) then Throw New ArgumentNullException  ("dir cannot be Nothing")
	If IsNothing (outdir) then Throw New ArgumentNullException  ("outdir cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.convertToNUpFiles( dir, substr, nx, ny, tw, spacing, border, fontsize, outdir)

	Return _Result
End Function

' SRC\pixafunc2.c (2316, 1)
' convertToNUpPixa(dir, substr, nx, ny, tw, spacing, border, fontsize) as Pixa
' convertToNUpPixa(const char *, const char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes for convertToNUpFiles()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/convertToNUpPixa/*"/>
'''  <param name="dir">[in] - full path to directory of images</param>
'''  <param name="substr">[in][optional] - can be null</param>
'''  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="tw">[in] - target width, in pixels must be  is greater = 20</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''  <param name="fontsize">[in] - to print tail of filename with image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function convertToNUpPixa(
				 ByVal dir as String, 
				 ByVal substr as String, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal tw as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer) as Pixa

	If IsNothing (dir) then Throw New ArgumentNullException  ("dir cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.convertToNUpPixa( dir, substr, nx, ny, tw, spacing, border, fontsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (2382, 1)
' pixaConvertToNUpPixa(pixas, sa, nx, ny, tw, spacing, border, fontsize) as Pixa
' pixaConvertToNUpPixa(PIXA *, SARRAY *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This takes an input pixa and an optional array of strings, and<para/>
''' generates a pixa of NUp tiles from the input, labeled with<para/>
''' the strings if they exist and %fontsize != 0.<para/>
''' (2) See notes for convertToNUpFiles()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaConvertToNUpPixa/*"/>
'''  <param name="pixas">[in] - </param>
'''  <param name="sa">[in][optional] - array of strings associated with each pix</param>
'''  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
'''  <param name="tw">[in] - target width, in pixels must be  is greater = 20</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''  <param name="fontsize">[in] - to print string with each image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaConvertToNUpPixa(
				 ByVal pixas as Pixa, 
				 ByVal sa as Sarray, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal tw as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")

	Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaConvertToNUpPixa( pixas.Pointer, saPTR, nx, ny, tw, spacing, border, fontsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixafunc2.c (2495, 1)
' pixaCompareInPdf(pixa1, pixa2, nx, ny, tw, spacing, border, fontsize, fileout) as Integer
' pixaCompareInPdf(PIXA *, PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This takes two pixa and renders them interleaved, side-by-side<para/>
''' in a pdf.  A warning is issued if the input pixa arrays<para/>
''' have different lengths.<para/>
''' (2) %nx and %ny specify how many side-by-side pairs are displayed<para/>
''' on each pdf page.  For example, if %nx = 1 and %ny = 2, then<para/>
''' two pairs are shown, one above the other, on each page.<para/>
''' (3) The input pix are scaled to a target width of %tw, and<para/>
''' then paired with optional %spacing between and optional<para/>
''' black border of width %border.<para/>
''' (4) After a pixa is generated of these tiled images, it is<para/>
''' written to %fileout as a pdf.<para/>
''' (5) Typical numbers for the input parameters are:<para/>
''' %nx = small integer (1 - 4)<para/>
''' %ny = 2  %nx<para/>
''' %tw = 200 - 500 pixels<para/>
''' %spacing = 10<para/>
''' %border = 2<para/>
''' %fontsize = 10<para/>
''' (6) If %fontsize != 0, the index of the pix pair in their pixa<para/>
''' is printed out below each pair.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaCompareInPdf/*"/>
'''  <param name="pixa1">[in] - </param>
'''  <param name="pixa2">[in] - </param>
'''  <param name="nx">[in] - in [1, ... 20], tiling factors in each direction</param>
'''  <param name="ny">[in] - in [1, ... 20], tiling factors in each direction</param>
'''  <param name="tw">[in] - target width, in pixels must be  is greater = 20</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image and on each pair use 0 for no border</param>
'''  <param name="fontsize">[in] - to print index of each pair of images.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
'''  <param name="fileout">[in] - output pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaCompareInPdf(
				 ByVal pixa1 as Pixa, 
				 ByVal pixa2 as Pixa, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal tw as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer, 
				 ByVal fontsize as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (pixa1) then Throw New ArgumentNullException  ("pixa1 cannot be Nothing")
	If IsNothing (pixa2) then Throw New ArgumentNullException  ("pixa2 cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaCompareInPdf( pixa1.Pointer, pixa2.Pointer, nx, ny, tw, spacing, border, fontsize, fileout)

	Return _Result
End Function

End Class
