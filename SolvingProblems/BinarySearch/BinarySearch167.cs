namespace SolvingProblems.BinarySearch
{
	public class BinarySearch167
	{
		public int[] TwoSum(int[] numbers, int target)
		{
			var left = 0;
			var right = numbers.Length - 1;

			do
			{
				var sum = numbers[left] + numbers[right];
				if (sum == target)
				{
					break;
				}

				if (sum > target)
				{
					right--;
				}

				if (sum < target)
				{
					left++;
				}

			} while (true);

			return new[] { left + 1, right + 1 };
		}

		//for (var i = 0; i < numbers.Length - 1; i++)
		//{
		//	for (var j = i + 1; j < numbers.Length; j++)
		//	{
		//		var sum = numbers[i] + numbers[j];
		//		if (sum == target)
		//		{
		//			return new[] { i + 1, j + 1 };
		//		}

		//		if (sum > target)
		//		{
		//			break;
		//		}
		//	}
		//}

		//return new[] {0, 0};
	}
}