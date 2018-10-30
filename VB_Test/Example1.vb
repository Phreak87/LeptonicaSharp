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
    Sub Test2()
        Dim pixa = _All.pixaCreate(0)
        Dim pixs = New Pix("test.jpg")
        Dim ppixhm, ppixtm, ppixtb, ppixm, ppixsd, ppixth, pixBinary As Pix

        Dim pixGray = _All.pixConvertTo8(pixs, 0)
        Dim retVal = _All.pixSauvolaBinarize(pixGray, 7, 0.25F, 0, ppixm, ppixsd, ppixth, pixBinary)

        _All.pixGetRegionsBinary(pixBinary, ppixhm, ppixtm, ppixtb, pixa)
        _All.pixaDisplayTiledAndScaled(pixa, 32, 250, 4, 255, 1, 1).Display()

        Dim PixaD As New Pixa(1)
        Dim PixLines As Pixa = LeptonicaSharp._All.pixExtractTextlines(pixBinary, 255, 30, 15, 15, 0, 0, PixaD)
        PixaD.display(150, 150)
        PixLines.display(150, 150)

        Dim pxByCol = _All.pixCountPixelsByColumn(pixBinary)
        Dim pxByRow = _All.pixCountPixelsByRow(pixBinary, Nothing)
        Dim colProjections = pxByCol.array
        Dim rowProjections = pxByRow.array
        pxByCol.DisplayasHistogram()
        pxByRow.DisplayasHistogram()

    End Sub
End Class
