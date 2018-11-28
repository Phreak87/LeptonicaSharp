using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// colormap.c (110, 1)
// pixcmapCreate(depth) as PixColormap
// pixcmapCreate(l_int32) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreate/*"/>
///  <param name="depth">[in] - bpp, of pix</param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapCreate(
				  int depth){

	IntPtr _Result = Natives.pixcmapCreate(  depth);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (157, 1)
// pixcmapCreateRandom(depth, hasblack, haswhite) as PixColormap
// pixcmapCreateRandom(l_int32, l_int32, l_int32) as PIXCMAP *
///  <summary>
/// (1) This sets up a colormap with random colors,
/// where the first color is optionally black, the last color
/// is optionally white, and the remaining colors are
/// chosen randomly.<para/>
/// 
/// (2) The number of randomly chosen colors is:
/// 2^(depth) - haswhite - hasblack<para/>
/// 
/// (3) Because rand() is seeded, it might disrupt otherwise
/// deterministic results if also used elsewhere in a program.<para/>
/// 
/// (4) rand() is not threadsafe, and will generate garbage if run
/// on multiple threads at once -- though garbage is generally
/// what you want from a random number generator!<para/>
/// 
/// (5) Modern rand()s have equal randomness in low and high order
/// bits, but older ones don't.  Here, we're just using rand()
/// to choose colors for output.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreateRandom/*"/>
///  <param name="depth">[in] - bpp, of pix 2, 4 or 8</param>
///  <param name="hasblack">[in] - 1 if the first color is black 0 if no black</param>
///  <param name="haswhite">[in] - 1 if the last color is white 0 if no white</param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapCreateRandom(
				  int depth, 
				  int hasblack, 
				  int haswhite){

	IntPtr _Result = Natives.pixcmapCreateRandom(  depth,   hasblack,   haswhite);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (203, 1)
// pixcmapCreateLinear(d, nlevels) as PixColormap
// pixcmapCreateLinear(l_int32, l_int32) as PIXCMAP *
///  <summary>
/// (1) Colormap has equally spaced gray color values
/// from black (0, 0, 0) to white (255, 255, 255).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreateLinear/*"/>
///  <param name="d">[in] - depth of pix for this colormap 1, 2, 4 or 8</param>
///  <param name="nlevels">[in] - valid in range [2, 2^d]</param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapCreateLinear(
				  int d, 
				  int nlevels){

	IntPtr _Result = Natives.pixcmapCreateLinear(  d,   nlevels);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (233, 1)
// pixcmapCopy(cmaps) as PixColormap
// pixcmapCopy(PIXCMAP *) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCopy/*"/>
///  <param name="cmaps">[in] - </param>
///   <returns>cmapd, or NULL on error</returns>
public static PixColormap pixcmapCopy(
				  PixColormap cmaps){

	IntPtr _Result = Natives.pixcmapCopy(cmaps.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (263, 1)
// pixcmapDestroy(pcmap) as Object
// pixcmapDestroy(PIXCMAP **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapDestroy/*"/>
///  <param name="pcmap">[in,out] - set to null</param>
public static void pixcmapDestroy(
				 ref PixColormap pcmap){

	IntPtr pcmapPtr = IntPtr.Zero; 	if (pcmap != null) {pcmapPtr = pcmap.Pointer;}

	Natives.pixcmapDestroy(ref pcmapPtr);
	

pcmap = null;
	; if (pcmapPtr != IntPtr.Zero){pcmap = new PixColormap(pcmapPtr);}


}

// colormap.c (299, 1)
// pixcmapAddColor(cmap, rval, gval, bval) as int
// pixcmapAddColor(PIXCMAP *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This always adds the color if there is room.<para/>
/// 
/// (2) The alpha component is 255 (opaque)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapAddColor(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval){

	int _Result = Natives.pixcmapAddColor(cmap.Pointer,   rval,   gval,   bval);
	



	return _Result;
}

// colormap.c (337, 1)
// pixcmapAddRGBA(cmap, rval, gval, bval, aval) as int
// pixcmapAddRGBA(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This always adds the color if there is room.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddRGBA/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="aval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapAddRGBA(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				  int aval){

	int _Result = Natives.pixcmapAddRGBA(cmap.Pointer,   rval,   gval,   bval,   aval);
	



	return _Result;
}

// colormap.c (381, 1)
// pixcmapAddNewColor(cmap, rval, gval, bval, pindex) as int
// pixcmapAddNewColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This only adds color if not already there.<para/>
/// 
/// (2) The alpha component is 255 (opaque)<para/>
/// 
/// (3) This returns the index of the new (or existing) color.<para/>
/// 
/// (4) Returns 2 with a warning if unable to add this color
/// the caller should check the return value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddNewColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="pindex">[out] - index of color</param>
///   <returns>0 if OK, 1 on error 2 if unable to add color</returns>
public static int pixcmapAddNewColor(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pindex){

	int _Result = Natives.pixcmapAddNewColor(cmap.Pointer,   rval,   gval,   bval, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (430, 1)
// pixcmapAddNearestColor(cmap, rval, gval, bval, pindex) as int
// pixcmapAddNearestColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This only adds color if not already there.<para/>
/// 
/// (2) The alpha component is 255 (opaque)<para/>
/// 
/// (3) If it's not in the colormap and there is no room to add
/// another color, this returns the index of the nearest color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddNearestColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="pindex">[out] - index of color</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapAddNearestColor(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pindex){

	int _Result = Natives.pixcmapAddNearestColor(cmap.Pointer,   rval,   gval,   bval, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (477, 1)
// pixcmapUsableColor(cmap, rval, gval, bval, pusable) as int
// pixcmapUsableColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This checks if the color already exists or if there is
/// room to add it.  It makes no change in the colormap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapUsableColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="pusable">[out] - 1 if usable 0 if not</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapUsableColor(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pusable){

	int _Result = Natives.pixcmapUsableColor(cmap.Pointer,   rval,   gval,   bval, out  pusable);
	

pusable = 0;


	return _Result;
}

// colormap.c (524, 1)
// pixcmapAddBlackOrWhite(cmap, color, pindex) as int
// pixcmapAddBlackOrWhite(PIXCMAP *, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This only adds color if not already there.<para/>
/// 
/// (2) The alpha component is 255 (opaque)<para/>
/// 
/// (3) This sets index to the requested color.<para/>
/// 
/// (4) If there is no room in the colormap, returns the index
/// of the closest color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddBlackOrWhite/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="color">[in] - 0 for black, 1 for white</param>
///  <param name="pindex">[out][optional] - index of color can be null</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapAddBlackOrWhite(
				  PixColormap cmap, 
				  int color, 
				out int pindex){

	int _Result = Natives.pixcmapAddBlackOrWhite(cmap.Pointer,   color, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (563, 1)
// pixcmapSetBlackAndWhite(cmap, setblack, setwhite) as int
// pixcmapSetBlackAndWhite(PIXCMAP *, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSetBlackAndWhite/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="setblack">[in] - 0 for no operation 1 to set darkest color to black</param>
///  <param name="setwhite">[in] - 0 for no operation 1 to set lightest color to white</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapSetBlackAndWhite(
				  PixColormap cmap, 
				  int setblack, 
				  int setwhite){

	int _Result = Natives.pixcmapSetBlackAndWhite(cmap.Pointer,   setblack,   setwhite);
	



	return _Result;
}

// colormap.c (593, 1)
// pixcmapGetCount(cmap) as int
// pixcmapGetCount(PIXCMAP *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetCount/*"/>
///  <param name="cmap">[in] - </param>
///   <returns>count, or 0 on error</returns>
public static int pixcmapGetCount(
				  PixColormap cmap){

	int _Result = Natives.pixcmapGetCount(cmap.Pointer);
	



	return _Result;
}

// colormap.c (610, 1)
// pixcmapGetFreeCount(cmap) as int
// pixcmapGetFreeCount(PIXCMAP *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetFreeCount/*"/>
///  <param name="cmap">[in] - </param>
///   <returns>free entries, or 0 on error</returns>
public static int pixcmapGetFreeCount(
				  PixColormap cmap){

	int _Result = Natives.pixcmapGetFreeCount(cmap.Pointer);
	



	return _Result;
}

// colormap.c (627, 1)
// pixcmapGetDepth(cmap) as int
// pixcmapGetDepth(PIXCMAP *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetDepth/*"/>
///  <param name="cmap">[in] - </param>
///   <returns>depth, or 0 on error</returns>
public static int pixcmapGetDepth(
				  PixColormap cmap){

	int _Result = Natives.pixcmapGetDepth(cmap.Pointer);
	



	return _Result;
}

// colormap.c (650, 1)
// pixcmapGetMinDepth(cmap, pmindepth) as int
// pixcmapGetMinDepth(PIXCMAP *, l_int32 *) as l_ok
///  <summary>
/// (1) On error, [and]mindepth is returned as 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetMinDepth/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="pmindepth">[out] - minimum depth to support the colormap</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapGetMinDepth(
				  PixColormap cmap, 
				 out int pmindepth){

	int _Result = Natives.pixcmapGetMinDepth(cmap.Pointer, out  pmindepth);
	

pmindepth = 0;


	return _Result;
}

// colormap.c (686, 1)
// pixcmapClear(cmap) as int
// pixcmapClear(PIXCMAP *) as l_ok
///  <summary>
/// (1) This removes the colors by setting the count to 0.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapClear/*"/>
///  <param name="cmap">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapClear(
				  PixColormap cmap){

	int _Result = Natives.pixcmapClear(cmap.Pointer);
	



	return _Result;
}

// colormap.c (709, 1)
// pixcmapGetColor(cmap, index, prval, pgval, pbval) as int
// pixcmapGetColor(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="prval">[out] - each color value</param>
///  <param name="pgval">[out] - each color value</param>
///  <param name="pbval">[out] - each color value</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
public static int pixcmapGetColor(
				  PixColormap cmap, 
				  int index, 
				 out int prval, 
				 out int pgval, 
				 out int pbval){

	int _Result = Natives.pixcmapGetColor(cmap.Pointer,   index, out  prval, out  pgval, out  pbval);
	

prval = 0;
pgval = 0;
pbval = 0;


	return _Result;
}

// colormap.c (749, 1)
// pixcmapGetColor32(cmap, index, pval32) as int
// pixcmapGetColor32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
///  <summary>
/// (1) The returned alpha channel value is 255.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetColor32/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="pval32">[out] - 32-bit rgb color value</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
public static int pixcmapGetColor32(
				  PixColormap cmap, 
				  int index, 
				 out uint pval32){

	int _Result = Natives.pixcmapGetColor32(cmap.Pointer,   index, out  pval32);
	

pval32 = 0;


	return _Result;
}

// colormap.c (777, 1)
// pixcmapGetRGBA(cmap, index, prval, pgval, pbval, paval) as int
// pixcmapGetRGBA(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRGBA/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="prval">[out] - each color value</param>
///  <param name="pgval">[out] - each color value</param>
///  <param name="pbval">[out] - each color value</param>
///  <param name="paval">[out] - each color value</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
public static int pixcmapGetRGBA(
				  PixColormap cmap, 
				  int index, 
				 out int prval, 
				 out int pgval, 
				 out int pbval, 
				 out int paval){

	int _Result = Natives.pixcmapGetRGBA(cmap.Pointer,   index, out  prval, out  pgval, out  pbval, out  paval);
	

prval = 0;
pgval = 0;
pbval = 0;
paval = 0;


	return _Result;
}

// colormap.c (815, 1)
// pixcmapGetRGBA32(cmap, index, pval32) as int
// pixcmapGetRGBA32(PIXCMAP *, l_int32, l_uint32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRGBA32/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="pval32">[out] - 32-bit rgba color value</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
public static int pixcmapGetRGBA32(
				  PixColormap cmap, 
				  int index, 
				 out uint pval32){

	int _Result = Natives.pixcmapGetRGBA32(cmap.Pointer,   index, out  pval32);
	

pval32 = 0;


	return _Result;
}

// colormap.c (851, 1)
// pixcmapResetColor(cmap, index, rval, gval, bval) as int
// pixcmapResetColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This resets sets the color of an entry that has already
/// been set and included in the count of colors.<para/>
/// 
/// (2) The alpha component is 255 (opaque)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapResetColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="rval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be reset each number is in range [0, ... 255]</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
public static int pixcmapResetColor(
				  PixColormap cmap, 
				  int index, 
				  int rval, 
				  int gval, 
				  int bval){

	int _Result = Natives.pixcmapResetColor(cmap.Pointer,   index,   rval,   gval,   bval);
	



	return _Result;
}

// colormap.c (892, 1)
// pixcmapSetAlpha(cmap, index, aval) as int
// pixcmapSetAlpha(PIXCMAP *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This modifies the transparency of one entry in a colormap.
/// The alpha component by default is 255 (opaque).
/// This is used when extracting the colormap from a PNG file
/// without decoding the image.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSetAlpha/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="aval">[in] - in range [0, ... 255]</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapSetAlpha(
				  PixColormap cmap, 
				  int index, 
				  int aval){

	int _Result = Natives.pixcmapSetAlpha(cmap.Pointer,   index,   aval);
	



	return _Result;
}

