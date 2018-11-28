using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// recogbasic.c (232, 1)
// recogCreateFromRecog(recs, scalew, scaleh, linew, threshold, maxyshift) as L_Recog
// recogCreateFromRecog(L_RECOG *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
///  <summary>
/// (1) This is a convenience function that generates a recog using
/// the unscaled training data in an existing recog.<para/>
/// 
/// (2) It is recommended to use %maxyshift = 1 (the default value)<para/>
/// 
/// (3) See recogCreate() for use of %scalew, %scaleh and %linew.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCreateFromRecog/*"/>
///  <param name="recs">[in] - source recog with arbitrary input parameters</param>
///  <param name="scalew">[in] - scale all widths to this use 0 otherwise</param>
///  <param name="scaleh">[in] - scale all heights to this use 0 otherwise</param>
///  <param name="linew">[in] - width of normalized strokes use 0 to skip</param>
///  <param name="threshold">[in] - for binarization typically ~128</param>
///  <param name="maxyshift">[in] - from nominal centroid alignment default is 1</param>
///   <returns>recd, or NULL on error</returns>
public static L_Recog recogCreateFromRecog(
				  L_Recog recs, 
				  int scalew, 
				  int scaleh, 
				  int linew, 
				  int threshold, 
				  int maxyshift){

	IntPtr _Result = Natives.recogCreateFromRecog(recs.Pointer,   scalew,   scaleh,   linew,   threshold,   maxyshift);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (279, 1)
// recogCreateFromPixa(pixa, scalew, scaleh, linew, threshold, maxyshift) as L_Recog
// recogCreateFromPixa(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
///  <summary>
/// (1) This is a convenience function for training from labeled data.
/// The pixa can be read from file.<para/>
/// 
/// (2) The pixa should contain the unscaled bitmaps used for training.<para/>
/// 
/// (3) See recogCreate() for use of %scalew, %scaleh and %linew.<para/>
/// 
/// (4) It is recommended to use %maxyshift = 1 (the default value)<para/>
/// 
/// (5) All examples in the same class (i.e., with the same character
/// label) should be similar.  They can be made similar by invoking
/// recogRemoveOutliers[1,2]() on %pixa before calling this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCreateFromPixa/*"/>
///  <param name="pixa">[in] - of labeled, 1 bpp images</param>
///  <param name="scalew">[in] - scale all widths to this use 0 otherwise</param>
///  <param name="scaleh">[in] - scale all heights to this use 0 otherwise</param>
///  <param name="linew">[in] - width of normalized strokes use 0 to skip</param>
///  <param name="threshold">[in] - for binarization typically ~150</param>
///  <param name="maxyshift">[in] - from nominal centroid alignment default is 1</param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogCreateFromPixa(
				  Pixa pixa, 
				  int scalew, 
				  int scaleh, 
				  int linew, 
				  int threshold, 
				  int maxyshift){

	IntPtr _Result = Natives.recogCreateFromPixa(pixa.Pointer,   scalew,   scaleh,   linew,   threshold,   maxyshift);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (325, 1)
// recogCreateFromPixaNoFinish(pixa, scalew, scaleh, linew, threshold, maxyshift) as L_Recog
// recogCreateFromPixaNoFinish(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
///  <summary>
/// (1) See recogCreateFromPixa() for details.<para/>
/// 
/// (2) This is also used to generate a pixaa with templates
/// in each class within a pixa.  For that, all args except for
/// %pixa are ignored.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCreateFromPixaNoFinish/*"/>
///  <param name="pixa">[in] - of labeled, 1 bpp images</param>
///  <param name="scalew">[in] - scale all widths to this use 0 otherwise</param>
///  <param name="scaleh">[in] - scale all heights to this use 0 otherwise</param>
///  <param name="linew">[in] - width of normalized strokes use 0 to skip</param>
///  <param name="threshold">[in] - for binarization typically ~150</param>
///  <param name="maxyshift">[in] - from nominal centroid alignment default is 1</param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogCreateFromPixaNoFinish(
				  Pixa pixa, 
				  int scalew, 
				  int scaleh, 
				  int linew, 
				  int threshold, 
				  int maxyshift){

	IntPtr _Result = Natives.recogCreateFromPixaNoFinish(pixa.Pointer,   scalew,   scaleh,   linew,   threshold,   maxyshift);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (406, 1)
// recogCreate(scalew, scaleh, linew, threshold, maxyshift) as L_Recog
// recogCreate(l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
///  <summary>
/// (1) If %scalew == 0 and %scaleh == 0, no scaling is done.
/// If one of these is 0 and the other is  is greater  0, scaling is isotropic
/// to the requested size.  We typically do not set both  is greater  0.<para/>
/// 
/// (2) Use linew  is greater  0 to convert the templates to images with fixed
/// width strokes.  linew == 0 skips the conversion.<para/>
/// 
/// (3) The only valid values for %maxyshift are 0, 1 and 2.
/// It is recommended to use %maxyshift == 1 (default value).
/// Using %maxyshift == 0 is much faster than %maxyshift == 1, but
/// it is much less likely to find the template with the best
/// correlation.  Use of anything but 1 results in a warning.<para/>
/// 
/// (4) Scaling is used for finding outliers and for training a
/// book-adapted recognizer (BAR) from a bootstrap recognizer (BSR).
/// Scaling the height to a fixed value and scaling the width
/// accordingly (e.g., %scaleh = 40, %scalew = 0) is recommended.<para/>
/// 
/// (5) The storage for most of the arrays is allocated when training
/// is finished.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCreate/*"/>
///  <param name="scalew">[in] - scale all widths to this use 0 otherwise</param>
///  <param name="scaleh">[in] - scale all heights to this use 0 otherwise</param>
///  <param name="linew">[in] - width of normalized strokes use 0 to skip</param>
///  <param name="threshold">[in] - for binarization typically ~128 0 for default</param>
///  <param name="maxyshift">[in] - from nominal centroid alignment default is 1</param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogCreate(
				  int scalew, 
				  int scaleh, 
				  int linew, 
				  int threshold, 
				  int maxyshift){

	IntPtr _Result = Natives.recogCreate(  scalew,   scaleh,   linew,   threshold,   maxyshift);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (476, 1)
// recogDestroy(precog) as Object
// recogDestroy(L_RECOG **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogDestroy/*"/>
///  <param name="precog">[in,out] - will be set to null before returning</param>
public static void recogDestroy(
				 ref L_Recog precog){

	IntPtr precogPtr = IntPtr.Zero; 	if (precog != null) {precogPtr = precog.Pointer;}

	Natives.recogDestroy(ref precogPtr);
	

precog = null;
	; if (precogPtr != IntPtr.Zero){precog = new L_Recog(precogPtr);}


}

// recogbasic.c (529, 1)
// recogGetCount(recog) as int
// recogGetCount(L_RECOG *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogGetCount/*"/>
///  <param name="recog">[in] - </param>
///   <returns>count of classes in recog 0 if no recog or on error</returns>
public static int recogGetCount(
				  L_Recog recog){

	int _Result = Natives.recogGetCount(recog.Pointer);
	



	return _Result;
}

// recogbasic.c (567, 1)
// recogSetParams(recog, type, min_nopad, max_wh_ratio, max_ht_ratio) as int
// recogSetParams(L_RECOG *, l_int32, l_int32, l_float32, l_float32) as l_ok
///  <summary>
/// (1) This is called when a recog is created.<para/>
/// 
/// (2) Default %min_nopad value allows for some padding.
/// To disable padding, set %min_nopad = 0.  To pad only when
/// no samples are available for the class, set %min_nopad = 1.<para/>
/// 
/// (3) The %max_wh_ratio limits the width/height ratio for components
/// that we attempt to split.  Splitting long components is expensive.<para/>
/// 
/// (4) The %max_ht_ratio is a quality requirement on the training data.
/// The recognizer will not run if the averages are computed and
/// the templates do not satisfy it.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSetParams/*"/>
///  <param name="recog">[in] - to be padded, if necessary</param>
///  <param name="type">[in] - type of char set -1 for default see enum in recog.h</param>
///  <param name="min_nopad">[in] - min number in a class without padding use -1 for default</param>
///  <param name="max_wh_ratio">[in] - max width/height ratio allowed for splitting use -1.0 for default</param>
///  <param name="max_ht_ratio">[in] - max of max/min averaged template height ratio use -1.0 for default</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogSetParams(
				  L_Recog recog, 
				  int type, 
				  int min_nopad, 
				  Single max_wh_ratio, 
				  Single max_ht_ratio){

	int _Result = Natives.recogSetParams(recog.Pointer,   type,   min_nopad,   max_wh_ratio,   max_ht_ratio);
	



	return _Result;
}

