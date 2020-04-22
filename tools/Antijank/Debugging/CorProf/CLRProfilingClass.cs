using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  [Guid("BD097ED8-733E-43fe-8ED7-A95FF9A8448C")]
  [ClassInterface(ClassInterfaceType.None)]
  [SuppressUnmanagedCodeSecurity]
  [ComImport]
  [PublicAPI]
  public class CLRProfilingClass : CLRProfiling, ICLRProfiling {

    [MethodImpl(MethodImplOptions.InternalCall)]
    public virtual extern void AttachProfiler(uint dwProfileeProcessID, uint dwMillisecondsMax, ref Guid pClsidProfiler,
      string wszProfilerPath, IntPtr pvClientData, uint cbClientData);

  }

}