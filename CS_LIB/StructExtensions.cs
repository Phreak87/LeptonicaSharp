using Enumerations;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using LeptonicaSharp ;
using System;

public partial class L_Bytea{
// bytearray.c (93, 1)
// l_byteaCreate(nbytes) as L_Bytea
// l_byteaCreate(size_t) as L_BYTEA *
///  <summary>
/// (1) The allocated array is n + 1 bytes.  This allows room
/// for null termination.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCreate/*"/>
///  <param name="nbytes">[in] - determines initial size of data array</param>
	// CreateAdditiveFunction: Constructor
	public L_Bytea (uint nbytes) {
	  L_Bytea RetObj = _All.l_byteaCreate(nbytes);
	  Pointer = RetObj.Pointer;
	}

// bytearray.c (122, 1)
// l_byteaInitFromMem(data, size) as L_Bytea
// l_byteaInitFromMem(const l_uint8 *, size_t) as L_BYTEA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaInitFromMem/*"/>
///  <param name="data">[in] - to be copied to the array</param>
///  <param name="size">[in] - amount of data</param>
	// CreateAdditiveFunction: Constructor
	public L_Bytea (Byte[] data, 
				 uint size) {
	  L_Bytea RetObj = _All.l_byteaInitFromMem(data, size);
	  Pointer = RetObj.Pointer;
	}

// bytearray.c (149, 1)
// l_byteaInitFromFile(fname) as L_Bytea
// l_byteaInitFromFile(const char *) as L_BYTEA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaInitFromFile/*"/>
///  <param name="fname">[in] - </param>
	// CreateAdditiveFunction: Constructor
	public L_Bytea (String fname) {
	  L_Bytea RetObj = _All.l_byteaInitFromFile(fname);
	  Pointer = RetObj.Pointer;
	}

// bytearray.c (396, 1)
// l_byteaAppendString(ba, str) as int
// l_byteaAppendString(L_BYTEA *, const char *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaAppendString/*"/>
///  <param name="str">[in] - null-terminated string to be appended</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaAppendString (String str) {
	  int RetObj = _All.l_byteaAppendString(this, str);
	  return RetObj;
	}

// bytearray.c (363, 1)
// l_byteaAppendData(ba, newdata, newbytes) as int
// l_byteaAppendData(L_BYTEA *, const l_uint8 *, size_t) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaAppendData/*"/>
///  <param name="newdata">[in] - byte array to be appended</param>
///  <param name="newbytes">[in] - size of data array</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaAppendData (Byte[] newdata, 
				 uint newbytes) {
	  int RetObj = _All.l_byteaAppendData(this, newdata, newbytes);
	  return RetObj;
	}

// bytearray.c (213, 1)
// l_byteaCopy(bas, copyflag) as L_Bytea
// l_byteaCopy(L_BYTEA *, l_int32) as L_BYTEA *
///  <summary>
/// (1) If cloning, up the refcount and return a ptr to %bas.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCopy/*"/>
///  <param name="bas">[in] - source lba</param>
///  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
///   <returns>clone or copy of bas, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public L_Bytea l_byteaCopy (L_Bytea bas, 
				 int copyflag) {
	  L_Bytea RetObj = _All.l_byteaCopy(bas, copyflag);
	  return RetObj;
	}

// bytearray.c (333, 1)
// l_byteaCopyData(ba, psize) as Byte[]
// l_byteaCopyData(L_BYTEA *, size_t *) as l_uint8 *
///  <summary>
/// (1) The returned data is owned by the caller.  The input %ba
/// still owns the original data array.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaCopyData/*"/>
///  <param name="psize">[out] - size of data in lba</param>
///   <returns>copy of data in use in the data array, or NULL on error.</returns>
	// CreateAdditiveFunction: Function/Return
	public Byte[] l_byteaCopyData (out uint psize) {
	  Byte[] RetObj = _All.l_byteaCopyData(this, out psize);
	  return RetObj;
	}

// bytearray.c (304, 1)
// l_byteaGetData(ba, psize) as Byte[]
// l_byteaGetData(L_BYTEA *, size_t *) as l_uint8 *
///  <summary>
/// (1) The returned ptr is owned by %ba.  Do not free it!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaGetData/*"/>
///  <param name="psize">[out] - size of data in lba</param>
///   <returns>ptr to existing data array, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Byte[] l_byteaGetData (out uint psize) {
	  Byte[] RetObj = _All.l_byteaGetData(this, out psize);
	  return RetObj;
	}

