using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(string message, Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log))
            {
                return;
            }

            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(LogCategory.Log, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(object message, Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log))
            {
                return;
            }

            var messageString = message?.ToString();
            UnityEngine.Debug.Log(messageString, context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal<T>(T message, Object context) where T : struct
        {
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
        private static void LogMessageInternal(LogCategory category, string message, Object context)
        {
            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, message), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal(LogCategory category, object message, Object context)
        {
            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogMessageInternal<T>(LogCategory category, T message, Object context) where T : struct
        {
            if (IsLogCategoryBlocked(category))
            {
                return;
            }

            var messageString = message.ToString();
            UnityEngine.Debug.Log(CreateLogCategoryMessageNoAlloc(category, messageString), context);
        }
    }
}