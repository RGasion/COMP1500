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

            int count = 1;
            char checkChar = '\0';

            char baseChar = (char)input.ReadByte();
            for (int i = 1; i < input.Length; i++)
            {
                checkChar = (char)input.ReadByte();

                if (checkChar == baseChar && count != MAX_COUNT && i != input.Length - 1)
                {
                    count++;
                }
                else
                {
                    if (i == input.Length - 1)
                    {
                        if (checkChar == baseChar && count != MAX_COUNT)
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
                    
                    output.WriteByte((byte)count);
                    output.WriteByte((byte)baseChar);

                    baseChar = checkChar;
                    count = 1;
                }
            }

            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);
            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                int times = (int)input.ReadByte();
                char character = (char)input.ReadByte();

                for (int k = 0; k < times; k++)
                {
                    output.WriteByte((byte)character);
                }
            }

            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);
            return true;
        }

    }
}