// colormap.c (921, 1)
// pixcmapGetIndex(cmap, rval, gval, bval, pindex) as int
// pixcmapGetIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetIndex/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="pindex">[out] - found index</param>
///   <returns>0 if found, 1 if not found caller must check</returns>
public static int pixcmapGetIndex(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pindex){

	int _Result = Natives.pixcmapGetIndex(cmap.Pointer,   rval,   gval,   bval, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (960, 1)
// pixcmapHasColor(cmap, pcolor) as int
// pixcmapHasColor(PIXCMAP *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapHasColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="pcolor">[out] - TRUE if cmap has color FALSE otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapHasColor(
				  PixColormap cmap, 
				 out int pcolor){

	int _Result = Natives.pixcmapHasColor(cmap.Pointer, out  pcolor);
	

pcolor = 0;


	return _Result;
}

// colormap.c (999, 1)
// pixcmapIsOpaque(cmap, popaque) as int
// pixcmapIsOpaque(PIXCMAP *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapIsOpaque/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="popaque">[out] - TRUE if fully opaque: all entries are 255</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapIsOpaque(
				  PixColormap cmap, 
				 out int popaque){

	int _Result = Natives.pixcmapIsOpaque(cmap.Pointer, out  popaque);
	

popaque = 0;


	return _Result;
}

