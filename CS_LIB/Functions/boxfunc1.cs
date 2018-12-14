using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// boxfunc1.c (99, 1)
		// boxContains(box1, box2, presult) as int
		// boxContains(BOX *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxContains()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxContains/*"/>
		///  <param name="box1">[in] - </param>
		///  <param name="box2">[in] - </param>
		///  <param name="presult">[out] - 1 if box2 is entirely contained within box1, and 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxContains(
						Box box1,
						Box box2,
						out int presult)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxContains(box1.Pointer, box2.Pointer, out  presult);
			return _Result;
		}

		// boxfunc1.c (130, 1)
		// boxIntersects(box1, box2, presult) as int
		// boxIntersects(BOX *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxIntersects()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxIntersects/*"/>
		///  <param name="box1">[in] - </param>
		///  <param name="box2">[in] - </param>
		///  <param name="presult">[out] - 1 if any part of box2 is contained in box1, and 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxIntersects(
						Box box1,
						Box box2,
						out int presult)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxIntersects(box1.Pointer, box2.Pointer, out  presult);
			return _Result;
		}

		// boxfunc1.c (172, 1)
		// boxaContainedInBox(boxas, box) as Boxa
		// boxaContainedInBox(BOXA *, BOX *) as BOXA *
		///  <summary>
		/// (1) All boxes in boxa that are entirely outside box are removed.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaContainedInBox/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="box">[in] - for containment</param>
		///   <returns>boxad boxa with all boxes in boxas that are entirely contained in box, or NULL on error</returns>
		public static Boxa boxaContainedInBox(
						Boxa boxas,
						Box box)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxaContainedInBox(boxas.Pointer, box.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (210, 1)
		// boxaContainedInBoxCount(boxa, box, pcount) as int
		// boxaContainedInBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxaContainedInBoxCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaContainedInBoxCount/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="box">[in] - for selecting contained boxes in %boxa</param>
		///  <param name="pcount">[out] - number of boxes intersecting the box</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaContainedInBoxCount(
						Boxa boxa,
						Box box,
						out int pcount)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaContainedInBoxCount(boxa.Pointer, box.Pointer, out  pcount);
			return _Result;
		}

		// boxfunc1.c (249, 1)
		// boxaContainedInBoxa(boxa1, boxa2, pcontained) as int
		// boxaContainedInBoxa(BOXA *, BOXA *, l_int32 *) as l_ok
		///  <summary>
		/// boxaContainedInBoxa()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaContainedInBoxa/*"/>
		///  <param name="boxa1">[in] - </param>
		///  <param name="boxa2">[in] - </param>
		///  <param name="pcontained">[out] - 1 if every box in boxa2 is contained in some box in boxa1 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaContainedInBoxa(
						Boxa boxa1,
						Boxa boxa2,
						out int pcontained)
		{
			if (boxa1 == null) {throw new ArgumentNullException  ("boxa1 cannot be Nothing");}

			if (boxa2 == null) {throw new ArgumentNullException  ("boxa2 cannot be Nothing");}

			int _Result = Natives.boxaContainedInBoxa(boxa1.Pointer, boxa2.Pointer, out  pcontained);
			return _Result;
		}

		// boxfunc1.c (302, 1)
		// boxaIntersectsBox(boxas, box) as Boxa
		// boxaIntersectsBox(BOXA *, BOX *) as BOXA *
		///  <summary>
		/// (1) All boxes in boxa that intersect with box (i.e., are completely
		/// or partially contained in box) are retained.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaIntersectsBox/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="box">[in] - for intersecting</param>
		///   <returns>boxad boxa with all boxes in boxas that intersect box, or NULL on error</returns>
		public static Boxa boxaIntersectsBox(
						Boxa boxas,
						Box box)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxaIntersectsBox(boxas.Pointer, box.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (340, 1)
		// boxaIntersectsBoxCount(boxa, box, pcount) as int
		// boxaIntersectsBoxCount(BOXA *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxaIntersectsBoxCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaIntersectsBoxCount/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="box">[in] - for selecting intersecting boxes in %boxa</param>
		///  <param name="pcount">[out] - number of boxes intersecting the box</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaIntersectsBoxCount(
						Boxa boxa,
						Box box,
						out int pcount)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaIntersectsBoxCount(boxa.Pointer, box.Pointer, out  pcount);
			return _Result;
		}

		// boxfunc1.c (385, 1)
		// boxaClipToBox(boxas, box) as Boxa
		// boxaClipToBox(BOXA *, BOX *) as BOXA *
		///  <summary>
		/// (1) All boxes in boxa not intersecting with box are removed, and
		/// the remaining boxes are clipped to box.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaClipToBox/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="box">[in] - for clipping</param>
		///   <returns>boxad boxa with boxes in boxas clipped to box, or NULL on error</returns>
		public static Boxa boxaClipToBox(
						Boxa boxas,
						Box box)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxaClipToBox(boxas.Pointer, box.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (442, 1)
		// boxaCombineOverlaps(boxas, pixadb) as Boxa
		// boxaCombineOverlaps(BOXA *, PIXA *) as BOXA *
		///  <summary>
		/// (1) If there are no overlapping boxes, it simply returns a copy
		/// of %boxas.<para/>
		///
		/// (2) Input an empty %pixadb, using pixaCreate(0), for debug output.
		/// The output gives 2 visualizations of the boxes per iteration
		/// boxes in red before, and added boxes in green after. Note that
		/// all pixels in the red boxes are contained in the green ones.<para/>
		///
		/// (3) The alternative method of painting each rectangle and finding
		/// the 4-connected components gives a different result in
		/// general, because two non-overlapping (but touching)
		/// rectangles, when rendered, are 4-connected and will be joined.<para/>
		///
		/// (4) A bad case computationally is to have n boxes, none of which
		/// overlap.  Then you have one iteration with O(n^2) compares.
		/// This is still faster than painting each rectangle and finding
		/// the bounding boxes of the connected components, even for
		/// thousands of rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCombineOverlaps/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="pixadb">[in,out] - debug output</param>
		///   <returns>boxad where each set of boxes in boxas that overlap are combined into a single bounding box in boxad, or NULL on error.</returns>
		public static Boxa boxaCombineOverlaps(
						Boxa boxas,
						ref Pixa pixadb)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pixadbPtr = IntPtr.Zero; if (pixadb != null) {pixadbPtr = pixadb.Pointer;}
			IntPtr _Result = Natives.boxaCombineOverlaps(boxas.Pointer, ref pixadbPtr);
			if (pixadbPtr == IntPtr.Zero) {pixadb = null;} else { pixadb = new Pixa(pixadbPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (536, 1)
		// boxaCombineOverlapsInPair(boxas1, boxas2, pboxad1, pboxad2, pixadb) as int
		// boxaCombineOverlapsInPair(BOXA *, BOXA *, BOXA **, BOXA **, PIXA *) as l_ok
		///  <summary>
		/// (1) One of three things happens to each box in %boxa1 and %boxa2:
		/// it gets absorbed into a larger box that it overlaps with
		/// it absorbs a smaller (by area) box that it overlaps with
		/// and gets larger, using the bounding region of the 2 boxes
		/// it is unchanged (including absorbing smaller boxes that
		/// are contained within it).<para/>
		///
		/// (2) If all the boxes from one of the input boxa are absorbed, this
		/// returns an empty boxa.<para/>
		///
		/// (3) Input an empty %pixadb, using pixaCreate(0), for debug output<para/>
		///
		/// (4) This is useful if different operations are to be carried out
		/// on possibly overlapping rectangular regions, and it is desired
		/// to have only one operation on any rectangular region.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCombineOverlapsInPair/*"/>
		///  <param name="boxas1">[in] - input boxa1</param>
		///  <param name="boxas2">[in] - input boxa2</param>
		///  <param name="pboxad1">[out] - output boxa1</param>
		///  <param name="pboxad2">[out] - output boxa2</param>
		///  <param name="pixadb">[in,out] - debug output</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaCombineOverlapsInPair(
						Boxa boxas1,
						Boxa boxas2,
						out Boxa pboxad1,
						out Boxa pboxad2,
						ref Pixa pixadb)
		{
			if (boxas1 == null) {throw new ArgumentNullException  ("boxas1 cannot be Nothing");}

			if (boxas2 == null) {throw new ArgumentNullException  ("boxas2 cannot be Nothing");}

			IntPtr pboxad1Ptr = IntPtr.Zero;
			IntPtr pboxad2Ptr = IntPtr.Zero;
			IntPtr pixadbPtr = IntPtr.Zero; if (pixadb != null) {pixadbPtr = pixadb.Pointer;}
			int _Result = Natives.boxaCombineOverlapsInPair(boxas1.Pointer, boxas2.Pointer, out pboxad1Ptr, out pboxad2Ptr, ref pixadbPtr);
			if (pboxad1Ptr == IntPtr.Zero) {pboxad1 = null;} else { pboxad1 = new Boxa(pboxad1Ptr); };
			if (pboxad2Ptr == IntPtr.Zero) {pboxad2 = null;} else { pboxad2 = new Boxa(pboxad2Ptr); };
			if (pixadbPtr == IntPtr.Zero) {pixadb = null;} else { pixadb = new Pixa(pixadbPtr); };

			return _Result;
		}

		// boxfunc1.c (674, 1)
		// boxOverlapRegion(box1, box2) as Box
		// boxOverlapRegion(BOX *, BOX *) as BOX *
		///  <summary>
		/// (1) This is the geometric intersection of the two rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxOverlapRegion/*"/>
		///  <param name="box1">[in] - two boxes</param>
		///  <param name="box2">[in] - two boxes</param>
		///   <returns>box of overlap region between input boxes, or NULL if no overlap or on error</returns>
		public static Box boxOverlapRegion(
						Box box1,
						Box box2)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			IntPtr _Result = Natives.boxOverlapRegion(box1.Pointer, box2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (716, 1)
		// boxBoundingRegion(box1, box2) as Box
		// boxBoundingRegion(BOX *, BOX *) as BOX *
		///  <summary>
		/// (1) This is the geometric union of the two rectangles.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxBoundingRegion/*"/>
		///  <param name="box1">[in] - two boxes</param>
		///  <param name="box2">[in] - two boxes</param>
		///   <returns>box of bounding region containing the input boxes, or NULL on error</returns>
		public static Box boxBoundingRegion(
						Box box1,
						Box box2)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			IntPtr _Result = Natives.boxBoundingRegion(box1.Pointer, box2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (756, 1)
		// boxOverlapFraction(box1, box2, pfract) as int
		// boxOverlapFraction(BOX *, BOX *, l_float32 *) as l_ok
		///  <summary>
		/// (1) The result depends on the order of the input boxes,
		/// because the overlap is taken as a fraction of box2.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxOverlapFraction/*"/>
		///  <param name="box1">[in] - two boxes</param>
		///  <param name="box2">[in] - two boxes</param>
		///  <param name="pfract">[out] - the fraction of box2 overlapped by box1</param>
		///   <returns>0 if OK, 1 on error.</returns>
		public static int boxOverlapFraction(
						Box box1,
						Box box2,
						out Single pfract)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxOverlapFraction(box1.Pointer, box2.Pointer, out  pfract);
			return _Result;
		}

		// boxfunc1.c (792, 1)
		// boxOverlapArea(box1, box2, parea) as int
		// boxOverlapArea(BOX *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxOverlapArea()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxOverlapArea/*"/>
		///  <param name="box1">[in] - two boxes</param>
		///  <param name="box2">[in] - two boxes</param>
		///  <param name="parea">[out] - the number of pixels in the overlap</param>
		///   <returns>0 if OK, 1 on error.</returns>
		public static int boxOverlapArea(
						Box box1,
						Box box2,
						out int parea)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxOverlapArea(box1.Pointer, box2.Pointer, out  parea);
			return _Result;
		}

		// boxfunc1.c (853, 1)
		// boxaHandleOverlaps(boxas, op, range, min_overlap, max_ratio, pnamap) as Boxa
		// boxaHandleOverlaps(BOXA *, l_int32, l_int32, l_float32, l_float32, NUMA **) as BOXA *
		///  <summary>
		/// (1) For all n(n-1)/2 box pairings, if two boxes overlap, either:
		/// (a) op == L_COMBINE: get the bounding region for the two,
		/// replace the larger with the bounding region, and remove
		/// the smaller of the two, or
		/// (b) op == L_REMOVE_SMALL: just remove the smaller.<para/>
		///
		/// (2) If boxas is 2D sorted, range can be small, but if it is
		/// not spatially sorted, range should be large to allow all
		/// pairwise comparisons to be made.<para/>
		///
		/// (3) The %min_overlap parameter allows ignoring small overlaps.
		/// If %min_overlap == 1.0, only boxes fully contained in larger
		/// boxes can be considered for removal if %min_overlap == 0.0,
		/// this constraint is ignored.<para/>
		///
		/// (4) The %max_ratio parameter allows ignoring overlaps between
		/// boxes that are not too different in size.  If %max_ratio == 0.0,
		/// no boxes can be removed if %max_ratio == 1.0, this constraint
		/// is ignored.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaHandleOverlaps/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="op">[in] - L_COMBINE, L_REMOVE_SMALL</param>
		///  <param name="range">[in] - is greater  0, forward distance over which overlaps are checked</param>
		///  <param name="min_overlap">[in] - minimum fraction of smaller box required for overlap to count 0.0 to ignore</param>
		///  <param name="max_ratio">[in] - maximum fraction of small/large areas for overlap to count 1.0 to ignore</param>
		///  <param name="pnamap">[out][optional] - combining map</param>
		///   <returns>boxad, or NULL on error.</returns>
		public static Boxa boxaHandleOverlaps(
						Boxa boxas,
						int op,
						int range,
						Single min_overlap,
						Single max_ratio,
						out Numa pnamap)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pnamapPtr = IntPtr.Zero;
			IntPtr _Result = Natives.boxaHandleOverlaps(boxas.Pointer,   op,   range,   min_overlap,   max_ratio, out pnamapPtr);
			if (pnamapPtr == IntPtr.Zero) {pnamap = null;} else { pnamap = new Numa(pnamapPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (973, 1)
		// boxSeparationDistance(box1, box2, ph_sep, pv_sep) as int
		// boxSeparationDistance(BOX *, BOX *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This measures horizontal and vertical separation of the
		/// two boxes.  If the boxes are touching but have no pixels
		/// in common, the separation is 0.  If the boxes overlap by
		/// a distance d, the returned separation is -d.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSeparationDistance/*"/>
		///  <param name="box1">[in] - two boxes, in any order</param>
		///  <param name="box2">[in] - two boxes, in any order</param>
		///  <param name="ph_sep">[out][optional] - horizontal separation</param>
		///  <param name="pv_sep">[out][optional] - vertical separation</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxSeparationDistance(
						Box box1,
						Box box2,
						out int ph_sep,
						out int pv_sep)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxSeparationDistance(box1.Pointer, box2.Pointer, out  ph_sep, out  pv_sep);
			return _Result;
		}

		// boxfunc1.c (1029, 1)
		// boxCompareSize(box1, box2, type, prel) as int
		// boxCompareSize(BOX *, BOX *, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) We're re-using the SORT enum for these comparisons.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCompareSize/*"/>
		///  <param name="box1">[in] - </param>
		///  <param name="box2">[in] - </param>
		///  <param name="type">[in] - L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA,</param>
		///  <param name="prel">[out] - 1 if box1  is greater  box2, 0 if the same, -1 if box1  is smaller box2</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxCompareSize(
						Box box1,
						Box box2,
						int type,
						out int prel)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxCompareSize(box1.Pointer, box2.Pointer,   type, out  prel);
			return _Result;
		}

		// boxfunc1.c (1080, 1)
		// boxContainsPt(box, x, y, pcontains) as int
		// boxContainsPt(BOX *, l_float32, l_float32, l_int32 *) as l_ok
		///  <summary>
		/// boxContainsPt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxContainsPt/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="x">[in] - a point</param>
		///  <param name="y">[in] - a point</param>
		///  <param name="pcontains">[out] - 1 if box contains point 0 otherwise</param>
		///   <returns>0 if OK, 1 on error.</returns>
		public static int boxContainsPt(
						Box box,
						Single x,
						Single y,
						out int pcontains)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxContainsPt(box.Pointer,   x,   y, out  pcontains);
			return _Result;
		}

		// boxfunc1.c (1115, 1)
		// boxaGetNearestToPt(boxa, x, y) as Box
		// boxaGetNearestToPt(BOXA *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) Uses euclidean distance between centroid and point.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetNearestToPt/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="x">[in] - point</param>
		///  <param name="y">[in] - point</param>
		///   <returns>box with centroid closest to the given point [x,y], or NULL if no boxes in boxa</returns>
		public static Box boxaGetNearestToPt(
						Boxa boxa,
						int x,
						int y)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaGetNearestToPt(boxa.Pointer,   x,   y);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (1167, 1)
		// boxaGetNearestToLine(boxa, x, y) as Box
		// boxaGetNearestToLine(BOXA *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) For a horizontal line at some value y, get the minimum of the
		/// distance |yc - y| from the box centroid yc value to y
		/// likewise minimize |xc - x| for a vertical line at x.<para/>
		///
		/// (2) Input y  is smaller 0, x greater or equal 0 to indicate a vertical line at x, and
		/// x  is smaller 0, y greater or equal 0 for a horizontal line at y.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetNearestToLine/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="x">[in] - (y = -1 for vertical line x = -1 for horiz line)</param>
		///  <param name="y">[in] - (y = -1 for vertical line x = -1 for horiz line)</param>
		///   <returns>box with centroid closest to the given line, or NULL if no boxes in boxa</returns>
		public static Box boxaGetNearestToLine(
						Boxa boxa,
						int x,
						int y)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaGetNearestToLine(boxa.Pointer,   x,   y);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (1224, 1)
		// boxaFindNearestBoxes(boxa, dist_select, range, pnaaindex, pnaadist) as int
		// boxaFindNearestBoxes(BOXA *, l_int32, l_int32, NUMAA **, NUMAA **) as l_ok
		///  <summary>
		/// (1) See boxaGetNearestByDirection() for usage of %dist_select
		/// and %range.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaFindNearestBoxes/*"/>
		///  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
		///  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
		///  <param name="range">[in] - search distance from box i use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
		///  <param name="pnaaindex">[out] - for each box in %boxa, contains a numa of 4 box indices (per direction) of the nearest box</param>
		///  <param name="pnaadist">[out] - for each box in %boxa, this contains a numa</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaFindNearestBoxes(
						Boxa boxa,
						int dist_select,
						int range,
						out Numaa pnaaindex,
						out Numaa pnaadist)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pnaaindexPtr = IntPtr.Zero;
			IntPtr pnaadistPtr = IntPtr.Zero;
			int _Result = Natives.boxaFindNearestBoxes(boxa.Pointer,   dist_select,   range, out pnaaindexPtr, out pnaadistPtr);
			if (pnaaindexPtr == IntPtr.Zero) {pnaaindex = null;} else { pnaaindex = new Numaa(pnaaindexPtr); };
			if (pnaadistPtr == IntPtr.Zero) {pnaadist = null;} else { pnaadist = new Numaa(pnaadistPtr); };

			return _Result;
		}

		// boxfunc1.c (1305, 1)
		// boxaGetNearestByDirection(boxa, i, dir, dist_select, range, pindex, pdist) as int
		// boxaGetNearestByDirection(BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) For efficiency, use a LR/TD sorted %boxa, which can be
		/// made by flattening a 2D sorted boxaa.  In that case,
		/// %range can be some positive integer like 50.<para/>
		///
		/// (2) If boxes overlap, the distance will be  is smaller 0.  Use %dist_select
		/// to determine if these should count or not.  If L_ALL, then
		/// one box will match as the nearest to another in 2 or more
		/// directions.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetNearestByDirection/*"/>
		///  <param name="boxa">[in] - either unsorted, or 2D sorted in LR/TB scan order</param>
		///  <param name="i">[in] - box we test against</param>
		///  <param name="dir">[in] - direction to look: L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
		///  <param name="dist_select">[in] - L_NON_NEGATIVE, L_ALL</param>
		///  <param name="range">[in] - search distance from box i use 0 to search entire boxa (e.g., if it's not 2D sorted)</param>
		///  <param name="pindex">[out] - index in boxa of nearest box with overlapping coordinates in the indicated direction -1 if there is no box</param>
		///  <param name="pdist">[out] - distance of the nearest box in the indicated direction 100000 if no box</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaGetNearestByDirection(
						Boxa boxa,
						int i,
						int dir,
						int dist_select,
						int range,
						out int pindex,
						out int pdist)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetNearestByDirection(boxa.Pointer,   i,   dir,   dist_select,   range, out  pindex, out  pdist);
			return _Result;
		}

		// boxfunc1.c (1444, 1)
		// boxGetCenter(box, pcx, pcy) as int
		// boxGetCenter(BOX *, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// boxGetCenter()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetCenter/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="pcx">[out] - location of center of box</param>
		///  <param name="pcy">[out] - location of center of box</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxGetCenter(
						Box box,
						out Single pcx,
						out Single pcy)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxGetCenter(box.Pointer, out  pcx, out  pcy);
			return _Result;
		}

		// boxfunc1.c (1485, 1)
		// boxIntersectByLine(box, x, y, slope, px1, py1, px2, py2, pn) as int
		// boxIntersectByLine(BOX *, l_int32, l_int32, l_float32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) If the intersection is at only one point (a corner), the
		/// coordinates are returned in (x1, y1).<para/>
		///
		/// (2) Represent a vertical line by one with a large but finite slope.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxIntersectByLine/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="x">[in] - point that line goes through</param>
		///  <param name="y">[in] - point that line goes through</param>
		///  <param name="slope">[in] - of line</param>
		///  <param name="px1">[out] - 1st point of intersection with box</param>
		///  <param name="py1">[out] - 1st point of intersection with box</param>
		///  <param name="px2">[out] - 2nd point of intersection with box</param>
		///  <param name="py2">[out] - 2nd point of intersection with box</param>
		///  <param name="pn">[out] - number of points of intersection</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxIntersectByLine(
						Box box,
						int x,
						int y,
						Single slope,
						out int px1,
						out int py1,
						out int px2,
						out int py2,
						out int pn)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxIntersectByLine(box.Pointer,   x,   y,   slope, out  px1, out  py1, out  px2, out  py2, out  pn);
			return _Result;
		}

		// boxfunc1.c (1587, 1)
		// boxClipToRectangle(box, wi, hi) as Box
		// boxClipToRectangle(BOX *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This can be used to clip a rectangle to an image.
		/// The clipping rectangle is assumed to have a UL corner at (0, 0),
		/// and a LR corner at (wi - 1, hi - 1).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxClipToRectangle/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="wi">[in] - rectangle representing image</param>
		///  <param name="hi">[in] - rectangle representing image</param>
		///   <returns>part of box within given rectangle, or NULL on error or if box is entirely outside the rectangle</returns>
		public static Box boxClipToRectangle(
						Box box,
						int wi,
						int hi)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxClipToRectangle(box.Pointer,   wi,   hi);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (1644, 1)
		// boxClipToRectangleParams(box, w, h, pxstart, pystart, pxend, pyend, pbw, pbh) as int
		// boxClipToRectangleParams(BOX *, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The return value should be checked.  If it is 1, the
		/// returned parameter values are bogus.<para/>
		///
		/// (2) This simplifies the selection of pixel locations within
		/// a given rectangle:
		/// for (i = ystart i  is smaller yend i++ {
		/// ...
		/// for (j = xstart j  is smaller xend j++ {
		/// ....
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxClipToRectangleParams/*"/>
		///  <param name="box">[in][optional] - requested box can be null</param>
		///  <param name="w">[in] - clipping box size typ. the size of an image</param>
		///  <param name="h">[in] - clipping box size typ. the size of an image</param>
		///  <param name="pxstart">[out] - start x coordinate</param>
		///  <param name="pystart">[out] - start y coordinate</param>
		///  <param name="pxend">[out] - one pixel beyond clipping box</param>
		///  <param name="pyend">[out] - one pixel beyond clipping box</param>
		///  <param name="pbw">[out][optional] - clipped width</param>
		///  <param name="pbh">[out][optional] - clipped height</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int boxClipToRectangleParams(
						Box box,
						int w,
						int h,
						out int pxstart,
						out int pystart,
						out int pxend,
						out int pyend,
						out int pbw,
						out int pbh)
		{
			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.boxClipToRectangleParams(boxPtr,   w,   h, out  pxstart, out  pystart, out  pxend, out  pyend, out  pbw, out  pbh);
			return _Result;
		}

		// boxfunc1.c (1706, 1)
		// boxRelocateOneSide(boxd, boxs, loc, sideflag) as Box
		// boxRelocateOneSide(BOX *, BOX *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) Set boxd == NULL to get new box boxd == boxs for in-place
		/// or otherwise to resize existing boxd.<para/>
		///
		/// (2) For usage, suggest one of these:
		/// boxd = boxRelocateOneSide(NULL, boxs, ...) // new
		/// boxRelocateOneSide(boxs, boxs, ...)  // in-place
		/// boxRelocateOneSide(boxd, boxs, ...)  // other
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxRelocateOneSide/*"/>
		///  <param name="boxd">[in][optional] - this can be null, equal to boxs, or different from boxs</param>
		///  <param name="boxs">[in] - starting box to have one side relocated</param>
		///  <param name="loc">[in] - new location of the side that is changing</param>
		///  <param name="sideflag">[in] - L_FROM_LEFT, etc., indicating the side that moves</param>
		///   <returns>boxd, or NULL on error or if the computed boxd has width or height smaller or equal 0.</returns>
		public static Box boxRelocateOneSide(
						Box boxd,
						Box boxs,
						int loc,
						int sideflag)
		{
			if (boxs == null) {throw new ArgumentNullException  ("boxs cannot be Nothing");}

			IntPtr boxdPtr = IntPtr.Zero; 	if (boxd != null) {boxdPtr = boxd.Pointer;}
			IntPtr _Result = Natives.boxRelocateOneSide(boxdPtr, boxs.Pointer,   loc,   sideflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (1750, 1)
		// boxaAdjustSides(boxas, delleft, delright, deltop, delbot) as Boxa
		// boxaAdjustSides(BOXA *, l_int32, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) New box dimensions are cropped at left and top to x greater or equal 0 and y greater or equal 0.<para/>
		///
		/// (2) If the width or height of a box goes to 0, we generate a box with
		/// w == 1 and h == 1, as a placeholder.<para/>
		///
		/// (3) See boxAdjustSides().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAdjustSides/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="delleft">[in] - changes in location of each side for each box</param>
		///  <param name="delright">[in] - changes in location of each side for each box</param>
		///  <param name="deltop">[in] - changes in location of each side for each box</param>
		///  <param name="delbot">[in] - changes in location of each side for each box</param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaAdjustSides(
						Boxa boxas,
						int delleft,
						int delright,
						int deltop,
						int delbot)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaAdjustSides(boxas.Pointer,   delleft,   delright,   deltop,   delbot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (1807, 1)
		// boxAdjustSides(boxd, boxs, delleft, delright, deltop, delbot) as Box
		// boxAdjustSides(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) Set boxd == NULL to get new box boxd == boxs for in-place
		/// or otherwise to resize existing boxd.<para/>
		///
		/// (2) For usage, suggest one of these:
		/// boxd = boxAdjustSides(NULL, boxs, ...) // new
		/// boxAdjustSides(boxs, boxs, ...)  // in-place
		/// boxAdjustSides(boxd, boxs, ...)  // other<para/>
		///
		/// (3) New box dimensions are cropped at left and top to x greater or equal 0 and y greater or equal 0.<para/>
		///
		/// (4) For example, to expand in-place by 20 pixels on each side, use
		/// boxAdjustSides(box, box, -20, 20, -20, 20)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxAdjustSides/*"/>
		///  <param name="boxd">[in][optional] - this can be null, equal to boxs, or different from boxs</param>
		///  <param name="boxs">[in] - starting box to have sides adjusted</param>
		///  <param name="delleft">[in] - changes in location of each side</param>
		///  <param name="delright">[in] - changes in location of each side</param>
		///  <param name="deltop">[in] - changes in location of each side</param>
		///  <param name="delbot">[in] - changes in location of each side</param>
		///   <returns>boxd, or NULL on error or if the computed boxd has width or height smaller or equal 0.</returns>
		public static Box boxAdjustSides(
						Box boxd,
						Box boxs,
						int delleft,
						int delright,
						int deltop,
						int delbot)
		{
			if (boxs == null) {throw new ArgumentNullException  ("boxs cannot be Nothing");}

			IntPtr boxdPtr = IntPtr.Zero; 	if (boxd != null) {boxdPtr = boxd.Pointer;}
			IntPtr _Result = Natives.boxAdjustSides(boxdPtr, boxs.Pointer,   delleft,   delright,   deltop,   delbot);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc1.c (1859, 1)
		// boxaSetSide(boxad, boxas, side, val, thresh) as Boxa
		// boxaSetSide(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) Sets the given side of each box.  Use boxad == NULL for a new
		/// boxa, and boxad == boxas for in-place.<para/>
		///
		/// (2) Use one of these:
		/// boxad = boxaSetSide(NULL, boxas, ...) // new
		/// boxaSetSide(boxas, boxas, ...)  // in-place
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSetSide/*"/>
		///  <param name="boxad">[in] - use NULL to get a new one same as boxas for in-place</param>
		///  <param name="boxas">[in] - </param>
		///  <param name="side">[in] - L_SET_LEFT, L_SET_RIGHT, L_SET_TOP, L_SET_BOT</param>
		///  <param name="val">[in] - location to set for given side, for each box</param>
		///  <param name="thresh">[in] - min abs difference to cause resetting to %val</param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaSetSide(
						Boxa boxad,
						Boxa boxas,
						int side,
						int val,
						int thresh)
		{
			if (boxad == null) {throw new ArgumentNullException  ("boxad cannot be Nothing");}

			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaSetSide(boxad.Pointer, boxas.Pointer,   side,   val,   thresh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (1932, 1)
		// boxaAdjustWidthToTarget(boxad, boxas, sides, target, thresh) as Boxa
		// boxaAdjustWidthToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) Conditionally adjusts the width of each box, by moving
		/// the indicated edges (left and/or right) if the width differs
		/// by %thresh or more from %target.<para/>
		///
		/// (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.
		/// Use one of these:
		/// boxad = boxaAdjustWidthToTarget(NULL, boxas, ...) // new
		/// boxaAdjustWidthToTarget(boxas, boxas, ...)  // in-place
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAdjustWidthToTarget/*"/>
		///  <param name="boxad">[in] - use NULL to get a new one same as boxas for in-place</param>
		///  <param name="boxas">[in] - </param>
		///  <param name="sides">[in] - L_ADJUST_LEFT, L_ADJUST_RIGHT, L_ADJUST_LEFT_AND_RIGHT</param>
		///  <param name="target">[in] - target width if differs by more than thresh</param>
		///  <param name="thresh">[in] - min abs difference in width to cause adjustment</param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaAdjustWidthToTarget(
						Boxa boxad,
						Boxa boxas,
						int sides,
						int target,
						int thresh)
		{
			if (boxad == null) {throw new ArgumentNullException  ("boxad cannot be Nothing");}

			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaAdjustWidthToTarget(boxad.Pointer, boxas.Pointer,   sides,   target,   thresh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (1999, 1)
		// boxaAdjustHeightToTarget(boxad, boxas, sides, target, thresh) as Boxa
		// boxaAdjustHeightToTarget(BOXA *, BOXA *, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) Conditionally adjusts the height of each box, by moving
		/// the indicated edges (top and/or bot) if the height differs
		/// by %thresh or more from %target.<para/>
		///
		/// (2) Use boxad == NULL for a new boxa, and boxad == boxas for in-place.
		/// Use one of these:
		/// boxad = boxaAdjustHeightToTarget(NULL, boxas, ...) // new
		/// boxaAdjustHeightToTarget(boxas, boxas, ...)  // in-place
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAdjustHeightToTarget/*"/>
		///  <param name="boxad">[in] - use NULL to get a new one</param>
		///  <param name="boxas">[in] - </param>
		///  <param name="sides">[in] - L_ADJUST_TOP, L_ADJUST_BOT, L_ADJUST_TOP_AND_BOT</param>
		///  <param name="target">[in] - target height if differs by more than thresh</param>
		///  <param name="thresh">[in] - min abs difference in height to cause adjustment</param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaAdjustHeightToTarget(
						Boxa boxad,
						Boxa boxas,
						int sides,
						int target,
						int thresh)
		{
			if (boxad == null) {throw new ArgumentNullException  ("boxad cannot be Nothing");}

			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaAdjustHeightToTarget(boxad.Pointer, boxas.Pointer,   sides,   target,   thresh);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc1.c (2057, 1)
		// boxEqual(box1, box2, psame) as int
		// boxEqual(BOX *, BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxEqual()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxEqual/*"/>
		///  <param name="box1">[in] - </param>
		///  <param name="box2">[in] - </param>
		///  <param name="psame">[out] - 1 if equal 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxEqual(
						Box box1,
						Box box2,
						out int psame)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxEqual(box1.Pointer, box2.Pointer, out  psame);
			return _Result;
		}

		// boxfunc1.c (2104, 1)
		// boxaEqual(boxa1, boxa2, maxdist, pnaindex, psame) as int
		// boxaEqual(BOXA *, BOXA *, l_int32, NUMA **, l_int32 *) as l_ok
		///  <summary>
		/// (1) The two boxa are the "same" if they contain the same
		/// boxes and each box is within %maxdist of its counterpart
		/// in their positions within the boxa.  This allows for
		/// small rearrangements.  Use 0 for maxdist if the boxa
		/// must be identical.<para/>
		///
		/// (2) This applies only to geometry and ordering refcounts
		/// are not considered.<para/>
		///
		/// (3) %maxdist allows some latitude in the ordering of the boxes.
		/// For the boxa to be the "same", corresponding boxes must
		/// be within %maxdist of each other.  Note that for large
		/// %maxdist, we should use a hash function for efficiency.<para/>
		///
		/// (4) naindex[i] gives the position of the box in boxa2 that
		/// corresponds to box i in boxa1.  It is only returned if the
		/// boxa are equal.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaEqual/*"/>
		///  <param name="boxa1">[in] - </param>
		///  <param name="boxa2">[in] - </param>
		///  <param name="maxdist">[in] - </param>
		///  <param name="pnaindex">[out][optional] - index array of correspondences</param>
		///  <param name="psame">[out] - (1 if equal 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaEqual(
						Boxa boxa1,
						Boxa boxa2,
						int maxdist,
						out Numa pnaindex,
						out int psame)
		{
			if (boxa1 == null) {throw new ArgumentNullException  ("boxa1 cannot be Nothing");}

			if (boxa2 == null) {throw new ArgumentNullException  ("boxa2 cannot be Nothing");}

			IntPtr pnaindexPtr = IntPtr.Zero;
			int _Result = Natives.boxaEqual(boxa1.Pointer, boxa2.Pointer,   maxdist, out pnaindexPtr, out  psame);
			if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };

			return _Result;
		}

		// boxfunc1.c (2183, 1)
		// boxSimilar(box1, box2, leftdiff, rightdiff, topdiff, botdiff, psimilar) as int
		// boxSimilar(BOX *, BOX *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) The values of leftdiff (etc) are the maximum allowed deviations
		/// between the locations of the left (etc) sides.  If any side
		/// pairs differ by more than this amount, the boxes are not similar.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSimilar/*"/>
		///  <param name="box1">[in] - </param>
		///  <param name="box2">[in] - </param>
		///  <param name="leftdiff">[in] - </param>
		///  <param name="rightdiff">[in] - </param>
		///  <param name="topdiff">[in] - </param>
		///  <param name="botdiff">[in] - </param>
		///  <param name="psimilar">[out] - 1 if similar 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxSimilar(
						Box box1,
						Box box2,
						int leftdiff,
						int rightdiff,
						int topdiff,
						int botdiff,
						out int psimilar)
		{
			if (box1 == null) {throw new ArgumentNullException  ("box1 cannot be Nothing");}

			if (box2 == null) {throw new ArgumentNullException  ("box2 cannot be Nothing");}

			int _Result = Natives.boxSimilar(box1.Pointer, box2.Pointer,   leftdiff,   rightdiff,   topdiff,   botdiff, out  psimilar);
			return _Result;
		}

		// boxfunc1.c (2238, 1)
		// boxaSimilar(boxa1, boxa2, leftdiff, rightdiff, topdiff, botdiff, debug, psimilar, pnasim) as int
		// boxaSimilar(BOXA *, BOXA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, NUMA **) as l_ok
		///  <summary>
		/// (1) See boxSimilar() for parameter usage.<para/>
		///
		/// (2) Corresponding boxes are taken in order in the two boxa.<para/>
		///
		/// (3) %nasim is an indicator array with a (0/1) for each box pair.<para/>
		///
		/// (4) With %nasim or debug == 1, boxes continue to be tested
		/// after failure.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSimilar/*"/>
		///  <param name="boxa1">[in] - </param>
		///  <param name="boxa2">[in] - </param>
		///  <param name="leftdiff">[in] - </param>
		///  <param name="rightdiff">[in] - </param>
		///  <param name="topdiff">[in] - </param>
		///  <param name="botdiff">[in] - </param>
		///  <param name="debug">[in] - output details of non-similar boxes</param>
		///  <param name="psimilar">[out] - 1 if similar 0 otherwise</param>
		///  <param name="pnasim">[out][optional] - na containing 1 if similar else 0</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaSimilar(
						Boxa boxa1,
						Boxa boxa2,
						int leftdiff,
						int rightdiff,
						int topdiff,
						int botdiff,
						Enumerations.DebugOnOff debug,
						out int psimilar,
						out Numa pnasim)
		{
			if (boxa1 == null) {throw new ArgumentNullException  ("boxa1 cannot be Nothing");}

			if (boxa2 == null) {throw new ArgumentNullException  ("boxa2 cannot be Nothing");}

			IntPtr pnasimPtr = IntPtr.Zero;
			int _Result = Natives.boxaSimilar(boxa1.Pointer, boxa2.Pointer,   leftdiff,   rightdiff,   topdiff,   botdiff,  (int) debug, out  psimilar, out pnasimPtr);
			if (pnasimPtr == IntPtr.Zero) {pnasim = null;} else { pnasim = new Numa(pnasimPtr); };

			return _Result;
		}

		// boxfunc1.c (2312, 1)
		// boxaJoin(boxad, boxas, istart, iend) as int
		// boxaJoin(BOXA *, BOXA *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This appends a clone of each indicated box in boxas to boxad<para/>
		///
		/// (2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
		///
		/// (3) iend  is smaller 0 means 'read to the end'<para/>
		///
		/// (4) if boxas == NULL or has no boxes, this is a no-op.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaJoin/*"/>
		///  <param name="boxad">[in] - dest boxa add to this one</param>
		///  <param name="boxas">[in] - source boxa add from this one</param>
		///  <param name="istart">[in] - starting index in boxas</param>
		///  <param name="iend">[in] - ending index in boxas use -1 to cat all</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaJoin(
						Boxa boxad,
						Boxa boxas,
						int istart,
						int iend)
		{
			if (boxad == null) {throw new ArgumentNullException  ("boxad cannot be Nothing");}

			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			int _Result = Natives.boxaJoin(boxad.Pointer, boxas.Pointer,   istart,   iend);
			return _Result;
		}

		// boxfunc1.c (2361, 1)
		// boxaaJoin(baad, baas, istart, iend) as int
		// boxaaJoin(BOXAA *, BOXAA *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) This appends a clone of each indicated boxa in baas to baad<para/>
		///
		/// (2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
		///
		/// (3) iend  is smaller 0 means 'read to the end'<para/>
		///
		/// (4) if baas == NULL, this is a no-op.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaJoin/*"/>
		///  <param name="baad">[in] - dest boxaa add to this one</param>
		///  <param name="baas">[in] - source boxaa add from this one</param>
		///  <param name="istart">[in] - starting index in baas</param>
		///  <param name="iend">[in] - ending index in baas use -1 to cat all</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaJoin(
						Boxaa baad,
						Boxaa baas,
						int istart,
						int iend)
		{
			if (baad == null) {throw new ArgumentNullException  ("baad cannot be Nothing");}

			if (baas == null) {throw new ArgumentNullException  ("baas cannot be Nothing");}

			int _Result = Natives.boxaaJoin(baad.Pointer, baas.Pointer,   istart,   iend);
			return _Result;
		}

		// boxfunc1.c (2411, 1)
		// boxaSplitEvenOdd(boxa, fillflag, pboxae, pboxao) as int
		// boxaSplitEvenOdd(BOXA *, l_int32, BOXA **, BOXA **) as l_ok
		///  <summary>
		/// (1) If %fillflag == 1, boxae has copies of the even boxes
		/// in their original location, and nvalid boxes are placed
		/// in the odd array locations.  And v.v.<para/>
		///
		/// (2) If %fillflag == 0, boxae has only copies of the even boxes.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSplitEvenOdd/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="fillflag">[in] - 1 to put invalid boxes in place 0 to omit</param>
		///  <param name="pboxae">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
		///  <param name="pboxao">[out] - save even and odd boxes in their separate boxa, setting the other type to invalid boxes.</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaSplitEvenOdd(
						Boxa boxa,
						int fillflag,
						out Boxa pboxae,
						out Boxa pboxao)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pboxaePtr = IntPtr.Zero;
			IntPtr pboxaoPtr = IntPtr.Zero;
			int _Result = Natives.boxaSplitEvenOdd(boxa.Pointer,   fillflag, out pboxaePtr, out pboxaoPtr);
			if (pboxaePtr == IntPtr.Zero) {pboxae = null;} else { pboxae = new Boxa(pboxaePtr); };
			if (pboxaoPtr == IntPtr.Zero) {pboxao = null;} else { pboxao = new Boxa(pboxaoPtr); };

			return _Result;
		}

		// boxfunc1.c (2475, 1)
		// boxaMergeEvenOdd(boxae, boxao, fillflag) as Boxa
		// boxaMergeEvenOdd(BOXA *, BOXA *, l_int32) as BOXA *
		///  <summary>
		/// (1) This is essentially the inverse of boxaSplitEvenOdd().
		/// Typically, boxae and boxao were generated by boxaSplitEvenOdd(),
		/// and the value of %fillflag needs to be the same in both calls.<para/>
		///
		/// (2) If %fillflag == 1, both boxae and boxao are of the same size
		/// otherwise boxae may have one more box than boxao.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaMergeEvenOdd/*"/>
		///  <param name="boxae">[in] - boxes to go in even positions in merged boxa</param>
		///  <param name="boxao">[in] - boxes to go in odd positions in merged boxa</param>
		///  <param name="fillflag">[in] - 1 if there are invalid boxes in placeholders</param>
		///   <returns>boxad merged, or NULL on error</returns>
		public static Boxa boxaMergeEvenOdd(
						Boxa boxae,
						Boxa boxao,
						int fillflag)
		{
			if (boxae == null) {throw new ArgumentNullException  ("boxae cannot be Nothing");}

			if (boxao == null) {throw new ArgumentNullException  ("boxao cannot be Nothing");}

			IntPtr _Result = Natives.boxaMergeEvenOdd(boxae.Pointer, boxao.Pointer,   fillflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}


	}
}
