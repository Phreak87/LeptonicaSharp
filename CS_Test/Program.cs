using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeptonicaSharp;

namespace TestAppCSharp
{
    class Program
    {
        private const string img1bpp = @"..\..\..\..\ALL_Images\Leptonica\feyn.tif";
        private const string img8bpp = @"..\..\..\..\ALL_Images\Leptonica\w91frag.jpg";
        private const string img24bpp = @"..\..\..\..\ALL_Images\Leptonica\zanotti-78.jpg";
        private const string img32bpp = @"..\..\..\..\ALL_Images\Leptonica\books_logo.png";
        private const string cat007 = @"..\..\..\..\ALL_Images\Leptonica\cat.007.jpg";

        static void Main(string[] args)
        {
            Natives.Initialize();
            _All.setLeptDebugOK(1);

            var app = new Program();
            //app.TestBitmapAccess(img1bpp);
            //app.TestpixGetRegionsBinary(img1bpp);
            app.TestProjections(img1bpp);
        }

        private void TestBitmapAccess(string pixfn)
        {
            var pixs = new Pix(pixfn);
            var bmp = pixs.ToBitmap();
            var bmp2 = pixs.BitmapStatic;
        }

        private void TestpixGetRegionsBinary(string pixfn)
        {
            var pixa = _All.pixaCreate(0);
            var pixs = new Pix(pixfn);
            _All.pixGetRegionsBinary(pixs, out Pix ppixhm, out Pix ppixtm, out Pix ppixtb, pixa);
            WriteAllPixaImages(ref pixa, "regions");
        }

        private Pix BinarizeWithSauvola(Pix pixs)
        {
            var pixGray = _All.pixConvertTo8(pixs, 0);
            var retVal = _All.pixSauvolaBinarize(pixGray, 7, 0.25f, 0, out Pix ppixm, out Pix ppixsd, out Pix ppixth, out Pix pixBinary);
            _All.pixDestroy(ref ppixm);
            _All.pixDestroy(ref ppixsd);
            _All.pixDestroy(ref ppixth);
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
                var pxByCol = _All.pixCountPixelsByColumn(pixBinary);
                var pxByRow = _All.pixCountPixelsByRow(pixBinary, null);
                var colProjections = pxByCol.array;
                var rowProjections = pxByRow.array;
            }
        }

        #region [ Helper Methods ]
        private void WriteAllPixaImages(ref Pixa pixa, string prefix)
        {
            var n = _All.pixaGetCount(pixa);
            for (int i = 0; i < n; i++)
            {
                var pix1 = _All.pixaGetPix(pixa, i, LeptonicaSharp.Enumerations.L_access_storage.L_CLONE);
                var fn = $"{prefix}-{i.ToString().PadLeft(2, '0')}.png";
                pix1.save_format(fn, LeptonicaSharp.Enumerations.IFF.IFF_PNG);
                _All.pixDestroy(ref pix1);
            }
        }
        #endregion
    }
}