// colormap.c (1034, 1)
// pixcmapIsBlackAndWhite(cmap, pblackwhite) as int
// pixcmapIsBlackAndWhite(PIXCMAP *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapIsBlackAndWhite/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="pblackwhite">[out] - TRUE if the cmap has only two colors: black (0,0,0) and white (255,255,255)</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapIsBlackAndWhite(
				  PixColormap cmap, 
				 out int pblackwhite){

	int _Result = Natives.pixcmapIsBlackAndWhite(cmap.Pointer, out  pblackwhite);
	

pblackwhite = 0;


	return _Result;
}

// colormap.c (1075, 1)
// pixcmapCountGrayColors(cmap, pngray) as int
// pixcmapCountGrayColors(PIXCMAP *, l_int32 *) as l_ok
///  <summary>
/// (1) This counts the unique gray colors, including black and white.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCountGrayColors/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="pngray">[out] - number of gray colors</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapCountGrayColors(
				  PixColormap cmap, 
				 out int pngray){

	int _Result = Natives.pixcmapCountGrayColors(cmap.Pointer, out  pngray);
	

pngray = 0;


	return _Result;
}

// colormap.c (1116, 1)
// pixcmapGetRankIntensity(cmap, rankval, pindex) as int
// pixcmapGetRankIntensity(PIXCMAP *, l_float32, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRankIntensity/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rankval">[in] - 0.0 for darkest, 1.0 for lightest color</param>
///  <param name="pindex">[out] - the index into the colormap that corresponds to the rank intensity color</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapGetRankIntensity(
				  PixColormap cmap, 
				  Single rankval, 
				 out int pindex){

	int _Result = Natives.pixcmapGetRankIntensity(cmap.Pointer,   rankval, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (1167, 1)
// pixcmapGetNearestIndex(cmap, rval, gval, bval, pindex) as int
// pixcmapGetNearestIndex(PIXCMAP *, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) Returns the index of the exact color if possible, otherwise the
/// index of the color closest to the target color.<para/>
/// 
/// (2) Nearest color is that which is the least sum-of-squares distance
/// from the target color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetNearestIndex/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="rval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap colors to search for each number is in range [0, ... 255]</param>
///  <param name="pindex">[out] - the index of the nearest color</param>
///   <returns>0 if OK, 1 on error caller must check</returns>
public static int pixcmapGetNearestIndex(
				  PixColormap cmap, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pindex){

	int _Result = Natives.pixcmapGetNearestIndex(cmap.Pointer,   rval,   gval,   bval, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (1225, 1)
// pixcmapGetNearestGrayIndex(cmap, val, pindex) as int
// pixcmapGetNearestGrayIndex(PIXCMAP *, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This should be used on gray colormaps.  It uses only the
/// green value of the colormap.<para/>
/// 
/// (2) Returns the index of the exact color if possible, otherwise the
/// index of the color closest to the target color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetNearestGrayIndex/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="val">[in] - gray value to search for in range [0, ... 255]</param>
///  <param name="pindex">[out] - the index of the nearest color</param>
///   <returns>0 if OK, 1 on error caller must check</returns>
public static int pixcmapGetNearestGrayIndex(
				  PixColormap cmap, 
				  int val, 
				 out int pindex){

	int _Result = Natives.pixcmapGetNearestGrayIndex(cmap.Pointer,   val, out  pindex);
	

pindex = 0;


	return _Result;
}

// colormap.c (1278, 1)
// pixcmapGetDistanceToColor(cmap, index, rval, gval, bval, pdist) as int
// pixcmapGetDistanceToColor(PIXCMAP *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) Returns the L2 distance (squared) between the color at index i
/// and the target color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetDistanceToColor/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="index">[in] - </param>
///  <param name="rval">[in] - target color</param>
///  <param name="gval">[in] - target color</param>
///  <param name="bval">[in] - target color</param>
///  <param name="pdist">[out] - the distance from the cmap entry to target</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapGetDistanceToColor(
				  PixColormap cmap, 
				  int index, 
				  int rval, 
				  int gval, 
				  int bval, 
				 out int pdist){

	int _Result = Natives.pixcmapGetDistanceToColor(cmap.Pointer,   index,   rval,   gval,   bval, out  pdist);
	

pdist = 0;


	return _Result;
}

// colormap.c (1334, 1)
// pixcmapGetRangeValues(cmap, select, pminval, pmaxval, pminindex, pmaxindex) as int
// pixcmapGetRangeValues(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) Returns, for selected components (or the average), the
/// the extreme values (min and/or max) and their indices
/// that are found in the cmap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetRangeValues/*"/>
///  <param name="cmap">[in] - </param>
///  <param name="pminval">[out][optional] - minimum value of component</param>
///  <param name="pmaxval">[out][optional] - maximum value of component</param>
///  <param name="pminindex">[out][optional] - index of minimum value</param>
///  <param name="pmaxindex">[out][optional] - index of maximum value</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapGetRangeValues(
				  PixColormap cmap, 
				  int _select_, 
				out int pminval, 
				out int pmaxval, 
				out int pminindex, 
				out int pmaxindex){

	int _Result = Natives.pixcmapGetRangeValues(cmap.Pointer,   _select_, out  pminval, out  pmaxval, out  pminindex, out  pmaxindex);
	

pminval = 0;
pmaxval = 0;
pminindex = 0;
pmaxindex = 0;


	return _Result;
}

// colormap.c (1430, 1)
// pixcmapGrayToColor(color) as PixColormap
// pixcmapGrayToColor(l_uint32) as PIXCMAP *
///  <summary>
/// (1) This creates a colormap that maps from gray to
/// a specific color.  In the mapping, each component
/// is faded to white, depending on the gray value.<para/>
/// 
/// (2) In use, this is simply attached to a grayscale pix
/// to give it the input color.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGrayToColor/*"/>
///  <param name="color">[in] - </param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapGrayToColor(
				  uint color){

	IntPtr _Result = Natives.pixcmapGrayToColor(  color);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1462, 1)
// pixcmapColorToGray(cmaps, rwt, gwt, bwt) as PixColormap
// pixcmapColorToGray(PIXCMAP *, l_float32, l_float32, l_float32) as PIXCMAP *
///  <summary>
/// (1) This creates a gray colormap from an arbitrary colormap.<para/>
/// 
/// (2) In use, attach the output gray colormap to the pix
/// (or a copy of it) that provided the input colormap.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapColorToGray/*"/>
///  <param name="cmaps">[in] - </param>
///  <param name="rwt">[in] - non-negative these should add to 1.0</param>
///  <param name="gwt">[in] - non-negative these should add to 1.0</param>
///  <param name="bwt">[in] - non-negative these should add to 1.0</param>
///   <returns>cmap gray, or NULL on error</returns>
public static PixColormap pixcmapColorToGray(
				  PixColormap cmaps, 
				  Single rwt, 
				  Single gwt, 
				  Single bwt){

	IntPtr _Result = Natives.pixcmapColorToGray(cmaps.Pointer,   rwt,   gwt,   bwt);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1518, 1)
// pixcmapConvertTo4(cmaps) as PixColormap
// pixcmapConvertTo4(PIXCMAP *) as PIXCMAP *
///  <summary>
/// (1) This converts a 2 bpp colormap to 4 bpp.  The colors
/// are the same the output colormap entry array has size 16.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertTo4/*"/>
///  <param name="cmaps">[in] - colormap for 2 bpp pix</param>
///   <returns>cmapd   (4 bpp)</returns>
public static PixColormap pixcmapConvertTo4(
				  PixColormap cmaps){

	IntPtr _Result = Natives.pixcmapConvertTo4(cmaps.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1553, 1)
// pixcmapConvertTo8(cmaps) as PixColormap
// pixcmapConvertTo8(PIXCMAP *) as PIXCMAP *
///  <summary>
/// (1) This converts a 2 bpp or 4 bpp colormap to 8 bpp.  The colors
/// are the same the output colormap entry array has size 256.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertTo8/*"/>
///  <param name="cmaps">[in] - colormap for 2 bpp or 4 bpp pix</param>
///   <returns>cmapd   (8 bpp)</returns>
public static PixColormap pixcmapConvertTo8(
				  PixColormap cmaps){

	IntPtr _Result = Natives.pixcmapConvertTo8(cmaps.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1587, 1)
// pixcmapRead(filename) as PixColormap
// pixcmapRead(const char *) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapRead(
				  String filename){

	IntPtr _Result = Natives.pixcmapRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1614, 1)
// pixcmapReadStream(fp) as PixColormap
// pixcmapReadStream(FILE *) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapReadStream(
				  FILE fp){

	IntPtr _Result = Natives.pixcmapReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1655, 1)
// pixcmapReadMem(data, size) as PixColormap
// pixcmapReadMem(const l_uint8 *, size_t) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapReadMem/*"/>
///  <param name="data">[in] - serialization of pixcmap in ascii</param>
///  <param name="size">[in] - of data in bytes can use strlen to get it</param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapReadMem(
				  Byte[] data, 
				  uint size){

	IntPtr _Result = Natives.pixcmapReadMem(  data,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (1683, 1)
// pixcmapWrite(filename, cmap) as int
// pixcmapWrite(const char *, PIXCMAP *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="cmap">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapWrite(
				  String filename, 
				  PixColormap cmap){

	int _Result = Natives.pixcmapWrite(  filename, cmap.Pointer);
	



	return _Result;
}

// colormap.c (1715, 1)
// pixcmapWriteStream(fp, cmap) as int
// pixcmapWriteStream(FILE *, PIXCMAP *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWriteStream/*"/>
///  <param name="fp">[in] - file stream    \param[in]    cmap</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapWriteStream(
				  FILE fp, 
				  PixColormap cmap){

	IntPtr cmapPtr = IntPtr.Zero; if (cmap != null) {cmapPtr = cmap.Pointer;}

	int _Result = Natives.pixcmapWriteStream(fp.Pointer, cmap.Pointer);
	



	return _Result;
}

