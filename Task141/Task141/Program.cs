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
            //string[] sNumSys = {"BIN", "TRI", "OCT", "DEC", "HEX" };
            Console.Write("Введите число: ");
            int iNum = int.Parse(Console.ReadLine());
            Console.Write("Введите систему счисления из следующих: " +
                "BIN - двоичная, TRI - троичная, OCT - восьмеричная, DEC - десятичная, HEX - шестнадцатиричная:/n");
            string sNumSys = Console.ReadLine();
            switch(sNumSys)
            {
                case "BIN":

                    break;
                case "TRI":
                    Console.Write("2");
                    break;
                case "OCT":
                    break;
                case "DEC":
                    break;
                case "HEX":
                    break;
                default:
                    break;

            }
        }
    }
}
