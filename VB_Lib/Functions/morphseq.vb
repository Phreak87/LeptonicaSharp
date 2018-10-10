Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\morphseq.c (133, 1)
' pixMorphSequence(pixs, sequence, dispsep) as Pix
' pixMorphSequence(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does rasterop morphology on binary images.<para/>
''' (2) This runs a pipeline of operations no branching is allowed.<para/>
''' (3) This only uses brick Sels, which are created on the fly.<para/>
''' In the future this will be generalized to extract Sels from<para/>
''' a Sela by name.<para/>
''' (4) A new image is always produced the input image is not changed.<para/>
''' (5) This contains an interpreter, allowing sequences to be<para/>
''' generated and run.<para/>
''' (6) The format of the sequence string is defined below.<para/>
''' (7) In addition to morphological operations, rank order reduction<para/>
''' and replicated expansion allow operations to take place<para/>
''' downscaled by a power of 2.<para/>
''' (8) Intermediate results can optionally be displayed.<para/>
''' (9) Thanks to Dar-Shyang Lee, who had the idea for this and<para/>
''' built the first implementation.<para/>
''' (10) The sequence string is formatted as follows:<para/>
''' ~ An arbitrary number of operations,  each separated<para/>
''' by a '+' character.  White space is ignored.<para/>
''' ~ Each operation begins with a case-independent character<para/>
''' specifying the operation:<para/>
''' d or D  (dilation)<para/>
''' e or E  (erosion)<para/>
''' o or O  (opening)<para/>
''' c or C  (closing)<para/>
''' r or R  (rank binary reduction)<para/>
''' x or X  (replicative binary expansion)<para/>
''' b or B  (add a border of 0 pixels of this size)<para/>
''' ~ The args to the morphological operations are bricks of hits,<para/>
''' and are formatted as a.b, where a and b are horizontal and<para/>
''' vertical dimensions, rsp.<para/>
''' ~ The args to the reduction are a sequence of up to 4 integers,<para/>
''' each from 1 to 4.<para/>
''' ~ The arg to the expansion is a power of two, in the set<para/>
''' {2, 4, 8, 16}.<para/>
''' (11) An example valid sequence is:<para/>
''' "b32 + o1.3 + C3.1 + r23 + e2.2 + D3.2 + X4"<para/>
''' In this example, the following operation sequence is carried out:<para/>
''' b32: Add a 32 pixel border around the input image<para/>
''' o1.3: Opening with vert sel of length 3 (e.g., 1 x 3)<para/>
''' C3.1: Closing with horiz sel of length 3  (e.g., 3 x 1)<para/>
''' r23: Two successive 2x2 reductions with rank 2 in the first<para/>
''' and rank 3 in the second.  The result is a 4x reduced pix.<para/>
''' e2.2: Erosion with a 2x2 sel (origin will be at x,y: 0,0)<para/>
''' d3.2: Dilation with a 3x2 sel (origin will be at x,y: 1,0)<para/>
''' X4: 4x replicative expansion, back to original resolution<para/>
''' (12) The safe closing is used.  However, if you implement a<para/>
''' closing as separable dilations followed by separable erosions,<para/>
''' it will not be safe.  For that situation, you need to add<para/>
''' a sufficiently large border as the first operation in<para/>
''' the sequence.  This will be removed automatically at the<para/>
''' end.  There are two cautions:<para/>
''' ~ When computing what is sufficient, remember that if<para/>
''' reductions are carried out, the border is also reduced.<para/>
''' ~ The border is removed at the end, so if a border is<para/>
''' added at the beginning, the result must be at the<para/>
''' same resolution as the input!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
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
' pixMorphCompSequence(pixs, sequence, dispsep) as Pix
' pixMorphCompSequence(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does rasterop morphology on binary images, using composite<para/>
''' operations for extra speed on large Sels.<para/>
''' (2) Safe closing is used atomically.  However, if you implement a<para/>
''' closing as a sequence with a dilation followed by an<para/>
''' erosion, it will not be safe, and to ensure that you have<para/>
''' no boundary effects you must add a border in advance and<para/>
''' remove it at the end.<para/>
''' (3) For other usage details, see the notes for pixMorphSequence().<para/>
''' (4) The sequence string is formatted as follows:<para/>
''' ~ An arbitrary number of operations,  each separated<para/>
''' by a '+' character.  White space is ignored.<para/>
''' ~ Each operation begins with a case-independent character<para/>
''' specifying the operation:<para/>
''' d or D  (dilation)<para/>
''' e or E  (erosion)<para/>
''' o or O  (opening)<para/>
''' c or C  (closing)<para/>
''' r or R  (rank binary reduction)<para/>
''' x or X  (replicative binary expansion)<para/>
''' b or B  (add a border of 0 pixels of this size)<para/>
''' ~ The args to the morphological operations are bricks of hits,<para/>
''' and are formatted as a.b, where a and b are horizontal and<para/>
''' vertical dimensions, rsp.<para/>
''' ~ The args to the reduction are a sequence of up to 4 integers,<para/>
''' each from 1 to 4.<para/>
''' ~ The arg to the expansion is a power of two, in the set<para/>
''' {2, 4, 8, 16}.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
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
' pixMorphSequenceDwa(pixs, sequence, dispsep) as Pix
' pixMorphSequenceDwa(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does dwa morphology on binary images.<para/>
''' (2) This runs a pipeline of operations no branching is allowed.<para/>
''' (3) This only uses brick Sels that have been pre-compiled with<para/>
''' dwa code.<para/>
''' (4) A new image is always produced the input image is not changed.<para/>
''' (5) This contains an interpreter, allowing sequences to be<para/>
''' generated and run.<para/>
''' (6) See pixMorphSequence() for further information about usage.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
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
' pixMorphCompSequenceDwa(pixs, sequence, dispsep) as Pix
' pixMorphCompSequenceDwa(PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does dwa morphology on binary images, using brick Sels.<para/>
''' (2) This runs a pipeline of operations no branching is allowed.<para/>
''' (3) It implements all brick Sels that have dimensions up to 63<para/>
''' on each side, using a composite (linear + comb) when useful.<para/>
''' (4) A new image is always produced the input image is not changed.<para/>
''' (5) This contains an interpreter, allowing sequences to be<para/>
''' generated and run.<para/>
''' (6) See pixMorphSequence() for further information about usage.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
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
' morphSequenceVerify(sa) as Integer
' morphSequenceVerify(SARRAY *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This does verification of valid binary morphological<para/>
''' operation sequences.<para/>
''' (2) See pixMorphSequence() for notes on valid operations<para/>
''' in the sequence.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of operation sequence</param>
'''   <returns>TRUE if valid FALSE otherwise or on error</returns>
Public Shared Function morphSequenceVerify(
				 ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.morphSequenceVerify( sa.Pointer)

	Return _Result
End Function

' SRC\morphseq.c (912, 1)
' pixGrayMorphSequence(pixs, sequence, dispsep, dispy) as Pix
' pixGrayMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This works on 8 bpp grayscale images.<para/>
''' (2) This runs a pipeline of operations no branching is allowed.<para/>
''' (3) This only uses brick SELs.<para/>
''' (4) A new image is always produced the input image is not changed.<para/>
''' (5) This contains an interpreter, allowing sequences to be<para/>
''' generated and run.<para/>
''' (6) The format of the sequence string is defined below.<para/>
''' (7) In addition to morphological operations, the composite<para/>
''' morph/subtract tophat can be performed.<para/>
''' (8) Sel sizes (width, height) must each be odd numbers.<para/>
''' (9) Intermediate results can optionally be displayed<para/>
''' (10) The sequence string is formatted as follows:<para/>
''' ~ An arbitrary number of operations,  each separated<para/>
''' by a '+' character.  White space is ignored.<para/>
''' ~ Each operation begins with a case-independent character<para/>
''' specifying the operation:<para/>
''' d or D  (dilation)<para/>
''' e or E  (erosion)<para/>
''' o or O  (opening)<para/>
''' c or C  (closing)<para/>
''' t or T  (tophat)<para/>
''' ~ The args to the morphological operations are bricks of hits,<para/>
''' and are formatted as a.b, where a and b are horizontal and<para/>
''' vertical dimensions, rsp. (each must be an odd number)<para/>
''' ~ The args to the tophat are w or W (for white tophat)<para/>
''' or b or B (for black tophat), followed by a.b as for<para/>
''' the dilation, erosion, opening and closing.<para/>
''' Example valid sequences are:<para/>
''' "c5.3 + o7.5"<para/>
''' "c9.9 + tw9.9"<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
'''  <param name="dispy">[in] - if dispsep  is greater  0, this gives the y-value of the UL corner for display otherwise it is ignored</param>
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
' pixColorMorphSequence(pixs, sequence, dispsep, dispy) as Pix
' pixColorMorphSequence(PIX *, const char *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This works on 32 bpp rgb images.<para/>
''' (2) Each component is processed separately.<para/>
''' (3) This runs a pipeline of operations no branching is allowed.<para/>
''' (4) This only uses brick SELs.<para/>
''' (5) A new image is always produced the input image is not changed.<para/>
''' (6) This contains an interpreter, allowing sequences to be<para/>
''' generated and run.<para/>
''' (7) Sel sizes (width, height) must each be odd numbers.<para/>
''' (8) The format of the sequence string is defined below.<para/>
''' (9) Intermediate results can optionally be displayed.<para/>
''' (10) The sequence string is formatted as follows:<para/>
''' ~ An arbitrary number of operations,  each separated<para/>
''' by a '+' character.  White space is ignored.<para/>
''' ~ Each operation begins with a case-independent character<para/>
''' specifying the operation:<para/>
''' d or D  (dilation)<para/>
''' e or E  (erosion)<para/>
''' o or O  (opening)<para/>
''' c or C  (closing)<para/>
''' ~ The args to the morphological operations are bricks of hits,<para/>
''' and are formatted as a.b, where a and b are horizontal and<para/>
''' vertical dimensions, rsp. (each must be an odd number)<para/>
''' Example valid sequences are:<para/>
''' "c5.3 + o7.5"<para/>
''' "D9.1"<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="dispsep">[in] - controls debug display of each result in the sequence: 0: no output  is greater  0: gives horizontal separation in pixels between successive displays  is lower  0: pdf output abs(dispsep) is used for naming</param>
'''  <param name="dispy">[in] - if dispsep  is greater  0, this gives the y-value of the UL corner for display otherwise it is ignored</param>
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
