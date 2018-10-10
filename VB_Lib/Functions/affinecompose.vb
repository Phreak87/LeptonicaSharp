Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\affinecompose.c (90, 1)
' createMatrix2dTranslate(transx, transy) as Single()
' createMatrix2dTranslate(l_float32, l_float32) as l_float32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The translation is equivalent to:<para/>
''' v' = Av<para/>
''' where v and v' are 1x3 column vectors in the form<para/>
''' v = [x, y, 1]^  ^ denotes transpose<para/>
''' and the affine translation matrix is<para/>
''' A = [ 1 0 tx<para/>
''' 0 1 ty<para/>
''' 0 0  1  ]<para/>
''' (2) We consider translation as with respect to a fixed origin.<para/>
''' In a clipping operation, the origin moves and the points<para/>
''' are fixed, and you use (-tx, -ty) where (tx, ty) is the<para/>
''' translation vector of the origin.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="transx">[in] - x component of translation wrt. the origin</param>
'''  <param name="transy">[in] - y component of translation wrt. the origin</param>
'''   <returns>3x3 transform matrix, or NULL on error</returns>
Public Shared Function createMatrix2dTranslate(
				 ByVal transx as Single, 
				 ByVal transy as Single) as Single()

	Dim _Result as Single() = LeptonicaSharp.Natives.createMatrix2dTranslate( transx, transy)

	Return _Result
End Function

' SRC\affinecompose.c (130, 1)
' createMatrix2dScale(scalex, scaley) as Single()
' createMatrix2dScale(l_float32, l_float32) as l_float32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The scaling is equivalent to:<para/>
''' v' = Av<para/>
''' where v and v' are 1x3 column vectors in the form<para/>
''' v = [x, y, 1]^  ^ denotes transpose<para/>
''' and the affine scaling matrix is<para/>
''' A = [ sx  0  0<para/>
''' 0 sy 0<para/>
''' 0 0  1  ]<para/>
''' (2) We consider scaling as with respect to a fixed origin.<para/>
''' In other words, the origin is the only point that doesn't<para/>
''' move in the scaling transform.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="scalex">[in] - horizontal scale factor</param>
'''  <param name="scaley">[in] - vertical scale factor</param>
'''   <returns>3x3 transform matrix, or NULL on error</returns>
Public Shared Function createMatrix2dScale(
				 ByVal scalex as Single, 
				 ByVal scaley as Single) as Single()

	Dim _Result as Single() = LeptonicaSharp.Natives.createMatrix2dScale( scalex, scaley)

	Return _Result
End Function

' SRC\affinecompose.c (182, 1)
' createMatrix2dRotate(xc, yc, angle) as Single()
' createMatrix2dRotate(l_float32, l_float32, l_float32) as l_float32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The rotation is equivalent to:<para/>
''' v' = Av<para/>
''' where v and v' are 1x3 column vectors in the form<para/>
''' v = [x, y, 1]^  ^ denotes transpose<para/>
''' and the affine rotation matrix is<para/>
''' A = [ cosa -sina  xc1-cosa + ycsina<para/>
''' sina  cosa  yc1-cosa - xcsina<para/>
''' 0 0   1 ]<para/>
''' If the rotation is about the origin, xc, yc) = (0, 0 and<para/>
''' this simplifies to<para/>
''' A = [ cosa -sina  0<para/>
''' sina  cosa  0<para/>
''' 0 0 1 ]<para/>
''' These relations follow from the following equations, which<para/>
''' you can convince yourself are correct as follows.  Draw a<para/>
''' circle centered on xc,yc) and passing through (x,y), with<para/>
''' (x',y') on the arc at an angle 'a' clockwise from (x,y).<para/>
''' [ Hint: cosa + b = cosa  cosb - sina  sinb<para/>
''' sina + b = sina  cosb + cosa  sinb ]<para/>
''' x' - xc =  x - xc)  cosa - (y - yc  sina<para/>
''' y' - yc =  x - xc)  sina + (y - yc  cosa<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="xc">[in] - location of center of rotation</param>
'''  <param name="yc">[in] - location of center of rotation</param>
'''  <param name="angle">[in] - rotation in radians clockwise is positive</param>
'''   <returns>3x3 transform matrix, or NULL on error</returns>
Public Shared Function createMatrix2dRotate(
				 ByVal xc as Single, 
				 ByVal yc as Single, 
				 ByVal angle as Single) as Single()

	Dim _Result as Single() = LeptonicaSharp.Natives.createMatrix2dRotate( xc, yc, angle)

	Return _Result
End Function

' SRC\affinecompose.c (223, 1)
' ptaTranslate(ptas, transx, transy) as Pta
' ptaTranslate(PTA *, l_float32, l_float32) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See createMatrix2dTranslate() for details of transform.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - for initial points</param>
'''  <param name="transx">[in] - x component of translation wrt. the origin</param>
'''  <param name="transy">[in] - y component of translation wrt. the origin</param>
'''   <returns>ptad  translated points, or NULL on error</returns>
Public Shared Function ptaTranslate(
				 ByVal ptas as Pta, 
				 ByVal transx as Single, 
				 ByVal transy as Single) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaTranslate( ptas.Pointer, transx, transy)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\affinecompose.c (262, 1)
' ptaScale(ptas, scalex, scaley) as Pta
' ptaScale(PTA *, l_float32, l_float32) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See createMatrix2dScale() for details of transform.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - for initial points</param>
'''  <param name="scalex">[in] - horizontal scale factor</param>
'''  <param name="scaley">[in] - vertical scale factor</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaScale(
				 ByVal ptas as Pta, 
				 Optional ByVal scalex as Single = 1, 
				 Optional ByVal scaley as Single = 1) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaScale( ptas.Pointer, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\affinecompose.c (313, 1)
' ptaRotate(ptas, xc, yc, angle) as Pta
' ptaRotate(PTA *, l_float32, l_float32, l_float32) as PTA *
'''  <summary>
''' <para/>
''' Notes<para/>
''' (1) See createMatrix2dScale() for details of transform.<para/>
''' (2) This transform can be thought of as composed of the<para/>
''' sum of two parts:<para/>
''' a) an (x,y)-dependent rotation about the origin:<para/>
''' xr = x  cosa - y  sina<para/>
''' yr = x  sina + y  cosa<para/>
''' b) an (x,y)-independent translation that depends on the<para/>
''' rotation center and the angle:<para/>
''' xt = xc - xc  cosa + yc  sina<para/>
''' yt = yc - xc  sina - yc  cosa<para/>
''' The translation part (xt,yt) is equal to the difference<para/>
''' between the center (xc,yc) and the location of the<para/>
''' center after it is rotated about the origin.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - for initial points</param>
'''  <param name="xc">[in] - location of center of rotation</param>
'''  <param name="yc">[in] - location of center of rotation</param>
'''  <param name="angle">[in] - rotation in radians clockwise is positive</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaRotate(
				 ByVal ptas as Pta, 
				 ByVal xc as Single, 
				 ByVal yc as Single, 
				 ByVal angle as Single) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaRotate( ptas.Pointer, xc, yc, angle)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\affinecompose.c (358, 1)
