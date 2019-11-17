using System;
using System.Collections.Generic;

namespace Assignment3
{
    public enum EDirection { Center, Right };
    public static class TowerOfHanoi
    {

        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 0)
            {
                return -1;
            }
            
            if (numDiscs == 0)
            {
                return 0;
            }

            return 2 * GetNumberOfSteps(numDiscs - 1) + 1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            List<List<int>[]> field = new List<List<int>[]>();

            if (!(numDiscs > 0))
            {
                return field;
            }
            
            return null;
        }
        
        //특정 갯수의 원판들을 이동시키는 함수
        public static List<List<int>[]> MoveRecursive(int numDiscs, EDirection direction, List<List<int>[]> field)
        {
            MoveRecursive(numDiscs - 1, EDirection.Center, field);
            return null;
        }
    }
}
