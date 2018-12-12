Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' colormap.c (110, 1)
' pixcmapCreate(depth) as PixColormap
' pixcmapCreate(l_int32) as PIXCMAP *
'''  <summary>
''' pixcmapCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreate/*"/>
'''  <param name="depth">[in] - bpp, of pix</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreate(
				ByVal depth as Integer) as PixColormap


	Dim _Result as IntPtr = Natives.pixcmapCreate(  depth)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (157, 1)
' pixcmapCreateRandom(depth, hasblack, haswhite) as PixColormap
' pixcmapCreateRandom(l_int32, l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' (1) This sets up a colormap with random colors,
'''where the first color is optionally black, the last color
'''is optionally white, and the remaining colors are
'''chosen randomly.<para/>
'''
'''(2) The number of randomly chosen colors is:
'''2^(depth) - haswhite - hasblack<para/>
'''
'''(3) Because rand() is seeded, it might disrupt otherwise
'''deterministic results if also used elsewhere in a program.<para/>
'''
'''(4) rand() is not threadsafe, and will generate garbage if run
'''on multiple threads at once -- though garbage is generally
'''what you want from a random number generator!<para/>
'''
'''(5) Modern rand()s have equal randomness in low and high order
'''bits, but older ones don't.  Here, we're just using rand()
'''to choose colors for output.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreateRandom/*"/>
'''  <param name="depth">[in] - bpp, of pix 2, 4 or 8</param>
'''  <param name="hasblack">[in] - 1 if the first color is black 0 if no black</param>
'''  <param name="haswhite">[in] - 1 if the last color is white 0 if no white</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreateRandom(
				ByVal depth as Integer, 
				ByVal hasblack as Integer, 
				ByVal haswhite as Integer) as PixColormap


	Dim _Result as IntPtr = Natives.pixcmapCreateRandom(  depth,   hasblack,   haswhite)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (203, 1)
' pixcmapCreateLinear(d, nlevels) as PixColormap
' pixcmapCreateLinear(l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' (1) Colormap has equally spaced gray color values
'''from black (0, 0, 0) to white (255, 255, 255).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreateLinear/*"/>
'''  <param name="d">[in] - depth of pix for this colormap 1, 2, 4 or 8</param>
'''  <param name="nlevels">[in] - valid in range [2, 2^d]</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapCreateLinear(
				ByVal d as Integer, 
				ByVal nlevels as Integer) as PixColormap


	Dim _Result as IntPtr = Natives.pixcmapCreateLinear(  d,   nlevels)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (233, 1)
' pixcmapCopy(cmaps) as PixColormap
' pixcmapCopy(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' pixcmapCopy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCopy/*"/>
'''  <param name="cmaps">[in] - </param>
'''   <returns>cmapd, or NULL on error</returns>
Public Shared Function pixcmapCopy(
				ByVal cmaps as PixColormap) as PixColormap


if IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapCopy(cmaps.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (263, 1)
' pixcmapDestroy(pcmap) as Object
' pixcmapDestroy(PIXCMAP **) as void
'''  <summary>
''' pixcmapDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapDestroy/*"/>
'''  <param name="pcmap">[in,out] - set to null</param>
Public Shared Sub pixcmapDestroy(
				ByRef pcmap as PixColormap)


	Dim pcmapPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pcmap) Then pcmapPtr = pcmap.Pointer

	Natives.pixcmapDestroy( pcmapPtr)
	
	if pcmapPtr = IntPtr.Zero then pcmap = Nothing else pcmap = new PixColormap(pcmapPtr)
End Sub

' colormap.c (299, 1)
' pixcmapAddColor(cmap, rval, gval, bval) as Integer
' pixcmapAddColor(PIXCMAP *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This always adds the color if there is room.<para/>
'''
'''(2) The alpha component is 255 (opaque)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapAddColor(cmap.Pointer,   rval,   gval,   bval)
	
	return _Result
End Function

' colormap.c (337, 1)
' pixcmapAddRGBA(cmap, rval, gval, bval, aval) as Integer
' pixcmapAddRGBA(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This always adds the color if there is room.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddRGBA/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="aval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddRGBA(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByVal aval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapAddRGBA(cmap.Pointer,   rval,   gval,   bval,   aval)
	
	return _Result
End Function

' colormap.c (381, 1)
' pixcmapAddNewColor(cmap, rval, gval, bval, pindex) as Integer
' pixcmapAddNewColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This only adds color if not already there.<para/>
'''
'''(2) The alpha component is 255 (opaque)<para/>
'''
'''(3) This returns the index of the new (or existing) color.<para/>
'''
'''(4) Returns 2 with a warning if unable to add this color
'''the caller should check the return value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddNewColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - index of color</param>
'''   <returns>0 if OK, 1 on error 2 if unable to add color</returns>
Public Shared Function pixcmapAddNewColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapAddNewColor(cmap.Pointer,   rval,   gval,   bval,   pindex)
	
	return _Result
End Function

' colormap.c (430, 1)
' pixcmapAddNearestColor(cmap, rval, gval, bval, pindex) as Integer
' pixcmapAddNearestColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This only adds color if not already there.<para/>
'''
'''(2) The alpha component is 255 (opaque)<para/>
'''
'''(3) If it's not in the colormap and there is no room to add
'''another color, this returns the index of the nearest color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddNearestColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - index of color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddNearestColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapAddNearestColor(cmap.Pointer,   rval,   gval,   bval,   pindex)
	
	return _Result
End Function

' colormap.c (477, 1)
' pixcmapUsableColor(cmap, rval, gval, bval, pusable) as Integer
' pixcmapUsableColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This checks if the color already exists or if there is
'''room to add it.  It makes no change in the colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapUsableColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="pusable">[out] - 1 if usable 0 if not</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapUsableColor(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				<Out()>  ByRef pusable as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapUsableColor(cmap.Pointer,   rval,   gval,   bval,   pusable)
	
	return _Result
End Function

' colormap.c (524, 1)
' pixcmapAddBlackOrWhite(cmap, color, pindex) as Integer
' pixcmapAddBlackOrWhite(PIXCMAP *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This only adds color if not already there.<para/>
'''
'''(2) The alpha component is 255 (opaque)<para/>
'''
'''(3) This sets index to the requested color.<para/>
'''
'''(4) If there is no room in the colormap, returns the index
'''of the closest color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddBlackOrWhite/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="color">[in] - 0 for black, 1 for white</param>
'''  <param name="pindex">[out][optional] - index of color can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapAddBlackOrWhite(
				ByVal cmap as PixColormap, 
				ByVal color as Integer, 
				<Out()> Optional  ByRef pindex as Integer = 0) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapAddBlackOrWhite(cmap.Pointer,   color,   pindex)
	
	return _Result
End Function

' colormap.c (563, 1)
' pixcmapSetBlackAndWhite(cmap, setblack, setwhite) as Integer
' pixcmapSetBlackAndWhite(PIXCMAP *, l_int32, l_int32) as l_ok
'''  <summary>
''' pixcmapSetBlackAndWhite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSetBlackAndWhite/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="setblack">[in] - 0 for no operation 1 to set darkest color to black</param>
'''  <param name="setwhite">[in] - 0 for no operation 1 to set lightest color to white</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapSetBlackAndWhite(
				ByVal cmap as PixColormap, 
				ByVal setblack as Integer, 
				ByVal setwhite as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapSetBlackAndWhite(cmap.Pointer,   setblack,   setwhite)
	
	return _Result
End Function

' colormap.c (593, 1)
' pixcmapGetCount(cmap) as Integer
' pixcmapGetCount(PIXCMAP *) as l_int32
'''  <summary>
''' pixcmapGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetCount/*"/>
'''  <param name="cmap">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function pixcmapGetCount(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetCount(cmap.Pointer)
	
	return _Result
End Function

' colormap.c (610, 1)
' pixcmapGetFreeCount(cmap) as Integer
' pixcmapGetFreeCount(PIXCMAP *) as l_int32
'''  <summary>
''' pixcmapGetFreeCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetFreeCount/*"/>
'''  <param name="cmap">[in] - </param>
'''   <returns>free entries, or 0 on error</returns>
Public Shared Function pixcmapGetFreeCount(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetFreeCount(cmap.Pointer)
	
	return _Result
End Function

' colormap.c (627, 1)
' pixcmapGetDepth(cmap) as Integer
' pixcmapGetDepth(PIXCMAP *) as l_int32
'''  <summary>
''' pixcmapGetDepth()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetDepth/*"/>
'''  <param name="cmap">[in] - </param>
'''   <returns>depth, or 0 on error</returns>
Public Shared Function pixcmapGetDepth(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetDepth(cmap.Pointer)
	
	return _Result
End Function

' colormap.c (650, 1)
' pixcmapGetMinDepth(cmap, pmindepth) as Integer
' pixcmapGetMinDepth(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' (1) On error, [and]mindepth is returned as 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetMinDepth/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="pmindepth">[out] - minimum depth to support the colormap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetMinDepth(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef pmindepth as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetMinDepth(cmap.Pointer,   pmindepth)
	
	return _Result
End Function

' colormap.c (686, 1)
' pixcmapClear(cmap) as Integer
' pixcmapClear(PIXCMAP *) as l_ok
'''  <summary>
''' (1) This removes the colors by setting the count to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapClear/*"/>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapClear(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapClear(cmap.Pointer)
	
	return _Result
End Function

' colormap.c (709, 1)
' pixcmapGetColor(cmap, index, prval, pgval, pbval) as Integer
' pixcmapGetColor(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' pixcmapGetColor()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="prval">[out] - each color value</param>
'''  <param name="pgval">[out] - each color value</param>
'''  <param name="pbval">[out] - each color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetColor(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetColor(cmap.Pointer,   index,   prval,   pgval,   pbval)
	
	return _Result
End Function

' colormap.c (749, 1)
' pixcmapGetColor32(cmap, index, pval32) as Integer
' pixcmapGetColor32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' (1) The returned alpha channel value is 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetColor32/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="pval32">[out] - 32-bit rgb color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetColor32(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				<Out()>  ByRef pval32 as UInteger) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetColor32(cmap.Pointer,   index,   pval32)
	
	return _Result
End Function

' colormap.c (777, 1)
' pixcmapGetRGBA(cmap, index, prval, pgval, pbval, paval) as Integer
' pixcmapGetRGBA(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' pixcmapGetRGBA()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRGBA/*"/>
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
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer, 
				<Out()>  ByRef paval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetRGBA(cmap.Pointer,   index,   prval,   pgval,   pbval,   paval)
	
	return _Result
End Function

' colormap.c (815, 1)
' pixcmapGetRGBA32(cmap, index, pval32) as Integer
' pixcmapGetRGBA32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
'''  <summary>
''' pixcmapGetRGBA32()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRGBA32/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="pval32">[out] - 32-bit rgba color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapGetRGBA32(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				<Out()>  ByRef pval32 as UInteger) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetRGBA32(cmap.Pointer,   index,   pval32)
	
	return _Result
End Function

' colormap.c (851, 1)
' pixcmapResetColor(cmap, index, rval, gval, bval) as Integer
' pixcmapResetColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This resets sets the color of an entry that has already
'''been set and included in the count of colors.<para/>
'''
'''(2) The alpha component is 255 (opaque)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapResetColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="rval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Shared Function pixcmapResetColor(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapResetColor(cmap.Pointer,   index,   rval,   gval,   bval)
	
	return _Result
End Function

' colormap.c (892, 1)
' pixcmapSetAlpha(cmap, index, aval) as Integer
' pixcmapSetAlpha(PIXCMAP *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This modifies the transparency of one entry in a colormap.
'''The alpha component by default is 255 (opaque).
'''This is used when extracting the colormap from a PNG file
'''without decoding the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSetAlpha/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="index">[in] - </param>
'''  <param name="aval">[in] - in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapSetAlpha(
				ByVal cmap as PixColormap, 
				ByVal index as Integer, 
				ByVal aval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapSetAlpha(cmap.Pointer,   index,   aval)
	
	return _Result
End Function

' colormap.c (921, 1)
' pixcmapGetIndex(cmap, rval, gval, bval, pindex) as Integer
' pixcmapGetIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
'''  <summary>
''' pixcmapGetIndex()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetIndex/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - found index</param>
'''   <returns>0 if found, 1 if not found caller must check</returns>
Public Shared Function pixcmapGetIndex(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetIndex(cmap.Pointer,   rval,   gval,   bval,   pindex)
	
	return _Result
End Function

' colormap.c (960, 1)
' pixcmapHasColor(cmap, pcolor) as Integer
' pixcmapHasColor(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' pixcmapHasColor()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapHasColor/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="pcolor">[out] - TRUE if cmap has color FALSE otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapHasColor(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef pcolor as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapHasColor(cmap.Pointer,   pcolor)
	
	return _Result
End Function

' colormap.c (999, 1)
' pixcmapIsOpaque(cmap, popaque) as Integer
' pixcmapIsOpaque(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' pixcmapIsOpaque()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapIsOpaque/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="popaque">[out] - TRUE if fully opaque: all entries are 255</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapIsOpaque(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef popaque as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapIsOpaque(cmap.Pointer,   popaque)
	
	return _Result
End Function

' colormap.c (1034, 1)
' pixcmapIsBlackAndWhite(cmap, pblackwhite) as Integer
' pixcmapIsBlackAndWhite(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' pixcmapIsBlackAndWhite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapIsBlackAndWhite/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="pblackwhite">[out] - TRUE if the cmap has only two colors: black (0,0,0) and white (255,255,255)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapIsBlackAndWhite(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef pblackwhite as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapIsBlackAndWhite(cmap.Pointer,   pblackwhite)
	
	return _Result
End Function

' colormap.c (1075, 1)
' pixcmapCountGrayColors(cmap, pngray) as Integer
' pixcmapCountGrayColors(PIXCMAP *, l_int32 *) as l_ok
'''  <summary>
''' (1) This counts the unique gray colors, including black and white.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCountGrayColors/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="pngray">[out] - number of gray colors</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapCountGrayColors(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef pngray as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapCountGrayColors(cmap.Pointer,   pngray)
	
	return _Result
End Function

' colormap.c (1116, 1)
' pixcmapGetRankIntensity(cmap, rankval, pindex) as Integer
' pixcmapGetRankIntensity(PIXCMAP *, l_float32, l_int32 *) as l_ok
'''  <summary>
''' pixcmapGetRankIntensity()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRankIntensity/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rankval">[in] - 0.0 for darkest, 1.0 for lightest color</param>
'''  <param name="pindex">[out] - the index into the colormap that corresponds to the rank intensity color</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetRankIntensity(
				ByVal cmap as PixColormap, 
				ByVal rankval as Single, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetRankIntensity(cmap.Pointer,   rankval,   pindex)
	
	return _Result
End Function

' colormap.c (1167, 1)
' pixcmapGetNearestIndex(cmap, rval, gval, bval, pindex) as Integer
' pixcmapGetNearestIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) Returns the index of the exact color if possible, otherwise the
'''index of the color closest to the target color.<para/>
'''
'''(2) Nearest color is that which is the least sum-of-squares distance
'''from the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetNearestIndex/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="rval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
'''  <param name="pindex">[out] - the index of the nearest color</param>
'''   <returns>0 if OK, 1 on error caller must check</returns>
Public Shared Function pixcmapGetNearestIndex(
				ByVal cmap as PixColormap, 
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetNearestIndex(cmap.Pointer,   rval,   gval,   bval,   pindex)
	
	return _Result
End Function

' colormap.c (1225, 1)
' pixcmapGetNearestGrayIndex(cmap, val, pindex) as Integer
' pixcmapGetNearestGrayIndex(PIXCMAP *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This should be used on gray colormaps.  It uses only the
'''green value of the colormap.<para/>
'''
'''(2) Returns the index of the exact color if possible, otherwise the
'''index of the color closest to the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetNearestGrayIndex/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="val">[in] - gray value to search for in range [0, ... 255]</param>
'''  <param name="pindex">[out] - the index of the nearest color</param>
'''   <returns>0 if OK, 1 on error caller must check</returns>
Public Shared Function pixcmapGetNearestGrayIndex(
				ByVal cmap as PixColormap, 
				ByVal val as Integer, 
				<Out()>  ByRef pindex as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetNearestGrayIndex(cmap.Pointer,   val,   pindex)
	
	return _Result
End Function

' colormap.c (1278, 1)
' pixcmapGetDistanceToColor(cmap, index, rval, gval, bval, pdist) as Integer
' pixcmapGetDistanceToColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) Returns the L2 distance (squared) between the color at index i
'''and the target color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetDistanceToColor/*"/>
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
				<Out()>  ByRef pdist as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetDistanceToColor(cmap.Pointer,   index,   rval,   gval,   bval,   pdist)
	
	return _Result
End Function

' colormap.c (1334, 1)
' pixcmapGetRangeValues(cmap, select, pminval, pmaxval, pminindex, pmaxindex) as Integer
' pixcmapGetRangeValues(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) Returns, for selected components (or the average), the
'''the extreme values (min and/or max) and their indices
'''that are found in the cmap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRangeValues/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="pminval">[out][optional] - minimum value of component</param>
'''  <param name="pmaxval">[out][optional] - maximum value of component</param>
'''  <param name="pminindex">[out][optional] - index of minimum value</param>
'''  <param name="pmaxindex">[out][optional] - index of maximum value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapGetRangeValues(
				ByVal cmap as PixColormap, 
				ByVal _select_ as Integer, 
				<Out()> Optional  ByRef pminval as Integer = 0, 
				<Out()> Optional  ByRef pmaxval as Integer = 0, 
				<Out()> Optional  ByRef pminindex as Integer = 0, 
				<Out()> Optional  ByRef pmaxindex as Integer = 0) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGetRangeValues(cmap.Pointer,   _select_,   pminval,   pmaxval,   pminindex,   pmaxindex)
	
	return _Result
End Function

' colormap.c (1430, 1)
' pixcmapGrayToColor(color) as PixColormap
' pixcmapGrayToColor(l_uint32) as PIXCMAP *
'''  <summary>
''' (1) This creates a colormap that maps from gray to
'''a specific color.  In the mapping, each component
'''is faded to white, depending on the gray value.<para/>
'''
'''(2) In use, this is simply attached to a grayscale pix
'''to give it the input color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGrayToColor/*"/>
'''  <param name="color">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapGrayToColor(
				ByVal color as UInteger) as PixColormap


	Dim _Result as IntPtr = Natives.pixcmapGrayToColor(  color)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1462, 1)
' pixcmapColorToGray(cmaps, rwt, gwt, bwt) as PixColormap
' pixcmapColorToGray(PIXCMAP *, l_float32, l_float32, l_float32) as PIXCMAP *
'''  <summary>
''' (1) This creates a gray colormap from an arbitrary colormap.<para/>
'''
'''(2) In use, attach the output gray colormap to the pix
'''(or a copy of it) that provided the input colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapColorToGray/*"/>
'''  <param name="cmaps">[in] - </param>
'''  <param name="rwt">[in] - non-negative these should add to 1.0</param>
'''  <param name="gwt">[in] - non-negative these should add to 1.0</param>
'''  <param name="bwt">[in] - non-negative these should add to 1.0</param>
'''   <returns>cmap gray, or NULL on error</returns>
Public Shared Function pixcmapColorToGray(
				ByVal cmaps as PixColormap, 
				ByVal rwt as Single, 
				ByVal gwt as Single, 
				ByVal bwt as Single) as PixColormap


if IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapColorToGray(cmaps.Pointer,   rwt,   gwt,   bwt)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1518, 1)
' pixcmapConvertTo4(cmaps) as PixColormap
' pixcmapConvertTo4(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' (1) This converts a 2 bpp colormap to 4 bpp.  The colors
'''are the same the output colormap entry array has size 16.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertTo4/*"/>
'''  <param name="cmaps">[in] - colormap for 2 bpp pix</param>
'''   <returns>cmapd   (4 bpp)</returns>
Public Shared Function pixcmapConvertTo4(
				ByVal cmaps as PixColormap) as PixColormap


if IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapConvertTo4(cmaps.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1553, 1)
' pixcmapConvertTo8(cmaps) as PixColormap
' pixcmapConvertTo8(PIXCMAP *) as PIXCMAP *
'''  <summary>
''' (1) This converts a 2 bpp or 4 bpp colormap to 8 bpp.  The colors
'''are the same the output colormap entry array has size 256.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertTo8/*"/>
'''  <param name="cmaps">[in] - colormap for 2 bpp or 4 bpp pix</param>
'''   <returns>cmapd   (8 bpp)</returns>
Public Shared Function pixcmapConvertTo8(
				ByVal cmaps as PixColormap) as PixColormap


if IsNothing (cmaps) then Throw New ArgumentNullException  ("cmaps cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapConvertTo8(cmaps.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1587, 1)
' pixcmapRead(filename) as PixColormap
' pixcmapRead(const char *) as PIXCMAP *
'''  <summary>
''' pixcmapRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapRead(
				ByVal filename as String) as PixColormap


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.pixcmapRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1614, 1)
' pixcmapReadStream(fp) as PixColormap
' pixcmapReadStream(FILE *) as PIXCMAP *
'''  <summary>
''' pixcmapReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapReadStream(
				ByVal fp as FILE) as PixColormap


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1655, 1)
' pixcmapReadMem(data, size) as PixColormap
' pixcmapReadMem(const l_uint8 *, size_t) as PIXCMAP *
'''  <summary>
''' pixcmapReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapReadMem/*"/>
'''  <param name="data">[in] - serialization of pixcmap in ascii</param>
'''  <param name="size">[in] - of data in bytes can use strlen to get it</param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as PixColormap


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (1683, 1)
' pixcmapWrite(filename, cmap) as Integer
' pixcmapWrite(const char *, PIXCMAP *) as l_ok
'''  <summary>
''' pixcmapWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWrite(
				ByVal filename as String, 
				ByVal cmap as PixColormap) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapWrite(  filename, cmap.Pointer)
	
	return _Result
End Function

' colormap.c (1715, 1)
' pixcmapWriteStream(fp, cmap) as Integer
' pixcmapWriteStream(FILE *, PIXCMAP *) as l_ok
'''  <summary>
''' pixcmapWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWriteStream/*"/>
'''  <param name="fp">[in] - file stream    \param[in]    cmap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWriteStream(
				ByVal fp as FILE, 
				ByVal cmap as PixColormap) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim cmapPtr as IntPtr = IntPtr.Zero : If Not IsNothing(cmap) Then cmapPtr = cmap.Pointer

	Dim _Result as Integer = Natives.pixcmapWriteStream(fp.Pointer, cmap.Pointer)
	
	return _Result
End Function

' colormap.c (1761, 1)
' pixcmapWriteMem(pdata, psize, cmap) as Integer
' pixcmapWriteMem(l_uint8 **, size_t *, PIXCMAP *) as l_ok
'''  <summary>
''' (1) Serializes a pixcmap in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized pixcmap ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="cmap">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcmapWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixcmapWriteMem(  pdataPtr,   psize, cmap.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' colormap.c (1813, 1)
' pixcmapToArrays(cmap, prmap, pgmap, pbmap, pamap) as Integer
' pixcmapToArrays(PIXCMAP *, l_int32 **, l_int32 **, l_int32 **, l_int32 **) as l_ok
'''  <summary>
''' pixcmapToArrays()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapToArrays/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="prmap">[out] - colormap arrays</param>
'''  <param name="pgmap">[out] - colormap arrays</param>
'''  <param name="pbmap">[out] - colormap arrays</param>
'''  <param name="pamap">[out][optional] - alpha array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapToArrays(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef prmap as List(of Integer()), 
				<Out()>  ByRef pgmap as List(of Integer()), 
				<Out()>  ByRef pbmap as List(of Integer()), 
				<Out()> Optional  ByRef pamap as List(of Integer()) = nothing) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim prmapPtr as IntPtr = IntPtr.Zero
	Dim pgmapPtr as IntPtr = IntPtr.Zero
	Dim pbmapPtr as IntPtr = IntPtr.Zero
	Dim pamapPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixcmapToArrays(cmap.Pointer,   prmapPtr,   pgmapPtr,   pbmapPtr,   pamapPtr)
	
	if IsNothing(prmap) then prmap = nothing else prmap = prmap
	if IsNothing(pgmap) then pgmap = nothing else pgmap = pgmap
	if IsNothing(pbmap) then pbmap = nothing else pbmap = pbmap
	if IsNothing(pamap) then pamap = nothing else pamap = pamap
	return _Result
End Function

' colormap.c (1867, 1)
' pixcmapToRGBTable(cmap, ptab, pncolors) as Integer
' pixcmapToRGBTable(PIXCMAP *, l_uint32 **, l_int32 *) as l_ok
'''  <summary>
''' pixcmapToRGBTable()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapToRGBTable/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="ptab">[out] - table of rgba values for the colormap</param>
'''  <param name="pncolors">[out][optional] - size of table</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapToRGBTable(
				ByVal cmap as PixColormap, 
				<Out()>  ByRef ptab as Byte(), 
				<Out()> Optional  ByRef pncolors as Integer = 0) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim ptabPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixcmapToRGBTable(cmap.Pointer,   ptabPtr,   pncolors)
	
	ReDim ptab(IIf(1 > 0, 1, 1) - 1)
	If ptabPtr <> IntPtr.Zero Then 
	  Marshal.Copy(ptabPtr, ptab, 0, ptab.count)
	End If
	return _Result
End Function

' colormap.c (1912, 1)
' pixcmapSerializeToMemory(cmap, cpc, pncolors, pdata) as Integer
' pixcmapSerializeToMemory(PIXCMAP *, l_int32, l_int32 *, l_uint8 **) as l_ok
'''  <summary>
''' (1) When serializing to store in a pdf, use %cpc = 3.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSerializeToMemory/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="cpc">[in] - components/color: 3 for rgb, 4 for rgba</param>
'''  <param name="pncolors">[out] - number of colors in table</param>
'''  <param name="pdata">[out] - binary string, cpc bytes per color</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapSerializeToMemory(
				ByVal cmap as PixColormap, 
				ByVal cpc as Integer, 
				<Out()>  ByRef pncolors as Integer, 
				<Out()>  ByRef pdata as Byte()) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixcmapSerializeToMemory(cmap.Pointer,   cpc,   pncolors,   pdataPtr)
	
	ReDim pdata(IIf(1 > 0, 1, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' colormap.c (1960, 1)
' pixcmapDeserializeFromMemory(data, cpc, ncolors) as PixColormap
' pixcmapDeserializeFromMemory(l_uint8 *, l_int32, l_int32) as PIXCMAP *
'''  <summary>
''' pixcmapDeserializeFromMemory()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapDeserializeFromMemory/*"/>
'''  <param name="data">[in] - binary string, 3 or 4 bytes per color</param>
'''  <param name="cpc">[in] - components/color: 3 for rgb, 4 for rgba</param>
'''  <param name="ncolors">[in] - </param>
'''   <returns>cmap, or NULL on error</returns>
Public Shared Function pixcmapDeserializeFromMemory(
				ByVal data as Byte(), 
				ByVal cpc as Integer, 
				ByVal ncolors as Integer) as PixColormap


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcmapDeserializeFromMemory(  data,   cpc,   ncolors)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixColormap(_Result)
End Function

' colormap.c (2021, 1)
' pixcmapConvertToHex(data, ncolors) as String
' pixcmapConvertToHex(l_uint8 *, l_int32) as char *
'''  <summary>
''' (1) The number of bytes in %data is 3  ncolors.<para/>
'''
'''(2) Output is in form:
''' is smaller r0g0b0 r1g1b1 ... rngnbn  is greater 
'''where r0, g0, b0 ... are each 2 bytes of hex ascii<para/>
'''
'''(3) This is used in pdf files to express the colormap as an
'''array in ascii (human-readable) format.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertToHex/*"/>
'''  <param name="data">[in] - binary serialized data</param>
'''  <param name="ncolors">[in] - in colormap</param>
'''   <returns>hexdata bracketed, space-separated ascii hex string, or NULL on error.</returns>
Public Shared Function pixcmapConvertToHex(
				ByVal data as Byte(), 
				ByVal ncolors as Integer) as String


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as String = Natives.pixcmapConvertToHex(  data,   ncolors)
	
	return _Result
End Function

' colormap.c (2079, 1)
' pixcmapGammaTRC(cmap, gamma, minval, maxval) as Integer
' pixcmapGammaTRC(PIXCMAP *, l_float32, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This is an in-place transform<para/>
'''
'''(2) See pixGammaTRC() and numaGammaTRC() in enhance.c
'''for description and use of transform
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGammaTRC/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="gamma">[in] - gamma correction must be  is greater  0.0</param>
'''  <param name="minval">[in] - input value that gives 0 for output can be  is smaller 0</param>
'''  <param name="maxval">[in] - input value that gives 255 for output can be  is greater  255</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapGammaTRC(
				ByVal cmap as PixColormap, 
				ByVal gamma as Single, 
				ByVal minval as Integer, 
				ByVal maxval as Integer) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapGammaTRC(cmap.Pointer,   gamma,   minval,   maxval)
	
	return _Result
End Function

' colormap.c (2134, 1)
' pixcmapContrastTRC(cmap, factor) as Integer
' pixcmapContrastTRC(PIXCMAP *, l_float32) as l_ok
'''  <summary>
''' (1) This is an in-place transform<para/>
'''
'''(2) See pixContrastTRC() and numaContrastTRC() in enhance.c
'''for description and use of transform
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapContrastTRC/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="factor">[in] - generally between 0.0 [no enhancement] and 1.0, but can be larger than 1.0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapContrastTRC(
				ByVal cmap as PixColormap, 
				ByVal factor as Single) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapContrastTRC(cmap.Pointer,   factor)
	
	return _Result
End Function

' colormap.c (2186, 1)
' pixcmapShiftIntensity(cmap, fraction) as Integer
' pixcmapShiftIntensity(PIXCMAP *, l_float32) as l_ok
'''  <summary>
''' (1) This is an in-place transform<para/>
'''
'''(2) It does a proportional shift of the intensity for each color.<para/>
'''
'''(3) If fraction  is smaller 0.0, it moves all colors towards (0,0,0).
'''This darkens the image.
'''If fraction  is greater  0.0, it moves all colors towards (255,255,255)
'''This fades the image.<para/>
'''
'''(4) The equivalent transform can be accomplished with pixcmapGammaTRC(),
'''but it is considerably more difficult (see numaGammaTRC()).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapShiftIntensity/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="fraction">[in] - between -1.0 and +1.0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapShiftIntensity(
				ByVal cmap as PixColormap, 
				ByVal fraction as Single) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapShiftIntensity(cmap.Pointer,   fraction)
	
	return _Result
End Function

' colormap.c (2236, 1)
' pixcmapShiftByComponent(cmap, srcval, dstval) as Integer
' pixcmapShiftByComponent(PIXCMAP *, l_uint32, l_uint32) as l_ok
'''  <summary>
''' (1) This is an in-place transform<para/>
'''
'''(2) It implements pixelShiftByComponent() for each color.
'''The mapping is specified by srcval and dstval.<para/>
'''
'''(3) If a component decreases, the component in the colormap
'''decreases by the same ratio.  Likewise for increasing, except
'''all ratios are taken with respect to the distance from 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapShiftByComponent/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''  <param name="srcval">[in] - source color: 0xrrggbb00</param>
'''  <param name="dstval">[in] - target color: 0xrrggbb00</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapShiftByComponent(
				ByVal cmap as PixColormap, 
				ByVal srcval as UInteger, 
				ByVal dstval as UInteger) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapShiftByComponent(cmap.Pointer,   srcval,   dstval)
	
	return _Result
End Function

End Class


