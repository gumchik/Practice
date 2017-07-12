using System;
using System.Text;

namespace Task211
{
    class Point
    {
        int _iX;
        int _iY;
        int _iDistOfOrigin;
        public Point(int iX, int iY) // конструктор 
        {
            _iX = iX;
            _iY = iY;
            _iDistOfOrigin = (int)Math.Sqrt(Math.Pow(_iX, 2) + Math.Pow(_iY, 2));
        }
        public void Show()
        {
            Console.WriteLine("Точка ({0}, {1}).", _iX, _iY);
        }
        public void OnAxis()
        {
            if (_iX == 0 && _iY == 0)
                Console.WriteLine("Точка лежит в начале координат.");
            else if (_iY == 0)
                Console.WriteLine("Точка лежит на оси Х.");
            else if (_iX == 0)
                Console.WriteLine("Точка лежит на оси Y.");
            else
                Console.WriteLine("Точка не лежит на осях координат.");
        }
        public void ShiftPoint(int iShX, int iShY)
        {
            _iX += iShX;
            _iY += iShY;
        }

    }
}