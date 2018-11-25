//  Класс «человек» должен содержать следующие элементы: 
//      поле-фамилия, поле-год рождения, поле статус(студент, преподаватель, бизнесмен и т.д.), конструктор с параметрами, 
//      конструктор без параметров, метод вывода информации об объекте, виртуальный методом Info возвращающим  возраст.
//  Использовать метод Info в методе вывода информации. Реализовать в классе «Человек» интерфейс IComparable для сравнения людей по возрасту.

using System;
using System.Collections;

namespace HW6_3
{
    class Human : IComparable
    {
        // поле-фамилия 
        public string Surname { get; set; }
        // поле-год рождения 
        int yearOfBirth;
        public int YearOfBirth
        {
            get => yearOfBirth;
            set
            {
                if (value <= DateTime.Now.Year)
                {
                    yearOfBirth = value;
                }
                else
                    throw new Exception("Год рождения не может превышать текущий год");
            }
        }
        // поле статус(студент, преподаватель, бизнесмен и т.д.)
        public string Status { get; set; }

        // конструктор с параметрами 
        public Human(string surname, int yearOfBirth, string status)
        {
            Surname = surname;
            YearOfBirth = yearOfBirth;
            Status = status;
        }

        // конструктор без параметров
        public Human()
        {
            Surname = "no surname";
            Status = "no status";
        }

        // метод вывода информации об объекте
        public override string ToString()
        {
            return ("Фамилия: "+Surname+"\nГод рождения: "+YearOfBirth+"\nСтатус: "+Status);
        }

        // виртуальный метод Info возвращающий возраст
        public virtual int Info()
        {
            return (DateTime.Now.Year - YearOfBirth);
        }

        // Реализовать в классе «Человек» интерфейс IComparable для сравнения людей по возрасту.
        public int CompareTo(object obj)
        {
            Human h = obj as Human;
            if (h != null)
                return (Info().CompareTo(h.Info()));
            return 1;
        }
    }
}
