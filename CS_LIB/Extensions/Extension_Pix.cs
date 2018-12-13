using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using LeptonicaSharp.Extensions;
using LeptonicaSharp;
using System.Linq;

public partial class Box
{
    public Pix GetBitmap(Pix Pix = null)
    {
        if (Pix == null)
        { Pix = new Pix(this.w + this.x + 5, this.h + this.y + 5); }

        using (var bmp = new Bitmap((int)Pix.w, (int)Pix.h, PixelFormat.Format24bppRgb))
        using (var g = Graphics.FromImage(bmp))
        using (var p = new Pen(Brushes.Red, 3))
        {
            g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h);
            g.DrawRectangle(p, new Rectangle(this.x, this.y, this.w, this.h));
            return new Pix(bmp);
        }
    }

    public void Display(Pix Pix = null)
    {
        var n = new ShowPix(GetBitmap(Pix));
    }
}

public partial class Boxa
{
    public Pix GetBitmap(Pix Pix = null)
    {
        int MaxW = 0;
        int MaxH = 0;

        foreach (var Entry_loopVariable in this.box)
        {
            var Entry = Entry_loopVariable;

            if (Entry.x + Entry.w + 5 > MaxW)
            { MaxW = Entry.x + Entry.w + 5; }

            if (Entry.y + Entry.h + 5 > MaxH)
            { MaxH = Entry.y + Entry.h + 5; }
        }

        if (Pix == null)
        { Pix = new Pix(MaxW, MaxH); }

        using (var bmp = new Bitmap((int)Pix.w, (int)Pix.h, PixelFormat.Format24bppRgb))
        using (var g = Graphics.FromImage(bmp))
        using (var p = new Pen(Brushes.Red, 3))
        {
            g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h);

            foreach (var Boxe_loopVariable in this.box)
            {
                var Boxe = Boxe_loopVariable;
                g.DrawRectangle(p, new Rectangle(Boxe.x, Boxe.y, Boxe.w, Boxe.h));
            }

            return new Pix(bmp);
        }
    }

    public void Display(Pix Pix = null)
    {
        var n = new ShowPix(GetBitmap(Pix));
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
            { return null; }

            if (Caching.ContainsKey("Data1"))
            { return (byte[])Caching["Data1"]; }

            Caching.Add("Data1", this.data);
            return (byte[])Caching["Data1"];
        }
    }

    public Bitmap BitmapStatic
    {
        get
        {
            if (Pointer == IntPtr.Zero)
            { return null; }

            if (Caching.ContainsKey("Bitmap"))
            { return (Bitmap)Caching["Bitmap"]; }

            Caching.Add("Bitmap", this.ToBitmap());
            return (Bitmap)Caching["Bitmap"];
        }
    }

    #endregion

    #region "Functions"

    public void RefreshStatic()
    {
        foreach (var Entry in Caching)
        {
            try
            {
                var disp = Entry.Value as IDisposable;

                if (disp != null)
                { disp.Dispose(); }
            }
            catch
            { }
        }

        Caching.Clear();
    }

    public void Display(string Text = "")
    {
        var n = new ShowPix(this, Text);
    }

    public Image ToBitmap()
    {
        uint Size = 0;
        byte[] Bytes = null;
        const int xr = 96, yr = 96;

        if (this.d == 1)
        { return ConvertTo1BPPBMP(this); }
        else if (this.d == 24)
        { _All.pixWriteMemBmp(out Bytes, out Size, this._ConvertTo32()); }
        else if (this.d == 32)
        {
            byte[] pdatafile;
            uint pfilesize;
            _All.pixWriteMemPng(out pdatafile, out pfilesize, this, 0.0f);
            Bitmap img;

            using (var ms = new System.IO.MemoryStream(pdatafile))
            {
                img = new Bitmap(ms);
                if (this.xres != 0 && this.yres != 0)
                    img.SetResolution(this.xres, this.yres);
                else
                    img.SetResolution(xr, yr);
            }
            return img;
        }
        else
        { _All.pixWriteMemBmp(out Bytes, out Size, this); }

        var MemStrm = new System.IO.MemoryStream(Bytes);
        var bmp = new Bitmap(MemStrm, true);
        if (this.xres != 0 && this.yres != 0)
            bmp.SetResolution(this.xres, this.yres);
        else
            bmp.SetResolution(xr, yr);
        return bmp;
    }

    public Bitmap ConvertTo1BPPBMP(Pix Pix)
    {
        var PixSwap = _All.pixEndianByteSwapNew(Pix);
        int xr = 96, yr = 96;

        try
        {
            var img = new Bitmap((int)Pix.w, (int)Pix.h, PixelFormat.Format1bppIndexed);
            var imgData = img.LockBits(new Rectangle(0, 0, (int)img.Width, (int)img.Height), ImageLockMode.ReadOnly, PixelFormat.Format1bppIndexed);

            for (int Line = 0; Line <= Pix.h - 1; Line++)
            {
                for (int Col = 0; Col <= Pix.w - 1; Col += 8)
                {
                    int index = ((int)Line * (int)PixSwap.wpl * 4) + (Col >> 3);
                    var Byt = PixSwap.DataStatic[index];
                    Marshal.WriteByte(imgData.Scan0, index, (Byte)(Byt ^ 0xff));
                }
            }

            img.UnlockBits(imgData);
            if (Pix.xres != 0 && Pix.yres != 0)
                img.SetResolution(Pix.xres, Pix.yres);
            else
                img.SetResolution(xr, yr);

            return img;
        }
        catch
        { }
        finally
        {
            _All.pixDestroy(ref PixSwap);
        }

        return null;
    }
    #endregion
}

