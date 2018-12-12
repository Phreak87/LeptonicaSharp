Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' finditalic.c (110, 1)
' pixItalicWords(pixs, boxaw, pixw, pboxa, debugflag) as Integer
' pixItalicWords(PIX *, BOXA *, PIX *, BOXA **, l_int32) as l_ok
'''  <summary>
''' (1) You can input the bounding boxes for the words in one of
'''two forms: as bounding boxes (%boxaw) or as a word mask with
'''the word bounding boxes filled (%pixw).  For example,
'''to compute %pixw, you can use pixWordMaskByDilation().<para/>
'''
'''(2) Alternatively, you can set both of these inputs to NULL,
'''in which case the word mask is generated here.  This is
'''done by dilating and closing the input image to connect
'''letters within a word, while leaving the words separated.
'''The parameters are chosen under the assumption that the
'''input is 10 to 12 pt text, scanned at about 300 ppi.<para/>
'''
'''(3) sel_ital1 and sel_ital2 detect the right edges that are
'''nearly vertical, at approximately the angle of italic
'''strokes.  We use the right edge to avoid getting seeds
'''from lower-case 'y'.  The typical italic slant has a smaller
'''angle with the vertical than the 'W', so in most cases we
'''will not trigger on the slanted lines in the 'W'.<para/>
'''
'''(4) Note that sel_ital2 is shorter than sel_ital1.  It is
'''more appropriate for a typical font scanned at 200 ppi.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixItalicWords/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="boxaw">[in][optional] - word bounding boxes can be NULL</param>
'''  <param name="pixw">[in][optional] - word box mask can be NULL</param>
'''  <param name="pboxa">[out] - boxa of italic words</param>
'''  <param name="debugflag">[in] - 1 for debug output 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixItalicWords(
				ByVal pixs as Pix, 
				ByVal boxaw as Boxa, 
				ByVal pixw as Pix, 
				<Out()>  ByRef pboxa as Boxa, 
				ByVal debugflag as Integer) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim boxawPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(boxaw) Then boxawPtr = boxaw.Pointer
	Dim pixwPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixw) Then pixwPtr = pixw.Pointer
	Dim pboxaPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixItalicWords(pixs.Pointer, boxawPtr, pixwPtr, pboxaPtr,   debugflag)
	
	if pboxaPtr = IntPtr.Zero then pboxa = Nothing else pboxa = new Boxa(pboxaPtr)
	return _Result
End Function

End Class


