using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 5, 5, 8, 8 };
            foreach (int val in numbers.Distinct())
            {
                Console.WriteLine(val + " - " + numbers.Where(x => x == val).Count() + " раз");
            }
        }
    }
}
