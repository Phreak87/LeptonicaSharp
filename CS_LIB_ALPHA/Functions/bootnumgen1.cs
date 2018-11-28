using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// bootnumgen1.c (290, 1)
// l_bootnum_gen1() as Pixa
// l_bootnum_gen1() as PIXA *
///  <summary>
/// Call this way:
/// PIXA  pixa = l_bootnum_gen1() (C)
/// Pixa  pixa = l_bootnum_gen1() (C++)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_bootnum_gen1/*"/>
///   <returns>pixa  of labeled digits</returns>
public static Pixa l_bootnum_gen1(){

	IntPtr _Result = Natives.l_bootnum_gen1();
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

}
