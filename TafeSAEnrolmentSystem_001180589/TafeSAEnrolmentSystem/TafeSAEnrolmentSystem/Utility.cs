using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TafeSAEnrolmentSystem
{
    public class Utility
    {
        /// <summary>
        /// 
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
        /// 
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

        public static void bubbleSortDecending<T>(T[] myArray) where T : IComparable<T>
        {
            int arraySize = myArray.Length;
            int index_I;
            int index_J;
            T temp;
            bool swapped;
            for (index_I = 0; index_I < arraySize - 1; index_I++)
            {
                swapped = false;
                for (index_J = 0; index_J < arraySize - index_I - 1; index_J++)
                {
                    if (myArray[index_J].CompareTo(myArray[index_J + 1]) == -1)
                    {

                        // Swap arr[j] and arr[j+1]
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

        public static void bubbleSortAcending<T>(T[] myArray) where T : IComparable<T>
        {
            int arraySize = myArray.Length;
            int index_I;
            int index_J;
            T temp;
            bool swapped;
            for (index_I = 0; index_I < arraySize - 1; index_I++)
            {
                swapped = false;
                for (index_J = 0; index_J < arraySize - index_I - 1; index_J++)
                {
                    if (myArray[index_J].CompareTo(myArray[index_J + 1]) == 1)
                    {

                        // Swap arr[j] and arr[j+1]
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







    }
}


