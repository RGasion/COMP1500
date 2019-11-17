using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------MergeDictionaries------------------------------*/
            /*3-1case*/
            Dictionary<string, int> numerators = new Dictionary<string, int>
           {
               { "a", 53 },
               { "b", -14 },
               { "c", 5 },
               { "d", 235 },
               { "g", 1 },
           };
            Dictionary<string, int> denominators = new Dictionary<string, int>
           {
               { "a", 77 },
               { "b", 235 },
               { "c", -3 },
               { "d", 121 },
               { "e", 8 },
               { "f", -621 },
           };
            
           Dictionary<string, decimal> result = Lab9.MergeDictionaries(numerators, denominators);
            Dictionary<string, decimal> expectedResult = new Dictionary<string, decimal>
           {
               { "a", 0.6883116883116883116883116883m },
               { "b", 0.0595744680851063829787234043m },
               { "c", 1.6666666666666666666666666667m },
               { "d", 1.9421487603305785123966942149m }
           };
            
           Console.WriteLine("Case3-1");
            printDictionary(result);
            
           Debug.Assert(expectedResult.Count == result.Count);
            
           foreach (var keyvaluePair in expectedResult)
            {
                Debug.Assert(keyvaluePair.Value == result[keyvaluePair.Key]);
            }
           
           /*3-2case*/
           numerators = new Dictionary<string, int>
           {
               { "a", 31 },
               { "b", 37 },
               { "c", 0 },
               { "d", -13 },
               { "e", 77 },
               { "f", 235 },
               { "g", 49},
               { "h", -11},
               { "i", 31}
           };
            denominators = new Dictionary<string, int>
           {
               { "b", 77 },
               { "c", 0 },
               { "d", 3 },
               { "g", -121 },
               { "i", -101},
               { "k", 3}
           };
            
           result = Lab9.MergeDictionaries(numerators, denominators);
            expectedResult = new Dictionary<string, decimal>
           {
               { "b", 0.4805194805194805194805194805m },
               { "d", 4.3333333333333333333333333333m },
               { "g", 0.4049586776859504132231404959m },
               { "i", 0.3069306930693069306930693069m }
           };

           Console.WriteLine("Case3-2");
            printDictionary(result);
            
           Debug.Assert(expectedResult.Count == result.Count);
            
           foreach (var keyvaluePair in expectedResult)
            {
                Debug.Assert(keyvaluePair.Value == result[keyvaluePair.Key]);
            }
           
           /*3-3case*/
           numerators = new Dictionary<string, int>
           {
               { "b", 77 },
               { "c", 235 },
               { "d", 3 },
               { "g", -121 },
               { "i", -32},
               { "k", 3}
           };
            denominators = new Dictionary<string, int>
           {
               { "a", 31 },
               { "b", 0 },
               { "c", 0 },
               { "d", -42 },
               { "e", 77 },
               { "f", 235 },
               { "g", 49},
               { "h", -11},
               { "i", 31}
           };

            result = Lab9.MergeDictionaries(numerators, denominators);
            expectedResult = new Dictionary<string, decimal>
           {
               { "d", 0.0714285714285714285714285714m },
               { "g", 2.4693877551020408163265306122m },
               { "i", 1.0322580645161290322580645161m }
           };
            
           Console.WriteLine("Case3-3");
            printDictionary(result);
            
           foreach (var keyvaluePair in expectedResult)
            {
                Debug.Assert(keyvaluePair.Value == result[keyvaluePair.Key]);
            }
        }
        
       private static void printDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
        {
            StringBuilder sb = new StringBuilder();
            
           sb.Append("[ ");
            
           foreach (var keyvaluepair in dict)
            {
                sb.Append($"{{ {keyvaluepair.Key}, {keyvaluepair.Value} }}, ");
            }
           
           string s = sb.ToString().Trim().Trim(',');
            Console.WriteLine($"{s} ]");
        }
    }
}