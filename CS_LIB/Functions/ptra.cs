using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// ptra.c (139, 1)
		// ptraCreate(n) as L_Ptra
		// ptraCreate(l_int32) as L_PTRA *
		///  <summary>
		/// ptraCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraCreate/*"/>
		///  <param name="n">[in] - size of ptr array to be alloc'd 0 for default</param>
		///   <returns>pa, or NULL on error</returns>
		public static L_Ptra ptraCreate(
						int n)
		{
			IntPtr _Result = Natives.ptraCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Ptra(_Result);
		}

		// ptra.c (185, 1)
		// ptraDestroy(ppa, freeflag, warnflag) as Object
		// ptraDestroy(L_PTRA **, l_int32, l_int32) as void
		///  <summary>
		/// (1) If %freeflag == TRUE, frees each item in the array.<para/>
		///
		/// (2) If %freeflag == FALSE and %warnflag == TRUE, and there are
		/// items on the array, this gives a warning and destroys the array.
		/// If these items are not owned elsewhere, this will cause
		/// a memory leak of all the items that were on the array.
		/// So if the items are not owned elsewhere and require their
		/// own destroy function, they must be destroyed before the ptra.<para/>
		///
		/// (3) If %warnflag == FALSE, no warnings will be issued.  This is
		/// useful if the items are owned elsewhere, such as a
		/// PixMemoryStore().<para/>
		///
		/// (4) To destroy the ptra, we destroy the ptr array, then
		/// the ptra, and then null the contents of the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraDestroy/*"/>
		///  <param name="ppa">[in,out] - ptra to be nulled</param>
		///  <param name="freeflag">[in] - TRUE to free each remaining item in the array</param>
		///  <param name="warnflag">[in] - TRUE to warn if any remaining items are not destroyed</param>
		public static void ptraDestroy(
						ref L_Ptra ppa,
						int freeflag,
						int warnflag)
		{
			IntPtr ppaPtr = IntPtr.Zero; 	if (ppa != null) {ppaPtr = ppa.Pointer;}
			Natives.ptraDestroy(ref ppaPtr,   freeflag,   warnflag);
			if (ppaPtr == IntPtr.Zero) {ppa = null;} else { ppa = new L_Ptra(ppaPtr); };
		}

		// ptra.c (242, 1)
		// ptraAdd(pa, item) as int
		// ptraAdd(L_PTRA *, void *) as l_ok
		///  <summary>
		/// (1) This adds the element to the next location beyond imax,
		/// which is the largest occupied ptr in the array.  This is
		/// what you expect from a stack, where all ptrs up to and
		/// including imax are occupied, but here the occuption of
		/// items in the array is entirely arbitrary.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraAdd/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="item">[in] - generic ptr to a struct</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraAdd(
						L_Ptra pa,
						Object item)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			if (item == null) {throw new ArgumentNullException  ("item cannot be Nothing");}

			IntPtr itemPtr = 	Marshal.AllocHGlobal(0);
			// Todo: Functions.cs:SecureIn - Define coversation for object type
			int _Result = Natives.ptraAdd(pa.Pointer,   itemPtr);
			Marshal.FreeHGlobal(itemPtr);
			return _Result;
		}

		// ptra.c (336, 1)
		// ptraInsert(pa, index, item, shiftflag) as int
		// ptraInsert(L_PTRA *, l_int32, void *, l_int32) as l_ok
		///  <summary>
		/// (1) This checks first to see if the location is valid, and
		/// then if there is presently an item there.  If there is not,
		/// it is simply inserted into that location.<para/>
		///
		/// (2) If there is an item at the insert location, items must be
		/// moved down to make room for the insert.  In the downward
		/// shift there are three options, given by %shiftflag.
		/// ~ If %shiftflag == L_AUTO_DOWNSHIFT, a decision is made
		/// whether, in a cascade of items, to downshift a minimum
		/// amount or for all items above %index.  The decision is
		/// based on the expectation of finding holes (null ptrs)
		/// between %index and the bottom of the array.
		/// Assuming the holes are distributed uniformly, if 2 or more
		/// holes are expected, we do a minimum shift.
		/// ~ If %shiftflag == L_MIN_DOWNSHIFT, the downward shifting
		/// cascade of items progresses a minimum amount, until
		/// the first empty slot is reached.  This mode requires
		/// some computation before the actual shifting is done.
		/// ~ If %shiftflag == L_FULL_DOWNSHIFT, a shifting cascade is
		/// performed where pa[i] to pa[i + 1] for all i greater or equal index.
		/// Then, the item is inserted at pa[index].<para/>
		///
		/// (3) If you are not using L_AUTO_DOWNSHIFT, the rule of thumb is
		/// to use L_FULL_DOWNSHIFT if the array is compacted (each
		/// element points to an item), and to use L_MIN_DOWNSHIFT
		/// if there are a significant number of null pointers.
		/// There is no penalty to using L_MIN_DOWNSHIFT for a
		/// compacted array, however, because the full shift is required
		/// and we don't do the O(n) computation to look for holes.<para/>
		///
		/// (4) This should not be used repeatedly on large arrays,
		/// because the function is generally O(n).<para/>
		///
		/// (5) However, it can be used repeatedly if we start with an empty
		/// ptr array and insert only once at each location.  For example,
		/// you can support an array of Numa, where at each ptr location
		/// you store either 0 or 1 Numa, and the Numa can be added
		/// randomly to the ptr array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraInsert/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="index">[in] - location in ptra to insert new value</param>
		///  <param name="item">[in] - generic ptr to a struct can be null</param>
		///  <param name="shiftflag">[in] - L_AUTO_DOWNSHIFT, L_MIN_DOWNSHIFT, L_FULL_DOWNSHIFT</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraInsert(
						L_Ptra pa,
						int index,
						Object item,
						int shiftflag)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			if (item == null) {throw new ArgumentNullException  ("item cannot be Nothing");}

			IntPtr itemPtr = 	Marshal.AllocHGlobal(0);
			// Todo: Functions.cs:SecureIn - Define coversation for object type
			int _Result = Natives.ptraInsert(pa.Pointer,   index,   itemPtr,   shiftflag);
			Marshal.FreeHGlobal(itemPtr);
			return _Result;
		}

		// ptra.c (434, 1)
		// ptraRemove(pa, index, flag) as Object
		// ptraRemove(L_PTRA *, l_int32, l_int32) as void *
		///  <summary>
		/// (1) If flag == L_NO_COMPACTION, this removes the item and
		/// nulls the ptr on the array.  If it takes the last item
		/// in the array, paton is reduced to the next item.<para/>
		///
		/// (2) If flag == L_COMPACTION, this compacts the array for
		/// for all i greater or equal index.  It should not be used repeatedly on
		/// large arrays, because compaction is O(n).<para/>
		///
		/// (3) The ability to remove without automatic compaction allows
		/// removal with cost O(1).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraRemove/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="index">[in] - element to be removed</param>
		///  <param name="flag">[in] - L_NO_COMPACTION, L_COMPACTION</param>
		///   <returns>item, or NULL on error</returns>
		public static Object ptraRemove(
						L_Ptra pa,
						int index,
						int flag)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			IntPtr _Result = Natives.ptraRemove(pa.Pointer,   index,   flag);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// ptra.c (483, 1)
		// ptraRemoveLast(pa) as Object
		// ptraRemoveLast(L_PTRA *) as void *
		///  <summary>
		/// ptraRemoveLast()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraRemoveLast/*"/>
		///  <param name="pa">[in] - ptra</param>
		///   <returns>item, or NULL on error or if the array is empty</returns>
		public static Object ptraRemoveLast(
						L_Ptra pa)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			IntPtr _Result = Natives.ptraRemoveLast(pa.Pointer);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// ptra.c (512, 1)
		// ptraReplace(pa, index, item, freeflag) as Object
		// ptraReplace(L_PTRA *, l_int32, void *, l_int32) as void *
		///  <summary>
		/// ptraReplace()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraReplace/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="index">[in] - element to be replaced</param>
		///  <param name="item">[in] - new generic ptr to a struct can be null</param>
		///  <param name="freeflag">[in] - TRUE to free old item FALSE to return it</param>
		///   <returns>item  old item, if it exists and is not freed, or NULL on error</returns>
		public static Object ptraReplace(
						L_Ptra pa,
						int index,
						Object item,
						int freeflag)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			if (item == null) {throw new ArgumentNullException  ("item cannot be Nothing");}

			IntPtr itemPtr = 	Marshal.AllocHGlobal(0);
			// Todo: Functions.cs:SecureIn - Define coversation for object type
			IntPtr _Result = Natives.ptraReplace(pa.Pointer,   index,   itemPtr,   freeflag);
			Marshal.FreeHGlobal(itemPtr);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// ptra.c (553, 1)
		// ptraSwap(pa, index1, index2) as int
		// ptraSwap(L_PTRA *, l_int32, l_int32) as l_ok
		///  <summary>
		/// ptraSwap()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraSwap/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="index1">[in] - </param>
		///  <param name="index2">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraSwap(
						L_Ptra pa,
						int index1,
						int index2)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraSwap(pa.Pointer,   index1,   index2);
			return _Result;
		}

		// ptra.c (590, 1)
		// ptraCompactArray(pa) as int
		// ptraCompactArray(L_PTRA *) as l_ok
		///  <summary>
		/// (1) This compacts the items on the array, filling any empty ptrs.<para/>
		///
		/// (2) This does not change the size of the array of ptrs.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraCompactArray/*"/>
		///  <param name="pa">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraCompactArray(
						L_Ptra pa)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraCompactArray(pa.Pointer);
			return _Result;
		}

		// ptra.c (625, 1)
		// ptraReverse(pa) as int
		// ptraReverse(L_PTRA *) as l_ok
		///  <summary>
		/// ptraReverse()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraReverse/*"/>
		///  <param name="pa">[in] - ptra</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraReverse(
						L_Ptra pa)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraReverse(pa.Pointer);
			return _Result;
		}

		// ptra.c (649, 1)
		// ptraJoin(pa1, pa2) as int
		// ptraJoin(L_PTRA *, L_PTRA *) as l_ok
		///  <summary>
		/// ptraJoin()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraJoin/*"/>
		///  <param name="pa1">[in] - add to this one</param>
		///  <param name="pa2">[in] - appended to pa1, and emptied of items can be null</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int ptraJoin(
						L_Ptra pa1,
						L_Ptra pa2)
		{
			if (pa1 == null) {throw new ArgumentNullException  ("pa1 cannot be Nothing");}

			if (pa2 == null) {throw new ArgumentNullException  ("pa2 cannot be Nothing");}

			int _Result = Natives.ptraJoin(pa1.Pointer, pa2.Pointer);
			return _Result;
		}

		// ptra.c (699, 1)
		// ptraGetMaxIndex(pa, pmaxindex) as int
		// ptraGetMaxIndex(L_PTRA *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The largest index to an item in the array is %maxindex.
		/// %maxindex is one less than the number of items that would be
		/// in the array if there were no null pointers between 0
		/// and %maxindex - 1.  However, because the internal ptr array
		/// need not be compacted, there may be NULL pointers at
		/// indices below %maxindex for example, if items have
		/// been removed.<para/>
		///
		/// (2) When an item is added to the end of the array, it goes
		/// into patoarray[maxindex + 1], and maxindex is then
		/// incremented by 1.<para/>
		///
		/// (3) If there are no items in the array, this returns %maxindex = -1.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraGetMaxIndex/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="pmaxindex">[out] - index of last item in the array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptraGetMaxIndex(
						L_Ptra pa,
						out int pmaxindex)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraGetMaxIndex(pa.Pointer, out  pmaxindex);
			return _Result;
		}

		// ptra.c (727, 1)
		// ptraGetActualCount(pa, pcount) as int
		// ptraGetActualCount(L_PTRA *, l_int32 *) as l_ok
		///  <summary>
		/// (1) The actual number of items on the ptr array, patonactual,
		/// will be smaller than paton if the array is not compacted.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraGetActualCount/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="pcount">[out] - actual number of items on the ptr array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptraGetActualCount(
						L_Ptra pa,
						out int pcount)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraGetActualCount(pa.Pointer, out  pcount);
			return _Result;
		}

		// ptra.c (759, 1)
		// ptraGetPtrToItem(pa, index) as Object
		// ptraGetPtrToItem(L_PTRA *, l_int32) as void *
		///  <summary>
		/// (1) This returns a ptr to the item.  You must cast it to
		/// the type of item.  Do not destroy it the item belongs
		/// to the Ptra.<para/>
		///
		/// (2) This can access all possible items on the ptr array.
		/// If an item doesn't exist, it returns null.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraGetPtrToItem/*"/>
		///  <param name="pa">[in] - ptra</param>
		///  <param name="index">[in] - of element to be retrieved</param>
		///   <returns>a ptr to the element, or NULL on error</returns>
		public static Object ptraGetPtrToItem(
						L_Ptra pa,
						int index)
		{
			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			IntPtr _Result = Natives.ptraGetPtrToItem(pa.Pointer,   index);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// ptra.c (790, 1)
		// ptraaCreate(n) as L_Ptraa
		// ptraaCreate(l_int32) as L_PTRAA *
		///  <summary>
		/// (1) The ptraa is generated with a fixed size, that can not change.
		/// The ptra can be generated and inserted randomly into this array.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaCreate/*"/>
		///  <param name="n">[in] - size of ptr array to be alloc'd</param>
		///   <returns>paa, or NULL on error</returns>
		public static L_Ptraa ptraaCreate(
						int n)
		{
			IntPtr _Result = Natives.ptraaCreate(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Ptraa(_Result);
		}

		// ptra.c (826, 1)
		// ptraaDestroy(ppaa, freeflag, warnflag) as Object
		// ptraaDestroy(L_PTRAA **, l_int32, l_int32) as void
		///  <summary>
		/// (1) See ptraDestroy() for use of %freeflag and %warnflag.<para/>
		///
		/// (2) To destroy the ptraa, we destroy each ptra, then the ptr array,
		/// then the ptraa, and then null the contents of the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaDestroy/*"/>
		///  <param name="ppaa">[in,out] - to be nulled</param>
		///  <param name="freeflag">[in] - TRUE to free each remaining item in each ptra</param>
		///  <param name="warnflag">[in] - TRUE to warn if any remaining items are not destroyed</param>
		public static void ptraaDestroy(
						ref L_Ptraa ppaa,
						int freeflag,
						int warnflag)
		{
			IntPtr ppaaPtr = IntPtr.Zero; 	if (ppaa != null) {ppaaPtr = ppaa.Pointer;}
			Natives.ptraaDestroy(ref ppaaPtr,   freeflag,   warnflag);
			if (ppaaPtr == IntPtr.Zero) {ppaa = null;} else { ppaa = new L_Ptraa(ppaaPtr); };
		}

		// ptra.c (867, 1)
		// ptraaGetSize(paa, psize) as int
		// ptraaGetSize(L_PTRAA *, l_int32 *) as l_ok
		///  <summary>
		/// ptraaGetSize()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaGetSize/*"/>
		///  <param name="paa">[in] - </param>
		///  <param name="psize">[out] - size of ptr array</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptraaGetSize(
						L_Ptraa paa,
						out int psize)
		{
			if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}

			int _Result = Natives.ptraaGetSize(paa.Pointer, out  psize);
			return _Result;
		}

		// ptra.c (898, 1)
		// ptraaInsertPtra(paa, index, pa) as int
		// ptraaInsertPtra(L_PTRAA *, l_int32, L_PTRA *) as l_ok
		///  <summary>
		/// (1) Caller should check return value.  On success, the Ptra
		/// is inserted in the Ptraa and is owned by it.  However,
		/// on error, the Ptra remains owned by the caller.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaInsertPtra/*"/>
		///  <param name="paa">[in] - ptraa</param>
		///  <param name="index">[in] - location in array for insertion</param>
		///  <param name="pa">[in] - to be inserted</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int ptraaInsertPtra(
						L_Ptraa paa,
						int index,
						L_Ptra pa)
		{
			if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}

			if (pa == null) {throw new ArgumentNullException  ("pa cannot be Nothing");}

			int _Result = Natives.ptraaInsertPtra(paa.Pointer,   index, pa.Pointer);
			return _Result;
		}

		// ptra.c (941, 1)
		// ptraaGetPtra(paa, index, accessflag) as L_Ptra
		// ptraaGetPtra(L_PTRAA *, l_int32, l_int32) as L_PTRA *
		///  <summary>
		/// (1) This returns the ptra ptr.  If %accessflag == L_HANDLE_ONLY,
		/// the ptra is left on the ptraa.  If %accessflag == L_REMOVE,
		/// the ptr in the ptraa is set to NULL, and the caller
		/// is responsible for disposing of the ptra (either putting it
		/// back on the ptraa, or destroying it).<para/>
		///
		/// (2) This returns NULL if there is no Ptra at the index location.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaGetPtra/*"/>
		///  <param name="paa">[in] - ptraa</param>
		///  <param name="index">[in] - location in array</param>
		///  <param name="accessflag">[in] - L_HANDLE_ONLY, L_REMOVE</param>
		///   <returns>ptra at index location, or NULL on error or if there is no ptra there.</returns>
		public static L_Ptra ptraaGetPtra(
						L_Ptraa paa,
						int index,
						int accessflag)
		{
			if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}

			IntPtr _Result = Natives.ptraaGetPtra(paa.Pointer,   index,   accessflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Ptra(_Result);
		}

		// ptra.c (983, 1)
		// ptraaFlattenToPtra(paa) as L_Ptra
		// ptraaFlattenToPtra(L_PTRAA *) as L_PTRA *
		///  <summary>
		/// (1) This 'flattens' the ptraa to a ptra, taking the items in
		/// each ptra, in order, starting with the first ptra, etc.<para/>
		///
		/// (2) As a side-effect, the ptra are all removed from the ptraa
		/// and destroyed, leaving an empty ptraa.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptraaFlattenToPtra/*"/>
		///  <param name="paa">[in] - ptraa</param>
		///   <returns>ptra, or NULL on error</returns>
		public static L_Ptra ptraaFlattenToPtra(
						L_Ptraa paa)
		{
			if (paa == null) {throw new ArgumentNullException  ("paa cannot be Nothing");}

			IntPtr _Result = Natives.ptraaFlattenToPtra(paa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Ptra(_Result);
		}


	}
}
