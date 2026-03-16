using System;

public class StatisticsHelper
{
	public static double GetAverage()
	{
		Console.WriteLine("Enter some nums to find the average:");

		string userNumsString = Console.ReadLine();
		string[] userNums = userNumsString.Split();
		List<double> nums = new List<double>();
		foreach (string n in userNums) nums.Add(double.Parse(n));
		return (double)nums.Average();
	}
}
