Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\queue.c (90, 1)
' lqueueCreate(nalloc) as L_Queue
' lqueueCreate(l_int32) as L_QUEUE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Allocates a ptr array of given size, and initializes counters.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nalloc">[in] - size of ptr array to be alloc'd 0 for default</param>
'''   <returns>lqueue, or NULL on error</returns>
Public Shared Function lqueueCreate(
				 ByVal nalloc as Integer) as L_Queue

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lqueueCreate( nalloc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Queue(_Result)
End Function

' SRC\queue.c (131, 1)
' lqueueDestroy(plq, freeflag) as Object
' lqueueDestroy(L_QUEUE **, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If freeflag is TRUE, frees each struct in the array.<para/>
''' (2) If freeflag is FALSE but there are elements on the array,<para/>
''' gives a warning and destroys the array.  This will<para/>
''' cause a memory leak of all the items that were on the queue.<para/>
''' So if the items require their own destroy function, they<para/>
''' must be destroyed before the queue.  The same applies to the<para/>
''' auxiliary stack, if it is used.<para/>
''' (3) To destroy the L_Queue, we destroy the ptr array, then<para/>
''' the lqueue, and then null the contents of the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="plq">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
Public Shared Sub lqueueDestroy(
				 ByRef plq as L_Queue, 
				 ByVal freeflag as Integer)

	Dim plqPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plq) Then plqPTR = plq.Pointer

	LeptonicaSharp.Natives.lqueueDestroy( plqPTR, freeflag)
	if plqPTR <> IntPtr.Zero then plq = new L_Queue(plqPTR)

End Sub

' SRC\queue.c (187, 1)
' lqueueAdd(lq, item) as Integer
' lqueueAdd(L_QUEUE *, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The algorithm is as follows.  If the queue is populated<para/>
''' to the end of the allocated array, shift all ptrs toward<para/>
''' the beginning of the array, so that the head of the queue<para/>
''' is at the beginning of the array.  Then, if the array is<para/>
''' more than 0.75 full, realloc with double the array size.<para/>
''' Finally, add the item to the tail of the queue.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="lq">[in] - lqueue</param>
'''  <param name="item">[in] - to be added to the tail of the queue</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lqueueAdd(
				 ByVal lq as L_Queue, 
				 ByVal item as Object) as Integer

	If IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")

Dim itemPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.lqueueAdd( lq.Pointer, itemPTR)

	Return _Result
End Function

' SRC\queue.c (254, 1)
' lqueueRemove(lq) as Object
' lqueueRemove(L_QUEUE *) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If this is the last item on the queue, so that the queue<para/>
''' becomes empty, nhead is reset to the beginning of the array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>ptr to item popped from the head of the queue, or NULL if the queue is empty or on error</returns>
Public Shared Function lqueueRemove(
				 ByVal lq as L_Queue) as Object

	If IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lqueueRemove( lq.Pointer)

	Return _Result
End Function

' SRC\queue.c (283, 1)
' lqueueGetCount(lq) as Integer
' lqueueGetCount(L_QUEUE *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function lqueueGetCount(
				 ByVal lq as L_Queue) as Integer

	If IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lqueueGetCount( lq.Pointer)

	Return _Result
End Function

' SRC\queue.c (305, 1)
' lqueuePrint(fp, lq) as Integer
' lqueuePrint(FILE *, L_QUEUE *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="lq">[in] - lqueue</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function lqueuePrint(
				 ByVal fp as FILE, 
				 ByVal lq as L_Queue) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (lq) then Throw New ArgumentNullException  ("lq cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lqueuePrint( fp.Pointer, lq.Pointer)

	Return _Result
End Function

End Class
