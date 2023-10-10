using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value = solution(3);

            Value = "\"" + Value + "\"";

            Console.Write(Value);
        }

        // 문제 2 
        // 짝수와 홀수 
        public static string solution(int num)
        {
            return (num % 2 == 0 ? "Even" : "Odd");
        }
    }
}