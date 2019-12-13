using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуси_Лебеди.Subclasses
{
    class Child : BaseClasses.Human, Interfaces.IChild
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public void Speaking()
        {
            Console.WriteLine();
        }
    }
}
