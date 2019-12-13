using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гуси_Лебеди.BaseClasses
{
    class Tree
    {
        private int height_in_meters;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Height_in_meters
        {
            get { return height_in_meters; }
            set
            {
                if (value > 0 && value < 120)
                {
                    height_in_meters = value;
                }
            }
        }
        public Tree(string name, string type, int height_in_meters)
        {
            this.Name = name;
            this.Type = type;
            this.Height_in_meters = height_in_meters;
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
