using System;
using System.Diagnostics;

namespace Hello
{
    internal class BadClass
    {
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="BadClass"/> class.
        /// </summary>
        /// <param name="name">The name of this instance.</param>
        public BadClass(string name) => _name = name;

        internal void DoSomething(int i)
        {
            const string methodName = "DoSomething";
            var args = new object[] { i };
            Log.LogMethodCall(TraceLevel.Verbose, methodName, args);

            try
            {
                var dal = new SomeDal(_name);
                dal.Save(i);
            }
            catch (Exception e)
            {
                Log.LogException(methodName, args, e);
                if (Configuration.Rethrow) throw;
            }
        }

        internal void DoSomethingElse(string s, DateTime d)
        {
            const string methodName = "DoSomethingElse";
            var args = new object[] { s, d };
            Log.LogMethodCall(TraceLevel.Verbose, methodName, args);

            try
            {
                var dal = new SomeDal(_name, s);
                dal.Save(d);
            }
            catch (Exception e)
            {
                Log.LogException(methodName, args, e);
                if (Configuration.Rethrow) throw;
            }
        }
    }
}
