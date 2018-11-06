Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\seedfill.c (243, 1)
' pixSeedfillBinary(pixd, pixs, pixm, connectivity) as Pix
' pixSeedfillBinary(PIX *, PIX *, PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is for binary seedfill (aka "binary reconstruction").<para/>
''' (2) There are 3 cases:<para/>
''' (a) pixd == null (make a new pixd)<para/>
''' (b) pixd == pixs (in-place)<para/>
''' (c) pixd != pixs<para/>
''' (3) If you know the case, use these patterns for clarity:<para/>
''' (a) pixd = pixSeedfillBinary(NULL, pixs, ...)<para/>
''' (b) pixSeedfillBinary(pixs, pixs, ...)<para/>
''' (c) pixSeedfillBinary(pixd, pixs, ...)<para/>
''' (4) The resulting pixd contains the filled seed.  For some<para/>
''' applications you want to OR it with the inverse of<para/>
''' the filling mask.<para/>
''' (5) The input seed and mask images can be different sizes, but<para/>
''' in typical use the difference, if any, would be only<para/>
''' a few pixels in each direction.  If the sizes differ,<para/>
''' the clipping is handled by the low-level function<para/>
''' seedfillBinaryLow().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillBinary/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSeedfillBinary(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillBinary( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (330, 1)
' pixSeedfillBinaryRestricted(pixd, pixs, pixm, connectivity, xmax, ymax) as Pix
' pixSeedfillBinaryRestricted(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See usage for pixSeedfillBinary(), which has unrestricted fill.<para/>
''' In pixSeedfillBinary(), the filling distance is unrestricted<para/>
''' and can be larger than pixs, depending on the topology of<para/>
''' th mask.<para/>
''' (2) There are occasions where it is useful not to permit the<para/>
''' fill to go more than a certain distance into the mask.<para/>
''' %xmax specifies the maximum horizontal distance allowed<para/>
''' in the fill %ymax does likewise in the vertical direction.<para/>
''' (3) Operationally, the max "distance" allowed for the fill<para/>
''' is a linear distance from the original seed, independent<para/>
''' of the actual mask topology.<para/>
''' (4) Another formulation of this problem, not implemented,<para/>
''' would use the manhattan distance from the seed, as<para/>
''' determined by a breadth-first search starting at the seed<para/>
''' boundaries and working outward where the mask fg allows.<para/>
''' How this might use the constraints of separate xmax and ymax<para/>
''' is not clear.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillBinaryRestricted/*"/>
'''  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="xmax">[in] - max distance in x direction of fill into the mask</param>
'''  <param name="ymax">[in] - max distance in y direction of fill into the mask</param>
'''   <returns>pixd always</returns>
Public Shared Function pixSeedfillBinaryRestricted(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal connectivity as Integer, 
				 ByVal xmax as Integer, 
				 ByVal ymax as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillBinaryRestricted( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity, xmax, ymax)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (605, 1)
' pixHolesByFilling(pixs, connectivity) as Pix
' pixHolesByFilling(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To get 4-c.c. holes of the 8-c.c. as foreground, use<para/>
''' 4-connected filling to get 8-c.c. holes of the 4-c.c.<para/>
''' as foreground, use 8-connected filling.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixHolesByFilling/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd  inverted image of all holes, or NULL on error Action: 1 Start with 1-pixel black border on otherwise white pixd 2 Use the inverted pixs as the filling mask to fill in all the pixels from the border to the pixs foreground 3 OR the result with pixs to have an image with all ON pixels except for the holes. 4 Invert the result to get the holes as foreground</returns>
Public Shared Function pixHolesByFilling(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHolesByFilling( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (656, 1)
' pixFillClosedBorders(pixs, connectivity) as Pix
' pixFillClosedBorders(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Start with 1-pixel black border on otherwise white pixd<para/>
''' (2) Subtract input pixs to remove border pixels that were<para/>
''' also on the closed border<para/>
''' (3) Use the inverted pixs as the filling mask to fill in<para/>
''' all the pixels from the outer border to the closed border<para/>
''' on pixs<para/>
''' (4) Invert the result to get the filled component, including<para/>
''' the input border<para/>
''' (5) If the borders are 4-c.c., use 8-c.c. filling, and v.v.<para/>
''' (6) Closed borders within c.c. that represent holes, etc., are filled.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFillClosedBorders/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all topologically outer closed borders are filled as connected comonents, or NULL on error</returns>
Public Shared Function pixFillClosedBorders(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillClosedBorders( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (694, 1)
' pixExtractBorderConnComps(pixs, connectivity) as Pix
' pixExtractBorderConnComps(PIX *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixExtractBorderConnComps/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all pixels in the src that are in connected components touching the border, or NULL on error</returns>
Public Shared Function pixExtractBorderConnComps(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractBorderConnComps( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (733, 1)
' pixRemoveBorderConnComps(pixs, connectivity) as Pix
' pixRemoveBorderConnComps(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes all fg components touching the border.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRemoveBorderConnComps/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd  all pixels in the src that are not touching the border or NULL on error</returns>
Public Shared Function pixRemoveBorderConnComps(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveBorderConnComps( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (783, 1)
' pixFillBgFromBorder(pixs, connectivity) as Pix
' pixFillBgFromBorder(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This fills all bg components touching the border to fg.<para/>
''' It is the photometric inverse of pixRemoveBorderConnComps().<para/>
''' (2) Invert the result to get the "holes" left after this fill.<para/>
''' This can be done multiple times, extracting holes within<para/>
''' holes after each pair of fillings.  Specifically, this code<para/>
''' peels away n successive embeddings of components:<para/>
''' \code<para/>
''' pix1 =  is lower initial image is greater <para/>
''' for (i = 0 i  is lower  2  n i++) {<para/>
''' pix2 = pixFillBgFromBorder(pix1, 8)<para/>
''' pixInvert(pix2, pix2)<para/>
''' pixDestroy( and pix1)<para/>
''' pix1 = pix2<para/>
''' }<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFillBgFromBorder/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
'''   <returns>pixd with the background c.c. touching the border filled to foreground, or NULL on error</returns>
Public Shared Function pixFillBgFromBorder(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillBgFromBorder( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (842, 1)
' pixFillHolesToBoundingRect(pixs, minsize, maxhfract, minfgfract) as Pix
' pixFillHolesToBoundingRect(PIX *, l_int32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does not fill holes that are smaller in area than 'minsize'.<para/>
''' (2) This does not fill holes with an area larger than<para/>
''' 'maxhfract' times the fg area of the c.c.<para/>
''' (3) This does not expand the fg of the c.c. to bounding rect if<para/>
''' the fg area is less than 'minfgfract' times the area of the<para/>
''' bounding rect.<para/>
''' (4) The decisions are made as follows:<para/>
''' ~ Decide if we are filling the holes if so, when using<para/>
''' the fg area, include the filled holes.<para/>
''' ~ Decide based on the fg area if we are filling to a bounding rect.<para/>
''' If so, do it.<para/>
''' If not, fill the holes if the condition is satisfied.<para/>
''' (5) The choice of minsize depends on the resolution.<para/>
''' (6) For solidifying image mask regions on printed materials,<para/>
''' which tend to be rectangular, values for maxhfract<para/>
''' and minfgfract around 0.5 are reasonable.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFillHolesToBoundingRect/*"/>
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

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFillHolesToBoundingRect( pixs.Pointer, minsize, maxhfract, minfgfract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (923, 1)
' pixSeedfillGray(pixs, pixm, connectivity) as Integer
' pixSeedfillGray(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place filling operation on the seed, pixs,<para/>
''' where the clipping mask is always above or at the level<para/>
''' of the seed as it is filled.<para/>
''' (2) For details of the operation, see the description in<para/>
''' seedfillGrayLow() and the code there.<para/>
''' (3) As an example of use, see the description in pixHDome().<para/>
''' There, the seed is an image where each pixel is a fixed<para/>
''' amount smaller than the corresponding mask pixel.<para/>
''' (4) Reference paper :<para/>
''' L. Vincent, Morphological grayscale reconstruction in image<para/>
''' analysis: applications and efficient algorithms, IEEE Transactions<para/>
''' on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillGray/*"/>
'''  <param name="pixs">[in] - 8 bpp seed filled in place</param>
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
' pixSeedfillGrayInv(pixs, pixm, connectivity) as Integer
' pixSeedfillGrayInv(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place filling operation on the seed, pixs,<para/>
''' where the clipping mask is always below or at the level<para/>
''' of the seed as it is filled.  Think of filling up a basin<para/>
''' to a particular level, given by the maximum seed value<para/>
''' in the basin.  Outside the filled region, the mask<para/>
''' is above the filling level.<para/>
''' (2) Contrast this with pixSeedfillGray(), where the clipping mask<para/>
''' is always above or at the level of the fill.  An example<para/>
''' of its use is the hdome fill, where the seed is an image<para/>
''' where each pixel is a fixed amount smaller than the<para/>
''' corresponding mask pixel.<para/>
''' (3) The basin fill, pixSeedfillGrayBasin(), is a special case<para/>
''' where the seed pixel values are generated from the mask,<para/>
''' and where the implementation uses pixSeedfillGray() by<para/>
''' inverting both the seed and mask.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillGrayInv/*"/>
'''  <param name="pixs">[in] - 8 bpp seed filled in place</param>
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
' pixSeedfillGraySimple(pixs, pixm, connectivity) as Integer
' pixSeedfillGraySimple(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place filling operation on the seed, pixs,<para/>
''' where the clipping mask is always above or at the level<para/>
''' of the seed as it is filled.<para/>
''' (2) For details of the operation, see the description in<para/>
''' seedfillGrayLowSimple() and the code there.<para/>
''' (3) As an example of use, see the description in pixHDome().<para/>
''' There, the seed is an image where each pixel is a fixed<para/>
''' amount smaller than the corresponding mask pixel.<para/>
''' (4) Reference paper :<para/>
''' L. Vincent, Morphological grayscale reconstruction in image<para/>
''' analysis: applications and efficient algorithms, IEEE Transactions<para/>
''' on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillGraySimple/*"/>
'''  <param name="pixs">[in] - 8 bpp seed filled in place</param>
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
' pixSeedfillGrayInvSimple(pixs, pixm, connectivity) as Integer
' pixSeedfillGrayInvSimple(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place filling operation on the seed, pixs,<para/>
''' where the clipping mask is always below or at the level<para/>
''' of the seed as it is filled.  Think of filling up a basin<para/>
''' to a particular level, given by the maximum seed value<para/>
''' in the basin.  Outside the filled region, the mask<para/>
''' is above the filling level.<para/>
''' (2) Contrast this with pixSeedfillGraySimple(), where the clipping mask<para/>
''' is always above or at the level of the fill.  An example<para/>
''' of its use is the hdome fill, where the seed is an image<para/>
''' where each pixel is a fixed amount smaller than the<para/>
''' corresponding mask pixel.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillGrayInvSimple/*"/>
'''  <param name="pixs">[in] - 8 bpp seed filled in place</param>
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
' pixSeedfillGrayBasin(pixb, pixm, delta, connectivity) as Pix
' pixSeedfillGrayBasin(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This fills from a seed within basins defined by a filling mask.<para/>
''' The seed value(s) are greater than the corresponding<para/>
''' filling mask value, and the result has the bottoms of<para/>
''' the basins raised by the initial seed value.<para/>
''' (2) The seed has value 255 except where pixb has fg (1), which<para/>
''' are the seed 'locations'.  At the seed locations, the seed<para/>
''' value is the corresponding value of the mask pixel in pixm<para/>
''' plus %delta.  If %delta == 0, we return a copy of pixm.<para/>
''' (3) The actual filling is done using the standard grayscale filling<para/>
''' operation on the inverse of the mask and using the inverse<para/>
''' of the seed image.  After filling, we return the inverse of<para/>
''' the filled seed.<para/>
''' (4) As an example of use: pixm can describe a grayscale image<para/>
''' of text, where the (dark) text pixels are basins of<para/>
''' low values pixb can identify the local minima in pixm (say, at<para/>
''' the bottom of the basins) and delta is the amount that we wish<para/>
''' to raise (lighten) the basins.  We construct the seed<para/>
''' (a.k.a marker) image from pixb, pixm and %delta.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedfillGrayBasin/*"/>
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
' pixDistanceFunction(pixs, connectivity, outdepth, boundcond) as Pix
' pixDistanceFunction(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This computes the distance of each pixel from the nearest<para/>
''' background pixel.  All bg pixels therefore have a distance of 0,<para/>
''' and the fg pixel distances increase linearly from 1 at the<para/>
''' boundary.  It can also be used to compute the distance of<para/>
''' each pixel from the nearest fg pixel, by inverting the input<para/>
''' image before calling this function.  Then all fg pixels have<para/>
''' a distance 0 and the bg pixel distances increase linearly<para/>
''' from 1 at the boundary.<para/>
''' (2) The algorithm, described in Leptonica on the page on seed<para/>
''' filling and connected components, is due to Luc Vincent.<para/>
''' In brief, we generate an 8 or 16 bpp image, initialized<para/>
''' with the fg pixels of the input pix set to 1 and the<para/>
''' 1-boundary pixels (i.e., the boundary pixels of width 1 on<para/>
''' the four sides set as either:<para/>
''' L_BOUNDARY_BG: 0<para/>
''' L_BOUNDARY_FG:  max<para/>
''' where max = 0xff for 8 bpp and 0xffff for 16 bpp.<para/>
''' Then do raster/anti-raster sweeps over all pixels interior<para/>
''' to the 1-boundary, where the value of each new pixel is<para/>
''' taken to be 1 more than the minimum of the previously-seen<para/>
''' connected pixels (using either 4 or 8 connectivity).<para/>
''' Finally, set the 1-boundary pixels using the mirrored method<para/>
''' this removes the max values there.<para/>
''' (3) Using L_BOUNDARY_BG clamps the distance to 0 at the<para/>
''' boundary.  Using L_BOUNDARY_FG allows the distance<para/>
''' at the image boundary to "float".<para/>
''' (4) For 4-connected, one could initialize only the left and top<para/>
''' 1-boundary pixels, and go all the way to the right<para/>
''' and bottom then coming back reset left and top.  But we<para/>
''' instead use a method that works for both 4- and 8-connected.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixDistanceFunction/*"/>
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
' pixSeedspread(pixs, connectivity) as Pix
' pixSeedspread(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The raster/anti-raster method for implementing this filling<para/>
''' operation was suggested by Ray Smith.<para/>
''' (2) This takes an arbitrary set of nonzero pixels in pixs, which<para/>
''' can be sparse, and spreads (extrapolates) the values to<para/>
''' fill all the pixels in pixd with the nonzero value it is<para/>
''' closest to in pixs.  This is similar (though not completely<para/>
''' equivalent) to doing a Voronoi tiling of the image, with a<para/>
''' tile surrounding each pixel that has a nonzero value.<para/>
''' All pixels within a tile are then closer to its "central"<para/>
''' pixel than to any others.  Then assign the value of the<para/>
''' "central" pixel to each pixel in the tile.<para/>
''' (3) This is implemented by computing a distance function in parallel<para/>
''' with the fill.  The distance function uses free boundary<para/>
''' conditions (assumed maxval outside), and it controls the<para/>
''' propagation of the pixels in pixd away from the nonzero<para/>
''' (seed) values.  This is done in 2 traversals (raster/antiraster).<para/>
''' In the raster direction, whenever the distance function<para/>
''' is nonzero, the spread pixel takes on the value of its<para/>
''' predecessor that has the minimum distance value.  In the<para/>
''' antiraster direction, whenever the distance function is nonzero<para/>
''' and its value is replaced by a smaller value, the spread<para/>
''' pixel takes the value of the predecessor with the minimum<para/>
''' distance value.<para/>
''' (4) At boundaries where a pixel is equidistant from two<para/>
''' nearest nonzero (seed) pixels, the decision of which value<para/>
''' to use is arbitrary (greedy in search for minimum distance).<para/>
''' This can give rise to strange-looking results, particularly<para/>
''' for 4-connectivity where the L1 distance is computed from<para/>
''' steps in N,S,E and W directions (no diagonals).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSeedspread/*"/>
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
' pixLocalExtrema(pixs, maxmin, minmax, ppixmin, ppixmax) as Integer
' pixLocalExtrema(PIX *, l_int32, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives the actual local minima and maxima.<para/>
''' A local minimum is a pixel whose surrounding pixels all<para/>
''' have values at least as large, and likewise for a local<para/>
''' maximum.  For the local minima, %maxmin is the upper<para/>
''' bound for the value of pixs.  Likewise, for the local maxima,<para/>
''' %minmax is the lower bound for the value of pixs.<para/>
''' (2) The minima are found by starting with the erosion-and-equality<para/>
''' approach of pixSelectedLocalExtrema().  This is followed<para/>
''' by a qualification step, where each c.c. in the resulting<para/>
''' minimum mask is extracted, the pixels bordering it are<para/>
''' located, and they are queried.  If all of those pixels<para/>
''' are larger than the value of that minimum, it is a true<para/>
''' minimum and its c.c. is saved otherwise the c.c. is<para/>
''' rejected.  Note that if a bordering pixel has the<para/>
''' same value as the minimum, it must then have a<para/>
''' neighbor that is smaller, so the component is not a<para/>
''' true minimum.<para/>
''' (3) The maxima are found by inverting the image and looking<para/>
''' for the minima there.<para/>
''' (4) The generated masks can be used as markers for<para/>
''' further operations.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixLocalExtrema/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="maxmin">[in] - max allowed for the min in a 3x3 neighborhood use 0 for default which is to have no upper bound</param>
'''  <param name="minmax">[in] - min allowed for the max in a 3x3 neighborhood use 0 for default which is to have no lower bound</param>
'''  <param name="ppixmin">[out][optional] - mask of local minima</param>
'''  <param name="ppixmax">[out][optional] - mask of local maxima</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixLocalExtrema(
				 ByVal pixs as Pix, 
				 ByVal maxmin as Integer, 
				 ByVal minmax as Integer, 
				<Out()> Optional ByRef ppixmin as Pix = Nothing, 
				<Out()> Optional ByRef ppixmax as Pix = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

Dim ppixminPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmin) Then ppixminPTR = ppixmin.Pointer
Dim ppixmaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmax) Then ppixmaxPTR = ppixmax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixLocalExtrema( pixs.Pointer, maxmin, minmax, ppixminPTR, ppixmaxPTR)
	if ppixminPTR <> IntPtr.Zero then ppixmin = new Pix(ppixminPTR)
	if ppixmaxPTR <> IntPtr.Zero then ppixmax = new Pix(ppixmaxPTR)

	Return _Result
End Function

' SRC\seedfill.c (3190, 1)
' pixSelectedLocalExtrema(pixs, mindist, ppixmin, ppixmax) as Integer
' pixSelectedLocalExtrema(PIX *, l_int32, PIX **, PIX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This selects those local 3x3 minima that are at least a<para/>
''' specified distance from the nearest local 3x3 maxima, and v.v.<para/>
''' for the selected set of local 3x3 maxima.<para/>
''' The local 3x3 minima is the set of pixels whose value equals<para/>
''' the value after a 3x3 brick erosion, and the local 3x3 maxima<para/>
''' is the set of pixels whose value equals the value after<para/>
''' a 3x3 brick dilation.<para/>
''' (2) mindist is the minimum distance allowed between<para/>
''' local 3x3 minima and local 3x3 maxima, in an 8-connected sense.<para/>
''' mindist == 1 keeps all pixels found in step 1.<para/>
''' mindist == 0 removes all pixels from each mask that are<para/>
''' both a local 3x3 minimum and a local 3x3 maximum.<para/>
''' mindist == 1 removes any local 3x3 minimum pixel that touches a<para/>
''' local 3x3 maximum pixel, and likewise for the local maxima.<para/>
''' To make the decision, visualize each local 3x3 minimum pixel<para/>
''' as being surrounded by a square of size (2  mindist + 1)<para/>
''' on each side, such that no local 3x3 maximum pixel is within<para/>
''' that square and v.v.<para/>
''' (3) The generated masks can be used as markers for further operations.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSelectedLocalExtrema/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="mindist">[in] - -1 for keeping all pixels  is greater = 0 specifies distance</param>
'''  <param name="ppixmin">[out] - mask of local minima</param>
'''  <param name="ppixmax">[out] - mask of local maxima</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSelectedLocalExtrema(
				 ByVal pixs as Pix, 
				 ByVal mindist as Integer, 
				<Out()> ByRef ppixmin as Pix, 
				<Out()> ByRef ppixmax as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")

	Dim ppixminPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmin) Then ppixminPTR = ppixmin.Pointer
	Dim ppixmaxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixmax) Then ppixmaxPTR = ppixmax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSelectedLocalExtrema( pixs.Pointer, mindist, ppixminPTR, ppixmaxPTR)
	if ppixminPTR <> IntPtr.Zero then ppixmin = new Pix(ppixminPTR)
	if ppixmaxPTR <> IntPtr.Zero then ppixmax = new Pix(ppixmaxPTR)

	Return _Result
End Function

' SRC\seedfill.c (3250, 1)
' pixFindEqualValues(pixs1, pixs2) as Pix
' pixFindEqualValues(PIX *, PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The two images are aligned at the UL corner, and the returned<para/>
''' image has ON pixels where the pixels in pixs1 and pixs2<para/>
''' have equal values.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFindEqualValues/*"/>
'''  <param name="pixs1">[in] - 8 bpp</param>
'''  <param name="pixs2">[in] - 8 bpp</param>
'''   <returns>pixd 1 bpp mask, or NULL on error</returns>
Public Shared Function pixFindEqualValues(
				 ByVal pixs1 as Pix, 
				 ByVal pixs2 as Pix) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	If {8}.contains (pixs1.d) = false then Throw New ArgumentException ("8 bpp")
	If {8}.contains (pixs2.d) = false then Throw New ArgumentException ("8 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFindEqualValues( pixs1.Pointer, pixs2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\seedfill.c (3317, 1)
' pixSelectMinInConnComp(pixs, pixm, ppta, pnav) as Integer
' pixSelectMinInConnComp(PIX *, PIX *, PTA **, NUMA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each 8 connected component in pixm, this finds<para/>
''' a pixel in pixs that has the lowest value, and saves<para/>
''' it in a Pta.  If several pixels in pixs have the same<para/>
''' minimum value, it picks the first one found.<para/>
''' (2) For a mask pixm of true local minima, all pixels in each<para/>
''' connected component have the same value in pixs, so it is<para/>
''' fastest to select one of them using a special seedfill<para/>
''' operation.  Not yet implemented.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixSelectMinInConnComp/*"/>
'''  <param name="pixs">[in] - 8 bpp</param>
'''  <param name="pixm">[in] - 1 bpp</param>
'''  <param name="ppta">[out] - pta of min pixel locations</param>
'''  <param name="pnav">[out][optional] - numa of minima values</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixSelectMinInConnComp(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				<Out()> ByRef ppta as Pta, 
				<Out()> Optional ByRef pnav as Numa = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp")
	If {1}.contains (pixm.d) = false then Throw New ArgumentException ("1 bpp")

	Dim pptaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppta) Then pptaPTR = ppta.Pointer
Dim pnavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnav) Then pnavPTR = pnav.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixSelectMinInConnComp( pixs.Pointer, pixm.Pointer, pptaPTR, pnavPTR)
	if pptaPTR <> IntPtr.Zero then ppta = new Pta(pptaPTR)
	if pnavPTR <> IntPtr.Zero then pnav = new Numa(pnavPTR)

	Return _Result
End Function

' SRC\seedfill.c (3430, 1)
' pixRemoveSeededComponents(pixd, pixs, pixm, connectivity, bordersize) as Pix
' pixRemoveSeededComponents(PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes each component in pixm for which there is<para/>
''' at least one seed in pixs.  If pixd == NULL, this returns<para/>
''' the result in a new pixd.  Otherwise, it is an in-place<para/>
''' operation on pixm.  In no situation is pixs altered,<para/>
''' because we do the filling with a copy of pixs.<para/>
''' (2) If bordersize  is greater  0, it also clears all pixels within a<para/>
''' distance %bordersize of the edge of pixd.  This is here<para/>
''' because pixLocalExtrema() typically finds local minima<para/>
''' at the border.  Use %bordersize  is greater = 2 to remove these.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRemoveSeededComponents/*"/>
'''  <param name="pixd">[in][optional] - this can be null or equal to pixm 1 bpp</param>
'''  <param name="pixs">[in] - 1 bpp seed</param>
'''  <param name="pixm">[in] - 1 bpp filling mask</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="bordersize">[in] - amount of border clearing</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixRemoveSeededComponents(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal connectivity as Integer, 
				 ByVal bordersize as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRemoveSeededComponents( pixdPTR, pixs.Pointer, pixm.Pointer, connectivity, bordersize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
