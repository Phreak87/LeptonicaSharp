using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// edge.c (91, 1)
		// pixSobelEdgeFilter(pixs, orientflag) as Pix
		// pixSobelEdgeFilter(PIX *, l_int32) as PIX *
		///  <summary>
		/// (1) Invert pixd to see larger gradients as darker (grayscale).<para/>
		///
		/// (2) To generate a binary image of the edges, threshold
		/// the result using pixThresholdToBinary().  If the high
		/// edge values are to be fg (1), invert after running
		/// pixThresholdToBinary().<para/>
		///
		/// (3) Label the pixels as follows:
		/// 1  4  7
		/// 2  5  8
		/// 3  6  9
		/// Read the data incrementally across the image and unroll
		/// the loop.<para/>
		///
		/// (4) This runs at about 45 Mpix/sec on a 3 GHz processor.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSobelEdgeFilter/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///  <param name="orientflag">[in] - L_HORIZONTAL_EDGES, L_VERTICAL_EDGES, L_ALL_EDGES</param>
		///   <returns>pixd 8 bpp, edges are brighter, or NULL on error</returns>
		public static Pix pixSobelEdgeFilter(
						Pix pixs,
						int orientflag)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixSobelEdgeFilter(pixs.Pointer,   orientflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// edge.c (199, 1)
		// pixTwoSidedEdgeFilter(pixs, orientflag) as Pix
		// pixTwoSidedEdgeFilter(PIX *, l_int32) as PIX *
		///  <summary>
		/// (1) For detecting vertical edges, this considers the
		/// difference of the central pixel from those on the left
		/// and right.  For situations where the gradient is the same
		/// sign on both sides, this computes and stores the minimum
		/// (absolute value of the) difference.  The reason for
		/// checking the sign is that we are looking for pixels within
		/// a transition.  By contrast, for single pixel noise, the pixel
		/// value is either larger than or smaller than its neighbors,
		/// so the gradient would change direction on each side.  Horizontal
		/// edges are handled similarly, looking for vertical gradients.<para/>
		///
		/// (2) To generate a binary image of the edges, threshold
		/// the result using pixThresholdToBinary().  If the high
		/// edge values are to be fg (1), invert after running
		/// pixThresholdToBinary().<para/>
		///
		/// (3) This runs at about 60 Mpix/sec on a 3 GHz processor.
		/// It is about 30% faster than Sobel, and the results are
		/// similar.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTwoSidedEdgeFilter/*"/>
		///  <param name="pixs">[in] - 8 bpp no colormap</param>
		///  <param name="orientflag">[in] - L_HORIZONTAL_EDGES, L_VERTICAL_EDGES</param>
		///   <returns>pixd 8 bpp, edges are brighter, or NULL on error</returns>
		public static Pix pixTwoSidedEdgeFilter(
						Pix pixs,
						int orientflag)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixTwoSidedEdgeFilter(pixs.Pointer,   orientflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// edge.c (309, 1)
		// pixMeasureEdgeSmoothness(pixs, side, minjump, minreversal, pjpl, pjspl, prpl, debugfile) as int
		// pixMeasureEdgeSmoothness(PIX *, l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *, const char *) as l_ok
		///  <summary>
		/// (1) This computes three measures of smoothness of the edge of a
		/// connected component:
		/// jumps/length: (jpl) the number of jumps of size greater or equal %minjump,
		/// normalized to the length of the side
		/// jump sum/length: (jspl) the sum of all jump lengths of
		/// size greater or equal %minjump, normalized to the length of the side
		/// reversals/length: (rpl) the number of peak  is smallerto valley
		/// reversals, using %minreverse as a minimum deviation of
		/// the peak or valley from its preceding extremum,
		/// normalized to the length of the side<para/>
		///
		/// (2) The input pix should be a single connected component, but
		/// this is not required.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMeasureEdgeSmoothness/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="side">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
		///  <param name="minjump">[in] - minimum jump to be counted greater or equal 1</param>
		///  <param name="minreversal">[in] - minimum reversal size for new peak or valley</param>
		///  <param name="pjpl">[out][optional] - jumps/length: number of jumps, normalized to length of component side</param>
		///  <param name="pjspl">[out][optional] - jumpsum/length: sum of all sufficiently large jumps, normalized to length of component side</param>
		///  <param name="prpl">[out][optional] - reversals/length: number of peak-to-valley or valley-to-peak reversals, normalized to length of component side</param>
		///  <param name="debugfile">[in][optional] - displays constructed edge use NULL for no output</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixMeasureEdgeSmoothness(
						Pix pixs,
						int side,
						int minjump,
						int minreversal,
						out Single pjpl,
						out Single pjspl,
						out Single prpl,
						String debugfile)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			int _Result = Natives.pixMeasureEdgeSmoothness(pixs.Pointer,   side,   minjump,   minreversal, out  pjpl, out  pjspl, out  prpl,   debugfile);
			return _Result;
		}

		// edge.c (386, 1)
		// pixGetEdgeProfile(pixs, side, debugfile) as Numa
		// pixGetEdgeProfile(PIX *, l_int32, const char *) as NUMA *
		///  <summary>
		/// pixGetEdgeProfile()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetEdgeProfile/*"/>
		///  <param name="pixs">[in] - 1 bpp</param>
		///  <param name="side">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
		///  <param name="debugfile">[in][optional] - displays constructed edge use NULL for no output</param>
		///   <returns>na of fg edge pixel locations, or NULL on error</returns>
		public static Numa pixGetEdgeProfile(
						Pix pixs,
						int side,
						String debugfile)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if ((new List<int> {1}).Contains ((int)pixs.d) == false) { throw new ArgumentException ("1 bpp"); }
			IntPtr _Result = Natives.pixGetEdgeProfile(pixs.Pointer,   side,   debugfile);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Numa(_Result);
		}

		// edge.c (515, 1)
		// pixGetLastOffPixelInRun(pixs, x, y, direction, ploc) as int
		// pixGetLastOffPixelInRun(PIX *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetLastOffPixelInRun/*"/>
		///   <returns></returns>
		public static int pixGetLastOffPixelInRun(
						Pix pixs,
						int x,
						int y,
						int direction,
						object ploc)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ploc == null) {throw new ArgumentNullException  ("ploc cannot be Nothing");}

			IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}
			int _Result = Natives.pixGetLastOffPixelInRun(pixs.Pointer,   x,   y,   direction,   ploc);
			return _Result;
		}

		// edge.c (587, 1)
		// pixGetLastOnPixelInRun(pixs, x, y, direction, ploc) as int
		// pixGetLastOnPixelInRun(PIX *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetLastOnPixelInRun/*"/>
		///   <returns></returns>
		public static int pixGetLastOnPixelInRun(
						Pix pixs,
						int x,
						int y,
						int direction,
						object ploc)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			if (ploc == null) {throw new ArgumentNullException  ("ploc cannot be Nothing");}

			IntPtr pixsPtr = IntPtr.Zero; if (pixs != null) {pixsPtr = pixs.Pointer;}
			int _Result = Natives.pixGetLastOnPixelInRun(pixs.Pointer,   x,   y,   direction,   ploc);
			return _Result;
		}


	}
}
