namespace SpecialNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());

			for (int number = n; number <= m; number++)
			{
				if (NumberIsSpecial(number))
				{
					Console.WriteLine(number);
				}
			}
		}

		private static bool NumberIsSpecial(int number)
		{
			char[] digitsAsChar = number.ToString().ToCharArray();

			List<int> digits = new List<int>();

			foreach (char character in digitsAsChar)
			{
				digits.Add((character - '0'));
			}

			for (int i = 0; i < digits.Count - 1; i++)
			{
				if ((digits[i] + 1 == digits[i + 1]) || ((digits[i] - 1) == digits[i + 1]))
				{

				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}