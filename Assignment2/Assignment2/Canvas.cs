using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public static class Canvas
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            if (width == 0 || height == 0)
            {
                char[,] fail = new char[0, 0];
                return fail;
            }

            char[,] canvas = new char[height + 4, width + 4];

            //초기화 작업  
            for (int i = 0; i < width + 4; i++)             
            {
                canvas[0, i] = canvas[height + 3, i] = '-';
            }

            for (int i = 1; i <= height + 2; i++)
            {
                canvas[i, 0] = canvas[i, width + 3] = '|';
                for (int k = 0; k < width + 2; k++)
                {
                    canvas[i, k + 1] = ' ';
                }
            }

            //EShape 값에 따른 canvas 처리
            if (shape == EShape.Rectangle)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int k = 0; k < width; k++)
                    {
                        canvas[i + 2, k + 2] = '*';
                    }
                }
            }
            else if (shape == EShape.IsoscelesRightTriangle)
            {
                if (width != height)
                {
                    char[,] fail = new char[0, 0];
                    return fail;
                }
                else
                {
                    uint cnt = 0;
                    for (int i = 0; i < height; i++)
                    {
                        cnt++;
                        for (int k = 0; k < cnt; k++)
                        {
                            canvas[i + 2, k + 2] = '*';
                        }
                    }
                }
            }
            else if (shape == EShape.IsoscelesTriangle)
            {
                if (width != height * 2 - 1)
                {
                    char[,] fail = new char[0, 0];
                    return fail;
                }
                else
                { 
                    uint chk = (width + 1) / 2 - 1;
                    uint cnt = 0;
                    for (int i = 0; i < height; i++)
                    {
                        for (int k = 0; k < width; k++)
                        {
                            if (k >= chk - cnt && k <= chk + cnt)
                            {
                                canvas[i + 2, k + 2] = '*';
                            }
                        }
                        cnt++;
                    }
                }
            }
            else if (shape == EShape.Circle)
            {
                if (width != height || width % 2 == 0)
                {
                    char[,] fail = new char[0, 0];
                    return fail;
                }
                else
                {
                    uint radius = width / 2;
                    //center = canvas[radius][radius]
                    for (int row = 0; row < height; row++)
                    {
                        for (int column = 0; column < width; column++)
                        {
                            if (Math.Pow(radius, 2) >= Math.Pow(Math.Abs(row - radius), 2) + Math.Pow(Math.Abs(column - radius), 2))
                            {
                                canvas[row + 2, column + 2] = '*';
                            }
                        }
                    }
                }
            }

            return canvas;
        }

        public static bool IsShape(char[,] canvas, EShape shape)
        {
            //길이 0 배열 확인
            if (canvas.Length == 0)
            {
                return false;
            }

            int height = canvas.GetUpperBound(0) + 1;
            int width = canvas.Length / height;

            width -= 4;
            height -= 4;

            //기준보다 작은 배열 확인
            if (width <= 0 || height <= 0)
            {
                return false;
            }
            
            if (shape == EShape.Rectangle)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int k = 0; k < width; k++)
                    {
                        if (canvas[i + 2, k + 2] != '*')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else if (shape == EShape.IsoscelesRightTriangle)
            {
                //기본 정의 확인
                if (height != width)
                {
                    return false;
                }
                else
                {
                    uint cnt = 0;
                    for (int i = 0; i < height; i++)
                    {
                        cnt++;
                        for (int k = 0; k < width; k++)
                        {
                            if (k < cnt)
                            {
                                if (canvas[i + 2, k + 2] != '*')
                                {
                                    return false;
                                }                                
                            }
                            else
                            {
                                if (canvas[i + 2, k + 2] != ' ')
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
            }
            else if (shape == EShape.IsoscelesTriangle)
            {
                //기본 정의 확인
                if (width != height * 2 - 1)
                {
                    return false;
                }
                else
                {
                    int chk = (width + 1) / 2 - 1;
                    int cnt = 0;
                    for (int i = 0; i < height; i++)
                    {
                        for (int k = 0; k < width; k++)
                        {
                            if (k >= chk - cnt && k <= chk + cnt)
                            {
                                if (canvas[i + 2, k + 2] != '*')
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (canvas[i + 2, k + 2] != ' ')
                                {
                                    return false;
                                }
                            }
                        }
                        cnt++;
                    }
                    return true;
                }
            }
            else if (shape == EShape.Circle)
            {
                if (width != height || width % 2 == 0)
                {
                    return false;
                }
                else
                {
                    int radius = width / 2;
                    
                    for (int row = 0; row < height; row++)
                    {
                        for (int column = 0; column < width; column++)
                        {
                            if (Math.Pow(radius, 2) >= Math.Pow(Math.Abs(row - radius), 2) + Math.Pow(Math.Abs(column - radius), 2))
                            {
                                if (canvas[row + 2, column + 2] != '*')
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                if (canvas[row + 2, column + 2] != ' ')
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
