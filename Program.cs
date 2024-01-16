using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKlase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;

            Console.WriteLine("Upisi recenicu");
            s1=Console.ReadLine();

            string zamjenznakova = s1.Replace(" ","_");
            Console.WriteLine(zamjenznakova);

            Console.ReadKey();
        }
    }
}