// bytearray.c (465, 1)
// l_byteaJoin(ba1, pba2) as int
// l_byteaJoin(L_BYTEA *, L_BYTEA **) as l_ok
///  <summary>
/// (1) It is a no-op, not an error, for %ba2 to be null.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaJoin/*"/>
///  <param name="ba1">[in] - </param>
///  <param name="pba2">[in,out] - data array is added to the one in ba1, and then ba2 is destroyed</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaJoin (L_Bytea ba1, 
				ref L_Bytea pba2) {
	  int RetObj = _All.l_byteaJoin(ba1, ref pba2);
	  return RetObj;
	}

// bytearray.c (497, 1)
// l_byteaSplit(ba1, splitloc, pba2) as int
// l_byteaSplit(L_BYTEA *, size_t, L_BYTEA **) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaSplit/*"/>
///  <param name="ba1">[in] - lba to split array bytes nulled beyond the split loc</param>
///  <param name="splitloc">[in] - location in ba1 to split ba2 begins there</param>
///  <param name="pba2">[out] - with data starting at splitloc</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaSplit (L_Bytea ba1, 
				 uint splitloc, 
				out L_Bytea pba2) {
	  int RetObj = _All.l_byteaSplit(ba1, splitloc, out pba2);
	  return RetObj;
	}

// bytearray.c (578, 1)
// l_byteaWrite(fname, ba, startloc, endloc) as int
// l_byteaWrite(const char *, L_BYTEA *, size_t, size_t) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaWrite/*"/>
///  <param name="fname">[in] - output file</param>
///  <param name="startloc">[in] - first byte to output</param>
///  <param name="endloc">[in] - last byte to output use 0 to write to the end of the data array</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaWrite (String fname, 
				 uint startloc, 
				 uint endloc) {
	  int RetObj = _All.l_byteaWrite(fname, this, startloc, endloc);
	  return RetObj;
	}

// bytearray.c (612, 1)
// l_byteaWriteStream(fp, ba, startloc, endloc) as int
// l_byteaWriteStream(FILE *, L_BYTEA *, size_t, size_t) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_byteaWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for binary write</param>
///  <param name="startloc">[in] - first byte to output</param>
///  <param name="endloc">[in] - last byte to output use 0 to write to the end of the data array</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int l_byteaWriteStream (FILE fp, 
				 uint startloc, 
				 uint endloc) {
	  int RetObj = _All.l_byteaWriteStream(fp, this, startloc, endloc);
	  return RetObj;
	}


}
public partial class Pix{
// readfile.c (189, 1)
// pixRead(filename) as Pix
// pixRead(const char *) as PIX *
///  <summary>
/// (1) See at top of file for supported formats.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixRead/*"/>
///  <param name="filename">[in] - with full pathname or in local directory</param>
	// CreateAdditiveFunction: Constructor
	public Pix (String filename) {
	  Pix RetObj = _All.pixRead(filename);
	  Pointer = RetObj.Pointer;
	}

// pixconv.c (3233, 1)
// pixConvertTo32(pixs) as Pix
// pixConvertTo32(PIX *) as PIX *
///  <summary>
/// (1) Never returns a clone of pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo32/*"/>
///   <returns>pixd 32 bpp, or NULL on error Usage: Top-level function, with simple default values for unpacking. 1 bpp:  val0 = 255, val1 = 0 and then replication into R, G and B components 2 bpp:  if colormapped, use the colormap values otherwise, use val0 = 0, val1 = 0x55, val2 = 0xaa, val3 = 255 and replicate gray into R, G and B components 4 bpp:  if colormapped, use the colormap values otherwise, replicate 2 nybs into a byte, and then into R,G,B components 8 bpp:  if colormapped, use the colormap values otherwise, replicate gray values into R, G and B components 16 bpp: replicate MSB into R, G and B components 24 bpp: unpack the pixels, maintaining word alignment on each scanline 32 bpp: makes a copy</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo32 () {
	  Pix RetObj = _All.pixConvertTo32(this);
	  return RetObj;
	}

