using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fanto fanto1 = new Fanto(true,3,10, "yellow");
            fanto1.ToString();
            Fanto fanto2 = new Fanto(false, 2, 5, "blue");
            fanto2.ToString();
            Console.ReadLine();
        }
    }
}
