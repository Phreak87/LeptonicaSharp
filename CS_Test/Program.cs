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
        private const string img1bpp = @"..\..\..\..\TestImages\feyn.tif";
        private const string img8bpp = @"..\..\..\..\TestImages\w91frag.jpg";
        private const string img24bpp = @"..\..\..\..\TestImages\zanotti-78.jpg";
        private const string img32bpp = @"..\..\..\..\TestImages\books_logo.png";
        private const string cat007 = @"..\..\..\..\TestImages\cat.007.jpg";

        static void Main(string[] args)
        {
            Natives.Initialize();
            _All.setLeptDebugOK(1);
            var pix = new Pix(img1bpp);
            var a = pix.Bitmap;
            var b = pix.ToBitmap();
            var c = pix.Convert();
            var pixa = _All.pixaCreate(0);
            _All.pixGetRegionsBinary(pix, out Pix ppixhm, out Pix ppixtm, out Pix ppixtb, pixa);
            var b1 = ppixhm.Bitmap;
            var b2 = ppixtm.Bitmap;
            var b3 = ppixtb.Bitmap;
            WriteAllPixaImages(ref pixa, "regions");
        }

        private static void WriteAllPixaImages(ref Pixa pixa, string prefix)
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
    }
}
