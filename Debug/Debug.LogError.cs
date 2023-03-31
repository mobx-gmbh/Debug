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
        /// <param name="error">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError(string error, Object context = null)
        {
            LogErrorInternal(error, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="error">Object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError(object error, Object context = null)
        {
            LogErrorInternal(error.ToString(), context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="error">Object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(T error, Object context = null) where T : struct
        {
            LogErrorInternal(error.ToString(), context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError(string error, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Error, logOption, error, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError(object error, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Error, logOption, error, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(T error, LogOption logOption, Object context = null) where T : struct
        {
            LogFormatInternal(LogType.Error, logOption, error, null, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="separator">String separating collection elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(IEnumerable<T> collection, string separator = Separator, Object context = null)
        {
            LogFormatInternal(LogType.Error, LogOption.None, collection, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(IEnumerable<T> collection, Object context)
        {
            LogFormatInternal(LogType.Error, LogOption.None, collection, Separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating collection elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(IEnumerable<T> collection, LogOption logOption, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(LogType.Error, logOption, collection, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(IEnumerable<T> collection, LogOption logOption, Object context)
        {
            LogFormatInternal(LogType.Error, logOption, collection, Separator, context);
        }

        //------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a formatted warning message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogErrorFormat(string format, params object[] args)
        {
            LogFormatInternal(LogType.Error, LogOption.None, format, args, null);
        }

        /// <summary>
        ///   <para>Logs a formatted warning message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            LogFormatInternal(LogType.Error, LogOption.None, format, args, context);
        }
    }
}