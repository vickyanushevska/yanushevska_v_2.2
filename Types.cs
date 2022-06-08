using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._2_sorting_
{
        class Paper : Garbage
        {
          public Paper(string type, int size, string name) : base(type, size, name) { }
        }

        class Plastic : Garbage
        {
            public Plastic(string type, int size, string name) : base(type, size, name) { }
        }

        class Glass : Garbage
        {
            public Glass(string type, int size, string name) : base(type, size, name) { }
        }

        class Metal : Garbage
        {
            public Metal(string type, int size, string name) : base(type, size, name) { }
        }
}

