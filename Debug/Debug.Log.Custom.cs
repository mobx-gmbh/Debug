using JetBrains.Annotations;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

namespace MobX
{
    public partial class Debug
    {
        #region Message

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(LogCategory category, string message, Object context = null)
        {
            LogMessageInternal(category, message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(LogCategory category, object message, Object context = null)
        {
            LogMessageInternal(category, message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, T message, Object context = null) where T : struct
        {
            LogMessageInternal(category, message, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(LogCategory category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(LogCategory category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string category, string message, Object context = null)
        {
            LogMessageInternal(category, message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string category, object message, Object context = null)
        {
            LogMessageInternal(category, message, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, T message, Object context = null) where T : struct
        {
            LogMessageInternal(category, message, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log(string category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Enumerable

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption, Object context)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, SEPARATOR, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, SEPARATOR, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, SEPARATOR, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_MESSAGE")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, LogOption logOption, Object context)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, SEPARATOR, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, SEPARATOR, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, IEnumerable<T> enumerable, string separator = SEPARATOR,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, SEPARATOR, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = SEPARATOR, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, separator, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, IEnumerable<T> enumerable, LogOption logOption, Object context)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, SEPARATOR, context);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Warning

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(LogCategory category, string warning, Object context = null)
        {
            LogWarningInternal(category, warning, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(LogCategory category, object warning, Object context = null)
        {
            LogWarningInternal(category, warning, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, T warning, Object context = null) where T : struct
        {
            LogWarningInternal(category, warning, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(LogCategory category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(LogCategory category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(LogCategory category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(string category, string warning, Object context = null)
        {
            LogWarningInternal(category, warning, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(string category, object warning, Object context = null)
        {
            LogWarningInternal(category, warning, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs a warning message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="warning">String to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, T warning, Object context = null) where T : struct
        {
            LogWarningInternal(category, warning, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(string category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning(string category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_WARNING")]
        public static void LogWarning<T>(string category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context);
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------------


        #region Error

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(LogCategory category, string error, Object context = null)
        {
            LogErrorInternal(category, error, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(LogCategory category, object error, Object context = null)
        {
            LogErrorInternal(category, error, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, T error, Object context = null) where T : struct
        {
            LogErrorInternal(category, error, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(LogCategory category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(LogCategory category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(LogCategory category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(string category, string error, Object context = null)
        {
            LogErrorInternal(category, error, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(string category, object error, Object context = null)
        {
            LogErrorInternal(category, error, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="error">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, T error, Object context = null) where T : struct
        {
            LogErrorInternal(category, error, context);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(string category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError(string category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("LOG_VERBOSITY_ERROR")]
        public static void LogError<T>(string category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context);
        }

        #endregion
    }
}