using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.Division(2, 0);
            Console.ReadLine();
        }
    }
}
