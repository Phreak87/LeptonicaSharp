Partial Public Class Box
    Sub New(X As Integer, Y As Integer, W As Integer, H As Integer)
        Me.New(LeptonicaSharp.Natives.boxCreate(X, Y, W, H))
    End Sub
End Class
