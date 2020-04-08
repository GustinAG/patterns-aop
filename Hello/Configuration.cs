using System;

namespace Hello
{
    /// <summary>
    /// Holds configuration settings.
    /// </summary>
    internal static class Configuration
    {
        /// <summary>
        /// Gets a value indicating whether to rethrow the exceptions.
        /// </summary>
        internal static bool Rethrow => new Random((int)DateTime.Now.Ticks).Next(100) > 99;
    }
}
