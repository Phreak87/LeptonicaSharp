using System;
using System.IO ;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

public class Convert
{
	public enum Languages {
		vbnet = 1,
		CSharp = 2,
		CPlusPlus = 3
	}
	public static void WriteHelpExtension(string Name, Pix PixSource, Pix PixTarget, string[] Line1, Languages Lang = Languages.vbnet)
	{
		if (PixSource != null)
		{ PixSource.pixWriteJpeg ("..\\..\\ALL_Help\\HelpImages\\" + Name + "_S.jpg", 75, 0); }

		if (PixTarget != null)
		{ PixTarget.pixWriteJpeg("..\\..\\ALL_Help\\HelpImages\\" + Name + "_T.jpg", 75, 0); }

		if (File.Exists("..\\..\\VB_Lib\\IncludeComments.xml") == true) {
			System.Xml.XmlDocument XML = new System.Xml.XmlDocument();
			XML.Load("..\\..\\VB_LIB\\IncludeComments.xml");
			System.Xml.XmlNode Node = XML.SelectSingleNode("Comments/" + Name);

			if ((Node == null))
			{ return; }

			var CodeNode = Node.SelectSingleNode("example/code[@language=\"" + Lang.ToString() + "\"]");

			if ((CodeNode == null))
			{ return; }

			CodeNode.InnerXml = Environment.NewLine + string.Join(Environment.NewLine, Line1);
			XML.Save("IncludeComments.xml");
		}
	}
	public static double Deg2Grad(double Deg)
	{
		return Deg * (Math.PI / 180);
	}
	public static double Grad2Dec(double Grad)
	{
		return Grad / (Math.PI / 180);
	}
}

