using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Practice
{
    // 88. 合并两个有序数组s
    public class Question88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m, j = 0; i < nums1.Length; i++)
            {
                nums1[i] = nums2[j++];
            }
            Array.Sort(nums1);
        }
    }
}
