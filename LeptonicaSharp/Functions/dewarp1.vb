Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dewarp1.c (446, 1)
' dewarpCreate()
' dewarpCreate(PIX *, l_int32) as L_DEWARP *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input pixs is either full resolution or 2x reduced.<para/>
''' (2) The page number is typically 0-based.  If scanned from a book,<para/>
''' the even pages are usually on the left.  Disparity arrays<para/>
''' built for even pages should only be applied to even pages.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pageno">[in] - page number</param>
'''   <returns>dew or NULL on error</returns>
Public Shared Function dewarpCreate(
				ByVal pixs as Pix, 
				ByVal pageno as Integer) as L_Dewarp

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpCreate( pixs.Pointer, pageno)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (486, 1)
' dewarpCreateRef()
' dewarpCreateRef(l_int32, l_int32) as L_DEWARP *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This specifies which dewarp struct should be used for<para/>
''' the given page.  It is placed in dewarpa for pages<para/>
''' for which no model can be built.<para/>
''' (2) This page and the reference page have the same parity and<para/>
''' the reference page is the closest page with a disparity model<para/>
''' to this page.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pageno">[in] - this page number</param>
'''  <param name="refpage">[in] - page number of dewarp disparity arrays to be used</param>
'''   <returns>dew or NULL on error</returns>
Public Shared Function dewarpCreateRef(
				ByVal pageno as Integer, 
				ByVal refpage as Integer) as L_Dewarp



	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpCreateRef( pageno, refpage)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (509, 1)
' dewarpDestroy()
' dewarpDestroy(L_DEWARP **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="pdew">[in,out] - will be set to null before returning</param>
Public Shared Sub dewarpDestroy(
				ByRef pdew as L_Dewarp)


	Dim pdewPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdew) Then pdewPTR = pdew.Pointer

	LeptonicaSharp.Natives.dewarpDestroy( pdewPTR)
	if pdewPTR <> IntPtr.Zero then pdew = new L_Dewarp(pdewPTR)

End Sub

' SRC\dewarp1.c (572, 1)
' dewarpaCreate()
' dewarpaCreate(l_int32, l_int32, l_int32, l_int32, l_int32) as L_DEWARPA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The sampling, minlines and maxdist parameters will be<para/>
''' applied to all images.<para/>
''' (2) The sampling factor is used for generating the disparity arrays<para/>
''' from the input image.  For 2x reduced input, use a sampling<para/>
''' factor that is half the sampling you want on the full resolution<para/>
''' images.<para/>
''' (3) Use %redfactor = 1 for full resolution 2 for 2x reduction.<para/>
''' All input images must be at one of these two resolutions.<para/>
''' (4) %minlines is the minimum number of nearly full-length lines<para/>
''' required to generate a vertical disparity array.  The default<para/>
''' number is 15.  Use a smaller number to accept a questionable<para/>
''' array, but not smaller than 4.<para/>
''' (5) When a model can't be built for a page, it looks up to %maxdist<para/>
''' in either direction for a valid model with the same page parity.<para/>
''' Use -1 for the default value of %maxdist use 0 to avoid using<para/>
''' a ref model.<para/>
''' (6) The ptr array is expanded as necessary to accommodate page images.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nptrs">[in] - number of dewarp page ptrs typically the number of pages</param>
'''  <param name="sampling">[in] - use 0 for default value the minimum allowed is 8</param>
'''  <param name="redfactor">[in] - of input images: 1 is full resolution 2 is 2x reduced</param>
'''  <param name="minlines">[in] - minimum number of lines to accept use 0 for default</param>
'''  <param name="maxdist">[in] - for locating reference disparity use -1 for default</param>
'''   <returns>dewa or NULL on error</returns>
Public Shared Function dewarpaCreate(
				ByVal nptrs as Integer, 
				ByVal sampling as Integer, 
				ByVal redfactor as Integer, 
				ByVal minlines as Integer, 
				ByVal maxdist as Integer) as L_Dewarpa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaCreate( nptrs, sampling, redfactor, minlines, maxdist)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarpa(_Result)
End Function

