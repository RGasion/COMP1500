using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output)
        {
            int integers1 = int.Parse(input.ReadLine());
            int integers2 = int.Parse(input.ReadLine());
            int integers3 = int.Parse(input.ReadLine());
            int integers4 = int.Parse(input.ReadLine());
            int integers5 = int.Parse(input.ReadLine());

            output.WriteLine($"{"oct",12} {"dec",10} {"hex",8}");
            output.WriteLine("------------ ---------- --------");//12 10 8

            output.WriteLine("{0, 12} {1, 10} {2, 8}", Convert.ToString(integers1, 8), integers1.ToString(), integers1.ToString("X"));
            output.WriteLine("{0, 12} {1, 10} {2, 8}", Convert.ToString(integers2, 8), integers2.ToString(), integers2.ToString("X"));
            output.WriteLine("{0, 12} {1, 10} {2, 8}", Convert.ToString(integers3, 8), integers3.ToString(), integers3.ToString("X"));
            output.WriteLine("{0, 12} {1, 10} {2, 8}", Convert.ToString(integers4, 8), integers4.ToString(), integers4.ToString("X"));
            output.WriteLine("{0, 12} {1, 10} {2, 8}", Convert.ToString(integers5, 8), integers5.ToString(), integers5.ToString("X"));

        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            float[] stats = new float[5];
            stats[0] = float.Parse(input.ReadLine());
            stats[1] = float.Parse(input.ReadLine());
            stats[2] = float.Parse(input.ReadLine());
            stats[3] = float.Parse(input.ReadLine());
            stats[4] = float.Parse(input.ReadLine());

            output.WriteLine($"{"",10}{stats[0].ToString("F3"),10}");
            output.WriteLine($"{"",10}{stats[1].ToString("F3"),10}");
            output.WriteLine($"{"",10}{stats[2].ToString("F3"),10}");
            output.WriteLine($"{"",10}{stats[3].ToString("F3"),10}");
            output.WriteLine($"{"",10}{stats[4].ToString("F3"),10}");

            float min = stats[0];
            for (int i = 1; i<5; i++ )
            {
                if (min > stats[i])
                {
                    min = stats[i];
                }
            }
            output.WriteLine($"{"Min",-9} {min.ToString("F3"),10}");

            float max = stats[0];
            for (int i = 1; i< 5; i++)
            {
                if (max < stats[i])
                {
                    max = stats[i];
                }
            }
            output.WriteLine($"{"Max",-10}{max.ToString("F3"),10}");

            float sum = stats[0] + stats[1] + stats[2] + stats[3] + stats[4];
            output.WriteLine($"{"Sum",-10}{sum.ToString("F3"),10}");

            float avr = sum / 5;
            output.WriteLine($"{"Average",-10}{avr.ToString("F3"),10}");
        }
    }
}