// pixconv.c (3184, 1)
// pixConvertTo16(pixs) as Pix
// pixConvertTo16(PIX *) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo16/*"/>
///   <returns>pixd 16 bpp, or NULL on error Usage: Top-level function, with simple default values for unpacking. 1 bpp:  val0 = 0xffff, val1 = 0 8 bpp:  replicates the 8 bit value in both the MSB and LSB of the 16 bit pixel.</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo16 () {
	  Pix RetObj = _All.pixConvertTo16(this);
	  return RetObj;
	}

// pixconv.c (3041, 1)
// pixConvertTo8(pixs, cmapflag) as Pix
// pixConvertTo8(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This is a top-level function, with simple default values
/// for unpacking.<para/>
/// 
/// (2) The result, pixd, is made with a colormap if specified.
/// It is always a new image -- never a clone.  For example,
/// if d == 8, and cmapflag matches the existence of a cmap
/// in pixs, the operation is lossless and it returns a copy.<para/>
/// 
/// (3) The default values used are:
/// ~ 1 bpp: val0 = 255, val1 = 0
/// ~ 2 bpp: 4 bpp:  even increments over dynamic range
/// ~ 8 bpp: lossless if cmap matches cmapflag
/// ~ 16 bpp: use most significant byte<para/>
/// 
/// (4) If 32 bpp RGB, this is converted to gray.  If you want
/// to do color quantization, you must specify the type
/// explicitly, using the color quantization code.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo8/*"/>
///  <param name="cmapflag">[in] - TRUE if pixd is to have a colormap FALSE otherwise</param>
///   <returns>pixd 8 bpp, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo8 (int cmapflag) {
	  Pix RetObj = _All.pixConvertTo8(this, cmapflag);
	  return RetObj;
	}

// pixconv.c (2826, 1)
// pixConvertTo4(pixs) as Pix
// pixConvertTo4(PIX *) as PIX *
///  <summary>
/// (1) This is a top-level function, with simple default values
/// used in pixConvertTo8() if unpacking is necessary.<para/>
/// 
/// (2) Any existing colormap is removed the result is always gray.<para/>
/// 
/// (3) If the input image has 4 bpp and no colormap, the operation is
/// lossless and a copy is returned.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo4/*"/>
///   <returns>pixd   4 bpp, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo4 () {
	  Pix RetObj = _All.pixConvertTo4(this);
	  return RetObj;
	}

// pixconv.c (2718, 1)
// pixConvertTo2(pixs) as Pix
// pixConvertTo2(PIX *) as PIX *
///  <summary>
/// (1) This is a top-level function, with simple default values
/// used in pixConvertTo8() if unpacking is necessary.<para/>
/// 
/// (2) Any existing colormap is removed the result is always gray.<para/>
/// 
/// (3) If the input image has 2 bpp and no colormap, the operation is
/// lossless and a copy is returned.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo2/*"/>
///   <returns>pixd   2 bpp, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo2 () {
	  Pix RetObj = _All.pixConvertTo2(this);
	  return RetObj;
	}

// pixconv.c (2933, 1)
// pixConvertTo1(pixs, threshold) as Pix
// pixConvertTo1(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This is a top-level function, with simple default values
/// used in pixConvertTo8() if unpacking is necessary.<para/>
/// 
/// (2) Any existing colormap is removed.<para/>
/// 
/// (3) If the input image has 1 bpp and no colormap, the operation is
/// lossless and a copy is returned.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertTo1/*"/>
///  <param name="threshold">[in] - for final binarization, relative to 8 bpp</param>
///   <returns>pixd 1 bpp, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertTo1 (int threshold) {
	  Pix RetObj = _All.pixConvertTo1(this, threshold);
	  return RetObj;
	}

