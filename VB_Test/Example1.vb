Imports LeptonicaSharp

Public Class Example1
    Function Test1()
        Dim Pixs As New Pix("pS1.tif")

        Dim pixt1 As Pix = LeptonicaSharp._All.pixReduceRankBinaryCascade(Pixs, 4, 4, 3, 0) : Pixs.save_jpg("pixReduceRankBinaryCascade_S.jpg") : pixt1.save_jpg("pixReduceRankBinaryCascade_T.jpg")
        Dim pixt2 As Pix = LeptonicaSharp._All.pixOpenBrick(Nothing, pixt1, 3, 2) : Pixs.save_jpg("pixOpenBrick_S.jpg") : pixt2.save_jpg("pixOpenBrick_T.jpg")
        Dim pixhs As Pix = LeptonicaSharp._All.pixExpandBinaryPower2(pixt2, 2) : Pixs.save_jpg("pixExpandBinaryPower2_S.jpg") : pixhs.save_jpg("pixExpandBinaryPower2_T.jpg")

        Dim pixm = LeptonicaSharp._All.pixCloseSafeBrick(Nothing, Pixs, 4, 4) : Pixs.save_jpg("pixCloseSafeBrick_S.jpg") : pixm.save_jpg("pixCloseSafeBrick_T.jpg")
        Dim pixhm = LeptonicaSharp._All.pixSeedfillBinary(Nothing, pixhs, pixm, 4) '  Pixs.save_jpg("pixSeedfillBinary_S.jpg") : pixhm.save_jpg("pixSeedfillBinary_T.jpg")
        LeptonicaSharp._All.pixOpenBrick(pixhm, pixhm, 10, 10)
        Dim pixtext = LeptonicaSharp._All.pixSubtract(Nothing, Pixs, pixhm)
        Dim pixinv = LeptonicaSharp._All.pixInvert(Nothing, Pixs)
        Dim pixvws = LeptonicaSharp._All.pixMorphCompSequence(pixinv, "o80.60", 0) ' : pixinv.save_jpg("pixMorphCompSequence_S.jpg") : pixvws.save_jpg("pixMorphCompSequence_T.jpg")
        Dim PNew2 As Pix = LeptonicaSharp._All.pixSubtract(pixvws, pixvws, pixt1)
        Dim pixt01 = LeptonicaSharp._All.pixCloseSafeBrick(Nothing, pixtext, 30, 1)
        Dim pixlines = LeptonicaSharp._All.pixSubtract(Nothing, pixt1, pixvws)
        Dim ResX = LeptonicaSharp._All.pixOpenBrick(pixlines, pixlines, 3, 3)
        Dim Pixa As New Pixa(1)
        Dim W, H As Integer
        pixt01 = LeptonicaSharp._All.pixSubtract(Nothing, pixt01, pixlines)
        Dim Boxa = LeptonicaSharp._All.pixConnComp(pixt01, Pixa, 8)
        Dim PixPD = LeptonicaSharp._All.pixGetDimensions(pixt01, W, H, Nothing)
        Pixa.display()
    End Function
    Sub Test2()
        Dim pixa = _All.pixaCreate(0)
        Dim pixs = New Pix("test.jpg")
        Dim ppixhm, ppixtm, ppixtb, ppixm, ppixsd, ppixth, pixBinary As Pix

        Dim pixGray = _All.pixConvertTo8(pixs, 0)
        Dim retVal = _All.pixSauvolaBinarize(pixGray, 7, 0.25F, 0, ppixm, ppixsd, ppixth, pixBinary)

        _All.pixGetRegionsBinary(pixBinary, ppixhm, ppixtm, ppixtb, pixa)
        _All.pixaDisplayTiledAndScaled(pixa, 32, 250, 4, 255, 1, 1).Display()
        Convert.WriteHelpExtension("asdf", pixBinary, pixa.GetBitmap, {"asdfasfd"})
        Dim PixaD As New Pixa(1)
        Dim PixLines As Pixa = LeptonicaSharp._All.pixExtractTextlines(pixBinary, 255, 30, 15, 15, 0, 0, PixaD)
        PixaD.display()
        PixLines.display()

        Dim pxByCol = _All.pixCountPixelsByColumn(pixBinary)
        Dim pxByRow = _All.pixCountPixelsByRow(pixBinary, Nothing)
        Dim colProjections = pxByCol.array
        Dim rowProjections = pxByRow.array
        pxByRow.DisplayNumaHeatmap(pxByCol, pixBinary)

    End Sub
End Class
