using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуси_Лебеди.BaseClasses
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string Say(string words)
        {
            return words;
        }
        public virtual string Do(string words)
        {
            return words;
        }
    }
}