// pix1.c (630, 1)
// pixCopy(pixd, pixs) as Pix
// pixCopy(PIX *, PIX *) as PIX *
///  <summary>
/// (1) There are three cases:
/// (a) pixd == null  (makes a new pix refcount = 1)
/// (b) pixd == pixs  (no-op)
/// (c) pixd != pixs  (data copy no change in refcount)
/// If the refcount of pixd  is greater  1, case (c) will side-effect
/// these handles.<para/>
/// 
/// (2) The general pattern of use is:
/// pixd = pixCopy(pixd, pixs)
/// This will work for all three cases.
/// For clarity when the case is known, you can use:
/// (a) pixd = pixCopy(NULL, pixs)
/// (c) pixCopy(pixd, pixs)<para/>
/// 
/// (3) For case (c), we check if pixs and pixd are the same
/// size (w,h,d).  If so, the data is copied directly.
/// Otherwise, the data is reallocated to the correct size
/// and the copy proceeds.  The refcount of pixd is unchanged.<para/>
/// 
/// (4) This operation, like all others that may involve a pre-existing
/// pixd, will side-effect any existing clones of pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCopy/*"/>
///  <param name="pixd">[in][optional] - can be null, equal to pixs, different from pixs</param>
///   <returns>pixd, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixCopy (Pix pixd) {
	  Pix RetObj = _All.pixCopy(pixd, this);
	  return RetObj;
	}

// skew.c (205, 1)
// pixDeskew(pixs, redsearch) as Pix
// pixDeskew(PIX *, l_int32) as PIX *
///  <summary>
/// (1) This binarizes if necessary and finds the skew angle.  If the
/// angle is large enough and there is sufficient confidence,
/// it returns a deskewed image otherwise, it returns a clone.<para/>
/// 
/// (2) Typical values at 300 ppi for %redsearch are 2 and 4.
/// At 75 ppi, one should use %redsearch = 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixDeskew/*"/>
///  <param name="redsearch">[in] - for binary search: reduction factor = 1, 2 or 4 use 0 for default</param>
///   <returns>pixd deskewed pix, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixDeskew (int redsearch) {
	  Pix RetObj = _All.pixDeskew(this, redsearch);
	  return RetObj;
	}

// pix3.c (1395, 1)
// pixInvert(pixd, pixs) as Pix
// pixInvert(PIX *, PIX *) as PIX *
///  <summary>
/// (1) This inverts pixs, for all pixel depths.<para/>
/// 
/// (2) There are 3 cases:
/// (a) pixd == null, ~src to new pixd
/// (b) pixd == pixs, ~src to src  (in-place)
/// (c) pixd != pixs, ~src to input pixd<para/>
/// 
/// (3) For clarity, if the case is known, use these patterns:
/// (a) pixd = pixInvert(NULL, pixs)
/// (b) pixInvert(pixs, pixs)
/// (c) pixInvert(pixd, pixs)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixInvert/*"/>
///  <param name="pixd">[in][optional] - this can be null, equal to pixs, or different from pixs</param>
///   <returns>pixd, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixInvert (Pix pixd) {
	  Pix RetObj = _All.pixInvert(pixd, this);
	  return RetObj;
	}

// flipdetect.c (242, 1)
// pixOrientCorrect(pixs, minupconf, minratio, pupconf, pleftconf, protation, debug) as Pix
// pixOrientCorrect(PIX *, l_float32, l_float32, l_float32 *, l_float32 *, l_int32 *, l_int32) as PIX *
///  <summary>
/// (1) Simple top-level function to detect if Roman text is in
/// reading orientation, and to rotate the image accordingly if not.<para/>
/// 
/// (2) Returns a copy if no rotation is needed.<para/>
/// 
/// (3) See notes for pixOrientDetect() and pixOrientDecision().
/// Use 0.0 for default values for %minupconf and %minratio<para/>
/// 
/// (4) Optional output of intermediate confidence results and
/// the rotation performed on pixs.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOrientCorrect/*"/>
///  <param name="minupconf">[in] - minimum value for which a decision can be made</param>
///  <param name="minratio">[in] - minimum conf ratio required for a decision</param>
///  <param name="pupconf">[out][optional] - use NULL to skip</param>
///  <param name="pleftconf">[out][optional] - use NULL to skip</param>
///  <param name="protation">[out][optional] - use NULL to skip</param>
///  <param name="debug">[in] - 1 for debug output 0 otherwise</param>
///   <returns>pixd  may be rotated by 90, 180 or 270 null on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixOrientCorrect (Single minupconf, 
				 Single minratio, 
				out Single pupconf, 
				out Single pleftconf, 
				out int protation, 
				 DebugOnOff debug) {
	  Pix RetObj = _All.pixOrientCorrect(this, minupconf, minratio, out pupconf, out pleftconf, out protation, debug);
	  return RetObj;
	}

