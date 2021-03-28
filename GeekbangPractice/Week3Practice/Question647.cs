using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Practice
{
    class Question647
    {
        public int CountSubstrings(string s)
        {
            int m = s.Length;
            int res = 0;
            var dp = new bool[m, m];

            for (int j = 0; j < m; j++)
            {
                for (int i = j; i >= 0; i--)
                {
                    if (s[i] == s[j] && ((j - i < 2) || dp[i + 1, j - 1]))
                    {
                        dp[i, j] = true;
                        res++;
                    }
                }
            }
            return res;
        }s
    }
}