// colormap.c (1761, 1)
// pixcmapWriteMem(pdata, psize, cmap) as int
// pixcmapWriteMem(l_uint8 **, size_t *, PIXCMAP *) as l_ok
///  <summary>
/// (1) Serializes a pixcmap in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized pixcmap ascii</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="cmap">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixcmapWriteMem(
				 out Byte[] pdata, 
				 out uint psize, 
				  PixColormap cmap){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixcmapWriteMem(out  pdataPtr, out  psize, cmap.Pointer);
	

pdata = null;
psize = 0;


	return _Result;
}

// colormap.c (1813, 1)
// pixcmapToArrays(cmap, prmap, pgmap, pbmap, pamap) as int
// pixcmapToArrays(PIXCMAP *, l_int32 **, l_int32 **, l_int32 **, l_int32 **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapToArrays/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="prmap">[out] - colormap arrays</param>
///  <param name="pgmap">[out] - colormap arrays</param>
///  <param name="pbmap">[out] - colormap arrays</param>
///  <param name="pamap">[out][optional] - alpha array</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapToArrays(
				  PixColormap cmap, 
				 out List<int[]> prmap, 
				 out List<int[]> pgmap, 
				 out List<int[]> pbmap, 
				out List<int[]> pamap){

	IntPtr prmapPtr = IntPtr.Zero;
	IntPtr pgmapPtr = IntPtr.Zero;
	IntPtr pbmapPtr = IntPtr.Zero;
	IntPtr pamapPtr = IntPtr.Zero;

	int _Result = Natives.pixcmapToArrays(cmap.Pointer, out  prmapPtr, out  pgmapPtr, out  pbmapPtr, out  pamapPtr);
	

prmap = null;
pgmap = null;
pbmap = null;
pamap = null;


	return _Result;
}

