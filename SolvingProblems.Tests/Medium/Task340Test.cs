using NUnit.Framework;
using SolvingProblems.Medium;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Medium
{
	public class Task340Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				"eceba", 2, 3
			};
			yield return new object[]
			{
				"aa", 1, 2
			};
			yield return new object[]
			{
				"a", 0, 0
			};
			yield return new object[]
			{
				"a", 1, 1
			};
			yield return new object[]
			{
				"a", 2, 1
			};
			yield return new object[]
			{
				"aba", 1, 1
			};
			yield return new object[]
			{
				"aaabbc", 2, 5
			};
			yield return new object[]
			{
				"bacc", 2, 3
			};
			yield return new object[]
			{
				"baberetrywcccccccca", 2, 9
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(string s, int k, int result)
		{
			var res = new Task340().Run(s, k);
			Assert.AreEqual(result, res);
		}
	}
}
	