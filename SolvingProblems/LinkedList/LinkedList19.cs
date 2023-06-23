namespace SolvingProblems.LinkedList
{
	public class LinkedList19
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			if (n == 1 && head.next == null)
			{
				return null;
			}

			Recurse(head, head.next, 2, n, out var end);

			return n == end ? head.next : head;
		}

		private void Recurse(ListNode parent, ListNode child, int step, int n, out int end)
		{
			if (child.next == null)
			{
				end = step;
			}
			else
			{
				Recurse(child, child.next, step + 1, n, out end);
			}

			var i = end + 1- n;
			if (step == i)
			{
				parent.next = child.next;
			}
		}

		public class ListNode
		{
			public ListNode next;
			public int val;

			public ListNode(int val = 0, ListNode next = null)
			{
				this.val = val;
				this.next = next;
			}
		}
	}
}