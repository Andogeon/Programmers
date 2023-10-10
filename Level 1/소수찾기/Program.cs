using System;
using System.Collections.Generic;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = solution(10);

            Console.Write(result);
        }

        // 문제 11
        // 소수 찾기
        public static int solution(int n)
        {
            int[] _ArrayValue = new int[n];

            for (int i = 1; i <= n; ++i)
                _ArrayValue[i - 1] = i;

            int Number = 2;

            int Count = 0;

            for (int i = 0; i < _ArrayValue.Length; ++i)
            {
                for (int j = Number + i; j <= _ArrayValue.Length; j += (Number + i))
                {
                    if (j == Number + i)
                        continue;

                    _ArrayValue[j - 1] = 0;
                }
            }

            for(int i = 0; i < _ArrayValue.Length; ++i)
            {
                if (_ArrayValue[i] <= 1)
                    continue;

                Count += 1;
            }

            return Count;
        }
    }
}