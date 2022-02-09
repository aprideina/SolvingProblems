using System;
using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Arrays
{
	public class Array349
	{
		public int[] Intersection(int[] nums1, int[] nums2)
		{
			var result = new Boolean[1001];
			HashSet<int> _index = new HashSet<int>(1001);

			if (nums1.Length > nums2.Length)
			{
				return Intersection(nums2, nums1);
			}

			foreach (var i1 in nums1)
			{
				result[i1] = true;
			}

			foreach (var i2 in nums2)
			{
				if (result[i2])
				{
					_index.Add(i2);
				}
			}
			
			return _index.ToArray();
		}
	}
}