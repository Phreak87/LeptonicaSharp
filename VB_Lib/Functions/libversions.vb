Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\libversions.c (101, 1)
' getImagelibVersions() as String
' getImagelibVersions() as char *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/getImagelibVersions/*"/>
'''   <returns></returns>
Public Shared Function getImagelibVersions() as String

	Dim _Result as String = LeptonicaSharp.Natives.getImagelibVersions( )

	Return _Result
End Function

End Class
