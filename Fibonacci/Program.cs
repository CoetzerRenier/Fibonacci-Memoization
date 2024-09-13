using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stuff s = new Stuff();

            Console.WriteLine(s.Fibonacci(50));
        }

        public class Stuff
        {
            private Dictionary<int, long> memo = new Dictionary<int, long>();

            public Stuff()
            {
                //Initialize base cases.
                memo[1] = 1;
                memo[2] = 1;
            }

            public long Fibonacci(int n)
            {
                //Return if already computed.
                if (memo.ContainsKey(n))
                {
                    return memo[n];
                }
                
                memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                return memo[n];
            }
        }
    }
}
