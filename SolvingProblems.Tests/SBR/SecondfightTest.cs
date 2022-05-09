using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.SBR;

namespace SolvingProblems.Tests.SBR
{
	public class SecondFightTest
	{
		[Test]
		public void Test()
		{
			//var numb = new List<int> { 10, 30, 40 };
			var numb = new List<int> {4, 2, 8, -5, 2};
			//var numb = new List<int> { 2, 4, -5, 3, 3, -7, 5, 1 };
			var res = SecondFight.GetResult(numb);
			//Assert.AreEqual(new List<int> { 80 }, res);

			Assert.AreEqual(new List<int> {4, 2, 8}, res);

			//Assert.AreEqual(new List<int> { 2, 4, -5, 3, 3 }, res);
		}
	}
}