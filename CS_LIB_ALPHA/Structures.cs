using Enumerations;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System;

#region"environ.h"
//  ./environ.h (308, 8)
/// <summary>
/// Timing struct
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_WallTimer.txt" language="C" title="./environ.h (308, 8)"/>
/// </example>
public partial class L_WallTimer : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_WallTimer Values = new Marshal_L_WallTimer();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_WallTimer(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./environ.h (309, 14)
///  Org: [l_int32 start_sec]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int start_sec
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./environ.h (310, 14)
///  Org: [l_int32 start_usec]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int start_usec
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./environ.h (311, 14)
///  Org: [l_int32 stop_sec]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int stop_sec
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./environ.h (312, 14)
///  Org: [l_int32 stop_usec]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int stop_usec
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_WallTimer{
		public int start_sec;
		public int start_usec;
		public int stop_sec;
		public int stop_usec;}
	}

#endregion
#region"array.h"
//  ./array.h (59, 8)
/// <summary>
/// Number array: an array of floats
/// </summary>
/// <example>
/// <code source="CSource\Struct_Numa.txt" language="C" title="./array.h (59, 8)"/>
/// </example>
public partial class Numa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Numa Values = new Marshal_Numa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Numa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated number array
///  </summary>
///  <remarks>
///  Loc: ./array.h (61, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of numbers saved
///  </summary>
///  <remarks>
///  Loc: ./array.h (62, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./array.h (63, 22)
///  Org: [l_int32 refcount]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  x value assigned to array[0]
///  </summary>
///  <remarks>
///  Loc: ./array.h (64, 22)
///  Org: [l_float32 startx]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single startx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  change in x value as i --> i + 1
///  </summary>
///  <remarks>
///  Loc: ./array.h (65, 22)
///  Org: [l_float32 delx]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single delx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  number array
///  </summary>
///  <remarks>
///  Loc: ./array.h (66, 22)
///  Org: [l_float32 * array]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Numa{
		public int nalloc;
		public int n;
		public int refcount;
		public Single startx;
		public Single delx;
		public IntPtr array;}
	}

//  ./array.h (71, 8)
/// <summary>
/// Array of number arrays
/// </summary>
/// <example>
/// <code source="CSource\Struct_Numaa.txt" language="C" title="./array.h (71, 8)"/>
/// </example>
public partial class Numaa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Numaa Values = new Marshal_Numaa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Numaa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./array.h (73, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of Numa saved
///  </summary>
///  <remarks>
///  Loc: ./array.h (74, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of Numa
///  </summary>
///  <remarks>
///  Loc: ./array.h (75, 22)
///  Org: [struct Numa ** numa]
///  Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
///  </remarks>
	public List<Numa> numa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Numaa{
		public int nalloc;
		public int n;
		public IntPtr numa;}
	}

//  ./array.h (83, 8)
/// <summary>
/// Double number array: an array of doubles
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Dna.txt" language="C" title="./array.h (83, 8)"/>
/// </example>
public partial class L_Dna : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Dna Values = new Marshal_L_Dna();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Dna(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated number array
///  </summary>
///  <remarks>
///  Loc: ./array.h (85, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of numbers saved
///  </summary>
///  <remarks>
///  Loc: ./array.h (86, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./array.h (87, 22)
///  Org: [l_int32 refcount]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  x value assigned to array[0]
///  </summary>
///  <remarks>
///  Loc: ./array.h (88, 22)
///  Org: [l_float64 startx]
///  Msh: l_float64 | 1:Double |
///  </remarks>
	public double startx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  change in x value as i --> i + 1
///  </summary>
///  <remarks>
///  Loc: ./array.h (89, 22)
///  Org: [l_float64 delx]
///  Msh: l_float64 | 1:Double |
///  </remarks>
	public double delx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number array
///  </summary>
///  <remarks>
///  Loc: ./array.h (90, 22)
///  Org: [l_float64 * array]
///  Msh: l_float64 * | 2:Double |
///  </remarks>
	public Double[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Dna{
		public int nalloc;
		public int n;
		public int refcount;
		public double startx;
		public double delx;
		public IntPtr array;}
	}

//  ./array.h (95, 8)
/// <summary>
/// Array of double number arrays
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Dnaa.txt" language="C" title="./array.h (95, 8)"/>
/// </example>
public partial class L_Dnaa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Dnaa Values = new Marshal_L_Dnaa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Dnaa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./array.h (97, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of L_Dna saved
///  </summary>
///  <remarks>
///  Loc: ./array.h (98, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of L_Dna
///  </summary>
///  <remarks>
///  Loc: ./array.h (99, 22)
///  Org: [struct L_Dna ** dna]
///  Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
///  </remarks>
	public List<L_Dna> dna
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Dnaa{
		public int nalloc;
		public int n;
		public IntPtr dna;}
	}

//  ./array.h (104, 8)
/// <summary>
/// A hash table of Dnas
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_DnaHash.txt" language="C" title="./array.h (104, 8)"/>
/// </example>
public partial class L_DnaHash : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_DnaHash Values = new Marshal_L_DnaHash();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_DnaHash(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./array.h (106, 22)
///  Org: [l_int32 nbuckets]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nbuckets
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  initial size of each dna that is made
///  </summary>
///  <remarks>
///  Loc: ./array.h (107, 22)
///  Org: [l_int32 initsize]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int initsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of L_Dna
///  </summary>
///  <remarks>
///  Loc: ./array.h (108, 22)
///  Org: [struct L_Dna ** dna]
///  Msh: struct L_Dna ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Dna = L_Dna
///  </remarks>
	public List<L_Dna> dna
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_DnaHash{
		public int nbuckets;
		public int initsize;
		public IntPtr dna;}
	}

//  ./array.h (116, 8)
/// <summary>
/// String array: an array of C strings
/// </summary>
/// <example>
/// <code source="CSource\Struct_Sarray.txt" language="C" title="./array.h (116, 8)"/>
/// </example>
public partial class Sarray : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Sarray Values = new Marshal_Sarray();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Sarray(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./array.h (118, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of strings allocated
///  </summary>
///  <remarks>
///  Loc: ./array.h (119, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./array.h (120, 22)
///  Org: [l_int32 refcount]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  string array
///  </summary>
///  <remarks>
///  Loc: ./array.h (121, 22)
///  Org: [char ** array]
///  Msh: char ** | 3:CharS | String[]
///  </remarks>
	public String[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Sarray{
		public int nalloc;
		public int n;
		public int refcount;
		public IntPtr array;}
	}

//  ./array.h (126, 8)
/// <summary>
/// Byte array (analogous to C++ "string")
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Bytea.txt" language="C" title="./array.h (126, 8)"/>
/// </example>
public partial class L_Bytea : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Bytea Values = new Marshal_L_Bytea();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Bytea(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of bytes allocated in data array
///  </summary>
///  <remarks>
///  Loc: ./array.h (128, 22)
///  Org: [size_t nalloc]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of bytes presently used
///  </summary>
///  <remarks>
///  Loc: ./array.h (129, 22)
///  Org: [size_t size]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./array.h (130, 22)
///  Org: [l_int32 refcount]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  data array
///  </summary>
///  <remarks>
///  Loc: ./array.h (131, 22)
///  Org: [l_uint8 * data]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Bytea{
		public uint nalloc;
		public uint size;
		public int refcount;
		public IntPtr data;}
	}

#endregion
#region"bbuffer.h"
//  ./bbuffer.h (50, 8)
/// <summary>
/// Expandable byte buffer for memory read/write operations
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_ByteBuffer.txt" language="C" title="./bbuffer.h (50, 8)"/>
/// </example>
public partial class L_ByteBuffer : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_ByteBuffer Values = new Marshal_L_ByteBuffer();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_ByteBuffer(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated byte array
///  </summary>
///  <remarks>
///  Loc: ./bbuffer.h (52, 18)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of bytes read into to the array
///  </summary>
///  <remarks>
///  Loc: ./bbuffer.h (53, 18)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of bytes written from the array
///  </summary>
///  <remarks>
///  Loc: ./bbuffer.h (54, 18)
///  Org: [l_int32 nwritten]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nwritten
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  byte array
///  </summary>
///  <remarks>
///  Loc: ./bbuffer.h (55, 18)
///  Org: [l_uint8 * array]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_ByteBuffer{
		public int nalloc;
		public int n;
		public int nwritten;
		public IntPtr array;}
	}

#endregion
#region"heap.h"
//  ./heap.h (77, 8)
/// <summary>
/// Heap of arbitrary void* data
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Heap.txt" language="C" title="./heap.h (77, 8)"/>
/// </example>
public partial class L_Heap : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Heap Values = new Marshal_L_Heap();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Heap(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./heap.h (79, 18)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of elements stored in the heap
///  </summary>
///  <remarks>
///  Loc: ./heap.h (80, 18)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ptr array
///  </summary>
///  <remarks>
///  Loc: ./heap.h (81, 18)
///  Org: [void ** array]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  L_SORT_INCREASING or L_SORT_DECREASING
///  </summary>
///  <remarks>
///  Loc: ./heap.h (82, 18)
///  Org: [l_int32 direction]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int direction
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Heap{
		public int nalloc;
		public int n;
		public IntPtr array;
		public int direction;}
	}

#endregion
#region"list.h"
//  ./list.h (61, 8)
/// <summary>
/// list.h
/// </summary>
/// <example>
/// <code source="CSource\Struct_DoubleLinkedList.txt" language="C" title="./list.h (61, 8)"/>
/// </example>
public partial class DoubleLinkedList : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_DoubleLinkedList Values = new Marshal_DoubleLinkedList();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public DoubleLinkedList(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./list.h (63, 33)
///  Org: [struct DoubleLinkedList * prev]
///  Msh: struct DoubleLinkedList * | 2:Struct |
///  </remarks>
	public DoubleLinkedList prev
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./list.h (64, 33)
///  Org: [struct DoubleLinkedList * next]
///  Msh: struct DoubleLinkedList * | 2:Struct |
///  </remarks>
	public DoubleLinkedList _next_
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./list.h (65, 33)
///  Org: [void * data]
///  Msh: void * | 2:Void | Object -  - IntPtr
///  </remarks>
	public IntPtr data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_DoubleLinkedList{
		public IntPtr prev;
		public IntPtr _next_;
		public IntPtr data;}
	}

#endregion
#region"ptra.h"
//  ./ptra.h (51, 8)
/// <summary>
/// Generic pointer array
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Ptra.txt" language="C" title="./ptra.h (51, 8)"/>
/// </example>
public partial class L_Ptra : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Ptra Values = new Marshal_L_Ptra();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Ptra(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (53, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  greatest valid index
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (54, 22)
///  Org: [l_int32 imax]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int imax
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  actual number of stored elements
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (55, 22)
///  Org: [l_int32 nactual]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nactual
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ptr array
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (56, 22)
///  Org: [void ** array]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Ptra{
		public int nalloc;
		public int imax;
		public int nactual;
		public IntPtr array;}
	}

//  ./ptra.h (62, 8)
/// <summary>
/// Array of generic pointer arrays
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Ptraa.txt" language="C" title="./ptra.h (62, 8)"/>
/// </example>
public partial class L_Ptraa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Ptraa Values = new Marshal_L_Ptraa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Ptraa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (64, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of ptra
///  </summary>
///  <remarks>
///  Loc: ./ptra.h (65, 22)
///  Org: [struct L_Ptra ** ptra]
///  Msh: struct L_Ptra ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: L_Ptra = L_Ptra
///  </remarks>
	public List<L_Ptra> ptra
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Ptraa{
		public int nalloc;
		public IntPtr ptra;}
	}

#endregion
#region"queue.h"
//  ./queue.h (64, 8)
/// <summary>
/// Expandable pointer queue for arbitrary void* data
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Queue.txt" language="C" title="./queue.h (64, 8)"/>
/// </example>
public partial class L_Queue : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Queue Values = new Marshal_L_Queue();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Queue(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./queue.h (66, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  location of head (in ptrs) from the
///  </summary>
///  <remarks>
///  Loc: ./queue.h (67, 22)
///  Org: [l_int32 nhead]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nhead
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of elements stored in the queue
///  </summary>
///  <remarks>
///  Loc: ./queue.h (69, 22)
///  Org: [l_int32 nelem]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nelem
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ptr array
///  </summary>
///  <remarks>
///  Loc: ./queue.h (70, 22)
///  Org: [void ** array]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  auxiliary stack
///  </summary>
///  <remarks>
///  Loc: ./queue.h (71, 22)
///  Org: [struct L_Stack * stack]
///  Msh: struct L_Stack * | 2:Struct |
///  </remarks>
	public L_Stack stack
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Queue{
		public int nalloc;
		public int nhead;
		public int nelem;
		public IntPtr array;
		public IntPtr stack;}
	}

#endregion
#region"rbtree.h"
//  ./rbtree.h (61, 7)
/// <summary>
/// Storage for keys and values for red-black trees, maps and sets. Note: (1) Keys and values of the valid key types are all 64-bit (2) (void *) can be used for values but not for keys.
/// </summary>
/// <example>
/// <code source="CSource\Struct_Rb_Type.txt" language="C" title="./rbtree.h (61, 7)"/>
/// </example>
public partial class Rb_Type : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Rb_Type Values = new Marshal_Rb_Type();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Rb_Type(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./rbtree.h (62, 16)
///  Org: [l_int64 itype]
///  Msh: l_int64 | 1:LongLong |
///  </remarks>
	public long itype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (63, 16)
///  Org: [l_uint64 utype]
///  Msh: l_uint64 | 1:ULongLong |
///  </remarks>
	public ulong utype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (64, 16)
///  Org: [l_float64 ftype]
///  Msh: l_float64 | 1:Double |
///  </remarks>
	public double ftype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (65, 16)
///  Org: [void * ptype]
///  Msh: void * | 2:Void | Object -  - IntPtr
///  </remarks>
	public IntPtr ptype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Rb_Type{
		public long itype;
		public ulong utype;
		public double ftype;
		public IntPtr ptype;}
	}

//  ./rbtree.h (69, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Rbtree.txt" language="C" title="./rbtree.h (69, 8)"/>
/// </example>
public partial class L_Rbtree : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Rbtree Values = new Marshal_L_Rbtree();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Rbtree(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./rbtree.h (70, 28)
///  Org: [struct L_Rbtree_Node * root]
///  Msh: struct L_Rbtree_Node * | 2:Struct |
///  </remarks>
	public L_Rbtree_Node root
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (71, 28)
///  Org: [l_int32 keytype]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int keytype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Rbtree{
		public IntPtr root;
		public int keytype;}
	}

//  ./rbtree.h (77, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Rbtree_Node.txt" language="C" title="./rbtree.h (77, 8)"/>
/// </example>
public partial class L_Rbtree_Node : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Rbtree_Node Values = new Marshal_L_Rbtree_Node();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Rbtree_Node(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: ./rbtree.h (78, 28)
///  Org: [union Rb_Type key]
///  Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
///  </remarks>
	public Rb_Type key
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (79, 28)
///  Org: [union Rb_Type value]
///  Msh: Rb_Type | 1:UnionDeclaration |  | Typedef: Rb_Type = Rb_Type
///  </remarks>
	public Rb_Type value
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (80, 28)
///  Org: [struct L_Rbtree_Node * left]
///  Msh: struct L_Rbtree_Node * | 2:Struct |
///  </remarks>
	public L_Rbtree_Node left
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (81, 28)
///  Org: [struct L_Rbtree_Node * right]
///  Msh: struct L_Rbtree_Node * | 2:Struct |
///  </remarks>
	public L_Rbtree_Node right
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (82, 28)
///  Org: [struct L_Rbtree_Node * parent]
///  Msh: struct L_Rbtree_Node * | 2:Struct |
///  </remarks>
	public L_Rbtree_Node parent
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: ./rbtree.h (83, 28)
///  Org: [l_int32 color]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int color
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Rbtree_Node{
		public Rb_Type key;
		public Rb_Type value;
		public IntPtr left;
		public IntPtr right;
		public IntPtr parent;
		public int color;}
	}

#endregion
#region"stack.h"
//  ./stack.h (59, 8)
/// <summary>
/// Expandable pointer stack for arbitrary void* data. Note that array[n] is the first null ptr in the array
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Stack.txt" language="C" title="./stack.h (59, 8)"/>
/// </example>
public partial class L_Stack : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Stack Values = new Marshal_L_Stack();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Stack(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of ptr array
///  </summary>
///  <remarks>
///  Loc: ./stack.h (61, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of stored elements
///  </summary>
///  <remarks>
///  Loc: ./stack.h (62, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ptr array
///  </summary>
///  <remarks>
///  Loc: ./stack.h (63, 22)
///  Org: [void ** array]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  auxiliary stack
///  </summary>
///  <remarks>
///  Loc: ./stack.h (64, 22)
///  Org: [struct L_Stack * auxstack]
///  Msh: struct L_Stack * | 2:Struct |
///  </remarks>
	public L_Stack auxstack
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Stack{
		public int nalloc;
		public int n;
		public IntPtr array;
		public IntPtr auxstack;}
	}

#endregion
#region"bmf.h"
//  ./bmf.h (45, 8)
/// <summary>
/// Data structure to hold bitmap fonts and related data
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Bmf.txt" language="C" title="./bmf.h (45, 8)"/>
/// </example>
public partial class L_Bmf : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Bmf Values = new Marshal_L_Bmf();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Bmf(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  pixa of bitmaps for 93 characters
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (47, 19)
///  Org: [struct Pixa * pixa]
///  Msh: struct Pixa * | 2:Struct |
///  </remarks>
	public Pixa pixa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  font size (in points at 300 ppi)
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (48, 19)
///  Org: [l_int32 size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  directory containing font bitmaps
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (49, 19)
///  Org: [char * directory]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String directory
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  baseline offset for ascii 33 - 57
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (50, 19)
///  Org: [l_int32 baseline1]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int baseline1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  baseline offset for ascii 58 - 91
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (51, 19)
///  Org: [l_int32 baseline2]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int baseline2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  baseline offset for ascii 93 - 126
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (52, 19)
///  Org: [l_int32 baseline3]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int baseline3
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max height of line of chars
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (53, 19)
///  Org: [l_int32 lineheight]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int lineheight
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pixel dist between char bitmaps
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (54, 19)
///  Org: [l_int32 kernwidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int kernwidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pixel dist between word bitmaps
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (55, 19)
///  Org: [l_int32 spacewidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int spacewidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  extra vertical space between text lines
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (56, 19)
///  Org: [l_int32 vertlinesep]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int vertlinesep
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  table mapping ascii --> font index
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (57, 19)
///  Org: [l_int32 * fonttab]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] fonttab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  table mapping ascii --> baseline offset
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (58, 19)
///  Org: [l_int32 * baselinetab]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] baselinetab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  table mapping ascii --> char width
///  </summary>
///  <remarks>
///  Loc: ./bmf.h (59, 19)
///  Org: [l_int32 * widthtab]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] widthtab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Bmf{
		public IntPtr pixa;
		public int size;
		public IntPtr directory;
		public int baseline1;
		public int baseline2;
		public int baseline3;
		public int lineheight;
		public int kernwidth;
		public int spacewidth;
		public int vertlinesep;
		public IntPtr fonttab;
		public IntPtr baselinetab;
		public IntPtr widthtab;}
	}

