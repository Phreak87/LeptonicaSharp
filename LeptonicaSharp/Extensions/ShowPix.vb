Public Class ShowPix
    WithEvents PicBox As New BetterPictureBox
    Sub New(ByVal Pix As Pix)
        InitializeComponent()
        If IsNothing(Pix) Then Exit Sub
        Dim Pix32 As Pix = LeptonicaSharp._AllFunctions.pixConvertTo32(Pix)
        If IsNothing(Pix32) Then Exit Sub

        Dim BMP As System.Drawing.Image = Pix32.ToBitmap
        PicBox.LoadImage(BMP) : Pix32.Dispose()
        Me.ShowDialog() : BMP.Dispose()
    End Sub
    Private Sub ShowPix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PicBox.Left = 0
        PicBox.Top = 0
        PicBox.Width = Me.Width
        PicBox.Height = Me.Height
        Me.Controls.Add(PicBox)
    End Sub
End Class