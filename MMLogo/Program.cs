using System;
using System.Diagnostics;

namespace MMLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintLogo.Print(n));
        }
    }
}
