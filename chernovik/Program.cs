using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static chernovik.Program;

namespace chernovik
{
    internal class Program
    {
        public struct human
        {
            public string Name;
            public int passport;
            public string problem;
            public short temperament;
            public short intell;
            public human(string Name, int passport, string problem, short temperament, short intell)
            {
                this.Name = Name;
                this.passport = passport;
                this.problem = problem;
                this.temperament = temperament;
                this.intell = intell;
            }
        }


        static void Main(string[] args)
        {
            human human1 = new human("Рофланов", 128765, "подключение", 4, 0);
            human human2 = new human("Зиганшин", 128766, "поломка", 5, 1);
            human human3 = new human("Морозов", 128767, "подключение", 6, 1);
            human human4 = new human("Головина", 128768, "включение", 2, 0);
            human human5 = new human("Сагдуллин", 128769, "включение", 8, 1);
            List<human> window = new List<human>();
            List<human> window2 = new List<human>();
            List<human> window3 = new List<human>();
            Dictionary<int, human> humans = new Dictionary<int, human>();
            humans.Add(human1.passport, human1);
            humans.Add(human2.passport, human2);
            humans.Add(human3.passport, human3);
            humans.Add(human4.passport, human4);
            humans.Add(human5.passport, human5);
            foreach (var s0 in humans)
            {
                Console.WriteLine($" Фамилия: {s0.Value.Name}, Пасспорт: {s0.Value.passport}, Проблема: {s0.Value.problem}, Характер: {s0.Value.temperament}, Интелект: {s0.Value.intell}");

            }
            Console.WriteLine();
            Console.WriteLine("Введи  фамилию, номер паспорта, проблему (подключение, поломка, включение),\n  уровень темперамента(0-10), уровень ума (0-1)");
            string a123 = Console.ReadLine();
            string[]  arr22= a123.Split(' ');
            human chel = new human(arr22[0], int.Parse(arr22[1]), arr22[2], short.Parse(arr22[3]), short.Parse(arr22[4]));
            humans.Add(chel.passport, chel);

            foreach (var s0 in humans)
            {
                Console.WriteLine($" Фамилия: {s0.Value.Name}, Пасспорт: {s0.Value.passport}, Проблема: {s0.Value.problem}, Характер: {s0.Value.temperament}, Интелект: {s0.Value.intell}");

            }
            

            int call = 1;
            foreach (var a in humans)
            {
                if (a.Value.intell == 1)
                {
                    switch (a.Value.problem) // подключение поломка включение
                    {
                        case "подключение":
                            Add_window(ref window, a.Value);
                            break;
                        case "поломка":
                            Add_window(ref window2, a.Value);
                            break;
                        case "включение":
                            Add_window(ref window3, a.Value);
                            break;
                    }
                }
                else
                {
                    human newcit = a.Value;
                    Random_window(ref newcit);
                    switch (newcit.problem) // подключение поломка включение
                    {
                        case "подключение":
                            Add_window(ref window, a.Value);
                            break;
                        case "поломка":
                            Add_window(ref window2, a.Value);
                            break;
                        case "включение":
                            Add_window(ref window3, a.Value);
                            break;
                    }
                }
                Console.WriteLine($"НОМЕР ХОДА {call}");
                Console.WriteLine("Очередь в окно 1 (подключение):");
                Check_window(window);
                Console.WriteLine();
                Console.WriteLine("Очередь в окно 2 (поломка):");
                Check_window(window2);
                Console.WriteLine();
                Console.WriteLine("Очередь в окно 3 (включение):");
                Check_window(window3);
                Console.WriteLine();
                call++;
            }




        }

        static void Random_window(ref human citizen)
        {
            List<string> name_window = new List<string> { "подключение", "поломка", "включение" };
            name_window.Remove(citizen.problem);
            var random = new Random();
            int index = random.Next(name_window.Count);
            citizen.problem = name_window[index];

        }

        public static void Check_window(List<human> window)
        {
            int call = 1;

            foreach (human name in window)
            {
                Console.WriteLine($"{name.Name} номер в очереди {call}");
                call++;
            }
        }

        public static void Add_window(ref List<human> window, human citizen)
        {
            if (citizen.temperament < 5)
            {
                window.Add(citizen);
            }
            else
            {
                Console.WriteLine($"На сколько человек обгонять? (спрашивает {citizen.Name} в окно для проблемы {citizen.problem})");
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
