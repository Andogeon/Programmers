using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strValue = new string[] { "Jane", "Kim" };

            string Value = "\"" + solution(strValue) + "\"";

            Console.Write(Value);
        }


        // 문제 10
        // 서울에서 김서방 찾기
        public static string solution(string[] seoul)
        {
            int Index = 0;

            for(int i = 0; i < seoul.Length; ++i)
            {
                if (seoul[i] == "Kim")
                {
                    Index = i;
                    break;
                }
            }

            return string.Format($"김서방은 {Index}에 있다");
        }
    }
}