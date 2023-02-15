using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MobX
{
    public static partial class Debug
    {
        /// <summary>
        /// Get or set the active log filtering method.
        /// </summary>
        [PublicAPI]
        public static LogCategoryFiltering CategoryFiltering { get; set; } = LogCategoryFiltering.ExplicitBlocking;

        /// <summary>
        /// Default collection item separation character.
        /// </summary>
        private const string SEPARATOR = ", ";

        private static readonly Dictionary<LogType, HashSet<LogCategory>> blockedLogCategories =
            new Dictionary<LogType, HashSet<LogCategory>>()
            {
                {LogType.Log, new HashSet<LogCategory>(16)},
                {LogType.Warning, new HashSet<LogCategory>(16)},
                {LogType.Error, new HashSet<LogCategory>(16)},
                {LogType.Exception, new HashSet<LogCategory>(16)},
                {LogType.Assert, new HashSet<LogCategory>(16)}
            };

        private static readonly Dictionary<LogType, HashSet<LogCategory>> unblockedLogCategories =
            new Dictionary<LogType, HashSet<LogCategory>>()
            {
                {LogType.Log, new HashSet<LogCategory>(16)},
                {LogType.Warning, new HashSet<LogCategory>(16)},
                {LogType.Error, new HashSet<LogCategory>(16)},
                {LogType.Exception, new HashSet<LogCategory>(16)},
                {LogType.Assert, new HashSet<LogCategory>(16)}
            };

        /// <summary>
        /// Reset enabled and disabled log categories.
        /// </summary>
        [PublicAPI]
        public static void ResetLogCategories()
        {
            ResetBlockedLogCategories();
            ResetUnblockedLogCategories();
        }

        /// <summary>
        /// Reset disabled log categories.
        /// </summary>
        [PublicAPI]
        public static void ResetBlockedLogCategories()
        {
            foreach (var (_, set) in blockedLogCategories)
            {
                set.Clear();
            }
        }

        /// <summary>
        /// Reset enabled log categories.
        /// </summary>
        [PublicAPI]
        public static void ResetUnblockedLogCategories()
        {
            foreach (var (_, set) in unblockedLogCategories)
            {
                set.Clear();
            }
        }

        /// <summary>
        /// When true, logType messages of the specified category are suppressed during runtime.
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLogCategoryBlocked(LogCategory category, LogType logType = LogType.Log)
        {
            return CategoryFiltering switch
            {
                LogCategoryFiltering.ExplicitBlocking => blockedLogCategories[logType].Contains(category),
                LogCategoryFiltering.BlockedByDefault => !unblockedLogCategories[logType].Contains(category),
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        /// <summary>
        /// Block a <see cref="LogCategory"/>, preventing logs from being processed during runtime.
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DisableLogCategory(LogCategory category, LogType logType = LogType.Log)
        {
            blockedLogCategories[logType].Add(category);
            unblockedLogCategories[logType].Remove(category);
        }

        /// <summary>
        /// Unblock a <see cref="LogCategory"/>, preventing logs from being processed during runtime.
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void EnableLogCategory(LogCategory category, LogType logType = LogType.Log)
        {
            blockedLogCategories[logType].Remove(category);
            unblockedLogCategories[logType].Add(category);
        }

        /// <summary>
        /// Combines two strings with minimal allocation.
        /// </summary>
        [PublicAPI]
        public static string CreateLogCategoryMessageNoAlloc(LogCategory category, string message)
        {
            var categoryBuffer = (ReadOnlySpan<char>) category.Name;
            var messageBuffer = (ReadOnlySpan<char>) message;

            Span<char> resultBuffer = stackalloc char[categoryBuffer.Length + messageBuffer.Length + 3];

            var index = 0;
            resultBuffer[index++] = '[';
            categoryBuffer.CopyTo(resultBuffer.Slice(index, categoryBuffer.Length));
            index += categoryBuffer.Length;
            resultBuffer[index++] = ']';
            resultBuffer[index++] = ' ';
            messageBuffer.CopyTo(resultBuffer.Slice(index, messageBuffer.Length));

            return resultBuffer.ToString();
        }
    }
}