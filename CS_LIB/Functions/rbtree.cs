using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// rbtree.c (132, 1)
		// l_rbtreeCreate(keytype) as L_Rbtree
		// l_rbtreeCreate(l_int32) as L_RBTREE *
		///  <summary>
		/// l_rbtreeCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeCreate/*"/>
		///  <param name="keytype">[in] - defined by an enum for an RB_TYPE union</param>
		///   <returns>rbtree    container with empty ptr to the root</returns>
		public static L_Rbtree l_rbtreeCreate(
						int keytype)
		{
			IntPtr _Result = Natives.l_rbtreeCreate(  keytype);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree(_Result);
		}

		// rbtree.c (154, 1)
		// l_rbtreeLookup(t, key) as Rb_Type
		// l_rbtreeLookup(L_RBTREE *, RB_TYPE) as RB_TYPE *
		///  <summary>
		/// l_rbtreeLookup()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeLookup/*"/>
		///  <param name="t">[in] - rbtree, including root node</param>
		///  <param name="key">[in] - find a node with this key</param>
		///   <returns>[and]value     a pointer to a union, if the node exists else NULL</returns>
		public static Rb_Type l_rbtreeLookup(
						L_Rbtree t,
						Rb_Type key)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			if (key == null) {throw new ArgumentNullException  ("key cannot be Nothing");}

			IntPtr _Result = Natives.l_rbtreeLookup(t.Pointer, key.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Rb_Type(_Result);
		}

		// rbtree.c (181, 1)
		// l_rbtreeInsert(t, key, value) as Object
		// l_rbtreeInsert(L_RBTREE *, RB_TYPE, RB_TYPE) as void
		///  <summary>
		/// (1) If a node with the key already exists, this just updates the value.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeInsert/*"/>
		///  <param name="t">[in] - rbtree, including root node</param>
		///  <param name="key">[in] - insert a node with this key, if the key does not already exist in the tree</param>
		///  <param name="value">[in] - typically an int, used for an index</param>
		public static void l_rbtreeInsert(
						L_Rbtree t,
						Rb_Type key,
						Rb_Type value)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			if (key == null) {throw new ArgumentNullException  ("key cannot be Nothing");}

			if (value == null) {throw new ArgumentNullException  ("value cannot be Nothing");}

			Natives.l_rbtreeInsert(t.Pointer, key.Pointer, value.Pointer);
		}

		// rbtree.c (235, 1)
		// l_rbtreeDelete(t, key) as Object
		// l_rbtreeDelete(L_RBTREE *, RB_TYPE) as void
		///  <summary>
		/// l_rbtreeDelete()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeDelete/*"/>
		///  <param name="t">[in] - rbtree, including root node</param>
		///  <param name="key">[in] - (delete the node with this key</param>
		public static void l_rbtreeDelete(
						L_Rbtree t,
						Rb_Type key)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			if (key == null) {throw new ArgumentNullException  ("key cannot be Nothing");}

			Natives.l_rbtreeDelete(t.Pointer, key.Pointer);
		}

		// rbtree.c (283, 1)
		// l_rbtreeDestroy(pt) as Object
		// l_rbtreeDestroy(L_RBTREE **) as void
		///  <summary>
		/// (1) Destroys the tree and nulls the input tree ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeDestroy/*"/>
		///  <param name="pt">[in] - ptr to rbtree</param>
		public static void l_rbtreeDestroy(
						List<L_Rbtree> pt)
		{
			if (pt == null) {throw new ArgumentNullException  ("pt cannot be Nothing");}

			IntPtr ptPtr = IntPtr.Zero;
			Natives.l_rbtreeDestroy(ptPtr);
		}

		// rbtree.c (318, 1)
		// l_rbtreeGetFirst(t) as L_Rbtree_Node
		// l_rbtreeGetFirst(L_RBTREE *) as L_RBTREE_NODE *
		///  <summary>
		/// (1) This is the first node in an in-order traversal.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetFirst/*"/>
		///  <param name="t">[in] - rbtree, including root node</param>
		///   <returns>void</returns>
		public static L_Rbtree_Node l_rbtreeGetFirst(
						L_Rbtree t)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			IntPtr _Result = Natives.l_rbtreeGetFirst(t.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree_Node(_Result);
		}

		// rbtree.c (353, 1)
		// l_rbtreeGetNext(n) as L_Rbtree_Node
		// l_rbtreeGetNext(L_RBTREE_NODE *) as L_RBTREE_NODE *
		///  <summary>
		/// (1) This finds the next node, in an in-order traversal, from
		/// the current node.<para/>
		///
		/// (2) It is useful as an iterator for a map.<para/>
		///
		/// (3) Call l_rbtreeGetFirst() to get the first node.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetNext/*"/>
		///  <param name="n">[in] - current node</param>
		///   <returns>next node, or NULL if it's the last node</returns>
		public static L_Rbtree_Node l_rbtreeGetNext(
						L_Rbtree_Node n)
		{
			if (n == null) {throw new ArgumentNullException  ("n cannot be Nothing");}

			IntPtr _Result = Natives.l_rbtreeGetNext(n.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree_Node(_Result);
		}

		// rbtree.c (388, 1)
		// l_rbtreeGetLast(t) as L_Rbtree_Node
		// l_rbtreeGetLast(L_RBTREE *) as L_RBTREE_NODE *
		///  <summary>
		/// (1) This is the last node in an in-order traversal.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetLast/*"/>
		///  <param name="t">[in] - rbtree, including root node</param>
		///   <returns>void</returns>
		public static L_Rbtree_Node l_rbtreeGetLast(
						L_Rbtree t)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			IntPtr _Result = Natives.l_rbtreeGetLast(t.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree_Node(_Result);
		}

		// rbtree.c (423, 1)
		// l_rbtreeGetPrev(n) as L_Rbtree_Node
		// l_rbtreeGetPrev(L_RBTREE_NODE *) as L_RBTREE_NODE *
		///  <summary>
		/// (1) This finds the previous node, in an in-order traversal, from
		/// the current node.<para/>
		///
		/// (2) It is useful as an iterator for a map.<para/>
		///
		/// (3) Call l_rbtreeGetLast() to get the last node.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetPrev/*"/>
		///  <param name="n">[in] - current node</param>
		///   <returns>next node, or NULL if it's the first node</returns>
		public static L_Rbtree_Node l_rbtreeGetPrev(
						L_Rbtree_Node n)
		{
			if (n == null) {throw new ArgumentNullException  ("n cannot be Nothing");}

			IntPtr _Result = Natives.l_rbtreeGetPrev(n.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree_Node(_Result);
		}

		// rbtree.c (453, 1)
		// l_rbtreeGetCount(t) as int
		// l_rbtreeGetCount(L_RBTREE *) as l_int32
		///  <summary>
		/// l_rbtreeGetCount()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetCount/*"/>
		///  <param name="t">[in] - rbtree</param>
		///   <returns>count  the number of nodes in the tree, or 0 on error</returns>
		public static int l_rbtreeGetCount(
						L_Rbtree t)
		{
			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			int _Result = Natives.l_rbtreeGetCount(t.Pointer);
			return _Result;
		}

		// rbtree.c (486, 1)
		// l_rbtreePrint(fp, t) as Object
		// l_rbtreePrint(FILE *, L_RBTREE *) as void
		///  <summary>
		/// l_rbtreePrint()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreePrint/*"/>
		///  <param name="fp">[in] - file stream</param>
		///  <param name="t">[in] - rbtree</param>
		public static void l_rbtreePrint(
						FILE fp,
						L_Rbtree t)
		{
			if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}

			if (t == null) {throw new ArgumentNullException  ("t cannot be Nothing");}

			Natives.l_rbtreePrint(fp.Pointer, t.Pointer);
		}


	}
}
