Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\utils1.c (125, 1)
' setMsgSeverity()
' setMsgSeverity(l_int32) as l_int32
'''  <summary>
''' Notes
''' (1) setMsgSeverity() allows the user to specify the desired
''' message severity threshold.  Messages of equal or greater
''' severity will be output.  The previous message severity is
''' returned when the new severity is set.
''' (2) If L_SEVERITY_EXTERNAL is passed, then the severity will be
''' obtained from the LEPT_MSG_SEVERITY environment variable.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="newsev">[in] - </param>
'''   <returns>oldsev</returns>
Public Shared Function setMsgSeverity(
				ByVal newsev as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.setMsgSeverity( newsev)

	Return _Result
End Function

' SRC\utils1.c (176, 1)
' returnErrorInt()
' returnErrorInt(const char *, const char *, l_int32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="msg">[in] - error message</param>
'''  <param name="procname">[in] - </param>
'''  <param name="ival">[in] - return val</param>
'''   <returns>ival typically 1 for an error return</returns>
Public Shared Function returnErrorInt(
				ByVal msg as String, 
				ByVal procname as String, 
				ByVal ival as Integer) as Integer

	If IsNothing (msg) then Throw New ArgumentNullException  ("msg cannot be Nothing")
	If IsNothing (procname) then Throw New ArgumentNullException  ("procname cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.returnErrorInt( msg, procname, ival)

	Return _Result
End Function

' SRC\utils1.c (194, 1)
' returnErrorFloat()
' returnErrorFloat(const char *, const char *, l_float32) as l_float32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="msg">[in] - error message</param>
'''  <param name="procname">[in] - </param>
'''  <param name="fval">[in] - return val</param>
'''   <returns>fval</returns>
Public Shared Function returnErrorFloat(
				ByVal msg as String, 
				ByVal procname as String, 
				ByVal fval as Single) as Single

	If IsNothing (msg) then Throw New ArgumentNullException  ("msg cannot be Nothing")
	If IsNothing (procname) then Throw New ArgumentNullException  ("procname cannot be Nothing")
	If IsNothing (fval) then Throw New ArgumentNullException  ("fval cannot be Nothing")


	Dim _Result as Single = LeptonicaSharp.Natives.returnErrorFloat( msg, procname, fval)

	Return _Result
End Function

' SRC\utils1.c (212, 1)
' returnErrorPtr()
' returnErrorPtr(const char *, const char *, void *) as void *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="msg">[in] - error message</param>
'''  <param name="procname">[in] - </param>
'''  <param name="pval">[in] - return val</param>
'''   <returns>pval typically null</returns>
Public Shared Function returnErrorPtr(
				ByVal msg as String, 
				ByVal procname as String, 
				ByVal pval as Object) as Object

	If IsNothing (msg) then Throw New ArgumentNullException  ("msg cannot be Nothing")
	If IsNothing (procname) then Throw New ArgumentNullException  ("procname cannot be Nothing")
	If IsNothing (pval) then Throw New ArgumentNullException  ("pval cannot be Nothing")

Dim pvalPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.returnErrorPtr( msg, procname, pvalPTR)

	Return _Result
End Function

' SRC\utils1.c (233, 1)
' filesAreIdentical()
' filesAreIdentical(const char *, const char *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname1">[in] - </param>
'''  <param name="fname2">[in] - </param>
'''  <param name="psame">[out] - 1 if identical; 0 if different</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function filesAreIdentical(
				ByVal fname1 as String, 
				ByVal fname2 as String, 
				ByRef psame as Integer) as Integer

	If IsNothing (fname1) then Throw New ArgumentNullException  ("fname1 cannot be Nothing")
	If IsNothing (fname2) then Throw New ArgumentNullException  ("fname2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.filesAreIdentical( fname1, fname2, psame)

	Return _Result
End Function

' SRC\utils1.c (303, 1)
' 
' convertOnLittleEnd16(l_uint16) as l_uint16
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertOnLittleEnd16(
				ByRef shortin as UShort) as UShort

	If IsNothing (shortin) then Throw New ArgumentNullException  ("shortin cannot be Nothing")


	Dim _Result as UShort = LeptonicaSharp.Natives.convertOnLittleEnd16( shortin)

	Return _Result
End Function

' SRC\utils1.c (309, 1)
' 
' convertOnBigEnd16(l_uint16) as l_uint16
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertOnBigEnd16(
				ByRef shortin as UShort) as UShort

	If IsNothing (shortin) then Throw New ArgumentNullException  ("shortin cannot be Nothing")


	Dim _Result as UShort = LeptonicaSharp.Natives.convertOnBigEnd16( shortin)

	Return _Result
End Function

' SRC\utils1.c (338, 1)
' 
' convertOnLittleEnd32(l_uint32) as l_uint32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertOnLittleEnd32(
				ByRef wordin as UInteger) as UInteger

	If IsNothing (wordin) then Throw New ArgumentNullException  ("wordin cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.convertOnLittleEnd32( wordin)

	Return _Result
End Function

' SRC\utils1.c (345, 1)
' 
' convertOnBigEnd32(l_uint32) as l_uint32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertOnBigEnd32(
				ByRef wordin as UInteger) as UInteger

	If IsNothing (wordin) then Throw New ArgumentNullException  ("wordin cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.convertOnBigEnd32( wordin)

	Return _Result
End Function

' SRC\utils1.c (377, 1)
' fileCorruptByDeletion()
' fileCorruptByDeletion(const char *, l_float32, l_float32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) %loc and %size are expressed as a fraction of the file size.
''' (2) This makes a copy of the data in %filein, where bytes in the
''' specified region have deleted.
''' (3) If (%loc + %size) GT= 1.0, this deletes from the position
''' represented by %loc to the end of the file.
''' (4) It is useful for testing robustness of I/O wrappers when the
''' data is corrupted, by simulating data corruption by deletion.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - </param>
'''  <param name="loc">[in] - fractional location of start of deletion</param>
'''  <param name="size">[in] - fractional size of deletion</param>
'''  <param name="fileout">[in] - corrupted file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fileCorruptByDeletion(
				ByVal filein as String, 
				ByVal loc as Single, 
				ByVal size as Single, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (loc) then Throw New ArgumentNullException  ("loc cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fileCorruptByDeletion( filein, loc, size, fileout)

	Return _Result
End Function

' SRC\utils1.c (441, 1)
' fileCorruptByMutation()
' fileCorruptByMutation(const char *, l_float32, l_float32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) %loc and %size are expressed as a fraction of the file size.
''' (2) This makes a copy of the data in %filein, where bytes in the
''' specified region have been replaced by random data.
''' (3) If (%loc + %size) GT= 1.0, this modifies data from the position
''' represented by %loc to the end of the file.
''' (4) It is useful for testing robustness of I/O wrappers when the
''' data is corrupted, by simulating data corruption.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - </param>
'''  <param name="loc">[in] - fractional location of start of randomization</param>
'''  <param name="size">[in] - fractional size of randomization</param>
'''  <param name="fileout">[in] - corrupted file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fileCorruptByMutation(
				ByVal filein as String, 
				ByVal loc as Single, 
				ByVal size as Single, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (loc) then Throw New ArgumentNullException  ("loc cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fileCorruptByMutation( filein, loc, size, fileout)

	Return _Result
End Function

' SRC\utils1.c (499, 1)
' genRandomIntegerInRange()
' genRandomIntegerInRange(l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) For example, to choose a rand integer between 0 and 99,
''' use %range = 100.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="range">[in] - size of range; must be GT= 2</param>
'''  <param name="seed">[in] - use 0 to skip; otherwise call srand</param>
'''  <param name="pval">[out] - random integer in range {0 ... range-1}</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function genRandomIntegerInRange(
				ByVal range as Integer, 
				ByVal seed as Integer, 
				ByRef pval as Integer) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.genRandomIntegerInRange( range, seed, pval)

	Return _Result
End Function

' SRC\utils1.c (536, 1)
' lept_roundftoi()
' lept_roundftoi(l_float32) as l_int32
'''  <summary>
''' Notes
''' (1) For fval GT= 0, fval --GT round(fval) == floor(fval + 0.5)
''' For fval LT 0, fval --GT -round(-fval))
''' This is symmetric around 0.
''' e.g., for fval in (-0.5 ... 0.5), fval --GT 0
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fval">[in] - </param>
'''   <returns>value rounded to int</returns>
Public Shared Function lept_roundftoi(
				ByVal fval as Single) as Integer

	If IsNothing (fval) then Throw New ArgumentNullException  ("fval cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_roundftoi( fval)

	Return _Result
End Function

' SRC\utils1.c (568, 1)
' l_hashStringToUint64()
' l_hashStringToUint64(const char *, l_uint64 *) as l_ok
'''  <summary>
''' Notes
''' (1) The intent of the hash is to avoid collisions by mapping
''' the string as randomly as possible into 64 bits.
''' (2) To the extent that the hashes are random, the probability of
''' a collision can be approximated by the square of the number
''' of strings divided by 2^64.  For 1 million strings, the
''' collision probability is about 1 in 16 million.
''' (3) I expect non-randomness of the distribution to be most evident
''' for small text strings.  This hash function has been tested
''' for all 5-character text strings composed of 26 letters,
''' of which there are 26^5 = 12356630.  There are no hash
''' collisions for this set.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="str">[in] - </param>
'''  <param name="phash">[out] - hash vale</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_hashStringToUint64(
				ByVal str as String, 
				ByRef phash as ULong) as Integer

	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")

Dim phashPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.l_hashStringToUint64( str, phashPTR)

	Return _Result
End Function

' SRC\utils1.c (614, 1)
' l_hashPtToUint64()
' l_hashPtToUint64(l_int32, l_int32, l_uint64 *) as l_ok
'''  <summary>
''' Notes
''' (1) I found that a simple hash function has no collisions for
''' any of 400 million points with x and y up to 20000.
''' (2) Previously used a much more complicated and slower function
''' mulp = 26544357894361;
''' hash = 104395301;
''' hash += (x  mulp) ^ (hash GTGT 5);
''' hash ^= (hash LTLT 7);
''' hash += (y  mulp) ^ (hash GTGT 7);
''' hash = hash ^ (hash LTLT 11);
''' Such logical gymnastics to get coverage over the 2^64
''' values are not required.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="x">[in] - </param>
'''  <param name="y">[in] - </param>
'''  <param name="phash">[out] - hash value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_hashPtToUint64(
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByRef phash as ULong) as Integer


Dim phashPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.l_hashPtToUint64( x, y, phashPTR)

	Return _Result
End Function

' SRC\utils1.c (654, 1)
' l_hashFloat64ToUint64()
' l_hashFloat64ToUint64(l_int32, l_float64, l_uint64 *) as l_ok
'''  <summary>
''' Notes
''' (1) Simple, fast hash for using dnaHash with 64-bit data
''' (e.g., sets and histograms).
''' (2) The resulting hash is called a "key" in a lookup
''' operation.  The bucket for %val in a dnaHash is simply
''' found by taking the mod of the hash with the number of
''' buckets (which is prime).  What gets stored in the
''' dna in that bucket could depend on use, but for the most
''' flexibility, we store an index into the associated dna.
''' This is all that is required for generating either a hash set
''' or a histogram (an example of a hash map).
''' (3) For example, to generate a histogram, the histogram dna,
''' a histogram of unique values aligned with the histogram dna,
''' and a dnahash hashmap are built.  See l_dnaMakeHistoByHash().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nbuckets">[in] - </param>
'''  <param name="val">[in] - </param>
'''  <param name="phash">[out] - hash value</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_hashFloat64ToUint64(
				ByVal nbuckets as Integer, 
				ByVal val as Double, 
				ByRef phash as ULong) as Integer

	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

Dim phashPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.l_hashFloat64ToUint64( nbuckets, val, phashPTR)

	Return _Result
End Function

' SRC\utils1.c (678, 1)
' findNextLargerPrime()
' findNextLargerPrime(l_int32, l_uint32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="start">[in] - </param>
'''  <param name="pprime">[out] - first prime larger than %start</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function findNextLargerPrime(
				ByVal start as Integer, 
				ByRef pprime as UInteger) as Integer



	Dim _Result as Integer = LeptonicaSharp.Natives.findNextLargerPrime( start, pprime)

	Return _Result
End Function

' SRC\utils1.c (713, 1)
' lept_isPrime()
' lept_isPrime(l_uint64, l_int32 *, l_uint32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - 64-bit unsigned</param>
'''  <param name="pis_prime">[out] - 1 if prime, 0 otherwise</param>
'''  <param name="pfactor">[out][optional] - smallest divisor, or 0 on error or if prime</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lept_isPrime(
				ByVal n as ULong, 
				ByRef pis_prime as Integer, 
				Optional ByRef pfactor as UInteger = Nothing) as Integer

	If IsNothing (n) then Throw New ArgumentNullException  ("n cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_isPrime( n, pis_prime, pfactor)

	Return _Result
End Function

' SRC\utils1.c (764, 1)
' convertIntToGrayCode()
' convertIntToGrayCode(l_uint32) as l_uint32
'''  <summary>
''' Notes
''' (1) Gray code values corresponding to integers differ by
''' only one bit transition between successive integers.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="val">[in] - integer value</param>
'''   <returns>corresponding gray code value</returns>
Public Shared Function convertIntToGrayCode(
				ByVal val as UInteger) as UInteger

	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.convertIntToGrayCode( val)

	Return _Result
End Function

' SRC\utils1.c (777, 1)
' convertGrayCodeToInt()
' convertGrayCodeToInt(l_uint32) as l_uint32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="val">[in] - gray code value</param>
'''   <returns>corresponding integer value</returns>
Public Shared Function convertGrayCodeToInt(
				ByVal val as UInteger) as UInteger

	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.convertGrayCodeToInt( val)

	Return _Result
End Function

' SRC\utils1.c (799, 1)
' getLeptonicaVersion() Return string of version number (e.g., 'leptonica-1.74.2') Notes (1) The caller has responsibility to free the memory.
' getLeptonicaVersion() as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function getLeptonicaVersion() as String



	Dim _Result as String = LeptonicaSharp.Natives.getLeptonicaVersion( )

	Return _Result
End Function

' SRC\utils1.c (946, 1)
' 
' startTimer() as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub startTimer()



	LeptonicaSharp.Natives.startTimer( )

End Sub

' SRC\utils1.c (960, 1)
' 
' stopTimer() as l_float32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function stopTimer() as Single



	Dim _Result as Single = LeptonicaSharp.Natives.stopTimer( )

	Return _Result
End Function

' SRC\utils1.c (977, 1)
' 
' startTimerNested() as L_TIMER
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function startTimerNested() as IntPtr



	Dim _Result as IntPtr = LeptonicaSharp.Natives.startTimerNested( )

	Return _Result
End Function

' SRC\utils1.c (994, 1)
' 
' stopTimerNested(L_TIMER) as l_float32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function stopTimerNested(
				ByRef utime_start as IntPtr) as Single

	If IsNothing (utime_start) then Throw New ArgumentNullException  ("utime_start cannot be Nothing")


	Dim _Result as Single = LeptonicaSharp.Natives.stopTimerNested( utime_start)

	Return _Result
End Function

' SRC\utils1.c (1013, 1)
' 
' l_getCurrentTime(l_int32 *, l_int32 *) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
Public Shared Sub l_getCurrentTime(
				ByRef sec as Object, 
				ByRef usec as Object)

	If IsNothing (sec) then Throw New ArgumentNullException  ("sec cannot be Nothing")
	If IsNothing (usec) then Throw New ArgumentNullException  ("usec cannot be Nothing")


	LeptonicaSharp.Natives.l_getCurrentTime( sec, usec)

End Sub

' SRC\utils1.c (1053, 1)
' startWallTimer()
' startWallTimer() as L_WALLTIMER *
'''  <summary>
''' Notes
''' (1) These measure the wall clock time  elapsed between the two calls
''' L_WALLTIMER timer = startWallTimer();
''' ....
''' fprintf(stderr, "Elapsed time = %f sec\n", stopWallTimer(timer);
''' (2) Note that the timer object is destroyed by stopWallTimer().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>walltimer-ptr</returns>
Public Shared Function startWallTimer() as L_WallTimer



	Dim _Result as IntPtr = LeptonicaSharp.Natives.startWallTimer( )
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_WallTimer(_Result)
End Function

' SRC\utils1.c (1069, 1)
' stopWallTimer()
' stopWallTimer(L_WALLTIMER **) as l_float32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptimer">[in,out] - walltimer-ptr</param>
'''   <returns>time wall time elapsed in seconds</returns>
Public Shared Function stopWallTimer(
				ByRef ptimer as L_WallTimer) as Single


	Dim ptimerPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ptimer) Then ptimerPTR = ptimer.Pointer

	Dim _Result as Single = LeptonicaSharp.Natives.stopWallTimer( ptimerPTR)
	if ptimerPTR <> IntPtr.Zero then ptimer = new L_WallTimer(ptimerPTR)

	Return _Result
End Function

' SRC\utils1.c (1104, 1)
' l_getFormattedDate()
' l_getFormattedDate() as char *
'''  <summary>
''' Notes
''' (1) This is used in pdf, in the form specified in section 3.8.2 of
''' http//partners.adobe.com/public/developer/en/pdf/PDFReference.pdf
''' (2) Contributed by Dave Bryan.  Works on all platforms.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>formatted date string, or NULL on error</returns>
Public Shared Function l_getFormattedDate() as String



	Dim _Result as String = LeptonicaSharp.Natives.l_getFormattedDate( )

	Return _Result
End Function

End Class
