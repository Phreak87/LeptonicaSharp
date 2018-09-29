Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\colormap.c (110, 1)
' pixcmapCreate()
' pixcmapCreate(l_int32) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="depth">[in] - bpp, of pix</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreate(
				ByVal depth as Integer) as PixColormap



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapCreate( depth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (157, 1)
' pixcmapCreateRandom()
' pixcmapCreateRandom(l_int32, l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) This sets up a colormap with random colors,
''' where the first color is optionally black, the last color
''' is optionally white, and the remaining colors are
''' chosen randomly.
''' (2) The number of randomly chosen colors is
''' 2^(depth) - haswhite - hasblack
''' (3) Because rand() is seeded, it might disrupt otherwise
''' deterministic results if also used elsewhere in a program.
''' (4) rand() is not threadsafe, and will generate garbage if run
''' on multiple threads at once -- though garbage is generally
''' what you want from a random number generator!
''' (5) Modern rand()s have equal randomness in low and high order
''' bits, but older ones don't.  Here, we're just using rand()
''' to choose colors for output.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="depth">[in] - bpp, of pix; 2, 4 or 8</param>
'''  <param name="hasblack">[in] - 1 if the first color is black; 0 if no black</param>
'''  <param name="haswhite">[in] - 1 if the last color is white; 0 if no white</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreateRandom(
				ByVal depth as Integer, 
				ByVal hasblack as Integer, 
				ByVal haswhite as Integer) as PixColormap



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapCreateRandom( depth, hasblack, haswhite)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (203, 1)
' pixcmapCreateLinear()
' pixcmapCreateLinear(l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) Colormap has equally spaced gray color values
''' from black (0, 0, 0) to white (255, 255, 255).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="d">[in] - depth of pix for this colormap; 1, 2, 4 or 8</param>
'''  <param name="nlevels">[in] - valid in range [2, 2^d]</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreateLinear(
				ByVal d as Integer, 
				ByVal nlevels as Integer) as PixColormap



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapCreateLinear( d, nlevels)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (233, 1)
' pixcmapCopy()
' pixcmapCopy(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmaps">[in] - </param>
'''   <returns>cmapd, or NULL on error</returns>
Public Shared Function pixcmapCopy(
				ByVal cmaps as PixColormap) as PixColormap

	If IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapCopy( cmaps.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (263, 1)
' pixcmapDestroy()
' pixcmapDestroy(PIXCMAP **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pcmap">[in,out] - set to null</param>
Public Shared Sub pixcmapDestroy(
				ByRef pcmap as PixColormap)


	Dim pcmapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pcmap) Then pcmapPTR = pcmap.Pointer

	LeptonicaSharp.Natives.pixcmapDestroy( pcmapPTR)
	if pcmapPTR <> IntPtr.Zero then pcmap = new PixColormap(pcmapPTR)

End Sub

' SRC\colormap.c (299, 1)
' pixcmapAddColor()
' pixcmapAddColor(PIXCMAP *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This always adds the color if there is room.
''' (2) The alpha component is 255 (opaque)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapAddColor( cmap.Pointer, rval, gval, bval)

	Return _Result
End Function

' SRC\colormap.c (337, 1)
' pixcmapAddRGBA()
' pixcmapAddRGBA(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This always adds the color if there is room.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="aval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddRGBA(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal aval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapAddRGBA( cmap.Pointer, rval, gval, bval, aval)

	Return _Result
End Function

' SRC\colormap.c (381, 1)
' pixcmapAddNewColor()
' pixcmapAddNewColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This only adds color if not already there.
''' (2) The alpha component is 255 (opaque)
''' (3) This returns the index of the new (or existing) color.
''' (4) Returns 2 with a warning if unable to add this color;
''' the caller should check the return value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - index of color</param>
'''   <returns>0 if OK, 1 on error; 2 if unable to add color</returns>
Public Shared Function pixcmapAddNewColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapAddNewColor( cmap.Pointer, rval, gval, bval, pindex)

	Return _Result
End Function

' SRC\colormap.c (430, 1)
' pixcmapAddNearestColor()
' pixcmapAddNearestColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This only adds color if not already there.
''' (2) The alpha component is 255 (opaque)
''' (3) If it's not in the colormap and there is no room to add
''' another color, this returns the index of the nearest color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - index of color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddNearestColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapAddNearestColor( cmap.Pointer, rval, gval, bval, pindex)

	Return _Result
End Function

' SRC\colormap.c (477, 1)
' pixcmapUsableColor()
' pixcmapUsableColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This checks if the color already exists or if there is
''' room to add it.  It makes no change in the colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added; each number is in range [0, ... 255]</param>
'''  <param name="pusable">[out] - 1 if usable; 0 if not</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapUsableColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pusable as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapUsableColor( cmap.Pointer, rval, gval, bval, pusable)

	Return _Result
End Function

' SRC\colormap.c (524, 1)
' pixcmapAddBlackOrWhite()
' pixcmapAddBlackOrWhite(PIXCMAP *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This only adds color if not already there.
''' (2) The alpha component is 255 (opaque)
''' (3) This sets index to the requested color.
''' (4) If there is no room in the colormap, returns the index
''' of the closest color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="color">[in] - 0 for black, 1 for white</param>
'''  <param name="pindex">[out][optional] - index of color; can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddBlackOrWhite(
				ByVal cmap as PixColormap, 
				ByVal color as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapAddBlackOrWhite( cmap.Pointer, color, pindex)

	Return _Result
End Function

' SRC\colormap.c (563, 1)
' pixcmapSetBlackAndWhite()
' pixcmapSetBlackAndWhite(PIXCMAP *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="setblack">[in] - 0 for no operation; 1 to set darkest color to black</param>
'''  <param name="setwhite">[in] - 0 for no operation; 1 to set lightest color to white</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapSetBlackAndWhite(
				ByVal cmap as PixColormap, 
				ByVal setblack as Integer, 
				ByVal setwhite as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapSetBlackAndWhite( cmap.Pointer, setblack, setwhite)

	Return _Result
End Function

' SRC\colormap.c (593, 1)
' pixcmapGetCount()
' pixcmapGetCount(PIXCMAP *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function pixcmapGetCount(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetCount( cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (610, 1)
' pixcmapGetFreeCount()
' pixcmapGetFreeCount(PIXCMAP *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''   <returns>free entries, or 0 on error</returns>
Public Shared Function pixcmapGetFreeCount(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetFreeCount( cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (627, 1)
' pixcmapGetDepth()
' pixcmapGetDepth(PIXCMAP *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''   <returns>depth, or 0 on error</returns>
Public Shared Function pixcmapGetDepth(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetDepth( cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (650, 1)
' pixcmapGetMinDepth()
' pixcmapGetMinDepth(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) On error, mindepth is returned as 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="pmindepth">[out] - minimum depth to support the colormap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetMinDepth(
				ByVal cmap as PixColormap, 
				ByRef pmindepth as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetMinDepth( cmap.Pointer, pmindepth)

	Return _Result
End Function

' SRC\colormap.c (686, 1)
' pixcmapClear()
' pixcmapClear(PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' (1) This removes the colors by setting the count to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapClear(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapClear( cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (709, 1)
' pixcmapGetColor()
' pixcmapGetColor(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="prval">[out] - each color value</param>
'''  <param name="pgval">[out] - each color value</param>
'''  <param name="pbval">[out] - each color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetColor(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetColor( cmap.Pointer, index, prval, pgval, pbval)

	Return _Result
End Function

' SRC\colormap.c (749, 1)
' pixcmapGetColor32()
' pixcmapGetColor32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The returned alpha channel value is 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="pval32">[out] - 32-bit rgb color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetColor32(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByRef pval32 as UInteger) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetColor32( cmap.Pointer, index, pval32)

	Return _Result
End Function

' SRC\colormap.c (777, 1)
' pixcmapGetRGBA()
' pixcmapGetRGBA(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="prval">[out] - each color value</param>
'''  <param name="pgval">[out] - each color value</param>
'''  <param name="pbval">[out] - each color value</param>
'''  <param name="paval">[out] - each color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetRGBA(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer, 
				ByRef paval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetRGBA( cmap.Pointer, index, prval, pgval, pbval, paval)

	Return _Result
End Function

' SRC\colormap.c (815, 1)
' pixcmapGetRGBA32()
' pixcmapGetRGBA32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="pval32">[out] - 32-bit rgba color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetRGBA32(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByRef pval32 as UInteger) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetRGBA32( cmap.Pointer, index, pval32)

	Return _Result
End Function

' SRC\colormap.c (851, 1)
' pixcmapResetColor()
' pixcmapResetColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This resets sets the color of an entry that has already
''' been set and included in the count of colors.
''' (2) The alpha component is 255 (opaque)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be reset; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be reset; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be reset; each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapResetColor(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapResetColor( cmap.Pointer, index, rval, gval, bval)

	Return _Result
End Function

' SRC\colormap.c (892, 1)
' pixcmapSetAlpha()
' pixcmapSetAlpha(PIXCMAP *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This modifies the transparency of one entry in a colormap.
''' The alpha component by default is 255 (opaque).
''' This is used when extracting the colormap from a PNG file
''' without decoding the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="aval">[in] - in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapSetAlpha(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByVal aval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapSetAlpha( cmap.Pointer, index, aval)

	Return _Result
End Function

' SRC\colormap.c (921, 1)
' pixcmapGetIndex()
' pixcmapGetIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - found index</param>
'''   <returns>0 if found, 1 if not found caller must check</returns>
Public Shared Function pixcmapGetIndex(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetIndex( cmap.Pointer, rval, gval, bval, pindex)

	Return _Result
End Function

' SRC\colormap.c (960, 1)
' pixcmapHasColor()
' pixcmapHasColor(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="pcolor">[out] - TRUE if cmap has color; FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapHasColor(
				ByVal cmap as PixColormap, 
				ByRef pcolor as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapHasColor( cmap.Pointer, pcolor)

	Return _Result
End Function

' SRC\colormap.c (999, 1)
' pixcmapIsOpaque()
' pixcmapIsOpaque(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="popaque">[out] - TRUE if fully opaque all entries are 255</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapIsOpaque(
				ByVal cmap as PixColormap, 
				ByRef popaque as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapIsOpaque( cmap.Pointer, popaque)

	Return _Result
End Function

' SRC\colormap.c (1034, 1)
' pixcmapIsBlackAndWhite()
' pixcmapIsBlackAndWhite(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="pblackwhite">[out] - TRUE if the cmap has only two colors black (0,0,0) and white (255,255,255)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapIsBlackAndWhite(
				ByVal cmap as PixColormap, 
				ByRef pblackwhite as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapIsBlackAndWhite( cmap.Pointer, pblackwhite)

	Return _Result
End Function

' SRC\colormap.c (1075, 1)
' pixcmapCountGrayColors()
' pixcmapCountGrayColors(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This counts the unique gray colors, including black and white.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="pngray">[out] - number of gray colors</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapCountGrayColors(
				ByVal cmap as PixColormap, 
				ByRef pngray as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapCountGrayColors( cmap.Pointer, pngray)

	Return _Result
End Function

' SRC\colormap.c (1116, 1)
' pixcmapGetRankIntensity()
' pixcmapGetRankIntensity(PIXCMAP *, l_float32, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rankval">[in] - 0.0 for darkest, 1.0 for lightest color</param>
'''  <param name="pindex">[out] - the index into the colormap that corresponds to the rank intensity color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetRankIntensity(
				ByVal cmap as PixColormap, 
				ByVal rankval as Single, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	If IsNothing (rankval) then Throw New ArgumentNullException  ("rankval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetRankIntensity( cmap.Pointer, rankval, pindex)

	Return _Result
End Function

' SRC\colormap.c (1167, 1)
' pixcmapGetNearestIndex()
' pixcmapGetNearestIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) Returns the index of the exact color if possible, otherwise the
''' index of the color closest to the target color.
''' (2) Nearest color is that which is the least sum-of-squares distance
''' from the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap colors to search for; each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - the index of the nearest color</param>
'''   <returns>0 if OK, 1 on error caller must check</returns>
Public Shared Function pixcmapGetNearestIndex(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetNearestIndex( cmap.Pointer, rval, gval, bval, pindex)

	Return _Result
End Function

' SRC\colormap.c (1225, 1)
' pixcmapGetNearestGrayIndex()
' pixcmapGetNearestGrayIndex(PIXCMAP *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This should be used on gray colormaps.  It uses only the
''' green value of the colormap.
''' (2) Returns the index of the exact color if possible, otherwise the
''' index of the color closest to the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="val">[in] - gray value to search for; in range [0, ... 255]</param>
'''  <param name="pindex">[out] - the index of the nearest color</param>
'''   <returns>0 if OK, 1 on error caller must check</returns>
Public Shared Function pixcmapGetNearestGrayIndex(
				ByVal cmap as PixColormap, 
				ByVal val as Integer, 
				ByRef pindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetNearestGrayIndex( cmap.Pointer, val, pindex)

	Return _Result
End Function

' SRC\colormap.c (1278, 1)
' pixcmapGetDistanceToColor()
' pixcmapGetDistanceToColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) Returns the L2 distance (squared) between the color at index i
''' and the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="rval">[in] - target color</param>
'''  <param name="gval">[in] - target color</param>
'''  <param name="bval">[in] - target color</param>
'''  <param name="pdist">[out] - the distance from the cmap entry to target</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetDistanceToColor(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pdist as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetDistanceToColor( cmap.Pointer, index, rval, gval, bval, pdist)

	Return _Result
End Function

' SRC\colormap.c (1334, 1)
' pixcmapGetRangeValues()
' pixcmapGetRangeValues(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) Returns, for selected components (or the average), the
''' the extreme values (min and/or max) and their indices
''' that are found in the cmap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - </param>
'''  <param name="pminval">[out][optional] - minimum value of component</param>
'''  <param name="pmaxval">[out][optional] - maximum value of component</param>
'''  <param name="pminindex">[out][optional] - index of minimum value</param>
'''  <param name="pmaxindex">[out][optional] - index of maximum value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetRangeValues(
				ByVal cmap as PixColormap, 
				ByRef _select_ as Integer, 
				ByRef pminval as Integer, 
				ByRef pmaxval as Integer, 
				ByRef pminindex as Integer, 
				ByRef pmaxindex as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGetRangeValues( cmap.Pointer, _select_, pminval, pmaxval, pminindex, pmaxindex)

	Return _Result
End Function

' SRC\colormap.c (1430, 1)
' pixcmapGrayToColor()
' pixcmapGrayToColor(l_uint32) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) This creates a colormap that maps from gray to
''' a specific color.  In the mapping, each component
''' is faded to white, depending on the gray value.
''' (2) In use, this is simply attached to a grayscale pix
''' to give it the input color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="color">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapGrayToColor(
				ByVal color as UInteger) as PixColormap



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapGrayToColor( color)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1462, 1)
' pixcmapColorToGray()
' pixcmapColorToGray(PIXCMAP *, l_float32, l_float32, l_float32) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) This creates a gray colormap from an arbitrary colormap.
''' (2) In use, attach the output gray colormap to the pix
''' (or a copy of it) that provided the input colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmaps">[in] - </param>
'''  <param name="rwt">[in] - non-negative; these should add to 1.0</param>
'''  <param name="gwt">[in] - non-negative; these should add to 1.0</param>
'''  <param name="bwt">[in] - non-negative; these should add to 1.0</param>
'''   <returns>cmap gray, or NULL on error</returns>
Public Shared Function pixcmapColorToGray(
				ByVal cmaps as PixColormap, 
				ByVal rwt as Single, 
				ByVal gwt as Single, 
				ByVal bwt as Single) as PixColormap

	If IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")
	If IsNothing (rwt) then Throw New ArgumentNullException  ("rwt cannot be Nothing")
	If IsNothing (gwt) then Throw New ArgumentNullException  ("gwt cannot be Nothing")
	If IsNothing (bwt) then Throw New ArgumentNullException  ("bwt cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapColorToGray( cmaps.Pointer, rwt, gwt, bwt)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1518, 1)
' pixcmapConvertTo4()
' pixcmapConvertTo4(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) This converts a 2 bpp colormap to 4 bpp.  The colors
''' are the same; the output colormap entry array has size 16.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmaps">[in] - colormap for 2 bpp pix</param>
'''   <returns>cmapd   (4 bpp)</returns>
Public Shared Function pixcmapConvertTo4(
				ByVal cmaps as PixColormap) as PixColormap

	If IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapConvertTo4( cmaps.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1553, 1)
' pixcmapConvertTo8()
' pixcmapConvertTo8(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' Notes
''' (1) This converts a 2 bpp or 4 bpp colormap to 8 bpp.  The colors
''' are the same; the output colormap entry array has size 256.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmaps">[in] - colormap for 2 bpp or 4 bpp pix</param>
'''   <returns>cmapd   (8 bpp)</returns>
Public Shared Function pixcmapConvertTo8(
				ByVal cmaps as PixColormap) as PixColormap

	If IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapConvertTo8( cmaps.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1587, 1)
' pixcmapRead()
' pixcmapRead(const char *) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapRead(
				ByVal filename as String) as PixColormap

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1614, 1)
' pixcmapReadStream()
' pixcmapReadStream(FILE *) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapReadStream(
				ByVal fp as FILE) as PixColormap

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1655, 1)
' pixcmapReadMem()
' pixcmapReadMem(const l_uint8 *, size_t) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of pixcmap; in ascii</param>
'''  <param name="size">[in] - of data in bytes; can use strlen to get it</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as PixColormap

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (1683, 1)
' pixcmapWrite()
' pixcmapWrite(const char *, PIXCMAP *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWrite(
				ByVal filename as String, 
				ByVal cmap as PixColormap) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapWrite( filename, cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (1715, 1)
' pixcmapWriteStream()
' pixcmapWriteStream(FILE *, PIXCMAP *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream    \param[in]    cmap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWriteStream(
				ByVal fp as FILE, 
				ByRef cmap as PixColormap) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

Dim cmapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(cmap) Then cmapPTR = cmap.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapWriteStream( fp.Pointer, cmap.Pointer)

	Return _Result
End Function

' SRC\colormap.c (1761, 1)
' pixcmapWriteMem()
' pixcmapWriteMem(l_uint8 **, size_t *, PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a pixcmap in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized pixcmap; ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapWriteMem( pdataPTR, psize, cmap.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\colormap.c (1813, 1)
' pixcmapToArrays()
' pixcmapToArrays(PIXCMAP *, l_int32 **, l_int32 **, l_int32 **, l_int32 **) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="prmap">[out] - colormap arrays</param>
'''  <param name="pgmap">[out] - colormap arrays</param>
'''  <param name="pbmap">[out] - colormap arrays</param>
'''  <param name="pamap">[out][optional] - alpha array</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapToArrays(
				ByVal cmap as PixColormap, 
				ByRef prmap as List (of Integer()), 
				ByRef pgmap as List (of Integer()), 
				ByRef pbmap as List (of Integer()), 
				ByRef pamap as List (of Integer())) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

Dim prmapPTR As IntPtr = Marshal.AllocHGlobal(0)
Dim pgmapPTR As IntPtr = Marshal.AllocHGlobal(0)
Dim pbmapPTR As IntPtr = Marshal.AllocHGlobal(0)
Dim pamapPTR As IntPtr = IntPtr.Zero: if not isNothing (pamap) then pamapPTR = Marshal.AllocHGlobal(Marshal.SizeOf(pamap.toarray))

	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapToArrays( cmap.Pointer, prmapPTR, pgmapPTR, pbmapPTR, pamapPTR)

	Return _Result
End Function

' SRC\colormap.c (1867, 1)
' pixcmapToRGBTable()
' pixcmapToRGBTable(PIXCMAP *, l_uint32 **, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="ptab">[out] - table of rgba values for the colormap</param>
'''  <param name="pncolors">[out][optional] - size of table</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapToRGBTable(
				ByVal cmap as PixColormap, 
				ByRef ptab as Byte(), 
				ByRef pncolors as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	Dim ptabPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapToRGBTable( cmap.Pointer, ptabPTR, pncolors)
	ReDim ptab(IIf(1 > 0, 1, 1) - 1) : If ptabPTR <> IntPtr.Zero Then Marshal.Copy(ptabPTR, ptab, 0, ptab.count)

	Return _Result
End Function

' SRC\colormap.c (1912, 1)
' pixcmapSerializeToMemory()
' pixcmapSerializeToMemory(PIXCMAP *, l_int32, l_int32 *, l_uint8 **) as l_ok
'''  <summary>
''' Notes
''' (1) When serializing to store in a pdf, use %cpc = 3.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="cpc">[in] - components/color 3 for rgb, 4 for rgba</param>
'''  <param name="pncolors">[out] - number of colors in table</param>
'''  <param name="pdata">[out] - binary string, cpc bytes per color</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapSerializeToMemory(
				ByVal cmap as PixColormap, 
				ByVal cpc as Integer, 
				ByRef pncolors as Integer, 
				ByRef pdata as Byte()) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapSerializeToMemory( cmap.Pointer, cpc, pncolors, pdataPTR)
	ReDim pdata(IIf(1 > 0, 1, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\colormap.c (1960, 1)
' pixcmapDeserializeFromMemory()
' pixcmapDeserializeFromMemory(l_uint8 *, l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - binary string, 3 or 4 bytes per color</param>
'''  <param name="cpc">[in] - components/color 3 for rgb, 4 for rgba</param>
'''  <param name="ncolors">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapDeserializeFromMemory(
				ByVal data as Byte(), 
				ByVal cpc as Integer, 
				ByVal ncolors as Integer) as PixColormap

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcmapDeserializeFromMemory( data, cpc, ncolors)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixColormap(_Result)
End Function

' SRC\colormap.c (2021, 1)
' pixcmapConvertToHex()
' pixcmapConvertToHex(l_uint8 *, l_int32) as char *
'''  <summary>
''' Notes
''' (1) The number of bytes in %data is 3  ncolors.
''' (2) Output is in form
''' LT r0g0b0 r1g1b1 ... rngnbn GT
''' where r0, g0, b0 ... are each 2 bytes of hex ascii
''' (3) This is used in pdf files to express the colormap as an
''' array in ascii (human-readable) format.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - binary serialized data</param>
'''  <param name="ncolors">[in] - in colormap</param>
'''   <returns>hexdata bracketed, space-separated ascii hex string, or NULL on error.</returns>
Public Shared Function pixcmapConvertToHex(
				ByVal data as Byte(), 
				ByVal ncolors as Integer) as String

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.pixcmapConvertToHex( data, ncolors)

	Return _Result
End Function

' SRC\colormap.c (2079, 1)
' pixcmapGammaTRC()
' pixcmapGammaTRC(PIXCMAP *, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place transform
''' (2) See pixGammaTRC() and numaGammaTRC() in enhance.c
''' for description and use of transform
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="gamma">[in] - gamma correction; must be GT 0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output; can be LT 0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output; can be GT 255</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapGammaTRC(
				ByVal cmap as PixColormap, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapGammaTRC( cmap.Pointer, gamma, minval, maxval)

	Return _Result
End Function

' SRC\colormap.c (2134, 1)
' pixcmapContrastTRC()
' pixcmapContrastTRC(PIXCMAP *, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place transform
''' (2) See pixContrastTRC() and numaContrastTRC() in enhance.c
''' for description and use of transform
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="factor">[in] - generally between 0.0 [no enhancement] and 1.0, but can be larger than 1.0</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapContrastTRC(
				ByVal cmap as PixColormap, 
				ByVal factor as Single) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	If IsNothing (factor) then Throw New ArgumentNullException  ("factor cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapContrastTRC( cmap.Pointer, factor)

	Return _Result
End Function

' SRC\colormap.c (2186, 1)
' pixcmapShiftIntensity()
' pixcmapShiftIntensity(PIXCMAP *, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place transform
''' (2) It does a proportional shift of the intensity for each color.
''' (3) If fraction LT 0.0, it moves all colors towards (0,0,0).
''' This darkens the image.
''' If fraction GT 0.0, it moves all colors towards (255,255,255)
''' This fades the image.
''' (4) The equivalent transform can be accomplished with pixcmapGammaTRC(),
''' but it is considerably more difficult (see numaGammaTRC()).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="fraction">[in] - between -1.0 and +1.0</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapShiftIntensity(
				ByVal cmap as PixColormap, 
				ByVal fraction as Single) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	If IsNothing (fraction) then Throw New ArgumentNullException  ("fraction cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapShiftIntensity( cmap.Pointer, fraction)

	Return _Result
End Function

' SRC\colormap.c (2236, 1)
' pixcmapShiftByComponent()
' pixcmapShiftByComponent(PIXCMAP *, l_uint32, l_uint32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place transform
''' (2) It implements pixelShiftByComponent() for each color.
''' The mapping is specified by srcval and dstval.
''' (3) If a component decreases, the component in the colormap
''' decreases by the same ratio.  Likewise for increasing, except
''' all ratios are taken with respect to the distance from 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="srcval">[in] - source color 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color 0xrrggbb00</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapShiftByComponent(
				ByVal cmap as PixColormap, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapShiftByComponent( cmap.Pointer, srcval, dstval)

	Return _Result
End Function

End Class
