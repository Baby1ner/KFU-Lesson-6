using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static int[] Task1(params char[] lena)
        {
            int glas = 0;
            int sogl = 0;
            string gla = "aeiouy";
            string sog = "bcdfghjklmnpqrstvwxz";
            int dlena = lena.Length;
            for (int i = 0; i < dlena; i++)
            {
                char c = char.ToLower(lena[i]);
                for (int j = 0; j < gla.Length; j++)
                {
                    if (c == gla[j])
                        glas++;
                }
                for (int j = 0; j < sog.Length; j++)
                {
                    if (c == sog[j])
                        sogl++;
                }
            }
            int[] arr = { glas, sogl };
            return arr;

        }



        static int[,] Task2(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }


        static int[] Task3(int[,] arr)
        {
            int[] ark = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int kal = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    kal += arr[i, j];
                }
                ark[i] = kal/arr.GetLength(0);
            }
            return ark;
        }


        static int[] HomeTask1(List<char> lena)
        {
            int glas = 0;
            int sogl = 0;
            string gla = "aeiouy";
            string sog = "bcdfghjklmnpqrstvwxz";
            int dlena = lena.Count;
            for (int i = 0; i < dlena; i++)
            {
                char c = char.ToLower(lena[i]);
                for (int j = 0; j < gla.Length; j++)
                {
                    if (c == gla[j])
                        glas++;
                }
                for (int j = 0; j < sog.Length; j++)
                {
                    if (c == sog[j])
                        sogl++;
                }
            }
            int[] arr = { glas, sogl };
            return arr;

        }





        static void Main(string[] args)
        {
            Random r = new Random();
            /*
            Console.WriteLine("Задание 1. Прочитать и файл и сказать сколько в нем гласных и согласных");
            using (StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\TUM.txt"))
            {
                char[] sru = sr.ReadLine().ToCharArray();

                int[] arr = Task1(sru);
                Console.WriteLine($"В исходном коде было {arr[1]} - согласных,{arr[0]} - гласных");
             }
            


            Console.WriteLine("Задание 2. Перемножение матриц");
            int[,] arr21 = new int[2, 2] { { 3, 5 }, { 2, 1 } };
            int[,] arr22 = new int[2, 3] { { 8, 2, 3 }, { 1, 7, 2 } };
            int[,] arr23 = Task2(arr21, arr22);
            matric(arr23);
            
            
            
            Console.WriteLine("Задание 3. средняя темепература за год");
            int[,] arr3 = new int[12,30];
            for (int i= 0; i < arr3.GetLength(0); i++)
            {
                for (int j= 0; j < arr3.GetLength(1); j++)
                    arr3[i, j] = r.Next(-30,30);
            }
            int[] ark = Task3(arr3);
            int[] mark = Bubble(ark);
            Console.WriteLine(String.Join(" ",mark));
            

            
            Console.WriteLine("Домашнее Задание 1. Коллекции");
            string fileName = @"C:\Users\User\Desktop\TUM.txt";
            string text = File.ReadAllText(fileName);
            List<char> list = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                list.Add(text[i]);
            }
            int[] arr41 = HomeTask1(list);
            Console.WriteLine($"В исходном коде было {arr41[1]} - согласных,{arr41[0]} - гласных");
            


            Console.WriteLine("Домашнее Задание 2. Перемножение матриц");
            LinkedList<LinkedList<int>> list = new LinkedList<LinkedList<int>>();
            */


            Console.WriteLine("Домашнее Задание 3. Средняя температура за год");
            Dictionary<string, int[]> mamamia = new Dictionary<string, int[]>()
            {
                ["Jan"] = radik1(),
                ["Feb"] = radik2(),
                ["Mar"] = radik3(),
                ["Apr"] = radik4(),
                ["May"] = radik5(),
                ["Jun"] = radik6(),
                ["Jul"] = radik7(),
                ["Aug"] = radik8(),
                ["Sep"] = radik9(),
                ["Oct"] = radik10(),
                ["Nov"] = radik11(),
                ["Dec"] = radik12(),
            };
            
            
        }







        static void matric(int[,] masa)
        {
            for (int i = 0; i < masa.GetLength(0); i++)
            {
                for (int j = 0; j < masa.GetLength(1); j++)
                    Console.Write(String.Format("{0,3}", masa[i, j]));
                Console.WriteLine();
            }

        }
        static int[] Bubble(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }






        static int[] radik1()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for(int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30,30);  
            }
            return mak;
        }

        static int[] radik2()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik3()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik4()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik5()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik6()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik7()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik8()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }

        static int[] radik9()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik10()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik11()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik12()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
    }
} 
