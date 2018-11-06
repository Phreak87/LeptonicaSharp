Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\colorcontent.c (179, 1)
' pixColorContent(pixs, rwhite, gwhite, bwhite, mingray, ppixr, ppixg, ppixb) as Integer
' pixColorContent(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns the color content in each component, which is<para/>
''' a measure of the deviation from gray, and is defined<para/>
''' as the difference between the component and the average of<para/>
''' the other two components.  See the discussion at the<para/>
''' top of this file.<para/>
''' (2) The three numbers (rwhite, gwhite and bwhite) can be thought<para/>
''' of as the values in the image corresponding to white.<para/>
''' They are used to compensate for an unbalanced color white point.<para/>
''' They must either be all 0 or all non-zero.  To turn this<para/>
''' off, set them all to 0.<para/>
''' (3) If the maximum component after white point correction,<para/>
''' max(r,g,b), is less than mingray, all color components<para/>
''' for that pixel are set to zero.<para/>
''' Use mingray = 0 to turn off this filtering of dark pixels.<para/>
''' (4) Therefore, use 0 for all four input parameters if the color<para/>
''' magnitude is to be calculated without either white balance<para/>
''' correction or dark filtering.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorContent/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb or 8 bpp colormapped</param>
'''  <param name="rwhite">[in] - color value associated with white point</param>
'''  <param name="gwhite">[in] - color value associated with white point</param>
'''  <param name="bwhite">[in] - color value associated with white point</param>
'''  <param name="mingray">[in] - min gray value for which color is measured</param>
'''  <param name="ppixr">[out][optional] - 8 bpp red 'content'</param>
'''  <param name="ppixg">[out][optional] - 8 bpp green 'content'</param>
'''  <param name="ppixb">[out][optional] - 8 bpp blue 'content'</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorContent(
				 ByVal pixs as Pix, 
				 ByVal rwhite as Integer, 
				 ByVal gwhite as Integer, 
				 ByVal bwhite as Integer, 
				 ByVal mingray as Integer, 
				<Out()> Optional ByRef ppixr as Pix = Nothing, 
				<Out()> Optional ByRef ppixg as Pix = Nothing, 
				<Out()> Optional ByRef ppixb as Pix = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

Dim ppixrPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixr) Then ppixrPTR = ppixr.Pointer
Dim ppixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixg) Then ppixgPTR = ppixg.Pointer
Dim ppixbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixb) Then ppixbPTR = ppixb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorContent( pixs.Pointer, rwhite, gwhite, bwhite, mingray, ppixrPTR, ppixgPTR, ppixbPTR)
	if ppixrPTR <> IntPtr.Zero then ppixr = new Pix(ppixrPTR)
	if ppixgPTR <> IntPtr.Zero then ppixg = new Pix(ppixgPTR)
	if ppixbPTR <> IntPtr.Zero then ppixb = new Pix(ppixbPTR)

	Return _Result
End Function

' SRC\colorcontent.c (363, 1)
' pixColorMagnitude(pixs, rwhite, gwhite, bwhite, type) as Pix
' pixColorMagnitude(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For an RGB image, a gray pixel is one where all three components<para/>
''' are equal.  We define the amount of color in an RGB pixel as<para/>
''' a function depending on the absolute value of the differences<para/>
''' between the three color components.  Consider the two largest<para/>
''' of these differences.  The pixel component in common to these<para/>
''' two differences is the color farthest from the other two.<para/>
''' The color magnitude in an RGB pixel can be taken as one<para/>
''' of these three definitions:<para/>
''' (a) The average of these two differences.  This is the<para/>
''' average distance from the two components that are<para/>
''' nearest to each other to the third component.<para/>
''' (b) The minimum value of these two differences.  This is<para/>
''' the intermediate value of the three distances between<para/>
''' component values.  Stated otherwise, it is the<para/>
''' maximum over all components of the minimum distance<para/>
''' from that component to the other two components.<para/>
''' (c) The maximum difference between component values.<para/>
''' (2) As an example, suppose that R and G are the closest in<para/>
''' magnitude.  Then the color is determined as either:<para/>
''' (a) The average distance of B from these two:<para/>
''' (|B - R| + |B - G|) / 2<para/>
''' (b) The minimum distance of B from these two:<para/>
''' min(|B - R|, |B - G|).<para/>
''' (c) The maximum distance of B from these two:<para/>
''' max(|B - R|, |B - G|)<para/>
''' (3) The three methods for choosing the color magnitude from<para/>
''' the components are selected with these flags:<para/>
''' (a) L_MAX_DIFF_FROM_AVERAGE_2<para/>
''' (b) L_MAX_MIN_DIFF_FROM_2<para/>
''' (c) L_MAX_DIFF<para/>
''' (4) The three numbers (rwhite, gwhite and bwhite) can be thought<para/>
''' of as the values in the image corresponding to white.<para/>
''' They are used to compensate for an unbalanced color white point.<para/>
''' They must either be all 0 or all non-zero.  To turn this<para/>
''' off, set them all to 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorMagnitude/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb or 8 bpp colormapped</param>
'''  <param name="rwhite">[in] - color value associated with white point</param>
'''  <param name="gwhite">[in] - color value associated with white point</param>
'''  <param name="bwhite">[in] - color value associated with white point</param>
'''  <param name="type">[in] - chooses the method for calculating the color magnitude: L_MAX_DIFF_FROM_AVERAGE_2, L_MAX_MIN_DIFF_FROM_2, L_MAX_DIFF</param>
'''   <returns>pixd 8 bpp, amount of color in each source pixel, or NULL on error</returns>
Public Shared Function pixColorMagnitude(
				 ByVal pixs as Pix, 
				 ByVal rwhite as Integer, 
				 ByVal gwhite as Integer, 
				 ByVal bwhite as Integer, 
				 ByVal type as Enumerations.L_MAX) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorMagnitude( pixs.Pointer, rwhite, gwhite, bwhite, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorcontent.c (502, 1)
' pixMaskOverColorPixels(pixs, threshdiff, mindist) as Pix
' pixMaskOverColorPixels(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The generated mask identifies each pixel as either color or<para/>
''' non-color.  For a pixel to be color, it must satisfy two<para/>
''' constraints:<para/>
''' (a) The max difference between the r,g and b components must<para/>
''' equal or exceed a threshold %threshdiff.<para/>
''' (b) It must be at least %mindist (in an 8-connected way)<para/>
''' from the nearest non-color pixel.<para/>
''' (2) The distance constraint (b) is only applied if %mindist  is greater  1.<para/>
''' For example, if %mindist == 2, the color pixels identified<para/>
''' by (a) are eroded by a 3x3 Sel.  In general, the Sel size<para/>
''' for erosion is 2  (%mindist - 1) + 1.<para/>
''' Why have this constraint?  In scanned images that are<para/>
''' essentially gray, color artifacts are typically introduced<para/>
''' in transition regions near sharp edges that go from dark<para/>
''' to light, so this allows these transition regions to be removed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMaskOverColorPixels/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb or 8 bpp colormapped</param>
'''  <param name="threshdiff">[in] - threshold for minimum of the max difference between components</param>
'''  <param name="mindist">[in] - minimum allowed distance from nearest non-color pixel</param>
'''   <returns>pixd 1 bpp, mask over color pixels, or NULL on error</returns>
Public Shared Function pixMaskOverColorPixels(
				 ByVal pixs as Pix, 
				 ByVal threshdiff as Integer, 
				 ByVal mindist as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMaskOverColorPixels( pixs.Pointer, threshdiff, mindist)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorcontent.c (569, 1)
' pixMaskOverColorRange(pixs, rmin, rmax, gmin, gmax, bmin, bmax) as Pix
' pixMaskOverColorRange(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMaskOverColorRange/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb or 8 bpp colormapped</param>
'''  <param name="rmin">[in] - min and max allowed values for red component</param>
'''  <param name="rmax">[in] - min and max allowed values for red component</param>
'''  <param name="gmin">[in] - </param>
'''  <param name="gmax">[in] - </param>
'''  <param name="bmin">[in] - </param>
'''  <param name="bmax">[in] - </param>
'''   <returns>pixd 1 bpp, mask over color pixels, or NULL on error</returns>
Public Shared Function pixMaskOverColorRange(
				 ByVal pixs as Pix, 
				 ByVal rmin as Integer, 
				 ByVal rmax as Integer, 
				 ByVal gmin as Integer, 
				 ByVal gmax as Integer, 
				 ByVal bmin as Integer, 
				 ByVal bmax as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMaskOverColorRange( pixs.Pointer, rmin, rmax, gmin, gmax, bmin, bmax)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorcontent.c (678, 1)
' pixColorFraction(pixs, darkthresh, lightthresh, diffthresh, factor, ppixfract, pcolorfract) as Integer
' pixColorFraction(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function is asking the question: to what extent does the<para/>
''' image appear to have color? The amount of color a pixel<para/>
''' appears to have depends on both the deviation of the<para/>
''' individual components from their average and on the average<para/>
''' intensity itself.  For example, the color will be much more<para/>
''' obvious with a small deviation from white than the same<para/>
''' deviation from black.<para/>
''' (2) Any pixel that meets these three tests is considered a<para/>
''' colorful pixel:<para/>
''' (a) the lightest component must equal or exceed %darkthresh<para/>
''' (b) the darkest component must not exceed %lightthresh<para/>
''' (c) the max difference between components must equal or<para/>
''' exceed %diffthresh.<para/>
''' (3) The dark pixels are removed from consideration because<para/>
''' they don't appear to have color.<para/>
''' (4) The very lightest pixels are removed because if an image<para/>
''' has a lot of "white", the color fraction will be artificially<para/>
''' low, even if all the other pixels are colorful.<para/>
''' (5) If pixfract is very small, there are few pixels that are neither<para/>
''' black nor white.  If colorfract is very small, the pixels<para/>
''' that are neither black nor white have very little color<para/>
''' content.  The product 'pixfract  colorfract' gives the<para/>
''' fraction of pixels with significant color content.<para/>
''' (6) One use of this function is as a preprocessing step for median<para/>
''' cut quantization (colorquant2.c), which does a very poor job<para/>
''' splitting the color space into rectangular volume elements when<para/>
''' all the pixels are near the diagonal of the color cube.  For<para/>
''' octree quantization of an image with only gray values, the<para/>
''' 2^(level) octcubes on the diagonal are the only ones<para/>
''' that can be occupied.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorFraction/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="darkthresh">[in] - threshold near black if the lightest component is below this, the pixel is not considered in the statistics typ. 20</param>
'''  <param name="lightthresh">[in] - threshold near white if the darkest component is above this, the pixel is not considered in the statistics typ. 244</param>
'''  <param name="diffthresh">[in] - thresh for the maximum difference between component value below this the pixel is not considered to have sufficient color</param>
'''  <param name="factor">[in] - subsampling factor</param>
'''  <param name="ppixfract">[out] - fraction of pixels in intermediate brightness range that were considered for color content</param>
'''  <param name="pcolorfract">[out] - fraction of pixels that meet the criterion for sufficient color 0.0 on error</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorFraction(
				 ByVal pixs as Pix, 
				 ByVal darkthresh as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal diffthresh as Integer, 
				 ByVal factor as Integer, 
				<Out()> ByRef ppixfract as Single, 
				<Out()> ByRef pcolorfract as Single) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorFraction( pixs.Pointer, darkthresh, lightthresh, diffthresh, factor, ppixfract, pcolorfract)

	Return _Result
End Function

' SRC\colorcontent.c (805, 1)
' pixFindColorRegions(pixs, pixm, factor, lightthresh, darkthresh, mindiff, colordiff, edgefract, pcolorfract, pcolormask1, pcolormask2, pixadb) as Integer
' pixFindColorRegions(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_float32, l_float32 *, PIX **, PIX **, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function tries to determine if there is a significant<para/>
''' color or darker region on a scanned page image, where part<para/>
''' of the image is background that is either white or reddish.<para/>
''' This also allows extraction of regions of colored pixels that<para/>
''' have a smaller red component than blue or green components.<para/>
''' (2) If %pixm exists, pixels under its fg are combined with<para/>
''' dark pixels to make a mask of pixels not to be considered<para/>
''' as color candidates.<para/>
''' (3) There are four thresholds.<para/>
''' %lightthresh: compute the average value of each rgb pixel,<para/>
''' and make 10 buckets by value.  If the lightest bucket gray<para/>
''' value is below %lightthresh, the image is not considered<para/>
''' to have a light bg, and this returns 0.0 for %colorfract.<para/>
''' %darkthresh: ignore pixels darker than this (typ. fg text).<para/>
''' We make a 1 bpp mask of these pixels, and then dilate it to<para/>
''' remove all vestiges of fg from their vicinity.<para/>
''' %mindiff: consider pixels with either (b - r) or (g - r)<para/>
''' being at least this value, as having color.<para/>
''' %colordiff: consider pixels where the (max - min) difference<para/>
''' of the pixel components exceeds this value, as having color.<para/>
''' (4) All components of color pixels that are touching the image<para/>
''' border are removed.  Additionally, all pixels within some<para/>
''' normalized distance %edgefract from the image border can<para/>
''' be removed.  This insures that dark pixels near the edge<para/>
''' of the image are not included.<para/>
''' (5) This returns in %pcolorfract the fraction of pixels that have<para/>
''' color and are not in the set consisting of an OR between<para/>
''' %pixm and the dilated dark pixel mask.<para/>
''' (6) No masks are returned unless light color pixels are found.<para/>
''' If colorfract  is greater  0.0 and %pcolormask1 is defined, this returns<para/>
''' a 1 bpp mask with fg pixels over the color background.<para/>
''' This mask may have some holes in it.<para/>
''' (7) If colorfract  is greater  0.0 and %pcolormask2 is defined, this returns<para/>
''' a version of colormask1 where small holes have been filled.<para/>
''' (8) To generate a boxa of rectangular regions from the overlap<para/>
''' of components in the filtered mask:<para/>
''' boxa1 = pixConnCompBB(colormask2, 8)<para/>
''' boxa2 = boxaCombineOverlaps(boxa1, NULL)<para/>
''' This is done here in debug mode.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindColorRegions/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask image</param>
'''  <param name="factor">[in] - subsample factor integer  is greater = 1</param>
'''  <param name="lightthresh">[in] - threshold for component average in lightest of 10 buckets typ. 210 -1 for default</param>
'''  <param name="darkthresh">[in] - threshold to eliminate dark pixels (e.g., text) from consideration typ. 70 -1 for default.</param>
'''  <param name="mindiff">[in] - minimum difference (b - r) and (g - r), used to find blue or green pixels typ. 10 -1 for default</param>
'''  <param name="colordiff">[in] - minimum difference in (max - min) component to qualify as a color pixel typ. 90 -1 for default</param>
'''  <param name="edgefract">[in] - fraction of image half-width and half-height for which color pixels are ignored typ. 0.05.</param>
'''  <param name="pcolorfract">[out] - fraction of 'color' pixels found</param>
'''  <param name="pcolormask1">[out][optional] - mask over background color, if any</param>
'''  <param name="pcolormask2">[out][optional] - filtered mask over background color</param>
'''  <param name="pixadb">[out][optional] - debug intermediate results</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixFindColorRegions(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal factor as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal darkthresh as Integer, 
				 ByVal mindiff as Integer, 
				 ByVal colordiff as Integer, 
				 ByVal edgefract as Single, 
				<Out()> ByRef pcolorfract as Single, 
				<Out()> Optional ByRef pcolormask1 as Pix = Nothing, 
				<Out()> Optional ByRef pcolormask2 as Pix = Nothing, 
				<Out()> Optional ByRef pixadb as Pixa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer
Dim pcolormask1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pcolormask1) Then pcolormask1PTR = pcolormask1.Pointer
Dim pcolormask2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pcolormask2) Then pcolormask2PTR = pcolormask2.Pointer
	Dim pixadbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadb) Then pixadbPTR = pixadb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixFindColorRegions( pixs.Pointer, pixmPTR, factor, lightthresh, darkthresh, mindiff, colordiff, edgefract, pcolorfract, pcolormask1PTR, pcolormask2PTR, pixadbPTR)
	if pcolormask1PTR <> IntPtr.Zero then pcolormask1 = new Pix(pcolormask1PTR)
	if pcolormask2PTR <> IntPtr.Zero then pcolormask2 = new Pix(pcolormask2PTR)
	if pixadbPTR <> IntPtr.Zero then pixadb = new Pixa(pixadbPTR)

	Return _Result
