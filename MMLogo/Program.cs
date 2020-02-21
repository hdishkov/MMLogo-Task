using System;
using System.Diagnostics;

namespace MMLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int n = int.Parse(Console.ReadLine());

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(PrintLogo.Print(n));
            
            //for (int i = 0; i <= n / 2; i++)
            //{
            //    //Upper half
            //    Console.Write(new string('-', n - i));
            //    Console.Write(new string('*', n + i));
            //    Console.Write(new string('*', i));
            //    Console.Write(new string('-', n - i - i));
            //    Console.Write(new string('*', n + i));
            //    Console.Write(new string('*', i));
            //    Console.Write(new string('-', n - i)); 
                
            //    Console.Write(new string('-', n - i));
            //    Console.Write(new string('*', n + i));
            //    Console.Write(new string('*', i));
            //    Console.Write(new string('-', n - i - i));
            //    Console.Write(new string('*', n + i));
            //    Console.Write(new string('*', i));
            //    Console.Write(new string('-', n - i));

            //    //Lower half

            //    Console.WriteLine();
            //}

            //for (int j = n / 2; j >= 0; j--)
            //{
            //    Console.Write(new string('-', j));
            //    Console.Write(new string('*', n));
            //    Console.Write(new string('-', n - j - j));
            //    Console.Write(new string('*', n + j));
            //    Console.Write(new string('*', j));
            //    Console.Write(new string('-', n - j - j));
            //    Console.Write(new string('*', n));
            //    Console.Write(new string('-', j)); 
                
            //    Console.Write(new string('-', j));
            //    Console.Write(new string('*', n));
            //    Console.Write(new string('-', n - j - j));
            //    Console.Write(new string('*', n + j));
            //    Console.Write(new string('*', j));
            //    Console.Write(new string('-', n - j - j));
            //    Console.Write(new string('*', n));
            //    Console.Write(new string('-', j));


            //    Console.WriteLine();
            //}


        }
    }
}