#endregion
#region"ccbord.h"
//  ./ccbord.h (91, 8)
/// <summary>
/// CCBord contains:
/// </summary>
/// <example>
/// <code source="CSource\Struct_CCBord.txt" language="C" title="./ccbord.h (91, 8)"/>
/// </example>
public partial class CCBord : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_CCBord Values = new Marshal_CCBord();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public CCBord(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  component bitmap (min size)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (93, 26)
///  Org: [struct Pix * pix]
///  Msh: struct Pix * | 2:Struct |
///  </remarks>
	public Pix pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  regions of each closed curve
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (94, 26)
///  Org: [struct Boxa * boxa]
///  Msh: struct Boxa * | 2:Struct |
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  initial border pixel locations
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (95, 26)
///  Org: [struct Pta * start]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta start
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of handles start at 1
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (96, 26)
///  Org: [l_int32 refcount]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ptaa of chain pixels (local)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (97, 26)
///  Org: [struct Ptaa * local]
///  Msh: struct Ptaa * | 2:Struct |
///  </remarks>
	public Ptaa local
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  ptaa of chain pixels (global)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (98, 26)
///  Org: [struct Ptaa * global]
///  Msh: struct Ptaa * | 2:Struct |
///  </remarks>
	public Ptaa _global_
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  numaa of chain code (step dir)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (99, 26)
///  Org: [struct Numaa * step]
///  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
///  </remarks>
	public Numaa _step_
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pta of single chain (local)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (100, 26)
///  Org: [struct Pta * splocal]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta splocal
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pta of single chain (global)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (101, 26)
///  Org: [struct Pta * spglobal]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta spglobal
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_CCBord{
		public IntPtr pix;
		public IntPtr boxa;
		public IntPtr start;
		public int refcount;
		public IntPtr local;
		public IntPtr _global_;
		public IntPtr _step_;
		public IntPtr splocal;
		public IntPtr spglobal;}
	}

//  ./ccbord.h (106, 8)
/// <summary>
/// Array of CCBord
/// </summary>
/// <example>
/// <code source="CSource\Struct_CCBorda.txt" language="C" title="./ccbord.h (106, 8)"/>
/// </example>
public partial class CCBorda : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_CCBorda Values = new Marshal_CCBorda();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public CCBorda(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  input pix (may be null)
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (108, 26)
///  Org: [struct Pix * pix]
///  Msh: struct Pix * | 2:Struct |
///  </remarks>
	public Pix pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  width of pix
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (109, 26)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height of pix
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (110, 26)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of ccbord in ptr array
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (111, 26)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of ccbord ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (112, 26)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ccb ptr array
///  </summary>
///  <remarks>
///  Loc: ./ccbord.h (113, 26)
///  Org: [struct CCBord ** ccb]
///  Msh: struct CCBord ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: CCBord = CCBord
///  </remarks>
	public List<CCBord> ccb
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_CCBorda{
		public IntPtr pix;
		public int w;
		public int h;
		public int n;
		public int nalloc;
		public IntPtr ccb;}
	}

#endregion
#region"dewarp.h"
//  ./dewarp.h (113, 8)
/// <summary>
/// Data structure to hold a number of Dewarp
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Dewarpa.txt" language="C" title="./dewarp.h (113, 8)"/>
/// </example>
public partial class L_Dewarpa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Dewarpa Values = new Marshal_L_Dewarpa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Dewarpa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of dewarp ptr array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (115, 24)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum page number in array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (116, 24)
///  Org: [l_int32 maxpage]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxpage
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of ptrs to page dewarp
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (117, 24)
///  Org: [struct L_Dewarp ** dewarp]
///  Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
///  </remarks>
	public List<L_Dewarp> dewarp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of ptrs to cached dewarps
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (118, 24)
///  Org: [struct L_Dewarp ** dewarpcache]
///  Msh: struct L_Dewarp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
///  </remarks>
	public List<L_Dewarp> dewarpcache
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  list of page numbers for pages
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (119, 24)
///  Org: [struct Numa * namodels]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa namodels
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  list of page numbers with either
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (121, 24)
///  Org: [struct Numa * napages]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa napages
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  reduction factor of input: 1 or 2
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (123, 24)
///  Org: [l_int32 redfactor]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int redfactor
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  disparity arrays sampling factor
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (124, 24)
///  Org: [l_int32 sampling]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sampling
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min number of long lines required
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (125, 24)
///  Org: [l_int32 minlines]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minlines
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max distance for getting ref page
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (126, 24)
///  Org: [l_int32 maxdist]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxdist
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum abs line curvature,
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (127, 24)
///  Org: [l_int32 max_linecurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_linecurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  minimum abs diff line
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (129, 24)
///  Org: [l_int32 min_diff_linecurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int min_diff_linecurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum abs diff line
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (131, 24)
///  Org: [l_int32 max_diff_linecurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_diff_linecurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum abs left or right edge
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (133, 24)
///  Org: [l_int32 max_edgeslope]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_edgeslope
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum abs left or right edge
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (135, 24)
///  Org: [l_int32 max_edgecurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_edgecurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  maximum abs diff left-right
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (137, 24)
///  Org: [l_int32 max_diff_edgecurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_diff_edgecurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  use both disparity arrays if
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (139, 24)
///  Org: [l_int32 useboth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int useboth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  if there are multiple columns,
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (141, 24)
///  Org: [l_int32 check_columns]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int check_columns
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  invalid models have been removed
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (144, 24)
///  Org: [l_int32 modelsready]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int modelsready
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Dewarpa{
		public int nalloc;
		public int maxpage;
		public IntPtr dewarp;
		public IntPtr dewarpcache;
		public IntPtr namodels;
		public IntPtr napages;
		public int redfactor;
		public int sampling;
		public int minlines;
		public int maxdist;
		public int max_linecurv;
		public int min_diff_linecurv;
		public int max_diff_linecurv;
		public int max_edgeslope;
		public int max_edgecurv;
		public int max_diff_edgecurv;
		public int useboth;
		public int check_columns;
		public int modelsready;}
	}

//  ./dewarp.h (151, 8)
/// <summary>
/// Data structure for a single dewarp
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Dewarp.txt" language="C" title="./dewarp.h (151, 8)"/>
/// </example>
public partial class L_Dewarp : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Dewarp Values = new Marshal_L_Dewarp();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Dewarp(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  ptr to parent (not owned)
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (153, 24)
///  Org: [struct L_Dewarpa * dewa]
///  Msh: struct L_Dewarpa * | 2:Struct |  | Typedef: L_Dewarpa = L_Dewarpa
///  </remarks>
	public L_Dewarpa dewa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  source pix, 1 bpp
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (154, 24)
///  Org: [struct Pix * pixs]
///  Msh: struct Pix * | 2:Struct |
///  </remarks>
	public Pix pixs
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sampled vert disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (155, 24)
///  Org: [struct FPix * sampvdispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix sampvdispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sampled horiz disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (156, 24)
///  Org: [struct FPix * samphdispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix samphdispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sampled slope h-disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (157, 24)
///  Org: [struct FPix * sampydispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix sampydispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  full vert disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (158, 24)
///  Org: [struct FPix * fullvdispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix fullvdispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  full horiz disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (159, 24)
///  Org: [struct FPix * fullhdispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix fullhdispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  full slope h-disparity array
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (160, 24)
///  Org: [struct FPix * fullydispar]
///  Msh: struct FPix * | 2:Struct |
///  </remarks>
	public FPix fullydispar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sorted y val of midpoint each line
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (161, 24)
///  Org: [struct Numa * namidys]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa namidys
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sorted curvature of each line
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (162, 24)
///  Org: [struct Numa * nacurves]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nacurves
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  width of source image
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (163, 24)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height of source image
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (164, 24)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  page number important for reuse
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (165, 24)
///  Org: [l_int32 pageno]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int pageno
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sampling factor of disparity arrays
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (166, 24)
///  Org: [l_int32 sampling]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sampling
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reduction factor of pixs: 1 or 2
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (167, 24)
///  Org: [l_int32 redfactor]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int redfactor
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min number of long lines required
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (168, 24)
///  Org: [l_int32 minlines]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minlines
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of long lines found
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (169, 24)
///  Org: [l_int32 nlines]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nlines
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min line curvature in micro-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (170, 24)
///  Org: [l_int32 mincurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int mincurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max line curvature in micro-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (171, 24)
///  Org: [l_int32 maxcurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxcurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  left edge slope in milli-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (172, 24)
///  Org: [l_int32 leftslope]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int leftslope
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  right edge slope in milli-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (173, 24)
///  Org: [l_int32 rightslope]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rightslope
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  left edge curvature in micro-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (174, 24)
///  Org: [l_int32 leftcurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int leftcurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  right edge curvature in micro-units
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (175, 24)
///  Org: [l_int32 rightcurv]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rightcurv
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of sampling pts in x-dir
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (176, 24)
///  Org: [l_int32 nx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of sampling pts in y-dir
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (177, 24)
///  Org: [l_int32 ny]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ny
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  0 if normal 1 if has a refpage
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (178, 24)
///  Org: [l_int32 hasref]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int hasref
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  page with disparity model to use
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (179, 24)
///  Org: [l_int32 refpage]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int refpage
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sets to 1 if vert disparity builds
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (180, 24)
///  Org: [l_int32 vsuccess]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int vsuccess
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sets to 1 if horiz disparity builds
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (181, 24)
///  Org: [l_int32 hsuccess]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int hsuccess
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sets to 1 if slope disparity builds
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (182, 24)
///  Org: [l_int32 ysuccess]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ysuccess
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sets to 1 if valid vert disparity
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (183, 24)
///  Org: [l_int32 vvalid]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int vvalid
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sets to 1 if valid horiz disparity
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (184, 24)
///  Org: [l_int32 hvalid]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int hvalid
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  if 1, skip horiz disparity
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (185, 24)
///  Org: [l_int32 skip_horiz]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int skip_horiz
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 if debug output requested
///  </summary>
///  <remarks>
///  Loc: ./dewarp.h (187, 24)
///  Org: [l_int32 debug]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int debug
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Dewarp{
		public IntPtr dewa;
		public IntPtr pixs;
		public IntPtr sampvdispar;
		public IntPtr samphdispar;
		public IntPtr sampydispar;
		public IntPtr fullvdispar;
		public IntPtr fullhdispar;
		public IntPtr fullydispar;
		public IntPtr namidys;
		public IntPtr nacurves;
		public int w;
		public int h;
		public int pageno;
		public int sampling;
		public int redfactor;
		public int minlines;
		public int nlines;
		public int mincurv;
		public int maxcurv;
		public int leftslope;
		public int rightslope;
		public int leftcurv;
		public int rightcurv;
		public int nx;
		public int ny;
		public int hasref;
		public int refpage;
		public int vsuccess;
		public int hsuccess;
		public int ysuccess;
		public int vvalid;
		public int hvalid;
		public int skip_horiz;
		public int debug;}
	}

