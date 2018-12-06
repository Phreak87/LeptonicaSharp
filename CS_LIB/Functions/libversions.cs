using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// libversions.c (101, 1)
// getImagelibVersions() as String
// getImagelibVersions() as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getImagelibVersions/*"/>
///   <returns></returns>
public static String getImagelibVersions(){

	String _Result = Natives.getImagelibVersions();
	
	return _Result;
}


}
}
