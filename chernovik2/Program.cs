using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chernovik2
{
    internal class Program
    {


        struct Сitizen
        {
            public string second_name;
            public int passport_ID;
            public string problem;
            public int temperament;
            public int intellect;
            public Сitizen(string second_name, int passport_ID, string problem, int temperament, int intellect)
            {
                this.second_name = second_name;
                this.passport_ID = passport_ID;
                this.problem = problem;
                this.temperament = temperament;
                this.intellect = intellect;
            }

            static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            // подключение поломка включение
            Сitizen citizen1 = new Сitizen("Хамитов", 128765, "подключение", 4, 0);
            Сitizen citizen2 = new Сitizen("Хамидуллина", 128766, "поломка", 5, 1);
            Сitizen citizen3 = new Сitizen("Митрофанов", 128767, "подключение", 6, 1);
            Сitizen citizen4 = new Сitizen("Гильфанова", 128768, "включение", 2, 0);
            Сitizen citizen5 = new Сitizen("Шапошникова", 128769, "включение", 8, 1);
            List<Сitizen> window = new List<Сitizen>();
            List<Сitizen> window2 = new List<Сitizen>();
            List<Сitizen> window3 = new List<Сitizen>();
            Dictionary<int, Сitizen> people2 = new Dictionary<int, Сitizen>()
            {
                { citizen1.passport_ID, citizen1}, { citizen2.passport_ID, citizen2},
                { citizen3.passport_ID, citizen3}, { citizen4.passport_ID, citizen4},
                { citizen5.passport_ID, citizen5}
            };
            Console.WriteLine("Хочешь добавить еще жителя?");
            string question = Console.ReadLine();
            if (question.ToLower().Equals("да"))
            {
                Console.WriteLine("Чтобы закончить добавление жителя напиши: «стоп»");
                do
                {
                    Console.WriteLine("Введи его фамилию, номер паспорта, его проблему (подключение, поломка, включение),\n уровень его темперамента(0-10), уровень ума (0-1)");
                    question = Console.ReadLine();
                    if (question.ToLower().Equals("стоп"))
                    {
                        break;
                    }
                    string[] info = question.Split(' ');
                    Сitizen citizen = new Сitizen(info[0], int.Parse(info[1]), info[2], int.Parse(info[3]), int.Parse(info[4]));
                    people2[citizen.passport_ID] = citizen;
                } while (!question.ToLower().Equals("стоп"));
            }
            foreach (var (key, value) in people2)
            {
                Console.WriteLine($"{key}: {value.second_name}");
            }
            k = 1;
            foreach (var (key, value) in people2)
            {
                if (value.intellect == 1)
                {
                    switch (value.problem) // подключение поломка включение
                    {
                        case "подключение":
                            Add_window(ref window, value);
                            break;
                        case "поломка":
                            Add_window(ref window2, value);
                            break;
                        case "включение":
                            Add_window(ref window3, value);
                            break;
                    }
                }
                else
                {
                    Сitizen newcit = value;
                    Random_window(ref newcit);
                    switch (newcit.problem) // подключение поломка включение
                    {
                        case "подключение":
                            Add_window(ref window, value);
                            break;
                        case "поломка":
                            Add_window(ref window2, value);
                            break;
                        case "включение":
                            Add_window(ref window3, value);
                            break;
                    }
                }
                Console.WriteLine($"НОМЕР ХОДА {k}");
                Console.WriteLine("Очередь в окно 1 (подключение):");
                Check_window(window);
                Console.WriteLine();
                Console.WriteLine("Очередь в окно 2 (поломка):");
                Check_window(window2);
                Console.WriteLine();
                Console.WriteLine("Очередь в окно 3 (включение):");
                Check_window(window3);
                Console.WriteLine();
                k++;
            }

        }

        public static void Random_window(ref Сitizen citizen)
        {
            List<string> name_window = new List<string> { "подключение", "поломка", "включение" };
            name_window.Remove(citizen.problem);
            var random = new Random();
            int index = random.Next(name_window.Count);
            citizen.problem = name_window[index];

        }
        public static void Check_window(List<Сitizen> window)
        {
            int k = 1;

            foreach (Сitizen name in window)
            {
                Console.WriteLine($"{name.second_name} номер в очереди {k}");
                k++;
            }
        }

        public static void Add_window(ref List<Сitizen> window, Сitizen citizen)
        {
            if (citizen.temperament < 5)
            {
                window.Add(citizen);
            }
            else
            {
                Console.WriteLine($"На сколько человек обгонять? (спрашивает {citizen.second_name} в окно для проблемы {citizen.problem})");
                int how_much_to_overtake = int.Parse(Console.ReadLine());
                if (how_much_to_overtake > window.Count)
                {
                    Console.WriteLine("Неверное количество обгонов");
                    window.Add(citizen);
                }
                else
                {
                    window.Insert(window.Count - how_much_to_overtake, citizen);
                }
            }
            return;
        }
    }
}
