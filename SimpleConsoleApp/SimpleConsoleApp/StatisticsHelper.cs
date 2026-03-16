namespace SimpleConsoleApp
{
	using System.Collections.Generic;
	using System.Linq;

	public class StatisticsHelper
	{
		public static double CalculateAverage(int[] numbers)
		{
			return numbers.Average();
		}

		public static double CalculateMax(int[] numbers)
		{
			return numbers.Max();
		}

		public static double CalculateMin(int[] numbers)
		{
			return numbers.Min();
		}
	}
}
