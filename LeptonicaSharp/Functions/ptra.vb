Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\ptra.c (139, 1)
' ptraCreate()
' ptraCreate(l_int32) as L_PTRA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of ptr array to be alloc'd 0 for default</param>
'''   <returns>pa, or NULL on error</returns>
Public Shared Function ptraCreate(
				ByVal n as Integer) as L_Ptra



	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Ptra(_Result)
End Function

' SRC\ptra.c (185, 1)
' ptraDestroy()
' ptraDestroy(L_PTRA **, l_int32, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If %freeflag == TRUE, frees each item in the array.<para/>
''' (2) If %freeflag == FALSE and %warnflag == TRUE, and there are<para/>
''' items on the array, this gives a warning and destroys the array.<para/>
''' If these items are not owned elsewhere, this will cause<para/>
''' a memory leak of all the items that were on the array.<para/>
''' So if the items are not owned elsewhere and require their<para/>
''' own destroy function, they must be destroyed before the ptra.<para/>
''' (3) If %warnflag == FALSE, no warnings will be issued.  This is<para/>
''' useful if the items are owned elsewhere, such as a<para/>
''' PixMemoryStore().<para/>
''' (4) To destroy the ptra, we destroy the ptr array, then<para/>
''' the ptra, and then null the contents of the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppa">[in,out] - ptra to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining item in the array</param>
'''  <param name="warnflag">[in] - TRUE to warn if any remaining items are not destroyed</param>
Public Shared Sub ptraDestroy(
				ByRef ppa as L_Ptra, 
				ByVal freeflag as Integer, 
				ByVal warnflag as Integer)


	Dim ppaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppa) Then ppaPTR = ppa.Pointer

	LeptonicaSharp.Natives.ptraDestroy( ppaPTR, freeflag, warnflag)
	if ppaPTR <> IntPtr.Zero then ppa = new L_Ptra(ppaPTR)

End Sub

' SRC\ptra.c (242, 1)
' ptraAdd()
' ptraAdd(L_PTRA *, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This adds the element to the next location beyond imax,<para/>
''' which is the largest occupied ptr in the array.  This is<para/>
''' what you expect from a stack, where all ptrs up to and<para/>
''' including imax are occupied, but here the occuption of<para/>
''' items in the array is entirely arbitrary.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="item">[in] - generic ptr to a struct</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraAdd(
				ByVal pa as L_Ptra, 
				ByVal item as Object) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")

Dim itemPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.ptraAdd( pa.Pointer, itemPTR)

	Return _Result
End Function

' SRC\ptra.c (336, 1)
' ptraInsert()
' ptraInsert(L_PTRA *, l_int32, void *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This checks first to see if the location is valid, and<para/>
''' then if there is presently an item there.  If there is not,<para/>
''' it is simply inserted into that location.<para/>
''' (2) If there is an item at the insert location, items must be<para/>
''' moved down to make room for the insert.  In the downward<para/>
''' shift there are three options, given by %shiftflag.<para/>
''' ~ If %shiftflag == L_AUTO_DOWNSHIFT, a decision is made<para/>
''' whether, in a cascade of items, to downshift a minimum<para/>
''' amount or for all items above %index.  The decision is<para/>
''' based on the expectation of finding holes (null ptrs)<para/>
''' between %index and the bottom of the array.<para/>
''' Assuming the holes are distributed uniformly, if 2 or more<para/>
''' holes are expected, we do a minimum shift.<para/>
''' ~ If %shiftflag == L_MIN_DOWNSHIFT, the downward shifting<para/>
''' cascade of items progresses a minimum amount, until<para/>
''' the first empty slot is reached.  This mode requires<para/>
''' some computation before the actual shifting is done.<para/>
''' ~ If %shiftflag == L_FULL_DOWNSHIFT, a shifting cascade is<para/>
''' performed where pa[i] -- is greater  pa[i + 1] for all i  is greater = index.<para/>
''' Then, the item is inserted at pa[index].<para/>
''' (3) If you are not using L_AUTO_DOWNSHIFT, the rule of thumb is<para/>
''' to use L_FULL_DOWNSHIFT if the array is compacted (each<para/>
''' element points to an item), and to use L_MIN_DOWNSHIFT<para/>
''' if there are a significant number of null pointers.<para/>
''' There is no penalty to using L_MIN_DOWNSHIFT for a<para/>
''' compacted array, however, because the full shift is required<para/>
''' and we don't do the O(n) computation to look for holes.<para/>
''' (4) This should not be used repeatedly on large arrays,<para/>
''' because the function is generally O(n).<para/>
''' (5) However, it can be used repeatedly if we start with an empty<para/>
''' ptr array and insert only once at each location.  For example,<para/>
''' you can support an array of Numa, where at each ptr location<para/>
''' you store either 0 or 1 Numa, and the Numa can be added<para/>
''' randomly to the ptr array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="index">[in] - location in ptra to insert new value</param>
'''  <param name="item">[in] - generic ptr to a struct can be null</param>
'''  <param name="shiftflag">[in] - L_AUTO_DOWNSHIFT, L_MIN_DOWNSHIFT, L_FULL_DOWNSHIFT</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraInsert(
				ByVal pa as L_Ptra, 
				ByVal index as Integer, 
				ByVal item as Object, 
				ByVal shiftflag as Enumerations.L_DOWNSHIFT) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")

Dim itemPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.ptraInsert( pa.Pointer, index, itemPTR, shiftflag)

	Return _Result
End Function

' SRC\ptra.c (434, 1)
' ptraRemove()
' ptraRemove(L_PTRA *, l_int32, l_int32) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If flag == L_NO_COMPACTION, this removes the item and<para/>
''' nulls the ptr on the array.  If it takes the last item<para/>
''' in the array, pa- is greater n is reduced to the next item.<para/>
''' (2) If flag == L_COMPACTION, this compacts the array for<para/>
''' for all i  is greater = index.  It should not be used repeatedly on<para/>
''' large arrays, because compaction is O(n).<para/>
''' (3) The ability to remove without automatic compaction allows<para/>
''' removal with cost O(1).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="index">[in] - element to be removed</param>
'''  <param name="flag">[in] - L_NO_COMPACTION, L_COMPACTION</param>
'''   <returns>item, or NULL on error</returns>
Public Shared Function ptraRemove(
				ByVal pa as L_Ptra, 
				ByVal index as Integer, 
				ByVal flag as Enumerations.L_COMPACTION) as Object

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraRemove( pa.Pointer, index, flag)

	Return _Result
End Function

' SRC\ptra.c (483, 1)
' ptraRemoveLast()
' ptraRemoveLast(L_PTRA *) as void *
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''   <returns>item, or NULL on error or if the array is empty</returns>
Public Shared Function ptraRemoveLast(
				ByVal pa as L_Ptra) as Object

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraRemoveLast( pa.Pointer)

	Return _Result
End Function

' SRC\ptra.c (512, 1)
' ptraReplace()
' ptraReplace(L_PTRA *, l_int32, void *, l_int32) as void *
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="index">[in] - element to be replaced</param>
'''  <param name="item">[in] - new generic ptr to a struct can be null</param>
'''  <param name="freeflag">[in] - TRUE to free old item FALSE to return it</param>
'''   <returns>item  old item, if it exists and is not freed, or NULL on error</returns>
Public Shared Function ptraReplace(
				ByVal pa as L_Ptra, 
				ByVal index as Integer, 
				ByVal item as Object, 
				ByVal freeflag as Integer) as Object

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")

Dim itemPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraReplace( pa.Pointer, index, itemPTR, freeflag)

	Return _Result
End Function

' SRC\ptra.c (553, 1)
' ptraSwap()
' ptraSwap(L_PTRA *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="index1">[in] - </param>
'''  <param name="index2">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraSwap(
				ByVal pa as L_Ptra, 
				ByVal index1 as Integer, 
				ByVal index2 as Integer) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraSwap( pa.Pointer, index1, index2)

	Return _Result
End Function

' SRC\ptra.c (590, 1)
' ptraCompactArray()
' ptraCompactArray(L_PTRA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This compacts the items on the array, filling any empty ptrs.<para/>
''' (2) This does not change the size of the array of ptrs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraCompactArray(
				ByVal pa as L_Ptra) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraCompactArray( pa.Pointer)

	Return _Result
End Function

' SRC\ptra.c (625, 1)
' ptraReverse()
' ptraReverse(L_PTRA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraReverse(
				ByVal pa as L_Ptra) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraReverse( pa.Pointer)

	Return _Result
