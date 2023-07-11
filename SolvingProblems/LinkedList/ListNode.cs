using System;

namespace SolvingProblems.LinkedList;

public class ListNode : IEquatable<ListNode>
{
    public ListNode next;
    public int val;

    public ListNode(params int[] values)
    {
        val = values[0];
        var node = this;
        for (var i = 1; i < values.Length; i++)
        {
            node.next = new ListNode(values[i]);
            node = node.next;
        }
    }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public bool Equals(ListNode other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return val == other.val;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ListNode)obj);
    }

    public override int GetHashCode()
    {
        return val;
    }
}