namespace SimpleConsoleApp
{
	using System.Collections.Generic;
	using System.Linq;

	public class StatisticsHelper
	{
		public static double CalculateAverage(int[] userNums)
		{
			return userNums.Average();
		}

		public static double CalculateMax(int[] userNums)
		{
			return userNums.Max();
		}

		public static double CalculateMin(int[] userNums)
		{
			return userNums.Min();
		}
	}
}
