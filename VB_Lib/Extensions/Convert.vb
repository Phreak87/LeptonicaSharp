Public Class Convert
    Public Shared Function Deg2Grad(ByVal Deg As Double) As Double
        Return Deg * (Math.PI / 180)
    End Function
    Public Shared Function Grad2Dec(ByVal Grad As Double) As Double
        Return Grad / (Math.PI / 180)
    End Function
End Class