#endregion
#region"gplot.h"
//  ./gplot.h (75, 8)
/// <summary>
/// Data structure for generating gnuplot files
/// </summary>
/// <example>
/// <code source="CSource\Struct_GPlot.txt" language="C" title="./gplot.h (75, 8)"/>
/// </example>
public partial class GPlot : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_GPlot Values = new Marshal_GPlot();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public GPlot(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  for cmd, data, output
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (77, 20)
///  Org: [char * rootname]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String rootname
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  command file name
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (78, 20)
///  Org: [char * cmdname]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String cmdname
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  command file contents
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (79, 20)
///  Org: [struct Sarray * cmddata]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray cmddata
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  data file names
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (80, 20)
///  Org: [struct Sarray * datanames]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray datanames
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  plot data (1 string/file)
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (81, 20)
///  Org: [struct Sarray * plotdata]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray plotdata
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  title for each individual plot
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (82, 20)
///  Org: [struct Sarray * plottitles]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray plottitles
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  plot style for individual plots
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (83, 20)
///  Org: [struct Numa * plotstyles]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa plotstyles
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  current number of plots
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (84, 20)
///  Org: [l_int32 nplots]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nplots
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  output file name
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (85, 20)
///  Org: [char * outname]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String outname
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  GPLOT_OUTPUT values
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (86, 20)
///  Org: [l_int32 outformat]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int outformat
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  GPLOT_SCALING values
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (87, 20)
///  Org: [l_int32 scaling]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int scaling
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  optional
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (88, 20)
///  Org: [char * title]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String title
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  optional x axis label
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (89, 20)
///  Org: [char * xlabel]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String xlabel
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  optional y axis label
///  </summary>
///  <remarks>
///  Loc: ./gplot.h (90, 20)
///  Org: [char * ylabel]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String ylabel
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_GPlot{
		public IntPtr rootname;
		public IntPtr cmdname;
		public IntPtr cmddata;
		public IntPtr datanames;
		public IntPtr plotdata;
		public IntPtr plottitles;
		public IntPtr plotstyles;
		public int nplots;
		public IntPtr outname;
		public int outformat;
		public int scaling;
		public IntPtr title;
		public IntPtr xlabel;
		public IntPtr ylabel;}
	}

#endregion
#region"imageio.h"
//  ./imageio.h (166, 8)
/// <summary>
/// Compressed image data
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Compressed_Data.txt" language="C" title="./imageio.h (166, 8)"/>
/// </example>
public partial class L_Compressed_Data : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Compressed_Data Values = new Marshal_L_Compressed_Data();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Compressed_Data(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  encoding type: L_JPEG_ENCODE, etc
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (168, 24)
///  Org: [l_int32 type]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int type
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  gzipped raster data
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (169, 24)
///  Org: [l_uint8 * datacomp]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] datacomp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of compressed bytes
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (170, 24)
///  Org: [size_t nbytescomp]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint nbytescomp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ascii85-encoded gzipped raster data
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (171, 24)
///  Org: [char * data85]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String data85
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of ascii85 encoded bytes
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (172, 24)
///  Org: [size_t nbytes85]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint nbytes85
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  ascii85-encoded uncompressed cmap
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (173, 24)
///  Org: [char * cmapdata85]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String cmapdata85
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  hex pdf array for the cmap
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (174, 24)
///  Org: [char * cmapdatahex]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String cmapdatahex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of colors in cmap
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (175, 24)
///  Org: [l_int32 ncolors]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ncolors
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image width
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (176, 24)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image height
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (177, 24)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  bits/sample typ. 1, 2, 4 or 8
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (178, 24)
///  Org: [l_int32 bps]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bps
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  samples/pixel typ. 1 or 3
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (179, 24)
///  Org: [l_int32 spp]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int spp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  tiff g4 photometry
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (180, 24)
///  Org: [l_int32 minisblack]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minisblack
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  flate data has PNG predictors
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (181, 24)
///  Org: [l_int32 predictor]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int predictor
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of uncompressed raster bytes
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (182, 24)
///  Org: [size_t nbytes]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint nbytes
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  resolution (ppi)
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (183, 24)
///  Org: [l_int32 res]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int res
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Compressed_Data{
		public int type;
		public IntPtr datacomp;
		public uint nbytescomp;
		public IntPtr data85;
		public uint nbytes85;
		public IntPtr cmapdata85;
		public IntPtr cmapdatahex;
		public int ncolors;
		public int w;
		public int h;
		public int bps;
		public int spp;
		public int minisblack;
		public int predictor;
		public uint nbytes;
		public int res;}
	}

//  ./imageio.h (211, 8)
/// <summary>
/// Intermediate pdf generation data
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Pdf_Data.txt" language="C" title="./imageio.h (211, 8)"/>
/// </example>
public partial class L_Pdf_Data : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Pdf_Data Values = new Marshal_L_Pdf_Data();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Pdf_Data(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  optional title for pdf
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (213, 24)
///  Org: [char * title]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String title
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of images
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (214, 24)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of colormaps
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (215, 24)
///  Org: [l_int32 ncmap]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ncmap
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of compressed image data
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (216, 24)
///  Org: [struct L_Ptra * cida]
///  Msh: struct L_Ptra * | 2:Struct |  | Typedef: L_Ptra = L_Ptra
///  </remarks>
	public L_Ptra cida
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  %PDF-1.2 id string
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (217, 24)
///  Org: [char * id]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String id
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  catalog string
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (218, 24)
///  Org: [char * obj1]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String obj1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  metadata string
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (219, 24)
///  Org: [char * obj2]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String obj2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pages string
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (220, 24)
///  Org: [char * obj3]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String obj3
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  page string (variable data)
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (221, 24)
///  Org: [char * obj4]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String obj4
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  content string (variable data)
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (222, 24)
///  Org: [char * obj5]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String obj5
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  post-binary-stream string
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (223, 24)
///  Org: [char * poststream]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String poststream
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  trailer string (variable data)
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (224, 24)
///  Org: [char * trailer]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String trailer
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  store (xpt, ypt) array
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (225, 24)
///  Org: [struct Pta * xy]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta xy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  store (wpt, hpt) array
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (226, 24)
///  Org: [struct Pta * wh]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta wh
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  bounding region for all images
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (227, 24)
///  Org: [struct Box * mediabox]
///  Msh: struct Box * | 2:Struct |
///  </remarks>
	public Box mediabox
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pre-binary-stream xobject strings
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (228, 24)
///  Org: [struct Sarray * saprex]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray saprex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  colormap pdf object strings
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (229, 24)
///  Org: [struct Sarray * sacmap]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray sacmap
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  sizes of each pdf string object
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (230, 24)
///  Org: [struct L_Dna * objsize]
///  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
///  </remarks>
	public L_Dna objsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  location of each pdf string object
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (231, 24)
///  Org: [struct L_Dna * objloc]
///  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
///  </remarks>
	public L_Dna objloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  location of xref
///  </summary>
///  <remarks>
///  Loc: ./imageio.h (232, 24)
///  Org: [l_int32 xrefloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xrefloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Pdf_Data{
		public IntPtr title;
		public int n;
		public int ncmap;
		public IntPtr cida;
		public IntPtr id;
		public IntPtr obj1;
		public IntPtr obj2;
		public IntPtr obj3;
		public IntPtr obj4;
		public IntPtr obj5;
		public IntPtr poststream;
		public IntPtr trailer;
		public IntPtr xy;
		public IntPtr wh;
		public IntPtr mediabox;
		public IntPtr saprex;
		public IntPtr sacmap;
		public IntPtr objsize;
		public IntPtr objloc;
		public int xrefloc;}
	}

#endregion
#region"jbclass.h"
//  ./jbclass.h (47, 8)
/// <summary>
/// The JbClasser struct holds all the data accumulated during the classification process that can be used for a compressed jbig2-type representation of a set of images. This is created in an initialization process and added to as the selected components on each successive page are analyzed.
/// </summary>
/// <example>
/// <code source="CSource\Struct_JbClasser.txt" language="C" title="./jbclass.h (47, 8)"/>
/// </example>
public partial class JbClasser : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_JbClasser Values = new Marshal_JbClasser();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public JbClasser(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  input page image file names
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (49, 22)
///  Org: [struct Sarray * safiles]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray safiles
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  JB_RANKHAUS, JB_CORRELATION
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (50, 22)
///  Org: [l_int32 method]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int method
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  JB_CONN_COMPS, JB_CHARACTERS or
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (51, 22)
///  Org: [l_int32 components]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int components
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max component width allowed
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (53, 22)
///  Org: [l_int32 maxwidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxwidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max component height allowed
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (54, 22)
///  Org: [l_int32 maxheight]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxheight
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of pages already processed
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (55, 22)
///  Org: [l_int32 npages]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int npages
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number components already processed
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (56, 22)
///  Org: [l_int32 baseindex]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int baseindex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of components on each page
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (58, 22)
///  Org: [struct Numa * nacomps]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nacomps
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  size of square struct elem for haus
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (59, 22)
///  Org: [l_int32 sizehaus]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sizehaus
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  rank val of haus match, each way
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (60, 22)
///  Org: [l_float32 rankhaus]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single rankhaus
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  thresh value for correlation score
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (61, 22)
///  Org: [l_float32 thresh]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single thresh
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  corrects thresh value for heaver
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (62, 22)
///  Org: [l_float32 weightfactor]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single weightfactor
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  w * h of each template, without
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (64, 22)
///  Org: [struct Numa * naarea]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naarea
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  max width of original src images
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (66, 22)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max height of original src images
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (67, 22)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  current number of classes
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (68, 22)
///  Org: [l_int32 nclass]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nclass
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  If zero, pixaa isn't filled
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (69, 22)
///  Org: [l_int32 keep_pixaa]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int keep_pixaa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  instances for each class unbordered
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (70, 22)
///  Org: [struct Pixaa * pixaa]
///  Msh: struct Pixaa * | 2:Struct |
///  </remarks>
	public Pixaa pixaa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  templates for each class bordered
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (71, 22)
///  Org: [struct Pixa * pixat]
///  Msh: struct Pixa * | 2:Struct |
///  </remarks>
	public Pixa pixat
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  templates for each class bordered
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (73, 22)
///  Org: [struct Pixa * pixatd]
///  Msh: struct Pixa * | 2:Struct |
///  </remarks>
	public Pixa pixatd
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  Hash table to find templates by size
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (75, 23)
///  Org: [struct L_DnaHash * dahash]
///  Msh: struct L_DnaHash * | 2:Struct |  | Typedef: L_DnaHash = L_DnaHash
///  </remarks>
	public L_DnaHash dahash
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  fg areas of undilated templates
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (76, 22)
///  Org: [struct Numa * nafgt]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nafgt
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of all bordered cc
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (78, 22)
///  Org: [struct Pta * ptac]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta ptac
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of all bordered template cc
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (79, 22)
///  Org: [struct Pta * ptact]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta ptact
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of class ids for each component
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (80, 22)
///  Org: [struct Numa * naclass]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naclass
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of page nums for each component
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (81, 22)
///  Org: [struct Numa * napage]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa napage
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of UL corners at which the
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (82, 22)
///  Org: [struct Pta * ptaul]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta ptaul
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  similar to ptaul, but for LL corners
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (85, 22)
///  Org: [struct Pta * ptall]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta ptall
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_JbClasser{
		public IntPtr safiles;
		public int method;
		public int components;
		public int maxwidth;
		public int maxheight;
		public int npages;
		public int baseindex;
		public IntPtr nacomps;
		public int sizehaus;
		public Single rankhaus;
		public Single thresh;
		public Single weightfactor;
		public IntPtr naarea;
		public int w;
		public int h;
		public int nclass;
		public int keep_pixaa;
		public IntPtr pixaa;
		public IntPtr pixat;
		public IntPtr pixatd;
		public IntPtr dahash;
		public IntPtr nafgt;
		public IntPtr ptac;
		public IntPtr ptact;
		public IntPtr naclass;
		public IntPtr napage;
		public IntPtr ptaul;
		public IntPtr ptall;}
	}

//  ./jbclass.h (104, 8)
/// <summary>
/// The JbData struct holds all the data required for the compressed jbig-type representation of a set of images. The data can be written to file, read back, and used to regenerate an approximate version of the original, which differs in two ways from the original: (1) It uses a template image for each c.c. instead of the original instance, for each occurrence on each page. (2) It discards components with either a height or width larger than the maximuma, given here by the lattice dimensions used for storing the templates.
/// </summary>
/// <example>
/// <code source="CSource\Struct_JbData.txt" language="C" title="./jbclass.h (104, 8)"/>
/// </example>
public partial class JbData : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_JbData Values = new Marshal_JbData();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public JbData(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  template composite for all classes
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (106, 22)
///  Org: [struct Pix * pix]
///  Msh: struct Pix * | 2:Struct |
///  </remarks>
	public Pix pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of pages
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (107, 22)
///  Org: [l_int32 npages]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int npages
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max width of original page images
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (108, 22)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max height of original page images
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (109, 22)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of classes
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (110, 22)
///  Org: [l_int32 nclass]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nclass
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  lattice width for template composite
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (111, 22)
///  Org: [l_int32 latticew]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int latticew
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  lattice height for template composite
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (112, 22)
///  Org: [l_int32 latticeh]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int latticeh
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of class ids for each component
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (113, 22)
///  Org: [struct Numa * naclass]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naclass
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of page nums for each component
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (114, 22)
///  Org: [struct Numa * napage]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa napage
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of UL corners at which the
///  </summary>
///  <remarks>
///  Loc: ./jbclass.h (115, 22)
///  Org: [struct Pta * ptaul]
///  Msh: struct Pta * | 2:Struct |
///  </remarks>
	public Pta ptaul
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_JbData{
		public IntPtr pix;
		public int npages;
		public int w;
		public int h;
		public int nclass;
		public int latticew;
		public int latticeh;
		public IntPtr naclass;
		public IntPtr napage;
		public IntPtr ptaul;}
	}

#endregion
#region"morph.h"
//  ./morph.h (62, 8)
/// <summary>
/// Selection
/// </summary>
/// <example>
/// <code source="CSource\Struct_Sel.txt" language="C" title="./morph.h (62, 8)"/>
/// </example>
public partial class Sel : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Sel Values = new Marshal_Sel();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Sel(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  sel height
///  </summary>
///  <remarks>
///  Loc: ./morph.h (64, 19)
///  Org: [l_int32 sy]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sel width
///  </summary>
///  <remarks>
///  Loc: ./morph.h (65, 19)
///  Org: [l_int32 sx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  y location of sel origin
///  </summary>
///  <remarks>
///  Loc: ./morph.h (66, 19)
///  Org: [l_int32 cy]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int cy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  x location of sel origin
///  </summary>
///  <remarks>
///  Loc: ./morph.h (67, 19)
///  Org: [l_int32 cx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int cx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  {0,1,2} data[i][j] in [row][col] order
///  </summary>
///  <remarks>
///  Loc: ./morph.h (68, 19)
///  Org: [l_int32 ** data]
///  Msh: l_int32 ** | 3:Integer | List<int[]>
///  </remarks>
	public List<int[]> data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  used to find sel by name
///  </summary>
///  <remarks>
///  Loc: ./morph.h (69, 19)
///  Org: [char * name]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String name
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Sel{
		public int sy;
		public int sx;
		public int cy;
		public int cx;
		public IntPtr data;
		public IntPtr name;}
	}

