using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// textops.c (115, 1)
// pixAddSingleTextblock(pixs, bmf, textstr, val, location, poverflow) as Pix
// pixAddSingleTextblock(PIX *, L_BMF *, const char *, l_uint32, l_int32, l_int32 *) as PIX *
///  <summary>
/// (1) This function paints a set of lines of text over an image.
/// If %location is L_ADD_ABOVE or L_ADD_BELOW, the pix size
/// is expanded with a border and rendered over the border.<para/>
/// 
/// (2) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.<para/>
/// 
/// (3) If textstr == NULL, use the text field in the pix.<para/>
/// 
/// (4) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.<para/>
/// 
/// (5) Typical usage is for labelling a pix with some text data.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddSingleTextblock/*"/>
///  <param name="pixs">[in] - input pix colormap ok</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="textstr">[in][optional] - text string to be added</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_AT_TOP, L_ADD_AT_BOT, L_ADD_BELOW</param>
///  <param name="poverflow">[out][optional] - 1 if text overflows allocated region and is clipped 0 otherwise</param>
///   <returns>pixd new pix with rendered text, or either a copy or NULL on error</returns>
public static Pix pixAddSingleTextblock(
				 Pix pixs, 
				 L_Bmf bmf, 
				 String textstr, 
				 uint val, 
				 int location, 
				out int poverflow){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
	IntPtr _Result = Natives.pixAddSingleTextblock(pixs.Pointer, bmf.Pointer,   textstr,   val,   location, out  poverflow);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// textops.c (270, 1)
// pixAddTextlines(pixs, bmf, textstr, val, location) as Pix
// pixAddTextlines(PIX *, L_BMF *, const char *, l_uint32, l_int32) as PIX *
///  <summary>
/// (1) This function expands an image as required to paint one or
/// more lines of text adjacent to the image.  If %bmf == NULL,
/// this returns a copy.  If above or below, the lines are
/// centered with respect to the image if left or right, they
/// are left justified.<para/>
/// 
/// (2) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.<para/>
/// 
/// (3) If textstr == NULL, use the text field in the pix.  The
/// text field contains one or most "lines" of text, where newlines
/// are used as line separators.<para/>
/// 
/// (4) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.<para/>
/// 
/// (5) Typical usage is for labelling a pix with some text data.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixAddTextlines/*"/>
///  <param name="pixs">[in] - input pix colormap ok</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="textstr">[in][optional] - text string to be added</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_BELOW, L_ADD_LEFT, L_ADD_RIGHT</param>
///   <returns>pixd new pix with rendered text, or either a copy or NULL on error</returns>
public static Pix pixAddTextlines(
				 Pix pixs, 
				 L_Bmf bmf, 
				 String textstr, 
				 uint val, 
				 int location){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
	IntPtr _Result = Natives.pixAddTextlines(pixs.Pointer, bmf.Pointer,   textstr,   val,   location);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pix(_Result);
}

// textops.c (431, 1)
// pixSetTextblock(pixs, bmf, textstr, val, x0, y0, wtext, firstindent, poverflow) as int
// pixSetTextblock(PIX *, L_BMF *, const char *, l_uint32, l_int32, l_int32, l_int32, l_int32, l_int32 *) as l_ok
///  <summary>
/// (1) This function paints a set of lines of text over an image.<para/>
/// 
/// (2) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.
/// The last two hex digits are 00 (byte value 0), assigned to
/// the A component.  Note that, as usual, RGBA proceeds from
/// left to right in the order from MSB to LSB (see pix.h
/// for details).<para/>
/// 
/// (3) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetTextblock/*"/>
///  <param name="pixs">[in] - input image</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="textstr">[in] - block text string to be set</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="x0">[in] - left edge for each line of text</param>
///  <param name="y0">[in] - baseline location for the first text line</param>
///  <param name="wtext">[in] - max width of each line of generated text</param>
///  <param name="firstindent">[in] - indentation of first line, in x-widths</param>
///  <param name="poverflow">[out][optional] - 0 if text is contained in input pix 1 if it is clipped</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSetTextblock(
				 Pix pixs, 
				 L_Bmf bmf, 
				 String textstr, 
				 uint val, 
				 int x0, 
				 int y0, 
				 int wtext, 
				 int firstindent, 
				out int poverflow){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
		if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
	int _Result = Natives.pixSetTextblock(pixs.Pointer, bmf.Pointer,   textstr,   val,   x0,   y0,   wtext,   firstindent, out  poverflow);
	
	return _Result;
}

