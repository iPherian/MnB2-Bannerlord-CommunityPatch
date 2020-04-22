﻿using JetBrains.Annotations;

namespace Antijank.Debugging {

  [PublicAPI]
  public enum CorDebugChainReason {

    CHAIN_NONE,

    CHAIN_CLASS_INIT,

    CHAIN_EXCEPTION_FILTER,

    CHAIN_SECURITY = 4,

    CHAIN_CONTEXT_POLICY = 8,

    CHAIN_INTERCEPTION = 16,

    CHAIN_PROCESS_START = 32,

    CHAIN_THREAD_START = 64,

    CHAIN_ENTER_MANAGED = 128,

    CHAIN_ENTER_UNMANAGED = 256,

    CHAIN_DEBUGGER_EVAL = 512,

    CHAIN_CONTEXT_SWITCH = 1024,

    CHAIN_FUNC_EVAL = 2048

  }

}