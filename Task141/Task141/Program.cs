using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task141
{
    class Program
    {
        static bool CorrectNum(string sNum) // числовое ли значение введено
        {
            if (sNum.Length - sNum.Replace(",", "").Replace(".", "").Length <= 1)
            {
                for (short i = 0; i < sNum.Length; i++)
                    if (!(Char.IsDigit(sNum, i)
                        || sNum[i] == ','
                        || sNum[i] == '.'))
                        return false;
                return true;
            }
            else
                return false;
        }
        static bool NumSys(string sNum, short sNumSys) // нахаодится ли число в заданной СС
        {
            for (short i = 0; i < sNum.Length; i++)
                if (Char.GetNumericValue(sNum[i]) >= sNumSys && !(sNum[i] == ',' || sNum[i] == '.'))
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string sNum = Console.ReadLine();
            Console.Write("Введите систему счисления из следующих: " +
                "BIN - двоичная, TRI - троичная, OCT - восьмеричная, DEC - десятичная:\n");
            string sNumSys = Console.ReadLine();
            if (CorrectNum(sNum))
            {
                switch (sNumSys)
                {
                    case "BIN":
                        if (NumSys(sNum, 2))
                            Console.WriteLine("Введено корректное число.");
                        else
                            Console.WriteLine("Введенное число некорректно!");
                        break;
                    case "TRI":
                        if (NumSys(sNum, 3))
                            Console.WriteLine("Введено корректное число.");
                        else
                            Console.WriteLine("Введенное число некорректно!");
                        break;
                    case "OCT":
                        if (NumSys(sNum, 8))
                            Console.WriteLine("Введено корректное число.");
                        else
                            Console.WriteLine("Введенное число некорректно!");
                        break;
                    case "DEC":
                        if (NumSys(sNum, 10))
                            Console.WriteLine("Введено корректное число.");
                        else
                            Console.WriteLine("Введенное число некорректно!");
                        break;
                    default:
                        Console.WriteLine("Неверно задана система счисления!");
                        break;
                }
            }
            else
                Console.WriteLine("Введенное число некорректно!");
            Console.ReadKey();
        }
    }
}
