using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            //PrintArray(arr1);
            //BubbleSort(arr1);
            //PrintArray(arr1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr1);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());
            int[] arr2 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            //PrintArray(arr2);
            //InsertionSort(arr2);
            //PrintArray(arr2);
            stopwatch.Restart();
            stopwatch.Start();
            SelectionSort(arr1);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());

            stopwatch.Restart();
            stopwatch.Start();
            InsertionSort(arr1);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());
        }

        public static void PrintArray(int[] arrToSort)
        {
            foreach (int element in arrToSort)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public static int BubbleSort(int[] arrToSort)
        {
            int totalOuterIterations = 0;
            int temp;
            // Overall O(n^2) runtime - Big O
            // Big Omega - O(n^2)
            for (int i = 0; i < arrToSort.Length - 1; i++) // O(n) how many times we need to go though the unsorted array
            {
                totalOuterIterations++;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)  // O(n)
                {
                    // we need to swap
                    if (arrToSort[j] > arrToSort[j + 1])           // can modify if '>' change to '<'
                    {
                        swaps++;
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }

                if (swaps == 0) break; // break out of the for loop
            }

            return totalOuterIterations;
        }

        public static void SelectionSort(int[] arrToSort)
        {
            // minIndex keeps track of the smallest index in each iteration
            // temp is used as temporary storage
            int minIndex, temp;

            // O(n) how many times we need to go though the unsorted array
            for (int i = 0; i < arrToSort.Length; i++)
            {
                minIndex = i; // set the minIdex equal to current smallest index
                for (int j = i; j < arrToSort.Length; j++) // loop through each element starting at i
                {
                    // if the element is smaller than the current minIndex
                    if (arrToSort[j] < arrToSort[minIndex])
                    {
                        // swap
                        minIndex = j;
                    }
                }

                // swap elements
                // swap current i (which is smallest position with the smallest/min element)
                temp = arrToSort[i];
                arrToSort[i] = arrToSort[minIndex];
                arrToSort[minIndex] = temp;
            }
        }

        public static void InsertionSort(int[] arrToSort)
        {
            int temp, i;
            for (i = 1; i < arrToSort.Length; i++)
            {
                temp = arrToSort[i]; // Store the current element
                int priorIndex = i - 1; // Start comparing with the element before the current one

                // If our prior element is greater than our stored element, and we have not 
                // reached the end of the array
                while (priorIndex >= 0 && arrToSort[priorIndex] > temp)
                {
                    arrToSort[priorIndex + 1] = arrToSort[priorIndex];
                    priorIndex--;
                }

                // Need to do an assignment
                arrToSort[priorIndex + 1 ] = temp;
            }
        }
    }
}