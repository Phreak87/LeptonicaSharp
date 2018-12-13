using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// pix2.c (180, 1)
		// pixGetPixel(pix, x, y, pval) as int
		// pixGetPixel(PIX *, l_int32, l_int32, l_uint32 *) as l_ok
		///  <summary>
		/// (1) This returns the value in the data array.  If the pix is
		/// colormapped, it returns the colormap index, not the rgb value.<para/>
		///
		/// (2) Because of the function overhead and the parameter checking,
		/// this is much slower than using the GET_DATA_() macros directly.
		/// Speed on a 1 Mpixel RGB image, using a 3 GHz machine:
		/// pixGet/pixSet: ~25 Mpix/sec
		/// GET_DATA/SET_DATA: ~350 MPix/sec
		/// If speed is important and you're doing random access into
		/// the pix, use pixGetLinePtrs() and the array access macros.<para/>
		///
		/// (3) If the point is outside the image, this returns an error (1),
		/// with 0 in %pval.  To avoid spamming output, it fails silently.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetPixel/*"/>
		///  <param name="pix">[in] - </param>
		///  <param name="x">[in] - ,y    pixel coords</param>
		///  <param name="pval">[out] - pixel value</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixGetPixel(
						Pix pix,
						int x,
						int y,
						out uint pval)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixGetPixel(pix.Pointer,   x,   y, out  pval);
			return _Result;
		}

		// pix2.c (251, 1)
		// pixSetPixel(pix, x, y, val) as int
		// pixSetPixel(PIX *, l_int32, l_int32, l_uint32) as l_ok
		///  <summary>
		/// (1) Warning: the input value is not checked for overflow with respect
		/// the the depth of %pix, and the sign bit (if any) is ignored.
		/// For d == 1, %val  is greater  0 sets the bit on.
		/// For d == 2, 4, 8 and 16, %val is masked to the maximum allowable
		/// pixel value, and any (invalid) higher order bits are discarded.<para/>
		///
		/// (2) See pixGetPixel() for information on performance.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetPixel/*"/>
		///  <param name="pix">[in] - </param>
		///  <param name="x">[in] - ,y   pixel coords</param>
		///  <param name="val">[in] - value to be inserted</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetPixel(
						Pix pix,
						int x,
						int y,
						uint val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetPixel(pix.Pointer,   x,   y,   val);
			return _Result;
		}

		// pix2.c (314, 1)
		// pixGetRGBPixel(pix, x, y, prval, pgval, pbval) as int
		// pixGetRGBPixel(PIX *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// pixGetRGBPixel()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRGBPixel/*"/>
		///  <param name="pix">[in] - 32 bpp rgb, not colormapped</param>
		///  <param name="x">[in] - ,y    pixel coords</param>
		///  <param name="prval">[out][optional] - red component</param>
		///  <param name="pgval">[out][optional] - green component</param>
		///  <param name="pbval">[out][optional] - blue component</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixGetRGBPixel(
						Pix pix,
						int x,
						int y,
						out int prval,
						out int pgval,
						out int pbval)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if ((new List<int> {32}).Contains ((int)pix.d) == false) { throw new ArgumentException ("32 bpp rgb, not colormapped"); }
			int _Result = Natives.pixGetRGBPixel(pix.Pointer,   x,   y, out  prval, out  pgval, out  pbval);
			return _Result;
		}

		// pix2.c (362, 1)
		// pixSetRGBPixel(pix, x, y, rval, gval, bval) as int
		// pixSetRGBPixel(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// pixSetRGBPixel()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetRGBPixel/*"/>
		///  <param name="pix">[in] - 32 bpp rgb</param>
		///  <param name="x">[in] - ,y    pixel coords</param>
		///  <param name="rval">[in] - red component</param>
		///  <param name="gval">[in] - green component</param>
		///  <param name="bval">[in] - blue component</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetRGBPixel(
						Pix pix,
						int x,
						int y,
						int rval,
						int gval,
						int bval)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if ((new List<int> {32}).Contains ((int)pix.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
			int _Result = Natives.pixSetRGBPixel(pix.Pointer,   x,   y,   rval,   gval,   bval);
			return _Result;
		}

		// pix2.c (409, 1)
		// pixGetRandomPixel(pix, pval, px, py) as int
		// pixGetRandomPixel(PIX *, l_uint32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) If the pix is colormapped, it returns the rgb value.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRandomPixel/*"/>
		///  <param name="pix">[in] - any depth can be colormapped</param>
		///  <param name="pval">[out][optional] - pixel value</param>
		///  <param name="px">[out][optional] - x coordinate chosen can be null</param>
		///  <param name="py">[out][optional] - y coordinate chosen can be null</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixGetRandomPixel(
						Pix pix,
						out uint pval,
						out int px,
						out int py)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixGetRandomPixel(pix.Pointer, out  pval, out  px, out  py);
			return _Result;
		}

		// pix2.c (455, 1)
		// pixClearPixel(pix, x, y) as int
		// pixClearPixel(PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// pixClearPixel()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClearPixel/*"/>
		///  <param name="pix">[in] - any depth warning if colormapped</param>
		///  <param name="x">[in] - ,y   pixel coords</param>
		///   <returns>0 if OK 1 on error.</returns>
		public static int pixClearPixel(
						Pix pix,
						int x,
						int y)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixClearPixel(pix.Pointer,   x,   y);
			return _Result;
		}

		// pix2.c (513, 1)
		// pixFlipPixel(pix, x, y) as int
		// pixFlipPixel(PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// pixFlipPixel()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFlipPixel/*"/>
		///  <param name="pix">[in] - any depth, warning if colormapped</param>
		///  <param name="x">[in] - ,y   pixel coords</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixFlipPixel(
						Pix pix,
						int x,
						int y)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixFlipPixel(pix.Pointer,   x,   y);
			return _Result;
		}

		// pix2.c (592, 1)
		// setPixelLow(line, x, depth, val) as Object
		// setPixelLow(l_uint32 *, l_int32, l_int32, l_uint32) as void
		///  <summary>
		/// (1) Caution: input variables are not checked!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/setPixelLow/*"/>
		///  <param name="line">[in] - ptr to beginning of line,</param>
		///  <param name="x">[in] - pixel location in line</param>
		///  <param name="depth">[in] - bpp</param>
		///  <param name="val">[in] - to be inserted</param>
		public static void setPixelLow(
						Byte[] line,
						int x,
						int depth,
						uint val)
		{
			if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}

			IntPtr linePtr = 	Marshal.AllocHGlobal(line.Length);
			Marshal.Copy(line, 0, linePtr, line.Length);
			Natives.setPixelLow(  linePtr,   x,   depth,   val);
			Marshal.FreeHGlobal(linePtr);
		}

		// pix2.c (648, 1)
		// pixGetBlackOrWhiteVal(pixs, op, pval) as int
		// pixGetBlackOrWhiteVal(PIX *, l_int32, l_uint32 *) as l_ok
		///  <summary>
		/// (1) Side effect.  For a colormapped image, if the requested
		/// color is not present and there is room to add it in the cmap,
		/// it is added and the new index is returned.  If there is no room,
		/// the index of the closest color in intensity is returned.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetBlackOrWhiteVal/*"/>
		///  <param name="pixs">[in] - all depths cmap ok</param>
		///  <param name="op">[in] - L_GET_BLACK_VAL, L_GET_WHITE_VAL</param>
		///  <param name="pval">[out] - pixel value</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixGetBlackOrWhiteVal(
						Pix pixs,
						int op,
						out uint pval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixGetBlackOrWhiteVal(pixs.Pointer,   op, out  pval);
			return _Result;
		}

		// pix2.c (704, 1)
		// pixClearAll(pix) as int
		// pixClearAll(PIX *) as l_ok
		///  <summary>
		/// (1) Clears all data to 0.  For 1 bpp, this is white for grayscale
		/// or color, this is black.<para/>
		///
		/// (2) Caution: for colormapped pix, this sets the color to the first
		/// one in the colormap.  Be sure that this is the intended color!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClearAll/*"/>
		///  <param name="pix">[in] - all depths use cmapped with caution</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixClearAll(
						Pix pix)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixClearAll(pix.Pointer);
			return _Result;
		}

		// pix2.c (733, 1)
		// pixSetAll(pix) as int
		// pixSetAll(PIX *) as l_ok
		///  <summary>
		/// (1) Sets all data to 1.  For 1 bpp, this is black for grayscale
		/// or color, this is white.<para/>
		///
		/// (2) Caution: for colormapped pix, this sets the pixel value to the
		/// maximum value supported by the colormap: 2^d - 1.  However, this
		/// color may not be defined, because the colormap may not be full.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetAll/*"/>
		///  <param name="pix">[in] - all depths use cmapped with caution</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSetAll(
						Pix pix)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetAll(pix.Pointer);
			return _Result;
		}

		// pix2.c (776, 1)
		// pixSetAllGray(pix, grayval) as int
		// pixSetAllGray(PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) N.B.  For all images, %grayval == 0 represents black and
		/// %grayval == 255 represents white.<para/>
		///
		/// (2) For depth  is smaller 8, we do our best to approximate the gray level.
		/// For 1 bpp images, any %grayval  is smaller 128 is black greater or equal 128 is white.
		/// For 32 bpp images, each r,g,b component is set to %grayval,
		/// and the alpha component is preserved.<para/>
		///
		/// (3) If pix is colormapped, it adds the gray value, replicated in
		/// all components, to the colormap if it's not there and there
		/// is room.  If the colormap is full, it finds the closest color in
		/// L2 distance of components.  This index is written to all pixels.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetAllGray/*"/>
		///  <param name="pix">[in] - all depths, cmap ok</param>
		///  <param name="grayval">[in] - in range 0 ... 255</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetAllGray(
						Pix pix,
						int grayval)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetAllGray(pix.Pointer,   grayval);
			return _Result;
		}

		// pix2.c (868, 1)
		// pixSetAllArbitrary(pix, val) as int
		// pixSetAllArbitrary(PIX *, l_uint32) as l_ok
		///  <summary>
		/// (1) Caution 1!  For colormapped pix, %val is used as an index
		/// into a colormap.  Be sure that index refers to the intended color.
		/// If the color is not in the colormap, you should first add it
		/// and then call this function.<para/>
		///
		/// (2) Caution 2!  For 32 bpp pix, the interpretation of the LSB
		/// of %val depends on whether spp == 3 (RGB) or spp == 4 (RGBA).
		/// For RGB, the LSB is ignored in image transformations.
		/// For RGBA, the LSB is interpreted as the alpha (transparency)
		/// component full transparency has alpha == 0x0, whereas
		/// full opacity has alpha = 0xff.  An RGBA image with full
		/// opacity behaves like an RGB image.<para/>
		///
		/// (3) As an example of (2), suppose you want to initialize a 32 bpp
		/// pix with partial opacity, say 0xee337788.  If the pix is 3 spp,
		/// the 0x88 alpha component will be ignored and may be changed
		/// in subsequent processing.  However, if the pix is 4 spp, the
		/// alpha component will be retained and used. The function
		/// pixCreate(w, h, 32) makes an RGB image by default, and
		/// pixSetSpp(pix, 4) can be used to promote an RGB image to RGBA.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetAllArbitrary/*"/>
		///  <param name="pix">[in] - all depths use cmapped with caution</param>
		///  <param name="val">[in] - value to set all pixels</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetAllArbitrary(
						Pix pix,
						uint val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetAllArbitrary(pix.Pointer,   val);
			return _Result;
		}

		// pix2.c (938, 1)
		// pixSetBlackOrWhite(pixs, op) as int
		// pixSetBlackOrWhite(PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) Function for setting all pixels in an image to either black
		/// or white.<para/>
		///
		/// (2) If pixs is colormapped, it adds black or white to the
		/// colormap if it's not there and there is room.  If the colormap
		/// is full, it finds the closest color in intensity.
		/// This index is written to all pixels.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetBlackOrWhite/*"/>
		///  <param name="pixs">[in] - all depths cmap ok</param>
		///  <param name="op">[in] - L_SET_BLACK, L_SET_WHITE</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetBlackOrWhite(
						Pix pixs,
						int op)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixSetBlackOrWhite(pixs.Pointer,   op);
			return _Result;
		}

		// pix2.c (985, 1)
		// pixSetComponentArbitrary(pix, comp, val) as int
		// pixSetComponentArbitrary(PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) For example, this can be used to set the alpha component to opaque:
		/// pixSetComponentArbitrary(pix, L_ALPHA_CHANNEL, 255)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetComponentArbitrary/*"/>
		///  <param name="pix">[in] - 32 bpp</param>
		///  <param name="comp">[in] - COLOR_RED, COLOR_GREEN, COLOR_BLUE, L_ALPHA_CHANNEL</param>
		///  <param name="val">[in] - value to set this component</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetComponentArbitrary(
						Pix pix,
						int comp,
						int val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixSetComponentArbitrary(pix.Pointer,   comp,   val);
			return _Result;
		}

		// pix2.c (1035, 1)
		// pixClearInRect(pix, box) as int
		// pixClearInRect(PIX *, BOX *) as l_ok
		///  <summary>
		/// (1) Clears all data in rect to 0.  For 1 bpp, this is white
		/// for grayscale or color, this is black.<para/>
		///
		/// (2) Caution: for colormapped pix, this sets the color to the first
		/// one in the colormap.  Be sure that this is the intended color!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClearInRect/*"/>
		///  <param name="pix">[in] - all depths can be cmapped</param>
		///  <param name="box">[in] - in which all pixels will be cleared</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixClearInRect(
						Pix pix,
						Box box)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.pixClearInRect(pix.Pointer, box.Pointer);
			return _Result;
		}

		// pix2.c (1070, 1)
		// pixSetInRect(pix, box) as int
		// pixSetInRect(PIX *, BOX *) as l_ok
		///  <summary>
		/// (1) Sets all data in rect to 1.  For 1 bpp, this is black
		/// for grayscale or color, this is white.<para/>
		///
		/// (2) Caution: for colormapped pix, this sets the pixel value to the
		/// maximum value supported by the colormap: 2^d - 1.  However, this
		/// color may not be defined, because the colormap may not be full.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetInRect/*"/>
		///  <param name="pix">[in] - all depths, can be cmapped</param>
		///  <param name="box">[in] - in which all pixels will be set</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSetInRect(
						Pix pix,
						Box box)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.pixSetInRect(pix.Pointer, box.Pointer);
			return _Result;
		}

		// pix2.c (1112, 1)
		// pixSetInRectArbitrary(pix, box, val) as int
		// pixSetInRectArbitrary(PIX *, BOX *, l_uint32) as l_ok
		///  <summary>
		/// (1) For colormapped pix, be sure the value is the intended
		/// one in the colormap.<para/>
		///
		/// (2) Caution: for colormapped pix, this sets each pixel in the
		/// rect to the color at the index equal to val.  Be sure that
		/// this index exists in the colormap and that it is the intended one!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetInRectArbitrary/*"/>
		///  <param name="pix">[in] - all depths can be cmapped</param>
		///  <param name="box">[in] - in which all pixels will be set to val</param>
		///  <param name="val">[in] - value to set all pixels</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetInRectArbitrary(
						Pix pix,
						Box box,
						uint val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.pixSetInRectArbitrary(pix.Pointer, box.Pointer,   val);
			return _Result;
		}

		// pix2.c (1213, 1)
		// pixBlendInRect(pixs, box, val, fract) as int
		// pixBlendInRect(PIX *, BOX *, l_uint32, l_float32) as l_ok
		///  <summary>
		/// (1) This is an in-place function.  It blends the input color %val
		/// with the pixels in pixs in the specified rectangle.
		/// If no rectangle is specified, it blends over the entire image.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBlendInRect/*"/>
		///  <param name="pixs">[in] - 32 bpp rgb</param>
		///  <param name="box">[in][optional] - in which all pixels will be blended</param>
		///  <param name="val">[in] - blend value 0xrrggbb00</param>
		///  <param name="fract">[in] - fraction of color to be blended with each pixel in pixs</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixBlendInRect(
						Pix pixs,
						Box box,
						uint val,
						Single fract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.pixBlendInRect(pixs.Pointer, boxPtr,   val,   fract);
			return _Result;
		}

		// pix2.c (1299, 1)
		// pixSetPadBits(pix, val) as int
		// pixSetPadBits(PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) The pad bits are the bits that expand each scanline to a
		/// multiple of 32 bits.  They are usually not used in
		/// image processing operations.  When boundary conditions
		/// are important, as in seedfill, they must be set properly.<para/>
		///
		/// (2) This sets the value of the pad bits (if any) in the last
		/// 32-bit word in each scanline.<para/>
		///
		/// (3) For 32 bpp pix, there are no pad bits, so this is a no-op.<para/>
		///
		/// (4) When writing formatted output, such as tiff, png or jpeg,
		/// the pad bits have no effect on the raster image that is
		/// generated by reading back from the file.  However, in some
		/// cases, the compressed file itself will depend on the pad
		/// bits.  This is seen, for example, in Windows with 2 and 4 bpp
		/// tiff-compressed images that have pad bits on each scanline.
		/// It is sometimes convenient to use a golden file with a
		/// byte-by-byte check to verify invariance.  Consequently,
		/// and because setting the pad bits is cheap, the pad bits are
		/// set to 0 before writing these compressed files.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetPadBits/*"/>
		///  <param name="pix">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
		///  <param name="val">[in] - 0 or 1</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetPadBits(
						Pix pix,
						int val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if ((new List<int> {1, 2, 4, 8, 16, 32}).Contains ((int)pix.d) == false) { throw new ArgumentException ("1, 2, 4, 8, 16, 32 bpp"); }
			int _Result = Natives.pixSetPadBits(pix.Pointer,   val);
			return _Result;
		}

		// pix2.c (1359, 1)
		// pixSetPadBitsBand(pix, by, bh, val) as int
		// pixSetPadBitsBand(PIX *, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) The pad bits are the bits that expand each scanline to a
		/// multiple of 32 bits.  They are usually not used in
		/// image processing operations.  When boundary conditions
		/// are important, as in seedfill, they must be set properly.<para/>
		///
		/// (2) This sets the value of the pad bits (if any) in the last
		/// 32-bit word in each scanline, within the specified
		/// band of raster lines.<para/>
		///
		/// (3) For 32 bpp pix, there are no pad bits, so this is a no-op.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetPadBitsBand/*"/>
		///  <param name="pix">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
		///  <param name="by">[in] - starting y value of band</param>
		///  <param name="bh">[in] - height of band</param>
		///  <param name="val">[in] - 0 or 1</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetPadBitsBand(
						Pix pix,
						int by,
						int bh,
						int val)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if ((new List<int> {1, 2, 4, 8, 16, 32}).Contains ((int)pix.d) == false) { throw new ArgumentException ("1, 2, 4, 8, 16, 32 bpp"); }
			int _Result = Natives.pixSetPadBitsBand(pix.Pointer,   by,   bh,   val);
			return _Result;
		}

		// pix2.c (1431, 1)
		// pixSetOrClearBorder(pixs, left, right, top, bot, op) as int
		// pixSetOrClearBorder(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) The border region is defined to be the region in the
		/// image within a specific distance of each edge.  Here, we
		/// allow the pixels within a specified distance of each
		/// edge to be set independently.  This either sets or
		/// clears all pixels in the border region.<para/>
		///
		/// (2) For binary images, use PIX_SET for black and PIX_CLR for white.<para/>
		///
		/// (3) For grayscale or color images, use PIX_SET for white
		/// and PIX_CLR for black.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetOrClearBorder/*"/>
		///  <param name="pixs">[in] - all depths</param>
		///  <param name="left">[in] - right, top, bot amount to set or clear</param>
		///  <param name="op">[in] - operation PIX_SET or PIX_CLR</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetOrClearBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot,
						int op)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixSetOrClearBorder(pixs.Pointer,   left,   right,   top,   bot,   op);
			return _Result;
		}

		// pix2.c (1480, 1)
		// pixSetBorderVal(pixs, left, right, top, bot, val) as int
		// pixSetBorderVal(PIX *, l_int32, l_int32, l_int32, l_int32, l_uint32) as l_ok
		///  <summary>
		/// (1) The border region is defined to be the region in the
		/// image within a specific distance of each edge.  Here, we
		/// allow the pixels within a specified distance of each
		/// edge to be set independently.  This sets the pixels
		/// in the border region to the given input value.<para/>
		///
		/// (2) For efficiency, use pixSetOrClearBorder() if
		/// you're setting the border to either black or white.<para/>
		///
		/// (3) If d != 32, the input value should be masked off
		/// to the appropriate number of least significant bits.<para/>
		///
		/// (4) The code is easily generalized for 2 or 4 bpp.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetBorderVal/*"/>
		///  <param name="pixs">[in] - 8, 16 or 32 bpp</param>
		///  <param name="left">[in] - amount to set</param>
		///  <param name="right">[in] - amount to set</param>
		///  <param name="top">[in] - amount to set</param>
		///  <param name="bot">[in] - amount to set</param>
		///  <param name="val">[in] - value to set at each border pixel</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetBorderVal(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot,
						uint val)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixSetBorderVal(pixs.Pointer,   left,   right,   top,   bot,   val);
			return _Result;
		}

		// pix2.c (1584, 1)
		// pixSetBorderRingVal(pixs, dist, val) as int
		// pixSetBorderRingVal(PIX *, l_int32, l_uint32) as l_ok
		///  <summary>
		/// (1) The rings are single-pixel-wide rectangular sets of
		/// pixels at a given distance from the edge of the pix.
		/// This sets all pixels in a given ring to a value.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetBorderRingVal/*"/>
		///  <param name="pixs">[in] - any depth cmap OK</param>
		///  <param name="dist">[in] - distance from outside must be  is greater  0 first ring is 1</param>
		///  <param name="val">[in] - value to set at each border pixel</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetBorderRingVal(
						Pix pixs,
						int dist,
						uint val)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixSetBorderRingVal(pixs.Pointer,   dist,   val);
			return _Result;
		}

		// pix2.c (1635, 1)
		// pixSetMirroredBorder(pixs, left, right, top, bot) as int
		// pixSetMirroredBorder(PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This applies what is effectively mirror boundary conditions
		/// to a border region in the image.  It is in-place.<para/>
		///
		/// (2) This is useful for setting pixels near the border to a
		/// value representative of the near pixels to the interior.<para/>
		///
		/// (3) The general pixRasterop() is used for an in-place operation here
		/// because there is no overlap between the src and dest rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetMirroredBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels to set</param>
		///  <param name="right">[in] - number of pixels to set</param>
		///  <param name="top">[in] - number of pixels to set</param>
		///  <param name="bot">[in] - number of pixels to set</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSetMirroredBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixSetMirroredBorder(pixs.Pointer,   left,   right,   top,   bot);
			return _Result;
		}

		// pix2.c (1686, 1)
		// pixCopyBorder(pixd, pixs, left, right, top, bot) as Pix
		// pixCopyBorder(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) pixd can be null, but otherwise it must be the same size
		/// and depth as pixs.  Always returns pixd.<para/>
		///
		/// (2) This is useful in situations where by setting a few border
		/// pixels we can avoid having to copy all pixels in pixs into
		/// pixd as an initialization step for some operation.
		/// Nevertheless, for safety, if making a new pixd, all the
		/// non-border pixels are initialized to 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyBorder/*"/>
		///  <param name="pixd">[in] - all depths colormap ok can be NULL</param>
		///  <param name="pixs">[in] - same depth and size as pixd</param>
		///  <param name="left">[in] - number of pixels to copy</param>
		///  <param name="right">[in] - number of pixels to copy</param>
		///  <param name="top">[in] - number of pixels to copy</param>
		///  <param name="bot">[in] - number of pixels to copy</param>
		///   <returns>pixd, or NULL on error if pixd is not defined</returns>
		public static Pix pixCopyBorder(
						Pix pixd,
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixCopyBorder(pixd.Pointer, pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1740, 1)
		// pixAddBorder(pixs, npix, val) as Pix
		// pixAddBorder(PIX *, l_int32, l_uint32) as PIX *
		///  <summary>
		/// (1) See pixGetBlackOrWhiteVal() for values of black and white pixels.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="npix">[in] - number of pixels to be added to each side</param>
		///  <param name="val">[in] - value of added border pixels</param>
		///   <returns>pixd with the added exterior pixels, or NULL on error</returns>
		public static Pix pixAddBorder(
						Pix pixs,
						int npix,
						uint val)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddBorder(pixs.Pointer,   npix,   val);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1780, 1)
		// pixAddBlackOrWhiteBorder(pixs, left, right, top, bot, op) as Pix
		// pixAddBlackOrWhiteBorder(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) See pixGetBlackOrWhiteVal() for possible side effect (adding
		/// a color to a colormap).<para/>
		///
		/// (2) The only complication is that pixs may have a colormap.
		/// There are two ways to add the black or white border:
		/// (a) As done here (simplest, most efficient)
		/// (b) l_int32 ws, hs, d
		/// pixGetDimensions(pixs, [and]ws, [and]hs, [and]d)
		/// Pix pixd = pixCreate(ws + left + right, hs + top + bot, d)
		/// PixColormap cmap = pixGetColormap(pixs)
		/// if (cmap != NULL)
		/// pixSetColormap(pixd, pixcmapCopy(cmap))
		/// pixSetBlackOrWhite(pixd, L_SET_WHITE)  // uses cmap
		/// pixRasterop(pixd, left, top, ws, hs, PIX_SET, pixs, 0, 0)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddBlackOrWhiteBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels added</param>
		///  <param name="right">[in] - number of pixels added</param>
		///  <param name="top">[in] - number of pixels added</param>
		///  <param name="bot">[in] - number of pixels added</param>
		///  <param name="op">[in] - L_GET_BLACK_VAL, L_GET_WHITE_VAL</param>
		///   <returns>pixd with the added exterior pixels, or NULL on error</returns>
		public static Pix pixAddBlackOrWhiteBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot,
						int op)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddBlackOrWhiteBorder(pixs.Pointer,   left,   right,   top,   bot,   op);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1834, 1)
		// pixAddBorderGeneral(pixs, left, right, top, bot, val) as Pix
		// pixAddBorderGeneral(PIX *, l_int32, l_int32, l_int32, l_int32, l_uint32) as PIX *
		///  <summary>
		/// (1) For binary images:
		/// white:  val = 0
		/// black:  val = 1
		/// For grayscale images:
		/// white:  val = 2  d - 1
		/// black:  val = 0
		/// For rgb color images:
		/// white:  val = 0xffffff00
		/// black:  val = 0
		/// For colormapped images, set val to the appropriate colormap index.<para/>
		///
		/// (2) If the added border is either black or white, you can use
		/// pixAddBlackOrWhiteBorder()
		/// The black and white values for all images can be found with
		/// pixGetBlackOrWhiteVal()
		/// which, if pixs is cmapped, may add an entry to the colormap.
		/// Alternatively, if pixs has a colormap, you can find the index
		/// of the pixel whose intensity is closest to white or black:
		/// white: pixcmapGetRankIntensity(cmap, 1.0, [and]index)
		/// black: pixcmapGetRankIntensity(cmap, 0.0, [and]index)
		/// and use that for val.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddBorderGeneral/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels added</param>
		///  <param name="right">[in] - number of pixels added</param>
		///  <param name="top">[in] - number of pixels added</param>
		///  <param name="bot">[in] - number of pixels added</param>
		///  <param name="val">[in] - value of added border pixels</param>
		///   <returns>pixd with the added exterior pixels, or NULL on error</returns>
		public static Pix pixAddBorderGeneral(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot,
						uint val)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddBorderGeneral(pixs.Pointer,   left,   right,   top,   bot,   val);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1889, 1)
		// pixRemoveBorder(pixs, npix) as Pix
		// pixRemoveBorder(PIX *, l_int32) as PIX *
		///  <summary>
		/// pixRemoveBorder()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="npix">[in] - number to be removed from each of the 4 sides</param>
		///   <returns>pixd with pixels removed around border, or NULL on error</returns>
		public static Pix pixRemoveBorder(
						Pix pixs,
						int npix)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRemoveBorder(pixs.Pointer,   npix);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1910, 1)
		// pixRemoveBorderGeneral(pixs, left, right, top, bot) as Pix
		// pixRemoveBorderGeneral(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// pixRemoveBorderGeneral()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveBorderGeneral/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels removed</param>
		///  <param name="right">[in] - number of pixels removed</param>
		///  <param name="top">[in] - number of pixels removed</param>
		///  <param name="bot">[in] - number of pixels removed</param>
		///   <returns>pixd with pixels removed around border, or NULL on error</returns>
		public static Pix pixRemoveBorderGeneral(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRemoveBorderGeneral(pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (1963, 1)
		// pixRemoveBorderToSize(pixs, wd, hd) as Pix
		// pixRemoveBorderToSize(PIX *, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) Removes pixels as evenly as possible from the sides of the
		/// image, leaving the central part.<para/>
		///
		/// (2) Returns clone if no pixels requested removed, or the target
		/// sizes are larger than the image.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRemoveBorderToSize/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="wd">[in] - target width use 0 if only removing from height</param>
		///  <param name="hd">[in] - target height use 0 if only removing from width</param>
		///   <returns>pixd with pixels removed around border, or NULL on error</returns>
		public static Pix pixRemoveBorderToSize(
						Pix pixs,
						int wd,
						int hd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRemoveBorderToSize(pixs.Pointer,   wd,   hd);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2018, 1)
		// pixAddMirroredBorder(pixs, left, right, top, bot) as Pix
		// pixAddMirroredBorder(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This applies what is effectively mirror boundary conditions.
		/// For the added border pixels in pixd, the pixels in pixs
		/// near the border are mirror-copied into the border region.<para/>
		///
		/// (2) This is useful for avoiding special operations near
		/// boundaries when doing image processing operations
		/// such as rank filters and convolution.  In use, one first
		/// adds mirrored pixels to each side of the image.  The number
		/// of pixels added on each side is half the filter dimension.
		/// Then the image processing operations proceed over a
		/// region equal to the size of the original image, and
		/// write directly into a dest pix of the same size as pixs.<para/>
		///
		/// (3) The general pixRasterop() is used for an in-place operation here
		/// because there is no overlap between the src and dest rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddMirroredBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels added</param>
		///  <param name="right">[in] - number of pixels added</param>
		///  <param name="top">[in] - number of pixels added</param>
		///  <param name="bot">[in] - number of pixels added</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixAddMirroredBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddMirroredBorder(pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2071, 1)
		// pixAddRepeatedBorder(pixs, left, right, top, bot) as Pix
		// pixAddRepeatedBorder(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This applies a repeated border, as if the central part of
		/// the image is tiled over the plane.  So, for example, the
		/// pixels in the left border come from the right side of the image.<para/>
		///
		/// (2) The general pixRasterop() is used for an in-place operation here
		/// because there is no overlap between the src and dest rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddRepeatedBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels added</param>
		///  <param name="right">[in] - number of pixels added</param>
		///  <param name="top">[in] - number of pixels added</param>
		///  <param name="bot">[in] - number of pixels added</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixAddRepeatedBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddRepeatedBorder(pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2127, 1)
		// pixAddMixedBorder(pixs, left, right, top, bot) as Pix
		// pixAddMixedBorder(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This applies mirrored boundary conditions horizontally
		/// and repeated b.c. vertically.<para/>
		///
		/// (2) It is specifically used for avoiding special operations
		/// near boundaries when convolving a hue-saturation histogram
		/// with a given window size.  The repeated b.c. are used
		/// vertically for hue, and the mirrored b.c. are used
		/// horizontally for saturation.  The number of pixels added
		/// on each side is approximately (but not quite) half the
		/// filter dimension.  The image processing operations can
		/// then proceed over a region equal to the size of the original
		/// image, and write directly into a dest pix of the same
		/// size as pixs.<para/>
		///
		/// (3) The general pixRasterop() can be used for an in-place
		/// operation here because there is no overlap between the
		/// src and dest rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddMixedBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - number of pixels added</param>
		///  <param name="right">[in] - number of pixels added</param>
		///  <param name="top">[in] - number of pixels added</param>
		///  <param name="bot">[in] - number of pixels added</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixAddMixedBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddMixedBorder(pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2174, 1)
		// pixAddContinuedBorder(pixs, left, right, top, bot) as Pix
		// pixAddContinuedBorder(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This adds pixels on each side whose values are equal to
		/// the value on the closest boundary pixel.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddContinuedBorder/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="left">[in] - pixels on each side to be added</param>
		///  <param name="right">[in] - pixels on each side to be added</param>
		///  <param name="top">[in] - pixels on each side to be added</param>
		///  <param name="bot">[in] - pixels on each side to be added</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixAddContinuedBorder(
						Pix pixs,
						int left,
						int right,
						int top,
						int bot)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAddContinuedBorder(pixs.Pointer,   left,   right,   top,   bot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2217, 1)
		// pixShiftAndTransferAlpha(pixd, pixs, shiftx, shifty) as int
		// pixShiftAndTransferAlpha(PIX *, PIX *, l_float32, l_float32) as l_ok
		///  <summary>
		/// pixShiftAndTransferAlpha()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixShiftAndTransferAlpha/*"/>
		///  <param name="pixd">[in] - 32 bpp</param>
		///  <param name="pixs">[in] - 32 bpp</param>
		///  <param name="shiftx">[in] - </param>
		///  <param name="shifty">[in] - </param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixShiftAndTransferAlpha(
						Pix pixd,
						Pix pixs,
						Single shiftx,
						Single shifty)
		{
			if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixShiftAndTransferAlpha(pixd.Pointer, pixs.Pointer,   shiftx,   shifty);
			return _Result;
		}

		// pix2.c (2268, 1)
		// pixDisplayLayersRGBA(pixs, val, maxw) as Pix
		// pixDisplayLayersRGBA(PIX *, l_uint32, l_int32) as PIX *
		///  <summary>
		/// (1) Use %val == 0xffffff00 for white background.<para/>
		///
		/// (2) Three views are given:
		/// ~ the image with a fully opaque alpha
		/// ~ the alpha layer
		/// ~ the image as it would appear with a white background.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDisplayLayersRGBA/*"/>
		///  <param name="pixs">[in] - cmap or 32 bpp rgba</param>
		///  <param name="val">[in] - 32 bit unsigned color to use as background</param>
		///  <param name="maxw">[in] - max output image width 0 for no scaling</param>
		///   <returns>pixd showing various image views, or NULL on error</returns>
		public static Pix pixDisplayLayersRGBA(
						Pix pixs,
						uint val,
						int maxw)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixDisplayLayersRGBA(pixs.Pointer,   val,   maxw);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2340, 1)
		// pixCreateRGBImage(pixr, pixg, pixb) as Pix
		// pixCreateRGBImage(PIX *, PIX *, PIX *) as PIX *
		///  <summary>
		/// (1) the 4th byte, sometimes called the "alpha channel",
		/// and which is often used for blending between different
		/// images, is left with 0 value.<para/>
		///
		/// (2) see Note (4) in pix.h for details on storage of
		/// 8-bit samples within each 32-bit word.<para/>
		///
		/// (3) This implementation, setting the r, g and b components
		/// sequentially, is much faster than setting them in parallel
		/// by constructing an RGB dest pixel and writing it to dest.
		/// The reason is there are many more cache misses when reading
		/// from 3 input images simultaneously.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateRGBImage/*"/>
		///  <param name="pixr">[in] - 8 bpp red pix</param>
		///  <param name="pixg">[in] - 8 bpp green pix</param>
		///  <param name="pixb">[in] - 8 bpp blue pix</param>
		///   <returns>32 bpp pix, interleaved with 4 samples/pixel, or NULL on error</returns>
		public static Pix pixCreateRGBImage(
						Pix pixr,
						Pix pixg,
						Pix pixb)
		{
			if (pixr == null) {throw new ArgumentNullException  ("pixr cannot be Nothing");}

			if (pixg == null) {throw new ArgumentNullException  ("pixg cannot be Nothing");}

			if (pixb == null) {throw new ArgumentNullException  ("pixb cannot be Nothing");}

			IntPtr _Result = Natives.pixCreateRGBImage(pixr.Pointer, pixg.Pointer, pixb.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2396, 1)
		// pixGetRGBComponent(pixs, comp) as Pix
		// pixGetRGBComponent(PIX *, l_int32) as PIX *
		///  <summary>
		/// (1) Three calls to this function generate the r, g and b 8 bpp
		/// component images.  This is much faster than generating the
		/// three images in parallel, by extracting a src pixel and setting
		/// the pixels of each component image from it.  The reason is
		/// there are many more cache misses when writing to three
		/// output images simultaneously.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRGBComponent/*"/>
		///  <param name="pixs">[in] - 32 bpp, or colormapped</param>
		///  <param name="comp">[in] - one of {COLOR_RED, COLOR_GREEN, COLOR_BLUE, L_ALPHA_CHANNEL}</param>
		///   <returns>pixd the selected 8 bpp component image of the input 32 bpp image or NULL on error</returns>
		public static Pix pixGetRGBComponent(
						Pix pixs,
						int comp)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixGetRGBComponent(pixs.Pointer,   comp);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2455, 1)
		// pixSetRGBComponent(pixd, pixs, comp) as int
		// pixSetRGBComponent(PIX *, PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) This places the 8 bpp pixel in pixs into the
		/// specified component (properly interleaved) in pixd,<para/>
		///
		/// (2) The two images are registered to the UL corner the sizes
		/// need not be the same, but a warning is issued if they differ.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetRGBComponent/*"/>
		///  <param name="pixd">[in] - 32 bpp</param>
		///  <param name="pixs">[in] - 8 bpp</param>
		///  <param name="comp">[in] - one of the set: {COLOR_RED, COLOR_GREEN, COLOR_BLUE, L_ALPHA_CHANNEL}</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixSetRGBComponent(
						Pix pixd,
						Pix pixs,
						int comp)
		{
			if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
			int _Result = Natives.pixSetRGBComponent(pixd.Pointer, pixs.Pointer,   comp);
			return _Result;
		}

		// pix2.c (2517, 1)
		// pixGetRGBComponentCmap(pixs, comp) as Pix
		// pixGetRGBComponentCmap(PIX *, l_int32) as PIX *
		///  <summary>
		/// (1) In leptonica, we do not support alpha in colormaps.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRGBComponentCmap/*"/>
		///  <param name="pixs">[in] - colormapped</param>
		///  <param name="comp">[in] - one of the set: {COLOR_RED, COLOR_GREEN, COLOR_BLUE}</param>
		///   <returns>pixd  the selected 8 bpp component image of the input cmapped image, or NULL on error</returns>
		public static Pix pixGetRGBComponentCmap(
						Pix pixs,
						int comp)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixGetRGBComponentCmap(pixs.Pointer,   comp);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2602, 1)
		// pixCopyRGBComponent(pixd, pixs, comp) as int
		// pixCopyRGBComponent(PIX *, PIX *, l_int32) as l_ok
		///  <summary>
		/// (1) The two images are registered to the UL corner.  The sizes
		/// are usually the same, and a warning is issued if they differ.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopyRGBComponent/*"/>
		///  <param name="pixd">[in] - 32 bpp</param>
		///  <param name="pixs">[in] - 32 bpp</param>
		///  <param name="comp">[in] - one of the set: {COLOR_RED, COLOR_GREEN, COLOR_BLUE, L_ALPHA_CHANNEL}</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixCopyRGBComponent(
						Pix pixd,
						Pix pixs,
						int comp)
		{
			if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixCopyRGBComponent(pixd.Pointer, pixs.Pointer,   comp);
			return _Result;
		}

		// pix2.c (2663, 1)
		// composeRGBPixel(rval, gval, bval, ppixel) as int
		// composeRGBPixel(l_int32, l_int32, l_int32, l_uint32 *) as l_ok
		///  <summary>
		/// (1) All channels are 8 bits: the input values must be between
		/// 0 and 255.  For speed, this is not enforced by masking
		/// with 0xff before shifting.<para/>
		///
		/// (2) A slower implementation uses macros:
		/// SET_DATA_BYTE(ppixel, COLOR_RED, rval)
		/// SET_DATA_BYTE(ppixel, COLOR_GREEN, gval)
		/// SET_DATA_BYTE(ppixel, COLOR_BLUE, bval)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/composeRGBPixel/*"/>
		///  <param name="rval">[in] - </param>
		///  <param name="gval">[in] - </param>
		///  <param name="bval">[in] - </param>
		///  <param name="ppixel">[out] - 32-bit pixel</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int composeRGBPixel(
						int rval,
						int gval,
						int bval,
						out uint ppixel)
		{
			int _Result = Natives.composeRGBPixel(  rval,   gval,   bval, out  ppixel);
			return _Result;
		}

		// pix2.c (2694, 1)
		// composeRGBAPixel(rval, gval, bval, aval, ppixel) as int
		// composeRGBAPixel(l_int32, l_int32, l_int32, l_int32, l_uint32 *) as l_ok
		///  <summary>
		/// (1) All channels are 8 bits: the input values must be between
		/// 0 and 255.  For speed, this is not enforced by masking
		/// with 0xff before shifting.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/composeRGBAPixel/*"/>
		///  <param name="rval">[in] - </param>
		///  <param name="gval">[in] - </param>
		///  <param name="bval">[in] - </param>
		///  <param name="aval">[in] - </param>
		///  <param name="ppixel">[out] - 32-bit pixel</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int composeRGBAPixel(
						int rval,
						int gval,
						int bval,
						int aval,
						out uint ppixel)
		{
			int _Result = Natives.composeRGBAPixel(  rval,   gval,   bval,   aval, out  ppixel);
			return _Result;
		}

		// pix2.c (2729, 1)
		// extractRGBValues(pixel, prval, pgval, pbval) as Object
		// extractRGBValues(l_uint32, l_int32 *, l_int32 *, l_int32 *) as void
		///  <summary>
		/// (1) A slower implementation uses macros:
		/// prval = GET_DATA_BYTE([and]pixel, COLOR_RED)
		/// pgval = GET_DATA_BYTE([and]pixel, COLOR_GREEN)
		/// pbval = GET_DATA_BYTE([and]pixel, COLOR_BLUE)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractRGBValues/*"/>
		///  <param name="pixel">[in] - 32 bit</param>
		///  <param name="prval">[out][optional] - red component</param>
		///  <param name="pgval">[out][optional] - green component</param>
		///  <param name="pbval">[out][optional] - blue component</param>
		public static void extractRGBValues(
						uint pixel,
						out int prval,
						out int pgval,
						out int pbval)
		{
			Natives.extractRGBValues(  pixel, out  prval, out  pgval, out  pbval);
		}

		// pix2.c (2752, 1)
		// extractRGBAValues(pixel, prval, pgval, pbval, paval) as Object
		// extractRGBAValues(l_uint32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as void
		///  <summary>
		/// extractRGBAValues()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractRGBAValues/*"/>
		///  <param name="pixel">[in] - 32 bit</param>
		///  <param name="prval">[out][optional] - red component</param>
		///  <param name="pgval">[out][optional] - green component</param>
		///  <param name="pbval">[out][optional] - blue component</param>
		///  <param name="paval">[out][optional] - alpha component</param>
		public static void extractRGBAValues(
						uint pixel,
						out int prval,
						out int pgval,
						out int pbval,
						out int paval)
		{
			Natives.extractRGBAValues(  pixel, out  prval, out  pgval, out  pbval, out  paval);
		}

		// pix2.c (2774, 1)
		// extractMinMaxComponent(pixel, type) as int
		// extractMinMaxComponent(l_uint32, l_int32) as l_int32
		///  <summary>
		/// extractMinMaxComponent()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractMinMaxComponent/*"/>
		///  <param name="pixel">[in] - 32 bpp RGB</param>
		///  <param name="type">[in] - L_CHOOSE_MIN or L_CHOOSE_MAX</param>
		///   <returns>component in range [0 ... 255], or NULL on error</returns>
		public static int extractMinMaxComponent(
						uint pixel,
						int type)
		{
			int _Result = Natives.extractMinMaxComponent(  pixel,   type);
			return _Result;
		}

		// pix2.c (2808, 1)
		// pixGetRGBLine(pixs, row, bufr, bufg, bufb) as int
		// pixGetRGBLine(PIX *, l_int32, l_uint8 *, l_uint8 *, l_uint8 *) as l_ok
		///  <summary>
		/// (1) This puts rgb components from the input line in pixs
		/// into the given buffers.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRGBLine/*"/>
		///  <param name="pixs">[in] - 32 bpp</param>
		///  <param name="row">[in] - </param>
		///  <param name="bufr">[in] - array of red samples size w bytes</param>
		///  <param name="bufg">[in] - array of green samples size w bytes</param>
		///  <param name="bufb">[in] - array of blue samples size w bytes</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixGetRGBLine(
						Pix pixs,
						int row,
						Byte[] bufr,
						Byte[] bufg,
						Byte[] bufb)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (bufr == null) {throw new ArgumentNullException  ("bufr cannot be Nothing");}

			if (bufg == null) {throw new ArgumentNullException  ("bufg cannot be Nothing");}

			if (bufb == null) {throw new ArgumentNullException  ("bufb cannot be Nothing");}

			int _Result = Natives.pixGetRGBLine(pixs.Pointer,   row,   bufr,   bufg,   bufb);
			return _Result;
		}

		// pix2.c (2871, 1)
		// pixEndianByteSwapNew(pixs) as Pix
		// pixEndianByteSwapNew(PIX *) as PIX *
		///  <summary>
		/// (1) This is used to convert the data in a pix to a
		/// serialized byte buffer in raster order, and, for RGB,
		/// in order RGBA.  This requires flipping bytes within
		/// each 32-bit word for little-endian platforms, because the
		/// words have a MSB-to-the-left rule, whereas byte raster-order
		/// requires the left-most byte in each word to be byte 0.
		/// For big-endians, no swap is necessary, so this returns a clone.<para/>
		///
		/// (2) Unlike pixEndianByteSwap(), which swaps the bytes in-place,
		/// this returns a new pix (or a clone).  We provide this
		/// because often when serialization is done, the source
		/// pix needs to be restored to canonical little-endian order,
		/// and this requires a second byte swap.  In such a situation,
		/// it is twice as fast to make a new pix in big-endian order,
		/// use it, and destroy it.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEndianByteSwapNew/*"/>
		///  <param name="pixs">[in] - </param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixEndianByteSwapNew(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixEndianByteSwapNew(pixs.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (2934, 1)
		// pixEndianByteSwap(pixs) as int
		// pixEndianByteSwap(PIX *) as l_ok
		///  <summary>
		/// (1) This is used on little-endian platforms to swap
		/// the bytes within a word bytes 0 and 3 are swapped,
		/// and bytes 1 and 2 are swapped.<para/>
		///
		/// (2) This is required for little-endians in situations
		/// where we convert from a serialized byte order that is
		/// in raster order, as one typically has in file formats,
		/// to one with MSB-to-the-left in each 32-bit word, or v.v.
		/// See pix.h for a description of the canonical format
		/// (MSB-to-the left) that is used for both little-endian
		/// and big-endian platforms. For big-endians, the
		/// MSB-to-the-left word order has the bytes in raster
		/// order when serialized, so no byte flipping is required.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEndianByteSwap/*"/>
		///  <param name="pixs">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixEndianByteSwap(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixEndianByteSwap(pixs.Pointer);
			return _Result;
		}

		// pix2.c (2992, 1)
		// lineEndianByteSwap(datad, datas, wpl) as int
		// lineEndianByteSwap(l_uint32 *, l_uint32 *, l_int32) as l_int32
		///  <summary>
		/// (1) This is used on little-endian platforms to swap
		/// the bytes within each word in the line of image data.
		/// Bytes 0 smaller or equal= is greater  3 and 1 smaller or equal= is greater  2 are swapped in the dest
		/// byte array data8d, relative to the pix data in datas.<para/>
		///
		/// (2) The bytes represent 8 bit pixel values.  They are swapped
		/// for little endians so that when the dest array datad
		/// is addressed by bytes, the pixels are chosen sequentially
		/// from left to right in the image.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lineEndianByteSwap/*"/>
		///  <param name="datad">[in] - dest byte array data, reordered on little-endians</param>
		///  <param name="datas">[in] - a src line of pix data)</param>
		///  <param name="wpl">[in] - number of 32 bit words in the line</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lineEndianByteSwap(
						Byte[] datad,
						Byte[] datas,
						int wpl)
		{
			if (datad == null) {throw new ArgumentNullException  ("datad cannot be Nothing");}

			if (datas == null) {throw new ArgumentNullException  ("datas cannot be Nothing");}

			IntPtr datadPtr = 	Marshal.AllocHGlobal(datad.Length);
			Marshal.Copy(datad, 0, datadPtr, datad.Length);
			IntPtr datasPtr = 	Marshal.AllocHGlobal(datas.Length);
			Marshal.Copy(datas, 0, datasPtr, datas.Length);
			int _Result = Natives.lineEndianByteSwap(  datadPtr,   datasPtr,   wpl);
			Marshal.FreeHGlobal(datadPtr);
			Marshal.FreeHGlobal(datasPtr);
			return _Result;
		}

		// pix2.c (3045, 1)
		// pixEndianTwoByteSwapNew(pixs) as Pix
		// pixEndianTwoByteSwapNew(PIX *) as PIX *
		///  <summary>
		/// (1) This is used on little-endian platforms to swap the
		/// 2-byte entities within a 32-bit word.<para/>
		///
		/// (2) This is equivalent to a full byte swap, as performed
		/// by pixEndianByteSwap(), followed by byte swaps in
		/// each of the 16-bit entities separately.<para/>
		///
		/// (3) Unlike pixEndianTwoByteSwap(), which swaps the shorts in-place,
		/// this returns a new pix (or a clone).  We provide this
		/// to avoid having to swap twice in situations where the input
		/// pix must be restored to canonical little-endian order.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEndianTwoByteSwapNew/*"/>
		///  <param name="pixs">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static Pix pixEndianTwoByteSwapNew(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixEndianTwoByteSwapNew(pixs.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix2.c (3098, 1)
		// pixEndianTwoByteSwap(pixs) as int
		// pixEndianTwoByteSwap(PIX *) as l_ok
		///  <summary>
		/// (1) This is used on little-endian platforms to swap the
		/// 2-byte entities within a 32-bit word.<para/>
		///
		/// (2) This is equivalent to a full byte swap, as performed
		/// by pixEndianByteSwap(), followed by byte swaps in
		/// each of the 16-bit entities separately.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixEndianTwoByteSwap/*"/>
		///  <param name="pixs">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixEndianTwoByteSwap(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			int _Result = Natives.pixEndianTwoByteSwap(pixs.Pointer);
			return _Result;
		}

		// pix2.c (3152, 1)
		// pixGetRasterData(pixs, pdata, pnbytes) as int
		// pixGetRasterData(PIX *, l_uint8 **, size_t *) as l_ok
		///  <summary>
		/// (1) This returns the raster data as a byte string, padded to the
		/// byte.  For 1 bpp, the first pixel is the MSbit in the first byte.
		/// For rgb, the bytes are in (rgb) order.  This is the format
		/// required for flate encoding of pixels in a PostScript file.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRasterData/*"/>
		///  <param name="pixs">[in] - 1, 8, 32 bpp</param>
		///  <param name="pdata">[out] - raster data in memory</param>
		///  <param name="pnbytes">[out] - number of bytes in data string</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixGetRasterData(
						Pix pixs,
						out Byte[] pdata,
						out uint pnbytes)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1, 8, 32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1, 8, 32 bpp"); }
			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.pixGetRasterData(pixs.Pointer, out  pdataPtr, out  pnbytes);
			Byte[] pdataGen = new Byte[pnbytes];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// pix2.c (3226, 1)
		// pixAlphaIsOpaque(pix, popaque) as int
		// pixAlphaIsOpaque(PIX *, l_int32 *) as l_ok
		///  <summary>
		/// pixAlphaIsOpaque()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAlphaIsOpaque/*"/>
		///  <param name="pix">[in] - 32 bpp, spp == 4</param>
		///  <param name="popaque">[out] - 1 if spp == 4 and all alpha component values are 255 (opaque) 0 otherwise</param>
		///   <returns>0 if OK, 1 on error Notes: 1) On error, opaque is returned as 0 (FALSE).</returns>
		public static int pixAlphaIsOpaque(
						Pix pix,
						out int popaque)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixAlphaIsOpaque(pix.Pointer, out  popaque);
			return _Result;
		}

		// pix2.c (3291, 1)
		// pixSetupByteProcessing(pix, pw, ph) as List<byte[]>
		// pixSetupByteProcessing(PIX *, l_int32 *, l_int32 *) as l_uint8 **
		///  <summary>
		/// (1) This is a simple helper for processing 8 bpp images with
		/// direct byte access.  It can swap byte order within each word.<para/>
		///
		/// (2) After processing, you must call pixCleanupByteProcessing(),
		/// which frees the lineptr array and restores byte order.<para/>
		///
		/// (3) Usage:
		/// l_uint8 lineptrs = pixSetupByteProcessing(pix, [and]w, [and]h)
		/// for (i = 0 i  is smaller h i++) {
		/// l_uint8 line = lineptrs[i]
		/// for (j = 0 j  is smaller w j++) {
		/// val = line[j]
		/// ...
		/// }
		/// }
		/// pixCleanupByteProcessing(pix, lineptrs)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetupByteProcessing/*"/>
		///  <param name="pix">[in] - 8 bpp, no colormap</param>
		///  <param name="pw">[out][optional] - width</param>
		///  <param name="ph">[out][optional] - height</param>
		///   <returns>line ptr array, or NULL on error</returns>
		public static List<byte[]> pixSetupByteProcessing(
						Pix pix,
						out int pw,
						out int ph)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr _Result = Natives.pixSetupByteProcessing(pix.Pointer, out  pw, out  ph);
			// Todo: Functions.cs:GenerateSecureOut:List_Integer
			List<Byte[]> B = null;
			return B;
		}

		// pix2.c (3329, 1)
		// pixCleanupByteProcessing(pix, lineptrs) as int
		// pixCleanupByteProcessing(PIX *, l_uint8 **) as l_ok
		///  <summary>
		/// (1) This must be called after processing that was initiated
		/// by pixSetupByteProcessing() has finished.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCleanupByteProcessing/*"/>
		///  <param name="pix">[in] - 8 bpp, no colormap</param>
		///  <param name="lineptrs">[in] - ptrs to the beginning of each raster line of data</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixCleanupByteProcessing(
						Pix pix,
						List<byte[]> lineptrs)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			if (lineptrs == null) {throw new ArgumentNullException  ("lineptrs cannot be Nothing");}

			IntPtr lineptrsPtr = 	Marshal.AllocHGlobal(0);
			int _Result = Natives.pixCleanupByteProcessing(pix.Pointer,   lineptrsPtr);
			Marshal.FreeHGlobal(lineptrsPtr);
			return _Result;
		}

		// pix2.c (3371, 1)
		// l_setAlphaMaskBorder(val1, val2) as Object
		// l_setAlphaMaskBorder(l_float32, l_float32) as void
		///  <summary>
		/// (1) This sets the opacity values used to generate the two outer
		/// boundary rings in the alpha mask associated with geometric
		/// transforms such as pixRotateWithAlpha().<para/>
		///
		/// (2) The default values are val1 = 0.0 (completely transparent
		/// in the outermost ring) and val2 = 0.5 (half transparent
		/// in the second ring).  When the image is blended, this
		/// completely removes the outer ring (shrinking the image by
		/// 2 in each direction), and alpha-blends with 0.5 the second ring.
		/// Using val1 = 0.25 and val2 = 0.75 gives a slightly more
		/// blurred border, with no perceptual difference at screen resolution.<para/>
		///
		/// (3) The actual mask values are found by multiplying these
		/// normalized opacity values by 255.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setAlphaMaskBorder/*"/>
		///  <param name="val1">[in] - in [0.0 ... 1.0]</param>
		///  <param name="val2">[in] - in [0.0 ... 1.0]</param>
		public static void l_setAlphaMaskBorder(
						Single val1,
						Single val2)
		{
			Natives.l_setAlphaMaskBorder(  val1,   val2);
		}


	}
}
