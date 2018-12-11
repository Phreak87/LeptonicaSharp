Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Drawing

#Region "Default Constructor"
Partial Public Class Sel

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
        Values.cida = New L_Ptra(10).Pointer
        Values.objloc = New L_Dna(10).Pointer
        Values.objsize = New L_Dna(10).Pointer
        Values.sacmap = New Sarray(10).Pointer
        Values.saprex = New Sarray(1).Pointer
        Values.wh = New Pta(10).Pointer
        Values.xy = New Pta(10).Pointer
        Pointer = Marshal.AllocHGlobal(Marshal.SizeOf(Values))
        Marshal.StructureToPtr(Values, Pointer, True)
    End Sub
End Class
Partial Public Class L_Ptra
    Sub New(Count As Integer)
        Me.New(LeptonicaSharp.Natives.ptraCreate(Count))
    End Sub
    Sub Refresh()
        Marshal.PtrToStructure(Me.Pointer, Values)
    End Sub
End Class
Partial Public Class L_Dna
    Sub New(Count As Integer)
        Me.New(Natives.l_dnaCreate(Count))
    End Sub
End Class
Partial Public Class Pta
    Sub New(Count As Integer)
        Me.New(Natives.ptaCreate(Count))
    End Sub
End Class
Partial Public Class Ptra
    Sub New()

    End Sub
End Class
Partial Public Class Sarray

    Sub New(ByVal Count As Integer)
        Me.New(Natives.sarrayCreate(Count))
    End Sub
End Class
Partial Public Class Pixa
    Sub New(Optional Count As Integer = 1)
        Me.New(Natives.pixaCreate(Count))
    End Sub
End Class
Partial Public Class Pix
    Sub New(ByVal w As Integer, ByVal h As Integer)
        Dim OBJ = LeptonicaSharp._All.pixCreate(w, h, 32)
        Pointer = OBJ.Pointer
    End Sub
    Sub New(ByVal Bitmap As Drawing.Bitmap)
        Dim Stream As New System.IO.MemoryStream : Bitmap.Save(Stream, Imaging.ImageFormat.Bmp)
        Dim OBJ = _All.pixReadMemBmp(Stream.GetBuffer, Stream.Length)
        Pointer = OBJ.Pointer
    End Sub
End Class
#End Region
