using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// arrayaccess.c (74, 1)
// l_getDataBit(line, n) as int
// l_getDataBit(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataBit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>val of the nth 1-bit pixel.</returns>
public static int l_getDataBit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataBit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (91, 1)
// l_setDataBit(line, n) as Object
// l_setDataBit(void *, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataBit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
public static void l_setDataBit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataBit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (108, 1)
// l_clearDataBit(line, n) as Object
// l_clearDataBit(void *, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataBit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
public static void l_clearDataBit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_clearDataBit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (134, 1)
// l_setDataBitVal(line, n, val) as Object
// l_setDataBitVal(void *, l_int32, l_int32) as void
///  <summary>
/// (1) This is an accessor for a 1 bpp pix.<para/>
/// 
/// (2) It is actually a little slower than using:
/// if (val == 0)
/// l_ClearDataBit(line, n)
/// else
/// l_SetDataBit(line, n)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataBitVal/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 or 1</param>
public static void l_setDataBitVal(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataBitVal(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (155, 1)
// l_getDataDibit(line, n) as int
// l_getDataDibit(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataDibit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>val of the nth 2-bit pixel.</returns>
public static int l_getDataDibit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataDibit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (171, 1)
// l_setDataDibit(line, n, val) as Object
// l_setDataDibit(void *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataDibit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 - 3</param>
public static void l_setDataDibit(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataDibit(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (194, 1)
// l_clearDataDibit(line, n) as Object
// l_clearDataDibit(void *, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataDibit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
public static void l_clearDataDibit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_clearDataDibit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (209, 1)
// l_getDataQbit(line, n) as int
// l_getDataQbit(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataQbit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>val of the nth 4-bit pixel.</returns>
public static int l_getDataQbit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataQbit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (225, 1)
// l_setDataQbit(line, n, val) as Object
// l_setDataQbit(void *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataQbit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 - 0xf</param>
public static void l_setDataQbit(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataQbit(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (248, 1)
// l_clearDataQbit(line, n) as Object
// l_clearDataQbit(void *, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataQbit/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
public static void l_clearDataQbit(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_clearDataQbit(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (263, 1)
// l_getDataByte(line, n) as int
// l_getDataByte(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataByte/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>value of the n-th byte pixel</returns>
public static int l_getDataByte(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataByte(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (283, 1)
// l_setDataByte(line, n, val) as Object
// l_setDataByte(void *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataByte/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 - 0xff</param>
public static void l_setDataByte(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataByte(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (303, 1)
// l_getDataTwoBytes(line, n) as int
// l_getDataTwoBytes(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataTwoBytes/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>value of the n-th 2-byte pixel</returns>
public static int l_getDataTwoBytes(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataTwoBytes(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (323, 1)
// l_setDataTwoBytes(line, n, val) as Object
// l_setDataTwoBytes(void *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataTwoBytes/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 - 0xffff</param>
public static void l_setDataTwoBytes(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataTwoBytes(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}

// arrayaccess.c (343, 1)
// l_getDataFourBytes(line, n) as int
// l_getDataFourBytes(void *, l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataFourBytes/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///   <returns>value of the n-th 4-byte pixel</returns>
public static int l_getDataFourBytes(
				 Object line, 
				 int n){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	int _Result = Natives.l_getDataFourBytes(  linePtr,   n);
	
	Marshal.FreeHGlobal(linePtr);
	return _Result;
}

// arrayaccess.c (359, 1)
// l_setDataFourBytes(line, n, val) as Object
// l_setDataFourBytes(void *, l_int32, l_int32) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataFourBytes/*"/>
///  <param name="line">[in] - ptr to beginning of data line</param>
///  <param name="n">[in] - pixel index</param>
///  <param name="val">[in] - val to be inserted: 0 - 0xffffffff</param>
public static void l_setDataFourBytes(
				 Object line, 
				 int n, 
				 int val){

if (line == null) {throw new ArgumentNullException  ("line cannot be Nothing");}
		IntPtr linePtr = 	Marshal.AllocHGlobal(0);
	// Todo: Functions.cs:SecureIn - Define coversation for object type

	Natives.l_setDataFourBytes(  linePtr,   n,   val);
	
	Marshal.FreeHGlobal(linePtr);
}


}
}
