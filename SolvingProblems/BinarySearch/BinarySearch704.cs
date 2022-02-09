namespace SolvingProblems.BinarySearch
{
	/// <summary>
	///     https://leetcode.com/problems/binary-search/
	/// </summary>
	public class BinarySearch704
	{
		public int Search(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;

			do
			{
				var med = (left + right) / 2;

				if (med >= nums.Length) return -1;

				var value = nums[med];

				if (value == target) return med;

				if (target > value) left = med + 1;

				if (target < value) right = med - 1;
			} while (left <= right);

			return -1;
		}
	}
}