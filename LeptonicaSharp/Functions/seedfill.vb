Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\seedfill.c (243, 1)
' pixSeedfillBinary()
' pixSeedfillBinary(PIX *, PIX *, PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This is for binary seedfill (aka "binary reconstruction").
''' (2) There are 3 cases
''' (a) pixd == null (make a new pixd)
''' (b) pixd == pixs (in-place)
''' (c) pixd != pixs
''' (3) If you know the case, use these patterns for clarity
''' (a) pixd = pixSeedfillBinary(NULL, pixs, ...);
''' (b) pixSeedfillBinary(pixs, pixs, ...);
''' (c) pixSeedfillBinary(pixd, pixs, ...);
''' (4) The resulting pixd contains the filled seed.  For some
''' applications you want to OR it with the inverse of
''' the filling mask.
''' (5) The input seed and mask images can be different sizes, but
''' in typical use the difference, if any, would be only
''' a few pixels in each direction.  If the sizes differ,
''' the clipping is handled by the low-level function
''' seedfillBinaryLow().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs; 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSeedfillBinary(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillBinary( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (330, 1)
' pixSeedfillBinaryRestricted()
' pixSeedfillBinaryRestricted(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) See usage for pixSeedfillBinary(), which has unrestricted fill.
''' In pixSeedfillBinary(), the filling distance is unrestricted
''' and can be larger than pixs, depending on the topology of
''' th mask.
''' (2) There are occasions where it is useful not to permit the
''' fill to go more than a certain distance into the mask.
''' %xmax specifies the maximum horizontal distance allowed
''' in the fill; %ymax does likewise in the vertical direction.
''' (3) Operationally, the max "distance" allowed for the fill
''' is a linear distance from the original seed, independent
''' of the actual mask topology.
''' (4) Another formulation of this problem, not implemented,
''' would use the manhattan distance from the seed, as
''' determined by a breadth-first search starting at the seed
''' boundaries and working outward where the mask fg allows.
''' How this might use the constraints of separate xmax and ymax
''' is not clear.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null, equal to pixs, or different from pixs; 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="xmax">[in] - max distance in x direction of fill into the mask</param>
'''  <param name="ymax">[in] - max distance in y direction of fill into the mask</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSeedfillBinaryRestricted(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer, 
				ByVal xmax as Integer, 
				ByVal ymax as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillBinaryRestricted( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity, xmax, ymax)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (605, 1)
' pixHolesByFilling()
' pixHolesByFilling(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) To get 4-c.c. holes of the 8-c.c. as foreground, use
''' 4-connected filling; to get 8-c.c. holes of the 4-c.c.
''' as foreground, use 8-connected filling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd  inverted image of all holes, or NULL on error Action 1 Start with 1-pixel black border on otherwise white pixd 2 Use the inverted pixs as the filling mask to fill in all the pixels from the border to the pixs foreground 3 OR the result with pixs to have an image with all ON pixels except for the holes. 4 Invert the result to get the holes as foreground</returns>
Public Shared Function pixHolesByFilling(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHolesByFilling( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (656, 1)
' pixFillClosedBorders()
' pixFillClosedBorders(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Start with 1-pixel black border on otherwise white pixd
''' (2) Subtract input pixs to remove border pixels that were
''' also on the closed border
''' (3) Use the inverted pixs as the filling mask to fill in
''' all the pixels from the outer border to the closed border
''' on pixs
''' (4) Invert the result to get the filled component, including
''' the input border
''' (5) If the borders are 4-c.c., use 8-c.c. filling, and v.v.
''' (6) Closed borders within c.c. that represent holes, etc., are filled.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all topologically outer closed borders are filled as connected comonents, or NULL on error</returns>
Public Shared Function pixFillClosedBorders(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillClosedBorders( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (694, 1)
' pixExtractBorderConnComps()
' pixExtractBorderConnComps(PIX *, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all pixels in the src that are in connected components touching the border, or NULL on error</returns>
Public Shared Function pixExtractBorderConnComps(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractBorderConnComps( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (733, 1)
' pixRemoveBorderConnComps()
' pixRemoveBorderConnComps(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This removes all fg components touching the border.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all pixels in the src that are not touching the border or NULL on error</returns>
Public Shared Function pixRemoveBorderConnComps(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveBorderConnComps( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (783, 1)
' pixFillBgFromBorder()
' pixFillBgFromBorder(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This fills all bg components touching the border to fg.
''' It is the photometric inverse of pixRemoveBorderConnComps().
''' (2) Invert the result to get the "holes" left after this fill.
''' This can be done multiple times, extracting holes within
''' holes after each pair of fillings.  Specifically, this code
''' peels away n successive embeddings of components
''' \code
''' pix1 = LTinitial imageGT
''' for (i = 0; i LT 2  n; i++) {
''' pix2 = pixFillBgFromBorder(pix1, 8);
''' pixInvert(pix2, pix2);
''' pixDestroy(pix1);
''' pix1 = pix2;
''' }
''' \endcode
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd with the background c.c. touching the border filled to foreground, or NULL on error</returns>
Public Shared Function pixFillBgFromBorder(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillBgFromBorder( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (842, 1)
' pixFillHolesToBoundingRect()
' pixFillHolesToBoundingRect(PIX *, l_int32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This does not fill holes that are smaller in area than 'minsize'.
''' (2) This does not fill holes with an area larger than
''' 'maxhfract' times the fg area of the c.c.
''' (3) This does not expand the fg of the c.c. to bounding rect if
''' the fg area is less than 'minfgfract' times the area of the
''' bounding rect.
''' (4) The decisions are made as follows
''' ~ Decide if we are filling the holes; if so, when using
''' the fg area, include the filled holes.
''' ~ Decide based on the fg area if we are filling to a bounding rect.
''' If so, do it.
''' If not, fill the holes if the condition is satisfied.
''' (5) The choice of minsize depends on the resolution.
''' (6) For solidifying image mask regions on printed materials,
''' which tend to be rectangular, values for maxhfract
''' and minfgfract around 0.5 are reasonable.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="minsize">[in] - min number of pixels in the hole</param>
'''  <param name="maxhfract">[in] - max hole area as fraction of fg pixels in the cc</param>
'''  <param name="minfgfract">[in] - min fg area as fraction of bounding rectangle</param>
'''   <returns>pixd pixs, with some holes possibly filled and some c.c. possibly expanded to their bounding rects, or NULL on error</returns>
Public Shared Function pixFillHolesToBoundingRect(
				ByVal pixs as Pix, 
				ByVal minsize as Integer, 
				ByVal maxhfract as Single, 
				ByVal minfgfract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (maxhfract) then Throw New ArgumentNullException  ("maxhfract cannot be Nothing")
	If IsNothing (minfgfract) then Throw New ArgumentNullException  ("minfgfract cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillHolesToBoundingRect( pixs.Pointer, minsize, maxhfract, minfgfract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (923, 1)
' pixSeedfillGray()
' pixSeedfillGray(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place filling operation on the seed, pixs,
''' where the clipping mask is always above or at the level
''' of the seed as it is filled.
''' (2) For details of the operation, see the description in
''' seedfillGrayLow() and the code there.
''' (3) As an example of use, see the description in pixHDome().
''' There, the seed is an image where each pixel is a fixed
''' amount smaller than the corresponding mask pixel.
''' (4) Reference paper 
''' L. Vincent, Morphological grayscale reconstruction in image
''' analysis applications and efficient algorithms, IEEE Transactions
''' on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp seed; filled in place</param>
'''  <param name="pixm">[in] - 8 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfillGray(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfillGray( pixs.Pointer, pixm.Pointer, connectivity)

	Return _Result
End Function

' SRC\seedfill.c (982, 1)
' pixSeedfillGrayInv()
' pixSeedfillGrayInv(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place filling operation on the seed, pixs,
''' where the clipping mask is always below or at the level
''' of the seed as it is filled.  Think of filling up a basin
''' to a particular level, given by the maximum seed value
''' in the basin.  Outside the filled region, the mask
''' is above the filling level.
''' (2) Contrast this with pixSeedfillGray(), where the clipping mask
''' is always above or at the level of the fill.  An example
''' of its use is the hdome fill, where the seed is an image
''' where each pixel is a fixed amount smaller than the
''' corresponding mask pixel.
''' (3) The basin fill, pixSeedfillGrayBasin(), is a special case
''' where the seed pixel values are generated from the mask,
''' and where the implementation uses pixSeedfillGray() by
''' inverting both the seed and mask.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp seed; filled in place</param>
'''  <param name="pixm">[in] - 8 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfillGrayInv(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfillGrayInv( pixs.Pointer, pixm.Pointer, connectivity)

	Return _Result
End Function

' SRC\seedfill.c (1969, 1)
' pixSeedfillGraySimple()
' pixSeedfillGraySimple(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place filling operation on the seed, pixs,
''' where the clipping mask is always above or at the level
''' of the seed as it is filled.
''' (2) For details of the operation, see the description in
''' seedfillGrayLowSimple() and the code there.
''' (3) As an example of use, see the description in pixHDome().
''' There, the seed is an image where each pixel is a fixed
''' amount smaller than the corresponding mask pixel.
''' (4) Reference paper 
''' L. Vincent, Morphological grayscale reconstruction in image
''' analysis applications and efficient algorithms, IEEE Transactions
''' on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp seed; filled in place</param>
'''  <param name="pixm">[in] - 8 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfillGraySimple(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfillGraySimple( pixs.Pointer, pixm.Pointer, connectivity)

	Return _Result
End Function

' SRC\seedfill.c (2040, 1)
' pixSeedfillGrayInvSimple()
' pixSeedfillGrayInvSimple(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is an in-place filling operation on the seed, pixs,
''' where the clipping mask is always below or at the level
''' of the seed as it is filled.  Think of filling up a basin
''' to a particular level, given by the maximum seed value
''' in the basin.  Outside the filled region, the mask
''' is above the filling level.
''' (2) Contrast this with pixSeedfillGraySimple(), where the clipping mask
''' is always above or at the level of the fill.  An example
''' of its use is the hdome fill, where the seed is an image
''' where each pixel is a fixed amount smaller than the
''' corresponding mask pixel.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp seed; filled in place</param>
'''  <param name="pixm">[in] - 8 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfillGrayInvSimple(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfillGrayInvSimple( pixs.Pointer, pixm.Pointer, connectivity)

	Return _Result
End Function

' SRC\seedfill.c (2442, 1)
' pixSeedfillGrayBasin()
' pixSeedfillGrayBasin(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This fills from a seed within basins defined by a filling mask.
''' The seed value(s) are greater than the corresponding
''' filling mask value, and the result has the bottoms of
''' the basins raised by the initial seed value.
''' (2) The seed has value 255 except where pixb has fg (1), which
''' are the seed 'locations'.  At the seed locations, the seed
''' value is the corresponding value of the mask pixel in pixm
''' plus %delta.  If %delta == 0, we return a copy of pixm.
''' (3) The actual filling is done using the standard grayscale filling
''' operation on the inverse of the mask and using the inverse
''' of the seed image.  After filling, we return the inverse of
''' the filled seed.
''' (4) As an example of use pixm can describe a grayscale image
''' of text, where the (dark) text pixels are basins of
''' low values; pixb can identify the local minima in pixm (say, at
''' the bottom of the basins); and delta is the amount that we wish
''' to raise (lighten) the basins.  We construct the seed
''' (a.k.a marker) image from pixb, pixm and %delta.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixb">[in] - binary mask giving seed locations</param>
'''  <param name="pixm">[in] - 8 bpp basin-type filling mask</param>
'''  <param name="delta">[in] - amount of seed value above mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd filled seed if OK, NULL on error</returns>
Public Shared Function pixSeedfillGrayBasin(
				ByVal pixb as Pix, 
				ByVal pixm as Pix, 
				ByVal delta as Integer, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillGrayBasin( pixb.Pointer, pixm.Pointer, delta, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (2533, 1)
' pixDistanceFunction()
' pixDistanceFunction(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This computes the distance of each pixel from the nearest
''' background pixel.  All bg pixels therefore have a distance of 0,
''' and the fg pixel distances increase linearly from 1 at the
''' boundary.  It can also be used to compute the distance of
''' each pixel from the nearest fg pixel, by inverting the input
''' image before calling this function.  Then all fg pixels have
''' a distance 0 and the bg pixel distances increase linearly
''' from 1 at the boundary.
''' (2) The algorithm, described in Leptonica on the page on seed
''' filling and connected components, is due to Luc Vincent.
''' In brief, we generate an 8 or 16 bpp image, initialized
''' with the fg pixels of the input pix set to 1 and the
''' 1-boundary pixels (i.e., the boundary pixels of width 1 on
''' the four sides set as either
''' L_BOUNDARY_BG 0
''' L_BOUNDARY_FG  max
''' where max = 0xff for 8 bpp and 0xffff for 16 bpp.
''' Then do raster/anti-raster sweeps over all pixels interior
''' to the 1-boundary, where the value of each new pixel is
''' taken to be 1 more than the minimum of the previously-seen
''' connected pixels (using either 4 or 8 connectivity).
''' Finally, set the 1-boundary pixels using the mirrored method;
''' this removes the max values there.
''' (3) Using L_BOUNDARY_BG clamps the distance to 0 at the
''' boundary.  Using L_BOUNDARY_FG allows the distance
''' at the image boundary to "float".
''' (4) For 4-connected, one could initialize only the left and top
''' 1-boundary pixels, and go all the way to the right
''' and bottom; then coming back reset left and top.  But we
''' instead use a method that works for both 4- and 8-connected.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp source</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="outdepth">[in] - 8 or 16 bits for pixd</param>
'''  <param name="boundcond">[in] - L_BOUNDARY_BG, L_BOUNDARY_FG</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixDistanceFunction(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer, 
				ByVal outdepth as Integer, 
				ByVal boundcond as Enumerations.L_BOUNDARY_G) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDistanceFunction( pixs.Pointer, connectivity, outdepth, boundcond)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (2791, 1)
' pixSeedspread()
' pixSeedspread(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) The raster/anti-raster method for implementing this filling
''' operation was suggested by Ray Smith.
''' (2) This takes an arbitrary set of nonzero pixels in pixs, which
''' can be sparse, and spreads (extrapolates) the values to
''' fill all the pixels in pixd with the nonzero value it is
''' closest to in pixs.  This is similar (though not completely
''' equivalent) to doing a Voronoi tiling of the image, with a
''' tile surrounding each pixel that has a nonzero value.
''' All pixels within a tile are then closer to its "central"
''' pixel than to any others.  Then assign the value of the
''' "central" pixel to each pixel in the tile.
''' (3) This is implemented by computing a distance function in parallel
''' with the fill.  The distance function uses free boundary
''' conditions (assumed maxval outside), and it controls the
''' propagation of the pixels in pixd away from the nonzero
''' (seed) values.  This is done in 2 traversals (raster/antiraster).
''' In the raster direction, whenever the distance function
''' is nonzero, the spread pixel takes on the value of its
''' predecessor that has the minimum distance value.  In the
''' antiraster direction, whenever the distance function is nonzero
''' and its value is replaced by a smaller value, the spread
''' pixel takes the value of the predecessor with the minimum
''' distance value.
''' (4) At boundaries where a pixel is equidistant from two
''' nearest nonzero (seed) pixels, the decision of which value
''' to use is arbitrary (greedy in search for minimum distance).
''' This can give rise to strange-looking results, particularly
''' for 4-connectivity where the L1 distance is computed from
''' steps in N,S,E and W directions (no diagonals).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp source</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixSeedspread(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedspread( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (3018, 1)
' pixLocalExtrema()
' pixLocalExtrema(PIX *, l_int32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) This gives the actual local minima and maxima.
''' A local minimum is a pixel whose surrounding pixels all
''' have values at least as large, and likewise for a local
''' maximum.  For the local minima, %maxmin is the upper
''' bound for the value of pixs.  Likewise, for the local maxima,
''' %minmax is the lower bound for the value of pixs.
''' (2) The minima are found by starting with the erosion-and-equality
''' approach of pixSelectedLocalExtrema().  This is followed
''' by a qualification step, where each c.c. in the resulting
''' minimum mask is extracted, the pixels bordering it are
''' located, and they are queried.  If all of those pixels
''' are larger than the value of that minimum, it is a true
''' minimum and its c.c. is saved; otherwise the c.c. is
''' rejected.  Note that if a bordering pixel has the
''' same value as the minimum, it must then have a
''' neighbor that is smaller, so the component is not a
''' true minimum.
''' (3) The maxima are found by inverting the image and looking
''' for the minima there.
''' (4) The generated masks can be used as markers for
''' further operations.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="maxmin">[in] - max allowed for the min in a 3x3 neighborhood; use 0 for default which is to have no upper bound</param>
'''  <param name="minmax">[in] - min allowed for the max in a 3x3 neighborhood; use 0 for default which is to have no lower bound</param>
'''  <param name="ppixmin">[out][optional] - mask of local minima</param>
'''  <param name="ppixmax">[out][optional] - mask of local maxima</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixLocalExtrema(
				ByVal pixs as Pix, 
				ByVal maxmin as Integer, 
				ByVal minmax as Integer, 
				Optional ByRef ppixmin as Pix = Nothing, 
				Optional ByRef ppixmax as Pix = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck

Dim ppixminPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmin) Then ppixminPTR = ppixmin.Pointer
Dim ppixmaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmax) Then ppixmaxPTR = ppixmax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixLocalExtrema( pixs.Pointer, maxmin, minmax, ppixminPTR, ppixmaxPTR)
	if ppixminPTR <> IntPtr.Zero then ppixmin = new Pix(ppixminPTR)
	if ppixmaxPTR <> IntPtr.Zero then ppixmax = new Pix(ppixmaxPTR)

	Return _Result
End Function

' SRC\seedfill.c (3190, 1)
' pixSelectedLocalExtrema()
' pixSelectedLocalExtrema(PIX *, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' Notes
''' (1) This selects those local 3x3 minima that are at least a
''' specified distance from the nearest local 3x3 maxima, and v.v.
''' for the selected set of local 3x3 maxima.
''' The local 3x3 minima is the set of pixels whose value equals
''' the value after a 3x3 brick erosion, and the local 3x3 maxima
''' is the set of pixels whose value equals the value after
''' a 3x3 brick dilation.
''' (2) mindist is the minimum distance allowed between
''' local 3x3 minima and local 3x3 maxima, in an 8-connected sense.
''' mindist == 1 keeps all pixels found in step 1.
''' mindist == 0 removes all pixels from each mask that are
''' both a local 3x3 minimum and a local 3x3 maximum.
''' mindist == 1 removes any local 3x3 minimum pixel that touches a
''' local 3x3 maximum pixel, and likewise for the local maxima.
''' To make the decision, visualize each local 3x3 minimum pixel
''' as being surrounded by a square of size (2  mindist + 1)
''' on each side, such that no local 3x3 maximum pixel is within
''' that square; and v.v.
''' (3) The generated masks can be used as markers for further operations.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="mindist">[in] - -1 for keeping all pixels; GT= 0 specifies distance</param>
'''  <param name="ppixmin">[out] - mask of local minima</param>
'''  <param name="ppixmax">[out] - mask of local maxima</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSelectedLocalExtrema(
				ByVal pixs as Pix, 
				ByVal mindist as Integer, 
				ByRef ppixmin as Pix, 
				ByRef ppixmax as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck

	Dim ppixminPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmin) Then ppixminPTR = ppixmin.Pointer
	Dim ppixmaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmax) Then ppixmaxPTR = ppixmax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSelectedLocalExtrema( pixs.Pointer, mindist, ppixminPTR, ppixmaxPTR)
	if ppixminPTR <> IntPtr.Zero then ppixmin = new Pix(ppixminPTR)
	if ppixmaxPTR <> IntPtr.Zero then ppixmax = new Pix(ppixmaxPTR)

	Return _Result
End Function

' SRC\seedfill.c (3250, 1)
' pixFindEqualValues()
' pixFindEqualValues(PIX *, PIX *) as PIX *
'''  <summary>
''' Notes
''' (1) The two images are aligned at the UL corner, and the returned
''' image has ON pixels where the pixels in pixs1 and pixs2
''' have equal values.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs1">[in] - 8 bpp</param>
'''  <param name="pixs2">[in] - 8 bpp</param>
'''   <returns>pixd 1 bpp mask, or NULL on error</returns>
Public Shared Function pixFindEqualValues(
				ByVal pixs1 as Pix, 
				ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")
	If {8}.contains (pixs1.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck
	If {8}.contains (pixs2.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindEqualValues( pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (3317, 1)
' pixSelectMinInConnComp()
' pixSelectMinInConnComp(PIX *, PIX *, PTA **, NUMA **) as l_ok
'''  <summary>
''' Notes
''' (1) For each 8 connected component in pixm, this finds
''' a pixel in pixs that has the lowest value, and saves
''' it in a Pta.  If several pixels in pixs have the same
''' minimum value, it picks the first one found.
''' (2) For a mask pixm of true local minima, all pixels in each
''' connected component have the same value in pixs, so it is
''' fastest to select one of them using a special seedfill
''' operation.  Not yet implemented.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="pixm">[in] - 1 bpp</param>
'''  <param name="ppta">[out] - pta of min pixel locations</param>
'''  <param name="pnav">[out][optional] - numa of minima values</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSelectMinInConnComp(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByRef ppta as Pta, 
				Optional ByRef pnav as Numa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp") ' All Functions - All Parameters - CommentCheck
	If {1}.contains (pixm.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pptaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppta) Then pptaPTR = ppta.Pointer
Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSelectMinInConnComp( pixs.Pointer, pixm.Pointer, pptaPTR, pnavPTR)
	if pptaPTR <> IntPtr.Zero then ppta = new Pta(pptaPTR)
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)

	Return _Result
End Function

' SRC\seedfill.c (3430, 1)
' pixRemoveSeededComponents()
' pixRemoveSeededComponents(PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This removes each component in pixm for which there is
''' at least one seed in pixs.  If pixd == NULL, this returns
''' the result in a new pixd.  Otherwise, it is an in-place
''' operation on pixm.  In no situation is pixs altered,
''' because we do the filling with a copy of pixs.
''' (2) If bordersize GT 0, it also clears all pixels within a
''' distance %bordersize of the edge of pixd.  This is here
''' because pixLocalExtrema() typically finds local minima
''' at the border.  Use %bordersize GT= 2 to remove these.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - ; this can be null or equal to pixm; 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="bordersize">[in] - amount of border clearing</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRemoveSeededComponents(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal connectivity as Integer, 
				ByVal bordersize as Integer, 
				Optional ByVal pixd as Pix = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveSeededComponents( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity, bordersize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
