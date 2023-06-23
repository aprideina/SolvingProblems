using NUnit.Framework;
using SolvingProblems.Easy;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Easy
{
	public class Task2215Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new int[]{ 1,2,3 },
				new int[]{ 2,4,6 },
				new List<IList<int>>()
				{
					new List<int>{ 1, 3 },
					new List<int>{ 4, 6 }
				}
			};
			yield return new object[]
			{
				new int[]{ 1,2,3,3 },
				new int[]{ 1,1,2,2 },
				new List<IList<int>>()
				{
					new List<int>{ 3 },
					new List<int>{ }
				}
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[] nums1, int[] nums2, IList<IList<int>> result)
		{
			var sut = new Task2215();
			var r = sut.FindDifference(nums1, nums2);
			Assert.AreEqual(result, r);
		}
	}
}