// colormap.c (1867, 1)
// pixcmapToRGBTable(cmap, ptab, pncolors) as int
// pixcmapToRGBTable(PIXCMAP *, l_uint32 **, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapToRGBTable/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="ptab">[out] - table of rgba values for the colormap</param>
///  <param name="pncolors">[out][optional] - size of table</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapToRGBTable(
				  PixColormap cmap, 
				 out Byte[] ptab, 
				out int pncolors){

	IntPtr ptabPtr = IntPtr.Zero;

	int _Result = Natives.pixcmapToRGBTable(cmap.Pointer, out  ptabPtr, out  pncolors);
	

ptab = null;
pncolors = 0;


	return _Result;
}

// colormap.c (1912, 1)
// pixcmapSerializeToMemory(cmap, cpc, pncolors, pdata) as int
// pixcmapSerializeToMemory(PIXCMAP *, l_int32, l_int32 *, l_uint8 **) as l_ok
///  <summary>
/// (1) When serializing to store in a pdf, use %cpc = 3.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapSerializeToMemory/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="cpc">[in] - components/color: 3 for rgb, 4 for rgba</param>
///  <param name="pncolors">[out] - number of colors in table</param>
///  <param name="pdata">[out] - binary string, cpc bytes per color</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapSerializeToMemory(
				  PixColormap cmap, 
				  int cpc, 
				 out int pncolors, 
				 out Byte[] pdata){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.pixcmapSerializeToMemory(cmap.Pointer,   cpc, out  pncolors, out  pdataPtr);
	

pncolors = 0;
pdata = null;


	return _Result;
}