End Function

' SRC\colorcontent.c (1022, 1)
' pixNumSignificantGrayColors(pixs, darkthresh, lightthresh, minfract, factor, pncolors) as Integer
' pixNumSignificantGrayColors(PIX *, l_int32, l_int32, l_float32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function is asking the question: how many perceptually<para/>
''' significant gray color levels is in this pix?<para/>
''' A color level must meet 3 criteria to be significant:<para/>
''' ~ it can't be too close to black<para/>
''' ~ it can't be too close to white<para/>
''' ~ it must have at least some minimum fractional population<para/>
''' (2) Use -1 for default values for darkthresh, lightthresh and minfract.<para/>
''' (3) Choose default of darkthresh = 20, because variations in very<para/>
''' dark pixels are not visually significant.<para/>
''' (4) Choose default of lightthresh = 236, because document images<para/>
''' that have been jpeg'd typically have near-white pixels in the<para/>
''' 8x8 jpeg blocks, and these should not be counted.  It is desirable<para/>
''' to obtain a clean image by quantizing this noise away.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixNumSignificantGrayColors/*"/>
'''  <param name="pixs">[in] - 8 bpp gray</param>
'''  <param name="darkthresh">[in] - dark threshold for minimum intensity to be considered typ. 20</param>
'''  <param name="lightthresh">[in] - threshold near white, for maximum intensity to be considered typ. 236</param>
'''  <param name="minfract">[in] - minimum fraction of all pixels to include a level as significant typ. 0.0001 should be  is lower  0.001</param>
'''  <param name="factor">[in] - subsample factor integer  is greater = 1</param>
'''  <param name="pncolors">[out] - number of significant colors 0 on error</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixNumSignificantGrayColors(
				 ByVal pixs as Pix, 
				 ByVal darkthresh as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal minfract as Single, 
				 ByVal factor as Integer, 
				<Out()> ByRef pncolors as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixNumSignificantGrayColors( pixs.Pointer, darkthresh, lightthresh, minfract, factor, pncolors)

	Return _Result
End Function

' SRC\colorcontent.c (1145, 1)
' pixColorsForQuantization(pixs, thresh, pncolors, piscolor, debug) as Integer
' pixColorsForQuantization(PIX *, l_int32, l_int32 *, l_int32 *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function finds a measure of the number of colors that are<para/>
''' found in low-gradient regions of an image.  By its<para/>
''' magnitude relative to some threshold (not specified in<para/>
''' this function), it gives a good indication of whether<para/>
''' quantization will generate posterization. This number<para/>
''' is larger for images with regions of slowly varying<para/>
''' intensity (if 8 bpp) or color (if rgb). Such images, if<para/>
''' quantized, may require dithering to avoid posterization,<para/>
''' and lossless compression is then expected to be poor.<para/>
''' (2) If pixs has a colormap, the number of colors returned is<para/>
''' the number in the colormap.<para/>
''' (3) It is recommended that document images be reduced to a width<para/>
''' of 800 pixels before applying this function.  Then it can<para/>
''' be expected that color detection will be fairly accurate<para/>
''' and the number of colors will reflect both the content and<para/>
''' the type of compression to be used.  For less than 15 colors,<para/>
''' there is unlikely to be a halftone image, and lossless<para/>
''' quantization should give both a good visual result and<para/>
''' better compression.<para/>
''' (4) When using the default threshold on the gradient (15),<para/>
''' images (both gray and rgb) where ncolors is greater than<para/>
''' about 15 will compress poorly with either lossless<para/>
''' compression or dithered quantization, and they may be<para/>
''' posterized with non-dithered quantization.<para/>
''' (5) For grayscale images, or images without significant color,<para/>
''' this returns the number of significant gray levels in<para/>
''' the low-gradient regions.  The actual number of gray levels<para/>
''' can be large due to jpeg compression noise in the background.<para/>
''' (6) Similarly, for color images, the actual number of different<para/>
''' (r,g,b) colors in the low-gradient regions (rather than the<para/>
''' number of occupied level 4 octcubes) can be quite large, e.g.,<para/>
''' due to jpeg compression noise, even for regions that appear<para/>
''' to be of a single color.  By quantizing to level 4 octcubes,<para/>
''' most of these superfluous colors are removed from the counting.<para/>
''' (7) The image is tested for color.  If there is very little color,<para/>
''' it is thresholded to gray and the number of gray levels in<para/>
''' the low gradient regions is found.  If the image has color,<para/>
''' the number of occupied level 4 octcubes is found.<para/>
''' (8) The number of colors in the low-gradient regions increases<para/>
''' monotonically with the threshold %thresh on the edge gradient.<para/>
''' (9) Background: grayscale and color quantization is often useful<para/>
''' to achieve highly compressed images with little visible<para/>
''' distortion.  However, gray or color washes (regions of<para/>
''' low gradient) can defeat this approach to high compression.<para/>
''' How can one determine if an image is expected to compress<para/>
''' well using gray or color quantization?  We use the fact that<para/>
''' gray washes, when quantized with less than 50 intensities,<para/>
''' have posterization (visible boundaries between regions<para/>
''' of uniform 'color') and poor lossless compression<para/>
''' color washes, when quantized with level 4 octcubes,<para/>
''' typically result in both posterization and the occupancy<para/>
''' of many level 4 octcubes.<para/>
''' Images can have colors either intrinsically or as jpeg<para/>
''' compression artifacts.  This function reduces but does not<para/>
''' completely eliminate measurement of jpeg quantization noise<para/>
''' in the white background of grayscale or color images.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixColorsForQuantization/*"/>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb with or without colormap</param>
'''  <param name="thresh">[in] - binary threshold on edge gradient 0 for default</param>
'''  <param name="pncolors">[out] - the number of colors found</param>
'''  <param name="piscolor">[out][optional] - 1 if significant color is found 0 otherwise.  If pixs is 8 bpp, and does not have a colormap with color entries, this is 0</param>
'''  <param name="debug">[in] - 1 to output masked image that is tested for colors 0 otherwise</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixColorsForQuantization(
				 ByVal pixs as Pix, 
				 ByVal thresh as Integer, 
				<Out()> ByRef pncolors as Integer, 
				<Out()> Optional ByRef piscolor as Integer = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorsForQuantization( pixs.Pointer, thresh, pncolors, piscolor, debug)

	Return _Result
End Function

' SRC\colorcontent.c (1287, 1)
' pixNumColors(pixs, factor, pncolors) as Integer
' pixNumColors(PIX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns the actual number of colors found in the image,<para/>
''' even if there is a colormap.  If %factor == 1 and the<para/>
''' number of colors differs from the number of entries<para/>
''' in the colormap, a warning is issued.<para/>
''' (2) Use %factor == 1 to find the actual number of colors.<para/>
''' Use %factor  is greater  1 to quickly find the approximate number of colors.<para/>
''' (3) For d = 2, 4 or 8 bpp grayscale, this returns the number<para/>
''' of colors found in the image in 'ncolors'.<para/>
''' (4) For d = 32 bpp (rgb), if the number of colors is<para/>
''' greater than 256, this returns 0 in 'ncolors'.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixNumColors/*"/>
'''  <param name="pixs">[in] - 2, 4, 8, 32 bpp</param>
'''  <param name="factor">[in] - subsampling factor integer</param>
'''  <param name="pncolors">[out] - the number of colors found, or 0 if there are more than 256</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixNumColors(
				 ByVal pixs as Pix, 
				 ByVal factor as Integer, 
				<Out()> ByRef pncolors as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixNumColors( pixs.Pointer, factor, pncolors)

	Return _Result
End Function

' SRC\colorcontent.c (1395, 1)
' pixGetMostPopulatedColors(pixs, sigbits, factor, ncolors, parray, pcmap) as Integer
' pixGetMostPopulatedColors(PIX *, l_int32, l_int32, l_int32, l_uint32 **, PIXCMAP **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the %ncolors most populated cubes in rgb colorspace,<para/>
''' where the cube size depends on %sigbits as<para/>
''' cube side = (256  is greater  is greater  sigbits)<para/>
''' (2) The rgb color components are found at the center of the cube.<para/>
''' (3) The output array of colors can be displayed using<para/>
''' pixDisplayColorArray(array, ncolors, ...)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetMostPopulatedColors/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="sigbits">[in] - 2-6, significant bits retained in the quantizer for each component of the input image</param>
'''  <param name="factor">[in] - subsampling factor use 1 for no subsampling</param>
'''  <param name="ncolors">[in] - the number of most populated colors to select</param>
'''  <param name="parray">[out][optional] - array of colors, each as 0xrrggbb00</param>
'''  <param name="pcmap">[out][optional] - colormap of the colors</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetMostPopulatedColors(
				 ByVal pixs as Pix, 
				 ByVal sigbits as Integer, 
				 ByVal factor as Integer, 
				 ByVal ncolors as Integer, 
				<Out()> Optional ByRef parray as Byte() = Nothing, 
				<Out()> Optional ByRef pcmap as PixColormap = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim parrayPTR As IntPtr = IntPtr.Zero
Dim pcmapPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pcmap) Then pcmapPTR = pcmap.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetMostPopulatedColors( pixs.Pointer, sigbits, factor, ncolors, parrayPTR, pcmapPTR)
	ReDim parray(IIf(1 > 0, 1, 1) - 1) : If parrayPTR <> IntPtr.Zero Then Marshal.Copy(parrayPTR, parray, 0, parray.count)
	if pcmapPTR <> IntPtr.Zero then pcmap = new PixColormap(pcmapPTR)

	Return _Result
End Function

' SRC\colorcontent.c (1470, 1)
' pixSimpleColorQuantize(pixs, sigbits, factor, ncolors) as Pix
' pixSimpleColorQuantize(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If you want to do color quantization for real, use octcube<para/>
''' or modified median cut.  This function shows that it is<para/>
''' easy to make a simple quantizer based solely on the population<para/>
''' in cells of a given size in rgb color space.<para/>
''' (2) The %ncolors most populated cells at the %sigbits level form<para/>
''' the colormap for quantizing, and this uses octcube indexing<para/>
''' under the covers to assign each pixel to the nearest color.<para/>
''' (3) %sigbits is restricted to 2, 3 and 4.  At the low end, the<para/>
''' color discrimination is very crude at the upper end, a set of<para/>
''' similar colors can dominate the result.  Interesting results<para/>
''' are generally found for %sigbits = 3 and ncolors ~ 20.<para/>
''' (4) See also pixColorSegment() for a method of quantizing the<para/>
''' colors to generate regions of similar color.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSimpleColorQuantize/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="sigbits">[in] - 2-4, significant bits retained in the quantizer for each component of the input image</param>
'''  <param name="factor">[in] - subsampling factor use 1 for no subsampling</param>
'''  <param name="ncolors">[in] - the number of most populated colors to select</param>
'''   <returns>pixd 8 bpp cmapped or NULL on error</returns>
Public Shared Function pixSimpleColorQuantize(
				 ByVal pixs as Pix, 
				 ByVal sigbits as Integer, 
				 ByVal factor as Integer, 
				 ByVal ncolors as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSimpleColorQuantize( pixs.Pointer, sigbits, factor, ncolors)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorcontent.c (1516, 1)
' pixGetRGBHistogram(pixs, sigbits, factor) as Numa
' pixGetRGBHistogram(PIX *, l_int32, l_int32) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses a simple, fast method of indexing into an rgb image.<para/>
''' (2) The output is a 1D histogram of count vs. rgb-index, which<para/>
''' uses red sigbits as the most significant and blue as the least.<para/>
''' (3) This function produces the same result as pixMedianCutHisto().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetRGBHistogram/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="sigbits">[in] - 2-6, significant bits retained in the quantizer for each component of the input image</param>
'''  <param name="factor">[in] - subsampling factor use 1 for no subsampling</param>
'''   <returns>numa histogram of colors, indexed by RGB components, or NULL on error</returns>
Public Shared Function pixGetRGBHistogram(
				 ByVal pixs as Pix, 
				 ByVal sigbits as Integer, 
				 ByVal factor as Integer) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetRGBHistogram( pixs.Pointer, sigbits, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\colorcontent.c (1584, 1)
' makeRGBIndexTables(prtab, pgtab, pbtab, sigbits) as Integer
' makeRGBIndexTables(l_uint32 **, l_uint32 **, l_uint32 **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These tables are used to map from rgb sample values to<para/>
''' an rgb index, using<para/>
''' rgbindex = rtab[rval] | gtab[gval] | btab[bval]<para/>
''' where, e.g., if sigbits = 3, the index is a 9 bit integer:<para/>
''' r7 r6 r5 g7 g6 g5 b7 b6 b5<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/makeRGBIndexTables/*"/>
'''  <param name="prtab">[out] - 256-entry index tables</param>
'''  <param name="pgtab">[out] - 256-entry index tables</param>
'''  <param name="pbtab">[out] - 256-entry index tables</param>
'''  <param name="sigbits">[in] - 2-6, significant bits retained in the quantizer for each component of the input image</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function makeRGBIndexTables(
				<Out()> ByRef prtab as Byte(), 
				<Out()> ByRef pgtab as Byte(), 
				<Out()> ByRef pbtab as Byte(), 
				 ByVal sigbits as Integer) as Integer

	Dim prtabPTR As IntPtr = IntPtr.Zero
	Dim pgtabPTR As IntPtr = IntPtr.Zero
	Dim pbtabPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.makeRGBIndexTables( prtabPTR, pgtabPTR, pbtabPTR, sigbits)
	ReDim prtab(IIf(1 > 0, 1, 1) - 1) : If prtabPTR <> IntPtr.Zero Then Marshal.Copy(prtabPTR, prtab, 0, prtab.count)
	ReDim pgtab(IIf(1 > 0, 1, 1) - 1) : If pgtabPTR <> IntPtr.Zero Then Marshal.Copy(pgtabPTR, pgtab, 0, pgtab.count)
	ReDim pbtab(IIf(1 > 0, 1, 1) - 1) : If pbtabPTR <> IntPtr.Zero Then Marshal.Copy(pbtabPTR, pbtab, 0, pbtab.count)

	Return _Result
End Function

' SRC\colorcontent.c (1674, 1)
' getRGBFromIndex(index, sigbits, prval, pgval, pbval) as Integer
' getRGBFromIndex(l_uint32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index is expressed in bits, based on the the<para/>
''' %sigbits of the r, g and b components, as<para/>
''' r7 r6 ... g7 g6 ... b7 b6 ...<para/>
''' (2) The computed rgb values are in the center of the quantized cube.<para/>
''' The extra bit that is OR'd accomplishes this.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/getRGBFromIndex/*"/>
'''  <param name="index">[in] - rgbindex</param>
'''  <param name="sigbits">[in] - 2-6, significant bits retained in the quantizer for each component of the input image</param>
'''  <param name="prval">[out] - rgb values</param>
'''  <param name="pgval">[out] - rgb values</param>
'''  <param name="pbval">[out] - rgb values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function getRGBFromIndex(
				 ByVal index as UInteger, 
				 ByVal sigbits as Integer, 
				<Out()> ByRef prval as Integer, 
				<Out()> ByRef pgval as Integer, 
				<Out()> ByRef pbval as Integer) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.getRGBFromIndex( index, sigbits, prval, pgval, pbval)

	Return _Result
End Function

' SRC\colorcontent.c (1757, 1)
' pixHasHighlightRed(pixs, factor, fract, fthresh, phasred, pratio, ppixdb) as Integer
' pixHasHighlightRed(PIX *, l_int32, l_float32, l_float32, l_int32 *, l_float32 *, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Pixels are identified as red if they satisfy two conditions:<para/>
''' (a) The components satisfy (R-B)/B  is greater  %fthresh (red or dark fg)<para/>
''' (b) The red component satisfied R  is greater  128  (red or light bg)<para/>
''' Masks are generated for (a) and (b), and the intersection<para/>
''' gives the pixels that are red but not either light bg or<para/>
''' dark fg.<para/>
''' (2) A typical value for fract = 0.0001, which gives sensitivity<para/>
''' to an image where a small fraction of the pixels are printed<para/>
''' in red.<para/>
''' (3) A typical value for fthresh = 2.5.  Higher values give less<para/>
''' sensitivity to red, and fewer false positives.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixHasHighlightRed/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="factor">[in] - subsampling an integer  is greater = 1 use 1 for all pixels</param>
'''  <param name="fract">[in] - threshold fraction of all image pixels</param>
'''  <param name="fthresh">[in] - threshold on a function of the components typ. ~2.5</param>
'''  <param name="phasred">[out] - 1 if red pixels are above threshold</param>
'''  <param name="pratio">[out][optional] - normalized fraction of threshold red pixels that is actually observed</param>
'''  <param name="ppixdb">[out][optional] - seed pixel mask</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixHasHighlightRed(
				 ByVal pixs as Pix, 
				 ByVal factor as Integer, 
				 ByVal fract as Single, 
				 ByVal fthresh as Single, 
				<Out()> ByRef phasred as Integer, 
				<Out()> Optional ByRef pratio as Single = Nothing, 
				<Out()> Optional ByRef ppixdb as Pix = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

Dim ppixdbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdb) Then ppixdbPTR = ppixdb.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixHasHighlightRed( pixs.Pointer, factor, fract, fthresh, phasred, pratio, ppixdbPTR)
	if ppixdbPTR <> IntPtr.Zero then ppixdb = new Pix(ppixdbPTR)

	Return _Result
End Function

End Class
