using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// colormorph.c (66, 1)
		// pixColorMorph(pixs, type, hsize, vsize) as Pix
		// pixColorMorph(PIX *, l_int32, l_int32, l_int32) as PIX *
		///  <summary>
		/// (1) This does the morph operation on each component separately,
		/// and recombines the result.<para/>
		///
		/// (2) Sel is a brick with all elements being hits.<para/>
		///
		/// (3) If hsize = vsize = 1, just returns a copy.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorMorph/*"/>
		///  <param name="pixs">[in] - </param>
		///  <param name="type">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, or L_MORPH_CLOSE</param>
		///  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
		///  <param name="vsize">[in] - ditto</param>
		///   <returns>pixd</returns>
		public static Pix pixColorMorph(
						Pix pixs,
						int type,
						int hsize,
						int vsize)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr _Result = Natives.pixColorMorph(pixs.Pointer,   type,   hsize,   vsize);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}


	}
}
