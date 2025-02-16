using System;

namespace LeetCode
{
  public class Solution
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello from LeetCode!");
    }

    public static int LongestConsecutive(int[] nums) {
        // n + 1
        // HashMap n + 1 => no in sequence already
        // n => (n + 1, 1)
        // n + 1 => (n + 2, 2)
        // n, n + 2 => (n + 1, 1), (n + 3, 1)
        //      n + 1 => (n + 2, 2), (n + 3, 1) => check if n + 2 + 1 on increment
        int n = nums.Length;
        if (n <= 1)
            return n;

        Dictionary<int, int> map = [];

        // Process

        return map
            .Select(kvp => kvp.)
            .Max();
    }
  }
}
