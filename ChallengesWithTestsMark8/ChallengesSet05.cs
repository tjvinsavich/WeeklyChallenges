using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;

            while (startNumber % n != 0)
            {
                startNumber++;
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            if (numbers.Length == 1)
            {
                return true;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i-1] > numbers[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return sum;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var returnString = "";
            if (words == null || words.Length == 0)
            {
                return returnString;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim() != "")
                {
                    returnString += words[i].Trim() + " ";
                }
            }

            //specific case
            if (returnString == "")
            {
                return returnString;
            }

            return returnString.TrimEnd() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            
            var returnList = new List<double>();

            if (elements == null || elements.Count == 0)
            {
                return returnList.ToArray();
            }

            for (int i = 3; i < elements.Count; i+=4)
            {
                returnList.Add(elements[i]);
            }

            return returnList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
