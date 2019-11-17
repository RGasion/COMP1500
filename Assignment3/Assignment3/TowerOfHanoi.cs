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

            List<int>[] saveProcess = new List<int>[3];
            for (int tower = 0; tower < 3; tower++)
            {
                saveProcess[tower] = new List<int>();
                for (int count = 0; count < field[tower].Count; count++)
                {
                    saveProcess[tower].Add(field[tower][count]);
                }
            }

            process.Add(saveProcess);

            MoveRecursive(numDiscs, EDirection.Left, EDirection.Right, ref field, ref process);
            
            return process;
        }
        
        //특정 갯수의 원판들을 왼쪽에서 해당 위치로 이동시키는 함수
        public static void MoveRecursive(int numDiscs, EDirection origin, EDirection dest, ref List<int>[] field, ref List<List<int>[]> process)
        {
            //왼쪽에서 센터로 (Recursive) -> 마지막 원판을 오른쪽으로 -> 센터를 오른쪽으로 (Recursive)
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
                
                //copy
                List<int>[] saveProcess = new List<int>[3];
                for (int tower = 0; tower < 3; tower++)
                {
                    saveProcess[tower] = new List<int>();
                    for (int count = 0; count < field[tower].Count; count++)
                    {
                        saveProcess[tower].Add(field[tower][count]);
                    }
                }

                process.Add(saveProcess);

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

            MoveRecursive(numDiscs - 1, origin, tmp, ref field, ref process);

            MoveRecursive(1, origin, dest, ref field, ref process);

            MoveRecursive(numDiscs - 1, tmp, dest, ref field, ref process);
        }

    }
}
