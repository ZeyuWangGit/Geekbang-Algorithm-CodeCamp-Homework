using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Practice
{
    // 47. 全排列 II
    public class Question47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var res = new List<IList<int>>();
            Array.Sort(nums);
            backtrace(nums, new bool[nums.Length], new List<int>(), res);
            return res;
        }

        private void backtrace(int[] nums, bool[] used, List<int> path, List<IList<int>> res)
        {
            if (path.Count == nums.Length)
            {
                res.Add(new List<int>(path));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!used[i])
                {
                    if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
                    path.Add(nums[i]);
                    used[i] = true;
                    backtrace(nums, used, path, res);
                    used[i] = false;
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
