using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeptonicaSharp;


    public class FILE : IDisposable
    {
        public FILE(IntPtr PTR)
        {

        }
        public IntPtr Pointer
        {
            get
            {
                return IntPtr.Zero;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class RB_TYPE
    {
        public RB_TYPE(IntPtr PTR)
        {

        }
        public IntPtr Pointer
        {
            get
            {
                return IntPtr.Zero;
            }
        }

    }
    //Sub New(w As Integer, h As Integer)
    //    Dim OBJ = LeptonicaSharp._All.pixCreate(w, h, 32)
    //    Pointer = OBJ.Pointer
    //End Sub


