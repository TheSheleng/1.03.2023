using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03._2023
{
    internal class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public enum type
        {
            Grocery,
            Hardware,
            Clothing,
            Shoe,
        }
        public type Type { get; set; }

        Shop(string n, string a, type t) 
        {
            Name = n;
            Address = a;
            Type = t;

            Console.WriteLine("Магазин открыт");
        }
        ~Shop() 
        {
            Console.WriteLine("Маназин закрыт");
        }
        public void Dispose() 
        { 
            Console.WriteLine("Маназин закрыт"); 
        }
    }
}
