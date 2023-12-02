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
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string message, Verbosity verbosity)
        {
            LogMessageInternal(message, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(object message, Verbosity verbosity)
        {
            LogMessageInternal(message, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(object message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
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
        [Conditional("DEBUG")]
        public static void Log<T>(T message, Object context = null) where T : struct
        {
            LogMessageInternal(message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(T message, Verbosity verbosity) where T : struct
        {
            LogMessageInternal(message, null, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(object message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(T message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            LogFormatInternal(LogType.Log, logOption, message, null, context, verbosity);
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
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(ICollection<T> collection, string separator = Separator, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, LogOption.None, collection, separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(ICollection<T> collection, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, LogOption.None, collection, Separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="separator">String separating collection elements</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(ICollection<T> collection, LogOption logOption, string separator = Separator,
            Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, logOption, collection, separator, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="collection">Collection to be converted to string representation for display.</param>
        /// <param name="logOption"></param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(ICollection<T> collection, LogOption logOption, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(LogType.Log, logOption, collection, Separator, context, verbosity);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Log Format

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        /// <param name="args">Format arguments.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogFormat(string format, Verbosity verbosity, params object[] args)
        {
            LogFormatInternal(LogType.Log, LogOption.None, format, args, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogFormat(Object context, string format, Verbosity verbosity, params object[] args)
        {
            LogFormatInternal(LogType.Log, LogOption.None, format, args, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a formatted message to the Unity Console.</para>
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="logType">Type of message e.g. warn or error etc.</param>
        /// <param name="logOptions">Option flags to treat the log message special.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, Verbosity verbosity,
            params object[] args)
        {
            LogFormatInternal(logType, logOptions, format, args, context, verbosity);
        }

        #endregion
    }
}