﻿using System;

namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length < 2 || array[0] == 0 || array[array.Length - 1] != 0)
            {
                return false;
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] == 0)
                {
                    return false;
                }
            }

            uint start = array[0];
            uint dest = array[array.Length - 1];

            return SearchAnswer(array, start, dest);
        }

        public static bool SearchAnswer(uint[] array, uint position, uint dest)
        {
            if (position <= 0 || position >= array.Length)
            {
                return false;
            }
            else if (position == array.Length - 1)
            {
                return true;
            }

            uint left = position - array[position];
            uint right = position + array[position];

            return SearchAnswer(array, left, dest) || SearchAnswer(array, right, dest);
        }
    }
}