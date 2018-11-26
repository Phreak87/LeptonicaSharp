Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\heap.c (102, 1)
' lheapCreate(nalloc, direction) as L_Heap
' lheapCreate(l_int32, l_int32) as L_HEAP *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapCreate/*"/>
'''  <param name="nalloc">[in] - size of ptr array to be alloc'd 0 for default</param>
'''  <param name="direction">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''   <returns>lheap, or NULL on error</returns>
Public Shared Function lheapCreate(
				 ByVal nalloc as Integer, 
				 ByVal direction as Enumerations.L_SORT_CREASING) as L_Heap

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lheapCreate( nalloc, direction)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Heap(_Result)
End Function

' SRC\heap.c (145, 1)
' lheapDestroy(plh, freeflag) as Object
' lheapDestroy(L_HEAP **, l_int32) as void
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Use freeflag == TRUE when the items in the array can be
''' simply destroyed using free.  If those items require their
''' own destroy function, they must be destroyed before
''' calling this function, and then this function is called
''' with freeflag == FALSE.<para/>
''' 
''' (2) To destroy the lheap, we destroy the ptr array, then
''' the lheap, and then null the contents of the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapDestroy/*"/>
'''  <param name="plh">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
Public Shared Sub lheapDestroy(
				 ByRef plh as L_Heap, 
				 ByVal freeflag as Integer)

	Dim plhPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plh) Then plhPTR = plh.Pointer

	LeptonicaSharp.Natives.lheapDestroy( plhPTR, freeflag)

If plhPTR = IntPtr.Zero Then plh = Nothing
If plhPTR <> IntPtr.Zero Then plh = New L_Heap(plhPTR)

End Sub

' SRC\heap.c (186, 1)
' lheapAdd(lh, item) as Integer
' lheapAdd(L_HEAP *, void *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapAdd/*"/>
'''  <param name="lh">[in] - heap</param>
'''  <param name="item">[in] - to be added to the tail of the heap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lheapAdd(
				 ByVal lh as L_Heap, 
				 ByVal item as Object) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")

	Dim itemPtr As IntPtr = IntPtr.Zero
	If TypeOf (item) Is IntPtr Then itemPtr = item
	If TypeOf (item) Is Byte() Then
		Dim cdata = CType(item, Byte())
		itemPtr = Marshal.AllocHGlobal(cdata.Length - 1)
		Marshal.Copy(cdata, 0, itemPtr, cdata.Length)
	End If
	If Not IsNothing(item.GetType.GetProperty("data")) Then
		Dim cdata = CType(item.data, Byte())
		itemPtr = Marshal.AllocHGlobal(cdata.Length - 1)
		Marshal.Copy(cdata, 0, itemPtr, cdata.Length)
	End If

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapAdd( lh.Pointer, itemPTR)
Marshal.FreeHGlobal(itemPTR)


	Return _Result
End Function

' SRC\heap.c (242, 1)
' lheapRemove(lh) as Object
' lheapRemove(L_HEAP *) as void *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapRemove/*"/>
'''  <param name="lh">[in] - heap</param>
'''   <returns>ptr to item popped from the root of the heap, or NULL if the heap is empty or on error</returns>
Public Shared Function lheapRemove(
				 ByVal lh as L_Heap) as Object

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lheapRemove( lh.Pointer)

	Dim B(1) As Byte : Marshal.Copy(_Result, B, 0, B.Length)

	Return B
End Function

' SRC\heap.c (271, 1)
' lheapGetCount(lh) as Integer
' lheapGetCount(L_HEAP *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapGetCount/*"/>
'''  <param name="lh">[in] - heap</param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function lheapGetCount(
				 ByVal lh as L_Heap) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapGetCount( lh.Pointer)


	Return _Result
End Function

' SRC\heap.c (304, 1)
' lheapSwapUp(lh, index) as Integer
' lheapSwapUp(L_HEAP *, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is called after a new item is put on the heap, at the
''' bottom of a complete tree.<para/>
''' 
''' (2) To regain the heap order, we let it bubble up,
''' iteratively swapping with its parent, until it either
''' reaches the root of the heap or it finds a parent that
''' is in the correct position already vis-a-vis the child.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSwapUp/*"/>
'''  <param name="lh">[in] - heap</param>
'''  <param name="index">[in] - of array corresponding to node to be swapped up</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lheapSwapUp(
				 ByVal lh as L_Heap, 
				 ByVal index as Integer) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapSwapUp( lh.Pointer, index)


	Return _Result
End Function

' SRC\heap.c (370, 1)
' lheapSwapDown(lh) as Integer
' lheapSwapDown(L_HEAP *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is called after an item has been popped off the
''' root of the heap, and the last item in the heap has
''' been placed at the root.<para/>
''' 
''' (2) To regain the heap order, we let it bubble down,
''' iteratively swapping with one of its children.  For a
''' decreasing sort, it swaps with the largest child for
''' an increasing sort, the smallest.  This continues until
''' it either reaches the lowest level in the heap, or the
''' parent finds that neither child should swap with it
''' (e.g., for a decreasing heap, the parent is larger
''' than or equal to both children).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSwapDown/*"/>
'''  <param name="lh">[in] - heap</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lheapSwapDown(
				 ByVal lh as L_Heap) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapSwapDown( lh.Pointer)


	Return _Result
End Function

' SRC\heap.c (453, 1)
' lheapSort(lh) as Integer
' lheapSort(L_HEAP *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This sorts an array into heap order.  If the heap is already
''' in heap order for the direction given, this has no effect.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSort/*"/>
'''  <param name="lh">[in] - heap, with internal array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lheapSort(
				 ByVal lh as L_Heap) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapSort( lh.Pointer)


	Return _Result
End Function

' SRC\heap.c (487, 1)
' lheapSortStrictOrder(lh) as Integer
' lheapSortStrictOrder(L_HEAP *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This sorts a heap into strict order.<para/>
''' 
''' (2) For each element, starting at the end of the array and
''' working forward, the element is swapped with the head
''' element and then allowed to swap down onto a heap of
''' size reduced by one.  The result is that the heap is
''' reversed but in strict order.  The array elements are
''' then reversed to put it in the original order.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapSortStrictOrder/*"/>
'''  <param name="lh">[in] - heap, with internal array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lheapSortStrictOrder(
				 ByVal lh as L_Heap) as Integer

	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapSortStrictOrder( lh.Pointer)


	Return _Result
End Function

' SRC\heap.c (524, 1)
' lheapPrint(fp, lh) as Integer
' lheapPrint(FILE *, L_HEAP *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lheapPrint/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="lh">[in] - heap</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function lheapPrint(
				 ByVal fp as FILE, 
				 ByVal lh as L_Heap) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (lh) then Throw New ArgumentNullException  ("lh cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lheapPrint( fp.Pointer, lh.Pointer)


	Return _Result
End Function

End Class
