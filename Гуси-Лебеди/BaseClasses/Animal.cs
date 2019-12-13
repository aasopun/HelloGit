using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуси_Лебеди.BaseClasses
{
    class Animal
    {
        private int count_of_foots;
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Count_of_foots
        {
            get { return count_of_foots; }
            set 
            {
                if (value > 0 && value < 5)
                {
                    count_of_foots = value;
                } 
            }
        }
        public Animal(string name, string type, int count_of_foots, string color)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
            this.Count_of_foots = count_of_foots;
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
