using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_12_21_06_2024
{
    internal class MathTest
    {
        public bool isParity(int num)
        {
            if (num %2 ==0) return true;
            return false;
        }
        public bool isOddnes(int num)
        {
            if (num % 2 == 0) return false;
            return true;
        }
        public bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public bool isFibonacci(int num)
        {
            int fNum = 0;
            int sNum = 1;
            while (sNum <= num)
            {
                if (sNum == num)
                {
                    return true;
                }
                int nextNum = fNum + sNum;
                fNum = sNum;
                sNum = nextNum;
            }
            return false;
        }
    }
}
