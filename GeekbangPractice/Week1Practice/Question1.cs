using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Practice
{
    // 1. 两数之和
    public class Question1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[2] { dict[target - nums[i]], i };
                }
                dict.Add(nums[i], i);
            }
            return new int[2];
        }
    }
}
