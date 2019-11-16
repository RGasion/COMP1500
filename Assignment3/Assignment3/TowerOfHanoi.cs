using System.Collections.Generic;

namespace Assignment3
{
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
            return null;
        }
    }
}
