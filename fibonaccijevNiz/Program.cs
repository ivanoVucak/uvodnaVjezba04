using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaccijevNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brojN = 0;
            int rezultat = 0;
            int prethodni = 1;
            int prethodni2 = 0;

            Console.Write("Upiši broj n: ");
            brojN = Convert.ToInt32(Console.ReadLine());

            if (brojN == 0) {
                Console.WriteLine("Rezultat tog fabonacijevog niza je 0");
            }
            if (brojN == 1) {
                Console.WriteLine("Rezultat tog fabonacijevog niza je 1");
            }
            if (brojN > 1) {
                for (int i = 1; i < brojN; i++) {
                    rezultat = prethodni + prethodni2;
                    prethodni2 = prethodni;
                    prethodni = rezultat;
                }
                Console.WriteLine("Rezultat tog fabonacijevog nizda je " + rezultat);
            }

            Console.ReadKey();

        }
    }
}
