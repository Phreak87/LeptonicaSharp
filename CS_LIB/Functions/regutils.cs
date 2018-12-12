using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// regutils.c (119, 1)
// regTestSetup(argc, argv, prp) as int
// regTestSetup(l_int32, char **, L_REGPARAMS **) as l_ok
///  <summary>
/// (1) Call this function with the args to the reg test.  The first arg
/// is the name of the reg test.  There are three cases:
/// Case 1:
/// There is either only one arg, or the second arg is "compare".
/// This is the mode in which you run a regression test
/// (or a set of them), looking for failures and logging
/// the results to a file.  The output, which includes
/// logging of all reg test failures plus a SUCCESS or
/// FAILURE summary for each test, is appended to the file
/// "/tmp/lept/reg_results.txt.  For this case, as in Case 2,
/// the display field in rp is set to FALSE, preventing
/// image display.
/// Case 2:
/// The second arg is "generate".  This will cause
/// generation of new golden files for the reg test.
/// The results of the reg test are not recorded, and
/// the display field in rp is set to FALSE.
/// Case 3:
/// The second arg is "display".  The test will run and
/// files will be written.  Comparisons with golden files
/// will not be carried out, so the only notion of success
/// or failure is with tests that do not involve golden files.
/// The display field in rp is TRUE, and this is used by
/// pixDisplayWithTitle().<para/>
/// 
/// (2) See regutils.h for examples of usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestSetup/*"/>
///  <param name="argc">[in] - from invocation can be either 1 or 2</param>
///  <param name="argv">[in] - to regtest: %argv[1] is one of these: "generate", "compare", "display"</param>
///  <param name="prp">[out] - all regression params</param>
///   <returns>0 if OK, 1 on error</returns>
public static int regTestSetup(
				 int argc, 
				 String[] argv, 
				out L_RegParams prp){

if (argv == null) {throw new ArgumentNullException  ("argv cannot be Nothing");}
	IntPtr argvPtr = 	Marshal.AllocHGlobal(Marshal.SizeOf(argv));
	IntPtr prpPtr = IntPtr.Zero;

	int _Result = Natives.regTestSetup(  argc,   argvPtr, out prpPtr);
	
	if (prpPtr == IntPtr.Zero) {prp = null;} else { prp = new L_RegParams(prpPtr); };
	return _Result;
}

// regutils.c (208, 1)
// regTestCleanup(rp) as int
// regTestCleanup(L_REGPARAMS *) as l_ok
///  <summary>
/// (1) This copies anything written to the temporary file to the
/// output file /tmp/lept/reg_results.txt.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCleanup/*"/>
///  <param name="rp">[in] - regression test parameters</param>
///   <returns>0 if OK, 1 on error</returns>
public static int regTestCleanup(
				 L_RegParams rp){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
	int _Result = Natives.regTestCleanup(rp.Pointer);
	
	return _Result;
}

// regutils.c (271, 1)
// regTestCompareValues(rp, val1, val2, delta) as int
// regTestCompareValues(L_REGPARAMS *, l_float32, l_float32, l_float32) as l_ok
///  <summary>
/// regTestCompareValues()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCompareValues/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="val1">[in] - typ. the golden value</param>
///  <param name="val2">[in] - typ. the value computed</param>
///  <param name="delta">[in] - allowed max absolute difference</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestCompareValues(
				 L_RegParams rp, 
				 Single val1, 
				 Single val2, 
				 Single delta){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
	int _Result = Natives.regTestCompareValues(rp.Pointer,   val1,   val2,   delta);
	
	return _Result;
}

// regutils.c (315, 1)
// regTestCompareStrings(rp, string1, bytes1, string2, bytes2) as int
// regTestCompareStrings(L_REGPARAMS *, l_uint8 *, size_t, l_uint8 *, size_t) as l_ok
///  <summary>
/// regTestCompareStrings()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCompareStrings/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="string1">[in] - typ. the expected string</param>
///  <param name="bytes1">[in] - size of string1</param>
///  <param name="string2">[in] - typ. the computed string</param>
///  <param name="bytes2">[in] - size of string2</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestCompareStrings(
				 L_RegParams rp, 
				 Byte[] string1, 
				 uint bytes1, 
				 Byte[] string2, 
				 uint bytes2){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (string1 == null) {throw new ArgumentNullException  ("string1 cannot be Nothing");}
		if (string2 == null) {throw new ArgumentNullException  ("string2 cannot be Nothing");}
	int _Result = Natives.regTestCompareStrings(rp.Pointer,   string1,   bytes1,   string2,   bytes2);
	
	return _Result;
}

