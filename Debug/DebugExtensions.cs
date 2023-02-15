using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    /// <summary>
    /// Contains some extension methods for debugging.
    /// </summary>
    public static class DebugExtensions
    {
        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Block(this LogCategory logCategory, LogType logType = LogType.Log)
        {
            Debug.DisableLogCategory(logCategory, logType);
        }

        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Unblock(this LogCategory logCategory, LogType logType = LogType.Log)
        {
            Debug.EnableLogCategory(logCategory, logType);
        }

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void BlockWarning(this LogCategory logCategory)
        {
            Debug.DisableLogCategory(logCategory, LogType.Warning);
        }

        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void BlockError(this LogCategory logCategory)
        {
            Debug.DisableLogCategory(logCategory, LogType.Error);
        }

        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnblockWarning(this LogCategory logCategory)
        {
            Debug.EnableLogCategory(logCategory, LogType.Warning);
        }

        /// <summary>
        /// Block a <see cref="LogCategory"/>
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnblockError(this LogCategory logCategory)
        {
            Debug.EnableLogCategory(logCategory, LogType.Error);
        }
    }
}