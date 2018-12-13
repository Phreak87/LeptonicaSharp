using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// utils1.c (125, 1)
		// setMsgSeverity(newsev) as int
		// setMsgSeverity(l_int32) as l_int32
		///  <summary>
		/// (1) setMsgSeverity() allows the user to specify the desired
		/// message severity threshold.  Messages of equal or greater
		/// severity will be output.  The previous message severity is
		/// returned when the new severity is set.<para/>
		///
		/// (2) If L_SEVERITY_EXTERNAL is passed, then the severity will be
		/// obtained from the LEPT_MSG_SEVERITY environment variable.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/setMsgSeverity/*"/>
		///  <param name="newsev">[in] - </param>
		///   <returns>oldsev</returns>
		public static int setMsgSeverity(
						int newsev)
		{
			int _Result = Natives.setMsgSeverity(  newsev);
			return _Result;
		}

		// utils1.c (176, 1)
		// returnErrorInt(msg, procname, ival) as int
		// returnErrorInt(const char *, const char *, l_int32) as l_int32
		///  <summary>
		/// returnErrorInt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/returnErrorInt/*"/>
		///  <param name="msg">[in] - error message</param>
		///  <param name="procname">[in] - </param>
		///  <param name="ival">[in] - return val</param>
		///   <returns>ival typically 1 for an error return</returns>
		public static int returnErrorInt(
						String msg,
						String procname,
						int ival)
		{
			if (msg == null) {throw new ArgumentNullException  ("msg cannot be Nothing");}

			if (procname == null) {throw new ArgumentNullException  ("procname cannot be Nothing");}

			int _Result = Natives.returnErrorInt(  msg,   procname,   ival);
			return _Result;
		}

		// utils1.c (194, 1)
		// returnErrorFloat(msg, procname, fval) as Single
		// returnErrorFloat(const char *, const char *, l_float32) as l_float32
		///  <summary>
		/// returnErrorFloat()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/returnErrorFloat/*"/>
		///  <param name="msg">[in] - error message</param>
		///  <param name="procname">[in] - </param>
		///  <param name="fval">[in] - return val</param>
		///   <returns>fval</returns>
		public static Single returnErrorFloat(
						String msg,
						String procname,
						Single fval)
		{
			if (msg == null) {throw new ArgumentNullException  ("msg cannot be Nothing");}

			if (procname == null) {throw new ArgumentNullException  ("procname cannot be Nothing");}

			Single _Result = Natives.returnErrorFloat(  msg,   procname,   fval);
			return _Result;
		}

		// utils1.c (212, 1)
		// returnErrorPtr(msg, procname, pval) as Object
		// returnErrorPtr(const char *, const char *, void *) as void *
		///  <summary>
		/// returnErrorPtr()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/returnErrorPtr/*"/>
		///  <param name="msg">[in] - error message</param>
		///  <param name="procname">[in] - </param>
		///  <param name="pval">[in] - return val</param>
		///   <returns>pval typically null</returns>
		public static Object returnErrorPtr(
						String msg,
						String procname,
						Object pval)
		{
			if (msg == null) {throw new ArgumentNullException  ("msg cannot be Nothing");}

			if (procname == null) {throw new ArgumentNullException  ("procname cannot be Nothing");}

			if (pval == null) {throw new ArgumentNullException  ("pval cannot be Nothing");}

			IntPtr pvalPtr = IntPtr.Zero;

			if (pval.GetType() == typeof(IntPtr)) {
				pvalPtr = (IntPtr)pval;
			} else if (pval.GetType() == typeof(Byte[])) {
				var cdata = (Byte[])pval;
				pvalPtr = Marshal.AllocHGlobal(cdata.Length);
				Marshal.Copy(cdata, 0, pvalPtr, cdata.Length);
			} else if (pval.GetType().GetProperty("pval") != null) {
				var cdata = (Byte[])pval.GetType().GetProperty("data").GetValue(pval, null);
				pvalPtr = Marshal.AllocHGlobal(cdata.Length);
				Marshal.Copy(cdata, 0, pvalPtr, cdata.Length);
			}

			IntPtr _Result = Natives.returnErrorPtr(  msg,   procname,   pvalPtr);
			Marshal.FreeHGlobal(pvalPtr);
			Byte[] B = new Byte[1];
			Marshal.Copy(_Result, B, 0, B.Length);
			return B;
		}

		// utils1.c (233, 1)
		// filesAreIdentical(fname1, fname2, psame) as int
		// filesAreIdentical(const char *, const char *, l_int32 *) as l_ok
		///  <summary>
		/// filesAreIdentical()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/filesAreIdentical/*"/>
		///  <param name="fname1">[in] - </param>
		///  <param name="fname2">[in] - </param>
		///  <param name="psame">[out] - 1 if identical 0 if different</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int filesAreIdentical(
						String fname1,
						String fname2,
						out int psame)
		{
			if (fname1 == null) {throw new ArgumentNullException  ("fname1 cannot be Nothing");}

			if (fname2 == null) {throw new ArgumentNullException  ("fname2 cannot be Nothing");}

			int _Result = Natives.filesAreIdentical(  fname1,   fname2, out  psame);
			return _Result;
		}

		// utils1.c (303, 1)
		// convertOnLittleEnd16(shortin) as ushort
		// convertOnLittleEnd16(l_uint16) as l_uint16
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertOnLittleEnd16/*"/>
		///   <returns></returns>
		public static ushort convertOnLittleEnd16(
						ushort shortin)
		{
			ushort _Result = Natives.convertOnLittleEnd16(  shortin);
			return _Result;
		}

		// utils1.c (309, 1)
		// convertOnBigEnd16(shortin) as ushort
		// convertOnBigEnd16(l_uint16) as l_uint16
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertOnBigEnd16/*"/>
		///   <returns></returns>
		public static ushort convertOnBigEnd16(
						ushort shortin)
		{
			ushort _Result = Natives.convertOnBigEnd16(  shortin);
			return _Result;
		}

		// utils1.c (338, 1)
		// convertOnLittleEnd32(wordin) as uint
		// convertOnLittleEnd32(l_uint32) as l_uint32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertOnLittleEnd32/*"/>
		///   <returns></returns>
		public static uint convertOnLittleEnd32(
						uint wordin)
		{
			uint _Result = Natives.convertOnLittleEnd32(  wordin);
			return _Result;
		}

		// utils1.c (345, 1)
		// convertOnBigEnd32(wordin) as uint
		// convertOnBigEnd32(l_uint32) as l_uint32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertOnBigEnd32/*"/>
		///   <returns></returns>
		public static uint convertOnBigEnd32(
						uint wordin)
		{
			uint _Result = Natives.convertOnBigEnd32(  wordin);
			return _Result;
		}

		// utils1.c (377, 1)
		// fileCorruptByDeletion(filein, loc, size, fileout) as int
		// fileCorruptByDeletion(const char *, l_float32, l_float32, const char *) as l_ok
		///  <summary>
		/// (1) %loc and %size are expressed as a fraction of the file size.<para/>
		///
		/// (2) This makes a copy of the data in %filein, where bytes in the
		/// specified region have deleted.<para/>
		///
		/// (3) If (%loc + %size) greater or equal 1.0, this deletes from the position
		/// represented by %loc to the end of the file.<para/>
		///
		/// (4) It is useful for testing robustness of I/O wrappers when the
		/// data is corrupted, by simulating data corruption by deletion.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileCorruptByDeletion/*"/>
		///  <param name="filein">[in] - </param>
		///  <param name="loc">[in] - fractional location of start of deletion</param>
		///  <param name="size">[in] - fractional size of deletion</param>
		///  <param name="fileout">[in] - corrupted file</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int fileCorruptByDeletion(
						String filein,
						Single loc,
						Single size,
						String fileout)
		{
			if (filein == null) {throw new ArgumentNullException  ("filein cannot be Nothing");}

			if (fileout == null) {throw new ArgumentNullException  ("fileout cannot be Nothing");}

			int _Result = Natives.fileCorruptByDeletion(  filein,   loc,   size,   fileout);
			return _Result;
		}

		// utils1.c (441, 1)
		// fileCorruptByMutation(filein, loc, size, fileout) as int
		// fileCorruptByMutation(const char *, l_float32, l_float32, const char *) as l_ok
		///  <summary>
		/// (1) %loc and %size are expressed as a fraction of the file size.<para/>
		///
		/// (2) This makes a copy of the data in %filein, where bytes in the
		/// specified region have been replaced by random data.<para/>
		///
		/// (3) If (%loc + %size) greater or equal 1.0, this modifies data from the position
		/// represented by %loc to the end of the file.<para/>
		///
		/// (4) It is useful for testing robustness of I/O wrappers when the
		/// data is corrupted, by simulating data corruption.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileCorruptByMutation/*"/>
		///  <param name="filein">[in] - </param>
		///  <param name="loc">[in] - fractional location of start of randomization</param>
		///  <param name="size">[in] - fractional size of randomization</param>
		///  <param name="fileout">[in] - corrupted file</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int fileCorruptByMutation(
						String filein,
						Single loc,
						Single size,
						String fileout)
		{
			if (filein == null) {throw new ArgumentNullException  ("filein cannot be Nothing");}

			if (fileout == null) {throw new ArgumentNullException  ("fileout cannot be Nothing");}

			int _Result = Natives.fileCorruptByMutation(  filein,   loc,   size,   fileout);
			return _Result;
		}

		// utils1.c (499, 1)
		// genRandomIntegerInRange(range, seed, pval) as int
		// genRandomIntegerInRange(l_int32, l_int32, l_int32 *) as l_ok
		///  <summary>
		/// (1) For example, to choose a rand integer between 0 and 99,
		/// use %range = 100.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/genRandomIntegerInRange/*"/>
		///  <param name="range">[in] - size of range must be greater or equal 2</param>
		///  <param name="seed">[in] - use 0 to skip otherwise call srand</param>
		///  <param name="pval">[out] - random integer in range {0 ... range-1}</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int genRandomIntegerInRange(
						int range,
						int seed,
						out int pval)
		{
			int _Result = Natives.genRandomIntegerInRange(  range,   seed, out  pval);
			return _Result;
		}

		// utils1.c (536, 1)
		// lept_roundftoi(fval) as int
		// lept_roundftoi(l_float32) as l_int32
		///  <summary>
		/// (1) For fval greater or equal 0, fval to round(fval) == floor(fval + 0.5)
		/// For fval  is smaller 0, fval to -round(-fval))
		/// This is symmetric around 0.
		/// e.g., for fval in (-0.5 ... 0.5), fval to 0
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_roundftoi/*"/>
		///  <param name="fval">[in] - </param>
		///   <returns>value rounded to int</returns>
		public static int lept_roundftoi(
						Single fval)
		{
			int _Result = Natives.lept_roundftoi(  fval);
			return _Result;
		}

		// utils1.c (568, 1)
		// l_hashStringToUint64(str, phash) as int
		// l_hashStringToUint64(const char *, l_uint64 *) as l_ok
		///  <summary>
		/// (1) The intent of the hash is to avoid collisions by mapping
		/// the string as randomly as possible into 64 bits.<para/>
		///
		/// (2) To the extent that the hashes are random, the probability of
		/// a collision can be approximated by the square of the number
		/// of strings divided by 2^64.  For 1 million strings, the
		/// collision probability is about 1 in 16 million.<para/>
		///
		/// (3) I expect non-randomness of the distribution to be most evident
		/// for small text strings.  This hash function has been tested
		/// for all 5-character text strings composed of 26 letters,
		/// of which there are 26^5 = 12356630.  There are no hash
		/// collisions for this set.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_hashStringToUint64/*"/>
		///  <param name="str">[in] - </param>
		///  <param name="phash">[out] - hash vale</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_hashStringToUint64(
						String str,
						out ulong phash)
		{
			if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}

			int _Result = Natives.l_hashStringToUint64(  str, out  phash);
			return _Result;
		}

		// utils1.c (614, 1)
		// l_hashPtToUint64(x, y, phash) as int
		// l_hashPtToUint64(l_int32, l_int32, l_uint64 *) as l_ok
		///  <summary>
		/// (1) I found that a simple hash function has no collisions for
		/// any of 400 million points with x and y up to 20000.<para/>
		///
		/// (2) Previously used a much more complicated and slower function:
		/// mulp = 26544357894361
		/// hash = 104395301
		/// hash += (x  mulp) ^ (hash  is greater  is greater  5)
		/// hash ^= (hash  is smaller is smaller 7)
		/// hash += (y  mulp) ^ (hash  is greater  is greater  7)
		/// hash = hash ^ (hash  is smaller is smaller 11)
		/// Such logical gymnastics to get coverage over the 2^64
		/// values are not required.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_hashPtToUint64/*"/>
		///  <param name="x">[in] - </param>
		///  <param name="y">[in] - </param>
		///  <param name="phash">[out] - hash value</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_hashPtToUint64(
						int x,
						int y,
						out ulong phash)
		{
			int _Result = Natives.l_hashPtToUint64(  x,   y, out  phash);
			return _Result;
		}

		// utils1.c (654, 1)
		// l_hashFloat64ToUint64(nbuckets, val, phash) as int
		// l_hashFloat64ToUint64(l_int32, l_float64, l_uint64 *) as l_ok
		///  <summary>
		/// (1) Simple, fast hash for using dnaHash with 64-bit data
		/// (e.g., sets and histograms).<para/>
		///
		/// (2) The resulting hash is called a "key" in a lookup
		/// operation.  The bucket for %val in a dnaHash is simply
		/// found by taking the mod of the hash with the number of
		/// buckets (which is prime).  What gets stored in the
		/// dna in that bucket could depend on use, but for the most
		/// flexibility, we store an index into the associated dna.
		/// This is all that is required for generating either a hash set
		/// or a histogram (an example of a hash map).<para/>
		///
		/// (3) For example, to generate a histogram, the histogram dna,
		/// a histogram of unique values aligned with the histogram dna,
		/// and a dnahash hashmap are built.  See l_dnaMakeHistoByHash().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_hashFloat64ToUint64/*"/>
		///  <param name="nbuckets">[in] - </param>
		///  <param name="val">[in] - </param>
		///  <param name="phash">[out] - hash value</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int l_hashFloat64ToUint64(
						int nbuckets,
						double val,
						out ulong phash)
		{
			int _Result = Natives.l_hashFloat64ToUint64(  nbuckets,   val, out  phash);
			return _Result;
		}

		// utils1.c (678, 1)
		// findNextLargerPrime(start, pprime) as int
		// findNextLargerPrime(l_int32, l_uint32 *) as l_ok
		///  <summary>
		/// findNextLargerPrime()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findNextLargerPrime/*"/>
		///  <param name="start">[in] - </param>
		///  <param name="pprime">[out] - first prime larger than %start</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int findNextLargerPrime(
						int start,
						out uint pprime)
		{
			int _Result = Natives.findNextLargerPrime(  start, out  pprime);
			return _Result;
		}

		// utils1.c (713, 1)
		// lept_isPrime(n, pis_prime, pfactor) as int
		// lept_isPrime(l_uint64, l_int32 *, l_uint32 *) as l_ok
		///  <summary>
		/// lept_isPrime()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_isPrime/*"/>
		///  <param name="n">[in] - 64-bit unsigned</param>
		///  <param name="pis_prime">[out] - 1 if prime, 0 otherwise</param>
		///  <param name="pfactor">[out][optional] - smallest divisor, or 0 on error or if prime</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int lept_isPrime(
						ulong n,
						out int pis_prime,
						out uint pfactor)
		{
			int _Result = Natives.lept_isPrime(  n, out  pis_prime, out  pfactor);
			return _Result;
		}

		// utils1.c (764, 1)
		// convertIntToGrayCode(val) as uint
		// convertIntToGrayCode(l_uint32) as l_uint32
		///  <summary>
		/// (1) Gray code values corresponding to integers differ by
		/// only one bit transition between successive integers.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertIntToGrayCode/*"/>
		///  <param name="val">[in] - integer value</param>
		///   <returns>corresponding gray code value</returns>
		public static uint convertIntToGrayCode(
						uint val)
		{
			uint _Result = Natives.convertIntToGrayCode(  val);
			return _Result;
		}

		// utils1.c (777, 1)
		// convertGrayCodeToInt(val) as uint
		// convertGrayCodeToInt(l_uint32) as l_uint32
		///  <summary>
		/// convertGrayCodeToInt()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertGrayCodeToInt/*"/>
		///  <param name="val">[in] - gray code value</param>
		///   <returns>corresponding integer value</returns>
		public static uint convertGrayCodeToInt(
						uint val)
		{
			uint _Result = Natives.convertGrayCodeToInt(  val);
			return _Result;
		}

		// utils1.c (799, 1)
		// getLeptonicaVersion() as String
		// getLeptonicaVersion() as char *
		///  <summary>
		/// getLeptonicaVersion() Return: string of version number (e.g., 'leptonica-1.74.2') Notes: (1) The caller has responsibility to free the memory.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getLeptonicaVersion/*"/>
		///   <returns></returns>
		public static String getLeptonicaVersion()
		{
			String _Result = Natives.getLeptonicaVersion();
			return _Result;
		}

		// utils1.c (946, 1)
		// startTimer() as Object
		// startTimer() as void
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/startTimer/*"/>
		public static void startTimer()
		{
			Natives.startTimer();
		}

		// utils1.c (960, 1)
		// stopTimer() as Single
		// stopTimer() as l_float32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stopTimer/*"/>
		///   <returns></returns>
		public static Single stopTimer()
		{
			Single _Result = Natives.stopTimer();
			return _Result;
		}

		// utils1.c (977, 1)
		// startTimerNested() as IntPtr
		// startTimerNested() as L_TIMER
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/startTimerNested/*"/>
		///   <returns></returns>
		public static IntPtr startTimerNested()
		{
			IntPtr _Result = Natives.startTimerNested();
			return _Result;
		}

		// utils1.c (994, 1)
		// stopTimerNested(utime_start) as Single
		// stopTimerNested(L_TIMER) as l_float32
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stopTimerNested/*"/>
		///   <returns></returns>
		public static Single stopTimerNested(
						IntPtr utime_start)
		{
			if (utime_start == null) {throw new ArgumentNullException  ("utime_start cannot be Nothing");}

			Single _Result = Natives.stopTimerNested(  utime_start);
			return _Result;
		}

		// utils1.c (1013, 1)
		// l_getCurrentTime(sec, usec) as Object
		// l_getCurrentTime(l_int32 *, l_int32 *) as void
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getCurrentTime/*"/>
		public static void l_getCurrentTime(
						object sec,
						object usec)
		{
			if (sec == null) {throw new ArgumentNullException  ("sec cannot be Nothing");}

			if (usec == null) {throw new ArgumentNullException  ("usec cannot be Nothing");}

			Natives.l_getCurrentTime(  sec,   usec);
		}

		// utils1.c (1053, 1)
		// startWallTimer() as L_WallTimer
		// startWallTimer() as L_WALLTIMER *
		///  <summary>
		/// (1) These measure the wall clock time  elapsed between the two calls:
		/// L_WALLTIMER timer = startWallTimer()
		/// ....
		/// fprintf(stderr, "Elapsed time = %f sec\n", stopWallTimer([and]timer)<para/>
		///
		/// (2) Note that the timer object is destroyed by stopWallTimer().
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/startWallTimer/*"/>
		///   <returns>walltimer-ptr</returns>
		public static L_WallTimer startWallTimer()
		{
			IntPtr _Result = Natives.startWallTimer();

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_WallTimer(_Result);
		}

		// utils1.c (1069, 1)
		// stopWallTimer(ptimer) as Single
		// stopWallTimer(L_WALLTIMER **) as l_float32
		///  <summary>
		/// stopWallTimer()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stopWallTimer/*"/>
		///  <param name="ptimer">[in,out] - walltimer-ptr</param>
		///   <returns>time wall time elapsed in seconds</returns>
		public static Single stopWallTimer(
						ref L_WallTimer ptimer)
		{
			IntPtr ptimerPtr = IntPtr.Zero; 	if (ptimer != null) {ptimerPtr = ptimer.Pointer;}
			Single _Result = Natives.stopWallTimer(ref ptimerPtr);
			if (ptimerPtr == IntPtr.Zero) {ptimer = null;} else { ptimer = new L_WallTimer(ptimerPtr); };

			return _Result;
		}

		// utils1.c (1104, 1)
		// l_getFormattedDate() as String
		// l_getFormattedDate() as char *
		///  <summary>
		/// (1) This is used in pdf, in the form specified in section 3.8.2 of
		/// http://partners.adobe.com/public/developer/en/pdf/PDFReference.pdf<para/>
		///
		/// (2) Contributed by Dave Bryan.  Works on all platforms.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getFormattedDate/*"/>
		///   <returns>formatted date string, or NULL on error</returns>
		public static String l_getFormattedDate()
		{
			String _Result = Natives.l_getFormattedDate();
			return _Result;
		}


	}
}