// adaptmap.c (231, 1)
// pixBackgroundNormSimple(pixs, pixim, pixg) as Pix
// pixBackgroundNormSimple(PIX *, PIX *, PIX *) as PIX *
///  <summary>
/// (1) This is a simplified interface to pixBackgroundNorm(),
/// where seven parameters are defaulted.<para/>
/// 
/// (2) The input image is either grayscale or rgb.<para/>
/// 
/// (3) See pixBackgroundNorm() for usage and function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixBackgroundNormSimple/*"/>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixBackgroundNormSimple (Pix pixim, 
				 Pix pixg) {
	  Pix RetObj = _All.pixBackgroundNormSimple(this, pixim, pixg);
	  return RetObj;
	}

// adaptmap.c (185, 1)
// pixCleanBackgroundToWhite(pixs, pixim, pixg, gamma, blackval, whiteval) as Pix
// pixCleanBackgroundToWhite(PIX *, PIX *, PIX *, l_float32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This is a simplified interface for cleaning an image.
/// For comparison, see pixAdaptThresholdToBinaryGen().<para/>
/// 
/// (2) The suggested default values for the input parameters are:
/// gamma:  1.0  (reduce this to increase the contrast e.g.,
/// for light text)
/// blackval 70  (a bit more than 60)
/// whiteval  190  (a bit less than 200)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCleanBackgroundToWhite/*"/>
///  <param name="pixim">[in][optional] - 1 bpp 'image' mask can be null</param>
///  <param name="pixg">[in][optional] - 8 bpp grayscale version can be null</param>
///  <param name="gamma">[in] - gamma correction must be  is greater  0.0 typically ~1.0</param>
///  <param name="blackval">[in] - dark value to set to black (0)</param>
///  <param name="whiteval">[in] - light value to set to white (255)</param>
///   <returns>pixd 8 bpp or 32 bpp rgb, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixCleanBackgroundToWhite (Pix pixim, 
				 Pix pixg, 
				 Single gamma, 
				 int blackval, 
				 int whiteval) {
	  Pix RetObj = _All.pixCleanBackgroundToWhite(this, pixim, pixg, gamma, blackval, whiteval);
	  return RetObj;
	}

// pageseg.c (102, 1)
// pixGetRegionsBinary(pixs, ppixhm, ppixtm, ppixtb, pixadb) as int
// pixGetRegionsBinary(PIX *, PIX **, PIX **, PIX **, PIXA *) as l_ok
///  <summary>
/// (1) It is best to deskew the image before segmenting.<para/>
/// 
/// (2) Passing in %pixadb enables debug output.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetRegionsBinary/*"/>
///  <param name="ppixhm">[out][optional] - halftone mask</param>
///  <param name="ppixtm">[out][optional] - textline mask</param>
///  <param name="ppixtb">[out][optional] - textblock mask</param>
///  <param name="pixadb">[in] - input for collecting debug pix use NULL to skip</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int pixGetRegionsBinary (Pixa pixadb, 
				out Pix ppixhm, 
				out Pix ppixtm, 
				out Pix ppixtb) {
	  int RetObj = _All.pixGetRegionsBinary(this, out ppixhm, out ppixtm, out ppixtb, pixadb);
	  return RetObj;
	}

// pixconv.c (753, 1)
// pixConvertRGBToGray(pixs, rwt, gwt, bwt) as Pix
// pixConvertRGBToGray(PIX *, l_float32, l_float32, l_float32) as PIX *
///  <summary>
/// (1) Use a weighted average of the RGB values.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertRGBToGray/*"/>
///  <param name="rwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
///  <param name="gwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
///  <param name="bwt">[in] - non-negative these should add to 1.0, or use 0.0 for default</param>
///   <returns>8 bpp pix, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixConvertRGBToGray (Single rwt, 
				 Single gwt, 
				 Single bwt) {
	  Pix RetObj = _All.pixConvertRGBToGray(this, rwt, gwt, bwt);
	  return RetObj;
	}

