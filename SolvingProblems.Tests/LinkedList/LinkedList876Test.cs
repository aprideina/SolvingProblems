using NUnit.Framework;
using SolvingProblems.LinkedList;

namespace SolvingProblems.Tests.LinkedList
{
	public class LinkedList876Test
	{
		private LinkedList876 _sut = new LinkedList876();

		[Test]
		public void Test()
		{
			var t5 = new LinkedList876.ListNode(5, new LinkedList876.ListNode(6));
			var t4 = new LinkedList876.ListNode(4, t5);
			var t3 = new LinkedList876.ListNode(3, t4);
			var t2 = new LinkedList876.ListNode(2, t3);
			var t = new LinkedList876.ListNode(1, t2);
			var result = _sut.MiddleNode(t);
			Assert.AreEqual(t4, result);
		}

		[Test]
		public void Test2()
		{
			var t5 = new LinkedList876.ListNode(5);
			var t4 = new LinkedList876.ListNode(4, t5);
			var t3 = new LinkedList876.ListNode(3, t4);
			var t2 = new LinkedList876.ListNode(2, t3);
			var t = new LinkedList876.ListNode(1, t2);
			var result = _sut.MiddleNode(t);
			Assert.AreEqual(t3, result);
		}

		[Test]
		public void Test_Single()
		{
			var t = new LinkedList876.ListNode(1);
			var result = _sut.MiddleNode(t);
			Assert.AreEqual(t, result);
		}

		[Test]
		public void Test_Two()
		{
			var t = new LinkedList876.ListNode(1, new LinkedList876.ListNode(2));
			var result = _sut.MiddleNode(t);
			Assert.AreEqual(t.next, result);
		}
	}
}