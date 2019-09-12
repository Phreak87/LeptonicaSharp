using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using static LeptonicaSharp._All;

namespace TestAppCSharp
{
    internal class Program
    {
        private const string img1bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\feyn.tif";
        private const string img8bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\w91frag.jpg";
        private const string img24bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\zanotti-78.jpg";
        private const string img32bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\books_logo.png";
        private const string cat007 = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\cat.007.jpg";
        private const string carplate = @"..\..\..\..\CHM_Help\ExampleImages\input\ca03pers.png";

        private static void Main(string[] args)
        {
            //Natives.Initialize();
            setLeptDebugOK(1);

            var app = new Program();
            //app.TestpixGetRegionsBinary(img1bpp);
            //app.TestProjections(img1bpp);
            //app.OtsuTest2(carplate);
            app.TestProjectionsOnImage(carplate);
            //app.TestArrayFunctions();
            //app.TestCCBorder(img1bpp);
            //app.TestBitmap();
            //app.TestMarkusByteA();
            //app.FindForeground();
            //app.Sel();
            //app.BinaryWrite();
            //app.MemoryCheck();
        }

        private void MemoryCheck()
        {
            //var ta = new byte[1000];
            //for (int i = 0; i < ta.Length; i++)
            //{
            //    ta[i] = (byte)(i + 100);
            //}
            //Array.Clear(ta, 0, ta.Length);
            //ta = null;
            //GC.Collect();

            var pix = new Pix(carplate);
            //var bs = pix.BitmapStatic;
            //var p1 = AddHelper.AddressOf(pix);
            //var c1 = AddHelper.AddressOf(pix.colormap);
            //var c2 = AddHelper.AddressOf(pix.colormap.Values.array);
            pix.colormap.Dispose();

            //for (int i = 0; i < 100000; i++)
            //{
            //    var b = pix.colormap.Array_Bytes;
            //    if (i % 10000 == 0)
            //    {
            //        System.Threading.Thread.Sleep(1000);
            //        GC.Collect();
            //    }
            //}

            //var pw = AddHelper.AddressOf(pix.w);
            //var pwv = AddHelper.AddressOf(pix.Values.w);
            //var ph = AddHelper.AddressOf(pix.h);
            //var phv = AddHelper.AddressOf(pix.Values.h);
            //var pd = AddHelper.AddressOf(pix.d);
            //var pdv = AddHelper.AddressOf(pix.Values.d);
            //var pspp = AddHelper.AddressOf(pix.spp);
            //var psppv = AddHelper.AddressOf(pix.Values.spp);
            //var pwpl = AddHelper.AddressOf(pix.wpl);
            //var pwplv = AddHelper.AddressOf(pix.Values.wpl);
            //var prefcount = AddHelper.AddressOf(pix.refcount);
            //var prefcountv = AddHelper.AddressOf(pix.Values.refcount);
            //var pxres = AddHelper.AddressOf(pix.xres);
            //var pxresv = AddHelper.AddressOf(pix.Values.xres);
            //var pyres = AddHelper.AddressOf(pix.yres);
            //var pyresv = AddHelper.AddressOf(pix.Values.yres);
            //var pinformat = AddHelper.AddressOf(pix.informat);
            //var pinformatv = AddHelper.AddressOf(pix.Values.informat);
            //var pspecial = AddHelper.AddressOf(pix.special);
            //var pspecialv = AddHelper.AddressOf(pix.Values.special);

            //var ptext = AddHelper.AddressOf(pix.text);
            //var ptextv = AddHelper.AddressOf(pix.Values.text);
            //var pcolormap = AddHelper.AddressOf(pix.colormap);
            //var pcolormapv = AddHelper.AddressOf(pix.Values.colormap);
            //var pcolormapp = AddHelper.AddressOf(pix.colormap.Pointer);
            //var pcolormapa = AddHelper.AddressOf(pix.colormap.array);
            //var pcolormapva = AddHelper.AddressOf(pix.colormap.Values.array);
            //var pdata = AddHelper.AddressOf(pix.data);
            //var pdatav = AddHelper.AddressOf(pix.Values.data);

            pixDestroy(ref pix);

        }

        private void BinaryWrite()
        {
            var pix = new Pix(carplate);
            l_binaryWrite("Test", "w", pix, (uint)pix.data.Length);
        }

        private void Sel()
        {
            const string sel_4_1 = "  x" +
                                   "oCx" +
                                   "  x";
            var sel41 = selCreateFromString(sel_4_1, 3, 3, "sel_4_1");
            var sel = selCreate(3, 3, "height");
        }

