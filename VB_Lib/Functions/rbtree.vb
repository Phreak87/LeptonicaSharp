Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' rbtree.c (132, 1)
' l_rbtreeCreate(keytype) as L_Rbtree
' l_rbtreeCreate(l_int32) as L_RBTREE *
'''  <summary>
''' l_rbtreeCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeCreate/*"/>
'''  <param name="keytype">[in] - defined by an enum for an RB_TYPE union</param>
'''   <returns>rbtree    container with empty ptr to the root</returns>
Public Shared Function l_rbtreeCreate(
				ByVal keytype as Integer) as L_Rbtree


	Dim _Result as IntPtr = Natives.l_rbtreeCreate(  keytype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree(_Result)
End Function

' rbtree.c (154, 1)
' l_rbtreeLookup(t, key) as Rb_Type
' l_rbtreeLookup(L_RBTREE *, RB_TYPE) as RB_TYPE *
'''  <summary>
''' l_rbtreeLookup()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeLookup/*"/>
'''  <param name="t">[in] - rbtree, including root node</param>
'''  <param name="key">[in] - find a node with this key</param>
'''   <returns>[and]value     a pointer to a union, if the node exists else NULL</returns>
Public Shared Function l_rbtreeLookup(
				ByVal t as L_Rbtree, 
				ByVal key as Rb_Type) as Rb_Type


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
		if IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_rbtreeLookup(t.Pointer, key.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Rb_Type(_Result)
End Function

' rbtree.c (181, 1)
' l_rbtreeInsert(t, key, value) as Object
' l_rbtreeInsert(L_RBTREE *, RB_TYPE, RB_TYPE) as void
'''  <summary>
''' (1) If a node with the key already exists, this just updates the value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeInsert/*"/>
'''  <param name="t">[in] - rbtree, including root node</param>
'''  <param name="key">[in] - insert a node with this key, if the key does not already exist in the tree</param>
'''  <param name="value">[in] - typically an int, used for an index</param>
Public Shared Sub l_rbtreeInsert(
				ByVal t as L_Rbtree, 
				ByVal key as Rb_Type, 
				ByVal value as Rb_Type)


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
		if IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
		if IsNothing (value) then Throw New ArgumentNullException  ("value cannot be Nothing")
	Natives.l_rbtreeInsert(t.Pointer, key.Pointer, value.Pointer)
	
End Sub

' rbtree.c (235, 1)
' l_rbtreeDelete(t, key) as Object
' l_rbtreeDelete(L_RBTREE *, RB_TYPE) as void
'''  <summary>
''' l_rbtreeDelete()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeDelete/*"/>
'''  <param name="t">[in] - rbtree, including root node</param>
'''  <param name="key">[in] - (delete the node with this key</param>
Public Shared Sub l_rbtreeDelete(
				ByVal t as L_Rbtree, 
				ByVal key as Rb_Type)


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
		if IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
	Natives.l_rbtreeDelete(t.Pointer, key.Pointer)
	
End Sub

' rbtree.c (283, 1)
' l_rbtreeDestroy(pt) as Object
' l_rbtreeDestroy(L_RBTREE **) as void
'''  <summary>
''' (1) Destroys the tree and nulls the input tree ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeDestroy/*"/>
'''  <param name="pt">[in] - ptr to rbtree</param>
Public Shared Sub l_rbtreeDestroy(
				ByVal pt as List(of L_Rbtree))


if IsNothing (pt) then Throw New ArgumentNullException  ("pt cannot be Nothing")
	Dim ptPtr as IntPtr = IntPtr.Zero

	Natives.l_rbtreeDestroy(ptPtr)
	
End Sub

' rbtree.c (318, 1)
' l_rbtreeGetFirst(t) as L_Rbtree_Node
' l_rbtreeGetFirst(L_RBTREE *) as L_RBTREE_NODE *
'''  <summary>
''' (1) This is the first node in an in-order traversal.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetFirst/*"/>
'''  <param name="t">[in] - rbtree, including root node</param>
'''   <returns>void</returns>
Public Shared Function l_rbtreeGetFirst(
				ByVal t as L_Rbtree) as L_Rbtree_Node


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_rbtreeGetFirst(t.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree_Node(_Result)
End Function

' rbtree.c (353, 1)
' l_rbtreeGetNext(n) as L_Rbtree_Node
' l_rbtreeGetNext(L_RBTREE_NODE *) as L_RBTREE_NODE *
'''  <summary>
''' (1) This finds the next node, in an in-order traversal, from
'''the current node.<para/>
'''
'''(2) It is useful as an iterator for a map.<para/>
'''
'''(3) Call l_rbtreeGetFirst() to get the first node.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetNext/*"/>
'''  <param name="n">[in] - current node</param>
'''   <returns>next node, or NULL if it's the last node</returns>
Public Shared Function l_rbtreeGetNext(
				ByVal n as L_Rbtree_Node) as L_Rbtree_Node


if IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_rbtreeGetNext(n.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree_Node(_Result)
End Function

' rbtree.c (388, 1)
' l_rbtreeGetLast(t) as L_Rbtree_Node
' l_rbtreeGetLast(L_RBTREE *) as L_RBTREE_NODE *
'''  <summary>
''' (1) This is the last node in an in-order traversal.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetLast/*"/>
'''  <param name="t">[in] - rbtree, including root node</param>
'''   <returns>void</returns>
Public Shared Function l_rbtreeGetLast(
				ByVal t as L_Rbtree) as L_Rbtree_Node


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_rbtreeGetLast(t.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree_Node(_Result)
End Function

' rbtree.c (423, 1)
' l_rbtreeGetPrev(n) as L_Rbtree_Node
' l_rbtreeGetPrev(L_RBTREE_NODE *) as L_RBTREE_NODE *
'''  <summary>
''' (1) This finds the previous node, in an in-order traversal, from
'''the current node.<para/>
'''
'''(2) It is useful as an iterator for a map.<para/>
'''
'''(3) Call l_rbtreeGetLast() to get the last node.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetPrev/*"/>
'''  <param name="n">[in] - current node</param>
'''   <returns>next node, or NULL if it's the first node</returns>
Public Shared Function l_rbtreeGetPrev(
				ByVal n as L_Rbtree_Node) as L_Rbtree_Node


if IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_rbtreeGetPrev(n.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree_Node(_Result)
End Function

' rbtree.c (453, 1)
' l_rbtreeGetCount(t) as Integer
' l_rbtreeGetCount(L_RBTREE *) as l_int32
'''  <summary>
''' l_rbtreeGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreeGetCount/*"/>
'''  <param name="t">[in] - rbtree</param>
'''   <returns>count  the number of nodes in the tree, or 0 on error</returns>
Public Shared Function l_rbtreeGetCount(
				ByVal t as L_Rbtree) as Integer


if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
	Dim _Result as Integer = Natives.l_rbtreeGetCount(t.Pointer)
	
	return _Result
End Function

' rbtree.c (486, 1)
' l_rbtreePrint(fp, t) as Object
' l_rbtreePrint(FILE *, L_RBTREE *) as void
'''  <summary>
''' l_rbtreePrint()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_rbtreePrint/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="t">[in] - rbtree</param>
Public Shared Sub l_rbtreePrint(
				ByVal fp as FILE, 
				ByVal t as L_Rbtree)


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (t) then Throw New ArgumentNullException  ("t cannot be Nothing")
	Natives.l_rbtreePrint(fp.Pointer, t.Pointer)
	
End Sub

End Class


