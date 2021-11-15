using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.creational
{
    namespace singleton
    {
        /// <summary>
        /// Not thread safe
        /// </summary>
        public class Singleton
        {
            private static Singleton instance;
            public string Name { get; private set; }

            protected Singleton(string name) => this.Name = name;
            public static Singleton getInstance(string name)
            {
                if (instance == null)
                {
                    instance = new Singleton(name);
                }
                return instance;
            }


        }
    }
}
