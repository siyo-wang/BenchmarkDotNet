﻿using BenchmarkDotNet.Extensions;

namespace BenchmarkDotNet.Engine
{
    public static class IterationModeExtensions
    {
        public static bool IsIdle(this IterationMode mode) => mode.IsOneOf(IterationMode.IdleWarmup, IterationMode.IdleTarget);
    }
}