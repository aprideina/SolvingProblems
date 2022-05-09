namespace SolvingProblems.Arrays
{
	public class Array1351
	{
		public int CountNegatives(int[][] grid)
		{
			var m = grid.GetLength(0);

			var count = 0;
			for (var i = m - 1; i >= 0; i--)
			{
				var n = grid[i].Length;
				for (var j = n - 1; j >= 0; j--)
				{
					if (grid[i][j] >= 0)
					{
						break;
					}
						
					count++;
				}
			}

			return count;
		}
	}
}