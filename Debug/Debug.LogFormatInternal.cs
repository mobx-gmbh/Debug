using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MobX
{
    public static partial class Debug
    {
        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal(LogType logType, LogOption logOption, string format, object[] args,
            Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log, logType))
            {
                return;
            }

            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal(LogType logType, LogOption logOption, object message, object[] args,
            Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log, logType))
            {
                return;
            }

            var format = message.ToString();
            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal<T>(LogType logType, LogOption logOption, T message, object[] args,
            Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log, logType))
            {
                return;
            }

            var format = message.ToString();
            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        //--------------------------------------------------------------------------------------------------------------

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal(LogCategory category, LogType logType, LogOption logOption,
            string message, object[] args, Object context)
        {
            if (IsLogCategoryBlocked(category, logType))
            {
                return;
            }

            var format = CreateLogCategoryMessageNoAlloc(category, message);
            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal(LogCategory category, LogType logType, LogOption logOption,
            object message, object[] args, Object context)
        {
            if (IsLogCategoryBlocked(category, logType))
            {
                return;
            }

            var format = CreateLogCategoryMessageNoAlloc(category, message.ToString());
            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal<T>(LogCategory category, LogType logType, LogOption logOption, T message,
            object[] args, Object context) where T : struct
        {
            if (IsLogCategoryBlocked(category, logType))
            {
                return;
            }

            var format = CreateLogCategoryMessageNoAlloc(category, message.ToString());
            UnityEngine.Debug.LogFormat(logType, logOption, context, format, args ?? Array.Empty<object>());
        }

        //--------------------------------------------------------------------------------------------------------------

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal<T>(LogType logType, LogOption logOption, IEnumerable<T> enumerable,
            string separator, Object context)
        {
            if (IsLogCategoryBlocked(LogCategory.Log, logType))
            {
                return;
            }

            var count = enumerable is ICollection<T> collection ? collection.Count : 1;
            var stringBuilder = new StringBuilder(count * 64);
            stringBuilder.Append('[');
            stringBuilder.Append(LogCategory.Log.Name);
            stringBuilder.Append(']');
            foreach (var element in enumerable)
            {
                stringBuilder.Append(separator);
                stringBuilder.Append(element?.ToString());
            }

            var message = stringBuilder.ToString();
            UnityEngine.Debug.LogFormat(logType, logOption, context, message);
        }

        [DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void LogFormatInternal<T>(LogCategory category, LogType logType, LogOption logOption,
            IEnumerable<T> enumerable, string separator, Object context)
        {
            if (IsLogCategoryBlocked(category, logType))
            {
                return;
            }

            var count = enumerable is ICollection<T> collection ? collection.Count : 1;
            var stringBuilder = new StringBuilder(count);
            stringBuilder.Append('[');
            stringBuilder.Append(category.Name);
            stringBuilder.Append(']');
            foreach (var element in enumerable)
            {
                stringBuilder.Append(separator);
                stringBuilder.Append(element?.ToString());
            }

            var message = stringBuilder.ToString();
            UnityEngine.Debug.LogFormat(logType, logOption, context, message);
        }
    }
}