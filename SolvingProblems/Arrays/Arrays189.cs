namespace SolvingProblems.Arrays
{
	public class Arrays189
	{
		public void Rotate(int[] nums, int k)
		{
			var rotatesCycles = k % nums.Length;
			if (rotatesCycles == 0)
			{
				return;
			}

			var j = 0;
			var counter = 0;
			do
			{
				var stored2 = nums[j];
				var i = j;
				int nextIndex;
				do
				{
					nextIndex = (i + rotatesCycles) % nums.Length;
					var stored = nums[nextIndex];
					nums[nextIndex] = stored2;
					stored2 = stored;

					i = nextIndex;
					counter++;
				} while (nextIndex != j);

				j++;
			}while(counter != nums.Length);
		}
	}
}