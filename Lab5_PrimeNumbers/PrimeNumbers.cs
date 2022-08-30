using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_PrimeNumbers
{
    public class PrimeNumbers
    {
        static int[] primeNums = new int[] {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97};

        public static int GetPrime(int num)
        {
            return primeNums[num - 1];
        }
    }
}
