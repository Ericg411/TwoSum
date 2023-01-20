using System;

namespace TwoSum
{
    internal class Program
    {
        //Given an array of integers nums and an integer target, 
        //return indices of the two numbers such that they add up to target.
        static void Main(string[] args)
        {
            Console.WriteLine("");
            
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int i2 = 0; i2 < nums.Length; i2++)
                {
                    if (nums[i] + nums[i2] == target && i != i2)
                    {
                        int[] newArr = { i, i2 };
                        return newArr;
                    }
                }
            }
            return nums;
        }
    }
}
