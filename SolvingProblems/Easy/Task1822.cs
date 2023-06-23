namespace SolvingProblems.Easy
{
	public class Task1822
	{
		public int ArraySign(int[] nums)
		{
			var res = false;
			foreach (var n in nums)
			{
				if(n == 0)
				{
					return 0;
				}
				res ^= n < 0;
			}

			return res == true ? -1 : 1;
		}
	}
}
