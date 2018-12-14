using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// affinecompose.c (90, 1)
		// createMatrix2dTranslate(transx, transy) as Single[]
		// createMatrix2dTranslate(l_float32, l_float32) as l_float32 *
		///  <summary>
		/// (1) The translation is equivalent to:
		/// v' = Av
		/// where v and v' are 1x3 column vectors in the form
		/// v = [x, y, 1]^  ^ denotes transpose
		/// and the affine translation matrix is
		/// A = [ 1 0 tx
		/// 0 1 ty
		/// 0 0  1  ]<para/>
		///
		/// (2) We consider translation as with respect to a fixed origin.
		/// In a clipping operation, the origin moves and the points
		/// are fixed, and you use (-tx, -ty) where (tx, ty) is the
		/// translation vector of the origin.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/createMatrix2dTranslate/*"/>
		///  <param name="transx">[in] - x component of translation wrt. the origin</param>
		///  <param name="transy">[in] - y component of translation wrt. the origin</param>
		///   <returns>3x3 transform matrix, or NULL on error</returns>
		public static Single[] createMatrix2dTranslate(
						Single transx,
						Single transy)
		{
			Single[] _Result = Natives.createMatrix2dTranslate(  transx,   transy);
			return _Result;
		}

		// affinecompose.c (130, 1)
		// createMatrix2dScale(scalex, scaley) as Single[]
		// createMatrix2dScale(l_float32, l_float32) as l_float32 *
		///  <summary>
		/// (1) The scaling is equivalent to:
		/// v' = Av
		/// where v and v' are 1x3 column vectors in the form
		/// v = [x, y, 1]^  ^ denotes transpose
		/// and the affine scaling matrix is
		/// A = [ sx  0  0
		/// 0 sy 0
		/// 0 0  1  ]<para/>
		///
		/// (2) We consider scaling as with respect to a fixed origin.
		/// In other words, the origin is the only point that doesn't
		/// move in the scaling transform.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/createMatrix2dScale/*"/>
		///  <param name="scalex">[in] - horizontal scale factor</param>
		///  <param name="scaley">[in] - vertical scale factor</param>
		///   <returns>3x3 transform matrix, or NULL on error</returns>
		public static Single[] createMatrix2dScale(
						Single scalex,
						Single scaley)
		{
			Single[] _Result = Natives.createMatrix2dScale(  scalex,   scaley);
			return _Result;
		}

		// affinecompose.c (182, 1)
		// createMatrix2dRotate(xc, yc, angle) as Single[]
		// createMatrix2dRotate(l_float32, l_float32, l_float32) as l_float32 *
		///  <summary>
		/// (1) The rotation is equivalent to:
		/// v' = Av
		/// where v and v' are 1x3 column vectors in the form
		/// v = [x, y, 1]^  ^ denotes transpose
		/// and the affine rotation matrix is
		/// A = [ cosa -sina  xc1-cosa + ycsina
		/// sina  cosa  yc1-cosa - xcsina
		/// 0 0   1 ]
		/// If the rotation is about the origin, xc, yc) = (0, 0 and
		/// this simplifies to
		/// A = [ cosa -sina  0
		/// sina  cosa  0
		/// 0 0 1 ]
		/// These relations follow from the following equations, which
		/// you can convince yourself are correct as follows.  Draw a
		/// circle centered on xc,yc) and passing through (x,y), with
		/// (x',y') on the arc at an angle 'a' clockwise from (x,y).
		/// [ Hint: cosa + b = cosa  cosb - sina  sinb
		/// sina + b = sina  cosb + cosa  sinb ]
		/// x' - xc =  x - xc)  cosa - (y - yc  sina
		/// y' - yc =  x - xc)  sina + (y - yc  cosa
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/createMatrix2dRotate/*"/>
		///  <param name="xc">[in] - location of center of rotation</param>
		///  <param name="yc">[in] - location of center of rotation</param>
		///  <param name="angle">[in] - rotation in radians clockwise is positive</param>
		///   <returns>3x3 transform matrix, or NULL on error</returns>
		public static Single[] createMatrix2dRotate(
						Single xc,
						Single yc,
						Single angle)
		{
			Single[] _Result = Natives.createMatrix2dRotate(  xc,   yc,   angle);
			return _Result;
		}

		// affinecompose.c (223, 1)
		// ptaTranslate(ptas, transx, transy) as Pta
		// ptaTranslate(PTA *, l_float32, l_float32) as PTA *
		///  <summary>
		/// (1) See createMatrix2dTranslate() for details of transform.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaTranslate/*"/>
		///  <param name="ptas">[in] - for initial points</param>
		///  <param name="transx">[in] - x component of translation wrt. the origin</param>
		///  <param name="transy">[in] - y component of translation wrt. the origin</param>
		///   <returns>ptad  translated points, or NULL on error</returns>
		public static Pta ptaTranslate(
						Pta ptas,
						Single transx,
						Single transy)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.ptaTranslate(ptas.Pointer,   transx,   transy);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// affinecompose.c (262, 1)
		// ptaScale(ptas, scalex, scaley) as Pta
		// ptaScale(PTA *, l_float32, l_float32) as PTA *
		///  <summary>
		/// (1) See createMatrix2dScale() for details of transform.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaScale/*"/>
		///  <param name="ptas">[in] - for initial points</param>
		///  <param name="scalex">[in] - horizontal scale factor</param>
		///  <param name="scaley">[in] - vertical scale factor</param>
		///   <returns>0 if OK 1 on error</returns>
		public static Pta ptaScale(
						Pta ptas,
						Single scalex = 1,
						Single scaley = 1)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.ptaScale(ptas.Pointer,   scalex,   scaley);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// affinecompose.c (313, 1)
		// ptaRotate(ptas, xc, yc, angle) as Pta
		// ptaRotate(PTA *, l_float32, l_float32, l_float32) as PTA *
		///  <summary>
		/// Notes<para/>
		///
		/// (1) See createMatrix2dScale() for details of transform.<para/>
		///
		/// (2) This transform can be thought of as composed of the
		/// sum of two parts:
		/// a) an (x,y)-dependent rotation about the origin:
		/// xr = x  cosa - y  sina
		/// yr = x  sina + y  cosa
		/// b) an (x,y)-independent translation that depends on the
		/// rotation center and the angle:
		/// xt = xc - xc  cosa + yc  sina
		/// yt = yc - xc  sina - yc  cosa
		/// The translation part (xt,yt) is equal to the difference
		/// between the center (xc,yc) and the location of the
		/// center after it is rotated about the origin.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaRotate/*"/>
		///  <param name="ptas">[in] - for initial points</param>
		///  <param name="xc">[in] - location of center of rotation</param>
		///  <param name="yc">[in] - location of center of rotation</param>
		///  <param name="angle">[in] - rotation in radians clockwise is positive</param>
		///   <returns>0 if OK 1 on error</returns>
		public static Pta ptaRotate(
						Pta ptas,
						Single xc,
						Single yc,
						Single angle)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			IntPtr _Result = Natives.ptaRotate(ptas.Pointer,   xc,   yc,   angle);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// affinecompose.c (358, 1)
		// boxaTranslate(boxas, transx, transy) as Boxa
		// boxaTranslate(BOXA *, l_float32, l_float32) as BOXA *
		///  <summary>
		/// boxaTranslate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaTranslate/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="transx">[in] - x component of translation wrt. the origin</param>
		///  <param name="transy">[in] - y component of translation wrt. the origin</param>
		///   <returns>boxad  translated boxas, or NULL on error Notes: (1) See createMatrix2dTranslate() for details of transform.</returns>
		public static Boxa boxaTranslate(
						Boxa boxas,
						Single transx,
						Single transy)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaTranslate(boxas.Pointer,   transx,   transy);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// affinecompose.c (391, 1)
		// boxaScale(boxas, scalex, scaley) as Boxa
		// boxaScale(BOXA *, l_float32, l_float32) as BOXA *
		///  <summary>
		/// boxaScale()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaScale/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="scalex">[in] - horizontal scale factor</param>
		///  <param name="scaley">[in] - vertical scale factor</param>
		///   <returns>boxad  scaled boxas, or NULL on error Notes: (1) See createMatrix2dScale() for details of transform.</returns>
		public static Boxa boxaScale(
						Boxa boxas,
						Single scalex = 1,
						Single scaley = 1)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaScale(boxas.Pointer,   scalex,   scaley);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// affinecompose.c (424, 1)
		// boxaRotate(boxas, xc, yc, angle) as Boxa
		// boxaRotate(BOXA *, l_float32, l_float32, l_float32) as BOXA *
		///  <summary>
		/// boxaRotate()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRotate/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="xc">[in] - location of center of rotation</param>
		///  <param name="yc">[in] - location of center of rotation</param>
		///  <param name="angle">[in] - rotation in radians clockwise is positive</param>
		///   <returns>boxad  scaled boxas, or NULL on error Notes: (1) See createMatrix2dRotate() for details of transform.</returns>
		public static Boxa boxaRotate(
						Boxa boxas,
						Single xc,
						Single yc,
						Single angle)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			IntPtr _Result = Natives.boxaRotate(boxas.Pointer,   xc,   yc,   angle);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// affinecompose.c (457, 1)
		// ptaAffineTransform(ptas, mat) as Pta
		// ptaAffineTransform(PTA *, l_float32 *) as PTA *
		///  <summary>
		/// ptaAffineTransform()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaAffineTransform/*"/>
		///  <param name="ptas">[in] - for initial points</param>
		///  <param name="mat">[in] - 3x3 transform matrix canonical form</param>
		///   <returns>ptad  transformed points, or NULL on error</returns>
		public static Pta ptaAffineTransform(
						Pta ptas,
						Single[] mat)
		{
			if (ptas == null) {throw new ArgumentNullException  ("ptas cannot be Nothing");}

			if (mat == null) {throw new ArgumentNullException  ("mat cannot be Nothing");}

			IntPtr _Result = Natives.ptaAffineTransform(ptas.Pointer,   mat);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// affinecompose.c (493, 1)
		// boxaAffineTransform(boxas, mat) as Boxa
		// boxaAffineTransform(BOXA *, l_float32 *) as BOXA *
		///  <summary>
		/// boxaAffineTransform()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAffineTransform/*"/>
		///  <param name="boxas">[in] - </param>
		///  <param name="mat">[in] - 3x3 transform matrix canonical form</param>
		///   <returns>boxad  transformed boxas, or NULL on error</returns>
		public static Boxa boxaAffineTransform(
						Boxa boxas,
						Single[] mat)
		{
			if (boxas == null) {throw new ArgumentNullException  ("boxas cannot be Nothing");}

			if (mat == null) {throw new ArgumentNullException  ("mat cannot be Nothing");}

			IntPtr _Result = Natives.boxaAffineTransform(boxas.Pointer,   mat);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Boxa(_Result);
		}

		// affinecompose.c (528, 1)
		// l_productMatVec(mat, vecs, vecd, size) as int
		// l_productMatVec(l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
		///  <summary>
		/// l_productMatVec()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_productMatVec/*"/>
		///  <param name="mat">[in] - square matrix, as a 1-dimensional %size^2 array</param>
		///  <param name="vecs">[in] - input column vector of length %size</param>
		///  <param name="vecd">[in] - result column vector</param>
		///  <param name="size">[in] - matrix is %size x %size vectors are length %size</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_productMatVec(
						Single[] mat,
						Single[] vecs,
						Single[] vecd,
						int size)
		{
			if (mat == null) {throw new ArgumentNullException  ("mat cannot be Nothing");}

			if (vecs == null) {throw new ArgumentNullException  ("vecs cannot be Nothing");}

			if (vecd == null) {throw new ArgumentNullException  ("vecd cannot be Nothing");}

			int _Result = Natives.l_productMatVec(  mat,   vecs,   vecd,   size);
			return _Result;
		}

		// affinecompose.c (564, 1)
		// l_productMat2(mat1, mat2, matd, size) as int
		// l_productMat2(l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
		///  <summary>
		/// l_productMat2()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_productMat2/*"/>
		///  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="matd">[in] - square matrix product stored here</param>
		///  <param name="size">[in] - of matrices</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_productMat2(
						Single[] mat1,
						Single[] mat2,
						Single[] matd,
						int size)
		{
			if (mat1 == null) {throw new ArgumentNullException  ("mat1 cannot be Nothing");}

			if (mat2 == null) {throw new ArgumentNullException  ("mat2 cannot be Nothing");}

			if (matd == null) {throw new ArgumentNullException  ("matd cannot be Nothing");}

			int _Result = Natives.l_productMat2(  mat1,   mat2,   matd,   size);
			return _Result;
		}

		// affinecompose.c (603, 1)
		// l_productMat3(mat1, mat2, mat3, matd, size) as int
		// l_productMat3(l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
		///  <summary>
		/// l_productMat3()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_productMat3/*"/>
		///  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat3">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="matd">[in] - square matrix product stored here</param>
		///  <param name="size">[in] - of matrices</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_productMat3(
						Single[] mat1,
						Single[] mat2,
						Single[] mat3,
						Single[] matd,
						int size)
		{
			if (mat1 == null) {throw new ArgumentNullException  ("mat1 cannot be Nothing");}

			if (mat2 == null) {throw new ArgumentNullException  ("mat2 cannot be Nothing");}

			if (mat3 == null) {throw new ArgumentNullException  ("mat3 cannot be Nothing");}

			if (matd == null) {throw new ArgumentNullException  ("matd cannot be Nothing");}

			int _Result = Natives.l_productMat3(  mat1,   mat2,   mat3,   matd,   size);
			return _Result;
		}

		// affinecompose.c (644, 1)
		// l_productMat4(mat1, mat2, mat3, mat4, matd, size) as int
		// l_productMat4(l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
		///  <summary>
		/// l_productMat4()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_productMat4/*"/>
		///  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat3">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="mat4">[in] - square matrix, as a 1-dimensional size^2 array</param>
		///  <param name="matd">[in] - square matrix product stored here</param>
		///  <param name="size">[in] - of matrices</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_productMat4(
						Single[] mat1,
						Single[] mat2,
						Single[] mat3,
						Single[] mat4,
						Single[] matd,
						int size)
		{
			if (mat1 == null) {throw new ArgumentNullException  ("mat1 cannot be Nothing");}

			if (mat2 == null) {throw new ArgumentNullException  ("mat2 cannot be Nothing");}

			if (mat3 == null) {throw new ArgumentNullException  ("mat3 cannot be Nothing");}

			if (mat4 == null) {throw new ArgumentNullException  ("mat4 cannot be Nothing");}

			if (matd == null) {throw new ArgumentNullException  ("matd cannot be Nothing");}

			int _Result = Natives.l_productMat4(  mat1,   mat2,   mat3,   mat4,   matd,   size);
			return _Result;
		}


	}
}
