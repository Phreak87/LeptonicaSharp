Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\morphseq.c (133, 1)
' pixMorphSequence()
' pixMorphSequence(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does rasterop morphology on binary images.
''' (2) This runs a pipeline of operations; no branching is allowed.
''' (3) This only uses brick Sels, which are created on the fly.
''' In the future this will be generalized to extract Sels from
''' a Sela by name.
''' (4) A new image is always produced; the input image is not changed.
''' (5) This contains an interpreter, allowing sequences to be
''' generated and run.
''' (6) The format of the sequence string is defined below.
''' (7) In addition to morphological operations, rank order reduction
''' and replicated expansion allow operations to take place
''' downscaled by a power of 2.
''' (8) Intermediate results can optionally be displayed.
''' (9) Thanks to Dar-Shyang Lee, who had the idea for this and
''' built the first implementation.
''' (10) The sequence string is formatted as follows
''' ~ An arbitrary number of operations,  each separated
''' by a '+' character.  White space is ignored.
''' ~ Each operation begins with a case-independent character
''' specifying the operation
''' d or D  (dilation)
''' e or E  (erosion)
''' o or O  (opening)
''' c or C  (closing)
''' r or R  (rank binary reduction)
''' x or X  (replicative binary expansion)
''' b or B  (add a border of 0 pixels of this size)
''' ~ The args to the morphological operations are bricks of hits,
''' and are formatted as a.b, where a and b are horizontal and
''' vertical dimensions, rsp.
''' ~ The args to the reduction are a sequence of up to 4 integers,
''' each from 1 to 4.
''' ~ The arg to the expansion is a power of two, in the set
''' {2, 4, 8, 16}.
''' (11) An example valid sequence is
''' "b32 + o1.3 + C3.1 + r23 + e2.2 + D3.2 + X4"
''' In this example, the following operation sequence is carried out
''' b32 Add a 32 pixel border around the input image
''' o1.3 Opening with vert sel of length 3 (e.g., 1 x 3)
''' C3.1 Closing with horiz sel of length 3  (e.g., 3 x 1)
''' r23 Two successive 2x2 reductions with rank 2 in the first
''' and rank 3 in the second.  The result is a 4x reduced pix.
''' e2.2 Erosion with a 2x2 sel (origin will be at x,y 0,0)
''' d3.2 Dilation with a 3x2 sel (origin will be at x,y 1,0)
''' X4 4x replicative expansion, back to original resolution
''' (12) The safe closing is used.  However, if you implement a
''' closing as separable dilations followed by separable erosions,
''' it will not be safe.  For that situation, you need to add
''' a sufficiently large border as the first operation in
''' the sequence.  This will be removed automatically at the
''' end.  There are two cautions
''' ~ When computing what is sufficient, remember that if
''' reductions are carried out, the border is also reduced.
''' ~ The border is removed at the end, so if a border is
''' added at the beginning, the result must be at the
''' same resolution as the input!
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphSequence(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphSequence( pixs.Pointer, sequence, dispsep)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphseq.c (300, 1)
' pixMorphCompSequence()
' pixMorphCompSequence(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does rasterop morphology on binary images, using composite
''' operations for extra speed on large Sels.
''' (2) Safe closing is used atomically.  However, if you implement a
''' closing as a sequence with a dilation followed by an
''' erosion, it will not be safe, and to ensure that you have
''' no boundary effects you must add a border in advance and
''' remove it at the end.
''' (3) For other usage details, see the notes for pixMorphSequence().
''' (4) The sequence string is formatted as follows
''' ~ An arbitrary number of operations,  each separated
''' by a '+' character.  White space is ignored.
''' ~ Each operation begins with a case-independent character
''' specifying the operation
''' d or D  (dilation)
''' e or E  (erosion)
''' o or O  (opening)
''' c or C  (closing)
''' r or R  (rank binary reduction)
''' x or X  (replicative binary expansion)
''' b or B  (add a border of 0 pixels of this size)
''' ~ The args to the morphological operations are bricks of hits,
''' and are formatted as a.b, where a and b are horizontal and
''' vertical dimensions, rsp.
''' ~ The args to the reduction are a sequence of up to 4 integers,
''' each from 1 to 4.
''' ~ The arg to the expansion is a power of two, in the set
''' {2, 4, 8, 16}.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphCompSequence(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphCompSequence( pixs.Pointer, sequence, dispsep)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphseq.c (449, 1)
' pixMorphSequenceDwa()
' pixMorphSequenceDwa(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does dwa morphology on binary images.
''' (2) This runs a pipeline of operations; no branching is allowed.
''' (3) This only uses brick Sels that have been pre-compiled with
''' dwa code.
''' (4) A new image is always produced; the input image is not changed.
''' (5) This contains an interpreter, allowing sequences to be
''' generated and run.
''' (6) See pixMorphSequence() for further information about usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphSequenceDwa(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphSequenceDwa( pixs.Pointer, sequence, dispsep)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphseq.c (598, 1)
' pixMorphCompSequenceDwa()
' pixMorphCompSequenceDwa(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This does dwa morphology on binary images, using brick Sels.
''' (2) This runs a pipeline of operations; no branching is allowed.
''' (3) It implements all brick Sels that have dimensions up to 63
''' on each side, using a composite (linear + comb) when useful.
''' (4) A new image is always produced; the input image is not changed.
''' (5) This contains an interpreter, allowing sequences to be
''' generated and run.
''' (6) See pixMorphSequence() for further information about usage.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphCompSequenceDwa(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphCompSequenceDwa( pixs.Pointer, sequence, dispsep)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphseq.c (737, 1)
' morphSequenceVerify()
' morphSequenceVerify(SARRAY *) as l_int32
'''  <summary>
''' Notes
''' (1) This does verification of valid binary morphological
''' operation sequences.
''' (2) See pixMorphSequence() for notes on valid operations
''' in the sequence.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of operation sequence</param>
'''   <returns>TRUE if valid; FALSE otherwise or on error</returns>
Public Shared Function morphSequenceVerify(
				ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.morphSequenceVerify( sa.Pointer)

	Return _Result
End Function

' SRC\morphseq.c (912, 1)
' pixGrayMorphSequence()
' pixGrayMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This works on 8 bpp grayscale images.
''' (2) This runs a pipeline of operations; no branching is allowed.
''' (3) This only uses brick SELs.
''' (4) A new image is always produced; the input image is not changed.
''' (5) This contains an interpreter, allowing sequences to be
''' generated and run.
''' (6) The format of the sequence string is defined below.
''' (7) In addition to morphological operations, the composite
''' morph/subtract tophat can be performed.
''' (8) Sel sizes (width, height) must each be odd numbers.
''' (9) Intermediate results can optionally be displayed
''' (10) The sequence string is formatted as follows
''' ~ An arbitrary number of operations,  each separated
''' by a '+' character.  White space is ignored.
''' ~ Each operation begins with a case-independent character
''' specifying the operation
''' d or D  (dilation)
''' e or E  (erosion)
''' o or O  (opening)
''' c or C  (closing)
''' t or T  (tophat)
''' ~ The args to the morphological operations are bricks of hits,
''' and are formatted as a.b, where a and b are horizontal and
''' vertical dimensions, rsp. (each must be an odd number)
''' ~ The args to the tophat are w or W (for white tophat)
''' or b or B (for black tophat), followed by a.b as for
''' the dilation, erosion, opening and closing.
''' Example valid sequences are
''' "c5.3 + o7.5"
''' "c9.9 + tw9.9"
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''  <param name="dispy">[in] - if dispsep GT 0, this gives the y-value of the UL corner for display; otherwise it is ignored</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixGrayMorphSequence(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer, 
				ByVal dispy as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGrayMorphSequence( pixs.Pointer, sequence, dispsep, dispy)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphseq.c (1117, 1)
' pixColorMorphSequence()
' pixColorMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) This works on 32 bpp rgb images.
''' (2) Each component is processed separately.
''' (3) This runs a pipeline of operations; no branching is allowed.
''' (4) This only uses brick SELs.
''' (5) A new image is always produced; the input image is not changed.
''' (6) This contains an interpreter, allowing sequences to be
''' generated and run.
''' (7) Sel sizes (width, height) must each be odd numbers.
''' (8) The format of the sequence string is defined below.
''' (9) Intermediate results can optionally be displayed.
''' (10) The sequence string is formatted as follows
''' ~ An arbitrary number of operations,  each separated
''' by a '+' character.  White space is ignored.
''' ~ Each operation begins with a case-independent character
''' specifying the operation
''' d or D  (dilation)
''' e or E  (erosion)
''' o or O  (opening)
''' c or C  (closing)
''' ~ The args to the morphological operations are bricks of hits,
''' and are formatted as a.b, where a and b are horizontal and
''' vertical dimensions, rsp. (each must be an odd number)
''' Example valid sequences are
''' "c5.3 + o7.5"
''' "D9.1"
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence 0 no output GT 0 gives horizontal separation in pixels between successive displays LT 0 pdf output; abs(dispsep) is used for naming</param>
'''  <param name="dispy">[in] - if dispsep GT 0, this gives the y-value of the UL corner for display; otherwise it is ignored</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixColorMorphSequence(
				ByVal pixs as Pix, 
				ByVal sequence as String, 
				ByVal dispsep as Integer, 
				ByVal dispy as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixColorMorphSequence( pixs.Pointer, sequence, dispsep, dispy)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
