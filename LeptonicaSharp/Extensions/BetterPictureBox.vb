Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO


<DebuggerStepThrough()>
Public Class BetterPictureBox
    Inherits PictureBox

    Property SavedPic As Boolean = True
    Property LoadedPic As String = ""
    Property DrawSegments As Integer = 0
    Private _interpolationMode As Drawing2D.InterpolationMode = Drawing2D.InterpolationMode.Default

    Event ImageMouseClick(ByVal PT As MouseEventArgs)
    Event ImageMouseMove(ByVal PT As MouseEventArgs)
    Event ImageMouseUp(ByVal PT As MouseEventArgs)
    Event ImageMouseDown(ByVal PT As MouseEventArgs)

    Enum DrawMode
        Both
        Overlay
        Background
    End Enum
    Sub New()
        Me.BackColor = Color.LightGray
        Me.SizeMode = ImageLayout.Zoom
        Me.BorderStyle = Windows.Forms.BorderStyle.None
        Me.BackgroundImageLayout = ImageLayout.Zoom
    End Sub
    Public Property InterpolationMode As Drawing2D.InterpolationMode
        Get
            Return _interpolationMode
        End Get
        Set(ByVal value As Drawing2D.InterpolationMode)
            If value <> _interpolationMode Then
                _interpolationMode = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <DebuggerStepThrough()>
    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        'pe.Graphics.InterpolationMode = _interpolationMode
        MyBase.OnPaint(pe)
    End Sub
    <DebuggerStepThrough()>
    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        pevent.Graphics.InterpolationMode = _interpolationMode
        MyBase.OnPaintBackground(pevent)
    End Sub

    <DebuggerStepThrough()>
    Function ZoomRand(ByVal PNT As Drawing.Point) As Drawing.Point
        If IsNothing(Me.BackgroundImage) Then Return PNT
        Dim ScaleW As Double = (Me.BackgroundImage.Width / Me.Width) '       Breitenskalierung
        Dim ScaleH As Double = (Me.BackgroundImage.Height / Me.Height) '     Hoehenskalierung
        Dim ScaleMin As Double = Math.Min(ScaleH, ScaleW) '                  Die Seite, die am kleinsten skaliert ist
        Dim ScaleMax As Double = Math.Max(ScaleH, ScaleW) '                  Die Seite, die am stärksten skaliert ist

        Dim DifPXW As Integer = Me.Width - (Me.BackgroundImage.Width / ScaleMax)    ' Anzahl der Randpixel Breite
        Dim DifPXH As Integer = Me.Height - (Me.BackgroundImage.Height / ScaleMax)  ' Anzahl der Randpixel Höhe

        Dim SolBreite As Integer = Me.Width
        Dim IstBreite As Integer = Me.BackgroundImage.Width / ScaleMax
        Dim DifBreite As Integer = (SolBreite - IstBreite) * ScaleMax

        Dim SolHoehe As Integer = Me.Height
        Dim IstHoehe As Integer = Me.BackgroundImage.Height / ScaleMax
        Dim DifHoehe As Integer = (SolHoehe - IstHoehe) * ScaleMax

        PNT.X = (PNT.X * ScaleMax) - DifBreite / 2
        PNT.Y = (PNT.Y * ScaleMax) - DifHoehe / 2
        Return PNT
    End Function

    <DebuggerStepThrough()>
    Function StretchRand(ByVal PNT As Drawing.Point) As Drawing.Point
        Dim ScaleW As Double = (Me.BackgroundImage.Width / Me.Width) '       Breitenskalierung
        Dim ScaleH As Double = (Me.BackgroundImage.Height / Me.Height) '     Hoehenskalierung
        Dim ScaleMin As Double = Math.Min(ScaleH, ScaleW)                       '    Die Seite, die am kleinsten skaliert ist
        Dim ScaleMax As Double = Math.Max(ScaleH, ScaleW)                        '   Die Seite, die am stärksten skaliert ist
        Dim ScaleDif As Double = ScaleMax - ScaleMin '                            '  Differenz der Faktoren
        PNT.X = (PNT.X * ScaleW)
        PNT.Y = (PNT.Y * ScaleH)
        Return PNT
    End Function

    Overloads Sub LoadImage(ByVal Picture As Image, Optional ByVal Overlay As Image = Nothing)
        If Not IsNothing(Me.Image) Then Me.Image.Dispose() : Me.Image = Nothing
        SavedPic = False

        If Me.Left < 0 Then Me.Left = 0
        If Me.Top < 0 Then Me.Top = 0
        If Me.Width < 100 Then Me.Width = 100
        If Me.Height < 100 Then Me.Height = 100

        If IsNothing(Picture) Then Exit Sub
        Me.BackgroundImage = Picture
        GenerateOverlay()
        RefreshPic()
    End Sub

    Delegate Sub PicRefresh()
    <DebuggerStepThrough()>
    Sub RefreshPic()
        Try
            If Me.InvokeRequired = True Then
                Me.Invoke(CType(AddressOf RefreshPic, PicRefresh))
                Exit Sub
            Else
                Me.Refresh()
            End If
        Catch : End Try
    End Sub

    Overloads Sub LoadImage(ByVal Filename As String)
        If Not IsNothing(Me.Image) Then Me.Image.Dispose() : Me.Image = Nothing
        If Not IsNothing(Me.BackgroundImage) Then Me.BackgroundImage.Dispose() : Me.BackgroundImage = Nothing
        LoadedPic = Filename
        SavedPic = True

        Dim Test As Boolean = False
        Dim TestI As Integer = 0
        Do Until Test = True Or TestI >= 20
            Try
                Dim FSTest As New System.IO.FileStream(LoadedPic, System.IO.FileMode.Open)
                FSTest.Dispose() : FSTest = Nothing : Test = True
                Using FS As New System.IO.FileStream(LoadedPic, System.IO.FileMode.Open)
                    Dim BMP As Bitmap = Bitmap.FromStream(FS) : Me.BackgroundImage = BMP
                    GenerateOverlay()
                End Using
            Catch
                TestI += 1
            End Try
        Loop

        RefreshPic()
    End Sub

    Function LoadUnblock(ByVal Filename As String) As Image
        Dim BMP As Bitmap
        If My.Computer.FileSystem.FileExists(Filename) = False Then Return Nothing
        Using FS As New System.IO.FileStream(Filename, System.IO.FileMode.Open)
            BMP = Bitmap.FromStream(FS)
        End Using
        Return BMP
    End Function

    <DebuggerStepThrough()>
    Sub GenerateOverlay()
        Try
            Dim OrgImage As Image = Me.BackgroundImage
            Dim Overlay As New Bitmap(OrgImage.Width, OrgImage.Height, Imaging.PixelFormat.Format32bppArgb)
            Overlay.SetResolution(OrgImage.HorizontalResolution, OrgImage.VerticalResolution)
        Catch : End Try
    End Sub

