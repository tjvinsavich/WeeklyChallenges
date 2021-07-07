using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var v in vals)
            {
                if(v == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                if(num % 2 != 0)
                {
                    sum += num;
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upperCheck = false;
            bool lowerCheck = false;
            bool numCheck = false;

            foreach (var p in password)
            {
                if(Char.IsUpper(p))
                {
                    upperCheck = true;
                }
                else if(Char.IsLower(p))
                {
                    lowerCheck = true;
                }
                else if(Char.IsDigit(p))
                {
                    numCheck = true;
                }
            }

            if (upperCheck && lowerCheck && numCheck)
            {
                return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddArr = new List<int>();

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddArr.Add(i);
                }
            }

            return oddArr.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
