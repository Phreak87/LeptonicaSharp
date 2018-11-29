using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixafunc2.c (179, 1)
// pixaDisplay(pixa, w, h) as Pix
// pixaDisplay(PIXA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This uses the boxes to place each pix in the rendered composite.<para/>
/// 
/// (2) Set w = h = 0 to use the b.b. of the components to determine
/// the size of the returned pix.<para/>
/// 
/// (3) Uses the first pix in pixa to determine the depth.<para/>
/// 
/// (4) The background is written "white".  On 1 bpp, each successive
/// pix is "painted" (adding foreground), whereas for grayscale
/// or color each successive pix is blitted with just the src.<para/>
/// 
/// (5) If the pixa is empty, returns an empty 1 bpp pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplay/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixaDisplay(
				 Pixa pixa, 
				 int w, 
				 int h){

	IntPtr _Result = Natives.pixaDisplay(pixa.Pointer,   w,   h);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (259, 1)
// pixaDisplayOnColor(pixa, w, h, bgcolor) as Pix
// pixaDisplayOnColor(PIXA *, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) This uses the boxes to place each pix in the rendered composite.<para/>
/// 
/// (2) Set w = h = 0 to use the b.b. of the components to determine
/// the size of the returned pix.<para/>
/// 
/// (3) If any pix in %pixa are colormapped, or if the pix have
/// different depths, it returns a 32 bpp pix.  Otherwise,
/// the depth of the returned pixa equals that of the pix in %pixa.<para/>
/// 
/// (4) If the pixa is empty, return null.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayOnColor/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///  <param name="bgcolor">[in] - background color to use</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixaDisplayOnColor(
				 Pixa pixa, 
				 int w, 
				 int h, 
				 uint bgcolor){

	IntPtr _Result = Natives.pixaDisplayOnColor(pixa.Pointer,   w,   h,   bgcolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (354, 1)
// pixaDisplayRandomCmap(pixa, w, h) as Pix
// pixaDisplayRandomCmap(PIXA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This uses the boxes to place each pix in the rendered composite.
/// The fg of each pix in %pixa, such as a single connected
/// component or a line of text, is given a random color.<para/>
/// 
/// (2) By default, the background color is black (cmap index 0).
/// This can be changed by pixcmapResetColor()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayRandomCmap/*"/>
///  <param name="pixa">[in] - 1 bpp regions, with boxa delineating those regions</param>
///  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///   <returns>pix   8 bpp, cmapped, with random colors assigned to each region, or NULL on error.</returns>
public static Pix pixaDisplayRandomCmap(
				 Pixa pixa, 
				 int w, 
				 int h){

	IntPtr _Result = Natives.pixaDisplayRandomCmap(pixa.Pointer,   w,   h);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (428, 1)
// pixaDisplayLinearly(pixas, direction, scalefactor, background, spacing, border, pboxa) as Pix
// pixaDisplayLinearly(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, BOXA **) as PIX *
///  <summary>
/// (1) This puts each pix, sequentially, in a line, either horizontally
/// or vertically.<para/>
/// 
/// (2) If any pix has a colormap, all pix are rendered in rgb.<para/>
/// 
/// (3) The boxa gives the location of each image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayLinearly/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="direction">[in] - L_HORIZ or L_VERT</param>
///  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
///  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
///  <param name="pboxa">[out][optional] - location of images in output pix</param>
///   <returns>pix of composite images, or NULL on error</returns>
public static Pix pixaDisplayLinearly(
				 Pixa pixas, 
				 int direction, 
				 Single scalefactor, 
				 int background, 
				 int spacing, 
				 int border, 
				out Boxa pboxa){

	IntPtr pboxaPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixaDisplayLinearly(pixas.Pointer,   direction,   scalefactor,   background,   spacing,   border, out pboxaPtr);
	

	if (pboxaPtr == null) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (522, 1)
// pixaDisplayOnLattice(pixa, cellw, cellh, pncols, pboxa) as Pix
// pixaDisplayOnLattice(PIXA *, l_int32, l_int32, l_int32 *, BOXA **) as PIX *
///  <summary>
/// (1) This places each pix on sequentially on a regular lattice
/// in the rendered composite.  If a pix is too large to fit in the
/// allocated lattice space, it is not rendered.<para/>
/// 
/// (2) If any pix has a colormap, all pix are rendered in rgb.<para/>
/// 
/// (3) This is useful when putting bitmaps of components,
/// such as characters, into a single image.<para/>
/// 
/// (4) The boxa gives the location of each image.  The UL corner
/// of each image is on a lattice cell corner.  Omitted images
/// (due to size) are assigned an invalid width and height of 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayOnLattice/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="cellw">[in] - lattice cell width</param>
///  <param name="cellh">[in] - lattice cell height</param>
///  <param name="pncols">[out][optional] - number of columns in output lattice</param>
///  <param name="pboxa">[out][optional] - location of images in lattice</param>
///   <returns>pix of composite images, or NULL on error</returns>
public static Pix pixaDisplayOnLattice(
				 Pixa pixa, 
				 int cellw, 
				 int cellh, 
				out int pncols, 
				out Boxa pboxa){

	IntPtr pboxaPtr = IntPtr.Zero;

	IntPtr _Result = Natives.pixaDisplayOnLattice(pixa.Pointer,   cellw,   cellh, out  pncols, out pboxaPtr);
	

	if (pboxaPtr == null) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (633, 1)
// pixaDisplayUnsplit(pixa, nx, ny, borderwidth, bordercolor) as Pix
// pixaDisplayUnsplit(PIXA *, l_int32, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) This is a logical inverse of pixaSplitPix().  It
/// constructs a pix from a mosaic of tiles, all of equal size.<para/>
/// 
/// (2) For added generality, a border of arbitrary color can
/// be added to each of the tiles.<para/>
/// 
/// (3) In use, pixa will typically have either been generated
/// from pixaSplitPix() or will derived from a pixa that
/// was so generated.<para/>
/// 
/// (4) All pix in the pixa must be of equal depth, and, if
/// colormapped, have the same colormap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayUnsplit/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="nx">[in] - number of mosaic cells horizontally</param>
///  <param name="ny">[in] - number of mosaic cells vertically</param>
///  <param name="borderwidth">[in] - of added border on all sides</param>
///  <param name="bordercolor">[in] - in our RGBA format: 0xrrggbbaa</param>
///   <returns>pix of tiled images, or NULL on error</returns>
public static Pix pixaDisplayUnsplit(
				 Pixa pixa, 
				 int nx, 
				 int ny, 
				 int borderwidth, 
				 uint bordercolor){

	IntPtr _Result = Natives.pixaDisplayUnsplit(pixa.Pointer,   nx,   ny,   borderwidth,   bordercolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (708, 1)
// pixaDisplayTiled(pixa, maxwidth, background, spacing) as Pix
// pixaDisplayTiled(PIXA *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This renders a pixa to a single image of width not to
/// exceed maxwidth, with background color either white or black,
/// and with each subimage spaced on a regular lattice.<para/>
/// 
/// (2) The lattice size is determined from the largest width and height,
/// separately, of all pix in the pixa.<para/>
/// 
/// (3) All pix in the pixa must be of equal depth.<para/>
/// 
/// (4) If any pix has a colormap, all pix are rendered in rgb.<para/>
/// 
/// (5) Careful: because no components are omitted, this is
/// dangerous if there are thousands of small components and
/// one or more very large one, because the size of the
/// resulting pix can be huge!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiled/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="maxwidth">[in] - of output image</param>
///  <param name="background">[in] - 0 for white, 1 for black</param>
///  <param name="spacing">[in] - </param>
///   <returns>pix of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiled(
				 Pixa pixa, 
				 int maxwidth, 
				 int background, 
				 int spacing){

	IntPtr _Result = Natives.pixaDisplayTiled(pixa.Pointer,   maxwidth,   background,   spacing);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (822, 1)
// pixaDisplayTiledInRows(pixa, outdepth, maxwidth, scalefactor, background, spacing, border) as Pix
// pixaDisplayTiledInRows(PIXA *, l_int32, l_int32, l_float32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This renders a pixa to a single image of width not to
/// exceed maxwidth, with background color either white or black,
/// and with each row tiled such that the top of each pix is
/// aligned and separated by 'spacing' from the next one.
/// A black border can be added to each pix.<para/>
/// 
/// (2) All pix are converted to outdepth existing colormaps are removed.<para/>
/// 
/// (3) This does a reasonably spacewise-efficient job of laying
/// out the individual pix images into a tiled composite.<para/>
/// 
/// (4) A serialized boxa giving the location in pixd of each input
/// pix (without added border) is stored in the text string of pixd.
/// This allows, e.g., regeneration of a pixa from pixd, using
/// pixaCreateFromBoxa().  If there is no scaling and the depth of
/// each input pix in the pixa is the same, this tiling operation
/// can be inverted using the boxa (except for loss of text in
/// each of the input pix):
/// pix1 = pixaDisplayTiledInRows(pixa1, 1, 1500, 1.0, 0, 30, 0)
/// char boxatxt = pixGetText(pix1)
/// boxa1 = boxaReadMem((l_uint8 )boxatxt, strlen(boxatxt))
/// pixa2 = pixaCreateFromBoxa(pix1, boxa1, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiledInRows/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
///  <param name="maxwidth">[in] - of output image</param>
///  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
///  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
///   <returns>pixd of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiledInRows(
				 Pixa pixa, 
				 int outdepth, 
				 int maxwidth, 
				 Single scalefactor, 
				 int background, 
				 int spacing, 
				 int border){

	IntPtr _Result = Natives.pixaDisplayTiledInRows(pixa.Pointer,   outdepth,   maxwidth,   scalefactor,   background,   spacing,   border);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1006, 1)
// pixaDisplayTiledInColumns(pixas, nx, scalefactor, spacing, border) as Pix
// pixaDisplayTiledInColumns(PIXA *, l_int32, l_float32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This renders a pixa to a single image with [and]nx columns of
/// subimages.  The background color is white, and each row
/// is tiled such that the top of each pix is aligned and
/// each pix is separated by 'spacing' from the next one.
/// A black border can be added to each pix.<para/>
/// 
/// (2) The output depth is determined by the largest depth
/// required by the pix in the pixa.  Colormaps are removed.<para/>
/// 
/// (3) A serialized boxa giving the location in pixd of each input
/// pix (without added border) is stored in the text string of pixd.
/// This allows, e.g., regeneration of a pixa from pixd, using
/// pixaCreateFromBoxa().  If there is no scaling and the depth of
/// each input pix in the pixa is the same, this tiling operation
/// can be inverted using the boxa (except for loss of text in
/// each of the input pix):
/// pix1 = pixaDisplayTiledInColumns(pixa1, 3, 1.0, 0, 30, 2)
/// char boxatxt = pixGetText(pix1)
/// boxa1 = boxaReadMem((l_uint8 )boxatxt, strlen(boxatxt))
/// pixa2 = pixaCreateFromBoxa(pix1, boxa1, NULL)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiledInColumns/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="nx">[in] - number of columns in output image</param>
///  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
///   <returns>pixd of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiledInColumns(
				 Pixa pixas, 
				 int nx, 
				 Single scalefactor, 
				 int spacing, 
				 int border){

	IntPtr _Result = Natives.pixaDisplayTiledInColumns(pixas.Pointer,   nx,   scalefactor,   spacing,   border);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1123, 1)
// pixaDisplayTiledAndScaled(pixa, outdepth, tilewidth, ncols, background, spacing, border) as Pix
// pixaDisplayTiledAndScaled(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This can be used to tile a number of renderings of
/// an image that are at different scales and depths.<para/>
/// 
/// (2) Each image, after scaling and optionally adding the
/// black border, has width 'tilewidth'.  Thus, the border does
/// not affect the spacing between the image tiles.  The
/// maximum allowed border width is tilewidth / 5.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiledAndScaled/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
///  <param name="tilewidth">[in] - each pix is scaled to this width</param>
///  <param name="ncols">[in] - number of tiles in each row</param>
///  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///   <returns>pix of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiledAndScaled(
				 Pixa pixa, 
				 int outdepth, 
				 int tilewidth, 
				 int ncols, 
				 int background, 
				 int spacing, 
				 int border){

	IntPtr _Result = Natives.pixaDisplayTiledAndScaled(pixa.Pointer,   outdepth,   tilewidth,   ncols,   background,   spacing,   border);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1278, 1)
// pixaDisplayTiledWithText(pixa, maxwidth, scalefactor, spacing, border, fontsize, textcolor) as Pix
// pixaDisplayTiledWithText(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) This is a version of pixaDisplayTiledInRows() that prints, below
/// each pix, the text in the pix text field.  Up to 127 chars
/// of text in the pix text field are rendered below each pix.<para/>
/// 
/// (2) It renders a pixa to a single image of width not to
/// exceed %maxwidth, with white background color, with each row
/// tiled such that the top of each pix is aligned and separated
/// by %spacing from the next one.<para/>
/// 
/// (3) All pix are converted to 32 bpp.<para/>
/// 
/// (4) This does a reasonably spacewise-efficient job of laying
/// out the individual pix images into a tiled composite.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiledWithText/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="maxwidth">[in] - of output image</param>
///  <param name="scalefactor">[in] - applied to every pix use 1.0 for no scaling</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
///  <param name="fontsize">[in] - 4, 6, ... 20</param>
///  <param name="textcolor">[in] - 0xrrggbb00</param>
///   <returns>pixd of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiledWithText(
				 Pixa pixa, 
				 int maxwidth, 
				 Single scalefactor, 
				 int spacing, 
				 int border, 
				 int fontsize, 
				 uint textcolor){

	IntPtr _Result = Natives.pixaDisplayTiledWithText(pixa.Pointer,   maxwidth,   scalefactor,   spacing,   border,   fontsize,   textcolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1377, 1)
// pixaDisplayTiledByIndex(pixa, na, width, spacing, border, fontsize, textcolor) as Pix
// pixaDisplayTiledByIndex(PIXA *, NUMA *, l_int32, l_int32, l_int32, l_int32, l_uint32) as PIX *
///  <summary>
/// (1) This renders a pixa to a single image with white
/// background color, where the pix are placed in columns
/// given by the index value in the numa.  Each pix
/// is separated by %spacing from the adjacent ones, and
/// an optional border is placed around them.<para/>
/// 
/// (2) Up to 127 chars of text in the pix text field are rendered
/// below each pix.  Use newlines in the text field to write
/// the text in multiple lines that fit within the pix width.<para/>
/// 
/// (3) To avoid having empty columns, if there are N different
/// index values, they should be in [0 ... N-1].<para/>
/// 
/// (4) All pix are converted to 32 bpp.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayTiledByIndex/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="na">[in] - numa with indices corresponding to the pix in pixa</param>
///  <param name="width">[in] - each pix is scaled to this width</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of black border added to each image use 0 for no border</param>
///  <param name="fontsize">[in] - 4, 6, ... 20</param>
///  <param name="textcolor">[in] - 0xrrggbb00</param>
///   <returns>pixd of tiled images, or NULL on error</returns>
public static Pix pixaDisplayTiledByIndex(
				 Pixa pixa, 
				 Numa na, 
				 int width, 
				 int spacing, 
				 int border, 
				 int fontsize, 
				 uint textcolor){

	IntPtr _Result = Natives.pixaDisplayTiledByIndex(pixa.Pointer, na.Pointer,   width,   spacing,   border,   fontsize,   textcolor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1480, 1)
// pixaaDisplay(paa, w, h) as Pix
// pixaaDisplay(PIXAA *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Each pix of the paa is displayed at the location given by
/// its box, translated by the box of the containing pixa
/// if it exists.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaDisplay/*"/>
///  <param name="paa">[in] - </param>
///  <param name="w">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///  <param name="h">[in] - if set to 0, the size is determined from the bounding box of the components in pixa</param>
///   <returns>pix, or NULL on error</returns>
public static Pix pixaaDisplay(
				 Pixaa paa, 
				 int w, 
				 int h){

	IntPtr _Result = Natives.pixaaDisplay(paa.Pointer,   w,   h);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1574, 1)
// pixaaDisplayByPixa(paa, xspace, yspace, maxw) as Pix
// pixaaDisplayByPixa(PIXAA *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Displays each pixa on a line (or set of lines),
/// in order from top to bottom.  Within each pixa,
/// the pix are displayed in order from left to right.<para/>
/// 
/// (2) The sizes and depths of each pix can differ.  The output pix
/// has a depth equal to the max depth of all the pix.<para/>
/// 
/// (3) This ignores the boxa of the paa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaDisplayByPixa/*"/>
///  <param name="paa">[in] - with pix that may have different depths</param>
///  <param name="xspace">[in] - between pix in pixa</param>
///  <param name="yspace">[in] - between pixa</param>
///  <param name="maxw">[in] - max width of output pix</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixaaDisplayByPixa(
				 Pixaa paa, 
				 int xspace, 
				 int yspace, 
				 int maxw){

	IntPtr _Result = Natives.pixaaDisplayByPixa(paa.Pointer,   xspace,   yspace,   maxw);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// pixafunc2.c (1711, 1)
// pixaaDisplayTiledAndScaled(paa, outdepth, tilewidth, ncols, background, spacing, border) as Pixa
// pixaaDisplayTiledAndScaled(PIXAA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) For each pixa, this generates from all the pix a
/// tiled/scaled output pix, and puts it in the output pixa.<para/>
/// 
/// (2) See comments in pixaDisplayTiledAndScaled().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaaDisplayTiledAndScaled/*"/>
///  <param name="paa">[in] - </param>
///  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
///  <param name="tilewidth">[in] - each pix is scaled to this width</param>
///  <param name="ncols">[in] - number of tiles in each row</param>
///  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///   <returns>pixa of tiled images, one image for each pixa in the paa, or NULL on error</returns>
public static Pixa pixaaDisplayTiledAndScaled(
				 Pixaa paa, 
				 int outdepth, 
				 int tilewidth, 
				 int ncols, 
				 int background, 
				 int spacing, 
				 int border){

	IntPtr _Result = Natives.pixaaDisplayTiledAndScaled(paa.Pointer,   outdepth,   tilewidth,   ncols,   background,   spacing,   border);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (1761, 1)
// pixaConvertTo1(pixas, thresh) as Pixa
// pixaConvertTo1(PIXA *, l_int32) as PIXA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertTo1/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="thresh">[in] - threshold for final binarization from 8 bpp gray</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaConvertTo1(
				 Pixa pixas, 
				 int thresh){

	IntPtr _Result = Natives.pixaConvertTo1(pixas.Pointer,   thresh);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (1802, 1)
// pixaConvertTo8(pixas, cmapflag) as Pixa
// pixaConvertTo8(PIXA *, l_int32) as PIXA *
///  <summary>
/// (1) See notes for pixConvertTo8(), applied to each pix in pixas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertTo8/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="cmapflag">[in] - 1 to give pixd a colormap 0 otherwise</param>
///   <returns>pixad each pix is 8 bpp, or NULL on error</returns>
public static Pixa pixaConvertTo8(
				 Pixa pixas, 
				 int cmapflag){

	IntPtr _Result = Natives.pixaConvertTo8(pixas.Pointer,   cmapflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (1843, 1)
// pixaConvertTo8Colormap(pixas, dither) as Pixa
// pixaConvertTo8Colormap(PIXA *, l_int32) as PIXA *
///  <summary>
/// (1) See notes for pixConvertTo8Colormap(), applied to each pix in pixas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertTo8Colormap/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="dither">[in] - 1 to dither if necessary 0 otherwise</param>
///   <returns>pixad each pix is 8 bpp, or NULL on error</returns>
public static Pixa pixaConvertTo8Colormap(
				 Pixa pixas, 
				 int dither){

	IntPtr _Result = Natives.pixaConvertTo8Colormap(pixas.Pointer,   dither);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (1885, 1)
// pixaConvertTo32(pixas) as Pixa
// pixaConvertTo32(PIXA *) as PIXA *
///  <summary>
/// (1) See notes for pixConvertTo32(), applied to each pix in pixas.<para/>
/// 
/// (2) This can be used to allow 1 bpp pix in a pixa to be displayed
/// with color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertTo32/*"/>
///  <param name="pixas">[in] - </param>
///   <returns>pixad 32 bpp rgb, or NULL on error</returns>
public static Pixa pixaConvertTo32(
				 Pixa pixas){

	IntPtr _Result = Natives.pixaConvertTo32(pixas.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (1938, 1)
// pixaConstrainedSelect(pixas, first, last, nmax, use_pairs, copyflag) as Pixa
// pixaConstrainedSelect(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) See notes in genConstrainedNumaInRange() for how selection
/// is made.<para/>
/// 
/// (2) This returns a selection of the pix in the input pixa.<para/>
/// 
/// (3) Use copyflag == L_COPY if you don't want changes in the pix
/// in the returned pixa to affect those in the input pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConstrainedSelect/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="first">[in] - first index to choose greater or equal 0</param>
///  <param name="last">[in] - biggest possible index to reach use -1 to go to the end otherwise, last greater or equal first</param>
///  <param name="nmax">[in] - maximum number of pix to select  is greater  0</param>
///  <param name="use_pairs">[in] - 1 = select pairs of adjacent pix 0 = select individual pix</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>pixad if OK, NULL on error</returns>
public static Pixa pixaConstrainedSelect(
				 Pixa pixas, 
				 int first, 
				 int last, 
				 int nmax, 
				 int use_pairs, 
				 int copyflag){

	IntPtr _Result = Natives.pixaConstrainedSelect(pixas.Pointer,   first,   last,   nmax,   use_pairs,   copyflag);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (2006, 1)
// pixaSelectToPdf(pixas, first, last, res, scalefactor, type, quality, color, fontsize, fileout) as int
// pixaSelectToPdf(PIXA *, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32, l_uint32, l_int32, const char *) as l_ok
///  <summary>
/// (1) This writes a pdf of the selected images from %pixas, one to
/// a page.  They are optionally scaled and annotated with the
/// index printed to the left of the image.<para/>
/// 
/// (2) If the input images are 1 bpp and you want the numbers to be
/// in color, first promote each pix to 8 bpp with a colormap:
/// pixa1 = pixaConvertTo8(pixas, 1)
/// and then call this function with the specified color
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSelectToPdf/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="first">[in] - first index to choose greater or equal 0</param>
///  <param name="last">[in] - biggest possible index to reach use -1 to go to the end otherwise, last greater or equal first</param>
///  <param name="res">[in] - override the resolution of each input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
///  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="color">[in] - of numbers added to each image (e.g., 0xff000000)</param>
///  <param name="fontsize">[in] - to print number below each image.  The valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
///  <param name="fileout">[in] - pdf file of all images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSelectToPdf(
				 Pixa pixas, 
				 int first, 
				 int last, 
				 int res, 
				 Single scalefactor, 
				 int type, 
				 int quality, 
				 uint color, 
				 int fontsize, 
				 String fileout){

	int _Result = Natives.pixaSelectToPdf(pixas.Pointer,   first,   last,   res,   scalefactor,   type,   quality,   color,   fontsize,   fileout);
	



	return _Result;
}

// pixafunc2.c (2086, 1)
// pixaDisplayMultiTiled(pixas, nx, ny, maxw, maxh, scalefactor, spacing, border) as Pixa
// pixaDisplayMultiTiled(PIXA *, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) Each set of %nx  %ny images is optionally scaled and saved
/// into a new pix, and then aggregated.<para/>
/// 
/// (2) Set %maxw = %maxh = 0 if you want to include all pix from %pixs.<para/>
/// 
/// (3) This is useful for generating a pdf from the output pixa, where
/// each page is a tile of (%nx  %ny) images from the input pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaDisplayMultiTiled/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="maxw">[in] - max sizes to keep</param>
///  <param name="maxh">[in] - max sizes to keep</param>
///  <param name="scalefactor">[in] - scale each image by this</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///   <returns>pixad if OK, NULL on error</returns>
public static Pixa pixaDisplayMultiTiled(
				 Pixa pixas, 
				 int nx, 
				 int ny, 
				 int maxw, 
				 int maxh, 
				 Single scalefactor, 
				 int spacing, 
				 int border){

	IntPtr _Result = Natives.pixaDisplayMultiTiled(pixas.Pointer,   nx,   ny,   maxw,   maxh,   scalefactor,   spacing,   border);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (2165, 1)
// pixaSplitIntoFiles(pixas, nsplit, scale, outwidth, write_pixa, write_pix, write_pdf) as int
// pixaSplitIntoFiles(PIXA *, l_int32, l_float32, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) For each requested output, %nsplit files are written into
/// directory /tmp/lept/split/.<para/>
/// 
/// (2) This is useful when a pixa is so large that the images
/// are not conveniently displayed as a single tiled image at
/// full resolution.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSplitIntoFiles/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="nsplit">[in] - split pixas into this number of pixa greater or equal 2</param>
///  <param name="scale">[in] - scalefactor applied to each pix</param>
///  <param name="outwidth">[in] - the maxwidth parameter of tiled images for write_pix</param>
///  <param name="write_pixa">[in] - 1 to write the split pixa as separate files</param>
///  <param name="write_pix">[in] - 1 to write tiled images of the split pixa</param>
///  <param name="write_pdf">[in] - 1 to write pdfs of the split pixa</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSplitIntoFiles(
				 Pixa pixas, 
				 int nsplit, 
				 Single scale, 
				 int outwidth, 
				 int write_pixa, 
				 int write_pix, 
				 int write_pdf){

	int _Result = Natives.pixaSplitIntoFiles(pixas.Pointer,   nsplit,   scale,   outwidth,   write_pixa,   write_pix,   write_pdf);
	



	return _Result;
}

// pixafunc2.c (2254, 1)
// convertToNUpFiles(dir, substr, nx, ny, tw, spacing, border, fontsize, outdir) as int
// convertToNUpFiles(const char *, const char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, const char *) as l_ok
///  <summary>
/// (1) Each set of %nx  %ny images is scaled and tiled into a single
/// image, that is written out to %outdir.<para/>
/// 
/// (2) All images in each %nx  %ny set are scaled to the same
/// width, %tw.  This is typically used when all images are
/// roughly the same size.<para/>
/// 
/// (3) This is useful for generating a pdf from the set of input
/// files, where each page is a tile of (%nx  %ny) input images.
/// Typical values for %nx and %ny are in the range [2 ... 5].<para/>
/// 
/// (4) If %fontsize != 0, each image has the tail of its filename
/// rendered below it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToNUpFiles/*"/>
///  <param name="dir">[in] - full path to directory of images</param>
///  <param name="substr">[in][optional] - can be null</param>
///  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="tw">[in] - target width, in pixels must be greater or equal 20</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///  <param name="fontsize">[in] - to print tail of filename with image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
///  <param name="outdir">[in] - subdirectory of /tmp to put N-up tiled images</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertToNUpFiles(
				 String dir, 
				 String substr, 
				 int nx, 
				 int ny, 
				 int tw, 
				 int spacing, 
				 int border, 
				 int fontsize, 
				 String outdir){

	int _Result = Natives.convertToNUpFiles(  dir,   substr,   nx,   ny,   tw,   spacing,   border,   fontsize,   outdir);
	



	return _Result;
}

// pixafunc2.c (2316, 1)
// convertToNUpPixa(dir, substr, nx, ny, tw, spacing, border, fontsize) as Pixa
// convertToNUpPixa(const char *, const char *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) See notes for convertToNUpFiles()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToNUpPixa/*"/>
///  <param name="dir">[in] - full path to directory of images</param>
///  <param name="substr">[in][optional] - can be null</param>
///  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="tw">[in] - target width, in pixels must be greater or equal 20</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///  <param name="fontsize">[in] - to print tail of filename with image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa convertToNUpPixa(
				 String dir, 
				 String substr, 
				 int nx, 
				 int ny, 
				 int tw, 
				 int spacing, 
				 int border, 
				 int fontsize){

	IntPtr _Result = Natives.convertToNUpPixa(  dir,   substr,   nx,   ny,   tw,   spacing,   border,   fontsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (2382, 1)
// pixaConvertToNUpPixa(pixas, sa, nx, ny, tw, spacing, border, fontsize) as Pixa
// pixaConvertToNUpPixa(PIXA *, SARRAY *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIXA *
///  <summary>
/// (1) This takes an input pixa and an optional array of strings, and
/// generates a pixa of NUp tiles from the input, labeled with
/// the strings if they exist and %fontsize != 0.<para/>
/// 
/// (2) See notes for convertToNUpFiles()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaConvertToNUpPixa/*"/>
///  <param name="pixas">[in] - </param>
///  <param name="sa">[in][optional] - array of strings associated with each pix</param>
///  <param name="nx">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="ny">[in] - in [1, ... 50], tiling factors in each direction</param>
///  <param name="tw">[in] - target width, in pixels must be greater or equal 20</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
///  <param name="fontsize">[in] - to print string with each image.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
///   <returns>pixad, or NULL on error</returns>
public static Pixa pixaConvertToNUpPixa(
				 Pixa pixas, 
				 Sarray sa, 
				 int nx, 
				 int ny, 
				 int tw, 
				 int spacing, 
				 int border, 
				 int fontsize){

	IntPtr saPtr = IntPtr.Zero; 	if (sa != null) {saPtr = sa.Pointer;}

	IntPtr _Result = Natives.pixaConvertToNUpPixa(pixas.Pointer, saPtr,   nx,   ny,   tw,   spacing,   border,   fontsize);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

// pixafunc2.c (2495, 1)
// pixaCompareInPdf(pixa1, pixa2, nx, ny, tw, spacing, border, fontsize, fileout) as int
// pixaCompareInPdf(PIXA *, PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, const char *) as l_ok
///  <summary>
/// (1) This takes two pixa and renders them interleaved, side-by-side
/// in a pdf.  A warning is issued if the input pixa arrays
/// have different lengths.<para/>
/// 
/// (2) %nx and %ny specify how many side-by-side pairs are displayed
/// on each pdf page.  For example, if %nx = 1 and %ny = 2, then
/// two pairs are shown, one above the other, on each page.<para/>
/// 
/// (3) The input pix are scaled to a target width of %tw, and
/// then paired with optional %spacing between and optional
/// black border of width %border.<para/>
/// 
/// (4) After a pixa is generated of these tiled images, it is
/// written to %fileout as a pdf.<para/>
/// 
/// (5) Typical numbers for the input parameters are:
/// %nx = small integer (1 - 4)
/// %ny = 2  %nx
/// %tw = 200 - 500 pixels
/// %spacing = 10
/// %border = 2
/// %fontsize = 10<para/>
/// 
/// (6) If %fontsize != 0, the index of the pix pair in their pixa
/// is printed out below each pair.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCompareInPdf/*"/>
///  <param name="pixa1">[in] - </param>
///  <param name="pixa2">[in] - </param>
///  <param name="nx">[in] - in [1, ... 20], tiling factors in each direction</param>
///  <param name="ny">[in] - in [1, ... 20], tiling factors in each direction</param>
///  <param name="tw">[in] - target width, in pixels must be greater or equal 20</param>
///  <param name="spacing">[in] - between images, and on outside</param>
///  <param name="border">[in] - width of additional black border on each image and on each pair use 0 for no border</param>
///  <param name="fontsize">[in] - to print index of each pair of images.  Valid set is {4,6,8,10,12,14,16,18,20}.  Use 0 to disable.</param>
///  <param name="fileout">[in] - output pdf file</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaCompareInPdf(
				 Pixa pixa1, 
				 Pixa pixa2, 
				 int nx, 
				 int ny, 
				 int tw, 
				 int spacing, 
				 int border, 
				 int fontsize, 
				 String fileout){

	int _Result = Natives.pixaCompareInPdf(pixa1.Pointer, pixa2.Pointer,   nx,   ny,   tw,   spacing,   border,   fontsize,   fileout);
	



	return _Result;
}

}
}
