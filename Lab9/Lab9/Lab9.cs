using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> forReturn = new List<int>();

            int List1Length = sortedList1.Count;
            int List1Index = 0;
            int List2Length = sortedList2.Count;            
            int List2Index = 0;

            while (true)
            {
                if (List1Index == List1Length)
                {
                    for (; List2Index < List2Length; List2Index++)
                    {
                        forReturn.Add(sortedList2[List2Index]);
                    }
                    break;
                }
                else if (List2Index == List2Length)
                {
                    for (; List1Index < List1Length; List1Index++)
                    {
                        forReturn.Add(sortedList1[List1Index]);
                    }
                    break;
                }

                if (sortedList1[List1Index] < sortedList2[List2Index])
                {
                    forReturn.Add(sortedList1[List1Index++]);
                }
                else
                {
                    forReturn.Add(sortedList2[List2Index++]);
                }
            }

            return forReturn;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            Dictionary<string, int> forReturn = new Dictionary<string, int>();

            int keysLength = keys.Count;
            int keysIndex = 0;
            int valuesLength = values.Count;            
            int valuesIndex = 0;

            while (true)
            {
                if (keysIndex == keysLength || valuesIndex == valuesLength)
                {
                    break;
                }

                if (!forReturn.TryAdd(keys[keysIndex], values[valuesIndex]))
                {
                    keysIndex++;
                }
                else
                {
                    keysIndex++;
                    valuesIndex++;
                }
            }

            return forReturn;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            return null;
        }
    }
}
