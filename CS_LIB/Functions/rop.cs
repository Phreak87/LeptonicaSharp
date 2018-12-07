using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// rop.c (193, 1)
// pixRasterop(pixd, dx, dy, dw, dh, op, pixs, sx, sy) as int
// pixRasterop(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, PIX *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This has the standard set of 9 args for rasterop.
/// This function is your friend it is worth memorizing!<para/>
/// 
/// (2) If the operation involves only dest, this calls
/// rasteropUniLow().  Otherwise, checks depth of the
/// src and dest, and if they match, calls rasteropLow().<para/>
/// 
/// (3) For the two-image operation, where both pixs and pixd
/// are defined, they are typically different images.  However
/// there are cases, such as pixSetMirroredBorder(), where
/// in-place operations can be done, blitting pixels from
/// one part of pixd to another.  Consequently, we permit
/// such operations.  If you use them, be sure that there
/// is no overlap between the source and destination rectangles
/// in pixd (!)
/// Background:
/// -----------
/// There are 18 operations, described by the op codes in pix.h.
/// One, PIX_DST, is a no-op.
/// Three, PIX_CLR, PIX_SET, and PIX_NOT(PIX_DST) operate only on the dest.
/// These are handled by the low-level rasteropUniLow().
/// The other 14 involve the both the src and the dest, and depend on
/// the bit values of either just the src or the bit values of both
/// src and dest.  They are handled by rasteropLow():
/// PIX_SRC     s
/// PIX_NOT(PIX_SRC)   ~s
/// PIX_SRC | PIX_DST   s | d
/// PIX_SRC [and] PIX_DST   s [and] d
/// PIX_SRC ^ PIX_DST   s ^ d
/// PIX_NOT(PIX_SRC) | PIX_DST ~s | d
/// PIX_NOT(PIX_SRC) [and] PIX_DST ~s [and] d
/// PIX_NOT(PIX_SRC) ^ PIX_DST ~s ^ d
/// PIX_SRC | PIX_NOT(PIX_DST)  s | ~d
/// PIX_SRC [and] PIX_NOT(PIX_DST)  s [and] ~d
/// PIX_SRC ^ PIX_NOT(PIX_DST)  s ^ ~d
/// PIX_NOT(PIX_SRC | PIX_DST) ~(s | d)
/// PIX_NOT(PIX_SRC [and] PIX_DST) ~(s [and] d)
/// PIX_NOT(PIX_SRC ^ PIX_DST) ~(s ^ d)
/// Each of these is implemented with one of three low-level
/// functions, depending on the alignment of the left edge
/// of the src and dest rectangles:
/// a fastest implementation if both left edges are
/// (32-bit) word aligned
/// a very slightly slower implementation if both left
/// edges have the same relative (32-bit) word alignment
/// the general routine that is invoked when
/// both left edges have different word alignment
/// Of the 14 binary rasterops above, only 12 are unique
/// logical combinations (out of a possible 16) of src
/// and dst bits:
/// (sd) (11) (10) (01) (00)
/// -----------------------------------------------
/// s  1  1  0  0
/// ~s  0  1  0  1
/// s | d  1  1  1  0
/// s [and] d  1  0  0  0
/// s ^ d  0  1  1  0
/// ~s | d  1  0  1  1
/// ~s [and] d  0  0  1  0
/// ~s ^ d  1  0  0  1
/// s | ~d 1  1  0  1
/// s [and] ~d 0  1  0  0
/// s ^ ~d 1  0  0  1
/// ~(s | d)  0  0  0  1
/// ~(s [and] d)  0  1  1  1
/// ~(s ^ d)  1  0  0  1
/// Note that the following three operations are equivalent:
/// ~(s ^ d)
/// ~s ^ d
/// s ^ ~d
/// and in the implementation, we call them out with the first form
/// namely, ~(s ^ d).
/// Of the 16 possible binary combinations of src and dest bits,
/// the remaining 4 unique ones are independent of the src bit.
/// They depend on either just the dest bit or on neither
/// the src nor dest bits:
/// d  1  0  1  0  (indep. of s)
/// ~d  0  1  0  1  (indep. of s)
/// CLR   0  0  0  0  (indep. of both s [and] d)
/// SET   1  1  1  1  (indep. of both s [and] d)
/// As mentioned above, three of these are implemented by
/// rasteropUniLow(), and one is a no-op.
/// How can these operation codes be represented by bits
/// in such a way that when the basic operations are performed
/// on the bits the results are unique for unique
/// operations, and mimic the logic table given above?
/// The answer is to choose a particular order of the pairings:
/// (sd) (11) (10) (01) (00)
/// (which happens to be the same as in the above table)
/// and to translate the result into 4-bit representations
/// of s and d.  For example, the Sun rasterop choice
/// (omitting the extra bit for clipping) is
/// PIX_SRC  0xc
/// PIX_DST  0xa
/// This corresponds to our pairing order given above:
/// (sd) (11) (10) (01) (00)
/// where for s = 1 we get the bit pattern
/// PIX_SRC:  1  1  0  0 (0xc)
/// and for d = 1 we get the pattern
/// PIX_DST: 1  0  1  0  (0xa)
/// OK, that's the pairing order that Sun chose.  How many different
/// ways can we assign bit patterns to PIX_SRC and PIX_DST to get
/// the boolean ops to work out?  Any of the 4 pairs can be put
/// in the first position, any of the remaining 3 pairs can go
/// in the second and one of the remaining 2 pairs can go the the third.
/// There is a total of 432 = 24 ways these pairs can be permuted.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRasterop/*"/>
///  <param name="pixd">[in] - dest pix</param>
///  <param name="dx">[in] - x val of UL corner of dest rectangle</param>
///  <param name="dy">[in] - y val of UL corner of dest rectangle</param>
///  <param name="dw">[in] - width of dest rectangle</param>
///  <param name="dh">[in] - height of dest rectangle</param>
///  <param name="op">[in] - op code</param>
///  <param name="pixs">[in] - src pix</param>
///  <param name="sx">[in] - x val of UL corner of src rectangle</param>
///  <param name="sy">[in] - y val of UL corner of src rectangle</param>
///   <returns>0 if OK 1 on error.</returns>
public static int pixRasterop(
				 Pix pixd, 
				 int dx, 
				 int dy, 
				 int dw, 
				 int dh, 
				 int op, 
				 Pix pixs, 
				 int sx, 
				 int sy){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	int _Result = Natives.pixRasterop(pixd.Pointer,   dx,   dy,   dw,   dh,   op, pixs.Pointer,   sx,   sy);
	
	return _Result;
}

