using System;
using System.Collections.Generic;

namespace Assignment3
{
    public enum EDirection { Left, Center, Right };
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
            List<List<int>[]> process = new List<List<int>[]>();

            if (!(numDiscs > 0))
            {
                return process;
            }

            //초기화 작업
            List<int>[] field = new List<int>[3];

            field[0] = new List<int>();
            field[1] = new List<int>();
            field[2] = new List<int>();
            for (int i = 0; i < numDiscs; i++)
            {
                field[0].Add(numDiscs - i);
            }

            process.Add(SaveProcess(field));

            MoveRecursive(numDiscs, EDirection.Left, EDirection.Right, ref field, ref process);

            return process;
        }

        public static void MoveRecursive(int numDiscs, EDirection origin, EDirection dest, ref List<int>[] field, ref List<List<int>[]> process)
        {
            int plate = 0;
            if (numDiscs == 0)
            {
                return;
            }
            if (numDiscs == 1)
            {
                plate = field[(int)origin][field[(int)origin].Count - 1];
                field[(int)origin].Remove(plate);

                field[(int)dest].Add(plate);
                
                process.Add(SaveProcess(field));

                return;
            }

            EDirection tmp;
            if ((int)origin * (int)dest != 0)
            {
                tmp = EDirection.Left;
            }
            else
            {
                if ((int)origin + (int)dest == 1)
                {
                    tmp = EDirection.Right;
                }
                else
                {
                    tmp = EDirection.Center;
                }
            }

            //[Left → Center](n-1) -> [Left → Right](1) -> [Center → Right](n-1)
            MoveRecursive(numDiscs - 1, origin, tmp, ref field, ref process);

            MoveRecursive(1, origin, dest, ref field, ref process);

            MoveRecursive(numDiscs - 1, tmp, dest, ref field, ref process);
        }

        public static List<int>[] SaveProcess(List<int>[] field)
        {
            List<int>[] forReturn = new List<int>[3];

            for (int tower = 0; tower < 3; tower++)
            {
                forReturn[tower] = new List<int>();
                for (int count = 0; count < field[tower].Count; count++)
                {
                    forReturn[tower].Add(field[tower][count]);
                }
            }

            return forReturn;
        }

    }
}
