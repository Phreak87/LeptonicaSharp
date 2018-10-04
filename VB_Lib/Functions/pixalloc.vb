Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixalloc.c (168, 1)
' pmsCreate(minsize, smallest, numalloc, logfile) as Integer
' pmsCreate(size_t, size_t, NUMA *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This computes the size of the block of memory required<para/>
''' and allocates it.  Each chunk starts on a 32-bit word boundary.<para/>
''' The chunk sizes are in powers of 2, starting at %smallest,<para/>
''' and the number of levels and chunks at each level is<para/>
''' specified by %numalloc.<para/>
''' (2) This is intended to manage the image data for a small number<para/>
''' of relatively large pix.  The system malloc is expected to<para/>
''' handle very large numbers of small chunks efficiently.<para/>
''' (3) Important: set the allocators and call this function<para/>
''' before any pix have been allocated.  Destroy all the pix<para/>
''' in the normal way before calling pmsDestroy().<para/>
''' (4) The pms struct is stored in a static global, so this function<para/>
''' is not thread-safe.  When used, there must be only one thread<para/>
''' per process.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (numalloc) then Throw New ArgumentNullException  ("numalloc cannot be Nothing")
	If IsNothing (logfile) then Throw New ArgumentNullException  ("logfile cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pmsCreate( minsize, smallest, numalloc.Pointer, logfile)

	Return _Result
End Function

' SRC\pixalloc.c (267, 1)
' pmsDestroy() as Object
' pmsDestroy() as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Important: call this function at the end of the program, after<para/>
''' the last pix has been destroyed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub pmsDestroy()



	LeptonicaSharp.Natives.pmsDestroy( )

End Sub

' SRC\pixalloc.c (311, 1)
' pmsCustomAlloc(nbytes) as Object
' pmsCustomAlloc(size_t) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This attempts to find a suitable pre-allocated chunk.<para/>
''' If not found, it dynamically allocates the chunk.<para/>
''' (2) If logging is turned on, the allocations that are not taken<para/>
''' from the memory store, and are at least as large as the<para/>
''' minimum size the store can handle, are logged to file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
'''   <returns>data ptr to chunk</returns>
Public Shared Function pmsCustomAlloc(
				 ByVal nbytes as UInteger) as Object



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pmsCustomAlloc( nbytes)

	Return _Result
End Function

' SRC\pixalloc.c (355, 1)
' pmsCustomDealloc(data) as Object
' pmsCustomDealloc(void *) as void
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - to be freed or returned to the storage</param>
Public Shared Sub pmsCustomDealloc(
				 ByVal data as Object)

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	LeptonicaSharp.Natives.pmsCustomDealloc( dataPTR)

End Sub

' SRC\pixalloc.c (406, 1)
' pmsGetAlloc(nbytes) as Object
' pmsGetAlloc(size_t) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is called when a request for pix data cannot be<para/>
''' obtained from the preallocated memory store.  After use it<para/>
''' is freed like normal memory.<para/>
''' (2) If logging is on, only write out allocs that are as large as<para/>
''' the minimum size handled by the memory store.<para/>
''' (3) size_t is %lu on 64 bit platforms and %u on 32 bit platforms.<para/>
''' The C99 platform-independent format specifier for size_t is %zu,<para/>
''' but windows hasn't conformed, so we are forced to go back to<para/>
''' C89, use %lu, and cast to get platform-independence.  Ugh.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nbytes">[in] - </param>
'''   <returns>data</returns>
Public Shared Function pmsGetAlloc(
				 ByVal nbytes as UInteger) as Object



	Dim _Result as IntPtr = LeptonicaSharp.Natives.pmsGetAlloc( nbytes)

	Return _Result
End Function

' SRC\pixalloc.c (437, 1)
' pmsGetLevelForAlloc(nbytes, plevel) as Integer
' pmsGetLevelForAlloc(size_t, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
'''  <param name="plevel">[out] - -1 if either too small or too large</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pmsGetLevelForAlloc(
				 ByVal nbytes as UInteger, 
				<Out()> ByRef plevel as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.pmsGetLevelForAlloc( nbytes, plevel)

	Return _Result
End Function

' SRC\pixalloc.c (476, 1)
' pmsGetLevelForDealloc(data, plevel) as Integer
' pmsGetLevelForDealloc(void *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - ptr to memory chunk</param>
'''  <param name="plevel">[out] - level in memory store -1 if allocated outside the store</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pmsGetLevelForDealloc(
				 ByVal data as Object, 
				<Out()> ByRef plevel as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.pmsGetLevelForDealloc( dataPTR, plevel)

	Return _Result
End Function

' SRC\pixalloc.c (511, 1)
' pmsLogInfo() as Object
' pmsLogInfo() as void
'''  <remarks>
'''  </remarks>
Public Shared Sub pmsLogInfo()



	LeptonicaSharp.Natives.pmsLogInfo( )

End Sub

End Class
