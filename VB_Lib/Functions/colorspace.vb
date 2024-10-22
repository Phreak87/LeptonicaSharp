Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' colorspace.c (134, 1)
' pixConvertRGBToHSV(pixd, pixs) as Pix
' pixConvertRGBToHSV(PIX *, PIX *) as PIX *
'''  <summary>
''' (1) For pixs = pixd, this is in-place otherwise pixd must be NULL.<para/>
'''
'''(2) The definition of our HSV space is given in convertRGBToHSV().<para/>
'''
'''(3) The h, s and v values are stored in the same places as
'''the r, g and b values, respectively.  Here, they are explicitly
'''placed in the 3 MS bytes in the pixel.<para/>
'''
'''(4) Normalizing to 1 and considering the r,g,b components,
'''a simple way to understand the HSV space is:
'''~ v = max(r,g,b)
'''~ s = (max - min) / max
'''~ h ~ (mid - min) / (max - min)  [apart from signs and constants]<para/>
'''
'''(5) Normalizing to 1, some properties of the HSV space are:
'''~ For gray values (r = g = b) along the continuum between
'''black and white:
'''s = 0  (becoming undefined as you approach black)
'''h is undefined everywhere
'''~ Where one component is saturated and the others are zero:
'''v = 1
'''s = 1
'''h = 0 (r = max), 1/3 (g = max), 2/3 (b = max)
'''~ Where two components are saturated and the other is zero:
'''v = 1
'''s = 1
'''h = 1/2 (if r = 0), 5/6 (if g = 0), 1/6 (if b = 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToHSV/*"/>
'''  <param name="pixd">[in]can be NULL - if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertRGBToHSV(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixConvertRGBToHSV(pixdPtr, pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (198, 1)
' pixConvertHSVToRGB(pixd, pixs) as Pix
' pixConvertHSVToRGB(PIX *, PIX *) as PIX *
'''  <summary>
''' (1) For pixs = pixd, this is in-place otherwise pixd must be NULL.<para/>
'''
'''(2) The user takes responsibility for making sure that pixs is
'''in our HSV space.  The definition of our HSV space is given
'''in convertRGBToHSV().<para/>
'''
'''(3) The h, s and v values are stored in the same places as
'''the r, g and b values, respectively.  Here, they are explicitly
'''placed in the 3 MS bytes in the pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertHSVToRGB/*"/>
'''  <param name="pixd">[in]can be NULL - if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertHSVToRGB(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixConvertHSVToRGB(pixdPtr, pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (273, 1)
' convertRGBToHSV(rval, gval, bval, phval, psval, pvval) as Integer
' convertRGBToHSV(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The range of returned values is:
'''h [0 ... 239]
'''s [0 ... 255]
'''v [0 ... 255]<para/>
'''
'''(2) If r = g = b, the pixel is gray (s = 0), and we define h = 0.<para/>
'''
'''(3) h wraps around, so that h = 0 and h = 240 are equivalent
'''in hue space.<para/>
'''
'''(4) h has the following correspondence to color:
'''h = 0 magenta
'''h = 40  red
'''h = 80  yellow
'''h = 120 green
'''h = 160 cyan
'''h = 200 blue
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertRGBToHSV/*"/>
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
				<Out()>  ByRef phval as Integer, 
				<Out()>  ByRef psval as Integer, 
				<Out()>  ByRef pvval as Integer) as Integer


	Dim _Result as Integer = Natives.convertRGBToHSV(  rval,   gval,   bval,   phval,   psval,   pvval)
	
	return _Result
End Function

' colorspace.c (335, 1)
' convertHSVToRGB(hval, sval, vval, prval, pgval, pbval) as Integer
' convertHSVToRGB(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) See convertRGBToHSV() for valid input range of HSV values
'''and their interpretation in color space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertHSVToRGB/*"/>
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
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer) as Integer


	Dim _Result as Integer = Natives.convertHSVToRGB(  hval,   sval,   vval,   prval,   pgval,   pbval)
	
	return _Result
End Function

' colorspace.c (424, 1)
' pixcmapConvertRGBToHSV(cmap) as Integer
' pixcmapConvertRGBToHSV(PIXCMAP *) as l_ok
'''  <summary>
''' ~ in-place transform
'''~ See convertRGBToHSV() for def'n of HSV space.
'''~ replaces: r to h, g to s, b to v
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertRGBToHSV/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapConvertRGBToHSV(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapConvertRGBToHSV(cmap.Pointer)
	
	return _Result
End Function

' colorspace.c (457, 1)
' pixcmapConvertHSVToRGB(cmap) as Integer
' pixcmapConvertHSVToRGB(PIXCMAP *) as l_ok
'''  <summary>
''' ~ in-place transform
'''~ See convertRGBToHSV() for def'n of HSV space.
'''~ replaces: h to r, s to g, v to b
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertHSVToRGB/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapConvertHSVToRGB(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapConvertHSVToRGB(cmap.Pointer)
	
	return _Result
End Function

' colorspace.c (492, 1)
' pixConvertRGBToHue(pixs) as Pix
' pixConvertRGBToHue(PIX *) as PIX *
'''  <summary>
''' (1) The conversion to HSV hue is in-lined here.<para/>
'''
'''(2) If there is a colormap, it is removed.<para/>
'''
'''(3) If you just want the hue component, this does it
'''at about 10 Mpixels/sec/GHz, which is about
'''2x faster than using pixConvertRGBToHSV()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToHue/*"/>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp hue of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToHue(
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixConvertRGBToHue(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (568, 1)
' pixConvertRGBToSaturation(pixs) as Pix
' pixConvertRGBToSaturation(PIX *) as PIX *
'''  <summary>
''' (1) The conversion to HSV sat is in-lined here.<para/>
'''
'''(2) If there is a colormap, it is removed.<para/>
'''
'''(3) If you just want the saturation component, this does it
'''at about 12 Mpixels/sec/GHz.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToSaturation/*"/>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp sat of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToSaturation(
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixConvertRGBToSaturation(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (633, 1)
' pixConvertRGBToValue(pixs) as Pix
' pixConvertRGBToValue(PIX *) as PIX *
'''  <summary>
''' (1) The conversion to HSV sat is in-lined here.<para/>
'''
'''(2) If there is a colormap, it is removed.<para/>
'''
'''(3) If you just want the value component, this does it
'''at about 35 Mpixels/sec/GHz.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToValue/*"/>
'''  <param name="pixs">[in] - 32 bpp RGB or 8 bpp with colormap</param>
'''   <returns>pixd 8 bpp max component intensity of HSV, or NULL on error</returns>
Public Shared Function pixConvertRGBToValue(
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixConvertRGBToValue(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (702, 1)
' pixMakeRangeMaskHS(pixs, huecenter, huehw, satcenter, sathw, regionflag) as Pix
' pixMakeRangeMaskHS(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The pixels are selected based on the specified ranges of
'''hue and saturation.  For selection or exclusion, the pixel
'''HS component values must be within both ranges.  Care must
'''be taken in finding the hue range because of wrap-around.<para/>
'''
'''(2) Use %regionflag == L_INCLUDE_REGION to take only those
'''pixels within the rectangular region specified in HS space.
'''Use %regionflag == L_EXCLUDE_REGION to take all pixels except
'''those within the rectangular region specified in HS space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeRangeMaskHS/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")
	Dim _Result as IntPtr = Natives.pixMakeRangeMaskHS(pixs.Pointer,   huecenter,   huehw,   satcenter,   sathw,   regionflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (801, 1)
' pixMakeRangeMaskHV(pixs, huecenter, huehw, valcenter, valhw, regionflag) as Pix
' pixMakeRangeMaskHV(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The pixels are selected based on the specified ranges of
'''hue and max intensity values.  For selection or exclusion,
'''the pixel HV component values must be within both ranges.
'''Care must be taken in finding the hue range because of wrap-around.<para/>
'''
'''(2) Use %regionflag == L_INCLUDE_REGION to take only those
'''pixels within the rectangular region specified in HV space.
'''Use %regionflag == L_EXCLUDE_REGION to take all pixels except
'''those within the rectangular region specified in HV space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeRangeMaskHV/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")
	Dim _Result as IntPtr = Natives.pixMakeRangeMaskHV(pixs.Pointer,   huecenter,   huehw,   valcenter,   valhw,   regionflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (899, 1)
' pixMakeRangeMaskSV(pixs, satcenter, sathw, valcenter, valhw, regionflag) as Pix
' pixMakeRangeMaskSV(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The pixels are selected based on the specified ranges of
'''saturation and max intensity (val).  For selection or
'''exclusion, the pixel SV component values must be within both ranges.<para/>
'''
'''(2) Use %regionflag == L_INCLUDE_REGION to take only those
'''pixels within the rectangular region specified in SV space.
'''Use %regionflag == L_EXCLUDE_REGION to take all pixels except
'''those within the rectangular region specified in SV space.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeRangeMaskSV/*"/>
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


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")
	Dim _Result as IntPtr = Natives.pixMakeRangeMaskSV(pixs.Pointer,   satcenter,   sathw,   valcenter,   valhw,   regionflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (988, 1)
' pixMakeHistoHS(pixs, factor, pnahue, pnasat) as Pix
' pixMakeHistoHS(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' (1) pixs is a 32 bpp image in HSV colorspace hue is in the "red"
'''byte, saturation is in the "green" byte.<para/>
'''
'''(2) In pixd, hue is displayed vertically saturation horizontally.
'''The dimensions of pixd are w = 256, h = 240, and the depth
'''is 32 bpp.  The value at each point is simply the number
'''of pixels found at that value of hue and saturation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeHistoHS/*"/>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor integer</param>
'''  <param name="pnahue">[out][optional] - hue histogram</param>
'''  <param name="pnasat">[out][optional] - saturation histogram</param>
'''   <returns>pixd 32 bpp histogram in hue and saturation, or NULL on error</returns>
Public Shared Function pixMakeHistoHS(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				<Out()> Optional  ByRef pnahue as Numa = Nothing, 
				<Out()> Optional  ByRef pnasat as Numa = Nothing) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnahuePtr as IntPtr = IntPtr.Zero
	Dim pnasatPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixMakeHistoHS(pixs.Pointer,   factor, pnahuePtr, pnasatPtr)
	
	if pnahuePtr = IntPtr.Zero then pnahue = Nothing else pnahue = new Numa(pnahuePtr)
	if pnasatPtr = IntPtr.Zero then pnasat = Nothing else pnasat = new Numa(pnasatPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1079, 1)
' pixMakeHistoHV(pixs, factor, pnahue, pnaval) as Pix
' pixMakeHistoHV(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' (1) pixs is a 32 bpp image in HSV colorspace hue is in the "red"
'''byte, max intensity ("value") is in the "blue" byte.<para/>
'''
'''(2) In pixd, hue is displayed vertically intensity horizontally.
'''The dimensions of pixd are w = 256, h = 240, and the depth
'''is 32 bpp.  The value at each point is simply the number
'''of pixels found at that value of hue and intensity.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeHistoHV/*"/>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor integer</param>
'''  <param name="pnahue">[out][optional] - hue histogram</param>
'''  <param name="pnaval">[out][optional] - max intensity (value) histogram</param>
'''   <returns>pixd 32 bpp histogram in hue and value, or NULL on error</returns>
Public Shared Function pixMakeHistoHV(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				<Out()> Optional  ByRef pnahue as Numa = Nothing, 
				<Out()> Optional  ByRef pnaval as Numa = Nothing) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnahuePtr as IntPtr = IntPtr.Zero
	Dim pnavalPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixMakeHistoHV(pixs.Pointer,   factor, pnahuePtr, pnavalPtr)
	
	if pnahuePtr = IntPtr.Zero then pnahue = Nothing else pnahue = new Numa(pnahuePtr)
	if pnavalPtr = IntPtr.Zero then pnaval = Nothing else pnaval = new Numa(pnavalPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1162, 1)
' pixMakeHistoSV(pixs, factor, pnasat, pnaval) as Pix
' pixMakeHistoSV(PIX *, l_int32, NUMA **, NUMA **) as PIX *
'''  <summary>
''' (1) pixs is a 32 bpp image in HSV colorspace sat is in the "green"
'''byte, max intensity ("value") is in the "blue" byte.<para/>
'''
'''(2) In pixd, sat is displayed vertically intensity horizontally.
'''The dimensions of pixd are w = 256, h = 256, and the depth
'''is 32 bpp.  The value at each point is simply the number
'''of pixels found at that value of saturation and intensity.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeHistoSV/*"/>
'''  <param name="pixs">[in] - HSV colorspace</param>
'''  <param name="factor">[in] - subsampling factor integer</param>
'''  <param name="pnasat">[out][optional] - sat histogram</param>
'''  <param name="pnaval">[out][optional] - max intensity (value) histogram</param>
'''   <returns>pixd 32 bpp histogram in sat and value, or NULL on error</returns>
Public Shared Function pixMakeHistoSV(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				<Out()> Optional  ByRef pnasat as Numa = Nothing, 
				<Out()> Optional  ByRef pnaval as Numa = Nothing) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pnasatPtr as IntPtr = IntPtr.Zero
	Dim pnavalPtr as IntPtr = IntPtr.Zero

	Dim _Result as IntPtr = Natives.pixMakeHistoSV(pixs.Pointer,   factor, pnasatPtr, pnavalPtr)
	
	if pnasatPtr = IntPtr.Zero then pnasat = Nothing else pnasat = new Numa(pnasatPtr)
	if pnavalPtr = IntPtr.Zero then pnaval = Nothing else pnaval = new Numa(pnavalPtr)
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1253, 1)
' pixFindHistoPeaksHSV(pixs, type, width, height, npeaks, erasefactor, ppta, pnatot, ppixa) as Integer
' pixFindHistoPeaksHSV(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, PTA **, NUMA **, PIXA **) as l_ok
'''  <summary>
''' (1) pixs is a 32 bpp histogram in a pair of HSV colorspace.  It
'''should be thought of as a single sample with 32 bps (bits/sample).<para/>
'''
'''(2) After each peak is found, the peak is erased with a window
'''that is centered on the peak and scaled from the sliding
'''window by %erasefactor.  Typically, %erasefactor is chosen
'''to be  is greater  1.0.<para/>
'''
'''(3) Data for a maximum of %npeaks is returned in %pta and %natot.<para/>
'''
'''(4) For debugging, after the pixa is returned, display with:
'''pixd = pixaDisplayTiledInRows(pixa, 32, 1000, 1.0, 0, 30, 2)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindHistoPeaksHSV/*"/>
'''  <param name="pixs">[in] - 32 bpp HS, HV or SV histogram not changed</param>
'''  <param name="type">[in] - L_HS_HISTO, L_HV_HISTO or L_SV_HISTO</param>
'''  <param name="width">[in] - half width of sliding window</param>
'''  <param name="height">[in] - half height of sliding window</param>
'''  <param name="npeaks">[in] - number of peaks to look for</param>
'''  <param name="erasefactor">[in] - ratio of erase window size to sliding window size</param>
'''  <param name="ppta">[out] - locations of max for each integrated peak area</param>
'''  <param name="pnatot">[out] - integrated peak areas</param>
'''  <param name="ppixa">[out][optional] - pixa for debugging NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindHistoPeaksHSV(
				ByVal pixs as Pix, 
				ByVal type as Enumerations.L_HISTO, 
				ByVal width as Integer, 
				ByVal height as Integer, 
				ByVal npeaks as Integer, 
				ByVal erasefactor as Single, 
				<Out()>  ByRef ppta as Pta, 
				<Out()>  ByRef pnatot as Numa, 
				<Out()> Optional  ByRef ppixa as Pixa = Nothing) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pptaPtr as IntPtr = IntPtr.Zero
	Dim pnatotPtr as IntPtr = IntPtr.Zero
	Dim ppixaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixFindHistoPeaksHSV(pixs.Pointer,   type,   width,   height,   npeaks,   erasefactor, pptaPtr, pnatotPtr, ppixaPtr)
	
	if pptaPtr = IntPtr.Zero then ppta = Nothing else ppta = new Pta(pptaPtr)
	if pnatotPtr = IntPtr.Zero then pnatot = Nothing else pnatot = new Numa(pnatotPtr)
	if ppixaPtr = IntPtr.Zero then ppixa = Nothing else ppixa = new Pixa(ppixaPtr)
	return _Result
End Function

' colorspace.c (1378, 1)
' displayHSVColorRange(hval, sval, vval, huehw, sathw, nsamp, factor) as Pix
' displayHSVColorRange(l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) The total number of color samplings in each of the hue
'''and saturation directions is 2  nsamp + 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/displayHSVColorRange/*"/>
'''  <param name="hval">[in] - hue center value in range [0 ... 240]</param>
'''  <param name="sval">[in] - saturation center value in range [0 ... 255]</param>
'''  <param name="vval">[in] - max intensity value in range [0 ... 255]</param>
'''  <param name="huehw">[in] - half-width of hue range  is greater  0</param>
'''  <param name="sathw">[in] - half-width of saturation range  is greater  0</param>
'''  <param name="nsamp">[in] - number of samplings in each half-width in hue and sat</param>
'''  <param name="factor">[in] - linear size of each color square, in pixels  is greater  3</param>
'''   <returns>pixd 32 bpp set of color squares over input range, or NULL on error</returns>
Public Shared Function displayHSVColorRange(
				ByVal hval as Integer, 
				ByVal sval as Integer, 
				ByVal vval as Integer, 
				ByVal huehw as Integer, 
				ByVal sathw as Integer, 
				ByVal nsamp as Integer, 
				ByVal factor as Integer) as Pix


	Dim _Result as IntPtr = Natives.displayHSVColorRange(  hval,   sval,   vval,   huehw,   sathw,   nsamp,   factor)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1454, 1)
' pixConvertRGBToYUV(pixd, pixs) as Pix
' pixConvertRGBToYUV(PIX *, PIX *) as PIX *
'''  <summary>
''' (1) For pixs = pixd, this is in-place otherwise pixd must be NULL.<para/>
'''
'''(2) The Y, U and V values are stored in the same places as
'''the r, g and b values, respectively.  Here, they are explicitly
'''placed in the 3 MS bytes in the pixel.<para/>
'''
'''(3) Normalizing to 1 and considering the r,g,b components,
'''a simple way to understand the YUV space is:
'''~ Y = weighted sum of (r,g,b)
'''~ U = weighted difference between Y and B
'''~ V = weighted difference between Y and R<para/>
'''
'''(4) Following video conventions, Y, U and V are in the range:
'''Y: [16, 235]
'''U: [16, 240]
'''V: [16, 240]<para/>
'''
'''(5) For the coefficients in the transform matrices, see eq. 4 in
'''"Frequently Asked Questions about Color" by Charles Poynton,
'''//http://user.engineering.uiowa.edu/~aip/Misc/ColorFAQ.html
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToYUV/*"/>
'''  <param name="pixd">[in]can be NULL - if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertRGBToYUV(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixConvertRGBToYUV(pixdPtr, pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1517, 1)
' pixConvertYUVToRGB(pixd, pixs) as Pix
' pixConvertYUVToRGB(PIX *, PIX *) as PIX *
'''  <summary>
''' (1) For pixs = pixd, this is in-place otherwise pixd must be NULL.<para/>
'''
'''(2) The user takes responsibility for making sure that pixs is
'''in YUV space.<para/>
'''
'''(3) The Y, U and V values are stored in the same places as
'''the r, g and b values, respectively.  Here, they are explicitly
'''placed in the 3 MS bytes in the pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertYUVToRGB/*"/>
'''  <param name="pixd">[in]can be NULL - if not NULL, must == pixs</param>
'''  <param name="pixs">[in] - </param>
'''   <returns>pixd always</returns>
Public Shared Function pixConvertYUVToRGB(
				ByVal pixd as Pix, 
				ByVal pixs as Pix) as Pix


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim pixdPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer

	Dim _Result as IntPtr = Natives.pixConvertYUVToRGB(pixdPtr, pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1582, 1)
' convertRGBToYUV(rval, gval, bval, pyval, puval, pvval) as Integer
' convertRGBToYUV(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The range of returned values is:
'''Y [16 ... 235]
'''U [16 ... 240]
'''V [16 ... 240]
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertRGBToYUV/*"/>
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
				<Out()>  ByRef pyval as Integer, 
				<Out()>  ByRef puval as Integer, 
				<Out()>  ByRef pvval as Integer) as Integer


	Dim _Result as Integer = Natives.convertRGBToYUV(  rval,   gval,   bval,   pyval,   puval,   pvval)
	
	return _Result
End Function

' colorspace.c (1630, 1)
' convertYUVToRGB(yval, uval, vval, prval, pgval, pbval) as Integer
' convertYUVToRGB(l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The range of valid input values is:
'''Y [16 ... 235]
'''U [16 ... 240]
'''V [16 ... 240]<para/>
'''
'''(2) Conversion of RGB to YUV to RGB leaves the image unchanged.<para/>
'''
'''(3) The YUV gamut is larger than the RBG gamut many YUV values
'''will result in an invalid RGB value.  We clip individual
'''r,g,b components to the range [0, 255], and do not test input.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertYUVToRGB/*"/>
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
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer) as Integer


	Dim _Result as Integer = Natives.convertYUVToRGB(  yval,   uval,   vval,   prval,   pgval,   pbval)
	
	return _Result
End Function

' colorspace.c (1678, 1)
' pixcmapConvertRGBToYUV(cmap) as Integer
' pixcmapConvertRGBToYUV(PIXCMAP *) as l_ok
'''  <summary>
''' ~ in-place transform
'''~ See convertRGBToYUV() for def'n of YUV space.
'''~ replaces: r to y, g to u, b to v
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertRGBToYUV/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapConvertRGBToYUV(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapConvertRGBToYUV(cmap.Pointer)
	
	return _Result
End Function

' colorspace.c (1711, 1)
' pixcmapConvertYUVToRGB(cmap) as Integer
' pixcmapConvertYUVToRGB(PIXCMAP *) as l_ok
'''  <summary>
''' ~ in-place transform
'''~ See convertRGBToYUV() for def'n of YUV space.
'''~ replaces: y to r, u to g, v to b
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertYUVToRGB/*"/>
'''  <param name="cmap">[in] - colormap</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcmapConvertYUVToRGB(
				ByVal cmap as PixColormap) as Integer


if IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")
	Dim _Result as Integer = Natives.pixcmapConvertYUVToRGB(cmap.Pointer)
	
	return _Result
End Function

' colorspace.c (1762, 1)
' pixConvertRGBToXYZ(pixs) as FPixa
' pixConvertRGBToXYZ(PIX *) as FPIXA *
'''  <summary>
''' (1) The [x,y,z] values are stored as float values in three fpix
'''that are returned in a fpixa.<para/>
'''
'''(2) The XYZ color space was defined in 1931 as a reference model that
'''simulates human color perception.  When Y is taken as luminance,
'''the values of X and Z constitute a color plane representing
'''all the hues that can be perceived.  This gamut of colors
'''is larger than the gamuts that can be displayed or printed.
'''For example, although all rgb values map to XYZ, the converse
'''is not true.<para/>
'''
'''(3) The value of the coefficients depends on the illuminant.  We use
'''coefficients for converting sRGB under D65 (the spectrum from
'''a 6500 degree K black body an approximation to daylight color).
'''See, e.g.,
'''http://www.cs.rit.edu/~ncs/color/t_convert.html
'''For more general information on color transforms, see:
'''http://www.brucelindbloom.com/
'''http://user.engineering.uiowa.edu/~aip/Misc/ColorFAQ.html
'''http://en.wikipedia.org/wiki/CIE_1931_color_space
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToXYZ/*"/>
'''  <param name="pixs">[in] - rgb</param>
'''   <returns>fpixa xyz</returns>
Public Shared Function pixConvertRGBToXYZ(
				ByVal pixs as Pix) as FPixa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixConvertRGBToXYZ(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' colorspace.c (1821, 1)
' fpixaConvertXYZToRGB(fpixa) as Pix
' fpixaConvertXYZToRGB(FPIXA *) as PIX *
'''  <summary>
''' (1) The xyz image is stored in three fpix.<para/>
'''
'''(2) For values of xyz that are out of gamut for rgb, the rgb
'''components are set to the closest valid color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaConvertXYZToRGB/*"/>
'''  <param name="fpixa">[in] - three fpix: x,y,z</param>
'''   <returns>pixd rgb</returns>
Public Shared Function fpixaConvertXYZToRGB(
				ByVal fpixa as FPixa) as Pix


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaConvertXYZToRGB(fpixa.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (1879, 1)
' convertRGBToXYZ(rval, gval, bval, pfxval, pfyval, pfzval) as Integer
' convertRGBToXYZ(l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) These conversions are for illuminant D65 acting on linear sRGB
'''values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertRGBToXYZ/*"/>
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
				<Out()>  ByRef pfxval as Single, 
				<Out()>  ByRef pfyval as Single, 
				<Out()>  ByRef pfzval as Single) as Integer


	Dim _Result as Integer = Natives.convertRGBToXYZ(  rval,   gval,   bval,   pfxval,   pfyval,   pfzval)
	
	return _Result
End Function

' colorspace.c (1921, 1)
' convertXYZToRGB(fxval, fyval, fzval, blackout, prval, pgval, pbval) as Integer
' convertXYZToRGB(l_float32, l_float32, l_float32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) For values of xyz that are out of gamut for rgb, at least
'''one of the r, g or b components will be either less than 0
'''or greater than 255.  For that situation:
'''if blackout == 0, the individual component(s) that are out
'''of gamut will be set to 0 or 255, respectively.
'''if blackout == 1, the output color will be set to black
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertXYZToRGB/*"/>
'''  <param name="fxval">[in] - </param>
'''  <param name="fyval">[in] - </param>
'''  <param name="fzval">[in] - </param>
'''  <param name="blackout">[in] - 0 to output nearest color if out of gamut 1 to output black</param>
'''  <param name="prval">[out] - rgb values</param>
'''  <param name="pgval">[out] - rgb values</param>
'''  <param name="pbval">[out] - rgb values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertXYZToRGB(
				ByVal fxval as Single, 
				ByVal fyval as Single, 
				ByVal fzval as Single, 
				ByVal blackout as Integer, 
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer) as Integer


	Dim _Result as Integer = Natives.convertXYZToRGB(  fxval,   fyval,   fzval,   blackout,   prval,   pgval,   pbval)
	
	return _Result
End Function

' colorspace.c (1982, 1)
' fpixaConvertXYZToLAB(fpixas) as FPixa
' fpixaConvertXYZToLAB(FPIXA *) as FPIXA *
'''  <summary>
''' (1) The input [x,y,z] and output [l,a,b] values are stored as
'''float values, each set in three fpix.<para/>
'''
'''(2) The CIE LAB color space was invented in 1976, as an
'''absolute reference for specifying colors that we can
'''perceive, independently of the rendering device.  It was
'''invented to align color display and print images.
'''For information, see:
'''http://www.brucelindbloom.com/
'''http://en.wikipedia.org/wiki/Lab_color_space
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaConvertXYZToLAB/*"/>
'''  <param name="fpixas">[in] - xyz</param>
'''   <returns>fpixa lab</returns>
Public Shared Function fpixaConvertXYZToLAB(
				ByVal fpixas as FPixa) as FPixa


if IsNothing (fpixas) then Throw New ArgumentNullException  ("fpixas cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaConvertXYZToLAB(fpixas.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' colorspace.c (2048, 1)
' fpixaConvertLABToXYZ(fpixas) as FPixa
' fpixaConvertLABToXYZ(FPIXA *) as FPIXA *
'''  <summary>
''' (1) The input [l,a,b] and output [x,y,z] values are stored as
'''float values, each set in three fpix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaConvertLABToXYZ/*"/>
'''  <param name="fpixas">[in] - lab</param>
'''   <returns>fpixa xyz</returns>
Public Shared Function fpixaConvertLABToXYZ(
				ByVal fpixas as FPixa) as FPixa


if IsNothing (fpixas) then Throw New ArgumentNullException  ("fpixas cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaConvertLABToXYZ(fpixas.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' colorspace.c (2109, 1)
' convertXYZToLAB(xval, yval, zval, plval, paval, pbval) as Integer
' convertXYZToLAB(l_float32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' convertXYZToLAB()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertXYZToLAB/*"/>
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
				<Out()>  ByRef plval as Single, 
				<Out()>  ByRef paval as Single, 
				<Out()>  ByRef pbval as Single) as Integer


	Dim _Result as Integer = Natives.convertXYZToLAB(  xval,   yval,   zval,   plval,   paval,   pbval)
	
	return _Result
End Function

' colorspace.c (2149, 1)
' convertLABToXYZ(lval, aval, bval, pxval, pyval, pzval) as Integer
' convertLABToXYZ(l_float32, l_float32, l_float32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' convertLABToXYZ()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertLABToXYZ/*"/>
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
				<Out()>  ByRef pxval as Single, 
				<Out()>  ByRef pyval as Single, 
				<Out()>  ByRef pzval as Single) as Integer


	Dim _Result as Integer = Natives.convertLABToXYZ(  lval,   aval,   bval,   pxval,   pyval,   pzval)
	
	return _Result
End Function

' colorspace.c (2243, 1)
' pixConvertRGBToLAB(pixs) as FPixa
' pixConvertRGBToLAB(PIX *) as FPIXA *
'''  <summary>
''' (1) The [l,a,b] values are stored as float values in three fpix
'''that are returned in a fpixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToLAB/*"/>
'''  <param name="pixs">[in] - rgb</param>
'''   <returns>fpixa lab</returns>
Public Shared Function pixConvertRGBToLAB(
				ByVal pixs as Pix) as FPixa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixConvertRGBToLAB(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new FPixa(_Result)
End Function

' colorspace.c (2300, 1)
' fpixaConvertLABToRGB(fpixa) as Pix
' fpixaConvertLABToRGB(FPIXA *) as PIX *
'''  <summary>
''' (1) The lab image is stored in three fpix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fpixaConvertLABToRGB/*"/>
'''  <param name="fpixa">[in] - three fpix: l,a,b</param>
'''   <returns>pixd rgb</returns>
Public Shared Function fpixaConvertLABToRGB(
				ByVal fpixa as FPixa) as Pix


if IsNothing (fpixa) then Throw New ArgumentNullException  ("fpixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.fpixaConvertLABToRGB(fpixa.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' colorspace.c (2358, 1)
' convertRGBToLAB(rval, gval, bval, pflval, pfaval, pfbval) as Integer
' convertRGBToLAB(l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' (1) These conversions are for illuminant D65 acting on linear sRGB
'''values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertRGBToLAB/*"/>
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
				<Out()>  ByRef pflval as Single, 
				<Out()>  ByRef pfaval as Single, 
				<Out()>  ByRef pfbval as Single) as Integer


	Dim _Result as Integer = Natives.convertRGBToLAB(  rval,   gval,   bval,   pflval,   pfaval,   pfbval)
	
	return _Result
End Function

' colorspace.c (2395, 1)
' convertLABToRGB(flval, faval, fbval, prval, pgval, pbval) as Integer
' convertLABToRGB(l_float32, l_float32, l_float32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) For values of lab that are out of gamut for rgb, the rgb
'''components are set to the closest valid color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertLABToRGB/*"/>
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
				<Out()>  ByRef prval as Integer, 
				<Out()>  ByRef pgval as Integer, 
				<Out()>  ByRef pbval as Integer) as Integer


	Dim _Result as Integer = Natives.convertLABToRGB(  flval,   faval,   fbval,   prval,   pgval,   pbval)
	
	return _Result
End Function

End Class


