using System;

namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            
            if (array.Length < 2) //유효한 배열 길이 확인
            {
                return false;
            }
            else if (array[0] == 0 || array[0] >= array.Length) //유효한 메타데이터 값 확인
            {
                return false;
            }
            else if (array[array.Length - 1] != 0) // 마지막 요소가 0인지 확인
            {
                return false;
            }

            for (int i = 1; i < array.Length - 1; i++) // 마지막 요소 이외에 0값이 있는지 확인
            {
                if (array[i] == 0)
                {
                    return false;
                }
            }

            uint start = array[0];
            uint dest = array[array.Length - 1];

            return SearchRecursive(array, start);
        }

        public static bool SearchRecursive(uint[] array, uint position)
        {
            if (position == 0 || position >= array.Length) //유효한 위치 확인
            {
                return false;
            }
            else if (array[position] == 0)
            {
                return true;
            }

            
            if (position < array[position])
            {
                uint right = position + array[position];

                return SearchRecursive(array, right);
            }
            else
            {
                uint left = position - array[position];
                uint right = position + array[position];

                return (SearchRecursive(array, left) || SearchRecursive(array, right));
            }
            
        }
    }
}
