Partial Public Class Box
    Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer)
        Me.New(LeptonicaSharp.Natives.boxCreate(X, Y, W, H))
    End Sub
End Class
