//  Создать класс-контейнер для фигур, содержащий: 
//      поле-массив фигур (ссылок интерфейсного типа), 
//      конструктор, 
//      методы для сортировки по площади и по типу фигуры, а также реализующий интерфейс IEnumerable.
using System;
using System.Collections;

namespace HW6_2
{
    class ContainerFigure: IEnumerable
    {
        //  поле-массив фигур (ссылок интерфейсного типа)
        IGeometricFigures[] geometricFigures;
        //  конструктор
        public ContainerFigure(IGeometricFigures[] geometricFigures)
        {
            this.geometricFigures = geometricFigures;
        }

        //  метод для сортировки по площади
        public void SortBySquare ()
        {
            FigureCompareBySquare bySquare = new FigureCompareBySquare();
            Array.Sort(geometricFigures, bySquare.Compare);
        }
        //  метод для сортировки по типу фигуры
        public void SortByType()
        {
            FigureCompareBySquare byType = new FigureCompareBySquare();
            Array.Sort(geometricFigures, byType.CompareByType);
        }

        // реализация интерфейса IEnumerable
        public IEnumerator GetEnumerator()
        {
            return geometricFigures.GetEnumerator();
        }
    }
}
