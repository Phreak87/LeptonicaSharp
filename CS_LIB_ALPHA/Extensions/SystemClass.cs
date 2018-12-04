using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices;

    public class FILE
    {
        public IntPtr Pointer { get; set; }

        private Marshal_FILE Values;
        public FILE(string Filename)
            : this(Natives.lept_fopen(Filename, "rb"))
        {
        }

        public FILE(IntPtr IntPTR)
        {
            if (IntPTR == IntPtr.Zero)
                return;
            Pointer = IntPTR;
            Values = new Marshal_FILE();
            Marshal.PtrToStructure(Pointer, Values);
        }

        [StructLayout(LayoutKind.Sequential)]
        private class Marshal_FILE
        {
            public string _ptr;
            public int _cnt;
            public string _base;
            public int _flag;
            public int _file;
            public int _charbuf;
            public int _bufsiz;
            public string _tmpfname;
        }

        public string _ptr
        {
            get { return Values._ptr; }
        }
        public int _cnt
        {
            get { return Values._cnt; }
        }
        public string _base
        {
            get { return Values._base; }
        }
        public int _flag
        {
            get { return Values._flag; }
        }
        public int _file
        {
            get { return Values._file; }
        }
        public int _charbuf
        {
            get { return Values._charbuf; }
        }
        public int _bufsiz
        {
            get { return Values._bufsiz; }
        }
        public string _tmpfname
        {
            get { return Values._tmpfname; }
        }
    }
