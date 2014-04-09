﻿using System;

namespace Splat
{
    interface IProfilerPlatformOperations
    {
        IDisposable Initialize();

        ulong GetSpanContextIdentifier();
        int GetRealThreadIdentifier();
        bool IsContextSpanNotScheduled(ulong spanContext);
    }

    interface IUiThreadDispatcherHook
    {
        IDisposable RegisterHook(
            Action<int> dispatcherQueued,
            Action<int> dispatcherItemStarted,
            Action<int> dispatcherItemFinished,
            Action<int> dispatcherItemCancelled);
    }
}