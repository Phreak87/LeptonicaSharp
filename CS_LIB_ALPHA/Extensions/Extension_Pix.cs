using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Reflection;
using System.Drawing.Imaging;
using LeptonicaSharp;
using LeptonicaCSharp.Extensions;

    public partial class Box
    {
        public Pix GetBitmap(Pix Pix = null)
        {
            if ((Pix == null))
                Pix = new Pix(this.w + this.x + 5, this.h + this.y + 5);
            Bitmap n = new Bitmap((int) Pix.w,(int) Pix.h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(n);
            Pen p = new Pen(Brushes.Red, 3);
            g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h);
            g.DrawRectangle(p, new Rectangle(this.x, this.y, this.w, this.h));
            Pix RPix = new Pix(n);
            n.Dispose();
            return RPix;
        }
        public void Display(Pix Pix = null)
        {
            ShowPix n = new ShowPix(GetBitmap(Pix));
        }
    }

    public partial class Boxa
    {
        public Pix GetBitmap(Pix Pix = null)
        {
            int MaxW = 0;
            int MaxH = 0;
            foreach (Box Entry_loopVariable in this.box)
            {
               Box Entry = Entry_loopVariable;
                if (Entry.x + Entry.w + 5 > MaxW)
                    MaxW = Entry.x + Entry.w + 5;
                if (Entry.y + Entry.h + 5 > MaxH)
                    MaxH = Entry.y + Entry.h + 5;
            }
            if ((Pix == null))
                Pix = new Pix(MaxW, MaxH);
            Bitmap n = new Bitmap((int) Pix.w, (int)Pix.h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(n);
            Pen p = new Pen(Brushes.Red, 3);
            g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h);
            foreach (Box Boxe_loopVariable in this.box)
            {
               Box Boxe = Boxe_loopVariable;
                g.DrawRectangle(p, new Rectangle(Boxe.x, Boxe.y, Boxe.w, Boxe.h));
            }
            Pix RPix = new Pix(n);
            n.Dispose();
            return RPix;
        }
        public void Display(Pix Pix = null)
        {
            ShowPix n = new ShowPix(GetBitmap(Pix));
        }
    }

    public partial class Pix
    {
        #region "Redirects"
        /// <summary>
        /// This Property returns a cached value of the data array 
        /// for iterating. 
        /// </summary>
        public byte[] DataStatic
        {
            get
            {
                if (Pointer == IntPtr.Zero)
                    return null;
                if (Caching.ContainsKey("Data1"))
                    return (byte[]) Caching["Data1"];
                Caching.Add("Data1", this.data);
                return (byte[]) Caching["Data1"];
            }
        }

        public Bitmap BitmapStatic
        {
            get
            {
                if (Pointer == IntPtr.Zero)
                    return null;
                //if (Caching.ContainsKey("Bitmap")) {CType (Caching ("Bitmap"), System.Drawing.Bitmap ). , Caching.Remove("Bitmap"); }
                Caching.Add("Bitmap", this.ToBitmap());
                return (Bitmap ) Caching["Bitmap"];
            }
        }

        #region "Saving"
        public void save_jpg(string filename, int quality = 95, int progressive = 0)
        {
            Natives.pixWriteJpeg(filename, Pointer, quality, progressive);
        }
        public void save_png(string filename, float gamma = 95, int progressive = 0)
        {
            Natives.pixWritePng(filename, Pointer, gamma);
        }
        public void save_tiff(string filename)
        {
            Natives.pixWriteTiff(filename,Pointer, (int) Enumerations.IFF.IFF_TIFF , "a");
        }
        public int save_format(string filename, Enumerations.IFF format)
        {
            return Natives.pixWrite(filename, Pointer,(int) format);
        }
        public int save_autoformat(string filename)
        {
            return Natives.pixWriteAutoFormat(filename,Pointer);
        }
        #endregion
        #endregion
        #region "Functions"
        public void RefreshStatic()
        {
            foreach (KeyValuePair<string, object> Entry in Caching)
            {
                try
                {
                    //Entry.Value = null;
                }
                catch
                {
                }
            }
            Caching.Clear();
        }
        public void Display(string Text = "")
        {
            ShowPix n = new ShowPix(this, Text);
        }
        public Image ToBitmap()
        {
            uint Size = 0;
            byte[] Bytes = null;

            if (this.d == 1) { return ConvertTo1BPPBMP(this); }
            _All.pixWriteMemBmp(out Bytes, out Size, (this.d == 24 ? this.pixConvertTo32() : this));
            System.IO.MemoryStream MemStrm = new System.IO.MemoryStream(Bytes);
            return new Bitmap(MemStrm, true);
        }

        public Bitmap ConvertTo1BPPBMP(Pix Pix)
        {
            Marshal_Pix MSH = new Marshal_Pix();
            Pix PixSwap = LeptonicaSharp._All.pixEndianByteSwapNew(Pix);

            try
            {
                Bitmap img = new Bitmap((int) Pix.w, (int)Pix.h, PixelFormat.Format1bppIndexed );
                BitmapData imgData = img.LockBits(new Rectangle(0, 0, (int)img.Width, (int)img.Height), ImageLockMode.ReadOnly  , PixelFormat.Format1bppIndexed);
                for (int Line = 0; Line <= Pix.h - 1; Line++)
                {
                    for (int Col = 0; Col <= Pix.w - 1; Col += 8)
                    {
                        int index = ((int)Line * (int)PixSwap.wpl * 4) + (Col >> 3);
                        Byte Byt =  PixSwap.DataStatic[index];
                        Marshal.WriteByte(imgData.Scan0, index, (Byte) (Byt ^ 0xff));
                    }
                }
                img.UnlockBits(imgData);
                return img;
                }
            catch
            {
            }
            return null;
        }
        #endregion
    }

    public partial class Pixa
    {
        public Pix GetBitmap(int NCols = 4)
        {
            var pixc = LeptonicaSharp._All.pixaDisplayTiledAndScaled(this, 32, 500, NCols, 0, 1, 3);
            return pixc;
        }
        public void Display(int NCols = 4)
        {
            ShowPix n = new ShowPix(GetBitmap());
        }
    }

    public partial class Numa
    {
        public void DisplayNumaBarGraph(Numa NumaH = null, Pix BgPix = null, bool Swap = false)
        {
        //    Numa NumaW = this;
        //    if (Swap == true)
        //    {
        //        var TMpH = NumaH;
        //        var TmpW = this;
        //        NumaH = TmpW;
        //        NumaW = TMpH;
        //    }
        //    int NumaHCnt = 1;
        //    if ((NumaH != null))
        //        NumaHCnt = NumaH.n;
        //    int NumaWCnt = 1;
        //    if ((NumaW != null))
        //        NumaWCnt = NumaW.n;
        //    //double NumaHMax = 1;
        //    //if ((NumaH != null))
        //    //    NumaHMax = (int) NumaH.array.Max();
        //    //double NumaWMax = 1;
        //    //if ((NumaW != null))
        //    //    NumaWMax = (int) NumaW.array.Max();
        //    //int VMaxH = (int )Math.Max(NumaHMax, NumaWCnt);
        //    //if (VMaxH > 2000)
        //    //    VMaxH = 2000;
        //    //int VMaxW = (int) Math.Max(NumaWMax, NumaHCnt);
        //    //if (VMaxW > 2000)
        //    //    VMaxW = 2000;
        //    //if ((BgPix != null)) { VMaxH = (int) BgPix.h; VMaxW = (int) BgPix.w; }
        //    //double DiffH = VMaxH / NumaHMax;
        //    //double DiffW = VMaxW / NumaWMax;

        //    //Bitmap n = new Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb);
        //    Pen Pen1 = new Pen(System.Drawing.Color.FromArgb(150, 0, 255, 0), 1);
        //    Pen Pen2 = new Pen(System.Drawing.Color.FromArgb(150, 255, 0, 0), 1);
        //    //Graphics g = Graphics.FromImage(n);

        //    if ((BgPix == null))
        //        //g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, 0, VMaxW, VMaxH));
        //    if ((BgPix != null))
        //        //g.DrawImage(BgPix.ToBitmap(), new System.Drawing.Point(0, 0));

        //    if ((NumaW != null))
        //    {
        //        for (int i = 0; i <= NumaW.n - 1; i++)
        //        {
        //            g.DrawLine(Pen1, new System.Drawing.Point(0, i + 1), new System.Drawing.Point((int) NumaW.array[i] * (int) DiffW, i + 1));
        //        }
        //    }
        //    if ((NumaH != null))
        //    {
        //        for (int i = 0; i <= NumaH.n - 1; i++)
        //        {
        //            g.DrawLine(Pen2, new System.Drawing.Point(i + 1, (int) VMaxH - ((int)NumaH.array[i] * (int)DiffH)), new System.Drawing.Point(i + 1, VMaxH));
        //        }
        //    }
        //    Pix PX = new Pix(n);
        //    PX.Display();
        //    PX.Dispose();
        }
        public void DisplayNumaHeatmap(Numa NumaH = null, Pix BgPix = null, bool Swap = false)
        {
        //    Numa NumaW = this;
        //    if (Swap == true)
        //    {
        //        var TMpH = NumaH;
        //        var TmpW = NumaW;
        //        NumaH = TmpW;
        //        NumaW = TMpH;
        //    }
        //    int NumaHCnt = 1;
        //    if ((NumaH != null))
        //        NumaHCnt = NumaH.n;
        //    int NumaWCnt = 1;
        //    if ((NumaW != null))
        //        NumaWCnt = NumaW.n;
        //    double NumaHMax = 1;
        //    if ((NumaH != null))
        //        NumaHMax = (int)NumaH.array.Max();
        //    double NumaWMax = 1;
        //    if ((NumaW != null))
        //        NumaWMax = (int)NumaW.array.Max();
        //    int VMaxH = (int)(Math.Max(NumaHMax, NumaWCnt));
        //    if (VMaxH > 2000)
        //        VMaxH = 2000;
        //    int VMaxW = (int)(Math.Max(NumaWMax, NumaHCnt));
        //    if (VMaxW > 2000)
        //        VMaxW = 2000;
        //    if ((BgPix != null)) { VMaxH = (int) BgPix.h; VMaxW = (int)BgPix.w; }
        //    double VDiffH = VMaxH / NumaHMax;
        //    double VDiffW = VMaxW / NumaWMax;

        //    Bitmap n = new Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb);
        //    Graphics g = Graphics.FromImage(n);

        //    if ((BgPix == null))
        //        g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, 0, VMaxW, VMaxH));
        //    if ((BgPix != null))
        //        g.DrawImage(BgPix.ToBitmap(), new System.Drawing.Point(0, 0));

        //    if ((NumaW != null))
        //    {
        //        int BarHeight = System.Convert.ToInt32 (VMaxH / NumaWCnt);
        //        for (int i = 0; i <= NumaW.n - 1; i++)
        //        {
        //            int BarPos = ((i) * BarHeight) + (BarHeight == 1 ? 0 : (BarHeight / 2));
        //            Pen Pen = new Pen(Color.FromArgb(System.Convert.ToInt32((130 / NumaWMax) * NumaW.array[i]), 0, 255, 0), BarHeight);
        //            System.Drawing.Point P1 = new System.Drawing.Point(0, BarPos);
        //            System.Drawing.Point P2 = new System.Drawing.Point(VMaxW, BarPos);
        //            g.DrawLine(Pen, P1, P2);
        //        }
        //    }

        //    if ((NumaH != null))
        //    {
        //        int BarWidth = Math.Max(System.Convert.ToInt32(VMaxW / NumaHCnt), 1);
        //        for (int i = 0; i <= NumaH.n - 1; i++)
        //        {
        //            int BarPos = ((i) * BarWidth) + (BarWidth == 1 ? 0 : (BarWidth / 2));
        //            Pen Pen = new Pen(Color.FromArgb(System.Convert.ToInt32((130 / NumaHMax) * NumaH.array[i]), 0, 0, 255), BarWidth);
        //            System.Drawing.Point P1 = new System.Drawing.Point(BarPos, 0);
        //            System.Drawing.Point P2 = new System.Drawing.Point(BarPos, VMaxH);
        //            g.DrawLine(Pen, P1, P2);
        //        }
        //    }

        //    Pix PX = new Pix(n);
        //    PX.Display();
        //    PX.Dispose();
        }
    }

    public partial class Sel
    {
        public void Display()
        {
           ShowPix n = new ShowPix(LeptonicaSharp._All.selDisplayInPix(this, 1, 1));
        }
        public void Display(Pix Pix)
		{
			UInt32 CRed = BitConverter.ToUInt32( new byte[]{255,0,0,0}, 0);
            UInt32 CBlu = BitConverter.ToUInt32(new byte[]{0,255,0,0}, 0);
			ShowPix n = new ShowPix(LeptonicaSharp._All.pixDisplayHitMissSel(Pix, this, 1, CRed, CBlu));
		}
    }
