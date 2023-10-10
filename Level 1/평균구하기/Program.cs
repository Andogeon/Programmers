using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            float Value = solution(arr);

            Console.Write(Value);
        }


        // 문제 1 
        // 평균 구하기 
        public static float solution(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
                sum += arr[i];

            return (float)sum / (float)arr.Length;
        }
    }
}