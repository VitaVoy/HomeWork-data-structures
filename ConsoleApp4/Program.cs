using System;

namespace ConsoleApp4
{
    class Program 
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            int i = str.LengthString();


            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}