// recogbasic.c (650, 1)
// recogGetClassIndex(recog, val, text, pindex) as int
// recogGetClassIndex(L_RECOG *, l_int32, char *, l_int32 *) as l_int32
///  <summary>
/// (1) This is used during training.  There is one entry in
/// recogtodna_tochar (integer value, e.g., ascii) and
/// one in recogtosa_text (e.g, ascii letter in a string)
/// for each character class.<para/>
/// 
/// (2) This searches the dna character array for %val.  If it is
/// not found, the template represents a character class not
/// already seen: it increments setsize (the number of character
/// classes) by 1, and augments both the index (dna_tochar)
/// and text (sa_text) arrays.<para/>
/// 
/// (3) Returns the index in [and]index, except on error.<para/>
/// 
/// (4) Caller must check the function return value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogGetClassIndex/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="val">[in] - integer value can be up to 3 bytes for UTF-8</param>
///  <param name="text">[in] - text from which %val was derived used if not found</param>
///  <param name="pindex">[out] - index into dna_tochar</param>
///   <returns>0 if found 1 if not found and added 2 on error.</returns>
public static int recogGetClassIndex(
				  L_Recog recog, 
				  int val, 
				  String text, 
				 out int pindex){

	int _Result = Natives.recogGetClassIndex(recog.Pointer,   val,   text, out  pindex);
	

pindex = 0;


	return _Result;
}

