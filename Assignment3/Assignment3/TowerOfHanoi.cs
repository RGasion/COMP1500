using System.Collections.Generic;

namespace Assignment3
{
    enum Direction { Center, Right}
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
            return field;
            /*
            //상태 초기화
            List<int>[] towerChk = field[0];            
            for (int i = numDiscs; i > 0; i--)
            {
                field[0][i - numDiscs] = i;
            }
            return null;*/
        }
        /*
        //특정 갯수의 원판들을 이동시키는 함수
        public static List<List<int>[]> RecursiveMove(int numDiscs, Direction direction, List<List<int>[]> field)
        {
            Move(numDiscs - 1, Direction.Center, field);
            return null;
        }*/
    }
}