// regutils.c (381, 1)
// regTestComparePix(rp, pix1, pix2) as int
// regTestComparePix(L_REGPARAMS *, PIX *, PIX *) as l_ok
///  <summary>
/// (1) This function compares two pix for equality.  On failure,
/// this writes to stderr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestComparePix/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="pix1">[in] - to be tested for equality</param>
///  <param name="pix2">[in] - to be tested for equality</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestComparePix(
				 L_RegParams rp, 
				 Pix pix1, 
				 Pix pix2){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}
		if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}
	int _Result = Natives.regTestComparePix(rp.Pointer, pix1.Pointer, pix2.Pointer);
	
	return _Result;
}

// regutils.c (441, 1)
// regTestCompareSimilarPix(rp, pix1, pix2, mindiff, maxfract, printstats) as int
// regTestCompareSimilarPix(L_REGPARAMS *, PIX *, PIX *, l_int32, l_float32, l_int32) as l_ok
///  <summary>
/// (1) This function compares two pix for near equality.  On failure,
/// this writes to stderr.<para/>
/// 
/// (2) The pix are similar if the fraction of non-conforming pixels
/// does not exceed %maxfract.  Pixels are non-conforming if
/// the difference in pixel values equals or exceeds %mindiff.
/// Typical values might be %mindiff = 15 and %maxfract = 0.01.<para/>
/// 
/// (3) The input images must have the same size and depth.  The
/// pixels for comparison are typically subsampled from the images.<para/>
/// 
/// (4) Normally, use %printstats = 0.  In debugging mode, to see
/// the relation between %mindiff and the minimum value of
/// %maxfract for success, set this to 1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCompareSimilarPix/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="pix1">[in] - to be tested for near equality</param>
///  <param name="pix2">[in] - to be tested for near equality</param>
///  <param name="mindiff">[in] - minimum pixel difference to be counted  is greater  0</param>
///  <param name="maxfract">[in] - maximum fraction of pixels allowed to have diff greater than or equal to mindiff</param>
///  <param name="printstats">[in] - use 1 to print normalized histogram to stderr</param>
///   <returns>0 if OK, 1 on error a failure in similarity comparison is not an error</returns>
public static int regTestCompareSimilarPix(
				 L_RegParams rp, 
				 Pix pix1, 
				 Pix pix2, 
				 int mindiff, 
				 Single maxfract, 
				 int printstats){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (pix1 == null) {throw new ArgumentNullException  ("pix1 cannot be Nothing");}
		if (pix2 == null) {throw new ArgumentNullException  ("pix2 cannot be Nothing");}
	int _Result = Natives.regTestCompareSimilarPix(rp.Pointer, pix1.Pointer, pix2.Pointer,   mindiff,   maxfract,   printstats);
	
	return _Result;
}

// regutils.c (504, 1)
// regTestCheckFile(rp, localname) as int
// regTestCheckFile(L_REGPARAMS *, const char *) as l_ok
///  <summary>
/// (1) This function does one of three things, depending on the mode:
/// "generate": makes a "golden" file as a copy %localname.
/// "compare": compares %localname contents with the golden file
/// "display": makes the %localname file but does no comparison<para/>
/// 
/// (2) The canonical format of the golden filenames is:
/// /tmp/lept/golden/[root of main name]_golden.[index].
/// [ext of localname]
/// e.g.,
/// /tmp/lept/golden/maze_golden.0.png
/// It is important to add an extension to the local name, because
/// the extension is added to the name of the golden file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCheckFile/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="localname">[in] - name of output file from reg test</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestCheckFile(
				 L_RegParams rp, 
				 String localname){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (localname == null) {throw new ArgumentNullException  ("localname cannot be Nothing");}
	int _Result = Natives.regTestCheckFile(rp.Pointer,   localname);
	
	return _Result;
}

// regutils.c (611, 1)
// regTestCompareFiles(rp, index1, index2) as int
// regTestCompareFiles(L_REGPARAMS *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) This only does something in "compare" mode.<para/>
/// 
/// (2) The canonical format of the golden filenames is:
/// /tmp/lept/golden/[root of main name]_golden.[index].
/// [ext of localname]
/// e.g.,
/// /tmp/lept/golden/maze_golden.0.png
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestCompareFiles/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="index1">[in] - of one output file from reg test</param>
///  <param name="index2">[in] - of another output file from reg test</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestCompareFiles(
				 L_RegParams rp, 
				 int index1, 
				 int index2){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
	int _Result = Natives.regTestCompareFiles(rp.Pointer,   index1,   index2);
	
	return _Result;
}

