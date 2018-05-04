using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3HomeWorkTask5
{
    class Program
    {
        static void Input(int i, int pos, ref int[] mas)
        {
            if (i > pos)
            {
                int keyVal = mas[i];
                while (i != pos)
                {
                    mas[i] = mas[i - 1];
                    i--;
                }
                mas[pos] = keyVal;
            }
        }

        static void BinarySearch(ref int[] mas, int keyVal, ref int startPos, ref int endPos, ref int posVal)
        {
            while (startPos < endPos)
            {
                int mid = startPos + (endPos -startPos) / 2;
                if (keyVal >= mas[mid])
                {
                    startPos = mid + 1;
                }
                else 
                {
                    endPos = mid;
                }
                
            }
        }

        static void Sort(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                int pos = -1;
                int startIndex = 0;
                int endIndex = i;
                int keyVal = mas[i];
                BinarySearch(ref mas, keyVal, ref startIndex, ref endIndex, ref pos);
                if (keyVal != mas[endIndex])
                {
                    Input(i, endIndex, ref mas);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] mass = { 2, 4, 3, 1, 5};
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
 