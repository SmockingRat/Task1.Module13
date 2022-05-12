using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Task1.Module13
{
    /// <summary>
    /// Central  class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Central method
        /// </summary>
        /// <param name="args"> Entry paprameter </param>
        static void Main(string[] args)
        {
            ////Adding two lists
            List<string> nlist = new List<string>();
            LinkedList<string> llist = new LinkedList<string>();

            ////Adding URL of file and time counter
            StreamReader read = new StreamReader("C:\\Users\\Михаил\\Downloads\\Text1.txt");
            Stopwatch fwatch = Stopwatch.StartNew();

            ////First list
            while (!read.EndOfStream)
            {
                nlist.Add(read.ReadLine());
            }

            double fnum = fwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время первой операции - {fnum}");
            fwatch.Reset();


            Stopwatch swatch = Stopwatch.StartNew();
            ////Second list
            while (!read.EndOfStream)
            {
                llist.AddLast(read.ReadLine());
            }

            double snum = swatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время второй операции - {snum}");
            swatch.Reset();

            ////Difference in time
            Console.WriteLine($"Разница в заполнении - {snum - fnum}");

            fwatch.Start();
            foreach(var i in nlist)
            {
                Console.Write("");
            }

            fnum = fwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время первого перебора - {fnum}");
            fwatch.Reset();

            swatch.Start();
            foreach (var i in llist)
            {
                Console.Write("");
            }

            snum = swatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время второго перебора - {snum}");
            swatch.Reset();

            Console.WriteLine($"Разница в переборе - {snum - fnum}");


            fwatch.Start();
            nlist.Add("fsfsfsf");

            fnum = fwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время первого добавления - {fnum}");
            fwatch.Reset();


            swatch.Start();
            nlist.Add("fsfsfsf");

            snum = swatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время второго добавления - {snum}");
            swatch.Reset();

            Console.WriteLine($"Разница в добавлении - {snum - fnum}");



            Console.ReadLine();
        }
    }
}
