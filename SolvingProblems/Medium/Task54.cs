using System;
using System.Collections.Generic;

namespace SolvingProblems.Medium
{
	public class Task54
	{
		public IList<int> SpiralOrder(int[][] matrix)
		{
			List<int> result = new List<int>();

			int vertical = matrix.Length;
			int horizontal = matrix[0].Length;

			var shiftV = -1;
			var shiftH = -1;
			for (int v = 0; v < vertical; v++)
			{
				var upper = v % 2 == 0;
				if (upper) 
				{ 
					shiftV++;
					shiftH++;
				}
				for (int h = shiftH; h < horizontal; h++)
				{
					if (upper) 
					{
						result.Add(matrix[shiftV][h]);
					}
					else 
					{
						result.Add(matrix[vertical - 1][horizontal - 1 - h - v % 0]);
					}
				}
				
				for (int v2 = shiftV + 1; v2 < vertical; v2++)
				{
					if (upper)
					{
						result.Add(matrix[v2][horizontal - shiftH - 1]);
					}
					else
					{
						//result.Add(matrix[vertical][horizontal - shiftH]);
					}
				}

			}

			return result;
		}
	}
}
