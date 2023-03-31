using System;
using System.IO;

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

        StringWriter underscore = new StringWriter();
        for (int i = 0; i < args.Length; i++)

                underscore.Write(args[i]);
                if (i != args.Length - 1)
                {
                    underscore.Write("_");
                }
        }
    }
}