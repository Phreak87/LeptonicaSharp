Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' queue.c (90, 1)
' lqueueCreate(nalloc) as L_Queue
' lqueueCreate(l_int32) as L_QUEUE *
'''  <summary>
''' (1) Allocates a ptr array of given size, and initializes counters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueCreate/*"/>
'''  <param name="nalloc">[in] - size of ptr array to be alloc'd 0 for default</param>
'''   <returns>lqueue, or NULL on error</returns>
Public Shared Function lqueueCreate(
				ByVal nalloc as Integer) as L_Queue


	Dim _Result as IntPtr = Natives.lqueueCreate(  nalloc)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Queue(_Result)
End Function

' queue.c (131, 1)
' lqueueDestroy(plq, freeflag) as Object
' lqueueDestroy(L_QUEUE **, l_int32) as void
'''  <summary>
''' (1) If freeflag is TRUE, frees each struct in the array.<para/>
'''
'''(2) If freeflag is FALSE but there are elements on the array,
'''gives a warning and destroys the array.  This will
'''cause a memory leak of all the items that were on the queue.
'''So if the items require their own destroy function, they
'''must be destroyed before the queue.  The same applies to the
'''auxiliary stack, if it is used.<para/>
'''
'''(3) To destroy the L_Queue, we destroy the ptr array, then
'''the lqueue, and then null the contents of the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueDestroy/*"/>
'''  <param name="plq">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
Public Shared Sub lqueueDestroy(
				ByRef plq as L_Queue, 
				ByVal freeflag as Integer)


	Dim plqPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(plq) Then plqPtr = plq.Pointer

	Natives.lqueueDestroy( plqPtr,   freeflag)
	
	if plqPtr = IntPtr.Zero then plq = Nothing else plq = new L_Queue(plqPtr)
End Sub

' queue.c (187, 1)
' lqueueAdd(lq, item) as Integer
' lqueueAdd(L_QUEUE *, void *) as l_ok
'''  <summary>
''' (1) The algorithm is as follows.  If the queue is populated
'''to the end of the allocated array, shift all ptrs toward
'''the beginning of the array, so that the head of the queue
'''is at the beginning of the array.  Then, if the array is
'''more than 0.75 full, realloc with double the array size.
'''Finally, add the item to the tail of the queue.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueAdd/*"/>
'''  <param name="lq">[in] - lqueue</param>
'''  <param name="item">[in] - to be added to the tail of the queue</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lqueueAdd(
				ByVal lq as L_Queue, 
				ByVal item as Object) as Integer


if IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")
		if IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")
		Dim itemPtr as IntPtr = 	Marshal.AllocHGlobal(0)
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

	Dim _Result as Integer = Natives.lqueueAdd(lq.Pointer,   itemPtr)
	
	Marshal.FreeHGlobal(itemPtr)
	return _Result
End Function

' queue.c (254, 1)
' lqueueRemove(lq) as Object
' lqueueRemove(L_QUEUE *) as void *
'''  <summary>
''' (1) If this is the last item on the queue, so that the queue
'''becomes empty, nhead is reset to the beginning of the array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueRemove/*"/>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>ptr to item popped from the head of the queue, or NULL if the queue is empty or on error</returns>
Public Shared Function lqueueRemove(
				ByVal lq as L_Queue) as Object


if IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")
	Dim _Result as IntPtr = Natives.lqueueRemove(lq.Pointer)
	
	Dim B(1) As Byte
	Marshal.Copy(_Result, B, 0, B.Length)
	return B
End Function

' queue.c (283, 1)
' lqueueGetCount(lq) as Integer
' lqueueGetCount(L_QUEUE *) as l_int32
'''  <summary>
''' lqueueGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueGetCount/*"/>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function lqueueGetCount(
				ByVal lq as L_Queue) as Integer


if IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")
	Dim _Result as Integer = Natives.lqueueGetCount(lq.Pointer)
	
	return _Result
End Function

' queue.c (305, 1)
' lqueuePrint(fp, lq) as Integer
' lqueuePrint(FILE *, L_QUEUE *) as l_ok
'''  <summary>
''' lqueuePrint()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueuePrint/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function lqueuePrint(
				ByVal fp as FILE, 
				ByVal lq as L_Queue) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")
	Dim _Result as Integer = Natives.lqueuePrint(fp.Pointer, lq.Pointer)
	
	return _Result
End Function

End Class


