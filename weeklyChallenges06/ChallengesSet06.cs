using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges06
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
                return false;
            foreach (var listed in words)
            {
                if (listed == null)
                    continue;

                if (listed == word)
                    return true;

                if (ignoreCase == true && listed.ToLower() == word.ToLower())
                    return true;
                

            }
            return false;


        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2)
            return true;

            if (num <= 1)
                return false;

            if (num % 2 == 0)
                return false;

            for (int i = 3; i < num / 2; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
          {
                if (str.Length == 0)
                    return -1;
           bool UniqueIndex;
           int Count = -1;
            for (int i = 0; i < str.Length; i++)
            {
              UniqueIndex = false;
              for (int a = 0; a < str.Length; a++)
              {
                if (str[i] == str[a] && i != a)
                UniqueIndex = true;
              }
              if (UniqueIndex == false)
              Count = i;
            }
             return Count;
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            int finalcount = 0;
            int currentint = numbers[0];
           
            foreach (int x in numbers)
            {
                if (x == currentint)
                    count += 1;
                if (finalcount < count)
                    finalcount = count;
                if (x != currentint)
                {
                    currentint = x;
                    count = 1;
                }
                
            }
            return finalcount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> returnedList = new List<double>();
            if (elements == null)
                return returnedList.ToArray();
            int count = 0;
            foreach (var x in elements)
            {
                count += 1;
                if (count == n)
                {
                    returnedList.Add(x);
                    count = 0;
                }
            }
            return returnedList.ToArray();
        }
    }
}
