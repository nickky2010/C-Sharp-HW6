﻿//                                                      Задание 2
//  Создать классы квадратов и окружностей, реализующие общий интерфейс «Геометрические фигуры»:
//                               "Квадрат" <="Интерфейс геометрическая фигура"=>"Круг"
//  Интерфейс должен определять следующие элементы: свойство, возвращающее площадь фигуры, метод вывода информации, 
//  и наследовать интерфейс IComparable для сравнения фигур по типу.
//  Класс квадратов должен содержать следующие элементы:поле-сторону квадрата, конструктор, реализованные элементы интерфейса, метод вычисления периметра.
//  Класс кругов должен содержать следующие элементы: поля - радиус, цвет фигуры, конструктор, реализованные элементы интерфейса.
//  Создать класс-контейнер для фигур, содержащий поле-массив фигур (ссылок интерфейсного типа), конструктор, 
//  методы для сортировки по площади и по типу фигуры, а также реализующий интерфейс IEnumerable.
//  Дополнительно создать класс, реализующий интерфейс IComparer.Использовать объект класса для сортировки фигур по площади.
//  В классе Program создать объект класса-контейнера с информацией о двух кругах и двух квадратах.
//  Вывести информацию о фигурах, используя для просмотра содержимого контейнера оператор foreach. 
//  Сортировать информацию по типу. Сортировать информацию по площадям фигур.

using System;

namespace HW6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IGeometricFigures[] figures = {
                    new Circle("black",3.3),
                    new Square(5.2),
                    new Circle("white",2.4),
                    new Square(3.1)
                };
                //  В классе Program создать объект класса-контейнера с информацией о двух кругах и двух квадратах.
                ContainerFigure containerFigure = new ContainerFigure(figures);
                //  Вывести информацию о фигурах, используя для просмотра содержимого контейнера оператор foreach. 
                foreach (IGeometricFigures item in containerFigure)
                {
                    item.Print();
                }
                //  Сортировать информацию по типу
                Console.WriteLine("*********************************************");
                Console.WriteLine("Сортируем информацию по типу фигур (название)");
                Console.WriteLine("*********************************************");
                containerFigure.SortByType();
                foreach (IGeometricFigures item in containerFigure)
                {
                    item.Print();
                }
                //  Сортировать информацию по площадям фигур.
                Console.WriteLine("*********************************************");
                Console.WriteLine("Сортируем информацию по площадям фигур");
                Console.WriteLine("*********************************************");
                containerFigure.SortBySquare();
                foreach (IGeometricFigures item in containerFigure)
                {
                    item.Print();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}