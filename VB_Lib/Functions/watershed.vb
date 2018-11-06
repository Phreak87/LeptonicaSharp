Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\watershed.c (203, 1)
' wshedCreate(pixs, pixm, mindepth, debugflag) as L_WShed
' wshedCreate(PIX *, PIX *, l_int32, l_int32) as L_WSHED *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is not necessary for the fg pixels in the seed image<para/>
''' be at minima, or that they be isolated.  We extract a<para/>
''' single pixel from each connected component, and a seed<para/>
''' anywhere in a watershed will eventually label the watershed<para/>
''' when the filling level reaches it.<para/>
''' (2) Set mindepth to some value to ignore noise in pixs that<para/>
''' can create small local minima.  Any watershed shallower<para/>
''' than mindepth, even if it has a seed, will not be saved<para/>
''' It will either be incorporated in another watershed or<para/>
''' eliminated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedCreate/*"/>
'''  <param name="pixs">[in] - 8 bpp source</param>
'''  <param name="pixm">[in] - 1 bpp 'marker' seed</param>
'''  <param name="mindepth">[in] - minimum depth anything less is not saved</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>WShed, or NULL on error</returns>
Public Shared Function wshedCreate(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal mindepth as Integer, 
				 ByVal debugflag as Integer) as L_WShed

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.wshedCreate( pixs.Pointer, pixm.Pointer, mindepth, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_WShed(_Result)
End Function

' SRC\watershed.c (250, 1)
' wshedDestroy(pwshed) as Object
' wshedDestroy(L_WSHED **) as void
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedDestroy/*"/>
'''  <param name="pwshed">[in,out] - will be set to null before returning</param>
Public Shared Sub wshedDestroy(
				 ByRef pwshed as L_WShed)

	Dim pwshedPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pwshed) Then pwshedPTR = pwshed.Pointer

	LeptonicaSharp.Natives.wshedDestroy( pwshedPTR)
	if pwshedPTR <> IntPtr.Zero then pwshed = new L_WShed(pwshedPTR)

End Sub

' SRC\watershed.c (305, 1)
' wshedApply(wshed) as Integer
' wshedApply(L_WSHED *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedApply/*"/>
'''  <param name="wshed">[in] - generated from wshedCreate()</param>
'''   <returns>0 if OK, 1 on error Iportant note: 1 This is buggy.  It seems to locate watersheds that are duplicates.  The watershed extraction after complete fill grabs some regions belonging to existing watersheds. See prog/watershedtest.c for testing.</returns>
Public Shared Function wshedApply(
				 ByVal wshed as L_WShed) as Integer

	If IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.wshedApply( wshed.Pointer)

	Return _Result
End Function

' SRC\watershed.c (1034, 1)
' wshedBasins(wshed, ppixa, pnalevels) as Integer
' wshedBasins(L_WSHED *, PIXA **, NUMA **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedBasins/*"/>
'''  <param name="wshed">[in] - </param>
'''  <param name="ppixa">[out][optional] - mask of watershed basins</param>
'''  <param name="pnalevels">[out][optional] - watershed levels</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function wshedBasins(
				 ByVal wshed as L_WShed, 
				<Out()> Optional ByRef ppixa as Pixa = Nothing, 
				<Out()> Optional ByRef pnalevels as Numa = Nothing) as Integer

	If IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")

Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer
Dim pnalevelsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnalevels) Then pnalevelsPTR = pnalevels.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.wshedBasins( wshed.Pointer, ppixaPTR, pnalevelsPTR)
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)
	if pnalevelsPTR <> IntPtr.Zero then pnalevels = new Numa(pnalevelsPTR)

	Return _Result
End Function

' SRC\watershed.c (1058, 1)
' wshedRenderFill(wshed) as Pix
' wshedRenderFill(L_WSHED *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedRenderFill/*"/>
'''  <param name="wshed">[in] - </param>
'''   <returns>pixd initial image with all basins filled, or NULL on error</returns>
Public Shared Function wshedRenderFill(
				 ByVal wshed as L_WShed) as Pix

	If IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.wshedRenderFill( wshed.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\watershed.c (1094, 1)
' wshedRenderColors(wshed) as Pix
' wshedRenderColors(L_WSHED *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/wshedRenderColors/*"/>
'''  <param name="wshed">[in] - </param>
'''   <returns>pixd initial image with all basins filled, or NULL on error</returns>
Public Shared Function wshedRenderColors(
				 ByVal wshed as L_WShed) as Pix

	If IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.wshedRenderColors( wshed.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class
