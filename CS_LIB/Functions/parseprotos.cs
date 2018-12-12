using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

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

if (filein == null) {throw new ArgumentNullException  ("filein cannot be Nothing");}
		if (prestring == null) {throw new ArgumentNullException  ("prestring cannot be Nothing");}
	String _Result = Natives.parseForProtos(  filein,   prestring);
	
	return _Result;
}


}
}