//  ./morph.h (74, 8)
/// <summary>
/// Array of Sel
/// </summary>
/// <example>
/// <code source="CSource\Struct_Sela.txt" language="C" title="./morph.h (74, 8)"/>
/// </example>
public partial class Sela : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Sela Values = new Marshal_Sela();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Sela(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of sel actually stored
///  </summary>
///  <remarks>
///  Loc: ./morph.h (76, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  size of allocated ptr array
///  </summary>
///  <remarks>
///  Loc: ./morph.h (77, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  sel ptr array
///  </summary>
///  <remarks>
///  Loc: ./morph.h (78, 22)
///  Org: [struct Sel ** sel]
///  Msh: struct Sel ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Sel = Sel
///  </remarks>
	public List<Sel> sel
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Sela{
		public int n;
		public int nalloc;
		public IntPtr sel;}
	}

//  ./morph.h (89, 8)
/// <summary>
/// Kernel
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Kernel.txt" language="C" title="./morph.h (89, 8)"/>
/// </example>
public partial class L_Kernel : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Kernel Values = new Marshal_L_Kernel();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Kernel(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  kernel height
///  </summary>
///  <remarks>
///  Loc: ./morph.h (91, 19)
///  Org: [l_int32 sy]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  kernel width
///  </summary>
///  <remarks>
///  Loc: ./morph.h (92, 19)
///  Org: [l_int32 sx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  y location of kernel origin
///  </summary>
///  <remarks>
///  Loc: ./morph.h (93, 19)
///  Org: [l_int32 cy]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int cy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  x location of kernel origin
///  </summary>
///  <remarks>
///  Loc: ./morph.h (94, 19)
///  Org: [l_int32 cx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int cx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  data[i][j] in [row][col] order
///  </summary>
///  <remarks>
///  Loc: ./morph.h (95, 19)
///  Org: [l_float32 ** data]
///  Msh: l_float32 ** | 3:Float | List<Single[]>
///  </remarks>
	public List<Single[]> data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Kernel{
		public int sy;
		public int sx;
		public int cy;
		public int cx;
		public IntPtr data;}
	}

#endregion
#region"pix.h"
//  ./pix.h (134, 8)
/// <summary>
/// Basic Pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_Pix.txt" language="C" title="./pix.h (134, 8)"/>
/// </example>
public partial class Pix : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Pix Values = new Marshal_Pix();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Pix(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  width in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (136, 26)
///  Org: [l_uint32 w]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (137, 26)
///  Org: [l_uint32 h]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  depth in bits (bpp)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (138, 26)
///  Org: [l_uint32 d]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint d
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of samples per pixel
///  </summary>
///  <remarks>
///  Loc: ./pix.h (139, 26)
///  Org: [l_uint32 spp]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint spp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  32-bit words/line
///  </summary>
///  <remarks>
///  Loc: ./pix.h (140, 26)
///  Org: [l_uint32 wpl]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint wpl
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (141, 26)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in x direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (142, 26)
///  Org: [l_int32 xres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in y direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (144, 26)
///  Org: [l_int32 yres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  input file format, IFF_*
///  </summary>
///  <remarks>
///  Loc: ./pix.h (146, 26)
///  Org: [l_int32 informat]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public IFF informat
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  special instructions for I/O, etc
///  </summary>
///  <remarks>
///  Loc: ./pix.h (147, 26)
///  Org: [l_int32 special]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int special
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  text string associated with pix
///  </summary>
///  <remarks>
///  Loc: ./pix.h (148, 26)
///  Org: [char * text]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String text
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  colormap (may be null)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (149, 26)
///  Org: [struct PixColormap * colormap]
///  Msh: struct PixColormap * | 2:Struct |
///  </remarks>
	public PixColormap colormap
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  the image data
///  </summary>
///  <remarks>
///  Loc: ./pix.h (150, 26)
///  Org: [l_uint32 * data]
///  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
///  </remarks>
	public Byte[] data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Pix{
		public uint w;
		public uint h;
		public uint d;
		public uint spp;
		public uint wpl;
		public uint refcount;
		public int xres;
		public int yres;
		public int informat;
		public int special;
		public IntPtr text;
		public IntPtr colormap;
		public IntPtr data;}
	}

//  ./pix.h (155, 8)
/// <summary>
/// Colormap of a Pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixColormap.txt" language="C" title="./pix.h (155, 8)"/>
/// </example>
public partial class PixColormap : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixColormap Values = new Marshal_PixColormap();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixColormap(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  colormap table (array of RGBA_QUAD)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (157, 22)
///  Org: [void * array]
///  Msh: void * | 2:Void | Object -  - IntPtr
///  </remarks>
	public IntPtr array
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

///  <summary>
///  of pix (1, 2, 4 or 8 bpp)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (158, 22)
///  Org: [l_int32 depth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int depth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of color entries allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (159, 22)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of color entries used
///  </summary>
///  <remarks>
///  Loc: ./pix.h (160, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixColormap{
		public IntPtr array;
		public int depth;
		public int nalloc;
		public int n;}
	}

//  ./pix.h (169, 8)
/// <summary>
/// Colormap table entry (after the BMP version). Note that the BMP format stores the colormap table exactly as it appears here, with color samples being stored sequentially, in the order (b,g,r,a).
/// </summary>
/// <example>
/// <code source="CSource\Struct_RGBA_Quad.txt" language="C" title="./pix.h (169, 8)"/>
/// </example>
public partial class RGBA_Quad : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_RGBA_Quad Values = new Marshal_RGBA_Quad();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public RGBA_Quad(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  blue value
///  </summary>
///  <remarks>
///  Loc: ./pix.h (171, 17)
///  Org: [l_uint8 blue]
///  Msh: l_uint8 | 1:UChar |
///  </remarks>
	public byte blue
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  green value
///  </summary>
///  <remarks>
///  Loc: ./pix.h (172, 17)
///  Org: [l_uint8 green]
///  Msh: l_uint8 | 1:UChar |
///  </remarks>
	public byte green
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  red value
///  </summary>
///  <remarks>
///  Loc: ./pix.h (173, 17)
///  Org: [l_uint8 red]
///  Msh: l_uint8 | 1:UChar |
///  </remarks>
	public byte red
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  alpha value
///  </summary>
///  <remarks>
///  Loc: ./pix.h (174, 17)
///  Org: [l_uint8 alpha]
///  Msh: l_uint8 | 1:UChar |
///  </remarks>
	public byte alpha
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_RGBA_Quad{
		public byte blue;
		public byte green;
		public byte red;
		public byte alpha;}
	}

//  ./pix.h (454, 8)
/// <summary>
/// Array of pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_Pixa.txt" language="C" title="./pix.h (454, 8)"/>
/// </example>
public partial class Pixa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Pixa Values = new Marshal_Pixa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Pixa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of Pix in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (456, 25)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of Pix ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (457, 25)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (458, 25)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the array of ptrs to pix
///  </summary>
///  <remarks>
///  Loc: ./pix.h (459, 25)
///  Org: [struct Pix ** pix]
///  Msh: struct Pix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pix = Pix
///  </remarks>
	public List<Pix> pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of boxes
///  </summary>
///  <remarks>
///  Loc: ./pix.h (460, 25)
///  Org: [struct Boxa * boxa]
///  Msh: struct Boxa * | 2:Struct |
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Pixa{
		public int n;
		public int nalloc;
		public uint refcount;
		public IntPtr pix;
		public IntPtr boxa;}
	}

//  ./pix.h (465, 8)
/// <summary>
/// Array of arrays of pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_Pixaa.txt" language="C" title="./pix.h (465, 8)"/>
/// </example>
public partial class Pixaa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Pixaa Values = new Marshal_Pixaa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Pixaa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of Pixa in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (467, 25)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of Pixa ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (468, 25)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array of ptrs to pixa
///  </summary>
///  <remarks>
///  Loc: ./pix.h (469, 25)
///  Org: [struct Pixa ** pixa]
///  Msh: struct Pixa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pixa = Pixa
///  </remarks>
	public List<Pixa> pixa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of boxes
///  </summary>
///  <remarks>
///  Loc: ./pix.h (470, 25)
///  Org: [struct Boxa * boxa]
///  Msh: struct Boxa * | 2:Struct |
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Pixaa{
		public int n;
		public int nalloc;
		public IntPtr pixa;
		public IntPtr boxa;}
	}

//  ./pix.h (480, 8)
/// <summary>
/// Basic rectangle
/// </summary>
/// <example>
/// <code source="CSource\Struct_Box.txt" language="C" title="./pix.h (480, 8)"/>
/// </example>
public partial class Box : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Box Values = new Marshal_Box();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Box(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  left coordinate
///  </summary>
///  <remarks>
///  Loc: ./pix.h (482, 24)
///  Org: [l_int32 x]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  top coordinate
///  </summary>
///  <remarks>
///  Loc: ./pix.h (483, 24)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  box width
///  </summary>
///  <remarks>
///  Loc: ./pix.h (484, 24)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  box height
///  </summary>
///  <remarks>
///  Loc: ./pix.h (485, 24)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (486, 24)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Box{
		public int x;
		public int y;
		public int w;
		public int h;
		public uint refcount;}
	}

//  ./pix.h (492, 8)
/// <summary>
/// Array of Box
/// </summary>
/// <example>
/// <code source="CSource\Struct_Boxa.txt" language="C" title="./pix.h (492, 8)"/>
/// </example>
public partial class Boxa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Boxa Values = new Marshal_Boxa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Boxa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of box in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (494, 24)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of box ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (495, 24)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (496, 24)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  box ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (497, 24)
///  Org: [struct Box ** box]
///  Msh: struct Box ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Box = Box
///  </remarks>
	public List<Box> box
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Boxa{
		public int n;
		public int nalloc;
		public uint refcount;
		public IntPtr box;}
	}

//  ./pix.h (502, 8)
/// <summary>
/// Array of Boxa
/// </summary>
/// <example>
/// <code source="CSource\Struct_Boxaa.txt" language="C" title="./pix.h (502, 8)"/>
/// </example>
public partial class Boxaa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Boxaa Values = new Marshal_Boxaa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Boxaa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of boxa in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (504, 24)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of boxa ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (505, 24)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  boxa ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (506, 24)
///  Org: [struct Boxa ** boxa]
///  Msh: struct Boxa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Boxa = Boxa
///  </remarks>
	public List<Boxa> boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Boxaa{
		public int n;
		public int nalloc;
		public IntPtr boxa;}
	}

//  ./pix.h (517, 8)
/// <summary>
/// Array of points
/// </summary>
/// <example>
/// <code source="CSource\Struct_Pta.txt" language="C" title="./pix.h (517, 8)"/>
/// </example>
public partial class Pta : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Pta Values = new Marshal_Pta();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Pta(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  actual number of pts
///  </summary>
///  <remarks>
///  Loc: ./pix.h (519, 24)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  size of allocated arrays
///  </summary>
///  <remarks>
///  Loc: ./pix.h (520, 24)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (521, 24)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  arrays of floats
///  </summary>
///  <remarks>
///  Loc: ./pix.h (522, 24)
///  Org: [l_float32 * x]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  arrays of floats
///  </summary>
///  <remarks>
///  Loc: ./pix.h (522, 28)
///  Org: [l_float32 * y]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Pta{
		public int n;
		public int nalloc;
		public uint refcount;
		public IntPtr x;
		public IntPtr y;}
	}

//  ./pix.h (532, 8)
/// <summary>
/// Array of Pta
/// </summary>
/// <example>
/// <code source="CSource\Struct_Ptaa.txt" language="C" title="./pix.h (532, 8)"/>
/// </example>
public partial class Ptaa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Ptaa Values = new Marshal_Ptaa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Ptaa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of pta in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (534, 26)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of pta ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (535, 26)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pta ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (536, 26)
///  Org: [struct Pta ** pta]
///  Msh: struct Pta ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Pta = Pta
///  </remarks>
	public List<Pta> pta
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Ptaa{
		public int n;
		public int nalloc;
		public IntPtr pta;}
	}

//  ./pix.h (546, 8)
/// <summary>
/// Pix accumulator container
/// </summary>
/// <example>
/// <code source="CSource\Struct_Pixacc.txt" language="C" title="./pix.h (546, 8)"/>
/// </example>
public partial class Pixacc : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_Pixacc Values = new Marshal_Pixacc();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public Pixacc(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  array width
///  </summary>
///  <remarks>
///  Loc: ./pix.h (548, 25)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  array height
///  </summary>
///  <remarks>
///  Loc: ./pix.h (549, 25)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  used to allow negative
///  </summary>
///  <remarks>
///  Loc: ./pix.h (550, 25)
///  Org: [l_int32 offset]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int offset
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the 32 bit accumulator pix
///  </summary>
///  <remarks>
///  Loc: ./pix.h (552, 25)
///  Org: [struct Pix * pix]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_Pixacc{
		public int w;
		public int h;
		public int offset;
		public IntPtr pix;}
	}

//  ./pix.h (562, 8)
/// <summary>
/// Pix tiling
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixTiling.txt" language="C" title="./pix.h (562, 8)"/>
/// </example>
public partial class PixTiling : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixTiling Values = new Marshal_PixTiling();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixTiling(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  input pix (a clone)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (564, 26)
///  Org: [struct Pix * pix]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of tiles horizontally
///  </summary>
///  <remarks>
///  Loc: ./pix.h (565, 26)
///  Org: [l_int32 nx]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nx
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of tiles vertically
///  </summary>
///  <remarks>
///  Loc: ./pix.h (566, 26)
///  Org: [l_int32 ny]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ny
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  tile width
///  </summary>
///  <remarks>
///  Loc: ./pix.h (567, 26)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  tile height
///  </summary>
///  <remarks>
///  Loc: ./pix.h (568, 26)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  overlap on left and right
///  </summary>
///  <remarks>
///  Loc: ./pix.h (569, 26)
///  Org: [l_int32 xoverlap]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xoverlap
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  overlap on top and bottom
///  </summary>
///  <remarks>
///  Loc: ./pix.h (570, 26)
///  Org: [l_int32 yoverlap]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yoverlap
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  strip for paint default is TRUE
///  </summary>
///  <remarks>
///  Loc: ./pix.h (571, 26)
///  Org: [l_int32 strip]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int strip
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixTiling{
		public IntPtr pix;
		public int nx;
		public int ny;
		public int w;
		public int h;
		public int xoverlap;
		public int yoverlap;
		public int strip;}
	}

