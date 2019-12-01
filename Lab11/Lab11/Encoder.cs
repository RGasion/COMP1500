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
            char checkChar = '\0';

            char baseChar = (char)input.ReadByte();
            for (int i = 0; i < input.Length; i++)
            {
                checkChar = (char)input.ReadByte();

                if (checkChar == baseChar && count != MAX_COUNT && i != input.Length - 1)
                {
                    count++;
                }
                else
                {
                    output.WriteByte((byte)count);
                    output.WriteByte((byte)baseChar);

                    baseChar = checkChar;
                    count = 1;
                }
            }

            input.Position = 0;
            output.Position = 0;
            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {


            return false;
        }

    }
}

