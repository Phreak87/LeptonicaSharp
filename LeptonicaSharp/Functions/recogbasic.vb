Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\recogbasic.c (232, 1)
' recogCreateFromRecog()
' recogCreateFromRecog(L_RECOG *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' Notes
''' (1) This is a convenience function that generates a recog using
''' the unscaled training data in an existing recog.
''' (2) It is recommended to use %maxyshift = 1 (the default value)
''' (3) See recogCreate() for use of %scalew, %scaleh and %linew.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recs">[in] - source recog with arbitrary input parameters</param>
'''  <param name="scalew">[in] - scale all widths to this; use 0 otherwise</param>
'''  <param name="scaleh">[in] - scale all heights to this; use 0 otherwise</param>
'''  <param name="linew">[in] - width of normalized strokes; use 0 to skip</param>
'''  <param name="threshold">[in] - for binarization; typically ~128</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment; default is 1</param>
'''   <returns>recd, or NULL on error</returns>
Public Shared Function recogCreateFromRecog(
				ByVal recs as L_Recog, 
				ByVal scalew as Integer, 
				ByVal scaleh as Integer, 
				ByVal linew as Integer, 
				ByVal threshold as Integer, 
				ByVal maxyshift as Integer) as L_Recog

	If IsNothing (recs) then Throw New ArgumentNullException  ("recs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogCreateFromRecog( recs.Pointer, scalew, scaleh, linew, threshold, maxyshift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (279, 1)
' recogCreateFromPixa()
' recogCreateFromPixa(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' Notes
''' (1) This is a convenience function for training from labeled data.
''' The pixa can be read from file.
''' (2) The pixa should contain the unscaled bitmaps used for training.
''' (3) See recogCreate() for use of %scalew, %scaleh and %linew.
''' (4) It is recommended to use %maxyshift = 1 (the default value)
''' (5) All examples in the same class (i.e., with the same character
''' label) should be similar.  They can be made similar by invoking
''' recogRemoveOutliers[1,2]() on %pixa before calling this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - of labeled, 1 bpp images</param>
'''  <param name="scalew">[in] - scale all widths to this; use 0 otherwise</param>
'''  <param name="scaleh">[in] - scale all heights to this; use 0 otherwise</param>
'''  <param name="linew">[in] - width of normalized strokes; use 0 to skip</param>
'''  <param name="threshold">[in] - for binarization; typically ~150</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment; default is 1</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogCreateFromPixa(
				ByVal pixa as Pixa, 
				ByVal scalew as Integer, 
				ByVal scaleh as Integer, 
				ByVal linew as Integer, 
				ByVal threshold as Integer, 
				ByVal maxyshift as Integer) as L_Recog

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogCreateFromPixa( pixa.Pointer, scalew, scaleh, linew, threshold, maxyshift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (325, 1)
' recogCreateFromPixaNoFinish()
' recogCreateFromPixaNoFinish(PIXA *, l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' Notes
''' (1) See recogCreateFromPixa() for details.
''' (2) This is also used to generate a pixaa with templates
''' in each class within a pixa.  For that, all args except for
''' %pixa are ignored.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - of labeled, 1 bpp images</param>
'''  <param name="scalew">[in] - scale all widths to this; use 0 otherwise</param>
'''  <param name="scaleh">[in] - scale all heights to this; use 0 otherwise</param>
'''  <param name="linew">[in] - width of normalized strokes; use 0 to skip</param>
'''  <param name="threshold">[in] - for binarization; typically ~150</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment; default is 1</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogCreateFromPixaNoFinish(
				ByVal pixa as Pixa, 
				ByVal scalew as Integer, 
				ByVal scaleh as Integer, 
				ByVal linew as Integer, 
				ByVal threshold as Integer, 
				ByVal maxyshift as Integer) as L_Recog

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogCreateFromPixaNoFinish( pixa.Pointer, scalew, scaleh, linew, threshold, maxyshift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (406, 1)
' recogCreate()
' recogCreate(l_int32, l_int32, l_int32, l_int32, l_int32) as L_RECOG *
'''  <summary>
''' Notes
''' (1) If %scalew == 0 and %scaleh == 0, no scaling is done.
''' If one of these is 0 and the other is GT 0, scaling is isotropic
''' to the requested size.  We typically do not set both GT 0.
''' (2) Use linew GT 0 to convert the templates to images with fixed
''' width strokes.  linew == 0 skips the conversion.
''' (3) The only valid values for %maxyshift are 0, 1 and 2.
''' It is recommended to use %maxyshift == 1 (default value).
''' Using %maxyshift == 0 is much faster than %maxyshift == 1, but
''' it is much less likely to find the template with the best
''' correlation.  Use of anything but 1 results in a warning.
''' (4) Scaling is used for finding outliers and for training a
''' book-adapted recognizer (BAR) from a bootstrap recognizer (BSR).
''' Scaling the height to a fixed value and scaling the width
''' accordingly (e.g., %scaleh = 40, %scalew = 0) is recommended.
''' (5) The storage for most of the arrays is allocated when training
''' is finished.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="scalew">[in] - scale all widths to this; use 0 otherwise</param>
'''  <param name="scaleh">[in] - scale all heights to this; use 0 otherwise</param>
'''  <param name="linew">[in] - width of normalized strokes; use 0 to skip</param>
'''  <param name="threshold">[in] - for binarization; typically ~128; 0 for default</param>
'''  <param name="maxyshift">[in] - from nominal centroid alignment; default is 1</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogCreate(
				ByVal scalew as Integer, 
				ByVal scaleh as Integer, 
				ByVal linew as Integer, 
				ByVal threshold as Integer, 
				ByVal maxyshift as Integer) as L_Recog



	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogCreate( scalew, scaleh, linew, threshold, maxyshift)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (476, 1)
' recogDestroy()
' recogDestroy(L_RECOG **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="precog">[in,out] - will be set to null before returning</param>
Public Shared Sub recogDestroy(
				ByRef precog as L_Recog)


	Dim precogPTR As IntPtr = IntPtr.Zero : If Not IsNothing(precog) Then precogPTR = precog.Pointer

	LeptonicaSharp.Natives.recogDestroy( precogPTR)
	if precogPTR <> IntPtr.Zero then precog = new L_Recog(precogPTR)

End Sub

' SRC\recogbasic.c (529, 1)
' recogGetCount()
' recogGetCount(L_RECOG *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>count of classes in recog; 0 if no recog or on error</returns>
Public Shared Function recogGetCount(
				ByVal recog as L_Recog) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogGetCount( recog.Pointer)

	Return _Result
End Function

' SRC\recogbasic.c (567, 1)
' recogSetParams()
' recogSetParams(L_RECOG *, l_int32, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' Notes
''' (1) This is called when a recog is created.
''' (2) Default %min_nopad value allows for some padding.
''' To disable padding, set %min_nopad = 0.  To pad only when
''' no samples are available for the class, set %min_nopad = 1.
''' (3) The %max_wh_ratio limits the width/height ratio for components
''' that we attempt to split.  Splitting long components is expensive.
''' (4) The %max_ht_ratio is a quality requirement on the training data.
''' The recognizer will not run if the averages are computed and
''' the templates do not satisfy it.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - to be padded, if necessary</param>
'''  <param name="type">[in] - type of char set; -1 for default; see enum in recog.h</param>
'''  <param name="min_nopad">[in] - min number in a class without padding; use -1 for default</param>
'''  <param name="max_wh_ratio">[in] - max width/height ratio allowed for splitting; use -1.0 for default</param>
'''  <param name="max_ht_ratio">[in] - max of max/min averaged template height ratio; use -1.0 for default</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogSetParams(
				ByVal recog as L_Recog, 
				ByVal type as Integer, 
				ByVal min_nopad as Integer, 
				ByVal max_wh_ratio as Single, 
				ByVal max_ht_ratio as Single) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (max_wh_ratio) then Throw New ArgumentNullException  ("max_wh_ratio cannot be Nothing")
	If IsNothing (max_ht_ratio) then Throw New ArgumentNullException  ("max_ht_ratio cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogSetParams( recog.Pointer, type, min_nopad, max_wh_ratio, max_ht_ratio)

	Return _Result
End Function

' SRC\recogbasic.c (650, 1)
' recogGetClassIndex()
' recogGetClassIndex(L_RECOG *, l_int32, char *, l_int32 *) as l_int32
'''  <summary>
''' Notes
''' (1) This is used during training.  There is one entry in
''' recog-GTdna_tochar (integer value, e.g., ascii) and
''' one in recog-GTsa_text (e.g, ascii letter in a string)
''' for each character class.
''' (2) This searches the dna character array for %val.  If it is
''' not found, the template represents a character class not
''' already seen it increments setsize (the number of character
''' classes) by 1, and augments both the index (dna_tochar)
''' and text (sa_text) arrays.
''' (3) Returns the index in index, except on error.
''' (4) Caller must check the function return value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="val">[in] - integer value; can be up to 3 bytes for UTF-8</param>
'''  <param name="text">[in] - text from which %val was derived; used if not found</param>
'''  <param name="pindex">[out] - index into dna_tochar</param>
'''   <returns>0 if found; 1 if not found and added; 2 on error.</returns>
Public Shared Function recogGetClassIndex(
				ByVal recog as L_Recog, 
				ByVal val as Integer, 
				ByVal text as String, 
				ByRef pindex as Integer) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (text) then Throw New ArgumentNullException  ("text cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogGetClassIndex( recog.Pointer, val, text, pindex)

	Return _Result
End Function

' SRC\recogbasic.c (695, 1)
' recogStringToIndex()
' recogStringToIndex(L_RECOG *, char *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="text">[in] - text string for some class</param>
'''  <param name="pindex">[out] - index for that class; -1 if not found</param>
'''   <returns>0 if OK, 1 on error not finding the string is an error</returns>
Public Shared Function recogStringToIndex(
				ByVal recog as L_Recog, 
				ByVal text as String, 
				ByRef pindex as Integer) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (text) then Throw New ArgumentNullException  ("text cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogStringToIndex( recog.Pointer, text, pindex)

	Return _Result
End Function

' SRC\recogbasic.c (748, 1)
' recogGetClassString()
' recogGetClassString(L_RECOG *, l_int32, char **) as l_int32
'''  <summary>
''' Notes
''' (1) Extracts a copy of the string from sa_text, which
''' the caller must free.
''' (2) Caller must check the function return value.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="index">[in] - into array of char types</param>
'''  <param name="pcharstr">[out] - string representation; returns an empty string on error</param>
'''   <returns>0 if found, 1 on error</returns>
Public Shared Function recogGetClassString(
				ByVal recog as L_Recog, 
				ByVal index as Integer, 
				ByRef pcharstr as String()) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")

Dim pcharstrPTR As IntPtr = pcharstrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pcharstr.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.recogGetClassString( recog.Pointer, index, pcharstrPTR)

	Return _Result
End Function

' SRC\recogbasic.c (778, 1)
' l_convertCharstrToInt()
' l_convertCharstrToInt(const char *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="str">[in] - input string representing one UTF-8 character; not more than 4 bytes</param>
'''  <param name="pval">[out] - integer value for the input.  Think of it as a 1-to-1 hash code.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_convertCharstrToInt(
				ByVal str as String, 
				ByRef pval as Integer) as Integer

	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.l_convertCharstrToInt( str, pval)

	Return _Result
End Function

' SRC\recogbasic.c (837, 1)
' recogRead()
' recogRead(const char *) as L_RECOG *
'''  <summary>
''' Notes
''' (1) When a recog is serialized, a pixaa of the templates that are
''' actually used for correlation is saved in the pixaa_u array
''' of the recog.  These can be different from the templates that
''' were used to generate the recog, because those original templates
''' can be scaled and turned into normalized lines.  When recog1
''' is deserialized to recog2, these templates are put in both the
''' unscaled array (pixaa_u) and the modified array (pixaa) in recog2.
''' Why not put it in only the unscaled array and let
''' recogTrainingFinalized() regenerate the modified templates?
''' The reason is that with normalized lines, the operation of
''' thinning to a skeleton and dilating back to a fixed width
''' is not idempotent.  Thinning to a skeleton saves pixels at
''' the end of a line segment, and thickening the skeleton puts
''' additional pixels at the end of the lines.  This tends to
''' close gaps.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogRead(
				ByVal filename as String) as L_Recog

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (866, 1)
' recogReadStream()
' recogReadStream(FILE *) as L_RECOG *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogReadStream(
				ByVal fp as FILE) as L_Recog

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (951, 1)
' recogReadMem()
' recogReadMem(const l_uint8 *, size_t) as L_RECOG *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of recog (not ascii)</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>recog, or NULL on error</returns>
Public Shared Function recogReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as L_Recog

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Recog(_Result)
End Function

' SRC\recogbasic.c (988, 1)
' recogWrite()
' recogWrite(const char *, L_RECOG *) as l_ok
'''  <summary>
''' Notes
''' (1) The pixaa of templates that is written is the modified one
''' in the pixaa field. It is the pixaa that is actually used
''' for correlation. This is not the unscaled array of labeled
''' bitmaps, in pixaa_u, that was used to generate the recog in the
''' first place.  See the notes in recogRead() for the rationale.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="recog">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogWrite(
				ByVal filename as String, 
				ByVal recog as L_Recog) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogWrite( filename, recog.Pointer)

	Return _Result
End Function

' SRC\recogbasic.c (1019, 1)
' recogWriteStream()
' recogWriteStream(FILE *, L_RECOG *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="recog">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogWriteStream(
				ByVal fp as FILE, 
				ByVal recog as L_Recog) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.recogWriteStream( fp.Pointer, recog.Pointer)

	Return _Result
End Function

' SRC\recogbasic.c (1060, 1)
' recogWriteMem()
' recogWriteMem(l_uint8 **, size_t *, L_RECOG *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a recog in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized recog (not ascii)</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="recog">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal recog as L_Recog) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.recogWriteMem( pdataPTR, psize, recog.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\recogbasic.c (1114, 1)
' recogExtractPixa()
' recogExtractPixa(L_RECOG *) as PIXA *
'''  <summary>
''' Notes
''' (1) This generates a pixa of all the unscaled images in the
''' recognizer, where each one has its character class label in
''' the pix text field, by flattening pixaa_u to a pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>pixa if OK, NULL on error</returns>
Public Shared Function recogExtractPixa(
				ByVal recog as L_Recog) as Pixa

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogExtractPixa( recog.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

End Class
