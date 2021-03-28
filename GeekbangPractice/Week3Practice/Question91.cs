using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Practice
{
    public class Question91
    {
        public int NumDecodings(string s)
        {
            int m = s.Length;
            var dp = new int[m];
            if (s[0] == '0') return 0;
            dp[0] = 1;
            for (int i = 1; i < m; i++)
            {
                if (s[i] == '0')
                {
                    if (s[i - 1] == '1' || s[i - 1] == '2')
                    {
                        if (i == 1)
                        {
                            dp[i] = 1;
                        }
                        else
                        {
                            dp[i] = dp[i - 2];
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    int value = 10 * (s[i - 1] - '0') + (s[i] - '0');
                    if (value >= 11 && value <= 26)
                    {
                        if (i == 1)
                        {
                            dp[i] = dp[0] + 1;
                        }
                        else
                        {
                            dp[i] = dp[i - 1] + dp[i - 2];
                        }
                    }
                    else
                    {
                        dp[i] = dp[i - 1];
                    }
                }
            }
            return dp[m - 1];
        }
    }
}
