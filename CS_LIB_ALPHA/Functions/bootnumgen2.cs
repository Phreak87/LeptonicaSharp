using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// bootnumgen2.c (273, 1)
// l_bootnum_gen2() as Pixa
// l_bootnum_gen2() as PIXA *
///  <summary>
/// Call this way:
/// PIXA  pixa = l_bootnum_gen2() (C)
/// Pixa  pixa = l_bootnum_gen2() (C++)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_bootnum_gen2/*"/>
///   <returns>pixa  of labeled digits</returns>

public static Pixa l_bootnum_gen2(){



	IntPtr _Result = Natives.l_bootnum_gen2();
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pixa(_Result);
}


}
}
