//  Класс студентов должен содержать дополнительные поля:
//      оценки по математике, физике и истории, 
//      конструктор с параметрами, 
//      метод для получения среднего балла за сессию. 
//  Переопределить метод Info в классе «Студент» так, чтобы он возвращал максимальную оценку.

using System;
using System.Text;

namespace HW6_3
{
    class Student : Human
    {
        // оценки по математике
        int[] gradeMath;
        public int[] GradeMath
        {
            get => gradeMath;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 1 || value[i] > 10)
                        throw new Exception((i + 1) + " оценка по математике у студента по фамилии" + Surname + " должна быть равна числу между 1 и 10");
                }
                gradeMath = value;
            }
        }

        // оценки по физике 
        int[] gradePhysics;
        public int[] GradePhysics
        {
            get => gradePhysics;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 1 || value[i] > 10)
                        throw new Exception((i + 1) + " оценка по физике у студента по фамилии " + Surname + " должна быть равна числу между 1 и 10");
                }
                gradePhysics = value;
            }
        }

        // оценки по истории 
        int[] gradeHistory;
        public int[] GradeHistory
        {
            get => gradeHistory;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 1 || value[i] > 10)
                        throw new Exception((i + 1) + " оценка по истории у студента по фамилии " + Surname + " должна быть равна числу между 1 и 10");
                }
                gradeHistory = value;
            }
        }

        // конструктор с параметрами 
        public Student(string surname, int yearOfBirth, string status, int[] gradeMath, int[] gradePhysics, int[] gradeHistory) :
            base(surname, yearOfBirth, status)
        {
            GradeMath = gradeMath;
            GradePhysics = gradePhysics;
            GradeHistory = gradeHistory;
        }

        // метод для получения среднего балла за сессию. 
        public double GetSessionAverage()
        {
            int sumGrade = 0;
            foreach (int item in gradeMath)
            {
                sumGrade += item;
            }
            foreach (int item in gradePhysics)
            {
                sumGrade += item;
            }
            foreach (int item in gradeHistory)
            {
                sumGrade += item;
            }
            return ((double)sumGrade / (gradeMath.Length + gradePhysics.Length + gradeHistory.Length));
        }

        // Переопределить метод Info в классе «Студент» так, чтобы он возвращал максимальную оценку.
        public override int Info()
        {
            int maxGrade = 0;
            foreach (int item in gradeMath)
            {
                if (maxGrade < item)
                    maxGrade = item;
            }
            if (maxGrade != 10)
            {
                foreach (int item in gradePhysics)
                {
                    if (maxGrade < item)
                        maxGrade = item;
                }
                if (maxGrade != 10)
                {
                    foreach (int item in gradeHistory)
                    {
                        if (maxGrade < item)
                            maxGrade = item;
                    }
                }
            }
            return (maxGrade);
        }
        public override string ToString()
        {
            int gradeMathLength = gradeMath.Length;
            int gradePhysicsLength = gradePhysics.Length;
            int gradeHistoryLength = gradeHistory.Length;
            StringBuilder grade = new StringBuilder(
                "\nОценки по математике: ".Length + gradeMathLength*2 + gradeMathLength-2+
                "\nОценки по физике: ".Length+ gradePhysicsLength * 2 + gradePhysicsLength - 2 +
                "\nОценки по истории: ".Length + gradeHistoryLength * 2 + gradeHistoryLength - 2);
            grade.Append("\nОценки по математике: ");
            for (int i = 0; i < gradeMathLength; i++)
            {
                grade.Append(gradeMath[i]);
                if (i != gradeMathLength - 1)
                    grade.Append(' ');
            }
            grade.Append("\nОценки по физике: ");
            for (int i = 0; i < gradePhysicsLength; i++)
            {
                grade.Append(gradePhysics[i]);
                if (i != gradePhysicsLength - 1)
                    grade.Append(' ');
            }
            grade.Append("\nОценки по истории: ");
            for (int i = 0; i < gradeHistoryLength; i++)
            {
                grade.Append(gradeHistory[i]);
                if (i != gradeHistoryLength - 1)
                    grade.Append(' ');
            }
            return base.ToString() + grade;
        }
    }
}
