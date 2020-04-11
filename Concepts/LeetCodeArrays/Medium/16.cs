﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeArrays.Medium
{
    public class _16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(currentSum - target) < Math.Abs(sum - target))
                    {
                        sum = currentSum;
                    }
                    if (currentSum > target)
                    {
                        --right;
                    }
                    else
                    {
                        ++left;
                    }
                }
            }
            return sum;
        }

    }
}
