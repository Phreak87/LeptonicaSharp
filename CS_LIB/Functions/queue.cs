using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// queue.c (90, 1)
// lqueueCreate(nalloc) as L_Queue
// lqueueCreate(l_int32) as L_QUEUE *
///  <summary>
/// (1) Allocates a ptr array of given size, and initializes counters.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueCreate/*"/>
///  <param name="nalloc">[in] - size of ptr array to be alloc'd 0 for default</param>
///   <returns>lqueue, or NULL on error</returns>
public static L_Queue lqueueCreate(
				 int nalloc){

	IntPtr _Result = Natives.lqueueCreate(  nalloc);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Queue(_Result);
}

// queue.c (131, 1)
// lqueueDestroy(plq, freeflag) as Object
// lqueueDestroy(L_QUEUE **, l_int32) as void
///  <summary>
/// (1) If freeflag is TRUE, frees each struct in the array.<para/>
/// 
/// (2) If freeflag is FALSE but there are elements on the array,
/// gives a warning and destroys the array.  This will
/// cause a memory leak of all the items that were on the queue.
/// So if the items require their own destroy function, they
/// must be destroyed before the queue.  The same applies to the
/// auxiliary stack, if it is used.<para/>
/// 
/// (3) To destroy the L_Queue, we destroy the ptr array, then
/// the lqueue, and then null the contents of the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueDestroy/*"/>
///  <param name="plq">[in,out] - to be nulled</param>
///  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
public static void lqueueDestroy(
				ref L_Queue plq, 
				 int freeflag){

	IntPtr plqPtr = IntPtr.Zero; 	if (plq != null) {plqPtr = plq.Pointer;}

	Natives.lqueueDestroy(ref plqPtr,   freeflag);
	
	if (plqPtr == IntPtr.Zero) {plq = null;} else { plq = new L_Queue(plqPtr); };
}

// queue.c (187, 1)
// lqueueAdd(lq, item) as int
// lqueueAdd(L_QUEUE *, void *) as l_ok
///  <summary>
/// (1) The algorithm is as follows.  If the queue is populated
/// to the end of the allocated array, shift all ptrs toward
/// the beginning of the array, so that the head of the queue
/// is at the beginning of the array.  Then, if the array is
/// more than 0.75 full, realloc with double the array size.
/// Finally, add the item to the tail of the queue.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueAdd/*"/>
///  <param name="lq">[in] - lqueue</param>
///  <param name="item">[in] - to be added to the tail of the queue</param>
///   <returns>0 if OK, 1 on error</returns>
public static int lqueueAdd(
				 L_Queue lq, 
				 Object item){

if (lq == null) {throw new ArgumentNullException  ("lq cannot be Nothing");}
		if (item == null) {throw new ArgumentNullException  ("item cannot be Nothing");}
	IntPtr itemPtr = IntPtr.Zero;
	if (item.GetType() == typeof(IntPtr))
	{
	  itemPtr = (IntPtr)item;
	}
	else if (item.GetType() == typeof(Byte[]))
	{ 
	  var cdata = (Byte[])item;
	  itemPtr = Marshal.AllocHGlobal(cdata.Length);
	   Marshal.Copy(cdata, 0, itemPtr, cdata.Length);
	}
	else if (item.GetType().GetProperty("item") != null)
	{
	   var cdata = (Byte[])item.GetType().GetProperty("data").GetValue(item, null);
	   itemPtr = Marshal.AllocHGlobal(cdata.Length);
	   Marshal.Copy(cdata, 0, itemPtr, cdata.Length);
	}

	int _Result = Natives.lqueueAdd(lq.Pointer,   itemPtr);
	
	Marshal.FreeHGlobal(itemPtr);
	return _Result;
}

// queue.c (254, 1)
// lqueueRemove(lq) as Object
// lqueueRemove(L_QUEUE *) as void *
///  <summary>
/// (1) If this is the last item on the queue, so that the queue
/// becomes empty, nhead is reset to the beginning of the array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueRemove/*"/>
///  <param name="lq">[in] - lqueue</param>
///   <returns>ptr to item popped from the head of the queue, or NULL if the queue is empty or on error</returns>
public static Object lqueueRemove(
				 L_Queue lq){

if (lq == null) {throw new ArgumentNullException  ("lq cannot be Nothing");}
	IntPtr _Result = Natives.lqueueRemove(lq.Pointer);
	
	Byte[] B = new Byte[1];
	Marshal.Copy(_Result, B, 0, B.Length);
	return B;
}

// queue.c (283, 1)
// lqueueGetCount(lq) as int
// lqueueGetCount(L_QUEUE *) as l_int32
///  <summary>
/// lqueueGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueueGetCount/*"/>
///  <param name="lq">[in] - lqueue</param>
///   <returns>count, or 0 on error</returns>
public static int lqueueGetCount(
				 L_Queue lq){

if (lq == null) {throw new ArgumentNullException  ("lq cannot be Nothing");}
	int _Result = Natives.lqueueGetCount(lq.Pointer);
	
	return _Result;
}

// queue.c (305, 1)
// lqueuePrint(fp, lq) as int
// lqueuePrint(FILE *, L_QUEUE *) as l_ok
///  <summary>
/// lqueuePrint()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lqueuePrint/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="lq">[in] - lqueue</param>
///   <returns>0 if OK 1 on error</returns>
public static int lqueuePrint(
				 FILE fp, 
				 L_Queue lq){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (lq == null) {throw new ArgumentNullException  ("lq cannot be Nothing");}
	int _Result = Natives.lqueuePrint(fp.Pointer, lq.Pointer);
	
	return _Result;
}


}
}
