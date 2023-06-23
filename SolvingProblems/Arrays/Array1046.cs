namespace SolvingProblems.Arrays
{
	public class Array1046
	{
        public int LastStoneWeight(int[] stones)
        {
			int length = 1001;
			var indexes = new int[length];
			var max = 3;
            foreach(var st in stones)
			{
                indexes[st]++;
				max = max > st ? max : st + 1;
			}

			var r = max - 1;
			var l = max - 2;

			do
			{
				if (indexes[r] == 0)
				{
					r--;
				}

				if (indexes[l] == 0)
				{
					l--;
				}

				if (l == r)
				{
					l--;
				}

				if (indexes[l] > 0 && indexes[r] > 0)
				{
					indexes[r] = indexes[r] % 2;
					while (indexes[r] > 0) 
					{
						var result = r - l;
						indexes[l]--;
						indexes[r]--;

						indexes[result]++;
						l = l > result ? l : result;
					}
					r--;
				}
			}
			while (l > 0);
			indexes[r] = indexes[r] % 2;
			return indexes[r] == 0 ? 0 : r;
        }
    }
}
