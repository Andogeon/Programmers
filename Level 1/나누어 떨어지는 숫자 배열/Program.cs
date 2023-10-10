using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Value = solution(5, new int[] { 5, 9, 7, 10 });

            Console.Write("[");

            for (int i = 0; i < Value.Length; ++i)
            {
                string strValue = (i != Value.Length - 1) ? string.Format($"{Value[i]},") : string.Format($"{Value[i]}]");

                Console.Write(strValue);
            }
        }


        // 문제 7
        // 나누어 떨어지는 숫자 배열
        public static int[] solution(int divisor, int[] arr)
        {
            int[] Result = null;

            int Index = 0;

            int Resize = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if(arr[i] % divisor == 0 && Index <= 0)
                {
                    Resize = Index + 1;

                    Result = new int[Resize];

                    Result[Index++] = arr[i];
                }
                else if(arr[i] % divisor == 0 && Index > 0)
                {
                    Resize = Index + 1;

                    Array.Resize(ref Result, Resize);

                    Result[Index++] = arr[i];
                }
            }

            if (Result == null)
                return new int[1] { -1 };

            Array.Sort(Result);

            return Result;
        }
    }
}