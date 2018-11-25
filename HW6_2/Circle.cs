//  Класс кругов должен содержать следующие элементы: 
//      поля - радиус, цвет фигуры, 
//      конструктор, 
//      реализованные элементы интерфейса.

using System;

namespace HW6_2
{
    class Circle: IGeometricFigures
    {
        //  поля - радиус, цвет фигуры
        double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new Exception("Радиус круга не может быть меньше либо равен нулю");
            }
        }
        string color;
        //  конструктор 
        public Circle(string color, double radius=1.0)
        {
            Radius = radius;
            this.color = color;
        }
        //  реализованные элементы интерфейса
        public double GetSquare()
        {
            return (Math.PI*radius*radius);
        }

        public void Print()
        {
            Console.WriteLine("Фигура Circle:\n\tradius = "+radius+"\n\tcolor = "+color+"\n\tsquare = "+GetSquare());
        }

        public override string ToString()
        {
            return ("Фигура Circle:\n\tradius = " + radius + "\n\tcolor = " + color + "\n\tsquare = " + GetSquare());
        }

        public int CompareTo(object obj)
        {
            Circle c = obj as Circle;
            if (c != null)
                return (this.GetSquare().CompareTo(c.GetSquare()));
            return 1;
        }
    }
}
