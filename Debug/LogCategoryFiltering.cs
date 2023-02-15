namespace MobX
{
    /// <summary>
    /// Log message filtering method types.
    /// </summary>
    public enum LogCategoryFiltering
    {
        /// <summary>
        /// Every category is enabled until it is explicitly disabled.
        /// </summary>
        ExplicitBlocking = 0,

        /// <summary>
        /// Every category is disabled until it is explicitly enabled.
        /// </summary>
        BlockedByDefault = 1,
    }
}