// rop.c (269, 1)
// pixRasteropVip(pixd, bx, bw, vshift, incolor) as int
// pixRasteropVip(PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This rasterop translates a vertical band of the
/// image either up or down, bringing in either white
/// or black pixels from outside the image.<para/>
/// 
/// (2) The vertical band extends the full height of pixd.<para/>
/// 
/// (3) If a colormap exists, the nearest color to white or black
/// is brought in.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRasteropVip/*"/>
///  <param name="pixd">[in] - in-place</param>
///  <param name="bx">[in] - left edge of vertical band</param>
///  <param name="bw">[in] - width of vertical band</param>
///  <param name="vshift">[in] - vertical shift of band vshift  is greater  0 is down</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixRasteropVip(
				 Pix pixd, 
				 int bx, 
				 int bw, 
				 int vshift, 
				 int incolor){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
	int _Result = Natives.pixRasteropVip(pixd.Pointer,   bx,   bw,   vshift,   incolor);
	
	return _Result;
}

// rop.c (347, 1)
// pixRasteropHip(pixd, by, bh, hshift, incolor) as int
// pixRasteropHip(PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This rasterop translates a horizontal band of the
/// image either left or right, bringing in either white
/// or black pixels from outside the image.<para/>
/// 
/// (2) The horizontal band extends the full width of pixd.<para/>
/// 
/// (3) If a colormap exists, the nearest color to white or black
/// is brought in.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRasteropHip/*"/>
///  <param name="pixd">[in] - in-place operation</param>
///  <param name="by">[in] - top of horizontal band</param>
///  <param name="bh">[in] - height of horizontal band</param>
///  <param name="hshift">[in] - horizontal shift of band hshift  is greater  0 is to right</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixRasteropHip(
				 Pix pixd, 
				 int by, 
				 int bh, 
				 int hshift, 
				 int incolor){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
	int _Result = Natives.pixRasteropHip(pixd.Pointer,   by,   bh,   hshift,   incolor);
	
	return _Result;
}

