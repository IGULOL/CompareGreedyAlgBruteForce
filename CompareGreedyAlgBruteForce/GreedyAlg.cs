using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareGreedyAlgBruteForce
{
    //жадный алгоритм
    class GreedyAlg
    {
        public static int FindRes(int[] sizes, int capacity, out long time)
        {
            int res;
            long msBefore = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;





            long msAfter = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            time = msAfter - msBefore;
            return res;
        }
    }
}
