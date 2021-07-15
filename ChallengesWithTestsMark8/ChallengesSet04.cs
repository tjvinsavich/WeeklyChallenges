using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
                else
                {
                    sum -= n;
                }
            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] arr = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            Array.Sort(arr);
            return arr[0];
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] arr = new int[] { number1, number2, number3, number4};
            Array.Sort(arr);
            return arr[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            return int.TryParse(input, out var result1) || double.TryParse(input, out var result2);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = objs.Count(x => x == null);

            if(count > objs.Length / 2)
            {
                return true;
            }

            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            if (numbers.All(x => x % 2 != 0 ))
            {
                return 0;
            }

            return numbers.Where(x => x % 2 == 0).Average();

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var product = 1;

            while (number > 0)
            {
                product *= number;
                number--;
            }

            return product;

        }
    }
}
