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
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, string message, Verbosity verbosity)
        {
            LogMessageInternal(category, message, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, object message, Verbosity verbosity)
        {
            LogMessageInternal(category, message, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, T message, Verbosity verbosity) where T : struct
        {
            LogMessageInternal(category, message, null, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, string message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, object message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, T message, Object context = null, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, string message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, object message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, T message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, string message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, object message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, T message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, string message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(LogCategory category, object message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, T message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, string message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, object message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, T message, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            LogMessageInternal(category, message, context, color, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, string message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, object message, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, T message, Object context = null, Verbosity verbosity = Verbosity.Verbose) where T : struct
        {
            LogMessageInternal(category, message, context, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, string message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, object message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="color">Log category color</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, T message, LogOption logOption, Color color, Object context = null, Verbosity verbosity = Verbosity.Verbose)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, string message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log(string category, object message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, T message, LogOption logOption, Object context = null, Verbosity verbosity = Verbosity.Verbose)
            where T : struct
        {
            LogFormatInternal(category, LogType.Log, logOption, message, null, context, verbosity);
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
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, Separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, Separator, context, verbosity);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, separator, context, Verbosity.Warning);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, Separator, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, separator, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, Separator, context, Verbosity.Warning);
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
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, separator, context, Verbosity.Error);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, Separator, context, Verbosity.Error);
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
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, separator, context, Verbosity.Error);
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
        public static void LogError<T>(LogCategory category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, Separator, context, Verbosity.Error);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, enumerable, Separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="separator">String separating enumerable elements</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, separator, context, verbosity);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="logOption">Additional log options.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="verbosity">The logging verbosity level</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void Log<T>(string category, IEnumerable<T> enumerable, LogOption logOption, Object context, Verbosity verbosity = Verbosity.Verbose)
        {
            LogFormatInternal(category, LogType.Log, logOption, enumerable, Separator, context, verbosity);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, separator, context, Verbosity.Warning);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        [Conditional("DEBUG")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Warning, LogOption.None, enumerable, Separator, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, separator, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            Object context)
        {
            LogFormatInternal(category, LogType.Warning, logOption, enumerable, Separator, context, Verbosity.Warning);
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
        public static void LogError<T>(string category, IEnumerable<T> enumerable, string separator = Separator,
            Object context = null)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, separator, context, Verbosity.Error);
        }

        /// <summary>
        ///   <para>Logs a message to the Unity Console.</para>
        /// </summary>
        /// <param name="category">Custom log category.</param>
        /// <param name="enumerable">Enumerable to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogError<T>(string category, IEnumerable<T> enumerable, Object context)
        {
            LogFormatInternal(category, LogType.Error, LogOption.None, enumerable, Separator, context, Verbosity.Error);
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
        public static void LogError<T>(string category, IEnumerable<T> enumerable, LogOption logOption,
            string separator = Separator, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, separator, context, Verbosity.Error);
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
        public static void LogError<T>(string category, IEnumerable<T> enumerable, LogOption logOption, Object context)
        {
            LogFormatInternal(category, LogType.Error, logOption, enumerable, Separator, context, Verbosity.Error);
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
        public static void LogWarning(LogCategory category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning(LogCategory category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(LogCategory category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
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
        [Conditional("DEBUG")]
        public static void LogWarning(string category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning(string category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        [Conditional("DEBUG")]
        public static void LogWarning<T>(string category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Warning, logOption, message, null, context, Verbosity.Warning);
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
        public static void LogError(LogCategory category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
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
        public static void LogError(LogCategory category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
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
        public static void LogError<T>(LogCategory category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
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
        public static void LogError(string category, string message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
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
        public static void LogError(string category, object message, LogOption logOption, Object context = null)
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
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
        public static void LogError<T>(string category, T message, LogOption logOption, Object context = null)
            where T : struct
        {
            LogFormatInternal(category, LogType.Error, logOption, message, null, context, Verbosity.Error);
        }

        #endregion
    }
}