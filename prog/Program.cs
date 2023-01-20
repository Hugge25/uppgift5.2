using System;
using System.Diagnostics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int num = int.Parse(Console.ReadLine());

            int[] v = new int[num];

            Console.WriteLine($"Skriv in {num} heltal:");

            for (int i = 0; i < num; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int tal = 0;
            Console.WriteLine("Här är de talen du skriv in:");
            for (int i = 0; i < num; i++)
            {
                tal = tal + 1;
                Console.Write($"Tal {tal}: {v[i]}");
                Console.WriteLine();
            }
        }
    }
}
