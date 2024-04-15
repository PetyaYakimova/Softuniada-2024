namespace Chess
{
	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int startRow = int.Parse(Console.ReadLine());
			int startCol = int.Parse(Console.ReadLine());
			int finalRow = int.Parse(Console.ReadLine());
			int finalCol = int.Parse(Console.ReadLine());

			Solution solution = new Solution(n);

			Console.WriteLine(solution.GetResult(startRow, startCol, finalRow, finalCol));
		}
	}
	public class Solution
	{
		private int minNumberOfMoves;
		private int n;

		public Solution(int n)
		{
			this.n = n;
			minNumberOfMoves = n * 2;
		}

		public int GetResult(int startRow, int startCol, int finalRow, int finalCol)
		{
			List<int[]> positionsSoFar = new List<int[]>();

			this.GetNextPosition(startRow, startCol, finalRow, finalCol, 0, positionsSoFar);

			return minNumberOfMoves;
		}
		public void GetNextPosition(int currentRow, int currentCol, int finalRow, int finalCol, int currentNumebrOfMoves, List<int[]> possitionsSoFar)
		{
			if (currentRow == finalRow && currentCol == finalCol)
			{
				if (minNumberOfMoves > currentNumebrOfMoves)
				{
					minNumberOfMoves = currentNumebrOfMoves;
				}
			}
			else if (minNumberOfMoves <= currentNumebrOfMoves)
			{
				//Stop
			}
			else if (possitionsSoFar.Any(p => p[0] == currentRow && p[1] == currentCol))
			{
				//Stop
			}
			else
			{
				List<int[]> newPossitionsSoFar = new List<int[]>();
				foreach (int[] possition in possitionsSoFar)
				{
					newPossitionsSoFar.Add(possition);
				}
				newPossitionsSoFar.Add(new int[] { currentRow, currentCol });

				List<int[]> possibleNextMoves = GetNextMovesFromPosition(currentRow, currentCol, n);

				foreach (int[] possiblleNextMove in possibleNextMoves)
				{
					int newCurrentNumberOfMoves = currentNumebrOfMoves + 1;

					GetNextPosition(possiblleNextMove[0], possiblleNextMove[1], finalRow, finalCol, newCurrentNumberOfMoves, newPossitionsSoFar);
				}
			}
		}

		private List<int[]> GetNextMovesFromPosition(int currentRow, int currentCol, int n)
		{
			List<int[]> allPosibleNextMoves = new List<int[]>();

			if (currentRow - 2 >= 0)
			{
				if (currentCol - 1 >= 0)
				{
					allPosibleNextMoves.Add(new int[] { currentRow - 2, currentCol - 1 });
				}

				if (currentCol + 1 < n)
				{
					allPosibleNextMoves.Add(new int[] { currentRow - 2, currentCol + 1 });
				}
			}

			if (currentRow - 1 >= 0)
			{
				if (currentCol - 2 >= 0)
				{
					allPosibleNextMoves.Add(new int[] { currentRow - 1, currentCol - 2 });
				}

				if (currentCol + 2 < n)
				{
					allPosibleNextMoves.Add(new int[] { currentRow - 1, currentCol + 2 });
				}
			}

			if (currentRow + 1 < n)
			{
				if (currentCol - 2 >= 0)
				{
					allPosibleNextMoves.Add(new int[] { currentRow + 1, currentCol - 2 });
				}

				if (currentCol + 2 < n)
				{
					allPosibleNextMoves.Add(new int[] { currentRow + 1, currentCol + 2 });
				}
			}

			if (currentRow + 2 < n)
			{
				if (currentCol - 1 >= 0)
				{
					allPosibleNextMoves.Add(new int[] { currentRow + 2, currentCol - 1 });
				}

				if (currentCol + 1 < n)
				{
					allPosibleNextMoves.Add(new int[] { currentRow + 2, currentCol + 1 });
				}
			}

			return allPosibleNextMoves;
		}
	}
}