// colormap.c (1960, 1)
// pixcmapDeserializeFromMemory(data, cpc, ncolors) as PixColormap
// pixcmapDeserializeFromMemory(l_uint8 *, l_int32, l_int32) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapDeserializeFromMemory/*"/>
///  <param name="data">[in] - binary string, 3 or 4 bytes per color</param>
///  <param name="cpc">[in] - components/color: 3 for rgb, 4 for rgba</param>
///  <param name="ncolors">[in] - </param>
///   <returns>cmap, or NULL on error</returns>
public static PixColormap pixcmapDeserializeFromMemory(
				  Byte[] data, 
				  int cpc, 
				  int ncolors){

	IntPtr _Result = Natives.pixcmapDeserializeFromMemory(  data,   cpc,   ncolors);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new PixColormap(_Result);
}

// colormap.c (2021, 1)
// pixcmapConvertToHex(data, ncolors) as String
// pixcmapConvertToHex(l_uint8 *, l_int32) as char *
///  <summary>
/// (1) The number of bytes in %data is 3  ncolors.<para/>
/// 
/// (2) Output is in form:
///  is smaller r0g0b0 r1g1b1 ... rngnbn  is greater 
/// where r0, g0, b0 ... are each 2 bytes of hex ascii<para/>
/// 
/// (3) This is used in pdf files to express the colormap as an
/// array in ascii (human-readable) format.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapConvertToHex/*"/>
///  <param name="data">[in] - binary serialized data</param>
///  <param name="ncolors">[in] - in colormap</param>
///   <returns>hexdata bracketed, space-separated ascii hex string, or NULL on error.</returns>
public static String pixcmapConvertToHex(
				  Byte[] data, 
				  int ncolors){

	String _Result = Natives.pixcmapConvertToHex(  data,   ncolors);
	



	return _Result;
}

