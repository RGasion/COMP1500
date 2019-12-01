using System;
using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            const int MAX_COUNT = 255;

            int count = 0;
            char baseChar = '\0';
            char checkChar;
            for (int i = 0; i < input.Length; i++)
            {
                if (count == 0)
                {
                    baseChar = (char)input.ReadByte();

                    count++;
                }
                else
                {
                    checkChar = (char)input.ReadByte();
                    if (checkChar == baseChar)
                    {
                        count++;
                    }
                    else if (checkChar != baseChar || count == MAX_COUNT || i == input.Length - 1)
                    {
                        output.WriteByte((byte)count);
                        output.WriteByte((byte)baseChar);

                        count = 0;
                    }
                }
            }

            input.Close();
            output.Close();

            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            return false;
        }

    }
}

