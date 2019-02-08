﻿using System;

namespace PNI.Graphics.Svg
{
    internal static class DisposableExtensions
    {
        public static TResult DisposeAfter<TDisposable, TResult>(this TDisposable disposable, Func<TDisposable, TResult> project)
            where TDisposable : IDisposable
        {
            using (disposable)
            {
                return project(disposable);
            }
        }
    }
}