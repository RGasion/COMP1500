using System;
using System.Collections.Generic;


namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> forReturn = new List<int>();

            int list1Length = sortedList1.Count;
            int list1Index = 0;
            int list2Length = sortedList2.Count;            
            int list2Index = 0;

            while (true)
            {
                if (list1Index == list1Length)
                {
                    for (; list2Index < list2Length; list2Index++)
                    {
                        forReturn.Add(sortedList2[list2Index]);
                    }
                    break;
                }
                else if (list2Index == list2Length)
                {
                    for (; list1Index < list1Length; list1Index++)
                    {
                        forReturn.Add(sortedList1[list1Index]);
                    }
                    break;
                }

                if (sortedList1[list1Index] < sortedList2[list2Index])
                {
                    forReturn.Add(sortedList1[list1Index++]);
                }
                else
                {
                    forReturn.Add(sortedList2[list2Index++]);
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

                forReturn.TryAdd(keys[keysIndex++], values[valuesIndex++]);
            }

            return forReturn;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            Dictionary<string, decimal> forReturn = new Dictionary<string, decimal>();

            if (numerators.Count == 0 || denominators.Count == 0)
            {
                return forReturn;
            }

            string[] stringKeys = new string[27];

            for (int i = 0; i < 26; i++)
            {
                stringKeys[i] = string.Format("{0}", (char)('a' + i));
            }

            for (int i = 0; i < 26; i++)
            {
                if (numerators.ContainsKey(stringKeys[i]) && denominators.ContainsKey(stringKeys[i]))
                {
                    int numeratorsValue;
                    int denominatorsValue;
                    numerators.TryGetValue(stringKeys[i], out numeratorsValue);
                    denominators.TryGetValue(stringKeys[i], out denominatorsValue);

                    if (denominatorsValue != 0)
                    {
                        forReturn.Add(stringKeys[i], Math.Abs((decimal)numeratorsValue / denominatorsValue));
                    }
                }
            }

            return forReturn;
        }
    }
}
