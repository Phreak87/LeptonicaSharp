Public Class ShowPix
    WithEvents PicBox As New BetterPictureBox
    Sub New(Pix As pix)
        InitializeComponent()

        ' Zuerst zu d32 konvertieren, Fehler aber einzige Lösung bis Dato
        Dim Pix32 As Pix = LeptonicaSharp._AllFunctions.pixConvertTo32(Pix)

        PicBox.LoadImage(Pix32.ToBitmap)
    End Sub
    Private Sub ShowPix_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PicBox.Left = 0
        PicBox.Top = 0
        PicBox.Width = Me.Width
        PicBox.Height = Me.Height
        Me.Controls.Add(PicBox)
    End Sub
End Class