using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerAlgorithm
{
    static class global
    {

        public static int numResources, numProcesses;
        public static int[] resTotal, resAvailable;
        public static int[,] currentAllocations, maxNeed,remainingNeed;
        public static int[] safeSequence;
        public static int MaxIter=numProcesses* numResources;
    }
}
