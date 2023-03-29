using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);
            crono1.Stop();
            Console.WriteLine("crono1: {0:F2}", crono1.Elapsed.TotalSeconds);

            Stopwatch crono2 = new Stopwatch();
            crono2.Start();
            Thread.Sleep(300);
            crono2.Stop();
            Console.WriteLine("crono2: {0:F2}", crono1.Elapsed.TotalSeconds);
        }
    }
}