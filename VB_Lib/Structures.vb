Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports LeptonicaSharp 
Imports System

#Region"environ.h"
' ./environ.h (308, 8)
'''<summary>
'''Timing struct
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_WallTimer.txt" language="C" title="./environ.h (308, 8)"/>
'''</example>
Public Class L_WallTimer
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_WallTimer
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./environ.h (309, 14)
''' Org: [l_int32 start_sec]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property start_sec as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.start_sec
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./environ.h (310, 14)
''' Org: [l_int32 start_usec]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property start_usec as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.start_usec
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./environ.h (311, 14)
''' Org: [l_int32 stop_sec]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property stop_sec as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.stop_sec
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./environ.h (312, 14)
''' Org: [l_int32 stop_usec]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property stop_usec as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.stop_usec
	     return Nothing
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
#Region"array.h"
' ./array.h (59, 8)
'''<summary>
'''Number array: an array of floats
'''</summary>
'''<example>
'''<code source="CSource\Struct_Numa.txt" language="C" title="./array.h (59, 8)"/>
'''</example>
Public Class Numa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Numa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.numaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated number array
''' </summary>
''' <remarks>
''' Loc: ./array.h (61, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of numbers saved
''' </summary>
''' <remarks>
''' Loc: ./array.h (62, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./array.h (63, 22)
''' Org: [l_int32 refcount]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refcount as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x value assigned to array[0]
''' </summary>
''' <remarks>
''' Loc: ./array.h (64, 22)
''' Org: [l_float32 startx]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property startx as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.startx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' change in x value as i --> i + 1
''' </summary>
''' <remarks>
''' Loc: ./array.h (65, 22)
''' Org: [l_float32 delx]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property delx as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.delx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number array
''' </summary>
''' <remarks>
''' Loc: ./array.h (66, 22)
''' Org: [l_float32 * array]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property array as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.n -1) as Single
	   Marshal.Copy(Values.array, _array, 0, _array.Length)
	   return _array
	End if
	     return Nothing
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


