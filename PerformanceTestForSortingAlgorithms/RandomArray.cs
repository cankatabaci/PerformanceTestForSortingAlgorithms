using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTestForSortingAlgorithms
{
    public class RandomArray
    {
        public int[] randomYuz = new int[100];
        public int[] randomYediYuzElli = new int[750];
        public int[] randomBinBesYuz = new int[1500];
        public int[] randomYediBinBesYuz = new int[7500];
        public int[] randomOnBesBin = new int[15000];
        public int[] randomYetmisBesBin = new int[75000];
        public int[] randomYuzElliBin = new int[150000];

        public RandomArray()
        {
            for (int i = 0; i < 100; i++)  //Create random 100 number
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                randomYuz[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 750; i++)  //Create random 750 Number
            {
                Random r = new Random();
                randomYediYuzElli[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 1500; i++)  //Create random 1500 Number
            {
                Random r = new Random();
                randomBinBesYuz[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 7500; i++)  //Create random 7500 Number
            {
                Random r = new Random();
                randomYediBinBesYuz[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 15000; i++)  //Create random 15000 Number
            {
                Random r = new Random();
                randomOnBesBin[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 75000; i++)  //Create random 75000 Number
            {
                Random r = new Random();
                randomYetmisBesBin[i] = r.Next(1, 999999);
            }

            for (int i = 0; i < 150000; i++)  //Create random 150000 Number
            {
                Random r = new Random();
                randomYuzElliBin[i] = r.Next(1, 999999);
            }

        }
    }
}
