using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hello
{
    /// <summary>
    /// Provides logging functionality.
    /// </summary>
    internal static class Log
    {
        /// <summary>
        /// Logs the given exception occured in the given method.
        /// </summary>
        /// <param name="methodName">The method's name.</param>
        /// <param name="args">The method's args.</param>
        /// <param name="e">The exception to log.</param>
        internal static void LogException(string methodName, IEnumerable<object> args, Exception e) => LogMsg(TraceLevel.Error, methodName, args, e);

        /// <summary>
        /// Logs the given method call.
        /// </summary>
        /// <param name="level">The tracing level.</param>
        /// <param name="name">The method's name.</param>
        /// <param name="args">The method's args.</param>
        internal static void LogMethodCall(TraceLevel level, string name, IEnumerable<object> args) => LogMsg(level, name, args, "called");

        private static void LogMsg(TraceLevel level, string name, IEnumerable<object> args, object msg) =>
            Console.WriteLine("[{0}] {1}({2}) {3}.", level, name, args.Aggregate((a, b) => string.Format("{0}, {1}", a, b)), msg);
    }
}