#Region "Picturebox Events + Zoom and Move"
    Dim MPosX As Integer
    Dim MPosY As Integer
    Enum ImageEvent
        MouseMove
        MouseClick
        MouseDown
        MouseUp
    End Enum

    <DebuggerStepThrough()>
    Sub SendEvent(ByVal e As MouseEventArgs, ByVal Evt As ImageEvent)
        Dim PNT As Drawing.Point = PointConverter(e)

        Select Case Evt
            Case ImageEvent.MouseClick : RaiseEvent ImageMouseClick(New MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta))
            Case ImageEvent.MouseDown : RaiseEvent ImageMouseDown(New MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta))
            Case ImageEvent.MouseMove : RaiseEvent ImageMouseMove(New MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta))
            Case ImageEvent.MouseUp : RaiseEvent ImageMouseUp(New MouseEventArgs(e.Button, e.Clicks, PNT.X, PNT.Y, e.Delta))
        End Select
    End Sub

    <DebuggerStepThrough()>
    Public Function PointConverter(ByVal Point As System.Windows.Forms.MouseEventArgs) As Drawing.Point
        Dim PNT As New Drawing.Point(Point.X, Point.Y)
        Select Case Me.SizeMode
            Case PictureBoxSizeMode.Zoom : PNT = ZoomRand(PNT)
            Case PictureBoxSizeMode.StretchImage : PNT = StretchRand(PNT)
        End Select
        Return PNT
    End Function

    <DebuggerStepThrough()>
    Private Sub PicBox_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            Me.Width = Me.Width + 200 : Me.Left = Me.Left - 100
            Me.Height = Me.Height + 200 : Me.Top = Me.Top - 100
        Else
            If Me.Height > 250 And Me.Width > 250 Then
                Me.Width = Me.Width - 200 : Me.Left = Me.Left + 100
                Me.Height = Me.Height - 200 : Me.Top = Me.Top + 100
            End If
        End If
        ' If Me.Left < Me.Width * -1 Then Me.Left = 0
    End Sub
    Private Sub PicBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        SendEvent(e, ImageEvent.MouseDown)
        If e.Button <> Windows.Forms.MouseButtons.Middle Then Exit Sub
        MPosX = e.X : MPosY = e.Y
    End Sub
    Private Sub PicBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        SendEvent(e, ImageEvent.MouseUp)
        If e.Button <> Windows.Forms.MouseButtons.Middle Then Exit Sub
        MPosX = 0 : MPosY = 0
    End Sub
    Private Sub PicBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        SendEvent(e, ImageEvent.MouseClick)
    End Sub
    <DebuggerStepThrough()>
    Private Sub PicBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        SendEvent(e, ImageEvent.MouseMove)
        Me.Select()
        If e.Button <> Windows.Forms.MouseButtons.Middle Then Exit Sub
        If MPosX = 0 Then Exit Sub
        If MPosY = 0 Then Exit Sub
        Me.Top = Me.Top - (MPosY - e.Y)
        Me.Left = Me.Left - (MPosX - e.X)
    End Sub
#End Region

End Class


