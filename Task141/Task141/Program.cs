using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task141
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int iNum = int.Parse(Console.ReadLine());
            Console.Write("Введите систему счисления из следующих: " +
                "2 - двоичная, 8 - восьмеричная, 10 - десятичная, 16 - шестнадцатиричная:/n");
            int iNumSys = int.Parse(Console.ReadLine());
            switch(iNumSys)
            {
                case '2':

                    break;
                case '8':
                    Console.Write("2");
                    break;
                default:
                    break;

            }
        }
    }
}
