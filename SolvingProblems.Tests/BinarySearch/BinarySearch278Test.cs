using Moq;
using NUnit.Framework;
using SolvingProblems.BinarySearch;

namespace SolvingProblems.Tests.BinarySearch
{
	public class BinarySearch278Test
	{
		private readonly BinarySearch278 _sut = new BinarySearch278();

		[Theory]
		[TestCase(1, 5)]
		[TestCase(2, 5)]
		[TestCase(3, 5)]
		[TestCase(4, 5)]
		[TestCase(5, 5)]
		[TestCase(21, 21)]
		[TestCase(1, 21)]
		[TestCase(9, 21)]
		[TestCase(10, 21)]
		[TestCase(11, 21)]
		[TestCase(12, 21)]
		public void Test(int target, int n)
		{
			var mock = new Mock<IBadVersion>();
			mock.Setup(x => x.isBadVersion(It.Is<int>(i => i >= target))).Returns(true);

			_sut.BadVersionService = mock.Object;

			var index = _sut.FirstBadVersion_NotWorked(n);
			Assert.AreEqual(target, index);
		}
	}
}