// colorquant1.c (2587, 1)
// pixOctcubeQuantMixedWithGray(pixs, depth, graylevels, delta) as Pix
// pixOctcubeQuantMixedWithGray(PIX *, l_int32, l_int32, l_int32) as PIX *
///  <summary>
/// (1) Generates a colormapped image, where the colormap table values
/// have two components: octcube values representing pixels with
/// color content, and grayscale values for the rest.<para/>
/// 
/// (2) The threshold (delta) is the maximum allowable difference of
/// the max abs value of | r - g |, | r - b | and | g - b |.<para/>
/// 
/// (3) The octcube values are the averages of all pixels that are
/// found in the octcube, and that are far enough from gray to
/// be considered color.  This can roughly be visualized as all
/// the points in the rgb color cube that are not within a "cylinder"
/// of diameter approximately 'delta' along the main diagonal.<para/>
/// 
/// (4) We want to guarantee full coverage of the rgb color space thus,
/// if the output depth is 4, the octlevel is 1 (2 x 2 x 2 = 8 cubes)
/// and if the output depth is 8, the octlevel is 2 (4 x 4 x 4
/// = 64 cubes).<para/>
/// 
/// (5) Consequently, we have the following constraint on the number
/// of allowed gray levels: for 4 bpp, 8 for 8 bpp, 192.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixOctcubeQuantMixedWithGray/*"/>
///  <param name="depth">[in] - of output pix</param>
///  <param name="graylevels">[in] - graylevels (must be  is greater  1)</param>
///  <param name="delta">[in] - threshold for deciding if a pix is color or gray</param>
///   <returns>pixd     quantized to octcube and gray levels or NULL on error</returns>
	// CreateAdditiveFunction: Function/Return
	public Pix pixOctcubeQuantMixedWithGray (int depth, 
				 int graylevels, 
				 int delta) {
	  Pix RetObj = _All.pixOctcubeQuantMixedWithGray(this, depth, graylevels, delta);
	  return RetObj;
	}

// pix1.c (1545, 1)
// pixGetColormap(pix) as PixColormap
// pixGetColormap(PIX *) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetColormap/*"/>
///   <returns></returns>
	// CreateAdditiveFunction: Function/Return
	public PixColormap pixGetColormap () {
	  PixColormap RetObj = _All.pixGetColormap(this);
	  return RetObj;
	}

// pix1.c (1571, 1)
// pixSetColormap(pix, colormap) as int
// pixSetColormap(PIX *, PIXCMAP *) as l_ok
///  <summary>
/// (1) Unlike with the pix data field, pixSetColormap() destroys
/// any existing colormap before assigning the new one.
/// Because colormaps are not ref counted, it is important that
/// the new colormap does not belong to any other pix.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetColormap/*"/>
///  <param name="colormap">[in] - to be assigned</param>
///   <returns>0 if OK, 1 on error.</returns>
	// CreateAdditiveFunction: Function/Return
	public int pixSetColormap (PixColormap colormap) {
	  int RetObj = _All.pixSetColormap(this, colormap);
	  return RetObj;
	}

// dewarp4.c (97, 1)
// dewarpSinglePage(pixs, thresh, adaptive, useboth, check_columns, ppixd, pdewa, debug) as int
// dewarpSinglePage(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **, L_DEWARPA **, l_int32) as l_ok
///  <summary>
/// (1) Dewarps pixs and returns the result in [and]pixd.<para/>
/// 
/// (2) This uses default values for all model parameters.<para/>
/// 
/// (3) If pixs is 1 bpp, the parameters %adaptive and %thresh are ignored.<para/>
/// 
/// (4) If it can't build a model, returns a copy of pixs in [and]pixd.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/dewarpSinglePage/*"/>
///  <param name="thresh">[in] - for global thresholding to 1 bpp ignored otherwise</param>
///  <param name="adaptive">[in] - 1 for adaptive thresholding 0 for global threshold</param>
///  <param name="useboth">[in] - 1 for horizontal and vertical 0 for vertical only</param>
///  <param name="check_columns">[in] - 1 to skip horizontal if multiple columns 0 otherwise default is to skip</param>
///  <param name="pdewa">[out][optional] - dewa with single page NULL to skip</param>
///  <param name="debug">[in] - 1 for debugging output, 0 otherwise</param>
///   <returns>0 if OK, 1 on error list of page numbers, or NULL on error</returns>
	// CreateAdditiveFunction: Function/Else
	public int dewarpSinglePage (int thresh, 
				 int adaptive, 
				 int useboth, 
				 int check_columns, 
				out Pix ppixd, 
				out L_Dewarpa pdewa, 
				 DebugOnOff debug) {
	  int RetObj = _All.dewarpSinglePage(this, thresh, adaptive, useboth, check_columns, out ppixd, out pdewa, debug);
	  return RetObj;
	}

