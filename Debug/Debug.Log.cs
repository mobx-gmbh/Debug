using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MobX
{
    public static partial class Debug
    {
        #region Log Message

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string message, Object context = null)
        {
            LogMessageInternal(message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(object message, Object context = null)
        {
            LogMessageInternal(message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(T message, Object context = null) where T : struct
        {
            LogMessageInternal(message, context);
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
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(T message, LogOption logOption, Object context = null) where T : struct
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Log Collection

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="separator">String separating collection elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(ICollection<T> collection, string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(LogType.Log, LogOption.None, collection, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(ICollection<T> collection, Object context)
        {
            LogFormatInternal(LogType.Log, LogOption.None, collection, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="separator">String separating collection elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(ICollection<T> collection, LogOption logOption, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(LogType.Log, logOption, collection, separator, null);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(ICollection<T> collection, LogOption logOption, Object context)
        {
            LogFormatInternal(LogType.Log, logOption, collection, SEPARATOR, context);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Log Format

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void LogFormat(string format, params object[] args)
        {
            LogFormatInternal(LogType.Log, LogOption.None, format, args, null);
        }

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void LogFormat(Object context, string format, params object[] args)
        {
            LogFormatInternal(LogType.Log, LogOption.None, format, args, context);
        }

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="logType">Type of message e.g. warn or error etc.</param>
        /// <param name="logOptions">Option flags to treat the log message special.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format,
            params object[] args)
        {
            LogFormatInternal(logType, logOptions, format, args, context);
        }

        #endregion
    }
}