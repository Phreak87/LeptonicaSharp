Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\gplot.c (138, 1)
' gplotCreate(rootname, outformat, title, xlabel, ylabel) as GPlot
' gplotCreate(const char *, l_int32, const char *, const char *, const char *) as GPLOT *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This initializes the plot.<para/>
''' 
''' (2) The 'title', 'xlabel' and 'ylabel' strings can have spaces,
''' double quotes and backquotes, but not single quotes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotCreate/*"/>
'''  <param name="rootname">[in] - root for all output files</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="title">[in][optional] - overall title</param>
'''  <param name="xlabel">[in][optional] - x axis label</param>
'''  <param name="ylabel">[in][optional] - y axis label</param>
'''   <returns>gplot, or NULL on error</returns>
Public Shared Function gplotCreate(
				 ByVal rootname as String, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 Optional ByVal title as String = Nothing, 
				 Optional ByVal xlabel as String = Nothing, 
				 Optional ByVal ylabel as String = Nothing) as GPlot

	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.gplotCreate( rootname, outformat, title, xlabel, ylabel)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new GPlot(_Result)
End Function

' SRC\gplot.c (197, 1)
' gplotDestroy(pgplot) as Object
' gplotDestroy(GPLOT **) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotDestroy/*"/>
'''  <param name="pgplot">[in,out] - to be nulled</param>
Public Shared Sub gplotDestroy(
				 ByRef pgplot as GPlot)

	Dim pgplotPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pgplot) Then pgplotPTR = pgplot.Pointer

	LeptonicaSharp.Natives.gplotDestroy( pgplotPTR)

If pgplotPTR = IntPtr.Zero Then pgplot = Nothing
If pgplotPTR <> IntPtr.Zero Then pgplot = New GPlot(pgplotPTR)

End Sub

