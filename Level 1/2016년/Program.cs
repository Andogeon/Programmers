using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Value = solution(5, 24);

            Value = "\"" + Value + "\"";

            Console.Write(Value);
        }


        // 문제 5
        // 2016년 
        public static string solution(int a, int b)
        {
            int[] MonthDays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[] strDayName = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            
            int Index = 4;

            if (a == 1 && b == 1) 
                return "FRI";

            for (int i = 1; i <= a; ++i)
            {
                int Days = (i == a) ? b : MonthDays[i - 1];

                for (int j = 1; j <= Days; ++j)
                {
                    ++Index;

                    if (Index == 7)
                        Index = 0;
                }
            }

            return strDayName[Index];
        }
    }
}