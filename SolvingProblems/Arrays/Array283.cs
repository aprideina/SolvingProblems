namespace SolvingProblems.Arrays
{
	public class Array283
	{
		public void MoveZeroes(int[] nums)
		{
			var index = 0;
			var counter = 0;
			var zeroCount = 0;

			while (counter != nums.Length)
			{
				nums[index] = nums[index + zeroCount];
				if (nums[index] == 0)
				{
					zeroCount++;
				}
				else
				{
					index++;
				}

				counter++;
			}

			for (int i = 1; i <= zeroCount; i++)
			{
				nums[nums.Length - i] = 0;
			}
		}
	}
}