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
            Fanto Fan1 = new Fanto(true,3,10, "yellow");
            Fan1.ToString();
            Fanto Fan2 = new Fanto(false, 2, 5, "blue");
            Fan2.ToString();
            Console.ReadLine();
        }
    }
}
