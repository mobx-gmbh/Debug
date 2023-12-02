using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogErrorInternal(string message, Object context)
        {
            if (Verbosity > Verbosity.Error)
            {
                return;
            }

            if (IsLogCategoryBlocked(LogCategory.Log, LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogError(CreateLogCategoryMessageNoAlloc(LogCategory.Log, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogErrorInternal(LogCategory category, string message, Object context)
        {
            if (Verbosity > Verbosity.Error)
            {
                return;
            }

            if (IsLogCategoryBlocked(category, LogType.Error))
            {
                return;
            }

            UnityEngine.Debug.LogError(CreateLogCategoryMessageNoAlloc(category, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogErrorInternal(LogCategory category, object message, Object context)
        {
            if (Verbosity > Verbosity.Error)
            {
                return;
            }

            if (IsLogCategoryBlocked(category, LogType.Error))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.LogError(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogErrorInternal<T>(LogCategory category, T message, Object context)
            where T : struct
        {
            if (Verbosity > Verbosity.Error)
            {
                return;
            }

            if (IsLogCategoryBlocked(category, LogType.Error))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.LogError(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }
    }
}