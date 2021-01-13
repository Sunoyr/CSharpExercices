using System;
using System.Collections.Generic;
using CS.Impl._02_Intermediate;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {
            List<int> permutationPrimeNumbers = new List<int>();
            Recursion r = new Recursion();

            for(int i=0; i<=upperBound;i++)
            {
                bool isPrime = r.IsPrime(i);
                if (isPrime)
                {
                    bool allPermutePrime = true;
                    foreach (var perm in GetPermutation(i.ToString()))
                    {
                        if(!r.IsPrime(Int32.Parse(perm)))
                        {
                            allPermutePrime = false;
                            break;
                        }
                        if (allPermutePrime) permutationPrimeNumbers.Add(Int32.Parse(perm));
                    }
                }
            }
            return permutationPrimeNumbers.ToArray();
        }

        private IEnumerable<string> GetPermutation(string set)
        {
            var output = new List<string>();
            if(set.Length == 1)
            {
                output.Add(set);
            } else
            {
                foreach(var c in set)
                {
                    var tail = set.Remove(set.IndexOf(c), 1);
                    foreach(var tailPerms in GetPermutation(tail))
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }
            return output;
        }
    }
}
