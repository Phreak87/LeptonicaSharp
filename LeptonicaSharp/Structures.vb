Imports System.Runtime.InteropServices

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
''' </summary>
ReadOnly Property stop_usec as Integer
	Get
				Return Values.stop_usec
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"start_sec:" & start_sec & " , " & 	"start_usec:" & start_usec & " , " & 	"stop_sec:" & stop_sec & " , " & 	"stop_usec:" & stop_usec & " , " & " "
End Function
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
''' </summary>
ReadOnly Property startx as Single
	Get
				Return Values.startx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: change in x value as i -- greater  i + 1
'''  Loc: SRC/array.h (65, 22)
'''  Org: [l_float32 delx]
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
''' </summary>
ReadOnly Property array as Single()
	Get
		Dim _array(values.n -1) as Single
Marshal.Copy(Values.array, _array, 0, _array.Length)
Return _array
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & 	"refcount:" & refcount & " , " & 	"startx:" & startx & " , " & 	"delx:" & delx & " , " & " "
End Function
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
''' </summary>
ReadOnly Property numa as  List (of Numa)
	Get
			If Values.numa <> IntPtr.Zero Then 
		Dim IntPTR_numa(values.n -1) as intPTR
		Dim Values_numa as new List (of Numa)
		Marshal.Copy(Values.numa, IntPTR_numa, 0, values.n)
		For Each _PTR_ In IntPTR_numa : Values_numa.Add(New Numa(_PTR_)) : Next
		Return Values_numa
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & " "
End Function
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
''' </summary>
ReadOnly Property startx as Double
	Get
				Return Values.startx
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: change in x value as i -- greater  i + 1
'''  Loc: SRC/array.h (89, 22)
'''  Org: [l_float64 delx]
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
''' </summary>
ReadOnly Property array as Double()
	Get
		Dim _array(values.n -1) as Double
Marshal.Copy(Values.array, _array, 0, _array.Length)
Return _array
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & 	"refcount:" & refcount & " , " & 	"startx:" & startx & " , " & 	"delx:" & delx & " , " & " "
End Function
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
''' </summary>
ReadOnly Property dna as  List (of L_Dna)
	Get
			If Values.dna <> IntPtr.Zero Then 
		Dim IntPTR_dna(values.n -1) as intPTR
		Dim Values_dna as new List (of L_Dna)
		Marshal.Copy(Values.dna, IntPTR_dna, 0, values.n)
		For Each _PTR_ In IntPTR_dna : Values_dna.Add(New L_Dna(_PTR_)) : Next
		Return Values_dna
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & " "
End Function
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
''' </summary>
ReadOnly Property dna as  List (of L_Dna)
	Get
			If Values.dna <> IntPtr.Zero Then 
		Dim IntPTR_dna(1 -1) as intPTR
		Dim Values_dna as new List (of L_Dna)
		Marshal.Copy(Values.dna, IntPTR_dna, 0, 1)
		For Each _PTR_ In IntPTR_dna : Values_dna.Add(New L_Dna(_PTR_)) : Next
		Return Values_dna
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nbuckets:" & nbuckets & " , " & 	"initsize:" & initsize & " , " & " "
End Function
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
''' </summary>
ReadOnly Property array as  List (of String)
	Get
		Dim Marshal_array(values.n -1) as IntPTR
Dim Values_array as new List (of String)
Marshal.Copy(Values.array, Marshal_array, 0, Marshal_array.Length)
For Each Marshal_Value In Marshal_array : Values_array.Add(Marshal.PtrToStringAnsi(Marshal_Value)) : Next
Return Values_array
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & 	"refcount:" & refcount & " , " & " "
End Function
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
''' </summary>
ReadOnly Property data as Byte()
	Get
		Dim _data(values.nalloc -1) as Byte
