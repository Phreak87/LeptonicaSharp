using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// pix5.c (130, 1)
		// pixaFindDimensions(pixa, pnaw, pnah) as int
		// pixaFindDimensions(PIXA *, NUMA **, NUMA **) as l_ok
		///  <summary>
		/// pixaFindDimensions()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindDimensions/*"/>
		///  <param name="pixa">[in] - </param>
		///  <param name="pnaw">[out][optional] - numa of pix widths</param>
		///  <param name="pnah">[out][optional] - numa of pix heights</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixaFindDimensions(
						Pixa pixa,
						out Numa pnaw,
						out Numa pnah)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr pnawPtr = IntPtr.Zero;
			IntPtr pnahPtr = IntPtr.Zero;
			int _Result = Natives.pixaFindDimensions(pixa.Pointer, out pnawPtr, out pnahPtr);
			if (pnawPtr == IntPtr.Zero) {pnaw = null;} else { pnaw = new Numa(pnawPtr); };
			if (pnahPtr == IntPtr.Zero) {pnah = null;} else { pnah = new Numa(pnahPtr); };

			return _Result;
		}

		// pix5.c (180, 1)
		// pixFindAreaPerimRatio(pixs, tab, pfract) as int
		// pixFindAreaPerimRatio(PIX *, l_int32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) The area is the number of fg pixels that are not on the
		/// boundary (i.e., are not 8-connected to a bg pixel), and the
		/// perimeter is the number of fg boundary pixels.  Returns
		/// 0.0 if there are no fg pixels.<para/>
		///
		/// (2) This function is retained because clients are using it.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindAreaPerimRatio/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be NULL</param>
		///  <param name="pfract">[out] - area/perimeter ratio</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindAreaPerimRatio(
						Pix pixs,
						int[] tab,
						out Single pfract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFindAreaPerimRatio(pixs.Pointer,   tab, out  pfract);
			return _Result;
		}

		// pix5.c (231, 1)
		// pixaFindPerimToAreaRatio(pixa) as Numa
		// pixaFindPerimToAreaRatio(PIXA *) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindPerimToAreaRatio/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///   <returns>na   of perimeter/arear ratio for each pix, or NULL on error</returns>
		public static Numa pixaFindPerimToAreaRatio(
						Pixa pixa)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindPerimToAreaRatio(pixa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (281, 1)
		// pixFindPerimToAreaRatio(pixs, tab, pfract) as int
		// pixFindPerimToAreaRatio(PIX *, l_int32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) The perimeter is the number of fg boundary pixels, and the
		/// area is the number of fg pixels.  This returns 0.0 if
		/// there are no fg pixels.<para/>
		///
		/// (2) Unlike pixFindAreaPerimRatio(), this uses the full set of
		/// fg pixels for the area, and the ratio is taken in the opposite
		/// order.<para/>
		///
		/// (3) This is typically used for a single connected component.
		/// This always has a value smaller or equal 1.0, and if the average distance
		/// of a fg pixel from the nearest bg pixel is d, this has
		/// a value ~1/d.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindPerimToAreaRatio/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be NULL</param>
		///  <param name="pfract">[out] - perimeter/area ratio</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindPerimToAreaRatio(
						Pix pixs,
						int[] tab,
						out Single pfract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFindPerimToAreaRatio(pixs.Pointer,   tab, out  pfract);
			return _Result;
		}

		// pix5.c (335, 1)
		// pixaFindPerimSizeRatio(pixa) as Numa
		// pixaFindPerimSizeRatio(PIXA *) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components.<para/>
		///
		/// (2) This has a minimum value for a circle of pi/4 a value for
		/// a rectangle component of approx. 1.0 and a value much larger
		/// than 1.0 for a component with a highly irregular boundary.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindPerimSizeRatio/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///   <returns>na   of fg perimeter/(2(w+h)) ratio for each pix, or NULL on error</returns>
		public static Numa pixaFindPerimSizeRatio(
						Pixa pixa)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindPerimSizeRatio(pixa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (385, 1)
		// pixFindPerimSizeRatio(pixs, tab, pratio) as int
		// pixFindPerimSizeRatio(PIX *, l_int32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) We take the 'size' as twice the sum of the width and
		/// height of pixs, and the perimeter is the number of fg
		/// boundary pixels.  We use the fg pixels of the boundary
		/// because the pix may be clipped to the boundary, so an
		/// erosion is required to count all boundary pixels.<para/>
		///
		/// (2) This has a large value for dendritic, fractal-like components
		/// with highly irregular boundaries.<para/>
		///
		/// (3) This is typically used for a single connected component.
		/// It has a value of about 1.0 for rectangular components with
		/// relatively smooth boundaries.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindPerimSizeRatio/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be NULL</param>
		///  <param name="pratio">[out] - perimeter/size ratio</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindPerimSizeRatio(
						Pix pixs,
						int[] tab,
						out Single pratio)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFindPerimSizeRatio(pixs.Pointer,   tab, out  pratio);
			return _Result;
		}

		// pix5.c (431, 1)
		// pixaFindAreaFraction(pixa) as Numa
		// pixaFindAreaFraction(PIXA *) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindAreaFraction/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///   <returns>na  of area fractions for each pix, or NULL on error</returns>
		public static Numa pixaFindAreaFraction(
						Pixa pixa)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindAreaFraction(pixa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (474, 1)
		// pixFindAreaFraction(pixs, tab, pfract) as int
		// pixFindAreaFraction(PIX *, l_int32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) This finds the ratio of the number of fg pixels to the
		/// size of the pix (w  h).  It is typically used for a
		/// single connected component.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindAreaFraction/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be NULL</param>
		///  <param name="pfract">[out] - fg area/size ratio</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindAreaFraction(
						Pix pixs,
						int[] tab,
						out Single pfract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFindAreaFraction(pixs.Pointer,   tab, out  pfract);
			return _Result;
		}

		// pix5.c (522, 1)
		// pixaFindAreaFractionMasked(pixa, pixm, debug) as Numa
		// pixaFindAreaFractionMasked(PIXA *, PIX *, l_int32) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components, which has an associated
		/// boxa giving the location of the components relative
		/// to the mask origin.<para/>
		///
		/// (2) The debug flag displays in green and red the masked and
		/// unmasked parts of the image from which pixa was derived.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindAreaFractionMasked/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///  <param name="pixm">[in] - mask image</param>
		///  <param name="debug">[in] - 1 for output, 0 to suppress</param>
		///   <returns>na of ratio masked/total fractions for each pix, or NULL on error</returns>
		public static Numa pixaFindAreaFractionMasked(
						Pixa pixa,
						Pix pixm,
						DebugOnOff debug)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindAreaFractionMasked(pixa.Pointer, pixm.Pointer,  (int) debug);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (601, 1)
		// pixFindAreaFractionMasked(pixs, box, pixm, tab, pfract) as int
		// pixFindAreaFractionMasked(PIX *, BOX *, PIX *, l_int32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) This finds the ratio of the number of masked fg pixels
		/// in pixs to the total number of fg pixels in pixs.
		/// It is typically used for a single connected component.
		/// If there are no fg pixels, this returns a ratio of 0.0.<para/>
		///
		/// (2) The box gives the location of the pix relative to that
		/// of the UL corner of the mask.  Therefore, the rasterop
		/// is performed with the pix translated to its location
		/// (x, y) in the mask before ANDing.
		/// If box == NULL, the UL corners of pixs and pixm are aligned.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindAreaFractionMasked/*"/>
		///  <param name="pixs">[in] - 1 bpp, typically a single component</param>
		///  <param name="box">[in][optional] - for pixs relative to pixm</param>
		///  <param name="pixm">[in] - 1 bpp mask, typically over the entire image from which the component pixs was extracted</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be NULL</param>
		///  <param name="pfract">[out] - fg area/size ratio</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindAreaFractionMasked(
						Pix pixs,
						Box box,
						Pix pixm,
						int[] tab,
						out Single pfract)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}

			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.pixFindAreaFractionMasked(pixs.Pointer, boxPtr, pixm.Pointer,   tab, out  pfract);
			return _Result;
		}

		// pix5.c (660, 1)
		// pixaFindWidthHeightRatio(pixa) as Numa
		// pixaFindWidthHeightRatio(PIXA *) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindWidthHeightRatio/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///   <returns>na of width/height ratios for each pix, or NULL on error</returns>
		public static Numa pixaFindWidthHeightRatio(
						Pixa pixa)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindWidthHeightRatio(pixa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (696, 1)
		// pixaFindWidthHeightProduct(pixa) as Numa
		// pixaFindWidthHeightProduct(PIXA *) as NUMA *
		///  <summary>
		/// (1) This is typically used for a pixa consisting of
		/// 1 bpp connected components.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaFindWidthHeightProduct/*"/>
		///  <param name="pixa">[in] - of 1 bpp pix</param>
		///   <returns>na of widthheight products for each pix, or NULL on error</returns>
		public static Numa pixaFindWidthHeightProduct(
						Pixa pixa)
		{
			if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}

			IntPtr _Result = Natives.pixaFindWidthHeightProduct(pixa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (736, 1)
		// pixFindOverlapFraction(pixs1, pixs2, x2, y2, tab, pratio, pnoverlap) as int
		// pixFindOverlapFraction(PIX *, PIX *, l_int32, l_int32, l_int32 *, l_float32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The UL corner of pixs2 is placed at (x2, y2) in pixs1.<para/>
		///
		/// (2) This measure is similar to the correlation.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindOverlapFraction/*"/>
		///  <param name="pixs1">[in] - 1 bpp</param>
		///  <param name="pixs2">[in] - 1 bpp</param>
		///  <param name="x2">[in] - location in pixs1 of UL corner of pixs2</param>
		///  <param name="y2">[in] - location in pixs1 of UL corner of pixs2</param>
		///  <param name="tab">[in][optional] - pixel sum table, can be null</param>
		///  <param name="pratio">[out] - ratio fg intersection to fg union</param>
		///  <param name="pnoverlap">[out][optional] - number of overlapping pixels</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixFindOverlapFraction(
						Pix pixs1,
						Pix pixs2,
						int x2,
						int y2,
						int[] tab,
						out Single pratio,
						out int pnoverlap)
		{
			if (pixs1 == null) {throw new ArgumentNullException  ("pixs1 cannot be Nothing");}

			if (pixs2 == null) {throw new ArgumentNullException  ("pixs2 cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs1.d) == false) { throw new ArgumentException ("1 bpp"); }

			if ((new List<int> {1}).Contains ((int)pixs2.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFindOverlapFraction(pixs1.Pointer, pixs2.Pointer,   x2,   y2,   tab, out  pratio, out  pnoverlap);
			return _Result;
		}

		// pix5.c (803, 1)
		// pixFindRectangleComps(pixs, dist, minw, minh) as Boxa
		// pixFindRectangleComps(PIX *, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) This applies the function pixConformsToRectangle() to
		/// each 8-c.c. in pixs, and returns a boxa containing the
		/// regions of all components that are conforming.<para/>
		///
		/// (2) Conforming components must satisfy both the size constraint
		/// given by %minsize and the slop in conforming to a rectangle
		/// determined by %dist.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFindRectangleComps/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="dist">[in] - max distance allowed between bounding box and nearest foreground pixel within it</param>
		///  <param name="minw">[in] - minimum size in each direction as a requirement for a conforming rectangle</param>
		///  <param name="minh">[in] - minimum size in each direction as a requirement for a conforming rectangle</param>
		///   <returns>boxa of components that conform, or NULL on error</returns>
		public static Boxa pixFindRectangleComps(
						Pix pixs,
						int dist,
						int minw,
						int minh)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixFindRectangleComps(pixs.Pointer,   dist,   minw,   minh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// pix5.c (883, 1)
		// pixConformsToRectangle(pixs, box, dist, pconforms) as int
		// pixConformsToRectangle(PIX *, BOX *, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) There are several ways to test if a connected component has
		/// an essentially rectangular boundary, such as:
		/// a. Fraction of fill into the bounding box
		/// b. Max-min distance of fg pixel from periphery of bounding box
		/// c. Max depth of bg intrusions into component within bounding box
		/// The weakness of (a) is that it is highly sensitive to holes
		/// within the c.c.  The weakness of (b) is that it can have
		/// arbitrarily large intrusions into the c.c.  Method (c) tests
		/// the integrity of the outer boundary of the c.c., with respect
		/// to the enclosing bounding box, so we use it.<para/>
		///
		/// (2) This tests if the connected component within the box conforms
		/// to the box at all points on the periphery within %dist.
		/// Inside, at a distance from the box boundary that is greater
		/// than %dist, we don't care about the pixels in the c.c.<para/>
		///
		/// (3) We can think of the conforming condition as follows:
		/// No pixel inside a distance %dist from the boundary
		/// can connect to the boundary through a path through the bg.
		/// To implement this, we need to do a flood fill.  We can go
		/// either from inside toward the boundary, or the other direction.
		/// It's easiest to fill from the boundary, and then verify that
		/// there are no filled pixels farther than %dist from the boundary.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConformsToRectangle/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="box">[in][optional] - if null, use the entire pixs</param>
		///  <param name="dist">[in] - max distance allowed between bounding box and nearest foreground pixel within it</param>
		///  <param name="pconforms">[out] - 0 (false) if not conforming 1 (true) if conforming</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixConformsToRectangle(
						Pix pixs,
						Box box,
						int dist,
						out int pconforms)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.pixConformsToRectangle(pixs.Pointer, boxPtr,   dist, out  pconforms);
			return _Result;
		}

		// pix5.c (950, 1)
		// pixClipRectangles(pixs, boxa) as Pixa
		// pixClipRectangles(PIX *, BOXA *) as PIXA *
		///  <summary>
		/// (1) The returned pixa includes the actual regions clipped out from
		/// the input pixs.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipRectangles/*"/>
		///  <param name="pixs">[in] - </param>
		///  <param name="boxa">[in] - requested clipping regions</param>
		///   <returns>pixa consisting of requested regions, or NULL on error</returns>
		public static Pixa pixClipRectangles(
						Pix pixs,
						Boxa boxa)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.pixClipRectangles(pixs.Pointer, boxa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixa(_Result);
		}

		// pix5.c (1016, 1)
		// pixClipRectangle(pixs, box, pboxc) as Pix
		// pixClipRectangle(PIX *, BOX *, BOX **) as PIX *
		///  <summary>
		/// This should be simple, but there are choices to be made.
		/// The box is defined relative to the pix coordinates.  However,
		/// if the box is not contained within the pix, we have two choices:<para/>
		///
		/// (1) clip the box to the pix<para/>
		///
		/// (2) make a new pix equal to the full box dimensions,
		/// but let rasterop do the clipping and positioning
		/// of the src with respect to the dest
		/// Choice (2) immediately brings up the problem of what pixel values
		/// to use that were not taken from the src.  For example, on a grayscale
		/// image, do you want the pixels not taken from the src to be black
		/// or white or something else?  To implement choice 2, one needs to
		/// specify the color of these extra pixels.
		/// So we adopt (1), and clip the box first, if necessary,
		/// before making the dest pix and doing the rasterop.  But there
		/// is another issue to consider.  If you want to paste the
		/// clipped pix back into pixs, it must be properly aligned, and
		/// it is necessary to use the clipped box for alignment.
		/// Accordingly, this function has a third (optional) argument, which is
		/// the input box clipped to the src pix.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipRectangle/*"/>
		///  <param name="pixs">[in] - </param>
		///  <param name="box">[in] - requested clipping region const</param>
		///  <param name="pboxc">[out][optional] - actual box of clipped region</param>
		///   <returns>clipped pix, or NULL on error or if rectangle doesn't intersect pixs</returns>
		public static Pix pixClipRectangle(
						Pix pixs,
						Box box,
						out Box pboxc)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr pboxcPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixClipRectangle(pixs.Pointer, box.Pointer, out pboxcPtr);
			if (pboxcPtr == IntPtr.Zero) {pboxc = null;} else { pboxc = new Box(pboxcPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1089, 1)
		// pixClipMasked(pixs, pixm, x, y, outval) as Pix
		// pixClipMasked(PIX *, PIX *, l_int32, l_int32, l_uint32) as PIX *
		///  <summary>
		/// (1) If pixs has a colormap, it is preserved in pixd.<para/>
		///
		/// (2) The depth of pixd is the same as that of pixs.<para/>
		///
		/// (3) If the depth of pixs is 1, use %outval = 0 for white background
		/// and 1 for black otherwise, use the max value for white
		/// and 0 for black.  If pixs has a colormap, the max value for
		/// %outval is 0xffffffff otherwise, it is 2^d - 1.<para/>
		///
		/// (4) When using 1 bpp pixs, this is a simple clip and
		/// blend operation.  For example, if both pix1 and pix2 are
		/// black text on white background, and you want to OR the
		/// fg on the two images, let pixm be the inverse of pix2.
		/// Then the operation takes all of pix1 that's in the bg of
		/// pix2, and for the remainder (which are the pixels
		/// corresponding to the fg of the pix2), paint them black<para/>
		///
		/// (1) in pix1.  The function call looks like
		/// pixClipMasked(pix2, pixInvert(pix1, pix1), x, y, 1)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipMasked/*"/>
		///  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp colormap ok</param>
		///  <param name="pixm">[in] - clipping mask, 1 bpp</param>
		///  <param name="x">[in] - origin of clipping mask relative to pixs</param>
		///  <param name="y">[in] - origin of clipping mask relative to pixs</param>
		///  <param name="outval">[in] - val to use for pixels that are outside the mask</param>
		///   <returns>pixd, clipped pix or NULL on error or if pixm doesn't intersect pixs</returns>
		public static Pix pixClipMasked(
						Pix pixs,
						Pix pixm,
						int x,
						int y,
						uint outval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (pixm == null) {throw new ArgumentNullException  ("pixm cannot be Nothing");}

			IntPtr _Result = Natives.pixClipMasked(pixs.Pointer, pixm.Pointer,   x,   y,   outval);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1151, 1)
		// pixCropToMatch(pixs1, pixs2, ppixd1, ppixd2) as int
		// pixCropToMatch(PIX *, PIX *, PIX **, PIX **) as l_ok
		///  <summary>
		/// (1) This resizes pixs1 and/or pixs2 by cropping at the right
		/// and bottom, so that they're the same size.<para/>
		///
		/// (2) If a pix doesn't need to be cropped, a clone is returned.<para/>
		///
		/// (3) Note: the images are implicitly aligned to the UL corner.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCropToMatch/*"/>
		///  <param name="pixs1">[in] - any depth, colormap OK</param>
		///  <param name="pixs2">[in] - any depth, colormap OK</param>
		///  <param name="ppixd1">[out] - may be a clone</param>
		///  <param name="ppixd2">[out] - may be a clone</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixCropToMatch(
						Pix pixs1,
						Pix pixs2,
						out Pix ppixd1,
						out Pix ppixd2)
		{
			if (pixs1 == null) {throw new ArgumentNullException  ("pixs1 cannot be Nothing");}

			if (pixs2 == null) {throw new ArgumentNullException  ("pixs2 cannot be Nothing");}

			IntPtr ppixd1Ptr = IntPtr.Zero;
			IntPtr ppixd2Ptr = IntPtr.Zero;
			int _Result = Natives.pixCropToMatch(pixs1.Pointer, pixs2.Pointer, out ppixd1Ptr, out ppixd2Ptr);
			if (ppixd1Ptr == IntPtr.Zero) {ppixd1 = null;} else { ppixd1 = new Pix(ppixd1Ptr); };
			if (ppixd2Ptr == IntPtr.Zero) {ppixd2 = null;} else { ppixd2 = new Pix(ppixd2Ptr); };

			return _Result;
		}

		// pix5.c (1194, 1)
		// pixCropToSize(pixs, w, h) as Pix
		// pixCropToSize(PIX *, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) If either w or h is smaller than the corresponding dimension
		/// of pixs, this returns a cropped image otherwise it returns
		/// a clone of pixs.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCropToSize/*"/>
		///  <param name="pixs">[in] - any depth, colormap OK</param>
		///  <param name="w">[in] - max dimensions of cropped image</param>
		///  <param name="h">[in] - max dimensions of cropped image</param>
		///   <returns>pixd cropped if necessary or NULL on error.</returns>
		public static Pix pixCropToSize(
						Pix pixs,
						int w,
						int h)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixCropToSize(pixs.Pointer,   w,   h);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1248, 1)
		// pixResizeToMatch(pixs, pixt, w, h) as Pix
		// pixResizeToMatch(PIX *, PIX *, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This resizes pixs to make pixd, without scaling, by either
		/// cropping or extending separately in both width and height.
		/// Extension is done by replicating the last row or column.
		/// This is useful in a situation where, due to scaling
		/// operations, two images that are expected to be the
		/// same size can differ slightly in each dimension.<para/>
		///
		/// (2) You can use either an existing pixt or specify
		/// both %w and %h.  If pixt is defined, the values
		/// in %w and %h are ignored.<para/>
		///
		/// (3) If pixt is larger than pixs (or if w and/or d is larger
		/// than the dimension of pixs, replicate the outer row and
		/// column of pixels in pixs into pixd.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixResizeToMatch/*"/>
		///  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp colormap ok</param>
		///  <param name="pixt">[in]can be null - we use only the size</param>
		///  <param name="w">[in] - ignored if pixt is defined</param>
		///  <param name="h">[in] - ignored if pixt is defined</param>
		///   <returns>pixd resized to match or NULL on error</returns>
		public static Pix pixResizeToMatch(
						Pix pixs,
						Pix pixt,
						int w,
						int h)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr pixtPtr = IntPtr.Zero; 	if (pixt != null) {pixtPtr = pixt.Pointer;}
			IntPtr _Result = Natives.pixResizeToMatch(pixs.Pointer, pixtPtr,   w,   h);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1329, 1)
		// pixMakeFrameMask(w, h, hf1, hf2, vf1, vf2) as Pix
		// pixMakeFrameMask(l_int32, l_int32, l_float32, l_float32, l_float32, l_float32) as PIX *
		///  <summary>
		/// (1) This makes an arbitrary 1-component mask with a centered fg
		/// frame, which can have both an inner and an outer boundary.
		/// All input fractional distances are measured from the image
		/// border to the frame boundary, in units of the image half-width
		/// for hf1 and hf2 and the image half-height for vf1 and vf2.
		/// The distances to the outer frame boundary are given by hf1
		/// and vf1 to the inner frame boundary, by hf2 and vf2.
		/// Input fractions are thus in [0.0 ... 1.0], with hf1 smaller or equal hf2
		/// and vf1 smaller or equal vf2.  Horizontal and vertical frame widths are
		/// thus independently specified.<para/>
		///
		/// (2) Special cases:
		/// full fg mask: hf1 = vf1 = 0.0, hf2 = vf2 = 1.0.
		/// empty fg (zero width) mask: set  hf1 = hf2  and vf1 = vf2.
		/// fg rectangle with no hole: set hf2 = vf2 = 1.0.
		/// frame touching outer boundary: set hf1 = vf1 = 0.0.<para/>
		///
		/// (3) The vertical thickness of the horizontal mask parts
		/// is 0.5  (vf2 - vf1)  h.  The horizontal thickness of the
		/// vertical mask parts is 0.5  (hf2 - hf1)  w.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeFrameMask/*"/>
		///  <param name="w">[in] - dimensions of output 1 bpp pix</param>
		///  <param name="h">[in] - dimensions of output 1 bpp pix</param>
		///  <param name="hf1">[in] - horizontal fraction of half-width at outer frame bdry</param>
		///  <param name="hf2">[in] - horizontal fraction of half-width at inner frame bdry</param>
		///  <param name="vf1">[in] - vertical fraction of half-width at outer frame bdry</param>
		///  <param name="vf2">[in] - vertical fraction of half-width at inner frame bdry</param>
		///   <returns>pixd 1 bpp, or NULL on error.</returns>
		public static Pix pixMakeFrameMask(
						int w,
						int h,
						Single hf1,
						Single hf2,
						Single vf1,
						Single vf2)
		{
			IntPtr _Result = Natives.pixMakeFrameMask(  w,   h,   hf1,   hf2,   vf1,   vf2);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1395, 1)
		// pixMakeCoveringOfRectangles(pixs, maxiters) as Pix
		// pixMakeCoveringOfRectangles(PIX *, l_int32) as PIX *
		///  <summary>
		/// (1) This iteratively finds the bounding boxes of the connected
		/// components and generates a mask from them.  Two iterations
		/// should suffice for most situations.<para/>
		///
		/// (2) Returns an empty pix if %pixs is empty.<para/>
		///
		/// (3) If there are many small components in proximity, it may
		/// be useful to merge them with a morphological closing before
		/// calling this one.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMakeCoveringOfRectangles/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="maxiters">[in] - max iterations: use 0 to iterate to completion</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixMakeCoveringOfRectangles(
						Pix pixs,
						int maxiters)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixMakeCoveringOfRectangles(pixs.Pointer,   maxiters);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (1468, 1)
		// pixFractionFgInMask(pix1, pix2, pfract) as int
		// pixFractionFgInMask(PIX *, PIX *, l_float32 *) as l_ok
		///  <summary>
		/// (1) This gives the fraction of fg pixels in pix1 that are in
		/// the intersection (i.e., under the fg) of pix2:
		/// |1 [and] 2|/|1|, where |...| means the number of fg pixels.
		/// Note that this is different from the situation where
		/// pix1 and pix2 are reversed.<para/>
		///
		/// (2) Both pix1 and pix2 are registered to the UL corners.  A warning
		/// is issued if pix1 and pix2 have different sizes.<para/>
		///
		/// (3) This can also be used to find the fraction of fg pixels in pix1
		/// that are NOT under the fg of pix2: 1.0 - |1 [and] 2|/|1|<para/>
		///
		/// (4) If pix1 or pix2 are empty, this returns %fract = 0.0.<para/>
		///
		/// (5) For example, pix2 could be a frame around the outside of the
		/// image, made from pixMakeFrameMask().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFractionFgInMask/*"/>
		///  <param name="pix1">[in] - 1 bpp</param>
		///  <param name="pix2">[in] - 1 bpp</param>
		///  <param name="pfract">[out] - fraction of fg pixels in 1 that are aligned with the fg of 2</param>
		///   <returns>0 if OK, 1 on error.</returns>
		public static int pixFractionFgInMask(
						Pix pix1,
						Pix pix2,
						out Single pfract)
		{
			if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}

			if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pix1.d) == false) { throw new ArgumentException ("1 bpp"); }

			if ((new List<int> {1}).Contains ((int)pix2.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixFractionFgInMask(pix1.Pointer, pix2.Pointer, out  pfract);
			return _Result;
		}

		// pix5.c (1524, 1)
		// pixClipToForeground(pixs, ppixd, pbox) as int
		// pixClipToForeground(PIX *, PIX **, BOX **) as l_ok
		///  <summary>
		/// (1) At least one of {[and]pixd, [and]box} must be specified.<para/>
		///
		/// (2) If there are no fg pixels, the returned ptrs are null.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipToForeground/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="ppixd">[out][optional] - clipped pix returned</param>
		///  <param name="pbox">[out][optional] - bounding box</param>
		///   <returns>0 if OK 1 on error or if there are no fg pixels</returns>
		public static int pixClipToForeground(
						Pix pixs,
						out Pix ppixd,
						out Box pbox)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr ppixdPtr = IntPtr.Zero;
			IntPtr pboxPtr = IntPtr.Zero;
			int _Result = Natives.pixClipToForeground(pixs.Pointer, out ppixdPtr, out pboxPtr);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
			if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };

			return _Result;
		}

		// pix5.c (1624, 1)
		// pixTestClipToForeground(pixs, pcanclip) as int
		// pixTestClipToForeground(PIX *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This is a lightweight test to determine if a 1 bpp image
		/// can be further cropped without loss of fg pixels.
		/// If it cannot, canclip is set to 0.<para/>
		///
		/// (2) It does not test for the existence of any fg pixels.
		/// If there are no fg pixels, it will return %canclip = 1.
		/// Check the output of the subsequent call to pixClipToForeground().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTestClipToForeground/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="pcanclip">[out] - 1 if fg does not extend to all four edges</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixTestClipToForeground(
						Pix pixs,
						out int pcanclip)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixTestClipToForeground(pixs.Pointer, out  pcanclip);
			return _Result;
		}

		// pix5.c (1696, 1)
		// pixClipBoxToForeground(pixs, boxs, ppixd, pboxd) as int
		// pixClipBoxToForeground(PIX *, BOX *, PIX **, BOX **) as l_ok
		///  <summary>
		/// (1) At least one of {[and]pixd, [and]boxd} must be specified.<para/>
		///
		/// (2) If there are no fg pixels, the returned ptrs are null.<para/>
		///
		/// (3) Do not use [and]pixs for the 3rd arg or [and]boxs for the 4th arg
		/// this will leak memory.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipBoxToForeground/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="boxs">[in][optional] - use full image if null</param>
		///  <param name="ppixd">[out][optional] - clipped pix returned</param>
		///  <param name="pboxd">[out][optional] - bounding box</param>
		///   <returns>0 if OK 1 on error or if there are no fg pixels</returns>
		public static int pixClipBoxToForeground(
						Pix pixs,
						Box boxs,
						out Pix ppixd,
						out Box pboxd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr boxsPtr = IntPtr.Zero; 	if (boxs != null) {boxsPtr = boxs.Pointer;}
			IntPtr ppixdPtr = IntPtr.Zero;
			IntPtr pboxdPtr = IntPtr.Zero;
			int _Result = Natives.pixClipBoxToForeground(pixs.Pointer, boxsPtr, out ppixdPtr, out pboxdPtr);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
			if (pboxdPtr == IntPtr.Zero) {pboxd = null;} else { pboxd = new Box(pboxdPtr); };

			return _Result;
		}

		// pix5.c (1762, 1)
		// pixScanForForeground(pixs, box, scanflag, ploc) as int
		// pixScanForForeground(PIX *, BOX *, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) If there are no fg pixels, the position is set to 0.
		/// Caller must check the return value!<para/>
		///
		/// (2) Use %box == NULL to scan from edge of pixs
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScanForForeground/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="box">[in][optional] - within which the search is conducted</param>
		///  <param name="scanflag">[in] - direction of scan e.g., L_FROM_LEFT</param>
		///  <param name="ploc">[out] - location in scan direction of first black pixel</param>
		///   <returns>0 if OK 1 on error or if no fg pixels are found</returns>
		public static int pixScanForForeground(
						Pix pixs,
						Box box,
						int scanflag,
						out int ploc)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.pixScanForForeground(pixs.Pointer, boxPtr,   scanflag, out  ploc);
			return _Result;
		}

		// pix5.c (1878, 1)
		// pixClipBoxToEdges(pixs, boxs, lowthresh, highthresh, maxwidth, factor, ppixd, pboxd) as int
		// pixClipBoxToEdges(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, PIX **, BOX **) as l_ok
		///  <summary>
		/// (1) At least one of {[and]pixd, [and]boxd} must be specified.<para/>
		///
		/// (2) If there are no fg pixels, the returned ptrs are null.<para/>
		///
		/// (3) This function attempts to locate rectangular "image" regions
		/// of high-density fg pixels, that have well-defined edges
		/// on the four sides.<para/>
		///
		/// (4) Edges are searched for on each side, iterating in order
		/// from left, right, top and bottom.  As each new edge is
		/// found, the search box is resized to use that location.
		/// Once an edge is found, it is held.  If no more edges
		/// are found in one iteration, the search fails.<para/>
		///
		/// (5) See pixScanForEdge() for usage of the thresholds and %maxwidth.<para/>
		///
		/// (6) The thresholds must be at least 1, and the low threshold
		/// cannot be larger than the high threshold.<para/>
		///
		/// (7) If the low and high thresholds are both 1, this is equivalent
		/// to pixClipBoxToForeground().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixClipBoxToEdges/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="boxs">[in][optional] - use full image if null</param>
		///  <param name="lowthresh">[in] - threshold to choose clipping location</param>
		///  <param name="highthresh">[in] - threshold required to find an edge</param>
		///  <param name="maxwidth">[in] - max allowed width between low and high thresh locs</param>
		///  <param name="factor">[in] - sampling factor along pixel counting direction</param>
		///  <param name="ppixd">[out][optional] - clipped pix returned</param>
		///  <param name="pboxd">[out][optional] - bounding box</param>
		///   <returns>0 if OK 1 on error or if a fg edge is not found from all four sides.</returns>
		public static int pixClipBoxToEdges(
						Pix pixs,
						Box boxs,
						int lowthresh,
						int highthresh,
						int maxwidth,
						int factor,
						out Pix ppixd,
						out Box pboxd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr boxsPtr = IntPtr.Zero; 	if (boxs != null) {boxsPtr = boxs.Pointer;}
			IntPtr ppixdPtr = IntPtr.Zero;
			IntPtr pboxdPtr = IntPtr.Zero;
			int _Result = Natives.pixClipBoxToEdges(pixs.Pointer, boxsPtr,   lowthresh,   highthresh,   maxwidth,   factor, out ppixdPtr, out pboxdPtr);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };
			if (pboxdPtr == IntPtr.Zero) {pboxd = null;} else { pboxd = new Box(pboxdPtr); };

			return _Result;
		}

		// pix5.c (2008, 1)
		// pixScanForEdge(pixs, box, lowthresh, highthresh, maxwidth, factor, scanflag, ploc) as int
		// pixScanForEdge(PIX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) If there are no fg pixels, the position is set to 0.
		/// Caller must check the return value!<para/>
		///
		/// (2) Use %box == NULL to scan from edge of pixs<para/>
		///
		/// (3) As the scan progresses, the location where the sum of
		/// pixels equals or excees %lowthresh is noted (loc).  The
		/// scan is stopped when the sum of pixels equals or exceeds
		/// %highthresh.  If the scan distance between loc and that
		/// point does not exceed %maxwidth, an edge is found and
		/// its position is taken to be loc.  %maxwidth implicitly
		/// sets a minimum on the required gradient of the edge.<para/>
		///
		/// (4) The thresholds must be at least 1, and the low threshold
		/// cannot be larger than the high threshold.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixScanForEdge/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="box">[in][optional] - within which the search is conducted</param>
		///  <param name="lowthresh">[in] - threshold to choose clipping location</param>
		///  <param name="highthresh">[in] - threshold required to find an edge</param>
		///  <param name="maxwidth">[in] - max allowed width between low and high thresh locs</param>
		///  <param name="factor">[in] - sampling factor along pixel counting direction</param>
		///  <param name="scanflag">[in] - direction of scan e.g., L_FROM_LEFT</param>
		///  <param name="ploc">[out] - location in scan direction of first black pixel</param>
		///   <returns>0 if OK 1 on error or if the edge is not found</returns>
		public static int pixScanForEdge(
						Pix pixs,
						Box box,
						int lowthresh,
						int highthresh,
						int maxwidth,
						int factor,
						int scanflag,
						out int ploc)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.pixScanForEdge(pixs.Pointer, boxPtr,   lowthresh,   highthresh,   maxwidth,   factor,   scanflag, out  ploc);
			return _Result;
		}

		// pix5.c (2189, 1)
		// pixExtractOnLine(pixs, x1, y1, x2, y2, factor) as Numa
		// pixExtractOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as NUMA *
		///  <summary>
		/// (1) Input end points are clipped to the pix.<para/>
		///
		/// (2) If the line is either horizontal, or closer to horizontal
		/// than to vertical, the points will be extracted from left
		/// to right in the pix.  Likewise, if the line is vertical,
		/// or closer to vertical than to horizontal, the points will
		/// be extracted from top to bottom.<para/>
		///
		/// (3) Can be used with numaCountReverals(), for example, to
		/// characterize the intensity smoothness along a line.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExtractOnLine/*"/>
		///  <param name="pixs">[in] - 1 bpp or 8 bpp no colormap</param>
		///  <param name="x1">[in] - one end point for line</param>
		///  <param name="y1">[in] - one end point for line</param>
		///  <param name="x2">[in] - another end pt for line</param>
		///  <param name="y2">[in] - another end pt for line</param>
		///  <param name="factor">[in] - sampling greater or equal 1</param>
		///   <returns>na of pixel values along line, or NULL on error.</returns>
		public static Numa pixExtractOnLine(
						Pix pixs,
						int x1,
						int y1,
						int x2,
						int y2,
						int factor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixExtractOnLine(pixs.Pointer,   x1,   y1,   x2,   y2,   factor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (2309, 1)
		// pixAverageOnLine(pixs, x1, y1, x2, y2, factor) as Single
		// pixAverageOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as l_float32
		///  <summary>
		/// (1) The line must be either horizontal or vertical, so either
		/// y1 == y2 (horizontal) or x1 == x2 (vertical).<para/>
		///
		/// (2) If horizontal, x1 must be smaller or equal x2.
		/// If vertical, y1 must be smaller or equal y2.
		/// characterize the intensity smoothness along a line.<para/>
		///
		/// (3) Input end points are clipped to the pix.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAverageOnLine/*"/>
		///  <param name="pixs">[in] - 1 bpp or 8 bpp no colormap</param>
		///  <param name="x1">[in] - starting pt for line</param>
		///  <param name="y1">[in] - starting pt for line</param>
		///  <param name="x2">[in] - end pt for line</param>
		///  <param name="y2">[in] - end pt for line</param>
		///  <param name="factor">[in] - sampling greater or equal 1</param>
		///   <returns>average of pixel values along line, or NULL on error.</returns>
		public static Single pixAverageOnLine(
						Pix pixs,
						int x1,
						int y1,
						int x2,
						int y2,
						int factor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			Single _Result = Natives.pixAverageOnLine(pixs.Pointer,   x1,   y1,   x2,   y2,   factor);
			return _Result;
		}

		// pix5.c (2408, 1)
		// pixAverageIntensityProfile(pixs, fract, dir, first, last, factor1, factor2) as Numa
		// pixAverageIntensityProfile(PIX *, l_float32, l_int32, l_int32, l_int32, l_int32, l_int32) as NUMA *
		///  <summary>
		/// (1) If d != 1 bpp, colormaps are removed and the result
		/// is converted to 8 bpp.<para/>
		///
		/// (2) If %dir == L_HORIZONTAL_LINE, the intensity is averaged
		/// along each horizontal raster line (sampled by %factor1),
		/// and the profile is the array of these averages in the
		/// vertical direction between %first and %last raster lines,
		/// and sampled by %factor2.<para/>
		///
		/// (3) If %dir == L_VERTICAL_LINE, the intensity is averaged
		/// along each vertical line (sampled by %factor1),
		/// and the profile is the array of these averages in the
		/// horizontal direction between %first and %last columns,
		/// and sampled by %factor2.<para/>
		///
		/// (4) The averages are measured over the central %fract of the image.
		/// Use %fract == 1.0 to average across the entire width or height.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAverageIntensityProfile/*"/>
		///  <param name="pixs">[in] - any depth colormap OK</param>
		///  <param name="fract">[in] - fraction of image width or height to be used</param>
		///  <param name="dir">[in] - averaging direction: L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
		///  <param name="first">[in] - last span of rows or columns to measure</param>
		///  <param name="factor1">[in] - sampling along fast scan direction greater or equal 1</param>
		///  <param name="factor2">[in] - sampling along slow scan direction greater or equal 1</param>
		///   <returns>na of reversal profile, or NULL on error.</returns>
		public static Numa pixAverageIntensityProfile(
						Pix pixs,
						Single fract,
						int dir,
						int first,
						int last,
						int factor1,
						int factor2)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixAverageIntensityProfile(pixs.Pointer,   fract,   dir,   first,   last,   factor1,   factor2);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (2523, 1)
		// pixReversalProfile(pixs, fract, dir, first, last, minreversal, factor1, factor2) as Numa
		// pixReversalProfile(PIX *, l_float32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as NUMA *
		///  <summary>
		/// (1) If d != 1 bpp, colormaps are removed and the result
		/// is converted to 8 bpp.<para/>
		///
		/// (2) If %dir == L_HORIZONTAL_LINE, the the reversals are counted
		/// along each horizontal raster line (sampled by %factor1),
		/// and the profile is the array of these sums in the
		/// vertical direction between %first and %last raster lines,
		/// and sampled by %factor2.<para/>
		///
		/// (3) If %dir == L_VERTICAL_LINE, the the reversals are counted
		/// along each vertical column (sampled by %factor1),
		/// and the profile is the array of these sums in the
		/// horizontal direction between %first and %last columns,
		/// and sampled by %factor2.<para/>
		///
		/// (4) For each row or column, the reversals are summed over the
		/// central %fract of the image.  Use %fract == 1.0 to sum
		/// across the entire width (of row) or height (of column).<para/>
		///
		/// (5) %minreversal is the relative change in intensity that is
		/// required to resolve peaks and valleys.  A typical number for
		/// locating text in 8 bpp might be 50.  For 1 bpp, minreversal
		/// must be 1.<para/>
		///
		/// (6) The reversal profile is simply the number of reversals
		/// in a row or column, vs the row or column index.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReversalProfile/*"/>
		///  <param name="pixs">[in] - any depth colormap OK</param>
		///  <param name="fract">[in] - fraction of image width or height to be used</param>
		///  <param name="dir">[in] - profile direction: L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
		///  <param name="first">[in] - span of rows or columns to measure</param>
		///  <param name="last">[in] - span of rows or columns to measure</param>
		///  <param name="minreversal">[in] - minimum change in intensity to trigger a reversal</param>
		///  <param name="factor1">[in] - sampling along raster line (fast scan) greater or equal 1</param>
		///  <param name="factor2">[in] - sampling of raster lines (slow scan) greater or equal 1</param>
		///   <returns>na of reversal profile, or NULL on error.</returns>
		public static Numa pixReversalProfile(
						Pix pixs,
						Single fract,
						int dir,
						int first,
						int last,
						int minreversal,
						int factor1,
						int factor2)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixReversalProfile(pixs.Pointer,   fract,   dir,   first,   last,   minreversal,   factor1,   factor2);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// pix5.c (2632, 1)
		// pixWindowedVarianceOnLine(pixs, dir, loc, c1, c2, size, pnad) as int
		// pixWindowedVarianceOnLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, NUMA **) as l_ok
		///  <summary>
		/// (1) The returned variance array traverses the line starting
		/// from the smallest coordinate, min(c1,c2).<para/>
		///
		/// (2) Line end points are clipped to pixs.<para/>
		///
		/// (3) The reference point for the variance calculation is the center of
		/// the window.  Therefore, the numa start parameter from
		/// pixExtractOnLine() is incremented by %size/2,
		/// to align the variance values with the pixel coordinate.<para/>
		///
		/// (4) The square root of the variance is the RMS deviation from the mean.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWindowedVarianceOnLine/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///  <param name="dir">[in] - L_HORIZONTAL_LINE or L_VERTICAL_LINE</param>
		///  <param name="loc">[in] - location of the constant coordinate for the line</param>
		///  <param name="c1">[in] - end point coordinates for the line</param>
		///  <param name="c2">[in] - end point coordinates for the line</param>
		///  <param name="size">[in] - window size must be  is greater  1</param>
		///  <param name="pnad">[out] - windowed square root of variance</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int pixWindowedVarianceOnLine(
						Pix pixs,
						int dir,
						int loc,
						int c1,
						int c2,
						int size,
						out Numa pnad)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr pnadPtr = IntPtr.Zero;
			int _Result = Natives.pixWindowedVarianceOnLine(pixs.Pointer,   dir,   loc,   c1,   c2,   size, out pnadPtr);
			if (pnadPtr == IntPtr.Zero) {pnad = null;} else { pnad = new Numa(pnadPtr); };

			return _Result;
		}

		// pix5.c (2750, 1)
		// pixMinMaxNearLine(pixs, x1, y1, x2, y2, dist, direction, pnamin, pnamax, pminave, pmaxave) as int
		// pixMinMaxNearLine(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, NUMA **, NUMA **, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) If the line is more horizontal than vertical, the values
		/// are computed for [x1, x2], and the pixels are taken
		/// below and/or above the local y-value.  Otherwise, the
		/// values are computed for [y1, y2] and the pixels are taken
		/// to the left and/or right of the local x value.<para/>
		///
		/// (2) %direction specifies which side (or both sides) of the
		/// line are scanned for min and max values.<para/>
		///
		/// (3) There are two ways to tell if the returned values of min
		/// and max averages are valid: the returned values cannot be
		/// negative and the function must return 0.<para/>
		///
		/// (4) All accessed pixels are clipped to the pix.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMinMaxNearLine/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///  <param name="x1">[in] - starting pt for line</param>
		///  <param name="y1">[in] - starting pt for line</param>
		///  <param name="x2">[in] - end pt for line</param>
		///  <param name="y2">[in] - end pt for line</param>
		///  <param name="dist">[in] - distance to search from line in each direction</param>
		///  <param name="direction">[in] - L_SCAN_NEGATIVE, L_SCAN_POSITIVE, L_SCAN_BOTH</param>
		///  <param name="pnamin">[out][optional] - minimum values</param>
		///  <param name="pnamax">[out][optional] - maximum values</param>
		///  <param name="pminave">[out][optional] - average of minimum values</param>
		///  <param name="pmaxave">[out][optional] - average of maximum values</param>
		///   <returns>0 if OK 1 on error or if there are no sampled points within the image.</returns>
		public static int pixMinMaxNearLine(
						Pix pixs,
						int x1,
						int y1,
						int x2,
						int y2,
						int dist,
						int direction,
						out Numa pnamin,
						out Numa pnamax,
						out Single pminave,
						out Single pmaxave)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr pnaminPtr = IntPtr.Zero;
			IntPtr pnamaxPtr = IntPtr.Zero;
			int _Result = Natives.pixMinMaxNearLine(pixs.Pointer,   x1,   y1,   x2,   y2,   dist,   direction, out pnaminPtr, out pnamaxPtr, out  pminave, out  pmaxave);
			if (pnaminPtr == IntPtr.Zero) {pnamin = null;} else { pnamin = new Numa(pnaminPtr); };
			if (pnamaxPtr == IntPtr.Zero) {pnamax = null;} else { pnamax = new Numa(pnamaxPtr); };

			return _Result;
		}

		// pix5.c (2873, 1)
		// pixRankRowTransform(pixs) as Pix
		// pixRankRowTransform(PIX *) as PIX *
		///  <summary>
		/// (1) The time is O(n) in the number of pixels and runs about
		/// 100 Mpixels/sec on a 3 GHz machine.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRankRowTransform/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///   <returns>pixd with pixels sorted in each row, from min to max value</returns>
		public static Pix pixRankRowTransform(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRankRowTransform(pixs.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pix5.c (2926, 1)
		// pixRankColumnTransform(pixs) as Pix
		// pixRankColumnTransform(PIX *) as PIX *
		///  <summary>
		/// (1) The time is O(n) in the number of pixels and runs about
		/// 50 Mpixels/sec on a 3 GHz machine.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRankColumnTransform/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///   <returns>pixd with pixels sorted in each column, from min to max value</returns>
		public static Pix pixRankColumnTransform(
						Pix pixs)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixRankColumnTransform(pixs.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}


	}
}
