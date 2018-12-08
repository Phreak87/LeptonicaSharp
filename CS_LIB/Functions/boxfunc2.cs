using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// boxfunc2.c (91, 1)
		// boxaTransform(boxas, shiftx, shifty, scalex, scaley) as Boxa
		// boxaTransform(BOXA *, l_int32, l_int32, l_float32, l_float32) as BOXA *
		///  <summary>
		/// (1) This is a very simple function that first shifts, then scales.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaTransform/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="shiftx">[in] - </param>
		///  <param name="shifty">[in] - </param>
		///  <param name="scalex">[in] - </param>
		///  <param name="scaley">[in] - </param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaTransform(
						Boxa boxas,
						int shiftx,
						int shifty,
						Single scalex,
						Single scaley)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaTransform(boxas.Pointer,   shiftx,   shifty,   scalex,   scaley);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (137, 1)
		// boxTransform(box, shiftx, shifty, scalex, scaley) as Box
		// boxTransform(BOX *, l_int32, l_int32, l_float32, l_float32) as BOX *
		///  <summary>
		/// (1) This is a very simple function that first shifts, then scales.<para/>
		///
		/// (2) If the box is invalid, a new invalid box is returned.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxTransform/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="shiftx">[in] - </param>
		///  <param name="shifty">[in] - </param>
		///  <param name="scalex">[in] - </param>
		///  <param name="scaley">[in] - </param>
		///   <returns>boxd, or NULL on error</returns>
		public static Box boxTransform(
						Box box,
						int shiftx,
						int shifty,
						Single scalex,
						Single scaley)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxTransform(box.Pointer,   shiftx,   shifty,   scalex,   scaley);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc2.c (192, 1)
		// boxaTransformOrdered(boxas, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order) as Boxa
		// boxaTransformOrdered(BOXA *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32, l_int32) as BOXA *
		///  <summary>
		/// (1) This allows a sequence of linear transforms on each box.
		/// the transforms are from the affine set, composed of
		/// shift, scaling and rotation, and the order of the
		/// transforms is specified.<para/>
		///
		/// (2) Although these operations appear to be on an infinite
		/// 2D plane, in practice the region of interest is clipped
		/// to a finite image.  The center of rotation is usually taken
		/// with respect to the image (either the UL corner or the
		/// center).  A translation can have two very different effects:
		/// (a) Moves the boxes across the fixed image region.
		/// (b) Moves the image origin, causing a change in the image
		/// region and an opposite effective translation of the boxes.
		/// This function should only be used for (a), where the image
		/// region is fixed on translation.  If the image region is
		/// changed by the translation, use instead the functions
		/// in affinecompose.c, where the image region and rotation
		/// center can be computed from the actual clipping due to
		/// translation of the image origin.<para/>
		///
		/// (3) See boxTransformOrdered() for usage and implementation details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaTransformOrdered/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="shiftx">[in] - </param>
		///  <param name="shifty">[in] - </param>
		///  <param name="scalex">[in] - </param>
		///  <param name="scaley">[in] - </param>
		///  <param name="xcen">[in] - center of rotation</param>
		///  <param name="ycen">[in] - center of rotation</param>
		///  <param name="angle">[in] - in radians clockwise is positive</param>
		///  <param name="order">[in] - one of 6 combinations: L_TR_SC_RO, ...</param>
		///   <returns>boxd, or NULL on error</returns>
		public static Boxa boxaTransformOrdered(
						Boxa boxas,
						int shiftx,
						int shifty,
						Single scalex,
						Single scaley,
						int xcen,
						int ycen,
						Single angle,
						int order)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaTransformOrdered(boxas.Pointer,   shiftx,   shifty,   scalex,   scaley,   xcen,   ycen,   angle,   order);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (280, 1)
		// boxTransformOrdered(boxs, shiftx, shifty, scalex, scaley, xcen, ycen, angle, order) as Box
		// boxTransformOrdered(BOX *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_float32, l_int32) as BOX *
		///  <summary>
		/// (1) This allows a sequence of linear transforms, composed of
		/// shift, scaling and rotation, where the order of the
		/// transforms is specified.<para/>
		///
		/// (2) The rotation is taken about a point specified by (xcen, ycen).
		/// Let the components of the vector from the center of rotation
		/// to the box center be (xdif, ydif):
		/// xdif = (bx + 0.5  bw) - xcen
		/// ydif = (by + 0.5  bh) - ycen
		/// Then the box center after rotation has new components:
		/// bxcen = xcen + xdif  cosa + ydif  sina
		/// bycen = ycen + ydif  cosa - xdif  sina
		/// where cosa and sina are the cos and sin of the angle,
		/// and the enclosing box for the rotated box has size:
		/// rw = |bw  cosa| + |bh  sina|
		/// rh = |bh  cosa| + |bw  sina|
		/// where bw and bh are the unrotated width and height.
		/// Then the box UL corner (rx, ry) is
		/// rx = bxcen - 0.5  rw
		/// ry = bycen - 0.5  rh<para/>
		///
		/// (3) The center of rotation specified by args %xcen and %ycen
		/// is the point BEFORE any translation or scaling.  If the
		/// rotation is not the first operation, this function finds
		/// the actual center at the time of rotation.  It does this
		/// by making the following assumptions:<para/>
		///
		/// (1) Any scaling is with respect to the UL corner, so
		/// that the center location scales accordingly.<para/>
		///
		/// (2) A translation does not affect the center of
		/// the image it just moves the boxes.
		/// We always use assumption (1).  However, assumption (2)
		/// will be incorrect if the apparent translation is due
		/// to a clipping operation that, in effect, moves the
		/// origin of the image.  In that case, you should NOT use
		/// these simple functions.  Instead, use the functions
		/// in affinecompose.c, where the rotation center can be
		/// computed from the actual clipping due to translation
		/// of the image origin.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxTransformOrdered/*"/>
		///  <param name="boxs">[in] - </param>
		///  <param name="shiftx">[in] - </param>
		///  <param name="shifty">[in] - </param>
		///  <param name="scalex">[in] - </param>
		///  <param name="scaley">[in] - </param>
		///  <param name="xcen">[in] - center of rotation</param>
		///  <param name="ycen">[in] - center of rotation</param>
		///  <param name="angle">[in] - in radians clockwise is positive</param>
		///  <param name="order">[in] - one of 6 combinations: L_TR_SC_RO, ...</param>
		///   <returns>boxd, or NULL on error</returns>
		public static Box boxTransformOrdered(
						Box boxs,
						int shiftx,
						int shifty,
						Single scalex,
						Single scaley,
						int xcen,
						int ycen,
						Single angle,
						int order)
		{
			if (boxs == null) {throw new ArgumentNullException  ("boxs cannot be Nothing");}

			IntPtr _Result = Natives.boxTransformOrdered(boxs.Pointer,   shiftx,   shifty,   scalex,   scaley,   xcen,   ycen,   angle,   order);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc2.c (454, 1)
		// boxaRotateOrth(boxas, w, h, rotation) as Boxa
		// boxaRotateOrth(BOXA *, l_int32, l_int32, l_int32) as BOXA *
		///  <summary>
		/// (1) See boxRotateOrth() for details.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRotateOrth/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="w">[in] - of image in which the boxa is embedded</param>
		///  <param name="h">[in] - of image in which the boxa is embedded</param>
		///  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg all rotations are clockwise</param>
		///   <returns>boxad, or NULL on error</returns>
		public static Boxa boxaRotateOrth(
						Boxa boxas,
						int w,
						int h,
						int rotation)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaRotateOrth(boxas.Pointer,   w,   h,   rotation);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (506, 1)
		// boxRotateOrth(box, w, h, rotation) as Box
		// boxRotateOrth(BOX *, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) Rotate the image with the embedded box by the specified amount.<para/>
		///
		/// (2) After rotation, the rotated box is always measured with
		/// respect to the UL corner of the image.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxRotateOrth/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="w">[in] - of image in which the box is embedded</param>
		///  <param name="h">[in] - of image in which the box is embedded</param>
		///  <param name="rotation">[in] - 0 = noop, 1 = 90 deg, 2 = 180 deg, 3 = 270 deg all rotations are clockwise</param>
		///   <returns>boxd, or NULL on error</returns>
		public static Box boxRotateOrth(
						Box box,
						int w,
						int h,
						int rotation)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxRotateOrth(box.Pointer,   w,   h,   rotation);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxfunc2.c (560, 1)
		// boxaSort(boxas, sorttype, sortorder, pnaindex) as Boxa
		// boxaSort(BOXA *, l_int32, l_int32, NUMA **) as BOXA *
		///  <summary>
		/// (1) An empty boxa returns a copy, with a warning.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSort/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_RIGHT, L_SORT_BY_BOT, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MIN_DIMENSION, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA, L_SORT_BY_ASPECT_RATIO</param>
		///  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
		///  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
		///   <returns>boxad sorted version of boxas, or NULL on error</returns>
		public static Boxa boxaSort(
						Boxa boxas,
						int sorttype,
						int sortorder,
						out Numa pnaindex)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pnaindexPtr = IntPtr.Zero;
			IntPtr _Result = Natives.boxaSort(boxas.Pointer,   sorttype,   sortorder, out pnaindexPtr);
			if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (684, 1)
		// boxaBinSort(boxas, sorttype, sortorder, pnaindex) as Boxa
		// boxaBinSort(BOXA *, l_int32, l_int32, NUMA **) as BOXA *
		///  <summary>
		/// (1) For a large number of boxes (say, greater than 1000), this
		/// O(n) binsort is much faster than the O(nlogn) shellsort.
		/// For 5000 components, this is over 20x faster than boxaSort().<para/>
		///
		/// (2) Consequently, boxaSort() calls this function if it will
		/// likely go much faster.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaBinSort/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y, L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_PERIMETER</param>
		///  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
		///  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
		///   <returns>boxad sorted version of boxas, or NULL on error</returns>
		public static Boxa boxaBinSort(
						Boxa boxas,
						int sorttype,
						int sortorder,
						out Numa pnaindex)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pnaindexPtr = IntPtr.Zero;
			IntPtr _Result = Natives.boxaBinSort(boxas.Pointer,   sorttype,   sortorder, out pnaindexPtr);
			if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (761, 1)
		// boxaSortByIndex(boxas, naindex) as Boxa
		// boxaSortByIndex(BOXA *, NUMA *) as BOXA *
		///  <summary>
		/// boxaSortByIndex()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSortByIndex/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="naindex">[in] - na that maps from the new boxa to the input boxa</param>
		///   <returns>boxad sorted, or NULL on error</returns>
		public static Boxa boxaSortByIndex(
						Boxa boxas,
						Numa naindex)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (naindex == null) {throw new ArgumentNullException  ("naindex cannot be Nothing");}

			IntPtr _Result = Natives.boxaSortByIndex(boxas.Pointer, naindex.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (837, 1)
		// boxaSort2d(boxas, pnaad, delta1, delta2, minh1) as Boxaa
		// boxaSort2d(BOXA *, NUMAA **, l_int32, l_int32, l_int32) as BOXAA *
		///  <summary>
		/// (1) The final result is a sort where the 'fast scan' direction is
		/// left to right, and the 'slow scan' direction is from top
		/// to bottom.  Each boxa in the baa represents a sorted set
		/// of boxes from left to right.<para/>
		///
		/// (2) Three passes are used to aggregate the boxas, which can correspond
		/// to characters or words in a line of text.  In pass 1, only
		/// taller components, which correspond to xheight or larger,
		/// are permitted to start a new boxa.  In pass 2, the remaining
		/// vertically-challenged components are allowed to join an
		/// existing boxa or start a new one.  In pass 3, boxa whose extent
		/// is overlapping are joined.  After that, the boxes in each
		/// boxa are sorted horizontally, and finally the boxa are
		/// sorted vertically.<para/>
		///
		/// (3) If delta1  is smaller 0, the first pass allows aggregation when
		/// boxes in the same boxa do not overlap vertically.
		/// The distance by which they can miss and still be aggregated
		/// is the absolute value |delta1|. Similar for delta2 on
		/// the second pass.<para/>
		///
		/// (4) On the first pass, any component of height less than minh1
		/// cannot start a new boxa it's put aside for later insertion.<para/>
		///
		/// (5) On the second pass, any small component that doesn't align
		/// with an existing boxa can start a new one.<para/>
		///
		/// (6) This can be used to identify lines of text from
		/// character or word bounding boxes.<para/>
		///
		/// (7) Typical values for the input parameters on 300 ppi text are:
		/// delta1 ~ 0
		/// delta2 ~ 0
		/// minh1 ~ 5
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSort2d/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="pnaad">[out][optional] - numaa with sorted indices whose values are the indices of the input array</param>
		///  <param name="delta1">[in] - min overlap that permits aggregation of a box onto a boxa of horizontally-aligned boxes pass 1</param>
		///  <param name="delta2">[in] - min overlap that permits aggregation of a box onto a boxa of horizontally-aligned boxes pass 2</param>
		///  <param name="minh1">[in] - components less than this height either join an existing boxa or are set aside for pass 2</param>
		///   <returns>baa 2d sorted version of boxa, or NULL on error</returns>
		public static Boxaa boxaSort2d(
						Boxa boxas,
						out Numaa pnaad,
						int delta1,
						int delta2,
						int minh1)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pnaadPtr = IntPtr.Zero;
			IntPtr _Result = Natives.boxaSort2d(boxas.Pointer, out pnaadPtr,   delta1,   delta2,   minh1);
			if (pnaadPtr == IntPtr.Zero) {pnaad = null;} else { pnaad = new Numaa(pnaadPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxfunc2.c (1024, 1)
		// boxaSort2dByIndex(boxas, naa) as Boxaa
		// boxaSort2dByIndex(BOXA *, NUMAA *) as BOXAA *
		///  <summary>
		/// boxaSort2dByIndex()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSort2dByIndex/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="naa">[in] - numaa that maps from the new baa to the input boxa</param>
		///   <returns>baa sorted boxaa, or NULL on error</returns>
		public static Boxaa boxaSort2dByIndex(
						Boxa boxas,
						Numaa naa)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (naa == null) {throw new ArgumentNullException  ("naa cannot be Nothing");}

			IntPtr _Result = Natives.boxaSort2dByIndex(boxas.Pointer, naa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxfunc2.c (1093, 1)
		// boxaExtractAsNuma(boxa, pnal, pnat, pnar, pnab, pnaw, pnah, keepinvalid) as int
		// boxaExtractAsNuma(BOXA *, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, NUMA **, l_int32) as l_ok
		///  <summary>
		/// (1) If you are counting or sorting values, such as determining
		/// rank order, you must remove invalid boxes.<para/>
		///
		/// (2) If you are parametrizing the values, or doing an evaluation
		/// where the position in the boxa sequence is important, you
		/// must replace the invalid boxes with valid ones before
		/// doing the extraction. This is easily done with boxaFillSequence().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtractAsNuma/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="pnal">[out][optional] - array of left locations</param>
		///  <param name="pnat">[out][optional] - array of top locations</param>
		///  <param name="pnar">[out][optional] - array of right locations</param>
		///  <param name="pnab">[out][optional] - array of bottom locations</param>
		///  <param name="pnaw">[out][optional] - array of widths</param>
		///  <param name="pnah">[out][optional] - array of heights</param>
		///  <param name="keepinvalid">[in] - 1 to keep invalid boxes 0 to remove them</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaExtractAsNuma(
						Boxa boxa,
						out Numa pnal,
						out Numa pnat,
						out Numa pnar,
						out Numa pnab,
						out Numa pnaw,
						out Numa pnah,
						int keepinvalid)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pnalPtr = IntPtr.Zero;
			IntPtr pnatPtr = IntPtr.Zero;
			IntPtr pnarPtr = IntPtr.Zero;
			IntPtr pnabPtr = IntPtr.Zero;
			IntPtr pnawPtr = IntPtr.Zero;
			IntPtr pnahPtr = IntPtr.Zero;
			int _Result = Natives.boxaExtractAsNuma(boxa.Pointer, out pnalPtr, out pnatPtr, out pnarPtr, out pnabPtr, out pnawPtr, out pnahPtr,   keepinvalid);
			if (pnalPtr == IntPtr.Zero) {pnal = null;} else { pnal = new Numa(pnalPtr); };
			if (pnatPtr == IntPtr.Zero) {pnat = null;} else { pnat = new Numa(pnatPtr); };
			if (pnarPtr == IntPtr.Zero) {pnar = null;} else { pnar = new Numa(pnarPtr); };
			if (pnabPtr == IntPtr.Zero) {pnab = null;} else { pnab = new Numa(pnabPtr); };
			if (pnawPtr == IntPtr.Zero) {pnaw = null;} else { pnaw = new Numa(pnawPtr); };
			if (pnahPtr == IntPtr.Zero) {pnah = null;} else { pnah = new Numa(pnahPtr); };

			return _Result;
		}

		// boxfunc2.c (1170, 1)
		// boxaExtractAsPta(boxa, pptal, pptat, pptar, pptab, pptaw, pptah, keepinvalid) as int
		// boxaExtractAsPta(BOXA *, PTA **, PTA **, PTA **, PTA **, PTA **, PTA **, l_int32) as l_ok
		///  <summary>
		/// (1) For most applications, such as counting, sorting, fitting
		/// to some parametrized form, plotting or filtering in general,
		/// you should remove the invalid boxes.  Each pta saves the
		/// box index in the x array, so replacing invalid boxes by
		/// filling with boxaFillSequence(), which is required for
		/// boxaExtractAsNuma(), is not necessary.<para/>
		///
		/// (2) If invalid boxes are retained, each one will result in
		/// entries (typically 0) in all selected output pta.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtractAsPta/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="pptal">[out][optional] - array of left locations vs. index</param>
		///  <param name="pptat">[out][optional] - array of top locations vs. index</param>
		///  <param name="pptar">[out][optional] - array of right locations vs. index</param>
		///  <param name="pptab">[out][optional] - array of bottom locations vs. index</param>
		///  <param name="pptaw">[out][optional] - array of widths vs. index</param>
		///  <param name="pptah">[out][optional] - array of heights vs. index</param>
		///  <param name="keepinvalid">[in] - 1 to keep invalid boxes 0 to remove them</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaExtractAsPta(
						Boxa boxa,
						out Pta pptal,
						out Pta pptat,
						out Pta pptar,
						out Pta pptab,
						out Pta pptaw,
						out Pta pptah,
						int keepinvalid)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pptalPtr = IntPtr.Zero;
			IntPtr pptatPtr = IntPtr.Zero;
			IntPtr pptarPtr = IntPtr.Zero;
			IntPtr pptabPtr = IntPtr.Zero;
			IntPtr pptawPtr = IntPtr.Zero;
			IntPtr pptahPtr = IntPtr.Zero;
			int _Result = Natives.boxaExtractAsPta(boxa.Pointer, out pptalPtr, out pptatPtr, out pptarPtr, out pptabPtr, out pptawPtr, out pptahPtr,   keepinvalid);
			if (pptalPtr == IntPtr.Zero) {pptal = null;} else { pptal = new Pta(pptalPtr); };
			if (pptatPtr == IntPtr.Zero) {pptat = null;} else { pptat = new Pta(pptatPtr); };
			if (pptarPtr == IntPtr.Zero) {pptar = null;} else { pptar = new Pta(pptarPtr); };
			if (pptabPtr == IntPtr.Zero) {pptab = null;} else { pptab = new Pta(pptabPtr); };
			if (pptawPtr == IntPtr.Zero) {pptaw = null;} else { pptaw = new Pta(pptawPtr); };
			if (pptahPtr == IntPtr.Zero) {pptah = null;} else { pptah = new Pta(pptahPtr); };

			return _Result;
		}

		// boxfunc2.c (1251, 1)
		// boxaGetRankVals(boxa, fract, px, py, pw, ph) as int
		// boxaGetRankVals(BOXA *, l_float32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This function does not assume that all boxes in the boxa are valid<para/>
		///
		/// (2) The four box parameters are sorted independently.
		/// For rank order, the width and height are sorted in increasing
		/// order.  But what does it mean to sort x and y in "rank order"?
		/// If the boxes are of comparable size and somewhat
		/// aligned (e.g., from multiple images), it makes some sense
		/// to give a "rank order" for x and y by sorting them in
		/// decreasing order.  But in general, the interpretation of a rank
		/// order on x and y is highly application dependent.  In summary:
		/// ~ x and y are sorted in decreasing order
		/// ~ w and h are sorted in increasing order
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetRankVals/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="fract">[in] - use 0.0 for smallest, 1.0 for largest width and height</param>
		///  <param name="px">[out][optional] - rank value of x</param>
		///  <param name="py">[out][optional] - rank value of y</param>
		///  <param name="pw">[out][optional] - rank value of width</param>
		///  <param name="ph">[out][optional] - rank value of height</param>
		///   <returns>0 if OK, 1 on error or if the boxa is empty or has no valid boxes</returns>
		public static int boxaGetRankVals(
						Boxa boxa,
						Single fract,
						out int px,
						out int py,
						out int pw,
						out int ph)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetRankVals(boxa.Pointer,   fract, out  px, out  py, out  pw, out  ph);
			return _Result;
		}

		// boxfunc2.c (1317, 1)
		// boxaGetMedianVals(boxa, px, py, pw, ph) as int
		// boxaGetMedianVals(BOXA *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) See boxaGetRankVals()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetMedianVals/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="px">[out][optional] - median value of x</param>
		///  <param name="py">[out][optional] - median value of y</param>
		///  <param name="pw">[out][optional] - median value of width</param>
		///  <param name="ph">[out][optional] - median value of height</param>
		///   <returns>0 if OK, 1 on error or if the boxa is empty or has no valid boxes</returns>
		public static int boxaGetMedianVals(
						Boxa boxa,
						out int px,
						out int py,
						out int pw,
						out int ph)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetMedianVals(boxa.Pointer, out  px, out  py, out  pw, out  ph);
			return _Result;
		}

		// boxfunc2.c (1343, 1)
		// boxaGetAverageSize(boxa, pw, ph) as int
		// boxaGetAverageSize(BOXA *, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// boxaGetAverageSize()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetAverageSize/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="pw">[out][optional] - average width</param>
		///  <param name="ph">[out][optional] - average height</param>
		///   <returns>0 if OK, 1 on error or if the boxa is empty</returns>
		public static int boxaGetAverageSize(
						Boxa boxa,
						out Single pw,
						out Single ph)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetAverageSize(boxa.Pointer, out  pw, out  ph);
			return _Result;
		}

		// boxfunc2.c (1398, 1)
		// boxaaGetExtent(baa, pw, ph, pbox, pboxa) as int
		// boxaaGetExtent(BOXAA *, l_int32 *, l_int32 *, BOX **, BOXA **) as l_ok
		///  <summary>
		/// (1) The returned w and h are the minimum size image
		/// that would contain all boxes untranslated.<para/>
		///
		/// (2) Each box in the returned boxa is the minimum box required to
		/// hold all the boxes in the respective boxa of baa.<para/>
		///
		/// (3) If there are no valid boxes in a boxa, the box corresponding
		/// to its extent has all fields set to 0 (an invalid box).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetExtent/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="pw">[out][optional] - width</param>
		///  <param name="ph">[out][optional] - height</param>
		///  <param name="pbox">[out][optional] - minimum box containing all boxa in boxaa</param>
		///  <param name="pboxa">[out][optional] - boxa containing all boxes in each boxa in the boxaa</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaGetExtent(
						Boxaa baa,
						out int pw,
						out int ph,
						out Box pbox,
						out Boxa pboxa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr pboxPtr = IntPtr.Zero;
			IntPtr pboxaPtr = IntPtr.Zero;
			int _Result = Natives.boxaaGetExtent(baa.Pointer, out  pw, out  ph, out pboxPtr, out pboxaPtr);
			if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };
			if (pboxaPtr == IntPtr.Zero) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };

			return _Result;
		}

		// boxfunc2.c (1478, 1)
		// boxaaFlattenToBoxa(baa, pnaindex, copyflag) as Boxa
		// boxaaFlattenToBoxa(BOXAA *, NUMA **, l_int32) as BOXA *
		///  <summary>
		/// (1) This 'flattens' the baa to a boxa, taking the boxes in
		/// order in the first boxa, then the second, etc.<para/>
		///
		/// (2) If a boxa is empty, we generate an invalid, placeholder box
		/// of zero size.  This is useful when converting from a baa
		/// where each boxa has either 0 or 1 boxes, and it is necessary
		/// to maintain a 1:1 correspondence between the initial
		/// boxa array and the resulting box array.<para/>
		///
		/// (3) If [and]naindex is defined, we generate a Numa that gives, for
		/// each box in the baa, the index of the boxa to which it belongs.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaFlattenToBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="pnaindex">[out][optional] - the boxa index in the baa</param>
		///  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaaFlattenToBoxa(
						Boxaa baa,
						out Numa pnaindex,
						int copyflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr pnaindexPtr = IntPtr.Zero;
			IntPtr _Result = Natives.boxaaFlattenToBoxa(baa.Pointer, out pnaindexPtr,   copyflag);
			if (pnaindexPtr == IntPtr.Zero) {pnaindex = null;} else { pnaindex = new Numa(pnaindexPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (1544, 1)
		// boxaaFlattenAligned(baa, num, fillerbox, copyflag) as Boxa
		// boxaaFlattenAligned(BOXAA *, l_int32, BOX *, l_int32) as BOXA *
		///  <summary>
		/// (1) This 'flattens' the baa to a boxa, taking the first %num
		/// boxes from each boxa.<para/>
		///
		/// (2) In each boxa, if there are less than %num boxes, we preserve
		/// the alignment between the input baa and the output boxa
		/// by inserting one or more fillerbox(es) or, if %fillerbox == NULL,
		/// one or more invalid placeholder boxes.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaFlattenAligned/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="num">[in] - number extracted from each</param>
		///  <param name="fillerbox">[in][optional] - that fills if necessary</param>
		///  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaaFlattenAligned(
						Boxaa baa,
						int num,
						Box fillerbox,
						int copyflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr fillerboxPtr = IntPtr.Zero; 	if (fillerbox != null) {fillerboxPtr = fillerbox.Pointer;}
			IntPtr _Result = Natives.boxaaFlattenAligned(baa.Pointer,   num, fillerboxPtr,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxfunc2.c (1602, 1)
		// boxaEncapsulateAligned(boxa, num, copyflag) as Boxaa
		// boxaEncapsulateAligned(BOXA *, l_int32, l_int32) as BOXAA *
		///  <summary>
		/// (1) This puts %num boxes from the input %boxa into each of a
		/// set of boxa within an output baa.<para/>
		///
		/// (2) This assumes that the boxes in %boxa are in sets of %num each.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaEncapsulateAligned/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="num">[in] - number put into each boxa in the baa</param>
		///  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>baa, or NULL on error</returns>
		public static Boxaa boxaEncapsulateAligned(
						Boxa boxa,
						int num,
						int copyflag)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaEncapsulateAligned(boxa.Pointer,   num,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxfunc2.c (1656, 1)
		// boxaaTranspose(baas) as Boxaa
		// boxaaTranspose(BOXAA *) as BOXAA *
		///  <summary>
		/// (1) If you think of a boxaa as a 2D array of boxes that is accessed
		/// row major, then each row is represented by one of the boxa.
		/// This function creates a new boxaa related to the input boxaa
		/// as a column major traversal of the input boxaa.<para/>
		///
		/// (2) For example, if %baas has 2 boxa, each with 10 boxes, then
		/// %baad will have 10 boxa, each with 2 boxes.<para/>
		///
		/// (3) Require for this transpose operation that each boxa in
		/// %baas has the same number of boxes.  This operation is useful
		/// when the i-th boxes in each boxa are meaningfully related.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaTranspose/*"/>
		///  <param name="baas">[in] - </param>
		///   <returns>baad, or NULL on error</returns>
		public static Boxaa boxaaTranspose(
						Boxaa baas)
		{
			if (baas == null) {throw new ArgumentNullException  ("baas cannot be Nothing");}

			IntPtr _Result = Natives.boxaaTranspose(baas.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxfunc2.c (1715, 1)
		// boxaaAlignBox(baa, box, delta, pindex) as int
		// boxaaAlignBox(BOXAA *, BOX *, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) This is not greedy.  It finds the boxa whose vertical
		/// extent has the closest overlap with the input box.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaAlignBox/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="box">[in] - to be aligned with the bext boxa in the baa, if possible</param>
		///  <param name="delta">[in] - amount by which consecutive components can miss in overlap and still be included in the array</param>
		///  <param name="pindex">[out] - index of boxa with best overlap, or if none match, this is the index of the next boxa to be generated</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaAlignBox(
						Boxaa baa,
						Box box,
						int delta,
						out int pindex)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaaAlignBox(baa.Pointer, box.Pointer,   delta, out  pindex);
			return _Result;
		}


	}
}
