namespace PeakElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			int maxElement = int.MinValue;

			for (int i = 1; i < numbers.Count() - 1; i++)
			{
				if (numbers[i] > numbers[i - 1] 
					&& numbers[i] > numbers[i + 1]
					&& numbers[i]>maxElement)
				{
					maxElement = numbers[i];
				}
			}

			Console.WriteLine(maxElement);
		}
	}
}