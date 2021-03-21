using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Practice
{
    // 46. 全排列
    public class Question46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
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