// colormap.c (2079, 1)
// pixcmapGammaTRC(cmap, gamma, minval, maxval) as int
// pixcmapGammaTRC(PIXCMAP *, l_float32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This is an in-place transform<para/>
/// 
/// (2) See pixGammaTRC() and numaGammaTRC() in enhance.c
/// for description and use of transform
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGammaTRC/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="gamma">[in] - gamma correction must be  is greater  0.0</param>
///  <param name="minval">[in] - input value that gives 0 for output can be  is smaller 0</param>
///  <param name="maxval">[in] - input value that gives 255 for output can be  is greater  255</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapGammaTRC(
				  PixColormap cmap, 
				  Single gamma, 
				  int minval, 
				  int maxval){

	int _Result = Natives.pixcmapGammaTRC(cmap.Pointer,   gamma,   minval,   maxval);
	



	return _Result;
}

// colormap.c (2134, 1)
// pixcmapContrastTRC(cmap, factor) as int
// pixcmapContrastTRC(PIXCMAP *, l_float32) as l_ok
///  <summary>
/// (1) This is an in-place transform<para/>
/// 
/// (2) See pixContrastTRC() and numaContrastTRC() in enhance.c
/// for description and use of transform
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapContrastTRC/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="factor">[in] - generally between 0.0 [no enhancement] and 1.0, but can be larger than 1.0</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapContrastTRC(
				  PixColormap cmap, 
				  Single factor){

	int _Result = Natives.pixcmapContrastTRC(cmap.Pointer,   factor);
	



	return _Result;
}

