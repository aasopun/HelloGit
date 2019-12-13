using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуси_Лебеди.BaseClasses
{
    class Building
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Building(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public string Say(string words)
        {
            return words;
        }
        public string Do(string words)
        {
            return words;
        }
    }
}
