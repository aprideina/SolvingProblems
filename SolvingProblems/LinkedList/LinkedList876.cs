namespace SolvingProblems.LinkedList
{
	public class LinkedList876
	{
		public ListNode MiddleNode(ListNode head)
		{
			if (head.next == null)
			{
				return head;
			}

			Recurse(head, out ListNode result, 1, out _);
			return result;
		}

		private void Recurse(ListNode node, out ListNode result, int step, out int mid)
		{
			if (node.next != null)
			{
				Recurse(node.next, out result, step + 1, out mid);
				if (step == mid)
				{
					result = node;
				}
			}
			else
			{
				result = node;
				mid = step / 2 + 1;
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