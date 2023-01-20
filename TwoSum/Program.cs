using System;

namespace TwoSum
{
    internal class Program
    {
        //Given an array of integers nums and an integer target, 
        //return indices of the two numbers such that they add up to target.
        static void Main(string[] args)
        {
            //TEST CASES
            //feel free to change any of these to test my work!
            int[] test1 = { 2, 7, 11, 15 };
            foreach (int num in TwoSum(test1, 9)) //expected [0,1]
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine("\n");

            int[] test2 = { 3, 2, 4 };
            foreach (int num in TwoSum(test2, 6)) //expected [1,2]
            {
                Console.Write($"{num}, ");
            }

            Console.WriteLine("\n");

            int[] test3 = { 3, 3 };
            foreach (int num in TwoSum(test3, 6)) //expected [0,1]
            {
                Console.Write($"{num}, ");
            }


        }

        public static int[] TwoSum(int[] nums, int target)
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
