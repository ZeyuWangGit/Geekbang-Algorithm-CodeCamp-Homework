using System;
using Xunit;

namespace Week1Practice
{
    // 26. 删除排序数组中的重复项
    public class Question26
    {
        [Fact]
        public void SampleTest()
        {
            // Arrange 
            var expected = 5;
            var nums = new int[10]{ 0,0,1,1,1,2,2,3,3,4 };
            // Act
            var actual = RemoveDuplicates(nums);
            // Assert
            Assert.Equal(expected, actual);
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
