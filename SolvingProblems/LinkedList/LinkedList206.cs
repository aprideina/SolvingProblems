using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.LinkedList;

public class LinkedList206 : ISolvingProblemTaskWithResult<ListNode, ListNode>
{
    public ListNode Run(ListNode head)
    {
        ListNode prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    public IEnumerable<TestCasesDto<ListNode, ListNode>> TestCases()
    {
        yield return TestCase3();
        
        var expected = new ListNode(2, 1);
        var testCase = new ListNode(1, 2);
        yield return new TestCasesDto<ListNode, ListNode>
        {
            Input = testCase,
            Expected = expected
        };

        var expected1 = new ListNode(3, 2, 1);
        var testCase1 = new ListNode(1, 2, 3);
        yield return new TestCasesDto<ListNode, ListNode>
        {
            Input = testCase1,
            Expected = expected1
        };

        yield return TestCase2();

        yield return new TestCasesDto<ListNode, ListNode>
        {
            Input = null,
            Expected = null
        };
    }

    private static TestCasesDto<ListNode, ListNode> TestCase2()
    {
        var expected2 = new ListNode();
        var testCase2 = new ListNode();
        return new TestCasesDto<ListNode, ListNode>
        {
            Input = expected2,
            Expected = testCase2
        };
    }

    private static TestCasesDto<ListNode, ListNode> TestCase3()
    {
        var expected2 = new ListNode(1, 2, 3, 4, 5);
        var testCase2 = new ListNode(5, 4, 3, 2, 1);
        return new TestCasesDto<ListNode, ListNode>
        {
            Input = expected2,
            Expected = testCase2
        };
    }
}