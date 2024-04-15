namespace ChampionsCup
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			//Top part
			for (int i = 0; i < n / 2; i++)
			{
				for (int j = 0; j < n + i; j++)
				{
					Console.Write('.');
				}

				for (int j = 0; j < 3 * n - (2 * i); j++)
				{
					Console.Write('#');
				}

				for (int j = 0; j < n + i; j++)
				{
					Console.Write('.');
				}
				Console.WriteLine();
			}

			//Empty part
			for (int i = 0; i < n / 2 + 1; i++)
			{
				for (int j = 0; j < n * 3 / 2 + i; j++)
				{
					Console.Write('.');
				}

				Console.Write('#');

				for (int j = 0; j < (2 * n - (2 * i) - 2); j++)
				{
					Console.Write('.');
				}

				Console.Write('#');

				for (int j = 0; j < n * 3 / 2 + i; j++)
				{
					Console.Write('.');
				}

				Console.WriteLine();
			}

			//Middle part
			for (int j = 0; j < 2 * n; j++)
			{
				Console.Write('.');
			}

			for (int j = 0; j < n; j++)
			{
				Console.Write('#');
			}

			for (int j = 0; j < 2 * n; j++)
			{
				Console.Write('.');
			}
			Console.WriteLine();


			//Bottom part
			for (int i = 0; i < n / 2; i++)
			{
				for (int j = 0; j < 2 * n - 2; j++)
				{
					Console.Write('.');
				}

				for (int j = 0; j < n + 4; j++)
				{
					Console.Write('#');
				}

				for (int j = 0; j < 2 * n - 2; j++)
				{
					Console.Write('.');
				}
				Console.WriteLine();
			}

			for (int j = 0; j < (5 * n / 2 - 5); j++)
			{
				Console.Write('.');
			}
			Console.Write("D^A^N^C^E^");
			for (int j = 0; j < (5 * n / 2 - 5); j++)
			{
				Console.Write('.');
			}
			Console.WriteLine();

			for (int i = 0; i < n / 2 + 1; i++)
			{
				for (int j = 0; j < 2 * n - 2; j++)
				{
					Console.Write('.');
				}

				for (int j = 0; j < n + 4; j++)
				{
					Console.Write('#');
				}

				for (int j = 0; j < 2 * n - 2; j++)
				{
					Console.Write('.');
				}
				Console.WriteLine();
			}
		}
	}
}