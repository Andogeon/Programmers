using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Value = solution("a1234");

            Console.Write(Value);
        }


        // 문제 9
        // 문자열 다루기 기본
        public static bool solution(string s)
        {           
            char[] Arrchar = s.ToCharArray();

            if (s.Length == 4 || s.Length == 6)
            {
                foreach (char i in Arrchar)
                {
                    if (i >= 65)
                        return false;
                }

                return true;
            }
            else
                return false;
            
        }
    }
}