Imports System.Runtime.InteropServices

' ----------------------------------------
' Meistens eine Typedef auf eine Struktur.
' FILE ist eine Systemklasse.
' ----------------------------------------

Public Class FILE
    ' http://www.cplusplus.com/reference/cstdio/fopen/
    Property Pointer As IntPtr
    Private Values As Marshal_FILE

    Sub New(ByVal Filename As String)
        Me.New(LeptonicaSharp.Natives.lept_fopen(Filename, "rb"))
    End Sub

    Sub New(ByVal IntPTR As IntPtr)
        If IntPTR = IntPTR.Zero Then Exit Sub
        Pointer = IntPTR
        Values = New Marshal_FILE
        Marshal.PtrToStructure(Pointer, Values)
    End Sub

    <StructLayout(LayoutKind.Sequential)>
    Private Class Marshal_FILE
        Public _ptr As String
        Public _cnt As Integer
        Public _base As String
        Public _flag As Integer
        Public _file As Integer
        Public _charbuf As Integer
        Public _bufsiz As Integer
        Public _tmpfname As String
    End Class

    ReadOnly Property _ptr As String
        Get
            Return Values._ptr
        End Get
    End Property
    ReadOnly Property _cnt As Integer
        Get
            Return Values._cnt
        End Get
    End Property
    ReadOnly Property _base As String
        Get
            Return Values._base
        End Get
    End Property
    ReadOnly Property _flag As Integer
        Get
            Return Values._flag
        End Get
    End Property
    ReadOnly Property _file As Integer
        Get
            Return Values._file
        End Get
    End Property
    ReadOnly Property _charbuf As Integer
        Get
            Return Values._charbuf
        End Get
    End Property
    ReadOnly Property _bufsiz As Integer
        Get
            Return Values._bufsiz
        End Get
    End Property
    ReadOnly Property _tmpfname As String
        Get
            Return Values._tmpfname
        End Get
    End Property
End Class
