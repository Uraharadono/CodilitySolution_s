using System;

namespace Codility.Lesson_1___Iterations
{
    public class BinaryGap
    {
        public int solution(int number)
        {
            string binary = Convert.ToString(number, 2);
            int maxNumOfSpaces = 0, counter = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    counter++;
                }
                else
                {
                    if (maxNumOfSpaces < counter)
                        maxNumOfSpaces = counter;
                    counter = 0;
                }
            }

            return maxNumOfSpaces;
        }
    }
}
