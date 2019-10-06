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

            char[,] canvas02 = Canvas.Draw(10, 10, EShape.IsoscelesRightTriangle);
            printCanvas(canvas02);

            char[,] canvas03 = Canvas.Draw(9, 5, EShape.IsoscelesTriangle);
            printCanvas(canvas03);

            char[,] canvas04 = Canvas.Draw(10, 10, EShape.Circle);
            printCanvas(canvas04);
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