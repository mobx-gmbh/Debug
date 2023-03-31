using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning(string warning, Object context = null)
        {
            LogWarningInternal(warning, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning(object warning, Object context = null)
        {
            LogWarningInternal(warning.ToString(), context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="warning">Object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(T warning, Object context = null) where T : struct
        {
            LogWarningInternal(warning.ToString(), context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning(string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning(object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(T message, LogOption logOption, Object context = null) where T : struct
        {
            LogFormatInternal(LogType.Warning, logOption, message, null, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(IEnumerable<T> enumerable, string separator = Separator, Object context = null)
        {
            LogFormatInternal(LogType.Warning, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(LogType.Warning, LogOption.None, enumerable, Separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(IEnumerable<T> enumerable, LogOption logOption, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(LogType.Warning, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(IEnumerable<T> enumerable, LogOption logOption, Object context)
        {
            LogFormatInternal(LogType.Warning, logOption, enumerable, Separator, context);
        }

        //------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a formatted warning message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarningFormat(string format, params object[] args)
        {
            LogFormatInternal(LogType.Warning, LogOption.None, format, args, null);
        }

        /// <summary>
        ///   <para>Logs a formatted warning message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            LogFormatInternal(LogType.Warning, LogOption.None, format, args, context);
        }
    }
}