// colormap.c (2186, 1)
// pixcmapShiftIntensity(cmap, fraction) as int
// pixcmapShiftIntensity(PIXCMAP *, l_float32) as l_ok
///  <summary>
/// (1) This is an in-place transform<para/>
/// 
/// (2) It does a proportional shift of the intensity for each color.<para/>
/// 
/// (3) If fraction  is smaller 0.0, it moves all colors towards (0,0,0).
/// This darkens the image.
/// If fraction  is greater  0.0, it moves all colors towards (255,255,255)
/// This fades the image.<para/>
/// 
/// (4) The equivalent transform can be accomplished with pixcmapGammaTRC(),
/// but it is considerably more difficult (see numaGammaTRC()).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapShiftIntensity/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="fraction">[in] - between -1.0 and +1.0</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapShiftIntensity(
				  PixColormap cmap, 
				  Single fraction){

	int _Result = Natives.pixcmapShiftIntensity(cmap.Pointer,   fraction);
	



	return _Result;
}

// colormap.c (2236, 1)
// pixcmapShiftByComponent(cmap, srcval, dstval) as int
// pixcmapShiftByComponent(PIXCMAP *, l_uint32, l_uint32) as l_ok
///  <summary>
/// (1) This is an in-place transform<para/>
/// 
/// (2) It implements pixelShiftByComponent() for each color.
/// The mapping is specified by srcval and dstval.<para/>
/// 
/// (3) If a component decreases, the component in the colormap
/// decreases by the same ratio.  Likewise for increasing, except
/// all ratios are taken with respect to the distance from 255.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapShiftByComponent/*"/>
///  <param name="cmap">[in] - colormap</param>
///  <param name="srcval">[in] - source color: 0xrrggbb00</param>
///  <param name="dstval">[in] - target color: 0xrrggbb00</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixcmapShiftByComponent(
				  PixColormap cmap, 
				  uint srcval, 
				  uint dstval){

	int _Result = Natives.pixcmapShiftByComponent(cmap.Pointer,   srcval,   dstval);
	



	return _Result;
}

}
