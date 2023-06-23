using NUnit.Framework;
using SolvingProblems.Medium;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Medium
{
	public class Task649Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				"RD", "Radiant"
			};
			yield return new object[]
			{
				"RDD", "Dire"
			};
			yield return new object[]
			{
				"DDR", "Dire"
			};
		}

		[Theory, Ignore("Fix it")]
		[TestCaseSource(nameof(GetSource))]
		public void Test(string senate, string result)
		{
			var sut = new Task649();
			var r = sut.PredictPartyVictory(senate);
			Assert.AreEqual(result, r);
		}
	}
}
