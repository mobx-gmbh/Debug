namespace MobX
{
    /// <summary>
    /// Logging Verbosity.
    /// </summary>
    public enum Verbosity
    {
        /// <summary>
        /// Verbose logging.
        /// </summary>
        Verbose = 1,

        /// <summary>
        /// Message logging.
        /// </summary>
        Message = 2,

        /// <summary>
        /// Important message logging.
        /// </summary>
        Critical = 3,

        /// <summary>
        /// Warnings logging.
        /// </summary>
        Warning = 10,

        /// <summary>
        /// Error logging.
        /// </summary>
        Error = 11,

        /// <summary>
        /// Exception logging.
        /// </summary>
        Exception = 12,
    }
}