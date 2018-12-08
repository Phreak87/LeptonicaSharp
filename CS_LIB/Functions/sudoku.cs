using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// sudoku.c (181, 1)
		// sudokuReadFile(filename) as int[]
		// sudokuReadFile(const char *) as l_int32 *
		///  <summary>
		/// (1) The file format has:
		/// any number of comment lines beginning with '#'
		/// a set of 9 lines, each having 9 digits (0-9) separated
		/// by a space
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuReadFile/*"/>
		///  <param name="filename">[in] - of formatted sudoku file</param>
		///   <returns>array of 81 numbers, or NULL on error</returns>
		public static int[] sudokuReadFile(
						String filename)
		{
			if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}

			if (File.Exists (filename) == false) {
				throw new ArgumentException ("File is missing");
			};

			int[] _Result = Natives.sudokuReadFile(  filename);

			return _Result;
		}

		// sudoku.c (260, 1)
		// sudokuReadString(str) as int[]
		// sudokuReadString(const char *) as l_int32 *
		///  <summary>
		/// (1) The string is formatted as 81 single digits, each separated
		/// by 81 spaces.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuReadString/*"/>
		///  <param name="str">[in] - of input data</param>
		///   <returns>array of 81 numbers, or NULL on error</returns>
		public static int[] sudokuReadString(
						String str)
		{
			if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}

			int[] _Result = Natives.sudokuReadString(  str);
			return _Result;
		}

		// sudoku.c (301, 1)
		// sudokuCreate(array) as L_Sudoku
		// sudokuCreate(l_int32 *) as L_SUDOKU *
		///  <summary>
		/// (1) The input array has 0 for the unknown values, and 1-9
		/// for the known initial values.  It is generated from
		/// a file using sudokuReadInput(), which checks that the file
		/// data has 81 numbers in 9 rows.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuCreate/*"/>
		///  <param name="array">[in] - of 81 numbers, 9 rows of 9 numbers each</param>
		///   <returns>l_sudoku, or NULL on error</returns>
		public static L_Sudoku sudokuCreate(
						int[] array)
		{
			if (array == null) {throw new ArgumentNullException  ("array cannot be Nothing");}

			IntPtr _Result = Natives.sudokuCreate(  array);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Sudoku(_Result);
		}

		// sudoku.c (337, 1)
		// sudokuDestroy(psud) as Object
		// sudokuDestroy(L_SUDOKU **) as void
		///  <summary>
		/// sudokuDestroy()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuDestroy/*"/>
		///  <param name="psud">[in,out] - to be nulled</param>
		public static void sudokuDestroy(
						ref L_Sudoku psud)
		{
			IntPtr psudPtr = IntPtr.Zero; 	if (psud != null) {psudPtr = psud.Pointer;}
			Natives.sudokuDestroy(ref psudPtr);
			if (psudPtr == IntPtr.Zero) {psud = null;} else { psud = new L_Sudoku(psudPtr); };
		}

		// sudoku.c (371, 1)
		// sudokuSolve(sud) as int
		// sudokuSolve(L_SUDOKU *) as l_int32
		///  <summary>
		/// sudokuSolve()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuSolve/*"/>
		///  <param name="sud">[in] - l_sudoku starting in initial state</param>
		///   <returns>1 on success, 0 on failure to solve note reversal of typical unix returns</returns>
		public static int sudokuSolve(
						L_Sudoku sud)
		{
			if (sud == null) {throw new ArgumentNullException  ("sud cannot be Nothing");}

			int _Result = Natives.sudokuSolve(sud.Pointer);
			return _Result;
		}

		// sudoku.c (562, 1)
		// sudokuTestUniqueness(array, punique) as int
		// sudokuTestUniqueness(l_int32 *, l_int32 *) as l_ok
		///  <summary>
		/// (1) This applies the brute force method to all four 90 degree
		/// rotations.  If there is more than one solution, it is highly
		/// unlikely that all four results will be the same
		/// consequently, if they are the same, the solution is
		/// most likely to be unique.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuTestUniqueness/*"/>
		///  <param name="array">[in] - of 81 numbers, 9 lines of 9 numbers each</param>
		///  <param name="punique">[out] - 1 if unique, 0 if not</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int sudokuTestUniqueness(
						int[] array,
						out int punique)
		{
			if (array == null) {throw new ArgumentNullException  ("array cannot be Nothing");}

			int _Result = Natives.sudokuTestUniqueness(  array, out  punique);
			return _Result;
		}

		// sudoku.c (731, 1)
		// sudokuGenerate(array, seed, minelems, maxtries) as L_Sudoku
		// sudokuGenerate(l_int32 *, l_int32, l_int32, l_int32) as L_SUDOKU *
		///  <summary>
		/// (1) This is a brute force generator.  It starts with a completed
		/// sudoku solution and, by removing elements (setting them to 0),
		/// generates a valid (unique) sudoku initial condition.<para/>
		///
		/// (2) The process stops when either %minelems, the minimum
		/// number of non-zero elements, is reached, or when the
		/// number of attempts to remove the next element exceeds %maxtries.<para/>
		///
		/// (3) No sudoku is known with less than 17 nonzero elements.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuGenerate/*"/>
		///  <param name="array">[in] - of 81 numbers, 9 rows of 9 numbers each</param>
		///  <param name="seed">[in] - random number</param>
		///  <param name="minelems">[in] - min non-zero elements allowed smaller or equal 80</param>
		///  <param name="maxtries">[in] - max tries to remove a number and get a valid sudoku</param>
		///   <returns>l_sudoku, or NULL on error</returns>
		public static L_Sudoku sudokuGenerate(
						int[] array,
						int seed,
						int minelems,
						int maxtries)
		{
			if (array == null) {throw new ArgumentNullException  ("array cannot be Nothing");}

			IntPtr _Result = Natives.sudokuGenerate(  array,   seed,   minelems,   maxtries);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Sudoku(_Result);
		}

		// sudoku.c (854, 1)
		// sudokuOutput(sud, arraytype) as int
		// sudokuOutput(L_SUDOKU *, l_int32) as l_int32
		///  <summary>
		/// (1) Prints either the initial array or the current state
		/// of the solution.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuOutput/*"/>
		///  <param name="sud">[in] - l_sudoku at any stage</param>
		///  <param name="arraytype">[in] - L_SUDOKU_INIT, L_SUDOKU_STATE</param>
		///   <returns>void</returns>
		public static int sudokuOutput(
						L_Sudoku sud,
						int arraytype)
		{
			if (sud == null) {throw new ArgumentNullException  ("sud cannot be Nothing");}

			int _Result = Natives.sudokuOutput(sud.Pointer,   arraytype);
			return _Result;
		}


	}
}
