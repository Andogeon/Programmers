using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int Value = solution(123);

            Console.Write(Value);
        }


        // 문제 4
        // 자릿수 더하기
        public static int solution(int N)
        {
            string strNumber = N.ToString();

            int Result = 0;

            int digit = Pow(10, strNumber.Length);

            if (digit == 1)
                return N;

            int iValue = N;

            while(digit > 0)
            {
                int Value = iValue / digit;

                Result += Value;

                iValue -= (Value * digit);

                digit /= 10;
            }

            return Result;
        }

        private static int Pow(int x, int y)
        {
            int Result = 1;

            for (int i = 1; i < y; ++i)
                Result *= x;

            return Result;
        }
    }
}