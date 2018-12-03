using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



#region "Default Constructor (Incomplete Pix, Sel)"
    public partial class Sel
    {
        //Sub Display()
        //    Dim n As New ShowPix(LeptonicaSharp._All.selDisplayInPix(Me, 1, 1))
        //End Sub
        //Sub Display(ByVal Pix As Pix)
        //    Dim CRed As UInt32 = BitConverter.ToUInt32({255, 0, 0, 0}, 0)
        //    Dim CBlu As UInt32 = BitConverter.ToUInt32({0, 255, 0, 0}, 0)
        //    Dim n As New ShowPix(LeptonicaSharp._All.pixDisplayHitMissSel(Pix, Me, 1, CRed, CBlu))
        //End Sub
        public Sel(String Text, int w, int h, String name)
        {
            this.Pointer = LeptonicaSharp._All.selCreateFromString(Text, h, w, name).Pointer ;
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
            //        Values = New Marshal_L_Pdf_Data
            //        Values.cida = New L_Ptra(10).Pointer
            //        Values.objloc = New L_Dna(10).Pointer
            //        Values.objsize = New L_Dna(10).Pointer
            //        Values.sacmap = New Sarray(10).Pointer
            //        Values.saprex = New Sarray(1).Pointer
            //        Values.wh = New Pta(10).Pointer
            //        Values.xy = New Pta(10).Pointer
            //        Pointer = Marshal.AllocHGlobal(Marshal.SizeOf(Values))
            //        Marshal.StructureToPtr(Values, Pointer, True)
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
    public partial class Sarray
    {
        public Sarray(int Count)
        {
            this.Pointer = LeptonicaSharp._All.sarrayCreate(Count).Pointer ;
        }
    }
    public partial class Pixa
    {
        public Pixa(int Count)
        {
            this.Pointer = LeptonicaSharp._All.pixaCreate(Count).Pointer ;
        }
    }
    public partial class Pix
    {
        //Sub New(ByVal Bitmap As Drawing.Bitmap)
        //    Dim Stream As New System.IO.MemoryStream : Bitmap.Save(Stream, Imaging.ImageFormat.Bmp)
        //    Dim OBJ = _All.pixReadMemBmp(Stream.GetBuffer, Stream.Length)
        //    Pointer = OBJ.Pointer
        //End Sub
        // VB-Clone
        public Pix(int w, int h)
        {
            Pix OBJ = LeptonicaSharp._All.pixCreate(w, h, 32);
            Pointer = OBJ.Pointer;
        }
    }
#endregion