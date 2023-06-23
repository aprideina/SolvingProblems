using NUnit.Framework;
using SolvingProblems.Hard;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Hard
{
	public class Task839Test
	{
		private Task839 _sut = new Task839();

		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new string[]{ "tars","rats","arts","star" },
				2
			};
			yield return new object[]
			{
				new string[]{ "omv","ovm" },
				1
			};
			yield return new object[]
			{
				new string[]{ "ooo","ooo" },
				1
			};
		}

		[Theory, Ignore("Fix it")]
		[TestCaseSource(nameof(GetSource))]
		public void Test(string[] strs, int result)
		{
			var r = _sut.NumSimilarGroups(strs);
			Assert.AreEqual(r, result);
		}
	}
}
