﻿﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  [Guid("BCDD6908-BA2D-4EC5-96CF-DF4D5CDCB4A4")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [SuppressUnmanagedCodeSecurity]
  [ComImport]
  [PublicAPI]
  public interface ICLRDataEnumMemoryRegionsCallback {

    [MethodImpl(MethodImplOptions.InternalCall)]
    void EnumMemoryRegion([In] ulong address, [In] uint size);

  }

}