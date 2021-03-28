using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Practice
{
    class Question221
    {
        public int MaximalSquare(char[][] matrix)
        {
            int max = 0;
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;
            int m = matrix.Length;
            int n = matrix[0].Length;
            var dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        if (i == 0 || j == 0)
                        {
                            dp[i, j] = 1;
                            max = Math.Max(dp[i, j], max);
                        }
                        else
                        {
                            dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
                            max = Math.Max(dp[i, j], max);
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            return max * max;
        }
    }
}
