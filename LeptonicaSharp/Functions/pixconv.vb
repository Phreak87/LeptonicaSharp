Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\pixconv.c (204, 1)
' pixThreshold8()
' pixThreshold8(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This uses, by default, equally spaced "target" values
''' that depend on the number of levels, with thresholds
''' halfway between.  For N levels, with separation (N-1)/255,
''' there are N-1 fixed thresholds.
''' (2) For 1 bpp destination, the number of levels can only be 2
''' and if a cmap is made, black is (0,0,0) and white
''' is (255,255,255), which is opposite to the convention
''' without a colormap.
''' (3) For 1, 2 and 4 bpp, the nlevels arg is used if a colormap
''' is made; otherwise, we take the most significant bits
''' from the src that will fit in the dest.
''' (4) For 8 bpp, the input pixs is quantized to nlevels.  The
''' dest quantized with that mapping, either through a colormap
''' table or directly with 8 bit values.
''' (5) Typically you should not use make a colormap for 1 bpp dest.
''' (6) This is not dithering.  Each pixel is treated independently.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale</param>
'''  <param name="d">[in] - destination depth 1, 2, 4 or 8</param>
'''  <param name="nlevels">[in] - number of levels to be used for colormap</param>
'''  <param name="cmapflag">[in] - 1 if makes colormap; 0 otherwise</param>
'''   <returns>pixd thresholded with standard dest thresholds, or NULL on error</returns>
Public Shared Function pixThreshold8(
				ByVal pixs as Pix, 
				ByVal d as Integer, 
				ByVal nlevels as Integer, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp grayscale")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixThreshold8( pixs.Pointer, d, nlevels, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (272, 1)
' pixRemoveColormapGeneral()
' pixRemoveColormapGeneral(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Convenience function that allows choice between returning
''' a clone or a copy if pixs does not have a colormap.
''' (2) See pixRemoveColormap().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, with or without colormap</param>
'''  <param name="type">[in] - REMOVE_CMAP_TO_BINARY, REMOVE_CMAP_TO_GRAYSCALE, REMOVE_CMAP_TO_FULL_COLOR, REMOVE_CMAP_WITH_ALPHA, REMOVE_CMAP_BASED_ON_SRC</param>
'''  <param name="ifnocmap">[in] - L_CLONE, L_COPY</param>
'''   <returns>pixd always a new pix; without colormap, or NULL on error</returns>
Public Shared Function pixRemoveColormapGeneral(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.REMOVE_CMAP, 
				ByVal ifnocmap as Enumerations.L_access_storage) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveColormapGeneral( pixs.Pointer, type, ifnocmap)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (322, 1)
