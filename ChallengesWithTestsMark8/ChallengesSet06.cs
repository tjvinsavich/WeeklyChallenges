using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Count() == 0)
            {
                return false;
            }
            
            foreach (var w in words)
            {
                if (w.ToLower() == word)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num % 2 == 0 || num % 3 == 0 || num < 0 || num == 1)
            {
                return false;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || str.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if(str.Count(x => x == str[i]) == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 1;
            var maxCount = 0;
            //key word CONSECUTIVE, this one is a wash
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    count++;
                }
                else
                {
                    if(count > maxCount)
                    {
                        maxCount = count;
                    }

                    count = 1;
                }
            }

            return maxCount;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var returnList = new List<double>();
            if (elements == null || elements.Count == 0 || n < 0)
            {
                return returnList.ToArray();
            }
            for (int i = n - 1; i < elements.Count; i += n)
            {
                returnList.Add(elements[i]);
            }

            return returnList.ToArray();
        }
    }
}