' SRC\dewarp1.c (661, 1)
' dewarpaCreateFromPixacomp()
' dewarpaCreateFromPixacomp(PIXAC *, l_int32, l_int32, l_int32, l_int32) as L_DEWARPA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned dewa has disparity arrays calculated and<para/>
''' is ready for serialization or for use in dewarping.<para/>
''' (2) The sampling, minlines and maxdist parameters are<para/>
''' applied to all images.  See notes in dewarpaCreate() for details.<para/>
''' (3) The pixac is full.  Placeholders, if any, are w=h=d=1 images,<para/>
''' and the real input images are 1 bpp at full resolution.<para/>
''' They are assumed to be cropped to the actual page regions,<para/>
''' and may be arbitrarily sparse in the array.<para/>
''' (4) The output dewarpa is indexed by the page number.<para/>
''' The offset in the pixac gives the mapping between the<para/>
''' array index in the pixac and the page number.<para/>
''' (5) This adds the ref page models.<para/>
''' (6) This can be used to make models for any desired set of pages.<para/>
''' The direct models are only made for pages with images in<para/>
''' the pixacomp the ref models are made for pages of the<para/>
''' same parity within %maxdist of the nearest direct model.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - pixacomp of G4, 1 bpp images with 1x1x1 placeholders</param>
'''  <param name="useboth">[in] - 0 for only vert disparity 1 for both vert and horiz</param>
'''  <param name="sampling">[in] - use -1 or 0 for default value otherwise minimum of 5</param>
'''  <param name="minlines">[in] - minimum number of lines to accept e.g., 10</param>
'''  <param name="maxdist">[in] - for locating reference disparity use -1 for default</param>
'''   <returns>dewa or NULL on error</returns>
Public Shared Function dewarpaCreateFromPixacomp(
				ByVal pixac as PixaComp, 
				ByVal useboth as Integer, 
				ByVal sampling as Integer, 
				ByVal minlines as Integer, 
				ByVal maxdist as Integer) as L_Dewarpa

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaCreateFromPixacomp( pixac.Pointer, useboth, sampling, minlines, maxdist)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarpa(_Result)
End Function

' SRC\dewarp1.c (722, 1)
' dewarpaDestroy()
' dewarpaDestroy(L_DEWARPA **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="pdewa">[in,out] - will be set to null before returning</param>
Public Shared Sub dewarpaDestroy(
				ByRef pdewa as L_Dewarpa)


	Dim pdewaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdewa) Then pdewaPTR = pdewa.Pointer

	LeptonicaSharp.Natives.dewarpaDestroy( pdewaPTR)
	if pdewaPTR <> IntPtr.Zero then pdewa = new L_Dewarpa(pdewaPTR)

End Sub

' SRC\dewarp1.c (762, 1)
' dewarpaDestroyDewarp()
' dewarpaDestroyDewarp(L_DEWARPA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="pageno">[in] - of dew to be destroyed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaDestroyDewarp(
				ByVal dewa as L_Dewarpa, 
				ByVal pageno as Integer) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaDestroyDewarp( dewa.Pointer, pageno)

	Return _Result
End Function