// pdfio1.c (1223, 1)
// pixConvertToPdf(pix, type, quality, fileout, x, y, res, title, plpd, position) as int
// pixConvertToPdf(PIX *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
///  <summary>
/// (1) If %res == 0 and the input resolution field is 0,
/// this will use DEFAULT_INPUT_RES.<para/>
/// 
/// (2) This only writes data to fileout if it is the last
/// image to be written on the page.<para/>
/// 
/// (3) See comments in convertToPdf().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixConvertToPdf/*"/>
///  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
///  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
///  <param name="fileout">[in] - output pdf file only required on last image on page</param>
///  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
///  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
///  <param name="res">[in] - override the resolution of the input image, in ppi use 0 to respect the resolution embedded in the input</param>
///  <param name="title">[in][optional] - pdf title</param>
///  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed</param>
///  <param name="position">[in] - in image sequence: L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
	// CreateAdditiveFunction: Sub/Default
	public int pixConvertToPdf (int type, 
				 String fileout, 
				ref L_Pdf_Data plpd, 
				 int position, 
				 int quality, 
				 int x, 
				 int y, 
				 int res, 
				 String title) {
	  int RetObj = _All.pixConvertToPdf(this, type, quality, fileout, x, y, res, title, ref plpd, position);
	   return RetObj;
	}


}
public partial class PixColormap{
// colormap.c (110, 1)
// pixcmapCreate(depth) as PixColormap
// pixcmapCreate(l_int32) as PIXCMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapCreate/*"/>
///  <param name="depth">[in] - bpp, of pix</param>
	// CreateAdditiveFunction: Constructor
	public PixColormap (int depth) {
	  PixColormap RetObj = _All.pixcmapCreate(depth);
	  Pointer = RetObj.Pointer;
	}

// colormap.c (593, 1)
// pixcmapGetCount(cmap) as int
// pixcmapGetCount(PIXCMAP *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetCount/*"/>
///   <returns>count, or 0 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int pixcmapGetCount () {
	  int RetObj = _All.pixcmapGetCount(this);
	  return RetObj;
	}

// colormap.c (709, 1)
// pixcmapGetColor(cmap, index, prval, pgval, pbval) as int
// pixcmapGetColor(PIXCMAP *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapGetColor/*"/>
///  <param name="index">[in] - </param>
///  <param name="prval">[out] - each color value</param>
///  <param name="pgval">[out] - each color value</param>
///  <param name="pbval">[out] - each color value</param>
///   <returns>0 if OK, 1 if not accessible caller should check</returns>
	// CreateAdditiveFunction: Function/Return
	public int pixcmapGetColor (int index, 
				out int prval, 
				out int pgval, 
				out int pbval) {
	  int RetObj = _All.pixcmapGetColor(this, index, out prval, out pgval, out pbval);
	  return RetObj;
	}

// colormap.c (299, 1)
// pixcmapAddColor(cmap, rval, gval, bval) as int
// pixcmapAddColor(PIXCMAP *, l_int32, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This always adds the color if there is room.<para/>
/// 
/// (2) The alpha component is 255 (opaque)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcmapAddColor/*"/>
///  <param name="rval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="gval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///  <param name="bval">[in] - colormap entry to be added each number is in range [0, ... 255]</param>
///   <returns>0 if OK, 1 on error</returns>
	// CreateAdditiveFunction: Function/Return
	public int pixcmapAddColor (int rval, 
				 int gval, 
				 int bval) {
	  int RetObj = _All.pixcmapAddColor(this, rval, gval, bval);
	  return RetObj;
	}


}
