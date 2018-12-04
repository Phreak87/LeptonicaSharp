using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (107, 1)
// l_amapCreate(keytype) as L_Rbtree
// l_amapCreate(l_int32) as L_AMAP *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapCreate/*"/>
///   <returns></returns>

public static L_Rbtree l_amapCreate(
				 int keytype){



	IntPtr _Result = Natives.l_amapCreate(
  keytype);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (121, 1)
// l_amapFind(m, key) as RB_TYPE
// l_amapFind(L_AMAP *, RB_TYPE) as RB_TYPE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapFind/*"/>
///   <returns></returns>

public static Rb_Type  l_amapFind(
				 L_Rbtree m, 
				 Rb_Type key){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}

	IntPtr _Result = Natives.l_amapFind(
m.Pointer, key.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


    return new Rb_Type(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (128, 1)
// l_amapInsert(m, key, value) as Object
// l_amapInsert(L_AMAP *, RB_TYPE, RB_TYPE) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapInsert/*"/>

public static void l_amapInsert(
				 L_Rbtree m, 
				 Rb_Type key, 
				 Rb_Type value){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}
	IntPtr valuePtr = IntPtr.Zero; if (value != null) {valuePtr = value.Pointer;}

	Natives.l_amapInsert(
m.Pointer, key.Pointer, value.Pointer);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (136, 1)
// l_amapDelete(m, key) as Object
// l_amapDelete(L_AMAP *, RB_TYPE) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapDelete/*"/>

public static void l_amapDelete(
				 L_Rbtree m, 
				 Rb_Type key){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}

	Natives.l_amapDelete(
m.Pointer, key.Pointer);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (143, 1)
// l_amapDestroy(pm) as Object
// l_amapDestroy(L_AMAP **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapDestroy/*"/>

public static void l_amapDestroy(
				 L_Rbtree pm){


	IntPtr pmPtr = IntPtr.Zero; 	if (pm != null) {pmPtr = pm.Pointer;}

	Natives.l_amapDestroy(
pmPtr);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (149, 1)
// l_amapGetFirst(m) as L_Rbtree_Node
// l_amapGetFirst(L_AMAP *) as L_AMAP_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetFirst/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_amapGetFirst(
				 L_Rbtree m){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}

	IntPtr _Result = Natives.l_amapGetFirst(
m.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (155, 1)
// l_amapGetNext(n) as L_Rbtree_Node
// l_amapGetNext(L_AMAP_NODE *) as L_AMAP_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetNext/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_amapGetNext(
				 L_Rbtree_Node n){


	IntPtr nPtr = IntPtr.Zero; if (n != null) {nPtr = n.Pointer;}

	IntPtr _Result = Natives.l_amapGetNext(
n.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (161, 1)
// l_amapGetLast(m) as L_Rbtree_Node
// l_amapGetLast(L_AMAP *) as L_AMAP_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetLast/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_amapGetLast(
				 L_Rbtree m){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}

	IntPtr _Result = Natives.l_amapGetLast(
m.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (167, 1)
// l_amapGetPrev(n) as L_Rbtree_Node
// l_amapGetPrev(L_AMAP_NODE *) as L_AMAP_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapGetPrev/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_amapGetPrev(
				 L_Rbtree_Node n){


	IntPtr nPtr = IntPtr.Zero; if (n != null) {nPtr = n.Pointer;}

	IntPtr _Result = Natives.l_amapGetPrev(
n.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (173, 1)
// l_amapSize(m) as int
// l_amapSize(L_AMAP *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_amapSize/*"/>
///   <returns></returns>

public static int l_amapSize(
				 L_Rbtree m){


	IntPtr mPtr = IntPtr.Zero; if (m != null) {mPtr = m.Pointer;}

	int _Result = Natives.l_amapSize(
m.Pointer);
	


//  



	return _Result;
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (183, 1)
// l_asetCreate(keytype) as L_Rbtree
// l_asetCreate(l_int32) as L_ASET *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetCreate/*"/>
///   <returns></returns>

public static L_Rbtree l_asetCreate(
				 int keytype){



	IntPtr _Result = Natives.l_asetCreate(
  keytype);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (203, 1)
// l_asetFind(s, key) as RB_TYPE
// l_asetFind(L_ASET *, RB_TYPE) as RB_TYPE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetFind/*"/>
///   <returns></returns>

public static Rb_Type l_asetFind(
				 L_Rbtree s, 
				 Rb_Type key){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}

	IntPtr _Result = Natives.l_asetFind(
s.Pointer, key.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


    return new Rb_Type(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (210, 1)
// l_asetInsert(s, key) as Object
// l_asetInsert(L_ASET *, RB_TYPE) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetInsert/*"/>

public static void l_asetInsert(
				 L_Rbtree s, 
				 Rb_Type key){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}

	Natives.l_asetInsert(
s.Pointer, key.Pointer);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (220, 1)
// l_asetDelete(s, key) as Object
// l_asetDelete(L_ASET *, RB_TYPE) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetDelete/*"/>

public static void l_asetDelete(
				 L_Rbtree s, 
				 Rb_Type key){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}
	IntPtr keyPtr = IntPtr.Zero; if (key != null) {keyPtr = key.Pointer;}

	Natives.l_asetDelete(
s.Pointer, key.Pointer);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (227, 1)
// l_asetDestroy(ps) as Object
// l_asetDestroy(L_ASET **) as void
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetDestroy/*"/>

public static void l_asetDestroy(
				 L_Rbtree ps){


	IntPtr psPtr = IntPtr.Zero; 	if (ps != null) {psPtr = ps.Pointer;}

	Natives.l_asetDestroy(
psPtr);
	


//  



}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (233, 1)
// l_asetGetFirst(s) as L_Rbtree_Node
// l_asetGetFirst(L_ASET *) as L_ASET_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetFirst/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_asetGetFirst(
				 L_Rbtree s){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}

	IntPtr _Result = Natives.l_asetGetFirst(
s.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (239, 1)
// l_asetGetNext(n) as L_Rbtree_Node
// l_asetGetNext(L_ASET_NODE *) as L_ASET_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetNext/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_asetGetNext(
				 L_Rbtree_Node n){


	IntPtr nPtr = IntPtr.Zero; if (n != null) {nPtr = n.Pointer;}

	IntPtr _Result = Natives.l_asetGetNext(
n.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (245, 1)
// l_asetGetLast(s) as L_Rbtree_Node
// l_asetGetLast(L_ASET *) as L_ASET_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetLast/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_asetGetLast(
				 L_Rbtree s){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}

	IntPtr _Result = Natives.l_asetGetLast(
s.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (251, 1)
// l_asetGetPrev(n) as L_Rbtree_Node
// l_asetGetPrev(L_ASET_NODE *) as L_ASET_NODE *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetGetPrev/*"/>
///   <returns></returns>

public static L_Rbtree_Node l_asetGetPrev(
				 L_Rbtree_Node n){


	IntPtr nPtr = IntPtr.Zero; if (n != null) {nPtr = n.Pointer;}

	IntPtr _Result = Natives.l_asetGetPrev(
n.Pointer);
	


//  

	if (_Result == IntPtr.Zero) {return null;}


	return  new L_Rbtree_Node(_Result);
}

// Comments.vb - System.String GenerateFunctionComment(NClang_Test.IntFunction, NClang_Test.TargetLang, System.String[]) :96
// map.c (257, 1)
// l_asetSize(s) as int
// l_asetSize(L_ASET *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetSize/*"/>
///   <returns></returns>

public static int l_asetSize(
				 L_Rbtree s){


	IntPtr sPtr = IntPtr.Zero; if (s != null) {sPtr = s.Pointer;}

	int _Result = Natives.l_asetSize(
s.Pointer);
	


//  



	return _Result;
}


}
}
