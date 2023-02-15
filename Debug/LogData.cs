using JetBrains.Annotations;
using UnityEngine;

namespace MobX
{
    /// <summary>
    /// Contains data of a Debug.Log call.
    /// </summary>
    public readonly ref struct LogData<T>
    {
        /// <summary>
        /// Log category of the message.
        /// </summary>
        public readonly LogCategory Category;

        /// <summary>
        /// Contents of the logged message.
        /// </summary>
        public readonly T Message;

        /// <summary>
        /// The stacktrace of the message.
        /// </summary>
        public readonly string StackTrace;

        /// <summary>
        /// Log type of the message.
        /// </summary>
        public readonly LogType LogType;

        internal LogData(in LogCategory category, T message, string stackTrace, LogType logType)
        {
            Category = category;
            Message = message;
            StackTrace = stackTrace;
            LogType = logType;
        }

        /// <summary>
        /// Deconstructs the data object.
        /// </summary>
        [PublicAPI]
        public void Deconstruct(out LogCategory category, out T message, out string stackTrace, out LogType logType)
        {
            category = Category;
            message = Message;
            stackTrace = StackTrace;
            logType = LogType;
        }
    }
}