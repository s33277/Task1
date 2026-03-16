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
            List<Integer> nums = new List<>();
            foreach (string userNum in userNums)
            {
                nums.append(userNum);
            }

            Console.WriteLine("Average: " + StatisticsHelper.CalculateAverage(userNums));
        }
    }
}