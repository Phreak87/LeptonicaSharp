Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' parseprotos.c (142, 1)
' parseForProtos(filein, prestring) as String
' parseForProtos(const char *, const char *) as char *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/parseForProtos/*"/>
'''   <returns></returns>
Public Shared Function parseForProtos(
				ByVal filein as String, 
				ByVal prestring as String) as String


if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
		if IsNothing (prestring) then Throw New ArgumentNullException  ("prestring cannot be Nothing")
	Dim _Result as String = Natives.parseForProtos(  filein,   prestring)
	
	return _Result
End Function

End Class