End Function

' SRC\ptra.c (649, 1)
' ptraJoin()
' ptraJoin(L_PTRA *, L_PTRA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pa1">[in] - add to this one</param>
'''  <param name="pa2">[in] - appended to pa1, and emptied of items can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraJoin(
				ByVal pa1 as L_Ptra, 
				ByVal pa2 as L_Ptra) as Integer

	If IsNothing (pa1) then Throw New ArgumentNullException  ("pa1 cannot be Nothing")
	If IsNothing (pa2) then Throw New ArgumentNullException  ("pa2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraJoin( pa1.Pointer, pa2.Pointer)

	Return _Result
End Function

' SRC\ptra.c (699, 1)
' ptraGetMaxIndex()
' ptraGetMaxIndex(L_PTRA *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The largest index to an item in the array is %maxindex.<para/>
''' %maxindex is one less than the number of items that would be<para/>
''' in the array if there were no null pointers between 0<para/>
''' and %maxindex - 1.  However, because the internal ptr array<para/>
''' need not be compacted, there may be NULL pointers at<para/>
''' indices below %maxindex for example, if items have<para/>
''' been removed.<para/>
''' (2) When an item is added to the end of the array, it goes<para/>
''' into pa- is greater array[maxindex + 1], and maxindex is then<para/>
''' incremented by 1.<para/>
''' (3) If there are no items in the array, this returns %maxindex = -1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="pmaxindex">[out] - index of last item in the array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptraGetMaxIndex(
				ByVal pa as L_Ptra, 
				ByRef pmaxindex as Integer) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraGetMaxIndex( pa.Pointer, pmaxindex)

	Return _Result
End Function

' SRC\ptra.c (727, 1)
' ptraGetActualCount()
' ptraGetActualCount(L_PTRA *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The actual number of items on the ptr array, pa- is greater nactual,<para/>
''' will be smaller than pa- is greater n if the array is not compacted.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="pcount">[out] - actual number of items on the ptr array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptraGetActualCount(
				ByVal pa as L_Ptra, 
				ByRef pcount as Integer) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraGetActualCount( pa.Pointer, pcount)

	Return _Result
