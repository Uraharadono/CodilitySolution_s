using System.Linq;

namespace Codility.Lesson_4___Counting_Elements
{
    public class PermCheck
    {
       /*
        * Solution 1
        * Detected time complexity: noone
        * Task Score: 100%
        * Correctness: 100%
        * Performance: 100%
        */
        public int solution(int[] numbers)
        {
            // if array is empty, return 0
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            // sort array using built in sorting function by microsoft, because I failed to create proper quick sort algorithm by myself in a task before
            numbers = numbers.OrderBy(s => s).ToArray();

            // if first element is not 1, return 0
            if (numbers[0] != 1)
            {
                return 0;
            }

            // since we are sure 1st elemnt is 1, we go from 2nd and so on
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] != numbers[i] - 1)
                    return 0;
            }
            
            return 1;
        }
    }
}
