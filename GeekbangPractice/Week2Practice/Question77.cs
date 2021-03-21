using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Practice
{
    // 77. 组合
    public class Question77
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var res = new List<IList<int>>();
            backtrace(1, n, k, new List<int>(), res);
            return res;
        }

        private void backtrace(int start, int n, int k, List<int> path, List<IList<int>> res)
        {
            if (path.Count == k)
            {
                res.Add(new List<int>(path));
            }
            for (int i = start; i <= n; i++)
            {
                path.Add(i);
                backtrace(i + 1, n, k, path, res);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
