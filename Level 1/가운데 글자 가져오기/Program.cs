using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value = solution("abcde");

            Value = "\"" + Value + "\"";

            Console.Write(Value);
        }


        // 문제 6
        // 가운데 글자 가져오기  
        public static string solution(string s)
        {
            string NewValue = null;

            int Index = s.Length / 2;

            if (s.Length % 2 == 0)
            {
                char LeftChar = s[Index - 1];
                char RightChar = s[Index];

                NewValue = LeftChar.ToString() + RightChar.ToString();
            }
            else
            {
                char LeftChar = s[Index];

                NewValue = LeftChar.ToString();
            }

            return NewValue;
        }
    }
}