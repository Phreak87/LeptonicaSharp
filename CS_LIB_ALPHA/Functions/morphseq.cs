using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// morphseq.c (133, 1)
// pixMorphSequence(pixs, sequence, dispsep) as Pix
// pixMorphSequence(PIX *, const char *, l_int32) as PIX *
///  <summary>
/// (1) This does rasterop morphology on binary images.<para/>
/// 
/// (2) This runs a pipeline of operations no branching is allowed.<para/>
/// 
/// (3) This only uses brick Sels, which are created on the fly.
/// In the future this will be generalized to extract Sels from
/// a Sela by name.<para/>
/// 
/// (4) A new image is always produced the input image is not changed.<para/>
/// 
/// (5) This contains an interpreter, allowing sequences to be
/// generated and run.<para/>
/// 
/// (6) The format of the sequence string is defined below.<para/>
/// 
/// (7) In addition to morphological operations, rank order reduction
/// and replicated expansion allow operations to take place
/// downscaled by a power of 2.<para/>
/// 
/// (8) Intermediate results can optionally be displayed.<para/>
/// 
/// (9) Thanks to Dar-Shyang Lee, who had the idea for this and
/// built the first implementation.<para/>
/// 
/// (10) The sequence string is formatted as follows:
/// ~ An arbitrary number of operations,  each separated
/// by a '+' character.  White space is ignored.
/// ~ Each operation begins with a case-independent character
/// specifying the operation:
/// d or D  (dilation)
/// e or E  (erosion)
/// o or O  (opening)
/// c or C  (closing)
/// r or R  (rank binary reduction)
/// x or X  (replicative binary expansion)
/// b or B  (add a border of 0 pixels of this size)
/// ~ The args to the morphological operations are bricks of hits,
/// and are formatted as a.b, where a and b are horizontal and
/// vertical dimensions, rsp.
/// ~ The args to the reduction are a sequence of up to 4 integers,
/// each from 1 to 4.
/// ~ The arg to the expansion is a power of two, in the set
/// {2, 4, 8, 16}.<para/>
/// 
/// (11) An example valid sequence is:
/// "b32 + o1.3 + C3.1 + r23 + e2.2 + D3.2 + X4"
/// In this example, the following operation sequence is carried out:
/// b32: Add a 32 pixel border around the input image
/// o1.3: Opening with vert sel of length 3 (e.g., 1 x 3)
/// C3.1: Closing with horiz sel of length 3  (e.g., 3 x 1)
/// r23: Two successive 2x2 reductions with rank 2 in the first
/// and rank 3 in the second.  The result is a 4x reduced pix.
/// e2.2: Erosion with a 2x2 sel (origin will be at x,y: 0,0)
/// d3.2: Dilation with a 3x2 sel (origin will be at x,y: 1,0)
/// X4: 4x replicative expansion, back to original resolution<para/>
/// 
/// (12) The safe closing is used.  However, if you implement a
/// closing as separable dilations followed by separable erosions,
/// it will not be safe.  For that situation, you need to add
/// a sufficiently large border as the first operation in
/// the sequence.  This will be removed automatically at the
/// end.  There are two cautions:
/// ~ When computing what is sufficient, remember that if
/// reductions are carried out, the border is also reduced.
/// ~ The border is removed at the end, so if a border is
/// added at the beginning, the result must be at the
/// same resolution as the input!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMorphSequence/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixMorphSequence(
				 Pix pixs, 
				 String sequence, 
				 int dispsep){

	IntPtr _Result = Natives.pixMorphSequence(pixs.Pointer,   sequence,   dispsep);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphseq.c (300, 1)
// pixMorphCompSequence(pixs, sequence, dispsep) as Pix
// pixMorphCompSequence(PIX *, const char *, l_int32) as PIX *
///  <summary>
/// (1) This does rasterop morphology on binary images, using composite
/// operations for extra speed on large Sels.<para/>
/// 
/// (2) Safe closing is used atomically.  However, if you implement a
/// closing as a sequence with a dilation followed by an
/// erosion, it will not be safe, and to ensure that you have
/// no boundary effects you must add a border in advance and
/// remove it at the end.<para/>
/// 
/// (3) For other usage details, see the notes for pixMorphSequence().<para/>
/// 
/// (4) The sequence string is formatted as follows:
/// ~ An arbitrary number of operations,  each separated
/// by a '+' character.  White space is ignored.
/// ~ Each operation begins with a case-independent character
/// specifying the operation:
/// d or D  (dilation)
/// e or E  (erosion)
/// o or O  (opening)
/// c or C  (closing)
/// r or R  (rank binary reduction)
/// x or X  (replicative binary expansion)
/// b or B  (add a border of 0 pixels of this size)
/// ~ The args to the morphological operations are bricks of hits,
/// and are formatted as a.b, where a and b are horizontal and
/// vertical dimensions, rsp.
/// ~ The args to the reduction are a sequence of up to 4 integers,
/// each from 1 to 4.
/// ~ The arg to the expansion is a power of two, in the set
/// {2, 4, 8, 16}.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMorphCompSequence/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixMorphCompSequence(
				 Pix pixs, 
				 String sequence, 
				 int dispsep){

	IntPtr _Result = Natives.pixMorphCompSequence(pixs.Pointer,   sequence,   dispsep);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphseq.c (449, 1)
// pixMorphSequenceDwa(pixs, sequence, dispsep) as Pix
// pixMorphSequenceDwa(PIX *, const char *, l_int32) as PIX *
///  <summary>
/// (1) This does dwa morphology on binary images.<para/>
/// 
/// (2) This runs a pipeline of operations no branching is allowed.<para/>
/// 
/// (3) This only uses brick Sels that have been pre-compiled with
/// dwa code.<para/>
/// 
/// (4) A new image is always produced the input image is not changed.<para/>
/// 
/// (5) This contains an interpreter, allowing sequences to be
/// generated and run.<para/>
/// 
/// (6) See pixMorphSequence() for further information about usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMorphSequenceDwa/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixMorphSequenceDwa(
				 Pix pixs, 
				 String sequence, 
				 int dispsep){

	IntPtr _Result = Natives.pixMorphSequenceDwa(pixs.Pointer,   sequence,   dispsep);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphseq.c (598, 1)
// pixMorphCompSequenceDwa(pixs, sequence, dispsep) as Pix
// pixMorphCompSequenceDwa(PIX *, const char *, l_int32) as PIX *
///  <summary>
/// (1) This does dwa morphology on binary images, using brick Sels.<para/>
/// 
/// (2) This runs a pipeline of operations no branching is allowed.<para/>
/// 
/// (3) It implements all brick Sels that have dimensions up to 63
/// on each side, using a composite (linear + comb) when useful.<para/>
/// 
/// (4) A new image is always produced the input image is not changed.<para/>
/// 
/// (5) This contains an interpreter, allowing sequences to be
/// generated and run.<para/>
/// 
/// (6) See pixMorphSequence() for further information about usage.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMorphCompSequenceDwa/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixMorphCompSequenceDwa(
				 Pix pixs, 
				 String sequence, 
				 int dispsep){

	IntPtr _Result = Natives.pixMorphCompSequenceDwa(pixs.Pointer,   sequence,   dispsep);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphseq.c (737, 1)
// morphSequenceVerify(sa) as int
// morphSequenceVerify(SARRAY *) as l_int32
///  <summary>
/// (1) This does verification of valid binary morphological
/// operation sequences.<para/>
/// 
/// (2) See pixMorphSequence() for notes on valid operations
/// in the sequence.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/morphSequenceVerify/*"/>
///  <param name="sa">[in] - string array of operation sequence</param>
///   <returns>TRUE if valid FALSE otherwise or on error</returns>
public static int morphSequenceVerify(
				 Sarray sa){

	int _Result = Natives.morphSequenceVerify(sa.Pointer);
	



	return _Result;
}

// morphseq.c (912, 1)
// pixGrayMorphSequence(pixs, sequence, dispsep, dispy) as Pix
// pixGrayMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This works on 8 bpp grayscale images.<para/>
/// 
/// (2) This runs a pipeline of operations no branching is allowed.<para/>
/// 
/// (3) This only uses brick SELs.<para/>
/// 
/// (4) A new image is always produced the input image is not changed.<para/>
/// 
/// (5) This contains an interpreter, allowing sequences to be
/// generated and run.<para/>
/// 
/// (6) The format of the sequence string is defined below.<para/>
/// 
/// (7) In addition to morphological operations, the composite
/// morph/subtract tophat can be performed.<para/>
/// 
/// (8) Sel sizes (width, height) must each be odd numbers.<para/>
/// 
/// (9) Intermediate results can optionally be displayed<para/>
/// 
/// (10) The sequence string is formatted as follows:
/// ~ An arbitrary number of operations,  each separated
/// by a '+' character.  White space is ignored.
/// ~ Each operation begins with a case-independent character
/// specifying the operation:
/// d or D  (dilation)
/// e or E  (erosion)
/// o or O  (opening)
/// c or C  (closing)
/// t or T  (tophat)
/// ~ The args to the morphological operations are bricks of hits,
/// and are formatted as a.b, where a and b are horizontal and
/// vertical dimensions, rsp. (each must be an odd number)
/// ~ The args to the tophat are w or W (for white tophat)
/// or b or B (for black tophat), followed by a.b as for
/// the dilation, erosion, opening and closing.
/// Example valid sequences are:
/// "c5.3 + o7.5"
/// "c9.9 + tw9.9"
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGrayMorphSequence/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///  <param name="dispy">[in] - if dispsep  is greater  0, this gives the y-value of the UL corner for display otherwise it is ignored</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixGrayMorphSequence(
				 Pix pixs, 
				 String sequence, 
				 int dispsep, 
				 int dispy){

	IntPtr _Result = Natives.pixGrayMorphSequence(pixs.Pointer,   sequence,   dispsep,   dispy);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// morphseq.c (1117, 1)
// pixColorMorphSequence(pixs, sequence, dispsep, dispy) as Pix
// pixColorMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
///  <summary>
/// (1) This works on 32 bpp rgb images.<para/>
/// 
/// (2) Each component is processed separately.<para/>
/// 
/// (3) This runs a pipeline of operations no branching is allowed.<para/>
/// 
/// (4) This only uses brick SELs.<para/>
/// 
/// (5) A new image is always produced the input image is not changed.<para/>
/// 
/// (6) This contains an interpreter, allowing sequences to be
/// generated and run.<para/>
/// 
/// (7) Sel sizes (width, height) must each be odd numbers.<para/>
/// 
/// (8) The format of the sequence string is defined below.<para/>
/// 
/// (9) Intermediate results can optionally be displayed.<para/>
/// 
/// (10) The sequence string is formatted as follows:
/// ~ An arbitrary number of operations,  each separated
/// by a '+' character.  White space is ignored.
/// ~ Each operation begins with a case-independent character
/// specifying the operation:
/// d or D  (dilation)
/// e or E  (erosion)
/// o or O  (opening)
/// c or C  (closing)
/// ~ The args to the morphological operations are bricks of hits,
/// and are formatted as a.b, where a and b are horizontal and
/// vertical dimensions, rsp. (each must be an odd number)
/// Example valid sequences are:
/// "c5.3 + o7.5"
/// "D9.1"
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixColorMorphSequence/*"/>
///  <param name="pixs">[in] - </param>
///  <param name="sequence">[in] - string specifying sequence</param>
///  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is smaller 0: pdf output abs(dispsep) is used for naming</param>
///  <param name="dispy">[in] - if dispsep  is greater  0, this gives the y-value of the UL corner for display otherwise it is ignored</param>
///   <returns>pixd, or NULL on error</returns>
public static Pix pixColorMorphSequence(
				 Pix pixs, 
				 String sequence, 
				 int dispsep, 
				 int dispy){

	IntPtr _Result = Natives.pixColorMorphSequence(pixs.Pointer,   sequence,   dispsep,   dispy);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}


}
}
