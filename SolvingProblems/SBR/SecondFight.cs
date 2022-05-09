using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.SBR
{
	public class SecondFight
	{
		public static List<int> GetResult(List<int> numb)
		{
			var sums = new List<(int, List<int>)>();

			var left = 0;
			var right = 1;

			var currentSum = numb[left];
			var pos = numb[left] > 0;

			while (right != numb.Count)
			{
				var currentPos = numb[right] > 0;
				if (currentPos != pos)
				{
					var range = numb.GetRange(left, right - left);
					sums.Add((currentSum, range));

					left = right;
					right = left;
					currentSum = 0;
					pos = currentPos;
				}

				currentSum += numb[right];
				right++;
			}

			sums.Add((currentSum, numb.GetRange(left, right - left)));

			var result = numb;
			var maxValue = numb.Sum();

			var leftSum = 0;
			for (var i = 0; i < sums.Count - 1; i++)
			{
				leftSum += sums[i].Item1;

				var rightSum = 0;
				for (var j = i + 1; j < sums.Count; j++)
				{
					rightSum += sums[j].Item1;
				}

				if (leftSum > maxValue)
				{
					result = sums.Where((i1, i2) => i2 <= i).SelectMany(x => x.Item2).ToList();
					maxValue = leftSum;
				}

				if (rightSum > maxValue)
				{
					result = sums.Where((i1, i2) => i2 >= i + i).SelectMany(x => x.Item2).ToList();
					maxValue = rightSum;
				}
			}

			if (sums.Count == 1)
			{
				var enumerable = sums.First().Item2;
				if (enumerable.First() < 0)
				{
					foreach (var i in enumerable)
					{
						if (i > maxValue)
						{
							result = new List<int> { i };
						}
					}
				}
				else
				{
					return numb;
				}
			}

			return result;
		}
	}
}
