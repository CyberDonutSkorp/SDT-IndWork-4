using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smst_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sub;
            Console.WriteLine($"Ведите кооличество первых чисел Мерсенна которое хотите увидеть");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Следует писать натуральные числа и не больше 2 147 483 647, программа выведет 1 число Мерсенна");
                n = 1;
            }
            Console.WriteLine($"Список первых {n} чисел Мерсенна");
            for (double i = 1; i < n+1; i++)
            {
                sub = Math.Pow(2, i) - 1;
                Console.WriteLine(sub);
            }
            Console.ReadKey();
        }
    }
}
