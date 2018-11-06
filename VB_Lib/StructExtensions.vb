Imports System.Runtime.InteropServices

Imports LeptonicaSharp.Enumerations

Partial Public Class Pix
' SRC\readfile.c (189, 1)
' pixRead(filename) as Pix
' pixRead(const char *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See at top of file for supported formats.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRead/*"/>
'''  <param name="filename">[in] - with full pathname or in local directory</param>
Sub New (
				 ByVal filename as String)
	Dim RetObj = _All.pixRead(filename)
	Pointer = RetObj.Pointer
End Sub
' SRC\pixconv.c (3233, 1)
' pixConvertTo32(pixs) as Pix
' pixConvertTo32(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Never returns a clone of pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo32/*"/>
'''   <returns>pixd 32 bpp, or NULL on error Usage: Top-level function, with simple default values for unpacking. 1 bpp:  val0 = 255, val1 = 0 and then replication into R, G and B components 2 bpp:  if colormapped, use the colormap values otherwise, use val0 = 0, val1 = 0x55, val2 = 0xaa, val3 = 255 and replicate gray into R, G and B components 4 bpp:  if colormapped, use the colormap values otherwise, replicate 2 nybs into a byte, and then into R,G,B components 8 bpp:  if colormapped, use the colormap values otherwise, replicate gray values into R, G and B components 16 bpp: replicate MSB into R, G and B components 24 bpp: unpack the pixels, maintaining word alignment on each scanline 32 bpp: makes a copy</returns>
Public Function pixConvertTo32(
) as Pix
	Dim RetObj = _All.pixConvertTo32(me)
	Return RetObj
