using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3HomeWork
{
    class Program
    {
        static void Swap(ref int elOne, ref int elTwo)
        {
            int temp = elOne;
            elOne = elTwo;
            elTwo = temp;
        }

        static void Sort(ref int[] mass)
        {
            int masLength = mass.Length;
            int movCount = 0;
            for (int i = 0; i < masLength; i++)
            {
                movCount = 0;
                if (i % 2 == 0)
                {
                    int j = 0;
                    while (j < masLength - 1)
                    {
                        if (mass[j] > mass[j + 1])
                        {
                            Swap(ref mass[j], ref mass[j + 1]);
                            movCount++;
                        }
                        j++;
                    }
                }
                else {
                    int j = masLength - 1;
                    while (j > 0)
                    {
                        if (mass[j-1] > mass[j])
                        {
                            Swap(ref mass[j - 1], ref mass[j]);
                            movCount++;
                        }
                        j--;
                    }
                }
                if (movCount == 0)
                { break; }
            }
        }

        static void Main(string[] args)
        {
            int[] mass = { 1, 4, 2, 6, 2, 9, 5, 7, 1 };
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
            Sort(ref mass);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.ReadKey();
        }
    }
}