End Function

' SRC\ptra.c (759, 1)
' ptraGetPtrToItem()
' ptraGetPtrToItem(L_PTRA *, l_int32) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a ptr to the item.  You must cast it to<para/>
''' the type of item.  Do not destroy it the item belongs<para/>
''' to the Ptra.<para/>
''' (2) This can access all possible items on the ptr array.<para/>
''' If an item doesn't exist, it returns null.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - ptra</param>
'''  <param name="index">[in] - of element to be retrieved</param>
'''   <returns>a ptr to the element, or NULL on error</returns>
Public Shared Function ptraGetPtrToItem(
				ByVal pa as L_Ptra, 
				ByVal index as Integer) as Object

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraGetPtrToItem( pa.Pointer, index)

	Return _Result
End Function

' SRC\ptra.c (790, 1)
' ptraaCreate()
' ptraaCreate(l_int32) as L_PTRAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The ptraa is generated with a fixed size, that can not change.<para/>
''' The ptra can be generated and inserted randomly into this array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of ptr array to be alloc'd</param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function ptraaCreate(
				ByVal n as Integer) as L_Ptraa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Ptraa(_Result)
End Function

' SRC\ptra.c (826, 1)
' ptraaDestroy()
' ptraaDestroy(L_PTRAA **, l_int32, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See ptraDestroy() for use of %freeflag and %warnflag.<para/>
''' (2) To destroy the ptraa, we destroy each ptra, then the ptr array,<para/>
''' then the ptraa, and then null the contents of the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppaa">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining item in each ptra</param>
'''  <param name="warnflag">[in] - TRUE to warn if any remaining items are not destroyed</param>
Public Shared Sub ptraaDestroy(
				ByRef ppaa as L_Ptraa, 
				ByVal freeflag as Integer, 
				ByVal warnflag as Integer)


	Dim ppaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppaa) Then ppaaPTR = ppaa.Pointer

	LeptonicaSharp.Natives.ptraaDestroy( ppaaPTR, freeflag, warnflag)
	if ppaaPTR <> IntPtr.Zero then ppaa = new L_Ptraa(ppaaPTR)

