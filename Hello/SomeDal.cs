using System;

namespace Hello
{
	class SomeDal
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="SomeDal"/> class.
        /// </summary>
        public SomeDal(string name, string s = null) => Console.WriteLine("{0}-{1} DAL created.", name, s);

        /// <summary>
        /// Saves the specified <see cref="object"/>.
        /// </summary>
        public void Save(object o) => Console.WriteLine("{0} saved.", o);
    }
}