' boxaTranslate(boxas, transx, transy) as Boxa
' boxaTranslate(BOXA *, l_float32, l_float32) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="transx">[in] - x component of translation wrt. the origin</param>
'''  <param name="transy">[in] - y component of translation wrt. the origin</param>
'''   <returns>boxad  translated boxas, or NULL on error Notes: (1) See createMatrix2dTranslate() for details of transform.</returns>
Public Shared Function boxaTranslate(
				 ByVal boxas as Boxa, 
				 ByVal transx as Single, 
				 ByVal transy as Single) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaTranslate( boxas.Pointer, transx, transy)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\affinecompose.c (391, 1)
' boxaScale(boxas, scalex, scaley) as Boxa
' boxaScale(BOXA *, l_float32, l_float32) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="scalex">[in] - horizontal scale factor</param>
'''  <param name="scaley">[in] - vertical scale factor</param>
'''   <returns>boxad  scaled boxas, or NULL on error Notes: (1) See createMatrix2dScale() for details of transform.</returns>
Public Shared Function boxaScale(
				 ByVal boxas as Boxa, 
				 Optional ByVal scalex as Single = 1, 
				 Optional ByVal scaley as Single = 1) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaScale( boxas.Pointer, scalex, scaley)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\affinecompose.c (424, 1)
