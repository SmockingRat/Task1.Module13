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
            Stopwatch swatch = Stopwatch.StartNew();

            ////First list
            while (!read.EndOfStream)
            {
                nlist.Add(read.ReadLine());
            }

            double fnum = swatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время первой операции - {fnum}");

            ////Second list
            while (!read.EndOfStream)
            {
                llist.AddLast(read.ReadLine());
            }

            double snum = swatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Время первой операции - {snum}");

            ////Difference in time
            Console.WriteLine($"Разница - {snum - fnum}");
            Console.ReadLine();
        }
    }
}
