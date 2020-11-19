using System;
using System.Collections.Generic;

namespace CS.Impl._01_Basic
{
    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int SumTable(IEnumerable<int> integersTable)
        {
            int result = 0;

            foreach(var nb in integersTable)
            {
                result += nb;
            }

            return result;
        }
    }
}

