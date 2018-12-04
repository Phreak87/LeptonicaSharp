using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// parseprotos.c (142, 1)
// parseForProtos(filein, prestring) as String
// parseForProtos(const char *, const char *) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/parseForProtos/*"/>
///   <returns></returns>

public static String parseForProtos(
				 String filein, 
				 String prestring){



	String _Result = Natives.parseForProtos(
  filein,   prestring);
	


//  



	return _Result;
}


}
}
