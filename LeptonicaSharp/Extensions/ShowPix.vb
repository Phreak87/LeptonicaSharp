Public Class ShowPix
    WithEvents PicBox As New BetterPictureBox
    Sub New(Pix As pix)
        InitializeComponent()
        'PicBox.LoadImage(Pix.tobitmap)
    End Sub
    Private Sub ShowPix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PicBox.Left = 0
        PicBox.Top = 0
        PicBox.Width = Me.Width
        PicBox.Height = Me.Height
        Me.Controls.Add(PicBox)
    End Sub
End Class