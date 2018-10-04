Imports System
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.DebuggerVisualizers

<Assembly: System.Diagnostics.DebuggerVisualizer(GetType(ImageVisualizer.DebuggerSide),
                                                 GetType(VisualizerObjectSource),
                                                 Target:=GetType(System.Drawing.Image),
                                                 Description:="Image Visualizer")> 

Namespace ImageVisualizer
    Public Class DebuggerSide
        Inherits DialogDebuggerVisualizer

        Protected Overrides Sub Show(ByVal windowService As IDialogVisualizerService, ByVal objectProvider As IVisualizerObjectProvider)
            Dim image As Image = CType(objectProvider.GetObject(), Image)
            Dim form As Form = New Form()
            form.Text = String.Format("Width: {0}, Height: {1}", image.Width, image.Height)
            form.ClientSize = New Size(350, 350)
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Dim pictureBox As BetterPictureBox = New BetterPictureBox()
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Image = image
            pictureBox.Parent = form
            pictureBox.Left = 0
            pictureBox.Top = 0
            pictureBox.Height = form.Height
            pictureBox.Width = form.Width
            windowService.ShowDialog(form)
        End Sub
    End Class
End Namespace
