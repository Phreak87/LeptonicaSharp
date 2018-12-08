using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// conncomp.c (144, 1)
		// pixConnComp(pixs, ppixa, connectivity) as Boxa
		// pixConnComp(PIX *, PIXA **, l_int32) as BOXA *
		///  <summary>
		/// (1) This is the top-level call for getting bounding boxes or
		/// a pixa of the components, and it can be used instead
		/// of either pixConnCompBB() or pixConnCompPixa(), rsp.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConnComp/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="ppixa">[out][optional] - pixa of each c.c.</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa pixConnComp(
						Pix pixs,
						out Pixa ppixa,
						int connectivity)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr ppixaPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixConnComp(pixs.Pointer, out ppixaPtr,   connectivity);
			if (ppixaPtr == IntPtr.Zero) {ppixa = null;} else { ppixa = new Pixa(ppixaPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// conncomp.c (190, 1)
		// pixConnCompPixa(pixs, ppixa, connectivity) as Boxa
		// pixConnCompPixa(PIX *, PIXA **, l_int32) as BOXA *
		///  <summary>
		/// (1) This finds bounding boxes of 4- or 8-connected components
		/// in a binary image, and saves images of each c.c
		/// in a pixa array.<para/>
		///
		/// (2) It sets up 2 temporary pix, and for each c.c. that is
		/// located in raster order, it erases the c.c. from one pix,
		/// then uses the b.b. to extract the c.c. from the two pix using
		/// an XOR, and finally erases the c.c. from the second pix.<para/>
		///
		/// (3) A clone of the returned boxa (where all boxes in the array
		/// are clones) is inserted into the pixa.<para/>
		///
		/// (4) If the input is valid, this always returns a boxa and a pixa.
		/// If pixs is empty, the boxa and pixa will be empty.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConnCompPixa/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="ppixa">[out] - pixa of each c.c.</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa pixConnCompPixa(
						Pix pixs,
						out Pixa ppixa,
						int connectivity)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr ppixaPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixConnCompPixa(pixs.Pointer, out ppixaPtr,   connectivity);
			if (ppixaPtr == IntPtr.Zero) {ppixa = null;} else { ppixa = new Pixa(ppixaPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// conncomp.c (304, 1)
		// pixConnCompBB(pixs, connectivity) as Boxa
		// pixConnCompBB(PIX *, l_int32) as BOXA *
		///  <summary>
		/// (1) Finds bounding boxes of 4- or 8-connected components
		/// in a binary image.<para/>
		///
		/// (2) This works on a copy of the input pix.  The c.c. are located
		/// in raster order and erased one at a time.  In the process,
		/// the b.b. is computed and saved.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConnCompBB/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa pixConnCompBB(
						Pix pixs,
						int connectivity)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixConnCompBB(pixs.Pointer,   connectivity);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// conncomp.c (387, 1)
		// pixCountConnComp(pixs, connectivity, pcount) as int
		// pixCountConnComp(PIX *, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// pixCountConnComp()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCountConnComp/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///  <param name="pcount">[out] - </param>
		///   <returns>0 if OK, 1 on error Notes: (1 This is the top-level call for getting the number of 4- or 8-connected components in a 1 bpp image. 2 It works on a copy of the input pix.  The c.c. are located in raster order and erased one at a time.</returns>
		public static int pixCountConnComp(
						Pix pixs,
						int connectivity,
						out int pcount)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixCountConnComp(pixs.Pointer,   connectivity, out  pcount);
			return _Result;
		}

		// conncomp.c (449, 1)
		// nextOnPixelInRaster(pixs, xstart, ystart, px, py) as int
		// nextOnPixelInRaster(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
		///  <summary>
		/// nextOnPixelInRaster()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/nextOnPixelInRaster/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="xstart">[in] - starting point for search</param>
		///  <param name="ystart">[in] - starting point for search</param>
		///  <param name="px">[out] - coord value of next ON pixel</param>
		///  <param name="py">[out] - coord value of next ON pixel</param>
		///   <returns>1 if a pixel is found 0 otherwise or on error</returns>
		public static int nextOnPixelInRaster(
						Pix pixs,
						int xstart,
						int ystart,
						out int px,
						out int py)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.nextOnPixelInRaster(pixs.Pointer,   xstart,   ystart, out  px, out  py);
			return _Result;
		}

		// conncomp.c (483, 1)
		// nextOnPixelInRasterLow(data, w, h, wpl, xstart, ystart, px, py) as int
		// nextOnPixelInRasterLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
		///  <summary>
		/// nextOnPixelInRasterLow()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/nextOnPixelInRasterLow/*"/>
		///  <param name="data">[in] - pix data</param>
		///  <param name="w">[in] - width and height</param>
		///  <param name="h">[in] - width and height</param>
		///  <param name="wpl">[in] - words per line</param>
		///  <param name="xstart">[in] - starting point for search</param>
		///  <param name="ystart">[in] - starting point for search</param>
		///  <param name="px">[out] - coord value of next ON pixel</param>
		///  <param name="py">[out] - coord value of next ON pixel</param>
		///   <returns>1 if a pixel is found 0 otherwise or on error</returns>
		public static int nextOnPixelInRasterLow(
						Byte[] data,
						int w,
						int h,
						int wpl,
						int xstart,
						int ystart,
						out int px,
						out int py)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr dataPtr = 	Marshal.AllocHGlobal(data.Length);
			Marshal.Copy(data, 0, dataPtr, data.Length);
			int _Result = Natives.nextOnPixelInRasterLow(  dataPtr,   w,   h,   wpl,   xstart,   ystart, out  px, out  py);
			Marshal.FreeHGlobal(dataPtr);
			return _Result;
		}

		// conncomp.c (560, 1)
		// pixSeedfillBB(pixs, stack, x, y, connectivity) as Box
		// pixSeedfillBB(PIX *, L_STACK *, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This is the high-level interface to Paul Heckbert's
		/// stack-based seedfill algorithm.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfillBB/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///   <returns>box or NULL on error</returns>
		public static Box pixSeedfillBB(
						Pix pixs,
						L_Stack stack,
						int x,
						int y,
						int connectivity)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixSeedfillBB(pixs.Pointer, stack.Pointer,   x,   y,   connectivity);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// conncomp.c (623, 1)
		// pixSeedfill4BB(pixs, stack, x, y) as Box
		// pixSeedfill4BB(PIX *, L_STACK *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This is Paul Heckbert's stack-based 4-cc seedfill algorithm.<para/>
		///
		/// (2) This operates on the input 1 bpp pix to remove the fg seed
		/// pixel, at (x,y), and all pixels that are 4-connected to it.
		/// The seed pixel at (x,y) must initially be ON.<para/>
		///
		/// (3) Returns the bounding box of the erased 4-cc component.<para/>
		///
		/// (4) Reference: see Paul Heckbert's stack-based seed fill algorithm
		/// in "Graphic Gems", ed. Andrew Glassner, Academic
		/// Press, 1990.  The algorithm description is given
		/// on pp. 275-277 working C code is on pp. 721-722.)
		/// The code here follows Heckbert's exactly, except
		/// we use function calls instead of macros for
		/// pushing data on and popping data off the stack.
		/// This makes sense to do because Heckbert's fixed-size
		/// stack with macros is dangerous: images exist that
		/// will overrun the stack and crash. The stack utility
		/// here grows dynamically as needed, and the fillseg
		/// structures that are not in use are stored in another
		/// stack for reuse.  It should be noted that the
		/// overhead in the function calls (vs. macros) is negligible.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfill4BB/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///   <returns>box or NULL on error.</returns>
		public static Box pixSeedfill4BB(
						Pix pixs,
						L_Stack stack,
						int x,
						int y)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixSeedfill4BB(pixs.Pointer, stack.Pointer,   x,   y);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// conncomp.c (738, 1)
		// pixSeedfill8BB(pixs, stack, x, y) as Box
		// pixSeedfill8BB(PIX *, L_STACK *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This is Paul Heckbert's stack-based 8-cc seedfill algorithm.<para/>
		///
		/// (2) This operates on the input 1 bpp pix to remove the fg seed
		/// pixel, at (x,y), and all pixels that are 8-connected to it.
		/// The seed pixel at (x,y) must initially be ON.<para/>
		///
		/// (3) Returns the bounding box of the erased 8-cc component.<para/>
		///
		/// (4) Reference: see Paul Heckbert's stack-based seed fill algorithm
		/// in "Graphic Gems", ed. Andrew Glassner, Academic
		/// Press, 1990.  The algorithm description is given
		/// on pp. 275-277 working C code is on pp. 721-722.)
		/// The code here follows Heckbert's closely, except
		/// the leak checks are changed for 8 connectivity.
		/// See comments on pixSeedfill4BB() for more details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfill8BB/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///   <returns>box or NULL on error.</returns>
		public static Box pixSeedfill8BB(
						Pix pixs,
						L_Stack stack,
						int x,
						int y)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixSeedfill8BB(pixs.Pointer, stack.Pointer,   x,   y);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// conncomp.c (844, 1)
		// pixSeedfill(pixs, stack, x, y, connectivity) as int
		// pixSeedfill(PIX *, L_STACK *, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This removes the component from pixs with a fg pixel at (x,y).<para/>
		///
		/// (2) See pixSeedfill4() and pixSeedfill8() for details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfill/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///  <param name="connectivity">[in] - 4 or 8</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSeedfill(
						Pix pixs,
						L_Stack stack,
						int x,
						int y,
						int connectivity)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixSeedfill(pixs.Pointer, stack.Pointer,   x,   y,   connectivity);
			return _Result;
		}

		// conncomp.c (888, 1)
		// pixSeedfill4(pixs, stack, x, y) as int
		// pixSeedfill4(PIX *, L_STACK *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This is Paul Heckbert's stack-based 4-cc seedfill algorithm.<para/>
		///
		/// (2) This operates on the input 1 bpp pix to remove the fg seed
		/// pixel, at (x,y), and all pixels that are 4-connected to it.
		/// The seed pixel at (x,y) must initially be ON.<para/>
		///
		/// (3) Reference: see pixSeedFill4BB()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfill4/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSeedfill4(
						Pix pixs,
						L_Stack stack,
						int x,
						int y)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixSeedfill4(pixs.Pointer, stack.Pointer,   x,   y);
			return _Result;
		}

		// conncomp.c (982, 1)
		// pixSeedfill8(pixs, stack, x, y) as int
		// pixSeedfill8(PIX *, L_STACK *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This is Paul Heckbert's stack-based 8-cc seedfill algorithm.<para/>
		///
		/// (2) This operates on the input 1 bpp pix to remove the fg seed
		/// pixel, at (x,y), and all pixels that are 8-connected to it.
		/// The seed pixel at (x,y) must initially be ON.<para/>
		///
		/// (3) Reference: see pixSeedFill8BB()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSeedfill8/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="stack">[in] - for holding fillsegs</param>
		///  <param name="x">[in] - ,y   location of seed pixel</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixSeedfill8(
						Pix pixs,
						L_Stack stack,
						int x,
						int y)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (stack == null) {throw new ArgumentNullException  ("stack cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixSeedfill8(pixs.Pointer, stack.Pointer,   x,   y);
			return _Result;
		}


	}
}
