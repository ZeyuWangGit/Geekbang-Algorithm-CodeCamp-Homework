using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Practice
{
    // 189. 旋转数组
    public class Question189
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }
        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[end];
                nums[end] = nums[start];
                nums[start] = temp;
                start++;
                end--;
            }

        }
    }
}
