using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// dewarp3.c (114, 1)
		// dewarpaApplyDisparity(dewa, pageno, pixs, grayin, x, y, ppixd, debugfile) as int
		// dewarpaApplyDisparity(L_DEWARPA *, l_int32, PIX *, l_int32, l_int32, l_int32, PIX **, const char *) as l_ok
		///  <summary>
		/// (1) This applies the disparity arrays to the specified image.<para/>
		///
		/// (2) Specify gray color for pixels brought in from the outside:
		/// 0 is black, 255 is white.  Use -1 to select pixels from the
		/// boundary of the source image.<para/>
		///
		/// (3) If the models and ref models have not been validated, this
		/// will do so by calling dewarpaInsertRefModels().<para/>
		///
		/// (4) This works with both stripped and full resolution page models.
		/// If the full res disparity array(s) are missing, they are remade.<para/>
		///
		/// (5) The caller must handle errors that are returned because there
		/// are no valid models or ref models for the page -- typically
		/// by using the input pixs.<para/>
		///
		/// (6) If there is no model for %pageno, this will use the model for
		/// 'refpage' and put the result in the dew for %pageno.<para/>
		///
		/// (7) This populates the full resolution disparity arrays if
		/// necessary.  If x and/or y are positive, they are used,
		/// in conjunction with pixs, to determine the required
		/// slope-based extension of the full resolution disparity
		/// arrays in each direction.  When (x,y) == (0,0), all
		/// extension is to the right and down.  Nonzero values of (x,y)
		/// are useful for dewarping when pixs is deliberately undercropped.<para/>
		///
		/// (8) Important: when applying disparity to a number of images,
		/// after calling this function and saving the resulting pixd,
		/// you should call dewarpMinimize(dew) on the dew for %pageno.
		/// This will remove pixs and pixd (or their clones) stored in dew,
		/// as well as the full resolution disparity arrays.  Together,
		/// these hold approximately 16 bytes for each pixel in pixs.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaApplyDisparity/*"/>
		///  <param name="dewa">[in] - </param>
		///  <param name="pageno">[in] - of page model to be used may be a ref model</param>
		///  <param name="pixs">[in] - image to be modified can be 1, 8 or 32 bpp</param>
		///  <param name="grayin">[in] - gray value, from 0 to 255, for pixels brought in use -1 to use pixels on the boundary of pixs</param>
		///  <param name="x">[in] - origin for generation of disparity arrays</param>
		///  <param name="y">[in] - origin for generation of disparity arrays</param>
		///  <param name="ppixd">[out] - disparity corrected image</param>
		///  <param name="debugfile">[in]use NULL to skip - writing this</param>
		///   <returns>0 if OK, 1 on error no models or ref models available</returns>
		public static int dewarpaApplyDisparity(
						L_Dewarpa dewa,
						int pageno,
						Pix pixs,
						int grayin,
						int x,
						int y,
						out Pix ppixd,
						String debugfile)
		{
			if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr ppixdPtr = IntPtr.Zero;
			int _Result = Natives.dewarpaApplyDisparity(dewa.Pointer,   pageno, pixs.Pointer,   grayin,   x,   y, out ppixdPtr,   debugfile);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			return _Result;
		}

		// dewarp3.c (537, 1)
		// dewarpaApplyDisparityBoxa(dewa, pageno, pixs, boxas, mapdir, x, y, pboxad, debugfile) as int
		// dewarpaApplyDisparityBoxa(L_DEWARPA *, l_int32, PIX *, BOXA *, l_int32, l_int32, l_int32, BOXA **, const char *) as l_ok
		///  <summary>
		/// (1) This applies the disparity arrays in one of two mapping directions
		/// to the specified boxa.  It can be used in the backward direction
		/// to locate a box in the original coordinates that would have
		/// been dewarped to to the specified image.<para/>
		///
		/// (2) If there is no model for %pageno, this will use the model for
		/// 'refpage' and put the result in the dew for %pageno.<para/>
		///
		/// (3) This works with both stripped and full resolution page models.
		/// If the full res disparity array(s) are missing, they are remade.<para/>
		///
		/// (4) If an error occurs, a copy of the input boxa is returned.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpaApplyDisparityBoxa/*"/>
		///  <param name="dewa">[in] - </param>
		///  <param name="pageno">[in] - of page model to be used may be a ref model</param>
		///  <param name="pixs">[in] - initial pix reference for alignment and debugging</param>
		///  <param name="boxas">[in] - boxa to be mapped</param>
		///  <param name="mapdir">[in] - 1 if mapping forward from original to dewarped 0 if backward</param>
		///  <param name="x">[in] - origin for generation of disparity arrays with respect to the source region</param>
		///  <param name="y">[in] - origin for generation of disparity arrays with respect to the source region</param>
		///  <param name="pboxad">[out] - disparity corrected boxa</param>
		///  <param name="debugfile">[in]use NULL to skip - writing this</param>
		///   <returns>0 if OK, 1 on error no models or ref models available</returns>
		public static int dewarpaApplyDisparityBoxa(
						L_Dewarpa dewa,
						int pageno,
						Pix pixs,
						Boxa boxas,
						int mapdir,
						int x,
						int y,
						out Boxa pboxad,
						String debugfile)
		{
			if (dewa == null) {throw new ArgumentNullException  ("dewa cannot be Nothing");}

			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr pboxadPtr = IntPtr.Zero;
			int _Result = Natives.dewarpaApplyDisparityBoxa(dewa.Pointer,   pageno, pixs.Pointer, boxas.Pointer,   mapdir,   x,   y, out pboxadPtr,   debugfile);
			if (pboxadPtr == IntPtr.Zero) {pboxad = null;} else { pboxad = new Boxa(pboxadPtr); };

			return _Result;
		}

		// dewarp3.c (729, 1)
		// dewarpMinimize(dew) as int
		// dewarpMinimize(L_DEWARP *) as l_ok
		///  <summary>
		/// (1) This removes all data that is not needed for serialization.
		/// It keeps the subsampled disparity array(s), so the full
		/// resolution arrays can be reconstructed.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpMinimize/*"/>
		///  <param name="dew">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int dewarpMinimize(
						L_Dewarp dew)
		{
			if (dew == null) {throw new ArgumentNullException  ("dew cannot be Nothing");}

			int _Result = Natives.dewarpMinimize(dew.Pointer);
			return _Result;
		}

		// dewarp3.c (785, 1)
		// dewarpPopulateFullRes(dew, pix, x, y) as int
		// dewarpPopulateFullRes(L_DEWARP *, PIX *, l_int32, l_int32) as l_ok
		///  <summary>
		/// (1) If the full resolution vertical and horizontal disparity
		/// arrays do not exist, they are built from the subsampled ones.<para/>
		///
		/// (2) If pixs is not given, the size of the arrays is determined
		/// by the original image from which the sampled version was
		/// generated.  Any values of (x,y) are ignored.<para/>
		///
		/// (3) If pixs is given, the full resolution disparity arrays must
		/// be large enough to accommodate it.
		/// (a) If the arrays do not exist, the value of (x,y) determines
		/// the origin of the full resolution arrays without extension,
		/// relative to pixs.  Thus, (x,y) gives the amount of
		/// slope extension in (left, top).  The (right, bottom)
		/// extension is then determined by the size of pixs and
		/// (x,y) the values should never be  is smaller 0.
		/// (b) If the arrays exist and pixs is too large, the existing
		/// full res arrays are destroyed and new ones are made,
		/// again using (x,y) to determine the extension in the
		/// four directions.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpPopulateFullRes/*"/>
		///  <param name="dew">[in] - </param>
		///  <param name="pix">[in][optional] - , to give size of actual image</param>
		///  <param name="x">[in] - origin for generation of disparity arrays</param>
		///  <param name="y">[in] - origin for generation of disparity arrays</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int dewarpPopulateFullRes(
						L_Dewarp dew,
						Pix pix,
						int x,
						int y)
		{
			if (dew == null) {throw new ArgumentNullException  ("dew cannot be Nothing");}

			IntPtr pixPtr = IntPtr.Zero; 	if (pix != null) {pixPtr = pix.Pointer;}
			int _Result = Natives.dewarpPopulateFullRes(dew.Pointer, pixPtr,   x,   y);
			return _Result;
		}


	}
}
