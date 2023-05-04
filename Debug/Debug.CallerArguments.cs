using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        #region Caller Arguments

        /// <summary>
        /// Returns the callers line number as an integer, captured at compile time.
        /// </summary>
        /// <param name="lineNumber">Buffer used by compiler</param>
        /// <returns>The current line number at compile time.</returns>
        public static int LineNumber([CallerLineNumber] int lineNumber = default)
        {
            return lineNumber;
        }

        /// <summary>
        /// Returns the callers member name, captured at compile time.
        /// </summary>
        /// <param name="memberName">Buffer used by compiler</param>
        /// <returns>The name of the method or property calling this method.</returns>
        public static string MemberName([CallerMemberName] string memberName = default)
        {
            return memberName;
        }

        /// <summary>
        /// Returns the callers member name, captured at compile time.
        /// </summary>
        /// <param name="memberName">Buffer used by compiler</param>
        /// <returns>The name of the method or property calling this method.</returns>
        public static string MethodName([CallerMemberName] string memberName = default)
        {
            return memberName;
        }

        /// <summary>
        /// Returns the callers file path, captured at compile time.
        /// </summary>
        /// <param name="filePath">Buffer used by compiler</param>
        /// <returns>The current file path at compile time.</returns>
        public static string FilePath([CallerFilePath] string filePath = default)
        {
            return filePath;
        }

        #endregion


        #region Log Line

        /// <summary>
        /// prefix used when calling <see cref="LogLine(UnityEngine.LogOption,UnityEngine.Object,int)"/>
        /// </summary>
        public static string LinePrefix { get; set; } = "Line: ";

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(LogOption logOption, Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, logOption, $"{LinePrefix}{line.ToString()}", null, context);
        }

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, LogOption.None, $"{LinePrefix}{line.ToString()}", null, context);
        }

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(LogCategory category, LogOption logOption, Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{LinePrefix}{line.ToString()}", null, context);
        }

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(LogCategory category, Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{LinePrefix}{line.ToString()}", null, context);
        }

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(string category, LogOption logOption, Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{LinePrefix}{line.ToString()}", null, context);
        }

        /// <summary>
        /// The current line number at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="line"></param>
        public static void LogLine(string category, Object context = null, [CallerLineNumber] int line = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{LinePrefix}{line.ToString()}", null, context);
        }

        #endregion


        #region Log Member

        /// <summary>
        /// prefix used when calling <see cref="LogMember(UnityEngine.LogOption,UnityEngine.Object,string)"/>
        /// </summary>
        public static string MemberPrefix { get; set; } = "Member: ";

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(LogOption logOption, Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, logOption, $"{MemberPrefix}{member}", null, context);
        }

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, LogOption.None, $"{MemberPrefix}{member}", null, context);
        }

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(LogCategory category, LogOption logOption, Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{MemberPrefix}{member}", null, context);
        }

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(LogCategory category, Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{MemberPrefix}{member}", null, context);
        }

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(string category, LogOption logOption, Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{MemberPrefix}{member}", null, context);
        }

        /// <summary>
        /// Log the callers member name at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="member"></param>
        public static void LogMember(string category, Object context = null, [CallerMemberName] string member = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{MemberPrefix}{member}", null, context);
        }

        #endregion


        #region Log File Path

        /// <summary>
        /// prefix used when calling <see cref="LogFile(UnityEngine.LogOption,UnityEngine.Object,string)"/>
        /// </summary>
        public static string FilePrefix { get; set; } = "File Path: ";

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(LogOption logOption, Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, logOption, $"{FilePrefix}{path}", null, context);
        }

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(LogCategory.Log, LogType.Log, LogOption.None, $"{FilePrefix}{path}", null, context);
        }

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(LogCategory category, LogOption logOption, Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{FilePrefix}{path}", null, context);
        }

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(LogCategory category, Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{FilePrefix}{path}", null, context);
        }

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="logOption"></param>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(string category, LogOption logOption, Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(category, LogType.Log, logOption, $"{FilePrefix}{path}", null, context);
        }

        /// <summary>
        /// Log the callers file path name captured at compile time.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="context"></param>
        /// <param name="path"></param>
        public static void LogFile(string category, Object context = null, [CallerFilePath] string path = default)
        {
            LogFormatInternal(category, LogType.Log, LogOption.None, $"{FilePrefix}{path}", null, context);
        }

        #endregion
    }
}