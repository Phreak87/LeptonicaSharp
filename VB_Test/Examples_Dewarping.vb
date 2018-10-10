Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations

Public Class Examples_Dewarping
    Sub TestDewarp()
        Dim PIXD As Pix = Nothing ' ByRef
        Dim DEWA As L_Dewarpa = Nothing ' ByRef
        Dim PIX32 As New Pix("img\cat.007.jpg") : PIX32.Display()
        Dim RSU = _All.dewarpSinglePage(PIX32, 1, 1, 0, 0, PIXD, DEWA, DebugOnOff.DebugOn)
        PIXD.save_jpg("DewarpSinglePageTest.jpg")

        Dim dewa1 As LeptonicaSharp.L_Dewarpa = _All.dewarpaCreate(1, 0, 2, 0, -1)
        Dim Dew As LeptonicaSharp.L_Dewarp = _All.dewarpCreate(PIX32.pixConvertTo1(128), 0)
        PIX32 = _All.pixDeskew(PIX32, 2) : PIX32.save_jpg("pixDeskewTest.jpg")
    End Sub
End Class
