using System;

namespace SolvingProblems.Easy
{
	public	class Task1491
	{
		public double Average(int[] salary)
		{
			int min = 1000001, max = 0;
			double sum = 0;
			foreach (var s in salary)
			{
				min = Math.Min(s, min);
				max = Math.Max(s, max);
				sum += s;
			}

			double v = (sum - min - max) / (salary.Length - 2);
			return Math.Round(v, 5);
		}
	}
}
