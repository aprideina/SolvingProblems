using System.Collections.Generic;

namespace SolvingProblems.Arrays.InterviewBit
{
	public class MaxMin
	{
		public int Solve(List<int> A)
		{
			var min = A[0];
			var max = A[0];
			foreach (var i in A)
			{
				if (i < min) min = i;
				if (i > max) max = i;
			}

			return min + max;
		}
	}
}