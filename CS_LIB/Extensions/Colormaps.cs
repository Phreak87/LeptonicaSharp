using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Drawing;

public partial class PixColormap
{
	public byte[] Array_Bytes
	{
		get {
			if ((Values == null))
			{ return null; }

			byte[] SRC = new byte[(n * 4)];
			Marshal.Copy(array, SRC, 0, SRC.Length);
			return SRC;
		}
	}
	public RGBA_Quad[] Array_RGBAQ
	{
		get {
			if ((Values == null))
			{ return null; }

			List<RGBA_Quad> QList = new List<RGBA_Quad>();

			for (int i = 0; i <= n - 1; i++)
			{ QList.Add(new RGBA_Quad(Values.array + (4 * i))); }

			return QList.ToArray();
		}
	}
	public Color[] Array_Color
	{
		get {
			if ((Values == null))
			{ return null; }

			List<Color> QList = new List<Color>();

			for (int i = 0; i <= Array_Bytes.Count() - 1; i += 4) {
				byte[] B = new byte[4];
				System.Array.Copy(Array_Bytes, i, B, 0, B.Length);
				QList.Add(Color.FromArgb(B[3], B[2], B[1], B[0]));
			}

			return QList.ToArray();
		}
	}
}

public partial class RGBA_Quad
{
	public object AsSystemColor
	{
		get {
			return Color.FromArgb(Values.alpha, Values.red, Values.green, Values.blue);
		}
	}
	public RGBA_Quad(byte r, byte  g, byte  b, byte  a)
	{
		Values = new Marshal_RGBA_Quad();
		Values.red = r;
		Values.green = g;
		Values.blue = b;
		Values.alpha = a;
	}
	public override string ToString()
	{
		return "R:" + red + " G:" + green + " B:" + blue + " A:" + alpha;
	}
}
