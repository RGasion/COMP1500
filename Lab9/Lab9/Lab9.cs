using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> forReturn = new List<int>();

            int sortedList1Count = sortedList1.Count;
            int sortedList2Count = sortedList2.Count;
            int listIndex1 = 0;
            int listIndex2 = 0;

            while (true)
            {
                if (listIndex1 == sortedList1Count)
                {
                    for (; listIndex2 < sortedList2Count; listIndex2++)
                    {
                        forReturn.Add(sortedList2[listIndex2]);
                    }
                    break;
                }
                else if (listIndex2 == sortedList2Count)
                {
                    for (; listIndex1 < sortedList1Count; listIndex1++)
                    {
                        forReturn.Add(sortedList1[listIndex1]);
                    }
                    break;
                }

                if (sortedList1[listIndex1] < sortedList2[listIndex2])
                {
                    forReturn.Add(sortedList1[listIndex1++]);
                }
                else
                {
                    forReturn.Add(sortedList2[listIndex2++]);
                }
            }

            return forReturn;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            Dictionary<string, int> forReturn = new Dictionary<string, int>();


            return null;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            return null;
        }
    }
}
