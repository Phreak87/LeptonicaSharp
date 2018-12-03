using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// stringcode.c (156, 1)
// strcodeCreate(fileno) as L_StrCode
// strcodeCreate(l_int32) as L_STRCODE *
///  <summary>
/// (1) This struct exists to build two files containing code for
/// any number of data objects.  The two files are named
/// autogen.[fileno].c
/// autogen.[fileno].h
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeCreate/*"/>
///  <param name="fileno">[in] - integer that labels the two output files</param>
///   <returns>initialized L_StrCode, or NULL on error</returns>
public static L_StrCode strcodeCreate(
				 int fileno){

	IntPtr _Result = Natives.strcodeCreate(  fileno);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_StrCode(_Result);
}

// stringcode.c (223, 1)
// strcodeCreateFromFile(filein, fileno, outdir) as int
// strcodeCreateFromFile(const char *, l_int32, const char *) as l_ok
///  <summary>
/// (1) The %filein has one filename on each line.
/// Comment lines begin with "#".<para/>
/// 
/// (2) The output is 2 files:
/// autogen.[fileno].c
/// autogen.[fileno].h
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeCreateFromFile/*"/>
///  <param name="filein">[in] - containing filenames of serialized data</param>
///  <param name="fileno">[in] - integer that labels the two output files</param>
///  <param name="outdir">[in][optional] - if null, files are made in /tmp/lept/auto</param>
///   <returns>0 if OK, 1 on error</returns>
public static int strcodeCreateFromFile(
				 String filein, 
				 int fileno, 
				 String outdir){

	int _Result = Natives.strcodeCreateFromFile(  filein,   fileno,   outdir);
	



	return _Result;
}

// stringcode.c (289, 1)
// strcodeGenerate(strcode, filein, type) as int
// strcodeGenerate(L_STRCODE *, const char *, const char *) as l_ok
///  <summary>
/// (1) The generated function name is
/// l_autodecode_[fileno]()
/// where [fileno] is the index label for the pair of output files.<para/>
/// 
/// (2) To deserialize this data, the function is called with the
/// argument 'ifunc', which increments each time strcodeGenerate()
/// is called.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeGenerate/*"/>
///  <param name="strcode">[in] - for accumulating data</param>
///  <param name="filein">[in] - input file with serialized data</param>
///  <param name="type">[in] - of data use the typedef string</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int strcodeGenerate(
				 L_StrCode strcode, 
				 String filein, 
				 String type){

	int _Result = Natives.strcodeGenerate(strcode.Pointer,   filein,   type);
	



	return _Result;
}

// stringcode.c (336, 1)
// strcodeFinalize(pstrcode, outdir) as int
// strcodeFinalize(L_STRCODE **, const char *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeFinalize/*"/>
///  <param name="pstrcode">[in,out] - destroys after .c and .h files have been generated</param>
///  <param name="outdir">[in][optional] - if NULL, files are made in /tmp/lept/auto</param>
///   <returns>void</returns>
public static int strcodeFinalize(
				ref L_StrCode pstrcode, 
				 String outdir){

	IntPtr pstrcodePtr = IntPtr.Zero; 	if (pstrcode != null) {pstrcodePtr = pstrcode.Pointer;}

	int _Result = Natives.strcodeFinalize(ref pstrcodePtr,   outdir);
	

	if (pstrcodePtr == IntPtr.Zero) {pstrcode = null;} else { pstrcode = new L_StrCode(pstrcodePtr); };


	return _Result;
}

// stringcode.c (525, 1)
// l_getStructStrFromFile(filename, field, pstr) as int
// l_getStructStrFromFile(const char *, l_int32, char **) as l_int32
///  <summary>
/// (1) For example, if %field == L_STR_NAME, and the file is a serialized
/// pixa, this will return "Pixa", the name of the struct.<para/>
/// 
/// (2) Caller must free the returned string.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getStructStrFromFile/*"/>
///  <param name="filename">[in] - </param>
///  <param name="field">[in] - (L_STR_TYPE, L_STR_NAME, L_STR_READER, L_STR_MEMREADER)</param>
///  <param name="pstr">[out] - struct string for this file</param>
///   <returns>0 if found, 1 on error.</returns>
public static int l_getStructStrFromFile(
				 String filename, 
				 int field, 
				out String[] pstr){

	IntPtr pstrPtr = IntPtr.Zero;

	int _Result = Natives.l_getStructStrFromFile(  filename,   field, out  pstrPtr);
	

	if (pstrPtr == null) {pstr = null;} else { pstr = null; };


	return _Result;
}


}
}
