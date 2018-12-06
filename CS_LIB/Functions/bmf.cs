using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// bmf.c (114, 1)
// bmfCreate(dir, fontsize) as L_Bmf
// bmfCreate(const char *, l_int32) as L_BMF *
///  <summary>
/// (1) If %dir == null, this generates the font bitmaps from a
/// compiled string.<para/>
/// 
/// (2) Otherwise, this tries to read a pre-computed pixa file with the
/// 95 ascii chars in it.  If the file is not found, it then
/// attempts to generate the pixa and associated baseline
/// data from a tiff image containing all the characters.  If
/// that fails, it uses the compiled string.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfCreate/*"/>
///  <param name="dir">[in][optional] - directory holding pixa of character set</param>
///  <param name="fontsize">[in] - 4, 6, 8, ... , 20</param>
///   <returns>bmf holding the bitmap font and associated information</returns>
public static L_Bmf bmfCreate(
				 String dir, 
				 int fontsize){

	IntPtr _Result = Natives.bmfCreate(  dir,   fontsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Bmf(_Result);
}

// bmf.c (166, 1)
// bmfDestroy(pbmf) as Object
// bmfDestroy(L_BMF **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfDestroy/*"/>
///  <param name="pbmf">[in,out] - set to null</param>
public static void bmfDestroy(
				ref L_Bmf pbmf){

	IntPtr pbmfPtr = IntPtr.Zero; 	if (pbmf != null) {pbmfPtr = pbmf.Pointer;}

	Natives.bmfDestroy(ref pbmfPtr);
	
	if (pbmfPtr == IntPtr.Zero) {pbmf = null;} else { pbmf = new L_Bmf(pbmfPtr); };
}

// bmf.c (202, 1)
// bmfGetPix(bmf, chr) as Pix
// bmfGetPix(L_BMF *, char) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetPix/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="chr">[in] - should be one of the 95 supported printable bitmaps</param>
///   <returns>pix clone of pix in bmf, or NULL on error</returns>
public static Pix bmfGetPix(
				 L_Bmf bmf, 
				 char chr){

	IntPtr _Result = Natives.bmfGetPix(bmf.Pointer,   chr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// bmf.c (237, 1)
// bmfGetWidth(bmf, chr, pw) as int
// bmfGetWidth(L_BMF *, char, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetWidth/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="chr">[in] - should be one of the 95 supported bitmaps</param>
///  <param name="pw">[out] - character width -1 if not printable</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bmfGetWidth(
				 L_Bmf bmf, 
				 char chr, 
				out int pw){

	int _Result = Natives.bmfGetWidth(bmf.Pointer,   chr, out  pw);
	
	return _Result;
}

// bmf.c (276, 1)
// bmfGetBaseline(bmf, chr, pbaseline) as int
// bmfGetBaseline(L_BMF *, char, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetBaseline/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="chr">[in] - should be one of the 95 supported bitmaps</param>
///  <param name="pbaseline">[out] - distance below UL corner of bitmap char</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bmfGetBaseline(
				 L_Bmf bmf, 
				 char chr, 
				out int pbaseline){

	int _Result = Natives.bmfGetBaseline(bmf.Pointer,   chr, out  pbaseline);
	
	return _Result;
}

// bmf.c (322, 1)
// pixaGetFont(dir, fontsize, pbl0, pbl1, pbl2) as Pixa
// pixaGetFont(const char *, l_int32, l_int32 *, l_int32 *, l_int32 *) as PIXA *
///  <summary>
/// (1) This reads a pre-computed pixa file with the 95 ascii chars.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetFont/*"/>
///  <param name="dir">[in] - directory holding pixa of character set</param>
///  <param name="fontsize">[in] - 4, 6, 8, ... , 20</param>
///  <param name="pbl0">[out] - baseline of row 1</param>
///  <param name="pbl1">[out] - baseline of row 2</param>
///  <param name="pbl2">[out] - baseline of row 3</param>
///   <returns>pixa of font bitmaps for 95 characters, or NULL on error</returns>
public static Pixa pixaGetFont(
				 String dir, 
				 int fontsize, 
				out int pbl0, 
				out int pbl1, 
				out int pbl2){

	IntPtr _Result = Natives.pixaGetFont(  dir,   fontsize, out  pbl0, out  pbl1, out  pbl2);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// bmf.c (372, 1)
// pixaSaveFont(indir, outdir, fontsize) as int
// pixaSaveFont(const char *, const char *, l_int32) as l_ok
///  <summary>
/// (1) This saves a font of a particular size.<para/>
/// 
/// (2) If %dir == null, this generates the font bitmaps from a
/// compiled string.<para/>
/// 
/// (3) prog/genfonts calls this function for each of the
/// nine font sizes, to generate all the font pixa files.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSaveFont/*"/>
///  <param name="indir">[in][optional] - directory holding image of character set</param>
///  <param name="outdir">[in] - directory into which the output pixa file will be written</param>
///  <param name="fontsize">[in] - in pts, at 300 ppi</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixaSaveFont(
				 String indir, 
				 String outdir, 
				 int fontsize){

	int _Result = Natives.pixaSaveFont(  indir,   outdir,   fontsize);
	
	return _Result;
}


}
}
