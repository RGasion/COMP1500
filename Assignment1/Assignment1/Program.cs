using System.Diagnostics;
using System.IO;
using System.Text;
using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string integersTest = "             52\n102   \n   1      \n         2382\n  409\n";
            string statsTest = " 12.5\n-25.262 \n  -12\n10008.2   \n   -1224.2   \n";

            byte[] buffer1 = Encoding.UTF8.GetBytes(integersTest);
            byte[] buffer2 = Encoding.UTF8.GetBytes(statsTest);
            
            
            using (StreamReader READER1 = new StreamReader(new MemoryStream(buffer1))) 
            using (StreamReader READER2 = new StreamReader(new MemoryStream(buffer2))) 
            

            using (StreamWriter WRITER = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
            {
                Console.WriteLine("Enter your 5 digits for PrintIntegers():");
                Assignment1.PrintIntegers(READER1, WRITER);

                Console.WriteLine("Enter your 5 digits for PrintStats():");
                Assignment1.PrintStats(READER2, WRITER);
            }

            Console.WriteLine("\n\nTest Assignment 1\n");

        }
    }
}
