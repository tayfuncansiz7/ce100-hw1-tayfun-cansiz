using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    public class Sorting
    {

        static void Main(string[] args)
        {

        }

        /**
        *
        *	  @name   InsertionSort (Insertion Sort)
        *
        *	  @brief Insertion Sort
        *
        *	  Insertion Sort
        *
        *	  @param  [in] unsortedList [\b double]  unsortedList
        *	  
        *	  
        *	  
        **/

        public static int[] InsertionSort(int[] unsortedList)
        {
            //index of element to be moved back
            int i = 1;
            //index of element we are trying to swap to
            int j = i;
            //temp variable used to swap
            int temp = 0;


            while (i < unsortedList.Length)
            {
                j = i;  //set the index of current item we are looking at
                        //as long as there is a number larger to the left and we havent gone through
                        //each element then swap our current element one position backwards

                while (j > 0 && unsortedList[j - 1] > unsortedList[j])
                {

                    //next 3 lines swaps j and j - 1

                    //set j in tempory variable
                    temp = unsortedList[j];
                    //move j - 1 into j
                    unsortedList[j] = unsortedList[j - 1];
                    //move j into j - 1
                    unsortedList[j - 1] = temp;
                    //decrement to compare to the next element to the left
                    j--;
                }
                //move to the next element to insert backwards into the list
                i++;
            }
            return unsortedList;
        }

        /**
        *
        *	  @name   SelectionSort (Selection Sort)
        *
        *	  @brief Selection Sort
        *
        *	  Selection Sort
        *
        *	  @param  [in] unsortedList [\b double]  unsortedList
        *	  
        *	  
        *	  
        **/

        public static int[] SelectionSort(int[] unsortedList)
        {
            //current index of the current minimum we are looking for
            int MinIndex = 0;

            //temporary variable for swapping the value of the current min index
            int MinimumValueFound = 0;

            //MainIndex is the pointer for each lowest element we need to find
            for (int MainIndex = 0; MainIndex < unsortedList.Length; MainIndex++)
            {
                //MinIndex is now the current spot in the Main list
                MinIndex = MainIndex;

                //remaining goes threw the remainder of the list finding the index of the next lowest value
                for (int RemainingIndex = MainIndex + 1; RemainingIndex < unsortedList.Length; RemainingIndex++)
                {
                    //if the remaining element is less then the MinIndex we move the index to that spot.
                    //Will swap values after going through the entire list

                    //We are finding the next smallest element
                    if (unsortedList[RemainingIndex] < unsortedList[MinIndex])
                    {
                        //Update Minimum amount index
                        MinIndex = RemainingIndex;
                    }
                }

                //We now have the index of the lowest number in the remaining list. Swap it with the current i element in the list
                MinimumValueFound = unsortedList[MinIndex];
                unsortedList[MinIndex] = unsortedList[MainIndex];
                unsortedList[MainIndex] = MinimumValueFound;
            }
            return unsortedList;
        }

        /**
        *
        *	  @name   mergeSort (Merge Sort)
        *
        *	  @brief Merge Sort
        *
        *	  Merge Sort
        *
        *	  @param  [in] array [\b int]  array
        *	  
        *	  
        *	  
        **/

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow

            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = mergeSort(left);
            //Recursively sort the right array
            right = mergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        /**
        *
        *	  @name   merge (Merge)
        *
        *	  @brief Merge
        *
        *	  Merge
        *
        *	  @param  [in] left [\b int]  left
        *	  
        *	  @param  [in] right [\b int]  right
        *	  
        *	  
        **/

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

        /**
        *
        *	  @name   NaivePower (Naive Power)
        *
        *	  @brief Naive Power
        *
        *	  Naive Power
        *
        *	  @param  [in] number [\b int]  number
        *	  
        *	  @param  [in] power [\b int]  power
        *	  
        *	  
        **/


        public static long Naivepower(int number, int power)
        {
            // initialize result by 1
            int pow = 1;

            // multiply `x` exactly `n` times
            for (int i = 0; i < power; i++)
            {
                pow = pow * number;
            }
            //return pow
            return pow;
        }

        /**
        *
        *	  @name   RecursivePower (Recursive Power)
        *
        *	  @brief Recursive Power
        *
        *	  Recursive Power
        *
        *	  @param  [in] n [\b int]  n
        *	  
        *	  @param  [in] p [\b int]  p
        *	  
        *	  
        **/


        public static long RecursivePower(int n, int p)
        {
            //if it is true this loop will run
            if (p != 0)
            {
                //return result
                return (n * RecursivePower(n, p - 1));
            }
            //return 1
            return 1;
        }

        /**
        *
        *	  @name   BinarySearchIterative (Binary Search Iterative)
        *
        *	  @brief Binary Search Iterative
        *
        *	  Binary Search Iterative
        *
        *	  @param  [in] inputArray [\b int]  inputArray
        *	  
        *	  @param  [in] key [\b int]  key
        *	  
        *	  
        **/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int l = 0, r = inputArray.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid
                if (inputArray[m] == key)
                    return m;

                // If x greater, ignore left half
                if (inputArray[m] < key)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            // if we reach here, then element was
            // not present

            // Returns index of x if it is present in
            // arr[l..r], else return -1
            return -1;
        }


        /**
        *
        *	  @name   BinarySearchRecursive (Binary Search Recursive)
        *
        *	  @brief Binary Search Recursive
        *
        *	  Binary Search Recursive
        *
        *	  @param  [in] inputArray [\b int]  inputArray
        *	  
        *	  @param  [in] key [\b int]  key
        *	  
        *	  @param  [in] min [\b int]  min
        *	  
        *	  @param  [in] max [\b int]  max
        *	  
        *	  
        **/

        public static int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            int mid = key + (min - key) / 2;

            // find the mid-value in the search space and
            // compares it with the target

            // Base condition (target value is found)
            if (max == inputArray[mid])
            {
                return mid;
            }

            // discard all elements in the right search space,
            // including the middle element
            else if (max < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, key, mid - 1, max);
            }

            // discard all elements in the left search space,
            // including the middle element
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, min, max);
            }
        }
    }
}