' SRC\gplot.c (263, 1)
' gplotAddPlot(gplot, nax, nay, plotstyle, plottitle) as Integer
' gplotAddPlot(GPLOT *, NUMA *, NUMA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) There are 2 options for (x,y) values:
''' o  To plot an array vs a linear function of the
''' index, set nax = NULL.
''' o  To plot one array vs another, use both nax and nay.<para/>
''' 
''' (2) If nax is NULL, the x value corresponding to the i-th
''' value of nay is found from the startx and delx fields
''' in nay:
''' x = startx + i  delx
''' These are set with numaSetParameters().  Their default
''' values are startx = 0.0, delx = 1.0.<para/>
''' 
''' (3) If nax is defined, it must be the same size as nay, and
''' must have at least one number.<para/>
''' 
''' (4) The 'plottitle' string can have spaces, double
''' quotes and backquotes, but not single quotes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotAddPlot/*"/>
'''  <param name="gplot">[in] - </param>
'''  <param name="nax">[in][optional] - numa: set to null for Y_VS_I required for Y_VS_X</param>
'''  <param name="nay">[in] - numa: required for both Y_VS_I and Y_VS_X</param>
'''  <param name="plotstyle">[in] - GPLOT_LINES, GPLOT_POINTS, GPLOT_IMPULSES, GPLOT_LINESPOINTS, GPLOT_DOTS</param>
'''  <param name="plottitle">[in][optional] - title for individual plot</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotAddPlot(
				 ByVal gplot as GPlot, 
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal plotstyle as Enumerations.GPLOT_STYLE, 
				 Optional ByVal plottitle as String = Nothing) as Integer

	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")
	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotAddPlot( gplot.Pointer, naxPTR, nay.Pointer, plotstyle, plottitle)


	Return _Result
End Function

' SRC\gplot.c (343, 1)
' gplotSetScaling(gplot, scaling) as Integer
' gplotSetScaling(GPLOT *, l_int32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) By default, the x and y axis scaling is linear.<para/>
''' 
''' (2) Call this function to set semi-log or log-log scaling.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSetScaling/*"/>
'''  <param name="gplot">[in] - </param>
'''  <param name="scaling">[in] - GPLOT_LINEAR_SCALE, GPLOT_LOG_SCALE_X, GPLOT_LOG_SCALE_Y, GPLOT_LOG_SCALE_X_Y</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function gplotSetScaling(
				 ByVal gplot as GPlot, 
				 ByVal scaling as Enumerations.GPLOT_SCALING) as Integer

	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSetScaling( gplot.Pointer, scaling)


	Return _Result
End Function

' SRC\gplot.c (379, 1)
' gplotMakeOutput(gplot) as Integer
' gplotMakeOutput(GPLOT *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This uses gplot and the new arrays to add a plot
''' to the output, by writing a new data file and appending
''' the appropriate plot commands to the command file.<para/>
''' 
''' (2) This is the only function in this file that requires the
''' gnuplot executable, to actually generate the plot.<para/>
''' 
''' (3) The command file name for unix is canonical (i.e., directory /tmp)
''' but the temp filename paths in the command file must be correct.<para/>
''' 
''' (4) The gnuplot program for windows is wgnuplot.exe.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotMakeOutput/*"/>
'''  <param name="gplot">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function gplotMakeOutput(
				 ByVal gplot as GPlot) as Integer

	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotMakeOutput( gplot.Pointer)


	Return _Result
End Function

' SRC\gplot.c (422, 1)
' gplotGenCommandFile(gplot) as Integer
' gplotGenCommandFile(GPLOT *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotGenCommandFile/*"/>
'''  <param name="gplot">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotGenCommandFile(
				 ByVal gplot as GPlot) as Integer

	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotGenCommandFile( gplot.Pointer)


	Return _Result
End Function

' SRC\gplot.c (528, 1)
' gplotGenDataFiles(gplot) as Integer
' gplotGenDataFiles(GPLOT *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) The pathnames in the gplot command file are actual pathnames,
''' which can be in temp directories.  Consequently, they must not be
''' rewritten by calling fopenWriteStream(), and we use fopen().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotGenDataFiles/*"/>
'''  <param name="gplot">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotGenDataFiles(
				 ByVal gplot as GPlot) as Integer

	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotGenDataFiles( gplot.Pointer)


	Return _Result
End Function

' SRC\gplot.c (575, 1)
' gplotSimple1(na, outformat, outroot, title) as Integer
' gplotSimple1(NUMA *, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives a line plot of a numa, where the array value
''' is plotted vs the array index.  The plot is generated
''' in the specified output format the title  is optional.<para/>
''' 
''' (2) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimple1/*"/>
'''  <param name="na">[in] - numa plot Y_VS_I</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - , can be NULL</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimple1(
				 ByVal na as Numa, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimple1( na.Pointer, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (604, 1)
' gplotSimple2(na1, na2, outformat, outroot, title) as Integer
' gplotSimple2(NUMA *, NUMA *, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives a line plot of two numa, where the array values
''' are each plotted vs the array index.  The plot is generated
''' in the specified output format the title  is optional.<para/>
''' 
''' (2) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimple2/*"/>
'''  <param name="na1">[in] - numa plotted with Y_VS_I</param>
'''  <param name="na2">[in] - ditto</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimple2(
				 ByVal na1 as Numa, 
				 ByVal na2 as Numa, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (na1) then Throw New ArgumentNullException  ("na1 cannot be Nothing")
	If IsNothing (na2) then Throw New ArgumentNullException  ("na2 cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimple2( na1.Pointer, na2.Pointer, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (635, 1)
' gplotSimpleN(naa, outformat, outroot, title) as Integer
' gplotSimpleN(NUMAA *, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives a line plot of all numas in a numaa (array of numa),
''' where the array values are each plotted vs the array index.
''' The plot is generated in the specified output format
''' the title  is optional.<para/>
''' 
''' (2) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimpleN/*"/>
'''  <param name="naa">[in] - numaa we plotted with Y_VS_I for each numa</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimpleN(
				 ByVal naa as Numaa, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (naa) then Throw New ArgumentNullException  ("naa cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimpleN( naa.Pointer, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (668, 1)
' gplotSimpleXY1(nax, nay, plotstyle, outformat, outroot, title) as Integer
' gplotSimpleXY1(NUMA *, NUMA *, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives a plot of a %nay vs %nax, generated in
''' the specified output format.  The title is optional.<para/>
''' 
''' (2) Use 0 for default plotstyle (lines).<para/>
''' 
''' (3) %nax is optional.  If NULL, %nay is plotted against
''' the array index.<para/>
''' 
''' (4) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimpleXY1/*"/>
'''  <param name="nax">[in][optional] - </param>
'''  <param name="nay">[in] - </param>
'''  <param name="plotstyle">[in] - GPLOT_LINES, GPLOT_POINTS, GPLOT_IMPULSES, GPLOT_LINESPOINTS, GPLOT_DOTS</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - , can be NULL</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimpleXY1(
				 ByVal nax as Numa, 
				 ByVal nay as Numa, 
				 ByVal plotstyle as Enumerations.GPLOT_STYLE, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimpleXY1( naxPTR, nay.Pointer, plotstyle, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (723, 1)
' gplotSimpleXY2(nax, nay1, nay2, plotstyle, outformat, outroot, title) as Integer
' gplotSimpleXY2(NUMA *, NUMA *, NUMA *, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives plots of %nay1 and %nay2 against nax, generated
''' in the specified output format.  The title is optional.<para/>
''' 
''' (2) Use 0 for default plotstyle (lines).<para/>
''' 
''' (3) %nax is optional.  If NULL, %nay1 and %nay2 are plotted
''' against the array index.<para/>
''' 
''' (4) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimpleXY2/*"/>
'''  <param name="nax">[in] - is smalleroptional can be NULL</param>
'''  <param name="nay1">[in] - </param>
'''  <param name="nay2">[in] - </param>
'''  <param name="plotstyle">[in] - GPLOT_LINES, GPLOT_POINTS, GPLOT_IMPULSES, GPLOT_LINESPOINTS, GPLOT_DOTS</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimpleXY2(
				 ByVal nax as Numa, 
				 ByVal nay1 as Numa, 
				 ByVal nay2 as Numa, 
				 ByVal plotstyle as Enumerations.GPLOT_STYLE, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (nax) then Throw New ArgumentNullException  ("nax cannot be Nothing")
	If IsNothing (nay1) then Throw New ArgumentNullException  ("nay1 cannot be Nothing")
	If IsNothing (nay2) then Throw New ArgumentNullException  ("nay2 cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimpleXY2( nax.Pointer, nay1.Pointer, nay2.Pointer, plotstyle, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (779, 1)
' gplotSimpleXYN(nax, naay, plotstyle, outformat, outroot, title) as Integer
' gplotSimpleXYN(NUMA *, NUMAA *, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This gives plots of each Numa in %naa against nax,
''' generated in the specified output format.  The title is optional.<para/>
''' 
''' (2) Use 0 for default plotstyle (lines).<para/>
''' 
''' (3) %nax is optional.  If NULL, each Numa array is plotted against
''' the array index.<para/>
''' 
''' (4) When calling these simple plot functions more than once, use
''' different %outroot to avoid overwriting the output files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotSimpleXYN/*"/>
'''  <param name="nax">[in][optional] - can be NULL</param>
'''  <param name="naay">[in] - numaa of arrays to plot against %nax</param>
'''  <param name="plotstyle">[in] - GPLOT_LINES, GPLOT_POINTS, GPLOT_IMPULSES, GPLOT_LINESPOINTS, GPLOT_DOTS</param>
'''  <param name="outformat">[in] - GPLOT_PNG, GPLOT_PS, GPLOT_EPS, GPLOT_LATEX</param>
'''  <param name="outroot">[in] - root of output files</param>
'''  <param name="title">[in][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function gplotSimpleXYN(
				 ByVal nax as Numa, 
				 ByVal naay as Numaa, 
				 ByVal plotstyle as Enumerations.GPLOT_STYLE, 
				 ByVal outformat as Enumerations.GPLOT_OUTPUT, 
				 ByVal outroot as String, 
				 Optional ByVal title as String = Nothing) as Integer

	If IsNothing (naay) then Throw New ArgumentNullException  ("naay cannot be Nothing")
	If IsNothing (outroot) then Throw New ArgumentNullException  ("outroot cannot be Nothing")

	Dim naxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nax) Then naxPTR = nax.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotSimpleXYN( naxPTR, naay.Pointer, plotstyle, outformat, outroot, title)


	Return _Result
End Function

' SRC\gplot.c (827, 1)
' gplotRead(filename) as GPlot
' gplotRead(const char *) as GPLOT *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>gplot, or NULL on error</returns>
Public Shared Function gplotRead(
				 ByVal filename as String) as GPlot

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.FileExists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.gplotRead( filename)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new GPlot(_Result)
End Function

' SRC\gplot.c (912, 1)
' gplotWrite(filename, gplot) as Integer
' gplotWrite(const char *, GPLOT *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/gplotWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="gplot">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function gplotWrite(
				 ByVal filename as String, 
				 ByVal gplot as GPlot) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (gplot) then Throw New ArgumentNullException  ("gplot cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.gplotWrite( filename, gplot.Pointer)


	Return _Result
End Function

End Class
