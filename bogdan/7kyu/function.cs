using System;

namespace Solution
{
    public class SolutionClass
    {
        public static string Compare(int a, int b)
        {
            string Result="0%",testA= Convert.ToString(a), testB= Convert.ToString(b);
            
            if (testA[1] == testB[1]  testA[0] == testB[0]  testA[0] == testB[1]  testA[1] == testB[0])
            {
                Result = "50%";
            }
            if ((testA[1] == testB[1] && testA[0] == testB[0])  (testA[0] == testB[1] && testA[1] == testB[0]))
            {
                Result = "100%";
            }
            return Result;
        }
    }
}