// rop.c (431, 1)
// pixTranslate(pixd, pixs, hshift, vshift, incolor) as Pix
// pixTranslate(PIX *, PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) The general pattern is:
/// pixd = pixTranslate(pixd, pixs, ...)
/// For clarity, when you know the case, use one of these:
/// pixd = pixTranslate(NULL, pixs, ...)  // new
/// pixTranslate(pixs, pixs, ...) // in-place
/// pixTranslate(pixd, pixs, ...) // to existing pixd<para/>
/// 
/// (2) If an existing pixd is not the same size as pixs, the
/// image data will be reallocated.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixTranslate/*"/>
///  <param name="pixd">[in][optional] - destination: this can be null, equal to pixs, or different from pixs</param>
///  <param name="pixs">[in] - </param>
///  <param name="hshift">[in] - horizontal shift hshift  is greater  0 is to right</param>
///  <param name="vshift">[in] - vertical shift vshift  is greater  0 is down</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>pixd, or NULL on error.</returns>
public static Pix pixTranslate(
				 Pix pixd, 
				 Pix pixs, 
				 int hshift, 
				 int vshift, 
				 int incolor){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	IntPtr pixdPtr = IntPtr.Zero; 	if (pixd != null) {pixdPtr = pixd.Pointer;}

	IntPtr _Result = Natives.pixTranslate(pixdPtr, pixs.Pointer,   hshift,   vshift,   incolor);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// rop.c (461, 1)
// pixRasteropIP(pixd, hshift, vshift, incolor) as int
// pixRasteropIP(PIX *, l_int32, l_int32, l_int32) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRasteropIP/*"/>
///  <param name="pixd">[in] - in-place translation</param>
///  <param name="hshift">[in] - horizontal shift hshift  is greater  0 is to right</param>
///  <param name="vshift">[in] - vertical shift vshift  is greater  0 is down</param>
///  <param name="incolor">[in] - L_BRING_IN_WHITE, L_BRING_IN_BLACK</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixRasteropIP(
				 Pix pixd, 
				 int hshift, 
				 int vshift, 
				 int incolor){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
	int _Result = Natives.pixRasteropIP(pixd.Pointer,   hshift,   vshift,   incolor);
	
	return _Result;
}

// rop.c (502, 1)
// pixRasteropFullImage(pixd, pixs, op) as int
// pixRasteropFullImage(PIX *, PIX *, l_int32) as l_ok
///  <summary>
/// ~ this is a wrapper for a common 2-image raster operation
/// ~ both pixs and pixd must be defined
/// ~ the operation is performed with aligned UL corners of pixs and pixd
/// ~ the operation clips to the smallest pix if the width or height
/// of pixd is larger than pixs, some pixels in pixd will be unchanged
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRasteropFullImage/*"/>
///  <param name="pixd">[in] - </param>
///  <param name="pixs">[in] - </param>
///  <param name="op">[in] - any of the op-codes</param>
///   <returns>0 if OK 1 on error</returns>
public static int pixRasteropFullImage(
				 Pix pixd, 
				 Pix pixs, 
				 int op){

if (pixd == null) {throw new ArgumentNullException  ("pixd cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
	int _Result = Natives.pixRasteropFullImage(pixd.Pointer, pixs.Pointer,   op);
	
	return _Result;
}


}
}
