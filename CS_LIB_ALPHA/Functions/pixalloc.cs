using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// pixalloc.c (168, 1)
// pmsCreate(minsize, smallest, numalloc, logfile) as int
// pmsCreate(size_t, size_t, NUMA *, const char *) as l_ok
///  <summary>
/// (1) This computes the size of the block of memory required
/// and allocates it.  Each chunk starts on a 32-bit word boundary.
/// The chunk sizes are in powers of 2, starting at %smallest,
/// and the number of levels and chunks at each level is
/// specified by %numalloc.<para/>
/// 
/// (2) This is intended to manage the image data for a small number
/// of relatively large pix.  The system malloc is expected to
/// handle very large numbers of small chunks efficiently.<para/>
/// 
/// (3) Important: set the allocators and call this function
/// before any pix have been allocated.  Destroy all the pix
/// in the normal way before calling pmsDestroy().<para/>
/// 
/// (4) The pms struct is stored in a static global, so this function
/// is not thread-safe.  When used, there must be only one thread
/// per process.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCreate/*"/>
///  <param name="minsize">[in] - of data chunk that can be supplied by pms</param>
///  <param name="smallest">[in] - bytes of the smallest pre-allocated data chunk.</param>
///  <param name="numalloc">[in] - array with the number of data chunks for each size that are in the memory store</param>
///  <param name="logfile">[in] - use for debugging null otherwise</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pmsCreate(
				 uint minsize, 
				 uint smallest, 
				 Numa numalloc, 
				 String logfile){

	int _Result = Natives.pmsCreate(  minsize,   smallest, numalloc.Pointer,   logfile);
	
	return _Result;
}

// pixalloc.c (267, 1)
// pmsDestroy() as Object
// pmsDestroy() as void
///  <summary>
/// (1) Important: call this function at the end of the program, after
/// the last pix has been destroyed.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsDestroy/*"/>
public static void pmsDestroy(){

	Natives.pmsDestroy();
	
}

// pixalloc.c (311, 1)
// pmsCustomAlloc(nbytes) as Object
// pmsCustomAlloc(size_t) as void *
///  <summary>
/// (1) This attempts to find a suitable pre-allocated chunk.
/// If not found, it dynamically allocates the chunk.<para/>
/// 
/// (2) If logging is turned on, the allocations that are not taken
/// from the memory store, and are at least as large as the
/// minimum size the store can handle, are logged to file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCustomAlloc/*"/>
///  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
///   <returns>data ptr to chunk</returns>
public static Object pmsCustomAlloc(
				 uint nbytes){

	IntPtr _Result = Natives.pmsCustomAlloc(  nbytes);
	
	Byte[] B = new Byte[1];
	Marshal.Copy(_Result, B, 0, B.Length);
	return B;
}

// pixalloc.c (355, 1)
// pmsCustomDealloc(data) as Object
// pmsCustomDealloc(void *) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsCustomDealloc/*"/>
///  <param name="data">[in] - to be freed or returned to the storage</param>
public static void pmsCustomDealloc(
				 Object data){

		IntPtr dataPtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.pmsCustomDealloc(  dataPtr);
	
	Marshal.FreeHGlobal(dataPtr);
}

// pixalloc.c (406, 1)
// pmsGetAlloc(nbytes) as Object
// pmsGetAlloc(size_t) as void *
///  <summary>
/// (1) This is called when a request for pix data cannot be
/// obtained from the preallocated memory store.  After use it
/// is freed like normal memory.<para/>
/// 
/// (2) If logging is on, only write out allocs that are as large as
/// the minimum size handled by the memory store.<para/>
/// 
/// (3) size_t is %lu on 64 bit platforms and %u on 32 bit platforms.
/// The C99 platform-independent format specifier for size_t is %zu,
/// but windows hasn't conformed, so we are forced to go back to
/// C89, use %lu, and cast to get platform-independence.  Ugh.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetAlloc/*"/>
///  <param name="nbytes">[in] - </param>
///   <returns>data</returns>
public static Object pmsGetAlloc(
				 uint nbytes){

	IntPtr _Result = Natives.pmsGetAlloc(  nbytes);
	
	Byte[] B = new Byte[1];
	Marshal.Copy(_Result, B, 0, B.Length);
	return B;
}

// pixalloc.c (437, 1)
// pmsGetLevelForAlloc(nbytes, plevel) as int
// pmsGetLevelForAlloc(size_t, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetLevelForAlloc/*"/>
///  <param name="nbytes">[in] - min number of bytes in the chunk to be retrieved</param>
///  <param name="plevel">[out] - -1 if either too small or too large</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pmsGetLevelForAlloc(
				 uint nbytes, 
				out int plevel){

	int _Result = Natives.pmsGetLevelForAlloc(  nbytes, out  plevel);
	
	return _Result;
}

// pixalloc.c (476, 1)
// pmsGetLevelForDealloc(data, plevel) as int
// pmsGetLevelForDealloc(void *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsGetLevelForDealloc/*"/>
///  <param name="data">[in] - ptr to memory chunk</param>
///  <param name="plevel">[out] - level in memory store -1 if allocated outside the store</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pmsGetLevelForDealloc(
				 Object data, 
				out int plevel){

		IntPtr dataPtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.pmsGetLevelForDealloc(  dataPtr, out  plevel);
	
	Marshal.FreeHGlobal(dataPtr);
	return _Result;
}

// pixalloc.c (511, 1)
// pmsLogInfo() as Object
// pmsLogInfo() as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pmsLogInfo/*"/>
public static void pmsLogInfo(){

	Natives.pmsLogInfo();
	
}


}
}
