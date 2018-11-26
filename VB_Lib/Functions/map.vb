Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\map.c (107, 1)
' l_amapCreate(keytype) as L_Rbtree
' l_amapCreate(l_int32) as L_AMAP *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapCreate/*"/>
'''   <returns></returns>
Public Shared Function l_amapCreate(
				 ByVal keytype as Integer) as L_Rbtree

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapCreate( keytype)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\map.c (121, 1)
' l_amapFind(m, key) as RB_TYPE
' l_amapFind(L_AMAP *, RB_TYPE) as RB_TYPE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapFind/*"/>
'''   <returns></returns>
Public Shared Function l_amapFind(
				 ByVal m as L_Rbtree, 
				 ByVal key as Rb_Type) as RB_TYPE

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapFind( m.Pointer, key.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new RB_TYPE(_Result)
End Function

' SRC\map.c (128, 1)
' l_amapInsert(m, key, value) as Object
' l_amapInsert(L_AMAP *, RB_TYPE, RB_TYPE) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapInsert/*"/>
Public Shared Sub l_amapInsert(
				 ByVal m as L_Rbtree, 
				 ByVal key as Rb_Type, 
				 ByVal value as Rb_Type)

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
	If IsNothing (value) then Throw New ArgumentNullException  ("value cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer
Dim valuePTR As IntPtr = IntPtr.Zero : If Not IsNothing(value) Then valuePTR = value.Pointer

	LeptonicaSharp.Natives.l_amapInsert( m.Pointer, key.Pointer, value.Pointer)


End Sub

' SRC\map.c (136, 1)
' l_amapDelete(m, key) as Object
' l_amapDelete(L_AMAP *, RB_TYPE) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapDelete/*"/>
Public Shared Sub l_amapDelete(
				 ByVal m as L_Rbtree, 
				 ByVal key as Rb_Type)

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_amapDelete( m.Pointer, key.Pointer)


End Sub

' SRC\map.c (143, 1)
' l_amapDestroy(pm) as Object
' l_amapDestroy(L_AMAP **) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapDestroy/*"/>
Public Shared Sub l_amapDestroy(
				 ByVal pm as L_Rbtree)

	If IsNothing (pm) then Throw New ArgumentNullException  ("pm cannot be Nothing")

	Dim pmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pm) Then pmPTR = pm.Pointer

	LeptonicaSharp.Natives.l_amapDestroy( pmPTR)


End Sub

' SRC\map.c (149, 1)
' l_amapGetFirst(m) as L_Rbtree_Node
' l_amapGetFirst(L_AMAP *) as L_AMAP_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetFirst/*"/>
'''   <returns></returns>
Public Shared Function l_amapGetFirst(
				 ByVal m as L_Rbtree) as L_Rbtree_Node

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetFirst( m.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (155, 1)
' l_amapGetNext(n) as L_Rbtree_Node
' l_amapGetNext(L_AMAP_NODE *) as L_AMAP_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetNext/*"/>
'''   <returns></returns>
Public Shared Function l_amapGetNext(
				 ByVal n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetNext( n.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (161, 1)
' l_amapGetLast(m) as L_Rbtree_Node
' l_amapGetLast(L_AMAP *) as L_AMAP_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetLast/*"/>
'''   <returns></returns>
Public Shared Function l_amapGetLast(
				 ByVal m as L_Rbtree) as L_Rbtree_Node

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetLast( m.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (167, 1)
' l_amapGetPrev(n) as L_Rbtree_Node
' l_amapGetPrev(L_AMAP_NODE *) as L_AMAP_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetPrev/*"/>
'''   <returns></returns>
Public Shared Function l_amapGetPrev(
				 ByVal n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetPrev( n.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (173, 1)
' l_amapSize(m) as Integer
' l_amapSize(L_AMAP *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapSize/*"/>
'''   <returns></returns>
Public Shared Function l_amapSize(
				 ByVal m as L_Rbtree) as Integer

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_amapSize( m.Pointer)


	Return _Result
End Function

' SRC\map.c (183, 1)
' l_asetCreate(keytype) as L_Rbtree
' l_asetCreate(l_int32) as L_ASET *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetCreate/*"/>
'''   <returns></returns>
Public Shared Function l_asetCreate(
				 ByVal keytype as Integer) as L_Rbtree

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetCreate( keytype)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\map.c (203, 1)
' l_asetFind(s, key) as RB_TYPE
' l_asetFind(L_ASET *, RB_TYPE) as RB_TYPE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetFind/*"/>
'''   <returns></returns>
Public Shared Function l_asetFind(
				 ByVal s as L_Rbtree, 
				 ByVal key as Rb_Type) as RB_TYPE

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetFind( s.Pointer, key.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new RB_TYPE(_Result)
End Function

' SRC\map.c (210, 1)
' l_asetInsert(s, key) as Object
' l_asetInsert(L_ASET *, RB_TYPE) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetInsert/*"/>
Public Shared Sub l_asetInsert(
				 ByVal s as L_Rbtree, 
				 ByVal key as Rb_Type)

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_asetInsert( s.Pointer, key.Pointer)


End Sub

' SRC\map.c (220, 1)
' l_asetDelete(s, key) as Object
' l_asetDelete(L_ASET *, RB_TYPE) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetDelete/*"/>
Public Shared Sub l_asetDelete(
				 ByVal s as L_Rbtree, 
				 ByVal key as Rb_Type)

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_asetDelete( s.Pointer, key.Pointer)


End Sub

' SRC\map.c (227, 1)
' l_asetDestroy(ps) as Object
' l_asetDestroy(L_ASET **) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetDestroy/*"/>
Public Shared Sub l_asetDestroy(
				 ByVal ps as L_Rbtree)

	If IsNothing (ps) then Throw New ArgumentNullException  ("ps cannot be Nothing")

	Dim psPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ps) Then psPTR = ps.Pointer

	LeptonicaSharp.Natives.l_asetDestroy( psPTR)


End Sub

' SRC\map.c (233, 1)
' l_asetGetFirst(s) as L_Rbtree_Node
' l_asetGetFirst(L_ASET *) as L_ASET_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetFirst/*"/>
'''   <returns></returns>
Public Shared Function l_asetGetFirst(
				 ByVal s as L_Rbtree) as L_Rbtree_Node

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetFirst( s.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (239, 1)
' l_asetGetNext(n) as L_Rbtree_Node
' l_asetGetNext(L_ASET_NODE *) as L_ASET_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetNext/*"/>
'''   <returns></returns>
Public Shared Function l_asetGetNext(
				 ByVal n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetNext( n.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (245, 1)
' l_asetGetLast(s) as L_Rbtree_Node
' l_asetGetLast(L_ASET *) as L_ASET_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetLast/*"/>
'''   <returns></returns>
Public Shared Function l_asetGetLast(
				 ByVal s as L_Rbtree) as L_Rbtree_Node

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetLast( s.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (251, 1)
' l_asetGetPrev(n) as L_Rbtree_Node
' l_asetGetPrev(L_ASET_NODE *) as L_ASET_NODE *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetPrev/*"/>
'''   <returns></returns>
Public Shared Function l_asetGetPrev(
				 ByVal n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetPrev( n.Pointer)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (257, 1)
' l_asetSize(s) as Integer
' l_asetSize(L_ASET *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetSize/*"/>
'''   <returns></returns>
Public Shared Function l_asetSize(
				 ByVal s as L_Rbtree) as Integer

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_asetSize( s.Pointer)


	Return _Result
End Function

End Class
