using System;

namespace Hello
{
    internal class GoodClass
    {
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoodClass"/> class.
        /// </summary>
        /// <param name="name">The name of this instance.</param>
        public GoodClass(string name) => _name = name;

        [ExceptionLogging]
        internal void DoSomething(int i)
        {
            var dal = new SomeDal(_name);
            dal.Save(i);
        }

        [ExceptionLogging]
        internal void DoSomethingElse(string s, DateTime d)
        {
            var dal = new SomeDal(_name, s);
            dal.Save(d);
        }
    }
}
