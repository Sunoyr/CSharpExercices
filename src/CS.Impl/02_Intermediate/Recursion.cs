using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        private List<int> naturalNumber = new List<int>();
        private int sumResult;

        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            naturalNumber.Add(n);
            if (n <= 1) return naturalNumber;
            return GetNaturalNumbers(n - 1);
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {
            sumResult += n;
            if (n <= 1) return sumResult;
            return SumNaturalNumbers(n - 1);
        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            if (n < 2) return false;
            return IsPrime(n, 2);
        }

        private bool IsPrime(int n, int current)
        {
            if (n % current == 0) return false;
            if (current * current > n) return true;
            return IsPrime(n, n+1);
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length == 1) return true;
            if (text[0] == text[text.Length - 1]) return IsPalindrome(text.Substring(1, text.Length - 2));

            return false;
        }
    }
}
