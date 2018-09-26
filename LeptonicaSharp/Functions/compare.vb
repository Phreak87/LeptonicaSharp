Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\compare.c (150, 1)
' pixEqual()
' pixEqual(PIX *, PIX *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) Equality is defined as having the same pixel values for
''' each respective image pixel.
''' (2) This works on two pix of any depth.  If one or both pix
''' have a colormap, the depths can be different and the
''' two pix can still be equal.
''' (3) This ignores the alpha component for 32 bpp images.
''' (4) If both pix have colormaps and the depths are equal,
''' use the pixEqualWithCmap() function, which does a fast
''' comparison if the colormaps are identical and a relatively
''' slow comparison otherwise.
''' (5) In all other cases, any existing colormaps must first be
''' removed before doing pixel comparison.  After the colormaps
''' are removed, the resulting two images must have the same depth.
''' The "lowest common denominator" is RGB, but this is only
''' chosen when necessary, or when both have colormaps but
''' different depths.
''' (6) For images without colormaps that are not 32 bpp, all bits
''' in the image part of the data array must be identical.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - </param>
'''  <param name="pix2">[in] - </param>
'''  <param name="psame">[out] - 1 if same; 0 if different</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixEqual(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByRef psame as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixEqual( pix1.Pointer, pix2.Pointer, psame)

	Return _Result
End Function

' SRC\compare.c (176, 1)
' pixEqualWithAlpha()
' pixEqualWithAlpha(PIX *, PIX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) See notes in pixEqual().
''' (2) This is more general than pixEqual(), in that for 32 bpp
''' RGBA images, where spp = 4, you can optionally include
''' the alpha component in the comparison.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - </param>
'''  <param name="pix2">[in] - </param>
'''  <param name="use_alpha">[in] - 1 to compare alpha in RGBA; 0 to ignore</param>
'''  <param name="psame">[out] - 1 if same; 0 if different</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixEqualWithAlpha(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal use_alpha as Integer, 
				ByRef psame as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixEqualWithAlpha( pix1.Pointer, pix2.Pointer, use_alpha, psame)

	Return _Result
End Function

' SRC\compare.c (378, 1)
' pixEqualWithCmap()
' pixEqualWithCmap(PIX *, PIX *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This returns same = TRUE if the images have identical content.
''' (2) Both pix must have a colormap, and be of equal size and depth.
''' If these conditions are not satisfied, it is not an error;
''' the returned result is same = FALSE.
''' (3) We then check whether the colormaps are the same; if so,
''' the comparison proceeds 32 bits at a time.
''' (4) If the colormaps are different, the comparison is done by
''' slow brute force.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - </param>
'''  <param name="pix2">[in] - </param>
'''  <param name="psame">[out] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixEqualWithCmap(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByRef psame as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixEqualWithCmap( pix1.Pointer, pix2.Pointer, psame)

	Return _Result
End Function

' SRC\compare.c (474, 1)
' cmapEqual()
' cmapEqual(PIXCMAP *, PIXCMAP *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This returns %same = TRUE if the colormaps have identical entries.
''' (2) If %ncomps == 4, the alpha components of the colormaps are also
''' compared.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmap1">[in] - </param>
'''  <param name="cmap2">[in] - </param>
'''  <param name="ncomps">[in] - 3 for RGB, 4 for RGBA</param>
'''  <param name="psame">[out] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function cmapEqual(
				ByVal cmap1 as PixColormap, 
				ByVal cmap2 as PixColormap, 
				ByVal ncomps as Integer, 
				ByRef psame as Integer) as Integer

	If IsNothing (cmap1) then Throw New ArgumentNullException  ("cmap1 cannot be Nothing")
	If IsNothing (cmap2) then Throw New ArgumentNullException  ("cmap2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.cmapEqual( cmap1.Pointer, cmap2.Pointer, ncomps, psame)

	Return _Result
End Function

' SRC\compare.c (532, 1)
' pixUsesCmapColor()
' pixUsesCmapColor(PIX *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This returns color = TRUE if three things are obtained
''' (a) the pix has a colormap
''' (b) the colormap has at least one color entry
''' (c) a color entry is actually used
''' (2) It is used in pixEqual() for comparing two images, in a
''' situation where it is required to know if the colormap
''' has color entries that are actually used in the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, colormap</param>
'''  <param name="pcolor">[out] - TRUE if color found</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixUsesCmapColor(
				ByVal pixs as Pix, 
				ByRef pcolor as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixUsesCmapColor( pixs.Pointer, pcolor)

	Return _Result
End Function

' SRC\compare.c (598, 1)
' pixCorrelationBinary()
' pixCorrelationBinary(PIX *, PIX *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The correlation is a number between 0.0 and 1.0,
''' based on foreground similarity
''' (|1 AND 2|)2
''' correlation =  --------------
''' |1|  |2|
''' where |x| is the count of foreground pixels in image x.
''' If the images are identical, this is 1.0.
''' If they have no fg pixels in common, this is 0.0.
''' If one or both images have no fg pixels, the correlation is 0.0.
''' (2) Typically the two images are of equal size, but this
''' is not enforced.  Instead, the UL corners are aligned.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 1 bpp</param>
'''  <param name="pix2">[in] - 1 bpp</param>
'''  <param name="pval">[out] - correlation</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCorrelationBinary(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByRef pval as Single()) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If {1}.contains (pix1.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {1}.contains (pix2.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCorrelationBinary( pix1.Pointer, pix2.Pointer, pval)

	Return _Result
End Function

' SRC\compare.c (656, 1)
' pixDisplayDiffBinary()
' pixDisplayDiffBinary(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) This gives a color representation of the difference between
''' pix1 and pix2.  The color difference depends on the order.
''' The pixels in pixd have 4 colors
''' unchanged  black (on), white (off)
''' on in pix1, off in pix2 red
''' on in pix2, off in pix1 green
''' (2) This aligns the UL corners of pix1 and pix2, and crops
''' to the overlapping pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 1 bpp</param>
'''  <param name="pix2">[in] - 1 bpp</param>
'''   <returns>pixd 4 bpp cmapped, or NULL on error</returns>
Public Shared Function pixDisplayDiffBinary(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix) as Pix

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If {1}.contains (pix1.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {1}.contains (pix2.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayDiffBinary( pix1.Pointer, pix2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\compare.c (712, 1)
' pixCompareBinary()
' pixCompareBinary(PIX *, PIX *, l_int32, l_float32 *, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) The two images are aligned at the UL corner, and do not
''' need to be the same size.
''' (2) If using L_COMPARE_SUBTRACT, pix2 is subtracted from pix1.
''' (3) The total number of pixels is determined by pix1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 1 bpp</param>
'''  <param name="pix2">[in] - 1 bpp</param>
'''  <param name="comptype">[in] - L_COMPARE_XOR, L_COMPARE_SUBTRACT</param>
'''  <param name="pfract">[out] - fraction of pixels that are different</param>
'''  <param name="ppixdiff">[out][optional] - pix of difference</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCompareBinary(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal comptype as Enumerations.L_COMPARE, 
				ByRef pfract as Single(), 
				Optional ByRef ppixdiff as Pix = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If {1}.contains (pix1.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {1}.contains (pix2.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

Dim ppixdiffPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff) Then ppixdiffPTR = ppixdiff.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareBinary( pix1.Pointer, pix2.Pointer, comptype, pfract, ppixdiffPTR)
	if ppixdiffPTR <> IntPtr.Zero then ppixdiff = new Pix(ppixdiffPTR)

	Return _Result
End Function

' SRC\compare.c (788, 1)
' pixCompareGrayOrRGB()
' pixCompareGrayOrRGB(PIX *, PIX *, l_int32, l_int32, l_int32 *, l_float32 *, l_float32 *, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) The two images are aligned at the UL corner, and do not
''' need to be the same size.  If they are not the same size,
''' the comparison will be made over overlapping pixels.
''' (2) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (3) If RGB, each component is compared separately.
''' (4) If type is L_COMPARE_ABS_DIFF, pix2 is subtracted from pix1
''' and the absolute value is taken.
''' (5) If type is L_COMPARE_SUBTRACT, pix2 is subtracted from pix1
''' and the result is clipped to 0.
''' (6) The plot output types are specified in gplot.h.
''' Use 0 if no difference plot is to be made.
''' (7) If the images are pixelwise identical, no difference
''' plot is made, even if requested.  The result (TRUE or FALSE)
''' is optionally returned in the parameter 'same'.
''' (8) The average difference (either subtracting or absolute value)
''' is optionally returned in the parameter 'diff'.
''' (9) The RMS difference is optionally returned in the
''' parameter 'rmsdiff'.  For RGB, we return the average of
''' the RMS differences for each of the components.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 or 16 bpp gray, 32 bpp rgb, or colormapped</param>
'''  <param name="pix2">[in] - 8 or 16 bpp gray, 32 bpp rgb, or colormapped</param>
'''  <param name="comptype">[in] - L_COMPARE_SUBTRACT, L_COMPARE_ABS_DIFF</param>
'''  <param name="plottype">[in] - gplot plot output type, or 0 for no plot</param>
'''  <param name="psame">[out][optional] - 1 if pixel values are identical</param>
'''  <param name="pdiff">[out][optional] - average difference</param>
'''  <param name="prmsdiff">[out][optional] - rms of difference</param>
'''  <param name="ppixdiff">[out][optional] - pix of difference</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCompareGrayOrRGB(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal comptype as Enumerations.L_COMPARE, 
				ByVal plottype as Integer, 
				Optional ByRef psame as Integer = Nothing, 
				Optional ByRef pdiff as Single() = Nothing, 
				Optional ByRef prmsdiff as Single() = Nothing, 
				Optional ByRef ppixdiff as Pix = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

Dim ppixdiffPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff) Then ppixdiffPTR = ppixdiff.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareGrayOrRGB( pix1.Pointer, pix2.Pointer, comptype, plottype, psame, pdiff, prmsdiff, ppixdiffPTR)
	if ppixdiffPTR <> IntPtr.Zero then ppixdiff = new Pix(ppixdiffPTR)

	Return _Result
End Function

' SRC\compare.c (859, 1)
' pixCompareGray()
' pixCompareGray(PIX *, PIX *, l_int32, l_int32, l_int32 *, l_float32 *, l_float32 *, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) See pixCompareGrayOrRGB() for details.
''' (2) Use pixCompareGrayOrRGB() if the input pix are colormapped.
''' (3) Note setting %plottype GT 0 can result in writing named
''' output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 or 16 bpp, not cmapped</param>
'''  <param name="pix2">[in] - 8 or 16 bpp, not cmapped</param>
'''  <param name="comptype">[in] - L_COMPARE_SUBTRACT, L_COMPARE_ABS_DIFF</param>
'''  <param name="plottype">[in] - gplot plot output type, or 0 for no plot</param>
'''  <param name="psame">[out][optional] - 1 if pixel values are identical</param>
'''  <param name="pdiff">[out][optional] - average difference</param>
'''  <param name="prmsdiff">[out][optional] - rms of difference</param>
'''  <param name="ppixdiff">[out][optional] - pix of difference</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCompareGray(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal comptype as Enumerations.L_COMPARE, 
				ByVal plottype as Integer, 
				Optional ByRef psame as Integer = Nothing, 
				Optional ByRef pdiff as Single() = Nothing, 
				Optional ByRef prmsdiff as Single() = Nothing, 
				Optional ByRef ppixdiff as Pix = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

Dim ppixdiffPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff) Then ppixdiffPTR = ppixdiff.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareGray( pix1.Pointer, pix2.Pointer, comptype, plottype, psame, pdiff, prmsdiff, ppixdiffPTR)
	if ppixdiffPTR <> IntPtr.Zero then ppixdiff = new Pix(ppixdiffPTR)

	Return _Result
End Function

' SRC\compare.c (968, 1)
' pixCompareRGB()
' pixCompareRGB(PIX *, PIX *, l_int32, l_int32, l_int32 *, l_float32 *, l_float32 *, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) See pixCompareGrayOrRGB() for details.
''' (2) Note setting %plottype GT 0 can result in writing named
''' output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 32 bpp rgb</param>
'''  <param name="pix2">[in] - 32 bpp rgb</param>
'''  <param name="comptype">[in] - L_COMPARE_SUBTRACT, L_COMPARE_ABS_DIFF</param>
'''  <param name="plottype">[in] - gplot plot output type, or 0 for no plot</param>
'''  <param name="psame">[out][optional] - 1 if pixel values are identical</param>
'''  <param name="pdiff">[out][optional] - average difference</param>
'''  <param name="prmsdiff">[out][optional] - rms of difference</param>
'''  <param name="ppixdiff">[out][optional] - pix of difference</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCompareRGB(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal comptype as Enumerations.L_COMPARE, 
				ByVal plottype as Integer, 
				Optional ByRef psame as Integer = Nothing, 
				Optional ByRef pdiff as Single() = Nothing, 
				Optional ByRef prmsdiff as Single() = Nothing, 
				Optional ByRef ppixdiff as Pix = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If {32}.contains (pix1.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck
	If {32}.contains (pix2.d) = false then Throw New ArgumentException ("32 bpp rgb") ' All Functions - All Parameters - CommentCheck

Dim ppixdiffPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff) Then ppixdiffPTR = ppixdiff.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareRGB( pix1.Pointer, pix2.Pointer, comptype, plottype, psame, pdiff, prmsdiff, ppixdiffPTR)
	if ppixdiffPTR <> IntPtr.Zero then ppixdiff = new Pix(ppixdiffPTR)

	Return _Result
End Function

' SRC\compare.c (1124, 1)
' pixCompareTiled()
' pixCompareTiled(PIX *, PIX *, l_int32, l_int32, l_int32, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) With L_MEAN_ABSVAL, we compute for each tile the
''' average abs value of the pixel component difference between
''' the two (aligned) images.  With L_ROOT_MEAN_SQUARE, we
''' compute instead the rms difference over all components.
''' (2) The two input pix must be the same depth.  Comparison is made
''' using UL corner alignment.
''' (3) For 32 bpp, the distance between corresponding tiles
''' is found by averaging the measured difference over all three
''' components of each pixel in the tile.
''' (4) The result, pixdiff, contains one pixel for each source tile.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 bpp or 32 bpp rgb</param>
'''  <param name="pix2">[in] - 8 bpp 32 bpp rgb</param>
'''  <param name="sx">[in] - tile size; must be GT 1 in each dimension</param>
'''  <param name="sy">[in] - tile size; must be GT 1 in each dimension</param>
'''  <param name="type">[in] - L_MEAN_ABSVAL or L_ROOT_MEAN_SQUARE</param>
'''  <param name="ppixdiff">[out] - pix of difference</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function pixCompareTiled(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal sx as Integer, 
				ByVal sy as Integer, 
				ByVal type as Enumerations.L_statistical_measures, 
				ByRef ppixdiff as Pix) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

	Dim ppixdiffPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff) Then ppixdiffPTR = ppixdiff.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareTiled( pix1.Pointer, pix2.Pointer, sx, sy, type, ppixdiffPTR)
	if ppixdiffPTR <> IntPtr.Zero then ppixdiff = new Pix(ppixdiffPTR)

	Return _Result
End Function

' SRC\compare.c (1218, 1)
' pixCompareRankDifference()
' pixCompareRankDifference(PIX *, PIX *, l_int32) as NUMA *
'''  <summary>
''' Notes
''' (1) This answers the question if the pixel values in each
''' component are compared by absolute difference, for
''' any value of difference, what is the fraction of
''' pixel pairs that have a difference of this magnitude
''' or greater.  For a difference of 0, the fraction is 1.0.
''' In this sense, it is a mapping from pixel difference to
''' rank order of difference.
''' (2) The two images are aligned at the UL corner, and do not
''' need to be the same size.  If they are not the same size,
''' the comparison will be made over overlapping pixels.
''' (3) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (4) If RGB, pixel differences for each component are aggregated
''' into a single histogram.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="pix2">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor; use 0 or 1 for no subsampling</param>
'''   <returns>narank      numa of rank difference, or NULL on error</returns>
Public Shared Function pixCompareRankDifference(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer) as Numa

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCompareRankDifference( pix1.Pointer, pix2.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\compare.c (1303, 1)
' pixTestForSimilarity()
' pixTestForSimilarity(PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_int32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This takes 2 pix that are the same size and determines using
''' 3 input parameters if they are "similar".  The first parameter
''' %mindiff establishes a criterion of pixel-to-pixel similarity
''' two pixels are not similar if their difference in value is
''' at least mindiff.  Then %maxfract and %maxave are thresholds
''' on the number and distribution of dissimilar pixels
''' allowed for the two pix to be similar.   If the pix are
''' to be similar, neither threshold can be exceeded.
''' (2) In setting the %maxfract and %maxave thresholds, you have
''' these options
''' (a) Base the comparison only on %maxfract.  Then set
''' %maxave = 0.0 or 256.0.  (If 0, we always ignore it.)
''' (b) Base the comparison only on %maxave.  Then set
''' %maxfract = 1.0.
''' (c) Base the comparison on both thresholds.
''' (3) Example of values that can be expected at mindiff = 15 when
''' comparing lossless png encoding with jpeg encoding, q=75
''' (smoothish bg) fractdiff = 0.01, avediff = 2.5
''' (natural scene)   fractdiff = 0.13, avediff = 3.5
''' To identify these images as 'similar', select maxfract
''' and maxave to be upper bounds of what you expect.
''' (4) See pixGetDifferenceStats() for a discussion of why we subtract
''' mindiff from the computed average diff of the nonsimilar pixels
''' to get the 'avediff' returned by that function.
''' (5) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (6) If RGB, the maximum difference between pixel components is
''' saved in the histogram.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="pix2">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor; use 0 or 1 for no subsampling</param>
'''  <param name="mindiff">[in] - minimum pixel difference to be counted; GT 0</param>
'''  <param name="maxfract">[in] - maximum fraction of pixels allowed to have diff greater than or equal to mindiff</param>
'''  <param name="maxave">[in] - maximum average difference of pixels allowed for pixels with diff greater than or equal to mindiff, after subtracting mindiff</param>
'''  <param name="psimilar">[out] - 1 if similar, 0 otherwise</param>
'''  <param name="details">[in] - use 1 to give normalized histogram and other data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixTestForSimilarity(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer, 
				ByVal mindiff as Integer, 
				ByVal maxfract as Single, 
				ByVal maxave as Single, 
				ByRef psimilar as Integer, 
				ByVal details as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (maxfract) then Throw New ArgumentNullException  ("maxfract cannot be Nothing")
	If IsNothing (maxave) then Throw New ArgumentNullException  ("maxave cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixTestForSimilarity( pix1.Pointer, pix2.Pointer, factor, mindiff, maxfract, maxave, psimilar, details)

	Return _Result
End Function

' SRC\compare.c (1382, 1)
' pixGetDifferenceStats()
' pixGetDifferenceStats(PIX *, PIX *, l_int32, l_int32, l_float32 *, l_float32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This takes a threshold %mindiff and describes the difference
''' between two images in terms of two numbers
''' (a) the fraction of pixels, %fractdiff, whose difference
''' equals or exceeds the threshold %mindiff, and
''' (b) the average value %avediff of the difference in pixel value
''' for the pixels in the set given by (a), after you subtract
''' %mindiff.  The reason for subtracting %mindiff is that
''' you then get a useful measure for the rate of falloff
''' of the distribution for larger differences.  For example,
''' if %mindiff = 10 and you find that %avediff = 2.5, it
''' says that of the pixels with diff GT 10, the average of
''' their diffs is just mindiff + 2.5 = 12.5.  This is a
''' fast falloff in the histogram with increasing difference.
''' (2) The two images are aligned at the UL corner, and do not
''' need to be the same size.  If they are not the same size,
''' the comparison will be made over overlapping pixels.
''' (3) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (4) If RGB, the maximum difference between pixel components is
''' saved in the histogram.
''' (5) Set %details == 1 to see the difference histogram and get
''' an output that shows for each value of %mindiff, what are the
''' minimum values required for fractdiff and avediff in order
''' that the two pix will be considered similar.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="pix2">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor; use 0 or 1 for no subsampling</param>
'''  <param name="mindiff">[in] - minimum pixel difference to be counted; GT 0</param>
'''  <param name="pfractdiff">[out] - fraction of pixels with diff greater than or equal to mindiff</param>
'''  <param name="pavediff">[out] - average difference of pixels with diff greater than or equal to mindiff, less mindiff</param>
'''  <param name="details">[in] - use 1 to give normalized histogram and other data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetDifferenceStats(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer, 
				ByVal mindiff as Integer, 
				ByRef pfractdiff as Single(), 
				ByRef pavediff as Single(), 
				ByVal details as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetDifferenceStats( pix1.Pointer, pix2.Pointer, factor, mindiff, pfractdiff, pavediff, details)

	Return _Result
End Function

' SRC\compare.c (1484, 1)
' pixGetDifferenceHistogram()
' pixGetDifferenceHistogram(PIX *, PIX *, l_int32) as NUMA *
'''  <summary>
''' Notes
''' (1) The two images are aligned at the UL corner, and do not
''' need to be the same size.  If they are not the same size,
''' the comparison will be made over overlapping pixels.
''' (2) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (3) If RGB, the maximum difference between pixel components is
''' saved in the histogram.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="pix2">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="factor">[in] - subsampling factor; use 0 or 1 for no subsampling</param>
'''   <returns>na     Numa of histogram of differences, or NULL on error</returns>
Public Shared Function pixGetDifferenceHistogram(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer) as Numa

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetDifferenceHistogram( pix1.Pointer, pix2.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\compare.c (1615, 1)
' pixGetPerceptualDiff()
' pixGetPerceptualDiff(PIX *, PIX *, l_int32, l_int32, l_int32, l_float32 *, PIX **, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) This takes 2 pix and determines, using 2 input parameters
''' %dilation specifies the amount of grayscale or color
''' dilation to apply to the images, to compensate for
''' a small amount of misregistration.  A typical number might
''' be 5, which uses a 5x5 Sel.  Grayscale dilation expands
''' lighter pixels into darker pixel regions.
''' %mindiff determines the threshold on the difference in
''' pixel values to be counted -- two pixels are not similar
''' if their difference in value is at least %mindiff.  For
''' color pixels, we use the maximum component difference.
''' (2) The pixelwise comparison is always done with the UL corners
''' aligned.  The sizes of pix1 and pix2 need not be the same,
''' although in practice it can be useful to scale to the same size.
''' (3) If there is a colormap, it is removed and the result
''' is either gray or RGB depending on the colormap.
''' (4) Two optional diff images can be retrieved (typ. for debugging)
''' pixdiff1 the gray or color difference
''' pixdiff2 thresholded to 1 bpp for pixels exceeding %mindiff
''' (5) The returned value of fract can be compared to some threshold,
''' which is application dependent.
''' (6) This method is in analogy to the two-sided hausdorff transform,
''' except here it is for d GT 1.  For d == 1 (see pixRankHaustest()),
''' we verify that when one pix1 is dilated, it covers at least a
''' given fraction of the pixels in pix2, and v.v.; in that
''' case, the two pix are sufficiently similar.  Here, we
''' do an analogous thing subtract the dilated pix1 from pix2 to
''' get a 1-sided hausdorff-like transform.  Then do it the
''' other way.  Take the component-wise max of the two results,
''' and threshold to get the fraction of pixels with a difference
''' below the threshold.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="pixs2">[in] - 8 bpp gray or 32 bpp rgb, or colormapped</param>
'''  <param name="sampling">[in] - subsampling factor; use 0 or 1 for no subsampling</param>
'''  <param name="dilation">[in] - size of grayscale or color Sel; odd</param>
'''  <param name="mindiff">[in] - minimum pixel difference to be counted; GT 0</param>
'''  <param name="pfract">[out] - fraction of pixels with diff greater than mindiff</param>
'''  <param name="ppixdiff1">[out][optional] - showing difference (gray or color)</param>
'''  <param name="ppixdiff2">[out][optional] - showing pixels of sufficient diff</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetPerceptualDiff(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix, 
				ByVal sampling as Integer, 
				ByVal dilation as Integer, 
				ByVal mindiff as Integer, 
				ByRef pfract as Single(), 
				Optional ByRef ppixdiff1 as Pix = Nothing, 
				Optional ByRef ppixdiff2 as Pix = Nothing) as Integer

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

Dim ppixdiff1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff1) Then ppixdiff1PTR = ppixdiff1.Pointer
Dim ppixdiff2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdiff2) Then ppixdiff2PTR = ppixdiff2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetPerceptualDiff( pixs1.Pointer, pixs2.Pointer, sampling, dilation, mindiff, pfract, ppixdiff1PTR, ppixdiff2PTR)
	if ppixdiff1PTR <> IntPtr.Zero then ppixdiff1 = new Pix(ppixdiff1PTR)
	if ppixdiff2PTR <> IntPtr.Zero then ppixdiff2 = new Pix(ppixdiff2PTR)

	Return _Result
End Function

' SRC\compare.c (1778, 1)
' pixGetPSNR()
' pixGetPSNR(PIX *, PIX *, l_int32, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This computes the power S/N ratio, in dB, for the difference
''' between two images.  By convention, the power S/N
''' for a grayscale image is ('log' == log base 10,
''' and 'ln == log base e)
''' PSNR = 10  log((255/MSE)^2)
''' = 4.3429  ln((255/MSE)^2)
''' = -4.3429  ln((MSE/255)^2)
''' where MSE is the mean squared error.
''' Here are some examples
''' MSE PSNR
''' --- ----
''' 10  28.1
''' 3   38.6
''' 1   48.1
''' 0.1 68.1
''' (2) If pix1 and pix2 have the same pixel values, the MSE = 0.0
''' and the PSNR is infinity.  For that case, this returns
''' PSNR = 1000, which corresponds to the very small MSE of
''' about 10^(-48).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="pix2">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="factor">[in] - sampling factor; GT= 1</param>
'''  <param name="ppsnr">[out] - power signal/noise ratio difference</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetPSNR(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer, 
				ByRef ppsnr as Single()) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetPSNR( pix1.Pointer, pix2.Pointer, factor, ppsnr)

	Return _Result
End Function

' SRC\compare.c (1893, 1)
' pixaComparePhotoRegionsByHisto()
' pixaComparePhotoRegionsByHisto(PIXA *, l_float32, l_float32, l_int32, l_int32, l_int32, l_float32, NUMA **, l_float32 **, PIX **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This function takes a pixa of cropped photo images and
''' compares each one to the others for similarity.
''' Each image is first tested to see if it is a photo that can
''' be compared by tiled histograms.  If so, it is padded to put
''' the centroid in the center of the image, and the histograms
''' are generated.  The final step of comparing each histogram
''' with all the others is very fast.
''' (2) An initial filter gives %score = 0 if the ratio of widths
''' and heights (smallest / largest) does not exceed a
''' threshold %minratio.  If set at 1.0, both images must be
''' exactly the same size.  A typical value for %minratio is 0.9.
''' (3) The comparison score between two images is a value in [0.0 .. 1.0].
''' If the comparison score GT= %simthresh, the images are placed in
''' the same similarity class.  Default value for %simthresh is 0.25.
''' (4) An array %nai of similarity class indices for pix in the
''' input pixa is returned.
''' (5) There are two debugging options
''' An optional 2D matrix of scores is returned as a 1D array.
''' A visualization of this is written to a temp file.
''' An optional pix showing the similarity classes can be
''' returned.  Text in each input pix is reproduced.
''' (6) See the notes in pixComparePhotoRegionsByHisto() for details
''' on the implementation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - any depth; colormap OK</param>
'''  <param name="minratio">[in] - requiring sizes be compatible; LT 1.0</param>
'''  <param name="textthresh">[in] - threshold for text/photo; use 0 for default</param>
'''  <param name="factor">[in] - subsampling; GT= 1</param>
'''  <param name="nx">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="ny">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="simthresh">[in] - threshold for similarity; use 0 for default</param>
'''  <param name="pnai">[out] - array  giving similarity class indices</param>
'''  <param name="pscores">[out][optional] - score matrix as 1-D array of size N^2</param>
'''  <param name="ppixd">[out][optional] - pix of similarity classes</param>
'''  <param name="debug">[in] - 1 to output histograms; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaComparePhotoRegionsByHisto(
				ByVal pixa as Pixa, 
				ByVal minratio as Single, 
				ByVal textthresh as Single, 
				ByVal factor as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal simthresh as Single, 
				ByRef pnai as Numa, 
				Optional ByRef pscores as List(Of Single()) = Nothing, 
				Optional ByRef ppixd as Pix = Nothing, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (minratio) then Throw New ArgumentNullException  ("minratio cannot be Nothing")
	If IsNothing (textthresh) then Throw New ArgumentNullException  ("textthresh cannot be Nothing")
	If IsNothing (simthresh) then Throw New ArgumentNullException  ("simthresh cannot be Nothing")

	Dim pnaiPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnai) Then pnaiPTR = pnai.Pointer
Dim pscoresPTR As IntPtr = IntPtr.Zero: if not isNothing (pscores) then pscoresPTR = Marshal.AllocHGlobal(Marshal.SizeOf(pscores.toarray))
Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaComparePhotoRegionsByHisto( pixa.Pointer, minratio, textthresh, factor, nx, ny, simthresh, pnaiPTR, pscoresPTR, ppixdPTR, debug)
	if pnaiPTR <> IntPtr.Zero then pnai = new Numa(pnaiPTR)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\compare.c (2104, 1)
' pixComparePhotoRegionsByHisto()
' pixComparePhotoRegionsByHisto(PIX *, PIX *, BOX *, BOX *, l_float32, l_int32, l_int32, l_int32, l_float32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This function compares two grayscale photo regions.  If a
''' box is given, the region is clipped; otherwise assume
''' the entire images are photo regions.  This is done with a
''' set of (nx  ny) spatially aligned histograms, which are
''' aligned using the centroid of the inverse image.
''' (2) An initial filter gives %score = 0 if the ratio of widths
''' and heights (smallest / largest) does not exceed a
''' threshold %minratio.  This must be between 0.5 and 1.0.
''' If set at 1.0, both images must be exactly the same size.
''' A typical value for %minratio is 0.9.
''' (3) Because this function should not be used on text or
''' line graphics, which can give false positive results
''' (i.e., high scores for different images), filter the images
''' using pixGenPhotoHistos(), which returns tiled histograms
''' only if an image is not text and comparison is expected
''' to work with histograms.  If either image fails the test,
''' the comparison returns a score of 0.0.
''' (4) The white value counts in the histograms are removed; they
''' are typically pixels that were padded to achieve alignment.
''' (5) For an efficient representation of the histogram, normalize
''' using a multiplicative factor so that the number in the
''' maximum bucket is 255.  It then takes 256 bytes to store.
''' (6) When comparing the histograms of two regions, use the
''' Earth Mover distance (EMD), with the histograms normalized
''' so that the sum over bins is the same.  Further normalize
''' by dividing by 255, so that the result is in [0.0 ... 1.0].
''' (7) Get a similarity score S = 1.0 - k  D, where
''' k is a constant, say in the range 5-10
''' D = normalized EMD
''' and for multiple tiles, take the Min(S) to be the final score.
''' Using aligned tiles gives protection against accidental
''' similarity of the overall grayscale histograms.
''' A small number of aligned tiles works well.
''' (8) With debug on, you get a pdf that shows, for each tile,
''' the images, histograms and score.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - any depth; colormap OK</param>
'''  <param name="pix2">[in] - any depth; colormap OK</param>
'''  <param name="box1">[in][optional] - photo regions from each; can be null</param>
'''  <param name="box2">[in][optional] - photo regions from each; can be null</param>
'''  <param name="minratio">[in] - requiring sizes be compatible; LT 1.0</param>
'''  <param name="factor">[in] - subsampling factor; GT= 1</param>
'''  <param name="nx">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="ny">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="pscore">[out] - similarity score of histograms</param>
'''  <param name="debugflag">[in] - 1 for debug output; 0 for no debugging</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixComparePhotoRegionsByHisto(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal minratio as Single, 
				ByVal factor as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByRef pscore as Single(), 
				ByVal debugflag as Integer, 
				Optional ByVal box1 as Box = Nothing, 
				Optional ByVal box2 as Box = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (minratio) then Throw New ArgumentNullException  ("minratio cannot be Nothing")

	Dim box1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(box1) Then box1PTR = box1.Pointer
	Dim box2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(box2) Then box2PTR = box2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixComparePhotoRegionsByHisto( pix1.Pointer, pix2.Pointer, box1PTR, box2PTR, minratio, factor, nx, ny, pscore, debugflag)

	Return _Result
End Function

' SRC\compare.c (2214, 1)
' pixGenPhotoHistos()
' pixGenPhotoHistos(PIX *, BOX *, l_int32, l_float32, l_int32, l_int32, NUMAA **, l_int32 *, l_int32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This crops and converts to 8 bpp if necessary.  It adds a
''' minimal white boundary such that the centroid of the
''' photo-inverted image is in the center. This allows
''' automatic alignment with histograms of other image regions.
''' (2) The white value in the histogram is removed, because of
''' the padding.
''' (3) Use 0 for conservative default (1.3) for thresh.
''' (4) For an efficient representation of the histogram, normalize
''' using a multiplicative factor so that the number in the
''' maximum bucket is 255.  It then takes 256 bytes to store.
''' (5) With %debugindex GT 0, this makes a pdf that shows, for each tile,
''' the images and histograms.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - depth GT 1 bpp; colormap OK</param>
'''  <param name="box">[in][optional] - region to be selected; can be null</param>
'''  <param name="factor">[in] - subsampling; GT= 1</param>
'''  <param name="thresh">[in] - threshold for photo/text; use 0 for default</param>
'''  <param name="nx">[in] - number of subregions to use for histograms; e.g. 3x3</param>
'''  <param name="ny">[in] - number of subregions to use for histograms; e.g. 3x3</param>
'''  <param name="pnaa">[out] - nx  ny 256-entry gray histograms</param>
'''  <param name="pw">[out] - width of image used to make histograms</param>
'''  <param name="ph">[out] - height of image used to make histograms</param>
'''  <param name="debugindex">[in] - 0 for no debugging; positive integer otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGenPhotoHistos(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByVal thresh as Single, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByRef pnaa as Numaa, 
				ByRef pw as Integer, 
				ByRef ph as Integer, 
				ByVal debugindex as Integer, 
				Optional ByVal box as Box = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer
	Dim pnaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaa) Then pnaaPTR = pnaa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGenPhotoHistos( pixs.Pointer, boxPTR, factor, thresh, nx, ny, pnaaPTR, pw, ph, debugindex)
	if pnaaPTR <> IntPtr.Zero then pnaa = new Numaa(pnaaPTR)

	Return _Result
End Function

' SRC\compare.c (2326, 1)
' pixPadToCenterCentroid()
' pixPadToCenterCentroid(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This add minimum white padding to an 8 bpp pix, such that
''' the centroid of the photometric inverse is in the center of
''' the resulting image.  Thus in computing the centroid,
''' black pixels have weight 255, and white pixels have weight 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, colormap OK</param>
'''  <param name="factor">[in] - subsampling for centroid; GT= 1</param>
'''   <returns>pixd padded with white pixels, or NULL on error.</returns>
Public Shared Function pixPadToCenterCentroid(
				ByVal pixs as Pix, 
				ByVal factor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixPadToCenterCentroid( pixs.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\compare.c (2380, 1)
' pixCentroid8()
' pixCentroid8(PIX *, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This first does a photometric inversion (black = 255, white = 0).
''' It then finds the centroid of the result.  The inversion is
''' done because white is usually background, so the centroid
''' is computed based on the "foreground" gray pixels, and the
''' darker the pixel, the more weight it is given.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="factor">[in] - subsampling factor; GT= 1</param>
'''  <param name="pcx">[out] - x value of centroid</param>
'''  <param name="pcy">[out] - y value of centroid</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCentroid8(
				ByVal pixs as Pix, 
				ByVal factor as Integer, 
				ByRef pcx as Single(), 
				ByRef pcy as Single()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCentroid8( pixs.Pointer, factor, pcx, pcy)

	Return _Result
End Function

' SRC\compare.c (2458, 1)
' pixDecideIfPhotoImage()
' pixDecideIfPhotoImage(PIX *, l_int32, l_int32, l_int32, l_float32, NUMAA **, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) The input image must be 8 bpp (no colormap), and padded with
''' white pixels so the centroid of photo-inverted pixels is at
''' the center of the image.
''' (2) If the pix is not almost certainly a photoimage, the returned
''' histograms (%naa) are null.
''' (3) If histograms are generated, the white (255) count is set
''' to 0.  This removes all pixels values above 230, including
''' white padding from the centroid matching operation, from
''' consideration.  The resulting histograms are then normalized
''' so the maximum count is 255.
''' (4) Default for %thresh is 1.3; this seems sufficiently conservative.
''' (5) Use %pixadebug == NULL unless debug output is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 8 bpp, centroid in center</param>
'''  <param name="factor">[in] - subsampling for histograms; GT= 1</param>
'''  <param name="nx">[in] - number of subregions to use for histograms</param>
'''  <param name="ny">[in] - number of subregions to use for histograms</param>
'''  <param name="thresh">[in] - threshold for photo/text; use 0 for default</param>
'''  <param name="pnaa">[out] - array of normalized histograms</param>
'''  <param name="pixadebug">[in][optional] - use only for debug output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixDecideIfPhotoImage(
				ByVal pix as Pix, 
				ByVal factor as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByVal thresh as Single, 
				ByRef pnaa as Numaa, 
				Optional ByVal pixadebug as Pixa = Nothing) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (thresh) then Throw New ArgumentNullException  ("thresh cannot be Nothing")

	Dim pnaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaa) Then pnaaPTR = pnaa.Pointer
	Dim pixadebugPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadebug) Then pixadebugPTR = pixadebug.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixDecideIfPhotoImage( pix.Pointer, factor, nx, ny, thresh, pnaaPTR, pixadebugPTR)
	if pnaaPTR <> IntPtr.Zero then pnaa = new Numaa(pnaaPTR)

	Return _Result
End Function

' SRC\compare.c (2590, 1)
' compareTilesByHisto()
' compareTilesByHisto(NUMAA *, NUMAA *, l_float32, l_int32, l_int32, l_int32, l_int32, l_float32 *, PIXA *) as l_ok
'''  <summary>
''' Notes
''' (1) naa1 and naa2 must be generated using pixGenPhotoHistos(),
''' using the same tile sizes.
''' (2) The image dimensions must be similar.  The score is 0.0
''' if the ratio of widths and heights (smallest / largest)
''' exceeds a threshold %minratio, which must be between
''' 0.5 and 1.0.  If set at 1.0, both images must be exactly
''' the same size.  A typical value for %minratio is 0.9.
''' (2) The input pixadebug is null unless debug output is requested.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa1">[in] - each is a set of 256 entry histograms</param>
'''  <param name="naa2">[in] - each is a set of 256 entry histograms</param>
'''  <param name="minratio">[in] - requiring image sizes be compatible; LT 1.0</param>
'''  <param name="w1">[in] - image sizes from which histograms were made</param>
'''  <param name="h1">[in] - image sizes from which histograms were made</param>
'''  <param name="w2">[in] - image sizes from which histograms were made</param>
'''  <param name="h2">[in] - image sizes from which histograms were made</param>
'''  <param name="pscore">[out] - similarity score of histograms</param>
'''  <param name="pixadebug">[in][optional] - use only for debug output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function compareTilesByHisto(
				ByVal naa1 as Numaa, 
				ByVal naa2 as Numaa, 
				ByVal minratio as Single, 
				ByVal w1 as Integer, 
				ByVal h1 as Integer, 
				ByVal w2 as Integer, 
				ByVal h2 as Integer, 
				ByRef pscore as Single(), 
				Optional ByVal pixadebug as Pixa = Nothing) as Integer

	If IsNothing (naa1) then Throw New ArgumentNullException  ("naa1 cannot be Nothing")
	If IsNothing (naa2) then Throw New ArgumentNullException  ("naa2 cannot be Nothing")
	If IsNothing (minratio) then Throw New ArgumentNullException  ("minratio cannot be Nothing")

	Dim pixadebugPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixadebug) Then pixadebugPTR = pixadebug.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.compareTilesByHisto( naa1.Pointer, naa2.Pointer, minratio, w1, h1, w2, h2, pscore, pixadebugPTR)

	Return _Result
End Function

' SRC\compare.c (2758, 1)
' pixCompareGrayByHisto()
' pixCompareGrayByHisto(PIX *, PIX *, BOX *, BOX *, l_float32, l_int32, l_int32, l_int32, l_int32, l_float32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This function compares two grayscale photo regions.  It can
''' do it with a single histogram from each region, or with a
''' set of (nx  ny) spatially aligned histograms.  For both
''' cases, align the regions using the centroid of the inverse
''' image, and crop to the smallest of the two.
''' (2) An initial filter gives %score = 0 if the ratio of widths
''' and heights (smallest / largest) does not exceed a
''' threshold %minratio.  This must be between 0.5 and 1.0.
''' If set at 1.0, both images must be exactly the same size.
''' A typical value for %minratio is 0.9.
''' (3) The lightest values in the histogram can be disregarded.
''' Set %maxgray to the lightest value to be kept.  For example,
''' to eliminate white (255), set %maxgray = 254.  %maxgray must
''' be GT= 200.
''' (4) For an efficient representation of the histogram, normalize
''' using a multiplicative factor so that the number in the
''' maximum bucket is 255.  It then takes 256 bytes to store.
''' (5) When comparing the histograms of two regions
''' ~ Use %maxgray = 254 to ignore the white pixels, the number
''' of which may be sensitive to the crop region if the pixels
''' outside that region are white.
''' ~ Use the Earth Mover distance (EMD), with the histograms
''' normalized so that the sum over bins is the same.
''' Further normalize by dividing by 255, so that the result
''' is in [0.0 ... 1.0].
''' (6) Get a similarity score S = 1.0 - k  D, where
''' k is a constant, say in the range 5-10
''' D = normalized EMD
''' and for multiple tiles, take the Min(S) to be the final score.
''' Using aligned tiles gives protection against accidental
''' similarity of the overall grayscale histograms.
''' A small number of aligned tiles works well.
''' (7) With debug on, you get a pdf that shows, for each tile,
''' the images, histograms and score.
''' (8) When to use
''' (a) Because this function should not be used on text or
''' line graphics, which can give false positive results
''' (i.e., high scores for different images), the input
''' images should be filtered.
''' (b) To filter, first use pixDecideIfText().  If that function
''' says the image is text, do not use it.  If the function
''' says it is not text, it still may be line graphics, and
''' in that case, use
''' pixGetGrayHistogramTiled()
''' grayInterHistogramStats()
''' to determine whether it is photo or line graphics.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - any depth; colormap OK</param>
'''  <param name="pix2">[in] - any depth; colormap OK</param>
'''  <param name="box1">[in][optional] - region selected from each; can be null</param>
'''  <param name="box2">[in][optional] - region selected from each; can be null</param>
'''  <param name="minratio">[in] - requiring sizes be compatible; LT 1.0</param>
'''  <param name="maxgray">[in] - max value to keep in histo; GT= 200, 255 to keep all</param>
'''  <param name="factor">[in] - subsampling factor; GT= 1</param>
'''  <param name="nx">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="ny">[in] - num subregions to use for histograms; e.g. 3x3</param>
'''  <param name="pscore">[out] - similarity score of histograms</param>
'''  <param name="debugflag">[in] - 1 for debug output; 0 for no debugging</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCompareGrayByHisto(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal minratio as Single, 
				ByVal maxgray as Integer, 
				ByVal factor as Integer, 
				ByVal nx as Integer, 
				ByVal ny as Integer, 
				ByRef pscore as Single(), 
				ByVal debugflag as Integer, 
				Optional ByVal box1 as Box = Nothing, 
				Optional ByVal box2 as Box = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (minratio) then Throw New ArgumentNullException  ("minratio cannot be Nothing")

	Dim box1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(box1) Then box1PTR = box1.Pointer
	Dim box2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(box2) Then box2PTR = box2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareGrayByHisto( pix1.Pointer, pix2.Pointer, box1PTR, box2PTR, minratio, maxgray, factor, nx, ny, pscore, debugflag)

	Return _Result
End Function

' SRC\compare.c (3011, 1)
' pixCropAlignedToCentroid()
' pixCropAlignedToCentroid(PIX *, PIX *, l_int32, BOX **, BOX **) as l_ok
'''  <summary>
''' Notes
''' (1) This finds the maximum crop boxes for two 8 bpp images when
''' their centroids of their photometric inverses are aligned.
''' Black pixels have weight 255; white pixels have weight 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - any depth; colormap OK</param>
'''  <param name="pix2">[in] - any depth; colormap OK</param>
'''  <param name="factor">[in] - subsampling; GT= 1</param>
'''  <param name="pbox1">[out] - crop box for pix1</param>
'''  <param name="pbox2">[out] - crop box for pix2</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCropAlignedToCentroid(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal factor as Integer, 
				ByRef pbox1 as Box, 
				ByRef pbox2 as Box) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

	Dim pbox1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox1) Then pbox1PTR = pbox1.Pointer
	Dim pbox2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox2) Then pbox2PTR = pbox2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCropAlignedToCentroid( pix1.Pointer, pix2.Pointer, factor, pbox1PTR, pbox2PTR)
	if pbox1PTR <> IntPtr.Zero then pbox1 = new Box(pbox1PTR)
	if pbox2PTR <> IntPtr.Zero then pbox2 = new Box(pbox2PTR)

	Return _Result
End Function

' SRC\compare.c (3086, 1)
' l_compressGrayHistograms()
' l_compressGrayHistograms(NUMAA *, l_int32, l_int32, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) This first writes w and h to the byte array as 4 byte ints.
''' (2) Then it normalizes each histogram to a max value of 255,
''' and saves each value as a byte.  If there are
''' N histograms, the output bytearray has 8 + 256  N bytes.
''' (3) Further compression of the array with zlib yields only about
''' a 25% decrease in size, so we don't bother.  If size reduction
''' were important, a lossy transform using a 1-dimensional DCT
''' would be effective, because we don't care about the fine
''' details of these histograms.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="naa">[in] - set of 256-entry histograms</param>
'''  <param name="w">[in] - size of image</param>
'''  <param name="h">[in] - size of image</param>
'''  <param name="psize">[out] - size of byte array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_compressGrayHistograms(
				ByVal naa as Numaa, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByRef psize as UInteger) as Byte()

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_compressGrayHistograms( naa.Pointer, w, h, psize)

	Return _Result
End Function

' SRC\compare.c (3154, 1)
' l_uncompressGrayHistograms()
' l_uncompressGrayHistograms(l_uint8 *, size_t, l_int32 *, l_int32 *) as NUMAA *
'''  <summary>
''' Notes
''' (1) The first 8 bytes are read as two 32-bit ints.
''' (2) Then this constructs a numaa representing some number of
''' gray histograms that are normalized such that the max value
''' in each histogram is 255.  The data is stored as a byte
''' array, with 256 bytes holding the data for each histogram.
''' Each gray histogram was computed from a tile of a grayscale image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="bytea">[in] - byte array of size 8 + 256  N, N an integer</param>
'''  <param name="size">[in] - size of byte array</param>
'''  <param name="pw">[out] - width of the image that generated the histograms</param>
'''  <param name="ph">[out] - height of the image</param>
'''   <returns>numaa     representing N histograms, each with 256 bins, or NULL on error.</returns>
Public Shared Function l_uncompressGrayHistograms(
				ByVal bytea as Byte(), 
				ByVal size as UInteger, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Numaa

	If IsNothing (bytea) then Throw New ArgumentNullException  ("bytea cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_uncompressGrayHistograms( bytea, size, pw, ph)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numaa(_Result)
End Function

' SRC\compare.c (3223, 1)
' pixCompareWithTranslation()
' pixCompareWithTranslation(PIX *, PIX *, l_int32, l_int32 *, l_int32 *, l_float32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This does a coarse-to-fine search for best translational
''' alignment of two images, measured by a scoring function
''' that is the correlation between the fg pixels.
''' (2) The threshold is used if the images aren't 1 bpp.
''' (3) With debug on, you get a pdf that shows, as a grayscale
''' image, the score as a function of shift from the initial
''' estimate, for each of the four levels.  The shift is 0 at
''' the center of the image.
''' (4) With debug on, you also get a pdf that shows the
''' difference at the best alignment between the two images,
''' at each of the four levels.  The red and green pixels
''' show locations where one image has a fg pixel and the
''' other doesn't.  The black pixels are where both images
''' have fg pixels, and white pixels are where neither image
''' has fg pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - any depth; colormap OK</param>
'''  <param name="pix2">[in] - any depth; colormap OK</param>
'''  <param name="thresh">[in] - threshold for converting to 1 bpp</param>
'''  <param name="pdelx">[out] - x translation on pix2 to align with pix1</param>
'''  <param name="pdely">[out] - y translation on pix2 to align with pix1</param>
'''  <param name="pscore">[out] - correlation score at best alignment</param>
'''  <param name="debugflag">[in] - 1 for debug output; 0 for no debugging</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCompareWithTranslation(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal thresh as Integer, 
				ByRef pdelx as Integer, 
				ByRef pdely as Integer, 
				ByRef pscore as Single(), 
				ByVal debugflag as Integer) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCompareWithTranslation( pix1.Pointer, pix2.Pointer, thresh, pdelx, pdely, pscore, debugflag)

	Return _Result
End Function

' SRC\compare.c (3377, 1)
' pixBestCorrelation()
' pixBestCorrelation(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *, l_float32 *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This maximizes the correlation score between two 1 bpp images,
''' by starting with an estimate of the alignment
''' (%etransx, %etransy) and computing the correlation around this.
''' It optionally returns the shift (%delx, %dely) that maximizes
''' the correlation score when pix2 is shifted by this amount
''' relative to pix1.
''' (2) Get the centroids of pix1 and pix2, using pixCentroid(),
''' to compute (%etransx, %etransy).  Get the areas using
''' pixCountPixels().
''' (3) The centroid of pix2 is shifted with respect to the centroid
''' of pix1 by all values between -maxshiftx and maxshiftx,
''' and likewise for the y shifts.  Therefore, the number of
''' correlations computed is
''' (2  maxshiftx + 1)  (2  maxshifty + 1)
''' Consequently, if pix1 and pix2 are large, you should do this
''' in a coarse-to-fine sequence.  See the use of this function
''' in pixCompareWithTranslation().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 1 bpp</param>
'''  <param name="pix2">[in] - 1 bpp</param>
'''  <param name="area1">[in] - number of on pixels in pix1</param>
'''  <param name="area2">[in] - number of on pixels in pix2</param>
'''  <param name="etransx">[in] - estimated x translation of pix2 to align with pix1</param>
'''  <param name="etransy">[in] - estimated y translation of pix2 to align with pix1</param>
'''  <param name="maxshift">[in] - max x and y shift of pix2, around the estimated alignment location, relative to pix1</param>
'''  <param name="tab8">[in][optional] - sum tab for ON pixels in byte; can be NULL</param>
'''  <param name="pdelx">[out][optional] - best x shift of pix2 relative to pix1</param>
'''  <param name="pdely">[out][optional] - best y shift of pix2 relative to pix1</param>
'''  <param name="pscore">[out][optional] - maximum score found; can be NULL</param>
'''  <param name="debugflag">[in] - LT= 0 to skip; positive to generate output. The integer is used to label the debug image.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixBestCorrelation(
				ByVal pix1 as Pix, 
				ByVal pix2 as Pix, 
				ByVal area1 as Integer, 
				ByVal area2 as Integer, 
				ByVal etransx as Integer, 
				ByVal etransy as Integer, 
				ByVal maxshift as Integer, 
				ByVal debugflag as Integer, 
				Optional ByVal tab8 as Integer() = Nothing, 
				Optional ByRef pdelx as Integer = Nothing, 
				Optional ByRef pdely as Integer = Nothing, 
				Optional ByRef pscore as Single() = Nothing) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If {1}.contains (pix1.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck
	If {1}.contains (pix2.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixBestCorrelation( pix1.Pointer, pix2.Pointer, area1, area2, etransx, etransy, maxshift, tab8, pdelx, pdely, pscore, debugflag)

	Return _Result
End Function

End Class
