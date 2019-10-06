using System;
using System.Diagnostics;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] canvas01 = Canvas.Draw(10, 8, EShape.Rectangle);
            printCanvas(canvas01);
            Console.WriteLine($"{Canvas.IsShape(canvas01, EShape.Rectangle)}");


            char[,] canvas02 = Canvas.Draw(10, 10, EShape.IsoscelesRightTriangle);
            printCanvas(canvas02);
            Console.WriteLine($"{Canvas.IsShape(canvas02, EShape.IsoscelesRightTriangle)}");
            

            char[,] canvas03 = Canvas.Draw(13, 7, EShape.IsoscelesTriangle);
            printCanvas(canvas03);
            Console.WriteLine($"{Canvas.IsShape(canvas03, EShape.IsoscelesTriangle)}");

            char[,] canvas04 = Canvas.Draw(10, 10, EShape.Circle);
            printCanvas(canvas04);
            Console.WriteLine($"{Canvas.IsShape(canvas04, EShape.Circle)}");
            
        }

        // canvas를 콘솔 창에 출력해주는 도우미 함수
        private static void printCanvas(char[,] canvas)
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}