using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// fhmtauto.c (207, 1)
// fhmtautogen(sela, fileindex, filename) as int
// fhmtautogen(SELA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This function generates all the code for implementing
/// dwa morphological operations using all the sels in the sela.<para/>
/// 
/// (2) See fhmtautogen1() and fhmtautogen2() for details.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtautogen/*"/>
///  <param name="sela">[in] - </param>
///  <param name="fileindex">[in] - </param>
///  <param name="filename">[in][optional] - can be null</param>
///   <returns>0 if OK 1 on error</returns>
public static int fhmtautogen(
				  Sela sela, 
				  int fileindex, 
				 String filename){

	int _Result = Natives.fhmtautogen(sela.Pointer,   fileindex,   filename);
	



	return _Result;
}

// fhmtauto.c (249, 1)
// fhmtautogen1(sela, fileindex, filename) as int
// fhmtautogen1(SELA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This function uses hmttemplate1.txt to create a
/// top-level file that contains two functions that carry
/// out the hit-miss transform for any of the sels in
/// the input sela.<para/>
/// 
/// (2) The fileindex parameter is inserted into the output
/// filename, as described below.<para/>
/// 
/// (3) If filename == NULL, the output file is fhmtgen.[n].c,
/// where [n] is equal to the 'fileindex' parameter.<para/>
/// 
/// (4) If filename != NULL, the output file is [filename].[n].c.<para/>
/// 
/// (5) Each sel must have at least one hit.  A sel with only misses
/// generates code that will abort the operation if it is called.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtautogen1/*"/>
///  <param name="sela">[in] - array</param>
///  <param name="fileindex">[in] - </param>
///  <param name="filename">[in][optional] - can be null</param>
///   <returns>0 if OK 1 on error</returns>
public static int fhmtautogen1(
				  Sela sela, 
				  int fileindex, 
				 String filename){

	int _Result = Natives.fhmtautogen1(sela.Pointer,   fileindex,   filename);
	



	return _Result;
}

// fhmtauto.c (431, 1)
// fhmtautogen2(sela, fileindex, filename) as int
// fhmtautogen2(SELA *, l_int32, const char *) as l_ok
///  <summary>
/// (1) This function uses hmttemplate2.txt to create a
/// low-level file that contains the low-level functions for
/// implementing the hit-miss transform for every sel
/// in the input sela.<para/>
/// 
/// (2) The fileindex parameter is inserted into the output
/// filename, as described below.<para/>
/// 
/// (3) If filename == NULL, the output file is fhmtgenlow.[n].c,
/// where [n] is equal to the %fileindex parameter.<para/>
/// 
/// (4) If filename != NULL, the output file is [filename]low.[n].c.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtautogen2/*"/>
///  <param name="sela">[in] - array</param>
///  <param name="fileindex">[in] - </param>
///  <param name="filename">[in][optional] - can be null</param>
///   <returns>0 if OK 1 on error</returns>
public static int fhmtautogen2(
				  Sela sela, 
				  int fileindex, 
				 String filename){

	int _Result = Natives.fhmtautogen2(sela.Pointer,   fileindex,   filename);
	



	return _Result;
}

}
