namespace SimpleConsoleApp
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter some nums to find the average:");
            string userNumsString = Console.ReadLine();
            string[] userNums = userNumsString.Split();
            int[] nums = new int[userNums.Length];
            for (int i = 0; i < userNums.Length; i++)
            {
                nums[i] = int.Parse(userNums[i]);
            }

            Console.WriteLine("Average: " + StatisticsHelper.CalculateAverage(nums));
        }
    }
}