Partial Public Class RGBA_Quad
    Property QuadList As List(Of RGBA_Quad)
    Sub New(Bytes As Byte())
        Dim QList As New List(Of RGBA_Quad)
        For i As Integer = 0 To Bytes.Count - 1 Step 4
            Dim B(3) As Byte : Array.Copy(Bytes, i, B, 0, B.Length)
            QList.Add(New RGBA_Quad(B(0), B(1), B(2), B(3)))
        Next
        QuadList = QList
    End Sub
    Sub New(r, g, b, a)
        Values = New Marshal_RGBA_Quad
        Values.red = r
        Values.green = g
        Values.blue = b
        Values.alpha = a
    End Sub
    Public Overrides Function ToString() As String
        Return "R:" & red & " G:" & green & " B:" & blue & " A:" & alpha
    End Function
End Class