//  ./pix.h (582, 8)
/// <summary>
/// Pix with float array
/// </summary>
/// <example>
/// <code source="CSource\Struct_FPix.txt" language="C" title="./pix.h (582, 8)"/>
/// </example>
public partial class FPix : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_FPix Values = new Marshal_FPix();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public FPix(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  width in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (584, 26)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (585, 26)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  32-bit words/line
///  </summary>
///  <remarks>
///  Loc: ./pix.h (586, 26)
///  Org: [l_int32 wpl]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int wpl
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (587, 26)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in x direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (588, 26)
///  Org: [l_int32 xres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in y direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (590, 26)
///  Org: [l_int32 yres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the float image data
///  </summary>
///  <remarks>
///  Loc: ./pix.h (592, 26)
///  Org: [l_float32 * data]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_FPix{
		public int w;
		public int h;
		public int wpl;
		public uint refcount;
		public int xres;
		public int yres;
		public IntPtr data;}
	}

//  ./pix.h (597, 8)
/// <summary>
/// Array of FPix
/// </summary>
/// <example>
/// <code source="CSource\Struct_FPixa.txt" language="C" title="./pix.h (597, 8)"/>
/// </example>
public partial class FPixa : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_FPixa Values = new Marshal_FPixa();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public FPixa(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of fpix in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (599, 25)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of fpix ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (600, 25)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (601, 25)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the array of ptrs to fpix
///  </summary>
///  <remarks>
///  Loc: ./pix.h (602, 25)
///  Org: [struct FPix ** fpix]
///  Msh: struct FPix ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: FPix = FPix
///  </remarks>
	public List<FPix> fpix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_FPixa{
		public int n;
		public int nalloc;
		public uint refcount;
		public IntPtr fpix;}
	}

//  ./pix.h (613, 8)
/// <summary>
/// Pix with double array
/// </summary>
/// <example>
/// <code source="CSource\Struct_DPix.txt" language="C" title="./pix.h (613, 8)"/>
/// </example>
public partial class DPix : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_DPix Values = new Marshal_DPix();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public DPix(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  width in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (615, 26)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (616, 26)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  32-bit words/line
///  </summary>
///  <remarks>
///  Loc: ./pix.h (617, 26)
///  Org: [l_int32 wpl]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int wpl
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  reference count (1 if no clones)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (618, 26)
///  Org: [l_uint32 refcount]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint refcount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in x direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (619, 26)
///  Org: [l_int32 xres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in y direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (621, 26)
///  Org: [l_int32 yres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the double image data
///  </summary>
///  <remarks>
///  Loc: ./pix.h (623, 26)
///  Org: [l_float64 * data]
///  Msh: l_float64 * | 2:Double |
///  </remarks>
	public Double[] data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_DPix{
		public int w;
		public int h;
		public int wpl;
		public uint refcount;
		public int xres;
		public int yres;
		public IntPtr data;}
	}

//  ./pix.h (633, 8)
/// <summary>
/// Compressed Pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixComp.txt" language="C" title="./pix.h (633, 8)"/>
/// </example>
public partial class PixComp : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixComp Values = new Marshal_PixComp();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixComp(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  width in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (635, 26)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  height in pixels
///  </summary>
///  <remarks>
///  Loc: ./pix.h (636, 26)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  depth in bits
///  </summary>
///  <remarks>
///  Loc: ./pix.h (637, 26)
///  Org: [l_int32 d]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int d
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in x direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (638, 26)
///  Org: [l_int32 xres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  image res (ppi) in y direction
///  </summary>
///  <remarks>
///  Loc: ./pix.h (640, 26)
///  Org: [l_int32 yres]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yres
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  compressed format (IFF_TIFF_G4,
///  </summary>
///  <remarks>
///  Loc: ./pix.h (642, 26)
///  Org: [l_int32 comptype]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int comptype
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  text string associated with pix
///  </summary>
///  <remarks>
///  Loc: ./pix.h (644, 26)
///  Org: [char * text]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String text
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  flag (1 for cmap, 0 otherwise)
///  </summary>
///  <remarks>
///  Loc: ./pix.h (645, 26)
///  Org: [l_int32 cmapflag]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int cmapflag
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the compressed image data
///  </summary>
///  <remarks>
///  Loc: ./pix.h (646, 26)
///  Org: [l_uint8 * data]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  size of the data array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (647, 26)
///  Org: [size_t size]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixComp{
		public int w;
		public int h;
		public int d;
		public int xres;
		public int yres;
		public int comptype;
		public IntPtr text;
		public int cmapflag;
		public IntPtr data;
		public uint size;}
	}

//  ./pix.h (658, 8)
/// <summary>
/// Array of compressed pix
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixaComp.txt" language="C" title="./pix.h (658, 8)"/>
/// </example>
public partial class PixaComp : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixaComp Values = new Marshal_PixaComp();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixaComp(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of PixComp in ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (660, 26)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of PixComp ptrs allocated
///  </summary>
///  <remarks>
///  Loc: ./pix.h (661, 26)
///  Org: [l_int32 nalloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nalloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  indexing offset into ptr array
///  </summary>
///  <remarks>
///  Loc: ./pix.h (662, 26)
///  Org: [l_int32 offset]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int offset
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  the array of ptrs to PixComp
///  </summary>
///  <remarks>
///  Loc: ./pix.h (663, 26)
///  Org: [struct PixComp ** pixc]
///  Msh: struct PixComp ** | 3:StructDeclaration |  ... Marshal List of Class to PTR
///  </remarks>
	public List<PixComp> pixc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of boxes
///  </summary>
///  <remarks>
///  Loc: ./pix.h (664, 26)
///  Org: [struct Boxa * boxa]
///  Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixaComp{
		public int n;
		public int nalloc;
		public int offset;
		public IntPtr pixc;
		public IntPtr boxa;}
	}

#endregion
#region"recog.h"
//  ./recog.h (116, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Recog.txt" language="C" title="./recog.h (116, 8)"/>
/// </example>
public partial class L_Recog : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Recog Values = new Marshal_L_Recog();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Recog(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  scale all examples to this width
///  </summary>
///  <remarks>
///  Loc: ./recog.h (117, 20)
///  Org: [l_int32 scalew]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int scalew
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  scale all examples to this height
///  </summary>
///  <remarks>
///  Loc: ./recog.h (119, 20)
///  Org: [l_int32 scaleh]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int scaleh
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  use a value > 0 to convert the bitmap
///  </summary>
///  <remarks>
///  Loc: ./recog.h (121, 20)
///  Org: [l_int32 linew]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int linew
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  template use: use either the average
///  </summary>
///  <remarks>
///  Loc: ./recog.h (123, 20)
///  Org: [l_int32 templ_use]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int templ_use
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  initialize container arrays to this
///  </summary>
///  <remarks>
///  Loc: ./recog.h (126, 20)
///  Org: [l_int32 maxarraysize]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxarraysize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  size of character set
///  </summary>
///  <remarks>
///  Loc: ./recog.h (127, 20)
///  Org: [l_int32 setsize]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int setsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  for binarizing if depth > 1
///  </summary>
///  <remarks>
///  Loc: ./recog.h (128, 20)
///  Org: [l_int32 threshold]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int threshold
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  vertical jiggle on nominal centroid
///  </summary>
///  <remarks>
///  Loc: ./recog.h (129, 20)
///  Org: [l_int32 maxyshift]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxyshift
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  one of L_ARABIC_NUMERALS, etc.
///  </summary>
///  <remarks>
///  Loc: ./recog.h (131, 20)
///  Org: [l_int32 charset_type]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int charset_type
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  expected number of classes in charset
///  </summary>
///  <remarks>
///  Loc: ./recog.h (132, 20)
///  Org: [l_int32 charset_size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int charset_size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min number of samples without padding
///  </summary>
///  <remarks>
///  Loc: ./recog.h (133, 20)
///  Org: [l_int32 min_nopad]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int min_nopad
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of training samples
///  </summary>
///  <remarks>
///  Loc: ./recog.h (134, 20)
///  Org: [l_int32 num_samples]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int num_samples
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min width averaged unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (135, 20)
///  Org: [l_int32 minwidth_u]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minwidth_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max width averaged unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (136, 20)
///  Org: [l_int32 maxwidth_u]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxwidth_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min height averaged unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (137, 20)
///  Org: [l_int32 minheight_u]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minheight_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max height averaged unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (138, 20)
///  Org: [l_int32 maxheight_u]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxheight_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  min width averaged scaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (139, 20)
///  Org: [l_int32 minwidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minwidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max width averaged scaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (140, 20)
///  Org: [l_int32 maxwidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxwidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 when averaged bitmaps are made
///  </summary>
///  <remarks>
///  Loc: ./recog.h (141, 20)
///  Org: [l_int32 ave_done]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ave_done
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 when training is complete or
///  </summary>
///  <remarks>
///  Loc: ./recog.h (142, 20)
///  Org: [l_int32 train_done]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int train_done
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max width/height ratio to split
///  </summary>
///  <remarks>
///  Loc: ./recog.h (144, 20)
///  Org: [l_float32 max_wh_ratio]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single max_wh_ratio
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  max of max/min template height ratio
///  </summary>
///  <remarks>
///  Loc: ./recog.h (145, 20)
///  Org: [l_float32 max_ht_ratio]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single max_ht_ratio
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  min component width kept in splitting
///  </summary>
///  <remarks>
///  Loc: ./recog.h (146, 20)
///  Org: [l_int32 min_splitw]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int min_splitw
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max component height kept in splitting
///  </summary>
///  <remarks>
///  Loc: ./recog.h (147, 20)
///  Org: [l_int32 max_splith]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int max_splith
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  text array for arbitrary char set
///  </summary>
///  <remarks>
///  Loc: ./recog.h (148, 20)
///  Org: [struct Sarray * sa_text]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray sa_text
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  index-to-char lut for arbitrary charset
///  </summary>
///  <remarks>
///  Loc: ./recog.h (149, 20)
///  Org: [struct L_Dna * dna_tochar]
///  Msh: struct L_Dna * | 2:Struct |  | Typedef: L_Dna = L_Dna
///  </remarks>
	public L_Dna dna_tochar
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  table for finding centroids
///  </summary>
///  <remarks>
///  Loc: ./recog.h (150, 20)
///  Org: [l_int32 * centtab]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] centtab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  table for finding pixel sums
///  </summary>
///  <remarks>
///  Loc: ./recog.h (151, 20)
///  Org: [l_int32 * sumtab]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] sumtab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  all unscaled templates for each class
///  </summary>
///  <remarks>
///  Loc: ./recog.h (152, 20)
///  Org: [struct Pixaa * pixaa_u]
///  Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
///  </remarks>
	public Pixaa pixaa_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of all unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (153, 20)
///  Org: [struct Ptaa * ptaa_u]
///  Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
///  </remarks>
	public Ptaa ptaa_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  area of all unscaled templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (154, 20)
///  Org: [struct Numaa * naasum_u]
///  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
///  </remarks>
	public Numaa naasum_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  all (scaled) templates for each class
///  </summary>
///  <remarks>
///  Loc: ./recog.h (155, 20)
///  Org: [struct Pixaa * pixaa]
///  Msh: struct Pixaa * | 2:Struct |  | Typedef: Pixaa = Pixaa
///  </remarks>
	public Pixaa pixaa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of all (scaledl) templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (156, 20)
///  Org: [struct Ptaa * ptaa]
///  Msh: struct Ptaa * | 2:Struct |  | Typedef: Ptaa = Ptaa
///  </remarks>
	public Ptaa ptaa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  area of all (scaled) templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (157, 20)
///  Org: [struct Numaa * naasum]
///  Msh: struct Numaa * | 2:Struct |  | Typedef: Numaa = Numaa
///  </remarks>
	public Numaa naasum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  averaged unscaled templates per class
///  </summary>
///  <remarks>
///  Loc: ./recog.h (158, 20)
///  Org: [struct Pixa * pixa_u]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixa_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of unscaled ave. templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (159, 20)
///  Org: [struct Pta * pta_u]
///  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
///  </remarks>
	public Pta pta_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  area of unscaled averaged templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (160, 20)
///  Org: [struct Numa * nasum_u]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasum_u
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  averaged (scaled) templates per class
///  </summary>
///  <remarks>
///  Loc: ./recog.h (161, 20)
///  Org: [struct Pixa * pixa]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  centroids of (scaled) ave. templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (162, 20)
///  Org: [struct Pta * pta]
///  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
///  </remarks>
	public Pta pta
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  area of (scaled) averaged templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (163, 20)
///  Org: [struct Numa * nasum]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  all input training images
///  </summary>
///  <remarks>
///  Loc: ./recog.h (164, 20)
///  Org: [struct Pixa * pixa_tr]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixa_tr
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  unscaled and scaled averaged bitmaps
///  </summary>
///  <remarks>
///  Loc: ./recog.h (165, 20)
///  Org: [struct Pixa * pixadb_ave]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixadb_ave
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  input images for identifying
///  </summary>
///  <remarks>
///  Loc: ./recog.h (166, 20)
///  Org: [struct Pixa * pixa_id]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixa_id
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  debug: best match of input against ave.
///  </summary>
///  <remarks>
///  Loc: ./recog.h (167, 20)
///  Org: [struct Pix * pixdb_ave]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixdb_ave
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  debug: best matches within range
///  </summary>
///  <remarks>
///  Loc: ./recog.h (168, 20)
///  Org: [struct Pix * pixdb_range]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixdb_range
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  debug: bootstrap training results
///  </summary>
///  <remarks>
///  Loc: ./recog.h (169, 20)
///  Org: [struct Pixa * pixadb_boot]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixadb_boot
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  debug: splitting results
///  </summary>
///  <remarks>
///  Loc: ./recog.h (170, 20)
///  Org: [struct Pixa * pixadb_split]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixadb_split
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  bmf fonts
///  </summary>
///  <remarks>
///  Loc: ./recog.h (171, 20)
///  Org: [struct L_Bmf * bmf]
///  Msh: struct L_Bmf * | 2:Struct |  | Typedef: L_Bmf = L_Bmf
///  </remarks>
	public L_Bmf bmf
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  font size of bmf default is 6 pt
///  </summary>
///  <remarks>
///  Loc: ./recog.h (172, 20)
///  Org: [l_int32 bmf_size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bmf_size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  temp data used for image decoding
///  </summary>
///  <remarks>
///  Loc: ./recog.h (173, 20)
///  Org: [struct L_Rdid * did]
///  Msh: struct L_Rdid * | 2:Struct |
///  </remarks>
	public L_Rdid did
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  temp data used for holding best char
///  </summary>
///  <remarks>
///  Loc: ./recog.h (174, 20)
///  Org: [struct L_Rch * rch]
///  Msh: struct L_Rch * | 2:Struct |
///  </remarks>
	public L_Rch rch
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  temp data used for array of best chars
///  </summary>
///  <remarks>
///  Loc: ./recog.h (175, 20)
///  Org: [struct L_Rcha * rcha]
///  Msh: struct L_Rcha * | 2:Struct |
///  </remarks>
	public L_Rcha rcha
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Recog{
		public int scalew;
		public int scaleh;
		public int linew;
		public int templ_use;
		public int maxarraysize;
		public int setsize;
		public int threshold;
		public int maxyshift;
		public int charset_type;
		public int charset_size;
		public int min_nopad;
		public int num_samples;
		public int minwidth_u;
		public int maxwidth_u;
		public int minheight_u;
		public int maxheight_u;
		public int minwidth;
		public int maxwidth;
		public int ave_done;
		public int train_done;
		public Single max_wh_ratio;
		public Single max_ht_ratio;
		public int min_splitw;
		public int max_splith;
		public IntPtr sa_text;
		public IntPtr dna_tochar;
		public IntPtr centtab;
		public IntPtr sumtab;
		public IntPtr pixaa_u;
		public IntPtr ptaa_u;
		public IntPtr naasum_u;
		public IntPtr pixaa;
		public IntPtr ptaa;
		public IntPtr naasum;
		public IntPtr pixa_u;
		public IntPtr pta_u;
		public IntPtr nasum_u;
		public IntPtr pixa;
		public IntPtr pta;
		public IntPtr nasum;
		public IntPtr pixa_tr;
		public IntPtr pixadb_ave;
		public IntPtr pixa_id;
		public IntPtr pixdb_ave;
		public IntPtr pixdb_range;
		public IntPtr pixadb_boot;
		public IntPtr pixadb_split;
		public IntPtr bmf;
		public int bmf_size;
		public IntPtr did;
		public IntPtr rch;
		public IntPtr rcha;}
	}

