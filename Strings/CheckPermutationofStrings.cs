using System;
namespace CodingChallenges.Strings
{
    public class CheckPermutationofStrings
    {
        public void CheckPermutation(string firstStr, string secondStr)
        {
            int NO_OF_CHARS = 256;

            bool result = true;

            char[] firstStrChars = firstStr.ToCharArray();
            char[] secondStrChars = secondStr.ToCharArray();

            // Get lenghts of both strings  
            int firstLength = firstStr.Length;
            int secondLength = secondStr.Length;

            int[] firstStringCount = new int[NO_OF_CHARS];
            int[] secondStringCount = new int[NO_OF_CHARS];

            for (int i = 0; i < firstStr.Length && i < secondStr.Length; i++)
            {
                firstStringCount[firstStrChars[i]]++;
                secondStringCount[secondStrChars[i]]++;
            }

            if (firstLength != secondLength)
                result = false;

            // Compare count arrays 
            for (int j = 0; j < NO_OF_CHARS; j++)
                if (firstStringCount[j] != secondStringCount[j])
                    result = false;

            if(result)
                Console.WriteLine("\nBoth strings are permutations of each other.");
            else
                Console.WriteLine("\nBoth strings are not permutations of each other.");
            
        }
    }
}
