internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Hellowowoelrl");
		Console.WriteLine("bnweh");
		Console.WriteLine();
		double a = Avg(new int[] { 1, 2,3,25,69})
	}
	public static double Avg(int[] numbers)
	{
		int result = 0;
		int avg;
		for (int i = 0; i < numbers.Length; i++)
		{
			result += numbers[i];
		}
		double avg1 = result / numbers.Length;
		return avg1;
	}
}
