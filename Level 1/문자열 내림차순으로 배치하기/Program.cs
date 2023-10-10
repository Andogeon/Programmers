using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value = "\"" + solution("Zbcdefg") + "\"";

            Console.Write(Value);
        }


        // 문제 8
        // 문자열 내림차순으로 배치하기
        public static string solution(string s)
        {           
            char[] Arrchar = s.ToCharArray();

            return new string(Sort(Arrchar));
        }

        private static char[] Sort(char[] _pArray)
        {
            for(int i = 0; i < _pArray.Length; ++i)
            {
                for (int j = i; j < _pArray.Length; ++j)
                {
                    if (_pArray[i] < _pArray[j])
                    {
                        char Temp = _pArray[i];
                        _pArray[i] = _pArray[j];
                        _pArray[j] = Temp;
                    }
                }
            }

            return _pArray;
        }
    }
}