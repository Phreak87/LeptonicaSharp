Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations

Public Class Examples_Quantization
    Sub QuantizationTest()
        Dim PIxCQ As New Pix("..\..\..\All_Images\MZucker\Test1.png") : PIxCQ = PIxCQ.ConvertTo32()
        'LeptonicaSharp._All.pixOctreeColorQuant(PIxCQ, 128, 0).Display()
        'LeptonicaSharp._All.pixSimpleColorQuantize(PIxCQ, 3, 1, 2).Display()
        'LeptonicaSharp._All.pixOctreeColorQuantGeneral(PIxCQ, 128, 0, 0.01, 0.01).Display()
        'LeptonicaSharp._All.pixOctreeQuantByPopulation(PIxCQ, 0, 0).Display()
        'LeptonicaSharp._All.pixFewColorsMedianCutQuantMixed(PIxCQ, 1, 2, 0, 0, 0, 0).Display()
    End Sub
End Class
