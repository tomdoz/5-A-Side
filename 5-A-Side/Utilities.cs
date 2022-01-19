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
        public static bool Duplicate(string input, string targetTable, string targetColumn)
        {
            for (int i = 0; i < Sql.CountRows("UserTable"); i++)
            {
                if (input == Sql.Select("Select " + targetColumn + " from " + targetTable, i, targetColumn))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool InputChecking(string input, int minLen, int minNums)
        {
            if (input.Length < minLen)
            {
                return false;
            }
            else
            {
                int numCount = 0;
                char[] numChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < numChars.Count(); j++)
                    {
                        if (input[i] == numChars[j])
                        {
                            numCount++;
                        }
                    }
                }
                if (numCount >= minNums)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string hashPassword(string password)
        {
            int[] passwordChars = new int[password.Length];
            int[] encryptionKey = new int[password.Length];
            string encrypted = "";
            for (int i = 0; i < password.Length; i++)
            {
                encryptionKey[i] = Convert.ToInt32(password[i]) + (i - 8);
                passwordChars[i] = Convert.ToInt32(password[i]);
                encrypted += Convert.ToChar(encryptionKey[i] ^ passwordChars[i]);
            }
            Debug.WriteLine(encrypted);
            return encrypted;

        }

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
            {
                return array;
            }
            int midPoint = array.Length / 2;
            left = new int[midPoint];
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
  
            int index = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[index] = array[i];
                index++;
            }
            left = mergeSort(left);
            right = mergeSort(right);
            result = Merge(left, right);
            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }

    
}
