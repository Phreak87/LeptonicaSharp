Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\colorseg.c (129, 1)
' pixColorSegment()
' pixColorSegment(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Color segmentation proceeds in four phases
''' Phase 1  pixColorSegmentCluster()
''' The image is traversed in raster order.  Each pixel either
''' becomes the representative for a new cluster or is assigned to an
''' existing cluster.  Assignment is greedy.  The data is stored in
''' a colormapped image.  Three auxiliary arrays are used to hold
''' the colors of the representative pixels, for fast lookup.
''' The average color in each cluster is computed.
''' Phase 2.  pixAssignToNearestColor()
''' A second non-greedy clustering pass is performed, where each pixel
''' is assigned to the nearest cluster average.  We also keep track
''' of how many pixels are assigned to each cluster.
''' Phase 3.  pixColorSegmentClean()
''' For each cluster, starting with the largest, do a morphological
''' closing to eliminate small components within larger ones.
''' Phase 4.  pixColorSegmentRemoveColors()
''' Eliminate all colors except the most populated 'finalcolors'.
''' Then remove unused colors from the colormap, and reassign those
''' pixels to the nearest remaining cluster, using the original pixel values.
''' Notes
''' (1) The goal is to generate a small number of colors.
''' Typically this would be specified by 'finalcolors',
''' a number that would be somewhere between 3 and 6.
''' The parameter 'maxcolors' specifies the maximum number of
''' colors generated in the first phase.  This should be
''' larger than finalcolors, perhaps twice as large.
''' If more than 'maxcolors' are generated in the first phase
''' using the input 'maxdist', the distance is repeatedly
''' increased by a multiplicative factor until the condition
''' is satisfied.  The implicit relation between 'maxdist'
''' and 'maxcolors' is thus adjusted programmatically.
''' (2) As a very rough guideline, given a target value of 'finalcolors',
''' here are approximate values of 'maxdist' and 'maxcolors'
''' to start with
''' finalcolors maxcolors maxdist
''' ----------- --------- -------
''' 3 6 100
''' 4 8  90
''' 5   10  75
''' 6   12  60
''' For a given number of finalcolors, if you use too many
''' maxcolors, the result will be noisy.  If you use too few,
''' the result will be a relatively poor assignment of colors.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp; 24-bit color</param>
'''  <param name="maxdist">[in] - max euclidean dist to existing cluster</param>
'''  <param name="maxcolors">[in] - max number of colors allowed in first pass</param>
'''  <param name="selsize">[in] - linear size of sel for closing to remove noise</param>
'''  <param name="finalcolors">[in] - max number of final colors allowed after 4th pass</param>
'''  <param name="debugflag">[in] - 1 for debug output; 0 otherwise</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixColorSegment(
				ByVal pixs as Pix, 
				ByVal maxdist as Integer, 
				ByVal maxcolors as Integer, 
				ByVal selsize as Integer, 
				ByVal finalcolors as Integer, 
				ByVal debugflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorSegment( pixs.Pointer, maxdist, maxcolors, selsize, finalcolors, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorseg.c (200, 1)
' pixColorSegmentCluster()
' pixColorSegmentCluster(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is phase 1.  See description in pixColorSegment().
''' (2) Greedy unsupervised classification.  If the limit 'maxcolors'
''' is exceeded, the computation is repeated with a larger
''' allowed cluster size.
''' (3) On each successive iteration, 'maxdist' is increased by a
''' constant factor.  See comments in pixColorSegment() for
''' a guideline on parameter selection.
''' Note that the diagonal of the 8-bit rgb color cube is about
''' 440, so for 'maxdist' = 440, you are guaranteed to get 1 color!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp; 24-bit color</param>
'''  <param name="maxdist">[in] - max euclidean dist to existing cluster</param>
'''  <param name="maxcolors">[in] - max number of colors allowed in first pass</param>
'''  <param name="debugflag">[in] - 1 for debug output; 0 otherwise</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixColorSegmentCluster(
				ByVal pixs as Pix, 
				ByVal maxdist as Integer, 
				ByVal maxcolors as Integer, 
				ByVal debugflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorSegmentCluster( pixs.Pointer, maxdist, maxcolors, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorseg.c (412, 1)
' pixAssignToNearestColor()
' pixAssignToNearestColor(PIX *, PIX *, PIX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This is used in phase 2 of color segmentation, where pixs
''' is the original input image to pixColorSegment(), and
''' pixd is the colormapped image returned from
''' pixColorSegmentCluster().  It is also used, with a mask,
''' in phase 4.
''' (2) This is an in-place operation.
''' (3) The colormap in pixd is unchanged.
''' (4) pixs and pixd must be the same size (w, h).
''' (5) The selection mask pixm can be null.  If it exists, it must
''' be the same size as pixs and pixd, and only pixels
''' corresponding to fg in pixm are assigned.  Set to
''' NULL if all pixels in pixd are to be assigned.
''' (6) The countarray can be null.  If it exists, it is pre-allocated
''' and of a size at least equal to the size of the colormap in pixd.
''' (7) This does a best-fit (non-greedy) assignment of pixels to
''' existing clusters.  Specifically, it assigns each pixel
''' in pixd to the color index in the pixd colormap that has a
''' color closest to the corresponding rgb pixel in pixs.
''' (8) 'level' is the octcube level used to quickly find the nearest
''' color in the colormap for each pixel.  For color segmentation,
''' this parameter is set to LEVEL_IN_OCTCUBE.
''' (9) We build a mapping table from octcube to colormap index so
''' that this function can run in a time (otherwise) independent
''' of the number of colors in the colormap.  This avoids a
''' brute-force search for the closest colormap color to each
''' pixel in the image.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8 bpp, colormapped</param>
'''  <param name="pixs">[in] - 32 bpp; 24-bit color</param>
'''  <param name="pixm">[in][optional] - 1 bpp</param>
'''  <param name="level">[in] - of octcube used for finding nearest color in cmap</param>
'''  <param name="countarray">[in][optional] - ptr to array, in which we can store the number of pixels found in each color in the colormap in pixd</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixAssignToNearestColor(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal level as Integer, 
				ByVal countarray as Integer()) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixm.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixAssignToNearestColor( pixd.Pointer, pixs.Pointer, pixmPTR, level, countarray)

	Return _Result
End Function

' SRC\colorseg.c (512, 1)
' pixColorSegmentClean()
' pixColorSegmentClean(PIX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This operation is in-place.
''' (2) This is phase 3 of color segmentation.  It is the first
''' part of a two-step noise removal process.  Colors with a
''' large population are closed first; this operation absorbs
''' small sets of intercolated pixels of a different color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, colormapped</param>
'''  <param name="selsize">[in] - for closing</param>
'''  <param name="countarray">[in] - ptr to array containing the number of pixels found in each color in the colormap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorSegmentClean(
				ByVal pixs as Pix, 
				ByVal selsize as Integer, 
				ByVal countarray as Integer()) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (countarray) then Throw New ArgumentNullException  ("countarray cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorSegmentClean( pixs.Pointer, selsize, countarray)

	Return _Result
End Function

' SRC\colorseg.c (584, 1)
' pixColorSegmentRemoveColors()
' pixColorSegmentRemoveColors(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This operation is in-place.
''' (2) This is phase 4 of color segmentation, and the second part
''' of the 2-step noise removal.  Only 'finalcolors' different
''' colors are retained, with colors with smaller populations
''' being replaced by the nearest color of the remaining colors.
''' For highest accuracy, for pixels that are being replaced,
''' we find the nearest colormap color  to the original rgb color.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - 8 bpp, colormapped</param>
'''  <param name="pixs">[in] - 32 bpp rgb, with initial pixel values</param>
'''  <param name="finalcolors">[in] - max number of colors to retain</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixColorSegmentRemoveColors(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal finalcolors as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixColorSegmentRemoveColors( pixd.Pointer, pixs.Pointer, finalcolors)

	Return _Result
End Function

End Class
