
Partial Public Class Sel
    Sub New(ByVal Text As String, ByVal w As Integer, ByVal h As Integer, ByVal name As String)
        Me.New(LeptonicaSharp.Natives.selCreateFromString(Text, h, w, name))
    End Sub
End Class
Partial Public Class Numa
    Sub New(ByVal Text As String)
        Me.New(LeptonicaSharp.Natives.numaCreateFromString(Text))
    End Sub
End Class
