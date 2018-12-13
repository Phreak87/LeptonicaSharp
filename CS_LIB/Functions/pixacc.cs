using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// pixacc.c (90, 1)
		// pixaccCreate(w, h, negflag) as Pixacc
		// pixaccCreate(l_int32, l_int32, l_int32) as PIXACC *
		///  <summary>
		/// (1) Use %negflag = 1 for safety if any negative numbers are going
		/// to be used in the chain of operations.  Negative numbers
		/// arise, e.g., by subtracting a pix, or by adding a pix
		/// that has been pre-multiplied by a negative number.<para/>
		///
		/// (2) Initializes the internal 32 bpp pix, similarly to the
		/// initialization in pixInitAccumulate().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccCreate/*"/>
		///  <param name="w">[in] - of 32 bpp internal Pix</param>
		///  <param name="h">[in] - of 32 bpp internal Pix</param>
		///  <param name="negflag">[in] - 0 if only positive numbers are involved 1 if there will be negative numbers</param>
		///   <returns>pixacc, or NULL on error</returns>
		public static Pixacc pixaccCreate(
						int w,
						int h,
						int negflag)
		{
			IntPtr _Result = Natives.pixaccCreate(  w,   h,   negflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixacc(_Result);
		}

		// pixacc.c (131, 1)
		// pixaccCreateFromPix(pix, negflag) as Pixacc
		// pixaccCreateFromPix(PIX *, l_int32) as PIXACC *
		///  <summary>
		/// (1) See pixaccCreate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccCreateFromPix/*"/>
		///  <param name="pix">[in] - </param>
		///  <param name="negflag">[in] - 0 if only positive numbers are involved 1 if there will be negative numbers</param>
		///   <returns>pixacc, or NULL on error</returns>
		public static Pixacc pixaccCreateFromPix(
						Pix pix,
						int negflag)
		{
			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			IntPtr _Result = Natives.pixaccCreateFromPix(pix.Pointer,   negflag);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pixacc(_Result);
		}

		// pixacc.c (160, 1)
		// pixaccDestroy(ppixacc) as Object
		// pixaccDestroy(PIXACC **) as void
		///  <summary>
		/// (1) Always nulls the input ptr.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccDestroy/*"/>
		///  <param name="ppixacc">[in,out] - to be nulled</param>
		public static void pixaccDestroy(
						ref Pixacc ppixacc)
		{
			IntPtr ppixaccPtr = IntPtr.Zero; 	if (ppixacc != null) {ppixaccPtr = ppixacc.Pointer;}
			Natives.pixaccDestroy(ref ppixaccPtr);
			if (ppixaccPtr == IntPtr.Zero) {ppixacc = null;} else { ppixacc = new Pixacc(ppixaccPtr); };
		}

		// pixacc.c (192, 1)
		// pixaccFinal(pixacc, outdepth) as Pix
		// pixaccFinal(PIXACC *, l_int32) as PIX *
		///  <summary>
		/// pixaccFinal()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccFinal/*"/>
		///  <param name="pixacc">[in] - </param>
		///  <param name="outdepth">[in] - 8, 16 or 32 bpp</param>
		///   <returns>pixd 8 , 16 or 32 bpp, or NULL on error</returns>
		public static Pix pixaccFinal(
						Pixacc pixacc,
						int outdepth)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			IntPtr _Result = Natives.pixaccFinal(pixacc.Pointer,   outdepth);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pixacc.c (215, 1)
		// pixaccGetPix(pixacc) as Pix
		// pixaccGetPix(PIXACC *) as PIX *
		///  <summary>
		/// pixaccGetPix()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccGetPix/*"/>
		///  <param name="pixacc">[in] - </param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix pixaccGetPix(
						Pixacc pixacc)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			IntPtr _Result = Natives.pixaccGetPix(pixacc.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// pixacc.c (232, 1)
		// pixaccGetOffset(pixacc) as int
		// pixaccGetOffset(PIXACC *) as l_int32
		///  <summary>
		/// pixaccGetOffset()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccGetOffset/*"/>
		///  <param name="pixacc">[in] - </param>
		///   <returns>offset, or -1 on error</returns>
		public static int pixaccGetOffset(
						Pixacc pixacc)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			int _Result = Natives.pixaccGetOffset(pixacc.Pointer);
			return _Result;
		}

		// pixacc.c (253, 1)
		// pixaccAdd(pixacc, pix) as int
		// pixaccAdd(PIXACC *, PIX *) as l_ok
		///  <summary>
		/// pixaccAdd()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccAdd/*"/>
		///  <param name="pixacc">[in] - </param>
		///  <param name="pix">[in] - to be added</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixaccAdd(
						Pixacc pixacc,
						Pix pix)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixaccAdd(pixacc.Pointer, pix.Pointer);
			return _Result;
		}

		// pixacc.c (275, 1)
		// pixaccSubtract(pixacc, pix) as int
		// pixaccSubtract(PIXACC *, PIX *) as l_ok
		///  <summary>
		/// pixaccSubtract()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccSubtract/*"/>
		///  <param name="pixacc">[in] - </param>
		///  <param name="pix">[in] - to be subtracted</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixaccSubtract(
						Pixacc pixacc,
						Pix pix)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixaccSubtract(pixacc.Pointer, pix.Pointer);
			return _Result;
		}

		// pixacc.c (297, 1)
		// pixaccMultConst(pixacc, factor) as int
		// pixaccMultConst(PIXACC *, l_float32) as l_ok
		///  <summary>
		/// pixaccMultConst()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccMultConst/*"/>
		///  <param name="pixacc">[in] - </param>
		///  <param name="factor">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixaccMultConst(
						Pixacc pixacc,
						Single factor)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			int _Result = Natives.pixaccMultConst(pixacc.Pointer,   factor);
			return _Result;
		}

		// pixacc.c (325, 1)
		// pixaccMultConstAccumulate(pixacc, pix, factor) as int
		// pixaccMultConstAccumulate(PIXACC *, PIX *, l_float32) as l_ok
		///  <summary>
		/// (1) This creates a temp pix that is %pix multiplied by the
		/// constant %factor.  It then adds that into %pixacc.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaccMultConstAccumulate/*"/>
		///  <param name="pixacc">[in] - </param>
		///  <param name="pix">[in] - </param>
		///  <param name="factor">[in] - </param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int pixaccMultConstAccumulate(
						Pixacc pixacc,
						Pix pix,
						Single factor)
		{
			if (pixacc == null) {throw new ArgumentNullException  ("pixacc cannot be Nothing");}

			if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}

			int _Result = Natives.pixaccMultConstAccumulate(pixacc.Pointer, pix.Pointer,   factor);
			return _Result;
		}


	}
}