//  ./recog.h (182, 8)
/// <summary>
/// Data returned from correlation matching on a single character
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Rch.txt" language="C" title="./recog.h (182, 8)"/>
/// </example>
public partial class L_Rch : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Rch Values = new Marshal_L_Rch();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Rch(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  index of best template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (183, 20)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  correlation score of best template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (184, 20)
///  Org: [l_float32 score]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single score
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  character string of best template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (185, 20)
///  Org: [char * text]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String text
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  index of best sample (within the best
///  </summary>
///  <remarks>
///  Loc: ./recog.h (186, 20)
///  Org: [l_int32 sample]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int sample
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  x-location of template (delx + shiftx)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (188, 20)
///  Org: [l_int32 xloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  y-location of template (dely + shifty)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (189, 20)
///  Org: [l_int32 yloc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int yloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  width of best template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (190, 20)
///  Org: [l_int32 width]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int width
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Rch{
		public int index;
		public Single score;
		public IntPtr text;
		public int sample;
		public int xloc;
		public int yloc;
		public int width;}
	}

//  ./recog.h (197, 8)
/// <summary>
/// Data returned from correlation matching on an array of characters
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Rcha.txt" language="C" title="./recog.h (197, 8)"/>
/// </example>
public partial class L_Rcha : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Rcha Values = new Marshal_L_Rcha();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Rcha(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  indices of best templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (198, 20)
///  Org: [struct Numa * naindex]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naindex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  correlation scores of best templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (199, 20)
///  Org: [struct Numa * nascore]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nascore
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  character strings of best templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (200, 20)
///  Org: [struct Sarray * satext]
///  Msh: struct Sarray * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray satext
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  indices of best samples
///  </summary>
///  <remarks>
///  Loc: ./recog.h (201, 20)
///  Org: [struct Numa * nasample]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasample
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  x-locations of templates (delx + shiftx)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (202, 20)
///  Org: [struct Numa * naxloc]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naxloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  y-locations of templates (dely + shifty)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (203, 20)
///  Org: [struct Numa * nayloc]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nayloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  widths of best templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (204, 20)
///  Org: [struct Numa * nawidth]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nawidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Rcha{
		public IntPtr naindex;
		public IntPtr nascore;
		public IntPtr satext;
		public IntPtr nasample;
		public IntPtr naxloc;
		public IntPtr nayloc;
		public IntPtr nawidth;}
	}

//  ./recog.h (211, 8)
/// <summary>
/// Data used for decoding a line of characters.
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Rdid.txt" language="C" title="./recog.h (211, 8)"/>
/// </example>
public partial class L_Rdid : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Rdid Values = new Marshal_L_Rdid();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Rdid(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  clone of pix to be decoded
///  </summary>
///  <remarks>
///  Loc: ./recog.h (212, 20)
///  Org: [struct Pix * pixs]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixs
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  count array for each averaged template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (213, 20)
///  Org: [l_int32 ** counta]
///  Msh: l_int32 ** | 3:Integer | List<int[]>
///  </remarks>
	public List<int[]> counta
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  best y-shift array per average template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (214, 20)
///  Org: [l_int32 ** delya]
///  Msh: l_int32 ** | 3:Integer | List<int[]>
///  </remarks>
	public List<int[]> delya
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of averaged templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (215, 20)
///  Org: [l_int32 narray]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int narray
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  size of count array (width of pixs)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (216, 20)
///  Org: [l_int32 size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  setwidths for each template
///  </summary>
///  <remarks>
///  Loc: ./recog.h (217, 20)
///  Org: [l_int32 * setwidth]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] setwidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pixel count in pixs by column
///  </summary>
///  <remarks>
///  Loc: ./recog.h (218, 20)
///  Org: [struct Numa * nasum]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  first moment of pixels in pixs by cols
///  </summary>
///  <remarks>
///  Loc: ./recog.h (219, 20)
///  Org: [struct Numa * namoment]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa namoment
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  1 if full arrays are made 0 otherwise
///  </summary>
///  <remarks>
///  Loc: ./recog.h (220, 20)
///  Org: [l_int32 fullarrays]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int fullarrays
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  channel coeffs for template fg term
///  </summary>
///  <remarks>
///  Loc: ./recog.h (221, 20)
///  Org: [l_float32 * beta]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] beta
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  channel coeffs for bit-and term
///  </summary>
///  <remarks>
///  Loc: ./recog.h (222, 20)
///  Org: [l_float32 * gamma]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] gamma
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  score on trellis
///  </summary>
///  <remarks>
///  Loc: ./recog.h (223, 20)
///  Org: [l_float32 * trellisscore]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] trellisscore
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  template on trellis (for backtrack)
///  </summary>
///  <remarks>
///  Loc: ./recog.h (224, 20)
///  Org: [l_int32 * trellistempl]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] trellistempl
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  indices of best path templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (225, 20)
///  Org: [struct Numa * natempl]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa natempl
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  x locations of best path templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (226, 20)
///  Org: [struct Numa * naxloc]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naxloc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  y locations of best path templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (227, 20)
///  Org: [struct Numa * nadely]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nadely
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  widths of best path templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (228, 20)
///  Org: [struct Numa * nawidth]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nawidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  Viterbi result for splitting input pixs
///  </summary>
///  <remarks>
///  Loc: ./recog.h (229, 20)
///  Org: [struct Boxa * boxa]
///  Msh: struct Boxa * | 2:Struct |  | Typedef: Boxa = Boxa
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  correlation scores: best path templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (230, 20)
///  Org: [struct Numa * nascore]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nascore
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  indices of best rescored templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (231, 20)
///  Org: [struct Numa * natempl_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa natempl_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  samples of best scored templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (232, 20)
///  Org: [struct Numa * nasample_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasample_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  x locations of best rescoredtemplates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (233, 20)
///  Org: [struct Numa * naxloc_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa naxloc_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  y locations of best rescoredtemplates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (234, 20)
///  Org: [struct Numa * nadely_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nadely_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  widths of best rescoredtemplates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (235, 20)
///  Org: [struct Numa * nawidth_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nawidth_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  correlation scores: rescored templates
///  </summary>
///  <remarks>
///  Loc: ./recog.h (236, 20)
///  Org: [struct Numa * nascore_r]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nascore_r
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Rdid{
		public IntPtr pixs;
		public IntPtr counta;
		public IntPtr delya;
		public int narray;
		public int size;
		public IntPtr setwidth;
		public IntPtr nasum;
		public IntPtr namoment;
		public int fullarrays;
		public IntPtr beta;
		public IntPtr gamma;
		public IntPtr trellisscore;
		public IntPtr trellistempl;
		public IntPtr natempl;
		public IntPtr naxloc;
		public IntPtr nadely;
		public IntPtr nawidth;
		public IntPtr boxa;
		public IntPtr nascore;
		public IntPtr natempl_r;
		public IntPtr nasample_r;
		public IntPtr naxloc_r;
		public IntPtr nadely_r;
		public IntPtr nawidth_r;
		public IntPtr nascore_r;}
	}

#endregion
#region"regutils.h"
//  ./regutils.h (117, 8)
/// <summary>
/// Regression test parameter packer
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_RegParams.txt" language="C" title="./regutils.h (117, 8)"/>
/// </example>
public partial class L_RegParams : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_RegParams Values = new Marshal_L_RegParams();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_RegParams(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  stream to temporary output file for compare mode
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (119, 14)
///  Org: [FILE * fp]
///  Msh: FILE * | 2:Struct |
///  </remarks>
	public FILE fp
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  name of test, without '_reg'
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (120, 14)
///  Org: [char * testname]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String testname
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  name of temp file for compare mode output
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (121, 14)
///  Org: [char * tempfile]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String tempfile
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  generate, compare or display
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (122, 14)
///  Org: [l_int32 mode]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int mode
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  index into saved files for this test 0-based
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (123, 14)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  overall result of the test
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (124, 14)
///  Org: [l_int32 success]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int success
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  1 if in display mode 0 otherwise
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (125, 14)
///  Org: [l_int32 display]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int display
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  marks beginning of the reg test
///  </summary>
///  <remarks>
///  Loc: ./regutils.h (126, 14)
///  Org: [L_TIMER tstart]
///  Msh: L_TIMER | 1:Pointer |
///  </remarks>
	public IntPtr tstart
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_RegParams{
		public IntPtr fp;
		public IntPtr testname;
		public IntPtr tempfile;
		public int mode;
		public int index;
		public int success;
		public int display;
		public IntPtr tstart;}
	}

#endregion
#region"stringcode.h"
//  ./stringcode.h (40, 8)
/// <summary>
/// stringcode.h
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_StrCode.txt" language="C" title="./stringcode.h (40, 8)"/>
/// </example>
public partial class L_StrCode : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_StrCode Values = new Marshal_L_StrCode();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_StrCode(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  index for function and output file names
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (42, 19)
///  Org: [l_int32 fileno]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int fileno
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  index into struct currently being stored
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (43, 19)
///  Org: [l_int32 ifunc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ifunc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  store case code for extraction
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (44, 19)
///  Org: [SARRAY * function]
///  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray _function_
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  store base64 encoded data as strings
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (45, 19)
///  Org: [SARRAY * data]
///  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray data
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  store line in description table
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (46, 19)
///  Org: [SARRAY * descr]
///  Msh: SARRAY * | 2:Struct |  | Typedef: Sarray = Sarray
///  </remarks>
	public Sarray descr
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of data strings
///  </summary>
///  <remarks>
///  Loc: ./stringcode.h (47, 19)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_StrCode{
		public int fileno;
		public int ifunc;
		public IntPtr _function_;
		public IntPtr data;
		public IntPtr descr;
		public int n;}
	}

#endregion
#region"sudoku.h"
//  ./sudoku.h (52, 8)
/// <summary>
/// sudoku.h
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Sudoku.txt" language="C" title="./sudoku.h (52, 8)"/>
/// </example>
public partial class L_Sudoku : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Sudoku Values = new Marshal_L_Sudoku();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Sudoku(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  number of unknowns
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (54, 20)
///  Org: [l_int32 num]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int num
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  location of unknowns
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (55, 20)
///  Org: [l_int32 * locs]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] locs
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  index into %locs of current location
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (56, 20)
///  Org: [l_int32 current]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int current
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  initial state, with 0 representing
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (57, 20)
///  Org: [l_int32 * init]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] init
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  present state, including inits and
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (59, 20)
///  Org: [l_int32 * state]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] state
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  shows current number of guesses
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (61, 20)
///  Org: [l_int32 nguess]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nguess
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 when solved
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (62, 20)
///  Org: [l_int32 finished]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int finished
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 if no solution is possible
///  </summary>
///  <remarks>
///  Loc: ./sudoku.h (63, 20)
///  Org: [l_int32 failure]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int failure
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Sudoku{
		public int num;
		public IntPtr locs;
		public int current;
		public IntPtr init;
		public IntPtr state;
		public int nguess;
		public int finished;
		public int failure;}
	}

#endregion
#region"watershed.h"
//  ./watershed.h (38, 8)
/// <summary>
/// Simple data structure to hold watershed data.
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_WShed.txt" language="C" title="./watershed.h (38, 8)"/>
/// </example>
public partial class L_WShed : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_WShed Values = new Marshal_L_WShed();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_WShed(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  clone of input 8 bpp pixs
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (40, 20)
///  Org: [struct Pix * pixs]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixs
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  clone of input 1 bpp seed (marker) pixm
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (41, 20)
///  Org: [struct Pix * pixm]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixm
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  minimum depth allowed for a watershed
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (42, 20)
///  Org: [l_int32 mindepth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int mindepth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  16 bpp label pix
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (43, 20)
///  Org: [struct Pix * pixlab]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixlab
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  scratch pix for computing wshed regions
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (44, 20)
///  Org: [struct Pix * pixt]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixt
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  line ptrs for pixs
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (45, 20)
///  Org: [void ** lines8]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] lines8
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  line ptrs for pixm
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (46, 20)
///  Org: [void ** linem1]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] linem1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  line ptrs for pixlab
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (47, 20)
///  Org: [void ** linelab32]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] linelab32
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  line ptrs for pixt
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (48, 20)
///  Org: [void ** linet1]
///  Msh: void ** | 3:Void | IntPtr[]
///  </remarks>
	public IntPtr[] linet1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  result: 1 bpp pixa of watersheds
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (49, 20)
///  Org: [struct Pixa * pixad]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixad
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pta of initial seed pixels
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (50, 20)
///  Org: [struct Pta * ptas]
///  Msh: struct Pta * | 2:Struct |  | Typedef: Pta = Pta
///  </remarks>
	public Pta ptas
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  numa of seed indicators 0 if completed
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (51, 20)
///  Org: [struct Numa * nasi]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nasi
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  numa of initial seed heights
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (52, 20)
///  Org: [struct Numa * nash]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nash
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  numa of initial minima heights
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (53, 20)
///  Org: [struct Numa * namh]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa namh
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  result: numa of watershed levels
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (54, 20)
///  Org: [struct Numa * nalevels]
///  Msh: struct Numa * | 2:Struct |  | Typedef: Numa = Numa
///  </remarks>
	public Numa nalevels
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of seeds (markers)
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (55, 20)
///  Org: [l_int32 nseeds]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nseeds
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of minima different from seeds
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (56, 20)
///  Org: [l_int32 nother]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nother
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  lut for pixel indices
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (57, 20)
///  Org: [l_int32 * lut]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] lut
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  back-links into lut, for updates
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (58, 20)
///  Org: [struct Numa ** links]
///  Msh: struct Numa ** | 3:StructDeclaration |  ... Marshal List of Class to PTR | Typedef: Numa = Numa
///  </remarks>
	public List<Numa> links
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  size of links array
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (59, 20)
///  Org: [l_int32 arraysize]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int arraysize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set to 1 for debug output
///  </summary>
///  <remarks>
///  Loc: ./watershed.h (60, 20)
///  Org: [l_int32 debug]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int debug
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_WShed{
		public IntPtr pixs;
		public IntPtr pixm;
		public int mindepth;
		public IntPtr pixlab;
		public IntPtr pixt;
		public IntPtr lines8;
		public IntPtr linem1;
		public IntPtr linelab32;
		public IntPtr linet1;
		public IntPtr pixad;
		public IntPtr ptas;
		public IntPtr nasi;
		public IntPtr nash;
		public IntPtr namh;
		public IntPtr nalevels;
		public int nseeds;
		public int nother;
		public IntPtr lut;
		public IntPtr links;
		public int arraysize;
		public int debug;}
	}

