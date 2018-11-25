//  Дополнительно создать класс, реализующий интерфейс IComparer. Использовать объект класса для сортировки фигур по площади.
using System.Collections;

namespace HW6_2
{
    class FigureCompareBySquare : IComparer
    {
        public int Compare(object x, object y)
        {
            IGeometricFigures f1 = x as IGeometricFigures;
            IGeometricFigures f2 = y as IGeometricFigures;
            return ((f1 == null && f2 == null) ? 0 : (f1 == null ? -1 : ((f2 == null) ? 1 : 
                f1.GetSquare().CompareTo(f2.GetSquare()))));
        }
        public int CompareByType(object x, object y)
        {
            IGeometricFigures f1 = x as IGeometricFigures;
            IGeometricFigures f2 = y as IGeometricFigures;
            return ((f1 == null && f2 == null) ? 0 : (f1 == null ? -1 : ((f2 == null) ? 1 :
                f1.GetType().ToString().CompareTo(f2.GetType().ToString()))));
        }

    }
}
