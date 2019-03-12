using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var randy = new Random();
            var randomList = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                randomList.Add(randy.Next(1, 50));
            }

            var squared = new List<int>();
            foreach (int num in randomList)
            {
                var squaredNum = num * num;
                var squaredDec = Convert.ToDecimal(squaredNum);
                
                if ((squaredDec/ 2) == Math.Floor(squaredDec / 2 ))
                {
                    squared.Add(squaredNum);
                }          
            }

            foreach(int num in squared)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
