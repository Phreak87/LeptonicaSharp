using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// fmorphauto.c (243, 1)
// fmorphautogen(sela, fileindex, filename) as int
// fmorphautogen(SELA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This function generates all the code for implementing
/// dwa morphological operations using all the sels in the sela.<para/>
/// 
/// (2) See fmorphautogen1() and fmorphautogen2() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fmorphautogen/*"/>
///  <param name="sela">[in] - </param>
///  <param name="fileindex">[in] - </param>
///  <param name="filename">[in][optional] - can be null</param>
///   <returns>0 if OK 1 on error</returns>
public static int fmorphautogen(
				 Sela sela, 
				 int fileindex, 
				 String filename){

	int _Result = Natives.fmorphautogen(sela.Pointer,   fileindex,   filename);
	
	return _Result;
}

// fmorphauto.c (283, 1)
// fmorphautogen1(sela, fileindex, filename) as int
// fmorphautogen1(SELA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This function uses morphtemplate1.txt to create a
/// top-level file that contains two functions.  These
/// functions will carry out dilation, erosion,
/// opening or closing for any of the sels in the input sela.<para/>
/// 
/// (2) The fileindex parameter is inserted into the output
/// filename, as described below.<para/>
/// 
/// (3) If filename == NULL, the output file is fmorphgen.[n].c,
/// where [n] is equal to the %fileindex parameter.<para/>
/// 
/// (4) If filename != NULL, the output file is [%filename].[n].c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fmorphautogen1/*"/>
///  <param name="sela">[in] - </param>
///  <param name="fileindex">[in] - </param>
///  <param name="filename">[in][optional] - can be null</param>
///   <returns>0 if OK 1 on error</returns>
public static int fmorphautogen1(
				 Sela sela, 
				 int fileindex, 
				 String filename){

	int _Result = Natives.fmorphautogen1(sela.Pointer,   fileindex,   filename);
	
	return _Result;
}

// fmorphauto.c (490, 1)
// fmorphautogen2(sela, fileindex, filename) as int
// fmorphautogen2(SELA *, l_int32, const char *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fmorphautogen2/*"/>
///   <returns></returns>
public static int fmorphautogen2(
				 Sela sela, 
				 int fileindex, 
				 String filename){

	IntPtr selaPtr = IntPtr.Zero; if (sela != null) {selaPtr = sela.Pointer;}

	int _Result = Natives.fmorphautogen2(sela.Pointer,   fileindex,   filename);
	
	return _Result;
}


}
}
