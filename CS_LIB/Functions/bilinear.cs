using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// bilinear.c (143, 1)
		// pixBilinearSampledPta(pixs, ptad, ptas, incolor) as Pix
		// pixBilinearSampledPta(PIX *, PTA *, PTA *, l_int32) as PIX *
		///  <summary>
		/// (1) Brings in either black or white pixels from the boundary.<para/>
		///
		/// (2) Retains colormap, which you can do for a sampled transform..<para/>
		///
		/// (3) No 3 of the 4 points may be collinear.<para/>
		///
		/// (4) For 8 and 32 bpp pix, better quality is obtained by the
		/// somewhat slower pixBilinearPta().  See that
		/// function for relative timings between sampled and interpolated.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearSampledPta/*"/>
		///  <param name="pixs">[in] - all depths</param>
		///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
		///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearSampledPta(
						Pix pixs,
						Pta ptad,
						Pta ptas,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinearSampledPta(pixs.Pointer, ptad.Pointer, ptas.Pointer,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (193, 1)
		// pixBilinearSampled(pixs, vc, incolor) as Pix
		// pixBilinearSampled(PIX *, l_float32 *, l_int32) as PIX *
		///  <summary>
		/// (1) Brings in either black or white pixels from the boundary.<para/>
		///
		/// (2) Retains colormap, which you can do for a sampled transform..<para/>
		///
		/// (3) For 8 or 32 bpp, much better quality is obtained by the
		/// somewhat slower pixBilinear().  See that function
		/// for relative timings between sampled and interpolated.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearSampled/*"/>
		///  <param name="pixs">[in] - all depths</param>
		///  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearSampled(
						Pix pixs,
						Single[] vc,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinearSampled(pixs.Pointer,   vc,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (286, 1)
		// pixBilinearPta(pixs, ptad, ptas, incolor) as Pix
		// pixBilinearPta(PIX *, PTA *, PTA *, l_int32) as PIX *
		///  <summary>
		/// (1) Brings in either black or white pixels from the boundary<para/>
		///
		/// (2) Removes any existing colormap, if necessary, before transforming
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearPta/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
		///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearPta(
						Pix pixs,
						Pta ptad,
						Pta ptas,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinearPta(pixs.Pointer, ptad.Pointer, ptas.Pointer,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (356, 1)
		// pixBilinear(pixs, vc, incolor) as Pix
		// pixBilinear(PIX *, l_float32 *, l_int32) as PIX *
		///  <summary>
		/// (1) Brings in either black or white pixels from the boundary<para/>
		///
		/// (2) Removes any existing colormap, if necessary, before transforming
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinear/*"/>
		///  <param name="pixs">[in] - all depths colormap ok</param>
		///  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
		///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinear(
						Pix pixs,
						Single[] vc,
						int incolor)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinear(pixs.Pointer,   vc,   incolor);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (412, 1)
		// pixBilinearPtaColor(pixs, ptad, ptas, colorval) as Pix
		// pixBilinearPtaColor(PIX *, PTA *, PTA *, l_uint32) as PIX *
		///  <summary>
		/// pixBilinearPtaColor()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearPtaColor/*"/>
		///  <param name="pixs">[in] - 32 bpp</param>
		///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
		///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
		///  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearPtaColor(
						Pix pixs,
						Pta ptad,
						Pta ptas,
						uint colorval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinearPtaColor(pixs.Pointer, ptad.Pointer, ptas.Pointer,   colorval);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (453, 1)
		// pixBilinearColor(pixs, vc, colorval) as Pix
		// pixBilinearColor(PIX *, l_float32 *, l_uint32) as PIX *
		///  <summary>
		/// pixBilinearColor()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearColor/*"/>
		///  <param name="pixs">[in] - 32 bpp</param>
		///  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
		///  <param name="colorval">[in] - e.g., 0 to bring in BLACK, 0xffffff00 for WHITE</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearColor(
						Pix pixs,
						Single[] vc,
						uint colorval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			IntPtr _Result = Natives.pixBilinearColor(pixs.Pointer,   vc,   colorval);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (515, 1)
		// pixBilinearPtaGray(pixs, ptad, ptas, grayval) as Pix
		// pixBilinearPtaGray(PIX *, PTA *, PTA *, l_uint8) as PIX *
		///  <summary>
		/// pixBilinearPtaGray()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearPtaGray/*"/>
		///  <param name="pixs">[in] - 8 bpp</param>
		///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
		///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
		///  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearPtaGray(
						Pix pixs,
						Pta ptad,
						Pta ptas,
						byte grayval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
			IntPtr _Result = Natives.pixBilinearPtaGray(pixs.Pointer, ptad.Pointer, ptas.Pointer,   grayval);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (556, 1)
		// pixBilinearGray(pixs, vc, grayval) as Pix
		// pixBilinearGray(PIX *, l_float32 *, l_uint8) as PIX *
		///  <summary>
		/// pixBilinearGray()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearGray/*"/>
		///  <param name="pixs">[in] - 8 bpp</param>
		///  <param name="vc">[in] - vector of 8 coefficients for bilinear transformation</param>
		///  <param name="grayval">[in] - 0 to bring in BLACK, 255 for WHITE</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearGray(
						Pix pixs,
						Single[] vc,
						byte grayval)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			if ((new List<int> {8}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("8 bpp"); }
			IntPtr _Result = Natives.pixBilinearGray(pixs.Pointer,   vc,   grayval);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (644, 1)
		// pixBilinearPtaWithAlpha(pixs, ptad, ptas, pixg, fract, border) as Pix
		// pixBilinearPtaWithAlpha(PIX *, PTA *, PTA *, PIX *, l_float32, l_int32) as PIX *
		///  <summary>
		/// (1) The alpha channel is transformed separately from pixs,
		/// and aligns with it, being fully transparent outside the
		/// boundary of the transformed pixs.  For pixels that are fully
		/// transparent, a blending function like pixBlendWithGrayMask()
		/// will give zero weight to corresponding pixels in pixs.<para/>
		///
		/// (2) If pixg is NULL, it is generated as an alpha layer that is
		/// partially opaque, using %fract.  Otherwise, it is cropped
		/// to pixs if required and %fract is ignored.  The alpha channel
		/// in pixs is never used.<para/>
		///
		/// (3) Colormaps are removed.<para/>
		///
		/// (4) When pixs is transformed, it doesn't matter what color is brought
		/// in because the alpha channel will be transparent (0) there.<para/>
		///
		/// (5) To avoid losing source pixels in the destination, it may be
		/// necessary to add a border to the source pix before doing
		/// the bilinear transformation.  This can be any non-negative number.<para/>
		///
		/// (6) The input %ptad and %ptas are in a coordinate space before
		/// the border is added.  Internally, we compensate for this
		/// before doing the bilinear transform on the image after
		/// the border is added.<para/>
		///
		/// (7) The default setting for the border values in the alpha channel
		/// is 0 (transparent) for the outermost ring of pixels and
		/// (0.5  fract  255) for the second ring.  When blended over
		/// a second image, this
		/// (a) shrinks the visible image to make a clean overlap edge
		/// with an image below, and
		/// (b) softens the edges by weakening the aliasing there.
		/// Use l_setAlphaMaskBorder() to change these values.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBilinearPtaWithAlpha/*"/>
		///  <param name="pixs">[in] - 32 bpp rgb</param>
		///  <param name="ptad">[in] - 4 pts of final coordinate space</param>
		///  <param name="ptas">[in] - 4 pts of initial coordinate space</param>
		///  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
		///  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
		///  <param name="border">[in] - of pixels added to capture transformed source pixels</param>
		///   <returns>pixd, or NULL on error</returns>
		public static Pix pixBilinearPtaWithAlpha(
						Pix pixs,
						Pta ptad,
						Pta ptas,
						Pix pixg,
						Single fract,
						int border)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			if ((new List<int> {32}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("32 bpp rgb"); }
			IntPtr pixgPtr = IntPtr.Zero; 	if (pixg != null) {pixgPtr = pixg.Pointer;}
			IntPtr _Result = Natives.pixBilinearPtaWithAlpha(pixs.Pointer, ptad.Pointer, ptas.Pointer, pixgPtr,   fract,   border);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// bilinear.c (776, 1)
		// getBilinearXformCoeffs(ptas, ptad, pvc) as int
		// getBilinearXformCoeffs(PTA *, PTA *, l_float32 **) as l_ok
		///  <summary>
		/// We have a set of 8 equations, describing the bilinear
		/// transformation that takes 4 points ptas into 4 other
		/// points ptad.  These equations are:
		/// x1' = c[0]x1 + c[1]y1 + c[2]x1y1 + c[3]
		/// y1' = c[4]x1 + c[5]y1 + c[6]x1y1 + c[7]
		/// x2' = c[0]x2 + c[1]y2 + c[2]x2y2 + c[3]
		/// y2' = c[4]x2 + c[5]y2 + c[6]x2y2 + c[7]
		/// x3' = c[0]x3 + c[1]y3 + c[2]x3y3 + c[3]
		/// y3' = c[4]x3 + c[5]y3 + c[6]x3y3 + c[7]
		/// x4' = c[0]x4 + c[1]y4 + c[2]x4y4 + c[3]
		/// y4' = c[4]x4 + c[5]y4 + c[6]x4y4 + c[7]
		/// This can be represented as
		/// AC = B
		/// where B and C are column vectors
		/// B = [ x1' y1' x2' y2' x3' y3' x4' y4' ]
		/// C = [ c[0] c[1] c[2] c[3] c[4] c[5] c[6] c[7] ]
		/// and A is the 8x8 matrix
		/// x1 y1 x1y1 1 0  0  0 0
		/// 0  0 0 0 x1 y1 x1y1 1
		/// x2 y2 x2y2 1 0  0  0 0
		/// 0  0 0 0 x2 y2 x2y2 1
		/// x3 y3 x3y3 1 0  0  0 0
		/// 0  0 0 0 x3 y3 x3y3 1
		/// x4 y4 x4y4 1 0  0  0 0
		/// 0  0 0 0 x4 y4 x4y4 1
		/// These eight equations are solved here for the coefficients C.
		/// These eight coefficients can then be used to find the mapping
		/// x,y) to (x',y':
		/// x' = c[0]x + c[1]y + c[2]xy + c[3]
		/// y' = c[4]x + c[5]y + c[6]xy + c[7]
		/// that are implemented in bilinearXformSampledPt and
		/// bilinearXFormPt.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getBilinearXformCoeffs/*"/>
		///  <param name="ptas">[in] - source 4 points unprimed</param>
		///  <param name="ptad">[in] - transformed 4 points primed</param>
		///  <param name="pvc">[out] - vector of coefficients of transform</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int getBilinearXformCoeffs(
						Pta ptas,
						Pta ptad,
						out List<Single[]> pvc)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			if (ptad == null) {throw new ArgumentNullException  ("ptad cannot be Nothing");}

			IntPtr pvcPtr = IntPtr.Zero;
			int _Result = Natives.getBilinearXformCoeffs(ptas.Pointer, ptad.Pointer, out  pvcPtr);
			if (pvcPtr == null) {pvc = null;} else { pvc = null; };

			return _Result;
		}

		// bilinear.c (869, 1)
		// bilinearXformSampledPt(vc, x, y, pxp, pyp) as int
		// bilinearXformSampledPt(l_float32 *, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This finds the nearest pixel coordinates of the transformed point.<para/>
		///
		/// (2) It does not check ptrs for returned data!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bilinearXformSampledPt/*"/>
		///  <param name="vc">[in] - vector of 8 coefficients</param>
		///  <param name="x">[in] - initial point</param>
		///  <param name="y">[in] - initial point</param>
		///  <param name="pxp">[out] - transformed point</param>
		///  <param name="pyp">[out] - transformed point</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int bilinearXformSampledPt(
						Single[] vc,
						int x,
						int y,
						out int pxp,
						out int pyp)
		{
			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			int _Result = Natives.bilinearXformSampledPt(  vc,   x,   y, out  pxp, out  pyp);
			return _Result;
		}

		// bilinear.c (902, 1)
		// bilinearXformPt(vc, x, y, pxp, pyp) as int
		// bilinearXformPt(l_float32 *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
		///  <summary>
		/// (1) This computes the floating point location of the transformed point.<para/>
		///
		/// (2) It does not check ptrs for returned data!
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bilinearXformPt/*"/>
		///  <param name="vc">[in] - vector of 8 coefficients</param>
		///  <param name="x">[in] - initial point</param>
		///  <param name="y">[in] - initial point</param>
		///  <param name="pxp">[out] - transformed point</param>
		///  <param name="pyp">[out] - transformed point</param>
		///   <returns>0 if OK 1 on error</returns>
		public static int bilinearXformPt(
						Single[] vc,
						int x,
						int y,
						out Single pxp,
						out Single pyp)
		{
			if (vc == null) {throw new ArgumentNullException  ("vc cannot be Nothing");}

			int _Result = Natives.bilinearXformPt(  vc,   x,   y, out  pxp, out  pyp);
			return _Result;
		}


	}
}