' ./array.h (71, 8)
'''<summary>
'''Array of number arrays
'''</summary>
'''<example>
'''<code source="CSource\Struct_Numaa.txt" language="C" title="./array.h (71, 8)"/>
'''</example>
Public Class Numaa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Numaa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.numaaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./array.h (73, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of Numa saved
''' </summary>
''' <remarks>
''' Loc: ./array.h (74, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of Numa
''' </summary>
''' <remarks>
''' Loc: ./array.h (75, 22)
''' Org: [struct Numa ** numa]
''' Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
''' </remarks>
	readonly property numa as List(of Numa)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.numa <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Numa)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.numa, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Numa(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Numaa
		public nalloc as Integer
		public n as Integer
		public numa as IntPtr
	End Class
End Class


' ./array.h (83, 8)
'''<summary>
'''Double number array: an array of doubles
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Dna.txt" language="C" title="./array.h (83, 8)"/>
'''</example>
Public Class L_Dna
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Dna
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.l_dnaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated number array
''' </summary>
''' <remarks>
''' Loc: ./array.h (85, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of numbers saved
''' </summary>
''' <remarks>
''' Loc: ./array.h (86, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./array.h (87, 22)
''' Org: [l_int32 refcount]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refcount as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x value assigned to array[0]
''' </summary>
''' <remarks>
''' Loc: ./array.h (88, 22)
''' Org: [l_float64 startx]
''' Msh: l_float64 | 1:Double |
''' </remarks>
	readonly property startx as Double
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.startx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' change in x value as i --> i + 1
''' </summary>
''' <remarks>
''' Loc: ./array.h (89, 22)
''' Org: [l_float64 delx]
''' Msh: l_float64 | 1:Double |
''' </remarks>
	readonly property delx as Double
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.delx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number array
''' </summary>
''' <remarks>
''' Loc: ./array.h (90, 22)
''' Org: [l_float64 * array]
''' Msh: l_float64 * | 2:Double |
''' </remarks>
	readonly property array as Double()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.n -1) as Double
	   Marshal.Copy(Values.array, _array, 0, _array.Length)
	   return _array
	End if
	     return Nothing
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


' ./array.h (95, 8)
'''<summary>
'''Array of double number arrays
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Dnaa.txt" language="C" title="./array.h (95, 8)"/>
'''</example>
Public Class L_Dnaa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Dnaa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.l_dnaaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./array.h (97, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of L_Dna saved
''' </summary>
''' <remarks>
''' Loc: ./array.h (98, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of L_Dna
''' </summary>
''' <remarks>
''' Loc: ./array.h (99, 22)
''' Org: [struct L_Dna ** dna]
''' Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property dna as List(of L_Dna)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.dna <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of L_Dna)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.dna, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New L_Dna(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Dnaa
		public nalloc as Integer
		public n as Integer
		public dna as IntPtr
	End Class
End Class


' ./array.h (104, 8)
'''<summary>
'''A hash table of Dnas
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_DnaHash.txt" language="C" title="./array.h (104, 8)"/>
'''</example>
Public Class L_DnaHash
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_DnaHash
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.l_dnaHashDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./array.h (106, 22)
''' Org: [l_int32 nbuckets]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nbuckets as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nbuckets
	     return Nothing
	 End Get
	End Property

''' <summary>
''' initial size of each dna that is made
''' </summary>
''' <remarks>
''' Loc: ./array.h (107, 22)
''' Org: [l_int32 initsize]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property initsize as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.initsize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of L_Dna
''' </summary>
''' <remarks>
''' Loc: ./array.h (108, 22)
''' Org: [struct L_Dna ** dna]
''' Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property dna as List(of L_Dna)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.dna <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of L_Dna)
	   Dim LSTPTR (1 - 1) As IntPtr
	   Marshal.Copy(Values.dna, LSTPTR, 0, 1)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New L_Dna(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_DnaHash
		public nbuckets as Integer
		public initsize as Integer
		public dna as IntPtr
	End Class
End Class


' ./array.h (116, 8)
'''<summary>
'''String array: an array of C strings
'''</summary>
'''<example>
'''<code source="CSource\Struct_Sarray.txt" language="C" title="./array.h (116, 8)"/>
'''</example>
Public Class Sarray
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Sarray
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.sarrayDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./array.h (118, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of strings allocated
''' </summary>
''' <remarks>
''' Loc: ./array.h (119, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./array.h (120, 22)
''' Org: [l_int32 refcount]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refcount as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' string array
''' </summary>
''' <remarks>
''' Loc: ./array.h (121, 22)
''' Org: [char ** array]
''' Msh: char ** | 3:CharS | String()
''' </remarks>
	readonly property array as String()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : CharS
	Dim LSTRET As New List(Of String)
	Dim LSTPTR(Values.n - 1) As IntPtr
	Marshal.Copy(Values.array, LSTPTR, 0, Values.n)
	For Each Entry As IntPtr In LSTPTR
	   LSTRET.Add(Marshal.PtrToStringAnsi(Entry))
	Next
	return LSTRET.ToArray
	     return Nothing
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


' ./array.h (126, 8)
'''<summary>
'''Byte array (analogous to C++ "string")
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Bytea.txt" language="C" title="./array.h (126, 8)"/>
'''</example>
Public Class L_Bytea
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Bytea
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.l_byteaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of bytes allocated in data array
''' </summary>
''' <remarks>
''' Loc: ./array.h (128, 22)
''' Org: [size_t nalloc]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property nalloc as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of bytes presently used
''' </summary>
''' <remarks>
''' Loc: ./array.h (129, 22)
''' Org: [size_t size]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property size as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./array.h (130, 22)
''' Org: [l_int32 refcount]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refcount as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' data array
''' </summary>
''' <remarks>
''' Loc: ./array.h (131, 22)
''' Org: [l_uint8 * data]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property data as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data <> IntPtr.Zero Then 
	   Dim _data(Values.size -1) as Byte
	   Marshal.Copy(Values.data, _data, 0, _data.Length)
	   return _data
	End if
	     return Nothing
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
#Region"bbuffer.h"
' ./bbuffer.h (50, 8)
'''<summary>
'''Expandable byte buffer for memory read/write operations
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_ByteBuffer.txt" language="C" title="./bbuffer.h (50, 8)"/>
'''</example>
Public Class L_ByteBuffer
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_ByteBuffer
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated byte array
''' </summary>
''' <remarks>
''' Loc: ./bbuffer.h (52, 18)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of bytes read into to the array
''' </summary>
''' <remarks>
''' Loc: ./bbuffer.h (53, 18)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of bytes written from the array
''' </summary>
''' <remarks>
''' Loc: ./bbuffer.h (54, 18)
''' Org: [l_int32 nwritten]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nwritten as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nwritten
	     return Nothing
	 End Get
	End Property

''' <summary>
''' byte array
''' </summary>
''' <remarks>
''' Loc: ./bbuffer.h (55, 18)
''' Org: [l_uint8 * array]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property array as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.n -1) as Byte
	   Marshal.Copy(Values.array, _array, 0, _array.Length)
	   return _array
	End if
	     return Nothing
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
#Region"heap.h"
' ./heap.h (77, 8)
'''<summary>
'''Heap of arbitrary void* data
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Heap.txt" language="C" title="./heap.h (77, 8)"/>
'''</example>
Public Class L_Heap
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Heap
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./heap.h (79, 18)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of elements stored in the heap
''' </summary>
''' <remarks>
''' Loc: ./heap.h (80, 18)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr array
''' </summary>
''' <remarks>
''' Loc: ./heap.h (81, 18)
''' Org: [void ** array]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property array as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.n) as IntPtr
	   Marshal.Copy(Values.array, _array, 0, Values.n)
	   return _array
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' L_SORT_INCREASING or L_SORT_DECREASING
''' </summary>
''' <remarks>
''' Loc: ./heap.h (82, 18)
''' Org: [l_int32 direction]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property direction as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.direction
	     return Nothing
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
#Region"list.h"
' ./list.h (61, 8)
'''<summary>
'''list.h
'''</summary>
'''<example>
'''<code source="CSource\Struct_DoubleLinkedList.txt" language="C" title="./list.h (61, 8)"/>
'''</example>
Public Class DoubleLinkedList
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_DoubleLinkedList
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./list.h (63, 33)
''' Org: [struct DoubleLinkedList * prev]
''' Msh: struct DoubleLinkedList * | 2:Struct |
''' </remarks>
	readonly property prev as DoubleLinkedList
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.prev <> IntPtr.Zero Then 
	   return New DoubleLinkedList (Values.prev)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./list.h (64, 33)
''' Org: [struct DoubleLinkedList * next]
''' Msh: struct DoubleLinkedList * | 2:Struct |
''' </remarks>
	readonly property _next_ as DoubleLinkedList
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values._next_ <> IntPtr.Zero Then 
	   return New DoubleLinkedList (Values._next_)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./list.h (65, 33)
''' Org: [void * data]
''' Msh: void * | 2:Void | Object -  - IntPtr
''' </remarks>
	readonly property data as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data <> IntPtr.Zero Then
	   return Values.data
	End if
	     return Nothing
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
#Region"ptra.h"
' ./ptra.h (51, 8)
'''<summary>
'''Generic pointer array
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Ptra.txt" language="C" title="./ptra.h (51, 8)"/>
'''</example>
Public Class L_Ptra
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Ptra
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (53, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' greatest valid index
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (54, 22)
''' Org: [l_int32 imax]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property imax as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.imax
	     return Nothing
	 End Get
	End Property

''' <summary>
''' actual number of stored elements
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (55, 22)
''' Org: [l_int32 nactual]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nactual as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nactual
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr array
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (56, 22)
''' Org: [void ** array]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property array as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.nactual) as IntPtr
	   Marshal.Copy(Values.array, _array, 0, Values.nactual)
	   return _array
	End if
	     return Nothing
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


' ./ptra.h (62, 8)
'''<summary>
'''Array of generic pointer arrays
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Ptraa.txt" language="C" title="./ptra.h (62, 8)"/>
'''</example>
Public Class L_Ptraa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Ptraa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (64, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of ptra
''' </summary>
''' <remarks>
''' Loc: ./ptra.h (65, 22)
''' Org: [struct L_Ptra ** ptra]
''' Msh: struct L_Ptra ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Ptra = L_Ptra
''' </remarks>
	readonly property ptra as List(of L_Ptra)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.ptra <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of L_Ptra)
	   Dim LSTPTR (Values.nalloc - 1) As IntPtr
	   Marshal.Copy(Values.ptra, LSTPTR, 0, Values.nalloc)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New L_Ptra(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Ptraa
		public nalloc as Integer
		public ptra as IntPtr
	End Class
End Class


#End Region
#Region"queue.h"
' ./queue.h (64, 8)
'''<summary>
'''Expandable pointer queue for arbitrary void* data
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Queue.txt" language="C" title="./queue.h (64, 8)"/>
'''</example>
Public Class L_Queue
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Queue
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./queue.h (66, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' location of head (in ptrs) from the
''' </summary>
''' <remarks>
''' Loc: ./queue.h (67, 22)
''' Org: [l_int32 nhead]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nhead as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nhead
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of elements stored in the queue
''' </summary>
''' <remarks>
''' Loc: ./queue.h (69, 22)
''' Org: [l_int32 nelem]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nelem as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nelem
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr array
''' </summary>
''' <remarks>
''' Loc: ./queue.h (70, 22)
''' Org: [void ** array]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property array as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.nelem) as IntPtr
	   Marshal.Copy(Values.array, _array, 0, Values.nelem)
	   return _array
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' auxiliary stack
''' </summary>
''' <remarks>
''' Loc: ./queue.h (71, 22)
''' Org: [struct L_Stack * stack]
''' Msh: struct L_Stack * | 2:Struct |
''' </remarks>
	readonly property stack as L_Stack
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.stack <> IntPtr.Zero Then 
	   return New L_Stack (Values.stack)
	End if
	     return Nothing
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
#Region"rbtree.h"
' ./rbtree.h (61, 7)
'''<summary>
'''Storage for keys and values for red-black trees, maps and sets. Note: (1) Keys and values of the valid key types are all 64-bit (2) (void *) can be used for values but not for keys.
'''</summary>
'''<example>
'''<code source="CSource\Struct_Rb_Type.txt" language="C" title="./rbtree.h (61, 7)"/>
'''</example>
Public Class Rb_Type
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Rb_Type
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./rbtree.h (62, 16)
''' Org: [l_int64 itype]
''' Msh: l_int64 | 1:LongLong |
''' </remarks>
	readonly property itype as Long
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.itype
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (63, 16)
''' Org: [l_uint64 utype]
''' Msh: l_uint64 | 1:ULongLong |
''' </remarks>
	readonly property utype as ULong
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.utype
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (64, 16)
''' Org: [l_float64 ftype]
''' Msh: l_float64 | 1:Double |
''' </remarks>
	readonly property ftype as Double
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ftype
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (65, 16)
''' Org: [void * ptype]
''' Msh: void * | 2:Void | Object -  - IntPtr
''' </remarks>
	readonly property ptype as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.ptype <> IntPtr.Zero Then
	   return Values.ptype
	End if
	     return Nothing
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


' ./rbtree.h (69, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Rbtree.txt" language="C" title="./rbtree.h (69, 8)"/>
'''</example>
Public Class L_Rbtree
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Rbtree
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.l_rbtreeDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./rbtree.h (70, 28)
''' Org: [struct L_Rbtree_Node * root]
''' Msh: struct L_Rbtree_Node * | 2:Struct |
''' </remarks>
	readonly property root as L_Rbtree_Node
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.root <> IntPtr.Zero Then 
	   return New L_Rbtree_Node (Values.root)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (71, 28)
''' Org: [l_int32 keytype]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property keytype as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.keytype
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Rbtree
		public root as IntPtr
		public keytype as Integer
	End Class
End Class


' ./rbtree.h (77, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Rbtree_Node.txt" language="C" title="./rbtree.h (77, 8)"/>
'''</example>
Public Class L_Rbtree_Node
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Rbtree_Node
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: ./rbtree.h (78, 28)
''' Org: [union Rb_Type key]
''' Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
''' </remarks>
	readonly property key as Rb_Type
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.key
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (79, 28)
''' Org: [union Rb_Type value]
''' Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
''' </remarks>
	readonly property value as Rb_Type
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.value
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (80, 28)
''' Org: [struct L_Rbtree_Node * left]
''' Msh: struct L_Rbtree_Node * | 2:Struct |
''' </remarks>
	readonly property left as L_Rbtree_Node
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.left <> IntPtr.Zero Then 
	   return New L_Rbtree_Node (Values.left)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (81, 28)
''' Org: [struct L_Rbtree_Node * right]
''' Msh: struct L_Rbtree_Node * | 2:Struct |
''' </remarks>
	readonly property right as L_Rbtree_Node
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.right <> IntPtr.Zero Then 
	   return New L_Rbtree_Node (Values.right)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (82, 28)
''' Org: [struct L_Rbtree_Node * parent]
''' Msh: struct L_Rbtree_Node * | 2:Struct |
''' </remarks>
	readonly property parent as L_Rbtree_Node
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.parent <> IntPtr.Zero Then 
	   return New L_Rbtree_Node (Values.parent)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: ./rbtree.h (83, 28)
''' Org: [l_int32 color]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property color as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.color
	     return Nothing
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
#Region"stack.h"
' ./stack.h (59, 8)
'''<summary>
'''Expandable pointer stack for arbitrary void* data. Note that array[n] is the first null ptr in the array
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Stack.txt" language="C" title="./stack.h (59, 8)"/>
'''</example>
Public Class L_Stack
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Stack
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of ptr array
''' </summary>
''' <remarks>
''' Loc: ./stack.h (61, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of stored elements
''' </summary>
''' <remarks>
''' Loc: ./stack.h (62, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr array
''' </summary>
''' <remarks>
''' Loc: ./stack.h (63, 22)
''' Org: [void ** array]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property array as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.array <> IntPtr.Zero Then 
	   Dim _array(Values.n) as IntPtr
	   Marshal.Copy(Values.array, _array, 0, Values.n)
	   return _array
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' auxiliary stack
''' </summary>
''' <remarks>
''' Loc: ./stack.h (64, 22)
''' Org: [struct L_Stack * auxstack]
''' Msh: struct L_Stack * | 2:Struct |
''' </remarks>
	readonly property auxstack as L_Stack
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.auxstack <> IntPtr.Zero Then 
	   return New L_Stack (Values.auxstack)
	End if
	     return Nothing
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
#Region"bmf.h"
' ./bmf.h (45, 8)
'''<summary>
'''Data structure to hold bitmap fonts and related data
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Bmf.txt" language="C" title="./bmf.h (45, 8)"/>
'''</example>
Public Class L_Bmf
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Bmf
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' pixa of bitmaps for 93 characters
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (47, 19)
''' Org: [struct Pixa * pixa]
''' Msh: struct Pixa * | 2:Struct |
''' </remarks>
	readonly property pixa as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixa <> IntPtr.Zero Then 
	   return New Pixa (Values.pixa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' font size (in points at 300 ppi)
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (48, 19)
''' Org: [l_int32 size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' directory containing font bitmaps
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (49, 19)
''' Org: [char * directory]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property directory as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.directory <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.directory)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' baseline offset for ascii 33 - 57
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (50, 19)
''' Org: [l_int32 baseline1]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property baseline1 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.baseline1
	     return Nothing
	 End Get
	End Property

''' <summary>
''' baseline offset for ascii 58 - 91
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (51, 19)
''' Org: [l_int32 baseline2]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property baseline2 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.baseline2
	     return Nothing
	 End Get
	End Property

''' <summary>
''' baseline offset for ascii 93 - 126
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (52, 19)
''' Org: [l_int32 baseline3]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property baseline3 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.baseline3
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max height of line of chars
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (53, 19)
''' Org: [l_int32 lineheight]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property lineheight as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.lineheight
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pixel dist between char bitmaps
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (54, 19)
''' Org: [l_int32 kernwidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property kernwidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.kernwidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pixel dist between word bitmaps
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (55, 19)
''' Org: [l_int32 spacewidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property spacewidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.spacewidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' extra vertical space between text lines
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (56, 19)
''' Org: [l_int32 vertlinesep]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property vertlinesep as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.vertlinesep
	     return Nothing
	 End Get
	End Property

''' <summary>
''' table mapping ascii --> font index
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (57, 19)
''' Org: [l_int32 * fonttab]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property fonttab as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.fonttab <> IntPtr.Zero Then 
	   Dim _fonttab(Values.size -1) as Integer
	   Marshal.Copy(Values.fonttab, _fonttab, 0, _fonttab.Length)
	   return _fonttab
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' table mapping ascii --> baseline offset
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (58, 19)
''' Org: [l_int32 * baselinetab]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property baselinetab as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.baselinetab <> IntPtr.Zero Then 
	   Dim _baselinetab(Values.size -1) as Integer
	   Marshal.Copy(Values.baselinetab, _baselinetab, 0, _baselinetab.Length)
	   return _baselinetab
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' table mapping ascii --> char width
''' </summary>
''' <remarks>
''' Loc: ./bmf.h (59, 19)
''' Org: [l_int32 * widthtab]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property widthtab as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.widthtab <> IntPtr.Zero Then 
	   Dim _widthtab(Values.size -1) as Integer
	   Marshal.Copy(Values.widthtab, _widthtab, 0, _widthtab.Length)
	   return _widthtab
	End if
	     return Nothing
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
#Region"ccbord.h"
' ./ccbord.h (91, 8)
'''<summary>
'''CCBord contains:
'''</summary>
'''<example>
'''<code source="CSource\Struct_CCBord.txt" language="C" title="./ccbord.h (91, 8)"/>
'''</example>
Public Class CCBord
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_CCBord
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' component bitmap (min size)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (93, 26)
''' Org: [struct Pix * pix]
''' Msh: struct Pix * | 2:Struct |
''' </remarks>
	readonly property pix as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pix <> IntPtr.Zero Then 
	   return New Pix (Values.pix)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' regions of each closed curve
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (94, 26)
''' Org: [struct Boxa * boxa]
''' Msh: struct Boxa * | 2:Struct |
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' initial border pixel locations
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (95, 26)
''' Org: [struct Pta * start]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property start as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.start <> IntPtr.Zero Then 
	   return New Pta (Values.start)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of handles start at 1
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (96, 26)
''' Org: [l_int32 refcount]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refcount as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptaa of chain pixels (local)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (97, 26)
''' Org: [struct Ptaa * local]
''' Msh: struct Ptaa * | 2:Struct |
''' </remarks>
	readonly property local as Ptaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.local <> IntPtr.Zero Then 
	   return New Ptaa (Values.local)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptaa of chain pixels (global)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (98, 26)
''' Org: [struct Ptaa * global]
''' Msh: struct Ptaa * | 2:Struct |
''' </remarks>
	readonly property _global_ as Ptaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values._global_ <> IntPtr.Zero Then 
	   return New Ptaa (Values._global_)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' numaa of chain code (step dir)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (99, 26)
''' Org: [struct Numaa * step]
''' Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
''' </remarks>
	readonly property _step_ as Numaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values._step_ <> IntPtr.Zero Then 
	   return New Numaa (Values._step_)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pta of single chain (local)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (100, 26)
''' Org: [struct Pta * splocal]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property splocal as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.splocal <> IntPtr.Zero Then 
	   return New Pta (Values.splocal)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pta of single chain (global)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (101, 26)
''' Org: [struct Pta * spglobal]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property spglobal as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.spglobal <> IntPtr.Zero Then 
	   return New Pta (Values.spglobal)
	End if
	     return Nothing
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


' ./ccbord.h (106, 8)
'''<summary>
'''Array of CCBord
'''</summary>
'''<example>
'''<code source="CSource\Struct_CCBorda.txt" language="C" title="./ccbord.h (106, 8)"/>
'''</example>
Public Class CCBorda
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_CCBorda
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' input pix (may be null)
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (108, 26)
''' Org: [struct Pix * pix]
''' Msh: struct Pix * | 2:Struct |
''' </remarks>
	readonly property pix as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pix <> IntPtr.Zero Then 
	   return New Pix (Values.pix)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' width of pix
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (109, 26)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height of pix
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (110, 26)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of ccbord in ptr array
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (111, 26)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of ccbord ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (112, 26)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ccb ptr array
''' </summary>
''' <remarks>
''' Loc: ./ccbord.h (113, 26)
''' Org: [struct CCBord ** ccb]
''' Msh: struct CCBord ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: CCBord = CCBord
''' </remarks>
	readonly property ccb as List(of CCBord)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.ccb <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of CCBord)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.ccb, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New CCBord(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
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
#Region"dewarp.h"
' ./dewarp.h (113, 8)
'''<summary>
'''Data structure to hold a number of Dewarp
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Dewarpa.txt" language="C" title="./dewarp.h (113, 8)"/>
'''</example>
Public Class L_Dewarpa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Dewarpa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of dewarp ptr array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (115, 24)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum page number in array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (116, 24)
''' Org: [l_int32 maxpage]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxpage as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxpage
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of ptrs to page dewarp
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (117, 24)
''' Org: [struct L_Dewarp ** dewarp]
''' Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
''' </remarks>
	readonly property dewarp as List(of L_Dewarp)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.dewarp <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of L_Dewarp)
	   Dim LSTPTR (Values.nalloc - 1) As IntPtr
	   Marshal.Copy(Values.dewarp, LSTPTR, 0, Values.nalloc)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New L_Dewarp(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of ptrs to cached dewarps
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (118, 24)
''' Org: [struct L_Dewarp ** dewarpcache]
''' Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
''' </remarks>
	readonly property dewarpcache as List(of L_Dewarp)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.dewarpcache <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of L_Dewarp)
	   Dim LSTPTR (Values.nalloc - 1) As IntPtr
	   Marshal.Copy(Values.dewarpcache, LSTPTR, 0, Values.nalloc)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New L_Dewarp(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' list of page numbers for pages
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (119, 24)
''' Org: [struct Numa * namodels]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property namodels as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.namodels <> IntPtr.Zero Then 
	   return New Numa (Values.namodels)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' list of page numbers with either
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (121, 24)
''' Org: [struct Numa * napages]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property napages as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.napages <> IntPtr.Zero Then 
	   return New Numa (Values.napages)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reduction factor of input: 1 or 2
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (123, 24)
''' Org: [l_int32 redfactor]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property redfactor as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.redfactor
	     return Nothing
	 End Get
	End Property

''' <summary>
''' disparity arrays sampling factor
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (124, 24)
''' Org: [l_int32 sampling]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sampling as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sampling
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min number of long lines required
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (125, 24)
''' Org: [l_int32 minlines]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minlines as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minlines
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max distance for getting ref page
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (126, 24)
''' Org: [l_int32 maxdist]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxdist as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxdist
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum abs line curvature,
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (127, 24)
''' Org: [l_int32 max_linecurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_linecurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_linecurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' minimum abs diff line
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (129, 24)
''' Org: [l_int32 min_diff_linecurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property min_diff_linecurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.min_diff_linecurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum abs diff line
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (131, 24)
''' Org: [l_int32 max_diff_linecurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_diff_linecurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_diff_linecurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum abs left or right edge
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (133, 24)
''' Org: [l_int32 max_edgeslope]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_edgeslope as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_edgeslope
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum abs left or right edge
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (135, 24)
''' Org: [l_int32 max_edgecurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_edgecurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_edgecurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' maximum abs diff left-right
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (137, 24)
''' Org: [l_int32 max_diff_edgecurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_diff_edgecurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_diff_edgecurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' use both disparity arrays if
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (139, 24)
''' Org: [l_int32 useboth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property useboth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.useboth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' if there are multiple columns,
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (141, 24)
''' Org: [l_int32 check_columns]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property check_columns as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.check_columns
	     return Nothing
	 End Get
	End Property

''' <summary>
''' invalid models have been removed
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (144, 24)
''' Org: [l_int32 modelsready]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property modelsready as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.modelsready
	     return Nothing
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


' ./dewarp.h (151, 8)
'''<summary>
'''Data structure for a single dewarp
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Dewarp.txt" language="C" title="./dewarp.h (151, 8)"/>
'''</example>
Public Class L_Dewarp
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Dewarp
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' ptr to parent (not owned)
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (153, 24)
''' Org: [struct L_Dewarpa * dewa]
''' Msh: struct L_Dewarpa * | 2:Struct |  | Typedef: L_Dewarpa = L_Dewarpa
''' </remarks>
	readonly property dewa as L_Dewarpa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.dewa <> IntPtr.Zero Then 
	   return New L_Dewarpa (Values.dewa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' source pix, 1 bpp
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (154, 24)
''' Org: [struct Pix * pixs]
''' Msh: struct Pix * | 2:Struct |
''' </remarks>
	readonly property pixs as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixs <> IntPtr.Zero Then 
	   return New Pix (Values.pixs)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sampled vert disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (155, 24)
''' Org: [struct FPix * sampvdispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property sampvdispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.sampvdispar <> IntPtr.Zero Then 
	   return New FPix (Values.sampvdispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sampled horiz disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (156, 24)
''' Org: [struct FPix * samphdispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property samphdispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.samphdispar <> IntPtr.Zero Then 
	   return New FPix (Values.samphdispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sampled slope h-disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (157, 24)
''' Org: [struct FPix * sampydispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property sampydispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.sampydispar <> IntPtr.Zero Then 
	   return New FPix (Values.sampydispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' full vert disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (158, 24)
''' Org: [struct FPix * fullvdispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property fullvdispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.fullvdispar <> IntPtr.Zero Then 
	   return New FPix (Values.fullvdispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' full horiz disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (159, 24)
''' Org: [struct FPix * fullhdispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property fullhdispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.fullhdispar <> IntPtr.Zero Then 
	   return New FPix (Values.fullhdispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' full slope h-disparity array
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (160, 24)
''' Org: [struct FPix * fullydispar]
''' Msh: struct FPix * | 2:Struct |
''' </remarks>
	readonly property fullydispar as FPix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.fullydispar <> IntPtr.Zero Then 
	   return New FPix (Values.fullydispar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sorted y val of midpoint each line
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (161, 24)
''' Org: [struct Numa * namidys]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property namidys as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.namidys <> IntPtr.Zero Then 
	   return New Numa (Values.namidys)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sorted curvature of each line
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (162, 24)
''' Org: [struct Numa * nacurves]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nacurves as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nacurves <> IntPtr.Zero Then 
	   return New Numa (Values.nacurves)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' width of source image
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (163, 24)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height of source image
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (164, 24)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' page number important for reuse
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (165, 24)
''' Org: [l_int32 pageno]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property pageno as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.pageno
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sampling factor of disparity arrays
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (166, 24)
''' Org: [l_int32 sampling]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sampling as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sampling
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reduction factor of pixs: 1 or 2
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (167, 24)
''' Org: [l_int32 redfactor]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property redfactor as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.redfactor
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min number of long lines required
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (168, 24)
''' Org: [l_int32 minlines]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minlines as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minlines
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of long lines found
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (169, 24)
''' Org: [l_int32 nlines]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nlines as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nlines
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min line curvature in micro-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (170, 24)
''' Org: [l_int32 mincurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property mincurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.mincurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max line curvature in micro-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (171, 24)
''' Org: [l_int32 maxcurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxcurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxcurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' left edge slope in milli-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (172, 24)
''' Org: [l_int32 leftslope]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property leftslope as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.leftslope
	     return Nothing
	 End Get
	End Property

''' <summary>
''' right edge slope in milli-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (173, 24)
''' Org: [l_int32 rightslope]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rightslope as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rightslope
	     return Nothing
	 End Get
	End Property

''' <summary>
''' left edge curvature in micro-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (174, 24)
''' Org: [l_int32 leftcurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property leftcurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.leftcurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' right edge curvature in micro-units
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (175, 24)
''' Org: [l_int32 rightcurv]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rightcurv as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rightcurv
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of sampling pts in x-dir
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (176, 24)
''' Org: [l_int32 nx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of sampling pts in y-dir
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (177, 24)
''' Org: [l_int32 ny]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ny as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ny
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 0 if normal 1 if has a refpage
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (178, 24)
''' Org: [l_int32 hasref]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property hasref as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.hasref
	     return Nothing
	 End Get
	End Property

''' <summary>
''' page with disparity model to use
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (179, 24)
''' Org: [l_int32 refpage]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property refpage as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refpage
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sets to 1 if vert disparity builds
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (180, 24)
''' Org: [l_int32 vsuccess]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property vsuccess as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.vsuccess
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sets to 1 if horiz disparity builds
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (181, 24)
''' Org: [l_int32 hsuccess]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property hsuccess as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.hsuccess
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sets to 1 if slope disparity builds
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (182, 24)
''' Org: [l_int32 ysuccess]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ysuccess as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ysuccess
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sets to 1 if valid vert disparity
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (183, 24)
''' Org: [l_int32 vvalid]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property vvalid as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.vvalid
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sets to 1 if valid horiz disparity
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (184, 24)
''' Org: [l_int32 hvalid]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property hvalid as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.hvalid
	     return Nothing
	 End Get
	End Property

''' <summary>
''' if 1, skip horiz disparity
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (185, 24)
''' Org: [l_int32 skip_horiz]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property skip_horiz as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.skip_horiz
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 if debug output requested
''' </summary>
''' <remarks>
''' Loc: ./dewarp.h (187, 24)
''' Org: [l_int32 debug]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property debug as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.debug
	     return Nothing
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
#Region"gplot.h"
' ./gplot.h (75, 8)
'''<summary>
'''Data structure for generating gnuplot files
'''</summary>
'''<example>
'''<code source="CSource\Struct_GPlot.txt" language="C" title="./gplot.h (75, 8)"/>
'''</example>
Public Class GPlot
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_GPlot
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.gplotDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' for cmd, data, output
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (77, 20)
''' Org: [char * rootname]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property rootname as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.rootname <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.rootname)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' command file name
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (78, 20)
''' Org: [char * cmdname]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property cmdname as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.cmdname <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.cmdname)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' command file contents
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (79, 20)
''' Org: [struct Sarray * cmddata]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property cmddata as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.cmddata <> IntPtr.Zero Then 
	   return New Sarray (Values.cmddata)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' data file names
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (80, 20)
''' Org: [struct Sarray * datanames]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property datanames as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.datanames <> IntPtr.Zero Then 
	   return New Sarray (Values.datanames)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' plot data (1 string/file)
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (81, 20)
''' Org: [struct Sarray * plotdata]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property plotdata as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.plotdata <> IntPtr.Zero Then 
	   return New Sarray (Values.plotdata)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' title for each individual plot
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (82, 20)
''' Org: [struct Sarray * plottitles]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property plottitles as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.plottitles <> IntPtr.Zero Then 
	   return New Sarray (Values.plottitles)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' plot style for individual plots
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (83, 20)
''' Org: [struct Numa * plotstyles]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property plotstyles as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.plotstyles <> IntPtr.Zero Then 
	   return New Numa (Values.plotstyles)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' current number of plots
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (84, 20)
''' Org: [l_int32 nplots]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nplots as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nplots
	     return Nothing
	 End Get
	End Property

''' <summary>
''' output file name
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (85, 20)
''' Org: [char * outname]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property outname as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.outname <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.outname)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' GPLOT_OUTPUT values
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (86, 20)
''' Org: [l_int32 outformat]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property outformat as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.outformat
	     return Nothing
	 End Get
	End Property

''' <summary>
''' GPLOT_SCALING values
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (87, 20)
''' Org: [l_int32 scaling]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property scaling as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.scaling
	     return Nothing
	 End Get
	End Property

''' <summary>
''' optional
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (88, 20)
''' Org: [char * title]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property title as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.title <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.title)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' optional x axis label
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (89, 20)
''' Org: [char * xlabel]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property xlabel as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.xlabel <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.xlabel)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' optional y axis label
''' </summary>
''' <remarks>
''' Loc: ./gplot.h (90, 20)
''' Org: [char * ylabel]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property ylabel as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.ylabel <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.ylabel)
	End if
	     return Nothing
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
#Region"imageio.h"
' ./imageio.h (166, 8)
'''<summary>
'''Compressed image data
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Compressed_Data.txt" language="C" title="./imageio.h (166, 8)"/>
'''</example>
Public Class L_Compressed_Data
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Compressed_Data
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' encoding type: L_JPEG_ENCODE, etc
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (168, 24)
''' Org: [l_int32 type]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property type as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.type
	     return Nothing
	 End Get
	End Property

''' <summary>
''' gzipped raster data
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (169, 24)
''' Org: [l_uint8 * datacomp]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property datacomp as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.datacomp <> IntPtr.Zero Then 
	   Dim _datacomp(1 -1) as Byte
	   Marshal.Copy(Values.datacomp, _datacomp, 0, _datacomp.Length)
	   return _datacomp
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of compressed bytes
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (170, 24)
''' Org: [size_t nbytescomp]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property nbytescomp as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nbytescomp
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ascii85-encoded gzipped raster data
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (171, 24)
''' Org: [char * data85]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property data85 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data85 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.data85)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of ascii85 encoded bytes
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (172, 24)
''' Org: [size_t nbytes85]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property nbytes85 as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nbytes85
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ascii85-encoded uncompressed cmap
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (173, 24)
''' Org: [char * cmapdata85]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property cmapdata85 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.cmapdata85 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.cmapdata85)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' hex pdf array for the cmap
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (174, 24)
''' Org: [char * cmapdatahex]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property cmapdatahex as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.cmapdatahex <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.cmapdatahex)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of colors in cmap
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (175, 24)
''' Org: [l_int32 ncolors]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ncolors as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ncolors
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image width
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (176, 24)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image height
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (177, 24)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' bits/sample typ. 1, 2, 4 or 8
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (178, 24)
''' Org: [l_int32 bps]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bps as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bps
	     return Nothing
	 End Get
	End Property

''' <summary>
''' samples/pixel typ. 1 or 3
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (179, 24)
''' Org: [l_int32 spp]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property spp as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.spp
	     return Nothing
	 End Get
	End Property

''' <summary>
''' tiff g4 photometry
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (180, 24)
''' Org: [l_int32 minisblack]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minisblack as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minisblack
	     return Nothing
	 End Get
	End Property

''' <summary>
''' flate data has PNG predictors
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (181, 24)
''' Org: [l_int32 predictor]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property predictor as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.predictor
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of uncompressed raster bytes
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (182, 24)
''' Org: [size_t nbytes]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property nbytes as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nbytes
	     return Nothing
	 End Get
	End Property

''' <summary>
''' resolution (ppi)
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (183, 24)
''' Org: [l_int32 res]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property res as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.res
	     return Nothing
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


' ./imageio.h (211, 8)
'''<summary>
'''Intermediate pdf generation data
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Pdf_Data.txt" language="C" title="./imageio.h (211, 8)"/>
'''</example>
Public Class L_Pdf_Data
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Pdf_Data
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' optional title for pdf
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (213, 24)
''' Org: [char * title]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property title as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.title <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.title)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of images
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (214, 24)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of colormaps
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (215, 24)
''' Org: [l_int32 ncmap]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ncmap as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ncmap
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of compressed image data
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (216, 24)
''' Org: [struct L_Ptra * cida]
''' Msh: struct L_Ptra * | 2:Struct |  | Typedef: L_Ptra = L_Ptra
''' </remarks>
	readonly property cida as L_Ptra
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.cida <> IntPtr.Zero Then 
	   return New L_Ptra (Values.cida)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' %PDF-1.2 id string
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (217, 24)
''' Org: [char * id]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property id as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.id <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.id)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' catalog string
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (218, 24)
''' Org: [char * obj1]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property obj1 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.obj1 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.obj1)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' metadata string
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (219, 24)
''' Org: [char * obj2]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property obj2 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.obj2 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.obj2)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pages string
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (220, 24)
''' Org: [char * obj3]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property obj3 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.obj3 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.obj3)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' page string (variable data)
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (221, 24)
''' Org: [char * obj4]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property obj4 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.obj4 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.obj4)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' content string (variable data)
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (222, 24)
''' Org: [char * obj5]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property obj5 as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.obj5 <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.obj5)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' post-binary-stream string
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (223, 24)
''' Org: [char * poststream]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property poststream as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.poststream <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.poststream)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' trailer string (variable data)
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (224, 24)
''' Org: [char * trailer]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property trailer as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.trailer <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.trailer)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' store (xpt, ypt) array
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (225, 24)
''' Org: [struct Pta * xy]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property xy as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.xy <> IntPtr.Zero Then 
	   return New Pta (Values.xy)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' store (wpt, hpt) array
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (226, 24)
''' Org: [struct Pta * wh]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property wh as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.wh <> IntPtr.Zero Then 
	   return New Pta (Values.wh)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' bounding region for all images
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (227, 24)
''' Org: [struct Box * mediabox]
''' Msh: struct Box * | 2:Struct |
''' </remarks>
	readonly property mediabox as Box
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.mediabox <> IntPtr.Zero Then 
	   return New Box (Values.mediabox)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pre-binary-stream xobject strings
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (228, 24)
''' Org: [struct Sarray * saprex]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property saprex as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.saprex <> IntPtr.Zero Then 
	   return New Sarray (Values.saprex)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' colormap pdf object strings
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (229, 24)
''' Org: [struct Sarray * sacmap]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property sacmap as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.sacmap <> IntPtr.Zero Then 
	   return New Sarray (Values.sacmap)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sizes of each pdf string object
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (230, 24)
''' Org: [struct L_Dna * objsize]
''' Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property objsize as L_Dna
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.objsize <> IntPtr.Zero Then 
	   return New L_Dna (Values.objsize)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' location of each pdf string object
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (231, 24)
''' Org: [struct L_Dna * objloc]
''' Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property objloc as L_Dna
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.objloc <> IntPtr.Zero Then 
	   return New L_Dna (Values.objloc)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' location of xref
''' </summary>
''' <remarks>
''' Loc: ./imageio.h (232, 24)
''' Org: [l_int32 xrefloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xrefloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xrefloc
	     return Nothing
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
#Region"jbclass.h"
' ./jbclass.h (47, 8)
'''<summary>
'''The JbClasser struct holds all the data accumulated during the classification process that can be used for a compressed jbig2-type representation of a set of images. This is created in an initialization process and added to as the selected components on each successive page are analyzed.
'''</summary>
'''<example>
'''<code source="CSource\Struct_JbClasser.txt" language="C" title="./jbclass.h (47, 8)"/>
'''</example>
Public Class JbClasser
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_JbClasser
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.jbClasserDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' input page image file names
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (49, 22)
''' Org: [struct Sarray * safiles]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property safiles as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.safiles <> IntPtr.Zero Then 
	   return New Sarray (Values.safiles)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' JB_RANKHAUS, JB_CORRELATION
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (50, 22)
''' Org: [l_int32 method]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property method as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.method
	     return Nothing
	 End Get
	End Property

''' <summary>
''' JB_CONN_COMPS, JB_CHARACTERS or
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (51, 22)
''' Org: [l_int32 components]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property components as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.components
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max component width allowed
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (53, 22)
''' Org: [l_int32 maxwidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxwidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxwidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max component height allowed
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (54, 22)
''' Org: [l_int32 maxheight]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxheight as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxheight
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of pages already processed
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (55, 22)
''' Org: [l_int32 npages]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property npages as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.npages
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number components already processed
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (56, 22)
''' Org: [l_int32 baseindex]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property baseindex as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.baseindex
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of components on each page
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (58, 22)
''' Org: [struct Numa * nacomps]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nacomps as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nacomps <> IntPtr.Zero Then 
	   return New Numa (Values.nacomps)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of square struct elem for haus
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (59, 22)
''' Org: [l_int32 sizehaus]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sizehaus as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sizehaus
	     return Nothing
	 End Get
	End Property

''' <summary>
''' rank val of haus match, each way
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (60, 22)
''' Org: [l_float32 rankhaus]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property rankhaus as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rankhaus
	     return Nothing
	 End Get
	End Property

''' <summary>
''' thresh value for correlation score
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (61, 22)
''' Org: [l_float32 thresh]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property thresh as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.thresh
	     return Nothing
	 End Get
	End Property

''' <summary>
''' corrects thresh value for heaver
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (62, 22)
''' Org: [l_float32 weightfactor]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property weightfactor as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.weightfactor
	     return Nothing
	 End Get
	End Property

''' <summary>
''' w * h of each template, without
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (64, 22)
''' Org: [struct Numa * naarea]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naarea as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naarea <> IntPtr.Zero Then 
	   return New Numa (Values.naarea)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max width of original src images
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (66, 22)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max height of original src images
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (67, 22)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' current number of classes
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (68, 22)
''' Org: [l_int32 nclass]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nclass as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nclass
	     return Nothing
	 End Get
	End Property

''' <summary>
''' If zero, pixaa isn't filled
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (69, 22)
''' Org: [l_int32 keep_pixaa]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property keep_pixaa as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.keep_pixaa
	     return Nothing
	 End Get
	End Property

''' <summary>
''' instances for each class unbordered
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (70, 22)
''' Org: [struct Pixaa * pixaa]
''' Msh: struct Pixaa * | 2:Struct |
''' </remarks>
	readonly property pixaa as Pixaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixaa <> IntPtr.Zero Then 
	   return New Pixaa (Values.pixaa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' templates for each class bordered
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (71, 22)
''' Org: [struct Pixa * pixat]
''' Msh: struct Pixa * | 2:Struct |
''' </remarks>
	readonly property pixat as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixat <> IntPtr.Zero Then 
	   return New Pixa (Values.pixat)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' templates for each class bordered
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (73, 22)
''' Org: [struct Pixa * pixatd]
''' Msh: struct Pixa * | 2:Struct |
''' </remarks>
	readonly property pixatd as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixatd <> IntPtr.Zero Then 
	   return New Pixa (Values.pixatd)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Hash table to find templates by size
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (75, 23)
''' Org: [struct L_DnaHash * dahash]
''' Msh: struct L_DnaHash * | 2:Struct |  | Typedef: L_DnaHash = L_DnaHash
''' </remarks>
	readonly property dahash as L_DnaHash
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.dahash <> IntPtr.Zero Then 
	   return New L_DnaHash (Values.dahash)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' fg areas of undilated templates
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (76, 22)
''' Org: [struct Numa * nafgt]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nafgt as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nafgt <> IntPtr.Zero Then 
	   return New Numa (Values.nafgt)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of all bordered cc
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (78, 22)
''' Org: [struct Pta * ptac]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property ptac as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptac <> IntPtr.Zero Then 
	   return New Pta (Values.ptac)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of all bordered template cc
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (79, 22)
''' Org: [struct Pta * ptact]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property ptact as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptact <> IntPtr.Zero Then 
	   return New Pta (Values.ptact)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of class ids for each component
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (80, 22)
''' Org: [struct Numa * naclass]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naclass as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naclass <> IntPtr.Zero Then 
	   return New Numa (Values.naclass)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of page nums for each component
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (81, 22)
''' Org: [struct Numa * napage]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property napage as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.napage <> IntPtr.Zero Then 
	   return New Numa (Values.napage)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of UL corners at which the
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (82, 22)
''' Org: [struct Pta * ptaul]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property ptaul as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptaul <> IntPtr.Zero Then 
	   return New Pta (Values.ptaul)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' similar to ptaul, but for LL corners
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (85, 22)
''' Org: [struct Pta * ptall]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property ptall as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptall <> IntPtr.Zero Then 
	   return New Pta (Values.ptall)
	End if
	     return Nothing
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


' ./jbclass.h (104, 8)
'''<summary>
'''The JbData struct holds all the data required for the compressed jbig-type representation of a set of images. The data can be written to file, read back, and used to regenerate an approximate version of the original, which differs in two ways from the original: (1) It uses a template image for each c.c. instead of the original instance, for each occurrence on each page. (2) It discards components with either a height or width larger than the maximuma, given here by the lattice dimensions used for storing the templates.
'''</summary>
'''<example>
'''<code source="CSource\Struct_JbData.txt" language="C" title="./jbclass.h (104, 8)"/>
'''</example>
Public Class JbData
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_JbData
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.jbDataDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' template composite for all classes
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (106, 22)
''' Org: [struct Pix * pix]
''' Msh: struct Pix * | 2:Struct |
''' </remarks>
	readonly property pix as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pix <> IntPtr.Zero Then 
	   return New Pix (Values.pix)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of pages
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (107, 22)
''' Org: [l_int32 npages]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property npages as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.npages
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max width of original page images
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (108, 22)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max height of original page images
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (109, 22)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of classes
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (110, 22)
''' Org: [l_int32 nclass]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nclass as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nclass
	     return Nothing
	 End Get
	End Property

''' <summary>
''' lattice width for template composite
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (111, 22)
''' Org: [l_int32 latticew]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property latticew as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.latticew
	     return Nothing
	 End Get
	End Property

''' <summary>
''' lattice height for template composite
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (112, 22)
''' Org: [l_int32 latticeh]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property latticeh as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.latticeh
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of class ids for each component
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (113, 22)
''' Org: [struct Numa * naclass]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naclass as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naclass <> IntPtr.Zero Then 
	   return New Numa (Values.naclass)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of page nums for each component
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (114, 22)
''' Org: [struct Numa * napage]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property napage as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.napage <> IntPtr.Zero Then 
	   return New Numa (Values.napage)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of UL corners at which the
''' </summary>
''' <remarks>
''' Loc: ./jbclass.h (115, 22)
''' Org: [struct Pta * ptaul]
''' Msh: struct Pta * | 2:Struct |
''' </remarks>
	readonly property ptaul as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptaul <> IntPtr.Zero Then 
	   return New Pta (Values.ptaul)
	End if
	     return Nothing
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
#Region"morph.h"
' ./morph.h (62, 8)
'''<summary>
'''Selection
'''</summary>
'''<example>
'''<code source="CSource\Struct_Sel.txt" language="C" title="./morph.h (62, 8)"/>
'''</example>
Public Class Sel
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Sel
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.selDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' sel height
''' </summary>
''' <remarks>
''' Loc: ./morph.h (64, 19)
''' Org: [l_int32 sy]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sy as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sy
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sel width
''' </summary>
''' <remarks>
''' Loc: ./morph.h (65, 19)
''' Org: [l_int32 sx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y location of sel origin
''' </summary>
''' <remarks>
''' Loc: ./morph.h (66, 19)
''' Org: [l_int32 cy]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property cy as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.cy
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x location of sel origin
''' </summary>
''' <remarks>
''' Loc: ./morph.h (67, 19)
''' Org: [l_int32 cx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property cx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.cx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' {0,1,2} data[i][j] in [row][col] order
''' </summary>
''' <remarks>
''' Loc: ./morph.h (68, 19)
''' Org: [l_int32 ** data]
''' Msh: l_int32 ** | 3:Integer | List(of Integer())
''' </remarks>
	readonly property data as List(of Integer())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(sy - 1) As Integer
	Dim _DataFin As New List(Of Integer())
	Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(sx - 1) As Integer
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
	 End Get
	End Property

''' <summary>
''' used to find sel by name
''' </summary>
''' <remarks>
''' Loc: ./morph.h (69, 19)
''' Org: [char * name]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property name as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.name <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.name)
	End if
	     return Nothing
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


' ./morph.h (74, 8)
'''<summary>
'''Array of Sel
'''</summary>
'''<example>
'''<code source="CSource\Struct_Sela.txt" language="C" title="./morph.h (74, 8)"/>
'''</example>
Public Class Sela
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Sela
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.selaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of sel actually stored
''' </summary>
''' <remarks>
''' Loc: ./morph.h (76, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of allocated ptr array
''' </summary>
''' <remarks>
''' Loc: ./morph.h (77, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' sel ptr array
''' </summary>
''' <remarks>
''' Loc: ./morph.h (78, 22)
''' Org: [struct Sel ** sel]
''' Msh: struct Sel ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Sel = Sel
''' </remarks>
	readonly property sel as List(of Sel)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.sel <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Sel)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.sel, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Sel(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Sela
		public n as Integer
		public nalloc as Integer
		public sel as IntPtr
	End Class
End Class


' ./morph.h (89, 8)
'''<summary>
'''Kernel
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Kernel.txt" language="C" title="./morph.h (89, 8)"/>
'''</example>
Public Class L_Kernel
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Kernel
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' kernel height
''' </summary>
''' <remarks>
''' Loc: ./morph.h (91, 19)
''' Org: [l_int32 sy]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sy as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sy
	     return Nothing
	 End Get
	End Property

''' <summary>
''' kernel width
''' </summary>
''' <remarks>
''' Loc: ./morph.h (92, 19)
''' Org: [l_int32 sx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y location of kernel origin
''' </summary>
''' <remarks>
''' Loc: ./morph.h (93, 19)
''' Org: [l_int32 cy]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property cy as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.cy
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x location of kernel origin
''' </summary>
''' <remarks>
''' Loc: ./morph.h (94, 19)
''' Org: [l_int32 cx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property cx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.cx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' data[i][j] in [row][col] order
''' </summary>
''' <remarks>
''' Loc: ./morph.h (95, 19)
''' Org: [l_float32 ** data]
''' Msh: l_float32 ** | 3:Float | List(of Single())
''' </remarks>
	readonly property data as List(of Single())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(1 - 1) As Single
	Dim _DataFin As New List(Of Single())
	Marshal.Copy(Values.data, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(1 - 1) As Single
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
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
#Region"pix.h"
' ./pix.h (134, 8)
'''<summary>
'''Basic Pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_Pix.txt" language="C" title="./pix.h (134, 8)"/>
'''</example>
Public Class Pix
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Pix
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' width in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (136, 26)
''' Org: [l_uint32 w]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property w as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (137, 26)
''' Org: [l_uint32 h]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property h as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' depth in bits (bpp)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (138, 26)
''' Org: [l_uint32 d]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property d as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.d
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of samples per pixel
''' </summary>
''' <remarks>
''' Loc: ./pix.h (139, 26)
''' Org: [l_uint32 spp]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property spp as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.spp
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 32-bit words/line
''' </summary>
''' <remarks>
''' Loc: ./pix.h (140, 26)
''' Org: [l_uint32 wpl]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property wpl as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.wpl
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (141, 26)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in x direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (142, 26)
''' Org: [l_int32 xres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in y direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (144, 26)
''' Org: [l_int32 yres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' input file format, IFF_*
''' </summary>
''' <remarks>
''' Loc: ./pix.h (146, 26)
''' Org: [l_int32 informat]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property informat as IFF
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	return  Values.informat
	     return Nothing
	 End Get
	End Property

''' <summary>
''' special instructions for I/O, etc
''' </summary>
''' <remarks>
''' Loc: ./pix.h (147, 26)
''' Org: [l_int32 special]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property special as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.special
	     return Nothing
	 End Get
	End Property

''' <summary>
''' text string associated with pix
''' </summary>
''' <remarks>
''' Loc: ./pix.h (148, 26)
''' Org: [char * text]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property text as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.text <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.text)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' colormap (may be null)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (149, 26)
''' Org: [struct PixColormap * colormap]
''' Msh: struct PixColormap * | 2:Struct |
''' </remarks>
	readonly property colormap as PixColormap
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.colormap <> IntPtr.Zero Then 
	   return New PixColormap (Values.colormap)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the image data
''' </summary>
''' <remarks>
''' Loc: ./pix.h (150, 26)
''' Org: [l_uint32 * data]
''' Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
''' </remarks>
	readonly property data as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _data((h * (wpl * 4)) -1) as Byte
	Marshal.Copy(Values.data, _data, 0, _data.Length)
	return _data
	     return Nothing
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


' ./pix.h (155, 8)
'''<summary>
'''Colormap of a Pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixColormap.txt" language="C" title="./pix.h (155, 8)"/>
'''</example>
Public Class PixColormap
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixColormap
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' colormap table (array of RGBA_QUAD)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (157, 22)
''' Org: [void * array]
''' Msh: void * | 2:Void | Object -  - IntPtr
''' </remarks>
	readonly property array as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.array <> IntPtr.Zero Then
	   return Values.array
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' of pix (1, 2, 4 or 8 bpp)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (158, 22)
''' Org: [l_int32 depth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property depth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.depth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of color entries allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (159, 22)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of color entries used
''' </summary>
''' <remarks>
''' Loc: ./pix.h (160, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
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


' ./pix.h (169, 8)
'''<summary>
'''Colormap table entry (after the BMP version). Note that the BMP format stores the colormap table exactly as it appears here, with color samples being stored sequentially, in the order (b,g,r,a).
'''</summary>
'''<example>
'''<code source="CSource\Struct_RGBA_Quad.txt" language="C" title="./pix.h (169, 8)"/>
'''</example>
Public Class RGBA_Quad
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_RGBA_Quad
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' blue value
''' </summary>
''' <remarks>
''' Loc: ./pix.h (171, 17)
''' Org: [l_uint8 blue]
''' Msh: l_uint8 | 1:UChar |
''' </remarks>
	readonly property blue as Byte
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.blue
	     return Nothing
	 End Get
	End Property

''' <summary>
''' green value
''' </summary>
''' <remarks>
''' Loc: ./pix.h (172, 17)
''' Org: [l_uint8 green]
''' Msh: l_uint8 | 1:UChar |
''' </remarks>
	readonly property green as Byte
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.green
	     return Nothing
	 End Get
	End Property

''' <summary>
''' red value
''' </summary>
''' <remarks>
''' Loc: ./pix.h (173, 17)
''' Org: [l_uint8 red]
''' Msh: l_uint8 | 1:UChar |
''' </remarks>
	readonly property red as Byte
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.red
	     return Nothing
	 End Get
	End Property

''' <summary>
''' alpha value
''' </summary>
''' <remarks>
''' Loc: ./pix.h (174, 17)
''' Org: [l_uint8 alpha]
''' Msh: l_uint8 | 1:UChar |
''' </remarks>
	readonly property alpha as Byte
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.alpha
	     return Nothing
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


' ./pix.h (454, 8)
'''<summary>
'''Array of pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_Pixa.txt" language="C" title="./pix.h (454, 8)"/>
'''</example>
Public Class Pixa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Pixa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of Pix in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (456, 25)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of Pix ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (457, 25)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (458, 25)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the array of ptrs to pix
''' </summary>
''' <remarks>
''' Loc: ./pix.h (459, 25)
''' Org: [struct Pix ** pix]
''' Msh: struct Pix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pix = Pix
''' </remarks>
	readonly property pix as List(of Pix)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.pix <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Pix)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.pix, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Pix(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of boxes
''' </summary>
''' <remarks>
''' Loc: ./pix.h (460, 25)
''' Org: [struct Boxa * boxa]
''' Msh: struct Boxa * | 2:Struct |
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
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


' ./pix.h (465, 8)
'''<summary>
'''Array of arrays of pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_Pixaa.txt" language="C" title="./pix.h (465, 8)"/>
'''</example>
Public Class Pixaa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Pixaa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixaaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of Pixa in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (467, 25)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of Pixa ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (468, 25)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of ptrs to pixa
''' </summary>
''' <remarks>
''' Loc: ./pix.h (469, 25)
''' Org: [struct Pixa ** pixa]
''' Msh: struct Pixa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixa as List(of Pixa)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.pixa <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Pixa)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.pixa, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Pixa(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of boxes
''' </summary>
''' <remarks>
''' Loc: ./pix.h (470, 25)
''' Org: [struct Boxa * boxa]
''' Msh: struct Boxa * | 2:Struct |
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
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


' ./pix.h (480, 8)
'''<summary>
'''Basic rectangle
'''</summary>
'''<example>
'''<code source="CSource\Struct_Box.txt" language="C" title="./pix.h (480, 8)"/>
'''</example>
Public Class Box
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Box
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.boxDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' left coordinate
''' </summary>
''' <remarks>
''' Loc: ./pix.h (482, 24)
''' Org: [l_int32 x]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property x as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.x
	     return Nothing
	 End Get
	End Property

''' <summary>
''' top coordinate
''' </summary>
''' <remarks>
''' Loc: ./pix.h (483, 24)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

''' <summary>
''' box width
''' </summary>
''' <remarks>
''' Loc: ./pix.h (484, 24)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' box height
''' </summary>
''' <remarks>
''' Loc: ./pix.h (485, 24)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (486, 24)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
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


' ./pix.h (492, 8)
'''<summary>
'''Array of Box
'''</summary>
'''<example>
'''<code source="CSource\Struct_Boxa.txt" language="C" title="./pix.h (492, 8)"/>
'''</example>
Public Class Boxa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Boxa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.boxaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of box in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (494, 24)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of box ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (495, 24)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (496, 24)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' box ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (497, 24)
''' Org: [struct Box ** box]
''' Msh: struct Box ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Box = Box
''' </remarks>
	readonly property box as List(of Box)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.box <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Box)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.box, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Box(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
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


' ./pix.h (502, 8)
'''<summary>
'''Array of Boxa
'''</summary>
'''<example>
'''<code source="CSource\Struct_Boxaa.txt" language="C" title="./pix.h (502, 8)"/>
'''</example>
Public Class Boxaa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Boxaa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.boxaaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of boxa in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (504, 24)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of boxa ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (505, 24)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' boxa ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (506, 24)
''' Org: [struct Boxa ** boxa]
''' Msh: struct Boxa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Boxa = Boxa
''' </remarks>
	readonly property boxa as List(of Boxa)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.boxa <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Boxa)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.boxa, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Boxa(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Boxaa
		public n as Integer
		public nalloc as Integer
		public boxa as IntPtr
	End Class
End Class


' ./pix.h (517, 8)
'''<summary>
'''Array of points
'''</summary>
'''<example>
'''<code source="CSource\Struct_Pta.txt" language="C" title="./pix.h (517, 8)"/>
'''</example>
Public Class Pta
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Pta
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.ptaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' actual number of pts
''' </summary>
''' <remarks>
''' Loc: ./pix.h (519, 24)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of allocated arrays
''' </summary>
''' <remarks>
''' Loc: ./pix.h (520, 24)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (521, 24)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' arrays of floats
''' </summary>
''' <remarks>
''' Loc: ./pix.h (522, 24)
''' Org: [l_float32 * x]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property x as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.x <> IntPtr.Zero Then 
	   Dim _x(Values.n -1) as Single
	   Marshal.Copy(Values.x, _x, 0, _x.Length)
	   return _x
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' arrays of floats
''' </summary>
''' <remarks>
''' Loc: ./pix.h (522, 28)
''' Org: [l_float32 * y]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property y as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.y <> IntPtr.Zero Then 
	   Dim _y(Values.n -1) as Single
	   Marshal.Copy(Values.y, _y, 0, _y.Length)
	   return _y
	End if
	     return Nothing
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


' ./pix.h (532, 8)
'''<summary>
'''Array of Pta
'''</summary>
'''<example>
'''<code source="CSource\Struct_Ptaa.txt" language="C" title="./pix.h (532, 8)"/>
'''</example>
Public Class Ptaa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Ptaa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.ptaaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of pta in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (534, 26)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of pta ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (535, 26)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pta ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (536, 26)
''' Org: [struct Pta ** pta]
''' Msh: struct Pta ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pta = Pta
''' </remarks>
	readonly property pta as List(of Pta)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.pta <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Pta)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.pta, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Pta(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_Ptaa
		public n as Integer
		public nalloc as Integer
		public pta as IntPtr
	End Class
End Class


' ./pix.h (546, 8)
'''<summary>
'''Pix accumulator container
'''</summary>
'''<example>
'''<code source="CSource\Struct_Pixacc.txt" language="C" title="./pix.h (546, 8)"/>
'''</example>
Public Class Pixacc
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_Pixacc
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixaccDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' array width
''' </summary>
''' <remarks>
''' Loc: ./pix.h (548, 25)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array height
''' </summary>
''' <remarks>
''' Loc: ./pix.h (549, 25)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' used to allow negative
''' </summary>
''' <remarks>
''' Loc: ./pix.h (550, 25)
''' Org: [l_int32 offset]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property offset as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.offset
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the 32 bit accumulator pix
''' </summary>
''' <remarks>
''' Loc: ./pix.h (552, 25)
''' Org: [struct Pix * pix]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pix as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pix <> IntPtr.Zero Then 
	   return New Pix (Values.pix)
	End if
	     return Nothing
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


' ./pix.h (562, 8)
'''<summary>
'''Pix tiling
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixTiling.txt" language="C" title="./pix.h (562, 8)"/>
'''</example>
Public Class PixTiling
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixTiling
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixTilingDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' input pix (a clone)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (564, 26)
''' Org: [struct Pix * pix]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pix as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pix <> IntPtr.Zero Then 
	   return New Pix (Values.pix)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of tiles horizontally
''' </summary>
''' <remarks>
''' Loc: ./pix.h (565, 26)
''' Org: [l_int32 nx]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nx as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nx
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of tiles vertically
''' </summary>
''' <remarks>
''' Loc: ./pix.h (566, 26)
''' Org: [l_int32 ny]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ny as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ny
	     return Nothing
	 End Get
	End Property

''' <summary>
''' tile width
''' </summary>
''' <remarks>
''' Loc: ./pix.h (567, 26)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' tile height
''' </summary>
''' <remarks>
''' Loc: ./pix.h (568, 26)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' overlap on left and right
''' </summary>
''' <remarks>
''' Loc: ./pix.h (569, 26)
''' Org: [l_int32 xoverlap]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xoverlap as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xoverlap
	     return Nothing
	 End Get
	End Property

''' <summary>
''' overlap on top and bottom
''' </summary>
''' <remarks>
''' Loc: ./pix.h (570, 26)
''' Org: [l_int32 yoverlap]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yoverlap as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yoverlap
	     return Nothing
	 End Get
	End Property

''' <summary>
''' strip for paint default is TRUE
''' </summary>
''' <remarks>
''' Loc: ./pix.h (571, 26)
''' Org: [l_int32 strip]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property strip as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.strip
	     return Nothing
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


' ./pix.h (582, 8)
'''<summary>
'''Pix with float array
'''</summary>
'''<example>
'''<code source="CSource\Struct_FPix.txt" language="C" title="./pix.h (582, 8)"/>
'''</example>
Public Class FPix
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_FPix
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.fpixDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' width in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (584, 26)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (585, 26)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 32-bit words/line
''' </summary>
''' <remarks>
''' Loc: ./pix.h (586, 26)
''' Org: [l_int32 wpl]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property wpl as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.wpl
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (587, 26)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in x direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (588, 26)
''' Org: [l_int32 xres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in y direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (590, 26)
''' Org: [l_int32 yres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the float image data
''' </summary>
''' <remarks>
''' Loc: ./pix.h (592, 26)
''' Org: [l_float32 * data]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property data as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data <> IntPtr.Zero Then 
	   Dim _data(1 -1) as Single
	   Marshal.Copy(Values.data, _data, 0, _data.Length)
	   return _data
	End if
	     return Nothing
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


' ./pix.h (597, 8)
'''<summary>
'''Array of FPix
'''</summary>
'''<example>
'''<code source="CSource\Struct_FPixa.txt" language="C" title="./pix.h (597, 8)"/>
'''</example>
Public Class FPixa
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_FPixa
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.fpixaDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of fpix in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (599, 25)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of fpix ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (600, 25)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (601, 25)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the array of ptrs to fpix
''' </summary>
''' <remarks>
''' Loc: ./pix.h (602, 25)
''' Org: [struct FPix ** fpix]
''' Msh: struct FPix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: FPix = FPix
''' </remarks>
	readonly property fpix as List(of FPix)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.fpix <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of FPix)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.fpix, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New FPix(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
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


' ./pix.h (613, 8)
'''<summary>
'''Pix with double array
'''</summary>
'''<example>
'''<code source="CSource\Struct_DPix.txt" language="C" title="./pix.h (613, 8)"/>
'''</example>
Public Class DPix
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_DPix
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.dpixDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' width in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (615, 26)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (616, 26)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 32-bit words/line
''' </summary>
''' <remarks>
''' Loc: ./pix.h (617, 26)
''' Org: [l_int32 wpl]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property wpl as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.wpl
	     return Nothing
	 End Get
	End Property

''' <summary>
''' reference count (1 if no clones)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (618, 26)
''' Org: [l_uint32 refcount]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property refcount as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.refcount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in x direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (619, 26)
''' Org: [l_int32 xres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in y direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (621, 26)
''' Org: [l_int32 yres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the double image data
''' </summary>
''' <remarks>
''' Loc: ./pix.h (623, 26)
''' Org: [l_float64 * data]
''' Msh: l_float64 * | 2:Double |
''' </remarks>
	readonly property data as Double()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data <> IntPtr.Zero Then 
	   Dim _data(1 -1) as Double
	   Marshal.Copy(Values.data, _data, 0, _data.Length)
	   return _data
	End if
	     return Nothing
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


' ./pix.h (633, 8)
'''<summary>
'''Compressed Pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixComp.txt" language="C" title="./pix.h (633, 8)"/>
'''</example>
Public Class PixComp
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixComp
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixcompDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' width in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (635, 26)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <summary>
''' height in pixels
''' </summary>
''' <remarks>
''' Loc: ./pix.h (636, 26)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <summary>
''' depth in bits
''' </summary>
''' <remarks>
''' Loc: ./pix.h (637, 26)
''' Org: [l_int32 d]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property d as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.d
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in x direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (638, 26)
''' Org: [l_int32 xres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' image res (ppi) in y direction
''' </summary>
''' <remarks>
''' Loc: ./pix.h (640, 26)
''' Org: [l_int32 yres]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yres as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yres
	     return Nothing
	 End Get
	End Property

''' <summary>
''' compressed format (IFF_TIFF_G4,
''' </summary>
''' <remarks>
''' Loc: ./pix.h (642, 26)
''' Org: [l_int32 comptype]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property comptype as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.comptype
	     return Nothing
	 End Get
	End Property

''' <summary>
''' text string associated with pix
''' </summary>
''' <remarks>
''' Loc: ./pix.h (644, 26)
''' Org: [char * text]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property text as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.text <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.text)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' flag (1 for cmap, 0 otherwise)
''' </summary>
''' <remarks>
''' Loc: ./pix.h (645, 26)
''' Org: [l_int32 cmapflag]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property cmapflag as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.cmapflag
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the compressed image data
''' </summary>
''' <remarks>
''' Loc: ./pix.h (646, 26)
''' Org: [l_uint8 * data]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property data as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.data <> IntPtr.Zero Then 
	   Dim _data(Values.size -1) as Byte
	   Marshal.Copy(Values.data, _data, 0, _data.Length)
	   return _data
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of the data array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (647, 26)
''' Org: [size_t size]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property size as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
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


' ./pix.h (658, 8)
'''<summary>
'''Array of compressed pix
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixaComp.txt" language="C" title="./pix.h (658, 8)"/>
'''</example>
Public Class PixaComp
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixaComp
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       	Natives.pixacompDestroy (Pointer)
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of PixComp in ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (660, 26)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of PixComp ptrs allocated
''' </summary>
''' <remarks>
''' Loc: ./pix.h (661, 26)
''' Org: [l_int32 nalloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nalloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nalloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' indexing offset into ptr array
''' </summary>
''' <remarks>
''' Loc: ./pix.h (662, 26)
''' Org: [l_int32 offset]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property offset as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.offset
	     return Nothing
	 End Get
	End Property

''' <summary>
''' the array of ptrs to PixComp
''' </summary>
''' <remarks>
''' Loc: ./pix.h (663, 26)
''' Org: [struct PixComp ** pixc]
''' Msh: struct PixComp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
''' </remarks>
	readonly property pixc as List(of PixComp)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.pixc <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of PixComp)
	   Dim LSTPTR (Values.n - 1) As IntPtr
	   Marshal.Copy(Values.pixc, LSTPTR, 0, Values.n)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New PixComp(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of boxes
''' </summary>
''' <remarks>
''' Loc: ./pix.h (664, 26)
''' Org: [struct Boxa * boxa]
''' Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
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
#Region"recog.h"
' ./recog.h (116, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Recog.txt" language="C" title="./recog.h (116, 8)"/>
'''</example>
Public Class L_Recog
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Recog
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' scale all examples to this width
''' </summary>
''' <remarks>
''' Loc: ./recog.h (117, 20)
''' Org: [l_int32 scalew]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property scalew as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.scalew
	     return Nothing
	 End Get
	End Property

''' <summary>
''' scale all examples to this height
''' </summary>
''' <remarks>
''' Loc: ./recog.h (119, 20)
''' Org: [l_int32 scaleh]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property scaleh as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.scaleh
	     return Nothing
	 End Get
	End Property

''' <summary>
''' use a value > 0 to convert the bitmap
''' </summary>
''' <remarks>
''' Loc: ./recog.h (121, 20)
''' Org: [l_int32 linew]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property linew as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.linew
	     return Nothing
	 End Get
	End Property

''' <summary>
''' template use: use either the average
''' </summary>
''' <remarks>
''' Loc: ./recog.h (123, 20)
''' Org: [l_int32 templ_use]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property templ_use as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.templ_use
	     return Nothing
	 End Get
	End Property

''' <summary>
''' initialize container arrays to this
''' </summary>
''' <remarks>
''' Loc: ./recog.h (126, 20)
''' Org: [l_int32 maxarraysize]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxarraysize as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxarraysize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of character set
''' </summary>
''' <remarks>
''' Loc: ./recog.h (127, 20)
''' Org: [l_int32 setsize]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property setsize as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.setsize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' for binarizing if depth > 1
''' </summary>
''' <remarks>
''' Loc: ./recog.h (128, 20)
''' Org: [l_int32 threshold]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property threshold as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.threshold
	     return Nothing
	 End Get
	End Property

''' <summary>
''' vertical jiggle on nominal centroid
''' </summary>
''' <remarks>
''' Loc: ./recog.h (129, 20)
''' Org: [l_int32 maxyshift]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxyshift as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxyshift
	     return Nothing
	 End Get
	End Property

''' <summary>
''' one of L_ARABIC_NUMERALS, etc.
''' </summary>
''' <remarks>
''' Loc: ./recog.h (131, 20)
''' Org: [l_int32 charset_type]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property charset_type as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.charset_type
	     return Nothing
	 End Get
	End Property

''' <summary>
''' expected number of classes in charset
''' </summary>
''' <remarks>
''' Loc: ./recog.h (132, 20)
''' Org: [l_int32 charset_size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property charset_size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.charset_size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min number of samples without padding
''' </summary>
''' <remarks>
''' Loc: ./recog.h (133, 20)
''' Org: [l_int32 min_nopad]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property min_nopad as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.min_nopad
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of training samples
''' </summary>
''' <remarks>
''' Loc: ./recog.h (134, 20)
''' Org: [l_int32 num_samples]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property num_samples as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.num_samples
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min width averaged unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (135, 20)
''' Org: [l_int32 minwidth_u]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minwidth_u as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minwidth_u
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max width averaged unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (136, 20)
''' Org: [l_int32 maxwidth_u]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxwidth_u as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxwidth_u
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min height averaged unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (137, 20)
''' Org: [l_int32 minheight_u]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minheight_u as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minheight_u
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max height averaged unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (138, 20)
''' Org: [l_int32 maxheight_u]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxheight_u as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxheight_u
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min width averaged scaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (139, 20)
''' Org: [l_int32 minwidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minwidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minwidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max width averaged scaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (140, 20)
''' Org: [l_int32 maxwidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxwidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxwidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 when averaged bitmaps are made
''' </summary>
''' <remarks>
''' Loc: ./recog.h (141, 20)
''' Org: [l_int32 ave_done]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ave_done as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ave_done
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 when training is complete or
''' </summary>
''' <remarks>
''' Loc: ./recog.h (142, 20)
''' Org: [l_int32 train_done]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property train_done as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.train_done
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max width/height ratio to split
''' </summary>
''' <remarks>
''' Loc: ./recog.h (144, 20)
''' Org: [l_float32 max_wh_ratio]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property max_wh_ratio as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_wh_ratio
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max of max/min template height ratio
''' </summary>
''' <remarks>
''' Loc: ./recog.h (145, 20)
''' Org: [l_float32 max_ht_ratio]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property max_ht_ratio as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_ht_ratio
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min component width kept in splitting
''' </summary>
''' <remarks>
''' Loc: ./recog.h (146, 20)
''' Org: [l_int32 min_splitw]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property min_splitw as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.min_splitw
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max component height kept in splitting
''' </summary>
''' <remarks>
''' Loc: ./recog.h (147, 20)
''' Org: [l_int32 max_splith]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property max_splith as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.max_splith
	     return Nothing
	 End Get
	End Property

''' <summary>
''' text array for arbitrary char set
''' </summary>
''' <remarks>
''' Loc: ./recog.h (148, 20)
''' Org: [struct Sarray * sa_text]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property sa_text as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.sa_text <> IntPtr.Zero Then 
	   return New Sarray (Values.sa_text)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' index-to-char lut for arbitrary charset
''' </summary>
''' <remarks>
''' Loc: ./recog.h (149, 20)
''' Org: [struct L_Dna * dna_tochar]
''' Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property dna_tochar as L_Dna
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.dna_tochar <> IntPtr.Zero Then 
	   return New L_Dna (Values.dna_tochar)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' table for finding centroids
''' </summary>
''' <remarks>
''' Loc: ./recog.h (150, 20)
''' Org: [l_int32 * centtab]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property centtab as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.centtab <> IntPtr.Zero Then 
	   Dim _centtab(1 -1) as Integer
	   Marshal.Copy(Values.centtab, _centtab, 0, _centtab.Length)
	   return _centtab
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' table for finding pixel sums
''' </summary>
''' <remarks>
''' Loc: ./recog.h (151, 20)
''' Org: [l_int32 * sumtab]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property sumtab as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.sumtab <> IntPtr.Zero Then 
	   Dim _sumtab(1 -1) as Integer
	   Marshal.Copy(Values.sumtab, _sumtab, 0, _sumtab.Length)
	   return _sumtab
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' all unscaled templates for each class
''' </summary>
''' <remarks>
''' Loc: ./recog.h (152, 20)
''' Org: [struct Pixaa * pixaa_u]
''' Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
''' </remarks>
	readonly property pixaa_u as Pixaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixaa_u <> IntPtr.Zero Then 
	   return New Pixaa (Values.pixaa_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of all unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (153, 20)
''' Org: [struct Ptaa * ptaa_u]
''' Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
''' </remarks>
	readonly property ptaa_u as Ptaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptaa_u <> IntPtr.Zero Then 
	   return New Ptaa (Values.ptaa_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' area of all unscaled templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (154, 20)
''' Org: [struct Numaa * naasum_u]
''' Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
''' </remarks>
	readonly property naasum_u as Numaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naasum_u <> IntPtr.Zero Then 
	   return New Numaa (Values.naasum_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' all (scaled) templates for each class
''' </summary>
''' <remarks>
''' Loc: ./recog.h (155, 20)
''' Org: [struct Pixaa * pixaa]
''' Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
''' </remarks>
	readonly property pixaa as Pixaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixaa <> IntPtr.Zero Then 
	   return New Pixaa (Values.pixaa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of all (scaledl) templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (156, 20)
''' Org: [struct Ptaa * ptaa]
''' Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
''' </remarks>
	readonly property ptaa as Ptaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptaa <> IntPtr.Zero Then 
	   return New Ptaa (Values.ptaa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' area of all (scaled) templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (157, 20)
''' Org: [struct Numaa * naasum]
''' Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
''' </remarks>
	readonly property naasum as Numaa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naasum <> IntPtr.Zero Then 
	   return New Numaa (Values.naasum)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' averaged unscaled templates per class
''' </summary>
''' <remarks>
''' Loc: ./recog.h (158, 20)
''' Org: [struct Pixa * pixa_u]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixa_u as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixa_u <> IntPtr.Zero Then 
	   return New Pixa (Values.pixa_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of unscaled ave. templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (159, 20)
''' Org: [struct Pta * pta_u]
''' Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
''' </remarks>
	readonly property pta_u as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pta_u <> IntPtr.Zero Then 
	   return New Pta (Values.pta_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' area of unscaled averaged templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (160, 20)
''' Org: [struct Numa * nasum_u]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasum_u as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasum_u <> IntPtr.Zero Then 
	   return New Numa (Values.nasum_u)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' averaged (scaled) templates per class
''' </summary>
''' <remarks>
''' Loc: ./recog.h (161, 20)
''' Org: [struct Pixa * pixa]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixa as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixa <> IntPtr.Zero Then 
	   return New Pixa (Values.pixa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' centroids of (scaled) ave. templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (162, 20)
''' Org: [struct Pta * pta]
''' Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
''' </remarks>
	readonly property pta as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pta <> IntPtr.Zero Then 
	   return New Pta (Values.pta)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' area of (scaled) averaged templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (163, 20)
''' Org: [struct Numa * nasum]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasum as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasum <> IntPtr.Zero Then 
	   return New Numa (Values.nasum)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' all input training images
''' </summary>
''' <remarks>
''' Loc: ./recog.h (164, 20)
''' Org: [struct Pixa * pixa_tr]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixa_tr as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixa_tr <> IntPtr.Zero Then 
	   return New Pixa (Values.pixa_tr)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' unscaled and scaled averaged bitmaps
''' </summary>
''' <remarks>
''' Loc: ./recog.h (165, 20)
''' Org: [struct Pixa * pixadb_ave]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixadb_ave as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixadb_ave <> IntPtr.Zero Then 
	   return New Pixa (Values.pixadb_ave)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' input images for identifying
''' </summary>
''' <remarks>
''' Loc: ./recog.h (166, 20)
''' Org: [struct Pixa * pixa_id]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixa_id as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixa_id <> IntPtr.Zero Then 
	   return New Pixa (Values.pixa_id)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' debug: best match of input against ave.
''' </summary>
''' <remarks>
''' Loc: ./recog.h (167, 20)
''' Org: [struct Pix * pixdb_ave]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixdb_ave as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixdb_ave <> IntPtr.Zero Then 
	   return New Pix (Values.pixdb_ave)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' debug: best matches within range
''' </summary>
''' <remarks>
''' Loc: ./recog.h (168, 20)
''' Org: [struct Pix * pixdb_range]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixdb_range as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixdb_range <> IntPtr.Zero Then 
	   return New Pix (Values.pixdb_range)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' debug: bootstrap training results
''' </summary>
''' <remarks>
''' Loc: ./recog.h (169, 20)
''' Org: [struct Pixa * pixadb_boot]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixadb_boot as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixadb_boot <> IntPtr.Zero Then 
	   return New Pixa (Values.pixadb_boot)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' debug: splitting results
''' </summary>
''' <remarks>
''' Loc: ./recog.h (170, 20)
''' Org: [struct Pixa * pixadb_split]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixadb_split as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixadb_split <> IntPtr.Zero Then 
	   return New Pixa (Values.pixadb_split)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' bmf fonts
''' </summary>
''' <remarks>
''' Loc: ./recog.h (171, 20)
''' Org: [struct L_Bmf * bmf]
''' Msh: struct L_Bmf * | 2:Struct |  | Typedef: L_Bmf = L_Bmf
''' </remarks>
	readonly property bmf as L_Bmf
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.bmf <> IntPtr.Zero Then 
	   return New L_Bmf (Values.bmf)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' font size of bmf default is 6 pt
''' </summary>
''' <remarks>
''' Loc: ./recog.h (172, 20)
''' Org: [l_int32 bmf_size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bmf_size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bmf_size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' temp data used for image decoding
''' </summary>
''' <remarks>
''' Loc: ./recog.h (173, 20)
''' Org: [struct L_Rdid * did]
''' Msh: struct L_Rdid * | 2:Struct |
''' </remarks>
	readonly property did as L_Rdid
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.did <> IntPtr.Zero Then 
	   return New L_Rdid (Values.did)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' temp data used for holding best char
''' </summary>
''' <remarks>
''' Loc: ./recog.h (174, 20)
''' Org: [struct L_Rch * rch]
''' Msh: struct L_Rch * | 2:Struct |
''' </remarks>
	readonly property rch as L_Rch
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.rch <> IntPtr.Zero Then 
	   return New L_Rch (Values.rch)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' temp data used for array of best chars
''' </summary>
''' <remarks>
''' Loc: ./recog.h (175, 20)
''' Org: [struct L_Rcha * rcha]
''' Msh: struct L_Rcha * | 2:Struct |
''' </remarks>
	readonly property rcha as L_Rcha
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.rcha <> IntPtr.Zero Then 
	   return New L_Rcha (Values.rcha)
	End if
	     return Nothing
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


' ./recog.h (182, 8)
'''<summary>
'''Data returned from correlation matching on a single character
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Rch.txt" language="C" title="./recog.h (182, 8)"/>
'''</example>
Public Class L_Rch
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Rch
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' index of best template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (183, 20)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
	 End Get
	End Property

''' <summary>
''' correlation score of best template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (184, 20)
''' Org: [l_float32 score]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property score as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.score
	     return Nothing
	 End Get
	End Property

''' <summary>
''' character string of best template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (185, 20)
''' Org: [char * text]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property text as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.text <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.text)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' index of best sample (within the best
''' </summary>
''' <remarks>
''' Loc: ./recog.h (186, 20)
''' Org: [l_int32 sample]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property sample as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sample
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x-location of template (delx + shiftx)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (188, 20)
''' Org: [l_int32 xloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y-location of template (dely + shifty)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (189, 20)
''' Org: [l_int32 yloc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property yloc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.yloc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' width of best template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (190, 20)
''' Org: [l_int32 width]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property width as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.width
	     return Nothing
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


' ./recog.h (197, 8)
'''<summary>
'''Data returned from correlation matching on an array of characters
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Rcha.txt" language="C" title="./recog.h (197, 8)"/>
'''</example>
Public Class L_Rcha
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Rcha
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' indices of best templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (198, 20)
''' Org: [struct Numa * naindex]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naindex as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naindex <> IntPtr.Zero Then 
	   return New Numa (Values.naindex)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' correlation scores of best templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (199, 20)
''' Org: [struct Numa * nascore]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nascore as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nascore <> IntPtr.Zero Then 
	   return New Numa (Values.nascore)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' character strings of best templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (200, 20)
''' Org: [struct Sarray * satext]
''' Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property satext as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.satext <> IntPtr.Zero Then 
	   return New Sarray (Values.satext)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' indices of best samples
''' </summary>
''' <remarks>
''' Loc: ./recog.h (201, 20)
''' Org: [struct Numa * nasample]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasample as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasample <> IntPtr.Zero Then 
	   return New Numa (Values.nasample)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x-locations of templates (delx + shiftx)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (202, 20)
''' Org: [struct Numa * naxloc]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naxloc as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naxloc <> IntPtr.Zero Then 
	   return New Numa (Values.naxloc)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y-locations of templates (dely + shifty)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (203, 20)
''' Org: [struct Numa * nayloc]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nayloc as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nayloc <> IntPtr.Zero Then 
	   return New Numa (Values.nayloc)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' widths of best templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (204, 20)
''' Org: [struct Numa * nawidth]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nawidth as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nawidth <> IntPtr.Zero Then 
	   return New Numa (Values.nawidth)
	End if
	     return Nothing
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


' ./recog.h (211, 8)
'''<summary>
'''Data used for decoding a line of characters.
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Rdid.txt" language="C" title="./recog.h (211, 8)"/>
'''</example>
Public Class L_Rdid
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Rdid
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' clone of pix to be decoded
''' </summary>
''' <remarks>
''' Loc: ./recog.h (212, 20)
''' Org: [struct Pix * pixs]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixs as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixs <> IntPtr.Zero Then 
	   return New Pix (Values.pixs)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' count array for each averaged template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (213, 20)
''' Org: [l_int32 ** counta]
''' Msh: l_int32 ** | 3:Integer | List(of Integer())
''' </remarks>
	readonly property counta as List(of Integer())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(Values.size - 1) As Integer
	Dim _DataFin As New List(Of Integer())
	Marshal.Copy(Values.counta, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(Values.size - 1) As Integer
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
	 End Get
	End Property

''' <summary>
''' best y-shift array per average template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (214, 20)
''' Org: [l_int32 ** delya]
''' Msh: l_int32 ** | 3:Integer | List(of Integer())
''' </remarks>
	readonly property delya as List(of Integer())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(Values.size - 1) As Integer
	Dim _DataFin As New List(Of Integer())
	Marshal.Copy(Values.delya, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(Values.size - 1) As Integer
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of averaged templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (215, 20)
''' Org: [l_int32 narray]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property narray as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.narray
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of count array (width of pixs)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (216, 20)
''' Org: [l_int32 size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' setwidths for each template
''' </summary>
''' <remarks>
''' Loc: ./recog.h (217, 20)
''' Org: [l_int32 * setwidth]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property setwidth as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.setwidth <> IntPtr.Zero Then 
	   Dim _setwidth(Values.size -1) as Integer
	   Marshal.Copy(Values.setwidth, _setwidth, 0, _setwidth.Length)
	   return _setwidth
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pixel count in pixs by column
''' </summary>
''' <remarks>
''' Loc: ./recog.h (218, 20)
''' Org: [struct Numa * nasum]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasum as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasum <> IntPtr.Zero Then 
	   return New Numa (Values.nasum)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' first moment of pixels in pixs by cols
''' </summary>
''' <remarks>
''' Loc: ./recog.h (219, 20)
''' Org: [struct Numa * namoment]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property namoment as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.namoment <> IntPtr.Zero Then 
	   return New Numa (Values.namoment)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 1 if full arrays are made 0 otherwise
''' </summary>
''' <remarks>
''' Loc: ./recog.h (220, 20)
''' Org: [l_int32 fullarrays]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property fullarrays as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.fullarrays
	     return Nothing
	 End Get
	End Property

''' <summary>
''' channel coeffs for template fg term
''' </summary>
''' <remarks>
''' Loc: ./recog.h (221, 20)
''' Org: [l_float32 * beta]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property beta as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.beta <> IntPtr.Zero Then 
	   Dim _beta(Values.size -1) as Single
	   Marshal.Copy(Values.beta, _beta, 0, _beta.Length)
	   return _beta
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' channel coeffs for bit-and term
''' </summary>
''' <remarks>
''' Loc: ./recog.h (222, 20)
''' Org: [l_float32 * gamma]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property gamma as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.gamma <> IntPtr.Zero Then 
	   Dim _gamma(Values.size -1) as Single
	   Marshal.Copy(Values.gamma, _gamma, 0, _gamma.Length)
	   return _gamma
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' score on trellis
''' </summary>
''' <remarks>
''' Loc: ./recog.h (223, 20)
''' Org: [l_float32 * trellisscore]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property trellisscore as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.trellisscore <> IntPtr.Zero Then 
	   Dim _trellisscore(Values.size -1) as Single
	   Marshal.Copy(Values.trellisscore, _trellisscore, 0, _trellisscore.Length)
	   return _trellisscore
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' template on trellis (for backtrack)
''' </summary>
''' <remarks>
''' Loc: ./recog.h (224, 20)
''' Org: [l_int32 * trellistempl]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property trellistempl as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.trellistempl <> IntPtr.Zero Then 
	   Dim _trellistempl(Values.size -1) as Integer
	   Marshal.Copy(Values.trellistempl, _trellistempl, 0, _trellistempl.Length)
	   return _trellistempl
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' indices of best path templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (225, 20)
''' Org: [struct Numa * natempl]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property natempl as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.natempl <> IntPtr.Zero Then 
	   return New Numa (Values.natempl)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x locations of best path templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (226, 20)
''' Org: [struct Numa * naxloc]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naxloc as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naxloc <> IntPtr.Zero Then 
	   return New Numa (Values.naxloc)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y locations of best path templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (227, 20)
''' Org: [struct Numa * nadely]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nadely as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nadely <> IntPtr.Zero Then 
	   return New Numa (Values.nadely)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' widths of best path templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (228, 20)
''' Org: [struct Numa * nawidth]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nawidth as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nawidth <> IntPtr.Zero Then 
	   return New Numa (Values.nawidth)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Viterbi result for splitting input pixs
''' </summary>
''' <remarks>
''' Loc: ./recog.h (229, 20)
''' Org: [struct Boxa * boxa]
''' Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' correlation scores: best path templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (230, 20)
''' Org: [struct Numa * nascore]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nascore as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nascore <> IntPtr.Zero Then 
	   return New Numa (Values.nascore)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' indices of best rescored templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (231, 20)
''' Org: [struct Numa * natempl_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property natempl_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.natempl_r <> IntPtr.Zero Then 
	   return New Numa (Values.natempl_r)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' samples of best scored templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (232, 20)
''' Org: [struct Numa * nasample_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasample_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasample_r <> IntPtr.Zero Then 
	   return New Numa (Values.nasample_r)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x locations of best rescoredtemplates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (233, 20)
''' Org: [struct Numa * naxloc_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property naxloc_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.naxloc_r <> IntPtr.Zero Then 
	   return New Numa (Values.naxloc_r)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y locations of best rescoredtemplates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (234, 20)
''' Org: [struct Numa * nadely_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nadely_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nadely_r <> IntPtr.Zero Then 
	   return New Numa (Values.nadely_r)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' widths of best rescoredtemplates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (235, 20)
''' Org: [struct Numa * nawidth_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nawidth_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nawidth_r <> IntPtr.Zero Then 
	   return New Numa (Values.nawidth_r)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' correlation scores: rescored templates
''' </summary>
''' <remarks>
''' Loc: ./recog.h (236, 20)
''' Org: [struct Numa * nascore_r]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nascore_r as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nascore_r <> IntPtr.Zero Then 
	   return New Numa (Values.nascore_r)
	End if
	     return Nothing
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
#Region"regutils.h"
' ./regutils.h (117, 8)
'''<summary>
'''Regression test parameter packer
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_RegParams.txt" language="C" title="./regutils.h (117, 8)"/>
'''</example>
Public Class L_RegParams
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_RegParams
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' stream to temporary output file for compare mode
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (119, 14)
''' Org: [FILE * fp]
''' Msh: FILE * | 2:Struct |
''' </remarks>
	readonly property fp as FILE
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.fp <> IntPtr.Zero Then 
	   return New FILE (Values.fp)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' name of test, without '_reg'
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (120, 14)
''' Org: [char * testname]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property testname as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.testname <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.testname)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' name of temp file for compare mode output
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (121, 14)
''' Org: [char * tempfile]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property tempfile as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.tempfile <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.tempfile)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' generate, compare or display
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (122, 14)
''' Org: [l_int32 mode]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property mode as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.mode
	     return Nothing
	 End Get
	End Property

''' <summary>
''' index into saved files for this test 0-based
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (123, 14)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
	 End Get
	End Property

''' <summary>
''' overall result of the test
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (124, 14)
''' Org: [l_int32 success]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property success as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.success
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 1 if in display mode 0 otherwise
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (125, 14)
''' Org: [l_int32 display]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property display as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.display
	     return Nothing
	 End Get
	End Property

''' <summary>
''' marks beginning of the reg test
''' </summary>
''' <remarks>
''' Loc: ./regutils.h (126, 14)
''' Org: [L_TIMER tstart]
''' Msh: L_TIMER | 1:Pointer |
''' </remarks>
	readonly property tstart as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.tstart
	     return Nothing
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
#Region"stringcode.h"
' ./stringcode.h (40, 8)
'''<summary>
'''stringcode.h
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_StrCode.txt" language="C" title="./stringcode.h (40, 8)"/>
'''</example>
Public Class L_StrCode
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_StrCode
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' index for function and output file names
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (42, 19)
''' Org: [l_int32 fileno]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property fileno as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.fileno
	     return Nothing
	 End Get
	End Property

''' <summary>
''' index into struct currently being stored
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (43, 19)
''' Org: [l_int32 ifunc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ifunc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ifunc
	     return Nothing
	 End Get
	End Property

''' <summary>
''' store case code for extraction
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (44, 19)
''' Org: [SARRAY * function]
''' Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property _function_ as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values._function_ <> IntPtr.Zero Then 
	   return New Sarray (Values._function_)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' store base64 encoded data as strings
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (45, 19)
''' Org: [SARRAY * data]
''' Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property data as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.data <> IntPtr.Zero Then 
	   return New Sarray (Values.data)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' store line in description table
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (46, 19)
''' Org: [SARRAY * descr]
''' Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
''' </remarks>
	readonly property descr as Sarray
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.descr <> IntPtr.Zero Then 
	   return New Sarray (Values.descr)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of data strings
''' </summary>
''' <remarks>
''' Loc: ./stringcode.h (47, 19)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
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
#Region"sudoku.h"
' ./sudoku.h (52, 8)
'''<summary>
'''sudoku.h
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Sudoku.txt" language="C" title="./sudoku.h (52, 8)"/>
'''</example>
Public Class L_Sudoku
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Sudoku
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' number of unknowns
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (54, 20)
''' Org: [l_int32 num]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property num as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.num
	     return Nothing
	 End Get
	End Property

''' <summary>
''' location of unknowns
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (55, 20)
''' Org: [l_int32 * locs]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property locs as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.locs <> IntPtr.Zero Then 
	   Dim _locs(1 -1) as Integer
	   Marshal.Copy(Values.locs, _locs, 0, _locs.Length)
	   return _locs
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' index into %locs of current location
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (56, 20)
''' Org: [l_int32 current]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property current as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.current
	     return Nothing
	 End Get
	End Property

''' <summary>
''' initial state, with 0 representing
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (57, 20)
''' Org: [l_int32 * init]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property init as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.init <> IntPtr.Zero Then 
	   Dim _init(1 -1) as Integer
	   Marshal.Copy(Values.init, _init, 0, _init.Length)
	   return _init
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' present state, including inits and
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (59, 20)
''' Org: [l_int32 * state]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property state as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.state <> IntPtr.Zero Then 
	   Dim _state(1 -1) as Integer
	   Marshal.Copy(Values.state, _state, 0, _state.Length)
	   return _state
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' shows current number of guesses
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (61, 20)
''' Org: [l_int32 nguess]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nguess as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nguess
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 when solved
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (62, 20)
''' Org: [l_int32 finished]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property finished as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.finished
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 if no solution is possible
''' </summary>
''' <remarks>
''' Loc: ./sudoku.h (63, 20)
''' Org: [l_int32 failure]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property failure as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.failure
	     return Nothing
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
#Region"watershed.h"
' ./watershed.h (38, 8)
'''<summary>
'''Simple data structure to hold watershed data.
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_WShed.txt" language="C" title="./watershed.h (38, 8)"/>
'''</example>
Public Class L_WShed
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_WShed
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' clone of input 8 bpp pixs
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (40, 20)
''' Org: [struct Pix * pixs]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixs as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixs <> IntPtr.Zero Then 
	   return New Pix (Values.pixs)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' clone of input 1 bpp seed (marker) pixm
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (41, 20)
''' Org: [struct Pix * pixm]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixm as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixm <> IntPtr.Zero Then 
	   return New Pix (Values.pixm)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' minimum depth allowed for a watershed
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (42, 20)
''' Org: [l_int32 mindepth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property mindepth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.mindepth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 16 bpp label pix
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (43, 20)
''' Org: [struct Pix * pixlab]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixlab as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixlab <> IntPtr.Zero Then 
	   return New Pix (Values.pixlab)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' scratch pix for computing wshed regions
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (44, 20)
''' Org: [struct Pix * pixt]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixt as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixt <> IntPtr.Zero Then 
	   return New Pix (Values.pixt)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' line ptrs for pixs
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (45, 20)
''' Org: [void ** lines8]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property lines8 as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.lines8 <> IntPtr.Zero Then 
	   Dim _lines8(1) as IntPtr
	   Marshal.Copy(Values.lines8, _lines8, 0, 1)
	   return _lines8
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' line ptrs for pixm
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (46, 20)
''' Org: [void ** linem1]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property linem1 as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.linem1 <> IntPtr.Zero Then 
	   Dim _linem1(1) as IntPtr
	   Marshal.Copy(Values.linem1, _linem1, 0, 1)
	   return _linem1
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' line ptrs for pixlab
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (47, 20)
''' Org: [void ** linelab32]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property linelab32 as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.linelab32 <> IntPtr.Zero Then 
	   Dim _linelab32(1) as IntPtr
	   Marshal.Copy(Values.linelab32, _linelab32, 0, 1)
	   return _linelab32
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' line ptrs for pixt
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (48, 20)
''' Org: [void ** linet1]
''' Msh: void ** | 3:Void | IntPtr()
''' </remarks>
	readonly property linet1 as IntPtr()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Void
	If Values.linet1 <> IntPtr.Zero Then 
	   Dim _linet1(1) as IntPtr
	   Marshal.Copy(Values.linet1, _linet1, 0, 1)
	   return _linet1
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' result: 1 bpp pixa of watersheds
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (49, 20)
''' Org: [struct Pixa * pixad]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixad as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixad <> IntPtr.Zero Then 
	   return New Pixa (Values.pixad)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pta of initial seed pixels
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (50, 20)
''' Org: [struct Pta * ptas]
''' Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
''' </remarks>
	readonly property ptas as Pta
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.ptas <> IntPtr.Zero Then 
	   return New Pta (Values.ptas)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' numa of seed indicators 0 if completed
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (51, 20)
''' Org: [struct Numa * nasi]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nasi as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nasi <> IntPtr.Zero Then 
	   return New Numa (Values.nasi)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' numa of initial seed heights
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (52, 20)
''' Org: [struct Numa * nash]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nash as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nash <> IntPtr.Zero Then 
	   return New Numa (Values.nash)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' numa of initial minima heights
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (53, 20)
''' Org: [struct Numa * namh]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property namh as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.namh <> IntPtr.Zero Then 
	   return New Numa (Values.namh)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' result: numa of watershed levels
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (54, 20)
''' Org: [struct Numa * nalevels]
''' Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
''' </remarks>
	readonly property nalevels as Numa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.nalevels <> IntPtr.Zero Then 
	   return New Numa (Values.nalevels)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of seeds (markers)
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (55, 20)
''' Org: [l_int32 nseeds]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nseeds as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nseeds
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of minima different from seeds
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (56, 20)
''' Org: [l_int32 nother]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nother as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nother
	     return Nothing
	 End Get
	End Property

''' <summary>
''' lut for pixel indices
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (57, 20)
''' Org: [l_int32 * lut]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property lut as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.lut <> IntPtr.Zero Then 
	   Dim _lut(1 -1) as Integer
	   Marshal.Copy(Values.lut, _lut, 0, _lut.Length)
	   return _lut
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' back-links into lut, for updates
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (58, 20)
''' Org: [struct Numa ** links]
''' Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
''' </remarks>
	readonly property links as List(of Numa)
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Struct Level 3 (Struct)
	If Values.links <> IntPtr.Zero Then
	   Dim LSTRET As New List(Of Numa)
	   Dim LSTPTR (1 - 1) As IntPtr
	   Marshal.Copy(Values.links, LSTPTR, 0, 1)
	   For Each Entry In LSTPTR
	       LSTRET.Add(New Numa(Entry))
	   Next
	   return LSTRET
	End If
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of links array
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (59, 20)
''' Org: [l_int32 arraysize]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property arraysize as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.arraysize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set to 1 for debug output
''' </summary>
''' <remarks>
''' Loc: ./watershed.h (60, 20)
''' Org: [l_int32 debug]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property debug as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.debug
	     return Nothing
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
#Region"bilateral.h"
' ./bilateral.h (115, 8)
'''<summary>
'''Bilateral filter
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Bilateral.txt" language="C" title="./bilateral.h (115, 8)"/>
'''</example>
Public Class L_Bilateral
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Bilateral
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' clone of source pix
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (117, 21)
''' Org: [struct Pix * pixs]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixs as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixs <> IntPtr.Zero Then 
	   return New Pix (Values.pixs)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' downscaled pix with mirrored border
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (118, 21)
''' Org: [struct Pix * pixsc]
''' Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
''' </remarks>
	readonly property pixsc as Pix
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixsc <> IntPtr.Zero Then 
	   return New Pix (Values.pixsc)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 1, 2 or 4x for intermediates
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (119, 21)
''' Org: [l_int32 reduction]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property reduction as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.reduction
	     return Nothing
	 End Get
	End Property

''' <summary>
''' stdev of spatial gaussian
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (120, 21)
''' Org: [l_float32 spatial_stdev]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property spatial_stdev as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.spatial_stdev
	     return Nothing
	 End Get
	End Property

''' <summary>
''' stdev of range gaussian
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (121, 21)
''' Org: [l_float32 range_stdev]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property range_stdev as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.range_stdev
	     return Nothing
	 End Get
	End Property

''' <summary>
''' 1D gaussian spatial kernel
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (122, 21)
''' Org: [l_float32 * spatial]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property spatial as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.spatial <> IntPtr.Zero Then 
	   Dim _spatial(1 -1) as Single
	   Marshal.Copy(Values.spatial, _spatial, 0, _spatial.Length)
	   return _spatial
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' one-sided gaussian range kernel
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (123, 21)
''' Org: [l_float32 * range]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property range as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.range <> IntPtr.Zero Then 
	   Dim _range(1 -1) as Single
	   Marshal.Copy(Values.range, _range, 0, _range.Length)
	   return _range
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' min value in 8 bpp pix
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (124, 21)
''' Org: [l_int32 minval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property minval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minval
	     return Nothing
	 End Get
	End Property

''' <summary>
''' max value in 8 bpp pix
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (125, 21)
''' Org: [l_int32 maxval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property maxval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.maxval
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of intermediate results
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (126, 21)
''' Org: [l_int32 ncomps]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property ncomps as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.ncomps
	     return Nothing
	 End Get
	End Property

''' <summary>
''' set of k values (size ncomps)
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (127, 21)
''' Org: [l_int32 * nc]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property nc as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.nc <> IntPtr.Zero Then 
	   Dim _nc(1 -1) as Integer
	   Marshal.Copy(Values.nc, _nc, 0, _nc.Length)
	   return _nc
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' mapping from intensity to lower k
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (128, 21)
''' Org: [l_int32 * kindex]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property kindex as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.kindex <> IntPtr.Zero Then 
	   Dim _kindex(1 -1) as Integer
	   Marshal.Copy(Values.kindex, _kindex, 0, _kindex.Length)
	   return _kindex
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' mapping from intensity to fract k
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (129, 21)
''' Org: [l_float32 * kfract]
''' Msh: l_float32 * | 2:Float |  ... = Single
''' </remarks>
	readonly property kfract as Single()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.kfract <> IntPtr.Zero Then 
	   Dim _kfract(1 -1) as Single
	   Marshal.Copy(Values.kfract, _kfract, 0, _kfract.Length)
	   return _kfract
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' intermediate result images (PBC)
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (130, 21)
''' Org: [struct Pixa * pixac]
''' Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
''' </remarks>
	readonly property pixac as Pixa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.pixac <> IntPtr.Zero Then 
	   return New Pixa (Values.pixac)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' lineptrs for pixac
''' </summary>
''' <remarks>
''' Loc: ./bilateral.h (131, 21)
''' Org: [l_uint32 *** lineset]
''' Msh: l_uint32 *** | 3:UInt | List (of List ( of List (of Byte()))) ... UInt => Byte[4]
''' </remarks>
	readonly property lineset as List (of List (of List (of Byte())))
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _Data1(4 - 1) As Byte
	Dim _DataFin As new List (of List ( of List (of Byte())))
	Marshal.Copy(Values.lineset, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	  Dim _Data2(4 - 1) As Byte
	  Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	  _DataFin.AddRange(_Data2)
	Next
	return _DataFin
	     return Nothing
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
#Region"bmp.h"
' ./bmp.h (50, 8)
'''<summary>
'''BMP file header
'''</summary>
'''<example>
'''<code source="CSource\Struct_BMP_FileHeader.txt" language="C" title="./bmp.h (50, 8)"/>
'''</example>
Public Class BMP_FileHeader
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_BMP_FileHeader
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' file type must be "BM"
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (52, 20)
''' Org: [l_int16 bfType]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfType as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfType
	     return Nothing
	 End Get
	End Property

''' <summary>
''' length of the file sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (53, 20)
''' Org: [l_int16 bfSize]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfSize as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfSize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' remainder of the bfSize field
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (58, 20)
''' Org: [l_int16 bfFill1]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfFill1 as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfFill1
	     return Nothing
	 End Get
	End Property

''' <summary>
''' don't care (set to 0)
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (59, 20)
''' Org: [l_int16 bfReserved1]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfReserved1 as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfReserved1
	     return Nothing
	 End Get
	End Property

''' <summary>
''' don't care (set to 0)
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (60, 20)
''' Org: [l_int16 bfReserved2]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfReserved2 as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfReserved2
	     return Nothing
	 End Get
	End Property

''' <summary>
''' offset from beginning of file
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (61, 20)
''' Org: [l_int16 bfOffBits]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfOffBits as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfOffBits
	     return Nothing
	 End Get
	End Property

''' <summary>
''' remainder of the bfOffBits field
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (62, 20)
''' Org: [l_int16 bfFill2]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property bfFill2 as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bfFill2
	     return Nothing
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


' ./bmp.h (75, 8)
'''<summary>
'''BMP info header
'''</summary>
'''<example>
'''<code source="CSource\Struct_BMP_InfoHeader.txt" language="C" title="./bmp.h (75, 8)"/>
'''</example>
Public Class BMP_InfoHeader
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_BMP_InfoHeader
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' size of the BMP_InfoHeader struct
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (77, 20)
''' Org: [l_int32 biSize]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biSize as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biSize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' bitmap width in pixels
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (78, 20)
''' Org: [l_int32 biWidth]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biWidth as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biWidth
	     return Nothing
	 End Get
	End Property

''' <summary>
''' bitmap height in pixels
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (79, 20)
''' Org: [l_int32 biHeight]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biHeight as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biHeight
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of bitmap planes
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (80, 20)
''' Org: [l_int16 biPlanes]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property biPlanes as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biPlanes
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of bits per pixel
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (81, 20)
''' Org: [l_int16 biBitCount]
''' Msh: l_int16 | 1:Short |
''' </remarks>
	readonly property biBitCount as Short
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biBitCount
	     return Nothing
	 End Get
	End Property

''' <summary>
''' compress format (0 == uncompressed)
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (82, 20)
''' Org: [l_int32 biCompression]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biCompression as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biCompression
	     return Nothing
	 End Get
	End Property

''' <summary>
''' size of image in bytes
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (83, 20)
''' Org: [l_int32 biSizeImage]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biSizeImage as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biSizeImage
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pixels per meter in x direction
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (84, 20)
''' Org: [l_int32 biXPelsPerMeter]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biXPelsPerMeter as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biXPelsPerMeter
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pixels per meter in y direction
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (85, 20)
''' Org: [l_int32 biYPelsPerMeter]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biYPelsPerMeter as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biYPelsPerMeter
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of colors used
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (86, 20)
''' Org: [l_int32 biClrUsed]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biClrUsed as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biClrUsed
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of important colors used
''' </summary>
''' <remarks>
''' Loc: ./bmp.h (87, 20)
''' Org: [l_int32 biClrImportant]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property biClrImportant as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.biClrImportant
	     return Nothing
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
#Region"lorquant1.c"
' colorquant1.c (158, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_ColorQuantCell.txt" language="C" title="colorquant1.c (158, 8)"/>
'''</example>
Public Class ColorQuantCell
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_ColorQuantCell
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: colorquant1.c (160, 17)
''' Org: [l_int32 rc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rc
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (160, 21)
''' Org: [l_int32 gc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property gc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.gc
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (160, 25)
''' Org: [l_int32 bc]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bc as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bc
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (161, 17)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (162, 17)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (163, 17)
''' Org: [l_int32 nleaves]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nleaves as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nleaves
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (164, 17)
''' Org: [l_int32 bleaf]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bleaf as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bleaf
	     return Nothing
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


' colorquant1.c (190, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_OctcubeQuantCell.txt" language="C" title="colorquant1.c (190, 8)"/>
'''</example>
Public Class OctcubeQuantCell
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_OctcubeQuantCell
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: colorquant1.c (192, 16)
''' Org: [l_float32 n]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property n as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (193, 16)
''' Org: [l_int32 octindex]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property octindex as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.octindex
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (194, 16)
''' Org: [l_int32 rcum]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rcum as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rcum
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (194, 22)
''' Org: [l_int32 gcum]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property gcum as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.gcum
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (194, 28)
''' Org: [l_int32 bcum]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bcum as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bcum
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (195, 16)
''' Org: [l_int32 rval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rval
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (195, 22)
''' Org: [l_int32 gval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property gval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.gval
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (195, 28)
''' Org: [l_int32 bval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bval
	     return Nothing
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


' colorquant1.c (206, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_OctcubePop.txt" language="C" title="colorquant1.c (206, 8)"/>
'''</example>
Public Class L_OctcubePop
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_OctcubePop
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: colorquant1.c (208, 22)
''' Org: [l_float32 npix]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property npix as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.npix
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (209, 22)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (210, 22)
''' Org: [l_int32 rval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property rval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rval
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (211, 22)
''' Org: [l_int32 gval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property gval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.gval
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant1.c (212, 22)
''' Org: [l_int32 bval]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property bval as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bval
	     return Nothing
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
#Region"lorquant2.c"
' colorquant2.c (178, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Box3d.txt" language="C" title="colorquant2.c (178, 8)"/>
'''</example>
Public Class L_Box3d
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Box3d
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: colorquant2.c (180, 22)
''' Org: [l_float32 sortparam]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property sortparam as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.sortparam
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (181, 22)
''' Org: [l_int32 npix]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property npix as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.npix
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (182, 22)
''' Org: [l_int32 vol]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property vol as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.vol
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (183, 22)
''' Org: [l_int32 r1]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property r1 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.r1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (184, 22)
''' Org: [l_int32 r2]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property r2 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.r2
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (185, 22)
''' Org: [l_int32 g1]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property g1 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.g1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (186, 22)
''' Org: [l_int32 g2]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property g2 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.g2
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (187, 22)
''' Org: [l_int32 b1]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property b1 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.b1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: colorquant2.c (188, 22)
''' Org: [l_int32 b2]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property b2 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.b2
	     return Nothing
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
#Region"nncomp.c"
' conncomp.c (99, 8)
'''<summary>
'''The struct FillSeg is used by the Heckbert seedfill algorithm to hold information about image segments that are waiting to be investigated. We use two Stacks, one to hold the FillSegs in use, and an auxiliary Stack as a reservoir to hold FillSegs for re-use.
'''</summary>
'''<example>
'''<code source="CSource\Struct_FillSeg.txt" language="C" title="conncomp.c (99, 8)"/>
'''</example>
Public Class FillSeg
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_FillSeg
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' left edge of run
''' </summary>
''' <remarks>
''' Loc: conncomp.c (101, 16)
''' Org: [l_int32 xleft]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xleft as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xleft
	     return Nothing
	 End Get
	End Property

''' <summary>
''' right edge of run
''' </summary>
''' <remarks>
''' Loc: conncomp.c (102, 16)
''' Org: [l_int32 xright]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property xright as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.xright
	     return Nothing
	 End Get
	End Property

''' <summary>
''' run y
''' </summary>
''' <remarks>
''' Loc: conncomp.c (103, 16)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

''' <summary>
''' parent segment direction: 1 above, -1 below)
''' </summary>
''' <remarks>
''' Loc: conncomp.c (104, 16)
''' Org: [l_int32 dy]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property dy as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.dy
	     return Nothing
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
#Region"class.c"
' jbclass.c (236, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_JbFindTemplatesState.txt" language="C" title="jbclass.c (236, 8)"/>
'''</example>
Public Class JbFindTemplatesState
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_JbFindTemplatesState
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: jbclass.c (238, 22)
''' Org: [JBCLASSER * classer]
''' Msh: JBCLASSER * | 2:Struct |  | Typedef: JbClasser = JbClasser
''' </remarks>
	readonly property classer as JbClasser
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.classer <> IntPtr.Zero Then 
	   return New JbClasser (Values.classer)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jbclass.c (239, 22)
''' Org: [l_int32 w]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property w as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.w
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jbclass.c (240, 22)
''' Org: [l_int32 h]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property h as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.h
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jbclass.c (241, 22)
''' Org: [l_int32 i]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property i as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.i
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jbclass.c (242, 22)
''' Org: [L_DNA * dna]
''' Msh: L_DNA * | 2:Struct |  | Typedef: L_Dna = L_Dna
''' </remarks>
	readonly property dna as L_Dna
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.dna <> IntPtr.Zero Then 
	   return New L_Dna (Values.dna)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jbclass.c (243, 22)
''' Org: [l_int32 n]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property n as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.n
	     return Nothing
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
#Region"egio.c"
' jpegio.c (164, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_callback_data.txt" language="C" title="jpegio.c (164, 8)"/>
'''</example>
Public Class callback_data
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_callback_data
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: jpegio.c (165, 15)
''' Org: [jmp_buf jmpbuf]
''' Msh: jmp_buf | 1:ConstantArray |
''' </remarks>
	readonly property jmpbuf as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.jmpbuf
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: jpegio.c (166, 15)
''' Org: [l_uint8 * comment]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property comment as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.comment <> IntPtr.Zero Then 
	   Dim _comment(1 -1) as Byte
	   Marshal.Copy(Values.comment, _comment, 0, _comment.Length)
	   return _comment
	End if
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_callback_data
		public jmpbuf as Char
		public comment as IntPtr
	End Class
End Class


#End Region
#Region"ze.c"
' maze.c (76, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_MazeElement.txt" language="C" title="maze.c (76, 8)"/>
'''</example>
Public Class MazeElement
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_MazeElement
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: maze.c (77, 16)
''' Org: [l_float32 distance]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property distance as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.distance
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: maze.c (78, 16)
''' Org: [l_int32 x]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property x as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.x
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: maze.c (79, 16)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: maze.c (80, 16)
''' Org: [l_uint32 val]
''' Msh: l_uint32 | 1:UInt |
''' </remarks>
	readonly property val as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.val
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: maze.c (81, 16)
''' Org: [l_int32 dir]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property dir as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.dir
	     return Nothing
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
#Region"rtition.c"
' partition.c (48, 8)
'''<summary>
'''Partition element
'''</summary>
'''<example>
'''<code source="CSource\Struct_PartitionElement.txt" language="C" title="partition.c (48, 8)"/>
'''</example>
Public Class PartitionElement
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PartitionElement
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: partition.c (49, 16)
''' Org: [l_float32 size]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property size as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: partition.c (50, 16)
''' Org: [BOX * box]
''' Msh: BOX * | 2:Struct |  | Typedef: Box = Box
''' </remarks>
	readonly property box as Box
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.box <> IntPtr.Zero Then 
	   return New Box (Values.box)
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: partition.c (51, 16)
''' Org: [BOXA * boxa]
''' Msh: BOXA * | 2:Struct |  | Typedef: Boxa = Boxa
''' </remarks>
	readonly property boxa as Boxa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.boxa <> IntPtr.Zero Then 
	   return New Boxa (Values.boxa)
	End if
	     return Nothing
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
#Region"x1.c"
' pix1.c (218, 8)
'''<summary>
'''Pix memory manager
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixMemoryManager.txt" language="C" title="pix1.c (218, 8)"/>
'''</example>
Public Class PixMemoryManager
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixMemoryManager
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: pix1.c (220, 17)
''' Org: [alloc_fn allocator]
''' Msh: alloc_fn | 1:Pointer |
''' </remarks>
	readonly property allocator as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.allocator
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: pix1.c (221, 17)
''' Org: [dealloc_fn deallocator]
''' Msh: dealloc_fn | 1:Pointer |
''' </remarks>
	readonly property deallocator as IntPtr
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.deallocator
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_PixMemoryManager
		public allocator as IntPtr
		public deallocator as IntPtr
	End Class
End Class


#End Region
#Region"xalloc.c"
' pixalloc.c (113, 8)
'''<summary>
'''Pix memory storage
'''</summary>
'''<example>
'''<code source="CSource\Struct_PixMemoryStore.txt" language="C" title="pixalloc.c (113, 8)"/>
'''</example>
Public Class PixMemoryStore
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_PixMemoryStore
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' Holds ptrs to allocated memory
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (115, 22)
''' Org: [struct L_Ptraa * paa]
''' Msh: struct L_Ptraa * | 2:Struct |  | Typedef: L_Ptraa = L_Ptraa
''' </remarks>
	readonly property paa as L_Ptraa
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.paa <> IntPtr.Zero Then 
	   return New L_Ptraa (Values.paa)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Pix smaller than this (in bytes)
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (116, 22)
''' Org: [size_t minsize]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property minsize as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.minsize
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Smallest mem (in bytes) alloc'd
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (118, 22)
''' Org: [size_t smallest]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property smallest as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.smallest
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Larest mem (in bytes) alloc'd
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (119, 22)
''' Org: [size_t largest]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property largest as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.largest
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Size of allocated block w/ all chunks
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (120, 22)
''' Org: [size_t nbytes]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property nbytes as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nbytes
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Num of power-of-2 sizes pre-alloc'd
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (121, 22)
''' Org: [l_int32 nlevels]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property nlevels as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.nlevels
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Mem sizes at each power-of-2 level
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (122, 22)
''' Org: [size_t * sizes]
''' Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
''' </remarks>
	readonly property sizes as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _sizes(1 -1) as Byte
	Marshal.Copy(Values.sizes, _sizes, 0, _sizes.Length)
	return _sizes
	     return Nothing
	 End Get
	End Property

''' <summary>
''' Number of mem alloc'd at each size
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (123, 22)
''' Org: [l_int32 * allocarray]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property allocarray as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.allocarray <> IntPtr.Zero Then 
	   Dim _allocarray(1 -1) as Integer
	   Marshal.Copy(Values.allocarray, _allocarray, 0, _allocarray.Length)
	   return _allocarray
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr to allocated array
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (124, 22)
''' Org: [l_uint32 * baseptr]
''' Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
''' </remarks>
	readonly property baseptr as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _baseptr(1 -1) as Byte
	Marshal.Copy(Values.baseptr, _baseptr, 0, _baseptr.Length)
	return _baseptr
	     return Nothing
	 End Get
	End Property

''' <summary>
''' ptr just beyond allocated memory
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (125, 22)
''' Org: [l_uint32 * maxptr]
''' Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
''' </remarks>
	readonly property maxptr as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _maxptr(1 -1) as Byte
	Marshal.Copy(Values.maxptr, _maxptr, 0, _maxptr.Length)
	return _maxptr
	     return Nothing
	 End Get
	End Property

''' <summary>
''' array of ptrs to first chunk in size
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (126, 22)
''' Org: [l_uint32 ** firstptr]
''' Msh: l_uint32 ** | 3:UInt | List (of byte()) ... UInt nicht Marshalbar. Verwende 4 Bytes
''' </remarks>
	readonly property firstptr as List(of Byte())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(4 - 1) As Byte
	Dim _DataFin As New List(Of Byte())
	Marshal.Copy(Values.firstptr, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(4 - 1) As Byte
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
	 End Get
	End Property

''' <summary>
''' log: total # of pix used (by level)
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (127, 22)
''' Org: [l_int32 * memused]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property memused as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.memused <> IntPtr.Zero Then 
	   Dim _memused(1 -1) as Integer
	   Marshal.Copy(Values.memused, _memused, 0, _memused.Length)
	   return _memused
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' log: # of pix in use (by level)
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (128, 22)
''' Org: [l_int32 * meminuse]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property meminuse as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.meminuse <> IntPtr.Zero Then 
	   Dim _meminuse(1 -1) as Integer
	   Marshal.Copy(Values.meminuse, _meminuse, 0, _meminuse.Length)
	   return _meminuse
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' log: max # of pix in use (by level)
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (129, 22)
''' Org: [l_int32 * memmax]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property memmax as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.memmax <> IntPtr.Zero Then 
	   Dim _memmax(1 -1) as Integer
	   Marshal.Copy(Values.memmax, _memmax, 0, _memmax.Length)
	   return _memmax
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' log: # of pix alloc'd because
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (130, 22)
''' Org: [l_int32 * memempty]
''' Msh: l_int32 * | 2:Int | Integer() -  - Integer()
''' </remarks>
	readonly property memempty as Integer()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.memempty <> IntPtr.Zero Then 
	   Dim _memempty(1 -1) as Integer
	   Marshal.Copy(Values.memempty, _memempty, 0, _memempty.Length)
	   return _memempty
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' log: set to null if no logging
''' </summary>
''' <remarks>
''' Loc: pixalloc.c (132, 22)
''' Org: [char * logfile]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property logfile as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.logfile <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.logfile)
	End if
	     return Nothing
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
#Region"gio.c"
' pngio.c (1293, 8)
'''<summary>
'''A node in a linked list of memory buffers that hold I/O content
'''</summary>
'''<example>
'''<code source="CSource\Struct_MemIOData.txt" language="C" title="pngio.c (1293, 8)"/>
'''</example>
Public Class MemIOData
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_MemIOData
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' pointer to this node's I/O content
''' </summary>
''' <remarks>
''' Loc: pngio.c (1295, 17)
''' Org: [char * m_Buffer]
''' Msh: char * | 2:CharS |
''' </remarks>
	readonly property m_Buffer as String
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.m_Buffer <> IntPtr.Zero Then
	   return Marshal.PtrToStringAnsi(Values.m_Buffer)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' number of I/O content bytes read or written
''' </summary>
''' <remarks>
''' Loc: pngio.c (1296, 17)
''' Org: [l_int32 m_Count]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property m_Count as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.m_Count
	     return Nothing
	 End Get
	End Property

''' <summary>
''' allocated size of m_buffer
''' </summary>
''' <remarks>
''' Loc: pngio.c (1297, 17)
''' Org: [l_int32 m_Size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property m_Size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.m_Size
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pointer to the next node in the list
''' </summary>
''' <remarks>
''' Loc: pngio.c (1298, 24)
''' Org: [struct MemIOData * m_Next]
''' Msh: struct MemIOData * | 2:Struct |
''' </remarks>
	readonly property m_Next as MemIOData
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.m_Next <> IntPtr.Zero Then 
	   return New MemIOData (Values.m_Next)
	End if
	     return Nothing
	 End Get
	End Property

''' <summary>
''' pointer to the last node in the linked
''' </summary>
''' <remarks>
''' Loc: pngio.c (1300, 24)
''' Org: [struct MemIOData * m_Last]
''' Msh: struct MemIOData * | 2:Struct |
''' </remarks>
	readonly property m_Last as MemIOData
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Depth:2 'StructureDeclaration'
	If Values.m_Last <> IntPtr.Zero Then 
	   return New MemIOData (Values.m_Last)
	End if
	     return Nothing
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
#Region"edfill.c"
' seedfill.c (170, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Pixel.txt" language="C" title="seedfill.c (170, 8)"/>
'''</example>
Public Class L_Pixel
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Pixel
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: seedfill.c (172, 16)
''' Org: [l_int32 x]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property x as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.x
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: seedfill.c (173, 16)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_Pixel
		public x as Integer
		public y as Integer
	End Class
End Class


#End Region
#Region"l1.c"
' sel1.c (152, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_CompParameterMap.txt" language="C" title="sel1.c (152, 8)"/>
'''</example>
Public Class CompParameterMap
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_CompParameterMap
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: sel1.c (154, 14)
''' Org: [l_int32 size]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property size as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (155, 14)
''' Org: [l_int32 size1]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property size1 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (156, 14)
''' Org: [l_int32 size2]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property size2 as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.size2
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (157, 14)
''' Org: [char [20] selnameh1]
''' Msh: char [20] | 1:ConstantArray |
''' </remarks>
	readonly property selnameh1 as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.selnameh1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (158, 14)
''' Org: [char [20] selnameh2]
''' Msh: char [20] | 1:ConstantArray |
''' </remarks>
	readonly property selnameh2 as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.selnameh2
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (159, 14)
''' Org: [char [20] selnamev1]
''' Msh: char [20] | 1:ConstantArray |
''' </remarks>
	readonly property selnamev1 as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.selnamev1
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: sel1.c (160, 14)
''' Org: [char [20] selnamev2]
''' Msh: char [20] | 1:ConstantArray |
''' </remarks>
	readonly property selnamev2 as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.selnamev2
	     return Nothing
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
#Region"ringcode.c"
' stringcode.c (95, 8)
'''<summary>
'''Associations between names and functions
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_GenAssoc.txt" language="C" title="stringcode.c (95, 8)"/>
'''</example>
Public Class L_GenAssoc
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_GenAssoc
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: stringcode.c (97, 14)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: stringcode.c (98, 14)
''' Org: [char [16] type]
''' Msh: char [16] | 1:ConstantArray |
''' </remarks>
	readonly property type as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.type
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: stringcode.c (99, 14)
''' Org: [char [16] structname]
''' Msh: char [16] | 1:ConstantArray |
''' </remarks>
	readonly property structname as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.structname
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: stringcode.c (100, 14)
''' Org: [char [16] reader]
''' Msh: char [16] | 1:ConstantArray |
''' </remarks>
	readonly property reader as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.reader
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: stringcode.c (101, 14)
''' Org: [char [20] memreader]
''' Msh: char [20] | 1:ConstantArray |
''' </remarks>
	readonly property memreader as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.memreader
	     return Nothing
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
#Region"ffio.c"
' tiffio.c (155, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_tiff_transform.txt" language="C" title="tiffio.c (155, 8)"/>
'''</example>
Public Class tiff_transform
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_tiff_transform
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: tiffio.c (156, 9)
''' Org: [int vflip]
''' Msh: int | 1:Int |
''' </remarks>
	readonly property vflip as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.vflip
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (157, 9)
''' Org: [int hflip]
''' Msh: int | 1:Int |
''' </remarks>
	readonly property hflip as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.hflip
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (158, 9)
''' Org: [int rotate]
''' Msh: int | 1:Int |
''' </remarks>
	readonly property rotate as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.rotate
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_tiff_transform
		public vflip as Integer
		public hflip as Integer
		public rotate as Integer
	End Class
End Class


' tiffio.c (2174, 8)
'''<summary>
'''Memory stream buffer used with TIFFClientOpen()
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_Memstream.txt" language="C" title="tiffio.c (2174, 8)"/>
'''</example>
Public Class L_Memstream
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_Memstream
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: tiffio.c (2176, 16)
''' Org: [l_uint8 * buffer]
''' Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
''' </remarks>
	readonly property buffer as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	If Values.buffer <> IntPtr.Zero Then 
	   Dim _buffer(1 -1) as Byte
	   Marshal.Copy(Values.buffer, _buffer, 0, _buffer.Length)
	   return _buffer
	End if
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (2178, 16)
''' Org: [size_t bufsize]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property bufsize as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.bufsize
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (2180, 16)
''' Org: [size_t offset]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property offset as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.offset
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (2181, 16)
''' Org: [size_t hw]
''' Msh: size_t | 1:UInt |
''' </remarks>
	readonly property hw as UInteger
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.hw
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (2182, 16)
''' Org: [l_uint8 ** poutdata]
''' Msh: l_uint8 ** | 3:UChar | Byte() ... Pointer auf ein Byte-Array
''' </remarks>
	readonly property poutdata as List(of Byte())
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	' Structs.cs : Struct 3 : Else
	Dim _Data1(1 - 1) As Byte
	Dim _DataFin As New List(Of Byte())
	Marshal.Copy(Values.poutdata, _Data1, 0, _Data1.Length)
	For Each eintrag In _Data1
	   Dim _Data2(1 - 1) As Byte
	   Marshal.Copy(eintrag, _Data2, 0, _Data2.Length)
	   _DataFin.Add(_Data2)
	Next
	return _DataFin
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: tiffio.c (2183, 16)
''' Org: [size_t * poutsize]
''' Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
''' </remarks>
	readonly property poutsize as Byte()
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     	Dim _poutsize(1 -1) as Byte
	Marshal.Copy(Values.poutsize, _poutsize, 0, _poutsize.Length)
	return _poutsize
	     return Nothing
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
#Region"tershed.c"
' watershed.c (124, 8)
'''<summary>
'''New pixel coordinates
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_NewPixel.txt" language="C" title="watershed.c (124, 8)"/>
'''</example>
Public Class L_NewPixel
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_NewPixel
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' x coordinate
''' </summary>
''' <remarks>
''' Loc: watershed.c (126, 16)
''' Org: [l_int32 x]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property x as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.x
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y coordinate
''' </summary>
''' <remarks>
''' Loc: watershed.c (127, 16)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_L_NewPixel
		public x as Integer
		public y as Integer
	End Class
End Class


' watershed.c (132, 8)
'''<summary>
'''Wartshed pixel
'''</summary>
'''<example>
'''<code source="CSource\Struct_L_WSPixel.txt" language="C" title="watershed.c (132, 8)"/>
'''</example>
Public Class L_WSPixel
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_L_WSPixel
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <summary>
''' pixel value
''' </summary>
''' <remarks>
''' Loc: watershed.c (134, 16)
''' Org: [l_float32 val]
''' Msh: l_float32 | 1:Float |
''' </remarks>
	readonly property val as Single
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.val
	     return Nothing
	 End Get
	End Property

''' <summary>
''' x coordinate
''' </summary>
''' <remarks>
''' Loc: watershed.c (135, 16)
''' Org: [l_int32 x]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property x as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.x
	     return Nothing
	 End Get
	End Property

''' <summary>
''' y coordinate
''' </summary>
''' <remarks>
''' Loc: watershed.c (136, 16)
''' Org: [l_int32 y]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property y as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.y
	     return Nothing
	 End Get
	End Property

''' <summary>
''' label for set to which pixel belongs
''' </summary>
''' <remarks>
''' Loc: watershed.c (137, 16)
''' Org: [l_int32 index]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property index as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.index
	     return Nothing
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
#Region"itefile.c"
' writefile.c (139, 8)
'''<summary>
'''
'''</summary>
'''<example>
'''<code source="CSource\Struct_ExtensionMap.txt" language="C" title="writefile.c (139, 8)"/>
'''</example>
Public Class ExtensionMap
Implements IDisposable
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Public Pointer as IntPtr
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Values as new Marshal_ExtensionMap
	<DebuggerBrowsable(DebuggerBrowsableState.Never)> Private Caching as new Dictionary (of String, Object)

	#Region "IDisposable Support"
	   <DebuggerBrowsable(DebuggerBrowsableState.Never)>
	   Private disposedValue As Boolean
	       Protected Overridable Sub Dispose(ByVal disposing As Boolean)
	       
	       For Each Entry In Caching
	           Try : Entry.Value.dispose() : Catch : End Try
	       Next : Caching.Clear() : Caching = Nothing
	       If Not Me.disposedValue Then
	           If disposing Then Values = Nothing
	       End If : Me.disposedValue = True
	   End Sub
	   Public Sub Dispose() Implements IDisposable.Dispose
	       Dispose(True) : System.GC.SuppressFinalize(Me)
	   End Sub
	#End Region

	Sub New (PTR as IntPtr)
	   If PTR = IntPtr.Zero Then Exit Sub
	   Pointer = PTR: Marshal.PtrToStructure (Pointer, Values)
	End Sub
''' <remarks>
''' Loc: writefile.c (141, 14)
''' Org: [char [8] extension]
''' Msh: char [8] | 1:ConstantArray |
''' </remarks>
	readonly property extension as Char
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.extension
	     return Nothing
	 End Get
	End Property

''' <remarks>
''' Loc: writefile.c (142, 14)
''' Org: [l_int32 format]
''' Msh: l_int32 | 1:Int |
''' </remarks>
	readonly property format as Integer
	 Get
	     If Pointer = IntPTR.Zero then return Nothing
	     Marshal.PtrToStructure (Pointer, Values)
	     return Values.format
	     return Nothing
	 End Get
	End Property

	<StructLayout(LayoutKind.Sequential)>
	private class Marshal_ExtensionMap
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=8)> 		public extension as Char
		public format as Integer
	End Class
End Class


#End Region
