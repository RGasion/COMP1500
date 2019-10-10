using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] arr)
        {
            if (arr.Length == 0)
            {
                return arr;
            }
            int originRow = arr.GetUpperBound(0) + 1;
            int originColumn = arr.GetUpperBound(1) + 1;

            int[,] arrReturn = new int[originColumn, originRow];

            for (int copyColumn = 0; copyColumn < originRow; copyColumn++)
            {
                for (int copyRow = 0; copyRow < originColumn; copyRow++)
                {
                    arrReturn[copyRow, arr.GetUpperBound(0) - copyColumn] = arr[copyColumn, copyRow];
                }
            }

            return arrReturn;
        }

        public static void TransformArray(ref int[,] arr, EMode mode)
        {
            int originRow = arr.GetUpperBound(0) + 1;
            int originColumn = arr.GetUpperBound(1) + 1;
            int tmp;            
            if (mode == EMode.HorizontalMirror)
            {
                int count = originColumn / 2;
                
                for (int processRow = 0; processRow < originRow; processRow++)
                {
                    for (int processColumn = 0; processColumn < count; processColumn++)
                    {
                        tmp = arr[processRow, processColumn];
                        arr[processRow, processColumn] = arr[processRow, originColumn - 1 - processColumn];
                        arr[processRow, originColumn - 1 - processColumn] = tmp;
                    }
                }
            }
            else if (mode == EMode.VerticalMirror)
            {
                int count = originRow / 2;

                for (int processColumn = 0; processColumn < originColumn; processColumn++)
                {
                    for (int processRow = 0; processRow < count; processRow++)
                    {
                        tmp = arr[processRow, processColumn];
                        arr[processRow, processColumn] = arr[originRow - 1 - processRow, processColumn];
                        arr[originRow - 1 - processRow, processColumn] = tmp;
                    }
                }
            }
            else if (mode == EMode.DiagonalShift)
            {

            }
        }
    }
}
