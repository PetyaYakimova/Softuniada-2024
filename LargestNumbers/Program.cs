namespace LargestNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			int k = int.Parse(Console.ReadLine());

			numbers = numbers.OrderBy(n => n).Skip(numbers.Count - k).ToList();
			Console.WriteLine(string.Join(Environment.NewLine, numbers));
		}
	}
}