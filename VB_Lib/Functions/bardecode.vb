Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\bardecode.c (96, 1)
' barcodeDispatchDecoder(barstr, format, debugflag) as String
' barcodeDispatchDecoder(char *, l_int32, l_int32) as char *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/barcodeDispatchDecoder/*"/>
'''  <param name="barstr">[in] - string of integers in set {1,2,3,4} of bar widths</param>
'''  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
'''  <param name="debugflag">[in] - use 1 to generate debug output</param>
'''   <returns>data string of decoded barcode data, or NULL on error</returns>
Public Shared Function barcodeDispatchDecoder(
				 ByVal barstr as String, 
				 ByVal format as Enumerations.IFF, 
				 ByVal debugflag as Integer) as String

	If IsNothing (barstr) then Throw New ArgumentNullException  ("barstr cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.barcodeDispatchDecoder( barstr, format, debugflag)

	Return _Result
End Function

' SRC\bardecode.c (173, 1)
' barcodeFormatIsSupported(format) as Integer
' barcodeFormatIsSupported(l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/barcodeFormatIsSupported/*"/>
'''  <param name="format">[in] - </param>
'''   <returns>1 if format is one of those supported 0 otherwise</returns>
Public Shared Function barcodeFormatIsSupported(
				 ByVal format as Enumerations.IFF) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.barcodeFormatIsSupported( format)

	Return _Result
End Function

End Class
