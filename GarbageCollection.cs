using System;
using System.Collections.Generic;
using System.Linq; //выражение запроса
using System.Text;
using System.Threading.Tasks;

namespace laba2._2_sorting_
{
    class GarbageCollection
    {
        public List<Garbage> alltypes { get; set; }

        public GarbageCollection()
        {
            alltypes = new List<Garbage>();
        }

        public void AddGarbage()
        {
            int number = 1;
            while (number != 0)
            {
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Paper paper = new Paper("папiр", 50, "аркуш/коробка");
                        alltypes.Add(paper);
                        continue;

                    case 2:
                        Plastic plastic = new Plastic("пластик", 60, "пластикова коробка/пляшка/обгортка/пакет");
                        alltypes.Add(plastic);
                        continue;

                    case 3:
                        Metal metal = new Metal("метал", 80, "металева банка");
                        alltypes.Add(metal);
                        continue;

                    case 4:
                        Glass glass = new Glass("скло", 70, "пляшка/лампа");
                        alltypes.Add(glass);
                        continue;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("введiть правильне число.");
                        continue;
                }

            }
        }

        public void Sort()
        {
            var sort = from p in alltypes
                       orderby p.Size
                       select p; 

            foreach (var p in sort)
                Console.WriteLine($"{p.Type}   розмiр: {p.Size}  назва: {p.Name}");
        }

        public void Content()
        {
            foreach (var sorting in alltypes)
                Console.WriteLine(sorting.ToString());
        }

    }
}
