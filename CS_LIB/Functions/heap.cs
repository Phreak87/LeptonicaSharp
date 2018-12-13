using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// heap.c (102, 1)
		// lheapCreate(nalloc, direction) as L_Heap
		// lheapCreate(l_int32, l_int32) as L_HEAP *
		///  <summary>
		/// lheapCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapCreate/*"/>
		///  <param name="nalloc">[in] - size of ptr array to be alloc'd 0 for default</param>
		///  <param name="direction">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
		///   <returns>lheap, or NULL on error</returns>
		public static L_Heap lheapCreate(
						int nalloc,
						int direction)
		{
			IntPtr _Result = Natives.lheapCreate(  nalloc,   direction);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Heap(_Result);
		}

		// heap.c (145, 1)
		// lheapDestroy(plh, freeflag) as Object
		// lheapDestroy(L_HEAP **, l_int32) as void
		///  <summary>
		/// (1) Use freeflag == TRUE when the items in the array can be
		/// simply destroyed using free.  If those items require their
		/// own destroy function, they must be destroyed before
		/// calling this function, and then this function is called
		/// with freeflag == FALSE.<para/>
		///
		/// (2) To destroy the lheap, we destroy the ptr array, then
		/// the lheap, and then null the contents of the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapDestroy/*"/>
		///  <param name="plh">[in,out] - to be nulled</param>
		///  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
		public static void lheapDestroy(
						ref L_Heap plh,
						int freeflag)
		{
			IntPtr plhPtr = IntPtr.Zero; 	if (plh != null) {plhPtr = plh.Pointer;}
			Natives.lheapDestroy(ref plhPtr,   freeflag);
			if (plhPtr == IntPtr.Zero) {plh = null;} else { plh = new L_Heap(plhPtr); };
		}

		// heap.c (186, 1)
		// lheapAdd(lh, item) as int
		// lheapAdd(L_HEAP *, void *) as l_ok
		///  <summary>
		/// lheapAdd()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapAdd/*"/>
		///  <param name="lh">[in] - heap</param>
		///  <param name="item">[in] - to be added to the tail of the heap</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lheapAdd(
						L_Heap lh,
						Object item)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			if (item == null) {throw new ArgumentNullException  ("item cannot be Nothing");}

			IntPtr itemPtr = IntPtr.Zero;

			if (item.GetType() == typeof(IntPtr)) {
				itemPtr = (IntPtr)item;
			} else if (item.GetType() == typeof(Byte[])) {
				var cdata = (Byte[])item;
				itemPtr = Marshal.AllocHGlobal(cdata.Length);
				Marshal.Copy(cdata, 0, itemPtr, cdata.Length);
			} else if (item.GetType().GetProperty("item") != null) {
				var cdata = (Byte[])item.GetType().GetProperty("data").GetValue(item, null);
				itemPtr = Marshal.AllocHGlobal(cdata.Length);
				Marshal.Copy(cdata, 0, itemPtr, cdata.Length);
			}

			int _Result = Natives.lheapAdd(lh.Pointer,   itemPtr);
			Marshal.FreeHGlobal(itemPtr);
			return _Result;
		}

		// heap.c (242, 1)
		// lheapRemove(lh) as Object
		// lheapRemove(L_HEAP *) as void *
		///  <summary>
		/// lheapRemove()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapRemove/*"/>
		///  <param name="lh">[in] - heap</param>
		///   <returns>ptr to item popped from the root of the heap, or NULL if the heap is empty or on error</returns>
		public static Object lheapRemove(
						L_Heap lh)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			IntPtr _Result = Natives.lheapRemove(lh.Pointer);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// heap.c (271, 1)
		// lheapGetCount(lh) as int
		// lheapGetCount(L_HEAP *) as l_int32
		///  <summary>
		/// lheapGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapGetCount/*"/>
		///  <param name="lh">[in] - heap</param>
		///   <returns>count, or 0 on error</returns>
		public static int lheapGetCount(
						L_Heap lh)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapGetCount(lh.Pointer);
			return _Result;
		}

		// heap.c (304, 1)
		// lheapSwapUp(lh, index) as int
		// lheapSwapUp(L_HEAP *, l_int32) as l_ok
		///  <summary>
		/// (1) This is called after a new item is put on the heap, at the
		/// bottom of a complete tree.<para/>
		///
		/// (2) To regain the heap order, we let it bubble up,
		/// iteratively swapping with its parent, until it either
		/// reaches the root of the heap or it finds a parent that
		/// is in the correct position already vis-a-vis the child.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSwapUp/*"/>
		///  <param name="lh">[in] - heap</param>
		///  <param name="index">[in] - of array corresponding to node to be swapped up</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lheapSwapUp(
						L_Heap lh,
						int index)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapSwapUp(lh.Pointer,   index);
			return _Result;
		}

		// heap.c (370, 1)
		// lheapSwapDown(lh) as int
		// lheapSwapDown(L_HEAP *) as l_ok
		///  <summary>
		/// (1) This is called after an item has been popped off the
		/// root of the heap, and the last item in the heap has
		/// been placed at the root.<para/>
		///
		/// (2) To regain the heap order, we let it bubble down,
		/// iteratively swapping with one of its children.  For a
		/// decreasing sort, it swaps with the largest child for
		/// an increasing sort, the smallest.  This continues until
		/// it either reaches the lowest level in the heap, or the
		/// parent finds that neither child should swap with it
		/// (e.g., for a decreasing heap, the parent is larger
		/// than or equal to both children).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSwapDown/*"/>
		///  <param name="lh">[in] - heap</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lheapSwapDown(
						L_Heap lh)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapSwapDown(lh.Pointer);
			return _Result;
		}

		// heap.c (453, 1)
		// lheapSort(lh) as int
		// lheapSort(L_HEAP *) as l_ok
		///  <summary>
		/// (1) This sorts an array into heap order.  If the heap is already
		/// in heap order for the direction given, this has no effect.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSort/*"/>
		///  <param name="lh">[in] - heap, with internal array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lheapSort(
						L_Heap lh)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapSort(lh.Pointer);
			return _Result;
		}

		// heap.c (487, 1)
		// lheapSortStrictOrder(lh) as int
		// lheapSortStrictOrder(L_HEAP *) as l_ok
		///  <summary>
		/// (1) This sorts a heap into strict order.<para/>
		///
		/// (2) For each element, starting at the end of the array and
		/// working forward, the element is swapped with the head
		/// element and then allowed to swap down onto a heap of
		/// size reduced by one.  The result is that the heap is
		/// reversed but in strict order.  The array elements are
		/// then reversed to put it in the original order.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSortStrictOrder/*"/>
		///  <param name="lh">[in] - heap, with internal array</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lheapSortStrictOrder(
						L_Heap lh)
		{
			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapSortStrictOrder(lh.Pointer);
			return _Result;
		}

		// heap.c (524, 1)
		// lheapPrint(fp, lh) as int
		// lheapPrint(FILE *, L_HEAP *) as l_ok
		///  <summary>
		/// lheapPrint()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapPrint/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="lh">[in] - heap</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int lheapPrint(
						FILE fp,
						L_Heap lh)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (lh == null) {throw new ArgumentNullException  ("lh cannot be Nothing");}

			int _Result = Natives.lheapPrint(fp.Pointer, lh.Pointer);
			return _Result;
		}


	}
}
