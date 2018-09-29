Partial Public Class Pix
Sub New (
				ByVal filename as String)
	Dim RetObj = _Allfunctions.pixRead(filename)
	Pointer = RetObj.Pointer
End Sub
	Public Sub pixConvert32To16 (
				ByVal type as Enumerations.L_16_bit_conversion)
		me.Pointer = _Allfunctions.pixConvert32To16(me, type).Pointer
	End Sub
	Public Sub pixConvert32To8 (
				ByVal type16 as Enumerations.L_16_bit_conversion, 
				ByVal type8 as Enumerations.L_16_bit_conversion)
		me.Pointer = _Allfunctions.pixConvert32To8(me, type16, type8).Pointer
	End Sub
	Public Sub pixConvert8To4 (
				ByVal pix as Pix)
		me.Pointer = _Allfunctions.pixConvert8To4(pix).Pointer
	End Sub
	Public Sub pixConvert8To2 (
				ByVal pix as Pix)
		me.Pointer = _Allfunctions.pixConvert8To2(pix).Pointer
	End Sub
	Public Sub pixConvertTo1 (
				ByVal threshold as Integer)
		me.Pointer = _Allfunctions.pixConvertTo1(me, threshold).Pointer
	End Sub
	Public Function pixConvertToPdf (
				ByVal type as Enumerations.L_ENCODE, 
				ByVal fileout as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE, 
				Optional ByVal quality as Integer = 0, 
				Optional ByVal x as Integer = 0, 
				Optional ByVal y as Integer = 0, 
				Optional ByVal res as Integer = 0, 
				Optional ByVal title as String = Nothing)
		Return _Allfunctions.pixConvertToPdf(me, type, quality, fileout, x, y, res, title, plpd, position)
	End Function

End Class
