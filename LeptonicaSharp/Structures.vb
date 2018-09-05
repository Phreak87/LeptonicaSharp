Imports System.Runtime.InteropServices

Imports LeptonicaSharp.Enumerations

#Region "SRC/environ.h"
' SRC/environ.h (308, 8)
' Timing struct
Public Class L_WallTimer
	Property Pointer as IntPTR
	Private Values as Marshal_L_WallTimer

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (309, 14)
'''  Org: [l_int32 start_sec]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property start_sec as Integer
	Get
				Return Values.start_sec
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (310, 14)
'''  Org: [l_int32 start_usec]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property start_usec as Integer
	Get
				Return Values.start_usec
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (311, 14)
'''  Org: [l_int32 stop_sec]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property stop_sec as Integer
	Get
				Return Values.stop_sec
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/environ.h (312, 14)
'''  Org: [l_int32 stop_usec]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property stop_usec as Integer
	Get
				Return Values.stop_usec
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_WallTimer
		Marshal.PtrToStructure (Pointer, Values)
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
' Number array: an array of floats
Public Class Numa
	Property Pointer as IntPTR
	Private Values as Marshal_Numa

''' <summary>
''' Brf: size of allocated number array
'''  Loc: SRC/array.h (61, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of numbers saved
'''  Loc: SRC/array.h (62, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (63, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as Integer
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (64, 22)
'''  Org: [l_float32 startx]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property startx as Single
	Get
				Return Values.startx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: change in x value as i -- bigger  i + 1
'''  Loc: SRC/array.h (65, 22)
'''  Org: [l_float32 delx]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property delx as Single
	Get
				Return Values.delx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number array
'''  Loc: SRC/array.h (66, 22)
'''  Org: [l_float32 * array]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property array as Single()
	Get
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Single
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Numa
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of number arrays
Public Class Numaa
	Property Pointer as IntPTR
	Private Values as Marshal_Numaa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (73, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of Numa saved
'''  Loc: SRC/array.h (74, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of Numa
'''  Loc: SRC/array.h (75, 22)
'''  Org: [struct Numa ** numa]
'''  Msh: struct Numa ** | 3:Struct | List (of Numa) Typedef: Numa = Numa
''' </summary>
ReadOnly Property numa as List (of Numa)
	Get
		If Values.numa <> IntPtr.Zero Then
		Dim LST_numa As New List(Of Numa)
		Dim ARR_numa(values.n - 1) As IntPtr
		Marshal.Copy(Values.numa, ARR_numa, 0, values.n)
		For Each Entry In ARR_numa
			LST_numa.Add(New Numa(Entry))
		Next
Return LST_numa
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Numaa
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Numaa
		Public nalloc as Integer
		Public n as Integer
		Public numa as IntPTR
	End Class
End Class


' SRC/array.h (83, 8)
' Double number array: an array of doubles
Public Class L_Dna
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dna

''' <summary>
''' Brf: size of allocated number array
'''  Loc: SRC/array.h (85, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of numbers saved
'''  Loc: SRC/array.h (86, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (87, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as Integer
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (88, 22)
'''  Org: [l_float64 startx]
'''  Msh: l_float64 = bigger  1:*
''' </summary>
ReadOnly Property startx as Double
	Get
				Return Values.startx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: change in x value as i -- bigger  i + 1
'''  Loc: SRC/array.h (89, 22)
'''  Org: [l_float64 delx]
'''  Msh: l_float64 = bigger  1:*
''' </summary>
ReadOnly Property delx as Double
	Get
				Return Values.delx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number array
'''  Loc: SRC/array.h (90, 22)
'''  Org: [l_float64 * array]
'''  Msh: l_float64 * | 2:Double | Double()
''' </summary>
ReadOnly Property array as Double()
	Get
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Double
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Dna
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of double number arrays
Public Class L_Dnaa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dnaa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (97, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of L_Dna saved
'''  Loc: SRC/array.h (98, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of L_Dna
'''  Loc: SRC/array.h (99, 22)
'''  Org: [struct L_Dna ** dna]
'''  Msh: struct L_Dna ** | 3:Struct | List (of L_Dna) Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property dna as List (of L_Dna)
	Get
		If Values.dna <> IntPtr.Zero Then
		Dim LST_dna As New List(Of L_Dna)
		Dim ARR_dna(values.n - 1) As IntPtr
		Marshal.Copy(Values.dna, ARR_dna, 0, values.n)
		For Each Entry In ARR_dna
			LST_dna.Add(New L_Dna(Entry))
		Next
Return LST_dna
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Dnaa
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Dnaa
		Public nalloc as Integer
		Public n as Integer
		Public dna as IntPTR
	End Class
End Class


' SRC/array.h (104, 8)
' A hash table of Dnas
Public Class L_DnaHash
	Property Pointer as IntPTR
	Private Values as Marshal_L_DnaHash

''' <summary>
''' Brf: 
'''  Loc: SRC/array.h (106, 22)
'''  Org: [l_int32 nbuckets]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nbuckets as Integer
	Get
				Return Values.nbuckets
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: initial size of each dna that is made
'''  Loc: SRC/array.h (107, 22)
'''  Org: [l_int32 initsize]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property initsize as Integer
	Get
				Return Values.initsize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of L_Dna
'''  Loc: SRC/array.h (108, 22)
'''  Org: [struct L_Dna ** dna]
'''  Msh: struct L_Dna ** | 3:Struct | List (of L_Dna) Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property dna as List (of L_Dna)
	Get
		If Values.dna <> IntPtr.Zero Then
		Dim LST_dna As New List(Of L_Dna)
		Dim ARR_dna(1 - 1) As IntPtr
		Marshal.Copy(Values.dna, ARR_dna, 0, 1)
		For Each Entry In ARR_dna
			LST_dna.Add(New L_Dna(Entry))
		Next
Return LST_dna
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_DnaHash
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_DnaHash
		Public nbuckets as Integer
		Public initsize as Integer
		Public dna as IntPTR
	End Class
End Class


' SRC/array.h (116, 8)
' String array: an array of C strings
Public Class Sarray
	Property Pointer as IntPTR
	Private Values as Marshal_Sarray

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/array.h (118, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of strings allocated
'''  Loc: SRC/array.h (119, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (120, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as Integer
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: string array
'''  Loc: SRC/array.h (121, 22)
'''  Org: [char ** array]
'''  Msh: char ** | 3:CharS | List (of String)
''' </summary>
ReadOnly Property array as List (of String)
	Get
		Dim Marshal_array(values.n -1) as IntPTR
Dim Values_array as new List (of String)
Marshal.Copy(Values.array, Marshal_array, 0, Marshal_array.Length)
For Each Marshal_Value In Marshal_array
	Values_array.Add(Marshal.PtrToStringAnsi(Marshal_Value))
Next
Return Values_array
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Sarray
		Marshal.PtrToStructure (Pointer, Values)
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
' Byte array (analogous to C++ "string")
Public Class L_Bytea
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bytea

''' <summary>
''' Brf: number of bytes allocated in data array
'''  Loc: SRC/array.h (128, 22)
'''  Org: [size_t nalloc]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property nalloc as UInteger
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of bytes presently used
'''  Loc: SRC/array.h (129, 22)
'''  Org: [size_t size]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property size as UInteger
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (130, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as Integer
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: data array
'''  Loc: SRC/array.h (131, 22)
'''  Org: [l_uint8 * data]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property data as Byte()
	Get
		If Values.data <> IntPtr.Zero Then 
	Dim _data(values.nalloc -1) as Byte
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Bytea
		Marshal.PtrToStructure (Pointer, Values)
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
' Expandable byte buffer for memory read/write operations
Public Class L_ByteBuffer
	Property Pointer as IntPTR
	Private Values as Marshal_L_ByteBuffer

''' <summary>
''' Brf: size of allocated byte array
'''  Loc: SRC/bbuffer.h (52, 18)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of bytes read into to the array
'''  Loc: SRC/bbuffer.h (53, 18)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of bytes written from the array
'''  Loc: SRC/bbuffer.h (54, 18)
'''  Org: [l_int32 nwritten]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nwritten as Integer
	Get
				Return Values.nwritten
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: byte array
'''  Loc: SRC/bbuffer.h (55, 18)
'''  Org: [l_uint8 * array]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property array as Byte()
	Get
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Byte
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_ByteBuffer
		Marshal.PtrToStructure (Pointer, Values)
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
' Heap of arbitrary void* data
Public Class L_Heap
	Property Pointer as IntPTR
	Private Values as Marshal_L_Heap

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/heap.h (79, 18)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of elements stored in the heap
'''  Loc: SRC/heap.h (80, 18)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/heap.h (81, 18)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.n) as IntPTR
		Marshal.Copy(Values.array, _array, 0, values.n)
		Return _array
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: L_SORT_INCREASING or L_SORT_DECREASING
'''  Loc: SRC/heap.h (82, 18)
'''  Org: [l_int32 direction]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property direction as Integer
	Get
				Return Values.direction
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Heap
		Marshal.PtrToStructure (Pointer, Values)
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
' list.h
Public Class DoubleLinkedList
	Property Pointer as IntPTR
	Private Values as Marshal_DoubleLinkedList

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (63, 33)
'''  Org: [struct DoubleLinkedList * prev]
'''  Msh: struct DoubleLinkedList * | 2:Struct | DoubleLinkedList
''' </summary>
ReadOnly Property prev as DoubleLinkedList
	Get
			If Values.prev <> IntPtr.Zero Then 
		Return New DoubleLinkedList(Values.prev)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (64, 33)
'''  Org: [struct DoubleLinkedList * next]
'''  Msh: struct DoubleLinkedList * | 2:Struct | DoubleLinkedList
''' </summary>
ReadOnly Property _next_ as DoubleLinkedList
	Get
			If Values._next_ <> IntPtr.Zero Then 
		Return New DoubleLinkedList(Values._next_)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/list.h (65, 33)
'''  Org: [void * data]
'''  Msh: void * | 2:Void | IntPTR ... Pointer auf Object = IntPTR
''' </summary>
ReadOnly Property data as IntPTR
	Get
		If Values.data <> IntPtr.Zero Then
	Return  Values.data
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_DoubleLinkedList
		Marshal.PtrToStructure (Pointer, Values)
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
' Generic pointer array
Public Class L_Ptra
	Property Pointer as IntPTR
	Private Values as Marshal_L_Ptra

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (53, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: greatest valid index
'''  Loc: SRC/ptra.h (54, 22)
'''  Org: [l_int32 imax]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property imax as Integer
	Get
				Return Values.imax
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: actual number of stored elements
'''  Loc: SRC/ptra.h (55, 22)
'''  Org: [l_int32 nactual]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nactual as Integer
	Get
				Return Values.nactual
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/ptra.h (56, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.nalloc) as IntPTR
		Marshal.Copy(Values.array, _array, 0, values.nalloc)
		Return _array
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Ptra
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of generic pointer arrays
Public Class L_Ptraa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Ptraa

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (64, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of ptra
'''  Loc: SRC/ptra.h (65, 22)
'''  Org: [struct L_Ptra ** ptra]
'''  Msh: struct L_Ptra ** | 3:Struct | List (of L_Ptra) Typedef: L_Ptra = L_Ptra
''' </summary>
ReadOnly Property ptra as List (of L_Ptra)
	Get
		If Values.ptra <> IntPtr.Zero Then
		Dim LST_ptra As New List(Of L_Ptra)
		Dim ARR_ptra(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.ptra, ARR_ptra, 0, values.nalloc)
		For Each Entry In ARR_ptra
			LST_ptra.Add(New L_Ptra(Entry))
		Next
Return LST_ptra
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Ptraa
		Marshal.PtrToStructure (Pointer, Values)
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
' Expandable pointer queue for arbitrary void* data
Public Class L_Queue
	Property Pointer as IntPTR
	Private Values as Marshal_L_Queue

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/queue.h (66, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: location of head (in ptrs) from the
'''  Loc: SRC/queue.h (67, 22)
'''  Org: [l_int32 nhead]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nhead as Integer
	Get
				Return Values.nhead
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of elements stored in the queue
'''  Loc: SRC/queue.h (69, 22)
'''  Org: [l_int32 nelem]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nelem as Integer
	Get
				Return Values.nelem
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/queue.h (70, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.nalloc) as IntPTR
		Marshal.Copy(Values.array, _array, 0, values.nalloc)
		Return _array
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: auxiliary stack
'''  Loc: SRC/queue.h (71, 22)
'''  Org: [struct L_Stack * stack]
'''  Msh: struct L_Stack * | 2:Struct | L_Stack
''' </summary>
ReadOnly Property stack as L_Stack
	Get
			If Values.stack <> IntPtr.Zero Then 
		Return New L_Stack(Values.stack)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Queue
		Marshal.PtrToStructure (Pointer, Values)
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
' Storage for keys and values for red-black trees, maps and sets. Note: (1) Keys and values of the valid key types are all 64-bit (2) (void *) can be used for values but not for keys.
Public Class Rb_Type
	Property Pointer as IntPTR
	Private Values as Marshal_Rb_Type

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (62, 16)
'''  Org: [l_int64 itype]
'''  Msh: l_int64 = bigger  1:*
''' </summary>
ReadOnly Property itype as Long
	Get
				Return Values.itype
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (63, 16)
'''  Org: [l_uint64 utype]
'''  Msh: l_uint64 = bigger  1:*
''' </summary>
ReadOnly Property utype as ULong
	Get
				Return Values.utype
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (64, 16)
'''  Org: [l_float64 ftype]
'''  Msh: l_float64 = bigger  1:*
''' </summary>
ReadOnly Property ftype as Double
	Get
				Return Values.ftype
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (65, 16)
'''  Org: [void * ptype]
'''  Msh: void * | 2:Void | IntPTR ... Pointer auf Object = IntPTR
''' </summary>
ReadOnly Property ptype as IntPTR
	Get
		If Values.ptype <> IntPtr.Zero Then
	Return  Values.ptype
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Rb_Type
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: struct L_Rbtree_Node * | 2:Struct | L_Rbtree_Node
''' </summary>
ReadOnly Property root as L_Rbtree_Node
	Get
			If Values.root <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.root)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (71, 28)
'''  Org: [l_int32 keytype]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property keytype as Integer
	Get
				Return Values.keytype
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Rbtree
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: Rb_Type = bigger  1:* Typedef: Rb_Type = Rb_Type
''' </summary>
ReadOnly Property key as Rb_Type
	Get
				Return Values.key
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (79, 28)
'''  Org: [union Rb_Type value]
'''  Msh: Rb_Type = bigger  1:* Typedef: Rb_Type = Rb_Type
''' </summary>
ReadOnly Property value as Rb_Type
	Get
				Return Values.value
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (80, 28)
'''  Org: [struct L_Rbtree_Node * left]
'''  Msh: struct L_Rbtree_Node * | 2:Struct | L_Rbtree_Node
''' </summary>
ReadOnly Property left as L_Rbtree_Node
	Get
			If Values.left <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.left)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (81, 28)
'''  Org: [struct L_Rbtree_Node * right]
'''  Msh: struct L_Rbtree_Node * | 2:Struct | L_Rbtree_Node
''' </summary>
ReadOnly Property right as L_Rbtree_Node
	Get
			If Values.right <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.right)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (82, 28)
'''  Org: [struct L_Rbtree_Node * parent]
'''  Msh: struct L_Rbtree_Node * | 2:Struct | L_Rbtree_Node
''' </summary>
ReadOnly Property parent as L_Rbtree_Node
	Get
			If Values.parent <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.parent)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC/rbtree.h (83, 28)
'''  Org: [l_int32 color]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property color as Integer
	Get
				Return Values.color
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Rbtree_Node
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rbtree_Node
		Public key as Rb_Type
		Public value as Rb_Type
		Public left as IntPTR
		Public right as IntPTR
		Public parent as IntPTR
		Public color as Integer
	End Class
End Class


#End Region
#Region "SRC/stack.h"
' SRC/stack.h (59, 8)
' Expandable pointer stack for arbitrary void* data. Note that array[n] is the first null ptr in the array
Public Class L_Stack
	Property Pointer as IntPTR
	Private Values as Marshal_L_Stack

''' <summary>
''' Brf: size of ptr array
'''  Loc: SRC/stack.h (61, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of stored elements
'''  Loc: SRC/stack.h (62, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr array
'''  Loc: SRC/stack.h (63, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.n) as IntPTR
		Marshal.Copy(Values.array, _array, 0, values.n)
		Return _array
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: auxiliary stack
'''  Loc: SRC/stack.h (64, 22)
'''  Org: [struct L_Stack * auxstack]
'''  Msh: struct L_Stack * | 2:Struct | L_Stack
''' </summary>
ReadOnly Property auxstack as L_Stack
	Get
			If Values.auxstack <> IntPtr.Zero Then 
		Return New L_Stack(Values.auxstack)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Stack
		Marshal.PtrToStructure (Pointer, Values)
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
' Data structure to hold bitmap fonts and related data
Public Class L_Bmf
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bmf

''' <summary>
''' Brf: pixa of bitmaps for 93 characters
'''  Loc: SRC/bmf.h (47, 19)
'''  Org: [struct Pixa * pixa]
'''  Msh: struct Pixa * | 2:Struct | Pixa
''' </summary>
ReadOnly Property pixa as Pixa
	Get
			If Values.pixa <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: font size (in points at 300 ppi)
'''  Loc: SRC/bmf.h (48, 19)
'''  Org: [l_int32 size]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property size as Integer
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: directory containing font bitmaps
'''  Loc: SRC/bmf.h (49, 19)
'''  Org: [char * directory]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property directory as String
	Get
		If Values.directory <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.directory)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: baseline offset for ascii 33 - 57
'''  Loc: SRC/bmf.h (50, 19)
'''  Org: [l_int32 baseline1]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property baseline1 as Integer
	Get
				Return Values.baseline1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: baseline offset for ascii 58 - 91
'''  Loc: SRC/bmf.h (51, 19)
'''  Org: [l_int32 baseline2]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property baseline2 as Integer
	Get
				Return Values.baseline2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: baseline offset for ascii 93 - 126
'''  Loc: SRC/bmf.h (52, 19)
'''  Org: [l_int32 baseline3]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property baseline3 as Integer
	Get
				Return Values.baseline3
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max height of line of chars
'''  Loc: SRC/bmf.h (53, 19)
'''  Org: [l_int32 lineheight]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property lineheight as Integer
	Get
				Return Values.lineheight
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pixel dist between char bitmaps
'''  Loc: SRC/bmf.h (54, 19)
'''  Org: [l_int32 kernwidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property kernwidth as Integer
	Get
				Return Values.kernwidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pixel dist between word bitmaps
'''  Loc: SRC/bmf.h (55, 19)
'''  Org: [l_int32 spacewidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property spacewidth as Integer
	Get
				Return Values.spacewidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: extra vertical space between text lines
'''  Loc: SRC/bmf.h (56, 19)
'''  Org: [l_int32 vertlinesep]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property vertlinesep as Integer
	Get
				Return Values.vertlinesep
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: table mapping ascii -- bigger  font index
'''  Loc: SRC/bmf.h (57, 19)
'''  Org: [l_int32 * fonttab]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property fonttab as Integer()
	Get
		If Values.fonttab <> IntPtr.Zero Then 
	Dim _fonttab(1 -1) as Integer
	Marshal.Copy(Values.fonttab, _fonttab, 0, _fonttab.Length)
	Return _fonttab
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: table mapping ascii -- bigger  baseline offset
'''  Loc: SRC/bmf.h (58, 19)
'''  Org: [l_int32 * baselinetab]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property baselinetab as Integer()
	Get
		If Values.baselinetab <> IntPtr.Zero Then 
	Dim _baselinetab(1 -1) as Integer
	Marshal.Copy(Values.baselinetab, _baselinetab, 0, _baselinetab.Length)
	Return _baselinetab
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: table mapping ascii -- bigger  char width
'''  Loc: SRC/bmf.h (59, 19)
'''  Org: [l_int32 * widthtab]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property widthtab as Integer()
	Get
		If Values.widthtab <> IntPtr.Zero Then 
	Dim _widthtab(1 -1) as Integer
	Marshal.Copy(Values.widthtab, _widthtab, 0, _widthtab.Length)
	Return _widthtab
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Bmf
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Bmf
		Public pixa as IntPTR
		Public size as Integer
		Public directory as IntPTR
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
' CCBord contains:
Public Class CCBord
	Property Pointer as IntPTR
	Private Values as Marshal_CCBord

''' <summary>
''' Brf: component bitmap (min size)
'''  Loc: SRC/ccbord.h (93, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct | Pix
''' </summary>
ReadOnly Property pix as Pix
	Get
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: regions of each closed curve
'''  Loc: SRC/ccbord.h (94, 26)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct | Boxa
''' </summary>
ReadOnly Property boxa as Boxa
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: initial border pixel locations
'''  Loc: SRC/ccbord.h (95, 26)
'''  Org: [struct Pta * start]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property start as Pta
	Get
			If Values.start <> IntPtr.Zero Then 
		Return New Pta(Values.start)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of handles; start at 1
'''  Loc: SRC/ccbord.h (96, 26)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as Integer
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptaa of chain pixels (local)
'''  Loc: SRC/ccbord.h (97, 26)
'''  Org: [struct Ptaa * local]
'''  Msh: struct Ptaa * | 2:Struct | Ptaa
''' </summary>
ReadOnly Property local as Ptaa
	Get
			If Values.local <> IntPtr.Zero Then 
		Return New Ptaa(Values.local)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptaa of chain pixels (global)
'''  Loc: SRC/ccbord.h (98, 26)
'''  Org: [struct Ptaa * global]
'''  Msh: struct Ptaa * | 2:Struct | Ptaa
''' </summary>
ReadOnly Property _global_ as Ptaa
	Get
			If Values._global_ <> IntPtr.Zero Then 
		Return New Ptaa(Values._global_)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: numaa of chain code (step dir)
'''  Loc: SRC/ccbord.h (99, 26)
'''  Org: [struct Numaa * step]
'''  Msh: struct Numaa * | 2:Struct | Numaa Typedef: Numaa = Numaa
''' </summary>
ReadOnly Property _step_ as Numaa
	Get
			If Values._step_ <> IntPtr.Zero Then 
		Return New Numaa(Values._step_)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pta of single chain (local)
'''  Loc: SRC/ccbord.h (100, 26)
'''  Org: [struct Pta * splocal]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property splocal as Pta
	Get
			If Values.splocal <> IntPtr.Zero Then 
		Return New Pta(Values.splocal)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pta of single chain (global)
'''  Loc: SRC/ccbord.h (101, 26)
'''  Org: [struct Pta * spglobal]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property spglobal as Pta
	Get
			If Values.spglobal <> IntPtr.Zero Then 
		Return New Pta(Values.spglobal)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_CCBord
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of CCBord
Public Class CCBorda
	Property Pointer as IntPTR
	Private Values as Marshal_CCBorda

''' <summary>
''' Brf: input pix (may be null)
'''  Loc: SRC/ccbord.h (108, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct | Pix
''' </summary>
ReadOnly Property pix as Pix
	Get
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: width of pix
'''  Loc: SRC/ccbord.h (109, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height of pix
'''  Loc: SRC/ccbord.h (110, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of ccbord in ptr array
'''  Loc: SRC/ccbord.h (111, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of ccbord ptrs allocated
'''  Loc: SRC/ccbord.h (112, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ccb ptr array
'''  Loc: SRC/ccbord.h (113, 26)
'''  Org: [struct CCBord ** ccb]
'''  Msh: struct CCBord ** | 3:Struct | List (of CCBord) Typedef: CCBord = CCBord
''' </summary>
ReadOnly Property ccb as List (of CCBord)
	Get
		If Values.ccb <> IntPtr.Zero Then
		Dim LST_ccb As New List(Of CCBord)
		Dim ARR_ccb(values.n - 1) As IntPtr
		Marshal.Copy(Values.ccb, ARR_ccb, 0, values.n)
		For Each Entry In ARR_ccb
			LST_ccb.Add(New CCBord(Entry))
		Next
Return LST_ccb
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_CCBorda
		Marshal.PtrToStructure (Pointer, Values)
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
' Data structure to hold a number of Dewarp
Public Class L_Dewarpa
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dewarpa

''' <summary>
''' Brf: size of dewarp ptr array
'''  Loc: SRC/dewarp.h (115, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum page number in array
'''  Loc: SRC/dewarp.h (116, 24)
'''  Org: [l_int32 maxpage]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxpage as Integer
	Get
				Return Values.maxpage
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of ptrs to page dewarp
'''  Loc: SRC/dewarp.h (117, 24)
'''  Org: [struct L_Dewarp ** dewarp]
'''  Msh: struct L_Dewarp ** | 3:Struct | List (of L_Dewarp)
''' </summary>
ReadOnly Property dewarp as List (of L_Dewarp)
	Get
		If Values.dewarp <> IntPtr.Zero Then
		Dim LST_dewarp As New List(Of L_Dewarp)
		Dim ARR_dewarp(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.dewarp, ARR_dewarp, 0, values.nalloc)
		For Each Entry In ARR_dewarp
			LST_dewarp.Add(New L_Dewarp(Entry))
		Next
Return LST_dewarp
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of ptrs to cached dewarps
'''  Loc: SRC/dewarp.h (118, 24)
'''  Org: [struct L_Dewarp ** dewarpcache]
'''  Msh: struct L_Dewarp ** | 3:Struct | List (of L_Dewarp)
''' </summary>
ReadOnly Property dewarpcache as List (of L_Dewarp)
	Get
		If Values.dewarpcache <> IntPtr.Zero Then
		Dim LST_dewarpcache As New List(Of L_Dewarp)
		Dim ARR_dewarpcache(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.dewarpcache, ARR_dewarpcache, 0, values.nalloc)
		For Each Entry In ARR_dewarpcache
			LST_dewarpcache.Add(New L_Dewarp(Entry))
		Next
Return LST_dewarpcache
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: list of page numbers for pages
'''  Loc: SRC/dewarp.h (119, 24)
'''  Org: [struct Numa * namodels]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property namodels as Numa
	Get
			If Values.namodels <> IntPtr.Zero Then 
		Return New Numa(Values.namodels)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: list of page numbers with either
'''  Loc: SRC/dewarp.h (121, 24)
'''  Org: [struct Numa * napages]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property napages as Numa
	Get
			If Values.napages <> IntPtr.Zero Then 
		Return New Numa(Values.napages)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reduction factor of input: 1 or 2
'''  Loc: SRC/dewarp.h (123, 24)
'''  Org: [l_int32 redfactor]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property redfactor as Integer
	Get
				Return Values.redfactor
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: disparity arrays sampling factor
'''  Loc: SRC/dewarp.h (124, 24)
'''  Org: [l_int32 sampling]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sampling as Integer
	Get
				Return Values.sampling
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (125, 24)
'''  Org: [l_int32 minlines]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minlines as Integer
	Get
				Return Values.minlines
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max distance for getting ref page
'''  Loc: SRC/dewarp.h (126, 24)
'''  Org: [l_int32 maxdist]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxdist as Integer
	Get
				Return Values.maxdist
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum abs line curvature,
'''  Loc: SRC/dewarp.h (127, 24)
'''  Org: [l_int32 max_linecurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_linecurv as Integer
	Get
				Return Values.max_linecurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: minimum abs diff line
'''  Loc: SRC/dewarp.h (129, 24)
'''  Org: [l_int32 min_diff_linecurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property min_diff_linecurv as Integer
	Get
				Return Values.min_diff_linecurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum abs diff line
'''  Loc: SRC/dewarp.h (131, 24)
'''  Org: [l_int32 max_diff_linecurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_diff_linecurv as Integer
	Get
				Return Values.max_diff_linecurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (133, 24)
'''  Org: [l_int32 max_edgeslope]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_edgeslope as Integer
	Get
				Return Values.max_edgeslope
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (135, 24)
'''  Org: [l_int32 max_edgecurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_edgecurv as Integer
	Get
				Return Values.max_edgecurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: maximum abs diff left-right
'''  Loc: SRC/dewarp.h (137, 24)
'''  Org: [l_int32 max_diff_edgecurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_diff_edgecurv as Integer
	Get
				Return Values.max_diff_edgecurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: use both disparity arrays if
'''  Loc: SRC/dewarp.h (139, 24)
'''  Org: [l_int32 useboth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property useboth as Integer
	Get
				Return Values.useboth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: if there are multiple columns,
'''  Loc: SRC/dewarp.h (141, 24)
'''  Org: [l_int32 check_columns]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property check_columns as Integer
	Get
				Return Values.check_columns
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: invalid models have been removed
'''  Loc: SRC/dewarp.h (144, 24)
'''  Org: [l_int32 modelsready]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property modelsready as Integer
	Get
				Return Values.modelsready
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Dewarpa
		Marshal.PtrToStructure (Pointer, Values)
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
' Data structure for a single dewarp
Public Class L_Dewarp
	Property Pointer as IntPTR
	Private Values as Marshal_L_Dewarp

''' <summary>
''' Brf: ptr to parent (not owned)
'''  Loc: SRC/dewarp.h (153, 24)
'''  Org: [struct L_Dewarpa * dewa]
'''  Msh: struct L_Dewarpa * | 2:Struct | L_Dewarpa Typedef: L_Dewarpa = L_Dewarpa
''' </summary>
ReadOnly Property dewa as L_Dewarpa
	Get
			If Values.dewa <> IntPtr.Zero Then 
		Return New L_Dewarpa(Values.dewa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: source pix, 1 bpp
'''  Loc: SRC/dewarp.h (154, 24)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct | Pix
''' </summary>
ReadOnly Property pixs as Pix
	Get
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sampled vert disparity array
'''  Loc: SRC/dewarp.h (155, 24)
'''  Org: [struct FPix * sampvdispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property sampvdispar as FPix
	Get
			If Values.sampvdispar <> IntPtr.Zero Then 
		Return New FPix(Values.sampvdispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sampled horiz disparity array
'''  Loc: SRC/dewarp.h (156, 24)
'''  Org: [struct FPix * samphdispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property samphdispar as FPix
	Get
			If Values.samphdispar <> IntPtr.Zero Then 
		Return New FPix(Values.samphdispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sampled slope h-disparity array
'''  Loc: SRC/dewarp.h (157, 24)
'''  Org: [struct FPix * sampydispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property sampydispar as FPix
	Get
			If Values.sampydispar <> IntPtr.Zero Then 
		Return New FPix(Values.sampydispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: full vert disparity array
'''  Loc: SRC/dewarp.h (158, 24)
'''  Org: [struct FPix * fullvdispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property fullvdispar as FPix
	Get
			If Values.fullvdispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullvdispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: full horiz disparity array
'''  Loc: SRC/dewarp.h (159, 24)
'''  Org: [struct FPix * fullhdispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property fullhdispar as FPix
	Get
			If Values.fullhdispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullhdispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: full slope h-disparity array
'''  Loc: SRC/dewarp.h (160, 24)
'''  Org: [struct FPix * fullydispar]
'''  Msh: struct FPix * | 2:Struct | FPix
''' </summary>
ReadOnly Property fullydispar as FPix
	Get
			If Values.fullydispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullydispar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sorted y val of midpoint each line
'''  Loc: SRC/dewarp.h (161, 24)
'''  Org: [struct Numa * namidys]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property namidys as Numa
	Get
			If Values.namidys <> IntPtr.Zero Then 
		Return New Numa(Values.namidys)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sorted curvature of each line
'''  Loc: SRC/dewarp.h (162, 24)
'''  Org: [struct Numa * nacurves]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nacurves as Numa
	Get
			If Values.nacurves <> IntPtr.Zero Then 
		Return New Numa(Values.nacurves)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: width of source image
'''  Loc: SRC/dewarp.h (163, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height of source image
'''  Loc: SRC/dewarp.h (164, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: page number; important for reuse
'''  Loc: SRC/dewarp.h (165, 24)
'''  Org: [l_int32 pageno]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property pageno as Integer
	Get
				Return Values.pageno
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sampling factor of disparity arrays
'''  Loc: SRC/dewarp.h (166, 24)
'''  Org: [l_int32 sampling]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sampling as Integer
	Get
				Return Values.sampling
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reduction factor of pixs: 1 or 2
'''  Loc: SRC/dewarp.h (167, 24)
'''  Org: [l_int32 redfactor]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property redfactor as Integer
	Get
				Return Values.redfactor
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (168, 24)
'''  Org: [l_int32 minlines]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minlines as Integer
	Get
				Return Values.minlines
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of long lines found
'''  Loc: SRC/dewarp.h (169, 24)
'''  Org: [l_int32 nlines]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nlines as Integer
	Get
				Return Values.nlines
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min line curvature in micro-units
'''  Loc: SRC/dewarp.h (170, 24)
'''  Org: [l_int32 mincurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property mincurv as Integer
	Get
				Return Values.mincurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max line curvature in micro-units
'''  Loc: SRC/dewarp.h (171, 24)
'''  Org: [l_int32 maxcurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxcurv as Integer
	Get
				Return Values.maxcurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: left edge slope in milli-units
'''  Loc: SRC/dewarp.h (172, 24)
'''  Org: [l_int32 leftslope]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property leftslope as Integer
	Get
				Return Values.leftslope
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: right edge slope in milli-units
'''  Loc: SRC/dewarp.h (173, 24)
'''  Org: [l_int32 rightslope]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rightslope as Integer
	Get
				Return Values.rightslope
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: left edge curvature in micro-units
'''  Loc: SRC/dewarp.h (174, 24)
'''  Org: [l_int32 leftcurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property leftcurv as Integer
	Get
				Return Values.leftcurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: right edge curvature in micro-units
'''  Loc: SRC/dewarp.h (175, 24)
'''  Org: [l_int32 rightcurv]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rightcurv as Integer
	Get
				Return Values.rightcurv
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of sampling pts in x-dir
'''  Loc: SRC/dewarp.h (176, 24)
'''  Org: [l_int32 nx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nx as Integer
	Get
				Return Values.nx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of sampling pts in y-dir
'''  Loc: SRC/dewarp.h (177, 24)
'''  Org: [l_int32 ny]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ny as Integer
	Get
				Return Values.ny
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 0 if normal; 1 if has a refpage
'''  Loc: SRC/dewarp.h (178, 24)
'''  Org: [l_int32 hasref]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property hasref as Integer
	Get
				Return Values.hasref
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: page with disparity model to use
'''  Loc: SRC/dewarp.h (179, 24)
'''  Org: [l_int32 refpage]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property refpage as Integer
	Get
				Return Values.refpage
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sets to 1 if vert disparity builds
'''  Loc: SRC/dewarp.h (180, 24)
'''  Org: [l_int32 vsuccess]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property vsuccess as Integer
	Get
				Return Values.vsuccess
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sets to 1 if horiz disparity builds
'''  Loc: SRC/dewarp.h (181, 24)
'''  Org: [l_int32 hsuccess]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property hsuccess as Integer
	Get
				Return Values.hsuccess
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sets to 1 if slope disparity builds
'''  Loc: SRC/dewarp.h (182, 24)
'''  Org: [l_int32 ysuccess]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ysuccess as Integer
	Get
				Return Values.ysuccess
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sets to 1 if valid vert disparity
'''  Loc: SRC/dewarp.h (183, 24)
'''  Org: [l_int32 vvalid]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property vvalid as Integer
	Get
				Return Values.vvalid
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sets to 1 if valid horiz disparity
'''  Loc: SRC/dewarp.h (184, 24)
'''  Org: [l_int32 hvalid]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property hvalid as Integer
	Get
				Return Values.hvalid
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: if 1, skip horiz disparity
'''  Loc: SRC/dewarp.h (185, 24)
'''  Org: [l_int32 skip_horiz]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property skip_horiz as Integer
	Get
				Return Values.skip_horiz
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 if debug output requested
'''  Loc: SRC/dewarp.h (187, 24)
'''  Org: [l_int32 debug]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property debug as Integer
	Get
				Return Values.debug
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Dewarp
		Marshal.PtrToStructure (Pointer, Values)
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
' Data structure for generating gnuplot files
Public Class GPlot
	Property Pointer as IntPTR
	Private Values as Marshal_GPlot

''' <summary>
''' Brf: for cmd, data, output
'''  Loc: SRC/gplot.h (77, 20)
'''  Org: [char * rootname]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property rootname as String
	Get
		If Values.rootname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.rootname)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: command file name
'''  Loc: SRC/gplot.h (78, 20)
'''  Org: [char * cmdname]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property cmdname as String
	Get
		If Values.cmdname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmdname)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: command file contents
'''  Loc: SRC/gplot.h (79, 20)
'''  Org: [struct Sarray * cmddata]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property cmddata as Sarray
	Get
			If Values.cmddata <> IntPtr.Zero Then 
		Return New Sarray(Values.cmddata)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: data file names
'''  Loc: SRC/gplot.h (80, 20)
'''  Org: [struct Sarray * datanames]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property datanames as Sarray
	Get
			If Values.datanames <> IntPtr.Zero Then 
		Return New Sarray(Values.datanames)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: plot data (1 string/file)
'''  Loc: SRC/gplot.h (81, 20)
'''  Org: [struct Sarray * plotdata]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property plotdata as Sarray
	Get
			If Values.plotdata <> IntPtr.Zero Then 
		Return New Sarray(Values.plotdata)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: title for each individual plot
'''  Loc: SRC/gplot.h (82, 20)
'''  Org: [struct Sarray * plottitles]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property plottitles as Sarray
	Get
			If Values.plottitles <> IntPtr.Zero Then 
		Return New Sarray(Values.plottitles)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: plot style for individual plots
'''  Loc: SRC/gplot.h (83, 20)
'''  Org: [struct Numa * plotstyles]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property plotstyles as Numa
	Get
			If Values.plotstyles <> IntPtr.Zero Then 
		Return New Numa(Values.plotstyles)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: current number of plots
'''  Loc: SRC/gplot.h (84, 20)
'''  Org: [l_int32 nplots]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nplots as Integer
	Get
				Return Values.nplots
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: output file name
'''  Loc: SRC/gplot.h (85, 20)
'''  Org: [char * outname]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property outname as String
	Get
		If Values.outname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.outname)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: GPLOT_OUTPUT values
'''  Loc: SRC/gplot.h (86, 20)
'''  Org: [l_int32 outformat]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property outformat as Integer
	Get
				Return Values.outformat
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: GPLOT_SCALING values
'''  Loc: SRC/gplot.h (87, 20)
'''  Org: [l_int32 scaling]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property scaling as Integer
	Get
				Return Values.scaling
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: optional
'''  Loc: SRC/gplot.h (88, 20)
'''  Org: [char * title]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property title as String
	Get
		If Values.title <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.title)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: optional x axis label
'''  Loc: SRC/gplot.h (89, 20)
'''  Org: [char * xlabel]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property xlabel as String
	Get
		If Values.xlabel <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.xlabel)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: optional y axis label
'''  Loc: SRC/gplot.h (90, 20)
'''  Org: [char * ylabel]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property ylabel as String
	Get
		If Values.ylabel <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.ylabel)
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_GPlot
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_GPlot
		Public rootname as IntPTR
		Public cmdname as IntPTR
		Public cmddata as IntPTR
		Public datanames as IntPTR
		Public plotdata as IntPTR
		Public plottitles as IntPTR
		Public plotstyles as IntPTR
		Public nplots as Integer
		Public outname as IntPTR
		Public outformat as Integer
		Public scaling as Integer
		Public title as IntPTR
		Public xlabel as IntPTR
		Public ylabel as IntPTR
	End Class
End Class


#End Region
#Region "SRC/imageio.h"
' SRC/imageio.h (166, 8)
' Compressed image data
Public Class L_Compressed_Data
	Property Pointer as IntPTR
	Private Values as Marshal_L_Compressed_Data

''' <summary>
''' Brf: encoding type: L_JPEG_ENCODE, etc
'''  Loc: SRC/imageio.h (168, 24)
'''  Org: [l_int32 type]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property type as Integer
	Get
				Return Values.type
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: gzipped raster data
'''  Loc: SRC/imageio.h (169, 24)
'''  Org: [l_uint8 * datacomp]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property datacomp as Byte()
	Get
		If Values.datacomp <> IntPtr.Zero Then 
	Dim _datacomp(1 -1) as Byte
	Marshal.Copy(Values.datacomp, _datacomp, 0, _datacomp.Length)
	Return _datacomp
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of compressed bytes
'''  Loc: SRC/imageio.h (170, 24)
'''  Org: [size_t nbytescomp]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property nbytescomp as UInteger
	Get
				Return Values.nbytescomp
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ascii85-encoded gzipped raster data
'''  Loc: SRC/imageio.h (171, 24)
'''  Org: [char * data85]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property data85 as String
	Get
		If Values.data85 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.data85)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of ascii85 encoded bytes
'''  Loc: SRC/imageio.h (172, 24)
'''  Org: [size_t nbytes85]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property nbytes85 as UInteger
	Get
				Return Values.nbytes85
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ascii85-encoded uncompressed cmap
'''  Loc: SRC/imageio.h (173, 24)
'''  Org: [char * cmapdata85]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property cmapdata85 as String
	Get
		If Values.cmapdata85 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmapdata85)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: hex pdf array for the cmap
'''  Loc: SRC/imageio.h (174, 24)
'''  Org: [char * cmapdatahex]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property cmapdatahex as String
	Get
		If Values.cmapdatahex <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmapdatahex)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of colors in cmap
'''  Loc: SRC/imageio.h (175, 24)
'''  Org: [l_int32 ncolors]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ncolors as Integer
	Get
				Return Values.ncolors
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image width
'''  Loc: SRC/imageio.h (176, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image height
'''  Loc: SRC/imageio.h (177, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: bits/sample; typ. 1, 2, 4 or 8
'''  Loc: SRC/imageio.h (178, 24)
'''  Org: [l_int32 bps]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bps as Integer
	Get
				Return Values.bps
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: samples/pixel; typ. 1 or 3
'''  Loc: SRC/imageio.h (179, 24)
'''  Org: [l_int32 spp]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property spp as Integer
	Get
				Return Values.spp
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: tiff g4 photometry
'''  Loc: SRC/imageio.h (180, 24)
'''  Org: [l_int32 minisblack]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minisblack as Integer
	Get
				Return Values.minisblack
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: flate data has PNG predictors
'''  Loc: SRC/imageio.h (181, 24)
'''  Org: [l_int32 predictor]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property predictor as Integer
	Get
				Return Values.predictor
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of uncompressed raster bytes
'''  Loc: SRC/imageio.h (182, 24)
'''  Org: [size_t nbytes]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property nbytes as UInteger
	Get
				Return Values.nbytes
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: resolution (ppi)
'''  Loc: SRC/imageio.h (183, 24)
'''  Org: [l_int32 res]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property res as Integer
	Get
				Return Values.res
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Compressed_Data
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Compressed_Data
		Public type as Integer
		Public datacomp as IntPTR
		Public nbytescomp as UInteger
		Public data85 as IntPTR
		Public nbytes85 as UInteger
		Public cmapdata85 as IntPTR
		Public cmapdatahex as IntPTR
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
' Intermediate pdf generation data
Public Class L_Pdf_Data
	Property Pointer as IntPTR
	Private Values as Marshal_L_Pdf_Data

''' <summary>
''' Brf: optional title for pdf
'''  Loc: SRC/imageio.h (213, 24)
'''  Org: [char * title]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property title as String
	Get
		If Values.title <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.title)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of images
'''  Loc: SRC/imageio.h (214, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of colormaps
'''  Loc: SRC/imageio.h (215, 24)
'''  Org: [l_int32 ncmap]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ncmap as Integer
	Get
				Return Values.ncmap
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of compressed image data
'''  Loc: SRC/imageio.h (216, 24)
'''  Org: [struct L_Ptra * cida]
'''  Msh: struct L_Ptra * | 2:Struct | L_Ptra Typedef: L_Ptra = L_Ptra
''' </summary>
ReadOnly Property cida as L_Ptra
	Get
			If Values.cida <> IntPtr.Zero Then 
		Return New L_Ptra(Values.cida)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: %PDF-1.2 id string
'''  Loc: SRC/imageio.h (217, 24)
'''  Org: [char * id]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property id as String
	Get
		If Values.id <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.id)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: catalog string
'''  Loc: SRC/imageio.h (218, 24)
'''  Org: [char * obj1]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property obj1 as String
	Get
		If Values.obj1 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj1)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: metadata string
'''  Loc: SRC/imageio.h (219, 24)
'''  Org: [char * obj2]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property obj2 as String
	Get
		If Values.obj2 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj2)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pages string
'''  Loc: SRC/imageio.h (220, 24)
'''  Org: [char * obj3]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property obj3 as String
	Get
		If Values.obj3 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj3)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: page string (variable data)
'''  Loc: SRC/imageio.h (221, 24)
'''  Org: [char * obj4]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property obj4 as String
	Get
		If Values.obj4 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj4)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: content string (variable data)
'''  Loc: SRC/imageio.h (222, 24)
'''  Org: [char * obj5]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property obj5 as String
	Get
		If Values.obj5 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj5)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: post-binary-stream string
'''  Loc: SRC/imageio.h (223, 24)
'''  Org: [char * poststream]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property poststream as String
	Get
		If Values.poststream <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.poststream)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: trailer string (variable data)
'''  Loc: SRC/imageio.h (224, 24)
'''  Org: [char * trailer]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property trailer as String
	Get
		If Values.trailer <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.trailer)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: store (xpt, ypt) array
'''  Loc: SRC/imageio.h (225, 24)
'''  Org: [struct Pta * xy]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property xy as Pta
	Get
			If Values.xy <> IntPtr.Zero Then 
		Return New Pta(Values.xy)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: store (wpt, hpt) array
'''  Loc: SRC/imageio.h (226, 24)
'''  Org: [struct Pta * wh]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property wh as Pta
	Get
			If Values.wh <> IntPtr.Zero Then 
		Return New Pta(Values.wh)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: bounding region for all images
'''  Loc: SRC/imageio.h (227, 24)
'''  Org: [struct Box * mediabox]
'''  Msh: struct Box * | 2:Struct | Box
''' </summary>
ReadOnly Property mediabox as Box
	Get
			If Values.mediabox <> IntPtr.Zero Then 
		Return New Box(Values.mediabox)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pre-binary-stream xobject strings
'''  Loc: SRC/imageio.h (228, 24)
'''  Org: [struct Sarray * saprex]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property saprex as Sarray
	Get
			If Values.saprex <> IntPtr.Zero Then 
		Return New Sarray(Values.saprex)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: colormap pdf object strings
'''  Loc: SRC/imageio.h (229, 24)
'''  Org: [struct Sarray * sacmap]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property sacmap as Sarray
	Get
			If Values.sacmap <> IntPtr.Zero Then 
		Return New Sarray(Values.sacmap)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sizes of each pdf string object
'''  Loc: SRC/imageio.h (230, 24)
'''  Org: [struct L_Dna * objsize]
'''  Msh: struct L_Dna * | 2:Struct | L_Dna Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property objsize as L_Dna
	Get
			If Values.objsize <> IntPtr.Zero Then 
		Return New L_Dna(Values.objsize)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: location of each pdf string object
'''  Loc: SRC/imageio.h (231, 24)
'''  Org: [struct L_Dna * objloc]
'''  Msh: struct L_Dna * | 2:Struct | L_Dna Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property objloc as L_Dna
	Get
			If Values.objloc <> IntPtr.Zero Then 
		Return New L_Dna(Values.objloc)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: location of xref
'''  Loc: SRC/imageio.h (232, 24)
'''  Org: [l_int32 xrefloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xrefloc as Integer
	Get
				Return Values.xrefloc
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Pdf_Data
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Pdf_Data
		Public title as IntPTR
		Public n as Integer
		Public ncmap as Integer
		Public cida as IntPTR
		Public id as IntPTR
		Public obj1 as IntPTR
		Public obj2 as IntPTR
		Public obj3 as IntPTR
		Public obj4 as IntPTR
		Public obj5 as IntPTR
		Public poststream as IntPTR
		Public trailer as IntPTR
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
' The JbClasser struct holds all the data accumulated during the classification process that can be used for a compressed jbig2-type representation of a set of images. This is created in an initialization process and added to as the selected components on each successive page are analyzed.
Public Class JbClasser
	Property Pointer as IntPTR
	Private Values as Marshal_JbClasser

''' <summary>
''' Brf: input page image file names
'''  Loc: SRC/jbclass.h (49, 22)
'''  Org: [struct Sarray * safiles]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property safiles as Sarray
	Get
			If Values.safiles <> IntPtr.Zero Then 
		Return New Sarray(Values.safiles)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: JB_RANKHAUS, JB_CORRELATION
'''  Loc: SRC/jbclass.h (50, 22)
'''  Org: [l_int32 method]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property method as Integer
	Get
				Return Values.method
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: JB_CONN_COMPS, JB_CHARACTERS or
'''  Loc: SRC/jbclass.h (51, 22)
'''  Org: [l_int32 components]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property components as Integer
	Get
				Return Values.components
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max component width allowed
'''  Loc: SRC/jbclass.h (53, 22)
'''  Org: [l_int32 maxwidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxwidth as Integer
	Get
				Return Values.maxwidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max component height allowed
'''  Loc: SRC/jbclass.h (54, 22)
'''  Org: [l_int32 maxheight]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxheight as Integer
	Get
				Return Values.maxheight
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of pages already processed
'''  Loc: SRC/jbclass.h (55, 22)
'''  Org: [l_int32 npages]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property npages as Integer
	Get
				Return Values.npages
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number components already processed
'''  Loc: SRC/jbclass.h (56, 22)
'''  Org: [l_int32 baseindex]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property baseindex as Integer
	Get
				Return Values.baseindex
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of components on each page
'''  Loc: SRC/jbclass.h (58, 22)
'''  Org: [struct Numa * nacomps]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nacomps as Numa
	Get
			If Values.nacomps <> IntPtr.Zero Then 
		Return New Numa(Values.nacomps)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of square struct elem for haus
'''  Loc: SRC/jbclass.h (59, 22)
'''  Org: [l_int32 sizehaus]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sizehaus as Integer
	Get
				Return Values.sizehaus
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: rank val of haus match, each way
'''  Loc: SRC/jbclass.h (60, 22)
'''  Org: [l_float32 rankhaus]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property rankhaus as Single
	Get
				Return Values.rankhaus
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: thresh value for correlation score
'''  Loc: SRC/jbclass.h (61, 22)
'''  Org: [l_float32 thresh]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property thresh as Single
	Get
				Return Values.thresh
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: corrects thresh value for heaver
'''  Loc: SRC/jbclass.h (62, 22)
'''  Org: [l_float32 weightfactor]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property weightfactor as Single
	Get
				Return Values.weightfactor
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: w * h of each template, without
'''  Loc: SRC/jbclass.h (64, 22)
'''  Org: [struct Numa * naarea]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naarea as Numa
	Get
			If Values.naarea <> IntPtr.Zero Then 
		Return New Numa(Values.naarea)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max width of original src images
'''  Loc: SRC/jbclass.h (66, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max height of original src images
'''  Loc: SRC/jbclass.h (67, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: current number of classes
'''  Loc: SRC/jbclass.h (68, 22)
'''  Org: [l_int32 nclass]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nclass as Integer
	Get
				Return Values.nclass
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: If zero, pixaa isn't filled
'''  Loc: SRC/jbclass.h (69, 22)
'''  Org: [l_int32 keep_pixaa]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property keep_pixaa as Integer
	Get
				Return Values.keep_pixaa
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: instances for each class; unbordered
'''  Loc: SRC/jbclass.h (70, 22)
'''  Org: [struct Pixaa * pixaa]
'''  Msh: struct Pixaa * | 2:Struct | Pixaa
''' </summary>
ReadOnly Property pixaa as Pixaa
	Get
			If Values.pixaa <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: templates for each class; bordered
'''  Loc: SRC/jbclass.h (71, 22)
'''  Org: [struct Pixa * pixat]
'''  Msh: struct Pixa * | 2:Struct | Pixa
''' </summary>
ReadOnly Property pixat as Pixa
	Get
			If Values.pixat <> IntPtr.Zero Then 
		Return New Pixa(Values.pixat)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: templates for each class; bordered
'''  Loc: SRC/jbclass.h (73, 22)
'''  Org: [struct Pixa * pixatd]
'''  Msh: struct Pixa * | 2:Struct | Pixa
''' </summary>
ReadOnly Property pixatd as Pixa
	Get
			If Values.pixatd <> IntPtr.Zero Then 
		Return New Pixa(Values.pixatd)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Hash table to find templates by size
'''  Loc: SRC/jbclass.h (75, 23)
'''  Org: [struct L_DnaHash * dahash]
'''  Msh: struct L_DnaHash * | 2:Struct | L_DnaHash Typedef: L_DnaHash = L_DnaHash
''' </summary>
ReadOnly Property dahash as L_DnaHash
	Get
			If Values.dahash <> IntPtr.Zero Then 
		Return New L_DnaHash(Values.dahash)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: fg areas of undilated templates;
'''  Loc: SRC/jbclass.h (76, 22)
'''  Org: [struct Numa * nafgt]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nafgt as Numa
	Get
			If Values.nafgt <> IntPtr.Zero Then 
		Return New Numa(Values.nafgt)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of all bordered cc
'''  Loc: SRC/jbclass.h (78, 22)
'''  Org: [struct Pta * ptac]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property ptac as Pta
	Get
			If Values.ptac <> IntPtr.Zero Then 
		Return New Pta(Values.ptac)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of all bordered template cc
'''  Loc: SRC/jbclass.h (79, 22)
'''  Org: [struct Pta * ptact]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property ptact as Pta
	Get
			If Values.ptact <> IntPtr.Zero Then 
		Return New Pta(Values.ptact)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (80, 22)
'''  Org: [struct Numa * naclass]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naclass as Numa
	Get
			If Values.naclass <> IntPtr.Zero Then 
		Return New Numa(Values.naclass)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (81, 22)
'''  Org: [struct Numa * napage]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property napage as Numa
	Get
			If Values.napage <> IntPtr.Zero Then 
		Return New Numa(Values.napage)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (82, 22)
'''  Org: [struct Pta * ptaul]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property ptaul as Pta
	Get
			If Values.ptaul <> IntPtr.Zero Then 
		Return New Pta(Values.ptaul)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: similar to ptaul, but for LL corners
'''  Loc: SRC/jbclass.h (85, 22)
'''  Org: [struct Pta * ptall]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property ptall as Pta
	Get
			If Values.ptall <> IntPtr.Zero Then 
		Return New Pta(Values.ptall)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_JbClasser
		Marshal.PtrToStructure (Pointer, Values)
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
' The JbData struct holds all the data required for the compressed jbig-type representation of a set of images. The data can be written to file, read back, and used to regenerate an approximate version of the original, which differs in two ways from the original: (1) It uses a template image for each c.c. instead of the original instance, for each occurrence on each page. (2) It discards components with either a height or width larger than the maximuma, given here by the lattice dimensions used for storing the templates.
Public Class JbData
	Property Pointer as IntPTR
	Private Values as Marshal_JbData

''' <summary>
''' Brf: template composite for all classes
'''  Loc: SRC/jbclass.h (106, 22)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct | Pix
''' </summary>
ReadOnly Property pix as Pix
	Get
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of pages
'''  Loc: SRC/jbclass.h (107, 22)
'''  Org: [l_int32 npages]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property npages as Integer
	Get
				Return Values.npages
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max width of original page images
'''  Loc: SRC/jbclass.h (108, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max height of original page images
'''  Loc: SRC/jbclass.h (109, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of classes
'''  Loc: SRC/jbclass.h (110, 22)
'''  Org: [l_int32 nclass]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nclass as Integer
	Get
				Return Values.nclass
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: lattice width for template composite
'''  Loc: SRC/jbclass.h (111, 22)
'''  Org: [l_int32 latticew]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property latticew as Integer
	Get
				Return Values.latticew
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: lattice height for template composite
'''  Loc: SRC/jbclass.h (112, 22)
'''  Org: [l_int32 latticeh]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property latticeh as Integer
	Get
				Return Values.latticeh
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (113, 22)
'''  Org: [struct Numa * naclass]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naclass as Numa
	Get
			If Values.naclass <> IntPtr.Zero Then 
		Return New Numa(Values.naclass)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (114, 22)
'''  Org: [struct Numa * napage]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property napage as Numa
	Get
			If Values.napage <> IntPtr.Zero Then 
		Return New Numa(Values.napage)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (115, 22)
'''  Org: [struct Pta * ptaul]
'''  Msh: struct Pta * | 2:Struct | Pta
''' </summary>
ReadOnly Property ptaul as Pta
	Get
			If Values.ptaul <> IntPtr.Zero Then 
		Return New Pta(Values.ptaul)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_JbData
		Marshal.PtrToStructure (Pointer, Values)
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
' Selection
Public Class Sel
	Property Pointer as IntPTR
	Private Values as Marshal_Sel

''' <summary>
''' Brf: sel height
'''  Loc: SRC/morph.h (64, 19)
'''  Org: [l_int32 sy]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sy as Integer
	Get
				Return Values.sy
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sel width
'''  Loc: SRC/morph.h (65, 19)
'''  Org: [l_int32 sx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sx as Integer
	Get
				Return Values.sx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y location of sel origin
'''  Loc: SRC/morph.h (66, 19)
'''  Org: [l_int32 cy]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property cy as Integer
	Get
				Return Values.cy
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x location of sel origin
'''  Loc: SRC/morph.h (67, 19)
'''  Org: [l_int32 cx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property cx as Integer
	Get
				Return Values.cx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: {0,1,2}; data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (68, 19)
'''  Org: [l_int32 ** data]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
''' </summary>
ReadOnly Property data as List (of Integer())
	Get
		Dim _Data1(sy - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(sx - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: used to find sel by name
'''  Loc: SRC/morph.h (69, 19)
'''  Org: [char * name]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property name as String
	Get
		If Values.name <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.name)
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Sel
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Sel
		Public sy as Integer
		Public sx as Integer
		Public cy as Integer
		Public cx as Integer
		Public data as IntPTR
		Public name as IntPTR
	End Class
End Class


' SRC/morph.h (74, 8)
' Array of Sel
Public Class Sela
	Property Pointer as IntPTR
	Private Values as Marshal_Sela

''' <summary>
''' Brf: number of sel actually stored
'''  Loc: SRC/morph.h (76, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of allocated ptr array
'''  Loc: SRC/morph.h (77, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: sel ptr array
'''  Loc: SRC/morph.h (78, 22)
'''  Org: [struct Sel ** sel]
'''  Msh: struct Sel ** | 3:Struct | List (of Sel) Typedef: Sel = Sel
''' </summary>
ReadOnly Property sel as List (of Sel)
	Get
		If Values.sel <> IntPtr.Zero Then
		Dim LST_sel As New List(Of Sel)
		Dim ARR_sel(values.n - 1) As IntPtr
		Marshal.Copy(Values.sel, ARR_sel, 0, values.n)
		For Each Entry In ARR_sel
			LST_sel.Add(New Sel(Entry))
		Next
Return LST_sel
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Sela
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Sela
		Public n as Integer
		Public nalloc as Integer
		Public sel as IntPTR
	End Class
End Class


' SRC/morph.h (89, 8)
' Kernel
Public Class L_Kernel
	Property Pointer as IntPTR
	Private Values as Marshal_L_Kernel

''' <summary>
''' Brf: kernel height
'''  Loc: SRC/morph.h (91, 19)
'''  Org: [l_int32 sy]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sy as Integer
	Get
				Return Values.sy
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: kernel width
'''  Loc: SRC/morph.h (92, 19)
'''  Org: [l_int32 sx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sx as Integer
	Get
				Return Values.sx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y location of kernel origin
'''  Loc: SRC/morph.h (93, 19)
'''  Org: [l_int32 cy]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property cy as Integer
	Get
				Return Values.cy
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x location of kernel origin
'''  Loc: SRC/morph.h (94, 19)
'''  Org: [l_int32 cx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property cx as Integer
	Get
				Return Values.cx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (95, 19)
'''  Org: [l_float32 ** data]
'''  Msh: l_float32 ** | 3:Float | List (of Single())
''' </summary>
ReadOnly Property data as List (of Single())
	Get
		Dim _Data1(1 - 1) As Single
Dim _DataFin As New List(Of Single())
Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Single
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Kernel
		Marshal.PtrToStructure (Pointer, Values)
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
' Basic Pix
Public Class Pix
	Property Pointer as IntPTR
	Private Values as Marshal_Pix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (136, 26)
'''  Org: [l_uint32 w]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property w as UInteger
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (137, 26)
'''  Org: [l_uint32 h]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property h as UInteger
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: depth in bits (bpp)
'''  Loc: SRC/pix.h (138, 26)
'''  Org: [l_uint32 d]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property d as UInteger
	Get
				Return Values.d
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of samples per pixel
'''  Loc: SRC/pix.h (139, 26)
'''  Org: [l_uint32 spp]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property spp as UInteger
	Get
				Return Values.spp
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (140, 26)
'''  Org: [l_uint32 wpl]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property wpl as UInteger
	Get
				Return Values.wpl
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (141, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (142, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xres as Integer
	Get
				Return Values.xres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (144, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yres as Integer
	Get
				Return Values.yres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: input file format, IFF_*
'''  Loc: SRC/pix.h (146, 26)
'''  Org: [l_int32 informat]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property informat as IFF
	Get
				Return Values.informat
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: special instructions for I/O, etc
'''  Loc: SRC/pix.h (147, 26)
'''  Org: [l_int32 special]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property special as Integer
	Get
				Return Values.special
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: text string associated with pix
'''  Loc: SRC/pix.h (148, 26)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property text as String
	Get
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: colormap (may be null)
'''  Loc: SRC/pix.h (149, 26)
'''  Org: [struct PixColormap * colormap]
'''  Msh: struct PixColormap * | 2:Struct | PixColormap
''' </summary>
ReadOnly Property colormap as PixColormap
	Get
			If Values.colormap <> IntPtr.Zero Then 
		Return New PixColormap(Values.colormap)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the image data
'''  Loc: SRC/pix.h (150, 26)
'''  Org: [l_uint32 * data]
'''  Msh: l_uint32 * | 2:UInt | Byte() ... UInt = 4 Byte * Len)
''' </summary>
ReadOnly Property data as Byte()
	Get
            Dim _data((w * h * (d / 8)) - 1) As Byte
Marshal.Copy(Values.data, _data, 0, _data.Length)
Return _data
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Pix
		Marshal.PtrToStructure (Pointer, Values)
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
		Public text as IntPTR
		Public colormap as IntPTR
		Public data as IntPTR
	End Class
End Class


' SRC/pix.h (155, 8)
' Colormap of a Pix
Public Class PixColormap
	Property Pointer as IntPTR
	Private Values as Marshal_PixColormap

''' <summary>
''' Brf: colormap table (array of RGBA_QUAD)
'''  Loc: SRC/pix.h (157, 22)
'''  Org: [void * array]
'''  Msh: void * | 2:Void | IntPTR ... Pointer auf Object = IntPTR
''' </summary>
    ReadOnly Property array As List(Of RGBA_Quad)
        Get
            If Values.array <> IntPtr.Zero Then
                Dim LST((n * 4) - 1) As Byte
                Marshal.Copy(Values.array, LST, 0, LST.Length)
                Return New RGBA_Quad(LST).QuadList
            End If
            Return Nothing
        End Get
    End Property

''' <summary>
''' Brf: of pix (1, 2, 4 or 8 bpp)
'''  Loc: SRC/pix.h (158, 22)
'''  Org: [l_int32 depth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property depth as Integer
	Get
				Return Values.depth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of color entries allocated
'''  Loc: SRC/pix.h (159, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of color entries used
'''  Loc: SRC/pix.h (160, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixColormap
		Marshal.PtrToStructure (Pointer, Values)
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
' Colormap table entry (after the BMP version). Note that the BMP format stores the colormap table exactly as it appears here, with color samples being stored sequentially, in the order (b,g,r,a).
Public Class RGBA_Quad
	Property Pointer as IntPTR
	Private Values as Marshal_RGBA_Quad

''' <summary>
''' Brf: blue value
'''  Loc: SRC/pix.h (171, 17)
'''  Org: [l_uint8 blue]
'''  Msh: l_uint8 = bigger  1:*
''' </summary>
    ReadOnly Property blue As Byte
        Get
            Return Values.blue
        End Get
    End Property

''' <summary>
''' Brf: green value
'''  Loc: SRC/pix.h (172, 17)
'''  Org: [l_uint8 green]
'''  Msh: l_uint8 = bigger  1:*
''' </summary>
ReadOnly Property green as Byte
	Get
				Return Values.green
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: red value
'''  Loc: SRC/pix.h (173, 17)
'''  Org: [l_uint8 red]
'''  Msh: l_uint8 = bigger  1:*
''' </summary>
ReadOnly Property red as Byte
	Get
				Return Values.red
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: alpha value
'''  Loc: SRC/pix.h (174, 17)
'''  Org: [l_uint8 alpha]
'''  Msh: l_uint8 = bigger  1:*
''' </summary>
ReadOnly Property alpha as Byte
	Get
				Return Values.alpha
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_RGBA_Quad
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of pix
Public Class Pixa
	Property Pointer as IntPTR
	Private Values as Marshal_Pixa

''' <summary>
''' Brf: number of Pix in ptr array
'''  Loc: SRC/pix.h (456, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of Pix ptrs allocated
'''  Loc: SRC/pix.h (457, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (458, 25)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the array of ptrs to pix
'''  Loc: SRC/pix.h (459, 25)
'''  Org: [struct Pix ** pix]
'''  Msh: struct Pix ** | 3:Struct | List (of Pix) Typedef: Pix = Pix
''' </summary>
ReadOnly Property pix as List (of Pix)
	Get
		If Values.pix <> IntPtr.Zero Then
		Dim LST_pix As New List(Of Pix)
		Dim ARR_pix(values.n - 1) As IntPtr
		Marshal.Copy(Values.pix, ARR_pix, 0, values.n)
		For Each Entry In ARR_pix
			LST_pix.Add(New Pix(Entry))
		Next
Return LST_pix
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (460, 25)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct | Boxa
''' </summary>
ReadOnly Property boxa as Boxa
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Pixa
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of arrays of pix
Public Class Pixaa
	Property Pointer as IntPTR
	Private Values as Marshal_Pixaa

''' <summary>
''' Brf: number of Pixa in ptr array
'''  Loc: SRC/pix.h (467, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of Pixa ptrs allocated
'''  Loc: SRC/pix.h (468, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of ptrs to pixa
'''  Loc: SRC/pix.h (469, 25)
'''  Org: [struct Pixa ** pixa]
'''  Msh: struct Pixa ** | 3:Struct | List (of Pixa) Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixa as List (of Pixa)
	Get
		If Values.pixa <> IntPtr.Zero Then
		Dim LST_pixa As New List(Of Pixa)
		Dim ARR_pixa(values.n - 1) As IntPtr
		Marshal.Copy(Values.pixa, ARR_pixa, 0, values.n)
		For Each Entry In ARR_pixa
			LST_pixa.Add(New Pixa(Entry))
		Next
Return LST_pixa
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (470, 25)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct | Boxa
''' </summary>
ReadOnly Property boxa as Boxa
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Pixaa
		Marshal.PtrToStructure (Pointer, Values)
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
' Basic rectangle
Public Class Box
	Property Pointer as IntPTR
	Private Values as Marshal_Box

''' <summary>
''' Brf: left coordinate
'''  Loc: SRC/pix.h (482, 24)
'''  Org: [l_int32 x]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property x as Integer
	Get
				Return Values.x
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: top coordinate
'''  Loc: SRC/pix.h (483, 24)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: box width
'''  Loc: SRC/pix.h (484, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: box height
'''  Loc: SRC/pix.h (485, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (486, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Box
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of Box
Public Class Boxa
	Property Pointer as IntPTR
	Private Values as Marshal_Boxa

''' <summary>
''' Brf: number of box in ptr array
'''  Loc: SRC/pix.h (494, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of box ptrs allocated
'''  Loc: SRC/pix.h (495, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (496, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: box ptr array
'''  Loc: SRC/pix.h (497, 24)
'''  Org: [struct Box ** box]
'''  Msh: struct Box ** | 3:Struct | List (of Box) Typedef: Box = Box
''' </summary>
ReadOnly Property box as List (of Box)
	Get
		If Values.box <> IntPtr.Zero Then
		Dim LST_box As New List(Of Box)
		Dim ARR_box(values.n - 1) As IntPtr
		Marshal.Copy(Values.box, ARR_box, 0, values.n)
		For Each Entry In ARR_box
			LST_box.Add(New Box(Entry))
		Next
Return LST_box
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Boxa
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of Boxa
Public Class Boxaa
	Property Pointer as IntPTR
	Private Values as Marshal_Boxaa

''' <summary>
''' Brf: number of boxa in ptr array
'''  Loc: SRC/pix.h (504, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of boxa ptrs allocated
'''  Loc: SRC/pix.h (505, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: boxa ptr array
'''  Loc: SRC/pix.h (506, 24)
'''  Org: [struct Boxa ** boxa]
'''  Msh: struct Boxa ** | 3:Struct | List (of Boxa) Typedef: Boxa = Boxa
''' </summary>
ReadOnly Property boxa as List (of Boxa)
	Get
		If Values.boxa <> IntPtr.Zero Then
		Dim LST_boxa As New List(Of Boxa)
		Dim ARR_boxa(values.n - 1) As IntPtr
		Marshal.Copy(Values.boxa, ARR_boxa, 0, values.n)
		For Each Entry In ARR_boxa
			LST_boxa.Add(New Boxa(Entry))
		Next
Return LST_boxa
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Boxaa
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Boxaa
		Public n as Integer
		Public nalloc as Integer
		Public boxa as IntPTR
	End Class
End Class


' SRC/pix.h (517, 8)
' Array of points
Public Class Pta
	Property Pointer as IntPTR
	Private Values as Marshal_Pta

''' <summary>
''' Brf: actual number of pts
'''  Loc: SRC/pix.h (519, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of allocated arrays
'''  Loc: SRC/pix.h (520, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (521, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 24)
'''  Org: [l_float32 * x]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property x as Single()
	Get
		If Values.x <> IntPtr.Zero Then 
	Dim _x(values.n -1) as Single
	Marshal.Copy(Values.x, _x, 0, _x.Length)
	Return _x
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 28)
'''  Org: [l_float32 * y]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property y as Single()
	Get
		If Values.y <> IntPtr.Zero Then 
	Dim _y(values.n -1) as Single
	Marshal.Copy(Values.y, _y, 0, _y.Length)
	Return _y
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Pta
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of Pta
Public Class Ptaa
	Property Pointer as IntPTR
	Private Values as Marshal_Ptaa

''' <summary>
''' Brf: number of pta in ptr array
'''  Loc: SRC/pix.h (534, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of pta ptrs allocated
'''  Loc: SRC/pix.h (535, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pta ptr array
'''  Loc: SRC/pix.h (536, 26)
'''  Org: [struct Pta ** pta]
'''  Msh: struct Pta ** | 3:Struct | List (of Pta) Typedef: Pta = Pta
''' </summary>
ReadOnly Property pta as List (of Pta)
	Get
		If Values.pta <> IntPtr.Zero Then
		Dim LST_pta As New List(Of Pta)
		Dim ARR_pta(values.n - 1) As IntPtr
		Marshal.Copy(Values.pta, ARR_pta, 0, values.n)
		For Each Entry In ARR_pta
			LST_pta.Add(New Pta(Entry))
		Next
Return LST_pta
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Ptaa
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_Ptaa
		Public n as Integer
		Public nalloc as Integer
		Public pta as IntPTR
	End Class
End Class


' SRC/pix.h (546, 8)
' Pix accumulator container
Public Class Pixacc
	Property Pointer as IntPTR
	Private Values as Marshal_Pixacc

''' <summary>
''' Brf: array width
'''  Loc: SRC/pix.h (548, 25)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array height
'''  Loc: SRC/pix.h (549, 25)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: used to allow negative
'''  Loc: SRC/pix.h (550, 25)
'''  Org: [l_int32 offset]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property offset as Integer
	Get
				Return Values.offset
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the 32 bit accumulator pix
'''  Loc: SRC/pix.h (552, 25)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pix as Pix
	Get
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_Pixacc
		Marshal.PtrToStructure (Pointer, Values)
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
' Pix tiling
Public Class PixTiling
	Property Pointer as IntPTR
	Private Values as Marshal_PixTiling

''' <summary>
''' Brf: input pix (a clone)
'''  Loc: SRC/pix.h (564, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pix as Pix
	Get
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of tiles horizontally
'''  Loc: SRC/pix.h (565, 26)
'''  Org: [l_int32 nx]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nx as Integer
	Get
				Return Values.nx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of tiles vertically
'''  Loc: SRC/pix.h (566, 26)
'''  Org: [l_int32 ny]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ny as Integer
	Get
				Return Values.ny
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: tile width
'''  Loc: SRC/pix.h (567, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: tile height
'''  Loc: SRC/pix.h (568, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: overlap on left and right
'''  Loc: SRC/pix.h (569, 26)
'''  Org: [l_int32 xoverlap]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xoverlap as Integer
	Get
				Return Values.xoverlap
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: overlap on top and bottom
'''  Loc: SRC/pix.h (570, 26)
'''  Org: [l_int32 yoverlap]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yoverlap as Integer
	Get
				Return Values.yoverlap
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: strip for paint; default is TRUE
'''  Loc: SRC/pix.h (571, 26)
'''  Org: [l_int32 strip]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property strip as Integer
	Get
				Return Values.strip
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixTiling
		Marshal.PtrToStructure (Pointer, Values)
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
' Pix with float array
Public Class FPix
	Property Pointer as IntPTR
	Private Values as Marshal_FPix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (584, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (585, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (586, 26)
'''  Org: [l_int32 wpl]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property wpl as Integer
	Get
				Return Values.wpl
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (587, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (588, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xres as Integer
	Get
				Return Values.xres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (590, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yres as Integer
	Get
				Return Values.yres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the float image data
'''  Loc: SRC/pix.h (592, 26)
'''  Org: [l_float32 * data]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property data as Single()
	Get
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Single
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_FPix
		Marshal.PtrToStructure (Pointer, Values)
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
' Array of FPix
Public Class FPixa
	Property Pointer as IntPTR
	Private Values as Marshal_FPixa

''' <summary>
''' Brf: number of fpix in ptr array
'''  Loc: SRC/pix.h (599, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of fpix ptrs allocated
'''  Loc: SRC/pix.h (600, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (601, 25)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the array of ptrs to fpix
'''  Loc: SRC/pix.h (602, 25)
'''  Org: [struct FPix ** fpix]
'''  Msh: struct FPix ** | 3:Struct | List (of FPix) Typedef: FPix = FPix
''' </summary>
ReadOnly Property fpix as List (of FPix)
	Get
		If Values.fpix <> IntPtr.Zero Then
		Dim LST_fpix As New List(Of FPix)
		Dim ARR_fpix(values.n - 1) As IntPtr
		Marshal.Copy(Values.fpix, ARR_fpix, 0, values.n)
		For Each Entry In ARR_fpix
			LST_fpix.Add(New FPix(Entry))
		Next
Return LST_fpix
End If
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_FPixa
		Marshal.PtrToStructure (Pointer, Values)
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
' Pix with double array
Public Class DPix
	Property Pointer as IntPTR
	Private Values as Marshal_DPix

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (615, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (616, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 32-bit words/line
'''  Loc: SRC/pix.h (617, 26)
'''  Org: [l_int32 wpl]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property wpl as Integer
	Get
				Return Values.wpl
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (618, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property refcount as UInteger
	Get
				Return Values.refcount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (619, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xres as Integer
	Get
				Return Values.xres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (621, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yres as Integer
	Get
				Return Values.yres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the double image data
'''  Loc: SRC/pix.h (623, 26)
'''  Org: [l_float64 * data]
'''  Msh: l_float64 * | 2:Double | Double()
''' </summary>
ReadOnly Property data as Double()
	Get
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Double
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_DPix
		Marshal.PtrToStructure (Pointer, Values)
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
' Compressed Pix
Public Class PixComp
	Property Pointer as IntPTR
	Private Values as Marshal_PixComp

''' <summary>
''' Brf: width in pixels
'''  Loc: SRC/pix.h (635, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: height in pixels
'''  Loc: SRC/pix.h (636, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: depth in bits
'''  Loc: SRC/pix.h (637, 26)
'''  Org: [l_int32 d]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property d as Integer
	Get
				Return Values.d
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (638, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xres as Integer
	Get
				Return Values.xres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (640, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yres as Integer
	Get
				Return Values.yres
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: compressed format (IFF_TIFF_G4,
'''  Loc: SRC/pix.h (642, 26)
'''  Org: [l_int32 comptype]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property comptype as Integer
	Get
				Return Values.comptype
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: text string associated with pix
'''  Loc: SRC/pix.h (644, 26)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property text as String
	Get
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: flag (1 for cmap, 0 otherwise)
'''  Loc: SRC/pix.h (645, 26)
'''  Org: [l_int32 cmapflag]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property cmapflag as Integer
	Get
				Return Values.cmapflag
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the compressed image data
'''  Loc: SRC/pix.h (646, 26)
'''  Org: [l_uint8 * data]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property data as Byte()
	Get
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Byte
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of the data array
'''  Loc: SRC/pix.h (647, 26)
'''  Org: [size_t size]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property size as UInteger
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixComp
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_PixComp
		Public w as Integer
		Public h as Integer
		Public d as Integer
		Public xres as Integer
		Public yres as Integer
		Public comptype as Integer
		Public text as IntPTR
		Public cmapflag as Integer
		Public data as IntPTR
		Public size as UInteger
	End Class
End Class


' SRC/pix.h (658, 8)
' Array of compressed pix
Public Class PixaComp
	Property Pointer as IntPTR
	Private Values as Marshal_PixaComp

''' <summary>
''' Brf: number of PixComp in ptr array
'''  Loc: SRC/pix.h (660, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of PixComp ptrs allocated
'''  Loc: SRC/pix.h (661, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nalloc as Integer
	Get
				Return Values.nalloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: indexing offset into ptr array
'''  Loc: SRC/pix.h (662, 26)
'''  Org: [l_int32 offset]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property offset as Integer
	Get
				Return Values.offset
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: the array of ptrs to PixComp
'''  Loc: SRC/pix.h (663, 26)
'''  Org: [struct PixComp ** pixc]
'''  Msh: struct PixComp ** | 3:Struct | List (of PixComp)
''' </summary>
ReadOnly Property pixc as List (of PixComp)
	Get
		If Values.pixc <> IntPtr.Zero Then
		Dim LST_pixc As New List(Of PixComp)
		Dim ARR_pixc(values.n - 1) As IntPtr
		Marshal.Copy(Values.pixc, ARR_pixc, 0, values.n)
		For Each Entry In ARR_pixc
			LST_pixc.Add(New PixComp(Entry))
		Next
Return LST_pixc
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of boxes
'''  Loc: SRC/pix.h (664, 26)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct | Boxa Typedef: Boxa = Boxa
''' </summary>
ReadOnly Property boxa as Boxa
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixaComp
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property scalew as Integer
	Get
				Return Values.scalew
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: scale all examples to this height;
'''  Loc: SRC/recog.h (119, 20)
'''  Org: [l_int32 scaleh]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property scaleh as Integer
	Get
				Return Values.scaleh
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: use a value  bigger  0 to convert the bitmap
'''  Loc: SRC/recog.h (121, 20)
'''  Org: [l_int32 linew]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property linew as Integer
	Get
				Return Values.linew
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: template use: use either the average
'''  Loc: SRC/recog.h (123, 20)
'''  Org: [l_int32 templ_use]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property templ_use as Integer
	Get
				Return Values.templ_use
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: initialize container arrays to this
'''  Loc: SRC/recog.h (126, 20)
'''  Org: [l_int32 maxarraysize]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxarraysize as Integer
	Get
				Return Values.maxarraysize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of character set
'''  Loc: SRC/recog.h (127, 20)
'''  Org: [l_int32 setsize]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property setsize as Integer
	Get
				Return Values.setsize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: for binarizing if depth  bigger  1
'''  Loc: SRC/recog.h (128, 20)
'''  Org: [l_int32 threshold]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property threshold as Integer
	Get
				Return Values.threshold
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: vertical jiggle on nominal centroid
'''  Loc: SRC/recog.h (129, 20)
'''  Org: [l_int32 maxyshift]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxyshift as Integer
	Get
				Return Values.maxyshift
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: one of L_ARABIC_NUMERALS, etc.
'''  Loc: SRC/recog.h (131, 20)
'''  Org: [l_int32 charset_type]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property charset_type as Integer
	Get
				Return Values.charset_type
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: expected number of classes in charset
'''  Loc: SRC/recog.h (132, 20)
'''  Org: [l_int32 charset_size]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property charset_size as Integer
	Get
				Return Values.charset_size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min number of samples without padding
'''  Loc: SRC/recog.h (133, 20)
'''  Org: [l_int32 min_nopad]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property min_nopad as Integer
	Get
				Return Values.min_nopad
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of training samples
'''  Loc: SRC/recog.h (134, 20)
'''  Org: [l_int32 num_samples]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property num_samples as Integer
	Get
				Return Values.num_samples
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min width averaged unscaled templates
'''  Loc: SRC/recog.h (135, 20)
'''  Org: [l_int32 minwidth_u]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minwidth_u as Integer
	Get
				Return Values.minwidth_u
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max width averaged unscaled templates
'''  Loc: SRC/recog.h (136, 20)
'''  Org: [l_int32 maxwidth_u]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxwidth_u as Integer
	Get
				Return Values.maxwidth_u
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min height averaged unscaled templates
'''  Loc: SRC/recog.h (137, 20)
'''  Org: [l_int32 minheight_u]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minheight_u as Integer
	Get
				Return Values.minheight_u
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max height averaged unscaled templates
'''  Loc: SRC/recog.h (138, 20)
'''  Org: [l_int32 maxheight_u]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxheight_u as Integer
	Get
				Return Values.maxheight_u
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min width averaged scaled templates
'''  Loc: SRC/recog.h (139, 20)
'''  Org: [l_int32 minwidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minwidth as Integer
	Get
				Return Values.minwidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max width averaged scaled templates
'''  Loc: SRC/recog.h (140, 20)
'''  Org: [l_int32 maxwidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxwidth as Integer
	Get
				Return Values.maxwidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 when averaged bitmaps are made
'''  Loc: SRC/recog.h (141, 20)
'''  Org: [l_int32 ave_done]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ave_done as Integer
	Get
				Return Values.ave_done
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 when training is complete or
'''  Loc: SRC/recog.h (142, 20)
'''  Org: [l_int32 train_done]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property train_done as Integer
	Get
				Return Values.train_done
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max width/height ratio to split
'''  Loc: SRC/recog.h (144, 20)
'''  Org: [l_float32 max_wh_ratio]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property max_wh_ratio as Single
	Get
				Return Values.max_wh_ratio
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max of max/min template height ratio
'''  Loc: SRC/recog.h (145, 20)
'''  Org: [l_float32 max_ht_ratio]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property max_ht_ratio as Single
	Get
				Return Values.max_ht_ratio
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min component width kept in splitting
'''  Loc: SRC/recog.h (146, 20)
'''  Org: [l_int32 min_splitw]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property min_splitw as Integer
	Get
				Return Values.min_splitw
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max component height kept in splitting
'''  Loc: SRC/recog.h (147, 20)
'''  Org: [l_int32 max_splith]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property max_splith as Integer
	Get
				Return Values.max_splith
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: text array for arbitrary char set
'''  Loc: SRC/recog.h (148, 20)
'''  Org: [struct Sarray * sa_text]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property sa_text as Sarray
	Get
			If Values.sa_text <> IntPtr.Zero Then 
		Return New Sarray(Values.sa_text)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: index-to-char lut for arbitrary charset
'''  Loc: SRC/recog.h (149, 20)
'''  Org: [struct L_Dna * dna_tochar]
'''  Msh: struct L_Dna * | 2:Struct | L_Dna Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property dna_tochar as L_Dna
	Get
			If Values.dna_tochar <> IntPtr.Zero Then 
		Return New L_Dna(Values.dna_tochar)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: table for finding centroids
'''  Loc: SRC/recog.h (150, 20)
'''  Org: [l_int32 * centtab]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property centtab as Integer()
	Get
		If Values.centtab <> IntPtr.Zero Then 
	Dim _centtab(1 -1) as Integer
	Marshal.Copy(Values.centtab, _centtab, 0, _centtab.Length)
	Return _centtab
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: table for finding pixel sums
'''  Loc: SRC/recog.h (151, 20)
'''  Org: [l_int32 * sumtab]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property sumtab as Integer()
	Get
		If Values.sumtab <> IntPtr.Zero Then 
	Dim _sumtab(1 -1) as Integer
	Marshal.Copy(Values.sumtab, _sumtab, 0, _sumtab.Length)
	Return _sumtab
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: all unscaled templates for each class
'''  Loc: SRC/recog.h (152, 20)
'''  Org: [struct Pixaa * pixaa_u]
'''  Msh: struct Pixaa * | 2:Struct | Pixaa Typedef: Pixaa = Pixaa
''' </summary>
ReadOnly Property pixaa_u as Pixaa
	Get
			If Values.pixaa_u <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of all unscaled templates
'''  Loc: SRC/recog.h (153, 20)
'''  Org: [struct Ptaa * ptaa_u]
'''  Msh: struct Ptaa * | 2:Struct | Ptaa Typedef: Ptaa = Ptaa
''' </summary>
ReadOnly Property ptaa_u as Ptaa
	Get
			If Values.ptaa_u <> IntPtr.Zero Then 
		Return New Ptaa(Values.ptaa_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: area of all unscaled templates
'''  Loc: SRC/recog.h (154, 20)
'''  Org: [struct Numaa * naasum_u]
'''  Msh: struct Numaa * | 2:Struct | Numaa Typedef: Numaa = Numaa
''' </summary>
ReadOnly Property naasum_u as Numaa
	Get
			If Values.naasum_u <> IntPtr.Zero Then 
		Return New Numaa(Values.naasum_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: all (scaled) templates for each class
'''  Loc: SRC/recog.h (155, 20)
'''  Org: [struct Pixaa * pixaa]
'''  Msh: struct Pixaa * | 2:Struct | Pixaa Typedef: Pixaa = Pixaa
''' </summary>
ReadOnly Property pixaa as Pixaa
	Get
			If Values.pixaa <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of all (scaledl) templates
'''  Loc: SRC/recog.h (156, 20)
'''  Org: [struct Ptaa * ptaa]
'''  Msh: struct Ptaa * | 2:Struct | Ptaa Typedef: Ptaa = Ptaa
''' </summary>
ReadOnly Property ptaa as Ptaa
	Get
			If Values.ptaa <> IntPtr.Zero Then 
		Return New Ptaa(Values.ptaa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: area of all (scaled) templates
'''  Loc: SRC/recog.h (157, 20)
'''  Org: [struct Numaa * naasum]
'''  Msh: struct Numaa * | 2:Struct | Numaa Typedef: Numaa = Numaa
''' </summary>
ReadOnly Property naasum as Numaa
	Get
			If Values.naasum <> IntPtr.Zero Then 
		Return New Numaa(Values.naasum)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: averaged unscaled templates per class
'''  Loc: SRC/recog.h (158, 20)
'''  Org: [struct Pixa * pixa_u]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixa_u as Pixa
	Get
			If Values.pixa_u <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of unscaled ave. templates
'''  Loc: SRC/recog.h (159, 20)
'''  Org: [struct Pta * pta_u]
'''  Msh: struct Pta * | 2:Struct | Pta Typedef: Pta = Pta
''' </summary>
ReadOnly Property pta_u as Pta
	Get
			If Values.pta_u <> IntPtr.Zero Then 
		Return New Pta(Values.pta_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: area of unscaled averaged templates
'''  Loc: SRC/recog.h (160, 20)
'''  Org: [struct Numa * nasum_u]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasum_u as Numa
	Get
			If Values.nasum_u <> IntPtr.Zero Then 
		Return New Numa(Values.nasum_u)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: averaged (scaled) templates per class
'''  Loc: SRC/recog.h (161, 20)
'''  Org: [struct Pixa * pixa]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixa as Pixa
	Get
			If Values.pixa <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: centroids of (scaled) ave. templates
'''  Loc: SRC/recog.h (162, 20)
'''  Org: [struct Pta * pta]
'''  Msh: struct Pta * | 2:Struct | Pta Typedef: Pta = Pta
''' </summary>
ReadOnly Property pta as Pta
	Get
			If Values.pta <> IntPtr.Zero Then 
		Return New Pta(Values.pta)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: area of (scaled) averaged templates
'''  Loc: SRC/recog.h (163, 20)
'''  Org: [struct Numa * nasum]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasum as Numa
	Get
			If Values.nasum <> IntPtr.Zero Then 
		Return New Numa(Values.nasum)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: all input training images
'''  Loc: SRC/recog.h (164, 20)
'''  Org: [struct Pixa * pixa_tr]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixa_tr as Pixa
	Get
			If Values.pixa_tr <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_tr)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: unscaled and scaled averaged bitmaps
'''  Loc: SRC/recog.h (165, 20)
'''  Org: [struct Pixa * pixadb_ave]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixadb_ave as Pixa
	Get
			If Values.pixadb_ave <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_ave)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: input images for identifying
'''  Loc: SRC/recog.h (166, 20)
'''  Org: [struct Pixa * pixa_id]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixa_id as Pixa
	Get
			If Values.pixa_id <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_id)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: debug: best match of input against ave.
'''  Loc: SRC/recog.h (167, 20)
'''  Org: [struct Pix * pixdb_ave]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixdb_ave as Pix
	Get
			If Values.pixdb_ave <> IntPtr.Zero Then 
		Return New Pix(Values.pixdb_ave)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: debug: best matches within range
'''  Loc: SRC/recog.h (168, 20)
'''  Org: [struct Pix * pixdb_range]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixdb_range as Pix
	Get
			If Values.pixdb_range <> IntPtr.Zero Then 
		Return New Pix(Values.pixdb_range)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: debug: bootstrap training results
'''  Loc: SRC/recog.h (169, 20)
'''  Org: [struct Pixa * pixadb_boot]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixadb_boot as Pixa
	Get
			If Values.pixadb_boot <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_boot)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: debug: splitting results
'''  Loc: SRC/recog.h (170, 20)
'''  Org: [struct Pixa * pixadb_split]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixadb_split as Pixa
	Get
			If Values.pixadb_split <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_split)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: bmf fonts
'''  Loc: SRC/recog.h (171, 20)
'''  Org: [struct L_Bmf * bmf]
'''  Msh: struct L_Bmf * | 2:Struct | L_Bmf Typedef: L_Bmf = L_Bmf
''' </summary>
ReadOnly Property bmf as L_Bmf
	Get
			If Values.bmf <> IntPtr.Zero Then 
		Return New L_Bmf(Values.bmf)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: font size of bmf; default is 6 pt
'''  Loc: SRC/recog.h (172, 20)
'''  Org: [l_int32 bmf_size]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bmf_size as Integer
	Get
				Return Values.bmf_size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: temp data used for image decoding
'''  Loc: SRC/recog.h (173, 20)
'''  Org: [struct L_Rdid * did]
'''  Msh: struct L_Rdid * | 2:Struct | L_Rdid
''' </summary>
ReadOnly Property did as L_Rdid
	Get
			If Values.did <> IntPtr.Zero Then 
		Return New L_Rdid(Values.did)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: temp data used for holding best char
'''  Loc: SRC/recog.h (174, 20)
'''  Org: [struct L_Rch * rch]
'''  Msh: struct L_Rch * | 2:Struct | L_Rch
''' </summary>
ReadOnly Property rch as L_Rch
	Get
			If Values.rch <> IntPtr.Zero Then 
		Return New L_Rch(Values.rch)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: temp data used for array of best chars
'''  Loc: SRC/recog.h (175, 20)
'''  Org: [struct L_Rcha * rcha]
'''  Msh: struct L_Rcha * | 2:Struct | L_Rcha
''' </summary>
ReadOnly Property rcha as L_Rcha
	Get
			If Values.rcha <> IntPtr.Zero Then 
		Return New L_Rcha(Values.rcha)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Recog
		Marshal.PtrToStructure (Pointer, Values)
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
' Data returned from correlation matching on a single character
Public Class L_Rch
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rch

''' <summary>
''' Brf: index of best template
'''  Loc: SRC/recog.h (183, 20)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: correlation score of best template
'''  Loc: SRC/recog.h (184, 20)
'''  Org: [l_float32 score]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property score as Single
	Get
				Return Values.score
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: character string of best template
'''  Loc: SRC/recog.h (185, 20)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property text as String
	Get
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: index of best sample (within the best
'''  Loc: SRC/recog.h (186, 20)
'''  Org: [l_int32 sample]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property sample as Integer
	Get
				Return Values.sample
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x-location of template (delx + shiftx)
'''  Loc: SRC/recog.h (188, 20)
'''  Org: [l_int32 xloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xloc as Integer
	Get
				Return Values.xloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y-location of template (dely + shifty)
'''  Loc: SRC/recog.h (189, 20)
'''  Org: [l_int32 yloc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property yloc as Integer
	Get
				Return Values.yloc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: width of best template
'''  Loc: SRC/recog.h (190, 20)
'''  Org: [l_int32 width]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property width as Integer
	Get
				Return Values.width
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Rch
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_Rch
		Public index as Integer
		Public score as Single
		Public text as IntPTR
		Public sample as Integer
		Public xloc as Integer
		Public yloc as Integer
		Public width as Integer
	End Class
End Class


' SRC/recog.h (197, 8)
' Data returned from correlation matching on an array of characters
Public Class L_Rcha
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rcha

''' <summary>
''' Brf: indices of best templates
'''  Loc: SRC/recog.h (198, 20)
'''  Org: [struct Numa * naindex]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naindex as Numa
	Get
			If Values.naindex <> IntPtr.Zero Then 
		Return New Numa(Values.naindex)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: correlation scores of best templates
'''  Loc: SRC/recog.h (199, 20)
'''  Org: [struct Numa * nascore]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nascore as Numa
	Get
			If Values.nascore <> IntPtr.Zero Then 
		Return New Numa(Values.nascore)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: character strings of best templates
'''  Loc: SRC/recog.h (200, 20)
'''  Org: [struct Sarray * satext]
'''  Msh: struct Sarray * | 2:Struct | Sarray Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property satext as Sarray
	Get
			If Values.satext <> IntPtr.Zero Then 
		Return New Sarray(Values.satext)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: indices of best samples
'''  Loc: SRC/recog.h (201, 20)
'''  Org: [struct Numa * nasample]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasample as Numa
	Get
			If Values.nasample <> IntPtr.Zero Then 
		Return New Numa(Values.nasample)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x-locations of templates (delx + shiftx)
'''  Loc: SRC/recog.h (202, 20)
'''  Org: [struct Numa * naxloc]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naxloc as Numa
	Get
			If Values.naxloc <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y-locations of templates (dely + shifty)
'''  Loc: SRC/recog.h (203, 20)
'''  Org: [struct Numa * nayloc]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nayloc as Numa
	Get
			If Values.nayloc <> IntPtr.Zero Then 
		Return New Numa(Values.nayloc)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: widths of best templates
'''  Loc: SRC/recog.h (204, 20)
'''  Org: [struct Numa * nawidth]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nawidth as Numa
	Get
			If Values.nawidth <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Rcha
		Marshal.PtrToStructure (Pointer, Values)
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
' Data used for decoding a line of characters.
Public Class L_Rdid
	Property Pointer as IntPTR
	Private Values as Marshal_L_Rdid

''' <summary>
''' Brf: clone of pix to be decoded
'''  Loc: SRC/recog.h (212, 20)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixs as Pix
	Get
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: count array for each averaged template
'''  Loc: SRC/recog.h (213, 20)
'''  Org: [l_int32 ** counta]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
''' </summary>
ReadOnly Property counta as List (of Integer())
	Get
		Dim _Data1(1 - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.counta, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: best y-shift array per average template
'''  Loc: SRC/recog.h (214, 20)
'''  Org: [l_int32 ** delya]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
''' </summary>
ReadOnly Property delya as List (of Integer())
	Get
		Dim _Data1(1 - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.delya, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of averaged templates
'''  Loc: SRC/recog.h (215, 20)
'''  Org: [l_int32 narray]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property narray as Integer
	Get
				Return Values.narray
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of count array (width of pixs)
'''  Loc: SRC/recog.h (216, 20)
'''  Org: [l_int32 size]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property size as Integer
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: setwidths for each template
'''  Loc: SRC/recog.h (217, 20)
'''  Org: [l_int32 * setwidth]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property setwidth as Integer()
	Get
		If Values.setwidth <> IntPtr.Zero Then 
	Dim _setwidth(1 -1) as Integer
	Marshal.Copy(Values.setwidth, _setwidth, 0, _setwidth.Length)
	Return _setwidth
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pixel count in pixs by column
'''  Loc: SRC/recog.h (218, 20)
'''  Org: [struct Numa * nasum]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasum as Numa
	Get
			If Values.nasum <> IntPtr.Zero Then 
		Return New Numa(Values.nasum)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: first moment of pixels in pixs by cols
'''  Loc: SRC/recog.h (219, 20)
'''  Org: [struct Numa * namoment]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property namoment as Numa
	Get
			If Values.namoment <> IntPtr.Zero Then 
		Return New Numa(Values.namoment)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 1 if full arrays are made; 0 otherwise
'''  Loc: SRC/recog.h (220, 20)
'''  Org: [l_int32 fullarrays]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property fullarrays as Integer
	Get
				Return Values.fullarrays
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: channel coeffs for template fg term
'''  Loc: SRC/recog.h (221, 20)
'''  Org: [l_float32 * beta]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property beta as Single()
	Get
		If Values.beta <> IntPtr.Zero Then 
	Dim _beta(1 -1) as Single
	Marshal.Copy(Values.beta, _beta, 0, _beta.Length)
	Return _beta
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: channel coeffs for bit-and term
'''  Loc: SRC/recog.h (222, 20)
'''  Org: [l_float32 * gamma]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property gamma as Single()
	Get
		If Values.gamma <> IntPtr.Zero Then 
	Dim _gamma(1 -1) as Single
	Marshal.Copy(Values.gamma, _gamma, 0, _gamma.Length)
	Return _gamma
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: score on trellis
'''  Loc: SRC/recog.h (223, 20)
'''  Org: [l_float32 * trellisscore]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property trellisscore as Single()
	Get
		If Values.trellisscore <> IntPtr.Zero Then 
	Dim _trellisscore(1 -1) as Single
	Marshal.Copy(Values.trellisscore, _trellisscore, 0, _trellisscore.Length)
	Return _trellisscore
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: template on trellis (for backtrack)
'''  Loc: SRC/recog.h (224, 20)
'''  Org: [l_int32 * trellistempl]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property trellistempl as Integer()
	Get
		If Values.trellistempl <> IntPtr.Zero Then 
	Dim _trellistempl(1 -1) as Integer
	Marshal.Copy(Values.trellistempl, _trellistempl, 0, _trellistempl.Length)
	Return _trellistempl
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: indices of best path templates
'''  Loc: SRC/recog.h (225, 20)
'''  Org: [struct Numa * natempl]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property natempl as Numa
	Get
			If Values.natempl <> IntPtr.Zero Then 
		Return New Numa(Values.natempl)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x locations of best path templates
'''  Loc: SRC/recog.h (226, 20)
'''  Org: [struct Numa * naxloc]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naxloc as Numa
	Get
			If Values.naxloc <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y locations of best path templates
'''  Loc: SRC/recog.h (227, 20)
'''  Org: [struct Numa * nadely]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nadely as Numa
	Get
			If Values.nadely <> IntPtr.Zero Then 
		Return New Numa(Values.nadely)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: widths of best path templates
'''  Loc: SRC/recog.h (228, 20)
'''  Org: [struct Numa * nawidth]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nawidth as Numa
	Get
			If Values.nawidth <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Viterbi result for splitting input pixs
'''  Loc: SRC/recog.h (229, 20)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct | Boxa Typedef: Boxa = Boxa
''' </summary>
ReadOnly Property boxa as Boxa
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: correlation scores: best path templates
'''  Loc: SRC/recog.h (230, 20)
'''  Org: [struct Numa * nascore]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nascore as Numa
	Get
			If Values.nascore <> IntPtr.Zero Then 
		Return New Numa(Values.nascore)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: indices of best rescored templates
'''  Loc: SRC/recog.h (231, 20)
'''  Org: [struct Numa * natempl_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property natempl_r as Numa
	Get
			If Values.natempl_r <> IntPtr.Zero Then 
		Return New Numa(Values.natempl_r)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: samples of best scored templates
'''  Loc: SRC/recog.h (232, 20)
'''  Org: [struct Numa * nasample_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasample_r as Numa
	Get
			If Values.nasample_r <> IntPtr.Zero Then 
		Return New Numa(Values.nasample_r)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x locations of best rescoredtemplates
'''  Loc: SRC/recog.h (233, 20)
'''  Org: [struct Numa * naxloc_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property naxloc_r as Numa
	Get
			If Values.naxloc_r <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc_r)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y locations of best rescoredtemplates
'''  Loc: SRC/recog.h (234, 20)
'''  Org: [struct Numa * nadely_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nadely_r as Numa
	Get
			If Values.nadely_r <> IntPtr.Zero Then 
		Return New Numa(Values.nadely_r)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: widths of best rescoredtemplates
'''  Loc: SRC/recog.h (235, 20)
'''  Org: [struct Numa * nawidth_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nawidth_r as Numa
	Get
			If Values.nawidth_r <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth_r)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: correlation scores: rescored templates
'''  Loc: SRC/recog.h (236, 20)
'''  Org: [struct Numa * nascore_r]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nascore_r as Numa
	Get
			If Values.nascore_r <> IntPtr.Zero Then 
		Return New Numa(Values.nascore_r)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Rdid
		Marshal.PtrToStructure (Pointer, Values)
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
' Regression test parameter packer
Public Class L_RegParams
	Property Pointer as IntPTR
	Private Values as Marshal_L_RegParams

''' <summary>
''' Brf: stream to temporary output file for compare mode
'''  Loc: SRC/regutils.h (119, 14)
'''  Org: [FILE * fp]
'''  Msh: FILE * | 2:Struct | FILE
''' </summary>
ReadOnly Property fp as FILE
	Get
			If Values.fp <> IntPtr.Zero Then 
		Return New FILE(Values.fp)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: name of test, without '_reg'
'''  Loc: SRC/regutils.h (120, 14)
'''  Org: [char * testname]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property testname as String
	Get
		If Values.testname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.testname)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: name of temp file for compare mode output
'''  Loc: SRC/regutils.h (121, 14)
'''  Org: [char * tempfile]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property tempfile as String
	Get
		If Values.tempfile <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.tempfile)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: generate, compare or display
'''  Loc: SRC/regutils.h (122, 14)
'''  Org: [l_int32 mode]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property mode as Integer
	Get
				Return Values.mode
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: index into saved files for this test; 0-based
'''  Loc: SRC/regutils.h (123, 14)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: overall result of the test
'''  Loc: SRC/regutils.h (124, 14)
'''  Org: [l_int32 success]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property success as Integer
	Get
				Return Values.success
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 1 if in display mode; 0 otherwise
'''  Loc: SRC/regutils.h (125, 14)
'''  Org: [l_int32 display]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property display as Integer
	Get
				Return Values.display
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: marks beginning of the reg test
'''  Loc: SRC/regutils.h (126, 14)
'''  Org: [L_TIMER tstart]
'''  Msh: L_TIMER = bigger  1:*
''' </summary>
ReadOnly Property tstart as IntPTR
	Get
				Return Values.tstart
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_RegParams
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_RegParams
		Public fp as IntPTR
		Public testname as IntPTR
		Public tempfile as IntPTR
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
' stringcode.h
Public Class L_StrCode
	Property Pointer as IntPTR
	Private Values as Marshal_L_StrCode

''' <summary>
''' Brf: index for function and output file names
'''  Loc: SRC/stringcode.h (42, 19)
'''  Org: [l_int32 fileno]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property fileno as Integer
	Get
				Return Values.fileno
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: index into struct currently being stored
'''  Loc: SRC/stringcode.h (43, 19)
'''  Org: [l_int32 ifunc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ifunc as Integer
	Get
				Return Values.ifunc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: store case code for extraction
'''  Loc: SRC/stringcode.h (44, 19)
'''  Org: [SARRAY * function]
'''  Msh: SARRAY * | 2:Struct | SARRAY Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property _function_ as SARRAY
	Get
			If Values._function_ <> IntPtr.Zero Then 
		Return New Sarray(Values._function_)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: store base64 encoded data as strings
'''  Loc: SRC/stringcode.h (45, 19)
'''  Org: [SARRAY * data]
'''  Msh: SARRAY * | 2:Struct | SARRAY Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property data as SARRAY
	Get
			If Values.data <> IntPtr.Zero Then 
		Return New Sarray(Values.data)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: store line in description table
'''  Loc: SRC/stringcode.h (46, 19)
'''  Org: [SARRAY * descr]
'''  Msh: SARRAY * | 2:Struct | SARRAY Typedef: Sarray = Sarray
''' </summary>
ReadOnly Property descr as SARRAY
	Get
			If Values.descr <> IntPtr.Zero Then 
		Return New Sarray(Values.descr)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of data strings
'''  Loc: SRC/stringcode.h (47, 19)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_StrCode
		Marshal.PtrToStructure (Pointer, Values)
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
' sudoku.h
Public Class L_Sudoku
	Property Pointer as IntPTR
	Private Values as Marshal_L_Sudoku

''' <summary>
''' Brf: number of unknowns
'''  Loc: SRC/sudoku.h (54, 20)
'''  Org: [l_int32 num]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property num as Integer
	Get
				Return Values.num
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: location of unknowns
'''  Loc: SRC/sudoku.h (55, 20)
'''  Org: [l_int32 * locs]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property locs as Integer()
	Get
		If Values.locs <> IntPtr.Zero Then 
	Dim _locs(1 -1) as Integer
	Marshal.Copy(Values.locs, _locs, 0, _locs.Length)
	Return _locs
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: index into %locs of current location
'''  Loc: SRC/sudoku.h (56, 20)
'''  Org: [l_int32 current]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property current as Integer
	Get
				Return Values.current
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: initial state, with 0 representing
'''  Loc: SRC/sudoku.h (57, 20)
'''  Org: [l_int32 * init]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property init as Integer()
	Get
		If Values.init <> IntPtr.Zero Then 
	Dim _init(1 -1) as Integer
	Marshal.Copy(Values.init, _init, 0, _init.Length)
	Return _init
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: present state, including inits and
'''  Loc: SRC/sudoku.h (59, 20)
'''  Org: [l_int32 * state]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property state as Integer()
	Get
		If Values.state <> IntPtr.Zero Then 
	Dim _state(1 -1) as Integer
	Marshal.Copy(Values.state, _state, 0, _state.Length)
	Return _state
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: shows current number of guesses
'''  Loc: SRC/sudoku.h (61, 20)
'''  Org: [l_int32 nguess]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nguess as Integer
	Get
				Return Values.nguess
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 when solved
'''  Loc: SRC/sudoku.h (62, 20)
'''  Org: [l_int32 finished]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property finished as Integer
	Get
				Return Values.finished
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 if no solution is possible
'''  Loc: SRC/sudoku.h (63, 20)
'''  Org: [l_int32 failure]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property failure as Integer
	Get
				Return Values.failure
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Sudoku
		Marshal.PtrToStructure (Pointer, Values)
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
' Simple data structure to hold watershed data.
Public Class L_WShed
	Property Pointer as IntPTR
	Private Values as Marshal_L_WShed

''' <summary>
''' Brf: clone of input 8 bpp pixs
'''  Loc: SRC/watershed.h (40, 20)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixs as Pix
	Get
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: clone of input 1 bpp seed (marker) pixm
'''  Loc: SRC/watershed.h (41, 20)
'''  Org: [struct Pix * pixm]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixm as Pix
	Get
			If Values.pixm <> IntPtr.Zero Then 
		Return New Pix(Values.pixm)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: minimum depth allowed for a watershed
'''  Loc: SRC/watershed.h (42, 20)
'''  Org: [l_int32 mindepth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property mindepth as Integer
	Get
				Return Values.mindepth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 16 bpp label pix
'''  Loc: SRC/watershed.h (43, 20)
'''  Org: [struct Pix * pixlab]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixlab as Pix
	Get
			If Values.pixlab <> IntPtr.Zero Then 
		Return New Pix(Values.pixlab)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: scratch pix for computing wshed regions
'''  Loc: SRC/watershed.h (44, 20)
'''  Org: [struct Pix * pixt]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixt as Pix
	Get
			If Values.pixt <> IntPtr.Zero Then 
		Return New Pix(Values.pixt)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: line ptrs for pixs
'''  Loc: SRC/watershed.h (45, 20)
'''  Org: [void ** lines8]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property lines8 as IntPTR()
	Get
			If Values.lines8 <> IntPtr.Zero Then 
		Dim _lines8(1) as IntPTR
		Marshal.Copy(Values.lines8, _lines8, 0, 1)
		Return _lines8
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: line ptrs for pixm
'''  Loc: SRC/watershed.h (46, 20)
'''  Org: [void ** linem1]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property linem1 as IntPTR()
	Get
			If Values.linem1 <> IntPtr.Zero Then 
		Dim _linem1(1) as IntPTR
		Marshal.Copy(Values.linem1, _linem1, 0, 1)
		Return _linem1
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: line ptrs for pixlab
'''  Loc: SRC/watershed.h (47, 20)
'''  Org: [void ** linelab32]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property linelab32 as IntPTR()
	Get
			If Values.linelab32 <> IntPtr.Zero Then 
		Dim _linelab32(1) as IntPTR
		Marshal.Copy(Values.linelab32, _linelab32, 0, 1)
		Return _linelab32
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: line ptrs for pixt
'''  Loc: SRC/watershed.h (48, 20)
'''  Org: [void ** linet1]
'''  Msh: void ** | 3:Void | IntPTR()
''' </summary>
ReadOnly Property linet1 as IntPTR()
	Get
			If Values.linet1 <> IntPtr.Zero Then 
		Dim _linet1(1) as IntPTR
		Marshal.Copy(Values.linet1, _linet1, 0, 1)
		Return _linet1
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: result: 1 bpp pixa of watersheds
'''  Loc: SRC/watershed.h (49, 20)
'''  Org: [struct Pixa * pixad]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixad as Pixa
	Get
			If Values.pixad <> IntPtr.Zero Then 
		Return New Pixa(Values.pixad)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pta of initial seed pixels
'''  Loc: SRC/watershed.h (50, 20)
'''  Org: [struct Pta * ptas]
'''  Msh: struct Pta * | 2:Struct | Pta Typedef: Pta = Pta
''' </summary>
ReadOnly Property ptas as Pta
	Get
			If Values.ptas <> IntPtr.Zero Then 
		Return New Pta(Values.ptas)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: numa of seed indicators; 0 if completed
'''  Loc: SRC/watershed.h (51, 20)
'''  Org: [struct Numa * nasi]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nasi as Numa
	Get
			If Values.nasi <> IntPtr.Zero Then 
		Return New Numa(Values.nasi)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: numa of initial seed heights
'''  Loc: SRC/watershed.h (52, 20)
'''  Org: [struct Numa * nash]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nash as Numa
	Get
			If Values.nash <> IntPtr.Zero Then 
		Return New Numa(Values.nash)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: numa of initial minima heights
'''  Loc: SRC/watershed.h (53, 20)
'''  Org: [struct Numa * namh]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property namh as Numa
	Get
			If Values.namh <> IntPtr.Zero Then 
		Return New Numa(Values.namh)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: result: numa of watershed levels
'''  Loc: SRC/watershed.h (54, 20)
'''  Org: [struct Numa * nalevels]
'''  Msh: struct Numa * | 2:Struct | Numa Typedef: Numa = Numa
''' </summary>
ReadOnly Property nalevels as Numa
	Get
			If Values.nalevels <> IntPtr.Zero Then 
		Return New Numa(Values.nalevels)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of seeds (markers)
'''  Loc: SRC/watershed.h (55, 20)
'''  Org: [l_int32 nseeds]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nseeds as Integer
	Get
				Return Values.nseeds
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of minima different from seeds
'''  Loc: SRC/watershed.h (56, 20)
'''  Org: [l_int32 nother]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nother as Integer
	Get
				Return Values.nother
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: lut for pixel indices
'''  Loc: SRC/watershed.h (57, 20)
'''  Org: [l_int32 * lut]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property lut as Integer()
	Get
		If Values.lut <> IntPtr.Zero Then 
	Dim _lut(1 -1) as Integer
	Marshal.Copy(Values.lut, _lut, 0, _lut.Length)
	Return _lut
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: back-links into lut, for updates
'''  Loc: SRC/watershed.h (58, 20)
'''  Org: [struct Numa ** links]
'''  Msh: struct Numa ** | 3:Struct | List (of Numa) Typedef: Numa = Numa
''' </summary>
ReadOnly Property links as List (of Numa)
	Get
		If Values.links <> IntPtr.Zero Then
		Dim LST_links As New List(Of Numa)
		Dim ARR_links(1 - 1) As IntPtr
		Marshal.Copy(Values.links, ARR_links, 0, 1)
		For Each Entry In ARR_links
			LST_links.Add(New Numa(Entry))
		Next
Return LST_links
End If
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of links array
'''  Loc: SRC/watershed.h (59, 20)
'''  Org: [l_int32 arraysize]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property arraysize as Integer
	Get
				Return Values.arraysize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set to 1 for debug output
'''  Loc: SRC/watershed.h (60, 20)
'''  Org: [l_int32 debug]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property debug as Integer
	Get
				Return Values.debug
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_WShed
		Marshal.PtrToStructure (Pointer, Values)
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
' Bilateral filter
Public Class L_Bilateral
	Property Pointer as IntPTR
	Private Values as Marshal_L_Bilateral

''' <summary>
''' Brf: clone of source pix
'''  Loc: SRC/bilateral.h (117, 21)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixs as Pix
	Get
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: downscaled pix with mirrored border
'''  Loc: SRC/bilateral.h (118, 21)
'''  Org: [struct Pix * pixsc]
'''  Msh: struct Pix * | 2:Struct | Pix Typedef: Pix = Pix
''' </summary>
ReadOnly Property pixsc as Pix
	Get
			If Values.pixsc <> IntPtr.Zero Then 
		Return New Pix(Values.pixsc)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 1, 2 or 4x for intermediates
'''  Loc: SRC/bilateral.h (119, 21)
'''  Org: [l_int32 reduction]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property reduction as Integer
	Get
				Return Values.reduction
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: stdev of spatial gaussian
'''  Loc: SRC/bilateral.h (120, 21)
'''  Org: [l_float32 spatial_stdev]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property spatial_stdev as Single
	Get
				Return Values.spatial_stdev
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: stdev of range gaussian
'''  Loc: SRC/bilateral.h (121, 21)
'''  Org: [l_float32 range_stdev]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property range_stdev as Single
	Get
				Return Values.range_stdev
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 1D gaussian spatial kernel
'''  Loc: SRC/bilateral.h (122, 21)
'''  Org: [l_float32 * spatial]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property spatial as Single()
	Get
		If Values.spatial <> IntPtr.Zero Then 
	Dim _spatial(1 -1) as Single
	Marshal.Copy(Values.spatial, _spatial, 0, _spatial.Length)
	Return _spatial
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: one-sided gaussian range kernel
'''  Loc: SRC/bilateral.h (123, 21)
'''  Org: [l_float32 * range]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property range as Single()
	Get
		If Values.range <> IntPtr.Zero Then 
	Dim _range(1 -1) as Single
	Marshal.Copy(Values.range, _range, 0, _range.Length)
	Return _range
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: min value in 8 bpp pix
'''  Loc: SRC/bilateral.h (124, 21)
'''  Org: [l_int32 minval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property minval as Integer
	Get
				Return Values.minval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: max value in 8 bpp pix
'''  Loc: SRC/bilateral.h (125, 21)
'''  Org: [l_int32 maxval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property maxval as Integer
	Get
				Return Values.maxval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of intermediate results
'''  Loc: SRC/bilateral.h (126, 21)
'''  Org: [l_int32 ncomps]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property ncomps as Integer
	Get
				Return Values.ncomps
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: set of k values (size ncomps)
'''  Loc: SRC/bilateral.h (127, 21)
'''  Org: [l_int32 * nc]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property nc as Integer()
	Get
		If Values.nc <> IntPtr.Zero Then 
	Dim _nc(1 -1) as Integer
	Marshal.Copy(Values.nc, _nc, 0, _nc.Length)
	Return _nc
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: mapping from intensity to lower k
'''  Loc: SRC/bilateral.h (128, 21)
'''  Org: [l_int32 * kindex]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property kindex as Integer()
	Get
		If Values.kindex <> IntPtr.Zero Then 
	Dim _kindex(1 -1) as Integer
	Marshal.Copy(Values.kindex, _kindex, 0, _kindex.Length)
	Return _kindex
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: mapping from intensity to fract k
'''  Loc: SRC/bilateral.h (129, 21)
'''  Org: [l_float32 * kfract]
'''  Msh: l_float32 * | 2:Float | Single() ... = Single
''' </summary>
ReadOnly Property kfract as Single()
	Get
		If Values.kfract <> IntPtr.Zero Then 
	Dim _kfract(1 -1) as Single
	Marshal.Copy(Values.kfract, _kfract, 0, _kfract.Length)
	Return _kfract
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: intermediate result images (PBC)
'''  Loc: SRC/bilateral.h (130, 21)
'''  Org: [struct Pixa * pixac]
'''  Msh: struct Pixa * | 2:Struct | Pixa Typedef: Pixa = Pixa
''' </summary>
ReadOnly Property pixac as Pixa
	Get
			If Values.pixac <> IntPtr.Zero Then 
		Return New Pixa(Values.pixac)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: lineptrs for pixac
'''  Loc: SRC/bilateral.h (131, 21)
'''  Org: [l_uint32 *** lineset]
'''  Msh: l_uint32 *** | 3:UInt | List (of List ( of List (of Byte()))) ... UInt = bigger  Byte[4]
''' </summary>
ReadOnly Property lineset as List (of List ( of List (of Byte())))
	Get
		Dim _Data1(4 - 1) As Byte
Dim _DataFin As new List (of List ( of List (of Byte())))
Marshal.Copy(Values.lineset, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(4 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.AddRange(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Bilateral
		Marshal.PtrToStructure (Pointer, Values)
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
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> 		Public lineset as IntPTR
	End Class
End Class


#End Region
#Region "SRC/bmp.h"
' SRC/bmp.h (50, 8)
' BMP file header
Public Class BMP_FileHeader
	Property Pointer as IntPTR
	Private Values as Marshal_BMP_FileHeader

''' <summary>
''' Brf: file type; must be "BM"
'''  Loc: SRC/bmp.h (52, 20)
'''  Org: [l_int16 bfType]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfType as Short
	Get
				Return Values.bfType
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: length of the file; sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
'''  Loc: SRC/bmp.h (53, 20)
'''  Org: [l_int16 bfSize]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfSize as Short
	Get
				Return Values.bfSize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: remainder of the bfSize field
'''  Loc: SRC/bmp.h (58, 20)
'''  Org: [l_int16 bfFill1]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfFill1 as Short
	Get
				Return Values.bfFill1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (59, 20)
'''  Org: [l_int16 bfReserved1]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfReserved1 as Short
	Get
				Return Values.bfReserved1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (60, 20)
'''  Org: [l_int16 bfReserved2]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfReserved2 as Short
	Get
				Return Values.bfReserved2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: offset from beginning of file
'''  Loc: SRC/bmp.h (61, 20)
'''  Org: [l_int16 bfOffBits]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfOffBits as Short
	Get
				Return Values.bfOffBits
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: remainder of the bfOffBits field
'''  Loc: SRC/bmp.h (62, 20)
'''  Org: [l_int16 bfFill2]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property bfFill2 as Short
	Get
				Return Values.bfFill2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_BMP_FileHeader
		Marshal.PtrToStructure (Pointer, Values)
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
' BMP info header
Public Class BMP_InfoHeader
	Property Pointer as IntPTR
	Private Values as Marshal_BMP_InfoHeader

''' <summary>
''' Brf: size of the BMP_InfoHeader struct
'''  Loc: SRC/bmp.h (77, 20)
'''  Org: [l_int32 biSize]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biSize as Integer
	Get
				Return Values.biSize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: bitmap width in pixels
'''  Loc: SRC/bmp.h (78, 20)
'''  Org: [l_int32 biWidth]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biWidth as Integer
	Get
				Return Values.biWidth
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: bitmap height in pixels
'''  Loc: SRC/bmp.h (79, 20)
'''  Org: [l_int32 biHeight]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biHeight as Integer
	Get
				Return Values.biHeight
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of bitmap planes
'''  Loc: SRC/bmp.h (80, 20)
'''  Org: [l_int16 biPlanes]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property biPlanes as Short
	Get
				Return Values.biPlanes
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of bits per pixel
'''  Loc: SRC/bmp.h (81, 20)
'''  Org: [l_int16 biBitCount]
'''  Msh: l_int16 = bigger  1:*
''' </summary>
ReadOnly Property biBitCount as Short
	Get
				Return Values.biBitCount
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: compress format (0 == uncompressed)
'''  Loc: SRC/bmp.h (82, 20)
'''  Org: [l_int32 biCompression]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biCompression as Integer
	Get
				Return Values.biCompression
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: size of image in bytes
'''  Loc: SRC/bmp.h (83, 20)
'''  Org: [l_int32 biSizeImage]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biSizeImage as Integer
	Get
				Return Values.biSizeImage
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pixels per meter in x direction
'''  Loc: SRC/bmp.h (84, 20)
'''  Org: [l_int32 biXPelsPerMeter]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biXPelsPerMeter as Integer
	Get
				Return Values.biXPelsPerMeter
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pixels per meter in y direction
'''  Loc: SRC/bmp.h (85, 20)
'''  Org: [l_int32 biYPelsPerMeter]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biYPelsPerMeter as Integer
	Get
				Return Values.biYPelsPerMeter
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of colors used
'''  Loc: SRC/bmp.h (86, 20)
'''  Org: [l_int32 biClrUsed]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biClrUsed as Integer
	Get
				Return Values.biClrUsed
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of important colors used
'''  Loc: SRC/bmp.h (87, 20)
'''  Org: [l_int32 biClrImportant]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property biClrImportant as Integer
	Get
				Return Values.biClrImportant
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_BMP_InfoHeader
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rc as Integer
	Get
				Return Values.rc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (160, 21)
'''  Org: [l_int32 gc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property gc as Integer
	Get
				Return Values.gc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (160, 25)
'''  Org: [l_int32 bc]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bc as Integer
	Get
				Return Values.bc
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (161, 17)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (162, 17)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (163, 17)
'''  Org: [l_int32 nleaves]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nleaves as Integer
	Get
				Return Values.nleaves
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (164, 17)
'''  Org: [l_int32 bleaf]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bleaf as Integer
	Get
				Return Values.bleaf
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_ColorQuantCell
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property n as Single
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (193, 16)
'''  Org: [l_int32 octindex]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property octindex as Integer
	Get
				Return Values.octindex
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 16)
'''  Org: [l_int32 rcum]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rcum as Integer
	Get
				Return Values.rcum
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 22)
'''  Org: [l_int32 gcum]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property gcum as Integer
	Get
				Return Values.gcum
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (194, 28)
'''  Org: [l_int32 bcum]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bcum as Integer
	Get
				Return Values.bcum
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 16)
'''  Org: [l_int32 rval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rval as Integer
	Get
				Return Values.rval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 22)
'''  Org: [l_int32 gval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property gval as Integer
	Get
				Return Values.gval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (195, 28)
'''  Org: [l_int32 bval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bval as Integer
	Get
				Return Values.bval
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_OctcubeQuantCell
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property npix as Single
	Get
				Return Values.npix
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (209, 22)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (210, 22)
'''  Org: [l_int32 rval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property rval as Integer
	Get
				Return Values.rval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (211, 22)
'''  Org: [l_int32 gval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property gval as Integer
	Get
				Return Values.gval
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant1.c (212, 22)
'''  Org: [l_int32 bval]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property bval as Integer
	Get
				Return Values.bval
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_OctcubePop
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property sortparam as Single
	Get
				Return Values.sortparam
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (181, 22)
'''  Org: [l_int32 npix]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property npix as Integer
	Get
				Return Values.npix
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (182, 22)
'''  Org: [l_int32 vol]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property vol as Integer
	Get
				Return Values.vol
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (183, 22)
'''  Org: [l_int32 r1]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property r1 as Integer
	Get
				Return Values.r1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (184, 22)
'''  Org: [l_int32 r2]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property r2 as Integer
	Get
				Return Values.r2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (185, 22)
'''  Org: [l_int32 g1]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property g1 as Integer
	Get
				Return Values.g1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (186, 22)
'''  Org: [l_int32 g2]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property g2 as Integer
	Get
				Return Values.g2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (187, 22)
'''  Org: [l_int32 b1]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property b1 as Integer
	Get
				Return Values.b1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\colorquant2.c (188, 22)
'''  Org: [l_int32 b2]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property b2 as Integer
	Get
				Return Values.b2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Box3d
		Marshal.PtrToStructure (Pointer, Values)
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
' The struct FillSeg is used by the Heckbert seedfill algorithm to hold information about image segments that are waiting to be investigated. We use two Stacks, one to hold the FillSegs in use, and an auxiliary Stack as a reservoir to hold FillSegs for re-use.
Public Class FillSeg
	Property Pointer as IntPTR
	Private Values as Marshal_FillSeg

''' <summary>
''' Brf: left edge of run
'''  Loc: SRC\conncomp.c (101, 16)
'''  Org: [l_int32 xleft]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xleft as Integer
	Get
				Return Values.xleft
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: right edge of run
'''  Loc: SRC\conncomp.c (102, 16)
'''  Org: [l_int32 xright]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property xright as Integer
	Get
				Return Values.xright
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: run y
'''  Loc: SRC\conncomp.c (103, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: parent segment direction: 1 above, -1 below)
'''  Loc: SRC\conncomp.c (104, 16)
'''  Org: [l_int32 dy]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property dy as Integer
	Get
				Return Values.dy
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_FillSeg
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: JBCLASSER * | 2:Struct | JBCLASSER Typedef: JbClasser = JbClasser
''' </summary>
ReadOnly Property classer as JBCLASSER
	Get
			If Values.classer <> IntPtr.Zero Then 
		Return New JbClasser(Values.classer)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (239, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property w as Integer
	Get
				Return Values.w
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (240, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property h as Integer
	Get
				Return Values.h
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (241, 22)
'''  Org: [l_int32 i]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property i as Integer
	Get
				Return Values.i
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (242, 22)
'''  Org: [L_DNA * dna]
'''  Msh: L_DNA * | 2:Struct | L_DNA Typedef: L_Dna = L_Dna
''' </summary>
ReadOnly Property dna as L_DNA
	Get
			If Values.dna <> IntPtr.Zero Then 
		Return New L_Dna(Values.dna)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (243, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_JbFindTemplatesState
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: jmp_buf = bigger  1:*
''' </summary>
ReadOnly Property jmpbuf as Char
	Get
				Return Values.jmpbuf
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jpegio.c (166, 15)
'''  Org: [l_uint8 * comment]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property comment as Byte()
	Get
		If Values.comment <> IntPtr.Zero Then 
	Dim _comment(1 -1) as Byte
	Marshal.Copy(Values.comment, _comment, 0, _comment.Length)
	Return _comment
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_callback_data
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property distance as Single
	Get
				Return Values.distance
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (78, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property x as Integer
	Get
				Return Values.x
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (79, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (80, 16)
'''  Org: [l_uint32 val]
'''  Msh: l_uint32 = bigger  1:*
''' </summary>
ReadOnly Property val as UInteger
	Get
				Return Values.val
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\maze.c (81, 16)
'''  Org: [l_int32 dir]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property dir as Integer
	Get
				Return Values.dir
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_MazeElement
		Marshal.PtrToStructure (Pointer, Values)
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
' Partition element
Public Class PartitionElement
	Property Pointer as IntPTR
	Private Values as Marshal_PartitionElement

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (49, 16)
'''  Org: [l_float32 size]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property size as Single
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (50, 16)
'''  Org: [BOX * box]
'''  Msh: BOX * | 2:Struct | BOX Typedef: Box = Box
''' </summary>
ReadOnly Property box as BOX
	Get
			If Values.box <> IntPtr.Zero Then 
		Return New Box(Values.box)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (51, 16)
'''  Org: [BOXA * boxa]
'''  Msh: BOXA * | 2:Struct | BOXA Typedef: Boxa = Boxa
''' </summary>
ReadOnly Property boxa as BOXA
	Get
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PartitionElement
		Marshal.PtrToStructure (Pointer, Values)
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
' Pix memory manager
Public Class PixMemoryManager
	Property Pointer as IntPTR
	Private Values as Marshal_PixMemoryManager

''' <summary>
''' Brf: 
'''  Loc: SRC\pix1.c (220, 17)
'''  Org: [alloc_fn allocator]
'''  Msh: alloc_fn = bigger  1:*
''' </summary>
ReadOnly Property allocator as IntPTR
	Get
				Return Values.allocator
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\pix1.c (221, 17)
'''  Org: [dealloc_fn deallocator]
'''  Msh: dealloc_fn = bigger  1:*
''' </summary>
ReadOnly Property deallocator as IntPTR
	Get
				Return Values.deallocator
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixMemoryManager
		Marshal.PtrToStructure (Pointer, Values)
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
' Pix memory storage
Public Class PixMemoryStore
	Property Pointer as IntPTR
	Private Values as Marshal_PixMemoryStore

''' <summary>
''' Brf: Holds ptrs to allocated memory
'''  Loc: SRC\pixalloc.c (115, 22)
'''  Org: [struct L_Ptraa * paa]
'''  Msh: struct L_Ptraa * | 2:Struct | L_Ptraa Typedef: L_Ptraa = L_Ptraa
''' </summary>
ReadOnly Property paa as L_Ptraa
	Get
			If Values.paa <> IntPtr.Zero Then 
		Return New L_Ptraa(Values.paa)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Pix smaller than this (in bytes)
'''  Loc: SRC\pixalloc.c (116, 22)
'''  Org: [size_t minsize]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property minsize as UInteger
	Get
				Return Values.minsize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Smallest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (118, 22)
'''  Org: [size_t smallest]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property smallest as UInteger
	Get
				Return Values.smallest
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Larest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (119, 22)
'''  Org: [size_t largest]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property largest as UInteger
	Get
				Return Values.largest
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Size of allocated block w/ all chunks
'''  Loc: SRC\pixalloc.c (120, 22)
'''  Org: [size_t nbytes]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property nbytes as UInteger
	Get
				Return Values.nbytes
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Num of power-of-2 sizes pre-alloc'd
'''  Loc: SRC\pixalloc.c (121, 22)
'''  Org: [l_int32 nlevels]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property nlevels as Integer
	Get
				Return Values.nlevels
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Mem sizes at each power-of-2 level
'''  Loc: SRC\pixalloc.c (122, 22)
'''  Org: [size_t * sizes]
'''  Msh: size_t * | 2:UInt | Byte() ... UInt = 4 Byte * Len)
''' </summary>
ReadOnly Property sizes as Byte()
	Get
		Dim _sizes(1 -1) as Byte
Marshal.Copy(Values.sizes, _sizes, 0, _sizes.Length)
Return _sizes
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: Number of mem alloc'd at each size
'''  Loc: SRC\pixalloc.c (123, 22)
'''  Org: [l_int32 * allocarray]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property allocarray as Integer()
	Get
		If Values.allocarray <> IntPtr.Zero Then 
	Dim _allocarray(1 -1) as Integer
	Marshal.Copy(Values.allocarray, _allocarray, 0, _allocarray.Length)
	Return _allocarray
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr to allocated array
'''  Loc: SRC\pixalloc.c (124, 22)
'''  Org: [l_uint32 * baseptr]
'''  Msh: l_uint32 * | 2:UInt | Byte() ... UInt = 4 Byte * Len)
''' </summary>
ReadOnly Property baseptr as Byte()
	Get
		Dim _baseptr(1 -1) as Byte
Marshal.Copy(Values.baseptr, _baseptr, 0, _baseptr.Length)
Return _baseptr
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr just beyond allocated memory
'''  Loc: SRC\pixalloc.c (125, 22)
'''  Org: [l_uint32 * maxptr]
'''  Msh: l_uint32 * | 2:UInt | Byte() ... UInt = 4 Byte * Len)
''' </summary>
ReadOnly Property maxptr as Byte()
	Get
		Dim _maxptr(1 -1) as Byte
Marshal.Copy(Values.maxptr, _maxptr, 0, _maxptr.Length)
Return _maxptr
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: array of ptrs to first chunk in size
'''  Loc: SRC\pixalloc.c (126, 22)
'''  Org: [l_uint32 ** firstptr]
'''  Msh: l_uint32 ** | 3:UInt | List (of Byte()) ... UInt nicht Marshalbar. Verwende 4 Bytes
''' </summary>
ReadOnly Property firstptr as List (of Byte())
	Get
		Dim _Data1(4 - 1) As Byte
Dim _DataFin As New List(Of Byte())
Marshal.Copy(Values.firstptr, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(4 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: total # of pix used (by level)
'''  Loc: SRC\pixalloc.c (127, 22)
'''  Org: [l_int32 * memused]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property memused as Integer()
	Get
		If Values.memused <> IntPtr.Zero Then 
	Dim _memused(1 -1) as Integer
	Marshal.Copy(Values.memused, _memused, 0, _memused.Length)
	Return _memused
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (128, 22)
'''  Org: [l_int32 * meminuse]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property meminuse as Integer()
	Get
		If Values.meminuse <> IntPtr.Zero Then 
	Dim _meminuse(1 -1) as Integer
	Marshal.Copy(Values.meminuse, _meminuse, 0, _meminuse.Length)
	Return _meminuse
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: max # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (129, 22)
'''  Org: [l_int32 * memmax]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property memmax as Integer()
	Get
		If Values.memmax <> IntPtr.Zero Then 
	Dim _memmax(1 -1) as Integer
	Marshal.Copy(Values.memmax, _memmax, 0, _memmax.Length)
	Return _memmax
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: # of pix alloc'd because
'''  Loc: SRC\pixalloc.c (130, 22)
'''  Org: [l_int32 * memempty]
'''  Msh: l_int32 * | 2:Int | Integer()
''' </summary>
ReadOnly Property memempty as Integer()
	Get
		If Values.memempty <> IntPtr.Zero Then 
	Dim _memempty(1 -1) as Integer
	Marshal.Copy(Values.memempty, _memempty, 0, _memempty.Length)
	Return _memempty
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: set to null if no logging
'''  Loc: SRC\pixalloc.c (132, 22)
'''  Org: [char * logfile]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property logfile as String
	Get
		If Values.logfile <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.logfile)
End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_PixMemoryStore
		Marshal.PtrToStructure (Pointer, Values)
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
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> 		Public firstptr as IntPTR
		Public memused as IntPTR
		Public meminuse as IntPTR
		Public memmax as IntPTR
		Public memempty as IntPTR
		Public logfile as IntPTR
	End Class
End Class


#End Region
#Region "SRC\pngio.c"
' SRC\pngio.c (1293, 8)
' A node in a linked list of memory buffers that hold I/O content
Public Class MemIOData
	Property Pointer as IntPTR
	Private Values as Marshal_MemIOData

''' <summary>
''' Brf: pointer to this node's I/O content
'''  Loc: SRC\pngio.c (1295, 17)
'''  Org: [char * m_Buffer]
'''  Msh: char * | 2:CharS | String
''' </summary>
ReadOnly Property m_Buffer as String
	Get
		If Values.m_Buffer <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.m_Buffer)
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of I/O content bytes read or written
'''  Loc: SRC\pngio.c (1296, 17)
'''  Org: [l_int32 m_Count]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property m_Count as Integer
	Get
				Return Values.m_Count
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: allocated size of m_buffer
'''  Loc: SRC\pngio.c (1297, 17)
'''  Org: [l_int32 m_Size]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property m_Size as Integer
	Get
				Return Values.m_Size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pointer to the next node in the list;
'''  Loc: SRC\pngio.c (1298, 24)
'''  Org: [struct MemIOData * m_Next]
'''  Msh: struct MemIOData * | 2:Struct | MemIOData
''' </summary>
ReadOnly Property m_Next as MemIOData
	Get
			If Values.m_Next <> IntPtr.Zero Then 
		Return New MemIOData(Values.m_Next)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: pointer to the last node in the linked
'''  Loc: SRC\pngio.c (1300, 24)
'''  Org: [struct MemIOData * m_Last]
'''  Msh: struct MemIOData * | 2:Struct | MemIOData
''' </summary>
ReadOnly Property m_Last as MemIOData
	Get
			If Values.m_Last <> IntPtr.Zero Then 
		Return New MemIOData(Values.m_Last)
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_MemIOData
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_MemIOData
		Public m_Buffer as IntPTR
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
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property x as Integer
	Get
				Return Values.x
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\seedfill.c (173, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Pixel
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property size as Integer
	Get
				Return Values.size
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (155, 14)
'''  Org: [l_int32 size1]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property size1 as Integer
	Get
				Return Values.size1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (156, 14)
'''  Org: [l_int32 size2]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property size2 as Integer
	Get
				Return Values.size2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (157, 14)
'''  Org: [char [20] selnameh1]
'''  Msh: char [20] = bigger  1:*
''' </summary>
ReadOnly Property selnameh1 as Char
	Get
				Return Values.selnameh1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (158, 14)
'''  Org: [char [20] selnameh2]
'''  Msh: char [20] = bigger  1:*
''' </summary>
ReadOnly Property selnameh2 as Char
	Get
				Return Values.selnameh2
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (159, 14)
'''  Org: [char [20] selnamev1]
'''  Msh: char [20] = bigger  1:*
''' </summary>
ReadOnly Property selnamev1 as Char
	Get
				Return Values.selnamev1
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\sel1.c (160, 14)
'''  Org: [char [20] selnamev2]
'''  Msh: char [20] = bigger  1:*
''' </summary>
ReadOnly Property selnamev2 as Char
	Get
				Return Values.selnamev2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_CompParameterMap
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_CompParameterMap
		Public size as Integer
		Public size1 as Integer
		Public size2 as Integer
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		Public selnameh1 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		Public selnameh2 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		Public selnamev1 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		Public selnamev2 as Char
	End Class
End Class


#End Region
#Region "SRC\stringcode.c"
' SRC\stringcode.c (95, 8)
' Associations between names and functions
Public Class L_GenAssoc
	Property Pointer as IntPTR
	Private Values as Marshal_L_GenAssoc

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (97, 14)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (98, 14)
'''  Org: [char [16] type]
'''  Msh: char [16] = bigger  1:*
''' </summary>
ReadOnly Property type as Char
	Get
				Return Values.type
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (99, 14)
'''  Org: [char [16] structname]
'''  Msh: char [16] = bigger  1:*
''' </summary>
ReadOnly Property structname as Char
	Get
				Return Values.structname
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (100, 14)
'''  Org: [char [16] reader]
'''  Msh: char [16] = bigger  1:*
''' </summary>
ReadOnly Property reader as Char
	Get
				Return Values.reader
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\stringcode.c (101, 14)
'''  Org: [char [20] memreader]
'''  Msh: char [20] = bigger  1:*
''' </summary>
ReadOnly Property memreader as Char
	Get
				Return Values.memreader
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_GenAssoc
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_GenAssoc
		Public index as Integer
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		Public type as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		Public structname as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		Public reader as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		Public memreader as Char
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
'''  Msh: int = bigger  1:*
''' </summary>
ReadOnly Property vflip as Integer
	Get
				Return Values.vflip
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (157, 9)
'''  Org: [int hflip]
'''  Msh: int = bigger  1:*
''' </summary>
ReadOnly Property hflip as Integer
	Get
				Return Values.hflip
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (158, 9)
'''  Org: [int rotate]
'''  Msh: int = bigger  1:*
''' </summary>
ReadOnly Property rotate as Integer
	Get
				Return Values.rotate
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_tiff_transform
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_tiff_transform
		Public vflip as Integer
		Public hflip as Integer
		Public rotate as Integer
	End Class
End Class


' SRC\tiffio.c (2174, 8)
' Memory stream buffer used with TIFFClientOpen()
Public Class L_Memstream
	Property Pointer as IntPTR
	Private Values as Marshal_L_Memstream

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2176, 16)
'''  Org: [l_uint8 * buffer]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </summary>
ReadOnly Property buffer as Byte()
	Get
		If Values.buffer <> IntPtr.Zero Then 
	Dim _buffer(1 -1) as Byte
	Marshal.Copy(Values.buffer, _buffer, 0, _buffer.Length)
	Return _buffer
End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2178, 16)
'''  Org: [size_t bufsize]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property bufsize as UInteger
	Get
				Return Values.bufsize
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2180, 16)
'''  Org: [size_t offset]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property offset as UInteger
	Get
				Return Values.offset
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2181, 16)
'''  Org: [size_t hw]
'''  Msh: size_t = bigger  1:*
''' </summary>
ReadOnly Property hw as UInteger
	Get
				Return Values.hw
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2182, 16)
'''  Org: [l_uint8 ** poutdata]
'''  Msh: l_uint8 ** | 3:Else | List(Of Byte())
''' </summary>
ReadOnly Property poutdata as List(Of Byte())
	Get
		Dim _Data1(1 - 1) As Byte
Dim _DataFin As New List(Of Byte())
Marshal.Copy(Values.poutdata, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2183, 16)
'''  Org: [size_t * poutsize]
'''  Msh: size_t * | 2:UInt | Byte() ... UInt = 4 Byte * Len)
''' </summary>
ReadOnly Property poutsize as Byte()
	Get
		Dim _poutsize(1 -1) as Byte
Marshal.Copy(Values.poutsize, _poutsize, 0, _poutsize.Length)
Return _poutsize
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_Memstream
		Marshal.PtrToStructure (Pointer, Values)
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
' New pixel coordinates
Public Class L_NewPixel
	Property Pointer as IntPTR
	Private Values as Marshal_L_NewPixel

''' <summary>
''' Brf: x coordinate
'''  Loc: SRC\watershed.c (126, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property x as Integer
	Get
				Return Values.x
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y coordinate
'''  Loc: SRC\watershed.c (127, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_NewPixel
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_L_NewPixel
		Public x as Integer
		Public y as Integer
	End Class
End Class


' SRC\watershed.c (132, 8)
' Wartshed pixel
Public Class L_WSPixel
	Property Pointer as IntPTR
	Private Values as Marshal_L_WSPixel

''' <summary>
''' Brf: pixel value
'''  Loc: SRC\watershed.c (134, 16)
'''  Org: [l_float32 val]
'''  Msh: l_float32 = bigger  1:*
''' </summary>
ReadOnly Property val as Single
	Get
				Return Values.val
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: x coordinate
'''  Loc: SRC\watershed.c (135, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property x as Integer
	Get
				Return Values.x
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: y coordinate
'''  Loc: SRC\watershed.c (136, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: label for set to which pixel belongs
'''  Loc: SRC\watershed.c (137, 16)
'''  Org: [l_int32 index]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_L_WSPixel
		Marshal.PtrToStructure (Pointer, Values)
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
'''  Msh: char [8] = bigger  1:*
''' </summary>
ReadOnly Property extension as Char
	Get
				Return Values.extension
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\writefile.c (142, 14)
'''  Org: [l_int32 format]
'''  Msh: l_int32 = bigger  1:*
''' </summary>
ReadOnly Property format as Integer
	Get
				Return Values.format
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_ExtensionMap
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

	<StructLayout(LayoutKind.Sequential)>
	Private Class Marshal_ExtensionMap
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> 		Public extension as Char
		Public format as Integer
	End Class
End Class


#End Region