// recogbasic.c (695, 1)
// recogStringToIndex(recog, text, pindex) as int
// recogStringToIndex(L_RECOG *, char *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogStringToIndex/*"/>
///  <param name="recog">[in] - </param>
///  <param name="text">[in] - text string for some class</param>
///  <param name="pindex">[out] - index for that class -1 if not found</param>
///   <returns>0 if OK, 1 on error not finding the string is an error</returns>
public static int recogStringToIndex(
				  L_Recog recog, 
				  String text, 
				 out int pindex){

	int _Result = Natives.recogStringToIndex(recog.Pointer,   text, out  pindex);
	

pindex = 0;


	return _Result;
}

// recogbasic.c (748, 1)
// recogGetClassString(recog, index, pcharstr) as int
// recogGetClassString(L_RECOG *, l_int32, char **) as l_int32
///  <summary>
/// (1) Extracts a copy of the string from sa_text, which
/// the caller must free.<para/>
/// 
/// (2) Caller must check the function return value.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogGetClassString/*"/>
///  <param name="recog">[in] - </param>
///  <param name="index">[in] - into array of char types</param>
///  <param name="pcharstr">[out] - string representation returns an empty string on error</param>
///   <returns>0 if found, 1 on error</returns>
public static int recogGetClassString(
				  L_Recog recog, 
				  int index, 
				 out String[] pcharstr){

	IntPtr pcharstrPtr = IntPtr.Zero;

	int _Result = Natives.recogGetClassString(recog.Pointer,   index, out  pcharstrPtr);
	

pcharstr = null;


	return _Result;
}

// recogbasic.c (778, 1)
// l_convertCharstrToInt(str, pval) as int
// l_convertCharstrToInt(const char *, l_int32 *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_convertCharstrToInt/*"/>
///  <param name="str">[in] - input string representing one UTF-8 character not more than 4 bytes</param>
///  <param name="pval">[out] - integer value for the input.  Think of it as a 1-to-1 hash code.</param>
///   <returns>0 if OK, 1 on error</returns>
public static int l_convertCharstrToInt(
				  String str, 
				 out int pval){

	int _Result = Natives.l_convertCharstrToInt(  str, out  pval);
	

pval = 0;


	return _Result;
}

