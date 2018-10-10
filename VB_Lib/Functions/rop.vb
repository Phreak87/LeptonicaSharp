Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\rop.c (193, 1)
' pixRasterop(pixd, dx, dy, dw, dh, op, pixs, sx, sy) as Integer
' pixRasterop(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This has the standard set of 9 args for rasterop.<para/>
''' This function is your friend it is worth memorizing!<para/>
''' (2) If the operation involves only dest, this calls<para/>
''' rasteropUniLow().  Otherwise, checks depth of the<para/>
''' src and dest, and if they match, calls rasteropLow().<para/>
''' (3) For the two-image operation, where both pixs and pixd<para/>
''' are defined, they are typically different images.  However<para/>
''' there are cases, such as pixSetMirroredBorder(), where<para/>
''' in-place operations can be done, blitting pixels from<para/>
''' one part of pixd to another.  Consequently, we permit<para/>
''' such operations.  If you use them, be sure that there<para/>
''' is no overlap between the source and destination rectangles<para/>
''' in pixd (!)<para/>
''' Background:<para/>
''' -----------<para/>
''' There are 18 operations, described by the op codes in pix.h.<para/>
''' One, PIX_DST, is a no-op.<para/>
''' Three, PIX_CLR, PIX_SET, and PIX_NOT(PIX_DST) operate only on the dest.<para/>
''' These are handled by the low-level rasteropUniLow().<para/>
''' The other 14 involve the both the src and the dest, and depend on<para/>
''' the bit values of either just the src or the bit values of both<para/>
''' src and dest.  They are handled by rasteropLow():<para/>
''' PIX_SRC     s<para/>
''' PIX_NOT(PIX_SRC)   ~s<para/>
''' PIX_SRC | PIX_DST   s | d<para/>
''' PIX_SRC  and  PIX_DST   s  and  d<para/>
''' PIX_SRC ^ PIX_DST   s ^ d<para/>
''' PIX_NOT(PIX_SRC) | PIX_DST ~s | d<para/>
''' PIX_NOT(PIX_SRC)  and  PIX_DST ~s  and  d<para/>
''' PIX_NOT(PIX_SRC) ^ PIX_DST ~s ^ d<para/>
''' PIX_SRC | PIX_NOT(PIX_DST)  s | ~d<para/>
''' PIX_SRC  and  PIX_NOT(PIX_DST)  s  and  ~d<para/>
''' PIX_SRC ^ PIX_NOT(PIX_DST)  s ^ ~d<para/>
''' PIX_NOT(PIX_SRC | PIX_DST) ~(s | d)<para/>
''' PIX_NOT(PIX_SRC  and  PIX_DST) ~(s  and  d)<para/>
''' PIX_NOT(PIX_SRC ^ PIX_DST) ~(s ^ d)<para/>
''' Each of these is implemented with one of three low-level<para/>
''' functions, depending on the alignment of the left edge<para/>
''' of the src and dest rectangles:<para/>
''' a fastest implementation if both left edges are<para/>
''' (32-bit) word aligned<para/>
''' a very slightly slower implementation if both left<para/>
''' edges have the same relative (32-bit) word alignment<para/>
''' the general routine that is invoked when<para/>
''' both left edges have different word alignment<para/>
''' Of the 14 binary rasterops above, only 12 are unique<para/>
''' logical combinations (out of a possible 16) of src<para/>
''' and dst bits:<para/>
''' (sd) (11) (10) (01) (00)<para/>
''' -----------------------------------------------<para/>
''' s  1  1  0  0<para/>
''' ~s  0  1  0  1<para/>
''' s | d  1  1  1  0<para/>
''' s  and  d  1  0  0  0<para/>
''' s ^ d  0  1  1  0<para/>
''' ~s | d  1  0  1  1<para/>
''' ~s  and  d  0  0  1  0<para/>
''' ~s ^ d  1  0  0  1<para/>
''' s | ~d 1  1  0  1<para/>
''' s  and  ~d 0  1  0  0<para/>
''' s ^ ~d 1  0  0  1<para/>
''' ~(s | d)  0  0  0  1<para/>
''' ~(s  and  d)  0  1  1  1<para/>
''' ~(s ^ d)  1  0  0  1<para/>
''' Note that the following three operations are equivalent:<para/>
''' ~(s ^ d)<para/>
''' ~s ^ d<para/>
''' s ^ ~d<para/>
''' and in the implementation, we call them out with the first form<para/>
''' namely, ~(s ^ d).<para/>
''' Of the 16 possible binary combinations of src and dest bits,<para/>
''' the remaining 4 unique ones are independent of the src bit.<para/>
''' They depend on either just the dest bit or on neither<para/>
''' the src nor dest bits:<para/>
''' d  1  0  1  0  (indep. of s)<para/>
''' ~d  0  1  0  1  (indep. of s)<para/>
''' CLR   0  0  0  0  (indep. of both s  and  d)<para/>
''' SET   1  1  1  1  (indep. of both s  and  d)<para/>
''' As mentioned above, three of these are implemented by<para/>
''' rasteropUniLow(), and one is a no-op.<para/>
''' How can these operation codes be represented by bits<para/>
''' in such a way that when the basic operations are performed<para/>
''' on the bits the results are unique for unique<para/>
''' operations, and mimic the logic table given above?<para/>
''' The answer is to choose a particular order of the pairings:<para/>
''' (sd) (11) (10) (01) (00)<para/>
''' (which happens to be the same as in the above table)<para/>
''' and to translate the result into 4-bit representations<para/>
''' of s and d.  For example, the Sun rasterop choice<para/>
''' (omitting the extra bit for clipping) is<para/>
''' PIX_SRC  0xc<para/>
''' PIX_DST  0xa<para/>
''' This corresponds to our pairing order given above:<para/>
''' (sd) (11) (10) (01) (00)<para/>
''' where for s = 1 we get the bit pattern<para/>
''' PIX_SRC:  1  1  0  0 (0xc)<para/>
''' and for d = 1 we get the pattern<para/>
''' PIX_DST: 1  0  1  0  (0xa)<para/>
''' OK, that's the pairing order that Sun chose.  How many different<para/>
''' ways can we assign bit patterns to PIX_SRC and PIX_DST to get<para/>
''' the boolean ops to work out?  Any of the 4 pairs can be put<para/>
''' in the first position, any of the remaining 3 pairs can go<para/>
''' in the second and one of the remaining 2 pairs can go the the third.<para/>
''' There is a total of 432 = 24 ways these pairs can be permuted.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - dest pix</param>
'''  <param name="dx">[in] - x val of UL corner of dest rectangle</param>
'''  <param name="dy">[in] - y val of UL corner of dest rectangle</param>
'''  <param name="dw">[in] - width of dest rectangle</param>
'''  <param name="dh">[in] - height of dest rectangle</param>
'''  <param name="op">[in] - op code</param>
'''  <param name="pixs">[in] - src pix</param>
'''  <param name="sx">[in] - x val of UL corner of src rectangle</param>
'''  <param name="sy">[in] - y val of UL corner of src rectangle</param>
'''   <returns>0 if OK 1 on error.</returns>
Public Shared Function pixRasterop(
				 ByVal pixd as Pix, 
				 ByVal dx as Integer, 
				 ByVal dy as Integer, 
				 ByVal dw as Integer, 
				 ByVal dh as Integer, 
				 ByVal op as Integer, 
				 ByVal pixs as Pix, 
				 ByVal sx as Integer, 
				 ByVal sy as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRasterop( pixd.Pointer, dx, dy, dw, dh, op, pixs.Pointer, sx, sy)

	Return _Result
End Function

' SRC\rop.c (269, 1)
' pixRasteropVip(pixd, bx, bw, vshift, incolor) as Integer
' pixRasteropVip(PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This rasterop translates a vertical band of the<para/>
''' image either up or down, bringing in either white<para/>
''' or black pixels from outside the image.<para/>
''' (2) The vertical band extends the full height of pixd.<para/>
''' (3) If a colormap exists, the nearest color to white or black<para/>
''' is brought in.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - in-place</param>
'''  <param name="bx">[in] - left edge of vertical band</param>
'''  <param name="bw">[in] - width of vertical band</param>
'''  <param name="vshift">[in] - vertical shift of band vshift  is greater  0 is down</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixRasteropVip(
				 ByVal pixd as Pix, 
				 ByVal bx as Integer, 
				 ByVal bw as Integer, 
				 ByVal vshift as Integer, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRasteropVip( pixd.Pointer, bx, bw, vshift, incolor)

	Return _Result
End Function

' SRC\rop.c (347, 1)
' pixRasteropHip(pixd, by, bh, hshift, incolor) as Integer
' pixRasteropHip(PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This rasterop translates a horizontal band of the<para/>
''' image either left or right, bringing in either white<para/>
''' or black pixels from outside the image.<para/>
''' (2) The horizontal band extends the full width of pixd.<para/>
''' (3) If a colormap exists, the nearest color to white or black<para/>
''' is brought in.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - in-place operation</param>
'''  <param name="by">[in] - top of horizontal band</param>
'''  <param name="bh">[in] - height of horizontal band</param>
'''  <param name="hshift">[in] - horizontal shift of band hshift  is greater  0 is to right</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixRasteropHip(
				 ByVal pixd as Pix, 
				 ByVal by as Integer, 
				 ByVal bh as Integer, 
				 ByVal hshift as Integer, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRasteropHip( pixd.Pointer, by, bh, hshift, incolor)

	Return _Result
End Function

' SRC\rop.c (431, 1)
' pixTranslate(pixd, pixs, hshift, vshift, incolor) as Pix
' pixTranslate(PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The general pattern is:<para/>
''' pixd = pixTranslate(pixd, pixs, ...)<para/>
''' For clarity, when you know the case, use one of these:<para/>
''' pixd = pixTranslate(NULL, pixs, ...)  // new<para/>
''' pixTranslate(pixs, pixs, ...) // in-place<para/>
''' pixTranslate(pixd, pixs, ...) // to existing pixd<para/>
''' (2) If an existing pixd is not the same size as pixs, the<para/>
''' image data will be reallocated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in][optional] - destination: this can be null, equal to pixs, or different from pixs</param>
'''  <param name="pixs">[in] - </param>
'''  <param name="hshift">[in] - horizontal shift hshift  is greater  0 is to right</param>
'''  <param name="vshift">[in] - vertical shift vshift  is greater  0 is down</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>pixd, or NULL on error.</returns>
Public Shared Function pixTranslate(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal hshift as Integer, 
				 ByVal vshift as Integer, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixTranslate( pixdPTR, pixs.Pointer, hshift, vshift, incolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rop.c (461, 1)
' pixRasteropIP(pixd, hshift, vshift, incolor) as Integer
' pixRasteropIP(PIX *, l_int32, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - in-place translation</param>
'''  <param name="hshift">[in] - horizontal shift hshift  is greater  0 is to right</param>
'''  <param name="vshift">[in] - vertical shift vshift  is greater  0 is down</param>
'''  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixRasteropIP(
				 ByVal pixd as Pix, 
				 ByVal hshift as Integer, 
				 ByVal vshift as Integer, 
				 ByVal incolor as Enumerations.L_BRING_IN) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRasteropIP( pixd.Pointer, hshift, vshift, incolor)

	Return _Result
End Function

' SRC\rop.c (502, 1)
' pixRasteropFullImage(pixd, pixs, op) as Integer
' pixRasteropFullImage(PIX *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' ~ this is a wrapper for a common 2-image raster operation<para/>
''' ~ both pixs and pixd must be defined<para/>
''' ~ the operation is performed with aligned UL corners of pixs and pixd<para/>
''' ~ the operation clips to the smallest pix if the width or height<para/>
''' of pixd is larger than pixs, some pixels in pixd will be unchanged<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - </param>
'''  <param name="pixs">[in] - </param>
'''  <param name="op">[in] - any of the op-codes</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixRasteropFullImage(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal op as Integer) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRasteropFullImage( pixd.Pointer, pixs.Pointer, op)

	Return _Result
End Function

End Class
