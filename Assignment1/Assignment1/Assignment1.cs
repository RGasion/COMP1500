using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static int PrintIntegers(StreamReader READER, StreamWriter WRITER)
        {
            int integers = int.Parse(Console.ReadLine());

            Console.WriteLine(integers);
            return 0;
        }

        public static int PrintStats(StreamReader READER, StreamWriter WRITER)
        {
            float stats = float.Parse(Console.ReadLine());

            Console.WriteLine(stats);
            return 0;
        }
    }
}