// regutils.c (704, 1)
// regTestWritePixAndCheck(rp, pix, format) as int
// regTestWritePixAndCheck(L_REGPARAMS *, PIX *, l_int32) as l_ok
///  <summary>
/// (1) This function makes it easy to write the pix in a numbered
/// sequence of files, and either to:
/// (a) write the golden file ("generate" arg to regression test)
/// (b) make a local file and "compare" with the golden file
/// (c) make a local file and "display" the results<para/>
/// 
/// (2) The canonical format of the local filename is:
/// /tmp/lept/regout/[root of main name].[count].[format extension]
/// e.g., for scale_reg,
/// /tmp/lept/regout/scale.0.png
/// The golden file name mirrors this in the usual way.<para/>
/// 
/// (3) The check is done between the written files, which requires
/// the files to be identical. The exception is for GIF, which
/// only requires that all pixels in the decoded pix are identical.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestWritePixAndCheck/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="pix">[in] - to be written</param>
///  <param name="format">[in] - of output pix</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestWritePixAndCheck(
				 L_RegParams rp, 
				 Pix pix, 
				 IFF format){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	int _Result = Natives.regTestWritePixAndCheck(rp.Pointer, pix.Pointer,  (int) format);
	
	return _Result;
}

// regutils.c (770, 1)
// regTestWriteDataAndCheck(rp, data, nbytes, ext) as int
// regTestWriteDataAndCheck(L_REGPARAMS *, void *, size_t, const char *) as l_ok
///  <summary>
/// (1) This function makes it easy to write data in a numbered
/// sequence of files, and either to:
/// (a) write the golden file ("generate" arg to regression test)
/// (b) make a local file and "compare" with the golden file
/// (c) make a local file and "display" the results<para/>
/// 
/// (2) The canonical format of the local filename is:
/// /tmp/lept/regout/[root of main name].[count].[ext]
/// e.g., for the first boxaa in quadtree_reg,
/// /tmp/lept/regout/quadtree.0.baa
/// The golden file name mirrors this in the usual way.<para/>
/// 
/// (3) The data can be anything.  It is most useful for serialized
/// output of data, such as boxa, pta, etc.<para/>
/// 
/// (4) The file extension is arbitrary.  It is included simply
/// to make the content type obvious when examining written files.<para/>
/// 
/// (5) The check is done between the written files, which requires
/// the files to be identical.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestWriteDataAndCheck/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="data">[in] - to be written</param>
///  <param name="nbytes">[in] - of data to be written</param>
///  <param name="ext">[in] - filename extension (e.g.: "ba", "pta")</param>
///   <returns>0 if OK, 1 on error a failure in comparison is not an error</returns>
public static int regTestWriteDataAndCheck(
				 L_RegParams rp, 
				 Object data, 
				 uint nbytes, 
				 String ext){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
		if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
		if (ext == null) {throw new ArgumentNullException  ("ext cannot be Nothing");}
	IntPtr dataPtr = IntPtr.Zero;
	if (data.GetType() == typeof(IntPtr))
	{
	  dataPtr = (IntPtr)data;
	}
	else if (data.GetType() == typeof(Byte[]))
	{ 
	  var cdata = (Byte[])data;
	  dataPtr = Marshal.AllocHGlobal(cdata.Length);
	   Marshal.Copy(cdata, 0, dataPtr, cdata.Length);
	}
	else if (data.GetType().GetProperty("data") != null)
	{
	   var cdata = (Byte[])data.GetType().GetProperty("data").GetValue(data, null);
	   dataPtr = Marshal.AllocHGlobal(cdata.Length);
	   Marshal.Copy(cdata, 0, dataPtr, cdata.Length);
	}

	int _Result = Natives.regTestWriteDataAndCheck(rp.Pointer,   dataPtr,   nbytes,   ext);
	
	Marshal.FreeHGlobal(dataPtr);
	return _Result;
}

// regutils.c (821, 1)
// regTestGenLocalFilename(rp, index, format) as String
// regTestGenLocalFilename(L_REGPARAMS *, l_int32, l_int32) as char *
///  <summary>
/// (1) This is used to get the name of a file in the regout
/// subdirectory, that has been made and is used to test against
/// the golden file.  You can either specify a particular index
/// value, or with %index == -1, this returns the most recently
/// written file.  The latter case lets you read a pix from a
/// file that has just been written with regTestWritePixAndCheck(),
/// which is useful for testing formatted read/write functions.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/regTestGenLocalFilename/*"/>
///  <param name="rp">[in] - regtest parameters</param>
///  <param name="index">[in] - use -1 for current index</param>
///  <param name="format">[in] - of image e.g., IFF_PNG</param>
///   <returns>filename if OK, or NULL on error</returns>
public static String regTestGenLocalFilename(
				 L_RegParams rp, 
				 int index, 
				 IFF format){

if (rp == null) {throw new ArgumentNullException  ("rp cannot be Nothing");}
	String _Result = Natives.regTestGenLocalFilename(rp.Pointer,   index,  (int) format);
	
	return _Result;
}


}
}
