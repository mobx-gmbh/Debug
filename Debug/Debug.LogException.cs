using JetBrains.Annotations;
using System;
using System.Diagnostics;
using Object = UnityEngine.Object;

namespace MobX
{
    public static partial class Debug
    {
        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="exception">Runtime Exception.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogException(Exception exception, Object context = null)
        {
            UnityEngine.Debug.LogException(exception, context);
        }

        /// <summary>
        ///   <para>A variant of Debug.Log that logs an error message to the console.</para>
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="category"></param>
        /// <param name="exception">Runtime Exception.</param>
        [PublicAPI]
        [DebuggerHidden]
        public static void LogException(LogCategory category, Exception exception, Object context = null)
        {
            UnityEngine.Debug.LogException(exception, context);
        }
    }
}