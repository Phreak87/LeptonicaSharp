using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

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

	String _Result = Natives.parseForProtos(  filein,   prestring);
	



	return _Result;
}

}
