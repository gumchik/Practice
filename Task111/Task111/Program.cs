using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    class Program
    {
        static void Main(string[] args)
        {
            float fNumA, fNumB;
            Console.Write("Введите первое число: ");
            fNumA = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            fNumB = float.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое чисел: " + (fNumA + fNumB) / 2);
            Console.WriteLine("Среднее геометрическое чисел: " + Math.Sqrt(fNumA * fNumB));
            Console.ReadKey();
        }
    }
}
