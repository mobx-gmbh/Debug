using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogWarningInternal(string message, Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log, LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarning(CreateLogCategoryMessageNoAlloc(LogCategory.Log, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogWarningInternal(LogCategory category, string message, Object context)
        {
            if (IsLogCategoryBlocked(category, LogType.Warning))
            {
                return;
            }

            UnityEngine.Debug.LogWarning(CreateLogCategoryMessageNoAlloc(category, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogWarningInternal(LogCategory category, object message, Object context)
        {
            if (IsLogCategoryBlocked(category, LogType.Warning))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.LogWarning(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogWarningInternal<T>(LogCategory category, T message, Object context)
            where T : struct
        {
            if (IsLogCategoryBlocked(category, LogType.Warning))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.LogWarning(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }
    }
}