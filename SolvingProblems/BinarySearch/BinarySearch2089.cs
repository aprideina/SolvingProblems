using System.Collections.Generic;

namespace SolvingProblems.BinarySearch
{
	public class BinarySearch2089
	{
		public IList<int> TargetIndices(int[] nums, int target)
		{
			var result = 0;
			var counter = 0;
			foreach (var num in nums)
			{
				if (num < target)
				{
					result++;
				}

				if(num == target)
				{
					counter++;
				}
			}

			if (counter == 0)
				return new int[] { };

			var r = new int[counter];
			for (int i = 0; i < counter; i++)
			{
				r[i] = result + i;
			}

			return r;
		}
	}
}