using Algorithms.Puzzles.Easy;
using DataStructures;
using Xunit;

namespace Algorithms.UnitTests.Puzzles.Easy;

public class ReverseLinkedListTests
{
    [Theory]
    [MemberData(nameof(GenerateLinkedList), new[] { 1, 2, 3, 4, 5 })]
    public void ReverseList(ListNode? head)
    {
        var result = ReverseLinkedList.ReverseListLoop(head);

    }

    public static TheoryData<ListNode?> GenerateLinkedList(int[] values)
    {
        var data = new TheoryData<ListNode?>();

        var dummyHead = new ListNode(); // Dummy head node
        var current = dummyHead;

        foreach (var value in values)
        {
            current.Next = new ListNode(value);
            current = current.Next;
        }

        data.Add(dummyHead.Next);

        return data;
    }
}
