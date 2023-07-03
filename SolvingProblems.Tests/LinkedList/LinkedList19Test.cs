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
			var t5 = new ListNode(5);
			var t4 = new ListNode(4, t5);
			var t3 = new ListNode(3, t4);
			var t2 = new ListNode(2, t3);
			var t = new ListNode(1, t2);

			var res = _sut.RemoveNthFromEnd(t, 2);
			Assert.AreEqual(5, res.next.next.next.val);
		}

		[Test]
		public void Test_First()
		{
			var t2 = new ListNode(2);
			var t = new ListNode(1, t2);

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
			var t2 = new ListNode(2);
			var t = new ListNode(1, t2);

			var res = _sut.RemoveNthFromEnd(t, 1);
			Assert.AreEqual(null, res.next);
			Assert.AreEqual(t.val, res.val);
		}

		[Test]
		public void Test_Three()
		{
			var t3 = new ListNode(3);
			var t2 = new ListNode(2, t3);
			var t = new ListNode(1, t2);

			var res = _sut.RemoveNthFromEnd(t, 1);
			Assert.AreEqual(null, res.next.next);
		}
	}
}