        private void FindForeground()
        {
            var pixs = new Pix(img24bpp);
            var pixac = pixacompCreate(10);
            var box = pixFindPageForeground(pixs, 128, 70, 25, 0, pixac);
            box.Display(pixs);
            //Pixcomp.pixacompWrite("pixcomp.txt", pixac);
            pixacompConvertToPdf(pixac, 300, 1.0f, (int)Enumerations.L_ENCODE.L_JPEG_ENCODE, 100, "PixaComp", "pixacomp.pdf");
            for (int i = 0; i < pixac.n; i++)
            {
                var pix = pixacompGetPix(pixac, i);
                var fn = $"pixacomp-{i.ToString().PadLeft(2, '0')}.png";
                pixWrite(fn, pix, Enumerations.IFF.IFF_PNG);
                pixDestroy(ref pix);
            }
        }

        private void TestMarkusByteA()
        {
            var x1 = new L_Bytea(new byte[] { 1, 2, 3 }, 3);
            var x2 = new L_Bytea(new byte[] { 4, 5, 6 }, 3);
            var o = l_byteaJoin(x1, ref x2);
        }

        private void TestBitmap()
        {
            var im1bpp = new Pix(img1bpp);
            //im1bpp.Display();
            var im1bppBmp = im1bpp.BitmapStatic;

            var im8bpp = new Pix(img8bpp);
            var im8bppBmp = im8bpp.BitmapStatic;

            var im24bpp = new Pix(img24bpp);
            var im24bppBmp = im24bpp.BitmapStatic;

            var im32bpp = new Pix(img32bpp);
            var im32bppBmp = im32bpp.BitmapStatic;
        }

        private void TestCCBorder(string pixfn)
        {
            var pixs = new Pix(pixfn);
            //var data = pixs.data;
            //var cm = pixs.colormap;
            //var tx = pixs.text;
            var ccba = pixGetAllCCBorders(pixs);
        }

        private void TestArrayFunctions()
        {
            var feyn = Path.GetFullPath(@"..\..\..\..\CHM_Help\ExampleImages\Leptonica\feyn.tif");
            var test24 = Path.GetFullPath(@"..\..\..\..\CHM_Help\ExampleImages\Leptonica\test24.jpg");

            var lba1 = l_byteaInitFromFile(feyn);
            var lba2 = l_byteaInitFromFile(test24);
            var size1 = l_byteaGetSize(lba1);
            var size2 = l_byteaGetSize(lba2);
            l_byteaJoin(lba1, ref lba2);
            var lba3 = l_byteaInitFromMem(lba1.data, size1);
            //var lba4 = l_byteaInitFromMem(lba1.data + size1, size2)
            var lba4 = l_byteaInitFromMem(lba1.data.Skip((int)size1).ToArray(), size2);

            l_binaryWrite("junk1.dat", "w", lba3.data, lba3.size);
            l_binaryWrite("junk2.dat", "w", lba4.data, lba4.size);
            filesAreIdentical(feyn, "junk1.dat", out int psame1);
            filesAreIdentical(test24, "junk2.dat", out int psame2);
        }

