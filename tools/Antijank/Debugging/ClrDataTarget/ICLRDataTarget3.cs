﻿﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("A5664F95-0AF4-4A1B-960E-2F3346B4214C")]
  [SuppressUnmanagedCodeSecurity]
  [ComImport]
  [PublicAPI]
  public interface ICLRDataTarget3 : ICLRDataTarget2 {

    /*
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetMachineType(out uint machineType);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetPointerSize(out uint pointerSize);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetImageBase([MarshalAs(UnmanagedType.LPWStr)] [In] string imagePath, out ulong baseAddress);
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void ReadVirtual([In] ulong address, ref byte* buffer, [In] uint bytesRequested, out uint bytesRead);
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void WriteVirtual([In] ulong address, [In] ref byte* buffer, [In] uint bytesRequested, out uint bytesWritten);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetTLSValue([In] uint threadID, [In] uint index, out ulong value);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void SetTLSValue([In] uint threadID, [In] uint index, [In] ulong value);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetCurrentThreadID(out uint threadID);
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void GetThreadContext([In] uint threadID, [In] uint contextFlags, [In] uint contextSize, ref byte*context);
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void SetThreadContext([In] uint threadID, [In] uint contextSize, [In] ref byte* context);
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void Request([In] uint reqCode, [In] uint inBufferSize, [In] ref byte* inBuffer, [In] uint outBufferSize, ref byte*outBuffer);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void AllocVirtual([In] ulong addr, [In] uint size, [In] uint typeFlags, [In] uint protectFlags, out ulong virt);
    [MethodImpl(MethodImplOptions.InternalCall)]
    void FreeVirtual([In] ulong addr, [In] uint size, [In] uint typeFlags);
    */
    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void GetExceptionRecord([In] uint bufferSize, out uint bufferUsed, ref byte* buffer);

    [MethodImpl(MethodImplOptions.InternalCall)]
    unsafe void GetExceptionContextRecord([In] uint bufferSize, out uint bufferUsed, ref byte* buffer);

    [MethodImpl(MethodImplOptions.InternalCall)]
    void GetExceptionThreadID(out uint threadID);

  }

}