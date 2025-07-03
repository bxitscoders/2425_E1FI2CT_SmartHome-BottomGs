using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string erg = string.Format("{0:C}", 20.4) + '€';
            Console.WriteLine(erg);
        }
    }
}
