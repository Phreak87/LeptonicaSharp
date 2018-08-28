Imports System.Runtime.InteropServices

#Region "SRC/environ.h"
' SRC/environ.h (308, 8)
' 
Public Class L_WallTimer
	Property Pointer as IntPTR
	Private Values as Marshal_L_WallTimer

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (309, 14)
'''  Org: [l_int32 start_sec]
''' </summary>
	Property start_sec as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (310, 14)
'''  Org: [l_int32 start_usec]
''' </summary>
	Property start_usec as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (311, 14)
'''  Org: [l_int32 stop_sec]
''' </summary>
	Property stop_sec as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (312, 14)
'''  Org: [l_int32 stop_usec]
''' </summary>
	Property stop_usec as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_WallTimer
		Marshal.PtrToStructure (Pointer, Values)
		start_sec = Values.start_sec
		start_usec = Values.start_usec
		stop_sec = Values.stop_sec
		stop_usec = Values.stop_usec
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_WallTimer
		Public start_sec as Integer
		Public start_usec as Integer
		Public stop_sec as Integer
		Public stop_usec as Integer
	End Class
End Class


#End Region
#Region "SRC/array.h"
' SRC/array.h (59, 8)
' 
Public Class Numa
	Property Pointer as IntPTR
	Private Values as Marshal_Numa

