Imports LeptonicaSharp

Public Class LineRemoval_Reg
    Dim Deg2Rad As Integer = Math.PI / 180
    Sub Test()
        Dim PIxs As New Pix("..\..\..\All_Images\Leptonica\dave-orig.png")
        Dim Pix1 As Pix = LeptonicaSharp._All.pixThresholdToBinary(PIxs, 170)
        Dim X1 As Single, X2 As Single : LeptonicaSharp._All.pixFindSkew(Pix1, X1, X2)
        Dim Pix2 As Pix = LeptonicaSharp._All.pixRotateAMGray(PIxs, X1 * Deg2Rad, 255)
        Dim Pix3 As Pix = LeptonicaSharp._All.pixCloseGray(Pix2, 51, 1)
        Dim Pix4 As Pix = LeptonicaSharp._All.pixErodeGray(Pix3, 1, 5)
        Dim Pix5 As Pix = LeptonicaSharp._All.pixThresholdToValue(Pix4, Pix4, 210, 255)
        Dim Pix6 As Pix = LeptonicaSharp._All.pixThresholdToValue(Pix5, Pix5, 200, 0)
        Dim Pix7 As Pix = LeptonicaSharp._All.pixThresholdToBinary(Pix6, 210)
        Pix6 = Pix6.pixInvert()
        Dim Pix8 As Pix = LeptonicaSharp._All.pixAddGray(Nothing, Pix2, Pix6)
        Dim Pix9 As Pix = LeptonicaSharp._All.pixOpenGray(Pix8, 1, 9)
        LeptonicaSharp._All.pixCombineMasked(Pix8, Pix9, Pix7)
        Pix9.Display()
    End Sub
End Class
