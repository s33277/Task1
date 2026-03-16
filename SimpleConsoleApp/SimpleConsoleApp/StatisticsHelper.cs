namespace SimpleConsoleApp
{
	using System.Collections.Generic;
	using System.Linq;

	public class StatisticsHelper
	{
		public static double CalculateAverage(string[] userNums)
		{
			List<double> nums = new List<double>();
			foreach (string n in userNums) nums.Add(double.Parse(n));
			return nums.Average();
		}
	}
}
