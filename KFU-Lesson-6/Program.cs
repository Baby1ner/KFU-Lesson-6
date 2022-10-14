using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_6
{
    public struct student
    {
        public string SurName;
        public string Name;
        public DateTime Birthday;
        public string Exam;
        public int Ball;

        public student(string SurName, string Name, DateTime Birthday, string Exam, int Ball)
        {
            this.SurName = SurName;
            this.Name = Name;
            this.Birthday = Birthday;
            this.Exam = Exam;
            this.Ball = Ball;
        }

    }

    internal class Program
    {
        static student newstudent()
        {
            Console.WriteLine("Введите имя студента");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя студента");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения студента в виде день/месяц/год");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите предмет который сдавали");
            string exam = Console.ReadLine();
            Console.WriteLine("Введите количество баллов по этому предмету");
            int ball = int.Parse(Console.ReadLine());
            student studenti = new student(surname, name, birthday, exam, ball);
            return studenti;
        }

        static string Task2(int[] arr1, int[] arr2)
        {
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == 5) c1++;
                if (arr2[i] == 5) c2++;
            }
            if (c1 == c2) return "Drinks All Round! Free Beers on Bjorg!";
            else return "Ой, Бьорг - пончик! Ни для кого пива";

        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 1. Студенты");
            Dictionary<string, student> students = new Dictionary<string, student>();
            student stud1 = new student("Залялетдинов", "Азат", DateTime.Parse("03/11/2004"), "Информатика", 85);
            student stud2 = new student("Рофланов", "Илья", DateTime.Parse("01/11/2003"), "Информатика", 88);
            student stud3 = new student("Зиганшин", "Халиль", DateTime.Parse("15/07/2005"), "Физика", 93);
            student stud4 = new student("Ахметзянов", "Камиль", DateTime.Parse("14/08/2003"), "Английский", 65);
            student stud5 = new student("Братухин", "Илья", DateTime.Parse("19/03/2004"), "Физика", 90);
            student stud6 = new student("Сагдуллин", "Амир", DateTime.Parse("07/07/2004"), "Информатика", 78);
            student stud7 = new student("Вотяков", "Александр", DateTime.Parse("23/11/2004"), "Информатика", 100);
            student stud8 = new student("Морозов", "Даниил", DateTime.Parse("29/02/2004"), "Английский", 98);
            student stud9 = new student("Головина", "Маша", DateTime.Parse("13/07/2003"), "Информатика", 95);
            student stud10 = new student("Мошкина", "Маша", DateTime.Parse("16/11/2004"), "Физика", 65);
            students.Add(stud1.SurName, stud1);
            students.Add(stud2.SurName, stud2);
            students.Add(stud3.SurName, stud3);
            students.Add(stud4.SurName, stud4);
            students.Add(stud5.SurName, stud5);
            students.Add(stud6.SurName, stud6);
            students.Add(stud7.SurName, stud7);
            students.Add(stud8.SurName, stud8);
            students.Add(stud9.SurName, stud9);
            students.Add(stud10.SurName, stud10);
            Console.WriteLine("Student List:");
            foreach (var s0 in students)
            {
                Console.WriteLine($" Фамилия: {s0.Value.SurName}, Имя: {s0.Value.Name}, День рождения: {s0.Value.Birthday.ToShortDateString()}, Экзамен: {s0.Value.Exam}, Баллы: {s0.Value.Ball}");

            }
            Console.WriteLine("У вас есть 3 действия ");
            Console.WriteLine("Введите [Новый студент],[Удалить],[Сортировка]");
            string akbar = Console.ReadLine();
            akbar = akbar.ToLower();
            switch (akbar)
            {
                case "новый студент":
                    student studnew = newstudent();
                    students.Add(studnew.SurName, studnew);
                    Console.WriteLine("New student List:");
                    foreach (var s0 in students)
                    {
                        Console.WriteLine($" Фамилия: {s0.Value.SurName}, Имя: {s0.Value.Name}, День рождения: {s0.Value.Birthday.ToShortDateString()}, Экзамен: {s0.Value.Exam}, Баллы: {s0.Value.Ball}");

                    }
                    break;

                case "удалить":
                    Console.WriteLine("Введите фамилию студента, которого вы хотите удалить");
                    string surname = Console.ReadLine();
                    if (students.ContainsKey(surname))
                    {
                        students.Remove(surname);
                    }

                    foreach (var s0 in students)
                    {
                        Console.WriteLine($" Фамилия: {s0.Value.SurName}, Имя: {s0.Value.Name}, День рождения: {s0.Value.Birthday.ToShortDateString()}, Экзамен: {s0.Value.Exam}, Баллы: {s0.Value.Ball}");

                    }
                    break;

                case "сортировка":
                    var sorted = students.OrderBy(x => x.Value.Ball).ToDictionary(x => x.Key, x => x.Value.Ball);
                    Console.WriteLine(String.Join("\n", sorted));
                    break;

                default:
                    Console.WriteLine("Вы ввели не то слово, шо совсем больные");
                    break;
            
            }
            


            Console.WriteLine("Задание 2. Воюющие кланы");
            Random random = new Random();
            int[] bavarr = new int[9];
            for (int i = 0; i < bavarr.Length; i++)
                bavarr[i] = random.Next(0,9);
            int[] scandi = new int[9];
            for (int i = 0; i < scandi.Length; i++)
                scandi[i] = random.Next(0, 9);
            Console.WriteLine(Task2(bavarr,scandi));
            */

            Console.WriteLine("Задание 3. ЖЕК");































        }

    }
}