        private void TestProjectionsOnImage(string pixfn)
        {
            var pixs = new Pix(pixfn);
            Pix pixBinary = default;
            if (pixs.d > 1)
            {
                //pixBinary = BinarizeWithSauvola(pixs);
                pixBinary = BinarizeWithModifiedOtsu(pixs);
            }
            else
                pixBinary = pixs;

            int[] rowProjections = null;
            int[] colProjections = null;
            if (pixBinary != null)
            {
                var pxByCol = pixCountPixelsByColumn(pixBinary);
                var pxByRow = pixCountPixelsByRow(pixBinary, null);
                colProjections = Array.ConvertAll(pxByCol.array, x => (int)x);
                rowProjections = Array.ConvertAll(pxByRow.array, x => (int)x);

                // Markus' functions
                //var px1 = pxByCol.DisplayNumaBarGraph(pxByCol, pixBinary, false);
                //var px1a = pxByCol.DisplayNumaBarGraph(pxByCol, pixBinary, true);
                //var px1b = pxByCol.DisplayNumaBarGraph(NumaH: null, BgPix: pixBinary, false);
                //var px1c = pxByCol.DisplayNumaBarGraph(NumaH: null, BgPix: pixBinary, true);

                //var px3 = pxByCol.DisplayNumaHeatmap(pxByCol, pixBinary, false);
                //var px4 = pxByCol.DisplayNumaHeatmap(pxByRow, pixBinary, true);
                //var px5 = pxByCol.DisplayNumaHeatmap(NumaH: null, BgPix: pixBinary, false);
                //var px6 = pxByCol.DisplayNumaHeatmap(NumaH: null, BgPix: pixBinary, true);

                var px1 = pxByCol.DisplayProjectionsOnPix(pixBinary);
                var px2 = pxByRow.DisplayProjectionsOnPix(pixBinary);
                var px3 = pxByCol.DisplayProjectionsOnPix(pixBinary, pxByRow);
                var px4 = pxByRow.DisplayProjectionsOnPix(pixBinary, pxByCol);
            }

            const float wRatio = 1 / 5f;
            const float hRatio = 1 / 5f;
            var width = (int)pixs.w;
            var height = (int)pixs.h;
            var widthR = (int)(width * wRatio);
            var heightR = (int)(height * hRatio);

            var vBmp = new System.Drawing.Bitmap(widthR, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            vBmp.SetResolution(pixs.xres, pixs.yres);

            using (var g = System.Drawing.Graphics.FromImage(vBmp))
            {
                g.Clear(System.Drawing.Color.White);
                for (int i = 0; i < rowProjections.Length; i++)
                {
                    var pt1 = new System.Drawing.Point(0, i);
                    var normalizex = (int)(rowProjections[i] * wRatio);
                    var pt2 = new System.Drawing.Point(normalizex, i);
                    g.DrawLine(System.Drawing.Pens.Black, pt1, pt2);
                }
            }

            var hBmp = new System.Drawing.Bitmap(width, heightR, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            hBmp.SetResolution(pixs.xres, pixs.yres);
            using (var g = System.Drawing.Graphics.FromImage(hBmp))
            {
                g.Clear(System.Drawing.Color.White);
                for (int i = 0; i < colProjections.Length; i++)
                {
                    var pt1 = new System.Drawing.Point(i, height);
                    var normalizey = (int)(colProjections[i] * hRatio);
                    var pt2 = new System.Drawing.Point(i, heightR - normalizey);
                    g.DrawLine(System.Drawing.Pens.Black, pt1, pt2);
                }
            }

            var outBmp = new System.Drawing.Bitmap(width + vBmp.Width, height + hBmp.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            outBmp.SetResolution(pixs.xres, pixs.yres);
            using (var g = System.Drawing.Graphics.FromImage(outBmp))
            {
                g.Clear(System.Drawing.Color.White);
                g.DrawImage(vBmp, 0, 0);
                g.DrawImage(pixs.BitmapStatic, vBmp.Width, 0);
                //g.DrawImage(System.Drawing.Image.FromFile(pixfn), vBmp.Width, 0);
                g.DrawImage(hBmp, vBmp.Width, height);
            }
        }

        private void TestpixGetRegionsBinary(string pixfn)
        {
            var pixa = pixaCreate(0);
            var pixs = new Pix(pixfn);
            pixGetRegionsBinary(pixs, out Pix ppixhm, out Pix ppixtm, out Pix ppixtb, pixa);
            WriteAllPixaImages(ref pixa, "regions");
            pixDestroy(ref ppixhm);
            pixDestroy(ref ppixtm);
            pixDestroy(ref ppixtb);
            pixaDestroy(ref pixa);
        }

        private Pix BinarizeWithModifiedOtsu(Pix pixs)
        {
            var pixg = pixConvertTo8(pixs, 0);
            var scorefract = 0.1f;
            pixOtsuAdaptiveThreshold(pixg, 2000, 2000, 0, 0, scorefract, out Pix ppixth, out Pix pixb);
            pixDestroy(ref ppixth);
            return pixb;
        }

        private Pix BinarizeWithModifiedOtsu(string pixfn)
        {
            var pixs = new Pix(pixfn);
            var pixg = pixConvertTo8(pixs, 0);
            var scorefract = 0.1f;
            pixOtsuAdaptiveThreshold(pixg, 2000, 2000, 0, 0, scorefract, out Pix ppixth, out Pix pixb);
            pixDestroy(ref ppixth);
            return pixb;
        }

        private void OtsuTest2(string pixfn)
        {
            // Test ported from prog/otsutest2.c

            var pixs = new Pix(pixfn);
            var pixg = pixConvertTo8(pixs, 0);
            var bmf = bmfCreate(null, 8);
            var pixad = pixaCreate(0);
            for (int i = 0; i < 3; i++)
            {
                var pixa1 = pixaCreate(2);
                var scorefract = 0.1f * i;
                pixOtsuAdaptiveThreshold(pixg, 2000, 2000, 0, 0, scorefract, out Pix ppixth, out Pix pixb);
                pixDestroy(ref ppixth);
                pixSaveTiledOutline(pixb, pixa1, 0.5f, 1, 20, 2, 32);
                pixSplitDistributionFgBg(pixg, scorefract, 1, out int thresh, out int fgval, out int bgval, out Pix pixp);
                Console.WriteLine($"Thresh = {thresh} fgval = {fgval} bgval = {bgval}");
                pixSaveTiled(pixp, pixa1, 1.0f, 0, 20, 1);
                var pix1 = pixaDisplay(pixa1, 0, 0);
                var textstr = $"Scorefract = {scorefract} Thresh = {thresh}";
                var pix2 = pixAddSingleTextblock(pix1, bmf, textstr, 0x00ff0000, (int)Enumerations.L_ADD.L_ADD_BELOW, out int poverflow);
                pixaAddPix(pixad, pix2, (int)Enumerations.L_access_storage.L_INSERT);
                textstr = $"otsu-{i.ToString().PadLeft(3, '0')}.png";
                pixWrite(textstr, pix2, Enumerations.IFF.IFF_PNG);
                pixDisplay(pix2, 100, 100);
                pixDestroy(ref pixb);
                pixDestroy(ref pixp);
                pixDestroy(ref pix1);
                pixaDestroy(ref pixa1);
            }

            for (int i = 0; i < 2; i++)
            {
                var scorefract = 0.1f * i;
                pixOtsuAdaptiveThreshold(pixg, 300, 300, 0, 0, scorefract, out Pix ppixth, out Pix pixb);
                var pix1 = pixAddBlackOrWhiteBorder(pixb, 2, 2, 2, 2, (int)Enumerations.L_GET_VAL.L_GET_BLACK_VAL);
                pixDestroy(ref ppixth);
                var pix2 = pixScale(pix1, 0.5f, 0.5f);
                var textstr = $"Scorefract = {scorefract}";
                var pix3 = pixAddSingleTextblock(pix2, bmf, textstr, 1, (int)Enumerations.L_ADD.L_ADD_BELOW, out int poverflow);
                pixaAddPix(pixad, pix3, (int)Enumerations.L_access_storage.L_INSERT);
                pixDestroy(ref pixb);
                pixDestroy(ref pix1);
                pixDestroy(ref pix2);
            }

            pixaConvertToPdf(pixad, 75, 1.0f, (int)Enumerations.L_ENCODE.L_DEFAULT_ENCODE, 100, string.Empty, "result1.pdf");
            bmfDestroy(ref bmf);
            pixDestroy(ref pixs);
            pixDestroy(ref pixg);
            pixaDestroy(ref pixad);
        }

        private Pix BinarizeWithSauvola(Pix pixs)
        {
            var pixGray = pixConvertTo8(pixs, 0);
            var retVal = pixSauvolaBinarize(pixGray, 7, 0.25f, 0, out Pix ppixm, out Pix ppixsd, out Pix ppixth, out Pix pixBinary);
            pixDestroy(ref ppixm);
            pixDestroy(ref ppixsd);
            pixDestroy(ref ppixth);
            if (retVal == 0)
                return pixBinary;
            else
                return null;
        }

        private void TestProjections(string pixfn)
        {
            // This method creates Row and Column Projections
            // also known as Horizontal and Vertical Histograms

            var pixs = new Pix(pixfn);
            Pix pixBinary = default;
            if (pixs.d > 1)
                pixBinary = BinarizeWithSauvola(pixs);
            else
                pixBinary = pixs;

            if (pixBinary != null)
            {
                var pxByCol = pixCountPixelsByColumn(pixBinary);
                var pxByRow = pixCountPixelsByRow(pixBinary, null);
                var colProjections = pxByCol.array;
                var rowProjections = pxByRow.array;
            }
        }

        #region [ Helper Methods ]

        private void WriteAllPixaImages(ref Pixa pixa, string prefix)
        {
            var n = pixaGetCount(pixa);
            for (int i = 0; i < n; i++)
            {
                var pix1 = pixaGetPix(pixa, i, Enumerations.L_access_storage.L_CLONE);
                var fn = $"{prefix}-{i.ToString().PadLeft(2, '0')}.png";
                pix1.save_format(fn, Enumerations.IFF.IFF_PNG);
                pixDestroy(ref pix1);
            }
        }

        #endregion
    }

    public static class Extensions
    {
        public static int save_format(this Pix pixs, string filename, Enumerations.IFF format)
        {
            return pixWrite(filename, pixs, format);
        }

        /// <summary>
        /// Draw projection histogram on Pix.
        /// </summary>
        /// <param name="numa">First Numa. Either column projection or row projection</param>
        /// <param name="pixs">The Pix for the background</param>
        /// <param name="otherNuma">If supplied, also draw the "other" numa histogram.
        /// This should be the opposite direction of the one supplied as the first parameter.
        /// E.G. If first parameter is Row projection, this should be the Col projection and vice versa.</param>
        /// <returns></returns>
        public static Pix DisplayProjectionsOnPix(this Numa numa, Pix pixs, Numa otherNuma = null)
        {
            try
            {
                var w = (int)pixs.w;
                var h = (int)pixs.h;
                var rows = numa.n == h ? true : false;
                var cols = numa.n == w ? true : false;
                float rowsRatio = 0.0f, colsRatio = 0.0f;
                var numamax = numa.array.Max();
                var otherNumaMax = otherNuma != null ? otherNuma.array.Max() : 0.0f;

                if (rows)
                {
                    // Normalize so we stretch rows to max
                    rowsRatio = h > 0 ? numamax / h : 1;
                    if (otherNuma != null)
                        colsRatio = otherNumaMax > 0 ? w / otherNumaMax : 1;
                }
                else if (cols)
                {
                    // Normalize so we stretch cols to max
                    colsRatio = numamax > 0 ? w / numamax : 1;
                    if (otherNuma != null)
                        rowsRatio = h > 0 ? otherNumaMax / h : 1;
                }

                using (var pen1 = new Pen(Color.FromArgb(150, 0, 255, 0), 1.0f))
                using (var pen2 = new Pen(Color.FromArgb(150, 255, 0, 0), 1.0f))
                using (var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
                {
                    bmp.SetResolution(pixs.xres, pixs.yres);
                    using (var g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(pixs.BitmapStatic, new Point(0, 0));
                        if (rows)
                        {
                            for (int i = 0; i < numa.n; i++)
                            {
                                var pt1 = new PointF(0, i);
                                var width = numa.array[i] * rowsRatio;
                                var pt2 = new PointF(width, i);
                                g.DrawLine(pen1, pt1, pt2);
                            }
                            if (otherNuma != null)
                            {
                                for (int i = 0; i < otherNuma.n; i++)
                                {
                                    var pt1 = new PointF(i, h);
                                    var height = h - otherNuma.array[i] * colsRatio;
                                    var pt2 = new PointF(i, height);
                                    g.DrawLine(pen2, pt1, pt2);
                                }
                            }
                        }
                        else if (cols)
                        {
                            for (int i = 0; i < numa.n; i++)
                            {
                                var pt1 = new PointF(i, h);
                                var height = h - numa.array[i] * colsRatio;
                                var pt2 = new PointF(i, height);
                                g.DrawLine(pen2, pt1, pt2);
                            }
                            if (otherNuma != null)
                            {
                                for (int i = 0; i < otherNuma.n; i++)
                                {
                                    var pt1 = new PointF(0, i);
                                    var width = otherNuma.array[i] * rowsRatio;
                                    var pt2 = new PointF(width, i);
                                    g.DrawLine(pen1, pt1, pt2);
                                }
                            }
                        }
                    }
                    return new Pix(bmp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }

    public unsafe static class AddHelper
    {
        public unsafe static IntPtr AddressOf(object obj)
        {
            if (obj == null)
                return System.IntPtr.Zero;

            TypedReference reference = __makeref(obj);
            TypedReference* pRef = &reference;
            var ret = (IntPtr)pRef;

            return **(IntPtr**)(&reference);
        }

        public unsafe static IntPtr AddressOf<T>(T t)
        {
            TypedReference reference = __makeref(t);
            TypedReference* pRef = &reference;
            var ret = (IntPtr)pRef;

            return **(IntPtr**)(&reference);
        }

        static unsafe IntPtr AddressOfRef<T>(ref T t)
        {
            TypedReference reference = __makeref(t);
            TypedReference* pRef = &reference;
            var ret = (IntPtr)pRef;

            return **(IntPtr**)(&reference);
        }
        public unsafe static IntPtr AddressOfByteArray(byte[] array)
        {
            if (array == null)
                return System.IntPtr.Zero;

            fixed (byte* ptr = array)
                return (IntPtr)(ptr - 2 * sizeof(void*)); //Todo staticaly determine size of void?
        }
    }
}
