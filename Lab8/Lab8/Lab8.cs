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

            string[] splitString = s.Split('\n');
            StringBuilder forReturn = new StringBuilder(4096);

            for (int i = 0; i < splitString.Length; i++)
            {       
                string tmp = splitString[i];

                int pos;
                int level = 0;
                for (pos = 0; tmp[pos] == '\t'; pos++)
                {
                    level++;
                }
                
                if (level == 0 && i != 0)
                {
                    forReturn.Append('|');
                }
                else if (level == 1 && i != 0)
                {
                    forReturn.Append('_');
                }
                else if (level == 2 && i != 0)
                {
                    forReturn.Append('/');
                }
                else if (level > 2)
                {
                    return null;
                }

                for (; !(tmp[pos] >= 'A' && tmp[pos] <= 'Z' || tmp[pos] >= 'a' && tmp[pos] <= 'z'); pos++) { }

                forReturn.Append(tmp.Substring(pos));
            }            

            if(forReturn == null)
            {
                return null;
            }
            return forReturn.ToString();
        }
    }
}
