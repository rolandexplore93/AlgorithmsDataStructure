using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.Questions
{
    public class ProblemSolving
    {
        // Check if the input length is within the valid range of 5-7
        // Check if the input are all in upper case
        // Check if it contains only unique characters
        // Check if the sum of ASCII code of the character in the string is between 420 and 600.
        // Return 1 for valid and -1 for invalid input that does not meet the requirement
        // Edge case: space before or after the string input. Trim() it

        public int CheckValidStringInput(string S)
        {
            try
            {
                

                if (string.IsNullOrEmpty(S)) return -2; // empty string

                // check the length of input
                if (S.Length < 5 || S.Length > 7) return -3; // invalid range

                // Convert string to character array
                char[] characterArray = S.ToCharArray();


               


                // Calculate the sum of ASCII values and check for unique uppercase characters
                int sum = 0;
                //HashSet<char> uniqueCharacters = new HashSet<char>(); // To track duplicates


                // Approach 1: Using Array sort 
                Array.Sort(characterArray);

                for (int i = 0; i < characterArray.Length - 1; i++)
                {
                    if (!char.IsUpper(characterArray[i])) return -4;

                    if (characterArray[i] == characterArray[i + 1]) return -1;

                    sum += (int)characterArray[i];
                }


                // APPROACH 2: USING HASHSET TO REMOVE DUPLICATES
                //foreach (char c in characterArray)
                //{
                //    // Check if the character is uppercase
                //    if (!char.IsUpper(c)) return -4; // All characters must be uppercase

                //    // Check for duplicates using a HashSet
                //    if (!uniqueCharacters.Add(c)) return -5; // Duplicate character found

                //    // Add ASCII value to the sum
                //    sum += (int)c;
                //}

                // Check if sum is between 420 and 600
                if (sum < 420 || sum > 600) return -6; // Out of ASCII range

                return 1; // valid string
            }
            catch
            {
                return -1; // invalid input
            }

        }

    }
}
