using System.Linq;

namespace Codility.Lesson_3___Time_Complexity
{
    public class PermMissingElem
    {
        /*
         * Solution 2 
         * NOTE NOTE: This one is faster for reasons unknown.
         * Maybe because of I used this implementation of QuickSort: https://www.geeksforgeeks.org/quick-sort/
         * And should have used this one, seems much better implemented: http://snipd.net/quicksort-in-c
         * Task Score: 100%
         * Correctness: 100%
         * Performance: 100%
         */
        public int solution(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 1;

            numbers = numbers.OrderBy(s => s).ToArray();

            if (numbers[0] != 1)
                return 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if ((numbers[i - 1] + 1) != numbers[i])
                    return numbers[i - 1] + 1;
            }

            return numbers[numbers.Length - 1] + 1;
        }


        /*
         * Solution 4 - Note: My implementation of sorting quick sort.
         * Task Score: 90%
         * Correctness: 100%
         * Performance: 80%
         */
        //static int partition(int[] arr, int low, int high)
        //{
        //    int pivot = arr[high];

        //    // index of smaller element
        //    int i = (low - 1);
        //    for (int j = low; j < high; j++)
        //    {
        //        // If current element is smaller than or equal to pivot
        //        if (arr[j] <= pivot)
        //        {
        //            i++;

        //            // swap arr[i] and arr[j]
        //            int temp = arr[i];
        //            arr[i] = arr[j];
        //            arr[j] = temp;
        //        }
        //    }

        //    // swap arr[i+1] and arr[high] (or pivot)
        //    int temp1 = arr[i + 1];
        //    arr[i + 1] = arr[high];
        //    arr[high] = temp1;

        //    return i + 1;
        //}
        ///* The main function that implements QuickSort()
        //arr[] --> Array to be sorted,
        //low --> Starting index,
        //high --> Ending index */
        //static void quickSort(int[] arr, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        /* pi is partitioning index, arr[pi] is now at right place */
        //        int pi = partition(arr, low, high);

        //        // Recursively sort elements before
        //        // partition and after partition
        //        quickSort(arr, low, pi - 1);
        //        quickSort(arr, pi + 1, high);
        //    }
        //}
        //public int solution(int[] numbers)
        //{
        //    // if array is empty just return 1
        //    if (numbers == null || numbers.Length == 0)
        //        return 1;

        //    // order array by ascending order
        //    // here I implement my sorting using quicksort cause that's what LINQ is using if I used "numbers.OrderBy(s => s).ToArray();"
        //    quickSort(numbers, 0, numbers.Length - 1);

        //    // if first elemnt is not 1, then return 1 (because of task "from 1...n")
        //    if (numbers[0] != 1)
        //        return 1;

        //    // go trough all of the elements, and compare previous one (+1) with current one
        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        if ((numbers[i - 1] + 1) != numbers[i])
        //            return numbers[i - 1] + 1;
        //    }

        //    // no element found, return last one + 1
        //    return numbers[numbers.Length - 1] + 1;
        //}


        /*
         * Solution 3 - Note: My implementation of sorting was wrong. LINQ actually uses quick sort by default, that's why my performace was bad.
         * Task Score: 50%
         * Correctness: 100%
         * Performance: 0%
         */
        //public int solution(int[] numbers)
        //{
        //    // if array is empty just return 1
        //    if (numbers == null || numbers.Length == 0)
        //        return 1;

        //    // order array by ascending order
        //    // numbers = numbers.OrderBy(s => s).ToArray(); //I hated this, even thought it is correct answer
        //    // so here I implement my sorting functions
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = 0; j < numbers.Length; j++)
        //        {
        //            if (numbers[i] < numbers[j])
        //            {
        //                int temp = numbers[j];
        //                numbers[j] = numbers[i];
        //                numbers[i] = temp;
        //            }
        //        }
        //    }

        //    // if first elemnt is not 1, then return 1 (because of task "from 1...n")
        //    if (numbers[0] != 1)
        //        return 1;

        //    // go trough all of the elements, and compare previous one (+1) with current one
        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        if ((numbers[i - 1] + 1) != numbers[i])
        //            return numbers[i - 1] + 1;
        //    }

        //    // no element found, return last one + 1
        //    return numbers[numbers.Length - 1] + 1;
        //}


        /*
         * Solution 1
         * Task Score: 50%
         * Correctness: 20%
         * Performance: 80%
         */
        //public int Solution(int[] numbers)
        //{
        //    numbers = numbers.OrderBy(s => s).ToArray();

        //    if (numbers[0] != 1)
        //        return 1;

        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        if ((numbers[i - 1] + 1) != numbers[i])
        //            return numbers[i - 1] + 1;
        //    }

        //    return 0;
        //}
    }
}
