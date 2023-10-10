using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Value = solution(2, 5);

            Console.Write("[");

            for (int i = 0; i < Value.Length; ++i)
            {
                string strValue = (i != Value.Length - 1) ? string.Format($"{Value[i]},") : string.Format($"{Value[i]}]");

                Console.Write(strValue);
            }
        }


        // 문제 3
        // X만큼 간격이 있는 n개의 숫자
        public static int[] solution(int x, int n)
        {
            int[] answer = new int[n];

            for (int i = 1; i <= n; ++i)
                answer[i - 1] = x * i;

            return answer;
        }
    }
}