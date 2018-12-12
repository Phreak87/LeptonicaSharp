Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' pixalloc.c (168, 1)
' pmsCreate(minsize, smallest, numalloc, logfile) as Integer
' pmsCreate(size_t, size_t, NUMA *, const char *) as l_ok
'''  <summary>
''' (1) This computes the size of the block of memory required
'''and allocates it.  Each chunk starts on a 32-bit word boundary.
'''The chunk sizes are in powers of 2, starting at %smallest,
'''and the number of levels and chunks at each level is
'''specified by %numalloc.<para/>
'''
'''(2) This is intended to manage the image data for a small number
'''of relatively large pix.  The system malloc is expected to
'''handle very large numbers of small chunks efficiently.<para/>
'''
'''(3) Important: set the allocators and call this function
'''before any pix have been allocated.  Destroy all the pix
'''in the normal way before calling pmsDestroy().<para/>
'''
'''(4) The pms struct is stored in a static global, so this function
'''is not thread-safe.  When used, there must be only one thread
'''per process.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCreate/*"/>
'''  <param name="minsize">[in] - of data chunk that can be supplied by pms</param>
'''  <param name="smallest">[in] - bytes of the smallest pre-allocated data chunk.</param>
'''  <param name="numalloc">[in] - array with the number of data chunks for each size that are in the memory store</param>
'''  <param name="logfile">[in] - use for debugging null otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pmsCreate(
				ByVal minsize as UInteger, 
				ByVal smallest as UInteger, 
				ByVal numalloc as Numa, 
				ByVal logfile as String) as Integer


if IsNothing (numalloc) then Throw New ArgumentNullException  ("numalloc cannot be Nothing")
		if IsNothing (logfile) then Throw New ArgumentNullException  ("logfile cannot be Nothing")
	Dim _Result as Integer = Natives.pmsCreate(  minsize,   smallest, numalloc.Pointer,   logfile)
	
	return _Result
End Function

' pixalloc.c (267, 1)
' pmsDestroy() as Object
' pmsDestroy() as void
'''  <summary>
''' (1) Important: call this function at the end of the program, after
'''the last pix has been destroyed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsDestroy/*"/>
Public Shared Sub pmsDestroy()


	Natives.pmsDestroy()
	
End Sub

' pixalloc.c (311, 1)
' pmsCustomAlloc(nbytes) as Object
' pmsCustomAlloc(size_t) as void *
'''  <summary>
''' (1) This attempts to find a suitable pre-allocated chunk.
'''If not found, it dynamically allocates the chunk.<para/>
'''
'''(2) If logging is turned on, the allocations that are not taken
'''from the memory store, and are at least as large as the
'''minimum size the store can handle, are logged to file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCustomAlloc/*"/>
'''  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
'''   <returns>data ptr to chunk</returns>
Public Shared Function pmsCustomAlloc(
				ByVal nbytes as UInteger) as Object


	Dim _Result as IntPtr = Natives.pmsCustomAlloc(  nbytes)
	
	Dim B(1) As Byte
	Marshal.Copy(_Result, B, 0, B.Length)
	return B
End Function

' pixalloc.c (355, 1)
' pmsCustomDealloc(data) as Object
' pmsCustomDealloc(void *) as void
'''  <summary>
''' pmsCustomDealloc()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCustomDealloc/*"/>
'''  <param name="data">[in] - to be freed or returned to the storage</param>
Public Shared Sub pmsCustomDealloc(
				ByVal data as Object)


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
		Dim dataPtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (data) Is IntPtr Then dataPtr = data
	If TypeOf (data) Is Byte() Then
	   Dim cdata = CType(data, Byte())
	   dataPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, dataPtr, cdata.Length)
	End If
	If Not IsNothing(data.GetType.GetProperty("data")) Then
	  Dim cdata = CType(data.data, Byte())
	  dataPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, dataPtr, cdata.Length)
	End If

	Natives.pmsCustomDealloc(  dataPtr)
	
	Marshal.FreeHGlobal(dataPtr)
End Sub

' pixalloc.c (406, 1)
' pmsGetAlloc(nbytes) as Object
' pmsGetAlloc(size_t) as void *
'''  <summary>
''' (1) This is called when a request for pix data cannot be
'''obtained from the preallocated memory store.  After use it
'''is freed like normal memory.<para/>
'''
'''(2) If logging is on, only write out allocs that are as large as
'''the minimum size handled by the memory store.<para/>
'''
'''(3) size_t is %lu on 64 bit platforms and %u on 32 bit platforms.
'''The C99 platform-independent format specifier for size_t is %zu,
'''but windows hasn't conformed, so we are forced to go back to
'''C89, use %lu, and cast to get platform-independence.  Ugh.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetAlloc/*"/>
'''  <param name="nbytes">[in] - </param>
'''   <returns>data</returns>
Public Shared Function pmsGetAlloc(
				ByVal nbytes as UInteger) as Object


	Dim _Result as IntPtr = Natives.pmsGetAlloc(  nbytes)
	
	Dim B(1) As Byte
	Marshal.Copy(_Result, B, 0, B.Length)
	return B
End Function

' pixalloc.c (437, 1)
' pmsGetLevelForAlloc(nbytes, plevel) as Integer
' pmsGetLevelForAlloc(size_t, l_int32 *) as l_ok
'''  <summary>
''' pmsGetLevelForAlloc()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetLevelForAlloc/*"/>
'''  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
'''  <param name="plevel">[out] - -1 if either too small or too large</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pmsGetLevelForAlloc(
				ByVal nbytes as UInteger, 
				<Out()>  ByRef plevel as Integer) as Integer


	Dim _Result as Integer = Natives.pmsGetLevelForAlloc(  nbytes,   plevel)
	
	return _Result
End Function

' pixalloc.c (476, 1)
' pmsGetLevelForDealloc(data, plevel) as Integer
' pmsGetLevelForDealloc(void *, l_int32 *) as l_ok
'''  <summary>
''' pmsGetLevelForDealloc()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetLevelForDealloc/*"/>
'''  <param name="data">[in] - ptr to memory chunk</param>
'''  <param name="plevel">[out] - level in memory store -1 if allocated outside the store</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pmsGetLevelForDealloc(
				ByVal data as Object, 
				<Out()>  ByRef plevel as Integer) as Integer


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
		Dim dataPtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (data) Is IntPtr Then dataPtr = data
	If TypeOf (data) Is Byte() Then
	   Dim cdata = CType(data, Byte())
	   dataPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, dataPtr, cdata.Length)
	End If
	If Not IsNothing(data.GetType.GetProperty("data")) Then
	  Dim cdata = CType(data.data, Byte())
	  dataPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, dataPtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.pmsGetLevelForDealloc(  dataPtr,   plevel)
	
	Marshal.FreeHGlobal(dataPtr)
	return _Result
End Function

' pixalloc.c (511, 1)
' pmsLogInfo() as Object
' pmsLogInfo() as void
'''  <summary>
''' pmsLogInfo()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsLogInfo/*"/>
Public Shared Sub pmsLogInfo()


	Natives.pmsLogInfo()
	
End Sub

End Class


