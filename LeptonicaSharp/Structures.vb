Imports System.Runtime.InteropServices

#Region "SRC/environ.h"
' SRC/environ.h (308, 8)
' 
Public Class L_WallTimer
	Property Pointer as IntPTR
    Private Values As New Marshal_L_WallTimer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/environ.h (309, 14)
    '''  Org: [l_int32 start_sec]
    ''' </summary>
    Property start_sec As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/environ.h (310, 14)
    '''  Org: [l_int32 start_usec]
    ''' </summary>
    Property start_usec As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/environ.h (311, 14)
    '''  Org: [l_int32 stop_sec]
    ''' </summary>
    Property stop_sec As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/environ.h (312, 14)
    '''  Org: [l_int32 stop_usec]
    ''' </summary>
    Property stop_usec As Integer

    Sub New(PTR As IntPtr)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        start_sec = Values.start_sec
        start_usec = Values.start_usec
        stop_sec = Values.stop_sec
        stop_usec = Values.stop_usec
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_WallTimer
        Public start_sec As Integer
        Public start_usec As Integer
        Public stop_sec As Integer
        Public stop_usec As Integer
    End Class
End Class


#End Region
#Region "SRC/array.h"
' SRC/array.h (59, 8)
' 
Public Class Numa
    Property Pointer As IntPTR
    Private Values As New Marshal_Numa

    ''' <summary>
    ''' Brf: size of allocated number array
    '''  Loc: SRC/array.h (61, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of numbers saved
    '''  Loc: SRC/array.h (62, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/array.h (63, 22)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    Property refcount As Integer

    ''' <summary>
    ''' Brf: x value assigned to array[0]
    '''  Loc: SRC/array.h (64, 22)
    '''  Org: [l_float32 startx]
    ''' </summary>
    Property startx As Single

    ''' <summary>
    ''' Brf: change in x value as i --> i + 1
    '''  Loc: SRC/array.h (65, 22)
    '''  Org: [l_float32 delx]
    ''' </summary>
    Property delx As Single

    ''' <summary>
    ''' Brf: number array
    '''  Loc: SRC/array.h (66, 22)
    '''  Org: [l_float32 * array]
    ''' </summary>
    Property array As Single()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        refcount = Values.refcount
        startx = Values.startx
        delx = Values.delx
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Numa
        Public nalloc As Integer
        Public n As Integer
        Public refcount As Integer
        Public startx As Single
        Public delx As Single
        Public array As IntPTR
    End Class
End Class


' SRC/array.h (71, 8)
' 
Public Class Numaa
    Property Pointer As IntPTR
    Private Values As New Marshal_Numaa

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/array.h (73, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of Numa saved
    '''  Loc: SRC/array.h (74, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: array of Numa
    '''  Loc: SRC/array.h (75, 22)
    '''  Org: [struct Numa ** numa]
    ''' </summary>
    Property numa As Numa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        numa = New Numa(Values.numa)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Numaa
        Public nalloc As Integer
        Public n As Integer
        Public numa As IntPTR
    End Class
End Class


' SRC/array.h (83, 8)
' 
Public Class L_Dna
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Dna

    ''' <summary>
    ''' Brf: size of allocated number array
    '''  Loc: SRC/array.h (85, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of numbers saved
    '''  Loc: SRC/array.h (86, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/array.h (87, 22)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    Property refcount As Integer

    ''' <summary>
    ''' Brf: x value assigned to array[0]
    '''  Loc: SRC/array.h (88, 22)
    '''  Org: [l_float64 startx]
    ''' </summary>
    Property startx As Double

    ''' <summary>
    ''' Brf: change in x value as i --> i + 1
    '''  Loc: SRC/array.h (89, 22)
    '''  Org: [l_float64 delx]
    ''' </summary>
    Property delx As Double

    ''' <summary>
    ''' Brf: number array
    '''  Loc: SRC/array.h (90, 22)
    '''  Org: [l_float64 * array]
    ''' </summary>
    Property array As Double()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        refcount = Values.refcount
        startx = Values.startx
        delx = Values.delx
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Dna
        Public nalloc As Integer
        Public n As Integer
        Public refcount As Integer
        Public startx As Double
        Public delx As Double
        Public array As IntPTR
    End Class
End Class


' SRC/array.h (95, 8)
' 
Public Class L_Dnaa
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Dnaa

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/array.h (97, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of L_Dna saved
    '''  Loc: SRC/array.h (98, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: array of L_Dna
    '''  Loc: SRC/array.h (99, 22)
    '''  Org: [struct L_Dna ** dna]
    ''' </summary>
    Property dna As L_Dna

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        dna = New L_Dna(Values.dna)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Dnaa
        Public nalloc As Integer
        Public n As Integer
        Public dna As IntPTR
    End Class
End Class


' SRC/array.h (104, 8)
' 
Public Class L_DnaHash
    Property Pointer As IntPTR
    Private Values As New Marshal_L_DnaHash

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/array.h (106, 22)
    '''  Org: [l_int32 nbuckets]
    ''' </summary>
    Property nbuckets As Integer

    ''' <summary>
    ''' Brf: initial size of each dna that is made
    '''  Loc: SRC/array.h (107, 22)
    '''  Org: [l_int32 initsize]
    ''' </summary>
    Property initsize As Integer

    ''' <summary>
    ''' Brf: array of L_Dna
    '''  Loc: SRC/array.h (108, 22)
    '''  Org: [struct L_Dna ** dna]
    ''' </summary>
    Property dna As L_Dna

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nbuckets = Values.nbuckets
        initsize = Values.initsize
        dna = New L_Dna(Values.dna)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_DnaHash
        Public nbuckets As Integer
        Public initsize As Integer
        Public dna As IntPTR
    End Class
End Class


' SRC/array.h (116, 8)
' 
Public Class Sarray
    Property Pointer As IntPTR
    Private Values As New Marshal_Sarray

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/array.h (118, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of strings allocated
    '''  Loc: SRC/array.h (119, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/array.h (120, 22)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    Property refcount As Integer

    ''' <summary>
    ''' Brf: string array
    '''  Loc: SRC/array.h (121, 22)
    '''  Org: [char ** array]
    ''' </summary>
    Property array As New List(Of String)

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        refcount = Values.refcount
        Dim Marshal_array(n - 1) As IntPTR
        Marshal.Copy(Values.array, Marshal_array, 0, Marshal_array.Length)
        For Each Marshal_Value In Marshal_array : array.Add(Marshal.PtrToStringAnsi(Marshal_Value)) : Next
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Sarray
        Public nalloc As Integer
        Public n As Integer
        Public refcount As Integer
        Public array As IntPTR
    End Class
End Class


' SRC/array.h (126, 8)
' 
Public Class L_Bytea
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Bytea

    ''' <summary>
    ''' Brf: number of bytes allocated in data array
    '''  Loc: SRC/array.h (128, 22)
    '''  Org: [size_t nalloc]
    ''' </summary>
    Property nalloc As UInteger

    ''' <summary>
    ''' Brf: number of bytes presently used
    '''  Loc: SRC/array.h (129, 22)
    '''  Org: [size_t size]
    ''' </summary>
    Property size As UInteger

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/array.h (130, 22)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    Property refcount As Integer

    ''' <summary>
    ''' Brf: data array
    '''  Loc: SRC/array.h (131, 22)
    '''  Org: [l_uint8 * data]
    ''' </summary>
    Property data As Byte()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        size = Values.size
        refcount = Values.refcount
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Bytea
        Public nalloc As UInteger
        Public size As UInteger
        Public refcount As Integer
        Public data As IntPTR
    End Class
End Class


#End Region
#Region "SRC/bbuffer.h"
' SRC/bbuffer.h (50, 8)
' 
Public Class L_ByteBuffer
    Property Pointer As IntPTR
    Private Values As New Marshal_L_ByteBuffer

    ''' <summary>
    ''' Brf: size of allocated byte array
    '''  Loc: SRC/bbuffer.h (52, 18)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of bytes read into to the array
    '''  Loc: SRC/bbuffer.h (53, 18)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of bytes written from the array
    '''  Loc: SRC/bbuffer.h (54, 18)
    '''  Org: [l_int32 nwritten]
    ''' </summary>
    Property nwritten As Integer

    ''' <summary>
    ''' Brf: byte array
    '''  Loc: SRC/bbuffer.h (55, 18)
    '''  Org: [l_uint8 * array]
    ''' </summary>
    Property array As Byte()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        nwritten = Values.nwritten
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_ByteBuffer
        Public nalloc As Integer
        Public n As Integer
        Public nwritten As Integer
        Public array As IntPTR
    End Class
End Class


#End Region
#Region "SRC/heap.h"
' SRC/heap.h (77, 8)
' 
Public Class L_Heap
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Heap

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/heap.h (79, 18)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of elements stored in the heap
    '''  Loc: SRC/heap.h (80, 18)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: ptr array
    '''  Loc: SRC/heap.h (81, 18)
    '''  Org: [void ** array]
    ''' </summary>
    Property array As Object

    ''' <summary>
    ''' Brf: L_SORT_INCREASING or L_SORT_DECREASING
    '''  Loc: SRC/heap.h (82, 18)
    '''  Org: [l_int32 direction]
    ''' </summary>
    Property direction As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
        direction = Values.direction
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Heap
        Public nalloc As Integer
        Public n As Integer
        Public array As IntPTR
        Public direction As Integer
    End Class
End Class


#End Region
#Region "SRC/list.h"
' SRC/list.h (61, 8)
' 
Public Class DoubleLinkedList
    Property Pointer As IntPTR
    Private Values As New Marshal_DoubleLinkedList

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/list.h (63, 33)
    '''  Org: [struct DoubleLinkedList * prev]
    ''' </summary>
    Property prev As DoubleLinkedList

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/list.h (64, 33)
    '''  Org: [struct DoubleLinkedList * next]
    ''' </summary>
    Property _next_ As DoubleLinkedList

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/list.h (65, 33)
    '''  Org: [void * data]
    ''' </summary>
    Property data As Object

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        prev = New DoubleLinkedList(Values.prev)
        _next_ = New DoubleLinkedList(Values._next_)
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_DoubleLinkedList
        Public prev As IntPTR
        Public _next_ As IntPTR
        Public data As IntPTR
    End Class
End Class


#End Region
#Region "SRC/ptra.h"
' SRC/ptra.h (51, 8)
' 
Public Class L_Ptra
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Ptra

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/ptra.h (53, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: greatest valid index
    '''  Loc: SRC/ptra.h (54, 22)
    '''  Org: [l_int32 imax]
    ''' </summary>
    Property imax As Integer

    ''' <summary>
    ''' Brf: actual number of stored elements
    '''  Loc: SRC/ptra.h (55, 22)
    '''  Org: [l_int32 nactual]
    ''' </summary>
    Property nactual As Integer

    ''' <summary>
    ''' Brf: ptr array
    '''  Loc: SRC/ptra.h (56, 22)
    '''  Org: [void ** array]
    ''' </summary>
    Property array As Object

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        imax = Values.imax
        nactual = Values.nactual
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Ptra
        Public nalloc As Integer
        Public imax As Integer
        Public nactual As Integer
        Public array As IntPTR
    End Class
End Class


' SRC/ptra.h (62, 8)
' 
Public Class L_Ptraa
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Ptraa

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/ptra.h (64, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: array of ptra
    '''  Loc: SRC/ptra.h (65, 22)
    '''  Org: [struct L_Ptra ** ptra]
    ''' </summary>
    Property ptra As L_Ptra

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        ptra = New L_Ptra(Values.ptra)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Ptraa
        Public nalloc As Integer
        Public ptra As IntPTR
    End Class
End Class


#End Region
#Region "SRC/queue.h"
' SRC/queue.h (64, 8)
' 
Public Class L_Queue
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Queue

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/queue.h (66, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: location of head (in ptrs) from the
    '''  Loc: SRC/queue.h (67, 22)
    '''  Org: [l_int32 nhead]
    ''' </summary>
    Property nhead As Integer

    ''' <summary>
    ''' Brf: number of elements stored in the queue
    '''  Loc: SRC/queue.h (69, 22)
    '''  Org: [l_int32 nelem]
    ''' </summary>
    Property nelem As Integer

    ''' <summary>
    ''' Brf: ptr array
    '''  Loc: SRC/queue.h (70, 22)
    '''  Org: [void ** array]
    ''' </summary>
    Property array As Object

    ''' <summary>
    ''' Brf: auxiliary stack
    '''  Loc: SRC/queue.h (71, 22)
    '''  Org: [struct L_Stack * stack]
    ''' </summary>
    Property stack As L_Stack

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        nhead = Values.nhead
        nelem = Values.nelem
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
        stack = New L_Stack(Values.stack)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Queue
        Public nalloc As Integer
        Public nhead As Integer
        Public nelem As Integer
        Public array As IntPTR
        Public stack As IntPTR
    End Class
End Class


#End Region
#Region "SRC/rbtree.h"
' SRC/rbtree.h (61, 7)
' 
Public Class Rb_Type
    Property Pointer As IntPTR
    Private Values As New Marshal_Rb_Type

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (62, 16)
    '''  Org: [l_int64 itype]
    ''' </summary>
    Property itype As Long

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (63, 16)
    '''  Org: [l_uint64 utype]
    ''' </summary>
    Property utype As ULong

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (64, 16)
    '''  Org: [l_float64 ftype]
    ''' </summary>
    Property ftype As Double

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (65, 16)
    '''  Org: [void * ptype]
    ''' </summary>
    Property ptype As Object

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        itype = Values.itype
        utype = Values.utype
        ftype = Values.ftype
        ReDim ptype(100)
        Marshal.Copy(Values.ptype, ptype, 0, ptype.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Rb_Type
        Public itype As Long
        Public utype As ULong
        Public ftype As Double
        Public ptype As IntPTR
    End Class
End Class


' SRC/rbtree.h (69, 8)
' 
Public Class L_Rbtree
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Rbtree

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (70, 28)
    '''  Org: [struct L_Rbtree_Node * root]
    ''' </summary>
    Property root As L_Rbtree_Node

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (71, 28)
    '''  Org: [l_int32 keytype]
    ''' </summary>
    Property keytype As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        root = New L_Rbtree_Node(Values.root)
        keytype = Values.keytype
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Rbtree
        Public root As IntPTR
        Public keytype As Integer
    End Class
End Class


' SRC/rbtree.h (77, 8)
' 
Public Class L_Rbtree_Node
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Rbtree_Node

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (78, 28)
    '''  Org: [union Rb_Type key]
    ''' </summary>
    Property key As Object

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (79, 28)
    '''  Org: [union Rb_Type value]
    ''' </summary>
    Property value As Object

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (80, 28)
    '''  Org: [struct L_Rbtree_Node * left]
    ''' </summary>
    Property left As L_Rbtree_Node

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (81, 28)
    '''  Org: [struct L_Rbtree_Node * right]
    ''' </summary>
    Property right As L_Rbtree_Node

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (82, 28)
    '''  Org: [struct L_Rbtree_Node * parent]
    ''' </summary>
    Property parent As L_Rbtree_Node

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (83, 28)
    '''  Org: [l_int32 color]
    ''' </summary>
    Property color As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        key = Values.key
        value = Values.value
        left = New L_Rbtree_Node(Values.left)
        right = New L_Rbtree_Node(Values.right)
        parent = New L_Rbtree_Node(Values.parent)
        color = Values.color
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Rbtree_Node
        Public key As IntPTR
        Public value As IntPTR
        Public left As IntPTR
        Public right As IntPTR
        Public parent As IntPTR
        Public color As Integer
    End Class
End Class


#End Region
#Region "SRC/stack.h"
' SRC/stack.h (59, 8)
' 
Public Class L_Stack
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Stack

    ''' <summary>
    ''' Brf: size of ptr array
    '''  Loc: SRC/stack.h (61, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of stored elements
    '''  Loc: SRC/stack.h (62, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: ptr array
    '''  Loc: SRC/stack.h (63, 22)
    '''  Org: [void ** array]
    ''' </summary>
    Property array As Object

    ''' <summary>
    ''' Brf: auxiliary stack
    '''  Loc: SRC/stack.h (64, 22)
    '''  Org: [struct L_Stack * auxstack]
    ''' </summary>
    Property auxstack As L_Stack

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        nalloc = Values.nalloc
        n = Values.n
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
        auxstack = New L_Stack(Values.auxstack)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Stack
        Public nalloc As Integer
        Public n As Integer
        Public array As IntPTR
        Public auxstack As IntPTR
    End Class
End Class


#End Region
#Region "SRC/bmf.h"
' SRC/bmf.h (45, 8)
' 
Public Class L_Bmf
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Bmf

    ''' <summary>
    ''' Brf: pixa of bitmaps for 93 characters
    '''  Loc: SRC/bmf.h (47, 19)
    '''  Org: [struct Pixa * pixa]
    ''' </summary>
    Property pixa As Pixa

    ''' <summary>
    ''' Brf: font size (in points at 300 ppi)
    '''  Loc: SRC/bmf.h (48, 19)
    '''  Org: [l_int32 size]
    ''' </summary>
    Property size As Integer

    ''' <summary>
    ''' Brf: directory containing font bitmaps
    '''  Loc: SRC/bmf.h (49, 19)
    '''  Org: [char * directory]
    ''' </summary>
    Property directory As String

    ''' <summary>
    ''' Brf: baseline offset for ascii 33 - 57
    '''  Loc: SRC/bmf.h (50, 19)
    '''  Org: [l_int32 baseline1]
    ''' </summary>
    Property baseline1 As Integer

    ''' <summary>
    ''' Brf: baseline offset for ascii 58 - 91
    '''  Loc: SRC/bmf.h (51, 19)
    '''  Org: [l_int32 baseline2]
    ''' </summary>
    Property baseline2 As Integer

    ''' <summary>
    ''' Brf: baseline offset for ascii 93 - 126
    '''  Loc: SRC/bmf.h (52, 19)
    '''  Org: [l_int32 baseline3]
    ''' </summary>
    Property baseline3 As Integer

    ''' <summary>
    ''' Brf: max height of line of chars
    '''  Loc: SRC/bmf.h (53, 19)
    '''  Org: [l_int32 lineheight]
    ''' </summary>
    Property lineheight As Integer

    ''' <summary>
    ''' Brf: pixel dist between char bitmaps
    '''  Loc: SRC/bmf.h (54, 19)
    '''  Org: [l_int32 kernwidth]
    ''' </summary>
    Property kernwidth As Integer

    ''' <summary>
    ''' Brf: pixel dist between word bitmaps
    '''  Loc: SRC/bmf.h (55, 19)
    '''  Org: [l_int32 spacewidth]
    ''' </summary>
    Property spacewidth As Integer

    ''' <summary>
    ''' Brf: extra vertical space between text lines
    '''  Loc: SRC/bmf.h (56, 19)
    '''  Org: [l_int32 vertlinesep]
    ''' </summary>
    Property vertlinesep As Integer

    ''' <summary>
    ''' Brf: table mapping ascii --> font index
    '''  Loc: SRC/bmf.h (57, 19)
    '''  Org: [l_int32 * fonttab]
    ''' </summary>
    Property fonttab As Integer()

    ''' <summary>
    ''' Brf: table mapping ascii --> baseline offset
    '''  Loc: SRC/bmf.h (58, 19)
    '''  Org: [l_int32 * baselinetab]
    ''' </summary>
    Property baselinetab As Integer()

    ''' <summary>
    ''' Brf: table mapping ascii --> char width
    '''  Loc: SRC/bmf.h (59, 19)
    '''  Org: [l_int32 * widthtab]
    ''' </summary>
    Property widthtab As Integer()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        ReDim fonttab(100)
        Marshal.Copy(Values.fonttab, fonttab, 0, fonttab.Length)
        ReDim baselinetab(100)
        Marshal.Copy(Values.baselinetab, baselinetab, 0, baselinetab.Length)
        ReDim widthtab(100)
        Marshal.Copy(Values.widthtab, widthtab, 0, widthtab.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Bmf
        Public pixa As IntPTR
        Public size As Integer
        Public directory As String
        Public baseline1 As Integer
        Public baseline2 As Integer
        Public baseline3 As Integer
        Public lineheight As Integer
        Public kernwidth As Integer
        Public spacewidth As Integer
        Public vertlinesep As Integer
        Public fonttab As IntPTR
        Public baselinetab As IntPTR
        Public widthtab As IntPTR
    End Class
End Class


#End Region
#Region "SRC/ccbord.h"
' SRC/ccbord.h (91, 8)
' 
Public Class CCBord
    Property Pointer As IntPTR
    Private Values As New Marshal_CCBord

    ''' <summary>
    ''' Brf: component bitmap (min size)
    '''  Loc: SRC/ccbord.h (93, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    Property pix As Pix

    ''' <summary>
    ''' Brf: regions of each closed curve
    '''  Loc: SRC/ccbord.h (94, 26)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    Property boxa As Boxa

    ''' <summary>
    ''' Brf: initial border pixel locations
    '''  Loc: SRC/ccbord.h (95, 26)
    '''  Org: [struct Pta * start]
    ''' </summary>
    Property start As Pta

    ''' <summary>
    ''' Brf: number of handles; start at 1
    '''  Loc: SRC/ccbord.h (96, 26)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    Property refcount As Integer

    ''' <summary>
    ''' Brf: ptaa of chain pixels (local)
    '''  Loc: SRC/ccbord.h (97, 26)
    '''  Org: [struct Ptaa * local]
    ''' </summary>
    Property local As Ptaa

    ''' <summary>
    ''' Brf: ptaa of chain pixels (global)
    '''  Loc: SRC/ccbord.h (98, 26)
    '''  Org: [struct Ptaa * global]
    ''' </summary>
    Property _global_ As Ptaa

    ''' <summary>
    ''' Brf: numaa of chain code (step dir)
    '''  Loc: SRC/ccbord.h (99, 26)
    '''  Org: [struct Numaa * step]
    ''' </summary>
    Property _step_ As Numaa

    ''' <summary>
    ''' Brf: pta of single chain (local)
    '''  Loc: SRC/ccbord.h (100, 26)
    '''  Org: [struct Pta * splocal]
    ''' </summary>
    Property splocal As Pta

    ''' <summary>
    ''' Brf: pta of single chain (global)
    '''  Loc: SRC/ccbord.h (101, 26)
    '''  Org: [struct Pta * spglobal]
    ''' </summary>
    Property spglobal As Pta

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public pix As IntPTR
        Public boxa As IntPTR
        Public start As IntPTR
        Public refcount As Integer
        Public local As IntPTR
        Public _global_ As IntPTR
        Public _step_ As IntPTR
        Public splocal As IntPTR
        Public spglobal As IntPTR
    End Class
End Class


' SRC/ccbord.h (106, 8)
' 
Public Class CCBorda
    Property Pointer As IntPTR
    Private Values As New Marshal_CCBorda

    ''' <summary>
    ''' Brf: input pix (may be null)
    '''  Loc: SRC/ccbord.h (108, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    Property pix As Pix

    ''' <summary>
    ''' Brf: width of pix
    '''  Loc: SRC/ccbord.h (109, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: height of pix
    '''  Loc: SRC/ccbord.h (110, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: number of ccbord in ptr array
    '''  Loc: SRC/ccbord.h (111, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of ccbord ptrs allocated
    '''  Loc: SRC/ccbord.h (112, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: ccb ptr array
    '''  Loc: SRC/ccbord.h (113, 26)
    '''  Org: [struct CCBord ** ccb]
    ''' </summary>
    Property ccb As CCBord

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        pix = New Pix(Values.pix)
        w = Values.w
        h = Values.h
        n = Values.n
        nalloc = Values.nalloc
        ccb = New CCBord(Values.ccb)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_CCBorda
        Public pix As IntPTR
        Public w As Integer
        Public h As Integer
        Public n As Integer
        Public nalloc As Integer
        Public ccb As IntPTR
    End Class
End Class


#End Region
#Region "SRC/dewarp.h"
' SRC/dewarp.h (113, 8)
' 
Public Class L_Dewarpa
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Dewarpa

    ''' <summary>
    ''' Brf: size of dewarp ptr array
    '''  Loc: SRC/dewarp.h (115, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: maximum page number in array
    '''  Loc: SRC/dewarp.h (116, 24)
    '''  Org: [l_int32 maxpage]
    ''' </summary>
    Property maxpage As Integer

    ''' <summary>
    ''' Brf: array of ptrs to page dewarp
    '''  Loc: SRC/dewarp.h (117, 24)
    '''  Org: [struct L_Dewarp ** dewarp]
    ''' </summary>
    Property dewarp As L_Dewarp

    ''' <summary>
    ''' Brf: array of ptrs to cached dewarps
    '''  Loc: SRC/dewarp.h (118, 24)
    '''  Org: [struct L_Dewarp ** dewarpcache]
    ''' </summary>
    Property dewarpcache As L_Dewarp

    ''' <summary>
    ''' Brf: list of page numbers for pages
    '''  Loc: SRC/dewarp.h (119, 24)
    '''  Org: [struct Numa * namodels]
    ''' </summary>
    Property namodels As Numa

    ''' <summary>
    ''' Brf: list of page numbers with either
    '''  Loc: SRC/dewarp.h (121, 24)
    '''  Org: [struct Numa * napages]
    ''' </summary>
    Property napages As Numa

    ''' <summary>
    ''' Brf: reduction factor of input: 1 or 2
    '''  Loc: SRC/dewarp.h (123, 24)
    '''  Org: [l_int32 redfactor]
    ''' </summary>
    Property redfactor As Integer

    ''' <summary>
    ''' Brf: disparity arrays sampling factor
    '''  Loc: SRC/dewarp.h (124, 24)
    '''  Org: [l_int32 sampling]
    ''' </summary>
    Property sampling As Integer

    ''' <summary>
    ''' Brf: min number of long lines required
    '''  Loc: SRC/dewarp.h (125, 24)
    '''  Org: [l_int32 minlines]
    ''' </summary>
    Property minlines As Integer

    ''' <summary>
    ''' Brf: max distance for getting ref page
    '''  Loc: SRC/dewarp.h (126, 24)
    '''  Org: [l_int32 maxdist]
    ''' </summary>
    Property maxdist As Integer

    ''' <summary>
    ''' Brf: maximum abs line curvature,
    '''  Loc: SRC/dewarp.h (127, 24)
    '''  Org: [l_int32 max_linecurv]
    ''' </summary>
    Property max_linecurv As Integer

    ''' <summary>
    ''' Brf: minimum abs diff line
    '''  Loc: SRC/dewarp.h (129, 24)
    '''  Org: [l_int32 min_diff_linecurv]
    ''' </summary>
    Property min_diff_linecurv As Integer

    ''' <summary>
    ''' Brf: maximum abs diff line
    '''  Loc: SRC/dewarp.h (131, 24)
    '''  Org: [l_int32 max_diff_linecurv]
    ''' </summary>
    Property max_diff_linecurv As Integer

    ''' <summary>
    ''' Brf: maximum abs left or right edge
    '''  Loc: SRC/dewarp.h (133, 24)
    '''  Org: [l_int32 max_edgeslope]
    ''' </summary>
    Property max_edgeslope As Integer

    ''' <summary>
    ''' Brf: maximum abs left or right edge
    '''  Loc: SRC/dewarp.h (135, 24)
    '''  Org: [l_int32 max_edgecurv]
    ''' </summary>
    Property max_edgecurv As Integer

    ''' <summary>
    ''' Brf: maximum abs diff left-right
    '''  Loc: SRC/dewarp.h (137, 24)
    '''  Org: [l_int32 max_diff_edgecurv]
    ''' </summary>
    Property max_diff_edgecurv As Integer

    ''' <summary>
    ''' Brf: use both disparity arrays if
    '''  Loc: SRC/dewarp.h (139, 24)
    '''  Org: [l_int32 useboth]
    ''' </summary>
    Property useboth As Integer

    ''' <summary>
    ''' Brf: if there are multiple columns,
    '''  Loc: SRC/dewarp.h (141, 24)
    '''  Org: [l_int32 check_columns]
    ''' </summary>
    Property check_columns As Integer

    ''' <summary>
    ''' Brf: invalid models have been removed
    '''  Loc: SRC/dewarp.h (144, 24)
    '''  Org: [l_int32 modelsready]
    ''' </summary>
    Property modelsready As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public nalloc As Integer
        Public maxpage As Integer
        Public dewarp As IntPTR
        Public dewarpcache As IntPTR
        Public namodels As IntPTR
        Public napages As IntPTR
        Public redfactor As Integer
        Public sampling As Integer
        Public minlines As Integer
        Public maxdist As Integer
        Public max_linecurv As Integer
        Public min_diff_linecurv As Integer
        Public max_diff_linecurv As Integer
        Public max_edgeslope As Integer
        Public max_edgecurv As Integer
        Public max_diff_edgecurv As Integer
        Public useboth As Integer
        Public check_columns As Integer
        Public modelsready As Integer
    End Class
End Class


' SRC/dewarp.h (151, 8)
' 
Public Class L_Dewarp
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Dewarp

    ''' <summary>
    ''' Brf: ptr to parent (not owned)
    '''  Loc: SRC/dewarp.h (153, 24)
    '''  Org: [struct L_Dewarpa * dewa]
    ''' </summary>
    Property dewa As L_Dewarpa

    ''' <summary>
    ''' Brf: source pix, 1 bpp
    '''  Loc: SRC/dewarp.h (154, 24)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    Property pixs As Pix

    ''' <summary>
    ''' Brf: sampled vert disparity array
    '''  Loc: SRC/dewarp.h (155, 24)
    '''  Org: [struct FPix * sampvdispar]
    ''' </summary>
    Property sampvdispar As FPix

    ''' <summary>
    ''' Brf: sampled horiz disparity array
    '''  Loc: SRC/dewarp.h (156, 24)
    '''  Org: [struct FPix * samphdispar]
    ''' </summary>
    Property samphdispar As FPix

    ''' <summary>
    ''' Brf: sampled slope h-disparity array
    '''  Loc: SRC/dewarp.h (157, 24)
    '''  Org: [struct FPix * sampydispar]
    ''' </summary>
    Property sampydispar As FPix

    ''' <summary>
    ''' Brf: full vert disparity array
    '''  Loc: SRC/dewarp.h (158, 24)
    '''  Org: [struct FPix * fullvdispar]
    ''' </summary>
    Property fullvdispar As FPix

    ''' <summary>
    ''' Brf: full horiz disparity array
    '''  Loc: SRC/dewarp.h (159, 24)
    '''  Org: [struct FPix * fullhdispar]
    ''' </summary>
    Property fullhdispar As FPix

    ''' <summary>
    ''' Brf: full slope h-disparity array
    '''  Loc: SRC/dewarp.h (160, 24)
    '''  Org: [struct FPix * fullydispar]
    ''' </summary>
    Property fullydispar As FPix

    ''' <summary>
    ''' Brf: sorted y val of midpoint each line
    '''  Loc: SRC/dewarp.h (161, 24)
    '''  Org: [struct Numa * namidys]
    ''' </summary>
    Property namidys As Numa

    ''' <summary>
    ''' Brf: sorted curvature of each line
    '''  Loc: SRC/dewarp.h (162, 24)
    '''  Org: [struct Numa * nacurves]
    ''' </summary>
    Property nacurves As Numa

    ''' <summary>
    ''' Brf: width of source image
    '''  Loc: SRC/dewarp.h (163, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: height of source image
    '''  Loc: SRC/dewarp.h (164, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: page number; important for reuse
    '''  Loc: SRC/dewarp.h (165, 24)
    '''  Org: [l_int32 pageno]
    ''' </summary>
    Property pageno As Integer

    ''' <summary>
    ''' Brf: sampling factor of disparity arrays
    '''  Loc: SRC/dewarp.h (166, 24)
    '''  Org: [l_int32 sampling]
    ''' </summary>
    Property sampling As Integer

    ''' <summary>
    ''' Brf: reduction factor of pixs: 1 or 2
    '''  Loc: SRC/dewarp.h (167, 24)
    '''  Org: [l_int32 redfactor]
    ''' </summary>
    Property redfactor As Integer

    ''' <summary>
    ''' Brf: min number of long lines required
    '''  Loc: SRC/dewarp.h (168, 24)
    '''  Org: [l_int32 minlines]
    ''' </summary>
    Property minlines As Integer

    ''' <summary>
    ''' Brf: number of long lines found
    '''  Loc: SRC/dewarp.h (169, 24)
    '''  Org: [l_int32 nlines]
    ''' </summary>
    Property nlines As Integer

    ''' <summary>
    ''' Brf: min line curvature in micro-units
    '''  Loc: SRC/dewarp.h (170, 24)
    '''  Org: [l_int32 mincurv]
    ''' </summary>
    Property mincurv As Integer

    ''' <summary>
    ''' Brf: max line curvature in micro-units
    '''  Loc: SRC/dewarp.h (171, 24)
    '''  Org: [l_int32 maxcurv]
    ''' </summary>
    Property maxcurv As Integer

    ''' <summary>
    ''' Brf: left edge slope in milli-units
    '''  Loc: SRC/dewarp.h (172, 24)
    '''  Org: [l_int32 leftslope]
    ''' </summary>
    Property leftslope As Integer

    ''' <summary>
    ''' Brf: right edge slope in milli-units
    '''  Loc: SRC/dewarp.h (173, 24)
    '''  Org: [l_int32 rightslope]
    ''' </summary>
    Property rightslope As Integer

    ''' <summary>
    ''' Brf: left edge curvature in micro-units
    '''  Loc: SRC/dewarp.h (174, 24)
    '''  Org: [l_int32 leftcurv]
    ''' </summary>
    Property leftcurv As Integer

    ''' <summary>
    ''' Brf: right edge curvature in micro-units
    '''  Loc: SRC/dewarp.h (175, 24)
    '''  Org: [l_int32 rightcurv]
    ''' </summary>
    Property rightcurv As Integer

    ''' <summary>
    ''' Brf: number of sampling pts in x-dir
    '''  Loc: SRC/dewarp.h (176, 24)
    '''  Org: [l_int32 nx]
    ''' </summary>
    Property nx As Integer

    ''' <summary>
    ''' Brf: number of sampling pts in y-dir
    '''  Loc: SRC/dewarp.h (177, 24)
    '''  Org: [l_int32 ny]
    ''' </summary>
    Property ny As Integer

    ''' <summary>
    ''' Brf: 0 if normal; 1 if has a refpage
    '''  Loc: SRC/dewarp.h (178, 24)
    '''  Org: [l_int32 hasref]
    ''' </summary>
    Property hasref As Integer

    ''' <summary>
    ''' Brf: page with disparity model to use
    '''  Loc: SRC/dewarp.h (179, 24)
    '''  Org: [l_int32 refpage]
    ''' </summary>
    Property refpage As Integer

    ''' <summary>
    ''' Brf: sets to 1 if vert disparity builds
    '''  Loc: SRC/dewarp.h (180, 24)
    '''  Org: [l_int32 vsuccess]
    ''' </summary>
    Property vsuccess As Integer

    ''' <summary>
    ''' Brf: sets to 1 if horiz disparity builds
    '''  Loc: SRC/dewarp.h (181, 24)
    '''  Org: [l_int32 hsuccess]
    ''' </summary>
    Property hsuccess As Integer

    ''' <summary>
    ''' Brf: sets to 1 if slope disparity builds
    '''  Loc: SRC/dewarp.h (182, 24)
    '''  Org: [l_int32 ysuccess]
    ''' </summary>
    Property ysuccess As Integer

    ''' <summary>
    ''' Brf: sets to 1 if valid vert disparity
    '''  Loc: SRC/dewarp.h (183, 24)
    '''  Org: [l_int32 vvalid]
    ''' </summary>
    Property vvalid As Integer

    ''' <summary>
    ''' Brf: sets to 1 if valid horiz disparity
    '''  Loc: SRC/dewarp.h (184, 24)
    '''  Org: [l_int32 hvalid]
    ''' </summary>
    Property hvalid As Integer

    ''' <summary>
    ''' Brf: if 1, skip horiz disparity
    '''  Loc: SRC/dewarp.h (185, 24)
    '''  Org: [l_int32 skip_horiz]
    ''' </summary>
    Property skip_horiz As Integer

    ''' <summary>
    ''' Brf: set to 1 if debug output requested
    '''  Loc: SRC/dewarp.h (187, 24)
    '''  Org: [l_int32 debug]
    ''' </summary>
    Property debug As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public dewa As IntPTR
        Public pixs As IntPTR
        Public sampvdispar As IntPTR
        Public samphdispar As IntPTR
        Public sampydispar As IntPTR
        Public fullvdispar As IntPTR
        Public fullhdispar As IntPTR
        Public fullydispar As IntPTR
        Public namidys As IntPTR
        Public nacurves As IntPTR
        Public w As Integer
        Public h As Integer
        Public pageno As Integer
        Public sampling As Integer
        Public redfactor As Integer
        Public minlines As Integer
        Public nlines As Integer
        Public mincurv As Integer
        Public maxcurv As Integer
        Public leftslope As Integer
        Public rightslope As Integer
        Public leftcurv As Integer
        Public rightcurv As Integer
        Public nx As Integer
        Public ny As Integer
        Public hasref As Integer
        Public refpage As Integer
        Public vsuccess As Integer
        Public hsuccess As Integer
        Public ysuccess As Integer
        Public vvalid As Integer
        Public hvalid As Integer
        Public skip_horiz As Integer
        Public debug As Integer
    End Class
End Class


#End Region
#Region "SRC/gplot.h"
' SRC/gplot.h (75, 8)
' 
Public Class GPlot
    Property Pointer As IntPTR
    Private Values As New Marshal_GPlot

    ''' <summary>
    ''' Brf: for cmd, data, output
    '''  Loc: SRC/gplot.h (77, 20)
    '''  Org: [char * rootname]
    ''' </summary>
    Property rootname As String

    ''' <summary>
    ''' Brf: command file name
    '''  Loc: SRC/gplot.h (78, 20)
    '''  Org: [char * cmdname]
    ''' </summary>
    Property cmdname As String

    ''' <summary>
    ''' Brf: command file contents
    '''  Loc: SRC/gplot.h (79, 20)
    '''  Org: [struct Sarray * cmddata]
    ''' </summary>
    Property cmddata As Sarray

    ''' <summary>
    ''' Brf: data file names
    '''  Loc: SRC/gplot.h (80, 20)
    '''  Org: [struct Sarray * datanames]
    ''' </summary>
    Property datanames As Sarray

    ''' <summary>
    ''' Brf: plot data (1 string/file)
    '''  Loc: SRC/gplot.h (81, 20)
    '''  Org: [struct Sarray * plotdata]
    ''' </summary>
    Property plotdata As Sarray

    ''' <summary>
    ''' Brf: title for each individual plot
    '''  Loc: SRC/gplot.h (82, 20)
    '''  Org: [struct Sarray * plottitles]
    ''' </summary>
    Property plottitles As Sarray

    ''' <summary>
    ''' Brf: plot style for individual plots
    '''  Loc: SRC/gplot.h (83, 20)
    '''  Org: [struct Numa * plotstyles]
    ''' </summary>
    Property plotstyles As Numa

    ''' <summary>
    ''' Brf: current number of plots
    '''  Loc: SRC/gplot.h (84, 20)
    '''  Org: [l_int32 nplots]
    ''' </summary>
    Property nplots As Integer

    ''' <summary>
    ''' Brf: output file name
    '''  Loc: SRC/gplot.h (85, 20)
    '''  Org: [char * outname]
    ''' </summary>
    Property outname As String

    ''' <summary>
    ''' Brf: GPLOT_OUTPUT values
    '''  Loc: SRC/gplot.h (86, 20)
    '''  Org: [l_int32 outformat]
    ''' </summary>
    Property outformat As Integer

    ''' <summary>
    ''' Brf: GPLOT_SCALING values
    '''  Loc: SRC/gplot.h (87, 20)
    '''  Org: [l_int32 scaling]
    ''' </summary>
    Property scaling As Integer

    ''' <summary>
    ''' Brf: optional
    '''  Loc: SRC/gplot.h (88, 20)
    '''  Org: [char * title]
    ''' </summary>
    Property title As String

    ''' <summary>
    ''' Brf: optional x axis label
    '''  Loc: SRC/gplot.h (89, 20)
    '''  Org: [char * xlabel]
    ''' </summary>
    Property xlabel As String

    ''' <summary>
    ''' Brf: optional y axis label
    '''  Loc: SRC/gplot.h (90, 20)
    '''  Org: [char * ylabel]
    ''' </summary>
    Property ylabel As String

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public rootname As String
        Public cmdname As String
        Public cmddata As IntPTR
        Public datanames As IntPTR
        Public plotdata As IntPTR
        Public plottitles As IntPTR
        Public plotstyles As IntPTR
        Public nplots As Integer
        Public outname As String
        Public outformat As Integer
        Public scaling As Integer
        Public title As String
        Public xlabel As String
        Public ylabel As String
    End Class
End Class


#End Region
#Region "SRC/imageio.h"
' SRC/imageio.h (166, 8)
' 
Public Class L_Compressed_Data
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Compressed_Data

    ''' <summary>
    ''' Brf: encoding type: L_JPEG_ENCODE, etc
    '''  Loc: SRC/imageio.h (168, 24)
    '''  Org: [l_int32 type]
    ''' </summary>
    Property type As Integer

    ''' <summary>
    ''' Brf: gzipped raster data
    '''  Loc: SRC/imageio.h (169, 24)
    '''  Org: [l_uint8 * datacomp]
    ''' </summary>
    Property datacomp As Byte()

    ''' <summary>
    ''' Brf: number of compressed bytes
    '''  Loc: SRC/imageio.h (170, 24)
    '''  Org: [size_t nbytescomp]
    ''' </summary>
    Property nbytescomp As UInteger

    ''' <summary>
    ''' Brf: ascii85-encoded gzipped raster data
    '''  Loc: SRC/imageio.h (171, 24)
    '''  Org: [char * data85]
    ''' </summary>
    Property data85 As String

    ''' <summary>
    ''' Brf: number of ascii85 encoded bytes
    '''  Loc: SRC/imageio.h (172, 24)
    '''  Org: [size_t nbytes85]
    ''' </summary>
    Property nbytes85 As UInteger

    ''' <summary>
    ''' Brf: ascii85-encoded uncompressed cmap
    '''  Loc: SRC/imageio.h (173, 24)
    '''  Org: [char * cmapdata85]
    ''' </summary>
    Property cmapdata85 As String

    ''' <summary>
    ''' Brf: hex pdf array for the cmap
    '''  Loc: SRC/imageio.h (174, 24)
    '''  Org: [char * cmapdatahex]
    ''' </summary>
    Property cmapdatahex As String

    ''' <summary>
    ''' Brf: number of colors in cmap
    '''  Loc: SRC/imageio.h (175, 24)
    '''  Org: [l_int32 ncolors]
    ''' </summary>
    Property ncolors As Integer

    ''' <summary>
    ''' Brf: image width
    '''  Loc: SRC/imageio.h (176, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: image height
    '''  Loc: SRC/imageio.h (177, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: bits/sample; typ. 1, 2, 4 or 8
    '''  Loc: SRC/imageio.h (178, 24)
    '''  Org: [l_int32 bps]
    ''' </summary>
    Property bps As Integer

    ''' <summary>
    ''' Brf: samples/pixel; typ. 1 or 3
    '''  Loc: SRC/imageio.h (179, 24)
    '''  Org: [l_int32 spp]
    ''' </summary>
    Property spp As Integer

    ''' <summary>
    ''' Brf: tiff g4 photometry
    '''  Loc: SRC/imageio.h (180, 24)
    '''  Org: [l_int32 minisblack]
    ''' </summary>
    Property minisblack As Integer

    ''' <summary>
    ''' Brf: flate data has PNG predictors
    '''  Loc: SRC/imageio.h (181, 24)
    '''  Org: [l_int32 predictor]
    ''' </summary>
    Property predictor As Integer

    ''' <summary>
    ''' Brf: number of uncompressed raster bytes
    '''  Loc: SRC/imageio.h (182, 24)
    '''  Org: [size_t nbytes]
    ''' </summary>
    Property nbytes As UInteger

    ''' <summary>
    ''' Brf: resolution (ppi)
    '''  Loc: SRC/imageio.h (183, 24)
    '''  Org: [l_int32 res]
    ''' </summary>
    Property res As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        type = Values.type
        ReDim datacomp(100)
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
        Public type As Integer
        Public datacomp As IntPTR
        Public nbytescomp As UInteger
        Public data85 As String
        Public nbytes85 As UInteger
        Public cmapdata85 As String
        Public cmapdatahex As String
        Public ncolors As Integer
        Public w As Integer
        Public h As Integer
        Public bps As Integer
        Public spp As Integer
        Public minisblack As Integer
        Public predictor As Integer
        Public nbytes As UInteger
        Public res As Integer
    End Class
End Class


' SRC/imageio.h (211, 8)
' 
Public Class L_Pdf_Data
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Pdf_Data

    ''' <summary>
    ''' Brf: optional title for pdf
    '''  Loc: SRC/imageio.h (213, 24)
    '''  Org: [char * title]
    ''' </summary>
    Property title As String

    ''' <summary>
    ''' Brf: number of images
    '''  Loc: SRC/imageio.h (214, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of colormaps
    '''  Loc: SRC/imageio.h (215, 24)
    '''  Org: [l_int32 ncmap]
    ''' </summary>
    Property ncmap As Integer

    ''' <summary>
    ''' Brf: array of compressed image data
    '''  Loc: SRC/imageio.h (216, 24)
    '''  Org: [struct L_Ptra * cida]
    ''' </summary>
    Property cida As L_Ptra

    ''' <summary>
    ''' Brf: %PDF-1.2 id string
    '''  Loc: SRC/imageio.h (217, 24)
    '''  Org: [char * id]
    ''' </summary>
    Property id As String

    ''' <summary>
    ''' Brf: catalog string
    '''  Loc: SRC/imageio.h (218, 24)
    '''  Org: [char * obj1]
    ''' </summary>
    Property obj1 As String

    ''' <summary>
    ''' Brf: metadata string
    '''  Loc: SRC/imageio.h (219, 24)
    '''  Org: [char * obj2]
    ''' </summary>
    Property obj2 As String

    ''' <summary>
    ''' Brf: pages string
    '''  Loc: SRC/imageio.h (220, 24)
    '''  Org: [char * obj3]
    ''' </summary>
    Property obj3 As String

    ''' <summary>
    ''' Brf: page string (variable data)
    '''  Loc: SRC/imageio.h (221, 24)
    '''  Org: [char * obj4]
    ''' </summary>
    Property obj4 As String

    ''' <summary>
    ''' Brf: content string (variable data)
    '''  Loc: SRC/imageio.h (222, 24)
    '''  Org: [char * obj5]
    ''' </summary>
    Property obj5 As String

    ''' <summary>
    ''' Brf: post-binary-stream string
    '''  Loc: SRC/imageio.h (223, 24)
    '''  Org: [char * poststream]
    ''' </summary>
    Property poststream As String

    ''' <summary>
    ''' Brf: trailer string (variable data)
    '''  Loc: SRC/imageio.h (224, 24)
    '''  Org: [char * trailer]
    ''' </summary>
    Property trailer As String

    ''' <summary>
    ''' Brf: store (xpt, ypt) array
    '''  Loc: SRC/imageio.h (225, 24)
    '''  Org: [struct Pta * xy]
    ''' </summary>
    Property xy As Pta

    ''' <summary>
    ''' Brf: store (wpt, hpt) array
    '''  Loc: SRC/imageio.h (226, 24)
    '''  Org: [struct Pta * wh]
    ''' </summary>
    Property wh As Pta

    ''' <summary>
    ''' Brf: bounding region for all images
    '''  Loc: SRC/imageio.h (227, 24)
    '''  Org: [struct Box * mediabox]
    ''' </summary>
    Property mediabox As Box

    ''' <summary>
    ''' Brf: pre-binary-stream xobject strings
    '''  Loc: SRC/imageio.h (228, 24)
    '''  Org: [struct Sarray * saprex]
    ''' </summary>
    Property saprex As Sarray

    ''' <summary>
    ''' Brf: colormap pdf object strings
    '''  Loc: SRC/imageio.h (229, 24)
    '''  Org: [struct Sarray * sacmap]
    ''' </summary>
    Property sacmap As Sarray

    ''' <summary>
    ''' Brf: sizes of each pdf string object
    '''  Loc: SRC/imageio.h (230, 24)
    '''  Org: [struct L_Dna * objsize]
    ''' </summary>
    Property objsize As L_Dna

    ''' <summary>
    ''' Brf: location of each pdf string object
    '''  Loc: SRC/imageio.h (231, 24)
    '''  Org: [struct L_Dna * objloc]
    ''' </summary>
    Property objloc As L_Dna

    ''' <summary>
    ''' Brf: location of xref
    '''  Loc: SRC/imageio.h (232, 24)
    '''  Org: [l_int32 xrefloc]
    ''' </summary>
    Property xrefloc As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public title As String
        Public n As Integer
        Public ncmap As Integer
        Public cida As IntPTR
        Public id As String
        Public obj1 As String
        Public obj2 As String
        Public obj3 As String
        Public obj4 As String
        Public obj5 As String
        Public poststream As String
        Public trailer As String
        Public xy As IntPTR
        Public wh As IntPTR
        Public mediabox As IntPTR
        Public saprex As IntPTR
        Public sacmap As IntPTR
        Public objsize As IntPTR
        Public objloc As IntPTR
        Public xrefloc As Integer
    End Class
End Class


#End Region
#Region "SRC/jbclass.h"
' SRC/jbclass.h (47, 8)
' 
Public Class JbClasser
    Property Pointer As IntPTR
    Private Values As New Marshal_JbClasser

    ''' <summary>
    ''' Brf: input page image file names
    '''  Loc: SRC/jbclass.h (49, 22)
    '''  Org: [struct Sarray * safiles]
    ''' </summary>
    Property safiles As Sarray

    ''' <summary>
    ''' Brf: JB_RANKHAUS, JB_CORRELATION
    '''  Loc: SRC/jbclass.h (50, 22)
    '''  Org: [l_int32 method]
    ''' </summary>
    Property method As Integer

    ''' <summary>
    ''' Brf: JB_CONN_COMPS, JB_CHARACTERS or
    '''  Loc: SRC/jbclass.h (51, 22)
    '''  Org: [l_int32 components]
    ''' </summary>
    Property components As Integer

    ''' <summary>
    ''' Brf: max component width allowed
    '''  Loc: SRC/jbclass.h (53, 22)
    '''  Org: [l_int32 maxwidth]
    ''' </summary>
    Property maxwidth As Integer

    ''' <summary>
    ''' Brf: max component height allowed
    '''  Loc: SRC/jbclass.h (54, 22)
    '''  Org: [l_int32 maxheight]
    ''' </summary>
    Property maxheight As Integer

    ''' <summary>
    ''' Brf: number of pages already processed
    '''  Loc: SRC/jbclass.h (55, 22)
    '''  Org: [l_int32 npages]
    ''' </summary>
    Property npages As Integer

    ''' <summary>
    ''' Brf: number components already processed
    '''  Loc: SRC/jbclass.h (56, 22)
    '''  Org: [l_int32 baseindex]
    ''' </summary>
    Property baseindex As Integer

    ''' <summary>
    ''' Brf: number of components on each page
    '''  Loc: SRC/jbclass.h (58, 22)
    '''  Org: [struct Numa * nacomps]
    ''' </summary>
    Property nacomps As Numa

    ''' <summary>
    ''' Brf: size of square struct elem for haus
    '''  Loc: SRC/jbclass.h (59, 22)
    '''  Org: [l_int32 sizehaus]
    ''' </summary>
    Property sizehaus As Integer

    ''' <summary>
    ''' Brf: rank val of haus match, each way
    '''  Loc: SRC/jbclass.h (60, 22)
    '''  Org: [l_float32 rankhaus]
    ''' </summary>
    Property rankhaus As Single

    ''' <summary>
    ''' Brf: thresh value for correlation score
    '''  Loc: SRC/jbclass.h (61, 22)
    '''  Org: [l_float32 thresh]
    ''' </summary>
    Property thresh As Single

    ''' <summary>
    ''' Brf: corrects thresh value for heaver
    '''  Loc: SRC/jbclass.h (62, 22)
    '''  Org: [l_float32 weightfactor]
    ''' </summary>
    Property weightfactor As Single

    ''' <summary>
    ''' Brf: w * h of each template, without
    '''  Loc: SRC/jbclass.h (64, 22)
    '''  Org: [struct Numa * naarea]
    ''' </summary>
    Property naarea As Numa

    ''' <summary>
    ''' Brf: max width of original src images
    '''  Loc: SRC/jbclass.h (66, 22)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: max height of original src images
    '''  Loc: SRC/jbclass.h (67, 22)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: current number of classes
    '''  Loc: SRC/jbclass.h (68, 22)
    '''  Org: [l_int32 nclass]
    ''' </summary>
    Property nclass As Integer

    ''' <summary>
    ''' Brf: If zero, pixaa isn't filled
    '''  Loc: SRC/jbclass.h (69, 22)
    '''  Org: [l_int32 keep_pixaa]
    ''' </summary>
    Property keep_pixaa As Integer

    ''' <summary>
    ''' Brf: instances for each class; unbordered
    '''  Loc: SRC/jbclass.h (70, 22)
    '''  Org: [struct Pixaa * pixaa]
    ''' </summary>
    Property pixaa As Pixaa

    ''' <summary>
    ''' Brf: templates for each class; bordered
    '''  Loc: SRC/jbclass.h (71, 22)
    '''  Org: [struct Pixa * pixat]
    ''' </summary>
    Property pixat As Pixa

    ''' <summary>
    ''' Brf: templates for each class; bordered
    '''  Loc: SRC/jbclass.h (73, 22)
    '''  Org: [struct Pixa * pixatd]
    ''' </summary>
    Property pixatd As Pixa

    ''' <summary>
    ''' Brf: Hash table to find templates by size
    '''  Loc: SRC/jbclass.h (75, 23)
    '''  Org: [struct L_DnaHash * dahash]
    ''' </summary>
    Property dahash As L_DnaHash

    ''' <summary>
    ''' Brf: fg areas of undilated templates;
    '''  Loc: SRC/jbclass.h (76, 22)
    '''  Org: [struct Numa * nafgt]
    ''' </summary>
    Property nafgt As Numa

    ''' <summary>
    ''' Brf: centroids of all bordered cc
    '''  Loc: SRC/jbclass.h (78, 22)
    '''  Org: [struct Pta * ptac]
    ''' </summary>
    Property ptac As Pta

    ''' <summary>
    ''' Brf: centroids of all bordered template cc
    '''  Loc: SRC/jbclass.h (79, 22)
    '''  Org: [struct Pta * ptact]
    ''' </summary>
    Property ptact As Pta

    ''' <summary>
    ''' Brf: array of class ids for each component
    '''  Loc: SRC/jbclass.h (80, 22)
    '''  Org: [struct Numa * naclass]
    ''' </summary>
    Property naclass As Numa

    ''' <summary>
    ''' Brf: array of page nums for each component
    '''  Loc: SRC/jbclass.h (81, 22)
    '''  Org: [struct Numa * napage]
    ''' </summary>
    Property napage As Numa

    ''' <summary>
    ''' Brf: array of UL corners at which the
    '''  Loc: SRC/jbclass.h (82, 22)
    '''  Org: [struct Pta * ptaul]
    ''' </summary>
    Property ptaul As Pta

    ''' <summary>
    ''' Brf: similar to ptaul, but for LL corners
    '''  Loc: SRC/jbclass.h (85, 22)
    '''  Org: [struct Pta * ptall]
    ''' </summary>
    Property ptall As Pta

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public safiles As IntPTR
        Public method As Integer
        Public components As Integer
        Public maxwidth As Integer
        Public maxheight As Integer
        Public npages As Integer
        Public baseindex As Integer
        Public nacomps As IntPTR
        Public sizehaus As Integer
        Public rankhaus As Single
        Public thresh As Single
        Public weightfactor As Single
        Public naarea As IntPTR
        Public w As Integer
        Public h As Integer
        Public nclass As Integer
        Public keep_pixaa As Integer
        Public pixaa As IntPTR
        Public pixat As IntPTR
        Public pixatd As IntPTR
        Public dahash As IntPTR
        Public nafgt As IntPTR
        Public ptac As IntPTR
        Public ptact As IntPTR
        Public naclass As IntPTR
        Public napage As IntPTR
        Public ptaul As IntPTR
        Public ptall As IntPTR
    End Class
End Class


' SRC/jbclass.h (104, 8)
' 
Public Class JbData
    Property Pointer As IntPTR
    Private Values As New Marshal_JbData

    ''' <summary>
    ''' Brf: template composite for all classes
    '''  Loc: SRC/jbclass.h (106, 22)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    Property pix As Pix

    ''' <summary>
    ''' Brf: number of pages
    '''  Loc: SRC/jbclass.h (107, 22)
    '''  Org: [l_int32 npages]
    ''' </summary>
    Property npages As Integer

    ''' <summary>
    ''' Brf: max width of original page images
    '''  Loc: SRC/jbclass.h (108, 22)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: max height of original page images
    '''  Loc: SRC/jbclass.h (109, 22)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: number of classes
    '''  Loc: SRC/jbclass.h (110, 22)
    '''  Org: [l_int32 nclass]
    ''' </summary>
    Property nclass As Integer

    ''' <summary>
    ''' Brf: lattice width for template composite
    '''  Loc: SRC/jbclass.h (111, 22)
    '''  Org: [l_int32 latticew]
    ''' </summary>
    Property latticew As Integer

    ''' <summary>
    ''' Brf: lattice height for template composite
    '''  Loc: SRC/jbclass.h (112, 22)
    '''  Org: [l_int32 latticeh]
    ''' </summary>
    Property latticeh As Integer

    ''' <summary>
    ''' Brf: array of class ids for each component
    '''  Loc: SRC/jbclass.h (113, 22)
    '''  Org: [struct Numa * naclass]
    ''' </summary>
    Property naclass As Numa

    ''' <summary>
    ''' Brf: array of page nums for each component
    '''  Loc: SRC/jbclass.h (114, 22)
    '''  Org: [struct Numa * napage]
    ''' </summary>
    Property napage As Numa

    ''' <summary>
    ''' Brf: array of UL corners at which the
    '''  Loc: SRC/jbclass.h (115, 22)
    '''  Org: [struct Pta * ptaul]
    ''' </summary>
    Property ptaul As Pta

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public pix As IntPTR
        Public npages As Integer
        Public w As Integer
        Public h As Integer
        Public nclass As Integer
        Public latticew As Integer
        Public latticeh As Integer
        Public naclass As IntPTR
        Public napage As IntPTR
        Public ptaul As IntPTR
    End Class
End Class


#End Region
#Region "SRC/morph.h"
' SRC/morph.h (62, 8)
' 
Public Class Sel
    Property Pointer As IntPTR
    Private Values As New Marshal_Sel

    ''' <summary>
    ''' Brf: sel height
    '''  Loc: SRC/morph.h (64, 19)
    '''  Org: [l_int32 sy]
    ''' </summary>
    Property sy As Integer

    ''' <summary>
    ''' Brf: sel width
    '''  Loc: SRC/morph.h (65, 19)
    '''  Org: [l_int32 sx]
    ''' </summary>
    Property sx As Integer

    ''' <summary>
    ''' Brf: y location of sel origin
    '''  Loc: SRC/morph.h (66, 19)
    '''  Org: [l_int32 cy]
    ''' </summary>
    Property cy As Integer

    ''' <summary>
    ''' Brf: x location of sel origin
    '''  Loc: SRC/morph.h (67, 19)
    '''  Org: [l_int32 cx]
    ''' </summary>
    Property cx As Integer

    ''' <summary>
    ''' Brf: {0,1,2}; data[i][j] in [row][col] order
    '''  Loc: SRC/morph.h (68, 19)
    '''  Org: [l_int32 ** data]
    ''' </summary>
    Property data As Integer()

    ''' <summary>
    ''' Brf: used to find sel by name
    '''  Loc: SRC/morph.h (69, 19)
    '''  Org: [char * name]
    ''' </summary>
    Property name As String

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        sy = Values.sy
        sx = Values.sx
        cy = Values.cy
        cx = Values.cx
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
        name = Values.name
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Sel
        Public sy As Integer
        Public sx As Integer
        Public cy As Integer
        Public cx As Integer
        Public data As IntPTR
        Public name As String
    End Class
End Class


' SRC/morph.h (74, 8)
' 
Public Class Sela
    Property Pointer As IntPTR
    Private Values As New Marshal_Sela

    ''' <summary>
    ''' Brf: number of sel actually stored
    '''  Loc: SRC/morph.h (76, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/morph.h (77, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: sel ptr array
    '''  Loc: SRC/morph.h (78, 22)
    '''  Org: [struct Sel ** sel]
    ''' </summary>
    Property sel As Sel

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        sel = New Sel(Values.sel)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Sela
        Public n As Integer
        Public nalloc As Integer
        Public sel As IntPTR
    End Class
End Class


' SRC/morph.h (89, 8)
' 
Public Class L_Kernel
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Kernel

    ''' <summary>
    ''' Brf: kernel height
    '''  Loc: SRC/morph.h (91, 19)
    '''  Org: [l_int32 sy]
    ''' </summary>
    Property sy As Integer

    ''' <summary>
    ''' Brf: kernel width
    '''  Loc: SRC/morph.h (92, 19)
    '''  Org: [l_int32 sx]
    ''' </summary>
    Property sx As Integer

    ''' <summary>
    ''' Brf: y location of kernel origin
    '''  Loc: SRC/morph.h (93, 19)
    '''  Org: [l_int32 cy]
    ''' </summary>
    Property cy As Integer

    ''' <summary>
    ''' Brf: x location of kernel origin
    '''  Loc: SRC/morph.h (94, 19)
    '''  Org: [l_int32 cx]
    ''' </summary>
    Property cx As Integer

    ''' <summary>
    ''' Brf: data[i][j] in [row][col] order
    '''  Loc: SRC/morph.h (95, 19)
    '''  Org: [l_float32 ** data]
    ''' </summary>
    Property data As Single()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        sy = Values.sy
        sx = Values.sx
        cy = Values.cy
        cx = Values.cx
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Kernel
        Public sy As Integer
        Public sx As Integer
        Public cy As Integer
        Public cx As Integer
        Public data As IntPTR
    End Class
End Class


#End Region
#Region "SRC/pix.h"
' SRC/pix.h (134, 8)
' 
Public Class Pix
    Property Pointer As IntPTR
    Private Values As New Marshal_Pix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (136, 26)
    '''  Org: [l_uint32 w]
    ''' </summary>
    Property w As UInteger

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (137, 26)
    '''  Org: [l_uint32 h]
    ''' </summary>
    Property h As UInteger

    ''' <summary>
    ''' Brf: depth in bits (bpp)
    '''  Loc: SRC/pix.h (138, 26)
    '''  Org: [l_uint32 d]
    ''' </summary>
    Property d As UInteger

    ''' <summary>
    ''' Brf: number of samples per pixel
    '''  Loc: SRC/pix.h (139, 26)
    '''  Org: [l_uint32 spp]
    ''' </summary>
    Property spp As UInteger

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (140, 26)
    '''  Org: [l_uint32 wpl]
    ''' </summary>
    Property wpl As UInteger

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (141, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (142, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    Property xres As Integer

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (144, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    Property yres As Integer

    ''' <summary>
    ''' Brf: input file format, IFF_*
    '''  Loc: SRC/pix.h (146, 26)
    '''  Org: [l_int32 informat]
    ''' </summary>
    Property informat As Integer

    ''' <summary>
    ''' Brf: special instructions for I/O, etc
    '''  Loc: SRC/pix.h (147, 26)
    '''  Org: [l_int32 special]
    ''' </summary>
    Property special As Integer

    ''' <summary>
    ''' Brf: text string associated with pix
    '''  Loc: SRC/pix.h (148, 26)
    '''  Org: [char * text]
    ''' </summary>
    Property text As String

    ''' <summary>
    ''' Brf: colormap (may be null)
    '''  Loc: SRC/pix.h (149, 26)
    '''  Org: [struct PixColormap * colormap]
    ''' </summary>
    Property colormap As PixColormap

    ''' <summary>
    ''' Brf: the image data
    '''  Loc: SRC/pix.h (150, 26)
    '''  Org: [l_uint32 * data]
    ''' </summary>
    Property data As Byte()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Pix
        Public w As UInteger
        Public h As UInteger
        Public d As UInteger
        Public spp As UInteger
        Public wpl As UInteger
        Public refcount As UInteger
        Public xres As Integer
        Public yres As Integer
        Public informat As Integer
        Public special As Integer
        Public text As String
        Public colormap As IntPTR
        Public data As IntPTR
    End Class
End Class


' SRC/pix.h (155, 8)
' 
Public Class PixColormap
    Property Pointer As IntPTR
    Private Values As New Marshal_PixColormap

    ''' <summary>
    ''' Brf: colormap table (array of RGBA_QUAD)
    '''  Loc: SRC/pix.h (157, 22)
    '''  Org: [void * array]
    ''' </summary>
    Property array As Object

    ''' <summary>
    ''' Brf: of pix (1, 2, 4 or 8 bpp)
    '''  Loc: SRC/pix.h (158, 22)
    '''  Org: [l_int32 depth]
    ''' </summary>
    Property depth As Integer

    ''' <summary>
    ''' Brf: number of color entries allocated
    '''  Loc: SRC/pix.h (159, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: number of color entries used
    '''  Loc: SRC/pix.h (160, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        ReDim array(100)
        Marshal.Copy(Values.array, array, 0, array.Length)
        depth = Values.depth
        nalloc = Values.nalloc
        n = Values.n
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PixColormap
        Public array As IntPTR
        Public depth As Integer
        Public nalloc As Integer
        Public n As Integer
    End Class
End Class


' SRC/pix.h (169, 8)
' 
Public Class RGBA_Quad
    Property Pointer As IntPTR
    Private Values As New Marshal_RGBA_Quad

    ''' <summary>
    ''' Brf: blue value
    '''  Loc: SRC/pix.h (171, 17)
    '''  Org: [l_uint8 blue]
    ''' </summary>
    Property blue As Byte

    ''' <summary>
    ''' Brf: green value
    '''  Loc: SRC/pix.h (172, 17)
    '''  Org: [l_uint8 green]
    ''' </summary>
    Property green As Byte

    ''' <summary>
    ''' Brf: red value
    '''  Loc: SRC/pix.h (173, 17)
    '''  Org: [l_uint8 red]
    ''' </summary>
    Property red As Byte

    ''' <summary>
    ''' Brf: alpha value
    '''  Loc: SRC/pix.h (174, 17)
    '''  Org: [l_uint8 alpha]
    ''' </summary>
    Property alpha As Byte

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        blue = Values.blue
        green = Values.green
        red = Values.red
        alpha = Values.alpha
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_RGBA_Quad
        Public blue As Byte
        Public green As Byte
        Public red As Byte
        Public alpha As Byte
    End Class
End Class


' SRC/pix.h (454, 8)
' 
Public Class Pixa
    Property Pointer As IntPTR
    Private Values As New Marshal_Pixa

    ''' <summary>
    ''' Brf: number of Pix in ptr array
    '''  Loc: SRC/pix.h (456, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of Pix ptrs allocated
    '''  Loc: SRC/pix.h (457, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (458, 25)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: the array of ptrs to pix
    '''  Loc: SRC/pix.h (459, 25)
    '''  Org: [struct Pix ** pix]
    ''' </summary>
    Property pix As Pix

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (460, 25)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    Property boxa As Boxa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        refcount = Values.refcount
        pix = New Pix(Values.pix)
        boxa = New Boxa(Values.boxa)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Pixa
        Public n As Integer
        Public nalloc As Integer
        Public refcount As UInteger
        Public pix As IntPTR
        Public boxa As IntPTR
    End Class
End Class


' SRC/pix.h (465, 8)
' 
Public Class Pixaa
    Property Pointer As IntPTR
    Private Values As New Marshal_Pixaa

    ''' <summary>
    ''' Brf: number of Pixa in ptr array
    '''  Loc: SRC/pix.h (467, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of Pixa ptrs allocated
    '''  Loc: SRC/pix.h (468, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: array of ptrs to pixa
    '''  Loc: SRC/pix.h (469, 25)
    '''  Org: [struct Pixa ** pixa]
    ''' </summary>
    Property pixa As Pixa

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (470, 25)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    Property boxa As Boxa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        pixa = New Pixa(Values.pixa)
        boxa = New Boxa(Values.boxa)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Pixaa
        Public n As Integer
        Public nalloc As Integer
        Public pixa As IntPTR
        Public boxa As IntPTR
    End Class
End Class


' SRC/pix.h (480, 8)
' 
Public Class Box
    Property Pointer As IntPTR
    Private Values As New Marshal_Box

    ''' <summary>
    ''' Brf: left coordinate
    '''  Loc: SRC/pix.h (482, 24)
    '''  Org: [l_int32 x]
    ''' </summary>
    Property x As Integer

    ''' <summary>
    ''' Brf: top coordinate
    '''  Loc: SRC/pix.h (483, 24)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    ''' <summary>
    ''' Brf: box width
    '''  Loc: SRC/pix.h (484, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: box height
    '''  Loc: SRC/pix.h (485, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (486, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        x = Values.x
        y = Values.y
        w = Values.w
        h = Values.h
        refcount = Values.refcount
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Box
        Public x As Integer
        Public y As Integer
        Public w As Integer
        Public h As Integer
        Public refcount As UInteger
    End Class
End Class


' SRC/pix.h (492, 8)
' 
Public Class Boxa
    Property Pointer As IntPTR
    Private Values As New Marshal_Boxa

    ''' <summary>
    ''' Brf: number of box in ptr array
    '''  Loc: SRC/pix.h (494, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of box ptrs allocated
    '''  Loc: SRC/pix.h (495, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (496, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: box ptr array
    '''  Loc: SRC/pix.h (497, 24)
    '''  Org: [struct Box ** box]
    ''' </summary>
    Property box As Box

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        refcount = Values.refcount
        box = New Box(Values.box)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Boxa
        Public n As Integer
        Public nalloc As Integer
        Public refcount As UInteger
        Public box As IntPTR
    End Class
End Class


' SRC/pix.h (502, 8)
' 
Public Class Boxaa
    Property Pointer As IntPTR
    Private Values As New Marshal_Boxaa

    ''' <summary>
    ''' Brf: number of boxa in ptr array
    '''  Loc: SRC/pix.h (504, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of boxa ptrs allocated
    '''  Loc: SRC/pix.h (505, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: boxa ptr array
    '''  Loc: SRC/pix.h (506, 24)
    '''  Org: [struct Boxa ** boxa]
    ''' </summary>
    Property boxa As Boxa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        boxa = New Boxa(Values.boxa)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Boxaa
        Public n As Integer
        Public nalloc As Integer
        Public boxa As IntPTR
    End Class
End Class


' SRC/pix.h (517, 8)
' 
Public Class Pta
    Property Pointer As IntPTR
    Private Values As New Marshal_Pta

    ''' <summary>
    ''' Brf: actual number of pts
    '''  Loc: SRC/pix.h (519, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: size of allocated arrays
    '''  Loc: SRC/pix.h (520, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (521, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: arrays of floats
    '''  Loc: SRC/pix.h (522, 24)
    '''  Org: [l_float32 * x]
    ''' </summary>
    Property x As Single()

    ''' <summary>
    ''' Brf: arrays of floats
    '''  Loc: SRC/pix.h (522, 28)
    '''  Org: [l_float32 * y]
    ''' </summary>
    Property y As Single()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        refcount = Values.refcount
        ReDim x(100)
        Marshal.Copy(Values.x, x, 0, x.Length)
        ReDim y(100)
        Marshal.Copy(Values.y, y, 0, y.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Pta
        Public n As Integer
        Public nalloc As Integer
        Public refcount As UInteger
        Public x As IntPTR
        Public y As IntPTR
    End Class
End Class


' SRC/pix.h (532, 8)
' 
Public Class Ptaa
    Property Pointer As IntPTR
    Private Values As New Marshal_Ptaa

    ''' <summary>
    ''' Brf: number of pta in ptr array
    '''  Loc: SRC/pix.h (534, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of pta ptrs allocated
    '''  Loc: SRC/pix.h (535, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: pta ptr array
    '''  Loc: SRC/pix.h (536, 26)
    '''  Org: [struct Pta ** pta]
    ''' </summary>
    Property pta As Pta

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        pta = New Pta(Values.pta)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Ptaa
        Public n As Integer
        Public nalloc As Integer
        Public pta As IntPTR
    End Class
End Class


' SRC/pix.h (546, 8)
' 
Public Class Pixacc
    Property Pointer As IntPTR
    Private Values As New Marshal_Pixacc

    ''' <summary>
    ''' Brf: array width
    '''  Loc: SRC/pix.h (548, 25)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: array height
    '''  Loc: SRC/pix.h (549, 25)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: used to allow negative
    '''  Loc: SRC/pix.h (550, 25)
    '''  Org: [l_int32 offset]
    ''' </summary>
    Property offset As Integer

    ''' <summary>
    ''' Brf: the 32 bit accumulator pix
    '''  Loc: SRC/pix.h (552, 25)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    Property pix As Pix

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        w = Values.w
        h = Values.h
        offset = Values.offset
        pix = New Pix(Values.pix)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Pixacc
        Public w As Integer
        Public h As Integer
        Public offset As Integer
        Public pix As IntPTR
    End Class
End Class


' SRC/pix.h (562, 8)
' 
Public Class PixTiling
    Property Pointer As IntPTR
    Private Values As New Marshal_PixTiling

    ''' <summary>
    ''' Brf: input pix (a clone)
    '''  Loc: SRC/pix.h (564, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    Property pix As Pix

    ''' <summary>
    ''' Brf: number of tiles horizontally
    '''  Loc: SRC/pix.h (565, 26)
    '''  Org: [l_int32 nx]
    ''' </summary>
    Property nx As Integer

    ''' <summary>
    ''' Brf: number of tiles vertically
    '''  Loc: SRC/pix.h (566, 26)
    '''  Org: [l_int32 ny]
    ''' </summary>
    Property ny As Integer

    ''' <summary>
    ''' Brf: tile width
    '''  Loc: SRC/pix.h (567, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: tile height
    '''  Loc: SRC/pix.h (568, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: overlap on left and right
    '''  Loc: SRC/pix.h (569, 26)
    '''  Org: [l_int32 xoverlap]
    ''' </summary>
    Property xoverlap As Integer

    ''' <summary>
    ''' Brf: overlap on top and bottom
    '''  Loc: SRC/pix.h (570, 26)
    '''  Org: [l_int32 yoverlap]
    ''' </summary>
    Property yoverlap As Integer

    ''' <summary>
    ''' Brf: strip for paint; default is TRUE
    '''  Loc: SRC/pix.h (571, 26)
    '''  Org: [l_int32 strip]
    ''' </summary>
    Property strip As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public pix As IntPTR
        Public nx As Integer
        Public ny As Integer
        Public w As Integer
        Public h As Integer
        Public xoverlap As Integer
        Public yoverlap As Integer
        Public strip As Integer
    End Class
End Class


' SRC/pix.h (582, 8)
' 
Public Class FPix
    Property Pointer As IntPTR
    Private Values As New Marshal_FPix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (584, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (585, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (586, 26)
    '''  Org: [l_int32 wpl]
    ''' </summary>
    Property wpl As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (587, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (588, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    Property xres As Integer

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (590, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    Property yres As Integer

    ''' <summary>
    ''' Brf: the float image data
    '''  Loc: SRC/pix.h (592, 26)
    '''  Org: [l_float32 * data]
    ''' </summary>
    Property data As Single()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        w = Values.w
        h = Values.h
        wpl = Values.wpl
        refcount = Values.refcount
        xres = Values.xres
        yres = Values.yres
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_FPix
        Public w As Integer
        Public h As Integer
        Public wpl As Integer
        Public refcount As UInteger
        Public xres As Integer
        Public yres As Integer
        Public data As IntPTR
    End Class
End Class


' SRC/pix.h (597, 8)
' 
Public Class FPixa
    Property Pointer As IntPTR
    Private Values As New Marshal_FPixa

    ''' <summary>
    ''' Brf: number of fpix in ptr array
    '''  Loc: SRC/pix.h (599, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of fpix ptrs allocated
    '''  Loc: SRC/pix.h (600, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (601, 25)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: the array of ptrs to fpix
    '''  Loc: SRC/pix.h (602, 25)
    '''  Org: [struct FPix ** fpix]
    ''' </summary>
    Property fpix As FPix

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        refcount = Values.refcount
        fpix = New FPix(Values.fpix)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_FPixa
        Public n As Integer
        Public nalloc As Integer
        Public refcount As UInteger
        Public fpix As IntPTR
    End Class
End Class


' SRC/pix.h (613, 8)
' 
Public Class DPix
    Property Pointer As IntPTR
    Private Values As New Marshal_DPix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (615, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (616, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (617, 26)
    '''  Org: [l_int32 wpl]
    ''' </summary>
    Property wpl As Integer

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (618, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    Property refcount As UInteger

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (619, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    Property xres As Integer

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (621, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    Property yres As Integer

    ''' <summary>
    ''' Brf: the double image data
    '''  Loc: SRC/pix.h (623, 26)
    '''  Org: [l_float64 * data]
    ''' </summary>
    Property data As Double()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        w = Values.w
        h = Values.h
        wpl = Values.wpl
        refcount = Values.refcount
        xres = Values.xres
        yres = Values.yres
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_DPix
        Public w As Integer
        Public h As Integer
        Public wpl As Integer
        Public refcount As UInteger
        Public xres As Integer
        Public yres As Integer
        Public data As IntPTR
    End Class
End Class


' SRC/pix.h (633, 8)
' 
Public Class PixComp
    Property Pointer As IntPTR
    Private Values As New Marshal_PixComp

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (635, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (636, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: depth in bits
    '''  Loc: SRC/pix.h (637, 26)
    '''  Org: [l_int32 d]
    ''' </summary>
    Property d As Integer

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (638, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    Property xres As Integer

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (640, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    Property yres As Integer

    ''' <summary>
    ''' Brf: compressed format (IFF_TIFF_G4,
    '''  Loc: SRC/pix.h (642, 26)
    '''  Org: [l_int32 comptype]
    ''' </summary>
    Property comptype As Integer

    ''' <summary>
    ''' Brf: text string associated with pix
    '''  Loc: SRC/pix.h (644, 26)
    '''  Org: [char * text]
    ''' </summary>
    Property text As String

    ''' <summary>
    ''' Brf: flag (1 for cmap, 0 otherwise)
    '''  Loc: SRC/pix.h (645, 26)
    '''  Org: [l_int32 cmapflag]
    ''' </summary>
    Property cmapflag As Integer

    ''' <summary>
    ''' Brf: the compressed image data
    '''  Loc: SRC/pix.h (646, 26)
    '''  Org: [l_uint8 * data]
    ''' </summary>
    Property data As Byte()

    ''' <summary>
    ''' Brf: size of the data array
    '''  Loc: SRC/pix.h (647, 26)
    '''  Org: [size_t size]
    ''' </summary>
    Property size As UInteger

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        w = Values.w
        h = Values.h
        d = Values.d
        xres = Values.xres
        yres = Values.yres
        comptype = Values.comptype
        text = Values.text
        cmapflag = Values.cmapflag
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
        size = Values.size
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PixComp
        Public w As Integer
        Public h As Integer
        Public d As Integer
        Public xres As Integer
        Public yres As Integer
        Public comptype As Integer
        Public text As String
        Public cmapflag As Integer
        Public data As IntPTR
        Public size As UInteger
    End Class
End Class


' SRC/pix.h (658, 8)
' 
Public Class PixaComp
    Property Pointer As IntPTR
    Private Values As New Marshal_PixaComp

    ''' <summary>
    ''' Brf: number of PixComp in ptr array
    '''  Loc: SRC/pix.h (660, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: number of PixComp ptrs allocated
    '''  Loc: SRC/pix.h (661, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    Property nalloc As Integer

    ''' <summary>
    ''' Brf: indexing offset into ptr array
    '''  Loc: SRC/pix.h (662, 26)
    '''  Org: [l_int32 offset]
    ''' </summary>
    Property offset As Integer

    ''' <summary>
    ''' Brf: the array of ptrs to PixComp
    '''  Loc: SRC/pix.h (663, 26)
    '''  Org: [struct PixComp ** pixc]
    ''' </summary>
    Property pixc As PixComp

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (664, 26)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    Property boxa As Boxa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        n = Values.n
        nalloc = Values.nalloc
        offset = Values.offset
        pixc = New PixComp(Values.pixc)
        boxa = New Boxa(Values.boxa)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PixaComp
        Public n As Integer
        Public nalloc As Integer
        Public offset As Integer
        Public pixc As IntPTR
        Public boxa As IntPTR
    End Class
End Class


#End Region
#Region "SRC/recog.h"
' SRC/recog.h (116, 8)
' 
Public Class L_Recog
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Recog

    ''' <summary>
    ''' Brf: scale all examples to this width;
    '''  Loc: SRC/recog.h (117, 20)
    '''  Org: [l_int32 scalew]
    ''' </summary>
    Property scalew As Integer

    ''' <summary>
    ''' Brf: scale all examples to this height;
    '''  Loc: SRC/recog.h (119, 20)
    '''  Org: [l_int32 scaleh]
    ''' </summary>
    Property scaleh As Integer

    ''' <summary>
    ''' Brf: use a value > 0 to convert the bitmap
    '''  Loc: SRC/recog.h (121, 20)
    '''  Org: [l_int32 linew]
    ''' </summary>
    Property linew As Integer

    ''' <summary>
    ''' Brf: template use: use either the average
    '''  Loc: SRC/recog.h (123, 20)
    '''  Org: [l_int32 templ_use]
    ''' </summary>
    Property templ_use As Integer

    ''' <summary>
    ''' Brf: initialize container arrays to this
    '''  Loc: SRC/recog.h (126, 20)
    '''  Org: [l_int32 maxarraysize]
    ''' </summary>
    Property maxarraysize As Integer

    ''' <summary>
    ''' Brf: size of character set
    '''  Loc: SRC/recog.h (127, 20)
    '''  Org: [l_int32 setsize]
    ''' </summary>
    Property setsize As Integer

    ''' <summary>
    ''' Brf: for binarizing if depth > 1
    '''  Loc: SRC/recog.h (128, 20)
    '''  Org: [l_int32 threshold]
    ''' </summary>
    Property threshold As Integer

    ''' <summary>
    ''' Brf: vertical jiggle on nominal centroid
    '''  Loc: SRC/recog.h (129, 20)
    '''  Org: [l_int32 maxyshift]
    ''' </summary>
    Property maxyshift As Integer

    ''' <summary>
    ''' Brf: one of L_ARABIC_NUMERALS, etc.
    '''  Loc: SRC/recog.h (131, 20)
    '''  Org: [l_int32 charset_type]
    ''' </summary>
    Property charset_type As Integer

    ''' <summary>
    ''' Brf: expected number of classes in charset
    '''  Loc: SRC/recog.h (132, 20)
    '''  Org: [l_int32 charset_size]
    ''' </summary>
    Property charset_size As Integer

    ''' <summary>
    ''' Brf: min number of samples without padding
    '''  Loc: SRC/recog.h (133, 20)
    '''  Org: [l_int32 min_nopad]
    ''' </summary>
    Property min_nopad As Integer

    ''' <summary>
    ''' Brf: number of training samples
    '''  Loc: SRC/recog.h (134, 20)
    '''  Org: [l_int32 num_samples]
    ''' </summary>
    Property num_samples As Integer

    ''' <summary>
    ''' Brf: min width averaged unscaled templates
    '''  Loc: SRC/recog.h (135, 20)
    '''  Org: [l_int32 minwidth_u]
    ''' </summary>
    Property minwidth_u As Integer

    ''' <summary>
    ''' Brf: max width averaged unscaled templates
    '''  Loc: SRC/recog.h (136, 20)
    '''  Org: [l_int32 maxwidth_u]
    ''' </summary>
    Property maxwidth_u As Integer

    ''' <summary>
    ''' Brf: min height averaged unscaled templates
    '''  Loc: SRC/recog.h (137, 20)
    '''  Org: [l_int32 minheight_u]
    ''' </summary>
    Property minheight_u As Integer

    ''' <summary>
    ''' Brf: max height averaged unscaled templates
    '''  Loc: SRC/recog.h (138, 20)
    '''  Org: [l_int32 maxheight_u]
    ''' </summary>
    Property maxheight_u As Integer

    ''' <summary>
    ''' Brf: min width averaged scaled templates
    '''  Loc: SRC/recog.h (139, 20)
    '''  Org: [l_int32 minwidth]
    ''' </summary>
    Property minwidth As Integer

    ''' <summary>
    ''' Brf: max width averaged scaled templates
    '''  Loc: SRC/recog.h (140, 20)
    '''  Org: [l_int32 maxwidth]
    ''' </summary>
    Property maxwidth As Integer

    ''' <summary>
    ''' Brf: set to 1 when averaged bitmaps are made
    '''  Loc: SRC/recog.h (141, 20)
    '''  Org: [l_int32 ave_done]
    ''' </summary>
    Property ave_done As Integer

    ''' <summary>
    ''' Brf: set to 1 when training is complete or
    '''  Loc: SRC/recog.h (142, 20)
    '''  Org: [l_int32 train_done]
    ''' </summary>
    Property train_done As Integer

    ''' <summary>
    ''' Brf: max width/height ratio to split
    '''  Loc: SRC/recog.h (144, 20)
    '''  Org: [l_float32 max_wh_ratio]
    ''' </summary>
    Property max_wh_ratio As Single

    ''' <summary>
    ''' Brf: max of max/min template height ratio
    '''  Loc: SRC/recog.h (145, 20)
    '''  Org: [l_float32 max_ht_ratio]
    ''' </summary>
    Property max_ht_ratio As Single

    ''' <summary>
    ''' Brf: min component width kept in splitting
    '''  Loc: SRC/recog.h (146, 20)
    '''  Org: [l_int32 min_splitw]
    ''' </summary>
    Property min_splitw As Integer

    ''' <summary>
    ''' Brf: max component height kept in splitting
    '''  Loc: SRC/recog.h (147, 20)
    '''  Org: [l_int32 max_splith]
    ''' </summary>
    Property max_splith As Integer

    ''' <summary>
    ''' Brf: text array for arbitrary char set
    '''  Loc: SRC/recog.h (148, 20)
    '''  Org: [struct Sarray * sa_text]
    ''' </summary>
    Property sa_text As Sarray

    ''' <summary>
    ''' Brf: index-to-char lut for arbitrary charset
    '''  Loc: SRC/recog.h (149, 20)
    '''  Org: [struct L_Dna * dna_tochar]
    ''' </summary>
    Property dna_tochar As L_Dna

    ''' <summary>
    ''' Brf: table for finding centroids
    '''  Loc: SRC/recog.h (150, 20)
    '''  Org: [l_int32 * centtab]
    ''' </summary>
    Property centtab As Integer()

    ''' <summary>
    ''' Brf: table for finding pixel sums
    '''  Loc: SRC/recog.h (151, 20)
    '''  Org: [l_int32 * sumtab]
    ''' </summary>
    Property sumtab As Integer()

    ''' <summary>
    ''' Brf: all unscaled templates for each class
    '''  Loc: SRC/recog.h (152, 20)
    '''  Org: [struct Pixaa * pixaa_u]
    ''' </summary>
    Property pixaa_u As Pixaa

    ''' <summary>
    ''' Brf: centroids of all unscaled templates
    '''  Loc: SRC/recog.h (153, 20)
    '''  Org: [struct Ptaa * ptaa_u]
    ''' </summary>
    Property ptaa_u As Ptaa

    ''' <summary>
    ''' Brf: area of all unscaled templates
    '''  Loc: SRC/recog.h (154, 20)
    '''  Org: [struct Numaa * naasum_u]
    ''' </summary>
    Property naasum_u As Numaa

    ''' <summary>
    ''' Brf: all (scaled) templates for each class
    '''  Loc: SRC/recog.h (155, 20)
    '''  Org: [struct Pixaa * pixaa]
    ''' </summary>
    Property pixaa As Pixaa

    ''' <summary>
    ''' Brf: centroids of all (scaledl) templates
    '''  Loc: SRC/recog.h (156, 20)
    '''  Org: [struct Ptaa * ptaa]
    ''' </summary>
    Property ptaa As Ptaa

    ''' <summary>
    ''' Brf: area of all (scaled) templates
    '''  Loc: SRC/recog.h (157, 20)
    '''  Org: [struct Numaa * naasum]
    ''' </summary>
    Property naasum As Numaa

    ''' <summary>
    ''' Brf: averaged unscaled templates per class
    '''  Loc: SRC/recog.h (158, 20)
    '''  Org: [struct Pixa * pixa_u]
    ''' </summary>
    Property pixa_u As Pixa

    ''' <summary>
    ''' Brf: centroids of unscaled ave. templates
    '''  Loc: SRC/recog.h (159, 20)
    '''  Org: [struct Pta * pta_u]
    ''' </summary>
    Property pta_u As Pta

    ''' <summary>
    ''' Brf: area of unscaled averaged templates
    '''  Loc: SRC/recog.h (160, 20)
    '''  Org: [struct Numa * nasum_u]
    ''' </summary>
    Property nasum_u As Numa

    ''' <summary>
    ''' Brf: averaged (scaled) templates per class
    '''  Loc: SRC/recog.h (161, 20)
    '''  Org: [struct Pixa * pixa]
    ''' </summary>
    Property pixa As Pixa

    ''' <summary>
    ''' Brf: centroids of (scaled) ave. templates
    '''  Loc: SRC/recog.h (162, 20)
    '''  Org: [struct Pta * pta]
    ''' </summary>
    Property pta As Pta

    ''' <summary>
    ''' Brf: area of (scaled) averaged templates
    '''  Loc: SRC/recog.h (163, 20)
    '''  Org: [struct Numa * nasum]
    ''' </summary>
    Property nasum As Numa

    ''' <summary>
    ''' Brf: all input training images
    '''  Loc: SRC/recog.h (164, 20)
    '''  Org: [struct Pixa * pixa_tr]
    ''' </summary>
    Property pixa_tr As Pixa

    ''' <summary>
    ''' Brf: unscaled and scaled averaged bitmaps
    '''  Loc: SRC/recog.h (165, 20)
    '''  Org: [struct Pixa * pixadb_ave]
    ''' </summary>
    Property pixadb_ave As Pixa

    ''' <summary>
    ''' Brf: input images for identifying
    '''  Loc: SRC/recog.h (166, 20)
    '''  Org: [struct Pixa * pixa_id]
    ''' </summary>
    Property pixa_id As Pixa

    ''' <summary>
    ''' Brf: debug: best match of input against ave.
    '''  Loc: SRC/recog.h (167, 20)
    '''  Org: [struct Pix * pixdb_ave]
    ''' </summary>
    Property pixdb_ave As Pix

    ''' <summary>
    ''' Brf: debug: best matches within range
    '''  Loc: SRC/recog.h (168, 20)
    '''  Org: [struct Pix * pixdb_range]
    ''' </summary>
    Property pixdb_range As Pix

    ''' <summary>
    ''' Brf: debug: bootstrap training results
    '''  Loc: SRC/recog.h (169, 20)
    '''  Org: [struct Pixa * pixadb_boot]
    ''' </summary>
    Property pixadb_boot As Pixa

    ''' <summary>
    ''' Brf: debug: splitting results
    '''  Loc: SRC/recog.h (170, 20)
    '''  Org: [struct Pixa * pixadb_split]
    ''' </summary>
    Property pixadb_split As Pixa

    ''' <summary>
    ''' Brf: bmf fonts
    '''  Loc: SRC/recog.h (171, 20)
    '''  Org: [struct L_Bmf * bmf]
    ''' </summary>
    Property bmf As L_Bmf

    ''' <summary>
    ''' Brf: font size of bmf; default is 6 pt
    '''  Loc: SRC/recog.h (172, 20)
    '''  Org: [l_int32 bmf_size]
    ''' </summary>
    Property bmf_size As Integer

    ''' <summary>
    ''' Brf: temp data used for image decoding
    '''  Loc: SRC/recog.h (173, 20)
    '''  Org: [struct L_Rdid * did]
    ''' </summary>
    Property did As L_Rdid

    ''' <summary>
    ''' Brf: temp data used for holding best char
    '''  Loc: SRC/recog.h (174, 20)
    '''  Org: [struct L_Rch * rch]
    ''' </summary>
    Property rch As L_Rch

    ''' <summary>
    ''' Brf: temp data used for array of best chars
    '''  Loc: SRC/recog.h (175, 20)
    '''  Org: [struct L_Rcha * rcha]
    ''' </summary>
    Property rcha As L_Rcha

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        ReDim centtab(100)
        Marshal.Copy(Values.centtab, centtab, 0, centtab.Length)
        ReDim sumtab(100)
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
        Public scalew As Integer
        Public scaleh As Integer
        Public linew As Integer
        Public templ_use As Integer
        Public maxarraysize As Integer
        Public setsize As Integer
        Public threshold As Integer
        Public maxyshift As Integer
        Public charset_type As Integer
        Public charset_size As Integer
        Public min_nopad As Integer
        Public num_samples As Integer
        Public minwidth_u As Integer
        Public maxwidth_u As Integer
        Public minheight_u As Integer
        Public maxheight_u As Integer
        Public minwidth As Integer
        Public maxwidth As Integer
        Public ave_done As Integer
        Public train_done As Integer
        Public max_wh_ratio As Single
        Public max_ht_ratio As Single
        Public min_splitw As Integer
        Public max_splith As Integer
        Public sa_text As IntPTR
        Public dna_tochar As IntPTR
        Public centtab As IntPTR
        Public sumtab As IntPTR
        Public pixaa_u As IntPTR
        Public ptaa_u As IntPTR
        Public naasum_u As IntPTR
        Public pixaa As IntPTR
        Public ptaa As IntPTR
        Public naasum As IntPTR
        Public pixa_u As IntPTR
        Public pta_u As IntPTR
        Public nasum_u As IntPTR
        Public pixa As IntPTR
        Public pta As IntPTR
        Public nasum As IntPTR
        Public pixa_tr As IntPTR
        Public pixadb_ave As IntPTR
        Public pixa_id As IntPTR
        Public pixdb_ave As IntPTR
        Public pixdb_range As IntPTR
        Public pixadb_boot As IntPTR
        Public pixadb_split As IntPTR
        Public bmf As IntPTR
        Public bmf_size As Integer
        Public did As IntPTR
        Public rch As IntPTR
        Public rcha As IntPTR
    End Class
End Class


' SRC/recog.h (182, 8)
' 
Public Class L_Rch
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Rch

    ''' <summary>
    ''' Brf: index of best template
    '''  Loc: SRC/recog.h (183, 20)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    ''' <summary>
    ''' Brf: correlation score of best template
    '''  Loc: SRC/recog.h (184, 20)
    '''  Org: [l_float32 score]
    ''' </summary>
    Property score As Single

    ''' <summary>
    ''' Brf: character string of best template
    '''  Loc: SRC/recog.h (185, 20)
    '''  Org: [char * text]
    ''' </summary>
    Property text As String

    ''' <summary>
    ''' Brf: index of best sample (within the best
    '''  Loc: SRC/recog.h (186, 20)
    '''  Org: [l_int32 sample]
    ''' </summary>
    Property sample As Integer

    ''' <summary>
    ''' Brf: x-location of template (delx + shiftx)
    '''  Loc: SRC/recog.h (188, 20)
    '''  Org: [l_int32 xloc]
    ''' </summary>
    Property xloc As Integer

    ''' <summary>
    ''' Brf: y-location of template (dely + shifty)
    '''  Loc: SRC/recog.h (189, 20)
    '''  Org: [l_int32 yloc]
    ''' </summary>
    Property yloc As Integer

    ''' <summary>
    ''' Brf: width of best template
    '''  Loc: SRC/recog.h (190, 20)
    '''  Org: [l_int32 width]
    ''' </summary>
    Property width As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public index As Integer
        Public score As Single
        Public text As String
        Public sample As Integer
        Public xloc As Integer
        Public yloc As Integer
        Public width As Integer
    End Class
End Class


' SRC/recog.h (197, 8)
' 
Public Class L_Rcha
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Rcha

    ''' <summary>
    ''' Brf: indices of best templates
    '''  Loc: SRC/recog.h (198, 20)
    '''  Org: [struct Numa * naindex]
    ''' </summary>
    Property naindex As Numa

    ''' <summary>
    ''' Brf: correlation scores of best templates
    '''  Loc: SRC/recog.h (199, 20)
    '''  Org: [struct Numa * nascore]
    ''' </summary>
    Property nascore As Numa

    ''' <summary>
    ''' Brf: character strings of best templates
    '''  Loc: SRC/recog.h (200, 20)
    '''  Org: [struct Sarray * satext]
    ''' </summary>
    Property satext As Sarray

    ''' <summary>
    ''' Brf: indices of best samples
    '''  Loc: SRC/recog.h (201, 20)
    '''  Org: [struct Numa * nasample]
    ''' </summary>
    Property nasample As Numa

    ''' <summary>
    ''' Brf: x-locations of templates (delx + shiftx)
    '''  Loc: SRC/recog.h (202, 20)
    '''  Org: [struct Numa * naxloc]
    ''' </summary>
    Property naxloc As Numa

    ''' <summary>
    ''' Brf: y-locations of templates (dely + shifty)
    '''  Loc: SRC/recog.h (203, 20)
    '''  Org: [struct Numa * nayloc]
    ''' </summary>
    Property nayloc As Numa

    ''' <summary>
    ''' Brf: widths of best templates
    '''  Loc: SRC/recog.h (204, 20)
    '''  Org: [struct Numa * nawidth]
    ''' </summary>
    Property nawidth As Numa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public naindex As IntPTR
        Public nascore As IntPTR
        Public satext As IntPTR
        Public nasample As IntPTR
        Public naxloc As IntPTR
        Public nayloc As IntPTR
        Public nawidth As IntPTR
    End Class
End Class


' SRC/recog.h (211, 8)
' 
Public Class L_Rdid
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Rdid

    ''' <summary>
    ''' Brf: clone of pix to be decoded
    '''  Loc: SRC/recog.h (212, 20)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    Property pixs As Pix

    ''' <summary>
    ''' Brf: count array for each averaged template
    '''  Loc: SRC/recog.h (213, 20)
    '''  Org: [l_int32 ** counta]
    ''' </summary>
    Property counta As Integer()

    ''' <summary>
    ''' Brf: best y-shift array per average template
    '''  Loc: SRC/recog.h (214, 20)
    '''  Org: [l_int32 ** delya]
    ''' </summary>
    Property delya As Integer()

    ''' <summary>
    ''' Brf: number of averaged templates
    '''  Loc: SRC/recog.h (215, 20)
    '''  Org: [l_int32 narray]
    ''' </summary>
    Property narray As Integer

    ''' <summary>
    ''' Brf: size of count array (width of pixs)
    '''  Loc: SRC/recog.h (216, 20)
    '''  Org: [l_int32 size]
    ''' </summary>
    Property size As Integer

    ''' <summary>
    ''' Brf: setwidths for each template
    '''  Loc: SRC/recog.h (217, 20)
    '''  Org: [l_int32 * setwidth]
    ''' </summary>
    Property setwidth As Integer()

    ''' <summary>
    ''' Brf: pixel count in pixs by column
    '''  Loc: SRC/recog.h (218, 20)
    '''  Org: [struct Numa * nasum]
    ''' </summary>
    Property nasum As Numa

    ''' <summary>
    ''' Brf: first moment of pixels in pixs by cols
    '''  Loc: SRC/recog.h (219, 20)
    '''  Org: [struct Numa * namoment]
    ''' </summary>
    Property namoment As Numa

    ''' <summary>
    ''' Brf: 1 if full arrays are made; 0 otherwise
    '''  Loc: SRC/recog.h (220, 20)
    '''  Org: [l_int32 fullarrays]
    ''' </summary>
    Property fullarrays As Integer

    ''' <summary>
    ''' Brf: channel coeffs for template fg term
    '''  Loc: SRC/recog.h (221, 20)
    '''  Org: [l_float32 * beta]
    ''' </summary>
    Property beta As Single()

    ''' <summary>
    ''' Brf: channel coeffs for bit-and term
    '''  Loc: SRC/recog.h (222, 20)
    '''  Org: [l_float32 * gamma]
    ''' </summary>
    Property gamma As Single()

    ''' <summary>
    ''' Brf: score on trellis
    '''  Loc: SRC/recog.h (223, 20)
    '''  Org: [l_float32 * trellisscore]
    ''' </summary>
    Property trellisscore As Single()

    ''' <summary>
    ''' Brf: template on trellis (for backtrack)
    '''  Loc: SRC/recog.h (224, 20)
    '''  Org: [l_int32 * trellistempl]
    ''' </summary>
    Property trellistempl As Integer()

    ''' <summary>
    ''' Brf: indices of best path templates
    '''  Loc: SRC/recog.h (225, 20)
    '''  Org: [struct Numa * natempl]
    ''' </summary>
    Property natempl As Numa

    ''' <summary>
    ''' Brf: x locations of best path templates
    '''  Loc: SRC/recog.h (226, 20)
    '''  Org: [struct Numa * naxloc]
    ''' </summary>
    Property naxloc As Numa

    ''' <summary>
    ''' Brf: y locations of best path templates
    '''  Loc: SRC/recog.h (227, 20)
    '''  Org: [struct Numa * nadely]
    ''' </summary>
    Property nadely As Numa

    ''' <summary>
    ''' Brf: widths of best path templates
    '''  Loc: SRC/recog.h (228, 20)
    '''  Org: [struct Numa * nawidth]
    ''' </summary>
    Property nawidth As Numa

    ''' <summary>
    ''' Brf: Viterbi result for splitting input pixs
    '''  Loc: SRC/recog.h (229, 20)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    Property boxa As Boxa

    ''' <summary>
    ''' Brf: correlation scores: best path templates
    '''  Loc: SRC/recog.h (230, 20)
    '''  Org: [struct Numa * nascore]
    ''' </summary>
    Property nascore As Numa

    ''' <summary>
    ''' Brf: indices of best rescored templates
    '''  Loc: SRC/recog.h (231, 20)
    '''  Org: [struct Numa * natempl_r]
    ''' </summary>
    Property natempl_r As Numa

    ''' <summary>
    ''' Brf: samples of best scored templates
    '''  Loc: SRC/recog.h (232, 20)
    '''  Org: [struct Numa * nasample_r]
    ''' </summary>
    Property nasample_r As Numa

    ''' <summary>
    ''' Brf: x locations of best rescoredtemplates
    '''  Loc: SRC/recog.h (233, 20)
    '''  Org: [struct Numa * naxloc_r]
    ''' </summary>
    Property naxloc_r As Numa

    ''' <summary>
    ''' Brf: y locations of best rescoredtemplates
    '''  Loc: SRC/recog.h (234, 20)
    '''  Org: [struct Numa * nadely_r]
    ''' </summary>
    Property nadely_r As Numa

    ''' <summary>
    ''' Brf: widths of best rescoredtemplates
    '''  Loc: SRC/recog.h (235, 20)
    '''  Org: [struct Numa * nawidth_r]
    ''' </summary>
    Property nawidth_r As Numa

    ''' <summary>
    ''' Brf: correlation scores: rescored templates
    '''  Loc: SRC/recog.h (236, 20)
    '''  Org: [struct Numa * nascore_r]
    ''' </summary>
    Property nascore_r As Numa

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        pixs = New Pix(Values.pixs)
        ReDim counta(100)
        Marshal.Copy(Values.counta, counta, 0, counta.Length)
        ReDim delya(100)
        Marshal.Copy(Values.delya, delya, 0, delya.Length)
        narray = Values.narray
        size = Values.size
        ReDim setwidth(100)
        Marshal.Copy(Values.setwidth, setwidth, 0, setwidth.Length)
        nasum = New Numa(Values.nasum)
        namoment = New Numa(Values.namoment)
        fullarrays = Values.fullarrays
        ReDim beta(100)
        Marshal.Copy(Values.beta, beta, 0, beta.Length)
        ReDim gamma(100)
        Marshal.Copy(Values.gamma, gamma, 0, gamma.Length)
        ReDim trellisscore(100)
        Marshal.Copy(Values.trellisscore, trellisscore, 0, trellisscore.Length)
        ReDim trellistempl(100)
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
        Public pixs As IntPTR
        Public counta As IntPTR
        Public delya As IntPTR
        Public narray As Integer
        Public size As Integer
        Public setwidth As IntPTR
        Public nasum As IntPTR
        Public namoment As IntPTR
        Public fullarrays As Integer
        Public beta As IntPTR
        Public gamma As IntPTR
        Public trellisscore As IntPTR
        Public trellistempl As IntPTR
        Public natempl As IntPTR
        Public naxloc As IntPTR
        Public nadely As IntPTR
        Public nawidth As IntPTR
        Public boxa As IntPTR
        Public nascore As IntPTR
        Public natempl_r As IntPTR
        Public nasample_r As IntPTR
        Public naxloc_r As IntPTR
        Public nadely_r As IntPTR
        Public nawidth_r As IntPTR
        Public nascore_r As IntPTR
    End Class
End Class


#End Region
#Region "SRC/regutils.h"
' SRC/regutils.h (117, 8)
' 
Public Class L_RegParams
    Property Pointer As IntPTR
    Private Values As New Marshal_L_RegParams

    ''' <summary>
    ''' Brf: stream to temporary output file for compare mode
    '''  Loc: SRC/regutils.h (119, 14)
    '''  Org: [FILE * fp]
    ''' </summary>
    Property fp As Object

    ''' <summary>
    ''' Brf: name of test, without '_reg'
    '''  Loc: SRC/regutils.h (120, 14)
    '''  Org: [char * testname]
    ''' </summary>
    Property testname As String

    ''' <summary>
    ''' Brf: name of temp file for compare mode output
    '''  Loc: SRC/regutils.h (121, 14)
    '''  Org: [char * tempfile]
    ''' </summary>
    Property tempfile As String

    ''' <summary>
    ''' Brf: generate, compare or display
    '''  Loc: SRC/regutils.h (122, 14)
    '''  Org: [l_int32 mode]
    ''' </summary>
    Property mode As Integer

    ''' <summary>
    ''' Brf: index into saved files for this test; 0-based
    '''  Loc: SRC/regutils.h (123, 14)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    ''' <summary>
    ''' Brf: overall result of the test
    '''  Loc: SRC/regutils.h (124, 14)
    '''  Org: [l_int32 success]
    ''' </summary>
    Property success As Integer

    ''' <summary>
    ''' Brf: 1 if in display mode; 0 otherwise
    '''  Loc: SRC/regutils.h (125, 14)
    '''  Org: [l_int32 display]
    ''' </summary>
    Property display As Integer

    ''' <summary>
    ''' Brf: marks beginning of the reg test
    '''  Loc: SRC/regutils.h (126, 14)
    '''  Org: [L_TIMER tstart]
    ''' </summary>
    Property tstart As IntPTR

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        ReDim fp(100)
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
        Public fp As IntPTR
        Public testname As String
        Public tempfile As String
        Public mode As Integer
        Public index As Integer
        Public success As Integer
        Public display As Integer
        Public tstart As IntPTR
    End Class
End Class


#End Region
#Region "SRC/stringcode.h"
' SRC/stringcode.h (40, 8)
' 
Public Class L_StrCode
    Property Pointer As IntPTR
    Private Values As New Marshal_L_StrCode

    ''' <summary>
    ''' Brf: index for function and output file names
    '''  Loc: SRC/stringcode.h (42, 19)
    '''  Org: [l_int32 fileno]
    ''' </summary>
    Property fileno As Integer

    ''' <summary>
    ''' Brf: index into struct currently being stored
    '''  Loc: SRC/stringcode.h (43, 19)
    '''  Org: [l_int32 ifunc]
    ''' </summary>
    Property ifunc As Integer

    ''' <summary>
    ''' Brf: store case code for extraction
    '''  Loc: SRC/stringcode.h (44, 19)
    '''  Org: [SARRAY * function]
    ''' </summary>
    Property _function_ As Object

    ''' <summary>
    ''' Brf: store base64 encoded data as strings
    '''  Loc: SRC/stringcode.h (45, 19)
    '''  Org: [SARRAY * data]
    ''' </summary>
    Property data As Object

    ''' <summary>
    ''' Brf: store line in description table
    '''  Loc: SRC/stringcode.h (46, 19)
    '''  Org: [SARRAY * descr]
    ''' </summary>
    Property descr As Object

    ''' <summary>
    ''' Brf: number of data strings
    '''  Loc: SRC/stringcode.h (47, 19)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        fileno = Values.fileno
        ifunc = Values.ifunc
        ReDim _function_(100)
        Marshal.Copy(Values._function_, _function_, 0, _function_.Length)
        ReDim data(100)
        Marshal.Copy(Values.data, data, 0, data.Length)
        ReDim descr(100)
        Marshal.Copy(Values.descr, descr, 0, descr.Length)
        n = Values.n
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_StrCode
        Public fileno As Integer
        Public ifunc As Integer
        Public _function_ As IntPTR
        Public data As IntPTR
        Public descr As IntPTR
        Public n As Integer
    End Class
End Class


#End Region
#Region "SRC/sudoku.h"
' SRC/sudoku.h (52, 8)
' 
Public Class L_Sudoku
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Sudoku

    ''' <summary>
    ''' Brf: number of unknowns
    '''  Loc: SRC/sudoku.h (54, 20)
    '''  Org: [l_int32 num]
    ''' </summary>
    Property num As Integer

    ''' <summary>
    ''' Brf: location of unknowns
    '''  Loc: SRC/sudoku.h (55, 20)
    '''  Org: [l_int32 * locs]
    ''' </summary>
    Property locs As Integer()

    ''' <summary>
    ''' Brf: index into %locs of current location
    '''  Loc: SRC/sudoku.h (56, 20)
    '''  Org: [l_int32 current]
    ''' </summary>
    Property current As Integer

    ''' <summary>
    ''' Brf: initial state, with 0 representing
    '''  Loc: SRC/sudoku.h (57, 20)
    '''  Org: [l_int32 * init]
    ''' </summary>
    Property init As Integer()

    ''' <summary>
    ''' Brf: present state, including inits and
    '''  Loc: SRC/sudoku.h (59, 20)
    '''  Org: [l_int32 * state]
    ''' </summary>
    Property state As Integer()

    ''' <summary>
    ''' Brf: shows current number of guesses
    '''  Loc: SRC/sudoku.h (61, 20)
    '''  Org: [l_int32 nguess]
    ''' </summary>
    Property nguess As Integer

    ''' <summary>
    ''' Brf: set to 1 when solved
    '''  Loc: SRC/sudoku.h (62, 20)
    '''  Org: [l_int32 finished]
    ''' </summary>
    Property finished As Integer

    ''' <summary>
    ''' Brf: set to 1 if no solution is possible
    '''  Loc: SRC/sudoku.h (63, 20)
    '''  Org: [l_int32 failure]
    ''' </summary>
    Property failure As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        num = Values.num
        ReDim locs(100)
        Marshal.Copy(Values.locs, locs, 0, locs.Length)
        current = Values.current
        ReDim init(100)
        Marshal.Copy(Values.init, init, 0, init.Length)
        ReDim state(100)
        Marshal.Copy(Values.state, state, 0, state.Length)
        nguess = Values.nguess
        finished = Values.finished
        failure = Values.failure
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Sudoku
        Public num As Integer
        Public locs As IntPTR
        Public current As Integer
        Public init As IntPTR
        Public state As IntPTR
        Public nguess As Integer
        Public finished As Integer
        Public failure As Integer
    End Class
End Class


#End Region
#Region "SRC/watershed.h"
' SRC/watershed.h (38, 8)
' 
Public Class L_WShed
    Property Pointer As IntPTR
    Private Values As New Marshal_L_WShed

    ''' <summary>
    ''' Brf: clone of input 8 bpp pixs
    '''  Loc: SRC/watershed.h (40, 20)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    Property pixs As Pix

    ''' <summary>
    ''' Brf: clone of input 1 bpp seed (marker) pixm
    '''  Loc: SRC/watershed.h (41, 20)
    '''  Org: [struct Pix * pixm]
    ''' </summary>
    Property pixm As Pix

    ''' <summary>
    ''' Brf: minimum depth allowed for a watershed
    '''  Loc: SRC/watershed.h (42, 20)
    '''  Org: [l_int32 mindepth]
    ''' </summary>
    Property mindepth As Integer

    ''' <summary>
    ''' Brf: 16 bpp label pix
    '''  Loc: SRC/watershed.h (43, 20)
    '''  Org: [struct Pix * pixlab]
    ''' </summary>
    Property pixlab As Pix

    ''' <summary>
    ''' Brf: scratch pix for computing wshed regions
    '''  Loc: SRC/watershed.h (44, 20)
    '''  Org: [struct Pix * pixt]
    ''' </summary>
    Property pixt As Pix

    ''' <summary>
    ''' Brf: line ptrs for pixs
    '''  Loc: SRC/watershed.h (45, 20)
    '''  Org: [void ** lines8]
    ''' </summary>
    Property lines8 As Object

    ''' <summary>
    ''' Brf: line ptrs for pixm
    '''  Loc: SRC/watershed.h (46, 20)
    '''  Org: [void ** linem1]
    ''' </summary>
    Property linem1 As Object

    ''' <summary>
    ''' Brf: line ptrs for pixlab
    '''  Loc: SRC/watershed.h (47, 20)
    '''  Org: [void ** linelab32]
    ''' </summary>
    Property linelab32 As Object

    ''' <summary>
    ''' Brf: line ptrs for pixt
    '''  Loc: SRC/watershed.h (48, 20)
    '''  Org: [void ** linet1]
    ''' </summary>
    Property linet1 As Object

    ''' <summary>
    ''' Brf: result: 1 bpp pixa of watersheds
    '''  Loc: SRC/watershed.h (49, 20)
    '''  Org: [struct Pixa * pixad]
    ''' </summary>
    Property pixad As Pixa

    ''' <summary>
    ''' Brf: pta of initial seed pixels
    '''  Loc: SRC/watershed.h (50, 20)
    '''  Org: [struct Pta * ptas]
    ''' </summary>
    Property ptas As Pta

    ''' <summary>
    ''' Brf: numa of seed indicators; 0 if completed
    '''  Loc: SRC/watershed.h (51, 20)
    '''  Org: [struct Numa * nasi]
    ''' </summary>
    Property nasi As Numa

    ''' <summary>
    ''' Brf: numa of initial seed heights
    '''  Loc: SRC/watershed.h (52, 20)
    '''  Org: [struct Numa * nash]
    ''' </summary>
    Property nash As Numa

    ''' <summary>
    ''' Brf: numa of initial minima heights
    '''  Loc: SRC/watershed.h (53, 20)
    '''  Org: [struct Numa * namh]
    ''' </summary>
    Property namh As Numa

    ''' <summary>
    ''' Brf: result: numa of watershed levels
    '''  Loc: SRC/watershed.h (54, 20)
    '''  Org: [struct Numa * nalevels]
    ''' </summary>
    Property nalevels As Numa

    ''' <summary>
    ''' Brf: number of seeds (markers)
    '''  Loc: SRC/watershed.h (55, 20)
    '''  Org: [l_int32 nseeds]
    ''' </summary>
    Property nseeds As Integer

    ''' <summary>
    ''' Brf: number of minima different from seeds
    '''  Loc: SRC/watershed.h (56, 20)
    '''  Org: [l_int32 nother]
    ''' </summary>
    Property nother As Integer

    ''' <summary>
    ''' Brf: lut for pixel indices
    '''  Loc: SRC/watershed.h (57, 20)
    '''  Org: [l_int32 * lut]
    ''' </summary>
    Property lut As Integer()

    ''' <summary>
    ''' Brf: back-links into lut, for updates
    '''  Loc: SRC/watershed.h (58, 20)
    '''  Org: [struct Numa ** links]
    ''' </summary>
    Property links As Numa

    ''' <summary>
    ''' Brf: size of links array
    '''  Loc: SRC/watershed.h (59, 20)
    '''  Org: [l_int32 arraysize]
    ''' </summary>
    Property arraysize As Integer

    ''' <summary>
    ''' Brf: set to 1 for debug output
    '''  Loc: SRC/watershed.h (60, 20)
    '''  Org: [l_int32 debug]
    ''' </summary>
    Property debug As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        pixs = New Pix(Values.pixs)
        pixm = New Pix(Values.pixm)
        mindepth = Values.mindepth
        pixlab = New Pix(Values.pixlab)
        pixt = New Pix(Values.pixt)
        ReDim lines8(100)
        Marshal.Copy(Values.lines8, lines8, 0, lines8.Length)
        ReDim linem1(100)
        Marshal.Copy(Values.linem1, linem1, 0, linem1.Length)
        ReDim linelab32(100)
        Marshal.Copy(Values.linelab32, linelab32, 0, linelab32.Length)
        ReDim linet1(100)
        Marshal.Copy(Values.linet1, linet1, 0, linet1.Length)
        pixad = New Pixa(Values.pixad)
        ptas = New Pta(Values.ptas)
        nasi = New Numa(Values.nasi)
        nash = New Numa(Values.nash)
        namh = New Numa(Values.namh)
        nalevels = New Numa(Values.nalevels)
        nseeds = Values.nseeds
        nother = Values.nother
        ReDim lut(100)
        Marshal.Copy(Values.lut, lut, 0, lut.Length)
        links = New Numa(Values.links)
        arraysize = Values.arraysize
        debug = Values.debug
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_WShed
        Public pixs As IntPTR
        Public pixm As IntPTR
        Public mindepth As Integer
        Public pixlab As IntPTR
        Public pixt As IntPTR
        Public lines8 As IntPTR
        Public linem1 As IntPTR
        Public linelab32 As IntPTR
        Public linet1 As IntPTR
        Public pixad As IntPTR
        Public ptas As IntPTR
        Public nasi As IntPTR
        Public nash As IntPTR
        Public namh As IntPTR
        Public nalevels As IntPTR
        Public nseeds As Integer
        Public nother As Integer
        Public lut As IntPTR
        Public links As IntPTR
        Public arraysize As Integer
        Public debug As Integer
    End Class
End Class


#End Region
#Region "SRC/bilateral.h"
' SRC/bilateral.h (115, 8)
' 
Public Class L_Bilateral
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Bilateral

    ''' <summary>
    ''' Brf: clone of source pix
    '''  Loc: SRC/bilateral.h (117, 21)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    Property pixs As Pix

    ''' <summary>
    ''' Brf: downscaled pix with mirrored border
    '''  Loc: SRC/bilateral.h (118, 21)
    '''  Org: [struct Pix * pixsc]
    ''' </summary>
    Property pixsc As Pix

    ''' <summary>
    ''' Brf: 1, 2 or 4x for intermediates
    '''  Loc: SRC/bilateral.h (119, 21)
    '''  Org: [l_int32 reduction]
    ''' </summary>
    Property reduction As Integer

    ''' <summary>
    ''' Brf: stdev of spatial gaussian
    '''  Loc: SRC/bilateral.h (120, 21)
    '''  Org: [l_float32 spatial_stdev]
    ''' </summary>
    Property spatial_stdev As Single

    ''' <summary>
    ''' Brf: stdev of range gaussian
    '''  Loc: SRC/bilateral.h (121, 21)
    '''  Org: [l_float32 range_stdev]
    ''' </summary>
    Property range_stdev As Single

    ''' <summary>
    ''' Brf: 1D gaussian spatial kernel
    '''  Loc: SRC/bilateral.h (122, 21)
    '''  Org: [l_float32 * spatial]
    ''' </summary>
    Property spatial As Single()

    ''' <summary>
    ''' Brf: one-sided gaussian range kernel
    '''  Loc: SRC/bilateral.h (123, 21)
    '''  Org: [l_float32 * range]
    ''' </summary>
    Property range As Single()

    ''' <summary>
    ''' Brf: min value in 8 bpp pix
    '''  Loc: SRC/bilateral.h (124, 21)
    '''  Org: [l_int32 minval]
    ''' </summary>
    Property minval As Integer

    ''' <summary>
    ''' Brf: max value in 8 bpp pix
    '''  Loc: SRC/bilateral.h (125, 21)
    '''  Org: [l_int32 maxval]
    ''' </summary>
    Property maxval As Integer

    ''' <summary>
    ''' Brf: number of intermediate results
    '''  Loc: SRC/bilateral.h (126, 21)
    '''  Org: [l_int32 ncomps]
    ''' </summary>
    Property ncomps As Integer

    ''' <summary>
    ''' Brf: set of k values (size ncomps)
    '''  Loc: SRC/bilateral.h (127, 21)
    '''  Org: [l_int32 * nc]
    ''' </summary>
    Property nc As Integer()

    ''' <summary>
    ''' Brf: mapping from intensity to lower k
    '''  Loc: SRC/bilateral.h (128, 21)
    '''  Org: [l_int32 * kindex]
    ''' </summary>
    Property kindex As Integer()

    ''' <summary>
    ''' Brf: mapping from intensity to fract k
    '''  Loc: SRC/bilateral.h (129, 21)
    '''  Org: [l_float32 * kfract]
    ''' </summary>
    Property kfract As Single()

    ''' <summary>
    ''' Brf: intermediate result images (PBC)
    '''  Loc: SRC/bilateral.h (130, 21)
    '''  Org: [struct Pixa * pixac]
    ''' </summary>
    Property pixac As Pixa

    ''' <summary>
    ''' Brf: lineptrs for pixac
    '''  Loc: SRC/bilateral.h (131, 21)
    '''  Org: [l_uint32 *** lineset]
    ''' </summary>
    Property lineset As Integer()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        pixs = New Pix(Values.pixs)
        pixsc = New Pix(Values.pixsc)
        reduction = Values.reduction
        spatial_stdev = Values.spatial_stdev
        range_stdev = Values.range_stdev
        ReDim spatial(100)
        Marshal.Copy(Values.spatial, spatial, 0, spatial.Length)
        ReDim range(100)
        Marshal.Copy(Values.range, range, 0, range.Length)
        minval = Values.minval
        maxval = Values.maxval
        ncomps = Values.ncomps
        ReDim nc(100)
        Marshal.Copy(Values.nc, nc, 0, nc.Length)
        ReDim kindex(100)
        Marshal.Copy(Values.kindex, kindex, 0, kindex.Length)
        ReDim kfract(100)
        Marshal.Copy(Values.kfract, kfract, 0, kfract.Length)
        pixac = New Pixa(Values.pixac)
        ReDim lineset(100)
        Marshal.Copy(Values.lineset, lineset, 0, lineset.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Bilateral
        Public pixs As IntPTR
        Public pixsc As IntPTR
        Public reduction As Integer
        Public spatial_stdev As Single
        Public range_stdev As Single
        Public spatial As IntPTR
        Public range As IntPTR
        Public minval As Integer
        Public maxval As Integer
        Public ncomps As Integer
        Public nc As IntPTR
        Public kindex As IntPTR
        Public kfract As IntPTR
        Public pixac As IntPTR
        Public lineset As IntPTR
    End Class
End Class


#End Region
#Region "SRC/bmp.h"
' SRC/bmp.h (50, 8)
' 
Public Class BMP_FileHeader
    Property Pointer As IntPTR
    Private Values As New Marshal_BMP_FileHeader

    ''' <summary>
    ''' Brf: file type; must be "BM"
    '''  Loc: SRC/bmp.h (52, 20)
    '''  Org: [l_int16 bfType]
    ''' </summary>
    Property bfType As Short

    ''' <summary>
    ''' Brf: length of the file; sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
    '''  Loc: SRC/bmp.h (53, 20)
    '''  Org: [l_int16 bfSize]
    ''' </summary>
    Property bfSize As Short

    ''' <summary>
    ''' Brf: remainder of the bfSize field
    '''  Loc: SRC/bmp.h (58, 20)
    '''  Org: [l_int16 bfFill1]
    ''' </summary>
    Property bfFill1 As Short

    ''' <summary>
    ''' Brf: don't care (set to 0)
    '''  Loc: SRC/bmp.h (59, 20)
    '''  Org: [l_int16 bfReserved1]
    ''' </summary>
    Property bfReserved1 As Short

    ''' <summary>
    ''' Brf: don't care (set to 0)
    '''  Loc: SRC/bmp.h (60, 20)
    '''  Org: [l_int16 bfReserved2]
    ''' </summary>
    Property bfReserved2 As Short

    ''' <summary>
    ''' Brf: offset from beginning of file
    '''  Loc: SRC/bmp.h (61, 20)
    '''  Org: [l_int16 bfOffBits]
    ''' </summary>
    Property bfOffBits As Short

    ''' <summary>
    ''' Brf: remainder of the bfOffBits field
    '''  Loc: SRC/bmp.h (62, 20)
    '''  Org: [l_int16 bfFill2]
    ''' </summary>
    Property bfFill2 As Short

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public bfType As Short
        Public bfSize As Short
        Public bfFill1 As Short
        Public bfReserved1 As Short
        Public bfReserved2 As Short
        Public bfOffBits As Short
        Public bfFill2 As Short
    End Class
End Class


' SRC/bmp.h (75, 8)
' 
Public Class BMP_InfoHeader
    Property Pointer As IntPTR
    Private Values As New Marshal_BMP_InfoHeader

    ''' <summary>
    ''' Brf: size of the BMP_InfoHeader struct
    '''  Loc: SRC/bmp.h (77, 20)
    '''  Org: [l_int32 biSize]
    ''' </summary>
    Property biSize As Integer

    ''' <summary>
    ''' Brf: bitmap width in pixels
    '''  Loc: SRC/bmp.h (78, 20)
    '''  Org: [l_int32 biWidth]
    ''' </summary>
    Property biWidth As Integer

    ''' <summary>
    ''' Brf: bitmap height in pixels
    '''  Loc: SRC/bmp.h (79, 20)
    '''  Org: [l_int32 biHeight]
    ''' </summary>
    Property biHeight As Integer

    ''' <summary>
    ''' Brf: number of bitmap planes
    '''  Loc: SRC/bmp.h (80, 20)
    '''  Org: [l_int16 biPlanes]
    ''' </summary>
    Property biPlanes As Short

    ''' <summary>
    ''' Brf: number of bits per pixel
    '''  Loc: SRC/bmp.h (81, 20)
    '''  Org: [l_int16 biBitCount]
    ''' </summary>
    Property biBitCount As Short

    ''' <summary>
    ''' Brf: compress format (0 == uncompressed)
    '''  Loc: SRC/bmp.h (82, 20)
    '''  Org: [l_int32 biCompression]
    ''' </summary>
    Property biCompression As Integer

    ''' <summary>
    ''' Brf: size of image in bytes
    '''  Loc: SRC/bmp.h (83, 20)
    '''  Org: [l_int32 biSizeImage]
    ''' </summary>
    Property biSizeImage As Integer

    ''' <summary>
    ''' Brf: pixels per meter in x direction
    '''  Loc: SRC/bmp.h (84, 20)
    '''  Org: [l_int32 biXPelsPerMeter]
    ''' </summary>
    Property biXPelsPerMeter As Integer

    ''' <summary>
    ''' Brf: pixels per meter in y direction
    '''  Loc: SRC/bmp.h (85, 20)
    '''  Org: [l_int32 biYPelsPerMeter]
    ''' </summary>
    Property biYPelsPerMeter As Integer

    ''' <summary>
    ''' Brf: number of colors used
    '''  Loc: SRC/bmp.h (86, 20)
    '''  Org: [l_int32 biClrUsed]
    ''' </summary>
    Property biClrUsed As Integer

    ''' <summary>
    ''' Brf: number of important colors used
    '''  Loc: SRC/bmp.h (87, 20)
    '''  Org: [l_int32 biClrImportant]
    ''' </summary>
    Property biClrImportant As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public biSize As Integer
        Public biWidth As Integer
        Public biHeight As Integer
        Public biPlanes As Short
        Public biBitCount As Short
        Public biCompression As Integer
        Public biSizeImage As Integer
        Public biXPelsPerMeter As Integer
        Public biYPelsPerMeter As Integer
        Public biClrUsed As Integer
        Public biClrImportant As Integer
    End Class
End Class


#End Region
#Region "SRC\colorquant1.c"
' SRC\colorquant1.c (158, 8)
' 
Public Class ColorQuantCell
    Property Pointer As IntPTR
    Private Values As New Marshal_ColorQuantCell

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (160, 17)
    '''  Org: [l_int32 rc]
    ''' </summary>
    Property rc As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (160, 21)
    '''  Org: [l_int32 gc]
    ''' </summary>
    Property gc As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (160, 25)
    '''  Org: [l_int32 bc]
    ''' </summary>
    Property bc As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (161, 17)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (162, 17)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (163, 17)
    '''  Org: [l_int32 nleaves]
    ''' </summary>
    Property nleaves As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (164, 17)
    '''  Org: [l_int32 bleaf]
    ''' </summary>
    Property bleaf As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public rc As Integer
        Public gc As Integer
        Public bc As Integer
        Public n As Integer
        Public index As Integer
        Public nleaves As Integer
        Public bleaf As Integer
    End Class
End Class


' SRC\colorquant1.c (190, 8)
' 
Public Class OctcubeQuantCell
    Property Pointer As IntPTR
    Private Values As New Marshal_OctcubeQuantCell

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (192, 16)
    '''  Org: [l_float32 n]
    ''' </summary>
    Property n As Single

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (193, 16)
    '''  Org: [l_int32 octindex]
    ''' </summary>
    Property octindex As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (194, 16)
    '''  Org: [l_int32 rcum]
    ''' </summary>
    Property rcum As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (194, 22)
    '''  Org: [l_int32 gcum]
    ''' </summary>
    Property gcum As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (194, 28)
    '''  Org: [l_int32 bcum]
    ''' </summary>
    Property bcum As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (195, 16)
    '''  Org: [l_int32 rval]
    ''' </summary>
    Property rval As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (195, 22)
    '''  Org: [l_int32 gval]
    ''' </summary>
    Property gval As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (195, 28)
    '''  Org: [l_int32 bval]
    ''' </summary>
    Property bval As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public n As Single
        Public octindex As Integer
        Public rcum As Integer
        Public gcum As Integer
        Public bcum As Integer
        Public rval As Integer
        Public gval As Integer
        Public bval As Integer
    End Class
End Class


' SRC\colorquant1.c (206, 8)
' 
Public Class L_OctcubePop
    Property Pointer As IntPTR
    Private Values As New Marshal_L_OctcubePop

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (208, 22)
    '''  Org: [l_float32 npix]
    ''' </summary>
    Property npix As Single

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (209, 22)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (210, 22)
    '''  Org: [l_int32 rval]
    ''' </summary>
    Property rval As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (211, 22)
    '''  Org: [l_int32 gval]
    ''' </summary>
    Property gval As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant1.c (212, 22)
    '''  Org: [l_int32 bval]
    ''' </summary>
    Property bval As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        npix = Values.npix
        index = Values.index
        rval = Values.rval
        gval = Values.gval
        bval = Values.bval
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_OctcubePop
        Public npix As Single
        Public index As Integer
        Public rval As Integer
        Public gval As Integer
        Public bval As Integer
    End Class
End Class


#End Region
#Region "SRC\colorquant2.c"
' SRC\colorquant2.c (178, 8)
' 
Public Class L_Box3d
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Box3d

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (180, 22)
    '''  Org: [l_float32 sortparam]
    ''' </summary>
    Property sortparam As Single

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (181, 22)
    '''  Org: [l_int32 npix]
    ''' </summary>
    Property npix As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (182, 22)
    '''  Org: [l_int32 vol]
    ''' </summary>
    Property vol As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (183, 22)
    '''  Org: [l_int32 r1]
    ''' </summary>
    Property r1 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (184, 22)
    '''  Org: [l_int32 r2]
    ''' </summary>
    Property r2 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (185, 22)
    '''  Org: [l_int32 g1]
    ''' </summary>
    Property g1 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (186, 22)
    '''  Org: [l_int32 g2]
    ''' </summary>
    Property g2 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (187, 22)
    '''  Org: [l_int32 b1]
    ''' </summary>
    Property b1 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\colorquant2.c (188, 22)
    '''  Org: [l_int32 b2]
    ''' </summary>
    Property b2 As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public sortparam As Single
        Public npix As Integer
        Public vol As Integer
        Public r1 As Integer
        Public r2 As Integer
        Public g1 As Integer
        Public g2 As Integer
        Public b1 As Integer
        Public b2 As Integer
    End Class
End Class


#End Region
#Region "SRC\conncomp.c"
' SRC\conncomp.c (99, 8)
' 
Public Class FillSeg
    Property Pointer As IntPTR
    Private Values As New Marshal_FillSeg

    ''' <summary>
    ''' Brf: left edge of run
    '''  Loc: SRC\conncomp.c (101, 16)
    '''  Org: [l_int32 xleft]
    ''' </summary>
    Property xleft As Integer

    ''' <summary>
    ''' Brf: right edge of run
    '''  Loc: SRC\conncomp.c (102, 16)
    '''  Org: [l_int32 xright]
    ''' </summary>
    Property xright As Integer

    ''' <summary>
    ''' Brf: run y
    '''  Loc: SRC\conncomp.c (103, 16)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    ''' <summary>
    ''' Brf: parent segment direction: 1 above, -1 below)
    '''  Loc: SRC\conncomp.c (104, 16)
    '''  Org: [l_int32 dy]
    ''' </summary>
    Property dy As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        xleft = Values.xleft
        xright = Values.xright
        y = Values.y
        dy = Values.dy
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_FillSeg
        Public xleft As Integer
        Public xright As Integer
        Public y As Integer
        Public dy As Integer
    End Class
End Class


#End Region
#Region "SRC\jbclass.c"
' SRC\jbclass.c (236, 8)
' 
Public Class JbFindTemplatesState
    Property Pointer As IntPTR
    Private Values As New Marshal_JbFindTemplatesState

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (238, 22)
    '''  Org: [JBCLASSER * classer]
    ''' </summary>
    Property classer As Object

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (239, 22)
    '''  Org: [l_int32 w]
    ''' </summary>
    Property w As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (240, 22)
    '''  Org: [l_int32 h]
    ''' </summary>
    Property h As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (241, 22)
    '''  Org: [l_int32 i]
    ''' </summary>
    Property i As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (242, 22)
    '''  Org: [L_DNA * dna]
    ''' </summary>
    Property dna As Object

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jbclass.c (243, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    Property n As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        ReDim classer(100)
        Marshal.Copy(Values.classer, classer, 0, classer.Length)
        w = Values.w
        h = Values.h
        i = Values.i
        ReDim dna(100)
        Marshal.Copy(Values.dna, dna, 0, dna.Length)
        n = Values.n
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_JbFindTemplatesState
        Public classer As IntPTR
        Public w As Integer
        Public h As Integer
        Public i As Integer
        Public dna As IntPTR
        Public n As Integer
    End Class
End Class


#End Region
#Region "SRC\jpegio.c"
' SRC\jpegio.c (164, 8)
' 
Public Class callback_data
    Property Pointer As IntPTR
    Private Values As New Marshal_callback_data

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jpegio.c (165, 15)
    '''  Org: [jmp_buf jmpbuf]
    ''' </summary>
    Property jmpbuf As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\jpegio.c (166, 15)
    '''  Org: [l_uint8 * comment]
    ''' </summary>
    Property comment As Byte()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        jmpbuf = Values.jmpbuf
        ReDim comment(100)
        Marshal.Copy(Values.comment, comment, 0, comment.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_callback_data
        Public jmpbuf As Char
        Public comment As IntPTR
    End Class
End Class


#End Region
#Region "SRC\maze.c"
' SRC\maze.c (76, 8)
' 
Public Class MazeElement
    Property Pointer As IntPTR
    Private Values As New Marshal_MazeElement

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\maze.c (77, 16)
    '''  Org: [l_float32 distance]
    ''' </summary>
    Property distance As Single

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\maze.c (78, 16)
    '''  Org: [l_int32 x]
    ''' </summary>
    Property x As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\maze.c (79, 16)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\maze.c (80, 16)
    '''  Org: [l_uint32 val]
    ''' </summary>
    Property val As UInteger

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\maze.c (81, 16)
    '''  Org: [l_int32 dir]
    ''' </summary>
    Property dir As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        distance = Values.distance
        x = Values.x
        y = Values.y
        val = Values.val
        dir = Values.dir
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_MazeElement
        Public distance As Single
        Public x As Integer
        Public y As Integer
        Public val As UInteger
        Public dir As Integer
    End Class
End Class


#End Region
#Region "SRC\partition.c"
' SRC\partition.c (48, 8)
' 
Public Class PartitionElement
    Property Pointer As IntPTR
    Private Values As New Marshal_PartitionElement

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\partition.c (49, 16)
    '''  Org: [l_float32 size]
    ''' </summary>
    Property size As Single

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\partition.c (50, 16)
    '''  Org: [BOX * box]
    ''' </summary>
    Property box As Object

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\partition.c (51, 16)
    '''  Org: [BOXA * boxa]
    ''' </summary>
    Property boxa As Object

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        size = Values.size
        ReDim box(100)
        Marshal.Copy(Values.box, box, 0, box.Length)
        ReDim boxa(100)
        Marshal.Copy(Values.boxa, boxa, 0, boxa.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PartitionElement
        Public size As Single
        Public box As IntPTR
        Public boxa As IntPTR
    End Class
End Class


#End Region
#Region "SRC\pix1.c"
' SRC\pix1.c (218, 8)
' 
Public Class PixMemoryManager
    Property Pointer As IntPTR
    Private Values As New Marshal_PixMemoryManager

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\pix1.c (220, 17)
    '''  Org: [alloc_fn allocator]
    ''' </summary>
    Property allocator As IntPTR

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\pix1.c (221, 17)
    '''  Org: [dealloc_fn deallocator]
    ''' </summary>
    Property deallocator As IntPTR

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        allocator = Values.allocator
        deallocator = Values.deallocator
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PixMemoryManager
        Public allocator As IntPTR
        Public deallocator As IntPTR
    End Class
End Class


#End Region
#Region "SRC\pixalloc.c"
' SRC\pixalloc.c (113, 8)
' 
Public Class PixMemoryStore
    Property Pointer As IntPTR
    Private Values As New Marshal_PixMemoryStore

    ''' <summary>
    ''' Brf: Holds ptrs to allocated memory
    '''  Loc: SRC\pixalloc.c (115, 22)
    '''  Org: [struct L_Ptraa * paa]
    ''' </summary>
    Property paa As L_Ptraa

    ''' <summary>
    ''' Brf: Pix smaller than this (in bytes)
    '''  Loc: SRC\pixalloc.c (116, 22)
    '''  Org: [size_t minsize]
    ''' </summary>
    Property minsize As UInteger

    ''' <summary>
    ''' Brf: Smallest mem (in bytes) alloc'd
    '''  Loc: SRC\pixalloc.c (118, 22)
    '''  Org: [size_t smallest]
    ''' </summary>
    Property smallest As UInteger

    ''' <summary>
    ''' Brf: Larest mem (in bytes) alloc'd
    '''  Loc: SRC\pixalloc.c (119, 22)
    '''  Org: [size_t largest]
    ''' </summary>
    Property largest As UInteger

    ''' <summary>
    ''' Brf: Size of allocated block w/ all chunks
    '''  Loc: SRC\pixalloc.c (120, 22)
    '''  Org: [size_t nbytes]
    ''' </summary>
    Property nbytes As UInteger

    ''' <summary>
    ''' Brf: Num of power-of-2 sizes pre-alloc'd
    '''  Loc: SRC\pixalloc.c (121, 22)
    '''  Org: [l_int32 nlevels]
    ''' </summary>
    Property nlevels As Integer

    ''' <summary>
    ''' Brf: Mem sizes at each power-of-2 level
    '''  Loc: SRC\pixalloc.c (122, 22)
    '''  Org: [size_t * sizes]
    ''' </summary>
    Property sizes As Byte()

    ''' <summary>
    ''' Brf: Number of mem alloc'd at each size
    '''  Loc: SRC\pixalloc.c (123, 22)
    '''  Org: [l_int32 * allocarray]
    ''' </summary>
    Property allocarray As Integer()

    ''' <summary>
    ''' Brf: ptr to allocated array
    '''  Loc: SRC\pixalloc.c (124, 22)
    '''  Org: [l_uint32 * baseptr]
    ''' </summary>
    Property baseptr As Byte()

    ''' <summary>
    ''' Brf: ptr just beyond allocated memory
    '''  Loc: SRC\pixalloc.c (125, 22)
    '''  Org: [l_uint32 * maxptr]
    ''' </summary>
    Property maxptr As Byte()

    ''' <summary>
    ''' Brf: array of ptrs to first chunk in size
    '''  Loc: SRC\pixalloc.c (126, 22)
    '''  Org: [l_uint32 ** firstptr]
    ''' </summary>
    Property firstptr As Integer()

    ''' <summary>
    ''' Brf: log: total # of pix used (by level)
    '''  Loc: SRC\pixalloc.c (127, 22)
    '''  Org: [l_int32 * memused]
    ''' </summary>
    Property memused As Integer()

    ''' <summary>
    ''' Brf: log: # of pix in use (by level)
    '''  Loc: SRC\pixalloc.c (128, 22)
    '''  Org: [l_int32 * meminuse]
    ''' </summary>
    Property meminuse As Integer()

    ''' <summary>
    ''' Brf: log: max # of pix in use (by level)
    '''  Loc: SRC\pixalloc.c (129, 22)
    '''  Org: [l_int32 * memmax]
    ''' </summary>
    Property memmax As Integer()

    ''' <summary>
    ''' Brf: log: # of pix alloc'd because
    '''  Loc: SRC\pixalloc.c (130, 22)
    '''  Org: [l_int32 * memempty]
    ''' </summary>
    Property memempty As Integer()

    ''' <summary>
    ''' Brf: log: set to null if no logging
    '''  Loc: SRC\pixalloc.c (132, 22)
    '''  Org: [char * logfile]
    ''' </summary>
    Property logfile As String

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        paa = New L_Ptraa(Values.paa)
        minsize = Values.minsize
        smallest = Values.smallest
        largest = Values.largest
        nbytes = Values.nbytes
        nlevels = Values.nlevels
        ReDim sizes(100)
        Marshal.Copy(Values.sizes, sizes, 0, sizes.Length)
        ReDim allocarray(100)
        Marshal.Copy(Values.allocarray, allocarray, 0, allocarray.Length)
        ReDim baseptr(100)
        Marshal.Copy(Values.baseptr, baseptr, 0, baseptr.Length)
        ReDim maxptr(100)
        Marshal.Copy(Values.maxptr, maxptr, 0, maxptr.Length)
        ReDim firstptr(100)
        Marshal.Copy(Values.firstptr, firstptr, 0, firstptr.Length)
        ReDim memused(100)
        Marshal.Copy(Values.memused, memused, 0, memused.Length)
        ReDim meminuse(100)
        Marshal.Copy(Values.meminuse, meminuse, 0, meminuse.Length)
        ReDim memmax(100)
        Marshal.Copy(Values.memmax, memmax, 0, memmax.Length)
        ReDim memempty(100)
        Marshal.Copy(Values.memempty, memempty, 0, memempty.Length)
        logfile = Values.logfile
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_PixMemoryStore
        Public paa As IntPTR
        Public minsize As UInteger
        Public smallest As UInteger
        Public largest As UInteger
        Public nbytes As UInteger
        Public nlevels As Integer
        Public sizes As IntPTR
        Public allocarray As IntPTR
        Public baseptr As IntPTR
        Public maxptr As IntPTR
        Public firstptr As IntPTR
        Public memused As IntPTR
        Public meminuse As IntPTR
        Public memmax As IntPTR
        Public memempty As IntPTR
        Public logfile As String
    End Class
End Class


#End Region
#Region "SRC\pngio.c"
' SRC\pngio.c (1293, 8)
' 
Public Class MemIOData
    Property Pointer As IntPTR
    Private Values As New Marshal_MemIOData

    ''' <summary>
    ''' Brf: pointer to this node's I/O content
    '''  Loc: SRC\pngio.c (1295, 17)
    '''  Org: [char * m_Buffer]
    ''' </summary>
    Property m_Buffer As String

    ''' <summary>
    ''' Brf: number of I/O content bytes read or written
    '''  Loc: SRC\pngio.c (1296, 17)
    '''  Org: [l_int32 m_Count]
    ''' </summary>
    Property m_Count As Integer

    ''' <summary>
    ''' Brf: allocated size of m_buffer
    '''  Loc: SRC\pngio.c (1297, 17)
    '''  Org: [l_int32 m_Size]
    ''' </summary>
    Property m_Size As Integer

    ''' <summary>
    ''' Brf: pointer to the next node in the list;
    '''  Loc: SRC\pngio.c (1298, 24)
    '''  Org: [struct MemIOData * m_Next]
    ''' </summary>
    Property m_Next As MemIOData

    ''' <summary>
    ''' Brf: pointer to the last node in the linked
    '''  Loc: SRC\pngio.c (1300, 24)
    '''  Org: [struct MemIOData * m_Last]
    ''' </summary>
    Property m_Last As MemIOData

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        m_Buffer = Values.m_Buffer
        m_Count = Values.m_Count
        m_Size = Values.m_Size
        m_Next = New MemIOData(Values.m_Next)
        m_Last = New MemIOData(Values.m_Last)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_MemIOData
        Public m_Buffer As String
        Public m_Count As Integer
        Public m_Size As Integer
        Public m_Next As IntPTR
        Public m_Last As IntPTR
    End Class
End Class


#End Region
#Region "SRC\seedfill.c"
' SRC\seedfill.c (170, 8)
' 
Public Class L_Pixel
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Pixel

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\seedfill.c (172, 16)
    '''  Org: [l_int32 x]
    ''' </summary>
    Property x As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\seedfill.c (173, 16)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        x = Values.x
        y = Values.y
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Pixel
        Public x As Integer
        Public y As Integer
    End Class
End Class


#End Region
#Region "SRC\sel1.c"
' SRC\sel1.c (152, 8)
' 
Public Class CompParameterMap
    Property Pointer As IntPTR
    Private Values As New Marshal_CompParameterMap

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (154, 14)
    '''  Org: [l_int32 size]
    ''' </summary>
    Property size As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (155, 14)
    '''  Org: [l_int32 size1]
    ''' </summary>
    Property size1 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (156, 14)
    '''  Org: [l_int32 size2]
    ''' </summary>
    Property size2 As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (157, 14)
    '''  Org: [char [20] selnameh1]
    ''' </summary>
    Property selnameh1 As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (158, 14)
    '''  Org: [char [20] selnameh2]
    ''' </summary>
    Property selnameh2 As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (159, 14)
    '''  Org: [char [20] selnamev1]
    ''' </summary>
    Property selnamev1 As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\sel1.c (160, 14)
    '''  Org: [char [20] selnamev2]
    ''' </summary>
    Property selnamev2 As Char

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
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
        Public size As Integer
        Public size1 As Integer
        Public size2 As Integer
        Public selnameh1 As Char
        Public selnameh2 As Char
        Public selnamev1 As Char
        Public selnamev2 As Char
    End Class
End Class


#End Region
#Region "SRC\stringcode.c"
' SRC\stringcode.c (95, 8)
' 
Public Class L_GenAssoc
    Property Pointer As IntPTR
    Private Values As New Marshal_L_GenAssoc

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\stringcode.c (97, 14)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\stringcode.c (98, 14)
    '''  Org: [char [16] type]
    ''' </summary>
    Property type As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\stringcode.c (99, 14)
    '''  Org: [char [16] structname]
    ''' </summary>
    Property structname As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\stringcode.c (100, 14)
    '''  Org: [char [16] reader]
    ''' </summary>
    Property reader As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\stringcode.c (101, 14)
    '''  Org: [char [20] memreader]
    ''' </summary>
    Property memreader As Char

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        index = Values.index
        type = Values.type
        structname = Values.structname
        reader = Values.reader
        memreader = Values.memreader
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_GenAssoc
        Public index As Integer
        Public type As Char
        Public structname As Char
        Public reader As Char
        Public memreader As Char
    End Class
End Class


#End Region
#Region "SRC\tiffio.c"
' SRC\tiffio.c (155, 8)
' 
Public Class tiff_transform
    Property Pointer As IntPTR
    Private Values As New Marshal_tiff_transform

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (156, 9)
    '''  Org: [int vflip]
    ''' </summary>
    Property vflip As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (157, 9)
    '''  Org: [int hflip]
    ''' </summary>
    Property hflip As Integer

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (158, 9)
    '''  Org: [int rotate]
    ''' </summary>
    Property rotate As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        vflip = Values.vflip
        hflip = Values.hflip
        rotate = Values.rotate
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_tiff_transform
        Public vflip As Integer
        Public hflip As Integer
        Public rotate As Integer
    End Class
End Class


' SRC\tiffio.c (2174, 8)
' 
Public Class L_Memstream
    Property Pointer As IntPTR
    Private Values As New Marshal_L_Memstream

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2176, 16)
    '''  Org: [l_uint8 * buffer]
    ''' </summary>
    Property buffer As Byte()

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2178, 16)
    '''  Org: [size_t bufsize]
    ''' </summary>
    Property bufsize As UInteger

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2180, 16)
    '''  Org: [size_t offset]
    ''' </summary>
    Property offset As UInteger

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2181, 16)
    '''  Org: [size_t hw]
    ''' </summary>
    Property hw As UInteger

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2182, 16)
    '''  Org: [l_uint8 ** poutdata]
    ''' </summary>
    Property poutdata As Byte()

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\tiffio.c (2183, 16)
    '''  Org: [size_t * poutsize]
    ''' </summary>
    Property poutsize As Byte()

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        ReDim buffer(100)
        Marshal.Copy(Values.buffer, buffer, 0, buffer.Length)
        bufsize = Values.bufsize
        offset = Values.offset
        hw = Values.hw
        ReDim poutdata(100)
        Marshal.Copy(Values.poutdata, poutdata, 0, poutdata.Length)
        ReDim poutsize(100)
        Marshal.Copy(Values.poutsize, poutsize, 0, poutsize.Length)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Memstream
        Public buffer As IntPTR
        Public bufsize As UInteger
        Public offset As UInteger
        Public hw As UInteger
        Public poutdata As IntPTR
        Public poutsize As IntPTR
    End Class
End Class


#End Region
#Region "SRC\watershed.c"
' SRC\watershed.c (124, 8)
' 
Public Class L_NewPixel
    Property Pointer As IntPTR
    Private Values As New Marshal_L_NewPixel

    ''' <summary>
    ''' Brf: x coordinate
    '''  Loc: SRC\watershed.c (126, 16)
    '''  Org: [l_int32 x]
    ''' </summary>
    Property x As Integer

    ''' <summary>
    ''' Brf: y coordinate
    '''  Loc: SRC\watershed.c (127, 16)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        x = Values.x
        y = Values.y
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_NewPixel
        Public x As Integer
        Public y As Integer
    End Class
End Class


' SRC\watershed.c (132, 8)
' 
Public Class L_WSPixel
    Property Pointer As IntPTR
    Private Values As New Marshal_L_WSPixel

    ''' <summary>
    ''' Brf: pixel value
    '''  Loc: SRC\watershed.c (134, 16)
    '''  Org: [l_float32 val]
    ''' </summary>
    Property val As Single

    ''' <summary>
    ''' Brf: x coordinate
    '''  Loc: SRC\watershed.c (135, 16)
    '''  Org: [l_int32 x]
    ''' </summary>
    Property x As Integer

    ''' <summary>
    ''' Brf: y coordinate
    '''  Loc: SRC\watershed.c (136, 16)
    '''  Org: [l_int32 y]
    ''' </summary>
    Property y As Integer

    ''' <summary>
    ''' Brf: label for set to which pixel belongs
    '''  Loc: SRC\watershed.c (137, 16)
    '''  Org: [l_int32 index]
    ''' </summary>
    Property index As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        val = Values.val
        x = Values.x
        y = Values.y
        index = Values.index
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_WSPixel
        Public val As Single
        Public x As Integer
        Public y As Integer
        Public index As Integer
    End Class
End Class


#End Region
#Region "SRC\writefile.c"
' SRC\writefile.c (139, 8)
' 
Public Class ExtensionMap
    Property Pointer As IntPTR
    Private Values As New Marshal_ExtensionMap

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\writefile.c (141, 14)
    '''  Org: [char [8] extension]
    ''' </summary>
    Property extension As Char

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC\writefile.c (142, 14)
    '''  Org: [l_int32 format]
    ''' </summary>
    Property format As Integer

    Sub New(PTR As IntPTR)
        Pointer = PTR
        Marshal.PtrToStructure(Pointer, Values)
        extension = Values.extension
        format = Values.format
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_ExtensionMap
        Public extension As Char
        Public format As Integer
    End Class
End Class


#End Region
