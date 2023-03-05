using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var play = new TheaterPlay("Адам и Ева", "М.А. Булгаков", "пьеса", 1931)) { play.Play(); }
        
            Console.ReadKey();
        }
    }
}
