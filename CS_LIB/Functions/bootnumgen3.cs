using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// bootnumgen3.c (349, 1)
// l_bootnum_gen3() as Pixa
// l_bootnum_gen3() as PIXA *
///  <summary>
/// Call this way:
/// PIXA  pixa = l_bootnum_gen3() (C)
/// Pixa  pixa = l_bootnum_gen3() (C++)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_bootnum_gen3/*"/>
///   <returns>pixa  of labeled digits</returns>
public static Pixa l_bootnum_gen3(){

	IntPtr _Result = Natives.l_bootnum_gen3();
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}


}
}
