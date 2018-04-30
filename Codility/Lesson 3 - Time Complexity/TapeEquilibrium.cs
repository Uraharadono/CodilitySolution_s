using System;

namespace Codility.Lesson_3___Time_Complexity
{
    public class TapeEquilibrium
    {
        /*
        * Solution 3
        * Detected time complexity: O(N)
        * Task Score: 91%
        * Correctness: 83%
        * Performance: 100%
        */
        public int solution(int[] numbers)
        {
            if (numbers.Length == 2)
                return Math.Abs(numbers[0] - numbers[1]);

            int headSum = 0, tailSum = 0;

            // Init head values
            headSum = numbers[0];

            // Init tail values
            for (int i = 1; i < numbers.Length; i++)
            {
                tailSum += numbers[i];
            }

            // Init return param values
            int minimalDifference = Math.Abs(headSum - tailSum);

            for (int i = 1; i < numbers.Length; i++)
            {
                headSum += numbers[i];
                tailSum -= numbers[i];
                if (Math.Abs(headSum - tailSum) < minimalDifference)
                {
                    minimalDifference = Math.Abs(headSum - tailSum);
                }
            }

            return minimalDifference;
        }

        /*
        * Solution 2
        * Detected time complexity: O(N)
        * Task Score: 83%
        * Correctness: 55%
        * Performance: 100%
        */
        //public int solution(int[] numbers)
        //{
        //    int headSum = 0, tailSum = 0;

        //    // Init head values
        //    headSum = numbers[0];

        //    // Init tail values
        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        tailSum += numbers[i];
        //    }

        //    // Init return param values
        //    int minimalDifference = Math.Abs(headSum - tailSum);

        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        headSum += numbers[i];
        //        tailSum -= numbers[i];
        //        if (Math.Abs(headSum - tailSum) < minimalDifference)
        //        {
        //            minimalDifference = Math.Abs(headSum - tailSum);
        //        }
        //    }

        //    return minimalDifference;
        //}


        /*
        * Solution 1
        * Detected time complexity: O(N * N)
        * Task Score: 33%
        * Correctness: 66%
        * Performance: 0%
        */
        //public int solution(int[] numbers)
        //{
        //    int minimalDifference = int.MaxValue;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        int headSum = 0, tailSum = 0;

        //        // Sum head
        //        for (int j = 0; j <= i; j++)
        //        {
        //            headSum = headSum + numbers[j];
        //        }

        //        // Sum tail
        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            tailSum = tailSum + numbers[j];
        //        }

        //        int difference = Math.Abs(headSum - tailSum);
        //        if (difference < minimalDifference)
        //        {
        //            minimalDifference = difference;
        //        }
        //    }

        //    return minimalDifference;
        //}
    }
}
