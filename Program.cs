using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a nullát.");
            try
            {
                double nulla;
                do
                {
                    nulla = double.Parse(Console.ReadLine());
                    if (nulla!=0)
                    {
                        Console.WriteLine("A szám nem jó");
                    }
                    else
                    {
                        Console.WriteLine("elég");
                    }
                } while (nulla != 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Számot adj meg");
            }
            Console.ReadKey();
        }
    }
}
