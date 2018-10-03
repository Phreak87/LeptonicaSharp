Imports System.Runtime.InteropServices

Imports LeptonicaSharp.Enumerations

#Region "SRC/environ.h"
'  SRC/environ.h (308, 8)
'  Timing struct
Public Class L_WallTimer
	Property Pointer as IntPtr
	Private Values as new Marshal_L_WallTimer



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/environ.h (309, 14)
'''  Org: [l_int32 start_sec]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property start_sec as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.start_sec
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/environ.h (310, 14)
'''  Org: [l_int32 start_usec]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property start_usec as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.start_usec
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/environ.h (311, 14)
'''  Org: [l_int32 stop_sec]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property stop_sec as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.stop_sec
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/environ.h (312, 14)
'''  Org: [l_int32 stop_usec]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property stop_usec as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.stop_usec
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_WallTimer
		public start_sec as Integer
		public start_usec as Integer
		public stop_sec as Integer
		public stop_usec as Integer
	End Class
End Class


#End Region
#Region "SRC/array.h"
'  SRC/array.h (59, 8)
'  Number array: an array of floats
Public Class Numa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Numa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.NumaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated number array
'''  Loc: SRC/array.h (61, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of numbers saved
'''  Loc: SRC/array.h (62, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (63, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refcount as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (64, 22)
'''  Org: [l_float32 startx]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property startx as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.startx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: change in x value as i --> i + 1
'''  Loc: SRC/array.h (65, 22)
'''  Org: [l_float32 delx]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property delx as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.delx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number array
'''  Loc: SRC/array.h (66, 22)
'''  Org: [l_float32 * array]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property array as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Single
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Numa
		public nalloc as Integer
		public n as Integer
		public refcount as Integer
		public startx as Single
		public delx as Single
		public array as IntPtr
	End Class
End Class


'  SRC/array.h (71, 8)
'  Array of number arrays
Public Class Numaa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Numaa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.NumaaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/array.h (73, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of Numa saved
'''  Loc: SRC/array.h (74, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of Numa
'''  Loc: SRC/array.h (75, 22)
'''  Org: [struct Numa ** numa]
'''  Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
'''  </summary>
ReadOnly property numa as List (of Numa)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.numa <> IntPtr.Zero Then
		Dim LST_numa As New List(Of Numa)
		Dim ARR_numa(values.n - 1) As IntPtr
		Marshal.Copy(Values.numa, ARR_numa, 0, values.n)
		For Each Entry In ARR_numa
			LST_numa.Add(New Numa(Entry))
		Next
Return LST_numa
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Numaa
		public nalloc as Integer
		public n as Integer
		public numa as IntPtr
	End Class
End Class


'  SRC/array.h (83, 8)
'  Double number array: an array of doubles
Public Class L_Dna
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Dna

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.L_DnaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated number array
'''  Loc: SRC/array.h (85, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of numbers saved
'''  Loc: SRC/array.h (86, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (87, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refcount as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x value assigned to array[0]
'''  Loc: SRC/array.h (88, 22)
'''  Org: [l_float64 startx]
'''  Msh: l_float64 | 1:Double |
'''  </summary>
ReadOnly property startx as Double
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.startx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: change in x value as i --> i + 1
'''  Loc: SRC/array.h (89, 22)
'''  Org: [l_float64 delx]
'''  Msh: l_float64 | 1:Double |
'''  </summary>
ReadOnly property delx as Double
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.delx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number array
'''  Loc: SRC/array.h (90, 22)
'''  Org: [l_float64 * array]
'''  Msh: l_float64 * | 2:Double |
'''  </summary>
ReadOnly property array as Double()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Double
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Dna
		public nalloc as Integer
		public n as Integer
		public refcount as Integer
		public startx as Double
		public delx as Double
		public array as IntPtr
	End Class
End Class


'  SRC/array.h (95, 8)
'  Array of double number arrays
Public Class L_Dnaa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Dnaa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.L_DnaaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/array.h (97, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of L_Dna saved
'''  Loc: SRC/array.h (98, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of L_Dna
'''  Loc: SRC/array.h (99, 22)
'''  Org: [struct L_Dna ** dna]
'''  Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property dna as List (of L_Dna)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.dna <> IntPtr.Zero Then
		Dim LST_dna As New List(Of L_Dna)
		Dim ARR_dna(values.n - 1) As IntPtr
		Marshal.Copy(Values.dna, ARR_dna, 0, values.n)
		For Each Entry In ARR_dna
			LST_dna.Add(New L_Dna(Entry))
		Next
Return LST_dna
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Dnaa
		public nalloc as Integer
		public n as Integer
		public dna as IntPtr
	End Class
End Class


'  SRC/array.h (104, 8)
'  A hash table of Dnas
Public Class L_DnaHash
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_L_DnaHash

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.L_DnaHashDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/array.h (106, 22)
'''  Org: [l_int32 nbuckets]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nbuckets as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nbuckets
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: initial size of each dna that is made
'''  Loc: SRC/array.h (107, 22)
'''  Org: [l_int32 initsize]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property initsize as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.initsize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of L_Dna
'''  Loc: SRC/array.h (108, 22)
'''  Org: [struct L_Dna ** dna]
'''  Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property dna as List (of L_Dna)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.dna <> IntPtr.Zero Then
		Dim LST_dna As New List(Of L_Dna)
		Dim ARR_dna(1 - 1) As IntPtr
		Marshal.Copy(Values.dna, ARR_dna, 0, 1)
		For Each Entry In ARR_dna
			LST_dna.Add(New L_Dna(Entry))
		Next
Return LST_dna
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_DnaHash
		public nbuckets as Integer
		public initsize as Integer
		public dna as IntPtr
	End Class
End Class


'  SRC/array.h (116, 8)
'  String array: an array of C strings
Public Class Sarray
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Sarray

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.SarrayDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/array.h (118, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of strings allocated
'''  Loc: SRC/array.h (119, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (120, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refcount as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: string array
'''  Loc: SRC/array.h (121, 22)
'''  Org: [char ** array]
'''  Msh: char ** | 3:CharS | String()
'''  </summary>
ReadOnly property array as String()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim LSTRET As New List(Of String)
Dim LSTPTR(values.n - 1) As IntPtr: Marshal.Copy(Values.array, LSTPTR, 0, values.n)
For Each Entry As IntPtr In LSTPTR: LSTRET.Add(Marshal.PtrToStringAnsi(Entry)): Next
Return LSTRET.ToArray
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Sarray
		public nalloc as Integer
		public n as Integer
		public refcount as Integer
		public array as IntPtr
	End Class
End Class


'  SRC/array.h (126, 8)
'  Byte array (analogous to C++ "string")
Public Class L_Bytea
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Bytea

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.L_ByteaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of bytes allocated in data array
'''  Loc: SRC/array.h (128, 22)
'''  Org: [size_t nalloc]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property nalloc as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of bytes presently used
'''  Loc: SRC/array.h (129, 22)
'''  Org: [size_t size]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property size as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/array.h (130, 22)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refcount as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: data array
'''  Loc: SRC/array.h (131, 22)
'''  Org: [l_uint8 * data]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property data as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data <> IntPtr.Zero Then 
	Dim _data(values.nalloc -1) as Byte
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Bytea
		public nalloc as UInteger
		public size as UInteger
		public refcount as Integer
		public data as IntPtr
	End Class
End Class


#End Region
#Region "SRC/bbuffer.h"
'  SRC/bbuffer.h (50, 8)
'  Expandable byte buffer for memory read/write operations
Public Class L_ByteBuffer
	Property Pointer as IntPtr
	Private Values as new Marshal_L_ByteBuffer



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated byte array
'''  Loc: SRC/bbuffer.h (52, 18)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of bytes read into to the array
'''  Loc: SRC/bbuffer.h (53, 18)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of bytes written from the array
'''  Loc: SRC/bbuffer.h (54, 18)
'''  Org: [l_int32 nwritten]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nwritten as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nwritten
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: byte array
'''  Loc: SRC/bbuffer.h (55, 18)
'''  Org: [l_uint8 * array]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property array as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.array <> IntPtr.Zero Then 
	Dim _array(values.n -1) as Byte
	Marshal.Copy(Values.array, _array, 0, _array.Length)
	Return _array
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_ByteBuffer
		public nalloc as Integer
		public n as Integer
		public nwritten as Integer
		public array as IntPtr
	End Class
End Class


#End Region
#Region "SRC/heap.h"
'  SRC/heap.h (77, 8)
'  Heap of arbitrary void* data
Public Class L_Heap
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Heap



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/heap.h (79, 18)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of elements stored in the heap
'''  Loc: SRC/heap.h (80, 18)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr array
'''  Loc: SRC/heap.h (81, 18)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property array as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.n) as IntPtr
		Marshal.Copy(Values.array, _array, 0, values.n)
		Return _array
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: L_SORT_INCREASING or L_SORT_DECREASING
'''  Loc: SRC/heap.h (82, 18)
'''  Org: [l_int32 direction]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property direction as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.direction
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Heap
		public nalloc as Integer
		public n as Integer
		public array as IntPtr
		public direction as Integer
	End Class
End Class


#End Region
#Region "SRC/list.h"
'  SRC/list.h (61, 8)
'  list.h
Public Class DoubleLinkedList
	Property Pointer as IntPtr
	Private Values as new Marshal_DoubleLinkedList



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/list.h (63, 33)
'''  Org: [struct DoubleLinkedList * prev]
'''  Msh: struct DoubleLinkedList * | 2:Struct |
'''  </summary>
ReadOnly property prev as DoubleLinkedList
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.prev <> IntPtr.Zero Then 
		Return New DoubleLinkedList(Values.prev)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/list.h (64, 33)
'''  Org: [struct DoubleLinkedList * next]
'''  Msh: struct DoubleLinkedList * | 2:Struct |
'''  </summary>
ReadOnly property _next_ as DoubleLinkedList
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values._next_ <> IntPtr.Zero Then 
		Return New DoubleLinkedList(Values._next_)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/list.h (65, 33)
'''  Org: [void * data]
'''  Msh: void * | 2:Void |  ... Pointer auf Object = IntPtr
'''  </summary>
ReadOnly property data as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data <> IntPtr.Zero Then
	Return  Values.data
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_DoubleLinkedList
		public prev as IntPtr
		public _next_ as IntPtr
		public data as IntPtr
	End Class
End Class


#End Region
#Region "SRC/ptra.h"
'  SRC/ptra.h (51, 8)
'  Generic pointer array
Public Class L_Ptra
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Ptra



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (53, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: greatest valid index
'''  Loc: SRC/ptra.h (54, 22)
'''  Org: [l_int32 imax]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property imax as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.imax
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: actual number of stored elements
'''  Loc: SRC/ptra.h (55, 22)
'''  Org: [l_int32 nactual]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nactual as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nactual
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr array
'''  Loc: SRC/ptra.h (56, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property array as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.nactual) as IntPtr
		Marshal.Copy(Values.array, _array, 0, values.nactual)
		Return _array
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Ptra
		public nalloc as Integer
		public imax as Integer
		public nactual as Integer
		public array as IntPtr
	End Class
End Class


'  SRC/ptra.h (62, 8)
'  Array of generic pointer arrays
Public Class L_Ptraa
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Ptraa



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/ptra.h (64, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of ptra
'''  Loc: SRC/ptra.h (65, 22)
'''  Org: [struct L_Ptra ** ptra]
'''  Msh: struct L_Ptra ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Ptra = L_Ptra
'''  </summary>
ReadOnly property ptra as List (of L_Ptra)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.ptra <> IntPtr.Zero Then
		Dim LST_ptra As New List(Of L_Ptra)
		Dim ARR_ptra(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.ptra, ARR_ptra, 0, values.nalloc)
		For Each Entry In ARR_ptra
			LST_ptra.Add(New L_Ptra(Entry))
		Next
Return LST_ptra
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Ptraa
		public nalloc as Integer
		public ptra as IntPtr
	End Class
End Class


#End Region
#Region "SRC/queue.h"
'  SRC/queue.h (64, 8)
'  Expandable pointer queue for arbitrary void* data
Public Class L_Queue
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Queue



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/queue.h (66, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: location of head (in ptrs) from the
'''  Loc: SRC/queue.h (67, 22)
'''  Org: [l_int32 nhead]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nhead as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nhead
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of elements stored in the queue
'''  Loc: SRC/queue.h (69, 22)
'''  Org: [l_int32 nelem]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nelem as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nelem
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr array
'''  Loc: SRC/queue.h (70, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property array as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.nelem) as IntPtr
		Marshal.Copy(Values.array, _array, 0, values.nelem)
		Return _array
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: auxiliary stack
'''  Loc: SRC/queue.h (71, 22)
'''  Org: [struct L_Stack * stack]
'''  Msh: struct L_Stack * | 2:Struct |
'''  </summary>
ReadOnly property stack as L_Stack
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.stack <> IntPtr.Zero Then 
		Return New L_Stack(Values.stack)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Queue
		public nalloc as Integer
		public nhead as Integer
		public nelem as Integer
		public array as IntPtr
		public stack as IntPtr
	End Class
End Class


#End Region
#Region "SRC/rbtree.h"
'  SRC/rbtree.h (61, 7)
'  Storage for keys and values for red-black trees, maps and sets. Note: (1) Keys and values of the valid key types are all 64-bit (2) (void *) can be used for values but not for keys.
Public Class Rb_Type
	Property Pointer as IntPtr
	Private Values as new Marshal_Rb_Type



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (62, 16)
'''  Org: [l_int64 itype]
'''  Msh: l_int64 | 1:LongLong |
'''  </summary>
ReadOnly property itype as Long
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.itype
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (63, 16)
'''  Org: [l_uint64 utype]
'''  Msh: l_uint64 | 1:ULongLong |
'''  </summary>
ReadOnly property utype as ULong
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.utype
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (64, 16)
'''  Org: [l_float64 ftype]
'''  Msh: l_float64 | 1:Double |
'''  </summary>
ReadOnly property ftype as Double
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ftype
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (65, 16)
'''  Org: [void * ptype]
'''  Msh: void * | 2:Void |  ... Pointer auf Object = IntPtr
'''  </summary>
ReadOnly property ptype as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.ptype <> IntPtr.Zero Then
	Return  Values.ptype
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Rb_Type
		public itype as Long
		public utype as ULong
		public ftype as Double
		public ptype as IntPtr
	End Class
End Class


'  SRC/rbtree.h (69, 8)
'  
Public Class L_Rbtree
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Rbtree

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.L_RbtreeDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (70, 28)
'''  Org: [struct L_Rbtree_Node * root]
'''  Msh: struct L_Rbtree_Node * | 2:Struct |
'''  </summary>
ReadOnly property root as L_Rbtree_Node
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.root <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.root)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (71, 28)
'''  Org: [l_int32 keytype]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property keytype as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.keytype
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rbtree
		public root as IntPtr
		public keytype as Integer
	End Class
End Class


'  SRC/rbtree.h (77, 8)
'  
Public Class L_Rbtree_Node
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Rbtree_Node



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (78, 28)
'''  Org: [union Rb_Type key]
'''  Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
'''  </summary>
ReadOnly property key as Rb_Type
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.key
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (79, 28)
'''  Org: [union Rb_Type value]
'''  Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
'''  </summary>
ReadOnly property value as Rb_Type
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.value
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (80, 28)
'''  Org: [struct L_Rbtree_Node * left]
'''  Msh: struct L_Rbtree_Node * | 2:Struct |
'''  </summary>
ReadOnly property left as L_Rbtree_Node
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.left <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.left)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (81, 28)
'''  Org: [struct L_Rbtree_Node * right]
'''  Msh: struct L_Rbtree_Node * | 2:Struct |
'''  </summary>
ReadOnly property right as L_Rbtree_Node
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.right <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.right)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (82, 28)
'''  Org: [struct L_Rbtree_Node * parent]
'''  Msh: struct L_Rbtree_Node * | 2:Struct |
'''  </summary>
ReadOnly property parent as L_Rbtree_Node
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.parent <> IntPtr.Zero Then 
		Return New L_Rbtree_Node(Values.parent)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC/rbtree.h (83, 28)
'''  Org: [l_int32 color]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property color as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.color
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rbtree_Node
		public key as Rb_Type
		public value as Rb_Type
		public left as IntPtr
		public right as IntPtr
		public parent as IntPtr
		public color as Integer
	End Class
End Class


#End Region
#Region "SRC/stack.h"
'  SRC/stack.h (59, 8)
'  Expandable pointer stack for arbitrary void* data. Note that array[n] is the first null ptr in the array
Public Class L_Stack
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Stack



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of ptr array
'''  Loc: SRC/stack.h (61, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of stored elements
'''  Loc: SRC/stack.h (62, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr array
'''  Loc: SRC/stack.h (63, 22)
'''  Org: [void ** array]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property array as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.array <> IntPtr.Zero Then 
		Dim _array(values.n) as IntPtr
		Marshal.Copy(Values.array, _array, 0, values.n)
		Return _array
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: auxiliary stack
'''  Loc: SRC/stack.h (64, 22)
'''  Org: [struct L_Stack * auxstack]
'''  Msh: struct L_Stack * | 2:Struct |
'''  </summary>
ReadOnly property auxstack as L_Stack
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.auxstack <> IntPtr.Zero Then 
		Return New L_Stack(Values.auxstack)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Stack
		public nalloc as Integer
		public n as Integer
		public array as IntPtr
		public auxstack as IntPtr
	End Class
End Class


#End Region
#Region "SRC/bmf.h"
'  SRC/bmf.h (45, 8)
'  Data structure to hold bitmap fonts and related data
Public Class L_Bmf
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Bmf



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: pixa of bitmaps for 93 characters
'''  Loc: SRC/bmf.h (47, 19)
'''  Org: [struct Pixa * pixa]
'''  Msh: struct Pixa * | 2:Struct |
'''  </summary>
ReadOnly property pixa as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixa <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: font size (in points at 300 ppi)
'''  Loc: SRC/bmf.h (48, 19)
'''  Org: [l_int32 size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: directory containing font bitmaps
'''  Loc: SRC/bmf.h (49, 19)
'''  Org: [char * directory]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property directory as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.directory <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.directory)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: baseline offset for ascii 33 - 57
'''  Loc: SRC/bmf.h (50, 19)
'''  Org: [l_int32 baseline1]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property baseline1 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.baseline1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: baseline offset for ascii 58 - 91
'''  Loc: SRC/bmf.h (51, 19)
'''  Org: [l_int32 baseline2]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property baseline2 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.baseline2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: baseline offset for ascii 93 - 126
'''  Loc: SRC/bmf.h (52, 19)
'''  Org: [l_int32 baseline3]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property baseline3 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.baseline3
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max height of line of chars
'''  Loc: SRC/bmf.h (53, 19)
'''  Org: [l_int32 lineheight]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property lineheight as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.lineheight
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pixel dist between char bitmaps
'''  Loc: SRC/bmf.h (54, 19)
'''  Org: [l_int32 kernwidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property kernwidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.kernwidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pixel dist between word bitmaps
'''  Loc: SRC/bmf.h (55, 19)
'''  Org: [l_int32 spacewidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property spacewidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.spacewidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: extra vertical space between text lines
'''  Loc: SRC/bmf.h (56, 19)
'''  Org: [l_int32 vertlinesep]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property vertlinesep as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.vertlinesep
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: table mapping ascii --> font index
'''  Loc: SRC/bmf.h (57, 19)
'''  Org: [l_int32 * fonttab]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property fonttab as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.fonttab <> IntPtr.Zero Then 
	Dim _fonttab(1 -1) as Integer
	Marshal.Copy(Values.fonttab, _fonttab, 0, _fonttab.Length)
	Return _fonttab
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: table mapping ascii --> baseline offset
'''  Loc: SRC/bmf.h (58, 19)
'''  Org: [l_int32 * baselinetab]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property baselinetab as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.baselinetab <> IntPtr.Zero Then 
	Dim _baselinetab(1 -1) as Integer
	Marshal.Copy(Values.baselinetab, _baselinetab, 0, _baselinetab.Length)
	Return _baselinetab
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: table mapping ascii --> char width
'''  Loc: SRC/bmf.h (59, 19)
'''  Org: [l_int32 * widthtab]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property widthtab as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.widthtab <> IntPtr.Zero Then 
	Dim _widthtab(1 -1) as Integer
	Marshal.Copy(Values.widthtab, _widthtab, 0, _widthtab.Length)
	Return _widthtab
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Bmf
		public pixa as IntPtr
		public size as Integer
		public directory as IntPtr
		public baseline1 as Integer
		public baseline2 as Integer
		public baseline3 as Integer
		public lineheight as Integer
		public kernwidth as Integer
		public spacewidth as Integer
		public vertlinesep as Integer
		public fonttab as IntPtr
		public baselinetab as IntPtr
		public widthtab as IntPtr
	End Class
End Class


#End Region
#Region "SRC/ccbord.h"
'  SRC/ccbord.h (91, 8)
'  CCBord contains:
Public Class CCBord
	Property Pointer as IntPtr
	Private Values as new Marshal_CCBord



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: component bitmap (min size)
'''  Loc: SRC/ccbord.h (93, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct |
'''  </summary>
ReadOnly property pix as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: regions of each closed curve
'''  Loc: SRC/ccbord.h (94, 26)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct |
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: initial border pixel locations
'''  Loc: SRC/ccbord.h (95, 26)
'''  Org: [struct Pta * start]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property start as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.start <> IntPtr.Zero Then 
		Return New Pta(Values.start)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of handles start at 1
'''  Loc: SRC/ccbord.h (96, 26)
'''  Org: [l_int32 refcount]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refcount as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptaa of chain pixels (local)
'''  Loc: SRC/ccbord.h (97, 26)
'''  Org: [struct Ptaa * local]
'''  Msh: struct Ptaa * | 2:Struct |
'''  </summary>
ReadOnly property local as Ptaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.local <> IntPtr.Zero Then 
		Return New Ptaa(Values.local)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptaa of chain pixels (global)
'''  Loc: SRC/ccbord.h (98, 26)
'''  Org: [struct Ptaa * global]
'''  Msh: struct Ptaa * | 2:Struct |
'''  </summary>
ReadOnly property _global_ as Ptaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values._global_ <> IntPtr.Zero Then 
		Return New Ptaa(Values._global_)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: numaa of chain code (step dir)
'''  Loc: SRC/ccbord.h (99, 26)
'''  Org: [struct Numaa * step]
'''  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
'''  </summary>
ReadOnly property _step_ as Numaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values._step_ <> IntPtr.Zero Then 
		Return New Numaa(Values._step_)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pta of single chain (local)
'''  Loc: SRC/ccbord.h (100, 26)
'''  Org: [struct Pta * splocal]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property splocal as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.splocal <> IntPtr.Zero Then 
		Return New Pta(Values.splocal)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pta of single chain (global)
'''  Loc: SRC/ccbord.h (101, 26)
'''  Org: [struct Pta * spglobal]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property spglobal as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.spglobal <> IntPtr.Zero Then 
		Return New Pta(Values.spglobal)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_CCBord
		public pix as IntPtr
		public boxa as IntPtr
		public start as IntPtr
		public refcount as Integer
		public local as IntPtr
		public _global_ as IntPtr
		public _step_ as IntPtr
		public splocal as IntPtr
		public spglobal as IntPtr
	End Class
End Class


'  SRC/ccbord.h (106, 8)
'  Array of CCBord
Public Class CCBorda
	Property Pointer as IntPtr
	Private Values as new Marshal_CCBorda



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: input pix (may be null)
'''  Loc: SRC/ccbord.h (108, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct |
'''  </summary>
ReadOnly property pix as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: width of pix
'''  Loc: SRC/ccbord.h (109, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height of pix
'''  Loc: SRC/ccbord.h (110, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of ccbord in ptr array
'''  Loc: SRC/ccbord.h (111, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of ccbord ptrs allocated
'''  Loc: SRC/ccbord.h (112, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ccb ptr array
'''  Loc: SRC/ccbord.h (113, 26)
'''  Org: [struct CCBord ** ccb]
'''  Msh: struct CCBord ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: CCBord = CCBord
'''  </summary>
ReadOnly property ccb as List (of CCBord)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.ccb <> IntPtr.Zero Then
		Dim LST_ccb As New List(Of CCBord)
		Dim ARR_ccb(values.n - 1) As IntPtr
		Marshal.Copy(Values.ccb, ARR_ccb, 0, values.n)
		For Each Entry In ARR_ccb
			LST_ccb.Add(New CCBord(Entry))
		Next
Return LST_ccb
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_CCBorda
		public pix as IntPtr
		public w as Integer
		public h as Integer
		public n as Integer
		public nalloc as Integer
		public ccb as IntPtr
	End Class
End Class


#End Region
#Region "SRC/dewarp.h"
'  SRC/dewarp.h (113, 8)
'  Data structure to hold a number of Dewarp
Public Class L_Dewarpa
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Dewarpa



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of dewarp ptr array
'''  Loc: SRC/dewarp.h (115, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum page number in array
'''  Loc: SRC/dewarp.h (116, 24)
'''  Org: [l_int32 maxpage]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxpage as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxpage
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of ptrs to page dewarp
'''  Loc: SRC/dewarp.h (117, 24)
'''  Org: [struct L_Dewarp ** dewarp]
'''  Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
'''  </summary>
ReadOnly property dewarp as List (of L_Dewarp)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.dewarp <> IntPtr.Zero Then
		Dim LST_dewarp As New List(Of L_Dewarp)
		Dim ARR_dewarp(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.dewarp, ARR_dewarp, 0, values.nalloc)
		For Each Entry In ARR_dewarp
			LST_dewarp.Add(New L_Dewarp(Entry))
		Next
Return LST_dewarp
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of ptrs to cached dewarps
'''  Loc: SRC/dewarp.h (118, 24)
'''  Org: [struct L_Dewarp ** dewarpcache]
'''  Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
'''  </summary>
ReadOnly property dewarpcache as List (of L_Dewarp)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.dewarpcache <> IntPtr.Zero Then
		Dim LST_dewarpcache As New List(Of L_Dewarp)
		Dim ARR_dewarpcache(values.nalloc - 1) As IntPtr
		Marshal.Copy(Values.dewarpcache, ARR_dewarpcache, 0, values.nalloc)
		For Each Entry In ARR_dewarpcache
			LST_dewarpcache.Add(New L_Dewarp(Entry))
		Next
Return LST_dewarpcache
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: list of page numbers for pages
'''  Loc: SRC/dewarp.h (119, 24)
'''  Org: [struct Numa * namodels]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property namodels as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.namodels <> IntPtr.Zero Then 
		Return New Numa(Values.namodels)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: list of page numbers with either
'''  Loc: SRC/dewarp.h (121, 24)
'''  Org: [struct Numa * napages]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property napages as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.napages <> IntPtr.Zero Then 
		Return New Numa(Values.napages)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reduction factor of input: 1 or 2
'''  Loc: SRC/dewarp.h (123, 24)
'''  Org: [l_int32 redfactor]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property redfactor as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.redfactor
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: disparity arrays sampling factor
'''  Loc: SRC/dewarp.h (124, 24)
'''  Org: [l_int32 sampling]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sampling as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sampling
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (125, 24)
'''  Org: [l_int32 minlines]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minlines as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minlines
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max distance for getting ref page
'''  Loc: SRC/dewarp.h (126, 24)
'''  Org: [l_int32 maxdist]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxdist as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxdist
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum abs line curvature,
'''  Loc: SRC/dewarp.h (127, 24)
'''  Org: [l_int32 max_linecurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_linecurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_linecurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: minimum abs diff line
'''  Loc: SRC/dewarp.h (129, 24)
'''  Org: [l_int32 min_diff_linecurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property min_diff_linecurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.min_diff_linecurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum abs diff line
'''  Loc: SRC/dewarp.h (131, 24)
'''  Org: [l_int32 max_diff_linecurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_diff_linecurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_diff_linecurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (133, 24)
'''  Org: [l_int32 max_edgeslope]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_edgeslope as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_edgeslope
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum abs left or right edge
'''  Loc: SRC/dewarp.h (135, 24)
'''  Org: [l_int32 max_edgecurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_edgecurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_edgecurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: maximum abs diff left-right
'''  Loc: SRC/dewarp.h (137, 24)
'''  Org: [l_int32 max_diff_edgecurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_diff_edgecurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_diff_edgecurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: use both disparity arrays if
'''  Loc: SRC/dewarp.h (139, 24)
'''  Org: [l_int32 useboth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property useboth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.useboth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: if there are multiple columns,
'''  Loc: SRC/dewarp.h (141, 24)
'''  Org: [l_int32 check_columns]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property check_columns as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.check_columns
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: invalid models have been removed
'''  Loc: SRC/dewarp.h (144, 24)
'''  Org: [l_int32 modelsready]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property modelsready as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.modelsready
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Dewarpa
		public nalloc as Integer
		public maxpage as Integer
		public dewarp as IntPtr
		public dewarpcache as IntPtr
		public namodels as IntPtr
		public napages as IntPtr
		public redfactor as Integer
		public sampling as Integer
		public minlines as Integer
		public maxdist as Integer
		public max_linecurv as Integer
		public min_diff_linecurv as Integer
		public max_diff_linecurv as Integer
		public max_edgeslope as Integer
		public max_edgecurv as Integer
		public max_diff_edgecurv as Integer
		public useboth as Integer
		public check_columns as Integer
		public modelsready as Integer
	End Class
End Class


'  SRC/dewarp.h (151, 8)
'  Data structure for a single dewarp
Public Class L_Dewarp
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Dewarp



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: ptr to parent (not owned)
'''  Loc: SRC/dewarp.h (153, 24)
'''  Org: [struct L_Dewarpa * dewa]
'''  Msh: struct L_Dewarpa * | 2:Struct |  | Typedef: L_Dewarpa = L_Dewarpa
'''  </summary>
ReadOnly property dewa as L_Dewarpa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.dewa <> IntPtr.Zero Then 
		Return New L_Dewarpa(Values.dewa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: source pix, 1 bpp
'''  Loc: SRC/dewarp.h (154, 24)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct |
'''  </summary>
ReadOnly property pixs as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sampled vert disparity array
'''  Loc: SRC/dewarp.h (155, 24)
'''  Org: [struct FPix * sampvdispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property sampvdispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.sampvdispar <> IntPtr.Zero Then 
		Return New FPix(Values.sampvdispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sampled horiz disparity array
'''  Loc: SRC/dewarp.h (156, 24)
'''  Org: [struct FPix * samphdispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property samphdispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.samphdispar <> IntPtr.Zero Then 
		Return New FPix(Values.samphdispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sampled slope h-disparity array
'''  Loc: SRC/dewarp.h (157, 24)
'''  Org: [struct FPix * sampydispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property sampydispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.sampydispar <> IntPtr.Zero Then 
		Return New FPix(Values.sampydispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: full vert disparity array
'''  Loc: SRC/dewarp.h (158, 24)
'''  Org: [struct FPix * fullvdispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property fullvdispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.fullvdispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullvdispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: full horiz disparity array
'''  Loc: SRC/dewarp.h (159, 24)
'''  Org: [struct FPix * fullhdispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property fullhdispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.fullhdispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullhdispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: full slope h-disparity array
'''  Loc: SRC/dewarp.h (160, 24)
'''  Org: [struct FPix * fullydispar]
'''  Msh: struct FPix * | 2:Struct |
'''  </summary>
ReadOnly property fullydispar as FPix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.fullydispar <> IntPtr.Zero Then 
		Return New FPix(Values.fullydispar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sorted y val of midpoint each line
'''  Loc: SRC/dewarp.h (161, 24)
'''  Org: [struct Numa * namidys]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property namidys as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.namidys <> IntPtr.Zero Then 
		Return New Numa(Values.namidys)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sorted curvature of each line
'''  Loc: SRC/dewarp.h (162, 24)
'''  Org: [struct Numa * nacurves]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nacurves as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nacurves <> IntPtr.Zero Then 
		Return New Numa(Values.nacurves)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: width of source image
'''  Loc: SRC/dewarp.h (163, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height of source image
'''  Loc: SRC/dewarp.h (164, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: page number important for reuse
'''  Loc: SRC/dewarp.h (165, 24)
'''  Org: [l_int32 pageno]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property pageno as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.pageno
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sampling factor of disparity arrays
'''  Loc: SRC/dewarp.h (166, 24)
'''  Org: [l_int32 sampling]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sampling as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sampling
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reduction factor of pixs: 1 or 2
'''  Loc: SRC/dewarp.h (167, 24)
'''  Org: [l_int32 redfactor]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property redfactor as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.redfactor
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min number of long lines required
'''  Loc: SRC/dewarp.h (168, 24)
'''  Org: [l_int32 minlines]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minlines as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minlines
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of long lines found
'''  Loc: SRC/dewarp.h (169, 24)
'''  Org: [l_int32 nlines]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nlines as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nlines
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min line curvature in micro-units
'''  Loc: SRC/dewarp.h (170, 24)
'''  Org: [l_int32 mincurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property mincurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.mincurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max line curvature in micro-units
'''  Loc: SRC/dewarp.h (171, 24)
'''  Org: [l_int32 maxcurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxcurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxcurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: left edge slope in milli-units
'''  Loc: SRC/dewarp.h (172, 24)
'''  Org: [l_int32 leftslope]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property leftslope as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.leftslope
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: right edge slope in milli-units
'''  Loc: SRC/dewarp.h (173, 24)
'''  Org: [l_int32 rightslope]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rightslope as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rightslope
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: left edge curvature in micro-units
'''  Loc: SRC/dewarp.h (174, 24)
'''  Org: [l_int32 leftcurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property leftcurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.leftcurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: right edge curvature in micro-units
'''  Loc: SRC/dewarp.h (175, 24)
'''  Org: [l_int32 rightcurv]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rightcurv as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rightcurv
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of sampling pts in x-dir
'''  Loc: SRC/dewarp.h (176, 24)
'''  Org: [l_int32 nx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of sampling pts in y-dir
'''  Loc: SRC/dewarp.h (177, 24)
'''  Org: [l_int32 ny]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ny as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ny
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 0 if normal 1 if has a refpage
'''  Loc: SRC/dewarp.h (178, 24)
'''  Org: [l_int32 hasref]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property hasref as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.hasref
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: page with disparity model to use
'''  Loc: SRC/dewarp.h (179, 24)
'''  Org: [l_int32 refpage]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property refpage as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refpage
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sets to 1 if vert disparity builds
'''  Loc: SRC/dewarp.h (180, 24)
'''  Org: [l_int32 vsuccess]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property vsuccess as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.vsuccess
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sets to 1 if horiz disparity builds
'''  Loc: SRC/dewarp.h (181, 24)
'''  Org: [l_int32 hsuccess]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property hsuccess as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.hsuccess
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sets to 1 if slope disparity builds
'''  Loc: SRC/dewarp.h (182, 24)
'''  Org: [l_int32 ysuccess]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ysuccess as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ysuccess
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sets to 1 if valid vert disparity
'''  Loc: SRC/dewarp.h (183, 24)
'''  Org: [l_int32 vvalid]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property vvalid as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.vvalid
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sets to 1 if valid horiz disparity
'''  Loc: SRC/dewarp.h (184, 24)
'''  Org: [l_int32 hvalid]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property hvalid as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.hvalid
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: if 1, skip horiz disparity
'''  Loc: SRC/dewarp.h (185, 24)
'''  Org: [l_int32 skip_horiz]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property skip_horiz as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.skip_horiz
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 if debug output requested
'''  Loc: SRC/dewarp.h (187, 24)
'''  Org: [l_int32 debug]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property debug as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.debug
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Dewarp
		public dewa as IntPtr
		public pixs as IntPtr
		public sampvdispar as IntPtr
		public samphdispar as IntPtr
		public sampydispar as IntPtr
		public fullvdispar as IntPtr
		public fullhdispar as IntPtr
		public fullydispar as IntPtr
		public namidys as IntPtr
		public nacurves as IntPtr
		public w as Integer
		public h as Integer
		public pageno as Integer
		public sampling as Integer
		public redfactor as Integer
		public minlines as Integer
		public nlines as Integer
		public mincurv as Integer
		public maxcurv as Integer
		public leftslope as Integer
		public rightslope as Integer
		public leftcurv as Integer
		public rightcurv as Integer
		public nx as Integer
		public ny as Integer
		public hasref as Integer
		public refpage as Integer
		public vsuccess as Integer
		public hsuccess as Integer
		public ysuccess as Integer
		public vvalid as Integer
		public hvalid as Integer
		public skip_horiz as Integer
		public debug as Integer
	End Class
End Class


#End Region
#Region "SRC/gplot.h"
'  SRC/gplot.h (75, 8)
'  Data structure for generating gnuplot files
Public Class GPlot
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_GPlot

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.GPlotDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: for cmd, data, output
'''  Loc: SRC/gplot.h (77, 20)
'''  Org: [char * rootname]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property rootname as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.rootname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.rootname)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: command file name
'''  Loc: SRC/gplot.h (78, 20)
'''  Org: [char * cmdname]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property cmdname as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.cmdname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmdname)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: command file contents
'''  Loc: SRC/gplot.h (79, 20)
'''  Org: [struct Sarray * cmddata]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property cmddata as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.cmddata <> IntPtr.Zero Then 
		Return New Sarray(Values.cmddata)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: data file names
'''  Loc: SRC/gplot.h (80, 20)
'''  Org: [struct Sarray * datanames]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property datanames as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.datanames <> IntPtr.Zero Then 
		Return New Sarray(Values.datanames)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: plot data (1 string/file)
'''  Loc: SRC/gplot.h (81, 20)
'''  Org: [struct Sarray * plotdata]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property plotdata as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.plotdata <> IntPtr.Zero Then 
		Return New Sarray(Values.plotdata)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: title for each individual plot
'''  Loc: SRC/gplot.h (82, 20)
'''  Org: [struct Sarray * plottitles]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property plottitles as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.plottitles <> IntPtr.Zero Then 
		Return New Sarray(Values.plottitles)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: plot style for individual plots
'''  Loc: SRC/gplot.h (83, 20)
'''  Org: [struct Numa * plotstyles]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property plotstyles as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.plotstyles <> IntPtr.Zero Then 
		Return New Numa(Values.plotstyles)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: current number of plots
'''  Loc: SRC/gplot.h (84, 20)
'''  Org: [l_int32 nplots]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nplots as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nplots
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: output file name
'''  Loc: SRC/gplot.h (85, 20)
'''  Org: [char * outname]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property outname as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.outname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.outname)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: GPLOT_OUTPUT values
'''  Loc: SRC/gplot.h (86, 20)
'''  Org: [l_int32 outformat]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property outformat as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.outformat
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: GPLOT_SCALING values
'''  Loc: SRC/gplot.h (87, 20)
'''  Org: [l_int32 scaling]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property scaling as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.scaling
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: optional
'''  Loc: SRC/gplot.h (88, 20)
'''  Org: [char * title]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property title as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.title <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.title)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: optional x axis label
'''  Loc: SRC/gplot.h (89, 20)
'''  Org: [char * xlabel]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property xlabel as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.xlabel <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.xlabel)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: optional y axis label
'''  Loc: SRC/gplot.h (90, 20)
'''  Org: [char * ylabel]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property ylabel as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.ylabel <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.ylabel)
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_GPlot
		public rootname as IntPtr
		public cmdname as IntPtr
		public cmddata as IntPtr
		public datanames as IntPtr
		public plotdata as IntPtr
		public plottitles as IntPtr
		public plotstyles as IntPtr
		public nplots as Integer
		public outname as IntPtr
		public outformat as Integer
		public scaling as Integer
		public title as IntPtr
		public xlabel as IntPtr
		public ylabel as IntPtr
	End Class
End Class


#End Region
#Region "SRC/imageio.h"
'  SRC/imageio.h (166, 8)
'  Compressed image data
Public Class L_Compressed_Data
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Compressed_Data



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: encoding type: L_JPEG_ENCODE, etc
'''  Loc: SRC/imageio.h (168, 24)
'''  Org: [l_int32 type]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property type as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.type
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: gzipped raster data
'''  Loc: SRC/imageio.h (169, 24)
'''  Org: [l_uint8 * datacomp]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property datacomp as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.datacomp <> IntPtr.Zero Then 
	Dim _datacomp(1 -1) as Byte
	Marshal.Copy(Values.datacomp, _datacomp, 0, _datacomp.Length)
	Return _datacomp
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of compressed bytes
'''  Loc: SRC/imageio.h (170, 24)
'''  Org: [size_t nbytescomp]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property nbytescomp as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nbytescomp
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ascii85-encoded gzipped raster data
'''  Loc: SRC/imageio.h (171, 24)
'''  Org: [char * data85]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property data85 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data85 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.data85)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of ascii85 encoded bytes
'''  Loc: SRC/imageio.h (172, 24)
'''  Org: [size_t nbytes85]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property nbytes85 as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nbytes85
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ascii85-encoded uncompressed cmap
'''  Loc: SRC/imageio.h (173, 24)
'''  Org: [char * cmapdata85]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property cmapdata85 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.cmapdata85 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmapdata85)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: hex pdf array for the cmap
'''  Loc: SRC/imageio.h (174, 24)
'''  Org: [char * cmapdatahex]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property cmapdatahex as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.cmapdatahex <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.cmapdatahex)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of colors in cmap
'''  Loc: SRC/imageio.h (175, 24)
'''  Org: [l_int32 ncolors]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ncolors as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ncolors
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image width
'''  Loc: SRC/imageio.h (176, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image height
'''  Loc: SRC/imageio.h (177, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: bits/sample typ. 1, 2, 4 or 8
'''  Loc: SRC/imageio.h (178, 24)
'''  Org: [l_int32 bps]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bps as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bps
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: samples/pixel typ. 1 or 3
'''  Loc: SRC/imageio.h (179, 24)
'''  Org: [l_int32 spp]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property spp as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.spp
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: tiff g4 photometry
'''  Loc: SRC/imageio.h (180, 24)
'''  Org: [l_int32 minisblack]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minisblack as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minisblack
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: flate data has PNG predictors
'''  Loc: SRC/imageio.h (181, 24)
'''  Org: [l_int32 predictor]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property predictor as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.predictor
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of uncompressed raster bytes
'''  Loc: SRC/imageio.h (182, 24)
'''  Org: [size_t nbytes]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property nbytes as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nbytes
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: resolution (ppi)
'''  Loc: SRC/imageio.h (183, 24)
'''  Org: [l_int32 res]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property res as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.res
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Compressed_Data
		public type as Integer
		public datacomp as IntPtr
		public nbytescomp as UInteger
		public data85 as IntPtr
		public nbytes85 as UInteger
		public cmapdata85 as IntPtr
		public cmapdatahex as IntPtr
		public ncolors as Integer
		public w as Integer
		public h as Integer
		public bps as Integer
		public spp as Integer
		public minisblack as Integer
		public predictor as Integer
		public nbytes as UInteger
		public res as Integer
	End Class
End Class


'  SRC/imageio.h (211, 8)
'  Intermediate pdf generation data
Public Class L_Pdf_Data
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Pdf_Data



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: optional title for pdf
'''  Loc: SRC/imageio.h (213, 24)
'''  Org: [char * title]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property title as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.title <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.title)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of images
'''  Loc: SRC/imageio.h (214, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of colormaps
'''  Loc: SRC/imageio.h (215, 24)
'''  Org: [l_int32 ncmap]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ncmap as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ncmap
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of compressed image data
'''  Loc: SRC/imageio.h (216, 24)
'''  Org: [struct L_Ptra * cida]
'''  Msh: struct L_Ptra * | 2:Struct |  | Typedef: L_Ptra = L_Ptra
'''  </summary>
ReadOnly property cida as L_Ptra
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.cida <> IntPtr.Zero Then 
		Return New L_Ptra(Values.cida)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: %PDF-1.2 id string
'''  Loc: SRC/imageio.h (217, 24)
'''  Org: [char * id]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property id as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.id <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.id)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: catalog string
'''  Loc: SRC/imageio.h (218, 24)
'''  Org: [char * obj1]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property obj1 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.obj1 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj1)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: metadata string
'''  Loc: SRC/imageio.h (219, 24)
'''  Org: [char * obj2]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property obj2 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.obj2 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj2)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pages string
'''  Loc: SRC/imageio.h (220, 24)
'''  Org: [char * obj3]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property obj3 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.obj3 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj3)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: page string (variable data)
'''  Loc: SRC/imageio.h (221, 24)
'''  Org: [char * obj4]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property obj4 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.obj4 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj4)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: content string (variable data)
'''  Loc: SRC/imageio.h (222, 24)
'''  Org: [char * obj5]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property obj5 as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.obj5 <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.obj5)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: post-binary-stream string
'''  Loc: SRC/imageio.h (223, 24)
'''  Org: [char * poststream]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property poststream as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.poststream <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.poststream)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: trailer string (variable data)
'''  Loc: SRC/imageio.h (224, 24)
'''  Org: [char * trailer]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property trailer as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.trailer <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.trailer)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: store (xpt, ypt) array
'''  Loc: SRC/imageio.h (225, 24)
'''  Org: [struct Pta * xy]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property xy as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.xy <> IntPtr.Zero Then 
		Return New Pta(Values.xy)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: store (wpt, hpt) array
'''  Loc: SRC/imageio.h (226, 24)
'''  Org: [struct Pta * wh]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property wh as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.wh <> IntPtr.Zero Then 
		Return New Pta(Values.wh)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: bounding region for all images
'''  Loc: SRC/imageio.h (227, 24)
'''  Org: [struct Box * mediabox]
'''  Msh: struct Box * | 2:Struct |
'''  </summary>
ReadOnly property mediabox as Box
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.mediabox <> IntPtr.Zero Then 
		Return New Box(Values.mediabox)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pre-binary-stream xobject strings
'''  Loc: SRC/imageio.h (228, 24)
'''  Org: [struct Sarray * saprex]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property saprex as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.saprex <> IntPtr.Zero Then 
		Return New Sarray(Values.saprex)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: colormap pdf object strings
'''  Loc: SRC/imageio.h (229, 24)
'''  Org: [struct Sarray * sacmap]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property sacmap as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.sacmap <> IntPtr.Zero Then 
		Return New Sarray(Values.sacmap)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sizes of each pdf string object
'''  Loc: SRC/imageio.h (230, 24)
'''  Org: [struct L_Dna * objsize]
'''  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property objsize as L_Dna
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.objsize <> IntPtr.Zero Then 
		Return New L_Dna(Values.objsize)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: location of each pdf string object
'''  Loc: SRC/imageio.h (231, 24)
'''  Org: [struct L_Dna * objloc]
'''  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property objloc as L_Dna
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.objloc <> IntPtr.Zero Then 
		Return New L_Dna(Values.objloc)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: location of xref
'''  Loc: SRC/imageio.h (232, 24)
'''  Org: [l_int32 xrefloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xrefloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xrefloc
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Pdf_Data
		public title as IntPtr
		public n as Integer
		public ncmap as Integer
		public cida as IntPtr
		public id as IntPtr
		public obj1 as IntPtr
		public obj2 as IntPtr
		public obj3 as IntPtr
		public obj4 as IntPtr
		public obj5 as IntPtr
		public poststream as IntPtr
		public trailer as IntPtr
		public xy as IntPtr
		public wh as IntPtr
		public mediabox as IntPtr
		public saprex as IntPtr
		public sacmap as IntPtr
		public objsize as IntPtr
		public objloc as IntPtr
		public xrefloc as Integer
	End Class
End Class


#End Region
#Region "SRC/jbclass.h"
'  SRC/jbclass.h (47, 8)
'  The JbClasser struct holds all the data accumulated during the classification process that can be used for a compressed jbig2-type representation of a set of images. This is created in an initialization process and added to as the selected components on each successive page are analyzed.
Public Class JbClasser
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_JbClasser

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.JbClasserDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: input page image file names
'''  Loc: SRC/jbclass.h (49, 22)
'''  Org: [struct Sarray * safiles]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property safiles as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.safiles <> IntPtr.Zero Then 
		Return New Sarray(Values.safiles)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: JB_RANKHAUS, JB_CORRELATION
'''  Loc: SRC/jbclass.h (50, 22)
'''  Org: [l_int32 method]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property method as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.method
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: JB_CONN_COMPS, JB_CHARACTERS or
'''  Loc: SRC/jbclass.h (51, 22)
'''  Org: [l_int32 components]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property components as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.components
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max component width allowed
'''  Loc: SRC/jbclass.h (53, 22)
'''  Org: [l_int32 maxwidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxwidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxwidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max component height allowed
'''  Loc: SRC/jbclass.h (54, 22)
'''  Org: [l_int32 maxheight]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxheight as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxheight
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of pages already processed
'''  Loc: SRC/jbclass.h (55, 22)
'''  Org: [l_int32 npages]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property npages as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.npages
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number components already processed
'''  Loc: SRC/jbclass.h (56, 22)
'''  Org: [l_int32 baseindex]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property baseindex as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.baseindex
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of components on each page
'''  Loc: SRC/jbclass.h (58, 22)
'''  Org: [struct Numa * nacomps]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nacomps as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nacomps <> IntPtr.Zero Then 
		Return New Numa(Values.nacomps)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of square struct elem for haus
'''  Loc: SRC/jbclass.h (59, 22)
'''  Org: [l_int32 sizehaus]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sizehaus as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sizehaus
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: rank val of haus match, each way
'''  Loc: SRC/jbclass.h (60, 22)
'''  Org: [l_float32 rankhaus]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property rankhaus as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rankhaus
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: thresh value for correlation score
'''  Loc: SRC/jbclass.h (61, 22)
'''  Org: [l_float32 thresh]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property thresh as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.thresh
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: corrects thresh value for heaver
'''  Loc: SRC/jbclass.h (62, 22)
'''  Org: [l_float32 weightfactor]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property weightfactor as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.weightfactor
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: w * h of each template, without
'''  Loc: SRC/jbclass.h (64, 22)
'''  Org: [struct Numa * naarea]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naarea as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naarea <> IntPtr.Zero Then 
		Return New Numa(Values.naarea)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max width of original src images
'''  Loc: SRC/jbclass.h (66, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max height of original src images
'''  Loc: SRC/jbclass.h (67, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: current number of classes
'''  Loc: SRC/jbclass.h (68, 22)
'''  Org: [l_int32 nclass]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nclass as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nclass
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: If zero, pixaa isn't filled
'''  Loc: SRC/jbclass.h (69, 22)
'''  Org: [l_int32 keep_pixaa]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property keep_pixaa as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.keep_pixaa
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: instances for each class unbordered
'''  Loc: SRC/jbclass.h (70, 22)
'''  Org: [struct Pixaa * pixaa]
'''  Msh: struct Pixaa * | 2:Struct |
'''  </summary>
ReadOnly property pixaa as Pixaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixaa <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: templates for each class bordered
'''  Loc: SRC/jbclass.h (71, 22)
'''  Org: [struct Pixa * pixat]
'''  Msh: struct Pixa * | 2:Struct |
'''  </summary>
ReadOnly property pixat as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixat <> IntPtr.Zero Then 
		Return New Pixa(Values.pixat)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: templates for each class bordered
'''  Loc: SRC/jbclass.h (73, 22)
'''  Org: [struct Pixa * pixatd]
'''  Msh: struct Pixa * | 2:Struct |
'''  </summary>
ReadOnly property pixatd as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixatd <> IntPtr.Zero Then 
		Return New Pixa(Values.pixatd)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Hash table to find templates by size
'''  Loc: SRC/jbclass.h (75, 23)
'''  Org: [struct L_DnaHash * dahash]
'''  Msh: struct L_DnaHash * | 2:Struct |  | Typedef: L_DnaHash = L_DnaHash
'''  </summary>
ReadOnly property dahash as L_DnaHash
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.dahash <> IntPtr.Zero Then 
		Return New L_DnaHash(Values.dahash)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: fg areas of undilated templates
'''  Loc: SRC/jbclass.h (76, 22)
'''  Org: [struct Numa * nafgt]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nafgt as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nafgt <> IntPtr.Zero Then 
		Return New Numa(Values.nafgt)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of all bordered cc
'''  Loc: SRC/jbclass.h (78, 22)
'''  Org: [struct Pta * ptac]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property ptac as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptac <> IntPtr.Zero Then 
		Return New Pta(Values.ptac)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of all bordered template cc
'''  Loc: SRC/jbclass.h (79, 22)
'''  Org: [struct Pta * ptact]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property ptact as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptact <> IntPtr.Zero Then 
		Return New Pta(Values.ptact)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (80, 22)
'''  Org: [struct Numa * naclass]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naclass as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naclass <> IntPtr.Zero Then 
		Return New Numa(Values.naclass)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (81, 22)
'''  Org: [struct Numa * napage]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property napage as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.napage <> IntPtr.Zero Then 
		Return New Numa(Values.napage)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (82, 22)
'''  Org: [struct Pta * ptaul]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property ptaul as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptaul <> IntPtr.Zero Then 
		Return New Pta(Values.ptaul)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: similar to ptaul, but for LL corners
'''  Loc: SRC/jbclass.h (85, 22)
'''  Org: [struct Pta * ptall]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property ptall as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptall <> IntPtr.Zero Then 
		Return New Pta(Values.ptall)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_JbClasser
		public safiles as IntPtr
		public method as Integer
		public components as Integer
		public maxwidth as Integer
		public maxheight as Integer
		public npages as Integer
		public baseindex as Integer
		public nacomps as IntPtr
		public sizehaus as Integer
		public rankhaus as Single
		public thresh as Single
		public weightfactor as Single
		public naarea as IntPtr
		public w as Integer
		public h as Integer
		public nclass as Integer
		public keep_pixaa as Integer
		public pixaa as IntPtr
		public pixat as IntPtr
		public pixatd as IntPtr
		public dahash as IntPtr
		public nafgt as IntPtr
		public ptac as IntPtr
		public ptact as IntPtr
		public naclass as IntPtr
		public napage as IntPtr
		public ptaul as IntPtr
		public ptall as IntPtr
	End Class
End Class


'  SRC/jbclass.h (104, 8)
'  The JbData struct holds all the data required for the compressed jbig-type representation of a set of images. The data can be written to file, read back, and used to regenerate an approximate version of the original, which differs in two ways from the original: (1) It uses a template image for each c.c. instead of the original instance, for each occurrence on each page. (2) It discards components with either a height or width larger than the maximuma, given here by the lattice dimensions used for storing the templates.
Public Class JbData
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_JbData

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.JbDataDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: template composite for all classes
'''  Loc: SRC/jbclass.h (106, 22)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct |
'''  </summary>
ReadOnly property pix as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of pages
'''  Loc: SRC/jbclass.h (107, 22)
'''  Org: [l_int32 npages]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property npages as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.npages
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max width of original page images
'''  Loc: SRC/jbclass.h (108, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max height of original page images
'''  Loc: SRC/jbclass.h (109, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of classes
'''  Loc: SRC/jbclass.h (110, 22)
'''  Org: [l_int32 nclass]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nclass as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nclass
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: lattice width for template composite
'''  Loc: SRC/jbclass.h (111, 22)
'''  Org: [l_int32 latticew]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property latticew as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.latticew
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: lattice height for template composite
'''  Loc: SRC/jbclass.h (112, 22)
'''  Org: [l_int32 latticeh]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property latticeh as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.latticeh
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of class ids for each component
'''  Loc: SRC/jbclass.h (113, 22)
'''  Org: [struct Numa * naclass]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naclass as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naclass <> IntPtr.Zero Then 
		Return New Numa(Values.naclass)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of page nums for each component
'''  Loc: SRC/jbclass.h (114, 22)
'''  Org: [struct Numa * napage]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property napage as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.napage <> IntPtr.Zero Then 
		Return New Numa(Values.napage)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of UL corners at which the
'''  Loc: SRC/jbclass.h (115, 22)
'''  Org: [struct Pta * ptaul]
'''  Msh: struct Pta * | 2:Struct |
'''  </summary>
ReadOnly property ptaul as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptaul <> IntPtr.Zero Then 
		Return New Pta(Values.ptaul)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_JbData
		public pix as IntPtr
		public npages as Integer
		public w as Integer
		public h as Integer
		public nclass as Integer
		public latticew as Integer
		public latticeh as Integer
		public naclass as IntPtr
		public napage as IntPtr
		public ptaul as IntPtr
	End Class
End Class


#End Region
#Region "SRC/morph.h"
'  SRC/morph.h (62, 8)
'  Selection
Public Class Sel
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Sel

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.SelDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: sel height
'''  Loc: SRC/morph.h (64, 19)
'''  Org: [l_int32 sy]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sy as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sy
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sel width
'''  Loc: SRC/morph.h (65, 19)
'''  Org: [l_int32 sx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y location of sel origin
'''  Loc: SRC/morph.h (66, 19)
'''  Org: [l_int32 cy]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property cy as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.cy
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x location of sel origin
'''  Loc: SRC/morph.h (67, 19)
'''  Org: [l_int32 cx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property cx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.cx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: {0,1,2} data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (68, 19)
'''  Org: [l_int32 ** data]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
'''  </summary>
ReadOnly property data as List (of Integer())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(sy - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(sx - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: used to find sel by name
'''  Loc: SRC/morph.h (69, 19)
'''  Org: [char * name]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property name as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.name <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.name)
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Sel
		public sy as Integer
		public sx as Integer
		public cy as Integer
		public cx as Integer
		public data as IntPtr
		public name as IntPtr
	End Class
End Class


'  SRC/morph.h (74, 8)
'  Array of Sel
Public Class Sela
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Sela

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.SelaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of sel actually stored
'''  Loc: SRC/morph.h (76, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of allocated ptr array
'''  Loc: SRC/morph.h (77, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: sel ptr array
'''  Loc: SRC/morph.h (78, 22)
'''  Org: [struct Sel ** sel]
'''  Msh: struct Sel ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Sel = Sel
'''  </summary>
ReadOnly property sel as List (of Sel)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.sel <> IntPtr.Zero Then
		Dim LST_sel As New List(Of Sel)
		Dim ARR_sel(values.n - 1) As IntPtr
		Marshal.Copy(Values.sel, ARR_sel, 0, values.n)
		For Each Entry In ARR_sel
			LST_sel.Add(New Sel(Entry))
		Next
Return LST_sel
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Sela
		public n as Integer
		public nalloc as Integer
		public sel as IntPtr
	End Class
End Class


'  SRC/morph.h (89, 8)
'  Kernel
Public Class L_Kernel
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Kernel



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: kernel height
'''  Loc: SRC/morph.h (91, 19)
'''  Org: [l_int32 sy]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sy as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sy
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: kernel width
'''  Loc: SRC/morph.h (92, 19)
'''  Org: [l_int32 sx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y location of kernel origin
'''  Loc: SRC/morph.h (93, 19)
'''  Org: [l_int32 cy]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property cy as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.cy
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x location of kernel origin
'''  Loc: SRC/morph.h (94, 19)
'''  Org: [l_int32 cx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property cx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.cx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: data[i][j] in [row][col] order
'''  Loc: SRC/morph.h (95, 19)
'''  Org: [l_float32 ** data]
'''  Msh: l_float32 ** | 3:Float | List (of Single())
'''  </summary>
ReadOnly property data as List(Of Single())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(1 - 1) As Single
Dim _DataFin As New List(Of Single())
Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Single
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Kernel
		public sy as Integer
		public sx as Integer
		public cy as Integer
		public cx as Integer
		public data as IntPtr
	End Class
End Class


#End Region
#Region "SRC/pix.h"
'  SRC/pix.h (134, 8)
'  Basic Pix
Public Class Pix
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Pix

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: width in pixels
'''  Loc: SRC/pix.h (136, 26)
'''  Org: [l_uint32 w]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property w as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height in pixels
'''  Loc: SRC/pix.h (137, 26)
'''  Org: [l_uint32 h]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property h as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: depth in bits (bpp)
'''  Loc: SRC/pix.h (138, 26)
'''  Org: [l_uint32 d]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property d as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.d
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of samples per pixel
'''  Loc: SRC/pix.h (139, 26)
'''  Org: [l_uint32 spp]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property spp as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.spp
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 32-bit words/line
'''  Loc: SRC/pix.h (140, 26)
'''  Org: [l_uint32 wpl]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property wpl as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.wpl
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (141, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (142, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (144, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: input file format, IFF_*
'''  Loc: SRC/pix.h (146, 26)
'''  Org: [l_int32 informat]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property informat as IFF
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.informat
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: special instructions for I/O, etc
'''  Loc: SRC/pix.h (147, 26)
'''  Org: [l_int32 special]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property special as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.special
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: text string associated with pix
'''  Loc: SRC/pix.h (148, 26)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property text as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: colormap (may be null)
'''  Loc: SRC/pix.h (149, 26)
'''  Org: [struct PixColormap * colormap]
'''  Msh: struct PixColormap * | 2:Struct |
'''  </summary>
ReadOnly property colormap as PixColormap
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.colormap <> IntPtr.Zero Then 
		Return New PixColormap(Values.colormap)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the image data
'''  Loc: SRC/pix.h (150, 26)
'''  Org: [l_uint32 * data]
'''  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
'''  </summary>
ReadOnly property data as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _data((w * h * (d/8)) -1) as Byte
Marshal.Copy(Values.data, _data, 0, _data.Length)
Return _data
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Pix
		public w as UInteger
		public h as UInteger
		public d as UInteger
		public spp as UInteger
		public wpl as UInteger
		public refcount as UInteger
		public xres as Integer
		public yres as Integer
		public informat as Integer
		public special as Integer
		public text as IntPtr
		public colormap as IntPtr
		public data as IntPtr
	End Class
End Class


'  SRC/pix.h (155, 8)
'  Colormap of a Pix
Public Class PixColormap
	Property Pointer as IntPtr
	Private Values as new Marshal_PixColormap



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: colormap table (array of RGBA_QUAD)
'''  Loc: SRC/pix.h (157, 22)
'''  Org: [void * array]
'''  Msh: void * | 2:Void |  ... Pointer auf Object = IntPtr
'''  </summary>
ReadOnly property array as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.array <> IntPtr.Zero Then
	Return  Values.array
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: of pix (1, 2, 4 or 8 bpp)
'''  Loc: SRC/pix.h (158, 22)
'''  Org: [l_int32 depth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property depth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.depth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of color entries allocated
'''  Loc: SRC/pix.h (159, 22)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of color entries used
'''  Loc: SRC/pix.h (160, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixColormap
		public array as IntPtr
		public depth as Integer
		public nalloc as Integer
		public n as Integer
	End Class
End Class


'  SRC/pix.h (169, 8)
'  Colormap table entry (after the BMP version). Note that the BMP format stores the colormap table exactly as it appears here, with color samples being stored sequentially, in the order (b,g,r,a).
Public Class RGBA_Quad
	Property Pointer as IntPtr
	Private Values as new Marshal_RGBA_Quad



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: blue value
'''  Loc: SRC/pix.h (171, 17)
'''  Org: [l_uint8 blue]
'''  Msh: l_uint8 | 1:UChar |
'''  </summary>
ReadOnly property blue as Byte
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.blue
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: green value
'''  Loc: SRC/pix.h (172, 17)
'''  Org: [l_uint8 green]
'''  Msh: l_uint8 | 1:UChar |
'''  </summary>
ReadOnly property green as Byte
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.green
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: red value
'''  Loc: SRC/pix.h (173, 17)
'''  Org: [l_uint8 red]
'''  Msh: l_uint8 | 1:UChar |
'''  </summary>
ReadOnly property red as Byte
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.red
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: alpha value
'''  Loc: SRC/pix.h (174, 17)
'''  Org: [l_uint8 alpha]
'''  Msh: l_uint8 | 1:UChar |
'''  </summary>
ReadOnly property alpha as Byte
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.alpha
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_RGBA_Quad
		public blue as Byte
		public green as Byte
		public red as Byte
		public alpha as Byte
	End Class
End Class


'  SRC/pix.h (454, 8)
'  Array of pix
Public Class Pixa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Pixa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of Pix in ptr array
'''  Loc: SRC/pix.h (456, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of Pix ptrs allocated
'''  Loc: SRC/pix.h (457, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (458, 25)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the array of ptrs to pix
'''  Loc: SRC/pix.h (459, 25)
'''  Org: [struct Pix ** pix]
'''  Msh: struct Pix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pix as List (of Pix)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.pix <> IntPtr.Zero Then
		Dim LST_pix As New List(Of Pix)
		Dim ARR_pix(values.n - 1) As IntPtr
		Marshal.Copy(Values.pix, ARR_pix, 0, values.n)
		For Each Entry In ARR_pix
			LST_pix.Add(New Pix(Entry))
		Next
Return LST_pix
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of boxes
'''  Loc: SRC/pix.h (460, 25)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct |
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Pixa
		public n as Integer
		public nalloc as Integer
		public refcount as UInteger
		public pix as IntPtr
		public boxa as IntPtr
	End Class
End Class


'  SRC/pix.h (465, 8)
'  Array of arrays of pix
Public Class Pixaa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Pixaa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixaaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of Pixa in ptr array
'''  Loc: SRC/pix.h (467, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of Pixa ptrs allocated
'''  Loc: SRC/pix.h (468, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of ptrs to pixa
'''  Loc: SRC/pix.h (469, 25)
'''  Org: [struct Pixa ** pixa]
'''  Msh: struct Pixa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixa as List (of Pixa)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.pixa <> IntPtr.Zero Then
		Dim LST_pixa As New List(Of Pixa)
		Dim ARR_pixa(values.n - 1) As IntPtr
		Marshal.Copy(Values.pixa, ARR_pixa, 0, values.n)
		For Each Entry In ARR_pixa
			LST_pixa.Add(New Pixa(Entry))
		Next
Return LST_pixa
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of boxes
'''  Loc: SRC/pix.h (470, 25)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct |
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Pixaa
		public n as Integer
		public nalloc as Integer
		public pixa as IntPtr
		public boxa as IntPtr
	End Class
End Class


'  SRC/pix.h (480, 8)
'  Basic rectangle
Public Class Box
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Box

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.BoxDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: left coordinate
'''  Loc: SRC/pix.h (482, 24)
'''  Org: [l_int32 x]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property x as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.x
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: top coordinate
'''  Loc: SRC/pix.h (483, 24)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: box width
'''  Loc: SRC/pix.h (484, 24)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: box height
'''  Loc: SRC/pix.h (485, 24)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (486, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Box
		public x as Integer
		public y as Integer
		public w as Integer
		public h as Integer
		public refcount as UInteger
	End Class
End Class


'  SRC/pix.h (492, 8)
'  Array of Box
Public Class Boxa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Boxa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.BoxaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of box in ptr array
'''  Loc: SRC/pix.h (494, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of box ptrs allocated
'''  Loc: SRC/pix.h (495, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (496, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: box ptr array
'''  Loc: SRC/pix.h (497, 24)
'''  Org: [struct Box ** box]
'''  Msh: struct Box ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Box = Box
'''  </summary>
ReadOnly property box as List (of Box)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.box <> IntPtr.Zero Then
		Dim LST_box As New List(Of Box)
		Dim ARR_box(values.n - 1) As IntPtr
		Marshal.Copy(Values.box, ARR_box, 0, values.n)
		For Each Entry In ARR_box
			LST_box.Add(New Box(Entry))
		Next
Return LST_box
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Boxa
		public n as Integer
		public nalloc as Integer
		public refcount as UInteger
		public box as IntPtr
	End Class
End Class


'  SRC/pix.h (502, 8)
'  Array of Boxa
Public Class Boxaa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Boxaa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.BoxaaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of boxa in ptr array
'''  Loc: SRC/pix.h (504, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of boxa ptrs allocated
'''  Loc: SRC/pix.h (505, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: boxa ptr array
'''  Loc: SRC/pix.h (506, 24)
'''  Org: [struct Boxa ** boxa]
'''  Msh: struct Boxa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Boxa = Boxa
'''  </summary>
ReadOnly property boxa as List (of Boxa)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.boxa <> IntPtr.Zero Then
		Dim LST_boxa As New List(Of Boxa)
		Dim ARR_boxa(values.n - 1) As IntPtr
		Marshal.Copy(Values.boxa, ARR_boxa, 0, values.n)
		For Each Entry In ARR_boxa
			LST_boxa.Add(New Boxa(Entry))
		Next
Return LST_boxa
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Boxaa
		public n as Integer
		public nalloc as Integer
		public boxa as IntPtr
	End Class
End Class


'  SRC/pix.h (517, 8)
'  Array of points
Public Class Pta
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Pta

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PtaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: actual number of pts
'''  Loc: SRC/pix.h (519, 24)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of allocated arrays
'''  Loc: SRC/pix.h (520, 24)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (521, 24)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 24)
'''  Org: [l_float32 * x]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property x as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.x <> IntPtr.Zero Then 
	Dim _x(values.n -1) as Single
	Marshal.Copy(Values.x, _x, 0, _x.Length)
	Return _x
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: arrays of floats
'''  Loc: SRC/pix.h (522, 28)
'''  Org: [l_float32 * y]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property y as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.y <> IntPtr.Zero Then 
	Dim _y(values.n -1) as Single
	Marshal.Copy(Values.y, _y, 0, _y.Length)
	Return _y
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Pta
		public n as Integer
		public nalloc as Integer
		public refcount as UInteger
		public x as IntPtr
		public y as IntPtr
	End Class
End Class


'  SRC/pix.h (532, 8)
'  Array of Pta
Public Class Ptaa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Ptaa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PtaaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of pta in ptr array
'''  Loc: SRC/pix.h (534, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of pta ptrs allocated
'''  Loc: SRC/pix.h (535, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pta ptr array
'''  Loc: SRC/pix.h (536, 26)
'''  Org: [struct Pta ** pta]
'''  Msh: struct Pta ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pta = Pta
'''  </summary>
ReadOnly property pta as List (of Pta)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.pta <> IntPtr.Zero Then
		Dim LST_pta As New List(Of Pta)
		Dim ARR_pta(values.n - 1) As IntPtr
		Marshal.Copy(Values.pta, ARR_pta, 0, values.n)
		For Each Entry In ARR_pta
			LST_pta.Add(New Pta(Entry))
		Next
Return LST_pta
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Ptaa
		public n as Integer
		public nalloc as Integer
		public pta as IntPtr
	End Class
End Class


'  SRC/pix.h (546, 8)
'  Pix accumulator container
Public Class Pixacc
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_Pixacc

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixaccDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: array width
'''  Loc: SRC/pix.h (548, 25)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array height
'''  Loc: SRC/pix.h (549, 25)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: used to allow negative
'''  Loc: SRC/pix.h (550, 25)
'''  Org: [l_int32 offset]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property offset as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.offset
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the 32 bit accumulator pix
'''  Loc: SRC/pix.h (552, 25)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pix as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Pixacc
		public w as Integer
		public h as Integer
		public offset as Integer
		public pix as IntPtr
	End Class
End Class


'  SRC/pix.h (562, 8)
'  Pix tiling
Public Class PixTiling
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_PixTiling

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixTilingDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: input pix (a clone)
'''  Loc: SRC/pix.h (564, 26)
'''  Org: [struct Pix * pix]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pix as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pix <> IntPtr.Zero Then 
		Return New Pix(Values.pix)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of tiles horizontally
'''  Loc: SRC/pix.h (565, 26)
'''  Org: [l_int32 nx]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nx as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nx
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of tiles vertically
'''  Loc: SRC/pix.h (566, 26)
'''  Org: [l_int32 ny]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ny as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ny
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: tile width
'''  Loc: SRC/pix.h (567, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: tile height
'''  Loc: SRC/pix.h (568, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: overlap on left and right
'''  Loc: SRC/pix.h (569, 26)
'''  Org: [l_int32 xoverlap]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xoverlap as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xoverlap
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: overlap on top and bottom
'''  Loc: SRC/pix.h (570, 26)
'''  Org: [l_int32 yoverlap]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yoverlap as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yoverlap
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: strip for paint default is TRUE
'''  Loc: SRC/pix.h (571, 26)
'''  Org: [l_int32 strip]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property strip as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.strip
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixTiling
		public pix as IntPtr
		public nx as Integer
		public ny as Integer
		public w as Integer
		public h as Integer
		public xoverlap as Integer
		public yoverlap as Integer
		public strip as Integer
	End Class
End Class


'  SRC/pix.h (582, 8)
'  Pix with float array
Public Class FPix
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_FPix

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.FPixDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: width in pixels
'''  Loc: SRC/pix.h (584, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height in pixels
'''  Loc: SRC/pix.h (585, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 32-bit words/line
'''  Loc: SRC/pix.h (586, 26)
'''  Org: [l_int32 wpl]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property wpl as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.wpl
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (587, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (588, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (590, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the float image data
'''  Loc: SRC/pix.h (592, 26)
'''  Org: [l_float32 * data]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property data as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Single
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_FPix
		public w as Integer
		public h as Integer
		public wpl as Integer
		public refcount as UInteger
		public xres as Integer
		public yres as Integer
		public data as IntPtr
	End Class
End Class


'  SRC/pix.h (597, 8)
'  Array of FPix
Public Class FPixa
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_FPixa

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.FPixaDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of fpix in ptr array
'''  Loc: SRC/pix.h (599, 25)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of fpix ptrs allocated
'''  Loc: SRC/pix.h (600, 25)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (601, 25)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the array of ptrs to fpix
'''  Loc: SRC/pix.h (602, 25)
'''  Org: [struct FPix ** fpix]
'''  Msh: struct FPix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: FPix = FPix
'''  </summary>
ReadOnly property fpix as List (of FPix)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.fpix <> IntPtr.Zero Then
		Dim LST_fpix As New List(Of FPix)
		Dim ARR_fpix(values.n - 1) As IntPtr
		Marshal.Copy(Values.fpix, ARR_fpix, 0, values.n)
		For Each Entry In ARR_fpix
			LST_fpix.Add(New FPix(Entry))
		Next
Return LST_fpix
End If
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_FPixa
		public n as Integer
		public nalloc as Integer
		public refcount as UInteger
		public fpix as IntPtr
	End Class
End Class


'  SRC/pix.h (613, 8)
'  Pix with double array
Public Class DPix
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_DPix

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.DPixDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: width in pixels
'''  Loc: SRC/pix.h (615, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height in pixels
'''  Loc: SRC/pix.h (616, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 32-bit words/line
'''  Loc: SRC/pix.h (617, 26)
'''  Org: [l_int32 wpl]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property wpl as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.wpl
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: reference count (1 if no clones)
'''  Loc: SRC/pix.h (618, 26)
'''  Org: [l_uint32 refcount]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property refcount as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.refcount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (619, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (621, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the double image data
'''  Loc: SRC/pix.h (623, 26)
'''  Org: [l_float64 * data]
'''  Msh: l_float64 * | 2:Double |
'''  </summary>
ReadOnly property data as Double()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Double
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_DPix
		public w as Integer
		public h as Integer
		public wpl as Integer
		public refcount as UInteger
		public xres as Integer
		public yres as Integer
		public data as IntPtr
	End Class
End Class


'  SRC/pix.h (633, 8)
'  Compressed Pix
Public Class PixComp
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_PixComp

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixCompDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: width in pixels
'''  Loc: SRC/pix.h (635, 26)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: height in pixels
'''  Loc: SRC/pix.h (636, 26)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: depth in bits
'''  Loc: SRC/pix.h (637, 26)
'''  Org: [l_int32 d]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property d as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.d
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in x direction
'''  Loc: SRC/pix.h (638, 26)
'''  Org: [l_int32 xres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: image res (ppi) in y direction
'''  Loc: SRC/pix.h (640, 26)
'''  Org: [l_int32 yres]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yres as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yres
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: compressed format (IFF_TIFF_G4,
'''  Loc: SRC/pix.h (642, 26)
'''  Org: [l_int32 comptype]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property comptype as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.comptype
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: text string associated with pix
'''  Loc: SRC/pix.h (644, 26)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property text as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: flag (1 for cmap, 0 otherwise)
'''  Loc: SRC/pix.h (645, 26)
'''  Org: [l_int32 cmapflag]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property cmapflag as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.cmapflag
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the compressed image data
'''  Loc: SRC/pix.h (646, 26)
'''  Org: [l_uint8 * data]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property data as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.data <> IntPtr.Zero Then 
	Dim _data(1 -1) as Byte
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	Return _data
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of the data array
'''  Loc: SRC/pix.h (647, 26)
'''  Org: [size_t size]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property size as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixComp
		public w as Integer
		public h as Integer
		public d as Integer
		public xres as Integer
		public yres as Integer
		public comptype as Integer
		public text as IntPtr
		public cmapflag as Integer
		public data as IntPtr
		public size as UInteger
	End Class
End Class


'  SRC/pix.h (658, 8)
'  Array of compressed pix
Public Class PixaComp
	implements IDisposable
	Property Pointer as IntPtr
	Private Values as new Marshal_PixaComp

	#Region "IDisposable Support"
	Private disposedValue As Boolean
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	  LeptonicaSharp.Natives.PixaCompDestroy(Pointer)
	  If Not Me.disposedValue Then
	  If disposing Then Values = Nothing
	  End If : Me.disposedValue = True
	End Sub
	Public Sub Dispose() Implements IDisposable.Dispose
	  Dispose(True) : GC.SuppressFinalize(Me)
	End Sub
	#End Region


	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of PixComp in ptr array
'''  Loc: SRC/pix.h (660, 26)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of PixComp ptrs allocated
'''  Loc: SRC/pix.h (661, 26)
'''  Org: [l_int32 nalloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nalloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nalloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: indexing offset into ptr array
'''  Loc: SRC/pix.h (662, 26)
'''  Org: [l_int32 offset]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property offset as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.offset
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: the array of ptrs to PixComp
'''  Loc: SRC/pix.h (663, 26)
'''  Org: [struct PixComp ** pixc]
'''  Msh: struct PixComp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
'''  </summary>
ReadOnly property pixc as List (of PixComp)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.pixc <> IntPtr.Zero Then
		Dim LST_pixc As New List(Of PixComp)
		Dim ARR_pixc(values.n - 1) As IntPtr
		Marshal.Copy(Values.pixc, ARR_pixc, 0, values.n)
		For Each Entry In ARR_pixc
			LST_pixc.Add(New PixComp(Entry))
		Next
Return LST_pixc
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of boxes
'''  Loc: SRC/pix.h (664, 26)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixaComp
		public n as Integer
		public nalloc as Integer
		public offset as Integer
		public pixc as IntPtr
		public boxa as IntPtr
	End Class
End Class


#End Region
#Region "SRC/recog.h"
'  SRC/recog.h (116, 8)
'  
Public Class L_Recog
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Recog



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: scale all examples to this width
'''  Loc: SRC/recog.h (117, 20)
'''  Org: [l_int32 scalew]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property scalew as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.scalew
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: scale all examples to this height
'''  Loc: SRC/recog.h (119, 20)
'''  Org: [l_int32 scaleh]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property scaleh as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.scaleh
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: use a value > 0 to convert the bitmap
'''  Loc: SRC/recog.h (121, 20)
'''  Org: [l_int32 linew]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property linew as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.linew
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: template use: use either the average
'''  Loc: SRC/recog.h (123, 20)
'''  Org: [l_int32 templ_use]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property templ_use as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.templ_use
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: initialize container arrays to this
'''  Loc: SRC/recog.h (126, 20)
'''  Org: [l_int32 maxarraysize]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxarraysize as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxarraysize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of character set
'''  Loc: SRC/recog.h (127, 20)
'''  Org: [l_int32 setsize]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property setsize as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.setsize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: for binarizing if depth > 1
'''  Loc: SRC/recog.h (128, 20)
'''  Org: [l_int32 threshold]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property threshold as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.threshold
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: vertical jiggle on nominal centroid
'''  Loc: SRC/recog.h (129, 20)
'''  Org: [l_int32 maxyshift]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxyshift as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxyshift
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: one of L_ARABIC_NUMERALS, etc.
'''  Loc: SRC/recog.h (131, 20)
'''  Org: [l_int32 charset_type]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property charset_type as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.charset_type
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: expected number of classes in charset
'''  Loc: SRC/recog.h (132, 20)
'''  Org: [l_int32 charset_size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property charset_size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.charset_size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min number of samples without padding
'''  Loc: SRC/recog.h (133, 20)
'''  Org: [l_int32 min_nopad]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property min_nopad as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.min_nopad
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of training samples
'''  Loc: SRC/recog.h (134, 20)
'''  Org: [l_int32 num_samples]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property num_samples as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.num_samples
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min width averaged unscaled templates
'''  Loc: SRC/recog.h (135, 20)
'''  Org: [l_int32 minwidth_u]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minwidth_u as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minwidth_u
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max width averaged unscaled templates
'''  Loc: SRC/recog.h (136, 20)
'''  Org: [l_int32 maxwidth_u]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxwidth_u as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxwidth_u
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min height averaged unscaled templates
'''  Loc: SRC/recog.h (137, 20)
'''  Org: [l_int32 minheight_u]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minheight_u as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minheight_u
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max height averaged unscaled templates
'''  Loc: SRC/recog.h (138, 20)
'''  Org: [l_int32 maxheight_u]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxheight_u as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxheight_u
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min width averaged scaled templates
'''  Loc: SRC/recog.h (139, 20)
'''  Org: [l_int32 minwidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minwidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minwidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max width averaged scaled templates
'''  Loc: SRC/recog.h (140, 20)
'''  Org: [l_int32 maxwidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxwidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxwidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 when averaged bitmaps are made
'''  Loc: SRC/recog.h (141, 20)
'''  Org: [l_int32 ave_done]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ave_done as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ave_done
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 when training is complete or
'''  Loc: SRC/recog.h (142, 20)
'''  Org: [l_int32 train_done]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property train_done as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.train_done
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max width/height ratio to split
'''  Loc: SRC/recog.h (144, 20)
'''  Org: [l_float32 max_wh_ratio]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property max_wh_ratio as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_wh_ratio
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max of max/min template height ratio
'''  Loc: SRC/recog.h (145, 20)
'''  Org: [l_float32 max_ht_ratio]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property max_ht_ratio as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_ht_ratio
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min component width kept in splitting
'''  Loc: SRC/recog.h (146, 20)
'''  Org: [l_int32 min_splitw]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property min_splitw as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.min_splitw
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max component height kept in splitting
'''  Loc: SRC/recog.h (147, 20)
'''  Org: [l_int32 max_splith]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property max_splith as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.max_splith
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: text array for arbitrary char set
'''  Loc: SRC/recog.h (148, 20)
'''  Org: [struct Sarray * sa_text]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property sa_text as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.sa_text <> IntPtr.Zero Then 
		Return New Sarray(Values.sa_text)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: index-to-char lut for arbitrary charset
'''  Loc: SRC/recog.h (149, 20)
'''  Org: [struct L_Dna * dna_tochar]
'''  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property dna_tochar as L_Dna
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.dna_tochar <> IntPtr.Zero Then 
		Return New L_Dna(Values.dna_tochar)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: table for finding centroids
'''  Loc: SRC/recog.h (150, 20)
'''  Org: [l_int32 * centtab]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property centtab as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.centtab <> IntPtr.Zero Then 
	Dim _centtab(1 -1) as Integer
	Marshal.Copy(Values.centtab, _centtab, 0, _centtab.Length)
	Return _centtab
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: table for finding pixel sums
'''  Loc: SRC/recog.h (151, 20)
'''  Org: [l_int32 * sumtab]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property sumtab as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.sumtab <> IntPtr.Zero Then 
	Dim _sumtab(1 -1) as Integer
	Marshal.Copy(Values.sumtab, _sumtab, 0, _sumtab.Length)
	Return _sumtab
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: all unscaled templates for each class
'''  Loc: SRC/recog.h (152, 20)
'''  Org: [struct Pixaa * pixaa_u]
'''  Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
'''  </summary>
ReadOnly property pixaa_u as Pixaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixaa_u <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of all unscaled templates
'''  Loc: SRC/recog.h (153, 20)
'''  Org: [struct Ptaa * ptaa_u]
'''  Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
'''  </summary>
ReadOnly property ptaa_u as Ptaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptaa_u <> IntPtr.Zero Then 
		Return New Ptaa(Values.ptaa_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: area of all unscaled templates
'''  Loc: SRC/recog.h (154, 20)
'''  Org: [struct Numaa * naasum_u]
'''  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
'''  </summary>
ReadOnly property naasum_u as Numaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naasum_u <> IntPtr.Zero Then 
		Return New Numaa(Values.naasum_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: all (scaled) templates for each class
'''  Loc: SRC/recog.h (155, 20)
'''  Org: [struct Pixaa * pixaa]
'''  Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
'''  </summary>
ReadOnly property pixaa as Pixaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixaa <> IntPtr.Zero Then 
		Return New Pixaa(Values.pixaa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of all (scaledl) templates
'''  Loc: SRC/recog.h (156, 20)
'''  Org: [struct Ptaa * ptaa]
'''  Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
'''  </summary>
ReadOnly property ptaa as Ptaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptaa <> IntPtr.Zero Then 
		Return New Ptaa(Values.ptaa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: area of all (scaled) templates
'''  Loc: SRC/recog.h (157, 20)
'''  Org: [struct Numaa * naasum]
'''  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
'''  </summary>
ReadOnly property naasum as Numaa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naasum <> IntPtr.Zero Then 
		Return New Numaa(Values.naasum)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: averaged unscaled templates per class
'''  Loc: SRC/recog.h (158, 20)
'''  Org: [struct Pixa * pixa_u]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixa_u as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixa_u <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of unscaled ave. templates
'''  Loc: SRC/recog.h (159, 20)
'''  Org: [struct Pta * pta_u]
'''  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
'''  </summary>
ReadOnly property pta_u as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pta_u <> IntPtr.Zero Then 
		Return New Pta(Values.pta_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: area of unscaled averaged templates
'''  Loc: SRC/recog.h (160, 20)
'''  Org: [struct Numa * nasum_u]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasum_u as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasum_u <> IntPtr.Zero Then 
		Return New Numa(Values.nasum_u)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: averaged (scaled) templates per class
'''  Loc: SRC/recog.h (161, 20)
'''  Org: [struct Pixa * pixa]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixa as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixa <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: centroids of (scaled) ave. templates
'''  Loc: SRC/recog.h (162, 20)
'''  Org: [struct Pta * pta]
'''  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
'''  </summary>
ReadOnly property pta as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pta <> IntPtr.Zero Then 
		Return New Pta(Values.pta)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: area of (scaled) averaged templates
'''  Loc: SRC/recog.h (163, 20)
'''  Org: [struct Numa * nasum]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasum as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasum <> IntPtr.Zero Then 
		Return New Numa(Values.nasum)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: all input training images
'''  Loc: SRC/recog.h (164, 20)
'''  Org: [struct Pixa * pixa_tr]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixa_tr as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixa_tr <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_tr)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: unscaled and scaled averaged bitmaps
'''  Loc: SRC/recog.h (165, 20)
'''  Org: [struct Pixa * pixadb_ave]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixadb_ave as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixadb_ave <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_ave)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: input images for identifying
'''  Loc: SRC/recog.h (166, 20)
'''  Org: [struct Pixa * pixa_id]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixa_id as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixa_id <> IntPtr.Zero Then 
		Return New Pixa(Values.pixa_id)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: debug: best match of input against ave.
'''  Loc: SRC/recog.h (167, 20)
'''  Org: [struct Pix * pixdb_ave]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixdb_ave as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixdb_ave <> IntPtr.Zero Then 
		Return New Pix(Values.pixdb_ave)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: debug: best matches within range
'''  Loc: SRC/recog.h (168, 20)
'''  Org: [struct Pix * pixdb_range]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixdb_range as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixdb_range <> IntPtr.Zero Then 
		Return New Pix(Values.pixdb_range)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: debug: bootstrap training results
'''  Loc: SRC/recog.h (169, 20)
'''  Org: [struct Pixa * pixadb_boot]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixadb_boot as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixadb_boot <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_boot)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: debug: splitting results
'''  Loc: SRC/recog.h (170, 20)
'''  Org: [struct Pixa * pixadb_split]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixadb_split as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixadb_split <> IntPtr.Zero Then 
		Return New Pixa(Values.pixadb_split)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: bmf fonts
'''  Loc: SRC/recog.h (171, 20)
'''  Org: [struct L_Bmf * bmf]
'''  Msh: struct L_Bmf * | 2:Struct |  | Typedef: L_Bmf = L_Bmf
'''  </summary>
ReadOnly property bmf as L_Bmf
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.bmf <> IntPtr.Zero Then 
		Return New L_Bmf(Values.bmf)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: font size of bmf default is 6 pt
'''  Loc: SRC/recog.h (172, 20)
'''  Org: [l_int32 bmf_size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bmf_size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bmf_size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: temp data used for image decoding
'''  Loc: SRC/recog.h (173, 20)
'''  Org: [struct L_Rdid * did]
'''  Msh: struct L_Rdid * | 2:Struct |
'''  </summary>
ReadOnly property did as L_Rdid
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.did <> IntPtr.Zero Then 
		Return New L_Rdid(Values.did)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: temp data used for holding best char
'''  Loc: SRC/recog.h (174, 20)
'''  Org: [struct L_Rch * rch]
'''  Msh: struct L_Rch * | 2:Struct |
'''  </summary>
ReadOnly property rch as L_Rch
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.rch <> IntPtr.Zero Then 
		Return New L_Rch(Values.rch)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: temp data used for array of best chars
'''  Loc: SRC/recog.h (175, 20)
'''  Org: [struct L_Rcha * rcha]
'''  Msh: struct L_Rcha * | 2:Struct |
'''  </summary>
ReadOnly property rcha as L_Rcha
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.rcha <> IntPtr.Zero Then 
		Return New L_Rcha(Values.rcha)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Recog
		public scalew as Integer
		public scaleh as Integer
		public linew as Integer
		public templ_use as Integer
		public maxarraysize as Integer
		public setsize as Integer
		public threshold as Integer
		public maxyshift as Integer
		public charset_type as Integer
		public charset_size as Integer
		public min_nopad as Integer
		public num_samples as Integer
		public minwidth_u as Integer
		public maxwidth_u as Integer
		public minheight_u as Integer
		public maxheight_u as Integer
		public minwidth as Integer
		public maxwidth as Integer
		public ave_done as Integer
		public train_done as Integer
		public max_wh_ratio as Single
		public max_ht_ratio as Single
		public min_splitw as Integer
		public max_splith as Integer
		public sa_text as IntPtr
		public dna_tochar as IntPtr
		public centtab as IntPtr
		public sumtab as IntPtr
		public pixaa_u as IntPtr
		public ptaa_u as IntPtr
		public naasum_u as IntPtr
		public pixaa as IntPtr
		public ptaa as IntPtr
		public naasum as IntPtr
		public pixa_u as IntPtr
		public pta_u as IntPtr
		public nasum_u as IntPtr
		public pixa as IntPtr
		public pta as IntPtr
		public nasum as IntPtr
		public pixa_tr as IntPtr
		public pixadb_ave as IntPtr
		public pixa_id as IntPtr
		public pixdb_ave as IntPtr
		public pixdb_range as IntPtr
		public pixadb_boot as IntPtr
		public pixadb_split as IntPtr
		public bmf as IntPtr
		public bmf_size as Integer
		public did as IntPtr
		public rch as IntPtr
		public rcha as IntPtr
	End Class
End Class


'  SRC/recog.h (182, 8)
'  Data returned from correlation matching on a single character
Public Class L_Rch
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Rch



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: index of best template
'''  Loc: SRC/recog.h (183, 20)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: correlation score of best template
'''  Loc: SRC/recog.h (184, 20)
'''  Org: [l_float32 score]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property score as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.score
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: character string of best template
'''  Loc: SRC/recog.h (185, 20)
'''  Org: [char * text]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property text as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.text <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.text)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: index of best sample (within the best
'''  Loc: SRC/recog.h (186, 20)
'''  Org: [l_int32 sample]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property sample as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sample
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x-location of template (delx + shiftx)
'''  Loc: SRC/recog.h (188, 20)
'''  Org: [l_int32 xloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y-location of template (dely + shifty)
'''  Loc: SRC/recog.h (189, 20)
'''  Org: [l_int32 yloc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property yloc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.yloc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: width of best template
'''  Loc: SRC/recog.h (190, 20)
'''  Org: [l_int32 width]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property width as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.width
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rch
		public index as Integer
		public score as Single
		public text as IntPtr
		public sample as Integer
		public xloc as Integer
		public yloc as Integer
		public width as Integer
	End Class
End Class


'  SRC/recog.h (197, 8)
'  Data returned from correlation matching on an array of characters
Public Class L_Rcha
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Rcha



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: indices of best templates
'''  Loc: SRC/recog.h (198, 20)
'''  Org: [struct Numa * naindex]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naindex as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naindex <> IntPtr.Zero Then 
		Return New Numa(Values.naindex)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: correlation scores of best templates
'''  Loc: SRC/recog.h (199, 20)
'''  Org: [struct Numa * nascore]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nascore as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nascore <> IntPtr.Zero Then 
		Return New Numa(Values.nascore)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: character strings of best templates
'''  Loc: SRC/recog.h (200, 20)
'''  Org: [struct Sarray * satext]
'''  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property satext as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.satext <> IntPtr.Zero Then 
		Return New Sarray(Values.satext)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: indices of best samples
'''  Loc: SRC/recog.h (201, 20)
'''  Org: [struct Numa * nasample]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasample as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasample <> IntPtr.Zero Then 
		Return New Numa(Values.nasample)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x-locations of templates (delx + shiftx)
'''  Loc: SRC/recog.h (202, 20)
'''  Org: [struct Numa * naxloc]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naxloc as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naxloc <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y-locations of templates (dely + shifty)
'''  Loc: SRC/recog.h (203, 20)
'''  Org: [struct Numa * nayloc]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nayloc as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nayloc <> IntPtr.Zero Then 
		Return New Numa(Values.nayloc)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: widths of best templates
'''  Loc: SRC/recog.h (204, 20)
'''  Org: [struct Numa * nawidth]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nawidth as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nawidth <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rcha
		public naindex as IntPtr
		public nascore as IntPtr
		public satext as IntPtr
		public nasample as IntPtr
		public naxloc as IntPtr
		public nayloc as IntPtr
		public nawidth as IntPtr
	End Class
End Class


'  SRC/recog.h (211, 8)
'  Data used for decoding a line of characters.
Public Class L_Rdid
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Rdid



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: clone of pix to be decoded
'''  Loc: SRC/recog.h (212, 20)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixs as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: count array for each averaged template
'''  Loc: SRC/recog.h (213, 20)
'''  Org: [l_int32 ** counta]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
'''  </summary>
ReadOnly property counta as List (of Integer())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(1 - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.counta, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: best y-shift array per average template
'''  Loc: SRC/recog.h (214, 20)
'''  Org: [l_int32 ** delya]
'''  Msh: l_int32 ** | 3:Integer | List (of Integer())
'''  </summary>
ReadOnly property delya as List (of Integer())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(1 - 1) As Integer
Dim _DataFin As New List(Of Integer())
Marshal.Copy(Values.delya, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Integer
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of averaged templates
'''  Loc: SRC/recog.h (215, 20)
'''  Org: [l_int32 narray]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property narray as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.narray
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of count array (width of pixs)
'''  Loc: SRC/recog.h (216, 20)
'''  Org: [l_int32 size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: setwidths for each template
'''  Loc: SRC/recog.h (217, 20)
'''  Org: [l_int32 * setwidth]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property setwidth as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.setwidth <> IntPtr.Zero Then 
	Dim _setwidth(1 -1) as Integer
	Marshal.Copy(Values.setwidth, _setwidth, 0, _setwidth.Length)
	Return _setwidth
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pixel count in pixs by column
'''  Loc: SRC/recog.h (218, 20)
'''  Org: [struct Numa * nasum]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasum as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasum <> IntPtr.Zero Then 
		Return New Numa(Values.nasum)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: first moment of pixels in pixs by cols
'''  Loc: SRC/recog.h (219, 20)
'''  Org: [struct Numa * namoment]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property namoment as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.namoment <> IntPtr.Zero Then 
		Return New Numa(Values.namoment)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 1 if full arrays are made 0 otherwise
'''  Loc: SRC/recog.h (220, 20)
'''  Org: [l_int32 fullarrays]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property fullarrays as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.fullarrays
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: channel coeffs for template fg term
'''  Loc: SRC/recog.h (221, 20)
'''  Org: [l_float32 * beta]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property beta as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.beta <> IntPtr.Zero Then 
	Dim _beta(1 -1) as Single
	Marshal.Copy(Values.beta, _beta, 0, _beta.Length)
	Return _beta
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: channel coeffs for bit-and term
'''  Loc: SRC/recog.h (222, 20)
'''  Org: [l_float32 * gamma]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property gamma as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.gamma <> IntPtr.Zero Then 
	Dim _gamma(1 -1) as Single
	Marshal.Copy(Values.gamma, _gamma, 0, _gamma.Length)
	Return _gamma
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: score on trellis
'''  Loc: SRC/recog.h (223, 20)
'''  Org: [l_float32 * trellisscore]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property trellisscore as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.trellisscore <> IntPtr.Zero Then 
	Dim _trellisscore(1 -1) as Single
	Marshal.Copy(Values.trellisscore, _trellisscore, 0, _trellisscore.Length)
	Return _trellisscore
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: template on trellis (for backtrack)
'''  Loc: SRC/recog.h (224, 20)
'''  Org: [l_int32 * trellistempl]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property trellistempl as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.trellistempl <> IntPtr.Zero Then 
	Dim _trellistempl(1 -1) as Integer
	Marshal.Copy(Values.trellistempl, _trellistempl, 0, _trellistempl.Length)
	Return _trellistempl
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: indices of best path templates
'''  Loc: SRC/recog.h (225, 20)
'''  Org: [struct Numa * natempl]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property natempl as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.natempl <> IntPtr.Zero Then 
		Return New Numa(Values.natempl)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x locations of best path templates
'''  Loc: SRC/recog.h (226, 20)
'''  Org: [struct Numa * naxloc]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naxloc as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naxloc <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y locations of best path templates
'''  Loc: SRC/recog.h (227, 20)
'''  Org: [struct Numa * nadely]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nadely as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nadely <> IntPtr.Zero Then 
		Return New Numa(Values.nadely)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: widths of best path templates
'''  Loc: SRC/recog.h (228, 20)
'''  Org: [struct Numa * nawidth]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nawidth as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nawidth <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Viterbi result for splitting input pixs
'''  Loc: SRC/recog.h (229, 20)
'''  Org: [struct Boxa * boxa]
'''  Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: correlation scores: best path templates
'''  Loc: SRC/recog.h (230, 20)
'''  Org: [struct Numa * nascore]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nascore as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nascore <> IntPtr.Zero Then 
		Return New Numa(Values.nascore)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: indices of best rescored templates
'''  Loc: SRC/recog.h (231, 20)
'''  Org: [struct Numa * natempl_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property natempl_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.natempl_r <> IntPtr.Zero Then 
		Return New Numa(Values.natempl_r)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: samples of best scored templates
'''  Loc: SRC/recog.h (232, 20)
'''  Org: [struct Numa * nasample_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasample_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasample_r <> IntPtr.Zero Then 
		Return New Numa(Values.nasample_r)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x locations of best rescoredtemplates
'''  Loc: SRC/recog.h (233, 20)
'''  Org: [struct Numa * naxloc_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property naxloc_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.naxloc_r <> IntPtr.Zero Then 
		Return New Numa(Values.naxloc_r)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y locations of best rescoredtemplates
'''  Loc: SRC/recog.h (234, 20)
'''  Org: [struct Numa * nadely_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nadely_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nadely_r <> IntPtr.Zero Then 
		Return New Numa(Values.nadely_r)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: widths of best rescoredtemplates
'''  Loc: SRC/recog.h (235, 20)
'''  Org: [struct Numa * nawidth_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nawidth_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nawidth_r <> IntPtr.Zero Then 
		Return New Numa(Values.nawidth_r)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: correlation scores: rescored templates
'''  Loc: SRC/recog.h (236, 20)
'''  Org: [struct Numa * nascore_r]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nascore_r as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nascore_r <> IntPtr.Zero Then 
		Return New Numa(Values.nascore_r)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rdid
		public pixs as IntPtr
		public counta as IntPtr
		public delya as IntPtr
		public narray as Integer
		public size as Integer
		public setwidth as IntPtr
		public nasum as IntPtr
		public namoment as IntPtr
		public fullarrays as Integer
		public beta as IntPtr
		public gamma as IntPtr
		public trellisscore as IntPtr
		public trellistempl as IntPtr
		public natempl as IntPtr
		public naxloc as IntPtr
		public nadely as IntPtr
		public nawidth as IntPtr
		public boxa as IntPtr
		public nascore as IntPtr
		public natempl_r as IntPtr
		public nasample_r as IntPtr
		public naxloc_r as IntPtr
		public nadely_r as IntPtr
		public nawidth_r as IntPtr
		public nascore_r as IntPtr
	End Class
End Class


#End Region
#Region "SRC/regutils.h"
'  SRC/regutils.h (117, 8)
'  Regression test parameter packer
Public Class L_RegParams
	Property Pointer as IntPtr
	Private Values as new Marshal_L_RegParams



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: stream to temporary output file for compare mode
'''  Loc: SRC/regutils.h (119, 14)
'''  Org: [FILE * fp]
'''  Msh: FILE * | 2:Struct |
'''  </summary>
ReadOnly property fp as FILE
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.fp <> IntPtr.Zero Then 
		Return New FILE(Values.fp)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: name of test, without '_reg'
'''  Loc: SRC/regutils.h (120, 14)
'''  Org: [char * testname]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property testname as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.testname <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.testname)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: name of temp file for compare mode output
'''  Loc: SRC/regutils.h (121, 14)
'''  Org: [char * tempfile]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property tempfile as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.tempfile <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.tempfile)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: generate, compare or display
'''  Loc: SRC/regutils.h (122, 14)
'''  Org: [l_int32 mode]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property mode as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.mode
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: index into saved files for this test 0-based
'''  Loc: SRC/regutils.h (123, 14)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: overall result of the test
'''  Loc: SRC/regutils.h (124, 14)
'''  Org: [l_int32 success]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property success as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.success
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 1 if in display mode 0 otherwise
'''  Loc: SRC/regutils.h (125, 14)
'''  Org: [l_int32 display]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property display as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.display
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: marks beginning of the reg test
'''  Loc: SRC/regutils.h (126, 14)
'''  Org: [L_TIMER tstart]
'''  Msh: L_TIMER | 1:Pointer |
'''  </summary>
ReadOnly property tstart as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.tstart
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_RegParams
		public fp as IntPtr
		public testname as IntPtr
		public tempfile as IntPtr
		public mode as Integer
		public index as Integer
		public success as Integer
		public display as Integer
		public tstart as IntPtr
	End Class
End Class


#End Region
#Region "SRC/stringcode.h"
'  SRC/stringcode.h (40, 8)
'  stringcode.h
Public Class L_StrCode
	Property Pointer as IntPtr
	Private Values as new Marshal_L_StrCode



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: index for function and output file names
'''  Loc: SRC/stringcode.h (42, 19)
'''  Org: [l_int32 fileno]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property fileno as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.fileno
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: index into struct currently being stored
'''  Loc: SRC/stringcode.h (43, 19)
'''  Org: [l_int32 ifunc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ifunc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ifunc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: store case code for extraction
'''  Loc: SRC/stringcode.h (44, 19)
'''  Org: [SARRAY * function]
'''  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property _function_ as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values._function_ <> IntPtr.Zero Then 
		Return New Sarray(Values._function_)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: store base64 encoded data as strings
'''  Loc: SRC/stringcode.h (45, 19)
'''  Org: [SARRAY * data]
'''  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property data as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.data <> IntPtr.Zero Then 
		Return New Sarray(Values.data)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: store line in description table
'''  Loc: SRC/stringcode.h (46, 19)
'''  Org: [SARRAY * descr]
'''  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
'''  </summary>
ReadOnly property descr as Sarray
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.descr <> IntPtr.Zero Then 
		Return New Sarray(Values.descr)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of data strings
'''  Loc: SRC/stringcode.h (47, 19)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_StrCode
		public fileno as Integer
		public ifunc as Integer
		public _function_ as IntPtr
		public data as IntPtr
		public descr as IntPtr
		public n as Integer
	End Class
End Class


#End Region
#Region "SRC/sudoku.h"
'  SRC/sudoku.h (52, 8)
'  sudoku.h
Public Class L_Sudoku
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Sudoku



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: number of unknowns
'''  Loc: SRC/sudoku.h (54, 20)
'''  Org: [l_int32 num]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property num as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.num
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: location of unknowns
'''  Loc: SRC/sudoku.h (55, 20)
'''  Org: [l_int32 * locs]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property locs as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.locs <> IntPtr.Zero Then 
	Dim _locs(1 -1) as Integer
	Marshal.Copy(Values.locs, _locs, 0, _locs.Length)
	Return _locs
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: index into %locs of current location
'''  Loc: SRC/sudoku.h (56, 20)
'''  Org: [l_int32 current]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property current as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.current
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: initial state, with 0 representing
'''  Loc: SRC/sudoku.h (57, 20)
'''  Org: [l_int32 * init]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property init as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.init <> IntPtr.Zero Then 
	Dim _init(1 -1) as Integer
	Marshal.Copy(Values.init, _init, 0, _init.Length)
	Return _init
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: present state, including inits and
'''  Loc: SRC/sudoku.h (59, 20)
'''  Org: [l_int32 * state]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property state as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.state <> IntPtr.Zero Then 
	Dim _state(1 -1) as Integer
	Marshal.Copy(Values.state, _state, 0, _state.Length)
	Return _state
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: shows current number of guesses
'''  Loc: SRC/sudoku.h (61, 20)
'''  Org: [l_int32 nguess]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nguess as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nguess
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 when solved
'''  Loc: SRC/sudoku.h (62, 20)
'''  Org: [l_int32 finished]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property finished as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.finished
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 if no solution is possible
'''  Loc: SRC/sudoku.h (63, 20)
'''  Org: [l_int32 failure]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property failure as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.failure
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Sudoku
		public num as Integer
		public locs as IntPtr
		public current as Integer
		public init as IntPtr
		public state as IntPtr
		public nguess as Integer
		public finished as Integer
		public failure as Integer
	End Class
End Class


#End Region
#Region "SRC/watershed.h"
'  SRC/watershed.h (38, 8)
'  Simple data structure to hold watershed data.
Public Class L_WShed
	Property Pointer as IntPtr
	Private Values as new Marshal_L_WShed



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: clone of input 8 bpp pixs
'''  Loc: SRC/watershed.h (40, 20)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixs as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: clone of input 1 bpp seed (marker) pixm
'''  Loc: SRC/watershed.h (41, 20)
'''  Org: [struct Pix * pixm]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixm as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixm <> IntPtr.Zero Then 
		Return New Pix(Values.pixm)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: minimum depth allowed for a watershed
'''  Loc: SRC/watershed.h (42, 20)
'''  Org: [l_int32 mindepth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property mindepth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.mindepth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 16 bpp label pix
'''  Loc: SRC/watershed.h (43, 20)
'''  Org: [struct Pix * pixlab]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixlab as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixlab <> IntPtr.Zero Then 
		Return New Pix(Values.pixlab)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: scratch pix for computing wshed regions
'''  Loc: SRC/watershed.h (44, 20)
'''  Org: [struct Pix * pixt]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixt as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixt <> IntPtr.Zero Then 
		Return New Pix(Values.pixt)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: line ptrs for pixs
'''  Loc: SRC/watershed.h (45, 20)
'''  Org: [void ** lines8]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property lines8 as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.lines8 <> IntPtr.Zero Then 
		Dim _lines8(1) as IntPtr
		Marshal.Copy(Values.lines8, _lines8, 0, 1)
		Return _lines8
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: line ptrs for pixm
'''  Loc: SRC/watershed.h (46, 20)
'''  Org: [void ** linem1]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property linem1 as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.linem1 <> IntPtr.Zero Then 
		Dim _linem1(1) as IntPtr
		Marshal.Copy(Values.linem1, _linem1, 0, 1)
		Return _linem1
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: line ptrs for pixlab
'''  Loc: SRC/watershed.h (47, 20)
'''  Org: [void ** linelab32]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property linelab32 as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.linelab32 <> IntPtr.Zero Then 
		Dim _linelab32(1) as IntPtr
		Marshal.Copy(Values.linelab32, _linelab32, 0, 1)
		Return _linelab32
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: line ptrs for pixt
'''  Loc: SRC/watershed.h (48, 20)
'''  Org: [void ** linet1]
'''  Msh: void ** | 3:Void | IntPtr()
'''  </summary>
ReadOnly property linet1 as IntPtr()
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.linet1 <> IntPtr.Zero Then 
		Dim _linet1(1) as IntPtr
		Marshal.Copy(Values.linet1, _linet1, 0, 1)
		Return _linet1
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: result: 1 bpp pixa of watersheds
'''  Loc: SRC/watershed.h (49, 20)
'''  Org: [struct Pixa * pixad]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixad as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixad <> IntPtr.Zero Then 
		Return New Pixa(Values.pixad)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pta of initial seed pixels
'''  Loc: SRC/watershed.h (50, 20)
'''  Org: [struct Pta * ptas]
'''  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
'''  </summary>
ReadOnly property ptas as Pta
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.ptas <> IntPtr.Zero Then 
		Return New Pta(Values.ptas)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: numa of seed indicators 0 if completed
'''  Loc: SRC/watershed.h (51, 20)
'''  Org: [struct Numa * nasi]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nasi as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nasi <> IntPtr.Zero Then 
		Return New Numa(Values.nasi)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: numa of initial seed heights
'''  Loc: SRC/watershed.h (52, 20)
'''  Org: [struct Numa * nash]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nash as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nash <> IntPtr.Zero Then 
		Return New Numa(Values.nash)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: numa of initial minima heights
'''  Loc: SRC/watershed.h (53, 20)
'''  Org: [struct Numa * namh]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property namh as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.namh <> IntPtr.Zero Then 
		Return New Numa(Values.namh)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: result: numa of watershed levels
'''  Loc: SRC/watershed.h (54, 20)
'''  Org: [struct Numa * nalevels]
'''  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
'''  </summary>
ReadOnly property nalevels as Numa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.nalevels <> IntPtr.Zero Then 
		Return New Numa(Values.nalevels)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of seeds (markers)
'''  Loc: SRC/watershed.h (55, 20)
'''  Org: [l_int32 nseeds]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nseeds as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nseeds
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of minima different from seeds
'''  Loc: SRC/watershed.h (56, 20)
'''  Org: [l_int32 nother]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nother as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nother
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: lut for pixel indices
'''  Loc: SRC/watershed.h (57, 20)
'''  Org: [l_int32 * lut]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property lut as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.lut <> IntPtr.Zero Then 
	Dim _lut(1 -1) as Integer
	Marshal.Copy(Values.lut, _lut, 0, _lut.Length)
	Return _lut
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: back-links into lut, for updates
'''  Loc: SRC/watershed.h (58, 20)
'''  Org: [struct Numa ** links]
'''  Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
'''  </summary>
ReadOnly property links as List (of Numa)
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.links <> IntPtr.Zero Then
		Dim LST_links As New List(Of Numa)
		Dim ARR_links(1 - 1) As IntPtr
		Marshal.Copy(Values.links, ARR_links, 0, 1)
		For Each Entry In ARR_links
			LST_links.Add(New Numa(Entry))
		Next
Return LST_links
End If
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of links array
'''  Loc: SRC/watershed.h (59, 20)
'''  Org: [l_int32 arraysize]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property arraysize as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.arraysize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set to 1 for debug output
'''  Loc: SRC/watershed.h (60, 20)
'''  Org: [l_int32 debug]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property debug as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.debug
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_WShed
		public pixs as IntPtr
		public pixm as IntPtr
		public mindepth as Integer
		public pixlab as IntPtr
		public pixt as IntPtr
		public lines8 as IntPtr
		public linem1 as IntPtr
		public linelab32 as IntPtr
		public linet1 as IntPtr
		public pixad as IntPtr
		public ptas as IntPtr
		public nasi as IntPtr
		public nash as IntPtr
		public namh as IntPtr
		public nalevels as IntPtr
		public nseeds as Integer
		public nother as Integer
		public lut as IntPtr
		public links as IntPtr
		public arraysize as Integer
		public debug as Integer
	End Class
End Class


#End Region
#Region "SRC/bilateral.h"
'  SRC/bilateral.h (115, 8)
'  Bilateral filter
Public Class L_Bilateral
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Bilateral



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: clone of source pix
'''  Loc: SRC/bilateral.h (117, 21)
'''  Org: [struct Pix * pixs]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixs as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixs <> IntPtr.Zero Then 
		Return New Pix(Values.pixs)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: downscaled pix with mirrored border
'''  Loc: SRC/bilateral.h (118, 21)
'''  Org: [struct Pix * pixsc]
'''  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
'''  </summary>
ReadOnly property pixsc as Pix
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixsc <> IntPtr.Zero Then 
		Return New Pix(Values.pixsc)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 1, 2 or 4x for intermediates
'''  Loc: SRC/bilateral.h (119, 21)
'''  Org: [l_int32 reduction]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property reduction as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.reduction
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: stdev of spatial gaussian
'''  Loc: SRC/bilateral.h (120, 21)
'''  Org: [l_float32 spatial_stdev]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property spatial_stdev as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.spatial_stdev
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: stdev of range gaussian
'''  Loc: SRC/bilateral.h (121, 21)
'''  Org: [l_float32 range_stdev]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property range_stdev as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.range_stdev
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 1D gaussian spatial kernel
'''  Loc: SRC/bilateral.h (122, 21)
'''  Org: [l_float32 * spatial]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property spatial as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.spatial <> IntPtr.Zero Then 
	Dim _spatial(1 -1) as Single
	Marshal.Copy(Values.spatial, _spatial, 0, _spatial.Length)
	Return _spatial
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: one-sided gaussian range kernel
'''  Loc: SRC/bilateral.h (123, 21)
'''  Org: [l_float32 * range]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property range as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.range <> IntPtr.Zero Then 
	Dim _range(1 -1) as Single
	Marshal.Copy(Values.range, _range, 0, _range.Length)
	Return _range
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: min value in 8 bpp pix
'''  Loc: SRC/bilateral.h (124, 21)
'''  Org: [l_int32 minval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property minval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: max value in 8 bpp pix
'''  Loc: SRC/bilateral.h (125, 21)
'''  Org: [l_int32 maxval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property maxval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.maxval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of intermediate results
'''  Loc: SRC/bilateral.h (126, 21)
'''  Org: [l_int32 ncomps]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property ncomps as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.ncomps
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: set of k values (size ncomps)
'''  Loc: SRC/bilateral.h (127, 21)
'''  Org: [l_int32 * nc]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property nc as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.nc <> IntPtr.Zero Then 
	Dim _nc(1 -1) as Integer
	Marshal.Copy(Values.nc, _nc, 0, _nc.Length)
	Return _nc
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: mapping from intensity to lower k
'''  Loc: SRC/bilateral.h (128, 21)
'''  Org: [l_int32 * kindex]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property kindex as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.kindex <> IntPtr.Zero Then 
	Dim _kindex(1 -1) as Integer
	Marshal.Copy(Values.kindex, _kindex, 0, _kindex.Length)
	Return _kindex
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: mapping from intensity to fract k
'''  Loc: SRC/bilateral.h (129, 21)
'''  Org: [l_float32 * kfract]
'''  Msh: l_float32 * | 2:Float |  ... = Single
'''  </summary>
ReadOnly property kfract as Single()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.kfract <> IntPtr.Zero Then 
	Dim _kfract(1 -1) as Single
	Marshal.Copy(Values.kfract, _kfract, 0, _kfract.Length)
	Return _kfract
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: intermediate result images (PBC)
'''  Loc: SRC/bilateral.h (130, 21)
'''  Org: [struct Pixa * pixac]
'''  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
'''  </summary>
ReadOnly property pixac as Pixa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.pixac <> IntPtr.Zero Then 
		Return New Pixa(Values.pixac)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: lineptrs for pixac
'''  Loc: SRC/bilateral.h (131, 21)
'''  Org: [l_uint32 *** lineset]
'''  Msh: l_uint32 *** | 3:UInt | List (of List ( of List (of Byte()))) ... UInt => Byte[4]
'''  </summary>
ReadOnly property lineset as List (of List (of List (of Byte())))
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(4 - 1) As Byte
Dim _DataFin As new List (of List ( of List (of Byte())))
Marshal.Copy(Values.lineset, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(4 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.AddRange(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Bilateral
		public pixs as IntPtr
		public pixsc as IntPtr
		public reduction as Integer
		public spatial_stdev as Single
		public range_stdev as Single
		public spatial as IntPtr
		public range as IntPtr
		public minval as Integer
		public maxval as Integer
		public ncomps as Integer
		public nc as IntPtr
		public kindex as IntPtr
		public kfract as IntPtr
		public pixac as IntPtr
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> 		public lineset as IntPtr
	End Class
End Class


#End Region
#Region "SRC/bmp.h"
'  SRC/bmp.h (50, 8)
'  BMP file header
Public Class BMP_FileHeader
	Property Pointer as IntPtr
	Private Values as new Marshal_BMP_FileHeader



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: file type must be "BM"
'''  Loc: SRC/bmp.h (52, 20)
'''  Org: [l_int16 bfType]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfType as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfType
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: length of the file sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
'''  Loc: SRC/bmp.h (53, 20)
'''  Org: [l_int16 bfSize]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfSize as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfSize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: remainder of the bfSize field
'''  Loc: SRC/bmp.h (58, 20)
'''  Org: [l_int16 bfFill1]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfFill1 as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfFill1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (59, 20)
'''  Org: [l_int16 bfReserved1]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfReserved1 as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfReserved1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: don't care (set to 0)
'''  Loc: SRC/bmp.h (60, 20)
'''  Org: [l_int16 bfReserved2]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfReserved2 as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfReserved2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: offset from beginning of file
'''  Loc: SRC/bmp.h (61, 20)
'''  Org: [l_int16 bfOffBits]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfOffBits as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfOffBits
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: remainder of the bfOffBits field
'''  Loc: SRC/bmp.h (62, 20)
'''  Org: [l_int16 bfFill2]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property bfFill2 as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bfFill2
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_BMP_FileHeader
		public bfType as Short
		public bfSize as Short
		public bfFill1 as Short
		public bfReserved1 as Short
		public bfReserved2 as Short
		public bfOffBits as Short
		public bfFill2 as Short
	End Class
End Class


'  SRC/bmp.h (75, 8)
'  BMP info header
Public Class BMP_InfoHeader
	Property Pointer as IntPtr
	Private Values as new Marshal_BMP_InfoHeader



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: size of the BMP_InfoHeader struct
'''  Loc: SRC/bmp.h (77, 20)
'''  Org: [l_int32 biSize]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biSize as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biSize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: bitmap width in pixels
'''  Loc: SRC/bmp.h (78, 20)
'''  Org: [l_int32 biWidth]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biWidth as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biWidth
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: bitmap height in pixels
'''  Loc: SRC/bmp.h (79, 20)
'''  Org: [l_int32 biHeight]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biHeight as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biHeight
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of bitmap planes
'''  Loc: SRC/bmp.h (80, 20)
'''  Org: [l_int16 biPlanes]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property biPlanes as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biPlanes
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of bits per pixel
'''  Loc: SRC/bmp.h (81, 20)
'''  Org: [l_int16 biBitCount]
'''  Msh: l_int16 | 1:Short |
'''  </summary>
ReadOnly property biBitCount as Short
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biBitCount
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: compress format (0 == uncompressed)
'''  Loc: SRC/bmp.h (82, 20)
'''  Org: [l_int32 biCompression]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biCompression as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biCompression
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: size of image in bytes
'''  Loc: SRC/bmp.h (83, 20)
'''  Org: [l_int32 biSizeImage]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biSizeImage as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biSizeImage
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pixels per meter in x direction
'''  Loc: SRC/bmp.h (84, 20)
'''  Org: [l_int32 biXPelsPerMeter]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biXPelsPerMeter as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biXPelsPerMeter
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pixels per meter in y direction
'''  Loc: SRC/bmp.h (85, 20)
'''  Org: [l_int32 biYPelsPerMeter]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biYPelsPerMeter as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biYPelsPerMeter
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of colors used
'''  Loc: SRC/bmp.h (86, 20)
'''  Org: [l_int32 biClrUsed]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biClrUsed as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biClrUsed
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of important colors used
'''  Loc: SRC/bmp.h (87, 20)
'''  Org: [l_int32 biClrImportant]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property biClrImportant as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.biClrImportant
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_BMP_InfoHeader
		public biSize as Integer
		public biWidth as Integer
		public biHeight as Integer
		public biPlanes as Short
		public biBitCount as Short
		public biCompression as Integer
		public biSizeImage as Integer
		public biXPelsPerMeter as Integer
		public biYPelsPerMeter as Integer
		public biClrUsed as Integer
		public biClrImportant as Integer
	End Class
End Class


#End Region
#Region "SRC\colorquant1.c"
'  SRC\colorquant1.c (158, 8)
'  
Public Class ColorQuantCell
	Property Pointer as IntPtr
	Private Values as new Marshal_ColorQuantCell



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (160, 17)
'''  Org: [l_int32 rc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (160, 21)
'''  Org: [l_int32 gc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property gc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.gc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (160, 25)
'''  Org: [l_int32 bc]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bc as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bc
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (161, 17)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (162, 17)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (163, 17)
'''  Org: [l_int32 nleaves]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nleaves as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nleaves
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (164, 17)
'''  Org: [l_int32 bleaf]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bleaf as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bleaf
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_ColorQuantCell
		public rc as Integer
		public gc as Integer
		public bc as Integer
		public n as Integer
		public index as Integer
		public nleaves as Integer
		public bleaf as Integer
	End Class
End Class


'  SRC\colorquant1.c (190, 8)
'  
Public Class OctcubeQuantCell
	Property Pointer as IntPtr
	Private Values as new Marshal_OctcubeQuantCell



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (192, 16)
'''  Org: [l_float32 n]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property n as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (193, 16)
'''  Org: [l_int32 octindex]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property octindex as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.octindex
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (194, 16)
'''  Org: [l_int32 rcum]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rcum as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rcum
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (194, 22)
'''  Org: [l_int32 gcum]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property gcum as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.gcum
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (194, 28)
'''  Org: [l_int32 bcum]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bcum as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bcum
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (195, 16)
'''  Org: [l_int32 rval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (195, 22)
'''  Org: [l_int32 gval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property gval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.gval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (195, 28)
'''  Org: [l_int32 bval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bval
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_OctcubeQuantCell
		public n as Single
		public octindex as Integer
		public rcum as Integer
		public gcum as Integer
		public bcum as Integer
		public rval as Integer
		public gval as Integer
		public bval as Integer
	End Class
End Class


'  SRC\colorquant1.c (206, 8)
'  
Public Class L_OctcubePop
	Property Pointer as IntPtr
	Private Values as new Marshal_L_OctcubePop



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (208, 22)
'''  Org: [l_float32 npix]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property npix as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.npix
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (209, 22)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (210, 22)
'''  Org: [l_int32 rval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property rval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (211, 22)
'''  Org: [l_int32 gval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property gval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.gval
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant1.c (212, 22)
'''  Org: [l_int32 bval]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property bval as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bval
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_OctcubePop
		public npix as Single
		public index as Integer
		public rval as Integer
		public gval as Integer
		public bval as Integer
	End Class
End Class


#End Region
#Region "SRC\colorquant2.c"
'  SRC\colorquant2.c (178, 8)
'  
Public Class L_Box3d
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Box3d



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (180, 22)
'''  Org: [l_float32 sortparam]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property sortparam as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.sortparam
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (181, 22)
'''  Org: [l_int32 npix]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property npix as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.npix
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (182, 22)
'''  Org: [l_int32 vol]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property vol as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.vol
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (183, 22)
'''  Org: [l_int32 r1]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property r1 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.r1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (184, 22)
'''  Org: [l_int32 r2]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property r2 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.r2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (185, 22)
'''  Org: [l_int32 g1]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property g1 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.g1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (186, 22)
'''  Org: [l_int32 g2]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property g2 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.g2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (187, 22)
'''  Org: [l_int32 b1]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property b1 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.b1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\colorquant2.c (188, 22)
'''  Org: [l_int32 b2]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property b2 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.b2
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Box3d
		public sortparam as Single
		public npix as Integer
		public vol as Integer
		public r1 as Integer
		public r2 as Integer
		public g1 as Integer
		public g2 as Integer
		public b1 as Integer
		public b2 as Integer
	End Class
End Class


#End Region
#Region "SRC\conncomp.c"
'  SRC\conncomp.c (99, 8)
'  The struct FillSeg is used by the Heckbert seedfill algorithm to hold information about image segments that are waiting to be investigated. We use two Stacks, one to hold the FillSegs in use, and an auxiliary Stack as a reservoir to hold FillSegs for re-use.
Public Class FillSeg
	Property Pointer as IntPtr
	Private Values as new Marshal_FillSeg



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: left edge of run
'''  Loc: SRC\conncomp.c (101, 16)
'''  Org: [l_int32 xleft]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xleft as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xleft
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: right edge of run
'''  Loc: SRC\conncomp.c (102, 16)
'''  Org: [l_int32 xright]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property xright as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.xright
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: run y
'''  Loc: SRC\conncomp.c (103, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: parent segment direction: 1 above, -1 below)
'''  Loc: SRC\conncomp.c (104, 16)
'''  Org: [l_int32 dy]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property dy as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.dy
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_FillSeg
		public xleft as Integer
		public xright as Integer
		public y as Integer
		public dy as Integer
	End Class
End Class


#End Region
#Region "SRC\jbclass.c"
'  SRC\jbclass.c (236, 8)
'  
Public Class JbFindTemplatesState
	Property Pointer as IntPtr
	Private Values as new Marshal_JbFindTemplatesState



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (238, 22)
'''  Org: [JBCLASSER * classer]
'''  Msh: JBCLASSER * | 2:Struct |  | Typedef: JbClasser = JbClasser
'''  </summary>
ReadOnly property classer as JbClasser
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.classer <> IntPtr.Zero Then 
		Return New JbClasser(Values.classer)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (239, 22)
'''  Org: [l_int32 w]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property w as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.w
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (240, 22)
'''  Org: [l_int32 h]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property h as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.h
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (241, 22)
'''  Org: [l_int32 i]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property i as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.i
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (242, 22)
'''  Org: [L_DNA * dna]
'''  Msh: L_DNA * | 2:Struct |  | Typedef: L_Dna = L_Dna
'''  </summary>
ReadOnly property dna as L_Dna
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.dna <> IntPtr.Zero Then 
		Return New L_Dna(Values.dna)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jbclass.c (243, 22)
'''  Org: [l_int32 n]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property n as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.n
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_JbFindTemplatesState
		public classer as IntPtr
		public w as Integer
		public h as Integer
		public i as Integer
		public dna as IntPtr
		public n as Integer
	End Class
End Class


#End Region
#Region "SRC\jpegio.c"
'  SRC\jpegio.c (164, 8)
'  
Public Class callback_data
	Property Pointer as IntPtr
	Private Values as new Marshal_callback_data



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\jpegio.c (165, 15)
'''  Org: [jmp_buf jmpbuf]
'''  Msh: jmp_buf | 1:ConstantArray |
'''  </summary>
ReadOnly property jmpbuf as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.jmpbuf
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\jpegio.c (166, 15)
'''  Org: [l_uint8 * comment]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property comment as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.comment <> IntPtr.Zero Then 
	Dim _comment(1 -1) as Byte
	Marshal.Copy(Values.comment, _comment, 0, _comment.Length)
	Return _comment
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_callback_data
		public jmpbuf as Char
		public comment as IntPtr
	End Class
End Class


#End Region
#Region "SRC\maze.c"
'  SRC\maze.c (76, 8)
'  
Public Class MazeElement
	Property Pointer as IntPtr
	Private Values as new Marshal_MazeElement



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\maze.c (77, 16)
'''  Org: [l_float32 distance]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property distance as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.distance
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\maze.c (78, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property x as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.x
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\maze.c (79, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\maze.c (80, 16)
'''  Org: [l_uint32 val]
'''  Msh: l_uint32 | 1:UInt |
'''  </summary>
ReadOnly property val as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.val
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\maze.c (81, 16)
'''  Org: [l_int32 dir]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property dir as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.dir
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_MazeElement
		public distance as Single
		public x as Integer
		public y as Integer
		public val as UInteger
		public dir as Integer
	End Class
End Class


#End Region
#Region "SRC\partition.c"
'  SRC\partition.c (48, 8)
'  Partition element
Public Class PartitionElement
	Property Pointer as IntPtr
	Private Values as new Marshal_PartitionElement



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\partition.c (49, 16)
'''  Org: [l_float32 size]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property size as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\partition.c (50, 16)
'''  Org: [BOX * box]
'''  Msh: BOX * | 2:Struct |  | Typedef: Box = Box
'''  </summary>
ReadOnly property box as Box
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.box <> IntPtr.Zero Then 
		Return New Box(Values.box)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\partition.c (51, 16)
'''  Org: [BOXA * boxa]
'''  Msh: BOXA * | 2:Struct |  | Typedef: Boxa = Boxa
'''  </summary>
ReadOnly property boxa as Boxa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.boxa <> IntPtr.Zero Then 
		Return New Boxa(Values.boxa)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PartitionElement
		public size as Single
		public box as IntPtr
		public boxa as IntPtr
	End Class
End Class


#End Region
#Region "SRC\pix1.c"
'  SRC\pix1.c (218, 8)
'  Pix memory manager
Public Class PixMemoryManager
	Property Pointer as IntPtr
	Private Values as new Marshal_PixMemoryManager



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\pix1.c (220, 17)
'''  Org: [alloc_fn allocator]
'''  Msh: alloc_fn | 1:Pointer |
'''  </summary>
ReadOnly property allocator as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.allocator
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\pix1.c (221, 17)
'''  Org: [dealloc_fn deallocator]
'''  Msh: dealloc_fn | 1:Pointer |
'''  </summary>
ReadOnly property deallocator as IntPtr
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.deallocator
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixMemoryManager
		public allocator as IntPtr
		public deallocator as IntPtr
	End Class
End Class


#End Region
#Region "SRC\pixalloc.c"
'  SRC\pixalloc.c (113, 8)
'  Pix memory storage
Public Class PixMemoryStore
	Property Pointer as IntPtr
	Private Values as new Marshal_PixMemoryStore



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: Holds ptrs to allocated memory
'''  Loc: SRC\pixalloc.c (115, 22)
'''  Org: [struct L_Ptraa * paa]
'''  Msh: struct L_Ptraa * | 2:Struct |  | Typedef: L_Ptraa = L_Ptraa
'''  </summary>
ReadOnly property paa as L_Ptraa
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.paa <> IntPtr.Zero Then 
		Return New L_Ptraa(Values.paa)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Pix smaller than this (in bytes)
'''  Loc: SRC\pixalloc.c (116, 22)
'''  Org: [size_t minsize]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property minsize as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.minsize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Smallest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (118, 22)
'''  Org: [size_t smallest]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property smallest as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.smallest
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Larest mem (in bytes) alloc'd
'''  Loc: SRC\pixalloc.c (119, 22)
'''  Org: [size_t largest]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property largest as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.largest
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Size of allocated block w/ all chunks
'''  Loc: SRC\pixalloc.c (120, 22)
'''  Org: [size_t nbytes]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property nbytes as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nbytes
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Num of power-of-2 sizes pre-alloc'd
'''  Loc: SRC\pixalloc.c (121, 22)
'''  Org: [l_int32 nlevels]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property nlevels as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.nlevels
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Mem sizes at each power-of-2 level
'''  Loc: SRC\pixalloc.c (122, 22)
'''  Org: [size_t * sizes]
'''  Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
'''  </summary>
ReadOnly property sizes as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _sizes(1 -1) as Byte
Marshal.Copy(Values.sizes, _sizes, 0, _sizes.Length)
Return _sizes
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: Number of mem alloc'd at each size
'''  Loc: SRC\pixalloc.c (123, 22)
'''  Org: [l_int32 * allocarray]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property allocarray as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.allocarray <> IntPtr.Zero Then 
	Dim _allocarray(1 -1) as Integer
	Marshal.Copy(Values.allocarray, _allocarray, 0, _allocarray.Length)
	Return _allocarray
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr to allocated array
'''  Loc: SRC\pixalloc.c (124, 22)
'''  Org: [l_uint32 * baseptr]
'''  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
'''  </summary>
ReadOnly property baseptr as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _baseptr(1 -1) as Byte
Marshal.Copy(Values.baseptr, _baseptr, 0, _baseptr.Length)
Return _baseptr
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: ptr just beyond allocated memory
'''  Loc: SRC\pixalloc.c (125, 22)
'''  Org: [l_uint32 * maxptr]
'''  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
'''  </summary>
ReadOnly property maxptr as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _maxptr(1 -1) as Byte
Marshal.Copy(Values.maxptr, _maxptr, 0, _maxptr.Length)
Return _maxptr
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: array of ptrs to first chunk in size
'''  Loc: SRC\pixalloc.c (126, 22)
'''  Org: [l_uint32 ** firstptr]
'''  Msh: l_uint32 ** | 3:UInt | List (of Byte()) ... UInt nicht Marshalbar. Verwende 4 Bytes
'''  </summary>
ReadOnly property firstptr as List(Of Byte())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(4 - 1) As Byte
Dim _DataFin As New List(Of Byte())
Marshal.Copy(Values.firstptr, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(4 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: log: total # of pix used (by level)
'''  Loc: SRC\pixalloc.c (127, 22)
'''  Org: [l_int32 * memused]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property memused as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.memused <> IntPtr.Zero Then 
	Dim _memused(1 -1) as Integer
	Marshal.Copy(Values.memused, _memused, 0, _memused.Length)
	Return _memused
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: log: # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (128, 22)
'''  Org: [l_int32 * meminuse]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property meminuse as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.meminuse <> IntPtr.Zero Then 
	Dim _meminuse(1 -1) as Integer
	Marshal.Copy(Values.meminuse, _meminuse, 0, _meminuse.Length)
	Return _meminuse
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: log: max # of pix in use (by level)
'''  Loc: SRC\pixalloc.c (129, 22)
'''  Org: [l_int32 * memmax]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property memmax as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.memmax <> IntPtr.Zero Then 
	Dim _memmax(1 -1) as Integer
	Marshal.Copy(Values.memmax, _memmax, 0, _memmax.Length)
	Return _memmax
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: log: # of pix alloc'd because
'''  Loc: SRC\pixalloc.c (130, 22)
'''  Org: [l_int32 * memempty]
'''  Msh: l_int32 * | 2:Int | Integer() -  - Integer()
'''  </summary>
ReadOnly property memempty as Integer()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.memempty <> IntPtr.Zero Then 
	Dim _memempty(1 -1) as Integer
	Marshal.Copy(Values.memempty, _memempty, 0, _memempty.Length)
	Return _memempty
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: log: set to null if no logging
'''  Loc: SRC\pixalloc.c (132, 22)
'''  Org: [char * logfile]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property logfile as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.logfile <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.logfile)
End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixMemoryStore
		public paa as IntPtr
		public minsize as UInteger
		public smallest as UInteger
		public largest as UInteger
		public nbytes as UInteger
		public nlevels as Integer
		public sizes as IntPtr
		public allocarray as IntPtr
		public baseptr as IntPtr
		public maxptr as IntPtr
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=4)> 		public firstptr as IntPtr
		public memused as IntPtr
		public meminuse as IntPtr
		public memmax as IntPtr
		public memempty as IntPtr
		public logfile as IntPtr
	End Class
End Class


#End Region
#Region "SRC\pngio.c"
'  SRC\pngio.c (1293, 8)
'  A node in a linked list of memory buffers that hold I/O content
Public Class MemIOData
	Property Pointer as IntPtr
	Private Values as new Marshal_MemIOData



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: pointer to this node's I/O content
'''  Loc: SRC\pngio.c (1295, 17)
'''  Org: [char * m_Buffer]
'''  Msh: char * | 2:CharS |
'''  </summary>
ReadOnly property m_Buffer as String
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.m_Buffer <> IntPtr.Zero Then
	Return Marshal.PtrToStringAnsi(Values.m_Buffer)
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: number of I/O content bytes read or written
'''  Loc: SRC\pngio.c (1296, 17)
'''  Org: [l_int32 m_Count]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property m_Count as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.m_Count
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: allocated size of m_buffer
'''  Loc: SRC\pngio.c (1297, 17)
'''  Org: [l_int32 m_Size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property m_Size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.m_Size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pointer to the next node in the list
'''  Loc: SRC\pngio.c (1298, 24)
'''  Org: [struct MemIOData * m_Next]
'''  Msh: struct MemIOData * | 2:Struct |
'''  </summary>
ReadOnly property m_Next as MemIOData
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.m_Next <> IntPtr.Zero Then 
		Return New MemIOData(Values.m_Next)
	End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: pointer to the last node in the linked
'''  Loc: SRC\pngio.c (1300, 24)
'''  Org: [struct MemIOData * m_Last]
'''  Msh: struct MemIOData * | 2:Struct |
'''  </summary>
ReadOnly property m_Last as MemIOData
	Get
		Marshal.PtrToStructure (Pointer, Values)
			If Values.m_Last <> IntPtr.Zero Then 
		Return New MemIOData(Values.m_Last)
	End if
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_MemIOData
		public m_Buffer as IntPtr
		public m_Count as Integer
		public m_Size as Integer
		public m_Next as IntPtr
		public m_Last as IntPtr
	End Class
End Class


#End Region
#Region "SRC\seedfill.c"
'  SRC\seedfill.c (170, 8)
'  
Public Class L_Pixel
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Pixel



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\seedfill.c (172, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property x as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.x
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\seedfill.c (173, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Pixel
		public x as Integer
		public y as Integer
	End Class
End Class


#End Region
#Region "SRC\sel1.c"
'  SRC\sel1.c (152, 8)
'  
Public Class CompParameterMap
	Property Pointer as IntPtr
	Private Values as new Marshal_CompParameterMap



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (154, 14)
'''  Org: [l_int32 size]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property size as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (155, 14)
'''  Org: [l_int32 size1]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property size1 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (156, 14)
'''  Org: [l_int32 size2]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property size2 as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.size2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (157, 14)
'''  Org: [char [20] selnameh1]
'''  Msh: char [20] | 1:ConstantArray |
'''  </summary>
ReadOnly property selnameh1 as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.selnameh1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (158, 14)
'''  Org: [char [20] selnameh2]
'''  Msh: char [20] | 1:ConstantArray |
'''  </summary>
ReadOnly property selnameh2 as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.selnameh2
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (159, 14)
'''  Org: [char [20] selnamev1]
'''  Msh: char [20] | 1:ConstantArray |
'''  </summary>
ReadOnly property selnamev1 as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.selnamev1
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\sel1.c (160, 14)
'''  Org: [char [20] selnamev2]
'''  Msh: char [20] | 1:ConstantArray |
'''  </summary>
ReadOnly property selnamev2 as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.selnamev2
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_CompParameterMap
		public size as Integer
		public size1 as Integer
		public size2 as Integer
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		public selnameh1 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		public selnameh2 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		public selnamev1 as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		public selnamev2 as Char
	End Class
End Class


#End Region
#Region "SRC\stringcode.c"
'  SRC\stringcode.c (95, 8)
'  Associations between names and functions
Public Class L_GenAssoc
	Property Pointer as IntPtr
	Private Values as new Marshal_L_GenAssoc



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\stringcode.c (97, 14)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\stringcode.c (98, 14)
'''  Org: [char [16] type]
'''  Msh: char [16] | 1:ConstantArray |
'''  </summary>
ReadOnly property type as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.type
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\stringcode.c (99, 14)
'''  Org: [char [16] structname]
'''  Msh: char [16] | 1:ConstantArray |
'''  </summary>
ReadOnly property structname as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.structname
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\stringcode.c (100, 14)
'''  Org: [char [16] reader]
'''  Msh: char [16] | 1:ConstantArray |
'''  </summary>
ReadOnly property reader as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.reader
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\stringcode.c (101, 14)
'''  Org: [char [20] memreader]
'''  Msh: char [20] | 1:ConstantArray |
'''  </summary>
ReadOnly property memreader as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.memreader
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_GenAssoc
		public index as Integer
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		public type as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		public structname as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> 		public reader as Char
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=20)> 		public memreader as Char
	End Class
End Class


#End Region
#Region "SRC\tiffio.c"
'  SRC\tiffio.c (155, 8)
'  
Public Class tiff_transform
	Property Pointer as IntPtr
	Private Values as new Marshal_tiff_transform



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (156, 9)
'''  Org: [int vflip]
'''  Msh: int | 1:Int |
'''  </summary>
ReadOnly property vflip as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.vflip
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (157, 9)
'''  Org: [int hflip]
'''  Msh: int | 1:Int |
'''  </summary>
ReadOnly property hflip as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.hflip
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (158, 9)
'''  Org: [int rotate]
'''  Msh: int | 1:Int |
'''  </summary>
ReadOnly property rotate as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.rotate
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_tiff_transform
		public vflip as Integer
		public hflip as Integer
		public rotate as Integer
	End Class
End Class


'  SRC\tiffio.c (2174, 8)
'  Memory stream buffer used with TIFFClientOpen()
Public Class L_Memstream
	Property Pointer as IntPtr
	Private Values as new Marshal_L_Memstream



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2176, 16)
'''  Org: [l_uint8 * buffer]
'''  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
'''  </summary>
ReadOnly property buffer as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		If Values.buffer <> IntPtr.Zero Then 
	Dim _buffer(1 -1) as Byte
	Marshal.Copy(Values.buffer, _buffer, 0, _buffer.Length)
	Return _buffer
End if
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2178, 16)
'''  Org: [size_t bufsize]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property bufsize as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.bufsize
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2180, 16)
'''  Org: [size_t offset]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property offset as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.offset
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2181, 16)
'''  Org: [size_t hw]
'''  Msh: size_t | 1:UInt |
'''  </summary>
ReadOnly property hw as UInteger
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.hw
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2182, 16)
'''  Org: [l_uint8 ** poutdata]
'''  Msh: l_uint8 ** | 3:UChar | Byte() ... Pointer auf ein Byte-Array
'''  </summary>
ReadOnly property poutdata as List(Of Byte())
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _Data1(1 - 1) As Byte
Dim _DataFin As New List(Of Byte())
Marshal.Copy(Values.poutdata, _Data1, 0, _Data1.Length)
For Each eintrag In _Data1
	Dim _Data2(1 - 1) As Byte
	Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	 _DataFin.Add(_Data2)
Next
Return _DataFin
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\tiffio.c (2183, 16)
'''  Org: [size_t * poutsize]
'''  Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
'''  </summary>
ReadOnly property poutsize as Byte()
	Get
		Marshal.PtrToStructure (Pointer, Values)
		Dim _poutsize(1 -1) as Byte
Marshal.Copy(Values.poutsize, _poutsize, 0, _poutsize.Length)
Return _poutsize
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Memstream
		public buffer as IntPtr
		public bufsize as UInteger
		public offset as UInteger
		public hw as UInteger
		public poutdata as IntPtr
		public poutsize as IntPtr
	End Class
End Class


#End Region
#Region "SRC\watershed.c"
'  SRC\watershed.c (124, 8)
'  New pixel coordinates
Public Class L_NewPixel
	Property Pointer as IntPtr
	Private Values as new Marshal_L_NewPixel



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: x coordinate
'''  Loc: SRC\watershed.c (126, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property x as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.x
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y coordinate
'''  Loc: SRC\watershed.c (127, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_NewPixel
		public x as Integer
		public y as Integer
	End Class
End Class


'  SRC\watershed.c (132, 8)
'  Wartshed pixel
Public Class L_WSPixel
	Property Pointer as IntPtr
	Private Values as new Marshal_L_WSPixel



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: pixel value
'''  Loc: SRC\watershed.c (134, 16)
'''  Org: [l_float32 val]
'''  Msh: l_float32 | 1:Float |
'''  </summary>
ReadOnly property val as Single
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.val
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: x coordinate
'''  Loc: SRC\watershed.c (135, 16)
'''  Org: [l_int32 x]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property x as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.x
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: y coordinate
'''  Loc: SRC\watershed.c (136, 16)
'''  Org: [l_int32 y]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property y as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.y
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: label for set to which pixel belongs
'''  Loc: SRC\watershed.c (137, 16)
'''  Org: [l_int32 index]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property index as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.index
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_WSPixel
		public val as Single
		public x as Integer
		public y as Integer
		public index as Integer
	End Class
End Class


#End Region
#Region "SRC\writefile.c"
'  SRC\writefile.c (139, 8)
'  
Public Class ExtensionMap
	Property Pointer as IntPtr
	Private Values as new Marshal_ExtensionMap



	Sub New (PTR as IntPtr)
		If PTR = IntPtr.Zero Then Exit Sub
		Pointer = PTR
		Marshal.PtrToStructure (Pointer, Values)
	End Sub

'''  <summary>
'''  Brf: 
'''  Loc: SRC\writefile.c (141, 14)
'''  Org: [char [8] extension]
'''  Msh: char [8] | 1:ConstantArray |
'''  </summary>
ReadOnly property extension as Char
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.extension
		Return nothing
	End Get
End Property


'''  <summary>
'''  Brf: 
'''  Loc: SRC\writefile.c (142, 14)
'''  Org: [l_int32 format]
'''  Msh: l_int32 | 1:Int |
'''  </summary>
ReadOnly property format as Integer
	Get
		Marshal.PtrToStructure (Pointer, Values)
				Return Values.format
		Return nothing
	End Get
End Property


	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_ExtensionMap
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> 		public extension as Char
		public format as Integer
	End Class
End Class


#End Region
