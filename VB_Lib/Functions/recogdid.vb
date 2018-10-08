Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\recogdid.c (215, 1)
' recogDecode(recog, pixs, nlevels, ppixdb) as Boxa
' recogDecode(L_RECOG *, PIX *, l_int32, PIX **) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input pixs has been filtered so that it is likely to be<para/>
''' composed of more than one touching character.  Specifically,<para/>
''' its height can only slightly exceed that of the tallest<para/>
''' unscaled template, the width is somewhat larger than the<para/>
''' width of the widest unscaled template, and the w/h aspect ratio<para/>
''' is bounded by max_wh_ratio.<para/>
''' (2) This uses the DID mechanism with labeled templates to<para/>
''' segment the input %pixs.  The resulting segmentation is<para/>
''' returned.  (It is given by did- is greater boxa).<para/>
''' (3) In debug mode, the Viterbi path is rescored based on all<para/>
''' the templates.  In non-debug mode, the same procedure is<para/>
''' carried out by recogIdentifyPix() on the result of the<para/>
''' segmentation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - with LUT's pre-computed</param>
'''  <param name="pixs">[in] - typically of multiple touching characters, 1 bpp</param>
'''  <param name="nlevels">[in] - of templates 2 for now</param>
'''  <param name="ppixdb">[out][optional] - debug result can be null</param>
'''   <returns>boxa  segmentation of pixs into characters, or NULL on error</returns>
Public Shared Function recogDecode(
				 ByVal recog as L_Recog, 
				 ByVal pixs as Pix, 
				 ByVal nlevels as Integer, 
				<Out()> ByRef ppixdb as Pix) as Boxa

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



Dim ppixdbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixdb) Then ppixdbPTR = ppixdb.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogDecode( recog.Pointer, pixs.Pointer, nlevels, ppixdbPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixdbPTR <> IntPtr.Zero then ppixdb = new Pix(ppixdbPTR)

	Return  new Boxa(_Result)
End Function

' SRC\recogdid.c (747, 1)
' recogCreateDid(recog, pixs) as Integer
' recogCreateDid(L_RECOG *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="pixs">[in] - of 1 bpp image to match</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogCreateDid(
				 ByVal recog as L_Recog, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.recogCreateDid( recog.Pointer, pixs.Pointer)

	Return _Result
End Function

' SRC\recogdid.c (818, 1)
' recogDestroyDid(recog) as Integer
' recogDestroyDid(L_RECOG *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) As the signature indicates, this is owned by the recog, and can<para/>
''' only be destroyed using this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogDestroyDid(
				 ByVal recog as L_Recog) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.recogDestroyDid( recog.Pointer)

	Return _Result
End Function

' SRC\recogdid.c (874, 1)
' recogDidExists(recog) as Integer
' recogDidExists(L_RECOG *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>1 if recog- is greater did exists 0 if not or on error.</returns>
Public Shared Function recogDidExists(
				 ByVal recog as L_Recog) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.recogDidExists( recog.Pointer)

	Return _Result
End Function

' SRC\recogdid.c (896, 1)
' recogGetDid(recog) as L_Rdid
' recogGetDid(L_RECOG *) as L_RDID *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This also makes sure the arrays are defined.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''   <returns>did still owned by the recog, or NULL on error</returns>
Public Shared Function recogGetDid(
				 ByVal recog as L_Recog) as L_Rdid

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.recogGetDid( recog.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rdid(_Result)
End Function

' SRC\recogdid.c (1005, 1)
' recogSetChannelParams(recog, nlevels) as Integer
' recogSetChannelParams(L_RECOG *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This converts the independent bit-flip probabilities in the<para/>
''' "channel" into log-likelihood coefficients on image sums.<para/>
''' These coefficients are only defined for the non-background<para/>
''' template levels.  Thus for nlevels = 2 (one fg, one bg),<para/>
''' only beta[1] and gamma[1] are used.  For nlevels = 4 (three<para/>
''' fg templates), we use beta[1-3] and gamma[1-3].<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="recog">[in] - </param>
'''  <param name="nlevels">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function recogSetChannelParams(
				 ByVal recog as L_Recog, 
				 ByVal nlevels as Integer) as Integer

	If IsNothing (recog) then Throw New ArgumentNullException  ("recog cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.recogSetChannelParams( recog.Pointer, nlevels)

	Return _Result
End Function

End Class
