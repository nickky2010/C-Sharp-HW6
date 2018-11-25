//  Класс квадратов должен содержать следующие элементы:  
//      поле-сторону квадрата, 
//      конструктор, 
//      реализованные элементы интерфейса, 
//      метод вычисления периметра.

using System;

namespace HW6_2
{
    class Square : IGeometricFigures
    {
        //  поле-сторону квадрата
        double side;
        public double Side
        {
            get => side;
            set
            {
                if (value > 0)
                    side = value;
                else
                    throw new Exception("Сторона квадрата не может быть меньше либо равна нулю");
            }
        }
        //  конструктор
        public Square(double side)
        {
            Side = side;
        }
        //  реализованные элементы интерфейса 
        public int CompareTo(object obj)
        {
            Square s = obj as Square;
            if (s != null)
                return (this.GetSquare().CompareTo(s.GetSquare()));
            return 1;
        }

        public double GetSquare()
        {
            return (side*side);
        }

        public void Print()
        {
            Console.WriteLine("Фигура Square:\n\tside = " + side + "\n\tsquare = " + GetSquare());
        }

        public override string ToString()
        {
            return ("Фигура Square:\n\tside = " + side + "\n\tsquare = " + GetSquare());
        }
    }
}