public partial class Pixa
{
    public Pix GetBitmap(int NCols = 4)
    {
        return _All.pixaDisplayTiledAndScaled(this, 32, 500, NCols, 0, 1, 3);
    }

    public void Display(int NCols = 4)
    {
        var n = new ShowPix(GetBitmap());
    }
}

public partial class Numa
{
    public Pix DisplayNumaBarGraph(Numa NumaH = null, Pix BgPix = null, bool Swap = false)
    {
        var NumaW = this;

        if (Swap == true)
        {
            var TMpH = NumaH;
            var TmpW = this;
            NumaH = TmpW;
            NumaW = TMpH;
        }

        int NumaHCnt = 1;

        if (NumaH != null)
        { NumaHCnt = NumaH.n; }

        int NumaWCnt = 1;

        if (NumaW != null)
        { NumaWCnt = NumaW.n; }

        double NumaHMax = 1;
        if (NumaH != null)
            NumaHMax = (int)NumaH.array.Max();
        double NumaWMax = 1;
        if (NumaW != null)
            NumaWMax = (int)NumaW.array.Max();
        int VMaxH = (int)Math.Max(NumaHMax, NumaWCnt);
        if (VMaxH > 2000)
            VMaxH = 2000;
        int VMaxW = (int)Math.Max(NumaWMax, NumaHCnt);
        if (VMaxW > 2000)
            VMaxW = 2000;

        int xres = 96, yres = 96;
        if (BgPix != null) { VMaxH = (int)BgPix.h; VMaxW = (int)BgPix.w; xres = BgPix.xres; yres = BgPix.yres; }
        double DiffH = VMaxH / NumaHMax;
        double DiffW = VMaxW / NumaWMax;

        using (var n = new Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb))
        {
            n.SetResolution(xres, yres);

            using (var Pen1 = new Pen(Color.FromArgb(150, 0, 255, 0), 1))
            using (var Pen2 = new Pen(Color.FromArgb(150, 255, 0, 0), 1))
            using (var g = Graphics.FromImage(n))
            {
                if (BgPix == null)
                    g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, 0, VMaxW, VMaxH));
                if (BgPix != null)
                    g.DrawImage(BgPix.ToBitmap(), new Point(0, 0));
                if (NumaW != null)
                {
                    for (int i = 0; i <= NumaW.n - 1; i++)
                        g.DrawLine(Pen1, new Point(0, i + 1), new Point((int)NumaW.array[i] * (int)DiffW, i + 1));
                }
                if (NumaH != null)
                {
                    for (int i = 0; i <= NumaH.n - 1; i++)
                        g.DrawLine(Pen2, new Point(i + 1, (int)VMaxH - ((int)NumaH.array[i] * (int)DiffH)), new Point(i + 1, VMaxH));
                }
                return new Pix(n);
            }
        }
    }

    public Pix DisplayNumaHeatmap(Numa NumaH = null, Pix BgPix = null, bool Swap = false)
    {
        var NumaW = this;

        if (Swap == true)
        {
            var TMpH = NumaH;
            var TmpW = NumaW;
            NumaH = TmpW;
            NumaW = TMpH;
        }

        int NumaHCnt = 1;

        if (NumaH != null)
        { NumaHCnt = NumaH.n; }

        int NumaWCnt = 1;

        if (NumaW != null)
        { NumaWCnt = NumaW.n; }

        double NumaHMax = 1;
        if (NumaH != null)
            NumaHMax = (int)NumaH.array.Max();
        double NumaWMax = 1;
        if (NumaW != null)
            NumaWMax = (int)NumaW.array.Max();
        int VMaxH = (int)(Math.Max(NumaHMax, NumaWCnt));
        if (VMaxH > 2000)
            VMaxH = 2000;
        int VMaxW = (int)(Math.Max(NumaWMax, NumaHCnt));
        if (VMaxW > 2000)
            VMaxW = 2000;

        int xres = 96, yres = 96;
        if (BgPix != null) { VMaxH = (int)BgPix.h; VMaxW = (int)BgPix.w; xres = BgPix.xres; yres = BgPix.yres; }
        double VDiffH = VMaxH / NumaHMax;
        double VDiffW = VMaxW / NumaWMax;

        using (var n = new Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb))
        {
            n.SetResolution(xres, yres);

            using (var g = Graphics.FromImage(n))
            {
                if (BgPix == null)
                    g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(0, 0, VMaxW, VMaxH));
                if (BgPix != null)
                    g.DrawImage(BgPix.ToBitmap(), new Point(0, 0));
                if (NumaW != null)
                {
                    int BarHeight = System.Convert.ToInt32(VMaxH / NumaWCnt);
                    for (int i = 0; i <= NumaW.n - 1; i++)
                    {
                        int BarPos = (i * BarHeight) + (BarHeight == 1 ? 0 : (BarHeight / 2));
                        using (var Pen = new Pen(Color.FromArgb(System.Convert.ToInt32((130 / NumaWMax) * NumaW.array[i]), 0, 255, 0), BarHeight))
                        {
                            var P1 = new Point(0, BarPos);
                            var P2 = new Point(VMaxW, BarPos);
                            g.DrawLine(Pen, P1, P2);
                        }
                    }
                }
                if (NumaH != null)
                {
                    int BarWidth = Math.Max(System.Convert.ToInt32(VMaxW / NumaHCnt), 1);
                    for (int i = 0; i <= NumaH.n - 1; i++)
                    {
                        int BarPos = (i * BarWidth) + (BarWidth == 1 ? 0 : (BarWidth / 2));
                        using (var Pen = new Pen(Color.FromArgb(System.Convert.ToInt32((130 / NumaHMax) * NumaH.array[i]), 0, 0, 255), BarWidth))
                        {
                            var P1 = new Point(BarPos, 0);
                            var P2 = new Point(BarPos, VMaxH);
                            g.DrawLine(Pen, P1, P2);
                        }
                    }
                }
                return new Pix(n);
            }
        }
    }
}

public partial class Sel
{
    public void Display()
    {
        var n = new ShowPix(_All.selDisplayInPix(this, 1, 1));
    }

    public void Display(Pix Pix)
    {
        var CRed = BitConverter.ToUInt32(new byte[] { 255, 0, 0, 0 }, 0);
        var CBlu = BitConverter.ToUInt32(new byte[] { 0, 255, 0, 0 }, 0);
        var n = new ShowPix(_All.pixDisplayHitMissSel(Pix, this, 1, CRed, CBlu));
    }
}