End Sub

' SRC\ptra.c (867, 1)
' ptraaGetSize()
' ptraaGetSize(L_PTRAA *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="psize">[out] - size of ptr array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptraaGetSize(
				ByVal paa as L_Ptraa, 
				ByRef psize as Integer) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraaGetSize( paa.Pointer, psize)

	Return _Result
End Function

' SRC\ptra.c (898, 1)
' ptraaInsertPtra()
' ptraaInsertPtra(L_PTRAA *, l_int32, L_PTRA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caller should check return value.  On success, the Ptra<para/>
''' is inserted in the Ptraa and is owned by it.  However,<para/>
''' on error, the Ptra remains owned by the caller.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - ptraa</param>
'''  <param name="index">[in] - location in array for insertion</param>
'''  <param name="pa">[in] - to be inserted</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptraaInsertPtra(
				ByVal paa as L_Ptraa, 
				ByVal index as Integer, 
				ByVal pa as L_Ptra) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraaInsertPtra( paa.Pointer, index, pa.Pointer)

	Return _Result
End Function

' SRC\ptra.c (941, 1)
' ptraaGetPtra()
' ptraaGetPtra(L_PTRAA *, l_int32, l_int32) as L_PTRA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns the ptra ptr.  If %accessflag == L_HANDLE_ONLY,<para/>
''' the ptra is left on the ptraa.  If %accessflag == L_REMOVE,<para/>
''' the ptr in the ptraa is set to NULL, and the caller<para/>
''' is responsible for disposing of the ptra (either putting it<para/>
''' back on the ptraa, or destroying it).<para/>
''' (2) This returns NULL if there is no Ptra at the index location.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - ptraa</param>
'''  <param name="index">[in] - location in array</param>
'''  <param name="accessflag">[in] - L_HANDLE_ONLY, L_REMOVE</param>
'''   <returns>ptra at index location, or NULL on error or if there is no ptra there.</returns>
Public Shared Function ptraaGetPtra(
				ByVal paa as L_Ptraa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_accessor__l_ptraa) as L_Ptra

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraaGetPtra( paa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Ptra(_Result)
End Function

' SRC\ptra.c (983, 1)
' ptraaFlattenToPtra()
' ptraaFlattenToPtra(L_PTRAA *) as L_PTRA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This 'flattens' the ptraa to a ptra, taking the items in<para/>
''' each ptra, in order, starting with the first ptra, etc.<para/>
''' (2) As a side-effect, the ptra are all removed from the ptraa<para/>
''' and destroyed, leaving an empty ptraa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - ptraa</param>
'''   <returns>ptra, or NULL on error</returns>
Public Shared Function ptraaFlattenToPtra(
				ByVal paa as L_Ptraa) as L_Ptra

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptraaFlattenToPtra( paa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Ptra(_Result)
End Function

End Class