' pixRemoveColormap()
' pixRemoveColormap(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixs does not have a colormap, a clone is returned.
''' (2) Otherwise, the input pixs is restricted to 1, 2, 4 or 8 bpp.
''' (3) Use REMOVE_CMAP_TO_BINARY only on 1 bpp pix.
''' (4) For grayscale conversion from RGB, use a weighted average
''' of RGB values, and always return an 8 bpp pix, regardless
''' of whether the input pixs depth is 2, 4 or 8 bpp.
''' (5) REMOVE_CMAP_TO_FULL_COLOR ignores the alpha component and
''' returns a 32 bpp pix with spp == 3 and the alpha bytes are 0.
''' (6) For REMOVE_CMAP_BASED_ON_SRC, if there is no color, this
''' returns either a 1 bpp or 8 bpp grayscale pix.
''' If there is color, this returns a 32 bpp pix, with either
''' 3 spp, if the alpha values are all 255 (opaque), or
''' 4 spp (preserving the alpha), if any alpha values are not 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - see restrictions below</param>
'''  <param name="type">[in] - REMOVE_CMAP_TO_BINARY, REMOVE_CMAP_TO_GRAYSCALE, REMOVE_CMAP_TO_FULL_COLOR, REMOVE_CMAP_WITH_ALPHA, REMOVE_CMAP_BASED_ON_SRC</param>
'''   <returns>pixd without colormap, or NULL on error</returns>
Public Shared Function pixRemoveColormap(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.REMOVE_CMAP) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveColormap( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (613, 1)
' pixAddGrayColormap8()
' pixAddGrayColormap8(PIX *) as l_ok
'''  <summary>
''' Notes
''' (1) If pixs has a colormap, this is a no-op.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAddGrayColormap8(
				ByVal pixs as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixAddGrayColormap8( pixs.Pointer)

	Return _Result
End Function

' SRC\pixconv.c (644, 1)
' pixAddMinimalGrayColormap8()
' pixAddMinimalGrayColormap8(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This generates a colormapped version of the input image
''' that has the same number of colormap entries as the
''' input image has unique gray levels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAddMinimalGrayColormap8(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAddMinimalGrayColormap8( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (733, 1)
' pixConvertRGBToLuminance()
' pixConvertRGBToLuminance(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Use a standard luminance conversion.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToLuminance(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToLuminance( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (753, 1)
' pixConvertRGBToGray()
' pixConvertRGBToGray(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) Use a weighted average of the RGB values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="rwt">[in] - non-negative; these should add to 1.0, or use 0.0 for default</param>
'''  <param name="gwt">[in] - non-negative; these should add to 1.0, or use 0.0 for default</param>
'''  <param name="bwt">[in] - non-negative; these should add to 1.0, or use 0.0 for default</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToGray(
				ByVal pixs as Pix, 
				ByVal rwt as Single, 
				ByVal gwt as Single, 
				ByVal bwt as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rwt) then Throw New ArgumentNullException  ("rwt cannot be Nothing")
	If IsNothing (gwt) then Throw New ArgumentNullException  ("gwt cannot be Nothing")
	If IsNothing (bwt) then Throw New ArgumentNullException  ("bwt cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToGray( pixs.Pointer, rwt, gwt, bwt)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (831, 1)
' pixConvertRGBToGrayFast()
' pixConvertRGBToGrayFast(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This function should be used if speed of conversion
''' is paramount, and the green channel can be used as
''' a fair representative of the RGB intensity.  It is
''' several times faster than pixConvertRGBToGray().
''' (2) To combine RGB to gray conversion with subsampling,
''' use pixScaleRGBToGrayFast() instead.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToGrayFast(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToGrayFast( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (887, 1)
' pixConvertRGBToGrayMinMax()
' pixConvertRGBToGrayMinMax(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This chooses various components or combinations of them,
''' from the three RGB sample values.  In addition to choosing
''' the min, max, and maxdiff (difference between max and min),
''' this also allows boosting the min and max about a reference
''' value.
''' (2) The default reference value for boosting the min and max
''' is 200.  This can be changed with l_setNeutralBoostVal()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="type">[in] - L_CHOOSE_MIN, L_CHOOSE_MAX, L_CHOOSE_MAXDIFF, L_CHOOSE_MIN_BOOST, L_CHOOSE_MAX_BOOST</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToGrayMinMax(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_CHOOSE_M) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToGrayMinMax( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (974, 1)
' pixConvertRGBToGraySatBoost()
' pixConvertRGBToGraySatBoost(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This returns the max component value, boosted by
''' the saturation. The maximum boost occurs where
''' the maximum component value is equal to some reference value.
''' This particular weighting is due to Dany Qumsiyeh.
''' (2) For gray pixels (zero saturation), this returns
''' the intensity of any component.
''' (3) For fully saturated pixels ('fullsat'), this rises linearly
''' with the max value and has a slope equal to 255 divided
''' by the reference value; for a max value greater than
''' the reference value, it is clipped to 255.
''' (4) For saturation values in between, the output is a linear
''' combination of (2) and (3), weighted by saturation.
''' It falls between these two curves, and does not exceed 255.
''' (5) This can be useful for distinguishing an object that has nonzero
''' saturation from a gray background.  For this, the refval
''' should be chosen near the expected value of the background,
''' to achieve maximum saturation boost there.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="refval">[in] - between 1 and 255; typ. less than 128</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvertRGBToGraySatBoost(
				ByVal pixs as Pix, 
				ByVal refval as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToGraySatBoost( pixs.Pointer, refval)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1052, 1)
' pixConvertRGBToGrayArb()
' pixConvertRGBToGrayArb(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This converts to gray using an arbitrary linear combination
''' of the rgb color components.  It differs from pixConvertToGray(),
''' which uses only positive coefficients that sum to 1.
''' (2) The gray output values are clipped to 0 and 255.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="rc">[in] - arithmetic factors; can be negative</param>
'''  <param name="gc">[in] - arithmetic factors; can be negative</param>
'''  <param name="bc">[in] - arithmetic factors; can be negative</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToGrayArb(
				ByVal pixs as Pix, 
				ByVal rc as Single, 
				ByVal gc as Single, 
				ByVal bc as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rc) then Throw New ArgumentNullException  ("rc cannot be Nothing")
	If IsNothing (gc) then Throw New ArgumentNullException  ("gc cannot be Nothing")
	If IsNothing (bc) then Throw New ArgumentNullException  ("bc cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToGrayArb( pixs.Pointer, rc, gc, bc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1114, 1)
' pixConvertRGBToBinaryArb()
' pixConvertRGBToBinaryArb(PIX *, l_float32, l_float32, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This makes a 1 bpp mask from an RGB image, using an arbitrary
''' linear combination of the rgb color components, along with
''' a threshold and a selection choice of the gray value relative
''' to %thresh.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB</param>
'''  <param name="rc">[in] - arithmetic factors; can be negative</param>
'''  <param name="gc">[in] - arithmetic factors; can be negative</param>
'''  <param name="bc">[in] - arithmetic factors; can be negative</param>
'''  <param name="thresh">[in] - binarization threshold</param>
'''  <param name="relation">[in] - L_SELECT_IF_LT, L_SELECT_IF_GT L_SELECT_IF_LTE, L_SELECT_IF_GTE</param>
'''   <returns>1 bpp pix, or NULL on error</returns>
Public Shared Function pixConvertRGBToBinaryArb(
				ByVal pixs as Pix, 
				ByVal rc as Single, 
				ByVal gc as Single, 
				ByVal bc as Single, 
				ByVal thresh as Integer, 
				ByVal relation as Enumerations.L_SELECT_IF) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rc) then Throw New ArgumentNullException  ("rc cannot be Nothing")
	If IsNothing (gc) then Throw New ArgumentNullException  ("gc cannot be Nothing")
	If IsNothing (bc) then Throw New ArgumentNullException  ("bc cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp RGB")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToBinaryArb( pixs.Pointer, rc, gc, bc, thresh, relation)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1171, 1)
' pixConvertGrayToColormap()
' pixConvertGrayToColormap(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a simple interface for adding a colormap to a
''' 2, 4 or 8 bpp grayscale image without causing any
''' quantization.  There is some similarity to operations
''' in grayquant.c, such as pixThresholdOn8bpp(), where
''' the emphasis is on quantization with an arbitrary number
''' of levels, and a colormap is an option.
''' (2) Returns a copy if pixs already has a colormap.
''' (3) For 8 bpp src, this is a lossless transformation.
''' (4) For 2 and 4 bpp src, this generates a colormap that
''' assumes full coverage of the gray space, with equally spaced
''' levels 4 levels for d = 2 and 16 levels for d = 4.
''' (5) In all cases, the depth of the dest is the same as the src.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2, 4 or 8 bpp grayscale</param>
'''   <returns>pixd 2, 4 or 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixConvertGrayToColormap(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {2,4,8}.contains (pixs.d) = false then Throw New ArgumentException ("2, 4 or 8 bpp grayscale")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertGrayToColormap( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1226, 1)
' pixConvertGrayToColormap8()
' pixConvertGrayToColormap8(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Returns a copy if pixs already has a colormap.
''' (2) This is a lossless transformation; there is no quantization.
''' We compute the number of different gray values in pixs,
''' and construct a colormap that has exactly these values.
''' (3) 'mindepth' is the minimum depth of pixd.  If mindepth == 8,
''' pixd will always be 8 bpp.  Let the number of different
''' gray values in pixs be ngray.  If mindepth == 4, we attempt
''' to save pixd as a 4 bpp image, but if ngray GT 16,
''' pixd must be 8 bpp.  Likewise, if mindepth == 2,
''' the depth of pixd will be 2 if ngray LT= 4 and 4 if ngray GT 4
''' but LT= 16.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale</param>
'''  <param name="mindepth">[in] - of pixd; valid values are 2, 4 and 8</param>
'''   <returns>pixd 2, 4 or 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixConvertGrayToColormap8(
				ByVal pixs as Pix, 
				ByVal mindepth as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp grayscale")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertGrayToColormap8( pixs.Pointer, mindepth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1323, 1)
' pixColorizeGray()
' pixColorizeGray(PIX *, l_uint32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This applies the specific color to the grayscale image.
''' (2) If pixs already has a colormap, it is removed to gray
''' before colorizing.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray; 2, 4 or 8 bpp colormapped</param>
'''  <param name="color">[in] - 32 bit rgba pixel</param>
'''  <param name="cmapflag">[in] - 1 for result to have colormap; 0 for RGB</param>
'''   <returns>pixd 8 bpp colormapped or 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixColorizeGray(
				ByVal pixs as Pix, 
				ByVal color as UInteger, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {2,4,8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp gray; 2, 4 or 8 bpp colormapped")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorizeGray( pixs.Pointer, color, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1412, 1)
' pixConvertRGBToColormap()
' pixConvertRGBToColormap(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This function has two relatively simple modes of color
''' quantization
''' (a) If the image is made orthographically and has not more
''' than 256 'colors' at the level 4 octcube leaves,
''' it is quantized nearly exactly.  The ditherflag
''' is ignored.
''' (b) Most natural images have more than 256 different colors;
''' in that case we use adaptive octree quantization,
''' with dithering if requested.
''' (2) If there are not more than 256 occupied level 4 octcubes,
''' the color in the colormap that represents all pixels in
''' one of those octcubes is given by the first pixel that
''' falls into that octcube.
''' (3) If there are more than 256 colors, we use adaptive octree
''' color quantization.
''' (4) Dithering gives better visual results on images where
''' there is a color wash (a slow variation of color), but it
''' is about twice as slow and results in significantly larger
''' files when losslessly compressed (e.g., into png).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ditherflag">[in] - 1 to dither, 0 otherwise</param>
'''   <returns>pixd 2, 4 or 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixConvertRGBToColormap(
				ByVal pixs as Pix, 
				ByVal ditherflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToColormap( pixs.Pointer, ditherflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1477, 1)
' pixConvertCmapTo1()
' pixConvertCmapTo1(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This is an extreme color quantizer.  It decides which
''' colors map to FG (black) and which to BG (white).
''' (2) This uses two heuristics to make the decision
''' (a) colors similar to each other are likely to be in the same class
''' (b) there is usually much less FG than BG.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - cmapped</param>
'''   <returns>pixd 1 bpp, or NULL on error</returns>
Public Shared Function pixConvertCmapTo1(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertCmapTo1( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1588, 1)
' pixQuantizeIfFewColors()
' pixQuantizeIfFewColors(PIX *, l_int32, l_int32, l_int32, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) This is a wrapper that tests if the pix can be quantized
''' with good quality using a small number of colors.  If so,
''' it does the quantization, defining a colormap and using
''' pixels whose value is an index into the colormap.
''' (2) If the image has color, it is quantized with 8 bpp pixels.
''' If the image is essentially grayscale, the pixels are
''' either 4 or 8 bpp, depending on the size of the required
''' colormap.
''' (3) %octlevel = 4 generates a larger colormap and larger
''' compressed image than %octlevel = 3.  If image quality is
''' important, you should use %octlevel = 4.
''' (4) If the image already has a colormap, it returns a clone.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb</param>
'''  <param name="maxcolors">[in] - max number of colors allowed to be returned from pixColorsForQuantization(); use 0 for default</param>
'''  <param name="mingraycolors">[in] - min number of gray levels that a grayscale image is quantized to; use 0 for default</param>
'''  <param name="octlevel">[in] - for octcube quantization 3 or 4</param>
'''  <param name="ppixd">[out] - 2,4 or 8 bpp quantized; null if too many colors</param>
'''   <returns>0 if OK, 1 on error or if pixs can't be quantized into a small number of colors.</returns>
Public Shared Function pixQuantizeIfFewColors(
				ByVal pixs as Pix, 
				ByVal maxcolors as Integer, 
				ByVal mingraycolors as Integer, 
				ByVal octlevel as Integer, 
				ByRef ppixd as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixQuantizeIfFewColors( pixs.Pointer, maxcolors, mingraycolors, octlevel, ppixdPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\pixconv.c (1689, 1)
' pixConvert16To8()
' pixConvert16To8(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) With L_AUTO_BYTE, if the max pixel value is greater than 255,
''' use the MSB; otherwise, use the LSB.
''' (2) With L_CLIP_TO_FF, use min(pixel-value, 0xff) for each
''' 16-bit src pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 16 bpp</param>
'''  <param name="type">[in] - L_LS_BYTE, L_MS_BYTE, L_AUTO_BYTE, L_CLIP_TO_FF</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvert16To8(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_16_bit_conversion) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {16}.contains (pixs.d) = false then Throw New ArgumentException ("16 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert16To8( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1786, 1)
' pixConvertGrayToFalseColor()
' pixConvertGrayToFalseColor(PIX *, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) For 8 bpp input, this simply adds a colormap to the input image.
''' (2) For 16 bpp input, it first converts to 8 bpp, using the MSB,
''' and then adds the colormap.
''' (3) The colormap is modeled after the Matlab "jet" configuration.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 16 bpp grayscale</param>
'''  <param name="gamma">[in] - (factor) 0.0 or 1.0 for default; GT 1.0 for brighter; 2.0 is quite nice</param>
'''   <returns>pixd 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixConvertGrayToFalseColor(
				ByVal pixs as Pix, 
				ByVal gamma as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (gamma) then Throw New ArgumentNullException  ("gamma cannot be Nothing")
	If {8,16}.contains (pixs.d) = false then Throw New ArgumentException ("8 or 16 bpp grayscale")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertGrayToFalseColor( pixs.Pointer, gamma)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1878, 1)
' pixUnpackBinary()
' pixUnpackBinary(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This function calls special cases of pixConvert1To(),
''' for 2, 4, 8, 16 and 32 bpp destinations.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="depth">[in] - of destination 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="invert">[in] - 0  binary 0 --GT grayscale 0 binary 1 --GT grayscale 0xff... 1  binary 0 --GT grayscale 0xff... binary 1 --GT grayscale 0</param>
'''   <returns>pixd 2, 4, 8, 16 or 32 bpp, or NULL on error</returns>
Public Shared Function pixUnpackBinary(
				ByVal pixs as Pix, 
				ByVal depth as Integer, 
				ByVal invert as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnpackBinary( pixs.Pointer, depth, invert)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (1943, 1)
' pixConvert1To16()
' pixConvert1To16(PIX *, PIX *, l_uint16, l_uint16) as PIX *
'''  <summary>
''' Notes
''' (1) If pixd is null, a new pix is made.
''' (2) If pixd is not null, it must be of equal width and height
''' as pixs.  It is always returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 16 bpp, can be null</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="val0">[in] - 16 bit value to be used for 0s in pixs</param>
'''  <param name="val1">[in] - 16 bit value to be used for 1s in pixs</param>
'''   <returns>pixd 16 bpp</returns>
Public Shared Function pixConvert1To16(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal val0 as UShort, 
				ByVal val1 as UShort) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (val0) then Throw New ArgumentNullException  ("val0 cannot be Nothing")
	If IsNothing (val1) then Throw New ArgumentNullException  ("val1 cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To16( pixdPTR, pixs.Pointer, val0, val1)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2017, 1)
' pixConvert1To32()
' pixConvert1To32(PIX *, PIX *, l_uint32, l_uint32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixd is null, a new pix is made.
''' (2) If pixd is not null, it must be of equal width and height
''' as pixs.  It is always returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 32 bpp, can be null</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="val0">[in] - 32 bit value to be used for 0s in pixs</param>
'''  <param name="val1">[in] - 32 bit value to be used for 1s in pixs</param>
'''   <returns>pixd 32 bpp</returns>
Public Shared Function pixConvert1To32(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal val0 as UInteger, 
				ByVal val1 as UInteger) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To32( pixdPTR, pixs.Pointer, val0, val1)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2080, 1)
' pixConvert1To2Cmap()
' pixConvert1To2Cmap(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Input 0 is mapped to (255, 255, 255); 1 is mapped to (0, 0, 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 2 bpp, cmapped</returns>
Public Shared Function pixConvert1To2Cmap(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To2Cmap( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2123, 1)
' pixConvert1To2()
' pixConvert1To2(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixd is null, a new pix is made.
''' (2) If pixd is not null, it must be of equal width and height
''' as pixs.  It is always returned.
''' (3) A simple unpacking might use val0 = 0 and val1 = 3.
''' (4) If you want a colormapped pixd, use pixConvert1To2Cmap().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 2 bpp, can be null</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="val0">[in] - 2 bit value to be used for 0s in pixs</param>
'''  <param name="val1">[in] - 2 bit value to be used for 1s in pixs</param>
'''   <returns>pixd 2 bpp</returns>
Public Shared Function pixConvert1To2(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal val0 as Integer, 
				ByVal val1 as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To2( pixdPTR, pixs.Pointer, val0, val1)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2202, 1)
' pixConvert1To4Cmap()
' pixConvert1To4Cmap(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Input 0 is mapped to (255, 255, 255); 1 is mapped to (0, 0, 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 4 bpp, cmapped</returns>
Public Shared Function pixConvert1To4Cmap(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To4Cmap( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2245, 1)
' pixConvert1To4()
' pixConvert1To4(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixd is null, a new pix is made.
''' (2) If pixd is not null, it must be of equal width and height
''' as pixs.  It is always returned.
''' (3) A simple unpacking might use val0 = 0 and val1 = 15, or v.v.
''' (4) If you want a colormapped pixd, use pixConvert1To4Cmap().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 4 bpp, can be null</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="val0">[in] - 4 bit value to be used for 0s in pixs</param>
'''  <param name="val1">[in] - 4 bit value to be used for 1s in pixs</param>
'''   <returns>pixd 4 bpp</returns>
Public Shared Function pixConvert1To4(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal val0 as Integer, 
				ByVal val1 as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {4}.contains (pixd.d) = false then Throw New ArgumentException ("4 bpp, can be null")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To4( pixdPTR, pixs.Pointer, val0, val1)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2323, 1)
' pixConvert1To8Cmap()
' pixConvert1To8Cmap(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Input 0 is mapped to (255, 255, 255); 1 is mapped to (0, 0, 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, cmapped</returns>
Public Shared Function pixConvert1To8Cmap(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To8Cmap( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2366, 1)
' pixConvert1To8()
' pixConvert1To8(PIX *, PIX *, l_uint8, l_uint8) as PIX *
'''  <summary>
''' Notes
''' (1) If pixd is null, a new pix is made.
''' (2) If pixd is not null, it must be of equal width and height
''' as pixs.  It is always returned.
''' (3) A simple unpacking might use val0 = 0 and val1 = 255, or v.v.
''' (4) To have a colormap associated with the 8 bpp pixd,
''' use pixConvert1To8Cmap().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 8 bpp, can be null</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="val0">[in] - 8 bit value to be used for 0s in pixs</param>
'''  <param name="val1">[in] - 8 bit value to be used for 1s in pixs</param>
'''   <returns>pixd 8 bpp</returns>
Public Shared Function pixConvert1To8(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal val0 as Byte, 
				ByVal val1 as Byte) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (val0) then Throw New ArgumentNullException  ("val0 cannot be Nothing")
	If IsNothing (val1) then Throw New ArgumentNullException  ("val1 cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert1To8( pixdPTR, pixs.Pointer, val0, val1)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2456, 1)
' pixConvert2To8()
' pixConvert2To8(PIX *, l_uint8, l_uint8, l_uint8, l_uint8, l_int32) as PIX *
'''  <summary>
''' Notes
''' ~ A simple unpacking might use val0 = 0,
''' val1 = 85 (0x55), val2 = 170 (0xaa), val3 = 255.
''' ~ If cmapflag is TRUE
''' ~ The 8 bpp image is made with a colormap.
''' ~ If pixs has a colormap, the input values are ignored and
''' the 8 bpp image is made using the colormap
''' ~ If pixs does not have a colormap, the input values are
''' used to build the colormap.
''' ~ If cmapflag is FALSE
''' ~ The 8 bpp image is made without a colormap.
''' ~ If pixs has a colormap, the input values are ignored,
''' the colormap is removed, and the values stored in the 8 bpp
''' image are from the colormap.
''' ~ If pixs does not have a colormap, the input values are
''' used to populate the 8 bpp image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 2 bpp</param>
'''  <param name="val0">[in] - 8 bit value to be used for 00 in pixs</param>
'''  <param name="val1">[in] - 8 bit value to be used for 01 in pixs</param>
'''  <param name="val2">[in] - 8 bit value to be used for 10 in pixs</param>
'''  <param name="val3">[in] - 8 bit value to be used for 11 in pixs</param>
'''  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap; FALSE otherwise</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvert2To8(
				ByVal pixs as Pix, 
				ByVal val0 as Byte, 
				ByVal val1 as Byte, 
				ByVal val2 as Byte, 
				ByVal val3 as Byte, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (val0) then Throw New ArgumentNullException  ("val0 cannot be Nothing")
	If IsNothing (val1) then Throw New ArgumentNullException  ("val1 cannot be Nothing")
	If IsNothing (val2) then Throw New ArgumentNullException  ("val2 cannot be Nothing")
	If IsNothing (val3) then Throw New ArgumentNullException  ("val3 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert2To8( pixs.Pointer, val0, val1, val2, val3, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2567, 1)
' pixConvert4To8()
' pixConvert4To8(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' ~ If cmapflag is TRUE
''' ~ pixd is made with a colormap.
''' ~ If pixs has a colormap, it is copied and the colormap
''' index values are placed in pixd.
''' ~ If pixs does not have a colormap, a colormap with linear
''' trc is built and the pixel values in pixs are placed in
''' pixd as colormap index values.
''' ~ If cmapflag is FALSE
''' ~ pixd is made without a colormap.
''' ~ If pixs has a colormap, it is removed and the values stored
''' in pixd are from the colormap (converted to gray).
''' ~ If pixs does not have a colormap, the pixel values in pixs
''' are used, with shift replication, to populate pixd.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 4 bpp</param>
'''  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap; FALSE otherwise</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvert4To8(
				ByVal pixs as Pix, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert4To8( pixs.Pointer, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2652, 1)
' pixConvert8To16()
' pixConvert8To16(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For left shift of 8, the 8 bit value is replicated in both
''' the MSB and the LSB of the pixels in pixd.  That way, we get
''' proportional mapping, with a correct map from 8 bpp white
''' (0xff) to 16 bpp white (0xffff).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; colormap removed to gray</param>
'''  <param name="leftshift">[in] - number of bits 0 is no shift; 8 replicates in MSB and LSB of dest</param>
'''   <returns>pixd 16 bpp, or NULL on error</returns>
Public Shared Function pixConvert8To16(
				ByVal pixs as Pix, 
				ByVal leftshift as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert8To16( pixs.Pointer, leftshift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2718, 1)
' pixConvertTo2()
' pixConvertTo2(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a top-level function, with simple default values
''' used in pixConvertTo8() if unpacking is necessary.
''' (2) Any existing colormap is removed; the result is always gray.
''' (3) If the input image has 2 bpp and no colormap, the operation is
''' lossless and a copy is returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp; colormap OK but will be removed</param>
'''   <returns>pixd   2 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo2(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo2( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2770, 1)
' pixConvert8To2()
' pixConvert8To2(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Any existing colormap is removed to gray.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; colormap OK</param>
'''   <returns>pixd  2 bpp, or NULL on error</returns>
Public Shared Function pixConvert8To2(
				ByVal pix as Pix) as Pix

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {8}.contains (pix.d) = false then Throw New ArgumentException ("8 bpp; colormap OK")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert8To2( pix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2826, 1)
' pixConvertTo4()
' pixConvertTo4(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a top-level function, with simple default values
''' used in pixConvertTo8() if unpacking is necessary.
''' (2) Any existing colormap is removed; the result is always gray.
''' (3) If the input image has 4 bpp and no colormap, the operation is
''' lossless and a copy is returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 32 bpp; colormap OK but will be removed</param>
'''   <returns>pixd   4 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo4(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo4( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2878, 1)
' pixConvert8To4()
' pixConvert8To4(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Any existing colormap is removed to gray.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp; colormap OK</param>
'''   <returns>pixd  4 bpp, or NULL on error</returns>
Public Shared Function pixConvert8To4(
				ByVal pix as Pix) as Pix

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If {8}.contains (pix.d) = false then Throw New ArgumentException ("8 bpp; colormap OK")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert8To4( pix.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2933, 1)
' pixConvertTo1()
' pixConvertTo1(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a top-level function, with simple default values
''' used in pixConvertTo8() if unpacking is necessary.
''' (2) Any existing colormap is removed.
''' (3) If the input image has 1 bpp and no colormap, the operation is
''' lossless and a copy is returned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="threshold">[in] - for final binarization, relative to 8 bpp</param>
'''   <returns>pixd 1 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo1(
				ByVal pixs as Pix, 
				ByVal threshold as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo1( pixs.Pointer, threshold)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (2989, 1)
' pixConvertTo1BySampling()
' pixConvertTo1BySampling(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a quick and dirty, top-level converter.
''' (2) See pixConvertTo1() for default values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="factor">[in] - submsampling factor; integer GT= 1</param>
'''  <param name="threshold">[in] - for final binarization, relative to 8 bpp</param>
'''   <returns>pixd 1 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo1BySampling(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal threshold as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo1BySampling( pixs.Pointer, factor, threshold)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3041, 1)
' pixConvertTo8()
' pixConvertTo8(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a top-level function, with simple default values
''' for unpacking.
''' (2) The result, pixd, is made with a colormap if specified.
''' It is always a new image -- never a clone.  For example,
''' if d == 8, and cmapflag matches the existence of a cmap
''' in pixs, the operation is lossless and it returns a copy.
''' (3) The default values used are
''' ~ 1 bpp val0 = 255, val1 = 0
''' ~ 2 bpp 4 bpp  even increments over dynamic range
''' ~ 8 bpp lossless if cmap matches cmapflag
''' ~ 16 bpp use most significant byte
''' (4) If 32 bpp RGB, this is converted to gray.  If you want
''' to do color quantization, you must specify the type
''' explicitly, using the color quantization code.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap; FALSE otherwise</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo8(
				ByVal pixs as Pix, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo8( pixs.Pointer, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3105, 1)
' pixConvertTo8BySampling()
' pixConvertTo8BySampling(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a fast, quick/dirty, top-level converter.
''' (2) See pixConvertTo8() for default values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="factor">[in] - submsampling factor; integer GT= 1</param>
'''  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap; FALSE otherwise</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo8BySampling(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal cmapflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo8BySampling( pixs.Pointer, factor, cmapflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3149, 1)
' pixConvertTo8Colormap()
' pixConvertTo8Colormap(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a top-level function, with simple default values
''' for unpacking.
''' (2) The result, pixd, is always made with a colormap.
''' (3) If d == 8, the operation is lossless and it returns a copy.
''' (4) The default values used for increasing depth are
''' ~ 1 bpp val0 = 255, val1 = 0
''' ~ 2 bpp 4 bpp  even increments over dynamic range
''' (5) For 16 bpp, use the most significant byte.
''' (6) For 32 bpp RGB, use octcube quantization with optional dithering.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="dither">[in] - 1 to dither if necessary; 0 otherwise</param>
'''   <returns>pixd 8 bpp, cmapped, or NULL on error</returns>
Public Shared Function pixConvertTo8Colormap(
				ByVal pixs as Pix, 
				ByVal dither as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo8Colormap( pixs.Pointer, dither)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3184, 1)
' pixConvertTo16()
' pixConvertTo16(PIX *) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 8 bpp</param>
'''   <returns>pixd 16 bpp, or NULL on error Usage Top-level function, with simple default values for unpacking. 1 bpp  val0 = 0xffff, val1 = 0 8 bpp  replicates the 8 bit value in both the MSB and LSB of the 16 bit pixel.</returns>
Public Shared Function pixConvertTo16(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo16( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3233, 1)
' pixConvertTo32()
' pixConvertTo32(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) Never returns a clone of pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''   <returns>pixd 32 bpp, or NULL on error Usage Top-level function, with simple default values for unpacking. 1 bpp  val0 = 255, val1 = 0 and then replication into R, G and B components 2 bpp  if colormapped, use the colormap values; otherwise, use val0 = 0, val1 = 0x55, val2 = 0xaa, val3 = 255 and replicate gray into R, G and B components 4 bpp  if colormapped, use the colormap values; otherwise, replicate 2 nybs into a byte, and then into R,G,B components 8 bpp  if colormapped, use the colormap values; otherwise, replicate gray values into R, G and B components 16 bpp replicate MSB into R, G and B components 24 bpp unpack the pixels, maintaining word alignment on each scanline 32 bpp makes a copy</returns>
Public Shared Function pixConvertTo32(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo32( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3288, 1)
' pixConvertTo32BySampling()
' pixConvertTo32BySampling(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a fast, quick/dirty, top-level converter.
''' (2) See pixConvertTo32() for default values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16 or 32 bpp</param>
'''  <param name="factor">[in] - submsampling factor; integer GT= 1</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixConvertTo32BySampling(
				ByVal pixs as Pix, 
				ByVal factor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,24,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16 or 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo32BySampling( pixs.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3323, 1)
' pixConvert8To32()
' pixConvert8To32(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) If there is no colormap, replicates the gray value
''' into the 3 MSB of the dest pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''   <returns>32 bpp rgb pix, or NULL on error</returns>
Public Shared Function pixConvert8To32(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert8To32( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3393, 1)
' pixConvertTo8Or32()
' pixConvertTo8Or32(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If there is a colormap, the colormap is removed to 8 or 32 bpp,
''' depending on whether the colors in the colormap are all gray.
''' (2) If the input is either rgb or 8 bpp without a colormap,
''' this returns either a clone or a copy, depending on %copyflag.
''' (3) Otherwise, the pix is converted to 8 bpp grayscale.
''' In all cases, pixd does not have a colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, with or without colormap; or 32 bpp rgb</param>
'''  <param name="copyflag">[in] - L_CLONE or L_COPY</param>
'''  <param name="warnflag">[in] - 1 to issue warning if colormap is removed; else 0</param>
'''   <returns>pixd 8 bpp grayscale or 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixConvertTo8Or32(
				ByVal pixs as Pix, 
				ByVal copyflag as Enumerations.L_access_storage, 
				ByVal warnflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertTo8Or32( pixs.Pointer, copyflag, warnflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3456, 1)
' pixConvert24To32()
' pixConvert24To32(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) 24 bpp rgb pix are not supported in leptonica, except for a small
''' number of formatted write operations.  The data is a byte array,
''' with pixels in order r,g,b, and padded to 32 bit boundaries
''' in each line.
''' (2) Because 24 bpp rgb pix are conveniently generated by programs
''' such as xpdf (which has SplashBitmaps that store the raster
''' data in consecutive 24-bit rgb pixels), it is useful to provide
''' 24 bpp pix that simply incorporate that data.  The only things
''' we can do with these are
''' (a) write them to file in png, jpeg, tiff and pnm
''' (b) interconvert between 24 and 32 bpp in memory (for testing).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 24 bpp rgb</param>
'''   <returns>pixd 32 bpp rgb, or NULL on error</returns>
Public Shared Function pixConvert24To32(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert24To32( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3506, 1)
' pixConvert32To24()
' pixConvert32To24(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) See pixconvert24To32().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''   <returns>pixd 24 bpp rgb, or NULL on error</returns>
Public Shared Function pixConvert32To24(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert32To24( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3559, 1)
' pixConvert32To16()
' pixConvert32To16(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The data in pixs is typically used for labelling.
''' It is an array of l_uint32 values, not rgb or rgba.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp, single component</param>
'''  <param name="type">[in] - L_LS_TWO_BYTES, L_MS_TWO_BYTES, L_CLIP_TO_FFFF</param>
'''   <returns>pixd 16 bpp , or NULL on error</returns>
Public Shared Function pixConvert32To16(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_16_bit_conversion) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp, single component")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert32To16( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3623, 1)
' pixConvert32To8()
' pixConvert32To8(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp, single component</param>
'''  <param name="type16">[in] - L_LS_TWO_BYTES, L_MS_TWO_BYTES, L_CLIP_TO_FFFF</param>
'''  <param name="type8">[in] - L_LS_BYTE, L_MS_BYTE, L_CLIP_TO_FF</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixConvert32To8(
				ByVal pixs as Pix, 
				ByVal type16 as Enumerations.L_16_bit_conversion, 
				ByVal type8 as Enumerations.L_16_bit_conversion) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp, single component")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvert32To8( pixs.Pointer, type16, type8)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3662, 1)
' pixRemoveAlpha()
' pixRemoveAlpha(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a wrapper on pixAlphaBlendUniform()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth</param>
'''   <returns>pixd        if 32 bpp rgba, pixs blended over a white background; a clone of pixs otherwise, and NULL on error</returns>
Public Shared Function pixRemoveAlpha(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveAlpha( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3699, 1)
' pixAddAlphaTo1bpp()
' pixAddAlphaTo1bpp(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) We don't use 1 bpp colormapped images with alpha in leptonica,
''' but we support generating them (here), writing to png, and reading
''' the png.  On reading, they are converted to 32 bpp RGBA.
''' (2) The background (0) pixels in pixs become fully transparent, and the
''' foreground (1) pixels are fully opaque.  Thus, pixd is a 1 bpp
''' representation of a stencil, that can be used to paint over pixels
''' of a backing image that are masked by the foreground in pixs.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - 1 bpp, can be null or equal to pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 1 bpp with colormap and non-opaque alpha, or NULL on error</returns>
Public Shared Function pixAddAlphaTo1bpp(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixAddAlphaTo1bpp( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3741, 1)
' pixConvertLossless()
' pixConvertLossless(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a lossless unpacking (depth-increasing)
''' conversion.  If ds is the depth of pixs, then
''' ~ if d LT ds, returns NULL
''' ~ if d == ds, returns a copy
''' ~ if d GT ds, does the unpacking conversion
''' (2) If pixs has a colormap, this is an error.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8 bpp, not cmapped</param>
'''  <param name="d">[in] - destination depth 2, 4 or 8</param>
'''   <returns>pixd 2, 4 or 8 bpp, or NULL on error</returns>
Public Shared Function pixConvertLossless(
				ByVal pixs as Pix, 
				ByVal d as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8 bpp, not cmapped")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertLossless( pixs.Pointer, d)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3832, 1)
' pixConvertForPSWrap()
' pixConvertForPSWrap(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) For wrapping in PostScript, we convert pixs to
''' 1 bpp, 8 bpp (gray) and 32 bpp (RGB color).
''' (2) Colormaps are removed.  For pixs with colormaps, the
''' images are converted to either 8 bpp gray or 32 bpp
''' RGB, depending on whether the colormap has color content.
''' (3) Images without colormaps, that are not 1 bpp or 32 bpp,
''' are converted to 8 bpp gray.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
'''   <returns>pixd    1, 8, or 32 bpp, or NULL on error</returns>
Public Shared Function pixConvertForPSWrap(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16, 32 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertForPSWrap( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3911, 1)
' pixConvertToSubpixelRGB()
' pixConvertToSubpixelRGB(PIX *, l_float32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixs has a colormap, it is removed based on its contents
''' to either 8 bpp gray or rgb.
''' (2) For horizontal subpixel splitting, the input image
''' is rescaled by %scaley vertically and by 3.0 times
''' %scalex horizontally.  Then each horizontal triplet
''' of pixels is mapped back to a single rgb pixel, with the
''' r, g and b values being assigned based on the pixel triplet.
''' For gray triplets, the r, g, and b values are set equal to
''' the three gray values.  For color triplets, the r, g and b
''' values are set equal to the components from the appropriate
''' subpixel.  Vertical subpixel splitting is handled similarly.
''' (3) See pixConvertGrayToSubpixelRGB() and
''' pixConvertColorToSubpixelRGB() for further details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp grayscale, 32 bpp rgb, or colormapped</param>
'''  <param name="scalex">[in] - anisotropic scaling permitted between source and destination</param>
'''  <param name="scaley">[in] - anisotropic scaling permitted between source and destination</param>
'''  <param name="order">[in] - of subpixel rgb color components in composition of pixd L_SUBPIXEL_ORDER_RGB, L_SUBPIXEL_ORDER_BGR, L_SUBPIXEL_ORDER_VRGB, L_SUBPIXEL_ORDER_VBGR</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixConvertToSubpixelRGB(
				ByVal pixs as Pix, 
				ByVal scalex as Single, 
				ByVal scaley as Single, 
				ByVal order as Enumerations.L_SUBPIXEL_ORDER) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8,16}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp grayscale, 32 bpp rgb, or colormapped")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertToSubpixelRGB( pixs.Pointer, scalex, scaley, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (3981, 1)
' pixConvertGrayToSubpixelRGB()
' pixConvertGrayToSubpixelRGB(PIX *, l_float32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixs has a colormap, it is removed to 8 bpp.
''' (2) For horizontal subpixel splitting, the input gray image
''' is rescaled by %scaley vertically and by 3.0 times
''' %scalex horizontally.  Then each horizontal triplet
''' of pixels is mapped back to a single rgb pixel, with the
''' r, g and b values being assigned from the triplet of gray values.
''' Similar operations are used for vertical subpixel splitting.
''' (3) This is a form of subpixel rendering that tends to give the
''' resulting text a sharper and somewhat chromatic display.
''' For horizontal subpixel splitting, the observable difference
''' between %order=L_SUBPIXEL_ORDER_RGB and
''' %order=L_SUBPIXEL_ORDER_BGR is reduced by optical diffusers
''' in the display that make the pixel color appear to emerge
''' from the entire pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp or colormapped</param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''  <param name="order">[in] - of subpixel rgb color components in composition of pixd L_SUBPIXEL_ORDER_RGB, L_SUBPIXEL_ORDER_BGR, L_SUBPIXEL_ORDER_VRGB, L_SUBPIXEL_ORDER_VBGR</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixConvertGrayToSubpixelRGB(
				ByVal pixs as Pix, 
				ByVal scalex as Single, 
				ByVal scaley as Single, 
				ByVal order as Enumerations.L_SUBPIXEL_ORDER) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertGrayToSubpixelRGB( pixs.Pointer, scalex, scaley, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (4086, 1)
' pixConvertColorToSubpixelRGB()
' pixConvertColorToSubpixelRGB(PIX *, l_float32, l_float32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) If pixs has a colormap, it is removed to 32 bpp rgb.
''' If the colormap has no color, pixConvertGrayToSubpixelRGB()
''' should be called instead, because it will give the same result
''' more efficiently.  The function pixConvertToSubpixelRGB()
''' will do the best thing for all cases.
''' (2) For horizontal subpixel splitting, the input rgb image
''' is rescaled by %scaley vertically and by 3.0 times
''' %scalex horizontally.  Then for each horizontal triplet
''' of pixels, the r component of the final pixel is selected
''' from the r component of the appropriate pixel in the triplet,
''' and likewise for g and b.  Vertical subpixel splitting is
''' handled similarly.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp or colormapped</param>
'''  <param name="scalex">[in] - </param>
'''  <param name="scaley">[in] - </param>
'''  <param name="order">[in] - of subpixel rgb color components in composition of pixd L_SUBPIXEL_ORDER_RGB, L_SUBPIXEL_ORDER_BGR, L_SUBPIXEL_ORDER_VRGB, L_SUBPIXEL_ORDER_VBGR</param>
'''   <returns>pixd 32 bpp, or NULL on error</returns>
Public Shared Function pixConvertColorToSubpixelRGB(
				ByVal pixs as Pix, 
				ByVal scalex as Single, 
				ByVal scaley as Single, 
				ByVal order as Enumerations.L_SUBPIXEL_ORDER) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertColorToSubpixelRGB( pixs.Pointer, scalex, scaley, order)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixconv.c (4189, 1)
' l_setNeutralBoostVal()
' l_setNeutralBoostVal(l_int32) as void
'''  <summary>
''' Notes
''' (1) This raises or lowers the selected min or max RGB component value,
''' depending on if that component is above or below this value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="val">[in] - between 1 and 255; typical value is 180</param>
Public Shared Sub l_setNeutralBoostVal(
				ByVal val as Integer)



	LeptonicaSharp.Natives.l_setNeutralBoostVal( val)

End Sub

End Class
