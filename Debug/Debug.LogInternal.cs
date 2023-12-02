using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(string message, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(LogCategory.Log))
            {
                return;
            }

            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(LogCategory.Log, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(object message, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(LogCategory.Log))
            {
                return;
            }

            var messageString = message?.ToString();
            UnityEngine.Debug.Log(messageString, context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal<T>(T message, Object context, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(LogCategory.Log))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(messageString, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(LogCategory category, string message, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(LogCategory category, object message, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal<T>(LogCategory category, T message, Object context, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        //--------------------------------------------------------------------------------------------------------------

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(LogCategory category, string message, Object context, Color color, Verbosity verbosity)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            UnityEngine.Debug.Log(
                Application.isEditor
                    ? CreateLogCategoryMessageNoAlloc(category, message, color)
                    : CreateLogCategoryMessageNoAlloc(category, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(LogCategory category, object message, Object context, Color color, Verbosity verbosity)
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(
                Application.isEditor
                    ? CreateLogCategoryMessageNoAlloc(category, messageString, color)
                    : CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal<T>(LogCategory category, T message, Object context, Color color, Verbosity verbosity) where T : struct
        {
            if (verbosity < Verbosity)
            {
                return;
            }

            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(
                Application.isEditor
                    ? CreateLogCategoryMessageNoAlloc(category, messageString, color)
                    : CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }
    }
}