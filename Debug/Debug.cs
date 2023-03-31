using JetBrains.Annotations;
using System.Diagnostics;
using UnityEngine;

// ReSharper disable InconsistentNaming

namespace MobX
{
    /// <summary>
    /// Advanced Logging utilities
    /// </summary>
    public static partial class Debug
    {
        /// <summary>
        ///   <para>Get default debug logger.</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static ILogger unityLogger => UnityEngine.Debug.unityLogger;

        /// <summary>
        ///   <para>Pauses the editor.</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static void Break()
        {
            UnityEngine.Debug.Break();
        }

        /// <summary>
        /// <para>Pauses the editor.</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static void DebugBreak()
        {
            UnityEngine.Debug.DebugBreak();
        }

        /// <summary>
        ///   <para>Populate an unmanaged buffer with the current managed call stack as a sequence of UTF-8 bytes, without allocating GC memory. Returns the number of bytes written into the buffer.</para>
        /// </summary>
        /// <param name="buffer">Target buffer to receive the callstack text</param>
        /// <param name="bufferMax">Max number of bytes to write</param>
        /// <param name="projectFolder">Project folder path, to clean up path names</param>
        [PublicAPI]
        [DebuggerHidden]
        public static unsafe int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
        {
            return UnityEngine.Debug.ExtractStackTraceNoAlloc(buffer, bufferMax, projectFolder);
        }

        /// <summary>
        ///   <para>Clears errors from the developer console.</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static void ClearDeveloperConsole() => UnityEngine.Debug.ClearDeveloperConsole();

        /// <summary>
        ///   <para>Reports whether the development console is visible. The development console cannot be made to appear using:</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static bool developerConsoleVisible
        {
            get => UnityEngine.Debug.developerConsoleVisible;
            set => UnityEngine.Debug.developerConsoleVisible = value;
        }

        /// <summary>
        ///   <para>In the Build Settings dialog there is a check box called "Development Build".</para>
        /// </summary>
        [PublicAPI]
        [DebuggerHidden]
        public static bool isDebugBuild => UnityEngine.Debug.isDebugBuild;

        /// <summary>
        /// Static ctor
        /// </summary>
        static Debug()
        {
            LoadEditorData();
        }
    }
}