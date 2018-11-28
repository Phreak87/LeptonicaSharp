using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum DebugOnOff {
    DebugOn = 1,
    DebugOff = 2
}
public class FILE : IDisposable{
    public FILE (IntPtr PTR){

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