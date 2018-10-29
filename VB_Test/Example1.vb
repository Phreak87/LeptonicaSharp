Imports LeptonicaSharp

Public Class Example1
    Function Test1()
        Dim Pixs As New Pix("pS1.tif")
        Dim pixt1 As Pix = LeptonicaSharp._All.pixReduceRankBinaryCascade(Pixs, 4, 4, 3, 0)
        Dim pixt2 As Pix = LeptonicaSharp._All.pixOpenBrick(Nothing, pixt1, 5, 5)
        Dim pixhs As Pix = LeptonicaSharp._All.pixExpandBinaryPower2(pixt2, 8)

        Dim pixm = LeptonicaSharp._All.pixCloseSafeBrick(Nothing, Pixs, 4, 4)
        Dim pixhm = LeptonicaSharp._All.pixSeedfillBinary(Nothing, pixhs, pixm, 4)
        LeptonicaSharp._All.pixOpenBrick(pixhm, pixhm, 10, 10)
        Dim pixtext = LeptonicaSharp._All.pixSubtract(Nothing, Pixs, pixhm)
        Dim pixinv = LeptonicaSharp._All.pixInvert(Nothing, Pixs)
        Dim pixvws = LeptonicaSharp._All.pixMorphCompSequence(pixinv, "o80.60", 0)
        Dim PNew2 As Pix = LeptonicaSharp._All.pixSubtract(pixvws, pixvws, pixt1)
        Dim pixt01 = LeptonicaSharp._All.pixCloseSafeBrick(Nothing, pixtext, 30, 1)
        Dim pixlines = LeptonicaSharp._All.pixSubtract(Nothing, pixt1, pixvws)
        Dim ResX = LeptonicaSharp._All.pixOpenBrick(pixlines, pixlines, 3, 3)
        Dim Pixa As New Pixa(1)
        Dim W, H As Integer
        pixt01 = LeptonicaSharp._All.pixSubtract(Nothing, pixt01, pixlines)
        Dim Boxa = LeptonicaSharp._All.pixConnComp(pixt01, Pixa, 8)
        Dim PixPD = LeptonicaSharp._All.pixGetDimensions(pixt01, W, H, Nothing)
        Pixa.display(W, H)
    End Function
End Class
