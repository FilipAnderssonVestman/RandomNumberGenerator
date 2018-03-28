using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random Nuber Generator";
            var menu = new Menu();
            menu.Start();
        }
    }
}
