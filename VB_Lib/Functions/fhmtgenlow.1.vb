Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' D:\SubVersion\01_ACCESSIBLE\WrapperGenerator\trunk\NClang_Test\bin\Debug\SRC\fhmtgenlow.1.c (60, 1)
' fhmtgen_low_1(datad, w, h, wpld, datas, wpls, index) as Integer
' fhmtgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtgen_low_1/*"/>
'''   <returns></returns>
Public Shared Function fhmtgen_low_1(
				 ByVal datad as Object, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal wpld as Integer, 
				 ByVal datas as Object, 
				 ByVal wpls as Integer, 
				 ByVal index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtgen_low_1( datad, w, h, wpld, datas, wpls, index)


	Return _Result
End Function

End Class
