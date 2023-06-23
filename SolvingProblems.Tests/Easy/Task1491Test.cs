using NUnit.Framework;
using SolvingProblems.Easy;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Easy
{
	public class Task1491Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new int[]{ 4000,3000,1000,2000 },
				2500.00000
			};
			yield return new object[]
			{
				new int[]{ 1000,2000,3000 },
				2000.00000
			};
			yield return new object[]
			{
				new int[]{ 48000,59000,99000,13000,78000,45000,31000,17000,39000,37000,93000,77000,33000,28000,4000,54000,67000,6000,1000,11000 },
				41111.11111
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[] salary, double result)
		{
			var sut = new Task1491();
			var r = sut.Average(salary);
			Assert.AreEqual(result, r);
		}
	}
}