#endregion
#region"bilateral.h"
//  ./bilateral.h (115, 8)
/// <summary>
/// Bilateral filter
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Bilateral.txt" language="C" title="./bilateral.h (115, 8)"/>
/// </example>
public partial class L_Bilateral : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Bilateral Values = new Marshal_L_Bilateral();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Bilateral(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  clone of source pix
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (117, 21)
///  Org: [struct Pix * pixs]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixs
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  downscaled pix with mirrored border
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (118, 21)
///  Org: [struct Pix * pixsc]
///  Msh: struct Pix * | 2:Struct |  | Typedef: Pix = Pix
///  </remarks>
	public Pix pixsc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  1, 2 or 4x for intermediates
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (119, 21)
///  Org: [l_int32 reduction]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int reduction
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  stdev of spatial gaussian
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (120, 21)
///  Org: [l_float32 spatial_stdev]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single spatial_stdev
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  stdev of range gaussian
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (121, 21)
///  Org: [l_float32 range_stdev]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single range_stdev
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  1D gaussian spatial kernel
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (122, 21)
///  Org: [l_float32 * spatial]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] spatial
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  one-sided gaussian range kernel
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (123, 21)
///  Org: [l_float32 * range]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] range
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  min value in 8 bpp pix
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (124, 21)
///  Org: [l_int32 minval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int minval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  max value in 8 bpp pix
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (125, 21)
///  Org: [l_int32 maxval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int maxval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of intermediate results
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (126, 21)
///  Org: [l_int32 ncomps]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int ncomps
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  set of k values (size ncomps)
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (127, 21)
///  Org: [l_int32 * nc]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] nc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  mapping from intensity to lower k
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (128, 21)
///  Org: [l_int32 * kindex]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] kindex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  mapping from intensity to fract k
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (129, 21)
///  Org: [l_float32 * kfract]
///  Msh: l_float32 * | 2:Float |  ... = Single
///  </remarks>
	public Single[] kfract
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  intermediate result images (PBC)
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (130, 21)
///  Org: [struct Pixa * pixac]
///  Msh: struct Pixa * | 2:Struct |  | Typedef: Pixa = Pixa
///  </remarks>
	public Pixa pixac
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  lineptrs for pixac
///  </summary>
///  <remarks>
///  Loc: ./bilateral.h (131, 21)
///  Org: [l_uint32 *** lineset]
///  Msh: l_uint32 *** | 3:UInt | List (of List ( of List (of Byte()))) ... UInt => Byte[4]
///  </remarks>
	public List <List <List <Byte[]>>> lineset
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Bilateral{
		public IntPtr pixs;
		public IntPtr pixsc;
		public int reduction;
		public Single spatial_stdev;
		public Single range_stdev;
		public IntPtr spatial;
		public IntPtr range;
		public int minval;
		public int maxval;
		public int ncomps;
		public IntPtr nc;
		public IntPtr kindex;
		public IntPtr kfract;
		public IntPtr pixac;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=4)]
		public IntPtr lineset;}
	}

#endregion
#region"bmp.h"
//  ./bmp.h (50, 8)
/// <summary>
/// BMP file header
/// </summary>
/// <example>
/// <code source="CSource\Struct_BMP_FileHeader.txt" language="C" title="./bmp.h (50, 8)"/>
/// </example>
public partial class BMP_FileHeader : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_BMP_FileHeader Values = new Marshal_BMP_FileHeader();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public BMP_FileHeader(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  file type must be "BM"
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (52, 20)
///  Org: [l_int16 bfType]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfType
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  length of the file sizeof(BMP_FileHeader) + sizeof(BMP_InfoHeader) + size of color table + size of DIB bits
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (53, 20)
///  Org: [l_int16 bfSize]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfSize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  remainder of the bfSize field
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (58, 20)
///  Org: [l_int16 bfFill1]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfFill1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  don't care (set to 0)
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (59, 20)
///  Org: [l_int16 bfReserved1]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfReserved1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  don't care (set to 0)
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (60, 20)
///  Org: [l_int16 bfReserved2]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfReserved2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  offset from beginning of file
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (61, 20)
///  Org: [l_int16 bfOffBits]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfOffBits
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  remainder of the bfOffBits field
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (62, 20)
///  Org: [l_int16 bfFill2]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short bfFill2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_BMP_FileHeader{
		public short bfType;
		public short bfSize;
		public short bfFill1;
		public short bfReserved1;
		public short bfReserved2;
		public short bfOffBits;
		public short bfFill2;}
	}

//  ./bmp.h (75, 8)
/// <summary>
/// BMP info header
/// </summary>
/// <example>
/// <code source="CSource\Struct_BMP_InfoHeader.txt" language="C" title="./bmp.h (75, 8)"/>
/// </example>
public partial class BMP_InfoHeader : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_BMP_InfoHeader Values = new Marshal_BMP_InfoHeader();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public BMP_InfoHeader(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  size of the BMP_InfoHeader struct
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (77, 20)
///  Org: [l_int32 biSize]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biSize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  bitmap width in pixels
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (78, 20)
///  Org: [l_int32 biWidth]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biWidth
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  bitmap height in pixels
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (79, 20)
///  Org: [l_int32 biHeight]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biHeight
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of bitmap planes
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (80, 20)
///  Org: [l_int16 biPlanes]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short biPlanes
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of bits per pixel
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (81, 20)
///  Org: [l_int16 biBitCount]
///  Msh: l_int16 | 1:Short |
///  </remarks>
	public short biBitCount
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  compress format (0 == uncompressed)
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (82, 20)
///  Org: [l_int32 biCompression]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biCompression
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  size of image in bytes
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (83, 20)
///  Org: [l_int32 biSizeImage]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biSizeImage
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pixels per meter in x direction
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (84, 20)
///  Org: [l_int32 biXPelsPerMeter]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biXPelsPerMeter
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pixels per meter in y direction
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (85, 20)
///  Org: [l_int32 biYPelsPerMeter]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biYPelsPerMeter
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of colors used
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (86, 20)
///  Org: [l_int32 biClrUsed]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biClrUsed
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  number of important colors used
///  </summary>
///  <remarks>
///  Loc: ./bmp.h (87, 20)
///  Org: [l_int32 biClrImportant]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int biClrImportant
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_BMP_InfoHeader{
		public int biSize;
		public int biWidth;
		public int biHeight;
		public short biPlanes;
		public short biBitCount;
		public int biCompression;
		public int biSizeImage;
		public int biXPelsPerMeter;
		public int biYPelsPerMeter;
		public int biClrUsed;
		public int biClrImportant;}
	}

#endregion
#region"lorquant1.c"
//  colorquant1.c (158, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_ColorQuantCell.txt" language="C" title="colorquant1.c (158, 8)"/>
/// </example>
public partial class ColorQuantCell : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_ColorQuantCell Values = new Marshal_ColorQuantCell();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public ColorQuantCell(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: colorquant1.c (160, 17)
///  Org: [l_int32 rc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (160, 21)
///  Org: [l_int32 gc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int gc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (160, 25)
///  Org: [l_int32 bc]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bc
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (161, 17)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (162, 17)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (163, 17)
///  Org: [l_int32 nleaves]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nleaves
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (164, 17)
///  Org: [l_int32 bleaf]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bleaf
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_ColorQuantCell{
		public int rc;
		public int gc;
		public int bc;
		public int n;
		public int index;
		public int nleaves;
		public int bleaf;}
	}

//  colorquant1.c (190, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_OctcubeQuantCell.txt" language="C" title="colorquant1.c (190, 8)"/>
/// </example>
public partial class OctcubeQuantCell : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_OctcubeQuantCell Values = new Marshal_OctcubeQuantCell();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public OctcubeQuantCell(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: colorquant1.c (192, 16)
///  Org: [l_float32 n]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (193, 16)
///  Org: [l_int32 octindex]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int octindex
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (194, 16)
///  Org: [l_int32 rcum]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rcum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (194, 22)
///  Org: [l_int32 gcum]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int gcum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (194, 28)
///  Org: [l_int32 bcum]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bcum
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (195, 16)
///  Org: [l_int32 rval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (195, 22)
///  Org: [l_int32 gval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int gval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (195, 28)
///  Org: [l_int32 bval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_OctcubeQuantCell{
		public Single n;
		public int octindex;
		public int rcum;
		public int gcum;
		public int bcum;
		public int rval;
		public int gval;
		public int bval;}
	}

//  colorquant1.c (206, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_OctcubePop.txt" language="C" title="colorquant1.c (206, 8)"/>
/// </example>
public partial class L_OctcubePop : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_OctcubePop Values = new Marshal_L_OctcubePop();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_OctcubePop(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: colorquant1.c (208, 22)
///  Org: [l_float32 npix]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single npix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (209, 22)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (210, 22)
///  Org: [l_int32 rval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int rval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (211, 22)
///  Org: [l_int32 gval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int gval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant1.c (212, 22)
///  Org: [l_int32 bval]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int bval
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_OctcubePop{
		public Single npix;
		public int index;
		public int rval;
		public int gval;
		public int bval;}
	}

#endregion
#region"lorquant2.c"
//  colorquant2.c (178, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Box3d.txt" language="C" title="colorquant2.c (178, 8)"/>
/// </example>
public partial class L_Box3d : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Box3d Values = new Marshal_L_Box3d();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Box3d(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: colorquant2.c (180, 22)
///  Org: [l_float32 sortparam]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single sortparam
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (181, 22)
///  Org: [l_int32 npix]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int npix
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (182, 22)
///  Org: [l_int32 vol]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int vol
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (183, 22)
///  Org: [l_int32 r1]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int r1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (184, 22)
///  Org: [l_int32 r2]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int r2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (185, 22)
///  Org: [l_int32 g1]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int g1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (186, 22)
///  Org: [l_int32 g2]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int g2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (187, 22)
///  Org: [l_int32 b1]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int b1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: colorquant2.c (188, 22)
///  Org: [l_int32 b2]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int b2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Box3d{
		public Single sortparam;
		public int npix;
		public int vol;
		public int r1;
		public int r2;
		public int g1;
		public int g2;
		public int b1;
		public int b2;}
	}

#endregion
#region"nncomp.c"
//  conncomp.c (99, 8)
/// <summary>
/// The struct FillSeg is used by the Heckbert seedfill algorithm to hold information about image segments that are waiting to be investigated. We use two Stacks, one to hold the FillSegs in use, and an auxiliary Stack as a reservoir to hold FillSegs for re-use.
/// </summary>
/// <example>
/// <code source="CSource\Struct_FillSeg.txt" language="C" title="conncomp.c (99, 8)"/>
/// </example>
public partial class FillSeg : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_FillSeg Values = new Marshal_FillSeg();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public FillSeg(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  left edge of run
///  </summary>
///  <remarks>
///  Loc: conncomp.c (101, 16)
///  Org: [l_int32 xleft]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xleft
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  right edge of run
///  </summary>
///  <remarks>
///  Loc: conncomp.c (102, 16)
///  Org: [l_int32 xright]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int xright
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  run y
///  </summary>
///  <remarks>
///  Loc: conncomp.c (103, 16)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  parent segment direction: 1 above, -1 below)
///  </summary>
///  <remarks>
///  Loc: conncomp.c (104, 16)
///  Org: [l_int32 dy]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int dy
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_FillSeg{
		public int xleft;
		public int xright;
		public int y;
		public int dy;}
	}

#endregion
#region"class.c"
//  jbclass.c (236, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_JbFindTemplatesState.txt" language="C" title="jbclass.c (236, 8)"/>
/// </example>
public partial class JbFindTemplatesState : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_JbFindTemplatesState Values = new Marshal_JbFindTemplatesState();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public JbFindTemplatesState(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: jbclass.c (238, 22)
///  Org: [JBCLASSER * classer]
///  Msh: JBCLASSER * | 2:Struct |  | Typedef: JbClasser = JbClasser
///  </remarks>
	public JbClasser classer
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: jbclass.c (239, 22)
///  Org: [l_int32 w]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int w
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: jbclass.c (240, 22)
///  Org: [l_int32 h]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int h
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: jbclass.c (241, 22)
///  Org: [l_int32 i]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int i
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: jbclass.c (242, 22)
///  Org: [L_DNA * dna]
///  Msh: L_DNA * | 2:Struct |  | Typedef: L_Dna = L_Dna
///  </remarks>
	public L_Dna dna
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: jbclass.c (243, 22)
///  Org: [l_int32 n]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int n
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_JbFindTemplatesState{
		public IntPtr classer;
		public int w;
		public int h;
		public int i;
		public IntPtr dna;
		public int n;}
	}

#endregion
#region"egio.c"
//  jpegio.c (164, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_callback_data.txt" language="C" title="jpegio.c (164, 8)"/>
/// </example>
public partial class callback_data : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_callback_data Values = new Marshal_callback_data();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public callback_data(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: jpegio.c (165, 15)
///  Org: [jmp_buf jmpbuf]
///  Msh: jmp_buf | 1:ConstantArray |
///  </remarks>
	public char jmpbuf
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: jpegio.c (166, 15)
///  Org: [l_uint8 * comment]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] comment
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_callback_data{
		public char jmpbuf;
		public IntPtr comment;}
	}

#endregion
#region"ze.c"
//  maze.c (76, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_MazeElement.txt" language="C" title="maze.c (76, 8)"/>
/// </example>
public partial class MazeElement : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_MazeElement Values = new Marshal_MazeElement();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public MazeElement(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: maze.c (77, 16)
///  Org: [l_float32 distance]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single distance
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <remarks>
///  Loc: maze.c (78, 16)
///  Org: [l_int32 x]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: maze.c (79, 16)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: maze.c (80, 16)
///  Org: [l_uint32 val]
///  Msh: l_uint32 | 1:UInt |
///  </remarks>
	public uint val
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: maze.c (81, 16)
///  Org: [l_int32 dir]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int dir
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_MazeElement{
		public Single distance;
		public int x;
		public int y;
		public uint val;
		public int dir;}
	}

