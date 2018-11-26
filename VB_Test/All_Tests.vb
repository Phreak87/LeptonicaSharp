Imports LeptonicaSharp

Class WriteHelp
Shared Sub WriteExamplePictures
Dim TestPix as new Pix("TestPix.jpg")

' Dim RESpixCleanBackgroundToWhite as Pix = LeptonicaSharp._All.pixCleanBackgroundToWhite(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCleanBackgroundToWhite",TestPix, RESpixCleanBackgroundToWhite,{"Dim RESpixCleanBackgroundToWhite as Pix = LeptonicaSharp._All.pixCleanBackgroundToWhite(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixBackgroundNormSimple as Pix = LeptonicaSharp._All.pixBackgroundNormSimple(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormSimple",TestPix, RESpixBackgroundNormSimple,{"Dim RESpixBackgroundNormSimple as Pix = LeptonicaSharp._All.pixBackgroundNormSimple(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixBackgroundNorm as Pix = LeptonicaSharp._All.pixBackgroundNorm(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNorm",TestPix, RESpixBackgroundNorm,{"Dim RESpixBackgroundNorm as Pix = LeptonicaSharp._All.pixBackgroundNorm(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBackgroundNormMorph as Pix = LeptonicaSharp._All.pixBackgroundNormMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormMorph",TestPix, RESpixBackgroundNormMorph,{"Dim RESpixBackgroundNormMorph as Pix = LeptonicaSharp._All.pixBackgroundNormMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBackgroundNormGrayArray as Integer = LeptonicaSharp._All.pixBackgroundNormGrayArray(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormGrayArray",TestPix, RESpixBackgroundNormGrayArray,{"Dim RESpixBackgroundNormGrayArray as Integer = LeptonicaSharp._All.pixBackgroundNormGrayArray(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixBackgroundNormRGBArrays as Integer = LeptonicaSharp._All.pixBackgroundNormRGBArrays(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormRGBArrays",TestPix, RESpixBackgroundNormRGBArrays,{"Dim RESpixBackgroundNormRGBArrays as Integer = LeptonicaSharp._All.pixBackgroundNormRGBArrays(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)"},1)

' Dim RESpixBackgroundNormGrayArrayMorph as Integer = LeptonicaSharp._All.pixBackgroundNormGrayArrayMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormGrayArrayMorph",TestPix, RESpixBackgroundNormGrayArrayMorph,{"Dim RESpixBackgroundNormGrayArrayMorph as Integer = LeptonicaSharp._All.pixBackgroundNormGrayArrayMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixBackgroundNormRGBArraysMorph as Integer = LeptonicaSharp._All.pixBackgroundNormRGBArraysMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormRGBArraysMorph",TestPix, RESpixBackgroundNormRGBArraysMorph,{"Dim RESpixBackgroundNormRGBArraysMorph as Integer = LeptonicaSharp._All.pixBackgroundNormRGBArraysMorph(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)"},1)

' Dim RESpixGetBackgroundGrayMap as Integer = LeptonicaSharp._All.pixGetBackgroundGrayMap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBackgroundGrayMap",TestPix, RESpixGetBackgroundGrayMap,{"Dim RESpixGetBackgroundGrayMap as Integer = LeptonicaSharp._All.pixGetBackgroundGrayMap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixGetBackgroundRGBMap as Integer = LeptonicaSharp._All.pixGetBackgroundRGBMap(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBackgroundRGBMap",TestPix, RESpixGetBackgroundRGBMap,{"Dim RESpixGetBackgroundRGBMap as Integer = LeptonicaSharp._All.pixGetBackgroundRGBMap(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix,New Pix)"},1)

' Dim RESpixGetBackgroundGrayMapMorph as Integer = LeptonicaSharp._All.pixGetBackgroundGrayMapMorph(TestPix ,Nothing ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBackgroundGrayMapMorph",TestPix, RESpixGetBackgroundGrayMapMorph,{"Dim RESpixGetBackgroundGrayMapMorph as Integer = LeptonicaSharp._All.pixGetBackgroundGrayMapMorph(TestPix ,Nothing ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixGetBackgroundRGBMapMorph as Integer = LeptonicaSharp._All.pixGetBackgroundRGBMapMorph(TestPix ,Nothing ,TestPix ,TestPix ,New Pix,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBackgroundRGBMapMorph",TestPix, RESpixGetBackgroundRGBMapMorph,{"Dim RESpixGetBackgroundRGBMapMorph as Integer = LeptonicaSharp._All.pixGetBackgroundRGBMapMorph(TestPix ,Nothing ,TestPix ,TestPix ,New Pix,New Pix,New Pix)"},1)

' Dim RESpixFillMapHoles as Integer = LeptonicaSharp._All.pixFillMapHoles(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFillMapHoles",TestPix, RESpixFillMapHoles,{"Dim RESpixFillMapHoles as Integer = LeptonicaSharp._All.pixFillMapHoles(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixExtendByReplication as Pix = LeptonicaSharp._All.pixExtendByReplication(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtendByReplication",TestPix, RESpixExtendByReplication,{"Dim RESpixExtendByReplication as Pix = LeptonicaSharp._All.pixExtendByReplication(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSmoothConnectedRegions as Integer = LeptonicaSharp._All.pixSmoothConnectedRegions(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSmoothConnectedRegions",TestPix, RESpixSmoothConnectedRegions,{"Dim RESpixSmoothConnectedRegions as Integer = LeptonicaSharp._All.pixSmoothConnectedRegions(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixGetInvBackgroundMap as Pix = LeptonicaSharp._All.pixGetInvBackgroundMap(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetInvBackgroundMap",TestPix, RESpixGetInvBackgroundMap,{"Dim RESpixGetInvBackgroundMap as Pix = LeptonicaSharp._All.pixGetInvBackgroundMap(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixApplyInvBackgroundGrayMap as Pix = LeptonicaSharp._All.pixApplyInvBackgroundGrayMap(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixApplyInvBackgroundGrayMap",TestPix, RESpixApplyInvBackgroundGrayMap,{"Dim RESpixApplyInvBackgroundGrayMap as Pix = LeptonicaSharp._All.pixApplyInvBackgroundGrayMap(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixApplyInvBackgroundRGBMap as Pix = LeptonicaSharp._All.pixApplyInvBackgroundRGBMap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixApplyInvBackgroundRGBMap",TestPix, RESpixApplyInvBackgroundRGBMap,{"Dim RESpixApplyInvBackgroundRGBMap as Pix = LeptonicaSharp._All.pixApplyInvBackgroundRGBMap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixApplyVariableGrayMap as Pix = LeptonicaSharp._All.pixApplyVariableGrayMap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixApplyVariableGrayMap",TestPix, RESpixApplyVariableGrayMap,{"Dim RESpixApplyVariableGrayMap as Pix = LeptonicaSharp._All.pixApplyVariableGrayMap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGlobalNormRGB as Pix = LeptonicaSharp._All.pixGlobalNormRGB(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGlobalNormRGB",TestPix, RESpixGlobalNormRGB,{"Dim RESpixGlobalNormRGB as Pix = LeptonicaSharp._All.pixGlobalNormRGB(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGlobalNormNoSatRGB as Pix = LeptonicaSharp._All.pixGlobalNormNoSatRGB(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGlobalNormNoSatRGB",TestPix, RESpixGlobalNormNoSatRGB,{"Dim RESpixGlobalNormNoSatRGB as Pix = LeptonicaSharp._All.pixGlobalNormNoSatRGB(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdSpreadNorm as Integer = LeptonicaSharp._All.pixThresholdSpreadNorm(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdSpreadNorm",TestPix, RESpixThresholdSpreadNorm,{"Dim RESpixThresholdSpreadNorm as Integer = LeptonicaSharp._All.pixThresholdSpreadNorm(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixBackgroundNormFlex as Pix = LeptonicaSharp._All.pixBackgroundNormFlex(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBackgroundNormFlex",TestPix, RESpixBackgroundNormFlex,{"Dim RESpixBackgroundNormFlex as Pix = LeptonicaSharp._All.pixBackgroundNormFlex(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixContrastNorm as Pix = LeptonicaSharp._All.pixContrastNorm(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixContrastNorm",TestPix, RESpixContrastNorm,{"Dim RESpixContrastNorm as Pix = LeptonicaSharp._All.pixContrastNorm(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMinMaxTiles as Integer = LeptonicaSharp._All.pixMinMaxTiles(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMinMaxTiles",TestPix, RESpixMinMaxTiles,{"Dim RESpixMinMaxTiles as Integer = LeptonicaSharp._All.pixMinMaxTiles(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New Pix)"},1)

' Dim RESpixSetLowContrast as Integer = LeptonicaSharp._All.pixSetLowContrast(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetLowContrast",TestPix, RESpixSetLowContrast,{"Dim RESpixSetLowContrast as Integer = LeptonicaSharp._All.pixSetLowContrast(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixLinearTRCTiled as Pix = LeptonicaSharp._All.pixLinearTRCTiled(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLinearTRCTiled",TestPix, RESpixLinearTRCTiled,{"Dim RESpixLinearTRCTiled as Pix = LeptonicaSharp._All.pixLinearTRCTiled(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffineSampledPta as Pix = LeptonicaSharp._All.pixAffineSampledPta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffineSampledPta",TestPix, RESpixAffineSampledPta,{"Dim RESpixAffineSampledPta as Pix = LeptonicaSharp._All.pixAffineSampledPta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffineSampled as Pix = LeptonicaSharp._All.pixAffineSampled(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffineSampled",TestPix, RESpixAffineSampled,{"Dim RESpixAffineSampled as Pix = LeptonicaSharp._All.pixAffineSampled(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffinePta as Pix = LeptonicaSharp._All.pixAffinePta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffinePta",TestPix, RESpixAffinePta,{"Dim RESpixAffinePta as Pix = LeptonicaSharp._All.pixAffinePta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffine as Pix = LeptonicaSharp._All.pixAffine(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffine",TestPix, RESpixAffine,{"Dim RESpixAffine as Pix = LeptonicaSharp._All.pixAffine(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffinePtaColor as Pix = LeptonicaSharp._All.pixAffinePtaColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffinePtaColor",TestPix, RESpixAffinePtaColor,{"Dim RESpixAffinePtaColor as Pix = LeptonicaSharp._All.pixAffinePtaColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffineColor as Pix = LeptonicaSharp._All.pixAffineColor(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffineColor",TestPix, RESpixAffineColor,{"Dim RESpixAffineColor as Pix = LeptonicaSharp._All.pixAffineColor(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffinePtaGray as Pix = LeptonicaSharp._All.pixAffinePtaGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffinePtaGray",TestPix, RESpixAffinePtaGray,{"Dim RESpixAffinePtaGray as Pix = LeptonicaSharp._All.pixAffinePtaGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffineGray as Pix = LeptonicaSharp._All.pixAffineGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffineGray",TestPix, RESpixAffineGray,{"Dim RESpixAffineGray as Pix = LeptonicaSharp._All.pixAffineGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffinePtaWithAlpha as Pix = LeptonicaSharp._All.pixAffinePtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffinePtaWithAlpha",TestPix, RESpixAffinePtaWithAlpha,{"Dim RESpixAffinePtaWithAlpha as Pix = LeptonicaSharp._All.pixAffinePtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESgetAffineXformCoeffs as Integer = LeptonicaSharp._All.getAffineXformCoeffs(TestPix ,TestPix ,New List(Of Single()))
' LeptonicaSharp.Convert.WriteHelpExtension ("getAffineXformCoeffs",TestPix, RESgetAffineXformCoeffs,{"Dim RESgetAffineXformCoeffs as Integer = LeptonicaSharp._All.getAffineXformCoeffs(TestPix ,TestPix ,New List(Of Single()))"},1)

' Dim RESaffineInvertXform as Integer = LeptonicaSharp._All.affineInvertXform(TestPix ,New List(Of Single()))
' LeptonicaSharp.Convert.WriteHelpExtension ("affineInvertXform",TestPix, RESaffineInvertXform,{"Dim RESaffineInvertXform as Integer = LeptonicaSharp._All.affineInvertXform(TestPix ,New List(Of Single()))"},1)

' Dim RESaffineXformSampledPt as Integer = LeptonicaSharp._All.affineXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("affineXformSampledPt",TestPix, RESaffineXformSampledPt,{"Dim RESaffineXformSampledPt as Integer = LeptonicaSharp._All.affineXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESaffineXformPt as Integer = LeptonicaSharp._All.affineXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("affineXformPt",TestPix, RESaffineXformPt,{"Dim RESaffineXformPt as Integer = LeptonicaSharp._All.affineXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)"},1)

' Dim RESlinearInterpolatePixelColor as Integer = LeptonicaSharp._All.linearInterpolatePixelColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("linearInterpolatePixelColor",TestPix, RESlinearInterpolatePixelColor,{"Dim RESlinearInterpolatePixelColor as Integer = LeptonicaSharp._All.linearInterpolatePixelColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESlinearInterpolatePixelGray as Integer = LeptonicaSharp._All.linearInterpolatePixelGray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("linearInterpolatePixelGray",TestPix, RESlinearInterpolatePixelGray,{"Dim RESlinearInterpolatePixelGray as Integer = LeptonicaSharp._All.linearInterpolatePixelGray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESgaussjordan as Integer = LeptonicaSharp._All.gaussjordan(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gaussjordan",TestPix, RESgaussjordan,{"Dim RESgaussjordan as Integer = LeptonicaSharp._All.gaussjordan(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAffineSequential as Pix = LeptonicaSharp._All.pixAffineSequential(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAffineSequential",TestPix, RESpixAffineSequential,{"Dim RESpixAffineSequential as Pix = LeptonicaSharp._All.pixAffineSequential(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim REScreateMatrix2dTranslate as Single() = LeptonicaSharp._All.createMatrix2dTranslate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("createMatrix2dTranslate",TestPix, REScreateMatrix2dTranslate,{"Dim REScreateMatrix2dTranslate as Single() = LeptonicaSharp._All.createMatrix2dTranslate(TestPix ,TestPix )"},1)

' Dim REScreateMatrix2dScale as Single() = LeptonicaSharp._All.createMatrix2dScale(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("createMatrix2dScale",TestPix, REScreateMatrix2dScale,{"Dim REScreateMatrix2dScale as Single() = LeptonicaSharp._All.createMatrix2dScale(Nothing ,Nothing )"},1)

' Dim REScreateMatrix2dRotate as Single() = LeptonicaSharp._All.createMatrix2dRotate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("createMatrix2dRotate",TestPix, REScreateMatrix2dRotate,{"Dim REScreateMatrix2dRotate as Single() = LeptonicaSharp._All.createMatrix2dRotate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaTranslate as Pta = LeptonicaSharp._All.ptaTranslate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaTranslate",TestPix, RESptaTranslate,{"Dim RESptaTranslate as Pta = LeptonicaSharp._All.ptaTranslate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaScale as Pta = LeptonicaSharp._All.ptaScale(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaScale",TestPix, RESptaScale,{"Dim RESptaScale as Pta = LeptonicaSharp._All.ptaScale(TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaRotate as Pta = LeptonicaSharp._All.ptaRotate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaRotate",TestPix, RESptaRotate,{"Dim RESptaRotate as Pta = LeptonicaSharp._All.ptaRotate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaTranslate as Boxa = LeptonicaSharp._All.boxaTranslate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaTranslate",TestPix, RESboxaTranslate,{"Dim RESboxaTranslate as Boxa = LeptonicaSharp._All.boxaTranslate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaScale as Boxa = LeptonicaSharp._All.boxaScale(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaScale",TestPix, RESboxaScale,{"Dim RESboxaScale as Boxa = LeptonicaSharp._All.boxaScale(TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxaRotate as Boxa = LeptonicaSharp._All.boxaRotate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaRotate",TestPix, RESboxaRotate,{"Dim RESboxaRotate as Boxa = LeptonicaSharp._All.boxaRotate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaAffineTransform as Pta = LeptonicaSharp._All.ptaAffineTransform(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaAffineTransform",TestPix, RESptaAffineTransform,{"Dim RESptaAffineTransform as Pta = LeptonicaSharp._All.ptaAffineTransform(TestPix ,TestPix )"},1)

' Dim RESboxaAffineTransform as Boxa = LeptonicaSharp._All.boxaAffineTransform(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaAffineTransform",TestPix, RESboxaAffineTransform,{"Dim RESboxaAffineTransform as Boxa = LeptonicaSharp._All.boxaAffineTransform(TestPix ,TestPix )"},1)

' Dim RESl_productMatVec as Integer = LeptonicaSharp._All.l_productMatVec(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_productMatVec",TestPix, RESl_productMatVec,{"Dim RESl_productMatVec as Integer = LeptonicaSharp._All.l_productMatVec(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_productMat2 as Integer = LeptonicaSharp._All.l_productMat2(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_productMat2",TestPix, RESl_productMat2,{"Dim RESl_productMat2 as Integer = LeptonicaSharp._All.l_productMat2(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_productMat3 as Integer = LeptonicaSharp._All.l_productMat3(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_productMat3",TestPix, RESl_productMat3,{"Dim RESl_productMat3 as Integer = LeptonicaSharp._All.l_productMat3(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_productMat4 as Integer = LeptonicaSharp._All.l_productMat4(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_productMat4",TestPix, RESl_productMat4,{"Dim RESl_productMat4 as Integer = LeptonicaSharp._All.l_productMat4(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_getDataBit as Integer = LeptonicaSharp._All.l_getDataBit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataBit",TestPix, RESl_getDataBit,{"Dim RESl_getDataBit as Integer = LeptonicaSharp._All.l_getDataBit(TestPix ,TestPix )"},1)

' Dim RESl_setDataBit as Object = LeptonicaSharp._All.l_setDataBit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataBit",TestPix, RESl_setDataBit,{"Dim RESl_setDataBit as Object = LeptonicaSharp._All.l_setDataBit(TestPix ,TestPix )"},1)

' Dim RESl_clearDataBit as Object = LeptonicaSharp._All.l_clearDataBit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_clearDataBit",TestPix, RESl_clearDataBit,{"Dim RESl_clearDataBit as Object = LeptonicaSharp._All.l_clearDataBit(TestPix ,TestPix )"},1)

' Dim RESl_setDataBitVal as Object = LeptonicaSharp._All.l_setDataBitVal(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataBitVal",TestPix, RESl_setDataBitVal,{"Dim RESl_setDataBitVal as Object = LeptonicaSharp._All.l_setDataBitVal(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_getDataDibit as Integer = LeptonicaSharp._All.l_getDataDibit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataDibit",TestPix, RESl_getDataDibit,{"Dim RESl_getDataDibit as Integer = LeptonicaSharp._All.l_getDataDibit(TestPix ,TestPix )"},1)

' Dim RESl_setDataDibit as Object = LeptonicaSharp._All.l_setDataDibit(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataDibit",TestPix, RESl_setDataDibit,{"Dim RESl_setDataDibit as Object = LeptonicaSharp._All.l_setDataDibit(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_clearDataDibit as Object = LeptonicaSharp._All.l_clearDataDibit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_clearDataDibit",TestPix, RESl_clearDataDibit,{"Dim RESl_clearDataDibit as Object = LeptonicaSharp._All.l_clearDataDibit(TestPix ,TestPix )"},1)

' Dim RESl_getDataQbit as Integer = LeptonicaSharp._All.l_getDataQbit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataQbit",TestPix, RESl_getDataQbit,{"Dim RESl_getDataQbit as Integer = LeptonicaSharp._All.l_getDataQbit(TestPix ,TestPix )"},1)

' Dim RESl_setDataQbit as Object = LeptonicaSharp._All.l_setDataQbit(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataQbit",TestPix, RESl_setDataQbit,{"Dim RESl_setDataQbit as Object = LeptonicaSharp._All.l_setDataQbit(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_clearDataQbit as Object = LeptonicaSharp._All.l_clearDataQbit(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_clearDataQbit",TestPix, RESl_clearDataQbit,{"Dim RESl_clearDataQbit as Object = LeptonicaSharp._All.l_clearDataQbit(TestPix ,TestPix )"},1)

' Dim RESl_getDataByte as Integer = LeptonicaSharp._All.l_getDataByte(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataByte",TestPix, RESl_getDataByte,{"Dim RESl_getDataByte as Integer = LeptonicaSharp._All.l_getDataByte(TestPix ,TestPix )"},1)

' Dim RESl_setDataByte as Object = LeptonicaSharp._All.l_setDataByte(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataByte",TestPix, RESl_setDataByte,{"Dim RESl_setDataByte as Object = LeptonicaSharp._All.l_setDataByte(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_getDataTwoBytes as Integer = LeptonicaSharp._All.l_getDataTwoBytes(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataTwoBytes",TestPix, RESl_getDataTwoBytes,{"Dim RESl_getDataTwoBytes as Integer = LeptonicaSharp._All.l_getDataTwoBytes(TestPix ,TestPix )"},1)

' Dim RESl_setDataTwoBytes as Object = LeptonicaSharp._All.l_setDataTwoBytes(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataTwoBytes",TestPix, RESl_setDataTwoBytes,{"Dim RESl_setDataTwoBytes as Object = LeptonicaSharp._All.l_setDataTwoBytes(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_getDataFourBytes as Integer = LeptonicaSharp._All.l_getDataFourBytes(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getDataFourBytes",TestPix, RESl_getDataFourBytes,{"Dim RESl_getDataFourBytes as Integer = LeptonicaSharp._All.l_getDataFourBytes(TestPix ,TestPix )"},1)

' Dim RESl_setDataFourBytes as Object = LeptonicaSharp._All.l_setDataFourBytes(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setDataFourBytes",TestPix, RESl_setDataFourBytes,{"Dim RESl_setDataFourBytes as Object = LeptonicaSharp._All.l_setDataFourBytes(TestPix ,TestPix ,TestPix )"},1)

' Dim RESbarcodeDispatchDecoder as String = LeptonicaSharp._All.barcodeDispatchDecoder(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("barcodeDispatchDecoder",TestPix, RESbarcodeDispatchDecoder,{"Dim RESbarcodeDispatchDecoder as String = LeptonicaSharp._All.barcodeDispatchDecoder(TestPix ,TestPix ,TestPix )"},1)

' Dim RESbarcodeFormatIsSupported as Integer = LeptonicaSharp._All.barcodeFormatIsSupported(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("barcodeFormatIsSupported",TestPix, RESbarcodeFormatIsSupported,{"Dim RESbarcodeFormatIsSupported as Integer = LeptonicaSharp._All.barcodeFormatIsSupported(TestPix )"},1)

' Dim RESpixFindBaselines as Numa = LeptonicaSharp._All.pixFindBaselines(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindBaselines",TestPix, RESpixFindBaselines,{"Dim RESpixFindBaselines as Numa = LeptonicaSharp._All.pixFindBaselines(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixDeskewLocal as Pix = LeptonicaSharp._All.pixDeskewLocal(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeskewLocal",TestPix, RESpixDeskewLocal,{"Dim RESpixDeskewLocal as Pix = LeptonicaSharp._All.pixDeskewLocal(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetLocalSkewTransform as Integer = LeptonicaSharp._All.pixGetLocalSkewTransform(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,New Pta,New Pta)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetLocalSkewTransform",TestPix, RESpixGetLocalSkewTransform,{"Dim RESpixGetLocalSkewTransform as Integer = LeptonicaSharp._All.pixGetLocalSkewTransform(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,New Pta,New Pta)"},1)

' Dim RESpixGetLocalSkewAngles as Numa = LeptonicaSharp._All.pixGetLocalSkewAngles(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetLocalSkewAngles",TestPix, RESpixGetLocalSkewAngles,{"Dim RESpixGetLocalSkewAngles as Numa = LeptonicaSharp._All.pixGetLocalSkewAngles(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESbbufferCreate as L_ByteBuffer = LeptonicaSharp._All.bbufferCreate(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferCreate",TestPix, RESbbufferCreate,{"Dim RESbbufferCreate as L_ByteBuffer = LeptonicaSharp._All.bbufferCreate(Nothing ,TestPix )"},1)

' Dim RESbbufferDestroy as Object = LeptonicaSharp._All.bbufferDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferDestroy",TestPix, RESbbufferDestroy,{"Dim RESbbufferDestroy as Object = LeptonicaSharp._All.bbufferDestroy(TestPix )"},1)

' Dim RESbbufferDestroyAndSaveData as Byte() = LeptonicaSharp._All.bbufferDestroyAndSaveData(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferDestroyAndSaveData",TestPix, RESbbufferDestroyAndSaveData,{"Dim RESbbufferDestroyAndSaveData as Byte() = LeptonicaSharp._All.bbufferDestroyAndSaveData(TestPix ,New UInteger)"},1)

' Dim RESbbufferRead as Integer = LeptonicaSharp._All.bbufferRead(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferRead",TestPix, RESbbufferRead,{"Dim RESbbufferRead as Integer = LeptonicaSharp._All.bbufferRead(TestPix ,TestPix ,TestPix )"},1)

' Dim RESbbufferReadStream as Integer = LeptonicaSharp._All.bbufferReadStream(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferReadStream",TestPix, RESbbufferReadStream,{"Dim RESbbufferReadStream as Integer = LeptonicaSharp._All.bbufferReadStream(TestPix ,TestPix ,TestPix )"},1)

' Dim RESbbufferExtendArray as Integer = LeptonicaSharp._All.bbufferExtendArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferExtendArray",TestPix, RESbbufferExtendArray,{"Dim RESbbufferExtendArray as Integer = LeptonicaSharp._All.bbufferExtendArray(TestPix ,TestPix )"},1)

' Dim RESbbufferWrite as Integer = LeptonicaSharp._All.bbufferWrite(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferWrite",TestPix, RESbbufferWrite,{"Dim RESbbufferWrite as Integer = LeptonicaSharp._All.bbufferWrite(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESbbufferWriteStream as Integer = LeptonicaSharp._All.bbufferWriteStream(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("bbufferWriteStream",TestPix, RESbbufferWriteStream,{"Dim RESbbufferWriteStream as Integer = LeptonicaSharp._All.bbufferWriteStream(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixBilateral as Pix = LeptonicaSharp._All.pixBilateral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilateral",TestPix, RESpixBilateral,{"Dim RESpixBilateral as Pix = LeptonicaSharp._All.pixBilateral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilateralGray as Pix = LeptonicaSharp._All.pixBilateralGray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilateralGray",TestPix, RESpixBilateralGray,{"Dim RESpixBilateralGray as Pix = LeptonicaSharp._All.pixBilateralGray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilateralExact as Pix = LeptonicaSharp._All.pixBilateralExact(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilateralExact",TestPix, RESpixBilateralExact,{"Dim RESpixBilateralExact as Pix = LeptonicaSharp._All.pixBilateralExact(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixBilateralGrayExact as Pix = LeptonicaSharp._All.pixBilateralGrayExact(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilateralGrayExact",TestPix, RESpixBilateralGrayExact,{"Dim RESpixBilateralGrayExact as Pix = LeptonicaSharp._All.pixBilateralGrayExact(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixBlockBilateralExact as Pix = LeptonicaSharp._All.pixBlockBilateralExact(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockBilateralExact",TestPix, RESpixBlockBilateralExact,{"Dim RESpixBlockBilateralExact as Pix = LeptonicaSharp._All.pixBlockBilateralExact(TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeRangeKernel as L_Kernel = LeptonicaSharp._All.makeRangeKernel(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeRangeKernel",TestPix, RESmakeRangeKernel,{"Dim RESmakeRangeKernel as L_Kernel = LeptonicaSharp._All.makeRangeKernel(TestPix )"},1)

' Dim RESpixBilinearSampledPta as Pix = LeptonicaSharp._All.pixBilinearSampledPta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearSampledPta",TestPix, RESpixBilinearSampledPta,{"Dim RESpixBilinearSampledPta as Pix = LeptonicaSharp._All.pixBilinearSampledPta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearSampled as Pix = LeptonicaSharp._All.pixBilinearSampled(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearSampled",TestPix, RESpixBilinearSampled,{"Dim RESpixBilinearSampled as Pix = LeptonicaSharp._All.pixBilinearSampled(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearPta as Pix = LeptonicaSharp._All.pixBilinearPta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearPta",TestPix, RESpixBilinearPta,{"Dim RESpixBilinearPta as Pix = LeptonicaSharp._All.pixBilinearPta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinear as Pix = LeptonicaSharp._All.pixBilinear(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinear",TestPix, RESpixBilinear,{"Dim RESpixBilinear as Pix = LeptonicaSharp._All.pixBilinear(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearPtaColor as Pix = LeptonicaSharp._All.pixBilinearPtaColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearPtaColor",TestPix, RESpixBilinearPtaColor,{"Dim RESpixBilinearPtaColor as Pix = LeptonicaSharp._All.pixBilinearPtaColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearColor as Pix = LeptonicaSharp._All.pixBilinearColor(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearColor",TestPix, RESpixBilinearColor,{"Dim RESpixBilinearColor as Pix = LeptonicaSharp._All.pixBilinearColor(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearPtaGray as Pix = LeptonicaSharp._All.pixBilinearPtaGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearPtaGray",TestPix, RESpixBilinearPtaGray,{"Dim RESpixBilinearPtaGray as Pix = LeptonicaSharp._All.pixBilinearPtaGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearGray as Pix = LeptonicaSharp._All.pixBilinearGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearGray",TestPix, RESpixBilinearGray,{"Dim RESpixBilinearGray as Pix = LeptonicaSharp._All.pixBilinearGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBilinearPtaWithAlpha as Pix = LeptonicaSharp._All.pixBilinearPtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBilinearPtaWithAlpha",TestPix, RESpixBilinearPtaWithAlpha,{"Dim RESpixBilinearPtaWithAlpha as Pix = LeptonicaSharp._All.pixBilinearPtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESgetBilinearXformCoeffs as Integer = LeptonicaSharp._All.getBilinearXformCoeffs(TestPix ,TestPix ,New List(Of Single()))
' LeptonicaSharp.Convert.WriteHelpExtension ("getBilinearXformCoeffs",TestPix, RESgetBilinearXformCoeffs,{"Dim RESgetBilinearXformCoeffs as Integer = LeptonicaSharp._All.getBilinearXformCoeffs(TestPix ,TestPix ,New List(Of Single()))"},1)

' Dim RESbilinearXformSampledPt as Integer = LeptonicaSharp._All.bilinearXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("bilinearXformSampledPt",TestPix, RESbilinearXformSampledPt,{"Dim RESbilinearXformSampledPt as Integer = LeptonicaSharp._All.bilinearXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESbilinearXformPt as Integer = LeptonicaSharp._All.bilinearXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("bilinearXformPt",TestPix, RESbilinearXformPt,{"Dim RESbilinearXformPt as Integer = LeptonicaSharp._All.bilinearXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)"},1)

' Dim RESpixOtsuAdaptiveThreshold as Integer = LeptonicaSharp._All.pixOtsuAdaptiveThreshold(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOtsuAdaptiveThreshold",TestPix, RESpixOtsuAdaptiveThreshold,{"Dim RESpixOtsuAdaptiveThreshold as Integer = LeptonicaSharp._All.pixOtsuAdaptiveThreshold(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixOtsuThreshOnBackgroundNorm as Pix = LeptonicaSharp._All.pixOtsuThreshOnBackgroundNorm(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOtsuThreshOnBackgroundNorm",TestPix, RESpixOtsuThreshOnBackgroundNorm,{"Dim RESpixOtsuThreshOnBackgroundNorm as Pix = LeptonicaSharp._All.pixOtsuThreshOnBackgroundNorm(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixMaskedThreshOnBackgroundNorm as Pix = LeptonicaSharp._All.pixMaskedThreshOnBackgroundNorm(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaskedThreshOnBackgroundNorm",TestPix, RESpixMaskedThreshOnBackgroundNorm,{"Dim RESpixMaskedThreshOnBackgroundNorm as Pix = LeptonicaSharp._All.pixMaskedThreshOnBackgroundNorm(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSauvolaBinarizeTiled as Integer = LeptonicaSharp._All.pixSauvolaBinarizeTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSauvolaBinarizeTiled",TestPix, RESpixSauvolaBinarizeTiled,{"Dim RESpixSauvolaBinarizeTiled as Integer = LeptonicaSharp._All.pixSauvolaBinarizeTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixSauvolaBinarize as Integer = LeptonicaSharp._All.pixSauvolaBinarize(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSauvolaBinarize",TestPix, RESpixSauvolaBinarize,{"Dim RESpixSauvolaBinarize as Integer = LeptonicaSharp._All.pixSauvolaBinarize(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixSauvolaGetThreshold as Pix = LeptonicaSharp._All.pixSauvolaGetThreshold(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSauvolaGetThreshold",TestPix, RESpixSauvolaGetThreshold,{"Dim RESpixSauvolaGetThreshold as Pix = LeptonicaSharp._All.pixSauvolaGetThreshold(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixApplyLocalThreshold as Pix = LeptonicaSharp._All.pixApplyLocalThreshold(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixApplyLocalThreshold",TestPix, RESpixApplyLocalThreshold,{"Dim RESpixApplyLocalThreshold as Pix = LeptonicaSharp._All.pixApplyLocalThreshold(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdByConnComp as Integer = LeptonicaSharp._All.pixThresholdByConnComp(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdByConnComp",TestPix, RESpixThresholdByConnComp,{"Dim RESpixThresholdByConnComp as Integer = LeptonicaSharp._All.pixThresholdByConnComp(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixExpandBinaryReplicate as Pix = LeptonicaSharp._All.pixExpandBinaryReplicate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExpandBinaryReplicate",TestPix, RESpixExpandBinaryReplicate,{"Dim RESpixExpandBinaryReplicate as Pix = LeptonicaSharp._All.pixExpandBinaryReplicate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixExpandBinaryPower2 as Pix = LeptonicaSharp._All.pixExpandBinaryPower2(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExpandBinaryPower2",TestPix, RESpixExpandBinaryPower2,{"Dim RESpixExpandBinaryPower2 as Pix = LeptonicaSharp._All.pixExpandBinaryPower2(TestPix ,TestPix )"},1)

' Dim RESpixReduceBinary2 as Pix = LeptonicaSharp._All.pixReduceBinary2(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReduceBinary2",TestPix, RESpixReduceBinary2,{"Dim RESpixReduceBinary2 as Pix = LeptonicaSharp._All.pixReduceBinary2(TestPix ,Nothing )"},1)

' Dim RESpixReduceRankBinaryCascade as Pix = LeptonicaSharp._All.pixReduceRankBinaryCascade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReduceRankBinaryCascade",TestPix, RESpixReduceRankBinaryCascade,{"Dim RESpixReduceRankBinaryCascade as Pix = LeptonicaSharp._All.pixReduceRankBinaryCascade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReduceRankBinary2 as Pix = LeptonicaSharp._All.pixReduceRankBinary2(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReduceRankBinary2",TestPix, RESpixReduceRankBinary2,{"Dim RESpixReduceRankBinary2 as Pix = LeptonicaSharp._All.pixReduceRankBinary2(TestPix ,TestPix ,Nothing )"},1)

' Dim RESmakeSubsampleTab2x as Byte() = LeptonicaSharp._All.makeSubsampleTab2x()
' LeptonicaSharp.Convert.WriteHelpExtension ("makeSubsampleTab2x",TestPix, RESmakeSubsampleTab2x,{"Dim RESmakeSubsampleTab2x as Byte() = LeptonicaSharp._All.makeSubsampleTab2x()"},1)

' Dim RESpixBlend as Pix = LeptonicaSharp._All.pixBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlend",TestPix, RESpixBlend,{"Dim RESpixBlend as Pix = LeptonicaSharp._All.pixBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendMask as Pix = LeptonicaSharp._All.pixBlendMask(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendMask",TestPix, RESpixBlendMask,{"Dim RESpixBlendMask as Pix = LeptonicaSharp._All.pixBlendMask(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendGray as Pix = LeptonicaSharp._All.pixBlendGray(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendGray",TestPix, RESpixBlendGray,{"Dim RESpixBlendGray as Pix = LeptonicaSharp._All.pixBlendGray(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendGrayInverse as Pix = LeptonicaSharp._All.pixBlendGrayInverse(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendGrayInverse",TestPix, RESpixBlendGrayInverse,{"Dim RESpixBlendGrayInverse as Pix = LeptonicaSharp._All.pixBlendGrayInverse(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendColor as Pix = LeptonicaSharp._All.pixBlendColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendColor",TestPix, RESpixBlendColor,{"Dim RESpixBlendColor as Pix = LeptonicaSharp._All.pixBlendColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendColorByChannel as Pix = LeptonicaSharp._All.pixBlendColorByChannel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendColorByChannel",TestPix, RESpixBlendColorByChannel,{"Dim RESpixBlendColorByChannel as Pix = LeptonicaSharp._All.pixBlendColorByChannel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendGrayAdapt as Pix = LeptonicaSharp._All.pixBlendGrayAdapt(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendGrayAdapt",TestPix, RESpixBlendGrayAdapt,{"Dim RESpixBlendGrayAdapt as Pix = LeptonicaSharp._All.pixBlendGrayAdapt(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFadeWithGray as Pix = LeptonicaSharp._All.pixFadeWithGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFadeWithGray",TestPix, RESpixFadeWithGray,{"Dim RESpixFadeWithGray as Pix = LeptonicaSharp._All.pixFadeWithGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendHardLight as Pix = LeptonicaSharp._All.pixBlendHardLight(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendHardLight",TestPix, RESpixBlendHardLight,{"Dim RESpixBlendHardLight as Pix = LeptonicaSharp._All.pixBlendHardLight(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendCmap as Integer = LeptonicaSharp._All.pixBlendCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendCmap",TestPix, RESpixBlendCmap,{"Dim RESpixBlendCmap as Integer = LeptonicaSharp._All.pixBlendCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendWithGrayMask as Pix = LeptonicaSharp._All.pixBlendWithGrayMask(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendWithGrayMask",TestPix, RESpixBlendWithGrayMask,{"Dim RESpixBlendWithGrayMask as Pix = LeptonicaSharp._All.pixBlendWithGrayMask(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixBlendBackgroundToColor as Pix = LeptonicaSharp._All.pixBlendBackgroundToColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendBackgroundToColor",TestPix, RESpixBlendBackgroundToColor,{"Dim RESpixBlendBackgroundToColor as Pix = LeptonicaSharp._All.pixBlendBackgroundToColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMultiplyByColor as Pix = LeptonicaSharp._All.pixMultiplyByColor(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMultiplyByColor",TestPix, RESpixMultiplyByColor,{"Dim RESpixMultiplyByColor as Pix = LeptonicaSharp._All.pixMultiplyByColor(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAlphaBlendUniform as Pix = LeptonicaSharp._All.pixAlphaBlendUniform(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAlphaBlendUniform",TestPix, RESpixAlphaBlendUniform,{"Dim RESpixAlphaBlendUniform as Pix = LeptonicaSharp._All.pixAlphaBlendUniform(TestPix ,TestPix )"},1)

' Dim RESpixAddAlphaToBlend as Pix = LeptonicaSharp._All.pixAddAlphaToBlend(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddAlphaToBlend",TestPix, RESpixAddAlphaToBlend,{"Dim RESpixAddAlphaToBlend as Pix = LeptonicaSharp._All.pixAddAlphaToBlend(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetAlphaOverWhite as Pix = LeptonicaSharp._All.pixSetAlphaOverWhite(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetAlphaOverWhite",TestPix, RESpixSetAlphaOverWhite,{"Dim RESpixSetAlphaOverWhite as Pix = LeptonicaSharp._All.pixSetAlphaOverWhite(TestPix )"},1)

' Dim RESpixLinearEdgeFade as Integer = LeptonicaSharp._All.pixLinearEdgeFade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLinearEdgeFade",TestPix, RESpixLinearEdgeFade,{"Dim RESpixLinearEdgeFade as Integer = LeptonicaSharp._All.pixLinearEdgeFade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESbmfCreate as L_Bmf = LeptonicaSharp._All.bmfCreate(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfCreate",TestPix, RESbmfCreate,{"Dim RESbmfCreate as L_Bmf = LeptonicaSharp._All.bmfCreate(Nothing ,TestPix )"},1)

' Dim RESbmfDestroy as Object = LeptonicaSharp._All.bmfDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfDestroy",TestPix, RESbmfDestroy,{"Dim RESbmfDestroy as Object = LeptonicaSharp._All.bmfDestroy(TestPix )"},1)

' Dim RESbmfGetPix as Pix = LeptonicaSharp._All.bmfGetPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetPix",TestPix, RESbmfGetPix,{"Dim RESbmfGetPix as Pix = LeptonicaSharp._All.bmfGetPix(TestPix ,TestPix )"},1)

' Dim RESbmfGetWidth as Integer = LeptonicaSharp._All.bmfGetWidth(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetWidth",TestPix, RESbmfGetWidth,{"Dim RESbmfGetWidth as Integer = LeptonicaSharp._All.bmfGetWidth(TestPix ,TestPix ,New Integer)"},1)

' Dim RESbmfGetBaseline as Integer = LeptonicaSharp._All.bmfGetBaseline(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetBaseline",TestPix, RESbmfGetBaseline,{"Dim RESbmfGetBaseline as Integer = LeptonicaSharp._All.bmfGetBaseline(TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixaGetFont as Pixa = LeptonicaSharp._All.pixaGetFont(TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetFont",TestPix, RESpixaGetFont,{"Dim RESpixaGetFont as Pixa = LeptonicaSharp._All.pixaGetFont(TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixaSaveFont as Integer = LeptonicaSharp._All.pixaSaveFont(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSaveFont",TestPix, RESpixaSaveFont,{"Dim RESpixaSaveFont as Integer = LeptonicaSharp._All.pixaSaveFont(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixReadStreamBmp as Pix = LeptonicaSharp._All.pixReadStreamBmp(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamBmp",TestPix, RESpixReadStreamBmp,{"Dim RESpixReadStreamBmp as Pix = LeptonicaSharp._All.pixReadStreamBmp(TestPix )"},1)

' Dim RESpixReadMemBmp as Pix = LeptonicaSharp._All.pixReadMemBmp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemBmp",TestPix, RESpixReadMemBmp,{"Dim RESpixReadMemBmp as Pix = LeptonicaSharp._All.pixReadMemBmp(TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamBmp as Integer = LeptonicaSharp._All.pixWriteStreamBmp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamBmp",TestPix, RESpixWriteStreamBmp,{"Dim RESpixWriteStreamBmp as Integer = LeptonicaSharp._All.pixWriteStreamBmp(TestPix ,TestPix )"},1)

' Dim RESpixWriteMemBmp as Integer = LeptonicaSharp._All.pixWriteMemBmp(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemBmp",TestPix, RESpixWriteMemBmp,{"Dim RESpixWriteMemBmp as Integer = LeptonicaSharp._All.pixWriteMemBmp(New Byte(),New UInteger,TestPix )"},1)

' Dim RESl_bootnum_gen1 as Pixa = LeptonicaSharp._All.l_bootnum_gen1()
' LeptonicaSharp.Convert.WriteHelpExtension ("l_bootnum_gen1",TestPix, RESl_bootnum_gen1,{"Dim RESl_bootnum_gen1 as Pixa = LeptonicaSharp._All.l_bootnum_gen1()"},1)

' Dim RESl_bootnum_gen2 as Pixa = LeptonicaSharp._All.l_bootnum_gen2()
' LeptonicaSharp.Convert.WriteHelpExtension ("l_bootnum_gen2",TestPix, RESl_bootnum_gen2,{"Dim RESl_bootnum_gen2 as Pixa = LeptonicaSharp._All.l_bootnum_gen2()"},1)

' Dim RESl_bootnum_gen3 as Pixa = LeptonicaSharp._All.l_bootnum_gen3()
' LeptonicaSharp.Convert.WriteHelpExtension ("l_bootnum_gen3",TestPix, RESl_bootnum_gen3,{"Dim RESl_bootnum_gen3 as Pixa = LeptonicaSharp._All.l_bootnum_gen3()"},1)

' Dim RESboxCreate as Box = LeptonicaSharp._All.boxCreate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxCreate",TestPix, RESboxCreate,{"Dim RESboxCreate as Box = LeptonicaSharp._All.boxCreate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxCreateValid as Box = LeptonicaSharp._All.boxCreateValid(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxCreateValid",TestPix, RESboxCreateValid,{"Dim RESboxCreateValid as Box = LeptonicaSharp._All.boxCreateValid(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxCopy as Box = LeptonicaSharp._All.boxCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxCopy",TestPix, RESboxCopy,{"Dim RESboxCopy as Box = LeptonicaSharp._All.boxCopy(TestPix )"},1)

' Dim RESboxClone as Box = LeptonicaSharp._All.boxClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxClone",TestPix, RESboxClone,{"Dim RESboxClone as Box = LeptonicaSharp._All.boxClone(TestPix )"},1)

' Dim RESboxDestroy as Object = LeptonicaSharp._All.boxDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxDestroy",TestPix, RESboxDestroy,{"Dim RESboxDestroy as Object = LeptonicaSharp._All.boxDestroy(TestPix )"},1)

' Dim RESboxGetGeometry as Integer = LeptonicaSharp._All.boxGetGeometry(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxGetGeometry",TestPix, RESboxGetGeometry,{"Dim RESboxGetGeometry as Integer = LeptonicaSharp._All.boxGetGeometry(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxSetGeometry as Integer = LeptonicaSharp._All.boxSetGeometry(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxSetGeometry",TestPix, RESboxSetGeometry,{"Dim RESboxSetGeometry as Integer = LeptonicaSharp._All.boxSetGeometry(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxGetSideLocations as Integer = LeptonicaSharp._All.boxGetSideLocations(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxGetSideLocations",TestPix, RESboxGetSideLocations,{"Dim RESboxGetSideLocations as Integer = LeptonicaSharp._All.boxGetSideLocations(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxSetSideLocations as Integer = LeptonicaSharp._All.boxSetSideLocations(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxSetSideLocations",TestPix, RESboxSetSideLocations,{"Dim RESboxSetSideLocations as Integer = LeptonicaSharp._All.boxSetSideLocations(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxGetRefcount as Integer = LeptonicaSharp._All.boxGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxGetRefcount",TestPix, RESboxGetRefcount,{"Dim RESboxGetRefcount as Integer = LeptonicaSharp._All.boxGetRefcount(TestPix )"},1)

' Dim RESboxChangeRefcount as Integer = LeptonicaSharp._All.boxChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxChangeRefcount",TestPix, RESboxChangeRefcount,{"Dim RESboxChangeRefcount as Integer = LeptonicaSharp._All.boxChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESboxIsValid as Integer = LeptonicaSharp._All.boxIsValid(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxIsValid",TestPix, RESboxIsValid,{"Dim RESboxIsValid as Integer = LeptonicaSharp._All.boxIsValid(TestPix ,New Integer)"},1)

' Dim RESboxaCreate as Boxa = LeptonicaSharp._All.boxaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaCreate",TestPix, RESboxaCreate,{"Dim RESboxaCreate as Boxa = LeptonicaSharp._All.boxaCreate(TestPix )"},1)

' Dim RESboxaCopy as Boxa = LeptonicaSharp._All.boxaCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaCopy",TestPix, RESboxaCopy,{"Dim RESboxaCopy as Boxa = LeptonicaSharp._All.boxaCopy(TestPix ,TestPix )"},1)

' Dim RESboxaDestroy as Object = LeptonicaSharp._All.boxaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaDestroy",TestPix, RESboxaDestroy,{"Dim RESboxaDestroy as Object = LeptonicaSharp._All.boxaDestroy(TestPix )"},1)

' Dim RESboxaAddBox as Integer = LeptonicaSharp._All.boxaAddBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaAddBox",TestPix, RESboxaAddBox,{"Dim RESboxaAddBox as Integer = LeptonicaSharp._All.boxaAddBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaExtendArray as Integer = LeptonicaSharp._All.boxaExtendArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaExtendArray",TestPix, RESboxaExtendArray,{"Dim RESboxaExtendArray as Integer = LeptonicaSharp._All.boxaExtendArray(TestPix )"},1)

' Dim RESboxaExtendArrayToSize as Integer = LeptonicaSharp._All.boxaExtendArrayToSize(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaExtendArrayToSize",TestPix, RESboxaExtendArrayToSize,{"Dim RESboxaExtendArrayToSize as Integer = LeptonicaSharp._All.boxaExtendArrayToSize(TestPix ,TestPix )"},1)

' Dim RESboxaGetCount as Integer = LeptonicaSharp._All.boxaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetCount",TestPix, RESboxaGetCount,{"Dim RESboxaGetCount as Integer = LeptonicaSharp._All.boxaGetCount(TestPix )"},1)

' Dim RESboxaGetValidCount as Integer = LeptonicaSharp._All.boxaGetValidCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetValidCount",TestPix, RESboxaGetValidCount,{"Dim RESboxaGetValidCount as Integer = LeptonicaSharp._All.boxaGetValidCount(TestPix )"},1)

' Dim RESboxaGetBox as Box = LeptonicaSharp._All.boxaGetBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetBox",TestPix, RESboxaGetBox,{"Dim RESboxaGetBox as Box = LeptonicaSharp._All.boxaGetBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaGetValidBox as Box = LeptonicaSharp._All.boxaGetValidBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetValidBox",TestPix, RESboxaGetValidBox,{"Dim RESboxaGetValidBox as Box = LeptonicaSharp._All.boxaGetValidBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaFindInvalidBoxes as Numa = LeptonicaSharp._All.boxaFindInvalidBoxes(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaFindInvalidBoxes",TestPix, RESboxaFindInvalidBoxes,{"Dim RESboxaFindInvalidBoxes as Numa = LeptonicaSharp._All.boxaFindInvalidBoxes(TestPix )"},1)

' Dim RESboxaGetBoxGeometry as Integer = LeptonicaSharp._All.boxaGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetBoxGeometry",TestPix, RESboxaGetBoxGeometry,{"Dim RESboxaGetBoxGeometry as Integer = LeptonicaSharp._All.boxaGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaIsFull as Integer = LeptonicaSharp._All.boxaIsFull(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaIsFull",TestPix, RESboxaIsFull,{"Dim RESboxaIsFull as Integer = LeptonicaSharp._All.boxaIsFull(TestPix ,New Integer)"},1)

' Dim RESboxaReplaceBox as Integer = LeptonicaSharp._All.boxaReplaceBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaReplaceBox",TestPix, RESboxaReplaceBox,{"Dim RESboxaReplaceBox as Integer = LeptonicaSharp._All.boxaReplaceBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaInsertBox as Integer = LeptonicaSharp._All.boxaInsertBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaInsertBox",TestPix, RESboxaInsertBox,{"Dim RESboxaInsertBox as Integer = LeptonicaSharp._All.boxaInsertBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaRemoveBox as Integer = LeptonicaSharp._All.boxaRemoveBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaRemoveBox",TestPix, RESboxaRemoveBox,{"Dim RESboxaRemoveBox as Integer = LeptonicaSharp._All.boxaRemoveBox(TestPix ,TestPix )"},1)

' Dim RESboxaRemoveBoxAndSave as Integer = LeptonicaSharp._All.boxaRemoveBoxAndSave(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaRemoveBoxAndSave",TestPix, RESboxaRemoveBoxAndSave,{"Dim RESboxaRemoveBoxAndSave as Integer = LeptonicaSharp._All.boxaRemoveBoxAndSave(TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaSaveValid as Boxa = LeptonicaSharp._All.boxaSaveValid(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSaveValid",TestPix, RESboxaSaveValid,{"Dim RESboxaSaveValid as Boxa = LeptonicaSharp._All.boxaSaveValid(TestPix ,TestPix )"},1)

' Dim RESboxaInitFull as Integer = LeptonicaSharp._All.boxaInitFull(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaInitFull",TestPix, RESboxaInitFull,{"Dim RESboxaInitFull as Integer = LeptonicaSharp._All.boxaInitFull(TestPix ,Nothing )"},1)

' Dim RESboxaClear as Integer = LeptonicaSharp._All.boxaClear(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaClear",TestPix, RESboxaClear,{"Dim RESboxaClear as Integer = LeptonicaSharp._All.boxaClear(TestPix )"},1)

' Dim RESboxaaCreate as Boxaa = LeptonicaSharp._All.boxaaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaCreate",TestPix, RESboxaaCreate,{"Dim RESboxaaCreate as Boxaa = LeptonicaSharp._All.boxaaCreate(TestPix )"},1)

' Dim RESboxaaCopy as Boxaa = LeptonicaSharp._All.boxaaCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaCopy",TestPix, RESboxaaCopy,{"Dim RESboxaaCopy as Boxaa = LeptonicaSharp._All.boxaaCopy(TestPix ,TestPix )"},1)

' Dim RESboxaaDestroy as Object = LeptonicaSharp._All.boxaaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaDestroy",TestPix, RESboxaaDestroy,{"Dim RESboxaaDestroy as Object = LeptonicaSharp._All.boxaaDestroy(TestPix )"},1)

' Dim RESboxaaAddBoxa as Integer = LeptonicaSharp._All.boxaaAddBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaAddBoxa",TestPix, RESboxaaAddBoxa,{"Dim RESboxaaAddBoxa as Integer = LeptonicaSharp._All.boxaaAddBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaExtendArray as Integer = LeptonicaSharp._All.boxaaExtendArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaExtendArray",TestPix, RESboxaaExtendArray,{"Dim RESboxaaExtendArray as Integer = LeptonicaSharp._All.boxaaExtendArray(TestPix )"},1)

' Dim RESboxaaExtendArrayToSize as Integer = LeptonicaSharp._All.boxaaExtendArrayToSize(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaExtendArrayToSize",TestPix, RESboxaaExtendArrayToSize,{"Dim RESboxaaExtendArrayToSize as Integer = LeptonicaSharp._All.boxaaExtendArrayToSize(TestPix ,TestPix )"},1)

' Dim RESboxaaGetCount as Integer = LeptonicaSharp._All.boxaaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaGetCount",TestPix, RESboxaaGetCount,{"Dim RESboxaaGetCount as Integer = LeptonicaSharp._All.boxaaGetCount(TestPix )"},1)

' Dim RESboxaaGetBoxCount as Integer = LeptonicaSharp._All.boxaaGetBoxCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaGetBoxCount",TestPix, RESboxaaGetBoxCount,{"Dim RESboxaaGetBoxCount as Integer = LeptonicaSharp._All.boxaaGetBoxCount(TestPix )"},1)

' Dim RESboxaaGetBoxa as Boxa = LeptonicaSharp._All.boxaaGetBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaGetBoxa",TestPix, RESboxaaGetBoxa,{"Dim RESboxaaGetBoxa as Boxa = LeptonicaSharp._All.boxaaGetBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaGetBox as Box = LeptonicaSharp._All.boxaaGetBox(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaGetBox",TestPix, RESboxaaGetBox,{"Dim RESboxaaGetBox as Box = LeptonicaSharp._All.boxaaGetBox(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaInitFull as Integer = LeptonicaSharp._All.boxaaInitFull(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaInitFull",TestPix, RESboxaaInitFull,{"Dim RESboxaaInitFull as Integer = LeptonicaSharp._All.boxaaInitFull(TestPix ,TestPix )"},1)

' Dim RESboxaaExtendWithInit as Integer = LeptonicaSharp._All.boxaaExtendWithInit(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaExtendWithInit",TestPix, RESboxaaExtendWithInit,{"Dim RESboxaaExtendWithInit as Integer = LeptonicaSharp._All.boxaaExtendWithInit(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaReplaceBoxa as Integer = LeptonicaSharp._All.boxaaReplaceBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaReplaceBoxa",TestPix, RESboxaaReplaceBoxa,{"Dim RESboxaaReplaceBoxa as Integer = LeptonicaSharp._All.boxaaReplaceBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaInsertBoxa as Integer = LeptonicaSharp._All.boxaaInsertBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaInsertBoxa",TestPix, RESboxaaInsertBoxa,{"Dim RESboxaaInsertBoxa as Integer = LeptonicaSharp._All.boxaaInsertBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaRemoveBoxa as Integer = LeptonicaSharp._All.boxaaRemoveBoxa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaRemoveBoxa",TestPix, RESboxaaRemoveBoxa,{"Dim RESboxaaRemoveBoxa as Integer = LeptonicaSharp._All.boxaaRemoveBoxa(TestPix ,TestPix )"},1)

' Dim RESboxaaAddBox as Integer = LeptonicaSharp._All.boxaaAddBox(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaAddBox",TestPix, RESboxaaAddBox,{"Dim RESboxaaAddBox as Integer = LeptonicaSharp._All.boxaaAddBox(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaReadFromFiles as Boxaa = LeptonicaSharp._All.boxaaReadFromFiles(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaReadFromFiles",TestPix, RESboxaaReadFromFiles,{"Dim RESboxaaReadFromFiles as Boxaa = LeptonicaSharp._All.boxaaReadFromFiles(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESboxaaRead as Boxaa = LeptonicaSharp._All.boxaaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaRead",TestPix, RESboxaaRead,{"Dim RESboxaaRead as Boxaa = LeptonicaSharp._All.boxaaRead(TestPix )"},1)

' Dim RESboxaaReadStream as Boxaa = LeptonicaSharp._All.boxaaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaReadStream",TestPix, RESboxaaReadStream,{"Dim RESboxaaReadStream as Boxaa = LeptonicaSharp._All.boxaaReadStream(TestPix )"},1)

' Dim RESboxaaReadMem as Boxaa = LeptonicaSharp._All.boxaaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaReadMem",TestPix, RESboxaaReadMem,{"Dim RESboxaaReadMem as Boxaa = LeptonicaSharp._All.boxaaReadMem(TestPix ,TestPix )"},1)

' Dim RESboxaaWrite as Integer = LeptonicaSharp._All.boxaaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaWrite",TestPix, RESboxaaWrite,{"Dim RESboxaaWrite as Integer = LeptonicaSharp._All.boxaaWrite(TestPix ,TestPix )"},1)

' Dim RESboxaaWriteStream as Integer = LeptonicaSharp._All.boxaaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaWriteStream",TestPix, RESboxaaWriteStream,{"Dim RESboxaaWriteStream as Integer = LeptonicaSharp._All.boxaaWriteStream(TestPix ,TestPix )"},1)

' Dim RESboxaaWriteMem as Integer = LeptonicaSharp._All.boxaaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaWriteMem",TestPix, RESboxaaWriteMem,{"Dim RESboxaaWriteMem as Integer = LeptonicaSharp._All.boxaaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESboxaRead as Boxa = LeptonicaSharp._All.boxaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaRead",TestPix, RESboxaRead,{"Dim RESboxaRead as Boxa = LeptonicaSharp._All.boxaRead(TestPix )"},1)

' Dim RESboxaReadStream as Boxa = LeptonicaSharp._All.boxaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaReadStream",TestPix, RESboxaReadStream,{"Dim RESboxaReadStream as Boxa = LeptonicaSharp._All.boxaReadStream(TestPix )"},1)

' Dim RESboxaReadMem as Boxa = LeptonicaSharp._All.boxaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaReadMem",TestPix, RESboxaReadMem,{"Dim RESboxaReadMem as Boxa = LeptonicaSharp._All.boxaReadMem(TestPix ,TestPix )"},1)

' Dim RESboxaWriteDebug as Integer = LeptonicaSharp._All.boxaWriteDebug(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaWriteDebug",TestPix, RESboxaWriteDebug,{"Dim RESboxaWriteDebug as Integer = LeptonicaSharp._All.boxaWriteDebug(TestPix ,TestPix )"},1)

' Dim RESboxaWrite as Integer = LeptonicaSharp._All.boxaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaWrite",TestPix, RESboxaWrite,{"Dim RESboxaWrite as Integer = LeptonicaSharp._All.boxaWrite(TestPix ,TestPix )"},1)

' Dim RESboxaWriteStream as Integer = LeptonicaSharp._All.boxaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaWriteStream",TestPix, RESboxaWriteStream,{"Dim RESboxaWriteStream as Integer = LeptonicaSharp._All.boxaWriteStream(TestPix ,TestPix )"},1)

' Dim RESboxaWriteMem as Integer = LeptonicaSharp._All.boxaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaWriteMem",TestPix, RESboxaWriteMem,{"Dim RESboxaWriteMem as Integer = LeptonicaSharp._All.boxaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESboxPrintStreamInfo as Integer = LeptonicaSharp._All.boxPrintStreamInfo(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxPrintStreamInfo",TestPix, RESboxPrintStreamInfo,{"Dim RESboxPrintStreamInfo as Integer = LeptonicaSharp._All.boxPrintStreamInfo(TestPix ,TestPix )"},1)

' Dim RESboxContains as Integer = LeptonicaSharp._All.boxContains(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxContains",TestPix, RESboxContains,{"Dim RESboxContains as Integer = LeptonicaSharp._All.boxContains(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxIntersects as Integer = LeptonicaSharp._All.boxIntersects(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxIntersects",TestPix, RESboxIntersects,{"Dim RESboxIntersects as Integer = LeptonicaSharp._All.boxIntersects(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaContainedInBox as Boxa = LeptonicaSharp._All.boxaContainedInBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaContainedInBox",TestPix, RESboxaContainedInBox,{"Dim RESboxaContainedInBox as Boxa = LeptonicaSharp._All.boxaContainedInBox(TestPix ,TestPix )"},1)

' Dim RESboxaContainedInBoxCount as Integer = LeptonicaSharp._All.boxaContainedInBoxCount(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaContainedInBoxCount",TestPix, RESboxaContainedInBoxCount,{"Dim RESboxaContainedInBoxCount as Integer = LeptonicaSharp._All.boxaContainedInBoxCount(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaContainedInBoxa as Integer = LeptonicaSharp._All.boxaContainedInBoxa(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaContainedInBoxa",TestPix, RESboxaContainedInBoxa,{"Dim RESboxaContainedInBoxa as Integer = LeptonicaSharp._All.boxaContainedInBoxa(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaIntersectsBox as Boxa = LeptonicaSharp._All.boxaIntersectsBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaIntersectsBox",TestPix, RESboxaIntersectsBox,{"Dim RESboxaIntersectsBox as Boxa = LeptonicaSharp._All.boxaIntersectsBox(TestPix ,TestPix )"},1)

' Dim RESboxaIntersectsBoxCount as Integer = LeptonicaSharp._All.boxaIntersectsBoxCount(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaIntersectsBoxCount",TestPix, RESboxaIntersectsBoxCount,{"Dim RESboxaIntersectsBoxCount as Integer = LeptonicaSharp._All.boxaIntersectsBoxCount(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaClipToBox as Boxa = LeptonicaSharp._All.boxaClipToBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaClipToBox",TestPix, RESboxaClipToBox,{"Dim RESboxaClipToBox as Boxa = LeptonicaSharp._All.boxaClipToBox(TestPix ,TestPix )"},1)

' Dim RESboxaCombineOverlaps as Boxa = LeptonicaSharp._All.boxaCombineOverlaps(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaCombineOverlaps",TestPix, RESboxaCombineOverlaps,{"Dim RESboxaCombineOverlaps as Boxa = LeptonicaSharp._All.boxaCombineOverlaps(TestPix ,TestPix )"},1)

' Dim RESboxaCombineOverlapsInPair as Integer = LeptonicaSharp._All.boxaCombineOverlapsInPair(TestPix ,TestPix ,New Boxa,New Boxa,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaCombineOverlapsInPair",TestPix, RESboxaCombineOverlapsInPair,{"Dim RESboxaCombineOverlapsInPair as Integer = LeptonicaSharp._All.boxaCombineOverlapsInPair(TestPix ,TestPix ,New Boxa,New Boxa,TestPix )"},1)

' Dim RESboxOverlapRegion as Box = LeptonicaSharp._All.boxOverlapRegion(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxOverlapRegion",TestPix, RESboxOverlapRegion,{"Dim RESboxOverlapRegion as Box = LeptonicaSharp._All.boxOverlapRegion(TestPix ,TestPix )"},1)

' Dim RESboxBoundingRegion as Box = LeptonicaSharp._All.boxBoundingRegion(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxBoundingRegion",TestPix, RESboxBoundingRegion,{"Dim RESboxBoundingRegion as Box = LeptonicaSharp._All.boxBoundingRegion(TestPix ,TestPix )"},1)

' Dim RESboxOverlapFraction as Integer = LeptonicaSharp._All.boxOverlapFraction(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxOverlapFraction",TestPix, RESboxOverlapFraction,{"Dim RESboxOverlapFraction as Integer = LeptonicaSharp._All.boxOverlapFraction(TestPix ,TestPix ,New Single)"},1)

' Dim RESboxOverlapArea as Integer = LeptonicaSharp._All.boxOverlapArea(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxOverlapArea",TestPix, RESboxOverlapArea,{"Dim RESboxOverlapArea as Integer = LeptonicaSharp._All.boxOverlapArea(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaHandleOverlaps as Boxa = LeptonicaSharp._All.boxaHandleOverlaps(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaHandleOverlaps",TestPix, RESboxaHandleOverlaps,{"Dim RESboxaHandleOverlaps as Boxa = LeptonicaSharp._All.boxaHandleOverlaps(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxSeparationDistance as Integer = LeptonicaSharp._All.boxSeparationDistance(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxSeparationDistance",TestPix, RESboxSeparationDistance,{"Dim RESboxSeparationDistance as Integer = LeptonicaSharp._All.boxSeparationDistance(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxCompareSize as Integer = LeptonicaSharp._All.boxCompareSize(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxCompareSize",TestPix, RESboxCompareSize,{"Dim RESboxCompareSize as Integer = LeptonicaSharp._All.boxCompareSize(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxContainsPt as Integer = LeptonicaSharp._All.boxContainsPt(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxContainsPt",TestPix, RESboxContainsPt,{"Dim RESboxContainsPt as Integer = LeptonicaSharp._All.boxContainsPt(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaGetNearestToPt as Box = LeptonicaSharp._All.boxaGetNearestToPt(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetNearestToPt",TestPix, RESboxaGetNearestToPt,{"Dim RESboxaGetNearestToPt as Box = LeptonicaSharp._All.boxaGetNearestToPt(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaGetNearestToLine as Box = LeptonicaSharp._All.boxaGetNearestToLine(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetNearestToLine",TestPix, RESboxaGetNearestToLine,{"Dim RESboxaGetNearestToLine as Box = LeptonicaSharp._All.boxaGetNearestToLine(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaFindNearestBoxes as Integer = LeptonicaSharp._All.boxaFindNearestBoxes(TestPix ,TestPix ,TestPix ,New Numaa,New Numaa)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaFindNearestBoxes",TestPix, RESboxaFindNearestBoxes,{"Dim RESboxaFindNearestBoxes as Integer = LeptonicaSharp._All.boxaFindNearestBoxes(TestPix ,TestPix ,TestPix ,New Numaa,New Numaa)"},1)

' Dim RESboxaGetNearestByDirection as Integer = LeptonicaSharp._All.boxaGetNearestByDirection(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetNearestByDirection",TestPix, RESboxaGetNearestByDirection,{"Dim RESboxaGetNearestByDirection as Integer = LeptonicaSharp._All.boxaGetNearestByDirection(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESboxGetCenter as Integer = LeptonicaSharp._All.boxGetCenter(TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxGetCenter",TestPix, RESboxGetCenter,{"Dim RESboxGetCenter as Integer = LeptonicaSharp._All.boxGetCenter(TestPix ,New Single,New Single)"},1)

' Dim RESboxIntersectByLine as Integer = LeptonicaSharp._All.boxIntersectByLine(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxIntersectByLine",TestPix, RESboxIntersectByLine,{"Dim RESboxIntersectByLine as Integer = LeptonicaSharp._All.boxIntersectByLine(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer,New Integer)"},1)

' Dim RESboxClipToRectangle as Box = LeptonicaSharp._All.boxClipToRectangle(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxClipToRectangle",TestPix, RESboxClipToRectangle,{"Dim RESboxClipToRectangle as Box = LeptonicaSharp._All.boxClipToRectangle(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxClipToRectangleParams as Integer = LeptonicaSharp._All.boxClipToRectangleParams(Nothing ,TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxClipToRectangleParams",TestPix, RESboxClipToRectangleParams,{"Dim RESboxClipToRectangleParams as Integer = LeptonicaSharp._All.boxClipToRectangleParams(Nothing ,TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing ,Nothing )"},1)

' Dim RESboxRelocateOneSide as Box = LeptonicaSharp._All.boxRelocateOneSide(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxRelocateOneSide",TestPix, RESboxRelocateOneSide,{"Dim RESboxRelocateOneSide as Box = LeptonicaSharp._All.boxRelocateOneSide(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaAdjustSides as Boxa = LeptonicaSharp._All.boxaAdjustSides(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaAdjustSides",TestPix, RESboxaAdjustSides,{"Dim RESboxaAdjustSides as Boxa = LeptonicaSharp._All.boxaAdjustSides(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxAdjustSides as Box = LeptonicaSharp._All.boxAdjustSides(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxAdjustSides",TestPix, RESboxAdjustSides,{"Dim RESboxAdjustSides as Box = LeptonicaSharp._All.boxAdjustSides(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSetSide as Boxa = LeptonicaSharp._All.boxaSetSide(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSetSide",TestPix, RESboxaSetSide,{"Dim RESboxaSetSide as Boxa = LeptonicaSharp._All.boxaSetSide(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaAdjustWidthToTarget as Boxa = LeptonicaSharp._All.boxaAdjustWidthToTarget(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaAdjustWidthToTarget",TestPix, RESboxaAdjustWidthToTarget,{"Dim RESboxaAdjustWidthToTarget as Boxa = LeptonicaSharp._All.boxaAdjustWidthToTarget(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaAdjustHeightToTarget as Boxa = LeptonicaSharp._All.boxaAdjustHeightToTarget(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaAdjustHeightToTarget",TestPix, RESboxaAdjustHeightToTarget,{"Dim RESboxaAdjustHeightToTarget as Boxa = LeptonicaSharp._All.boxaAdjustHeightToTarget(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxEqual as Integer = LeptonicaSharp._All.boxEqual(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxEqual",TestPix, RESboxEqual,{"Dim RESboxEqual as Integer = LeptonicaSharp._All.boxEqual(TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaEqual as Integer = LeptonicaSharp._All.boxaEqual(TestPix ,TestPix ,TestPix ,Nothing ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaEqual",TestPix, RESboxaEqual,{"Dim RESboxaEqual as Integer = LeptonicaSharp._All.boxaEqual(TestPix ,TestPix ,TestPix ,Nothing ,New Integer)"},1)

' Dim RESboxSimilar as Integer = LeptonicaSharp._All.boxSimilar(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxSimilar",TestPix, RESboxSimilar,{"Dim RESboxSimilar as Integer = LeptonicaSharp._All.boxSimilar(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESboxaSimilar as Integer = LeptonicaSharp._All.boxaSimilar(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSimilar",TestPix, RESboxaSimilar,{"Dim RESboxaSimilar as Integer = LeptonicaSharp._All.boxaSimilar(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Integer,Nothing )"},1)

' Dim RESboxaJoin as Integer = LeptonicaSharp._All.boxaJoin(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaJoin",TestPix, RESboxaJoin,{"Dim RESboxaJoin as Integer = LeptonicaSharp._All.boxaJoin(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaJoin as Integer = LeptonicaSharp._All.boxaaJoin(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaJoin",TestPix, RESboxaaJoin,{"Dim RESboxaaJoin as Integer = LeptonicaSharp._All.boxaaJoin(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSplitEvenOdd as Integer = LeptonicaSharp._All.boxaSplitEvenOdd(TestPix ,TestPix ,New Boxa,New Boxa)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSplitEvenOdd",TestPix, RESboxaSplitEvenOdd,{"Dim RESboxaSplitEvenOdd as Integer = LeptonicaSharp._All.boxaSplitEvenOdd(TestPix ,TestPix ,New Boxa,New Boxa)"},1)

' Dim RESboxaMergeEvenOdd as Boxa = LeptonicaSharp._All.boxaMergeEvenOdd(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaMergeEvenOdd",TestPix, RESboxaMergeEvenOdd,{"Dim RESboxaMergeEvenOdd as Boxa = LeptonicaSharp._All.boxaMergeEvenOdd(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaTransform as Boxa = LeptonicaSharp._All.boxaTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaTransform",TestPix, RESboxaTransform,{"Dim RESboxaTransform as Boxa = LeptonicaSharp._All.boxaTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxTransform as Box = LeptonicaSharp._All.boxTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxTransform",TestPix, RESboxTransform,{"Dim RESboxTransform as Box = LeptonicaSharp._All.boxTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxaTransformOrdered as Boxa = LeptonicaSharp._All.boxaTransformOrdered(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaTransformOrdered",TestPix, RESboxaTransformOrdered,{"Dim RESboxaTransformOrdered as Boxa = LeptonicaSharp._All.boxaTransformOrdered(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxTransformOrdered as Box = LeptonicaSharp._All.boxTransformOrdered(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxTransformOrdered",TestPix, RESboxTransformOrdered,{"Dim RESboxTransformOrdered as Box = LeptonicaSharp._All.boxTransformOrdered(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaRotateOrth as Boxa = LeptonicaSharp._All.boxaRotateOrth(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaRotateOrth",TestPix, RESboxaRotateOrth,{"Dim RESboxaRotateOrth as Boxa = LeptonicaSharp._All.boxaRotateOrth(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxRotateOrth as Box = LeptonicaSharp._All.boxRotateOrth(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxRotateOrth",TestPix, RESboxRotateOrth,{"Dim RESboxRotateOrth as Box = LeptonicaSharp._All.boxRotateOrth(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSort as Boxa = LeptonicaSharp._All.boxaSort(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSort",TestPix, RESboxaSort,{"Dim RESboxaSort as Boxa = LeptonicaSharp._All.boxaSort(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaBinSort as Boxa = LeptonicaSharp._All.boxaBinSort(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaBinSort",TestPix, RESboxaBinSort,{"Dim RESboxaBinSort as Boxa = LeptonicaSharp._All.boxaBinSort(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaSortByIndex as Boxa = LeptonicaSharp._All.boxaSortByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSortByIndex",TestPix, RESboxaSortByIndex,{"Dim RESboxaSortByIndex as Boxa = LeptonicaSharp._All.boxaSortByIndex(TestPix ,TestPix )"},1)

' Dim RESboxaSort2d as Boxaa = LeptonicaSharp._All.boxaSort2d(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSort2d",TestPix, RESboxaSort2d,{"Dim RESboxaSort2d as Boxaa = LeptonicaSharp._All.boxaSort2d(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSort2dByIndex as Boxaa = LeptonicaSharp._All.boxaSort2dByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSort2dByIndex",TestPix, RESboxaSort2dByIndex,{"Dim RESboxaSort2dByIndex as Boxaa = LeptonicaSharp._All.boxaSort2dByIndex(TestPix ,TestPix )"},1)

' Dim RESboxaExtractAsNuma as Integer = LeptonicaSharp._All.boxaExtractAsNuma(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaExtractAsNuma",TestPix, RESboxaExtractAsNuma,{"Dim RESboxaExtractAsNuma as Integer = LeptonicaSharp._All.boxaExtractAsNuma(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESboxaExtractAsPta as Integer = LeptonicaSharp._All.boxaExtractAsPta(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaExtractAsPta",TestPix, RESboxaExtractAsPta,{"Dim RESboxaExtractAsPta as Integer = LeptonicaSharp._All.boxaExtractAsPta(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESboxaGetRankVals as Integer = LeptonicaSharp._All.boxaGetRankVals(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetRankVals",TestPix, RESboxaGetRankVals,{"Dim RESboxaGetRankVals as Integer = LeptonicaSharp._All.boxaGetRankVals(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaGetMedianVals as Integer = LeptonicaSharp._All.boxaGetMedianVals(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetMedianVals",TestPix, RESboxaGetMedianVals,{"Dim RESboxaGetMedianVals as Integer = LeptonicaSharp._All.boxaGetMedianVals(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaGetAverageSize as Integer = LeptonicaSharp._All.boxaGetAverageSize(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetAverageSize",TestPix, RESboxaGetAverageSize,{"Dim RESboxaGetAverageSize as Integer = LeptonicaSharp._All.boxaGetAverageSize(TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxaaGetExtent as Integer = LeptonicaSharp._All.boxaaGetExtent(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaGetExtent",TestPix, RESboxaaGetExtent,{"Dim RESboxaaGetExtent as Integer = LeptonicaSharp._All.boxaaGetExtent(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaaFlattenToBoxa as Boxa = LeptonicaSharp._All.boxaaFlattenToBoxa(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaFlattenToBoxa",TestPix, RESboxaaFlattenToBoxa,{"Dim RESboxaaFlattenToBoxa as Boxa = LeptonicaSharp._All.boxaaFlattenToBoxa(TestPix ,Nothing ,TestPix )"},1)

' Dim RESboxaaFlattenAligned as Boxa = LeptonicaSharp._All.boxaaFlattenAligned(TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaFlattenAligned",TestPix, RESboxaaFlattenAligned,{"Dim RESboxaaFlattenAligned as Boxa = LeptonicaSharp._All.boxaaFlattenAligned(TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESboxaEncapsulateAligned as Boxaa = LeptonicaSharp._All.boxaEncapsulateAligned(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaEncapsulateAligned",TestPix, RESboxaEncapsulateAligned,{"Dim RESboxaEncapsulateAligned as Boxaa = LeptonicaSharp._All.boxaEncapsulateAligned(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaTranspose as Boxaa = LeptonicaSharp._All.boxaaTranspose(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaTranspose",TestPix, RESboxaaTranspose,{"Dim RESboxaaTranspose as Boxaa = LeptonicaSharp._All.boxaaTranspose(TestPix )"},1)

' Dim RESboxaaAlignBox as Integer = LeptonicaSharp._All.boxaaAlignBox(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaAlignBox",TestPix, RESboxaaAlignBox,{"Dim RESboxaaAlignBox as Integer = LeptonicaSharp._All.boxaaAlignBox(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixMaskConnComp as Pix = LeptonicaSharp._All.pixMaskConnComp(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaskConnComp",TestPix, RESpixMaskConnComp,{"Dim RESpixMaskConnComp as Pix = LeptonicaSharp._All.pixMaskConnComp(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixMaskBoxa as Pix = LeptonicaSharp._All.pixMaskBoxa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaskBoxa",TestPix, RESpixMaskBoxa,{"Dim RESpixMaskBoxa as Pix = LeptonicaSharp._All.pixMaskBoxa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixPaintBoxa as Pix = LeptonicaSharp._All.pixPaintBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPaintBoxa",TestPix, RESpixPaintBoxa,{"Dim RESpixPaintBoxa as Pix = LeptonicaSharp._All.pixPaintBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetBlackOrWhiteBoxa as Pix = LeptonicaSharp._All.pixSetBlackOrWhiteBoxa(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetBlackOrWhiteBoxa",TestPix, RESpixSetBlackOrWhiteBoxa,{"Dim RESpixSetBlackOrWhiteBoxa as Pix = LeptonicaSharp._All.pixSetBlackOrWhiteBoxa(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixPaintBoxaRandom as Pix = LeptonicaSharp._All.pixPaintBoxaRandom(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPaintBoxaRandom",TestPix, RESpixPaintBoxaRandom,{"Dim RESpixPaintBoxaRandom as Pix = LeptonicaSharp._All.pixPaintBoxaRandom(TestPix ,TestPix )"},1)

' Dim RESpixBlendBoxaRandom as Pix = LeptonicaSharp._All.pixBlendBoxaRandom(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendBoxaRandom",TestPix, RESpixBlendBoxaRandom,{"Dim RESpixBlendBoxaRandom as Pix = LeptonicaSharp._All.pixBlendBoxaRandom(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDrawBoxa as Pix = LeptonicaSharp._All.pixDrawBoxa(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDrawBoxa",TestPix, RESpixDrawBoxa,{"Dim RESpixDrawBoxa as Pix = LeptonicaSharp._All.pixDrawBoxa(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDrawBoxaRandom as Pix = LeptonicaSharp._All.pixDrawBoxaRandom(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDrawBoxaRandom",TestPix, RESpixDrawBoxaRandom,{"Dim RESpixDrawBoxaRandom as Pix = LeptonicaSharp._All.pixDrawBoxaRandom(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaDisplay as Pix = LeptonicaSharp._All.boxaaDisplay(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaDisplay",TestPix, RESboxaaDisplay,{"Dim RESboxaaDisplay as Pix = LeptonicaSharp._All.boxaaDisplay(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayBoxaa as Pixa = LeptonicaSharp._All.pixaDisplayBoxaa(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayBoxaa",TestPix, RESpixaDisplayBoxaa,{"Dim RESpixaDisplayBoxaa as Pixa = LeptonicaSharp._All.pixaDisplayBoxaa(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSplitIntoBoxa as Boxa = LeptonicaSharp._All.pixSplitIntoBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSplitIntoBoxa",TestPix, RESpixSplitIntoBoxa,{"Dim RESpixSplitIntoBoxa as Boxa = LeptonicaSharp._All.pixSplitIntoBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSplitComponentIntoBoxa as Boxa = LeptonicaSharp._All.pixSplitComponentIntoBoxa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSplitComponentIntoBoxa",TestPix, RESpixSplitComponentIntoBoxa,{"Dim RESpixSplitComponentIntoBoxa as Boxa = LeptonicaSharp._All.pixSplitComponentIntoBoxa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeMosaicStrips as Boxa = LeptonicaSharp._All.makeMosaicStrips(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeMosaicStrips",TestPix, RESmakeMosaicStrips,{"Dim RESmakeMosaicStrips as Boxa = LeptonicaSharp._All.makeMosaicStrips(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaCompareRegions as Integer = LeptonicaSharp._All.boxaCompareRegions(TestPix ,TestPix ,TestPix ,New Integer,New Single,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaCompareRegions",TestPix, RESboxaCompareRegions,{"Dim RESboxaCompareRegions as Integer = LeptonicaSharp._All.boxaCompareRegions(TestPix ,TestPix ,TestPix ,New Integer,New Single,Nothing ,Nothing )"},1)

' Dim RESpixSelectLargeULComp as Box = LeptonicaSharp._All.pixSelectLargeULComp(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectLargeULComp",TestPix, RESpixSelectLargeULComp,{"Dim RESpixSelectLargeULComp as Box = LeptonicaSharp._All.pixSelectLargeULComp(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectLargeULBox as Box = LeptonicaSharp._All.boxaSelectLargeULBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectLargeULBox",TestPix, RESboxaSelectLargeULBox,{"Dim RESboxaSelectLargeULBox as Box = LeptonicaSharp._All.boxaSelectLargeULBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectRange as Boxa = LeptonicaSharp._All.boxaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectRange",TestPix, RESboxaSelectRange,{"Dim RESboxaSelectRange as Boxa = LeptonicaSharp._All.boxaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaaSelectRange as Boxaa = LeptonicaSharp._All.boxaaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaSelectRange",TestPix, RESboxaaSelectRange,{"Dim RESboxaaSelectRange as Boxaa = LeptonicaSharp._All.boxaaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectBySize as Boxa = LeptonicaSharp._All.boxaSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectBySize",TestPix, RESboxaSelectBySize,{"Dim RESboxaSelectBySize as Boxa = LeptonicaSharp._All.boxaSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaMakeSizeIndicator as Numa = LeptonicaSharp._All.boxaMakeSizeIndicator(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaMakeSizeIndicator",TestPix, RESboxaMakeSizeIndicator,{"Dim RESboxaMakeSizeIndicator as Numa = LeptonicaSharp._All.boxaMakeSizeIndicator(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectByArea as Boxa = LeptonicaSharp._All.boxaSelectByArea(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectByArea",TestPix, RESboxaSelectByArea,{"Dim RESboxaSelectByArea as Boxa = LeptonicaSharp._All.boxaSelectByArea(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaMakeAreaIndicator as Numa = LeptonicaSharp._All.boxaMakeAreaIndicator(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaMakeAreaIndicator",TestPix, RESboxaMakeAreaIndicator,{"Dim RESboxaMakeAreaIndicator as Numa = LeptonicaSharp._All.boxaMakeAreaIndicator(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectByWHRatio as Boxa = LeptonicaSharp._All.boxaSelectByWHRatio(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectByWHRatio",TestPix, RESboxaSelectByWHRatio,{"Dim RESboxaSelectByWHRatio as Boxa = LeptonicaSharp._All.boxaSelectByWHRatio(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaMakeWHRatioIndicator as Numa = LeptonicaSharp._All.boxaMakeWHRatioIndicator(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaMakeWHRatioIndicator",TestPix, RESboxaMakeWHRatioIndicator,{"Dim RESboxaMakeWHRatioIndicator as Numa = LeptonicaSharp._All.boxaMakeWHRatioIndicator(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaSelectWithIndicator as Boxa = LeptonicaSharp._All.boxaSelectWithIndicator(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSelectWithIndicator",TestPix, RESboxaSelectWithIndicator,{"Dim RESboxaSelectWithIndicator as Boxa = LeptonicaSharp._All.boxaSelectWithIndicator(TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaPermutePseudorandom as Boxa = LeptonicaSharp._All.boxaPermutePseudorandom(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaPermutePseudorandom",TestPix, RESboxaPermutePseudorandom,{"Dim RESboxaPermutePseudorandom as Boxa = LeptonicaSharp._All.boxaPermutePseudorandom(TestPix )"},1)

' Dim RESboxaPermuteRandom as Boxa = LeptonicaSharp._All.boxaPermuteRandom(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaPermuteRandom",TestPix, RESboxaPermuteRandom,{"Dim RESboxaPermuteRandom as Boxa = LeptonicaSharp._All.boxaPermuteRandom(Nothing ,TestPix )"},1)

' Dim RESboxaSwapBoxes as Integer = LeptonicaSharp._All.boxaSwapBoxes(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSwapBoxes",TestPix, RESboxaSwapBoxes,{"Dim RESboxaSwapBoxes as Integer = LeptonicaSharp._All.boxaSwapBoxes(TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaConvertToPta as Pta = LeptonicaSharp._All.boxaConvertToPta(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaConvertToPta",TestPix, RESboxaConvertToPta,{"Dim RESboxaConvertToPta as Pta = LeptonicaSharp._All.boxaConvertToPta(TestPix ,TestPix )"},1)

' Dim RESptaConvertToBoxa as Boxa = LeptonicaSharp._All.ptaConvertToBoxa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaConvertToBoxa",TestPix, RESptaConvertToBoxa,{"Dim RESptaConvertToBoxa as Boxa = LeptonicaSharp._All.ptaConvertToBoxa(TestPix ,TestPix )"},1)

' Dim RESboxConvertToPta as Pta = LeptonicaSharp._All.boxConvertToPta(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxConvertToPta",TestPix, RESboxConvertToPta,{"Dim RESboxConvertToPta as Pta = LeptonicaSharp._All.boxConvertToPta(TestPix ,TestPix )"},1)

' Dim RESptaConvertToBox as Box = LeptonicaSharp._All.ptaConvertToBox(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaConvertToBox",TestPix, RESptaConvertToBox,{"Dim RESptaConvertToBox as Box = LeptonicaSharp._All.ptaConvertToBox(TestPix )"},1)

' Dim RESboxaSmoothSequenceLS as Boxa = LeptonicaSharp._All.boxaSmoothSequenceLS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSmoothSequenceLS",TestPix, RESboxaSmoothSequenceLS,{"Dim RESboxaSmoothSequenceLS as Boxa = LeptonicaSharp._All.boxaSmoothSequenceLS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaSmoothSequenceMedian as Boxa = LeptonicaSharp._All.boxaSmoothSequenceMedian(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSmoothSequenceMedian",TestPix, RESboxaSmoothSequenceMedian,{"Dim RESboxaSmoothSequenceMedian as Boxa = LeptonicaSharp._All.boxaSmoothSequenceMedian(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaLinearFit as Boxa = LeptonicaSharp._All.boxaLinearFit(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaLinearFit",TestPix, RESboxaLinearFit,{"Dim RESboxaLinearFit as Boxa = LeptonicaSharp._All.boxaLinearFit(TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaWindowedMedian as Boxa = LeptonicaSharp._All.boxaWindowedMedian(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaWindowedMedian",TestPix, RESboxaWindowedMedian,{"Dim RESboxaWindowedMedian as Boxa = LeptonicaSharp._All.boxaWindowedMedian(TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaModifyWithBoxa as Boxa = LeptonicaSharp._All.boxaModifyWithBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaModifyWithBoxa",TestPix, RESboxaModifyWithBoxa,{"Dim RESboxaModifyWithBoxa as Boxa = LeptonicaSharp._All.boxaModifyWithBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaConstrainSize as Boxa = LeptonicaSharp._All.boxaConstrainSize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaConstrainSize",TestPix, RESboxaConstrainSize,{"Dim RESboxaConstrainSize as Boxa = LeptonicaSharp._All.boxaConstrainSize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaReconcileEvenOddHeight as Boxa = LeptonicaSharp._All.boxaReconcileEvenOddHeight(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaReconcileEvenOddHeight",TestPix, RESboxaReconcileEvenOddHeight,{"Dim RESboxaReconcileEvenOddHeight as Boxa = LeptonicaSharp._All.boxaReconcileEvenOddHeight(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaReconcilePairWidth as Boxa = LeptonicaSharp._All.boxaReconcilePairWidth(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaReconcilePairWidth",TestPix, RESboxaReconcilePairWidth,{"Dim RESboxaReconcilePairWidth as Boxa = LeptonicaSharp._All.boxaReconcilePairWidth(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaPlotSides as Integer = LeptonicaSharp._All.boxaPlotSides(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaPlotSides",TestPix, RESboxaPlotSides,{"Dim RESboxaPlotSides as Integer = LeptonicaSharp._All.boxaPlotSides(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaPlotSizes as Integer = LeptonicaSharp._All.boxaPlotSizes(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaPlotSizes",TestPix, RESboxaPlotSizes,{"Dim RESboxaPlotSizes as Integer = LeptonicaSharp._All.boxaPlotSizes(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaFillSequence as Boxa = LeptonicaSharp._All.boxaFillSequence(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaFillSequence",TestPix, RESboxaFillSequence,{"Dim RESboxaFillSequence as Boxa = LeptonicaSharp._All.boxaFillSequence(TestPix ,TestPix ,Nothing )"},1)

' Dim RESboxaSizeVariation as Integer = LeptonicaSharp._All.boxaSizeVariation(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSizeVariation",TestPix, RESboxaSizeVariation,{"Dim RESboxaSizeVariation as Integer = LeptonicaSharp._All.boxaSizeVariation(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaGetExtent as Integer = LeptonicaSharp._All.boxaGetExtent(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetExtent",TestPix, RESboxaGetExtent,{"Dim RESboxaGetExtent as Integer = LeptonicaSharp._All.boxaGetExtent(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaGetCoverage as Integer = LeptonicaSharp._All.boxaGetCoverage(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetCoverage",TestPix, RESboxaGetCoverage,{"Dim RESboxaGetCoverage as Integer = LeptonicaSharp._All.boxaGetCoverage(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESboxaaSizeRange as Integer = LeptonicaSharp._All.boxaaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaSizeRange",TestPix, RESboxaaSizeRange,{"Dim RESboxaaSizeRange as Integer = LeptonicaSharp._All.boxaaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaSizeRange as Integer = LeptonicaSharp._All.boxaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaSizeRange",TestPix, RESboxaSizeRange,{"Dim RESboxaSizeRange as Integer = LeptonicaSharp._All.boxaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaLocationRange as Integer = LeptonicaSharp._All.boxaLocationRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaLocationRange",TestPix, RESboxaLocationRange,{"Dim RESboxaLocationRange as Integer = LeptonicaSharp._All.boxaLocationRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESboxaGetSizes as Integer = LeptonicaSharp._All.boxaGetSizes(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetSizes",TestPix, RESboxaGetSizes,{"Dim RESboxaGetSizes as Integer = LeptonicaSharp._All.boxaGetSizes(TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxaGetArea as Integer = LeptonicaSharp._All.boxaGetArea(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetArea",TestPix, RESboxaGetArea,{"Dim RESboxaGetArea as Integer = LeptonicaSharp._All.boxaGetArea(TestPix ,New Integer)"},1)

' Dim RESboxaDisplayTiled as Pix = LeptonicaSharp._All.boxaDisplayTiled(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaDisplayTiled",TestPix, RESboxaDisplayTiled,{"Dim RESboxaDisplayTiled as Pix = LeptonicaSharp._All.boxaDisplayTiled(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_byteaCreate as L_Bytea = LeptonicaSharp._All.l_byteaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaCreate",TestPix, RESl_byteaCreate,{"Dim RESl_byteaCreate as L_Bytea = LeptonicaSharp._All.l_byteaCreate(TestPix )"},1)

' Dim RESl_byteaInitFromMem as L_Bytea = LeptonicaSharp._All.l_byteaInitFromMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaInitFromMem",TestPix, RESl_byteaInitFromMem,{"Dim RESl_byteaInitFromMem as L_Bytea = LeptonicaSharp._All.l_byteaInitFromMem(TestPix ,TestPix )"},1)

' Dim RESl_byteaInitFromFile as L_Bytea = LeptonicaSharp._All.l_byteaInitFromFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaInitFromFile",TestPix, RESl_byteaInitFromFile,{"Dim RESl_byteaInitFromFile as L_Bytea = LeptonicaSharp._All.l_byteaInitFromFile(TestPix )"},1)

' Dim RESl_byteaInitFromStream as L_Bytea = LeptonicaSharp._All.l_byteaInitFromStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaInitFromStream",TestPix, RESl_byteaInitFromStream,{"Dim RESl_byteaInitFromStream as L_Bytea = LeptonicaSharp._All.l_byteaInitFromStream(TestPix )"},1)

' Dim RESl_byteaCopy as L_Bytea = LeptonicaSharp._All.l_byteaCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaCopy",TestPix, RESl_byteaCopy,{"Dim RESl_byteaCopy as L_Bytea = LeptonicaSharp._All.l_byteaCopy(TestPix ,TestPix )"},1)

' Dim RESl_byteaDestroy as Object = LeptonicaSharp._All.l_byteaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaDestroy",TestPix, RESl_byteaDestroy,{"Dim RESl_byteaDestroy as Object = LeptonicaSharp._All.l_byteaDestroy(TestPix )"},1)

' Dim RESl_byteaGetSize as UInteger = LeptonicaSharp._All.l_byteaGetSize(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaGetSize",TestPix, RESl_byteaGetSize,{"Dim RESl_byteaGetSize as UInteger = LeptonicaSharp._All.l_byteaGetSize(TestPix )"},1)

' Dim RESl_byteaGetData as Byte() = LeptonicaSharp._All.l_byteaGetData(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaGetData",TestPix, RESl_byteaGetData,{"Dim RESl_byteaGetData as Byte() = LeptonicaSharp._All.l_byteaGetData(TestPix ,New UInteger)"},1)

' Dim RESl_byteaCopyData as Byte() = LeptonicaSharp._All.l_byteaCopyData(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaCopyData",TestPix, RESl_byteaCopyData,{"Dim RESl_byteaCopyData as Byte() = LeptonicaSharp._All.l_byteaCopyData(TestPix ,New UInteger)"},1)

' Dim RESl_byteaAppendData as Integer = LeptonicaSharp._All.l_byteaAppendData(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaAppendData",TestPix, RESl_byteaAppendData,{"Dim RESl_byteaAppendData as Integer = LeptonicaSharp._All.l_byteaAppendData(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_byteaAppendString as Integer = LeptonicaSharp._All.l_byteaAppendString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaAppendString",TestPix, RESl_byteaAppendString,{"Dim RESl_byteaAppendString as Integer = LeptonicaSharp._All.l_byteaAppendString(TestPix ,TestPix )"},1)

' Dim RESl_byteaJoin as Integer = LeptonicaSharp._All.l_byteaJoin(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaJoin",TestPix, RESl_byteaJoin,{"Dim RESl_byteaJoin as Integer = LeptonicaSharp._All.l_byteaJoin(TestPix ,TestPix )"},1)

' Dim RESl_byteaSplit as Integer = LeptonicaSharp._All.l_byteaSplit(TestPix ,TestPix ,New L_Bytea)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaSplit",TestPix, RESl_byteaSplit,{"Dim RESl_byteaSplit as Integer = LeptonicaSharp._All.l_byteaSplit(TestPix ,TestPix ,New L_Bytea)"},1)

' Dim RESl_byteaFindEachSequence as Integer = LeptonicaSharp._All.l_byteaFindEachSequence(TestPix ,TestPix ,TestPix ,New L_Dna)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaFindEachSequence",TestPix, RESl_byteaFindEachSequence,{"Dim RESl_byteaFindEachSequence as Integer = LeptonicaSharp._All.l_byteaFindEachSequence(TestPix ,TestPix ,TestPix ,New L_Dna)"},1)

' Dim RESl_byteaWrite as Integer = LeptonicaSharp._All.l_byteaWrite(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaWrite",TestPix, RESl_byteaWrite,{"Dim RESl_byteaWrite as Integer = LeptonicaSharp._All.l_byteaWrite(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_byteaWriteStream as Integer = LeptonicaSharp._All.l_byteaWriteStream(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_byteaWriteStream",TestPix, RESl_byteaWriteStream,{"Dim RESl_byteaWriteStream as Integer = LeptonicaSharp._All.l_byteaWriteStream(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESccbaCreate as CCBorda = LeptonicaSharp._All.ccbaCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaCreate",TestPix, RESccbaCreate,{"Dim RESccbaCreate as CCBorda = LeptonicaSharp._All.ccbaCreate(TestPix ,TestPix )"},1)

' Dim RESccbaDestroy as Object = LeptonicaSharp._All.ccbaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaDestroy",TestPix, RESccbaDestroy,{"Dim RESccbaDestroy as Object = LeptonicaSharp._All.ccbaDestroy(TestPix )"},1)

' Dim RESccbCreate as CCBord = LeptonicaSharp._All.ccbCreate(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbCreate",TestPix, RESccbCreate,{"Dim RESccbCreate as CCBord = LeptonicaSharp._All.ccbCreate(Nothing )"},1)

' Dim RESccbDestroy as Object = LeptonicaSharp._All.ccbDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbDestroy",TestPix, RESccbDestroy,{"Dim RESccbDestroy as Object = LeptonicaSharp._All.ccbDestroy(TestPix )"},1)

' Dim RESccbaAddCcb as Integer = LeptonicaSharp._All.ccbaAddCcb(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaAddCcb",TestPix, RESccbaAddCcb,{"Dim RESccbaAddCcb as Integer = LeptonicaSharp._All.ccbaAddCcb(TestPix ,TestPix )"},1)

' Dim RESccbaGetCount as Integer = LeptonicaSharp._All.ccbaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGetCount",TestPix, RESccbaGetCount,{"Dim RESccbaGetCount as Integer = LeptonicaSharp._All.ccbaGetCount(TestPix )"},1)

' Dim RESccbaGetCcb as CCBord = LeptonicaSharp._All.ccbaGetCcb(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGetCcb",TestPix, RESccbaGetCcb,{"Dim RESccbaGetCcb as CCBord = LeptonicaSharp._All.ccbaGetCcb(TestPix ,TestPix )"},1)

' Dim RESpixGetAllCCBorders as CCBorda = LeptonicaSharp._All.pixGetAllCCBorders(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAllCCBorders",TestPix, RESpixGetAllCCBorders,{"Dim RESpixGetAllCCBorders as CCBorda = LeptonicaSharp._All.pixGetAllCCBorders(TestPix )"},1)

' Dim RESpixGetCCBorders as CCBord = LeptonicaSharp._All.pixGetCCBorders(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetCCBorders",TestPix, RESpixGetCCBorders,{"Dim RESpixGetCCBorders as CCBord = LeptonicaSharp._All.pixGetCCBorders(TestPix ,TestPix )"},1)

' Dim RESpixGetOuterBordersPtaa as Ptaa = LeptonicaSharp._All.pixGetOuterBordersPtaa(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetOuterBordersPtaa",TestPix, RESpixGetOuterBordersPtaa,{"Dim RESpixGetOuterBordersPtaa as Ptaa = LeptonicaSharp._All.pixGetOuterBordersPtaa(TestPix )"},1)

' Dim RESpixGetOuterBorderPta as Pta = LeptonicaSharp._All.pixGetOuterBorderPta(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetOuterBorderPta",TestPix, RESpixGetOuterBorderPta,{"Dim RESpixGetOuterBorderPta as Pta = LeptonicaSharp._All.pixGetOuterBorderPta(TestPix ,Nothing )"},1)

' Dim RESpixGetOuterBorder as Integer = LeptonicaSharp._All.pixGetOuterBorder(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetOuterBorder",TestPix, RESpixGetOuterBorder,{"Dim RESpixGetOuterBorder as Integer = LeptonicaSharp._All.pixGetOuterBorder(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetHoleBorder as Integer = LeptonicaSharp._All.pixGetHoleBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetHoleBorder",TestPix, RESpixGetHoleBorder,{"Dim RESpixGetHoleBorder as Integer = LeptonicaSharp._All.pixGetHoleBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfindNextBorderPixel as Integer = LeptonicaSharp._All.findNextBorderPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("findNextBorderPixel",TestPix, RESfindNextBorderPixel,{"Dim RESfindNextBorderPixel as Integer = LeptonicaSharp._All.findNextBorderPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESlocateOutsideSeedPixel as Object = LeptonicaSharp._All.locateOutsideSeedPixel(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("locateOutsideSeedPixel",TestPix, RESlocateOutsideSeedPixel,{"Dim RESlocateOutsideSeedPixel as Object = LeptonicaSharp._All.locateOutsideSeedPixel(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESccbaGenerateGlobalLocs as Integer = LeptonicaSharp._All.ccbaGenerateGlobalLocs(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGenerateGlobalLocs",TestPix, RESccbaGenerateGlobalLocs,{"Dim RESccbaGenerateGlobalLocs as Integer = LeptonicaSharp._All.ccbaGenerateGlobalLocs(TestPix )"},1)

' Dim RESccbaGenerateStepChains as Integer = LeptonicaSharp._All.ccbaGenerateStepChains(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGenerateStepChains",TestPix, RESccbaGenerateStepChains,{"Dim RESccbaGenerateStepChains as Integer = LeptonicaSharp._All.ccbaGenerateStepChains(TestPix )"},1)

' Dim RESccbaStepChainsToPixCoords as Integer = LeptonicaSharp._All.ccbaStepChainsToPixCoords(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaStepChainsToPixCoords",TestPix, RESccbaStepChainsToPixCoords,{"Dim RESccbaStepChainsToPixCoords as Integer = LeptonicaSharp._All.ccbaStepChainsToPixCoords(TestPix ,TestPix )"},1)

' Dim RESccbaGenerateSPGlobalLocs as Integer = LeptonicaSharp._All.ccbaGenerateSPGlobalLocs(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGenerateSPGlobalLocs",TestPix, RESccbaGenerateSPGlobalLocs,{"Dim RESccbaGenerateSPGlobalLocs as Integer = LeptonicaSharp._All.ccbaGenerateSPGlobalLocs(TestPix ,TestPix )"},1)

' Dim RESccbaGenerateSinglePath as Integer = LeptonicaSharp._All.ccbaGenerateSinglePath(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaGenerateSinglePath",TestPix, RESccbaGenerateSinglePath,{"Dim RESccbaGenerateSinglePath as Integer = LeptonicaSharp._All.ccbaGenerateSinglePath(TestPix )"},1)

' Dim RESgetCutPathForHole as Pta = LeptonicaSharp._All.getCutPathForHole(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("getCutPathForHole",TestPix, RESgetCutPathForHole,{"Dim RESgetCutPathForHole as Pta = LeptonicaSharp._All.getCutPathForHole(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESccbaDisplayBorder as Pix = LeptonicaSharp._All.ccbaDisplayBorder(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaDisplayBorder",TestPix, RESccbaDisplayBorder,{"Dim RESccbaDisplayBorder as Pix = LeptonicaSharp._All.ccbaDisplayBorder(TestPix )"},1)

' Dim RESccbaDisplaySPBorder as Pix = LeptonicaSharp._All.ccbaDisplaySPBorder(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaDisplaySPBorder",TestPix, RESccbaDisplaySPBorder,{"Dim RESccbaDisplaySPBorder as Pix = LeptonicaSharp._All.ccbaDisplaySPBorder(TestPix )"},1)

' Dim RESccbaDisplayImage1 as Pix = LeptonicaSharp._All.ccbaDisplayImage1(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaDisplayImage1",TestPix, RESccbaDisplayImage1,{"Dim RESccbaDisplayImage1 as Pix = LeptonicaSharp._All.ccbaDisplayImage1(TestPix )"},1)

' Dim RESccbaDisplayImage2 as Pix = LeptonicaSharp._All.ccbaDisplayImage2(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaDisplayImage2",TestPix, RESccbaDisplayImage2,{"Dim RESccbaDisplayImage2 as Pix = LeptonicaSharp._All.ccbaDisplayImage2(TestPix )"},1)

' Dim RESccbaWrite as Integer = LeptonicaSharp._All.ccbaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaWrite",TestPix, RESccbaWrite,{"Dim RESccbaWrite as Integer = LeptonicaSharp._All.ccbaWrite(TestPix ,TestPix )"},1)

' Dim RESccbaWriteStream as Integer = LeptonicaSharp._All.ccbaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaWriteStream",TestPix, RESccbaWriteStream,{"Dim RESccbaWriteStream as Integer = LeptonicaSharp._All.ccbaWriteStream(TestPix ,TestPix )"},1)

' Dim RESccbaRead as CCBorda = LeptonicaSharp._All.ccbaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaRead",TestPix, RESccbaRead,{"Dim RESccbaRead as CCBorda = LeptonicaSharp._All.ccbaRead(TestPix )"},1)

' Dim RESccbaReadStream as CCBorda = LeptonicaSharp._All.ccbaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaReadStream",TestPix, RESccbaReadStream,{"Dim RESccbaReadStream as CCBorda = LeptonicaSharp._All.ccbaReadStream(TestPix )"},1)

' Dim RESccbaWriteSVG as Integer = LeptonicaSharp._All.ccbaWriteSVG(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaWriteSVG",TestPix, RESccbaWriteSVG,{"Dim RESccbaWriteSVG as Integer = LeptonicaSharp._All.ccbaWriteSVG(TestPix ,TestPix )"},1)

' Dim RESccbaWriteSVGString as String = LeptonicaSharp._All.ccbaWriteSVGString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ccbaWriteSVGString",TestPix, RESccbaWriteSVGString,{"Dim RESccbaWriteSVGString as String = LeptonicaSharp._All.ccbaWriteSVGString(TestPix ,TestPix )"},1)

' Dim RESpixaThinConnected as Pixa = LeptonicaSharp._All.pixaThinConnected(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaThinConnected",TestPix, RESpixaThinConnected,{"Dim RESpixaThinConnected as Pixa = LeptonicaSharp._All.pixaThinConnected(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThinConnected as Pix = LeptonicaSharp._All.pixThinConnected(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThinConnected",TestPix, RESpixThinConnected,{"Dim RESpixThinConnected as Pix = LeptonicaSharp._All.pixThinConnected(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThinConnectedBySet as Pix = LeptonicaSharp._All.pixThinConnectedBySet(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThinConnectedBySet",TestPix, RESpixThinConnectedBySet,{"Dim RESpixThinConnectedBySet as Pix = LeptonicaSharp._All.pixThinConnectedBySet(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaMakeThinSets as Sela = LeptonicaSharp._All.selaMakeThinSets(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaMakeThinSets",TestPix, RESselaMakeThinSets,{"Dim RESselaMakeThinSets as Sela = LeptonicaSharp._All.selaMakeThinSets(TestPix ,Nothing )"},1)

' Dim RESjbCorrelation as Integer = LeptonicaSharp._All.jbCorrelation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbCorrelation",TestPix, RESjbCorrelation,{"Dim RESjbCorrelation as Integer = LeptonicaSharp._All.jbCorrelation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbRankHaus as Integer = LeptonicaSharp._All.jbRankHaus(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbRankHaus",TestPix, RESjbRankHaus,{"Dim RESjbRankHaus as Integer = LeptonicaSharp._All.jbRankHaus(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbWordsInTextlines as JbClasser = LeptonicaSharp._All.jbWordsInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbWordsInTextlines",TestPix, RESjbWordsInTextlines,{"Dim RESjbWordsInTextlines as JbClasser = LeptonicaSharp._All.jbWordsInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa,TestPix ,TestPix )"},1)

' Dim RESpixGetWordsInTextlines as Integer = LeptonicaSharp._All.pixGetWordsInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,New Pixa,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetWordsInTextlines",TestPix, RESpixGetWordsInTextlines,{"Dim RESpixGetWordsInTextlines as Integer = LeptonicaSharp._All.pixGetWordsInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,New Pixa,New Numa)"},1)

' Dim RESpixGetWordBoxesInTextlines as Integer = LeptonicaSharp._All.pixGetWordBoxesInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetWordBoxesInTextlines",TestPix, RESpixGetWordBoxesInTextlines,{"Dim RESpixGetWordBoxesInTextlines as Integer = LeptonicaSharp._All.pixGetWordBoxesInTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing )"},1)

' Dim RESboxaExtractSortedPattern as Numaa = LeptonicaSharp._All.boxaExtractSortedPattern(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaExtractSortedPattern",TestPix, RESboxaExtractSortedPattern,{"Dim RESboxaExtractSortedPattern as Numaa = LeptonicaSharp._All.boxaExtractSortedPattern(TestPix ,TestPix )"},1)

' Dim RESnumaaCompareImagesByBoxes as Integer = LeptonicaSharp._All.numaaCompareImagesByBoxes(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaCompareImagesByBoxes",TestPix, RESnumaaCompareImagesByBoxes,{"Dim RESnumaaCompareImagesByBoxes as Integer = LeptonicaSharp._All.numaaCompareImagesByBoxes(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,TestPix )"},1)

' Dim RESpixColorContent as Integer = LeptonicaSharp._All.pixColorContent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorContent",TestPix, RESpixColorContent,{"Dim RESpixColorContent as Integer = LeptonicaSharp._All.pixColorContent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixColorMagnitude as Pix = LeptonicaSharp._All.pixColorMagnitude(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorMagnitude",TestPix, RESpixColorMagnitude,{"Dim RESpixColorMagnitude as Pix = LeptonicaSharp._All.pixColorMagnitude(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMaskOverColorPixels as Pix = LeptonicaSharp._All.pixMaskOverColorPixels(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaskOverColorPixels",TestPix, RESpixMaskOverColorPixels,{"Dim RESpixMaskOverColorPixels as Pix = LeptonicaSharp._All.pixMaskOverColorPixels(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMaskOverColorRange as Pix = LeptonicaSharp._All.pixMaskOverColorRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaskOverColorRange",TestPix, RESpixMaskOverColorRange,{"Dim RESpixMaskOverColorRange as Pix = LeptonicaSharp._All.pixMaskOverColorRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorFraction as Integer = LeptonicaSharp._All.pixColorFraction(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorFraction",TestPix, RESpixColorFraction,{"Dim RESpixColorFraction as Integer = LeptonicaSharp._All.pixColorFraction(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single)"},1)

' Dim RESpixFindColorRegions as Integer = LeptonicaSharp._All.pixFindColorRegions(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindColorRegions",TestPix, RESpixFindColorRegions,{"Dim RESpixFindColorRegions as Integer = LeptonicaSharp._All.pixFindColorRegions(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixNumSignificantGrayColors as Integer = LeptonicaSharp._All.pixNumSignificantGrayColors(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixNumSignificantGrayColors",TestPix, RESpixNumSignificantGrayColors,{"Dim RESpixNumSignificantGrayColors as Integer = LeptonicaSharp._All.pixNumSignificantGrayColors(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixColorsForQuantization as Integer = LeptonicaSharp._All.pixColorsForQuantization(TestPix ,TestPix ,New Integer,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorsForQuantization",TestPix, RESpixColorsForQuantization,{"Dim RESpixColorsForQuantization as Integer = LeptonicaSharp._All.pixColorsForQuantization(TestPix ,TestPix ,New Integer,Nothing ,Nothing )"},1)

' Dim RESpixNumColors as Integer = LeptonicaSharp._All.pixNumColors(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixNumColors",TestPix, RESpixNumColors,{"Dim RESpixNumColors as Integer = LeptonicaSharp._All.pixNumColors(TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixGetMostPopulatedColors as Integer = LeptonicaSharp._All.pixGetMostPopulatedColors(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetMostPopulatedColors",TestPix, RESpixGetMostPopulatedColors,{"Dim RESpixGetMostPopulatedColors as Integer = LeptonicaSharp._All.pixGetMostPopulatedColors(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixSimpleColorQuantize as Pix = LeptonicaSharp._All.pixSimpleColorQuantize(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSimpleColorQuantize",TestPix, RESpixSimpleColorQuantize,{"Dim RESpixSimpleColorQuantize as Pix = LeptonicaSharp._All.pixSimpleColorQuantize(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRGBHistogram as Numa = LeptonicaSharp._All.pixGetRGBHistogram(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRGBHistogram",TestPix, RESpixGetRGBHistogram,{"Dim RESpixGetRGBHistogram as Numa = LeptonicaSharp._All.pixGetRGBHistogram(TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeRGBIndexTables as Integer = LeptonicaSharp._All.makeRGBIndexTables(New Byte(),New Byte(),New Byte(),TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeRGBIndexTables",TestPix, RESmakeRGBIndexTables,{"Dim RESmakeRGBIndexTables as Integer = LeptonicaSharp._All.makeRGBIndexTables(New Byte(),New Byte(),New Byte(),TestPix )"},1)

' Dim RESgetRGBFromIndex as Integer = LeptonicaSharp._All.getRGBFromIndex(TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("getRGBFromIndex",TestPix, RESgetRGBFromIndex,{"Dim RESgetRGBFromIndex as Integer = LeptonicaSharp._All.getRGBFromIndex(TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixHasHighlightRed as Integer = LeptonicaSharp._All.pixHasHighlightRed(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHasHighlightRed",TestPix, RESpixHasHighlightRed,{"Dim RESpixHasHighlightRed as Integer = LeptonicaSharp._All.pixHasHighlightRed(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing ,Nothing )"},1)

' Dim RESpixColorGrayRegions as Pix = LeptonicaSharp._All.pixColorGrayRegions(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGrayRegions",TestPix, RESpixColorGrayRegions,{"Dim RESpixColorGrayRegions as Pix = LeptonicaSharp._All.pixColorGrayRegions(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorGray as Integer = LeptonicaSharp._All.pixColorGray(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGray",TestPix, RESpixColorGray,{"Dim RESpixColorGray as Integer = LeptonicaSharp._All.pixColorGray(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorGrayMasked as Pix = LeptonicaSharp._All.pixColorGrayMasked(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGrayMasked",TestPix, RESpixColorGrayMasked,{"Dim RESpixColorGrayMasked as Pix = LeptonicaSharp._All.pixColorGrayMasked(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSnapColor as Pix = LeptonicaSharp._All.pixSnapColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSnapColor",TestPix, RESpixSnapColor,{"Dim RESpixSnapColor as Pix = LeptonicaSharp._All.pixSnapColor(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSnapColorCmap as Pix = LeptonicaSharp._All.pixSnapColorCmap(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSnapColorCmap",TestPix, RESpixSnapColorCmap,{"Dim RESpixSnapColorCmap as Pix = LeptonicaSharp._All.pixSnapColorCmap(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixLinearMapToTargetColor as Pix = LeptonicaSharp._All.pixLinearMapToTargetColor(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLinearMapToTargetColor",TestPix, RESpixLinearMapToTargetColor,{"Dim RESpixLinearMapToTargetColor as Pix = LeptonicaSharp._All.pixLinearMapToTargetColor(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixelLinearMapToTargetColor as Integer = LeptonicaSharp._All.pixelLinearMapToTargetColor(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixelLinearMapToTargetColor",TestPix, RESpixelLinearMapToTargetColor,{"Dim RESpixelLinearMapToTargetColor as Integer = LeptonicaSharp._All.pixelLinearMapToTargetColor(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixShiftByComponent as Pix = LeptonicaSharp._All.pixShiftByComponent(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixShiftByComponent",TestPix, RESpixShiftByComponent,{"Dim RESpixShiftByComponent as Pix = LeptonicaSharp._All.pixShiftByComponent(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixelShiftByComponent as Integer = LeptonicaSharp._All.pixelShiftByComponent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixelShiftByComponent",TestPix, RESpixelShiftByComponent,{"Dim RESpixelShiftByComponent as Integer = LeptonicaSharp._All.pixelShiftByComponent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixelFractionalShift as Integer = LeptonicaSharp._All.pixelFractionalShift(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixelFractionalShift",TestPix, RESpixelFractionalShift,{"Dim RESpixelFractionalShift as Integer = LeptonicaSharp._All.pixelFractionalShift(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixcmapCreate as PixColormap = LeptonicaSharp._All.pixcmapCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapCreate",TestPix, RESpixcmapCreate,{"Dim RESpixcmapCreate as PixColormap = LeptonicaSharp._All.pixcmapCreate(TestPix )"},1)

' Dim RESpixcmapCreateRandom as PixColormap = LeptonicaSharp._All.pixcmapCreateRandom(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapCreateRandom",TestPix, RESpixcmapCreateRandom,{"Dim RESpixcmapCreateRandom as PixColormap = LeptonicaSharp._All.pixcmapCreateRandom(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapCreateLinear as PixColormap = LeptonicaSharp._All.pixcmapCreateLinear(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapCreateLinear",TestPix, RESpixcmapCreateLinear,{"Dim RESpixcmapCreateLinear as PixColormap = LeptonicaSharp._All.pixcmapCreateLinear(TestPix ,TestPix )"},1)

' Dim RESpixcmapCopy as PixColormap = LeptonicaSharp._All.pixcmapCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapCopy",TestPix, RESpixcmapCopy,{"Dim RESpixcmapCopy as PixColormap = LeptonicaSharp._All.pixcmapCopy(TestPix )"},1)

' Dim RESpixcmapDestroy as Object = LeptonicaSharp._All.pixcmapDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapDestroy",TestPix, RESpixcmapDestroy,{"Dim RESpixcmapDestroy as Object = LeptonicaSharp._All.pixcmapDestroy(TestPix )"},1)

' Dim RESpixcmapAddColor as Integer = LeptonicaSharp._All.pixcmapAddColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapAddColor",TestPix, RESpixcmapAddColor,{"Dim RESpixcmapAddColor as Integer = LeptonicaSharp._All.pixcmapAddColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapAddRGBA as Integer = LeptonicaSharp._All.pixcmapAddRGBA(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapAddRGBA",TestPix, RESpixcmapAddRGBA,{"Dim RESpixcmapAddRGBA as Integer = LeptonicaSharp._All.pixcmapAddRGBA(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapAddNewColor as Integer = LeptonicaSharp._All.pixcmapAddNewColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapAddNewColor",TestPix, RESpixcmapAddNewColor,{"Dim RESpixcmapAddNewColor as Integer = LeptonicaSharp._All.pixcmapAddNewColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapAddNearestColor as Integer = LeptonicaSharp._All.pixcmapAddNearestColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapAddNearestColor",TestPix, RESpixcmapAddNearestColor,{"Dim RESpixcmapAddNearestColor as Integer = LeptonicaSharp._All.pixcmapAddNearestColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapUsableColor as Integer = LeptonicaSharp._All.pixcmapUsableColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapUsableColor",TestPix, RESpixcmapUsableColor,{"Dim RESpixcmapUsableColor as Integer = LeptonicaSharp._All.pixcmapUsableColor(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapAddBlackOrWhite as Integer = LeptonicaSharp._All.pixcmapAddBlackOrWhite(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapAddBlackOrWhite",TestPix, RESpixcmapAddBlackOrWhite,{"Dim RESpixcmapAddBlackOrWhite as Integer = LeptonicaSharp._All.pixcmapAddBlackOrWhite(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixcmapSetBlackAndWhite as Integer = LeptonicaSharp._All.pixcmapSetBlackAndWhite(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapSetBlackAndWhite",TestPix, RESpixcmapSetBlackAndWhite,{"Dim RESpixcmapSetBlackAndWhite as Integer = LeptonicaSharp._All.pixcmapSetBlackAndWhite(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapGetCount as Integer = LeptonicaSharp._All.pixcmapGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetCount",TestPix, RESpixcmapGetCount,{"Dim RESpixcmapGetCount as Integer = LeptonicaSharp._All.pixcmapGetCount(TestPix )"},1)

' Dim RESpixcmapGetFreeCount as Integer = LeptonicaSharp._All.pixcmapGetFreeCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetFreeCount",TestPix, RESpixcmapGetFreeCount,{"Dim RESpixcmapGetFreeCount as Integer = LeptonicaSharp._All.pixcmapGetFreeCount(TestPix )"},1)

' Dim RESpixcmapGetDepth as Integer = LeptonicaSharp._All.pixcmapGetDepth(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetDepth",TestPix, RESpixcmapGetDepth,{"Dim RESpixcmapGetDepth as Integer = LeptonicaSharp._All.pixcmapGetDepth(TestPix )"},1)

' Dim RESpixcmapGetMinDepth as Integer = LeptonicaSharp._All.pixcmapGetMinDepth(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetMinDepth",TestPix, RESpixcmapGetMinDepth,{"Dim RESpixcmapGetMinDepth as Integer = LeptonicaSharp._All.pixcmapGetMinDepth(TestPix ,New Integer)"},1)

' Dim RESpixcmapClear as Integer = LeptonicaSharp._All.pixcmapClear(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapClear",TestPix, RESpixcmapClear,{"Dim RESpixcmapClear as Integer = LeptonicaSharp._All.pixcmapClear(TestPix )"},1)

' Dim RESpixcmapGetColor as Integer = LeptonicaSharp._All.pixcmapGetColor(TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetColor",TestPix, RESpixcmapGetColor,{"Dim RESpixcmapGetColor as Integer = LeptonicaSharp._All.pixcmapGetColor(TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixcmapGetColor32 as Integer = LeptonicaSharp._All.pixcmapGetColor32(TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetColor32",TestPix, RESpixcmapGetColor32,{"Dim RESpixcmapGetColor32 as Integer = LeptonicaSharp._All.pixcmapGetColor32(TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixcmapGetRGBA as Integer = LeptonicaSharp._All.pixcmapGetRGBA(TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetRGBA",TestPix, RESpixcmapGetRGBA,{"Dim RESpixcmapGetRGBA as Integer = LeptonicaSharp._All.pixcmapGetRGBA(TestPix ,TestPix ,New Integer,New Integer,New Integer,New Integer)"},1)

' Dim RESpixcmapGetRGBA32 as Integer = LeptonicaSharp._All.pixcmapGetRGBA32(TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetRGBA32",TestPix, RESpixcmapGetRGBA32,{"Dim RESpixcmapGetRGBA32 as Integer = LeptonicaSharp._All.pixcmapGetRGBA32(TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixcmapResetColor as Integer = LeptonicaSharp._All.pixcmapResetColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapResetColor",TestPix, RESpixcmapResetColor,{"Dim RESpixcmapResetColor as Integer = LeptonicaSharp._All.pixcmapResetColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapSetAlpha as Integer = LeptonicaSharp._All.pixcmapSetAlpha(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapSetAlpha",TestPix, RESpixcmapSetAlpha,{"Dim RESpixcmapSetAlpha as Integer = LeptonicaSharp._All.pixcmapSetAlpha(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapGetIndex as Integer = LeptonicaSharp._All.pixcmapGetIndex(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetIndex",TestPix, RESpixcmapGetIndex,{"Dim RESpixcmapGetIndex as Integer = LeptonicaSharp._All.pixcmapGetIndex(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapHasColor as Integer = LeptonicaSharp._All.pixcmapHasColor(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapHasColor",TestPix, RESpixcmapHasColor,{"Dim RESpixcmapHasColor as Integer = LeptonicaSharp._All.pixcmapHasColor(TestPix ,New Integer)"},1)

' Dim RESpixcmapIsOpaque as Integer = LeptonicaSharp._All.pixcmapIsOpaque(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapIsOpaque",TestPix, RESpixcmapIsOpaque,{"Dim RESpixcmapIsOpaque as Integer = LeptonicaSharp._All.pixcmapIsOpaque(TestPix ,New Integer)"},1)

' Dim RESpixcmapIsBlackAndWhite as Integer = LeptonicaSharp._All.pixcmapIsBlackAndWhite(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapIsBlackAndWhite",TestPix, RESpixcmapIsBlackAndWhite,{"Dim RESpixcmapIsBlackAndWhite as Integer = LeptonicaSharp._All.pixcmapIsBlackAndWhite(TestPix ,New Integer)"},1)

' Dim RESpixcmapCountGrayColors as Integer = LeptonicaSharp._All.pixcmapCountGrayColors(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapCountGrayColors",TestPix, RESpixcmapCountGrayColors,{"Dim RESpixcmapCountGrayColors as Integer = LeptonicaSharp._All.pixcmapCountGrayColors(TestPix ,New Integer)"},1)

' Dim RESpixcmapGetRankIntensity as Integer = LeptonicaSharp._All.pixcmapGetRankIntensity(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetRankIntensity",TestPix, RESpixcmapGetRankIntensity,{"Dim RESpixcmapGetRankIntensity as Integer = LeptonicaSharp._All.pixcmapGetRankIntensity(TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapGetNearestIndex as Integer = LeptonicaSharp._All.pixcmapGetNearestIndex(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetNearestIndex",TestPix, RESpixcmapGetNearestIndex,{"Dim RESpixcmapGetNearestIndex as Integer = LeptonicaSharp._All.pixcmapGetNearestIndex(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapGetNearestGrayIndex as Integer = LeptonicaSharp._All.pixcmapGetNearestGrayIndex(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetNearestGrayIndex",TestPix, RESpixcmapGetNearestGrayIndex,{"Dim RESpixcmapGetNearestGrayIndex as Integer = LeptonicaSharp._All.pixcmapGetNearestGrayIndex(TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapGetDistanceToColor as Integer = LeptonicaSharp._All.pixcmapGetDistanceToColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetDistanceToColor",TestPix, RESpixcmapGetDistanceToColor,{"Dim RESpixcmapGetDistanceToColor as Integer = LeptonicaSharp._All.pixcmapGetDistanceToColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixcmapGetRangeValues as Integer = LeptonicaSharp._All.pixcmapGetRangeValues(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGetRangeValues",TestPix, RESpixcmapGetRangeValues,{"Dim RESpixcmapGetRangeValues as Integer = LeptonicaSharp._All.pixcmapGetRangeValues(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixcmapGrayToColor as PixColormap = LeptonicaSharp._All.pixcmapGrayToColor(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGrayToColor",TestPix, RESpixcmapGrayToColor,{"Dim RESpixcmapGrayToColor as PixColormap = LeptonicaSharp._All.pixcmapGrayToColor(TestPix )"},1)

' Dim RESpixcmapColorToGray as PixColormap = LeptonicaSharp._All.pixcmapColorToGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapColorToGray",TestPix, RESpixcmapColorToGray,{"Dim RESpixcmapColorToGray as PixColormap = LeptonicaSharp._All.pixcmapColorToGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapConvertTo4 as PixColormap = LeptonicaSharp._All.pixcmapConvertTo4(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertTo4",TestPix, RESpixcmapConvertTo4,{"Dim RESpixcmapConvertTo4 as PixColormap = LeptonicaSharp._All.pixcmapConvertTo4(TestPix )"},1)

' Dim RESpixcmapConvertTo8 as PixColormap = LeptonicaSharp._All.pixcmapConvertTo8(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertTo8",TestPix, RESpixcmapConvertTo8,{"Dim RESpixcmapConvertTo8 as PixColormap = LeptonicaSharp._All.pixcmapConvertTo8(TestPix )"},1)

' Dim RESpixcmapRead as PixColormap = LeptonicaSharp._All.pixcmapRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapRead",TestPix, RESpixcmapRead,{"Dim RESpixcmapRead as PixColormap = LeptonicaSharp._All.pixcmapRead(TestPix )"},1)

' Dim RESpixcmapReadStream as PixColormap = LeptonicaSharp._All.pixcmapReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapReadStream",TestPix, RESpixcmapReadStream,{"Dim RESpixcmapReadStream as PixColormap = LeptonicaSharp._All.pixcmapReadStream(TestPix )"},1)

' Dim RESpixcmapReadMem as PixColormap = LeptonicaSharp._All.pixcmapReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapReadMem",TestPix, RESpixcmapReadMem,{"Dim RESpixcmapReadMem as PixColormap = LeptonicaSharp._All.pixcmapReadMem(TestPix ,TestPix )"},1)

' Dim RESpixcmapWrite as Integer = LeptonicaSharp._All.pixcmapWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapWrite",TestPix, RESpixcmapWrite,{"Dim RESpixcmapWrite as Integer = LeptonicaSharp._All.pixcmapWrite(TestPix ,TestPix )"},1)

' Dim RESpixcmapWriteStream as Integer = LeptonicaSharp._All.pixcmapWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapWriteStream",TestPix, RESpixcmapWriteStream,{"Dim RESpixcmapWriteStream as Integer = LeptonicaSharp._All.pixcmapWriteStream(TestPix ,TestPix )"},1)

' Dim RESpixcmapWriteMem as Integer = LeptonicaSharp._All.pixcmapWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapWriteMem",TestPix, RESpixcmapWriteMem,{"Dim RESpixcmapWriteMem as Integer = LeptonicaSharp._All.pixcmapWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixcmapToArrays as Integer = LeptonicaSharp._All.pixcmapToArrays(TestPix ,New List (of Integer()),New List (of Integer()),New List (of Integer()),Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapToArrays",TestPix, RESpixcmapToArrays,{"Dim RESpixcmapToArrays as Integer = LeptonicaSharp._All.pixcmapToArrays(TestPix ,New List (of Integer()),New List (of Integer()),New List (of Integer()),Nothing )"},1)

' Dim RESpixcmapToRGBTable as Integer = LeptonicaSharp._All.pixcmapToRGBTable(TestPix ,New Byte(),Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapToRGBTable",TestPix, RESpixcmapToRGBTable,{"Dim RESpixcmapToRGBTable as Integer = LeptonicaSharp._All.pixcmapToRGBTable(TestPix ,New Byte(),Nothing )"},1)

' Dim RESpixcmapSerializeToMemory as Integer = LeptonicaSharp._All.pixcmapSerializeToMemory(TestPix ,TestPix ,New Integer,New Byte())
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapSerializeToMemory",TestPix, RESpixcmapSerializeToMemory,{"Dim RESpixcmapSerializeToMemory as Integer = LeptonicaSharp._All.pixcmapSerializeToMemory(TestPix ,TestPix ,New Integer,New Byte())"},1)

' Dim RESpixcmapDeserializeFromMemory as PixColormap = LeptonicaSharp._All.pixcmapDeserializeFromMemory(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapDeserializeFromMemory",TestPix, RESpixcmapDeserializeFromMemory,{"Dim RESpixcmapDeserializeFromMemory as PixColormap = LeptonicaSharp._All.pixcmapDeserializeFromMemory(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapConvertToHex as String = LeptonicaSharp._All.pixcmapConvertToHex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertToHex",TestPix, RESpixcmapConvertToHex,{"Dim RESpixcmapConvertToHex as String = LeptonicaSharp._All.pixcmapConvertToHex(TestPix ,TestPix )"},1)

' Dim RESpixcmapGammaTRC as Integer = LeptonicaSharp._All.pixcmapGammaTRC(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapGammaTRC",TestPix, RESpixcmapGammaTRC,{"Dim RESpixcmapGammaTRC as Integer = LeptonicaSharp._All.pixcmapGammaTRC(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcmapContrastTRC as Integer = LeptonicaSharp._All.pixcmapContrastTRC(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapContrastTRC",TestPix, RESpixcmapContrastTRC,{"Dim RESpixcmapContrastTRC as Integer = LeptonicaSharp._All.pixcmapContrastTRC(TestPix ,TestPix )"},1)

' Dim RESpixcmapShiftIntensity as Integer = LeptonicaSharp._All.pixcmapShiftIntensity(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapShiftIntensity",TestPix, RESpixcmapShiftIntensity,{"Dim RESpixcmapShiftIntensity as Integer = LeptonicaSharp._All.pixcmapShiftIntensity(TestPix ,TestPix )"},1)

' Dim RESpixcmapShiftByComponent as Integer = LeptonicaSharp._All.pixcmapShiftByComponent(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapShiftByComponent",TestPix, RESpixcmapShiftByComponent,{"Dim RESpixcmapShiftByComponent as Integer = LeptonicaSharp._All.pixcmapShiftByComponent(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorMorph as Pix = LeptonicaSharp._All.pixColorMorph(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorMorph",TestPix, RESpixColorMorph,{"Dim RESpixColorMorph as Pix = LeptonicaSharp._All.pixColorMorph(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctreeColorQuant as Pix = LeptonicaSharp._All.pixOctreeColorQuant(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctreeColorQuant",TestPix, RESpixOctreeColorQuant,{"Dim RESpixOctreeColorQuant as Pix = LeptonicaSharp._All.pixOctreeColorQuant(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctreeColorQuantGeneral as Pix = LeptonicaSharp._All.pixOctreeColorQuantGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctreeColorQuantGeneral",TestPix, RESpixOctreeColorQuantGeneral,{"Dim RESpixOctreeColorQuantGeneral as Pix = LeptonicaSharp._All.pixOctreeColorQuantGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeRGBToIndexTables as Integer = LeptonicaSharp._All.makeRGBToIndexTables(New Byte(),New Byte(),New Byte(),TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeRGBToIndexTables",TestPix, RESmakeRGBToIndexTables,{"Dim RESmakeRGBToIndexTables as Integer = LeptonicaSharp._All.makeRGBToIndexTables(New Byte(),New Byte(),New Byte(),TestPix )"},1)

' Dim RESgetOctcubeIndexFromRGB as Object = LeptonicaSharp._All.getOctcubeIndexFromRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("getOctcubeIndexFromRGB",TestPix, RESgetOctcubeIndexFromRGB,{"Dim RESgetOctcubeIndexFromRGB as Object = LeptonicaSharp._All.getOctcubeIndexFromRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixOctreeQuantByPopulation as Pix = LeptonicaSharp._All.pixOctreeQuantByPopulation(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctreeQuantByPopulation",TestPix, RESpixOctreeQuantByPopulation,{"Dim RESpixOctreeQuantByPopulation as Pix = LeptonicaSharp._All.pixOctreeQuantByPopulation(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctreeQuantNumColors as Pix = LeptonicaSharp._All.pixOctreeQuantNumColors(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctreeQuantNumColors",TestPix, RESpixOctreeQuantNumColors,{"Dim RESpixOctreeQuantNumColors as Pix = LeptonicaSharp._All.pixOctreeQuantNumColors(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctcubeQuantMixedWithGray as Pix = LeptonicaSharp._All.pixOctcubeQuantMixedWithGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctcubeQuantMixedWithGray",TestPix, RESpixOctcubeQuantMixedWithGray,{"Dim RESpixOctcubeQuantMixedWithGray as Pix = LeptonicaSharp._All.pixOctcubeQuantMixedWithGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFixedOctcubeQuant256 as Pix = LeptonicaSharp._All.pixFixedOctcubeQuant256(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFixedOctcubeQuant256",TestPix, RESpixFixedOctcubeQuant256,{"Dim RESpixFixedOctcubeQuant256 as Pix = LeptonicaSharp._All.pixFixedOctcubeQuant256(TestPix ,TestPix )"},1)

' Dim RESpixFewColorsOctcubeQuant1 as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuant1(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFewColorsOctcubeQuant1",TestPix, RESpixFewColorsOctcubeQuant1,{"Dim RESpixFewColorsOctcubeQuant1 as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuant1(TestPix ,TestPix )"},1)

' Dim RESpixFewColorsOctcubeQuant2 as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuant2(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFewColorsOctcubeQuant2",TestPix, RESpixFewColorsOctcubeQuant2,{"Dim RESpixFewColorsOctcubeQuant2 as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuant2(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixFewColorsOctcubeQuantMixed as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFewColorsOctcubeQuantMixed",TestPix, RESpixFewColorsOctcubeQuantMixed,{"Dim RESpixFewColorsOctcubeQuantMixed as Pix = LeptonicaSharp._All.pixFewColorsOctcubeQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixFixedOctcubeQuantGenRGB as Pix = LeptonicaSharp._All.pixFixedOctcubeQuantGenRGB(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFixedOctcubeQuantGenRGB",TestPix, RESpixFixedOctcubeQuantGenRGB,{"Dim RESpixFixedOctcubeQuantGenRGB as Pix = LeptonicaSharp._All.pixFixedOctcubeQuantGenRGB(TestPix ,TestPix )"},1)

' Dim RESpixQuantFromCmap as Pix = LeptonicaSharp._All.pixQuantFromCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuantFromCmap",TestPix, RESpixQuantFromCmap,{"Dim RESpixQuantFromCmap as Pix = LeptonicaSharp._All.pixQuantFromCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctcubeQuantFromCmap as Pix = LeptonicaSharp._All.pixOctcubeQuantFromCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctcubeQuantFromCmap",TestPix, RESpixOctcubeQuantFromCmap,{"Dim RESpixOctcubeQuantFromCmap as Pix = LeptonicaSharp._All.pixOctcubeQuantFromCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOctcubeHistogram as Numa = LeptonicaSharp._All.pixOctcubeHistogram(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOctcubeHistogram",TestPix, RESpixOctcubeHistogram,{"Dim RESpixOctcubeHistogram as Numa = LeptonicaSharp._All.pixOctcubeHistogram(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixcmapToOctcubeLUT as Integer() = LeptonicaSharp._All.pixcmapToOctcubeLUT(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapToOctcubeLUT",TestPix, RESpixcmapToOctcubeLUT,{"Dim RESpixcmapToOctcubeLUT as Integer() = LeptonicaSharp._All.pixcmapToOctcubeLUT(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveUnusedColors as Integer = LeptonicaSharp._All.pixRemoveUnusedColors(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveUnusedColors",TestPix, RESpixRemoveUnusedColors,{"Dim RESpixRemoveUnusedColors as Integer = LeptonicaSharp._All.pixRemoveUnusedColors(TestPix )"},1)

' Dim RESpixNumberOccupiedOctcubes as Integer = LeptonicaSharp._All.pixNumberOccupiedOctcubes(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixNumberOccupiedOctcubes",TestPix, RESpixNumberOccupiedOctcubes,{"Dim RESpixNumberOccupiedOctcubes as Integer = LeptonicaSharp._All.pixNumberOccupiedOctcubes(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixMedianCutQuant as Pix = LeptonicaSharp._All.pixMedianCutQuant(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMedianCutQuant",TestPix, RESpixMedianCutQuant,{"Dim RESpixMedianCutQuant as Pix = LeptonicaSharp._All.pixMedianCutQuant(TestPix ,TestPix )"},1)

' Dim RESpixMedianCutQuantGeneral as Pix = LeptonicaSharp._All.pixMedianCutQuantGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMedianCutQuantGeneral",TestPix, RESpixMedianCutQuantGeneral,{"Dim RESpixMedianCutQuantGeneral as Pix = LeptonicaSharp._All.pixMedianCutQuantGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMedianCutQuantMixed as Pix = LeptonicaSharp._All.pixMedianCutQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMedianCutQuantMixed",TestPix, RESpixMedianCutQuantMixed,{"Dim RESpixMedianCutQuantMixed as Pix = LeptonicaSharp._All.pixMedianCutQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFewColorsMedianCutQuantMixed as Pix = LeptonicaSharp._All.pixFewColorsMedianCutQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFewColorsMedianCutQuantMixed",TestPix, RESpixFewColorsMedianCutQuantMixed,{"Dim RESpixFewColorsMedianCutQuantMixed as Pix = LeptonicaSharp._All.pixFewColorsMedianCutQuantMixed(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMedianCutHisto as Integer() = LeptonicaSharp._All.pixMedianCutHisto(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMedianCutHisto",TestPix, RESpixMedianCutHisto,{"Dim RESpixMedianCutHisto as Integer() = LeptonicaSharp._All.pixMedianCutHisto(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorSegment as Pix = LeptonicaSharp._All.pixColorSegment(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorSegment",TestPix, RESpixColorSegment,{"Dim RESpixColorSegment as Pix = LeptonicaSharp._All.pixColorSegment(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorSegmentCluster as Pix = LeptonicaSharp._All.pixColorSegmentCluster(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorSegmentCluster",TestPix, RESpixColorSegmentCluster,{"Dim RESpixColorSegmentCluster as Pix = LeptonicaSharp._All.pixColorSegmentCluster(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAssignToNearestColor as Integer = LeptonicaSharp._All.pixAssignToNearestColor(TestPix ,TestPix ,Nothing ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAssignToNearestColor",TestPix, RESpixAssignToNearestColor,{"Dim RESpixAssignToNearestColor as Integer = LeptonicaSharp._All.pixAssignToNearestColor(TestPix ,TestPix ,Nothing ,TestPix ,Nothing )"},1)

' Dim RESpixColorSegmentClean as Integer = LeptonicaSharp._All.pixColorSegmentClean(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorSegmentClean",TestPix, RESpixColorSegmentClean,{"Dim RESpixColorSegmentClean as Integer = LeptonicaSharp._All.pixColorSegmentClean(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorSegmentRemoveColors as Integer = LeptonicaSharp._All.pixColorSegmentRemoveColors(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorSegmentRemoveColors",TestPix, RESpixColorSegmentRemoveColors,{"Dim RESpixColorSegmentRemoveColors as Integer = LeptonicaSharp._All.pixColorSegmentRemoveColors(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToHSV as Pix = LeptonicaSharp._All.pixConvertRGBToHSV(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToHSV",TestPix, RESpixConvertRGBToHSV,{"Dim RESpixConvertRGBToHSV as Pix = LeptonicaSharp._All.pixConvertRGBToHSV(Nothing ,TestPix )"},1)

' Dim RESpixConvertHSVToRGB as Pix = LeptonicaSharp._All.pixConvertHSVToRGB(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertHSVToRGB",TestPix, RESpixConvertHSVToRGB,{"Dim RESpixConvertHSVToRGB as Pix = LeptonicaSharp._All.pixConvertHSVToRGB(Nothing ,TestPix )"},1)

' Dim RESconvertRGBToHSV as Integer = LeptonicaSharp._All.convertRGBToHSV(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertRGBToHSV",TestPix, RESconvertRGBToHSV,{"Dim RESconvertRGBToHSV as Integer = LeptonicaSharp._All.convertRGBToHSV(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESconvertHSVToRGB as Integer = LeptonicaSharp._All.convertHSVToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertHSVToRGB",TestPix, RESconvertHSVToRGB,{"Dim RESconvertHSVToRGB as Integer = LeptonicaSharp._All.convertHSVToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixcmapConvertRGBToHSV as Integer = LeptonicaSharp._All.pixcmapConvertRGBToHSV(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertRGBToHSV",TestPix, RESpixcmapConvertRGBToHSV,{"Dim RESpixcmapConvertRGBToHSV as Integer = LeptonicaSharp._All.pixcmapConvertRGBToHSV(TestPix )"},1)

' Dim RESpixcmapConvertHSVToRGB as Integer = LeptonicaSharp._All.pixcmapConvertHSVToRGB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertHSVToRGB",TestPix, RESpixcmapConvertHSVToRGB,{"Dim RESpixcmapConvertHSVToRGB as Integer = LeptonicaSharp._All.pixcmapConvertHSVToRGB(TestPix )"},1)

' Dim RESpixConvertRGBToHue as Pix = LeptonicaSharp._All.pixConvertRGBToHue(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToHue",TestPix, RESpixConvertRGBToHue,{"Dim RESpixConvertRGBToHue as Pix = LeptonicaSharp._All.pixConvertRGBToHue(TestPix )"},1)

' Dim RESpixConvertRGBToSaturation as Pix = LeptonicaSharp._All.pixConvertRGBToSaturation(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToSaturation",TestPix, RESpixConvertRGBToSaturation,{"Dim RESpixConvertRGBToSaturation as Pix = LeptonicaSharp._All.pixConvertRGBToSaturation(TestPix )"},1)

' Dim RESpixConvertRGBToValue as Pix = LeptonicaSharp._All.pixConvertRGBToValue(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToValue",TestPix, RESpixConvertRGBToValue,{"Dim RESpixConvertRGBToValue as Pix = LeptonicaSharp._All.pixConvertRGBToValue(TestPix )"},1)

' Dim RESpixMakeRangeMaskHS as Pix = LeptonicaSharp._All.pixMakeRangeMaskHS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeRangeMaskHS",TestPix, RESpixMakeRangeMaskHS,{"Dim RESpixMakeRangeMaskHS as Pix = LeptonicaSharp._All.pixMakeRangeMaskHS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMakeRangeMaskHV as Pix = LeptonicaSharp._All.pixMakeRangeMaskHV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeRangeMaskHV",TestPix, RESpixMakeRangeMaskHV,{"Dim RESpixMakeRangeMaskHV as Pix = LeptonicaSharp._All.pixMakeRangeMaskHV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMakeRangeMaskSV as Pix = LeptonicaSharp._All.pixMakeRangeMaskSV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeRangeMaskSV",TestPix, RESpixMakeRangeMaskSV,{"Dim RESpixMakeRangeMaskSV as Pix = LeptonicaSharp._All.pixMakeRangeMaskSV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMakeHistoHS as Pix = LeptonicaSharp._All.pixMakeHistoHS(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeHistoHS",TestPix, RESpixMakeHistoHS,{"Dim RESpixMakeHistoHS as Pix = LeptonicaSharp._All.pixMakeHistoHS(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixMakeHistoHV as Pix = LeptonicaSharp._All.pixMakeHistoHV(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeHistoHV",TestPix, RESpixMakeHistoHV,{"Dim RESpixMakeHistoHV as Pix = LeptonicaSharp._All.pixMakeHistoHV(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixMakeHistoSV as Pix = LeptonicaSharp._All.pixMakeHistoSV(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeHistoSV",TestPix, RESpixMakeHistoSV,{"Dim RESpixMakeHistoSV as Pix = LeptonicaSharp._All.pixMakeHistoSV(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixFindHistoPeaksHSV as Integer = LeptonicaSharp._All.pixFindHistoPeaksHSV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pta,New Numa,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindHistoPeaksHSV",TestPix, RESpixFindHistoPeaksHSV,{"Dim RESpixFindHistoPeaksHSV as Integer = LeptonicaSharp._All.pixFindHistoPeaksHSV(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pta,New Numa,Nothing )"},1)

' Dim RESdisplayHSVColorRange as Pix = LeptonicaSharp._All.displayHSVColorRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("displayHSVColorRange",TestPix, RESdisplayHSVColorRange,{"Dim RESdisplayHSVColorRange as Pix = LeptonicaSharp._All.displayHSVColorRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToYUV as Pix = LeptonicaSharp._All.pixConvertRGBToYUV(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToYUV",TestPix, RESpixConvertRGBToYUV,{"Dim RESpixConvertRGBToYUV as Pix = LeptonicaSharp._All.pixConvertRGBToYUV(Nothing ,TestPix )"},1)

' Dim RESpixConvertYUVToRGB as Pix = LeptonicaSharp._All.pixConvertYUVToRGB(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertYUVToRGB",TestPix, RESpixConvertYUVToRGB,{"Dim RESpixConvertYUVToRGB as Pix = LeptonicaSharp._All.pixConvertYUVToRGB(Nothing ,TestPix )"},1)

' Dim RESconvertRGBToYUV as Integer = LeptonicaSharp._All.convertRGBToYUV(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertRGBToYUV",TestPix, RESconvertRGBToYUV,{"Dim RESconvertRGBToYUV as Integer = LeptonicaSharp._All.convertRGBToYUV(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESconvertYUVToRGB as Integer = LeptonicaSharp._All.convertYUVToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertYUVToRGB",TestPix, RESconvertYUVToRGB,{"Dim RESconvertYUVToRGB as Integer = LeptonicaSharp._All.convertYUVToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixcmapConvertRGBToYUV as Integer = LeptonicaSharp._All.pixcmapConvertRGBToYUV(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertRGBToYUV",TestPix, RESpixcmapConvertRGBToYUV,{"Dim RESpixcmapConvertRGBToYUV as Integer = LeptonicaSharp._All.pixcmapConvertRGBToYUV(TestPix )"},1)

' Dim RESpixcmapConvertYUVToRGB as Integer = LeptonicaSharp._All.pixcmapConvertYUVToRGB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcmapConvertYUVToRGB",TestPix, RESpixcmapConvertYUVToRGB,{"Dim RESpixcmapConvertYUVToRGB as Integer = LeptonicaSharp._All.pixcmapConvertYUVToRGB(TestPix )"},1)

' Dim RESpixConvertRGBToXYZ as FPixa = LeptonicaSharp._All.pixConvertRGBToXYZ(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToXYZ",TestPix, RESpixConvertRGBToXYZ,{"Dim RESpixConvertRGBToXYZ as FPixa = LeptonicaSharp._All.pixConvertRGBToXYZ(TestPix )"},1)

' Dim RESfpixaConvertXYZToRGB as Pix = LeptonicaSharp._All.fpixaConvertXYZToRGB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaConvertXYZToRGB",TestPix, RESfpixaConvertXYZToRGB,{"Dim RESfpixaConvertXYZToRGB as Pix = LeptonicaSharp._All.fpixaConvertXYZToRGB(TestPix )"},1)

' Dim RESconvertRGBToXYZ as Integer = LeptonicaSharp._All.convertRGBToXYZ(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertRGBToXYZ",TestPix, RESconvertRGBToXYZ,{"Dim RESconvertRGBToXYZ as Integer = LeptonicaSharp._All.convertRGBToXYZ(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)"},1)

' Dim RESconvertXYZToRGB as Integer = LeptonicaSharp._All.convertXYZToRGB(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertXYZToRGB",TestPix, RESconvertXYZToRGB,{"Dim RESconvertXYZToRGB as Integer = LeptonicaSharp._All.convertXYZToRGB(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESfpixaConvertXYZToLAB as FPixa = LeptonicaSharp._All.fpixaConvertXYZToLAB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaConvertXYZToLAB",TestPix, RESfpixaConvertXYZToLAB,{"Dim RESfpixaConvertXYZToLAB as FPixa = LeptonicaSharp._All.fpixaConvertXYZToLAB(TestPix )"},1)

' Dim RESfpixaConvertLABToXYZ as FPixa = LeptonicaSharp._All.fpixaConvertLABToXYZ(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaConvertLABToXYZ",TestPix, RESfpixaConvertLABToXYZ,{"Dim RESfpixaConvertLABToXYZ as FPixa = LeptonicaSharp._All.fpixaConvertLABToXYZ(TestPix )"},1)

' Dim RESconvertXYZToLAB as Integer = LeptonicaSharp._All.convertXYZToLAB(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertXYZToLAB",TestPix, RESconvertXYZToLAB,{"Dim RESconvertXYZToLAB as Integer = LeptonicaSharp._All.convertXYZToLAB(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)"},1)

' Dim RESconvertLABToXYZ as Integer = LeptonicaSharp._All.convertLABToXYZ(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertLABToXYZ",TestPix, RESconvertLABToXYZ,{"Dim RESconvertLABToXYZ as Integer = LeptonicaSharp._All.convertLABToXYZ(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)"},1)

' Dim RESpixConvertRGBToLAB as FPixa = LeptonicaSharp._All.pixConvertRGBToLAB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToLAB",TestPix, RESpixConvertRGBToLAB,{"Dim RESpixConvertRGBToLAB as FPixa = LeptonicaSharp._All.pixConvertRGBToLAB(TestPix )"},1)

' Dim RESfpixaConvertLABToRGB as Pix = LeptonicaSharp._All.fpixaConvertLABToRGB(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaConvertLABToRGB",TestPix, RESfpixaConvertLABToRGB,{"Dim RESfpixaConvertLABToRGB as Pix = LeptonicaSharp._All.fpixaConvertLABToRGB(TestPix )"},1)

' Dim RESconvertRGBToLAB as Integer = LeptonicaSharp._All.convertRGBToLAB(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertRGBToLAB",TestPix, RESconvertRGBToLAB,{"Dim RESconvertRGBToLAB as Integer = LeptonicaSharp._All.convertRGBToLAB(TestPix ,TestPix ,TestPix ,New Single,New Single,New Single)"},1)

' Dim RESconvertLABToRGB as Integer = LeptonicaSharp._All.convertLABToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertLABToRGB",TestPix, RESconvertLABToRGB,{"Dim RESconvertLABToRGB as Integer = LeptonicaSharp._All.convertLABToRGB(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Integer)"},1)

' Dim RESpixEqual as Integer = LeptonicaSharp._All.pixEqual(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEqual",TestPix, RESpixEqual,{"Dim RESpixEqual as Integer = LeptonicaSharp._All.pixEqual(TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixEqualWithAlpha as Integer = LeptonicaSharp._All.pixEqualWithAlpha(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEqualWithAlpha",TestPix, RESpixEqualWithAlpha,{"Dim RESpixEqualWithAlpha as Integer = LeptonicaSharp._All.pixEqualWithAlpha(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixEqualWithCmap as Integer = LeptonicaSharp._All.pixEqualWithCmap(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEqualWithCmap",TestPix, RESpixEqualWithCmap,{"Dim RESpixEqualWithCmap as Integer = LeptonicaSharp._All.pixEqualWithCmap(TestPix ,TestPix ,New Integer)"},1)

' Dim REScmapEqual as Integer = LeptonicaSharp._All.cmapEqual(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("cmapEqual",TestPix, REScmapEqual,{"Dim REScmapEqual as Integer = LeptonicaSharp._All.cmapEqual(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixUsesCmapColor as Integer = LeptonicaSharp._All.pixUsesCmapColor(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUsesCmapColor",TestPix, RESpixUsesCmapColor,{"Dim RESpixUsesCmapColor as Integer = LeptonicaSharp._All.pixUsesCmapColor(TestPix ,New Integer)"},1)

' Dim RESpixCorrelationBinary as Integer = LeptonicaSharp._All.pixCorrelationBinary(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCorrelationBinary",TestPix, RESpixCorrelationBinary,{"Dim RESpixCorrelationBinary as Integer = LeptonicaSharp._All.pixCorrelationBinary(TestPix ,TestPix ,New Single)"},1)

' Dim RESpixDisplayDiffBinary as Pix = LeptonicaSharp._All.pixDisplayDiffBinary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayDiffBinary",TestPix, RESpixDisplayDiffBinary,{"Dim RESpixDisplayDiffBinary as Pix = LeptonicaSharp._All.pixDisplayDiffBinary(TestPix ,TestPix )"},1)

' Dim RESpixCompareBinary as Integer = LeptonicaSharp._All.pixCompareBinary(TestPix ,TestPix ,TestPix ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareBinary",TestPix, RESpixCompareBinary,{"Dim RESpixCompareBinary as Integer = LeptonicaSharp._All.pixCompareBinary(TestPix ,TestPix ,TestPix ,New Single,Nothing )"},1)

' Dim RESpixCompareGrayOrRGB as Integer = LeptonicaSharp._All.pixCompareGrayOrRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareGrayOrRGB",TestPix, RESpixCompareGrayOrRGB,{"Dim RESpixCompareGrayOrRGB as Integer = LeptonicaSharp._All.pixCompareGrayOrRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixCompareGray as Integer = LeptonicaSharp._All.pixCompareGray(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareGray",TestPix, RESpixCompareGray,{"Dim RESpixCompareGray as Integer = LeptonicaSharp._All.pixCompareGray(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixCompareRGB as Integer = LeptonicaSharp._All.pixCompareRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareRGB",TestPix, RESpixCompareRGB,{"Dim RESpixCompareRGB as Integer = LeptonicaSharp._All.pixCompareRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixCompareTiled as Integer = LeptonicaSharp._All.pixCompareTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareTiled",TestPix, RESpixCompareTiled,{"Dim RESpixCompareTiled as Integer = LeptonicaSharp._All.pixCompareTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixCompareRankDifference as Numa = LeptonicaSharp._All.pixCompareRankDifference(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareRankDifference",TestPix, RESpixCompareRankDifference,{"Dim RESpixCompareRankDifference as Numa = LeptonicaSharp._All.pixCompareRankDifference(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTestForSimilarity as Integer = LeptonicaSharp._All.pixTestForSimilarity(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTestForSimilarity",TestPix, RESpixTestForSimilarity,{"Dim RESpixTestForSimilarity as Integer = LeptonicaSharp._All.pixTestForSimilarity(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,TestPix )"},1)

' Dim RESpixGetDifferenceStats as Integer = LeptonicaSharp._All.pixGetDifferenceStats(TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetDifferenceStats",TestPix, RESpixGetDifferenceStats,{"Dim RESpixGetDifferenceStats as Integer = LeptonicaSharp._All.pixGetDifferenceStats(TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,TestPix )"},1)

' Dim RESpixGetDifferenceHistogram as Numa = LeptonicaSharp._All.pixGetDifferenceHistogram(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetDifferenceHistogram",TestPix, RESpixGetDifferenceHistogram,{"Dim RESpixGetDifferenceHistogram as Numa = LeptonicaSharp._All.pixGetDifferenceHistogram(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetPerceptualDiff as Integer = LeptonicaSharp._All.pixGetPerceptualDiff(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetPerceptualDiff",TestPix, RESpixGetPerceptualDiff,{"Dim RESpixGetPerceptualDiff as Integer = LeptonicaSharp._All.pixGetPerceptualDiff(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing ,Nothing )"},1)

' Dim RESpixGetPSNR as Integer = LeptonicaSharp._All.pixGetPSNR(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetPSNR",TestPix, RESpixGetPSNR,{"Dim RESpixGetPSNR as Integer = LeptonicaSharp._All.pixGetPSNR(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixaComparePhotoRegionsByHisto as Integer = LeptonicaSharp._All.pixaComparePhotoRegionsByHisto(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaComparePhotoRegionsByHisto",TestPix, RESpixaComparePhotoRegionsByHisto,{"Dim RESpixaComparePhotoRegionsByHisto as Integer = LeptonicaSharp._All.pixaComparePhotoRegionsByHisto(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixComparePhotoRegionsByHisto as Integer = LeptonicaSharp._All.pixComparePhotoRegionsByHisto(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixComparePhotoRegionsByHisto",TestPix, RESpixComparePhotoRegionsByHisto,{"Dim RESpixComparePhotoRegionsByHisto as Integer = LeptonicaSharp._All.pixComparePhotoRegionsByHisto(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,TestPix )"},1)

' Dim RESpixGenPhotoHistos as Integer = LeptonicaSharp._All.pixGenPhotoHistos(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Numaa,New Integer,New Integer,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenPhotoHistos",TestPix, RESpixGenPhotoHistos,{"Dim RESpixGenPhotoHistos as Integer = LeptonicaSharp._All.pixGenPhotoHistos(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Numaa,New Integer,New Integer,TestPix )"},1)

' Dim RESpixPadToCenterCentroid as Pix = LeptonicaSharp._All.pixPadToCenterCentroid(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPadToCenterCentroid",TestPix, RESpixPadToCenterCentroid,{"Dim RESpixPadToCenterCentroid as Pix = LeptonicaSharp._All.pixPadToCenterCentroid(TestPix ,TestPix )"},1)

' Dim RESpixCentroid8 as Integer = LeptonicaSharp._All.pixCentroid8(TestPix ,TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCentroid8",TestPix, RESpixCentroid8,{"Dim RESpixCentroid8 as Integer = LeptonicaSharp._All.pixCentroid8(TestPix ,TestPix ,New Single,New Single)"},1)

' Dim RESpixDecideIfPhotoImage as Integer = LeptonicaSharp._All.pixDecideIfPhotoImage(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numaa,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDecideIfPhotoImage",TestPix, RESpixDecideIfPhotoImage,{"Dim RESpixDecideIfPhotoImage as Integer = LeptonicaSharp._All.pixDecideIfPhotoImage(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numaa,Nothing )"},1)

' Dim REScompareTilesByHisto as Integer = LeptonicaSharp._All.compareTilesByHisto(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("compareTilesByHisto",TestPix, REScompareTilesByHisto,{"Dim REScompareTilesByHisto as Integer = LeptonicaSharp._All.compareTilesByHisto(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing )"},1)

' Dim RESpixCompareGrayByHisto as Integer = LeptonicaSharp._All.pixCompareGrayByHisto(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareGrayByHisto",TestPix, RESpixCompareGrayByHisto,{"Dim RESpixCompareGrayByHisto as Integer = LeptonicaSharp._All.pixCompareGrayByHisto(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,TestPix )"},1)

' Dim RESpixCropAlignedToCentroid as Integer = LeptonicaSharp._All.pixCropAlignedToCentroid(TestPix ,TestPix ,TestPix ,New Box,New Box)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCropAlignedToCentroid",TestPix, RESpixCropAlignedToCentroid,{"Dim RESpixCropAlignedToCentroid as Integer = LeptonicaSharp._All.pixCropAlignedToCentroid(TestPix ,TestPix ,TestPix ,New Box,New Box)"},1)

' Dim RESl_compressGrayHistograms as Byte() = LeptonicaSharp._All.l_compressGrayHistograms(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_compressGrayHistograms",TestPix, RESl_compressGrayHistograms,{"Dim RESl_compressGrayHistograms as Byte() = LeptonicaSharp._All.l_compressGrayHistograms(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESl_uncompressGrayHistograms as Numaa = LeptonicaSharp._All.l_uncompressGrayHistograms(TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_uncompressGrayHistograms",TestPix, RESl_uncompressGrayHistograms,{"Dim RESl_uncompressGrayHistograms as Numaa = LeptonicaSharp._All.l_uncompressGrayHistograms(TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESpixCompareWithTranslation as Integer = LeptonicaSharp._All.pixCompareWithTranslation(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Single,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCompareWithTranslation",TestPix, RESpixCompareWithTranslation,{"Dim RESpixCompareWithTranslation as Integer = LeptonicaSharp._All.pixCompareWithTranslation(TestPix ,TestPix ,TestPix ,New Integer,New Integer,New Single,TestPix )"},1)

' Dim RESpixBestCorrelation as Integer = LeptonicaSharp._All.pixBestCorrelation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBestCorrelation",TestPix, RESpixBestCorrelation,{"Dim RESpixBestCorrelation as Integer = LeptonicaSharp._All.pixBestCorrelation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixConnComp as Boxa = LeptonicaSharp._All.pixConnComp(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnComp",TestPix, RESpixConnComp,{"Dim RESpixConnComp as Boxa = LeptonicaSharp._All.pixConnComp(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixConnCompPixa as Boxa = LeptonicaSharp._All.pixConnCompPixa(TestPix ,New Pixa,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompPixa",TestPix, RESpixConnCompPixa,{"Dim RESpixConnCompPixa as Boxa = LeptonicaSharp._All.pixConnCompPixa(TestPix ,New Pixa,TestPix )"},1)

' Dim RESpixConnCompBB as Boxa = LeptonicaSharp._All.pixConnCompBB(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompBB",TestPix, RESpixConnCompBB,{"Dim RESpixConnCompBB as Boxa = LeptonicaSharp._All.pixConnCompBB(TestPix ,TestPix )"},1)

' Dim RESpixCountConnComp as Integer = LeptonicaSharp._All.pixCountConnComp(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountConnComp",TestPix, RESpixCountConnComp,{"Dim RESpixCountConnComp as Integer = LeptonicaSharp._All.pixCountConnComp(TestPix ,TestPix ,New Integer)"},1)

' Dim RESnextOnPixelInRaster as Integer = LeptonicaSharp._All.nextOnPixelInRaster(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("nextOnPixelInRaster",TestPix, RESnextOnPixelInRaster,{"Dim RESnextOnPixelInRaster as Integer = LeptonicaSharp._All.nextOnPixelInRaster(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESnextOnPixelInRasterLow as Integer = LeptonicaSharp._All.nextOnPixelInRasterLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("nextOnPixelInRasterLow",TestPix, RESnextOnPixelInRasterLow,{"Dim RESnextOnPixelInRasterLow as Integer = LeptonicaSharp._All.nextOnPixelInRasterLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESpixSeedfillBB as Box = LeptonicaSharp._All.pixSeedfillBB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillBB",TestPix, RESpixSeedfillBB,{"Dim RESpixSeedfillBB as Box = LeptonicaSharp._All.pixSeedfillBB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfill4BB as Box = LeptonicaSharp._All.pixSeedfill4BB(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfill4BB",TestPix, RESpixSeedfill4BB,{"Dim RESpixSeedfill4BB as Box = LeptonicaSharp._All.pixSeedfill4BB(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfill8BB as Box = LeptonicaSharp._All.pixSeedfill8BB(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfill8BB",TestPix, RESpixSeedfill8BB,{"Dim RESpixSeedfill8BB as Box = LeptonicaSharp._All.pixSeedfill8BB(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfill as Integer = LeptonicaSharp._All.pixSeedfill(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfill",TestPix, RESpixSeedfill,{"Dim RESpixSeedfill as Integer = LeptonicaSharp._All.pixSeedfill(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfill4 as Integer = LeptonicaSharp._All.pixSeedfill4(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfill4",TestPix, RESpixSeedfill4,{"Dim RESpixSeedfill4 as Integer = LeptonicaSharp._All.pixSeedfill4(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfill8 as Integer = LeptonicaSharp._All.pixSeedfill8(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfill8",TestPix, RESpixSeedfill8,{"Dim RESpixSeedfill8 as Integer = LeptonicaSharp._All.pixSeedfill8(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertFilesTo1bpp as Integer = LeptonicaSharp._All.convertFilesTo1bpp(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFilesTo1bpp",TestPix, RESconvertFilesTo1bpp,{"Dim RESconvertFilesTo1bpp as Integer = LeptonicaSharp._All.convertFilesTo1bpp(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlockconv as Pix = LeptonicaSharp._All.pixBlockconv(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconv",TestPix, RESpixBlockconv,{"Dim RESpixBlockconv as Pix = LeptonicaSharp._All.pixBlockconv(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlockconvGray as Pix = LeptonicaSharp._All.pixBlockconvGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconvGray",TestPix, RESpixBlockconvGray,{"Dim RESpixBlockconvGray as Pix = LeptonicaSharp._All.pixBlockconvGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlockconvAccum as Pix = LeptonicaSharp._All.pixBlockconvAccum(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconvAccum",TestPix, RESpixBlockconvAccum,{"Dim RESpixBlockconvAccum as Pix = LeptonicaSharp._All.pixBlockconvAccum(TestPix )"},1)

' Dim RESpixBlockconvGrayUnnormalized as Pix = LeptonicaSharp._All.pixBlockconvGrayUnnormalized(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconvGrayUnnormalized",TestPix, RESpixBlockconvGrayUnnormalized,{"Dim RESpixBlockconvGrayUnnormalized as Pix = LeptonicaSharp._All.pixBlockconvGrayUnnormalized(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlockconvTiled as Pix = LeptonicaSharp._All.pixBlockconvTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconvTiled",TestPix, RESpixBlockconvTiled,{"Dim RESpixBlockconvTiled as Pix = LeptonicaSharp._All.pixBlockconvTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlockconvGrayTile as Pix = LeptonicaSharp._All.pixBlockconvGrayTile(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockconvGrayTile",TestPix, RESpixBlockconvGrayTile,{"Dim RESpixBlockconvGrayTile as Pix = LeptonicaSharp._All.pixBlockconvGrayTile(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWindowedStats as Integer = LeptonicaSharp._All.pixWindowedStats(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWindowedStats",TestPix, RESpixWindowedStats,{"Dim RESpixWindowedStats as Integer = LeptonicaSharp._All.pixWindowedStats(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixWindowedMean as Pix = LeptonicaSharp._All.pixWindowedMean(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWindowedMean",TestPix, RESpixWindowedMean,{"Dim RESpixWindowedMean as Pix = LeptonicaSharp._All.pixWindowedMean(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWindowedMeanSquare as Pix = LeptonicaSharp._All.pixWindowedMeanSquare(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWindowedMeanSquare",TestPix, RESpixWindowedMeanSquare,{"Dim RESpixWindowedMeanSquare as Pix = LeptonicaSharp._All.pixWindowedMeanSquare(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWindowedVariance as Integer = LeptonicaSharp._All.pixWindowedVariance(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWindowedVariance",TestPix, RESpixWindowedVariance,{"Dim RESpixWindowedVariance as Integer = LeptonicaSharp._All.pixWindowedVariance(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixMeanSquareAccum as DPix = LeptonicaSharp._All.pixMeanSquareAccum(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMeanSquareAccum",TestPix, RESpixMeanSquareAccum,{"Dim RESpixMeanSquareAccum as DPix = LeptonicaSharp._All.pixMeanSquareAccum(TestPix )"},1)

' Dim RESpixBlockrank as Pix = LeptonicaSharp._All.pixBlockrank(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlockrank",TestPix, RESpixBlockrank,{"Dim RESpixBlockrank as Pix = LeptonicaSharp._All.pixBlockrank(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlocksum as Pix = LeptonicaSharp._All.pixBlocksum(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlocksum",TestPix, RESpixBlocksum,{"Dim RESpixBlocksum as Pix = LeptonicaSharp._All.pixBlocksum(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixCensusTransform as Pix = LeptonicaSharp._All.pixCensusTransform(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCensusTransform",TestPix, RESpixCensusTransform,{"Dim RESpixCensusTransform as Pix = LeptonicaSharp._All.pixCensusTransform(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixConvolve as Pix = LeptonicaSharp._All.pixConvolve(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvolve",TestPix, RESpixConvolve,{"Dim RESpixConvolve as Pix = LeptonicaSharp._All.pixConvolve(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvolveSep as Pix = LeptonicaSharp._All.pixConvolveSep(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvolveSep",TestPix, RESpixConvolveSep,{"Dim RESpixConvolveSep as Pix = LeptonicaSharp._All.pixConvolveSep(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvolveRGB as Pix = LeptonicaSharp._All.pixConvolveRGB(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvolveRGB",TestPix, RESpixConvolveRGB,{"Dim RESpixConvolveRGB as Pix = LeptonicaSharp._All.pixConvolveRGB(TestPix ,TestPix )"},1)

' Dim RESpixConvolveRGBSep as Pix = LeptonicaSharp._All.pixConvolveRGBSep(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvolveRGBSep",TestPix, RESpixConvolveRGBSep,{"Dim RESpixConvolveRGBSep as Pix = LeptonicaSharp._All.pixConvolveRGBSep(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixConvolve as FPix = LeptonicaSharp._All.fpixConvolve(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixConvolve",TestPix, RESfpixConvolve,{"Dim RESfpixConvolve as FPix = LeptonicaSharp._All.fpixConvolve(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixConvolveSep as FPix = LeptonicaSharp._All.fpixConvolveSep(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixConvolveSep",TestPix, RESfpixConvolveSep,{"Dim RESfpixConvolveSep as FPix = LeptonicaSharp._All.fpixConvolveSep(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvolveWithBias as Pix = LeptonicaSharp._All.pixConvolveWithBias(TestPix ,TestPix ,Nothing ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvolveWithBias",TestPix, RESpixConvolveWithBias,{"Dim RESpixConvolveWithBias as Pix = LeptonicaSharp._All.pixConvolveWithBias(TestPix ,TestPix ,Nothing ,TestPix ,New Integer)"},1)

' Dim RESl_setConvolveSampling as Object = LeptonicaSharp._All.l_setConvolveSampling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setConvolveSampling",TestPix, RESl_setConvolveSampling,{"Dim RESl_setConvolveSampling as Object = LeptonicaSharp._All.l_setConvolveSampling(TestPix ,TestPix )"},1)

' Dim RESpixAddGaussianNoise as Pix = LeptonicaSharp._All.pixAddGaussianNoise(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddGaussianNoise",TestPix, RESpixAddGaussianNoise,{"Dim RESpixAddGaussianNoise as Pix = LeptonicaSharp._All.pixAddGaussianNoise(TestPix ,TestPix )"},1)

' Dim RESgaussDistribSampling as Single = LeptonicaSharp._All.gaussDistribSampling()
' LeptonicaSharp.Convert.WriteHelpExtension ("gaussDistribSampling",TestPix, RESgaussDistribSampling,{"Dim RESgaussDistribSampling as Single = LeptonicaSharp._All.gaussDistribSampling()"},1)

' Dim RESpixCorrelationScore as Integer = LeptonicaSharp._All.pixCorrelationScore(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCorrelationScore",TestPix, RESpixCorrelationScore,{"Dim RESpixCorrelationScore as Integer = LeptonicaSharp._All.pixCorrelationScore(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixCorrelationScoreThresholded as Integer = LeptonicaSharp._All.pixCorrelationScoreThresholded(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCorrelationScoreThresholded",TestPix, RESpixCorrelationScoreThresholded,{"Dim RESpixCorrelationScoreThresholded as Integer = LeptonicaSharp._All.pixCorrelationScoreThresholded(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCorrelationScoreSimple as Integer = LeptonicaSharp._All.pixCorrelationScoreSimple(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCorrelationScoreSimple",TestPix, RESpixCorrelationScoreSimple,{"Dim RESpixCorrelationScoreSimple as Integer = LeptonicaSharp._All.pixCorrelationScoreSimple(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixCorrelationScoreShifted as Integer = LeptonicaSharp._All.pixCorrelationScoreShifted(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCorrelationScoreShifted",TestPix, RESpixCorrelationScoreShifted,{"Dim RESpixCorrelationScoreShifted as Integer = LeptonicaSharp._All.pixCorrelationScoreShifted(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESdewarpCreate as L_Dewarp = LeptonicaSharp._All.dewarpCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpCreate",TestPix, RESdewarpCreate,{"Dim RESdewarpCreate as L_Dewarp = LeptonicaSharp._All.dewarpCreate(TestPix ,TestPix )"},1)

' Dim RESdewarpCreateRef as L_Dewarp = LeptonicaSharp._All.dewarpCreateRef(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpCreateRef",TestPix, RESdewarpCreateRef,{"Dim RESdewarpCreateRef as L_Dewarp = LeptonicaSharp._All.dewarpCreateRef(TestPix ,TestPix )"},1)

' Dim RESdewarpDestroy as Object = LeptonicaSharp._All.dewarpDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpDestroy",TestPix, RESdewarpDestroy,{"Dim RESdewarpDestroy as Object = LeptonicaSharp._All.dewarpDestroy(TestPix )"},1)

' Dim RESdewarpaCreate as L_Dewarpa = LeptonicaSharp._All.dewarpaCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaCreate",TestPix, RESdewarpaCreate,{"Dim RESdewarpaCreate as L_Dewarpa = LeptonicaSharp._All.dewarpaCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpaCreateFromPixacomp as L_Dewarpa = LeptonicaSharp._All.dewarpaCreateFromPixacomp(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaCreateFromPixacomp",TestPix, RESdewarpaCreateFromPixacomp,{"Dim RESdewarpaCreateFromPixacomp as L_Dewarpa = LeptonicaSharp._All.dewarpaCreateFromPixacomp(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpaDestroy as Object = LeptonicaSharp._All.dewarpaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaDestroy",TestPix, RESdewarpaDestroy,{"Dim RESdewarpaDestroy as Object = LeptonicaSharp._All.dewarpaDestroy(TestPix )"},1)

' Dim RESdewarpaDestroyDewarp as Integer = LeptonicaSharp._All.dewarpaDestroyDewarp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaDestroyDewarp",TestPix, RESdewarpaDestroyDewarp,{"Dim RESdewarpaDestroyDewarp as Integer = LeptonicaSharp._All.dewarpaDestroyDewarp(TestPix ,TestPix )"},1)

' Dim RESdewarpaInsertDewarp as Integer = LeptonicaSharp._All.dewarpaInsertDewarp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaInsertDewarp",TestPix, RESdewarpaInsertDewarp,{"Dim RESdewarpaInsertDewarp as Integer = LeptonicaSharp._All.dewarpaInsertDewarp(TestPix ,TestPix )"},1)

' Dim RESdewarpaGetDewarp as L_Dewarp = LeptonicaSharp._All.dewarpaGetDewarp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaGetDewarp",TestPix, RESdewarpaGetDewarp,{"Dim RESdewarpaGetDewarp as L_Dewarp = LeptonicaSharp._All.dewarpaGetDewarp(TestPix ,TestPix )"},1)

' Dim RESdewarpaSetCurvatures as Integer = LeptonicaSharp._All.dewarpaSetCurvatures(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaSetCurvatures",TestPix, RESdewarpaSetCurvatures,{"Dim RESdewarpaSetCurvatures as Integer = LeptonicaSharp._All.dewarpaSetCurvatures(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpaUseBothArrays as Integer = LeptonicaSharp._All.dewarpaUseBothArrays(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaUseBothArrays",TestPix, RESdewarpaUseBothArrays,{"Dim RESdewarpaUseBothArrays as Integer = LeptonicaSharp._All.dewarpaUseBothArrays(TestPix ,TestPix )"},1)

' Dim RESdewarpaSetCheckColumns as Integer = LeptonicaSharp._All.dewarpaSetCheckColumns(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaSetCheckColumns",TestPix, RESdewarpaSetCheckColumns,{"Dim RESdewarpaSetCheckColumns as Integer = LeptonicaSharp._All.dewarpaSetCheckColumns(TestPix ,TestPix )"},1)

' Dim RESdewarpaSetMaxDistance as Integer = LeptonicaSharp._All.dewarpaSetMaxDistance(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaSetMaxDistance",TestPix, RESdewarpaSetMaxDistance,{"Dim RESdewarpaSetMaxDistance as Integer = LeptonicaSharp._All.dewarpaSetMaxDistance(TestPix ,TestPix )"},1)

' Dim RESdewarpRead as L_Dewarp = LeptonicaSharp._All.dewarpRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpRead",TestPix, RESdewarpRead,{"Dim RESdewarpRead as L_Dewarp = LeptonicaSharp._All.dewarpRead(TestPix )"},1)

' Dim RESdewarpReadStream as L_Dewarp = LeptonicaSharp._All.dewarpReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpReadStream",TestPix, RESdewarpReadStream,{"Dim RESdewarpReadStream as L_Dewarp = LeptonicaSharp._All.dewarpReadStream(TestPix )"},1)

' Dim RESdewarpReadMem as L_Dewarp = LeptonicaSharp._All.dewarpReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpReadMem",TestPix, RESdewarpReadMem,{"Dim RESdewarpReadMem as L_Dewarp = LeptonicaSharp._All.dewarpReadMem(TestPix ,TestPix )"},1)

' Dim RESdewarpWrite as Integer = LeptonicaSharp._All.dewarpWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpWrite",TestPix, RESdewarpWrite,{"Dim RESdewarpWrite as Integer = LeptonicaSharp._All.dewarpWrite(TestPix ,TestPix )"},1)

' Dim RESdewarpWriteStream as Integer = LeptonicaSharp._All.dewarpWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpWriteStream",TestPix, RESdewarpWriteStream,{"Dim RESdewarpWriteStream as Integer = LeptonicaSharp._All.dewarpWriteStream(TestPix ,TestPix )"},1)

' Dim RESdewarpWriteMem as Integer = LeptonicaSharp._All.dewarpWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpWriteMem",TestPix, RESdewarpWriteMem,{"Dim RESdewarpWriteMem as Integer = LeptonicaSharp._All.dewarpWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESdewarpaRead as L_Dewarpa = LeptonicaSharp._All.dewarpaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaRead",TestPix, RESdewarpaRead,{"Dim RESdewarpaRead as L_Dewarpa = LeptonicaSharp._All.dewarpaRead(TestPix )"},1)

' Dim RESdewarpaReadStream as L_Dewarpa = LeptonicaSharp._All.dewarpaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaReadStream",TestPix, RESdewarpaReadStream,{"Dim RESdewarpaReadStream as L_Dewarpa = LeptonicaSharp._All.dewarpaReadStream(TestPix )"},1)

' Dim RESdewarpaReadMem as L_Dewarpa = LeptonicaSharp._All.dewarpaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaReadMem",TestPix, RESdewarpaReadMem,{"Dim RESdewarpaReadMem as L_Dewarpa = LeptonicaSharp._All.dewarpaReadMem(TestPix ,TestPix )"},1)

' Dim RESdewarpaWrite as Integer = LeptonicaSharp._All.dewarpaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaWrite",TestPix, RESdewarpaWrite,{"Dim RESdewarpaWrite as Integer = LeptonicaSharp._All.dewarpaWrite(TestPix ,TestPix )"},1)

' Dim RESdewarpaWriteStream as Integer = LeptonicaSharp._All.dewarpaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaWriteStream",TestPix, RESdewarpaWriteStream,{"Dim RESdewarpaWriteStream as Integer = LeptonicaSharp._All.dewarpaWriteStream(TestPix ,TestPix )"},1)

' Dim RESdewarpaWriteMem as Integer = LeptonicaSharp._All.dewarpaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaWriteMem",TestPix, RESdewarpaWriteMem,{"Dim RESdewarpaWriteMem as Integer = LeptonicaSharp._All.dewarpaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESdewarpBuildPageModel as Integer = LeptonicaSharp._All.dewarpBuildPageModel(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpBuildPageModel",TestPix, RESdewarpBuildPageModel,{"Dim RESdewarpBuildPageModel as Integer = LeptonicaSharp._All.dewarpBuildPageModel(TestPix ,Nothing )"},1)

' Dim RESdewarpFindVertDisparity as Integer = LeptonicaSharp._All.dewarpFindVertDisparity(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpFindVertDisparity",TestPix, RESdewarpFindVertDisparity,{"Dim RESdewarpFindVertDisparity as Integer = LeptonicaSharp._All.dewarpFindVertDisparity(TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpFindHorizDisparity as Integer = LeptonicaSharp._All.dewarpFindHorizDisparity(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpFindHorizDisparity",TestPix, RESdewarpFindHorizDisparity,{"Dim RESdewarpFindHorizDisparity as Integer = LeptonicaSharp._All.dewarpFindHorizDisparity(TestPix ,TestPix )"},1)

' Dim RESdewarpGetTextlineCenters as Ptaa = LeptonicaSharp._All.dewarpGetTextlineCenters(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpGetTextlineCenters",TestPix, RESdewarpGetTextlineCenters,{"Dim RESdewarpGetTextlineCenters as Ptaa = LeptonicaSharp._All.dewarpGetTextlineCenters(TestPix ,TestPix )"},1)

' Dim RESdewarpRemoveShortLines as Ptaa = LeptonicaSharp._All.dewarpRemoveShortLines(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpRemoveShortLines",TestPix, RESdewarpRemoveShortLines,{"Dim RESdewarpRemoveShortLines as Ptaa = LeptonicaSharp._All.dewarpRemoveShortLines(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpFindHorizSlopeDisparity as Integer = LeptonicaSharp._All.dewarpFindHorizSlopeDisparity(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpFindHorizSlopeDisparity",TestPix, RESdewarpFindHorizSlopeDisparity,{"Dim RESdewarpFindHorizSlopeDisparity as Integer = LeptonicaSharp._All.dewarpFindHorizSlopeDisparity(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpBuildLineModel as Integer = LeptonicaSharp._All.dewarpBuildLineModel(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpBuildLineModel",TestPix, RESdewarpBuildLineModel,{"Dim RESdewarpBuildLineModel as Integer = LeptonicaSharp._All.dewarpBuildLineModel(TestPix ,TestPix ,Nothing )"},1)

' Dim RESdewarpaModelStatus as Integer = LeptonicaSharp._All.dewarpaModelStatus(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaModelStatus",TestPix, RESdewarpaModelStatus,{"Dim RESdewarpaModelStatus as Integer = LeptonicaSharp._All.dewarpaModelStatus(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESdewarpaApplyDisparity as Integer = LeptonicaSharp._All.dewarpaApplyDisparity(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaApplyDisparity",TestPix, RESdewarpaApplyDisparity,{"Dim RESdewarpaApplyDisparity as Integer = LeptonicaSharp._All.dewarpaApplyDisparity(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,Nothing )"},1)

' Dim RESdewarpaApplyDisparityBoxa as Integer = LeptonicaSharp._All.dewarpaApplyDisparityBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaApplyDisparityBoxa",TestPix, RESdewarpaApplyDisparityBoxa,{"Dim RESdewarpaApplyDisparityBoxa as Integer = LeptonicaSharp._All.dewarpaApplyDisparityBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing )"},1)

' Dim RESdewarpMinimize as Integer = LeptonicaSharp._All.dewarpMinimize(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpMinimize",TestPix, RESdewarpMinimize,{"Dim RESdewarpMinimize as Integer = LeptonicaSharp._All.dewarpMinimize(TestPix )"},1)

' Dim RESdewarpPopulateFullRes as Integer = LeptonicaSharp._All.dewarpPopulateFullRes(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpPopulateFullRes",TestPix, RESdewarpPopulateFullRes,{"Dim RESdewarpPopulateFullRes as Integer = LeptonicaSharp._All.dewarpPopulateFullRes(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESdewarpSinglePage as Integer = LeptonicaSharp._All.dewarpSinglePage(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpSinglePage",TestPix, RESdewarpSinglePage,{"Dim RESdewarpSinglePage as Integer = LeptonicaSharp._All.dewarpSinglePage(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,Nothing ,Nothing )"},1)

' Dim RESdewarpSinglePageInit as Integer = LeptonicaSharp._All.dewarpSinglePageInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New L_Dewarpa)
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpSinglePageInit",TestPix, RESdewarpSinglePageInit,{"Dim RESdewarpSinglePageInit as Integer = LeptonicaSharp._All.dewarpSinglePageInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Pix,New L_Dewarpa)"},1)

' Dim RESdewarpSinglePageRun as Integer = LeptonicaSharp._All.dewarpSinglePageRun(TestPix ,TestPix ,TestPix ,New Pix,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpSinglePageRun",TestPix, RESdewarpSinglePageRun,{"Dim RESdewarpSinglePageRun as Integer = LeptonicaSharp._All.dewarpSinglePageRun(TestPix ,TestPix ,TestPix ,New Pix,Nothing )"},1)

' Dim RESdewarpaListPages as Integer = LeptonicaSharp._All.dewarpaListPages(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaListPages",TestPix, RESdewarpaListPages,{"Dim RESdewarpaListPages as Integer = LeptonicaSharp._All.dewarpaListPages(TestPix )"},1)

' Dim RESdewarpaSetValidModels as Integer = LeptonicaSharp._All.dewarpaSetValidModels(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaSetValidModels",TestPix, RESdewarpaSetValidModels,{"Dim RESdewarpaSetValidModels as Integer = LeptonicaSharp._All.dewarpaSetValidModels(TestPix ,TestPix ,Nothing )"},1)

' Dim RESdewarpaInsertRefModels as Integer = LeptonicaSharp._All.dewarpaInsertRefModels(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaInsertRefModels",TestPix, RESdewarpaInsertRefModels,{"Dim RESdewarpaInsertRefModels as Integer = LeptonicaSharp._All.dewarpaInsertRefModels(TestPix ,TestPix ,Nothing )"},1)

' Dim RESdewarpaStripRefModels as Integer = LeptonicaSharp._All.dewarpaStripRefModels(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaStripRefModels",TestPix, RESdewarpaStripRefModels,{"Dim RESdewarpaStripRefModels as Integer = LeptonicaSharp._All.dewarpaStripRefModels(TestPix )"},1)

' Dim RESdewarpaRestoreModels as Integer = LeptonicaSharp._All.dewarpaRestoreModels(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaRestoreModels",TestPix, RESdewarpaRestoreModels,{"Dim RESdewarpaRestoreModels as Integer = LeptonicaSharp._All.dewarpaRestoreModels(TestPix )"},1)

' Dim RESdewarpaInfo as Integer = LeptonicaSharp._All.dewarpaInfo(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaInfo",TestPix, RESdewarpaInfo,{"Dim RESdewarpaInfo as Integer = LeptonicaSharp._All.dewarpaInfo(TestPix ,TestPix )"},1)

' Dim RESdewarpaModelStats as Integer = LeptonicaSharp._All.dewarpaModelStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaModelStats",TestPix, RESdewarpaModelStats,{"Dim RESdewarpaModelStats as Integer = LeptonicaSharp._All.dewarpaModelStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESdewarpaShowArrays as Integer = LeptonicaSharp._All.dewarpaShowArrays(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpaShowArrays",TestPix, RESdewarpaShowArrays,{"Dim RESdewarpaShowArrays as Integer = LeptonicaSharp._All.dewarpaShowArrays(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpDebug as Integer = LeptonicaSharp._All.dewarpDebug(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpDebug",TestPix, RESdewarpDebug,{"Dim RESdewarpDebug as Integer = LeptonicaSharp._All.dewarpDebug(TestPix ,TestPix ,TestPix )"},1)

' Dim RESdewarpShowResults as Integer = LeptonicaSharp._All.dewarpShowResults(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dewarpShowResults",TestPix, RESdewarpShowResults,{"Dim RESdewarpShowResults as Integer = LeptonicaSharp._All.dewarpShowResults(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaCreate as L_Dna = LeptonicaSharp._All.l_dnaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaCreate",TestPix, RESl_dnaCreate,{"Dim RESl_dnaCreate as L_Dna = LeptonicaSharp._All.l_dnaCreate(TestPix )"},1)

' Dim RESl_dnaCreateFromIArray as L_Dna = LeptonicaSharp._All.l_dnaCreateFromIArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaCreateFromIArray",TestPix, RESl_dnaCreateFromIArray,{"Dim RESl_dnaCreateFromIArray as L_Dna = LeptonicaSharp._All.l_dnaCreateFromIArray(TestPix ,TestPix )"},1)

' Dim RESl_dnaCreateFromDArray as L_Dna = LeptonicaSharp._All.l_dnaCreateFromDArray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaCreateFromDArray",TestPix, RESl_dnaCreateFromDArray,{"Dim RESl_dnaCreateFromDArray as L_Dna = LeptonicaSharp._All.l_dnaCreateFromDArray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaMakeSequence as L_Dna = LeptonicaSharp._All.l_dnaMakeSequence(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaMakeSequence",TestPix, RESl_dnaMakeSequence,{"Dim RESl_dnaMakeSequence as L_Dna = LeptonicaSharp._All.l_dnaMakeSequence(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaDestroy as Object = LeptonicaSharp._All.l_dnaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaDestroy",TestPix, RESl_dnaDestroy,{"Dim RESl_dnaDestroy as Object = LeptonicaSharp._All.l_dnaDestroy(TestPix )"},1)

' Dim RESl_dnaCopy as L_Dna = LeptonicaSharp._All.l_dnaCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaCopy",TestPix, RESl_dnaCopy,{"Dim RESl_dnaCopy as L_Dna = LeptonicaSharp._All.l_dnaCopy(TestPix )"},1)

' Dim RESl_dnaClone as L_Dna = LeptonicaSharp._All.l_dnaClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaClone",TestPix, RESl_dnaClone,{"Dim RESl_dnaClone as L_Dna = LeptonicaSharp._All.l_dnaClone(TestPix )"},1)

' Dim RESl_dnaEmpty as Integer = LeptonicaSharp._All.l_dnaEmpty(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaEmpty",TestPix, RESl_dnaEmpty,{"Dim RESl_dnaEmpty as Integer = LeptonicaSharp._All.l_dnaEmpty(TestPix )"},1)

' Dim RESl_dnaAddNumber as Integer = LeptonicaSharp._All.l_dnaAddNumber(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaAddNumber",TestPix, RESl_dnaAddNumber,{"Dim RESl_dnaAddNumber as Integer = LeptonicaSharp._All.l_dnaAddNumber(TestPix ,TestPix )"},1)

' Dim RESl_dnaInsertNumber as Integer = LeptonicaSharp._All.l_dnaInsertNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaInsertNumber",TestPix, RESl_dnaInsertNumber,{"Dim RESl_dnaInsertNumber as Integer = LeptonicaSharp._All.l_dnaInsertNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaRemoveNumber as Integer = LeptonicaSharp._All.l_dnaRemoveNumber(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaRemoveNumber",TestPix, RESl_dnaRemoveNumber,{"Dim RESl_dnaRemoveNumber as Integer = LeptonicaSharp._All.l_dnaRemoveNumber(TestPix ,TestPix )"},1)

' Dim RESl_dnaReplaceNumber as Integer = LeptonicaSharp._All.l_dnaReplaceNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaReplaceNumber",TestPix, RESl_dnaReplaceNumber,{"Dim RESl_dnaReplaceNumber as Integer = LeptonicaSharp._All.l_dnaReplaceNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaGetCount as Integer = LeptonicaSharp._All.l_dnaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetCount",TestPix, RESl_dnaGetCount,{"Dim RESl_dnaGetCount as Integer = LeptonicaSharp._All.l_dnaGetCount(TestPix )"},1)

' Dim RESl_dnaSetCount as Integer = LeptonicaSharp._All.l_dnaSetCount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaSetCount",TestPix, RESl_dnaSetCount,{"Dim RESl_dnaSetCount as Integer = LeptonicaSharp._All.l_dnaSetCount(TestPix ,TestPix )"},1)

' Dim RESl_dnaGetDValue as Integer = LeptonicaSharp._All.l_dnaGetDValue(TestPix ,TestPix ,New Double())
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetDValue",TestPix, RESl_dnaGetDValue,{"Dim RESl_dnaGetDValue as Integer = LeptonicaSharp._All.l_dnaGetDValue(TestPix ,TestPix ,New Double())"},1)

' Dim RESl_dnaGetIValue as Integer = LeptonicaSharp._All.l_dnaGetIValue(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetIValue",TestPix, RESl_dnaGetIValue,{"Dim RESl_dnaGetIValue as Integer = LeptonicaSharp._All.l_dnaGetIValue(TestPix ,TestPix ,New Integer)"},1)

' Dim RESl_dnaSetValue as Integer = LeptonicaSharp._All.l_dnaSetValue(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaSetValue",TestPix, RESl_dnaSetValue,{"Dim RESl_dnaSetValue as Integer = LeptonicaSharp._All.l_dnaSetValue(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaShiftValue as Integer = LeptonicaSharp._All.l_dnaShiftValue(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaShiftValue",TestPix, RESl_dnaShiftValue,{"Dim RESl_dnaShiftValue as Integer = LeptonicaSharp._All.l_dnaShiftValue(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaGetIArray as Integer() = LeptonicaSharp._All.l_dnaGetIArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetIArray",TestPix, RESl_dnaGetIArray,{"Dim RESl_dnaGetIArray as Integer() = LeptonicaSharp._All.l_dnaGetIArray(TestPix )"},1)

' Dim RESl_dnaGetDArray as Double() = LeptonicaSharp._All.l_dnaGetDArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetDArray",TestPix, RESl_dnaGetDArray,{"Dim RESl_dnaGetDArray as Double() = LeptonicaSharp._All.l_dnaGetDArray(TestPix ,TestPix )"},1)

' Dim RESl_dnaGetRefcount as Integer = LeptonicaSharp._All.l_dnaGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetRefcount",TestPix, RESl_dnaGetRefcount,{"Dim RESl_dnaGetRefcount as Integer = LeptonicaSharp._All.l_dnaGetRefcount(TestPix )"},1)

' Dim RESl_dnaChangeRefcount as Integer = LeptonicaSharp._All.l_dnaChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaChangeRefcount",TestPix, RESl_dnaChangeRefcount,{"Dim RESl_dnaChangeRefcount as Integer = LeptonicaSharp._All.l_dnaChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESl_dnaGetParameters as Integer = LeptonicaSharp._All.l_dnaGetParameters(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaGetParameters",TestPix, RESl_dnaGetParameters,{"Dim RESl_dnaGetParameters as Integer = LeptonicaSharp._All.l_dnaGetParameters(TestPix ,Nothing ,Nothing )"},1)

' Dim RESl_dnaSetParameters as Integer = LeptonicaSharp._All.l_dnaSetParameters(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaSetParameters",TestPix, RESl_dnaSetParameters,{"Dim RESl_dnaSetParameters as Integer = LeptonicaSharp._All.l_dnaSetParameters(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaCopyParameters as Integer = LeptonicaSharp._All.l_dnaCopyParameters(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaCopyParameters",TestPix, RESl_dnaCopyParameters,{"Dim RESl_dnaCopyParameters as Integer = LeptonicaSharp._All.l_dnaCopyParameters(TestPix ,TestPix )"},1)

' Dim RESl_dnaRead as L_Dna = LeptonicaSharp._All.l_dnaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaRead",TestPix, RESl_dnaRead,{"Dim RESl_dnaRead as L_Dna = LeptonicaSharp._All.l_dnaRead(TestPix )"},1)

' Dim RESl_dnaReadStream as L_Dna = LeptonicaSharp._All.l_dnaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaReadStream",TestPix, RESl_dnaReadStream,{"Dim RESl_dnaReadStream as L_Dna = LeptonicaSharp._All.l_dnaReadStream(TestPix )"},1)

' Dim RESl_dnaWrite as Integer = LeptonicaSharp._All.l_dnaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaWrite",TestPix, RESl_dnaWrite,{"Dim RESl_dnaWrite as Integer = LeptonicaSharp._All.l_dnaWrite(TestPix ,TestPix )"},1)

' Dim RESl_dnaWriteStream as Integer = LeptonicaSharp._All.l_dnaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaWriteStream",TestPix, RESl_dnaWriteStream,{"Dim RESl_dnaWriteStream as Integer = LeptonicaSharp._All.l_dnaWriteStream(TestPix ,TestPix )"},1)

' Dim RESl_dnaaCreate as L_Dnaa = LeptonicaSharp._All.l_dnaaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaCreate",TestPix, RESl_dnaaCreate,{"Dim RESl_dnaaCreate as L_Dnaa = LeptonicaSharp._All.l_dnaaCreate(TestPix )"},1)

' Dim RESl_dnaaCreateFull as L_Dnaa = LeptonicaSharp._All.l_dnaaCreateFull(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaCreateFull",TestPix, RESl_dnaaCreateFull,{"Dim RESl_dnaaCreateFull as L_Dnaa = LeptonicaSharp._All.l_dnaaCreateFull(TestPix ,TestPix )"},1)

' Dim RESl_dnaaTruncate as Integer = LeptonicaSharp._All.l_dnaaTruncate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaTruncate",TestPix, RESl_dnaaTruncate,{"Dim RESl_dnaaTruncate as Integer = LeptonicaSharp._All.l_dnaaTruncate(TestPix )"},1)

' Dim RESl_dnaaDestroy as Object = LeptonicaSharp._All.l_dnaaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaDestroy",TestPix, RESl_dnaaDestroy,{"Dim RESl_dnaaDestroy as Object = LeptonicaSharp._All.l_dnaaDestroy(TestPix )"},1)

' Dim RESl_dnaaAddDna as Integer = LeptonicaSharp._All.l_dnaaAddDna(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaAddDna",TestPix, RESl_dnaaAddDna,{"Dim RESl_dnaaAddDna as Integer = LeptonicaSharp._All.l_dnaaAddDna(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaaGetCount as Integer = LeptonicaSharp._All.l_dnaaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaGetCount",TestPix, RESl_dnaaGetCount,{"Dim RESl_dnaaGetCount as Integer = LeptonicaSharp._All.l_dnaaGetCount(TestPix )"},1)

' Dim RESl_dnaaGetDnaCount as Integer = LeptonicaSharp._All.l_dnaaGetDnaCount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaGetDnaCount",TestPix, RESl_dnaaGetDnaCount,{"Dim RESl_dnaaGetDnaCount as Integer = LeptonicaSharp._All.l_dnaaGetDnaCount(TestPix ,TestPix )"},1)

' Dim RESl_dnaaGetNumberCount as Integer = LeptonicaSharp._All.l_dnaaGetNumberCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaGetNumberCount",TestPix, RESl_dnaaGetNumberCount,{"Dim RESl_dnaaGetNumberCount as Integer = LeptonicaSharp._All.l_dnaaGetNumberCount(TestPix )"},1)

' Dim RESl_dnaaGetDna as L_Dna = LeptonicaSharp._All.l_dnaaGetDna(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaGetDna",TestPix, RESl_dnaaGetDna,{"Dim RESl_dnaaGetDna as L_Dna = LeptonicaSharp._All.l_dnaaGetDna(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaaReplaceDna as Integer = LeptonicaSharp._All.l_dnaaReplaceDna(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaReplaceDna",TestPix, RESl_dnaaReplaceDna,{"Dim RESl_dnaaReplaceDna as Integer = LeptonicaSharp._All.l_dnaaReplaceDna(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaaGetValue as Integer = LeptonicaSharp._All.l_dnaaGetValue(TestPix ,TestPix ,TestPix ,New Double())
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaGetValue",TestPix, RESl_dnaaGetValue,{"Dim RESl_dnaaGetValue as Integer = LeptonicaSharp._All.l_dnaaGetValue(TestPix ,TestPix ,TestPix ,New Double())"},1)

' Dim RESl_dnaaAddNumber as Integer = LeptonicaSharp._All.l_dnaaAddNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaAddNumber",TestPix, RESl_dnaaAddNumber,{"Dim RESl_dnaaAddNumber as Integer = LeptonicaSharp._All.l_dnaaAddNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaaRead as L_Dnaa = LeptonicaSharp._All.l_dnaaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaRead",TestPix, RESl_dnaaRead,{"Dim RESl_dnaaRead as L_Dnaa = LeptonicaSharp._All.l_dnaaRead(TestPix )"},1)

' Dim RESl_dnaaReadStream as L_Dnaa = LeptonicaSharp._All.l_dnaaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaReadStream",TestPix, RESl_dnaaReadStream,{"Dim RESl_dnaaReadStream as L_Dnaa = LeptonicaSharp._All.l_dnaaReadStream(TestPix )"},1)

' Dim RESl_dnaaWrite as Integer = LeptonicaSharp._All.l_dnaaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaWrite",TestPix, RESl_dnaaWrite,{"Dim RESl_dnaaWrite as Integer = LeptonicaSharp._All.l_dnaaWrite(TestPix ,TestPix )"},1)

' Dim RESl_dnaaWriteStream as Integer = LeptonicaSharp._All.l_dnaaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaWriteStream",TestPix, RESl_dnaaWriteStream,{"Dim RESl_dnaaWriteStream as Integer = LeptonicaSharp._All.l_dnaaWriteStream(TestPix ,TestPix )"},1)

' Dim RESl_dnaJoin as Integer = LeptonicaSharp._All.l_dnaJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaJoin",TestPix, RESl_dnaJoin,{"Dim RESl_dnaJoin as Integer = LeptonicaSharp._All.l_dnaJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESl_dnaaFlattenToDna as L_Dna = LeptonicaSharp._All.l_dnaaFlattenToDna(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaaFlattenToDna",TestPix, RESl_dnaaFlattenToDna,{"Dim RESl_dnaaFlattenToDna as L_Dna = LeptonicaSharp._All.l_dnaaFlattenToDna(TestPix )"},1)

' Dim RESl_dnaConvertToNuma as Numa = LeptonicaSharp._All.l_dnaConvertToNuma(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaConvertToNuma",TestPix, RESl_dnaConvertToNuma,{"Dim RESl_dnaConvertToNuma as Numa = LeptonicaSharp._All.l_dnaConvertToNuma(TestPix )"},1)

' Dim RESnumaConvertToDna as L_Dna = LeptonicaSharp._All.numaConvertToDna(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaConvertToDna",TestPix, RESnumaConvertToDna,{"Dim RESnumaConvertToDna as L_Dna = LeptonicaSharp._All.numaConvertToDna(TestPix )"},1)

' Dim RESl_dnaUnionByAset as L_Dna = LeptonicaSharp._All.l_dnaUnionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaUnionByAset",TestPix, RESl_dnaUnionByAset,{"Dim RESl_dnaUnionByAset as L_Dna = LeptonicaSharp._All.l_dnaUnionByAset(TestPix ,TestPix )"},1)

' Dim RESl_dnaRemoveDupsByAset as L_Dna = LeptonicaSharp._All.l_dnaRemoveDupsByAset(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaRemoveDupsByAset",TestPix, RESl_dnaRemoveDupsByAset,{"Dim RESl_dnaRemoveDupsByAset as L_Dna = LeptonicaSharp._All.l_dnaRemoveDupsByAset(TestPix )"},1)

' Dim RESl_dnaIntersectionByAset as L_Dna = LeptonicaSharp._All.l_dnaIntersectionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaIntersectionByAset",TestPix, RESl_dnaIntersectionByAset,{"Dim RESl_dnaIntersectionByAset as L_Dna = LeptonicaSharp._All.l_dnaIntersectionByAset(TestPix ,TestPix )"},1)

' Dim RESl_asetCreateFromDna as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromDna(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetCreateFromDna",TestPix, RESl_asetCreateFromDna,{"Dim RESl_asetCreateFromDna as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromDna(TestPix )"},1)

' Dim RESl_dnaDiffAdjValues as L_Dna = LeptonicaSharp._All.l_dnaDiffAdjValues(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaDiffAdjValues",TestPix, RESl_dnaDiffAdjValues,{"Dim RESl_dnaDiffAdjValues as L_Dna = LeptonicaSharp._All.l_dnaDiffAdjValues(TestPix )"},1)

' Dim RESl_dnaHashCreate as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashCreate",TestPix, RESl_dnaHashCreate,{"Dim RESl_dnaHashCreate as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreate(TestPix ,TestPix )"},1)

' Dim RESl_dnaHashDestroy as Object = LeptonicaSharp._All.l_dnaHashDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashDestroy",TestPix, RESl_dnaHashDestroy,{"Dim RESl_dnaHashDestroy as Object = LeptonicaSharp._All.l_dnaHashDestroy(TestPix )"},1)

' Dim RESl_dnaHashGetCount as Integer = LeptonicaSharp._All.l_dnaHashGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashGetCount",TestPix, RESl_dnaHashGetCount,{"Dim RESl_dnaHashGetCount as Integer = LeptonicaSharp._All.l_dnaHashGetCount(TestPix )"},1)

' Dim RESl_dnaHashGetTotalCount as Integer = LeptonicaSharp._All.l_dnaHashGetTotalCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashGetTotalCount",TestPix, RESl_dnaHashGetTotalCount,{"Dim RESl_dnaHashGetTotalCount as Integer = LeptonicaSharp._All.l_dnaHashGetTotalCount(TestPix )"},1)

' Dim RESl_dnaHashGetDna as L_Dna = LeptonicaSharp._All.l_dnaHashGetDna(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashGetDna",TestPix, RESl_dnaHashGetDna,{"Dim RESl_dnaHashGetDna as L_Dna = LeptonicaSharp._All.l_dnaHashGetDna(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaHashAdd as Integer = LeptonicaSharp._All.l_dnaHashAdd(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashAdd",TestPix, RESl_dnaHashAdd,{"Dim RESl_dnaHashAdd as Integer = LeptonicaSharp._All.l_dnaHashAdd(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_dnaHashCreateFromDna as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromDna(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashCreateFromDna",TestPix, RESl_dnaHashCreateFromDna,{"Dim RESl_dnaHashCreateFromDna as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromDna(TestPix )"},1)

' Dim RESl_dnaRemoveDupsByHash as Integer = LeptonicaSharp._All.l_dnaRemoveDupsByHash(TestPix ,New L_Dna,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaRemoveDupsByHash",TestPix, RESl_dnaRemoveDupsByHash,{"Dim RESl_dnaRemoveDupsByHash as Integer = LeptonicaSharp._All.l_dnaRemoveDupsByHash(TestPix ,New L_Dna,Nothing )"},1)

' Dim RESl_dnaMakeHistoByHash as Integer = LeptonicaSharp._All.l_dnaMakeHistoByHash(TestPix ,New L_DnaHash,New L_Dna,New L_Dna)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaMakeHistoByHash",TestPix, RESl_dnaMakeHistoByHash,{"Dim RESl_dnaMakeHistoByHash as Integer = LeptonicaSharp._All.l_dnaMakeHistoByHash(TestPix ,New L_DnaHash,New L_Dna,New L_Dna)"},1)

' Dim RESl_dnaIntersectionByHash as L_Dna = LeptonicaSharp._All.l_dnaIntersectionByHash(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaIntersectionByHash",TestPix, RESl_dnaIntersectionByHash,{"Dim RESl_dnaIntersectionByHash as L_Dna = LeptonicaSharp._All.l_dnaIntersectionByHash(TestPix ,TestPix )"},1)

' Dim RESl_dnaFindValByHash as Integer = LeptonicaSharp._All.l_dnaFindValByHash(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaFindValByHash",TestPix, RESl_dnaFindValByHash,{"Dim RESl_dnaFindValByHash as Integer = LeptonicaSharp._All.l_dnaFindValByHash(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixMorphDwa_2 as Pix = LeptonicaSharp._All.pixMorphDwa_2(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphDwa_2",TestPix, RESpixMorphDwa_2,{"Dim RESpixMorphDwa_2 as Pix = LeptonicaSharp._All.pixMorphDwa_2(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFMorphopGen_2 as Pix = LeptonicaSharp._All.pixFMorphopGen_2(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFMorphopGen_2",TestPix, RESpixFMorphopGen_2,{"Dim RESpixFMorphopGen_2 as Pix = LeptonicaSharp._All.pixFMorphopGen_2(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfmorphopgen_low_2 as Integer = LeptonicaSharp._All.fmorphopgen_low_2(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fmorphopgen_low_2",TestPix, RESfmorphopgen_low_2,{"Dim RESfmorphopgen_low_2 as Integer = LeptonicaSharp._All.fmorphopgen_low_2(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSobelEdgeFilter as Pix = LeptonicaSharp._All.pixSobelEdgeFilter(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSobelEdgeFilter",TestPix, RESpixSobelEdgeFilter,{"Dim RESpixSobelEdgeFilter as Pix = LeptonicaSharp._All.pixSobelEdgeFilter(TestPix ,TestPix )"},1)

' Dim RESpixTwoSidedEdgeFilter as Pix = LeptonicaSharp._All.pixTwoSidedEdgeFilter(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTwoSidedEdgeFilter",TestPix, RESpixTwoSidedEdgeFilter,{"Dim RESpixTwoSidedEdgeFilter as Pix = LeptonicaSharp._All.pixTwoSidedEdgeFilter(TestPix ,TestPix )"},1)

' Dim RESpixMeasureEdgeSmoothness as Integer = LeptonicaSharp._All.pixMeasureEdgeSmoothness(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMeasureEdgeSmoothness",TestPix, RESpixMeasureEdgeSmoothness,{"Dim RESpixMeasureEdgeSmoothness as Integer = LeptonicaSharp._All.pixMeasureEdgeSmoothness(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetEdgeProfile as Numa = LeptonicaSharp._All.pixGetEdgeProfile(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetEdgeProfile",TestPix, RESpixGetEdgeProfile,{"Dim RESpixGetEdgeProfile as Numa = LeptonicaSharp._All.pixGetEdgeProfile(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGetLastOffPixelInRun as Integer = LeptonicaSharp._All.pixGetLastOffPixelInRun(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetLastOffPixelInRun",TestPix, RESpixGetLastOffPixelInRun,{"Dim RESpixGetLastOffPixelInRun as Integer = LeptonicaSharp._All.pixGetLastOffPixelInRun(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetLastOnPixelInRun as Integer = LeptonicaSharp._All.pixGetLastOnPixelInRun(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetLastOnPixelInRun",TestPix, RESpixGetLastOnPixelInRun,{"Dim RESpixGetLastOnPixelInRun as Integer = LeptonicaSharp._All.pixGetLastOnPixelInRun(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESencodeBase64 as String = LeptonicaSharp._All.encodeBase64(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("encodeBase64",TestPix, RESencodeBase64,{"Dim RESencodeBase64 as String = LeptonicaSharp._All.encodeBase64(TestPix ,TestPix ,New Integer)"},1)

' Dim RESdecodeBase64 as Byte() = LeptonicaSharp._All.decodeBase64(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("decodeBase64",TestPix, RESdecodeBase64,{"Dim RESdecodeBase64 as Byte() = LeptonicaSharp._All.decodeBase64(TestPix ,TestPix ,New Integer)"},1)

' Dim RESencodeAscii85 as String = LeptonicaSharp._All.encodeAscii85(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("encodeAscii85",TestPix, RESencodeAscii85,{"Dim RESencodeAscii85 as String = LeptonicaSharp._All.encodeAscii85(TestPix ,TestPix ,New Integer)"},1)

' Dim RESdecodeAscii85 as Byte() = LeptonicaSharp._All.decodeAscii85(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("decodeAscii85",TestPix, RESdecodeAscii85,{"Dim RESdecodeAscii85 as Byte() = LeptonicaSharp._All.decodeAscii85(TestPix ,TestPix ,New Integer)"},1)

' Dim RESreformatPacked64 as String = LeptonicaSharp._All.reformatPacked64(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("reformatPacked64",TestPix, RESreformatPacked64,{"Dim RESreformatPacked64 as String = LeptonicaSharp._All.reformatPacked64(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixGammaTRC as Pix = LeptonicaSharp._All.pixGammaTRC(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGammaTRC",TestPix, RESpixGammaTRC,{"Dim RESpixGammaTRC as Pix = LeptonicaSharp._All.pixGammaTRC(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGammaTRCMasked as Pix = LeptonicaSharp._All.pixGammaTRCMasked(Nothing ,TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGammaTRCMasked",TestPix, RESpixGammaTRCMasked,{"Dim RESpixGammaTRCMasked as Pix = LeptonicaSharp._All.pixGammaTRCMasked(Nothing ,TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGammaTRCWithAlpha as Pix = LeptonicaSharp._All.pixGammaTRCWithAlpha(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGammaTRCWithAlpha",TestPix, RESpixGammaTRCWithAlpha,{"Dim RESpixGammaTRCWithAlpha as Pix = LeptonicaSharp._All.pixGammaTRCWithAlpha(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaGammaTRC as Numa = LeptonicaSharp._All.numaGammaTRC(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGammaTRC",TestPix, RESnumaGammaTRC,{"Dim RESnumaGammaTRC as Numa = LeptonicaSharp._All.numaGammaTRC(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixContrastTRC as Pix = LeptonicaSharp._All.pixContrastTRC(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixContrastTRC",TestPix, RESpixContrastTRC,{"Dim RESpixContrastTRC as Pix = LeptonicaSharp._All.pixContrastTRC(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixContrastTRCMasked as Pix = LeptonicaSharp._All.pixContrastTRCMasked(Nothing ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixContrastTRCMasked",TestPix, RESpixContrastTRCMasked,{"Dim RESpixContrastTRCMasked as Pix = LeptonicaSharp._All.pixContrastTRCMasked(Nothing ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESnumaContrastTRC as Numa = LeptonicaSharp._All.numaContrastTRC(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaContrastTRC",TestPix, RESnumaContrastTRC,{"Dim RESnumaContrastTRC as Numa = LeptonicaSharp._All.numaContrastTRC(TestPix )"},1)

' Dim RESpixEqualizeTRC as Pix = LeptonicaSharp._All.pixEqualizeTRC(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEqualizeTRC",TestPix, RESpixEqualizeTRC,{"Dim RESpixEqualizeTRC as Pix = LeptonicaSharp._All.pixEqualizeTRC(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaEqualizeTRC as Numa = LeptonicaSharp._All.numaEqualizeTRC(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaEqualizeTRC",TestPix, RESnumaEqualizeTRC,{"Dim RESnumaEqualizeTRC as Numa = LeptonicaSharp._All.numaEqualizeTRC(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTRCMap as Integer = LeptonicaSharp._All.pixTRCMap(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTRCMap",TestPix, RESpixTRCMap,{"Dim RESpixTRCMap as Integer = LeptonicaSharp._All.pixTRCMap(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixUnsharpMasking as Pix = LeptonicaSharp._All.pixUnsharpMasking(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMasking",TestPix, RESpixUnsharpMasking,{"Dim RESpixUnsharpMasking as Pix = LeptonicaSharp._All.pixUnsharpMasking(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnsharpMaskingGray as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMaskingGray",TestPix, RESpixUnsharpMaskingGray,{"Dim RESpixUnsharpMaskingGray as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnsharpMaskingFast as Pix = LeptonicaSharp._All.pixUnsharpMaskingFast(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMaskingFast",TestPix, RESpixUnsharpMaskingFast,{"Dim RESpixUnsharpMaskingFast as Pix = LeptonicaSharp._All.pixUnsharpMaskingFast(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnsharpMaskingGrayFast as Pix = LeptonicaSharp._All.pixUnsharpMaskingGrayFast(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMaskingGrayFast",TestPix, RESpixUnsharpMaskingGrayFast,{"Dim RESpixUnsharpMaskingGrayFast as Pix = LeptonicaSharp._All.pixUnsharpMaskingGrayFast(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnsharpMaskingGray1D as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray1D(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMaskingGray1D",TestPix, RESpixUnsharpMaskingGray1D,{"Dim RESpixUnsharpMaskingGray1D as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray1D(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnsharpMaskingGray2D as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray2D(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnsharpMaskingGray2D",TestPix, RESpixUnsharpMaskingGray2D,{"Dim RESpixUnsharpMaskingGray2D as Pix = LeptonicaSharp._All.pixUnsharpMaskingGray2D(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixModifyHue as Pix = LeptonicaSharp._All.pixModifyHue(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixModifyHue",TestPix, RESpixModifyHue,{"Dim RESpixModifyHue as Pix = LeptonicaSharp._All.pixModifyHue(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixModifySaturation as Pix = LeptonicaSharp._All.pixModifySaturation(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixModifySaturation",TestPix, RESpixModifySaturation,{"Dim RESpixModifySaturation as Pix = LeptonicaSharp._All.pixModifySaturation(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixMeasureSaturation as Integer = LeptonicaSharp._All.pixMeasureSaturation(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMeasureSaturation",TestPix, RESpixMeasureSaturation,{"Dim RESpixMeasureSaturation as Integer = LeptonicaSharp._All.pixMeasureSaturation(TestPix ,TestPix ,New Single)"},1)

' Dim RESpixModifyBrightness as Pix = LeptonicaSharp._All.pixModifyBrightness(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixModifyBrightness",TestPix, RESpixModifyBrightness,{"Dim RESpixModifyBrightness as Pix = LeptonicaSharp._All.pixModifyBrightness(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixMosaicColorShiftRGB as Pix = LeptonicaSharp._All.pixMosaicColorShiftRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMosaicColorShiftRGB",TestPix, RESpixMosaicColorShiftRGB,{"Dim RESpixMosaicColorShiftRGB as Pix = LeptonicaSharp._All.pixMosaicColorShiftRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorShiftRGB as Pix = LeptonicaSharp._All.pixColorShiftRGB(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorShiftRGB",TestPix, RESpixColorShiftRGB,{"Dim RESpixColorShiftRGB as Pix = LeptonicaSharp._All.pixColorShiftRGB(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDarkenGray as Pix = LeptonicaSharp._All.pixDarkenGray(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDarkenGray",TestPix, RESpixDarkenGray,{"Dim RESpixDarkenGray as Pix = LeptonicaSharp._All.pixDarkenGray(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMultConstantColor as Pix = LeptonicaSharp._All.pixMultConstantColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMultConstantColor",TestPix, RESpixMultConstantColor,{"Dim RESpixMultConstantColor as Pix = LeptonicaSharp._All.pixMultConstantColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMultMatrixColor as Pix = LeptonicaSharp._All.pixMultMatrixColor(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMultMatrixColor",TestPix, RESpixMultMatrixColor,{"Dim RESpixMultMatrixColor as Pix = LeptonicaSharp._All.pixMultMatrixColor(TestPix ,TestPix )"},1)

' Dim RESpixHalfEdgeByBandpass as Pix = LeptonicaSharp._All.pixHalfEdgeByBandpass(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHalfEdgeByBandpass",TestPix, RESpixHalfEdgeByBandpass,{"Dim RESpixHalfEdgeByBandpass as Pix = LeptonicaSharp._All.pixHalfEdgeByBandpass(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfhmtautogen as Integer = LeptonicaSharp._All.fhmtautogen(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fhmtautogen",TestPix, RESfhmtautogen,{"Dim RESfhmtautogen as Integer = LeptonicaSharp._All.fhmtautogen(TestPix ,TestPix ,Nothing )"},1)

' Dim RESfhmtautogen1 as Integer = LeptonicaSharp._All.fhmtautogen1(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fhmtautogen1",TestPix, RESfhmtautogen1,{"Dim RESfhmtautogen1 as Integer = LeptonicaSharp._All.fhmtautogen1(TestPix ,TestPix ,Nothing )"},1)

' Dim RESfhmtautogen2 as Integer = LeptonicaSharp._All.fhmtautogen2(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fhmtautogen2",TestPix, RESfhmtautogen2,{"Dim RESfhmtautogen2 as Integer = LeptonicaSharp._All.fhmtautogen2(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixHMTDwa_1 as Pix = LeptonicaSharp._All.pixHMTDwa_1(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHMTDwa_1",TestPix, RESpixHMTDwa_1,{"Dim RESpixHMTDwa_1 as Pix = LeptonicaSharp._All.pixHMTDwa_1(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFHMTGen_1 as Pix = LeptonicaSharp._All.pixFHMTGen_1(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFHMTGen_1",TestPix, RESpixFHMTGen_1,{"Dim RESpixFHMTGen_1 as Pix = LeptonicaSharp._All.pixFHMTGen_1(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfhmtgen_low_1 as Integer = LeptonicaSharp._All.fhmtgen_low_1(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fhmtgen_low_1",TestPix, RESfhmtgen_low_1,{"Dim RESfhmtgen_low_1 as Integer = LeptonicaSharp._All.fhmtgen_low_1(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixItalicWords as Integer = LeptonicaSharp._All.pixItalicWords(TestPix ,Nothing ,Nothing ,New Boxa,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixItalicWords",TestPix, RESpixItalicWords,{"Dim RESpixItalicWords as Integer = LeptonicaSharp._All.pixItalicWords(TestPix ,Nothing ,Nothing ,New Boxa,TestPix )"},1)

' Dim RESpixOrientCorrect as Pix = LeptonicaSharp._All.pixOrientCorrect(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOrientCorrect",TestPix, RESpixOrientCorrect,{"Dim RESpixOrientCorrect as Pix = LeptonicaSharp._All.pixOrientCorrect(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixOrientDetect as Integer = LeptonicaSharp._All.pixOrientDetect(TestPix ,Nothing ,Nothing ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOrientDetect",TestPix, RESpixOrientDetect,{"Dim RESpixOrientDetect as Integer = LeptonicaSharp._All.pixOrientDetect(TestPix ,Nothing ,Nothing ,TestPix ,Nothing )"},1)

' Dim RESmakeOrientDecision as Integer = LeptonicaSharp._All.makeOrientDecision(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeOrientDecision",TestPix, RESmakeOrientDecision,{"Dim RESmakeOrientDecision as Integer = LeptonicaSharp._All.makeOrientDecision(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESpixUpDownDetect as Integer = LeptonicaSharp._All.pixUpDownDetect(TestPix ,New Single,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUpDownDetect",TestPix, RESpixUpDownDetect,{"Dim RESpixUpDownDetect as Integer = LeptonicaSharp._All.pixUpDownDetect(TestPix ,New Single,TestPix ,Nothing )"},1)

' Dim RESpixUpDownDetectGeneral as Integer = LeptonicaSharp._All.pixUpDownDetectGeneral(TestPix ,New Single,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUpDownDetectGeneral",TestPix, RESpixUpDownDetectGeneral,{"Dim RESpixUpDownDetectGeneral as Integer = LeptonicaSharp._All.pixUpDownDetectGeneral(TestPix ,New Single,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixOrientDetectDwa as Integer = LeptonicaSharp._All.pixOrientDetectDwa(TestPix ,Nothing ,Nothing ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOrientDetectDwa",TestPix, RESpixOrientDetectDwa,{"Dim RESpixOrientDetectDwa as Integer = LeptonicaSharp._All.pixOrientDetectDwa(TestPix ,Nothing ,Nothing ,TestPix ,Nothing )"},1)

' Dim RESpixUpDownDetectDwa as Integer = LeptonicaSharp._All.pixUpDownDetectDwa(TestPix ,New Single,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUpDownDetectDwa",TestPix, RESpixUpDownDetectDwa,{"Dim RESpixUpDownDetectDwa as Integer = LeptonicaSharp._All.pixUpDownDetectDwa(TestPix ,New Single,TestPix ,Nothing )"},1)

' Dim RESpixUpDownDetectGeneralDwa as Integer = LeptonicaSharp._All.pixUpDownDetectGeneralDwa(TestPix ,New Single,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUpDownDetectGeneralDwa",TestPix, RESpixUpDownDetectGeneralDwa,{"Dim RESpixUpDownDetectGeneralDwa as Integer = LeptonicaSharp._All.pixUpDownDetectGeneralDwa(TestPix ,New Single,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixMirrorDetect as Integer = LeptonicaSharp._All.pixMirrorDetect(TestPix ,New Single,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMirrorDetect",TestPix, RESpixMirrorDetect,{"Dim RESpixMirrorDetect as Integer = LeptonicaSharp._All.pixMirrorDetect(TestPix ,New Single,TestPix ,Nothing )"},1)

' Dim RESpixMirrorDetectDwa as Integer = LeptonicaSharp._All.pixMirrorDetectDwa(TestPix ,New Single,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMirrorDetectDwa",TestPix, RESpixMirrorDetectDwa,{"Dim RESpixMirrorDetectDwa as Integer = LeptonicaSharp._All.pixMirrorDetectDwa(TestPix ,New Single,TestPix ,Nothing )"},1)

' Dim RESpixFlipFHMTGen as Pix = LeptonicaSharp._All.pixFlipFHMTGen(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFlipFHMTGen",TestPix, RESpixFlipFHMTGen,{"Dim RESpixFlipFHMTGen as Pix = LeptonicaSharp._All.pixFlipFHMTGen(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfmorphautogen as Integer = LeptonicaSharp._All.fmorphautogen(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fmorphautogen",TestPix, RESfmorphautogen,{"Dim RESfmorphautogen as Integer = LeptonicaSharp._All.fmorphautogen(TestPix ,TestPix ,Nothing )"},1)

' Dim RESfmorphautogen1 as Integer = LeptonicaSharp._All.fmorphautogen1(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fmorphautogen1",TestPix, RESfmorphautogen1,{"Dim RESfmorphautogen1 as Integer = LeptonicaSharp._All.fmorphautogen1(TestPix ,TestPix ,Nothing )"},1)

' Dim RESfmorphautogen2 as Integer = LeptonicaSharp._All.fmorphautogen2(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fmorphautogen2",TestPix, RESfmorphautogen2,{"Dim RESfmorphautogen2 as Integer = LeptonicaSharp._All.fmorphautogen2(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphDwa_1 as Pix = LeptonicaSharp._All.pixMorphDwa_1(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphDwa_1",TestPix, RESpixMorphDwa_1,{"Dim RESpixMorphDwa_1 as Pix = LeptonicaSharp._All.pixMorphDwa_1(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFMorphopGen_1 as Pix = LeptonicaSharp._All.pixFMorphopGen_1(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFMorphopGen_1",TestPix, RESpixFMorphopGen_1,{"Dim RESpixFMorphopGen_1 as Pix = LeptonicaSharp._All.pixFMorphopGen_1(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfmorphopgen_low_1 as Integer = LeptonicaSharp._All.fmorphopgen_low_1(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fmorphopgen_low_1",TestPix, RESfmorphopgen_low_1,{"Dim RESfmorphopgen_low_1 as Integer = LeptonicaSharp._All.fmorphopgen_low_1(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixCreate as FPix = LeptonicaSharp._All.fpixCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixCreate",TestPix, RESfpixCreate,{"Dim RESfpixCreate as FPix = LeptonicaSharp._All.fpixCreate(TestPix ,TestPix )"},1)

' Dim RESfpixCreateTemplate as FPix = LeptonicaSharp._All.fpixCreateTemplate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixCreateTemplate",TestPix, RESfpixCreateTemplate,{"Dim RESfpixCreateTemplate as FPix = LeptonicaSharp._All.fpixCreateTemplate(TestPix )"},1)

' Dim RESfpixClone as FPix = LeptonicaSharp._All.fpixClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixClone",TestPix, RESfpixClone,{"Dim RESfpixClone as FPix = LeptonicaSharp._All.fpixClone(TestPix )"},1)

' Dim RESfpixCopy as FPix = LeptonicaSharp._All.fpixCopy(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixCopy",TestPix, RESfpixCopy,{"Dim RESfpixCopy as FPix = LeptonicaSharp._All.fpixCopy(Nothing ,TestPix )"},1)

' Dim RESfpixResizeImageData as Integer = LeptonicaSharp._All.fpixResizeImageData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixResizeImageData",TestPix, RESfpixResizeImageData,{"Dim RESfpixResizeImageData as Integer = LeptonicaSharp._All.fpixResizeImageData(TestPix ,TestPix )"},1)

' Dim RESfpixDestroy as Object = LeptonicaSharp._All.fpixDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixDestroy",TestPix, RESfpixDestroy,{"Dim RESfpixDestroy as Object = LeptonicaSharp._All.fpixDestroy(TestPix )"},1)

' Dim RESfpixGetDimensions as Integer = LeptonicaSharp._All.fpixGetDimensions(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetDimensions",TestPix, RESfpixGetDimensions,{"Dim RESfpixGetDimensions as Integer = LeptonicaSharp._All.fpixGetDimensions(TestPix ,Nothing ,Nothing )"},1)

' Dim RESfpixSetDimensions as Integer = LeptonicaSharp._All.fpixSetDimensions(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetDimensions",TestPix, RESfpixSetDimensions,{"Dim RESfpixSetDimensions as Integer = LeptonicaSharp._All.fpixSetDimensions(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixGetWpl as Integer = LeptonicaSharp._All.fpixGetWpl(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetWpl",TestPix, RESfpixGetWpl,{"Dim RESfpixGetWpl as Integer = LeptonicaSharp._All.fpixGetWpl(TestPix )"},1)

' Dim RESfpixSetWpl as Integer = LeptonicaSharp._All.fpixSetWpl(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetWpl",TestPix, RESfpixSetWpl,{"Dim RESfpixSetWpl as Integer = LeptonicaSharp._All.fpixSetWpl(TestPix ,TestPix )"},1)

' Dim RESfpixGetRefcount as Integer = LeptonicaSharp._All.fpixGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetRefcount",TestPix, RESfpixGetRefcount,{"Dim RESfpixGetRefcount as Integer = LeptonicaSharp._All.fpixGetRefcount(TestPix )"},1)

' Dim RESfpixChangeRefcount as Integer = LeptonicaSharp._All.fpixChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixChangeRefcount",TestPix, RESfpixChangeRefcount,{"Dim RESfpixChangeRefcount as Integer = LeptonicaSharp._All.fpixChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESfpixGetResolution as Integer = LeptonicaSharp._All.fpixGetResolution(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetResolution",TestPix, RESfpixGetResolution,{"Dim RESfpixGetResolution as Integer = LeptonicaSharp._All.fpixGetResolution(TestPix ,Nothing ,Nothing )"},1)

' Dim RESfpixSetResolution as Integer = LeptonicaSharp._All.fpixSetResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetResolution",TestPix, RESfpixSetResolution,{"Dim RESfpixSetResolution as Integer = LeptonicaSharp._All.fpixSetResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixCopyResolution as Integer = LeptonicaSharp._All.fpixCopyResolution(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixCopyResolution",TestPix, RESfpixCopyResolution,{"Dim RESfpixCopyResolution as Integer = LeptonicaSharp._All.fpixCopyResolution(TestPix ,TestPix )"},1)

' Dim RESfpixGetData as Single() = LeptonicaSharp._All.fpixGetData(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetData",TestPix, RESfpixGetData,{"Dim RESfpixGetData as Single() = LeptonicaSharp._All.fpixGetData(TestPix )"},1)

' Dim RESfpixSetData as Integer = LeptonicaSharp._All.fpixSetData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetData",TestPix, RESfpixSetData,{"Dim RESfpixSetData as Integer = LeptonicaSharp._All.fpixSetData(TestPix ,TestPix )"},1)

' Dim RESfpixGetPixel as Integer = LeptonicaSharp._All.fpixGetPixel(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetPixel",TestPix, RESfpixGetPixel,{"Dim RESfpixGetPixel as Integer = LeptonicaSharp._All.fpixGetPixel(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESfpixSetPixel as Integer = LeptonicaSharp._All.fpixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetPixel",TestPix, RESfpixSetPixel,{"Dim RESfpixSetPixel as Integer = LeptonicaSharp._All.fpixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixaCreate as FPixa = LeptonicaSharp._All.fpixaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaCreate",TestPix, RESfpixaCreate,{"Dim RESfpixaCreate as FPixa = LeptonicaSharp._All.fpixaCreate(TestPix )"},1)

' Dim RESfpixaCopy as FPixa = LeptonicaSharp._All.fpixaCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaCopy",TestPix, RESfpixaCopy,{"Dim RESfpixaCopy as FPixa = LeptonicaSharp._All.fpixaCopy(TestPix ,TestPix )"},1)

' Dim RESfpixaDestroy as Object = LeptonicaSharp._All.fpixaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaDestroy",TestPix, RESfpixaDestroy,{"Dim RESfpixaDestroy as Object = LeptonicaSharp._All.fpixaDestroy(TestPix )"},1)

' Dim RESfpixaAddFPix as Integer = LeptonicaSharp._All.fpixaAddFPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaAddFPix",TestPix, RESfpixaAddFPix,{"Dim RESfpixaAddFPix as Integer = LeptonicaSharp._All.fpixaAddFPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixaGetCount as Integer = LeptonicaSharp._All.fpixaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaGetCount",TestPix, RESfpixaGetCount,{"Dim RESfpixaGetCount as Integer = LeptonicaSharp._All.fpixaGetCount(TestPix )"},1)

' Dim RESfpixaChangeRefcount as Integer = LeptonicaSharp._All.fpixaChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaChangeRefcount",TestPix, RESfpixaChangeRefcount,{"Dim RESfpixaChangeRefcount as Integer = LeptonicaSharp._All.fpixaChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESfpixaGetFPix as FPix = LeptonicaSharp._All.fpixaGetFPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaGetFPix",TestPix, RESfpixaGetFPix,{"Dim RESfpixaGetFPix as FPix = LeptonicaSharp._All.fpixaGetFPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixaGetFPixDimensions as Integer = LeptonicaSharp._All.fpixaGetFPixDimensions(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaGetFPixDimensions",TestPix, RESfpixaGetFPixDimensions,{"Dim RESfpixaGetFPixDimensions as Integer = LeptonicaSharp._All.fpixaGetFPixDimensions(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESfpixaGetData as Single() = LeptonicaSharp._All.fpixaGetData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaGetData",TestPix, RESfpixaGetData,{"Dim RESfpixaGetData as Single() = LeptonicaSharp._All.fpixaGetData(TestPix ,TestPix )"},1)

' Dim RESfpixaGetPixel as Integer = LeptonicaSharp._All.fpixaGetPixel(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaGetPixel",TestPix, RESfpixaGetPixel,{"Dim RESfpixaGetPixel as Integer = LeptonicaSharp._All.fpixaGetPixel(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESfpixaSetPixel as Integer = LeptonicaSharp._All.fpixaSetPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaSetPixel",TestPix, RESfpixaSetPixel,{"Dim RESfpixaSetPixel as Integer = LeptonicaSharp._All.fpixaSetPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixCreate as DPix = LeptonicaSharp._All.dpixCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixCreate",TestPix, RESdpixCreate,{"Dim RESdpixCreate as DPix = LeptonicaSharp._All.dpixCreate(TestPix ,TestPix )"},1)

' Dim RESdpixCreateTemplate as DPix = LeptonicaSharp._All.dpixCreateTemplate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixCreateTemplate",TestPix, RESdpixCreateTemplate,{"Dim RESdpixCreateTemplate as DPix = LeptonicaSharp._All.dpixCreateTemplate(TestPix )"},1)

' Dim RESdpixClone as DPix = LeptonicaSharp._All.dpixClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixClone",TestPix, RESdpixClone,{"Dim RESdpixClone as DPix = LeptonicaSharp._All.dpixClone(TestPix )"},1)

' Dim RESdpixCopy as DPix = LeptonicaSharp._All.dpixCopy(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixCopy",TestPix, RESdpixCopy,{"Dim RESdpixCopy as DPix = LeptonicaSharp._All.dpixCopy(Nothing ,TestPix )"},1)

' Dim RESdpixResizeImageData as Integer = LeptonicaSharp._All.dpixResizeImageData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixResizeImageData",TestPix, RESdpixResizeImageData,{"Dim RESdpixResizeImageData as Integer = LeptonicaSharp._All.dpixResizeImageData(TestPix ,TestPix )"},1)

' Dim RESdpixDestroy as Object = LeptonicaSharp._All.dpixDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixDestroy",TestPix, RESdpixDestroy,{"Dim RESdpixDestroy as Object = LeptonicaSharp._All.dpixDestroy(TestPix )"},1)

' Dim RESdpixGetDimensions as Integer = LeptonicaSharp._All.dpixGetDimensions(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetDimensions",TestPix, RESdpixGetDimensions,{"Dim RESdpixGetDimensions as Integer = LeptonicaSharp._All.dpixGetDimensions(TestPix ,Nothing ,Nothing )"},1)

' Dim RESdpixSetDimensions as Integer = LeptonicaSharp._All.dpixSetDimensions(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetDimensions",TestPix, RESdpixSetDimensions,{"Dim RESdpixSetDimensions as Integer = LeptonicaSharp._All.dpixSetDimensions(TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixGetWpl as Integer = LeptonicaSharp._All.dpixGetWpl(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetWpl",TestPix, RESdpixGetWpl,{"Dim RESdpixGetWpl as Integer = LeptonicaSharp._All.dpixGetWpl(TestPix )"},1)

' Dim RESdpixSetWpl as Integer = LeptonicaSharp._All.dpixSetWpl(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetWpl",TestPix, RESdpixSetWpl,{"Dim RESdpixSetWpl as Integer = LeptonicaSharp._All.dpixSetWpl(TestPix ,TestPix )"},1)

' Dim RESdpixGetRefcount as Integer = LeptonicaSharp._All.dpixGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetRefcount",TestPix, RESdpixGetRefcount,{"Dim RESdpixGetRefcount as Integer = LeptonicaSharp._All.dpixGetRefcount(TestPix )"},1)

' Dim RESdpixChangeRefcount as Integer = LeptonicaSharp._All.dpixChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixChangeRefcount",TestPix, RESdpixChangeRefcount,{"Dim RESdpixChangeRefcount as Integer = LeptonicaSharp._All.dpixChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESdpixGetResolution as Integer = LeptonicaSharp._All.dpixGetResolution(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetResolution",TestPix, RESdpixGetResolution,{"Dim RESdpixGetResolution as Integer = LeptonicaSharp._All.dpixGetResolution(TestPix ,Nothing ,Nothing )"},1)

' Dim RESdpixSetResolution as Integer = LeptonicaSharp._All.dpixSetResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetResolution",TestPix, RESdpixSetResolution,{"Dim RESdpixSetResolution as Integer = LeptonicaSharp._All.dpixSetResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixCopyResolution as Integer = LeptonicaSharp._All.dpixCopyResolution(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixCopyResolution",TestPix, RESdpixCopyResolution,{"Dim RESdpixCopyResolution as Integer = LeptonicaSharp._All.dpixCopyResolution(TestPix ,TestPix )"},1)

' Dim RESdpixGetData as Double() = LeptonicaSharp._All.dpixGetData(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetData",TestPix, RESdpixGetData,{"Dim RESdpixGetData as Double() = LeptonicaSharp._All.dpixGetData(TestPix )"},1)

' Dim RESdpixSetData as Integer = LeptonicaSharp._All.dpixSetData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetData",TestPix, RESdpixSetData,{"Dim RESdpixSetData as Integer = LeptonicaSharp._All.dpixSetData(TestPix ,TestPix )"},1)

' Dim RESdpixGetPixel as Integer = LeptonicaSharp._All.dpixGetPixel(TestPix ,TestPix ,TestPix ,New Double())
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetPixel",TestPix, RESdpixGetPixel,{"Dim RESdpixGetPixel as Integer = LeptonicaSharp._All.dpixGetPixel(TestPix ,TestPix ,TestPix ,New Double())"},1)

' Dim RESdpixSetPixel as Integer = LeptonicaSharp._All.dpixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetPixel",TestPix, RESdpixSetPixel,{"Dim RESdpixSetPixel as Integer = LeptonicaSharp._All.dpixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixRead as FPix = LeptonicaSharp._All.fpixRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRead",TestPix, RESfpixRead,{"Dim RESfpixRead as FPix = LeptonicaSharp._All.fpixRead(TestPix )"},1)

' Dim RESfpixReadStream as FPix = LeptonicaSharp._All.fpixReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixReadStream",TestPix, RESfpixReadStream,{"Dim RESfpixReadStream as FPix = LeptonicaSharp._All.fpixReadStream(TestPix )"},1)

' Dim RESfpixReadMem as FPix = LeptonicaSharp._All.fpixReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixReadMem",TestPix, RESfpixReadMem,{"Dim RESfpixReadMem as FPix = LeptonicaSharp._All.fpixReadMem(TestPix ,TestPix )"},1)

' Dim RESfpixWrite as Integer = LeptonicaSharp._All.fpixWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixWrite",TestPix, RESfpixWrite,{"Dim RESfpixWrite as Integer = LeptonicaSharp._All.fpixWrite(TestPix ,TestPix )"},1)

' Dim RESfpixWriteStream as Integer = LeptonicaSharp._All.fpixWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixWriteStream",TestPix, RESfpixWriteStream,{"Dim RESfpixWriteStream as Integer = LeptonicaSharp._All.fpixWriteStream(TestPix ,TestPix )"},1)

' Dim RESfpixWriteMem as Integer = LeptonicaSharp._All.fpixWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixWriteMem",TestPix, RESfpixWriteMem,{"Dim RESfpixWriteMem as Integer = LeptonicaSharp._All.fpixWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESfpixEndianByteSwap as FPix = LeptonicaSharp._All.fpixEndianByteSwap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixEndianByteSwap",TestPix, RESfpixEndianByteSwap,{"Dim RESfpixEndianByteSwap as FPix = LeptonicaSharp._All.fpixEndianByteSwap(TestPix ,TestPix )"},1)

' Dim RESdpixRead as DPix = LeptonicaSharp._All.dpixRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixRead",TestPix, RESdpixRead,{"Dim RESdpixRead as DPix = LeptonicaSharp._All.dpixRead(TestPix )"},1)

' Dim RESdpixReadStream as DPix = LeptonicaSharp._All.dpixReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixReadStream",TestPix, RESdpixReadStream,{"Dim RESdpixReadStream as DPix = LeptonicaSharp._All.dpixReadStream(TestPix )"},1)

' Dim RESdpixReadMem as DPix = LeptonicaSharp._All.dpixReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixReadMem",TestPix, RESdpixReadMem,{"Dim RESdpixReadMem as DPix = LeptonicaSharp._All.dpixReadMem(TestPix ,TestPix )"},1)

' Dim RESdpixWrite as Integer = LeptonicaSharp._All.dpixWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixWrite",TestPix, RESdpixWrite,{"Dim RESdpixWrite as Integer = LeptonicaSharp._All.dpixWrite(TestPix ,TestPix )"},1)

' Dim RESdpixWriteStream as Integer = LeptonicaSharp._All.dpixWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixWriteStream",TestPix, RESdpixWriteStream,{"Dim RESdpixWriteStream as Integer = LeptonicaSharp._All.dpixWriteStream(TestPix ,TestPix )"},1)

' Dim RESdpixWriteMem as Integer = LeptonicaSharp._All.dpixWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixWriteMem",TestPix, RESdpixWriteMem,{"Dim RESdpixWriteMem as Integer = LeptonicaSharp._All.dpixWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESdpixEndianByteSwap as DPix = LeptonicaSharp._All.dpixEndianByteSwap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixEndianByteSwap",TestPix, RESdpixEndianByteSwap,{"Dim RESdpixEndianByteSwap as DPix = LeptonicaSharp._All.dpixEndianByteSwap(TestPix ,TestPix )"},1)

' Dim RESfpixPrintStream as Integer = LeptonicaSharp._All.fpixPrintStream(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixPrintStream",TestPix, RESfpixPrintStream,{"Dim RESfpixPrintStream as Integer = LeptonicaSharp._All.fpixPrintStream(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertToFPix as FPix = LeptonicaSharp._All.pixConvertToFPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToFPix",TestPix, RESpixConvertToFPix,{"Dim RESpixConvertToFPix as FPix = LeptonicaSharp._All.pixConvertToFPix(TestPix ,TestPix )"},1)

' Dim RESpixConvertToDPix as DPix = LeptonicaSharp._All.pixConvertToDPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToDPix",TestPix, RESpixConvertToDPix,{"Dim RESpixConvertToDPix as DPix = LeptonicaSharp._All.pixConvertToDPix(TestPix ,TestPix )"},1)

' Dim RESfpixConvertToPix as Pix = LeptonicaSharp._All.fpixConvertToPix(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixConvertToPix",TestPix, RESfpixConvertToPix,{"Dim RESfpixConvertToPix as Pix = LeptonicaSharp._All.fpixConvertToPix(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixDisplayMaxDynamicRange as Pix = LeptonicaSharp._All.fpixDisplayMaxDynamicRange(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixDisplayMaxDynamicRange",TestPix, RESfpixDisplayMaxDynamicRange,{"Dim RESfpixDisplayMaxDynamicRange as Pix = LeptonicaSharp._All.fpixDisplayMaxDynamicRange(TestPix )"},1)

' Dim RESfpixConvertToDPix as DPix = LeptonicaSharp._All.fpixConvertToDPix(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixConvertToDPix",TestPix, RESfpixConvertToDPix,{"Dim RESfpixConvertToDPix as DPix = LeptonicaSharp._All.fpixConvertToDPix(TestPix )"},1)

' Dim RESdpixConvertToPix as Pix = LeptonicaSharp._All.dpixConvertToPix(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixConvertToPix",TestPix, RESdpixConvertToPix,{"Dim RESdpixConvertToPix as Pix = LeptonicaSharp._All.dpixConvertToPix(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixConvertToFPix as FPix = LeptonicaSharp._All.dpixConvertToFPix(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixConvertToFPix",TestPix, RESdpixConvertToFPix,{"Dim RESdpixConvertToFPix as FPix = LeptonicaSharp._All.dpixConvertToFPix(TestPix )"},1)

' Dim RESfpixGetMin as Integer = LeptonicaSharp._All.fpixGetMin(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetMin",TestPix, RESfpixGetMin,{"Dim RESfpixGetMin as Integer = LeptonicaSharp._All.fpixGetMin(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfpixGetMax as Integer = LeptonicaSharp._All.fpixGetMax(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixGetMax",TestPix, RESfpixGetMax,{"Dim RESfpixGetMax as Integer = LeptonicaSharp._All.fpixGetMax(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESdpixGetMin as Integer = LeptonicaSharp._All.dpixGetMin(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetMin",TestPix, RESdpixGetMin,{"Dim RESdpixGetMin as Integer = LeptonicaSharp._All.dpixGetMin(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESdpixGetMax as Integer = LeptonicaSharp._All.dpixGetMax(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixGetMax",TestPix, RESdpixGetMax,{"Dim RESdpixGetMax as Integer = LeptonicaSharp._All.dpixGetMax(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfpixScaleByInteger as FPix = LeptonicaSharp._All.fpixScaleByInteger(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixScaleByInteger",TestPix, RESfpixScaleByInteger,{"Dim RESfpixScaleByInteger as FPix = LeptonicaSharp._All.fpixScaleByInteger(TestPix ,TestPix )"},1)

' Dim RESdpixScaleByInteger as DPix = LeptonicaSharp._All.dpixScaleByInteger(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixScaleByInteger",TestPix, RESdpixScaleByInteger,{"Dim RESdpixScaleByInteger as DPix = LeptonicaSharp._All.dpixScaleByInteger(TestPix ,TestPix )"},1)

' Dim RESfpixLinearCombination as FPix = LeptonicaSharp._All.fpixLinearCombination(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixLinearCombination",TestPix, RESfpixLinearCombination,{"Dim RESfpixLinearCombination as FPix = LeptonicaSharp._All.fpixLinearCombination(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAddMultConstant as Integer = LeptonicaSharp._All.fpixAddMultConstant(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAddMultConstant",TestPix, RESfpixAddMultConstant,{"Dim RESfpixAddMultConstant as Integer = LeptonicaSharp._All.fpixAddMultConstant(TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixLinearCombination as DPix = LeptonicaSharp._All.dpixLinearCombination(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixLinearCombination",TestPix, RESdpixLinearCombination,{"Dim RESdpixLinearCombination as DPix = LeptonicaSharp._All.dpixLinearCombination(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESdpixAddMultConstant as Integer = LeptonicaSharp._All.dpixAddMultConstant(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixAddMultConstant",TestPix, RESdpixAddMultConstant,{"Dim RESdpixAddMultConstant as Integer = LeptonicaSharp._All.dpixAddMultConstant(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixSetAllArbitrary as Integer = LeptonicaSharp._All.fpixSetAllArbitrary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixSetAllArbitrary",TestPix, RESfpixSetAllArbitrary,{"Dim RESfpixSetAllArbitrary as Integer = LeptonicaSharp._All.fpixSetAllArbitrary(TestPix ,TestPix )"},1)

' Dim RESdpixSetAllArbitrary as Integer = LeptonicaSharp._All.dpixSetAllArbitrary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("dpixSetAllArbitrary",TestPix, RESdpixSetAllArbitrary,{"Dim RESdpixSetAllArbitrary as Integer = LeptonicaSharp._All.dpixSetAllArbitrary(TestPix ,TestPix )"},1)

' Dim RESfpixAddBorder as FPix = LeptonicaSharp._All.fpixAddBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAddBorder",TestPix, RESfpixAddBorder,{"Dim RESfpixAddBorder as FPix = LeptonicaSharp._All.fpixAddBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixRemoveBorder as FPix = LeptonicaSharp._All.fpixRemoveBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRemoveBorder",TestPix, RESfpixRemoveBorder,{"Dim RESfpixRemoveBorder as FPix = LeptonicaSharp._All.fpixRemoveBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAddMirroredBorder as FPix = LeptonicaSharp._All.fpixAddMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAddMirroredBorder",TestPix, RESfpixAddMirroredBorder,{"Dim RESfpixAddMirroredBorder as FPix = LeptonicaSharp._All.fpixAddMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAddContinuedBorder as FPix = LeptonicaSharp._All.fpixAddContinuedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAddContinuedBorder",TestPix, RESfpixAddContinuedBorder,{"Dim RESfpixAddContinuedBorder as FPix = LeptonicaSharp._All.fpixAddContinuedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAddSlopeBorder as FPix = LeptonicaSharp._All.fpixAddSlopeBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAddSlopeBorder",TestPix, RESfpixAddSlopeBorder,{"Dim RESfpixAddSlopeBorder as FPix = LeptonicaSharp._All.fpixAddSlopeBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixRasterop as Integer = LeptonicaSharp._All.fpixRasterop(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRasterop",TestPix, RESfpixRasterop,{"Dim RESfpixRasterop as Integer = LeptonicaSharp._All.fpixRasterop(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixRotateOrth as FPix = LeptonicaSharp._All.fpixRotateOrth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRotateOrth",TestPix, RESfpixRotateOrth,{"Dim RESfpixRotateOrth as FPix = LeptonicaSharp._All.fpixRotateOrth(TestPix ,TestPix )"},1)

' Dim RESfpixRotate180 as FPix = LeptonicaSharp._All.fpixRotate180(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRotate180",TestPix, RESfpixRotate180,{"Dim RESfpixRotate180 as FPix = LeptonicaSharp._All.fpixRotate180(Nothing ,TestPix )"},1)

' Dim RESfpixRotate90 as FPix = LeptonicaSharp._All.fpixRotate90(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRotate90",TestPix, RESfpixRotate90,{"Dim RESfpixRotate90 as FPix = LeptonicaSharp._All.fpixRotate90(TestPix ,TestPix )"},1)

' Dim RESfpixFlipLR as FPix = LeptonicaSharp._All.fpixFlipLR(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixFlipLR",TestPix, RESfpixFlipLR,{"Dim RESfpixFlipLR as FPix = LeptonicaSharp._All.fpixFlipLR(Nothing ,TestPix )"},1)

' Dim RESfpixFlipTB as FPix = LeptonicaSharp._All.fpixFlipTB(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixFlipTB",TestPix, RESfpixFlipTB,{"Dim RESfpixFlipTB as FPix = LeptonicaSharp._All.fpixFlipTB(Nothing ,TestPix )"},1)

' Dim RESfpixAffinePta as FPix = LeptonicaSharp._All.fpixAffinePta(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAffinePta",TestPix, RESfpixAffinePta,{"Dim RESfpixAffinePta as FPix = LeptonicaSharp._All.fpixAffinePta(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAffine as FPix = LeptonicaSharp._All.fpixAffine(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAffine",TestPix, RESfpixAffine,{"Dim RESfpixAffine as FPix = LeptonicaSharp._All.fpixAffine(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixProjectivePta as FPix = LeptonicaSharp._All.fpixProjectivePta(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixProjectivePta",TestPix, RESfpixProjectivePta,{"Dim RESfpixProjectivePta as FPix = LeptonicaSharp._All.fpixProjectivePta(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixProjective as FPix = LeptonicaSharp._All.fpixProjective(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixProjective",TestPix, RESfpixProjective,{"Dim RESfpixProjective as FPix = LeptonicaSharp._All.fpixProjective(TestPix ,TestPix ,TestPix )"},1)

' Dim RESlinearInterpolatePixelFloat as Integer = LeptonicaSharp._All.linearInterpolatePixelFloat(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("linearInterpolatePixelFloat",TestPix, RESlinearInterpolatePixelFloat,{"Dim RESlinearInterpolatePixelFloat as Integer = LeptonicaSharp._All.linearInterpolatePixelFloat(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESfpixThresholdToPix as Pix = LeptonicaSharp._All.fpixThresholdToPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixThresholdToPix",TestPix, RESfpixThresholdToPix,{"Dim RESfpixThresholdToPix as Pix = LeptonicaSharp._All.fpixThresholdToPix(TestPix ,TestPix )"},1)

' Dim RESpixComponentFunction as FPix = LeptonicaSharp._All.pixComponentFunction(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixComponentFunction",TestPix, RESpixComponentFunction,{"Dim RESpixComponentFunction as FPix = LeptonicaSharp._All.pixComponentFunction(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadStreamGif as Pix = LeptonicaSharp._All.pixReadStreamGif(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamGif",TestPix, RESpixReadStreamGif,{"Dim RESpixReadStreamGif as Pix = LeptonicaSharp._All.pixReadStreamGif(TestPix )"},1)

' Dim RESpixReadMemGif as Pix = LeptonicaSharp._All.pixReadMemGif(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemGif",TestPix, RESpixReadMemGif,{"Dim RESpixReadMemGif as Pix = LeptonicaSharp._All.pixReadMemGif(TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamGif as Integer = LeptonicaSharp._All.pixWriteStreamGif(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamGif",TestPix, RESpixWriteStreamGif,{"Dim RESpixWriteStreamGif as Integer = LeptonicaSharp._All.pixWriteStreamGif(TestPix ,TestPix )"},1)

' Dim RESpixWriteMemGif as Integer = LeptonicaSharp._All.pixWriteMemGif(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemGif",TestPix, RESpixWriteMemGif,{"Dim RESpixWriteMemGif as Integer = LeptonicaSharp._All.pixWriteMemGif(TestPix ,TestPix ,TestPix )"},1)

' Dim RESgplotCreate as GPlot = LeptonicaSharp._All.gplotCreate(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotCreate",TestPix, RESgplotCreate,{"Dim RESgplotCreate as GPlot = LeptonicaSharp._All.gplotCreate(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESgplotDestroy as Object = LeptonicaSharp._All.gplotDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotDestroy",TestPix, RESgplotDestroy,{"Dim RESgplotDestroy as Object = LeptonicaSharp._All.gplotDestroy(TestPix )"},1)

' Dim RESgplotAddPlot as Integer = LeptonicaSharp._All.gplotAddPlot(TestPix ,Nothing ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotAddPlot",TestPix, RESgplotAddPlot,{"Dim RESgplotAddPlot as Integer = LeptonicaSharp._All.gplotAddPlot(TestPix ,Nothing ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSetScaling as Integer = LeptonicaSharp._All.gplotSetScaling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSetScaling",TestPix, RESgplotSetScaling,{"Dim RESgplotSetScaling as Integer = LeptonicaSharp._All.gplotSetScaling(TestPix ,TestPix )"},1)

' Dim RESgplotMakeOutput as Integer = LeptonicaSharp._All.gplotMakeOutput(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotMakeOutput",TestPix, RESgplotMakeOutput,{"Dim RESgplotMakeOutput as Integer = LeptonicaSharp._All.gplotMakeOutput(TestPix )"},1)

' Dim RESgplotGenCommandFile as Integer = LeptonicaSharp._All.gplotGenCommandFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotGenCommandFile",TestPix, RESgplotGenCommandFile,{"Dim RESgplotGenCommandFile as Integer = LeptonicaSharp._All.gplotGenCommandFile(TestPix )"},1)

' Dim RESgplotGenDataFiles as Integer = LeptonicaSharp._All.gplotGenDataFiles(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotGenDataFiles",TestPix, RESgplotGenDataFiles,{"Dim RESgplotGenDataFiles as Integer = LeptonicaSharp._All.gplotGenDataFiles(TestPix )"},1)

' Dim RESgplotSimple1 as Integer = LeptonicaSharp._All.gplotSimple1(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimple1",TestPix, RESgplotSimple1,{"Dim RESgplotSimple1 as Integer = LeptonicaSharp._All.gplotSimple1(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSimple2 as Integer = LeptonicaSharp._All.gplotSimple2(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimple2",TestPix, RESgplotSimple2,{"Dim RESgplotSimple2 as Integer = LeptonicaSharp._All.gplotSimple2(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSimpleN as Integer = LeptonicaSharp._All.gplotSimpleN(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimpleN",TestPix, RESgplotSimpleN,{"Dim RESgplotSimpleN as Integer = LeptonicaSharp._All.gplotSimpleN(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSimpleXY1 as Integer = LeptonicaSharp._All.gplotSimpleXY1(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimpleXY1",TestPix, RESgplotSimpleXY1,{"Dim RESgplotSimpleXY1 as Integer = LeptonicaSharp._All.gplotSimpleXY1(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSimpleXY2 as Integer = LeptonicaSharp._All.gplotSimpleXY2(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimpleXY2",TestPix, RESgplotSimpleXY2,{"Dim RESgplotSimpleXY2 as Integer = LeptonicaSharp._All.gplotSimpleXY2(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotSimpleXYN as Integer = LeptonicaSharp._All.gplotSimpleXYN(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotSimpleXYN",TestPix, RESgplotSimpleXYN,{"Dim RESgplotSimpleXYN as Integer = LeptonicaSharp._All.gplotSimpleXYN(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESgplotRead as GPlot = LeptonicaSharp._All.gplotRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotRead",TestPix, RESgplotRead,{"Dim RESgplotRead as GPlot = LeptonicaSharp._All.gplotRead(TestPix )"},1)

' Dim RESgplotWrite as Integer = LeptonicaSharp._All.gplotWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("gplotWrite",TestPix, RESgplotWrite,{"Dim RESgplotWrite as Integer = LeptonicaSharp._All.gplotWrite(TestPix ,TestPix )"},1)

' Dim RESgeneratePtaLine as Pta = LeptonicaSharp._All.generatePtaLine(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaLine",TestPix, RESgeneratePtaLine,{"Dim RESgeneratePtaLine as Pta = LeptonicaSharp._All.generatePtaLine(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaWideLine as Pta = LeptonicaSharp._All.generatePtaWideLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaWideLine",TestPix, RESgeneratePtaWideLine,{"Dim RESgeneratePtaWideLine as Pta = LeptonicaSharp._All.generatePtaWideLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaBox as Pta = LeptonicaSharp._All.generatePtaBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaBox",TestPix, RESgeneratePtaBox,{"Dim RESgeneratePtaBox as Pta = LeptonicaSharp._All.generatePtaBox(TestPix ,TestPix )"},1)

' Dim RESgeneratePtaBoxa as Pta = LeptonicaSharp._All.generatePtaBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaBoxa",TestPix, RESgeneratePtaBoxa,{"Dim RESgeneratePtaBoxa as Pta = LeptonicaSharp._All.generatePtaBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaHashBox as Pta = LeptonicaSharp._All.generatePtaHashBox(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaHashBox",TestPix, RESgeneratePtaHashBox,{"Dim RESgeneratePtaHashBox as Pta = LeptonicaSharp._All.generatePtaHashBox(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaHashBoxa as Pta = LeptonicaSharp._All.generatePtaHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaHashBoxa",TestPix, RESgeneratePtaHashBoxa,{"Dim RESgeneratePtaHashBoxa as Pta = LeptonicaSharp._All.generatePtaHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaaBoxa as Ptaa = LeptonicaSharp._All.generatePtaaBoxa(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaaBoxa",TestPix, RESgeneratePtaaBoxa,{"Dim RESgeneratePtaaBoxa as Ptaa = LeptonicaSharp._All.generatePtaaBoxa(TestPix )"},1)

' Dim RESgeneratePtaaHashBoxa as Ptaa = LeptonicaSharp._All.generatePtaaHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaaHashBoxa",TestPix, RESgeneratePtaaHashBoxa,{"Dim RESgeneratePtaaHashBoxa as Ptaa = LeptonicaSharp._All.generatePtaaHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaPolyline as Pta = LeptonicaSharp._All.generatePtaPolyline(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaPolyline",TestPix, RESgeneratePtaPolyline,{"Dim RESgeneratePtaPolyline as Pta = LeptonicaSharp._All.generatePtaPolyline(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgeneratePtaGrid as Pta = LeptonicaSharp._All.generatePtaGrid(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaGrid",TestPix, RESgeneratePtaGrid,{"Dim RESgeneratePtaGrid as Pta = LeptonicaSharp._All.generatePtaGrid(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertPtaLineTo4cc as Pta = LeptonicaSharp._All.convertPtaLineTo4cc(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertPtaLineTo4cc",TestPix, RESconvertPtaLineTo4cc,{"Dim RESconvertPtaLineTo4cc as Pta = LeptonicaSharp._All.convertPtaLineTo4cc(TestPix )"},1)

' Dim RESgeneratePtaFilledCircle as Pta = LeptonicaSharp._All.generatePtaFilledCircle(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaFilledCircle",TestPix, RESgeneratePtaFilledCircle,{"Dim RESgeneratePtaFilledCircle as Pta = LeptonicaSharp._All.generatePtaFilledCircle(TestPix )"},1)

' Dim RESgeneratePtaFilledSquare as Pta = LeptonicaSharp._All.generatePtaFilledSquare(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaFilledSquare",TestPix, RESgeneratePtaFilledSquare,{"Dim RESgeneratePtaFilledSquare as Pta = LeptonicaSharp._All.generatePtaFilledSquare(TestPix )"},1)

' Dim RESgeneratePtaLineFromPt as Pta = LeptonicaSharp._All.generatePtaLineFromPt(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generatePtaLineFromPt",TestPix, RESgeneratePtaLineFromPt,{"Dim RESgeneratePtaLineFromPt as Pta = LeptonicaSharp._All.generatePtaLineFromPt(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESlocatePtRadially as Integer = LeptonicaSharp._All.locatePtRadially(TestPix ,TestPix ,TestPix ,TestPix ,New Double(),New Double())
' LeptonicaSharp.Convert.WriteHelpExtension ("locatePtRadially",TestPix, RESlocatePtRadially,{"Dim RESlocatePtRadially as Integer = LeptonicaSharp._All.locatePtRadially(TestPix ,TestPix ,TestPix ,TestPix ,New Double(),New Double())"},1)

' Dim RESpixRenderPlotFromNuma as Integer = LeptonicaSharp._All.pixRenderPlotFromNuma(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPlotFromNuma",TestPix, RESpixRenderPlotFromNuma,{"Dim RESpixRenderPlotFromNuma as Integer = LeptonicaSharp._All.pixRenderPlotFromNuma(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakePlotPtaFromNuma as Pta = LeptonicaSharp._All.makePlotPtaFromNuma(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makePlotPtaFromNuma",TestPix, RESmakePlotPtaFromNuma,{"Dim RESmakePlotPtaFromNuma as Pta = LeptonicaSharp._All.makePlotPtaFromNuma(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPlotFromNumaGen as Integer = LeptonicaSharp._All.pixRenderPlotFromNumaGen(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPlotFromNumaGen",TestPix, RESpixRenderPlotFromNumaGen,{"Dim RESpixRenderPlotFromNumaGen as Integer = LeptonicaSharp._All.pixRenderPlotFromNumaGen(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakePlotPtaFromNumaGen as Pta = LeptonicaSharp._All.makePlotPtaFromNumaGen(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makePlotPtaFromNumaGen",TestPix, RESmakePlotPtaFromNumaGen,{"Dim RESmakePlotPtaFromNumaGen as Pta = LeptonicaSharp._All.makePlotPtaFromNumaGen(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPta as Integer = LeptonicaSharp._All.pixRenderPta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPta",TestPix, RESpixRenderPta,{"Dim RESpixRenderPta as Integer = LeptonicaSharp._All.pixRenderPta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPtaArb as Integer = LeptonicaSharp._All.pixRenderPtaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPtaArb",TestPix, RESpixRenderPtaArb,{"Dim RESpixRenderPtaArb as Integer = LeptonicaSharp._All.pixRenderPtaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPtaBlend as Integer = LeptonicaSharp._All.pixRenderPtaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPtaBlend",TestPix, RESpixRenderPtaBlend,{"Dim RESpixRenderPtaBlend as Integer = LeptonicaSharp._All.pixRenderPtaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderLine as Integer = LeptonicaSharp._All.pixRenderLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderLine",TestPix, RESpixRenderLine,{"Dim RESpixRenderLine as Integer = LeptonicaSharp._All.pixRenderLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderLineArb as Integer = LeptonicaSharp._All.pixRenderLineArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderLineArb",TestPix, RESpixRenderLineArb,{"Dim RESpixRenderLineArb as Integer = LeptonicaSharp._All.pixRenderLineArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderLineBlend as Integer = LeptonicaSharp._All.pixRenderLineBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderLineBlend",TestPix, RESpixRenderLineBlend,{"Dim RESpixRenderLineBlend as Integer = LeptonicaSharp._All.pixRenderLineBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBox as Integer = LeptonicaSharp._All.pixRenderBox(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBox",TestPix, RESpixRenderBox,{"Dim RESpixRenderBox as Integer = LeptonicaSharp._All.pixRenderBox(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBoxArb as Integer = LeptonicaSharp._All.pixRenderBoxArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBoxArb",TestPix, RESpixRenderBoxArb,{"Dim RESpixRenderBoxArb as Integer = LeptonicaSharp._All.pixRenderBoxArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBoxBlend as Integer = LeptonicaSharp._All.pixRenderBoxBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBoxBlend",TestPix, RESpixRenderBoxBlend,{"Dim RESpixRenderBoxBlend as Integer = LeptonicaSharp._All.pixRenderBoxBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBoxa as Integer = LeptonicaSharp._All.pixRenderBoxa(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBoxa",TestPix, RESpixRenderBoxa,{"Dim RESpixRenderBoxa as Integer = LeptonicaSharp._All.pixRenderBoxa(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBoxaArb as Integer = LeptonicaSharp._All.pixRenderBoxaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBoxaArb",TestPix, RESpixRenderBoxaArb,{"Dim RESpixRenderBoxaArb as Integer = LeptonicaSharp._All.pixRenderBoxaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderBoxaBlend as Integer = LeptonicaSharp._All.pixRenderBoxaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderBoxaBlend",TestPix, RESpixRenderBoxaBlend,{"Dim RESpixRenderBoxaBlend as Integer = LeptonicaSharp._All.pixRenderBoxaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBox as Integer = LeptonicaSharp._All.pixRenderHashBox(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBox",TestPix, RESpixRenderHashBox,{"Dim RESpixRenderHashBox as Integer = LeptonicaSharp._All.pixRenderHashBox(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBoxArb as Integer = LeptonicaSharp._All.pixRenderHashBoxArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBoxArb",TestPix, RESpixRenderHashBoxArb,{"Dim RESpixRenderHashBoxArb as Integer = LeptonicaSharp._All.pixRenderHashBoxArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBoxBlend as Integer = LeptonicaSharp._All.pixRenderHashBoxBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBoxBlend",TestPix, RESpixRenderHashBoxBlend,{"Dim RESpixRenderHashBoxBlend as Integer = LeptonicaSharp._All.pixRenderHashBoxBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashMaskArb as Integer = LeptonicaSharp._All.pixRenderHashMaskArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashMaskArb",TestPix, RESpixRenderHashMaskArb,{"Dim RESpixRenderHashMaskArb as Integer = LeptonicaSharp._All.pixRenderHashMaskArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBoxa as Integer = LeptonicaSharp._All.pixRenderHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBoxa",TestPix, RESpixRenderHashBoxa,{"Dim RESpixRenderHashBoxa as Integer = LeptonicaSharp._All.pixRenderHashBoxa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBoxaArb as Integer = LeptonicaSharp._All.pixRenderHashBoxaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBoxaArb",TestPix, RESpixRenderHashBoxaArb,{"Dim RESpixRenderHashBoxaArb as Integer = LeptonicaSharp._All.pixRenderHashBoxaArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderHashBoxaBlend as Integer = LeptonicaSharp._All.pixRenderHashBoxaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderHashBoxaBlend",TestPix, RESpixRenderHashBoxaBlend,{"Dim RESpixRenderHashBoxaBlend as Integer = LeptonicaSharp._All.pixRenderHashBoxaBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPolyline as Integer = LeptonicaSharp._All.pixRenderPolyline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPolyline",TestPix, RESpixRenderPolyline,{"Dim RESpixRenderPolyline as Integer = LeptonicaSharp._All.pixRenderPolyline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPolylineArb as Integer = LeptonicaSharp._All.pixRenderPolylineArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPolylineArb",TestPix, RESpixRenderPolylineArb,{"Dim RESpixRenderPolylineArb as Integer = LeptonicaSharp._All.pixRenderPolylineArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPolylineBlend as Integer = LeptonicaSharp._All.pixRenderPolylineBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPolylineBlend",TestPix, RESpixRenderPolylineBlend,{"Dim RESpixRenderPolylineBlend as Integer = LeptonicaSharp._All.pixRenderPolylineBlend(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderGridArb as Integer = LeptonicaSharp._All.pixRenderGridArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderGridArb",TestPix, RESpixRenderGridArb,{"Dim RESpixRenderGridArb as Integer = LeptonicaSharp._All.pixRenderGridArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderRandomCmapPtaa as Pix = LeptonicaSharp._All.pixRenderRandomCmapPtaa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderRandomCmapPtaa",TestPix, RESpixRenderRandomCmapPtaa,{"Dim RESpixRenderRandomCmapPtaa as Pix = LeptonicaSharp._All.pixRenderRandomCmapPtaa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderPolygon as Pix = LeptonicaSharp._All.pixRenderPolygon(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderPolygon",TestPix, RESpixRenderPolygon,{"Dim RESpixRenderPolygon as Pix = LeptonicaSharp._All.pixRenderPolygon(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixFillPolygon as Pix = LeptonicaSharp._All.pixFillPolygon(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFillPolygon",TestPix, RESpixFillPolygon,{"Dim RESpixFillPolygon as Pix = LeptonicaSharp._All.pixFillPolygon(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRenderContours as Pix = LeptonicaSharp._All.pixRenderContours(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRenderContours",TestPix, RESpixRenderContours,{"Dim RESpixRenderContours as Pix = LeptonicaSharp._All.pixRenderContours(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfpixAutoRenderContours as Pix = LeptonicaSharp._All.fpixAutoRenderContours(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixAutoRenderContours",TestPix, RESfpixAutoRenderContours,{"Dim RESfpixAutoRenderContours as Pix = LeptonicaSharp._All.fpixAutoRenderContours(TestPix ,TestPix )"},1)

' Dim RESfpixRenderContours as Pix = LeptonicaSharp._All.fpixRenderContours(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixRenderContours",TestPix, RESfpixRenderContours,{"Dim RESfpixRenderContours as Pix = LeptonicaSharp._All.fpixRenderContours(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGeneratePtaBoundary as Pta = LeptonicaSharp._All.pixGeneratePtaBoundary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGeneratePtaBoundary",TestPix, RESpixGeneratePtaBoundary,{"Dim RESpixGeneratePtaBoundary as Pta = LeptonicaSharp._All.pixGeneratePtaBoundary(TestPix ,TestPix )"},1)

' Dim RESpixErodeGray as Pix = LeptonicaSharp._All.pixErodeGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeGray",TestPix, RESpixErodeGray,{"Dim RESpixErodeGray as Pix = LeptonicaSharp._All.pixErodeGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDilateGray as Pix = LeptonicaSharp._All.pixDilateGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateGray",TestPix, RESpixDilateGray,{"Dim RESpixDilateGray as Pix = LeptonicaSharp._All.pixDilateGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenGray as Pix = LeptonicaSharp._All.pixOpenGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenGray",TestPix, RESpixOpenGray,{"Dim RESpixOpenGray as Pix = LeptonicaSharp._All.pixOpenGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseGray as Pix = LeptonicaSharp._All.pixCloseGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseGray",TestPix, RESpixCloseGray,{"Dim RESpixCloseGray as Pix = LeptonicaSharp._All.pixCloseGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeGray3 as Pix = LeptonicaSharp._All.pixErodeGray3(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeGray3",TestPix, RESpixErodeGray3,{"Dim RESpixErodeGray3 as Pix = LeptonicaSharp._All.pixErodeGray3(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDilateGray3 as Pix = LeptonicaSharp._All.pixDilateGray3(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateGray3",TestPix, RESpixDilateGray3,{"Dim RESpixDilateGray3 as Pix = LeptonicaSharp._All.pixDilateGray3(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenGray3 as Pix = LeptonicaSharp._All.pixOpenGray3(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenGray3",TestPix, RESpixOpenGray3,{"Dim RESpixOpenGray3 as Pix = LeptonicaSharp._All.pixOpenGray3(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseGray3 as Pix = LeptonicaSharp._All.pixCloseGray3(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseGray3",TestPix, RESpixCloseGray3,{"Dim RESpixCloseGray3 as Pix = LeptonicaSharp._All.pixCloseGray3(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDitherToBinary as Pix = LeptonicaSharp._All.pixDitherToBinary(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDitherToBinary",TestPix, RESpixDitherToBinary,{"Dim RESpixDitherToBinary as Pix = LeptonicaSharp._All.pixDitherToBinary(TestPix )"},1)

' Dim RESpixDitherToBinarySpec as Pix = LeptonicaSharp._All.pixDitherToBinarySpec(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDitherToBinarySpec",TestPix, RESpixDitherToBinarySpec,{"Dim RESpixDitherToBinarySpec as Pix = LeptonicaSharp._All.pixDitherToBinarySpec(TestPix ,TestPix ,TestPix )"},1)

' Dim RESditherToBinaryLineLow as Object = LeptonicaSharp._All.ditherToBinaryLineLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ditherToBinaryLineLow",TestPix, RESditherToBinaryLineLow,{"Dim RESditherToBinaryLineLow as Object = LeptonicaSharp._All.ditherToBinaryLineLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdToBinary as Pix = LeptonicaSharp._All.pixThresholdToBinary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdToBinary",TestPix, RESpixThresholdToBinary,{"Dim RESpixThresholdToBinary as Pix = LeptonicaSharp._All.pixThresholdToBinary(TestPix ,TestPix )"},1)

' Dim RESthresholdToBinaryLineLow as Object = LeptonicaSharp._All.thresholdToBinaryLineLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("thresholdToBinaryLineLow",TestPix, RESthresholdToBinaryLineLow,{"Dim RESthresholdToBinaryLineLow as Object = LeptonicaSharp._All.thresholdToBinaryLineLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVarThresholdToBinary as Pix = LeptonicaSharp._All.pixVarThresholdToBinary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVarThresholdToBinary",TestPix, RESpixVarThresholdToBinary,{"Dim RESpixVarThresholdToBinary as Pix = LeptonicaSharp._All.pixVarThresholdToBinary(TestPix ,TestPix )"},1)

' Dim RESpixAdaptThresholdToBinary as Pix = LeptonicaSharp._All.pixAdaptThresholdToBinary(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAdaptThresholdToBinary",TestPix, RESpixAdaptThresholdToBinary,{"Dim RESpixAdaptThresholdToBinary as Pix = LeptonicaSharp._All.pixAdaptThresholdToBinary(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixAdaptThresholdToBinaryGen as Pix = LeptonicaSharp._All.pixAdaptThresholdToBinaryGen(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAdaptThresholdToBinaryGen",TestPix, RESpixAdaptThresholdToBinaryGen,{"Dim RESpixAdaptThresholdToBinaryGen as Pix = LeptonicaSharp._All.pixAdaptThresholdToBinaryGen(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGenerateMaskByValue as Pix = LeptonicaSharp._All.pixGenerateMaskByValue(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateMaskByValue",TestPix, RESpixGenerateMaskByValue,{"Dim RESpixGenerateMaskByValue as Pix = LeptonicaSharp._All.pixGenerateMaskByValue(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGenerateMaskByBand as Pix = LeptonicaSharp._All.pixGenerateMaskByBand(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateMaskByBand",TestPix, RESpixGenerateMaskByBand,{"Dim RESpixGenerateMaskByBand as Pix = LeptonicaSharp._All.pixGenerateMaskByBand(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDitherTo2bpp as Pix = LeptonicaSharp._All.pixDitherTo2bpp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDitherTo2bpp",TestPix, RESpixDitherTo2bpp,{"Dim RESpixDitherTo2bpp as Pix = LeptonicaSharp._All.pixDitherTo2bpp(TestPix ,TestPix )"},1)

' Dim RESpixDitherTo2bppSpec as Pix = LeptonicaSharp._All.pixDitherTo2bppSpec(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDitherTo2bppSpec",TestPix, RESpixDitherTo2bppSpec,{"Dim RESpixDitherTo2bppSpec as Pix = LeptonicaSharp._All.pixDitherTo2bppSpec(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdTo2bpp as Pix = LeptonicaSharp._All.pixThresholdTo2bpp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdTo2bpp",TestPix, RESpixThresholdTo2bpp,{"Dim RESpixThresholdTo2bpp as Pix = LeptonicaSharp._All.pixThresholdTo2bpp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdTo4bpp as Pix = LeptonicaSharp._All.pixThresholdTo4bpp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdTo4bpp",TestPix, RESpixThresholdTo4bpp,{"Dim RESpixThresholdTo4bpp as Pix = LeptonicaSharp._All.pixThresholdTo4bpp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdOn8bpp as Pix = LeptonicaSharp._All.pixThresholdOn8bpp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdOn8bpp",TestPix, RESpixThresholdOn8bpp,{"Dim RESpixThresholdOn8bpp as Pix = LeptonicaSharp._All.pixThresholdOn8bpp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdGrayArb as Pix = LeptonicaSharp._All.pixThresholdGrayArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdGrayArb",TestPix, RESpixThresholdGrayArb,{"Dim RESpixThresholdGrayArb as Pix = LeptonicaSharp._All.pixThresholdGrayArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeGrayQuantIndexTable as Integer() = LeptonicaSharp._All.makeGrayQuantIndexTable(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeGrayQuantIndexTable",TestPix, RESmakeGrayQuantIndexTable,{"Dim RESmakeGrayQuantIndexTable as Integer() = LeptonicaSharp._All.makeGrayQuantIndexTable(TestPix )"},1)

' Dim RESmakeGrayQuantTableArb as Integer = LeptonicaSharp._All.makeGrayQuantTableArb(TestPix ,TestPix ,New List (of Integer()),New PixColormap)
' LeptonicaSharp.Convert.WriteHelpExtension ("makeGrayQuantTableArb",TestPix, RESmakeGrayQuantTableArb,{"Dim RESmakeGrayQuantTableArb as Integer = LeptonicaSharp._All.makeGrayQuantTableArb(TestPix ,TestPix ,New List (of Integer()),New PixColormap)"},1)

' Dim RESpixGenerateMaskByBand32 as Pix = LeptonicaSharp._All.pixGenerateMaskByBand32(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateMaskByBand32",TestPix, RESpixGenerateMaskByBand32,{"Dim RESpixGenerateMaskByBand32 as Pix = LeptonicaSharp._All.pixGenerateMaskByBand32(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGenerateMaskByDiscr32 as Pix = LeptonicaSharp._All.pixGenerateMaskByDiscr32(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateMaskByDiscr32",TestPix, RESpixGenerateMaskByDiscr32,{"Dim RESpixGenerateMaskByDiscr32 as Pix = LeptonicaSharp._All.pixGenerateMaskByDiscr32(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGrayQuantFromHisto as Pix = LeptonicaSharp._All.pixGrayQuantFromHisto(Nothing ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGrayQuantFromHisto",TestPix, RESpixGrayQuantFromHisto,{"Dim RESpixGrayQuantFromHisto as Pix = LeptonicaSharp._All.pixGrayQuantFromHisto(Nothing ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixGrayQuantFromCmap as Pix = LeptonicaSharp._All.pixGrayQuantFromCmap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGrayQuantFromCmap",TestPix, RESpixGrayQuantFromCmap,{"Dim RESpixGrayQuantFromCmap as Pix = LeptonicaSharp._All.pixGrayQuantFromCmap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESlheapCreate as L_Heap = LeptonicaSharp._All.lheapCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapCreate",TestPix, RESlheapCreate,{"Dim RESlheapCreate as L_Heap = LeptonicaSharp._All.lheapCreate(TestPix ,TestPix )"},1)

' Dim RESlheapDestroy as Object = LeptonicaSharp._All.lheapDestroy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapDestroy",TestPix, RESlheapDestroy,{"Dim RESlheapDestroy as Object = LeptonicaSharp._All.lheapDestroy(TestPix ,TestPix )"},1)

' Dim RESlheapAdd as Integer = LeptonicaSharp._All.lheapAdd(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapAdd",TestPix, RESlheapAdd,{"Dim RESlheapAdd as Integer = LeptonicaSharp._All.lheapAdd(TestPix ,TestPix )"},1)

' Dim RESlheapRemove as Object = LeptonicaSharp._All.lheapRemove(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapRemove",TestPix, RESlheapRemove,{"Dim RESlheapRemove as Object = LeptonicaSharp._All.lheapRemove(TestPix )"},1)

' Dim RESlheapGetCount as Integer = LeptonicaSharp._All.lheapGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapGetCount",TestPix, RESlheapGetCount,{"Dim RESlheapGetCount as Integer = LeptonicaSharp._All.lheapGetCount(TestPix )"},1)

' Dim RESlheapSwapUp as Integer = LeptonicaSharp._All.lheapSwapUp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapSwapUp",TestPix, RESlheapSwapUp,{"Dim RESlheapSwapUp as Integer = LeptonicaSharp._All.lheapSwapUp(TestPix ,TestPix )"},1)

' Dim RESlheapSwapDown as Integer = LeptonicaSharp._All.lheapSwapDown(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapSwapDown",TestPix, RESlheapSwapDown,{"Dim RESlheapSwapDown as Integer = LeptonicaSharp._All.lheapSwapDown(TestPix )"},1)

' Dim RESlheapSort as Integer = LeptonicaSharp._All.lheapSort(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapSort",TestPix, RESlheapSort,{"Dim RESlheapSort as Integer = LeptonicaSharp._All.lheapSort(TestPix )"},1)

' Dim RESlheapSortStrictOrder as Integer = LeptonicaSharp._All.lheapSortStrictOrder(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapSortStrictOrder",TestPix, RESlheapSortStrictOrder,{"Dim RESlheapSortStrictOrder as Integer = LeptonicaSharp._All.lheapSortStrictOrder(TestPix )"},1)

' Dim RESlheapPrint as Integer = LeptonicaSharp._All.lheapPrint(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lheapPrint",TestPix, RESlheapPrint,{"Dim RESlheapPrint as Integer = LeptonicaSharp._All.lheapPrint(TestPix ,TestPix )"},1)

' Dim RESjbRankHausInit as JbClasser = LeptonicaSharp._All.jbRankHausInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbRankHausInit",TestPix, RESjbRankHausInit,{"Dim RESjbRankHausInit as JbClasser = LeptonicaSharp._All.jbRankHausInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbCorrelationInit as JbClasser = LeptonicaSharp._All.jbCorrelationInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbCorrelationInit",TestPix, RESjbCorrelationInit,{"Dim RESjbCorrelationInit as JbClasser = LeptonicaSharp._All.jbCorrelationInit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbCorrelationInitWithoutComponents as JbClasser = LeptonicaSharp._All.jbCorrelationInitWithoutComponents(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbCorrelationInitWithoutComponents",TestPix, RESjbCorrelationInitWithoutComponents,{"Dim RESjbCorrelationInitWithoutComponents as JbClasser = LeptonicaSharp._All.jbCorrelationInitWithoutComponents(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbAddPages as Integer = LeptonicaSharp._All.jbAddPages(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbAddPages",TestPix, RESjbAddPages,{"Dim RESjbAddPages as Integer = LeptonicaSharp._All.jbAddPages(TestPix ,TestPix )"},1)

' Dim RESjbAddPage as Integer = LeptonicaSharp._All.jbAddPage(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbAddPage",TestPix, RESjbAddPage,{"Dim RESjbAddPage as Integer = LeptonicaSharp._All.jbAddPage(TestPix ,TestPix )"},1)

' Dim RESjbAddPageComponents as Integer = LeptonicaSharp._All.jbAddPageComponents(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbAddPageComponents",TestPix, RESjbAddPageComponents,{"Dim RESjbAddPageComponents as Integer = LeptonicaSharp._All.jbAddPageComponents(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbClassifyRankHaus as Integer = LeptonicaSharp._All.jbClassifyRankHaus(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbClassifyRankHaus",TestPix, RESjbClassifyRankHaus,{"Dim RESjbClassifyRankHaus as Integer = LeptonicaSharp._All.jbClassifyRankHaus(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHaustest as Integer = LeptonicaSharp._All.pixHaustest(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHaustest",TestPix, RESpixHaustest,{"Dim RESpixHaustest as Integer = LeptonicaSharp._All.pixHaustest(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRankHaustest as Integer = LeptonicaSharp._All.pixRankHaustest(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankHaustest",TestPix, RESpixRankHaustest,{"Dim RESpixRankHaustest as Integer = LeptonicaSharp._All.pixRankHaustest(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbClassifyCorrelation as Integer = LeptonicaSharp._All.jbClassifyCorrelation(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbClassifyCorrelation",TestPix, RESjbClassifyCorrelation,{"Dim RESjbClassifyCorrelation as Integer = LeptonicaSharp._All.jbClassifyCorrelation(TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbGetComponents as Integer = LeptonicaSharp._All.jbGetComponents(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbGetComponents",TestPix, RESjbGetComponents,{"Dim RESjbGetComponents as Integer = LeptonicaSharp._All.jbGetComponents(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWordMaskByDilation as Integer = LeptonicaSharp._All.pixWordMaskByDilation(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWordMaskByDilation",TestPix, RESpixWordMaskByDilation,{"Dim RESpixWordMaskByDilation as Integer = LeptonicaSharp._All.pixWordMaskByDilation(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixWordBoxesByDilation as Integer = LeptonicaSharp._All.pixWordBoxesByDilation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWordBoxesByDilation",TestPix, RESpixWordBoxesByDilation,{"Dim RESpixWordBoxesByDilation as Integer = LeptonicaSharp._All.pixWordBoxesByDilation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,Nothing ,Nothing )"},1)

' Dim RESjbAccumulateComposites as Pixa = LeptonicaSharp._All.jbAccumulateComposites(TestPix ,TestPix ,New Pta)
' LeptonicaSharp.Convert.WriteHelpExtension ("jbAccumulateComposites",TestPix, RESjbAccumulateComposites,{"Dim RESjbAccumulateComposites as Pixa = LeptonicaSharp._All.jbAccumulateComposites(TestPix ,TestPix ,New Pta)"},1)

' Dim RESjbTemplatesFromComposites as Pixa = LeptonicaSharp._All.jbTemplatesFromComposites(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbTemplatesFromComposites",TestPix, RESjbTemplatesFromComposites,{"Dim RESjbTemplatesFromComposites as Pixa = LeptonicaSharp._All.jbTemplatesFromComposites(TestPix ,TestPix )"},1)

' Dim RESjbClasserCreate as JbClasser = LeptonicaSharp._All.jbClasserCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbClasserCreate",TestPix, RESjbClasserCreate,{"Dim RESjbClasserCreate as JbClasser = LeptonicaSharp._All.jbClasserCreate(TestPix ,TestPix )"},1)

' Dim RESjbClasserDestroy as Object = LeptonicaSharp._All.jbClasserDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbClasserDestroy",TestPix, RESjbClasserDestroy,{"Dim RESjbClasserDestroy as Object = LeptonicaSharp._All.jbClasserDestroy(TestPix )"},1)

' Dim RESjbDataSave as JbData = LeptonicaSharp._All.jbDataSave(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbDataSave",TestPix, RESjbDataSave,{"Dim RESjbDataSave as JbData = LeptonicaSharp._All.jbDataSave(TestPix )"},1)

' Dim RESjbDataDestroy as Object = LeptonicaSharp._All.jbDataDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbDataDestroy",TestPix, RESjbDataDestroy,{"Dim RESjbDataDestroy as Object = LeptonicaSharp._All.jbDataDestroy(TestPix )"},1)

' Dim RESjbDataWrite as Integer = LeptonicaSharp._All.jbDataWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbDataWrite",TestPix, RESjbDataWrite,{"Dim RESjbDataWrite as Integer = LeptonicaSharp._All.jbDataWrite(TestPix ,TestPix )"},1)

' Dim RESjbDataRead as JbData = LeptonicaSharp._All.jbDataRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbDataRead",TestPix, RESjbDataRead,{"Dim RESjbDataRead as JbData = LeptonicaSharp._All.jbDataRead(TestPix )"},1)

' Dim RESjbDataRender as Pixa = LeptonicaSharp._All.jbDataRender(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbDataRender",TestPix, RESjbDataRender,{"Dim RESjbDataRender as Pixa = LeptonicaSharp._All.jbDataRender(TestPix ,TestPix )"},1)

' Dim RESjbGetULCorners as Integer = LeptonicaSharp._All.jbGetULCorners(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbGetULCorners",TestPix, RESjbGetULCorners,{"Dim RESjbGetULCorners as Integer = LeptonicaSharp._All.jbGetULCorners(TestPix ,TestPix ,TestPix )"},1)

' Dim RESjbGetLLCorners as Integer = LeptonicaSharp._All.jbGetLLCorners(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("jbGetLLCorners",TestPix, RESjbGetLLCorners,{"Dim RESjbGetLLCorners as Integer = LeptonicaSharp._All.jbGetLLCorners(TestPix )"},1)

' Dim RESreadHeaderJp2k as Integer = LeptonicaSharp._All.readHeaderJp2k(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderJp2k",TestPix, RESreadHeaderJp2k,{"Dim RESreadHeaderJp2k as Integer = LeptonicaSharp._All.readHeaderJp2k(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfreadHeaderJp2k as Integer = LeptonicaSharp._All.freadHeaderJp2k(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderJp2k",TestPix, RESfreadHeaderJp2k,{"Dim RESfreadHeaderJp2k as Integer = LeptonicaSharp._All.freadHeaderJp2k(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESreadHeaderMemJp2k as Integer = LeptonicaSharp._All.readHeaderMemJp2k(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemJp2k",TestPix, RESreadHeaderMemJp2k,{"Dim RESreadHeaderMemJp2k as Integer = LeptonicaSharp._All.readHeaderMemJp2k(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfgetJp2kResolution as Integer = LeptonicaSharp._All.fgetJp2kResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fgetJp2kResolution",TestPix, RESfgetJp2kResolution,{"Dim RESfgetJp2kResolution as Integer = LeptonicaSharp._All.fgetJp2kResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadJp2k as Pix = LeptonicaSharp._All.pixReadJp2k(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadJp2k",TestPix, RESpixReadJp2k,{"Dim RESpixReadJp2k as Pix = LeptonicaSharp._All.pixReadJp2k(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixReadStreamJp2k as Pix = LeptonicaSharp._All.pixReadStreamJp2k(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamJp2k",TestPix, RESpixReadStreamJp2k,{"Dim RESpixReadStreamJp2k as Pix = LeptonicaSharp._All.pixReadStreamJp2k(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixWriteJp2k as Integer = LeptonicaSharp._All.pixWriteJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteJp2k",TestPix, RESpixWriteJp2k,{"Dim RESpixWriteJp2k as Integer = LeptonicaSharp._All.pixWriteJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixWriteStreamJp2k as Integer = LeptonicaSharp._All.pixWriteStreamJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamJp2k",TestPix, RESpixWriteStreamJp2k,{"Dim RESpixWriteStreamJp2k as Integer = LeptonicaSharp._All.pixWriteStreamJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixReadMemJp2k as Pix = LeptonicaSharp._All.pixReadMemJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemJp2k",TestPix, RESpixReadMemJp2k,{"Dim RESpixReadMemJp2k as Pix = LeptonicaSharp._All.pixReadMemJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixWriteMemJp2k as Integer = LeptonicaSharp._All.pixWriteMemJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemJp2k",TestPix, RESpixWriteMemJp2k,{"Dim RESpixWriteMemJp2k as Integer = LeptonicaSharp._All.pixWriteMemJp2k(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixReadJpeg as Pix = LeptonicaSharp._All.pixReadJpeg(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadJpeg",TestPix, RESpixReadJpeg,{"Dim RESpixReadJpeg as Pix = LeptonicaSharp._All.pixReadJpeg(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixReadStreamJpeg as Pix = LeptonicaSharp._All.pixReadStreamJpeg(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamJpeg",TestPix, RESpixReadStreamJpeg,{"Dim RESpixReadStreamJpeg as Pix = LeptonicaSharp._All.pixReadStreamJpeg(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESreadHeaderJpeg as Integer = LeptonicaSharp._All.readHeaderJpeg(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderJpeg",TestPix, RESreadHeaderJpeg,{"Dim RESreadHeaderJpeg as Integer = LeptonicaSharp._All.readHeaderJpeg(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfreadHeaderJpeg as Integer = LeptonicaSharp._All.freadHeaderJpeg(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderJpeg",TestPix, RESfreadHeaderJpeg,{"Dim RESfreadHeaderJpeg as Integer = LeptonicaSharp._All.freadHeaderJpeg(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfgetJpegResolution as Integer = LeptonicaSharp._All.fgetJpegResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fgetJpegResolution",TestPix, RESfgetJpegResolution,{"Dim RESfgetJpegResolution as Integer = LeptonicaSharp._All.fgetJpegResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfgetJpegComment as Integer = LeptonicaSharp._All.fgetJpegComment(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fgetJpegComment",TestPix, RESfgetJpegComment,{"Dim RESfgetJpegComment as Integer = LeptonicaSharp._All.fgetJpegComment(TestPix ,TestPix )"},1)

' Dim RESpixWriteJpeg as Integer = LeptonicaSharp._All.pixWriteJpeg(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteJpeg",TestPix, RESpixWriteJpeg,{"Dim RESpixWriteJpeg as Integer = LeptonicaSharp._All.pixWriteJpeg(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamJpeg as Integer = LeptonicaSharp._All.pixWriteStreamJpeg(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamJpeg",TestPix, RESpixWriteStreamJpeg,{"Dim RESpixWriteStreamJpeg as Integer = LeptonicaSharp._All.pixWriteStreamJpeg(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadMemJpeg as Pix = LeptonicaSharp._All.pixReadMemJpeg(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemJpeg",TestPix, RESpixReadMemJpeg,{"Dim RESpixReadMemJpeg as Pix = LeptonicaSharp._All.pixReadMemJpeg(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESreadHeaderMemJpeg as Integer = LeptonicaSharp._All.readHeaderMemJpeg(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemJpeg",TestPix, RESreadHeaderMemJpeg,{"Dim RESreadHeaderMemJpeg as Integer = LeptonicaSharp._All.readHeaderMemJpeg(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESreadResolutionMemJpeg as Integer = LeptonicaSharp._All.readResolutionMemJpeg(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readResolutionMemJpeg",TestPix, RESreadResolutionMemJpeg,{"Dim RESreadResolutionMemJpeg as Integer = LeptonicaSharp._All.readResolutionMemJpeg(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixWriteMemJpeg as Integer = LeptonicaSharp._All.pixWriteMemJpeg(New Byte(),New UInteger,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemJpeg",TestPix, RESpixWriteMemJpeg,{"Dim RESpixWriteMemJpeg as Integer = LeptonicaSharp._All.pixWriteMemJpeg(New Byte(),New UInteger,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetChromaSampling as Integer = LeptonicaSharp._All.pixSetChromaSampling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetChromaSampling",TestPix, RESpixSetChromaSampling,{"Dim RESpixSetChromaSampling as Integer = LeptonicaSharp._All.pixSetChromaSampling(TestPix ,TestPix )"},1)

' Dim RESkernelCreate as L_Kernel = LeptonicaSharp._All.kernelCreate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelCreate",TestPix, RESkernelCreate,{"Dim RESkernelCreate as L_Kernel = LeptonicaSharp._All.kernelCreate(TestPix ,TestPix )"},1)

' Dim RESkernelDestroy as Object = LeptonicaSharp._All.kernelDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelDestroy",TestPix, RESkernelDestroy,{"Dim RESkernelDestroy as Object = LeptonicaSharp._All.kernelDestroy(TestPix )"},1)

' Dim RESkernelCopy as L_Kernel = LeptonicaSharp._All.kernelCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelCopy",TestPix, RESkernelCopy,{"Dim RESkernelCopy as L_Kernel = LeptonicaSharp._All.kernelCopy(TestPix )"},1)

' Dim RESkernelGetElement as Integer = LeptonicaSharp._All.kernelGetElement(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelGetElement",TestPix, RESkernelGetElement,{"Dim RESkernelGetElement as Integer = LeptonicaSharp._All.kernelGetElement(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESkernelSetElement as Integer = LeptonicaSharp._All.kernelSetElement(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelSetElement",TestPix, RESkernelSetElement,{"Dim RESkernelSetElement as Integer = LeptonicaSharp._All.kernelSetElement(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESkernelGetParameters as Integer = LeptonicaSharp._All.kernelGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelGetParameters",TestPix, RESkernelGetParameters,{"Dim RESkernelGetParameters as Integer = LeptonicaSharp._All.kernelGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESkernelSetOrigin as Integer = LeptonicaSharp._All.kernelSetOrigin(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelSetOrigin",TestPix, RESkernelSetOrigin,{"Dim RESkernelSetOrigin as Integer = LeptonicaSharp._All.kernelSetOrigin(TestPix ,TestPix ,TestPix )"},1)

' Dim RESkernelGetSum as Integer = LeptonicaSharp._All.kernelGetSum(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelGetSum",TestPix, RESkernelGetSum,{"Dim RESkernelGetSum as Integer = LeptonicaSharp._All.kernelGetSum(TestPix ,New Single)"},1)

' Dim RESkernelGetMinMax as Integer = LeptonicaSharp._All.kernelGetMinMax(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelGetMinMax",TestPix, RESkernelGetMinMax,{"Dim RESkernelGetMinMax as Integer = LeptonicaSharp._All.kernelGetMinMax(TestPix ,Nothing ,Nothing )"},1)

' Dim RESkernelNormalize as L_Kernel = LeptonicaSharp._All.kernelNormalize(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelNormalize",TestPix, RESkernelNormalize,{"Dim RESkernelNormalize as L_Kernel = LeptonicaSharp._All.kernelNormalize(TestPix ,TestPix )"},1)

' Dim RESkernelInvert as L_Kernel = LeptonicaSharp._All.kernelInvert(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelInvert",TestPix, RESkernelInvert,{"Dim RESkernelInvert as L_Kernel = LeptonicaSharp._All.kernelInvert(TestPix )"},1)

' Dim REScreate2dFloatArray as List(Of Single()) = LeptonicaSharp._All.create2dFloatArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("create2dFloatArray",TestPix, REScreate2dFloatArray,{"Dim REScreate2dFloatArray as List(Of Single()) = LeptonicaSharp._All.create2dFloatArray(TestPix ,TestPix )"},1)

' Dim RESkernelRead as L_Kernel = LeptonicaSharp._All.kernelRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelRead",TestPix, RESkernelRead,{"Dim RESkernelRead as L_Kernel = LeptonicaSharp._All.kernelRead(TestPix )"},1)

' Dim RESkernelReadStream as L_Kernel = LeptonicaSharp._All.kernelReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelReadStream",TestPix, RESkernelReadStream,{"Dim RESkernelReadStream as L_Kernel = LeptonicaSharp._All.kernelReadStream(TestPix )"},1)

' Dim RESkernelWrite as Integer = LeptonicaSharp._All.kernelWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelWrite",TestPix, RESkernelWrite,{"Dim RESkernelWrite as Integer = LeptonicaSharp._All.kernelWrite(TestPix ,TestPix )"},1)

' Dim RESkernelWriteStream as Integer = LeptonicaSharp._All.kernelWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelWriteStream",TestPix, RESkernelWriteStream,{"Dim RESkernelWriteStream as Integer = LeptonicaSharp._All.kernelWriteStream(TestPix ,TestPix )"},1)

' Dim RESkernelCreateFromString as L_Kernel = LeptonicaSharp._All.kernelCreateFromString(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelCreateFromString",TestPix, RESkernelCreateFromString,{"Dim RESkernelCreateFromString as L_Kernel = LeptonicaSharp._All.kernelCreateFromString(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESkernelCreateFromFile as L_Kernel = LeptonicaSharp._All.kernelCreateFromFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelCreateFromFile",TestPix, RESkernelCreateFromFile,{"Dim RESkernelCreateFromFile as L_Kernel = LeptonicaSharp._All.kernelCreateFromFile(TestPix )"},1)

' Dim RESkernelCreateFromPix as L_Kernel = LeptonicaSharp._All.kernelCreateFromPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelCreateFromPix",TestPix, RESkernelCreateFromPix,{"Dim RESkernelCreateFromPix as L_Kernel = LeptonicaSharp._All.kernelCreateFromPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESkernelDisplayInPix as Pix = LeptonicaSharp._All.kernelDisplayInPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("kernelDisplayInPix",TestPix, RESkernelDisplayInPix,{"Dim RESkernelDisplayInPix as Pix = LeptonicaSharp._All.kernelDisplayInPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESparseStringForNumbers as Numa = LeptonicaSharp._All.parseStringForNumbers(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("parseStringForNumbers",TestPix, RESparseStringForNumbers,{"Dim RESparseStringForNumbers as Numa = LeptonicaSharp._All.parseStringForNumbers(TestPix ,TestPix )"},1)

' Dim RESmakeFlatKernel as L_Kernel = LeptonicaSharp._All.makeFlatKernel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeFlatKernel",TestPix, RESmakeFlatKernel,{"Dim RESmakeFlatKernel as L_Kernel = LeptonicaSharp._All.makeFlatKernel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeGaussianKernel as L_Kernel = LeptonicaSharp._All.makeGaussianKernel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeGaussianKernel",TestPix, RESmakeGaussianKernel,{"Dim RESmakeGaussianKernel as L_Kernel = LeptonicaSharp._All.makeGaussianKernel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeGaussianKernelSep as Integer = LeptonicaSharp._All.makeGaussianKernelSep(TestPix ,TestPix ,TestPix ,TestPix ,New L_Kernel,New L_Kernel)
' LeptonicaSharp.Convert.WriteHelpExtension ("makeGaussianKernelSep",TestPix, RESmakeGaussianKernelSep,{"Dim RESmakeGaussianKernelSep as Integer = LeptonicaSharp._All.makeGaussianKernelSep(TestPix ,TestPix ,TestPix ,TestPix ,New L_Kernel,New L_Kernel)"},1)

' Dim RESmakeDoGKernel as L_Kernel = LeptonicaSharp._All.makeDoGKernel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeDoGKernel",TestPix, RESmakeDoGKernel,{"Dim RESmakeDoGKernel as L_Kernel = LeptonicaSharp._All.makeDoGKernel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetImagelibVersions as String = LeptonicaSharp._All.getImagelibVersions()
' LeptonicaSharp.Convert.WriteHelpExtension ("getImagelibVersions",TestPix, RESgetImagelibVersions,{"Dim RESgetImagelibVersions as String = LeptonicaSharp._All.getImagelibVersions()"},1)

' Dim RESlistDestroy as Object = LeptonicaSharp._All.listDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listDestroy",TestPix, RESlistDestroy,{"Dim RESlistDestroy as Object = LeptonicaSharp._All.listDestroy(TestPix )"},1)

' Dim RESlistAddToHead as Integer = LeptonicaSharp._All.listAddToHead(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listAddToHead",TestPix, RESlistAddToHead,{"Dim RESlistAddToHead as Integer = LeptonicaSharp._All.listAddToHead(Nothing ,TestPix )"},1)

' Dim RESlistAddToTail as Integer = LeptonicaSharp._All.listAddToTail(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listAddToTail",TestPix, RESlistAddToTail,{"Dim RESlistAddToTail as Integer = LeptonicaSharp._All.listAddToTail(TestPix ,TestPix ,TestPix )"},1)

' Dim RESlistInsertBefore as Integer = LeptonicaSharp._All.listInsertBefore(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listInsertBefore",TestPix, RESlistInsertBefore,{"Dim RESlistInsertBefore as Integer = LeptonicaSharp._All.listInsertBefore(Nothing ,TestPix ,TestPix )"},1)

' Dim RESlistInsertAfter as Integer = LeptonicaSharp._All.listInsertAfter(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listInsertAfter",TestPix, RESlistInsertAfter,{"Dim RESlistInsertAfter as Integer = LeptonicaSharp._All.listInsertAfter(Nothing ,TestPix ,TestPix )"},1)

' Dim RESlistRemoveElement as Object = LeptonicaSharp._All.listRemoveElement(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listRemoveElement",TestPix, RESlistRemoveElement,{"Dim RESlistRemoveElement as Object = LeptonicaSharp._All.listRemoveElement(TestPix ,TestPix )"},1)

' Dim RESlistRemoveFromHead as Object = LeptonicaSharp._All.listRemoveFromHead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listRemoveFromHead",TestPix, RESlistRemoveFromHead,{"Dim RESlistRemoveFromHead as Object = LeptonicaSharp._All.listRemoveFromHead(TestPix )"},1)

' Dim RESlistRemoveFromTail as Object = LeptonicaSharp._All.listRemoveFromTail(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listRemoveFromTail",TestPix, RESlistRemoveFromTail,{"Dim RESlistRemoveFromTail as Object = LeptonicaSharp._All.listRemoveFromTail(TestPix ,TestPix )"},1)

' Dim RESlistFindElement as DoubleLinkedList = LeptonicaSharp._All.listFindElement(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listFindElement",TestPix, RESlistFindElement,{"Dim RESlistFindElement as DoubleLinkedList = LeptonicaSharp._All.listFindElement(TestPix ,TestPix )"},1)

' Dim RESlistFindTail as DoubleLinkedList = LeptonicaSharp._All.listFindTail(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listFindTail",TestPix, RESlistFindTail,{"Dim RESlistFindTail as DoubleLinkedList = LeptonicaSharp._All.listFindTail(TestPix )"},1)

' Dim RESlistGetCount as Integer = LeptonicaSharp._All.listGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listGetCount",TestPix, RESlistGetCount,{"Dim RESlistGetCount as Integer = LeptonicaSharp._All.listGetCount(TestPix )"},1)

' Dim RESlistReverse as Integer = LeptonicaSharp._All.listReverse(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listReverse",TestPix, RESlistReverse,{"Dim RESlistReverse as Integer = LeptonicaSharp._All.listReverse(TestPix )"},1)

' Dim RESlistJoin as Integer = LeptonicaSharp._All.listJoin(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("listJoin",TestPix, RESlistJoin,{"Dim RESlistJoin as Integer = LeptonicaSharp._All.listJoin(TestPix ,TestPix )"},1)

' Dim RESl_amapCreate as L_Rbtree = LeptonicaSharp._All.l_amapCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapCreate",TestPix, RESl_amapCreate,{"Dim RESl_amapCreate as L_Rbtree = LeptonicaSharp._All.l_amapCreate(TestPix )"},1)

' Dim RESl_amapFind as RB_TYPE = LeptonicaSharp._All.l_amapFind(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapFind",TestPix, RESl_amapFind,{"Dim RESl_amapFind as RB_TYPE = LeptonicaSharp._All.l_amapFind(TestPix ,TestPix )"},1)

' Dim RESl_amapInsert as Object = LeptonicaSharp._All.l_amapInsert(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapInsert",TestPix, RESl_amapInsert,{"Dim RESl_amapInsert as Object = LeptonicaSharp._All.l_amapInsert(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_amapDelete as Object = LeptonicaSharp._All.l_amapDelete(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapDelete",TestPix, RESl_amapDelete,{"Dim RESl_amapDelete as Object = LeptonicaSharp._All.l_amapDelete(TestPix ,TestPix )"},1)

' Dim RESl_amapDestroy as Object = LeptonicaSharp._All.l_amapDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapDestroy",TestPix, RESl_amapDestroy,{"Dim RESl_amapDestroy as Object = LeptonicaSharp._All.l_amapDestroy(TestPix )"},1)

' Dim RESl_amapGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetFirst(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapGetFirst",TestPix, RESl_amapGetFirst,{"Dim RESl_amapGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetFirst(TestPix )"},1)

' Dim RESl_amapGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetNext(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapGetNext",TestPix, RESl_amapGetNext,{"Dim RESl_amapGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetNext(TestPix )"},1)

' Dim RESl_amapGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetLast(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapGetLast",TestPix, RESl_amapGetLast,{"Dim RESl_amapGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetLast(TestPix )"},1)

' Dim RESl_amapGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetPrev(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapGetPrev",TestPix, RESl_amapGetPrev,{"Dim RESl_amapGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_amapGetPrev(TestPix )"},1)

' Dim RESl_amapSize as Integer = LeptonicaSharp._All.l_amapSize(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_amapSize",TestPix, RESl_amapSize,{"Dim RESl_amapSize as Integer = LeptonicaSharp._All.l_amapSize(TestPix )"},1)

' Dim RESl_asetCreate as L_Rbtree = LeptonicaSharp._All.l_asetCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetCreate",TestPix, RESl_asetCreate,{"Dim RESl_asetCreate as L_Rbtree = LeptonicaSharp._All.l_asetCreate(TestPix )"},1)

' Dim RESl_asetFind as RB_TYPE = LeptonicaSharp._All.l_asetFind(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetFind",TestPix, RESl_asetFind,{"Dim RESl_asetFind as RB_TYPE = LeptonicaSharp._All.l_asetFind(TestPix ,TestPix )"},1)

' Dim RESl_asetInsert as Object = LeptonicaSharp._All.l_asetInsert(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetInsert",TestPix, RESl_asetInsert,{"Dim RESl_asetInsert as Object = LeptonicaSharp._All.l_asetInsert(TestPix ,TestPix )"},1)

' Dim RESl_asetDelete as Object = LeptonicaSharp._All.l_asetDelete(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetDelete",TestPix, RESl_asetDelete,{"Dim RESl_asetDelete as Object = LeptonicaSharp._All.l_asetDelete(TestPix ,TestPix )"},1)

' Dim RESl_asetDestroy as Object = LeptonicaSharp._All.l_asetDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetDestroy",TestPix, RESl_asetDestroy,{"Dim RESl_asetDestroy as Object = LeptonicaSharp._All.l_asetDestroy(TestPix )"},1)

' Dim RESl_asetGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetFirst(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetGetFirst",TestPix, RESl_asetGetFirst,{"Dim RESl_asetGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetFirst(TestPix )"},1)

' Dim RESl_asetGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetNext(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetGetNext",TestPix, RESl_asetGetNext,{"Dim RESl_asetGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetNext(TestPix )"},1)

' Dim RESl_asetGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetLast(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetGetLast",TestPix, RESl_asetGetLast,{"Dim RESl_asetGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetLast(TestPix )"},1)

' Dim RESl_asetGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetPrev(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetGetPrev",TestPix, RESl_asetGetPrev,{"Dim RESl_asetGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_asetGetPrev(TestPix )"},1)

' Dim RESl_asetSize as Integer = LeptonicaSharp._All.l_asetSize(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetSize",TestPix, RESl_asetSize,{"Dim RESl_asetSize as Integer = LeptonicaSharp._All.l_asetSize(TestPix )"},1)

' Dim RESgenerateBinaryMaze as Pix = LeptonicaSharp._All.generateBinaryMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generateBinaryMaze",TestPix, RESgenerateBinaryMaze,{"Dim RESgenerateBinaryMaze as Pix = LeptonicaSharp._All.generateBinaryMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSearchBinaryMaze as Pta = LeptonicaSharp._All.pixSearchBinaryMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSearchBinaryMaze",TestPix, RESpixSearchBinaryMaze,{"Dim RESpixSearchBinaryMaze as Pta = LeptonicaSharp._All.pixSearchBinaryMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSearchGrayMaze as Pta = LeptonicaSharp._All.pixSearchGrayMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSearchGrayMaze",TestPix, RESpixSearchGrayMaze,{"Dim RESpixSearchGrayMaze as Pta = LeptonicaSharp._All.pixSearchGrayMaze(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixDilate as Pix = LeptonicaSharp._All.pixDilate(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilate",TestPix, RESpixDilate,{"Dim RESpixDilate as Pix = LeptonicaSharp._All.pixDilate(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixErode as Pix = LeptonicaSharp._All.pixErode(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErode",TestPix, RESpixErode,{"Dim RESpixErode as Pix = LeptonicaSharp._All.pixErode(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixHMT as Pix = LeptonicaSharp._All.pixHMT(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHMT",TestPix, RESpixHMT,{"Dim RESpixHMT as Pix = LeptonicaSharp._All.pixHMT(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixOpen as Pix = LeptonicaSharp._All.pixOpen(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpen",TestPix, RESpixOpen,{"Dim RESpixOpen as Pix = LeptonicaSharp._All.pixOpen(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixClose as Pix = LeptonicaSharp._All.pixClose(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClose",TestPix, RESpixClose,{"Dim RESpixClose as Pix = LeptonicaSharp._All.pixClose(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixCloseSafe as Pix = LeptonicaSharp._All.pixCloseSafe(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseSafe",TestPix, RESpixCloseSafe,{"Dim RESpixCloseSafe as Pix = LeptonicaSharp._All.pixCloseSafe(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixOpenGeneralized as Pix = LeptonicaSharp._All.pixOpenGeneralized(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenGeneralized",TestPix, RESpixOpenGeneralized,{"Dim RESpixOpenGeneralized as Pix = LeptonicaSharp._All.pixOpenGeneralized(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixCloseGeneralized as Pix = LeptonicaSharp._All.pixCloseGeneralized(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseGeneralized",TestPix, RESpixCloseGeneralized,{"Dim RESpixCloseGeneralized as Pix = LeptonicaSharp._All.pixCloseGeneralized(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixDilateBrick as Pix = LeptonicaSharp._All.pixDilateBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateBrick",TestPix, RESpixDilateBrick,{"Dim RESpixDilateBrick as Pix = LeptonicaSharp._All.pixDilateBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeBrick as Pix = LeptonicaSharp._All.pixErodeBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeBrick",TestPix, RESpixErodeBrick,{"Dim RESpixErodeBrick as Pix = LeptonicaSharp._All.pixErodeBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenBrick as Pix = LeptonicaSharp._All.pixOpenBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenBrick",TestPix, RESpixOpenBrick,{"Dim RESpixOpenBrick as Pix = LeptonicaSharp._All.pixOpenBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseBrick as Pix = LeptonicaSharp._All.pixCloseBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseBrick",TestPix, RESpixCloseBrick,{"Dim RESpixCloseBrick as Pix = LeptonicaSharp._All.pixCloseBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseSafeBrick as Pix = LeptonicaSharp._All.pixCloseSafeBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseSafeBrick",TestPix, RESpixCloseSafeBrick,{"Dim RESpixCloseSafeBrick as Pix = LeptonicaSharp._All.pixCloseSafeBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselectComposableSels as Integer = LeptonicaSharp._All.selectComposableSels(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selectComposableSels",TestPix, RESselectComposableSels,{"Dim RESselectComposableSels as Integer = LeptonicaSharp._All.selectComposableSels(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselectComposableSizes as Integer = LeptonicaSharp._All.selectComposableSizes(TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("selectComposableSizes",TestPix, RESselectComposableSizes,{"Dim RESselectComposableSizes as Integer = LeptonicaSharp._All.selectComposableSizes(TestPix ,New Integer,New Integer)"},1)

' Dim RESpixDilateCompBrick as Pix = LeptonicaSharp._All.pixDilateCompBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateCompBrick",TestPix, RESpixDilateCompBrick,{"Dim RESpixDilateCompBrick as Pix = LeptonicaSharp._All.pixDilateCompBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeCompBrick as Pix = LeptonicaSharp._All.pixErodeCompBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeCompBrick",TestPix, RESpixErodeCompBrick,{"Dim RESpixErodeCompBrick as Pix = LeptonicaSharp._All.pixErodeCompBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenCompBrick as Pix = LeptonicaSharp._All.pixOpenCompBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenCompBrick",TestPix, RESpixOpenCompBrick,{"Dim RESpixOpenCompBrick as Pix = LeptonicaSharp._All.pixOpenCompBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseCompBrick as Pix = LeptonicaSharp._All.pixCloseCompBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseCompBrick",TestPix, RESpixCloseCompBrick,{"Dim RESpixCloseCompBrick as Pix = LeptonicaSharp._All.pixCloseCompBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseSafeCompBrick as Pix = LeptonicaSharp._All.pixCloseSafeCompBrick(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseSafeCompBrick",TestPix, RESpixCloseSafeCompBrick,{"Dim RESpixCloseSafeCompBrick as Pix = LeptonicaSharp._All.pixCloseSafeCompBrick(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESresetMorphBoundaryCondition as Object = LeptonicaSharp._All.resetMorphBoundaryCondition(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("resetMorphBoundaryCondition",TestPix, RESresetMorphBoundaryCondition,{"Dim RESresetMorphBoundaryCondition as Object = LeptonicaSharp._All.resetMorphBoundaryCondition(TestPix )"},1)

' Dim RESgetMorphBorderPixelColor as UInteger = LeptonicaSharp._All.getMorphBorderPixelColor(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getMorphBorderPixelColor",TestPix, RESgetMorphBorderPixelColor,{"Dim RESgetMorphBorderPixelColor as UInteger = LeptonicaSharp._All.getMorphBorderPixelColor(TestPix ,TestPix )"},1)

' Dim RESpixExtractBoundary as Pix = LeptonicaSharp._All.pixExtractBoundary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBoundary",TestPix, RESpixExtractBoundary,{"Dim RESpixExtractBoundary as Pix = LeptonicaSharp._All.pixExtractBoundary(TestPix ,TestPix )"},1)

' Dim RESpixMorphSequenceMasked as Pix = LeptonicaSharp._All.pixMorphSequenceMasked(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphSequenceMasked",TestPix, RESpixMorphSequenceMasked,{"Dim RESpixMorphSequenceMasked as Pix = LeptonicaSharp._All.pixMorphSequenceMasked(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixMorphSequenceByComponent as Pix = LeptonicaSharp._All.pixMorphSequenceByComponent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphSequenceByComponent",TestPix, RESpixMorphSequenceByComponent,{"Dim RESpixMorphSequenceByComponent as Pix = LeptonicaSharp._All.pixMorphSequenceByComponent(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaMorphSequenceByComponent as Pixa = LeptonicaSharp._All.pixaMorphSequenceByComponent(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaMorphSequenceByComponent",TestPix, RESpixaMorphSequenceByComponent,{"Dim RESpixaMorphSequenceByComponent as Pixa = LeptonicaSharp._All.pixaMorphSequenceByComponent(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphSequenceByRegion as Pix = LeptonicaSharp._All.pixMorphSequenceByRegion(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphSequenceByRegion",TestPix, RESpixMorphSequenceByRegion,{"Dim RESpixMorphSequenceByRegion as Pix = LeptonicaSharp._All.pixMorphSequenceByRegion(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaMorphSequenceByRegion as Pixa = LeptonicaSharp._All.pixaMorphSequenceByRegion(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaMorphSequenceByRegion",TestPix, RESpixaMorphSequenceByRegion,{"Dim RESpixaMorphSequenceByRegion as Pixa = LeptonicaSharp._All.pixaMorphSequenceByRegion(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixUnionOfMorphOps as Pix = LeptonicaSharp._All.pixUnionOfMorphOps(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnionOfMorphOps",TestPix, RESpixUnionOfMorphOps,{"Dim RESpixUnionOfMorphOps as Pix = LeptonicaSharp._All.pixUnionOfMorphOps(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixIntersectionOfMorphOps as Pix = LeptonicaSharp._All.pixIntersectionOfMorphOps(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixIntersectionOfMorphOps",TestPix, RESpixIntersectionOfMorphOps,{"Dim RESpixIntersectionOfMorphOps as Pix = LeptonicaSharp._All.pixIntersectionOfMorphOps(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSelectiveConnCompFill as Pix = LeptonicaSharp._All.pixSelectiveConnCompFill(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectiveConnCompFill",TestPix, RESpixSelectiveConnCompFill,{"Dim RESpixSelectiveConnCompFill as Pix = LeptonicaSharp._All.pixSelectiveConnCompFill(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveMatchedPattern as Integer = LeptonicaSharp._All.pixRemoveMatchedPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveMatchedPattern",TestPix, RESpixRemoveMatchedPattern,{"Dim RESpixRemoveMatchedPattern as Integer = LeptonicaSharp._All.pixRemoveMatchedPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayMatchedPattern as Pix = LeptonicaSharp._All.pixDisplayMatchedPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayMatchedPattern",TestPix, RESpixDisplayMatchedPattern,{"Dim RESpixDisplayMatchedPattern as Pix = LeptonicaSharp._All.pixDisplayMatchedPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaExtendByMorph as Pixa = LeptonicaSharp._All.pixaExtendByMorph(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaExtendByMorph",TestPix, RESpixaExtendByMorph,{"Dim RESpixaExtendByMorph as Pixa = LeptonicaSharp._All.pixaExtendByMorph(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaExtendByScaling as Pixa = LeptonicaSharp._All.pixaExtendByScaling(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaExtendByScaling",TestPix, RESpixaExtendByScaling,{"Dim RESpixaExtendByScaling as Pixa = LeptonicaSharp._All.pixaExtendByScaling(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillMorph as Pix = LeptonicaSharp._All.pixSeedfillMorph(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillMorph",TestPix, RESpixSeedfillMorph,{"Dim RESpixSeedfillMorph as Pix = LeptonicaSharp._All.pixSeedfillMorph(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRunHistogramMorph as Numa = LeptonicaSharp._All.pixRunHistogramMorph(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRunHistogramMorph",TestPix, RESpixRunHistogramMorph,{"Dim RESpixRunHistogramMorph as Numa = LeptonicaSharp._All.pixRunHistogramMorph(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTophat as Pix = LeptonicaSharp._All.pixTophat(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTophat",TestPix, RESpixTophat,{"Dim RESpixTophat as Pix = LeptonicaSharp._All.pixTophat(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHDome as Pix = LeptonicaSharp._All.pixHDome(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHDome",TestPix, RESpixHDome,{"Dim RESpixHDome as Pix = LeptonicaSharp._All.pixHDome(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFastTophat as Pix = LeptonicaSharp._All.pixFastTophat(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFastTophat",TestPix, RESpixFastTophat,{"Dim RESpixFastTophat as Pix = LeptonicaSharp._All.pixFastTophat(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphGradient as Pix = LeptonicaSharp._All.pixMorphGradient(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphGradient",TestPix, RESpixMorphGradient,{"Dim RESpixMorphGradient as Pix = LeptonicaSharp._All.pixMorphGradient(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaCentroids as Pta = LeptonicaSharp._All.pixaCentroids(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCentroids",TestPix, RESpixaCentroids,{"Dim RESpixaCentroids as Pta = LeptonicaSharp._All.pixaCentroids(TestPix )"},1)

' Dim RESpixCentroid as Integer = LeptonicaSharp._All.pixCentroid(TestPix ,Nothing ,Nothing ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCentroid",TestPix, RESpixCentroid,{"Dim RESpixCentroid as Integer = LeptonicaSharp._All.pixCentroid(TestPix ,Nothing ,Nothing ,New Single,New Single)"},1)

' Dim RESpixDilateBrickDwa as Pix = LeptonicaSharp._All.pixDilateBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateBrickDwa",TestPix, RESpixDilateBrickDwa,{"Dim RESpixDilateBrickDwa as Pix = LeptonicaSharp._All.pixDilateBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeBrickDwa as Pix = LeptonicaSharp._All.pixErodeBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeBrickDwa",TestPix, RESpixErodeBrickDwa,{"Dim RESpixErodeBrickDwa as Pix = LeptonicaSharp._All.pixErodeBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenBrickDwa as Pix = LeptonicaSharp._All.pixOpenBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenBrickDwa",TestPix, RESpixOpenBrickDwa,{"Dim RESpixOpenBrickDwa as Pix = LeptonicaSharp._All.pixOpenBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseBrickDwa as Pix = LeptonicaSharp._All.pixCloseBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseBrickDwa",TestPix, RESpixCloseBrickDwa,{"Dim RESpixCloseBrickDwa as Pix = LeptonicaSharp._All.pixCloseBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDilateCompBrickDwa as Pix = LeptonicaSharp._All.pixDilateCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateCompBrickDwa",TestPix, RESpixDilateCompBrickDwa,{"Dim RESpixDilateCompBrickDwa as Pix = LeptonicaSharp._All.pixDilateCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeCompBrickDwa as Pix = LeptonicaSharp._All.pixErodeCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeCompBrickDwa",TestPix, RESpixErodeCompBrickDwa,{"Dim RESpixErodeCompBrickDwa as Pix = LeptonicaSharp._All.pixErodeCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenCompBrickDwa as Pix = LeptonicaSharp._All.pixOpenCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenCompBrickDwa",TestPix, RESpixOpenCompBrickDwa,{"Dim RESpixOpenCompBrickDwa as Pix = LeptonicaSharp._All.pixOpenCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseCompBrickDwa as Pix = LeptonicaSharp._All.pixCloseCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseCompBrickDwa",TestPix, RESpixCloseCompBrickDwa,{"Dim RESpixCloseCompBrickDwa as Pix = LeptonicaSharp._All.pixCloseCompBrickDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDilateCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixDilateCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDilateCompBrickExtendDwa",TestPix, RESpixDilateCompBrickExtendDwa,{"Dim RESpixDilateCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixDilateCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixErodeCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixErodeCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixErodeCompBrickExtendDwa",TestPix, RESpixErodeCompBrickExtendDwa,{"Dim RESpixErodeCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixErodeCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixOpenCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixOpenCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOpenCompBrickExtendDwa",TestPix, RESpixOpenCompBrickExtendDwa,{"Dim RESpixOpenCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixOpenCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCloseCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixCloseCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCloseCompBrickExtendDwa",TestPix, RESpixCloseCompBrickExtendDwa,{"Dim RESpixCloseCompBrickExtendDwa as Pix = LeptonicaSharp._All.pixCloseCompBrickExtendDwa(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetExtendedCompositeParameters as Integer = LeptonicaSharp._All.getExtendedCompositeParameters(TestPix ,New Integer,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("getExtendedCompositeParameters",TestPix, RESgetExtendedCompositeParameters,{"Dim RESgetExtendedCompositeParameters as Integer = LeptonicaSharp._All.getExtendedCompositeParameters(TestPix ,New Integer,New Integer,Nothing )"},1)

' Dim RESpixMorphSequence as Pix = LeptonicaSharp._All.pixMorphSequence(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphSequence",TestPix, RESpixMorphSequence,{"Dim RESpixMorphSequence as Pix = LeptonicaSharp._All.pixMorphSequence(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphCompSequence as Pix = LeptonicaSharp._All.pixMorphCompSequence(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphCompSequence",TestPix, RESpixMorphCompSequence,{"Dim RESpixMorphCompSequence as Pix = LeptonicaSharp._All.pixMorphCompSequence(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphSequenceDwa as Pix = LeptonicaSharp._All.pixMorphSequenceDwa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphSequenceDwa",TestPix, RESpixMorphSequenceDwa,{"Dim RESpixMorphSequenceDwa as Pix = LeptonicaSharp._All.pixMorphSequenceDwa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMorphCompSequenceDwa as Pix = LeptonicaSharp._All.pixMorphCompSequenceDwa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMorphCompSequenceDwa",TestPix, RESpixMorphCompSequenceDwa,{"Dim RESpixMorphCompSequenceDwa as Pix = LeptonicaSharp._All.pixMorphCompSequenceDwa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESmorphSequenceVerify as Integer = LeptonicaSharp._All.morphSequenceVerify(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("morphSequenceVerify",TestPix, RESmorphSequenceVerify,{"Dim RESmorphSequenceVerify as Integer = LeptonicaSharp._All.morphSequenceVerify(TestPix )"},1)

' Dim RESpixGrayMorphSequence as Pix = LeptonicaSharp._All.pixGrayMorphSequence(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGrayMorphSequence",TestPix, RESpixGrayMorphSequence,{"Dim RESpixGrayMorphSequence as Pix = LeptonicaSharp._All.pixGrayMorphSequence(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorMorphSequence as Pix = LeptonicaSharp._All.pixColorMorphSequence(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorMorphSequence",TestPix, RESpixColorMorphSequence,{"Dim RESpixColorMorphSequence as Pix = LeptonicaSharp._All.pixColorMorphSequence(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaCreate as Numa = LeptonicaSharp._All.numaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCreate",TestPix, RESnumaCreate,{"Dim RESnumaCreate as Numa = LeptonicaSharp._All.numaCreate(TestPix )"},1)

' Dim RESnumaCreateFromIArray as Numa = LeptonicaSharp._All.numaCreateFromIArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCreateFromIArray",TestPix, RESnumaCreateFromIArray,{"Dim RESnumaCreateFromIArray as Numa = LeptonicaSharp._All.numaCreateFromIArray(TestPix ,TestPix )"},1)

' Dim RESnumaCreateFromFArray as Numa = LeptonicaSharp._All.numaCreateFromFArray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCreateFromFArray",TestPix, RESnumaCreateFromFArray,{"Dim RESnumaCreateFromFArray as Numa = LeptonicaSharp._All.numaCreateFromFArray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaCreateFromString as Numa = LeptonicaSharp._All.numaCreateFromString(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCreateFromString",TestPix, RESnumaCreateFromString,{"Dim RESnumaCreateFromString as Numa = LeptonicaSharp._All.numaCreateFromString(TestPix )"},1)

' Dim RESnumaDestroy as Object = LeptonicaSharp._All.numaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaDestroy",TestPix, RESnumaDestroy,{"Dim RESnumaDestroy as Object = LeptonicaSharp._All.numaDestroy(TestPix )"},1)

' Dim RESnumaCopy as Numa = LeptonicaSharp._All.numaCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCopy",TestPix, RESnumaCopy,{"Dim RESnumaCopy as Numa = LeptonicaSharp._All.numaCopy(TestPix )"},1)

' Dim RESnumaClone as Numa = LeptonicaSharp._All.numaClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaClone",TestPix, RESnumaClone,{"Dim RESnumaClone as Numa = LeptonicaSharp._All.numaClone(TestPix )"},1)

' Dim RESnumaEmpty as Integer = LeptonicaSharp._All.numaEmpty(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaEmpty",TestPix, RESnumaEmpty,{"Dim RESnumaEmpty as Integer = LeptonicaSharp._All.numaEmpty(TestPix )"},1)

' Dim RESnumaAddNumber as Integer = LeptonicaSharp._All.numaAddNumber(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaAddNumber",TestPix, RESnumaAddNumber,{"Dim RESnumaAddNumber as Integer = LeptonicaSharp._All.numaAddNumber(TestPix ,TestPix )"},1)

' Dim RESnumaInsertNumber as Integer = LeptonicaSharp._All.numaInsertNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInsertNumber",TestPix, RESnumaInsertNumber,{"Dim RESnumaInsertNumber as Integer = LeptonicaSharp._All.numaInsertNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaRemoveNumber as Integer = LeptonicaSharp._All.numaRemoveNumber(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaRemoveNumber",TestPix, RESnumaRemoveNumber,{"Dim RESnumaRemoveNumber as Integer = LeptonicaSharp._All.numaRemoveNumber(TestPix ,TestPix )"},1)

' Dim RESnumaReplaceNumber as Integer = LeptonicaSharp._All.numaReplaceNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaReplaceNumber",TestPix, RESnumaReplaceNumber,{"Dim RESnumaReplaceNumber as Integer = LeptonicaSharp._All.numaReplaceNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaGetCount as Integer = LeptonicaSharp._All.numaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetCount",TestPix, RESnumaGetCount,{"Dim RESnumaGetCount as Integer = LeptonicaSharp._All.numaGetCount(TestPix )"},1)

' Dim RESnumaSetCount as Integer = LeptonicaSharp._All.numaSetCount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSetCount",TestPix, RESnumaSetCount,{"Dim RESnumaSetCount as Integer = LeptonicaSharp._All.numaSetCount(TestPix ,TestPix )"},1)

' Dim RESnumaGetFValue as Integer = LeptonicaSharp._All.numaGetFValue(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetFValue",TestPix, RESnumaGetFValue,{"Dim RESnumaGetFValue as Integer = LeptonicaSharp._All.numaGetFValue(TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaGetIValue as Integer = LeptonicaSharp._All.numaGetIValue(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetIValue",TestPix, RESnumaGetIValue,{"Dim RESnumaGetIValue as Integer = LeptonicaSharp._All.numaGetIValue(TestPix ,TestPix ,New Integer)"},1)

' Dim RESnumaSetValue as Integer = LeptonicaSharp._All.numaSetValue(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSetValue",TestPix, RESnumaSetValue,{"Dim RESnumaSetValue as Integer = LeptonicaSharp._All.numaSetValue(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaShiftValue as Integer = LeptonicaSharp._All.numaShiftValue(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaShiftValue",TestPix, RESnumaShiftValue,{"Dim RESnumaShiftValue as Integer = LeptonicaSharp._All.numaShiftValue(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaGetIArray as Integer() = LeptonicaSharp._All.numaGetIArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetIArray",TestPix, RESnumaGetIArray,{"Dim RESnumaGetIArray as Integer() = LeptonicaSharp._All.numaGetIArray(TestPix )"},1)

' Dim RESnumaGetFArray as Single() = LeptonicaSharp._All.numaGetFArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetFArray",TestPix, RESnumaGetFArray,{"Dim RESnumaGetFArray as Single() = LeptonicaSharp._All.numaGetFArray(TestPix ,TestPix )"},1)

' Dim RESnumaGetRefcount as Integer = LeptonicaSharp._All.numaGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetRefcount",TestPix, RESnumaGetRefcount,{"Dim RESnumaGetRefcount as Integer = LeptonicaSharp._All.numaGetRefcount(TestPix )"},1)

' Dim RESnumaChangeRefcount as Integer = LeptonicaSharp._All.numaChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaChangeRefcount",TestPix, RESnumaChangeRefcount,{"Dim RESnumaChangeRefcount as Integer = LeptonicaSharp._All.numaChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESnumaGetParameters as Integer = LeptonicaSharp._All.numaGetParameters(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetParameters",TestPix, RESnumaGetParameters,{"Dim RESnumaGetParameters as Integer = LeptonicaSharp._All.numaGetParameters(TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaSetParameters as Integer = LeptonicaSharp._All.numaSetParameters(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSetParameters",TestPix, RESnumaSetParameters,{"Dim RESnumaSetParameters as Integer = LeptonicaSharp._All.numaSetParameters(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaCopyParameters as Integer = LeptonicaSharp._All.numaCopyParameters(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCopyParameters",TestPix, RESnumaCopyParameters,{"Dim RESnumaCopyParameters as Integer = LeptonicaSharp._All.numaCopyParameters(TestPix ,TestPix )"},1)

' Dim RESnumaConvertToSarray as Sarray = LeptonicaSharp._All.numaConvertToSarray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaConvertToSarray",TestPix, RESnumaConvertToSarray,{"Dim RESnumaConvertToSarray as Sarray = LeptonicaSharp._All.numaConvertToSarray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaRead as Numa = LeptonicaSharp._All.numaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaRead",TestPix, RESnumaRead,{"Dim RESnumaRead as Numa = LeptonicaSharp._All.numaRead(TestPix )"},1)

' Dim RESnumaReadStream as Numa = LeptonicaSharp._All.numaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaReadStream",TestPix, RESnumaReadStream,{"Dim RESnumaReadStream as Numa = LeptonicaSharp._All.numaReadStream(TestPix )"},1)

' Dim RESnumaReadMem as Numa = LeptonicaSharp._All.numaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaReadMem",TestPix, RESnumaReadMem,{"Dim RESnumaReadMem as Numa = LeptonicaSharp._All.numaReadMem(TestPix ,TestPix )"},1)

' Dim RESnumaWriteDebug as Integer = LeptonicaSharp._All.numaWriteDebug(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWriteDebug",TestPix, RESnumaWriteDebug,{"Dim RESnumaWriteDebug as Integer = LeptonicaSharp._All.numaWriteDebug(TestPix ,TestPix )"},1)

' Dim RESnumaWrite as Integer = LeptonicaSharp._All.numaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWrite",TestPix, RESnumaWrite,{"Dim RESnumaWrite as Integer = LeptonicaSharp._All.numaWrite(TestPix ,TestPix )"},1)

' Dim RESnumaWriteStream as Integer = LeptonicaSharp._All.numaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWriteStream",TestPix, RESnumaWriteStream,{"Dim RESnumaWriteStream as Integer = LeptonicaSharp._All.numaWriteStream(TestPix ,TestPix )"},1)

' Dim RESnumaWriteMem as Integer = LeptonicaSharp._All.numaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWriteMem",TestPix, RESnumaWriteMem,{"Dim RESnumaWriteMem as Integer = LeptonicaSharp._All.numaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESnumaaCreate as Numaa = LeptonicaSharp._All.numaaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaCreate",TestPix, RESnumaaCreate,{"Dim RESnumaaCreate as Numaa = LeptonicaSharp._All.numaaCreate(TestPix )"},1)

' Dim RESnumaaCreateFull as Numaa = LeptonicaSharp._All.numaaCreateFull(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaCreateFull",TestPix, RESnumaaCreateFull,{"Dim RESnumaaCreateFull as Numaa = LeptonicaSharp._All.numaaCreateFull(TestPix ,TestPix )"},1)

' Dim RESnumaaTruncate as Integer = LeptonicaSharp._All.numaaTruncate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaTruncate",TestPix, RESnumaaTruncate,{"Dim RESnumaaTruncate as Integer = LeptonicaSharp._All.numaaTruncate(TestPix )"},1)

' Dim RESnumaaDestroy as Object = LeptonicaSharp._All.numaaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaDestroy",TestPix, RESnumaaDestroy,{"Dim RESnumaaDestroy as Object = LeptonicaSharp._All.numaaDestroy(TestPix )"},1)

' Dim RESnumaaAddNuma as Integer = LeptonicaSharp._All.numaaAddNuma(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaAddNuma",TestPix, RESnumaaAddNuma,{"Dim RESnumaaAddNuma as Integer = LeptonicaSharp._All.numaaAddNuma(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaaGetCount as Integer = LeptonicaSharp._All.numaaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetCount",TestPix, RESnumaaGetCount,{"Dim RESnumaaGetCount as Integer = LeptonicaSharp._All.numaaGetCount(TestPix )"},1)

' Dim RESnumaaGetNumaCount as Integer = LeptonicaSharp._All.numaaGetNumaCount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetNumaCount",TestPix, RESnumaaGetNumaCount,{"Dim RESnumaaGetNumaCount as Integer = LeptonicaSharp._All.numaaGetNumaCount(TestPix ,TestPix )"},1)

' Dim RESnumaaGetNumberCount as Integer = LeptonicaSharp._All.numaaGetNumberCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetNumberCount",TestPix, RESnumaaGetNumberCount,{"Dim RESnumaaGetNumberCount as Integer = LeptonicaSharp._All.numaaGetNumberCount(TestPix )"},1)

' Dim RESnumaaGetPtrArray as Numa = LeptonicaSharp._All.numaaGetPtrArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetPtrArray",TestPix, RESnumaaGetPtrArray,{"Dim RESnumaaGetPtrArray as Numa = LeptonicaSharp._All.numaaGetPtrArray(TestPix )"},1)

' Dim RESnumaaGetNuma as Numa = LeptonicaSharp._All.numaaGetNuma(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetNuma",TestPix, RESnumaaGetNuma,{"Dim RESnumaaGetNuma as Numa = LeptonicaSharp._All.numaaGetNuma(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaaReplaceNuma as Integer = LeptonicaSharp._All.numaaReplaceNuma(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaReplaceNuma",TestPix, RESnumaaReplaceNuma,{"Dim RESnumaaReplaceNuma as Integer = LeptonicaSharp._All.numaaReplaceNuma(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaaGetValue as Integer = LeptonicaSharp._All.numaaGetValue(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaGetValue",TestPix, RESnumaaGetValue,{"Dim RESnumaaGetValue as Integer = LeptonicaSharp._All.numaaGetValue(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaaAddNumber as Integer = LeptonicaSharp._All.numaaAddNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaAddNumber",TestPix, RESnumaaAddNumber,{"Dim RESnumaaAddNumber as Integer = LeptonicaSharp._All.numaaAddNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaaRead as Numaa = LeptonicaSharp._All.numaaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaRead",TestPix, RESnumaaRead,{"Dim RESnumaaRead as Numaa = LeptonicaSharp._All.numaaRead(TestPix )"},1)

' Dim RESnumaaReadStream as Numaa = LeptonicaSharp._All.numaaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaReadStream",TestPix, RESnumaaReadStream,{"Dim RESnumaaReadStream as Numaa = LeptonicaSharp._All.numaaReadStream(TestPix )"},1)

' Dim RESnumaaReadMem as Numaa = LeptonicaSharp._All.numaaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaReadMem",TestPix, RESnumaaReadMem,{"Dim RESnumaaReadMem as Numaa = LeptonicaSharp._All.numaaReadMem(TestPix ,TestPix )"},1)

' Dim RESnumaaWrite as Integer = LeptonicaSharp._All.numaaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaWrite",TestPix, RESnumaaWrite,{"Dim RESnumaaWrite as Integer = LeptonicaSharp._All.numaaWrite(TestPix ,TestPix )"},1)

' Dim RESnumaaWriteStream as Integer = LeptonicaSharp._All.numaaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaWriteStream",TestPix, RESnumaaWriteStream,{"Dim RESnumaaWriteStream as Integer = LeptonicaSharp._All.numaaWriteStream(TestPix ,TestPix )"},1)

' Dim RESnumaaWriteMem as Integer = LeptonicaSharp._All.numaaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaWriteMem",TestPix, RESnumaaWriteMem,{"Dim RESnumaaWriteMem as Integer = LeptonicaSharp._All.numaaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESnumaArithOp as Numa = LeptonicaSharp._All.numaArithOp(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaArithOp",TestPix, RESnumaArithOp,{"Dim RESnumaArithOp as Numa = LeptonicaSharp._All.numaArithOp(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaLogicalOp as Numa = LeptonicaSharp._All.numaLogicalOp(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaLogicalOp",TestPix, RESnumaLogicalOp,{"Dim RESnumaLogicalOp as Numa = LeptonicaSharp._All.numaLogicalOp(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaInvert as Numa = LeptonicaSharp._All.numaInvert(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInvert",TestPix, RESnumaInvert,{"Dim RESnumaInvert as Numa = LeptonicaSharp._All.numaInvert(Nothing ,TestPix )"},1)

' Dim RESnumaSimilar as Integer = LeptonicaSharp._All.numaSimilar(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSimilar",TestPix, RESnumaSimilar,{"Dim RESnumaSimilar as Integer = LeptonicaSharp._All.numaSimilar(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESnumaAddToNumber as Integer = LeptonicaSharp._All.numaAddToNumber(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaAddToNumber",TestPix, RESnumaAddToNumber,{"Dim RESnumaAddToNumber as Integer = LeptonicaSharp._All.numaAddToNumber(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaGetMin as Integer = LeptonicaSharp._All.numaGetMin(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetMin",TestPix, RESnumaGetMin,{"Dim RESnumaGetMin as Integer = LeptonicaSharp._All.numaGetMin(TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaGetMax as Integer = LeptonicaSharp._All.numaGetMax(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetMax",TestPix, RESnumaGetMax,{"Dim RESnumaGetMax as Integer = LeptonicaSharp._All.numaGetMax(TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaGetSum as Integer = LeptonicaSharp._All.numaGetSum(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetSum",TestPix, RESnumaGetSum,{"Dim RESnumaGetSum as Integer = LeptonicaSharp._All.numaGetSum(TestPix ,New Single)"},1)

' Dim RESnumaGetPartialSums as Numa = LeptonicaSharp._All.numaGetPartialSums(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetPartialSums",TestPix, RESnumaGetPartialSums,{"Dim RESnumaGetPartialSums as Numa = LeptonicaSharp._All.numaGetPartialSums(TestPix )"},1)

' Dim RESnumaGetSumOnInterval as Integer = LeptonicaSharp._All.numaGetSumOnInterval(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetSumOnInterval",TestPix, RESnumaGetSumOnInterval,{"Dim RESnumaGetSumOnInterval as Integer = LeptonicaSharp._All.numaGetSumOnInterval(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaHasOnlyIntegers as Integer = LeptonicaSharp._All.numaHasOnlyIntegers(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaHasOnlyIntegers",TestPix, RESnumaHasOnlyIntegers,{"Dim RESnumaHasOnlyIntegers as Integer = LeptonicaSharp._All.numaHasOnlyIntegers(TestPix ,TestPix ,New Integer)"},1)

' Dim RESnumaSubsample as Numa = LeptonicaSharp._All.numaSubsample(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSubsample",TestPix, RESnumaSubsample,{"Dim RESnumaSubsample as Numa = LeptonicaSharp._All.numaSubsample(TestPix ,TestPix )"},1)

' Dim RESnumaMakeDelta as Numa = LeptonicaSharp._All.numaMakeDelta(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeDelta",TestPix, RESnumaMakeDelta,{"Dim RESnumaMakeDelta as Numa = LeptonicaSharp._All.numaMakeDelta(TestPix )"},1)

' Dim RESnumaMakeSequence as Numa = LeptonicaSharp._All.numaMakeSequence(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeSequence",TestPix, RESnumaMakeSequence,{"Dim RESnumaMakeSequence as Numa = LeptonicaSharp._All.numaMakeSequence(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaMakeConstant as Numa = LeptonicaSharp._All.numaMakeConstant(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeConstant",TestPix, RESnumaMakeConstant,{"Dim RESnumaMakeConstant as Numa = LeptonicaSharp._All.numaMakeConstant(TestPix ,TestPix )"},1)

' Dim RESnumaMakeAbsValue as Numa = LeptonicaSharp._All.numaMakeAbsValue(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeAbsValue",TestPix, RESnumaMakeAbsValue,{"Dim RESnumaMakeAbsValue as Numa = LeptonicaSharp._All.numaMakeAbsValue(Nothing ,TestPix )"},1)

' Dim RESnumaAddBorder as Numa = LeptonicaSharp._All.numaAddBorder(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaAddBorder",TestPix, RESnumaAddBorder,{"Dim RESnumaAddBorder as Numa = LeptonicaSharp._All.numaAddBorder(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaAddSpecifiedBorder as Numa = LeptonicaSharp._All.numaAddSpecifiedBorder(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaAddSpecifiedBorder",TestPix, RESnumaAddSpecifiedBorder,{"Dim RESnumaAddSpecifiedBorder as Numa = LeptonicaSharp._All.numaAddSpecifiedBorder(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaRemoveBorder as Numa = LeptonicaSharp._All.numaRemoveBorder(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaRemoveBorder",TestPix, RESnumaRemoveBorder,{"Dim RESnumaRemoveBorder as Numa = LeptonicaSharp._All.numaRemoveBorder(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaCountNonzeroRuns as Integer = LeptonicaSharp._All.numaCountNonzeroRuns(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCountNonzeroRuns",TestPix, RESnumaCountNonzeroRuns,{"Dim RESnumaCountNonzeroRuns as Integer = LeptonicaSharp._All.numaCountNonzeroRuns(TestPix ,New Integer)"},1)

' Dim RESnumaGetNonzeroRange as Integer = LeptonicaSharp._All.numaGetNonzeroRange(TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetNonzeroRange",TestPix, RESnumaGetNonzeroRange,{"Dim RESnumaGetNonzeroRange as Integer = LeptonicaSharp._All.numaGetNonzeroRange(TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESnumaGetCountRelativeToZero as Integer = LeptonicaSharp._All.numaGetCountRelativeToZero(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetCountRelativeToZero",TestPix, RESnumaGetCountRelativeToZero,{"Dim RESnumaGetCountRelativeToZero as Integer = LeptonicaSharp._All.numaGetCountRelativeToZero(TestPix ,TestPix ,New Integer)"},1)

' Dim RESnumaClipToInterval as Numa = LeptonicaSharp._All.numaClipToInterval(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaClipToInterval",TestPix, RESnumaClipToInterval,{"Dim RESnumaClipToInterval as Numa = LeptonicaSharp._All.numaClipToInterval(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaMakeThresholdIndicator as Numa = LeptonicaSharp._All.numaMakeThresholdIndicator(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeThresholdIndicator",TestPix, RESnumaMakeThresholdIndicator,{"Dim RESnumaMakeThresholdIndicator as Numa = LeptonicaSharp._All.numaMakeThresholdIndicator(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaUniformSampling as Numa = LeptonicaSharp._All.numaUniformSampling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaUniformSampling",TestPix, RESnumaUniformSampling,{"Dim RESnumaUniformSampling as Numa = LeptonicaSharp._All.numaUniformSampling(TestPix ,TestPix )"},1)

' Dim RESnumaReverse as Numa = LeptonicaSharp._All.numaReverse(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaReverse",TestPix, RESnumaReverse,{"Dim RESnumaReverse as Numa = LeptonicaSharp._All.numaReverse(Nothing ,TestPix )"},1)

' Dim RESnumaLowPassIntervals as Numa = LeptonicaSharp._All.numaLowPassIntervals(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaLowPassIntervals",TestPix, RESnumaLowPassIntervals,{"Dim RESnumaLowPassIntervals as Numa = LeptonicaSharp._All.numaLowPassIntervals(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaThresholdEdges as Numa = LeptonicaSharp._All.numaThresholdEdges(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaThresholdEdges",TestPix, RESnumaThresholdEdges,{"Dim RESnumaThresholdEdges as Numa = LeptonicaSharp._All.numaThresholdEdges(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaGetSpanValues as Integer = LeptonicaSharp._All.numaGetSpanValues(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetSpanValues",TestPix, RESnumaGetSpanValues,{"Dim RESnumaGetSpanValues as Integer = LeptonicaSharp._All.numaGetSpanValues(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaGetEdgeValues as Integer = LeptonicaSharp._All.numaGetEdgeValues(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetEdgeValues",TestPix, RESnumaGetEdgeValues,{"Dim RESnumaGetEdgeValues as Integer = LeptonicaSharp._All.numaGetEdgeValues(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaInterpolateEqxVal as Integer = LeptonicaSharp._All.numaInterpolateEqxVal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInterpolateEqxVal",TestPix, RESnumaInterpolateEqxVal,{"Dim RESnumaInterpolateEqxVal as Integer = LeptonicaSharp._All.numaInterpolateEqxVal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaInterpolateArbxVal as Integer = LeptonicaSharp._All.numaInterpolateArbxVal(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInterpolateArbxVal",TestPix, RESnumaInterpolateArbxVal,{"Dim RESnumaInterpolateArbxVal as Integer = LeptonicaSharp._All.numaInterpolateArbxVal(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaInterpolateEqxInterval as Integer = LeptonicaSharp._All.numaInterpolateEqxInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInterpolateEqxInterval",TestPix, RESnumaInterpolateEqxInterval,{"Dim RESnumaInterpolateEqxInterval as Integer = LeptonicaSharp._All.numaInterpolateEqxInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)"},1)

' Dim RESnumaInterpolateArbxInterval as Integer = LeptonicaSharp._All.numaInterpolateArbxInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInterpolateArbxInterval",TestPix, RESnumaInterpolateArbxInterval,{"Dim RESnumaInterpolateArbxInterval as Integer = LeptonicaSharp._All.numaInterpolateArbxInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)"},1)

' Dim RESnumaFitMax as Integer = LeptonicaSharp._All.numaFitMax(TestPix ,New Single,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaFitMax",TestPix, RESnumaFitMax,{"Dim RESnumaFitMax as Integer = LeptonicaSharp._All.numaFitMax(TestPix ,New Single,Nothing ,New Single)"},1)

' Dim RESnumaDifferentiateInterval as Integer = LeptonicaSharp._All.numaDifferentiateInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaDifferentiateInterval",TestPix, RESnumaDifferentiateInterval,{"Dim RESnumaDifferentiateInterval as Integer = LeptonicaSharp._All.numaDifferentiateInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)"},1)

' Dim RESnumaIntegrateInterval as Integer = LeptonicaSharp._All.numaIntegrateInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaIntegrateInterval",TestPix, RESnumaIntegrateInterval,{"Dim RESnumaIntegrateInterval as Integer = LeptonicaSharp._All.numaIntegrateInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaSortGeneral as Integer = LeptonicaSharp._All.numaSortGeneral(TestPix ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSortGeneral",TestPix, RESnumaSortGeneral,{"Dim RESnumaSortGeneral as Integer = LeptonicaSharp._All.numaSortGeneral(TestPix ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESnumaSortAutoSelect as Numa = LeptonicaSharp._All.numaSortAutoSelect(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSortAutoSelect",TestPix, RESnumaSortAutoSelect,{"Dim RESnumaSortAutoSelect as Numa = LeptonicaSharp._All.numaSortAutoSelect(TestPix ,TestPix )"},1)

' Dim RESnumaSortIndexAutoSelect as Numa = LeptonicaSharp._All.numaSortIndexAutoSelect(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSortIndexAutoSelect",TestPix, RESnumaSortIndexAutoSelect,{"Dim RESnumaSortIndexAutoSelect as Numa = LeptonicaSharp._All.numaSortIndexAutoSelect(TestPix ,TestPix )"},1)

' Dim RESnumaChooseSortType as Integer = LeptonicaSharp._All.numaChooseSortType(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaChooseSortType",TestPix, RESnumaChooseSortType,{"Dim RESnumaChooseSortType as Integer = LeptonicaSharp._All.numaChooseSortType(TestPix )"},1)

' Dim RESnumaSort as Numa = LeptonicaSharp._All.numaSort(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSort",TestPix, RESnumaSort,{"Dim RESnumaSort as Numa = LeptonicaSharp._All.numaSort(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaBinSort as Numa = LeptonicaSharp._All.numaBinSort(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaBinSort",TestPix, RESnumaBinSort,{"Dim RESnumaBinSort as Numa = LeptonicaSharp._All.numaBinSort(TestPix ,TestPix )"},1)

' Dim RESnumaGetSortIndex as Numa = LeptonicaSharp._All.numaGetSortIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetSortIndex",TestPix, RESnumaGetSortIndex,{"Dim RESnumaGetSortIndex as Numa = LeptonicaSharp._All.numaGetSortIndex(TestPix ,TestPix )"},1)

' Dim RESnumaGetBinSortIndex as Numa = LeptonicaSharp._All.numaGetBinSortIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetBinSortIndex",TestPix, RESnumaGetBinSortIndex,{"Dim RESnumaGetBinSortIndex as Numa = LeptonicaSharp._All.numaGetBinSortIndex(TestPix ,TestPix )"},1)

' Dim RESnumaSortByIndex as Numa = LeptonicaSharp._All.numaSortByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSortByIndex",TestPix, RESnumaSortByIndex,{"Dim RESnumaSortByIndex as Numa = LeptonicaSharp._All.numaSortByIndex(TestPix ,TestPix )"},1)

' Dim RESnumaIsSorted as Integer = LeptonicaSharp._All.numaIsSorted(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaIsSorted",TestPix, RESnumaIsSorted,{"Dim RESnumaIsSorted as Integer = LeptonicaSharp._All.numaIsSorted(TestPix ,TestPix ,New Integer)"},1)

' Dim RESnumaSortPair as Integer = LeptonicaSharp._All.numaSortPair(TestPix ,TestPix ,TestPix ,New Numa,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSortPair",TestPix, RESnumaSortPair,{"Dim RESnumaSortPair as Integer = LeptonicaSharp._All.numaSortPair(TestPix ,TestPix ,TestPix ,New Numa,New Numa)"},1)

' Dim RESnumaInvertMap as Numa = LeptonicaSharp._All.numaInvertMap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaInvertMap",TestPix, RESnumaInvertMap,{"Dim RESnumaInvertMap as Numa = LeptonicaSharp._All.numaInvertMap(TestPix )"},1)

' Dim RESnumaPseudorandomSequence as Numa = LeptonicaSharp._All.numaPseudorandomSequence(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaPseudorandomSequence",TestPix, RESnumaPseudorandomSequence,{"Dim RESnumaPseudorandomSequence as Numa = LeptonicaSharp._All.numaPseudorandomSequence(TestPix ,TestPix )"},1)

' Dim RESnumaRandomPermutation as Numa = LeptonicaSharp._All.numaRandomPermutation(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaRandomPermutation",TestPix, RESnumaRandomPermutation,{"Dim RESnumaRandomPermutation as Numa = LeptonicaSharp._All.numaRandomPermutation(TestPix ,TestPix )"},1)

' Dim RESnumaGetRankValue as Integer = LeptonicaSharp._All.numaGetRankValue(TestPix ,TestPix ,Nothing ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetRankValue",TestPix, RESnumaGetRankValue,{"Dim RESnumaGetRankValue as Integer = LeptonicaSharp._All.numaGetRankValue(TestPix ,TestPix ,Nothing ,TestPix ,New Single)"},1)

' Dim RESnumaGetMedian as Integer = LeptonicaSharp._All.numaGetMedian(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetMedian",TestPix, RESnumaGetMedian,{"Dim RESnumaGetMedian as Integer = LeptonicaSharp._All.numaGetMedian(TestPix ,New Single)"},1)

' Dim RESnumaGetBinnedMedian as Integer = LeptonicaSharp._All.numaGetBinnedMedian(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetBinnedMedian",TestPix, RESnumaGetBinnedMedian,{"Dim RESnumaGetBinnedMedian as Integer = LeptonicaSharp._All.numaGetBinnedMedian(TestPix ,New Integer)"},1)

' Dim RESnumaGetMode as Integer = LeptonicaSharp._All.numaGetMode(TestPix ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetMode",TestPix, RESnumaGetMode,{"Dim RESnumaGetMode as Integer = LeptonicaSharp._All.numaGetMode(TestPix ,New Single,Nothing )"},1)

' Dim RESnumaGetMedianVariation as Integer = LeptonicaSharp._All.numaGetMedianVariation(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetMedianVariation",TestPix, RESnumaGetMedianVariation,{"Dim RESnumaGetMedianVariation as Integer = LeptonicaSharp._All.numaGetMedianVariation(TestPix ,Nothing ,New Single)"},1)

' Dim RESnumaJoin as Integer = LeptonicaSharp._All.numaJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaJoin",TestPix, RESnumaJoin,{"Dim RESnumaJoin as Integer = LeptonicaSharp._All.numaJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESnumaaJoin as Integer = LeptonicaSharp._All.numaaJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaJoin",TestPix, RESnumaaJoin,{"Dim RESnumaaJoin as Integer = LeptonicaSharp._All.numaaJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESnumaaFlattenToNuma as Numa = LeptonicaSharp._All.numaaFlattenToNuma(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaaFlattenToNuma",TestPix, RESnumaaFlattenToNuma,{"Dim RESnumaaFlattenToNuma as Numa = LeptonicaSharp._All.numaaFlattenToNuma(TestPix )"},1)

' Dim RESnumaErode as Numa = LeptonicaSharp._All.numaErode(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaErode",TestPix, RESnumaErode,{"Dim RESnumaErode as Numa = LeptonicaSharp._All.numaErode(TestPix ,TestPix )"},1)

' Dim RESnumaDilate as Numa = LeptonicaSharp._All.numaDilate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaDilate",TestPix, RESnumaDilate,{"Dim RESnumaDilate as Numa = LeptonicaSharp._All.numaDilate(TestPix ,TestPix )"},1)

' Dim RESnumaOpen as Numa = LeptonicaSharp._All.numaOpen(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaOpen",TestPix, RESnumaOpen,{"Dim RESnumaOpen as Numa = LeptonicaSharp._All.numaOpen(TestPix ,TestPix )"},1)

' Dim RESnumaClose as Numa = LeptonicaSharp._All.numaClose(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaClose",TestPix, RESnumaClose,{"Dim RESnumaClose as Numa = LeptonicaSharp._All.numaClose(TestPix ,TestPix )"},1)

' Dim RESnumaTransform as Numa = LeptonicaSharp._All.numaTransform(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaTransform",TestPix, RESnumaTransform,{"Dim RESnumaTransform as Numa = LeptonicaSharp._All.numaTransform(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaSimpleStats as Integer = LeptonicaSharp._All.numaSimpleStats(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSimpleStats",TestPix, RESnumaSimpleStats,{"Dim RESnumaSimpleStats as Integer = LeptonicaSharp._All.numaSimpleStats(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaWindowedStats as Integer = LeptonicaSharp._All.numaWindowedStats(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWindowedStats",TestPix, RESnumaWindowedStats,{"Dim RESnumaWindowedStats as Integer = LeptonicaSharp._All.numaWindowedStats(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaWindowedMean as Numa = LeptonicaSharp._All.numaWindowedMean(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWindowedMean",TestPix, RESnumaWindowedMean,{"Dim RESnumaWindowedMean as Numa = LeptonicaSharp._All.numaWindowedMean(TestPix ,TestPix )"},1)

' Dim RESnumaWindowedMeanSquare as Numa = LeptonicaSharp._All.numaWindowedMeanSquare(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWindowedMeanSquare",TestPix, RESnumaWindowedMeanSquare,{"Dim RESnumaWindowedMeanSquare as Numa = LeptonicaSharp._All.numaWindowedMeanSquare(TestPix ,TestPix )"},1)

' Dim RESnumaWindowedVariance as Integer = LeptonicaSharp._All.numaWindowedVariance(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWindowedVariance",TestPix, RESnumaWindowedVariance,{"Dim RESnumaWindowedVariance as Integer = LeptonicaSharp._All.numaWindowedVariance(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaWindowedMedian as Numa = LeptonicaSharp._All.numaWindowedMedian(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaWindowedMedian",TestPix, RESnumaWindowedMedian,{"Dim RESnumaWindowedMedian as Numa = LeptonicaSharp._All.numaWindowedMedian(TestPix ,TestPix )"},1)

' Dim RESnumaConvertToInt as Numa = LeptonicaSharp._All.numaConvertToInt(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaConvertToInt",TestPix, RESnumaConvertToInt,{"Dim RESnumaConvertToInt as Numa = LeptonicaSharp._All.numaConvertToInt(TestPix )"},1)

' Dim RESnumaMakeHistogram as Numa = LeptonicaSharp._All.numaMakeHistogram(TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeHistogram",TestPix, RESnumaMakeHistogram,{"Dim RESnumaMakeHistogram as Numa = LeptonicaSharp._All.numaMakeHistogram(TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESnumaMakeHistogramAuto as Numa = LeptonicaSharp._All.numaMakeHistogramAuto(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeHistogramAuto",TestPix, RESnumaMakeHistogramAuto,{"Dim RESnumaMakeHistogramAuto as Numa = LeptonicaSharp._All.numaMakeHistogramAuto(TestPix ,TestPix )"},1)

' Dim RESnumaMakeHistogramClipped as Numa = LeptonicaSharp._All.numaMakeHistogramClipped(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeHistogramClipped",TestPix, RESnumaMakeHistogramClipped,{"Dim RESnumaMakeHistogramClipped as Numa = LeptonicaSharp._All.numaMakeHistogramClipped(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaRebinHistogram as Numa = LeptonicaSharp._All.numaRebinHistogram(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaRebinHistogram",TestPix, RESnumaRebinHistogram,{"Dim RESnumaRebinHistogram as Numa = LeptonicaSharp._All.numaRebinHistogram(TestPix ,TestPix )"},1)

' Dim RESnumaNormalizeHistogram as Numa = LeptonicaSharp._All.numaNormalizeHistogram(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaNormalizeHistogram",TestPix, RESnumaNormalizeHistogram,{"Dim RESnumaNormalizeHistogram as Numa = LeptonicaSharp._All.numaNormalizeHistogram(TestPix ,TestPix )"},1)

' Dim RESnumaGetStatsUsingHistogram as Integer = LeptonicaSharp._All.numaGetStatsUsingHistogram(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetStatsUsingHistogram",TestPix, RESnumaGetStatsUsingHistogram,{"Dim RESnumaGetStatsUsingHistogram as Integer = LeptonicaSharp._All.numaGetStatsUsingHistogram(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaGetHistogramStats as Integer = LeptonicaSharp._All.numaGetHistogramStats(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetHistogramStats",TestPix, RESnumaGetHistogramStats,{"Dim RESnumaGetHistogramStats as Integer = LeptonicaSharp._All.numaGetHistogramStats(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaGetHistogramStatsOnInterval as Integer = LeptonicaSharp._All.numaGetHistogramStatsOnInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetHistogramStatsOnInterval",TestPix, RESnumaGetHistogramStatsOnInterval,{"Dim RESnumaGetHistogramStatsOnInterval as Integer = LeptonicaSharp._All.numaGetHistogramStatsOnInterval(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaMakeRankFromHistogram as Integer = LeptonicaSharp._All.numaMakeRankFromHistogram(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaMakeRankFromHistogram",TestPix, RESnumaMakeRankFromHistogram,{"Dim RESnumaMakeRankFromHistogram as Integer = LeptonicaSharp._All.numaMakeRankFromHistogram(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Numa)"},1)

' Dim RESnumaHistogramGetRankFromVal as Integer = LeptonicaSharp._All.numaHistogramGetRankFromVal(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaHistogramGetRankFromVal",TestPix, RESnumaHistogramGetRankFromVal,{"Dim RESnumaHistogramGetRankFromVal as Integer = LeptonicaSharp._All.numaHistogramGetRankFromVal(TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaHistogramGetValFromRank as Integer = LeptonicaSharp._All.numaHistogramGetValFromRank(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaHistogramGetValFromRank",TestPix, RESnumaHistogramGetValFromRank,{"Dim RESnumaHistogramGetValFromRank as Integer = LeptonicaSharp._All.numaHistogramGetValFromRank(TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaDiscretizeRankAndIntensity as Integer = LeptonicaSharp._All.numaDiscretizeRankAndIntensity(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaDiscretizeRankAndIntensity",TestPix, RESnumaDiscretizeRankAndIntensity,{"Dim RESnumaDiscretizeRankAndIntensity as Integer = LeptonicaSharp._All.numaDiscretizeRankAndIntensity(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaGetRankBinValues as Integer = LeptonicaSharp._All.numaGetRankBinValues(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaGetRankBinValues",TestPix, RESnumaGetRankBinValues,{"Dim RESnumaGetRankBinValues as Integer = LeptonicaSharp._All.numaGetRankBinValues(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaSplitDistribution as Integer = LeptonicaSharp._All.numaSplitDistribution(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSplitDistribution",TestPix, RESnumaSplitDistribution,{"Dim RESnumaSplitDistribution as Integer = LeptonicaSharp._All.numaSplitDistribution(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESgrayHistogramsToEMD as Integer = LeptonicaSharp._All.grayHistogramsToEMD(TestPix ,TestPix ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("grayHistogramsToEMD",TestPix, RESgrayHistogramsToEMD,{"Dim RESgrayHistogramsToEMD as Integer = LeptonicaSharp._All.grayHistogramsToEMD(TestPix ,TestPix ,New Numa)"},1)

' Dim RESnumaEarthMoverDistance as Integer = LeptonicaSharp._All.numaEarthMoverDistance(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaEarthMoverDistance",TestPix, RESnumaEarthMoverDistance,{"Dim RESnumaEarthMoverDistance as Integer = LeptonicaSharp._All.numaEarthMoverDistance(TestPix ,TestPix ,New Single)"},1)

' Dim RESgrayInterHistogramStats as Integer = LeptonicaSharp._All.grayInterHistogramStats(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("grayInterHistogramStats",TestPix, RESgrayInterHistogramStats,{"Dim RESgrayInterHistogramStats as Integer = LeptonicaSharp._All.grayInterHistogramStats(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESnumaFindPeaks as Numa = LeptonicaSharp._All.numaFindPeaks(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaFindPeaks",TestPix, RESnumaFindPeaks,{"Dim RESnumaFindPeaks as Numa = LeptonicaSharp._All.numaFindPeaks(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaFindExtrema as Numa = LeptonicaSharp._All.numaFindExtrema(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaFindExtrema",TestPix, RESnumaFindExtrema,{"Dim RESnumaFindExtrema as Numa = LeptonicaSharp._All.numaFindExtrema(TestPix ,TestPix ,Nothing )"},1)

' Dim RESnumaCountReversals as Integer = LeptonicaSharp._All.numaCountReversals(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCountReversals",TestPix, RESnumaCountReversals,{"Dim RESnumaCountReversals as Integer = LeptonicaSharp._All.numaCountReversals(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESnumaSelectCrossingThreshold as Integer = LeptonicaSharp._All.numaSelectCrossingThreshold(Nothing ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaSelectCrossingThreshold",TestPix, RESnumaSelectCrossingThreshold,{"Dim RESnumaSelectCrossingThreshold as Integer = LeptonicaSharp._All.numaSelectCrossingThreshold(Nothing ,TestPix ,TestPix ,New Single)"},1)

' Dim RESnumaCrossingsByThreshold as Numa = LeptonicaSharp._All.numaCrossingsByThreshold(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCrossingsByThreshold",TestPix, RESnumaCrossingsByThreshold,{"Dim RESnumaCrossingsByThreshold as Numa = LeptonicaSharp._All.numaCrossingsByThreshold(Nothing ,TestPix ,TestPix )"},1)

' Dim RESnumaCrossingsByPeaks as Numa = LeptonicaSharp._All.numaCrossingsByPeaks(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaCrossingsByPeaks",TestPix, RESnumaCrossingsByPeaks,{"Dim RESnumaCrossingsByPeaks as Numa = LeptonicaSharp._All.numaCrossingsByPeaks(Nothing ,TestPix ,TestPix )"},1)

' Dim RESnumaEvalBestHaarParameters as Integer = LeptonicaSharp._All.numaEvalBestHaarParameters(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaEvalBestHaarParameters",TestPix, RESnumaEvalBestHaarParameters,{"Dim RESnumaEvalBestHaarParameters as Integer = LeptonicaSharp._All.numaEvalBestHaarParameters(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,Nothing )"},1)

' Dim RESnumaEvalHaarSum as Integer = LeptonicaSharp._All.numaEvalHaarSum(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("numaEvalHaarSum",TestPix, RESnumaEvalHaarSum,{"Dim RESnumaEvalHaarSum as Integer = LeptonicaSharp._All.numaEvalHaarSum(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESgenConstrainedNumaInRange as Numa = LeptonicaSharp._All.genConstrainedNumaInRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("genConstrainedNumaInRange",TestPix, RESgenConstrainedNumaInRange,{"Dim RESgenConstrainedNumaInRange as Numa = LeptonicaSharp._All.genConstrainedNumaInRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRegionsBinary as Integer = LeptonicaSharp._All.pixGetRegionsBinary(TestPix ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRegionsBinary",TestPix, RESpixGetRegionsBinary,{"Dim RESpixGetRegionsBinary as Integer = LeptonicaSharp._All.pixGetRegionsBinary(TestPix ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixGenHalftoneMask as Pix = LeptonicaSharp._All.pixGenHalftoneMask(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenHalftoneMask",TestPix, RESpixGenHalftoneMask,{"Dim RESpixGenHalftoneMask as Pix = LeptonicaSharp._All.pixGenHalftoneMask(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGenerateHalftoneMask as Pix = LeptonicaSharp._All.pixGenerateHalftoneMask(TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateHalftoneMask",TestPix, RESpixGenerateHalftoneMask,{"Dim RESpixGenerateHalftoneMask as Pix = LeptonicaSharp._All.pixGenerateHalftoneMask(TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixGenTextlineMask as Pix = LeptonicaSharp._All.pixGenTextlineMask(TestPix ,New Pix,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenTextlineMask",TestPix, RESpixGenTextlineMask,{"Dim RESpixGenTextlineMask as Pix = LeptonicaSharp._All.pixGenTextlineMask(TestPix ,New Pix,Nothing ,TestPix )"},1)

' Dim RESpixGenTextblockMask as Pix = LeptonicaSharp._All.pixGenTextblockMask(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenTextblockMask",TestPix, RESpixGenTextblockMask,{"Dim RESpixGenTextblockMask as Pix = LeptonicaSharp._All.pixGenTextblockMask(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindPageForeground as Box = LeptonicaSharp._All.pixFindPageForeground(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindPageForeground",TestPix, RESpixFindPageForeground,{"Dim RESpixFindPageForeground as Box = LeptonicaSharp._All.pixFindPageForeground(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSplitIntoCharacters as Integer = LeptonicaSharp._All.pixSplitIntoCharacters(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSplitIntoCharacters",TestPix, RESpixSplitIntoCharacters,{"Dim RESpixSplitIntoCharacters as Integer = LeptonicaSharp._All.pixSplitIntoCharacters(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixSplitComponentWithProfile as Boxa = LeptonicaSharp._All.pixSplitComponentWithProfile(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSplitComponentWithProfile",TestPix, RESpixSplitComponentWithProfile,{"Dim RESpixSplitComponentWithProfile as Boxa = LeptonicaSharp._All.pixSplitComponentWithProfile(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixExtractTextlines as Pixa = LeptonicaSharp._All.pixExtractTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractTextlines",TestPix, RESpixExtractTextlines,{"Dim RESpixExtractTextlines as Pixa = LeptonicaSharp._All.pixExtractTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixExtractRawTextlines as Pixa = LeptonicaSharp._All.pixExtractRawTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractRawTextlines",TestPix, RESpixExtractRawTextlines,{"Dim RESpixExtractRawTextlines as Pixa = LeptonicaSharp._All.pixExtractRawTextlines(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCountTextColumns as Integer = LeptonicaSharp._All.pixCountTextColumns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountTextColumns",TestPix, RESpixCountTextColumns,{"Dim RESpixCountTextColumns as Integer = LeptonicaSharp._All.pixCountTextColumns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESpixDecideIfText as Integer = LeptonicaSharp._All.pixDecideIfText(TestPix ,Nothing ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDecideIfText",TestPix, RESpixDecideIfText,{"Dim RESpixDecideIfText as Integer = LeptonicaSharp._All.pixDecideIfText(TestPix ,Nothing ,New Integer,Nothing )"},1)

' Dim RESpixFindThreshFgExtent as Integer = LeptonicaSharp._All.pixFindThreshFgExtent(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindThreshFgExtent",TestPix, RESpixFindThreshFgExtent,{"Dim RESpixFindThreshFgExtent as Integer = LeptonicaSharp._All.pixFindThreshFgExtent(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixDecideIfTable as Integer = LeptonicaSharp._All.pixDecideIfTable(TestPix ,Nothing ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDecideIfTable",TestPix, RESpixDecideIfTable,{"Dim RESpixDecideIfTable as Integer = LeptonicaSharp._All.pixDecideIfTable(TestPix ,Nothing ,TestPix ,New Integer,Nothing )"},1)

' Dim RESpixPrepare1bpp as Pix = LeptonicaSharp._All.pixPrepare1bpp(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPrepare1bpp",TestPix, RESpixPrepare1bpp,{"Dim RESpixPrepare1bpp as Pix = LeptonicaSharp._All.pixPrepare1bpp(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixEstimateBackground as Integer = LeptonicaSharp._All.pixEstimateBackground(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEstimateBackground",TestPix, RESpixEstimateBackground,{"Dim RESpixEstimateBackground as Integer = LeptonicaSharp._All.pixEstimateBackground(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixFindLargeRectangles as Integer = LeptonicaSharp._All.pixFindLargeRectangles(TestPix ,TestPix ,TestPix ,New Boxa,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindLargeRectangles",TestPix, RESpixFindLargeRectangles,{"Dim RESpixFindLargeRectangles as Integer = LeptonicaSharp._All.pixFindLargeRectangles(TestPix ,TestPix ,TestPix ,New Boxa,TestPix )"},1)

' Dim RESpixFindLargestRectangle as Integer = LeptonicaSharp._All.pixFindLargestRectangle(TestPix ,TestPix ,New Box,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindLargestRectangle",TestPix, RESpixFindLargestRectangle,{"Dim RESpixFindLargestRectangle as Integer = LeptonicaSharp._All.pixFindLargestRectangle(TestPix ,TestPix ,New Box,TestPix )"},1)

' Dim RESpixSetSelectCmap as Integer = LeptonicaSharp._All.pixSetSelectCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetSelectCmap",TestPix, RESpixSetSelectCmap,{"Dim RESpixSetSelectCmap as Integer = LeptonicaSharp._All.pixSetSelectCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorGrayRegionsCmap as Integer = LeptonicaSharp._All.pixColorGrayRegionsCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGrayRegionsCmap",TestPix, RESpixColorGrayRegionsCmap,{"Dim RESpixColorGrayRegionsCmap as Integer = LeptonicaSharp._All.pixColorGrayRegionsCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorGrayCmap as Integer = LeptonicaSharp._All.pixColorGrayCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGrayCmap",TestPix, RESpixColorGrayCmap,{"Dim RESpixColorGrayCmap as Integer = LeptonicaSharp._All.pixColorGrayCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixColorGrayMaskedCmap as Integer = LeptonicaSharp._All.pixColorGrayMaskedCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorGrayMaskedCmap",TestPix, RESpixColorGrayMaskedCmap,{"Dim RESpixColorGrayMaskedCmap as Integer = LeptonicaSharp._All.pixColorGrayMaskedCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESaddColorizedGrayToCmap as Integer = LeptonicaSharp._All.addColorizedGrayToCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("addColorizedGrayToCmap",TestPix, RESaddColorizedGrayToCmap,{"Dim RESaddColorizedGrayToCmap as Integer = LeptonicaSharp._All.addColorizedGrayToCmap(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSetSelectMaskedCmap as Integer = LeptonicaSharp._All.pixSetSelectMaskedCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetSelectMaskedCmap",TestPix, RESpixSetSelectMaskedCmap,{"Dim RESpixSetSelectMaskedCmap as Integer = LeptonicaSharp._All.pixSetSelectMaskedCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetMaskedCmap as Integer = LeptonicaSharp._All.pixSetMaskedCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetMaskedCmap",TestPix, RESpixSetMaskedCmap,{"Dim RESpixSetMaskedCmap as Integer = LeptonicaSharp._All.pixSetMaskedCmap(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESparseForProtos as String = LeptonicaSharp._All.parseForProtos(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("parseForProtos",TestPix, RESparseForProtos,{"Dim RESparseForProtos as String = LeptonicaSharp._All.parseForProtos(TestPix ,TestPix )"},1)

' Dim RESboxaGetWhiteblocks as Boxa = LeptonicaSharp._All.boxaGetWhiteblocks(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaGetWhiteblocks",TestPix, RESboxaGetWhiteblocks,{"Dim RESboxaGetWhiteblocks as Boxa = LeptonicaSharp._All.boxaGetWhiteblocks(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESboxaPruneSortedOnOverlap as Boxa = LeptonicaSharp._All.boxaPruneSortedOnOverlap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaPruneSortedOnOverlap",TestPix, RESboxaPruneSortedOnOverlap,{"Dim RESboxaPruneSortedOnOverlap as Boxa = LeptonicaSharp._All.boxaPruneSortedOnOverlap(TestPix ,TestPix )"},1)

' Dim RESconvertFilesToPdf as Integer = LeptonicaSharp._All.convertFilesToPdf(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFilesToPdf",TestPix, RESconvertFilesToPdf,{"Dim RESconvertFilesToPdf as Integer = LeptonicaSharp._All.convertFilesToPdf(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESsaConvertFilesToPdf as Integer = LeptonicaSharp._All.saConvertFilesToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("saConvertFilesToPdf",TestPix, RESsaConvertFilesToPdf,{"Dim RESsaConvertFilesToPdf as Integer = LeptonicaSharp._All.saConvertFilesToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESsaConvertFilesToPdfData as Integer = LeptonicaSharp._All.saConvertFilesToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("saConvertFilesToPdfData",TestPix, RESsaConvertFilesToPdfData,{"Dim RESsaConvertFilesToPdfData as Integer = LeptonicaSharp._All.saConvertFilesToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESselectDefaultPdfEncoding as Integer = LeptonicaSharp._All.selectDefaultPdfEncoding(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("selectDefaultPdfEncoding",TestPix, RESselectDefaultPdfEncoding,{"Dim RESselectDefaultPdfEncoding as Integer = LeptonicaSharp._All.selectDefaultPdfEncoding(TestPix ,New Integer)"},1)

' Dim RESconvertUnscaledFilesToPdf as Integer = LeptonicaSharp._All.convertUnscaledFilesToPdf(TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertUnscaledFilesToPdf",TestPix, RESconvertUnscaledFilesToPdf,{"Dim RESconvertUnscaledFilesToPdf as Integer = LeptonicaSharp._All.convertUnscaledFilesToPdf(TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESsaConvertUnscaledFilesToPdf as Integer = LeptonicaSharp._All.saConvertUnscaledFilesToPdf(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("saConvertUnscaledFilesToPdf",TestPix, RESsaConvertUnscaledFilesToPdf,{"Dim RESsaConvertUnscaledFilesToPdf as Integer = LeptonicaSharp._All.saConvertUnscaledFilesToPdf(TestPix ,Nothing ,TestPix )"},1)

' Dim RESsaConvertUnscaledFilesToPdfData as Integer = LeptonicaSharp._All.saConvertUnscaledFilesToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("saConvertUnscaledFilesToPdfData",TestPix, RESsaConvertUnscaledFilesToPdfData,{"Dim RESsaConvertUnscaledFilesToPdfData as Integer = LeptonicaSharp._All.saConvertUnscaledFilesToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESconvertUnscaledToPdfData as Integer = LeptonicaSharp._All.convertUnscaledToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertUnscaledToPdfData",TestPix, RESconvertUnscaledToPdfData,{"Dim RESconvertUnscaledToPdfData as Integer = LeptonicaSharp._All.convertUnscaledToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESpixaConvertToPdf as Integer = LeptonicaSharp._All.pixaConvertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertToPdf",TestPix, RESpixaConvertToPdf,{"Dim RESpixaConvertToPdf as Integer = LeptonicaSharp._All.pixaConvertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixaConvertToPdfData as Integer = LeptonicaSharp._All.pixaConvertToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertToPdfData",TestPix, RESpixaConvertToPdfData,{"Dim RESpixaConvertToPdfData as Integer = LeptonicaSharp._All.pixaConvertToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESconvertToPdf as Integer = LeptonicaSharp._All.convertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToPdf",TestPix, RESconvertToPdf,{"Dim RESconvertToPdf as Integer = LeptonicaSharp._All.convertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESconvertImageDataToPdf as Integer = LeptonicaSharp._All.convertImageDataToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertImageDataToPdf",TestPix, RESconvertImageDataToPdf,{"Dim RESconvertImageDataToPdf as Integer = LeptonicaSharp._All.convertImageDataToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESconvertToPdfData as Integer = LeptonicaSharp._All.convertToPdfData(TestPix ,TestPix ,Nothing ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToPdfData",TestPix, RESconvertToPdfData,{"Dim RESconvertToPdfData as Integer = LeptonicaSharp._All.convertToPdfData(TestPix ,TestPix ,Nothing ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESconvertImageDataToPdfData as Integer = LeptonicaSharp._All.convertImageDataToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),New UInteger,TestPix ,TestPix ,TestPix ,Nothing ,New L_Pdf_Data,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertImageDataToPdfData",TestPix, RESconvertImageDataToPdfData,{"Dim RESconvertImageDataToPdfData as Integer = LeptonicaSharp._All.convertImageDataToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),New UInteger,TestPix ,TestPix ,TestPix ,Nothing ,New L_Pdf_Data,TestPix )"},1)

' Dim RESpixConvertToPdf as Integer = LeptonicaSharp._All.pixConvertToPdf(TestPix ,TestPix ,Nothing ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToPdf",TestPix, RESpixConvertToPdf,{"Dim RESpixConvertToPdf as Integer = LeptonicaSharp._All.pixConvertToPdf(TestPix ,TestPix ,Nothing ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamPdf as Integer = LeptonicaSharp._All.pixWriteStreamPdf(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamPdf",TestPix, RESpixWriteStreamPdf,{"Dim RESpixWriteStreamPdf as Integer = LeptonicaSharp._All.pixWriteStreamPdf(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixWriteMemPdf as Integer = LeptonicaSharp._All.pixWriteMemPdf(New Byte(),New UInteger,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemPdf",TestPix, RESpixWriteMemPdf,{"Dim RESpixWriteMemPdf as Integer = LeptonicaSharp._All.pixWriteMemPdf(New Byte(),New UInteger,TestPix ,TestPix ,Nothing )"},1)

' Dim RESconvertSegmentedFilesToPdf as Integer = LeptonicaSharp._All.convertSegmentedFilesToPdf(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertSegmentedFilesToPdf",TestPix, RESconvertSegmentedFilesToPdf,{"Dim RESconvertSegmentedFilesToPdf as Integer = LeptonicaSharp._All.convertSegmentedFilesToPdf(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESconvertNumberedMasksToBoxaa as Boxaa = LeptonicaSharp._All.convertNumberedMasksToBoxaa(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertNumberedMasksToBoxaa",TestPix, RESconvertNumberedMasksToBoxaa,{"Dim RESconvertNumberedMasksToBoxaa as Boxaa = LeptonicaSharp._All.convertNumberedMasksToBoxaa(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESconvertToPdfSegmented as Integer = LeptonicaSharp._All.convertToPdfSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToPdfSegmented",TestPix, RESconvertToPdfSegmented,{"Dim RESconvertToPdfSegmented as Integer = LeptonicaSharp._All.convertToPdfSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixConvertToPdfSegmented as Integer = LeptonicaSharp._All.pixConvertToPdfSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToPdfSegmented",TestPix, RESpixConvertToPdfSegmented,{"Dim RESpixConvertToPdfSegmented as Integer = LeptonicaSharp._All.pixConvertToPdfSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESconvertToPdfDataSegmented as Integer = LeptonicaSharp._All.convertToPdfDataSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToPdfDataSegmented",TestPix, RESconvertToPdfDataSegmented,{"Dim RESconvertToPdfDataSegmented as Integer = LeptonicaSharp._All.convertToPdfDataSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESpixConvertToPdfDataSegmented as Integer = LeptonicaSharp._All.pixConvertToPdfDataSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToPdfDataSegmented",TestPix, RESpixConvertToPdfDataSegmented,{"Dim RESpixConvertToPdfDataSegmented as Integer = LeptonicaSharp._All.pixConvertToPdfDataSegmented(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESconcatenatePdf as Integer = LeptonicaSharp._All.concatenatePdf(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("concatenatePdf",TestPix, RESconcatenatePdf,{"Dim RESconcatenatePdf as Integer = LeptonicaSharp._All.concatenatePdf(TestPix ,Nothing ,TestPix )"},1)

' Dim RESsaConcatenatePdf as Integer = LeptonicaSharp._All.saConcatenatePdf(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("saConcatenatePdf",TestPix, RESsaConcatenatePdf,{"Dim RESsaConcatenatePdf as Integer = LeptonicaSharp._All.saConcatenatePdf(TestPix ,TestPix )"},1)

' Dim RESptraConcatenatePdf as Integer = LeptonicaSharp._All.ptraConcatenatePdf(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraConcatenatePdf",TestPix, RESptraConcatenatePdf,{"Dim RESptraConcatenatePdf as Integer = LeptonicaSharp._All.ptraConcatenatePdf(TestPix ,TestPix )"},1)

' Dim RESconcatenatePdfToData as Integer = LeptonicaSharp._All.concatenatePdfToData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("concatenatePdfToData",TestPix, RESconcatenatePdfToData,{"Dim RESconcatenatePdfToData as Integer = LeptonicaSharp._All.concatenatePdfToData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESsaConcatenatePdfToData as Integer = LeptonicaSharp._All.saConcatenatePdfToData(TestPix ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("saConcatenatePdfToData",TestPix, RESsaConcatenatePdfToData,{"Dim RESsaConcatenatePdfToData as Integer = LeptonicaSharp._All.saConcatenatePdfToData(TestPix ,New Byte(),New UInteger)"},1)

' Dim RESpixConvertToPdfData as Integer = LeptonicaSharp._All.pixConvertToPdfData(TestPix ,TestPix ,Nothing ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToPdfData",TestPix, RESpixConvertToPdfData,{"Dim RESpixConvertToPdfData as Integer = LeptonicaSharp._All.pixConvertToPdfData(TestPix ,TestPix ,Nothing ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESptraConcatenatePdfToData as Integer = LeptonicaSharp._All.ptraConcatenatePdfToData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraConcatenatePdfToData",TestPix, RESptraConcatenatePdfToData,{"Dim RESptraConcatenatePdfToData as Integer = LeptonicaSharp._All.ptraConcatenatePdfToData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESconvertTiffMultipageToPdf as Integer = LeptonicaSharp._All.convertTiffMultipageToPdf(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertTiffMultipageToPdf",TestPix, RESconvertTiffMultipageToPdf,{"Dim RESconvertTiffMultipageToPdf as Integer = LeptonicaSharp._All.convertTiffMultipageToPdf(TestPix ,TestPix )"},1)

' Dim RESl_generateCIDataForPdf as Integer = LeptonicaSharp._All.l_generateCIDataForPdf(Nothing ,Nothing ,TestPix ,New L_Compressed_Data)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateCIDataForPdf",TestPix, RESl_generateCIDataForPdf,{"Dim RESl_generateCIDataForPdf as Integer = LeptonicaSharp._All.l_generateCIDataForPdf(Nothing ,Nothing ,TestPix ,New L_Compressed_Data)"},1)

' Dim RESl_generateFlateDataPdf as L_Compressed_Data = LeptonicaSharp._All.l_generateFlateDataPdf(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateFlateDataPdf",TestPix, RESl_generateFlateDataPdf,{"Dim RESl_generateFlateDataPdf as L_Compressed_Data = LeptonicaSharp._All.l_generateFlateDataPdf(TestPix ,Nothing )"},1)

' Dim RESl_generateJpegData as L_Compressed_Data = LeptonicaSharp._All.l_generateJpegData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateJpegData",TestPix, RESl_generateJpegData,{"Dim RESl_generateJpegData as L_Compressed_Data = LeptonicaSharp._All.l_generateJpegData(TestPix ,TestPix )"},1)

' Dim RESl_generateJpegDataMem as L_Compressed_Data = LeptonicaSharp._All.l_generateJpegDataMem(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateJpegDataMem",TestPix, RESl_generateJpegDataMem,{"Dim RESl_generateJpegDataMem as L_Compressed_Data = LeptonicaSharp._All.l_generateJpegDataMem(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_generateCIData as Integer = LeptonicaSharp._All.l_generateCIData(TestPix ,TestPix ,TestPix ,TestPix ,New L_Compressed_Data)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateCIData",TestPix, RESl_generateCIData,{"Dim RESl_generateCIData as Integer = LeptonicaSharp._All.l_generateCIData(TestPix ,TestPix ,TestPix ,TestPix ,New L_Compressed_Data)"},1)

' Dim RESpixGenerateCIData as Integer = LeptonicaSharp._All.pixGenerateCIData(TestPix ,TestPix ,TestPix ,TestPix ,New L_Compressed_Data)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateCIData",TestPix, RESpixGenerateCIData,{"Dim RESpixGenerateCIData as Integer = LeptonicaSharp._All.pixGenerateCIData(TestPix ,TestPix ,TestPix ,TestPix ,New L_Compressed_Data)"},1)

' Dim RESl_generateFlateData as L_Compressed_Data = LeptonicaSharp._All.l_generateFlateData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateFlateData",TestPix, RESl_generateFlateData,{"Dim RESl_generateFlateData as L_Compressed_Data = LeptonicaSharp._All.l_generateFlateData(TestPix ,TestPix )"},1)

' Dim RESl_generateG4Data as L_Compressed_Data = LeptonicaSharp._All.l_generateG4Data(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_generateG4Data",TestPix, RESl_generateG4Data,{"Dim RESl_generateG4Data as L_Compressed_Data = LeptonicaSharp._All.l_generateG4Data(TestPix ,TestPix )"},1)

' Dim REScidConvertToPdfData as Integer = LeptonicaSharp._All.cidConvertToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("cidConvertToPdfData",TestPix, REScidConvertToPdfData,{"Dim REScidConvertToPdfData as Integer = LeptonicaSharp._All.cidConvertToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESl_CIDataDestroy as Object = LeptonicaSharp._All.l_CIDataDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_CIDataDestroy",TestPix, RESl_CIDataDestroy,{"Dim RESl_CIDataDestroy as Object = LeptonicaSharp._All.l_CIDataDestroy(TestPix )"},1)

' Dim RESl_pdfSetG4ImageMask as Object = LeptonicaSharp._All.l_pdfSetG4ImageMask(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_pdfSetG4ImageMask",TestPix, RESl_pdfSetG4ImageMask,{"Dim RESl_pdfSetG4ImageMask as Object = LeptonicaSharp._All.l_pdfSetG4ImageMask(TestPix )"},1)

' Dim RESl_pdfSetDateAndVersion as Object = LeptonicaSharp._All.l_pdfSetDateAndVersion(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_pdfSetDateAndVersion",TestPix, RESl_pdfSetDateAndVersion,{"Dim RESl_pdfSetDateAndVersion as Object = LeptonicaSharp._All.l_pdfSetDateAndVersion(TestPix )"},1)

' Dim RESsetPixMemoryManager as Object = LeptonicaSharp._All.setPixMemoryManager(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("setPixMemoryManager",TestPix, RESsetPixMemoryManager,{"Dim RESsetPixMemoryManager as Object = LeptonicaSharp._All.setPixMemoryManager(Nothing ,Nothing )"},1)

' Dim RESpixCreate as Pix = LeptonicaSharp._All.pixCreate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreate",TestPix, RESpixCreate,{"Dim RESpixCreate as Pix = LeptonicaSharp._All.pixCreate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCreateNoInit as Pix = LeptonicaSharp._All.pixCreateNoInit(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateNoInit",TestPix, RESpixCreateNoInit,{"Dim RESpixCreateNoInit as Pix = LeptonicaSharp._All.pixCreateNoInit(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCreateTemplate as Pix = LeptonicaSharp._All.pixCreateTemplate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateTemplate",TestPix, RESpixCreateTemplate,{"Dim RESpixCreateTemplate as Pix = LeptonicaSharp._All.pixCreateTemplate(TestPix )"},1)

' Dim RESpixCreateTemplateNoInit as Pix = LeptonicaSharp._All.pixCreateTemplateNoInit(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateTemplateNoInit",TestPix, RESpixCreateTemplateNoInit,{"Dim RESpixCreateTemplateNoInit as Pix = LeptonicaSharp._All.pixCreateTemplateNoInit(TestPix )"},1)

' Dim RESpixCreateHeader as Pix = LeptonicaSharp._All.pixCreateHeader(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateHeader",TestPix, RESpixCreateHeader,{"Dim RESpixCreateHeader as Pix = LeptonicaSharp._All.pixCreateHeader(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixClone as Pix = LeptonicaSharp._All.pixClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClone",TestPix, RESpixClone,{"Dim RESpixClone as Pix = LeptonicaSharp._All.pixClone(TestPix )"},1)

' Dim RESpixDestroy as Object = LeptonicaSharp._All.pixDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDestroy",TestPix, RESpixDestroy,{"Dim RESpixDestroy as Object = LeptonicaSharp._All.pixDestroy(TestPix )"},1)

' Dim RESpixCopy as Pix = LeptonicaSharp._All.pixCopy(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopy",TestPix, RESpixCopy,{"Dim RESpixCopy as Pix = LeptonicaSharp._All.pixCopy(Nothing ,TestPix )"},1)

' Dim RESpixResizeImageData as Integer = LeptonicaSharp._All.pixResizeImageData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixResizeImageData",TestPix, RESpixResizeImageData,{"Dim RESpixResizeImageData as Integer = LeptonicaSharp._All.pixResizeImageData(TestPix ,TestPix )"},1)

' Dim RESpixCopyColormap as Integer = LeptonicaSharp._All.pixCopyColormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyColormap",TestPix, RESpixCopyColormap,{"Dim RESpixCopyColormap as Integer = LeptonicaSharp._All.pixCopyColormap(TestPix ,TestPix )"},1)

' Dim RESpixSizesEqual as Integer = LeptonicaSharp._All.pixSizesEqual(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSizesEqual",TestPix, RESpixSizesEqual,{"Dim RESpixSizesEqual as Integer = LeptonicaSharp._All.pixSizesEqual(TestPix ,TestPix )"},1)

' Dim RESpixTransferAllData as Integer = LeptonicaSharp._All.pixTransferAllData(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTransferAllData",TestPix, RESpixTransferAllData,{"Dim RESpixTransferAllData as Integer = LeptonicaSharp._All.pixTransferAllData(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSwapAndDestroy as Integer = LeptonicaSharp._All.pixSwapAndDestroy(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSwapAndDestroy",TestPix, RESpixSwapAndDestroy,{"Dim RESpixSwapAndDestroy as Integer = LeptonicaSharp._All.pixSwapAndDestroy(Nothing ,TestPix )"},1)

' Dim RESpixGetWidth as Integer = LeptonicaSharp._All.pixGetWidth(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetWidth",TestPix, RESpixGetWidth,{"Dim RESpixGetWidth as Integer = LeptonicaSharp._All.pixGetWidth(TestPix )"},1)

' Dim RESpixSetWidth as Integer = LeptonicaSharp._All.pixSetWidth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetWidth",TestPix, RESpixSetWidth,{"Dim RESpixSetWidth as Integer = LeptonicaSharp._All.pixSetWidth(TestPix ,TestPix )"},1)

' Dim RESpixGetHeight as Integer = LeptonicaSharp._All.pixGetHeight(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetHeight",TestPix, RESpixGetHeight,{"Dim RESpixGetHeight as Integer = LeptonicaSharp._All.pixGetHeight(TestPix )"},1)

' Dim RESpixSetHeight as Integer = LeptonicaSharp._All.pixSetHeight(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetHeight",TestPix, RESpixSetHeight,{"Dim RESpixSetHeight as Integer = LeptonicaSharp._All.pixSetHeight(TestPix ,TestPix )"},1)

' Dim RESpixGetDepth as Integer = LeptonicaSharp._All.pixGetDepth(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetDepth",TestPix, RESpixGetDepth,{"Dim RESpixGetDepth as Integer = LeptonicaSharp._All.pixGetDepth(TestPix )"},1)

' Dim RESpixSetDepth as Integer = LeptonicaSharp._All.pixSetDepth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetDepth",TestPix, RESpixSetDepth,{"Dim RESpixSetDepth as Integer = LeptonicaSharp._All.pixSetDepth(TestPix ,TestPix )"},1)

' Dim RESpixGetDimensions as Integer = LeptonicaSharp._All.pixGetDimensions(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetDimensions",TestPix, RESpixGetDimensions,{"Dim RESpixGetDimensions as Integer = LeptonicaSharp._All.pixGetDimensions(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixSetDimensions as Integer = LeptonicaSharp._All.pixSetDimensions(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetDimensions",TestPix, RESpixSetDimensions,{"Dim RESpixSetDimensions as Integer = LeptonicaSharp._All.pixSetDimensions(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCopyDimensions as Integer = LeptonicaSharp._All.pixCopyDimensions(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyDimensions",TestPix, RESpixCopyDimensions,{"Dim RESpixCopyDimensions as Integer = LeptonicaSharp._All.pixCopyDimensions(TestPix ,TestPix )"},1)

' Dim RESpixGetSpp as Integer = LeptonicaSharp._All.pixGetSpp(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetSpp",TestPix, RESpixGetSpp,{"Dim RESpixGetSpp as Integer = LeptonicaSharp._All.pixGetSpp(TestPix )"},1)

' Dim RESpixSetSpp as Integer = LeptonicaSharp._All.pixSetSpp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetSpp",TestPix, RESpixSetSpp,{"Dim RESpixSetSpp as Integer = LeptonicaSharp._All.pixSetSpp(TestPix ,TestPix )"},1)

' Dim RESpixCopySpp as Integer = LeptonicaSharp._All.pixCopySpp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopySpp",TestPix, RESpixCopySpp,{"Dim RESpixCopySpp as Integer = LeptonicaSharp._All.pixCopySpp(TestPix ,TestPix )"},1)

' Dim RESpixGetWpl as Integer = LeptonicaSharp._All.pixGetWpl(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetWpl",TestPix, RESpixGetWpl,{"Dim RESpixGetWpl as Integer = LeptonicaSharp._All.pixGetWpl(TestPix )"},1)

' Dim RESpixSetWpl as Integer = LeptonicaSharp._All.pixSetWpl(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetWpl",TestPix, RESpixSetWpl,{"Dim RESpixSetWpl as Integer = LeptonicaSharp._All.pixSetWpl(TestPix ,TestPix )"},1)

' Dim RESpixGetRefcount as Integer = LeptonicaSharp._All.pixGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRefcount",TestPix, RESpixGetRefcount,{"Dim RESpixGetRefcount as Integer = LeptonicaSharp._All.pixGetRefcount(TestPix )"},1)

' Dim RESpixChangeRefcount as Integer = LeptonicaSharp._All.pixChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixChangeRefcount",TestPix, RESpixChangeRefcount,{"Dim RESpixChangeRefcount as Integer = LeptonicaSharp._All.pixChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESpixGetXRes as Integer = LeptonicaSharp._All.pixGetXRes(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetXRes",TestPix, RESpixGetXRes,{"Dim RESpixGetXRes as Integer = LeptonicaSharp._All.pixGetXRes(TestPix )"},1)

' Dim RESpixSetXRes as Integer = LeptonicaSharp._All.pixSetXRes(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetXRes",TestPix, RESpixSetXRes,{"Dim RESpixSetXRes as Integer = LeptonicaSharp._All.pixSetXRes(TestPix ,TestPix )"},1)

' Dim RESpixGetYRes as Integer = LeptonicaSharp._All.pixGetYRes(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetYRes",TestPix, RESpixGetYRes,{"Dim RESpixGetYRes as Integer = LeptonicaSharp._All.pixGetYRes(TestPix )"},1)

' Dim RESpixSetYRes as Integer = LeptonicaSharp._All.pixSetYRes(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetYRes",TestPix, RESpixSetYRes,{"Dim RESpixSetYRes as Integer = LeptonicaSharp._All.pixSetYRes(TestPix ,TestPix )"},1)

' Dim RESpixGetResolution as Integer = LeptonicaSharp._All.pixGetResolution(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetResolution",TestPix, RESpixGetResolution,{"Dim RESpixGetResolution as Integer = LeptonicaSharp._All.pixGetResolution(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixSetResolution as Integer = LeptonicaSharp._All.pixSetResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetResolution",TestPix, RESpixSetResolution,{"Dim RESpixSetResolution as Integer = LeptonicaSharp._All.pixSetResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCopyResolution as Integer = LeptonicaSharp._All.pixCopyResolution(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyResolution",TestPix, RESpixCopyResolution,{"Dim RESpixCopyResolution as Integer = LeptonicaSharp._All.pixCopyResolution(TestPix ,TestPix )"},1)

' Dim RESpixScaleResolution as Integer = LeptonicaSharp._All.pixScaleResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleResolution",TestPix, RESpixScaleResolution,{"Dim RESpixScaleResolution as Integer = LeptonicaSharp._All.pixScaleResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetInputFormat as Integer = LeptonicaSharp._All.pixGetInputFormat(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetInputFormat",TestPix, RESpixGetInputFormat,{"Dim RESpixGetInputFormat as Integer = LeptonicaSharp._All.pixGetInputFormat(TestPix )"},1)

' Dim RESpixSetInputFormat as Integer = LeptonicaSharp._All.pixSetInputFormat(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetInputFormat",TestPix, RESpixSetInputFormat,{"Dim RESpixSetInputFormat as Integer = LeptonicaSharp._All.pixSetInputFormat(TestPix ,TestPix )"},1)

' Dim RESpixCopyInputFormat as Integer = LeptonicaSharp._All.pixCopyInputFormat(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyInputFormat",TestPix, RESpixCopyInputFormat,{"Dim RESpixCopyInputFormat as Integer = LeptonicaSharp._All.pixCopyInputFormat(TestPix ,TestPix )"},1)

' Dim RESpixSetSpecial as Integer = LeptonicaSharp._All.pixSetSpecial(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetSpecial",TestPix, RESpixSetSpecial,{"Dim RESpixSetSpecial as Integer = LeptonicaSharp._All.pixSetSpecial(TestPix ,TestPix )"},1)

' Dim RESpixGetText as String = LeptonicaSharp._All.pixGetText(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetText",TestPix, RESpixGetText,{"Dim RESpixGetText as String = LeptonicaSharp._All.pixGetText(TestPix )"},1)

' Dim RESpixSetText as Integer = LeptonicaSharp._All.pixSetText(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetText",TestPix, RESpixSetText,{"Dim RESpixSetText as Integer = LeptonicaSharp._All.pixSetText(TestPix ,Nothing )"},1)

' Dim RESpixAddText as Integer = LeptonicaSharp._All.pixAddText(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddText",TestPix, RESpixAddText,{"Dim RESpixAddText as Integer = LeptonicaSharp._All.pixAddText(TestPix ,Nothing )"},1)

' Dim RESpixCopyText as Integer = LeptonicaSharp._All.pixCopyText(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyText",TestPix, RESpixCopyText,{"Dim RESpixCopyText as Integer = LeptonicaSharp._All.pixCopyText(TestPix ,TestPix )"},1)

' Dim RESpixGetColormap as PixColormap = LeptonicaSharp._All.pixGetColormap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColormap",TestPix, RESpixGetColormap,{"Dim RESpixGetColormap as PixColormap = LeptonicaSharp._All.pixGetColormap(TestPix )"},1)

' Dim RESpixSetColormap as Integer = LeptonicaSharp._All.pixSetColormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetColormap",TestPix, RESpixSetColormap,{"Dim RESpixSetColormap as Integer = LeptonicaSharp._All.pixSetColormap(TestPix ,TestPix )"},1)

' Dim RESpixDestroyColormap as Integer = LeptonicaSharp._All.pixDestroyColormap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDestroyColormap",TestPix, RESpixDestroyColormap,{"Dim RESpixDestroyColormap as Integer = LeptonicaSharp._All.pixDestroyColormap(TestPix )"},1)

' Dim RESpixGetData as Byte() = LeptonicaSharp._All.pixGetData(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetData",TestPix, RESpixGetData,{"Dim RESpixGetData as Byte() = LeptonicaSharp._All.pixGetData(TestPix )"},1)

' Dim RESpixSetData as Integer = LeptonicaSharp._All.pixSetData(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetData",TestPix, RESpixSetData,{"Dim RESpixSetData as Integer = LeptonicaSharp._All.pixSetData(TestPix ,TestPix )"},1)

' Dim RESpixExtractData as Byte() = LeptonicaSharp._All.pixExtractData(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractData",TestPix, RESpixExtractData,{"Dim RESpixExtractData as Byte() = LeptonicaSharp._All.pixExtractData(TestPix )"},1)

' Dim RESpixFreeData as Integer = LeptonicaSharp._All.pixFreeData(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFreeData",TestPix, RESpixFreeData,{"Dim RESpixFreeData as Integer = LeptonicaSharp._All.pixFreeData(TestPix )"},1)

' Dim RESpixGetLinePtrs as IntPtr() = LeptonicaSharp._All.pixGetLinePtrs(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetLinePtrs",TestPix, RESpixGetLinePtrs,{"Dim RESpixGetLinePtrs as IntPtr() = LeptonicaSharp._All.pixGetLinePtrs(TestPix ,Nothing )"},1)

' Dim RESpixPrintStreamInfo as Integer = LeptonicaSharp._All.pixPrintStreamInfo(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPrintStreamInfo",TestPix, RESpixPrintStreamInfo,{"Dim RESpixPrintStreamInfo as Integer = LeptonicaSharp._All.pixPrintStreamInfo(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGetPixel as Integer = LeptonicaSharp._All.pixGetPixel(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetPixel",TestPix, RESpixGetPixel,{"Dim RESpixGetPixel as Integer = LeptonicaSharp._All.pixGetPixel(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixSetPixel as Integer = LeptonicaSharp._All.pixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetPixel",TestPix, RESpixSetPixel,{"Dim RESpixSetPixel as Integer = LeptonicaSharp._All.pixSetPixel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRGBPixel as Integer = LeptonicaSharp._All.pixGetRGBPixel(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRGBPixel",TestPix, RESpixGetRGBPixel,{"Dim RESpixGetRGBPixel as Integer = LeptonicaSharp._All.pixGetRGBPixel(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixSetRGBPixel as Integer = LeptonicaSharp._All.pixSetRGBPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetRGBPixel",TestPix, RESpixSetRGBPixel,{"Dim RESpixSetRGBPixel as Integer = LeptonicaSharp._All.pixSetRGBPixel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRandomPixel as Integer = LeptonicaSharp._All.pixGetRandomPixel(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRandomPixel",TestPix, RESpixGetRandomPixel,{"Dim RESpixGetRandomPixel as Integer = LeptonicaSharp._All.pixGetRandomPixel(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixClearPixel as Integer = LeptonicaSharp._All.pixClearPixel(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClearPixel",TestPix, RESpixClearPixel,{"Dim RESpixClearPixel as Integer = LeptonicaSharp._All.pixClearPixel(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFlipPixel as Integer = LeptonicaSharp._All.pixFlipPixel(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFlipPixel",TestPix, RESpixFlipPixel,{"Dim RESpixFlipPixel as Integer = LeptonicaSharp._All.pixFlipPixel(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsetPixelLow as Object = LeptonicaSharp._All.setPixelLow(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("setPixelLow",TestPix, RESsetPixelLow,{"Dim RESsetPixelLow as Object = LeptonicaSharp._All.setPixelLow(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetBlackOrWhiteVal as Integer = LeptonicaSharp._All.pixGetBlackOrWhiteVal(TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBlackOrWhiteVal",TestPix, RESpixGetBlackOrWhiteVal,{"Dim RESpixGetBlackOrWhiteVal as Integer = LeptonicaSharp._All.pixGetBlackOrWhiteVal(TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixClearAll as Integer = LeptonicaSharp._All.pixClearAll(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClearAll",TestPix, RESpixClearAll,{"Dim RESpixClearAll as Integer = LeptonicaSharp._All.pixClearAll(TestPix )"},1)

' Dim RESpixSetAll as Integer = LeptonicaSharp._All.pixSetAll(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetAll",TestPix, RESpixSetAll,{"Dim RESpixSetAll as Integer = LeptonicaSharp._All.pixSetAll(TestPix )"},1)

' Dim RESpixSetAllGray as Integer = LeptonicaSharp._All.pixSetAllGray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetAllGray",TestPix, RESpixSetAllGray,{"Dim RESpixSetAllGray as Integer = LeptonicaSharp._All.pixSetAllGray(TestPix ,TestPix )"},1)

' Dim RESpixSetAllArbitrary as Integer = LeptonicaSharp._All.pixSetAllArbitrary(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetAllArbitrary",TestPix, RESpixSetAllArbitrary,{"Dim RESpixSetAllArbitrary as Integer = LeptonicaSharp._All.pixSetAllArbitrary(TestPix ,TestPix )"},1)

' Dim RESpixSetBlackOrWhite as Integer = LeptonicaSharp._All.pixSetBlackOrWhite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetBlackOrWhite",TestPix, RESpixSetBlackOrWhite,{"Dim RESpixSetBlackOrWhite as Integer = LeptonicaSharp._All.pixSetBlackOrWhite(TestPix ,TestPix )"},1)

' Dim RESpixSetComponentArbitrary as Integer = LeptonicaSharp._All.pixSetComponentArbitrary(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetComponentArbitrary",TestPix, RESpixSetComponentArbitrary,{"Dim RESpixSetComponentArbitrary as Integer = LeptonicaSharp._All.pixSetComponentArbitrary(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixClearInRect as Integer = LeptonicaSharp._All.pixClearInRect(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClearInRect",TestPix, RESpixClearInRect,{"Dim RESpixClearInRect as Integer = LeptonicaSharp._All.pixClearInRect(TestPix ,TestPix )"},1)

' Dim RESpixSetInRect as Integer = LeptonicaSharp._All.pixSetInRect(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetInRect",TestPix, RESpixSetInRect,{"Dim RESpixSetInRect as Integer = LeptonicaSharp._All.pixSetInRect(TestPix ,TestPix )"},1)

' Dim RESpixSetInRectArbitrary as Integer = LeptonicaSharp._All.pixSetInRectArbitrary(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetInRectArbitrary",TestPix, RESpixSetInRectArbitrary,{"Dim RESpixSetInRectArbitrary as Integer = LeptonicaSharp._All.pixSetInRectArbitrary(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixBlendInRect as Integer = LeptonicaSharp._All.pixBlendInRect(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixBlendInRect",TestPix, RESpixBlendInRect,{"Dim RESpixBlendInRect as Integer = LeptonicaSharp._All.pixBlendInRect(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixSetPadBits as Integer = LeptonicaSharp._All.pixSetPadBits(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetPadBits",TestPix, RESpixSetPadBits,{"Dim RESpixSetPadBits as Integer = LeptonicaSharp._All.pixSetPadBits(TestPix ,TestPix )"},1)

' Dim RESpixSetPadBitsBand as Integer = LeptonicaSharp._All.pixSetPadBitsBand(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetPadBitsBand",TestPix, RESpixSetPadBitsBand,{"Dim RESpixSetPadBitsBand as Integer = LeptonicaSharp._All.pixSetPadBitsBand(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetOrClearBorder as Integer = LeptonicaSharp._All.pixSetOrClearBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetOrClearBorder",TestPix, RESpixSetOrClearBorder,{"Dim RESpixSetOrClearBorder as Integer = LeptonicaSharp._All.pixSetOrClearBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetBorderVal as Integer = LeptonicaSharp._All.pixSetBorderVal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetBorderVal",TestPix, RESpixSetBorderVal,{"Dim RESpixSetBorderVal as Integer = LeptonicaSharp._All.pixSetBorderVal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetBorderRingVal as Integer = LeptonicaSharp._All.pixSetBorderRingVal(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetBorderRingVal",TestPix, RESpixSetBorderRingVal,{"Dim RESpixSetBorderRingVal as Integer = LeptonicaSharp._All.pixSetBorderRingVal(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetMirroredBorder as Integer = LeptonicaSharp._All.pixSetMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetMirroredBorder",TestPix, RESpixSetMirroredBorder,{"Dim RESpixSetMirroredBorder as Integer = LeptonicaSharp._All.pixSetMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCopyBorder as Pix = LeptonicaSharp._All.pixCopyBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyBorder",TestPix, RESpixCopyBorder,{"Dim RESpixCopyBorder as Pix = LeptonicaSharp._All.pixCopyBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddBorder as Pix = LeptonicaSharp._All.pixAddBorder(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddBorder",TestPix, RESpixAddBorder,{"Dim RESpixAddBorder as Pix = LeptonicaSharp._All.pixAddBorder(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddBlackOrWhiteBorder as Pix = LeptonicaSharp._All.pixAddBlackOrWhiteBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddBlackOrWhiteBorder",TestPix, RESpixAddBlackOrWhiteBorder,{"Dim RESpixAddBlackOrWhiteBorder as Pix = LeptonicaSharp._All.pixAddBlackOrWhiteBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddBorderGeneral as Pix = LeptonicaSharp._All.pixAddBorderGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddBorderGeneral",TestPix, RESpixAddBorderGeneral,{"Dim RESpixAddBorderGeneral as Pix = LeptonicaSharp._All.pixAddBorderGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveBorder as Pix = LeptonicaSharp._All.pixRemoveBorder(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveBorder",TestPix, RESpixRemoveBorder,{"Dim RESpixRemoveBorder as Pix = LeptonicaSharp._All.pixRemoveBorder(TestPix ,TestPix )"},1)

' Dim RESpixRemoveBorderGeneral as Pix = LeptonicaSharp._All.pixRemoveBorderGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveBorderGeneral",TestPix, RESpixRemoveBorderGeneral,{"Dim RESpixRemoveBorderGeneral as Pix = LeptonicaSharp._All.pixRemoveBorderGeneral(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveBorderToSize as Pix = LeptonicaSharp._All.pixRemoveBorderToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveBorderToSize",TestPix, RESpixRemoveBorderToSize,{"Dim RESpixRemoveBorderToSize as Pix = LeptonicaSharp._All.pixRemoveBorderToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddMirroredBorder as Pix = LeptonicaSharp._All.pixAddMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddMirroredBorder",TestPix, RESpixAddMirroredBorder,{"Dim RESpixAddMirroredBorder as Pix = LeptonicaSharp._All.pixAddMirroredBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddRepeatedBorder as Pix = LeptonicaSharp._All.pixAddRepeatedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddRepeatedBorder",TestPix, RESpixAddRepeatedBorder,{"Dim RESpixAddRepeatedBorder as Pix = LeptonicaSharp._All.pixAddRepeatedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddMixedBorder as Pix = LeptonicaSharp._All.pixAddMixedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddMixedBorder",TestPix, RESpixAddMixedBorder,{"Dim RESpixAddMixedBorder as Pix = LeptonicaSharp._All.pixAddMixedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddContinuedBorder as Pix = LeptonicaSharp._All.pixAddContinuedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddContinuedBorder",TestPix, RESpixAddContinuedBorder,{"Dim RESpixAddContinuedBorder as Pix = LeptonicaSharp._All.pixAddContinuedBorder(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixShiftAndTransferAlpha as Integer = LeptonicaSharp._All.pixShiftAndTransferAlpha(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixShiftAndTransferAlpha",TestPix, RESpixShiftAndTransferAlpha,{"Dim RESpixShiftAndTransferAlpha as Integer = LeptonicaSharp._All.pixShiftAndTransferAlpha(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayLayersRGBA as Pix = LeptonicaSharp._All.pixDisplayLayersRGBA(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayLayersRGBA",TestPix, RESpixDisplayLayersRGBA,{"Dim RESpixDisplayLayersRGBA as Pix = LeptonicaSharp._All.pixDisplayLayersRGBA(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCreateRGBImage as Pix = LeptonicaSharp._All.pixCreateRGBImage(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateRGBImage",TestPix, RESpixCreateRGBImage,{"Dim RESpixCreateRGBImage as Pix = LeptonicaSharp._All.pixCreateRGBImage(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRGBComponent as Pix = LeptonicaSharp._All.pixGetRGBComponent(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRGBComponent",TestPix, RESpixGetRGBComponent,{"Dim RESpixGetRGBComponent as Pix = LeptonicaSharp._All.pixGetRGBComponent(TestPix ,TestPix )"},1)

' Dim RESpixSetRGBComponent as Integer = LeptonicaSharp._All.pixSetRGBComponent(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetRGBComponent",TestPix, RESpixSetRGBComponent,{"Dim RESpixSetRGBComponent as Integer = LeptonicaSharp._All.pixSetRGBComponent(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRGBComponentCmap as Pix = LeptonicaSharp._All.pixGetRGBComponentCmap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRGBComponentCmap",TestPix, RESpixGetRGBComponentCmap,{"Dim RESpixGetRGBComponentCmap as Pix = LeptonicaSharp._All.pixGetRGBComponentCmap(TestPix ,TestPix )"},1)

' Dim RESpixCopyRGBComponent as Integer = LeptonicaSharp._All.pixCopyRGBComponent(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCopyRGBComponent",TestPix, RESpixCopyRGBComponent,{"Dim RESpixCopyRGBComponent as Integer = LeptonicaSharp._All.pixCopyRGBComponent(TestPix ,TestPix ,TestPix )"},1)

' Dim REScomposeRGBPixel as Integer = LeptonicaSharp._All.composeRGBPixel(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("composeRGBPixel",TestPix, REScomposeRGBPixel,{"Dim REScomposeRGBPixel as Integer = LeptonicaSharp._All.composeRGBPixel(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim REScomposeRGBAPixel as Integer = LeptonicaSharp._All.composeRGBAPixel(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("composeRGBAPixel",TestPix, REScomposeRGBAPixel,{"Dim REScomposeRGBAPixel as Integer = LeptonicaSharp._All.composeRGBAPixel(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESextractRGBValues as Object = LeptonicaSharp._All.extractRGBValues(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("extractRGBValues",TestPix, RESextractRGBValues,{"Dim RESextractRGBValues as Object = LeptonicaSharp._All.extractRGBValues(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESextractRGBAValues as Object = LeptonicaSharp._All.extractRGBAValues(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("extractRGBAValues",TestPix, RESextractRGBAValues,{"Dim RESextractRGBAValues as Object = LeptonicaSharp._All.extractRGBAValues(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESextractMinMaxComponent as Integer = LeptonicaSharp._All.extractMinMaxComponent(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("extractMinMaxComponent",TestPix, RESextractMinMaxComponent,{"Dim RESextractMinMaxComponent as Integer = LeptonicaSharp._All.extractMinMaxComponent(TestPix ,TestPix )"},1)

' Dim RESpixGetRGBLine as Integer = LeptonicaSharp._All.pixGetRGBLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRGBLine",TestPix, RESpixGetRGBLine,{"Dim RESpixGetRGBLine as Integer = LeptonicaSharp._All.pixGetRGBLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixEndianByteSwapNew as Pix = LeptonicaSharp._All.pixEndianByteSwapNew(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEndianByteSwapNew",TestPix, RESpixEndianByteSwapNew,{"Dim RESpixEndianByteSwapNew as Pix = LeptonicaSharp._All.pixEndianByteSwapNew(TestPix )"},1)

' Dim RESpixEndianByteSwap as Integer = LeptonicaSharp._All.pixEndianByteSwap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEndianByteSwap",TestPix, RESpixEndianByteSwap,{"Dim RESpixEndianByteSwap as Integer = LeptonicaSharp._All.pixEndianByteSwap(TestPix )"},1)

' Dim RESlineEndianByteSwap as Integer = LeptonicaSharp._All.lineEndianByteSwap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lineEndianByteSwap",TestPix, RESlineEndianByteSwap,{"Dim RESlineEndianByteSwap as Integer = LeptonicaSharp._All.lineEndianByteSwap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixEndianTwoByteSwapNew as Pix = LeptonicaSharp._All.pixEndianTwoByteSwapNew(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEndianTwoByteSwapNew",TestPix, RESpixEndianTwoByteSwapNew,{"Dim RESpixEndianTwoByteSwapNew as Pix = LeptonicaSharp._All.pixEndianTwoByteSwapNew(TestPix )"},1)

' Dim RESpixEndianTwoByteSwap as Integer = LeptonicaSharp._All.pixEndianTwoByteSwap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEndianTwoByteSwap",TestPix, RESpixEndianTwoByteSwap,{"Dim RESpixEndianTwoByteSwap as Integer = LeptonicaSharp._All.pixEndianTwoByteSwap(TestPix )"},1)

' Dim RESpixGetRasterData as Integer = LeptonicaSharp._All.pixGetRasterData(TestPix ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRasterData",TestPix, RESpixGetRasterData,{"Dim RESpixGetRasterData as Integer = LeptonicaSharp._All.pixGetRasterData(TestPix ,New Byte(),New UInteger)"},1)

' Dim RESpixAlphaIsOpaque as Integer = LeptonicaSharp._All.pixAlphaIsOpaque(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAlphaIsOpaque",TestPix, RESpixAlphaIsOpaque,{"Dim RESpixAlphaIsOpaque as Integer = LeptonicaSharp._All.pixAlphaIsOpaque(TestPix ,New Integer)"},1)

' Dim RESpixSetupByteProcessing as List( of Byte()) = LeptonicaSharp._All.pixSetupByteProcessing(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetupByteProcessing",TestPix, RESpixSetupByteProcessing,{"Dim RESpixSetupByteProcessing as List( of Byte()) = LeptonicaSharp._All.pixSetupByteProcessing(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixCleanupByteProcessing as Integer = LeptonicaSharp._All.pixCleanupByteProcessing(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCleanupByteProcessing",TestPix, RESpixCleanupByteProcessing,{"Dim RESpixCleanupByteProcessing as Integer = LeptonicaSharp._All.pixCleanupByteProcessing(TestPix ,TestPix )"},1)

' Dim RESl_setAlphaMaskBorder as Object = LeptonicaSharp._All.l_setAlphaMaskBorder(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setAlphaMaskBorder",TestPix, RESl_setAlphaMaskBorder,{"Dim RESl_setAlphaMaskBorder as Object = LeptonicaSharp._All.l_setAlphaMaskBorder(TestPix ,TestPix )"},1)

' Dim RESpixSetMasked as Integer = LeptonicaSharp._All.pixSetMasked(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetMasked",TestPix, RESpixSetMasked,{"Dim RESpixSetMasked as Integer = LeptonicaSharp._All.pixSetMasked(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixSetMaskedGeneral as Integer = LeptonicaSharp._All.pixSetMaskedGeneral(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetMaskedGeneral",TestPix, RESpixSetMaskedGeneral,{"Dim RESpixSetMaskedGeneral as Integer = LeptonicaSharp._All.pixSetMaskedGeneral(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCombineMasked as Integer = LeptonicaSharp._All.pixCombineMasked(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCombineMasked",TestPix, RESpixCombineMasked,{"Dim RESpixCombineMasked as Integer = LeptonicaSharp._All.pixCombineMasked(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixCombineMaskedGeneral as Integer = LeptonicaSharp._All.pixCombineMaskedGeneral(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCombineMaskedGeneral",TestPix, RESpixCombineMaskedGeneral,{"Dim RESpixCombineMaskedGeneral as Integer = LeptonicaSharp._All.pixCombineMaskedGeneral(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixPaintThroughMask as Integer = LeptonicaSharp._All.pixPaintThroughMask(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPaintThroughMask",TestPix, RESpixPaintThroughMask,{"Dim RESpixPaintThroughMask as Integer = LeptonicaSharp._All.pixPaintThroughMask(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixPaintSelfThroughMask as Integer = LeptonicaSharp._All.pixPaintSelfThroughMask(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPaintSelfThroughMask",TestPix, RESpixPaintSelfThroughMask,{"Dim RESpixPaintSelfThroughMask as Integer = LeptonicaSharp._All.pixPaintSelfThroughMask(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMakeMaskFromVal as Pix = LeptonicaSharp._All.pixMakeMaskFromVal(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeMaskFromVal",TestPix, RESpixMakeMaskFromVal,{"Dim RESpixMakeMaskFromVal as Pix = LeptonicaSharp._All.pixMakeMaskFromVal(TestPix ,TestPix )"},1)

' Dim RESpixMakeMaskFromLUT as Pix = LeptonicaSharp._All.pixMakeMaskFromLUT(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeMaskFromLUT",TestPix, RESpixMakeMaskFromLUT,{"Dim RESpixMakeMaskFromLUT as Pix = LeptonicaSharp._All.pixMakeMaskFromLUT(TestPix ,TestPix )"},1)

' Dim RESpixMakeArbMaskFromRGB as Pix = LeptonicaSharp._All.pixMakeArbMaskFromRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeArbMaskFromRGB",TestPix, RESpixMakeArbMaskFromRGB,{"Dim RESpixMakeArbMaskFromRGB as Pix = LeptonicaSharp._All.pixMakeArbMaskFromRGB(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetUnderTransparency as Pix = LeptonicaSharp._All.pixSetUnderTransparency(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetUnderTransparency",TestPix, RESpixSetUnderTransparency,{"Dim RESpixSetUnderTransparency as Pix = LeptonicaSharp._All.pixSetUnderTransparency(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixMakeAlphaFromMask as Pix = LeptonicaSharp._All.pixMakeAlphaFromMask(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeAlphaFromMask",TestPix, RESpixMakeAlphaFromMask,{"Dim RESpixMakeAlphaFromMask as Pix = LeptonicaSharp._All.pixMakeAlphaFromMask(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGetColorNearMaskBoundary as Integer = LeptonicaSharp._All.pixGetColorNearMaskBoundary(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColorNearMaskBoundary",TestPix, RESpixGetColorNearMaskBoundary,{"Dim RESpixGetColorNearMaskBoundary as Integer = LeptonicaSharp._All.pixGetColorNearMaskBoundary(TestPix ,TestPix ,TestPix ,TestPix ,New UInteger,Nothing )"},1)

' Dim RESpixInvert as Pix = LeptonicaSharp._All.pixInvert(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixInvert",TestPix, RESpixInvert,{"Dim RESpixInvert as Pix = LeptonicaSharp._All.pixInvert(Nothing ,TestPix )"},1)

' Dim RESpixOr as Pix = LeptonicaSharp._All.pixOr(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixOr",TestPix, RESpixOr,{"Dim RESpixOr as Pix = LeptonicaSharp._All.pixOr(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixAnd as Pix = LeptonicaSharp._All.pixAnd(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAnd",TestPix, RESpixAnd,{"Dim RESpixAnd as Pix = LeptonicaSharp._All.pixAnd(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixXor as Pix = LeptonicaSharp._All.pixXor(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixXor",TestPix, RESpixXor,{"Dim RESpixXor as Pix = LeptonicaSharp._All.pixXor(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixSubtract as Pix = LeptonicaSharp._All.pixSubtract(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSubtract",TestPix, RESpixSubtract,{"Dim RESpixSubtract as Pix = LeptonicaSharp._All.pixSubtract(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixZero as Integer = LeptonicaSharp._All.pixZero(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixZero",TestPix, RESpixZero,{"Dim RESpixZero as Integer = LeptonicaSharp._All.pixZero(TestPix ,New Integer)"},1)

' Dim RESpixForegroundFraction as Integer = LeptonicaSharp._All.pixForegroundFraction(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixForegroundFraction",TestPix, RESpixForegroundFraction,{"Dim RESpixForegroundFraction as Integer = LeptonicaSharp._All.pixForegroundFraction(TestPix ,New Single)"},1)

' Dim RESpixaCountPixels as Numa = LeptonicaSharp._All.pixaCountPixels(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCountPixels",TestPix, RESpixaCountPixels,{"Dim RESpixaCountPixels as Numa = LeptonicaSharp._All.pixaCountPixels(TestPix )"},1)

' Dim RESpixCountPixels as Integer = LeptonicaSharp._All.pixCountPixels(TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountPixels",TestPix, RESpixCountPixels,{"Dim RESpixCountPixels as Integer = LeptonicaSharp._All.pixCountPixels(TestPix ,New Integer,Nothing )"},1)

' Dim RESpixCountPixelsInRect as Integer = LeptonicaSharp._All.pixCountPixelsInRect(TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountPixelsInRect",TestPix, RESpixCountPixelsInRect,{"Dim RESpixCountPixelsInRect as Integer = LeptonicaSharp._All.pixCountPixelsInRect(TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESpixCountByRow as Numa = LeptonicaSharp._All.pixCountByRow(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountByRow",TestPix, RESpixCountByRow,{"Dim RESpixCountByRow as Numa = LeptonicaSharp._All.pixCountByRow(TestPix ,Nothing )"},1)

' Dim RESpixCountByColumn as Numa = LeptonicaSharp._All.pixCountByColumn(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountByColumn",TestPix, RESpixCountByColumn,{"Dim RESpixCountByColumn as Numa = LeptonicaSharp._All.pixCountByColumn(TestPix ,Nothing )"},1)

' Dim RESpixCountPixelsByRow as Numa = LeptonicaSharp._All.pixCountPixelsByRow(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountPixelsByRow",TestPix, RESpixCountPixelsByRow,{"Dim RESpixCountPixelsByRow as Numa = LeptonicaSharp._All.pixCountPixelsByRow(TestPix ,Nothing )"},1)

' Dim RESpixCountPixelsByColumn as Numa = LeptonicaSharp._All.pixCountPixelsByColumn(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountPixelsByColumn",TestPix, RESpixCountPixelsByColumn,{"Dim RESpixCountPixelsByColumn as Numa = LeptonicaSharp._All.pixCountPixelsByColumn(TestPix )"},1)

' Dim RESpixCountPixelsInRow as Integer = LeptonicaSharp._All.pixCountPixelsInRow(TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountPixelsInRow",TestPix, RESpixCountPixelsInRow,{"Dim RESpixCountPixelsInRow as Integer = LeptonicaSharp._All.pixCountPixelsInRow(TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESpixGetMomentByColumn as Numa = LeptonicaSharp._All.pixGetMomentByColumn(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetMomentByColumn",TestPix, RESpixGetMomentByColumn,{"Dim RESpixGetMomentByColumn as Numa = LeptonicaSharp._All.pixGetMomentByColumn(TestPix ,TestPix )"},1)

' Dim RESpixThresholdPixelSum as Integer = LeptonicaSharp._All.pixThresholdPixelSum(TestPix ,TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdPixelSum",TestPix, RESpixThresholdPixelSum,{"Dim RESpixThresholdPixelSum as Integer = LeptonicaSharp._All.pixThresholdPixelSum(TestPix ,TestPix ,New Integer,Nothing )"},1)

' Dim RESmakePixelSumTab8 as Integer() = LeptonicaSharp._All.makePixelSumTab8()
' LeptonicaSharp.Convert.WriteHelpExtension ("makePixelSumTab8",TestPix, RESmakePixelSumTab8,{"Dim RESmakePixelSumTab8 as Integer() = LeptonicaSharp._All.makePixelSumTab8()"},1)

' Dim RESmakePixelCentroidTab8 as Integer() = LeptonicaSharp._All.makePixelCentroidTab8()
' LeptonicaSharp.Convert.WriteHelpExtension ("makePixelCentroidTab8",TestPix, RESmakePixelCentroidTab8,{"Dim RESmakePixelCentroidTab8 as Integer() = LeptonicaSharp._All.makePixelCentroidTab8()"},1)

' Dim RESpixAverageByRow as Numa = LeptonicaSharp._All.pixAverageByRow(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAverageByRow",TestPix, RESpixAverageByRow,{"Dim RESpixAverageByRow as Numa = LeptonicaSharp._All.pixAverageByRow(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixAverageByColumn as Numa = LeptonicaSharp._All.pixAverageByColumn(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAverageByColumn",TestPix, RESpixAverageByColumn,{"Dim RESpixAverageByColumn as Numa = LeptonicaSharp._All.pixAverageByColumn(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixAverageInRect as Integer = LeptonicaSharp._All.pixAverageInRect(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAverageInRect",TestPix, RESpixAverageInRect,{"Dim RESpixAverageInRect as Integer = LeptonicaSharp._All.pixAverageInRect(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixVarianceByRow as Numa = LeptonicaSharp._All.pixVarianceByRow(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVarianceByRow",TestPix, RESpixVarianceByRow,{"Dim RESpixVarianceByRow as Numa = LeptonicaSharp._All.pixVarianceByRow(TestPix ,Nothing )"},1)

' Dim RESpixVarianceByColumn as Numa = LeptonicaSharp._All.pixVarianceByColumn(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVarianceByColumn",TestPix, RESpixVarianceByColumn,{"Dim RESpixVarianceByColumn as Numa = LeptonicaSharp._All.pixVarianceByColumn(TestPix ,Nothing )"},1)

' Dim RESpixVarianceInRect as Integer = LeptonicaSharp._All.pixVarianceInRect(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVarianceInRect",TestPix, RESpixVarianceInRect,{"Dim RESpixVarianceInRect as Integer = LeptonicaSharp._All.pixVarianceInRect(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixAbsDiffByRow as Numa = LeptonicaSharp._All.pixAbsDiffByRow(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAbsDiffByRow",TestPix, RESpixAbsDiffByRow,{"Dim RESpixAbsDiffByRow as Numa = LeptonicaSharp._All.pixAbsDiffByRow(TestPix ,Nothing )"},1)

' Dim RESpixAbsDiffByColumn as Numa = LeptonicaSharp._All.pixAbsDiffByColumn(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAbsDiffByColumn",TestPix, RESpixAbsDiffByColumn,{"Dim RESpixAbsDiffByColumn as Numa = LeptonicaSharp._All.pixAbsDiffByColumn(TestPix ,Nothing )"},1)

' Dim RESpixAbsDiffInRect as Integer = LeptonicaSharp._All.pixAbsDiffInRect(TestPix ,Nothing ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAbsDiffInRect",TestPix, RESpixAbsDiffInRect,{"Dim RESpixAbsDiffInRect as Integer = LeptonicaSharp._All.pixAbsDiffInRect(TestPix ,Nothing ,TestPix ,New Single)"},1)

' Dim RESpixAbsDiffOnLine as Integer = LeptonicaSharp._All.pixAbsDiffOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAbsDiffOnLine",TestPix, RESpixAbsDiffOnLine,{"Dim RESpixAbsDiffOnLine as Integer = LeptonicaSharp._All.pixAbsDiffOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixCountArbInRect as Integer = LeptonicaSharp._All.pixCountArbInRect(TestPix ,Nothing ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountArbInRect",TestPix, RESpixCountArbInRect,{"Dim RESpixCountArbInRect as Integer = LeptonicaSharp._All.pixCountArbInRect(TestPix ,Nothing ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixMirroredTiling as Pix = LeptonicaSharp._All.pixMirroredTiling(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMirroredTiling",TestPix, RESpixMirroredTiling,{"Dim RESpixMirroredTiling as Pix = LeptonicaSharp._All.pixMirroredTiling(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindRepCloseTile as Integer = LeptonicaSharp._All.pixFindRepCloseTile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Box,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindRepCloseTile",TestPix, RESpixFindRepCloseTile,{"Dim RESpixFindRepCloseTile as Integer = LeptonicaSharp._All.pixFindRepCloseTile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Box,Nothing )"},1)

' Dim RESpixGetGrayHistogram as Numa = LeptonicaSharp._All.pixGetGrayHistogram(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetGrayHistogram",TestPix, RESpixGetGrayHistogram,{"Dim RESpixGetGrayHistogram as Numa = LeptonicaSharp._All.pixGetGrayHistogram(TestPix ,TestPix )"},1)

' Dim RESpixGetGrayHistogramMasked as Numa = LeptonicaSharp._All.pixGetGrayHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetGrayHistogramMasked",TestPix, RESpixGetGrayHistogramMasked,{"Dim RESpixGetGrayHistogramMasked as Numa = LeptonicaSharp._All.pixGetGrayHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetGrayHistogramInRect as Numa = LeptonicaSharp._All.pixGetGrayHistogramInRect(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetGrayHistogramInRect",TestPix, RESpixGetGrayHistogramInRect,{"Dim RESpixGetGrayHistogramInRect as Numa = LeptonicaSharp._All.pixGetGrayHistogramInRect(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixGetGrayHistogramTiled as Numaa = LeptonicaSharp._All.pixGetGrayHistogramTiled(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetGrayHistogramTiled",TestPix, RESpixGetGrayHistogramTiled,{"Dim RESpixGetGrayHistogramTiled as Numaa = LeptonicaSharp._All.pixGetGrayHistogramTiled(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetColorHistogram as Integer = LeptonicaSharp._All.pixGetColorHistogram(TestPix ,TestPix ,New Numa,New Numa,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColorHistogram",TestPix, RESpixGetColorHistogram,{"Dim RESpixGetColorHistogram as Integer = LeptonicaSharp._All.pixGetColorHistogram(TestPix ,TestPix ,New Numa,New Numa,New Numa)"},1)

' Dim RESpixGetColorHistogramMasked as Integer = LeptonicaSharp._All.pixGetColorHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Numa,New Numa,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColorHistogramMasked",TestPix, RESpixGetColorHistogramMasked,{"Dim RESpixGetColorHistogramMasked as Integer = LeptonicaSharp._All.pixGetColorHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New Numa,New Numa,New Numa)"},1)

' Dim RESpixGetCmapHistogram as Numa = LeptonicaSharp._All.pixGetCmapHistogram(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetCmapHistogram",TestPix, RESpixGetCmapHistogram,{"Dim RESpixGetCmapHistogram as Numa = LeptonicaSharp._All.pixGetCmapHistogram(TestPix ,TestPix )"},1)

' Dim RESpixGetCmapHistogramMasked as Numa = LeptonicaSharp._All.pixGetCmapHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetCmapHistogramMasked",TestPix, RESpixGetCmapHistogramMasked,{"Dim RESpixGetCmapHistogramMasked as Numa = LeptonicaSharp._All.pixGetCmapHistogramMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetCmapHistogramInRect as Numa = LeptonicaSharp._All.pixGetCmapHistogramInRect(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetCmapHistogramInRect",TestPix, RESpixGetCmapHistogramInRect,{"Dim RESpixGetCmapHistogramInRect as Numa = LeptonicaSharp._All.pixGetCmapHistogramInRect(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixCountRGBColors as Integer = LeptonicaSharp._All.pixCountRGBColors(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCountRGBColors",TestPix, RESpixCountRGBColors,{"Dim RESpixCountRGBColors as Integer = LeptonicaSharp._All.pixCountRGBColors(TestPix )"},1)

' Dim RESpixGetColorAmapHistogram as L_Rbtree = LeptonicaSharp._All.pixGetColorAmapHistogram(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColorAmapHistogram",TestPix, RESpixGetColorAmapHistogram,{"Dim RESpixGetColorAmapHistogram as L_Rbtree = LeptonicaSharp._All.pixGetColorAmapHistogram(TestPix ,TestPix )"},1)

' Dim RESamapGetCountForColor as Integer = LeptonicaSharp._All.amapGetCountForColor(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("amapGetCountForColor",TestPix, RESamapGetCountForColor,{"Dim RESamapGetCountForColor as Integer = LeptonicaSharp._All.amapGetCountForColor(TestPix ,TestPix )"},1)

' Dim RESpixGetRankValue as Integer = LeptonicaSharp._All.pixGetRankValue(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRankValue",TestPix, RESpixGetRankValue,{"Dim RESpixGetRankValue as Integer = LeptonicaSharp._All.pixGetRankValue(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixGetRankValueMaskedRGB as Integer = LeptonicaSharp._All.pixGetRankValueMaskedRGB(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRankValueMaskedRGB",TestPix, RESpixGetRankValueMaskedRGB,{"Dim RESpixGetRankValueMaskedRGB as Integer = LeptonicaSharp._All.pixGetRankValueMaskedRGB(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetRankValueMasked as Integer = LeptonicaSharp._All.pixGetRankValueMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRankValueMasked",TestPix, RESpixGetRankValueMasked,{"Dim RESpixGetRankValueMasked as Integer = LeptonicaSharp._All.pixGetRankValueMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,Nothing )"},1)

' Dim RESpixGetPixelAverage as Integer = LeptonicaSharp._All.pixGetPixelAverage(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetPixelAverage",TestPix, RESpixGetPixelAverage,{"Dim RESpixGetPixelAverage as Integer = LeptonicaSharp._All.pixGetPixelAverage(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixGetPixelStats as Integer = LeptonicaSharp._All.pixGetPixelStats(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetPixelStats",TestPix, RESpixGetPixelStats,{"Dim RESpixGetPixelStats as Integer = LeptonicaSharp._All.pixGetPixelStats(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESpixGetAverageMaskedRGB as Integer = LeptonicaSharp._All.pixGetAverageMaskedRGB(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAverageMaskedRGB",TestPix, RESpixGetAverageMaskedRGB,{"Dim RESpixGetAverageMaskedRGB as Integer = LeptonicaSharp._All.pixGetAverageMaskedRGB(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetAverageMasked as Integer = LeptonicaSharp._All.pixGetAverageMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAverageMasked",TestPix, RESpixGetAverageMasked,{"Dim RESpixGetAverageMasked as Integer = LeptonicaSharp._All.pixGetAverageMasked(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixGetAverageTiledRGB as Integer = LeptonicaSharp._All.pixGetAverageTiledRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAverageTiledRGB",TestPix, RESpixGetAverageTiledRGB,{"Dim RESpixGetAverageTiledRGB as Integer = LeptonicaSharp._All.pixGetAverageTiledRGB(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetAverageTiled as Pix = LeptonicaSharp._All.pixGetAverageTiled(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAverageTiled",TestPix, RESpixGetAverageTiled,{"Dim RESpixGetAverageTiled as Pix = LeptonicaSharp._All.pixGetAverageTiled(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRowStats as Integer = LeptonicaSharp._All.pixRowStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRowStats",TestPix, RESpixRowStats,{"Dim RESpixRowStats as Integer = LeptonicaSharp._All.pixRowStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixColumnStats as Integer = LeptonicaSharp._All.pixColumnStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColumnStats",TestPix, RESpixColumnStats,{"Dim RESpixColumnStats as Integer = LeptonicaSharp._All.pixColumnStats(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetRangeValues as Integer = LeptonicaSharp._All.pixGetRangeValues(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRangeValues",TestPix, RESpixGetRangeValues,{"Dim RESpixGetRangeValues as Integer = LeptonicaSharp._All.pixGetRangeValues(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixGetExtremeValue as Integer = LeptonicaSharp._All.pixGetExtremeValue(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetExtremeValue",TestPix, RESpixGetExtremeValue,{"Dim RESpixGetExtremeValue as Integer = LeptonicaSharp._All.pixGetExtremeValue(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetMaxValueInRect as Integer = LeptonicaSharp._All.pixGetMaxValueInRect(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetMaxValueInRect",TestPix, RESpixGetMaxValueInRect,{"Dim RESpixGetMaxValueInRect as Integer = LeptonicaSharp._All.pixGetMaxValueInRect(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetBinnedComponentRange as Integer = LeptonicaSharp._All.pixGetBinnedComponentRange(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBinnedComponentRange",TestPix, RESpixGetBinnedComponentRange,{"Dim RESpixGetBinnedComponentRange as Integer = LeptonicaSharp._All.pixGetBinnedComponentRange(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixGetRankColorArray as Integer = LeptonicaSharp._All.pixGetRankColorArray(TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRankColorArray",TestPix, RESpixGetRankColorArray,{"Dim RESpixGetRankColorArray as Integer = LeptonicaSharp._All.pixGetRankColorArray(TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),TestPix ,Nothing )"},1)

' Dim RESpixGetBinnedColor as Integer = LeptonicaSharp._All.pixGetBinnedColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetBinnedColor",TestPix, RESpixGetBinnedColor,{"Dim RESpixGetBinnedColor as Integer = LeptonicaSharp._All.pixGetBinnedColor(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Byte(),TestPix )"},1)

' Dim RESpixDisplayColorArray as Pix = LeptonicaSharp._All.pixDisplayColorArray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayColorArray",TestPix, RESpixDisplayColorArray,{"Dim RESpixDisplayColorArray as Pix = LeptonicaSharp._All.pixDisplayColorArray(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRankBinByStrip as Pix = LeptonicaSharp._All.pixRankBinByStrip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankBinByStrip",TestPix, RESpixRankBinByStrip,{"Dim RESpixRankBinByStrip as Pix = LeptonicaSharp._All.pixRankBinByStrip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaGetAlignedStats as Pix = LeptonicaSharp._All.pixaGetAlignedStats(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetAlignedStats",TestPix, RESpixaGetAlignedStats,{"Dim RESpixaGetAlignedStats as Pix = LeptonicaSharp._All.pixaGetAlignedStats(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaExtractColumnFromEachPix as Integer = LeptonicaSharp._All.pixaExtractColumnFromEachPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaExtractColumnFromEachPix",TestPix, RESpixaExtractColumnFromEachPix,{"Dim RESpixaExtractColumnFromEachPix as Integer = LeptonicaSharp._All.pixaExtractColumnFromEachPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRowStats as Integer = LeptonicaSharp._All.pixGetRowStats(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRowStats",TestPix, RESpixGetRowStats,{"Dim RESpixGetRowStats as Integer = LeptonicaSharp._All.pixGetRowStats(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetColumnStats as Integer = LeptonicaSharp._All.pixGetColumnStats(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetColumnStats",TestPix, RESpixGetColumnStats,{"Dim RESpixGetColumnStats as Integer = LeptonicaSharp._All.pixGetColumnStats(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetPixelColumn as Integer = LeptonicaSharp._All.pixSetPixelColumn(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetPixelColumn",TestPix, RESpixSetPixelColumn,{"Dim RESpixSetPixelColumn as Integer = LeptonicaSharp._All.pixSetPixelColumn(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdForFgBg as Integer = LeptonicaSharp._All.pixThresholdForFgBg(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdForFgBg",TestPix, RESpixThresholdForFgBg,{"Dim RESpixThresholdForFgBg as Integer = LeptonicaSharp._All.pixThresholdForFgBg(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixSplitDistributionFgBg as Integer = LeptonicaSharp._All.pixSplitDistributionFgBg(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSplitDistributionFgBg",TestPix, RESpixSplitDistributionFgBg,{"Dim RESpixSplitDistributionFgBg as Integer = LeptonicaSharp._All.pixSplitDistributionFgBg(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixaFindDimensions as Integer = LeptonicaSharp._All.pixaFindDimensions(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindDimensions",TestPix, RESpixaFindDimensions,{"Dim RESpixaFindDimensions as Integer = LeptonicaSharp._All.pixaFindDimensions(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixFindAreaPerimRatio as Integer = LeptonicaSharp._All.pixFindAreaPerimRatio(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindAreaPerimRatio",TestPix, RESpixFindAreaPerimRatio,{"Dim RESpixFindAreaPerimRatio as Integer = LeptonicaSharp._All.pixFindAreaPerimRatio(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixaFindPerimToAreaRatio as Numa = LeptonicaSharp._All.pixaFindPerimToAreaRatio(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindPerimToAreaRatio",TestPix, RESpixaFindPerimToAreaRatio,{"Dim RESpixaFindPerimToAreaRatio as Numa = LeptonicaSharp._All.pixaFindPerimToAreaRatio(TestPix )"},1)

' Dim RESpixFindPerimToAreaRatio as Integer = LeptonicaSharp._All.pixFindPerimToAreaRatio(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindPerimToAreaRatio",TestPix, RESpixFindPerimToAreaRatio,{"Dim RESpixFindPerimToAreaRatio as Integer = LeptonicaSharp._All.pixFindPerimToAreaRatio(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixaFindPerimSizeRatio as Numa = LeptonicaSharp._All.pixaFindPerimSizeRatio(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindPerimSizeRatio",TestPix, RESpixaFindPerimSizeRatio,{"Dim RESpixaFindPerimSizeRatio as Numa = LeptonicaSharp._All.pixaFindPerimSizeRatio(TestPix )"},1)

' Dim RESpixFindPerimSizeRatio as Integer = LeptonicaSharp._All.pixFindPerimSizeRatio(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindPerimSizeRatio",TestPix, RESpixFindPerimSizeRatio,{"Dim RESpixFindPerimSizeRatio as Integer = LeptonicaSharp._All.pixFindPerimSizeRatio(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixaFindAreaFraction as Numa = LeptonicaSharp._All.pixaFindAreaFraction(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindAreaFraction",TestPix, RESpixaFindAreaFraction,{"Dim RESpixaFindAreaFraction as Numa = LeptonicaSharp._All.pixaFindAreaFraction(TestPix )"},1)

' Dim RESpixFindAreaFraction as Integer = LeptonicaSharp._All.pixFindAreaFraction(TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindAreaFraction",TestPix, RESpixFindAreaFraction,{"Dim RESpixFindAreaFraction as Integer = LeptonicaSharp._All.pixFindAreaFraction(TestPix ,Nothing ,New Single)"},1)

' Dim RESpixaFindAreaFractionMasked as Numa = LeptonicaSharp._All.pixaFindAreaFractionMasked(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindAreaFractionMasked",TestPix, RESpixaFindAreaFractionMasked,{"Dim RESpixaFindAreaFractionMasked as Numa = LeptonicaSharp._All.pixaFindAreaFractionMasked(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixFindAreaFractionMasked as Integer = LeptonicaSharp._All.pixFindAreaFractionMasked(TestPix ,Nothing ,TestPix ,Nothing ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindAreaFractionMasked",TestPix, RESpixFindAreaFractionMasked,{"Dim RESpixFindAreaFractionMasked as Integer = LeptonicaSharp._All.pixFindAreaFractionMasked(TestPix ,Nothing ,TestPix ,Nothing ,New Single)"},1)

' Dim RESpixaFindWidthHeightRatio as Numa = LeptonicaSharp._All.pixaFindWidthHeightRatio(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindWidthHeightRatio",TestPix, RESpixaFindWidthHeightRatio,{"Dim RESpixaFindWidthHeightRatio as Numa = LeptonicaSharp._All.pixaFindWidthHeightRatio(TestPix )"},1)

' Dim RESpixaFindWidthHeightProduct as Numa = LeptonicaSharp._All.pixaFindWidthHeightProduct(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindWidthHeightProduct",TestPix, RESpixaFindWidthHeightProduct,{"Dim RESpixaFindWidthHeightProduct as Numa = LeptonicaSharp._All.pixaFindWidthHeightProduct(TestPix )"},1)

' Dim RESpixFindOverlapFraction as Integer = LeptonicaSharp._All.pixFindOverlapFraction(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindOverlapFraction",TestPix, RESpixFindOverlapFraction,{"Dim RESpixFindOverlapFraction as Integer = LeptonicaSharp._All.pixFindOverlapFraction(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Single,Nothing )"},1)

' Dim RESpixFindRectangleComps as Boxa = LeptonicaSharp._All.pixFindRectangleComps(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindRectangleComps",TestPix, RESpixFindRectangleComps,{"Dim RESpixFindRectangleComps as Boxa = LeptonicaSharp._All.pixFindRectangleComps(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConformsToRectangle as Integer = LeptonicaSharp._All.pixConformsToRectangle(TestPix ,Nothing ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConformsToRectangle",TestPix, RESpixConformsToRectangle,{"Dim RESpixConformsToRectangle as Integer = LeptonicaSharp._All.pixConformsToRectangle(TestPix ,Nothing ,TestPix ,New Integer)"},1)

' Dim RESpixClipRectangles as Pixa = LeptonicaSharp._All.pixClipRectangles(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipRectangles",TestPix, RESpixClipRectangles,{"Dim RESpixClipRectangles as Pixa = LeptonicaSharp._All.pixClipRectangles(TestPix ,TestPix )"},1)

' Dim RESpixClipRectangle as Pix = LeptonicaSharp._All.pixClipRectangle(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipRectangle",TestPix, RESpixClipRectangle,{"Dim RESpixClipRectangle as Pix = LeptonicaSharp._All.pixClipRectangle(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixClipMasked as Pix = LeptonicaSharp._All.pixClipMasked(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipMasked",TestPix, RESpixClipMasked,{"Dim RESpixClipMasked as Pix = LeptonicaSharp._All.pixClipMasked(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixCropToMatch as Integer = LeptonicaSharp._All.pixCropToMatch(TestPix ,TestPix ,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCropToMatch",TestPix, RESpixCropToMatch,{"Dim RESpixCropToMatch as Integer = LeptonicaSharp._All.pixCropToMatch(TestPix ,TestPix ,New Pix,New Pix)"},1)

' Dim RESpixCropToSize as Pix = LeptonicaSharp._All.pixCropToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCropToSize",TestPix, RESpixCropToSize,{"Dim RESpixCropToSize as Pix = LeptonicaSharp._All.pixCropToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixResizeToMatch as Pix = LeptonicaSharp._All.pixResizeToMatch(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixResizeToMatch",TestPix, RESpixResizeToMatch,{"Dim RESpixResizeToMatch as Pix = LeptonicaSharp._All.pixResizeToMatch(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixMakeFrameMask as Pix = LeptonicaSharp._All.pixMakeFrameMask(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeFrameMask",TestPix, RESpixMakeFrameMask,{"Dim RESpixMakeFrameMask as Pix = LeptonicaSharp._All.pixMakeFrameMask(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMakeCoveringOfRectangles as Pix = LeptonicaSharp._All.pixMakeCoveringOfRectangles(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMakeCoveringOfRectangles",TestPix, RESpixMakeCoveringOfRectangles,{"Dim RESpixMakeCoveringOfRectangles as Pix = LeptonicaSharp._All.pixMakeCoveringOfRectangles(TestPix ,TestPix )"},1)

' Dim RESpixFractionFgInMask as Integer = LeptonicaSharp._All.pixFractionFgInMask(TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFractionFgInMask",TestPix, RESpixFractionFgInMask,{"Dim RESpixFractionFgInMask as Integer = LeptonicaSharp._All.pixFractionFgInMask(TestPix ,TestPix ,New Single)"},1)

' Dim RESpixClipToForeground as Integer = LeptonicaSharp._All.pixClipToForeground(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipToForeground",TestPix, RESpixClipToForeground,{"Dim RESpixClipToForeground as Integer = LeptonicaSharp._All.pixClipToForeground(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixTestClipToForeground as Integer = LeptonicaSharp._All.pixTestClipToForeground(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTestClipToForeground",TestPix, RESpixTestClipToForeground,{"Dim RESpixTestClipToForeground as Integer = LeptonicaSharp._All.pixTestClipToForeground(TestPix ,New Integer)"},1)

' Dim RESpixClipBoxToForeground as Integer = LeptonicaSharp._All.pixClipBoxToForeground(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipBoxToForeground",TestPix, RESpixClipBoxToForeground,{"Dim RESpixClipBoxToForeground as Integer = LeptonicaSharp._All.pixClipBoxToForeground(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixScanForForeground as Integer = LeptonicaSharp._All.pixScanForForeground(TestPix ,Nothing ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScanForForeground",TestPix, RESpixScanForForeground,{"Dim RESpixScanForForeground as Integer = LeptonicaSharp._All.pixScanForForeground(TestPix ,Nothing ,TestPix ,New Integer)"},1)

' Dim RESpixClipBoxToEdges as Integer = LeptonicaSharp._All.pixClipBoxToEdges(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixClipBoxToEdges",TestPix, RESpixClipBoxToEdges,{"Dim RESpixClipBoxToEdges as Integer = LeptonicaSharp._All.pixClipBoxToEdges(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScanForEdge as Integer = LeptonicaSharp._All.pixScanForEdge(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScanForEdge",TestPix, RESpixScanForEdge,{"Dim RESpixScanForEdge as Integer = LeptonicaSharp._All.pixScanForEdge(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixExtractOnLine as Numa = LeptonicaSharp._All.pixExtractOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractOnLine",TestPix, RESpixExtractOnLine,{"Dim RESpixExtractOnLine as Numa = LeptonicaSharp._All.pixExtractOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAverageOnLine as Single = LeptonicaSharp._All.pixAverageOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAverageOnLine",TestPix, RESpixAverageOnLine,{"Dim RESpixAverageOnLine as Single = LeptonicaSharp._All.pixAverageOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAverageIntensityProfile as Numa = LeptonicaSharp._All.pixAverageIntensityProfile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAverageIntensityProfile",TestPix, RESpixAverageIntensityProfile,{"Dim RESpixAverageIntensityProfile as Numa = LeptonicaSharp._All.pixAverageIntensityProfile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReversalProfile as Numa = LeptonicaSharp._All.pixReversalProfile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReversalProfile",TestPix, RESpixReversalProfile,{"Dim RESpixReversalProfile as Numa = LeptonicaSharp._All.pixReversalProfile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWindowedVarianceOnLine as Integer = LeptonicaSharp._All.pixWindowedVarianceOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWindowedVarianceOnLine",TestPix, RESpixWindowedVarianceOnLine,{"Dim RESpixWindowedVarianceOnLine as Integer = LeptonicaSharp._All.pixWindowedVarianceOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Numa)"},1)

' Dim RESpixMinMaxNearLine as Integer = LeptonicaSharp._All.pixMinMaxNearLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMinMaxNearLine",TestPix, RESpixMinMaxNearLine,{"Dim RESpixMinMaxNearLine as Integer = LeptonicaSharp._All.pixMinMaxNearLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixRankRowTransform as Pix = LeptonicaSharp._All.pixRankRowTransform(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankRowTransform",TestPix, RESpixRankRowTransform,{"Dim RESpixRankRowTransform as Pix = LeptonicaSharp._All.pixRankRowTransform(TestPix )"},1)

' Dim RESpixRankColumnTransform as Pix = LeptonicaSharp._All.pixRankColumnTransform(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankColumnTransform",TestPix, RESpixRankColumnTransform,{"Dim RESpixRankColumnTransform as Pix = LeptonicaSharp._All.pixRankColumnTransform(TestPix )"},1)

' Dim RESpixaCreate as Pixa = LeptonicaSharp._All.pixaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCreate",TestPix, RESpixaCreate,{"Dim RESpixaCreate as Pixa = LeptonicaSharp._All.pixaCreate(TestPix )"},1)

' Dim RESpixaCreateFromPix as Pixa = LeptonicaSharp._All.pixaCreateFromPix(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCreateFromPix",TestPix, RESpixaCreateFromPix,{"Dim RESpixaCreateFromPix as Pixa = LeptonicaSharp._All.pixaCreateFromPix(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaCreateFromBoxa as Pixa = LeptonicaSharp._All.pixaCreateFromBoxa(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCreateFromBoxa",TestPix, RESpixaCreateFromBoxa,{"Dim RESpixaCreateFromBoxa as Pixa = LeptonicaSharp._All.pixaCreateFromBoxa(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSplitPix as Pixa = LeptonicaSharp._All.pixaSplitPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSplitPix",TestPix, RESpixaSplitPix,{"Dim RESpixaSplitPix as Pixa = LeptonicaSharp._All.pixaSplitPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDestroy as Object = LeptonicaSharp._All.pixaDestroy(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDestroy",TestPix, RESpixaDestroy,{"Dim RESpixaDestroy as Object = LeptonicaSharp._All.pixaDestroy(Nothing )"},1)

' Dim RESpixaCopy as Pixa = LeptonicaSharp._All.pixaCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCopy",TestPix, RESpixaCopy,{"Dim RESpixaCopy as Pixa = LeptonicaSharp._All.pixaCopy(TestPix ,TestPix )"},1)

' Dim RESpixaAddPix as Integer = LeptonicaSharp._All.pixaAddPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddPix",TestPix, RESpixaAddPix,{"Dim RESpixaAddPix as Integer = LeptonicaSharp._All.pixaAddPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaAddBox as Integer = LeptonicaSharp._All.pixaAddBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddBox",TestPix, RESpixaAddBox,{"Dim RESpixaAddBox as Integer = LeptonicaSharp._All.pixaAddBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaExtendArrayToSize as Integer = LeptonicaSharp._All.pixaExtendArrayToSize(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaExtendArrayToSize",TestPix, RESpixaExtendArrayToSize,{"Dim RESpixaExtendArrayToSize as Integer = LeptonicaSharp._All.pixaExtendArrayToSize(TestPix ,TestPix )"},1)

' Dim RESpixaGetCount as Integer = LeptonicaSharp._All.pixaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetCount",TestPix, RESpixaGetCount,{"Dim RESpixaGetCount as Integer = LeptonicaSharp._All.pixaGetCount(TestPix )"},1)

' Dim RESpixaChangeRefcount as Integer = LeptonicaSharp._All.pixaChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaChangeRefcount",TestPix, RESpixaChangeRefcount,{"Dim RESpixaChangeRefcount as Integer = LeptonicaSharp._All.pixaChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESpixaGetPix as Pix = LeptonicaSharp._All.pixaGetPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetPix",TestPix, RESpixaGetPix,{"Dim RESpixaGetPix as Pix = LeptonicaSharp._All.pixaGetPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaGetPixDimensions as Integer = LeptonicaSharp._All.pixaGetPixDimensions(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetPixDimensions",TestPix, RESpixaGetPixDimensions,{"Dim RESpixaGetPixDimensions as Integer = LeptonicaSharp._All.pixaGetPixDimensions(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixaGetBoxa as Boxa = LeptonicaSharp._All.pixaGetBoxa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetBoxa",TestPix, RESpixaGetBoxa,{"Dim RESpixaGetBoxa as Boxa = LeptonicaSharp._All.pixaGetBoxa(TestPix ,TestPix )"},1)

' Dim RESpixaGetBoxaCount as Integer = LeptonicaSharp._All.pixaGetBoxaCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetBoxaCount",TestPix, RESpixaGetBoxaCount,{"Dim RESpixaGetBoxaCount as Integer = LeptonicaSharp._All.pixaGetBoxaCount(TestPix )"},1)

' Dim RESpixaGetBox as Box = LeptonicaSharp._All.pixaGetBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetBox",TestPix, RESpixaGetBox,{"Dim RESpixaGetBox as Box = LeptonicaSharp._All.pixaGetBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaGetBoxGeometry as Integer = LeptonicaSharp._All.pixaGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetBoxGeometry",TestPix, RESpixaGetBoxGeometry,{"Dim RESpixaGetBoxGeometry as Integer = LeptonicaSharp._All.pixaGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixaSetBoxa as Integer = LeptonicaSharp._All.pixaSetBoxa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSetBoxa",TestPix, RESpixaSetBoxa,{"Dim RESpixaSetBoxa as Integer = LeptonicaSharp._All.pixaSetBoxa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaGetPixArray as Pix = LeptonicaSharp._All.pixaGetPixArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetPixArray",TestPix, RESpixaGetPixArray,{"Dim RESpixaGetPixArray as Pix = LeptonicaSharp._All.pixaGetPixArray(TestPix )"},1)

' Dim RESpixaVerifyDepth as Integer = LeptonicaSharp._All.pixaVerifyDepth(TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaVerifyDepth",TestPix, RESpixaVerifyDepth,{"Dim RESpixaVerifyDepth as Integer = LeptonicaSharp._All.pixaVerifyDepth(TestPix ,New Integer,Nothing )"},1)

' Dim RESpixaVerifyDimensions as Integer = LeptonicaSharp._All.pixaVerifyDimensions(TestPix ,New Integer,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaVerifyDimensions",TestPix, RESpixaVerifyDimensions,{"Dim RESpixaVerifyDimensions as Integer = LeptonicaSharp._All.pixaVerifyDimensions(TestPix ,New Integer,Nothing ,Nothing )"},1)

' Dim RESpixaIsFull as Integer = LeptonicaSharp._All.pixaIsFull(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaIsFull",TestPix, RESpixaIsFull,{"Dim RESpixaIsFull as Integer = LeptonicaSharp._All.pixaIsFull(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaCountText as Integer = LeptonicaSharp._All.pixaCountText(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCountText",TestPix, RESpixaCountText,{"Dim RESpixaCountText as Integer = LeptonicaSharp._All.pixaCountText(TestPix ,New Integer)"},1)

' Dim RESpixaSetText as Integer = LeptonicaSharp._All.pixaSetText(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSetText",TestPix, RESpixaSetText,{"Dim RESpixaSetText as Integer = LeptonicaSharp._All.pixaSetText(TestPix ,Nothing )"},1)

' Dim RESpixaGetLinePtrs as IntPtr = LeptonicaSharp._All.pixaGetLinePtrs(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetLinePtrs",TestPix, RESpixaGetLinePtrs,{"Dim RESpixaGetLinePtrs as IntPtr = LeptonicaSharp._All.pixaGetLinePtrs(TestPix ,Nothing )"},1)

' Dim RESpixaWriteStreamInfo as Integer = LeptonicaSharp._All.pixaWriteStreamInfo(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteStreamInfo",TestPix, RESpixaWriteStreamInfo,{"Dim RESpixaWriteStreamInfo as Integer = LeptonicaSharp._All.pixaWriteStreamInfo(TestPix ,TestPix )"},1)

' Dim RESpixaReplacePix as Integer = LeptonicaSharp._All.pixaReplacePix(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReplacePix",TestPix, RESpixaReplacePix,{"Dim RESpixaReplacePix as Integer = LeptonicaSharp._All.pixaReplacePix(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaInsertPix as Integer = LeptonicaSharp._All.pixaInsertPix(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaInsertPix",TestPix, RESpixaInsertPix,{"Dim RESpixaInsertPix as Integer = LeptonicaSharp._All.pixaInsertPix(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaRemovePix as Integer = LeptonicaSharp._All.pixaRemovePix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRemovePix",TestPix, RESpixaRemovePix,{"Dim RESpixaRemovePix as Integer = LeptonicaSharp._All.pixaRemovePix(TestPix ,TestPix )"},1)

' Dim RESpixaRemovePixAndSave as Integer = LeptonicaSharp._All.pixaRemovePixAndSave(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRemovePixAndSave",TestPix, RESpixaRemovePixAndSave,{"Dim RESpixaRemovePixAndSave as Integer = LeptonicaSharp._All.pixaRemovePixAndSave(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaInitFull as Integer = LeptonicaSharp._All.pixaInitFull(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaInitFull",TestPix, RESpixaInitFull,{"Dim RESpixaInitFull as Integer = LeptonicaSharp._All.pixaInitFull(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaClear as Integer = LeptonicaSharp._All.pixaClear(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaClear",TestPix, RESpixaClear,{"Dim RESpixaClear as Integer = LeptonicaSharp._All.pixaClear(TestPix )"},1)

' Dim RESpixaJoin as Integer = LeptonicaSharp._All.pixaJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaJoin",TestPix, RESpixaJoin,{"Dim RESpixaJoin as Integer = LeptonicaSharp._All.pixaJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaInterleave as Pixa = LeptonicaSharp._All.pixaInterleave(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaInterleave",TestPix, RESpixaInterleave,{"Dim RESpixaInterleave as Pixa = LeptonicaSharp._All.pixaInterleave(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaJoin as Integer = LeptonicaSharp._All.pixaaJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaJoin",TestPix, RESpixaaJoin,{"Dim RESpixaaJoin as Integer = LeptonicaSharp._All.pixaaJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaaCreate as Pixaa = LeptonicaSharp._All.pixaaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaCreate",TestPix, RESpixaaCreate,{"Dim RESpixaaCreate as Pixaa = LeptonicaSharp._All.pixaaCreate(TestPix )"},1)

' Dim RESpixaaCreateFromPixa as Pixaa = LeptonicaSharp._All.pixaaCreateFromPixa(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaCreateFromPixa",TestPix, RESpixaaCreateFromPixa,{"Dim RESpixaaCreateFromPixa as Pixaa = LeptonicaSharp._All.pixaaCreateFromPixa(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaDestroy as Object = LeptonicaSharp._All.pixaaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaDestroy",TestPix, RESpixaaDestroy,{"Dim RESpixaaDestroy as Object = LeptonicaSharp._All.pixaaDestroy(TestPix )"},1)

' Dim RESpixaaAddPixa as Integer = LeptonicaSharp._All.pixaaAddPixa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaAddPixa",TestPix, RESpixaaAddPixa,{"Dim RESpixaaAddPixa as Integer = LeptonicaSharp._All.pixaaAddPixa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaExtendArray as Integer = LeptonicaSharp._All.pixaaExtendArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaExtendArray",TestPix, RESpixaaExtendArray,{"Dim RESpixaaExtendArray as Integer = LeptonicaSharp._All.pixaaExtendArray(TestPix )"},1)

' Dim RESpixaaAddPix as Integer = LeptonicaSharp._All.pixaaAddPix(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaAddPix",TestPix, RESpixaaAddPix,{"Dim RESpixaaAddPix as Integer = LeptonicaSharp._All.pixaaAddPix(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixaaAddBox as Integer = LeptonicaSharp._All.pixaaAddBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaAddBox",TestPix, RESpixaaAddBox,{"Dim RESpixaaAddBox as Integer = LeptonicaSharp._All.pixaaAddBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaGetCount as Integer = LeptonicaSharp._All.pixaaGetCount(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaGetCount",TestPix, RESpixaaGetCount,{"Dim RESpixaaGetCount as Integer = LeptonicaSharp._All.pixaaGetCount(TestPix ,Nothing )"},1)

' Dim RESpixaaGetPixa as Pixa = LeptonicaSharp._All.pixaaGetPixa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaGetPixa",TestPix, RESpixaaGetPixa,{"Dim RESpixaaGetPixa as Pixa = LeptonicaSharp._All.pixaaGetPixa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaGetBoxa as Boxa = LeptonicaSharp._All.pixaaGetBoxa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaGetBoxa",TestPix, RESpixaaGetBoxa,{"Dim RESpixaaGetBoxa as Boxa = LeptonicaSharp._All.pixaaGetBoxa(TestPix ,TestPix )"},1)

' Dim RESpixaaGetPix as Pix = LeptonicaSharp._All.pixaaGetPix(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaGetPix",TestPix, RESpixaaGetPix,{"Dim RESpixaaGetPix as Pix = LeptonicaSharp._All.pixaaGetPix(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaVerifyDepth as Integer = LeptonicaSharp._All.pixaaVerifyDepth(TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaVerifyDepth",TestPix, RESpixaaVerifyDepth,{"Dim RESpixaaVerifyDepth as Integer = LeptonicaSharp._All.pixaaVerifyDepth(TestPix ,New Integer,Nothing )"},1)

' Dim RESpixaaVerifyDimensions as Integer = LeptonicaSharp._All.pixaaVerifyDimensions(TestPix ,New Integer,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaVerifyDimensions",TestPix, RESpixaaVerifyDimensions,{"Dim RESpixaaVerifyDimensions as Integer = LeptonicaSharp._All.pixaaVerifyDimensions(TestPix ,New Integer,Nothing ,Nothing )"},1)

' Dim RESpixaaIsFull as Integer = LeptonicaSharp._All.pixaaIsFull(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaIsFull",TestPix, RESpixaaIsFull,{"Dim RESpixaaIsFull as Integer = LeptonicaSharp._All.pixaaIsFull(TestPix ,New Integer)"},1)

' Dim RESpixaaInitFull as Integer = LeptonicaSharp._All.pixaaInitFull(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaInitFull",TestPix, RESpixaaInitFull,{"Dim RESpixaaInitFull as Integer = LeptonicaSharp._All.pixaaInitFull(TestPix ,TestPix )"},1)

' Dim RESpixaaReplacePixa as Integer = LeptonicaSharp._All.pixaaReplacePixa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaReplacePixa",TestPix, RESpixaaReplacePixa,{"Dim RESpixaaReplacePixa as Integer = LeptonicaSharp._All.pixaaReplacePixa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaClear as Integer = LeptonicaSharp._All.pixaaClear(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaClear",TestPix, RESpixaaClear,{"Dim RESpixaaClear as Integer = LeptonicaSharp._All.pixaaClear(TestPix )"},1)

' Dim RESpixaaTruncate as Integer = LeptonicaSharp._All.pixaaTruncate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaTruncate",TestPix, RESpixaaTruncate,{"Dim RESpixaaTruncate as Integer = LeptonicaSharp._All.pixaaTruncate(TestPix )"},1)

' Dim RESpixaRead as Pixa = LeptonicaSharp._All.pixaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRead",TestPix, RESpixaRead,{"Dim RESpixaRead as Pixa = LeptonicaSharp._All.pixaRead(TestPix )"},1)

' Dim RESpixaReadStream as Pixa = LeptonicaSharp._All.pixaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadStream",TestPix, RESpixaReadStream,{"Dim RESpixaReadStream as Pixa = LeptonicaSharp._All.pixaReadStream(TestPix )"},1)

' Dim RESpixaReadMem as Pixa = LeptonicaSharp._All.pixaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadMem",TestPix, RESpixaReadMem,{"Dim RESpixaReadMem as Pixa = LeptonicaSharp._All.pixaReadMem(TestPix ,TestPix )"},1)

' Dim RESpixaWriteDebug as Integer = LeptonicaSharp._All.pixaWriteDebug(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteDebug",TestPix, RESpixaWriteDebug,{"Dim RESpixaWriteDebug as Integer = LeptonicaSharp._All.pixaWriteDebug(TestPix ,TestPix )"},1)

' Dim RESpixaWrite as Integer = LeptonicaSharp._All.pixaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWrite",TestPix, RESpixaWrite,{"Dim RESpixaWrite as Integer = LeptonicaSharp._All.pixaWrite(TestPix ,TestPix )"},1)

' Dim RESpixaWriteStream as Integer = LeptonicaSharp._All.pixaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteStream",TestPix, RESpixaWriteStream,{"Dim RESpixaWriteStream as Integer = LeptonicaSharp._All.pixaWriteStream(TestPix ,TestPix )"},1)

' Dim RESpixaWriteMem as Integer = LeptonicaSharp._All.pixaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteMem",TestPix, RESpixaWriteMem,{"Dim RESpixaWriteMem as Integer = LeptonicaSharp._All.pixaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixaReadBoth as Pixa = LeptonicaSharp._All.pixaReadBoth(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadBoth",TestPix, RESpixaReadBoth,{"Dim RESpixaReadBoth as Pixa = LeptonicaSharp._All.pixaReadBoth(TestPix )"},1)

' Dim RESpixaaReadFromFiles as Pixaa = LeptonicaSharp._All.pixaaReadFromFiles(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaReadFromFiles",TestPix, RESpixaaReadFromFiles,{"Dim RESpixaaReadFromFiles as Pixaa = LeptonicaSharp._All.pixaaReadFromFiles(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaaRead as Pixaa = LeptonicaSharp._All.pixaaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaRead",TestPix, RESpixaaRead,{"Dim RESpixaaRead as Pixaa = LeptonicaSharp._All.pixaaRead(TestPix )"},1)

' Dim RESpixaaReadStream as Pixaa = LeptonicaSharp._All.pixaaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaReadStream",TestPix, RESpixaaReadStream,{"Dim RESpixaaReadStream as Pixaa = LeptonicaSharp._All.pixaaReadStream(TestPix )"},1)

' Dim RESpixaaReadMem as Pixaa = LeptonicaSharp._All.pixaaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaReadMem",TestPix, RESpixaaReadMem,{"Dim RESpixaaReadMem as Pixaa = LeptonicaSharp._All.pixaaReadMem(TestPix ,TestPix )"},1)

' Dim RESpixaaWrite as Integer = LeptonicaSharp._All.pixaaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaWrite",TestPix, RESpixaaWrite,{"Dim RESpixaaWrite as Integer = LeptonicaSharp._All.pixaaWrite(TestPix ,TestPix )"},1)

' Dim RESpixaaWriteStream as Integer = LeptonicaSharp._All.pixaaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaWriteStream",TestPix, RESpixaaWriteStream,{"Dim RESpixaaWriteStream as Integer = LeptonicaSharp._All.pixaaWriteStream(TestPix ,TestPix )"},1)

' Dim RESpixaaWriteMem as Integer = LeptonicaSharp._All.pixaaWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaWriteMem",TestPix, RESpixaaWriteMem,{"Dim RESpixaaWriteMem as Integer = LeptonicaSharp._All.pixaaWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixaccCreate as Pixacc = LeptonicaSharp._All.pixaccCreate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccCreate",TestPix, RESpixaccCreate,{"Dim RESpixaccCreate as Pixacc = LeptonicaSharp._All.pixaccCreate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaccCreateFromPix as Pixacc = LeptonicaSharp._All.pixaccCreateFromPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccCreateFromPix",TestPix, RESpixaccCreateFromPix,{"Dim RESpixaccCreateFromPix as Pixacc = LeptonicaSharp._All.pixaccCreateFromPix(TestPix ,TestPix )"},1)

' Dim RESpixaccDestroy as Object = LeptonicaSharp._All.pixaccDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccDestroy",TestPix, RESpixaccDestroy,{"Dim RESpixaccDestroy as Object = LeptonicaSharp._All.pixaccDestroy(TestPix )"},1)

' Dim RESpixaccFinal as Pix = LeptonicaSharp._All.pixaccFinal(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccFinal",TestPix, RESpixaccFinal,{"Dim RESpixaccFinal as Pix = LeptonicaSharp._All.pixaccFinal(TestPix ,TestPix )"},1)

' Dim RESpixaccGetPix as Pix = LeptonicaSharp._All.pixaccGetPix(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccGetPix",TestPix, RESpixaccGetPix,{"Dim RESpixaccGetPix as Pix = LeptonicaSharp._All.pixaccGetPix(TestPix )"},1)

' Dim RESpixaccGetOffset as Integer = LeptonicaSharp._All.pixaccGetOffset(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccGetOffset",TestPix, RESpixaccGetOffset,{"Dim RESpixaccGetOffset as Integer = LeptonicaSharp._All.pixaccGetOffset(TestPix )"},1)

' Dim RESpixaccAdd as Integer = LeptonicaSharp._All.pixaccAdd(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccAdd",TestPix, RESpixaccAdd,{"Dim RESpixaccAdd as Integer = LeptonicaSharp._All.pixaccAdd(TestPix ,TestPix )"},1)

' Dim RESpixaccSubtract as Integer = LeptonicaSharp._All.pixaccSubtract(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccSubtract",TestPix, RESpixaccSubtract,{"Dim RESpixaccSubtract as Integer = LeptonicaSharp._All.pixaccSubtract(TestPix ,TestPix )"},1)

' Dim RESpixaccMultConst as Integer = LeptonicaSharp._All.pixaccMultConst(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccMultConst",TestPix, RESpixaccMultConst,{"Dim RESpixaccMultConst as Integer = LeptonicaSharp._All.pixaccMultConst(TestPix ,TestPix )"},1)

' Dim RESpixaccMultConstAccumulate as Integer = LeptonicaSharp._All.pixaccMultConstAccumulate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaccMultConstAccumulate",TestPix, RESpixaccMultConstAccumulate,{"Dim RESpixaccMultConstAccumulate as Integer = LeptonicaSharp._All.pixaccMultConstAccumulate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSelectBySize as Pix = LeptonicaSharp._All.pixSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectBySize",TestPix, RESpixSelectBySize,{"Dim RESpixSelectBySize as Pix = LeptonicaSharp._All.pixSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectBySize as Pixa = LeptonicaSharp._All.pixaSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectBySize",TestPix, RESpixaSelectBySize,{"Dim RESpixaSelectBySize as Pixa = LeptonicaSharp._All.pixaSelectBySize(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaMakeSizeIndicator as Numa = LeptonicaSharp._All.pixaMakeSizeIndicator(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaMakeSizeIndicator",TestPix, RESpixaMakeSizeIndicator,{"Dim RESpixaMakeSizeIndicator as Numa = LeptonicaSharp._All.pixaMakeSizeIndicator(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSelectByPerimToAreaRatio as Pix = LeptonicaSharp._All.pixSelectByPerimToAreaRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectByPerimToAreaRatio",TestPix, RESpixSelectByPerimToAreaRatio,{"Dim RESpixSelectByPerimToAreaRatio as Pix = LeptonicaSharp._All.pixSelectByPerimToAreaRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectByPerimToAreaRatio as Pixa = LeptonicaSharp._All.pixaSelectByPerimToAreaRatio(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectByPerimToAreaRatio",TestPix, RESpixaSelectByPerimToAreaRatio,{"Dim RESpixaSelectByPerimToAreaRatio as Pixa = LeptonicaSharp._All.pixaSelectByPerimToAreaRatio(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSelectByPerimSizeRatio as Pix = LeptonicaSharp._All.pixSelectByPerimSizeRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectByPerimSizeRatio",TestPix, RESpixSelectByPerimSizeRatio,{"Dim RESpixSelectByPerimSizeRatio as Pix = LeptonicaSharp._All.pixSelectByPerimSizeRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectByPerimSizeRatio as Pixa = LeptonicaSharp._All.pixaSelectByPerimSizeRatio(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectByPerimSizeRatio",TestPix, RESpixaSelectByPerimSizeRatio,{"Dim RESpixaSelectByPerimSizeRatio as Pixa = LeptonicaSharp._All.pixaSelectByPerimSizeRatio(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSelectByAreaFraction as Pix = LeptonicaSharp._All.pixSelectByAreaFraction(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectByAreaFraction",TestPix, RESpixSelectByAreaFraction,{"Dim RESpixSelectByAreaFraction as Pix = LeptonicaSharp._All.pixSelectByAreaFraction(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectByAreaFraction as Pixa = LeptonicaSharp._All.pixaSelectByAreaFraction(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectByAreaFraction",TestPix, RESpixaSelectByAreaFraction,{"Dim RESpixaSelectByAreaFraction as Pixa = LeptonicaSharp._All.pixaSelectByAreaFraction(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSelectByWidthHeightRatio as Pix = LeptonicaSharp._All.pixSelectByWidthHeightRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectByWidthHeightRatio",TestPix, RESpixSelectByWidthHeightRatio,{"Dim RESpixSelectByWidthHeightRatio as Pix = LeptonicaSharp._All.pixSelectByWidthHeightRatio(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectByWidthHeightRatio as Pixa = LeptonicaSharp._All.pixaSelectByWidthHeightRatio(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectByWidthHeightRatio",TestPix, RESpixaSelectByWidthHeightRatio,{"Dim RESpixaSelectByWidthHeightRatio as Pixa = LeptonicaSharp._All.pixaSelectByWidthHeightRatio(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectByNumConnComp as Pixa = LeptonicaSharp._All.pixaSelectByNumConnComp(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectByNumConnComp",TestPix, RESpixaSelectByNumConnComp,{"Dim RESpixaSelectByNumConnComp as Pixa = LeptonicaSharp._All.pixaSelectByNumConnComp(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaSelectWithIndicator as Pixa = LeptonicaSharp._All.pixaSelectWithIndicator(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectWithIndicator",TestPix, RESpixaSelectWithIndicator,{"Dim RESpixaSelectWithIndicator as Pixa = LeptonicaSharp._All.pixaSelectWithIndicator(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixRemoveWithIndicator as Integer = LeptonicaSharp._All.pixRemoveWithIndicator(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveWithIndicator",TestPix, RESpixRemoveWithIndicator,{"Dim RESpixRemoveWithIndicator as Integer = LeptonicaSharp._All.pixRemoveWithIndicator(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAddWithIndicator as Integer = LeptonicaSharp._All.pixAddWithIndicator(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddWithIndicator",TestPix, RESpixAddWithIndicator,{"Dim RESpixAddWithIndicator as Integer = LeptonicaSharp._All.pixAddWithIndicator(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSelectWithString as Pixa = LeptonicaSharp._All.pixaSelectWithString(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectWithString",TestPix, RESpixaSelectWithString,{"Dim RESpixaSelectWithString as Pixa = LeptonicaSharp._All.pixaSelectWithString(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaRenderComponent as Pix = LeptonicaSharp._All.pixaRenderComponent(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRenderComponent",TestPix, RESpixaRenderComponent,{"Dim RESpixaRenderComponent as Pix = LeptonicaSharp._All.pixaRenderComponent(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaSort as Pixa = LeptonicaSharp._All.pixaSort(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSort",TestPix, RESpixaSort,{"Dim RESpixaSort as Pixa = LeptonicaSharp._All.pixaSort(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixaBinSort as Pixa = LeptonicaSharp._All.pixaBinSort(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaBinSort",TestPix, RESpixaBinSort,{"Dim RESpixaBinSort as Pixa = LeptonicaSharp._All.pixaBinSort(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixaSortByIndex as Pixa = LeptonicaSharp._All.pixaSortByIndex(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSortByIndex",TestPix, RESpixaSortByIndex,{"Dim RESpixaSortByIndex as Pixa = LeptonicaSharp._All.pixaSortByIndex(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSort2dByIndex as Pixaa = LeptonicaSharp._All.pixaSort2dByIndex(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSort2dByIndex",TestPix, RESpixaSort2dByIndex,{"Dim RESpixaSort2dByIndex as Pixaa = LeptonicaSharp._All.pixaSort2dByIndex(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSelectRange as Pixa = LeptonicaSharp._All.pixaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectRange",TestPix, RESpixaSelectRange,{"Dim RESpixaSelectRange as Pixa = LeptonicaSharp._All.pixaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaSelectRange as Pixaa = LeptonicaSharp._All.pixaaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaSelectRange",TestPix, RESpixaaSelectRange,{"Dim RESpixaaSelectRange as Pixaa = LeptonicaSharp._All.pixaaSelectRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaScaleToSize as Pixaa = LeptonicaSharp._All.pixaaScaleToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaScaleToSize",TestPix, RESpixaaScaleToSize,{"Dim RESpixaaScaleToSize as Pixaa = LeptonicaSharp._All.pixaaScaleToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaScaleToSizeVar as Pixaa = LeptonicaSharp._All.pixaaScaleToSizeVar(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaScaleToSizeVar",TestPix, RESpixaaScaleToSizeVar,{"Dim RESpixaaScaleToSizeVar as Pixaa = LeptonicaSharp._All.pixaaScaleToSizeVar(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaScaleToSize as Pixa = LeptonicaSharp._All.pixaScaleToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaScaleToSize",TestPix, RESpixaScaleToSize,{"Dim RESpixaScaleToSize as Pixa = LeptonicaSharp._All.pixaScaleToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaScaleToSizeRel as Pixa = LeptonicaSharp._All.pixaScaleToSizeRel(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaScaleToSizeRel",TestPix, RESpixaScaleToSizeRel,{"Dim RESpixaScaleToSizeRel as Pixa = LeptonicaSharp._All.pixaScaleToSizeRel(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaScale as Pixa = LeptonicaSharp._All.pixaScale(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaScale",TestPix, RESpixaScale,{"Dim RESpixaScale as Pixa = LeptonicaSharp._All.pixaScale(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaScaleBySampling as Pixa = LeptonicaSharp._All.pixaScaleBySampling(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaScaleBySampling",TestPix, RESpixaScaleBySampling,{"Dim RESpixaScaleBySampling as Pixa = LeptonicaSharp._All.pixaScaleBySampling(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaRotate as Pixa = LeptonicaSharp._All.pixaRotate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRotate",TestPix, RESpixaRotate,{"Dim RESpixaRotate as Pixa = LeptonicaSharp._All.pixaRotate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaRotateOrth as Pixa = LeptonicaSharp._All.pixaRotateOrth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRotateOrth",TestPix, RESpixaRotateOrth,{"Dim RESpixaRotateOrth as Pixa = LeptonicaSharp._All.pixaRotateOrth(TestPix ,TestPix )"},1)

' Dim RESpixaTranslate as Pixa = LeptonicaSharp._All.pixaTranslate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaTranslate",TestPix, RESpixaTranslate,{"Dim RESpixaTranslate as Pixa = LeptonicaSharp._All.pixaTranslate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaAddBorderGeneral as Pixa = LeptonicaSharp._All.pixaAddBorderGeneral(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddBorderGeneral",TestPix, RESpixaAddBorderGeneral,{"Dim RESpixaAddBorderGeneral as Pixa = LeptonicaSharp._All.pixaAddBorderGeneral(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaFlattenToPixa as Pixa = LeptonicaSharp._All.pixaaFlattenToPixa(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaFlattenToPixa",TestPix, RESpixaaFlattenToPixa,{"Dim RESpixaaFlattenToPixa as Pixa = LeptonicaSharp._All.pixaaFlattenToPixa(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixaaSizeRange as Integer = LeptonicaSharp._All.pixaaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaSizeRange",TestPix, RESpixaaSizeRange,{"Dim RESpixaaSizeRange as Integer = LeptonicaSharp._All.pixaaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixaSizeRange as Integer = LeptonicaSharp._All.pixaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSizeRange",TestPix, RESpixaSizeRange,{"Dim RESpixaSizeRange as Integer = LeptonicaSharp._All.pixaSizeRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixaClipToPix as Pixa = LeptonicaSharp._All.pixaClipToPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaClipToPix",TestPix, RESpixaClipToPix,{"Dim RESpixaClipToPix as Pixa = LeptonicaSharp._All.pixaClipToPix(TestPix ,TestPix )"},1)

' Dim RESpixaClipToForeground as Integer = LeptonicaSharp._All.pixaClipToForeground(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaClipToForeground",TestPix, RESpixaClipToForeground,{"Dim RESpixaClipToForeground as Integer = LeptonicaSharp._All.pixaClipToForeground(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaGetRenderingDepth as Integer = LeptonicaSharp._All.pixaGetRenderingDepth(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetRenderingDepth",TestPix, RESpixaGetRenderingDepth,{"Dim RESpixaGetRenderingDepth as Integer = LeptonicaSharp._All.pixaGetRenderingDepth(TestPix ,New Integer)"},1)

' Dim RESpixaHasColor as Integer = LeptonicaSharp._All.pixaHasColor(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaHasColor",TestPix, RESpixaHasColor,{"Dim RESpixaHasColor as Integer = LeptonicaSharp._All.pixaHasColor(TestPix ,New Integer)"},1)

' Dim RESpixaAnyColormaps as Integer = LeptonicaSharp._All.pixaAnyColormaps(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAnyColormaps",TestPix, RESpixaAnyColormaps,{"Dim RESpixaAnyColormaps as Integer = LeptonicaSharp._All.pixaAnyColormaps(TestPix ,New Integer)"},1)

' Dim RESpixaGetDepthInfo as Integer = LeptonicaSharp._All.pixaGetDepthInfo(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaGetDepthInfo",TestPix, RESpixaGetDepthInfo,{"Dim RESpixaGetDepthInfo as Integer = LeptonicaSharp._All.pixaGetDepthInfo(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaConvertToSameDepth as Pixa = LeptonicaSharp._All.pixaConvertToSameDepth(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertToSameDepth",TestPix, RESpixaConvertToSameDepth,{"Dim RESpixaConvertToSameDepth as Pixa = LeptonicaSharp._All.pixaConvertToSameDepth(TestPix )"},1)

' Dim RESpixaEqual as Integer = LeptonicaSharp._All.pixaEqual(TestPix ,TestPix ,TestPix ,Nothing ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaEqual",TestPix, RESpixaEqual,{"Dim RESpixaEqual as Integer = LeptonicaSharp._All.pixaEqual(TestPix ,TestPix ,TestPix ,Nothing ,New Integer)"},1)

' Dim RESpixaSetFullSizeBoxa as Integer = LeptonicaSharp._All.pixaSetFullSizeBoxa(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSetFullSizeBoxa",TestPix, RESpixaSetFullSizeBoxa,{"Dim RESpixaSetFullSizeBoxa as Integer = LeptonicaSharp._All.pixaSetFullSizeBoxa(TestPix )"},1)

' Dim RESpixaDisplay as Pix = LeptonicaSharp._All.pixaDisplay(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplay",TestPix, RESpixaDisplay,{"Dim RESpixaDisplay as Pix = LeptonicaSharp._All.pixaDisplay(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayOnColor as Pix = LeptonicaSharp._All.pixaDisplayOnColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayOnColor",TestPix, RESpixaDisplayOnColor,{"Dim RESpixaDisplayOnColor as Pix = LeptonicaSharp._All.pixaDisplayOnColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayRandomCmap as Pix = LeptonicaSharp._All.pixaDisplayRandomCmap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayRandomCmap",TestPix, RESpixaDisplayRandomCmap,{"Dim RESpixaDisplayRandomCmap as Pix = LeptonicaSharp._All.pixaDisplayRandomCmap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayLinearly as Pix = LeptonicaSharp._All.pixaDisplayLinearly(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayLinearly",TestPix, RESpixaDisplayLinearly,{"Dim RESpixaDisplayLinearly as Pix = LeptonicaSharp._All.pixaDisplayLinearly(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixaDisplayOnLattice as Pix = LeptonicaSharp._All.pixaDisplayOnLattice(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayOnLattice",TestPix, RESpixaDisplayOnLattice,{"Dim RESpixaDisplayOnLattice as Pix = LeptonicaSharp._All.pixaDisplayOnLattice(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaDisplayUnsplit as Pix = LeptonicaSharp._All.pixaDisplayUnsplit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayUnsplit",TestPix, RESpixaDisplayUnsplit,{"Dim RESpixaDisplayUnsplit as Pix = LeptonicaSharp._All.pixaDisplayUnsplit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiled as Pix = LeptonicaSharp._All.pixaDisplayTiled(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiled",TestPix, RESpixaDisplayTiled,{"Dim RESpixaDisplayTiled as Pix = LeptonicaSharp._All.pixaDisplayTiled(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiledInRows as Pix = LeptonicaSharp._All.pixaDisplayTiledInRows(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiledInRows",TestPix, RESpixaDisplayTiledInRows,{"Dim RESpixaDisplayTiledInRows as Pix = LeptonicaSharp._All.pixaDisplayTiledInRows(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiledInColumns as Pix = LeptonicaSharp._All.pixaDisplayTiledInColumns(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiledInColumns",TestPix, RESpixaDisplayTiledInColumns,{"Dim RESpixaDisplayTiledInColumns as Pix = LeptonicaSharp._All.pixaDisplayTiledInColumns(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiledAndScaled as Pix = LeptonicaSharp._All.pixaDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiledAndScaled",TestPix, RESpixaDisplayTiledAndScaled,{"Dim RESpixaDisplayTiledAndScaled as Pix = LeptonicaSharp._All.pixaDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiledWithText as Pix = LeptonicaSharp._All.pixaDisplayTiledWithText(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiledWithText",TestPix, RESpixaDisplayTiledWithText,{"Dim RESpixaDisplayTiledWithText as Pix = LeptonicaSharp._All.pixaDisplayTiledWithText(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayTiledByIndex as Pix = LeptonicaSharp._All.pixaDisplayTiledByIndex(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayTiledByIndex",TestPix, RESpixaDisplayTiledByIndex,{"Dim RESpixaDisplayTiledByIndex as Pix = LeptonicaSharp._All.pixaDisplayTiledByIndex(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaDisplay as Pix = LeptonicaSharp._All.pixaaDisplay(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaDisplay",TestPix, RESpixaaDisplay,{"Dim RESpixaaDisplay as Pix = LeptonicaSharp._All.pixaaDisplay(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaDisplayByPixa as Pix = LeptonicaSharp._All.pixaaDisplayByPixa(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaDisplayByPixa",TestPix, RESpixaaDisplayByPixa,{"Dim RESpixaaDisplayByPixa as Pix = LeptonicaSharp._All.pixaaDisplayByPixa(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaaDisplayTiledAndScaled as Pixa = LeptonicaSharp._All.pixaaDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaaDisplayTiledAndScaled",TestPix, RESpixaaDisplayTiledAndScaled,{"Dim RESpixaaDisplayTiledAndScaled as Pixa = LeptonicaSharp._All.pixaaDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaConvertTo1 as Pixa = LeptonicaSharp._All.pixaConvertTo1(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertTo1",TestPix, RESpixaConvertTo1,{"Dim RESpixaConvertTo1 as Pixa = LeptonicaSharp._All.pixaConvertTo1(TestPix ,TestPix )"},1)

' Dim RESpixaConvertTo8 as Pixa = LeptonicaSharp._All.pixaConvertTo8(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertTo8",TestPix, RESpixaConvertTo8,{"Dim RESpixaConvertTo8 as Pixa = LeptonicaSharp._All.pixaConvertTo8(TestPix ,TestPix )"},1)

' Dim RESpixaConvertTo8Colormap as Pixa = LeptonicaSharp._All.pixaConvertTo8Colormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertTo8Colormap",TestPix, RESpixaConvertTo8Colormap,{"Dim RESpixaConvertTo8Colormap as Pixa = LeptonicaSharp._All.pixaConvertTo8Colormap(TestPix ,TestPix )"},1)

' Dim RESpixaConvertTo32 as Pixa = LeptonicaSharp._All.pixaConvertTo32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertTo32",TestPix, RESpixaConvertTo32,{"Dim RESpixaConvertTo32 as Pixa = LeptonicaSharp._All.pixaConvertTo32(TestPix )"},1)

' Dim RESpixaConstrainedSelect as Pixa = LeptonicaSharp._All.pixaConstrainedSelect(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConstrainedSelect",TestPix, RESpixaConstrainedSelect,{"Dim RESpixaConstrainedSelect as Pixa = LeptonicaSharp._All.pixaConstrainedSelect(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSelectToPdf as Integer = LeptonicaSharp._All.pixaSelectToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSelectToPdf",TestPix, RESpixaSelectToPdf,{"Dim RESpixaSelectToPdf as Integer = LeptonicaSharp._All.pixaSelectToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaDisplayMultiTiled as Pixa = LeptonicaSharp._All.pixaDisplayMultiTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaDisplayMultiTiled",TestPix, RESpixaDisplayMultiTiled,{"Dim RESpixaDisplayMultiTiled as Pixa = LeptonicaSharp._All.pixaDisplayMultiTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSplitIntoFiles as Integer = LeptonicaSharp._All.pixaSplitIntoFiles(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSplitIntoFiles",TestPix, RESpixaSplitIntoFiles,{"Dim RESpixaSplitIntoFiles as Integer = LeptonicaSharp._All.pixaSplitIntoFiles(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertToNUpFiles as Integer = LeptonicaSharp._All.convertToNUpFiles(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToNUpFiles",TestPix, RESconvertToNUpFiles,{"Dim RESconvertToNUpFiles as Integer = LeptonicaSharp._All.convertToNUpFiles(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertToNUpPixa as Pixa = LeptonicaSharp._All.convertToNUpPixa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToNUpPixa",TestPix, RESconvertToNUpPixa,{"Dim RESconvertToNUpPixa as Pixa = LeptonicaSharp._All.convertToNUpPixa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaConvertToNUpPixa as Pixa = LeptonicaSharp._All.pixaConvertToNUpPixa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaConvertToNUpPixa",TestPix, RESpixaConvertToNUpPixa,{"Dim RESpixaConvertToNUpPixa as Pixa = LeptonicaSharp._All.pixaConvertToNUpPixa(TestPix ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaCompareInPdf as Integer = LeptonicaSharp._All.pixaCompareInPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCompareInPdf",TestPix, RESpixaCompareInPdf,{"Dim RESpixaCompareInPdf as Integer = LeptonicaSharp._All.pixaCompareInPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpmsCreate as Integer = LeptonicaSharp._All.pmsCreate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsCreate",TestPix, RESpmsCreate,{"Dim RESpmsCreate as Integer = LeptonicaSharp._All.pmsCreate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpmsDestroy as Object = LeptonicaSharp._All.pmsDestroy()
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsDestroy",TestPix, RESpmsDestroy,{"Dim RESpmsDestroy as Object = LeptonicaSharp._All.pmsDestroy()"},1)

' Dim RESpmsCustomAlloc as Object = LeptonicaSharp._All.pmsCustomAlloc(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsCustomAlloc",TestPix, RESpmsCustomAlloc,{"Dim RESpmsCustomAlloc as Object = LeptonicaSharp._All.pmsCustomAlloc(TestPix )"},1)

' Dim RESpmsCustomDealloc as Object = LeptonicaSharp._All.pmsCustomDealloc(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsCustomDealloc",TestPix, RESpmsCustomDealloc,{"Dim RESpmsCustomDealloc as Object = LeptonicaSharp._All.pmsCustomDealloc(TestPix )"},1)

' Dim RESpmsGetAlloc as Object = LeptonicaSharp._All.pmsGetAlloc(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsGetAlloc",TestPix, RESpmsGetAlloc,{"Dim RESpmsGetAlloc as Object = LeptonicaSharp._All.pmsGetAlloc(TestPix )"},1)

' Dim RESpmsGetLevelForAlloc as Integer = LeptonicaSharp._All.pmsGetLevelForAlloc(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsGetLevelForAlloc",TestPix, RESpmsGetLevelForAlloc,{"Dim RESpmsGetLevelForAlloc as Integer = LeptonicaSharp._All.pmsGetLevelForAlloc(TestPix ,New Integer)"},1)

' Dim RESpmsGetLevelForDealloc as Integer = LeptonicaSharp._All.pmsGetLevelForDealloc(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsGetLevelForDealloc",TestPix, RESpmsGetLevelForDealloc,{"Dim RESpmsGetLevelForDealloc as Integer = LeptonicaSharp._All.pmsGetLevelForDealloc(TestPix ,New Integer)"},1)

' Dim RESpmsLogInfo as Object = LeptonicaSharp._All.pmsLogInfo()
' LeptonicaSharp.Convert.WriteHelpExtension ("pmsLogInfo",TestPix, RESpmsLogInfo,{"Dim RESpmsLogInfo as Object = LeptonicaSharp._All.pmsLogInfo()"},1)

' Dim RESpixAddConstantGray as Integer = LeptonicaSharp._All.pixAddConstantGray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddConstantGray",TestPix, RESpixAddConstantGray,{"Dim RESpixAddConstantGray as Integer = LeptonicaSharp._All.pixAddConstantGray(TestPix ,TestPix )"},1)

' Dim RESpixMultConstantGray as Integer = LeptonicaSharp._All.pixMultConstantGray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMultConstantGray",TestPix, RESpixMultConstantGray,{"Dim RESpixMultConstantGray as Integer = LeptonicaSharp._All.pixMultConstantGray(TestPix ,TestPix )"},1)

' Dim RESpixAddGray as Pix = LeptonicaSharp._All.pixAddGray(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddGray",TestPix, RESpixAddGray,{"Dim RESpixAddGray as Pix = LeptonicaSharp._All.pixAddGray(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixSubtractGray as Pix = LeptonicaSharp._All.pixSubtractGray(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSubtractGray",TestPix, RESpixSubtractGray,{"Dim RESpixSubtractGray as Pix = LeptonicaSharp._All.pixSubtractGray(Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixThresholdToValue as Pix = LeptonicaSharp._All.pixThresholdToValue(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThresholdToValue",TestPix, RESpixThresholdToValue,{"Dim RESpixThresholdToValue as Pix = LeptonicaSharp._All.pixThresholdToValue(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixInitAccumulate as Pix = LeptonicaSharp._All.pixInitAccumulate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixInitAccumulate",TestPix, RESpixInitAccumulate,{"Dim RESpixInitAccumulate as Pix = LeptonicaSharp._All.pixInitAccumulate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFinalAccumulate as Pix = LeptonicaSharp._All.pixFinalAccumulate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFinalAccumulate",TestPix, RESpixFinalAccumulate,{"Dim RESpixFinalAccumulate as Pix = LeptonicaSharp._All.pixFinalAccumulate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFinalAccumulateThreshold as Pix = LeptonicaSharp._All.pixFinalAccumulateThreshold(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFinalAccumulateThreshold",TestPix, RESpixFinalAccumulateThreshold,{"Dim RESpixFinalAccumulateThreshold as Pix = LeptonicaSharp._All.pixFinalAccumulateThreshold(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAccumulate as Integer = LeptonicaSharp._All.pixAccumulate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAccumulate",TestPix, RESpixAccumulate,{"Dim RESpixAccumulate as Integer = LeptonicaSharp._All.pixAccumulate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMultConstAccumulate as Integer = LeptonicaSharp._All.pixMultConstAccumulate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMultConstAccumulate",TestPix, RESpixMultConstAccumulate,{"Dim RESpixMultConstAccumulate as Integer = LeptonicaSharp._All.pixMultConstAccumulate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixAbsDifference as Pix = LeptonicaSharp._All.pixAbsDifference(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAbsDifference",TestPix, RESpixAbsDifference,{"Dim RESpixAbsDifference as Pix = LeptonicaSharp._All.pixAbsDifference(TestPix ,TestPix )"},1)

' Dim RESpixAddRGB as Pix = LeptonicaSharp._All.pixAddRGB(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddRGB",TestPix, RESpixAddRGB,{"Dim RESpixAddRGB as Pix = LeptonicaSharp._All.pixAddRGB(TestPix ,TestPix )"},1)

' Dim RESpixMinOrMax as Pix = LeptonicaSharp._All.pixMinOrMax(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMinOrMax",TestPix, RESpixMinOrMax,{"Dim RESpixMinOrMax as Pix = LeptonicaSharp._All.pixMinOrMax(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMaxDynamicRange as Pix = LeptonicaSharp._All.pixMaxDynamicRange(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaxDynamicRange",TestPix, RESpixMaxDynamicRange,{"Dim RESpixMaxDynamicRange as Pix = LeptonicaSharp._All.pixMaxDynamicRange(TestPix ,TestPix )"},1)

' Dim RESpixMaxDynamicRangeRGB as Pix = LeptonicaSharp._All.pixMaxDynamicRangeRGB(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMaxDynamicRangeRGB",TestPix, RESpixMaxDynamicRangeRGB,{"Dim RESpixMaxDynamicRangeRGB as Pix = LeptonicaSharp._All.pixMaxDynamicRangeRGB(TestPix ,TestPix )"},1)

' Dim RESlinearScaleRGBVal as UInteger = LeptonicaSharp._All.linearScaleRGBVal(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("linearScaleRGBVal",TestPix, RESlinearScaleRGBVal,{"Dim RESlinearScaleRGBVal as UInteger = LeptonicaSharp._All.linearScaleRGBVal(TestPix ,TestPix )"},1)

' Dim RESlogScaleRGBVal as UInteger = LeptonicaSharp._All.logScaleRGBVal(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("logScaleRGBVal",TestPix, RESlogScaleRGBVal,{"Dim RESlogScaleRGBVal as UInteger = LeptonicaSharp._All.logScaleRGBVal(TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeLogBase2Tab as Single() = LeptonicaSharp._All.makeLogBase2Tab()
' LeptonicaSharp.Convert.WriteHelpExtension ("makeLogBase2Tab",TestPix, RESmakeLogBase2Tab,{"Dim RESmakeLogBase2Tab as Single() = LeptonicaSharp._All.makeLogBase2Tab()"},1)

' Dim RESgetLogBase2 as Single = LeptonicaSharp._All.getLogBase2(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getLogBase2",TestPix, RESgetLogBase2,{"Dim RESgetLogBase2 as Single = LeptonicaSharp._All.getLogBase2(TestPix ,TestPix )"},1)

' Dim RESpixcompCreateFromPix as PixComp = LeptonicaSharp._All.pixcompCreateFromPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompCreateFromPix",TestPix, RESpixcompCreateFromPix,{"Dim RESpixcompCreateFromPix as PixComp = LeptonicaSharp._All.pixcompCreateFromPix(TestPix ,TestPix )"},1)

' Dim RESpixcompCreateFromString as PixComp = LeptonicaSharp._All.pixcompCreateFromString(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompCreateFromString",TestPix, RESpixcompCreateFromString,{"Dim RESpixcompCreateFromString as PixComp = LeptonicaSharp._All.pixcompCreateFromString(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixcompCreateFromFile as PixComp = LeptonicaSharp._All.pixcompCreateFromFile(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompCreateFromFile",TestPix, RESpixcompCreateFromFile,{"Dim RESpixcompCreateFromFile as PixComp = LeptonicaSharp._All.pixcompCreateFromFile(TestPix ,TestPix )"},1)

' Dim RESpixcompDestroy as Object = LeptonicaSharp._All.pixcompDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompDestroy",TestPix, RESpixcompDestroy,{"Dim RESpixcompDestroy as Object = LeptonicaSharp._All.pixcompDestroy(TestPix )"},1)

' Dim RESpixcompCopy as PixComp = LeptonicaSharp._All.pixcompCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompCopy",TestPix, RESpixcompCopy,{"Dim RESpixcompCopy as PixComp = LeptonicaSharp._All.pixcompCopy(TestPix )"},1)

' Dim RESpixcompGetDimensions as Integer = LeptonicaSharp._All.pixcompGetDimensions(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompGetDimensions",TestPix, RESpixcompGetDimensions,{"Dim RESpixcompGetDimensions as Integer = LeptonicaSharp._All.pixcompGetDimensions(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixcompGetParameters as Integer = LeptonicaSharp._All.pixcompGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompGetParameters",TestPix, RESpixcompGetParameters,{"Dim RESpixcompGetParameters as Integer = LeptonicaSharp._All.pixcompGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixcompDetermineFormat as Integer = LeptonicaSharp._All.pixcompDetermineFormat(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompDetermineFormat",TestPix, RESpixcompDetermineFormat,{"Dim RESpixcompDetermineFormat as Integer = LeptonicaSharp._All.pixcompDetermineFormat(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixCreateFromPixcomp as Pix = LeptonicaSharp._All.pixCreateFromPixcomp(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixCreateFromPixcomp",TestPix, RESpixCreateFromPixcomp,{"Dim RESpixCreateFromPixcomp as Pix = LeptonicaSharp._All.pixCreateFromPixcomp(TestPix )"},1)

' Dim RESpixacompCreate as PixaComp = LeptonicaSharp._All.pixacompCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompCreate",TestPix, RESpixacompCreate,{"Dim RESpixacompCreate as PixaComp = LeptonicaSharp._All.pixacompCreate(TestPix )"},1)

' Dim RESpixacompCreateWithInit as PixaComp = LeptonicaSharp._All.pixacompCreateWithInit(TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompCreateWithInit",TestPix, RESpixacompCreateWithInit,{"Dim RESpixacompCreateWithInit as PixaComp = LeptonicaSharp._All.pixacompCreateWithInit(TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixacompCreateFromPixa as PixaComp = LeptonicaSharp._All.pixacompCreateFromPixa(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompCreateFromPixa",TestPix, RESpixacompCreateFromPixa,{"Dim RESpixacompCreateFromPixa as PixaComp = LeptonicaSharp._All.pixacompCreateFromPixa(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompCreateFromFiles as PixaComp = LeptonicaSharp._All.pixacompCreateFromFiles(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompCreateFromFiles",TestPix, RESpixacompCreateFromFiles,{"Dim RESpixacompCreateFromFiles as PixaComp = LeptonicaSharp._All.pixacompCreateFromFiles(TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixacompCreateFromSA as PixaComp = LeptonicaSharp._All.pixacompCreateFromSA(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompCreateFromSA",TestPix, RESpixacompCreateFromSA,{"Dim RESpixacompCreateFromSA as PixaComp = LeptonicaSharp._All.pixacompCreateFromSA(TestPix ,TestPix )"},1)

' Dim RESpixacompDestroy as Object = LeptonicaSharp._All.pixacompDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompDestroy",TestPix, RESpixacompDestroy,{"Dim RESpixacompDestroy as Object = LeptonicaSharp._All.pixacompDestroy(TestPix )"},1)

' Dim RESpixacompAddPix as Integer = LeptonicaSharp._All.pixacompAddPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompAddPix",TestPix, RESpixacompAddPix,{"Dim RESpixacompAddPix as Integer = LeptonicaSharp._All.pixacompAddPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompAddPixcomp as Integer = LeptonicaSharp._All.pixacompAddPixcomp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompAddPixcomp",TestPix, RESpixacompAddPixcomp,{"Dim RESpixacompAddPixcomp as Integer = LeptonicaSharp._All.pixacompAddPixcomp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompReplacePix as Integer = LeptonicaSharp._All.pixacompReplacePix(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompReplacePix",TestPix, RESpixacompReplacePix,{"Dim RESpixacompReplacePix as Integer = LeptonicaSharp._All.pixacompReplacePix(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompReplacePixcomp as Integer = LeptonicaSharp._All.pixacompReplacePixcomp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompReplacePixcomp",TestPix, RESpixacompReplacePixcomp,{"Dim RESpixacompReplacePixcomp as Integer = LeptonicaSharp._All.pixacompReplacePixcomp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompAddBox as Integer = LeptonicaSharp._All.pixacompAddBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompAddBox",TestPix, RESpixacompAddBox,{"Dim RESpixacompAddBox as Integer = LeptonicaSharp._All.pixacompAddBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompGetCount as Integer = LeptonicaSharp._All.pixacompGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetCount",TestPix, RESpixacompGetCount,{"Dim RESpixacompGetCount as Integer = LeptonicaSharp._All.pixacompGetCount(TestPix )"},1)

' Dim RESpixacompGetPixcomp as PixComp = LeptonicaSharp._All.pixacompGetPixcomp(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetPixcomp",TestPix, RESpixacompGetPixcomp,{"Dim RESpixacompGetPixcomp as PixComp = LeptonicaSharp._All.pixacompGetPixcomp(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompGetPix as Pix = LeptonicaSharp._All.pixacompGetPix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetPix",TestPix, RESpixacompGetPix,{"Dim RESpixacompGetPix as Pix = LeptonicaSharp._All.pixacompGetPix(TestPix ,TestPix )"},1)

' Dim RESpixacompGetPixDimensions as Integer = LeptonicaSharp._All.pixacompGetPixDimensions(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetPixDimensions",TestPix, RESpixacompGetPixDimensions,{"Dim RESpixacompGetPixDimensions as Integer = LeptonicaSharp._All.pixacompGetPixDimensions(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixacompGetBoxa as Boxa = LeptonicaSharp._All.pixacompGetBoxa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetBoxa",TestPix, RESpixacompGetBoxa,{"Dim RESpixacompGetBoxa as Boxa = LeptonicaSharp._All.pixacompGetBoxa(TestPix ,TestPix )"},1)

' Dim RESpixacompGetBoxaCount as Integer = LeptonicaSharp._All.pixacompGetBoxaCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetBoxaCount",TestPix, RESpixacompGetBoxaCount,{"Dim RESpixacompGetBoxaCount as Integer = LeptonicaSharp._All.pixacompGetBoxaCount(TestPix )"},1)

' Dim RESpixacompGetBox as Box = LeptonicaSharp._All.pixacompGetBox(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetBox",TestPix, RESpixacompGetBox,{"Dim RESpixacompGetBox as Box = LeptonicaSharp._All.pixacompGetBox(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompGetBoxGeometry as Integer = LeptonicaSharp._All.pixacompGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetBoxGeometry",TestPix, RESpixacompGetBoxGeometry,{"Dim RESpixacompGetBoxGeometry as Integer = LeptonicaSharp._All.pixacompGetBoxGeometry(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixacompGetOffset as Integer = LeptonicaSharp._All.pixacompGetOffset(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompGetOffset",TestPix, RESpixacompGetOffset,{"Dim RESpixacompGetOffset as Integer = LeptonicaSharp._All.pixacompGetOffset(TestPix )"},1)

' Dim RESpixacompSetOffset as Integer = LeptonicaSharp._All.pixacompSetOffset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompSetOffset",TestPix, RESpixacompSetOffset,{"Dim RESpixacompSetOffset as Integer = LeptonicaSharp._All.pixacompSetOffset(TestPix ,TestPix )"},1)

' Dim RESpixaCreateFromPixacomp as Pixa = LeptonicaSharp._All.pixaCreateFromPixacomp(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaCreateFromPixacomp",TestPix, RESpixaCreateFromPixacomp,{"Dim RESpixaCreateFromPixacomp as Pixa = LeptonicaSharp._All.pixaCreateFromPixacomp(TestPix ,TestPix )"},1)

' Dim RESpixacompJoin as Integer = LeptonicaSharp._All.pixacompJoin(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompJoin",TestPix, RESpixacompJoin,{"Dim RESpixacompJoin as Integer = LeptonicaSharp._All.pixacompJoin(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixacompInterleave as PixaComp = LeptonicaSharp._All.pixacompInterleave(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompInterleave",TestPix, RESpixacompInterleave,{"Dim RESpixacompInterleave as PixaComp = LeptonicaSharp._All.pixacompInterleave(TestPix ,TestPix )"},1)

' Dim RESpixacompRead as PixaComp = LeptonicaSharp._All.pixacompRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompRead",TestPix, RESpixacompRead,{"Dim RESpixacompRead as PixaComp = LeptonicaSharp._All.pixacompRead(TestPix )"},1)

' Dim RESpixacompReadStream as PixaComp = LeptonicaSharp._All.pixacompReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompReadStream",TestPix, RESpixacompReadStream,{"Dim RESpixacompReadStream as PixaComp = LeptonicaSharp._All.pixacompReadStream(TestPix )"},1)

' Dim RESpixacompReadMem as PixaComp = LeptonicaSharp._All.pixacompReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompReadMem",TestPix, RESpixacompReadMem,{"Dim RESpixacompReadMem as PixaComp = LeptonicaSharp._All.pixacompReadMem(TestPix ,TestPix )"},1)

' Dim RESpixacompWrite as Integer = LeptonicaSharp._All.pixacompWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompWrite",TestPix, RESpixacompWrite,{"Dim RESpixacompWrite as Integer = LeptonicaSharp._All.pixacompWrite(TestPix ,TestPix )"},1)

' Dim RESpixacompWriteStream as Integer = LeptonicaSharp._All.pixacompWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompWriteStream",TestPix, RESpixacompWriteStream,{"Dim RESpixacompWriteStream as Integer = LeptonicaSharp._All.pixacompWriteStream(TestPix ,TestPix )"},1)

' Dim RESpixacompWriteMem as Integer = LeptonicaSharp._All.pixacompWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompWriteMem",TestPix, RESpixacompWriteMem,{"Dim RESpixacompWriteMem as Integer = LeptonicaSharp._All.pixacompWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixacompConvertToPdf as Integer = LeptonicaSharp._All.pixacompConvertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompConvertToPdf",TestPix, RESpixacompConvertToPdf,{"Dim RESpixacompConvertToPdf as Integer = LeptonicaSharp._All.pixacompConvertToPdf(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixacompConvertToPdfData as Integer = LeptonicaSharp._All.pixacompConvertToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompConvertToPdfData",TestPix, RESpixacompConvertToPdfData,{"Dim RESpixacompConvertToPdfData as Integer = LeptonicaSharp._All.pixacompConvertToPdfData(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESpixacompFastConvertToPdfData as Integer = LeptonicaSharp._All.pixacompFastConvertToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompFastConvertToPdfData",TestPix, RESpixacompFastConvertToPdfData,{"Dim RESpixacompFastConvertToPdfData as Integer = LeptonicaSharp._All.pixacompFastConvertToPdfData(TestPix ,Nothing ,New Byte(),New UInteger)"},1)

' Dim RESpixacompWriteStreamInfo as Integer = LeptonicaSharp._All.pixacompWriteStreamInfo(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompWriteStreamInfo",TestPix, RESpixacompWriteStreamInfo,{"Dim RESpixacompWriteStreamInfo as Integer = LeptonicaSharp._All.pixacompWriteStreamInfo(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixcompWriteStreamInfo as Integer = LeptonicaSharp._All.pixcompWriteStreamInfo(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompWriteStreamInfo",TestPix, RESpixcompWriteStreamInfo,{"Dim RESpixcompWriteStreamInfo as Integer = LeptonicaSharp._All.pixcompWriteStreamInfo(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixacompDisplayTiledAndScaled as Pix = LeptonicaSharp._All.pixacompDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompDisplayTiledAndScaled",TestPix, RESpixacompDisplayTiledAndScaled,{"Dim RESpixacompDisplayTiledAndScaled as Pix = LeptonicaSharp._All.pixacompDisplayTiledAndScaled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixacompWriteFiles as Integer = LeptonicaSharp._All.pixacompWriteFiles(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixacompWriteFiles",TestPix, RESpixacompWriteFiles,{"Dim RESpixacompWriteFiles as Integer = LeptonicaSharp._All.pixacompWriteFiles(TestPix ,TestPix )"},1)

' Dim RESpixcompWriteFile as Integer = LeptonicaSharp._All.pixcompWriteFile(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixcompWriteFile",TestPix, RESpixcompWriteFile,{"Dim RESpixcompWriteFile as Integer = LeptonicaSharp._All.pixcompWriteFile(TestPix ,TestPix )"},1)

' Dim RESpixThreshold8 as Pix = LeptonicaSharp._All.pixThreshold8(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixThreshold8",TestPix, RESpixThreshold8,{"Dim RESpixThreshold8 as Pix = LeptonicaSharp._All.pixThreshold8(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveColormapGeneral as Pix = LeptonicaSharp._All.pixRemoveColormapGeneral(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveColormapGeneral",TestPix, RESpixRemoveColormapGeneral,{"Dim RESpixRemoveColormapGeneral as Pix = LeptonicaSharp._All.pixRemoveColormapGeneral(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveColormap as Pix = LeptonicaSharp._All.pixRemoveColormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveColormap",TestPix, RESpixRemoveColormap,{"Dim RESpixRemoveColormap as Pix = LeptonicaSharp._All.pixRemoveColormap(TestPix ,TestPix )"},1)

' Dim RESpixAddGrayColormap8 as Integer = LeptonicaSharp._All.pixAddGrayColormap8(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddGrayColormap8",TestPix, RESpixAddGrayColormap8,{"Dim RESpixAddGrayColormap8 as Integer = LeptonicaSharp._All.pixAddGrayColormap8(TestPix )"},1)

' Dim RESpixAddMinimalGrayColormap8 as Pix = LeptonicaSharp._All.pixAddMinimalGrayColormap8(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddMinimalGrayColormap8",TestPix, RESpixAddMinimalGrayColormap8,{"Dim RESpixAddMinimalGrayColormap8 as Pix = LeptonicaSharp._All.pixAddMinimalGrayColormap8(TestPix )"},1)

' Dim RESpixConvertRGBToLuminance as Pix = LeptonicaSharp._All.pixConvertRGBToLuminance(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToLuminance",TestPix, RESpixConvertRGBToLuminance,{"Dim RESpixConvertRGBToLuminance as Pix = LeptonicaSharp._All.pixConvertRGBToLuminance(TestPix )"},1)

' Dim RESpixConvertRGBToGray as Pix = LeptonicaSharp._All.pixConvertRGBToGray(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToGray",TestPix, RESpixConvertRGBToGray,{"Dim RESpixConvertRGBToGray as Pix = LeptonicaSharp._All.pixConvertRGBToGray(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixConvertRGBToGrayFast as Pix = LeptonicaSharp._All.pixConvertRGBToGrayFast(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToGrayFast",TestPix, RESpixConvertRGBToGrayFast,{"Dim RESpixConvertRGBToGrayFast as Pix = LeptonicaSharp._All.pixConvertRGBToGrayFast(TestPix )"},1)

' Dim RESpixConvertRGBToGrayMinMax as Pix = LeptonicaSharp._All.pixConvertRGBToGrayMinMax(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToGrayMinMax",TestPix, RESpixConvertRGBToGrayMinMax,{"Dim RESpixConvertRGBToGrayMinMax as Pix = LeptonicaSharp._All.pixConvertRGBToGrayMinMax(TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToGraySatBoost as Pix = LeptonicaSharp._All.pixConvertRGBToGraySatBoost(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToGraySatBoost",TestPix, RESpixConvertRGBToGraySatBoost,{"Dim RESpixConvertRGBToGraySatBoost as Pix = LeptonicaSharp._All.pixConvertRGBToGraySatBoost(TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToGrayArb as Pix = LeptonicaSharp._All.pixConvertRGBToGrayArb(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToGrayArb",TestPix, RESpixConvertRGBToGrayArb,{"Dim RESpixConvertRGBToGrayArb as Pix = LeptonicaSharp._All.pixConvertRGBToGrayArb(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToBinaryArb as Pix = LeptonicaSharp._All.pixConvertRGBToBinaryArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToBinaryArb",TestPix, RESpixConvertRGBToBinaryArb,{"Dim RESpixConvertRGBToBinaryArb as Pix = LeptonicaSharp._All.pixConvertRGBToBinaryArb(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertGrayToColormap as Pix = LeptonicaSharp._All.pixConvertGrayToColormap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertGrayToColormap",TestPix, RESpixConvertGrayToColormap,{"Dim RESpixConvertGrayToColormap as Pix = LeptonicaSharp._All.pixConvertGrayToColormap(TestPix )"},1)

' Dim RESpixConvertGrayToColormap8 as Pix = LeptonicaSharp._All.pixConvertGrayToColormap8(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertGrayToColormap8",TestPix, RESpixConvertGrayToColormap8,{"Dim RESpixConvertGrayToColormap8 as Pix = LeptonicaSharp._All.pixConvertGrayToColormap8(TestPix ,TestPix )"},1)

' Dim RESpixColorizeGray as Pix = LeptonicaSharp._All.pixColorizeGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixColorizeGray",TestPix, RESpixColorizeGray,{"Dim RESpixColorizeGray as Pix = LeptonicaSharp._All.pixColorizeGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertRGBToColormap as Pix = LeptonicaSharp._All.pixConvertRGBToColormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertRGBToColormap",TestPix, RESpixConvertRGBToColormap,{"Dim RESpixConvertRGBToColormap as Pix = LeptonicaSharp._All.pixConvertRGBToColormap(TestPix ,TestPix )"},1)

' Dim RESpixConvertCmapTo1 as Pix = LeptonicaSharp._All.pixConvertCmapTo1(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertCmapTo1",TestPix, RESpixConvertCmapTo1,{"Dim RESpixConvertCmapTo1 as Pix = LeptonicaSharp._All.pixConvertCmapTo1(TestPix )"},1)

' Dim RESpixQuantizeIfFewColors as Integer = LeptonicaSharp._All.pixQuantizeIfFewColors(TestPix ,TestPix ,TestPix ,TestPix ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuantizeIfFewColors",TestPix, RESpixQuantizeIfFewColors,{"Dim RESpixQuantizeIfFewColors as Integer = LeptonicaSharp._All.pixQuantizeIfFewColors(TestPix ,TestPix ,TestPix ,TestPix ,New Pix)"},1)

' Dim RESpixConvert16To8 as Pix = LeptonicaSharp._All.pixConvert16To8(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert16To8",TestPix, RESpixConvert16To8,{"Dim RESpixConvert16To8 as Pix = LeptonicaSharp._All.pixConvert16To8(TestPix ,TestPix )"},1)

' Dim RESpixConvertGrayToFalseColor as Pix = LeptonicaSharp._All.pixConvertGrayToFalseColor(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertGrayToFalseColor",TestPix, RESpixConvertGrayToFalseColor,{"Dim RESpixConvertGrayToFalseColor as Pix = LeptonicaSharp._All.pixConvertGrayToFalseColor(TestPix ,TestPix )"},1)

' Dim RESpixUnpackBinary as Pix = LeptonicaSharp._All.pixUnpackBinary(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixUnpackBinary",TestPix, RESpixUnpackBinary,{"Dim RESpixUnpackBinary as Pix = LeptonicaSharp._All.pixUnpackBinary(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert1To16 as Pix = LeptonicaSharp._All.pixConvert1To16(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To16",TestPix, RESpixConvert1To16,{"Dim RESpixConvert1To16 as Pix = LeptonicaSharp._All.pixConvert1To16(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert1To32 as Pix = LeptonicaSharp._All.pixConvert1To32(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To32",TestPix, RESpixConvert1To32,{"Dim RESpixConvert1To32 as Pix = LeptonicaSharp._All.pixConvert1To32(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert1To2Cmap as Pix = LeptonicaSharp._All.pixConvert1To2Cmap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To2Cmap",TestPix, RESpixConvert1To2Cmap,{"Dim RESpixConvert1To2Cmap as Pix = LeptonicaSharp._All.pixConvert1To2Cmap(TestPix )"},1)

' Dim RESpixConvert1To2 as Pix = LeptonicaSharp._All.pixConvert1To2(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To2",TestPix, RESpixConvert1To2,{"Dim RESpixConvert1To2 as Pix = LeptonicaSharp._All.pixConvert1To2(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert1To4Cmap as Pix = LeptonicaSharp._All.pixConvert1To4Cmap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To4Cmap",TestPix, RESpixConvert1To4Cmap,{"Dim RESpixConvert1To4Cmap as Pix = LeptonicaSharp._All.pixConvert1To4Cmap(TestPix )"},1)

' Dim RESpixConvert1To4 as Pix = LeptonicaSharp._All.pixConvert1To4(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To4",TestPix, RESpixConvert1To4,{"Dim RESpixConvert1To4 as Pix = LeptonicaSharp._All.pixConvert1To4(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert1To8Cmap as Pix = LeptonicaSharp._All.pixConvert1To8Cmap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To8Cmap",TestPix, RESpixConvert1To8Cmap,{"Dim RESpixConvert1To8Cmap as Pix = LeptonicaSharp._All.pixConvert1To8Cmap(TestPix )"},1)

' Dim RESpixConvert1To8 as Pix = LeptonicaSharp._All.pixConvert1To8(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert1To8",TestPix, RESpixConvert1To8,{"Dim RESpixConvert1To8 as Pix = LeptonicaSharp._All.pixConvert1To8(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert2To8 as Pix = LeptonicaSharp._All.pixConvert2To8(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert2To8",TestPix, RESpixConvert2To8,{"Dim RESpixConvert2To8 as Pix = LeptonicaSharp._All.pixConvert2To8(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert4To8 as Pix = LeptonicaSharp._All.pixConvert4To8(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert4To8",TestPix, RESpixConvert4To8,{"Dim RESpixConvert4To8 as Pix = LeptonicaSharp._All.pixConvert4To8(TestPix ,TestPix )"},1)

' Dim RESpixConvert8To16 as Pix = LeptonicaSharp._All.pixConvert8To16(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert8To16",TestPix, RESpixConvert8To16,{"Dim RESpixConvert8To16 as Pix = LeptonicaSharp._All.pixConvert8To16(TestPix ,TestPix )"},1)

' Dim RESpixConvertTo2 as Pix = LeptonicaSharp._All.pixConvertTo2(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo2",TestPix, RESpixConvertTo2,{"Dim RESpixConvertTo2 as Pix = LeptonicaSharp._All.pixConvertTo2(TestPix )"},1)

' Dim RESpixConvert8To2 as Pix = LeptonicaSharp._All.pixConvert8To2(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert8To2",TestPix, RESpixConvert8To2,{"Dim RESpixConvert8To2 as Pix = LeptonicaSharp._All.pixConvert8To2(TestPix )"},1)

' Dim RESpixConvertTo4 as Pix = LeptonicaSharp._All.pixConvertTo4(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo4",TestPix, RESpixConvertTo4,{"Dim RESpixConvertTo4 as Pix = LeptonicaSharp._All.pixConvertTo4(TestPix )"},1)

' Dim RESpixConvert8To4 as Pix = LeptonicaSharp._All.pixConvert8To4(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert8To4",TestPix, RESpixConvert8To4,{"Dim RESpixConvert8To4 as Pix = LeptonicaSharp._All.pixConvert8To4(TestPix )"},1)

' Dim RESpixConvertTo1 as Pix = LeptonicaSharp._All.pixConvertTo1(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo1",TestPix, RESpixConvertTo1,{"Dim RESpixConvertTo1 as Pix = LeptonicaSharp._All.pixConvertTo1(TestPix ,TestPix )"},1)

' Dim RESpixConvertTo1BySampling as Pix = LeptonicaSharp._All.pixConvertTo1BySampling(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo1BySampling",TestPix, RESpixConvertTo1BySampling,{"Dim RESpixConvertTo1BySampling as Pix = LeptonicaSharp._All.pixConvertTo1BySampling(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertTo8 as Pix = LeptonicaSharp._All.pixConvertTo8(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo8",TestPix, RESpixConvertTo8,{"Dim RESpixConvertTo8 as Pix = LeptonicaSharp._All.pixConvertTo8(TestPix ,TestPix )"},1)

' Dim RESpixConvertTo8BySampling as Pix = LeptonicaSharp._All.pixConvertTo8BySampling(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo8BySampling",TestPix, RESpixConvertTo8BySampling,{"Dim RESpixConvertTo8BySampling as Pix = LeptonicaSharp._All.pixConvertTo8BySampling(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvertTo8Colormap as Pix = LeptonicaSharp._All.pixConvertTo8Colormap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo8Colormap",TestPix, RESpixConvertTo8Colormap,{"Dim RESpixConvertTo8Colormap as Pix = LeptonicaSharp._All.pixConvertTo8Colormap(TestPix ,TestPix )"},1)

' Dim RESpixConvertTo16 as Pix = LeptonicaSharp._All.pixConvertTo16(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo16",TestPix, RESpixConvertTo16,{"Dim RESpixConvertTo16 as Pix = LeptonicaSharp._All.pixConvertTo16(TestPix )"},1)

' Dim RESpixConvertTo32 as Pix = LeptonicaSharp._All.pixConvertTo32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo32",TestPix, RESpixConvertTo32,{"Dim RESpixConvertTo32 as Pix = LeptonicaSharp._All.pixConvertTo32(TestPix )"},1)

' Dim RESpixConvertTo32BySampling as Pix = LeptonicaSharp._All.pixConvertTo32BySampling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo32BySampling",TestPix, RESpixConvertTo32BySampling,{"Dim RESpixConvertTo32BySampling as Pix = LeptonicaSharp._All.pixConvertTo32BySampling(TestPix ,TestPix )"},1)

' Dim RESpixConvert8To32 as Pix = LeptonicaSharp._All.pixConvert8To32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert8To32",TestPix, RESpixConvert8To32,{"Dim RESpixConvert8To32 as Pix = LeptonicaSharp._All.pixConvert8To32(TestPix )"},1)

' Dim RESpixConvertTo8Or32 as Pix = LeptonicaSharp._All.pixConvertTo8Or32(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertTo8Or32",TestPix, RESpixConvertTo8Or32,{"Dim RESpixConvertTo8Or32 as Pix = LeptonicaSharp._All.pixConvertTo8Or32(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConvert24To32 as Pix = LeptonicaSharp._All.pixConvert24To32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert24To32",TestPix, RESpixConvert24To32,{"Dim RESpixConvert24To32 as Pix = LeptonicaSharp._All.pixConvert24To32(TestPix )"},1)

' Dim RESpixConvert32To24 as Pix = LeptonicaSharp._All.pixConvert32To24(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert32To24",TestPix, RESpixConvert32To24,{"Dim RESpixConvert32To24 as Pix = LeptonicaSharp._All.pixConvert32To24(TestPix )"},1)

' Dim RESpixConvert32To16 as Pix = LeptonicaSharp._All.pixConvert32To16(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert32To16",TestPix, RESpixConvert32To16,{"Dim RESpixConvert32To16 as Pix = LeptonicaSharp._All.pixConvert32To16(TestPix ,TestPix )"},1)

' Dim RESpixConvert32To8 as Pix = LeptonicaSharp._All.pixConvert32To8(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvert32To8",TestPix, RESpixConvert32To8,{"Dim RESpixConvert32To8 as Pix = LeptonicaSharp._All.pixConvert32To8(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRemoveAlpha as Pix = LeptonicaSharp._All.pixRemoveAlpha(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveAlpha",TestPix, RESpixRemoveAlpha,{"Dim RESpixRemoveAlpha as Pix = LeptonicaSharp._All.pixRemoveAlpha(TestPix )"},1)

' Dim RESpixAddAlphaTo1bpp as Pix = LeptonicaSharp._All.pixAddAlphaTo1bpp(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddAlphaTo1bpp",TestPix, RESpixAddAlphaTo1bpp,{"Dim RESpixAddAlphaTo1bpp as Pix = LeptonicaSharp._All.pixAddAlphaTo1bpp(Nothing ,TestPix )"},1)

' Dim RESpixConvertLossless as Pix = LeptonicaSharp._All.pixConvertLossless(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertLossless",TestPix, RESpixConvertLossless,{"Dim RESpixConvertLossless as Pix = LeptonicaSharp._All.pixConvertLossless(TestPix ,TestPix )"},1)

' Dim RESpixConvertForPSWrap as Pix = LeptonicaSharp._All.pixConvertForPSWrap(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertForPSWrap",TestPix, RESpixConvertForPSWrap,{"Dim RESpixConvertForPSWrap as Pix = LeptonicaSharp._All.pixConvertForPSWrap(TestPix )"},1)

' Dim RESpixConvertToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertToSubpixelRGB",TestPix, RESpixConvertToSubpixelRGB,{"Dim RESpixConvertToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixConvertGrayToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertGrayToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertGrayToSubpixelRGB",TestPix, RESpixConvertGrayToSubpixelRGB,{"Dim RESpixConvertGrayToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertGrayToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixConvertColorToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertColorToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConvertColorToSubpixelRGB",TestPix, RESpixConvertColorToSubpixelRGB,{"Dim RESpixConvertColorToSubpixelRGB as Pix = LeptonicaSharp._All.pixConvertColorToSubpixelRGB(TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESl_setNeutralBoostVal as Object = LeptonicaSharp._All.l_setNeutralBoostVal(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_setNeutralBoostVal",TestPix, RESl_setNeutralBoostVal,{"Dim RESl_setNeutralBoostVal as Object = LeptonicaSharp._All.l_setNeutralBoostVal(TestPix )"},1)

' Dim RESpixConnCompTransform as Pix = LeptonicaSharp._All.pixConnCompTransform(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompTransform",TestPix, RESpixConnCompTransform,{"Dim RESpixConnCompTransform as Pix = LeptonicaSharp._All.pixConnCompTransform(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixConnCompAreaTransform as Pix = LeptonicaSharp._All.pixConnCompAreaTransform(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompAreaTransform",TestPix, RESpixConnCompAreaTransform,{"Dim RESpixConnCompAreaTransform as Pix = LeptonicaSharp._All.pixConnCompAreaTransform(TestPix ,TestPix )"},1)

' Dim RESpixConnCompIncrInit as Integer = LeptonicaSharp._All.pixConnCompIncrInit(TestPix ,TestPix ,New Pix,New Ptaa,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompIncrInit",TestPix, RESpixConnCompIncrInit,{"Dim RESpixConnCompIncrInit as Integer = LeptonicaSharp._All.pixConnCompIncrInit(TestPix ,TestPix ,New Pix,New Ptaa,New Integer)"},1)

' Dim RESpixConnCompIncrAdd as Integer = LeptonicaSharp._All.pixConnCompIncrAdd(TestPix ,TestPix ,New Integer,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixConnCompIncrAdd",TestPix, RESpixConnCompIncrAdd,{"Dim RESpixConnCompIncrAdd as Integer = LeptonicaSharp._All.pixConnCompIncrAdd(TestPix ,TestPix ,New Integer,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGetSortedNeighborValues as Integer = LeptonicaSharp._All.pixGetSortedNeighborValues(TestPix ,TestPix ,TestPix ,TestPix ,New List (of Integer()),New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetSortedNeighborValues",TestPix, RESpixGetSortedNeighborValues,{"Dim RESpixGetSortedNeighborValues as Integer = LeptonicaSharp._All.pixGetSortedNeighborValues(TestPix ,TestPix ,TestPix ,TestPix ,New List (of Integer()),New Integer)"},1)

' Dim RESpixLocToColorTransform as Pix = LeptonicaSharp._All.pixLocToColorTransform(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLocToColorTransform",TestPix, RESpixLocToColorTransform,{"Dim RESpixLocToColorTransform as Pix = LeptonicaSharp._All.pixLocToColorTransform(TestPix )"},1)

' Dim RESpixTilingCreate as PixTiling = LeptonicaSharp._All.pixTilingCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingCreate",TestPix, RESpixTilingCreate,{"Dim RESpixTilingCreate as PixTiling = LeptonicaSharp._All.pixTilingCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTilingDestroy as Object = LeptonicaSharp._All.pixTilingDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingDestroy",TestPix, RESpixTilingDestroy,{"Dim RESpixTilingDestroy as Object = LeptonicaSharp._All.pixTilingDestroy(TestPix )"},1)

' Dim RESpixTilingGetCount as Integer = LeptonicaSharp._All.pixTilingGetCount(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingGetCount",TestPix, RESpixTilingGetCount,{"Dim RESpixTilingGetCount as Integer = LeptonicaSharp._All.pixTilingGetCount(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixTilingGetSize as Integer = LeptonicaSharp._All.pixTilingGetSize(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingGetSize",TestPix, RESpixTilingGetSize,{"Dim RESpixTilingGetSize as Integer = LeptonicaSharp._All.pixTilingGetSize(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixTilingGetTile as Pix = LeptonicaSharp._All.pixTilingGetTile(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingGetTile",TestPix, RESpixTilingGetTile,{"Dim RESpixTilingGetTile as Pix = LeptonicaSharp._All.pixTilingGetTile(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTilingNoStripOnPaint as Integer = LeptonicaSharp._All.pixTilingNoStripOnPaint(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingNoStripOnPaint",TestPix, RESpixTilingNoStripOnPaint,{"Dim RESpixTilingNoStripOnPaint as Integer = LeptonicaSharp._All.pixTilingNoStripOnPaint(TestPix )"},1)

' Dim RESpixTilingPaintTile as Integer = LeptonicaSharp._All.pixTilingPaintTile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTilingPaintTile",TestPix, RESpixTilingPaintTile,{"Dim RESpixTilingPaintTile as Integer = LeptonicaSharp._All.pixTilingPaintTile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadStreamPng as Pix = LeptonicaSharp._All.pixReadStreamPng(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamPng",TestPix, RESpixReadStreamPng,{"Dim RESpixReadStreamPng as Pix = LeptonicaSharp._All.pixReadStreamPng(TestPix )"},1)

' Dim RESreadHeaderPng as Integer = LeptonicaSharp._All.readHeaderPng(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderPng",TestPix, RESreadHeaderPng,{"Dim RESreadHeaderPng as Integer = LeptonicaSharp._All.readHeaderPng(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfreadHeaderPng as Integer = LeptonicaSharp._All.freadHeaderPng(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderPng",TestPix, RESfreadHeaderPng,{"Dim RESfreadHeaderPng as Integer = LeptonicaSharp._All.freadHeaderPng(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESreadHeaderMemPng as Integer = LeptonicaSharp._All.readHeaderMemPng(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemPng",TestPix, RESreadHeaderMemPng,{"Dim RESreadHeaderMemPng as Integer = LeptonicaSharp._All.readHeaderMemPng(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfgetPngResolution as Integer = LeptonicaSharp._All.fgetPngResolution(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fgetPngResolution",TestPix, RESfgetPngResolution,{"Dim RESfgetPngResolution as Integer = LeptonicaSharp._All.fgetPngResolution(TestPix ,TestPix ,TestPix )"},1)

' Dim RESisPngInterlaced as Integer = LeptonicaSharp._All.isPngInterlaced(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("isPngInterlaced",TestPix, RESisPngInterlaced,{"Dim RESisPngInterlaced as Integer = LeptonicaSharp._All.isPngInterlaced(TestPix ,New Integer)"},1)

' Dim RESfgetPngColormapInfo as Integer = LeptonicaSharp._All.fgetPngColormapInfo(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fgetPngColormapInfo",TestPix, RESfgetPngColormapInfo,{"Dim RESfgetPngColormapInfo as Integer = LeptonicaSharp._All.fgetPngColormapInfo(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWritePng as Integer = LeptonicaSharp._All.pixWritePng(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWritePng",TestPix, RESpixWritePng,{"Dim RESpixWritePng as Integer = LeptonicaSharp._All.pixWritePng(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamPng as Integer = LeptonicaSharp._All.pixWriteStreamPng(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamPng",TestPix, RESpixWriteStreamPng,{"Dim RESpixWriteStreamPng as Integer = LeptonicaSharp._All.pixWriteStreamPng(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetZlibCompression as Integer = LeptonicaSharp._All.pixSetZlibCompression(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetZlibCompression",TestPix, RESpixSetZlibCompression,{"Dim RESpixSetZlibCompression as Integer = LeptonicaSharp._All.pixSetZlibCompression(TestPix ,TestPix )"},1)

' Dim RESl_pngSetReadStrip16To8 as Object = LeptonicaSharp._All.l_pngSetReadStrip16To8(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_pngSetReadStrip16To8",TestPix, RESl_pngSetReadStrip16To8,{"Dim RESl_pngSetReadStrip16To8 as Object = LeptonicaSharp._All.l_pngSetReadStrip16To8(TestPix )"},1)

' Dim RESpixReadMemPng as Pix = LeptonicaSharp._All.pixReadMemPng(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemPng",TestPix, RESpixReadMemPng,{"Dim RESpixReadMemPng as Pix = LeptonicaSharp._All.pixReadMemPng(TestPix ,TestPix )"},1)

' Dim RESpixWriteMemPng as Integer = LeptonicaSharp._All.pixWriteMemPng(New Byte(),New UInteger,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemPng",TestPix, RESpixWriteMemPng,{"Dim RESpixWriteMemPng as Integer = LeptonicaSharp._All.pixWriteMemPng(New Byte(),New UInteger,TestPix ,TestPix )"},1)

' Dim RESpixReadStreamPnm as Pix = LeptonicaSharp._All.pixReadStreamPnm(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamPnm",TestPix, RESpixReadStreamPnm,{"Dim RESpixReadStreamPnm as Pix = LeptonicaSharp._All.pixReadStreamPnm(TestPix )"},1)

' Dim RESreadHeaderPnm as Integer = LeptonicaSharp._All.readHeaderPnm(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderPnm",TestPix, RESreadHeaderPnm,{"Dim RESreadHeaderPnm as Integer = LeptonicaSharp._All.readHeaderPnm(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfreadHeaderPnm as Integer = LeptonicaSharp._All.freadHeaderPnm(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderPnm",TestPix, RESfreadHeaderPnm,{"Dim RESfreadHeaderPnm as Integer = LeptonicaSharp._All.freadHeaderPnm(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixWriteStreamPnm as Integer = LeptonicaSharp._All.pixWriteStreamPnm(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamPnm",TestPix, RESpixWriteStreamPnm,{"Dim RESpixWriteStreamPnm as Integer = LeptonicaSharp._All.pixWriteStreamPnm(TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamAsciiPnm as Integer = LeptonicaSharp._All.pixWriteStreamAsciiPnm(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamAsciiPnm",TestPix, RESpixWriteStreamAsciiPnm,{"Dim RESpixWriteStreamAsciiPnm as Integer = LeptonicaSharp._All.pixWriteStreamAsciiPnm(TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamPam as Integer = LeptonicaSharp._All.pixWriteStreamPam(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamPam",TestPix, RESpixWriteStreamPam,{"Dim RESpixWriteStreamPam as Integer = LeptonicaSharp._All.pixWriteStreamPam(TestPix ,TestPix )"},1)

' Dim RESpixReadMemPnm as Pix = LeptonicaSharp._All.pixReadMemPnm(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemPnm",TestPix, RESpixReadMemPnm,{"Dim RESpixReadMemPnm as Pix = LeptonicaSharp._All.pixReadMemPnm(TestPix ,TestPix )"},1)

' Dim RESreadHeaderMemPnm as Integer = LeptonicaSharp._All.readHeaderMemPnm(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemPnm",TestPix, RESreadHeaderMemPnm,{"Dim RESreadHeaderMemPnm as Integer = LeptonicaSharp._All.readHeaderMemPnm(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixWriteMemPnm as Integer = LeptonicaSharp._All.pixWriteMemPnm(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemPnm",TestPix, RESpixWriteMemPnm,{"Dim RESpixWriteMemPnm as Integer = LeptonicaSharp._All.pixWriteMemPnm(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixWriteMemPam as Integer = LeptonicaSharp._All.pixWriteMemPam(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemPam",TestPix, RESpixWriteMemPam,{"Dim RESpixWriteMemPam as Integer = LeptonicaSharp._All.pixWriteMemPam(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixProjectiveSampledPta as Pix = LeptonicaSharp._All.pixProjectiveSampledPta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectiveSampledPta",TestPix, RESpixProjectiveSampledPta,{"Dim RESpixProjectiveSampledPta as Pix = LeptonicaSharp._All.pixProjectiveSampledPta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectiveSampled as Pix = LeptonicaSharp._All.pixProjectiveSampled(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectiveSampled",TestPix, RESpixProjectiveSampled,{"Dim RESpixProjectiveSampled as Pix = LeptonicaSharp._All.pixProjectiveSampled(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectivePta as Pix = LeptonicaSharp._All.pixProjectivePta(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectivePta",TestPix, RESpixProjectivePta,{"Dim RESpixProjectivePta as Pix = LeptonicaSharp._All.pixProjectivePta(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjective as Pix = LeptonicaSharp._All.pixProjective(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjective",TestPix, RESpixProjective,{"Dim RESpixProjective as Pix = LeptonicaSharp._All.pixProjective(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectivePtaColor as Pix = LeptonicaSharp._All.pixProjectivePtaColor(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectivePtaColor",TestPix, RESpixProjectivePtaColor,{"Dim RESpixProjectivePtaColor as Pix = LeptonicaSharp._All.pixProjectivePtaColor(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectiveColor as Pix = LeptonicaSharp._All.pixProjectiveColor(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectiveColor",TestPix, RESpixProjectiveColor,{"Dim RESpixProjectiveColor as Pix = LeptonicaSharp._All.pixProjectiveColor(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectivePtaGray as Pix = LeptonicaSharp._All.pixProjectivePtaGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectivePtaGray",TestPix, RESpixProjectivePtaGray,{"Dim RESpixProjectivePtaGray as Pix = LeptonicaSharp._All.pixProjectivePtaGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectiveGray as Pix = LeptonicaSharp._All.pixProjectiveGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectiveGray",TestPix, RESpixProjectiveGray,{"Dim RESpixProjectiveGray as Pix = LeptonicaSharp._All.pixProjectiveGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixProjectivePtaWithAlpha as Pix = LeptonicaSharp._All.pixProjectivePtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProjectivePtaWithAlpha",TestPix, RESpixProjectivePtaWithAlpha,{"Dim RESpixProjectivePtaWithAlpha as Pix = LeptonicaSharp._All.pixProjectivePtaWithAlpha(TestPix ,TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESgetProjectiveXformCoeffs as Integer = LeptonicaSharp._All.getProjectiveXformCoeffs(TestPix ,TestPix ,New List(Of Single()))
' LeptonicaSharp.Convert.WriteHelpExtension ("getProjectiveXformCoeffs",TestPix, RESgetProjectiveXformCoeffs,{"Dim RESgetProjectiveXformCoeffs as Integer = LeptonicaSharp._All.getProjectiveXformCoeffs(TestPix ,TestPix ,New List(Of Single()))"},1)

' Dim RESprojectiveXformSampledPt as Integer = LeptonicaSharp._All.projectiveXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("projectiveXformSampledPt",TestPix, RESprojectiveXformSampledPt,{"Dim RESprojectiveXformSampledPt as Integer = LeptonicaSharp._All.projectiveXformSampledPt(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESprojectiveXformPt as Integer = LeptonicaSharp._All.projectiveXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("projectiveXformPt",TestPix, RESprojectiveXformPt,{"Dim RESprojectiveXformPt as Integer = LeptonicaSharp._All.projectiveXformPt(TestPix ,TestPix ,TestPix ,New Single,New Single)"},1)

' Dim RESconvertFilesToPS as Integer = LeptonicaSharp._All.convertFilesToPS(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFilesToPS",TestPix, RESconvertFilesToPS,{"Dim RESconvertFilesToPS as Integer = LeptonicaSharp._All.convertFilesToPS(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayConvertFilesToPS as Integer = LeptonicaSharp._All.sarrayConvertFilesToPS(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayConvertFilesToPS",TestPix, RESsarrayConvertFilesToPS,{"Dim RESsarrayConvertFilesToPS as Integer = LeptonicaSharp._All.sarrayConvertFilesToPS(TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertFilesFittedToPS as Integer = LeptonicaSharp._All.convertFilesFittedToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFilesFittedToPS",TestPix, RESconvertFilesFittedToPS,{"Dim RESconvertFilesFittedToPS as Integer = LeptonicaSharp._All.convertFilesFittedToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayConvertFilesFittedToPS as Integer = LeptonicaSharp._All.sarrayConvertFilesFittedToPS(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayConvertFilesFittedToPS",TestPix, RESsarrayConvertFilesFittedToPS,{"Dim RESsarrayConvertFilesFittedToPS as Integer = LeptonicaSharp._All.sarrayConvertFilesFittedToPS(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESwriteImageCompressedToPSFile as Integer = LeptonicaSharp._All.writeImageCompressedToPSFile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("writeImageCompressedToPSFile",TestPix, RESwriteImageCompressedToPSFile,{"Dim RESwriteImageCompressedToPSFile as Integer = LeptonicaSharp._All.writeImageCompressedToPSFile(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertSegmentedPagesToPS as Integer = LeptonicaSharp._All.convertSegmentedPagesToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertSegmentedPagesToPS",TestPix, RESconvertSegmentedPagesToPS,{"Dim RESconvertSegmentedPagesToPS as Integer = LeptonicaSharp._All.convertSegmentedPagesToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteSegmentedPageToPS as Integer = LeptonicaSharp._All.pixWriteSegmentedPageToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteSegmentedPageToPS",TestPix, RESpixWriteSegmentedPageToPS,{"Dim RESpixWriteSegmentedPageToPS as Integer = LeptonicaSharp._All.pixWriteSegmentedPageToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteMixedToPS as Integer = LeptonicaSharp._All.pixWriteMixedToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMixedToPS",TestPix, RESpixWriteMixedToPS,{"Dim RESpixWriteMixedToPS as Integer = LeptonicaSharp._All.pixWriteMixedToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertToPSEmbed as Integer = LeptonicaSharp._All.convertToPSEmbed(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertToPSEmbed",TestPix, RESconvertToPSEmbed,{"Dim RESconvertToPSEmbed as Integer = LeptonicaSharp._All.convertToPSEmbed(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaWriteCompressedToPS as Integer = LeptonicaSharp._All.pixaWriteCompressedToPS(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteCompressedToPS",TestPix, RESpixaWriteCompressedToPS,{"Dim RESpixaWriteCompressedToPS as Integer = LeptonicaSharp._All.pixaWriteCompressedToPS(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWritePSEmbed as Integer = LeptonicaSharp._All.pixWritePSEmbed(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWritePSEmbed",TestPix, RESpixWritePSEmbed,{"Dim RESpixWritePSEmbed as Integer = LeptonicaSharp._All.pixWritePSEmbed(TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamPS as Integer = LeptonicaSharp._All.pixWriteStreamPS(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamPS",TestPix, RESpixWriteStreamPS,{"Dim RESpixWriteStreamPS as Integer = LeptonicaSharp._All.pixWriteStreamPS(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStringPS as String = LeptonicaSharp._All.pixWriteStringPS(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStringPS",TestPix, RESpixWriteStringPS,{"Dim RESpixWriteStringPS as String = LeptonicaSharp._All.pixWriteStringPS(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgenerateUncompressedPS as String = LeptonicaSharp._All.generateUncompressedPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generateUncompressedPS",TestPix, RESgenerateUncompressedPS,{"Dim RESgenerateUncompressedPS as String = LeptonicaSharp._All.generateUncompressedPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetScaledParametersPS as Object = LeptonicaSharp._All.getScaledParametersPS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("getScaledParametersPS",TestPix, RESgetScaledParametersPS,{"Dim RESgetScaledParametersPS as Object = LeptonicaSharp._All.getScaledParametersPS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,New Single,New Single)"},1)

' Dim RESconvertByteToHexAscii as Object = LeptonicaSharp._All.convertByteToHexAscii(TestPix ,New String,New String)
' LeptonicaSharp.Convert.WriteHelpExtension ("convertByteToHexAscii",TestPix, RESconvertByteToHexAscii,{"Dim RESconvertByteToHexAscii as Object = LeptonicaSharp._All.convertByteToHexAscii(TestPix ,New String,New String)"},1)

' Dim RESconvertJpegToPSEmbed as Integer = LeptonicaSharp._All.convertJpegToPSEmbed(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertJpegToPSEmbed",TestPix, RESconvertJpegToPSEmbed,{"Dim RESconvertJpegToPSEmbed as Integer = LeptonicaSharp._All.convertJpegToPSEmbed(TestPix ,TestPix )"},1)

' Dim RESconvertJpegToPS as Integer = LeptonicaSharp._All.convertJpegToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertJpegToPS",TestPix, RESconvertJpegToPS,{"Dim RESconvertJpegToPS as Integer = LeptonicaSharp._All.convertJpegToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertJpegToPSString as Integer = LeptonicaSharp._All.convertJpegToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertJpegToPSString",TestPix, RESconvertJpegToPSString,{"Dim RESconvertJpegToPSString as Integer = LeptonicaSharp._All.convertJpegToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgenerateJpegPS as String = LeptonicaSharp._All.generateJpegPS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generateJpegPS",TestPix, RESgenerateJpegPS,{"Dim RESgenerateJpegPS as String = LeptonicaSharp._All.generateJpegPS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertG4ToPSEmbed as Integer = LeptonicaSharp._All.convertG4ToPSEmbed(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertG4ToPSEmbed",TestPix, RESconvertG4ToPSEmbed,{"Dim RESconvertG4ToPSEmbed as Integer = LeptonicaSharp._All.convertG4ToPSEmbed(TestPix ,TestPix )"},1)

' Dim RESconvertG4ToPS as Integer = LeptonicaSharp._All.convertG4ToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertG4ToPS",TestPix, RESconvertG4ToPS,{"Dim RESconvertG4ToPS as Integer = LeptonicaSharp._All.convertG4ToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertG4ToPSString as Integer = LeptonicaSharp._All.convertG4ToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertG4ToPSString",TestPix, RESconvertG4ToPSString,{"Dim RESconvertG4ToPSString as Integer = LeptonicaSharp._All.convertG4ToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgenerateG4PS as String = LeptonicaSharp._All.generateG4PS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generateG4PS",TestPix, RESgenerateG4PS,{"Dim RESgenerateG4PS as String = LeptonicaSharp._All.generateG4PS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertTiffMultipageToPS as Integer = LeptonicaSharp._All.convertTiffMultipageToPS(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertTiffMultipageToPS",TestPix, RESconvertTiffMultipageToPS,{"Dim RESconvertTiffMultipageToPS as Integer = LeptonicaSharp._All.convertTiffMultipageToPS(TestPix ,TestPix ,Nothing )"},1)

' Dim RESconvertFlateToPSEmbed as Integer = LeptonicaSharp._All.convertFlateToPSEmbed(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFlateToPSEmbed",TestPix, RESconvertFlateToPSEmbed,{"Dim RESconvertFlateToPSEmbed as Integer = LeptonicaSharp._All.convertFlateToPSEmbed(TestPix ,TestPix )"},1)

' Dim RESconvertFlateToPS as Integer = LeptonicaSharp._All.convertFlateToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFlateToPS",TestPix, RESconvertFlateToPS,{"Dim RESconvertFlateToPS as Integer = LeptonicaSharp._All.convertFlateToPS(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESconvertFlateToPSString as Integer = LeptonicaSharp._All.convertFlateToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertFlateToPSString",TestPix, RESconvertFlateToPSString,{"Dim RESconvertFlateToPSString as Integer = LeptonicaSharp._All.convertFlateToPSString(TestPix ,New String(),New Integer,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgenerateFlatePS as String = LeptonicaSharp._All.generateFlatePS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("generateFlatePS",TestPix, RESgenerateFlatePS,{"Dim RESgenerateFlatePS as String = LeptonicaSharp._All.generateFlatePS(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteMemPS as Integer = LeptonicaSharp._All.pixWriteMemPS(New Byte(),New UInteger,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemPS",TestPix, RESpixWriteMemPS,{"Dim RESpixWriteMemPS as Integer = LeptonicaSharp._All.pixWriteMemPS(New Byte(),New UInteger,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESgetResLetterPage as Integer = LeptonicaSharp._All.getResLetterPage(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getResLetterPage",TestPix, RESgetResLetterPage,{"Dim RESgetResLetterPage as Integer = LeptonicaSharp._All.getResLetterPage(TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetResA4Page as Integer = LeptonicaSharp._All.getResA4Page(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getResA4Page",TestPix, RESgetResA4Page,{"Dim RESgetResA4Page as Integer = LeptonicaSharp._All.getResA4Page(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_psWriteBoundingBox as Object = LeptonicaSharp._All.l_psWriteBoundingBox(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_psWriteBoundingBox",TestPix, RESl_psWriteBoundingBox,{"Dim RESl_psWriteBoundingBox as Object = LeptonicaSharp._All.l_psWriteBoundingBox(TestPix )"},1)

' Dim RESptaCreate as Pta = LeptonicaSharp._All.ptaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCreate",TestPix, RESptaCreate,{"Dim RESptaCreate as Pta = LeptonicaSharp._All.ptaCreate(TestPix )"},1)

' Dim RESptaCreateFromNuma as Pta = LeptonicaSharp._All.ptaCreateFromNuma(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCreateFromNuma",TestPix, RESptaCreateFromNuma,{"Dim RESptaCreateFromNuma as Pta = LeptonicaSharp._All.ptaCreateFromNuma(Nothing ,TestPix )"},1)

' Dim RESptaDestroy as Object = LeptonicaSharp._All.ptaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaDestroy",TestPix, RESptaDestroy,{"Dim RESptaDestroy as Object = LeptonicaSharp._All.ptaDestroy(TestPix )"},1)

' Dim RESptaCopy as Pta = LeptonicaSharp._All.ptaCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCopy",TestPix, RESptaCopy,{"Dim RESptaCopy as Pta = LeptonicaSharp._All.ptaCopy(TestPix )"},1)

' Dim RESptaCopyRange as Pta = LeptonicaSharp._All.ptaCopyRange(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCopyRange",TestPix, RESptaCopyRange,{"Dim RESptaCopyRange as Pta = LeptonicaSharp._All.ptaCopyRange(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaClone as Pta = LeptonicaSharp._All.ptaClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaClone",TestPix, RESptaClone,{"Dim RESptaClone as Pta = LeptonicaSharp._All.ptaClone(TestPix )"},1)

' Dim RESptaEmpty as Integer = LeptonicaSharp._All.ptaEmpty(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaEmpty",TestPix, RESptaEmpty,{"Dim RESptaEmpty as Integer = LeptonicaSharp._All.ptaEmpty(TestPix )"},1)

' Dim RESptaAddPt as Integer = LeptonicaSharp._All.ptaAddPt(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaAddPt",TestPix, RESptaAddPt,{"Dim RESptaAddPt as Integer = LeptonicaSharp._All.ptaAddPt(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaInsertPt as Integer = LeptonicaSharp._All.ptaInsertPt(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaInsertPt",TestPix, RESptaInsertPt,{"Dim RESptaInsertPt as Integer = LeptonicaSharp._All.ptaInsertPt(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaRemovePt as Integer = LeptonicaSharp._All.ptaRemovePt(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaRemovePt",TestPix, RESptaRemovePt,{"Dim RESptaRemovePt as Integer = LeptonicaSharp._All.ptaRemovePt(TestPix ,TestPix )"},1)

' Dim RESptaGetRefcount as Integer = LeptonicaSharp._All.ptaGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetRefcount",TestPix, RESptaGetRefcount,{"Dim RESptaGetRefcount as Integer = LeptonicaSharp._All.ptaGetRefcount(TestPix )"},1)

' Dim RESptaChangeRefcount as Integer = LeptonicaSharp._All.ptaChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaChangeRefcount",TestPix, RESptaChangeRefcount,{"Dim RESptaChangeRefcount as Integer = LeptonicaSharp._All.ptaChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESptaGetCount as Integer = LeptonicaSharp._All.ptaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetCount",TestPix, RESptaGetCount,{"Dim RESptaGetCount as Integer = LeptonicaSharp._All.ptaGetCount(TestPix )"},1)

' Dim RESptaGetPt as Integer = LeptonicaSharp._All.ptaGetPt(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetPt",TestPix, RESptaGetPt,{"Dim RESptaGetPt as Integer = LeptonicaSharp._All.ptaGetPt(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaGetIPt as Integer = LeptonicaSharp._All.ptaGetIPt(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetIPt",TestPix, RESptaGetIPt,{"Dim RESptaGetIPt as Integer = LeptonicaSharp._All.ptaGetIPt(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaSetPt as Integer = LeptonicaSharp._All.ptaSetPt(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSetPt",TestPix, RESptaSetPt,{"Dim RESptaSetPt as Integer = LeptonicaSharp._All.ptaSetPt(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaGetArrays as Integer = LeptonicaSharp._All.ptaGetArrays(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetArrays",TestPix, RESptaGetArrays,{"Dim RESptaGetArrays as Integer = LeptonicaSharp._All.ptaGetArrays(TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaRead as Pta = LeptonicaSharp._All.ptaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaRead",TestPix, RESptaRead,{"Dim RESptaRead as Pta = LeptonicaSharp._All.ptaRead(TestPix )"},1)

' Dim RESptaReadStream as Pta = LeptonicaSharp._All.ptaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaReadStream",TestPix, RESptaReadStream,{"Dim RESptaReadStream as Pta = LeptonicaSharp._All.ptaReadStream(TestPix )"},1)

' Dim RESptaReadMem as Pta = LeptonicaSharp._All.ptaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaReadMem",TestPix, RESptaReadMem,{"Dim RESptaReadMem as Pta = LeptonicaSharp._All.ptaReadMem(TestPix ,TestPix )"},1)

' Dim RESptaWriteDebug as Integer = LeptonicaSharp._All.ptaWriteDebug(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaWriteDebug",TestPix, RESptaWriteDebug,{"Dim RESptaWriteDebug as Integer = LeptonicaSharp._All.ptaWriteDebug(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaWrite as Integer = LeptonicaSharp._All.ptaWrite(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaWrite",TestPix, RESptaWrite,{"Dim RESptaWrite as Integer = LeptonicaSharp._All.ptaWrite(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaWriteStream as Integer = LeptonicaSharp._All.ptaWriteStream(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaWriteStream",TestPix, RESptaWriteStream,{"Dim RESptaWriteStream as Integer = LeptonicaSharp._All.ptaWriteStream(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaWriteMem as Integer = LeptonicaSharp._All.ptaWriteMem(New Byte(),New UInteger,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaWriteMem",TestPix, RESptaWriteMem,{"Dim RESptaWriteMem as Integer = LeptonicaSharp._All.ptaWriteMem(New Byte(),New UInteger,TestPix ,TestPix )"},1)

' Dim RESptaaCreate as Ptaa = LeptonicaSharp._All.ptaaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaCreate",TestPix, RESptaaCreate,{"Dim RESptaaCreate as Ptaa = LeptonicaSharp._All.ptaaCreate(TestPix )"},1)

' Dim RESptaaDestroy as Object = LeptonicaSharp._All.ptaaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaDestroy",TestPix, RESptaaDestroy,{"Dim RESptaaDestroy as Object = LeptonicaSharp._All.ptaaDestroy(TestPix )"},1)

' Dim RESptaaAddPta as Integer = LeptonicaSharp._All.ptaaAddPta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaAddPta",TestPix, RESptaaAddPta,{"Dim RESptaaAddPta as Integer = LeptonicaSharp._All.ptaaAddPta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaGetCount as Integer = LeptonicaSharp._All.ptaaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaGetCount",TestPix, RESptaaGetCount,{"Dim RESptaaGetCount as Integer = LeptonicaSharp._All.ptaaGetCount(TestPix )"},1)

' Dim RESptaaGetPta as Pta = LeptonicaSharp._All.ptaaGetPta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaGetPta",TestPix, RESptaaGetPta,{"Dim RESptaaGetPta as Pta = LeptonicaSharp._All.ptaaGetPta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaGetPt as Integer = LeptonicaSharp._All.ptaaGetPt(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaGetPt",TestPix, RESptaaGetPt,{"Dim RESptaaGetPt as Integer = LeptonicaSharp._All.ptaaGetPt(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaaInitFull as Integer = LeptonicaSharp._All.ptaaInitFull(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaInitFull",TestPix, RESptaaInitFull,{"Dim RESptaaInitFull as Integer = LeptonicaSharp._All.ptaaInitFull(TestPix ,TestPix )"},1)

' Dim RESptaaReplacePta as Integer = LeptonicaSharp._All.ptaaReplacePta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaReplacePta",TestPix, RESptaaReplacePta,{"Dim RESptaaReplacePta as Integer = LeptonicaSharp._All.ptaaReplacePta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaAddPt as Integer = LeptonicaSharp._All.ptaaAddPt(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaAddPt",TestPix, RESptaaAddPt,{"Dim RESptaaAddPt as Integer = LeptonicaSharp._All.ptaaAddPt(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaTruncate as Integer = LeptonicaSharp._All.ptaaTruncate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaTruncate",TestPix, RESptaaTruncate,{"Dim RESptaaTruncate as Integer = LeptonicaSharp._All.ptaaTruncate(TestPix )"},1)

' Dim RESptaaRead as Ptaa = LeptonicaSharp._All.ptaaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaRead",TestPix, RESptaaRead,{"Dim RESptaaRead as Ptaa = LeptonicaSharp._All.ptaaRead(TestPix )"},1)

' Dim RESptaaReadStream as Ptaa = LeptonicaSharp._All.ptaaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaReadStream",TestPix, RESptaaReadStream,{"Dim RESptaaReadStream as Ptaa = LeptonicaSharp._All.ptaaReadStream(TestPix )"},1)

' Dim RESptaaReadMem as Ptaa = LeptonicaSharp._All.ptaaReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaReadMem",TestPix, RESptaaReadMem,{"Dim RESptaaReadMem as Ptaa = LeptonicaSharp._All.ptaaReadMem(TestPix ,TestPix )"},1)

' Dim RESptaaWriteDebug as Integer = LeptonicaSharp._All.ptaaWriteDebug(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaWriteDebug",TestPix, RESptaaWriteDebug,{"Dim RESptaaWriteDebug as Integer = LeptonicaSharp._All.ptaaWriteDebug(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaWrite as Integer = LeptonicaSharp._All.ptaaWrite(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaWrite",TestPix, RESptaaWrite,{"Dim RESptaaWrite as Integer = LeptonicaSharp._All.ptaaWrite(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaWriteStream as Integer = LeptonicaSharp._All.ptaaWriteStream(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaWriteStream",TestPix, RESptaaWriteStream,{"Dim RESptaaWriteStream as Integer = LeptonicaSharp._All.ptaaWriteStream(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaWriteMem as Integer = LeptonicaSharp._All.ptaaWriteMem(New Byte(),New UInteger,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaWriteMem",TestPix, RESptaaWriteMem,{"Dim RESptaaWriteMem as Integer = LeptonicaSharp._All.ptaaWriteMem(New Byte(),New UInteger,TestPix ,TestPix )"},1)

' Dim RESptaSubsample as Pta = LeptonicaSharp._All.ptaSubsample(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSubsample",TestPix, RESptaSubsample,{"Dim RESptaSubsample as Pta = LeptonicaSharp._All.ptaSubsample(TestPix ,TestPix )"},1)

' Dim RESptaJoin as Integer = LeptonicaSharp._All.ptaJoin(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaJoin",TestPix, RESptaJoin,{"Dim RESptaJoin as Integer = LeptonicaSharp._All.ptaJoin(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaaJoin as Integer = LeptonicaSharp._All.ptaaJoin(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaJoin",TestPix, RESptaaJoin,{"Dim RESptaaJoin as Integer = LeptonicaSharp._All.ptaaJoin(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaReverse as Pta = LeptonicaSharp._All.ptaReverse(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaReverse",TestPix, RESptaReverse,{"Dim RESptaReverse as Pta = LeptonicaSharp._All.ptaReverse(TestPix ,TestPix )"},1)

' Dim RESptaTranspose as Pta = LeptonicaSharp._All.ptaTranspose(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaTranspose",TestPix, RESptaTranspose,{"Dim RESptaTranspose as Pta = LeptonicaSharp._All.ptaTranspose(TestPix )"},1)

' Dim RESptaCyclicPerm as Pta = LeptonicaSharp._All.ptaCyclicPerm(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCyclicPerm",TestPix, RESptaCyclicPerm,{"Dim RESptaCyclicPerm as Pta = LeptonicaSharp._All.ptaCyclicPerm(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaSelectRange as Pta = LeptonicaSharp._All.ptaSelectRange(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSelectRange",TestPix, RESptaSelectRange,{"Dim RESptaSelectRange as Pta = LeptonicaSharp._All.ptaSelectRange(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaGetBoundingRegion as Box = LeptonicaSharp._All.ptaGetBoundingRegion(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetBoundingRegion",TestPix, RESptaGetBoundingRegion,{"Dim RESptaGetBoundingRegion as Box = LeptonicaSharp._All.ptaGetBoundingRegion(TestPix )"},1)

' Dim RESptaGetRange as Integer = LeptonicaSharp._All.ptaGetRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetRange",TestPix, RESptaGetRange,{"Dim RESptaGetRange as Integer = LeptonicaSharp._All.ptaGetRange(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaGetInsideBox as Pta = LeptonicaSharp._All.ptaGetInsideBox(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetInsideBox",TestPix, RESptaGetInsideBox,{"Dim RESptaGetInsideBox as Pta = LeptonicaSharp._All.ptaGetInsideBox(TestPix ,TestPix )"},1)

' Dim RESpixFindCornerPixels as Pta = LeptonicaSharp._All.pixFindCornerPixels(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindCornerPixels",TestPix, RESpixFindCornerPixels,{"Dim RESpixFindCornerPixels as Pta = LeptonicaSharp._All.pixFindCornerPixels(TestPix )"},1)

' Dim RESptaContainsPt as Integer = LeptonicaSharp._All.ptaContainsPt(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaContainsPt",TestPix, RESptaContainsPt,{"Dim RESptaContainsPt as Integer = LeptonicaSharp._All.ptaContainsPt(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaTestIntersection as Integer = LeptonicaSharp._All.ptaTestIntersection(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaTestIntersection",TestPix, RESptaTestIntersection,{"Dim RESptaTestIntersection as Integer = LeptonicaSharp._All.ptaTestIntersection(TestPix ,TestPix )"},1)

' Dim RESptaTransform as Pta = LeptonicaSharp._All.ptaTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaTransform",TestPix, RESptaTransform,{"Dim RESptaTransform as Pta = LeptonicaSharp._All.ptaTransform(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaPtInsidePolygon as Integer = LeptonicaSharp._All.ptaPtInsidePolygon(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaPtInsidePolygon",TestPix, RESptaPtInsidePolygon,{"Dim RESptaPtInsidePolygon as Integer = LeptonicaSharp._All.ptaPtInsidePolygon(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESl_angleBetweenVectors as Single = LeptonicaSharp._All.l_angleBetweenVectors(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_angleBetweenVectors",TestPix, RESl_angleBetweenVectors,{"Dim RESl_angleBetweenVectors as Single = LeptonicaSharp._All.l_angleBetweenVectors(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaGetMinMax as Integer = LeptonicaSharp._All.ptaGetMinMax(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetMinMax",TestPix, RESptaGetMinMax,{"Dim RESptaGetMinMax as Integer = LeptonicaSharp._All.ptaGetMinMax(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaSelectByValue as Pta = LeptonicaSharp._All.ptaSelectByValue(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSelectByValue",TestPix, RESptaSelectByValue,{"Dim RESptaSelectByValue as Pta = LeptonicaSharp._All.ptaSelectByValue(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaCropToMask as Pta = LeptonicaSharp._All.ptaCropToMask(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaCropToMask",TestPix, RESptaCropToMask,{"Dim RESptaCropToMask as Pta = LeptonicaSharp._All.ptaCropToMask(TestPix ,TestPix )"},1)

' Dim RESptaGetLinearLSF as Integer = LeptonicaSharp._All.ptaGetLinearLSF(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetLinearLSF",TestPix, RESptaGetLinearLSF,{"Dim RESptaGetLinearLSF as Integer = LeptonicaSharp._All.ptaGetLinearLSF(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaGetQuadraticLSF as Integer = LeptonicaSharp._All.ptaGetQuadraticLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetQuadraticLSF",TestPix, RESptaGetQuadraticLSF,{"Dim RESptaGetQuadraticLSF as Integer = LeptonicaSharp._All.ptaGetQuadraticLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaGetCubicLSF as Integer = LeptonicaSharp._All.ptaGetCubicLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetCubicLSF",TestPix, RESptaGetCubicLSF,{"Dim RESptaGetCubicLSF as Integer = LeptonicaSharp._All.ptaGetCubicLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaGetQuarticLSF as Integer = LeptonicaSharp._All.ptaGetQuarticLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetQuarticLSF",TestPix, RESptaGetQuarticLSF,{"Dim RESptaGetQuarticLSF as Integer = LeptonicaSharp._All.ptaGetQuarticLSF(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaNoisyLinearLSF as Integer = LeptonicaSharp._All.ptaNoisyLinearLSF(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaNoisyLinearLSF",TestPix, RESptaNoisyLinearLSF,{"Dim RESptaNoisyLinearLSF as Integer = LeptonicaSharp._All.ptaNoisyLinearLSF(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESptaNoisyQuadraticLSF as Integer = LeptonicaSharp._All.ptaNoisyQuadraticLSF(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaNoisyQuadraticLSF",TestPix, RESptaNoisyQuadraticLSF,{"Dim RESptaNoisyQuadraticLSF as Integer = LeptonicaSharp._All.ptaNoisyQuadraticLSF(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESapplyLinearFit as Integer = LeptonicaSharp._All.applyLinearFit(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("applyLinearFit",TestPix, RESapplyLinearFit,{"Dim RESapplyLinearFit as Integer = LeptonicaSharp._All.applyLinearFit(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESapplyQuadraticFit as Integer = LeptonicaSharp._All.applyQuadraticFit(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("applyQuadraticFit",TestPix, RESapplyQuadraticFit,{"Dim RESapplyQuadraticFit as Integer = LeptonicaSharp._All.applyQuadraticFit(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESapplyCubicFit as Integer = LeptonicaSharp._All.applyCubicFit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("applyCubicFit",TestPix, RESapplyCubicFit,{"Dim RESapplyCubicFit as Integer = LeptonicaSharp._All.applyCubicFit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESapplyQuarticFit as Integer = LeptonicaSharp._All.applyQuarticFit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("applyQuarticFit",TestPix, RESapplyQuarticFit,{"Dim RESapplyQuarticFit as Integer = LeptonicaSharp._All.applyQuarticFit(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixPlotAlongPta as Integer = LeptonicaSharp._All.pixPlotAlongPta(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixPlotAlongPta",TestPix, RESpixPlotAlongPta,{"Dim RESpixPlotAlongPta as Integer = LeptonicaSharp._All.pixPlotAlongPta(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESptaGetPixelsFromPix as Pta = LeptonicaSharp._All.ptaGetPixelsFromPix(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetPixelsFromPix",TestPix, RESptaGetPixelsFromPix,{"Dim RESptaGetPixelsFromPix as Pta = LeptonicaSharp._All.ptaGetPixelsFromPix(TestPix ,Nothing )"},1)

' Dim RESpixGenerateFromPta as Pix = LeptonicaSharp._All.pixGenerateFromPta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateFromPta",TestPix, RESpixGenerateFromPta,{"Dim RESpixGenerateFromPta as Pix = LeptonicaSharp._All.pixGenerateFromPta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaGetBoundaryPixels as Pta = LeptonicaSharp._All.ptaGetBoundaryPixels(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetBoundaryPixels",TestPix, RESptaGetBoundaryPixels,{"Dim RESptaGetBoundaryPixels as Pta = LeptonicaSharp._All.ptaGetBoundaryPixels(TestPix ,TestPix )"},1)

' Dim RESptaaGetBoundaryPixels as Ptaa = LeptonicaSharp._All.ptaaGetBoundaryPixels(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaGetBoundaryPixels",TestPix, RESptaaGetBoundaryPixels,{"Dim RESptaaGetBoundaryPixels as Ptaa = LeptonicaSharp._All.ptaaGetBoundaryPixels(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESptaaIndexLabeledPixels as Ptaa = LeptonicaSharp._All.ptaaIndexLabeledPixels(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaIndexLabeledPixels",TestPix, RESptaaIndexLabeledPixels,{"Dim RESptaaIndexLabeledPixels as Ptaa = LeptonicaSharp._All.ptaaIndexLabeledPixels(TestPix ,Nothing )"},1)

' Dim RESptaGetNeighborPixLocs as Pta = LeptonicaSharp._All.ptaGetNeighborPixLocs(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetNeighborPixLocs",TestPix, RESptaGetNeighborPixLocs,{"Dim RESptaGetNeighborPixLocs as Pta = LeptonicaSharp._All.ptaGetNeighborPixLocs(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaConvertToPta1 as Pta = LeptonicaSharp._All.numaConvertToPta1(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaConvertToPta1",TestPix, RESnumaConvertToPta1,{"Dim RESnumaConvertToPta1 as Pta = LeptonicaSharp._All.numaConvertToPta1(TestPix )"},1)

' Dim RESnumaConvertToPta2 as Pta = LeptonicaSharp._All.numaConvertToPta2(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaConvertToPta2",TestPix, RESnumaConvertToPta2,{"Dim RESnumaConvertToPta2 as Pta = LeptonicaSharp._All.numaConvertToPta2(TestPix ,TestPix )"},1)

' Dim RESptaConvertToNuma as Integer = LeptonicaSharp._All.ptaConvertToNuma(TestPix ,New Numa,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaConvertToNuma",TestPix, RESptaConvertToNuma,{"Dim RESptaConvertToNuma as Integer = LeptonicaSharp._All.ptaConvertToNuma(TestPix ,New Numa,New Numa)"},1)

' Dim RESpixDisplayPta as Pix = LeptonicaSharp._All.pixDisplayPta(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayPta",TestPix, RESpixDisplayPta,{"Dim RESpixDisplayPta as Pix = LeptonicaSharp._All.pixDisplayPta(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayPtaaPattern as Pix = LeptonicaSharp._All.pixDisplayPtaaPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayPtaaPattern",TestPix, RESpixDisplayPtaaPattern,{"Dim RESpixDisplayPtaaPattern as Pix = LeptonicaSharp._All.pixDisplayPtaaPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayPtaPattern as Pix = LeptonicaSharp._All.pixDisplayPtaPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayPtaPattern",TestPix, RESpixDisplayPtaPattern,{"Dim RESpixDisplayPtaPattern as Pix = LeptonicaSharp._All.pixDisplayPtaPattern(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptaReplicatePattern as Pta = LeptonicaSharp._All.ptaReplicatePattern(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaReplicatePattern",TestPix, RESptaReplicatePattern,{"Dim RESptaReplicatePattern as Pta = LeptonicaSharp._All.ptaReplicatePattern(TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayPtaa as Pix = LeptonicaSharp._All.pixDisplayPtaa(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayPtaa",TestPix, RESpixDisplayPtaa,{"Dim RESpixDisplayPtaa as Pix = LeptonicaSharp._All.pixDisplayPtaa(TestPix ,TestPix )"},1)

' Dim RESptaSort as Pta = LeptonicaSharp._All.ptaSort(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSort",TestPix, RESptaSort,{"Dim RESptaSort as Pta = LeptonicaSharp._All.ptaSort(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESptaGetSortIndex as Integer = LeptonicaSharp._All.ptaGetSortIndex(TestPix ,TestPix ,TestPix ,New Numa)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetSortIndex",TestPix, RESptaGetSortIndex,{"Dim RESptaGetSortIndex as Integer = LeptonicaSharp._All.ptaGetSortIndex(TestPix ,TestPix ,TestPix ,New Numa)"},1)

' Dim RESptaSortByIndex as Pta = LeptonicaSharp._All.ptaSortByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaSortByIndex",TestPix, RESptaSortByIndex,{"Dim RESptaSortByIndex as Pta = LeptonicaSharp._All.ptaSortByIndex(TestPix ,TestPix )"},1)

' Dim RESptaaSortByIndex as Ptaa = LeptonicaSharp._All.ptaaSortByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaaSortByIndex",TestPix, RESptaaSortByIndex,{"Dim RESptaaSortByIndex as Ptaa = LeptonicaSharp._All.ptaaSortByIndex(TestPix ,TestPix )"},1)

' Dim RESptaGetRankValue as Integer = LeptonicaSharp._All.ptaGetRankValue(TestPix ,TestPix ,Nothing ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaGetRankValue",TestPix, RESptaGetRankValue,{"Dim RESptaGetRankValue as Integer = LeptonicaSharp._All.ptaGetRankValue(TestPix ,TestPix ,Nothing ,TestPix ,New Single)"},1)

' Dim RESptaUnionByAset as Pta = LeptonicaSharp._All.ptaUnionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaUnionByAset",TestPix, RESptaUnionByAset,{"Dim RESptaUnionByAset as Pta = LeptonicaSharp._All.ptaUnionByAset(TestPix ,TestPix )"},1)

' Dim RESptaRemoveDupsByAset as Pta = LeptonicaSharp._All.ptaRemoveDupsByAset(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaRemoveDupsByAset",TestPix, RESptaRemoveDupsByAset,{"Dim RESptaRemoveDupsByAset as Pta = LeptonicaSharp._All.ptaRemoveDupsByAset(TestPix )"},1)

' Dim RESptaIntersectionByAset as Pta = LeptonicaSharp._All.ptaIntersectionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaIntersectionByAset",TestPix, RESptaIntersectionByAset,{"Dim RESptaIntersectionByAset as Pta = LeptonicaSharp._All.ptaIntersectionByAset(TestPix ,TestPix )"},1)

' Dim RESl_asetCreateFromPta as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromPta(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetCreateFromPta",TestPix, RESl_asetCreateFromPta,{"Dim RESl_asetCreateFromPta as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromPta(TestPix )"},1)

' Dim RESptaUnionByHash as Pta = LeptonicaSharp._All.ptaUnionByHash(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaUnionByHash",TestPix, RESptaUnionByHash,{"Dim RESptaUnionByHash as Pta = LeptonicaSharp._All.ptaUnionByHash(TestPix ,TestPix )"},1)

' Dim RESptaRemoveDupsByHash as Integer = LeptonicaSharp._All.ptaRemoveDupsByHash(TestPix ,New Pta,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaRemoveDupsByHash",TestPix, RESptaRemoveDupsByHash,{"Dim RESptaRemoveDupsByHash as Integer = LeptonicaSharp._All.ptaRemoveDupsByHash(TestPix ,New Pta,Nothing )"},1)

' Dim RESptaIntersectionByHash as Pta = LeptonicaSharp._All.ptaIntersectionByHash(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaIntersectionByHash",TestPix, RESptaIntersectionByHash,{"Dim RESptaIntersectionByHash as Pta = LeptonicaSharp._All.ptaIntersectionByHash(TestPix ,TestPix )"},1)

' Dim RESptaFindPtByHash as Integer = LeptonicaSharp._All.ptaFindPtByHash(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptaFindPtByHash",TestPix, RESptaFindPtByHash,{"Dim RESptaFindPtByHash as Integer = LeptonicaSharp._All.ptaFindPtByHash(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESl_dnaHashCreateFromPta as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromPta(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashCreateFromPta",TestPix, RESl_dnaHashCreateFromPta,{"Dim RESl_dnaHashCreateFromPta as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromPta(TestPix )"},1)

' Dim RESptraCreate as L_Ptra = LeptonicaSharp._All.ptraCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraCreate",TestPix, RESptraCreate,{"Dim RESptraCreate as L_Ptra = LeptonicaSharp._All.ptraCreate(TestPix )"},1)

' Dim RESptraDestroy as Object = LeptonicaSharp._All.ptraDestroy(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraDestroy",TestPix, RESptraDestroy,{"Dim RESptraDestroy as Object = LeptonicaSharp._All.ptraDestroy(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraAdd as Integer = LeptonicaSharp._All.ptraAdd(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraAdd",TestPix, RESptraAdd,{"Dim RESptraAdd as Integer = LeptonicaSharp._All.ptraAdd(TestPix ,TestPix )"},1)

' Dim RESptraInsert as Integer = LeptonicaSharp._All.ptraInsert(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraInsert",TestPix, RESptraInsert,{"Dim RESptraInsert as Integer = LeptonicaSharp._All.ptraInsert(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraRemove as Object = LeptonicaSharp._All.ptraRemove(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraRemove",TestPix, RESptraRemove,{"Dim RESptraRemove as Object = LeptonicaSharp._All.ptraRemove(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraRemoveLast as Object = LeptonicaSharp._All.ptraRemoveLast(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraRemoveLast",TestPix, RESptraRemoveLast,{"Dim RESptraRemoveLast as Object = LeptonicaSharp._All.ptraRemoveLast(TestPix )"},1)

' Dim RESptraReplace as Object = LeptonicaSharp._All.ptraReplace(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraReplace",TestPix, RESptraReplace,{"Dim RESptraReplace as Object = LeptonicaSharp._All.ptraReplace(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraSwap as Integer = LeptonicaSharp._All.ptraSwap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraSwap",TestPix, RESptraSwap,{"Dim RESptraSwap as Integer = LeptonicaSharp._All.ptraSwap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraCompactArray as Integer = LeptonicaSharp._All.ptraCompactArray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraCompactArray",TestPix, RESptraCompactArray,{"Dim RESptraCompactArray as Integer = LeptonicaSharp._All.ptraCompactArray(TestPix )"},1)

' Dim RESptraReverse as Integer = LeptonicaSharp._All.ptraReverse(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraReverse",TestPix, RESptraReverse,{"Dim RESptraReverse as Integer = LeptonicaSharp._All.ptraReverse(TestPix )"},1)

' Dim RESptraJoin as Integer = LeptonicaSharp._All.ptraJoin(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraJoin",TestPix, RESptraJoin,{"Dim RESptraJoin as Integer = LeptonicaSharp._All.ptraJoin(TestPix ,TestPix )"},1)

' Dim RESptraGetMaxIndex as Integer = LeptonicaSharp._All.ptraGetMaxIndex(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraGetMaxIndex",TestPix, RESptraGetMaxIndex,{"Dim RESptraGetMaxIndex as Integer = LeptonicaSharp._All.ptraGetMaxIndex(TestPix ,New Integer)"},1)

' Dim RESptraGetActualCount as Integer = LeptonicaSharp._All.ptraGetActualCount(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraGetActualCount",TestPix, RESptraGetActualCount,{"Dim RESptraGetActualCount as Integer = LeptonicaSharp._All.ptraGetActualCount(TestPix ,New Integer)"},1)

' Dim RESptraGetPtrToItem as Object = LeptonicaSharp._All.ptraGetPtrToItem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraGetPtrToItem",TestPix, RESptraGetPtrToItem,{"Dim RESptraGetPtrToItem as Object = LeptonicaSharp._All.ptraGetPtrToItem(TestPix ,TestPix )"},1)

' Dim RESptraaCreate as L_Ptraa = LeptonicaSharp._All.ptraaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaCreate",TestPix, RESptraaCreate,{"Dim RESptraaCreate as L_Ptraa = LeptonicaSharp._All.ptraaCreate(TestPix )"},1)

' Dim RESptraaDestroy as Object = LeptonicaSharp._All.ptraaDestroy(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaDestroy",TestPix, RESptraaDestroy,{"Dim RESptraaDestroy as Object = LeptonicaSharp._All.ptraaDestroy(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraaGetSize as Integer = LeptonicaSharp._All.ptraaGetSize(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaGetSize",TestPix, RESptraaGetSize,{"Dim RESptraaGetSize as Integer = LeptonicaSharp._All.ptraaGetSize(TestPix ,New Integer)"},1)

' Dim RESptraaInsertPtra as Integer = LeptonicaSharp._All.ptraaInsertPtra(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaInsertPtra",TestPix, RESptraaInsertPtra,{"Dim RESptraaInsertPtra as Integer = LeptonicaSharp._All.ptraaInsertPtra(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraaGetPtra as L_Ptra = LeptonicaSharp._All.ptraaGetPtra(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaGetPtra",TestPix, RESptraaGetPtra,{"Dim RESptraaGetPtra as L_Ptra = LeptonicaSharp._All.ptraaGetPtra(TestPix ,TestPix ,TestPix )"},1)

' Dim RESptraaFlattenToPtra as L_Ptra = LeptonicaSharp._All.ptraaFlattenToPtra(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ptraaFlattenToPtra",TestPix, RESptraaFlattenToPtra,{"Dim RESptraaFlattenToPtra as L_Ptra = LeptonicaSharp._All.ptraaFlattenToPtra(TestPix )"},1)

' Dim RESpixQuadtreeMean as Integer = LeptonicaSharp._All.pixQuadtreeMean(TestPix ,TestPix ,TestPix ,New FPixa)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuadtreeMean",TestPix, RESpixQuadtreeMean,{"Dim RESpixQuadtreeMean as Integer = LeptonicaSharp._All.pixQuadtreeMean(TestPix ,TestPix ,TestPix ,New FPixa)"},1)

' Dim RESpixQuadtreeVariance as Integer = LeptonicaSharp._All.pixQuadtreeVariance(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuadtreeVariance",TestPix, RESpixQuadtreeVariance,{"Dim RESpixQuadtreeVariance as Integer = LeptonicaSharp._All.pixQuadtreeVariance(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixMeanInRectangle as Integer = LeptonicaSharp._All.pixMeanInRectangle(TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMeanInRectangle",TestPix, RESpixMeanInRectangle,{"Dim RESpixMeanInRectangle as Integer = LeptonicaSharp._All.pixMeanInRectangle(TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESpixVarianceInRectangle as Integer = LeptonicaSharp._All.pixVarianceInRectangle(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVarianceInRectangle",TestPix, RESpixVarianceInRectangle,{"Dim RESpixVarianceInRectangle as Integer = LeptonicaSharp._All.pixVarianceInRectangle(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESboxaaQuadtreeRegions as Boxaa = LeptonicaSharp._All.boxaaQuadtreeRegions(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("boxaaQuadtreeRegions",TestPix, RESboxaaQuadtreeRegions,{"Dim RESboxaaQuadtreeRegions as Boxaa = LeptonicaSharp._All.boxaaQuadtreeRegions(TestPix ,TestPix ,TestPix )"},1)

' Dim RESquadtreeGetParent as Integer = LeptonicaSharp._All.quadtreeGetParent(TestPix ,TestPix ,TestPix ,TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("quadtreeGetParent",TestPix, RESquadtreeGetParent,{"Dim RESquadtreeGetParent as Integer = LeptonicaSharp._All.quadtreeGetParent(TestPix ,TestPix ,TestPix ,TestPix ,New Single)"},1)

' Dim RESquadtreeGetChildren as Integer = LeptonicaSharp._All.quadtreeGetChildren(TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("quadtreeGetChildren",TestPix, RESquadtreeGetChildren,{"Dim RESquadtreeGetChildren as Integer = LeptonicaSharp._All.quadtreeGetChildren(TestPix ,TestPix ,TestPix ,TestPix ,New Single,New Single,New Single,New Single)"},1)

' Dim RESquadtreeMaxLevels as Integer = LeptonicaSharp._All.quadtreeMaxLevels(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("quadtreeMaxLevels",TestPix, RESquadtreeMaxLevels,{"Dim RESquadtreeMaxLevels as Integer = LeptonicaSharp._All.quadtreeMaxLevels(TestPix ,TestPix )"},1)

' Dim RESfpixaDisplayQuadtree as Pix = LeptonicaSharp._All.fpixaDisplayQuadtree(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fpixaDisplayQuadtree",TestPix, RESfpixaDisplayQuadtree,{"Dim RESfpixaDisplayQuadtree as Pix = LeptonicaSharp._All.fpixaDisplayQuadtree(TestPix ,TestPix ,TestPix )"},1)

' Dim RESlqueueCreate as L_Queue = LeptonicaSharp._All.lqueueCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueueCreate",TestPix, RESlqueueCreate,{"Dim RESlqueueCreate as L_Queue = LeptonicaSharp._All.lqueueCreate(TestPix )"},1)

' Dim RESlqueueDestroy as Object = LeptonicaSharp._All.lqueueDestroy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueueDestroy",TestPix, RESlqueueDestroy,{"Dim RESlqueueDestroy as Object = LeptonicaSharp._All.lqueueDestroy(TestPix ,TestPix )"},1)

' Dim RESlqueueAdd as Integer = LeptonicaSharp._All.lqueueAdd(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueueAdd",TestPix, RESlqueueAdd,{"Dim RESlqueueAdd as Integer = LeptonicaSharp._All.lqueueAdd(TestPix ,TestPix )"},1)

' Dim RESlqueueRemove as Object = LeptonicaSharp._All.lqueueRemove(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueueRemove",TestPix, RESlqueueRemove,{"Dim RESlqueueRemove as Object = LeptonicaSharp._All.lqueueRemove(TestPix )"},1)

' Dim RESlqueueGetCount as Integer = LeptonicaSharp._All.lqueueGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueueGetCount",TestPix, RESlqueueGetCount,{"Dim RESlqueueGetCount as Integer = LeptonicaSharp._All.lqueueGetCount(TestPix )"},1)

' Dim RESlqueuePrint as Integer = LeptonicaSharp._All.lqueuePrint(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lqueuePrint",TestPix, RESlqueuePrint,{"Dim RESlqueuePrint as Integer = LeptonicaSharp._All.lqueuePrint(TestPix ,TestPix )"},1)

' Dim RESpixRankFilter as Pix = LeptonicaSharp._All.pixRankFilter(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankFilter",TestPix, RESpixRankFilter,{"Dim RESpixRankFilter as Pix = LeptonicaSharp._All.pixRankFilter(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRankFilterRGB as Pix = LeptonicaSharp._All.pixRankFilterRGB(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankFilterRGB",TestPix, RESpixRankFilterRGB,{"Dim RESpixRankFilterRGB as Pix = LeptonicaSharp._All.pixRankFilterRGB(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRankFilterGray as Pix = LeptonicaSharp._All.pixRankFilterGray(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankFilterGray",TestPix, RESpixRankFilterGray,{"Dim RESpixRankFilterGray as Pix = LeptonicaSharp._All.pixRankFilterGray(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixMedianFilter as Pix = LeptonicaSharp._All.pixMedianFilter(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixMedianFilter",TestPix, RESpixMedianFilter,{"Dim RESpixMedianFilter as Pix = LeptonicaSharp._All.pixMedianFilter(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRankFilterWithScaling as Pix = LeptonicaSharp._All.pixRankFilterWithScaling(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRankFilterWithScaling",TestPix, RESpixRankFilterWithScaling,{"Dim RESpixRankFilterWithScaling as Pix = LeptonicaSharp._All.pixRankFilterWithScaling(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_rbtreeCreate as L_Rbtree = LeptonicaSharp._All.l_rbtreeCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeCreate",TestPix, RESl_rbtreeCreate,{"Dim RESl_rbtreeCreate as L_Rbtree = LeptonicaSharp._All.l_rbtreeCreate(TestPix )"},1)

' Dim RESl_rbtreeLookup as RB_TYPE = LeptonicaSharp._All.l_rbtreeLookup(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeLookup",TestPix, RESl_rbtreeLookup,{"Dim RESl_rbtreeLookup as RB_TYPE = LeptonicaSharp._All.l_rbtreeLookup(TestPix ,TestPix )"},1)

' Dim RESl_rbtreeInsert as Object = LeptonicaSharp._All.l_rbtreeInsert(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeInsert",TestPix, RESl_rbtreeInsert,{"Dim RESl_rbtreeInsert as Object = LeptonicaSharp._All.l_rbtreeInsert(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_rbtreeDelete as Object = LeptonicaSharp._All.l_rbtreeDelete(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeDelete",TestPix, RESl_rbtreeDelete,{"Dim RESl_rbtreeDelete as Object = LeptonicaSharp._All.l_rbtreeDelete(TestPix ,TestPix )"},1)

' Dim RESl_rbtreeDestroy as Object = LeptonicaSharp._All.l_rbtreeDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeDestroy",TestPix, RESl_rbtreeDestroy,{"Dim RESl_rbtreeDestroy as Object = LeptonicaSharp._All.l_rbtreeDestroy(TestPix )"},1)

' Dim RESl_rbtreeGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetFirst(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeGetFirst",TestPix, RESl_rbtreeGetFirst,{"Dim RESl_rbtreeGetFirst as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetFirst(TestPix )"},1)

' Dim RESl_rbtreeGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetNext(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeGetNext",TestPix, RESl_rbtreeGetNext,{"Dim RESl_rbtreeGetNext as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetNext(TestPix )"},1)

' Dim RESl_rbtreeGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetLast(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeGetLast",TestPix, RESl_rbtreeGetLast,{"Dim RESl_rbtreeGetLast as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetLast(TestPix )"},1)

' Dim RESl_rbtreeGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetPrev(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeGetPrev",TestPix, RESl_rbtreeGetPrev,{"Dim RESl_rbtreeGetPrev as L_Rbtree_Node = LeptonicaSharp._All.l_rbtreeGetPrev(TestPix )"},1)

' Dim RESl_rbtreeGetCount as Integer = LeptonicaSharp._All.l_rbtreeGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreeGetCount",TestPix, RESl_rbtreeGetCount,{"Dim RESl_rbtreeGetCount as Integer = LeptonicaSharp._All.l_rbtreeGetCount(TestPix )"},1)

' Dim RESl_rbtreePrint as Object = LeptonicaSharp._All.l_rbtreePrint(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_rbtreePrint",TestPix, RESl_rbtreePrint,{"Dim RESl_rbtreePrint as Object = LeptonicaSharp._All.l_rbtreePrint(TestPix ,TestPix )"},1)

' Dim RESpixProcessBarcodes as Sarray = LeptonicaSharp._All.pixProcessBarcodes(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixProcessBarcodes",TestPix, RESpixProcessBarcodes,{"Dim RESpixProcessBarcodes as Sarray = LeptonicaSharp._All.pixProcessBarcodes(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixExtractBarcodes as Pixa = LeptonicaSharp._All.pixExtractBarcodes(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBarcodes",TestPix, RESpixExtractBarcodes,{"Dim RESpixExtractBarcodes as Pixa = LeptonicaSharp._All.pixExtractBarcodes(TestPix ,TestPix )"},1)

' Dim RESpixReadBarcodes as Sarray = LeptonicaSharp._All.pixReadBarcodes(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadBarcodes",TestPix, RESpixReadBarcodes,{"Dim RESpixReadBarcodes as Sarray = LeptonicaSharp._All.pixReadBarcodes(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixReadBarcodeWidths as Numa = LeptonicaSharp._All.pixReadBarcodeWidths(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadBarcodeWidths",TestPix, RESpixReadBarcodeWidths,{"Dim RESpixReadBarcodeWidths as Numa = LeptonicaSharp._All.pixReadBarcodeWidths(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixLocateBarcodes as Boxa = LeptonicaSharp._All.pixLocateBarcodes(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLocateBarcodes",TestPix, RESpixLocateBarcodes,{"Dim RESpixLocateBarcodes as Boxa = LeptonicaSharp._All.pixLocateBarcodes(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixDeskewBarcode as Pix = LeptonicaSharp._All.pixDeskewBarcode(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeskewBarcode",TestPix, RESpixDeskewBarcode,{"Dim RESpixDeskewBarcode as Pix = LeptonicaSharp._All.pixDeskewBarcode(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixExtractBarcodeWidths1 as Numa = LeptonicaSharp._All.pixExtractBarcodeWidths1(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBarcodeWidths1",TestPix, RESpixExtractBarcodeWidths1,{"Dim RESpixExtractBarcodeWidths1 as Numa = LeptonicaSharp._All.pixExtractBarcodeWidths1(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixExtractBarcodeWidths2 as Numa = LeptonicaSharp._All.pixExtractBarcodeWidths2(TestPix ,TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBarcodeWidths2",TestPix, RESpixExtractBarcodeWidths2,{"Dim RESpixExtractBarcodeWidths2 as Numa = LeptonicaSharp._All.pixExtractBarcodeWidths2(TestPix ,TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixExtractBarcodeCrossings as Numa = LeptonicaSharp._All.pixExtractBarcodeCrossings(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBarcodeCrossings",TestPix, RESpixExtractBarcodeCrossings,{"Dim RESpixExtractBarcodeCrossings as Numa = LeptonicaSharp._All.pixExtractBarcodeCrossings(TestPix ,TestPix ,TestPix )"},1)

' Dim RESnumaQuantizeCrossingsByWidth as Numa = LeptonicaSharp._All.numaQuantizeCrossingsByWidth(TestPix ,TestPix ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaQuantizeCrossingsByWidth",TestPix, RESnumaQuantizeCrossingsByWidth,{"Dim RESnumaQuantizeCrossingsByWidth as Numa = LeptonicaSharp._All.numaQuantizeCrossingsByWidth(TestPix ,TestPix ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESnumaQuantizeCrossingsByWindow as Numa = LeptonicaSharp._All.numaQuantizeCrossingsByWindow(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("numaQuantizeCrossingsByWindow",TestPix, RESnumaQuantizeCrossingsByWindow,{"Dim RESnumaQuantizeCrossingsByWindow as Numa = LeptonicaSharp._All.numaQuantizeCrossingsByWindow(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixaReadFiles as Pixa = LeptonicaSharp._All.pixaReadFiles(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadFiles",TestPix, RESpixaReadFiles,{"Dim RESpixaReadFiles as Pixa = LeptonicaSharp._All.pixaReadFiles(TestPix ,Nothing )"},1)

' Dim RESpixaReadFilesSA as Pixa = LeptonicaSharp._All.pixaReadFilesSA(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadFilesSA",TestPix, RESpixaReadFilesSA,{"Dim RESpixaReadFilesSA as Pixa = LeptonicaSharp._All.pixaReadFilesSA(TestPix )"},1)

' Dim RESpixRead as Pix = LeptonicaSharp._All.pixRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRead",TestPix, RESpixRead,{"Dim RESpixRead as Pix = LeptonicaSharp._All.pixRead(TestPix )"},1)

' Dim RESpixReadWithHint as Pix = LeptonicaSharp._All.pixReadWithHint(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadWithHint",TestPix, RESpixReadWithHint,{"Dim RESpixReadWithHint as Pix = LeptonicaSharp._All.pixReadWithHint(TestPix ,TestPix )"},1)

' Dim RESpixReadIndexed as Pix = LeptonicaSharp._All.pixReadIndexed(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadIndexed",TestPix, RESpixReadIndexed,{"Dim RESpixReadIndexed as Pix = LeptonicaSharp._All.pixReadIndexed(TestPix ,TestPix )"},1)

' Dim RESpixReadStream as Pix = LeptonicaSharp._All.pixReadStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStream",TestPix, RESpixReadStream,{"Dim RESpixReadStream as Pix = LeptonicaSharp._All.pixReadStream(TestPix ,TestPix )"},1)

' Dim RESpixReadHeader as Integer = LeptonicaSharp._All.pixReadHeader(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadHeader",TestPix, RESpixReadHeader,{"Dim RESpixReadHeader as Integer = LeptonicaSharp._All.pixReadHeader(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfindFileFormat as Integer = LeptonicaSharp._All.findFileFormat(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("findFileFormat",TestPix, RESfindFileFormat,{"Dim RESfindFileFormat as Integer = LeptonicaSharp._All.findFileFormat(TestPix ,New Integer)"},1)

' Dim RESfindFileFormatStream as Integer = LeptonicaSharp._All.findFileFormatStream(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("findFileFormatStream",TestPix, RESfindFileFormatStream,{"Dim RESfindFileFormatStream as Integer = LeptonicaSharp._All.findFileFormatStream(TestPix ,New Integer)"},1)

' Dim RESfindFileFormatBuffer as Integer = LeptonicaSharp._All.findFileFormatBuffer(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("findFileFormatBuffer",TestPix, RESfindFileFormatBuffer,{"Dim RESfindFileFormatBuffer as Integer = LeptonicaSharp._All.findFileFormatBuffer(TestPix ,New Integer)"},1)

' Dim RESfileFormatIsTiff as Integer = LeptonicaSharp._All.fileFormatIsTiff(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileFormatIsTiff",TestPix, RESfileFormatIsTiff,{"Dim RESfileFormatIsTiff as Integer = LeptonicaSharp._All.fileFormatIsTiff(TestPix )"},1)

' Dim RESpixReadMem as Pix = LeptonicaSharp._All.pixReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMem",TestPix, RESpixReadMem,{"Dim RESpixReadMem as Pix = LeptonicaSharp._All.pixReadMem(TestPix ,TestPix )"},1)

' Dim RESpixReadHeaderMem as Integer = LeptonicaSharp._All.pixReadHeaderMem(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadHeaderMem",TestPix, RESpixReadHeaderMem,{"Dim RESpixReadHeaderMem as Integer = LeptonicaSharp._All.pixReadHeaderMem(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESwriteImageFileInfo as Integer = LeptonicaSharp._All.writeImageFileInfo(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("writeImageFileInfo",TestPix, RESwriteImageFileInfo,{"Dim RESwriteImageFileInfo as Integer = LeptonicaSharp._All.writeImageFileInfo(TestPix ,TestPix ,TestPix )"},1)

' Dim RESioFormatTest as Integer = LeptonicaSharp._All.ioFormatTest(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("ioFormatTest",TestPix, RESioFormatTest,{"Dim RESioFormatTest as Integer = LeptonicaSharp._All.ioFormatTest(TestPix )"},1)

' Dim RESrecogCreateFromRecog as L_Recog = LeptonicaSharp._All.recogCreateFromRecog(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCreateFromRecog",TestPix, RESrecogCreateFromRecog,{"Dim RESrecogCreateFromRecog as L_Recog = LeptonicaSharp._All.recogCreateFromRecog(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogCreateFromPixa as L_Recog = LeptonicaSharp._All.recogCreateFromPixa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCreateFromPixa",TestPix, RESrecogCreateFromPixa,{"Dim RESrecogCreateFromPixa as L_Recog = LeptonicaSharp._All.recogCreateFromPixa(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogCreateFromPixaNoFinish as L_Recog = LeptonicaSharp._All.recogCreateFromPixaNoFinish(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCreateFromPixaNoFinish",TestPix, RESrecogCreateFromPixaNoFinish,{"Dim RESrecogCreateFromPixaNoFinish as L_Recog = LeptonicaSharp._All.recogCreateFromPixaNoFinish(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogCreate as L_Recog = LeptonicaSharp._All.recogCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCreate",TestPix, RESrecogCreate,{"Dim RESrecogCreate as L_Recog = LeptonicaSharp._All.recogCreate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogDestroy as Object = LeptonicaSharp._All.recogDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogDestroy",TestPix, RESrecogDestroy,{"Dim RESrecogDestroy as Object = LeptonicaSharp._All.recogDestroy(TestPix )"},1)

' Dim RESrecogGetCount as Integer = LeptonicaSharp._All.recogGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogGetCount",TestPix, RESrecogGetCount,{"Dim RESrecogGetCount as Integer = LeptonicaSharp._All.recogGetCount(TestPix )"},1)

' Dim RESrecogSetParams as Integer = LeptonicaSharp._All.recogSetParams(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogSetParams",TestPix, RESrecogSetParams,{"Dim RESrecogSetParams as Integer = LeptonicaSharp._All.recogSetParams(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogGetClassIndex as Integer = LeptonicaSharp._All.recogGetClassIndex(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("recogGetClassIndex",TestPix, RESrecogGetClassIndex,{"Dim RESrecogGetClassIndex as Integer = LeptonicaSharp._All.recogGetClassIndex(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESrecogStringToIndex as Integer = LeptonicaSharp._All.recogStringToIndex(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("recogStringToIndex",TestPix, RESrecogStringToIndex,{"Dim RESrecogStringToIndex as Integer = LeptonicaSharp._All.recogStringToIndex(TestPix ,TestPix ,New Integer)"},1)

' Dim RESrecogGetClassString as Integer = LeptonicaSharp._All.recogGetClassString(TestPix ,TestPix ,New String())
' LeptonicaSharp.Convert.WriteHelpExtension ("recogGetClassString",TestPix, RESrecogGetClassString,{"Dim RESrecogGetClassString as Integer = LeptonicaSharp._All.recogGetClassString(TestPix ,TestPix ,New String())"},1)

' Dim RESl_convertCharstrToInt as Integer = LeptonicaSharp._All.l_convertCharstrToInt(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_convertCharstrToInt",TestPix, RESl_convertCharstrToInt,{"Dim RESl_convertCharstrToInt as Integer = LeptonicaSharp._All.l_convertCharstrToInt(TestPix ,New Integer)"},1)

' Dim RESrecogRead as L_Recog = LeptonicaSharp._All.recogRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogRead",TestPix, RESrecogRead,{"Dim RESrecogRead as L_Recog = LeptonicaSharp._All.recogRead(TestPix )"},1)

' Dim RESrecogReadStream as L_Recog = LeptonicaSharp._All.recogReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogReadStream",TestPix, RESrecogReadStream,{"Dim RESrecogReadStream as L_Recog = LeptonicaSharp._All.recogReadStream(TestPix )"},1)

' Dim RESrecogReadMem as L_Recog = LeptonicaSharp._All.recogReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogReadMem",TestPix, RESrecogReadMem,{"Dim RESrecogReadMem as L_Recog = LeptonicaSharp._All.recogReadMem(TestPix ,TestPix )"},1)

' Dim RESrecogWrite as Integer = LeptonicaSharp._All.recogWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogWrite",TestPix, RESrecogWrite,{"Dim RESrecogWrite as Integer = LeptonicaSharp._All.recogWrite(TestPix ,TestPix )"},1)

' Dim RESrecogWriteStream as Integer = LeptonicaSharp._All.recogWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogWriteStream",TestPix, RESrecogWriteStream,{"Dim RESrecogWriteStream as Integer = LeptonicaSharp._All.recogWriteStream(TestPix ,TestPix )"},1)

' Dim RESrecogWriteMem as Integer = LeptonicaSharp._All.recogWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogWriteMem",TestPix, RESrecogWriteMem,{"Dim RESrecogWriteMem as Integer = LeptonicaSharp._All.recogWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESrecogExtractPixa as Pixa = LeptonicaSharp._All.recogExtractPixa(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogExtractPixa",TestPix, RESrecogExtractPixa,{"Dim RESrecogExtractPixa as Pixa = LeptonicaSharp._All.recogExtractPixa(TestPix )"},1)

' Dim RESrecogDecode as Boxa = LeptonicaSharp._All.recogDecode(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogDecode",TestPix, RESrecogDecode,{"Dim RESrecogDecode as Boxa = LeptonicaSharp._All.recogDecode(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogCreateDid as Integer = LeptonicaSharp._All.recogCreateDid(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCreateDid",TestPix, RESrecogCreateDid,{"Dim RESrecogCreateDid as Integer = LeptonicaSharp._All.recogCreateDid(TestPix ,TestPix )"},1)

' Dim RESrecogDestroyDid as Integer = LeptonicaSharp._All.recogDestroyDid(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogDestroyDid",TestPix, RESrecogDestroyDid,{"Dim RESrecogDestroyDid as Integer = LeptonicaSharp._All.recogDestroyDid(TestPix )"},1)

' Dim RESrecogDidExists as Integer = LeptonicaSharp._All.recogDidExists(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogDidExists",TestPix, RESrecogDidExists,{"Dim RESrecogDidExists as Integer = LeptonicaSharp._All.recogDidExists(TestPix )"},1)

' Dim RESrecogGetDid as L_Rdid = LeptonicaSharp._All.recogGetDid(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogGetDid",TestPix, RESrecogGetDid,{"Dim RESrecogGetDid as L_Rdid = LeptonicaSharp._All.recogGetDid(TestPix )"},1)

' Dim RESrecogSetChannelParams as Integer = LeptonicaSharp._All.recogSetChannelParams(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogSetChannelParams",TestPix, RESrecogSetChannelParams,{"Dim RESrecogSetChannelParams as Integer = LeptonicaSharp._All.recogSetChannelParams(TestPix ,TestPix )"},1)

' Dim RESrecogIdentifyMultiple as Integer = LeptonicaSharp._All.recogIdentifyMultiple(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogIdentifyMultiple",TestPix, RESrecogIdentifyMultiple,{"Dim RESrecogIdentifyMultiple as Integer = LeptonicaSharp._All.recogIdentifyMultiple(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESrecogSplitIntoCharacters as Integer = LeptonicaSharp._All.recogSplitIntoCharacters(TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,New Pixa,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogSplitIntoCharacters",TestPix, RESrecogSplitIntoCharacters,{"Dim RESrecogSplitIntoCharacters as Integer = LeptonicaSharp._All.recogSplitIntoCharacters(TestPix ,TestPix ,TestPix ,TestPix ,New Boxa,New Pixa,Nothing )"},1)

' Dim RESrecogCorrelationBestRow as Integer = LeptonicaSharp._All.recogCorrelationBestRow(TestPix ,TestPix ,New Boxa,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCorrelationBestRow",TestPix, RESrecogCorrelationBestRow,{"Dim RESrecogCorrelationBestRow as Integer = LeptonicaSharp._All.recogCorrelationBestRow(TestPix ,TestPix ,New Boxa,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESrecogCorrelationBestChar as Integer = LeptonicaSharp._All.recogCorrelationBestChar(TestPix ,TestPix ,New Box,New Single,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogCorrelationBestChar",TestPix, RESrecogCorrelationBestChar,{"Dim RESrecogCorrelationBestChar as Integer = LeptonicaSharp._All.recogCorrelationBestChar(TestPix ,TestPix ,New Box,New Single,Nothing ,Nothing ,Nothing )"},1)

' Dim RESrecogIdentifyPixa as Integer = LeptonicaSharp._All.recogIdentifyPixa(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogIdentifyPixa",TestPix, RESrecogIdentifyPixa,{"Dim RESrecogIdentifyPixa as Integer = LeptonicaSharp._All.recogIdentifyPixa(TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogIdentifyPix as Integer = LeptonicaSharp._All.recogIdentifyPix(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogIdentifyPix",TestPix, RESrecogIdentifyPix,{"Dim RESrecogIdentifyPix as Integer = LeptonicaSharp._All.recogIdentifyPix(TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogSkipIdentify as Integer = LeptonicaSharp._All.recogSkipIdentify(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogSkipIdentify",TestPix, RESrecogSkipIdentify,{"Dim RESrecogSkipIdentify as Integer = LeptonicaSharp._All.recogSkipIdentify(TestPix )"},1)

' Dim RESrchaDestroy as Object = LeptonicaSharp._All.rchaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rchaDestroy",TestPix, RESrchaDestroy,{"Dim RESrchaDestroy as Object = LeptonicaSharp._All.rchaDestroy(TestPix )"},1)

' Dim RESrchDestroy as Object = LeptonicaSharp._All.rchDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rchDestroy",TestPix, RESrchDestroy,{"Dim RESrchDestroy as Object = LeptonicaSharp._All.rchDestroy(TestPix )"},1)

' Dim RESrchaExtract as Integer = LeptonicaSharp._All.rchaExtract(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("rchaExtract",TestPix, RESrchaExtract,{"Dim RESrchaExtract as Integer = LeptonicaSharp._All.rchaExtract(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESrchExtract as Integer = LeptonicaSharp._All.rchExtract(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("rchExtract",TestPix, RESrchExtract,{"Dim RESrchExtract as Integer = LeptonicaSharp._All.rchExtract(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESrecogProcessToIdentify as Pix = LeptonicaSharp._All.recogProcessToIdentify(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogProcessToIdentify",TestPix, RESrecogProcessToIdentify,{"Dim RESrecogProcessToIdentify as Pix = LeptonicaSharp._All.recogProcessToIdentify(TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogExtractNumbers as Sarray = LeptonicaSharp._All.recogExtractNumbers(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogExtractNumbers",TestPix, RESrecogExtractNumbers,{"Dim RESrecogExtractNumbers as Sarray = LeptonicaSharp._All.recogExtractNumbers(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESshowExtractNumbers as Pixa = LeptonicaSharp._All.showExtractNumbers(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("showExtractNumbers",TestPix, RESshowExtractNumbers,{"Dim RESshowExtractNumbers as Pixa = LeptonicaSharp._All.showExtractNumbers(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogTrainLabeled as Integer = LeptonicaSharp._All.recogTrainLabeled(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogTrainLabeled",TestPix, RESrecogTrainLabeled,{"Dim RESrecogTrainLabeled as Integer = LeptonicaSharp._All.recogTrainLabeled(TestPix ,TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESrecogProcessLabeled as Integer = LeptonicaSharp._All.recogProcessLabeled(TestPix ,TestPix ,Nothing ,Nothing ,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("recogProcessLabeled",TestPix, RESrecogProcessLabeled,{"Dim RESrecogProcessLabeled as Integer = LeptonicaSharp._All.recogProcessLabeled(TestPix ,TestPix ,Nothing ,Nothing ,New Pix)"},1)

' Dim RESrecogAddSample as Integer = LeptonicaSharp._All.recogAddSample(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogAddSample",TestPix, RESrecogAddSample,{"Dim RESrecogAddSample as Integer = LeptonicaSharp._All.recogAddSample(TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogModifyTemplate as Pix = LeptonicaSharp._All.recogModifyTemplate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogModifyTemplate",TestPix, RESrecogModifyTemplate,{"Dim RESrecogModifyTemplate as Pix = LeptonicaSharp._All.recogModifyTemplate(TestPix ,TestPix )"},1)

' Dim RESrecogAverageSamples as Integer = LeptonicaSharp._All.recogAverageSamples(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogAverageSamples",TestPix, RESrecogAverageSamples,{"Dim RESrecogAverageSamples as Integer = LeptonicaSharp._All.recogAverageSamples(TestPix ,Nothing )"},1)

' Dim RESpixaAccumulateSamples as Integer = LeptonicaSharp._All.pixaAccumulateSamples(TestPix ,Nothing ,New Pix,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAccumulateSamples",TestPix, RESpixaAccumulateSamples,{"Dim RESpixaAccumulateSamples as Integer = LeptonicaSharp._All.pixaAccumulateSamples(TestPix ,Nothing ,New Pix,Nothing ,Nothing )"},1)

' Dim RESrecogTrainingFinished as Integer = LeptonicaSharp._All.recogTrainingFinished(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogTrainingFinished",TestPix, RESrecogTrainingFinished,{"Dim RESrecogTrainingFinished as Integer = LeptonicaSharp._All.recogTrainingFinished(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogFilterPixaBySize as Pixa = LeptonicaSharp._All.recogFilterPixaBySize(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogFilterPixaBySize",TestPix, RESrecogFilterPixaBySize,{"Dim RESrecogFilterPixaBySize as Pixa = LeptonicaSharp._All.recogFilterPixaBySize(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogSortPixaByClass as Pixaa = LeptonicaSharp._All.recogSortPixaByClass(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogSortPixaByClass",TestPix, RESrecogSortPixaByClass,{"Dim RESrecogSortPixaByClass as Pixaa = LeptonicaSharp._All.recogSortPixaByClass(TestPix ,TestPix )"},1)

' Dim RESrecogRemoveOutliers1 as Integer = LeptonicaSharp._All.recogRemoveOutliers1(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogRemoveOutliers1",TestPix, RESrecogRemoveOutliers1,{"Dim RESrecogRemoveOutliers1 as Integer = LeptonicaSharp._All.recogRemoveOutliers1(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaRemoveOutliers1 as Pixa = LeptonicaSharp._All.pixaRemoveOutliers1(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRemoveOutliers1",TestPix, RESpixaRemoveOutliers1,{"Dim RESpixaRemoveOutliers1 as Pixa = LeptonicaSharp._All.pixaRemoveOutliers1(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESrecogRemoveOutliers2 as Integer = LeptonicaSharp._All.recogRemoveOutliers2(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogRemoveOutliers2",TestPix, RESrecogRemoveOutliers2,{"Dim RESrecogRemoveOutliers2 as Integer = LeptonicaSharp._All.recogRemoveOutliers2(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaRemoveOutliers2 as Pixa = LeptonicaSharp._All.pixaRemoveOutliers2(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaRemoveOutliers2",TestPix, RESpixaRemoveOutliers2,{"Dim RESpixaRemoveOutliers2 as Pixa = LeptonicaSharp._All.pixaRemoveOutliers2(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESrecogTrainFromBoot as Pixa = LeptonicaSharp._All.recogTrainFromBoot(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogTrainFromBoot",TestPix, RESrecogTrainFromBoot,{"Dim RESrecogTrainFromBoot as Pixa = LeptonicaSharp._All.recogTrainFromBoot(TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogPadDigitTrainingSet as Integer = LeptonicaSharp._All.recogPadDigitTrainingSet(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogPadDigitTrainingSet",TestPix, RESrecogPadDigitTrainingSet,{"Dim RESrecogPadDigitTrainingSet as Integer = LeptonicaSharp._All.recogPadDigitTrainingSet(TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogIsPaddingNeeded as Integer = LeptonicaSharp._All.recogIsPaddingNeeded(TestPix ,New Sarray)
' LeptonicaSharp.Convert.WriteHelpExtension ("recogIsPaddingNeeded",TestPix, RESrecogIsPaddingNeeded,{"Dim RESrecogIsPaddingNeeded as Integer = LeptonicaSharp._All.recogIsPaddingNeeded(TestPix ,New Sarray)"},1)

' Dim RESrecogAddDigitPadTemplates as Pixa = LeptonicaSharp._All.recogAddDigitPadTemplates(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogAddDigitPadTemplates",TestPix, RESrecogAddDigitPadTemplates,{"Dim RESrecogAddDigitPadTemplates as Pixa = LeptonicaSharp._All.recogAddDigitPadTemplates(TestPix ,TestPix )"},1)

' Dim RESrecogMakeBootDigitRecog as L_Recog = LeptonicaSharp._All.recogMakeBootDigitRecog(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogMakeBootDigitRecog",TestPix, RESrecogMakeBootDigitRecog,{"Dim RESrecogMakeBootDigitRecog as L_Recog = LeptonicaSharp._All.recogMakeBootDigitRecog(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESrecogMakeBootDigitTemplates as Pixa = LeptonicaSharp._All.recogMakeBootDigitTemplates(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogMakeBootDigitTemplates",TestPix, RESrecogMakeBootDigitTemplates,{"Dim RESrecogMakeBootDigitTemplates as Pixa = LeptonicaSharp._All.recogMakeBootDigitTemplates(Nothing )"},1)

' Dim RESrecogShowContent as Integer = LeptonicaSharp._All.recogShowContent(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogShowContent",TestPix, RESrecogShowContent,{"Dim RESrecogShowContent as Integer = LeptonicaSharp._All.recogShowContent(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogDebugAverages as Integer = LeptonicaSharp._All.recogDebugAverages(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogDebugAverages",TestPix, RESrecogDebugAverages,{"Dim RESrecogDebugAverages as Integer = LeptonicaSharp._All.recogDebugAverages(TestPix ,Nothing )"},1)

' Dim RESrecogShowAverageTemplates as Integer = LeptonicaSharp._All.recogShowAverageTemplates(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogShowAverageTemplates",TestPix, RESrecogShowAverageTemplates,{"Dim RESrecogShowAverageTemplates as Integer = LeptonicaSharp._All.recogShowAverageTemplates(TestPix )"},1)

' Dim RESrecogShowMatchesInRange as Integer = LeptonicaSharp._All.recogShowMatchesInRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogShowMatchesInRange",TestPix, RESrecogShowMatchesInRange,{"Dim RESrecogShowMatchesInRange as Integer = LeptonicaSharp._All.recogShowMatchesInRange(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrecogShowMatch as Pix = LeptonicaSharp._All.recogShowMatch(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("recogShowMatch",TestPix, RESrecogShowMatch,{"Dim RESrecogShowMatch as Pix = LeptonicaSharp._All.recogShowMatch(TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESregTestSetup as Integer = LeptonicaSharp._All.regTestSetup(TestPix ,TestPix ,New L_RegParams)
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestSetup",TestPix, RESregTestSetup,{"Dim RESregTestSetup as Integer = LeptonicaSharp._All.regTestSetup(TestPix ,TestPix ,New L_RegParams)"},1)

' Dim RESregTestCleanup as Integer = LeptonicaSharp._All.regTestCleanup(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCleanup",TestPix, RESregTestCleanup,{"Dim RESregTestCleanup as Integer = LeptonicaSharp._All.regTestCleanup(TestPix )"},1)

' Dim RESregTestCompareValues as Integer = LeptonicaSharp._All.regTestCompareValues(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCompareValues",TestPix, RESregTestCompareValues,{"Dim RESregTestCompareValues as Integer = LeptonicaSharp._All.regTestCompareValues(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestCompareStrings as Integer = LeptonicaSharp._All.regTestCompareStrings(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCompareStrings",TestPix, RESregTestCompareStrings,{"Dim RESregTestCompareStrings as Integer = LeptonicaSharp._All.regTestCompareStrings(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestComparePix as Integer = LeptonicaSharp._All.regTestComparePix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestComparePix",TestPix, RESregTestComparePix,{"Dim RESregTestComparePix as Integer = LeptonicaSharp._All.regTestComparePix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestCompareSimilarPix as Integer = LeptonicaSharp._All.regTestCompareSimilarPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCompareSimilarPix",TestPix, RESregTestCompareSimilarPix,{"Dim RESregTestCompareSimilarPix as Integer = LeptonicaSharp._All.regTestCompareSimilarPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestCheckFile as Integer = LeptonicaSharp._All.regTestCheckFile(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCheckFile",TestPix, RESregTestCheckFile,{"Dim RESregTestCheckFile as Integer = LeptonicaSharp._All.regTestCheckFile(TestPix ,TestPix )"},1)

' Dim RESregTestCompareFiles as Integer = LeptonicaSharp._All.regTestCompareFiles(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestCompareFiles",TestPix, RESregTestCompareFiles,{"Dim RESregTestCompareFiles as Integer = LeptonicaSharp._All.regTestCompareFiles(TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestWritePixAndCheck as Integer = LeptonicaSharp._All.regTestWritePixAndCheck(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestWritePixAndCheck",TestPix, RESregTestWritePixAndCheck,{"Dim RESregTestWritePixAndCheck as Integer = LeptonicaSharp._All.regTestWritePixAndCheck(TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestWriteDataAndCheck as Integer = LeptonicaSharp._All.regTestWriteDataAndCheck(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestWriteDataAndCheck",TestPix, RESregTestWriteDataAndCheck,{"Dim RESregTestWriteDataAndCheck as Integer = LeptonicaSharp._All.regTestWriteDataAndCheck(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESregTestGenLocalFilename as String = LeptonicaSharp._All.regTestGenLocalFilename(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("regTestGenLocalFilename",TestPix, RESregTestGenLocalFilename,{"Dim RESregTestGenLocalFilename as String = LeptonicaSharp._All.regTestGenLocalFilename(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRasterop as Integer = LeptonicaSharp._All.pixRasterop(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRasterop",TestPix, RESpixRasterop,{"Dim RESpixRasterop as Integer = LeptonicaSharp._All.pixRasterop(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRasteropVip as Integer = LeptonicaSharp._All.pixRasteropVip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRasteropVip",TestPix, RESpixRasteropVip,{"Dim RESpixRasteropVip as Integer = LeptonicaSharp._All.pixRasteropVip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRasteropHip as Integer = LeptonicaSharp._All.pixRasteropHip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRasteropHip",TestPix, RESpixRasteropHip,{"Dim RESpixRasteropHip as Integer = LeptonicaSharp._All.pixRasteropHip(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixTranslate as Pix = LeptonicaSharp._All.pixTranslate(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixTranslate",TestPix, RESpixTranslate,{"Dim RESpixTranslate as Pix = LeptonicaSharp._All.pixTranslate(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRasteropIP as Integer = LeptonicaSharp._All.pixRasteropIP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRasteropIP",TestPix, RESpixRasteropIP,{"Dim RESpixRasteropIP as Integer = LeptonicaSharp._All.pixRasteropIP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRasteropFullImage as Integer = LeptonicaSharp._All.pixRasteropFullImage(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRasteropFullImage",TestPix, RESpixRasteropFullImage,{"Dim RESpixRasteropFullImage as Integer = LeptonicaSharp._All.pixRasteropFullImage(TestPix ,TestPix ,TestPix )"},1)

' Dim RESrasteropUniLow as Object = LeptonicaSharp._All.rasteropUniLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rasteropUniLow",TestPix, RESrasteropUniLow,{"Dim RESrasteropUniLow as Object = LeptonicaSharp._All.rasteropUniLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrasteropLow as Object = LeptonicaSharp._All.rasteropLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rasteropLow",TestPix, RESrasteropLow,{"Dim RESrasteropLow as Object = LeptonicaSharp._All.rasteropLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrasteropVipLow as Object = LeptonicaSharp._All.rasteropVipLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rasteropVipLow",TestPix, RESrasteropVipLow,{"Dim RESrasteropVipLow as Object = LeptonicaSharp._All.rasteropVipLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESrasteropHipLow as Object = LeptonicaSharp._All.rasteropHipLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("rasteropHipLow",TestPix, RESrasteropHipLow,{"Dim RESrasteropHipLow as Object = LeptonicaSharp._All.rasteropHipLow(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotate as Pix = LeptonicaSharp._All.pixRotate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotate",TestPix, RESpixRotate,{"Dim RESpixRotate as Pix = LeptonicaSharp._All.pixRotate(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixEmbedForRotation as Pix = LeptonicaSharp._All.pixEmbedForRotation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixEmbedForRotation",TestPix, RESpixEmbedForRotation,{"Dim RESpixEmbedForRotation as Pix = LeptonicaSharp._All.pixEmbedForRotation(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateBySampling as Pix = LeptonicaSharp._All.pixRotateBySampling(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateBySampling",TestPix, RESpixRotateBySampling,{"Dim RESpixRotateBySampling as Pix = LeptonicaSharp._All.pixRotateBySampling(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateBinaryNice as Pix = LeptonicaSharp._All.pixRotateBinaryNice(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateBinaryNice",TestPix, RESpixRotateBinaryNice,{"Dim RESpixRotateBinaryNice as Pix = LeptonicaSharp._All.pixRotateBinaryNice(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateWithAlpha as Pix = LeptonicaSharp._All.pixRotateWithAlpha(TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateWithAlpha",TestPix, RESpixRotateWithAlpha,{"Dim RESpixRotateWithAlpha as Pix = LeptonicaSharp._All.pixRotateWithAlpha(TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixRotateAM as Pix = LeptonicaSharp._All.pixRotateAM(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAM",TestPix, RESpixRotateAM,{"Dim RESpixRotateAM as Pix = LeptonicaSharp._All.pixRotateAM(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMColor as Pix = LeptonicaSharp._All.pixRotateAMColor(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMColor",TestPix, RESpixRotateAMColor,{"Dim RESpixRotateAMColor as Pix = LeptonicaSharp._All.pixRotateAMColor(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMGray as Pix = LeptonicaSharp._All.pixRotateAMGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMGray",TestPix, RESpixRotateAMGray,{"Dim RESpixRotateAMGray as Pix = LeptonicaSharp._All.pixRotateAMGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMCorner as Pix = LeptonicaSharp._All.pixRotateAMCorner(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMCorner",TestPix, RESpixRotateAMCorner,{"Dim RESpixRotateAMCorner as Pix = LeptonicaSharp._All.pixRotateAMCorner(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMColorCorner as Pix = LeptonicaSharp._All.pixRotateAMColorCorner(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMColorCorner",TestPix, RESpixRotateAMColorCorner,{"Dim RESpixRotateAMColorCorner as Pix = LeptonicaSharp._All.pixRotateAMColorCorner(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMGrayCorner as Pix = LeptonicaSharp._All.pixRotateAMGrayCorner(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMGrayCorner",TestPix, RESpixRotateAMGrayCorner,{"Dim RESpixRotateAMGrayCorner as Pix = LeptonicaSharp._All.pixRotateAMGrayCorner(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateAMColorFast as Pix = LeptonicaSharp._All.pixRotateAMColorFast(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateAMColorFast",TestPix, RESpixRotateAMColorFast,{"Dim RESpixRotateAMColorFast as Pix = LeptonicaSharp._All.pixRotateAMColorFast(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateOrth as Pix = LeptonicaSharp._All.pixRotateOrth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateOrth",TestPix, RESpixRotateOrth,{"Dim RESpixRotateOrth as Pix = LeptonicaSharp._All.pixRotateOrth(TestPix ,TestPix )"},1)

' Dim RESpixRotate180 as Pix = LeptonicaSharp._All.pixRotate180(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotate180",TestPix, RESpixRotate180,{"Dim RESpixRotate180 as Pix = LeptonicaSharp._All.pixRotate180(Nothing ,TestPix )"},1)

' Dim RESpixRotate90 as Pix = LeptonicaSharp._All.pixRotate90(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotate90",TestPix, RESpixRotate90,{"Dim RESpixRotate90 as Pix = LeptonicaSharp._All.pixRotate90(TestPix ,TestPix )"},1)

' Dim RESpixFlipLR as Pix = LeptonicaSharp._All.pixFlipLR(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFlipLR",TestPix, RESpixFlipLR,{"Dim RESpixFlipLR as Pix = LeptonicaSharp._All.pixFlipLR(Nothing ,TestPix )"},1)

' Dim RESpixFlipTB as Pix = LeptonicaSharp._All.pixFlipTB(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFlipTB",TestPix, RESpixFlipTB,{"Dim RESpixFlipTB as Pix = LeptonicaSharp._All.pixFlipTB(Nothing ,TestPix )"},1)

' Dim RESpixRotateShear as Pix = LeptonicaSharp._All.pixRotateShear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateShear",TestPix, RESpixRotateShear,{"Dim RESpixRotateShear as Pix = LeptonicaSharp._All.pixRotateShear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotate2Shear as Pix = LeptonicaSharp._All.pixRotate2Shear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotate2Shear",TestPix, RESpixRotate2Shear,{"Dim RESpixRotate2Shear as Pix = LeptonicaSharp._All.pixRotate2Shear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotate3Shear as Pix = LeptonicaSharp._All.pixRotate3Shear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotate3Shear",TestPix, RESpixRotate3Shear,{"Dim RESpixRotate3Shear as Pix = LeptonicaSharp._All.pixRotate3Shear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateShearIP as Integer = LeptonicaSharp._All.pixRotateShearIP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateShearIP",TestPix, RESpixRotateShearIP,{"Dim RESpixRotateShearIP as Integer = LeptonicaSharp._All.pixRotateShearIP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateShearCenter as Pix = LeptonicaSharp._All.pixRotateShearCenter(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateShearCenter",TestPix, RESpixRotateShearCenter,{"Dim RESpixRotateShearCenter as Pix = LeptonicaSharp._All.pixRotateShearCenter(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRotateShearCenterIP as Integer = LeptonicaSharp._All.pixRotateShearCenterIP(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRotateShearCenterIP",TestPix, RESpixRotateShearCenterIP,{"Dim RESpixRotateShearCenterIP as Integer = LeptonicaSharp._All.pixRotateShearCenterIP(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixStrokeWidthTransform as Pix = LeptonicaSharp._All.pixStrokeWidthTransform(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixStrokeWidthTransform",TestPix, RESpixStrokeWidthTransform,{"Dim RESpixStrokeWidthTransform as Pix = LeptonicaSharp._All.pixStrokeWidthTransform(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRunlengthTransform as Pix = LeptonicaSharp._All.pixRunlengthTransform(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRunlengthTransform",TestPix, RESpixRunlengthTransform,{"Dim RESpixRunlengthTransform as Pix = LeptonicaSharp._All.pixRunlengthTransform(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindHorizontalRuns as Integer = LeptonicaSharp._All.pixFindHorizontalRuns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindHorizontalRuns",TestPix, RESpixFindHorizontalRuns,{"Dim RESpixFindHorizontalRuns as Integer = LeptonicaSharp._All.pixFindHorizontalRuns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixFindVerticalRuns as Integer = LeptonicaSharp._All.pixFindVerticalRuns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindVerticalRuns",TestPix, RESpixFindVerticalRuns,{"Dim RESpixFindVerticalRuns as Integer = LeptonicaSharp._All.pixFindVerticalRuns(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESpixFindMaxRuns as Numa = LeptonicaSharp._All.pixFindMaxRuns(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindMaxRuns",TestPix, RESpixFindMaxRuns,{"Dim RESpixFindMaxRuns as Numa = LeptonicaSharp._All.pixFindMaxRuns(TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixFindMaxHorizontalRunOnLine as Integer = LeptonicaSharp._All.pixFindMaxHorizontalRunOnLine(TestPix ,TestPix ,Nothing ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindMaxHorizontalRunOnLine",TestPix, RESpixFindMaxHorizontalRunOnLine,{"Dim RESpixFindMaxHorizontalRunOnLine as Integer = LeptonicaSharp._All.pixFindMaxHorizontalRunOnLine(TestPix ,TestPix ,Nothing ,New Integer)"},1)

' Dim RESpixFindMaxVerticalRunOnLine as Integer = LeptonicaSharp._All.pixFindMaxVerticalRunOnLine(TestPix ,TestPix ,Nothing ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindMaxVerticalRunOnLine",TestPix, RESpixFindMaxVerticalRunOnLine,{"Dim RESpixFindMaxVerticalRunOnLine as Integer = LeptonicaSharp._All.pixFindMaxVerticalRunOnLine(TestPix ,TestPix ,Nothing ,New Integer)"},1)

' Dim RESrunlengthMembershipOnLine as Integer = LeptonicaSharp._All.runlengthMembershipOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("runlengthMembershipOnLine",TestPix, RESrunlengthMembershipOnLine,{"Dim RESrunlengthMembershipOnLine as Integer = LeptonicaSharp._All.runlengthMembershipOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESmakeMSBitLocTab as Integer() = LeptonicaSharp._All.makeMSBitLocTab(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeMSBitLocTab",TestPix, RESmakeMSBitLocTab,{"Dim RESmakeMSBitLocTab as Integer() = LeptonicaSharp._All.makeMSBitLocTab(TestPix )"},1)

' Dim RESsarrayCreate as Sarray = LeptonicaSharp._All.sarrayCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayCreate",TestPix, RESsarrayCreate,{"Dim RESsarrayCreate as Sarray = LeptonicaSharp._All.sarrayCreate(TestPix )"},1)

' Dim RESsarrayCreateInitialized as Sarray = LeptonicaSharp._All.sarrayCreateInitialized(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayCreateInitialized",TestPix, RESsarrayCreateInitialized,{"Dim RESsarrayCreateInitialized as Sarray = LeptonicaSharp._All.sarrayCreateInitialized(TestPix ,TestPix )"},1)

' Dim RESsarrayCreateWordsFromString as Sarray = LeptonicaSharp._All.sarrayCreateWordsFromString(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayCreateWordsFromString",TestPix, RESsarrayCreateWordsFromString,{"Dim RESsarrayCreateWordsFromString as Sarray = LeptonicaSharp._All.sarrayCreateWordsFromString(TestPix )"},1)

' Dim RESsarrayCreateLinesFromString as Sarray = LeptonicaSharp._All.sarrayCreateLinesFromString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayCreateLinesFromString",TestPix, RESsarrayCreateLinesFromString,{"Dim RESsarrayCreateLinesFromString as Sarray = LeptonicaSharp._All.sarrayCreateLinesFromString(TestPix ,TestPix )"},1)

' Dim RESsarrayDestroy as Object = LeptonicaSharp._All.sarrayDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayDestroy",TestPix, RESsarrayDestroy,{"Dim RESsarrayDestroy as Object = LeptonicaSharp._All.sarrayDestroy(TestPix )"},1)

' Dim RESsarrayCopy as Sarray = LeptonicaSharp._All.sarrayCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayCopy",TestPix, RESsarrayCopy,{"Dim RESsarrayCopy as Sarray = LeptonicaSharp._All.sarrayCopy(TestPix )"},1)

' Dim RESsarrayClone as Sarray = LeptonicaSharp._All.sarrayClone(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayClone",TestPix, RESsarrayClone,{"Dim RESsarrayClone as Sarray = LeptonicaSharp._All.sarrayClone(TestPix )"},1)

' Dim RESsarrayAddString as Integer = LeptonicaSharp._All.sarrayAddString(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayAddString",TestPix, RESsarrayAddString,{"Dim RESsarrayAddString as Integer = LeptonicaSharp._All.sarrayAddString(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayRemoveString as String = LeptonicaSharp._All.sarrayRemoveString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayRemoveString",TestPix, RESsarrayRemoveString,{"Dim RESsarrayRemoveString as String = LeptonicaSharp._All.sarrayRemoveString(TestPix ,TestPix )"},1)

' Dim RESsarrayReplaceString as Integer = LeptonicaSharp._All.sarrayReplaceString(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayReplaceString",TestPix, RESsarrayReplaceString,{"Dim RESsarrayReplaceString as Integer = LeptonicaSharp._All.sarrayReplaceString(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayClear as Integer = LeptonicaSharp._All.sarrayClear(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayClear",TestPix, RESsarrayClear,{"Dim RESsarrayClear as Integer = LeptonicaSharp._All.sarrayClear(TestPix )"},1)

' Dim RESsarrayGetCount as Integer = LeptonicaSharp._All.sarrayGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayGetCount",TestPix, RESsarrayGetCount,{"Dim RESsarrayGetCount as Integer = LeptonicaSharp._All.sarrayGetCount(TestPix )"},1)

' Dim RESsarrayGetArray as String() = LeptonicaSharp._All.sarrayGetArray(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayGetArray",TestPix, RESsarrayGetArray,{"Dim RESsarrayGetArray as String() = LeptonicaSharp._All.sarrayGetArray(TestPix ,Nothing ,Nothing )"},1)

' Dim RESsarrayGetString as String = LeptonicaSharp._All.sarrayGetString(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayGetString",TestPix, RESsarrayGetString,{"Dim RESsarrayGetString as String = LeptonicaSharp._All.sarrayGetString(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayGetRefcount as Integer = LeptonicaSharp._All.sarrayGetRefcount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayGetRefcount",TestPix, RESsarrayGetRefcount,{"Dim RESsarrayGetRefcount as Integer = LeptonicaSharp._All.sarrayGetRefcount(TestPix )"},1)

' Dim RESsarrayChangeRefcount as Integer = LeptonicaSharp._All.sarrayChangeRefcount(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayChangeRefcount",TestPix, RESsarrayChangeRefcount,{"Dim RESsarrayChangeRefcount as Integer = LeptonicaSharp._All.sarrayChangeRefcount(TestPix ,TestPix )"},1)

' Dim RESsarrayToString as String = LeptonicaSharp._All.sarrayToString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayToString",TestPix, RESsarrayToString,{"Dim RESsarrayToString as String = LeptonicaSharp._All.sarrayToString(TestPix ,TestPix )"},1)

' Dim RESsarrayToStringRange as String = LeptonicaSharp._All.sarrayToStringRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayToStringRange",TestPix, RESsarrayToStringRange,{"Dim RESsarrayToStringRange as String = LeptonicaSharp._All.sarrayToStringRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayJoin as Integer = LeptonicaSharp._All.sarrayJoin(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayJoin",TestPix, RESsarrayJoin,{"Dim RESsarrayJoin as Integer = LeptonicaSharp._All.sarrayJoin(TestPix ,TestPix )"},1)

' Dim RESsarrayAppendRange as Integer = LeptonicaSharp._All.sarrayAppendRange(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayAppendRange",TestPix, RESsarrayAppendRange,{"Dim RESsarrayAppendRange as Integer = LeptonicaSharp._All.sarrayAppendRange(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayPadToSameSize as Integer = LeptonicaSharp._All.sarrayPadToSameSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayPadToSameSize",TestPix, RESsarrayPadToSameSize,{"Dim RESsarrayPadToSameSize as Integer = LeptonicaSharp._All.sarrayPadToSameSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayConvertWordsToLines as Sarray = LeptonicaSharp._All.sarrayConvertWordsToLines(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayConvertWordsToLines",TestPix, RESsarrayConvertWordsToLines,{"Dim RESsarrayConvertWordsToLines as Sarray = LeptonicaSharp._All.sarrayConvertWordsToLines(TestPix ,TestPix )"},1)

' Dim RESsarraySplitString as Integer = LeptonicaSharp._All.sarraySplitString(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarraySplitString",TestPix, RESsarraySplitString,{"Dim RESsarraySplitString as Integer = LeptonicaSharp._All.sarraySplitString(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarraySelectBySubstring as Sarray = LeptonicaSharp._All.sarraySelectBySubstring(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarraySelectBySubstring",TestPix, RESsarraySelectBySubstring,{"Dim RESsarraySelectBySubstring as Sarray = LeptonicaSharp._All.sarraySelectBySubstring(TestPix ,Nothing )"},1)

' Dim RESsarraySelectByRange as Sarray = LeptonicaSharp._All.sarraySelectByRange(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarraySelectByRange",TestPix, RESsarraySelectByRange,{"Dim RESsarraySelectByRange as Sarray = LeptonicaSharp._All.sarraySelectByRange(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarrayParseRange as Integer = LeptonicaSharp._All.sarrayParseRange(TestPix ,TestPix ,New Integer,New Integer,New Integer,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayParseRange",TestPix, RESsarrayParseRange,{"Dim RESsarrayParseRange as Integer = LeptonicaSharp._All.sarrayParseRange(TestPix ,TestPix ,New Integer,New Integer,New Integer,TestPix ,TestPix )"},1)

' Dim RESsarrayRead as Sarray = LeptonicaSharp._All.sarrayRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayRead",TestPix, RESsarrayRead,{"Dim RESsarrayRead as Sarray = LeptonicaSharp._All.sarrayRead(TestPix )"},1)

' Dim RESsarrayReadStream as Sarray = LeptonicaSharp._All.sarrayReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayReadStream",TestPix, RESsarrayReadStream,{"Dim RESsarrayReadStream as Sarray = LeptonicaSharp._All.sarrayReadStream(TestPix )"},1)

' Dim RESsarrayReadMem as Sarray = LeptonicaSharp._All.sarrayReadMem(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayReadMem",TestPix, RESsarrayReadMem,{"Dim RESsarrayReadMem as Sarray = LeptonicaSharp._All.sarrayReadMem(TestPix ,TestPix )"},1)

' Dim RESsarrayWrite as Integer = LeptonicaSharp._All.sarrayWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayWrite",TestPix, RESsarrayWrite,{"Dim RESsarrayWrite as Integer = LeptonicaSharp._All.sarrayWrite(TestPix ,TestPix )"},1)

' Dim RESsarrayWriteStream as Integer = LeptonicaSharp._All.sarrayWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayWriteStream",TestPix, RESsarrayWriteStream,{"Dim RESsarrayWriteStream as Integer = LeptonicaSharp._All.sarrayWriteStream(TestPix ,TestPix )"},1)

' Dim RESsarrayWriteMem as Integer = LeptonicaSharp._All.sarrayWriteMem(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayWriteMem",TestPix, RESsarrayWriteMem,{"Dim RESsarrayWriteMem as Integer = LeptonicaSharp._All.sarrayWriteMem(New Byte(),New UInteger,TestPix )"},1)

' Dim RESsarrayAppend as Integer = LeptonicaSharp._All.sarrayAppend(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayAppend",TestPix, RESsarrayAppend,{"Dim RESsarrayAppend as Integer = LeptonicaSharp._All.sarrayAppend(TestPix ,TestPix )"},1)

' Dim RESgetNumberedPathnamesInDirectory as Sarray = LeptonicaSharp._All.getNumberedPathnamesInDirectory(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getNumberedPathnamesInDirectory",TestPix, RESgetNumberedPathnamesInDirectory,{"Dim RESgetNumberedPathnamesInDirectory as Sarray = LeptonicaSharp._All.getNumberedPathnamesInDirectory(TestPix ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetSortedPathnamesInDirectory as Sarray = LeptonicaSharp._All.getSortedPathnamesInDirectory(TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getSortedPathnamesInDirectory",TestPix, RESgetSortedPathnamesInDirectory,{"Dim RESgetSortedPathnamesInDirectory as Sarray = LeptonicaSharp._All.getSortedPathnamesInDirectory(TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESconvertSortedToNumberedPathnames as Sarray = LeptonicaSharp._All.convertSortedToNumberedPathnames(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertSortedToNumberedPathnames",TestPix, RESconvertSortedToNumberedPathnames,{"Dim RESconvertSortedToNumberedPathnames as Sarray = LeptonicaSharp._All.convertSortedToNumberedPathnames(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetFilenamesInDirectory as Sarray = LeptonicaSharp._All.getFilenamesInDirectory(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getFilenamesInDirectory",TestPix, RESgetFilenamesInDirectory,{"Dim RESgetFilenamesInDirectory as Sarray = LeptonicaSharp._All.getFilenamesInDirectory(TestPix )"},1)

' Dim RESsarraySort as Sarray = LeptonicaSharp._All.sarraySort(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarraySort",TestPix, RESsarraySort,{"Dim RESsarraySort as Sarray = LeptonicaSharp._All.sarraySort(TestPix ,TestPix ,TestPix )"},1)

' Dim RESsarraySortByIndex as Sarray = LeptonicaSharp._All.sarraySortByIndex(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarraySortByIndex",TestPix, RESsarraySortByIndex,{"Dim RESsarraySortByIndex as Sarray = LeptonicaSharp._All.sarraySortByIndex(TestPix ,TestPix )"},1)

' Dim RESstringCompareLexical as Integer = LeptonicaSharp._All.stringCompareLexical(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringCompareLexical",TestPix, RESstringCompareLexical,{"Dim RESstringCompareLexical as Integer = LeptonicaSharp._All.stringCompareLexical(TestPix ,TestPix )"},1)

' Dim RESsarrayUnionByAset as Sarray = LeptonicaSharp._All.sarrayUnionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayUnionByAset",TestPix, RESsarrayUnionByAset,{"Dim RESsarrayUnionByAset as Sarray = LeptonicaSharp._All.sarrayUnionByAset(TestPix ,TestPix )"},1)

' Dim RESsarrayRemoveDupsByAset as Sarray = LeptonicaSharp._All.sarrayRemoveDupsByAset(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayRemoveDupsByAset",TestPix, RESsarrayRemoveDupsByAset,{"Dim RESsarrayRemoveDupsByAset as Sarray = LeptonicaSharp._All.sarrayRemoveDupsByAset(TestPix )"},1)

' Dim RESsarrayIntersectionByAset as Sarray = LeptonicaSharp._All.sarrayIntersectionByAset(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayIntersectionByAset",TestPix, RESsarrayIntersectionByAset,{"Dim RESsarrayIntersectionByAset as Sarray = LeptonicaSharp._All.sarrayIntersectionByAset(TestPix ,TestPix )"},1)

' Dim RESl_asetCreateFromSarray as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromSarray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_asetCreateFromSarray",TestPix, RESl_asetCreateFromSarray,{"Dim RESl_asetCreateFromSarray as L_Rbtree = LeptonicaSharp._All.l_asetCreateFromSarray(TestPix )"},1)

' Dim RESsarrayRemoveDupsByHash as Integer = LeptonicaSharp._All.sarrayRemoveDupsByHash(TestPix ,New Sarray,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayRemoveDupsByHash",TestPix, RESsarrayRemoveDupsByHash,{"Dim RESsarrayRemoveDupsByHash as Integer = LeptonicaSharp._All.sarrayRemoveDupsByHash(TestPix ,New Sarray,Nothing )"},1)

' Dim RESsarrayIntersectionByHash as Sarray = LeptonicaSharp._All.sarrayIntersectionByHash(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayIntersectionByHash",TestPix, RESsarrayIntersectionByHash,{"Dim RESsarrayIntersectionByHash as Sarray = LeptonicaSharp._All.sarrayIntersectionByHash(TestPix ,TestPix )"},1)

' Dim RESsarrayFindStringByHash as Integer = LeptonicaSharp._All.sarrayFindStringByHash(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayFindStringByHash",TestPix, RESsarrayFindStringByHash,{"Dim RESsarrayFindStringByHash as Integer = LeptonicaSharp._All.sarrayFindStringByHash(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESl_dnaHashCreateFromSarray as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromSarray(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_dnaHashCreateFromSarray",TestPix, RESl_dnaHashCreateFromSarray,{"Dim RESl_dnaHashCreateFromSarray as L_DnaHash = LeptonicaSharp._All.l_dnaHashCreateFromSarray(TestPix )"},1)

' Dim RESsarrayGenerateIntegers as Sarray = LeptonicaSharp._All.sarrayGenerateIntegers(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayGenerateIntegers",TestPix, RESsarrayGenerateIntegers,{"Dim RESsarrayGenerateIntegers as Sarray = LeptonicaSharp._All.sarrayGenerateIntegers(TestPix )"},1)

' Dim RESsarrayLookupCSKV as Integer = LeptonicaSharp._All.sarrayLookupCSKV(TestPix ,TestPix ,New String())
' LeptonicaSharp.Convert.WriteHelpExtension ("sarrayLookupCSKV",TestPix, RESsarrayLookupCSKV,{"Dim RESsarrayLookupCSKV as Integer = LeptonicaSharp._All.sarrayLookupCSKV(TestPix ,TestPix ,New String())"},1)

' Dim RESpixScale as Pix = LeptonicaSharp._All.pixScale(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScale",TestPix, RESpixScale,{"Dim RESpixScale as Pix = LeptonicaSharp._All.pixScale(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleToSizeRel as Pix = LeptonicaSharp._All.pixScaleToSizeRel(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToSizeRel",TestPix, RESpixScaleToSizeRel,{"Dim RESpixScaleToSizeRel as Pix = LeptonicaSharp._All.pixScaleToSizeRel(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleToSize as Pix = LeptonicaSharp._All.pixScaleToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToSize",TestPix, RESpixScaleToSize,{"Dim RESpixScaleToSize as Pix = LeptonicaSharp._All.pixScaleToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleGeneral as Pix = LeptonicaSharp._All.pixScaleGeneral(TestPix ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGeneral",TestPix, RESpixScaleGeneral,{"Dim RESpixScaleGeneral as Pix = LeptonicaSharp._All.pixScaleGeneral(TestPix ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixScaleLI as Pix = LeptonicaSharp._All.pixScaleLI(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleLI",TestPix, RESpixScaleLI,{"Dim RESpixScaleLI as Pix = LeptonicaSharp._All.pixScaleLI(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleColorLI as Pix = LeptonicaSharp._All.pixScaleColorLI(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleColorLI",TestPix, RESpixScaleColorLI,{"Dim RESpixScaleColorLI as Pix = LeptonicaSharp._All.pixScaleColorLI(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleColor2xLI as Pix = LeptonicaSharp._All.pixScaleColor2xLI(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleColor2xLI",TestPix, RESpixScaleColor2xLI,{"Dim RESpixScaleColor2xLI as Pix = LeptonicaSharp._All.pixScaleColor2xLI(TestPix )"},1)

' Dim RESpixScaleColor4xLI as Pix = LeptonicaSharp._All.pixScaleColor4xLI(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleColor4xLI",TestPix, RESpixScaleColor4xLI,{"Dim RESpixScaleColor4xLI as Pix = LeptonicaSharp._All.pixScaleColor4xLI(TestPix )"},1)

' Dim RESpixScaleGrayLI as Pix = LeptonicaSharp._All.pixScaleGrayLI(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayLI",TestPix, RESpixScaleGrayLI,{"Dim RESpixScaleGrayLI as Pix = LeptonicaSharp._All.pixScaleGrayLI(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleGray2xLI as Pix = LeptonicaSharp._All.pixScaleGray2xLI(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray2xLI",TestPix, RESpixScaleGray2xLI,{"Dim RESpixScaleGray2xLI as Pix = LeptonicaSharp._All.pixScaleGray2xLI(TestPix )"},1)

' Dim RESpixScaleGray4xLI as Pix = LeptonicaSharp._All.pixScaleGray4xLI(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray4xLI",TestPix, RESpixScaleGray4xLI,{"Dim RESpixScaleGray4xLI as Pix = LeptonicaSharp._All.pixScaleGray4xLI(TestPix )"},1)

' Dim RESpixScaleGray2xLIThresh as Pix = LeptonicaSharp._All.pixScaleGray2xLIThresh(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray2xLIThresh",TestPix, RESpixScaleGray2xLIThresh,{"Dim RESpixScaleGray2xLIThresh as Pix = LeptonicaSharp._All.pixScaleGray2xLIThresh(TestPix ,TestPix )"},1)

' Dim RESpixScaleGray2xLIDither as Pix = LeptonicaSharp._All.pixScaleGray2xLIDither(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray2xLIDither",TestPix, RESpixScaleGray2xLIDither,{"Dim RESpixScaleGray2xLIDither as Pix = LeptonicaSharp._All.pixScaleGray2xLIDither(TestPix )"},1)

' Dim RESpixScaleGray4xLIThresh as Pix = LeptonicaSharp._All.pixScaleGray4xLIThresh(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray4xLIThresh",TestPix, RESpixScaleGray4xLIThresh,{"Dim RESpixScaleGray4xLIThresh as Pix = LeptonicaSharp._All.pixScaleGray4xLIThresh(TestPix ,TestPix )"},1)

' Dim RESpixScaleGray4xLIDither as Pix = LeptonicaSharp._All.pixScaleGray4xLIDither(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGray4xLIDither",TestPix, RESpixScaleGray4xLIDither,{"Dim RESpixScaleGray4xLIDither as Pix = LeptonicaSharp._All.pixScaleGray4xLIDither(TestPix )"},1)

' Dim RESpixScaleBySampling as Pix = LeptonicaSharp._All.pixScaleBySampling(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleBySampling",TestPix, RESpixScaleBySampling,{"Dim RESpixScaleBySampling as Pix = LeptonicaSharp._All.pixScaleBySampling(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleBySamplingToSize as Pix = LeptonicaSharp._All.pixScaleBySamplingToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleBySamplingToSize",TestPix, RESpixScaleBySamplingToSize,{"Dim RESpixScaleBySamplingToSize as Pix = LeptonicaSharp._All.pixScaleBySamplingToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleByIntSampling as Pix = LeptonicaSharp._All.pixScaleByIntSampling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleByIntSampling",TestPix, RESpixScaleByIntSampling,{"Dim RESpixScaleByIntSampling as Pix = LeptonicaSharp._All.pixScaleByIntSampling(TestPix ,TestPix )"},1)

' Dim RESpixScaleRGBToGrayFast as Pix = LeptonicaSharp._All.pixScaleRGBToGrayFast(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleRGBToGrayFast",TestPix, RESpixScaleRGBToGrayFast,{"Dim RESpixScaleRGBToGrayFast as Pix = LeptonicaSharp._All.pixScaleRGBToGrayFast(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleRGBToBinaryFast as Pix = LeptonicaSharp._All.pixScaleRGBToBinaryFast(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleRGBToBinaryFast",TestPix, RESpixScaleRGBToBinaryFast,{"Dim RESpixScaleRGBToBinaryFast as Pix = LeptonicaSharp._All.pixScaleRGBToBinaryFast(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleGrayToBinaryFast as Pix = LeptonicaSharp._All.pixScaleGrayToBinaryFast(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayToBinaryFast",TestPix, RESpixScaleGrayToBinaryFast,{"Dim RESpixScaleGrayToBinaryFast as Pix = LeptonicaSharp._All.pixScaleGrayToBinaryFast(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleSmooth as Pix = LeptonicaSharp._All.pixScaleSmooth(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleSmooth",TestPix, RESpixScaleSmooth,{"Dim RESpixScaleSmooth as Pix = LeptonicaSharp._All.pixScaleSmooth(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleSmoothToSize as Pix = LeptonicaSharp._All.pixScaleSmoothToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleSmoothToSize",TestPix, RESpixScaleSmoothToSize,{"Dim RESpixScaleSmoothToSize as Pix = LeptonicaSharp._All.pixScaleSmoothToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleRGBToGray2 as Pix = LeptonicaSharp._All.pixScaleRGBToGray2(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleRGBToGray2",TestPix, RESpixScaleRGBToGray2,{"Dim RESpixScaleRGBToGray2 as Pix = LeptonicaSharp._All.pixScaleRGBToGray2(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleAreaMap as Pix = LeptonicaSharp._All.pixScaleAreaMap(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleAreaMap",TestPix, RESpixScaleAreaMap,{"Dim RESpixScaleAreaMap as Pix = LeptonicaSharp._All.pixScaleAreaMap(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleAreaMap2 as Pix = LeptonicaSharp._All.pixScaleAreaMap2(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleAreaMap2",TestPix, RESpixScaleAreaMap2,{"Dim RESpixScaleAreaMap2 as Pix = LeptonicaSharp._All.pixScaleAreaMap2(TestPix )"},1)

' Dim RESpixScaleAreaMapToSize as Pix = LeptonicaSharp._All.pixScaleAreaMapToSize(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleAreaMapToSize",TestPix, RESpixScaleAreaMapToSize,{"Dim RESpixScaleAreaMapToSize as Pix = LeptonicaSharp._All.pixScaleAreaMapToSize(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleBinary as Pix = LeptonicaSharp._All.pixScaleBinary(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleBinary",TestPix, RESpixScaleBinary,{"Dim RESpixScaleBinary as Pix = LeptonicaSharp._All.pixScaleBinary(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleToGray as Pix = LeptonicaSharp._All.pixScaleToGray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray",TestPix, RESpixScaleToGray,{"Dim RESpixScaleToGray as Pix = LeptonicaSharp._All.pixScaleToGray(TestPix ,TestPix )"},1)

' Dim RESpixScaleToGrayFast as Pix = LeptonicaSharp._All.pixScaleToGrayFast(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGrayFast",TestPix, RESpixScaleToGrayFast,{"Dim RESpixScaleToGrayFast as Pix = LeptonicaSharp._All.pixScaleToGrayFast(TestPix ,TestPix )"},1)

' Dim RESpixScaleToGray2 as Pix = LeptonicaSharp._All.pixScaleToGray2(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray2",TestPix, RESpixScaleToGray2,{"Dim RESpixScaleToGray2 as Pix = LeptonicaSharp._All.pixScaleToGray2(TestPix )"},1)

' Dim RESpixScaleToGray3 as Pix = LeptonicaSharp._All.pixScaleToGray3(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray3",TestPix, RESpixScaleToGray3,{"Dim RESpixScaleToGray3 as Pix = LeptonicaSharp._All.pixScaleToGray3(TestPix )"},1)

' Dim RESpixScaleToGray4 as Pix = LeptonicaSharp._All.pixScaleToGray4(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray4",TestPix, RESpixScaleToGray4,{"Dim RESpixScaleToGray4 as Pix = LeptonicaSharp._All.pixScaleToGray4(TestPix )"},1)

' Dim RESpixScaleToGray6 as Pix = LeptonicaSharp._All.pixScaleToGray6(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray6",TestPix, RESpixScaleToGray6,{"Dim RESpixScaleToGray6 as Pix = LeptonicaSharp._All.pixScaleToGray6(TestPix )"},1)

' Dim RESpixScaleToGray8 as Pix = LeptonicaSharp._All.pixScaleToGray8(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray8",TestPix, RESpixScaleToGray8,{"Dim RESpixScaleToGray8 as Pix = LeptonicaSharp._All.pixScaleToGray8(TestPix )"},1)

' Dim RESpixScaleToGray16 as Pix = LeptonicaSharp._All.pixScaleToGray16(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGray16",TestPix, RESpixScaleToGray16,{"Dim RESpixScaleToGray16 as Pix = LeptonicaSharp._All.pixScaleToGray16(TestPix )"},1)

' Dim RESpixScaleToGrayMipmap as Pix = LeptonicaSharp._All.pixScaleToGrayMipmap(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleToGrayMipmap",TestPix, RESpixScaleToGrayMipmap,{"Dim RESpixScaleToGrayMipmap as Pix = LeptonicaSharp._All.pixScaleToGrayMipmap(TestPix ,TestPix )"},1)

' Dim RESpixScaleMipmap as Pix = LeptonicaSharp._All.pixScaleMipmap(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleMipmap",TestPix, RESpixScaleMipmap,{"Dim RESpixScaleMipmap as Pix = LeptonicaSharp._All.pixScaleMipmap(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixExpandReplicate as Pix = LeptonicaSharp._All.pixExpandReplicate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExpandReplicate",TestPix, RESpixExpandReplicate,{"Dim RESpixExpandReplicate as Pix = LeptonicaSharp._All.pixExpandReplicate(TestPix ,TestPix )"},1)

' Dim RESpixScaleGrayMinMax as Pix = LeptonicaSharp._All.pixScaleGrayMinMax(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayMinMax",TestPix, RESpixScaleGrayMinMax,{"Dim RESpixScaleGrayMinMax as Pix = LeptonicaSharp._All.pixScaleGrayMinMax(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleGrayMinMax2 as Pix = LeptonicaSharp._All.pixScaleGrayMinMax2(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayMinMax2",TestPix, RESpixScaleGrayMinMax2,{"Dim RESpixScaleGrayMinMax2 as Pix = LeptonicaSharp._All.pixScaleGrayMinMax2(TestPix ,TestPix )"},1)

' Dim RESpixScaleGrayRankCascade as Pix = LeptonicaSharp._All.pixScaleGrayRankCascade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayRankCascade",TestPix, RESpixScaleGrayRankCascade,{"Dim RESpixScaleGrayRankCascade as Pix = LeptonicaSharp._All.pixScaleGrayRankCascade(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixScaleGrayRank2 as Pix = LeptonicaSharp._All.pixScaleGrayRank2(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleGrayRank2",TestPix, RESpixScaleGrayRank2,{"Dim RESpixScaleGrayRank2 as Pix = LeptonicaSharp._All.pixScaleGrayRank2(TestPix ,TestPix )"},1)

' Dim RESpixScaleAndTransferAlpha as Integer = LeptonicaSharp._All.pixScaleAndTransferAlpha(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleAndTransferAlpha",TestPix, RESpixScaleAndTransferAlpha,{"Dim RESpixScaleAndTransferAlpha as Integer = LeptonicaSharp._All.pixScaleAndTransferAlpha(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixScaleWithAlpha as Pix = LeptonicaSharp._All.pixScaleWithAlpha(TestPix ,Nothing ,Nothing ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixScaleWithAlpha",TestPix, RESpixScaleWithAlpha,{"Dim RESpixScaleWithAlpha as Pix = LeptonicaSharp._All.pixScaleWithAlpha(TestPix ,Nothing ,Nothing ,Nothing ,TestPix )"},1)

' Dim RESpixSeedfillBinary as Pix = LeptonicaSharp._All.pixSeedfillBinary(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillBinary",TestPix, RESpixSeedfillBinary,{"Dim RESpixSeedfillBinary as Pix = LeptonicaSharp._All.pixSeedfillBinary(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillBinaryRestricted as Pix = LeptonicaSharp._All.pixSeedfillBinaryRestricted(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillBinaryRestricted",TestPix, RESpixSeedfillBinaryRestricted,{"Dim RESpixSeedfillBinaryRestricted as Pix = LeptonicaSharp._All.pixSeedfillBinaryRestricted(Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHolesByFilling as Pix = LeptonicaSharp._All.pixHolesByFilling(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHolesByFilling",TestPix, RESpixHolesByFilling,{"Dim RESpixHolesByFilling as Pix = LeptonicaSharp._All.pixHolesByFilling(TestPix ,TestPix )"},1)

' Dim RESpixFillClosedBorders as Pix = LeptonicaSharp._All.pixFillClosedBorders(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFillClosedBorders",TestPix, RESpixFillClosedBorders,{"Dim RESpixFillClosedBorders as Pix = LeptonicaSharp._All.pixFillClosedBorders(TestPix ,TestPix )"},1)

' Dim RESpixExtractBorderConnComps as Pix = LeptonicaSharp._All.pixExtractBorderConnComps(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixExtractBorderConnComps",TestPix, RESpixExtractBorderConnComps,{"Dim RESpixExtractBorderConnComps as Pix = LeptonicaSharp._All.pixExtractBorderConnComps(TestPix ,TestPix )"},1)

' Dim RESpixRemoveBorderConnComps as Pix = LeptonicaSharp._All.pixRemoveBorderConnComps(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveBorderConnComps",TestPix, RESpixRemoveBorderConnComps,{"Dim RESpixRemoveBorderConnComps as Pix = LeptonicaSharp._All.pixRemoveBorderConnComps(TestPix ,TestPix )"},1)

' Dim RESpixFillBgFromBorder as Pix = LeptonicaSharp._All.pixFillBgFromBorder(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFillBgFromBorder",TestPix, RESpixFillBgFromBorder,{"Dim RESpixFillBgFromBorder as Pix = LeptonicaSharp._All.pixFillBgFromBorder(TestPix ,TestPix )"},1)

' Dim RESpixFillHolesToBoundingRect as Pix = LeptonicaSharp._All.pixFillHolesToBoundingRect(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFillHolesToBoundingRect",TestPix, RESpixFillHolesToBoundingRect,{"Dim RESpixFillHolesToBoundingRect as Pix = LeptonicaSharp._All.pixFillHolesToBoundingRect(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillGray as Integer = LeptonicaSharp._All.pixSeedfillGray(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillGray",TestPix, RESpixSeedfillGray,{"Dim RESpixSeedfillGray as Integer = LeptonicaSharp._All.pixSeedfillGray(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillGrayInv as Integer = LeptonicaSharp._All.pixSeedfillGrayInv(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillGrayInv",TestPix, RESpixSeedfillGrayInv,{"Dim RESpixSeedfillGrayInv as Integer = LeptonicaSharp._All.pixSeedfillGrayInv(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillGraySimple as Integer = LeptonicaSharp._All.pixSeedfillGraySimple(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillGraySimple",TestPix, RESpixSeedfillGraySimple,{"Dim RESpixSeedfillGraySimple as Integer = LeptonicaSharp._All.pixSeedfillGraySimple(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillGrayInvSimple as Integer = LeptonicaSharp._All.pixSeedfillGrayInvSimple(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillGrayInvSimple",TestPix, RESpixSeedfillGrayInvSimple,{"Dim RESpixSeedfillGrayInvSimple as Integer = LeptonicaSharp._All.pixSeedfillGrayInvSimple(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedfillGrayBasin as Pix = LeptonicaSharp._All.pixSeedfillGrayBasin(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedfillGrayBasin",TestPix, RESpixSeedfillGrayBasin,{"Dim RESpixSeedfillGrayBasin as Pix = LeptonicaSharp._All.pixSeedfillGrayBasin(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDistanceFunction as Pix = LeptonicaSharp._All.pixDistanceFunction(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDistanceFunction",TestPix, RESpixDistanceFunction,{"Dim RESpixDistanceFunction as Pix = LeptonicaSharp._All.pixDistanceFunction(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSeedspread as Pix = LeptonicaSharp._All.pixSeedspread(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSeedspread",TestPix, RESpixSeedspread,{"Dim RESpixSeedspread as Pix = LeptonicaSharp._All.pixSeedspread(TestPix ,TestPix )"},1)

' Dim RESpixLocalExtrema as Integer = LeptonicaSharp._All.pixLocalExtrema(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixLocalExtrema",TestPix, RESpixLocalExtrema,{"Dim RESpixLocalExtrema as Integer = LeptonicaSharp._All.pixLocalExtrema(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixSelectedLocalExtrema as Integer = LeptonicaSharp._All.pixSelectedLocalExtrema(TestPix ,TestPix ,New Pix,New Pix)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectedLocalExtrema",TestPix, RESpixSelectedLocalExtrema,{"Dim RESpixSelectedLocalExtrema as Integer = LeptonicaSharp._All.pixSelectedLocalExtrema(TestPix ,TestPix ,New Pix,New Pix)"},1)

' Dim RESpixFindEqualValues as Pix = LeptonicaSharp._All.pixFindEqualValues(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindEqualValues",TestPix, RESpixFindEqualValues,{"Dim RESpixFindEqualValues as Pix = LeptonicaSharp._All.pixFindEqualValues(TestPix ,TestPix )"},1)

' Dim RESpixSelectMinInConnComp as Integer = LeptonicaSharp._All.pixSelectMinInConnComp(TestPix ,TestPix ,New Pta,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSelectMinInConnComp",TestPix, RESpixSelectMinInConnComp,{"Dim RESpixSelectMinInConnComp as Integer = LeptonicaSharp._All.pixSelectMinInConnComp(TestPix ,TestPix ,New Pta,Nothing )"},1)

' Dim RESpixRemoveSeededComponents as Pix = LeptonicaSharp._All.pixRemoveSeededComponents(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRemoveSeededComponents",TestPix, RESpixRemoveSeededComponents,{"Dim RESpixRemoveSeededComponents as Pix = LeptonicaSharp._All.pixRemoveSeededComponents(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaCreate as Sela = LeptonicaSharp._All.selaCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaCreate",TestPix, RESselaCreate,{"Dim RESselaCreate as Sela = LeptonicaSharp._All.selaCreate(TestPix )"},1)

' Dim RESselaDestroy as Object = LeptonicaSharp._All.selaDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaDestroy",TestPix, RESselaDestroy,{"Dim RESselaDestroy as Object = LeptonicaSharp._All.selaDestroy(TestPix )"},1)

' Dim RESselCreate as Sel = LeptonicaSharp._All.selCreate(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreate",TestPix, RESselCreate,{"Dim RESselCreate as Sel = LeptonicaSharp._All.selCreate(TestPix ,TestPix ,Nothing )"},1)

' Dim RESselDestroy as Object = LeptonicaSharp._All.selDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selDestroy",TestPix, RESselDestroy,{"Dim RESselDestroy as Object = LeptonicaSharp._All.selDestroy(TestPix )"},1)

' Dim RESselCopy as Sel = LeptonicaSharp._All.selCopy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCopy",TestPix, RESselCopy,{"Dim RESselCopy as Sel = LeptonicaSharp._All.selCopy(TestPix )"},1)

' Dim RESselCreateBrick as Sel = LeptonicaSharp._All.selCreateBrick(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateBrick",TestPix, RESselCreateBrick,{"Dim RESselCreateBrick as Sel = LeptonicaSharp._All.selCreateBrick(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselCreateComb as Sel = LeptonicaSharp._All.selCreateComb(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateComb",TestPix, RESselCreateComb,{"Dim RESselCreateComb as Sel = LeptonicaSharp._All.selCreateComb(TestPix ,TestPix ,TestPix )"},1)

' Dim REScreate2dIntArray as List (of Integer()) = LeptonicaSharp._All.create2dIntArray(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("create2dIntArray",TestPix, REScreate2dIntArray,{"Dim REScreate2dIntArray as List (of Integer()) = LeptonicaSharp._All.create2dIntArray(TestPix ,TestPix )"},1)

' Dim RESselaAddSel as Integer = LeptonicaSharp._All.selaAddSel(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddSel",TestPix, RESselaAddSel,{"Dim RESselaAddSel as Integer = LeptonicaSharp._All.selaAddSel(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaGetCount as Integer = LeptonicaSharp._All.selaGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaGetCount",TestPix, RESselaGetCount,{"Dim RESselaGetCount as Integer = LeptonicaSharp._All.selaGetCount(TestPix )"},1)

' Dim RESselaGetSel as Sel = LeptonicaSharp._All.selaGetSel(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaGetSel",TestPix, RESselaGetSel,{"Dim RESselaGetSel as Sel = LeptonicaSharp._All.selaGetSel(TestPix ,TestPix )"},1)

' Dim RESselGetName as String = LeptonicaSharp._All.selGetName(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selGetName",TestPix, RESselGetName,{"Dim RESselGetName as String = LeptonicaSharp._All.selGetName(TestPix )"},1)

' Dim RESselSetName as Integer = LeptonicaSharp._All.selSetName(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selSetName",TestPix, RESselSetName,{"Dim RESselSetName as Integer = LeptonicaSharp._All.selSetName(TestPix ,Nothing )"},1)

' Dim RESselaFindSelByName as Integer = LeptonicaSharp._All.selaFindSelByName(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaFindSelByName",TestPix, RESselaFindSelByName,{"Dim RESselaFindSelByName as Integer = LeptonicaSharp._All.selaFindSelByName(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESselGetElement as Integer = LeptonicaSharp._All.selGetElement(TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("selGetElement",TestPix, RESselGetElement,{"Dim RESselGetElement as Integer = LeptonicaSharp._All.selGetElement(TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESselSetElement as Integer = LeptonicaSharp._All.selSetElement(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selSetElement",TestPix, RESselSetElement,{"Dim RESselSetElement as Integer = LeptonicaSharp._All.selSetElement(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselGetParameters as Integer = LeptonicaSharp._All.selGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selGetParameters",TestPix, RESselGetParameters,{"Dim RESselGetParameters as Integer = LeptonicaSharp._All.selGetParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESselSetOrigin as Integer = LeptonicaSharp._All.selSetOrigin(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selSetOrigin",TestPix, RESselSetOrigin,{"Dim RESselSetOrigin as Integer = LeptonicaSharp._All.selSetOrigin(TestPix ,TestPix ,TestPix )"},1)

' Dim RESselGetTypeAtOrigin as Integer = LeptonicaSharp._All.selGetTypeAtOrigin(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("selGetTypeAtOrigin",TestPix, RESselGetTypeAtOrigin,{"Dim RESselGetTypeAtOrigin as Integer = LeptonicaSharp._All.selGetTypeAtOrigin(TestPix ,New Integer)"},1)

' Dim RESselaGetBrickName as String = LeptonicaSharp._All.selaGetBrickName(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaGetBrickName",TestPix, RESselaGetBrickName,{"Dim RESselaGetBrickName as String = LeptonicaSharp._All.selaGetBrickName(TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaGetCombName as String = LeptonicaSharp._All.selaGetCombName(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaGetCombName",TestPix, RESselaGetCombName,{"Dim RESselaGetCombName as String = LeptonicaSharp._All.selaGetCombName(TestPix ,TestPix ,TestPix )"},1)

' Dim RESgetCompositeParameters as Integer = LeptonicaSharp._All.getCompositeParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("getCompositeParameters",TestPix, RESgetCompositeParameters,{"Dim RESgetCompositeParameters as Integer = LeptonicaSharp._All.getCompositeParameters(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESselaGetSelnames as Sarray = LeptonicaSharp._All.selaGetSelnames(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaGetSelnames",TestPix, RESselaGetSelnames,{"Dim RESselaGetSelnames as Sarray = LeptonicaSharp._All.selaGetSelnames(TestPix )"},1)

' Dim RESselFindMaxTranslations as Integer = LeptonicaSharp._All.selFindMaxTranslations(TestPix ,New Integer,New Integer,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("selFindMaxTranslations",TestPix, RESselFindMaxTranslations,{"Dim RESselFindMaxTranslations as Integer = LeptonicaSharp._All.selFindMaxTranslations(TestPix ,New Integer,New Integer,New Integer,New Integer)"},1)

' Dim RESselRotateOrth as Sel = LeptonicaSharp._All.selRotateOrth(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selRotateOrth",TestPix, RESselRotateOrth,{"Dim RESselRotateOrth as Sel = LeptonicaSharp._All.selRotateOrth(TestPix ,TestPix )"},1)

' Dim RESselaRead as Sela = LeptonicaSharp._All.selaRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaRead",TestPix, RESselaRead,{"Dim RESselaRead as Sela = LeptonicaSharp._All.selaRead(TestPix )"},1)

' Dim RESselaReadStream as Sela = LeptonicaSharp._All.selaReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaReadStream",TestPix, RESselaReadStream,{"Dim RESselaReadStream as Sela = LeptonicaSharp._All.selaReadStream(TestPix )"},1)

' Dim RESselRead as Sel = LeptonicaSharp._All.selRead(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selRead",TestPix, RESselRead,{"Dim RESselRead as Sel = LeptonicaSharp._All.selRead(TestPix )"},1)

' Dim RESselReadStream as Sel = LeptonicaSharp._All.selReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selReadStream",TestPix, RESselReadStream,{"Dim RESselReadStream as Sel = LeptonicaSharp._All.selReadStream(TestPix )"},1)

' Dim RESselaWrite as Integer = LeptonicaSharp._All.selaWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaWrite",TestPix, RESselaWrite,{"Dim RESselaWrite as Integer = LeptonicaSharp._All.selaWrite(TestPix ,TestPix )"},1)

' Dim RESselaWriteStream as Integer = LeptonicaSharp._All.selaWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaWriteStream",TestPix, RESselaWriteStream,{"Dim RESselaWriteStream as Integer = LeptonicaSharp._All.selaWriteStream(TestPix ,TestPix )"},1)

' Dim RESselWrite as Integer = LeptonicaSharp._All.selWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selWrite",TestPix, RESselWrite,{"Dim RESselWrite as Integer = LeptonicaSharp._All.selWrite(TestPix ,TestPix )"},1)

' Dim RESselWriteStream as Integer = LeptonicaSharp._All.selWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selWriteStream",TestPix, RESselWriteStream,{"Dim RESselWriteStream as Integer = LeptonicaSharp._All.selWriteStream(TestPix ,TestPix )"},1)

' Dim RESselCreateFromString as Sel = LeptonicaSharp._All.selCreateFromString(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateFromString",TestPix, RESselCreateFromString,{"Dim RESselCreateFromString as Sel = LeptonicaSharp._All.selCreateFromString(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESselPrintToString as String = LeptonicaSharp._All.selPrintToString(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selPrintToString",TestPix, RESselPrintToString,{"Dim RESselPrintToString as String = LeptonicaSharp._All.selPrintToString(TestPix )"},1)

' Dim RESselaCreateFromFile as Sela = LeptonicaSharp._All.selaCreateFromFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaCreateFromFile",TestPix, RESselaCreateFromFile,{"Dim RESselaCreateFromFile as Sela = LeptonicaSharp._All.selaCreateFromFile(TestPix )"},1)

' Dim RESselCreateFromPta as Sel = LeptonicaSharp._All.selCreateFromPta(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateFromPta",TestPix, RESselCreateFromPta,{"Dim RESselCreateFromPta as Sel = LeptonicaSharp._All.selCreateFromPta(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESselCreateFromPix as Sel = LeptonicaSharp._All.selCreateFromPix(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateFromPix",TestPix, RESselCreateFromPix,{"Dim RESselCreateFromPix as Sel = LeptonicaSharp._All.selCreateFromPix(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESselReadFromColorImage as Sel = LeptonicaSharp._All.selReadFromColorImage(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selReadFromColorImage",TestPix, RESselReadFromColorImage,{"Dim RESselReadFromColorImage as Sel = LeptonicaSharp._All.selReadFromColorImage(TestPix )"},1)

' Dim RESselCreateFromColorPix as Sel = LeptonicaSharp._All.selCreateFromColorPix(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selCreateFromColorPix",TestPix, RESselCreateFromColorPix,{"Dim RESselCreateFromColorPix as Sel = LeptonicaSharp._All.selCreateFromColorPix(TestPix ,Nothing )"},1)

' Dim RESselDisplayInPix as Pix = LeptonicaSharp._All.selDisplayInPix(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selDisplayInPix",TestPix, RESselDisplayInPix,{"Dim RESselDisplayInPix as Pix = LeptonicaSharp._All.selDisplayInPix(TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaDisplayInPix as Pix = LeptonicaSharp._All.selaDisplayInPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaDisplayInPix",TestPix, RESselaDisplayInPix,{"Dim RESselaDisplayInPix as Pix = LeptonicaSharp._All.selaDisplayInPix(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaAddBasic as Sela = LeptonicaSharp._All.selaAddBasic(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddBasic",TestPix, RESselaAddBasic,{"Dim RESselaAddBasic as Sela = LeptonicaSharp._All.selaAddBasic(Nothing )"},1)

' Dim RESselaAddHitMiss as Sela = LeptonicaSharp._All.selaAddHitMiss(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddHitMiss",TestPix, RESselaAddHitMiss,{"Dim RESselaAddHitMiss as Sela = LeptonicaSharp._All.selaAddHitMiss(Nothing )"},1)

' Dim RESselaAddDwaLinear as Sela = LeptonicaSharp._All.selaAddDwaLinear(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddDwaLinear",TestPix, RESselaAddDwaLinear,{"Dim RESselaAddDwaLinear as Sela = LeptonicaSharp._All.selaAddDwaLinear(Nothing )"},1)

' Dim RESselaAddDwaCombs as Sela = LeptonicaSharp._All.selaAddDwaCombs(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddDwaCombs",TestPix, RESselaAddDwaCombs,{"Dim RESselaAddDwaCombs as Sela = LeptonicaSharp._All.selaAddDwaCombs(Nothing )"},1)

' Dim RESselaAddCrossJunctions as Sela = LeptonicaSharp._All.selaAddCrossJunctions(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddCrossJunctions",TestPix, RESselaAddCrossJunctions,{"Dim RESselaAddCrossJunctions as Sela = LeptonicaSharp._All.selaAddCrossJunctions(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESselaAddTJunctions as Sela = LeptonicaSharp._All.selaAddTJunctions(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("selaAddTJunctions",TestPix, RESselaAddTJunctions,{"Dim RESselaAddTJunctions as Sela = LeptonicaSharp._All.selaAddTJunctions(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsela4ccThin as Sela = LeptonicaSharp._All.sela4ccThin(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sela4ccThin",TestPix, RESsela4ccThin,{"Dim RESsela4ccThin as Sela = LeptonicaSharp._All.sela4ccThin(Nothing )"},1)

' Dim RESsela8ccThin as Sela = LeptonicaSharp._All.sela8ccThin(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sela8ccThin",TestPix, RESsela8ccThin,{"Dim RESsela8ccThin as Sela = LeptonicaSharp._All.sela8ccThin(Nothing )"},1)

' Dim RESsela4and8ccThin as Sela = LeptonicaSharp._All.sela4and8ccThin(Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sela4and8ccThin",TestPix, RESsela4and8ccThin,{"Dim RESsela4and8ccThin as Sela = LeptonicaSharp._All.sela4and8ccThin(Nothing )"},1)

' Dim RESpixGenerateSelWithRuns as Sel = LeptonicaSharp._All.pixGenerateSelWithRuns(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateSelWithRuns",TestPix, RESpixGenerateSelWithRuns,{"Dim RESpixGenerateSelWithRuns as Sel = LeptonicaSharp._All.pixGenerateSelWithRuns(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGenerateSelRandom as Sel = LeptonicaSharp._All.pixGenerateSelRandom(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateSelRandom",TestPix, RESpixGenerateSelRandom,{"Dim RESpixGenerateSelRandom as Sel = LeptonicaSharp._All.pixGenerateSelRandom(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGenerateSelBoundary as Sel = LeptonicaSharp._All.pixGenerateSelBoundary(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGenerateSelBoundary",TestPix, RESpixGenerateSelBoundary,{"Dim RESpixGenerateSelBoundary as Sel = LeptonicaSharp._All.pixGenerateSelBoundary(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixGetRunCentersOnLine as Numa = LeptonicaSharp._All.pixGetRunCentersOnLine(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRunCentersOnLine",TestPix, RESpixGetRunCentersOnLine,{"Dim RESpixGetRunCentersOnLine as Numa = LeptonicaSharp._All.pixGetRunCentersOnLine(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixGetRunsOnLine as Numa = LeptonicaSharp._All.pixGetRunsOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetRunsOnLine",TestPix, RESpixGetRunsOnLine,{"Dim RESpixGetRunsOnLine as Numa = LeptonicaSharp._All.pixGetRunsOnLine(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSubsampleBoundaryPixels as Pta = LeptonicaSharp._All.pixSubsampleBoundaryPixels(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSubsampleBoundaryPixels",TestPix, RESpixSubsampleBoundaryPixels,{"Dim RESpixSubsampleBoundaryPixels as Pta = LeptonicaSharp._All.pixSubsampleBoundaryPixels(TestPix ,TestPix )"},1)

' Dim RESadjacentOnPixelInRaster as Integer = LeptonicaSharp._All.adjacentOnPixelInRaster(TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("adjacentOnPixelInRaster",TestPix, RESadjacentOnPixelInRaster,{"Dim RESadjacentOnPixelInRaster as Integer = LeptonicaSharp._All.adjacentOnPixelInRaster(TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESpixDisplayHitMissSel as Pix = LeptonicaSharp._All.pixDisplayHitMissSel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayHitMissSel",TestPix, RESpixDisplayHitMissSel,{"Dim RESpixDisplayHitMissSel as Pix = LeptonicaSharp._All.pixDisplayHitMissSel(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHShear as Pix = LeptonicaSharp._All.pixHShear(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHShear",TestPix, RESpixHShear,{"Dim RESpixHShear as Pix = LeptonicaSharp._All.pixHShear(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVShear as Pix = LeptonicaSharp._All.pixVShear(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVShear",TestPix, RESpixVShear,{"Dim RESpixVShear as Pix = LeptonicaSharp._All.pixVShear(Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHShearCorner as Pix = LeptonicaSharp._All.pixHShearCorner(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHShearCorner",TestPix, RESpixHShearCorner,{"Dim RESpixHShearCorner as Pix = LeptonicaSharp._All.pixHShearCorner(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVShearCorner as Pix = LeptonicaSharp._All.pixVShearCorner(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVShearCorner",TestPix, RESpixVShearCorner,{"Dim RESpixVShearCorner as Pix = LeptonicaSharp._All.pixVShearCorner(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHShearCenter as Pix = LeptonicaSharp._All.pixHShearCenter(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHShearCenter",TestPix, RESpixHShearCenter,{"Dim RESpixHShearCenter as Pix = LeptonicaSharp._All.pixHShearCenter(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVShearCenter as Pix = LeptonicaSharp._All.pixVShearCenter(Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVShearCenter",TestPix, RESpixVShearCenter,{"Dim RESpixVShearCenter as Pix = LeptonicaSharp._All.pixVShearCenter(Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHShearIP as Integer = LeptonicaSharp._All.pixHShearIP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHShearIP",TestPix, RESpixHShearIP,{"Dim RESpixHShearIP as Integer = LeptonicaSharp._All.pixHShearIP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVShearIP as Integer = LeptonicaSharp._All.pixVShearIP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVShearIP",TestPix, RESpixVShearIP,{"Dim RESpixVShearIP as Integer = LeptonicaSharp._All.pixVShearIP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixHShearLI as Pix = LeptonicaSharp._All.pixHShearLI(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixHShearLI",TestPix, RESpixHShearLI,{"Dim RESpixHShearLI as Pix = LeptonicaSharp._All.pixHShearLI(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixVShearLI as Pix = LeptonicaSharp._All.pixVShearLI(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixVShearLI",TestPix, RESpixVShearLI,{"Dim RESpixVShearLI as Pix = LeptonicaSharp._All.pixVShearLI(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDeskewBoth as Pix = LeptonicaSharp._All.pixDeskewBoth(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeskewBoth",TestPix, RESpixDeskewBoth,{"Dim RESpixDeskewBoth as Pix = LeptonicaSharp._All.pixDeskewBoth(TestPix ,Nothing )"},1)

' Dim RESpixDeskew as Pix = LeptonicaSharp._All.pixDeskew(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeskew",TestPix, RESpixDeskew,{"Dim RESpixDeskew as Pix = LeptonicaSharp._All.pixDeskew(TestPix ,Nothing )"},1)

' Dim RESpixFindSkewAndDeskew as Pix = LeptonicaSharp._All.pixFindSkewAndDeskew(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewAndDeskew",TestPix, RESpixFindSkewAndDeskew,{"Dim RESpixFindSkewAndDeskew as Pix = LeptonicaSharp._All.pixFindSkewAndDeskew(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixDeskewGeneral as Pix = LeptonicaSharp._All.pixDeskewGeneral(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeskewGeneral",TestPix, RESpixDeskewGeneral,{"Dim RESpixDeskewGeneral as Pix = LeptonicaSharp._All.pixDeskewGeneral(TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixFindSkew as Integer = LeptonicaSharp._All.pixFindSkew(TestPix ,New Single,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkew",TestPix, RESpixFindSkew,{"Dim RESpixFindSkew as Integer = LeptonicaSharp._All.pixFindSkew(TestPix ,New Single,New Single)"},1)

' Dim RESpixFindSkewSweep as Integer = LeptonicaSharp._All.pixFindSkewSweep(TestPix ,New Single,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewSweep",TestPix, RESpixFindSkewSweep,{"Dim RESpixFindSkewSweep as Integer = LeptonicaSharp._All.pixFindSkewSweep(TestPix ,New Single,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindSkewSweepAndSearch as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearch(TestPix ,New Single,New Single,Nothing ,Nothing ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewSweepAndSearch",TestPix, RESpixFindSkewSweepAndSearch,{"Dim RESpixFindSkewSweepAndSearch as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearch(TestPix ,New Single,New Single,Nothing ,Nothing ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindSkewSweepAndSearchScore as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearchScore(TestPix ,New Single,New Single,Nothing ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewSweepAndSearchScore",TestPix, RESpixFindSkewSweepAndSearchScore,{"Dim RESpixFindSkewSweepAndSearchScore as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearchScore(TestPix ,New Single,New Single,Nothing ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindSkewSweepAndSearchScorePivot as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearchScorePivot(TestPix ,New Single,New Single,Nothing ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewSweepAndSearchScorePivot",TestPix, RESpixFindSkewSweepAndSearchScorePivot,{"Dim RESpixFindSkewSweepAndSearchScorePivot as Integer = LeptonicaSharp._All.pixFindSkewSweepAndSearchScorePivot(TestPix ,New Single,New Single,Nothing ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindSkewOrthogonalRange as Integer = LeptonicaSharp._All.pixFindSkewOrthogonalRange(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindSkewOrthogonalRange",TestPix, RESpixFindSkewOrthogonalRange,{"Dim RESpixFindSkewOrthogonalRange as Integer = LeptonicaSharp._All.pixFindSkewOrthogonalRange(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixFindDifferentialSquareSum as Integer = LeptonicaSharp._All.pixFindDifferentialSquareSum(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindDifferentialSquareSum",TestPix, RESpixFindDifferentialSquareSum,{"Dim RESpixFindDifferentialSquareSum as Integer = LeptonicaSharp._All.pixFindDifferentialSquareSum(TestPix ,New Single)"},1)

' Dim RESpixFindNormalizedSquareSum as Integer = LeptonicaSharp._All.pixFindNormalizedSquareSum(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindNormalizedSquareSum",TestPix, RESpixFindNormalizedSquareSum,{"Dim RESpixFindNormalizedSquareSum as Integer = LeptonicaSharp._All.pixFindNormalizedSquareSum(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixReadStreamSpix as Pix = LeptonicaSharp._All.pixReadStreamSpix(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamSpix",TestPix, RESpixReadStreamSpix,{"Dim RESpixReadStreamSpix as Pix = LeptonicaSharp._All.pixReadStreamSpix(TestPix )"},1)

' Dim RESreadHeaderSpix as Integer = LeptonicaSharp._All.readHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderSpix",TestPix, RESreadHeaderSpix,{"Dim RESreadHeaderSpix as Integer = LeptonicaSharp._All.readHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )"},1)

' Dim RESfreadHeaderSpix as Integer = LeptonicaSharp._All.freadHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderSpix",TestPix, RESfreadHeaderSpix,{"Dim RESfreadHeaderSpix as Integer = LeptonicaSharp._All.freadHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )"},1)

' Dim RESsreadHeaderSpix as Integer = LeptonicaSharp._All.sreadHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("sreadHeaderSpix",TestPix, RESsreadHeaderSpix,{"Dim RESsreadHeaderSpix as Integer = LeptonicaSharp._All.sreadHeaderSpix(TestPix ,New Integer,New Integer,New Integer,New Integer,Nothing )"},1)

' Dim RESpixWriteStreamSpix as Integer = LeptonicaSharp._All.pixWriteStreamSpix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamSpix",TestPix, RESpixWriteStreamSpix,{"Dim RESpixWriteStreamSpix as Integer = LeptonicaSharp._All.pixWriteStreamSpix(TestPix ,TestPix )"},1)

' Dim RESpixReadMemSpix as Pix = LeptonicaSharp._All.pixReadMemSpix(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemSpix",TestPix, RESpixReadMemSpix,{"Dim RESpixReadMemSpix as Pix = LeptonicaSharp._All.pixReadMemSpix(TestPix ,TestPix )"},1)

' Dim RESpixWriteMemSpix as Integer = LeptonicaSharp._All.pixWriteMemSpix(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemSpix",TestPix, RESpixWriteMemSpix,{"Dim RESpixWriteMemSpix as Integer = LeptonicaSharp._All.pixWriteMemSpix(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixSerializeToMemory as Integer = LeptonicaSharp._All.pixSerializeToMemory(TestPix ,New Byte(),New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSerializeToMemory",TestPix, RESpixSerializeToMemory,{"Dim RESpixSerializeToMemory as Integer = LeptonicaSharp._All.pixSerializeToMemory(TestPix ,New Byte(),New UInteger)"},1)

' Dim RESpixDeserializeFromMemory as Pix = LeptonicaSharp._All.pixDeserializeFromMemory(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDeserializeFromMemory",TestPix, RESpixDeserializeFromMemory,{"Dim RESpixDeserializeFromMemory as Pix = LeptonicaSharp._All.pixDeserializeFromMemory(TestPix ,TestPix )"},1)

' Dim RESlstackCreate as L_Stack = LeptonicaSharp._All.lstackCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackCreate",TestPix, RESlstackCreate,{"Dim RESlstackCreate as L_Stack = LeptonicaSharp._All.lstackCreate(TestPix )"},1)

' Dim RESlstackDestroy as Object = LeptonicaSharp._All.lstackDestroy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackDestroy",TestPix, RESlstackDestroy,{"Dim RESlstackDestroy as Object = LeptonicaSharp._All.lstackDestroy(TestPix ,TestPix )"},1)

' Dim RESlstackAdd as Integer = LeptonicaSharp._All.lstackAdd(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackAdd",TestPix, RESlstackAdd,{"Dim RESlstackAdd as Integer = LeptonicaSharp._All.lstackAdd(TestPix ,TestPix )"},1)

' Dim RESlstackRemove as Object = LeptonicaSharp._All.lstackRemove(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackRemove",TestPix, RESlstackRemove,{"Dim RESlstackRemove as Object = LeptonicaSharp._All.lstackRemove(TestPix )"},1)

' Dim RESlstackGetCount as Integer = LeptonicaSharp._All.lstackGetCount(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackGetCount",TestPix, RESlstackGetCount,{"Dim RESlstackGetCount as Integer = LeptonicaSharp._All.lstackGetCount(TestPix )"},1)

' Dim RESlstackPrint as Integer = LeptonicaSharp._All.lstackPrint(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lstackPrint",TestPix, RESlstackPrint,{"Dim RESlstackPrint as Integer = LeptonicaSharp._All.lstackPrint(TestPix ,TestPix )"},1)

' Dim RESstrcodeCreate as L_StrCode = LeptonicaSharp._All.strcodeCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("strcodeCreate",TestPix, RESstrcodeCreate,{"Dim RESstrcodeCreate as L_StrCode = LeptonicaSharp._All.strcodeCreate(TestPix )"},1)

' Dim RESstrcodeCreateFromFile as Integer = LeptonicaSharp._All.strcodeCreateFromFile(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("strcodeCreateFromFile",TestPix, RESstrcodeCreateFromFile,{"Dim RESstrcodeCreateFromFile as Integer = LeptonicaSharp._All.strcodeCreateFromFile(TestPix ,TestPix ,Nothing )"},1)

' Dim RESstrcodeGenerate as Integer = LeptonicaSharp._All.strcodeGenerate(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("strcodeGenerate",TestPix, RESstrcodeGenerate,{"Dim RESstrcodeGenerate as Integer = LeptonicaSharp._All.strcodeGenerate(TestPix ,TestPix ,TestPix )"},1)

' Dim RESstrcodeFinalize as Integer = LeptonicaSharp._All.strcodeFinalize(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("strcodeFinalize",TestPix, RESstrcodeFinalize,{"Dim RESstrcodeFinalize as Integer = LeptonicaSharp._All.strcodeFinalize(TestPix ,Nothing )"},1)

' Dim RESl_getStructStrFromFile as Integer = LeptonicaSharp._All.l_getStructStrFromFile(TestPix ,TestPix ,New String())
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getStructStrFromFile",TestPix, RESl_getStructStrFromFile,{"Dim RESl_getStructStrFromFile as Integer = LeptonicaSharp._All.l_getStructStrFromFile(TestPix ,TestPix ,New String())"},1)

' Dim RESpixFindStrokeLength as Integer = LeptonicaSharp._All.pixFindStrokeLength(TestPix ,Nothing ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindStrokeLength",TestPix, RESpixFindStrokeLength,{"Dim RESpixFindStrokeLength as Integer = LeptonicaSharp._All.pixFindStrokeLength(TestPix ,Nothing ,New Integer)"},1)

' Dim RESpixFindStrokeWidth as Integer = LeptonicaSharp._All.pixFindStrokeWidth(TestPix ,TestPix ,Nothing ,New Single,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixFindStrokeWidth",TestPix, RESpixFindStrokeWidth,{"Dim RESpixFindStrokeWidth as Integer = LeptonicaSharp._All.pixFindStrokeWidth(TestPix ,TestPix ,Nothing ,New Single,Nothing )"},1)

' Dim RESpixaFindStrokeWidth as Numa = LeptonicaSharp._All.pixaFindStrokeWidth(TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaFindStrokeWidth",TestPix, RESpixaFindStrokeWidth,{"Dim RESpixaFindStrokeWidth as Numa = LeptonicaSharp._All.pixaFindStrokeWidth(TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaModifyStrokeWidth as Pixa = LeptonicaSharp._All.pixaModifyStrokeWidth(TestPix ,New Single)
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaModifyStrokeWidth",TestPix, RESpixaModifyStrokeWidth,{"Dim RESpixaModifyStrokeWidth as Pixa = LeptonicaSharp._All.pixaModifyStrokeWidth(TestPix ,New Single)"},1)

' Dim RESpixModifyStrokeWidth as Pix = LeptonicaSharp._All.pixModifyStrokeWidth(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixModifyStrokeWidth",TestPix, RESpixModifyStrokeWidth,{"Dim RESpixModifyStrokeWidth as Pix = LeptonicaSharp._All.pixModifyStrokeWidth(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaSetStrokeWidth as Pixa = LeptonicaSharp._All.pixaSetStrokeWidth(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaSetStrokeWidth",TestPix, RESpixaSetStrokeWidth,{"Dim RESpixaSetStrokeWidth as Pixa = LeptonicaSharp._All.pixaSetStrokeWidth(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSetStrokeWidth as Pix = LeptonicaSharp._All.pixSetStrokeWidth(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetStrokeWidth",TestPix, RESpixSetStrokeWidth,{"Dim RESpixSetStrokeWidth as Pix = LeptonicaSharp._All.pixSetStrokeWidth(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsudokuReadFile as Integer() = LeptonicaSharp._All.sudokuReadFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuReadFile",TestPix, RESsudokuReadFile,{"Dim RESsudokuReadFile as Integer() = LeptonicaSharp._All.sudokuReadFile(TestPix )"},1)

' Dim RESsudokuReadString as Integer() = LeptonicaSharp._All.sudokuReadString(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuReadString",TestPix, RESsudokuReadString,{"Dim RESsudokuReadString as Integer() = LeptonicaSharp._All.sudokuReadString(TestPix )"},1)

' Dim RESsudokuCreate as L_Sudoku = LeptonicaSharp._All.sudokuCreate(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuCreate",TestPix, RESsudokuCreate,{"Dim RESsudokuCreate as L_Sudoku = LeptonicaSharp._All.sudokuCreate(TestPix )"},1)

' Dim RESsudokuDestroy as Object = LeptonicaSharp._All.sudokuDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuDestroy",TestPix, RESsudokuDestroy,{"Dim RESsudokuDestroy as Object = LeptonicaSharp._All.sudokuDestroy(TestPix )"},1)

' Dim RESsudokuSolve as Integer = LeptonicaSharp._All.sudokuSolve(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuSolve",TestPix, RESsudokuSolve,{"Dim RESsudokuSolve as Integer = LeptonicaSharp._All.sudokuSolve(TestPix )"},1)

' Dim RESsudokuTestUniqueness as Integer = LeptonicaSharp._All.sudokuTestUniqueness(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuTestUniqueness",TestPix, RESsudokuTestUniqueness,{"Dim RESsudokuTestUniqueness as Integer = LeptonicaSharp._All.sudokuTestUniqueness(TestPix ,New Integer)"},1)

' Dim RESsudokuGenerate as L_Sudoku = LeptonicaSharp._All.sudokuGenerate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuGenerate",TestPix, RESsudokuGenerate,{"Dim RESsudokuGenerate as L_Sudoku = LeptonicaSharp._All.sudokuGenerate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESsudokuOutput as Integer = LeptonicaSharp._All.sudokuOutput(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("sudokuOutput",TestPix, RESsudokuOutput,{"Dim RESsudokuOutput as Integer = LeptonicaSharp._All.sudokuOutput(TestPix ,TestPix )"},1)

' Dim RESpixAddSingleTextblock as Pix = LeptonicaSharp._All.pixAddSingleTextblock(TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddSingleTextblock",TestPix, RESpixAddSingleTextblock,{"Dim RESpixAddSingleTextblock as Pix = LeptonicaSharp._All.pixAddSingleTextblock(TestPix ,TestPix ,Nothing ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixAddTextlines as Pix = LeptonicaSharp._All.pixAddTextlines(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixAddTextlines",TestPix, RESpixAddTextlines,{"Dim RESpixAddTextlines as Pix = LeptonicaSharp._All.pixAddTextlines(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixSetTextblock as Integer = LeptonicaSharp._All.pixSetTextblock(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetTextblock",TestPix, RESpixSetTextblock,{"Dim RESpixSetTextblock as Integer = LeptonicaSharp._All.pixSetTextblock(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESpixSetTextline as Integer = LeptonicaSharp._All.pixSetTextline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSetTextline",TestPix, RESpixSetTextline,{"Dim RESpixSetTextline as Integer = LeptonicaSharp._All.pixSetTextline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESpixaAddTextNumber as Pixa = LeptonicaSharp._All.pixaAddTextNumber(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddTextNumber",TestPix, RESpixaAddTextNumber,{"Dim RESpixaAddTextNumber as Pixa = LeptonicaSharp._All.pixaAddTextNumber(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaAddTextlines as Pixa = LeptonicaSharp._All.pixaAddTextlines(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddTextlines",TestPix, RESpixaAddTextlines,{"Dim RESpixaAddTextlines as Pixa = LeptonicaSharp._All.pixaAddTextlines(TestPix ,TestPix ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESpixaAddPixWithText as Integer = LeptonicaSharp._All.pixaAddPixWithText(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaAddPixWithText",TestPix, RESpixaAddPixWithText,{"Dim RESpixaAddPixWithText as Integer = LeptonicaSharp._All.pixaAddPixWithText(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESbmfGetLineStrings as Sarray = LeptonicaSharp._All.bmfGetLineStrings(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetLineStrings",TestPix, RESbmfGetLineStrings,{"Dim RESbmfGetLineStrings as Sarray = LeptonicaSharp._All.bmfGetLineStrings(TestPix ,TestPix ,TestPix ,TestPix ,New Integer)"},1)

' Dim RESbmfGetWordWidths as Numa = LeptonicaSharp._All.bmfGetWordWidths(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetWordWidths",TestPix, RESbmfGetWordWidths,{"Dim RESbmfGetWordWidths as Numa = LeptonicaSharp._All.bmfGetWordWidths(TestPix ,TestPix ,TestPix )"},1)

' Dim RESbmfGetStringWidth as Integer = LeptonicaSharp._All.bmfGetStringWidth(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("bmfGetStringWidth",TestPix, RESbmfGetStringWidth,{"Dim RESbmfGetStringWidth as Integer = LeptonicaSharp._All.bmfGetStringWidth(TestPix ,TestPix ,New Integer)"},1)

' Dim RESsplitStringToParagraphs as Sarray = LeptonicaSharp._All.splitStringToParagraphs(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("splitStringToParagraphs",TestPix, RESsplitStringToParagraphs,{"Dim RESsplitStringToParagraphs as Sarray = LeptonicaSharp._All.splitStringToParagraphs(TestPix ,TestPix )"},1)

' Dim RESpixReadTiff as Pix = LeptonicaSharp._All.pixReadTiff(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadTiff",TestPix, RESpixReadTiff,{"Dim RESpixReadTiff as Pix = LeptonicaSharp._All.pixReadTiff(TestPix ,TestPix )"},1)

' Dim RESpixReadStreamTiff as Pix = LeptonicaSharp._All.pixReadStreamTiff(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamTiff",TestPix, RESpixReadStreamTiff,{"Dim RESpixReadStreamTiff as Pix = LeptonicaSharp._All.pixReadStreamTiff(TestPix ,TestPix )"},1)

' Dim RESpixWriteTiff as Integer = LeptonicaSharp._All.pixWriteTiff(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteTiff",TestPix, RESpixWriteTiff,{"Dim RESpixWriteTiff as Integer = LeptonicaSharp._All.pixWriteTiff(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteTiffCustom as Integer = LeptonicaSharp._All.pixWriteTiffCustom(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteTiffCustom",TestPix, RESpixWriteTiffCustom,{"Dim RESpixWriteTiffCustom as Integer = LeptonicaSharp._All.pixWriteTiffCustom(TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixWriteStreamTiff as Integer = LeptonicaSharp._All.pixWriteStreamTiff(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamTiff",TestPix, RESpixWriteStreamTiff,{"Dim RESpixWriteStreamTiff as Integer = LeptonicaSharp._All.pixWriteStreamTiff(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamTiffWA as Integer = LeptonicaSharp._All.pixWriteStreamTiffWA(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamTiffWA",TestPix, RESpixWriteStreamTiffWA,{"Dim RESpixWriteStreamTiffWA as Integer = LeptonicaSharp._All.pixWriteStreamTiffWA(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadFromMultipageTiff as Pix = LeptonicaSharp._All.pixReadFromMultipageTiff(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadFromMultipageTiff",TestPix, RESpixReadFromMultipageTiff,{"Dim RESpixReadFromMultipageTiff as Pix = LeptonicaSharp._All.pixReadFromMultipageTiff(TestPix ,TestPix )"},1)

' Dim RESpixaReadMultipageTiff as Pixa = LeptonicaSharp._All.pixaReadMultipageTiff(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadMultipageTiff",TestPix, RESpixaReadMultipageTiff,{"Dim RESpixaReadMultipageTiff as Pixa = LeptonicaSharp._All.pixaReadMultipageTiff(TestPix )"},1)

' Dim RESpixaWriteMultipageTiff as Integer = LeptonicaSharp._All.pixaWriteMultipageTiff(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteMultipageTiff",TestPix, RESpixaWriteMultipageTiff,{"Dim RESpixaWriteMultipageTiff as Integer = LeptonicaSharp._All.pixaWriteMultipageTiff(TestPix ,TestPix )"},1)

' Dim RESwriteMultipageTiff as Integer = LeptonicaSharp._All.writeMultipageTiff(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("writeMultipageTiff",TestPix, RESwriteMultipageTiff,{"Dim RESwriteMultipageTiff as Integer = LeptonicaSharp._All.writeMultipageTiff(TestPix ,Nothing ,TestPix )"},1)

' Dim RESwriteMultipageTiffSA as Integer = LeptonicaSharp._All.writeMultipageTiffSA(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("writeMultipageTiffSA",TestPix, RESwriteMultipageTiffSA,{"Dim RESwriteMultipageTiffSA as Integer = LeptonicaSharp._All.writeMultipageTiffSA(TestPix ,TestPix )"},1)

' Dim RESfprintTiffInfo as Integer = LeptonicaSharp._All.fprintTiffInfo(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fprintTiffInfo",TestPix, RESfprintTiffInfo,{"Dim RESfprintTiffInfo as Integer = LeptonicaSharp._All.fprintTiffInfo(TestPix ,TestPix )"},1)

' Dim REStiffGetCount as Integer = LeptonicaSharp._All.tiffGetCount(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("tiffGetCount",TestPix, REStiffGetCount,{"Dim REStiffGetCount as Integer = LeptonicaSharp._All.tiffGetCount(TestPix ,New Integer)"},1)

' Dim RESgetTiffResolution as Integer = LeptonicaSharp._All.getTiffResolution(TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("getTiffResolution",TestPix, RESgetTiffResolution,{"Dim RESgetTiffResolution as Integer = LeptonicaSharp._All.getTiffResolution(TestPix ,New Integer,New Integer)"},1)

' Dim RESreadHeaderTiff as Integer = LeptonicaSharp._All.readHeaderTiff(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderTiff",TestPix, RESreadHeaderTiff,{"Dim RESreadHeaderTiff as Integer = LeptonicaSharp._All.readHeaderTiff(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfreadHeaderTiff as Integer = LeptonicaSharp._All.freadHeaderTiff(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("freadHeaderTiff",TestPix, RESfreadHeaderTiff,{"Dim RESfreadHeaderTiff as Integer = LeptonicaSharp._All.freadHeaderTiff(TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESreadHeaderMemTiff as Integer = LeptonicaSharp._All.readHeaderMemTiff(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemTiff",TestPix, RESreadHeaderMemTiff,{"Dim RESreadHeaderMemTiff as Integer = LeptonicaSharp._All.readHeaderMemTiff(TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESfindTiffCompression as Integer = LeptonicaSharp._All.findTiffCompression(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("findTiffCompression",TestPix, RESfindTiffCompression,{"Dim RESfindTiffCompression as Integer = LeptonicaSharp._All.findTiffCompression(TestPix ,New Integer)"},1)

' Dim RESextractG4DataFromFile as Integer = LeptonicaSharp._All.extractG4DataFromFile(TestPix ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("extractG4DataFromFile",TestPix, RESextractG4DataFromFile,{"Dim RESextractG4DataFromFile as Integer = LeptonicaSharp._All.extractG4DataFromFile(TestPix ,New Byte(),New UInteger,Nothing ,Nothing ,Nothing )"},1)

' Dim RESpixReadMemTiff as Pix = LeptonicaSharp._All.pixReadMemTiff(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemTiff",TestPix, RESpixReadMemTiff,{"Dim RESpixReadMemTiff as Pix = LeptonicaSharp._All.pixReadMemTiff(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixReadMemFromMultipageTiff as Pix = LeptonicaSharp._All.pixReadMemFromMultipageTiff(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemFromMultipageTiff",TestPix, RESpixReadMemFromMultipageTiff,{"Dim RESpixReadMemFromMultipageTiff as Pix = LeptonicaSharp._All.pixReadMemFromMultipageTiff(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixaReadMemMultipageTiff as Pixa = LeptonicaSharp._All.pixaReadMemMultipageTiff(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaReadMemMultipageTiff",TestPix, RESpixaReadMemMultipageTiff,{"Dim RESpixaReadMemMultipageTiff as Pixa = LeptonicaSharp._All.pixaReadMemMultipageTiff(TestPix ,TestPix )"},1)

' Dim RESpixaWriteMemMultipageTiff as Integer = LeptonicaSharp._All.pixaWriteMemMultipageTiff(New Byte(),New UInteger,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteMemMultipageTiff",TestPix, RESpixaWriteMemMultipageTiff,{"Dim RESpixaWriteMemMultipageTiff as Integer = LeptonicaSharp._All.pixaWriteMemMultipageTiff(New Byte(),New UInteger,TestPix )"},1)

' Dim RESpixWriteMemTiff as Integer = LeptonicaSharp._All.pixWriteMemTiff(New Byte(),New UInteger,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemTiff",TestPix, RESpixWriteMemTiff,{"Dim RESpixWriteMemTiff as Integer = LeptonicaSharp._All.pixWriteMemTiff(New Byte(),New UInteger,TestPix ,TestPix )"},1)

' Dim RESpixWriteMemTiffCustom as Integer = LeptonicaSharp._All.pixWriteMemTiffCustom(New Byte(),New UInteger,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemTiffCustom",TestPix, RESpixWriteMemTiffCustom,{"Dim RESpixWriteMemTiffCustom as Integer = LeptonicaSharp._All.pixWriteMemTiffCustom(New Byte(),New UInteger,TestPix ,TestPix ,Nothing ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESsetMsgSeverity as Integer = LeptonicaSharp._All.setMsgSeverity(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("setMsgSeverity",TestPix, RESsetMsgSeverity,{"Dim RESsetMsgSeverity as Integer = LeptonicaSharp._All.setMsgSeverity(TestPix )"},1)

' Dim RESreturnErrorInt as Integer = LeptonicaSharp._All.returnErrorInt(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("returnErrorInt",TestPix, RESreturnErrorInt,{"Dim RESreturnErrorInt as Integer = LeptonicaSharp._All.returnErrorInt(TestPix ,TestPix ,TestPix )"},1)

' Dim RESreturnErrorFloat as Single = LeptonicaSharp._All.returnErrorFloat(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("returnErrorFloat",TestPix, RESreturnErrorFloat,{"Dim RESreturnErrorFloat as Single = LeptonicaSharp._All.returnErrorFloat(TestPix ,TestPix ,TestPix )"},1)

' Dim RESreturnErrorPtr as Object = LeptonicaSharp._All.returnErrorPtr(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("returnErrorPtr",TestPix, RESreturnErrorPtr,{"Dim RESreturnErrorPtr as Object = LeptonicaSharp._All.returnErrorPtr(TestPix ,TestPix ,TestPix )"},1)

' Dim RESfilesAreIdentical as Integer = LeptonicaSharp._All.filesAreIdentical(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("filesAreIdentical",TestPix, RESfilesAreIdentical,{"Dim RESfilesAreIdentical as Integer = LeptonicaSharp._All.filesAreIdentical(TestPix ,TestPix ,New Integer)"},1)

' Dim RESconvertOnLittleEnd16 as UShort = LeptonicaSharp._All.convertOnLittleEnd16(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertOnLittleEnd16",TestPix, RESconvertOnLittleEnd16,{"Dim RESconvertOnLittleEnd16 as UShort = LeptonicaSharp._All.convertOnLittleEnd16(TestPix )"},1)

' Dim RESconvertOnBigEnd16 as UShort = LeptonicaSharp._All.convertOnBigEnd16(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertOnBigEnd16",TestPix, RESconvertOnBigEnd16,{"Dim RESconvertOnBigEnd16 as UShort = LeptonicaSharp._All.convertOnBigEnd16(TestPix )"},1)

' Dim RESconvertOnLittleEnd32 as UInteger = LeptonicaSharp._All.convertOnLittleEnd32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertOnLittleEnd32",TestPix, RESconvertOnLittleEnd32,{"Dim RESconvertOnLittleEnd32 as UInteger = LeptonicaSharp._All.convertOnLittleEnd32(TestPix )"},1)

' Dim RESconvertOnBigEnd32 as UInteger = LeptonicaSharp._All.convertOnBigEnd32(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertOnBigEnd32",TestPix, RESconvertOnBigEnd32,{"Dim RESconvertOnBigEnd32 as UInteger = LeptonicaSharp._All.convertOnBigEnd32(TestPix )"},1)

' Dim RESfileCorruptByDeletion as Integer = LeptonicaSharp._All.fileCorruptByDeletion(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileCorruptByDeletion",TestPix, RESfileCorruptByDeletion,{"Dim RESfileCorruptByDeletion as Integer = LeptonicaSharp._All.fileCorruptByDeletion(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESfileCorruptByMutation as Integer = LeptonicaSharp._All.fileCorruptByMutation(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileCorruptByMutation",TestPix, RESfileCorruptByMutation,{"Dim RESfileCorruptByMutation as Integer = LeptonicaSharp._All.fileCorruptByMutation(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESgenRandomIntegerInRange as Integer = LeptonicaSharp._All.genRandomIntegerInRange(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("genRandomIntegerInRange",TestPix, RESgenRandomIntegerInRange,{"Dim RESgenRandomIntegerInRange as Integer = LeptonicaSharp._All.genRandomIntegerInRange(TestPix ,TestPix ,New Integer)"},1)

' Dim RESlept_roundftoi as Integer = LeptonicaSharp._All.lept_roundftoi(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_roundftoi",TestPix, RESlept_roundftoi,{"Dim RESlept_roundftoi as Integer = LeptonicaSharp._All.lept_roundftoi(TestPix )"},1)

' Dim RESl_hashStringToUint64 as Integer = LeptonicaSharp._All.l_hashStringToUint64(TestPix ,New ULong)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_hashStringToUint64",TestPix, RESl_hashStringToUint64,{"Dim RESl_hashStringToUint64 as Integer = LeptonicaSharp._All.l_hashStringToUint64(TestPix ,New ULong)"},1)

' Dim RESl_hashPtToUint64 as Integer = LeptonicaSharp._All.l_hashPtToUint64(TestPix ,TestPix ,New ULong)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_hashPtToUint64",TestPix, RESl_hashPtToUint64,{"Dim RESl_hashPtToUint64 as Integer = LeptonicaSharp._All.l_hashPtToUint64(TestPix ,TestPix ,New ULong)"},1)

' Dim RESl_hashFloat64ToUint64 as Integer = LeptonicaSharp._All.l_hashFloat64ToUint64(TestPix ,TestPix ,New ULong)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_hashFloat64ToUint64",TestPix, RESl_hashFloat64ToUint64,{"Dim RESl_hashFloat64ToUint64 as Integer = LeptonicaSharp._All.l_hashFloat64ToUint64(TestPix ,TestPix ,New ULong)"},1)

' Dim RESfindNextLargerPrime as Integer = LeptonicaSharp._All.findNextLargerPrime(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("findNextLargerPrime",TestPix, RESfindNextLargerPrime,{"Dim RESfindNextLargerPrime as Integer = LeptonicaSharp._All.findNextLargerPrime(TestPix ,New UInteger)"},1)

' Dim RESlept_isPrime as Integer = LeptonicaSharp._All.lept_isPrime(TestPix ,New Integer,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_isPrime",TestPix, RESlept_isPrime,{"Dim RESlept_isPrime as Integer = LeptonicaSharp._All.lept_isPrime(TestPix ,New Integer,Nothing )"},1)

' Dim RESconvertIntToGrayCode as UInteger = LeptonicaSharp._All.convertIntToGrayCode(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertIntToGrayCode",TestPix, RESconvertIntToGrayCode,{"Dim RESconvertIntToGrayCode as UInteger = LeptonicaSharp._All.convertIntToGrayCode(TestPix )"},1)

' Dim RESconvertGrayCodeToInt as UInteger = LeptonicaSharp._All.convertGrayCodeToInt(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertGrayCodeToInt",TestPix, RESconvertGrayCodeToInt,{"Dim RESconvertGrayCodeToInt as UInteger = LeptonicaSharp._All.convertGrayCodeToInt(TestPix )"},1)

' Dim RESgetLeptonicaVersion as String = LeptonicaSharp._All.getLeptonicaVersion()
' LeptonicaSharp.Convert.WriteHelpExtension ("getLeptonicaVersion",TestPix, RESgetLeptonicaVersion,{"Dim RESgetLeptonicaVersion as String = LeptonicaSharp._All.getLeptonicaVersion()"},1)

' Dim RESstartTimer as Object = LeptonicaSharp._All.startTimer()
' LeptonicaSharp.Convert.WriteHelpExtension ("startTimer",TestPix, RESstartTimer,{"Dim RESstartTimer as Object = LeptonicaSharp._All.startTimer()"},1)

' Dim RESstopTimer as Single = LeptonicaSharp._All.stopTimer()
' LeptonicaSharp.Convert.WriteHelpExtension ("stopTimer",TestPix, RESstopTimer,{"Dim RESstopTimer as Single = LeptonicaSharp._All.stopTimer()"},1)

' Dim RESstartTimerNested as IntPtr = LeptonicaSharp._All.startTimerNested()
' LeptonicaSharp.Convert.WriteHelpExtension ("startTimerNested",TestPix, RESstartTimerNested,{"Dim RESstartTimerNested as IntPtr = LeptonicaSharp._All.startTimerNested()"},1)

' Dim RESstopTimerNested as Single = LeptonicaSharp._All.stopTimerNested(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stopTimerNested",TestPix, RESstopTimerNested,{"Dim RESstopTimerNested as Single = LeptonicaSharp._All.stopTimerNested(TestPix )"},1)

' Dim RESl_getCurrentTime as Object = LeptonicaSharp._All.l_getCurrentTime(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getCurrentTime",TestPix, RESl_getCurrentTime,{"Dim RESl_getCurrentTime as Object = LeptonicaSharp._All.l_getCurrentTime(TestPix ,TestPix )"},1)

' Dim RESstartWallTimer as L_WallTimer = LeptonicaSharp._All.startWallTimer()
' LeptonicaSharp.Convert.WriteHelpExtension ("startWallTimer",TestPix, RESstartWallTimer,{"Dim RESstartWallTimer as L_WallTimer = LeptonicaSharp._All.startWallTimer()"},1)

' Dim RESstopWallTimer as Single = LeptonicaSharp._All.stopWallTimer(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stopWallTimer",TestPix, RESstopWallTimer,{"Dim RESstopWallTimer as Single = LeptonicaSharp._All.stopWallTimer(TestPix )"},1)

' Dim RESl_getFormattedDate as String = LeptonicaSharp._All.l_getFormattedDate()
' LeptonicaSharp.Convert.WriteHelpExtension ("l_getFormattedDate",TestPix, RESl_getFormattedDate,{"Dim RESl_getFormattedDate as String = LeptonicaSharp._All.l_getFormattedDate()"},1)

' Dim RESstringNew as String = LeptonicaSharp._All.stringNew(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringNew",TestPix, RESstringNew,{"Dim RESstringNew as String = LeptonicaSharp._All.stringNew(TestPix )"},1)

' Dim RESstringCopy as Integer = LeptonicaSharp._All.stringCopy(TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringCopy",TestPix, RESstringCopy,{"Dim RESstringCopy as Integer = LeptonicaSharp._All.stringCopy(TestPix ,Nothing ,TestPix )"},1)

' Dim RESstringReplace as Integer = LeptonicaSharp._All.stringReplace(New String(),Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringReplace",TestPix, RESstringReplace,{"Dim RESstringReplace as Integer = LeptonicaSharp._All.stringReplace(New String(),Nothing )"},1)

' Dim RESstringLength as Integer = LeptonicaSharp._All.stringLength(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringLength",TestPix, RESstringLength,{"Dim RESstringLength as Integer = LeptonicaSharp._All.stringLength(TestPix ,TestPix )"},1)

' Dim RESstringCat as Integer = LeptonicaSharp._All.stringCat(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringCat",TestPix, RESstringCat,{"Dim RESstringCat as Integer = LeptonicaSharp._All.stringCat(TestPix ,TestPix ,TestPix )"},1)

' Dim RESstringConcatNew as String = LeptonicaSharp._All.stringConcatNew(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringConcatNew",TestPix, RESstringConcatNew,{"Dim RESstringConcatNew as String = LeptonicaSharp._All.stringConcatNew(TestPix )"},1)

' Dim RESstringJoin as String = LeptonicaSharp._All.stringJoin(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringJoin",TestPix, RESstringJoin,{"Dim RESstringJoin as String = LeptonicaSharp._All.stringJoin(Nothing ,Nothing )"},1)

' Dim RESstringJoinIP as Integer = LeptonicaSharp._All.stringJoinIP(TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringJoinIP",TestPix, RESstringJoinIP,{"Dim RESstringJoinIP as Integer = LeptonicaSharp._All.stringJoinIP(TestPix ,Nothing )"},1)

' Dim RESstringReverse as String = LeptonicaSharp._All.stringReverse(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringReverse",TestPix, RESstringReverse,{"Dim RESstringReverse as String = LeptonicaSharp._All.stringReverse(TestPix )"},1)

' Dim RESstrtokSafe as String = LeptonicaSharp._All.strtokSafe(TestPix ,TestPix ,New String())
' LeptonicaSharp.Convert.WriteHelpExtension ("strtokSafe",TestPix, RESstrtokSafe,{"Dim RESstrtokSafe as String = LeptonicaSharp._All.strtokSafe(TestPix ,TestPix ,New String())"},1)

' Dim RESstringSplitOnToken as Integer = LeptonicaSharp._All.stringSplitOnToken(TestPix ,TestPix ,New String(),New String())
' LeptonicaSharp.Convert.WriteHelpExtension ("stringSplitOnToken",TestPix, RESstringSplitOnToken,{"Dim RESstringSplitOnToken as Integer = LeptonicaSharp._All.stringSplitOnToken(TestPix ,TestPix ,New String(),New String())"},1)

' Dim RESstringCheckForChars as Integer = LeptonicaSharp._All.stringCheckForChars(TestPix ,TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("stringCheckForChars",TestPix, RESstringCheckForChars,{"Dim RESstringCheckForChars as Integer = LeptonicaSharp._All.stringCheckForChars(TestPix ,TestPix ,New Integer)"},1)

' Dim RESstringRemoveChars as String = LeptonicaSharp._All.stringRemoveChars(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringRemoveChars",TestPix, RESstringRemoveChars,{"Dim RESstringRemoveChars as String = LeptonicaSharp._All.stringRemoveChars(TestPix ,TestPix )"},1)

' Dim RESstringFindSubstr as Integer = LeptonicaSharp._All.stringFindSubstr(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringFindSubstr",TestPix, RESstringFindSubstr,{"Dim RESstringFindSubstr as Integer = LeptonicaSharp._All.stringFindSubstr(TestPix ,TestPix ,Nothing )"},1)

' Dim RESstringReplaceSubstr as String = LeptonicaSharp._All.stringReplaceSubstr(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringReplaceSubstr",TestPix, RESstringReplaceSubstr,{"Dim RESstringReplaceSubstr as String = LeptonicaSharp._All.stringReplaceSubstr(TestPix ,TestPix ,TestPix ,Nothing ,Nothing )"},1)

' Dim RESstringReplaceEachSubstr as String = LeptonicaSharp._All.stringReplaceEachSubstr(TestPix ,TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("stringReplaceEachSubstr",TestPix, RESstringReplaceEachSubstr,{"Dim RESstringReplaceEachSubstr as String = LeptonicaSharp._All.stringReplaceEachSubstr(TestPix ,TestPix ,TestPix ,Nothing )"},1)

' Dim RESarrayFindEachSequence as L_Dna = LeptonicaSharp._All.arrayFindEachSequence(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("arrayFindEachSequence",TestPix, RESarrayFindEachSequence,{"Dim RESarrayFindEachSequence as L_Dna = LeptonicaSharp._All.arrayFindEachSequence(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESarrayFindSequence as Integer = LeptonicaSharp._All.arrayFindSequence(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("arrayFindSequence",TestPix, RESarrayFindSequence,{"Dim RESarrayFindSequence as Integer = LeptonicaSharp._All.arrayFindSequence(TestPix ,TestPix ,TestPix ,TestPix ,New Integer,New Integer)"},1)

' Dim RESreallocNew as Object = LeptonicaSharp._All.reallocNew(Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("reallocNew",TestPix, RESreallocNew,{"Dim RESreallocNew as Object = LeptonicaSharp._All.reallocNew(Nothing ,TestPix ,TestPix )"},1)

' Dim RESl_binaryRead as Byte() = LeptonicaSharp._All.l_binaryRead(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryRead",TestPix, RESl_binaryRead,{"Dim RESl_binaryRead as Byte() = LeptonicaSharp._All.l_binaryRead(TestPix ,New UInteger)"},1)

' Dim RESl_binaryReadStream as Byte() = LeptonicaSharp._All.l_binaryReadStream(TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryReadStream",TestPix, RESl_binaryReadStream,{"Dim RESl_binaryReadStream as Byte() = LeptonicaSharp._All.l_binaryReadStream(TestPix ,New UInteger)"},1)

' Dim RESl_binaryReadSelect as Byte() = LeptonicaSharp._All.l_binaryReadSelect(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryReadSelect",TestPix, RESl_binaryReadSelect,{"Dim RESl_binaryReadSelect as Byte() = LeptonicaSharp._All.l_binaryReadSelect(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESl_binaryReadSelectStream as Byte() = LeptonicaSharp._All.l_binaryReadSelectStream(TestPix ,TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryReadSelectStream",TestPix, RESl_binaryReadSelectStream,{"Dim RESl_binaryReadSelectStream as Byte() = LeptonicaSharp._All.l_binaryReadSelectStream(TestPix ,TestPix ,TestPix ,New UInteger)"},1)

' Dim RESl_binaryWrite as Integer = LeptonicaSharp._All.l_binaryWrite(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryWrite",TestPix, RESl_binaryWrite,{"Dim RESl_binaryWrite as Integer = LeptonicaSharp._All.l_binaryWrite(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESnbytesInFile as UInteger = LeptonicaSharp._All.nbytesInFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("nbytesInFile",TestPix, RESnbytesInFile,{"Dim RESnbytesInFile as UInteger = LeptonicaSharp._All.nbytesInFile(TestPix )"},1)

' Dim RESfnbytesInFile as UInteger = LeptonicaSharp._All.fnbytesInFile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fnbytesInFile",TestPix, RESfnbytesInFile,{"Dim RESfnbytesInFile as UInteger = LeptonicaSharp._All.fnbytesInFile(TestPix )"},1)

' Dim RESl_binaryCopy as Byte() = LeptonicaSharp._All.l_binaryCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_binaryCopy",TestPix, RESl_binaryCopy,{"Dim RESl_binaryCopy as Byte() = LeptonicaSharp._All.l_binaryCopy(TestPix ,TestPix )"},1)

' Dim RESfileCopy as Integer = LeptonicaSharp._All.fileCopy(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileCopy",TestPix, RESfileCopy,{"Dim RESfileCopy as Integer = LeptonicaSharp._All.fileCopy(TestPix ,TestPix )"},1)

' Dim RESfileConcatenate as Integer = LeptonicaSharp._All.fileConcatenate(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileConcatenate",TestPix, RESfileConcatenate,{"Dim RESfileConcatenate as Integer = LeptonicaSharp._All.fileConcatenate(TestPix ,TestPix )"},1)

' Dim RESfileAppendString as Integer = LeptonicaSharp._All.fileAppendString(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fileAppendString",TestPix, RESfileAppendString,{"Dim RESfileAppendString as Integer = LeptonicaSharp._All.fileAppendString(TestPix ,TestPix )"},1)

' Dim RESfopenReadStream as FILE = LeptonicaSharp._All.fopenReadStream(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fopenReadStream",TestPix, RESfopenReadStream,{"Dim RESfopenReadStream as FILE = LeptonicaSharp._All.fopenReadStream(TestPix )"},1)

' Dim RESfopenWriteStream as FILE = LeptonicaSharp._All.fopenWriteStream(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fopenWriteStream",TestPix, RESfopenWriteStream,{"Dim RESfopenWriteStream as FILE = LeptonicaSharp._All.fopenWriteStream(TestPix ,TestPix )"},1)

' Dim RESfopenReadFromMemory as FILE = LeptonicaSharp._All.fopenReadFromMemory(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("fopenReadFromMemory",TestPix, RESfopenReadFromMemory,{"Dim RESfopenReadFromMemory as FILE = LeptonicaSharp._All.fopenReadFromMemory(TestPix ,TestPix )"},1)

' Dim RESfopenWriteWinTempfile as FILE = LeptonicaSharp._All.fopenWriteWinTempfile()
' LeptonicaSharp.Convert.WriteHelpExtension ("fopenWriteWinTempfile",TestPix, RESfopenWriteWinTempfile,{"Dim RESfopenWriteWinTempfile as FILE = LeptonicaSharp._All.fopenWriteWinTempfile()"},1)

' Dim RESlept_fopen as FILE = LeptonicaSharp._All.lept_fopen(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_fopen",TestPix, RESlept_fopen,{"Dim RESlept_fopen as FILE = LeptonicaSharp._All.lept_fopen(TestPix ,TestPix )"},1)

' Dim RESlept_fclose as Integer = LeptonicaSharp._All.lept_fclose(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_fclose",TestPix, RESlept_fclose,{"Dim RESlept_fclose as Integer = LeptonicaSharp._All.lept_fclose(TestPix )"},1)

' Dim RESlept_calloc as Object = LeptonicaSharp._All.lept_calloc(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_calloc",TestPix, RESlept_calloc,{"Dim RESlept_calloc as Object = LeptonicaSharp._All.lept_calloc(TestPix ,TestPix )"},1)

' Dim RESlept_free as Object = LeptonicaSharp._All.lept_free(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_free",TestPix, RESlept_free,{"Dim RESlept_free as Object = LeptonicaSharp._All.lept_free(TestPix )"},1)

' Dim RESlept_mkdir as Integer = LeptonicaSharp._All.lept_mkdir(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_mkdir",TestPix, RESlept_mkdir,{"Dim RESlept_mkdir as Integer = LeptonicaSharp._All.lept_mkdir(TestPix )"},1)

' Dim RESlept_rmdir as Integer = LeptonicaSharp._All.lept_rmdir(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_rmdir",TestPix, RESlept_rmdir,{"Dim RESlept_rmdir as Integer = LeptonicaSharp._All.lept_rmdir(TestPix )"},1)

' Dim RESlept_direxists as Object = LeptonicaSharp._All.lept_direxists(TestPix ,New Integer)
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_direxists",TestPix, RESlept_direxists,{"Dim RESlept_direxists as Object = LeptonicaSharp._All.lept_direxists(TestPix ,New Integer)"},1)

' Dim RESlept_rm_match as Integer = LeptonicaSharp._All.lept_rm_match(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_rm_match",TestPix, RESlept_rm_match,{"Dim RESlept_rm_match as Integer = LeptonicaSharp._All.lept_rm_match(Nothing ,Nothing )"},1)

' Dim RESlept_rm as Integer = LeptonicaSharp._All.lept_rm(Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_rm",TestPix, RESlept_rm,{"Dim RESlept_rm as Integer = LeptonicaSharp._All.lept_rm(Nothing ,TestPix )"},1)

' Dim RESlept_rmfile as Integer = LeptonicaSharp._All.lept_rmfile(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_rmfile",TestPix, RESlept_rmfile,{"Dim RESlept_rmfile as Integer = LeptonicaSharp._All.lept_rmfile(TestPix )"},1)

' Dim RESlept_mv as Integer = LeptonicaSharp._All.lept_mv(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_mv",TestPix, RESlept_mv,{"Dim RESlept_mv as Integer = LeptonicaSharp._All.lept_mv(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim RESlept_cp as Integer = LeptonicaSharp._All.lept_cp(TestPix ,Nothing ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("lept_cp",TestPix, RESlept_cp,{"Dim RESlept_cp as Integer = LeptonicaSharp._All.lept_cp(TestPix ,Nothing ,Nothing ,Nothing )"},1)

' Dim REScallSystemDebug as Object = LeptonicaSharp._All.callSystemDebug(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("callSystemDebug",TestPix, REScallSystemDebug,{"Dim REScallSystemDebug as Object = LeptonicaSharp._All.callSystemDebug(TestPix )"},1)

' Dim RESsplitPathAtDirectory as Integer = LeptonicaSharp._All.splitPathAtDirectory(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("splitPathAtDirectory",TestPix, RESsplitPathAtDirectory,{"Dim RESsplitPathAtDirectory as Integer = LeptonicaSharp._All.splitPathAtDirectory(TestPix ,Nothing ,Nothing )"},1)

' Dim RESsplitPathAtExtension as Integer = LeptonicaSharp._All.splitPathAtExtension(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("splitPathAtExtension",TestPix, RESsplitPathAtExtension,{"Dim RESsplitPathAtExtension as Integer = LeptonicaSharp._All.splitPathAtExtension(TestPix ,Nothing ,Nothing )"},1)

' Dim RESpathJoin as String = LeptonicaSharp._All.pathJoin(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("pathJoin",TestPix, RESpathJoin,{"Dim RESpathJoin as String = LeptonicaSharp._All.pathJoin(Nothing ,Nothing )"},1)

' Dim RESappendSubdirs as String = LeptonicaSharp._All.appendSubdirs(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("appendSubdirs",TestPix, RESappendSubdirs,{"Dim RESappendSubdirs as String = LeptonicaSharp._All.appendSubdirs(TestPix ,TestPix )"},1)

' Dim RESconvertSepCharsInPath as Integer = LeptonicaSharp._All.convertSepCharsInPath(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("convertSepCharsInPath",TestPix, RESconvertSepCharsInPath,{"Dim RESconvertSepCharsInPath as Integer = LeptonicaSharp._All.convertSepCharsInPath(TestPix ,TestPix )"},1)

' Dim RESgenPathname as String = LeptonicaSharp._All.genPathname(Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("genPathname",TestPix, RESgenPathname,{"Dim RESgenPathname as String = LeptonicaSharp._All.genPathname(Nothing ,Nothing )"},1)

' Dim RESmakeTempDirname as Integer = LeptonicaSharp._All.makeTempDirname(TestPix ,TestPix ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("makeTempDirname",TestPix, RESmakeTempDirname,{"Dim RESmakeTempDirname as Integer = LeptonicaSharp._All.makeTempDirname(TestPix ,TestPix ,Nothing )"},1)

' Dim RESmodifyTrailingSlash as Integer = LeptonicaSharp._All.modifyTrailingSlash(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("modifyTrailingSlash",TestPix, RESmodifyTrailingSlash,{"Dim RESmodifyTrailingSlash as Integer = LeptonicaSharp._All.modifyTrailingSlash(TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_makeTempFilename as String = LeptonicaSharp._All.l_makeTempFilename()
' LeptonicaSharp.Convert.WriteHelpExtension ("l_makeTempFilename",TestPix, RESl_makeTempFilename,{"Dim RESl_makeTempFilename as String = LeptonicaSharp._All.l_makeTempFilename()"},1)

' Dim RESextractNumberFromFilename as Integer = LeptonicaSharp._All.extractNumberFromFilename(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("extractNumberFromFilename",TestPix, RESextractNumberFromFilename,{"Dim RESextractNumberFromFilename as Integer = LeptonicaSharp._All.extractNumberFromFilename(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSimpleCaptcha as Pix = LeptonicaSharp._All.pixSimpleCaptcha(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSimpleCaptcha",TestPix, RESpixSimpleCaptcha,{"Dim RESpixSimpleCaptcha as Pix = LeptonicaSharp._All.pixSimpleCaptcha(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixRandomHarmonicWarp as Pix = LeptonicaSharp._All.pixRandomHarmonicWarp(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixRandomHarmonicWarp",TestPix, RESpixRandomHarmonicWarp,{"Dim RESpixRandomHarmonicWarp as Pix = LeptonicaSharp._All.pixRandomHarmonicWarp(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWarpStereoscopic as Pix = LeptonicaSharp._All.pixWarpStereoscopic(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWarpStereoscopic",TestPix, RESpixWarpStereoscopic,{"Dim RESpixWarpStereoscopic as Pix = LeptonicaSharp._All.pixWarpStereoscopic(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixStretchHorizontal as Pix = LeptonicaSharp._All.pixStretchHorizontal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixStretchHorizontal",TestPix, RESpixStretchHorizontal,{"Dim RESpixStretchHorizontal as Pix = LeptonicaSharp._All.pixStretchHorizontal(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixStretchHorizontalSampled as Pix = LeptonicaSharp._All.pixStretchHorizontalSampled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixStretchHorizontalSampled",TestPix, RESpixStretchHorizontalSampled,{"Dim RESpixStretchHorizontalSampled as Pix = LeptonicaSharp._All.pixStretchHorizontalSampled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixStretchHorizontalLI as Pix = LeptonicaSharp._All.pixStretchHorizontalLI(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixStretchHorizontalLI",TestPix, RESpixStretchHorizontalLI,{"Dim RESpixStretchHorizontalLI as Pix = LeptonicaSharp._All.pixStretchHorizontalLI(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixQuadraticVShear as Pix = LeptonicaSharp._All.pixQuadraticVShear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuadraticVShear",TestPix, RESpixQuadraticVShear,{"Dim RESpixQuadraticVShear as Pix = LeptonicaSharp._All.pixQuadraticVShear(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixQuadraticVShearSampled as Pix = LeptonicaSharp._All.pixQuadraticVShearSampled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuadraticVShearSampled",TestPix, RESpixQuadraticVShearSampled,{"Dim RESpixQuadraticVShearSampled as Pix = LeptonicaSharp._All.pixQuadraticVShearSampled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixQuadraticVShearLI as Pix = LeptonicaSharp._All.pixQuadraticVShearLI(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixQuadraticVShearLI",TestPix, RESpixQuadraticVShearLI,{"Dim RESpixQuadraticVShearLI as Pix = LeptonicaSharp._All.pixQuadraticVShearLI(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixStereoFromPair as Pix = LeptonicaSharp._All.pixStereoFromPair(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixStereoFromPair",TestPix, RESpixStereoFromPair,{"Dim RESpixStereoFromPair as Pix = LeptonicaSharp._All.pixStereoFromPair(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESwshedCreate as L_WShed = LeptonicaSharp._All.wshedCreate(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedCreate",TestPix, RESwshedCreate,{"Dim RESwshedCreate as L_WShed = LeptonicaSharp._All.wshedCreate(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESwshedDestroy as Object = LeptonicaSharp._All.wshedDestroy(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedDestroy",TestPix, RESwshedDestroy,{"Dim RESwshedDestroy as Object = LeptonicaSharp._All.wshedDestroy(TestPix )"},1)

' Dim RESwshedApply as Integer = LeptonicaSharp._All.wshedApply(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedApply",TestPix, RESwshedApply,{"Dim RESwshedApply as Integer = LeptonicaSharp._All.wshedApply(TestPix )"},1)

' Dim RESwshedBasins as Integer = LeptonicaSharp._All.wshedBasins(TestPix ,Nothing ,Nothing )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedBasins",TestPix, RESwshedBasins,{"Dim RESwshedBasins as Integer = LeptonicaSharp._All.wshedBasins(TestPix ,Nothing ,Nothing )"},1)

' Dim RESwshedRenderFill as Pix = LeptonicaSharp._All.wshedRenderFill(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedRenderFill",TestPix, RESwshedRenderFill,{"Dim RESwshedRenderFill as Pix = LeptonicaSharp._All.wshedRenderFill(TestPix )"},1)

' Dim RESwshedRenderColors as Pix = LeptonicaSharp._All.wshedRenderColors(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("wshedRenderColors",TestPix, RESwshedRenderColors,{"Dim RESwshedRenderColors as Pix = LeptonicaSharp._All.wshedRenderColors(TestPix )"},1)

' Dim RESpixReadStreamWebP as Pix = LeptonicaSharp._All.pixReadStreamWebP(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadStreamWebP",TestPix, RESpixReadStreamWebP,{"Dim RESpixReadStreamWebP as Pix = LeptonicaSharp._All.pixReadStreamWebP(TestPix )"},1)

' Dim RESpixReadMemWebP as Pix = LeptonicaSharp._All.pixReadMemWebP(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixReadMemWebP",TestPix, RESpixReadMemWebP,{"Dim RESpixReadMemWebP as Pix = LeptonicaSharp._All.pixReadMemWebP(TestPix ,TestPix )"},1)

' Dim RESreadHeaderWebP as Integer = LeptonicaSharp._All.readHeaderWebP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderWebP",TestPix, RESreadHeaderWebP,{"Dim RESreadHeaderWebP as Integer = LeptonicaSharp._All.readHeaderWebP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESreadHeaderMemWebP as Integer = LeptonicaSharp._All.readHeaderMemWebP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("readHeaderMemWebP",TestPix, RESreadHeaderMemWebP,{"Dim RESreadHeaderMemWebP as Integer = LeptonicaSharp._All.readHeaderMemWebP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteWebP as Integer = LeptonicaSharp._All.pixWriteWebP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteWebP",TestPix, RESpixWriteWebP,{"Dim RESpixWriteWebP as Integer = LeptonicaSharp._All.pixWriteWebP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteStreamWebP as Integer = LeptonicaSharp._All.pixWriteStreamWebP(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStreamWebP",TestPix, RESpixWriteStreamWebP,{"Dim RESpixWriteStreamWebP as Integer = LeptonicaSharp._All.pixWriteStreamWebP(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteMemWebP as Integer = LeptonicaSharp._All.pixWriteMemWebP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMemWebP",TestPix, RESpixWriteMemWebP,{"Dim RESpixWriteMemWebP as Integer = LeptonicaSharp._All.pixWriteMemWebP(TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESl_jpegSetQuality as Integer = LeptonicaSharp._All.l_jpegSetQuality(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_jpegSetQuality",TestPix, RESl_jpegSetQuality,{"Dim RESl_jpegSetQuality as Integer = LeptonicaSharp._All.l_jpegSetQuality(TestPix )"},1)

' Dim RESsetLeptDebugOK as Object = LeptonicaSharp._All.setLeptDebugOK(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("setLeptDebugOK",TestPix, RESsetLeptDebugOK,{"Dim RESsetLeptDebugOK as Object = LeptonicaSharp._All.setLeptDebugOK(TestPix )"},1)

' Dim RESpixaWriteFiles as Integer = LeptonicaSharp._All.pixaWriteFiles(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixaWriteFiles",TestPix, RESpixaWriteFiles,{"Dim RESpixaWriteFiles as Integer = LeptonicaSharp._All.pixaWriteFiles(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteDebug as Integer = LeptonicaSharp._All.pixWriteDebug(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteDebug",TestPix, RESpixWriteDebug,{"Dim RESpixWriteDebug as Integer = LeptonicaSharp._All.pixWriteDebug(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWrite as Integer = LeptonicaSharp._All.pixWrite(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWrite",TestPix, RESpixWrite,{"Dim RESpixWrite as Integer = LeptonicaSharp._All.pixWrite(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteAutoFormat as Integer = LeptonicaSharp._All.pixWriteAutoFormat(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteAutoFormat",TestPix, RESpixWriteAutoFormat,{"Dim RESpixWriteAutoFormat as Integer = LeptonicaSharp._All.pixWriteAutoFormat(TestPix ,TestPix )"},1)

' Dim RESpixWriteStream as Integer = LeptonicaSharp._All.pixWriteStream(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteStream",TestPix, RESpixWriteStream,{"Dim RESpixWriteStream as Integer = LeptonicaSharp._All.pixWriteStream(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixWriteImpliedFormat as Integer = LeptonicaSharp._All.pixWriteImpliedFormat(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteImpliedFormat",TestPix, RESpixWriteImpliedFormat,{"Dim RESpixWriteImpliedFormat as Integer = LeptonicaSharp._All.pixWriteImpliedFormat(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixChooseOutputFormat as Integer = LeptonicaSharp._All.pixChooseOutputFormat(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixChooseOutputFormat",TestPix, RESpixChooseOutputFormat,{"Dim RESpixChooseOutputFormat as Integer = LeptonicaSharp._All.pixChooseOutputFormat(TestPix )"},1)

' Dim RESgetImpliedFileFormat as Integer = LeptonicaSharp._All.getImpliedFileFormat(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getImpliedFileFormat",TestPix, RESgetImpliedFileFormat,{"Dim RESgetImpliedFileFormat as Integer = LeptonicaSharp._All.getImpliedFileFormat(TestPix )"},1)

' Dim RESpixGetAutoFormat as Integer = LeptonicaSharp._All.pixGetAutoFormat(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixGetAutoFormat",TestPix, RESpixGetAutoFormat,{"Dim RESpixGetAutoFormat as Integer = LeptonicaSharp._All.pixGetAutoFormat(TestPix ,TestPix )"},1)

' Dim RESgetFormatExtension as String = LeptonicaSharp._All.getFormatExtension(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("getFormatExtension",TestPix, RESgetFormatExtension,{"Dim RESgetFormatExtension as String = LeptonicaSharp._All.getFormatExtension(TestPix )"},1)

' Dim RESpixWriteMem as Integer = LeptonicaSharp._All.pixWriteMem(New Byte(),New UInteger,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixWriteMem",TestPix, RESpixWriteMem,{"Dim RESpixWriteMem as Integer = LeptonicaSharp._All.pixWriteMem(New Byte(),New UInteger,TestPix ,TestPix )"},1)

' Dim RESl_fileDisplay as Integer = LeptonicaSharp._All.l_fileDisplay(TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_fileDisplay",TestPix, RESl_fileDisplay,{"Dim RESl_fileDisplay as Integer = LeptonicaSharp._All.l_fileDisplay(TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplay as Integer = LeptonicaSharp._All.pixDisplay(TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplay",TestPix, RESpixDisplay,{"Dim RESpixDisplay as Integer = LeptonicaSharp._All.pixDisplay(TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixDisplayWithTitle as Integer = LeptonicaSharp._All.pixDisplayWithTitle(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayWithTitle",TestPix, RESpixDisplayWithTitle,{"Dim RESpixDisplayWithTitle as Integer = LeptonicaSharp._All.pixDisplayWithTitle(TestPix ,TestPix ,TestPix ,Nothing ,TestPix )"},1)

' Dim RESpixSaveTiled as Integer = LeptonicaSharp._All.pixSaveTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSaveTiled",TestPix, RESpixSaveTiled,{"Dim RESpixSaveTiled as Integer = LeptonicaSharp._All.pixSaveTiled(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSaveTiledOutline as Integer = LeptonicaSharp._All.pixSaveTiledOutline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSaveTiledOutline",TestPix, RESpixSaveTiledOutline,{"Dim RESpixSaveTiledOutline as Integer = LeptonicaSharp._All.pixSaveTiledOutline(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix )"},1)

' Dim RESpixSaveTiledWithText as Integer = LeptonicaSharp._All.pixSaveTiledWithText(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixSaveTiledWithText",TestPix, RESpixSaveTiledWithText,{"Dim RESpixSaveTiledWithText as Integer = LeptonicaSharp._All.pixSaveTiledWithText(TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,TestPix ,Nothing ,Nothing ,TestPix ,TestPix )"},1)

' Dim RESl_chooseDisplayProg as Object = LeptonicaSharp._All.l_chooseDisplayProg(TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("l_chooseDisplayProg",TestPix, RESl_chooseDisplayProg,{"Dim RESl_chooseDisplayProg as Object = LeptonicaSharp._All.l_chooseDisplayProg(TestPix )"},1)

' Dim RESpixDisplayWrite as Integer = LeptonicaSharp._All.pixDisplayWrite(TestPix ,TestPix )
' LeptonicaSharp.Convert.WriteHelpExtension ("pixDisplayWrite",TestPix, RESpixDisplayWrite,{"Dim RESpixDisplayWrite as Integer = LeptonicaSharp._All.pixDisplayWrite(TestPix ,TestPix )"},1)

' Dim RESzlibCompress as Byte() = LeptonicaSharp._All.zlibCompress(TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("zlibCompress",TestPix, RESzlibCompress,{"Dim RESzlibCompress as Byte() = LeptonicaSharp._All.zlibCompress(TestPix ,TestPix ,New UInteger)"},1)

' Dim RESzlibUncompress as Byte() = LeptonicaSharp._All.zlibUncompress(TestPix ,TestPix ,New UInteger)
' LeptonicaSharp.Convert.WriteHelpExtension ("zlibUncompress",TestPix, RESzlibUncompress,{"Dim RESzlibUncompress as Byte() = LeptonicaSharp._All.zlibUncompress(TestPix ,TestPix ,New UInteger)"},1)
End Sub
End Class
