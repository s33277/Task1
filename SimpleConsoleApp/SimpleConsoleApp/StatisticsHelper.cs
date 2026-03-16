namespace SimpleConsoleApp
{
	using System.Collections.Generic;
	using System.Linq;

	public class StatisticsHelper
	{
		public static double CalculateAverage(int[] nums)
		{
			return nums.Average();
		}

		public static double CalculateMax(int[] nums)
		{
			return nums.Max();
		}

		public static double CalculateMin(int[] nums)
		{
			return nums.Min();
		}
	}
}
