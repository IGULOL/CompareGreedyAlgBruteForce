using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CompareGreedyAlgBruteForce
{
    //перебор
    class BruteForce
    {
        private static void Swap(ref int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }

        //следующая перестановка
        private static bool NextSet(ref int[] a, int n)
        {
            int j = n - 2;
            while (j != -1 && a[j] >= a[j + 1])
            {
                j--;
            }
            if (j == -1)
            {
                return false; //больше перестановок нет
            }
            int k = n - 1;
            while (a[j] >= a[k])
            {
                k--;
            }
            Swap(ref a, j, k);
            int l = j + 1;   //сортируем оставшуюся часть последовательности
            int r = n - 1; 
            while (l < r)
            {
                Swap(ref a, l++, r--);
            }
            return true;
        }

        //проверить во сколько ящиков влезут дискеты в заданном порядке
        private static int Check(int[] files, int capacity)
        {
            int res = 1;

            int diskette = 0;

            for (int i = 0; i < files.Length; i++)
            {
                if (diskette <= capacity)
                {
                    diskette += files[i];
                }     
                else
                {
                    diskette = 0;
                    res++;
                }  
            }

            return res;
        }

        public static int FindRes(int[] files, int capacity, out long time)
        {
            time = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<int> diskettes = new List<int>(1);

            //проверяем есть ли файлы больше размера дискеты
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i] > capacity)
                    return 0;
            }

            //формируем первую перестановку
            int n = files.Length;
            NextSet(ref files, n);           
            int min = Check(files, capacity);

            //пока есть переставноки, ищем минимальную
            int res;
            while (NextSet(ref files, n))
            {
                res = Check(files, capacity);
                if (res < min)
                {
                    min = res;
                }
            }

            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;

            return min;
        }
    }
}
