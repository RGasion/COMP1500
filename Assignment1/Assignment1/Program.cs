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
            //정수 처리 관련 체크 012, 3, 4, 5
            string integersTest_b0 = "1\n4\n9\n16\n31\n";
            //양의 정수를 입력했을 때, 각 진수의 출력 확인
            string integersTest_b3 = " 52\n  102\n      1\n         2382\n                409\n";
            //정수 앞에 하나 이상의 빈 칸을 넣어서 입력했을 때 출력 확인
            string integersTest_b4 = "52 \n102   \n1      \n2382          \n409               ";
            //정수 뒤에 하나 이상의 빈 칸을 넣어서 입력했을 때 출력 확인
            string integersTest_b5 = " 52 \n   102   \n      1      \n         2382         \n            409                 \n";
            //정수 앞뒤에 하나 이상의 빈 칸을 넣어서 입력했을 때 출력 확인
            string statsTest = " 12.5\n-25.2625 \n  -12\n10008   \n   -1224.2   \n";

            byte[] buffer_IB0 = Encoding.UTF8.GetBytes(integersTest_b0);
            byte[] buffer_IB3 = Encoding.UTF8.GetBytes(integersTest_b3);
            byte[] buffer_IB4 = Encoding.UTF8.GetBytes(integersTest_b4);
            byte[] buffer_IB5 = Encoding.UTF8.GetBytes(integersTest_b5);

            byte[] buffer2 = Encoding.UTF8.GetBytes(statsTest);
            
            using (StreamReader READER_IB0 = new StreamReader(new MemoryStream(buffer_IB0)))
            using (StreamReader READER_IB3 = new StreamReader(new MemoryStream(buffer_IB3)))
            using (StreamReader READER_IB4 = new StreamReader(new MemoryStream(buffer_IB4)))
            using (StreamReader READER_IB5 = new StreamReader(new MemoryStream(buffer_IB5)))
            using (StreamReader READER2 = new StreamReader(new MemoryStream(buffer2))) 
            

            using (StreamWriter WRITER = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
            {
                Console.WriteLine("Streamtest: PrintIntegers B012");
                Assignment1.PrintIntegers(READER_IB0, WRITER);

                Console.WriteLine("Streamtest: PrintIntegers B3");
                Assignment1.PrintIntegers(READER_IB3, WRITER);

                Console.WriteLine("Streamtest: PrintIntegers B4");
                Assignment1.PrintIntegers(READER_IB4, WRITER);

                Console.WriteLine("Streamtest: PrintIntegers B5");
                Assignment1.PrintIntegers(READER_IB5, WRITER);

                Console.WriteLine("Streamtest: PrintStats");
                Assignment1.PrintStats(READER2, WRITER);
            }

            Console.WriteLine("\n\nTest Assignment 1\n");

        }
    }
}
