namespace Codility.Lesson_3___Time_Complexity
{
    public class FrogJmp
    {
        /*
         * Solution 2
         * Formula: Y - X / D  NOTE: BE AWARE OF F***ING POINTS
         * Detected time complexity: O(1)
         * Task Score: 100%
         * Correctness: 100%
         * Performance: 100%
         */
        public int solution(int positionX, int positionY, int canJump)
        {
            int diff = positionY - positionX;
            int count = diff / canJump;
            if (diff % canJump > 0)
            {
                count++;
            }
            return count;
        }

        /*
         * Solution 1
         * Detected time complexity: O(Y-X)
         * Task Score: 55%
         * Correctness: 100%
         * Performance: 20%
         */
        //public int solution(int positionX, int positionY, int canJump)
        //{
        //    int numberOfJumps = 0;

        //    while (positionX < positionY)
        //    {
        //        positionX = positionX + canJump;
        //        numberOfJumps++;
        //    }

        //    return numberOfJumps;
        //}
    }
}
