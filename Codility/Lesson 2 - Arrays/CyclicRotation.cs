using System.Collections.Generic;

namespace Codility.Lesson_2___Arrays
{
    // NOTE TO SELF
    // Even tho speed was not assesed, in better scenario i should have used array instead of list
    // int[] temp = new int[numbers.Length];;

    public class CyclicRotation
    {
        public int[] solution(int[] numbers, int numOfShifts)
        {
            if (numbers == null || numbers.Length == 0)
                return new int[0];

            for (int i = 0; i < numOfShifts; i++)
            {
                // create temp list
                List<int> temp = new List<int>();

                // set first element as last
                temp.Add(numbers[numbers.Length - 1]);

                // then shuffle bby
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    temp.Add(numbers[j]);
                }

                numbers = temp.ToArray();
            }

            return numbers;
        }


    }
}
