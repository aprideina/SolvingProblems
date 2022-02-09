namespace SolvingProblems.BinarySearch
{
	public class BinarySearch35
	{
		public int SearchInsert(int[] nums, int target)
		{
			var left = 0;
			var right = nums.Length - 1;

			while (nums[left] < target && nums[right] > target && (right - left) > 1)
			{
				var med = (left + right) / 2;
				if (nums[med] <= target)
				{
					left = med;
				}
				
				if (nums[med] >= target)
				{
					right = med;
				}
			}

			if (nums[left] == target)
			{
				return left;
			}

			if (nums[right] == target)
			{
				return right;
			}

			if (nums[left] > target)
			{
				return left;
			}

			if (nums[right] < target)
			{
				return right + 1;
			}

			return left + 1;
		}
	}
}