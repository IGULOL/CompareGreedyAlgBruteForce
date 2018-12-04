using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareGreedyAlgBruteForce
{
    //перебор
    class BruteForce
    {
        public int FindRes(int[] files, int capacity, out long time)
        {
            long msBefore = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int[] diskettes = new int[files.Length];
            





            long msAfter = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            time = msAfter - msBefore;
            return diskettes.Length;
        }
    }
}
