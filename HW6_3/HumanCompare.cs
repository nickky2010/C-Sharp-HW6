//  Дополнительно создать класс, реализующий интерфейс IComparer.Использовать объект класса для сортировки списка людей по алфавиту.
using System.Collections;

namespace HW6_3
{
    class HumanCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            Human h1 = x as Human;
            Human h2 = y as Human;
            return ((h1 == null && h2 == null) ? 0 : (h1 == null ? -1 : ((h2 == null) ? 1 :
                h1.Surname.CompareTo(h2.Surname))));
        }
    }
}
