using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// seedfill.c (243, 1)
// pixSeedfillBinary(pixd, pixs, pixm, connectivity) as Pix
// pixSeedfillBinary(PIX *, PIX *, PIX *, l_int32) as PIX *
///  <summary>
/// (1) This is for binary seedfill (aka "binary reconstruction").<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null (make a new pixd)
/// (b) pixd == pixs (in-place)
/// (c) pixd != pixs<para/>
/// 
/// (3) If you know the case, use these patterns for clarity:
/// (a) pixd = pixSeedfillBinary(NULL, pixs, ...)
/// (b) pixSeedfillBinary(pixs, pixs, ...)
/// (c) pixSeedfillBinary(pixd, pixs, ...)<para/>
/// 
/// (4) The resulting pixd contains the filled seed.  For some
/// applications you want to OR it with the inverse of
/// the filling mask.<para/>
/// 
/// (5) The input seed and mask images can be different sizes, but
/// in typical use the difference, if any, would be only
/// a few pixels in each direction.  If the sizes differ,
/// the clipping is handled by the low-level function
/// seedfillBinaryLow().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillBinary/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs 1 bpp</param>
///  <param name="pixs">[in] - 1 bpp seed</param>
///  <param name="pixm">[in] - 1 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>pixd always</returns>
public static Pix pixSeedfillBinary(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSeedfillBinary(pixdPtr, pixs.Pointer, pixm.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (330, 1)
// pixSeedfillBinaryRestricted(pixd, pixs, pixm, connectivity, xmax, ymax) as Pix
// pixSeedfillBinaryRestricted(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) See usage for pixSeedfillBinary(), which has unrestricted fill.
/// In pixSeedfillBinary(), the filling distance is unrestricted
/// and can be larger than pixs, depending on the topology of
/// th mask.<para/>
/// 
/// (2) There are occasions where it is useful not to permit the
/// fill to go more than a certain distance into the mask.
/// %xmax specifies the maximum horizontal distance allowed
/// in the fill %ymax does likewise in the vertical direction.<para/>
/// 
/// (3) Operationally, the max "distance" allowed for the fill
/// is a linear distance from the original seed, independent
/// of the actual mask topology.<para/>
/// 
/// (4) Another formulation of this problem, not implemented,
/// would use the manhattan distance from the seed, as
/// determined by a breadth-first search starting at the seed
/// boundaries and working outward where the mask fg allows.
/// How this might use the constraints of separate xmax and ymax
/// is not clear.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillBinaryRestricted/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs 1 bpp</param>
///  <param name="pixs">[in] - 1 bpp seed</param>
///  <param name="pixm">[in] - 1 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="xmax">[in] - max distance in x direction of fill into the mask</param>
///  <param name="ymax">[in] - max distance in y direction of fill into the mask</param>
///   <returns>pixd always</returns>
public static Pix pixSeedfillBinaryRestricted(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity, 
				 int xmax, 
				 int ymax){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixSeedfillBinaryRestricted(pixdPtr, pixs.Pointer, pixm.Pointer,   connectivity,   xmax,   ymax);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (605, 1)
// pixHolesByFilling(pixs, connectivity) as Pix
// pixHolesByFilling(PIX *, l_int32) as PIX *
///  <summary>
/// (1) To get 4-c.c. holes of the 8-c.c. as foreground, use
/// 4-connected filling to get 8-c.c. holes of the 4-c.c.
/// as foreground, use 8-connected filling.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHolesByFilling/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>pixd  inverted image of all holes, or NULL on error Action: 1 Start with 1-pixel black border on otherwise white pixd 2 Use the inverted pixs as the filling mask to fill in all the pixels from the border to the pixs foreground 3 OR the result with pixs to have an image with all ON pixels except for the holes. 4 Invert the result to get the holes as foreground</returns>
public static Pix pixHolesByFilling(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixHolesByFilling(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (656, 1)
// pixFillClosedBorders(pixs, connectivity) as Pix
// pixFillClosedBorders(PIX *, l_int32) as PIX *
///  <summary>
/// (1) Start with 1-pixel black border on otherwise white pixd<para/>
/// 
/// (2) Subtract input pixs to remove border pixels that were
/// also on the closed border<para/>
/// 
/// (3) Use the inverted pixs as the filling mask to fill in
/// all the pixels from the outer border to the closed border
/// on pixs<para/>
/// 
/// (4) Invert the result to get the filled component, including
/// the input border<para/>
/// 
/// (5) If the borders are 4-c.c., use 8-c.c. filling, and v.v.<para/>
/// 
/// (6) Closed borders within c.c. that represent holes, etc., are filled.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFillClosedBorders/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
///   <returns>pixd  all topologically outer closed borders are filled as connected comonents, or NULL on error</returns>
public static Pix pixFillClosedBorders(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixFillClosedBorders(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (694, 1)
// pixExtractBorderConnComps(pixs, connectivity) as Pix
// pixExtractBorderConnComps(PIX *, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractBorderConnComps/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
///   <returns>pixd  all pixels in the src that are in connected components touching the border, or NULL on error</returns>
public static Pix pixExtractBorderConnComps(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixExtractBorderConnComps(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (733, 1)
// pixRemoveBorderConnComps(pixs, connectivity) as Pix
// pixRemoveBorderConnComps(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This removes all fg components touching the border.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveBorderConnComps/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
///   <returns>pixd  all pixels in the src that are not touching the border or NULL on error</returns>
public static Pix pixRemoveBorderConnComps(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixRemoveBorderConnComps(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (783, 1)
// pixFillBgFromBorder(pixs, connectivity) as Pix
// pixFillBgFromBorder(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This fills all bg components touching the border to fg.
/// It is the photometric inverse of pixRemoveBorderConnComps().<para/>
/// 
/// (2) Invert the result to get the "holes" left after this fill.
/// This can be done multiple times, extracting holes within
/// holes after each pair of fillings.  Specifically, this code
/// peels away n successive embeddings of components:
/// \code
/// pix1 =  is smallerinitial image is greater 
/// for (i = 0 i  is smaller 2  n i++) {
/// pix2 = pixFillBgFromBorder(pix1, 8)
/// pixInvert(pix2, pix2)
/// pixDestroy([and]pix1)
/// pix1 = pix2
/// }
/// \endcode
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFillBgFromBorder/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="connectivity">[in] - filling connectivity 4 or 8</param>
///   <returns>pixd with the background c.c. touching the border filled to foreground, or NULL on error</returns>
public static Pix pixFillBgFromBorder(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixFillBgFromBorder(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (842, 1)
// pixFillHolesToBoundingRect(pixs, minsize, maxhfract, minfgfract) as Pix
// pixFillHolesToBoundingRect(PIX *, l_int32, l_float32, l_float32) as PIX *
///  <summary>
/// (1) This does not fill holes that are smaller in area than 'minsize'.<para/>
/// 
/// (2) This does not fill holes with an area larger than
/// 'maxhfract' times the fg area of the c.c.<para/>
/// 
/// (3) This does not expand the fg of the c.c. to bounding rect if
/// the fg area is less than 'minfgfract' times the area of the
/// bounding rect.<para/>
/// 
/// (4) The decisions are made as follows:
/// ~ Decide if we are filling the holes if so, when using
/// the fg area, include the filled holes.
/// ~ Decide based on the fg area if we are filling to a bounding rect.
/// If so, do it.
/// If not, fill the holes if the condition is satisfied.<para/>
/// 
/// (5) The choice of minsize depends on the resolution.<para/>
/// 
/// (6) For solidifying image mask regions on printed materials,
/// which tend to be rectangular, values for maxhfract
/// and minfgfract around 0.5 are reasonable.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFillHolesToBoundingRect/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="minsize">[in] - min number of pixels in the hole</param>
///  <param name="maxhfract">[in] - max hole area as fraction of fg pixels in the cc</param>
///  <param name="minfgfract">[in] - min fg area as fraction of bounding rectangle</param>
///   <returns>pixd pixs, with some holes possibly filled and some c.c. possibly expanded to their bounding rects, or NULL on error</returns>
public static Pix pixFillHolesToBoundingRect(
				 Pix pixs, 
				 int minsize, 
				 Single maxhfract, 
				 Single minfgfract){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr _Result = Natives.pixFillHolesToBoundingRect(pixs.Pointer,   minsize,   maxhfract,   minfgfract);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (923, 1)
// pixSeedfillGray(pixs, pixm, connectivity) as int
// pixSeedfillGray(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place filling operation on the seed, pixs,
/// where the clipping mask is always above or at the level
/// of the seed as it is filled.<para/>
/// 
/// (2) For details of the operation, see the description in
/// seedfillGrayLow() and the code there.<para/>
/// 
/// (3) As an example of use, see the description in pixHDome().
/// There, the seed is an image where each pixel is a fixed
/// amount smaller than the corresponding mask pixel.<para/>
/// 
/// (4) Reference paper :
/// L. Vincent, Morphological grayscale reconstruction in image
/// analysis: applications and efficient algorithms, IEEE Transactions
/// on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillGray/*"/>
///  <param name="pixs">[in] - 8 bpp seed filled in place</param>
///  <param name="pixm">[in] - 8 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSeedfillGray(
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	int _Result = Natives.pixSeedfillGray(pixs.Pointer, pixm.Pointer,   connectivity);
	
	return _Result;
}

// seedfill.c (982, 1)
// pixSeedfillGrayInv(pixs, pixm, connectivity) as int
// pixSeedfillGrayInv(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place filling operation on the seed, pixs,
/// where the clipping mask is always below or at the level
/// of the seed as it is filled.  Think of filling up a basin
/// to a particular level, given by the maximum seed value
/// in the basin.  Outside the filled region, the mask
/// is above the filling level.<para/>
/// 
/// (2) Contrast this with pixSeedfillGray(), where the clipping mask
/// is always above or at the level of the fill.  An example
/// of its use is the hdome fill, where the seed is an image
/// where each pixel is a fixed amount smaller than the
/// corresponding mask pixel.<para/>
/// 
/// (3) The basin fill, pixSeedfillGrayBasin(), is a special case
/// where the seed pixel values are generated from the mask,
/// and where the implementation uses pixSeedfillGray() by
/// inverting both the seed and mask.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillGrayInv/*"/>
///  <param name="pixs">[in] - 8 bpp seed filled in place</param>
///  <param name="pixm">[in] - 8 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSeedfillGrayInv(
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	int _Result = Natives.pixSeedfillGrayInv(pixs.Pointer, pixm.Pointer,   connectivity);
	
	return _Result;
}

// seedfill.c (1969, 1)
// pixSeedfillGraySimple(pixs, pixm, connectivity) as int
// pixSeedfillGraySimple(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place filling operation on the seed, pixs,
/// where the clipping mask is always above or at the level
/// of the seed as it is filled.<para/>
/// 
/// (2) For details of the operation, see the description in
/// seedfillGrayLowSimple() and the code there.<para/>
/// 
/// (3) As an example of use, see the description in pixHDome().
/// There, the seed is an image where each pixel is a fixed
/// amount smaller than the corresponding mask pixel.<para/>
/// 
/// (4) Reference paper :
/// L. Vincent, Morphological grayscale reconstruction in image
/// analysis: applications and efficient algorithms, IEEE Transactions
/// on  Image Processing, vol. 2, no. 2, pp. 176-201, 1993.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillGraySimple/*"/>
///  <param name="pixs">[in] - 8 bpp seed filled in place</param>
///  <param name="pixm">[in] - 8 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSeedfillGraySimple(
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	int _Result = Natives.pixSeedfillGraySimple(pixs.Pointer, pixm.Pointer,   connectivity);
	
	return _Result;
}

// seedfill.c (2040, 1)
// pixSeedfillGrayInvSimple(pixs, pixm, connectivity) as int
// pixSeedfillGrayInvSimple(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place filling operation on the seed, pixs,
/// where the clipping mask is always below or at the level
/// of the seed as it is filled.  Think of filling up a basin
/// to a particular level, given by the maximum seed value
/// in the basin.  Outside the filled region, the mask
/// is above the filling level.<para/>
/// 
/// (2) Contrast this with pixSeedfillGraySimple(), where the clipping mask
/// is always above or at the level of the fill.  An example
/// of its use is the hdome fill, where the seed is an image
/// where each pixel is a fixed amount smaller than the
/// corresponding mask pixel.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillGrayInvSimple/*"/>
///  <param name="pixs">[in] - 8 bpp seed filled in place</param>
///  <param name="pixm">[in] - 8 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSeedfillGrayInvSimple(
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	int _Result = Natives.pixSeedfillGrayInvSimple(pixs.Pointer, pixm.Pointer,   connectivity);
	
	return _Result;
}

// seedfill.c (2442, 1)
// pixSeedfillGrayBasin(pixb, pixm, delta, connectivity) as Pix
// pixSeedfillGrayBasin(PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This fills from a seed within basins defined by a filling mask.
/// The seed value(s) are greater than the corresponding
/// filling mask value, and the result has the bottoms of
/// the basins raised by the initial seed value.<para/>
/// 
/// (2) The seed has value 255 except where pixb has fg (1), which
/// are the seed 'locations'.  At the seed locations, the seed
/// value is the corresponding value of the mask pixel in pixm
/// plus %delta.  If %delta == 0, we return a copy of pixm.<para/>
/// 
/// (3) The actual filling is done using the standard grayscale filling
/// operation on the inverse of the mask and using the inverse
/// of the seed image.  After filling, we return the inverse of
/// the filled seed.<para/>
/// 
/// (4) As an example of use: pixm can describe a grayscale image
/// of text, where the (dark) text pixels are basins of
/// low values pixb can identify the local minima in pixm (say, at
/// the bottom of the basins) and delta is the amount that we wish
/// to raise (lighten) the basins.  We construct the seed
/// (a.k.a marker) image from pixb, pixm and %delta.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillGrayBasin/*"/>
///  <param name="pixb">[in] - binary mask giving seed locations</param>
///  <param name="pixm">[in] - 8 bpp basin-type filling mask</param>
///  <param name="delta">[in] - amount of seed value above mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>pixd filled seed if OK, NULL on error</returns>
public static Pix pixSeedfillGrayBasin(
				 Pix pixb, 
				 Pix pixm, 
				 int delta, 
				 int connectivity){

if (pixb == null) {throw new ArgumentNullException  ("pixb cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	IntPtr _Result = Natives.pixSeedfillGrayBasin(pixb.Pointer, pixm.Pointer,   delta,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (2533, 1)
// pixDistanceFunction(pixs, connectivity, outdepth, boundcond) as Pix
// pixDistanceFunction(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This computes the distance of each pixel from the nearest
/// background pixel.  All bg pixels therefore have a distance of 0,
/// and the fg pixel distances increase linearly from 1 at the
/// boundary.  It can also be used to compute the distance of
/// each pixel from the nearest fg pixel, by inverting the input
/// image before calling this function.  Then all fg pixels have
/// a distance 0 and the bg pixel distances increase linearly
/// from 1 at the boundary.<para/>
/// 
/// (2) The algorithm, described in Leptonica on the page on seed
/// filling and connected components, is due to Luc Vincent.
/// In brief, we generate an 8 or 16 bpp image, initialized
/// with the fg pixels of the input pix set to 1 and the
/// 1-boundary pixels (i.e., the boundary pixels of width 1 on
/// the four sides set as either:
/// L_BOUNDARY_BG: 0
/// L_BOUNDARY_FG:  max
/// where max = 0xff for 8 bpp and 0xffff for 16 bpp.
/// Then do raster/anti-raster sweeps over all pixels interior
/// to the 1-boundary, where the value of each new pixel is
/// taken to be 1 more than the minimum of the previously-seen
/// connected pixels (using either 4 or 8 connectivity).
/// Finally, set the 1-boundary pixels using the mirrored method
/// this removes the max values there.<para/>
/// 
/// (3) Using L_BOUNDARY_BG clamps the distance to 0 at the
/// boundary.  Using L_BOUNDARY_FG allows the distance
/// at the image boundary to "float".<para/>
/// 
/// (4) For 4-connected, one could initialize only the left and top
/// 1-boundary pixels, and go all the way to the right
/// and bottom then coming back reset left and top.  But we
/// instead use a method that works for both 4- and 8-connected.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDistanceFunction/*"/>
///  <param name="pixs">[in] - 1 bpp source</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="outdepth">[in] - 8 or 16 bits for pixd</param>
///  <param name="boundcond">[in] - L_BOUNDARY_BG, L_BOUNDARY_FG</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixDistanceFunction(
				 Pix pixs, 
				 int connectivity, 
				 int outdepth, 
				 int boundcond){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixDistanceFunction(pixs.Pointer,   connectivity,   outdepth,   boundcond);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (2791, 1)
// pixSeedspread(pixs, connectivity) as Pix
// pixSeedspread(PIX *, l_int32) as PIX *
///  <summary>
/// (1) The raster/anti-raster method for implementing this filling
/// operation was suggested by Ray Smith.<para/>
/// 
/// (2) This takes an arbitrary set of nonzero pixels in pixs, which
/// can be sparse, and spreads (extrapolates) the values to
/// fill all the pixels in pixd with the nonzero value it is
/// closest to in pixs.  This is similar (though not completely
/// equivalent) to doing a Voronoi tiling of the image, with a
/// tile surrounding each pixel that has a nonzero value.
/// All pixels within a tile are then closer to its "central"
/// pixel than to any others.  Then assign the value of the
/// "central" pixel to each pixel in the tile.<para/>
/// 
/// (3) This is implemented by computing a distance function in parallel
/// with the fill.  The distance function uses free boundary
/// conditions (assumed maxval outside), and it controls the
/// propagation of the pixels in pixd away from the nonzero
/// (seed) values.  This is done in 2 traversals (raster/antiraster).
/// In the raster direction, whenever the distance function
/// is nonzero, the spread pixel takes on the value of its
/// predecessor that has the minimum distance value.  In the
/// antiraster direction, whenever the distance function is nonzero
/// and its value is replaced by a smaller value, the spread
/// pixel takes the value of the predecessor with the minimum
/// distance value.<para/>
/// 
/// (4) At boundaries where a pixel is equidistant from two
/// nearest nonzero (seed) pixels, the decision of which value
/// to use is arbitrary (greedy in search for minimum distance).
/// This can give rise to strange-looking results, particularly
/// for 4-connectivity where the L1 distance is computed from
/// steps in N,S,E and W directions (no diagonals).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedspread/*"/>
///  <param name="pixs">[in] - 8 bpp source</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixSeedspread(
				 Pix pixs, 
				 int connectivity){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr _Result = Natives.pixSeedspread(pixs.Pointer,   connectivity);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (3018, 1)
// pixLocalExtrema(pixs, maxmin, minmax, ppixmin, ppixmax) as int
// pixLocalExtrema(PIX *, l_int32, l_int32, PIX **, PIX **) as l_ok
///  <summary>
/// (1) This gives the actual local minima and maxima.
/// A local minimum is a pixel whose surrounding pixels all
/// have values at least as large, and likewise for a local
/// maximum.  For the local minima, %maxmin is the upper
/// bound for the value of pixs.  Likewise, for the local maxima,
/// %minmax is the lower bound for the value of pixs.<para/>
/// 
/// (2) The minima are found by starting with the erosion-and-equality
/// approach of pixSelectedLocalExtrema().  This is followed
/// by a qualification step, where each c.c. in the resulting
/// minimum mask is extracted, the pixels bordering it are
/// located, and they are queried.  If all of those pixels
/// are larger than the value of that minimum, it is a true
/// minimum and its c.c. is saved otherwise the c.c. is
/// rejected.  Note that if a bordering pixel has the
/// same value as the minimum, it must then have a
/// neighbor that is smaller, so the component is not a
/// true minimum.<para/>
/// 
/// (3) The maxima are found by inverting the image and looking
/// for the minima there.<para/>
/// 
/// (4) The generated masks can be used as markers for
/// further operations.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixLocalExtrema/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="maxmin">[in] - max allowed for the min in a 3x3 neighborhood use 0 for default which is to have no upper bound</param>
///  <param name="minmax">[in] - min allowed for the max in a 3x3 neighborhood use 0 for default which is to have no lower bound</param>
///  <param name="ppixmin">[out][optional] - mask of local minima</param>
///  <param name="ppixmax">[out][optional] - mask of local maxima</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixLocalExtrema(
				 Pix pixs, 
				 int maxmin, 
				 int minmax, 
				out Pix ppixmin, 
				out Pix ppixmax){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr ppixminPtr = IntPtr.Zero;
	IntPtr ppixmaxPtr = IntPtr.Zero;

	int _Result = Natives.pixLocalExtrema(pixs.Pointer,   maxmin,   minmax, out ppixminPtr, out ppixmaxPtr);
	
	if (ppixminPtr == IntPtr.Zero) {ppixmin = null;} else { ppixmin = new Pix(ppixminPtr); };
	if (ppixmaxPtr == IntPtr.Zero) {ppixmax = null;} else { ppixmax = new Pix(ppixmaxPtr); };
	return _Result;
}

// seedfill.c (3190, 1)
// pixSelectedLocalExtrema(pixs, mindist, ppixmin, ppixmax) as int
// pixSelectedLocalExtrema(PIX *, l_int32, PIX **, PIX **) as l_ok
///  <summary>
/// (1) This selects those local 3x3 minima that are at least a
/// specified distance from the nearest local 3x3 maxima, and v.v.
/// for the selected set of local 3x3 maxima.
/// The local 3x3 minima is the set of pixels whose value equals
/// the value after a 3x3 brick erosion, and the local 3x3 maxima
/// is the set of pixels whose value equals the value after
/// a 3x3 brick dilation.<para/>
/// 
/// (2) mindist is the minimum distance allowed between
/// local 3x3 minima and local 3x3 maxima, in an 8-connected sense.
/// mindist == 1 keeps all pixels found in step 1.
/// mindist == 0 removes all pixels from each mask that are
/// both a local 3x3 minimum and a local 3x3 maximum.
/// mindist == 1 removes any local 3x3 minimum pixel that touches a
/// local 3x3 maximum pixel, and likewise for the local maxima.
/// To make the decision, visualize each local 3x3 minimum pixel
/// as being surrounded by a square of size (2  mindist + 1)
/// on each side, such that no local 3x3 maximum pixel is within
/// that square and v.v.<para/>
/// 
/// (3) The generated masks can be used as markers for further operations.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectedLocalExtrema/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="mindist">[in] - -1 for keeping all pixels greater or equal 0 specifies distance</param>
///  <param name="ppixmin">[out] - mask of local minima</param>
///  <param name="ppixmax">[out] - mask of local maxima</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSelectedLocalExtrema(
				 Pix pixs, 
				 int mindist, 
				out Pix ppixmin, 
				out Pix ppixmax){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr ppixminPtr = IntPtr.Zero;
	IntPtr ppixmaxPtr = IntPtr.Zero;

	int _Result = Natives.pixSelectedLocalExtrema(pixs.Pointer,   mindist, out ppixminPtr, out ppixmaxPtr);
	
	if (ppixminPtr == IntPtr.Zero) {ppixmin = null;} else { ppixmin = new Pix(ppixminPtr); };
	if (ppixmaxPtr == IntPtr.Zero) {ppixmax = null;} else { ppixmax = new Pix(ppixmaxPtr); };
	return _Result;
}

// seedfill.c (3250, 1)
// pixFindEqualValues(pixs1, pixs2) as Pix
// pixFindEqualValues(PIX *, PIX *) as PIX *
///  <summary>
/// (1) The two images are aligned at the UL corner, and the returned
/// image has ON pixels where the pixels in pixs1 and pixs2
/// have equal values.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindEqualValues/*"/>
///  <param name="pixs1">[in] - 8 bpp</param>
///  <param name="pixs2">[in] - 8 bpp</param>
///   <returns>pixd 1 bpp mask, or NULL on error</returns>
public static Pix pixFindEqualValues(
				 Pix pixs1, 
				 Pix pixs2){

if (pixs1 == null) {throw new ArgumentNullException  ("pixs1 cannot be Nothing");}
		if (pixs2 == null) {throw new ArgumentNullException  ("pixs2 cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs1.d) == false) { throw new ArgumentException ("8 bpp"); }
	if ((new List<int> {8}).Contains ((int)pixs2.d) == false) { throw new ArgumentException ("8 bpp"); }
	IntPtr _Result = Natives.pixFindEqualValues(pixs1.Pointer, pixs2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// seedfill.c (3317, 1)
// pixSelectMinInConnComp(pixs, pixm, ppta, pnav) as int
// pixSelectMinInConnComp(PIX *, PIX *, PTA **, NUMA **) as l_ok
///  <summary>
/// (1) For each 8 connected component in pixm, this finds
/// a pixel in pixs that has the lowest value, and saves
/// it in a Pta.  If several pixels in pixs have the same
/// minimum value, it picks the first one found.<para/>
/// 
/// (2) For a mask pixm of true local minima, all pixels in each
/// connected component have the same value in pixs, so it is
/// fastest to select one of them using a special seedfill
/// operation.  Not yet implemented.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSelectMinInConnComp/*"/>
///  <param name="pixs">[in] - 8 bpp</param>
///  <param name="pixm">[in] - 1 bpp</param>
///  <param name="ppta">[out] - pta of min pixel locations</param>
///  <param name="pnav">[out][optional] - numa of minima values</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixSelectMinInConnComp(
				 Pix pixs, 
				 Pix pixm, 
				out Pta ppta, 
				out Numa pnav){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
	if ((new List<int> {1}).Contains ((int)pixm.d) == false) { throw new ArgumentException ("1 bpp"); }
	IntPtr pptaPtr = IntPtr.Zero;
	IntPtr pnavPtr = IntPtr.Zero;

	int _Result = Natives.pixSelectMinInConnComp(pixs.Pointer, pixm.Pointer, out pptaPtr, out pnavPtr);
	
	if (pptaPtr == IntPtr.Zero) {ppta = null;} else { ppta = new Pta(pptaPtr); };
	if (pnavPtr == IntPtr.Zero) {pnav = null;} else { pnav = new Numa(pnavPtr); };
	return _Result;
}

// seedfill.c (3430, 1)
// pixRemoveSeededComponents(pixd, pixs, pixm, connectivity, bordersize) as Pix
// pixRemoveSeededComponents(PIX *, PIX *, PIX *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This removes each component in pixm for which there is
/// at least one seed in pixs.  If pixd == NULL, this returns
/// the result in a new pixd.  Otherwise, it is an in-place
/// operation on pixm.  In no situation is pixs altered,
/// because we do the filling with a copy of pixs.<para/>
/// 
/// (2) If bordersize  is greater  0, it also clears all pixels within a
/// distance %bordersize of the edge of pixd.  This is here
/// because pixLocalExtrema() typically finds local minima
/// at the border.  Use %bordersize greater or equal 2 to remove these.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveSeededComponents/*"/>
///  <param name="pixd">[in][optional] - this can be null or equal to pixm 1 bpp</param>
///  <param name="pixs">[in] - 1 bpp seed</param>
///  <param name="pixm">[in] - 1 bpp filling mask</param>
///  <param name="connectivity">[in] - 4 or 8</param>
///  <param name="bordersize">[in] - amount of border clearing</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixRemoveSeededComponents(
				 Pix pixd, 
				 Pix pixs, 
				 Pix pixm, 
				 int connectivity, 
				 int bordersize){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}
	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixRemoveSeededComponents(pixdPtr, pixs.Pointer, pixm.Pointer,   connectivity,   bordersize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}


}
}
