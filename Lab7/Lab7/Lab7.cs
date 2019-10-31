using System;

namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            
            if (array.Length < 2)   // 배열 길이 확인
            {
                return false;
            }
            else if (array[0] == 0 || array[0] >= array.Length) // 메타데이터 확인
            {
                return false;
            }
            else if (array[array.Length - 1] != 0)  // 마지막 요소 확인
            {
                return false;
            }

            for (int i = 1; i < array.Length - 1; i++)  // 마지막 요소 이외에 0이 있는지 확인
            {
                if (array[i] == 0)
                {
                    return false;
                }
            }

            uint[] loopCheck = new uint[array.Length];
            return SearchRecursive(array, loopCheck, array[0]);
        }

        public static bool SearchRecursive(uint[] array, uint[] loopCheck, uint position)
        {
            //색인 체크와 정답 확인
            if (position == 0 || position >= array.Length)
            {
                return false;
            }
            else if (array[position] == 0)
            {
                return true;
            }

            //루프 체크 : 한 번 체크한 색인은 더 이상 체크할 필요가 없다
            if (loopCheck[position] > 1)
            {
                return false;
            }
            else
            {
                loopCheck[position]++;
            }

            uint left;  //left 변수의 언더플로우로 문제가 발생할 여지를 차단하기 위한 코드, 대소 구분없이 뺀 값을 대입해도 테스트는 통과 가능
            if (position > array[position])
            {
                left = position - array[position];
            }
            else
            {
                left = 0;
            }
            uint right = position + array[position];
            /*
             * right 변수는 테스트 환경에서 오버플로우가 일어날 가능성이 작기 때문에 오버플로우 관련 코드를 추가하지 않음
             * uint 범위 : 0 ~ 4,294,967,295
             */

            //목적지는 항상 배열의 오른쪽 끝에 위치하기 때문에 오른쪽을 먼저 체크
            return (SearchRecursive(array, loopCheck, right) || SearchRecursive(array, loopCheck, left));
        }
    }
}
