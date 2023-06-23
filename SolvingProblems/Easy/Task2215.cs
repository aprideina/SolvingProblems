using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Easy
{
	public class Task2215
	{
		public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
		{
			var t1 = nums1.ToList().Except(nums2).ToList();
			var t2 = nums2.ToList().Except(nums1).ToList();
			IList<IList<int>> list = new List<IList<int>>() { t1, t2 };
			return list;
		}
	}
}