' boxaRotate(boxas, xc, yc, angle) as Boxa
' boxaRotate(BOXA *, l_float32, l_float32, l_float32) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="xc">[in] - location of center of rotation</param>
'''  <param name="yc">[in] - location of center of rotation</param>
'''  <param name="angle">[in] - rotation in radians clockwise is positive</param>
'''   <returns>boxad  scaled boxas, or NULL on error Notes: (1) See createMatrix2dRotate() for details of transform.</returns>
Public Shared Function boxaRotate(
				 ByVal boxas as Boxa, 
				 ByVal xc as Single, 
				 ByVal yc as Single, 
				 ByVal angle as Single) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaRotate( boxas.Pointer, xc, yc, angle)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\affinecompose.c (457, 1)
' ptaAffineTransform(ptas, mat) as Pta
' ptaAffineTransform(PTA *, l_float32 *) as PTA *
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - for initial points</param>
'''  <param name="mat">[in] - 3x3 transform matrix canonical form</param>
'''   <returns>ptad  transformed points, or NULL on error</returns>
Public Shared Function ptaAffineTransform(
				 ByVal ptas as Pta, 
				 ByVal mat as Single()) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (mat) then Throw New ArgumentNullException  ("mat cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaAffineTransform( ptas.Pointer, mat)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\affinecompose.c (493, 1)
' boxaAffineTransform(boxas, mat) as Boxa
' boxaAffineTransform(BOXA *, l_float32 *) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="mat">[in] - 3x3 transform matrix canonical form</param>
'''   <returns>boxad  transformed boxas, or NULL on error</returns>
Public Shared Function boxaAffineTransform(
				 ByVal boxas as Boxa, 
				 ByVal mat as Single()) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (mat) then Throw New ArgumentNullException  ("mat cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaAffineTransform( boxas.Pointer, mat)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\affinecompose.c (528, 1)
' l_productMatVec(mat, vecs, vecd, size) as Integer
' l_productMatVec(l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="mat">[in] - square matrix, as a 1-dimensional %size^2 array</param>
'''  <param name="vecs">[in] - input column vector of length %size</param>
'''  <param name="vecd">[in] - result column vector</param>
'''  <param name="size">[in] - matrix is %size x %size vectors are length %size</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_productMatVec(
				 ByVal mat as Single(), 
				 ByVal vecs as Single(), 
				 ByVal vecd as Single(), 
				 ByVal size as Integer) as Integer

	If IsNothing (mat) then Throw New ArgumentNullException  ("mat cannot be Nothing")
	If IsNothing (vecs) then Throw New ArgumentNullException  ("vecs cannot be Nothing")
	If IsNothing (vecd) then Throw New ArgumentNullException  ("vecd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_productMatVec( mat, vecs, vecd, size)

	Return _Result
End Function

' SRC\affinecompose.c (564, 1)
' l_productMat2(mat1, mat2, matd, size) as Integer
' l_productMat2(l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="matd">[in] - square matrix product stored here</param>
'''  <param name="size">[in] - of matrices</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_productMat2(
				 ByVal mat1 as Single(), 
				 ByVal mat2 as Single(), 
				 ByVal matd as Single(), 
				 ByVal size as Integer) as Integer

	If IsNothing (mat1) then Throw New ArgumentNullException  ("mat1 cannot be Nothing")
	If IsNothing (mat2) then Throw New ArgumentNullException  ("mat2 cannot be Nothing")
	If IsNothing (matd) then Throw New ArgumentNullException  ("matd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_productMat2( mat1, mat2, matd, size)

	Return _Result
End Function

' SRC\affinecompose.c (603, 1)
' l_productMat3(mat1, mat2, mat3, matd, size) as Integer
' l_productMat3(l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat3">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="matd">[in] - square matrix product stored here</param>
'''  <param name="size">[in] - of matrices</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_productMat3(
				 ByVal mat1 as Single(), 
				 ByVal mat2 as Single(), 
				 ByVal mat3 as Single(), 
				 ByVal matd as Single(), 
				 ByVal size as Integer) as Integer

	If IsNothing (mat1) then Throw New ArgumentNullException  ("mat1 cannot be Nothing")
	If IsNothing (mat2) then Throw New ArgumentNullException  ("mat2 cannot be Nothing")
	If IsNothing (mat3) then Throw New ArgumentNullException  ("mat3 cannot be Nothing")
	If IsNothing (matd) then Throw New ArgumentNullException  ("matd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_productMat3( mat1, mat2, mat3, matd, size)

	Return _Result
End Function

' SRC\affinecompose.c (644, 1)
' l_productMat4(mat1, mat2, mat3, mat4, matd, size) as Integer
' l_productMat4(l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_float32 *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="mat1">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat2">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat3">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="mat4">[in] - square matrix, as a 1-dimensional size^2 array</param>
'''  <param name="matd">[in] - square matrix product stored here</param>
'''  <param name="size">[in] - of matrices</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_productMat4(
				 ByVal mat1 as Single(), 
				 ByVal mat2 as Single(), 
				 ByVal mat3 as Single(), 
				 ByVal mat4 as Single(), 
				 ByVal matd as Single(), 
				 ByVal size as Integer) as Integer

	If IsNothing (mat1) then Throw New ArgumentNullException  ("mat1 cannot be Nothing")
	If IsNothing (mat2) then Throw New ArgumentNullException  ("mat2 cannot be Nothing")
	If IsNothing (mat3) then Throw New ArgumentNullException  ("mat3 cannot be Nothing")
	If IsNothing (mat4) then Throw New ArgumentNullException  ("mat4 cannot be Nothing")
	If IsNothing (matd) then Throw New ArgumentNullException  ("matd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_productMat4( mat1, mat2, mat3, mat4, matd, size)

	Return _Result
End Function

End Class