// textops.c (544, 1)
// pixSetTextline(pixs, bmf, textstr, val, x0, y0, pwidth, poverflow) as int
// pixSetTextline(PIX *, L_BMF *, const char *, l_uint32, l_int32, l_int32, l_int32 *, l_int32 *) as l_ok
///  <summary>
/// (1) This function paints a line of text over an image.<para/>
/// 
/// (2) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.
/// The last two hex digits are 00 (byte value 0), assigned to
/// the A component.  Note that, as usual, RGBA proceeds from
/// left to right in the order from MSB to LSB (see pix.h
/// for details).<para/>
/// 
/// (3) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSetTextline/*"/>
///  <param name="pixs">[in] - input image</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="textstr">[in] - text string to be set on the line</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="x0">[in] - left edge for first char</param>
///  <param name="y0">[in] - baseline location for all text on line</param>
///  <param name="pwidth">[out][optional] - width of generated text</param>
///  <param name="poverflow">[out][optional] - 0 if text is contained in input pix 1 if it is clipped</param>
///   <returns>0 if OK, 1 on error</returns>
public static int pixSetTextline(
				 Pix pixs, 
				 L_Bmf bmf, 
				 String textstr, 
				 uint val, 
				 int x0, 
				 int y0, 
				out int pwidth, 
				out int poverflow){

if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
		if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
	int _Result = Natives.pixSetTextline(pixs.Pointer, bmf.Pointer,   textstr,   val,   x0,   y0, out  pwidth, out  poverflow);
	
	return _Result;
}

