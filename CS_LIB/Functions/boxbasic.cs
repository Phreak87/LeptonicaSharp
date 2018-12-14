using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// boxbasic.c (165, 1)
		// boxCreate(x, y, w, h) as Box
		// boxCreate(l_int32, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This clips the box to the +quad.  If no part of the
		/// box is in the +quad, this returns NULL.<para/>
		///
		/// (2) We allow you to make a box with w = 0 and/or h = 0.
		/// This does not represent a valid region, but it is useful
		/// as a placeholder in a boxa for which the index of the
		/// box in the boxa is important.  This is an atypical
		/// situation usually you want to put only valid boxes with
		/// nonzero width and height in a boxa.  If you have a boxa
		/// with invalid boxes, the accessor boxaGetValidBox()
		/// will return NULL on each invalid box.<para/>
		///
		/// (3) If you want to create only valid boxes, use boxCreateValid(),
		/// which returns NULL if either w or h is 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCreate/*"/>
		///  <param name="x">[in] - </param>
		///  <param name="y">[in] - </param>
		///  <param name="w">[in] - </param>
		///  <param name="h">[in] - </param>
		///   <returns>box, or NULL on error</returns>
		public static Box boxCreate(
						int x,
						int y,
						int w,
						int h)
		{
			IntPtr _Result = Natives.boxCreate(  x,   y,   w,   h);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (210, 1)
		// boxCreateValid(x, y, w, h) as Box
		// boxCreateValid(l_int32, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This returns NULL if either w = 0 or h = 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCreateValid/*"/>
		///  <param name="x">[in] - </param>
		///  <param name="y">[in] - </param>
		///  <param name="w">[in] - </param>
		///  <param name="h">[in] - </param>
		///   <returns>box, or NULL on error</returns>
		public static Box boxCreateValid(
						int x,
						int y,
						int w,
						int h)
		{
			IntPtr _Result = Natives.boxCreateValid(  x,   y,   w,   h);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (230, 1)
		// boxCopy(box) as Box
		// boxCopy(BOX *) as BOX *
		///  <summary>
		/// boxCopy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCopy/*"/>
		///  <param name="box">[in] - </param>
		///   <returns>copy of box, or NULL on error</returns>
		public static Box boxCopy(
						Box box)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxCopy(box.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (252, 1)
		// boxClone(box) as Box
		// boxClone(BOX *) as BOX *
		///  <summary>
		/// boxClone()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxClone/*"/>
		///  <param name="box">[in] - </param>
		///   <returns>ptr to same box, or NULL on error</returns>
		public static Box boxClone(
						Box box)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			IntPtr _Result = Natives.boxClone(box.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (278, 1)
		// boxDestroy(pbox) as Object
		// boxDestroy(BOX **) as void
		///  <summary>
		/// (1) Decrements the ref count and, if 0, destroys the box.<para/>
		///
		/// (2) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxDestroy/*"/>
		///  <param name="pbox">[in,out] - will be set to null before returning</param>
		public static void boxDestroy(
						ref Box pbox)
		{
			IntPtr pboxPtr = IntPtr.Zero; 	if (pbox != null) {pboxPtr = pbox.Pointer;}
			Natives.boxDestroy(ref pboxPtr);
			if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };
		}

		// boxbasic.c (310, 1)
		// boxGetGeometry(box, px, py, pw, ph) as int
		// boxGetGeometry(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// boxGetGeometry()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetGeometry/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="px">[out][optional] - each can be null</param>
		///  <param name="py">[out][optional] - each can be null</param>
		///  <param name="pw">[out][optional] - each can be null</param>
		///  <param name="ph">[out][optional] - each can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxGetGeometry(
						Box box,
						out int px,
						out int py,
						out int pw,
						out int ph)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxGetGeometry(box.Pointer, out  px, out  py, out  pw, out  ph);
			return _Result;
		}

		// boxbasic.c (340, 1)
		// boxSetGeometry(box, x, y, w, h) as int
		// boxSetGeometry(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// boxSetGeometry()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSetGeometry/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="x">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="y">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="w">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="h">[in][optional] - use -1 to leave unchanged</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxSetGeometry(
						Box box,
						int x = 0,
						int y = 0,
						int w = 0,
						int h = 0)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxSetGeometry(box.Pointer,   x,   y,   w,   h);
			return _Result;
		}

		// boxbasic.c (371, 1)
		// boxGetSideLocations(box, pl, pr, pt, pb) as int
		// boxGetSideLocations(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) All returned values are within the box.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetSideLocations/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="pl">[out][optional] - each can be null</param>
		///  <param name="pr">[out][optional] - each can be null</param>
		///  <param name="pt">[out][optional] - each can be null</param>
		///  <param name="pb">[out][optional] - each can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxGetSideLocations(
						Box box,
						out int pl,
						out int pr,
						out int pt,
						out int pb)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxGetSideLocations(box.Pointer, out  pl, out  pr, out  pt, out  pb);
			return _Result;
		}

		// boxbasic.c (405, 1)
		// boxSetSideLocations(box, l, r, t, b) as int
		// boxSetSideLocations(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
		///  <summary>
		/// boxSetSideLocations()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSetSideLocations/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="l">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="r">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="t">[in][optional] - use -1 to leave unchanged</param>
		///  <param name="b">[in][optional] - use -1 to leave unchanged</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxSetSideLocations(
						Box box,
						int l = 0,
						int r = 0,
						int t = 0,
						int b = 0)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxSetSideLocations(box.Pointer,   l,   r,   t,   b);
			return _Result;
		}

		// boxbasic.c (432, 1)
		// boxGetRefcount(box) as int
		// boxGetRefcount(BOX *) as l_int32
		///  <summary>
		/// Return the current reference count of %box
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetRefcount/*"/>
		///  <param name="box">[in] - ptr to Box</param>
		///   <returns>refcount</returns>
		public static int boxGetRefcount(
						Box box)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxGetRefcount(box.Pointer);
			return _Result;
		}

		// boxbasic.c (449, 1)
		// boxChangeRefcount(box, delta) as int
		// boxChangeRefcount(BOX *, l_int32) as l_ok
		///  <summary>
		/// Adjust the current references count of %box by %delta
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxChangeRefcount/*"/>
		///  <param name="box">[in] - ptr to box</param>
		///  <param name="delta">[in] - adjustment, usually -1 or 1</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxChangeRefcount(
						Box box,
						int delta)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxChangeRefcount(box.Pointer,   delta);
			return _Result;
		}

		// boxbasic.c (470, 1)
		// boxIsValid(box, pvalid) as int
		// boxIsValid(BOX *, l_int32 *) as l_ok
		///  <summary>
		/// boxIsValid()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxIsValid/*"/>
		///  <param name="box">[in] - </param>
		///  <param name="pvalid">[out] - 1 if valid 0 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxIsValid(
						Box box,
						out int pvalid)
		{
			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxIsValid(box.Pointer, out  pvalid);
			return _Result;
		}

		// boxbasic.c (497, 1)
		// boxaCreate(n) as Boxa
		// boxaCreate(l_int32) as BOXA *
		///  <summary>
		/// boxaCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCreate/*"/>
		///  <param name="n">[in] - initial number of ptrs</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaCreate(
						int n)
		{
			IntPtr _Result = Natives.boxaCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (532, 1)
		// boxaCopy(boxa, copyflag) as Boxa
		// boxaCopy(BOXA *, l_int32) as BOXA *
		///  <summary>
		/// (1) See pix.h for description of the copyflag.<para/>
		///
		/// (2) The copy-clone makes a new boxa that holds clones of each box.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCopy/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="copyflag">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
		///   <returns>new boxa, or NULL on error</returns>
		public static Boxa boxaCopy(
						Boxa boxa,
						int copyflag)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaCopy(boxa.Pointer,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (578, 1)
		// boxaDestroy(pboxa) as Object
		// boxaDestroy(BOXA **) as void
		///  <summary>
		/// (1) Decrements the ref count and, if 0, destroys the boxa.<para/>
		///
		/// (2) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaDestroy/*"/>
		///  <param name="pboxa">[in,out] - will be set to null before returning</param>
		public static void boxaDestroy(
						ref Boxa pboxa)
		{
			IntPtr pboxaPtr = IntPtr.Zero; 	if (pboxa != null) {pboxaPtr = pboxa.Pointer;}
			Natives.boxaDestroy(ref pboxaPtr);
			if (pboxaPtr == IntPtr.Zero) {pboxa = null;} else { pboxa = new Boxa(pboxaPtr); };
		}

		// boxbasic.c (616, 1)
		// boxaAddBox(boxa, box, copyflag) as int
		// boxaAddBox(BOXA *, BOX *, l_int32) as l_ok
		///  <summary>
		/// boxaAddBox()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAddBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="box">[in] - to be added</param>
		///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaAddBox(
						Boxa boxa,
						Box box,
						int copyflag)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaAddBox(boxa.Pointer, box.Pointer,   copyflag);
			return _Result;
		}

		// boxbasic.c (663, 1)
		// boxaExtendArray(boxa) as int
		// boxaExtendArray(BOXA *) as l_ok
		///  <summary>
		/// (1) Reallocs with doubled size of ptr array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtendArray/*"/>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK 1 on error</returns>
		public static int boxaExtendArray(
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaExtendArray(boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (687, 1)
		// boxaExtendArrayToSize(boxa, size) as int
		// boxaExtendArrayToSize(BOXA *, l_int32) as l_ok
		///  <summary>
		/// (1) If necessary, reallocs new boxa ptr array to %size.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtendArrayToSize/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="size">[in] - new size of boxa array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int boxaExtendArrayToSize(
						Boxa boxa,
						int size)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaExtendArrayToSize(boxa.Pointer,   size);
			return _Result;
		}

		// boxbasic.c (716, 1)
		// boxaGetCount(boxa) as int
		// boxaGetCount(BOXA *) as l_int32
		///  <summary>
		/// boxaGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetCount/*"/>
		///  <param name="boxa">[in] - </param>
		///   <returns>count of all boxes 0 if no boxes or on error</returns>
		public static int boxaGetCount(
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetCount(boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (733, 1)
		// boxaGetValidCount(boxa) as int
		// boxaGetValidCount(BOXA *) as l_int32
		///  <summary>
		/// boxaGetValidCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetValidCount/*"/>
		///  <param name="boxa">[in] - </param>
		///   <returns>count of valid boxes 0 if no valid boxes or on error</returns>
		public static int boxaGetValidCount(
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetValidCount(boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (761, 1)
		// boxaGetBox(boxa, index, accessflag) as Box
		// boxaGetBox(BOXA *, l_int32, l_int32) as BOX *
		///  <summary>
		/// boxaGetBox()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - to the index-th box</param>
		///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>box, or NULL on error</returns>
		public static Box boxaGetBox(
						Boxa boxa,
						int index,
						int accessflag)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaGetBox(boxa.Pointer,   index,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (800, 1)
		// boxaGetValidBox(boxa, index, accessflag) as Box
		// boxaGetValidBox(BOXA *, l_int32, l_int32) as BOX *
		///  <summary>
		/// (1) This returns NULL for an invalid box in a boxa.
		/// For a box to be valid, both the width and height must be  is greater  0.<para/>
		///
		/// (2) We allow invalid boxes, with w = 0 or h = 0, as placeholders
		/// in boxa for which the index of the box in the boxa is important.
		/// This is an atypical situation usually you want to put only
		/// valid boxes in a boxa.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetValidBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - to the index-th box</param>
		///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>box, or NULL if box is not valid or on error</returns>
		public static Box boxaGetValidBox(
						Boxa boxa,
						int index,
						int accessflag)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaGetValidBox(boxa.Pointer,   index,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (828, 1)
		// boxaFindInvalidBoxes(boxa) as Numa
		// boxaFindInvalidBoxes(BOXA *) as NUMA *
		///  <summary>
		/// boxaFindInvalidBoxes()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaFindInvalidBoxes/*"/>
		///  <param name="boxa">[in] - </param>
		///   <returns>na   numa of invalid boxes NULL if there are none or on error</returns>
		public static Numa boxaFindInvalidBoxes(
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr _Result = Natives.boxaFindInvalidBoxes(boxa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// boxbasic.c (861, 1)
		// boxaGetBoxGeometry(boxa, index, px, py, pw, ph) as int
		// boxaGetBoxGeometry(BOXA *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// boxaGetBoxGeometry()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetBoxGeometry/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - to the index-th box</param>
		///  <param name="px">[out][optional] - each can be null</param>
		///  <param name="py">[out][optional] - each can be null</param>
		///  <param name="pw">[out][optional] - each can be null</param>
		///  <param name="ph">[out][optional] - each can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaGetBoxGeometry(
						Boxa boxa,
						int index,
						out int px,
						out int py,
						out int pw,
						out int ph)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaGetBoxGeometry(boxa.Pointer,   index, out  px, out  py, out  pw, out  ph);
			return _Result;
		}

		// boxbasic.c (897, 1)
		// boxaIsFull(boxa, pfull) as int
		// boxaIsFull(BOXA *, l_int32 *) as l_ok
		///  <summary>
		/// boxaIsFull()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaIsFull/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="pfull">[out] - 1 if boxa is full</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaIsFull(
						Boxa boxa,
						out int pfull)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaIsFull(boxa.Pointer, out  pfull);
			return _Result;
		}

		// boxbasic.c (943, 1)
		// boxaReplaceBox(boxa, index, box) as int
		// boxaReplaceBox(BOXA *, l_int32, BOX *) as l_ok
		///  <summary>
		/// (1) In-place replacement of one box.<para/>
		///
		/// (2) The previous box at that location, if any, is destroyed.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReplaceBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - to the index-th box</param>
		///  <param name="box">[in] - insert to replace existing one</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaReplaceBox(
						Boxa boxa,
						int index,
						Box box)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaReplaceBox(boxa.Pointer,   index, box.Pointer);
			return _Result;
		}

		// boxbasic.c (981, 1)
		// boxaInsertBox(boxa, index, box) as int
		// boxaInsertBox(BOXA *, l_int32, BOX *) as l_ok
		///  <summary>
		/// (1) This shifts box[i] to box[i + 1] for all i greater or equal index,
		/// and then inserts box as box[index].<para/>
		///
		/// (2) To insert at the beginning of the array, set index = 0.<para/>
		///
		/// (3) To append to the array, it's easier to use boxaAddBox().<para/>
		///
		/// (4) This should not be used repeatedly to insert into large arrays,
		/// because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaInsertBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - location in boxa to insert new value</param>
		///  <param name="box">[in] - new box to be inserted</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaInsertBox(
						Boxa boxa,
						int index,
						Box box)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaInsertBox(boxa.Pointer,   index, box.Pointer);
			return _Result;
		}

		// boxbasic.c (1026, 1)
		// boxaRemoveBox(boxa, index) as int
		// boxaRemoveBox(BOXA *, l_int32) as l_ok
		///  <summary>
		/// (1) This removes box[index] and then shifts
		/// box[i] to box[i - 1] for all i  is greater  index.<para/>
		///
		/// (2) It should not be used repeatedly to remove boxes from
		/// large arrays, because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRemoveBox/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - of box to be removed</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaRemoveBox(
						Boxa boxa,
						int index)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaRemoveBox(boxa.Pointer,   index);
			return _Result;
		}

		// boxbasic.c (1068, 1)
		// boxaRemoveBoxAndSave(boxa, index, pbox) as int
		// boxaRemoveBoxAndSave(BOXA *, l_int32, BOX **) as l_ok
		///  <summary>
		/// (1) This removes box[index] and then shifts
		/// box[i] to box[i - 1] for all i  is greater  index.<para/>
		///
		/// (2) It should not be used repeatedly to remove boxes from
		/// large arrays, because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRemoveBoxAndSave/*"/>
		///  <param name="boxa">[in] - </param>
		///  <param name="index">[in] - of box to be removed</param>
		///  <param name="pbox">[out][optional] - removed box</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaRemoveBoxAndSave(
						Boxa boxa,
						int index,
						out Box pbox)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pboxPtr = IntPtr.Zero;
			int _Result = Natives.boxaRemoveBoxAndSave(boxa.Pointer,   index, out pboxPtr);
			if (pboxPtr == IntPtr.Zero) {pbox = null;} else { pbox = new Box(pboxPtr); };

			return _Result;
		}

		// boxbasic.c (1110, 1)
		// boxaSaveValid(boxas, copyflag) as Boxa
		// boxaSaveValid(BOXA *, l_int32) as BOXA *
		///  <summary>
		/// (1) This makes a copy/clone of each valid box.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSaveValid/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>boxad if OK, NULL on error</returns>
		public static Boxa boxaSaveValid(
						Boxa boxas,
						int copyflag)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaSaveValid(boxas.Pointer,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (1174, 1)
		// boxaInitFull(boxa, box) as int
		// boxaInitFull(BOXA *, BOX *) as l_ok
		///  <summary>
		/// (1) This initializes a boxa by filling up the entire box ptr array
		/// with copies of %box.  If %box == NULL, use a placeholder box
		/// of zero size.  Any existing boxes are destroyed.
		/// After this opepration, the number of boxes is equal to
		/// the number of allocated ptrs.<para/>
		///
		/// (2) Note that we use boxaReplaceBox() instead of boxaInsertBox().
		/// They both have the same effect when inserting into a NULL ptr
		/// in the boxa ptr array:<para/>
		///
		/// (3) Example usage.  This function is useful to prepare for a
		/// random insertion (or replacement) of boxes into a boxa.
		/// To randomly insert boxes into a boxa, up to some index "max":
		/// Boxa boxa = boxaCreate(max)
		/// boxaInitFull(boxa, NULL)
		/// If you want placeholder boxes of non-zero size:
		/// Boxa boxa = boxaCreate(max)
		/// Box box = boxCreate(...)
		/// boxaInitFull(boxa, box)
		/// boxDestroy([and]box)
		/// If we have an existing boxa with a smaller ptr array, it can
		/// be reused for up to max boxes:
		/// boxaExtendArrayToSize(boxa, max)
		/// boxaInitFull(boxa, NULL)
		/// The initialization allows the boxa to always be properly
		/// filled, even if all the boxes are not later replaced.
		/// If you want to know which boxes have been replaced,
		/// and you initialized with invalid zero-sized boxes,
		/// use boxaGetValidBox() to return NULL for the invalid boxes.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaInitFull/*"/>
		///  <param name="boxa">[in] - typically empty</param>
		///  <param name="box">[in][optional] - to be replicated into the entire ptr array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaInitFull(
						Boxa boxa,
						Box box = null)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr boxPtr = IntPtr.Zero; 	if (box != null) {boxPtr = box.Pointer;}
			int _Result = Natives.boxaInitFull(boxa.Pointer, boxPtr);
			return _Result;
		}

		// boxbasic.c (1211, 1)
		// boxaClear(boxa) as int
		// boxaClear(BOXA *) as l_ok
		///  <summary>
		/// (1) This destroys all boxes in the boxa, setting the ptrs
		/// to null.  The number of allocated boxes, n, is set to 0.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaClear/*"/>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaClear(
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaClear(boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (1238, 1)
		// boxaaCreate(n) as Boxaa
		// boxaaCreate(l_int32) as BOXAA *
		///  <summary>
		/// boxaaCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaCreate/*"/>
		///  <param name="n">[in] - size of boxa ptr array to be alloc'd 0 for default</param>
		///   <returns>baa, or NULL on error</returns>
		public static Boxaa boxaaCreate(
						int n)
		{
			IntPtr _Result = Natives.boxaaCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1273, 1)
		// boxaaCopy(baas, copyflag) as Boxaa
		// boxaaCopy(BOXAA *, l_int32) as BOXAA *
		///  <summary>
		/// (1) L_COPY makes a copy of each boxa in baas.
		/// L_CLONE makes a clone of each boxa in baas.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaCopy/*"/>
		///  <param name="baas">[in] - input boxaa to be copied</param>
		///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
		///   <returns>baad new boxaa, composed of copies or clones of the boxa in baas, or NULL on error</returns>
		public static Boxaa boxaaCopy(
						Boxaa baas,
						int copyflag)
		{
			if (baas == null) {throw new ArgumentNullException  ("baas cannot be Nothing");}

			IntPtr _Result = Natives.boxaaCopy(baas.Pointer,   copyflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1304, 1)
		// boxaaDestroy(pbaa) as Object
		// boxaaDestroy(BOXAA **) as void
		///  <summary>
		/// boxaaDestroy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaDestroy/*"/>
		///  <param name="pbaa">[in,out] - will be set to null before returning</param>
		public static void boxaaDestroy(
						ref Boxaa pbaa)
		{
			IntPtr pbaaPtr = IntPtr.Zero; 	if (pbaa != null) {pbaaPtr = pbaa.Pointer;}
			Natives.boxaaDestroy(ref pbaaPtr);
			if (pbaaPtr == IntPtr.Zero) {pbaa = null;} else { pbaa = new Boxaa(pbaaPtr); };
		}

		// boxbasic.c (1342, 1)
		// boxaaAddBoxa(baa, ba, copyflag) as int
		// boxaaAddBoxa(BOXAA *, BOXA *, l_int32) as l_ok
		///  <summary>
		/// boxaaAddBoxa()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaAddBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="ba">[in] - to be added</param>
		///  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaAddBoxa(
						Boxaa baa,
						Boxa ba,
						int copyflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (ba == null) {throw new ArgumentNullException  ("ba cannot be Nothing");}

			int _Result = Natives.boxaaAddBoxa(baa.Pointer, ba.Pointer,   copyflag);
			return _Result;
		}

		// boxbasic.c (1379, 1)
		// boxaaExtendArray(baa) as int
		// boxaaExtendArray(BOXAA *) as l_ok
		///  <summary>
		/// boxaaExtendArray()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendArray/*"/>
		///  <param name="baa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaExtendArray(
						Boxaa baa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaExtendArray(baa.Pointer);
			return _Result;
		}

		// boxbasic.c (1410, 1)
		// boxaaExtendArrayToSize(baa, size) as int
		// boxaaExtendArrayToSize(BOXAA *, l_int32) as l_ok
		///  <summary>
		/// (1) If necessary, reallocs the boxa ptr array to %size.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendArrayToSize/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="size">[in] - new size of boxa array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int boxaaExtendArrayToSize(
						Boxaa baa,
						int size)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaExtendArrayToSize(baa.Pointer,   size);
			return _Result;
		}

		// boxbasic.c (1439, 1)
		// boxaaGetCount(baa) as int
		// boxaaGetCount(BOXAA *) as l_int32
		///  <summary>
		/// boxaaGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetCount/*"/>
		///  <param name="baa">[in] - </param>
		///   <returns>count number of boxa, or 0 if no boxa or on error</returns>
		public static int boxaaGetCount(
						Boxaa baa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaGetCount(baa.Pointer);
			return _Result;
		}

		// boxbasic.c (1456, 1)
		// boxaaGetBoxCount(baa) as int
		// boxaaGetBoxCount(BOXAA *) as l_int32
		///  <summary>
		/// boxaaGetBoxCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBoxCount/*"/>
		///  <param name="baa">[in] - </param>
		///   <returns>count number of boxes, or 0 if no boxes or on error</returns>
		public static int boxaaGetBoxCount(
						Boxaa baa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaGetBoxCount(baa.Pointer);
			return _Result;
		}

		// boxbasic.c (1486, 1)
		// boxaaGetBoxa(baa, index, accessflag) as Boxa
		// boxaaGetBoxa(BOXAA *, l_int32, l_int32) as BOXA *
		///  <summary>
		/// boxaaGetBoxa()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="index">[in] - to the index-th boxa</param>
		///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaaGetBoxa(
						Boxaa baa,
						int index,
						int accessflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr _Result = Natives.boxaaGetBoxa(baa.Pointer,   index,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (1516, 1)
		// boxaaGetBox(baa, iboxa, ibox, accessflag) as Box
		// boxaaGetBox(BOXAA *, l_int32, l_int32, l_int32) as BOX *
		///  <summary>
		/// boxaaGetBox()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBox/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="iboxa">[in] - index into the boxa array in the boxaa</param>
		///  <param name="ibox">[in] - index into the box array in the boxa</param>
		///  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
		///   <returns>box, or NULL on error</returns>
		public static Box boxaaGetBox(
						Boxaa baa,
						int iboxa,
						int ibox,
						int accessflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr _Result = Natives.boxaaGetBox(baa.Pointer,   iboxa,   ibox,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Box(_Result);
		}

		// boxbasic.c (1568, 1)
		// boxaaInitFull(baa, boxa) as int
		// boxaaInitFull(BOXAA *, BOXA *) as l_ok
		///  <summary>
		/// (1) This initializes a boxaa by filling up the entire boxa ptr array
		/// with copies of %boxa.  Any existing boxa are destroyed.
		/// After this operation, the number of boxa is equal to
		/// the number of allocated ptrs.<para/>
		///
		/// (2) Note that we use boxaaReplaceBox() instead of boxaInsertBox().
		/// They both have the same effect when inserting into a NULL ptr
		/// in the boxa ptr array<para/>
		///
		/// (3) Example usage.  This function is useful to prepare for a
		/// random insertion (or replacement) of boxa into a boxaa.
		/// To randomly insert boxa into a boxaa, up to some index "max":
		/// Boxaa baa = boxaaCreate(max)
		/// // initialize the boxa
		/// Boxa boxa = boxaCreate(...)
		/// ...  [optionally fix with boxes]
		/// boxaaInitFull(baa, boxa)
		/// A typical use is to initialize the array with empty boxa,
		/// and to replace only a subset that must be aligned with
		/// something else, such as a pixa.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaInitFull/*"/>
		///  <param name="baa">[in] - typically empty</param>
		///  <param name="boxa">[in] - to be replicated into the entire ptr array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaInitFull(
						Boxaa baa,
						Boxa boxa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaaInitFull(baa.Pointer, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (1608, 1)
		// boxaaExtendWithInit(baa, maxindex, boxa) as int
		// boxaaExtendWithInit(BOXAA *, l_int32, BOXA *) as l_ok
		///  <summary>
		/// (1) This should be used on an existing boxaa that has been
		/// fully loaded with boxa.  It then extends the boxaa,
		/// loading all the additional ptrs with copies of boxa.
		/// Typically, boxa will be empty.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendWithInit/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="maxindex">[in] - </param>
		///  <param name="boxa">[in] - to be replicated into the extended ptr array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaExtendWithInit(
						Boxaa baa,
						int maxindex,
						Boxa boxa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaaExtendWithInit(baa.Pointer,   maxindex, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (1649, 1)
		// boxaaReplaceBoxa(baa, index, boxa) as int
		// boxaaReplaceBoxa(BOXAA *, l_int32, BOXA *) as l_ok
		///  <summary>
		/// (1) Any existing boxa is destroyed, and the input one
		/// is inserted in its place.<para/>
		///
		/// (2) If the index is invalid, return 1 (error)
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReplaceBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="index">[in] - to the index-th boxa</param>
		///  <param name="boxa">[in] - insert and replace any existing one</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaReplaceBoxa(
						Boxaa baa,
						int index,
						Boxa boxa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaaReplaceBoxa(baa.Pointer,   index, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (1690, 1)
		// boxaaInsertBoxa(baa, index, boxa) as int
		// boxaaInsertBoxa(BOXAA *, l_int32, BOXA *) as l_ok
		///  <summary>
		/// (1) This shifts boxa[i] to boxa[i + 1] for all i greater or equal index,
		/// and then inserts boxa as boxa[index].<para/>
		///
		/// (2) To insert at the beginning of the array, set index = 0.<para/>
		///
		/// (3) To append to the array, it's easier to use boxaaAddBoxa().<para/>
		///
		/// (4) This should not be used repeatedly to insert into large arrays,
		/// because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaInsertBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="index">[in] - location in boxaa to insert new boxa</param>
		///  <param name="boxa">[in] - new boxa to be inserted</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaInsertBoxa(
						Boxaa baa,
						int index,
						Boxa boxa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaaInsertBoxa(baa.Pointer,   index, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (1736, 1)
		// boxaaRemoveBoxa(baa, index) as int
		// boxaaRemoveBoxa(BOXAA *, l_int32) as l_ok
		///  <summary>
		/// (1) This removes boxa[index] and then shifts
		/// boxa[i] to boxa[i - 1] for all i  is greater  index.<para/>
		///
		/// (2) The removed boxaa is destroyed.<para/>
		///
		/// (2) This should not be used repeatedly on large arrays,
		/// because the function is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaRemoveBoxa/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="index">[in] - of the boxa to be removed</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaRemoveBoxa(
						Boxaa baa,
						int index)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaRemoveBoxa(baa.Pointer,   index);
			return _Result;
		}

		// boxbasic.c (1776, 1)
		// boxaaAddBox(baa, index, box, accessflag) as int
		// boxaaAddBox(BOXAA *, l_int32, BOX *, l_int32) as l_ok
		///  <summary>
		/// (1) Adds to an existing boxa only.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaAddBox/*"/>
		///  <param name="baa">[in] - </param>
		///  <param name="index">[in] - of boxa with boxaa</param>
		///  <param name="box">[in] - to be added</param>
		///  <param name="accessflag">[in] - L_INSERT, L_COPY or L_CLONE</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaAddBox(
						Boxaa baa,
						int index,
						Box box,
						int accessflag)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxaaAddBox(baa.Pointer,   index, box.Pointer,   accessflag);
			return _Result;
		}

		// boxbasic.c (1824, 1)
		// boxaaReadFromFiles(dirname, substr, first, nfiles) as Boxaa
		// boxaaReadFromFiles(const char *, const char *, l_int32, l_int32) as BOXAA *
		///  <summary>
		/// (1) The files must be serialized boxa files (e.g., .ba).
		/// If some files cannot be read, warnings are issued.<para/>
		///
		/// (2) Use %substr to filter filenames in the directory.  If
		/// %substr == NULL, this takes all files.<para/>
		///
		/// (3) After filtering, use %first and %nfiles to select
		/// a contiguous set of files, that have been lexically
		/// sorted in increasing order.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadFromFiles/*"/>
		///  <param name="dirname">[in] - directory</param>
		///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
		///  <param name="first">[in] - 0-based</param>
		///  <param name="nfiles">[in] - use 0 for everything from %first to the end</param>
		///   <returns>baa, or NULL on error or if no boxa files are found.</returns>
		public static Boxaa boxaaReadFromFiles(
						String dirname,
						String substr,
						int first,
						int nfiles)
		{
			if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}

			IntPtr _Result = Natives.boxaaReadFromFiles(  dirname,   substr,   first,   nfiles);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1868, 1)
		// boxaaRead(filename) as Boxaa
		// boxaaRead(const char *) as BOXAA *
		///  <summary>
		/// boxaaRead()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaRead/*"/>
		///  <param name="filename">[in] - </param>
		///   <returns>boxaa, or NULL on error</returns>
		public static Boxaa boxaaRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.boxaaRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1895, 1)
		// boxaaReadStream(fp) as Boxaa
		// boxaaReadStream(FILE *) as BOXAA *
		///  <summary>
		/// boxaaReadStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>boxaa, or NULL on error</returns>
		public static Boxaa boxaaReadStream(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.boxaaReadStream(fp.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1940, 1)
		// boxaaReadMem(data, size) as Boxaa
		// boxaaReadMem(const l_uint8 *, size_t) as BOXAA *
		///  <summary>
		/// boxaaReadMem()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadMem/*"/>
		///  <param name="data">[in] - serialization of boxaa in ascii</param>
		///  <param name="size">[in] - of data in bytes can use strlen to get it</param>
		///   <returns>baa, or NULL on error</returns>
		public static Boxaa boxaaReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.boxaaReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxaa(_Result);
		}

		// boxbasic.c (1968, 1)
		// boxaaWrite(filename, baa) as int
		// boxaaWrite(const char *, BOXAA *) as l_ok
		///  <summary>
		/// boxaaWrite()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWrite/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="baa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaWrite(
						String filename,
						Boxaa baa)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaWrite(  filename, baa.Pointer);
			return _Result;
		}

		// boxbasic.c (1999, 1)
		// boxaaWriteStream(fp, baa) as int
		// boxaaWriteStream(FILE *, BOXAA *) as l_ok
		///  <summary>
		/// boxaaWriteStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWriteStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="baa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaWriteStream(
						FILE fp,
						Boxaa baa)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			int _Result = Natives.boxaaWriteStream(fp.Pointer, baa.Pointer);
			return _Result;
		}

		// boxbasic.c (2046, 1)
		// boxaaWriteMem(pdata, psize, baa) as int
		// boxaaWriteMem(l_uint8 **, size_t *, BOXAA *) as l_ok
		///  <summary>
		/// (1) Serializes a boxaa in memory and puts the result in a buffer.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWriteMem/*"/>
		///  <param name="pdata">[out] - data of serialized boxaa ascii</param>
		///  <param name="psize">[out] - size of returned data</param>
		///  <param name="baa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaaWriteMem(
						out Byte[] pdata,
						out uint psize,
						Boxaa baa)
		{
			if (baa == null) {throw new ArgumentNullException  ("baa cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.boxaaWriteMem(out  pdataPtr, out  psize, baa.Pointer);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// boxbasic.c (2096, 1)
		// boxaRead(filename) as Boxa
		// boxaRead(const char *) as BOXA *
		///  <summary>
		/// boxaRead()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRead/*"/>
		///  <param name="filename">[in] - </param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaRead(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};

			IntPtr _Result = Natives.boxaRead(  filename);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (2123, 1)
		// boxaReadStream(fp) as Boxa
		// boxaReadStream(FILE *) as BOXA *
		///  <summary>
		/// boxaReadStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReadStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaReadStream(
						FILE fp)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			IntPtr _Result = Natives.boxaReadStream(fp.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (2166, 1)
		// boxaReadMem(data, size) as Boxa
		// boxaReadMem(const l_uint8 *, size_t) as BOXA *
		///  <summary>
		/// boxaReadMem()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReadMem/*"/>
		///  <param name="data">[in] - serialization of boxa in ascii</param>
		///  <param name="size">[in] - of data in bytes can use strlen to get it</param>
		///   <returns>boxa, or NULL on error</returns>
		public static Boxa boxaReadMem(
						Byte[] data,
						uint size)
		{
			if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}

			IntPtr _Result = Natives.boxaReadMem(  data,   size);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// boxbasic.c (2203, 1)
		// boxaWriteDebug(filename, boxa) as int
		// boxaWriteDebug(const char *, BOXA *) as l_ok
		///  <summary>
		/// (1) Debug version, intended for use in the library when writing
		/// to files in a temp directory with names that are compiled in.
		/// This is used instead of boxaWrite() for all such library calls.<para/>
		///
		/// (2) The global variable LeptDebugOK defaults to 0, and can be set
		/// or cleared by the function setLeptDebugOK().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteDebug/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK 1 on error</returns>
		public static int boxaWriteDebug(
						String filename,
						Boxa boxa)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaWriteDebug(  filename, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (2225, 1)
		// boxaWrite(filename, boxa) as int
		// boxaWrite(const char *, BOXA *) as l_ok
		///  <summary>
		/// boxaWrite()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWrite/*"/>
		///  <param name="filename">[in] - </param>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaWrite(
						String filename,
						Boxa boxa)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaWrite(  filename, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (2257, 1)
		// boxaWriteStream(fp, boxa) as int
		// boxaWriteStream(FILE *, BOXA *) as l_ok
		///  <summary>
		/// boxaWriteStream()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteStream/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaWriteStream(
						FILE fp,
						Boxa boxa)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			int _Result = Natives.boxaWriteStream(fp.Pointer, boxa.Pointer);
			return _Result;
		}

		// boxbasic.c (2298, 1)
		// boxaWriteMem(pdata, psize, boxa) as int
		// boxaWriteMem(l_uint8 **, size_t *, BOXA *) as l_ok
		///  <summary>
		/// (1) Serializes a boxa in memory and puts the result in a buffer.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteMem/*"/>
		///  <param name="pdata">[out] - data of serialized boxa ascii</param>
		///  <param name="psize">[out] - size of returned data</param>
		///  <param name="boxa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxaWriteMem(
						out Byte[] pdata,
						out uint psize,
						Boxa boxa)
		{
			if (boxa == null) {throw new ArgumentNullException  ("boxa cannot be Nothing");}

			IntPtr pdataPtr = IntPtr.Zero;
			int _Result = Natives.boxaWriteMem(out  pdataPtr, out  psize, boxa.Pointer);
			Byte[] pdataGen = new Byte[psize];

			if (pdataPtr != IntPtr.Zero) {
				Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
			}

			pdata = pdataGen;
			return _Result;
		}

		// boxbasic.c (2355, 1)
		// boxPrintStreamInfo(fp, box) as int
		// boxPrintStreamInfo(FILE *, BOX *) as l_ok
		///  <summary>
		/// (1) This outputs debug info.  Use serialization functions to
		/// write to file if you want to read the data back.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxPrintStreamInfo/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="box">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int boxPrintStreamInfo(
						FILE fp,
						Box box)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (box == null) {throw new ArgumentNullException  ("box cannot be Nothing");}

			int _Result = Natives.boxPrintStreamInfo(fp.Pointer, box.Pointer);
			return _Result;
		}


	}
}
