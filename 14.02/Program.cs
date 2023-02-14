using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02
{
    class Program
    {
        interface IOutput
        {
            void Show();
            void Show(string text);
        }
        interface IMath
        {
            int Max();
            int Min();
            float Avg();
            bool Search(int search);
        }
        interface ISort
        {
            void SortAsc();
            void SortDesc();
            void SortByParam(bool isAsc);
        }

        class Array : IOutput, IMath, ISort
        {
            public string mass_chr;
            public int[] mass_int;
            public Array(string a)
            {
                mass_chr = a;
            }
            public Array(params int[] a)
            {
                mass_int = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                    mass_int[i] = a[i];
            }
            public void Show()
            {
                if (mass_chr != null)
                    Console.WriteLine(mass_chr);
                if (mass_int != null)
                    for (int i = 0; i < mass_int.Length; i++)
                        Console.WriteLine(mass_int[i]);
            }
            public void Show(string text)
            {
                Show();
                Console.WriteLine("Info: " + text);
            }
            public int Max()
            {
                int max = 0;
                if (mass_int != null)
                {
                    max = mass_int[0];
                    for (int i = 0; i < mass_int.Length; i++)
                        if (mass_int[i] > max)
                            max = mass_int[i];
                }
                return max;
            }
            public int Min()
            {
                int min = 0;
                if (mass_int != null)
                {
                    min = mass_int[0];
                    for (int i = 0; i < mass_int.Length; i++)
                        if (mass_int[i] < min)
                            min = mass_int[i];
                }
                return min;
            }
            public float Avg()
            {
                float sum = 0;
                if (mass_int != null)
                {
                    for (int i = 0; i < mass_int.Length; i++)
                        sum += mass_int[i];
                    sum /= mass_int.Length;
                }
                return sum;
            }
            public bool Search(int valueToSearch)
            {
                bool find = false;
                return find;
            }
            public void SortAsc()
            {
                if (mass_int != null)
                    System.Array.Sort(mass_int);
            }
            public void SortDesc()
            {
                if (mass_int != null)
                {
                    System.Array.Sort(mass_int);
                    System.Array.Reverse(mass_int);
                }
            }
            public void SortByParam(bool isAsc)
            {
                if (mass_int != null)
                {
                    if (isAsc != true)
                        SortDesc();
                    else
                        SortAsc();
                }

            }

        }
        static void Main(string[] args)
        {
            Array array = new Array("boba");
            array.Show("aboba");
        }
    }
}