End Function
' SRC\pixconv.c (3184, 1)
' pixConvertTo16(pixs) as Pix
' pixConvertTo16(PIX *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo16/*"/>
'''   <returns>pixd 16 bpp, or NULL on error Usage: Top-level function, with simple default values for unpacking. 1 bpp:  val0 = 0xffff, val1 = 0 8 bpp:  replicates the 8 bit value in both the MSB and LSB of the 16 bit pixel.</returns>
Public Function pixConvertTo16(
) as Pix
	Dim RetObj = _All.pixConvertTo16(me)
	Return RetObj
End Function
' SRC\pixconv.c (3041, 1)
' pixConvertTo8(pixs, cmapflag) as Pix
' pixConvertTo8(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a top-level function, with simple default values<para/>
''' for unpacking.<para/>
''' (2) The result, pixd, is made with a colormap if specified.<para/>
''' It is always a new image -- never a clone.  For example,<para/>
''' if d == 8, and cmapflag matches the existence of a cmap<para/>
''' in pixs, the operation is lossless and it returns a copy.<para/>
''' (3) The default values used are:<para/>
''' ~ 1 bpp: val0 = 255, val1 = 0<para/>
''' ~ 2 bpp: 4 bpp:  even increments over dynamic range<para/>
''' ~ 8 bpp: lossless if cmap matches cmapflag<para/>
''' ~ 16 bpp: use most significant byte<para/>
''' (4) If 32 bpp RGB, this is converted to gray.  If you want<para/>
''' to do color quantization, you must specify the type<para/>
''' explicitly, using the color quantization code.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo8/*"/>
'''  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap FALSE otherwise</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Function pixConvertTo8(
				 ByVal cmapflag as Integer) as Pix
	Dim RetObj = _All.pixConvertTo8(me, cmapflag)
	Return RetObj
End Function
' SRC\pixconv.c (2826, 1)
' pixConvertTo4(pixs) as Pix
' pixConvertTo4(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a top-level function, with simple default values<para/>
''' used in pixConvertTo8() if unpacking is necessary.<para/>
''' (2) Any existing colormap is removed the result is always gray.<para/>
''' (3) If the input image has 4 bpp and no colormap, the operation is<para/>
''' lossless and a copy is returned.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo4/*"/>
'''   <returns>pixd   4 bpp, or NULL on error</returns>
Public Function pixConvertTo4(
) as Pix
	Dim RetObj = _All.pixConvertTo4(me)
	Return RetObj
End Function
' SRC\pixconv.c (2718, 1)
' pixConvertTo2(pixs) as Pix
' pixConvertTo2(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a top-level function, with simple default values<para/>
''' used in pixConvertTo8() if unpacking is necessary.<para/>
''' (2) Any existing colormap is removed the result is always gray.<para/>
''' (3) If the input image has 2 bpp and no colormap, the operation is<para/>
''' lossless and a copy is returned.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo2/*"/>
'''   <returns>pixd   2 bpp, or NULL on error</returns>
Public Function pixConvertTo2(
) as Pix
	Dim RetObj = _All.pixConvertTo2(me)
	Return RetObj
End Function
' SRC\pixconv.c (2933, 1)
' pixConvertTo1(pixs, threshold) as Pix
' pixConvertTo1(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a top-level function, with simple default values<para/>
''' used in pixConvertTo8() if unpacking is necessary.<para/>
''' (2) Any existing colormap is removed.<para/>
''' (3) If the input image has 1 bpp and no colormap, the operation is<para/>
''' lossless and a copy is returned.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertTo1/*"/>
'''  <param name="threshold">[in] - for final binarization, relative to 8 bpp</param>
'''   <returns>pixd 1 bpp, or NULL on error</returns>
Public Function pixConvertTo1(
				 ByVal threshold as Integer) as Pix
	Dim RetObj = _All.pixConvertTo1(me, threshold)
	Return RetObj
End Function
' SRC\skew.c (205, 1)
' pixDeskew(pixs, redsearch) as Pix
' pixDeskew(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This binarizes if necessary and finds the skew angle.  If the<para/>
''' angle is large enough and there is sufficient confidence,<para/>
''' it returns a deskewed image otherwise, it returns a clone.<para/>
''' (2) Typical values at 300 ppi for %redsearch are 2 and 4.<para/>
''' At 75 ppi, one should use %redsearch = 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDeskew/*"/>
'''  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
'''   <returns>pixd deskewed pix, or NULL on error</returns>
Public Function pixDeskew(
				 Optional ByVal redsearch as Integer = 0) as Pix
	Dim RetObj = _All.pixDeskew(me, redsearch)
	Return RetObj
End Function
' SRC\pix3.c (1395, 1)
' pixInvert(pixd, pixs) as Pix
' pixInvert(PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This inverts pixs, for all pixel depths.<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null, ~src -- is greater  new pixd<para/>
''' (b) pixd == pixs, ~src -- is greater  src  (in-place)<para/>
''' (c) pixd != pixs, ~src -- is greater  input pixd<para/>
''' (3) For clarity, if the case is known, use these patterns:<para/>
''' (a) pixd = pixInvert(NULL, pixs)<para/>
''' (b) pixInvert(pixs, pixs)<para/>
''' (c) pixInvert(pixd, pixs)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixInvert/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
'''   <returns>pixd, or NULL on error</returns>
Public Function pixInvert(
				 Optional ByVal pixd as Pix = Nothing) as Pix
	Dim RetObj = _All.pixInvert(pixd, me)
	Return RetObj
End Function
' SRC\flipdetect.c (242, 1)
' pixOrientCorrect(pixs, minupconf, minratio, pupconf, pleftconf, protation, debug) as Pix
' pixOrientCorrect(PIX *, l_float32, l_float32, l_float32 *, l_float32 *, l_int32 *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Simple top-level function to detect if Roman text is in<para/>
''' reading orientation, and to rotate the image accordingly if not.<para/>
''' (2) Returns a copy if no rotation is needed.<para/>
''' (3) See notes for pixOrientDetect() and pixOrientDecision().<para/>
''' Use 0.0 for default values for %minupconf and %minratio<para/>
''' (4) Optional output of intermediate confidence results and<para/>
''' the rotation performed on pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOrientCorrect/*"/>
'''  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
'''  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
'''  <param name="pupconf">[out][optional] - use NULL to skip</param>
'''  <param name="pleftconf">[out][optional] - use NULL to skip</param>
'''  <param name="protation">[out][optional] - use NULL to skip</param>
'''  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>pixd  may be rotated by 90, 180 or 270 null on error</returns>
Public Function pixOrientCorrect(
				 ByVal minupconf as Single, 
				 ByVal minratio as Single, 
				<Out()> Optional ByRef pupconf as Single = Nothing, 
				<Out()> Optional ByRef pleftconf as Single = Nothing, 
				<Out()> Optional ByRef protation as Integer = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix
	Dim RetObj = _All.pixOrientCorrect(me, minupconf, minratio, pupconf, pleftconf, protation, debug)
	Return RetObj
End Function
' SRC\adaptmap.c (231, 1)
' pixBackgroundNormSimple(pixs, pixim, pixg) as Pix
' pixBackgroundNormSimple(PIX *, PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a simplified interface to pixBackgroundNorm(),<para/>
''' where seven parameters are defaulted.<para/>
''' (2) The input image is either grayscale or rgb.<para/>
''' (3) See pixBackgroundNorm() for usage and function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixBackgroundNormSimple/*"/>
'''  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
'''  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
'''   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
Public Function pixBackgroundNormSimple(
				 Optional ByVal pixim as Pix = Nothing, 
				 Optional ByVal pixg as Pix = Nothing) as Pix
	Dim RetObj = _All.pixBackgroundNormSimple(me, pixim, pixg)
	Return RetObj
End Function
' SRC\adaptmap.c (185, 1)
' pixCleanBackgroundToWhite(pixs, pixim, pixg, gamma, blackval, whiteval) as Pix
' pixCleanBackgroundToWhite(PIX *, PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a simplified interface for cleaning an image.<para/>
''' For comparison, see pixAdaptThresholdToBinaryGen().<para/>
''' (2) The suggested default values for the input parameters are:<para/>
''' gamma:  1.0  (reduce this to increase the contrast e.g.,<para/>
''' for light text)<para/>
''' blackval 70  (a bit more than 60)<para/>
''' whiteval  190  (a bit less than 200)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixCleanBackgroundToWhite/*"/>
'''  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
'''  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
'''  <param name="gamma">[in] - gamma correction must be  is greater  0.0 typically ~1.0</param>
'''  <param name="blackval">[in] - dark value to set to black (0)</param>
'''  <param name="whiteval">[in] - light value to set to white (255)</param>
'''   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
Public Function pixCleanBackgroundToWhite(
				 Optional ByVal pixim as Pix = Nothing, 
				 Optional ByVal pixg as Pix = Nothing, 
				 Optional ByVal gamma as Single = 1.0, 
				 Optional ByVal blackval as Integer = 70, 
				 Optional ByVal whiteval as Integer = 180) as Pix
	Dim RetObj = _All.pixCleanBackgroundToWhite(me, pixim, pixg, gamma, blackval, whiteval)
	Return RetObj
End Function
' SRC\pageseg.c (102, 1)
' pixGetRegionsBinary(pixs, ppixhm, ppixtm, ppixtb, pixadb) as Integer
' pixGetRegionsBinary(PIX *, PIX **, PIX **, PIX **, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is best to deskew the image before segmenting.<para/>
''' (2) Passing in %pixadb enables debug output.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetRegionsBinary/*"/>
'''  <param name="ppixhm">[out][optional] - halftone mask</param>
'''  <param name="ppixtm">[out][optional] - textline mask</param>
'''  <param name="ppixtb">[out][optional] - textblock mask</param>
'''  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Function pixGetRegionsBinary(
				 ByVal pixadb as Pixa, 
				<Out()> Optional ByRef ppixhm as Pix = Nothing, 
				<Out()> Optional ByRef ppixtm as Pix = Nothing, 
				<Out()> Optional ByRef ppixtb as Pix = Nothing) as Integer
	Dim RetObj = _All.pixGetRegionsBinary(me, ppixhm, ppixtm, ppixtb, pixadb)
	Return RetObj
End Function
' SRC\pixconv.c (753, 1)
' pixConvertRGBToGray(pixs, rwt, gwt, bwt) as Pix
' pixConvertRGBToGray(PIX *, l_float32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use a weighted average of the RGB values.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertRGBToGray/*"/>
'''  <param name="rwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
'''  <param name="gwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
'''  <param name="bwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
'''   <returns>8 bpp pix, or NULL on error</returns>
Public Function pixConvertRGBToGray(
				 Optional ByVal rwt as Single = 0, 
				 Optional ByVal gwt as Single = 0, 
				 Optional ByVal bwt as Single = 0) as Pix
	Dim RetObj = _All.pixConvertRGBToGray(me, rwt, gwt, bwt)
	Return RetObj
End Function
' SRC\colorquant1.c (2587, 1)
' pixOctcubeQuantMixedWithGray(pixs, depth, graylevels, delta) as Pix
' pixOctcubeQuantMixedWithGray(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a colormapped image, where the colormap table values<para/>
''' have two components: octcube values representing pixels with<para/>
''' color content, and grayscale values for the rest.<para/>
''' (2) The threshold (delta) is the maximum allowable difference of<para/>
''' the max abs value of | r - g |, | r - b | and | g - b |.<para/>
''' (3) The octcube values are the averages of all pixels that are<para/>
''' found in the octcube, and that are far enough from gray to<para/>
''' be considered color.  This can roughly be visualized as all<para/>
''' the points in the rgb color cube that are not within a "cylinder"<para/>
''' of diameter approximately 'delta' along the main diagonal.<para/>
''' (4) We want to guarantee full coverage of the rgb color space thus,<para/>
''' if the output depth is 4, the octlevel is 1 (2 x 2 x 2 = 8 cubes)<para/>
''' and if the output depth is 8, the octlevel is 2 (4 x 4 x 4<para/>
''' = 64 cubes).<para/>
''' (5) Consequently, we have the following constraint on the number<para/>
''' of allowed gray levels: for 4 bpp, 8 for 8 bpp, 192.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctcubeQuantMixedWithGray/*"/>
'''  <param name="depth">[in] - of output pix</param>
'''  <param name="graylevels">[in] - graylevels (must be  is greater  1)</param>
'''  <param name="delta">[in] - threshold for deciding if a pix is color or gray</param>
'''   <returns>pixd     quantized to octcube and gray levels or NULL on error</returns>
Public Function pixOctcubeQuantMixedWithGray(
				 ByVal depth as Integer, 
				 ByVal graylevels as Integer, 
				 ByVal delta as Integer) as Pix
	Dim RetObj = _All.pixOctcubeQuantMixedWithGray(me, depth, graylevels, delta)
	Return RetObj
End Function
' SRC\pix1.c (1545, 1)
' pixGetColormap(pix) as PixColormap
' pixGetColormap(PIX *) as PIXCMAP *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixGetColormap/*"/>
'''   <returns></returns>
Public Function pixGetColormap(
) as PixColormap
	Dim RetObj = _All.pixGetColormap(me)
	Return RetObj
End Function
' SRC\pix1.c (1571, 1)
' pixSetColormap(pix, colormap) as Integer
' pixSetColormap(PIX *, PIXCMAP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Unlike with the pix data field, pixSetColormap() destroys<para/>
''' any existing colormap before assigning the new one.<para/>
''' Because colormaps are not ref counted, it is important that<para/>
''' the new colormap does not belong to any other pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSetColormap/*"/>
'''  <param name="colormap">[in] - to be assigned</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Function pixSetColormap(
				 ByVal colormap as PixColormap) as Integer
	Dim RetObj = _All.pixSetColormap(me, colormap)
	Return RetObj
End Function
' SRC\dewarp4.c (97, 1)
' dewarpSinglePage(pixs, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug) as Integer
' dewarpSinglePage(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Dewarps pixs and returns the result in  and pixd.<para/>
''' (2) This uses default values for all model parameters.<para/>
''' (3) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
''' (4) If it can't build a model, returns a copy of pixs in  and pixd.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpSinglePage/*"/>
'''  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
'''  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
'''  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
'''  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
'''  <param name="pdewa">[out][optional] - dewa with single page NULL to skip</param>
'''  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
'''   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
Public Function dewarpSinglePage(
				 ByVal thresh as Integer, 
				 ByVal adaptive as Integer, 
				 ByVal useboth as Integer, 
				 ByVal check_columns as Integer, 
				<Out()> Optional ByRef ppixd as Pix = Nothing, 
				<Out()> Optional ByRef pdewa as L_Dewarpa = Nothing, 
				 Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Object
	Dim RetObj = _All.dewarpSinglePage(me, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug)
	Return ppixd
End Function
' SRC\pdfio1.c (1223, 1)
' pixConvertToPdf(pix, type, quality, fileout, x, y, res, title, plpd, position) as Integer
' pixConvertToPdf(PIX *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If %res == 0 and the input resolution field is 0,<para/>
''' this will use DEFAULT_INPUT_RES.<para/>
''' (2) This only writes data to fileout if it is the last<para/>
''' image to be written on the page.<para/>
''' (3) See comments in convertToPdf().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixConvertToPdf/*"/>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
'''  <param name="fileout">[in] - output pdf file only required on last image on page</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed</param>
'''  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
Public Sub pixConvertToPdf(
				 ByVal type as Enumerations.L_ENCODE, 
				 ByVal fileout as String, 
				 ByRef plpd as L_Pdf_Data, 
				 ByVal position as Enumerations.L_T_IMAGE, 
				 Optional ByVal quality as Integer = 0, 
				 Optional ByVal x as Integer = 0, 
				 Optional ByVal y as Integer = 0, 
				 Optional ByVal res as Integer = 0, 
				 Optional ByVal title as String = Nothing)
	Dim RetObj = _All.pixConvertToPdf(me, type, quality, fileout, x, y, res, title, plpd, position)
End Sub

End Class
Partial Public Class PixColormap
' SRC\colormap.c (110, 1)
' pixcmapCreate(depth) as PixColormap
' pixcmapCreate(l_int32) as PIXCMAP *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixcmapCreate/*"/>
'''  <param name="depth">[in] - bpp, of pix</param>
Sub New (
				 ByVal depth as Integer)
	Dim RetObj = _All.pixcmapCreate(depth)
	Pointer = RetObj.Pointer
End Sub
' SRC\colormap.c (593, 1)
' pixcmapGetCount(cmap) as Integer
' pixcmapGetCount(PIXCMAP *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixcmapGetCount/*"/>
'''   <returns>count, or 0 on error</returns>
Public Function pixcmapGetCount(
) as Integer
	Dim RetObj = _All.pixcmapGetCount(me)
	Return RetObj
End Function
' SRC\colormap.c (709, 1)
' pixcmapGetColor(cmap, index, prval, pgval, pbval) as Integer
' pixcmapGetColor(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixcmapGetColor/*"/>
'''  <param name="index">[in] - </param>
'''  <param name="prval">[out] - each color value</param>
'''  <param name="pgval">[out] - each color value</param>
'''  <param name="pbval">[out] - each color value</param>
'''   <returns>0 if OK, 1 if not accessible caller should check</returns>
Public Function pixcmapGetColor(
				 ByVal index as Integer, 
				<Out()> ByRef prval as Integer, 
				<Out()> ByRef pgval as Integer, 
				<Out()> ByRef pbval as Integer) as Integer
	Dim RetObj = _All.pixcmapGetColor(me, index, prval, pgval, pbval)
	Return RetObj
End Function
' SRC\colormap.c (299, 1)
' pixcmapAddColor(cmap, rval, gval, bval) as Integer
' pixcmapAddColor(PIXCMAP *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This always adds the color if there is room.<para/>
''' (2) The alpha component is 255 (opaque)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixcmapAddColor/*"/>
'''  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Function pixcmapAddColor(
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer) as Integer
	Dim RetObj = _All.pixcmapAddColor(me, rval, gval, bval)
	Return RetObj
End Function

End Class
