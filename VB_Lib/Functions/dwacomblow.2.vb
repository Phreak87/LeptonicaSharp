Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' D:\SubVersion\01_ACCESSIBLE\WrapperGenerator\trunk\NClang_Test\bin\Debug\SRC\dwacomblow.2.c (203, 1)
' fmorphopgen_low_2(datad, w, h, wpld, datas, wpls, index) as Integer
' fmorphopgen_low_2(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fmorphopgen_low_2/*"/>
'''   <returns></returns>
Public Shared Function fmorphopgen_low_2(
				 ByVal datad as Object, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal wpld as Integer, 
				 ByVal datas as Object, 
				 ByVal wpls as Integer, 
				 ByVal index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphopgen_low_2( datad, w, h, wpld, datas, wpls, index)


	Return _Result
End Function

End Class
