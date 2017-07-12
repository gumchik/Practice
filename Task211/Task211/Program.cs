using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте точку:\n" +
                "Координата Х: ");
            int iX = int.Parse(Console.ReadLine());
            Console.Write("Координата Y: ");
            int iY = int.Parse(Console.ReadLine());
            Point newPoint = new Point(iX, iY);
            Console.WriteLine("Создано:");
            newPoint.Show();
            newPoint.OnAxis();
            Console.Write("Задайте смещение точки относительно текущих координат:\n" +
                "Смещение по оси Х: ");
            int iShX = int.Parse(Console.ReadLine());
            Console.Write("Смещение по оси Y: ");
            int iShY = int.Parse(Console.ReadLine());
            newPoint.ShiftPoint(iShX, iShY);
            Console.WriteLine("Новые координаты:");
            newPoint.Show();
            Console.ReadKey();
        }
    }
}
