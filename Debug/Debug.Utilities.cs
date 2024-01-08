using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using File = System.IO.File;

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
        private const string Separator = ", ";

        private static Dictionary<LogType, HashSet<LogCategory>> blockedLogCategories =
            new Dictionary<LogType, HashSet<LogCategory>>()
            {
                {LogType.Log, new HashSet<LogCategory>(16)},
                {LogType.Warning, new HashSet<LogCategory>(16)},
                {LogType.Error, new HashSet<LogCategory>(16)},
                {LogType.Exception, new HashSet<LogCategory>(16)},
                {LogType.Assert, new HashSet<LogCategory>(16)}
            };

        private static Dictionary<LogType, HashSet<LogCategory>> unblockedLogCategories =
            new Dictionary<LogType, HashSet<LogCategory>>()
            {
                {LogType.Log, new HashSet<LogCategory>(16)},
                {LogType.Warning, new HashSet<LogCategory>(16)},
                {LogType.Error, new HashSet<LogCategory>(16)},
                {LogType.Exception, new HashSet<LogCategory>(16)},
                {LogType.Assert, new HashSet<LogCategory>(16)}
            };

        /// <summary>
        /// Get disabled log categories.
        /// </summary>
        [PublicAPI]
        public static IReadOnlyCollection<LogCategory> BlockedLogCategories(LogType logType = LogType.Log)
        {
            return blockedLogCategories[logType];
        }

        /// <summary>
        /// Get enabled log categories.
        /// </summary>
        [PublicAPI]
        public static IReadOnlyCollection<LogCategory> UnblockedLogCategories(LogType logType = LogType.Log)
        {
            return unblockedLogCategories[logType];
        }

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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        /// <summary>
        /// Combines two strings with minimal allocation.
        /// </summary>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string CreateLogCategoryMessageNoAlloc(LogCategory category, string message, Color color)
        {
            var categoryBuffer = (ReadOnlySpan<char>) category.Name;
            var messageBuffer = (ReadOnlySpan<char>) message;

            const int ColorCodeLength = 8; // RGBA in HTML format.
            var totalLength = categoryBuffer.Length + messageBuffer.Length + 3 + 17 + ColorCodeLength; // 3 for "[ ] ", 17 for "<color=#></color>", 8 for color code

            Span<char> resultBuffer = stackalloc char[totalLength]; // Adjust size as needed

            var index = 0;

            // Insert opening color tag
            "<color=#".AsSpan().CopyTo(resultBuffer.Slice(index, 8));
            index += 8;

            ColorUtility.ToHtmlStringRGBA(color).AsSpan().CopyTo(resultBuffer.Slice(index, ColorCodeLength));
            index += ColorCodeLength;

            resultBuffer[index++] = '>';

            // Insert log category
            resultBuffer[index++] = '[';
            categoryBuffer.CopyTo(resultBuffer.Slice(index, categoryBuffer.Length));
            index += categoryBuffer.Length;
            resultBuffer[index++] = ']';

            // Insert closing color tag
            "</color>".AsSpan().CopyTo(resultBuffer.Slice(index, 8));
            index += 8;

            // Insert space
            resultBuffer[index++] = ' ';

            // Insert message
            messageBuffer.CopyTo(resultBuffer.Slice(index, messageBuffer.Length));

            return new string(resultBuffer);
        }

        /// <summary>
        /// Load blocked and unblocked data.
        /// </summary>
        [PublicAPI]
        private static void LoadEditorData()
        {
            if (!Application.isEditor)
            {
                return;
            }
            var path = $"{Application.dataPath.Replace("Assets", "Library")}/MobXDebug.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var data = JsonUtility.FromJson<DebugSettingsData>(json);
                blockedLogCategories = data.BlockedLogCategories;
                unblockedLogCategories = data.UnblockedLogCategories;
            }
        }

        /// <summary>
        /// Save blocked and unblocked data.
        /// </summary>
        [PublicAPI]
        public static void SaveEditorData()
        {
            if (!Application.isEditor)
            {
                return;
            }
            var path = $"{Application.dataPath.Replace("Assets", "Library")}/MobXDebug.json";
            var data = new DebugSettingsData
            {
                BlockedLogCategories = blockedLogCategories,
                UnblockedLogCategories = unblockedLogCategories
            };
            var json = JsonUtility.ToJson(data, true);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Colorize the passed string
        /// </summary>
        /// <param name="content"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Colorize(this string content, Color color)
        {
            // Calculate the length needed for the final string.
            var colorCodeLength = 8; // RGBA in HTML format.
            var contentLength = content.Length;
            var totalLength = 17 + colorCodeLength + contentLength; // Length of "<color=#></color>" + color code + content.

            // Use stack-allocated memory if the string is small.
            var span = totalLength <= 128 ? stackalloc char[totalLength] : new char[totalLength];

            "<color=#".AsSpan().CopyTo(span.Slice(0, 8));

            ColorUtility.ToHtmlStringRGBA(color).AsSpan().CopyTo(span.Slice(8, colorCodeLength));

            ">".AsSpan().CopyTo(span.Slice(8 + colorCodeLength, 1));
            content.AsSpan().CopyTo(span.Slice(9 + colorCodeLength, contentLength));
            "</color>".AsSpan().CopyTo(span.Slice(9 + colorCodeLength + contentLength));

            return new string(span);
        }

        /// <summary>
        /// Colorize the passed string
        /// </summary>
        /// <param name="content"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Colorize(this Span<char> content, Color color)
        {
            // Calculate the length needed for the final string.
            var colorCodeLength = 8; // RGBA in HTML format.
            var contentLength = content.Length;
            var totalLength = 17 + colorCodeLength + contentLength; // Length of "<color=#></color>" + color code + content.

            // Use stack-allocated memory if the string is small.
            var span = totalLength <= 128 ? stackalloc char[totalLength] : new char[totalLength];

            "<color=#".AsSpan().CopyTo(span.Slice(0, 8));

            ColorUtility.ToHtmlStringRGBA(color).AsSpan().CopyTo(span.Slice(8, colorCodeLength));

            ">".AsSpan().CopyTo(span.Slice(8 + colorCodeLength, 1));
            content.CopyTo(span.Slice(9 + colorCodeLength, contentLength));
            "</color>".AsSpan().CopyTo(span.Slice(9 + colorCodeLength + contentLength));

            return new string(span);
        }
    }
}