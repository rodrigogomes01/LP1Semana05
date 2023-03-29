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

            Stopwatch crono2 = new Stopwatch();
            crono2.Start();
            Thread.Sleep(300);
        }
    }
}