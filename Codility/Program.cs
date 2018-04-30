using System;
using Codility.Lesson_1___Iterations;
using Codility.Lesson_2___Arrays;
using Codility.Lesson_3___Time_Complexity;
using Codility.Lesson_4___Counting_Elements;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
            //BinaryGap binaryGap = new BinaryGap();
            //Console.WriteLine(binaryGap.solution(1376796946));

            // https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
            //CyclicRotation cyclicRotation = new CyclicRotation();
            //Console.WriteLine(cyclicRotation.solution(new int[] { 3, 8, 9, 7, 6 }, 3));
            //Console.WriteLine(cyclicRotation.solution(new int[] { 1, 2, 3, 4 }, 4));

            // https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
            //OddOccurrencesInArray oddOccurrencesInArray = new OddOccurrencesInArray();
            //Console.WriteLine(oddOccurrencesInArray.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));

            // https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
            //PermMissingElem permMissingElem = new PermMissingElem();
            //Console.WriteLine(permMissingElem.solution(new int[] { 2, 3, 1, 5 }));

            // https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
            //FrogJmp frogJmp = new FrogJmp();
            //Console.WriteLine(frogJmp.solution(10, 85, 30));

            // https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
            //TapeEquilibrium tapeEquilibrium = new TapeEquilibrium();
            //Console.WriteLine(tapeEquilibrium.solution(new int[] { 3, 1, 2, 4, 3 }));

            // https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
            PermCheck permCheck = new PermCheck();
            Console.WriteLine(permCheck.solution(new int[] { 3, 1, 2, 4 }));



        }
    }
}






//    class Solution
//    {
//        private void SwitchPlaces(int i, int j, int[] numbers)
//        {
//            var tmp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = tmp;
//        }

//        public int solution(int[] numbers)
//        {
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                while (0 < numbers[i] && numbers[i] - 1 < numbers.Length
//                                   && numbers[i] != i + 1
//                                   && numbers[i] != numbers[numbers[i] - 1])
//                {
//                    SwitchPlaces(i, numbers[i] - 1, numbers);
//                }
//            }

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                if (numbers[i] != i + 1)
//                {
//                    return i + 1;
//                }
//            }
//            return numbers.Length + 1;
//        }
//    }