﻿using System;

namespace Trady.Core.Infrastructure
{
    public interface IAnalyzableTick : ITick
    {
        new DateTime? DateTime { get; }

        object Tick { get; }
    }

    public interface IAnalyzableTick<T> : IAnalyzableTick
    {
        new T Tick { get; }
    }
}