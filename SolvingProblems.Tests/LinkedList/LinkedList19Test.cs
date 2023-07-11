using NUnit.Framework;
using SolvingProblems.LinkedList;

namespace SolvingProblems.Tests.LinkedList
{
	public class LinkedList19Test
	{
		private readonly LinkedList19 _sut = new LinkedList19();

		[Test]
		public void Test()
		{
			var t = new ListNode(1, 2, 3, 4, 5);

			var res = _sut.RemoveNthFromEnd(t, 2);
			Assert.AreEqual(5, res.next.next.next.val);
		}

		[Test]
		public void Test_First()
		{
			var t = new ListNode(1, 2);

			var res = _sut.RemoveNthFromEnd(t, 2);
			Assert.AreEqual(2, res.val);
		}

		[Test]
		public void Test_Single()
		{
			var t = new ListNode(1);

			var res = _sut.RemoveNthFromEnd(t, 1);
			Assert.AreEqual(null, res);
		}

		[Test]
		public void Test_Two()
		{
			var t = new ListNode(1, 2);

			var res = _sut.RemoveNthFromEnd(t, 1);
			Assert.AreEqual(null, res.next);
			Assert.AreEqual(t.val, res.val);
		}

		[Test]
		public void Test_Three()
		{
			var t = new ListNode(1, 2, 3);

			var res = _sut.RemoveNthFromEnd(t, 1);
			Assert.AreEqual(null, res.next.next);
		}
	}
}