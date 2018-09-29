Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\colorspace.c (134, 1)
' pixConvertRGBToHSV()
' pixConvertRGBToHSV(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) For pixs = pixd, this is in-place; otherwise pixd must be NULL.
''' (2) The definition of our HSV space is given in convertRGBToHSV().
''' (3) The h, s and v values are stored in the same places as
''' the r, g and b values, respectively.  Here, they are explicitly
''' placed in the 3 MS bytes in the pixel.
''' (4) Normalizing to 1 and considering the r,g,b components,
''' a simple way to understand the HSV space is
''' ~ v = max(r,g,b)
''' ~ s = (max - min) / max
''' ~ h ~ (mid - min) / (max - min)  [apart from signs and constants]
''' (5) Normalizing to 1, some properties of the HSV space are
''' ~ For gray values (r = g = b) along the continuum between
''' black and white
''' s = 0  (becoming undefined as you approach black)
''' h is undefined everywhere
''' ~ Where one component is saturated and the others are zero
''' v = 1
''' s = 1
''' h = 0 (r = max), 1/3 (g = max), 2/3 (b = max)
''' ~ Where two components are saturated and the other is zero
''' v = 1
''' s = 1
''' h = 1/2 (if r = 0), 5/6 (if g = 0), 1/6 (if b = 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - ; if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertRGBToHSV(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToHSV( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (198, 1)
' pixConvertHSVToRGB()
' pixConvertHSVToRGB(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) For pixs = pixd, this is in-place; otherwise pixd must be NULL.
''' (2) The user takes responsibility for making sure that pixs is
''' in our HSV space.  The definition of our HSV space is given
''' in convertRGBToHSV().
''' (3) The h, s and v values are stored in the same places as
''' the r, g and b values, respectively.  Here, they are explicitly
''' placed in the 3 MS bytes in the pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - ; if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertHSVToRGB(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertHSVToRGB( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (273, 1)
' convertRGBToHSV()
' convertRGBToHSV(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The range of returned values is
''' h [0 ... 239]
''' s [0 ... 255]
''' v [0 ... 255]
''' (2) If r = g = b, the pixel is gray (s = 0), and we define h = 0.
''' (3) h wraps around, so that h = 0 and h = 240 are equivalent
''' in hue space.
''' (4) h has the following correspondence to color
''' h = 0   magenta
''' h = 40  red
''' h = 80  yellow
''' h = 120 green
''' h = 160 cyan
''' h = 200 blue
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - RGB input</param>
'''  <param name="gval">[in] - RGB input</param>
'''  <param name="bval">[in] - RGB input</param>
'''  <param name="phval">[out] - HSV values</param>
'''  <param name="psval">[out] - HSV values</param>
'''  <param name="pvval">[out] - HSV values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertRGBToHSV(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef phval as Integer, 
				ByRef psval as Integer, 
				ByRef pvval as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertRGBToHSV( rval, gval, bval, phval, psval, pvval)

	Return _Result
End Function

' SRC\colorspace.c (335, 1)
' convertHSVToRGB()
' convertHSVToRGB(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertRGBToHSV() for valid input range of HSV values
''' and their interpretation in color space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="hval">[in] - </param>
'''  <param name="sval">[in] - </param>
'''  <param name="vval">[in] - </param>
'''  <param name="prval">[out] - RGB values</param>
'''  <param name="pgval">[out] - RGB values</param>
'''  <param name="pbval">[out] - RGB values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertHSVToRGB(
				ByVal hval as Integer, 
				ByVal sval as Integer, 
				ByVal vval as Integer, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertHSVToRGB( hval, sval, vval, prval, pgval, pbval)

	Return _Result
End Function

' SRC\colorspace.c (424, 1)
' pixcmapConvertRGBToHSV()
' pixcmapConvertRGBToHSV(PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' ~ in-place transform
''' ~ See convertRGBToHSV() for def'n of HSV space.
''' ~ replaces r --GT h, g --GT s, b --GT v
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapConvertRGBToHSV(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapConvertRGBToHSV( cmap.Pointer)

	Return _Result
End Function

' SRC\colorspace.c (457, 1)
' pixcmapConvertHSVToRGB()
' pixcmapConvertHSVToRGB(PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' ~ in-place transform
''' ~ See convertRGBToHSV() for def'n of HSV space.
''' ~ replaces h --GT r, s --GT g, v --GT b
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapConvertHSVToRGB(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapConvertHSVToRGB( cmap.Pointer)

	Return _Result
End Function

' SRC\colorspace.c (492, 1)
' pixConvertRGBToHue()
' pixConvertRGBToHue(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The conversion to HSV hue is in-lined here.
''' (2) If there is a colormap, it is removed.
''' (3) If you just want the hue component, this does it
''' at about 10 Mpixels/sec/GHz, which is about
''' 2x faster than using pixConvertRGBToHSV()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp hue of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToHue(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToHue( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (568, 1)
' pixConvertRGBToSaturation()
' pixConvertRGBToSaturation(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The conversion to HSV sat is in-lined here.
''' (2) If there is a colormap, it is removed.
''' (3) If you just want the saturation component, this does it
''' at about 12 Mpixels/sec/GHz.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp sat of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToSaturation(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToSaturation( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (633, 1)
' pixConvertRGBToValue()
' pixConvertRGBToValue(PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The conversion to HSV sat is in-lined here.
''' (2) If there is a colormap, it is removed.
''' (3) If you just want the value component, this does it
''' at about 35 Mpixels/sec/GHz.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp max component intensity of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToValue(
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToValue( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (702, 1)
' pixMakeRangeMaskHS()
' pixMakeRangeMaskHS(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The pixels are selected based on the specified ranges of
''' hue and saturation.  For selection or exclusion, the pixel
''' HS component values must be within both ranges.  Care must
''' be taken in finding the hue range because of wrap-around.
''' (2) Use %regionflag == L_INCLUDE_REGION to take only those
''' pixels within the rectangular region specified in HS space.
''' Use %regionflag == L_EXCLUDE_REGION to take all pixels except
''' those within the rectangular region specified in HS space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="huecenter">[in] - center value of hue range</param>
'''  <param name="huehw">[in] - half-width of hue range</param>
'''  <param name="satcenter">[in] - center value of saturation range</param>
'''  <param name="sathw">[in] - half-width of saturation range</param>
'''  <param name="regionflag">[in] - L_INCLUDE_REGION, L_EXCLUDE_REGION</param>
'''   <returns>pixd 1 bpp mask over selected pixels, or NULL on error</returns>
Public Shared Function pixMakeRangeMaskHS(
				ByVal pixs as Pix, 
				ByVal huecenter as Integer, 
				ByVal huehw as Integer, 
				ByVal satcenter as Integer, 
				ByVal sathw as Integer, 
				ByVal regionflag as Enumerations.L_CLUDE_REGION) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeRangeMaskHS( pixs.Pointer, huecenter, huehw, satcenter, sathw, regionflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (801, 1)
' pixMakeRangeMaskHV()
' pixMakeRangeMaskHV(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The pixels are selected based on the specified ranges of
''' hue and max intensity values.  For selection or exclusion,
''' the pixel HV component values must be within both ranges.
''' Care must be taken in finding the hue range because of wrap-around.
''' (2) Use %regionflag == L_INCLUDE_REGION to take only those
''' pixels within the rectangular region specified in HV space.
''' Use %regionflag == L_EXCLUDE_REGION to take all pixels except
''' those within the rectangular region specified in HV space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="huecenter">[in] - center value of hue range</param>
'''  <param name="huehw">[in] - half-width of hue range</param>
'''  <param name="valcenter">[in] - center value of max intensity range</param>
'''  <param name="valhw">[in] - half-width of max intensity range</param>
'''  <param name="regionflag">[in] - L_INCLUDE_REGION, L_EXCLUDE_REGION</param>
'''   <returns>pixd 1 bpp mask over selected pixels, or NULL on error</returns>
Public Shared Function pixMakeRangeMaskHV(
				ByVal pixs as Pix, 
				ByVal huecenter as Integer, 
				ByVal huehw as Integer, 
				ByVal valcenter as Integer, 
				ByVal valhw as Integer, 
				ByVal regionflag as Enumerations.L_CLUDE_REGION) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeRangeMaskHV( pixs.Pointer, huecenter, huehw, valcenter, valhw, regionflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (899, 1)
' pixMakeRangeMaskSV()
' pixMakeRangeMaskSV(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The pixels are selected based on the specified ranges of
''' saturation and max intensity (val).  For selection or
''' exclusion, the pixel SV component values must be within both ranges.
''' (2) Use %regionflag == L_INCLUDE_REGION to take only those
''' pixels within the rectangular region specified in SV space.
''' Use %regionflag == L_EXCLUDE_REGION to take all pixels except
''' those within the rectangular region specified in SV space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="satcenter">[in] - center value of saturation range</param>
'''  <param name="sathw">[in] - half-width of saturation range</param>
'''  <param name="valcenter">[in] - center value of max intensity range</param>
'''  <param name="valhw">[in] - half-width of max intensity range</param>
'''  <param name="regionflag">[in] - L_INCLUDE_REGION, L_EXCLUDE_REGION</param>
'''   <returns>pixd 1 bpp mask over selected pixels, or NULL on error</returns>
Public Shared Function pixMakeRangeMaskSV(
				ByVal pixs as Pix, 
				ByVal satcenter as Integer, 
				ByVal sathw as Integer, 
				ByVal valcenter as Integer, 
				ByVal valhw as Integer, 
				ByVal regionflag as Enumerations.L_CLUDE_REGION) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeRangeMaskSV( pixs.Pointer, satcenter, sathw, valcenter, valhw, regionflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (988, 1)
' pixMakeHistoHS()
' pixMakeHistoHS(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' Notes
''' (1) pixs is a 32 bpp image in HSV colorspace; hue is in the "red"
''' byte, saturation is in the "green" byte.
''' (2) In pixd, hue is displayed vertically; saturation horizontally.
''' The dimensions of pixd are w = 256, h = 240, and the depth
''' is 32 bpp.  The value at each point is simply the number
''' of pixels found at that value of hue and saturation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor; integer</param>
'''  <param name="pnahue">[out][optional] - hue histogram</param>
'''  <param name="pnasat">[out][optional] - saturation histogram</param>
'''   <returns>pixd 32 bpp histogram in hue and saturation, or NULL on error</returns>
Public Shared Function pixMakeHistoHS(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByRef pnahue as Numa, 
				ByRef pnasat as Numa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pnahuePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnahue) Then pnahuePTR = pnahue.Pointer
Dim pnasatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasat) Then pnasatPTR = pnasat.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeHistoHS( pixs.Pointer, factor, pnahuePTR, pnasatPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnahuePTR <> IntPtr.Zero then pnahue = new Numa(pnahuePTR)
	if pnasatPTR <> IntPtr.Zero then pnasat = new Numa(pnasatPTR)

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1079, 1)
' pixMakeHistoHV()
' pixMakeHistoHV(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' Notes
''' (1) pixs is a 32 bpp image in HSV colorspace; hue is in the "red"
''' byte, max intensity ("value") is in the "blue" byte.
''' (2) In pixd, hue is displayed vertically; intensity horizontally.
''' The dimensions of pixd are w = 256, h = 240, and the depth
''' is 32 bpp.  The value at each point is simply the number
''' of pixels found at that value of hue and intensity.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor; integer</param>
'''  <param name="pnahue">[out][optional] - hue histogram</param>
'''  <param name="pnaval">[out][optional] - max intensity (value) histogram</param>
'''   <returns>pixd 32 bpp histogram in hue and value, or NULL on error</returns>
Public Shared Function pixMakeHistoHV(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByRef pnahue as Numa, 
				ByRef pnaval as Numa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pnahuePTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnahue) Then pnahuePTR = pnahue.Pointer
Dim pnavalPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaval) Then pnavalPTR = pnaval.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeHistoHV( pixs.Pointer, factor, pnahuePTR, pnavalPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnahuePTR <> IntPtr.Zero then pnahue = new Numa(pnahuePTR)
	if pnavalPTR <> IntPtr.Zero then pnaval = new Numa(pnavalPTR)

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1162, 1)
' pixMakeHistoSV()
' pixMakeHistoSV(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' Notes
''' (1) pixs is a 32 bpp image in HSV colorspace; sat is in the "green"
''' byte, max intensity ("value") is in the "blue" byte.
''' (2) In pixd, sat is displayed vertically; intensity horizontally.
''' The dimensions of pixd are w = 256, h = 256, and the depth
''' is 32 bpp.  The value at each point is simply the number
''' of pixels found at that value of saturation and intensity.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor; integer</param>
'''  <param name="pnasat">[out][optional] - sat histogram</param>
'''  <param name="pnaval">[out][optional] - max intensity (value) histogram</param>
'''   <returns>pixd 32 bpp histogram in sat and value, or NULL on error</returns>
Public Shared Function pixMakeHistoSV(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByRef pnasat as Numa, 
				ByRef pnaval as Numa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim pnasatPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnasat) Then pnasatPTR = pnasat.Pointer
Dim pnavalPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaval) Then pnavalPTR = pnaval.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMakeHistoSV( pixs.Pointer, factor, pnasatPTR, pnavalPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnasatPTR <> IntPtr.Zero then pnasat = new Numa(pnasatPTR)
	if pnavalPTR <> IntPtr.Zero then pnaval = new Numa(pnavalPTR)

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1253, 1)
' pixFindHistoPeaksHSV()
' pixFindHistoPeaksHSV(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, PTA **, NUMA **, PIXA **) as l_ok
'''  <summary>
''' Notes
''' (1) pixs is a 32 bpp histogram in a pair of HSV colorspace.  It
''' should be thought of as a single sample with 32 bps (bits/sample).
''' (2) After each peak is found, the peak is erased with a window
''' that is centered on the peak and scaled from the sliding
''' window by %erasefactor.  Typically, %erasefactor is chosen
''' to be GT 1.0.
''' (3) Data for a maximum of %npeaks is returned in %pta and %natot.
''' (4) For debugging, after the pixa is returned, display with
''' pixd = pixaDisplayTiledInRows(pixa, 32, 1000, 1.0, 0, 30, 2);
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp; HS, HV or SV histogram; not changed</param>
'''  <param name="type">[in] - L_HS_HISTO, L_HV_HISTO or L_SV_HISTO</param>
'''  <param name="width">[in] - half width of sliding window</param>
'''  <param name="height">[in] - half height of sliding window</param>
'''  <param name="npeaks">[in] - number of peaks to look for</param>
'''  <param name="erasefactor">[in] - ratio of erase window size to sliding window size</param>
'''  <param name="ppta">[out] - locations of max for each integrated peak area</param>
'''  <param name="pnatot">[out] - integrated peak areas</param>
'''  <param name="ppixa">[out][optional] - pixa for debugging; NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindHistoPeaksHSV(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_HISTO, 
				ByVal width as Integer, 
				ByVal height as Integer, 
				ByVal npeaks as Integer, 
				ByVal erasefactor as Single, 
				ByRef ppta as Pta, 
				ByRef pnatot as Numa, 
				ByRef ppixa as Pixa) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (erasefactor) then Throw New ArgumentNullException  ("erasefactor cannot be Nothing")

	Dim pptaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppta) Then pptaPTR = ppta.Pointer
	Dim pnatotPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnatot) Then pnatotPTR = pnatot.Pointer
Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindHistoPeaksHSV( pixs.Pointer, type, width, height, npeaks, erasefactor, pptaPTR, pnatotPTR, ppixaPTR)
	if pptaPTR <> IntPtr.Zero then ppta = new Pta(pptaPTR)
	if pnatotPTR <> IntPtr.Zero then pnatot = new Numa(pnatotPTR)
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)

	Return _Result
End Function

' SRC\colorspace.c (1378, 1)
' displayHSVColorRange()
' displayHSVColorRange(l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The total number of color samplings in each of the hue
''' and saturation directions is 2  nsamp + 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="hval">[in] - hue center value; in range [0 ... 240]</param>
'''  <param name="sval">[in] - saturation center value; in range [0 ... 255]</param>
'''  <param name="vval">[in] - max intensity value; in range [0 ... 255]</param>
'''  <param name="huehw">[in] - half-width of hue range; GT 0</param>
'''  <param name="sathw">[in] - half-width of saturation range; GT 0</param>
'''  <param name="nsamp">[in] - number of samplings in each half-width in hue and sat</param>
'''  <param name="factor">[in] - linear size of each color square, in pixels; GT 3</param>
'''   <returns>pixd 32 bpp set of color squares over input range, or NULL on error</returns>
Public Shared Function displayHSVColorRange(
				ByVal hval as Integer, 
				ByVal sval as Integer, 
				ByVal vval as Integer, 
				ByVal huehw as Integer, 
				ByVal sathw as Integer, 
				ByVal nsamp as Integer, 
				ByVal factor as Integer) as Pix



	Dim _Result as IntPtr = LeptonicaSharp.Natives.displayHSVColorRange( hval, sval, vval, huehw, sathw, nsamp, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1454, 1)
' pixConvertRGBToYUV()
' pixConvertRGBToYUV(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) For pixs = pixd, this is in-place; otherwise pixd must be NULL.
''' (2) The Y, U and V values are stored in the same places as
''' the r, g and b values, respectively.  Here, they are explicitly
''' placed in the 3 MS bytes in the pixel.
''' (3) Normalizing to 1 and considering the r,g,b components,
''' a simple way to understand the YUV space is
''' ~ Y = weighted sum of (r,g,b)
''' ~ U = weighted difference between Y and B
''' ~ V = weighted difference between Y and R
''' (4) Following video conventions, Y, U and V are in the range
''' Y [16, 235]
''' U [16, 240]
''' V [16, 240]
''' (5) For the coefficients in the transform matrices, see eq. 4 in
''' "Frequently Asked Questions about Color" by Charles Poynton,
''' //http//user.engineering.uiowa.edu/~aip/Misc/ColorFAQ.html
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - ; if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertRGBToYUV(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToYUV( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1517, 1)
' pixConvertYUVToRGB()
' pixConvertYUVToRGB(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) For pixs = pixd, this is in-place; otherwise pixd must be NULL.
''' (2) The user takes responsibility for making sure that pixs is
''' in YUV space.
''' (3) The Y, U and V values are stored in the same places as
''' the r, g and b values, respectively.  Here, they are explicitly
''' placed in the 3 MS bytes in the pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in]can be NULL - ; if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertYUVToRGB(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertYUVToRGB( pixdPTR, pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1582, 1)
' convertRGBToYUV()
' convertRGBToYUV(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The range of returned values is
''' Y [16 ... 235]
''' U [16 ... 240]
''' V [16 ... 240]
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - RGB input</param>
'''  <param name="gval">[in] - RGB input</param>
'''  <param name="bval">[in] - RGB input</param>
'''  <param name="pyval">[out] - YUV values</param>
'''  <param name="puval">[out] - YUV values</param>
'''  <param name="pvval">[out] - YUV values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertRGBToYUV(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pyval as Integer, 
				ByRef puval as Integer, 
				ByRef pvval as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertRGBToYUV( rval, gval, bval, pyval, puval, pvval)

	Return _Result
End Function

' SRC\colorspace.c (1630, 1)
' convertYUVToRGB()
' convertYUVToRGB(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The range of valid input values is
''' Y [16 ... 235]
''' U [16 ... 240]
''' V [16 ... 240]
''' (2) Conversion of RGB --GT YUV --GT RGB leaves the image unchanged.
''' (3) The YUV gamut is larger than the RBG gamut; many YUV values
''' will result in an invalid RGB value.  We clip individual
''' r,g,b components to the range [0, 255], and do not test input.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="yval">[in] - </param>
'''  <param name="uval">[in] - </param>
'''  <param name="vval">[in] - </param>
'''  <param name="prval">[out] - RGB values</param>
'''  <param name="pgval">[out] - RGB values</param>
'''  <param name="pbval">[out] - RGB values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertYUVToRGB(
				ByVal yval as Integer, 
				ByVal uval as Integer, 
				ByVal vval as Integer, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertYUVToRGB( yval, uval, vval, prval, pgval, pbval)

	Return _Result
End Function

' SRC\colorspace.c (1678, 1)
' pixcmapConvertRGBToYUV()
' pixcmapConvertRGBToYUV(PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' ~ in-place transform
''' ~ See convertRGBToYUV() for def'n of YUV space.
''' ~ replaces r --GT y, g --GT u, b --GT v
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapConvertRGBToYUV(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapConvertRGBToYUV( cmap.Pointer)

	Return _Result
End Function

' SRC\colorspace.c (1711, 1)
' pixcmapConvertYUVToRGB()
' pixcmapConvertYUVToRGB(PIXCMAP *) as l_ok
'''  <summary>
''' Notes
''' ~ in-place transform
''' ~ See convertRGBToYUV() for def'n of YUV space.
''' ~ replaces y --GT r, u --GT g, v --GT b
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixcmapConvertYUVToRGB(
				ByVal cmap as PixColormap) as Integer

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixcmapConvertYUVToRGB( cmap.Pointer)

	Return _Result
End Function

' SRC\colorspace.c (1762, 1)
' pixConvertRGBToXYZ()
' pixConvertRGBToXYZ(PIX *) as FPIXA *
'''  <summary>
''' Notes
''' (1) The [x,y,z] values are stored as float values in three fpix
''' that are returned in a fpixa.
''' (2) The XYZ color space was defined in 1931 as a reference model that
''' simulates human color perception.  When Y is taken as luminance,
''' the values of X and Z constitute a color plane representing
''' all the hues that can be perceived.  This gamut of colors
''' is larger than the gamuts that can be displayed or printed.
''' For example, although all rgb values map to XYZ, the converse
''' is not true.
''' (3) The value of the coefficients depends on the illuminant.  We use
''' coefficients for converting sRGB under D65 (the spectrum from
''' a 6500 degree K black body; an approximation to daylight color).
''' See, e.g.,
''' http//www.cs.rit.edu/~ncs/color/t_convert.html
''' For more general information on color transforms, see
''' http//www.brucelindbloom.com/
''' http//user.engineering.uiowa.edu/~aip/Misc/ColorFAQ.html
''' http//en.wikipedia.org/wiki/CIE_1931_color_space
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - rgb</param>
'''   <returns>fpixa xyz</returns>
Public Shared Function pixConvertRGBToXYZ(
				ByVal pixs as Pix) as FPixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToXYZ( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\colorspace.c (1821, 1)
' fpixaConvertXYZToRGB()
' fpixaConvertXYZToRGB(FPIXA *) as PIX *
'''  <summary>
''' Notes
''' (1) The xyz image is stored in three fpix.
''' (2) For values of xyz that are out of gamut for rgb, the rgb
''' components are set to the closest valid color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - three fpix x,y,z</param>
'''   <returns>pixd rgb</returns>
Public Shared Function fpixaConvertXYZToRGB(
				ByVal fpixa as FPixa) as Pix

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaConvertXYZToRGB( fpixa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (1879, 1)
' convertRGBToXYZ()
' convertRGBToXYZ(l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) These conversions are for illuminant D65 acting on linear sRGB
''' values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - rgb input</param>
'''  <param name="gval">[in] - rgb input</param>
'''  <param name="bval">[in] - rgb input</param>
'''  <param name="pfxval">[out] - xyz values</param>
'''  <param name="pfyval">[out] - xyz values</param>
'''  <param name="pfzval">[out] - xyz values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertRGBToXYZ(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pfxval as Single(), 
				ByRef pfyval as Single(), 
				ByRef pfzval as Single()) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertRGBToXYZ( rval, gval, bval, pfxval, pfyval, pfzval)

	Return _Result
End Function

' SRC\colorspace.c (1921, 1)
' convertXYZToRGB()
' convertXYZToRGB(l_float32, l_float32, l_float32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) For values of xyz that are out of gamut for rgb, at least
''' one of the r, g or b components will be either less than 0
''' or greater than 255.  For that situation
''' if blackout == 0, the individual component(s) that are out
''' of gamut will be set to 0 or 255, respectively.
''' if blackout == 1, the output color will be set to black
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fxval">[in] - </param>
'''  <param name="fyval">[in] - </param>
'''  <param name="fzval">[in] - </param>
'''  <param name="blackout">[in] - 0 to output nearest color if out of gamut; 1 to output black</param>
'''  <param name="prval">[out] - rgb values</param>
'''  <param name="pgval">[out] - rgb values</param>
'''  <param name="pbval">[out] - rgb values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertXYZToRGB(
				ByVal fxval as Single, 
				ByVal fyval as Single, 
				ByVal fzval as Single, 
				ByVal blackout as Integer, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer) as Integer

	If IsNothing (fxval) then Throw New ArgumentNullException  ("fxval cannot be Nothing")
	If IsNothing (fyval) then Throw New ArgumentNullException  ("fyval cannot be Nothing")
	If IsNothing (fzval) then Throw New ArgumentNullException  ("fzval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertXYZToRGB( fxval, fyval, fzval, blackout, prval, pgval, pbval)

	Return _Result
End Function

' SRC\colorspace.c (1982, 1)
' fpixaConvertXYZToLAB()
' fpixaConvertXYZToLAB(FPIXA *) as FPIXA *
'''  <summary>
''' Notes
''' (1) The input [x,y,z] and output [l,a,b] values are stored as
''' float values, each set in three fpix.
''' (2) The CIE LAB color space was invented in 1976, as an
''' absolute reference for specifying colors that we can
''' perceive, independently of the rendering device.  It was
''' invented to align color display and print images.
''' For information, see
''' http//www.brucelindbloom.com/
''' http//en.wikipedia.org/wiki/Lab_color_space
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixas">[in] - xyz</param>
'''   <returns>fpixa lab</returns>
Public Shared Function fpixaConvertXYZToLAB(
				ByVal fpixas as FPixa) as FPixa

	If IsNothing (fpixas) then Throw New ArgumentNullException  ("fpixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaConvertXYZToLAB( fpixas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\colorspace.c (2048, 1)
' fpixaConvertLABToXYZ()
' fpixaConvertLABToXYZ(FPIXA *) as FPIXA *
'''  <summary>
''' Notes
''' (1) The input [l,a,b] and output [x,y,z] values are stored as
''' float values, each set in three fpix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixas">[in] - lab</param>
'''   <returns>fpixa xyz</returns>
Public Shared Function fpixaConvertLABToXYZ(
				ByVal fpixas as FPixa) as FPixa

	If IsNothing (fpixas) then Throw New ArgumentNullException  ("fpixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaConvertLABToXYZ( fpixas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\colorspace.c (2109, 1)
' convertXYZToLAB()
' convertXYZToLAB(l_float32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="xval">[in] - xyz input</param>
'''  <param name="yval">[in] - xyz input</param>
'''  <param name="zval">[in] - xyz input</param>
'''  <param name="plval">[out] - lab values</param>
'''  <param name="paval">[out] - lab values</param>
'''  <param name="pbval">[out] - lab values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertXYZToLAB(
				ByVal xval as Single, 
				ByVal yval as Single, 
				ByVal zval as Single, 
				ByRef plval as Single(), 
				ByRef paval as Single(), 
				ByRef pbval as Single()) as Integer

	If IsNothing (xval) then Throw New ArgumentNullException  ("xval cannot be Nothing")
	If IsNothing (yval) then Throw New ArgumentNullException  ("yval cannot be Nothing")
	If IsNothing (zval) then Throw New ArgumentNullException  ("zval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertXYZToLAB( xval, yval, zval, plval, paval, pbval)

	Return _Result
End Function

' SRC\colorspace.c (2149, 1)
' convertLABToXYZ()
' convertLABToXYZ(l_float32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="lval">[in] - </param>
'''  <param name="aval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="pxval">[out] - xyz values</param>
'''  <param name="pyval">[out] - xyz values</param>
'''  <param name="pzval">[out] - xyz values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertLABToXYZ(
				ByVal lval as Single, 
				ByVal aval as Single, 
				ByVal bval as Single, 
				ByRef pxval as Single(), 
				ByRef pyval as Single(), 
				ByRef pzval as Single()) as Integer

	If IsNothing (lval) then Throw New ArgumentNullException  ("lval cannot be Nothing")
	If IsNothing (aval) then Throw New ArgumentNullException  ("aval cannot be Nothing")
	If IsNothing (bval) then Throw New ArgumentNullException  ("bval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertLABToXYZ( lval, aval, bval, pxval, pyval, pzval)

	Return _Result
End Function

' SRC\colorspace.c (2243, 1)
' pixConvertRGBToLAB()
' pixConvertRGBToLAB(PIX *) as FPIXA *
'''  <summary>
''' Notes
''' (1) The [l,a,b] values are stored as float values in three fpix
''' that are returned in a fpixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - rgb</param>
'''   <returns>fpixa lab</returns>
Public Shared Function pixConvertRGBToLAB(
				ByVal pixs as Pix) as FPixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConvertRGBToLAB( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FPixa(_Result)
End Function

' SRC\colorspace.c (2300, 1)
' fpixaConvertLABToRGB()
' fpixaConvertLABToRGB(FPIXA *) as PIX *
'''  <summary>
''' Notes
''' (1) The lab image is stored in three fpix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fpixa">[in] - three fpix l,a,b</param>
'''   <returns>pixd rgb</returns>
Public Shared Function fpixaConvertLABToRGB(
				ByVal fpixa as FPixa) as Pix

	If IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.fpixaConvertLABToRGB( fpixa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorspace.c (2358, 1)
' convertRGBToLAB()
' convertRGBToLAB(l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) These conversions are for illuminant D65 acting on linear sRGB
''' values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rval">[in] - rgb input</param>
'''  <param name="gval">[in] - rgb input</param>
'''  <param name="bval">[in] - rgb input</param>
'''  <param name="pflval">[out] - lab values</param>
'''  <param name="pfaval">[out] - lab values</param>
'''  <param name="pfbval">[out] - lab values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertRGBToLAB(
				ByVal rval as Integer, 
				ByVal gval as Integer, 
				ByVal bval as Integer, 
				ByRef pflval as Single(), 
				ByRef pfaval as Single(), 
				ByRef pfbval as Single()) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.convertRGBToLAB( rval, gval, bval, pflval, pfaval, pfbval)

	Return _Result
End Function

' SRC\colorspace.c (2395, 1)
' convertLABToRGB()
' convertLABToRGB(l_float32, l_float32, l_float32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) For values of lab that are out of gamut for rgb, the rgb
''' components are set to the closest valid color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="flval">[in] - </param>
'''  <param name="faval">[in] - </param>
'''  <param name="fbval">[in] - </param>
'''  <param name="prval">[out] - rgb values</param>
'''  <param name="pgval">[out] - rgb values</param>
'''  <param name="pbval">[out] - rgb values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertLABToRGB(
				ByVal flval as Single, 
				ByVal faval as Single, 
				ByVal fbval as Single, 
				ByRef prval as Integer, 
				ByRef pgval as Integer, 
				ByRef pbval as Integer) as Integer

	If IsNothing (flval) then Throw New ArgumentNullException  ("flval cannot be Nothing")
	If IsNothing (faval) then Throw New ArgumentNullException  ("faval cannot be Nothing")
	If IsNothing (fbval) then Throw New ArgumentNullException  ("fbval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertLABToRGB( flval, faval, fbval, prval, pgval, pbval)

	Return _Result
End Function

End Class
