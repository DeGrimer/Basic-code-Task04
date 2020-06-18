using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    public class Program
    {
        public static int MaxFinder(int[] arr, int currentElement, int largest)
        {
            int lastElement = arr.Length;
            if (currentElement == lastElement)
                return largest;
            if (arr[currentElement] > largest)
                largest = arr[currentElement];
            currentElement++;
            return MaxFinder(arr, currentElement, largest);
        }
        public static double IndexFinder(double[] arr)
        {
            if (arr.Length < 3)
                return -1;
            double index = -1;
            double sumLeft = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                sumLeft += arr[i - 1];
                double sumRight = arr.Sum() - sumLeft - arr[i];
                if (Math.Round(sumLeft, 2) == Math.Round(sumRight, 2))
                    index = i;
            }
            return index;
        }
        public static string StringConcatenation(string firstStr, string secondStr)
        {
            char[] arr = firstStr.ToCharArray();
            string final = firstStr;
            for (int i = 0; i < secondStr.Length; i++)
            {
                if (!(arr.Contains(secondStr[i])))
                    final += secondStr[i];
            }
            return final;
        }
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int[] digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int index = -1;
            for (int i = digitArray.Length - 1; i > 0; i--)
            {
                if (digitArray[i] > digitArray[i - 1])
                {
                    index = i - 1;
                    break;
                }
            }
            if (index != -1)
            {
                int temp = digitArray[index];
                digitArray[index] = digitArray[index + 1];
                digitArray[index + 1] = temp;
                Array.Sort(digitArray, index + 1, digitArray.Length - index - 1);
                int res = 0;
                int k = 0;
                for (int i = digitArray.Length - 1; i >= 0; i--)
                {
                    res += digitArray[i] * (int)Math.Pow(10, k);
                    k++;
                }
                return res;
            }
            return index;
        }
        public static int[] FilterDigit(int[] array, int number)
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(number.ToString()))
                    arr.Add(array[i]);
            }
            return arr.ToArray();
        }
        static void Main(string[] args)
        {
        }
    }
}