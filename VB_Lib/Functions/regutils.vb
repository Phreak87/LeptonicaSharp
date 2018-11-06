Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\regutils.c (119, 1)
' regTestSetup(argc, argv, prp) as Integer
' regTestSetup(l_int32, char **, L_REGPARAMS **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Call this function with the args to the reg test.  The first arg<para/>
''' is the name of the reg test.  There are three cases:<para/>
''' Case 1:<para/>
''' There is either only one arg, or the second arg is "compare".<para/>
''' This is the mode in which you run a regression test<para/>
''' (or a set of them), looking for failures and logging<para/>
''' the results to a file.  The output, which includes<para/>
''' logging of all reg test failures plus a SUCCESS or<para/>
''' FAILURE summary for each test, is appended to the file<para/>
''' "/tmp/lept/reg_results.txt.  For this case, as in Case 2,<para/>
''' the display field in rp is set to FALSE, preventing<para/>
''' image display.<para/>
''' Case 2:<para/>
''' The second arg is "generate".  This will cause<para/>
''' generation of new golden files for the reg test.<para/>
''' The results of the reg test are not recorded, and<para/>
''' the display field in rp is set to FALSE.<para/>
''' Case 3:<para/>
''' The second arg is "display".  The test will run and<para/>
''' files will be written.  Comparisons with golden files<para/>
''' will not be carried out, so the only notion of success<para/>
''' or failure is with tests that do not involve golden files.<para/>
''' The display field in rp is TRUE, and this is used by<para/>
''' pixDisplayWithTitle().<para/>
''' (2) See regutils.h for examples of usage.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestSetup/*"/>
'''  <param name="argc">[in] - from invocation can be either 1 or 2</param>
'''  <param name="argv">[in] - to regtest: %argv[1] is one of these: "generate", "compare", "display"</param>
'''  <param name="prp">[out] - all regression params</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function regTestSetup(
				 ByVal argc as Integer, 
				 ByVal argv as String(), 
				<Out()> ByRef prp as L_RegParams) as Integer

	If IsNothing (argv) then Throw New ArgumentNullException  ("argv cannot be Nothing")

Dim argvPTR As IntPtr = argvPTR = Marshal.AllocHGlobal(Marshal.sizeOf(argv.toArray))
	Dim prpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(prp) Then prpPTR = prp.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestSetup( argc, argvPTR, prpPTR)
	if prpPTR <> IntPtr.Zero then prp = new L_RegParams(prpPTR)

	Return _Result
End Function

' SRC\regutils.c (208, 1)
' regTestCleanup(rp) as Integer
' regTestCleanup(L_REGPARAMS *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This copies anything written to the temporary file to the<para/>
''' output file /tmp/lept/reg_results.txt.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCleanup/*"/>
'''  <param name="rp">[in] - regression test parameters</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function regTestCleanup(
				 ByVal rp as L_RegParams) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCleanup( rp.Pointer)

	Return _Result
End Function

' SRC\regutils.c (271, 1)
' regTestCompareValues(rp, val1, val2, delta) as Integer
' regTestCompareValues(L_REGPARAMS *, l_float32, l_float32, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCompareValues/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="val1">[in] - typ. the golden value</param>
'''  <param name="val2">[in] - typ. the value computed</param>
'''  <param name="delta">[in] - allowed max absolute difference</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestCompareValues(
				 ByVal rp as L_RegParams, 
				 ByVal val1 as Single, 
				 ByVal val2 as Single, 
				 ByVal delta as Single) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCompareValues( rp.Pointer, val1, val2, delta)

	Return _Result
End Function

' SRC\regutils.c (315, 1)
' regTestCompareStrings(rp, string1, bytes1, string2, bytes2) as Integer
' regTestCompareStrings(L_REGPARAMS *, l_uint8 *, size_t, l_uint8 *, size_t) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCompareStrings/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="string1">[in] - typ. the expected string</param>
'''  <param name="bytes1">[in] - size of string1</param>
'''  <param name="string2">[in] - typ. the computed string</param>
'''  <param name="bytes2">[in] - size of string2</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestCompareStrings(
				 ByVal rp as L_RegParams, 
				 ByVal string1 as Byte(), 
				 ByVal bytes1 as UInteger, 
				 ByVal string2 as Byte(), 
				 ByVal bytes2 as UInteger) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (string1) then Throw New ArgumentNullException  ("string1 cannot be Nothing")
	If IsNothing (string2) then Throw New ArgumentNullException  ("string2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCompareStrings( rp.Pointer, string1, bytes1, string2, bytes2)

	Return _Result
End Function

' SRC\regutils.c (381, 1)
' regTestComparePix(rp, pix1, pix2) as Integer
' regTestComparePix(L_REGPARAMS *, PIX *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function compares two pix for equality.  On failure,<para/>
''' this writes to stderr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestComparePix/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="pix1">[in] - to be tested for equality</param>
'''  <param name="pix2">[in] - to be tested for equality</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestComparePix(
				 ByVal rp as L_RegParams, 
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestComparePix( rp.Pointer, pix1.Pointer, pix2.Pointer)

	Return _Result
End Function

' SRC\regutils.c (441, 1)
' regTestCompareSimilarPix(rp, pix1, pix2, mindiff, maxfract, printstats) as Integer
' regTestCompareSimilarPix(L_REGPARAMS *, PIX *, PIX *, l_int32, l_float32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function compares two pix for near equality.  On failure,<para/>
''' this writes to stderr.<para/>
''' (2) The pix are similar if the fraction of non-conforming pixels<para/>
''' does not exceed %maxfract.  Pixels are non-conforming if<para/>
''' the difference in pixel values equals or exceeds %mindiff.<para/>
''' Typical values might be %mindiff = 15 and %maxfract = 0.01.<para/>
''' (3) The input images must have the same size and depth.  The<para/>
''' pixels for comparison are typically subsampled from the images.<para/>
''' (4) Normally, use %printstats = 0.  In debugging mode, to see<para/>
''' the relation between %mindiff and the minimum value of<para/>
''' %maxfract for success, set this to 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCompareSimilarPix/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="pix1">[in] - to be tested for near equality</param>
'''  <param name="pix2">[in] - to be tested for near equality</param>
'''  <param name="mindiff">[in] - minimum pixel difference to be counted  is greater  0</param>
'''  <param name="maxfract">[in] - maximum fraction of pixels allowed to have diff greater than or equal to mindiff</param>
'''  <param name="printstats">[in] - use 1 to print normalized histogram to stderr</param>
'''   <returns>0 if OK, 1 on error a failure in similarity comparison is not an error</returns>
Public Shared Function regTestCompareSimilarPix(
				 ByVal rp as L_RegParams, 
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal mindiff as Integer, 
				 ByVal maxfract as Single, 
				 ByVal printstats as Integer) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCompareSimilarPix( rp.Pointer, pix1.Pointer, pix2.Pointer, mindiff, maxfract, printstats)

	Return _Result
End Function

' SRC\regutils.c (504, 1)
' regTestCheckFile(rp, localname) as Integer
' regTestCheckFile(L_REGPARAMS *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function does one of three things, depending on the mode:<para/>
''' "generate": makes a "golden" file as a copy %localname.<para/>
''' "compare": compares %localname contents with the golden file<para/>
''' "display": makes the %localname file but does no comparison<para/>
''' (2) The canonical format of the golden filenames is:<para/>
''' /tmp/lept/golden/[root of main name]_golden.[index].<para/>
''' [ext of localname]<para/>
''' e.g.,<para/>
''' /tmp/lept/golden/maze_golden.0.png<para/>
''' It is important to add an extension to the local name, because<para/>
''' the extension is added to the name of the golden file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCheckFile/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="localname">[in] - name of output file from reg test</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestCheckFile(
				 ByVal rp as L_RegParams, 
				 ByVal localname as String) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (localname) then Throw New ArgumentNullException  ("localname cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCheckFile( rp.Pointer, localname)

	Return _Result
End Function

' SRC\regutils.c (611, 1)
' regTestCompareFiles(rp, index1, index2) as Integer
' regTestCompareFiles(L_REGPARAMS *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This only does something in "compare" mode.<para/>
''' (2) The canonical format of the golden filenames is:<para/>
''' /tmp/lept/golden/[root of main name]_golden.[index].<para/>
''' [ext of localname]<para/>
''' e.g.,<para/>
''' /tmp/lept/golden/maze_golden.0.png<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestCompareFiles/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="index1">[in] - of one output file from reg test</param>
'''  <param name="index2">[in] - of another output file from reg test</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestCompareFiles(
				 ByVal rp as L_RegParams, 
				 ByVal index1 as Integer, 
				 ByVal index2 as Integer) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestCompareFiles( rp.Pointer, index1, index2)

	Return _Result
End Function

' SRC\regutils.c (704, 1)
' regTestWritePixAndCheck(rp, pix, format) as Integer
' regTestWritePixAndCheck(L_REGPARAMS *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function makes it easy to write the pix in a numbered<para/>
''' sequence of files, and either to:<para/>
''' (a) write the golden file ("generate" arg to regression test)<para/>
''' (b) make a local file and "compare" with the golden file<para/>
''' (c) make a local file and "display" the results<para/>
''' (2) The canonical format of the local filename is:<para/>
''' /tmp/lept/regout/[root of main name].[count].[format extension]<para/>
''' e.g., for scale_reg,<para/>
''' /tmp/lept/regout/scale.0.png<para/>
''' The golden file name mirrors this in the usual way.<para/>
''' (3) The check is done between the written files, which requires<para/>
''' the files to be identical. The exception is for GIF, which<para/>
''' only requires that all pixels in the decoded pix are identical.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestWritePixAndCheck/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="pix">[in] - to be written</param>
'''  <param name="format">[in] - of output pix</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestWritePixAndCheck(
				 ByVal rp as L_RegParams, 
				 ByVal pix as Pix, 
				 ByVal format as Enumerations.IFF) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestWritePixAndCheck( rp.Pointer, pix.Pointer, format)

	Return _Result
End Function

' SRC\regutils.c (770, 1)
' regTestWriteDataAndCheck(rp, data, nbytes, ext) as Integer
' regTestWriteDataAndCheck(L_REGPARAMS *, void *, size_t, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function makes it easy to write data in a numbered<para/>
''' sequence of files, and either to:<para/>
''' (a) write the golden file ("generate" arg to regression test)<para/>
''' (b) make a local file and "compare" with the golden file<para/>
''' (c) make a local file and "display" the results<para/>
''' (2) The canonical format of the local filename is:<para/>
''' /tmp/lept/regout/[root of main name].[count].[ext]<para/>
''' e.g., for the first boxaa in quadtree_reg,<para/>
''' /tmp/lept/regout/quadtree.0.baa<para/>
''' The golden file name mirrors this in the usual way.<para/>
''' (3) The data can be anything.  It is most useful for serialized<para/>
''' output of data, such as boxa, pta, etc.<para/>
''' (4) The file extension is arbitrary.  It is included simply<para/>
''' to make the content type obvious when examining written files.<para/>
''' (5) The check is done between the written files, which requires<para/>
''' the files to be identical.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestWriteDataAndCheck/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="data">[in] - to be written</param>
'''  <param name="nbytes">[in] - of data to be written</param>
'''  <param name="ext">[in] - filename extension (e.g.: "ba", "pta")</param>
'''   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
Public Shared Function regTestWriteDataAndCheck(
				 ByVal rp as L_RegParams, 
				 ByVal data as Object, 
				 ByVal nbytes as UInteger, 
				 ByVal ext as String) as Integer

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (ext) then Throw New ArgumentNullException  ("ext cannot be Nothing")

Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.regTestWriteDataAndCheck( rp.Pointer, dataPTR, nbytes, ext)

	Return _Result
End Function

' SRC\regutils.c (821, 1)
' regTestGenLocalFilename(rp, index, format) as String
' regTestGenLocalFilename(L_REGPARAMS *, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is used to get the name of a file in the regout<para/>
''' subdirectory, that has been made and is used to test against<para/>
''' the golden file.  You can either specify a particular index<para/>
''' value, or with %index == -1, this returns the most recently<para/>
''' written file.  The latter case lets you read a pix from a<para/>
''' file that has just been written with regTestWritePixAndCheck(),<para/>
''' which is useful for testing formatted read/write functions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/regTestGenLocalFilename/*"/>
'''  <param name="rp">[in] - regtest parameters</param>
'''  <param name="index">[in] - use -1 for current index</param>
'''  <param name="format">[in] - of image e.g., IFF_PNG</param>
'''   <returns>filename if OK, or NULL on error</returns>
Public Shared Function regTestGenLocalFilename(
				 ByVal rp as L_RegParams, 
				 ByVal index as Integer, 
				 ByVal format as Enumerations.IFF) as String

	If IsNothing (rp) then Throw New ArgumentNullException  ("rp cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.regTestGenLocalFilename( rp.Pointer, index, format)

	Return _Result
End Function

End Class
