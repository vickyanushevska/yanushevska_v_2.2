using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._2_sorting_
{
    class Garbage
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }

        public Garbage(string type, int size, string name)
        {
            Type = type;
            Name = name;
            Size = size;
        }

        public override string ToString() { 
            return $"{Type}   розмiр: {Size}  назва: {Name}";
        }
    }
}

