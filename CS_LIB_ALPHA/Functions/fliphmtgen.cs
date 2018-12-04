using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// fliphmtgen.c (77, 1)
// pixFlipFHMTGen(pixd, pixs, selname) as Pix
// pixFlipFHMTGen(PIX *, PIX *, const char *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFlipFHMTGen/*"/>
///   <returns></returns>

public static Pix pixFlipFHMTGen(
				 Pix pixd, 
				 Pix pixs, 
				 String selname){


	IntPtr pixdPtr = IntPtr.Zero; if (pixd != null) {pixdPtr = pixd.Pointer;}
	IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}

	IntPtr _Result = Natives.pixFlipFHMTGen(
pixd.Pointer, pixs.Pointer,   selname);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new Pix(_Result);
}


}
}
