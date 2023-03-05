using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._2023
{
    internal class TheaterPlay : IDisposable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public TheaterPlay(string n, string a, string g, int y) 
        { 
            Name = n;
            Author = a;
            Genre = g;
            Year = y;

            Console.WriteLine("Пьеса началась");
        }
        ~TheaterPlay()
        {
            Console.WriteLine("Пьеса закончилась");
        }
        public void Dispose() 
        {
            Console.WriteLine("Пьеса закончилась");
        }
        public void Play()
        {
            Console.WriteLine("Пьеса идёт");
        }
    }
}
