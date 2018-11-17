Public Class Convert
    Enum Languages
        vbnet = 1
        CSharp = 2
        CPlusPlus = 3
    End Enum
    Public Shared Sub WriteHelpExtension(ByVal Name As String, 
										 ByVal PixSource As Pix, 
										 ByVal PixTarget As Pix, 
										 ByVal Line1 As String(), 
										 Optional Lang As Languages = Languages.vbnet)
										 
        If Not IsNothing(PixSource) Then PixSource.save_jpg("..\..\ALL_Help\HelpImages\" &  Name & "_S.jpg")
        If Not IsNothing(PixTarget) Then PixTarget.save_jpg("..\..\ALL_Help\HelpImages\" & Name & "_T.jpg")

        If My.Computer.FileSystem.FileExists("..\..\VB_Lib\IncludeComments.xml") = True Then
            Dim XML As New Xml.XmlDocument : XML.Load("..\..\VB_LIB\IncludeComments.xml")
            Dim Node As Xml.XmlNode = XML.SelectSingleNode("Comments/" & Name) : If IsNothing(Node) Then Exit Sub
            Dim CodeNode = Node.SelectSingleNode("example/code[@language=""" & Lang.ToString & """]") : If IsNothing(CodeNode) Then Exit Sub
            CodeNode.InnerXml = vbCrLf & String.Join(vbCrLf, Line1)
            XML.Save("IncludeComments.xml")
        End If
    End Sub
    Public Shared Function Deg2Grad(ByVal Deg As Double) As Double
        Return Deg * (Math.PI / 180)
    End Function
    Public Shared Function Grad2Dec(ByVal Grad As Double) As Double
        Return Grad / (Math.PI / 180)
    End Function
End Class