#endregion
#region"rtition.c"
//  partition.c (48, 8)
/// <summary>
/// Partition element
/// </summary>
/// <example>
/// <code source="CSource\Struct_PartitionElement.txt" language="C" title="partition.c (48, 8)"/>
/// </example>
public partial class PartitionElement : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PartitionElement Values = new Marshal_PartitionElement();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PartitionElement(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: partition.c (49, 16)
///  Org: [l_float32 size]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <remarks>
///  Loc: partition.c (50, 16)
///  Org: [BOX * box]
///  Msh: BOX * | 2:Struct |  | Typedef: Box = Box
///  </remarks>
	public Box box
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: partition.c (51, 16)
///  Org: [BOXA * boxa]
///  Msh: BOXA * | 2:Struct |  | Typedef: Boxa = Boxa
///  </remarks>
	public Boxa boxa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PartitionElement{
		public Single size;
		public IntPtr box;
		public IntPtr boxa;}
	}

#endregion
#region"x1.c"
//  pix1.c (218, 8)
/// <summary>
/// Pix memory manager
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixMemoryManager.txt" language="C" title="pix1.c (218, 8)"/>
/// </example>
public partial class PixMemoryManager : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixMemoryManager Values = new Marshal_PixMemoryManager();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixMemoryManager(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: pix1.c (220, 17)
///  Org: [alloc_fn allocator]
///  Msh: alloc_fn | 1:Pointer |
///  </remarks>
	public IntPtr allocator
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

///  <remarks>
///  Loc: pix1.c (221, 17)
///  Org: [dealloc_fn deallocator]
///  Msh: dealloc_fn | 1:Pointer |
///  </remarks>
	public IntPtr deallocator
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return IntPtr.Zero;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return IntPtr.Zero;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixMemoryManager{
		public IntPtr allocator;
		public IntPtr deallocator;}
	}

#endregion
#region"xalloc.c"
//  pixalloc.c (113, 8)
/// <summary>
/// Pix memory storage
/// </summary>
/// <example>
/// <code source="CSource\Struct_PixMemoryStore.txt" language="C" title="pixalloc.c (113, 8)"/>
/// </example>
public partial class PixMemoryStore : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_PixMemoryStore Values = new Marshal_PixMemoryStore();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public PixMemoryStore(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  Holds ptrs to allocated memory
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (115, 22)
///  Org: [struct L_Ptraa * paa]
///  Msh: struct L_Ptraa * | 2:Struct |  | Typedef: L_Ptraa = L_Ptraa
///  </remarks>
	public L_Ptraa paa
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  Pix smaller than this (in bytes)
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (116, 22)
///  Org: [size_t minsize]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint minsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  Smallest mem (in bytes) alloc'd
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (118, 22)
///  Org: [size_t smallest]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint smallest
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  Larest mem (in bytes) alloc'd
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (119, 22)
///  Org: [size_t largest]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint largest
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  Size of allocated block w/ all chunks
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (120, 22)
///  Org: [size_t nbytes]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint nbytes
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  Num of power-of-2 sizes pre-alloc'd
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (121, 22)
///  Org: [l_int32 nlevels]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int nlevels
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  Mem sizes at each power-of-2 level
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (122, 22)
///  Org: [size_t * sizes]
///  Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
///  </remarks>
	public Byte[] sizes
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  Number of mem alloc'd at each size
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (123, 22)
///  Org: [l_int32 * allocarray]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] allocarray
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  ptr to allocated array
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (124, 22)
///  Org: [l_uint32 * baseptr]
///  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
///  </remarks>
	public Byte[] baseptr
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  ptr just beyond allocated memory
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (125, 22)
///  Org: [l_uint32 * maxptr]
///  Msh: l_uint32 * | 2:UInt |  ... UInt = 4 Byte * Len)
///  </remarks>
	public Byte[] maxptr
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  array of ptrs to first chunk in size
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (126, 22)
///  Org: [l_uint32 ** firstptr]
///  Msh: l_uint32 ** | 3:UInt | List <byte[]> ... UInt nicht Marshalbar. Verwende 4 Bytes
///  </remarks>
	public List<Byte[]> firstptr
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  log: total # of pix used (by level)
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (127, 22)
///  Org: [l_int32 * memused]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] memused
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  log: # of pix in use (by level)
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (128, 22)
///  Org: [l_int32 * meminuse]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] meminuse
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  log: max # of pix in use (by level)
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (129, 22)
///  Org: [l_int32 * memmax]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] memmax
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  log: # of pix alloc'd because
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (130, 22)
///  Org: [l_int32 * memempty]
///  Msh: l_int32 * | 2:Int | int[] -  - int[]
///  </remarks>
	public int[] memempty
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  log: set to null if no logging
///  </summary>
///  <remarks>
///  Loc: pixalloc.c (132, 22)
///  Org: [char * logfile]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String logfile
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_PixMemoryStore{
		public IntPtr paa;
		public uint minsize;
		public uint smallest;
		public uint largest;
		public uint nbytes;
		public int nlevels;
		public IntPtr sizes;
		public IntPtr allocarray;
		public IntPtr baseptr;
		public IntPtr maxptr;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=4)]
		public IntPtr firstptr;
		public IntPtr memused;
		public IntPtr meminuse;
		public IntPtr memmax;
		public IntPtr memempty;
		public IntPtr logfile;}
	}

#endregion
#region"gio.c"
//  pngio.c (1293, 8)
/// <summary>
/// A node in a linked list of memory buffers that hold I/O content
/// </summary>
/// <example>
/// <code source="CSource\Struct_MemIOData.txt" language="C" title="pngio.c (1293, 8)"/>
/// </example>
public partial class MemIOData : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_MemIOData Values = new Marshal_MemIOData();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public MemIOData(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  pointer to this node's I/O content
///  </summary>
///  <remarks>
///  Loc: pngio.c (1295, 17)
///  Org: [char * m_Buffer]
///  Msh: char * | 2:CharS |
///  </remarks>
	public String m_Buffer
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  number of I/O content bytes read or written
///  </summary>
///  <remarks>
///  Loc: pngio.c (1296, 17)
///  Org: [l_int32 m_Count]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int m_Count
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  allocated size of m_buffer
///  </summary>
///  <remarks>
///  Loc: pngio.c (1297, 17)
///  Org: [l_int32 m_Size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int m_Size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  pointer to the next node in the list
///  </summary>
///  <remarks>
///  Loc: pngio.c (1298, 24)
///  Org: [struct MemIOData * m_Next]
///  Msh: struct MemIOData * | 2:Struct |
///  </remarks>
	public MemIOData m_Next
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <summary>
///  pointer to the last node in the linked
///  </summary>
///  <remarks>
///  Loc: pngio.c (1300, 24)
///  Org: [struct MemIOData * m_Last]
///  Msh: struct MemIOData * | 2:Struct |
///  </remarks>
	public MemIOData m_Last
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_MemIOData{
		public IntPtr m_Buffer;
		public int m_Count;
		public int m_Size;
		public IntPtr m_Next;
		public IntPtr m_Last;}
	}

#endregion
#region"edfill.c"
//  seedfill.c (170, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Pixel.txt" language="C" title="seedfill.c (170, 8)"/>
/// </example>
public partial class L_Pixel : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Pixel Values = new Marshal_L_Pixel();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Pixel(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: seedfill.c (172, 16)
///  Org: [l_int32 x]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: seedfill.c (173, 16)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Pixel{
		public int x;
		public int y;}
	}

#endregion
#region"l1.c"
//  sel1.c (152, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_CompParameterMap.txt" language="C" title="sel1.c (152, 8)"/>
/// </example>
public partial class CompParameterMap : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_CompParameterMap Values = new Marshal_CompParameterMap();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public CompParameterMap(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: sel1.c (154, 14)
///  Org: [l_int32 size]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int size
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: sel1.c (155, 14)
///  Org: [l_int32 size1]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int size1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: sel1.c (156, 14)
///  Org: [l_int32 size2]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int size2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: sel1.c (157, 14)
///  Org: [char [20] selnameh1]
///  Msh: char [20] | 1:ConstantArray |
///  </remarks>
	public char selnameh1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: sel1.c (158, 14)
///  Org: [char [20] selnameh2]
///  Msh: char [20] | 1:ConstantArray |
///  </remarks>
	public char selnameh2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: sel1.c (159, 14)
///  Org: [char [20] selnamev1]
///  Msh: char [20] | 1:ConstantArray |
///  </remarks>
	public char selnamev1
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: sel1.c (160, 14)
///  Org: [char [20] selnamev2]
///  Msh: char [20] | 1:ConstantArray |
///  </remarks>
	public char selnamev2
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_CompParameterMap{
		public int size;
		public int size1;
		public int size2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public char selnameh1;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public char selnameh2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public char selnamev1;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public char selnamev2;}
	}

#endregion
#region"ringcode.c"
//  stringcode.c (95, 8)
/// <summary>
/// Associations between names and functions
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_GenAssoc.txt" language="C" title="stringcode.c (95, 8)"/>
/// </example>
public partial class L_GenAssoc : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_GenAssoc Values = new Marshal_L_GenAssoc();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_GenAssoc(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: stringcode.c (97, 14)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: stringcode.c (98, 14)
///  Org: [char [16] type]
///  Msh: char [16] | 1:ConstantArray |
///  </remarks>
	public char type
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: stringcode.c (99, 14)
///  Org: [char [16] structname]
///  Msh: char [16] | 1:ConstantArray |
///  </remarks>
	public char structname
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: stringcode.c (100, 14)
///  Org: [char [16] reader]
///  Msh: char [16] | 1:ConstantArray |
///  </remarks>
	public char reader
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: stringcode.c (101, 14)
///  Org: [char [20] memreader]
///  Msh: char [20] | 1:ConstantArray |
///  </remarks>
	public char memreader
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_GenAssoc{
		public int index;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=16)]
		public char type;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=16)]
		public char structname;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=16)]
		public char reader;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=20)]
		public char memreader;}
	}

#endregion
#region"ffio.c"
//  tiffio.c (155, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_tiff_transform.txt" language="C" title="tiffio.c (155, 8)"/>
/// </example>
public partial class tiff_transform : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_tiff_transform Values = new Marshal_tiff_transform();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public tiff_transform(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: tiffio.c (156, 9)
///  Org: [int vflip]
///  Msh: int | 1:Int |
///  </remarks>
	public int vflip
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (157, 9)
///  Org: [int hflip]
///  Msh: int | 1:Int |
///  </remarks>
	public int hflip
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (158, 9)
///  Org: [int rotate]
///  Msh: int | 1:Int |
///  </remarks>
	public int rotate
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_tiff_transform{
		public int vflip;
		public int hflip;
		public int rotate;}
	}

//  tiffio.c (2174, 8)
/// <summary>
/// Memory stream buffer used with TIFFClientOpen()
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_Memstream.txt" language="C" title="tiffio.c (2174, 8)"/>
/// </example>
public partial class L_Memstream : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_Memstream Values = new Marshal_L_Memstream();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_Memstream(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: tiffio.c (2176, 16)
///  Org: [l_uint8 * buffer]
///  Msh: l_uint8 * | 2:UChar | ([1 Byte, VB-Unsupported])
///  </remarks>
	public Byte[] buffer
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (2178, 16)
///  Org: [size_t bufsize]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint bufsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (2180, 16)
///  Org: [size_t offset]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint offset
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (2181, 16)
///  Org: [size_t hw]
///  Msh: size_t | 1:UInt |
///  </remarks>
	public uint hw
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (2182, 16)
///  Org: [l_uint8 ** poutdata]
///  Msh: l_uint8 ** | 3:UChar | Byte[] ... Pointer auf ein Byte-Array
///  </remarks>
	public List<byte[]> poutdata
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

///  <remarks>
///  Loc: tiffio.c (2183, 16)
///  Org: [size_t * poutsize]
///  Msh: size_t * | 2:UInt |  ... UInt = 4 Byte * Len)
///  </remarks>
	public Byte[] poutsize
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return null;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return null;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_Memstream{
		public IntPtr buffer;
		public uint bufsize;
		public uint offset;
		public uint hw;
		public IntPtr poutdata;
		public IntPtr poutsize;}
	}

#endregion
#region"tershed.c"
//  watershed.c (124, 8)
/// <summary>
/// New pixel coordinates
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_NewPixel.txt" language="C" title="watershed.c (124, 8)"/>
/// </example>
public partial class L_NewPixel : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_NewPixel Values = new Marshal_L_NewPixel();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_NewPixel(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  x coordinate
///  </summary>
///  <remarks>
///  Loc: watershed.c (126, 16)
///  Org: [l_int32 x]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  y coordinate
///  </summary>
///  <remarks>
///  Loc: watershed.c (127, 16)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_NewPixel{
		public int x;
		public int y;}
	}

//  watershed.c (132, 8)
/// <summary>
/// Wartshed pixel
/// </summary>
/// <example>
/// <code source="CSource\Struct_L_WSPixel.txt" language="C" title="watershed.c (132, 8)"/>
/// </example>
public partial class L_WSPixel : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_L_WSPixel Values = new Marshal_L_WSPixel();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public L_WSPixel(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <summary>
///  pixel value
///  </summary>
///  <remarks>
///  Loc: watershed.c (134, 16)
///  Org: [l_float32 val]
///  Msh: l_float32 | 1:Float |
///  </remarks>
	public Single val
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0f;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0f;
	       }
	}

///  <summary>
///  x coordinate
///  </summary>
///  <remarks>
///  Loc: watershed.c (135, 16)
///  Org: [l_int32 x]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int x
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  y coordinate
///  </summary>
///  <remarks>
///  Loc: watershed.c (136, 16)
///  Org: [l_int32 y]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int y
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

///  <summary>
///  label for set to which pixel belongs
///  </summary>
///  <remarks>
///  Loc: watershed.c (137, 16)
///  Org: [l_int32 index]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int index
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_L_WSPixel{
		public Single val;
		public int x;
		public int y;
		public int index;}
	}

#endregion
#region"itefile.c"
//  writefile.c (139, 8)
/// <summary>
/// 
/// </summary>
/// <example>
/// <code source="CSource\Struct_ExtensionMap.txt" language="C" title="writefile.c (139, 8)"/>
/// </example>
public partial class ExtensionMap : IDisposable {
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] public IntPtr Pointer;
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Marshal_ExtensionMap Values = new Marshal_ExtensionMap();
   [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Dictionary <String, Object> Caching  = new Dictionary<String, Object>();

	public void Dispose() { throw new NotImplementedException(); }
	
	public ExtensionMap(IntPtr PTR){
	  if (PTR != IntPtr.Zero) {Pointer = PTR;}
	  Pointer = PTR; Marshal.PtrToStructure(Pointer, Values);
	}
///  <remarks>
///  Loc: writefile.c (141, 14)
///  Org: [char [8] extension]
///  Msh: char [8] | 1:ConstantArray |
///  </remarks>
	public char extension
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return ' ';}
	           Marshal.PtrToStructure(Pointer, Values);
	           return ' ';
	       }
	}

///  <remarks>
///  Loc: writefile.c (142, 14)
///  Org: [l_int32 format]
///  Msh: l_int32 | 1:Int |
///  </remarks>
	public int format
	{
	   get {
	           if (Pointer == IntPtr.Zero) {return 0;}
	           Marshal.PtrToStructure(Pointer, Values);
	           return 0;
	       }
	}

	[StructLayout(LayoutKind.Sequential)]
	private class Marshal_ExtensionMap{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=8)]
		public char extension;
		public int format;}
	}

#endregion
