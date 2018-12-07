using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// sel2.c (92, 1)
// selaAddBasic(sela) as Sela
// selaAddBasic(SELA *) as SELA *
///  <summary>
/// (1) Adds the following sels:
/// ~ all linear (horiz, vert) brick sels that are
/// necessary for decomposable sels up to size 63
/// ~ square brick sels up to size 10
/// ~ 4 diagonal sels
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddBasic/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddBasic(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddBasic(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (181, 1)
// selaAddHitMiss(sela) as Sela
// selaAddHitMiss(SELA *) as SELA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddHitMiss/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddHitMiss(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddHitMiss(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (319, 1)
// selaAddDwaLinear(sela) as Sela
// selaAddDwaLinear(SELA *) as SELA *
///  <summary>
/// (1) Adds all linear (horizontal, vertical) sels from
/// 2 to 63 pixels in length, which are the sizes over
/// which dwa code can be generated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddDwaLinear/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddDwaLinear(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddDwaLinear(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (361, 1)
// selaAddDwaCombs(sela) as Sela
// selaAddDwaCombs(SELA *) as SELA *
///  <summary>
/// (1) Adds all comb (horizontal, vertical) Sels that are
/// used in composite linear morphological operations
/// up to 63 pixels in length, which are the sizes over
/// which dwa code can be generated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddDwaCombs/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddDwaCombs(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddDwaCombs(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (423, 1)
// selaAddCrossJunctions(sela, hlsize, mdist, norient, debugflag) as Sela
// selaAddCrossJunctions(SELA *, l_float32, l_float32, l_int32, l_int32) as SELA *
///  <summary>
/// (1) Adds hitmiss Sels for the intersection of two lines.
/// If the lines are very thin, they must be nearly orthogonal
/// to register.<para/>
/// 
/// (2) The number of Sels generated is equal to %norient.<para/>
/// 
/// (3) If %norient == 2, this generates 2 Sels of crosses, each with
/// two perpendicular lines of hits.  One Sel has horizontal and
/// vertical hits the other has hits along lines at +-45 degrees.
/// Likewise, if %norient == 3, this generates 3 Sels of crosses
/// oriented at 30 degrees with each other.<para/>
/// 
/// (4) It is suggested that %hlsize be chosen at least 1 greater
/// than %mdist.  Try values of (%hlsize, %mdist) such as
/// (6,5), (7,6), (8,7), (9,7), etc.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddCrossJunctions/*"/>
///  <param name="sela">[in][optional] - </param>
///  <param name="hlsize">[in] - length of each line of hits from origin</param>
///  <param name="mdist">[in] - distance of misses from the origin</param>
///  <param name="norient">[in] - number of orientations max of 8</param>
///  <param name="debugflag">[in] - 1 for debug output</param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddCrossJunctions(
				 Sela sela, 
				 Single hlsize, 
				 Single mdist, 
				 int norient, 
				 int debugflag){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddCrossJunctions(selaPtr,   hlsize,   mdist,   norient,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (548, 1)
// selaAddTJunctions(sela, hlsize, mdist, norient, debugflag) as Sela
// selaAddTJunctions(SELA *, l_float32, l_float32, l_int32, l_int32) as SELA *
///  <summary>
/// (1) Adds hitmiss Sels for the T-junction of two lines.
/// If the lines are very thin, they must be nearly orthogonal
/// to register.<para/>
/// 
/// (2) The number of Sels generated is 4  %norient.<para/>
/// 
/// (3) It is suggested that %hlsize be chosen at least 1 greater
/// than %mdist.  Try values of (%hlsize, %mdist) such as
/// (6,5), (7,6), (8,7), (9,7), etc.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/selaAddTJunctions/*"/>
///  <param name="sela">[in][optional] - </param>
///  <param name="hlsize">[in] - length of each line of hits from origin</param>
///  <param name="mdist">[in] - distance of misses from the origin</param>
///  <param name="norient">[in] - number of orientations max of 8</param>
///  <param name="debugflag">[in] - 1 for debug output</param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela selaAddTJunctions(
				 Sela sela, 
				 Single hlsize, 
				 Single mdist, 
				 int norient, 
				 int debugflag){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.selaAddTJunctions(selaPtr,   hlsize,   mdist,   norient,   debugflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (749, 1)
// sela4ccThin(sela) as Sela
// sela4ccThin(SELA *) as SELA *
///  <summary>
/// (1) Adds the 9 basic sels for 4-cc thinning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sela4ccThin/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela sela4ccThin(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.sela4ccThin(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (790, 1)
// sela8ccThin(sela) as Sela
// sela8ccThin(SELA *) as SELA *
///  <summary>
/// (1) Adds the 9 basic sels for 8-cc thinning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sela8ccThin/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela sela8ccThin(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.sela8ccThin(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}

// sel2.c (831, 1)
// sela4and8ccThin(sela) as Sela
// sela4and8ccThin(SELA *) as SELA *
///  <summary>
/// (1) Adds the 2 basic sels for either 4-cc or 8-cc thinning.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sela4and8ccThin/*"/>
///  <param name="sela">[in][optional] - </param>
///   <returns>sela with additional sels, or NULL on error</returns>
public static Sela sela4and8ccThin(
				 Sela sela){

	IntPtr selaPtr = IntPtr.Zero; 	if (sela != null) {selaPtr = sela.Pointer;}

	IntPtr _Result = Natives.sela4and8ccThin(selaPtr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sela(_Result);
}


}
}
