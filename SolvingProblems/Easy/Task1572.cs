namespace SolvingProblems.Easy
{
	public class Task1572
	{
		public int DiagonalSum(int[][] mat)
		{
			var sum = 0;
			if (mat.Length == 1) 
			{
				return mat[0][0];
			}

			for (int i = 0; i < mat.Length; i++) 
			{
				sum += mat[i][i];

				int v = mat.Length - 1 - i;
				if(v != i)
				{
					sum += mat[v][i];
				}
			}

			return sum;
		}
	}
}
