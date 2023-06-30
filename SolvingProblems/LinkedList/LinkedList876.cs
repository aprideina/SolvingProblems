using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.LinkedList;

public class LinkedList876 : ISolvingProblemTaskWithResult<LinkedList876.ListNode, LinkedList876.ListNode>
{
    private void Recurse(ListNode node, out ListNode result, int step, out int mid)
    {
        if (node.next != null)
        {
            Recurse(node.next, out result, step + 1, out mid);
            if (step == mid) result = node;
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

    public ListNode Run(ListNode input)
    {
        if (input.next == null) return input;

        Recurse(input, out var result, 1, out _);
        return result;
    }

    public IEnumerable<TestCasesDto<ListNode, ListNode>> TestCases()
    {
        var testCase1 = new ListNode(1);
        yield return new TestCasesDto<ListNode, ListNode>
        {
            Input = testCase1,
            Expected = testCase1
        };
        
        var testCase2 = new ListNode(1, new ListNode(2));
        yield return new TestCasesDto<ListNode, ListNode>
        {
            Input = testCase2,
            Expected = testCase2.next
        };

        yield return TestCase3();
        yield return TestCase4();
    }
    
    private TestCasesDto<ListNode, ListNode> TestCase3()
    {
        var t5 = new LinkedList876.ListNode(5);
        var t4 = new LinkedList876.ListNode(4, t5);
        var t3 = new LinkedList876.ListNode(3, t4);
        var t2 = new LinkedList876.ListNode(2, t3);
        var t = new LinkedList876.ListNode(1, t2);

        return new TestCasesDto<ListNode, ListNode>
        {
            Expected = t3,
            Input = t
        };
    }
    
    private TestCasesDto<ListNode, ListNode> TestCase4()
    {
        var t5 = new LinkedList876.ListNode(5, new LinkedList876.ListNode(6));
        var t4 = new LinkedList876.ListNode(4, t5);
        var t3 = new LinkedList876.ListNode(3, t4);
        var t2 = new LinkedList876.ListNode(2, t3);
        var t = new LinkedList876.ListNode(1, t2);

        return new TestCasesDto<ListNode, ListNode>
        {
            Expected = t4,
            Input = t
        };
    }
}