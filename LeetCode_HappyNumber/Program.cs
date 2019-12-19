using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsHappy(19));
        }
    }

    public class Solution
    {
        public bool IsHappy(int n)
        {
            var hash = new HashSet<int>();
            while (true)
            {
                var newTotal = 0;
                while (n > 0)
                {
                    var digit = n % 10;
                    newTotal += digit * digit;
                    n /= 10;
                }

                n = newTotal;
                if (!hash.Add(n)) return false;
                if (n == 1) return true;
            }
        }
    }
}
