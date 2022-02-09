using System;

namespace SolvingProblems.BinarySearch
{
	/// <summary>
	///     https://leetcode.com/problems/first-bad-version/
	/// </summary>
	public class BinarySearch278
	{
		public IBadVersion BadVersionService { get; set; }

		public int FirstBadVersion_NotWorked(int n)
		{
			var left = 0;
			var right = n;

			while (left < right)
			{
				var med = (left + right) / 2;
				var bad = BadVersionService.isBadVersion(med);

				if (bad)
				{
					right = med;
				}
				else
				{
					left = med + 1;
				}

			}

			return left;
		}

		public int FirstBadVersion_Success(int n)
		{
			var left = 1;
			var right = n;

			var result = n;

			while (left < right)
			{
				var diff = (right - left + 1) / 2;

				var middle = left + diff;

				var isBad = BadVersionService.isBadVersion(middle);

				if (!isBad)
				{
					left += diff;
				}
				else
				{
					right -= diff;
					result = middle;
				}
			}

			return BadVersionService.isBadVersion(left) ? left : result;
		}

		public int FirstBadVersion_NotWorked2(int n)
		{
			var index = 1.0;
			while (!BadVersionService.isBadVersion((int) Math.Pow(2, index)))
			{
				index++;
			}
			
			var left = (int)Math.Pow(2, index - 1);
			var right = (int)Math.Pow(2, index);

			while (left < right)
			{
				var med = (left + right) / 2;
				var bad = BadVersionService.isBadVersion(med);

				if (!bad)
				{
					left = med + 1;
				}
				else
				{
					right = med;
				}
			}

			return left;
		}
	}
}