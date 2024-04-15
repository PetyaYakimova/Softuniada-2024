using System.Text;

namespace PalindromicNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[] number = Console.ReadLine().ToCharArray();
			List<int> digits = new List<int>();

			foreach (char character in number)
			{
				digits.Add((character - '0'));
			}

			digits = digits.OrderByDescending(d => d).ToList();

			Dictionary<int, int> numberOfEachDigit = new Dictionary<int, int>();
			for (int i = 0; i < digits.Count; i++)
			{
				if (!numberOfEachDigit.ContainsKey(digits[i]))
				{
					numberOfEachDigit.Add(digits[i], 0);
				}

				numberOfEachDigit[digits[i]]++;
			}

			int numberOfDigitsWihOddCount = 0;
			foreach (var digit in numberOfEachDigit)
			{
				if (digit.Value % 2 != 0)
				{
					numberOfDigitsWihOddCount++;
				}
			}

			if (numberOfDigitsWihOddCount > 1)
			{
				Console.WriteLine("No palindromic number available.");
			}
			else
			{
				StringBuilder sb = new StringBuilder();
				int position = 0;
				while (digits.Count>1)
				{
					if (digits[position] == digits[position+1])
					{
						sb.Append(digits[position]);
						digits.RemoveAt(position);
						digits.RemoveAt(position);
					}
					else
					{
						position++;
					}
				}

				char[] charArray = sb.ToString().ToCharArray();
				Array.Reverse(charArray);
				string end =  new string(charArray);

				if (digits.Any())
				{
					sb.Append(digits[0]);
				}
				sb.Append(end);

				Console.WriteLine(sb.ToString().Trim());
			}
		}
	}
}