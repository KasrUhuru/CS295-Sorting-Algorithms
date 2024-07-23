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

            /// Console.WriteLine(stopwatch.Elapsed.ToString());
            int[] arr2 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };

            
            Student student1 = new Student("Jill Stein", 4.0);

            Student student2 = new Student("Matias", 3.0);

            Student student3 = new Student("Matt", 3.9);

            Student student4 = new Student("Biden", 0.1);

            Student student5 = new Student("Carlos", 2.4);


            Student[] students = { student1, student2, student3, student4, student5 };

            /// For the Student Class
            Console.WriteLine($"The current Student[] Array is UNSORTED with the following objects...");
            PrintArray(students);
            Console.WriteLine("Please select a sorting algorithm:");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");
            Console.WriteLine("4: Merge Sort");

            string? userSelection = Console.ReadLine();

            //Student student1 = new Student();
            //student1.name = "Melissa";
            //student1.gpa = 3.0;

            // Doesn't work! Constructor doesn't permit non-named Student objects
            // Student student3 = new Student(4.0);

            // Utilize a SWITCH statement to handle different possibilities
            switch (userSelection)
            {
                case "1":
                    // Commit Bubble activities
                    Console.WriteLine("Initiating Bubble Sort...");
                    stopwatch.Start();
                    BubbleSort(students);
                    stopwatch.Stop();
                    Console.Write("Time taken to execute this algorithm:");
                    Console.WriteLine(stopwatch.Elapsed.ToString());
                    break;
                case "2":
                    // Commit Selection activities
                    Console.WriteLine("Initiating Selection Sort...");
                    stopwatch.Start();
                    SelectionSort(students);
                    stopwatch.Stop();
                    Console.Write("Time taken to execute this algorithm:");
                    Console.WriteLine(stopwatch.Elapsed.ToString());
                    break;
                case "3":
                    // Commit Insertion activities
                    Console.WriteLine("Initiating Insertion Sort...");
                    stopwatch.Start();
                    InsertionSort(students);
                    stopwatch.Stop();
                    Console.Write("Time taken to execute this algorithm:");
                    Console.WriteLine(stopwatch.Elapsed.ToString());
                    break;
                case "4":
                    // Commit Merge activities
                    Console.WriteLine("Initiating Merge Sort...");
                    stopwatch.Start();
                    MergeSort(students);
                    stopwatch.Stop();
                    Console.Write("Time taken to execute this algorithm:");
                    Console.WriteLine(stopwatch.Elapsed.ToString());
                    break;
                default:
                    // none of the cases matched
                    break;
            }

            PrintArray(students);

            MergeSort(arr2);
            // PrintArray(arr2);

        }

        public static void PrintArray(int[] arrToSort)
        {
            foreach (int element in arrToSort)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(Student[] arrToSort)
        {
            foreach (var item in arrToSort)
            {
                Console.WriteLine($"{item.name}: {item.gpa} ");
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

        public static void BubbleSort(Student[] arrToSort)
        {
            int totalOuterIterations = 0;
            // Change from INT to STUDENT class for the temp variable
            Student temp;
            // Overall O(n^2) runtime - Big O
            // Big Omega - O(n^2)
            for (int i = 0; i < arrToSort.Length - 1; i++) // O(n) how many times we need to go though the unsorted array
            {
                totalOuterIterations++;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)  // O(n)
                {
                    // we need to swap SWITCHED FROM ASCENDING TO DESCENDING
                    if (arrToSort[j].gpa < arrToSort[j + 1].gpa)           // can modify if '>' change to '<'
                    {
                        swaps++;
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }

                if (swaps == 0) break; // break out of the for loop
            }


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

        public static void SelectionSort(Student[] arrToSort)
        {
            // minIndex keeps track of the smallest index in each iteration
            // temp is used as temporary storage
            int minIndex;
            Student temp;

            // O(n) how many times we need to go though the unsorted array
            for (int i = 0; i < arrToSort.Length; i++)
            {
                minIndex = i; // set the minIdex equal to current smallest index
                for (int j = i; j < arrToSort.Length; j++) // loop through each element starting at i
                {
                    // if the element is smaller than the current minIndex
                    if (arrToSort[j].gpa > arrToSort[minIndex].gpa)
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

        public static void InsertionSort(Student[] arrToSort)
        {
            Student temp;
            int i;
            for (i = 1; i < arrToSort.Length; i++)
            {
                temp = arrToSort[i]; // Store the current element
                int priorIndex = i - 1; // Start comparing with the element before the current one

                // If our prior element is greater than our stored element, and we have not 
                // reached the end of the array
                while (priorIndex >= 0 && arrToSort[priorIndex].gpa < temp.gpa)
                {
                    arrToSort[priorIndex + 1] = arrToSort[priorIndex];
                    priorIndex--;
                }

                // Need to do an assignment
                arrToSort[priorIndex + 1] = temp;
            }
        }


        // Recursive function that splits the array up and merges it together
        public static void MergeSort(int[] arrToSort)
        {
            if (arrToSort.Length <= 1) return; // Early return for arrays of length 1 or less

            int mid = arrToSort.Length / 2;

            // Create left and right sub-arrays
            int[] leftSubArray = new int[mid];
            int[] rightSubArray = new int[arrToSort.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                leftSubArray[i] = arrToSort[i];
            }

            for (int i = mid; i < arrToSort.Length; i++)
            {
                rightSubArray[i - mid] = arrToSort[i];
            }

            // Recursively sort the sub-arrays
            MergeSort(leftSubArray);
            MergeSort(rightSubArray);

            // Merge the sorted sub-arrays
            Merge(arrToSort, leftSubArray, rightSubArray);
        }

        private static void Merge(int[] arrToSort, int[] leftSubArray, int[] rightSubArray)
        {
            int leftIndex = 0, rightIndex = 0, sortedIndex = 0;

            // Merge elements from leftSubArray and rightSubArray in sorted order
            while (leftIndex < leftSubArray.Length && rightIndex < rightSubArray.Length)
            {
                if (leftSubArray[leftIndex] >= rightSubArray[rightIndex])
                {
                    arrToSort[sortedIndex] = leftSubArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arrToSort[sortedIndex] = rightSubArray[rightIndex];
                    rightIndex++;
                }
                sortedIndex++;
            }

            // Copy any remaining elements from leftSubArray
            while (leftIndex < leftSubArray.Length)
            {
                arrToSort[sortedIndex] = leftSubArray[leftIndex];
                leftIndex++;
                sortedIndex++;
            }

            // Copy any remaining elements from rightSubArray
            while (rightIndex < rightSubArray.Length)
            {
                arrToSort[sortedIndex] = rightSubArray[rightIndex];
                rightIndex++;
                sortedIndex++;
            }
        }

        public static void MergeSort(Student[] arrToSort)
        {
            if (arrToSort.Length <= 1) return; // Early return for arrays of length 1 or less

            int mid = arrToSort.Length / 2;

            // Create left and right sub-arrays
            Student[] leftSubArray = new Student[mid];
            Student[] rightSubArray = new Student[arrToSort.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                leftSubArray[i] = arrToSort[i];
            }

            for (int i = mid; i < arrToSort.Length; i++)
            {
                rightSubArray[i - mid] = arrToSort[i];
            }

            // Recursively sort the sub-arrays
            MergeSort(leftSubArray);
            MergeSort(rightSubArray);

            // Merge the sorted sub-arrays
            Merge(arrToSort, leftSubArray, rightSubArray);
        }

        private static void Merge(Student[] arrToSort, Student[] leftSubArray, Student[] rightSubArray)
        {
            int leftIndex = 0, rightIndex = 0, sortedIndex = 0;

            // Merge elements from leftSubArray and rightSubArray in sorted order
            while (leftIndex < leftSubArray.Length && rightIndex < rightSubArray.Length)
            {
                if (leftSubArray[leftIndex].gpa >= rightSubArray[rightIndex].gpa)
                {
                    arrToSort[sortedIndex] = leftSubArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arrToSort[sortedIndex] = rightSubArray[rightIndex];
                    rightIndex++;
                }
                sortedIndex++;
            }

            // Copy any remaining elements from leftSubArray
            while (leftIndex < leftSubArray.Length)
            {
                arrToSort[sortedIndex] = leftSubArray[leftIndex];
                leftIndex++;
                sortedIndex++;
            }

            // Copy any remaining elements from rightSubArray
            while (rightIndex < rightSubArray.Length)
            {
                arrToSort[sortedIndex] = rightSubArray[rightIndex];
                rightIndex++;
                sortedIndex++;
            }
        }

    }
}