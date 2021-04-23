using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Any(item => item == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            var oddNumbers= numbers.Where(x=>Math.Abs(x)%2!=0);
            return oddNumbers.Sum()%2!=0;

            

        }
        //return false;

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit) ;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
            {
                return 0;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {

            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();
            for (int i =0; i<=100; i++)
            {
                //var sum = 0;
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }

            }
            int[] numbers1= new int[numbers.Count];
            for (var j=0; j< numbers.Count; j++)
            {
                numbers1[j] = numbers[j];
            }
            return numbers1;


        }   


        public void ChangeAllElementsToUppercase(string[] words)
        {
            for( var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
