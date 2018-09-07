
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
Partial Public Class Box
    Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer)
        Me.New(LeptonicaSharp.Natives.boxCreate(X, Y, W, H))
    End Sub
End Class