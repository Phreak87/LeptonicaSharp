Imports System.Runtime.InteropServices

#Region "Default Constructor"
Partial Public Class Sel

    Sub Display()
        Dim n As New ShowPix(LeptonicaSharp._AllFunctions.selDisplayInPix(Me, 1, 1))
    End Sub
    Sub Display(ByVal Pix As Pix)
        Dim CRed As UInt32 = BitConverter.ToUInt32({255, 0, 0, 0}, 0)
        Dim CBlu As UInt32 = BitConverter.ToUInt32({0, 255, 0, 0}, 0)
        Dim n As New ShowPix(LeptonicaSharp._AllFunctions.pixDisplayHitMissSel(Pix, Me, 1, CRed, CBlu))
    End Sub
    Sub New(ByVal Text As String, ByVal w As Integer, ByVal h As Integer, ByVal name As String)
        Me.New(LeptonicaSharp.Natives.selCreateFromString(Text, h, w, name))
    End Sub

End Class
Partial Public Class Numa
    Sub New(ByVal Text As String)
        Me.New(LeptonicaSharp.Natives.numaCreateFromString(Text))
    End Sub
End Class
Partial Public Class Box
    Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal W As Integer, ByVal H As Integer)
        Me.New(LeptonicaSharp.Natives.boxCreate(X, Y, W, H))
    End Sub
End Class
Partial Public Class L_Pdf_Data
    Sub New()
        Values = New Marshal_L_Pdf_Data
        Values.cida = New L_Ptra().Pointer
        Values.objloc = New L_Dna().Pointer
        Values.objsize = New L_Dna().Pointer
        Values.sacmap = New Sarray().Pointer
        Values.saprex = New Sarray().Pointer
        Values.wh = New Pta().Pointer
        Values.xy = New Pta().Pointer
        Pointer = Marshal.AllocHGlobal(Marshal.SizeOf(Values))
        Marshal.StructureToPtr(Values, Pointer, True)
    End Sub
End Class
Partial Public Class L_Ptra
    Sub New()
        Me.Pointer = LeptonicaSharp._AllFunctions.ptraCreate(10).Pointer
    End Sub
End Class
Partial Public Class L_Dna
    Sub New()
        Pointer = LeptonicaSharp._AllFunctions.l_dnaCreate(10).Pointer
    End Sub
End Class
Partial Public Class Pta
    Sub New()
        Pointer = LeptonicaSharp._AllFunctions.ptaCreate(10).Pointer
    End Sub
End Class
Partial Public Class Sarray
    Sub New()
        Pointer = LeptonicaSharp._AllFunctions.sarrayCreate(10).Pointer
    End Sub
End Class
#End Region
