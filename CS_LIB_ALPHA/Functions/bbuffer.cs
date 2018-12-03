using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// bbuffer.c (124, 1)
// bbufferCreate(indata, nalloc) as L_ByteBuffer
// bbufferCreate(const l_uint8 *, l_int32) as L_BBUFFER *
///  <summary>
/// (1) If a buffer address is given, you should read all the data in.<para/>
/// 
/// (2) Allocates a bbuffer with associated byte array of
/// the given size.  If a buffer address is given,
/// it then reads the number of bytes into the byte array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferCreate/*"/>
///  <param name="indata">[in] - address in memory [optional]</param>
///  <param name="nalloc">[in] - size of byte array to be alloc'd 0 for default</param>
///   <returns>bbuffer, or NULL on error</returns>
public static L_ByteBuffer bbufferCreate(
				 Byte[] indata, 
				 int nalloc){

	IntPtr _Result = Natives.bbufferCreate(  indata,   nalloc);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_ByteBuffer(_Result);
}

// bbuffer.c (167, 1)
// bbufferDestroy(pbb) as Object
// bbufferDestroy(L_BBUFFER **) as void
///  <summary>
/// (1) Destroys the byte array in the bbuffer and then the bbuffer
/// then nulls the contents of the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferDestroy/*"/>
///  <param name="pbb">[in,out] - buffer to be nulled</param>
public static void bbufferDestroy(
				ref L_ByteBuffer pbb){

	IntPtr pbbPtr = IntPtr.Zero; 	if (pbb != null) {pbbPtr = pbb.Pointer;}

	Natives.bbufferDestroy(ref pbbPtr);
	

	if (pbbPtr == IntPtr.Zero) {pbb = null;} else { pbb = new L_ByteBuffer(pbbPtr); };


}

// bbuffer.c (203, 1)
// bbufferDestroyAndSaveData(pbb, pnbytes) as Byte[]
// bbufferDestroyAndSaveData(L_BBUFFER **, size_t *) as l_uint8 *
///  <summary>
/// (1) Copies data to newly allocated array then destroys the bbuffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferDestroyAndSaveData/*"/>
///  <param name="pbb">[in,out] - buffer to be nulled</param>
///  <param name="pnbytes">[out] - number of bytes saved in array</param>
///   <returns>barray newly allocated array of data</returns>
public static Byte[] bbufferDestroyAndSaveData(
				ref L_ByteBuffer pbb, 
				out uint pnbytes){

	IntPtr pbbPtr = IntPtr.Zero; 	if (pbb != null) {pbbPtr = pbb.Pointer;}

	Byte[] _Result = Natives.bbufferDestroyAndSaveData(ref pbbPtr, out  pnbytes);
	

	if (pbbPtr == IntPtr.Zero) {pbb = null;} else { pbb = new L_ByteBuffer(pbbPtr); };


	return _Result;
}

// bbuffer.c (262, 1)
// bbufferRead(bb, src, nbytes) as int
// bbufferRead(L_BBUFFER *, l_uint8 *, l_int32) as l_ok
///  <summary>
/// (1) For a read after write, first remove the written
/// bytes by shifting the unwritten bytes in the array,
/// then check if there is enough room to add the new bytes.
/// If not, realloc with bbufferExpandArray(), resulting
/// in a second writing of the unwritten bytes.  While less
/// efficient, this is simpler than making a special case
/// of reallocNew().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferRead/*"/>
///  <param name="bb">[in] - bbuffer</param>
///  <param name="src">[in] - source memory buffer from which bytes are read</param>
///  <param name="nbytes">[in] - bytes to be read</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bbufferRead(
				 L_ByteBuffer bb, 
				 Byte[] src, 
				 int nbytes){

	int _Result = Natives.bbufferRead(bb.Pointer,   src,   nbytes);
	



	return _Result;
}

// bbuffer.c (308, 1)
// bbufferReadStream(bb, fp, nbytes) as int
// bbufferReadStream(L_BBUFFER *, FILE *, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferReadStream/*"/>
///  <param name="bb">[in] - bbuffer</param>
///  <param name="fp">[in] - source stream from which bytes are read</param>
///  <param name="nbytes">[in] - bytes to be read</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bbufferReadStream(
				 L_ByteBuffer bb, 
				 FILE fp, 
				 int nbytes){

	int _Result = Natives.bbufferReadStream(bb.Pointer, fp.Pointer,   nbytes);
	



	return _Result;
}

// bbuffer.c (359, 1)
// bbufferExtendArray(bb, nbytes) as int
// bbufferExtendArray(L_BBUFFER *, l_int32) as l_ok
///  <summary>
/// (1) reallocNew() copies all bbtonalloc bytes, even though
/// only bbton are data.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferExtendArray/*"/>
///  <param name="bb">[in] - bbuffer</param>
///  <param name="nbytes">[in] - number of bytes to extend array size</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bbufferExtendArray(
				 L_ByteBuffer bb, 
				 int nbytes){

	int _Result = Natives.bbufferExtendArray(bb.Pointer,   nbytes);
	



	return _Result;
}

// bbuffer.c (390, 1)
// bbufferWrite(bb, dest, nbytes, pnout) as int
// bbufferWrite(L_BBUFFER *, l_uint8 *, size_t, size_t *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferWrite/*"/>
///  <param name="bb">[in] - bbuffer</param>
///  <param name="dest">[in] - dest memory buffer to which bytes are written</param>
///  <param name="nbytes">[in] - bytes requested to be written</param>
///  <param name="pnout">[out] - bytes actually written</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bbufferWrite(
				 L_ByteBuffer bb, 
				 Byte[] dest, 
				 uint nbytes, 
				out uint pnout){

	int _Result = Natives.bbufferWrite(bb.Pointer,   dest,   nbytes, out  pnout);
	



	return _Result;
}

// bbuffer.c (442, 1)
// bbufferWriteStream(bb, fp, nbytes, pnout) as int
// bbufferWriteStream(L_BBUFFER *, FILE *, size_t, size_t *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bbufferWriteStream/*"/>
///  <param name="bb">[in] - bbuffer</param>
///  <param name="fp">[in] - dest stream to which bytes are written</param>
///  <param name="nbytes">[in] - bytes requested to be written</param>
///  <param name="pnout">[out] - bytes actually written</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bbufferWriteStream(
				 L_ByteBuffer bb, 
				 FILE fp, 
				 uint nbytes, 
				out uint pnout){

	int _Result = Natives.bbufferWriteStream(bb.Pointer, fp.Pointer,   nbytes, out  pnout);
	



	return _Result;
}


}
}
