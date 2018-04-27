using System.Collections.Generic;

namespace Codility.Lesson_2___Arrays
{
    public class OddOccurrencesInArray
    {
        /*
         * THIRD ATTEMPT WITH STACK OVERFLOW ( https://stackoverflow.com/questions/45855564/find-number-with-no-pair-in-array - Schidu Luca)
         * Then I went ahead to read about maths of XOR which was fail as fuck: https://stackoverflow.com/questions/2385389/xor-using-mathematical-operators
         */
        public int solution(int[] numbers)
        {
            var element = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                element = element ^ numbers[i];
            }

            return element;
        }


        /*
         * SECOND ATTEMPT
         * Task Score: 55%
         * Correctness: 80%
         * Performance: 25%
         */

        //public int solution(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        bool hasFound = false;

        //        for (int j = (i + 1); j < numbers.Length; j++)
        //        {
        //            if (numbers[i] == numbers[j])
        //                hasFound = true;
        //        }

        //        for (int j = 0; j < i; j++)
        //        {
        //            if (numbers[i] == numbers[j])
        //                hasFound = true;
        //        }

        //        if (!hasFound)
        //            return numbers[i];
        //    }

        //    return numbers[0];
        //}



        /*
         * FIRST ATTEMPT
         * Task Score 55%
         * Correctness 80%
         * Performance 25%
         */

        //public int solution(int[] numbers)
        //{
        //    int counter = 0;
        //    int[] foundNumbers = new int[numbers.Length / 2];

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        var hasFound = false;

        //        // Check if number already has been found before
        //        for (int j = 0; j < foundNumbers.Length; j++)
        //        {
        //            if (foundNumbers[j] == numbers[i])
        //            {
        //                hasFound = true;
        //            }
        //        }

        //        // Then check if number is found further in array
        //        for (int j = (i + 1); j < numbers.Length; j++)
        //        {
        //            if (numbers[i] == numbers[j])
        //            {
        //                hasFound = true;
        //                if (!AlreadyRecordedDuplicate(foundNumbers, numbers[j]))
        //                {
        //                    foundNumbers[counter] = numbers[j];
        //                    counter++;
        //                }
        //                break;
        //            }
        //        }

        //        if (!hasFound)
        //            return numbers[i];
        //    }

        //    return numbers[0];
        //}

        //private bool AlreadyRecordedDuplicate(int[] foundNumbers, int number)
        //{
        //    for (int i = 0; i < foundNumbers.Length; i++)
        //    {
        //        if (number == foundNumbers[i])
        //            return true;
        //    }

        //    return false;
        //}
    }
}
