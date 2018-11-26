Imports System.Drawing

Public Class ShowPix
    WithEvents PicBox As New BetterPictureBox
    Sub New(ByVal Pix As Bitmap, Optional Text As String = "")
        InitializeComponent()
        Me.Text = Text
        If IsNothing(Pix) Then Exit Sub
        PicBox.LoadImage(Pix)
        Me.ShowDialog()
    End Sub
    Sub New(ByVal Pix As Pix, Optional Text As String = "")
        InitializeComponent()
        Me.Text = Text
        If IsNothing(Pix) Then Exit Sub
        PicBox.LoadImage(Pix.ToBitmap)
        Me.ShowDialog()
    End Sub
    Private Sub ShowPix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PicBox.Left = 0
        PicBox.Top = 0
        PicBox.Width = Me.Width
        PicBox.Height = Me.Height
        Me.Controls.Add(PicBox)
    End Sub
End Class