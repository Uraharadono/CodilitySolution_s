using System;
using Codility.Lesson_1___Iterations;
using Codility.Lesson_2___Arrays;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
            //BinaryGap lesson1 = new BinaryGap();
            //Console.WriteLine(lesson1.solution(1376796946));

            // https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
            CyclicRotation lesson2 = new CyclicRotation();
            Console.WriteLine(lesson2.solution(1376796946));

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