// recogbasic.c (837, 1)
// recogRead(filename) as L_Recog
// recogRead(const char *) as L_RECOG *
///  <summary>
/// (1) When a recog is serialized, a pixaa of the templates that are
/// actually used for correlation is saved in the pixaa_u array
/// of the recog.  These can be different from the templates that
/// were used to generate the recog, because those original templates
/// can be scaled and turned into normalized lines.  When recog1
/// is deserialized to recog2, these templates are put in both the
/// unscaled array (pixaa_u) and the modified array (pixaa) in recog2.
/// Why not put it in only the unscaled array and let
/// recogTrainingFinalized() regenerate the modified templates?
/// The reason is that with normalized lines, the operation of
/// thinning to a skeleton and dilating back to a fixed width
/// is not idempotent.  Thinning to a skeleton saves pixels at
/// the end of a line segment, and thickening the skeleton puts
/// additional pixels at the end of the lines.  This tends to
/// close gaps.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogRead(
				  String filename){

	IntPtr _Result = Natives.recogRead(  filename);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (866, 1)
// recogReadStream(fp) as L_Recog
// recogReadStream(FILE *) as L_RECOG *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogReadStream(
				  FILE fp){

	IntPtr _Result = Natives.recogReadStream(fp.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (951, 1)
// recogReadMem(data, size) as L_Recog
// recogReadMem(const l_uint8 *, size_t) as L_RECOG *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogReadMem/*"/>
///  <param name="data">[in] - serialization of recog (not ascii)</param>
///  <param name="size">[in] - of data in bytes</param>
///   <returns>recog, or NULL on error</returns>
public static L_Recog recogReadMem(
				  Byte[] data, 
				  uint size){

	IntPtr _Result = Natives.recogReadMem(  data,   size);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Recog(_Result);
}

// recogbasic.c (988, 1)
// recogWrite(filename, recog) as int
// recogWrite(const char *, L_RECOG *) as l_ok
///  <summary>
/// (1) The pixaa of templates that is written is the modified one
/// in the pixaa field. It is the pixaa that is actually used
/// for correlation. This is not the unscaled array of labeled
/// bitmaps, in pixaa_u, that was used to generate the recog in the
/// first place.  See the notes in recogRead() for the rationale.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="recog">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogWrite(
				  String filename, 
				  L_Recog recog){

	int _Result = Natives.recogWrite(  filename, recog.Pointer);
	



	return _Result;
}

// recogbasic.c (1019, 1)
// recogWriteStream(fp, recog) as int
// recogWriteStream(FILE *, L_RECOG *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogWriteStream/*"/>
///  <param name="fp">[in] - file stream opened for "wb"</param>
///  <param name="recog">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogWriteStream(
				  FILE fp, 
				  L_Recog recog){

	int _Result = Natives.recogWriteStream(fp.Pointer, recog.Pointer);
	



	return _Result;
}

// recogbasic.c (1060, 1)
// recogWriteMem(pdata, psize, recog) as int
// recogWriteMem(l_uint8 **, size_t *, L_RECOG *) as l_ok
///  <summary>
/// (1) Serializes a recog in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized recog (not ascii)</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="recog">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogWriteMem(
				 out Byte[] pdata, 
				 out uint psize, 
				  L_Recog recog){

	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.recogWriteMem(out  pdataPtr, out  psize, recog.Pointer);
	

pdata = null;
psize = 0;


	return _Result;
}

// recogbasic.c (1114, 1)
// recogExtractPixa(recog) as Pixa
// recogExtractPixa(L_RECOG *) as PIXA *
///  <summary>
/// (1) This generates a pixa of all the unscaled images in the
/// recognizer, where each one has its character class label in
/// the pix text field, by flattening pixaa_u to a pixa.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogExtractPixa/*"/>
///  <param name="recog">[in] - </param>
///   <returns>pixa if OK, NULL on error</returns>
public static Pixa recogExtractPixa(
				  L_Recog recog){

	IntPtr _Result = Natives.recogExtractPixa(recog.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pixa(_Result);
}

}
