using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeptonicaSharp;
using static LeptonicaSharp._All;

namespace TestAppCSharp
{
    class Program
    {
        private const string img1bpp =  @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\feyn.tif";
        private const string img8bpp =  @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\w91frag.jpg";
        private const string img24bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\zanotti-78.jpg";
        private const string img32bpp = @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\books_logo.png";
        private const string cat007 =   @"..\..\..\..\CHM_Help\ExampleImages\Leptonica\cat.007.jpg";
        private const string carplate = @"..\..\..\..\CHM_Help\ExampleImages\input\ca03pers.png";

        static void Main(string[] args)
        {
            //Natives.Initialize();
            setLeptDebugOK(1);

            var app = new Program();
            //app.TestBitmapAccess(img1bpp);
            //app.TestpixGetRegionsBinary(img1bpp);
            //app.TestProjections(img1bpp);
            //app.OtsuTest2(carplate);
            //app.TestProjectionsOnImage(carplate);
            //app.TestArrayFunctions();
            //app.TestCCBorder(img1bpp);
            app.TestBitmap();
        }

        private void TestBitmap()
        {
            var im1bpp = new Pix(img1bpp);
            var im1bbpBmp = Pix.Convert(im1bpp);

            var im8bpp = new Pix(img8bpp);
            var im8bppBmp = Pix.Convert(im8bpp);

            var im24bpp = new Pix(img24bpp);
            var im24bppBmp = Pix.Convert(im24bpp);

            var im32bpp = new Pix(img32bpp);
            var im32bppBmp = Pix.Convert(im32bpp, true);
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
                //g.DrawImage(pixs.BitmapStatic, vBmp.Width, 0);
                g.DrawImage(System.Drawing.Image.FromFile(pixfn), vBmp.Width, 0);
                g.DrawImage(hBmp, vBmp.Width, height);
            }
        }

        //private void TestBitmapAccess(string pixfn)
        //{
        //    var pixs = new Pix(pixfn);
        //    var bmp = pixs.ToBitmap();
        //    var bmp2 = pixs.BitmapStatic;
        //}

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
                var pix1 = pixaGetPix(pixa, i, (int)Enumerations.L_access_storage.L_CLONE);
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

    }
}
