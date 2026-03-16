public class StatisticsHelper
{
	public static double GetAverage(string[] userNums)
	{
		List<double> nums = new List<double>();
		foreach (string n in userNums) nums.Add(double.Parse(n));
		return (double)nums.Average();
	}
}
