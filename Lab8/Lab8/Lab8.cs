using System;
using System.Text;

namespace Lab8
{
    class Lab8
    {
        public static string PrettifyList(string s)
        {
            /*
            1. 목록의 각 항목 앞에 붙는 숫자와 문자를 제거
            2. 목록의 첫 번째 레벨에 있는 항목은 | 문자로 분리 ()
            3. 목록의 두 번째 레벨에 있는 항목은 _ 문자로 분리 (\t)
            4. 목록의 세 번째 레벨에 있는 항목은 / 문자로 분리 (\t\t)
             */

            string[] splitLv1 = s.Split('|');
            StringBuilder forReturn = new StringBuilder(4096);

            int lv1 = 0;
            for (int cntLv1 = 0; cntLv1 < splitLv1.Length; cntLv1++)
            {
                string[] splitLv2 = splitLv1[cntLv1].Split('_');

                forReturn.Append($"{++lv1}) ");
                forReturn.AppendLine($"{splitLv2[0]}");

                for(int cntLv2 = 1; cntLv2 < splitLv2.Length; cntLv2++)
                {
                    string[] splitLv3 = splitLv2[cntLv2].Split('/');

                    forReturn.Append($"\t{(char)('a' + cntLv2)}) ");
                    forReturn.AppendLine($"{splitLv3[0]}");

                    if (splitLv3.Length != 1)
                    {
                        for (int cntLv3 = 1; cntLv3 < splitLv3.Length; cntLv3++)
                        {
                            forReturn.Append($"\t\t- ");
                            forReturn.AppendLine($"{splitLv3[cntLv3]}");
                        }
                    }
                }
            }

            if (forReturn == null)
            {
                return null;
            }

            return forReturn.ToString();
        }
    }
}
