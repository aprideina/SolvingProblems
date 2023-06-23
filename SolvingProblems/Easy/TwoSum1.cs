using System.Collections.Generic;

namespace SolvingProblems.Easy
{
	public class TwoSum1
	{
		public int[] TwoSum(int[] nums, int target)
		{
			// key - expected value
			// value - index in nums array
			var result = new int[2];
			var dict = new Dictionary<int, int>();

			for (var i = 0; i < nums.Length; i++)
			{
				var current = nums[i];
				var expectedValue = current >= 0 ? target - current : current - target;

				if (dict.ContainsKey(expectedValue) || (i == nums.Length - 1))
				{
					result[0] = dict[expectedValue];
					result[1] = i;

					break;
				}
					
				dict.Add(expectedValue, i);
			}

			return result;
		}
	}
}