Marshal.Copy(Values.data, _data, 0, _data.Length)
Return _data
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"size:" & size & " , " & 	"refcount:" & refcount & " , " & " "
End Function
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
''' </summary>
ReadOnly Property array as Byte()
	Get
		Dim _array(values.n -1) as Byte
Marshal.Copy(Values.array, _array, 0, _array.Length)
Return _array
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & 	"nwritten:" & nwritten & " , " & " "
End Function
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
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array as IntPTR()
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
''' </summary>
ReadOnly Property direction as Integer
	Get
				Return Values.direction
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"n:" & n & " , " & 	"direction:" & direction & " , " & " "
End Function
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
''' </summary>
ReadOnly Property data as IntPTR
	Get
		Return data =  Values.data
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return " "
End Function
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
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array as IntPTR()
		Marshal.Copy(Values.array, _array, 0, values.nalloc)
		Return _array
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"imax:" & imax & " , " & 	"nactual:" & nactual & " , " & " "
End Function
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
''' </summary>
ReadOnly Property ptra as  List (of L_Ptra)
	Get
			If Values.ptra <> IntPtr.Zero Then 
		Dim IntPTR_ptra(values.nalloc -1) as intPTR
		Dim Values_ptra as new List (of L_Ptra)
		Marshal.Copy(Values.ptra, IntPTR_ptra, 0, values.nalloc)
		For Each _PTR_ In IntPTR_ptra : Values_ptra.Add(New L_Ptra(_PTR_)) : Next
		Return Values_ptra
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & " "
End Function
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
''' </summary>
ReadOnly Property array as IntPTR()
	Get
			If Values.array <> IntPtr.Zero Then 
		Dim _array as IntPTR()
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
Public Overrides Function ToString() As String
Return 	"nalloc:" & nalloc & " , " & 	"nhead:" & nhead & " , " & 	"nelem:" & nelem & " , " & " "
End Function
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
''' </summary>
ReadOnly Property ptype as IntPTR
	Get
		Return ptype =  Values.ptype
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"itype:" & itype & " , " & 	"utype:" & utype & " , " & 	"ftype:" & ftype & " , " & " "
End Function
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
''' </summary>
ReadOnly Property keytype as Integer
	Get
				Return Values.keytype
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"keytype:" & keytype & " , " & " "
End Function
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
''' </summary>
ReadOnly Property key as Object
	Get
            Dim _key(1 - 1) As Byte
            Marshal.Copy(Values.key, _key, 0, _key.Length)
            Return _key
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (79, 28)
    '''  Org: [union Rb_Type value]
    ''' </summary>
    ReadOnly Property value As Object
        Get
            Dim _value(1 - 1) As Byte
            Marshal.Copy(Values.value, _value, 0, _value.Length)
            Return _value
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (80, 28)
    '''  Org: [struct L_Rbtree_Node * left]
    ''' </summary>
    ReadOnly Property left As L_Rbtree_Node
        Get
            If Values.left <> IntPtr.Zero Then
                Return New L_Rbtree_Node(Values.left)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (81, 28)
    '''  Org: [struct L_Rbtree_Node * right]
    ''' </summary>
    ReadOnly Property right As L_Rbtree_Node
        Get
            If Values.right <> IntPtr.Zero Then
                Return New L_Rbtree_Node(Values.right)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (82, 28)
    '''  Org: [struct L_Rbtree_Node * parent]
    ''' </summary>
    ReadOnly Property parent As L_Rbtree_Node
        Get
            If Values.parent <> IntPtr.Zero Then
                Return New L_Rbtree_Node(Values.parent)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 
    '''  Loc: SRC/rbtree.h (83, 28)
    '''  Org: [l_int32 color]
    ''' </summary>
    ReadOnly Property color As Integer
        Get
            Return Values.color
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "color:" & color & " , " & " "
    End Function
    Sub New(PTR As IntPtr)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Rbtree_Node
        Marshal.PtrToStructure(Pointer, Values)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_L_Rbtree_Node
        Public key As IntPtr
        Public value As IntPtr
        Public left As IntPtr
        Public right As IntPtr
        Public parent As IntPtr
        Public color As Integer
    End Class
End Class


#End Region
#Region "SRC/stack.h"
' SRC/stack.h (59, 8)
' Expandable pointer stack for arbitrary void* data. Note that array[n] is the first null ptr in the array
Public Class L_Stack
    Property Pointer As IntPTR
    Private Values As Marshal_L_Stack

    ''' <summary>
    ''' Brf: size of ptr array
    '''  Loc: SRC/stack.h (61, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of stored elements
    '''  Loc: SRC/stack.h (62, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ptr array
    '''  Loc: SRC/stack.h (63, 22)
    '''  Org: [void ** array]
    ''' </summary>
    ReadOnly Property array As IntPTR()
        Get
            If Values.array <> IntPtr.Zero Then
                Dim _array As IntPTR()
                Marshal.Copy(Values.array, _array, 0, values.n)
                Return _array
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: auxiliary stack
    '''  Loc: SRC/stack.h (64, 22)
    '''  Org: [struct L_Stack * auxstack]
    ''' </summary>
    ReadOnly Property auxstack As L_Stack
        Get
            If Values.auxstack <> IntPtr.Zero Then
                Return New L_Stack(Values.auxstack)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "nalloc:" & nalloc & " , " & "n:" & n & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Stack
        Marshal.PtrToStructure(Pointer, Values)
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
' Data structure to hold bitmap fonts and related data
Public Class L_Bmf
    Property Pointer As IntPTR
    Private Values As Marshal_L_Bmf

    ''' <summary>
    ''' Brf: pixa of bitmaps for 93 characters
    '''  Loc: SRC/bmf.h (47, 19)
    '''  Org: [struct Pixa * pixa]
    ''' </summary>
    ReadOnly Property pixa As Pixa
        Get
            If Values.pixa <> IntPtr.Zero Then
                Return New Pixa(Values.pixa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: font size (in points at 300 ppi)
    '''  Loc: SRC/bmf.h (48, 19)
    '''  Org: [l_int32 size]
    ''' </summary>
    ReadOnly Property size As Integer
        Get
            Return Values.size
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: directory containing font bitmaps
    '''  Loc: SRC/bmf.h (49, 19)
    '''  Org: [char * directory]
    ''' </summary>
    ReadOnly Property directory As String
        Get
            Return Values.directory
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: baseline offset for ascii 33 - 57
    '''  Loc: SRC/bmf.h (50, 19)
    '''  Org: [l_int32 baseline1]
    ''' </summary>
    ReadOnly Property baseline1 As Integer
        Get
            Return Values.baseline1
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: baseline offset for ascii 58 - 91
    '''  Loc: SRC/bmf.h (51, 19)
    '''  Org: [l_int32 baseline2]
    ''' </summary>
    ReadOnly Property baseline2 As Integer
        Get
            Return Values.baseline2
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: baseline offset for ascii 93 - 126
    '''  Loc: SRC/bmf.h (52, 19)
    '''  Org: [l_int32 baseline3]
    ''' </summary>
    ReadOnly Property baseline3 As Integer
        Get
            Return Values.baseline3
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max height of line of chars
    '''  Loc: SRC/bmf.h (53, 19)
    '''  Org: [l_int32 lineheight]
    ''' </summary>
    ReadOnly Property lineheight As Integer
        Get
            Return Values.lineheight
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pixel dist between char bitmaps
    '''  Loc: SRC/bmf.h (54, 19)
    '''  Org: [l_int32 kernwidth]
    ''' </summary>
    ReadOnly Property kernwidth As Integer
        Get
            Return Values.kernwidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pixel dist between word bitmaps
    '''  Loc: SRC/bmf.h (55, 19)
    '''  Org: [l_int32 spacewidth]
    ''' </summary>
    ReadOnly Property spacewidth As Integer
        Get
            Return Values.spacewidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: extra vertical space between text lines
    '''  Loc: SRC/bmf.h (56, 19)
    '''  Org: [l_int32 vertlinesep]
    ''' </summary>
    ReadOnly Property vertlinesep As Integer
        Get
            Return Values.vertlinesep
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: table mapping ascii -- greater  font index
    '''  Loc: SRC/bmf.h (57, 19)
    '''  Org: [l_int32 * fonttab]
    ''' </summary>
    ReadOnly Property fonttab As Integer()
        Get
            Dim _fonttab(1 - 1) As Integer
            Marshal.Copy(Values.fonttab, _fonttab, 0, _fonttab.Length)
            Return _fonttab
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: table mapping ascii -- greater  baseline offset
    '''  Loc: SRC/bmf.h (58, 19)
    '''  Org: [l_int32 * baselinetab]
    ''' </summary>
    ReadOnly Property baselinetab As Integer()
        Get
            Dim _baselinetab(1 - 1) As Integer
            Marshal.Copy(Values.baselinetab, _baselinetab, 0, _baselinetab.Length)
            Return _baselinetab
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: table mapping ascii -- greater  char width
    '''  Loc: SRC/bmf.h (59, 19)
    '''  Org: [l_int32 * widthtab]
    ''' </summary>
    ReadOnly Property widthtab As Integer()
        Get
            Dim _widthtab(1 - 1) As Integer
            Marshal.Copy(Values.widthtab, _widthtab, 0, _widthtab.Length)
            Return _widthtab
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "size:" & size & " , " & "directory:" & directory & " , " & "baseline1:" & baseline1 & " , " & "baseline2:" & baseline2 & " , " & "baseline3:" & baseline3 & " , " & "lineheight:" & lineheight & " , " & "kernwidth:" & kernwidth & " , " & "spacewidth:" & spacewidth & " , " & "vertlinesep:" & vertlinesep & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Bmf
        Marshal.PtrToStructure(Pointer, Values)
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
' CCBord contains:
Public Class CCBord
    Property Pointer As IntPTR
    Private Values As Marshal_CCBord

    ''' <summary>
    ''' Brf: component bitmap (min size)
    '''  Loc: SRC/ccbord.h (93, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    ReadOnly Property pix As Pix
        Get
            If Values.pix <> IntPtr.Zero Then
                Return New Pix(Values.pix)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: regions of each closed curve
    '''  Loc: SRC/ccbord.h (94, 26)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    ReadOnly Property boxa As Boxa
        Get
            If Values.boxa <> IntPtr.Zero Then
                Return New Boxa(Values.boxa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: initial border pixel locations
    '''  Loc: SRC/ccbord.h (95, 26)
    '''  Org: [struct Pta * start]
    ''' </summary>
    ReadOnly Property start As Pta
        Get
            If Values.start <> IntPtr.Zero Then
                Return New Pta(Values.start)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of handles; start at 1
    '''  Loc: SRC/ccbord.h (96, 26)
    '''  Org: [l_int32 refcount]
    ''' </summary>
    ReadOnly Property refcount As Integer
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ptaa of chain pixels (local)
    '''  Loc: SRC/ccbord.h (97, 26)
    '''  Org: [struct Ptaa * local]
    ''' </summary>
    ReadOnly Property local As Ptaa
        Get
            If Values.local <> IntPtr.Zero Then
                Return New Ptaa(Values.local)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ptaa of chain pixels (global)
    '''  Loc: SRC/ccbord.h (98, 26)
    '''  Org: [struct Ptaa * global]
    ''' </summary>
    ReadOnly Property _global_ As Ptaa
        Get
            If Values._global_ <> IntPtr.Zero Then
                Return New Ptaa(Values._global_)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: numaa of chain code (step dir)
    '''  Loc: SRC/ccbord.h (99, 26)
    '''  Org: [struct Numaa * step]
    ''' </summary>
    ReadOnly Property _step_ As Numaa
        Get
            If Values._step_ <> IntPtr.Zero Then
                Return New Numaa(Values._step_)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pta of single chain (local)
    '''  Loc: SRC/ccbord.h (100, 26)
    '''  Org: [struct Pta * splocal]
    ''' </summary>
    ReadOnly Property splocal As Pta
        Get
            If Values.splocal <> IntPtr.Zero Then
                Return New Pta(Values.splocal)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pta of single chain (global)
    '''  Loc: SRC/ccbord.h (101, 26)
    '''  Org: [struct Pta * spglobal]
    ''' </summary>
    ReadOnly Property spglobal As Pta
        Get
            If Values.spglobal <> IntPtr.Zero Then
                Return New Pta(Values.spglobal)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_CCBord
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of CCBord
Public Class CCBorda
    Property Pointer As IntPTR
    Private Values As Marshal_CCBorda

    ''' <summary>
    ''' Brf: input pix (may be null)
    '''  Loc: SRC/ccbord.h (108, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    ReadOnly Property pix As Pix
        Get
            If Values.pix <> IntPtr.Zero Then
                Return New Pix(Values.pix)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: width of pix
    '''  Loc: SRC/ccbord.h (109, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height of pix
    '''  Loc: SRC/ccbord.h (110, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of ccbord in ptr array
    '''  Loc: SRC/ccbord.h (111, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of ccbord ptrs allocated
    '''  Loc: SRC/ccbord.h (112, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ccb ptr array
    '''  Loc: SRC/ccbord.h (113, 26)
    '''  Org: [struct CCBord ** ccb]
    ''' </summary>
    ReadOnly Property ccb As List(Of CCBord)
        Get
            If Values.ccb <> IntPtr.Zero Then
                Dim IntPTR_ccb(values.n - 1) As intPTR
                Dim Values_ccb As New List(Of CCBord)
                Marshal.Copy(Values.ccb, IntPTR_ccb, 0, values.n)
                For Each _PTR_ In IntPTR_ccb : Values_ccb.Add(New CCBord(_PTR_)) : Next
                Return Values_ccb
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "n:" & n & " , " & "nalloc:" & nalloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_CCBorda
        Marshal.PtrToStructure(Pointer, Values)
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
' Data structure to hold a number of Dewarp
Public Class L_Dewarpa
    Property Pointer As IntPTR
    Private Values As Marshal_L_Dewarpa

    ''' <summary>
    ''' Brf: size of dewarp ptr array
    '''  Loc: SRC/dewarp.h (115, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum page number in array
    '''  Loc: SRC/dewarp.h (116, 24)
    '''  Org: [l_int32 maxpage]
    ''' </summary>
    ReadOnly Property maxpage As Integer
        Get
            Return Values.maxpage
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of ptrs to page dewarp
    '''  Loc: SRC/dewarp.h (117, 24)
    '''  Org: [struct L_Dewarp ** dewarp]
    ''' </summary>
    ReadOnly Property dewarp As List(Of L_Dewarp)
        Get
            If Values.dewarp <> IntPtr.Zero Then
                Dim IntPTR_dewarp(values.nalloc - 1) As intPTR
                Dim Values_dewarp As New List(Of L_Dewarp)
                Marshal.Copy(Values.dewarp, IntPTR_dewarp, 0, values.nalloc)
                For Each _PTR_ In IntPTR_dewarp : Values_dewarp.Add(New L_Dewarp(_PTR_)) : Next
                Return Values_dewarp
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of ptrs to cached dewarps
    '''  Loc: SRC/dewarp.h (118, 24)
    '''  Org: [struct L_Dewarp ** dewarpcache]
    ''' </summary>
    ReadOnly Property dewarpcache As List(Of L_Dewarp)
        Get
            If Values.dewarpcache <> IntPtr.Zero Then
                Dim IntPTR_dewarpcache(values.nalloc - 1) As intPTR
                Dim Values_dewarpcache As New List(Of L_Dewarp)
                Marshal.Copy(Values.dewarpcache, IntPTR_dewarpcache, 0, values.nalloc)
                For Each _PTR_ In IntPTR_dewarpcache : Values_dewarpcache.Add(New L_Dewarp(_PTR_)) : Next
                Return Values_dewarpcache
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: list of page numbers for pages
    '''  Loc: SRC/dewarp.h (119, 24)
    '''  Org: [struct Numa * namodels]
    ''' </summary>
    ReadOnly Property namodels As Numa
        Get
            If Values.namodels <> IntPtr.Zero Then
                Return New Numa(Values.namodels)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: list of page numbers with either
    '''  Loc: SRC/dewarp.h (121, 24)
    '''  Org: [struct Numa * napages]
    ''' </summary>
    ReadOnly Property napages As Numa
        Get
            If Values.napages <> IntPtr.Zero Then
                Return New Numa(Values.napages)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reduction factor of input: 1 or 2
    '''  Loc: SRC/dewarp.h (123, 24)
    '''  Org: [l_int32 redfactor]
    ''' </summary>
    ReadOnly Property redfactor As Integer
        Get
            Return Values.redfactor
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: disparity arrays sampling factor
    '''  Loc: SRC/dewarp.h (124, 24)
    '''  Org: [l_int32 sampling]
    ''' </summary>
    ReadOnly Property sampling As Integer
        Get
            Return Values.sampling
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min number of long lines required
    '''  Loc: SRC/dewarp.h (125, 24)
    '''  Org: [l_int32 minlines]
    ''' </summary>
    ReadOnly Property minlines As Integer
        Get
            Return Values.minlines
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max distance for getting ref page
    '''  Loc: SRC/dewarp.h (126, 24)
    '''  Org: [l_int32 maxdist]
    ''' </summary>
    ReadOnly Property maxdist As Integer
        Get
            Return Values.maxdist
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum abs line curvature,
    '''  Loc: SRC/dewarp.h (127, 24)
    '''  Org: [l_int32 max_linecurv]
    ''' </summary>
    ReadOnly Property max_linecurv As Integer
        Get
            Return Values.max_linecurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: minimum abs diff line
    '''  Loc: SRC/dewarp.h (129, 24)
    '''  Org: [l_int32 min_diff_linecurv]
    ''' </summary>
    ReadOnly Property min_diff_linecurv As Integer
        Get
            Return Values.min_diff_linecurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum abs diff line
    '''  Loc: SRC/dewarp.h (131, 24)
    '''  Org: [l_int32 max_diff_linecurv]
    ''' </summary>
    ReadOnly Property max_diff_linecurv As Integer
        Get
            Return Values.max_diff_linecurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum abs left or right edge
    '''  Loc: SRC/dewarp.h (133, 24)
    '''  Org: [l_int32 max_edgeslope]
    ''' </summary>
    ReadOnly Property max_edgeslope As Integer
        Get
            Return Values.max_edgeslope
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum abs left or right edge
    '''  Loc: SRC/dewarp.h (135, 24)
    '''  Org: [l_int32 max_edgecurv]
    ''' </summary>
    ReadOnly Property max_edgecurv As Integer
        Get
            Return Values.max_edgecurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: maximum abs diff left-right
    '''  Loc: SRC/dewarp.h (137, 24)
    '''  Org: [l_int32 max_diff_edgecurv]
    ''' </summary>
    ReadOnly Property max_diff_edgecurv As Integer
        Get
            Return Values.max_diff_edgecurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: use both disparity arrays if
    '''  Loc: SRC/dewarp.h (139, 24)
    '''  Org: [l_int32 useboth]
    ''' </summary>
    ReadOnly Property useboth As Integer
        Get
            Return Values.useboth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: if there are multiple columns,
    '''  Loc: SRC/dewarp.h (141, 24)
    '''  Org: [l_int32 check_columns]
    ''' </summary>
    ReadOnly Property check_columns As Integer
        Get
            Return Values.check_columns
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: invalid models have been removed
    '''  Loc: SRC/dewarp.h (144, 24)
    '''  Org: [l_int32 modelsready]
    ''' </summary>
    ReadOnly Property modelsready As Integer
        Get
            Return Values.modelsready
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "nalloc:" & nalloc & " , " & "maxpage:" & maxpage & " , " & "redfactor:" & redfactor & " , " & "sampling:" & sampling & " , " & "minlines:" & minlines & " , " & "maxdist:" & maxdist & " , " & "max_linecurv:" & max_linecurv & " , " & "min_diff_linecurv:" & min_diff_linecurv & " , " & "max_diff_linecurv:" & max_diff_linecurv & " , " & "max_edgeslope:" & max_edgeslope & " , " & "max_edgecurv:" & max_edgecurv & " , " & "max_diff_edgecurv:" & max_diff_edgecurv & " , " & "useboth:" & useboth & " , " & "check_columns:" & check_columns & " , " & "modelsready:" & modelsready & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Dewarpa
        Marshal.PtrToStructure(Pointer, Values)
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
' Data structure for a single dewarp
Public Class L_Dewarp
    Property Pointer As IntPTR
    Private Values As Marshal_L_Dewarp

    ''' <summary>
    ''' Brf: ptr to parent (not owned)
    '''  Loc: SRC/dewarp.h (153, 24)
    '''  Org: [struct L_Dewarpa * dewa]
    ''' </summary>
    ReadOnly Property dewa As L_Dewarpa
        Get
            If Values.dewa <> IntPtr.Zero Then
                Return New L_Dewarpa(Values.dewa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: source pix, 1 bpp
    '''  Loc: SRC/dewarp.h (154, 24)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    ReadOnly Property pixs As Pix
        Get
            If Values.pixs <> IntPtr.Zero Then
                Return New Pix(Values.pixs)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sampled vert disparity array
    '''  Loc: SRC/dewarp.h (155, 24)
    '''  Org: [struct FPix * sampvdispar]
    ''' </summary>
    ReadOnly Property sampvdispar As FPix
        Get
            If Values.sampvdispar <> IntPtr.Zero Then
                Return New FPix(Values.sampvdispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sampled horiz disparity array
    '''  Loc: SRC/dewarp.h (156, 24)
    '''  Org: [struct FPix * samphdispar]
    ''' </summary>
    ReadOnly Property samphdispar As FPix
        Get
            If Values.samphdispar <> IntPtr.Zero Then
                Return New FPix(Values.samphdispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sampled slope h-disparity array
    '''  Loc: SRC/dewarp.h (157, 24)
    '''  Org: [struct FPix * sampydispar]
    ''' </summary>
    ReadOnly Property sampydispar As FPix
        Get
            If Values.sampydispar <> IntPtr.Zero Then
                Return New FPix(Values.sampydispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: full vert disparity array
    '''  Loc: SRC/dewarp.h (158, 24)
    '''  Org: [struct FPix * fullvdispar]
    ''' </summary>
    ReadOnly Property fullvdispar As FPix
        Get
            If Values.fullvdispar <> IntPtr.Zero Then
                Return New FPix(Values.fullvdispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: full horiz disparity array
    '''  Loc: SRC/dewarp.h (159, 24)
    '''  Org: [struct FPix * fullhdispar]
    ''' </summary>
    ReadOnly Property fullhdispar As FPix
        Get
            If Values.fullhdispar <> IntPtr.Zero Then
                Return New FPix(Values.fullhdispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: full slope h-disparity array
    '''  Loc: SRC/dewarp.h (160, 24)
    '''  Org: [struct FPix * fullydispar]
    ''' </summary>
    ReadOnly Property fullydispar As FPix
        Get
            If Values.fullydispar <> IntPtr.Zero Then
                Return New FPix(Values.fullydispar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sorted y val of midpoint each line
    '''  Loc: SRC/dewarp.h (161, 24)
    '''  Org: [struct Numa * namidys]
    ''' </summary>
    ReadOnly Property namidys As Numa
        Get
            If Values.namidys <> IntPtr.Zero Then
                Return New Numa(Values.namidys)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sorted curvature of each line
    '''  Loc: SRC/dewarp.h (162, 24)
    '''  Org: [struct Numa * nacurves]
    ''' </summary>
    ReadOnly Property nacurves As Numa
        Get
            If Values.nacurves <> IntPtr.Zero Then
                Return New Numa(Values.nacurves)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: width of source image
    '''  Loc: SRC/dewarp.h (163, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height of source image
    '''  Loc: SRC/dewarp.h (164, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: page number; important for reuse
    '''  Loc: SRC/dewarp.h (165, 24)
    '''  Org: [l_int32 pageno]
    ''' </summary>
    ReadOnly Property pageno As Integer
        Get
            Return Values.pageno
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sampling factor of disparity arrays
    '''  Loc: SRC/dewarp.h (166, 24)
    '''  Org: [l_int32 sampling]
    ''' </summary>
    ReadOnly Property sampling As Integer
        Get
            Return Values.sampling
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reduction factor of pixs: 1 or 2
    '''  Loc: SRC/dewarp.h (167, 24)
    '''  Org: [l_int32 redfactor]
    ''' </summary>
    ReadOnly Property redfactor As Integer
        Get
            Return Values.redfactor
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min number of long lines required
    '''  Loc: SRC/dewarp.h (168, 24)
    '''  Org: [l_int32 minlines]
    ''' </summary>
    ReadOnly Property minlines As Integer
        Get
            Return Values.minlines
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of long lines found
    '''  Loc: SRC/dewarp.h (169, 24)
    '''  Org: [l_int32 nlines]
    ''' </summary>
    ReadOnly Property nlines As Integer
        Get
            Return Values.nlines
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min line curvature in micro-units
    '''  Loc: SRC/dewarp.h (170, 24)
    '''  Org: [l_int32 mincurv]
    ''' </summary>
    ReadOnly Property mincurv As Integer
        Get
            Return Values.mincurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max line curvature in micro-units
    '''  Loc: SRC/dewarp.h (171, 24)
    '''  Org: [l_int32 maxcurv]
    ''' </summary>
    ReadOnly Property maxcurv As Integer
        Get
            Return Values.maxcurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: left edge slope in milli-units
    '''  Loc: SRC/dewarp.h (172, 24)
    '''  Org: [l_int32 leftslope]
    ''' </summary>
    ReadOnly Property leftslope As Integer
        Get
            Return Values.leftslope
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: right edge slope in milli-units
    '''  Loc: SRC/dewarp.h (173, 24)
    '''  Org: [l_int32 rightslope]
    ''' </summary>
    ReadOnly Property rightslope As Integer
        Get
            Return Values.rightslope
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: left edge curvature in micro-units
    '''  Loc: SRC/dewarp.h (174, 24)
    '''  Org: [l_int32 leftcurv]
    ''' </summary>
    ReadOnly Property leftcurv As Integer
        Get
            Return Values.leftcurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: right edge curvature in micro-units
    '''  Loc: SRC/dewarp.h (175, 24)
    '''  Org: [l_int32 rightcurv]
    ''' </summary>
    ReadOnly Property rightcurv As Integer
        Get
            Return Values.rightcurv
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of sampling pts in x-dir
    '''  Loc: SRC/dewarp.h (176, 24)
    '''  Org: [l_int32 nx]
    ''' </summary>
    ReadOnly Property nx As Integer
        Get
            Return Values.nx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of sampling pts in y-dir
    '''  Loc: SRC/dewarp.h (177, 24)
    '''  Org: [l_int32 ny]
    ''' </summary>
    ReadOnly Property ny As Integer
        Get
            Return Values.ny
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 0 if normal; 1 if has a refpage
    '''  Loc: SRC/dewarp.h (178, 24)
    '''  Org: [l_int32 hasref]
    ''' </summary>
    ReadOnly Property hasref As Integer
        Get
            Return Values.hasref
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: page with disparity model to use
    '''  Loc: SRC/dewarp.h (179, 24)
    '''  Org: [l_int32 refpage]
    ''' </summary>
    ReadOnly Property refpage As Integer
        Get
            Return Values.refpage
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sets to 1 if vert disparity builds
    '''  Loc: SRC/dewarp.h (180, 24)
    '''  Org: [l_int32 vsuccess]
    ''' </summary>
    ReadOnly Property vsuccess As Integer
        Get
            Return Values.vsuccess
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sets to 1 if horiz disparity builds
    '''  Loc: SRC/dewarp.h (181, 24)
    '''  Org: [l_int32 hsuccess]
    ''' </summary>
    ReadOnly Property hsuccess As Integer
        Get
            Return Values.hsuccess
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sets to 1 if slope disparity builds
    '''  Loc: SRC/dewarp.h (182, 24)
    '''  Org: [l_int32 ysuccess]
    ''' </summary>
    ReadOnly Property ysuccess As Integer
        Get
            Return Values.ysuccess
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sets to 1 if valid vert disparity
    '''  Loc: SRC/dewarp.h (183, 24)
    '''  Org: [l_int32 vvalid]
    ''' </summary>
    ReadOnly Property vvalid As Integer
        Get
            Return Values.vvalid
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sets to 1 if valid horiz disparity
    '''  Loc: SRC/dewarp.h (184, 24)
    '''  Org: [l_int32 hvalid]
    ''' </summary>
    ReadOnly Property hvalid As Integer
        Get
            Return Values.hvalid
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: if 1, skip horiz disparity
    '''  Loc: SRC/dewarp.h (185, 24)
    '''  Org: [l_int32 skip_horiz]
    ''' </summary>
    ReadOnly Property skip_horiz As Integer
        Get
            Return Values.skip_horiz
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 if debug output requested
    '''  Loc: SRC/dewarp.h (187, 24)
    '''  Org: [l_int32 debug]
    ''' </summary>
    ReadOnly Property debug As Integer
        Get
            Return Values.debug
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "pageno:" & pageno & " , " & "sampling:" & sampling & " , " & "redfactor:" & redfactor & " , " & "minlines:" & minlines & " , " & "nlines:" & nlines & " , " & "mincurv:" & mincurv & " , " & "maxcurv:" & maxcurv & " , " & "leftslope:" & leftslope & " , " & "rightslope:" & rightslope & " , " & "leftcurv:" & leftcurv & " , " & "rightcurv:" & rightcurv & " , " & "nx:" & nx & " , " & "ny:" & ny & " , " & "hasref:" & hasref & " , " & "refpage:" & refpage & " , " & "vsuccess:" & vsuccess & " , " & "hsuccess:" & hsuccess & " , " & "ysuccess:" & ysuccess & " , " & "vvalid:" & vvalid & " , " & "hvalid:" & hvalid & " , " & "skip_horiz:" & skip_horiz & " , " & "debug:" & debug & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Dewarp
        Marshal.PtrToStructure(Pointer, Values)
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
' Data structure for generating gnuplot files
Public Class GPlot
    Property Pointer As IntPTR
    Private Values As Marshal_GPlot

    ''' <summary>
    ''' Brf: for cmd, data, output
    '''  Loc: SRC/gplot.h (77, 20)
    '''  Org: [char * rootname]
    ''' </summary>
    ReadOnly Property rootname As String
        Get
            Return Values.rootname
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: command file name
    '''  Loc: SRC/gplot.h (78, 20)
    '''  Org: [char * cmdname]
    ''' </summary>
    ReadOnly Property cmdname As String
        Get
            Return Values.cmdname
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: command file contents
    '''  Loc: SRC/gplot.h (79, 20)
    '''  Org: [struct Sarray * cmddata]
    ''' </summary>
    ReadOnly Property cmddata As Sarray
        Get
            If Values.cmddata <> IntPtr.Zero Then
                Return New Sarray(Values.cmddata)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: data file names
    '''  Loc: SRC/gplot.h (80, 20)
    '''  Org: [struct Sarray * datanames]
    ''' </summary>
    ReadOnly Property datanames As Sarray
        Get
            If Values.datanames <> IntPtr.Zero Then
                Return New Sarray(Values.datanames)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: plot data (1 string/file)
    '''  Loc: SRC/gplot.h (81, 20)
    '''  Org: [struct Sarray * plotdata]
    ''' </summary>
    ReadOnly Property plotdata As Sarray
        Get
            If Values.plotdata <> IntPtr.Zero Then
                Return New Sarray(Values.plotdata)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: title for each individual plot
    '''  Loc: SRC/gplot.h (82, 20)
    '''  Org: [struct Sarray * plottitles]
    ''' </summary>
    ReadOnly Property plottitles As Sarray
        Get
            If Values.plottitles <> IntPtr.Zero Then
                Return New Sarray(Values.plottitles)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: plot style for individual plots
    '''  Loc: SRC/gplot.h (83, 20)
    '''  Org: [struct Numa * plotstyles]
    ''' </summary>
    ReadOnly Property plotstyles As Numa
        Get
            If Values.plotstyles <> IntPtr.Zero Then
                Return New Numa(Values.plotstyles)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: current number of plots
    '''  Loc: SRC/gplot.h (84, 20)
    '''  Org: [l_int32 nplots]
    ''' </summary>
    ReadOnly Property nplots As Integer
        Get
            Return Values.nplots
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: output file name
    '''  Loc: SRC/gplot.h (85, 20)
    '''  Org: [char * outname]
    ''' </summary>
    ReadOnly Property outname As String
        Get
            Return Values.outname
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: GPLOT_OUTPUT values
    '''  Loc: SRC/gplot.h (86, 20)
    '''  Org: [l_int32 outformat]
    ''' </summary>
    ReadOnly Property outformat As Integer
        Get
            Return Values.outformat
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: GPLOT_SCALING values
    '''  Loc: SRC/gplot.h (87, 20)
    '''  Org: [l_int32 scaling]
    ''' </summary>
    ReadOnly Property scaling As Integer
        Get
            Return Values.scaling
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: optional
    '''  Loc: SRC/gplot.h (88, 20)
    '''  Org: [char * title]
    ''' </summary>
    ReadOnly Property title As String
        Get
            Return Values.title
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: optional x axis label
    '''  Loc: SRC/gplot.h (89, 20)
    '''  Org: [char * xlabel]
    ''' </summary>
    ReadOnly Property xlabel As String
        Get
            Return Values.xlabel
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: optional y axis label
    '''  Loc: SRC/gplot.h (90, 20)
    '''  Org: [char * ylabel]
    ''' </summary>
    ReadOnly Property ylabel As String
        Get
            Return Values.ylabel
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "rootname:" & rootname & " , " & "cmdname:" & cmdname & " , " & "nplots:" & nplots & " , " & "outname:" & outname & " , " & "outformat:" & outformat & " , " & "scaling:" & scaling & " , " & "title:" & title & " , " & "xlabel:" & xlabel & " , " & "ylabel:" & ylabel & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_GPlot
        Marshal.PtrToStructure(Pointer, Values)
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
' Compressed image data
Public Class L_Compressed_Data
    Property Pointer As IntPTR
    Private Values As Marshal_L_Compressed_Data

    ''' <summary>
    ''' Brf: encoding type: L_JPEG_ENCODE, etc
    '''  Loc: SRC/imageio.h (168, 24)
    '''  Org: [l_int32 type]
    ''' </summary>
    ReadOnly Property type As Integer
        Get
            Return Values.type
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: gzipped raster data
    '''  Loc: SRC/imageio.h (169, 24)
    '''  Org: [l_uint8 * datacomp]
    ''' </summary>
    ReadOnly Property datacomp As Byte()
        Get
            Dim _datacomp(1 - 1) As Byte
            Marshal.Copy(Values.datacomp, _datacomp, 0, _datacomp.Length)
            Return _datacomp
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of compressed bytes
    '''  Loc: SRC/imageio.h (170, 24)
    '''  Org: [size_t nbytescomp]
    ''' </summary>
    ReadOnly Property nbytescomp As UInteger
        Get
            Return Values.nbytescomp
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ascii85-encoded gzipped raster data
    '''  Loc: SRC/imageio.h (171, 24)
    '''  Org: [char * data85]
    ''' </summary>
    ReadOnly Property data85 As String
        Get
            Return Values.data85
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of ascii85 encoded bytes
    '''  Loc: SRC/imageio.h (172, 24)
    '''  Org: [size_t nbytes85]
    ''' </summary>
    ReadOnly Property nbytes85 As UInteger
        Get
            Return Values.nbytes85
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: ascii85-encoded uncompressed cmap
    '''  Loc: SRC/imageio.h (173, 24)
    '''  Org: [char * cmapdata85]
    ''' </summary>
    ReadOnly Property cmapdata85 As String
        Get
            Return Values.cmapdata85
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: hex pdf array for the cmap
    '''  Loc: SRC/imageio.h (174, 24)
    '''  Org: [char * cmapdatahex]
    ''' </summary>
    ReadOnly Property cmapdatahex As String
        Get
            Return Values.cmapdatahex
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of colors in cmap
    '''  Loc: SRC/imageio.h (175, 24)
    '''  Org: [l_int32 ncolors]
    ''' </summary>
    ReadOnly Property ncolors As Integer
        Get
            Return Values.ncolors
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image width
    '''  Loc: SRC/imageio.h (176, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image height
    '''  Loc: SRC/imageio.h (177, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: bits/sample; typ. 1, 2, 4 or 8
    '''  Loc: SRC/imageio.h (178, 24)
    '''  Org: [l_int32 bps]
    ''' </summary>
    ReadOnly Property bps As Integer
        Get
            Return Values.bps
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: samples/pixel; typ. 1 or 3
    '''  Loc: SRC/imageio.h (179, 24)
    '''  Org: [l_int32 spp]
    ''' </summary>
    ReadOnly Property spp As Integer
        Get
            Return Values.spp
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: tiff g4 photometry
    '''  Loc: SRC/imageio.h (180, 24)
    '''  Org: [l_int32 minisblack]
    ''' </summary>
    ReadOnly Property minisblack As Integer
        Get
            Return Values.minisblack
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: flate data has PNG predictors
    '''  Loc: SRC/imageio.h (181, 24)
    '''  Org: [l_int32 predictor]
    ''' </summary>
    ReadOnly Property predictor As Integer
        Get
            Return Values.predictor
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of uncompressed raster bytes
    '''  Loc: SRC/imageio.h (182, 24)
    '''  Org: [size_t nbytes]
    ''' </summary>
    ReadOnly Property nbytes As UInteger
        Get
            Return Values.nbytes
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: resolution (ppi)
    '''  Loc: SRC/imageio.h (183, 24)
    '''  Org: [l_int32 res]
    ''' </summary>
    ReadOnly Property res As Integer
        Get
            Return Values.res
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "type:" & type & " , " & "nbytescomp:" & nbytescomp & " , " & "data85:" & data85 & " , " & "nbytes85:" & nbytes85 & " , " & "cmapdata85:" & cmapdata85 & " , " & "cmapdatahex:" & cmapdatahex & " , " & "ncolors:" & ncolors & " , " & "w:" & w & " , " & "h:" & h & " , " & "bps:" & bps & " , " & "spp:" & spp & " , " & "minisblack:" & minisblack & " , " & "predictor:" & predictor & " , " & "nbytes:" & nbytes & " , " & "res:" & res & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Compressed_Data
        Marshal.PtrToStructure(Pointer, Values)
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
' Intermediate pdf generation data
Public Class L_Pdf_Data
    Property Pointer As IntPTR
    Private Values As Marshal_L_Pdf_Data

    ''' <summary>
    ''' Brf: optional title for pdf
    '''  Loc: SRC/imageio.h (213, 24)
    '''  Org: [char * title]
    ''' </summary>
    ReadOnly Property title As String
        Get
            Return Values.title
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of images
    '''  Loc: SRC/imageio.h (214, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of colormaps
    '''  Loc: SRC/imageio.h (215, 24)
    '''  Org: [l_int32 ncmap]
    ''' </summary>
    ReadOnly Property ncmap As Integer
        Get
            Return Values.ncmap
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of compressed image data
    '''  Loc: SRC/imageio.h (216, 24)
    '''  Org: [struct L_Ptra * cida]
    ''' </summary>
    ReadOnly Property cida As L_Ptra
        Get
            If Values.cida <> IntPtr.Zero Then
                Return New L_Ptra(Values.cida)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: %PDF-1.2 id string
    '''  Loc: SRC/imageio.h (217, 24)
    '''  Org: [char * id]
    ''' </summary>
    ReadOnly Property id As String
        Get
            Return Values.id
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: catalog string
    '''  Loc: SRC/imageio.h (218, 24)
    '''  Org: [char * obj1]
    ''' </summary>
    ReadOnly Property obj1 As String
        Get
            Return Values.obj1
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: metadata string
    '''  Loc: SRC/imageio.h (219, 24)
    '''  Org: [char * obj2]
    ''' </summary>
    ReadOnly Property obj2 As String
        Get
            Return Values.obj2
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pages string
    '''  Loc: SRC/imageio.h (220, 24)
    '''  Org: [char * obj3]
    ''' </summary>
    ReadOnly Property obj3 As String
        Get
            Return Values.obj3
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: page string (variable data)
    '''  Loc: SRC/imageio.h (221, 24)
    '''  Org: [char * obj4]
    ''' </summary>
    ReadOnly Property obj4 As String
        Get
            Return Values.obj4
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: content string (variable data)
    '''  Loc: SRC/imageio.h (222, 24)
    '''  Org: [char * obj5]
    ''' </summary>
    ReadOnly Property obj5 As String
        Get
            Return Values.obj5
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: post-binary-stream string
    '''  Loc: SRC/imageio.h (223, 24)
    '''  Org: [char * poststream]
    ''' </summary>
    ReadOnly Property poststream As String
        Get
            Return Values.poststream
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: trailer string (variable data)
    '''  Loc: SRC/imageio.h (224, 24)
    '''  Org: [char * trailer]
    ''' </summary>
    ReadOnly Property trailer As String
        Get
            Return Values.trailer
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: store (xpt, ypt) array
    '''  Loc: SRC/imageio.h (225, 24)
    '''  Org: [struct Pta * xy]
    ''' </summary>
    ReadOnly Property xy As Pta
        Get
            If Values.xy <> IntPtr.Zero Then
                Return New Pta(Values.xy)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: store (wpt, hpt) array
    '''  Loc: SRC/imageio.h (226, 24)
    '''  Org: [struct Pta * wh]
    ''' </summary>
    ReadOnly Property wh As Pta
        Get
            If Values.wh <> IntPtr.Zero Then
                Return New Pta(Values.wh)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: bounding region for all images
    '''  Loc: SRC/imageio.h (227, 24)
    '''  Org: [struct Box * mediabox]
    ''' </summary>
    ReadOnly Property mediabox As Box
        Get
            If Values.mediabox <> IntPtr.Zero Then
                Return New Box(Values.mediabox)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pre-binary-stream xobject strings
    '''  Loc: SRC/imageio.h (228, 24)
    '''  Org: [struct Sarray * saprex]
    ''' </summary>
    ReadOnly Property saprex As Sarray
        Get
            If Values.saprex <> IntPtr.Zero Then
                Return New Sarray(Values.saprex)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: colormap pdf object strings
    '''  Loc: SRC/imageio.h (229, 24)
    '''  Org: [struct Sarray * sacmap]
    ''' </summary>
    ReadOnly Property sacmap As Sarray
        Get
            If Values.sacmap <> IntPtr.Zero Then
                Return New Sarray(Values.sacmap)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sizes of each pdf string object
    '''  Loc: SRC/imageio.h (230, 24)
    '''  Org: [struct L_Dna * objsize]
    ''' </summary>
    ReadOnly Property objsize As L_Dna
        Get
            If Values.objsize <> IntPtr.Zero Then
                Return New L_Dna(Values.objsize)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: location of each pdf string object
    '''  Loc: SRC/imageio.h (231, 24)
    '''  Org: [struct L_Dna * objloc]
    ''' </summary>
    ReadOnly Property objloc As L_Dna
        Get
            If Values.objloc <> IntPtr.Zero Then
                Return New L_Dna(Values.objloc)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: location of xref
    '''  Loc: SRC/imageio.h (232, 24)
    '''  Org: [l_int32 xrefloc]
    ''' </summary>
    ReadOnly Property xrefloc As Integer
        Get
            Return Values.xrefloc
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "title:" & title & " , " & "n:" & n & " , " & "ncmap:" & ncmap & " , " & "id:" & id & " , " & "obj1:" & obj1 & " , " & "obj2:" & obj2 & " , " & "obj3:" & obj3 & " , " & "obj4:" & obj4 & " , " & "obj5:" & obj5 & " , " & "poststream:" & poststream & " , " & "trailer:" & trailer & " , " & "xrefloc:" & xrefloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Pdf_Data
        Marshal.PtrToStructure(Pointer, Values)
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
' The JbClasser struct holds all the data accumulated during the classification process that can be used for a compressed jbig2-type representation of a set of images. This is created in an initialization process and added to as the selected components on each successive page are analyzed.
Public Class JbClasser
    Property Pointer As IntPTR
    Private Values As Marshal_JbClasser

    ''' <summary>
    ''' Brf: input page image file names
    '''  Loc: SRC/jbclass.h (49, 22)
    '''  Org: [struct Sarray * safiles]
    ''' </summary>
    ReadOnly Property safiles As Sarray
        Get
            If Values.safiles <> IntPtr.Zero Then
                Return New Sarray(Values.safiles)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: JB_RANKHAUS, JB_CORRELATION
    '''  Loc: SRC/jbclass.h (50, 22)
    '''  Org: [l_int32 method]
    ''' </summary>
    ReadOnly Property method As Integer
        Get
            Return Values.method
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: JB_CONN_COMPS, JB_CHARACTERS or
    '''  Loc: SRC/jbclass.h (51, 22)
    '''  Org: [l_int32 components]
    ''' </summary>
    ReadOnly Property components As Integer
        Get
            Return Values.components
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max component width allowed
    '''  Loc: SRC/jbclass.h (53, 22)
    '''  Org: [l_int32 maxwidth]
    ''' </summary>
    ReadOnly Property maxwidth As Integer
        Get
            Return Values.maxwidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max component height allowed
    '''  Loc: SRC/jbclass.h (54, 22)
    '''  Org: [l_int32 maxheight]
    ''' </summary>
    ReadOnly Property maxheight As Integer
        Get
            Return Values.maxheight
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of pages already processed
    '''  Loc: SRC/jbclass.h (55, 22)
    '''  Org: [l_int32 npages]
    ''' </summary>
    ReadOnly Property npages As Integer
        Get
            Return Values.npages
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number components already processed
    '''  Loc: SRC/jbclass.h (56, 22)
    '''  Org: [l_int32 baseindex]
    ''' </summary>
    ReadOnly Property baseindex As Integer
        Get
            Return Values.baseindex
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of components on each page
    '''  Loc: SRC/jbclass.h (58, 22)
    '''  Org: [struct Numa * nacomps]
    ''' </summary>
    ReadOnly Property nacomps As Numa
        Get
            If Values.nacomps <> IntPtr.Zero Then
                Return New Numa(Values.nacomps)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of square struct elem for haus
    '''  Loc: SRC/jbclass.h (59, 22)
    '''  Org: [l_int32 sizehaus]
    ''' </summary>
    ReadOnly Property sizehaus As Integer
        Get
            Return Values.sizehaus
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: rank val of haus match, each way
    '''  Loc: SRC/jbclass.h (60, 22)
    '''  Org: [l_float32 rankhaus]
    ''' </summary>
    ReadOnly Property rankhaus As Single
        Get
            Return Values.rankhaus
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: thresh value for correlation score
    '''  Loc: SRC/jbclass.h (61, 22)
    '''  Org: [l_float32 thresh]
    ''' </summary>
    ReadOnly Property thresh As Single
        Get
            Return Values.thresh
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: corrects thresh value for heaver
    '''  Loc: SRC/jbclass.h (62, 22)
    '''  Org: [l_float32 weightfactor]
    ''' </summary>
    ReadOnly Property weightfactor As Single
        Get
            Return Values.weightfactor
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: w * h of each template, without
    '''  Loc: SRC/jbclass.h (64, 22)
    '''  Org: [struct Numa * naarea]
    ''' </summary>
    ReadOnly Property naarea As Numa
        Get
            If Values.naarea <> IntPtr.Zero Then
                Return New Numa(Values.naarea)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max width of original src images
    '''  Loc: SRC/jbclass.h (66, 22)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max height of original src images
    '''  Loc: SRC/jbclass.h (67, 22)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: current number of classes
    '''  Loc: SRC/jbclass.h (68, 22)
    '''  Org: [l_int32 nclass]
    ''' </summary>
    ReadOnly Property nclass As Integer
        Get
            Return Values.nclass
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: If zero, pixaa isn't filled
    '''  Loc: SRC/jbclass.h (69, 22)
    '''  Org: [l_int32 keep_pixaa]
    ''' </summary>
    ReadOnly Property keep_pixaa As Integer
        Get
            Return Values.keep_pixaa
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: instances for each class; unbordered
    '''  Loc: SRC/jbclass.h (70, 22)
    '''  Org: [struct Pixaa * pixaa]
    ''' </summary>
    ReadOnly Property pixaa As Pixaa
        Get
            If Values.pixaa <> IntPtr.Zero Then
                Return New Pixaa(Values.pixaa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: templates for each class; bordered
    '''  Loc: SRC/jbclass.h (71, 22)
    '''  Org: [struct Pixa * pixat]
    ''' </summary>
    ReadOnly Property pixat As Pixa
        Get
            If Values.pixat <> IntPtr.Zero Then
                Return New Pixa(Values.pixat)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: templates for each class; bordered
    '''  Loc: SRC/jbclass.h (73, 22)
    '''  Org: [struct Pixa * pixatd]
    ''' </summary>
    ReadOnly Property pixatd As Pixa
        Get
            If Values.pixatd <> IntPtr.Zero Then
                Return New Pixa(Values.pixatd)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: Hash table to find templates by size
    '''  Loc: SRC/jbclass.h (75, 23)
    '''  Org: [struct L_DnaHash * dahash]
    ''' </summary>
    ReadOnly Property dahash As L_DnaHash
        Get
            If Values.dahash <> IntPtr.Zero Then
                Return New L_DnaHash(Values.dahash)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: fg areas of undilated templates;
    '''  Loc: SRC/jbclass.h (76, 22)
    '''  Org: [struct Numa * nafgt]
    ''' </summary>
    ReadOnly Property nafgt As Numa
        Get
            If Values.nafgt <> IntPtr.Zero Then
                Return New Numa(Values.nafgt)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of all bordered cc
    '''  Loc: SRC/jbclass.h (78, 22)
    '''  Org: [struct Pta * ptac]
    ''' </summary>
    ReadOnly Property ptac As Pta
        Get
            If Values.ptac <> IntPtr.Zero Then
                Return New Pta(Values.ptac)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of all bordered template cc
    '''  Loc: SRC/jbclass.h (79, 22)
    '''  Org: [struct Pta * ptact]
    ''' </summary>
    ReadOnly Property ptact As Pta
        Get
            If Values.ptact <> IntPtr.Zero Then
                Return New Pta(Values.ptact)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of class ids for each component
    '''  Loc: SRC/jbclass.h (80, 22)
    '''  Org: [struct Numa * naclass]
    ''' </summary>
    ReadOnly Property naclass As Numa
        Get
            If Values.naclass <> IntPtr.Zero Then
                Return New Numa(Values.naclass)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of page nums for each component
    '''  Loc: SRC/jbclass.h (81, 22)
    '''  Org: [struct Numa * napage]
    ''' </summary>
    ReadOnly Property napage As Numa
        Get
            If Values.napage <> IntPtr.Zero Then
                Return New Numa(Values.napage)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of UL corners at which the
    '''  Loc: SRC/jbclass.h (82, 22)
    '''  Org: [struct Pta * ptaul]
    ''' </summary>
    ReadOnly Property ptaul As Pta
        Get
            If Values.ptaul <> IntPtr.Zero Then
                Return New Pta(Values.ptaul)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: similar to ptaul, but for LL corners
    '''  Loc: SRC/jbclass.h (85, 22)
    '''  Org: [struct Pta * ptall]
    ''' </summary>
    ReadOnly Property ptall As Pta
        Get
            If Values.ptall <> IntPtr.Zero Then
                Return New Pta(Values.ptall)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "method:" & method & " , " & "components:" & components & " , " & "maxwidth:" & maxwidth & " , " & "maxheight:" & maxheight & " , " & "npages:" & npages & " , " & "baseindex:" & baseindex & " , " & "sizehaus:" & sizehaus & " , " & "rankhaus:" & rankhaus & " , " & "thresh:" & thresh & " , " & "weightfactor:" & weightfactor & " , " & "w:" & w & " , " & "h:" & h & " , " & "nclass:" & nclass & " , " & "keep_pixaa:" & keep_pixaa & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_JbClasser
        Marshal.PtrToStructure(Pointer, Values)
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
' The JbData struct holds all the data required for the compressed jbig-type representation of a set of images. The data can be written to file, read back, and used to regenerate an approximate version of the original, which differs in two ways from the original: (1) It uses a template image for each c.c. instead of the original instance, for each occurrence on each page. (2) It discards components with either a height or width larger than the maximuma, given here by the lattice dimensions used for storing the templates.
Public Class JbData
    Property Pointer As IntPTR
    Private Values As Marshal_JbData

    ''' <summary>
    ''' Brf: template composite for all classes
    '''  Loc: SRC/jbclass.h (106, 22)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    ReadOnly Property pix As Pix
        Get
            If Values.pix <> IntPtr.Zero Then
                Return New Pix(Values.pix)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of pages
    '''  Loc: SRC/jbclass.h (107, 22)
    '''  Org: [l_int32 npages]
    ''' </summary>
    ReadOnly Property npages As Integer
        Get
            Return Values.npages
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max width of original page images
    '''  Loc: SRC/jbclass.h (108, 22)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max height of original page images
    '''  Loc: SRC/jbclass.h (109, 22)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of classes
    '''  Loc: SRC/jbclass.h (110, 22)
    '''  Org: [l_int32 nclass]
    ''' </summary>
    ReadOnly Property nclass As Integer
        Get
            Return Values.nclass
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: lattice width for template composite
    '''  Loc: SRC/jbclass.h (111, 22)
    '''  Org: [l_int32 latticew]
    ''' </summary>
    ReadOnly Property latticew As Integer
        Get
            Return Values.latticew
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: lattice height for template composite
    '''  Loc: SRC/jbclass.h (112, 22)
    '''  Org: [l_int32 latticeh]
    ''' </summary>
    ReadOnly Property latticeh As Integer
        Get
            Return Values.latticeh
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of class ids for each component
    '''  Loc: SRC/jbclass.h (113, 22)
    '''  Org: [struct Numa * naclass]
    ''' </summary>
    ReadOnly Property naclass As Numa
        Get
            If Values.naclass <> IntPtr.Zero Then
                Return New Numa(Values.naclass)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of page nums for each component
    '''  Loc: SRC/jbclass.h (114, 22)
    '''  Org: [struct Numa * napage]
    ''' </summary>
    ReadOnly Property napage As Numa
        Get
            If Values.napage <> IntPtr.Zero Then
                Return New Numa(Values.napage)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of UL corners at which the
    '''  Loc: SRC/jbclass.h (115, 22)
    '''  Org: [struct Pta * ptaul]
    ''' </summary>
    ReadOnly Property ptaul As Pta
        Get
            If Values.ptaul <> IntPtr.Zero Then
                Return New Pta(Values.ptaul)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "npages:" & npages & " , " & "w:" & w & " , " & "h:" & h & " , " & "nclass:" & nclass & " , " & "latticew:" & latticew & " , " & "latticeh:" & latticeh & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_JbData
        Marshal.PtrToStructure(Pointer, Values)
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
' Selection
Public Class Sel
    Property Pointer As IntPTR
    Private Values As Marshal_Sel

    ''' <summary>
    ''' Brf: sel height
    '''  Loc: SRC/morph.h (64, 19)
    '''  Org: [l_int32 sy]
    ''' </summary>
    ReadOnly Property sy As Integer
        Get
            Return Values.sy
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sel width
    '''  Loc: SRC/morph.h (65, 19)
    '''  Org: [l_int32 sx]
    ''' </summary>
    ReadOnly Property sx As Integer
        Get
            Return Values.sx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y location of sel origin
    '''  Loc: SRC/morph.h (66, 19)
    '''  Org: [l_int32 cy]
    ''' </summary>
    ReadOnly Property cy As Integer
        Get
            Return Values.cy
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x location of sel origin
    '''  Loc: SRC/morph.h (67, 19)
    '''  Org: [l_int32 cx]
    ''' </summary>
    ReadOnly Property cx As Integer
        Get
            Return Values.cx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: {0,1,2}; data[i][j] in [row][col] order
    '''  Loc: SRC/morph.h (68, 19)
    '''  Org: [l_int32 ** data]
    ''' </summary>
    ReadOnly Property data As Integer()
        Get
            If Values.data <> IntPtr.Zero Then
                Marshal.Copy(Values.data, data, 0, 1)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: used to find sel by name
    '''  Loc: SRC/morph.h (69, 19)
    '''  Org: [char * name]
    ''' </summary>
    ReadOnly Property name As String
        Get
            Return Values.name
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "sy:" & sy & " , " & "sx:" & sx & " , " & "cy:" & cy & " , " & "cx:" & cx & " , " & "name:" & name & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Sel
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of Sel
Public Class Sela
    Property Pointer As IntPTR
    Private Values As Marshal_Sela

    ''' <summary>
    ''' Brf: number of sel actually stored
    '''  Loc: SRC/morph.h (76, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of allocated ptr array
    '''  Loc: SRC/morph.h (77, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: sel ptr array
    '''  Loc: SRC/morph.h (78, 22)
    '''  Org: [struct Sel ** sel]
    ''' </summary>
    ReadOnly Property sel As List(Of Sel)
        Get
            If Values.sel <> IntPtr.Zero Then
                Dim IntPTR_sel(values.n - 1) As intPTR
                Dim Values_sel As New List(Of Sel)
                Marshal.Copy(Values.sel, IntPTR_sel, 0, values.n)
                For Each _PTR_ In IntPTR_sel : Values_sel.Add(New Sel(_PTR_)) : Next
                Return Values_sel
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Sela
        Marshal.PtrToStructure(Pointer, Values)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Sela
        Public n As Integer
        Public nalloc As Integer
        Public sel As IntPTR
    End Class
End Class


' SRC/morph.h (89, 8)
' Kernel
Public Class L_Kernel
    Property Pointer As IntPTR
    Private Values As Marshal_L_Kernel

    ''' <summary>
    ''' Brf: kernel height
    '''  Loc: SRC/morph.h (91, 19)
    '''  Org: [l_int32 sy]
    ''' </summary>
    ReadOnly Property sy As Integer
        Get
            Return Values.sy
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: kernel width
    '''  Loc: SRC/morph.h (92, 19)
    '''  Org: [l_int32 sx]
    ''' </summary>
    ReadOnly Property sx As Integer
        Get
            Return Values.sx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y location of kernel origin
    '''  Loc: SRC/morph.h (93, 19)
    '''  Org: [l_int32 cy]
    ''' </summary>
    ReadOnly Property cy As Integer
        Get
            Return Values.cy
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x location of kernel origin
    '''  Loc: SRC/morph.h (94, 19)
    '''  Org: [l_int32 cx]
    ''' </summary>
    ReadOnly Property cx As Integer
        Get
            Return Values.cx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: data[i][j] in [row][col] order
    '''  Loc: SRC/morph.h (95, 19)
    '''  Org: [l_float32 ** data]
    ''' </summary>
    ReadOnly Property data As Single()
        Get
            If Values.data <> IntPtr.Zero Then
                Marshal.Copy(Values.data, data, 0, 1)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "sy:" & sy & " , " & "sx:" & sx & " , " & "cy:" & cy & " , " & "cx:" & cx & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Kernel
        Marshal.PtrToStructure(Pointer, Values)
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
' Basic Pix
Public Class Pix
    Property Pointer As IntPTR
    Private Values As Marshal_Pix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (136, 26)
    '''  Org: [l_uint32 w]
    ''' </summary>
    ReadOnly Property w As UInteger
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (137, 26)
    '''  Org: [l_uint32 h]
    ''' </summary>
    ReadOnly Property h As UInteger
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: depth in bits (bpp)
    '''  Loc: SRC/pix.h (138, 26)
    '''  Org: [l_uint32 d]
    ''' </summary>
    ReadOnly Property d As UInteger
        Get
            Return Values.d
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of samples per pixel
    '''  Loc: SRC/pix.h (139, 26)
    '''  Org: [l_uint32 spp]
    ''' </summary>
    ReadOnly Property spp As UInteger
        Get
            Return Values.spp
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (140, 26)
    '''  Org: [l_uint32 wpl]
    ''' </summary>
    ReadOnly Property wpl As UInteger
        Get
            Return Values.wpl
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (141, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (142, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    ReadOnly Property xres As Integer
        Get
            Return Values.xres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (144, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    ReadOnly Property yres As Integer
        Get
            Return Values.yres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: input file format, IFF_*
    '''  Loc: SRC/pix.h (146, 26)
    '''  Org: [l_int32 informat]
    ''' </summary>
    ReadOnly Property informat As Integer
        Get
            Return Values.informat
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: special instructions for I/O, etc
    '''  Loc: SRC/pix.h (147, 26)
    '''  Org: [l_int32 special]
    ''' </summary>
    ReadOnly Property special As Integer
        Get
            Return Values.special
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: text string associated with pix
    '''  Loc: SRC/pix.h (148, 26)
    '''  Org: [char * text]
    ''' </summary>
    ReadOnly Property text As String
        Get
            Return Values.text
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: colormap (may be null)
    '''  Loc: SRC/pix.h (149, 26)
    '''  Org: [struct PixColormap * colormap]
    ''' </summary>
    ReadOnly Property colormap As PixColormap
        Get
            If Values.colormap <> IntPtr.Zero Then
                Return New PixColormap(Values.colormap)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the image data
    '''  Loc: SRC/pix.h (150, 26)
    '''  Org: [l_uint32 * data]
    '''  Marshal = greater  UInteger = greater  Byte() : [UInt=4 Bytes]
    ''' </summary>
    ReadOnly Property data As Byte()
        Get
            Dim _data((w * h * (d / 8)) - 1) As Byte
            Marshal.Copy(Values.data, _data, 0, _data.Length)
            Return _data
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "d:" & d & " , " & "spp:" & spp & " , " & "wpl:" & wpl & " , " & "refcount:" & refcount & " , " & "xres:" & xres & " , " & "yres:" & yres & " , " & "informat:" & informat & " , " & "special:" & special & " , " & "text:" & text & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Pix
        Marshal.PtrToStructure(Pointer, Values)
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
' Colormap of a Pix
Public Class PixColormap
    Property Pointer As IntPTR
    Private Values As Marshal_PixColormap

    ''' <summary>
    ''' Brf: colormap table (array of RGBA_QUAD)
    '''  Loc: SRC/pix.h (157, 22)
    '''  Org: [void * array]
    ''' </summary>
    ReadOnly Property array As IntPTR
        Get
            Return array = Values.array
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: of pix (1, 2, 4 or 8 bpp)
    '''  Loc: SRC/pix.h (158, 22)
    '''  Org: [l_int32 depth]
    ''' </summary>
    ReadOnly Property depth As Integer
        Get
            Return Values.depth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of color entries allocated
    '''  Loc: SRC/pix.h (159, 22)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of color entries used
    '''  Loc: SRC/pix.h (160, 22)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "depth:" & depth & " , " & "nalloc:" & nalloc & " , " & "n:" & n & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_PixColormap
        Marshal.PtrToStructure(Pointer, Values)
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
' Colormap table entry (after the BMP version). Note that the BMP format stores the colormap table exactly as it appears here, with color samples being stored sequentially, in the order (b,g,r,a).
Public Class RGBA_Quad
    Property Pointer As IntPTR
    Private Values As Marshal_RGBA_Quad

    ''' <summary>
    ''' Brf: blue value
    '''  Loc: SRC/pix.h (171, 17)
    '''  Org: [l_uint8 blue]
    ''' </summary>
    ReadOnly Property blue As Byte
        Get
            Return Values.blue
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: green value
    '''  Loc: SRC/pix.h (172, 17)
    '''  Org: [l_uint8 green]
    ''' </summary>
    ReadOnly Property green As Byte
        Get
            Return Values.green
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: red value
    '''  Loc: SRC/pix.h (173, 17)
    '''  Org: [l_uint8 red]
    ''' </summary>
    ReadOnly Property red As Byte
        Get
            Return Values.red
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: alpha value
    '''  Loc: SRC/pix.h (174, 17)
    '''  Org: [l_uint8 alpha]
    ''' </summary>
    ReadOnly Property alpha As Byte
        Get
            Return Values.alpha
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "blue:" & blue & " , " & "green:" & green & " , " & "red:" & red & " , " & "alpha:" & alpha & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_RGBA_Quad
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of pix
Public Class Pixa
    Property Pointer As IntPTR
    Private Values As Marshal_Pixa

    ''' <summary>
    ''' Brf: number of Pix in ptr array
    '''  Loc: SRC/pix.h (456, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of Pix ptrs allocated
    '''  Loc: SRC/pix.h (457, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (458, 25)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the array of ptrs to pix
    '''  Loc: SRC/pix.h (459, 25)
    '''  Org: [struct Pix ** pix]
    ''' </summary>
    ReadOnly Property pix As List(Of Pix)
        Get
            If Values.pix <> IntPtr.Zero Then
                Dim IntPTR_pix(values.n - 1) As intPTR
                Dim Values_pix As New List(Of Pix)
                Marshal.Copy(Values.pix, IntPTR_pix, 0, values.n)
                For Each _PTR_ In IntPTR_pix : Values_pix.Add(New Pix(_PTR_)) : Next
                Return Values_pix
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (460, 25)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    ReadOnly Property boxa As Boxa
        Get
            If Values.boxa <> IntPtr.Zero Then
                Return New Boxa(Values.boxa)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Pixa
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of arrays of pix
Public Class Pixaa
    Property Pointer As IntPTR
    Private Values As Marshal_Pixaa

    ''' <summary>
    ''' Brf: number of Pixa in ptr array
    '''  Loc: SRC/pix.h (467, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of Pixa ptrs allocated
    '''  Loc: SRC/pix.h (468, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of ptrs to pixa
    '''  Loc: SRC/pix.h (469, 25)
    '''  Org: [struct Pixa ** pixa]
    ''' </summary>
    ReadOnly Property pixa As List(Of Pixa)
        Get
            If Values.pixa <> IntPtr.Zero Then
                Dim IntPTR_pixa(values.n - 1) As intPTR
                Dim Values_pixa As New List(Of Pixa)
                Marshal.Copy(Values.pixa, IntPTR_pixa, 0, values.n)
                For Each _PTR_ In IntPTR_pixa : Values_pixa.Add(New Pixa(_PTR_)) : Next
                Return Values_pixa
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (470, 25)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    ReadOnly Property boxa As Boxa
        Get
            If Values.boxa <> IntPtr.Zero Then
                Return New Boxa(Values.boxa)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Pixaa
        Marshal.PtrToStructure(Pointer, Values)
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
' Basic rectangle
Public Class Box
    Property Pointer As IntPTR
    Private Values As Marshal_Box

    ''' <summary>
    ''' Brf: left coordinate
    '''  Loc: SRC/pix.h (482, 24)
    '''  Org: [l_int32 x]
    ''' </summary>
    ReadOnly Property x As Integer
        Get
            Return Values.x
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: top coordinate
    '''  Loc: SRC/pix.h (483, 24)
    '''  Org: [l_int32 y]
    ''' </summary>
    ReadOnly Property y As Integer
        Get
            Return Values.y
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: box width
    '''  Loc: SRC/pix.h (484, 24)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: box height
    '''  Loc: SRC/pix.h (485, 24)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (486, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "x:" & x & " , " & "y:" & y & " , " & "w:" & w & " , " & "h:" & h & " , " & "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Box
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of Box
Public Class Boxa
    Property Pointer As IntPTR
    Private Values As Marshal_Boxa

    ''' <summary>
    ''' Brf: number of box in ptr array
    '''  Loc: SRC/pix.h (494, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of box ptrs allocated
    '''  Loc: SRC/pix.h (495, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (496, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: box ptr array
    '''  Loc: SRC/pix.h (497, 24)
    '''  Org: [struct Box ** box]
    ''' </summary>
    ReadOnly Property box As List(Of Box)
        Get
            If Values.box <> IntPtr.Zero Then
                Dim IntPTR_box(values.n - 1) As intPTR
                Dim Values_box As New List(Of Box)
                Marshal.Copy(Values.box, IntPTR_box, 0, values.n)
                For Each _PTR_ In IntPTR_box : Values_box.Add(New Box(_PTR_)) : Next
                Return Values_box
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Boxa
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of Boxa
Public Class Boxaa
    Property Pointer As IntPTR
    Private Values As Marshal_Boxaa

    ''' <summary>
    ''' Brf: number of boxa in ptr array
    '''  Loc: SRC/pix.h (504, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of boxa ptrs allocated
    '''  Loc: SRC/pix.h (505, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: boxa ptr array
    '''  Loc: SRC/pix.h (506, 24)
    '''  Org: [struct Boxa ** boxa]
    ''' </summary>
    ReadOnly Property boxa As List(Of Boxa)
        Get
            If Values.boxa <> IntPtr.Zero Then
                Dim IntPTR_boxa(values.n - 1) As intPTR
                Dim Values_boxa As New List(Of Boxa)
                Marshal.Copy(Values.boxa, IntPTR_boxa, 0, values.n)
                For Each _PTR_ In IntPTR_boxa : Values_boxa.Add(New Boxa(_PTR_)) : Next
                Return Values_boxa
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Boxaa
        Marshal.PtrToStructure(Pointer, Values)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Boxaa
        Public n As Integer
        Public nalloc As Integer
        Public boxa As IntPTR
    End Class
End Class


' SRC/pix.h (517, 8)
' Array of points
Public Class Pta
    Property Pointer As IntPTR
    Private Values As Marshal_Pta

    ''' <summary>
    ''' Brf: actual number of pts
    '''  Loc: SRC/pix.h (519, 24)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of allocated arrays
    '''  Loc: SRC/pix.h (520, 24)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (521, 24)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: arrays of floats
    '''  Loc: SRC/pix.h (522, 24)
    '''  Org: [l_float32 * x]
    ''' </summary>
    ReadOnly Property x As Single()
        Get
            Dim _x(values.n - 1) As Single
            Marshal.Copy(Values.x, _x, 0, _x.Length)
            Return _x
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: arrays of floats
    '''  Loc: SRC/pix.h (522, 28)
    '''  Org: [l_float32 * y]
    ''' </summary>
    ReadOnly Property y As Single()
        Get
            Dim _y(values.n - 1) As Single
            Marshal.Copy(Values.y, _y, 0, _y.Length)
            Return _y
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Pta
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of Pta
Public Class Ptaa
    Property Pointer As IntPTR
    Private Values As Marshal_Ptaa

    ''' <summary>
    ''' Brf: number of pta in ptr array
    '''  Loc: SRC/pix.h (534, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of pta ptrs allocated
    '''  Loc: SRC/pix.h (535, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pta ptr array
    '''  Loc: SRC/pix.h (536, 26)
    '''  Org: [struct Pta ** pta]
    ''' </summary>
    ReadOnly Property pta As List(Of Pta)
        Get
            If Values.pta <> IntPtr.Zero Then
                Dim IntPTR_pta(values.n - 1) As intPTR
                Dim Values_pta As New List(Of Pta)
                Marshal.Copy(Values.pta, IntPTR_pta, 0, values.n)
                For Each _PTR_ In IntPTR_pta : Values_pta.Add(New Pta(_PTR_)) : Next
                Return Values_pta
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Ptaa
        Marshal.PtrToStructure(Pointer, Values)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_Ptaa
        Public n As Integer
        Public nalloc As Integer
        Public pta As IntPTR
    End Class
End Class


' SRC/pix.h (546, 8)
' Pix accumulator container
Public Class Pixacc
    Property Pointer As IntPTR
    Private Values As Marshal_Pixacc

    ''' <summary>
    ''' Brf: array width
    '''  Loc: SRC/pix.h (548, 25)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array height
    '''  Loc: SRC/pix.h (549, 25)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: used to allow negative
    '''  Loc: SRC/pix.h (550, 25)
    '''  Org: [l_int32 offset]
    ''' </summary>
    ReadOnly Property offset As Integer
        Get
            Return Values.offset
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the 32 bit accumulator pix
    '''  Loc: SRC/pix.h (552, 25)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    ReadOnly Property pix As Pix
        Get
            If Values.pix <> IntPtr.Zero Then
                Return New Pix(Values.pix)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "offset:" & offset & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_Pixacc
        Marshal.PtrToStructure(Pointer, Values)
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
' Pix tiling
Public Class PixTiling
    Property Pointer As IntPTR
    Private Values As Marshal_PixTiling

    ''' <summary>
    ''' Brf: input pix (a clone)
    '''  Loc: SRC/pix.h (564, 26)
    '''  Org: [struct Pix * pix]
    ''' </summary>
    ReadOnly Property pix As Pix
        Get
            If Values.pix <> IntPtr.Zero Then
                Return New Pix(Values.pix)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of tiles horizontally
    '''  Loc: SRC/pix.h (565, 26)
    '''  Org: [l_int32 nx]
    ''' </summary>
    ReadOnly Property nx As Integer
        Get
            Return Values.nx
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of tiles vertically
    '''  Loc: SRC/pix.h (566, 26)
    '''  Org: [l_int32 ny]
    ''' </summary>
    ReadOnly Property ny As Integer
        Get
            Return Values.ny
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: tile width
    '''  Loc: SRC/pix.h (567, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: tile height
    '''  Loc: SRC/pix.h (568, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: overlap on left and right
    '''  Loc: SRC/pix.h (569, 26)
    '''  Org: [l_int32 xoverlap]
    ''' </summary>
    ReadOnly Property xoverlap As Integer
        Get
            Return Values.xoverlap
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: overlap on top and bottom
    '''  Loc: SRC/pix.h (570, 26)
    '''  Org: [l_int32 yoverlap]
    ''' </summary>
    ReadOnly Property yoverlap As Integer
        Get
            Return Values.yoverlap
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: strip for paint; default is TRUE
    '''  Loc: SRC/pix.h (571, 26)
    '''  Org: [l_int32 strip]
    ''' </summary>
    ReadOnly Property strip As Integer
        Get
            Return Values.strip
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "nx:" & nx & " , " & "ny:" & ny & " , " & "w:" & w & " , " & "h:" & h & " , " & "xoverlap:" & xoverlap & " , " & "yoverlap:" & yoverlap & " , " & "strip:" & strip & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_PixTiling
        Marshal.PtrToStructure(Pointer, Values)
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
' Pix with float array
Public Class FPix
    Property Pointer As IntPTR
    Private Values As Marshal_FPix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (584, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (585, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (586, 26)
    '''  Org: [l_int32 wpl]
    ''' </summary>
    ReadOnly Property wpl As Integer
        Get
            Return Values.wpl
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (587, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (588, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    ReadOnly Property xres As Integer
        Get
            Return Values.xres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (590, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    ReadOnly Property yres As Integer
        Get
            Return Values.yres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the float image data
    '''  Loc: SRC/pix.h (592, 26)
    '''  Org: [l_float32 * data]
    ''' </summary>
    ReadOnly Property data As Single()
        Get
            Dim _data(1 - 1) As Single
            Marshal.Copy(Values.data, _data, 0, _data.Length)
            Return _data
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "wpl:" & wpl & " , " & "refcount:" & refcount & " , " & "xres:" & xres & " , " & "yres:" & yres & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_FPix
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of FPix
Public Class FPixa
    Property Pointer As IntPTR
    Private Values As Marshal_FPixa

    ''' <summary>
    ''' Brf: number of fpix in ptr array
    '''  Loc: SRC/pix.h (599, 25)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of fpix ptrs allocated
    '''  Loc: SRC/pix.h (600, 25)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (601, 25)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the array of ptrs to fpix
    '''  Loc: SRC/pix.h (602, 25)
    '''  Org: [struct FPix ** fpix]
    ''' </summary>
    ReadOnly Property fpix As List(Of FPix)
        Get
            If Values.fpix <> IntPtr.Zero Then
                Dim IntPTR_fpix(values.n - 1) As intPTR
                Dim Values_fpix As New List(Of FPix)
                Marshal.Copy(Values.fpix, IntPTR_fpix, 0, values.n)
                For Each _PTR_ In IntPTR_fpix : Values_fpix.Add(New FPix(_PTR_)) : Next
                Return Values_fpix
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & "refcount:" & refcount & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_FPixa
        Marshal.PtrToStructure(Pointer, Values)
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
' Pix with double array
Public Class DPix
    Property Pointer As IntPTR
    Private Values As Marshal_DPix

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (615, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (616, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 32-bit words/line
    '''  Loc: SRC/pix.h (617, 26)
    '''  Org: [l_int32 wpl]
    ''' </summary>
    ReadOnly Property wpl As Integer
        Get
            Return Values.wpl
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: reference count (1 if no clones)
    '''  Loc: SRC/pix.h (618, 26)
    '''  Org: [l_uint32 refcount]
    ''' </summary>
    ReadOnly Property refcount As UInteger
        Get
            Return Values.refcount
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (619, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    ReadOnly Property xres As Integer
        Get
            Return Values.xres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (621, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    ReadOnly Property yres As Integer
        Get
            Return Values.yres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the double image data
    '''  Loc: SRC/pix.h (623, 26)
    '''  Org: [l_float64 * data]
    ''' </summary>
    ReadOnly Property data As Double()
        Get
            Dim _data(1 - 1) As Double
            Marshal.Copy(Values.data, _data, 0, _data.Length)
            Return _data
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "wpl:" & wpl & " , " & "refcount:" & refcount & " , " & "xres:" & xres & " , " & "yres:" & yres & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_DPix
        Marshal.PtrToStructure(Pointer, Values)
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
' Compressed Pix
Public Class PixComp
    Property Pointer As IntPTR
    Private Values As Marshal_PixComp

    ''' <summary>
    ''' Brf: width in pixels
    '''  Loc: SRC/pix.h (635, 26)
    '''  Org: [l_int32 w]
    ''' </summary>
    ReadOnly Property w As Integer
        Get
            Return Values.w
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: height in pixels
    '''  Loc: SRC/pix.h (636, 26)
    '''  Org: [l_int32 h]
    ''' </summary>
    ReadOnly Property h As Integer
        Get
            Return Values.h
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: depth in bits
    '''  Loc: SRC/pix.h (637, 26)
    '''  Org: [l_int32 d]
    ''' </summary>
    ReadOnly Property d As Integer
        Get
            Return Values.d
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in x direction
    '''  Loc: SRC/pix.h (638, 26)
    '''  Org: [l_int32 xres]
    ''' </summary>
    ReadOnly Property xres As Integer
        Get
            Return Values.xres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: image res (ppi) in y direction
    '''  Loc: SRC/pix.h (640, 26)
    '''  Org: [l_int32 yres]
    ''' </summary>
    ReadOnly Property yres As Integer
        Get
            Return Values.yres
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: compressed format (IFF_TIFF_G4,
    '''  Loc: SRC/pix.h (642, 26)
    '''  Org: [l_int32 comptype]
    ''' </summary>
    ReadOnly Property comptype As Integer
        Get
            Return Values.comptype
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: text string associated with pix
    '''  Loc: SRC/pix.h (644, 26)
    '''  Org: [char * text]
    ''' </summary>
    ReadOnly Property text As String
        Get
            Return Values.text
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: flag (1 for cmap, 0 otherwise)
    '''  Loc: SRC/pix.h (645, 26)
    '''  Org: [l_int32 cmapflag]
    ''' </summary>
    ReadOnly Property cmapflag As Integer
        Get
            Return Values.cmapflag
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the compressed image data
    '''  Loc: SRC/pix.h (646, 26)
    '''  Org: [l_uint8 * data]
    ''' </summary>
    ReadOnly Property data As Byte()
        Get
            Dim _data(1 - 1) As Byte
            Marshal.Copy(Values.data, _data, 0, _data.Length)
            Return _data
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of the data array
    '''  Loc: SRC/pix.h (647, 26)
    '''  Org: [size_t size]
    ''' </summary>
    ReadOnly Property size As UInteger
        Get
            Return Values.size
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "w:" & w & " , " & "h:" & h & " , " & "d:" & d & " , " & "xres:" & xres & " , " & "yres:" & yres & " , " & "comptype:" & comptype & " , " & "text:" & text & " , " & "cmapflag:" & cmapflag & " , " & "size:" & size & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_PixComp
        Marshal.PtrToStructure(Pointer, Values)
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
' Array of compressed pix
Public Class PixaComp
    Property Pointer As IntPTR
    Private Values As Marshal_PixaComp

    ''' <summary>
    ''' Brf: number of PixComp in ptr array
    '''  Loc: SRC/pix.h (660, 26)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of PixComp ptrs allocated
    '''  Loc: SRC/pix.h (661, 26)
    '''  Org: [l_int32 nalloc]
    ''' </summary>
    ReadOnly Property nalloc As Integer
        Get
            Return Values.nalloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: indexing offset into ptr array
    '''  Loc: SRC/pix.h (662, 26)
    '''  Org: [l_int32 offset]
    ''' </summary>
    ReadOnly Property offset As Integer
        Get
            Return Values.offset
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: the array of ptrs to PixComp
    '''  Loc: SRC/pix.h (663, 26)
    '''  Org: [struct PixComp ** pixc]
    ''' </summary>
    ReadOnly Property pixc As List(Of PixComp)
        Get
            If Values.pixc <> IntPtr.Zero Then
                Dim IntPTR_pixc(values.n - 1) As intPTR
                Dim Values_pixc As New List(Of PixComp)
                Marshal.Copy(Values.pixc, IntPTR_pixc, 0, values.n)
                For Each _PTR_ In IntPTR_pixc : Values_pixc.Add(New PixComp(_PTR_)) : Next
                Return Values_pixc
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: array of boxes
    '''  Loc: SRC/pix.h (664, 26)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    ReadOnly Property boxa As Boxa
        Get
            If Values.boxa <> IntPtr.Zero Then
                Return New Boxa(Values.boxa)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "n:" & n & " , " & "nalloc:" & nalloc & " , " & "offset:" & offset & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_PixaComp
        Marshal.PtrToStructure(Pointer, Values)
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
    Private Values As Marshal_L_Recog

    ''' <summary>
    ''' Brf: scale all examples to this width;
    '''  Loc: SRC/recog.h (117, 20)
    '''  Org: [l_int32 scalew]
    ''' </summary>
    ReadOnly Property scalew As Integer
        Get
            Return Values.scalew
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: scale all examples to this height;
    '''  Loc: SRC/recog.h (119, 20)
    '''  Org: [l_int32 scaleh]
    ''' </summary>
    ReadOnly Property scaleh As Integer
        Get
            Return Values.scaleh
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: use a value  greater  0 to convert the bitmap
    '''  Loc: SRC/recog.h (121, 20)
    '''  Org: [l_int32 linew]
    ''' </summary>
    ReadOnly Property linew As Integer
        Get
            Return Values.linew
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: template use: use either the average
    '''  Loc: SRC/recog.h (123, 20)
    '''  Org: [l_int32 templ_use]
    ''' </summary>
    ReadOnly Property templ_use As Integer
        Get
            Return Values.templ_use
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: initialize container arrays to this
    '''  Loc: SRC/recog.h (126, 20)
    '''  Org: [l_int32 maxarraysize]
    ''' </summary>
    ReadOnly Property maxarraysize As Integer
        Get
            Return Values.maxarraysize
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of character set
    '''  Loc: SRC/recog.h (127, 20)
    '''  Org: [l_int32 setsize]
    ''' </summary>
    ReadOnly Property setsize As Integer
        Get
            Return Values.setsize
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: for binarizing if depth  greater  1
    '''  Loc: SRC/recog.h (128, 20)
    '''  Org: [l_int32 threshold]
    ''' </summary>
    ReadOnly Property threshold As Integer
        Get
            Return Values.threshold
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: vertical jiggle on nominal centroid
    '''  Loc: SRC/recog.h (129, 20)
    '''  Org: [l_int32 maxyshift]
    ''' </summary>
    ReadOnly Property maxyshift As Integer
        Get
            Return Values.maxyshift
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: one of L_ARABIC_NUMERALS, etc.
    '''  Loc: SRC/recog.h (131, 20)
    '''  Org: [l_int32 charset_type]
    ''' </summary>
    ReadOnly Property charset_type As Integer
        Get
            Return Values.charset_type
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: expected number of classes in charset
    '''  Loc: SRC/recog.h (132, 20)
    '''  Org: [l_int32 charset_size]
    ''' </summary>
    ReadOnly Property charset_size As Integer
        Get
            Return Values.charset_size
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min number of samples without padding
    '''  Loc: SRC/recog.h (133, 20)
    '''  Org: [l_int32 min_nopad]
    ''' </summary>
    ReadOnly Property min_nopad As Integer
        Get
            Return Values.min_nopad
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of training samples
    '''  Loc: SRC/recog.h (134, 20)
    '''  Org: [l_int32 num_samples]
    ''' </summary>
    ReadOnly Property num_samples As Integer
        Get
            Return Values.num_samples
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min width averaged unscaled templates
    '''  Loc: SRC/recog.h (135, 20)
    '''  Org: [l_int32 minwidth_u]
    ''' </summary>
    ReadOnly Property minwidth_u As Integer
        Get
            Return Values.minwidth_u
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max width averaged unscaled templates
    '''  Loc: SRC/recog.h (136, 20)
    '''  Org: [l_int32 maxwidth_u]
    ''' </summary>
    ReadOnly Property maxwidth_u As Integer
        Get
            Return Values.maxwidth_u
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min height averaged unscaled templates
    '''  Loc: SRC/recog.h (137, 20)
    '''  Org: [l_int32 minheight_u]
    ''' </summary>
    ReadOnly Property minheight_u As Integer
        Get
            Return Values.minheight_u
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max height averaged unscaled templates
    '''  Loc: SRC/recog.h (138, 20)
    '''  Org: [l_int32 maxheight_u]
    ''' </summary>
    ReadOnly Property maxheight_u As Integer
        Get
            Return Values.maxheight_u
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min width averaged scaled templates
    '''  Loc: SRC/recog.h (139, 20)
    '''  Org: [l_int32 minwidth]
    ''' </summary>
    ReadOnly Property minwidth As Integer
        Get
            Return Values.minwidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max width averaged scaled templates
    '''  Loc: SRC/recog.h (140, 20)
    '''  Org: [l_int32 maxwidth]
    ''' </summary>
    ReadOnly Property maxwidth As Integer
        Get
            Return Values.maxwidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 when averaged bitmaps are made
    '''  Loc: SRC/recog.h (141, 20)
    '''  Org: [l_int32 ave_done]
    ''' </summary>
    ReadOnly Property ave_done As Integer
        Get
            Return Values.ave_done
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 when training is complete or
    '''  Loc: SRC/recog.h (142, 20)
    '''  Org: [l_int32 train_done]
    ''' </summary>
    ReadOnly Property train_done As Integer
        Get
            Return Values.train_done
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max width/height ratio to split
    '''  Loc: SRC/recog.h (144, 20)
    '''  Org: [l_float32 max_wh_ratio]
    ''' </summary>
    ReadOnly Property max_wh_ratio As Single
        Get
            Return Values.max_wh_ratio
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max of max/min template height ratio
    '''  Loc: SRC/recog.h (145, 20)
    '''  Org: [l_float32 max_ht_ratio]
    ''' </summary>
    ReadOnly Property max_ht_ratio As Single
        Get
            Return Values.max_ht_ratio
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min component width kept in splitting
    '''  Loc: SRC/recog.h (146, 20)
    '''  Org: [l_int32 min_splitw]
    ''' </summary>
    ReadOnly Property min_splitw As Integer
        Get
            Return Values.min_splitw
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max component height kept in splitting
    '''  Loc: SRC/recog.h (147, 20)
    '''  Org: [l_int32 max_splith]
    ''' </summary>
    ReadOnly Property max_splith As Integer
        Get
            Return Values.max_splith
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: text array for arbitrary char set
    '''  Loc: SRC/recog.h (148, 20)
    '''  Org: [struct Sarray * sa_text]
    ''' </summary>
    ReadOnly Property sa_text As Sarray
        Get
            If Values.sa_text <> IntPtr.Zero Then
                Return New Sarray(Values.sa_text)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: index-to-char lut for arbitrary charset
    '''  Loc: SRC/recog.h (149, 20)
    '''  Org: [struct L_Dna * dna_tochar]
    ''' </summary>
    ReadOnly Property dna_tochar As L_Dna
        Get
            If Values.dna_tochar <> IntPtr.Zero Then
                Return New L_Dna(Values.dna_tochar)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: table for finding centroids
    '''  Loc: SRC/recog.h (150, 20)
    '''  Org: [l_int32 * centtab]
    ''' </summary>
    ReadOnly Property centtab As Integer()
        Get
            Dim _centtab(1 - 1) As Integer
            Marshal.Copy(Values.centtab, _centtab, 0, _centtab.Length)
            Return _centtab
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: table for finding pixel sums
    '''  Loc: SRC/recog.h (151, 20)
    '''  Org: [l_int32 * sumtab]
    ''' </summary>
    ReadOnly Property sumtab As Integer()
        Get
            Dim _sumtab(1 - 1) As Integer
            Marshal.Copy(Values.sumtab, _sumtab, 0, _sumtab.Length)
            Return _sumtab
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: all unscaled templates for each class
    '''  Loc: SRC/recog.h (152, 20)
    '''  Org: [struct Pixaa * pixaa_u]
    ''' </summary>
    ReadOnly Property pixaa_u As Pixaa
        Get
            If Values.pixaa_u <> IntPtr.Zero Then
                Return New Pixaa(Values.pixaa_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of all unscaled templates
    '''  Loc: SRC/recog.h (153, 20)
    '''  Org: [struct Ptaa * ptaa_u]
    ''' </summary>
    ReadOnly Property ptaa_u As Ptaa
        Get
            If Values.ptaa_u <> IntPtr.Zero Then
                Return New Ptaa(Values.ptaa_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: area of all unscaled templates
    '''  Loc: SRC/recog.h (154, 20)
    '''  Org: [struct Numaa * naasum_u]
    ''' </summary>
    ReadOnly Property naasum_u As Numaa
        Get
            If Values.naasum_u <> IntPtr.Zero Then
                Return New Numaa(Values.naasum_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: all (scaled) templates for each class
    '''  Loc: SRC/recog.h (155, 20)
    '''  Org: [struct Pixaa * pixaa]
    ''' </summary>
    ReadOnly Property pixaa As Pixaa
        Get
            If Values.pixaa <> IntPtr.Zero Then
                Return New Pixaa(Values.pixaa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of all (scaledl) templates
    '''  Loc: SRC/recog.h (156, 20)
    '''  Org: [struct Ptaa * ptaa]
    ''' </summary>
    ReadOnly Property ptaa As Ptaa
        Get
            If Values.ptaa <> IntPtr.Zero Then
                Return New Ptaa(Values.ptaa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: area of all (scaled) templates
    '''  Loc: SRC/recog.h (157, 20)
    '''  Org: [struct Numaa * naasum]
    ''' </summary>
    ReadOnly Property naasum As Numaa
        Get
            If Values.naasum <> IntPtr.Zero Then
                Return New Numaa(Values.naasum)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: averaged unscaled templates per class
    '''  Loc: SRC/recog.h (158, 20)
    '''  Org: [struct Pixa * pixa_u]
    ''' </summary>
    ReadOnly Property pixa_u As Pixa
        Get
            If Values.pixa_u <> IntPtr.Zero Then
                Return New Pixa(Values.pixa_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of unscaled ave. templates
    '''  Loc: SRC/recog.h (159, 20)
    '''  Org: [struct Pta * pta_u]
    ''' </summary>
    ReadOnly Property pta_u As Pta
        Get
            If Values.pta_u <> IntPtr.Zero Then
                Return New Pta(Values.pta_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: area of unscaled averaged templates
    '''  Loc: SRC/recog.h (160, 20)
    '''  Org: [struct Numa * nasum_u]
    ''' </summary>
    ReadOnly Property nasum_u As Numa
        Get
            If Values.nasum_u <> IntPtr.Zero Then
                Return New Numa(Values.nasum_u)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: averaged (scaled) templates per class
    '''  Loc: SRC/recog.h (161, 20)
    '''  Org: [struct Pixa * pixa]
    ''' </summary>
    ReadOnly Property pixa As Pixa
        Get
            If Values.pixa <> IntPtr.Zero Then
                Return New Pixa(Values.pixa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: centroids of (scaled) ave. templates
    '''  Loc: SRC/recog.h (162, 20)
    '''  Org: [struct Pta * pta]
    ''' </summary>
    ReadOnly Property pta As Pta
        Get
            If Values.pta <> IntPtr.Zero Then
                Return New Pta(Values.pta)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: area of (scaled) averaged templates
    '''  Loc: SRC/recog.h (163, 20)
    '''  Org: [struct Numa * nasum]
    ''' </summary>
    ReadOnly Property nasum As Numa
        Get
            If Values.nasum <> IntPtr.Zero Then
                Return New Numa(Values.nasum)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: all input training images
    '''  Loc: SRC/recog.h (164, 20)
    '''  Org: [struct Pixa * pixa_tr]
    ''' </summary>
    ReadOnly Property pixa_tr As Pixa
        Get
            If Values.pixa_tr <> IntPtr.Zero Then
                Return New Pixa(Values.pixa_tr)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: unscaled and scaled averaged bitmaps
    '''  Loc: SRC/recog.h (165, 20)
    '''  Org: [struct Pixa * pixadb_ave]
    ''' </summary>
    ReadOnly Property pixadb_ave As Pixa
        Get
            If Values.pixadb_ave <> IntPtr.Zero Then
                Return New Pixa(Values.pixadb_ave)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: input images for identifying
    '''  Loc: SRC/recog.h (166, 20)
    '''  Org: [struct Pixa * pixa_id]
    ''' </summary>
    ReadOnly Property pixa_id As Pixa
        Get
            If Values.pixa_id <> IntPtr.Zero Then
                Return New Pixa(Values.pixa_id)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: debug: best match of input against ave.
    '''  Loc: SRC/recog.h (167, 20)
    '''  Org: [struct Pix * pixdb_ave]
    ''' </summary>
    ReadOnly Property pixdb_ave As Pix
        Get
            If Values.pixdb_ave <> IntPtr.Zero Then
                Return New Pix(Values.pixdb_ave)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: debug: best matches within range
    '''  Loc: SRC/recog.h (168, 20)
    '''  Org: [struct Pix * pixdb_range]
    ''' </summary>
    ReadOnly Property pixdb_range As Pix
        Get
            If Values.pixdb_range <> IntPtr.Zero Then
                Return New Pix(Values.pixdb_range)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: debug: bootstrap training results
    '''  Loc: SRC/recog.h (169, 20)
    '''  Org: [struct Pixa * pixadb_boot]
    ''' </summary>
    ReadOnly Property pixadb_boot As Pixa
        Get
            If Values.pixadb_boot <> IntPtr.Zero Then
                Return New Pixa(Values.pixadb_boot)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: debug: splitting results
    '''  Loc: SRC/recog.h (170, 20)
    '''  Org: [struct Pixa * pixadb_split]
    ''' </summary>
    ReadOnly Property pixadb_split As Pixa
        Get
            If Values.pixadb_split <> IntPtr.Zero Then
                Return New Pixa(Values.pixadb_split)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: bmf fonts
    '''  Loc: SRC/recog.h (171, 20)
    '''  Org: [struct L_Bmf * bmf]
    ''' </summary>
    ReadOnly Property bmf As L_Bmf
        Get
            If Values.bmf <> IntPtr.Zero Then
                Return New L_Bmf(Values.bmf)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: font size of bmf; default is 6 pt
    '''  Loc: SRC/recog.h (172, 20)
    '''  Org: [l_int32 bmf_size]
    ''' </summary>
    ReadOnly Property bmf_size As Integer
        Get
            Return Values.bmf_size
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: temp data used for image decoding
    '''  Loc: SRC/recog.h (173, 20)
    '''  Org: [struct L_Rdid * did]
    ''' </summary>
    ReadOnly Property did As L_Rdid
        Get
            If Values.did <> IntPtr.Zero Then
                Return New L_Rdid(Values.did)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: temp data used for holding best char
    '''  Loc: SRC/recog.h (174, 20)
    '''  Org: [struct L_Rch * rch]
    ''' </summary>
    ReadOnly Property rch As L_Rch
        Get
            If Values.rch <> IntPtr.Zero Then
                Return New L_Rch(Values.rch)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: temp data used for array of best chars
    '''  Loc: SRC/recog.h (175, 20)
    '''  Org: [struct L_Rcha * rcha]
    ''' </summary>
    ReadOnly Property rcha As L_Rcha
        Get
            If Values.rcha <> IntPtr.Zero Then
                Return New L_Rcha(Values.rcha)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "scalew:" & scalew & " , " & "scaleh:" & scaleh & " , " & "linew:" & linew & " , " & "templ_use:" & templ_use & " , " & "maxarraysize:" & maxarraysize & " , " & "setsize:" & setsize & " , " & "threshold:" & threshold & " , " & "maxyshift:" & maxyshift & " , " & "charset_type:" & charset_type & " , " & "charset_size:" & charset_size & " , " & "min_nopad:" & min_nopad & " , " & "num_samples:" & num_samples & " , " & "minwidth_u:" & minwidth_u & " , " & "maxwidth_u:" & maxwidth_u & " , " & "minheight_u:" & minheight_u & " , " & "maxheight_u:" & maxheight_u & " , " & "minwidth:" & minwidth & " , " & "maxwidth:" & maxwidth & " , " & "ave_done:" & ave_done & " , " & "train_done:" & train_done & " , " & "max_wh_ratio:" & max_wh_ratio & " , " & "max_ht_ratio:" & max_ht_ratio & " , " & "min_splitw:" & min_splitw & " , " & "max_splith:" & max_splith & " , " & "bmf_size:" & bmf_size & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Recog
        Marshal.PtrToStructure(Pointer, Values)
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
' Data returned from correlation matching on a single character
Public Class L_Rch
    Property Pointer As IntPTR
    Private Values As Marshal_L_Rch

    ''' <summary>
    ''' Brf: index of best template
    '''  Loc: SRC/recog.h (183, 20)
    '''  Org: [l_int32 index]
    ''' </summary>
    ReadOnly Property index As Integer
        Get
            Return Values.index
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: correlation score of best template
    '''  Loc: SRC/recog.h (184, 20)
    '''  Org: [l_float32 score]
    ''' </summary>
    ReadOnly Property score As Single
        Get
            Return Values.score
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: character string of best template
    '''  Loc: SRC/recog.h (185, 20)
    '''  Org: [char * text]
    ''' </summary>
    ReadOnly Property text As String
        Get
            Return Values.text
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: index of best sample (within the best
    '''  Loc: SRC/recog.h (186, 20)
    '''  Org: [l_int32 sample]
    ''' </summary>
    ReadOnly Property sample As Integer
        Get
            Return Values.sample
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x-location of template (delx + shiftx)
    '''  Loc: SRC/recog.h (188, 20)
    '''  Org: [l_int32 xloc]
    ''' </summary>
    ReadOnly Property xloc As Integer
        Get
            Return Values.xloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y-location of template (dely + shifty)
    '''  Loc: SRC/recog.h (189, 20)
    '''  Org: [l_int32 yloc]
    ''' </summary>
    ReadOnly Property yloc As Integer
        Get
            Return Values.yloc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: width of best template
    '''  Loc: SRC/recog.h (190, 20)
    '''  Org: [l_int32 width]
    ''' </summary>
    ReadOnly Property width As Integer
        Get
            Return Values.width
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "index:" & index & " , " & "score:" & score & " , " & "text:" & text & " , " & "sample:" & sample & " , " & "xloc:" & xloc & " , " & "yloc:" & yloc & " , " & "width:" & width & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Rch
        Marshal.PtrToStructure(Pointer, Values)
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
' Data returned from correlation matching on an array of characters
Public Class L_Rcha
    Property Pointer As IntPTR
    Private Values As Marshal_L_Rcha

    ''' <summary>
    ''' Brf: indices of best templates
    '''  Loc: SRC/recog.h (198, 20)
    '''  Org: [struct Numa * naindex]
    ''' </summary>
    ReadOnly Property naindex As Numa
        Get
            If Values.naindex <> IntPtr.Zero Then
                Return New Numa(Values.naindex)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: correlation scores of best templates
    '''  Loc: SRC/recog.h (199, 20)
    '''  Org: [struct Numa * nascore]
    ''' </summary>
    ReadOnly Property nascore As Numa
        Get
            If Values.nascore <> IntPtr.Zero Then
                Return New Numa(Values.nascore)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: character strings of best templates
    '''  Loc: SRC/recog.h (200, 20)
    '''  Org: [struct Sarray * satext]
    ''' </summary>
    ReadOnly Property satext As Sarray
        Get
            If Values.satext <> IntPtr.Zero Then
                Return New Sarray(Values.satext)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: indices of best samples
    '''  Loc: SRC/recog.h (201, 20)
    '''  Org: [struct Numa * nasample]
    ''' </summary>
    ReadOnly Property nasample As Numa
        Get
            If Values.nasample <> IntPtr.Zero Then
                Return New Numa(Values.nasample)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x-locations of templates (delx + shiftx)
    '''  Loc: SRC/recog.h (202, 20)
    '''  Org: [struct Numa * naxloc]
    ''' </summary>
    ReadOnly Property naxloc As Numa
        Get
            If Values.naxloc <> IntPtr.Zero Then
                Return New Numa(Values.naxloc)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y-locations of templates (dely + shifty)
    '''  Loc: SRC/recog.h (203, 20)
    '''  Org: [struct Numa * nayloc]
    ''' </summary>
    ReadOnly Property nayloc As Numa
        Get
            If Values.nayloc <> IntPtr.Zero Then
                Return New Numa(Values.nayloc)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: widths of best templates
    '''  Loc: SRC/recog.h (204, 20)
    '''  Org: [struct Numa * nawidth]
    ''' </summary>
    ReadOnly Property nawidth As Numa
        Get
            If Values.nawidth <> IntPtr.Zero Then
                Return New Numa(Values.nawidth)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Rcha
        Marshal.PtrToStructure(Pointer, Values)
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
' Data used for decoding a line of characters.
Public Class L_Rdid
    Property Pointer As IntPTR
    Private Values As Marshal_L_Rdid

    ''' <summary>
    ''' Brf: clone of pix to be decoded
    '''  Loc: SRC/recog.h (212, 20)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    ReadOnly Property pixs As Pix
        Get
            If Values.pixs <> IntPtr.Zero Then
                Return New Pix(Values.pixs)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: count array for each averaged template
    '''  Loc: SRC/recog.h (213, 20)
    '''  Org: [l_int32 ** counta]
    ''' </summary>
    ReadOnly Property counta As Integer()
        Get
            If Values.counta <> IntPtr.Zero Then
                Marshal.Copy(Values.counta, counta, 0, 1)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: best y-shift array per average template
    '''  Loc: SRC/recog.h (214, 20)
    '''  Org: [l_int32 ** delya]
    ''' </summary>
    ReadOnly Property delya As Integer()
        Get
            If Values.delya <> IntPtr.Zero Then
                Marshal.Copy(Values.delya, delya, 0, 1)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of averaged templates
    '''  Loc: SRC/recog.h (215, 20)
    '''  Org: [l_int32 narray]
    ''' </summary>
    ReadOnly Property narray As Integer
        Get
            Return Values.narray
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of count array (width of pixs)
    '''  Loc: SRC/recog.h (216, 20)
    '''  Org: [l_int32 size]
    ''' </summary>
    ReadOnly Property size As Integer
        Get
            Return Values.size
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: setwidths for each template
    '''  Loc: SRC/recog.h (217, 20)
    '''  Org: [l_int32 * setwidth]
    ''' </summary>
    ReadOnly Property setwidth As Integer()
        Get
            Dim _setwidth(1 - 1) As Integer
            Marshal.Copy(Values.setwidth, _setwidth, 0, _setwidth.Length)
            Return _setwidth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pixel count in pixs by column
    '''  Loc: SRC/recog.h (218, 20)
    '''  Org: [struct Numa * nasum]
    ''' </summary>
    ReadOnly Property nasum As Numa
        Get
            If Values.nasum <> IntPtr.Zero Then
                Return New Numa(Values.nasum)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: first moment of pixels in pixs by cols
    '''  Loc: SRC/recog.h (219, 20)
    '''  Org: [struct Numa * namoment]
    ''' </summary>
    ReadOnly Property namoment As Numa
        Get
            If Values.namoment <> IntPtr.Zero Then
                Return New Numa(Values.namoment)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 1 if full arrays are made; 0 otherwise
    '''  Loc: SRC/recog.h (220, 20)
    '''  Org: [l_int32 fullarrays]
    ''' </summary>
    ReadOnly Property fullarrays As Integer
        Get
            Return Values.fullarrays
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: channel coeffs for template fg term
    '''  Loc: SRC/recog.h (221, 20)
    '''  Org: [l_float32 * beta]
    ''' </summary>
    ReadOnly Property beta As Single()
        Get
            Dim _beta(1 - 1) As Single
            Marshal.Copy(Values.beta, _beta, 0, _beta.Length)
            Return _beta
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: channel coeffs for bit-and term
    '''  Loc: SRC/recog.h (222, 20)
    '''  Org: [l_float32 * gamma]
    ''' </summary>
    ReadOnly Property gamma As Single()
        Get
            Dim _gamma(1 - 1) As Single
            Marshal.Copy(Values.gamma, _gamma, 0, _gamma.Length)
            Return _gamma
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: score on trellis
    '''  Loc: SRC/recog.h (223, 20)
    '''  Org: [l_float32 * trellisscore]
    ''' </summary>
    ReadOnly Property trellisscore As Single()
        Get
            Dim _trellisscore(1 - 1) As Single
            Marshal.Copy(Values.trellisscore, _trellisscore, 0, _trellisscore.Length)
            Return _trellisscore
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: template on trellis (for backtrack)
    '''  Loc: SRC/recog.h (224, 20)
    '''  Org: [l_int32 * trellistempl]
    ''' </summary>
    ReadOnly Property trellistempl As Integer()
        Get
            Dim _trellistempl(1 - 1) As Integer
            Marshal.Copy(Values.trellistempl, _trellistempl, 0, _trellistempl.Length)
            Return _trellistempl
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: indices of best path templates
    '''  Loc: SRC/recog.h (225, 20)
    '''  Org: [struct Numa * natempl]
    ''' </summary>
    ReadOnly Property natempl As Numa
        Get
            If Values.natempl <> IntPtr.Zero Then
                Return New Numa(Values.natempl)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x locations of best path templates
    '''  Loc: SRC/recog.h (226, 20)
    '''  Org: [struct Numa * naxloc]
    ''' </summary>
    ReadOnly Property naxloc As Numa
        Get
            If Values.naxloc <> IntPtr.Zero Then
                Return New Numa(Values.naxloc)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y locations of best path templates
    '''  Loc: SRC/recog.h (227, 20)
    '''  Org: [struct Numa * nadely]
    ''' </summary>
    ReadOnly Property nadely As Numa
        Get
            If Values.nadely <> IntPtr.Zero Then
                Return New Numa(Values.nadely)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: widths of best path templates
    '''  Loc: SRC/recog.h (228, 20)
    '''  Org: [struct Numa * nawidth]
    ''' </summary>
    ReadOnly Property nawidth As Numa
        Get
            If Values.nawidth <> IntPtr.Zero Then
                Return New Numa(Values.nawidth)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: Viterbi result for splitting input pixs
    '''  Loc: SRC/recog.h (229, 20)
    '''  Org: [struct Boxa * boxa]
    ''' </summary>
    ReadOnly Property boxa As Boxa
        Get
            If Values.boxa <> IntPtr.Zero Then
                Return New Boxa(Values.boxa)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: correlation scores: best path templates
    '''  Loc: SRC/recog.h (230, 20)
    '''  Org: [struct Numa * nascore]
    ''' </summary>
    ReadOnly Property nascore As Numa
        Get
            If Values.nascore <> IntPtr.Zero Then
                Return New Numa(Values.nascore)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: indices of best rescored templates
    '''  Loc: SRC/recog.h (231, 20)
    '''  Org: [struct Numa * natempl_r]
    ''' </summary>
    ReadOnly Property natempl_r As Numa
        Get
            If Values.natempl_r <> IntPtr.Zero Then
                Return New Numa(Values.natempl_r)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: samples of best scored templates
    '''  Loc: SRC/recog.h (232, 20)
    '''  Org: [struct Numa * nasample_r]
    ''' </summary>
    ReadOnly Property nasample_r As Numa
        Get
            If Values.nasample_r <> IntPtr.Zero Then
                Return New Numa(Values.nasample_r)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: x locations of best rescoredtemplates
    '''  Loc: SRC/recog.h (233, 20)
    '''  Org: [struct Numa * naxloc_r]
    ''' </summary>
    ReadOnly Property naxloc_r As Numa
        Get
            If Values.naxloc_r <> IntPtr.Zero Then
                Return New Numa(Values.naxloc_r)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: y locations of best rescoredtemplates
    '''  Loc: SRC/recog.h (234, 20)
    '''  Org: [struct Numa * nadely_r]
    ''' </summary>
    ReadOnly Property nadely_r As Numa
        Get
            If Values.nadely_r <> IntPtr.Zero Then
                Return New Numa(Values.nadely_r)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: widths of best rescoredtemplates
    '''  Loc: SRC/recog.h (235, 20)
    '''  Org: [struct Numa * nawidth_r]
    ''' </summary>
    ReadOnly Property nawidth_r As Numa
        Get
            If Values.nawidth_r <> IntPtr.Zero Then
                Return New Numa(Values.nawidth_r)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: correlation scores: rescored templates
    '''  Loc: SRC/recog.h (236, 20)
    '''  Org: [struct Numa * nascore_r]
    ''' </summary>
    ReadOnly Property nascore_r As Numa
        Get
            If Values.nascore_r <> IntPtr.Zero Then
                Return New Numa(Values.nascore_r)
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "narray:" & narray & " , " & "size:" & size & " , " & "fullarrays:" & fullarrays & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Rdid
        Marshal.PtrToStructure(Pointer, Values)
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
' Regression test parameter packer
Public Class L_RegParams
    Property Pointer As IntPTR
    Private Values As Marshal_L_RegParams

    ''' <summary>
    ''' Brf: stream to temporary output file for compare mode
    '''  Loc: SRC/regutils.h (119, 14)
    '''  Org: [FILE * fp]
    ''' </summary>
    ReadOnly Property fp As FILE
        Get
            If Values.fp <> IntPtr.Zero Then
                fp = New FILE(Values.fp)
            Else
                Return Nothing
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: name of test, without '_reg'
    '''  Loc: SRC/regutils.h (120, 14)
    '''  Org: [char * testname]
    ''' </summary>
    ReadOnly Property testname As String
        Get
            Return Values.testname
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: name of temp file for compare mode output
    '''  Loc: SRC/regutils.h (121, 14)
    '''  Org: [char * tempfile]
    ''' </summary>
    ReadOnly Property tempfile As String
        Get
            Return Values.tempfile
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: generate, compare or display
    '''  Loc: SRC/regutils.h (122, 14)
    '''  Org: [l_int32 mode]
    ''' </summary>
    ReadOnly Property mode As Integer
        Get
            Return Values.mode
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: index into saved files for this test; 0-based
    '''  Loc: SRC/regutils.h (123, 14)
    '''  Org: [l_int32 index]
    ''' </summary>
    ReadOnly Property index As Integer
        Get
            Return Values.index
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: overall result of the test
    '''  Loc: SRC/regutils.h (124, 14)
    '''  Org: [l_int32 success]
    ''' </summary>
    ReadOnly Property success As Integer
        Get
            Return Values.success
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 1 if in display mode; 0 otherwise
    '''  Loc: SRC/regutils.h (125, 14)
    '''  Org: [l_int32 display]
    ''' </summary>
    ReadOnly Property display As Integer
        Get
            Return Values.display
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: marks beginning of the reg test
    '''  Loc: SRC/regutils.h (126, 14)
    '''  Org: [L_TIMER tstart]
    ''' </summary>
    ReadOnly Property tstart As IntPTR
        Get
            Return Values.tstart
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "testname:" & testname & " , " & "tempfile:" & tempfile & " , " & "mode:" & mode & " , " & "index:" & index & " , " & "success:" & success & " , " & "display:" & display & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_RegParams
        Marshal.PtrToStructure(Pointer, Values)
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
' stringcode.h
Public Class L_StrCode
    Property Pointer As IntPTR
    Private Values As Marshal_L_StrCode

    ''' <summary>
    ''' Brf: index for function and output file names
    '''  Loc: SRC/stringcode.h (42, 19)
    '''  Org: [l_int32 fileno]
    ''' </summary>
    ReadOnly Property fileno As Integer
        Get
            Return Values.fileno
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: index into struct currently being stored
    '''  Loc: SRC/stringcode.h (43, 19)
    '''  Org: [l_int32 ifunc]
    ''' </summary>
    ReadOnly Property ifunc As Integer
        Get
            Return Values.ifunc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: store case code for extraction
    '''  Loc: SRC/stringcode.h (44, 19)
    '''  Org: [SARRAY * function]
    ''' </summary>
    ReadOnly Property _function_ As SARRAY
        Get
            If Values._function_ <> IntPtr.Zero Then
                _function_ = New SARRAY(Values._function_)
            Else
                Return Nothing
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: store base64 encoded data as strings
    '''  Loc: SRC/stringcode.h (45, 19)
    '''  Org: [SARRAY * data]
    ''' </summary>
    ReadOnly Property data As SARRAY
        Get
            If Values.data <> IntPtr.Zero Then
                data = New SARRAY(Values.data)
            Else
                Return Nothing
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: store line in description table
    '''  Loc: SRC/stringcode.h (46, 19)
    '''  Org: [SARRAY * descr]
    ''' </summary>
    ReadOnly Property descr As SARRAY
        Get
            If Values.descr <> IntPtr.Zero Then
                descr = New SARRAY(Values.descr)
            Else
                Return Nothing
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of data strings
    '''  Loc: SRC/stringcode.h (47, 19)
    '''  Org: [l_int32 n]
    ''' </summary>
    ReadOnly Property n As Integer
        Get
            Return Values.n
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "fileno:" & fileno & " , " & "ifunc:" & ifunc & " , " & "n:" & n & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_StrCode
        Marshal.PtrToStructure(Pointer, Values)
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
' sudoku.h
Public Class L_Sudoku
    Property Pointer As IntPTR
    Private Values As Marshal_L_Sudoku

    ''' <summary>
    ''' Brf: number of unknowns
    '''  Loc: SRC/sudoku.h (54, 20)
    '''  Org: [l_int32 num]
    ''' </summary>
    ReadOnly Property num As Integer
        Get
            Return Values.num
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: location of unknowns
    '''  Loc: SRC/sudoku.h (55, 20)
    '''  Org: [l_int32 * locs]
    ''' </summary>
    ReadOnly Property locs As Integer()
        Get
            Dim _locs(1 - 1) As Integer
            Marshal.Copy(Values.locs, _locs, 0, _locs.Length)
            Return _locs
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: index into %locs of current location
    '''  Loc: SRC/sudoku.h (56, 20)
    '''  Org: [l_int32 current]
    ''' </summary>
    ReadOnly Property current As Integer
        Get
            Return Values.current
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: initial state, with 0 representing
    '''  Loc: SRC/sudoku.h (57, 20)
    '''  Org: [l_int32 * init]
    ''' </summary>
    ReadOnly Property init As Integer()
        Get
            Dim _init(1 - 1) As Integer
            Marshal.Copy(Values.init, _init, 0, _init.Length)
            Return _init
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: present state, including inits and
    '''  Loc: SRC/sudoku.h (59, 20)
    '''  Org: [l_int32 * state]
    ''' </summary>
    ReadOnly Property state As Integer()
        Get
            Dim _state(1 - 1) As Integer
            Marshal.Copy(Values.state, _state, 0, _state.Length)
            Return _state
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: shows current number of guesses
    '''  Loc: SRC/sudoku.h (61, 20)
    '''  Org: [l_int32 nguess]
    ''' </summary>
    ReadOnly Property nguess As Integer
        Get
            Return Values.nguess
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 when solved
    '''  Loc: SRC/sudoku.h (62, 20)
    '''  Org: [l_int32 finished]
    ''' </summary>
    ReadOnly Property finished As Integer
        Get
            Return Values.finished
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 if no solution is possible
    '''  Loc: SRC/sudoku.h (63, 20)
    '''  Org: [l_int32 failure]
    ''' </summary>
    ReadOnly Property failure As Integer
        Get
            Return Values.failure
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "num:" & num & " , " & "current:" & current & " , " & "nguess:" & nguess & " , " & "finished:" & finished & " , " & "failure:" & failure & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Sudoku
        Marshal.PtrToStructure(Pointer, Values)
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
' Simple data structure to hold watershed data.
Public Class L_WShed
    Property Pointer As IntPTR
    Private Values As Marshal_L_WShed

    ''' <summary>
    ''' Brf: clone of input 8 bpp pixs
    '''  Loc: SRC/watershed.h (40, 20)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    ReadOnly Property pixs As Pix
        Get
            If Values.pixs <> IntPtr.Zero Then
                Return New Pix(Values.pixs)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: clone of input 1 bpp seed (marker) pixm
    '''  Loc: SRC/watershed.h (41, 20)
    '''  Org: [struct Pix * pixm]
    ''' </summary>
    ReadOnly Property pixm As Pix
        Get
            If Values.pixm <> IntPtr.Zero Then
                Return New Pix(Values.pixm)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: minimum depth allowed for a watershed
    '''  Loc: SRC/watershed.h (42, 20)
    '''  Org: [l_int32 mindepth]
    ''' </summary>
    ReadOnly Property mindepth As Integer
        Get
            Return Values.mindepth
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 16 bpp label pix
    '''  Loc: SRC/watershed.h (43, 20)
    '''  Org: [struct Pix * pixlab]
    ''' </summary>
    ReadOnly Property pixlab As Pix
        Get
            If Values.pixlab <> IntPtr.Zero Then
                Return New Pix(Values.pixlab)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: scratch pix for computing wshed regions
    '''  Loc: SRC/watershed.h (44, 20)
    '''  Org: [struct Pix * pixt]
    ''' </summary>
    ReadOnly Property pixt As Pix
        Get
            If Values.pixt <> IntPtr.Zero Then
                Return New Pix(Values.pixt)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: line ptrs for pixs
    '''  Loc: SRC/watershed.h (45, 20)
    '''  Org: [void ** lines8]
    ''' </summary>
    ReadOnly Property lines8 As IntPTR()
        Get
            If Values.lines8 <> IntPtr.Zero Then
                Dim _lines8 As IntPTR()
                Marshal.Copy(Values.lines8, _lines8, 0, 1)
                Return _lines8
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: line ptrs for pixm
    '''  Loc: SRC/watershed.h (46, 20)
    '''  Org: [void ** linem1]
    ''' </summary>
    ReadOnly Property linem1 As IntPTR()
        Get
            If Values.linem1 <> IntPtr.Zero Then
                Dim _linem1 As IntPTR()
                Marshal.Copy(Values.linem1, _linem1, 0, 1)
                Return _linem1
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: line ptrs for pixlab
    '''  Loc: SRC/watershed.h (47, 20)
    '''  Org: [void ** linelab32]
    ''' </summary>
    ReadOnly Property linelab32 As IntPTR()
        Get
            If Values.linelab32 <> IntPtr.Zero Then
                Dim _linelab32 As IntPTR()
                Marshal.Copy(Values.linelab32, _linelab32, 0, 1)
                Return _linelab32
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: line ptrs for pixt
    '''  Loc: SRC/watershed.h (48, 20)
    '''  Org: [void ** linet1]
    ''' </summary>
    ReadOnly Property linet1 As IntPTR()
        Get
            If Values.linet1 <> IntPtr.Zero Then
                Dim _linet1 As IntPTR()
                Marshal.Copy(Values.linet1, _linet1, 0, 1)
                Return _linet1
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: result: 1 bpp pixa of watersheds
    '''  Loc: SRC/watershed.h (49, 20)
    '''  Org: [struct Pixa * pixad]
    ''' </summary>
    ReadOnly Property pixad As Pixa
        Get
            If Values.pixad <> IntPtr.Zero Then
                Return New Pixa(Values.pixad)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: pta of initial seed pixels
    '''  Loc: SRC/watershed.h (50, 20)
    '''  Org: [struct Pta * ptas]
    ''' </summary>
    ReadOnly Property ptas As Pta
        Get
            If Values.ptas <> IntPtr.Zero Then
                Return New Pta(Values.ptas)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: numa of seed indicators; 0 if completed
    '''  Loc: SRC/watershed.h (51, 20)
    '''  Org: [struct Numa * nasi]
    ''' </summary>
    ReadOnly Property nasi As Numa
        Get
            If Values.nasi <> IntPtr.Zero Then
                Return New Numa(Values.nasi)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: numa of initial seed heights
    '''  Loc: SRC/watershed.h (52, 20)
    '''  Org: [struct Numa * nash]
    ''' </summary>
    ReadOnly Property nash As Numa
        Get
            If Values.nash <> IntPtr.Zero Then
                Return New Numa(Values.nash)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: numa of initial minima heights
    '''  Loc: SRC/watershed.h (53, 20)
    '''  Org: [struct Numa * namh]
    ''' </summary>
    ReadOnly Property namh As Numa
        Get
            If Values.namh <> IntPtr.Zero Then
                Return New Numa(Values.namh)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: result: numa of watershed levels
    '''  Loc: SRC/watershed.h (54, 20)
    '''  Org: [struct Numa * nalevels]
    ''' </summary>
    ReadOnly Property nalevels As Numa
        Get
            If Values.nalevels <> IntPtr.Zero Then
                Return New Numa(Values.nalevels)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of seeds (markers)
    '''  Loc: SRC/watershed.h (55, 20)
    '''  Org: [l_int32 nseeds]
    ''' </summary>
    ReadOnly Property nseeds As Integer
        Get
            Return Values.nseeds
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of minima different from seeds
    '''  Loc: SRC/watershed.h (56, 20)
    '''  Org: [l_int32 nother]
    ''' </summary>
    ReadOnly Property nother As Integer
        Get
            Return Values.nother
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: lut for pixel indices
    '''  Loc: SRC/watershed.h (57, 20)
    '''  Org: [l_int32 * lut]
    ''' </summary>
    ReadOnly Property lut As Integer()
        Get
            Dim _lut(1 - 1) As Integer
            Marshal.Copy(Values.lut, _lut, 0, _lut.Length)
            Return _lut
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: back-links into lut, for updates
    '''  Loc: SRC/watershed.h (58, 20)
    '''  Org: [struct Numa ** links]
    ''' </summary>
    ReadOnly Property links As List(Of Numa)
        Get
            If Values.links <> IntPtr.Zero Then
                Dim IntPTR_links(1 - 1) As intPTR
                Dim Values_links As New List(Of Numa)
                Marshal.Copy(Values.links, IntPTR_links, 0, 1)
                For Each _PTR_ In IntPTR_links : Values_links.Add(New Numa(_PTR_)) : Next
                Return Values_links
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: size of links array
    '''  Loc: SRC/watershed.h (59, 20)
    '''  Org: [l_int32 arraysize]
    ''' </summary>
    ReadOnly Property arraysize As Integer
        Get
            Return Values.arraysize
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set to 1 for debug output
    '''  Loc: SRC/watershed.h (60, 20)
    '''  Org: [l_int32 debug]
    ''' </summary>
    ReadOnly Property debug As Integer
        Get
            Return Values.debug
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "mindepth:" & mindepth & " , " & "nseeds:" & nseeds & " , " & "nother:" & nother & " , " & "arraysize:" & arraysize & " , " & "debug:" & debug & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_WShed
        Marshal.PtrToStructure(Pointer, Values)
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
' Bilateral filter
Public Class L_Bilateral
    Property Pointer As IntPTR
    Private Values As Marshal_L_Bilateral

    ''' <summary>
    ''' Brf: clone of source pix
    '''  Loc: SRC/bilateral.h (117, 21)
    '''  Org: [struct Pix * pixs]
    ''' </summary>
    ReadOnly Property pixs As Pix
        Get
            If Values.pixs <> IntPtr.Zero Then
                Return New Pix(Values.pixs)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: downscaled pix with mirrored border
    '''  Loc: SRC/bilateral.h (118, 21)
    '''  Org: [struct Pix * pixsc]
    ''' </summary>
    ReadOnly Property pixsc As Pix
        Get
            If Values.pixsc <> IntPtr.Zero Then
                Return New Pix(Values.pixsc)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 1, 2 or 4x for intermediates
    '''  Loc: SRC/bilateral.h (119, 21)
    '''  Org: [l_int32 reduction]
    ''' </summary>
    ReadOnly Property reduction As Integer
        Get
            Return Values.reduction
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: stdev of spatial gaussian
    '''  Loc: SRC/bilateral.h (120, 21)
    '''  Org: [l_float32 spatial_stdev]
    ''' </summary>
    ReadOnly Property spatial_stdev As Single
        Get
            Return Values.spatial_stdev
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: stdev of range gaussian
    '''  Loc: SRC/bilateral.h (121, 21)
    '''  Org: [l_float32 range_stdev]
    ''' </summary>
    ReadOnly Property range_stdev As Single
        Get
            Return Values.range_stdev
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: 1D gaussian spatial kernel
    '''  Loc: SRC/bilateral.h (122, 21)
    '''  Org: [l_float32 * spatial]
    ''' </summary>
    ReadOnly Property spatial As Single()
        Get
            Dim _spatial(1 - 1) As Single
            Marshal.Copy(Values.spatial, _spatial, 0, _spatial.Length)
            Return _spatial
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: one-sided gaussian range kernel
    '''  Loc: SRC/bilateral.h (123, 21)
    '''  Org: [l_float32 * range]
    ''' </summary>
    ReadOnly Property range As Single()
        Get
            Dim _range(1 - 1) As Single
            Marshal.Copy(Values.range, _range, 0, _range.Length)
            Return _range
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: min value in 8 bpp pix
    '''  Loc: SRC/bilateral.h (124, 21)
    '''  Org: [l_int32 minval]
    ''' </summary>
    ReadOnly Property minval As Integer
        Get
            Return Values.minval
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: max value in 8 bpp pix
    '''  Loc: SRC/bilateral.h (125, 21)
    '''  Org: [l_int32 maxval]
    ''' </summary>
    ReadOnly Property maxval As Integer
        Get
            Return Values.maxval
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: number of intermediate results
    '''  Loc: SRC/bilateral.h (126, 21)
    '''  Org: [l_int32 ncomps]
    ''' </summary>
    ReadOnly Property ncomps As Integer
        Get
            Return Values.ncomps
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: set of k values (size ncomps)
    '''  Loc: SRC/bilateral.h (127, 21)
    '''  Org: [l_int32 * nc]
    ''' </summary>
    ReadOnly Property nc As Integer()
        Get
            Dim _nc(1 - 1) As Integer
            Marshal.Copy(Values.nc, _nc, 0, _nc.Length)
            Return _nc
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: mapping from intensity to lower k
    '''  Loc: SRC/bilateral.h (128, 21)
    '''  Org: [l_int32 * kindex]
    ''' </summary>
    ReadOnly Property kindex As Integer()
        Get
            Dim _kindex(1 - 1) As Integer
            Marshal.Copy(Values.kindex, _kindex, 0, _kindex.Length)
            Return _kindex
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: mapping from intensity to fract k
    '''  Loc: SRC/bilateral.h (129, 21)
    '''  Org: [l_float32 * kfract]
    ''' </summary>
    ReadOnly Property kfract As Single()
        Get
            Dim _kfract(1 - 1) As Single
            Marshal.Copy(Values.kfract, _kfract, 0, _kfract.Length)
            Return _kfract
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: intermediate result images (PBC)
    '''  Loc: SRC/bilateral.h (130, 21)
    '''  Org: [struct Pixa * pixac]
    ''' </summary>
    ReadOnly Property pixac As Pixa
        Get
            If Values.pixac <> IntPtr.Zero Then
                Return New Pixa(Values.pixac)
            End If
            Return Nothing
        End Get
    End Property

    ''' <summary>
    ''' Brf: lineptrs for pixac
    '''  Loc: SRC/bilateral.h (131, 21)
    '''  Org: [l_uint32 *** lineset]
    ''' </summary>
    ReadOnly Property lineset As List(Of Byte())
        Get
            If Values.lineset <> IntPtr.Zero Then
                Dim IntPTR_lineset(1 - 1) As intPTR
                Dim Values_lineset As New List(Of Byte())
                Marshal.Copy(Values.lineset, IntPTR_lineset, 0, 1)
                'For Each _PTR_ In IntPTR_lineset : Values_lineset.Add(New Byte()(_PTR_)) : Next
                Return Values_lineset
            End If
            Return Nothing
        End Get
    End Property

    Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return "reduction:" & reduction & " , " & "spatial_stdev:" & spatial_stdev & " , " & "range_stdev:" & range_stdev & " , " & "minval:" & minval & " , " & "maxval:" & maxval & " , " & "ncomps:" & ncomps & " , " & " "
    End Function
    Sub New(PTR As IntPTR)
        If PTR = IntPtr.Zero Then Exit Sub
        Pointer = PTR
        Values = New Marshal_L_Bilateral
        Marshal.PtrToStructure(Pointer, Values)
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
' BMP file header
Public Class BMP_FileHeader
	Property Pointer as IntPTR
	Private Values as Marshal_BMP_FileHeader

''' <summary>
''' Brf: file type; must be "BM"
'''  Loc: SRC/bmp.h (52, 20)
'''  Org: [l_int16 bfType]
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
''' </summary>
ReadOnly Property bfFill2 as Short
	Get
				Return Values.bfFill2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"bfType:" & bfType & " , " & 	"bfSize:" & bfSize & " , " & 	"bfFill1:" & bfFill1 & " , " & 	"bfReserved1:" & bfReserved1 & " , " & 	"bfReserved2:" & bfReserved2 & " , " & 	"bfOffBits:" & bfOffBits & " , " & 	"bfFill2:" & bfFill2 & " , " & " "
End Function
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
''' </summary>
ReadOnly Property biClrImportant as Integer
	Get
				Return Values.biClrImportant
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"biSize:" & biSize & " , " & 	"biWidth:" & biWidth & " , " & 	"biHeight:" & biHeight & " , " & 	"biPlanes:" & biPlanes & " , " & 	"biBitCount:" & biBitCount & " , " & 	"biCompression:" & biCompression & " , " & 	"biSizeImage:" & biSizeImage & " , " & 	"biXPelsPerMeter:" & biXPelsPerMeter & " , " & 	"biYPelsPerMeter:" & biYPelsPerMeter & " , " & 	"biClrUsed:" & biClrUsed & " , " & 	"biClrImportant:" & biClrImportant & " , " & " "
End Function
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
''' </summary>
ReadOnly Property bleaf as Integer
	Get
				Return Values.bleaf
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"rc:" & rc & " , " & 	"gc:" & gc & " , " & 	"bc:" & bc & " , " & 	"n:" & n & " , " & 	"index:" & index & " , " & 	"nleaves:" & nleaves & " , " & 	"bleaf:" & bleaf & " , " & " "
End Function
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
''' </summary>
ReadOnly Property bval as Integer
	Get
				Return Values.bval
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"n:" & n & " , " & 	"octindex:" & octindex & " , " & 	"rcum:" & rcum & " , " & 	"gcum:" & gcum & " , " & 	"bcum:" & bcum & " , " & 	"rval:" & rval & " , " & 	"gval:" & gval & " , " & 	"bval:" & bval & " , " & " "
End Function
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
''' </summary>
ReadOnly Property bval as Integer
	Get
				Return Values.bval
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"npix:" & npix & " , " & 	"index:" & index & " , " & 	"rval:" & rval & " , " & 	"gval:" & gval & " , " & 	"bval:" & bval & " , " & " "
End Function
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
''' </summary>
ReadOnly Property b2 as Integer
	Get
				Return Values.b2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"sortparam:" & sortparam & " , " & 	"npix:" & npix & " , " & 	"vol:" & vol & " , " & 	"r1:" & r1 & " , " & 	"r2:" & r2 & " , " & 	"g1:" & g1 & " , " & 	"g2:" & g2 & " , " & 	"b1:" & b1 & " , " & 	"b2:" & b2 & " , " & " "
End Function
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
''' </summary>
ReadOnly Property dy as Integer
	Get
				Return Values.dy
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"xleft:" & xleft & " , " & 	"xright:" & xright & " , " & 	"y:" & y & " , " & 	"dy:" & dy & " , " & " "
End Function
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
''' </summary>
ReadOnly Property classer as JBCLASSER
	Get
			If Values.classer <> IntPtr.Zero Then 
		classer = New JBCLASSER(Values.classer)
	Else
		Return Nothing
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (239, 22)
'''  Org: [l_int32 w]
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
''' </summary>
ReadOnly Property dna as L_DNA
	Get
			If Values.dna <> IntPtr.Zero Then 
		dna = New L_DNA(Values.dna)
	Else
		Return Nothing
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\jbclass.c (243, 22)
'''  Org: [l_int32 n]
''' </summary>
ReadOnly Property n as Integer
	Get
				Return Values.n
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"w:" & w & " , " & 	"h:" & h & " , " & 	"i:" & i & " , " & 	"n:" & n & " , " & " "
End Function
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
''' </summary>
ReadOnly Property comment as Byte()
	Get
		Dim _comment(1 -1) as Byte
Marshal.Copy(Values.comment, _comment, 0, _comment.Length)
Return _comment
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"jmpbuf:" & jmpbuf & " , " & " "
End Function
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
''' </summary>
ReadOnly Property dir as Integer
	Get
				Return Values.dir
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"distance:" & distance & " , " & 	"x:" & x & " , " & 	"y:" & y & " , " & 	"val:" & val & " , " & 	"dir:" & dir & " , " & " "
End Function
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
''' </summary>
ReadOnly Property box as BOX
	Get
			If Values.box <> IntPtr.Zero Then 
		box = New BOX(Values.box)
	Else
		Return Nothing
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\partition.c (51, 16)
'''  Org: [BOXA * boxa]
''' </summary>
ReadOnly Property boxa as BOXA
	Get
			If Values.boxa <> IntPtr.Zero Then 
		boxa = New BOXA(Values.boxa)
	Else
		Return Nothing
	End if
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"size:" & size & " , " & " "
End Function
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
''' </summary>
ReadOnly Property deallocator as IntPTR
	Get
				Return Values.deallocator
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return " "
End Function
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
'''  Marshal = greater  UInteger = greater  Byte() : [UInt=4 Bytes]
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
''' </summary>
ReadOnly Property allocarray as Integer()
	Get
		Dim _allocarray(1 -1) as Integer
Marshal.Copy(Values.allocarray, _allocarray, 0, _allocarray.Length)
Return _allocarray
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: ptr to allocated array
'''  Loc: SRC\pixalloc.c (124, 22)
'''  Org: [l_uint32 * baseptr]
'''  Marshal = greater  UInteger = greater  Byte() : [UInt=4 Bytes]
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
'''  Marshal = greater  UInteger = greater  Byte() : [UInt=4 Bytes]
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
''' </summary>
ReadOnly Property firstptr as Byte()
	Get
			If Values.firstptr <> IntPtr.Zero Then 
		Marshal.Copy(Values.firstptr, firstptr, 0, 1)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: total # of pix used (by level)
'''  Loc: SRC\pixalloc.c (127, 22)
'''  Org: [l_int32 * memused]
''' </summary>
ReadOnly Property memused as Integer()
	Get
		Dim _memused(1 -1) as Integer
Marshal.Copy(Values.memused, _memused, 0, _memused.Length)
Return _memused
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (128, 22)
'''  Org: [l_int32 * meminuse]
''' </summary>
ReadOnly Property meminuse as Integer()
	Get
		Dim _meminuse(1 -1) as Integer
Marshal.Copy(Values.meminuse, _meminuse, 0, _meminuse.Length)
Return _meminuse
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: max # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (129, 22)
'''  Org: [l_int32 * memmax]
''' </summary>
ReadOnly Property memmax as Integer()
	Get
		Dim _memmax(1 -1) as Integer
Marshal.Copy(Values.memmax, _memmax, 0, _memmax.Length)
Return _memmax
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: # of pix alloc'd because
'''  Loc: SRC\pixalloc.c (130, 22)
'''  Org: [l_int32 * memempty]
''' </summary>
ReadOnly Property memempty as Integer()
	Get
		Dim _memempty(1 -1) as Integer
Marshal.Copy(Values.memempty, _memempty, 0, _memempty.Length)
Return _memempty
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: log: set to null if no logging
'''  Loc: SRC\pixalloc.c (132, 22)
'''  Org: [char * logfile]
''' </summary>
ReadOnly Property logfile as String
	Get
				Return Values.logfile
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"minsize:" & minsize & " , " & 	"smallest:" & smallest & " , " & 	"largest:" & largest & " , " & 	"nbytes:" & nbytes & " , " & 	"nlevels:" & nlevels & " , " & 	"logfile:" & logfile & " , " & " "
End Function
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
' A node in a linked list of memory buffers that hold I/O content
Public Class MemIOData
	Property Pointer as IntPTR
	Private Values as Marshal_MemIOData

''' <summary>
''' Brf: pointer to this node's I/O content
'''  Loc: SRC\pngio.c (1295, 17)
'''  Org: [char * m_Buffer]
''' </summary>
ReadOnly Property m_Buffer as String
	Get
				Return Values.m_Buffer
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: number of I/O content bytes read or written
'''  Loc: SRC\pngio.c (1296, 17)
'''  Org: [l_int32 m_Count]
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
Public Overrides Function ToString() As String
Return 	"m_Buffer:" & m_Buffer & " , " & 	"m_Count:" & m_Count & " , " & 	"m_Size:" & m_Size & " , " & " "
End Function
	Sub New (PTR as IntPTR)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Values = New  Marshal_MemIOData
		Marshal.PtrToStructure (Pointer, Values)
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
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"x:" & x & " , " & 	"y:" & y & " , " & " "
End Function
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
''' </summary>
ReadOnly Property selnamev2 as Char
	Get
				Return Values.selnamev2
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"size:" & size & " , " & 	"size1:" & size1 & " , " & 	"size2:" & size2 & " , " & 	"selnameh1:" & selnameh1 & " , " & 	"selnameh2:" & selnameh2 & " , " & 	"selnamev1:" & selnamev1 & " , " & 	"selnamev2:" & selnamev2 & " , " & " "
End Function
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
''' </summary>
ReadOnly Property memreader as Char
	Get
				Return Values.memreader
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"index:" & index & " , " & 	"type:" & type & " , " & 	"structname:" & structname & " , " & 	"reader:" & reader & " , " & 	"memreader:" & memreader & " , " & " "
End Function
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
''' </summary>
ReadOnly Property rotate as Integer
	Get
				Return Values.rotate
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"vflip:" & vflip & " , " & 	"hflip:" & hflip & " , " & 	"rotate:" & rotate & " , " & " "
End Function
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
''' </summary>
ReadOnly Property buffer as Byte()
	Get
		Dim _buffer(1 -1) as Byte
Marshal.Copy(Values.buffer, _buffer, 0, _buffer.Length)
Return _buffer
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2178, 16)
'''  Org: [size_t bufsize]
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
''' </summary>
ReadOnly Property poutdata as Byte()
	Get
			If Values.poutdata <> IntPtr.Zero Then 
		Marshal.Copy(Values.poutdata, poutdata, 0, 1)
	End if
		Return Nothing
	End Get
End Property

''' <summary>
''' Brf: 
'''  Loc: SRC\tiffio.c (2183, 16)
'''  Org: [size_t * poutsize]
'''  Marshal = greater  UInteger = greater  Byte() : [UInt=4 Bytes]
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
Public Overrides Function ToString() As String
Return 	"bufsize:" & bufsize & " , " & 	"offset:" & offset & " , " & 	"hw:" & hw & " , " & " "
End Function
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
''' </summary>
ReadOnly Property y as Integer
	Get
				Return Values.y
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"x:" & x & " , " & 	"y:" & y & " , " & " "
End Function
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
''' </summary>
ReadOnly Property index as Integer
	Get
				Return Values.index
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"val:" & val & " , " & 	"x:" & x & " , " & 	"y:" & y & " , " & 	"index:" & index & " , " & " "
End Function
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
''' </summary>
ReadOnly Property format as Integer
	Get
				Return Values.format
		Return Nothing
	End Get
End Property

	Sub New ()
	End Sub
Public Overrides Function ToString() As String
Return 	"extension:" & extension & " , " & 	"format:" & format & " , " & " "
End Function
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
