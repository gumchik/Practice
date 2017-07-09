using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVarA, iVarB, iVarC;
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("Сторона a = ");
            iVarA = int.Parse(Console.ReadLine());
            Console.Write("Сторона b = ");
            iVarB = int.Parse(Console.ReadLine());
            Console.Write("Сторона c = ");
            iVarC = int.Parse(Console.ReadLine());
            if ((iVarA + iVarB > iVarC) && (iVarA + iVarC > iVarB) && (iVarB + iVarC > iVarA))
            {
                if (Math.Pow(iVarA, 2) + Math.Pow(iVarB, 2) == Math.Pow(iVarC, 2)
                    || Math.Pow(iVarA, 2) + Math.Pow(iVarC, 2) == Math.Pow(iVarB, 2)
                    || Math.Pow(iVarB, 2) + Math.Pow(iVarC, 2) == Math.Pow(iVarA, 2))
                    Console.WriteLine("Треугольник прямоугольный.");
                else if (Math.Pow(iVarA, 2) + Math.Pow(iVarB, 2) < Math.Pow(iVarC, 2)
                    || Math.Pow(iVarA, 2) + Math.Pow(iVarC, 2) < Math.Pow(iVarB, 2)
                    || Math.Pow(iVarB, 2) + Math.Pow(iVarC, 2) < Math.Pow(iVarA, 2))
                    Console.WriteLine("Треугольник тупоугольный.");
                else
                    Console.WriteLine("Треугольник остроугольный.");
            }
            else
                Console.WriteLine("Заданный треугольник не существует!");
            Console.ReadKey();
        }
    }
}
