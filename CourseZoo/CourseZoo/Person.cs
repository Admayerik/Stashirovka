using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZoo
{
    internal abstract class Person : IView
    {
        public string Name { get; protected set; }
        public Person(string name)
        {
            Name = name;
        }

        public abstract void Info();
    }
}
