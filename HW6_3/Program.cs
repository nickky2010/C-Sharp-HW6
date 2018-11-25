//                                                          Задание 3
//  Создать иерархию классов: "Человек"=>"Студент"
//  Класс «человек» должен содержать следующие элементы: 
//      поле-фамилия, поле-год рождения, поле статус(студент, преподаватель, бизнесмен и т.д.), конструктор с параметрами, 
//      конструктор без параметров, метод вывода информации об объекте, виртуальный методом Info возвращающим  возраст.
//  Использовать метод Info в методе вывода информации.Реализовать в классе «Человек» интерфейс IComparable для сравнения людей по возрасту.
//  Класс студентов должен содержать дополнительные поля:
//      оценки по математике, физике и истории, 
//      конструктор с параметрами, 
//      метод для получения среднего балла за сессию. 
//  Переопределить метод Info в классе «Студент» так, чтобы он возвращал максимальную оценку.
//  Дополнительно создать класс, реализующий интерфейс IComparer.Использовать объект класса для сортировки списка людей по алфавиту.
//  В методе Main:
//      •	формировать массив объектов класса человек(с клавиатуры не вводить, генератор случайных значений не использовать). 
//      •	Сортировать по возрасту.
//      •	Сортировать по фамилии.
//      •	Выводить информацию

using System;

namespace HW6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  формируем массив объектов класса человек(с клавиатуры не вводить, генератор случайных значений не использовать). 
                int[][] math = new int[2][];
                math[0] = new int[] { 5, 4, 10, 6, 8 };
                math[1] = new int[] { 7, 6, 8, 8, 4, 5, 8, 6 };
                int[][] physics = new int[2][];
                physics[0] = new int[] { 6, 8, 4, 3, 7, 6, 8, 4, 4, 9 };
                physics[1] = new int[] { 4, 4, 6, 8, 8, 5, 7, 8 };
                int[][] history = new int[2][];
                history[0] = new int[] { 3, 4, 8, 5, 6, 5, 9, 4 };
                history[1] = new int[] { 6, 8, 7, 8, 8, 3, 7, 3 };
                Human[] human =
                {
                    new Human ("Иванов",1988,"Бизнесмен"),
                    new Human ("Чижиков",1966,"Преподаватель"),
                    new Human ("Пыжиков",1979,"Рабочий"),
                    new Student ("Петров", 2000,"Студент", math[0], physics[0], history[0]),
                    new Student ("Сидоров", 1996,"Студент", math[1], physics[1], history[1])
                };
                // выводим на экран созданный массив объектов Human
                Console.WriteLine("\t\t\t\t\tИсходный массив объектов Human");
                Show(human);
                Clear();
                //  Сортируем по возрасту
                Console.WriteLine("\t\t\t\t\tСортируем по возрасту");
                Array.Sort(human);
                Show(human);
                Clear();
                //  Сортируем по фамилии
                HumanCompare humanCompare = new HumanCompare();
                Console.WriteLine("\t\t\t\t\tСортируем по фамилии");
                Array.Sort(human, humanCompare.Compare);
                Show(human);
                Clear();
                //  Выводить информацию
                Console.WriteLine("\t\t\t\t\tВыводим информацию");
                foreach (Human item in human)
                {
                    Console.WriteLine("***********************************");
                    Student student = item as Student;
                    if (student == null)
                        Console.WriteLine(item.Surname+"\n"+ item.Status+"\nВозраст: " + item.Info());
                    else
                        Console.WriteLine(item.Surname + "\n" + item.Status+ "\nМаксимальная оценка: " + item.Info()+ 
                            "\nСредний балл: "+ Math.Round(student.GetSessionAverage(),3));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void Clear()
        {
            Console.WriteLine("\nДля продолжения нажмите пробел");
            Console.ReadKey();
            Console.Clear();
        }
        static void Show (Human[] human)
        {
            foreach (Human item in human)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine(item);
            }
        }
    }
}
