﻿using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
        {
            args[i] = args[i].ToLower();
        }
        
        Array.Sort(args);
        
        for (int i = 0; i < args.Length; i++)

                Console.WriteLine(args[i]);
        }
    }
}