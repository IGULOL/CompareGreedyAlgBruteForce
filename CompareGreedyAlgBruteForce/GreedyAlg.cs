using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CompareGreedyAlgBruteForce
{
    //жадный алгоритм
    class GreedyAlg
    {
        public static int FindRes(int[] file, int capacity, out long time)
        {
            time = 0;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<int> diskettes = new List<int>(1);

            //сортируем файлы по возрастанию 
            Array.Sort(file);
            //проверяем есть ли файлы больше размера дискеты
            if (file[file.Length - 1] > capacity)
            {
                return 0;
            }

            //создаем двумерный массив
            //в котором будет содержаться информация
            //был ли использован файл или нет
            int[,] files = new int[2, file.Length];

            for (int i = 0; i < file.Length; i++)
            {
                files[0, i] = file[i];
            }


            for (int i = (file.Length - 1); i >= 0; i--)               
            {
                //смотрим куда можно положить
                for (int j = 0; j < diskettes.Count; j++)
                {
                    //если нашли куда положить
                    if (diskettes[j] + files[0, i] <= capacity)
                    {
                        diskettes[j] += files[0, i];
                        files[1, i] = 1;
                        continue;
                    }
                }
                //если не нашли куда положить
                if (files[1, i] == 0)
                {
                    diskettes.Add(files[0, i]);
                    files[1, i] = 1;
                }
            }

            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;

            return diskettes.Count;
        }
    }
}
