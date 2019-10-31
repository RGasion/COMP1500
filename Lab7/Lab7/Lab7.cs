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
            uint[] loopCheck = new uint[array.Length];

            return SearchRecursive(array, loopCheck, start);
        }

        public static bool SearchRecursive(uint[] array, uint[] loopCheck, uint position)
        {
            //잘못된 색인범위 or 정답찾기 성공
            if (position == 0 || position >= array.Length)
            {
                return false;
            }
            else if (array[position] == 0)
            {
                return true;
            }

            //루프 체크
            if (loopCheck[position] > 1)
            {
                return false;
            }
            else
            {
                loopCheck[position]++;
            }

            uint left = position - array[position];
            uint right = position + array[position];

            return (SearchRecursive(array, loopCheck, right) || SearchRecursive(array, loopCheck, left));

        }
    }
}
