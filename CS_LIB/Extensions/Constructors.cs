using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LeptonicaSharp;
using System.Linq;
using System.Text;

#region "Default Constructor"
public partial class Sel
{
	public Sel(String Text, int w, int h, String name)
	{
		this.Pointer = LeptonicaSharp._All.selCreateFromString(Text, h, w, name).Pointer ;
	}
}
public partial class Pix
{
	public Pix(System.Drawing.Bitmap Bitmap)
	{
		System.IO.MemoryStream Stream = new System.IO.MemoryStream();
		Bitmap.Save(Stream, System.Drawing.Imaging.ImageFormat.Bmp);
		var OBJ = _All.pixReadMemBmp(Stream.GetBuffer(), (uint) Stream.Length);
		Pointer = OBJ.Pointer;
	}
	public Pix(int w, int h)
	{
		Pix OBJ = LeptonicaSharp._All.pixCreate(w, h, 32);
		Pointer = OBJ.Pointer;
	}
	public Pix()
	{
	}
}
public partial class Pixa
{
	public Pixa(int Count)
	{
		this.Pointer = LeptonicaSharp._All.pixaCreate(Count).Pointer ;
	}
}
public partial class Pta
{
	public Pta(int Count)
	{
		this.Pointer = LeptonicaSharp._All.ptaCreate(Count).Pointer ;
	}
}
public partial class Ptra
{
	public Ptra()
	{
	}
}
public partial class Numa
{
	public Numa(String Text)
	{
		this.Pointer = LeptonicaSharp._All.numaCreateFromString(Text).Pointer ;
	}
}
public partial class Box
{
	public Box(int X, int Y, int W, int H)
	{
		this.Pointer = LeptonicaSharp._All.boxCreate(X, Y, W, H).Pointer ;
	}
}
public partial class L_Pdf_Data
{
	public L_Pdf_Data()
	{
		Values = new Marshal_L_Pdf_Data();
		Values.cida = new L_Ptra(10).Pointer;
		Values.objloc = new L_Dna(10).Pointer;
		Values.objsize = new L_Dna(10).Pointer;
		Values.sacmap = new Sarray(10).Pointer;
		Values.saprex = new Sarray(1).Pointer;
		Values.wh = new Pta(10).Pointer;
		Values.xy = new Pta(10).Pointer;
		Pointer = Marshal.AllocHGlobal(Marshal.SizeOf(Values));
		Marshal.StructureToPtr(Values, Pointer, true);
	}
}
public partial class L_Ptra
{
	public L_Ptra(int Count)
	{
		this.Pointer = LeptonicaSharp._All.ptraCreate(Count).Pointer ;
	}
}
public partial class L_Dna
{
	public L_Dna(int Count)
	{
		this.Pointer = LeptonicaSharp._All.l_dnaCreate(Count).Pointer ;
	}
}
public partial class Sarray
{
	public Sarray(int Count)
	{
		this.Pointer = LeptonicaSharp._All.sarrayCreate(Count).Pointer ;
	}
}

#endregion