Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\parseprotos.c (142, 1)
' parseForProtos(filein, prestring) as String
' parseForProtos(const char *, const char *) as char *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function parseForProtos(
				 ByVal filein as String, 
				 ByVal prestring as String) as String

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (prestring) then Throw New ArgumentNullException  ("prestring cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.parseForProtos( filein, prestring)

	Return _Result
End Function

End Class
