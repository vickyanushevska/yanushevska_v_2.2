using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._2_sorting_
{
    class main
    
    {
       static void Main(string[] args)
        {
            Garbage[] sortings =
            {
                new Garbage("папiр", 50,"аркуш/коробка"),
                new Garbage ("пластик",60, "пластикова коробка/пляшка/обгортка/пакет"),
                new Garbage("метал", 80,"металева банка"),
                new Garbage("скло", 70, "пляшка/лампа")
            };

            Console.WriteLine("Види смiття для сортування:");

            for (int i = 0; i < sortings.Length; i++)
            {
                Console.WriteLine($"{i + 1}. " + sortings[i]);
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("який тип смiття Ви хочете сортувати?\nвведiть 0 для зупинки");
            GarbageCollection garbage = new GarbageCollection();
            garbage.AddGarbage();
            Console.WriteLine("-----------------------------------------------------------");
            garbage.Content();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("вiдсортоване смiття:");
            garbage.Sort();
        }
    }
}
