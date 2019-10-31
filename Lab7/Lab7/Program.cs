using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[0];
            bool bPass = Lab7.PlayGame(array); // false
            Console.WriteLine($"{bPass}");

            array = new uint[3] { 3, 2, 0 };
            bPass = Lab7.PlayGame(array); // false
            Console.WriteLine($"{bPass}");

            array = new uint[4] { 10, 2, 10, 0 };
            bPass = Lab7.PlayGame(array); // false
            Console.WriteLine($"{bPass}");

            array = new uint[3] { 2, 2, 0 };
            bPass = Lab7.PlayGame(array); // true
            Console.WriteLine($"{bPass}");

            array = new uint[3] { 1, 1, 0 };
            bPass = Lab7.PlayGame(array); // true
            Console.WriteLine($"{bPass}");

            array = new uint[7] { 3, 1, 4, 2, 8, 6, 0 };
            bPass = Lab7.PlayGame(array); // true
            Console.WriteLine($"{bPass}");

            array = new uint[1] { 0 };
            bPass = Lab7.PlayGame(array); // false
            Console.WriteLine($"{bPass}");

            array = new uint[7] { 0, 1, 4, 2, 5, 6, 0 };
            bPass = Lab7.PlayGame(array); // false
            Console.WriteLine($"{bPass}");

            array = new uint[5] { 1, 1, 2, 1, 0};
            bPass = Lab7.PlayGame(array); // True
            Console.WriteLine($"{bPass}");
        }
    }
}
