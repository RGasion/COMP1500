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
            int originColumn = arr.Length / originRow;

            int[,] arrReturn = new int[originColumn, originRow];

            for (int copyColumn = 0; copyColumn < originRow; copyColumn++)
            {
                for(int copyRow = 0; copyRow < originColumn; copyRow++)
                {
                    arrReturn[copyRow, arr.GetUpperBound(0) - copyColumn] = arr[copyColumn, copyRow];
                }
            }

            return arrReturn;
        }

        public static void TransformArray(int[,] arr, EMode mode)
        {
            if (mode == EMode.HorizontalMirror)
            {

            }
            else if (mode == EMode.VerticalMirror)
            {

            }
            else if (mode == EMode.DiagonalShift)
            {

            }
        }
    }
}
