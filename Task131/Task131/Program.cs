using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int iSize = int.Parse(Console.ReadLine());
            int[] iArr = new int[iSize];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < iSize; i++)
            {
                Console.Write("Элемент " + i + ": ");
                iArr[i] = int.Parse(Console.ReadLine());
            }
            int iMin = iArr[0],
                iInd = 0;
            for (int i = 1; i < iSize; i++)
                if (iArr[i] < iMin)
                {
                    iMin = iArr[i];
                    iInd = i;
                }
            Console.WriteLine("Минимальный элемент массива = " + iMin + ", его индекс " + iInd + ".");
            Console.ReadKey();
        }
    }
}