// textops.c (641, 1)
// pixaAddTextNumber(pixas, bmf, na, val, location) as Pixa
// pixaAddTextNumber(PIXA *, L_BMF *, NUMA *, l_uint32, l_int32) as PIXA *
///  <summary>
/// (1) Typical usage is for labelling each pix in a pixa with a number.<para/>
/// 
/// (2) This function paints numbers external to each pix, in a position
/// given by %location.  In all cases, the pix is expanded on
/// on side and the number is painted over white in the added region.<para/>
/// 
/// (3) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.<para/>
/// 
/// (4) If na == NULL, number each pix sequentially, starting with 1.<para/>
/// 
/// (5) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddTextNumber/*"/>
///  <param name="pixas">[in] - input pixa colormap ok</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="na">[in][optional] - number array use 1 ... n if null</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_BELOW, L_ADD_LEFT, L_ADD_RIGHT</param>
///   <returns>pixad new pixa with rendered numbers, or NULL on error</returns>
public static Pixa pixaAddTextNumber(
				 Pixa pixas, 
				 L_Bmf bmf, 
				 Numa na, 
				 uint val, 
				 int location){

if (pixas == null) {throw new ArgumentNullException  ("pixas cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
	IntPtr naPtr = IntPtr.Zero; 	if (na != null) {naPtr = na.Pointer;}

	IntPtr _Result = Natives.pixaAddTextNumber(pixas.Pointer, bmf.Pointer, naPtr,   val,   location);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// textops.c (710, 1)
// pixaAddTextlines(pixas, bmf, sa, val, location) as Pixa
// pixaAddTextlines(PIXA *, L_BMF *, SARRAY *, l_uint32, l_int32) as PIXA *
///  <summary>
/// (1) This function adds one or more lines of text externally to
/// each pix, in a position given by %location.  In all cases,
/// the pix is expanded as necessary to accommodate the text.<para/>
/// 
/// (2) %val is the pixel value to be painted through the font mask.
/// It should be chosen to agree with the depth of pixs.
/// If it is out of bounds, an intermediate value is chosen.
/// For RGB, use hex notation: 0xRRGGBB00, where RR is the
/// hex representation of the red intensity, etc.<para/>
/// 
/// (3) If sa == NULL, use the text embedded in each pix.  In all
/// cases, newlines in the text string are used to separate the
/// lines of text that are added to the pix.<para/>
/// 
/// (4) If sa has a smaller count than pixa, issue a warning
/// and do not use any embedded text.<para/>
/// 
/// (5) If there is a colormap, this does the best it can to use
/// the requested color, or something similar to it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddTextlines/*"/>
///  <param name="pixas">[in] - input pixa colormap ok</param>
///  <param name="bmf">[in] - bitmap font data</param>
///  <param name="sa">[in][optional] - sarray use text embedded in each pix if null</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_BELOW, L_ADD_LEFT, L_ADD_RIGHT</param>
///   <returns>pixad new pixa with rendered text, or NULL on error</returns>
public static Pixa pixaAddTextlines(
				 Pixa pixas, 
				 L_Bmf bmf, 
				 Sarray sa, 
				 uint val, 
				 int location){

if (pixas == null) {throw new ArgumentNullException  ("pixas cannot be Nothing");}
		if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
	IntPtr saPtr = IntPtr.Zero; 	if (sa != null) {saPtr = sa.Pointer;}

	IntPtr _Result = Natives.pixaAddTextlines(pixas.Pointer, bmf.Pointer, saPtr,   val,   location);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Pixa(_Result);
}

// textops.c (780, 1)
// pixaAddPixWithText(pixa, pixs, reduction, bmf, textstr, val, location) as int
// pixaAddPixWithText(PIXA *, PIX *, l_int32, L_BMF *, const char *, l_uint32, l_int32) as l_ok
///  <summary>
/// (1) This function generates a new pix with added text, and adds
/// it by insertion into the pixa.<para/>
/// 
/// (2) If the input pixs is not cmapped and not 32 bpp, it is
/// converted to 32 bpp rgb.  %val is a standard 32 bpp pixel,
/// expressed as 0xrrggbb00.  If there is a colormap, this does
/// the best it can to use the requested color, or something close.<para/>
/// 
/// (3) if %bmf == NULL, generate an 8 pt font this takes about 5 msec.<para/>
/// 
/// (4) If %textstr == NULL, use the text field in the pix.<para/>
/// 
/// (5) In general, the text string can be written in multiple lines
/// use newlines as the separators.<para/>
/// 
/// (6) Typical usage is for debugging, where the pixa of labeled images
/// is used to generate a pdf.  Suggest using 1.0 for scalefactor.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaAddPixWithText/*"/>
///  <param name="pixa">[in] - </param>
///  <param name="pixs">[in] - any depth, colormap ok</param>
///  <param name="reduction">[in] - integer subsampling factor</param>
///  <param name="bmf">[in][optional] - bitmap font data</param>
///  <param name="textstr">[in][optional] - text string to be added</param>
///  <param name="val">[in] - color to set the text</param>
///  <param name="location">[in] - L_ADD_ABOVE, L_ADD_BELOW, L_ADD_LEFT, L_ADD_RIGHT</param>
///   <returns>0 if OK, 1 on error.</returns>
public static int pixaAddPixWithText(
				 Pixa pixa, 
				 Pix pixs, 
				 int reduction, 
				 L_Bmf bmf, 
				 String textstr, 
				 uint val, 
				 int location){

if (pixa == null) {throw new ArgumentNullException  ("pixa cannot be Nothing");}
		if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}
if (reduction > 2 && reduction < 16){
	   throw new ArgumentException ("integer subsampling factor");
	};
	IntPtr bmfPtr = IntPtr.Zero; 	if (bmf != null) {bmfPtr = bmf.Pointer;}

	int _Result = Natives.pixaAddPixWithText(pixa.Pointer, pixs.Pointer,   reduction, bmfPtr,   textstr,   val,   location);
	
	return _Result;
}

// textops.c (862, 1)
// bmfGetLineStrings(bmf, textstr, maxw, firstindent, ph) as Sarray
// bmfGetLineStrings(L_BMF *, const char *, l_int32, l_int32, l_int32 *) as SARRAY *
///  <summary>
/// (1) Divides the input text string into an array of text strings,
/// each of which will fit within maxw bits of width.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetLineStrings/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="textstr">[in] - </param>
///  <param name="maxw">[in] - max width of a text line in pixels</param>
///  <param name="firstindent">[in] - indentation of first line, in x-widths</param>
///  <param name="ph">[out] - height required to hold text bitmap</param>
///   <returns>sarray of text strings for each line, or NULL on error</returns>
public static Sarray bmfGetLineStrings(
				 L_Bmf bmf, 
				 String textstr, 
				 int maxw, 
				 int firstindent, 
				out int ph){

if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
		if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
	IntPtr _Result = Natives.bmfGetLineStrings(bmf.Pointer,   textstr,   maxw,   firstindent, out  ph);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// textops.c (938, 1)
// bmfGetWordWidths(bmf, textstr, sa) as Numa
// bmfGetWordWidths(L_BMF *, const char *, SARRAY *) as NUMA *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetWordWidths/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="textstr">[in] - </param>
///  <param name="sa">[in] - of individual words</param>
///   <returns>numa of word lengths in pixels for the font represented by the bmf, or NULL on error</returns>
public static Numa bmfGetWordWidths(
				 L_Bmf bmf, 
				 String textstr, 
				 Sarray sa){

if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
		if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
		if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.bmfGetWordWidths(bmf.Pointer,   textstr, sa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Numa(_Result);
}

// textops.c (979, 1)
// bmfGetStringWidth(bmf, textstr, pw) as int
// bmfGetStringWidth(L_BMF *, const char *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetStringWidth/*"/>
///  <param name="bmf">[in] - </param>
///  <param name="textstr">[in] - </param>
///  <param name="pw">[out] - width of text string, in pixels for the font represented by the bmf</param>
///   <returns>0 if OK, 1 on error</returns>
public static int bmfGetStringWidth(
				 L_Bmf bmf, 
				 String textstr, 
				out int pw){

if (bmf == null) {throw new ArgumentNullException  ("bmf cannot be Nothing");}
		if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
	int _Result = Natives.bmfGetStringWidth(bmf.Pointer,   textstr, out  pw);
	
	return _Result;
}

// textops.c (1023, 1)
// splitStringToParagraphs(textstr, splitflag) as Sarray
// splitStringToParagraphs(char *, l_int32) as SARRAY *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/splitStringToParagraphs/*"/>
///  <param name="textstr">[in] - text string</param>
///  <param name="splitflag">[in] - see enum in bmf.h valid values in {1,2,3}</param>
///   <returns>sarray where each string is a paragraph of the input, or NULL on error.</returns>
public static Sarray splitStringToParagraphs(
				 String textstr, 
				 int splitflag){

if (textstr == null) {throw new ArgumentNullException  ("textstr cannot be Nothing");}
	IntPtr _Result = Natives.splitStringToParagraphs(  textstr,   splitflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}


}
}
