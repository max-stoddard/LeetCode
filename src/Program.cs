using System;

namespace LeetCode
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from LeetCode!");
        }

        public int LongestConsecutive(int[] nums)
        {
            // Turn nums to hashSet

            // Find a start element

            // See how deep it goes

            // Return best of start elements

            HashSet<int> set = new HashSet<int>(nums);
            int best = 0;

            foreach (int n in set)
            {
                if (!set.Contains(n - 1))
                {
                    // n is first element in sequenct
                    int cnt = 1;
                    while (set.Contains(n + cnt))
                    {
                        cnt++;
                    }

                    best = Math.Max(cnt, best);
                }
            }

            return best;
        }
    }
}