' SRC\dewarp1.c (805, 1)
' dewarpaInsertDewarp()
' dewarpaInsertDewarp(L_DEWARPA *, L_DEWARP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This inserts the dewarp into the array, which now owns it.<para/>
''' It also keeps track of the largest page number stored.<para/>
''' It must be done before the disparity model is built.<para/>
''' (2) Note that this differs from the usual method of filling out<para/>
''' arrays in leptonica, where the arrays are compact and<para/>
''' new elements are typically added to the end.  Here,<para/>
''' the dewarp can be added anywhere, even beyond the initial<para/>
''' allocation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="dew">[in] - to be added</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaInsertDewarp(
				ByVal dewa as L_Dewarpa, 
				ByVal dew as L_Dewarp) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaInsertDewarp( dewa.Pointer, dew.Pointer)

	Return _Result
End Function

' SRC\dewarp1.c (902, 1)
' dewarpaGetDewarp()
' dewarpaGetDewarp(L_DEWARPA *, l_int32) as L_DEWARP *
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - populated with dewarp structs for pages</param>
'''  <param name="index">[in] - into dewa: this is the pageno</param>
'''   <returns>dew handle still owned by dewa, or NULL on error</returns>
Public Shared Function dewarpaGetDewarp(
				ByVal dewa as L_Dewarpa, 
				ByVal index as Integer) as L_Dewarp

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaGetDewarp( dewa.Pointer, index)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (966, 1)
' dewarpaSetCurvatures()
' dewarpaSetCurvatures(L_DEWARPA *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Approximating the line by a quadratic, the coefficient<para/>
''' of the quadratic term is the curvature, and distance<para/>
''' units are in pixels (of course).  The curvature is very<para/>
''' small, so we multiply by 10^6 and express the constraints<para/>
''' on the model curvatures in micro-units.<para/>
''' (2) This sets five curvature thresholds and a slope threshold:<para/>
''' the maximum absolute value of the vertical disparity<para/>
''' line curvatures<para/>
''' the minimum absolute value of the largest difference in<para/>
''' vertical disparity line curvatures (Use a value of 0<para/>
''' to accept all models.)<para/>
''' the maximum absolute value of the largest difference in<para/>
''' vertical disparity line curvatures<para/>
''' the maximum absolute value of the left and right edge<para/>
''' curvature for the horizontal disparity<para/>
''' the maximum absolute value of the difference between<para/>
''' left and right edge curvature for the horizontal disparity<para/>
''' all in micro-units, for dewarping to take place.<para/>
''' Use -1 for default values.<para/>
''' (3) An image with a line curvature less than about 0.00001<para/>
''' has fairly straight textlines.  This is 10 micro-units.<para/>
''' (4) For example, if %max_linecurv == 100, this would prevent dewarping<para/>
''' if any of the lines has a curvature exceeding 100 micro-units.<para/>
''' A model having maximum line curvature larger than about 150<para/>
''' micro-units should probably not be used.<para/>
''' (5) A model having a left or right edge curvature larger than<para/>
''' about 100 micro-units should probably not be used.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="max_linecurv">[in] - -1 for default</param>
'''  <param name="min_diff_linecurv">[in] - -1 for default 0 to accept all models</param>
'''  <param name="max_diff_linecurv">[in] - -1 for default</param>
'''  <param name="max_edgecurv">[in] - -1 for default</param>
'''  <param name="max_diff_edgecurv">[in] - -1 for default</param>
'''  <param name="max_edgeslope">[in] - -1 for default</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaSetCurvatures(
				ByVal dewa as L_Dewarpa, 
				ByVal max_linecurv as Integer, 
				ByVal min_diff_linecurv as Integer, 
				ByVal max_diff_linecurv as Integer, 
				ByVal max_edgecurv as Integer, 
				ByVal max_diff_edgecurv as Integer, 
				ByVal max_edgeslope as Integer) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaSetCurvatures( dewa.Pointer, max_linecurv, min_diff_linecurv, max_diff_linecurv, max_edgecurv, max_diff_edgecurv, max_edgeslope)

	Return _Result
End Function

' SRC\dewarp1.c (1030, 1)
' dewarpaUseBothArrays()
' dewarpaUseBothArrays(L_DEWARPA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This sets the useboth field.  If set, this will attempt<para/>
''' to apply both vertical and horizontal disparity arrays.<para/>
''' Note that a model with only a vertical disparity array will<para/>
''' always be valid.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="useboth">[in] - 0 for false, 1 for true</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaUseBothArrays(
				ByVal dewa as L_Dewarpa, 
				ByVal useboth as Integer) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaUseBothArrays( dewa.Pointer, useboth)

	Return _Result
End Function

' SRC\dewarp1.c (1069, 1)
' dewarpaSetCheckColumns()
' dewarpaSetCheckColumns(L_DEWARPA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This sets the 'check_columns" field.  If set, and if<para/>
''' 'useboth' is set, this will count the number of text<para/>
''' columns.  If the number is larger than 1, this will<para/>
''' prevent the application of horizontal disparity arrays<para/>
''' if they exist.  Note that the default value of check_columns<para/>
''' if 0 (FALSE).<para/>
''' (2) This field is set to 0 by default.  For horizontal disparity<para/>
''' correction to take place on a single column of text, you must have:<para/>
''' - a valid horizontal disparity array<para/>
''' - useboth = 1 (TRUE)<para/>
''' If there are multiple columns, additionally<para/>
''' - check_columns = 0 (FALSE)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="check_columns">[in] - 0 for false, 1 for true</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaSetCheckColumns(
				ByVal dewa as L_Dewarpa, 
				ByVal check_columns as Integer) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaSetCheckColumns( dewa.Pointer, check_columns)

	Return _Result
End Function

' SRC\dewarp1.c (1095, 1)
' dewarpaSetMaxDistance()
' dewarpaSetMaxDistance(L_DEWARPA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This sets the maxdist field.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dewa">[in] - </param>
'''  <param name="maxdist">[in] - for using ref models</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaSetMaxDistance(
				ByVal dewa as L_Dewarpa, 
				ByVal maxdist as Integer) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaSetMaxDistance( dewa.Pointer, maxdist)

	Return _Result
End Function

' SRC\dewarp1.c (1119, 1)
' dewarpRead()
' dewarpRead(const char *) as L_DEWARP *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>dew, or NULL on error</returns>
Public Shared Function dewarpRead(
				ByVal filename as String) as L_Dewarp

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (1159, 1)
' dewarpReadStream()
' dewarpReadStream(FILE *) as L_DEWARP *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The dewarp struct is stored in minimized format, with only<para/>
''' subsampled disparity arrays.<para/>
''' (2) The sampling and extra horizontal disparity parameters are<para/>
''' stored here.  During generation of the dewarp struct, they<para/>
''' are passed in from the dewarpa.  In readback, it is assumed<para/>
''' that they are (a) the same for each page and (b) the same<para/>
''' as the values used to create the dewarpa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>dew, or NULL on error</returns>
Public Shared Function dewarpReadStream(
				ByVal fp as FILE) as L_Dewarp

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (1264, 1)
' dewarpReadMem()
' dewarpReadMem(const l_uint8 *, size_t) as L_DEWARP *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of dewarp</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>dew  dewarp, or NULL on error</returns>
Public Shared Function dewarpReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as L_Dewarp

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarp(_Result)
End Function

' SRC\dewarp1.c (1292, 1)
' dewarpWrite()
' dewarpWrite(const char *, L_DEWARP *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="dew">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpWrite(
				ByVal filename as String, 
				ByVal dew as L_Dewarp) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpWrite( filename, dew.Pointer)

	Return _Result
End Function

' SRC\dewarp1.c (1330, 1)
' dewarpWriteStream()
' dewarpWriteStream(FILE *, L_DEWARP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This should not be written if there is no sampled<para/>
''' vertical disparity array, which means that no model has<para/>
''' been built for this page.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="dew">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpWriteStream(
				ByVal fp as FILE, 
				ByVal dew as L_Dewarp) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpWriteStream( fp.Pointer, dew.Pointer)

	Return _Result
End Function

' SRC\dewarp1.c (1386, 1)
' dewarpWriteMem()
' dewarpWriteMem(l_uint8 **, size_t *, L_DEWARP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a dewarp in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized dewarp (not ascii)</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="dew">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal dew as L_Dewarp) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpWriteMem( pdataPTR, psize, dew.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\dewarp1.c (1436, 1)
' dewarpaRead()
' dewarpaRead(const char *) as L_DEWARPA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>dewa, or NULL on error</returns>
Public Shared Function dewarpaRead(
				ByVal filename as String) as L_Dewarpa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarpa(_Result)
End Function

' SRC\dewarp1.c (1473, 1)
' dewarpaReadStream()
' dewarpaReadStream(FILE *) as L_DEWARPA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The serialized dewarp contains a Numa that gives the<para/>
''' (increasing) page number of the dewarp structs that are<para/>
''' contained.<para/>
''' (2) Reference pages are added in after readback.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>dewa, or NULL on error</returns>
Public Shared Function dewarpaReadStream(
				ByVal fp as FILE) as L_Dewarpa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarpa(_Result)
End Function

' SRC\dewarp1.c (1545, 1)
' dewarpaReadMem()
' dewarpaReadMem(const l_uint8 *, size_t) as L_DEWARPA *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of dewarpa</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>dewa  dewarpa, or NULL on error</returns>
Public Shared Function dewarpaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as L_Dewarpa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.dewarpaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dewarpa(_Result)
End Function

' SRC\dewarp1.c (1573, 1)
' dewarpaWrite()
' dewarpaWrite(const char *, L_DEWARPA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="dewa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaWrite(
				ByVal filename as String, 
				ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaWrite( filename, dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp1.c (1604, 1)
' dewarpaWriteStream()
' dewarpaWriteStream(FILE *, L_DEWARPA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="dewa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaWriteStream(
				ByVal fp as FILE, 
				ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaWriteStream( fp.Pointer, dewa.Pointer)

	Return _Result
End Function

' SRC\dewarp1.c (1660, 1)
' dewarpaWriteMem()
' dewarpaWriteMem(l_uint8 **, size_t *, L_DEWARPA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a dewarpa in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized dewarpa (not ascii)</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="dewa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpaWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal dewa as L_Dewarpa) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaWriteMem( pdataPTR, psize, dewa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class
