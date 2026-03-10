using System;

public class StatisticsHelper
{
	public static double GetAverage()
	{
		Console.WriteLine("Enter some nums to find the average:");

		string userNumsString = Console.ReadLine();
		string[] userNums = userNumsString.Split();
		List<int> nums = new List<int>();
		foreach (string n in userNums) nums.Add(int.Parse(n));
		int average = (int)nums.Average();
		return average;
	}
}
