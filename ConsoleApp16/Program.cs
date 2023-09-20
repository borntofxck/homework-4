using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum= a+b+c ; 
            int mult= a*b*c ;
            double average = (double)sum / 3;

            Console.WriteLine($"Сумма:{sum}");
            Console.WriteLine($"Произведение:{mult}");
            Console.WriteLine($"Среднее арифметическое: {average:F3}");


        }
    }
}
