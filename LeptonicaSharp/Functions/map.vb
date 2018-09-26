Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\map.c (107, 1)
' 
' l_amapCreate(l_int32) as L_AMAP *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapCreate(
				ByRef keytype as Integer) as L_Rbtree



	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapCreate( keytype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\map.c (121, 1)
' 
' l_amapFind(L_AMAP *, RB_TYPE) as RB_TYPE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapFind(
				ByRef m as L_Rbtree, 
				ByRef key as Rb_Type) as RB_TYPE

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapFind( m.Pointer, key.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new RB_TYPE(_Result)
End Function

' SRC\map.c (128, 1)
' 
' l_amapInsert(L_AMAP *, RB_TYPE, RB_TYPE) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_amapInsert(
				ByRef m as L_Rbtree, 
				ByRef key as Rb_Type, 
				ByRef value as Rb_Type)

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
	If IsNothing (value) then Throw New ArgumentNullException  ("value cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer
Dim valuePTR As IntPtr = IntPtr.Zero : If Not IsNothing(value) Then valuePTR = value.Pointer

	LeptonicaSharp.Natives.l_amapInsert( m.Pointer, key.Pointer, value.Pointer)

End Sub

' SRC\map.c (136, 1)
' 
' l_amapDelete(L_AMAP *, RB_TYPE) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_amapDelete(
				ByRef m as L_Rbtree, 
				ByRef key as Rb_Type)

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_amapDelete( m.Pointer, key.Pointer)

End Sub

' SRC\map.c (143, 1)
' 
' l_amapDestroy(L_AMAP **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_amapDestroy(
				ByRef pm as L_Rbtree)

	If IsNothing (pm) then Throw New ArgumentNullException  ("pm cannot be Nothing")

	Dim pmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pm) Then pmPTR = pm.Pointer

	LeptonicaSharp.Natives.l_amapDestroy( pmPTR)

End Sub

' SRC\map.c (149, 1)
' 
' l_amapGetFirst(L_AMAP *) as L_AMAP_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapGetFirst(
				ByRef m as L_Rbtree) as L_Rbtree_Node

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetFirst( m.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (155, 1)
' 
' l_amapGetNext(L_AMAP_NODE *) as L_AMAP_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapGetNext(
				ByRef n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetNext( n.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (161, 1)
' 
' l_amapGetLast(L_AMAP *) as L_AMAP_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapGetLast(
				ByRef m as L_Rbtree) as L_Rbtree_Node

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetLast( m.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (167, 1)
' 
' l_amapGetPrev(L_AMAP_NODE *) as L_AMAP_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapGetPrev(
				ByRef n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_amapGetPrev( n.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (173, 1)
' 
' l_amapSize(L_AMAP *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_amapSize(
				ByRef m as L_Rbtree) as Integer

	If IsNothing (m) then Throw New ArgumentNullException  ("m cannot be Nothing")

Dim mPTR As IntPtr = IntPtr.Zero : If Not IsNothing(m) Then mPTR = m.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_amapSize( m.Pointer)

	Return _Result
End Function

' SRC\map.c (183, 1)
' 
' l_asetCreate(l_int32) as L_ASET *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetCreate(
				ByRef keytype as Integer) as L_Rbtree



	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetCreate( keytype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\map.c (203, 1)
' 
' l_asetFind(L_ASET *, RB_TYPE) as RB_TYPE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetFind(
				ByRef s as L_Rbtree, 
				ByRef key as Rb_Type) as RB_TYPE

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetFind( s.Pointer, key.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new RB_TYPE(_Result)
End Function

' SRC\map.c (210, 1)
' 
' l_asetInsert(L_ASET *, RB_TYPE) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_asetInsert(
				ByRef s as L_Rbtree, 
				ByRef key as Rb_Type)

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_asetInsert( s.Pointer, key.Pointer)

End Sub

' SRC\map.c (220, 1)
' 
' l_asetDelete(L_ASET *, RB_TYPE) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_asetDelete(
				ByRef s as L_Rbtree, 
				ByRef key as Rb_Type)

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer
Dim keyPTR As IntPtr = IntPtr.Zero : If Not IsNothing(key) Then keyPTR = key.Pointer

	LeptonicaSharp.Natives.l_asetDelete( s.Pointer, key.Pointer)

End Sub

' SRC\map.c (227, 1)
' 
' l_asetDestroy(L_ASET **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_asetDestroy(
				ByRef ps as L_Rbtree)

	If IsNothing (ps) then Throw New ArgumentNullException  ("ps cannot be Nothing")

	Dim psPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ps) Then psPTR = ps.Pointer

	LeptonicaSharp.Natives.l_asetDestroy( psPTR)

End Sub

' SRC\map.c (233, 1)
' 
' l_asetGetFirst(L_ASET *) as L_ASET_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetGetFirst(
				ByRef s as L_Rbtree) as L_Rbtree_Node

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetFirst( s.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (239, 1)
' 
' l_asetGetNext(L_ASET_NODE *) as L_ASET_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetGetNext(
				ByRef n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetNext( n.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (245, 1)
' 
' l_asetGetLast(L_ASET *) as L_ASET_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetGetLast(
				ByRef s as L_Rbtree) as L_Rbtree_Node

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetLast( s.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (251, 1)
' 
' l_asetGetPrev(L_ASET_NODE *) as L_ASET_NODE *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetGetPrev(
				ByRef n as L_Rbtree_Node) as L_Rbtree_Node

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")

Dim nPTR As IntPtr = IntPtr.Zero : If Not IsNothing(n) Then nPTR = n.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetGetPrev( n.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree_Node(_Result)
End Function

' SRC\map.c (257, 1)
' 
' l_asetSize(L_ASET *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function l_asetSize(
				ByRef s as L_Rbtree) as Integer

	If IsNothing (s) then Throw New ArgumentNullException  ("s cannot be Nothing")

Dim sPTR As IntPtr = IntPtr.Zero : If Not IsNothing(s) Then sPTR = s.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_asetSize( s.Pointer)

	Return _Result
End Function

End Class
