using System;
using System.Collections.Generic;

namespace SolvingProblems.SBR
{
	class FirstFight
	{
		public static int GetResult(List<int> ground)
		{
			var sum = 0;
			var operations = 0;
			var indexes = new int[200];
			foreach (int i in ground)
			{
				sum += i;
				indexes[i]++;
			}

			var mid = (int)Math.Round(sum * 1.0 / ground.Count);
			for (var i = 0; i < indexes.Length; i++)
			{
				if (i == mid)
				{
					continue;
				}

				if (indexes[i] != 0)
				{
					operations += Math.Abs(mid - i);
				}
			}
			return operations;
		}
	}
}