''' <summary>
''' Brf: size of allocated number array
'''  Loc: SRC/array.h (61, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of numbers saved
'''  Loc: SRC/array.h (62, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (63, 22)
'''  Org: [l_int32 refcount]
''' </summary>
	Property refcount as Integer

''' <summary>
''' Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (64, 22)
'''  Org: [l_float32 startx]
''' </summary>
	Property startx as Single

''' <summary>
''' Brf: change in x value as i -- greater  i + 1
'''  Loc: SRC/array.h (65, 22)
'''  Org: [l_float32 delx]
''' </summary>
	Property delx as Single

''' <summary>
''' Brf: number array
'''  Loc: SRC/array.h (66, 22)
'''  Org: [l_float32 * array]
''' </summary>
	Property array as Single()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Numa
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		refcount = Values.refcount
		startx = Values.startx
		delx = Values.delx
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Numa
		Public nalloc as Integer
		Public n as Integer
		Public refcount as Integer
		Public startx as Single
		Public delx as Single
		Public array as IntPTR
	End Class
End Class


' SRC/array.h (71, 8)
' 
Public Class Numaa
	Property Pointer as IntPTR
	Private Values as Marshal_Numaa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (73, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of Numa saved
'''  Loc: SRC/array.h (74, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: array of Numa
'''  Loc: SRC/array.h (75, 22)
'''  Org: [struct Numa ** numa]
''' </summary>
	Property numa as Numa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Numaa
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		numa = New Numa(Values.numa)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Numaa
		Public nalloc as Integer
		Public n as Integer
		Public numa as IntPTR
	End Class
End Class


' SRC/array.h (83, 8)
' 
Public Class L_Dna
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dna

''' <summary>
''' Brf: size of allocated number array
'''  Loc: SRC/array.h (85, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of numbers saved
'''  Loc: SRC/array.h (86, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (87, 22)
'''  Org: [l_int32 refcount]
''' </summary>
	Property refcount as Integer

''' <summary>
''' Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (88, 22)
'''  Org: [l_float64 startx]
''' </summary>
	Property startx as Double

''' <summary>
''' Brf: change in x value as i -- greater  i + 1
'''  Loc: SRC/array.h (89, 22)
'''  Org: [l_float64 delx]
''' </summary>
	Property delx as Double

''' <summary>
''' Brf: number array
'''  Loc: SRC/array.h (90, 22)
'''  Org: [l_float64 * array]
''' </summary>
	Property array as Double()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Dna
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		refcount = Values.refcount
		startx = Values.startx
		delx = Values.delx
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Dna
		Public nalloc as Integer
		Public n as Integer
		Public refcount as Integer
		Public startx as Double
		Public delx as Double
		Public array as IntPTR
	End Class
End Class


' SRC/array.h (95, 8)
' 
Public Class L_Dnaa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dnaa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (97, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of L_Dna saved
'''  Loc: SRC/array.h (98, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: array of L_Dna
'''  Loc: SRC/array.h (99, 22)
'''  Org: [struct L_Dna ** dna]
''' </summary>
	Property dna as L_Dna

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Dnaa
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		dna = New L_Dna(Values.dna)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Dnaa
		Public nalloc as Integer
		Public n as Integer
		Public dna as IntPTR
	End Class
End Class


' SRC/array.h (104, 8)
' 
Public Class L_DnaHash
	Property Pointer as IntPTR
	Private Values as Marshal_L_DnaHash

''' <summary>
''' Brf: 
'''  Loc: SRC/array.h (106, 22)
'''  Org: [l_int32 nbuckets]
''' </summary>
	Property nbuckets as Integer

''' <summary>
''' Brf: initial size of each dna that is made
'''  Loc: SRC/array.h (107, 22)
'''  Org: [l_int32 initsize]
''' </summary>
	Property initsize as Integer

''' <summary>
''' Brf: array of L_Dna
'''  Loc: SRC/array.h (108, 22)
'''  Org: [struct L_Dna ** dna]
''' </summary>
	Property dna as L_Dna

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_DnaHash
		Marshal.PtrToStructure (Pointer, Values)
		nbuckets = Values.nbuckets
		initsize = Values.initsize
		dna = New L_Dna(Values.dna)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_DnaHash
		Public nbuckets as Integer
		Public initsize as Integer
		Public dna as IntPTR
	End Class
End Class


' SRC/array.h (116, 8)
' 
Public Class Sarray
	Property Pointer as IntPTR
	Private Values as Marshal_Sarray

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (118, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of strings allocated
'''  Loc: SRC/array.h (119, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (120, 22)
'''  Org: [l_int32 refcount]
''' </summary>
	Property refcount as Integer

''' <summary>
''' Brf: string array
'''  Loc: SRC/array.h (121, 22)
'''  Org: [char ** array]
''' </summary>
	Property array as new List (of String)

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Sarray
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		refcount = Values.refcount
		Dim Marshal_array(n - 1) as IntPTR
Marshal.Copy(Values.array, Marshal_array, 0, Marshal_array.Length)
For Each Marshal_Value In Marshal_array : array.Add(Marshal.PtrToStringAnsi(Marshal_Value)) : Next
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Sarray
		Public nalloc as Integer
		Public n as Integer
		Public refcount as Integer
		Public array as IntPTR
	End Class
End Class


' SRC/array.h (126, 8)
' 
Public Class L_Bytea
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bytea

''' <summary>
''' Brf: number of bytes allocated in data array
'''  Loc: SRC/array.h (128, 22)
'''  Org: [size_t nalloc]
''' </summary>
	Property nalloc as UInteger

''' <summary>
''' Brf: number of bytes presently used
'''  Loc: SRC/array.h (129, 22)
'''  Org: [size_t size]
''' </summary>
	Property size as UInteger

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (130, 22)
'''  Org: [l_int32 refcount]
''' </summary>
	Property refcount as Integer

''' <summary>
''' Brf: data array
'''  Loc: SRC/array.h (131, 22)
'''  Org: [l_uint8 * data]
''' </summary>
	Property data as Byte()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Bytea
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		size = Values.size
		refcount = Values.refcount
		ReDim data(values.nalloc)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Bytea
		Public nalloc as UInteger
		Public size as UInteger
		Public refcount as Integer
		Public data as IntPTR
	End Class
End Class


#End Region
#Region "SRC/bbuffer.h"
' SRC/bbuffer.h (50, 8)
' 
Public Class L_ByteBuffer
	Property Pointer as IntPTR
	Private Values as Marshal_L_ByteBuffer

''' <summary>
''' Brf: size of allocated byte array
'''  Loc: SRC/bbuffer.h (52, 18)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of bytes read into to the array
'''  Loc: SRC/bbuffer.h (53, 18)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of bytes written from the array
'''  Loc: SRC/bbuffer.h (54, 18)
'''  Org: [l_int32 nwritten]
''' </summary>
	Property nwritten as Integer

''' <summary>
''' Brf: byte array
'''  Loc: SRC/bbuffer.h (55, 18)
'''  Org: [l_uint8 * array]
''' </summary>
	Property array as Byte()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_ByteBuffer
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		nwritten = Values.nwritten
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_ByteBuffer
		Public nalloc as Integer
		Public n as Integer
		Public nwritten as Integer
		Public array as IntPTR
	End Class
End Class


#End Region
#Region "SRC/heap.h"
' SRC/heap.h (77, 8)
' 
Public Class L_Heap
	Property Pointer as IntPTR
	Private Values as Marshal_L_Heap

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/heap.h (79, 18)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of elements stored in the heap
'''  Loc: SRC/heap.h (80, 18)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/heap.h (81, 18)
'''  Org: [void ** array]
''' </summary>
	Property array as Object

''' <summary>
''' Brf: L_SORT_INCREASING or L_SORT_DECREASING
'''  Loc: SRC/heap.h (82, 18)
'''  Org: [l_int32 direction]
''' </summary>
	Property direction as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Heap
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
		direction = Values.direction
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Heap
		Public nalloc as Integer
		Public n as Integer
		Public array as IntPTR
		Public direction as Integer
	End Class
End Class


#End Region
#Region "SRC/list.h"
' SRC/list.h (61, 8)
' 
Public Class DoubleLinkedList
	Property Pointer as IntPTR
	Private Values as Marshal_DoubleLinkedList

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (63, 33)
'''  Org: [struct DoubleLinkedList * prev]
''' </summary>
	Property prev as DoubleLinkedList

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (64, 33)
'''  Org: [struct DoubleLinkedList * next]
''' </summary>
	Property _next_ as DoubleLinkedList

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (65, 33)
'''  Org: [void * data]
''' </summary>
	Property data as Object

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_DoubleLinkedList
		Marshal.PtrToStructure (Pointer, Values)
		prev = New DoubleLinkedList(Values.prev)
		_next_ = New DoubleLinkedList(Values._next_)
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_DoubleLinkedList
		Public prev as IntPTR
		Public _next_ as IntPTR
		Public data as IntPTR
	End Class
End Class


#End Region
#Region "SRC/ptra.h"
' SRC/ptra.h (51, 8)
' 
Public Class L_Ptra
	Property Pointer as IntPTR
	Private Values as Marshal_L_Ptra

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (53, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: greatest valid index
'''  Loc: SRC/ptra.h (54, 22)
'''  Org: [l_int32 imax]
''' </summary>
	Property imax as Integer

''' <summary>
''' Brf: actual number of stored elements
'''  Loc: SRC/ptra.h (55, 22)
'''  Org: [l_int32 nactual]
''' </summary>
	Property nactual as Integer

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/ptra.h (56, 22)
'''  Org: [void ** array]
''' </summary>
	Property array as Object

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Ptra
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		imax = Values.imax
		nactual = Values.nactual
		ReDim array(values.nalloc)
Marshal.Copy(Values.array, array, 0, array.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Ptra
		Public nalloc as Integer
		Public imax as Integer
		Public nactual as Integer
		Public array as IntPTR
	End Class
End Class


' SRC/ptra.h (62, 8)
' 
Public Class L_Ptraa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Ptraa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (64, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: array of ptra
'''  Loc: SRC/ptra.h (65, 22)
'''  Org: [struct L_Ptra ** ptra]
''' </summary>
	Property ptra as L_Ptra

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Ptraa
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		ptra = New L_Ptra(Values.ptra)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Ptraa
		Public nalloc as Integer
		Public ptra as IntPTR
	End Class
End Class


#End Region
#Region "SRC/queue.h"
' SRC/queue.h (64, 8)
' 
Public Class L_Queue
	Property Pointer as IntPTR
	Private Values as Marshal_L_Queue

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/queue.h (66, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: location of head (in ptrs) from the
'''  Loc: SRC/queue.h (67, 22)
'''  Org: [l_int32 nhead]
''' </summary>
	Property nhead as Integer

''' <summary>
''' Brf: number of elements stored in the queue
'''  Loc: SRC/queue.h (69, 22)
'''  Org: [l_int32 nelem]
''' </summary>
	Property nelem as Integer

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/queue.h (70, 22)
'''  Org: [void ** array]
''' </summary>
	Property array as Object

''' <summary>
''' Brf: auxiliary stack
'''  Loc: SRC/queue.h (71, 22)
'''  Org: [struct L_Stack * stack]
''' </summary>
	Property stack as L_Stack

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Queue
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		nhead = Values.nhead
		nelem = Values.nelem
		ReDim array(values.nalloc)
Marshal.Copy(Values.array, array, 0, array.Length)
		stack = New L_Stack(Values.stack)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Queue
		Public nalloc as Integer
		Public nhead as Integer
		Public nelem as Integer
		Public array as IntPTR
		Public stack as IntPTR
	End Class
End Class


#End Region
#Region "SRC/rbtree.h"
' SRC/rbtree.h (61, 7)
' 
Public Class Rb_Type
	Property Pointer as IntPTR
	Private Values as Marshal_Rb_Type

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (62, 16)
'''  Org: [l_int64 itype]
''' </summary>
	Property itype as Long

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (63, 16)
'''  Org: [l_uint64 utype]
''' </summary>
	Property utype as ULong

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (64, 16)
'''  Org: [l_float64 ftype]
''' </summary>
	Property ftype as Double

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (65, 16)
'''  Org: [void * ptype]
''' </summary>
	Property ptype as Object

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Rb_Type
		Marshal.PtrToStructure (Pointer, Values)
		itype = Values.itype
		utype = Values.utype
		ftype = Values.ftype
		ReDim ptype(1)
Marshal.Copy(Values.ptype, ptype, 0, ptype.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Rb_Type
		Public itype as Long
		Public utype as ULong
		Public ftype as Double
		Public ptype as IntPTR
	End Class
End Class


' SRC/rbtree.h (69, 8)
' 
Public Class L_Rbtree
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rbtree

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (70, 28)
'''  Org: [struct L_Rbtree_Node * root]
''' </summary>
	Property root as L_Rbtree_Node

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (71, 28)
'''  Org: [l_int32 keytype]
''' </summary>
	Property keytype as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Rbtree
		Marshal.PtrToStructure (Pointer, Values)
		root = New L_Rbtree_Node(Values.root)
		keytype = Values.keytype
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rbtree
		Public root as IntPTR
		Public keytype as Integer
	End Class
End Class


' SRC/rbtree.h (77, 8)
' 
Public Class L_Rbtree_Node
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rbtree_Node

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (78, 28)
'''  Org: [union Rb_Type key]
''' </summary>
	Property key as Object

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (79, 28)
'''  Org: [union Rb_Type value]
''' </summary>
	Property value as Object

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (80, 28)
'''  Org: [struct L_Rbtree_Node * left]
''' </summary>
	Property left as L_Rbtree_Node

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (81, 28)
'''  Org: [struct L_Rbtree_Node * right]
''' </summary>
	Property right as L_Rbtree_Node

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (82, 28)
'''  Org: [struct L_Rbtree_Node * parent]
''' </summary>
	Property parent as L_Rbtree_Node

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (83, 28)
'''  Org: [l_int32 color]
''' </summary>
	Property color as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Rbtree_Node
		Marshal.PtrToStructure (Pointer, Values)
		key = Values.key
		value = Values.value
		left = New L_Rbtree_Node(Values.left)
		right = New L_Rbtree_Node(Values.right)
		parent = New L_Rbtree_Node(Values.parent)
		color = Values.color
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rbtree_Node
		Public key as IntPTR
		Public value as IntPTR
		Public left as IntPTR
		Public right as IntPTR
		Public parent as IntPTR
		Public color as Integer
	End Class
End Class


#End Region
#Region "SRC/stack.h"
' SRC/stack.h (59, 8)
' 
Public Class L_Stack
	Property Pointer as IntPTR
	Private Values as Marshal_L_Stack

''' <summary>
''' Brf: size of ptr array
'''  Loc: SRC/stack.h (61, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of stored elements
'''  Loc: SRC/stack.h (62, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/stack.h (63, 22)
'''  Org: [void ** array]
''' </summary>
	Property array as Object

''' <summary>
''' Brf: auxiliary stack
'''  Loc: SRC/stack.h (64, 22)
'''  Org: [struct L_Stack * auxstack]
''' </summary>
	Property auxstack as L_Stack

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Stack
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		n = Values.n
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
		auxstack = New L_Stack(Values.auxstack)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Stack
		Public nalloc as Integer
		Public n as Integer
		Public array as IntPTR
		Public auxstack as IntPTR
	End Class
End Class


#End Region
#Region "SRC/bmf.h"
' SRC/bmf.h (45, 8)
' 
Public Class L_Bmf
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bmf

''' <summary>
''' Brf: pixa of bitmaps for 93 characters
'''  Loc: SRC/bmf.h (47, 19)
'''  Org: [struct Pixa * pixa]
''' </summary>
	Property pixa as Pixa

''' <summary>
''' Brf: font size (in points at 300 ppi)
'''  Loc: SRC/bmf.h (48, 19)
'''  Org: [l_int32 size]
''' </summary>
	Property size as Integer

''' <summary>
''' Brf: directory containing font bitmaps
'''  Loc: SRC/bmf.h (49, 19)
'''  Org: [char * directory]
''' </summary>
	Property directory as String

''' <summary>
''' Brf: baseline offset for ascii 33 - 57
'''  Loc: SRC/bmf.h (50, 19)
'''  Org: [l_int32 baseline1]
''' </summary>
	Property baseline1 as Integer

''' <summary>
''' Brf: baseline offset for ascii 58 - 91
'''  Loc: SRC/bmf.h (51, 19)
'''  Org: [l_int32 baseline2]
''' </summary>
	Property baseline2 as Integer

''' <summary>
''' Brf: baseline offset for ascii 93 - 126
'''  Loc: SRC/bmf.h (52, 19)
'''  Org: [l_int32 baseline3]
''' </summary>
	Property baseline3 as Integer

''' <summary>
''' Brf: max height of line of chars
'''  Loc: SRC/bmf.h (53, 19)
'''  Org: [l_int32 lineheight]
''' </summary>
	Property lineheight as Integer

''' <summary>
''' Brf: pixel dist between char bitmaps
'''  Loc: SRC/bmf.h (54, 19)
'''  Org: [l_int32 kernwidth]
''' </summary>
	Property kernwidth as Integer

''' <summary>
''' Brf: pixel dist between word bitmaps
'''  Loc: SRC/bmf.h (55, 19)
'''  Org: [l_int32 spacewidth]
''' </summary>
	Property spacewidth as Integer

''' <summary>
''' Brf: extra vertical space between text lines
'''  Loc: SRC/bmf.h (56, 19)
'''  Org: [l_int32 vertlinesep]
''' </summary>
	Property vertlinesep as Integer

''' <summary>
''' Brf: table mapping ascii -- greater  font index
'''  Loc: SRC/bmf.h (57, 19)
'''  Org: [l_int32 * fonttab]
''' </summary>
	Property fonttab as Integer()

''' <summary>
''' Brf: table mapping ascii -- greater  baseline offset
'''  Loc: SRC/bmf.h (58, 19)
'''  Org: [l_int32 * baselinetab]
''' </summary>
	Property baselinetab as Integer()

''' <summary>
''' Brf: table mapping ascii -- greater  char width
'''  Loc: SRC/bmf.h (59, 19)
'''  Org: [l_int32 * widthtab]
''' </summary>
	Property widthtab as Integer()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Bmf
		Marshal.PtrToStructure (Pointer, Values)
		pixa = New Pixa(Values.pixa)
		size = Values.size
		directory = Values.directory
		baseline1 = Values.baseline1
		baseline2 = Values.baseline2
		baseline3 = Values.baseline3
		lineheight = Values.lineheight
		kernwidth = Values.kernwidth
		spacewidth = Values.spacewidth
		vertlinesep = Values.vertlinesep
		ReDim fonttab(1)
Marshal.Copy(Values.fonttab, fonttab, 0, fonttab.Length)
		ReDim baselinetab(1)
Marshal.Copy(Values.baselinetab, baselinetab, 0, baselinetab.Length)
		ReDim widthtab(1)
Marshal.Copy(Values.widthtab, widthtab, 0, widthtab.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Bmf
		Public pixa as IntPTR
		Public size as Integer
		Public directory as String
		Public baseline1 as Integer
		Public baseline2 as Integer
		Public baseline3 as Integer
		Public lineheight as Integer
		Public kernwidth as Integer
		Public spacewidth as Integer
		Public vertlinesep as Integer
		Public fonttab as IntPTR
		Public baselinetab as IntPTR
		Public widthtab as IntPTR
	End Class
End Class


#End Region
#Region "SRC/ccbord.h"
' SRC/ccbord.h (91, 8)
' 
Public Class CCBord
	Property Pointer as IntPTR
	Private Values as Marshal_CCBord

''' <summary>
''' Brf: component bitmap (min size)
'''  Loc: SRC/ccbord.h (93, 26)
'''  Org: [struct Pix * pix]
''' </summary>
	Property pix as Pix

''' <summary>
''' Brf: regions of each closed curve
'''  Loc: SRC/ccbord.h (94, 26)
'''  Org: [struct Boxa * boxa]
''' </summary>
	Property boxa as Boxa

''' <summary>
''' Brf: initial border pixel locations
'''  Loc: SRC/ccbord.h (95, 26)
'''  Org: [struct Pta * start]
''' </summary>
	Property start as Pta

''' <summary>
''' Brf: number of handles; start at 1
'''  Loc: SRC/ccbord.h (96, 26)
'''  Org: [l_int32 refcount]
''' </summary>
	Property refcount as Integer

''' <summary>
''' Brf: ptaa of chain pixels (local)
'''  Loc: SRC/ccbord.h (97, 26)
'''  Org: [struct Ptaa * local]
''' </summary>
	Property local as Ptaa

''' <summary>
''' Brf: ptaa of chain pixels (global)
'''  Loc: SRC/ccbord.h (98, 26)
'''  Org: [struct Ptaa * global]
''' </summary>
	Property _global_ as Ptaa

''' <summary>
''' Brf: numaa of chain code (step dir)
'''  Loc: SRC/ccbord.h (99, 26)
'''  Org: [struct Numaa * step]
''' </summary>
	Property _step_ as Numaa

''' <summary>
''' Brf: pta of single chain (local)
'''  Loc: SRC/ccbord.h (100, 26)
'''  Org: [struct Pta * splocal]
''' </summary>
	Property splocal as Pta

''' <summary>
''' Brf: pta of single chain (global)
'''  Loc: SRC/ccbord.h (101, 26)
'''  Org: [struct Pta * spglobal]
''' </summary>
	Property spglobal as Pta

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_CCBord
		Marshal.PtrToStructure (Pointer, Values)
		pix = New Pix(Values.pix)
		boxa = New Boxa(Values.boxa)
		start = New Pta(Values.start)
		refcount = Values.refcount
		local = New Ptaa(Values.local)
		_global_ = New Ptaa(Values._global_)
		_step_ = New Numaa(Values._step_)
		splocal = New Pta(Values.splocal)
		spglobal = New Pta(Values.spglobal)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_CCBord
		Public pix as IntPTR
		Public boxa as IntPTR
		Public start as IntPTR
		Public refcount as Integer
		Public local as IntPTR
		Public _global_ as IntPTR
		Public _step_ as IntPTR
		Public splocal as IntPTR
		Public spglobal as IntPTR
	End Class
End Class


' SRC/ccbord.h (106, 8)
' 
Public Class CCBorda
	Property Pointer as IntPTR
	Private Values as Marshal_CCBorda

''' <summary>
''' Brf: input pix (may be null)
'''  Loc: SRC/ccbord.h (108, 26)
'''  Org: [struct Pix * pix]
''' </summary>
	Property pix as Pix

''' <summary>
''' Brf: width of pix
'''  Loc: SRC/ccbord.h (109, 26)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: height of pix
'''  Loc: SRC/ccbord.h (110, 26)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: number of ccbord in ptr array
'''  Loc: SRC/ccbord.h (111, 26)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of ccbord ptrs allocated
'''  Loc: SRC/ccbord.h (112, 26)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: ccb ptr array
'''  Loc: SRC/ccbord.h (113, 26)
'''  Org: [struct CCBord ** ccb]
''' </summary>
	Property ccb as CCBord

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_CCBorda
		Marshal.PtrToStructure (Pointer, Values)
		pix = New Pix(Values.pix)
		w = Values.w
		h = Values.h
		n = Values.n
		nalloc = Values.nalloc
		ccb = New CCBord(Values.ccb)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_CCBorda
		Public pix as IntPTR
		Public w as Integer
		Public h as Integer
		Public n as Integer
		Public nalloc as Integer
		Public ccb as IntPTR
	End Class
End Class


#End Region
#Region "SRC/dewarp.h"
' SRC/dewarp.h (113, 8)
' 
Public Class L_Dewarpa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dewarpa

''' <summary>
''' Brf: size of dewarp ptr array
'''  Loc: SRC/dewarp.h (115, 24)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: maximum page number in array
'''  Loc: SRC/dewarp.h (116, 24)
'''  Org: [l_int32 maxpage]
''' </summary>
	Property maxpage as Integer

''' <summary>
''' Brf: array of ptrs to page dewarp
'''  Loc: SRC/dewarp.h (117, 24)
'''  Org: [struct L_Dewarp ** dewarp]
''' </summary>
	Property dewarp as L_Dewarp

''' <summary>
''' Brf: array of ptrs to cached dewarps
'''  Loc: SRC/dewarp.h (118, 24)
'''  Org: [struct L_Dewarp ** dewarpcache]
''' </summary>
	Property dewarpcache as L_Dewarp

''' <summary>
''' Brf: list of page numbers for pages
'''  Loc: SRC/dewarp.h (119, 24)
'''  Org: [struct Numa * namodels]
''' </summary>
	Property namodels as Numa

''' <summary>
''' Brf: list of page numbers with either
'''  Loc: SRC/dewarp.h (121, 24)
'''  Org: [struct Numa * napages]
''' </summary>
	Property napages as Numa

''' <summary>
''' Brf: reduction factor of input: 1 or 2
'''  Loc: SRC/dewarp.h (123, 24)
'''  Org: [l_int32 redfactor]
''' </summary>
	Property redfactor as Integer

''' <summary>
''' Brf: disparity arrays sampling factor
'''  Loc: SRC/dewarp.h (124, 24)
'''  Org: [l_int32 sampling]
''' </summary>
	Property sampling as Integer

''' <summary>
''' Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (125, 24)
'''  Org: [l_int32 minlines]
''' </summary>
	Property minlines as Integer

''' <summary>
''' Brf: max distance for getting ref page
'''  Loc: SRC/dewarp.h (126, 24)
'''  Org: [l_int32 maxdist]
''' </summary>
	Property maxdist as Integer

''' <summary>
''' Brf: maximum abs line curvature,
'''  Loc: SRC/dewarp.h (127, 24)
'''  Org: [l_int32 max_linecurv]
''' </summary>
	Property max_linecurv as Integer

''' <summary>
''' Brf: minimum abs diff line
'''  Loc: SRC/dewarp.h (129, 24)
'''  Org: [l_int32 min_diff_linecurv]
''' </summary>
	Property min_diff_linecurv as Integer

''' <summary>
''' Brf: maximum abs diff line
'''  Loc: SRC/dewarp.h (131, 24)
'''  Org: [l_int32 max_diff_linecurv]
''' </summary>
	Property max_diff_linecurv as Integer

''' <summary>
''' Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (133, 24)
'''  Org: [l_int32 max_edgeslope]
''' </summary>
	Property max_edgeslope as Integer

''' <summary>
''' Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (135, 24)
'''  Org: [l_int32 max_edgecurv]
''' </summary>
	Property max_edgecurv as Integer

''' <summary>
''' Brf: maximum abs diff left-right
'''  Loc: SRC/dewarp.h (137, 24)
'''  Org: [l_int32 max_diff_edgecurv]
''' </summary>
	Property max_diff_edgecurv as Integer

''' <summary>
''' Brf: use both disparity arrays if
'''  Loc: SRC/dewarp.h (139, 24)
'''  Org: [l_int32 useboth]
''' </summary>
	Property useboth as Integer

''' <summary>
''' Brf: if there are multiple columns,
'''  Loc: SRC/dewarp.h (141, 24)
'''  Org: [l_int32 check_columns]
''' </summary>
	Property check_columns as Integer

''' <summary>
''' Brf: invalid models have been removed
'''  Loc: SRC/dewarp.h (144, 24)
'''  Org: [l_int32 modelsready]
''' </summary>
	Property modelsready as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Dewarpa
		Marshal.PtrToStructure (Pointer, Values)
		nalloc = Values.nalloc
		maxpage = Values.maxpage
		dewarp = New L_Dewarp(Values.dewarp)
		dewarpcache = New L_Dewarp(Values.dewarpcache)
		namodels = New Numa(Values.namodels)
		napages = New Numa(Values.napages)
		redfactor = Values.redfactor
		sampling = Values.sampling
		minlines = Values.minlines
		maxdist = Values.maxdist
		max_linecurv = Values.max_linecurv
		min_diff_linecurv = Values.min_diff_linecurv
		max_diff_linecurv = Values.max_diff_linecurv
		max_edgeslope = Values.max_edgeslope
		max_edgecurv = Values.max_edgecurv
		max_diff_edgecurv = Values.max_diff_edgecurv
		useboth = Values.useboth
		check_columns = Values.check_columns
		modelsready = Values.modelsready
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Dewarpa
		Public nalloc as Integer
		Public maxpage as Integer
		Public dewarp as IntPTR
		Public dewarpcache as IntPTR
		Public namodels as IntPTR
		Public napages as IntPTR
		Public redfactor as Integer
		Public sampling as Integer
		Public minlines as Integer
		Public maxdist as Integer
		Public max_linecurv as Integer
		Public min_diff_linecurv as Integer
		Public max_diff_linecurv as Integer
		Public max_edgeslope as Integer
		Public max_edgecurv as Integer
		Public max_diff_edgecurv as Integer
		Public useboth as Integer
		Public check_columns as Integer
		Public modelsready as Integer
	End Class
End Class


' SRC/dewarp.h (151, 8)
' 
Public Class L_Dewarp
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dewarp

''' <summary>
''' Brf: ptr to parent (not owned)
'''  Loc: SRC/dewarp.h (153, 24)
'''  Org: [struct L_Dewarpa * dewa]
''' </summary>
	Property dewa as L_Dewarpa

''' <summary>
''' Brf: source pix, 1 bpp
'''  Loc: SRC/dewarp.h (154, 24)
'''  Org: [struct Pix * pixs]
''' </summary>
	Property pixs as Pix

''' <summary>
''' Brf: sampled vert disparity array
'''  Loc: SRC/dewarp.h (155, 24)
'''  Org: [struct FPix * sampvdispar]
''' </summary>
	Property sampvdispar as FPix

''' <summary>
''' Brf: sampled horiz disparity array
'''  Loc: SRC/dewarp.h (156, 24)
'''  Org: [struct FPix * samphdispar]
''' </summary>
	Property samphdispar as FPix

''' <summary>
''' Brf: sampled slope h-disparity array
'''  Loc: SRC/dewarp.h (157, 24)
'''  Org: [struct FPix * sampydispar]
''' </summary>
	Property sampydispar as FPix

''' <summary>
''' Brf: full vert disparity array
'''  Loc: SRC/dewarp.h (158, 24)
'''  Org: [struct FPix * fullvdispar]
''' </summary>
	Property fullvdispar as FPix

''' <summary>
''' Brf: full horiz disparity array
'''  Loc: SRC/dewarp.h (159, 24)
'''  Org: [struct FPix * fullhdispar]
''' </summary>
	Property fullhdispar as FPix

''' <summary>
''' Brf: full slope h-disparity array
'''  Loc: SRC/dewarp.h (160, 24)
'''  Org: [struct FPix * fullydispar]
''' </summary>
	Property fullydispar as FPix

''' <summary>
''' Brf: sorted y val of midpoint each line
'''  Loc: SRC/dewarp.h (161, 24)
'''  Org: [struct Numa * namidys]
''' </summary>
	Property namidys as Numa

''' <summary>
''' Brf: sorted curvature of each line
'''  Loc: SRC/dewarp.h (162, 24)
'''  Org: [struct Numa * nacurves]
''' </summary>
	Property nacurves as Numa

''' <summary>
''' Brf: width of source image
'''  Loc: SRC/dewarp.h (163, 24)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: height of source image
'''  Loc: SRC/dewarp.h (164, 24)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: page number; important for reuse
'''  Loc: SRC/dewarp.h (165, 24)
'''  Org: [l_int32 pageno]
''' </summary>
	Property pageno as Integer

''' <summary>
''' Brf: sampling factor of disparity arrays
'''  Loc: SRC/dewarp.h (166, 24)
'''  Org: [l_int32 sampling]
''' </summary>
	Property sampling as Integer

''' <summary>
''' Brf: reduction factor of pixs: 1 or 2
'''  Loc: SRC/dewarp.h (167, 24)
'''  Org: [l_int32 redfactor]
''' </summary>
	Property redfactor as Integer

''' <summary>
''' Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (168, 24)
'''  Org: [l_int32 minlines]
''' </summary>
	Property minlines as Integer

''' <summary>
''' Brf: number of long lines found
'''  Loc: SRC/dewarp.h (169, 24)
'''  Org: [l_int32 nlines]
''' </summary>
	Property nlines as Integer

''' <summary>
''' Brf: min line curvature in micro-units
'''  Loc: SRC/dewarp.h (170, 24)
'''  Org: [l_int32 mincurv]
''' </summary>
	Property mincurv as Integer

''' <summary>
''' Brf: max line curvature in micro-units
'''  Loc: SRC/dewarp.h (171, 24)
'''  Org: [l_int32 maxcurv]
''' </summary>
	Property maxcurv as Integer

''' <summary>
''' Brf: left edge slope in milli-units
'''  Loc: SRC/dewarp.h (172, 24)
'''  Org: [l_int32 leftslope]
''' </summary>
	Property leftslope as Integer

''' <summary>
''' Brf: right edge slope in milli-units
'''  Loc: SRC/dewarp.h (173, 24)
'''  Org: [l_int32 rightslope]
''' </summary>
	Property rightslope as Integer

''' <summary>
''' Brf: left edge curvature in micro-units
'''  Loc: SRC/dewarp.h (174, 24)
'''  Org: [l_int32 leftcurv]
''' </summary>
	Property leftcurv as Integer

''' <summary>
''' Brf: right edge curvature in micro-units
'''  Loc: SRC/dewarp.h (175, 24)
'''  Org: [l_int32 rightcurv]
''' </summary>
	Property rightcurv as Integer

''' <summary>
''' Brf: number of sampling pts in x-dir
'''  Loc: SRC/dewarp.h (176, 24)
'''  Org: [l_int32 nx]
''' </summary>
	Property nx as Integer

''' <summary>
''' Brf: number of sampling pts in y-dir
'''  Loc: SRC/dewarp.h (177, 24)
'''  Org: [l_int32 ny]
''' </summary>
	Property ny as Integer

''' <summary>
''' Brf: 0 if normal; 1 if has a refpage
'''  Loc: SRC/dewarp.h (178, 24)
'''  Org: [l_int32 hasref]
''' </summary>
	Property hasref as Integer

''' <summary>
''' Brf: page with disparity model to use
'''  Loc: SRC/dewarp.h (179, 24)
'''  Org: [l_int32 refpage]
''' </summary>
	Property refpage as Integer

''' <summary>
''' Brf: sets to 1 if vert disparity builds
'''  Loc: SRC/dewarp.h (180, 24)
'''  Org: [l_int32 vsuccess]
''' </summary>
	Property vsuccess as Integer

''' <summary>
''' Brf: sets to 1 if horiz disparity builds
'''  Loc: SRC/dewarp.h (181, 24)
'''  Org: [l_int32 hsuccess]
''' </summary>
	Property hsuccess as Integer

''' <summary>
''' Brf: sets to 1 if slope disparity builds
'''  Loc: SRC/dewarp.h (182, 24)
'''  Org: [l_int32 ysuccess]
''' </summary>
	Property ysuccess as Integer

''' <summary>
''' Brf: sets to 1 if valid vert disparity
'''  Loc: SRC/dewarp.h (183, 24)
'''  Org: [l_int32 vvalid]
''' </summary>
	Property vvalid as Integer

''' <summary>
''' Brf: sets to 1 if valid horiz disparity
'''  Loc: SRC/dewarp.h (184, 24)
'''  Org: [l_int32 hvalid]
''' </summary>
	Property hvalid as Integer

''' <summary>
''' Brf: if 1, skip horiz disparity
'''  Loc: SRC/dewarp.h (185, 24)
'''  Org: [l_int32 skip_horiz]
''' </summary>
	Property skip_horiz as Integer

''' <summary>
''' Brf: set to 1 if debug output requested
'''  Loc: SRC/dewarp.h (187, 24)
'''  Org: [l_int32 debug]
''' </summary>
	Property debug as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Dewarp
		Marshal.PtrToStructure (Pointer, Values)
		dewa = New L_Dewarpa(Values.dewa)
		pixs = New Pix(Values.pixs)
		sampvdispar = New FPix(Values.sampvdispar)
		samphdispar = New FPix(Values.samphdispar)
		sampydispar = New FPix(Values.sampydispar)
		fullvdispar = New FPix(Values.fullvdispar)
		fullhdispar = New FPix(Values.fullhdispar)
		fullydispar = New FPix(Values.fullydispar)
		namidys = New Numa(Values.namidys)
		nacurves = New Numa(Values.nacurves)
		w = Values.w
		h = Values.h
		pageno = Values.pageno
		sampling = Values.sampling
		redfactor = Values.redfactor
		minlines = Values.minlines
		nlines = Values.nlines
		mincurv = Values.mincurv
		maxcurv = Values.maxcurv
		leftslope = Values.leftslope
		rightslope = Values.rightslope
		leftcurv = Values.leftcurv
		rightcurv = Values.rightcurv
		nx = Values.nx
		ny = Values.ny
		hasref = Values.hasref
		refpage = Values.refpage
		vsuccess = Values.vsuccess
		hsuccess = Values.hsuccess
		ysuccess = Values.ysuccess
		vvalid = Values.vvalid
		hvalid = Values.hvalid
		skip_horiz = Values.skip_horiz
		debug = Values.debug
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Dewarp
		Public dewa as IntPTR
		Public pixs as IntPTR
		Public sampvdispar as IntPTR
		Public samphdispar as IntPTR
		Public sampydispar as IntPTR
		Public fullvdispar as IntPTR
		Public fullhdispar as IntPTR
		Public fullydispar as IntPTR
		Public namidys as IntPTR
		Public nacurves as IntPTR
		Public w as Integer
		Public h as Integer
		Public pageno as Integer
		Public sampling as Integer
		Public redfactor as Integer
		Public minlines as Integer
		Public nlines as Integer
		Public mincurv as Integer
		Public maxcurv as Integer
		Public leftslope as Integer
		Public rightslope as Integer
		Public leftcurv as Integer
		Public rightcurv as Integer
		Public nx as Integer
		Public ny as Integer
		Public hasref as Integer
		Public refpage as Integer
		Public vsuccess as Integer
		Public hsuccess as Integer
		Public ysuccess as Integer
		Public vvalid as Integer
		Public hvalid as Integer
		Public skip_horiz as Integer
		Public debug as Integer
	End Class
End Class


#End Region
#Region "SRC/gplot.h"
' SRC/gplot.h (75, 8)
' 
Public Class GPlot
	Property Pointer as IntPTR
	Private Values as Marshal_GPlot

''' <summary>
''' Brf: for cmd, data, output
'''  Loc: SRC/gplot.h (77, 20)
'''  Org: [char * rootname]
''' </summary>
	Property rootname as String

''' <summary>
''' Brf: command file name
'''  Loc: SRC/gplot.h (78, 20)
'''  Org: [char * cmdname]
''' </summary>
	Property cmdname as String

''' <summary>
''' Brf: command file contents
'''  Loc: SRC/gplot.h (79, 20)
'''  Org: [struct Sarray * cmddata]
''' </summary>
	Property cmddata as Sarray

''' <summary>
''' Brf: data file names
'''  Loc: SRC/gplot.h (80, 20)
'''  Org: [struct Sarray * datanames]
''' </summary>
	Property datanames as Sarray

''' <summary>
''' Brf: plot data (1 string/file)
'''  Loc: SRC/gplot.h (81, 20)
'''  Org: [struct Sarray * plotdata]
''' </summary>
	Property plotdata as Sarray

''' <summary>
''' Brf: title for each individual plot
'''  Loc: SRC/gplot.h (82, 20)
'''  Org: [struct Sarray * plottitles]
''' </summary>
	Property plottitles as Sarray

''' <summary>
''' Brf: plot style for individual plots
'''  Loc: SRC/gplot.h (83, 20)
'''  Org: [struct Numa * plotstyles]
''' </summary>
	Property plotstyles as Numa

''' <summary>
''' Brf: current number of plots
'''  Loc: SRC/gplot.h (84, 20)
'''  Org: [l_int32 nplots]
''' </summary>
	Property nplots as Integer

''' <summary>
''' Brf: output file name
'''  Loc: SRC/gplot.h (85, 20)
'''  Org: [char * outname]
''' </summary>
	Property outname as String

''' <summary>
''' Brf: GPLOT_OUTPUT values
'''  Loc: SRC/gplot.h (86, 20)
'''  Org: [l_int32 outformat]
''' </summary>
	Property outformat as Integer

''' <summary>
''' Brf: GPLOT_SCALING values
'''  Loc: SRC/gplot.h (87, 20)
'''  Org: [l_int32 scaling]
''' </summary>
	Property scaling as Integer

''' <summary>
''' Brf: optional
'''  Loc: SRC/gplot.h (88, 20)
'''  Org: [char * title]
''' </summary>
	Property title as String

''' <summary>
''' Brf: optional x axis label
'''  Loc: SRC/gplot.h (89, 20)
'''  Org: [char * xlabel]
''' </summary>
	Property xlabel as String

''' <summary>
''' Brf: optional y axis label
'''  Loc: SRC/gplot.h (90, 20)
'''  Org: [char * ylabel]
''' </summary>
	Property ylabel as String

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_GPlot
		Marshal.PtrToStructure (Pointer, Values)
		rootname = Values.rootname
		cmdname = Values.cmdname
		cmddata = New Sarray(Values.cmddata)
		datanames = New Sarray(Values.datanames)
		plotdata = New Sarray(Values.plotdata)
		plottitles = New Sarray(Values.plottitles)
		plotstyles = New Numa(Values.plotstyles)
		nplots = Values.nplots
		outname = Values.outname
		outformat = Values.outformat
		scaling = Values.scaling
		title = Values.title
		xlabel = Values.xlabel
		ylabel = Values.ylabel
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_GPlot
		Public rootname as String
		Public cmdname as String
		Public cmddata as IntPTR
		Public datanames as IntPTR
		Public plotdata as IntPTR
		Public plottitles as IntPTR
		Public plotstyles as IntPTR
		Public nplots as Integer
		Public outname as String
		Public outformat as Integer
		Public scaling as Integer
		Public title as String
		Public xlabel as String
		Public ylabel as String
	End Class
End Class


#End Region
#Region "SRC/imageio.h"
' SRC/imageio.h (166, 8)
' 
Public Class L_Compressed_Data
	Property Pointer as IntPTR
	Private Values as Marshal_L_Compressed_Data

''' <summary>
''' Brf: encoding type: L_JPEG_ENCODE, etc
'''  Loc: SRC/imageio.h (168, 24)
'''  Org: [l_int32 type]
''' </summary>
	Property type as Integer

''' <summary>
''' Brf: gzipped raster data
'''  Loc: SRC/imageio.h (169, 24)
'''  Org: [l_uint8 * datacomp]
''' </summary>
	Property datacomp as Byte()

''' <summary>
''' Brf: number of compressed bytes
'''  Loc: SRC/imageio.h (170, 24)
'''  Org: [size_t nbytescomp]
''' </summary>
	Property nbytescomp as UInteger

''' <summary>
''' Brf: ascii85-encoded gzipped raster data
'''  Loc: SRC/imageio.h (171, 24)
'''  Org: [char * data85]
''' </summary>
	Property data85 as String

''' <summary>
''' Brf: number of ascii85 encoded bytes
'''  Loc: SRC/imageio.h (172, 24)
'''  Org: [size_t nbytes85]
''' </summary>
	Property nbytes85 as UInteger

''' <summary>
''' Brf: ascii85-encoded uncompressed cmap
'''  Loc: SRC/imageio.h (173, 24)
'''  Org: [char * cmapdata85]
''' </summary>
	Property cmapdata85 as String

''' <summary>
''' Brf: hex pdf array for the cmap
'''  Loc: SRC/imageio.h (174, 24)
'''  Org: [char * cmapdatahex]
''' </summary>
	Property cmapdatahex as String

''' <summary>
''' Brf: number of colors in cmap
'''  Loc: SRC/imageio.h (175, 24)
'''  Org: [l_int32 ncolors]
''' </summary>
	Property ncolors as Integer

''' <summary>
''' Brf: image width
'''  Loc: SRC/imageio.h (176, 24)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: image height
'''  Loc: SRC/imageio.h (177, 24)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: bits/sample; typ. 1, 2, 4 or 8
'''  Loc: SRC/imageio.h (178, 24)
'''  Org: [l_int32 bps]
''' </summary>
	Property bps as Integer

''' <summary>
''' Brf: samples/pixel; typ. 1 or 3
'''  Loc: SRC/imageio.h (179, 24)
'''  Org: [l_int32 spp]
''' </summary>
	Property spp as Integer

''' <summary>
''' Brf: tiff g4 photometry
'''  Loc: SRC/imageio.h (180, 24)
'''  Org: [l_int32 minisblack]
''' </summary>
	Property minisblack as Integer

''' <summary>
''' Brf: flate data has PNG predictors
'''  Loc: SRC/imageio.h (181, 24)
'''  Org: [l_int32 predictor]
''' </summary>
	Property predictor as Integer

''' <summary>
''' Brf: number of uncompressed raster bytes
'''  Loc: SRC/imageio.h (182, 24)
'''  Org: [size_t nbytes]
''' </summary>
	Property nbytes as UInteger

''' <summary>
''' Brf: resolution (ppi)
'''  Loc: SRC/imageio.h (183, 24)
'''  Org: [l_int32 res]
''' </summary>
	Property res as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Compressed_Data
		Marshal.PtrToStructure (Pointer, Values)
		type = Values.type
		ReDim datacomp(1)
Marshal.Copy(Values.datacomp, datacomp, 0, datacomp.Length)
		nbytescomp = Values.nbytescomp
		data85 = Values.data85
		nbytes85 = Values.nbytes85
		cmapdata85 = Values.cmapdata85
		cmapdatahex = Values.cmapdatahex
		ncolors = Values.ncolors
		w = Values.w
		h = Values.h
		bps = Values.bps
		spp = Values.spp
		minisblack = Values.minisblack
		predictor = Values.predictor
		nbytes = Values.nbytes
		res = Values.res
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Compressed_Data
		Public type as Integer
		Public datacomp as IntPTR
		Public nbytescomp as UInteger
		Public data85 as String
		Public nbytes85 as UInteger
		Public cmapdata85 as String
		Public cmapdatahex as String
		Public ncolors as Integer
		Public w as Integer
		Public h as Integer
		Public bps as Integer
		Public spp as Integer
		Public minisblack as Integer
		Public predictor as Integer
		Public nbytes as UInteger
		Public res as Integer
	End Class
End Class


' SRC/imageio.h (211, 8)
' 
Public Class L_Pdf_Data
	Property Pointer as IntPTR
	Private Values as Marshal_L_Pdf_Data

''' <summary>
''' Brf: optional title for pdf
'''  Loc: SRC/imageio.h (213, 24)
'''  Org: [char * title]
''' </summary>
	Property title as String

''' <summary>
''' Brf: number of images
'''  Loc: SRC/imageio.h (214, 24)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of colormaps
'''  Loc: SRC/imageio.h (215, 24)
'''  Org: [l_int32 ncmap]
''' </summary>
	Property ncmap as Integer

''' <summary>
''' Brf: array of compressed image data
'''  Loc: SRC/imageio.h (216, 24)
'''  Org: [struct L_Ptra * cida]
''' </summary>
	Property cida as L_Ptra

''' <summary>
''' Brf: %PDF-1.2 id string
'''  Loc: SRC/imageio.h (217, 24)
'''  Org: [char * id]
''' </summary>
	Property id as String

''' <summary>
''' Brf: catalog string
'''  Loc: SRC/imageio.h (218, 24)
'''  Org: [char * obj1]
''' </summary>
	Property obj1 as String

''' <summary>
''' Brf: metadata string
'''  Loc: SRC/imageio.h (219, 24)
'''  Org: [char * obj2]
''' </summary>
	Property obj2 as String

''' <summary>
''' Brf: pages string
'''  Loc: SRC/imageio.h (220, 24)
'''  Org: [char * obj3]
''' </summary>
	Property obj3 as String

''' <summary>
''' Brf: page string (variable data)
'''  Loc: SRC/imageio.h (221, 24)
'''  Org: [char * obj4]
''' </summary>
	Property obj4 as String

''' <summary>
''' Brf: content string (variable data)
'''  Loc: SRC/imageio.h (222, 24)
'''  Org: [char * obj5]
''' </summary>
	Property obj5 as String

''' <summary>
''' Brf: post-binary-stream string
'''  Loc: SRC/imageio.h (223, 24)
'''  Org: [char * poststream]
''' </summary>
	Property poststream as String

''' <summary>
''' Brf: trailer string (variable data)
'''  Loc: SRC/imageio.h (224, 24)
'''  Org: [char * trailer]
''' </summary>
	Property trailer as String

''' <summary>
''' Brf: store (xpt, ypt) array
'''  Loc: SRC/imageio.h (225, 24)
'''  Org: [struct Pta * xy]
''' </summary>
	Property xy as Pta

''' <summary>
''' Brf: store (wpt, hpt) array
'''  Loc: SRC/imageio.h (226, 24)
'''  Org: [struct Pta * wh]
''' </summary>
	Property wh as Pta

''' <summary>
''' Brf: bounding region for all images
'''  Loc: SRC/imageio.h (227, 24)
'''  Org: [struct Box * mediabox]
''' </summary>
	Property mediabox as Box

''' <summary>
''' Brf: pre-binary-stream xobject strings
'''  Loc: SRC/imageio.h (228, 24)
'''  Org: [struct Sarray * saprex]
''' </summary>
	Property saprex as Sarray

''' <summary>
''' Brf: colormap pdf object strings
'''  Loc: SRC/imageio.h (229, 24)
'''  Org: [struct Sarray * sacmap]
''' </summary>
	Property sacmap as Sarray

''' <summary>
''' Brf: sizes of each pdf string object
'''  Loc: SRC/imageio.h (230, 24)
'''  Org: [struct L_Dna * objsize]
''' </summary>
	Property objsize as L_Dna

''' <summary>
''' Brf: location of each pdf string object
'''  Loc: SRC/imageio.h (231, 24)
'''  Org: [struct L_Dna * objloc]
''' </summary>
	Property objloc as L_Dna

''' <summary>
''' Brf: location of xref
'''  Loc: SRC/imageio.h (232, 24)
'''  Org: [l_int32 xrefloc]
''' </summary>
	Property xrefloc as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Pdf_Data
		Marshal.PtrToStructure (Pointer, Values)
		title = Values.title
		n = Values.n
		ncmap = Values.ncmap
		cida = New L_Ptra(Values.cida)
		id = Values.id
		obj1 = Values.obj1
		obj2 = Values.obj2
		obj3 = Values.obj3
		obj4 = Values.obj4
		obj5 = Values.obj5
		poststream = Values.poststream
		trailer = Values.trailer
		xy = New Pta(Values.xy)
		wh = New Pta(Values.wh)
		mediabox = New Box(Values.mediabox)
		saprex = New Sarray(Values.saprex)
		sacmap = New Sarray(Values.sacmap)
		objsize = New L_Dna(Values.objsize)
		objloc = New L_Dna(Values.objloc)
		xrefloc = Values.xrefloc
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Pdf_Data
		Public title as String
		Public n as Integer
		Public ncmap as Integer
		Public cida as IntPTR
		Public id as String
		Public obj1 as String
		Public obj2 as String
		Public obj3 as String
		Public obj4 as String
		Public obj5 as String
		Public poststream as String
		Public trailer as String
		Public xy as IntPTR
		Public wh as IntPTR
		Public mediabox as IntPTR
		Public saprex as IntPTR
		Public sacmap as IntPTR
		Public objsize as IntPTR
		Public objloc as IntPTR
		Public xrefloc as Integer
	End Class
End Class


#End Region
#Region "SRC/jbclass.h"
' SRC/jbclass.h (47, 8)
' 
Public Class JbClasser
	Property Pointer as IntPTR
	Private Values as Marshal_JbClasser

''' <summary>
''' Brf: input page image file names
'''  Loc: SRC/jbclass.h (49, 22)
'''  Org: [struct Sarray * safiles]
''' </summary>
	Property safiles as Sarray

''' <summary>
''' Brf: JB_RANKHAUS, JB_CORRELATION
'''  Loc: SRC/jbclass.h (50, 22)
'''  Org: [l_int32 method]
''' </summary>
	Property method as Integer

''' <summary>
''' Brf: JB_CONN_COMPS, JB_CHARACTERS or
'''  Loc: SRC/jbclass.h (51, 22)
'''  Org: [l_int32 components]
''' </summary>
	Property components as Integer

''' <summary>
''' Brf: max component width allowed
'''  Loc: SRC/jbclass.h (53, 22)
'''  Org: [l_int32 maxwidth]
''' </summary>
	Property maxwidth as Integer

''' <summary>
''' Brf: max component height allowed
'''  Loc: SRC/jbclass.h (54, 22)
'''  Org: [l_int32 maxheight]
''' </summary>
	Property maxheight as Integer

''' <summary>
''' Brf: number of pages already processed
'''  Loc: SRC/jbclass.h (55, 22)
'''  Org: [l_int32 npages]
''' </summary>
	Property npages as Integer

''' <summary>
''' Brf: number components already processed
'''  Loc: SRC/jbclass.h (56, 22)
'''  Org: [l_int32 baseindex]
''' </summary>
	Property baseindex as Integer

''' <summary>
''' Brf: number of components on each page
'''  Loc: SRC/jbclass.h (58, 22)
'''  Org: [struct Numa * nacomps]
''' </summary>
	Property nacomps as Numa

''' <summary>
''' Brf: size of square struct elem for haus
'''  Loc: SRC/jbclass.h (59, 22)
'''  Org: [l_int32 sizehaus]
''' </summary>
	Property sizehaus as Integer

''' <summary>
''' Brf: rank val of haus match, each way
'''  Loc: SRC/jbclass.h (60, 22)
'''  Org: [l_float32 rankhaus]
''' </summary>
	Property rankhaus as Single

''' <summary>
''' Brf: thresh value for correlation score
'''  Loc: SRC/jbclass.h (61, 22)
'''  Org: [l_float32 thresh]
''' </summary>
	Property thresh as Single

''' <summary>
''' Brf: corrects thresh value for heaver
'''  Loc: SRC/jbclass.h (62, 22)
'''  Org: [l_float32 weightfactor]
''' </summary>
	Property weightfactor as Single

''' <summary>
''' Brf: w * h of each template, without
'''  Loc: SRC/jbclass.h (64, 22)
'''  Org: [struct Numa * naarea]
''' </summary>
	Property naarea as Numa

''' <summary>
''' Brf: max width of original src images
'''  Loc: SRC/jbclass.h (66, 22)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: max height of original src images
'''  Loc: SRC/jbclass.h (67, 22)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: current number of classes
'''  Loc: SRC/jbclass.h (68, 22)
'''  Org: [l_int32 nclass]
''' </summary>
	Property nclass as Integer

''' <summary>
''' Brf: If zero, pixaa isn't filled
'''  Loc: SRC/jbclass.h (69, 22)
'''  Org: [l_int32 keep_pixaa]
''' </summary>
	Property keep_pixaa as Integer

''' <summary>
''' Brf: instances for each class; unbordered
'''  Loc: SRC/jbclass.h (70, 22)
'''  Org: [struct Pixaa * pixaa]
''' </summary>
	Property pixaa as Pixaa

''' <summary>
''' Brf: templates for each class; bordered
'''  Loc: SRC/jbclass.h (71, 22)
'''  Org: [struct Pixa * pixat]
''' </summary>
	Property pixat as Pixa

''' <summary>
''' Brf: templates for each class; bordered
'''  Loc: SRC/jbclass.h (73, 22)
'''  Org: [struct Pixa * pixatd]
''' </summary>
	Property pixatd as Pixa

''' <summary>
''' Brf: Hash table to find templates by size
'''  Loc: SRC/jbclass.h (75, 23)
'''  Org: [struct L_DnaHash * dahash]
''' </summary>
	Property dahash as L_DnaHash

''' <summary>
''' Brf: fg areas of undilated templates;
'''  Loc: SRC/jbclass.h (76, 22)
'''  Org: [struct Numa * nafgt]
''' </summary>
	Property nafgt as Numa

''' <summary>
''' Brf: centroids of all bordered cc
'''  Loc: SRC/jbclass.h (78, 22)
'''  Org: [struct Pta * ptac]
''' </summary>
	Property ptac as Pta

''' <summary>
''' Brf: centroids of all bordered template cc
'''  Loc: SRC/jbclass.h (79, 22)
'''  Org: [struct Pta * ptact]
''' </summary>
	Property ptact as Pta

''' <summary>
''' Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (80, 22)
'''  Org: [struct Numa * naclass]
''' </summary>
	Property naclass as Numa

''' <summary>
''' Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (81, 22)
'''  Org: [struct Numa * napage]
''' </summary>
	Property napage as Numa

''' <summary>
''' Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (82, 22)
'''  Org: [struct Pta * ptaul]
''' </summary>
	Property ptaul as Pta

''' <summary>
''' Brf: similar to ptaul, but for LL corners
'''  Loc: SRC/jbclass.h (85, 22)
'''  Org: [struct Pta * ptall]
''' </summary>
	Property ptall as Pta

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_JbClasser
		Marshal.PtrToStructure (Pointer, Values)
		safiles = New Sarray(Values.safiles)
		method = Values.method
		components = Values.components
		maxwidth = Values.maxwidth
		maxheight = Values.maxheight
		npages = Values.npages
		baseindex = Values.baseindex
		nacomps = New Numa(Values.nacomps)
		sizehaus = Values.sizehaus
		rankhaus = Values.rankhaus
		thresh = Values.thresh
		weightfactor = Values.weightfactor
		naarea = New Numa(Values.naarea)
		w = Values.w
		h = Values.h
		nclass = Values.nclass
		keep_pixaa = Values.keep_pixaa
		pixaa = New Pixaa(Values.pixaa)
		pixat = New Pixa(Values.pixat)
		pixatd = New Pixa(Values.pixatd)
		dahash = New L_DnaHash(Values.dahash)
		nafgt = New Numa(Values.nafgt)
		ptac = New Pta(Values.ptac)
		ptact = New Pta(Values.ptact)
		naclass = New Numa(Values.naclass)
		napage = New Numa(Values.napage)
		ptaul = New Pta(Values.ptaul)
		ptall = New Pta(Values.ptall)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_JbClasser
		Public safiles as IntPTR
		Public method as Integer
		Public components as Integer
		Public maxwidth as Integer
		Public maxheight as Integer
		Public npages as Integer
		Public baseindex as Integer
		Public nacomps as IntPTR
		Public sizehaus as Integer
		Public rankhaus as Single
		Public thresh as Single
		Public weightfactor as Single
		Public naarea as IntPTR
		Public w as Integer
		Public h as Integer
		Public nclass as Integer
		Public keep_pixaa as Integer
		Public pixaa as IntPTR
		Public pixat as IntPTR
		Public pixatd as IntPTR
		Public dahash as IntPTR
		Public nafgt as IntPTR
		Public ptac as IntPTR
		Public ptact as IntPTR
		Public naclass as IntPTR
		Public napage as IntPTR
		Public ptaul as IntPTR
		Public ptall as IntPTR
	End Class
End Class


' SRC/jbclass.h (104, 8)
' 
Public Class JbData
	Property Pointer as IntPTR
	Private Values as Marshal_JbData

''' <summary>
''' Brf: template composite for all classes
'''  Loc: SRC/jbclass.h (106, 22)
'''  Org: [struct Pix * pix]
''' </summary>
	Property pix as Pix

''' <summary>
''' Brf: number of pages
'''  Loc: SRC/jbclass.h (107, 22)
'''  Org: [l_int32 npages]
''' </summary>
	Property npages as Integer

''' <summary>
''' Brf: max width of original page images
'''  Loc: SRC/jbclass.h (108, 22)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: max height of original page images
'''  Loc: SRC/jbclass.h (109, 22)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: number of classes
'''  Loc: SRC/jbclass.h (110, 22)
'''  Org: [l_int32 nclass]
''' </summary>
	Property nclass as Integer

''' <summary>
''' Brf: lattice width for template composite
'''  Loc: SRC/jbclass.h (111, 22)
'''  Org: [l_int32 latticew]
''' </summary>
	Property latticew as Integer

''' <summary>
''' Brf: lattice height for template composite
'''  Loc: SRC/jbclass.h (112, 22)
'''  Org: [l_int32 latticeh]
''' </summary>
	Property latticeh as Integer

''' <summary>
''' Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (113, 22)
'''  Org: [struct Numa * naclass]
''' </summary>
	Property naclass as Numa

''' <summary>
''' Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (114, 22)
'''  Org: [struct Numa * napage]
''' </summary>
	Property napage as Numa

''' <summary>
''' Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (115, 22)
'''  Org: [struct Pta * ptaul]
''' </summary>
	Property ptaul as Pta

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_JbData
		Marshal.PtrToStructure (Pointer, Values)
		pix = New Pix(Values.pix)
		npages = Values.npages
		w = Values.w
		h = Values.h
		nclass = Values.nclass
		latticew = Values.latticew
		latticeh = Values.latticeh
		naclass = New Numa(Values.naclass)
		napage = New Numa(Values.napage)
		ptaul = New Pta(Values.ptaul)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_JbData
		Public pix as IntPTR
		Public npages as Integer
		Public w as Integer
		Public h as Integer
		Public nclass as Integer
		Public latticew as Integer
		Public latticeh as Integer
		Public naclass as IntPTR
		Public napage as IntPTR
		Public ptaul as IntPTR
	End Class
End Class


#End Region
#Region "SRC/morph.h"
' SRC/morph.h (62, 8)
' 
Public Class Sel
	Property Pointer as IntPTR
	Private Values as Marshal_Sel

''' <summary>
''' Brf: sel height
'''  Loc: SRC/morph.h (64, 19)
'''  Org: [l_int32 sy]
''' </summary>
	Property sy as Integer

''' <summary>
''' Brf: sel width
'''  Loc: SRC/morph.h (65, 19)
'''  Org: [l_int32 sx]
''' </summary>
	Property sx as Integer

''' <summary>
''' Brf: y location of sel origin
'''  Loc: SRC/morph.h (66, 19)
'''  Org: [l_int32 cy]
''' </summary>
	Property cy as Integer

''' <summary>
''' Brf: x location of sel origin
'''  Loc: SRC/morph.h (67, 19)
'''  Org: [l_int32 cx]
''' </summary>
	Property cx as Integer

''' <summary>
''' Brf: {0,1,2}; data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (68, 19)
'''  Org: [l_int32 ** data]
''' </summary>
	Property data as Integer()

''' <summary>
''' Brf: used to find sel by name
'''  Loc: SRC/morph.h (69, 19)
'''  Org: [char * name]
''' </summary>
	Property name as String

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Sel
		Marshal.PtrToStructure (Pointer, Values)
		sy = Values.sy
		sx = Values.sx
		cy = Values.cy
		cx = Values.cx
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
		name = Values.name
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Sel
		Public sy as Integer
		Public sx as Integer
		Public cy as Integer
		Public cx as Integer
		Public data as IntPTR
		Public name as String
	End Class
End Class


' SRC/morph.h (74, 8)
' 
Public Class Sela
	Property Pointer as IntPTR
	Private Values as Marshal_Sela

''' <summary>
''' Brf: number of sel actually stored
'''  Loc: SRC/morph.h (76, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/morph.h (77, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: sel ptr array
'''  Loc: SRC/morph.h (78, 22)
'''  Org: [struct Sel ** sel]
''' </summary>
	Property sel as Sel

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Sela
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		sel = New Sel(Values.sel)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Sela
		Public n as Integer
		Public nalloc as Integer
		Public sel as IntPTR
	End Class
End Class


' SRC/morph.h (89, 8)
' 
Public Class L_Kernel
	Property Pointer as IntPTR
	Private Values as Marshal_L_Kernel

''' <summary>
''' Brf: kernel height
'''  Loc: SRC/morph.h (91, 19)
'''  Org: [l_int32 sy]
''' </summary>
	Property sy as Integer

''' <summary>
''' Brf: kernel width
'''  Loc: SRC/morph.h (92, 19)
'''  Org: [l_int32 sx]
''' </summary>
	Property sx as Integer

''' <summary>
''' Brf: y location of kernel origin
'''  Loc: SRC/morph.h (93, 19)
'''  Org: [l_int32 cy]
''' </summary>
	Property cy as Integer

''' <summary>
''' Brf: x location of kernel origin
'''  Loc: SRC/morph.h (94, 19)
'''  Org: [l_int32 cx]
''' </summary>
	Property cx as Integer

''' <summary>
''' Brf: data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (95, 19)
'''  Org: [l_float32 ** data]
''' </summary>
	Property data as Single()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Kernel
		Marshal.PtrToStructure (Pointer, Values)
		sy = Values.sy
		sx = Values.sx
		cy = Values.cy
		cx = Values.cx
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Kernel
		Public sy as Integer
		Public sx as Integer
		Public cy as Integer
		Public cx as Integer
		Public data as IntPTR
	End Class
End Class


#End Region
#Region "SRC/pix.h"
' SRC/pix.h (134, 8)
' 
Public Class Pix
	Property Pointer as IntPTR
	Private Values as Marshal_Pix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (136, 26)
'''  Org: [l_uint32 w]
''' </summary>
	Property w as UInteger

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (137, 26)
'''  Org: [l_uint32 h]
''' </summary>
	Property h as UInteger

''' <summary>
''' Brf: depth in bits (bpp)
'''  Loc: SRC/pix.h (138, 26)
'''  Org: [l_uint32 d]
''' </summary>
	Property d as UInteger

''' <summary>
''' Brf: number of samples per pixel
'''  Loc: SRC/pix.h (139, 26)
'''  Org: [l_uint32 spp]
''' </summary>
	Property spp as UInteger

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (140, 26)
'''  Org: [l_uint32 wpl]
''' </summary>
	Property wpl as UInteger

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (141, 26)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (142, 26)
'''  Org: [l_int32 xres]
''' </summary>
	Property xres as Integer

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (144, 26)
'''  Org: [l_int32 yres]
''' </summary>
	Property yres as Integer

''' <summary>
''' Brf: input file format, IFF_*
'''  Loc: SRC/pix.h (146, 26)
'''  Org: [l_int32 informat]
''' </summary>
	Property informat as Integer

''' <summary>
''' Brf: special instructions for I/O, etc
'''  Loc: SRC/pix.h (147, 26)
'''  Org: [l_int32 special]
''' </summary>
	Property special as Integer

''' <summary>
''' Brf: text string associated with pix
'''  Loc: SRC/pix.h (148, 26)
'''  Org: [char * text]
''' </summary>
	Property text as String

''' <summary>
''' Brf: colormap (may be null)
'''  Loc: SRC/pix.h (149, 26)
'''  Org: [struct PixColormap * colormap]
''' </summary>
	Property colormap as PixColormap

''' <summary>
''' Brf: the image data
'''  Loc: SRC/pix.h (150, 26)
'''  Org: [l_uint32 * data]
''' </summary>
	Property data as Byte()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Pix
		Marshal.PtrToStructure (Pointer, Values)
		w = Values.w
		h = Values.h
		d = Values.d
		spp = Values.spp
		wpl = Values.wpl
		refcount = Values.refcount
		xres = Values.xres
		yres = Values.yres
		informat = Values.informat
		special = Values.special
		text = Values.text
		colormap = New PixColormap(Values.colormap)
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Pix
		Public w as UInteger
		Public h as UInteger
		Public d as UInteger
		Public spp as UInteger
		Public wpl as UInteger
		Public refcount as UInteger
		Public xres as Integer
		Public yres as Integer
		Public informat as Integer
		Public special as Integer
		Public text as String
		Public colormap as IntPTR
		Public data as IntPTR
	End Class
End Class


' SRC/pix.h (155, 8)
' 
Public Class PixColormap
	Property Pointer as IntPTR
	Private Values as Marshal_PixColormap

''' <summary>
''' Brf: colormap table (array of RGBA_QUAD)
'''  Loc: SRC/pix.h (157, 22)
'''  Org: [void * array]
''' </summary>
	Property array as Object

''' <summary>
''' Brf: of pix (1, 2, 4 or 8 bpp)
'''  Loc: SRC/pix.h (158, 22)
'''  Org: [l_int32 depth]
''' </summary>
	Property depth as Integer

''' <summary>
''' Brf: number of color entries allocated
'''  Loc: SRC/pix.h (159, 22)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: number of color entries used
'''  Loc: SRC/pix.h (160, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixColormap
		Marshal.PtrToStructure (Pointer, Values)
		ReDim array(values.n)
Marshal.Copy(Values.array, array, 0, array.Length)
		depth = Values.depth
		nalloc = Values.nalloc
		n = Values.n
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixColormap
		Public array as IntPTR
		Public depth as Integer
		Public nalloc as Integer
		Public n as Integer
	End Class
End Class


' SRC/pix.h (169, 8)
' 
Public Class RGBA_Quad
	Property Pointer as IntPTR
	Private Values as Marshal_RGBA_Quad

''' <summary>
''' Brf: blue value
'''  Loc: SRC/pix.h (171, 17)
'''  Org: [l_uint8 blue]
''' </summary>
	Property blue as Byte

''' <summary>
''' Brf: green value
'''  Loc: SRC/pix.h (172, 17)
'''  Org: [l_uint8 green]
''' </summary>
	Property green as Byte

''' <summary>
''' Brf: red value
'''  Loc: SRC/pix.h (173, 17)
'''  Org: [l_uint8 red]
''' </summary>
	Property red as Byte

''' <summary>
''' Brf: alpha value
'''  Loc: SRC/pix.h (174, 17)
'''  Org: [l_uint8 alpha]
''' </summary>
	Property alpha as Byte

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_RGBA_Quad
		Marshal.PtrToStructure (Pointer, Values)
		blue = Values.blue
		green = Values.green
		red = Values.red
		alpha = Values.alpha
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_RGBA_Quad
		Public blue as Byte
		Public green as Byte
		Public red as Byte
		Public alpha as Byte
	End Class
End Class


' SRC/pix.h (454, 8)
' 
Public Class Pixa
	Property Pointer as IntPTR
	Private Values as Marshal_Pixa

''' <summary>
''' Brf: number of Pix in ptr array
'''  Loc: SRC/pix.h (456, 25)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of Pix ptrs allocated
'''  Loc: SRC/pix.h (457, 25)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (458, 25)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: the array of ptrs to pix
'''  Loc: SRC/pix.h (459, 25)
'''  Org: [struct Pix ** pix]
''' </summary>
	Property pix as Pix

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (460, 25)
'''  Org: [struct Boxa * boxa]
''' </summary>
	Property boxa as Boxa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Pixa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		refcount = Values.refcount
		pix = New Pix(Values.pix)
		boxa = New Boxa(Values.boxa)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Pixa
		Public n as Integer
		Public nalloc as Integer
		Public refcount as UInteger
		Public pix as IntPTR
		Public boxa as IntPTR
	End Class
End Class


' SRC/pix.h (465, 8)
' 
Public Class Pixaa
	Property Pointer as IntPTR
	Private Values as Marshal_Pixaa

''' <summary>
''' Brf: number of Pixa in ptr array
'''  Loc: SRC/pix.h (467, 25)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of Pixa ptrs allocated
'''  Loc: SRC/pix.h (468, 25)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: array of ptrs to pixa
'''  Loc: SRC/pix.h (469, 25)
'''  Org: [struct Pixa ** pixa]
''' </summary>
	Property pixa as Pixa

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (470, 25)
'''  Org: [struct Boxa * boxa]
''' </summary>
	Property boxa as Boxa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Pixaa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		pixa = New Pixa(Values.pixa)
		boxa = New Boxa(Values.boxa)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Pixaa
		Public n as Integer
		Public nalloc as Integer
		Public pixa as IntPTR
		Public boxa as IntPTR
	End Class
End Class


' SRC/pix.h (480, 8)
' 
Public Class Box
	Property Pointer as IntPTR
	Private Values as Marshal_Box

''' <summary>
''' Brf: left coordinate
'''  Loc: SRC/pix.h (482, 24)
'''  Org: [l_int32 x]
''' </summary>
	Property x as Integer

''' <summary>
''' Brf: top coordinate
'''  Loc: SRC/pix.h (483, 24)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

''' <summary>
''' Brf: box width
'''  Loc: SRC/pix.h (484, 24)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: box height
'''  Loc: SRC/pix.h (485, 24)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (486, 24)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Box
		Marshal.PtrToStructure (Pointer, Values)
		x = Values.x
		y = Values.y
		w = Values.w
		h = Values.h
		refcount = Values.refcount
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Box
		Public x as Integer
		Public y as Integer
		Public w as Integer
		Public h as Integer
		Public refcount as UInteger
	End Class
End Class


' SRC/pix.h (492, 8)
' 
Public Class Boxa
	Property Pointer as IntPTR
	Private Values as Marshal_Boxa

''' <summary>
''' Brf: number of box in ptr array
'''  Loc: SRC/pix.h (494, 24)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of box ptrs allocated
'''  Loc: SRC/pix.h (495, 24)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (496, 24)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: box ptr array
'''  Loc: SRC/pix.h (497, 24)
'''  Org: [struct Box ** box]
''' </summary>
	Property box as Box

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Boxa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		refcount = Values.refcount
		box = New Box(Values.box)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Boxa
		Public n as Integer
		Public nalloc as Integer
		Public refcount as UInteger
		Public box as IntPTR
	End Class
End Class


' SRC/pix.h (502, 8)
' 
Public Class Boxaa
	Property Pointer as IntPTR
	Private Values as Marshal_Boxaa

''' <summary>
''' Brf: number of boxa in ptr array
'''  Loc: SRC/pix.h (504, 24)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of boxa ptrs allocated
'''  Loc: SRC/pix.h (505, 24)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: boxa ptr array
'''  Loc: SRC/pix.h (506, 24)
'''  Org: [struct Boxa ** boxa]
''' </summary>
	Property boxa as Boxa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Boxaa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		boxa = New Boxa(Values.boxa)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Boxaa
		Public n as Integer
		Public nalloc as Integer
		Public boxa as IntPTR
	End Class
End Class


' SRC/pix.h (517, 8)
' 
Public Class Pta
	Property Pointer as IntPTR
	Private Values as Marshal_Pta

''' <summary>
''' Brf: actual number of pts
'''  Loc: SRC/pix.h (519, 24)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: size of allocated arrays
'''  Loc: SRC/pix.h (520, 24)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (521, 24)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 24)
'''  Org: [l_float32 * x]
''' </summary>
	Property x as Single()

''' <summary>
''' Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 28)
'''  Org: [l_float32 * y]
''' </summary>
	Property y as Single()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Pta
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		refcount = Values.refcount
		ReDim x(values.n)
Marshal.Copy(Values.x, x, 0, x.Length)
		ReDim y(values.n)
Marshal.Copy(Values.y, y, 0, y.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Pta
		Public n as Integer
		Public nalloc as Integer
		Public refcount as UInteger
		Public x as IntPTR
		Public y as IntPTR
	End Class
End Class


' SRC/pix.h (532, 8)
' 
Public Class Ptaa
	Property Pointer as IntPTR
	Private Values as Marshal_Ptaa

''' <summary>
''' Brf: number of pta in ptr array
'''  Loc: SRC/pix.h (534, 26)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of pta ptrs allocated
'''  Loc: SRC/pix.h (535, 26)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: pta ptr array
'''  Loc: SRC/pix.h (536, 26)
'''  Org: [struct Pta ** pta]
''' </summary>
	Property pta as Pta

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Ptaa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		pta = New Pta(Values.pta)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Ptaa
		Public n as Integer
		Public nalloc as Integer
		Public pta as IntPTR
	End Class
End Class


' SRC/pix.h (546, 8)
' 
Public Class Pixacc
	Property Pointer as IntPTR
	Private Values as Marshal_Pixacc

''' <summary>
''' Brf: array width
'''  Loc: SRC/pix.h (548, 25)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: array height
'''  Loc: SRC/pix.h (549, 25)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: used to allow negative
'''  Loc: SRC/pix.h (550, 25)
'''  Org: [l_int32 offset]
''' </summary>
	Property offset as Integer

''' <summary>
''' Brf: the 32 bit accumulator pix
'''  Loc: SRC/pix.h (552, 25)
'''  Org: [struct Pix * pix]
''' </summary>
	Property pix as Pix

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_Pixacc
		Marshal.PtrToStructure (Pointer, Values)
		w = Values.w
		h = Values.h
		offset = Values.offset
		pix = New Pix(Values.pix)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Pixacc
		Public w as Integer
		Public h as Integer
		Public offset as Integer
		Public pix as IntPTR
	End Class
End Class


' SRC/pix.h (562, 8)
' 
Public Class PixTiling
	Property Pointer as IntPTR
	Private Values as Marshal_PixTiling

''' <summary>
''' Brf: input pix (a clone)
'''  Loc: SRC/pix.h (564, 26)
'''  Org: [struct Pix * pix]
''' </summary>
	Property pix as Pix

''' <summary>
''' Brf: number of tiles horizontally
'''  Loc: SRC/pix.h (565, 26)
'''  Org: [l_int32 nx]
''' </summary>
	Property nx as Integer

''' <summary>
''' Brf: number of tiles vertically
'''  Loc: SRC/pix.h (566, 26)
'''  Org: [l_int32 ny]
''' </summary>
	Property ny as Integer

''' <summary>
''' Brf: tile width
'''  Loc: SRC/pix.h (567, 26)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: tile height
'''  Loc: SRC/pix.h (568, 26)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: overlap on left and right
'''  Loc: SRC/pix.h (569, 26)
'''  Org: [l_int32 xoverlap]
''' </summary>
	Property xoverlap as Integer

''' <summary>
''' Brf: overlap on top and bottom
'''  Loc: SRC/pix.h (570, 26)
'''  Org: [l_int32 yoverlap]
''' </summary>
	Property yoverlap as Integer

''' <summary>
''' Brf: strip for paint; default is TRUE
'''  Loc: SRC/pix.h (571, 26)
'''  Org: [l_int32 strip]
''' </summary>
	Property strip as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixTiling
		Marshal.PtrToStructure (Pointer, Values)
		pix = New Pix(Values.pix)
		nx = Values.nx
		ny = Values.ny
		w = Values.w
		h = Values.h
		xoverlap = Values.xoverlap
		yoverlap = Values.yoverlap
		strip = Values.strip
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixTiling
		Public pix as IntPTR
		Public nx as Integer
		Public ny as Integer
		Public w as Integer
		Public h as Integer
		Public xoverlap as Integer
		Public yoverlap as Integer
		Public strip as Integer
	End Class
End Class


' SRC/pix.h (582, 8)
' 
Public Class FPix
	Property Pointer as IntPTR
	Private Values as Marshal_FPix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (584, 26)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (585, 26)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (586, 26)
'''  Org: [l_int32 wpl]
''' </summary>
	Property wpl as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (587, 26)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (588, 26)
'''  Org: [l_int32 xres]
''' </summary>
	Property xres as Integer

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (590, 26)
'''  Org: [l_int32 yres]
''' </summary>
	Property yres as Integer

''' <summary>
''' Brf: the float image data
'''  Loc: SRC/pix.h (592, 26)
'''  Org: [l_float32 * data]
''' </summary>
	Property data as Single()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_FPix
		Marshal.PtrToStructure (Pointer, Values)
		w = Values.w
		h = Values.h
		wpl = Values.wpl
		refcount = Values.refcount
		xres = Values.xres
		yres = Values.yres
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_FPix
		Public w as Integer
		Public h as Integer
		Public wpl as Integer
		Public refcount as UInteger
		Public xres as Integer
		Public yres as Integer
		Public data as IntPTR
	End Class
End Class


' SRC/pix.h (597, 8)
' 
Public Class FPixa
	Property Pointer as IntPTR
	Private Values as Marshal_FPixa

''' <summary>
''' Brf: number of fpix in ptr array
'''  Loc: SRC/pix.h (599, 25)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of fpix ptrs allocated
'''  Loc: SRC/pix.h (600, 25)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (601, 25)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: the array of ptrs to fpix
'''  Loc: SRC/pix.h (602, 25)
'''  Org: [struct FPix ** fpix]
''' </summary>
	Property fpix as FPix

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_FPixa
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		refcount = Values.refcount
		fpix = New FPix(Values.fpix)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_FPixa
		Public n as Integer
		Public nalloc as Integer
		Public refcount as UInteger
		Public fpix as IntPTR
	End Class
End Class


' SRC/pix.h (613, 8)
' 
Public Class DPix
	Property Pointer as IntPTR
	Private Values as Marshal_DPix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (615, 26)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (616, 26)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (617, 26)
'''  Org: [l_int32 wpl]
''' </summary>
	Property wpl as Integer

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (618, 26)
'''  Org: [l_uint32 refcount]
''' </summary>
	Property refcount as UInteger

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (619, 26)
'''  Org: [l_int32 xres]
''' </summary>
	Property xres as Integer

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (621, 26)
'''  Org: [l_int32 yres]
''' </summary>
	Property yres as Integer

''' <summary>
''' Brf: the double image data
'''  Loc: SRC/pix.h (623, 26)
'''  Org: [l_float64 * data]
''' </summary>
	Property data as Double()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_DPix
		Marshal.PtrToStructure (Pointer, Values)
		w = Values.w
		h = Values.h
		wpl = Values.wpl
		refcount = Values.refcount
		xres = Values.xres
		yres = Values.yres
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_DPix
		Public w as Integer
		Public h as Integer
		Public wpl as Integer
		Public refcount as UInteger
		Public xres as Integer
		Public yres as Integer
		Public data as IntPTR
	End Class
End Class


' SRC/pix.h (633, 8)
' 
Public Class PixComp
	Property Pointer as IntPTR
	Private Values as Marshal_PixComp

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (635, 26)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (636, 26)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: depth in bits
'''  Loc: SRC/pix.h (637, 26)
'''  Org: [l_int32 d]
''' </summary>
	Property d as Integer

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (638, 26)
'''  Org: [l_int32 xres]
''' </summary>
	Property xres as Integer

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (640, 26)
'''  Org: [l_int32 yres]
''' </summary>
	Property yres as Integer

''' <summary>
''' Brf: compressed format (IFF_TIFF_G4,
'''  Loc: SRC/pix.h (642, 26)
'''  Org: [l_int32 comptype]
''' </summary>
	Property comptype as Integer

''' <summary>
''' Brf: text string associated with pix
'''  Loc: SRC/pix.h (644, 26)
'''  Org: [char * text]
''' </summary>
	Property text as String

''' <summary>
''' Brf: flag (1 for cmap, 0 otherwise)
'''  Loc: SRC/pix.h (645, 26)
'''  Org: [l_int32 cmapflag]
''' </summary>
	Property cmapflag as Integer

''' <summary>
''' Brf: the compressed image data
'''  Loc: SRC/pix.h (646, 26)
'''  Org: [l_uint8 * data]
''' </summary>
	Property data as Byte()

''' <summary>
''' Brf: size of the data array
'''  Loc: SRC/pix.h (647, 26)
'''  Org: [size_t size]
''' </summary>
	Property size as UInteger

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixComp
		Marshal.PtrToStructure (Pointer, Values)
		w = Values.w
		h = Values.h
		d = Values.d
		xres = Values.xres
		yres = Values.yres
		comptype = Values.comptype
		text = Values.text
		cmapflag = Values.cmapflag
		ReDim data(1)
Marshal.Copy(Values.data, data, 0, data.Length)
		size = Values.size
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixComp
		Public w as Integer
		Public h as Integer
		Public d as Integer
		Public xres as Integer
		Public yres as Integer
		Public comptype as Integer
		Public text as String
		Public cmapflag as Integer
		Public data as IntPTR
		Public size as UInteger
	End Class
End Class


' SRC/pix.h (658, 8)
' 
Public Class PixaComp
	Property Pointer as IntPTR
	Private Values as Marshal_PixaComp

''' <summary>
''' Brf: number of PixComp in ptr array
'''  Loc: SRC/pix.h (660, 26)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: number of PixComp ptrs allocated
'''  Loc: SRC/pix.h (661, 26)
'''  Org: [l_int32 nalloc]
''' </summary>
	Property nalloc as Integer

''' <summary>
''' Brf: indexing offset into ptr array
'''  Loc: SRC/pix.h (662, 26)
'''  Org: [l_int32 offset]
''' </summary>
	Property offset as Integer

''' <summary>
''' Brf: the array of ptrs to PixComp
'''  Loc: SRC/pix.h (663, 26)
'''  Org: [struct PixComp ** pixc]
''' </summary>
	Property pixc as PixComp

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (664, 26)
'''  Org: [struct Boxa * boxa]
''' </summary>
	Property boxa as Boxa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixaComp
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		nalloc = Values.nalloc
		offset = Values.offset
		pixc = New PixComp(Values.pixc)
		boxa = New Boxa(Values.boxa)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixaComp
		Public n as Integer
		Public nalloc as Integer
		Public offset as Integer
		Public pixc as IntPTR
		Public boxa as IntPTR
	End Class
End Class


#End Region
#Region "SRC/recog.h"
' SRC/recog.h (116, 8)
' 
Public Class L_Recog
	Property Pointer as IntPTR
	Private Values as Marshal_L_Recog

''' <summary>
''' Brf: scale all examples to this width;
'''  Loc: SRC/recog.h (117, 20)
'''  Org: [l_int32 scalew]
''' </summary>
	Property scalew as Integer

''' <summary>
''' Brf: scale all examples to this height;
'''  Loc: SRC/recog.h (119, 20)
'''  Org: [l_int32 scaleh]
''' </summary>
	Property scaleh as Integer

''' <summary>
''' Brf: use a value  greater  0 to convert the bitmap
'''  Loc: SRC/recog.h (121, 20)
'''  Org: [l_int32 linew]
''' </summary>
	Property linew as Integer

''' <summary>
''' Brf: template use: use either the average
'''  Loc: SRC/recog.h (123, 20)
'''  Org: [l_int32 templ_use]
''' </summary>
	Property templ_use as Integer

''' <summary>
''' Brf: initialize container arrays to this
'''  Loc: SRC/recog.h (126, 20)
'''  Org: [l_int32 maxarraysize]
''' </summary>
	Property maxarraysize as Integer

''' <summary>
''' Brf: size of character set
'''  Loc: SRC/recog.h (127, 20)
'''  Org: [l_int32 setsize]
''' </summary>
	Property setsize as Integer

''' <summary>
''' Brf: for binarizing if depth  greater  1
'''  Loc: SRC/recog.h (128, 20)
'''  Org: [l_int32 threshold]
''' </summary>
	Property threshold as Integer

''' <summary>
''' Brf: vertical jiggle on nominal centroid
'''  Loc: SRC/recog.h (129, 20)
'''  Org: [l_int32 maxyshift]
''' </summary>
	Property maxyshift as Integer

''' <summary>
''' Brf: one of L_ARABIC_NUMERALS, etc.
'''  Loc: SRC/recog.h (131, 20)
'''  Org: [l_int32 charset_type]
''' </summary>
	Property charset_type as Integer

''' <summary>
''' Brf: expected number of classes in charset
'''  Loc: SRC/recog.h (132, 20)
'''  Org: [l_int32 charset_size]
''' </summary>
	Property charset_size as Integer

''' <summary>
''' Brf: min number of samples without padding
'''  Loc: SRC/recog.h (133, 20)
'''  Org: [l_int32 min_nopad]
''' </summary>
	Property min_nopad as Integer

''' <summary>
''' Brf: number of training samples
'''  Loc: SRC/recog.h (134, 20)
'''  Org: [l_int32 num_samples]
''' </summary>
	Property num_samples as Integer

''' <summary>
''' Brf: min width averaged unscaled templates
'''  Loc: SRC/recog.h (135, 20)
'''  Org: [l_int32 minwidth_u]
''' </summary>
	Property minwidth_u as Integer

''' <summary>
''' Brf: max width averaged unscaled templates
'''  Loc: SRC/recog.h (136, 20)
'''  Org: [l_int32 maxwidth_u]
''' </summary>
	Property maxwidth_u as Integer

''' <summary>
''' Brf: min height averaged unscaled templates
'''  Loc: SRC/recog.h (137, 20)
'''  Org: [l_int32 minheight_u]
''' </summary>
	Property minheight_u as Integer

''' <summary>
''' Brf: max height averaged unscaled templates
'''  Loc: SRC/recog.h (138, 20)
'''  Org: [l_int32 maxheight_u]
''' </summary>
	Property maxheight_u as Integer

''' <summary>
''' Brf: min width averaged scaled templates
'''  Loc: SRC/recog.h (139, 20)
'''  Org: [l_int32 minwidth]
''' </summary>
	Property minwidth as Integer

''' <summary>
''' Brf: max width averaged scaled templates
'''  Loc: SRC/recog.h (140, 20)
'''  Org: [l_int32 maxwidth]
''' </summary>
	Property maxwidth as Integer

''' <summary>
''' Brf: set to 1 when averaged bitmaps are made
'''  Loc: SRC/recog.h (141, 20)
'''  Org: [l_int32 ave_done]
''' </summary>
	Property ave_done as Integer

''' <summary>
''' Brf: set to 1 when training is complete or
'''  Loc: SRC/recog.h (142, 20)
'''  Org: [l_int32 train_done]
''' </summary>
	Property train_done as Integer

''' <summary>
''' Brf: max width/height ratio to split
'''  Loc: SRC/recog.h (144, 20)
'''  Org: [l_float32 max_wh_ratio]
''' </summary>
	Property max_wh_ratio as Single

''' <summary>
''' Brf: max of max/min template height ratio
'''  Loc: SRC/recog.h (145, 20)
'''  Org: [l_float32 max_ht_ratio]
''' </summary>
	Property max_ht_ratio as Single

''' <summary>
''' Brf: min component width kept in splitting
'''  Loc: SRC/recog.h (146, 20)
'''  Org: [l_int32 min_splitw]
''' </summary>
	Property min_splitw as Integer

''' <summary>
''' Brf: max component height kept in splitting
'''  Loc: SRC/recog.h (147, 20)
'''  Org: [l_int32 max_splith]
''' </summary>
	Property max_splith as Integer

''' <summary>
''' Brf: text array for arbitrary char set
'''  Loc: SRC/recog.h (148, 20)
'''  Org: [struct Sarray * sa_text]
''' </summary>
	Property sa_text as Sarray

''' <summary>
''' Brf: index-to-char lut for arbitrary charset
'''  Loc: SRC/recog.h (149, 20)
'''  Org: [struct L_Dna * dna_tochar]
''' </summary>
	Property dna_tochar as L_Dna

''' <summary>
''' Brf: table for finding centroids
'''  Loc: SRC/recog.h (150, 20)
'''  Org: [l_int32 * centtab]
''' </summary>
	Property centtab as Integer()

''' <summary>
''' Brf: table for finding pixel sums
'''  Loc: SRC/recog.h (151, 20)
'''  Org: [l_int32 * sumtab]
''' </summary>
	Property sumtab as Integer()

''' <summary>
''' Brf: all unscaled templates for each class
'''  Loc: SRC/recog.h (152, 20)
'''  Org: [struct Pixaa * pixaa_u]
''' </summary>
	Property pixaa_u as Pixaa

''' <summary>
''' Brf: centroids of all unscaled templates
'''  Loc: SRC/recog.h (153, 20)
'''  Org: [struct Ptaa * ptaa_u]
''' </summary>
	Property ptaa_u as Ptaa

''' <summary>
''' Brf: area of all unscaled templates
'''  Loc: SRC/recog.h (154, 20)
'''  Org: [struct Numaa * naasum_u]
''' </summary>
	Property naasum_u as Numaa

''' <summary>
''' Brf: all (scaled) templates for each class
'''  Loc: SRC/recog.h (155, 20)
'''  Org: [struct Pixaa * pixaa]
''' </summary>
	Property pixaa as Pixaa

''' <summary>
''' Brf: centroids of all (scaledl) templates
'''  Loc: SRC/recog.h (156, 20)
'''  Org: [struct Ptaa * ptaa]
''' </summary>
	Property ptaa as Ptaa

''' <summary>
''' Brf: area of all (scaled) templates
'''  Loc: SRC/recog.h (157, 20)
'''  Org: [struct Numaa * naasum]
''' </summary>
	Property naasum as Numaa

''' <summary>
''' Brf: averaged unscaled templates per class
'''  Loc: SRC/recog.h (158, 20)
'''  Org: [struct Pixa * pixa_u]
''' </summary>
	Property pixa_u as Pixa

''' <summary>
''' Brf: centroids of unscaled ave. templates
'''  Loc: SRC/recog.h (159, 20)
'''  Org: [struct Pta * pta_u]
''' </summary>
	Property pta_u as Pta

''' <summary>
''' Brf: area of unscaled averaged templates
'''  Loc: SRC/recog.h (160, 20)
'''  Org: [struct Numa * nasum_u]
''' </summary>
	Property nasum_u as Numa

''' <summary>
''' Brf: averaged (scaled) templates per class
'''  Loc: SRC/recog.h (161, 20)
'''  Org: [struct Pixa * pixa]
''' </summary>
	Property pixa as Pixa

''' <summary>
''' Brf: centroids of (scaled) ave. templates
'''  Loc: SRC/recog.h (162, 20)
'''  Org: [struct Pta * pta]
''' </summary>
	Property pta as Pta

''' <summary>
''' Brf: area of (scaled) averaged templates
'''  Loc: SRC/recog.h (163, 20)
'''  Org: [struct Numa * nasum]
''' </summary>
	Property nasum as Numa

''' <summary>
''' Brf: all input training images
'''  Loc: SRC/recog.h (164, 20)
'''  Org: [struct Pixa * pixa_tr]
''' </summary>
	Property pixa_tr as Pixa

''' <summary>
''' Brf: unscaled and scaled averaged bitmaps
'''  Loc: SRC/recog.h (165, 20)
'''  Org: [struct Pixa * pixadb_ave]
''' </summary>
	Property pixadb_ave as Pixa

''' <summary>
''' Brf: input images for identifying
'''  Loc: SRC/recog.h (166, 20)
'''  Org: [struct Pixa * pixa_id]
''' </summary>
	Property pixa_id as Pixa

''' <summary>
''' Brf: debug: best match of input against ave.
'''  Loc: SRC/recog.h (167, 20)
'''  Org: [struct Pix * pixdb_ave]
''' </summary>
	Property pixdb_ave as Pix

''' <summary>
''' Brf: debug: best matches within range
'''  Loc: SRC/recog.h (168, 20)
'''  Org: [struct Pix * pixdb_range]
''' </summary>
	Property pixdb_range as Pix

''' <summary>
''' Brf: debug: bootstrap training results
'''  Loc: SRC/recog.h (169, 20)
'''  Org: [struct Pixa * pixadb_boot]
''' </summary>
	Property pixadb_boot as Pixa

''' <summary>
''' Brf: debug: splitting results
'''  Loc: SRC/recog.h (170, 20)
'''  Org: [struct Pixa * pixadb_split]
''' </summary>
	Property pixadb_split as Pixa

''' <summary>
''' Brf: bmf fonts
'''  Loc: SRC/recog.h (171, 20)
'''  Org: [struct L_Bmf * bmf]
''' </summary>
	Property bmf as L_Bmf

''' <summary>
''' Brf: font size of bmf; default is 6 pt
'''  Loc: SRC/recog.h (172, 20)
'''  Org: [l_int32 bmf_size]
''' </summary>
	Property bmf_size as Integer

''' <summary>
''' Brf: temp data used for image decoding
'''  Loc: SRC/recog.h (173, 20)
'''  Org: [struct L_Rdid * did]
''' </summary>
	Property did as L_Rdid

''' <summary>
''' Brf: temp data used for holding best char
'''  Loc: SRC/recog.h (174, 20)
'''  Org: [struct L_Rch * rch]
''' </summary>
	Property rch as L_Rch

''' <summary>
''' Brf: temp data used for array of best chars
'''  Loc: SRC/recog.h (175, 20)
'''  Org: [struct L_Rcha * rcha]
''' </summary>
	Property rcha as L_Rcha

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Recog
		Marshal.PtrToStructure (Pointer, Values)
		scalew = Values.scalew
		scaleh = Values.scaleh
		linew = Values.linew
		templ_use = Values.templ_use
		maxarraysize = Values.maxarraysize
		setsize = Values.setsize
		threshold = Values.threshold
		maxyshift = Values.maxyshift
		charset_type = Values.charset_type
		charset_size = Values.charset_size
		min_nopad = Values.min_nopad
		num_samples = Values.num_samples
		minwidth_u = Values.minwidth_u
		maxwidth_u = Values.maxwidth_u
		minheight_u = Values.minheight_u
		maxheight_u = Values.maxheight_u
		minwidth = Values.minwidth
		maxwidth = Values.maxwidth
		ave_done = Values.ave_done
		train_done = Values.train_done
		max_wh_ratio = Values.max_wh_ratio
		max_ht_ratio = Values.max_ht_ratio
		min_splitw = Values.min_splitw
		max_splith = Values.max_splith
		sa_text = New Sarray(Values.sa_text)
		dna_tochar = New L_Dna(Values.dna_tochar)
		ReDim centtab(1)
Marshal.Copy(Values.centtab, centtab, 0, centtab.Length)
		ReDim sumtab(1)
Marshal.Copy(Values.sumtab, sumtab, 0, sumtab.Length)
		pixaa_u = New Pixaa(Values.pixaa_u)
		ptaa_u = New Ptaa(Values.ptaa_u)
		naasum_u = New Numaa(Values.naasum_u)
		pixaa = New Pixaa(Values.pixaa)
		ptaa = New Ptaa(Values.ptaa)
		naasum = New Numaa(Values.naasum)
		pixa_u = New Pixa(Values.pixa_u)
		pta_u = New Pta(Values.pta_u)
		nasum_u = New Numa(Values.nasum_u)
		pixa = New Pixa(Values.pixa)
		pta = New Pta(Values.pta)
		nasum = New Numa(Values.nasum)
		pixa_tr = New Pixa(Values.pixa_tr)
		pixadb_ave = New Pixa(Values.pixadb_ave)
		pixa_id = New Pixa(Values.pixa_id)
		pixdb_ave = New Pix(Values.pixdb_ave)
		pixdb_range = New Pix(Values.pixdb_range)
		pixadb_boot = New Pixa(Values.pixadb_boot)
		pixadb_split = New Pixa(Values.pixadb_split)
		bmf = New L_Bmf(Values.bmf)
		bmf_size = Values.bmf_size
		did = New L_Rdid(Values.did)
		rch = New L_Rch(Values.rch)
		rcha = New L_Rcha(Values.rcha)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Recog
		Public scalew as Integer
		Public scaleh as Integer
		Public linew as Integer
		Public templ_use as Integer
		Public maxarraysize as Integer
		Public setsize as Integer
		Public threshold as Integer
		Public maxyshift as Integer
		Public charset_type as Integer
		Public charset_size as Integer
		Public min_nopad as Integer
		Public num_samples as Integer
		Public minwidth_u as Integer
		Public maxwidth_u as Integer
		Public minheight_u as Integer
		Public maxheight_u as Integer
		Public minwidth as Integer
		Public maxwidth as Integer
		Public ave_done as Integer
		Public train_done as Integer
		Public max_wh_ratio as Single
		Public max_ht_ratio as Single
		Public min_splitw as Integer
		Public max_splith as Integer
		Public sa_text as IntPTR
		Public dna_tochar as IntPTR
		Public centtab as IntPTR
		Public sumtab as IntPTR
		Public pixaa_u as IntPTR
		Public ptaa_u as IntPTR
		Public naasum_u as IntPTR
		Public pixaa as IntPTR
		Public ptaa as IntPTR
		Public naasum as IntPTR
		Public pixa_u as IntPTR
		Public pta_u as IntPTR
		Public nasum_u as IntPTR
		Public pixa as IntPTR
		Public pta as IntPTR
		Public nasum as IntPTR
		Public pixa_tr as IntPTR
		Public pixadb_ave as IntPTR
		Public pixa_id as IntPTR
		Public pixdb_ave as IntPTR
		Public pixdb_range as IntPTR
		Public pixadb_boot as IntPTR
		Public pixadb_split as IntPTR
		Public bmf as IntPTR
		Public bmf_size as Integer
		Public did as IntPTR
		Public rch as IntPTR
		Public rcha as IntPTR
	End Class
End Class


' SRC/recog.h (182, 8)
' 
Public Class L_Rch
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rch

''' <summary>
''' Brf: index of best template
'''  Loc: SRC/recog.h (183, 20)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

''' <summary>
''' Brf: correlation score of best template
'''  Loc: SRC/recog.h (184, 20)
'''  Org: [l_float32 score]
''' </summary>
	Property score as Single

''' <summary>
''' Brf: character string of best template
'''  Loc: SRC/recog.h (185, 20)
'''  Org: [char * text]
''' </summary>
	Property text as String

''' <summary>
''' Brf: index of best sample (within the best
'''  Loc: SRC/recog.h (186, 20)
'''  Org: [l_int32 sample]
''' </summary>
	Property sample as Integer

''' <summary>
''' Brf: x-location of template (delx + shiftx)
'''  Loc: SRC/recog.h (188, 20)
'''  Org: [l_int32 xloc]
''' </summary>
	Property xloc as Integer

''' <summary>
''' Brf: y-location of template (dely + shifty)
'''  Loc: SRC/recog.h (189, 20)
'''  Org: [l_int32 yloc]
''' </summary>
	Property yloc as Integer

''' <summary>
''' Brf: width of best template
'''  Loc: SRC/recog.h (190, 20)
'''  Org: [l_int32 width]
''' </summary>
	Property width as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Rch
		Marshal.PtrToStructure (Pointer, Values)
		index = Values.index
		score = Values.score
		text = Values.text
		sample = Values.sample
		xloc = Values.xloc
		yloc = Values.yloc
		width = Values.width
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rch
		Public index as Integer
		Public score as Single
		Public text as String
		Public sample as Integer
		Public xloc as Integer
		Public yloc as Integer
		Public width as Integer
	End Class
End Class


' SRC/recog.h (197, 8)
' 
Public Class L_Rcha
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rcha

''' <summary>
''' Brf: indices of best templates
'''  Loc: SRC/recog.h (198, 20)
'''  Org: [struct Numa * naindex]
''' </summary>
	Property naindex as Numa

''' <summary>
''' Brf: correlation scores of best templates
'''  Loc: SRC/recog.h (199, 20)
'''  Org: [struct Numa * nascore]
''' </summary>
	Property nascore as Numa

''' <summary>
''' Brf: character strings of best templates
'''  Loc: SRC/recog.h (200, 20)
'''  Org: [struct Sarray * satext]
''' </summary>
	Property satext as Sarray

''' <summary>
''' Brf: indices of best samples
'''  Loc: SRC/recog.h (201, 20)
'''  Org: [struct Numa * nasample]
''' </summary>
	Property nasample as Numa

''' <summary>
''' Brf: x-locations of templates (delx + shiftx)
'''  Loc: SRC/recog.h (202, 20)
'''  Org: [struct Numa * naxloc]
''' </summary>
	Property naxloc as Numa

''' <summary>
''' Brf: y-locations of templates (dely + shifty)
'''  Loc: SRC/recog.h (203, 20)
'''  Org: [struct Numa * nayloc]
''' </summary>
	Property nayloc as Numa

''' <summary>
''' Brf: widths of best templates
'''  Loc: SRC/recog.h (204, 20)
'''  Org: [struct Numa * nawidth]
''' </summary>
	Property nawidth as Numa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Rcha
		Marshal.PtrToStructure (Pointer, Values)
		naindex = New Numa(Values.naindex)
		nascore = New Numa(Values.nascore)
		satext = New Sarray(Values.satext)
		nasample = New Numa(Values.nasample)
		naxloc = New Numa(Values.naxloc)
		nayloc = New Numa(Values.nayloc)
		nawidth = New Numa(Values.nawidth)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rcha
		Public naindex as IntPTR
		Public nascore as IntPTR
		Public satext as IntPTR
		Public nasample as IntPTR
		Public naxloc as IntPTR
		Public nayloc as IntPTR
		Public nawidth as IntPTR
	End Class
End Class


' SRC/recog.h (211, 8)
' 
Public Class L_Rdid
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rdid

''' <summary>
''' Brf: clone of pix to be decoded
'''  Loc: SRC/recog.h (212, 20)
'''  Org: [struct Pix * pixs]
''' </summary>
	Property pixs as Pix

''' <summary>
''' Brf: count array for each averaged template
'''  Loc: SRC/recog.h (213, 20)
'''  Org: [l_int32 ** counta]
''' </summary>
	Property counta as Integer()

''' <summary>
''' Brf: best y-shift array per average template
'''  Loc: SRC/recog.h (214, 20)
'''  Org: [l_int32 ** delya]
''' </summary>
	Property delya as Integer()

''' <summary>
''' Brf: number of averaged templates
'''  Loc: SRC/recog.h (215, 20)
'''  Org: [l_int32 narray]
''' </summary>
	Property narray as Integer

''' <summary>
''' Brf: size of count array (width of pixs)
'''  Loc: SRC/recog.h (216, 20)
'''  Org: [l_int32 size]
''' </summary>
	Property size as Integer

''' <summary>
''' Brf: setwidths for each template
'''  Loc: SRC/recog.h (217, 20)
'''  Org: [l_int32 * setwidth]
''' </summary>
	Property setwidth as Integer()

''' <summary>
''' Brf: pixel count in pixs by column
'''  Loc: SRC/recog.h (218, 20)
'''  Org: [struct Numa * nasum]
''' </summary>
	Property nasum as Numa

''' <summary>
''' Brf: first moment of pixels in pixs by cols
'''  Loc: SRC/recog.h (219, 20)
'''  Org: [struct Numa * namoment]
''' </summary>
	Property namoment as Numa

''' <summary>
''' Brf: 1 if full arrays are made; 0 otherwise
'''  Loc: SRC/recog.h (220, 20)
'''  Org: [l_int32 fullarrays]
''' </summary>
	Property fullarrays as Integer

''' <summary>
''' Brf: channel coeffs for template fg term
'''  Loc: SRC/recog.h (221, 20)
'''  Org: [l_float32 * beta]
''' </summary>
	Property beta as Single()

''' <summary>
''' Brf: channel coeffs for bit-and term
'''  Loc: SRC/recog.h (222, 20)
'''  Org: [l_float32 * gamma]
''' </summary>
	Property gamma as Single()

''' <summary>
''' Brf: score on trellis
'''  Loc: SRC/recog.h (223, 20)
'''  Org: [l_float32 * trellisscore]
''' </summary>
	Property trellisscore as Single()

''' <summary>
''' Brf: template on trellis (for backtrack)
'''  Loc: SRC/recog.h (224, 20)
'''  Org: [l_int32 * trellistempl]
''' </summary>
	Property trellistempl as Integer()

''' <summary>
''' Brf: indices of best path templates
'''  Loc: SRC/recog.h (225, 20)
'''  Org: [struct Numa * natempl]
''' </summary>
	Property natempl as Numa

''' <summary>
''' Brf: x locations of best path templates
'''  Loc: SRC/recog.h (226, 20)
'''  Org: [struct Numa * naxloc]
''' </summary>
	Property naxloc as Numa

''' <summary>
''' Brf: y locations of best path templates
'''  Loc: SRC/recog.h (227, 20)
'''  Org: [struct Numa * nadely]
''' </summary>
	Property nadely as Numa

''' <summary>
''' Brf: widths of best path templates
'''  Loc: SRC/recog.h (228, 20)
'''  Org: [struct Numa * nawidth]
''' </summary>
	Property nawidth as Numa

''' <summary>
''' Brf: Viterbi result for splitting input pixs
'''  Loc: SRC/recog.h (229, 20)
'''  Org: [struct Boxa * boxa]
''' </summary>
	Property boxa as Boxa

''' <summary>
''' Brf: correlation scores: best path templates
'''  Loc: SRC/recog.h (230, 20)
'''  Org: [struct Numa * nascore]
''' </summary>
	Property nascore as Numa

''' <summary>
''' Brf: indices of best rescored templates
'''  Loc: SRC/recog.h (231, 20)
'''  Org: [struct Numa * natempl_r]
''' </summary>
	Property natempl_r as Numa

''' <summary>
''' Brf: samples of best scored templates
'''  Loc: SRC/recog.h (232, 20)
'''  Org: [struct Numa * nasample_r]
''' </summary>
	Property nasample_r as Numa

''' <summary>
''' Brf: x locations of best rescoredtemplates
'''  Loc: SRC/recog.h (233, 20)
'''  Org: [struct Numa * naxloc_r]
''' </summary>
	Property naxloc_r as Numa

''' <summary>
''' Brf: y locations of best rescoredtemplates
'''  Loc: SRC/recog.h (234, 20)
'''  Org: [struct Numa * nadely_r]
''' </summary>
	Property nadely_r as Numa

''' <summary>
''' Brf: widths of best rescoredtemplates
'''  Loc: SRC/recog.h (235, 20)
'''  Org: [struct Numa * nawidth_r]
''' </summary>
	Property nawidth_r as Numa

''' <summary>
''' Brf: correlation scores: rescored templates
'''  Loc: SRC/recog.h (236, 20)
'''  Org: [struct Numa * nascore_r]
''' </summary>
	Property nascore_r as Numa

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Rdid
		Marshal.PtrToStructure (Pointer, Values)
		pixs = New Pix(Values.pixs)
		ReDim counta(1)
Marshal.Copy(Values.counta, counta, 0, counta.Length)
		ReDim delya(1)
Marshal.Copy(Values.delya, delya, 0, delya.Length)
		narray = Values.narray
		size = Values.size
		ReDim setwidth(1)
Marshal.Copy(Values.setwidth, setwidth, 0, setwidth.Length)
		nasum = New Numa(Values.nasum)
		namoment = New Numa(Values.namoment)
		fullarrays = Values.fullarrays
		ReDim beta(1)
Marshal.Copy(Values.beta, beta, 0, beta.Length)
		ReDim gamma(1)
Marshal.Copy(Values.gamma, gamma, 0, gamma.Length)
		ReDim trellisscore(1)
Marshal.Copy(Values.trellisscore, trellisscore, 0, trellisscore.Length)
		ReDim trellistempl(1)
Marshal.Copy(Values.trellistempl, trellistempl, 0, trellistempl.Length)
		natempl = New Numa(Values.natempl)
		naxloc = New Numa(Values.naxloc)
		nadely = New Numa(Values.nadely)
		nawidth = New Numa(Values.nawidth)
		boxa = New Boxa(Values.boxa)
		nascore = New Numa(Values.nascore)
		natempl_r = New Numa(Values.natempl_r)
		nasample_r = New Numa(Values.nasample_r)
		naxloc_r = New Numa(Values.naxloc_r)
		nadely_r = New Numa(Values.nadely_r)
		nawidth_r = New Numa(Values.nawidth_r)
		nascore_r = New Numa(Values.nascore_r)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rdid
		Public pixs as IntPTR
		Public counta as IntPTR
		Public delya as IntPTR
		Public narray as Integer
		Public size as Integer
		Public setwidth as IntPTR
		Public nasum as IntPTR
		Public namoment as IntPTR
		Public fullarrays as Integer
		Public beta as IntPTR
		Public gamma as IntPTR
		Public trellisscore as IntPTR
		Public trellistempl as IntPTR
		Public natempl as IntPTR
		Public naxloc as IntPTR
		Public nadely as IntPTR
		Public nawidth as IntPTR
		Public boxa as IntPTR
		Public nascore as IntPTR
		Public natempl_r as IntPTR
		Public nasample_r as IntPTR
		Public naxloc_r as IntPTR
		Public nadely_r as IntPTR
		Public nawidth_r as IntPTR
		Public nascore_r as IntPTR
	End Class
End Class


#End Region
#Region "SRC/regutils.h"
' SRC/regutils.h (117, 8)
' 
Public Class L_RegParams
	Property Pointer as IntPTR
	Private Values as Marshal_L_RegParams

''' <summary>
''' Brf: stream to temporary output file for compare mode
'''  Loc: SRC/regutils.h (119, 14)
'''  Org: [FILE * fp]
''' </summary>
	Property fp as Object

''' <summary>
''' Brf: name of test, without '_reg'
'''  Loc: SRC/regutils.h (120, 14)
'''  Org: [char * testname]
''' </summary>
	Property testname as String

''' <summary>
''' Brf: name of temp file for compare mode output
'''  Loc: SRC/regutils.h (121, 14)
'''  Org: [char * tempfile]
''' </summary>
	Property tempfile as String

''' <summary>
''' Brf: generate, compare or display
'''  Loc: SRC/regutils.h (122, 14)
'''  Org: [l_int32 mode]
''' </summary>
	Property mode as Integer

''' <summary>
''' Brf: index into saved files for this test; 0-based
'''  Loc: SRC/regutils.h (123, 14)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

''' <summary>
''' Brf: overall result of the test
'''  Loc: SRC/regutils.h (124, 14)
'''  Org: [l_int32 success]
''' </summary>
	Property success as Integer

''' <summary>
''' Brf: 1 if in display mode; 0 otherwise
'''  Loc: SRC/regutils.h (125, 14)
'''  Org: [l_int32 display]
''' </summary>
	Property display as Integer

''' <summary>
''' Brf: marks beginning of the reg test
'''  Loc: SRC/regutils.h (126, 14)
'''  Org: [L_TIMER tstart]
''' </summary>
	Property tstart as IntPTR

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_RegParams
		Marshal.PtrToStructure (Pointer, Values)
		ReDim fp(1)
Marshal.Copy(Values.fp, fp, 0, fp.Length)
		testname = Values.testname
		tempfile = Values.tempfile
		mode = Values.mode
		index = Values.index
		success = Values.success
		display = Values.display
		tstart = Values.tstart
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_RegParams
		Public fp as IntPTR
		Public testname as String
		Public tempfile as String
		Public mode as Integer
		Public index as Integer
		Public success as Integer
		Public display as Integer
		Public tstart as IntPTR
	End Class
End Class


#End Region
#Region "SRC/stringcode.h"
' SRC/stringcode.h (40, 8)
' 
Public Class L_StrCode
	Property Pointer as IntPTR
	Private Values as Marshal_L_StrCode

''' <summary>
''' Brf: index for function and output file names
'''  Loc: SRC/stringcode.h (42, 19)
'''  Org: [l_int32 fileno]
''' </summary>
	Property fileno as Integer

''' <summary>
''' Brf: index into struct currently being stored
'''  Loc: SRC/stringcode.h (43, 19)
'''  Org: [l_int32 ifunc]
''' </summary>
	Property ifunc as Integer

''' <summary>
''' Brf: store case code for extraction
'''  Loc: SRC/stringcode.h (44, 19)
'''  Org: [SARRAY * function]
''' </summary>
	Property _function_ as Object

''' <summary>
''' Brf: store base64 encoded data as strings
'''  Loc: SRC/stringcode.h (45, 19)
'''  Org: [SARRAY * data]
''' </summary>
	Property data as Object

''' <summary>
''' Brf: store line in description table
'''  Loc: SRC/stringcode.h (46, 19)
'''  Org: [SARRAY * descr]
''' </summary>
	Property descr as Object

''' <summary>
''' Brf: number of data strings
'''  Loc: SRC/stringcode.h (47, 19)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_StrCode
		Marshal.PtrToStructure (Pointer, Values)
		fileno = Values.fileno
		ifunc = Values.ifunc
		ReDim _function_(values.n)
Marshal.Copy(Values._function_, _function_, 0, _function_.Length)
		ReDim data(values.n)
Marshal.Copy(Values.data, data, 0, data.Length)
		ReDim descr(values.n)
Marshal.Copy(Values.descr, descr, 0, descr.Length)
		n = Values.n
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_StrCode
		Public fileno as Integer
		Public ifunc as Integer
		Public _function_ as IntPTR
		Public data as IntPTR
		Public descr as IntPTR
		Public n as Integer
	End Class
End Class


#End Region
#Region "SRC/sudoku.h"
' SRC/sudoku.h (52, 8)
' 
Public Class L_Sudoku
	Property Pointer as IntPTR
	Private Values as Marshal_L_Sudoku

''' <summary>
''' Brf: number of unknowns
'''  Loc: SRC/sudoku.h (54, 20)
'''  Org: [l_int32 num]
''' </summary>
	Property num as Integer

''' <summary>
''' Brf: location of unknowns
'''  Loc: SRC/sudoku.h (55, 20)
'''  Org: [l_int32 * locs]
''' </summary>
	Property locs as Integer()

''' <summary>
''' Brf: index into %locs of current location
'''  Loc: SRC/sudoku.h (56, 20)
'''  Org: [l_int32 current]
''' </summary>
	Property current as Integer

''' <summary>
''' Brf: initial state, with 0 representing
'''  Loc: SRC/sudoku.h (57, 20)
'''  Org: [l_int32 * init]
''' </summary>
	Property init as Integer()

''' <summary>
''' Brf: present state, including inits and
'''  Loc: SRC/sudoku.h (59, 20)
'''  Org: [l_int32 * state]
''' </summary>
	Property state as Integer()

''' <summary>
''' Brf: shows current number of guesses
'''  Loc: SRC/sudoku.h (61, 20)
'''  Org: [l_int32 nguess]
''' </summary>
	Property nguess as Integer

''' <summary>
''' Brf: set to 1 when solved
'''  Loc: SRC/sudoku.h (62, 20)
'''  Org: [l_int32 finished]
''' </summary>
	Property finished as Integer

''' <summary>
''' Brf: set to 1 if no solution is possible
'''  Loc: SRC/sudoku.h (63, 20)
'''  Org: [l_int32 failure]
''' </summary>
	Property failure as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Sudoku
		Marshal.PtrToStructure (Pointer, Values)
		num = Values.num
		ReDim locs(1)
Marshal.Copy(Values.locs, locs, 0, locs.Length)
		current = Values.current
		ReDim init(1)
Marshal.Copy(Values.init, init, 0, init.Length)
		ReDim state(1)
Marshal.Copy(Values.state, state, 0, state.Length)
		nguess = Values.nguess
		finished = Values.finished
		failure = Values.failure
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Sudoku
		Public num as Integer
		Public locs as IntPTR
		Public current as Integer
		Public init as IntPTR
		Public state as IntPTR
		Public nguess as Integer
		Public finished as Integer
		Public failure as Integer
	End Class
End Class


#End Region
#Region "SRC/watershed.h"
' SRC/watershed.h (38, 8)
' 
Public Class L_WShed
	Property Pointer as IntPTR
	Private Values as Marshal_L_WShed

''' <summary>
''' Brf: clone of input 8 bpp pixs
'''  Loc: SRC/watershed.h (40, 20)
'''  Org: [struct Pix * pixs]
''' </summary>
	Property pixs as Pix

''' <summary>
''' Brf: clone of input 1 bpp seed (marker) pixm
'''  Loc: SRC/watershed.h (41, 20)
'''  Org: [struct Pix * pixm]
''' </summary>
	Property pixm as Pix

''' <summary>
''' Brf: minimum depth allowed for a watershed
'''  Loc: SRC/watershed.h (42, 20)
'''  Org: [l_int32 mindepth]
''' </summary>
	Property mindepth as Integer

''' <summary>
''' Brf: 16 bpp label pix
'''  Loc: SRC/watershed.h (43, 20)
'''  Org: [struct Pix * pixlab]
''' </summary>
	Property pixlab as Pix

''' <summary>
''' Brf: scratch pix for computing wshed regions
'''  Loc: SRC/watershed.h (44, 20)
'''  Org: [struct Pix * pixt]
''' </summary>
	Property pixt as Pix

''' <summary>
''' Brf: line ptrs for pixs
'''  Loc: SRC/watershed.h (45, 20)
'''  Org: [void ** lines8]
''' </summary>
	Property lines8 as Object

''' <summary>
''' Brf: line ptrs for pixm
'''  Loc: SRC/watershed.h (46, 20)
'''  Org: [void ** linem1]
''' </summary>
	Property linem1 as Object

''' <summary>
''' Brf: line ptrs for pixlab
'''  Loc: SRC/watershed.h (47, 20)
'''  Org: [void ** linelab32]
''' </summary>
	Property linelab32 as Object

''' <summary>
''' Brf: line ptrs for pixt
'''  Loc: SRC/watershed.h (48, 20)
'''  Org: [void ** linet1]
''' </summary>
	Property linet1 as Object

''' <summary>
''' Brf: result: 1 bpp pixa of watersheds
'''  Loc: SRC/watershed.h (49, 20)
'''  Org: [struct Pixa * pixad]
''' </summary>
	Property pixad as Pixa

''' <summary>
''' Brf: pta of initial seed pixels
'''  Loc: SRC/watershed.h (50, 20)
'''  Org: [struct Pta * ptas]
''' </summary>
	Property ptas as Pta

''' <summary>
''' Brf: numa of seed indicators; 0 if completed
'''  Loc: SRC/watershed.h (51, 20)
'''  Org: [struct Numa * nasi]
''' </summary>
	Property nasi as Numa

''' <summary>
''' Brf: numa of initial seed heights
'''  Loc: SRC/watershed.h (52, 20)
'''  Org: [struct Numa * nash]
''' </summary>
	Property nash as Numa

''' <summary>
''' Brf: numa of initial minima heights
'''  Loc: SRC/watershed.h (53, 20)
'''  Org: [struct Numa * namh]
''' </summary>
	Property namh as Numa

''' <summary>
''' Brf: result: numa of watershed levels
'''  Loc: SRC/watershed.h (54, 20)
'''  Org: [struct Numa * nalevels]
''' </summary>
	Property nalevels as Numa

''' <summary>
''' Brf: number of seeds (markers)
'''  Loc: SRC/watershed.h (55, 20)
'''  Org: [l_int32 nseeds]
''' </summary>
	Property nseeds as Integer

''' <summary>
''' Brf: number of minima different from seeds
'''  Loc: SRC/watershed.h (56, 20)
'''  Org: [l_int32 nother]
''' </summary>
	Property nother as Integer

''' <summary>
''' Brf: lut for pixel indices
'''  Loc: SRC/watershed.h (57, 20)
'''  Org: [l_int32 * lut]
''' </summary>
	Property lut as Integer()

''' <summary>
''' Brf: back-links into lut, for updates
'''  Loc: SRC/watershed.h (58, 20)
'''  Org: [struct Numa ** links]
''' </summary>
	Property links as Numa

''' <summary>
''' Brf: size of links array
'''  Loc: SRC/watershed.h (59, 20)
'''  Org: [l_int32 arraysize]
''' </summary>
	Property arraysize as Integer

''' <summary>
''' Brf: set to 1 for debug output
'''  Loc: SRC/watershed.h (60, 20)
'''  Org: [l_int32 debug]
''' </summary>
	Property debug as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_WShed
		Marshal.PtrToStructure (Pointer, Values)
		pixs = New Pix(Values.pixs)
		pixm = New Pix(Values.pixm)
		mindepth = Values.mindepth
		pixlab = New Pix(Values.pixlab)
		pixt = New Pix(Values.pixt)
		ReDim lines8(1)
Marshal.Copy(Values.lines8, lines8, 0, lines8.Length)
		ReDim linem1(1)
Marshal.Copy(Values.linem1, linem1, 0, linem1.Length)
		ReDim linelab32(1)
Marshal.Copy(Values.linelab32, linelab32, 0, linelab32.Length)
		ReDim linet1(1)
Marshal.Copy(Values.linet1, linet1, 0, linet1.Length)
		pixad = New Pixa(Values.pixad)
		ptas = New Pta(Values.ptas)
		nasi = New Numa(Values.nasi)
		nash = New Numa(Values.nash)
		namh = New Numa(Values.namh)
		nalevels = New Numa(Values.nalevels)
		nseeds = Values.nseeds
		nother = Values.nother
		ReDim lut(1)
Marshal.Copy(Values.lut, lut, 0, lut.Length)
		links = New Numa(Values.links)
		arraysize = Values.arraysize
		debug = Values.debug
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_WShed
		Public pixs as IntPTR
		Public pixm as IntPTR
		Public mindepth as Integer
		Public pixlab as IntPTR
		Public pixt as IntPTR
		Public lines8 as IntPTR
		Public linem1 as IntPTR
		Public linelab32 as IntPTR
		Public linet1 as IntPTR
		Public pixad as IntPTR
		Public ptas as IntPTR
		Public nasi as IntPTR
		Public nash as IntPTR
		Public namh as IntPTR
		Public nalevels as IntPTR
		Public nseeds as Integer
		Public nother as Integer
		Public lut as IntPTR
		Public links as IntPTR
		Public arraysize as Integer
		Public debug as Integer
	End Class
End Class


#End Region
#Region "SRC/bilateral.h"
' SRC/bilateral.h (115, 8)
' 
Public Class L_Bilateral
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bilateral

''' <summary>
''' Brf: clone of source pix
'''  Loc: SRC/bilateral.h (117, 21)
'''  Org: [struct Pix * pixs]
''' </summary>
	Property pixs as Pix

''' <summary>
''' Brf: downscaled pix with mirrored border
'''  Loc: SRC/bilateral.h (118, 21)
'''  Org: [struct Pix * pixsc]
''' </summary>
	Property pixsc as Pix

''' <summary>
''' Brf: 1, 2 or 4x for intermediates
'''  Loc: SRC/bilateral.h (119, 21)
'''  Org: [l_int32 reduction]
''' </summary>
	Property reduction as Integer

''' <summary>
''' Brf: stdev of spatial gaussian
'''  Loc: SRC/bilateral.h (120, 21)
'''  Org: [l_float32 spatial_stdev]
''' </summary>
	Property spatial_stdev as Single

''' <summary>
''' Brf: stdev of range gaussian
'''  Loc: SRC/bilateral.h (121, 21)
'''  Org: [l_float32 range_stdev]
''' </summary>
	Property range_stdev as Single

''' <summary>
''' Brf: 1D gaussian spatial kernel
'''  Loc: SRC/bilateral.h (122, 21)
'''  Org: [l_float32 * spatial]
''' </summary>
	Property spatial as Single()

''' <summary>
''' Brf: one-sided gaussian range kernel
'''  Loc: SRC/bilateral.h (123, 21)
'''  Org: [l_float32 * range]
''' </summary>
	Property range as Single()

''' <summary>
''' Brf: min value in 8 bpp pix
'''  Loc: SRC/bilateral.h (124, 21)
'''  Org: [l_int32 minval]
''' </summary>
	Property minval as Integer

''' <summary>
''' Brf: max value in 8 bpp pix
'''  Loc: SRC/bilateral.h (125, 21)
'''  Org: [l_int32 maxval]
''' </summary>
	Property maxval as Integer

''' <summary>
''' Brf: number of intermediate results
'''  Loc: SRC/bilateral.h (126, 21)
'''  Org: [l_int32 ncomps]
''' </summary>
	Property ncomps as Integer

''' <summary>
''' Brf: set of k values (size ncomps)
'''  Loc: SRC/bilateral.h (127, 21)
'''  Org: [l_int32 * nc]
''' </summary>
	Property nc as Integer()

''' <summary>
''' Brf: mapping from intensity to lower k
'''  Loc: SRC/bilateral.h (128, 21)
'''  Org: [l_int32 * kindex]
''' </summary>
	Property kindex as Integer()

''' <summary>
''' Brf: mapping from intensity to fract k
'''  Loc: SRC/bilateral.h (129, 21)
'''  Org: [l_float32 * kfract]
''' </summary>
	Property kfract as Single()

''' <summary>
''' Brf: intermediate result images (PBC)
'''  Loc: SRC/bilateral.h (130, 21)
'''  Org: [struct Pixa * pixac]
''' </summary>
	Property pixac as Pixa

''' <summary>
''' Brf: lineptrs for pixac
'''  Loc: SRC/bilateral.h (131, 21)
'''  Org: [l_uint32 *** lineset]
''' </summary>
	Property lineset as Integer()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Bilateral
		Marshal.PtrToStructure (Pointer, Values)
		pixs = New Pix(Values.pixs)
		pixsc = New Pix(Values.pixsc)
		reduction = Values.reduction
		spatial_stdev = Values.spatial_stdev
		range_stdev = Values.range_stdev
		ReDim spatial(1)
Marshal.Copy(Values.spatial, spatial, 0, spatial.Length)
		ReDim range(1)
Marshal.Copy(Values.range, range, 0, range.Length)
		minval = Values.minval
		maxval = Values.maxval
		ncomps = Values.ncomps
		ReDim nc(1)
Marshal.Copy(Values.nc, nc, 0, nc.Length)
		ReDim kindex(1)
Marshal.Copy(Values.kindex, kindex, 0, kindex.Length)
		ReDim kfract(1)
Marshal.Copy(Values.kfract, kfract, 0, kfract.Length)
		pixac = New Pixa(Values.pixac)
		ReDim lineset(1)
Marshal.Copy(Values.lineset, lineset, 0, lineset.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Bilateral
		Public pixs as IntPTR
		Public pixsc as IntPTR
		Public reduction as Integer
		Public spatial_stdev as Single
		Public range_stdev as Single
		Public spatial as IntPTR
		Public range as IntPTR
		Public minval as Integer
		Public maxval as Integer
		Public ncomps as Integer
		Public nc as IntPTR
		Public kindex as IntPTR
		Public kfract as IntPTR
		Public pixac as IntPTR
		Public lineset as IntPTR
	End Class
End Class


#End Region
#Region "SRC/bmp.h"
' SRC/bmp.h (50, 8)
' 
Public Class BMP_FileHeader
	Property Pointer as IntPTR
	Private Values as Marshal_BMP_FileHeader

''' <summary>
''' Brf: file type; must be "BM"
'''  Loc: SRC/bmp.h (52, 20)
'''  Org: [l_int16 bfType]
''' </summary>
	Property bfType as Short

''' <summary>
''' Brf: length of the file; sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
'''  Loc: SRC/bmp.h (53, 20)
'''  Org: [l_int16 bfSize]
''' </summary>
	Property bfSize as Short

''' <summary>
''' Brf: remainder of the bfSize field
'''  Loc: SRC/bmp.h (58, 20)
'''  Org: [l_int16 bfFill1]
''' </summary>
	Property bfFill1 as Short

''' <summary>
''' Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (59, 20)
'''  Org: [l_int16 bfReserved1]
''' </summary>
	Property bfReserved1 as Short

''' <summary>
''' Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (60, 20)
'''  Org: [l_int16 bfReserved2]
''' </summary>
	Property bfReserved2 as Short

''' <summary>
''' Brf: offset from beginning of file
'''  Loc: SRC/bmp.h (61, 20)
'''  Org: [l_int16 bfOffBits]
''' </summary>
	Property bfOffBits as Short

''' <summary>
''' Brf: remainder of the bfOffBits field
'''  Loc: SRC/bmp.h (62, 20)
'''  Org: [l_int16 bfFill2]
''' </summary>
	Property bfFill2 as Short

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_BMP_FileHeader
		Marshal.PtrToStructure (Pointer, Values)
		bfType = Values.bfType
		bfSize = Values.bfSize
		bfFill1 = Values.bfFill1
		bfReserved1 = Values.bfReserved1
		bfReserved2 = Values.bfReserved2
		bfOffBits = Values.bfOffBits
		bfFill2 = Values.bfFill2
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_BMP_FileHeader
		Public bfType as Short
		Public bfSize as Short
		Public bfFill1 as Short
		Public bfReserved1 as Short
		Public bfReserved2 as Short
		Public bfOffBits as Short
		Public bfFill2 as Short
	End Class
End Class


' SRC/bmp.h (75, 8)
' 
Public Class BMP_InfoHeader
	Property Pointer as IntPTR
	Private Values as Marshal_BMP_InfoHeader

''' <summary>
''' Brf: size of the BMP_InfoHeader struct
'''  Loc: SRC/bmp.h (77, 20)
'''  Org: [l_int32 biSize]
''' </summary>
	Property biSize as Integer

''' <summary>
''' Brf: bitmap width in pixels
'''  Loc: SRC/bmp.h (78, 20)
'''  Org: [l_int32 biWidth]
''' </summary>
	Property biWidth as Integer

''' <summary>
''' Brf: bitmap height in pixels
'''  Loc: SRC/bmp.h (79, 20)
'''  Org: [l_int32 biHeight]
''' </summary>
	Property biHeight as Integer

''' <summary>
''' Brf: number of bitmap planes
'''  Loc: SRC/bmp.h (80, 20)
'''  Org: [l_int16 biPlanes]
''' </summary>
	Property biPlanes as Short

''' <summary>
''' Brf: number of bits per pixel
'''  Loc: SRC/bmp.h (81, 20)
'''  Org: [l_int16 biBitCount]
''' </summary>
	Property biBitCount as Short

''' <summary>
''' Brf: compress format (0 == uncompressed)
'''  Loc: SRC/bmp.h (82, 20)
'''  Org: [l_int32 biCompression]
''' </summary>
	Property biCompression as Integer

''' <summary>
''' Brf: size of image in bytes
'''  Loc: SRC/bmp.h (83, 20)
'''  Org: [l_int32 biSizeImage]
''' </summary>
	Property biSizeImage as Integer

''' <summary>
''' Brf: pixels per meter in x direction
'''  Loc: SRC/bmp.h (84, 20)
'''  Org: [l_int32 biXPelsPerMeter]
''' </summary>
	Property biXPelsPerMeter as Integer

''' <summary>
''' Brf: pixels per meter in y direction
'''  Loc: SRC/bmp.h (85, 20)
'''  Org: [l_int32 biYPelsPerMeter]
''' </summary>
	Property biYPelsPerMeter as Integer

''' <summary>
''' Brf: number of colors used
'''  Loc: SRC/bmp.h (86, 20)
'''  Org: [l_int32 biClrUsed]
''' </summary>
	Property biClrUsed as Integer

''' <summary>
''' Brf: number of important colors used
'''  Loc: SRC/bmp.h (87, 20)
'''  Org: [l_int32 biClrImportant]
''' </summary>
	Property biClrImportant as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_BMP_InfoHeader
		Marshal.PtrToStructure (Pointer, Values)
		biSize = Values.biSize
		biWidth = Values.biWidth
		biHeight = Values.biHeight
		biPlanes = Values.biPlanes
		biBitCount = Values.biBitCount
		biCompression = Values.biCompression
		biSizeImage = Values.biSizeImage
		biXPelsPerMeter = Values.biXPelsPerMeter
		biYPelsPerMeter = Values.biYPelsPerMeter
		biClrUsed = Values.biClrUsed
		biClrImportant = Values.biClrImportant
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_BMP_InfoHeader
		Public biSize as Integer
		Public biWidth as Integer
		Public biHeight as Integer
		Public biPlanes as Short
		Public biBitCount as Short
		Public biCompression as Integer
		Public biSizeImage as Integer
		Public biXPelsPerMeter as Integer
		Public biYPelsPerMeter as Integer
		Public biClrUsed as Integer
		Public biClrImportant as Integer
	End Class
End Class


#End Region
#Region "SRC\colorquant1.c"
' SRC\colorquant1.c (158, 8)
' 
Public Class ColorQuantCell
	Property Pointer as IntPTR
	Private Values as Marshal_ColorQuantCell

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (160, 17)
'''  Org: [l_int32 rc]
''' </summary>
	Property rc as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (160, 21)
'''  Org: [l_int32 gc]
''' </summary>
	Property gc as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (160, 25)
'''  Org: [l_int32 bc]
''' </summary>
	Property bc as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (161, 17)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (162, 17)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (163, 17)
'''  Org: [l_int32 nleaves]
''' </summary>
	Property nleaves as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (164, 17)
'''  Org: [l_int32 bleaf]
''' </summary>
	Property bleaf as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_ColorQuantCell
		Marshal.PtrToStructure (Pointer, Values)
		rc = Values.rc
		gc = Values.gc
		bc = Values.bc
		n = Values.n
		index = Values.index
		nleaves = Values.nleaves
		bleaf = Values.bleaf
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_ColorQuantCell
		Public rc as Integer
		Public gc as Integer
		Public bc as Integer
		Public n as Integer
		Public index as Integer
		Public nleaves as Integer
		Public bleaf as Integer
	End Class
End Class


' SRC\colorquant1.c (190, 8)
' 
Public Class OctcubeQuantCell
	Property Pointer as IntPTR
	Private Values as Marshal_OctcubeQuantCell

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (192, 16)
'''  Org: [l_float32 n]
''' </summary>
	Property n as Single

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (193, 16)
'''  Org: [l_int32 octindex]
''' </summary>
	Property octindex as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 16)
'''  Org: [l_int32 rcum]
''' </summary>
	Property rcum as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 22)
'''  Org: [l_int32 gcum]
''' </summary>
	Property gcum as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 28)
'''  Org: [l_int32 bcum]
''' </summary>
	Property bcum as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 16)
'''  Org: [l_int32 rval]
''' </summary>
	Property rval as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 22)
'''  Org: [l_int32 gval]
''' </summary>
	Property gval as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 28)
'''  Org: [l_int32 bval]
''' </summary>
	Property bval as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_OctcubeQuantCell
		Marshal.PtrToStructure (Pointer, Values)
		n = Values.n
		octindex = Values.octindex
		rcum = Values.rcum
		gcum = Values.gcum
		bcum = Values.bcum
		rval = Values.rval
		gval = Values.gval
		bval = Values.bval
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_OctcubeQuantCell
		Public n as Single
		Public octindex as Integer
		Public rcum as Integer
		Public gcum as Integer
		Public bcum as Integer
		Public rval as Integer
		Public gval as Integer
		Public bval as Integer
	End Class
End Class


' SRC\colorquant1.c (206, 8)
' 
Public Class L_OctcubePop
	Property Pointer as IntPTR
	Private Values as Marshal_L_OctcubePop

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (208, 22)
'''  Org: [l_float32 npix]
''' </summary>
	Property npix as Single

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (209, 22)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (210, 22)
'''  Org: [l_int32 rval]
''' </summary>
	Property rval as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (211, 22)
'''  Org: [l_int32 gval]
''' </summary>
	Property gval as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (212, 22)
'''  Org: [l_int32 bval]
''' </summary>
	Property bval as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_OctcubePop
		Marshal.PtrToStructure (Pointer, Values)
		npix = Values.npix
		index = Values.index
		rval = Values.rval
		gval = Values.gval
		bval = Values.bval
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_OctcubePop
		Public npix as Single
		Public index as Integer
		Public rval as Integer
		Public gval as Integer
		Public bval as Integer
	End Class
End Class


#End Region
#Region "SRC\colorquant2.c"
' SRC\colorquant2.c (178, 8)
' 
Public Class L_Box3d
	Property Pointer as IntPTR
	Private Values as Marshal_L_Box3d

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (180, 22)
'''  Org: [l_float32 sortparam]
''' </summary>
	Property sortparam as Single

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (181, 22)
'''  Org: [l_int32 npix]
''' </summary>
	Property npix as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (182, 22)
'''  Org: [l_int32 vol]
''' </summary>
	Property vol as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (183, 22)
'''  Org: [l_int32 r1]
''' </summary>
	Property r1 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (184, 22)
'''  Org: [l_int32 r2]
''' </summary>
	Property r2 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (185, 22)
'''  Org: [l_int32 g1]
''' </summary>
	Property g1 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (186, 22)
'''  Org: [l_int32 g2]
''' </summary>
	Property g2 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (187, 22)
'''  Org: [l_int32 b1]
''' </summary>
	Property b1 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (188, 22)
'''  Org: [l_int32 b2]
''' </summary>
	Property b2 as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Box3d
		Marshal.PtrToStructure (Pointer, Values)
		sortparam = Values.sortparam
		npix = Values.npix
		vol = Values.vol
		r1 = Values.r1
		r2 = Values.r2
		g1 = Values.g1
		g2 = Values.g2
		b1 = Values.b1
		b2 = Values.b2
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Box3d
		Public sortparam as Single
		Public npix as Integer
		Public vol as Integer
		Public r1 as Integer
		Public r2 as Integer
		Public g1 as Integer
		Public g2 as Integer
		Public b1 as Integer
		Public b2 as Integer
	End Class
End Class


#End Region
#Region "SRC\conncomp.c"
' SRC\conncomp.c (99, 8)
' 
Public Class FillSeg
	Property Pointer as IntPTR
	Private Values as Marshal_FillSeg

''' <summary>
''' Brf: left edge of run
'''  Loc: SRC\conncomp.c (101, 16)
'''  Org: [l_int32 xleft]
''' </summary>
	Property xleft as Integer

''' <summary>
''' Brf: right edge of run
'''  Loc: SRC\conncomp.c (102, 16)
'''  Org: [l_int32 xright]
''' </summary>
	Property xright as Integer

''' <summary>
''' Brf: run y
'''  Loc: SRC\conncomp.c (103, 16)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

''' <summary>
''' Brf: parent segment direction: 1 above, -1 below)
'''  Loc: SRC\conncomp.c (104, 16)
'''  Org: [l_int32 dy]
''' </summary>
	Property dy as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_FillSeg
		Marshal.PtrToStructure (Pointer, Values)
		xleft = Values.xleft
		xright = Values.xright
		y = Values.y
		dy = Values.dy
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_FillSeg
		Public xleft as Integer
		Public xright as Integer
		Public y as Integer
		Public dy as Integer
	End Class
End Class


#End Region
#Region "SRC\jbclass.c"
' SRC\jbclass.c (236, 8)
' 
Public Class JbFindTemplatesState
	Property Pointer as IntPTR
	Private Values as Marshal_JbFindTemplatesState

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (238, 22)
'''  Org: [JBCLASSER * classer]
''' </summary>
	Property classer as Object

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (239, 22)
'''  Org: [l_int32 w]
''' </summary>
	Property w as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (240, 22)
'''  Org: [l_int32 h]
''' </summary>
	Property h as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (241, 22)
'''  Org: [l_int32 i]
''' </summary>
	Property i as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (242, 22)
'''  Org: [L_DNA * dna]
''' </summary>
	Property dna as Object

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (243, 22)
'''  Org: [l_int32 n]
''' </summary>
	Property n as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_JbFindTemplatesState
		Marshal.PtrToStructure (Pointer, Values)
		ReDim classer(values.n)
Marshal.Copy(Values.classer, classer, 0, classer.Length)
		w = Values.w
		h = Values.h
		i = Values.i
		ReDim dna(values.n)
Marshal.Copy(Values.dna, dna, 0, dna.Length)
		n = Values.n
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_JbFindTemplatesState
		Public classer as IntPTR
		Public w as Integer
		Public h as Integer
		Public i as Integer
		Public dna as IntPTR
		Public n as Integer
	End Class
End Class


#End Region
#Region "SRC\jpegio.c"
' SRC\jpegio.c (164, 8)
' 
Public Class callback_data
	Property Pointer as IntPTR
	Private Values as Marshal_callback_data

''' <summary>
''' Brf: 
'''  Loc: SRC\jpegio.c (165, 15)
'''  Org: [jmp_buf jmpbuf]
''' </summary>
	Property jmpbuf as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\jpegio.c (166, 15)
'''  Org: [l_uint8 * comment]
''' </summary>
	Property comment as Byte()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_callback_data
		Marshal.PtrToStructure (Pointer, Values)
		jmpbuf = Values.jmpbuf
		ReDim comment(1)
Marshal.Copy(Values.comment, comment, 0, comment.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_callback_data
		Public jmpbuf as Char
		Public comment as IntPTR
	End Class
End Class


#End Region
#Region "SRC\maze.c"
' SRC\maze.c (76, 8)
' 
Public Class MazeElement
	Property Pointer as IntPTR
	Private Values as Marshal_MazeElement

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (77, 16)
'''  Org: [l_float32 distance]
''' </summary>
	Property distance as Single

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (78, 16)
'''  Org: [l_int32 x]
''' </summary>
	Property x as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (79, 16)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (80, 16)
'''  Org: [l_uint32 val]
''' </summary>
	Property val as UInteger

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (81, 16)
'''  Org: [l_int32 dir]
''' </summary>
	Property dir as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_MazeElement
		Marshal.PtrToStructure (Pointer, Values)
		distance = Values.distance
		x = Values.x
		y = Values.y
		val = Values.val
		dir = Values.dir
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_MazeElement
		Public distance as Single
		Public x as Integer
		Public y as Integer
		Public val as UInteger
		Public dir as Integer
	End Class
End Class


#End Region
#Region "SRC\partition.c"
' SRC\partition.c (48, 8)
' 
Public Class PartitionElement
	Property Pointer as IntPTR
	Private Values as Marshal_PartitionElement

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (49, 16)
'''  Org: [l_float32 size]
''' </summary>
	Property size as Single

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (50, 16)
'''  Org: [BOX * box]
''' </summary>
	Property box as Object

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (51, 16)
'''  Org: [BOXA * boxa]
''' </summary>
	Property boxa as Object

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PartitionElement
		Marshal.PtrToStructure (Pointer, Values)
		size = Values.size
		ReDim box(1)
Marshal.Copy(Values.box, box, 0, box.Length)
		ReDim boxa(1)
Marshal.Copy(Values.boxa, boxa, 0, boxa.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PartitionElement
		Public size as Single
		Public box as IntPTR
		Public boxa as IntPTR
	End Class
End Class


#End Region
#Region "SRC\pix1.c"
' SRC\pix1.c (218, 8)
' 
Public Class PixMemoryManager
	Property Pointer as IntPTR
	Private Values as Marshal_PixMemoryManager

''' <summary>
''' Brf: 
'''  Loc: SRC\pix1.c (220, 17)
'''  Org: [alloc_fn allocator]
''' </summary>
	Property allocator as IntPTR

''' <summary>
''' Brf: 
'''  Loc: SRC\pix1.c (221, 17)
'''  Org: [dealloc_fn deallocator]
''' </summary>
	Property deallocator as IntPTR

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixMemoryManager
		Marshal.PtrToStructure (Pointer, Values)
		allocator = Values.allocator
		deallocator = Values.deallocator
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixMemoryManager
		Public allocator as IntPTR
		Public deallocator as IntPTR
	End Class
End Class


#End Region
#Region "SRC\pixalloc.c"
' SRC\pixalloc.c (113, 8)
' 
Public Class PixMemoryStore
	Property Pointer as IntPTR
	Private Values as Marshal_PixMemoryStore

''' <summary>
''' Brf: Holds ptrs to allocated memory
'''  Loc: SRC\pixalloc.c (115, 22)
'''  Org: [struct L_Ptraa * paa]
''' </summary>
	Property paa as L_Ptraa

''' <summary>
''' Brf: Pix smaller than this (in bytes)
'''  Loc: SRC\pixalloc.c (116, 22)
'''  Org: [size_t minsize]
''' </summary>
	Property minsize as UInteger

''' <summary>
''' Brf: Smallest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (118, 22)
'''  Org: [size_t smallest]
''' </summary>
	Property smallest as UInteger

''' <summary>
''' Brf: Larest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (119, 22)
'''  Org: [size_t largest]
''' </summary>
	Property largest as UInteger

''' <summary>
''' Brf: Size of allocated block w/ all chunks
'''  Loc: SRC\pixalloc.c (120, 22)
'''  Org: [size_t nbytes]
''' </summary>
	Property nbytes as UInteger

''' <summary>
''' Brf: Num of power-of-2 sizes pre-alloc'd
'''  Loc: SRC\pixalloc.c (121, 22)
'''  Org: [l_int32 nlevels]
''' </summary>
	Property nlevels as Integer

''' <summary>
''' Brf: Mem sizes at each power-of-2 level
'''  Loc: SRC\pixalloc.c (122, 22)
'''  Org: [size_t * sizes]
''' </summary>
	Property sizes as Byte()

''' <summary>
''' Brf: Number of mem alloc'd at each size
'''  Loc: SRC\pixalloc.c (123, 22)
'''  Org: [l_int32 * allocarray]
''' </summary>
	Property allocarray as Integer()

''' <summary>
''' Brf: ptr to allocated array
'''  Loc: SRC\pixalloc.c (124, 22)
'''  Org: [l_uint32 * baseptr]
''' </summary>
	Property baseptr as Byte()

''' <summary>
''' Brf: ptr just beyond allocated memory
'''  Loc: SRC\pixalloc.c (125, 22)
'''  Org: [l_uint32 * maxptr]
''' </summary>
	Property maxptr as Byte()

''' <summary>
''' Brf: array of ptrs to first chunk in size
'''  Loc: SRC\pixalloc.c (126, 22)
'''  Org: [l_uint32 ** firstptr]
''' </summary>
	Property firstptr as Integer()

''' <summary>
''' Brf: log: total # of pix used (by level)
'''  Loc: SRC\pixalloc.c (127, 22)
'''  Org: [l_int32 * memused]
''' </summary>
	Property memused as Integer()

''' <summary>
''' Brf: log: # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (128, 22)
'''  Org: [l_int32 * meminuse]
''' </summary>
	Property meminuse as Integer()

''' <summary>
''' Brf: log: max # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (129, 22)
'''  Org: [l_int32 * memmax]
''' </summary>
	Property memmax as Integer()

''' <summary>
''' Brf: log: # of pix alloc'd because
'''  Loc: SRC\pixalloc.c (130, 22)
'''  Org: [l_int32 * memempty]
''' </summary>
	Property memempty as Integer()

''' <summary>
''' Brf: log: set to null if no logging
'''  Loc: SRC\pixalloc.c (132, 22)
'''  Org: [char * logfile]
''' </summary>
	Property logfile as String

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_PixMemoryStore
		Marshal.PtrToStructure (Pointer, Values)
		paa = New L_Ptraa(Values.paa)
		minsize = Values.minsize
		smallest = Values.smallest
		largest = Values.largest
		nbytes = Values.nbytes
		nlevels = Values.nlevels
		ReDim sizes(1)
Marshal.Copy(Values.sizes, sizes, 0, sizes.Length)
		ReDim allocarray(1)
Marshal.Copy(Values.allocarray, allocarray, 0, allocarray.Length)
		ReDim baseptr(1)
Marshal.Copy(Values.baseptr, baseptr, 0, baseptr.Length)
		ReDim maxptr(1)
Marshal.Copy(Values.maxptr, maxptr, 0, maxptr.Length)
		ReDim firstptr(1)
Marshal.Copy(Values.firstptr, firstptr, 0, firstptr.Length)
		ReDim memused(1)
Marshal.Copy(Values.memused, memused, 0, memused.Length)
		ReDim meminuse(1)
Marshal.Copy(Values.meminuse, meminuse, 0, meminuse.Length)
		ReDim memmax(1)
Marshal.Copy(Values.memmax, memmax, 0, memmax.Length)
		ReDim memempty(1)
Marshal.Copy(Values.memempty, memempty, 0, memempty.Length)
		logfile = Values.logfile
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixMemoryStore
		Public paa as IntPTR
		Public minsize as UInteger
		Public smallest as UInteger
		Public largest as UInteger
		Public nbytes as UInteger
		Public nlevels as Integer
		Public sizes as IntPTR
		Public allocarray as IntPTR
		Public baseptr as IntPTR
		Public maxptr as IntPTR
		Public firstptr as IntPTR
		Public memused as IntPTR
		Public meminuse as IntPTR
		Public memmax as IntPTR
		Public memempty as IntPTR
		Public logfile as String
	End Class
End Class


#End Region
#Region "SRC\pngio.c"
' SRC\pngio.c (1293, 8)
' 
Public Class MemIOData
	Property Pointer as IntPTR
	Private Values as Marshal_MemIOData

''' <summary>
''' Brf: pointer to this node's I/O content
'''  Loc: SRC\pngio.c (1295, 17)
'''  Org: [char * m_Buffer]
''' </summary>
	Property m_Buffer as String

''' <summary>
''' Brf: number of I/O content bytes read or written
'''  Loc: SRC\pngio.c (1296, 17)
'''  Org: [l_int32 m_Count]
''' </summary>
	Property m_Count as Integer

''' <summary>
''' Brf: allocated size of m_buffer
'''  Loc: SRC\pngio.c (1297, 17)
'''  Org: [l_int32 m_Size]
''' </summary>
	Property m_Size as Integer

''' <summary>
''' Brf: pointer to the next node in the list;
'''  Loc: SRC\pngio.c (1298, 24)
'''  Org: [struct MemIOData * m_Next]
''' </summary>
	Property m_Next as MemIOData

''' <summary>
''' Brf: pointer to the last node in the linked
'''  Loc: SRC\pngio.c (1300, 24)
'''  Org: [struct MemIOData * m_Last]
''' </summary>
	Property m_Last as MemIOData

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_MemIOData
		Marshal.PtrToStructure (Pointer, Values)
		m_Buffer = Values.m_Buffer
		m_Count = Values.m_Count
		m_Size = Values.m_Size
		m_Next = New MemIOData(Values.m_Next)
		m_Last = New MemIOData(Values.m_Last)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_MemIOData
		Public m_Buffer as String
		Public m_Count as Integer
		Public m_Size as Integer
		Public m_Next as IntPTR
		Public m_Last as IntPTR
	End Class
End Class


#End Region
#Region "SRC\seedfill.c"
' SRC\seedfill.c (170, 8)
' 
Public Class L_Pixel
	Property Pointer as IntPTR
	Private Values as Marshal_L_Pixel

''' <summary>
''' Brf: 
'''  Loc: SRC\seedfill.c (172, 16)
'''  Org: [l_int32 x]
''' </summary>
	Property x as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\seedfill.c (173, 16)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Pixel
		Marshal.PtrToStructure (Pointer, Values)
		x = Values.x
		y = Values.y
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Pixel
		Public x as Integer
		Public y as Integer
	End Class
End Class


#End Region
#Region "SRC\sel1.c"
' SRC\sel1.c (152, 8)
' 
Public Class CompParameterMap
	Property Pointer as IntPTR
	Private Values as Marshal_CompParameterMap

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (154, 14)
'''  Org: [l_int32 size]
''' </summary>
	Property size as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (155, 14)
'''  Org: [l_int32 size1]
''' </summary>
	Property size1 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (156, 14)
'''  Org: [l_int32 size2]
''' </summary>
	Property size2 as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (157, 14)
'''  Org: [char [20] selnameh1]
''' </summary>
	Property selnameh1 as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (158, 14)
'''  Org: [char [20] selnameh2]
''' </summary>
	Property selnameh2 as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (159, 14)
'''  Org: [char [20] selnamev1]
''' </summary>
	Property selnamev1 as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (160, 14)
'''  Org: [char [20] selnamev2]
''' </summary>
	Property selnamev2 as Char

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_CompParameterMap
		Marshal.PtrToStructure (Pointer, Values)
		size = Values.size
		size1 = Values.size1
		size2 = Values.size2
		selnameh1 = Values.selnameh1
		selnameh2 = Values.selnameh2
		selnamev1 = Values.selnamev1
		selnamev2 = Values.selnamev2
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_CompParameterMap
		Public size as Integer
		Public size1 as Integer
		Public size2 as Integer
		Public selnameh1 as Char
		Public selnameh2 as Char
		Public selnamev1 as Char
		Public selnamev2 as Char
	End Class
End Class


#End Region
#Region "SRC\stringcode.c"
' SRC\stringcode.c (95, 8)
' 
Public Class L_GenAssoc
	Property Pointer as IntPTR
	Private Values as Marshal_L_GenAssoc

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (97, 14)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (98, 14)
'''  Org: [char [16] type]
''' </summary>
	Property type as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (99, 14)
'''  Org: [char [16] structname]
''' </summary>
	Property structname as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (100, 14)
'''  Org: [char [16] reader]
''' </summary>
	Property reader as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (101, 14)
'''  Org: [char [20] memreader]
''' </summary>
	Property memreader as Char

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_GenAssoc
		Marshal.PtrToStructure (Pointer, Values)
		index = Values.index
		type = Values.type
		structname = Values.structname
		reader = Values.reader
		memreader = Values.memreader
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_GenAssoc
		Public index as Integer
		Public type as Char
		Public structname as Char
		Public reader as Char
		Public memreader as Char
	End Class
End Class


#End Region
#Region "SRC\tiffio.c"
' SRC\tiffio.c (155, 8)
' 
Public Class tiff_transform
	Property Pointer as IntPTR
	Private Values as Marshal_tiff_transform

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (156, 9)
'''  Org: [int vflip]
''' </summary>
	Property vflip as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (157, 9)
'''  Org: [int hflip]
''' </summary>
	Property hflip as Integer

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (158, 9)
'''  Org: [int rotate]
''' </summary>
	Property rotate as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_tiff_transform
		Marshal.PtrToStructure (Pointer, Values)
		vflip = Values.vflip
		hflip = Values.hflip
		rotate = Values.rotate
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_tiff_transform
		Public vflip as Integer
		Public hflip as Integer
		Public rotate as Integer
	End Class
End Class


' SRC\tiffio.c (2174, 8)
' 
Public Class L_Memstream
	Property Pointer as IntPTR
	Private Values as Marshal_L_Memstream

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2176, 16)
'''  Org: [l_uint8 * buffer]
''' </summary>
	Property buffer as Byte()

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2178, 16)
'''  Org: [size_t bufsize]
''' </summary>
	Property bufsize as UInteger

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2180, 16)
'''  Org: [size_t offset]
''' </summary>
	Property offset as UInteger

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2181, 16)
'''  Org: [size_t hw]
''' </summary>
	Property hw as UInteger

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2182, 16)
'''  Org: [l_uint8 ** poutdata]
''' </summary>
	Property poutdata as Byte()

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2183, 16)
'''  Org: [size_t * poutsize]
''' </summary>
	Property poutsize as Byte()

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_Memstream
		Marshal.PtrToStructure (Pointer, Values)
		ReDim buffer(1)
Marshal.Copy(Values.buffer, buffer, 0, buffer.Length)
		bufsize = Values.bufsize
		offset = Values.offset
		hw = Values.hw
		ReDim poutdata(1)
Marshal.Copy(Values.poutdata, poutdata, 0, poutdata.Length)
		ReDim poutsize(1)
Marshal.Copy(Values.poutsize, poutsize, 0, poutsize.Length)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Memstream
		Public buffer as IntPTR
		Public bufsize as UInteger
		Public offset as UInteger
		Public hw as UInteger
		Public poutdata as IntPTR
		Public poutsize as IntPTR
	End Class
End Class


#End Region
#Region "SRC\watershed.c"
' SRC\watershed.c (124, 8)
' 
Public Class L_NewPixel
	Property Pointer as IntPTR
	Private Values as Marshal_L_NewPixel

''' <summary>
''' Brf: x coordinate
'''  Loc: SRC\watershed.c (126, 16)
'''  Org: [l_int32 x]
''' </summary>
	Property x as Integer

''' <summary>
''' Brf: y coordinate
'''  Loc: SRC\watershed.c (127, 16)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_NewPixel
		Marshal.PtrToStructure (Pointer, Values)
		x = Values.x
		y = Values.y
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_NewPixel
		Public x as Integer
		Public y as Integer
	End Class
End Class


' SRC\watershed.c (132, 8)
' 
Public Class L_WSPixel
	Property Pointer as IntPTR
	Private Values as Marshal_L_WSPixel

''' <summary>
''' Brf: pixel value
'''  Loc: SRC\watershed.c (134, 16)
'''  Org: [l_float32 val]
''' </summary>
	Property val as Single

''' <summary>
''' Brf: x coordinate
'''  Loc: SRC\watershed.c (135, 16)
'''  Org: [l_int32 x]
''' </summary>
	Property x as Integer

''' <summary>
''' Brf: y coordinate
'''  Loc: SRC\watershed.c (136, 16)
'''  Org: [l_int32 y]
''' </summary>
	Property y as Integer

''' <summary>
''' Brf: label for set to which pixel belongs
'''  Loc: SRC\watershed.c (137, 16)
'''  Org: [l_int32 index]
''' </summary>
	Property index as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_L_WSPixel
		Marshal.PtrToStructure (Pointer, Values)
		val = Values.val
		x = Values.x
		y = Values.y
		index = Values.index
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_WSPixel
		Public val as Single
		Public x as Integer
		Public y as Integer
		Public index as Integer
	End Class
End Class


#End Region
#Region "SRC\writefile.c"
' SRC\writefile.c (139, 8)
' 
Public Class ExtensionMap
	Property Pointer as IntPTR
	Private Values as Marshal_ExtensionMap

''' <summary>
''' Brf: 
'''  Loc: SRC\writefile.c (141, 14)
'''  Org: [char [8] extension]
''' </summary>
	Property extension as Char

''' <summary>
''' Brf: 
'''  Loc: SRC\writefile.c (142, 14)
'''  Org: [l_int32 format]
''' </summary>
	Property format as Integer

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		Pointer = PTR
If Pointer = IntPtr.Zero Then Exit Sub
Values = New  Marshal_ExtensionMap
		Marshal.PtrToStructure (Pointer, Values)
		extension = Values.extension
		format = Values.format
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_ExtensionMap
		Public extension as Char
		Public format as Integer
	End Class
End Class


#End Region
