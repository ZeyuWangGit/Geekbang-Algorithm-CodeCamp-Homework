using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Practice
{
    // 78. 子集
    public class Question78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            backtrace(0, nums, res, new List<int>());
            return res;
        }

        private void backtrace(int start, int[] nums, List<IList<int>> res, List<int> temp)
        {
            res.Add(new List<int>(temp));
            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                backtrace(i + 1, nums, res, temp);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
