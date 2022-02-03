//Collection of miscellaneous methods used around the program 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace _5_A_Side
{
    public class Utilities
    {
        public static bool Duplicate(string input, string targetTable, string targetColumn) //Checks if data to be placed in a field already exists in that field in the same table 
        {
            int Count = Convert.ToInt32(Sql.Count(targetTable)); //Uses SQL Aggregate COUNT function to find number of records in given table
            for (int i = 0; i < Count; i++) //iterate through each record
            {
                if (input == Sql.Select("Select " + targetColumn + " from " + targetTable, i, targetColumn)) //If duplicate found
                {
                    return true;
                }
            }
            return false;
        }

        public static bool InputChecking(string input, int minLen, int maxLen, int minNums) //Evaluates the input passed in to see if it meets conditions on length and amount of numbers
        {
            if (input.Length < minLen || input.Length > maxLen) //If input is less than minimum or greater than maximum amount of characters allowed
            {
                return false; //Reject the input
            }
            else 
            {
                int numCount = 0; 
                char[] numChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //All number characters 
                for (int i = 0; i < input.Length; i++) //iterate through every character in the string
                {
                    for (int j = 0; j < numChars.Count(); j++) //iterate through each "number character" in the array
                    {
                        if (input[i] == numChars[j]) //if character i is a numbe
                        {
                            numCount++; //increment the count
                        }
                    }
                }
                if (numCount >= minNums) //if amount of numbers is greater than or equal to the minimum amount allowed
                {
                    return true; //allow input
                }
                else
                {
                    return false;
                }
            }
        }
        public static string hashPassword(string password) //encrypts the input by using the XOR with the input string and a key generated from the input string
        {
            int[] passwordChars = new int[password.Length];
            int[] encryptionKey = new int[password.Length];
            string encrypted = "";  
            for (int i = 0; i < password.Length; i++) //iterates through each character of the password string
            {
                encryptionKey[i] = Convert.ToInt32(password[i]) + (i - 8); //takes character code of position i in array and adds (i - 8) to it and assigns this value of position i of the encryption key array
                passwordChars[i] = Convert.ToInt32(password[i]); //adds character in index i of password to the array at position i
                encrypted += Convert.ToChar(encryptionKey[i] ^ passwordChars[i]); //Performs XOR operation on integers at position i in encryptionKey and passwordChars array. The result is then converted to a character and appended to the encrypted string
            }
            return encrypted;

        }

        public static int[] mergeSort(int[] array) 
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //Basecase needed as algorithm is recursive
            if (array.Length <= 1)
            {
                return array;
            }
            int midPoint = array.Length / 2; //midpoint of array
            left = new int[midPoint];
            if (array.Length % 2 == 0)
            {
                //if array has even number of elements
                right = new int[midPoint];
                //right array has same number of elements as left array 
            }
            else
            {
                //array has odd number of elements
                right = new int[midPoint + 1]; //right array has one more element than left array
            }
            for (int i = 0; i < midPoint; i++)
            {
                left[i] = array[i]; //array elements with indexes less than the midpoint are added to the left array
            }
            int index = 0; 
            for (int i = midPoint; i < array.Length; i++) 
            {
                right[index] = array[i]; //populate right array with every element with an index greater than or equal to the midpoint
                index++;
            }
            left = mergeSort(left); //Uses recursion to sort the left array
            right = mergeSort(right); //Uses recursion to sort the right array
            result = Merge(left, right); //Merge the two sorted chins
            return result; 
        }
        //Combines the sorted arrays into one array
        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length; 
            int[] result = new int[resultLength];
            int indexLeft = 0;
            int indexRight = 0; 
            int indexResult = 0;
            //While the left or right array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {   
                //if the left and right array both still have an element
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //if item on left array is less than the item of the right
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft]; //add the item on the left to the result
                        //increment left and result indexes so looking at next item in array
                        indexLeft++;
                        indexResult++;
                    }
                    else //item on right is less than item on left 
                    {
                        result[indexResult] = right[indexRight]; //add the item on the right to the result
                        indexRight++; //increment the right and result indexes so looking at next item in array
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length) // if only left array has elements left
                {
                    result[indexResult] = left[indexLeft]; //add element in left array to result 
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length) //if only right array has elements
                {
                    result[indexResult] = right[indexRight]; //add element in right array to result
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }

    
}
