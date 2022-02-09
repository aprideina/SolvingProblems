using System;

namespace SolvingProblems.Pointers
{
	public class Pointers977
	{
		public int[] SortedSquares(int[] nums)
		{
			var left = 0;
			var right = nums.Length - 1;

			var result = new int[nums.Length];

			var index = 1;
			while (left <= right)
			{
				var leftValue = Math.Pow(nums[left], 2.0);
				var rightValue = Math.Pow(nums[right], 2.0);

				if (rightValue > leftValue)
				{
					result[nums.Length - index++] = (int)rightValue;
					right -= 1;
				}
				else 
				{
					result[nums.Length - index++] = (int)leftValue;
					left += 1;
				}
			}

			return result;
		}
	}
}