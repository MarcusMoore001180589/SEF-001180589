using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace TafeSAEnrolmentSystem
{
    public class Utility
    {
        /// <summary>
        /// Sequential search checks each item in the list one by one 
        /// until it finds a match or reaches the end, meaning the target 
        /// was not found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LinearSearch<T>(T[] myArray, T target) where T : IComparable<T>
        {
            int index_I = 0;
            bool found = false;
            while (!found && index_I < myArray.Length)
            {
                if (target.CompareTo(myArray[index_I]) == 0)
                    found = true;
                else
                    index_I++;
            }
            if (index_I < myArray.Length)
                return index_I;
            else
                return -1;
        }

        /// <summary>
        /// Birnay search by setting a mid point of the array
        /// then it checks if the target is in the first half or second half
        /// it does this untill the target is found or has reach the end of the array
        /// meaning the target was not found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(T[] myArray, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = myArray.Length - 1;
            int mid;
            do
            {
                mid = (min + max) / 2;
                if (target.CompareTo(myArray[mid]) == 0)
                    return mid;
                if (target.CompareTo(myArray[mid]) > 0)
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (min <= max);
            return -1;
        }

        /// <summary>
        /// Bubble sort uses two loops. The first loop goes through the whole list.
        /// The second loop compares the current value with the next. If the next
        /// value is smaller, they are swapped. This continues until the list is
        /// fully sorted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>

        public static void bubbleSortDecending<T>(T[] myArray) where T : IComparable<T>
        {
            // get length of the array
            int arraySize = myArray.Length;
            int index_I;
            int index_J;
            // temp variable used for swapping values
            T temp;
            bool swapped;
            // outer loop controls how many passes to make
            for (index_I = 0; index_I < arraySize - 1; index_I++)
            {
                swapped = false;

                // inner loop runs until the second-to-last index
                for (index_J = 0; index_J < arraySize - index_I - 1; index_J++)
                {
                    // check if the current value is smaller than the next (for descending sort)
                    if (myArray[index_J].CompareTo(myArray[index_J + 1]) == -1)
                    {

                        // Swap arr[index_J] and arr[index_J + 1]
                        temp = myArray[index_J + 1];
                        myArray[index_J + 1] = myArray[index_J];
                        myArray[index_J] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        /// <summary>
        /// Bubble sort uses two loops. The first loop goes through the whole list.
        /// The second loop compares the current value with the next one. If the next
        /// value is bigger than the first, they are swapped. This continues until the
        /// list is fully sorted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        public static void bubbleSortAcending<T>(T[] myArray) where T : IComparable<T>
        {
            // get length of the array
            int arraySize = myArray.Length;
            int index_I;
            int index_J;
            // temp variable used for swapping values
            T temp;
            bool swapped;
            // outer loop controls how many passes to make
            for (index_I = 0; index_I < arraySize - 1; index_I++)
            {
                swapped = false;
                // inner loop runs until the second-to-last index
                for (index_J = 0; index_J < arraySize - index_I - 1; index_J++)
                {
                    // check if the current value is bigger than the next(ascending sort)
                    if (myArray[index_J].CompareTo(myArray[index_J + 1]) == 1)
                    {

                        // Swap arr[index_J + 1] and arr[index_J]
                        temp = myArray[index_J];
                        myArray[index_J] = myArray[index_J + 1];
                        myArray[index_J + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        /// <summary>
        /// Merge sort works by breaking the array into smaller sub‑arrays until each element is in its own array.
        /// Then, during the merge step, the left and right sub‑arrays are compared,
        /// and elements are placed in order—moving the smaller value first.
        /// As the merge continues, the algorithm repeatedly compares elements from 
        /// both sub‑arrays and builds a sorted array from lowes to highest until the entire array is fully merged.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>
        public static void mergeSortAcending<T>(T[] myArray , int left, int mid, int right) where T : IComparable<T>
        {
            // Fidnt the length of the two
            // Subarray to be mereged
            int arraySize1 = mid - left + 1;
            int arraySize2 = right - mid;
;
            // Create temp arrays
            T[] leftArray = new T[arraySize1];
            T[] rightArray = new T[arraySize2];
            int index_I;
            int index_J;

            // Copy data to temp arrays
            for (index_I = 0; index_I < arraySize1; index_I++)
                leftArray[index_I] = myArray[left + index_I];

            for (index_J = 0; index_J < arraySize2; ++index_J)
                rightArray[index_J] = myArray[mid + 1 + index_J];


            // Initial indexes of first
            // and second subarrays
            index_I = 0;
            index_J = 0;

            // Initial index of merged
            // subarray array

            int index_K = left;
            while (index_I < arraySize1 && index_J < arraySize2) {
                if (leftArray[index_I].CompareTo(rightArray[index_J]) == -1)
                {
                    myArray[index_K] = leftArray[index_I];
                    index_I++;
                }
                else
                {
                    myArray[index_K] = rightArray[index_J];
                    index_J++;
                }
                index_K++;
            }

            while (index_I < arraySize1)
            {
                myArray[index_K] = leftArray[index_I];
                index_I++;
                index_K++;
            }

            while (index_J < arraySize2)
            {
                myArray[index_K] = rightArray[index_J];
                index_J++;
                index_K++;
            }

        }

        /// <summary>
        /// Breaking the array into smaller arrays for the meregeSortAcending to sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void mergeAcending<T>(T[] myArray, int left, int right) where T : IComparable<T>
        {

            if (left < right)
            {

                // Find the middle point
                int mid = left + (right - left) / 2;

                // Sort first and second halves
                mergeAcending(myArray, left, mid);
                mergeAcending(myArray, mid + 1, right);

                // Merge the sorted halves
                mergeSortAcending(myArray, left, mid, right);
            }
        }


        /// <summary>
        /// Merge sort works by breaking the array into smaller sub‑arrays until each element is in its own array.
        /// Then, during the merge step, the left and right sub‑arrays are compared,
        /// and elements are placed in order—moving the larger value first.
        /// As the merge continues, the algorithm repeatedly compares elements from 
        /// both sub‑arrays and builds a sorted array from largest to smalles until the entire array is fully merged.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="right"></param>

        public static void mergeSortDecending<T>(T[] myArray, int left, int mid, int right) where T : IComparable<T>
        {
            // Fidnt the length of the two
            // Subarray to be mereged
            int arraySize1 = mid - left + 1;
            int arraySize2 = right - mid;
            ;
            // Create temp arrays
            T[] leftArray = new T[arraySize1];
            T[] rightArray = new T[arraySize2];
            int index_I;
            int index_J;

            // Copy data to temp arrays
            for (index_I = 0; index_I < arraySize1; index_I++)
                leftArray[index_I] = myArray[left + index_I];

            for (index_J = 0; index_J < arraySize2; ++index_J)
                rightArray[index_J] = myArray[mid + 1 + index_J];


            // Initial indexes of first
            // and second subarrays
            index_I = 0;
            index_J = 0;

            // Initial index of merged
            // subarray array

            int index_K = left;
            while (index_I < arraySize1 && index_J < arraySize2)
            {
                if (leftArray[index_I].CompareTo(rightArray[index_J]) == 1)
                {
                    myArray[index_K] = leftArray[index_I];
                    index_I++;
                }
                else
                {
                    myArray[index_K] = rightArray[index_J];
                    index_J++;
                }
                index_K++;
            }

            while (index_I < arraySize1)
            {
                myArray[index_K] = leftArray[index_I];
                index_I++;
                index_K++;
            }

            while (index_J < arraySize2)
            {
                myArray[index_K] = rightArray[index_J];
                index_J++;
                index_K++;
            }

        }

        /// <summary>
        /// Breaking the array into smaller arrays for the meregeSortAcending to sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="myArray"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void mergeDecending<T>(T[] myArray, int left, int right) where T : IComparable<T>
        {

            if (left < right)
            {

                // Find the middle point
                int mid = left + (right - left) / 2;

                // Sort first and second halves
                mergeDecending(myArray, left, mid);
                mergeDecending(myArray, mid + 1, right);

                // Merge the sorted halves
                mergeSortDecending(myArray, left, mid, right);
            }
        }





    }
}


